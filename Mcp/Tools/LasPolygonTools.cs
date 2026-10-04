// Mcp/Tools/LasPolygonTools.cs
// Полигоны RoboLas: просмотр/добавление/очистка, удаление точек по полигонам
// и построение ЦММ по полигонам плана.
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasPolygonTools : ToolProvider
    {
        [ToolDef(
            Name = "las_save_polygons",
            Description = "[ROBOLAS] Сохранить каждый полигон scope=plan/crs в отдельный переносимый JSON: ИмяПроекта.план.полигон.001.json (или поперечник). output_directory — абсолютный путь к папке. overwrite=false защищает существующие файлы. Проект не меняется. При ошибке сообщаются уже записанные файлы; набор файлов не является одной атомарной записью.",
            InputSchema = @"{""type"":""object"",""properties"":{""scope"":{""type"":""string"",""enum"":[""plan"",""crs""]},""output_directory"":{""type"":""string"",""minLength"":1},""overwrite"":{""type"":""boolean"",""default"":false},""request_id"":{""type"":""string"",""minLength"":1},""expected_context"":{""type"":""string"",""minLength"":64}},""required"":[""scope"",""output_directory""],""additionalProperties"":false}",
            DestructiveHint = true,
            IdempotentHint = false)]
        public object SavePolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_save_polygons", args, SavePolygonsCore);
        }

        private object SavePolygonsCore(Dictionary<string, object> args)
        {
            Dictionary<string, object> result = LasAutomation.SavePolygons(JsonUtils.RequireString(args, "scope"),
                JsonUtils.RequireString(args, "output_directory"), JsonUtils.GetBool(args, "overwrite", false).Value);
            if ((int)result["saved"] == 0)
                return ToolResult.Ok(result, "Полигонов для сохранения нет.",
                    ToolResult.Step("las_list_polygons", "проверить выбранный набор полигонов",
                        new Dictionary<string, object> { { "scope", result["scope"] } }));
            if ((string)result["scope"] == "crs")
                return ToolResult.Ok(result, "Переносимые JSON-файлы поперечных полигонов сохранены.",
                    ToolResult.Step("las_list_sections", "в проекте назначения выбрать section_id или station перед las_load_polygons",
                        ToolResult.NoArgs()));
            return ToolResult.Ok(result, "Переносимые JSON-файлы полигонов сохранены.",
                ToolResult.Step("las_load_polygons", "загрузить сохранённые файлы в нужный проект; для CRS явно выбрать section_id или station",
                    new Dictionary<string, object> { { "paths", result["paths"] } }));
        }

        [ToolDef(
            Name = "las_load_polygons",
            Description = "[ROBOLAS] Загрузить переносимые JSON-полигоны из массива абсолютных paths и добавить к существующим. Все файлы проверяются до одной записи проекта. План сохраняет мировые X/Y: системы координат проектов должны совпадать. Для CRS ОБЯЗАТЕЛЬНО явно указать section_id или station существующего сечения; контуры offset/Z привязываются к нему. План и CRS загружаются отдельными вызовами.",
            InputSchema = @"{""type"":""object"",""properties"":{""paths"":{""type"":""array"",""minItems"":1,""items"":{""type"":""string"",""minLength"":1}},""section_id"":{""type"":""integer"",""minimum"":0,""maximum"":4294967295},""station"":{""type"":""number""},""request_id"":{""type"":""string"",""minLength"":1},""expected_context"":{""type"":""string"",""minLength"":64}},""required"":[""paths""],""additionalProperties"":false}",
            IdempotentHint = false)]
        public object LoadPolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_load_polygons", args, LoadPolygonsCore);
        }

        private object LoadPolygonsCore(Dictionary<string, object> args)
        {
            string[] paths = Newtonsoft.Json.Linq.JToken.FromObject(args["paths"]).ToObject<string[]>();
            Dictionary<string, object> result = LasAutomation.LoadPolygons(paths, GetUInt(args, "section_id"),
                JsonUtils.GetDouble(args, "station", null));
            return ToolResult.Ok(result, "Полигоны добавлены в текущий проект.",
                ToolResult.Step("las_list_polygons", "проверить загруженные полигоны",
                    new Dictionary<string, object> { { "scope", result["scope"] } }));
        }

        [ToolDef(
            Name = "las_list_polygons",
            Description = "[ROBOLAS] Полигоны scope'а активной трассы. scope=plan: вершины — мировые координаты X,Y плана (используются для удаления точек и ЦММ по полигонам). scope=crs: вершины — ЛОКАЛЬНЫЕ координаты поперечника [offset, Z] + привязка к сечению (section_id, station, thickness).",
            InputSchema = @"{""type"":""object"",""properties"":{""scope"":{""type"":""string"",""enum"":[""plan"",""crs""],""description"":""plan — вид сверху; crs — поперечники.""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""scope""],""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object ListPolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_list_polygons", args, ListPolygonsCore);
        }

        private object ListPolygonsCore(Dictionary<string, object> args)
        {
            string scope = JsonUtils.RequireString(args, "scope");
            LasPolygonListResult result = LasAutomation.ListPolygons(scope);
            List<object> steps = new List<object>();
            if (result.Count == 0)
            {
                steps.Add(ToolResult.Step("las_add_polygon",
                    "добавить полигон вершинами (минимум 3)",
                    new Dictionary<string, object>
                    {
                        { "scope", result.Scope },
                        { "vertices", new double[][] { new double[] { 0, 0 }, new double[] { 10, 0 }, new double[] { 10, 10 } } }
                    }));
                if (result.Scope == "crs")
                    steps.Add(ToolResult.Step("las_list_sections",
                        "для CRS-полигонов нужны id/пикеты сечений",
                        new Dictionary<string, object> { { "max_sections", 20 } }));
            }
            else
            {
                steps.Add(ToolResult.Step("las_delete_points_by_polygons",
                    "экспортировать LAS без точек полигонов (после успеха полигоны очистятся)",
                    new Dictionary<string, object> { { "scope", result.Scope }, { "output_path", @"D:\exports\cleaned.las" } }));
                if (result.Scope == "plan")
                    steps.Add(ToolResult.Step("las_build_surface_by_polygons",
                        "построить локальную ЦММ внутри полигонов",
                        new Dictionary<string, object> { { "method", "grid" } }));
                steps.Add(ToolResult.Step("las_clear_polygons",
                    "если полигоны больше не нужны — очистить",
                    new Dictionary<string, object> { { "scope", result.Scope } }));
            }
            return ToolResult.Ok(result,
                string.Format("Полигонов в scope '{0}': {1}.", result.Scope, result.Count),
                steps.ToArray());
        }

        [ToolDef(
            Name = "las_add_polygon",
            Description = "[ROBOLAS] Добавляет полигон в scope активной трассы (замена рисования мышью). scope=plan: vertices — мировые [[x,y],...] (координаты плана; минимум 3 вершины). scope=crs: vertices — локальные [[offset,Z],...] поперечника + ОБЯЗАТЕЛЬНА привязка к сечению: section_id (точный id) или station (пикет); thickness — полная толщина коридора (по умолчанию crs_overlay_border).",
            InputSchema = @"{""type"":""object"",""properties"":{""scope"":{""type"":""string"",""enum"":[""plan"",""crs""]},""vertices"":{""type"":""array"",""description"":""Вершины [[x, y], ...]; минимум 3."",""items"":{""type"":""array"",""items"":{""type"":""number""},""minItems"":2,""maxItems"":2},""minItems"":3},""section_id"":{""type"":""integer"",""description"":""scope=crs: id сечения из las_list_sections."",""minimum"":0,""maximum"":4294967295},""station"":{""type"":""number"",""description"":""scope=crs: пикет сечения (альтернатива section_id; берётся ближайшее, отклонение не более 1 мм).""},""thickness"":{""type"":""number"",""description"":""scope=crs: полная толщина коридора поперечника, м."",""exclusiveMinimum"":0},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""scope"",""vertices""],""additionalProperties"":false}")]
        public object AddPolygon(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_add_polygon", args, AddPolygonCore);
        }

        private object AddPolygonCore(Dictionary<string, object> args)
        {
            string scope = JsonUtils.RequireString(args, "scope");
            double[][] vertices = ToolResult.Vertices(args, "vertices");
            uint? sectionId = GetUInt(args, "section_id");
            double? station = JsonUtils.GetDouble(args, "station", null);
            double? thickness = JsonUtils.GetDouble(args, "thickness", null);
            LasPolygonMutationResult result = LasAutomation.AddPolygon(scope, vertices,
                sectionId, station, thickness);
            return ToolResult.Ok(result,
                string.Format("Полигон добавлен; всего в scope '{0}': {1}.",
                    result.Scope, result.TotalPolygons),
                ToolResult.Step("las_list_polygons",
                    "проверить набор полигонов",
                    new Dictionary<string, object> { { "scope", result.Scope } }),
                ToolResult.Step("las_delete_points_by_polygons",
                    "экспортировать LAS без точек полигонов",
                    new Dictionary<string, object> { { "scope", result.Scope }, { "output_path", @"D:\exports\cleaned.las" } }),
                ToolResult.Step("las_build_surface_by_polygons",
                    "или построить ЦММ по полигонам (scope=plan)",
                    new Dictionary<string, object> { { "method", "grid" } }));
        }

        [ToolDef(
            Name = "las_clear_polygons",
            Description = "[ROBOLAS] Удаляет ВСЕ полигоны scope'а активной трассы. Точки облака и ЦММ не затрагиваются. Операция необратима для набора полигонов.",
            InputSchema = @"{""type"":""object"",""properties"":{""scope"":{""type"":""string"",""enum"":[""plan"",""crs""]},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""scope""],""additionalProperties"":false}",
            DestructiveHint = true,
            IdempotentHint = true)]
        public object ClearPolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_clear_polygons", args, ClearPolygonsCore);
        }

        private object ClearPolygonsCore(Dictionary<string, object> args)
        {
            string scope = JsonUtils.RequireString(args, "scope");
            LasPolygonMutationResult result = LasAutomation.ClearPolygons(scope);
            return ToolResult.Ok(result,
                string.Format("Полигоны scope '{0}' очищены.", result.Scope),
                ToolResult.Step("las_list_polygons",
                    "убедиться, что набор пуст",
                    new Dictionary<string, object> { { "scope", result.Scope } }));
        }

        [ToolDef(
            Name = "las_delete_points_by_polygons",
            Description = "[ROBOLAS] Удаляет точки облака, попадающие в полигоны scope'а, и пишет результат в НОВЫЙ LAS 1.2: scope=plan — фильтрация по X,Y плана; scope=crs — по локальным координатам поперечников (offset,Z). Исходное облако в проекте НЕ меняется. После успешной публикации полигоны scope'а автоматически очищаются. Если точек для удаления нет — файл не создаётся, полигоны сохраняются. Отмена пользователем возвращает cancelled=true без ошибки.",
            InputSchema = @"{""type"":""object"",""properties"":{""scope"":{""type"":""string"",""enum"":[""plan"",""crs""]},""output_path"":{""type"":""string"",""description"":""Абсолютный путь выходного .las файла."",""minLength"":1},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""scope"",""output_path""],""additionalProperties"":false}",
            DestructiveHint = true)]
        public object DeletePointsByPolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_delete_points_by_polygons", args, DeletePointsByPolygonsCore);
        }

        private object DeletePointsByPolygonsCore(Dictionary<string, object> args)
        {
            string scope = JsonUtils.RequireString(args, "scope");
            string outputPath = JsonUtils.RequireString(args, "output_path");
            LasDeletePointsResult result = LasAutomation.DeletePointsByPolygons(scope, outputPath);
            string description = result.Published
                ? string.Format("Удалено точек: {0}; осталось: {1}. Файл: {2}",
                    result.Deleted, result.Kept, result.OutputPath)
                : (result.Note ?? "Файл не опубликован.");
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_get_workflow_guide",
                    "результат импортируется в Robur вручную; см. другие сценарии",
                    ToolResult.NoArgs()));
        }

        [ToolDef(
            Name = "las_build_surface_by_polygons",
            Description = "[ROBOLAS] Локальная ЦММ внутри полигонов ПЛАНА по точкам облака. method='grid': регулярная сетка min-Z + характерные точки (бровки/канавы) — рекомендуется по умолчанию; method='polynomial': полиномиальная поверхность Z=f(x,y) (степень/регуляризация/шаг — las_set_settings). Полигоны берутся из scope plan; вставка идёт в ЦММ активной трассы (проект изменяется). Отмена пользователем возвращает cancelled=true без ошибки.",
            InputSchema = @"{""type"":""object"",""properties"":{""method"":{""type"":""string"",""enum"":[""grid"",""polynomial""],""description"":""grid — сетка min-Z с характерными точками; polynomial — полиномиальная подгонка.""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""method""],""additionalProperties"":false}",
            DestructiveHint = true)]
        public object BuildSurfaceByPolygons(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_build_surface_by_polygons", args, BuildSurfaceByPolygonsCore);
        }

        private object BuildSurfaceByPolygonsCore(Dictionary<string, object> args)
        {
            string method = JsonUtils.RequireString(args, "method");
            LasSurfaceByPolygonsResult result = LasAutomation.BuildSurfaceByPolygons(method);
            string description = string.Format(
                "Метод: {0}; полигонов: {1}; точек в облаке: {2}; вставлено в ЦММ: {3}.",
                result.Method, result.Polygons, result.PointsInCloud, result.Inserted);
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_get_context",
                    "проверить рост surface_points",
                    ToolResult.NoArgs()));
        }

        private static uint? GetUInt(Dictionary<string, object> args, string key)
        {
            object value;
            if (!args.TryGetValue(key, out value) || value == null) return null;
            return System.Convert.ToUInt32(JsonUtils.UnwrapJsonValue(value), System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
