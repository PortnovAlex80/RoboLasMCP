using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;
using LAS_TERRAIN.Domain.Service;

namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }
    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
    }
    public struct BoundingBox2D
    {
        public Vector2D Min, Max;
        public BoundingBox2D(Vector2D min, Vector2D max) { Min = min; Max = max; }
    }
}

namespace LAS_TERRAIN.Tests
{
    using Topomatic.Cad.Foundation;

    internal static class PolynomialSurfaceFitterTests
    {
        private static int _checks;
        private static volatile bool _sampling;
        private static long _peakBytes;

        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        private static double Formula(double x, double y, int degree)
        {
            double z = 2 + 3 * x - 4 * y;
            if (degree >= 2) z += 0.5 * x * x + 0.75 * x * y - 0.25 * y * y;
            if (degree >= 3) z += 0.1 * x * x * x - 0.2 * x * x * y +
                0.3 * x * y * y - 0.05 * y * y * y;
            return z;
        }

        private static List<Vector3D> Input(int degree)
        {
            var points = new List<Vector3D>();
            for (int y = -2; y <= 2; y++)
                for (int x = -2; x <= 2; x++)
                    points.Add(new Vector3D(x, y, Formula(x, y, degree)));
            return points;
        }

        private static void ExactPolynomial(int degree)
        {
            List<Vector3D> points = Input(degree);
            var bounds = new BoundingBox2D(new Vector2D(-2, -2), new Vector2D(2, 2));
            List<Vector3D> result = PolynomialSurfaceFitter.FitSurface(
                points, degree, 1e-9, 1.0, bounds);
            Check(result.Count == 25, "degree " + degree + " output count");
            for (int ix = 0; ix < 5; ix++)
                for (int iy = 0; iy < 5; iy++)
                {
                    Vector3D actual = result[ix * 5 + iy];
                    double x = ix - 2, y = iy - 2;
                    Check(actual.X == x && actual.Y == y,
                        "degree " + degree + " x-major output order");
                    Check(Math.Abs(actual.Z - Formula(x, y, degree)) < 1e-5,
                        "degree " + degree + " fitted height");
                }
            Check(points[0].X == -2 && points[0].Z == Formula(-2, -2, degree),
                "input left unchanged");
        }

        private static void BoundedGrid()
        {
            var bounds = new BoundingBox2D(new Vector2D(0, 0), new Vector2D(1, 1));
            var points = new List<Vector3D> {
                new Vector3D(0, 0, 1), new Vector3D(1, 0, 2),
                new Vector3D(0, 1, 3), new Vector3D(1, 1, 4) };
            List<Vector3D> result = PolynomialSurfaceFitter.FitSurface(
                points, 1, 1e-9, 0.6, bounds);
            Check(result.Count == 9, "non-divisible step grid count");
            Check(result[0].X == 0 && result[0].Y == 0, "first grid coordinate");
            Check(result[8].X == 1 && result[8].Y == 1, "last grid coordinate clamped");
        }

        private static void MixedInputBaseline()
        {
            var points = new List<Vector3D>();
            for (int i = 0; i < 199; i++)
            {
                double x = -3.0 + (i % 17) * 0.37;
                double y = -2.0 + ((i * 7) % 19) * 0.29;
                double z = Math.Sin(x * 0.7) + Math.Cos(y * 1.1) +
                    0.2 * x * y + (i % 5) * 0.03;
                points.Add(new Vector3D(x, y, z));
            }
            var bounds = new BoundingBox2D(new Vector2D(-1.7, -0.8),
                new Vector2D(2.3, 1.6));
            string[] expected = {
                "",
                "0E2D74E54FEFB2D9E9845357992F08459FCB329BFE5AC47E6A3CEB35A31F0192",
                "BFB6581E197A63802D3D6C880272B7A93FFEC7F5E198573B5FC0B1831F1E3A3D",
                "45952B65EDF552C5F7BD74CC5A7CAA1BFBBE37C0373BAF649FAAD177FCD2D6E0"
            };
            for (int degree = 1; degree <= 3; degree++)
            {
                List<Vector3D> result = PolynomialSurfaceFitter.FitSurface(
                    points, degree, 0.001, 0.65, bounds);
                byte[] bytes = new byte[result.Count * 24];
                for (int i = 0; i < result.Count; i++)
                {
                    Array.Copy(BitConverter.GetBytes(result[i].X), 0, bytes, i * 24, 8);
                    Array.Copy(BitConverter.GetBytes(result[i].Y), 0, bytes, i * 24 + 8, 8);
                    Array.Copy(BitConverter.GetBytes(result[i].Z), 0, bytes, i * 24 + 16, 8);
                }
                using (SHA256 sha = SHA256.Create())
                    Check(BitConverter.ToString(sha.ComputeHash(bytes)).Replace("-", "") ==
                        expected[degree], "degree " + degree + " production bit baseline");
            }
        }

