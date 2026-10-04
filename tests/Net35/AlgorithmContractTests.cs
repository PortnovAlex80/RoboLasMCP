// Small, hand-checkable contracts for production algorithms. Compile with the
// .NET 3.5 csc and the production source files listed in docs/algorithm-test-matrix.md.
// This is a separate entry point; it does not change the existing test runner.
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class AlgorithmContractTests
    {
        private static int passed;
        private static FilterOperationSnapshot GraphSnapshot(int minPts)
        {
            return new FilterOperationSnapshot(
                true, true, 0.01,
                1.0, 1.0, minPts,
                5, 8, 0.175, 0.80, 6, 5,
                3, 8, 0.25, 0.0, 0.05, 1e-4,
                256, 1e-9, 1.0, false, 0.3);
        }


        private static void Check(bool condition, string message)
        {
            if (!condition) throw new Exception(message);
        }

        private static void Test(string name, Action body)
        {
            body();
            passed++;
            Console.WriteLine("PASS " + name);
        }

        private static List<Vector2D> Points(params double[] xy)
        {
            List<Vector2D> result = new List<Vector2D>();
            for (int i = 0; i < xy.Length; i += 2)
                result.Add(new Vector2D(xy[i], xy[i + 1]));
            return result;
        }

        private static void SamePoints(IList<Vector2D> actual, IList<Vector2D> expected)
        {
            Check(actual.Count == expected.Count, "point count: expected " + expected.Count + ", got " + actual.Count);
            for (int i = 0; i < actual.Count; i++)
                Check(actual[i].X == expected[i].X && actual[i].Y == expected[i].Y,
                    "point " + i + ": expected (" + expected[i].X + "," + expected[i].Y +
                    "), got (" + actual[i].X + "," + actual[i].Y + ")");
        }

        private static void Rejects<T>(Action action) where T : Exception
        {
            try { action(); }
            catch (T) { return; }
            throw new Exception("Expected " + typeof(T).Name);
        }

        public static int Main()
        {
            try
            {
                Test("millimetre cells straddle zero and retain full coordinate width", delegate
                {
                    HashSet<PointKey2D> cells = new HashSet<PointKey2D>();
                    cells.Add(PointKey2D.Millimetre(-0.0001, 0));
                    cells.Add(PointKey2D.Millimetre(-0.0009, 0));
                    cells.Add(PointKey2D.Millimetre(0, 0));
                    cells.Add(PointKey2D.Millimetre(4294967.296, 0));
                    Check(cells.Count == 3, "negative, zero or wide-coordinate cells merged");
                    Check(!PointKey2D.Millimetre(-0.0011, 0).Equals(PointKey2D.Millimetre(-0.001, 0)),
                        "negative cell boundary lost");
                });
                Test("exact XYZ keys preserve height and reject non-finite coordinates", delegate
                {
                    HashSet<PointKey3D> keys = new HashSet<PointKey3D>();
                    keys.Add(PointKey3D.Exact(2, -1, 4));
                    keys.Add(PointKey3D.Exact(2, -1, 4.000000001));
                    keys.Add(PointKey3D.Exact(2, -1, 4));
                    Check(keys.Count == 2, "height or exact duplicate policy changed");
                    Rejects<ArgumentException>(delegate { PointKey3D.Exact(0, double.PositiveInfinity, 0); });
                    Rejects<ArgumentException>(delegate { PointKey2D.Millimetre(double.NaN, 0); });
                });
                Test("sort is in-place and orders negative and duplicate X", delegate
                {
                    List<Vector2D> input = Points(2, 20, -1, 10, 0, 0, 2, 21);
                    List<Vector2D> sorted = OrderByX.Apply(input);
                    Check(Object.ReferenceEquals(input, sorted), "sort allocated a replacement list");
                    Check(sorted[0].X == -1 && sorted[1].X == 0 && sorted[2].X == 2 && sorted[3].X == 2,
                        "X ordering changed");
                    Check((sorted[2].Y == 20 && sorted[3].Y == 21) ||
                          (sorted[2].Y == 21 && sorted[3].Y == 20), "duplicate X points were lost");
                });
                Test("simplifier includes exact tolerance boundary", delegate
                {
                    List<Vector2D> input = Points(0, 0, 1, 0.25, 2, 0);
                    SamePoints(SplitAndMergeAlgorithm.Apply(input, 0.25), Points(0, 0, 2, 0));
                    SamePoints(SplitAndMergeAlgorithm.Apply(input, 0.249), input);
                    SamePoints(input, Points(0, 0, 1, 0.25, 2, 0));
                });
                Test("simplifier retains backtracking and excursion order", delegate
                {
                    List<Vector2D> backtrack = Points(0, 0, 2, 0, 1, 0);
                    SamePoints(SplitAndMergeAlgorithm.Apply(backtrack, 0.01), backtrack);
                    List<Vector2D> closed = Points(0, 0, 1, 1, 0, 0);
                    SamePoints(SplitAndMergeAlgorithm.Apply(closed, 0.01), closed);
                    SamePoints(SplitAndMergeAlgorithm.Apply(Points(1, 1, 1, 1, 1, 1), 0), Points(1, 1));
                });
                Test("simplifier rejects invalid tolerance and coordinates", delegate
                {
                    Rejects<ArgumentOutOfRangeException>(delegate { SplitAndMergeAlgorithm.Apply(Points(0, 0), -0.01); });
                    Rejects<ArgumentOutOfRangeException>(delegate { SplitAndMergeAlgorithm.Apply(null, double.NaN); });
                    Rejects<ArgumentException>(delegate { SplitAndMergeAlgorithm.Apply(Points(0, 0, double.NegativeInfinity, 1), 0.1); });
                });
                Test("ground occupancy threshold retains duplicate points in source order", delegate
                {
                    List<Vector2D> input = Points(0.2, 3, 0, 0, 1.2, 0, 0.2, 3, 0.2, 0.2);
                    GraphGroundDebugInfo debug;
                    List<Vector2D> output = GraphGroundFilter.Apply(input, out debug, GraphSnapshot(2));
                    SamePoints(output, Points(0, 0, 0.2, 0.2));
                    Check(debug.NX == 3 && debug.NY == 4, "grid dimensions changed");
                    Check(debug.Grid[0] == 2 && debug.Grid[3] == 2 && debug.Grid[4] == 1,
                        "occupancy or cell indexing changed");
                    Check(debug.CellType[0] == 1 && debug.CellType[3] == 3 && debug.CellType[4] == 0,
                        "ground/high/inactive classification changed");
                    Check(debug.InputPointCount == 5 && debug.OutputPointCount == 2,
                        "debug counts changed");
                });
                Test("ground classification follows each column's local slope", delegate
                {
                    List<Vector2D> input = Points(-2, -3, -1, -2, 0, -1);
                    GraphGroundDebugInfo debug;
                    SamePoints(GraphGroundFilter.Apply(input, out debug, GraphSnapshot(1)), input);
                    Check(debug.XMin == -2 && debug.YMin == -3, "negative grid origin changed");
                    Check(debug.CellType[0] == 1 && debug.CellType[4] == 1 && debug.CellType[8] == 1,
                        "slope cells must be local ground");
                });
                Test("sampling uses banker rounding at half counts and reports completion", delegate
                {
                    List<Vector4D> input = new List<Vector4D>();
                    for (int i = 0; i < 5; i++) input.Add(new Vector4D(i, 0, 0, 0));
                    float last = -1;
                    List<Vector4D> zero = SamplingHelper.ReduceByPercentWithProgress(input, 10,
                        delegate(float progress) { last = progress; });
                    Check(zero.Count == 0 && last == 1f, "5 * 10% must round 0.5 to zero");
                    List<Vector4D> two = SamplingHelper.ReduceByPercentWithProgress(input, 30, null);
                    Check(two.Count == 2, "5 * 30% must round 1.5 to two");
                    List<Vector4D> full = SamplingHelper.ReduceByPercentWithProgress(input, 100, null);
                    Check(!Object.ReferenceEquals(full, input), "full result aliases source list");
                    for (int i = 0; i < 5; i++) Check(full[i].X == i, "full result changed source order");
                });
                Console.WriteLine("PASS " + passed + " algorithm contracts");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL after " + passed + " contracts: " + ex);
                return 1;
            }
        }
    }
}
