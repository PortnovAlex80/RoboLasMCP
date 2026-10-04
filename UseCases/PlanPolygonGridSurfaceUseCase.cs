// UseCases/PlanPolygonGridSurfaceUseCase.cs
// Построение поверхности по сетке внутри полигонов плана
// Фильтрует точки LiDAR по полигонам и строит регулярную сетку min-Z
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
    /// Построение ЦММ по сетке внутри полигонов плана.
    /// Фильтрует точки LiDAR по нарисованным полигонам и строит регулярную сетку min-Z.
    /// </summary>
    [SectionCmd("plan_polygon_grid_surface")]
    public class PlanPolygonGridSurfaceUseCase : ISectionUseCase
    {
        public string Name => "plan_polygon_grid_surface";

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
            List<Vector3D> groundPoints;
            List<Vector3D> feats;
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
                    "[PlanPolygonGridSurface] Loaded polygons: {0}", polygons.Count));

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

                // Сбор min-Z по сетке внутри полигонов
                double gridStep = settings.GridStep;
                try { groundPoints = CollectGroundMinZInPolygonsParallel(buffers, polygons, polygonBounds, gridStep, scanState); }
                catch (Exception ex)
                {
                    MessageDlg.Show("Ошибка чтения точек LiDAR: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                if (scanState.Cancelled) return;

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonGridSurface] Ground points collected: {0}", groundPoints.Count));

                // Детекция特征 (features) - брови/канавы
                feats = GridFeatureDetector.DetectFeatures(
                    groundPoints, polygonBounds, gridStep,
                    /*smallRadiusMeters:*/ 0.3,
                    /*largeRadiusMeters:*/ 0.9,
                    /*dogThreshold:*/ 0.02,
                    /*slopeThreshold:*/ 0.10,
                    GridFeatureDetector.Mode.Both);

                System.Diagnostics.Debug.WriteLine(string.Format(
                    "[PlanPolygonGridSurface] Features detected: {0}", feats.Count));
            }

            // Вставка в поверхность
            if (!polygonContext.IsSourceCurrent() ||
                !polygonContext.IsSnapshotCurrent(polygonSnapshot))
            {
                MessageDlg.Show("Проект, источник LiDAR или полигоны изменились; результат не применён.");
                return;
            }
            try { target.Apply(feats); }
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
            int inserted = feats.Count;

            MessageDlg.Show(string.Format(
                "Построение ЦММ по полигонам завершено!\n\n" +
                "Полигонов: {0}\n" +
                "Точек в облаке: {1:N0}\n" +
                "Опорных точек (сетка): {2:N0}\n" +
                "Характерных точек: {3:N0}\n" +
                "Вставлено в поверхность: {4:N0}",
                polygons.Count, totalPoints, groundPoints.Count, feats.Count, inserted),
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);

            // Обновляем отображение
            env.CadView?.Unlock();
            env.CadView?.Invalidate();
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

            var idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;

            scanState.Execute("Подсчёт точек в полигонах...", idxs, i =>
                {
                    if (scanState.WorkerShouldStop()) return;

                    var buf = buffers[i];
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
        /// Параллельный сбор опорных точек (min-Z по сетке) внутри полигонов.
        /// </summary>
        private List<Vector3D> CollectGroundMinZInPolygonsParallel(
            IList<LidarBuffer> buffers,
            List<PlanPolygonEntry> polygons,
            BoundingBox2D bounds,
            double gridStep,
            PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0 || gridStep <= 0)
                return new List<Vector3D>();

            double x0 = bounds.Min.X;
            double y0 = bounds.Min.Y;

            var global = new GridMinZAccumulator(x0, y0, gridStep, 1 << 16);

            int n = buffers.Count;
            // Equal-Z cells keep the first point. Merge in buffer order so the
            // winner does not depend on worker completion order.
            var bufferCells = new List<Vector3D>[n];
            var idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;

            scanState.Execute("Сбор опорных точек (по полигонам)...", idxs, i =>
                {
                    if (scanState.WorkerShouldStop()) return;

                    var buf = buffers[i];
                    if (buf == null || buf.indexers == null) return;

                    var local = new GridMinZAccumulator(x0, y0, gridStep, 1 << 14);

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

                            local.Add(wx, wy, wz);
                        }
                    }

                    if (scanState.WorkerShouldStop()) return;
                    // Retain only populated cells, not each accumulator's
                    // preallocated dictionary, until the ordered merge.
                    bufferCells[i] = local.ToList();
                });

            if (scanState.Cancelled) return new List<Vector3D>();
            for (int i = 0; i < n; i++)
            {
                if (bufferCells[i] == null) continue;
                foreach (Vector3D point in bufferCells[i])
                    global.Add(point.X, point.Y, point.Z);
                bufferCells[i] = null;
            }
            return global.ToList();
        }

    }
}
