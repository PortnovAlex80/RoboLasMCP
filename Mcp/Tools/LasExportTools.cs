// Mcp/Tools/LasExportTools.cs
// Экспортные тулзы RoboLas: прореживание облака и разделение на полосу/обочины.
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasExportTools : ToolProvider
    {
        [ToolDef(
            Name = "las_reduce_cloud",
            Description = "[ROBOLAS] Прореживание облака вдоль активной трассы: собирает слайсы толщиной 1 м, опционально оставляет только точки земли (3D ground-фильтр), редуцирует до percent% и пишет НОВЫЙ LAS 1.2 (Point Format 1). Исходное облако в проекте НЕ меняется. При 'слишком много точек' уменьшите percent или включите ground_filter. Отмена пользователем вернёт cancelled=true.",
            InputSchema = @"{""type"":""object"",""properties"":{""percent"":{""type"":""number"",""description"":""Процент точек для сохранения, 1..100."",""minimum"":1,""maximum"":100},""output_path"":{""type"":""string"",""description"":""Абсолютный путь выходного .las файла."",""minLength"":1},""ground_filter"":{""type"":""boolean"",""description"":""true — перед редукцией оставить только точки земли (GraphGround3D).""},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""percent"",""output_path""],""additionalProperties"":false}",
            IdempotentHint = true)]
        public object ReduceCloud(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_reduce_cloud", args, ReduceCloudCore);
        }

        private object ReduceCloudCore(Dictionary<string, object> args)
        {
            double percent = JsonUtils.RequireDouble(args, "percent");
            string outputPath = JsonUtils.RequireString(args, "output_path");
            bool groundFilter = JsonUtils.GetBool(args, "ground_filter", false).Value;
            LasReduceResult result = LasAutomation.ReduceCloud(percent, outputPath, groundFilter);
            string description;
            if (result.Cancelled)
                description = "Прореживание отменено пользователем; файл не опубликован.";
            else if (!result.Published)
                description = result.Note ?? "Файл не создан.";
            else
                description = string.Format(
                    "Сохранено {0} точек ({1:F1}% из {2}; ground-фильтр: {3}): {4}",
                    result.TotalReduced, result.Percent, result.TotalRaw,
                    result.GroundFilterUsed ? "да" : "нет", result.OutputPath);
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_get_workflow_guide",
                    "что делать с результатом (импорт в Robur) и другие сценарии",
                    ToolResult.NoArgs()));
        }

        [ToolDef(
            Name = "las_split_by_offset",
            Description = "[ROBOLAS] Разделение облака на ДВА LAS: полоса трассы (в пределах left_offset/right_offset от оси, редукция percent_center%) и обочины (вне полосы, редукция percent_edge%). output_path — путь файла ПОЛОСЫ; файл обочин '<имя>_edge.las' создаётся рядом автоматически. Исходное облако в проекте не меняется. При незавершённой предыдущей публикации повторный вызов с тем же путём восстановит пару без пересчёта. Отмена пользователем возвращает cancelled=true без ошибки.",
            InputSchema = @"{""type"":""object"",""properties"":{""left_offset"":{""type"":""number"",""description"":""Граница полосы слева от оси, метры (положительное число)."",""minimum"":0},""right_offset"":{""type"":""number"",""description"":""Граница полосы справа от оси, метры (положительное число)."",""minimum"":0},""percent_center"":{""type"":""number"",""description"":""Процент точек полосы, 1..100."",""minimum"":1,""maximum"":100},""percent_edge"":{""type"":""number"",""description"":""Процент точек обочин, 1..100."",""minimum"":1,""maximum"":100},""output_path"":{""type"":""string"",""description"":""Абсолютный путь выходного .las файла ПОЛОСЫ."",""minLength"":1},""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""required"":[""left_offset"",""right_offset"",""percent_center"",""percent_edge"",""output_path""],""additionalProperties"":false}",
            IdempotentHint = true)]
        public object SplitByOffset(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_split_by_offset", args, SplitByOffsetCore);
        }

        private object SplitByOffsetCore(Dictionary<string, object> args)
        {
            double leftOffset = JsonUtils.RequireDouble(args, "left_offset");
            double rightOffset = JsonUtils.RequireDouble(args, "right_offset");
            double percentCenter = JsonUtils.RequireDouble(args, "percent_center");
            double percentEdge = JsonUtils.RequireDouble(args, "percent_edge");
            string outputPath = JsonUtils.RequireString(args, "output_path");
            LasSplitResult result = LasAutomation.SplitByOffset(leftOffset, rightOffset,
                percentCenter, percentEdge, outputPath);
            string description = result.Recovered
                ? "Восстановлена незавершённая публикация пары LAS без повторного расчёта."
                : result.Published
                    ? string.Format("Сохранено: полоса {0} точек → {1}; обочины {2} точек → {3}",
                        result.CenterPoints, result.PrimaryPath, result.EdgePoints, result.EdgePath)
                    : (result.Note ?? "Файлы не созданы.");
            return ToolResult.Ok(result, description,
                ToolResult.Step("las_get_workflow_guide",
                    "что делать с результатом (импорт в Robur) и другие сценарии",
                    ToolResult.NoArgs()));
        }
    }
}
