// tests/Net35/CharacterizationTests.cs
// Wave 0 / PR-01 characterization suite for the LAS_TERRAIN filtering pipeline.
//
// PURPOSE: freeze CURRENT numerical behavior of the deterministic filter stages
// as executable assertions, so later refactors (PR-03..PR-05) cannot silently
// change results. The assertions below ARE the baseline snapshot; every test
// also prints its measurements as "BASELINE <label> = <value>" lines, so a run
// log doubles as the recorded baseline.
//
// MODES:
//   CharacterizationTests.exe         — full mode: prints baselines AND asserts.
//   CharacterizationTests.exe probe   — probe mode: prints baselines, asserts
//                                        only structural invariants. Used to
//                                        capture baseline values; values are
//                                        then hard-coded in this file.
//
// WHAT IS COVERED AND WHAT IS NOT (recorded for the lead):
//  1. Compilable under v3.5 csc and covered here: OrderByX, GraphGroundFilter
//     (+ GraphGroundDebugInfo), BreakDetector (+ SegmentBoundary),
//     SplitAndMergeAlgorithm, SmoothingSplineFilter, SamplingHelper
//     (via CharacterizationStubs.Vector4D), PointKey2D/3D dedup policy.
//  2. NOT compilable under v3.5 csc (C# > 3 syntax) — characterized only by
//     source reading, must be re-characterized after PR-04 mechanical fixes:
//       - RobustGroundSplineFilter.cs:344 — C# 4 NAMED ARGUMENTS
//         `solver.Solve(ys, ones, smooth: 0.0, ridgeEps: stableRidge);`
//         This is the PRIMARY ground stage (RuntimeConfig.UseSplineFilter
//         defaults true), so the spline-grid output stage of the chain is
//         currently untestable in isolation.
//       - SmoothingBSplineFilter.cs:67-75 — C# 4 named arguments in the
//         BSplineApproximator constructor call.
//       - FilterAggregator.cs — C# 6 null-conditional `progressCallback?.Invoke`
//         AND RuntimeConfig.UseSplineFilter, which the shared Stubs.cs lacks.
//       - MinWeightedGroundLevelMedianFilter.cs — C# 6 `using static` +
//         C# 4 optional parameters.
//       - SmoothingCSplineFilter.cs — C# 6 expression-bodied property bound to
//         RuntimeConfig.CSplineSmooth (also missing from Stubs.cs).
//       - GraphGround3DFilter.cs — C# 4 optional parameter
//         (`Action<float> onProgress = null`) + Topomatic.FoundationClasses.Parallel
//         + Vector4D member usage.
//  3. LasFilterService.cs is C# 3-clean itself but needs, in Stubs.cs:
//     Vector2D operator+ / operator* (verified componentwise in the decompiled
//     SDK) and a Vector3D stub with ctor Vector3D(Vector2D, double). Until the
//     lead extends Stubs.cs, the world-transform math is characterized only by
//     source reading (LasFilterService.ApplyFilter internal overload).
//  4. The "subchain" tests reproduce FilterAggregator's stage ORDER
//     OrderByX → GraphGroundFilter → BreakDetector and then apply
//     SplitAndMergeAlgorithm DIRECTLY TO the GraphGround output. That last step
//     is a labeled SURROGATE: in production SplitAndMerge consumes the
//     RobustGroundSplineFilter grid output, not raw graph points. It still
//     pins down the deterministic 3-stage subchain and the simplification of
//     a real ground-point polyline.
//  5. SplitAndMergeAlgorithm accepts an explicit tolerance only. These tests
//     pass the product default 0.07 explicitly
//     (LaunchSettings/Settings.cs: SettingsDefaults.SplitMergeTolerance).
//  6. SamplingHelper.ReservoirSampleWithProgress creates `new Random()` with
//     no seam to inject a seed, so its OUTPUT CONTENT is not deterministic
//     across runs. Characterized structurally only (counts, membership,
//     order-preservation, progress reporting). Missing seed seam is an
//     integration request for the parameter-snapshot work (PR-03).
//  7. Filter static parameters (GraphGroundFilter.BinX/BinY/MinPts,
//     BreakDetector.*, SmoothingSplineFilter.Lambda) are app-global mutable
//     statics — a known hidden coupling (parent plan §3). Every test SETS the
//     statics it depends on before running, so tests are order-independent.
//
// COMPILE CONTRACT: C# 3.0 / .NET 3.5 only (v3.5 csc, /langversion:default).