        private static void HighCoordinateBaseline()
        {
            var points = new List<Vector3D>();
            for (int i = 0; i < 199; i++)
            {
                double x = 500000.0 + (i % 17) * 0.37;
                double y = 600000.0 + ((i * 7) % 19) * 0.29;
                double z = 100.0 + Math.Sin((x - 500000.0) * 0.7) +
                    Math.Cos((y - 600000.0) * 1.1) + (i % 5) * 0.03;
                points.Add(new Vector3D(x, y, z));
            }
            var bounds = new BoundingBox2D(new Vector2D(500000.0, 600000.0),
                new Vector2D(500003.0, 600003.0));
            string[] expected = {
                "",
                "8D6820D75E62AE30B5B6AD9EEB80F748C577E2FB5FDFE005BCFA3253B8695715",
                "3881C619C85D768C9337CDFD22DFDA9EFFD9065942DA37155CDBFA6C9472F9B4",
                "6060BEA00BA5B2726AE658199C527DB946663AE9BE63D0608E1075EDB1FD3F50"
            };
            for (int degree = 1; degree <= 3; degree++)
            {
                List<Vector3D> result = PolynomialSurfaceFitter.FitSurface(
                    points, degree, 0.001, 0.75, bounds);
                Check(result.Count == 25, "high-coordinate grid count");
                byte[] bytes = new byte[result.Count * 24];
                for (int i = 0; i < result.Count; i++)
                {
                    Array.Copy(BitConverter.GetBytes(result[i].X), 0, bytes, i * 24, 8);
                    Array.Copy(BitConverter.GetBytes(result[i].Y), 0, bytes, i * 24 + 8, 8);
                    Array.Copy(BitConverter.GetBytes(result[i].Z), 0, bytes, i * 24 + 16, 8);
                }
                using (SHA256 sha = SHA256.Create())
                    Check(BitConverter.ToString(sha.ComputeHash(bytes)).Replace("-", "") ==
                        expected[degree], "degree " + degree + " high-coordinate bit baseline");
            }
        }

        private static void InvalidInputs()
        {
            var bounds = new BoundingBox2D(new Vector2D(0, 0), new Vector2D(1, 1));
            var points = Input(1);
            Check(PolynomialSurfaceFitter.FitSurface(null, 1, 0, 1, bounds).Count == 0,
                "null input is empty");
            ExpectArgument(() => PolynomialSurfaceFitter.FitSurface(points, 0, 0, 1, bounds),
                "degree zero rejected");
            ExpectArgument(() => PolynomialSurfaceFitter.FitSurface(points, 4, 0, 1, bounds),
                "degree four rejected");
            ExpectArgument(() => PolynomialSurfaceFitter.FitSurface(points, 1, -1, 1, bounds),
                "negative regularization rejected");
            ExpectArgument(() => PolynomialSurfaceFitter.FitSurface(points, 1, 0, 0, bounds),
                "zero grid step rejected");
            ExpectArgument(() => PolynomialSurfaceFitter.FitSurface(
                new List<Vector3D> { points[0], points[1] }, 1, 0, 1, bounds),
                "insufficient points rejected");
        }

        private static void ExpectArgument(Action action, string name)
        {
            bool rejected = false;
            try { action(); }
            catch (ArgumentException) { rejected = true; }
            Check(rejected, name);
        }

        private static void MemoryProbe()
        {
            var points = new List<Vector3D>(250000);
            for (int i = 0; i < 250000; i++)
            {
                double x = -3.0 + (i % 17) * 0.37;
                double y = -2.0 + ((i * 7) % 19) * 0.29;
                points.Add(new Vector3D(x, y, Math.Sin(x) + Math.Cos(y)));
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Process process = Process.GetCurrentProcess();
            process.Refresh();
            long before = process.PrivateMemorySize64;
            _peakBytes = before;
            _sampling = true;
            Thread sampler = new Thread(() =>
            {
                while (_sampling)
                {
                    process.Refresh();
                    long current = process.PrivateMemorySize64;
                    if (current > _peakBytes) _peakBytes = current;
                    Thread.Sleep(1);
                }
            });
            sampler.IsBackground = true;
            sampler.Start();
            Stopwatch watch = Stopwatch.StartNew();
            try
            {
                List<Vector3D> result = PolynomialSurfaceFitter.FitSurface(
                    points, 3, 0.001, 0.5,
                    new BoundingBox2D(new Vector2D(-1, -1), new Vector2D(1, 1)));
                Check(result.Count == 25, "memory probe output count");
            }
            finally
            {
                watch.Stop();
                _sampling = false;
                sampler.Join();
            }
            Console.WriteLine("FITTER_MEMORY points=250000 degree=3 peak_delta_bytes=" +
                (_peakBytes - before) + " elapsed_ms=" + watch.ElapsedMilliseconds);
        }

        public static int Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "--memory-probe")
            {
                MemoryProbe();
                return 0;
            }
            ExactPolynomial(1);
            ExactPolynomial(2);
            ExactPolynomial(3);
            BoundedGrid();
            MixedInputBaseline();
            HighCoordinateBaseline();
            InvalidInputs();
            Console.WriteLine("Production polynomial fitter: " + _checks + " checks passed.");
            return 0;
        }
    }
}
