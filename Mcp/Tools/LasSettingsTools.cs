// Mcp/Tools/LasSettingsTools.cs
// Настройки RoboLas: чтение и изменение параметров фильтрации/поверхностей.
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal sealed class LasSettingsTools : ToolProvider
    {
        [ToolDef(
            Name = "las_get_settings",
            Description = "[ROBOLAS] Текущие настройки плагина RoboLas: алгоритм фильтрации земли (use_spline_filter: spline/мин-вес), допуск рельефа (split_merge_tolerance), ширина коридора CRS (crs_overlay_border), шаг сетки (grid_step), параметры полинома (polynomial_degree 1..3, polynomial_regularization, polynomial_grid_step), режим сбора (onepass_active), детекция разрывов (enable_break_detection) и параметры сплайна.",
            InputSchema = @"{""type"":""object"",""properties"":{""request_id"":{""type"":""string"",""minLength"":1,""description"":""Unique write request ID; replay limited to retained process history.""},""expected_context"":{""type"":""string"",""minLength"":64,""description"":""Fingerprint from las_preflight; checked before execution.""}},""additionalProperties"":false}",
            ReadOnlyHint = true,
            IdempotentHint = true)]
        public object GetSettings(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_get_settings", args, GetSettingsCore);
        }

        private object GetSettingsCore(Dictionary<string, object> args)
        {
            Dictionary<string, object> settings = LasAutomation.GetSettings();
            return ToolResult.Ok(new Dictionary<string, object> {
                { "values", settings }, { "schema", PluginSettings.Describe() },
                { "read_only", new string[] { "max_filter_border" } }
            }, "Все настройки RoboLas и их допустимые значения.",
                ToolResult.Step("las_set_settings",
                    "изменить настройки (действуют на последующие операции)",
                    new Dictionary<string, object> { { "split_merge_tolerance", 0.07 } }));
        }

        [ToolDef(
            Name = "las_set_settings",
            Description = "[ROBOLAS] Изменяет настройки RoboLas; передавайте только изменяемые поля. Ключевые: use_spline_filter (true=spline-фильтр земли, false=медиана), split_merge_tolerance (допуск рельефа, м), crs_overlay_border (ширина коридора поперечника, м, максимум фильтрации 10), grid_step (шаг сетки min-Z), polynomial_degree (1..3), polynomial_regularization, polynomial_grid_step. Персистентные поля сохраняются в настройках Robur.",
            InputSchema = SettingsSchema.Patch,
            IdempotentHint = true)]
        public object SetSettings(Dictionary<string, object> args)
        {
            return McpToolContract.Execute("las_set_settings", args, SetSettingsCore);
        }

        private object SetSettingsCore(Dictionary<string, object> args)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> pair in args)
            {
                Newtonsoft.Json.Linq.JValue token = pair.Value as Newtonsoft.Json.Linq.JValue;
                values.Add(pair.Key, token == null ? pair.Value : token.Value);
            }
            Dictionary<string, object> applied = LasAutomation.ApplySettings(values);
            return ToolResult.Ok(applied, "Настройки применены (действуют на последующие операции).",
                ToolResult.Step("las_build_terrain",
                    "пересчитать ЦММ с новыми настройками",
                    new Dictionary<string, object> { { "thickness", 0.25 } }));
        }

        private static bool? GetBool(Dictionary<string, object> args, string key)
        {
            bool? value = JsonUtils.GetBool(args, key, null);
            return value;
        }

        private static double? GetDouble(Dictionary<string, object> args, string key)
        {
            double? value = JsonUtils.GetDouble(args, key, null);
            return value;
        }

        private static int? GetInt(Dictionary<string, object> args, string key)
        {
            int? value = JsonUtils.GetInt(args, key, null);
            return value;
        }
    }
}
