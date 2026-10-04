// UseCases/CrsDeletePointsUseCase.cs
// Массовое удаление точек по собранным полигонам (Cross-Section view)
// Результат: новый LAS 1.2 Point Format 1; .ldr не модифицируются.
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Service;
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
    /// Массовое удаление точек по собранным полигонам (Cross-Section).
    /// Пишет новый LAS 1.2 Point Format 1. Оригинальные .ldr не трогает.
    /// Один проход: последовательная проверка и запись ограниченными пакетами.
    /// </summary>
    [SectionCmd("crs_delete_points")]
    public class CrsDeletePointsUseCase : ISectionUseCase
    {
        public string Name => "crs_delete_points";

        private class SectionGeom
        {
            public Vector2D LeftMost;
            public double DirX;
            public double DirY;
            public double NormalX;
            public double NormalY;
            public List<PolygonGeom> Polygons;
        }

        private class PolygonGeom
        {
            public List<Vector2D> Points;
            public double HalfBorder;
        }

        public void Run(SectionEnv env)
        {
            CadView view = env == null ? null : env.CadView;
            double halfBorder = RuntimeConfig.CrsOverlayBorder / 2.0;
            ScopedPolygonOperationContext context;
            try { context = ScopedPolygonOperationContext.Capture(view, PolygonGeometryKind.Crs); }
            catch (Exception ex)
            {
                MessageDlg.Show("Не удалось определить проект полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            if (context == null)
            {
                MessageDlg.Show("Не удалось зафиксировать трассу, проект, окно или путь к полигонам.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            ScopedPolygonSnapshot polygonSnapshot;
            try
            {
                if (!context.TryRead(out polygonSnapshot)) return;
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка инициализации коллекции полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            IList<ScopedPolygonRecord> polygons = polygonSnapshot.Records;
            if (polygons.Count == 0)
            {
                MessageDlg.Show("Нет собранных полигонов для удаления.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }

            var confirm = System.Windows.Forms.MessageBox.Show(
                "Удалить точки по всем собранным полигонам?\nРезультат будет сохранён в новый LAS-файл.",
                "Удаление точек",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question);

            if (confirm != System.Windows.Forms.DialogResult.Yes) return;
            if (!context.IsSourceCurrent())
            {
                ShowChangedContext();
                return;
            }

            string outputPath = UserDialogs.GetSaveFilePath("Сохранить отфильтрованный LAS-файл");
            if (string.IsNullOrEmpty(outputPath)) return;
            if (!context.IsSourceCurrent())
            {
                ShowChangedContext();
                return;
            }

            PreparedLasFile prepared = null;
            long totalDeleted = 0;
            long totalKept = 0;
            bool noMatchingPoints = false;
            bool cancellationObserved = false;
            try
            {
            using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                var alg = receiver.Alignment;
                if (alg == null)
                {
                    MessageDlg.Show("Сделайте трассу активной.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                var buffers = LidarBufferService.CollectBuffers(alg);
                if (buffers == null || buffers.Count == 0 ||
                    !context.MatchesCapturedSource(alg, buffers))
                {
                    ShowChangedContext();
                    return;
                }

                var sections = alg.Corridor.Sections;
                var grouped = GroupPolygons(polygons, sections.Count,
                    delegate(int i) { return sections[i].Id; },
                    delegate(int i) { return sections[i].Station; });
                if (grouped == null)
                {
                    UserDialogs.ShowWarning("Сохранённые CRS-полигоны не соответствуют текущим ID и пикетам сечений. Операция отменена.");
                    return;
                }
                double dtmLeft = alg.DtmSizeLeft;
                double dtmRight = alg.DtmSizeRight;

                // Предвычисляем геометрию секций (один раз, без повторов для каждой точки)
                var sectionGeoms = new List<SectionGeom>();
                foreach (var kvp in grouped)
                {
                    int sectionIdx = kvp.Key;
                    var section = sections[sectionIdx];
                    Vector2D leftMost, rightMost;
                    if (!alg.Plan.CompoundLine.StaOffsetToPos(section.Station, -dtmLeft, out leftMost) ||
                        !alg.Plan.CompoundLine.StaOffsetToPos(section.Station, dtmRight, out rightMost))
                    {
                        UserDialogs.ShowWarning("Не удалось построить геометрию одного из сохранённых CRS-полигонов. Операция отменена.");
                        return;
                    }

                    double dx = rightMost.X - leftMost.X;
                    double dy = rightMost.Y - leftMost.Y;
                    double length = Math.Sqrt(dx * dx + dy * dy);
                    if (Double.IsNaN(length) || Double.IsInfinity(length) || length < 0.0001)
                    {
                        UserDialogs.ShowWarning("Геометрия одного из сохранённых CRS-полигонов вырождена. Операция отменена.");
                        return;
                    }

                    var polygonGeoms = new List<PolygonGeom>(kvp.Value.Count);
                    foreach (var entry in kvp.Value)
                    {
                        // Historical entries without a valid saved thickness
                        // keep the command's captured setting.
                        double polygonHalfBorder = entry.Thickness > 0.0 &&
                            !Double.IsNaN(entry.Thickness) &&
                            !Double.IsInfinity(entry.Thickness)
                            ? entry.Thickness / 2.0 : halfBorder;
                        polygonGeoms.Add(new PolygonGeom {
                            Points = new List<Vector2D>(entry.Polygon),
                            HalfBorder = polygonHalfBorder
                        });
                    }

                    sectionGeoms.Add(new SectionGeom
                    {
                        LeftMost = leftMost,
                        DirX = dx / length,
                        DirY = dy / length,
                        NormalX = -dy / length,
                        NormalY = dx / length,
                        Polygons = polygonGeoms
                    });
                }

                if (sectionGeoms.Count == 0)
                {
                    MessageDlg.Show("Нет подходящих секций для удаления.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                // Собираем indexer'ы для параллельной обработки
                var indexerList = new List<QuadTreeIndexer>();
                foreach (var buffer in buffers)
                {
                    if (buffer == null || buffer.indexers == null) continue;
                    foreach (var indexer in buffer.indexers)
                    {
                        if (indexer != null && indexer.points != null)
                            indexerList.Add(indexer);
                    }
                }

                if (indexerList.Count == 0)
                {
                    MessageDlg.Show("Нет данных LiDAR для обработки.",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }

                int totalIndexers = indexerList.Count;
                Func<bool> isCancelled = delegate
                {
                    if (WaitProgress.CancellationPending) cancellationObserved = true;
                    return cancellationObserved;
                };

                // Keep at most one output batch, including for a single huge indexer.
                // LAS record order follows the source buffer/indexer/point traversal.
                try
                {
                    WaitProgress.BeginProgress(
                        string.Format("Удаление точек ({0} блоков)...", totalIndexers), () =>
                    {
                        int batchSize = Math.Max(1,
                            Math.Min(MemoryStatus.CalcBatchSizeForReduceOnly(), 65536));
                        var keptPoints = new List<Vector4D>(batchSize);
                        using (var writer = new ColorAwareLasWriter(buffers,outputPath,isCancelled))
                        {
                            writer.IsCancellationRequested = isCancelled;
                            for (int r = 0; r < totalIndexers; r++)
                            {
                                if (isCancelled()) return;
                                var indexer = indexerList[r];
                                var points = indexer.points.GetBuffer();
                                var weights = indexer.weights != null
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
                                    if ((i & 4095) == 0 && isCancelled()) return;
                                    double wx = points[i].X * scaleX + posX;
                                    double wy = points[i].Y * scaleY + posY;
                                    double wz = points[i].Z * scaleZ + posZ;

                                    bool shouldDelete = false;
                                    for (int g = 0; g < sectionGeoms.Count; g++)
                                    {
                                        var sg = sectionGeoms[g];
                                        foreach (var polygon in sg.Polygons)
                                        {
                                            if (ShouldDeletePointInPolygon(wx, wy, wz,
                                                sg.LeftMost, sg.NormalX, sg.NormalY,
                                                polygon.HalfBorder, sg.DirX, sg.DirY,
                                                dtmLeft, polygon.Points))
                                            {
                                                shouldDelete = true;
                                                break;
                                            }
                                        }
                                        if (shouldDelete) break;
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
                                WaitProgress.ProgressChange(
                                    (float)(r + 1) / totalIndexers * 0.8f);
                            }

                            if (isCancelled()) return;
                            if (totalDeleted == 0)
                            {
                                noMatchingPoints = totalKept > 0 || keptPoints.Count > 0;
                                return;
                            }

                            if (keptPoints.Count > 0)
                            {
                                writer.WritePoints(keptPoints);
                                totalKept += keptPoints.Count;
                            }
                            if (isCancelled()) return;
                            PreparedLasFile candidate = writer.Complete();
                            if (isCancelled())
                            {
                                candidate.Dispose();
                                return;
                            }
                            prepared = candidate;
                            WaitProgress.ProgressChange(1.0f);
                            if (isCancelled())
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
                    System.Diagnostics.Debug.WriteLine("[CrsDeletePoints] Export error: " + ex);
                    MessageDlg.Show("Ошибка экспорта LAS: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }

                if (prepared == null)
                {
                    if (!cancellationObserved && totalDeleted == 0)
                        MessageDlg.Show(noMatchingPoints
                                ? "Точек для удаления не найдено; LAS и полигоны сохранены без изменений."
                                : "Точек для обработки не найдено.",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
            }

            // The borrowed LiDAR receiver and modal progress have both ended.
            // Validate on the command thread before publishing the staged LAS.
            if (!context.IsSourceCurrent())
            {
                ShowChangedContext();
                return;
            }
            if (!context.IsSnapshotCurrent(polygonSnapshot))
            {
                MessageDlg.Show("Полигоны изменились во время экспорта. LAS не опубликован.",
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

            if (!context.IsSourceCurrent())
            {
                MessageDlg.Show("LAS-файл сохранён: " + outputPath +
                    ". Контекст изменился; полигоны не очищены.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            // The LAS file is written; clear persisted polygons before reporting
            // the whole command as complete.
            try
            {
                context.Commit(polygonSnapshot, new ScopedPolygonRecord[0]);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[CrsDeletePoints] Polygon clear error: " + ex.Message);
                MessageDlg.Show("LAS-файл сохранён: " + outputPath +
                    ". Не удалось очистить полигоны: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!context.IsSourceCurrent())
                    throw new InvalidOperationException("Контекст изменился после очистки.");
                var crossCv = CadViewDesignUtils.OnCadViewSelect(
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

        private static Dictionary<int, List<ScopedPolygonRecord>> GroupPolygons(
            IList<ScopedPolygonRecord> polygons, int sectionCount,
            Func<int, uint> idAt, Func<int, double> stationAt)
        {
            var grouped = new Dictionary<int, List<ScopedPolygonRecord>>();
            foreach (ScopedPolygonRecord entry in polygons)
            {
                int sectionIndex;
                if (!CrsScopedSectionAssociation.TryResolve(entry, sectionCount,
                    idAt, stationAt, out sectionIndex)) return null;
                List<ScopedPolygonRecord> section;
                if (!grouped.TryGetValue(sectionIndex, out section))
                    grouped.Add(sectionIndex,
                        section = new List<ScopedPolygonRecord>());
                section.Add(entry);
            }
            return grouped;
        }

        private static void ShowChangedContext()
        {
            MessageDlg.Show("Трасса, проект или окно изменились; LAS не опубликован.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        private bool ShouldDeletePointInPolygon(
            double wx, double wy, double wz,
            Vector2D leftMost,
            double normalX, double normalY, double halfBorder,
            double dirX, double dirY, double dtmLeft,
            List<Vector2D> polygon)
        {
            double distNormal = (wx - leftMost.X) * normalX + (wy - leftMost.Y) * normalY;
            if (System.Math.Abs(distNormal) > halfBorder)
                return false;

            double along = (wx - leftMost.X) * dirX + (wy - leftMost.Y) * dirY;
            double offset = along - dtmLeft;
            double z = wz;

            var sectionPt = new Vector2D(offset, z);
            return IsPointInPolygon(sectionPt, polygon);
        }

        private bool IsPointInPolygon(Vector2D point, List<Vector2D> polygon)
        {
            return PolygonGeometry.Contains(point, polygon);
        }
    }
}
