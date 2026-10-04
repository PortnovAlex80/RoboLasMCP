using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;

namespace Topomatic.Cad.Foundation
{
    public struct Vector4D
    {
        public double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }
}

namespace LAS_TERRAIN.Tests
{
    using Topomatic.Cad.Foundation;

    internal static class SpilledPointListTests
    {
        private static int checks;
        private static void Check(bool condition, string message)
        {
            checks++;
            if (!condition) throw new Exception(message);
        }

        private static void Same(Vector4D left, Vector4D right, string message)
        {
            Check(left.X == right.X && left.Y == right.Y &&
                left.Z == right.Z && left.W == right.W, message);
        }

        public static int Main()
        {
            string folder = Path.Combine(Path.GetTempPath(),
                "robolas-point-spool-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(folder);
            string outputPath = Path.Combine(folder, "result.las");
            List<Vector4D> points = new List<Vector4D>();
            for (int i = 0; i < 10001; i++)
                points.Add(new Vector4D(i - 5000, -i * 0.25,
                    2000000.0 + i * 0.0001, i % 256));

            try
            {
                SpilledPointList streamed;
                using (SpilledPointWriter writer = new SpilledPointWriter(outputPath))
                {
                    for (int i = 0; i < points.Count; i++) writer.Append(points[i]);
                    streamed = writer.Complete();
                }
                Check(Directory.GetFiles(folder, "*.points.tmp").Length == 1,
                    "completed writer lost spool ownership before reader disposal");
                using (streamed)
                {
                    Check(streamed.Count == points.Count,
                        "streamed point count changed");
                    Same(streamed[0], points[0], "first streamed point changed");
                    Same(streamed[5000], points[5000], "middle streamed point changed");
                    Same(streamed[10000], points[10000], "last streamed point changed");
                    List<Vector4D> expected = SamplingHelper.ReservoirSampleWithProgress(
                        points, 5001, null, new Random(41));
                    List<Vector4D> actual = SamplingHelper.ReservoirSampleWithProgress(
                        streamed, 5001, null, new Random(41));
                    Check(actual.Count == expected.Count, "streamed sample count changed");
                    for (int i = 0; i < actual.Count; i++)
                        Same(actual[i], expected[i], "streamed sample slot " + i);
                    List<Vector4D> all = SamplingHelper.ReduceByPercentWithProgress(
                        streamed, 100.0, null);
                    Check(all.Count == points.Count, "100 percent sample count changed");
                    Same(all[0], points[0], "100 percent first point changed");
                    Same(all[all.Count - 1], points[points.Count - 1],
                        "100 percent last point changed");
                }
                Check(Directory.GetFiles(folder, "*.points.tmp").Length == 0,
                    "streamed spool remained after reader disposal");
                using (SpilledPointWriter partial = new SpilledPointWriter(outputPath))
                {
                    partial.Append(points[0]);
                }
                Check(Directory.GetFiles(folder, "*.points.tmp").Length == 0,
                    "abandoned streamed spool left a partial file");
                using (SpilledPointWriter empty = new SpilledPointWriter(outputPath))
                using (SpilledPointList emptyList = empty.Complete())
                    Check(emptyList.Count == 0, "empty streamed spool failed");
                Check(!File.Exists(outputPath), "spooling published a LAS file");
            }
            finally
            {
                foreach (string file in Directory.GetFiles(folder)) File.Delete(file);
                Directory.Delete(folder);
            }
            Console.WriteLine("Spilled point list: " + checks + " checks passed.");
            return 0;
        }
    }
}
