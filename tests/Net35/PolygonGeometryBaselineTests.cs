using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.UseCases;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    // Calls the built production use cases through reflection. No geometry
    // implementation is copied into this test assembly.
    internal static class PolygonGeometryBaselineTests
    {
        private static string _pluginDirectory;
        private static string _sdkDirectory;
        private static int _checks;

        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("Usage: PolygonGeometryBaselineTests <plugin-dll> <Rail-sdk-dir>");
                return 2;
            }
            _pluginDirectory = Path.GetDirectoryName(Path.GetFullPath(args[0]));
            _sdkDirectory = Path.GetFullPath(args[1]);
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
            try
            {
                Assembly.LoadFrom(Path.GetFullPath(args[0]));
                PointInPolygon();
                CrsProjection();
                PolygonBounds();
                FeatureCellMinimum();
                Console.WriteLine("PASS production polygon geometry baseline: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL production polygon geometry baseline: " + ex);
                return 1;
            }
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            string file = new AssemblyName(args.Name).Name + ".dll";
            string path = Path.Combine(_pluginDirectory, file);
            if (File.Exists(path)) return Assembly.LoadFrom(path);
            path = Path.Combine(_sdkDirectory, file);
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }

        private static MethodInfo Private(object instance, string name)
        {
            MethodInfo method = instance.GetType().GetMethod(name,
                BindingFlags.Instance | BindingFlags.NonPublic);
            if (method == null) throw new Exception("Production method missing: " + name);
            return method;
        }

        private static List<Vector2D> Square()
        {
            return new List<Vector2D> {
                new Vector2D(0, 0), new Vector2D(10, 0),
                new Vector2D(10, 10), new Vector2D(0, 10)
            };
        }

        private static bool PlanContains(object command, List<Vector2D> polygon, double x, double y)
        {
            return (bool)Private(command, "IsPointInsidePolygon").Invoke(command,
                new object[] { x, y, polygon });
        }

        private static bool CrsContains(object command, List<Vector2D> polygon, double x, double y)
        {
            return (bool)Private(command, "IsPointInPolygon").Invoke(command,
                new object[] { new Vector2D(x, y), polygon });
        }

        private static void PointInPolygon()
        {
            Check(String.Equals(Path.GetFullPath(typeof(PlanDeletePointsUseCase).Assembly.Location),
                Path.Combine(_pluginDirectory, "LAS_TERRAIN.dll"),
                StringComparison.OrdinalIgnoreCase), "a different plugin DLL was loaded");
            // Drawing stores polygons; only deletion and surface commands query membership.
            object[] commands = {
                new PlanDeletePointsUseCase(), new PlanPolygonGridSurfaceUseCase(),
                new PlanPolygonPolynomialSurfaceUseCase(),
                new CrsDeletePointsUseCase()
            };
            List<Vector2D> square = Square();
            List<Vector2D> closed = Square();
            closed.Add(new Vector2D(0, 0));
            List<Vector2D> collinear = new List<Vector2D> {
                new Vector2D(0, 0), new Vector2D(5, 0), new Vector2D(10, 0)
            };
            for (int i = 0; i < commands.Length; i++)
            {
                object command = commands[i];
                bool isPlan = i < 3;
                Check(Contains(command, isPlan, square, 5, 5), "square interior " + i);
                Check(Contains(command, isPlan, square, 0, 5), "square left edge " + i);
                Check(Contains(command, isPlan, square, 5, 0), "square bottom edge " + i);
                Check(!Contains(command, isPlan, square, 10, 5), "square right edge " + i);
                Check(!Contains(command, isPlan, square, 5, 10), "square top edge " + i);
                Check(Contains(command, isPlan, closed, 5, 5), "repeated closing vertex " + i);
                Check(!Contains(command, isPlan, collinear, 5, 0), "collinear polygon " + i);
                Check(!Contains(command, isPlan, null, 5, 5), "null polygon " + i);
                Check(!Contains(command, isPlan, collinear.GetRange(0, 2), 5, 0),
                    "two-point polygon " + i);
            }
        }

        private static bool Contains(object command, bool isPlan, List<Vector2D> polygon,
            double x, double y)
        {
            return isPlan ? PlanContains(command, polygon, x, y) :
                CrsContains(command, polygon, x, y);
        }

        private static bool CrsDeletes(object command, List<Vector2D> polygon,
            double wx, double wy, double wz, Vector2D leftMost,
            double normalX, double normalY, double dirX, double dirY)
        {
            return (bool)Private(command, "ShouldDeletePointInPolygon").Invoke(command,
                new object[] { wx, wy, wz, leftMost, normalX, normalY,
                    0.5, dirX, dirY, 1.0, polygon });
        }

        private static void CrsProjection()
        {
            object[] commands = { new CrsDeletePointsUseCase() };
            List<Vector2D> polygon = Square();
            for (int i = 0; i < commands.Length; i++)
            {
                object command = commands[i];
                Vector2D origin = new Vector2D(0, 0);
                Check(CrsDeletes(command, polygon, 6, 0.5, 5, origin, 0, 1, 1, 0),
                    "inclusive positive strip border " + i);
                Check(CrsDeletes(command, polygon, 6, -0.5, 5, origin, 0, 1, 1, 0),
                    "inclusive negative strip border " + i);
                Check(!CrsDeletes(command, polygon, 6, 0.500001, 5, origin, 0, 1, 1, 0),
                    "outside strip " + i);
                Check(CrsDeletes(command, polygon, 1, 0, 5, origin, 0, 1, 1, 0),
                    "projected left polygon edge " + i);
                Check(!CrsDeletes(command, polygon, 11, 0, 5, origin, 0, 1, 1, 0),
                    "projected right polygon edge " + i);
                Check(CrsDeletes(command, polygon, 99.5, 206, 5,
                    new Vector2D(100, 200), -1, 0, 0, 1),
                    "rotated section projection " + i);
            }
        }

        private static List<PlanPolygonEntry> Entries(List<Vector2D> points)
        {
            PlanPolygonEntry entry = new PlanPolygonEntry();
            entry.Polygon = points;
            return new List<PlanPolygonEntry> { entry };
        }

        private static void PolygonBounds()
        {
            object[] commands = {
                new PlanPolygonGridSurfaceUseCase(), new PlanPolygonPolynomialSurfaceUseCase()
            };
            for (int i = 0; i < commands.Length; i++)
            {
                MethodInfo method = Private(commands[i], "TryComputePolygonBounds");
                object[] empty = { new List<PlanPolygonEntry>(), null };
                Check(!(bool)method.Invoke(commands[i], empty), "empty bounds " + i);

                object[] twoPoint = { Entries(new List<Vector2D> {
                    new Vector2D(2, 3), new Vector2D(4, 7) }), null };
                Check((bool)method.Invoke(commands[i], twoPoint), "two-point bounds missing " + i);
                BoundingBox2D box = (BoundingBox2D)twoPoint[1];
                Check(box.Min.X == 1 && box.Min.Y == 2 &&
                    box.Max.X == 5 && box.Max.Y == 8,
                    "two-point bounds or one-unit margin changed " + i);
            }
        }

        private static void FeatureCellMinimum()
        {
            Type detector = typeof(PlanPolygonGridSurfaceUseCase).Assembly.GetType(
                "LAS_TERRAIN.Domain.Service.GridFeatureDetector", false);
            if (detector == null) throw new Exception("Production GridFeatureDetector missing");
            Type modeType = detector.GetNestedType("Mode", BindingFlags.Public | BindingFlags.NonPublic);
            MethodInfo method = detector.GetMethod("DetectFeatures", BindingFlags.Public | BindingFlags.Static);
            if (modeType == null || method == null)
                throw new Exception("Production feature detector method missing");

            List<Vector3D> points = new List<Vector3D> {
                new Vector3D(0.1, 0.1, 5),
                new Vector3D(0.2, 0.2, 2),
                new Vector3D(0.3, 0.3, 2)
            };
            object mode = Enum.Parse(modeType, "Both");
            object[] parameters = { points,
                new BoundingBox2D(new Vector2D(0, 0), new Vector2D(1, 1)),
                1.0, 0.3, 0.9, 0.0, 0.0, mode };
            List<Vector3D> result = (List<Vector3D>)method.Invoke(null, parameters);
            Check(result.Count == 1, "duplicate cell did not collapse");
            Check(result[0].X == 0.2 && result[0].Y == 0.2 && result[0].Z == 2,
                "minimum Z or first equal-Z point changed");
        }
    }
}
