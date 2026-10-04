using System;
using System.Collections.Generic;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Tests.Fixtures;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class FilterOperationSnapshotTests
    {
        private static FilterOperationSnapshot Snapshot(int minPts, double angleThreshold,
            double splineGridStep)
        {
            return new FilterOperationSnapshot(
                true, true, 0.01,
                1.0, 1.0, minPts,
                5, 8, angleThreshold, 0.80, 6, 5,
                3, 8, 0.25, 0.0, splineGridStep, 1e-4,
                256, 1e-9, 1.0, false, 0.3);
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
        }

        public static int Main()
        {
            FilterOperationSnapshot snapshot = Snapshot(1, 0.175, 0.05);

            List<Vector2D> points = FixtureData.OrdinarySection();
            GraphGroundDebugInfo debug;
            List<Vector2D> expected = GraphGroundFilter.Apply(points, out debug, snapshot);
            Check(expected.Count > 0, "ground fixture must produce points");

            FilterOperationSnapshot otherGraph = Snapshot(int.MaxValue, 0.175, 0.05);
            Check(GraphGroundFilter.Apply(points, out debug, otherGraph).Count != expected.Count,
                "graph fixture must respond to minPts");
            List<Vector2D> actual = GraphGroundFilter.Apply(points, out debug, snapshot);
            Check(actual.Count == expected.Count, "captured graph parameter changed");
            for (int i = 0; i < expected.Count; i++)
                Check(actual[i].X == expected[i].X && actual[i].Y == expected[i].Y,
                    "captured graph output changed");

            List<Vector2D> profile = FixtureData.ProfileBreakSection();
            List<SegmentBoundary> expectedBreaks = BreakDetector.FindBreaks(profile, snapshot);
            Check(expectedBreaks.Count == 1, "break fixture must contain one break");

            FilterOperationSnapshot otherBreak = Snapshot(1, 100.0, 0.05);
            Check(BreakDetector.FindBreaks(profile, otherBreak).Count == 0,
                "break fixture must respond to angle threshold");
            List<SegmentBoundary> actualBreaks = BreakDetector.FindBreaks(profile, snapshot);
            Check(actualBreaks.Count == 1 &&
                actualBreaks[0].X == expectedBreaks[0].X &&
                actualBreaks[0].Y == expectedBreaks[0].Y,
                "captured break output changed");

            List<Vector2D> splineExpected = RobustGroundSplineFilter.Apply(profile, null, snapshot);
            Check(splineExpected.Count > 10, "spline fixture must produce a grid");

            FilterOperationSnapshot otherSpline = Snapshot(1, 0.175, 1.0);
            Check(RobustGroundSplineFilter.Apply(profile, null, otherSpline).Count !=
                splineExpected.Count, "spline fixture must respond to grid step");
            List<Vector2D> splineActual = RobustGroundSplineFilter.Apply(profile, null, snapshot);
            Check(splineActual.Count == splineExpected.Count, "captured spline grid changed");
            for (int i = 0; i < splineExpected.Count; i++)
                Check(splineActual[i].X == splineExpected[i].X &&
                    splineActual[i].Y == splineExpected[i].Y,
                    "captured spline values changed");

            Console.WriteLine("Filter operation snapshot tests passed.");
            return 0;
        }
    }
}
