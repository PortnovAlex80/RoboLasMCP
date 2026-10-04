// Mcp/Tools/LasContextTools.cs
// Контекстные тулзы RoboLas: снимок проекта, справочник сценариев,
// список/активация трасс. Все — read-only кроме активации трассы.
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasContextTools : ToolProvider
    {
        [ToolDef(
            Name = "las_get_context",
            Description = "[ROBOLAS] Сводное состояние проекта для плагина RoboLas (LAS→ЦММ): активный проект, активная трасса, число сечений и диапазон пикетов, состояние ЦММ (точки/треугольники), подключённые LAS-облака (файлы, суммарно точек), режимы сбора и фильтрации. НАЧИНАЙТЕ ЛЮБУЮ РАБОТУ С ЭТОГО ТУЛА: ответ показывает, чего не хватает (трасса/облако/сечения) и какой тул звать дальше.",
            InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object GetContext(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_context", args, GetContextCore);
        }

        private object GetContextCore(Dictionary<string, object> args)
        {
            LasAutomationContext ctx = LasAutomation.GetContext();
            List<object> steps = new List<object>();
            if (!ctx.HasActiveAlignment)
            {
                steps.Add(ToolResult.Step("las_list_alignments",
                    "нет активной трассы — получить список трасс проекта",
                    ToolResult.NoArgs()));
                steps.Add(ToolResult.Step("las_set_active_alignment",
                    "затем активировать нужную трассу по имени",
                    new Dictionary<string, object> { { "name", "<имя из las_list_alignments>" } }));
            }
            else if (!ctx.HasLidarSource)
            {
                steps.Add(ToolResult.Step("las_get_workflow_guide",
                    "у активной трассы нет LAS-облака — см. раздел подготовки в справочнике",
                    ToolResult.NoArgs()));
            }
            else if (ctx.SectionsCount == 0)
            {
                steps.Add(ToolResult.Step("las_generate_sections",
                    "у трассы нет сечений — авторазбивка сечений (замена существующих)",
                    new Dictionary<string, object> { { "step", 1.0 } }));
            }
            else
            {
                steps.Add(ToolResult.Step("las_build_terrain",
                    "основной сценарий: собрать точки, отфильтровать землю и вставить в ЦММ",
                    new Dictionary<string, object> { { "thickness", 0.25 }, { "step", 1.0 } }));
                steps.Add(ToolResult.Step("las_reduce_cloud",
                    "альтернатива: проредить облако в новый LAS-файл",
                    new Dictionary<string, object> { { "percent", 20 }, { "output_path", @"D:\out\reduced.las" } }));
                steps.Add(ToolResult.Step("las_list_polygons",
                    "работа с полигонами (удаление точек / ЦММ по полигонам)",
                    new Dictionary<string, object> { { "scope", "plan" } }));
            }
            steps.Add(ToolResult.Step("las_get_workflow_guide",
                "полный справочник сценариев RoboLas с цепочками тулов",
                ToolResult.NoArgs()));
            string description = string.Format(
                "Проект: {0}; трасса: {1}; сечений: {2}; LAS: {3}; точек ЦММ: {4}.",
                ctx.ProjectAlias ?? "(нет)",
                ctx.HasActiveAlignment ? ctx.ActiveAlignment ?? "?" : "НЕТ",
                ctx.SectionsCount,
                ctx.HasLidarSource ? string.Join("; ", ctx.LidarFiles.ToArray()) : "НЕТ",
                ctx.HasSurface ? ctx.SurfacePoints.ToString() : "нет ЦММ");
            return ToolResult.Ok(ctx, description, steps.ToArray());
        }

        [ToolDef(
            Name = "las_get_workflow_guide",
            Description = "[ROBOLAS] Справочник сценариев плагина RoboLas: полные цепочки тулов (какой тул за каким и с какими аргументами) для построения ЦММ по LAS, прореживания/разделения облака, удаления точек по полигонам и построения ЦММ по полигонам. Вызывайте, когда не ясно, какой тул нужен следующим, или перед началом незнакомого сценария.",
            InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object GetWorkflowGuide(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_workflow_guide", args, GetWorkflowGuideCore);
        }

        private object GetWorkflowGuideCore(Dictionary<string, object> args)
        {
            object guide = new Dictionary<string, object>
            {
                { "intro",
                    "RoboLas обрабатывает LAS-облака вдоль трасс железных дорог в Topomatic Robur. " +
                    "Обязательные условия для любых операций: открытый проект, АКТИВНАЯ трасса с ЦММ, " +
                    "содержащим точки LAS (включённые для отображения), открытый видовой экран (план). " +
                    "Долгие операции показывают прогресс-бар в Robur и могут быть отменены пользователем. " +
                    "Операции выполняются последовательно. После timeout не повторяйте запись вслепую: " +
                    "сохраните request_id, дождитесь завершения Robur и запросите las_get_operation. " +
                    "Для контракта harness сначала прочитайте las_get_capabilities." },
                { "scenarios", new object[]
                    {
                        new Dictionary<string, object>
                        {
                            { "name", "1. Построение ЦММ по LAS вдоль трассы (главный сценарий)" },
                            { "goal", "Из облака LAS собрать точки по сечениям трассы, отфильтровать землю (рельеф) и вставить опорные точки в ЦММ проекта." },
                            { "steps", new object[]
                                {
                                    ToolResult.ScenarioStep("las_get_context", ToolResult.NoArgs(),
                                        "проверить: трасса активна, LAS подключён, ЦММ есть"),
                                    ToolResult.ScenarioStep("las_set_active_alignment",
                                        new Dictionary<string, object> { { "name", "<имя трассы>" } },
                                        "если активной трассы нет или нужна другая"),
                                    ToolResult.ScenarioStep("las_generate_sections",
                                        new Dictionary<string, object> { { "step", 1.0 } },
                                        "разбить трассу сечениями с шагом 1 м (можно пропустить, если сечения уже есть; ВНИМАНИЕ: заменяет существующие сечения)"),
                                    ToolResult.ScenarioStep("las_build_terrain",
                                        new Dictionary<string, object> { { "thickness", 0.25 } },
                                        "сбор + фильтрация + вставка в ЦММ; thickness — полная толщина слайса в метрах (0.1–1.0); если step не задан — используются существующие сечения"),
                                    ToolResult.ScenarioStep("las_get_context", ToolResult.NoArgs(),
                                        "проверить, что surface_points выросло")
                                }
                            }
                        },
                        new Dictionary<string, object>
                        {
                            { "name", "2. Прореживание облака (уменьшить вес LAS-файла)" },
                            { "goal", "Создать новый LAS с процентом точек (опционально — только точки земли). Исходное облако не меняется." },
                            { "steps", new object[]
                                {
                                    ToolResult.ScenarioStep("las_get_context", ToolResult.NoArgs(),
                                        "проверить готовность (трасса/LAS)"),
                                    ToolResult.ScenarioStep("las_reduce_cloud",
                                        new Dictionary<string, object>
                                        {
                                            { "percent", 20 },
                                            { "output_path", @"D:\exports\reduced.las" },
                                            { "ground_filter", false }
                                        },
                                        "percent 1..100; ground_filter=true оставляет только точки земли (3D ground-фильтр). Результат нужно импортировать в Robur вручную."),
                                }
                            }
                        },
                        new Dictionary<string, object>
                        {
                            { "name", "3. Разделение облака на полосу и обочины" },
                            { "goal", "Два LAS: полоса трассы ±offsets (плотнее) и обочины (реже)." },
                            { "steps", new object[]
                                {
                                    ToolResult.ScenarioStep("las_split_by_offset",
                                        new Dictionary<string, object>
                                        {
                                            { "left_offset", 5.0 },
                                            { "right_offset", 5.0 },
                                            { "percent_center", 50 },
                                            { "percent_edge", 10 },
                                            { "output_path", @"D:\exports\center.las" }
                                        },
                                        "output_path — путь центрального файла; файл обочин '<имя>_edge.las' создаётся рядом автоматически")
                                }
                            }
                        },
                        new Dictionary<string, object>
                        {
                            { "name", "4. Удаление точек по полигонам (очистка шума)" },
                            { "goal", "Обвести зоны шума полигонами и выгрузить новый LAS без этих точек." },
                            { "steps", new object[]
                                {
                                    ToolResult.ScenarioStep("las_list_polygons",
                                        new Dictionary<string, object> { { "scope", "plan" } },
                                        "посмотреть существующие полигоны (scope: plan — вид сверху, мировые X,Y; crs — поперечник, локальные offset,Z + привязка к сечению)"),
                                    ToolResult.ScenarioStep("las_add_polygon",
                                        new Dictionary<string, object>
                                        {
                                            { "scope", "plan" },
                                            { "vertices", new double[][] { new double[] { 0, 0 }, new double[] { 10, 0 }, new double[] { 10, 10 }, new double[] { 0, 10 } } }
                                        },
                                        "добавить полигон вершинами [[x,y],...] (минимум 3); для scope=crs дополнительно section_id или station и thickness"),
                                    ToolResult.ScenarioStep("las_delete_points_by_polygons",
                                        new Dictionary<string, object> { { "scope", "plan" }, { "output_path", @"D:\exports\cleaned.las" } },
                                        "экспорт нового LAS без точек из полигонов; после успешной публикации полигоны очищаются; исходное облако не меняется")
                                }
                            }
                        },
                        new Dictionary<string, object>
                        {
                            { "name", "5. Локальная ЦММ по полигонам плана" },
                            { "goal", "Построить поверхность только внутри полигонов: сеткой min-Z (с характерными точками) или полиномом." },
                            { "steps", new object[]
                                {
                                    ToolResult.ScenarioStep("las_list_polygons",
                                        new Dictionary<string, object> { { "scope", "plan" } },
                                        "нужны полигоны plan; если нет — las_add_polygon"),
                                    ToolResult.ScenarioStep("las_build_surface_by_polygons",
                                        new Dictionary<string, object> { { "method", "grid" } },
                                        "method: 'grid' (сетка min-Z + детекция бровок) или 'polynomial' (Z=f(x,y); степень и шаг — las_set_settings)"),
                                    ToolResult.ScenarioStep("las_get_context", ToolResult.NoArgs(),
                                        "проверить рост точек ЦММ")
                                }
                            }
                        }
                    }
                },
                { "common_rules", new string[]
                    {
                        "Тулзы меняют проект: las_generate_sections (замена сечений), las_build_terrain и las_build_surface_by_polygons (добавление точек в ЦММ), las_clear_polygons и las_delete_points_by_polygons (очистка полигонов). Осторожно на больших данных.",
                        "Экспортные тулзы (reduce/split/delete_points) НЕ меняют облако в проекте — они пишут новый LAS-файл; результат импортируется в Robur вручную.",
                        "Ошибки 'уже выполняется' — повторите вызов после завершения текущей операции.",
                        "Настройки фильтрации/сеток — las_get_settings / las_set_settings (действуют на последующие операции)."
                    }
                }
            };
            return ToolResult.Ok(guide,
                "Справочник сценариев RoboLas: 5 сценариев с цепочками тулов.",
                ToolResult.Step("las_get_context", "проверить готовность проекта", ToolResult.NoArgs()));
        }

        [ToolDef(
            Name = "las_list_alignments",
            Description = "[ROBOLAS] Список всех трасс проекта RoboLas (rail/alignment моделей) с признаком активной. Используйте перед las_set_active_alignment, чтобы взять точное имя.",
            InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object ListAlignments(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_list_alignments", args, ListAlignmentsCore);
        }

        private object ListAlignmentsCore(Dictionary<string, object> args)
        {
            List<LasAlignmentInfo> alignments = LasAutomation.ListAlignments();
            List<object> steps = new List<object>();
            LasAlignmentInfo first = alignments.Count > 0 ? alignments[0] : null;
            if (first != null && !first.IsActive)
                steps.Add(ToolResult.Step("las_set_active_alignment",
                    "активировать трассу (пример для первой из списка)",
                    new Dictionary<string, object> { { "name", first.Name } }));
            else if (first != null)
                steps.Add(ToolResult.Step("las_get_context",
                    "трасса уже активна — проверить готовность к операциям",
                    ToolResult.NoArgs()));
            string description = alignments.Count == 0
                ? "Трассы в проекте не найдены."
                : string.Format("Найдено трасс: {0}.", alignments.Count);
            return ToolResult.Ok(alignments, description, steps.ToArray());
        }

        [ToolDef(
            Name = "las_set_active_alignment",
            Description = "[ROBOLAS] Делает трассу активной (аналог «Сделать текущей» в Robur): открывает модель трассы и активирует её. Имя — точное из las_list_alignments (Alias или имя файла модели). После активации проверьте las_get_context: у трассы должны быть LAS-облако и ЦММ.",
            InputSchema = @"{""type"":""object"",""properties"":{""name"":{""type"":""string"",""description"":""Имя трассы из las_list_alignments.""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""name""],""additionalProperties"":false}",
            IdempotentHint = true)]
        public object SetActiveAlignment(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_set_active_alignment", args, SetActiveAlignmentCore);
        }

        private object SetActiveAlignmentCore(Dictionary<string, object> args)
        {
            string name = JsonUtils.RequireString(args, "name");
            LasAlignmentActivationResult result = LasAutomation.SetActiveAlignment(name);
            List<object> steps = new List<object>();
            steps.Add(ToolResult.Step("las_get_context",
                "проверить: у трассы есть LAS-облако и ЦММ",
                ToolResult.NoArgs()));
            steps.Add(ToolResult.Step("las_generate_sections",
                "если сечений нет — авторазбивка",
                new Dictionary<string, object> { { "step", 1.0 } }));
            return ToolResult.Ok(result, "Активирована трасса: " + name, steps.ToArray());
        }
    }
}
