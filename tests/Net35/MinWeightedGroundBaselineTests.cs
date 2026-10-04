using System;
using System.Collections.Generic;
using LAS_TERRAIN.Filters;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class MinWeightedGroundBaselineTests
    {
        private static int assertions;

        private static void Check(bool condition, string message)
        {
            assertions++;
            if (!condition) throw new Exception(message);
        }

        private static List<Vector2D> Points(params double[] xy)
        {
            List<Vector2D> result = new List<Vector2D>();
            for (int i = 0; i < xy.Length; i += 2)
                result.Add(new Vector2D(xy[i], xy[i + 1]));
            return result;
        }

        private static uint Next(ref uint state)
        {
            state = unchecked(state * 1664525u + 1013904223u);
            return state;
        }

        private static List<Vector2D> SeededProfile()
        {
            uint state = 123456789u;
            List<Vector2D> result = new List<Vector2D>();
            for (int i = 0; i < 48; i++)
            {
                double x = i * 0.1;
                double noise = ((int)(Next(ref state) % 201u) - 100) / 1000.0;
                double y = -2.0 + 0.03 * x + noise;
                if (i == 13 || i == 31) y += 1.25;
                result.Add(new Vector2D(x, y));
            }
            return result;
        }

        private static string Signature(List<Vector2D> points)
        {
            ulong hash = 14695981039346656037UL;
            for (int i = 0; i < points.Count; i++)
            {
                byte[] x = BitConverter.GetBytes(points[i].X);
                byte[] y = BitConverter.GetBytes(points[i].Y);
                for (int j = 0; j < 8; j++)
                    hash = unchecked((hash ^ x[j]) * 1099511628211UL);
                for (int j = 0; j < 8; j++)
                    hash = unchecked((hash ^ y[j]) * 1099511628211UL);
            }
            return hash.ToString("x16");
        }

        private static void CheckProfile(string label, List<Vector2D> input,
            int expectedCount, string expectedSignature, bool collapsedToOrigin)
        {
            List<Vector2D> output = MinWeightedGroundLevelMedianFilter.Apply(input);
            Check(output.Count == expectedCount, label + " count changed.");
            Check(Signature(output) == expectedSignature, label + " exact coordinates changed.");
            if (collapsedToOrigin)
                for (int i = 0; i < output.Count; i++)
                    Check(output[i].X == 0 && output[i].Y == 0,
                        label + " historical flat-profile behavior changed at " + i);
        }

        public static int Main()
        {
            List<Vector2D> empty = MinWeightedGroundLevelMedianFilter.Apply(new List<Vector2D>());
            Check(empty.Count == 0, "Empty input changed.");
            List<Vector2D> single = MinWeightedGroundLevelMedianFilter.Apply(Points(5, -2));
            Check(single.Count == 1 && single[0].X == 5 && single[0].Y == -2,
                "Single point changed.");
            CheckProfile("FLAT", Points(0, 0, 1, 0, 2, 0, 3, 0, 4, 0),
                5, "f14b84b8290b8965", true);
            CheckProfile("SPIKE", Points(0, 0, 0.1, 0, 0.2, 0, 0.3, 1,
                0.4, 0, 0.5, 0, 0.6, 0, 0.7, 0),
                8, "8421ae126c7ced25", true);
            CheckProfile("SEEDED", SeededProfile(), 48, "cffff8e86007b2bf", false);
            Console.WriteLine("MinWeighted baseline: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