using System;
using System.Collections.Generic;
using System.Diagnostics;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Tests.Fixtures;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class CharacterizationTests
    {
        private const double Tol = 1e-9;

        private static bool _probe;
        private static int _passed;
        private static int _failed;

        private static void Assert(bool value, string message)
        {
            if (!value) throw new Exception(message);
        }

        private static void Record(string label, string value)
        {
            Console.WriteLine("BASELINE " + label + " = " + value);
        }

        private static void Record(string label, double value)
        {
            Record(label, value.ToString("R"));
        }

        /// <summary>Records the measurement; asserts the baseline in full mode.</summary>
        private static void Expect(string label, double actual, double expected)
        {
            Record(label, actual);
            if (_probe) return;
            Assert(Math.Abs(actual - expected) <= Tol * Math.Max(1.0, Math.Abs(expected)),
                label + ": expected " + expected.ToString("R") + " got " + actual.ToString("R"));
        }

        private static void ExpectCount(string label, int actual, int expected)
        {
            Record(label, actual.ToString());
            if (_probe) return;
            Assert(actual == expected, label + ": expected " + expected + " got " + actual);
        }

        private static void ExpectTrue(bool condition, string message)
        {
            if (_probe) return;
            Assert(condition, message);
        }

        private static void Test(string name, Action body)
        {
            try
            {
                body();
                _passed++;
                Console.WriteLine("PASS " + name);
            }
            catch (Exception error)
            {
                _failed++;
                Console.WriteLine("FAIL " + name + " :: " + error.Message);
            }
        }

        // ── helpers ─────────────────────────────────────────────────────────

        private static bool IsAscendingX(List<Vector2D> pts)
        {
            for (int i = 1; i < pts.Count; i++)
                if (pts[i].X < pts[i - 1].X) return false;
            return true;
        }

        private static double MaxYDeviation(List<Vector2D> pts, Func<double, double> reference)
        {
            double max = 0.0;
            for (int i = 0; i < pts.Count; i++)
            {
                double d = Math.Abs(pts[i].Y - reference(pts[i].X));
                if (d > max) max = d;
            }
            return max;
        }

        private static bool SameValues(List<Vector4D> a, IList<Vector4D> b)
        {
            if (a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].X != b[i].X || a[i].Y != b[i].Y || a[i].Z != b[i].Z || a[i].W != b[i].W)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Replica of GroundPointsCollector.RemoveDuplicatesByXY (first
        /// occurrence per PointKey2D millimetre cell wins). The production
        /// method is private inside an SDK-bound class, so the POLICY is
        /// characterized through the production PointKey2D type.
        /// </summary>
        private static List<Vector4D> DeduplicateByXYReplica(List<Vector4D> input)
        {
            HashSet<PointKey2D> unique = new HashSet<PointKey2D>();
            List<Vector4D> result = new List<Vector4D>();
            for (int i = 0; i < input.Count; i++)
            {
                Vector4D point = input[i];
                if (unique.Add(PointKey2D.Millimetre(point.X, point.Y))) result.Add(point);
            }
            return result;
        }

        /// <summary>
        /// Replica of the compilable prefix of FilterAggregator.Apply
        /// (UseSplineFilter = true, EnableBreakDetection = true):
        /// OrderByX → GraphGroundFilter → BreakDetector. See header note 4.
        /// </summary>
        private static List<Vector2D> SubchainFilter(List<Vector2D> input, out List<SegmentBoundary> breaks)
        {
            List<Vector2D> ordered = OrderByX.Apply(input);
            GraphGroundDebugInfo debug;
            List<Vector2D> ground = GraphGroundFilter.Apply(ordered, out debug, DefaultSnapshot());
            breaks = BreakDetector.FindBreaks(ground, DefaultSnapshot());
            return ground;
        }

        private static FilterOperationSnapshot DefaultSnapshot()
        {
            return new FilterOperationSnapshot(
                true, true, 0.07,
                1.0, 1.0, 1,
                5, 8, 0.175, 0.80, 6, 5,
                3, 8, 0.25, 0.0, 0.05, 1e-4,
                256, 1e-9, 1.0, false, 0.3);
        }

        public static int Main(string[] args)
        {
            _probe = args != null && args.Length > 0 && args[0] == "probe";
            Console.WriteLine("== LAS_TERRAIN characterization suite (" +
                (_probe ? "probe" : "full") + " mode) ==");

            Test("OrderByX.ordinary.unsorted-input", TestOrderByXOrdinary);
            Test("OrderByX.degenerate", TestOrderByXDegenerate);

            Test("GraphGround.ordinary", TestGraphOrdinary);
            Test("GraphGround.vegetation-dropped", TestGraphVegetation);
            Test("GraphGround.negative-coords", TestGraphNegative);
            Test("GraphGround.duplicates", TestGraphDuplicates);
            Test("GraphGround.empty", TestGraphEmpty);
            Test("GraphGround.large-timing", TestGraphLarge);

            Test("BreakDetector.profile-break", TestBreakOnProfileBreak);
            Test("BreakDetector.curb-not-detected", TestBreakOnCurbNotDetected);
            Test("BreakDetector.ordinary-no-breaks", TestBreakOnOrdinary);
            Test("BreakDetector.graph-vegetation-output", TestBreakOnGraphVegetation);
            Test("BreakDetector.degenerate", TestBreakDegenerate);

            Test("SplitAndMerge.ordinary", TestSplitMergeOrdinary);
            Test("SplitAndMerge.profile-break", TestSplitMergeBreak);
            Test("SplitAndMerge.curb", TestSplitMergeCurb);
            Test("SplitAndMerge.duplicates", TestSplitMergeDuplicates);
            Test("SplitAndMerge.degenerate", TestSplitMergeDegenerate);
            Test("SplitAndMerge.negative-translation-invariant", TestSplitMergeNegative);

            Test("SmoothingSpline.ordinary", TestSmoothingSplineOrdinary);
            Test("SmoothingSpline.degenerate", TestSmoothingSplineDegenerate);

            Test("SamplingHelper.edge-cases", TestSamplingEdges);
            Test("SamplingHelper.reservoir-structure", TestSamplingReservoir);
            Test("SamplingHelper.percent-reduce", TestSamplingPercent);
            Test("SamplingHelper.two-sets-progress", TestSamplingTwoSets);

            Test("Dedup.first-wins-millimetre", TestDedupFirstWins);

            Test("Subchain.ordinary", TestSubchainOrdinary);
            Test("Subchain.profile-break", TestSubchainBreak);
            Test("Subchain.negative", TestSubchainNegative);
            Test("Subchain.empty", TestSubchainEmpty);
            Test("Subchain.large-timing", TestSubchainLarge);

            Console.WriteLine("RESULT passed=" + _passed + " failed=" + _failed);
            return _failed == 0 ? 0 : 1;
        }

        // ── OrderByX ────────────────────────────────────────────────────────

        private static void TestOrderByXOrdinary()
        {
            List<Vector2D> input = FixtureData.OrdinarySection();
            ExpectCount("orderbyx.ordinary.input-count", input.Count, 41);
            List<Vector2D> same = OrderByX.Apply(input);
            ExpectTrue(ReferenceEquals(same, input), "OrderByX must sort in place (same instance)");
            ExpectCount("orderbyx.ordinary.output-count", same.Count, 41);
            Expect("orderbyx.ordinary.first-x", same[0].X, 0.0);
            Expect("orderbyx.ordinary.last-x", same[same.Count - 1].X, 20.0);
            ExpectTrue(IsAscendingX(same), "OrderByX output must be ascending by X");
        }

        private static void TestOrderByXDegenerate()
        {
            List<Vector2D> empty = FixtureData.EmptySection();
            ExpectTrue(ReferenceEquals(OrderByX.Apply(empty), empty), "empty: same instance expected");
            List<Vector2D> single = FixtureData.SinglePoint();
            ExpectTrue(ReferenceEquals(OrderByX.Apply(single), single), "single: same instance expected");
            ExpectTrue(OrderByX.Apply(null) == null, "null: null expected (documented pass-through)");
        }

        // ── GraphGroundFilter ───────────────────────────────────────────────

        private static void TestGraphOrdinary()
        {
            Record("graph.params", "BinX=1.0 BinY=1.0 MinPts=1 (product defaults)");
            List<Vector2D> input = FixtureData.OrdinarySection();
            List<Vector2D> ordered = OrderByX.Apply(input);
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(ordered, out debug, DefaultSnapshot());
            ExpectCount("graph.ordinary.output-count", outPts.Count, 41);
            ExpectTrue(debug != null, "debug info expected for non-empty input");
            ExpectCount("graph.ordinary.debug-input", debug.InputPointCount, 41);
            ExpectCount("graph.ordinary.debug-output", debug.OutputPointCount, 41);
            ExpectCount("graph.ordinary.debug-nx", debug.NX, 21);
            ExpectCount("graph.ordinary.debug-ny", debug.NY, 2);
            Record("graph.ordinary.debug-xmin", debug.XMin);
            Record("graph.ordinary.debug-ymin", debug.YMin);
            ExpectCount("graph.ordinary.debug-maxcount", debug.MaxCount, 2);
        }

        private static void TestGraphVegetation()
        {
            List<Vector2D> input = FixtureData.LargeSection();
            List<Vector2D> ordered = OrderByX.Apply(input);
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(ordered, out debug, DefaultSnapshot());
            Record("graph.vegetation.output-count", outPts.Count.ToString());
            ExpectCount("graph.vegetation.output-count", outPts.Count, 19101);
            ExpectTrue(outPts.Count < input.Count, "vegetation clumps must be dropped");
            // No surviving point may sit inside a vegetation clump band.
            double maxKeptInClump = 0.0;
            for (int i = 0; i < outPts.Count; i++)
            {
                if ((outPts[i].X >= 4.0 && outPts[i].X < 4.4)
                    || (outPts[i].X >= 12.0 && outPts[i].X < 12.1))
                    if (outPts[i].Y > maxKeptInClump) maxKeptInClump = outPts[i].Y;
            }
            Record("graph.vegetation.max-kept-y-in-clump", maxKeptInClump);
            ExpectTrue(maxKeptInClump < 102.0, "vegetation survived the graph filter");
        }

        private static void TestGraphNegative()
        {
            List<Vector2D> input = FixtureData.NegativeCoordinatesSection();
            List<Vector2D> ordered = OrderByX.Apply(input);
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(ordered, out debug, DefaultSnapshot());
            Record("graph.negative.output-count", outPts.Count.ToString());
            ExpectCount("graph.negative.debug-nx", debug.NX, 21);
            Expect("graph.negative.debug-xmin", debug.XMin, -1000.0);
            ExpectCount("graph.negative.debug-maxcount", debug.MaxCount, 2);
        }

        private static void TestGraphDuplicates()
        {
            List<Vector2D> input = FixtureData.DuplicateXYSection();
            List<Vector2D> ordered = OrderByX.Apply(input);
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(ordered, out debug, DefaultSnapshot());
            Record("graph.duplicates.output-count", outPts.Count.ToString());
            ExpectCount("graph.duplicates.output-count", outPts.Count, 24);
            ExpectCount("graph.duplicates.debug-input", debug.InputPointCount, 26);
        }

        private static void TestGraphEmpty()
        {
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(FixtureData.EmptySection(), out debug, DefaultSnapshot());
            ExpectCount("graph.empty.output-count", outPts.Count, 0);
            ExpectTrue(debug == null, "empty input must leave debug info null (documented)");
        }

        private static void TestGraphLarge()
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<Vector2D> input = OrderByX.Apply(FixtureData.LargeSection());
            GraphGroundDebugInfo debug;
            List<Vector2D> outPts = GraphGroundFilter.Apply(input, out debug, DefaultSnapshot());
            sw.Stop();
            Record("graph.large.output-count", outPts.Count.ToString());
            Record("graph.large.elapsed-ms", sw.ElapsedMilliseconds.ToString());
        }

        // ── BreakDetector ───────────────────────────────────────────────────

        private static void TestBreakOnProfileBreak()
        {
            Record("break.params", "SlopeWindow=5 R2Window=8 AngleThreshold=0.175 MinR2=0.8 MinSegmentPoints=6 SuppressRadius=5");
            List<Vector2D> pts = FixtureData.ProfileBreakSection();
            List<SegmentBoundary> breaks = BreakDetector.FindBreaks(pts, DefaultSnapshot());
            ExpectCount("break.embankment.count", breaks.Count, 1);
            if (breaks.Count > 0)
            {
                // LSQ-line intersection, not exactly the design point (8, 14).
                Expect("break.embankment.x", breaks[0].X, 7.9561523705127053);
                Expect("break.embankment.y", breaks[0].Y, 13.973166896605836);
                Record("break.embankment.strength-deg", (breaks[0].Strength * 180.0 / Math.PI).ToString("R"));
                ExpectTrue(breaks[0].Type == BoundaryType.Break, "type must be Break");
                ExpectTrue(breaks[0].X > 7.5 && breaks[0].X < 8.5, "break must localize at the slope change");
            }
        }

        private static void TestBreakOnCurbNotDetected()
        {
            // Documented FALSE NEGATIVE of the current defaults: see
            // FixtureData.CurbSection. A noisy-flat window has LSQ R² ≈ 0
            // (pure noise explains itself), failing MinR2 = 0.8 on both sides
            // of the curb, so no break is reported.
            List<SegmentBoundary> breaks = BreakDetector.FindBreaks(FixtureData.CurbSection(), DefaultSnapshot());
            ExpectCount("break.curb-not-detected.count", breaks.Count, 0);
        }

        private static void TestBreakOnOrdinary()
        {
            List<Vector2D> pts = FixtureData.OrdinarySection();
            List<SegmentBoundary> breaks = BreakDetector.FindBreaks(OrderByX.Apply(pts), DefaultSnapshot());
            ExpectCount("break.ordinary.count", breaks.Count, 0);
        }

        private static void TestBreakOnGraphVegetation()
        {
            // Production order: BreakDetector consumes GraphGround output.
            List<Vector2D> input = OrderByX.Apply(FixtureData.LargeSection());
            GraphGroundDebugInfo debug;
            List<Vector2D> ground = GraphGroundFilter.Apply(input, out debug, DefaultSnapshot());
            List<SegmentBoundary> breaks = BreakDetector.FindBreaks(ground, DefaultSnapshot());
            Record("break.graphvegetation.count", breaks.Count.ToString());
            for (int i = 0; i < breaks.Count; i++)
                Record("break.graphvegetation.x" + i, breaks[i].X);
        }

        private static void TestBreakDegenerate()
        {
            ExpectCount("break.empty.count", BreakDetector.FindBreaks(FixtureData.EmptySection(), DefaultSnapshot()).Count, 0);
            ExpectCount("break.single.count", BreakDetector.FindBreaks(FixtureData.SinglePoint(), DefaultSnapshot()).Count, 0);
            ExpectCount("break.two-points.count", BreakDetector.FindBreaks(FixtureData.TinyTwoPoints(), DefaultSnapshot()).Count, 0);
        }

        // ── SplitAndMergeAlgorithm ──────────────────────────────────────────

        private static void TestSplitMergeOrdinary()
        {
            List<Vector2D> outPts = SplitAndMergeAlgorithm.Apply(
                OrderByX.Apply(FixtureData.OrdinarySection()), 0.07);
            Record("splitmerge.ordinary.count", outPts.Count.ToString());
            ExpectCount("splitmerge.ordinary.count", outPts.Count, 2);
            Expect("splitmerge.ordinary.first-x", outPts[0].X, 0.0);
            Expect("splitmerge.ordinary.last-x", outPts[outPts.Count - 1].X, 20.0);
        }

        private static void TestSplitMergeBreak()
        {
            List<Vector2D> outPts = SplitAndMergeAlgorithm.Apply(
                FixtureData.ProfileBreakSection(), 0.07);
            Record("splitmerge.embankment.count", outPts.Count.ToString());
            ExpectCount("splitmerge.embankment.count", outPts.Count, 3);
            Expect("splitmerge.embankment.first-x", outPts[0].X, 0.0);
            Expect("splitmerge.embankment.kink-x", outPts[1].X, 8.0);
            Expect("splitmerge.embankment.kink-y", outPts[1].Y, 13.97576);
            Expect("splitmerge.embankment.last-x", outPts[2].X, 16.0);
        }

        private static void TestSplitMergeCurb()
        {
            List<Vector2D> outPts = SplitAndMergeAlgorithm.Apply(
                FixtureData.CurbSection(), 0.07);
            Record("splitmerge.curb.count", outPts.Count.ToString());
            ExpectCount("splitmerge.curb.count", outPts.Count, 4);
            // Baseline: the 3 curb-face points collapse to one straight jump
            // between the berm edges (v1 → v2).
            Expect("splitmerge.curb.v0-x", outPts[0].X, 0.0);
            Expect("splitmerge.curb.v0-y", outPts[0].Y, 9.97096);
            Expect("splitmerge.curb.v1-x", outPts[1].X, 8.0);
            Expect("splitmerge.curb.v1-y", outPts[1].Y, 9.97576);
            Expect("splitmerge.curb.v2-x", outPts[2].X, 9.0);
            Expect("splitmerge.curb.v2-y", outPts[2].Y, 10.41716);
            Expect("splitmerge.curb.v3-x", outPts[3].X, 16.0);
            Expect("splitmerge.curb.v3-y", outPts[3].Y, 10.4472);
        }

        private static void TestSplitMergeDuplicates()
        {
            List<Vector2D> outPts = SplitAndMergeAlgorithm.Apply(
                FixtureData.DuplicateXYSection(), 0.07);
            Record("splitmerge.duplicates.count", outPts.Count.ToString());
            // Exact consecutive duplicates must collapse; the same-X vertical
            // stack at x=5.0 must survive as distinct vertices.
            ExpectCount("splitmerge.duplicates.count", outPts.Count, 5);
            // Baseline: the vertical stack at x=5.0 keeps only its ground
            // point (5, 50.22462) and its top (5, 56.5); the middle point
            // (5, 53.0) is DROPPED by the Douglas-Peucker recursion —
            // simplification is NOT lossless across a same-X vertical stack.
            Expect("splitmerge.duplicates.v0-x", outPts[0].X, 0.0);
            Expect("splitmerge.duplicates.v0-y", outPts[0].Y, 49.97096);
            Expect("splitmerge.duplicates.v1-x", outPts[1].X, 5.0);
            Expect("splitmerge.duplicates.v1-y", outPts[1].Y, 50.22462);
            Expect("splitmerge.duplicates.v2-x", outPts[2].X, 5.0);
            Expect("splitmerge.duplicates.v2-y", outPts[2].Y, 56.5);
            Expect("splitmerge.duplicates.v3-x", outPts[3].X, 5.5);
            Expect("splitmerge.duplicates.v3-y", outPts[3].Y, 50.28007);
            Expect("splitmerge.duplicates.v4-x", outPts[4].X, 10.0);
            Expect("splitmerge.duplicates.v4-y", outPts[4].Y, 50.47924);
        }

        private static void TestSplitMergeDegenerate()
        {
            ExpectCount("splitmerge.null.count", SplitAndMergeAlgorithm.Apply(null, 0.07).Count, 0);
            ExpectCount("splitmerge.empty.count", SplitAndMergeAlgorithm.Apply(FixtureData.EmptySection(), 0.07).Count, 0);
            List<Vector2D> one = SplitAndMergeAlgorithm.Apply(FixtureData.SinglePoint(), 0.07);
            ExpectCount("splitmerge.single.count", one.Count, 1);
            Expect("splitmerge.single.y", one[0].Y, 42.0);
            // Consecutive exact duplicates collapse to one vertex.
            List<Vector2D> trip = new List<Vector2D>();
            trip.Add(new Vector2D(1.0, 1.0));
            trip.Add(new Vector2D(1.0, 1.0));
            trip.Add(new Vector2D(1.0, 1.0));
            ExpectCount("splitmerge.consecutive-dups.count", SplitAndMergeAlgorithm.Apply(trip, 0.07).Count, 1);
        }

        private static void TestSplitMergeNegative()
        {
            List<Vector2D> neg = SplitAndMergeAlgorithm.Apply(
                OrderByX.Apply(FixtureData.NegativeCoordinatesSection()), 0.07);
            // Same shape translated to positive quadrant must simplify identically.
            List<Vector2D> pos = new List<Vector2D>();
            foreach (Vector2D p in FixtureData.NegativeCoordinatesSection())
                pos.Add(new Vector2D(p.X + 1000.0, p.Y + 15.0));
            List<Vector2D> posOut = SplitAndMergeAlgorithm.Apply(OrderByX.Apply(pos), 0.07);
            Record("splitmerge.negative.count", neg.Count.ToString());
            Record("splitmerge.shifted.count", posOut.Count.ToString());
            ExpectCount("splitmerge.translation.count-equal", posOut.Count, neg.Count);
            Expect("splitmerge.negative.first-x", neg[0].X, -1000.0);
            Expect("splitmerge.negative.last-x", neg[neg.Count - 1].X, -980.0);
        }

        // ── SmoothingSplineFilter ───────────────────────────────────────────

        private static void TestSmoothingSplineOrdinary()
        {
            SmoothingSplineFilter.Lambda = 0.1;
            Record("smoothspline.params", "Lambda=0.1 (product default)");
            List<Vector2D> input = OrderByX.Apply(FixtureData.OrdinarySection());
            List<Vector2D> outPts = SmoothingSplineFilter.Apply(input);
            ExpectCount("smoothspline.ordinary.output-count", outPts.Count, 41);
            ExpectTrue(IsAscendingX(outPts), "output X sequence must match input order");
            double maxShift = 0.0;
            for (int i = 0; i < outPts.Count; i++)
            {
                ExpectTrue(outPts[i].X == input[i].X, "X must be preserved exactly");
                double d = Math.Abs(outPts[i].Y - input[i].Y);
                if (d > maxShift) maxShift = d;
            }
            Record("smoothspline.ordinary.max-y-shift", maxShift);
            ExpectTrue(maxShift > 0.0, "smoothing must change Y (noise present)");
        }

        private static void TestSmoothingSplineDegenerate()
        {
            SmoothingSplineFilter.Lambda = 0.1;
            ExpectCount("smoothspline.empty.count", SmoothingSplineFilter.Apply(FixtureData.EmptySection()).Count, 0);
            List<Vector2D> one = SmoothingSplineFilter.Apply(FixtureData.SinglePoint());
            ExpectCount("smoothspline.single.count", one.Count, 1);
            Expect("smoothspline.single.y", one[0].Y, 42.0);
        }

        // ── SamplingHelper (structural; content is nondeterministic) ────────

        private static void TestSamplingEdges()
        {
            float lastProgress = -1.0f;
            List<Vector4D> empty = SamplingHelper.ReservoirSampleWithProgress(
                null, 10, delegate(float p) { lastProgress = p; });
            ExpectCount("sampling.null.count", empty.Count, 0);
            Expect("sampling.null.progress", lastProgress, 1.0);

            lastProgress = -1.0f;
            ExpectCount("sampling.empty-source.count",
                SamplingHelper.ReservoirSampleWithProgress(
                    FixtureData.SamplingSource(0), 10, delegate(float p) { lastProgress = p; }).Count, 0);
            Expect("sampling.empty-source.progress", lastProgress, 1.0);

            lastProgress = -1.0f;
            ExpectCount("sampling.k-zero.count",
                SamplingHelper.ReservoirSampleWithProgress(
                    FixtureData.SamplingSource(50), 0, delegate(float p) { lastProgress = p; }).Count, 0);
            Expect("sampling.k-zero.progress", lastProgress, 1.0);

            // k >= n: full copy, order preserved.
            List<Vector4D> src = FixtureData.SamplingSource(50);
            List<Vector4D> full = SamplingHelper.ReservoirSampleWithProgress(src, 50, null);
            ExpectCount("sampling.k-eq-n.count", full.Count, 50);
            ExpectTrue(SameValues(full, src), "k >= n must return the source in order");
        }

        private static void TestSamplingReservoir()
        {
            List<Vector4D> src = FixtureData.SamplingSource(1000);
            List<float> progress = new List<float>();
            List<Vector4D> sample = SamplingHelper.ReservoirSampleWithProgress(
                src, 100, delegate(float p) { progress.Add(p); });
            ExpectCount("sampling.reservoir.count", sample.Count, 100);
            // Every sampled element must be a member of the source (value equality).
            HashSet<PointKey3D> srcKeys = new HashSet<PointKey3D>();
            for (int i = 0; i < src.Count; i++)
                srcKeys.Add(PointKey3D.Exact(src[i].X, src[i].Y, src[i].Z));
            int foreign = 0;
            for (int i = 0; i < sample.Count; i++)
                if (!srcKeys.Contains(PointKey3D.Exact(sample[i].X, sample[i].Y, sample[i].Z)))
                    foreign++;
            ExpectCount("sampling.reservoir.foreign-elements", foreign, 0);
            // Progress: monotonic, final call is exactly 1f.
            ExpectTrue(progress.Count >= 10, "progress must be reported at least ~once per 1%");
            bool monotonic = true;
            for (int i = 1; i < progress.Count; i++)
                if (progress[i] < progress[i - 1]) monotonic = false;
            ExpectTrue(monotonic, "progress must be nondecreasing");
            Expect("sampling.reservoir.progress-last", progress[progress.Count - 1], 1.0);
        }

        private static void TestSamplingPercent()
        {
            List<Vector4D> src = FixtureData.SamplingSource(1000);
            List<Vector4D> half = SamplingHelper.ReduceByPercentWithProgress(src, 50.0, null);
            ExpectCount("sampling.percent50.count", half.Count, 500);
            ExpectCount("sampling.percent100.count",
                SamplingHelper.ReduceByPercentWithProgress(src, 100.0, null).Count, 1000);
            ExpectTrue(SameValues(
                SamplingHelper.ReduceByPercentWithProgress(src, 150.0, null), src),
                "percent >= 100 must return the full source in order");
            ExpectCount("sampling.percent0.count",
                SamplingHelper.ReduceByPercentWithProgress(src, 0.0, null).Count, 0);
            ExpectCount("sampling.percent-negative.count",
                SamplingHelper.ReduceByPercentWithProgress(src, -5.0, null).Count, 0);
        }

        private static void TestSamplingTwoSets()
        {
            List<Vector4D> a = FixtureData.SamplingSource(400);
            List<Vector4D> b = FixtureData.SamplingSource(600);
            float last = -1.0f;
            List<Vector4D> ra, rb;
            SamplingHelper.ReduceTwoSetsByPercentWithProgress(
                a, 50.0, b, 50.0, 0.25f, 0.5f, 0.4f,
                delegate(float p) { last = p; }, out ra, out rb);
            ExpectCount("sampling.twosets.first-count", ra.Count, 200);
            ExpectCount("sampling.twosets.second-count", rb.Count, 300);
            Expect("sampling.twosets.progress-end", last, 0.75);
        }

        // ── Duplicate-XY dedup policy ───────────────────────────────────────

        private static void TestDedupFirstWins()
        {
            List<Vector4D> input = FixtureData.DuplicateXYWorldPoints();
            List<Vector4D> kept = DeduplicateByXYReplica(input);
            ExpectCount("dedup.world.kept-count", kept.Count, 6);
            Expect("dedup.world.z0", kept[0].Z, 100.0);
            Expect("dedup.world.z1", kept[1].Z, 7.0);
            Expect("dedup.world.z2", kept[2].Z, 3.0);
            Expect("dedup.world.z3", kept[3].Z, 2.0);
            Expect("dedup.world.z4", kept[4].Z, 5.0);
            Expect("dedup.world.z5", kept[5].Z, 6.0);
            // The 2^32-millimetre pair must occupy distinct cells (no wrap).
            ExpectTrue(!PointKey2D.Millimetre(input[8].X, input[8].Y)
                .Equals(PointKey2D.Millimetre(input[9].X, input[9].Y)), "wrap collision");
        }

        // ── Subchain (FilterAggregator replica prefix + surrogate simplify) ─

        private static void TestSubchainOrdinary()
        {
            List<SegmentBoundary> breaks;
            List<Vector2D> ground = SubchainFilter(FixtureData.OrdinarySection(), out breaks);
            ExpectCount("subchain.ordinary.breaks", breaks.Count, 0);
            List<Vector2D> simplified = SplitAndMergeAlgorithm.Apply(ground, 0.07);
            Record("subchain.ordinary.simplified-count", simplified.Count.ToString());
            ExpectCount("subchain.ordinary.simplified-count", simplified.Count, 2);
            Expect("subchain.ordinary.first-x", simplified[0].X, 0.0);
            Expect("subchain.ordinary.last-x", simplified[simplified.Count - 1].X, 20.0);
        }

        private static void TestSubchainBreak()
        {
            List<SegmentBoundary> breaks;
            List<Vector2D> ground = SubchainFilter(FixtureData.ProfileBreakSection(), out breaks);
            ExpectCount("subchain.embankment.breaks", breaks.Count, 1);
            if (breaks.Count > 0)
                Expect("subchain.embankment.break-x", breaks[0].X, 7.9561523705127053);
            // SURROGATE: production simplifies the spline grid, not raw ground
            // points. This pins the deterministic subchain behavior as-is.
            List<Vector2D> simplified = SplitAndMergeAlgorithm.Apply(ground, 0.07);
            Record("subchain.embankment.simplified-count", simplified.Count.ToString());
            ExpectTrue(simplified.Count >= 3, "slope-change kink must survive simplification");
            bool kinkKept = false;
            for (int i = 0; i < simplified.Count; i++)
                if (simplified[i].X > 7.5 && simplified[i].X < 8.5) kinkKept = true;
            ExpectTrue(kinkKept, "kink vertex range must survive simplification");
        }

        private static void TestSubchainNegative()
        {
            List<SegmentBoundary> breaks;
            List<Vector2D> ground = SubchainFilter(FixtureData.NegativeCoordinatesSection(), out breaks);
            ExpectCount("subchain.negative.breaks", breaks.Count, 0);
            Expect("subchain.negative.ground-min-x", ground[0].X, -1000.0);
            Expect("subchain.negative.ground-max-x", ground[ground.Count - 1].X, -980.0);
            List<Vector2D> simplified = SplitAndMergeAlgorithm.Apply(ground, 0.07);
            Record("subchain.negative.simplified-count", simplified.Count.ToString());
            ExpectCount("subchain.negative.simplified-count", simplified.Count, 2);
            Expect("subchain.negative.first-x", simplified[0].X, -1000.0);
            Expect("subchain.negative.last-x", simplified[simplified.Count - 1].X, -980.0);
        }

        private static void TestSubchainEmpty()
        {
            List<SegmentBoundary> breaks;
            List<Vector2D> ground = SubchainFilter(FixtureData.EmptySection(), out breaks);
            ExpectCount("subchain.empty.ground-count", ground.Count, 0);
            ExpectCount("subchain.empty.breaks", breaks.Count, 0);
            ExpectCount("subchain.empty.simplified-count",
                SplitAndMergeAlgorithm.Apply(ground, 0.07).Count, 0);
        }

        private static void TestSubchainLarge()
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<SegmentBoundary> breaks;
            List<Vector2D> ground = SubchainFilter(FixtureData.LargeSection(), out breaks);
            List<Vector2D> simplified = SplitAndMergeAlgorithm.Apply(ground, 0.07);
            sw.Stop();
            Record("subchain.large.breaks", breaks.Count.ToString());
            Record("subchain.large.simplified-count", simplified.Count.ToString());
            Record("subchain.large.elapsed-ms", sw.ElapsedMilliseconds.ToString());
            ExpectTrue(IsAscendingX(simplified), "subchain output must be ascending by X");
        }
    }
}
