// UseCases/PlanPolygonPolynomialSurfaceUseCase.cs
// Построение поверхности по полиномиальной подгонке внутри полигонов плана
// Фильтрует точки LiDAR по полигонам и строит полиномиальную поверхность
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Service;
using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;
using Topomatic.FoundationClasses.Parallel;
using Topomatic.Lidar;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.UseCases
{
    /// <summary>
    /// Построение ЦММ по полиномиальной подгонке внутри полигонов плана.
    /// Фильтрует точки LiDAR по нарисованным полигонам и строит полиномиальную поверхность Z = f(x,y).
    /// </summary>
    [SectionCmd("plan_polygon_polynomial_surface")]
    public class PlanPolygonPolynomialSurfaceUseCase : ISectionUseCase
    {
        public string Name
        {
            get { return "plan_polygon_polynomial_surface"; }
        }

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;

            var surfaceLayer = UserDialogs.GetSurfaceLayerOrShow(env.CadView);
            if (surfaceLayer == null) return;
            PlanSurfaceSettings settings = RuntimeConfig.CapturePlanSurfaceSettings();
            ScopedPolygonOperationContext polygonContext;
            ScopedPolygonSnapshot polygonSnapshot;
            try
            {
                polygonContext = ScopedPolygonOperationContext.Capture(
                    env.CadView, PolygonGeometryKind.Plan);
                if (polygonContext == null)
                    throw new InvalidOperationException("Не удалось зафиксировать проект и трассу.");
                if (!polygonContext.TryRead(out polygonSnapshot)) return;
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка загрузки полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            List<PlanPolygonEntry> polygons = new List<PlanPolygonEntry>();
            foreach (ScopedPolygonRecord record in polygonSnapshot.Records)
            {
                PlanPolygonEntry entry = new PlanPolygonEntry();
                entry.CreatedAt = record.CreatedAt;
                foreach (Vector2D point in record.Polygon)
                    entry.Polygon.Add(new Vector2D(point.X, point.Y));
                polygons.Add(entry);
            }
            if (polygons.Count == 0)
            {
                MessageDlg.Show("Нет собранных полигонов.\nСначала нарисуйте полигоны командой plan_draw_polygon.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }
            long totalPoints;
            int degree;
            List<Vector3D> surfacePoints;
            // Инициализируем коллекцию полигонов
            PlanSurfaceTarget target;
            using (var source = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                Alignment alignment = source.Alignment;
                List<LidarBuffer> sourceBuffers = alignment == null ? null :
                    LidarBufferService.CollectBuffers(alignment);
                target = PlanSurfaceTarget.Capture(env.CadView, surfaceLayer,
                    alignment, sourceBuffers);
                if (target == null || !polygonContext.MatchesCapturedSource(alignment,
                    sourceBuffers))
                {
                    MessageDlg.Show("Не удалось зафиксировать трассу, поверхность или путь к полигонам.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonPolynomialSurface] Loaded polygons: {0}", polygons.Count));

                // Проверяем захваченный контекст перед чтением его буферов
                if (!target.IsCurrent(source.Alignment))
                {
                    MessageDlg.Show("Трасса, проект, окно или поверхность изменились во время подготовки. Результат не применён.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                List<LidarBuffer> buffers = target.Buffers;

                // Вычисляем границы по полигонам (объединение)
                BoundingBox2D polygonBounds;
                if (!TryComputePolygonBounds(polygons, out polygonBounds))
                {
                    MessageDlg.Show("Не удалось вычислить границы полигонов.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                // Подсчёт точек внутри полигонов
                var scanState = new PlanPolygonScanState();
                try { totalPoints = CountPointsInPolygonsParallel(buffers, polygons, scanState); }
                catch (Exception ex)
                {
                    MessageDlg.Show("Ошибка чтения точек LiDAR: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                if (scanState.Cancelled) return;
                if (totalPoints == 0)
                {
                    MessageDlg.Show("Точек внутри полигонов не найдено.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }

                // Сбор всех точек внутри полигонов
                List<Vector3D> allPoints;
                try { allPoints = CollectAllPointsInPolygonsParallel(buffers, polygons, scanState); }
                catch (Exception ex)
                {
                    MessageDlg.Show("Ошибка чтения точек LiDAR: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                if (scanState.Cancelled) return;

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonPolynomialSurface] Points collected: {0}", allPoints.Count));

                // Проверяем минимальное количество точек для полиномиальной подгонки
                degree = settings.PolynomialDegree;
                int minPointsRequired = (degree + 1) * (degree + 2) / 2;

                if (allPoints.Count < minPointsRequired)
                {
                    MessageDlg.Show(string.Format(
                        "Недостаточно точек для полиномиальной подгонки.\n" +
                        "Требуется: {0}\n" +
                        "Найдено: {1}",
                        minPointsRequired, allPoints.Count),
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                // Подгонка полиномиальной поверхности
                double regularization = settings.PolynomialRegularization;
                double gridStep = settings.PolynomialGridStep;

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonPolynomialSurface] Fitting polynomial: degree={0}, lambda={1}, step={2}",
                    degree, regularization, gridStep));

                try
                {
                    surfacePoints = PolynomialSurfaceFitter.FitSurface(
                        allPoints, degree, regularization, gridStep, polygonBounds);
                }
                catch (System.Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "[PlanPolygonPolynomialSurface] FitSurface error: " + ex.Message);
                    MessageDlg.Show("Ошибка подгонки полиномиальной поверхности: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonPolynomialSurface] Surface points generated: {0}", surfacePoints.Count));
            }

            // Вставка в поверхность
            if (!polygonContext.IsSourceCurrent() ||
                !polygonContext.IsSnapshotCurrent(polygonSnapshot))
            {
                MessageDlg.Show("Проект, источник LiDAR или полигоны изменились; результат не применён.");
                return;
            }
            try { target.Apply(surfacePoints); }
            catch (Exception error)
            {
                Exception cause = error is System.Reflection.TargetInvocationException &&
                    error.InnerException != null ? error.InnerException : error;
                SurfaceApplyException applyError = cause as SurfaceApplyException;
                string detail = applyError != null && applyError.UpdateStateUnknown
                    ? " Состояние обновления поверхности в SDK требует проверки." : "";
                MessageDlg.Show("Не удалось завершить запись результата: " + cause.Message + detail,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            int inserted = surfacePoints.Count;

            MessageDlg.Show(string.Format(
                "Построение ЦММ по полигонам (полином) завершено!\n\n" +
                "Полигонов: {0}\n" +
                "Точек в облаке: {1:N0}\n" +
                "Степень полинома: {2}\n" +
                "Точек поверхности: {3:N0}\n" +
                "Вставлено в поверхность: {4:N0}",
                polygons.Count, totalPoints, degree, surfacePoints.Count, inserted),
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);

            // Обновляем отображение
            if (env.CadView != null)
            {
                env.CadView.Unlock();
                env.CadView.Invalidate();
                }
        }

        /// <summary>
        /// Вычисляет объединённые границы всех полигонов.
        /// </summary>
        private bool TryComputePolygonBounds(List<PlanPolygonEntry> polygons, out BoundingBox2D bounds)
        {
            return PolygonBounds.TryCompute(polygons, out bounds);
        }

        /// <summary>
        /// Проверка попадания точки в любой полигон (Ray Casting, БЕЗ Z).
        /// </summary>
        private bool IsPointInsideAnyPolygon(double x, double y, List<PlanPolygonEntry> polygons)
        {
            foreach (var entry in polygons)
            {
                if (IsPointInsidePolygon(x, y, entry.Polygon))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка попадания точки в полигон (Ray Casting algorithm).
        /// </summary>
        private bool IsPointInsidePolygon(double x, double y, List<Vector2D> polygon)
        {
            return PolygonGeometry.Contains(x, y, polygon);
        }

        /// <summary>
        /// Параллельный подсчёт точек внутри полигонов.
        /// </summary>
        private long CountPointsInPolygonsParallel(IList<LidarBuffer> buffers, List<PlanPolygonEntry> polygons,
            PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0 || polygons == null || polygons.Count == 0)
                return 0;

            long total = 0;
            object sumSync = new object();
            int n = buffers.Count;

            int[] idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;

            scanState.Execute("Подсчёт точек в полигонах...", idxs, i =>
                {
                    if (scanState.WorkerShouldStop()) return;

                    LidarBuffer buf = buffers[i];
                    if (buf == null || buf.indexers == null) return;

                    long local = 0;
                    foreach (QuadTreeIndexer indexer in buf.indexers)
                    {
                        if (scanState.WorkerShouldStop()) return;
                        if (indexer == null || indexer.points == null) continue;
                        Vector3F[] points = indexer.points.GetBuffer();
                        int count = indexer.points.Count;

                        double scaleX = indexer.scale.X;
                        double scaleY = indexer.scale.Y;
                        double posX = indexer.position.X;
                        double posY = indexer.position.Y;

                        for (int k = 0; k < count; k++)
                        {
                            if ((k & 1023) == 0 && scanState.WorkerShouldStop()) return;
                            double wx = points[k].X * scaleX + posX;
                            double wy = points[k].Y * scaleY + posY;

                            if (IsPointInsideAnyPolygon(wx, wy, polygons))
                                local++;
                        }
                    }

                    if (scanState.WorkerShouldStop()) return;
                    lock (sumSync) { total += local; }
                });

            return total;
        }

        /// <summary>
        /// Параллельный сбор всех точек внутри полигонов для полиномиальной подгонки.
        /// </summary>
        private List<Vector3D> CollectAllPointsInPolygonsParallel(
            IList<LidarBuffer> buffers,
            List<PlanPolygonEntry> polygons,
            PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0)
                return new List<Vector3D>();

            int n = buffers.Count;
            // Keep the fit's accumulation order independent of worker completion.
            // Floating-point normal equations depend on the input order.
            var bufferPoints = new List<Vector3D>[n];

            int[] idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;

            scanState.Execute("Сбор точек (по полигонам)...", idxs, i =>
                {
                    if (scanState.WorkerShouldStop()) return;

                    LidarBuffer buf = buffers[i];
                    if (buf == null || buf.indexers == null) return;

                    var local = new List<Vector3D>();

                    foreach (QuadTreeIndexer indexer in buf.indexers)
                    {
                        if (scanState.WorkerShouldStop()) return;
                        if (indexer == null || indexer.points == null) continue;
                        Vector3F[] points = indexer.points.GetBuffer();
                        int count = indexer.points.Count;

                        double scaleX = indexer.scale.X;
                        double scaleY = indexer.scale.Y;
                        double scaleZ = indexer.scale.Z;
                        double posX = indexer.position.X;
                        double posY = indexer.position.Y;
                        double posZ = indexer.position.Z;

                        for (int k = 0; k < count; k++)
                        {
                            if ((k & 1023) == 0 && scanState.WorkerShouldStop()) return;
                            double wx = points[k].X * scaleX + posX;
                            double wy = points[k].Y * scaleY + posY;
                            double wz = points[k].Z * scaleZ + posZ;

                            // Фильтр по полигонам
                            if (!IsPointInsideAnyPolygon(wx, wy, polygons))
                                continue;

                            local.Add(new Vector3D(wx, wy, wz));
                        }
                    }

                    if (scanState.WorkerShouldStop()) return;
                    bufferPoints[i] = local;
                });

            if (scanState.Cancelled) return new List<Vector3D>();
            long total = 0;
            for (int i = 0; i < n; i++)
                if (bufferPoints[i] != null) total += bufferPoints[i].Count;
            if (total > int.MaxValue)
                throw new OutOfMemoryException("The polygon point count exceeds List capacity.");
            var allPoints = new List<Vector3D>((int)total);
            for (int i = 0; i < n; i++)
            {
                if (bufferPoints[i] == null) continue;
                allPoints.AddRange(bufferPoints[i]);
                bufferPoints[i] = null;
            }
            return allPoints;
        }

    }
}
