// Mcp/ToolResult.cs
// Единая обёртка ответа тулзы RoboLas и построитель подсказок next_steps.
// Каждый ответ — JSON-объект вида:
//   { "result": <данные>, "description": "сводка для человека",
//     "status": "ok", "next_steps": [ { "tool", "when", "args" } ] }
// next_steps подсказывают агенту следующий тул сценария и пример аргументов.
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    internal static class ToolResult
    {
        internal static Dictionary<string, object> Ok(object result,
            string description, params object[] nextSteps)
        {
            return new Dictionary<string, object>
            {
                { "result", result },
                { "description", description },
                { "status", "ok" },
                { "next_steps", nextSteps }
            };
        }

        /// <summary>Подсказка следующего тула: имя, когда вызывать, пример аргументов.</summary>
        internal static Dictionary<string, object> Step(string tool, string when, object args)
        {
            return new Dictionary<string, object>
            {
                { "tool", tool },
                { "when", when },
                { "args", args }
            };
        }

        /// <summary>Шаг сценария для las_get_workflow_guide.</summary>
        internal static Dictionary<string, object> ScenarioStep(string tool, object args, string why)
        {
            return new Dictionary<string, object>
            {
                { "tool", tool },
                { "args", args },
                { "why", why }
            };
        }

        internal static Dictionary<string, object> NoArgs()
        {
            return new Dictionary<string, object>();
        }

        // ─────────────── Разбор аргументов (JToken из моста) ───────────────

        internal static double[][] Vertices(Dictionary<string, object> source, string key)
        {
            object raw;
            if (source == null || !source.TryGetValue(key, out raw) || raw == null)
                throw new ArgumentException(key + " обязателен: массив вершин [[x, y], ...] (минимум 3).");
            JArray array = raw as JArray;
            if (array == null)
                throw new ArgumentException(key + " должен быть массивом пар чисел [x, y].");
            double[][] result = new double[array.Count][];
            for (int i = 0; i < array.Count; i++)
            {
                JArray pair = array[i] as JArray;
                if (pair == null || pair.Count < 2)
                    throw new ArgumentException(key + "[" + i + "] должен быть парой чисел [x, y].");
                result[i] = new double[] { ToDouble(pair[0]), ToDouble(pair[1]) };
            }
            return result;
        }

        private static double ToDouble(JToken token)
        {
            JValue value = token as JValue;
            if (value == null || value.Value == null)
                throw new ArgumentException("Ожидалось число.");
            return Convert.ToDouble(value.Value, CultureInfo.InvariantCulture);
        }
    }
}
