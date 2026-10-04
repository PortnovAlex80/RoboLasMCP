using System;
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.ApplicationPlatform;
using Topomatic.Stg;
using LAS_TERRAIN.Configuration;

namespace LAS_TERRAIN
{
    /// <summary>
    /// Default values for LAS_TERRAIN settings.
    /// Single source of truth for field initializers and fallback values.
    /// </summary>
    internal static class SettingsDefaults
    {
        public const double SplitMergeTolerance = 0.07;
        public const double CsplineSmooth = 0.0;
        public const double CrsOverlayBorder = 1.0;
        public const double GridStep = 1.0;
        public const bool UseSplineFilter = true;  // true = Spline, false = MinWeighted
    }

    class Settings : IStgSerializable
    {
        public double SplitMergeTolerance = SettingsDefaults.SplitMergeTolerance;
        // сглаживание для кубического B-сплайна
        public double CsplineSmooth = SettingsDefaults.CsplineSmooth;
        public double CrsOverlayBorder = SettingsDefaults.CrsOverlayBorder;

        // шаг сетки для построения поверхностей по полигонам
        public double GridStep = SettingsDefaults.GridStep;

        // выбор алгоритма фильтрации земли
        public bool UseSplineFilter = SettingsDefaults.UseSplineFilter;

        void IStgSerializable.LoadFromStg(StgNode node)
        {
            try
            {
                try
                {
                    var tol = node.GetDouble("splitMergeTolerance");
                    if (tol > 0 && !double.IsInfinity(tol) && !double.IsNaN(tol))
                        this.SplitMergeTolerance = tol;
                }
                catch
                {
                    this.SplitMergeTolerance = SettingsDefaults.SplitMergeTolerance;
                }

                try
                {
                    var csplineSmooth = node.GetDouble("csplineSmooth");
                    if (csplineSmooth > 0 && !double.IsInfinity(csplineSmooth) && !double.IsNaN(csplineSmooth))
                        this.CsplineSmooth = csplineSmooth;
                }
                catch
                {
                    this.CsplineSmooth = SettingsDefaults.CsplineSmooth;
                }
                try
                {
                    var b = node.GetDouble("crsOverlayBorder");
                    if (b > 0 && !double.IsInfinity(b) && !double.IsNaN(b))
                        this.CrsOverlayBorder = b;
                }
                catch { this.CrsOverlayBorder = SettingsDefaults.CrsOverlayBorder; }
                try
                {
                    var gs = node.GetDouble("gridStep");
                    if (gs > 0 && !double.IsInfinity(gs) && !double.IsNaN(gs))
                        this.GridStep = gs;
                }
                catch { this.GridStep = SettingsDefaults.GridStep; }
                try
                {
                    this.UseSplineFilter = node.GetBoolean("useSplineFilter", SettingsDefaults.UseSplineFilter);
                }
                catch { this.UseSplineFilter = SettingsDefaults.UseSplineFilter; }
            }
            catch
            {
                // Keep field initializers/default fallbacks already assigned above.
            }

            PushToRuntimeConfig();
            // New keys cover every plugin preference; old five keys still load
            // packages/projects written before the MCP settings catalog.
            Dictionary<string, object> properties = (Dictionary<string, object>)PluginSettings.Describe()["properties"];
            foreach (KeyValuePair<string, object> entry in properties)
            {
                try
                {
                    string type = (string)((Dictionary<string, object>)entry.Value)["type"];
                    object value = type == "boolean"
                        ? (object)node.GetBoolean("robolas_" + entry.Key, (bool)PluginSettings.Read()[entry.Key])
                        : (object)node.GetDouble("robolas_" + entry.Key);
                    PluginSettings.Apply(new Dictionary<string, object> { { entry.Key, value } });
                }
                catch (Exception) { /* Missing/obsolete values keep validated legacy/default preferences. */ }
            }
            CaptureRuntimePreferences();
        }

        /// <summary>
        /// Synchronizes current settings values to RuntimeConfig.
        /// Call this after loading from storage or when settings change.
        /// </summary>
        public void PushToRuntimeConfig()
        {
            RuntimeConfig.ApplyStoredPreferences(this.SplitMergeTolerance,
                this.CsplineSmooth, this.CrsOverlayBorder, this.GridStep,
                this.UseSplineFilter);
        }

        public void CaptureRuntimePreferences()
        {
            SplitMergeTolerance = RuntimeConfig.SplitMergeTolerance;
            CsplineSmooth = RuntimeConfig.CSplineSmooth;
            CrsOverlayBorder = RuntimeConfig.CrsOverlayBorder;
            GridStep = RuntimeConfig.GridStep;
            UseSplineFilter = RuntimeConfig.UseSplineFilter;
        }

        void IStgSerializable.SaveToStg(StgNode node)
        {
            CaptureRuntimePreferences();
            foreach (KeyValuePair<string, object> entry in PluginSettings.Read())
            {
                if (entry.Value is bool) node.AddBoolean("robolas_" + entry.Key, (bool)entry.Value);
                else node.AddDouble("robolas_" + entry.Key, Convert.ToDouble(entry.Value));
            }
            node.AddDouble("splitMergeTolerance", SplitMergeTolerance);
            node.AddDouble("csplineSmooth", CsplineSmooth);
            node.AddDouble("crsOverlayBorder", CrsOverlayBorder);
            node.AddDouble("gridStep", GridStep);
            node.AddBoolean("useSplineFilter", UseSplineFilter);
        }

        public static readonly Settings Instance = Settings._getSettings();

        private static Settings _getSettings()
        {
            object settings;
            ApplicationHost.Current.Settings.TryGetValue("las_plugin_settings", out settings);
            if (settings == null)
            {
                ApplicationHost.Current.Settings["las_plugin_settings"] = new Settings();
                settings = ApplicationHost.Current.Settings["las_plugin_settings"] as Settings;
            }
            return settings as Settings;
        }
    }
}
