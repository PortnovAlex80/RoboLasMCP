using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace LAS_TERRAIN.Tests
{
    // Checks each captured field against an independent, distinct source sentinel.
    internal static class FilterSettingsSnapshotAdapterTests
    {
        private const BindingFlags StaticFlags = BindingFlags.Static |
            BindingFlags.Public | BindingFlags.NonPublic;
        private const BindingFlags InstanceFlags = BindingFlags.Instance |
            BindingFlags.Public | BindingFlags.NonPublic;
        private static Assembly _plugin;
        private static string _pluginDirectory;
        private static string _sdkDirectory;
        private static int _checks;

        private sealed class Setting
        {
            internal readonly string TypeName;
            internal readonly string MemberName;
            internal readonly string SnapshotField;
            internal readonly object Sentinel;
            internal readonly bool IsProperty;
            internal object Original;

            internal Setting(string typeName, string memberName, string snapshotField,
                object sentinel, bool isProperty)
            {
                TypeName = typeName;
                MemberName = memberName;
                SnapshotField = snapshotField;
                Sentinel = sentinel;
                IsProperty = isProperty;
            }

            internal object Read()
            {
                Type type = RequireType(TypeName);
                if (IsProperty)
                    return RequireProperty(type, MemberName).GetValue(null, null);
                return RequireField(type, MemberName, StaticFlags).GetValue(null);
            }

            internal void Write(object value)
            {
                Type type = RequireType(TypeName);
                if (IsProperty)
                    RequireProperty(type, MemberName).SetValue(null, value, null);
                else
                    RequireField(type, MemberName, StaticFlags).SetValue(null, value);
            }
        }

        private static Setting[] Settings()
        {
            const string runtime = "LAS_TERRAIN.Configuration.RuntimeConfig";
            return new Setting[] {
                new Setting(runtime, "UseSplineFilter", "UseSplineFilter", false, true),
                new Setting(runtime, "EnableBreakDetection", "EnableBreakDetection", false, true),
                new Setting(runtime, "SplitMergeTolerance", "SplitMergeTolerance", 0.193, true),
                new Setting(runtime, "GraphBinX", "GraphBinX", 1.13, true),
                new Setting(runtime, "GraphBinY", "GraphBinY", 2.17, true),
                new Setting(runtime, "GraphMinPts", "GraphMinPts", 3, true),
                new Setting(runtime, "BreakSlopeWindow", "BreakSlopeWindow", 7, true),
                new Setting(runtime, "BreakR2Window", "BreakR2Window", 9, true),
                new Setting(runtime, "BreakAngleThreshold", "BreakAngleThreshold", 0.271, true),
                new Setting(runtime, "BreakMinR2", "BreakMinR2", 0.713, true),
                new Setting(runtime, "BreakMinSegmentPoints", "BreakMinSegmentPoints", 11, true),
                new Setting(runtime, "BreakSuppressRadius", "BreakSuppressRadius", 13, true),
                new Setting(runtime, "SplineDegree", "SplineDegree", 4, true),
                new Setting(runtime, "SplineMaxIterations", "SplineMaxIterations", 14, true),
                new Setting(runtime, "SplineSigma", "SplineSigma", 0.347, true),
                new Setting(runtime, "CSplineSmooth", "SplineSmooth", 0.061, true),
                new Setting(runtime, "SplineGridStep", "SplineGridStep", 0.079, true),
                new Setting(runtime, "SplineConvergenceTol", "SplineConvergenceTol", 0.00013, true),
                new Setting(runtime, "SplineAutoCtrlMax", "SplineAutoCtrlMax", 211, true),
                new Setting(runtime, "SplineRidgeEps", "SplineRidgeEps", 2e-8, true),
                new Setting(runtime, "SplineMaxGapMeters", "SplineMaxGapMeters", 1.89, true),
                new Setting(runtime, "SplineEnableRailFilter", "SplineEnableRailFilter", true, true),
                new Setting(runtime, "SplineRailFilterWindowMeters", "SplineRailFilterWindowMeters", 0.57, true)
            };
        }

        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("Usage: FilterSettingsSnapshotAdapterTests <plugin-dll> <Rail-sdk-dir>");
                return 2;
            }

            _pluginDirectory = Path.GetDirectoryName(Path.GetFullPath(args[0]));
            _sdkDirectory = Path.GetFullPath(args[1]);
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
            Setting[] settings = Settings();
            List<Setting> changed = new List<Setting>();
            try
            {
                _plugin = Assembly.LoadFrom(Path.GetFullPath(args[0]));
                Type snapshotType = RequireType("LAS_TERRAIN.Models.FilterOperationSnapshot");
                Check(snapshotType.GetFields(InstanceFlags).Length == settings.Length,
                    "snapshot field count changed");

                foreach (Setting setting in settings)
                {
                    setting.Original = setting.Read();
                    changed.Add(setting);
                    setting.Write(setting.Sentinel);
                }

                object adapter = Capture();
                CheckFields(settings, adapter);

                CheckAtomicStoredPreferences();

                Console.WriteLine("PASS filter settings snapshot adapter: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL filter settings snapshot adapter: " + ex);
                return 1;
            }
            finally
            {
                for (int i = changed.Count - 1; i >= 0; i--)
                    changed[i].Write(changed[i].Original);
            }
        }

        private static void CheckAtomicStoredPreferences()
        {
            Type runtime = RequireType("LAS_TERRAIN.Configuration.RuntimeConfig");
            MethodInfo apply = runtime.GetMethod("ApplyStoredPreferences", StaticFlags);
            Check(apply != null, "bulk preferences method missing");
            object originalBorder = RequireProperty(runtime, "CrsOverlayBorder").GetValue(null, null);
            object originalGrid = RequireProperty(runtime, "GridStep").GetValue(null, null);
            object[] a = { 0.21, 0.031, 1.1, 0.3, true };
            object[] b = { 0.41, 0.071, 2.2, 0.6, false };
            Exception writerError = null;
            Thread writer = null;
            try
            {
                apply.Invoke(null, a);
                writer = new Thread(delegate()
                {
                    try
                    {
                        for (int i = 0; i < 1000; i++)
                            apply.Invoke(null, (i & 1) == 0 ? b : a);
                    }
                    catch (Exception ex) { writerError = ex; }
                });
                writer.Start();
                for (int i = 0; i < 1000; i++)
                {
                    object snapshot = Capture();
                    double tolerance = (double)ReadSnapshotField(snapshot, "SplitMergeTolerance");
                    double smooth = (double)ReadSnapshotField(snapshot, "SplineSmooth");
                    bool spline = (bool)ReadSnapshotField(snapshot, "UseSplineFilter");
                    Check((tolerance == 0.21 && smooth == 0.031 && spline) ||
                          (tolerance == 0.41 && smooth == 0.071 && !spline),
                        "capture mixed two stored preference generations");
                }
                writer.Join();
                Check(writerError == null, "bulk preference writer failed: " + writerError);
            }
            finally
            {
                if (writer != null && writer.IsAlive) writer.Join();
                RequireProperty(runtime, "CrsOverlayBorder").SetValue(null, originalBorder, null);
                RequireProperty(runtime, "GridStep").SetValue(null, originalGrid, null);
            }
        }

        private static void CheckFields(Setting[] settings, object adapter)
        {
            foreach (Setting setting in settings)
            {
                object actual = ReadSnapshotField(adapter, setting.SnapshotField);
                Check(Object.Equals(actual, setting.Sentinel), "adapter " + setting.SnapshotField);
            }
        }

        private static object ReadSnapshotField(object snapshot, string name)
        {
            return RequireField(snapshot.GetType(), name, InstanceFlags).GetValue(snapshot);
        }

        private static object Capture()
        {
            const string typeName = "LAS_TERRAIN.Infrastructure.FilterSettingsSnapshotAdapter";
            MethodInfo method = RequireType(typeName).GetMethod("Capture", StaticFlags);
            if (method == null) throw new Exception("Missing capture: " + typeName + ".Capture");
            return method.Invoke(null, null);
        }

        private static Type RequireType(string name)
        {
            Type type = _plugin.GetType(name, false);
            if (type == null) throw new Exception("Missing type: " + name);
            return type;
        }

        private static FieldInfo RequireField(Type type, string name, BindingFlags flags)
        {
            FieldInfo field = type.GetField(name, flags);
            if (field == null) throw new Exception("Missing field: " + type.FullName + "." + name);
            return field;
        }

        private static PropertyInfo RequireProperty(Type type, string name)
        {
            PropertyInfo property = type.GetProperty(name, StaticFlags);
            if (property == null) throw new Exception("Missing property: " + type.FullName + "." + name);
            return property;
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            string file = new AssemblyName(args.Name).Name + ".dll";
            string path = Path.Combine(_pluginDirectory, file);
            if (File.Exists(path)) return Assembly.LoadFrom(path);
            path = Path.Combine(_sdkDirectory, file);
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        }

        private static void Check(bool condition, string message)
        {
            if (!condition) throw new Exception(message);
            _checks++;
        }
    }
}
