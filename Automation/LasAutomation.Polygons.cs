// Automation/LasAutomation.Polygons.cs
// Headless-операции с полигонами RoboLas: просмотр/добавление/очистка,
// удаление точек по полигонам (plan/crs) и построение ЦММ по полигонам
// (сетка min-Z или полином). Версии use-case'ов без confirm/SaveFileDialog:
// подтверждение делает вызывающий агент, путь приходит параметром.
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.UseCases;
using LAS_TERRAIN.Visualization;
using System;
using System.Collections.Generic;
using System.IO;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Design;
using Topomatic.Controls;
using Topomatic.Lidar;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Automation
{
    public static partial class LasAutomation
    {
        // ─────────────────────────── Просмотр ───────────────────────────

        /// <summary>Полилинии scope'а (plan: мировые X,Y; crs: локальные offset,Z сечения).</summary>
        public static LasPolygonListResult ListPolygons(string scope)
        {
            PolygonGeometryKind kind = ParseScope(scope);
            using (EnterGate())
            {
                CadView view = RequireCadView();
                ScopedPolygonOperationContext context =
                    ScopedPolygonOperationContext.Capture(view, kind);
                if (context == null)
                    throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot snapshot = context.Repository.Read();
                LasPolygonListResult result = new LasPolygonListResult();
                result.Scope = scope.ToLowerInvariant();
                for (int i = 0; i < snapshot.Records.Count; i++)
                {
                    ScopedPolygonRecord record = snapshot.Records[i];
                    LasPolygonInfo info = new LasPolygonInfo();
                    info.Index = i;
                    info.CreatedAt = record.CreatedAt;
                    info.VertexCount = record.Polygon.Count;
                    foreach (Vector2D point in record.Polygon)
                        info.Vertices.Add(new double[] { point.X, point.Y });
                    info.SectionId = record.SectionId;
                    info.SectionStation = record.SectionStation;
                    info.Thickness = record.Thickness;
                    result.Polygons.Add(info);
                }
                result.Count = result.Polygons.Count;
                return result;
            }
        }

        /// <summary>Exports each polygon to a user-selected directory, without changing the project.</summary>
        public static Dictionary<string, object> SavePolygons(string scope, string outputDirectory, bool overwrite)
        {
            PolygonGeometryKind kind = ParseScope(scope);
            if (!IsAbsolutePolygonPath(outputDirectory))
                throw new LasAutomationException("output_directory должен быть абсолютным путём к папке.");
            string directory = Path.GetFullPath(outputDirectory);
            using (EnterGate())
            {
                ScopedPolygonOperationContext context = ScopedPolygonOperationContext.Capture(RequireCadView(), kind);
                if (context == null) throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot snapshot = context.Repository.Read();
                List<string> paths = new List<string>();
                for (int i = 0; i < snapshot.Records.Count; i++)
                {
                    string path = Path.Combine(directory, PortablePolygonFile.FileName(context.Scope.ProjectAlias, kind, i + 1));
                    if (String.Equals(path, context.Scope.FilePath, StringComparison.OrdinalIgnoreCase))
                        throw new LasAutomationException("Файл экспорта совпадает с хранилищем проекта.");
                    if (!overwrite && File.Exists(path))
                        throw new LasAutomationException("Файл уже существует: " + path + ". Выберите другую папку или явно укажите overwrite=true. Файлы не сохранены.");
                    paths.Add(path);
                }
                List<string> saved = new List<string>();
                try
                {
                    if (!context.IsSnapshotCurrent(snapshot)) throw new InvalidOperationException("Проект или полигоны изменились.");
                    if (paths.Count > 0) Directory.CreateDirectory(directory);
                    for (int i = 0; i < paths.Count; i++)
                    {
                        if (!context.IsSnapshotCurrent(snapshot)) throw new InvalidOperationException("Проект или полигоны изменились.");
                        if (overwrite) PortablePolygonFile.Save(paths[i], snapshot.Records[i]);
                        else
                        {
                            // Publish with Move so a competing file creation is never overwritten.
                            string stage = paths[i] + "." + Guid.NewGuid().ToString("N") + ".tmp";
                            try
                            {
                                PortablePolygonFile.Save(stage, snapshot.Records[i]);
                                if (!context.IsSnapshotCurrent(snapshot)) throw new InvalidOperationException("Проект или полигоны изменились.");
                                File.Move(stage, paths[i]);
                            }
                            finally { if (File.Exists(stage)) File.Delete(stage); }
                        }
                        saved.Add(paths[i]);
                    }
                }
                catch (Exception ex)
                {
                    throw new LasAutomationException("Сохранение полигонов не завершено. Уже сохранено файлов: " + saved.Count +
                        ". Пути: " + String.Join("; ", saved.ToArray()) + ". Не повторяйте запись вслепую. Причина: " + ex.Message, ex);
                }
                return new Dictionary<string, object> { { "scope", scope.ToLowerInvariant() }, { "saved", saved.Count },
                    { "paths", saved.ToArray() }, { "format", "robolas-polygon" }, { "version", 1 }, { "project_changed", false } };
            }
        }

        /// <summary>Validates every portable file before appending the complete batch once.</summary>
        public static Dictionary<string, object> LoadPolygons(string[] paths, uint? sectionId, double? station)
        {
            if (paths == null || paths.Length == 0) throw new LasAutomationException("Укажите paths: массив абсолютных путей к JSON-файлам полигонов.");
            if (sectionId.HasValue && station.HasValue) throw new LasAutomationException("Укажите только section_id или station, а не оба поля.");
            if (station.HasValue && (Double.IsNaN(station.Value) || Double.IsInfinity(station.Value)))
                throw new LasAutomationException("station должен быть конечным числом.");
            using (EnterGate())
            {
                CadView view = RequireCadView();
                ScopedPolygonOperationContext owner = ScopedPolygonOperationContext.Capture(view, PolygonGeometryKind.Plan);
                if (owner == null) throw new LasAutomationException(CannotCaptureContextMessage);
                List<ScopedPolygonRecord> imported = new List<ScopedPolygonRecord>();
                HashSet<string> uniquePaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (string path in paths)
                {
                    if (!IsAbsolutePolygonPath(path)) throw new LasAutomationException("Каждый элемент paths должен быть абсолютным путём к файлу.");
                    string fullPath = Path.GetFullPath(path);
                    if (!uniquePaths.Add(fullPath)) throw new LasAutomationException("Файл указан повторно: " + fullPath);
                    imported.Add(PortablePolygonFile.Load(fullPath));
                }
                PolygonGeometryKind kind = imported[0].GeometryKind;
                foreach (ScopedPolygonRecord record in imported)
                    if (record.GeometryKind != kind) throw new LasAutomationException("Загрузите полигоны плана и поперечников отдельными вызовами.");
                if (kind == PolygonGeometryKind.Plan && (sectionId.HasValue || station.HasValue))
                    throw new LasAutomationException("Полигоны плана сохраняют мировые X/Y; section_id и station для них не применяются.");
                ScopedPolygonOperationContext context = kind == PolygonGeometryKind.Plan ? owner : ScopedPolygonOperationContext.Capture(view, kind);
                if (context == null || !owner.IsCurrent()) throw new LasAutomationException("Проект или трасса изменились; полигоны не загружены.");
                ScopedPolygonSnapshot snapshot = context.Repository.Read();
                if (kind == PolygonGeometryKind.Crs)
                {
                    SectionBinding binding = ResolveCrsSection(sectionId, station);
                    for (int i = 0; i < imported.Count; i++)
                    {
                        ScopedPolygonRecord record = imported[i];
                        imported[i] = ScopedPolygonRecord.Crs(record.CreatedAt, record.Polygon, binding.SectionId, binding.Station, record.Thickness);
                    }
                }
                if (!owner.IsCurrent() || !context.IsSnapshotCurrent(snapshot))
                    throw new LasAutomationException("Проект, трасса, сечения или полигоны изменились; полигоны не загружены.");
                List<ScopedPolygonRecord> combined = new List<ScopedPolygonRecord>(snapshot.Records);
                combined.AddRange(imported);
                ScopedPolygonSnapshot committed = context.Commit(snapshot, combined);
                RefreshOverlay(kind);
                return new Dictionary<string, object> { { "scope", kind == PolygonGeometryKind.Plan ? "plan" : "crs" },
                    { "added", imported.Count }, { "total_polygons", committed.Records.Count }, { "paths", paths },
                    { "note", kind == PolygonGeometryKind.Plan ? "Мировые X/Y сохранены; системы координат проектов должны совпадать." :
                        "Контуры привязаны к явно выбранному существующему поперечнику; offset и высоты сохранены." } };
            }
        }

        private static bool IsAbsolutePolygonPath(string path)
        {
            if (String.IsNullOrEmpty(path) || !Path.IsPathRooted(path)) return false;
            string root = Path.GetPathRoot(path);
            return root.Length > 1 && (root[root.Length - 1] == Path.DirectorySeparatorChar ||
                root[root.Length - 1] == Path.AltDirectorySeparatorChar);
        }

        // ─────────────────────────── Изменение ───────────────────────────

        /// <summary>
        /// Добавляет полигон в scope. Для plan: vertices — мировые [x, y].
        /// Для crs: vertices — локальные [offset, Z] поперечника + привязка к сечению
        /// (section_id либо station; thickness по умолчанию = crs_overlay_border).
        /// </summary>
        public static LasPolygonMutationResult AddPolygon(string scope, double[][] vertices,
            uint? sectionId, double? station, double? thickness)
        {
            PolygonGeometryKind kind = ParseScope(scope);
            List<Vector2D> polygon = ParseVertices(vertices);
            using (EnterGate())
            {
                CadView view = RequireCadView();
                ScopedPolygonOperationContext context =
                    ScopedPolygonOperationContext.Capture(view, kind);
                if (context == null)
                    throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot snapshot = context.Repository.Read();

                ScopedPolygonRecord record;
                if (kind == PolygonGeometryKind.Plan)
                {
                    record = ScopedPolygonRecord.Plan(DateTime.Now, polygon);
                }
                else
                {
                    SectionBinding binding = ResolveCrsSection(sectionId, station);
                    double effectiveThickness = thickness.HasValue && thickness.Value > 0 &&
                        !double.IsNaN(thickness.Value) && !double.IsInfinity(thickness.Value)
                        ? thickness.Value
                        : RuntimeConfig.CrsOverlayBorder;
                    record = ScopedPolygonRecord.Crs(DateTime.Now, polygon,
                        binding.SectionId, binding.Station, effectiveThickness);
                }

                List<ScopedPolygonRecord> records =
                    new List<ScopedPolygonRecord>(snapshot.Records.Count + 1);
                foreach (ScopedPolygonRecord existing in snapshot.Records)
                    records.Add(existing);
                records.Add(record);
                try
                {
                    ScopedPolygonSnapshot committed = context.Commit(snapshot, records);
                    RefreshOverlay(kind);
                    return new LasPolygonMutationResult
                    {
                        Scope = scope.ToLowerInvariant(),
                        TotalPolygons = committed.Records.Count,
                        Added = true
                    };
                }
                catch (PolygonRevisionConflictException ex)
                {
                    throw new LasAutomationException(
                        "Набор полигонов изменился с момента чтения. Повторите вызов.", ex);
                }
            }
        }

        /// <summary>Удаляет все полигоны scope'а (сами точки облака не трогает).</summary>
        public static LasPolygonMutationResult ClearPolygons(string scope)
        {
            PolygonGeometryKind kind = ParseScope(scope);
            using (EnterGate())
            {
                CadView view = RequireCadView();
                ScopedPolygonOperationContext context =
                    ScopedPolygonOperationContext.Capture(view, kind);
                if (context == null)
                    throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot snapshot = context.Repository.Read();
                try
                {
                    context.Commit(snapshot, new ScopedPolygonRecord[0]);
                    RefreshOverlay(kind);
                    return new LasPolygonMutationResult
                    {
                        Scope = scope.ToLowerInvariant(),
                        TotalPolygons = 0,
                        Cleared = true
                    };
                }
                catch (PolygonRevisionConflictException ex)
                {
                    throw new LasAutomationException(
                        "Набор полигонов изменился с момента чтения. Повторите вызов.", ex);
                }
            }
        }

        // ─────────────────────── Удаление точек ───────────────────────

        /// <summary>
        /// Удаляет точки облака, попадающие в полигоны scope'а, и пишет результат
        /// в новый LAS (LAS 1.2, Point Format 1). Исходное облако в проекте не
        /// меняется; после успешной публикации полигоны scope'а очищаются.
        /// </summary>
        public static LasDeletePointsResult DeletePointsByPolygons(string scope, string outputPath)
        {
            PolygonGeometryKind kind = ParseScope(scope);
            string validatedPath = ValidateLasPath(outputPath);
            using (EnterGate())
            {
                CadView view = RequireCadView();
                ScopedPolygonOperationContext context =
                    ScopedPolygonOperationContext.Capture(view, kind);
                if (context == null)
                    throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot polygonSnapshot = context.Repository.Read();
                if (polygonSnapshot.Records.Count == 0)
                    throw new LasAutomationException(
                        "Нет собранных полигонов в scope '" + scope + "'. Добавьте их через las_add_polygon или las_load_polygons.");

                DeletePointsOutcome outcome;
                {
                    using (ActiveAlignmentReciver<Alignment> receiver =
                        ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                    {
                        Alignment alg = RequireAlignment(receiver);
                        var buffers = LidarBufferService.CollectBuffers(alg);
                        if (buffers == null || buffers.Count == 0 ||
                            !context.MatchesCapturedSource(alg, buffers))
                            throw new LasAutomationException(
                                "Трасса, проект или облако изменились; операция отменена.");

                        List<QuadTreeIndexer> indexerList = CollectIndexers(buffers);
                        if (indexerList.Count == 0)
                            throw new LasAutomationException("Нет данных LiDAR для обработки.");

                        outcome = kind == PolygonGeometryKind.Plan
                            ? DeletePointsPlanCore(alg,buffers,polygonSnapshot.Records, indexerList, validatedPath)
                            : DeletePointsCrsCore(alg,buffers, polygonSnapshot.Records, indexerList, validatedPath);
                    }
                }

                LasDeletePointsResult result = new LasDeletePointsResult();
                result.Scope = scope.ToLowerInvariant();
                result.OutputPath = validatedPath;
                result.Deleted = outcome.Deleted;
                result.Kept = outcome.Kept;
                if (outcome.Cancelled)
                {
                    result.Cancelled = true;
                    result.Note = "Операция отменена пользователем; LAS не опубликован, полигоны сохранены.";
                    return result;
                }
                PreparedLasFile prepared = outcome.Prepared;
                try
                {
                    if (prepared == null)
                    {
                        result.Note = outcome.Deleted == 0
                            ? "Точек для удаления не найдено; LAS не создан, полигоны сохранены."
                            : "Операция не завершилась; LAS не опубликован.";
                        return result;
                    }
                    if (!context.IsSourceCurrent() || !context.IsSnapshotCurrent(polygonSnapshot))
                        throw new LasAutomationException(
                            "Проект, источник LiDAR или полигоны изменились; LAS не опубликован.");
                    CalculationTelemetry.Report("publish", 0.97);
                    prepared.Publish();
                    result.Published = true;
                    result.RgbPreserved = outcome.RgbPrepared;

                    // LAS записан — очищаем полигоны до отчёта.
                    try
                    {
                        context.Commit(polygonSnapshot, new ScopedPolygonRecord[0]);
                        result.PolygonsCleared = true;
                    }
                    catch (PolygonRevisionConflictException)
                    {
                        result.Note = "LAS сохранён, но полигоны изменились и не были очищены.";
                        return result;
                    }
                    RefreshOverlay(kind);
                    result.Note = "Исходное облако в проекте не менялось. Чтобы работать с результатом, импортируйте LAS в Topomatic.";
                    return result;
                }
                finally
                {
                    if (prepared != null) prepared.Dispose();
                }
            }
        }

        private sealed class DeletePointsOutcome
        {
            public bool RgbPrepared;
            public PreparedLasFile Prepared;
            public long Deleted;
            public long Kept;
            public bool Cancelled;
        }

        private static DeletePointsOutcome DeletePointsPlanCore(Alignment alg,List<LidarBuffer> buffers,
            IList<ScopedPolygonRecord> records, List<QuadTreeIndexer> indexerList,
            string outputPath)
        {
            List<List<Vector2D>> polygons = new List<List<Vector2D>>();
            foreach (ScopedPolygonRecord record in records)
            {
                List<Vector2D> polygon = new List<Vector2D>(record.Polygon.Count);
                foreach (Vector2D point in record.Polygon)
                    polygon.Add(new Vector2D(point.X, point.Y));
                polygons.Add(polygon);
            }

            DeletePointsOutcome outcome = new DeletePointsOutcome();
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
                using (var writer = new ColorAwareLasWriter(buffers,outputPath,isCancelled))
                {
                    writer.IsCancellationRequested = isCancelled;
                    for (int r = 0; r < indexerList.Count; r++)
                    {
                        if (isCancelled()) return;
                        WriteKeptPointsPlan(indexerList[r], polygons, writer, keptPoints,
                            batchSize, outcome);
                        WaitProgress.ProgressChange((float)(r + 1) / indexerList.Count * 0.8f);
                    }
                    if (isCancelled() || outcome.Deleted == 0) return;
                    if (keptPoints.Count > 0)
                    {
                        writer.WritePoints(keptPoints);
                        outcome.Kept += keptPoints.Count;
                    }
                    if (isCancelled()) return;
                    outcome.RgbPrepared=writer.HasRgb;
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

        private static void WriteKeptPointsPlan(QuadTreeIndexer indexer,
            List<List<Vector2D>> polygons, ColorAwareLasWriter writer,
            List<Vector4D> keptPoints, int batchSize, DeletePointsOutcome outcome)
        {
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
                if ((i & 4095) == 0 && WaitProgress.CancellationPending) return;
                double wx = points[i].X * scaleX + posX;
                double wy = points[i].Y * scaleY + posY;
                double wz = points[i].Z * scaleZ + posZ;
                bool shouldDelete = false;
                foreach (List<Vector2D> polygon in polygons)
                {
                    if (PolygonGeometry.Contains(wx, wy, polygon))
                    {
                        shouldDelete = true;
                        break;
                    }
                }
                if (shouldDelete)
                {
                    outcome.Deleted++;
                    continue;
                }
                // Rail 16 хранит intensity как байт; расширяем до 16-бит LAS.
                double w = weights == null ? UInt16.MaxValue : weights[i] * 257.0;
                writer.CaptureKeptPoint(indexer,i,new Vector4D(wx,wy,wz,w));
                keptPoints.Add(new Vector4D(wx, wy, wz, w));
                if (keptPoints.Count == batchSize)
                {
                    writer.WritePoints(keptPoints);
                    outcome.Kept += keptPoints.Count;
                    keptPoints.Clear();
                }
            }
        }

        private sealed class CrsSectionGeom
        {
            public Vector2D LeftMost;
            public double DirX;
            public double DirY;
            public double NormalX;
            public double NormalY;
            public List<CrsPolygonGeom> Polygons;
        }

        private sealed class CrsPolygonGeom
        {
            public List<Vector2D> Points;
            public double HalfBorder;
        }

        private static DeletePointsOutcome DeletePointsCrsCore(Alignment alg,List<LidarBuffer> buffers,
            IList<ScopedPolygonRecord> records, List<QuadTreeIndexer> indexerList,
            string outputPath)
        {
            double halfBorder = RuntimeConfig.CrsOverlayBorder / 2.0;
            var sections = alg.Corridor.Sections;
            var grouped = GroupPolygons(records, sections.Count,
                delegate(int i) { return sections[i].Id; },
                delegate(int i) { return sections[i].Station; });
            if (grouped == null)
                throw new LasAutomationException(
                    "Сохранённые CRS-полигоны не соответствуют текущим ID и пикетам сечений. " +
                    "Операция отменена; проверьте список сечений (las_list_sections).");
            double dtmLeft = alg.DtmSizeLeft;
            double dtmRight = alg.DtmSizeRight;

            var sectionGeoms = new List<CrsSectionGeom>();
            foreach (var kvp in grouped)
            {
                var section = sections[kvp.Key];
                Vector2D leftMost, rightMost;
                if (!alg.Plan.CompoundLine.StaOffsetToPos(section.Station, -dtmLeft, out leftMost) ||
                    !alg.Plan.CompoundLine.StaOffsetToPos(section.Station, dtmRight, out rightMost))
                    throw new LasAutomationException(
                        "Не удалось построить геометрию одного из CRS-полигонов. Операция отменена.");
                double dx = rightMost.X - leftMost.X;
                double dy = rightMost.Y - leftMost.Y;
                double length = Math.Sqrt(dx * dx + dy * dy);
                if (double.IsNaN(length) || double.IsInfinity(length) || length < 0.0001)
                    throw new LasAutomationException(
                        "Геометрия одного из CRS-полигонов вырождена. Операция отменена.");

                var polygonGeoms = new List<CrsPolygonGeom>(kvp.Value.Count);
                foreach (ScopedPolygonRecord entry in kvp.Value)
                {
                    double polygonHalfBorder = entry.Thickness > 0.0 &&
                        !double.IsNaN(entry.Thickness) && !double.IsInfinity(entry.Thickness)
                        ? entry.Thickness / 2.0 : halfBorder;
                    polygonGeoms.Add(new CrsPolygonGeom
                    {
                        Points = new List<Vector2D>(entry.Polygon),
                        HalfBorder = polygonHalfBorder
                    });
                }
                sectionGeoms.Add(new CrsSectionGeom
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
                throw new LasAutomationException("Нет подходящих сечений для удаления.");

            DeletePointsOutcome outcome = new DeletePointsOutcome();
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
                using (var writer = new ColorAwareLasWriter(buffers,outputPath,isCancelled))
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
                            for (int g = 0; g < sectionGeoms.Count && !shouldDelete; g++)
                            {
                                var sg = sectionGeoms[g];
                                foreach (CrsPolygonGeom polygon in sg.Polygons)
                                {
                                    if (ShouldDeleteCrsPoint(wx, wy, wz, sg, polygon, dtmLeft))
                                    {
                                        shouldDelete = true;
                                        break;
                                    }
                                }
                            }
                            if (shouldDelete)
                            {
                                outcome.Deleted++;
                                continue;
                            }
                            double w = weights == null ? UInt16.MaxValue : weights[i] * 257.0;
                            writer.CaptureKeptPoint(indexer,i,new Vector4D(wx,wy,wz,w));
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
                    outcome.RgbPrepared=writer.HasRgb;
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

        private static bool ShouldDeleteCrsPoint(double wx, double wy, double wz,
            CrsSectionGeom sg, CrsPolygonGeom polygon, double dtmLeft)
        {
            double distNormal = (wx - sg.LeftMost.X) * sg.NormalX +
                (wy - sg.LeftMost.Y) * sg.NormalY;
            if (Math.Abs(distNormal) > polygon.HalfBorder)
                return false;
            double along = (wx - sg.LeftMost.X) * sg.DirX +
                (wy - sg.LeftMost.Y) * sg.DirY;
            double offset = along - dtmLeft;
            return PolygonGeometry.Contains(new Vector2D(offset, wz), polygon.Points);
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
                    grouped.Add(sectionIndex, section = new List<ScopedPolygonRecord>());
                section.Add(entry);
            }
            return grouped;
        }

        private static List<QuadTreeIndexer> CollectIndexers(List<LidarBuffer> buffers)
        {
            var indexerList = new List<QuadTreeIndexer>();
            foreach (LidarBuffer buffer in buffers)
            {
                if (buffer == null || buffer.indexers == null) continue;
                foreach (QuadTreeIndexer indexer in buffer.indexers)
                    if (indexer != null && indexer.points != null)
                        indexerList.Add(indexer);
            }
            return indexerList;
        }

        // ───────────────────── Поверхности по полигонам ─────────────────────

        /// <summary>
        /// Строит ЦММ по полигонам плана: method="grid" — регулярная сетка min-Z
        /// c детекцией характерных точек; method="polynomial" — полином Z=f(x,y).
        /// Настройки берутся из las_set_settings (grid_step, polynomial_*).
        /// </summary>
        public static LasSurfaceByPolygonsResult BuildSurfaceByPolygons(string method)
        {
            bool polynomial;
            if (string.Equals(method, "grid", StringComparison.OrdinalIgnoreCase))
                polynomial = false;
            else if (string.Equals(method, "polynomial", StringComparison.OrdinalIgnoreCase))
                polynomial = true;
            else
                throw new LasAutomationException(
                    "method должен быть 'grid' (сетка min-Z) или 'polynomial' (полиномиальная поверхность).");

            using (EnterGate())
            {
                CadView view = RequireCadView();
                SurfaceLayer surfaceLayer = SurfaceLayer.GetSurfaceLayer(view);
                if (surfaceLayer == null || surfaceLayer.Surface == null)
                    throw new LasAutomationException(
                        "Не найден слой ЦММ на видовом экране. Откройте вид с поверхностью ЦММ трассы.");
                PlanSurfaceSettings settings = RuntimeConfig.CapturePlanSurfaceSettings();
                ScopedPolygonOperationContext polygonContext =
                    ScopedPolygonOperationContext.Capture(view, PolygonGeometryKind.Plan);
                if (polygonContext == null)
                    throw new LasAutomationException(CannotCaptureContextMessage);
                ScopedPolygonSnapshot polygonSnapshot = polygonContext.Repository.Read();
                if (polygonSnapshot.Records.Count == 0)
                    throw new LasAutomationException(
                        "Нет полигонов плана. Сначала добавьте их через las_add_polygon (scope=plan).");

                List<PlanPolygonEntry> polygons = new List<PlanPolygonEntry>();
                foreach (ScopedPolygonRecord record in polygonSnapshot.Records)
                {
                    PlanPolygonEntry entry = new PlanPolygonEntry();
                    entry.CreatedAt = record.CreatedAt;
                    foreach (Vector2D point in record.Polygon)
                        entry.Polygon.Add(new Vector2D(point.X, point.Y));
                    polygons.Add(entry);
                }

                LasSurfaceByPolygonsResult result = new LasSurfaceByPolygonsResult();
                result.Method = polynomial ? "polynomial" : "grid";
                result.Polygons = polygons.Count;
                result.GridStep = polynomial ? settings.PolynomialGridStep : settings.GridStep;

                long totalPoints;
                List<Vector3D> outputPoints;
                using (var source = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alignment = RequireAlignment(source);
                    CalculationTelemetry.Report("capture_source", 0.1);
                    List<LidarBuffer> sourceBuffers = LidarBufferService.CollectBuffers(alignment);
                    PlanSurfaceTarget target = PlanSurfaceTarget.Capture(view, surfaceLayer,
                        alignment, sourceBuffers);
                    if (target == null || !polygonContext.MatchesCapturedSource(alignment, sourceBuffers))
                        throw new LasAutomationException(
                            "Не удалось зафиксировать трассу, поверхность или источник полигонов.");
                    if (!target.IsCurrent(source.Alignment))
                        throw new LasAutomationException(
                            "Трасса, проект, окно или поверхность изменились во время подготовки. Результат не применён.");
                    List<LidarBuffer> buffers = target.Buffers;

                    BoundingBox2D polygonBounds;
                    if (!PolygonBounds.TryCompute(polygons, out polygonBounds))
                        throw new LasAutomationException("Не удалось вычислить границы полигонов.");

                    var scanState = new PlanPolygonScanState();
                    CalculationTelemetry.Report("count_polygon_points", 0.2);
                    totalPoints = CountPointsInPolygonsParallel(buffers, polygons, scanState);
                    if (scanState.Cancelled)
                    {
                        result.Cancelled = true;
                        result.Note = "Операция отменена пользователем; результат не применён.";
                        return result;
                    }
                    if (totalPoints == 0)
                        throw new LasAutomationException(
                            "Точек внутри полигонов не найдено. Проверьте координаты полигонов (las_list_polygons).");

                    if (polynomial)
                    {
                        CalculationTelemetry.Report("collect_polygon_points", 0.4);
                        List<Vector3D> allPoints = CollectAllPointsInPolygonsParallel(
                            buffers, polygons, scanState);
                        if (scanState.Cancelled)
                        {
                            result.Cancelled = true;
                            result.Note = "Операция отменена пользователем; результат не применён " +
                                "(частично собранные точки отброшены).";
                            return result;
                        }
                        int degree = settings.PolynomialDegree;
                        int minPointsRequired = (degree + 1) * (degree + 2) / 2;
                        if (allPoints.Count < minPointsRequired)
                            throw new LasAutomationException(string.Format(
                                "Недостаточно точек для полиномиальной подгонки: требуется {0}, найдено {1}.",
                                minPointsRequired, allPoints.Count));
                        result.Degree = degree;
                        try
                        {
                            CalculationTelemetry.Report("fit_polynomial", 0.65);
                            outputPoints = PolynomialSurfaceFitter.FitSurface(
                                allPoints, degree, settings.PolynomialRegularization,
                                settings.PolynomialGridStep, polygonBounds);
                        }
                        catch (Exception ex)
                        {
                            throw new LasAutomationException(
                                "Ошибка подгонки полиномиальной поверхности: " + ex.Message, ex);
                        }
                    }
                    else
                    {
                        double gridStep = settings.GridStep;
                        CalculationTelemetry.Report("grid_min_z", 0.4);
                        List<Vector3D> groundPoints = CollectGroundMinZInPolygonsParallel(
                            buffers, polygons, polygonBounds, gridStep, scanState);
                        if (scanState.Cancelled)
                        {
                            result.Cancelled = true;
                            result.Note = "Операция отменена пользователем; результат не применён.";
                            return result;
                        }
                        result.SupportPoints = groundPoints.Count;
                        CalculationTelemetry.Report("detect_features", 0.65);
                        outputPoints = GridFeatureDetector.DetectFeatures(
                            groundPoints, polygonBounds, gridStep,
                            0.3, 0.9, 0.02, 0.10, GridFeatureDetector.Mode.Both);
                        result.FeaturePoints = outputPoints.Count;
                    }

                    if (!polygonContext.IsSourceCurrent() ||
                        !polygonContext.IsSnapshotCurrent(polygonSnapshot))
                        throw new LasAutomationException(
                            "Проект, источник LiDAR или полигоны изменились; результат не применён.");
                    try
                    {
                        CalculationTelemetry.Report("validate_target_and_commit_surface", 0.9);
                        target.Apply(outputPoints);
                    }
                    catch (Exception error)
                    {
                        Exception cause = error is System.Reflection.TargetInvocationException &&
                            error.InnerException != null ? error.InnerException : error;
                        throw new LasAutomationException(
                            "Не удалось завершить запись результата: " + cause.Message, cause);
                    }
                    result.PointsInCloud = totalPoints;
                    result.Inserted = outputPoints.Count;
                }

                try
                {
                    view.Unlock();
                    view.Invalidate();
                }
                catch (Exception) { /* обновление вида не критично */ }
                return result;
            }
        }

        private static long CountPointsInPolygonsParallel(IList<LidarBuffer> buffers,
            List<PlanPolygonEntry> polygons, PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0 || polygons == null || polygons.Count == 0)
                return 0;
            long total = 0;
            object sumSync = new object();
            int n = buffers.Count;
            int[] idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;
            scanState.Execute("Подсчёт точек в полигонах...", idxs, delegate(int i)
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

        private static List<Vector3D> CollectGroundMinZInPolygonsParallel(
            IList<LidarBuffer> buffers, List<PlanPolygonEntry> polygons,
            BoundingBox2D bounds, double gridStep, PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0 || gridStep <= 0)
                return new List<Vector3D>();
            double x0 = bounds.Min.X;
            double y0 = bounds.Min.Y;
            var global = new GridMinZAccumulator(x0, y0, gridStep, 1 << 16);
            int n = buffers.Count;
            var bufferCells = new List<Vector3D>[n];
            int[] idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;
            scanState.Execute("Сбор опорных точек (по полигонам)...", idxs, delegate(int i)
            {
                if (scanState.WorkerShouldStop()) return;
                LidarBuffer buf = buffers[i];
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
                        if (!IsPointInsideAnyPolygon(wx, wy, polygons))
                            continue;
                        local.Add(wx, wy, wz);
                    }
                }
                if (scanState.WorkerShouldStop()) return;
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

        private static List<Vector3D> CollectAllPointsInPolygonsParallel(
            IList<LidarBuffer> buffers, List<PlanPolygonEntry> polygons,
            PlanPolygonScanState scanState)
        {
            if (buffers == null || buffers.Count == 0)
                return new List<Vector3D>();
            int n = buffers.Count;
            var bufferPoints = new List<Vector3D>[n];
            int[] idxs = new int[n];
            for (int i = 0; i < n; i++) idxs[i] = i;
            scanState.Execute("Сбор точек (по полигонам)...", idxs, delegate(int i)
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

        private static bool IsPointInsideAnyPolygon(double x, double y,
            List<PlanPolygonEntry> polygons)
        {
            foreach (PlanPolygonEntry entry in polygons)
                if (PolygonGeometry.Contains(x, y, entry.Polygon))
                    return true;
            return false;
        }

        // ─────────────────────────── Вспомогательное ───────────────────────────

        private sealed class SectionBinding
        {
            public uint SectionId;
            public double Station;
        }

        private static PolygonGeometryKind ParseScope(string scope)
        {
            if (string.Equals(scope, "plan", StringComparison.OrdinalIgnoreCase))
                return PolygonGeometryKind.Plan;
            if (string.Equals(scope, "crs", StringComparison.OrdinalIgnoreCase))
                return PolygonGeometryKind.Crs;
            throw new LasAutomationException(
                "scope должен быть 'plan' (вид сверху) или 'crs' (поперечники).");
        }

        private static List<Vector2D> ParseVertices(double[][] vertices)
        {
            if (vertices == null || vertices.Length < 3)
                throw new LasAutomationException(
                    "Полигон должен содержать минимум 3 вершины [[x,y], ...].");
            List<Vector2D> polygon = new List<Vector2D>(vertices.Length);
            foreach (double[] vertex in vertices)
            {
                if (vertex == null || vertex.Length < 2 ||
                    double.IsNaN(vertex[0]) || double.IsNaN(vertex[1]) ||
                    double.IsInfinity(vertex[0]) || double.IsInfinity(vertex[1]))
                    throw new LasAutomationException(
                        "Каждая вершина — пара чисел [x, y].");
                polygon.Add(new Vector2D(vertex[0], vertex[1]));
            }
            return polygon;
        }

        private static SectionBinding ResolveCrsSection(uint? sectionId, double? station)
        {
            if (!sectionId.HasValue && !station.HasValue)
                throw new LasAutomationException(
                    "Для scope=crs укажите привязку к сечению: section_id (точно) или station " +
                    "(пикет, берётся ближайшее сечение). Список: las_list_sections.");
            using (ActiveAlignmentReciver<Alignment> receiver =
                ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                Alignment alg = RequireAlignment(receiver);
                var sections = alg.Corridor.Sections;
                if (sections.Count == 0)
                    throw new LasAutomationException(
                        "У трассы нет сечений. Сначала выполните las_generate_sections.");
                if (sectionId.HasValue)
                {
                    for (int i = 0; i < sections.Count; i++)
                        if (sections[i].Id == sectionId.Value)
                            return new SectionBinding
                            {
                                SectionId = sections[i].Id,
                                Station = sections[i].Station
                            };
                    throw new LasAutomationException(
                        "Сечение с id=" + sectionId.Value + " не найдено. См. las_list_sections.");
                }
                int best = 0;
                double bestDiff = double.MaxValue;
                for (int i = 0; i < sections.Count; i++)
                {
                    double diff = Math.Abs(sections[i].Station - station.Value);
                    if (diff < bestDiff)
                    {
                        bestDiff = diff;
                        best = i;
                    }
                }
                if (bestDiff > 0.001)
                    throw new LasAutomationException(string.Format(
                        "Ближайшее сечение к пикету {0} дальше 1 мм ({1}). Укажите точный station или section_id.",
                        station.Value, sections[best].Station));
                return new SectionBinding
                {
                    SectionId = sections[best].Id,
                    Station = sections[best].Station
                };
            }
        }

        private static void RefreshOverlay(PolygonGeometryKind kind)
        {
            try
            {
                CadView view = GetActiveCadView();
                if (view == null || view.IsDisposed) return;
                if (kind == PolygonGeometryKind.Plan)
                {
                    PlanOverlayLayer overlay = view[PlanOverlayLayer.GUID] as PlanOverlayLayer;
                    if (overlay != null) overlay.ClearPolygons();
                    view.Unlock();
                    view.Invalidate();
                }
                CadView crossCv = CadViewDesignUtils.OnCadViewSelect(
                    CadViewDesignUtils.CrossSectionCadViewAlias);
                if (crossCv != null)
                {
                    crossCv.Unlock();
                    crossCv.Invalidate();
                }
            }
            catch (Exception) { /* обновление вида не критично */ }
        }

        private const string CannotCaptureContextMessage =
            "Не удалось зафиксировать трассу, проект или окно. Убедитесь, что трасса активна " +
            "(las_set_active_alignment) и видовой экран открыт.";
    }
}
