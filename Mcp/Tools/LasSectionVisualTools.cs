// Mcp/Tools/LasSectionVisualTools.cs
// Визуальная чистка сечений (docs/MCP_SECTION_VISUAL.md): PNG-кадр сечения,
// полигон поверх кадра с dry-run счётом призмы удаления и вырезание точек
// в призмах (полигон × толщина сечения) по одному или нескольким пикетам — результат
// пишется в НОВЫЙ LAS, облако проекта не меняется.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using LAS_TERRAIN.Automation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasSectionVisualTools : ToolProvider
    {
        [ToolDef(
            Name = "las_render_section",
            Description = "[ROBOLAS] Только чтение: PNG-кадр сечения облака по пикету и полной толщине среза — сетка, оси, калибровка пиксель↔метр (image.plot, image.pixels_per_meter_x/y), окраска точек intensity/z/slice_distance. Offset — поперечное смещение от оси трассы (влево отрицательное), Z — высота проекта. Возвращает компактные точки [offset, Z] и файл полного среза *.points.json. Прочитай image.path как изображение; толщину подбирай сам: толще — плотнее, тоньше — чище. Полигон поверх кадра — las_preview_section_polygon; вырезание — las_delete_section_points. Требует активной трассы и загруженного облака. Проект не меняется.",
            InputSchema = @"{""type"":""object"",""properties"":{""station"":{""type"":""number"",""minimum"":0,""description"":""Пикет сечения в метрах от начала активной трассы; ПК 12+34 = 1234.""},""thickness"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Полная толщина среза для ПРОСМОТРА, м (что видно на кадре и в points.json); границы открыты: -thickness/2 < SliceDistance < thickness/2.""},""width_px"":{""type"":""integer"",""minimum"":320,""maximum"":4096,""description"":""Ширина PNG, px (по умолчанию 2400).""},""height_px"":{""type"":""integer"",""minimum"":240,""maximum"":4096,""description"":""Высота PNG, px (по умолчанию 1400).""},""color_by"":{""type"":""string"",""enum"":[""intensity"",""z"",""slice_distance""],""description"":""Окраска точек: intensity — градации серого по интенсивности LAS; z — спектр синий (низ) → красный (верх); slice_distance — синий (плоскость сечения) → красный (край толщи).""},""point_px"":{""type"":""integer"",""minimum"":1,""maximum"":8,""description"":""Размер точки, px (по умолчанию 2).""},""scale_mode"":{""type"":""string"",""enum"":[""fit"",""equal""],""description"":""fit — заполнить канву (независимые px/м по осям); equal — равный масштаб осей, стороны не искажены.""},""z_min"":{""type"":""number"",""description"":""Нижняя граница кадра по Z, м (по умолчанию наблюдаемая).""},""z_max"":{""type"":""number"",""description"":""Верхняя граница кадра по Z, м (по умолчанию наблюдаемая).""},""grid_step"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Шаг сетки по обеим осям, м (по умолчанию авто: 1/2/5×10^k на 8–25 линий).""},""max_points"":{""type"":""integer"",""minimum"":0,""maximum"":20000,""description"":""Точек [offset, Z] в ответе (по умолчанию 2000; 0 — не включать).""},""max_stored_points"":{""type"":""integer"",""minimum"":1000,""maximum"":1000000,""description"":""Сколько точек среза собирать для кадра и файла (по умолчанию 300000).""},""include_points_file"":{""type"":""boolean"",""description"":""Писать *.points.json полного среза (по умолчанию true).""},""output_dir"":{""type"":""string"",""minLength"":1,""description"":""Абсолютный путь папки для PNG и points.json (по умолчанию %TEMP%\\RoboLasSections).""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""station"",""thickness""],""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object RenderSection(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_render_section", args, RenderSectionCore);
        }

        private object RenderSectionCore(Dictionary<string, object> args)
        {
            double station = JsonUtils.RequireDouble(args, "station");
            double thickness = JsonUtils.RequireDouble(args, "thickness");
            int maxPoints = JsonUtils.GetInt(args, "max_points", 2000).Value;
            int maxStoredPoints = JsonUtils.GetInt(args, "max_stored_points", 300000).Value;
            bool includePointsFile = JsonUtils.GetBool(args, "include_points_file", true).Value;
            string outputDir = ResolveOutputDir(args);
            LasSectionFrame frame = LasAutomation.GetSectionFrame(station, thickness, maxStoredPoints);
            string pngPath = Path.Combine(outputDir, string.Format(CultureInfo.InvariantCulture,
                "section_{0:F1}_{1:yyyyMMdd_HHmmss}.png", station, DateTime.Now));
            SectionImageInfo info = SectionImageRenderer.Render(frame, null, ReadImageOptions(args), pngPath);
            string pointsFile = null;
            if (includePointsFile)
            {
                pointsFile = pngPath + ".points.json";
                WritePointsFile(pointsFile, frame);
            }
            List<object> points = new List<object>();
            if (maxPoints > 0 && frame.Offsets != null && frame.Elevations != null)
            {
                int limit = Math.Min(maxPoints, Math.Min(frame.StoredPoints,
                    Math.Min(frame.Offsets.Length, frame.Elevations.Length)));
                for (int i = 0; i < limit; i++)
                    points.Add(new double[] { Math.Round(frame.Offsets[i], 3), Math.Round(frame.Elevations[i], 3) });
            }
            Dictionary<string, object> bounds = BoundsPayload(info);
            Dictionary<string, object> payload = new Dictionary<string, object>
            {
                { "alignment", frame.Alignment },
                { "station", frame.Station },
                { "thickness", frame.Thickness },
                { "left_offset", frame.LeftOffset },
                { "right_offset", frame.RightOffset },
                { "total_points", frame.TotalPoints },
                { "stored_points", frame.StoredPoints },
                { "truncated", frame.Truncated },
                { "bounds", bounds },
                { "image", ImagePayload(info, bounds) },
                { "points", points },
                { "points_file", pointsFile }
            };
            string description = string.Format(CultureInfo.InvariantCulture,
                "Сечение ПК {0:F1} м: {1} точек среза, PNG {2}x{3}. Прочитай файл image.path как изображение.",
                station, frame.TotalPoints, info.WidthPx, info.HeightPx);
            double exampleO1 = Math.Round(info.OffsetFrom * 0.2, 3);
            double exampleO2 = Math.Round(info.OffsetTo * 0.2, 3);
            double exampleZ1 = Math.Round(info.ZFrom + 0.5, 3);
            double exampleZ2 = Math.Round(info.ZTo - 0.5, 3);
            double[][] examplePolygon = new double[][]
            {
                new double[] { exampleO1, exampleZ1 }, new double[] { exampleO2, exampleZ1 },
                new double[] { exampleO2, exampleZ2 }, new double[] { exampleO1, exampleZ2 }
            };
            return ToolResult.Ok(payload, description,
                ToolResult.Step("las_preview_section_polygon",
                    "построить полигон поверх кадра и получить точный счёт точек к удалению (пример — прямоугольник в 20% ширины кадра)",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness },
                        { "polygons", new double[][][] { examplePolygon } } }),
                ToolResult.Step("las_render_section", "посмотреть срез толще (плотнее, больше точек в кадре)",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness * 2 } }),
                ToolResult.Step("las_render_section", "посмотреть срез тоньше (чище, меньше наложений)",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness / 2 } }),
                ToolResult.Step("las_get_section_points", "полная выгрузка исходных точек сечения со статистикой и гистограммами",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness } }));
        }

        [ToolDef(
            Name = "las_preview_section_polygon",
            Description = "[ROBOLAS] Только чтение (dry-run): рисует полигоны поверх PNG сечения — полупрозрачная красная заливка, контур 3 px, вершины — и возвращает ТОЧНЫЙ счёт точек, которые попадут в призму удаления: полигон в плоскости сечения × та же толщина сечения thickness вдоль нормали. Параметр толщины один: что видно в срезе под полигоном — то и будет удалено; для большей/меньшей призмы меняй thickness (картинка и счёт меняются вместе). Вершины — локальные [offset, Z] сечения; matched_points=0 — полигон мимо. Сверь картинку с сектором, который хочешь вычистить. Проект не меняется.",
            InputSchema = @"{""type"":""object"",""properties"":{""station"":{""type"":""number"",""minimum"":0,""description"":""Пикет сечения в метрах от начала активной трассы.""},""thickness"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Полная толщина сечения, м: срез для картинки И толщина призмы удаления — одна величина.""},""polygons"":{""type"":""array"",""minItems"":1,""maxItems"":50,""description"":""Полигоны в координатах сечения: [[[offset, Z], ...], ...]; каждый — минимум 3 вершины."",""items"":{""type"":""array"",""minItems"":3,""items"":{""type"":""array"",""items"":{""type"":""number""},""minItems"":2,""maxItems"":2}}},""width_px"":{""type"":""integer"",""minimum"":320,""maximum"":4096,""description"":""Ширина PNG, px (по умолчанию 2400).""},""height_px"":{""type"":""integer"",""minimum"":240,""maximum"":4096,""description"":""Высота PNG, px (по умолчанию 1400).""},""color_by"":{""type"":""string"",""enum"":[""intensity"",""z"",""slice_distance""],""description"":""Окраска точек кадра (по умолчанию intensity).""},""point_px"":{""type"":""integer"",""minimum"":1,""maximum"":8,""description"":""Размер точки, px (по умолчанию 2).""},""scale_mode"":{""type"":""string"",""enum"":[""fit"",""equal""],""description"":""fit — заполнить канву; equal — равный масштаб осей.""},""z_min"":{""type"":""number"",""description"":""Нижняя граница кадра по Z, м (по умолчанию наблюдаемая).""},""z_max"":{""type"":""number"",""description"":""Верхняя граница кадра по Z, м (по умолчанию наблюдаемая).""},""grid_step"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Шаг сетки, м (по умолчанию авто).""},""max_stored_points"":{""type"":""integer"",""minimum"":1000,""maximum"":1000000,""description"":""Сколько точек среза собирать для кадра (по умолчанию 300000).""},""output_dir"":{""type"":""string"",""minLength"":1,""description"":""Абсолютный путь папки для PNG (по умолчанию %TEMP%\\RoboLasSections).""},""request_id"":{""type"":""string"",""minLength"":1},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""station"",""thickness"",""polygons""],""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object PreviewSectionPolygon(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_preview_section_polygon", args, PreviewSectionPolygonCore);
        }

        private object PreviewSectionPolygonCore(Dictionary<string, object> args)
        {
            double station = JsonUtils.RequireDouble(args, "station");
            double thickness = JsonUtils.RequireDouble(args, "thickness");
            object rawPolygons;
            if (!args.TryGetValue("polygons", out rawPolygons) || rawPolygons == null)
                throw new ArgumentException("polygons обязателен: массив полигонов [[[offset, Z], ...], ...] (минимум 1 полигон из 3 вершин).");
            double[][][] polygons = JToken.FromObject(rawPolygons).ToObject<double[][][]>();
            if (polygons == null || polygons.Length == 0)
                throw new ArgumentException("polygons: нужен хотя бы один полигон из минимум 3 вершин.");
            int maxStoredPoints = JsonUtils.GetInt(args, "max_stored_points", 300000).Value;
            string outputDir = ResolveOutputDir(args);
            // Два независимых гейта фасада: кадр для картинки и dry-run счёт;
            // толщина одна — срез и призма удаления совпадают.
            LasSectionFrame frame = LasAutomation.GetSectionFrame(station, thickness, maxStoredPoints);
            LasSectionPreviewResult preview = LasAutomation.PreviewSectionPolygons(station, thickness, polygons);
            SectionImageOptions options = ReadImageOptions(args);
            options.Title = string.Format(CultureInfo.InvariantCulture,
                "полигонов: {0}; толщина сечения/удаления: ±{1:F2} м", polygons.Length, thickness / 2.0);
            string pngPath = Path.Combine(outputDir, string.Format(CultureInfo.InvariantCulture,
                "section_{0:F1}_{1:yyyyMMdd_HHmmss}.png", station, DateTime.Now));
            SectionImageInfo info = SectionImageRenderer.Render(frame, polygons, options, pngPath);
            List<object> counts = new List<object>();
            foreach (LasSectionPolygonCount count in preview.Polygons)
                counts.Add(new Dictionary<string, object> { { "index", count.Index }, { "inside_points", count.Count } });
            Dictionary<string, object> bounds = BoundsPayload(info);
            Dictionary<string, object> payload = new Dictionary<string, object>
            {
                { "image", ImagePayload(info, bounds) },
                { "thickness", thickness },
                { "polygons", polygons },
                { "slice_points", preview.SlicePoints },
                { "matched_points", preview.MatchedPoints },
                { "polygons_counts", counts }
            };
            string description = string.Format(CultureInfo.InvariantCulture,
                "Полигонов: {0}; в срезе {1} точек (thickness {2:F2} м); под полигонами {3} точек к удалению.",
                polygons.Length, preview.SlicePoints, thickness, preview.MatchedPoints);
            if (preview.MatchedPoints == 0)
                description = description + " ПОЛИГОН МИМО: точек под призмами нет — проверь картинку/толщину.";
            return ToolResult.Ok(payload, description,
                ToolResult.Step("las_delete_section_points",
                    "вырезать точки под полигонами (эхо секции из этого ответа)",
                    new Dictionary<string, object> { { "output_path", @"D:\exports\cleaned_section.las" },
                        { "sections", new object[] { new Dictionary<string, object>
                            { { "station", station }, { "thickness", thickness }, { "polygons", polygons } } } } }),
                ToolResult.Step("las_preview_section_polygon",
                    "толще сечение — больше точек в срезе и в призме (картинка и счёт меняются вместе)",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness * 2 },
                        { "polygons", polygons } }),
                ToolResult.Step("las_preview_section_polygon",
                    "или тоньше — только точки, близкие к плоскости сечения",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness / 2 },
                        { "polygons", polygons } }),
                ToolResult.Step("las_render_section",
                    "чистое сечение соседнего пикета — продолжить осмотр",
                    new Dictionary<string, object> { { "station", station + 10.0 }, { "thickness", thickness } }));
        }

        [ToolDef(
            Name = "las_delete_section_points",
            Description = "[ROBOLAS] Вырезает точки LAS в призмах — полигон в плоскости сечения × та же толщина сечения thickness вдоль нормали — по одному или нескольким пикетам одним проходом и пишет результат в НОВЫЙ LAS 1.2 (интенсивность 16 бит, RGB сохраняется). Предикат: |SliceDistance| < thickness/2 И (offset, Z) внутри полигона. Толщина одна: ровно то, что видно в срезе под полигоном (las_preview_section_polygon), и удаляется. Исходное облако в проекте НЕ меняется, хранилище полигонов не трогается, результат импортируется в Robur вручную. Сначала проверь полигон через las_preview_section_polygon. Если удалять нечего — файл не создаётся. Отмена пользователем возвращает cancelled=true без ошибки.",
            InputSchema = @"{""type"":""object"",""properties"":{""output_path"":{""type"":""string"",""minLength"":1,""description"":""Абсолютный путь выходного .las файла.""},""sections"":{""type"":""array"",""minItems"":1,""maxItems"":200,""description"":""Секции удаления: {station, thickness, polygons}; thickness обязательна, полигоны — как в las_preview_section_polygon."",""items"":{""type"":""object"",""properties"":{""station"":{""type"":""number"",""minimum"":0,""description"":""Пикет сечения, м.""},""thickness"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Полная толщина сечения, м — она же толщина удаляемой призмы вдоль нормали.""},""polygons"":{""type"":""array"",""minItems"":1,""maxItems"":50,""description"":""Полигоны [[[offset, Z], ...], ...]; каждый — минимум 3 вершины."",""items"":{""type"":""array"",""minItems"":3,""items"":{""type"":""array"",""items"":{""type"":""number""},""minItems"":2,""maxItems"":2}}}},""required"":[""station"",""thickness"",""polygons""],""additionalProperties"":false}},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""output_path"",""sections""],""additionalProperties"":false}",
            DestructiveHint = true)]
        public object DeleteSectionPoints(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_delete_section_points", args, DeleteSectionPointsCore);
        }

        private object DeleteSectionPointsCore(Dictionary<string, object> args)
        {
            string outputPath = JsonUtils.RequireString(args, "output_path");
            object rawSections;
            if (!args.TryGetValue("sections", out rawSections) || rawSections == null)
                throw new ArgumentException("sections обязателен: массив секций {station, thickness, polygons}.");
            LasSectionPolygonSpec[] sections = JToken.FromObject(rawSections).ToObject<LasSectionPolygonSpec[]>();
            if (sections == null || sections.Length == 0)
                throw new ArgumentException("sections: нужна хотя бы одна секция {station, thickness, polygons}.");
            LasSectionDeleteResult result = LasAutomation.DeleteSectionPoints(sections, outputPath);
            List<object> perSection = new List<object>();
            foreach (LasSectionPolygonCount count in result.PerSection)
                perSection.Add(new Dictionary<string, object> { { "index", count.Index }, { "deleted", count.Count } });
            Dictionary<string, object> payload = new Dictionary<string, object>
            {
                { "deleted", result.Deleted },
                { "kept", result.Kept },
                { "published", result.Published },
                { "rgb_preserved", result.RgbPreserved },
                { "cancelled", result.Cancelled },
                { "sections", result.Sections },
                { "per_section", perSection },
                { "output_path", result.OutputPath },
                { "elapsed_seconds", result.ElapsedSeconds },
                { "note", result.Note },
                // PascalCase-эхо для статус-машины McpToolContract.Execute (cancelled/no_output),
                // как у DTO остальных деструктивных тулов.
                { "Cancelled", result.Cancelled },
                { "Published", result.Published }
            };
            string description;
            if (result.Cancelled)
                description = "Удаление отменено пользователем; LAS не опубликован.";
            else if (!result.Published)
                description = result.Note ?? "Файл не опубликован.";
            else
            {
                StringBuilder per = new StringBuilder();
                for (int i = 0; i < result.PerSection.Count; i++)
                {
                    if (i > 0) per.Append(", ");
                    per.AppendFormat(CultureInfo.InvariantCulture, "{0}:{1}",
                        result.PerSection[i].Index, result.PerSection[i].Count);
                }
                description = string.Format(CultureInfo.InvariantCulture,
                    "Удалено точек: {0}; осталось: {1}; по секциям: {2}. Файл: {3}",
                    result.Deleted, result.Kept, per.ToString(), result.OutputPath);
            }
            return ToolResult.Ok(payload, description,
                ToolResult.Step("las_render_section",
                    "продолжить чистку соседнего пикета",
                    new Dictionary<string, object> { { "station", sections[0].Station + 10.0 }, { "thickness", 0.4 } }),
                ToolResult.Step("las_get_context",
                    "проверить состояние проекта (облако проекта не менялось)",
                    ToolResult.NoArgs()),
                ToolResult.Step("las_get_workflow_guide",
                    "результат — новый LAS-файл; импортируй в Robur вручную, облако проекта не менялось",
                    ToolResult.NoArgs()));
        }

        // ─────────────── Общие помощники трёх тулов ───────────────

        private static SectionImageOptions ReadImageOptions(Dictionary<string, object> args)
        {
            SectionImageOptions options = new SectionImageOptions();
            options.WidthPx = JsonUtils.GetInt(args, "width_px", 2400).Value;
            options.HeightPx = JsonUtils.GetInt(args, "height_px", 1400).Value;
            options.ColorBy = JsonUtils.GetString(args, "color_by", "intensity");
            options.PointPx = JsonUtils.GetInt(args, "point_px", 2).Value;
            options.ScaleMode = JsonUtils.GetString(args, "scale_mode", "fit");
            options.ZMin = JsonUtils.GetDouble(args, "z_min", null);
            options.ZMax = JsonUtils.GetDouble(args, "z_max", null);
            options.GridStep = JsonUtils.GetDouble(args, "grid_step", null);
            return options;
        }

        private static string ResolveOutputDir(Dictionary<string, object> args)
        {
            string dir = JsonUtils.GetString(args, "output_dir",
                Path.Combine(Path.GetTempPath(), "RoboLasSections"));
            if (string.IsNullOrWhiteSpace(dir) || !Path.IsPathRooted(dir))
                throw new ArgumentException(
                    "output_dir должен быть абсолютным путём к папке (например C:\\Users\\user\\AppData\\Local\\Temp\\RoboLasSections).");
            Directory.CreateDirectory(dir);
            return dir;
        }

        private static Dictionary<string, object> BoundsPayload(SectionImageInfo info)
        {
            return new Dictionary<string, object>
            {
                { "offset_from", info.OffsetFrom },
                { "offset_to", info.OffsetTo },
                { "z_from", info.ZFrom },
                { "z_to", info.ZTo }
            };
        }

        private static Dictionary<string, object> ImagePayload(SectionImageInfo info,
            Dictionary<string, object> bounds)
        {
            return new Dictionary<string, object>
            {
                { "path", info.Path },
                { "format", "png" },
                { "width_px", info.WidthPx },
                { "height_px", info.HeightPx },
                { "plot", new Dictionary<string, object>
                    { { "left_px", info.PlotLeftPx }, { "top_px", info.PlotTopPx },
                      { "width_px", info.PlotWidthPx }, { "height_px", info.PlotHeightPx } } },
                { "bounds", bounds },
                { "pixels_per_meter_x", info.PixelsPerMeterX },
                { "pixels_per_meter_y", info.PixelsPerMeterY },
                { "y_axis", "z_up" },
                { "grid_step_offset_m", info.GridStepOffset },
                { "grid_step_z_m", info.GridStepZ },
                { "color_by", info.ColorBy },
                { "color_min", info.ColorMin },
                { "color_max", info.ColorMax }
            };
        }

        /// <summary>Файл полного среза: поточная запись массивов без материализации JArray.</summary>
        private static void WritePointsFile(string path, LasSectionFrame frame)
        {
            using (StreamWriter stream = new StreamWriter(path, false, new UTF8Encoding(false)))
            using (JsonTextWriter json = new JsonTextWriter(stream))
            {
                json.Formatting = Formatting.Indented;
                json.Culture = CultureInfo.InvariantCulture;
                json.WriteStartObject();
                json.WritePropertyName("alignment");
                json.WriteValue(frame.Alignment ?? "");
                json.WritePropertyName("station");
                json.WriteValue(frame.Station);
                json.WritePropertyName("thickness");
                json.WriteValue(frame.Thickness);
                json.WritePropertyName("left_offset");
                json.WriteValue(frame.LeftOffset);
                json.WritePropertyName("right_offset");
                json.WriteValue(frame.RightOffset);
                json.WritePropertyName("total_points");
                json.WriteValue(frame.TotalPoints);
                json.WritePropertyName("stored_points");
                json.WriteValue(frame.StoredPoints);
                WriteDoubleArray(json, "offset", frame.Offsets);
                WriteDoubleArray(json, "z", frame.Elevations);
                WriteDoubleArray(json, "intensity", frame.Weights);
                WriteDoubleArray(json, "slice_distance", frame.SliceDistances);
                json.WriteEndObject();
                json.Flush();
            }
        }

        private static void WriteDoubleArray(JsonTextWriter json, string name, double[] values)
        {
            json.WritePropertyName(name);
            json.WriteStartArray();
            if (values != null)
                for (int i = 0; i < values.Length; i++)
                    json.WriteValue(values[i]);
            json.WriteEndArray();
        }
    }
}
