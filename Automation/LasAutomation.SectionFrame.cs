// Automation/LasAutomation.SectionFrame.cs
// Визуальная чистка сечений (docs/MCP_SECTION_VISUAL.md): кадр сечения для
// рендера, dry-run счёт точек в призмах полигонов и удаление точек LAS в
// призмах (полигон в плоскости сечения × толщина сечения вдоль нормали).
// Полигоны приходят аргументами stateless — хранилище полигонов и overlay не трогаем.
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Service.Collector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Automation
{
    public static partial class LasAutomation
    {
        // ─────────────────────── Кадр сечения ───────────────────────

        /// <summary>
        /// Собирает кадр поперечника в локальных координатах сечения: offset —
        /// поперечное смещение от оси трассы (влево отрицательное), Z — высота
        /// проекта, SliceDistance — расстояние до плоскости сечения со знаком.
        /// Хранит до maxStoredPoints точек, min/max считает по всему срезу.
        /// Только чтение; для отрисовки отвечает net48-адаптер.
        /// </summary>
        public static LasSectionFrame GetSectionFrame(double station, double thickness,
            int maxStoredPoints)
        {
            if (double.IsNaN(station) || double.IsInfinity(station) || station < 0)
                throw new ArgumentOutOfRangeException("station", "Station must be finite, in meters from the alignment start.");
            if (double.IsNaN(thickness) || double.IsInfinity(thickness) || thickness <= 0)
                throw new ArgumentOutOfRangeException("thickness", "Thickness must be finite and positive.");
            if (maxStoredPoints < 1 || maxStoredPoints > 1000000)
                throw new ArgumentOutOfRangeException("max_stored_points", "Max stored points must be between 1 and 1000000.");
            using (EnterGate())
            {
                var view = RequireCadView();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alg = RequireAlignment(receiver);
                    if (station > alg.Plan.CompoundLine.Length)
                        throw new ArgumentOutOfRangeException("station", "Station exceeds the active alignment length.");
                    SectionBasis basis = BuildSectionBasis(alg, station);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(NoLidarSourceMessage);
                    LasExportSourceContext source = LasExportSourceContext.Capture(view, alg, buffers);
                    if (source == null || !source.IsCurrent())
                        throw new LasAutomationException(SourceChangedMessage);

                    int capacity = Math.Min(maxStoredPoints, 1 << 16);
                    var offsets = new List<double>(capacity);
                    var elevations = new List<double>(capacity);
                    var weights = new List<double>(capacity);
                    var sliceDistances = new List<double>(capacity);
                    long totalPoints = 0;
                    double offsetMin = 0, offsetMax = 0, zMin = 0, zMax = 0;
                    double weightMin = 0, weightMax = 0;
                    SectionCollectStatus status;
                    // Масштаб веса: Rail 16 FindPoints возвращает байтовую интенсивность,
                    // нормированную на 1 (NativeLidarPointAdapter.Weight читает поле Weight/W
                    // точки SDK как есть), поэтому Vector4D.W коллектора лежит в 0..1.
                    // Передаём без пересчёта; расширение до 16-бит LAS-интенсивности
                    // (LidarIntensity.ExpandNormalized / байт*257) делает потребитель.
                    LasSectionPointsCollectorService.StreamRawAtStation(alg, buffers, station,
                        LasFilterOptions.FromThickness(thickness, false), delegate(Vector4D p)
                        {
                            double px = p.X - basis.LeftPoint.X, py = p.Y - basis.LeftPoint.Y;
                            double offset = px * basis.UnitX + py * basis.UnitY - basis.Left;
                            double distance = px * basis.UnitY - py * basis.UnitX;
                            if (totalPoints == 0)
                            {
                                offsetMin = offsetMax = offset;
                                zMin = zMax = p.Z;
                                weightMin = weightMax = p.W;
                            }
                            else
                            {
                                if (offset < offsetMin) offsetMin = offset;
                                if (offset > offsetMax) offsetMax = offset;
                                if (p.Z < zMin) zMin = p.Z;
                                if (p.Z > zMax) zMax = p.Z;
                                if (p.W < weightMin) weightMin = p.W;
                                if (p.W > weightMax) weightMax = p.W;
                            }
                            totalPoints++;
                            if (offsets.Count < maxStoredPoints)
                            {
                                offsets.Add(offset);
                                elevations.Add(p.Z);
                                weights.Add(p.W);
                                sliceDistances.Add(distance);
                            }
                        }, null, out status);
                    if (status != SectionCollectStatus.Success)
                        throw new LasAutomationException("Section point limit exceeded. Use a thinner slice; partial statistics are not returned.");
                    if (!source.IsCurrent()) throw new LasAutomationException(SourceChangedMessage);

                    LasSectionFrame result = new LasSectionFrame();
                    result.Alignment = alg.Alias;
                    result.Station = station;
                    result.Thickness = thickness;
                    result.LeftOffset = basis.Left;
                    result.RightOffset = basis.Right;
                    result.TotalPoints = totalPoints;
                    result.StoredPoints = offsets.Count;
                    result.Truncated = result.StoredPoints < result.TotalPoints;
                    if (totalPoints == 0)
                    {
                        // Пустой срез валиден: рамка по границам полосы, MCP рисует
                        // сетку и подпись «нет точек».
                        result.OffsetMin = -basis.Left;
                        result.OffsetMax = basis.Right;
                        result.ZMin = 0;
                        result.ZMax = 0;
                        result.WeightMin = 0;
                        result.WeightMax = 0;
                    }
                    else
                    {
                        result.OffsetMin = offsetMin;
                        result.OffsetMax = offsetMax;
                        result.ZMin = zMin;
                        result.ZMax = zMax;
                        result.WeightMin = weightMin;
                        result.WeightMax = weightMax;
                    }
                    result.Offsets = offsets.ToArray();
                    result.Elevations = elevations.ToArray();
                    result.Weights = weights.ToArray();
                    result.SliceDistances = sliceDistances.ToArray();
                    return result;
                }
            }
        }

        // ─────────────────── Dry-run призм полигонов ───────────────────

        /// <summary>
        /// Точный dry-run удаления без рендера: один проход по срезу толщиной
        /// thickness (|SliceDistance| &lt; thickness/2) и подсчёт точек, попадающих в
        /// призмы полигонов [[offset, Z], ...] (по первому совпадению). Толщина
        /// призмы равна толщине сечения — отдельного параметра глубины нет.
        /// Ничего не меняет — ни облако, ни хранилище полигонов.
        /// </summary>
        public static LasSectionPreviewResult PreviewSectionPolygons(double station,
            double thickness, double[][][] polygons)
        {
            if (double.IsNaN(station) || double.IsInfinity(station) || station < 0)
                throw new ArgumentOutOfRangeException("station", "Station must be finite, in meters from the alignment start.");
            if (double.IsNaN(thickness) || double.IsInfinity(thickness) || thickness <= 0)
                throw new ArgumentOutOfRangeException("thickness", "Thickness must be finite and positive.");
            // Всю валидацию полигонов проходим до входа в гейт и тяжёлой работы.
            List<List<Vector2D>> parsed = ParseSectionPolygons(polygons, 1, 50, "polygons");
            using (EnterGate())
            {
                var view = RequireCadView();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alg = RequireAlignment(receiver);
                    if (station > alg.Plan.CompoundLine.Length)
                        throw new ArgumentOutOfRangeException("station", "Station exceeds the active alignment length.");
                    SectionBasis basis = BuildSectionBasis(alg, station);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(NoLidarSourceMessage);
                    LasExportSourceContext source = LasExportSourceContext.Capture(view, alg, buffers);
                    if (source == null || !source.IsCurrent())
                        throw new LasAutomationException(SourceChangedMessage);

                    long slicePoints = 0;
                    long matchedPoints = 0;
                    long[] counters = new long[parsed.Count];
                    SectionCollectStatus status;
                    LasSectionPointsCollectorService.StreamRawAtStation(alg, buffers, station,
                        LasFilterOptions.FromThickness(thickness, false), delegate(Vector4D p)
                        {
                            double px = p.X - basis.LeftPoint.X, py = p.Y - basis.LeftPoint.Y;
                            double offset = px * basis.UnitX + py * basis.UnitY - basis.Left;
                            slicePoints++;
                            // Первый полигон по порядку забирает точку себе.
                            for (int i = 0; i < parsed.Count; i++)
                            {
                                if (PolygonGeometry.Contains(offset, p.Z, parsed[i]))
                                {
                                    counters[i]++;
                                    matchedPoints++;
                                    break;
                                }
                            }
                        }, null, out status);
                    if (status != SectionCollectStatus.Success)
                        throw new LasAutomationException("Section point limit exceeded. Use a thinner slice; partial statistics are not returned.");
                    if (!source.IsCurrent()) throw new LasAutomationException(SourceChangedMessage);

                    LasSectionPreviewResult result = new LasSectionPreviewResult();
                    result.Alignment = alg.Alias;
                    result.Station = station;
                    result.Thickness = thickness;
                    result.PolygonCount = parsed.Count;
                    result.SlicePoints = slicePoints;
                    result.MatchedPoints = matchedPoints;
                    for (int i = 0; i < parsed.Count; i++)
                        result.Polygons.Add(new LasSectionPolygonCount { Index = i, Count = counters[i] });
                    return result;
                }
            }
        }

        // ─────────────────── Удаление точек в призмах ───────────────────

        /// <summary>
        /// Удаляет точки облака, попадающие хотя бы в одну призму
        /// (полигон в плоскости сечения × толщина сечения вдоль нормали), и пишет
        /// результат в новый LAS 1.2 (Point Format 1, RGB сохраняется
        /// ColorAwareLasWriter-ом). Геометрия каждой секции строится из её
        /// station; исходное облако и хранилище полигонов не меняются.
        /// </summary>
        public static LasSectionDeleteResult DeleteSectionPoints(
            LasSectionPolygonSpec[] sections, string outputPath)
        {
            // Лёгкая валидация до тяжёлой работы: путь, размер массива,
            // полигоны и thickness не зависят от активной трассы.
            string validatedPath = ValidateLasPath(outputPath);
            if (sections == null || sections.Length == 0)
                throw new LasAutomationException(
                    "Укажите sections: массив из 1..200 секций {station, thickness, polygons}.");
            if (sections.Length > 200)
                throw new LasAutomationException(
                    "sections не может содержать больше 200 секций за один вызов.");
            List<List<Vector2D>>[] parsed = new List<List<Vector2D>>[sections.Length];
            for (int i = 0; i < sections.Length; i++)
            {
                LasSectionPolygonSpec spec = sections[i];
                if (spec == null)
                    throw new LasAutomationException(
                        "sections[" + i + "] не задан: ожидается {station, thickness, polygons}.");
                if (double.IsNaN(spec.Station) || double.IsInfinity(spec.Station) || spec.Station < 0)
                    throw new ArgumentOutOfRangeException("station",
                        "sections[" + i + "]: station must be finite, non-negative, in meters from the alignment start.");
                if (double.IsNaN(spec.Thickness) || double.IsInfinity(spec.Thickness) || spec.Thickness <= 0)
                    throw new LasAutomationException(
                        "sections[" + i + "]: thickness должен быть конечным положительным числом (полная толщина сечения = толщина удаляемой призмы, м).");
                // Секция несёт 1..50 полигонов; призма одна на секцию (толщина общая).
                parsed[i] = ParseSectionPolygons(spec.Polygons, 1, 50,
                    "sections[" + i + "].polygons");
            }
            using (EnterGate())
            {
                var view = RequireCadView();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alg = RequireAlignment(receiver);
                    double alignmentLength = alg.Plan.CompoundLine.Length;
                    for (int i = 0; i < sections.Length; i++)
                        if (sections[i].Station > alignmentLength)
                            throw new ArgumentOutOfRangeException("station",
                                "sections[" + i + "]: station exceeds the active alignment length.");
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0)
                        throw new LasAutomationException(NoLidarSourceMessage);
                    LasExportSourceContext source = LasExportSourceContext.Capture(view, alg, buffers);
                    if (source == null || !source.IsCurrent())
                        throw new LasAutomationException(SourceChangedMessage);
                    List<QuadTreeIndexer> indexerList = CollectIndexers(buffers);
                    if (indexerList.Count == 0)
                        throw new LasAutomationException("Нет данных LiDAR для обработки.");

                    // Геометрия призмы каждой секции строится из её собственного
                    // пикета (StaOffsetToPos с -DtmSizeLeft..DtmSizeRight).
                    var prisms = new List<SectionPrismSpec>(sections.Length);
                    for (int i = 0; i < sections.Length; i++)
                        prisms.Add(BuildSectionPrismSpec(alg, sections[i], parsed[i]));

                    Stopwatch clock = Stopwatch.StartNew();
                    SectionDeleteOutcome outcome = DeleteSectionPrismCore(buffers, prisms,
                        indexerList, validatedPath);

                    LasSectionDeleteResult result = new LasSectionDeleteResult();
                    result.OutputPath = validatedPath;
                    result.Sections = sections.Length;
                    result.Deleted = outcome.Deleted;
                    result.Kept = outcome.Kept;
                    for (int i = 0; i < sections.Length; i++)
                        result.PerSection.Add(new LasSectionPolygonCount
                        {
                            Index = i,
                            Count = outcome.PerSection[i]
                        });
                    PreparedLasFile prepared = outcome.Prepared;
                    try
                    {
                        if (outcome.Cancelled)
                        {
                            result.Cancelled = true;
                            result.Note = "Операция отменена пользователем; LAS не опубликован, полигоны сохранены.";
                            return result;
                        }
                        if (prepared == null)
                        {
                            result.Note = outcome.Deleted == 0
                                ? "Точек для удаления не найдено; LAS не создан, полигоны сохранены."
                                : "Операция не завершилась; LAS не опубликован.";
                            return result;
                        }
                        if (!source.IsCurrent())
                            throw new LasAutomationException(
                                "Проект, источник LiDAR или облако изменились; LAS не опубликован. Повторите вызов.");
                        prepared.Publish();
                        result.Published = true;
                        result.RgbPreserved = outcome.RgbPrepared;
                        result.Note = "Исходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.";
                        return result;
                    }
                    finally
                    {
                        clock.Stop();
                        result.ElapsedSeconds = clock.Elapsed.TotalSeconds;
                        if (prepared != null) prepared.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Предикат удаления (единый для preview-счёта и delete): строгое
        /// |distNormal| &lt; halfThickness — открытый интервал, как
        /// ContainsSliceDistance коллектора — и попадание (offset, Z) в
        /// полигон по правилу even-odd (PolygonGeometry.Contains).
        /// </summary>
        internal static bool IsPointInSectionPrism(double wx, double wy, double wz,
            SectionPrismGeom geometry, double halfThickness, List<Vector2D> polygon)
        {
            double distNormal = (wx - geometry.LeftMost.X) * geometry.NormalX +
                (wy - geometry.LeftMost.Y) * geometry.NormalY;
            // Строго меньше по модулю: точки ровно на границе thickness/2 не удаляются.
            if (!(distNormal < halfThickness && distNormal > -halfThickness)) return false;
            double along = (wx - geometry.LeftMost.X) * geometry.DirX +
                (wy - geometry.LeftMost.Y) * geometry.DirY;
            double offset = along - geometry.DtmLeft;
            return PolygonGeometry.Contains(offset, wz, polygon);
        }

        // ─────────────────────── Вспомогательное ───────────────────────

        /// <summary>Базис сечения как в GetSectionPoints: крайние точки полосы и орты.</summary>
        private sealed class SectionBasis
        {
            public Vector2D LeftPoint;
            public double UnitX;
            public double UnitY;
            public double Left;
            public double Right;
        }

        /// <summary>
        /// Геометрия призмы одного сечения (как CrsSectionGeom у CRS-удаления):
        /// левый край полосы, орт вдоль сечения, нормаль плоскости и DtmSizeLeft.
        /// </summary>
        internal sealed class SectionPrismGeom
        {
            public Vector2D LeftMost;
            public double DirX;
            public double DirY;
            public double NormalX;
            public double NormalY;
            public double DtmLeft;
        }

        /// <summary>Сечение с призмами: геометрия, полутолщина и полигоны в (offset, Z).</summary>
        private sealed class SectionPrismSpec
        {
            public SectionPrismGeom Geometry;
            public double HalfThickness;
            public List<List<Vector2D>> Polygons;
        }

        private sealed class SectionDeleteOutcome
        {
            public bool RgbPrepared;
            public PreparedLasFile Prepared;
            public long Deleted;
            public long Kept;
            public bool Cancelled;
            public long[] PerSection;
        }

        // StaOffsetToPos ±DtmSize и орт вдоль сечения — точно как в probe.
        private static SectionBasis BuildSectionBasis(Alignment alg, double station)
        {
            double left = alg.DtmSizeLeft, right = alg.DtmSizeRight;
            Vector2D leftPoint, rightPoint;
            if (double.IsNaN(left) || double.IsInfinity(left) || left < 0 ||
                double.IsNaN(right) || double.IsInfinity(right) || right < 0 ||
                !alg.Plan.CompoundLine.StaOffsetToPos(station, -left, out leftPoint) ||
                !alg.Plan.CompoundLine.StaOffsetToPos(station, right, out rightPoint))
                throw new LasAutomationException("Cannot construct section geometry at this station.");
            double dx = rightPoint.X - leftPoint.X, dy = rightPoint.Y - leftPoint.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            if (double.IsNaN(length) || double.IsInfinity(length) || length < 1e-9)
                throw new LasAutomationException("The section width is zero or invalid.");
            return new SectionBasis
            {
                LeftPoint = leftPoint,
                UnitX = dx / length,
                UnitY = dy / length,
                Left = left,
                Right = right
            };
        }

        private static SectionPrismSpec BuildSectionPrismSpec(Alignment alg,
            LasSectionPolygonSpec spec, List<List<Vector2D>> polygons)
        {
            double dtmLeft = alg.DtmSizeLeft, dtmRight = alg.DtmSizeRight;
            Vector2D leftMost, rightMost;
            if (!alg.Plan.CompoundLine.StaOffsetToPos(spec.Station, -dtmLeft, out leftMost) ||
                !alg.Plan.CompoundLine.StaOffsetToPos(spec.Station, dtmRight, out rightMost))
                throw new LasAutomationException(
                    "Не удалось построить геометрию сечения на пикете " + spec.Station + ". Операция отменена.");
            double dx = rightMost.X - leftMost.X, dy = rightMost.Y - leftMost.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            if (double.IsNaN(length) || double.IsInfinity(length) || length < 0.0001)
                throw new LasAutomationException(
                    "Геометрия сечения на пикете " + spec.Station + " вырождена. Операция отменена.");
            return new SectionPrismSpec
            {
                Geometry = new SectionPrismGeom
                {
                    LeftMost = leftMost,
                    DirX = dx / length,
                    DirY = dy / length,
                    NormalX = -dy / length,
                    NormalY = dx / length,
                    DtmLeft = dtmLeft
                },
                HalfThickness = spec.Thickness / 2.0,
                Polygons = polygons
            };
        }

        // Зеркало DeletePointsCrsCore: один проход по индексерам, отбор
        // удержанных точек и публикация нового LAS без правки исходного облака.
        private static SectionDeleteOutcome DeleteSectionPrismCore(List<LidarBuffer> buffers,
            List<SectionPrismSpec> prisms, List<QuadTreeIndexer> indexerList, string outputPath)
        {
            SectionDeleteOutcome outcome = new SectionDeleteOutcome();
            outcome.PerSection = new long[prisms.Count];
            bool cancellationObserved = false;
            Func<bool> isCancelled = delegate
            {
                if (WaitProgress.CancellationPending) cancellationObserved = true;
                return cancellationObserved;
            };
            int batchSize = Math.Max(1,
                Math.Min(MemoryStatus.CalcBatchSizeForReduceOnly(), 65536));
            WaitProgress.BeginProgress(
                string.Format("Удаление точек ({0} блоков)...", indexerList.Count), delegate
            {
                var keptPoints = new List<Vector4D>(batchSize);
                using (var writer = new ColorAwareLasWriter(buffers, outputPath, isCancelled))
                {
                    writer.IsCancellationRequested = isCancelled;
                    for (int r = 0; r < indexerList.Count; r++)
                    {
                        if (isCancelled()) return;
                        QuadTreeIndexer indexer = indexerList[r];
                        Vector3F[] points = indexer.points.GetBuffer();
                        byte[] weights = indexer.weights != null
                            ? indexer.weights.GetBuffer() : null;
                        int count = indexer.points.Count;
                        if (indexer.weights != null &&
                            (weights == null || indexer.weights.Count < count || weights.Length < count))
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
                            // Секция по порядку забирает точку себе (первое совпадение).
                            for (int s = 0; s < prisms.Count && !shouldDelete; s++)
                            {
                                SectionPrismSpec prism = prisms[s];
                                for (int p = 0; p < prism.Polygons.Count; p++)
                                {
                                    if (IsPointInSectionPrism(wx, wy, wz,
                                        prism.Geometry, prism.HalfThickness, prism.Polygons[p]))
                                    {
                                        shouldDelete = true;
                                        outcome.PerSection[s]++;
                                        break;
                                    }
                                }
                            }
                            if (shouldDelete)
                            {
                                outcome.Deleted++;
                                continue;
                            }
                            // Rail 16 хранит intensity как байт; расширяем до 16-бит LAS.
                            double w = weights == null ? UInt16.MaxValue : weights[i] * 257.0;
                            writer.CaptureKeptPoint(indexer, i, new Vector4D(wx, wy, wz, w));
                            keptPoints.Add(new Vector4D(wx, wy, wz, w));
                            if (keptPoints.Count == batchSize)
                            {
                                writer.WritePoints(keptPoints);
                                outcome.Kept += keptPoints.Count;
                                keptPoints.Clear();
                            }
                        }
                        WaitProgress.ProgressChange(
                            (float)(r + 1) / indexerList.Count * 0.8f);
                    }

                    if (isCancelled()) return;
                    if (outcome.Deleted == 0) return;
                    if (keptPoints.Count > 0)
                    {
                        writer.WritePoints(keptPoints);
                        outcome.Kept += keptPoints.Count;
                    }
                    if (isCancelled()) return;
                    outcome.RgbPrepared = writer.HasRgb;
                    PreparedLasFile candidate = writer.Complete();
                    if (isCancelled())
                    {
                        candidate.Dispose();
                        return;
                    }
                    outcome.Prepared = candidate;
                    WaitProgress.ProgressChange(1.0f);
                }
            }, true);
            outcome.Cancelled = cancellationObserved || WaitProgress.CancellationPending;
            if (outcome.Cancelled && outcome.Prepared != null)
            {
                outcome.Prepared.Dispose();
                outcome.Prepared = null;
            }
            return outcome;
        }

        // Валидация и разбор массива полигонов сечения [[offset, Z], ...] в стиле
        // ParseVertices: сообщения с индексом полигона/вершины, finite-проверка.
        private static List<List<Vector2D>> ParseSectionPolygons(double[][][] polygons,
            int minCount, int maxCount, string label)
        {
            if (polygons == null || polygons.Length < minCount)
                throw new LasAutomationException(label + " должен содержать от " + minCount +
                    " до " + maxCount + " полигонов [[offset, Z], ...].");
            if (polygons.Length > maxCount)
                throw new LasAutomationException(label + " не может содержать больше " +
                    maxCount + " полигонов за один вызов.");
            List<List<Vector2D>> parsed = new List<List<Vector2D>>(polygons.Length);
            for (int i = 0; i < polygons.Length; i++)
                parsed.Add(ParseSectionPolygon(polygons[i], label + "[" + i + "]"));
            return parsed;
        }

        // Один полигон сечения: минимум 3 конечные вершины [offset, Z].
        private static List<Vector2D> ParseSectionPolygon(double[][] vertices, string label)
        {
            if (vertices == null || vertices.Length < 3)
                throw new LasAutomationException(label +
                    " должен содержать минимум 3 вершины [[offset, Z], ...].");
            List<Vector2D> polygon = new List<Vector2D>(vertices.Length);
            for (int v = 0; v < vertices.Length; v++)
            {
                double[] vertex = vertices[v];
                if (vertex == null || vertex.Length < 2 ||
                    double.IsNaN(vertex[0]) || double.IsNaN(vertex[1]) ||
                    double.IsInfinity(vertex[0]) || double.IsInfinity(vertex[1]))
                    throw new LasAutomationException(label + ", вершина " + v +
                        ": каждая вершина — пара конечных чисел [offset, Z].");
                polygon.Add(new Vector2D(vertex[0], vertex[1]));
            }
            return polygon;
        }
    }
}
