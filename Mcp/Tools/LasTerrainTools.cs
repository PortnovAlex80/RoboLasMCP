// Mcp/Tools/LasTerrainTools.cs
// Ядро RoboLas: сечения и построение ЦММ по LAS (главный сценарий).
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasTerrainTools : ToolProvider
    {
        [ToolDef(
            Name = "las_get_section_points",
            Description = "[ROBOLAS] Только чтение: исходные XYZ точки сечения облака Robur по пикету и полной толщине. Offset — поперечное смещение от оси (влево отрицательное), Elevation — исходная Z, SliceDistance — расстояние до плоскости сечения со знаком по нормали коллектора. Ширина: DtmSizeLeft/Right активной трассы. Возвращает страницы точек и полные гистограммы плотности (точек/м), пустоты по трём осям для самостоятельного подбора толщины. Без фильтра земли, прореживания и изменений проекта. До 10000 интервалов на ось; при ошибке увеличить шаг гистограммы. Для полной выгрузки следовать NextPointOffset при неизменном облаке.",
            InputSchema = @"{""type"":""object"",""properties"":{""station"":{""type"":""number"",""minimum"":0,""description"":""Пикет в метрах от начала активной трассы; ПК 12+34 = 1234.""},""thickness"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Полная толщина среза в метрах, границы открыты: -thickness/2 < SliceDistance < thickness/2.""},""bin_size"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Шаг гистограмм Offset и Elevation, метры; по умолчанию 1.""},""slice_bin_size"":{""type"":""number"",""exclusiveMinimum"":0,""description"":""Шаг гистограммы SliceDistance, метры; по умолчанию thickness/10.""},""point_offset"":{""type"":""integer"",""minimum"":0,""maximum"":33554432,""description"":""Начальный индекс страницы точек, по умолчанию 0. Каждая страница заново читает облако.""},""max_points"":{""type"":""integer"",""minimum"":1,""maximum"":10000,""description"":""Размер страницы исходных точек, по умолчанию 2000; статистика всегда по всему срезу.""},""request_id"":{""type"":""string"",""minLength"":1},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""station"",""thickness""],""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object GetSectionPoints(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_section_points", args, GetSectionPointsCore);
        }

        private object GetSectionPointsCore(Dictionary<string, object> args)
        {
            double station = JsonUtils.RequireDouble(args, "station");
            double thickness = JsonUtils.RequireDouble(args, "thickness");
            double bin = JsonUtils.GetDouble(args, "bin_size", 1.0).Value;
            double sliceBin = JsonUtils.GetDouble(args, "slice_bin_size", thickness / 10).Value;
            int offset = JsonUtils.GetInt(args, "point_offset", 0).Value;
            int limit = JsonUtils.GetInt(args, "max_points", 2000).Value;
            var result = LasAutomation.GetSectionPoints(station, thickness, bin, sliceBin, offset, limit);
            var next = new List<object>();
            if (result.NextPointOffset.HasValue)
                next.Add(ToolResult.Step("las_get_section_points", "получить следующую страницу точек без изменения источника",
                    new Dictionary<string, object> { { "station", station }, { "thickness", thickness },
                        { "bin_size", bin }, { "slice_bin_size", sliceBin },
                        { "point_offset", result.NextPointOffset.Value }, { "max_points", limit } }));
            next.Add(ToolResult.Step("las_get_section_points", "сравнить плотность и пустые интервалы при другой толщине; оптимум выбирается по требованиям задачи",
                new Dictionary<string, object> { { "station", station }, { "thickness", thickness * 1.5 },
                    { "bin_size", bin }, { "slice_bin_size", sliceBin }, { "max_points", limit } }));
            return ToolResult.Ok(result, string.Format("Сечение {0} м, толщина {1} м: {2} исходных точек; страница {3}..{4}. Статистика по всему срезу.",
                station, thickness, result.TotalPoints, offset, (long)offset + result.ReturnedPoints), next.ToArray());
        }

        [ToolDef(
            Name = "las_list_sections",
            Description = "[ROBOLAS] Сечения активной трассы: id и пикет (station, метры от начала). Нужны id/пикеты для привязки CRS-полигонов (las_add_polygon scope=crs).",
            InputSchema = @"{""type"":""object"",""properties"":{""max_sections"":{""type"":""integer"",""description"":""Максимум возвращаемых сечений (по умолчанию 50)."",""minimum"":1,""maximum"":100000},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object ListSections(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_list_sections", args, ListSectionsCore);
        }

        private object ListSectionsCore(Dictionary<string, object> args)
        {
            int maxSections = JsonUtils.GetInt(args, "max_sections", 50).Value;
            LasSectionListResult result = LasAutomation.ListSections(maxSections);
            string description = string.Format(
                "Сечений: {0}; пикеты {1:F3}..{2:F3}{3}.",
                result.TotalCount, result.FirstStation, result.LastStation,
                result.Truncated ? " (список усечён)" : "");
            List<object> steps = new List<object>();
            if (result.TotalCount == 0)
                steps.Add(ToolResult.Step("las_generate_sections",
                    "сечений нет — авторазбивка (например, шаг 1 м)",
                    new Dictionary<string, object> { { "step", 1.0 } }));
            else
                steps.Add(ToolResult.Step("las_build_terrain",
                    "построить ЦММ по существующим сечениям (step не задавать)",
                    new Dictionary<string, object> { { "thickness", 0.25 } }));
            return ToolResult.Ok(result, description, steps.ToArray());
        }

        [ToolDef(
            Name = "las_generate_sections",
            Description = "[ROBOLAS] Авторазбивка сечений активной трассы с равным шагом (аналог команды «ЦММ (шаг 1 м)» / «ЦММ (заданный шаг)»). ВНИМАНИЕ: ЗАМЕНЯЕТ существующие сечения (транзакция с откатом при сбое). Обычно вызывается перед первым las_build_terrain; дальше вызывайте las_build_terrain с тем же step.",
            InputSchema = @"{""type"":""object"",""properties"":{""step"":{""type"":""number"",""description"":""Шаг между сечениями, метры (обычно 1.0)."",""exclusiveMinimum"":0},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""step""],""additionalProperties"":false}",
            DestructiveHint = true,
            IdempotentHint = true)]
        public object GenerateSections(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_generate_sections", args, GenerateSectionsCore);
        }

        private object GenerateSectionsCore(Dictionary<string, object> args)
        {
            double step = JsonUtils.RequireDouble(args, "step");
            LasTerrainResult result = LasAutomation.GenerateSections(step);
            string description = string.Format(
                "Создано сечений: {0} (шаг {1} м).",
                result.SectionsCreated, step);
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_build_terrain",
                    "построить ЦММ по созданным сечениям; step повторно не задавать",
                    new Dictionary<string, object> { { "thickness", 0.25 } }),
                ToolResult.Step("las_list_sections",
                    "посмотреть id/пикеты сечений (нужно для CRS-полигонов)",
                    new Dictionary<string, object> { { "max_sections", 20 } }));
        }

        [ToolDef(
            Name = "las_activate_surface_view",
            Description = "[ROBOLAS] Делает активным видовым экраном вид со слоем ЦММ активной трассы: ищет слой ЦММ на активном виде, затем среди открытых окон (включая поперечники), затем открывает узел ЦММ из дерева модели трассы. Требуется перед las_build_terrain / las_build_surface_by_polygons, если активен другой вид (признак ошибки: «Не найден слой ЦММ на видовом экране»). Возвращает: найден ли слой, число точек/треугольников поверхности, диагностику просмотренных видов/узлов. UI-действие: переключает активное окно Robur; данные проекта не меняются.",
            InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            IdempotentHint = true)]
        public object ActivateSurfaceView(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_activate_surface_view", args, ActivateSurfaceViewCore);
        }

        private object ActivateSurfaceViewCore(Dictionary<string, object> args)
        {
            LasSurfaceViewState result = LasAutomation.ActivateSurfaceView();
            string description = result.HasSurface
                ? string.Format("Вид со слоем ЦММ активен ({0}); ЦММ: {1} точек, {2} треугольников.",
                    result.ActivatedView, result.SurfacePoints, result.SurfaceTriangles)
                : "Вид со слоем ЦММ не активирован: " + result.Note;
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_build_terrain",
                    "строить ЦММ по сечениям активной трассы (толщина слайса обычно 0.25)",
                    new Dictionary<string, object> { { "thickness", 0.25 } }),
                ToolResult.Step("las_get_context",
                    "проверить состояние поверхности после активации вида",
                    ToolResult.NoArgs()));
        }

        [ToolDef(
            Name = "las_build_terrain",
            Description = "[ROBOLAS] ГЛАВНЫЙ СЦЕНАРИЙ: построение ЦММ — сбор LAS-точек по сечениям активной трассы, фильтрация земли (по настройкам las_set_settings) и вставка опорных точек в поверхность ЦММ проекта. thickness — полная толщина слайса в метрах (обычно 0.1–1.0; больше — плотнее). step задан — сечения пересоздаются с этим шагом; step не задан — используются существующие сечения (их должна быть хотя бы 1). Требует активный видовой экран со слоем ЦММ (иначе вызови las_activate_crs_view). Операция меняет ЦММ; прогресс виден в Robur; отмена пользователем вернёт cancelled=true без ошибки. При 'слишком много точек' — сначала las_reduce_cloud.",
            InputSchema = @"{""type"":""object"",""properties"":{""thickness"":{""type"":""number"",""description"":""Полная толщина слайса, метры (0.1–1.0; по умолчанию 0.25)."",""exclusiveMinimum"":0},""step"":{""type"":""number"",""description"":""Шаг сечений, метры. Задан — сечения пересоздаются (ЗАМЕНЯЕТ существующие); не задан — используются существующие сечения."",""exclusiveMinimum"":0},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""thickness""],""additionalProperties"":false}",
            DestructiveHint = true)]
        public object BuildTerrain(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_build_terrain", args, BuildTerrainCore);
        }

        private object BuildTerrainCore(Dictionary<string, object> args)
        {
            double thickness = JsonUtils.RequireDouble(args, "thickness");
            double? step = JsonUtils.GetDouble(args, "step", null);
            LasTerrainResult result = LasAutomation.BuildTerrain(thickness, step);
            string description = result.Cancelled
                ? "Построение ЦММ отменено пользователем; проверьте состояние проекта через las_get_context."
                : string.Format(
                    "Собрано точек: {0}; вставлено в ЦММ: {1}; сечений: {2} (режим {3}).",
                    result.PointsCollected, result.PointsInserted,
                    result.SectionsCreated, result.Mode);
            List<object> steps = new List<object>();
            if (result.Cancelled)
                steps.Add(ToolResult.Step("las_get_context",
                    "проверить состояние проекта после отмены",
                    ToolResult.NoArgs()));
            else
                steps.Add(ToolResult.Step("las_get_context",
                    "проверить рост surface_points после вставки",
                    ToolResult.NoArgs()));
            steps.Add(ToolResult.Step("las_reduce_cloud",
                "если точек слишком много для следующего прохода — проредить облако",
                new Dictionary<string, object> { { "percent", 20 }, { "output_path", @"D:\exports\reduced.las" } }));
            return ToolResult.Ok(result, description, steps.ToArray());
        }
    }
}
