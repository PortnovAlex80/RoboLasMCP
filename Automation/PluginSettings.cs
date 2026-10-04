using System;
using System.Collections.Generic;
using System.Reflection;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Infrastructure;

namespace LAS_TERRAIN.Automation
{
    // One catalog for discovery, validation, MCP schema and host persistence.
    // The values are the plugin's actual preferences; no second MCP-only state.
    public static class PluginSettings
    {
        private sealed class Entry
        {
            internal string Key, Property, Type;
            internal double Minimum, Maximum;
            internal bool ExclusiveMinimum, Adapter;
            internal object Read()
            {
                if (Adapter) return typeof(GraphGround3DSettingsAdapter).GetField(Property,
                    BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
                return typeof(RuntimeConfig).GetProperty(Property).GetValue(null, null);
            }
            internal void Write(object value)
            {
                if (Adapter) typeof(GraphGround3DSettingsAdapter).GetField(Property,
                    BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, value);
                else typeof(RuntimeConfig).GetProperty(Property).SetValue(null, value, null);
            }
        }
        private static readonly Entry[] Entries = new Entry[]
        {
            B("use_spline_filter", "UseSplineFilter"),
            N("split_merge_tolerance", "SplitMergeTolerance", 0, Double.MaxValue, true),
            N("c_spline_smooth", "CSplineSmooth", 0, 10, false),
            N("crs_overlay_border", "CrsOverlayBorder", 0.001, 1000000, false),
            N("grid_step", "GridStep", 0.1, 100, false),
            I("polynomial_degree", "PolynomialDegree", 1, 3),
            N("polynomial_regularization", "PolynomialRegularization", 0, 1, false),
            N("polynomial_grid_step", "PolynomialGridStep", 0.1, 100, false),
            B("onepass_active", "OnePassActive"), B("enable_break_detection", "EnableBreakDetection"),
            N("graph_bin_x", "GraphBinX", 0, Double.MaxValue, true),
            N("graph_bin_y", "GraphBinY", 0, Double.MaxValue, true), I("graph_min_points", "GraphMinPts", 1, Int32.MaxValue),
            I("break_slope_window", "BreakSlopeWindow", 2, 100000),
            I("break_r2_window", "BreakR2Window", 3, 100000),
            N("break_angle_threshold", "BreakAngleThreshold", 0, Math.PI, false),
            N("break_min_r2", "BreakMinR2", 0, 1, false),
            I("break_min_segment_points", "BreakMinSegmentPoints", 2, 100000),
            I("break_suppress_radius", "BreakSuppressRadius", 1, 100000),
            I("spline_degree", "SplineDegree", 1, 3), I("spline_max_iterations", "SplineMaxIterations", 1, 10000),
            N("spline_sigma", "SplineSigma", 0, Double.MaxValue, true),
            N("spline_grid_step", "SplineGridStep", 0, 100, true),
            N("spline_convergence_tolerance", "SplineConvergenceTol", 0, 1, true),
            I("spline_auto_control_max", "SplineAutoCtrlMax", 4, 100000),
            N("spline_ridge_epsilon", "SplineRidgeEps", 0, 1, true),
            N("spline_max_gap_meters", "SplineMaxGapMeters", 0, Double.MaxValue, true),
            B("spline_enable_rail_filter", "SplineEnableRailFilter"),
            N("spline_rail_filter_window_meters", "SplineRailFilterWindowMeters", 0, Double.MaxValue, true),
            A("ground3d_bin_x", "BinX", false), A("ground3d_bin_y", "BinY", false),
            A("ground3d_bin_z", "BinZ", false), A("ground3d_min_points", "MinPts", true)
        };

        private static Entry B(string key, string property) { return new Entry { Key=key, Property=property, Type="boolean" }; }
        private static Entry N(string key, string property, double min, double max, bool exclusive)
        { return new Entry { Key=key, Property=property, Type="number", Minimum=min, Maximum=max, ExclusiveMinimum=exclusive }; }
        private static Entry I(string key, string property, int min, int max)
        { Entry e=N(key,property,min,max,false); e.Type="integer"; return e; }
        private static Entry A(string key, string field, bool integer)
        { Entry e=integer ? I(key,field,1,Int32.MaxValue) : N(key,field,0,Double.MaxValue,true); e.Adapter=true; return e; }

        public static Dictionary<string, object> Read()
        {
            lock (RuntimeConfig.SyncRoot)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (Entry e in Entries) result.Add(e.Key, e.Read());
                return result;
            }
        }

        public static Dictionary<string, object> Describe()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            foreach (Entry e in Entries)
            {
                Dictionary<string, object> definition = new Dictionary<string, object>();
                definition["type"] = e.Type;
                definition["description"] = "RoboLas " + e.Property + "; persisted in Robur settings; applies to the next operation.";
                if (e.Type != "boolean")
                {
                    definition[e.ExclusiveMinimum ? "exclusiveMinimum" : "minimum"] = e.Minimum;
                    definition["maximum"] = e.Maximum;
                }
                properties.Add(e.Key, definition);
            }
            return new Dictionary<string, object> { { "type", "object" }, { "properties", properties },
                { "additionalProperties", false }, { "minProperties", 1 } };
        }

        // Validate every field before touching any preference. A rejected patch
        // cannot leave a partially changed algorithm configuration.
        public static Dictionary<string, object> Apply(IDictionary<string, object> changes)
        {
            if (changes == null || changes.Count == 0)
                throw new ArgumentException("At least one plugin setting is required.");
            Dictionary<Entry, object> validated = new Dictionary<Entry, object>();
            foreach (KeyValuePair<string, object> pair in changes)
            {
                Entry entry = null;
                foreach (Entry candidate in Entries) if (candidate.Key == pair.Key) { entry=candidate; break; }
                if (entry == null) throw new ArgumentException("Unknown or read-only setting: " + pair.Key);
                object value = pair.Value;
                if (entry.Type == "boolean")
                {
                    if (!(value is bool)) throw new ArgumentException(pair.Key + " must be boolean.");
                }
                else
                {
                    if (!(value is byte || value is short || value is int || value is long ||
                        value is float || value is double || value is decimal))
                        throw new ArgumentException(pair.Key + " must be a number.");
                    double number = Convert.ToDouble(value);
                    if (Double.IsNaN(number) || Double.IsInfinity(number) || number < entry.Minimum ||
                        (entry.ExclusiveMinimum && number == entry.Minimum) || number > entry.Maximum)
                        throw new ArgumentException(pair.Key + " is outside its allowed range.");
                    if (entry.Type == "integer")
                    {
                        if (number != Math.Truncate(number)) throw new ArgumentException(pair.Key + " must be an integer.");
                        value = (int)number;
                    }
                    else value = number;
                }
                validated.Add(entry, value);
            }
            lock (RuntimeConfig.SyncRoot)
            {
                Dictionary<Entry, object> previous = new Dictionary<Entry, object>();
                foreach (Entry e in validated.Keys) previous.Add(e,e.Read());
                try { foreach (KeyValuePair<Entry, object> pair in validated) pair.Key.Write(pair.Value); }
                catch { foreach (KeyValuePair<Entry, object> pair in previous) pair.Key.Write(pair.Value); throw; }
                return Read();
            }
        }

        public static string[] RuntimeProperties()
        {
            List<string> properties = new List<string>();
            foreach (Entry e in Entries) if (!e.Adapter) properties.Add(e.Property);
            return properties.ToArray();
        }
    }
}
