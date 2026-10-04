// UseCases/PlanDeletePointsUseCase.cs
// Массовое удаление точек по собранным полигонам на виде сверху (Plan view)
// Результат: новый LAS 1.2 Point Format 1; .ldr не модифицируются.
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Visualization;
using System;
using System.Collections.Generic;
using System.IO;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Design;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;
using Topomatic.Lidar;

namespace LAS_TERRAIN.UseCases
{
    /// <summary>
    /// Массовое удаление точек по собранным полигонам на виде сверху (Plan view).
    /// Проверка попадания точки в полигон — БЕЗ Z.
    /// Пишет новый LAS 1.2 Point Format 1. Оригинальные .ldr не трогает.
    /// </summary>
    [SectionCmd("plan_delete_points")]
    public class PlanDeletePointsUseCase : ISectionUseCase
    {
        public string Name => "plan_delete_points";

        public void Run(SectionEnv env)
        {
            CadView planCv = env == null ? null : env.CadView;
            ScopedPolygonOperationContext context;
            ScopedPolygonSnapshot polygonSnapshot;
            PlanOverlayLayer overlayLayer;
            try
            {
                context = ScopedPolygonOperationContext.Capture(planCv, PolygonGeometryKind.Plan);
                if (context == null)
                    throw new InvalidOperationException("Не удалось зафиксировать проект и трассу.");
                if (!context.TryRead(out polygonSnapshot)) return;
                overlayLayer = planCv[PlanOverlayLayer.GUID] as PlanOverlayLayer;
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[PlanDeletePoints] Init error: " + ex.Message);
                MessageDlg.Show("Ошибка инициализации коллекции полигонов: " + ex.Message,
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
                MessageDlg.Show("Нет собранных полигонов для удаления.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Debug.WriteLine(string.Format(
                "[PlanDeletePoints] Loaded polygons: {0}", polygons.Count));

            System.Windows.Forms.DialogResult confirm = System.Windows.Forms.MessageBox.Show(
                "Удалить точки по всем собранным полигонам (Plan view)?\nРезультат будет сохранён в новый LAS-файл.",
                "Удаление точек",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question);
            if (confirm != System.Windows.Forms.DialogResult.Yes) return;
            if (!IsCurrent(context, planCv, overlayLayer))
            {
                ShowChangedContext();
                return;
            }

            string outputPath = UserDialogs.GetSaveFilePath("Сохранить отфильтрованный LAS-файл");
            if (string.IsNullOrEmpty(outputPath)) return;
            if (!IsCurrent(context, planCv, overlayLayer))
            {
                ShowChangedContext();
                return;
            }

            PreparedLasFile prepared = null;
            bool noMatch = false;
            bool changedSource = false;
            long totalDeleted = 0;
            long totalKept = 0;
            try
            {
            // Keep the receiver alive while borrowing LiDAR arrays. No nested
            // active-alignment receiver is opened in the progress callback.
            using (ActiveAlignmentReciver<Alignment> receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                Alignment alg = receiver.Alignment;
                if (alg == null)
                {
                    MessageDlg.Show("Сделайте трассу активной.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                // Собираем буферы
                List<LidarBuffer> buffers = LidarBufferService.CollectBuffers(alg);
                if (buffers == null || buffers.Count == 0 ||
                    !context.MatchesCapturedSource(alg, buffers))
                {
                    ShowChangedContext();
                    return;
                }

                List<QuadTreeIndexer> indexerList = new List<QuadTreeIndexer>();
                foreach (LidarBuffer buffer in buffers)
                {
                    if (buffer == null || buffer.indexers == null) continue;
                    foreach (QuadTreeIndexer indexer in buffer.indexers)
                        if (indexer != null && indexer.points != null)
                            indexerList.Add(indexer);
                }
                if (indexerList.Count == 0)
                {
                    MessageDlg.Show("Нет данных LiDAR для обработки.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                var scanState = new PlanPolygonScanState();
                int foundDeletion = 0;
                try
                {
                    WaitProgress.BeginProgress("Удаление точек, запись LAS...", () =>
                    {
                        // The preflight only needs one match. It creates no output file.
                        try
                        {
                            ParallelWorkRunner.Run(indexerList.Count, true,
                                delegate(int index, WorkCancellation stop)
                                {
                                    try
                                    {
                                        if (stop.IsCancellationRequested ||
                                            scanState.WorkerShouldStop() ||
                                            System.Threading.Thread.VolatileRead(ref foundDeletion) != 0)
                                            return;
                                        QuadTreeIndexer indexer = indexerList[index];
                                        Vector3F[] points = indexer.points.GetBuffer();
                                        int count = indexer.points.Count;
                                        double scaleX = indexer.scale.X;
                                        double scaleY = indexer.scale.Y;
                                        double posX = indexer.position.X;
                                        double posY = indexer.position.Y;
                                        for (int i = 0; i < count; i++)
                                        {
                                            if ((i & 4095) == 0 &&
                                                (stop.IsCancellationRequested ||
                                                 scanState.WorkerShouldStop() ||
                                                 System.Threading.Thread.VolatileRead(ref foundDeletion) != 0))
                                                return;
                                            double wx = points[i].X * scaleX + posX;
                                            double wy = points[i].Y * scaleY + posY;
                                            foreach (PlanPolygonEntry polygonEntry in polygons)
                                            {
                                                if (IsPointInsidePolygon(wx, wy, polygonEntry.Polygon))
                                                {
                                                    System.Threading.Interlocked.Exchange(
                                                        ref foundDeletion, 1);
                                                    stop.Cancel();
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception error)
                                    {
                                        scanState.RecordFailure(error);
                                        stop.Cancel();
                                    }
                                }, scanState.ShouldStop, null);
                        }
                        catch (Exception error) { scanState.RecordFailure(error); }
                        scanState.ThrowIfFailed();
                        if (scanState.ShouldStop()) return;
                        if (System.Threading.Thread.VolatileRead(ref foundDeletion) == 0)
                        {
                            noMatch = true;
                            return;
                        }
                        WaitProgress.ProgressChange(0.2f);

                        int batchSize = Math.Max(1,
                            Math.Min(MemoryStatus.CalcBatchSizeForReduceOnly(), 65536));
                        var keptPoints = new List<Vector4D>(batchSize);
                        using (var writer = new ColorAwareLasWriter(buffers,outputPath,scanState.ShouldStop))
                        {
                            writer.IsCancellationRequested = scanState.ShouldStop;
                            for (int r = 0; r < indexerList.Count; r++)
                            {
                                if (scanState.ShouldStop()) return;
                                QuadTreeIndexer indexer = indexerList[r];
                                Vector3F[] points = indexer.points.GetBuffer();
                                byte[] weights = indexer.weights != null
                                    ? indexer.weights.GetBuffer() : null;
                                int count = indexer.points.Count;
                                if (indexer.weights != null &&
                                    (weights == null || indexer.weights.Count < count ||
                                     weights.Length < count))
                                    throw new InvalidDataException(
                                        "LiDAR weights are shorter than the point buffer.");
                                double scaleX = indexer.scale.X;
                                double scaleY = indexer.scale.Y;
                                double scaleZ = indexer.scale.Z;
                                double posX = indexer.position.X;
                                double posY = indexer.position.Y;
                                double posZ = indexer.position.Z;

                                for (int i = 0; i < count; i++)
                                {
                                    if ((i & 4095) == 0 && scanState.ShouldStop()) return;
                                    double wx = points[i].X * scaleX + posX;
                                    double wy = points[i].Y * scaleY + posY;
                                    double wz = points[i].Z * scaleZ + posZ;
                                    bool shouldDelete = false;
                                    foreach (PlanPolygonEntry polygonEntry in polygons)
                                    {
                                        if (IsPointInsidePolygon(wx, wy, polygonEntry.Polygon))
                                        {
                                            shouldDelete = true;
                                            break;
                                        }
                                    }
                                    if (shouldDelete)
                                    {
                                        totalDeleted++;
                                        continue;
                                    }
                                    // Rail 16 stores LAS intensity as a byte weight.
                                    // Expand it to the 16-bit LAS range for re-import.
                                    double w = weights == null ? UInt16.MaxValue : weights[i] * 257.0;
                                    writer.CaptureKeptPoint(indexer,i,new Vector4D(wx,wy,wz,w));
                                    keptPoints.Add(new Vector4D(wx, wy, wz, w));
                                    if (keptPoints.Count == batchSize)
                                    {
                                        writer.WritePoints(keptPoints);
                                        totalKept += keptPoints.Count;
                                        keptPoints.Clear();
                                    }
                                }
                                WaitProgress.ProgressChange(0.2f +
                                    (float)(r + 1) / indexerList.Count * 0.65f);
                            }

                            if (scanState.ShouldStop()) return;
                            if (totalDeleted == 0)
                            {
                                changedSource = true;
                                return;
                            }
                            if (keptPoints.Count > 0)
                            {
                                writer.WritePoints(keptPoints);
                                totalKept += keptPoints.Count;
                            }
                            if (scanState.ShouldStop()) return;
                            PreparedLasFile candidate = writer.Complete();
                            if (scanState.ShouldStop())
                            {
                                candidate.Dispose();
                                return;
                            }
                            prepared = candidate;
                            WaitProgress.ProgressChange(1.0f);
                            if (scanState.ShouldStop())
                            {
                                prepared.Dispose();
                                prepared = null;
                            }
                        }
                    }, true);
                }
                catch (OperationCanceledException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("[PlanDeletePoints] Export error: " + ex);
                    MessageDlg.Show("Ошибка экспорта LAS: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }

                if (prepared == null)
                {
                    if (noMatch)
                        MessageDlg.Show("Точек для удаления не найдено.",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Information);
                    else if (changedSource)
                        MessageDlg.Show("Точки LiDAR изменились во время экспорта; LAS не опубликован.",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }
            }

            // WaitProgress has closed and the borrowed source receiver is gone.
            // Validate on the command thread before replacing the final LAS.
            if (!IsCurrent(context, planCv, overlayLayer) ||
                !context.IsSnapshotCurrent(polygonSnapshot))
            {
                MessageDlg.Show("Проект, источник LiDAR или полигоны изменились; LAS не опубликован.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            try
            {
                prepared.Publish();
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка публикации LAS: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            if (!IsCurrent(context, planCv, overlayLayer))
            {
                MessageDlg.Show("LAS-файл сохранён: " + outputPath +
                    ". Контекст изменился; полигоны не очищены.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            // The LAS file is written; clear persisted polygons before reporting
            // the whole command as complete or changing the overlay.
            try
            {
                context.Commit(polygonSnapshot, new ScopedPolygonRecord[0]);
            }
            catch (PolygonRevisionConflictException)
            {
                MessageDlg.Show("LAS-файл сохранён: " + outputPath +
                    ". Полигоны изменились и не были очищены.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[PlanDeletePoints] Polygon clear error: " + ex.Message);
                MessageDlg.Show("LAS-файл сохранён: " + outputPath +
                    ". Не удалось очистить полигоны: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!IsCurrent(context, planCv, overlayLayer))
                    throw new InvalidOperationException("Контекст изменился после очистки.");
                if (overlayLayer != null) overlayLayer.ClearPolygons();
                planCv.Unlock();
                planCv.Invalidate();
                CadView crossCv = CadViewDesignUtils.OnCadViewSelect(
                    CadViewDesignUtils.CrossSectionCadViewAlias);
                if (crossCv != null)
                {
                    crossCv.Unlock();
                    crossCv.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageDlg.Show("LAS-файл сохранён и полигоны очищены, но вид не обновлён: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            MessageDlg.Show(string.Format(
                "Удалено точек: {0}\nОсталось: {1}\nФайл: {2}\nИсходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.",
                totalDeleted, totalKept, outputPath),
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                if (prepared != null) prepared.Dispose();
            }
        }

        private static bool IsCurrent(ScopedPolygonOperationContext context,
            CadView view, PlanOverlayLayer overlay)
        {
            try
            {
                return context.IsSourceCurrent() &&
                    Object.ReferenceEquals(view[PlanOverlayLayer.GUID], overlay);
            }
            catch (Exception) { return false; }
        }

        private static void ShowChangedContext()
        {
            MessageDlg.Show("Трасса, проект, окно или слой изменились; LAS не опубликован.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Проверка попадания точки в полигон — БЕЗ Z!
        /// </summary>
        private bool IsPointInsidePolygon(double x, double y, List<Vector2D> polygon)
        {
            return PolygonGeometry.Contains(x, y, polygon);
        }
    }
}
