using System;
using System.Collections.Generic;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class GraphGround3DSnapshotTests
    {
        private static int assertions;

        private static void Check(bool condition, string message)
        {
            assertions++;
            if (!condition) throw new Exception(message);
        }

        private static void CheckIds(List<Vector4D> points, params int[] expected)
        {
            Check(points.Count == expected.Length, "Filtered point count changed.");
            for (int i = 0; i < expected.Length; i++)
                Check(points[i].W == expected[i], "Filtered point order or membership changed at " + i);
        }

        private static List<Vector4D> HandPoints()
        {
            return new List<Vector4D> {
                new Vector4D(0, 0, 0, 0),
                new Vector4D(0, 0, 1, 1),
                new Vector4D(0, 0, 2, 2),
                new Vector4D(1, 0, -1, 3),
                new Vector4D(1, 0, 0, 4),
                new Vector4D(1, 0, 1, 5),
                new Vector4D(0, 0, 0, 6)
            };
        }

        private static uint Next(ref uint state)
        {
            state = unchecked(state * 1664525u + 1013904223u);
            return state;
        }

        private static List<Vector4D> SeededPoints()
        {
            uint state = 0x9E3779B9u;
            List<Vector4D> result = new List<Vector4D>();
            for (int i = 0; i < 96; i++)
            {
                double x = (int)(Next(ref state) % 5u) - 2;
                double y = (int)(Next(ref state) % 4u) - 1;
                double z = (int)(Next(ref state) % 7u) - 3;
                result.Add(new Vector4D(x, y, z, i));
            }
            return result;
        }

        private static void TestHandMembership()
        {
            List<float> progress = new List<float>();
            List<Vector4D> result = GraphGround3DFilter.Apply(HandPoints(),
                GraphGround3DSettingsAdapter.Capture(), delegate(float value)
            {
                progress.Add(value);
            });
            CheckIds(result, 0, 1, 3, 4, 6);
            Check(progress.Count > 3 && progress[0] == 0.3f &&
                progress[1] == 0.5f && progress[2] == 0.65f,
                "Initial progress milestones changed.");
            Check(progress[progress.Count - 1] == 1.0f,
                "Final progress milestone changed.");
        }

        private static void TestSparseCellThreshold()
        {
            int old = GraphGround3DSettingsAdapter.MinPts;
            try
            {
                GraphGround3DSettingsAdapter.MinPts = 2;
                List<Vector4D> input = new List<Vector4D> {
                    new Vector4D(-2, -3, 0, 10),
                    new Vector4D(-2, -3, 0, 11),
                    new Vector4D(-2, -3, 1, 12),
                    new Vector4D(-1, -3, 0, 13)
                };
                CheckIds(GraphGround3DFilter.Apply(input,
                    GraphGround3DSettingsAdapter.Capture(), null), 10, 11);
            }
            finally { GraphGround3DSettingsAdapter.MinPts = old; }
        }

        private static void TestSeededBaseline()
        {
            List<Vector4D> result = GraphGround3DFilter.Apply(SeededPoints(),
                GraphGround3DSettingsAdapter.Capture(), null);
            CheckIds(result,
                6, 11, 16, 21, 26, 27, 29, 36, 37, 39, 40, 43, 45, 46, 49,
                52, 53, 54, 58, 63, 64, 67, 68, 70, 75, 79, 81, 82, 83,
                84, 85, 87, 88, 89, 90, 92, 94);
        }

        private static void TestOneSnapshotAcrossBatches()
        {
            double oldX = GraphGround3DSettingsAdapter.BinX;
            double oldY = GraphGround3DSettingsAdapter.BinY;
            double oldZ = GraphGround3DSettingsAdapter.BinZ;
            int oldMin = GraphGround3DSettingsAdapter.MinPts;
            try
            {
                GraphGround3DSettingsAdapter.BinX = 1.0;
                GraphGround3DSettingsAdapter.BinY = 1.0;
                GraphGround3DSettingsAdapter.BinZ = 1.0;
                GraphGround3DSettingsAdapter.MinPts = 1;
                GraphGround3DOptions options = GraphGround3DSettingsAdapter.Capture();
                Check(options.BinX == 1 && options.BinY == 1 &&
                    options.BinZ == 1 && options.MinPts == 1,
                    "Operation snapshot did not capture all four scalars.");

                CheckIds(GraphGround3DFilter.Apply(HandPoints(), options, null),
                    0, 1, 3, 4, 6);

                // Simulate another command changing process-wide defaults before
                // the next flush in this operation.
                GraphGround3DSettingsAdapter.BinX = 2.0;
                GraphGround3DSettingsAdapter.BinY = 3.0;
                GraphGround3DSettingsAdapter.BinZ = 2.0;
                GraphGround3DSettingsAdapter.MinPts = int.MaxValue;

                List<Vector4D> secondBatch = HandPoints();
                for (int i = 0; i < secondBatch.Count; i++)
                {
                    Vector4D point = secondBatch[i];
                    point.W += 100;
                    secondBatch[i] = point;
                }
                CheckIds(GraphGround3DFilter.Apply(secondBatch, options, null),
                    100, 101, 103, 104, 106);
                Check(GraphGround3DFilter.Apply(secondBatch,
                    GraphGround3DSettingsAdapter.Capture(), null).Count == 0,
                    "Test did not change the newly captured defaults.");
            }
            finally
            {
                GraphGround3DSettingsAdapter.BinX = oldX;
                GraphGround3DSettingsAdapter.BinY = oldY;
                GraphGround3DSettingsAdapter.BinZ = oldZ;
                GraphGround3DSettingsAdapter.MinPts = oldMin;
            }
        }

        private static void CheckSame(List<Vector4D> actual, List<Vector4D> expected,
            string label)
        {
            Check(actual.Count == expected.Count, label + " count changed");
            for (int i = 0; i < expected.Count; i++)
                Check(actual[i].X == expected[i].X && actual[i].Y == expected[i].Y &&
                    actual[i].Z == expected[i].Z && actual[i].W == expected[i].W,
                    label + " tuple or order changed at " + i);
        }

        private static List<Vector4D> DemotionPoints()
        {
            return new List<Vector4D> {
                new Vector4D(0, 0, 0, 200), new Vector4D(0, 0, 4, 201),
                new Vector4D(1, 0, 4, 202), new Vector4D(2, 0, 4, 203),
                new Vector4D(3, 0, 4, 204), new Vector4D(4, 0, 0, 205),
                new Vector4D(4, 0, 4, 206),
                new Vector4D(10, 0, 0, 210), new Vector4D(10, 0, 4, 211),
                new Vector4D(10, 1, 4, 212), new Vector4D(10, 2, 4, 213),
                new Vector4D(10, 3, 4, 214), new Vector4D(10, 4, 0, 215),
                new Vector4D(10, 4, 4, 216)
            };
        }

        private static List<Vector4D> ThinPoints()
        {
            return new List<Vector4D> {
                new Vector4D(0, 0, 0, 300),
                new Vector4D(1, 0, 0, 301),
                new Vector4D(0, 1, 0, 302),
                new Vector4D(1, 1, 0, 303)
            };
        }

        private static void TestInjectedSchedulers()
        {
            GraphGround3DOptions options = new GraphGround3DOptions(1, 1, 1, 1);
            Action<int, Action<int>> reverse = delegate(int count, Action<int> body)
            {
                for (int i = count - 1; i >= 0; i--) body(i);
            };
            Action<int, Action<int>> parallel = delegate(int count, Action<int> body)
            {
                if (!ParallelWorkRunner.Run(count, 2,
                    delegate(int i, WorkCancellation stop) { body(i); },
                    null, null)) throw new Exception("parallel scheduler did not finish");
            };
            List<Vector4D>[] fixtures = {
                HandPoints(), SeededPoints(), DemotionPoints(), ThinPoints()
            };
            int schedulerDepth = 0;
            int phaseCalls = 0;
            int[] phaseLines = new int[3];
            Action<int, Action<int>> nonNested = delegate(int count, Action<int> body)
            {
                schedulerDepth++;
                phaseLines[phaseCalls] = count;
                phaseCalls++;
                Check(schedulerDepth == 1, "3D filter nested a parallel phase");
                try
                {
                    for (int j = 0; j < count; j++) body(j);
                }
                finally { schedulerDepth--; }
            };
            for (int i = 0; i < fixtures.Length; i++)
            {
                List<Vector4D> expected = GraphGround3DFilter.Apply(fixtures[i], options, null);
                CheckSame(GraphGround3DFilter.Apply(fixtures[i], options, null, reverse),
                    expected, "reverse fixture " + i);
                CheckSame(GraphGround3DFilter.Apply(fixtures[i], options, null, parallel),
                    expected, "parallel fixture " + i);
                phaseCalls = 0;
                CheckSame(GraphGround3DFilter.Apply(fixtures[i], options, null, nonNested),
                    expected, "non-nested fixture " + i);
                Check(phaseCalls == 3, "3D filter changed its three phase barriers");
                Check(phaseLines[1] > 1 && phaseLines[2] > 1,
                    "3D demotion did not distribute independent lines");
                CheckSame(GraphGround3DFilter.Apply(fixtures[i], options, null,
                    TopomaticIndexScheduler.ForEach), expected, "production scheduler fixture " + i);
            }
            CheckIds(GraphGround3DFilter.Apply(DemotionPoints(), options, null),
                200, 205, 210, 215);
        }

        private static void TestSchedulerFailure()
        {
            Exception workerFailure = new ApplicationException("injected worker failure");
            bool forwarded = false;
            try
            {
                TopomaticIndexScheduler.ForEach(4,
                    delegate(int index) { if (index == 2) throw workerFailure; });
            }
            catch (Exception error)
            {
                forwarded = Object.ReferenceEquals(error, workerFailure) ||
                    Object.ReferenceEquals(error.InnerException, workerFailure);
            }
            Check(forwarded, "production scheduler lost a worker exception");
        }

        private static void TestGridLimitsAndCancellation()
        {
            GraphGround3DOptions options = new GraphGround3DOptions(1, 1, 1, 1);
            List<Vector4D> distant = new List<Vector4D> {
                new Vector4D(0, 0, 0, 1),
                new Vector4D(1000000, 1000000, 1000000, 2)
            };
            bool rejected = false;
            try { GraphGround3DFilter.Apply(distant, options, null); }
            catch (InvalidOperationException) { rejected = true; }
            Check(rejected, "Overflowing 3D grid was not rejected before allocation.");

            distant[1] = new Vector4D(4000, 4000, 0, 2);
            rejected = false;
            try { GraphGround3DFilter.Apply(distant, options, null); }
            catch (InvalidOperationException) { rejected = true; }
            Check(rejected, "Oversized 3D grid exceeded the memory budget.");

            distant[1] = new Vector4D(Double.NaN, 0, 0, 2);
            rejected = false;
            try { GraphGround3DFilter.Apply(distant, options, null); }
            catch (InvalidOperationException) { rejected = true; }
            Check(rejected, "Non-finite LiDAR coordinate was not rejected.");

            bool cancelled = true;
            bool schedulerCalled = false;
            Action<int, Action<int>> scheduler = delegate(int count, Action<int> body)
            {
                schedulerCalled = true;
                for (int i = 0; i < count; i++) body(i);
            };
            try
            {
                GraphGround3DFilter.Apply(HandPoints(), options, null, scheduler,
                    delegate { return cancelled; });
                throw new Exception("Already-cancelled 3D filter continued.");
            }
            catch (OperationCanceledException) { }
            Check(!schedulerCalled, "Cancelled filter entered a parallel phase.");

            cancelled = false;
            try
            {
                GraphGround3DFilter.Apply(HandPoints(), options,
                    delegate(float value) { if (value == 0.3f) cancelled = true; },
                    scheduler, delegate { return cancelled; });
                throw new Exception("3D filter ignored cancellation between phases.");
            }
            catch (OperationCanceledException) { }
            Check(!schedulerCalled, "Filter entered a parallel phase after cancellation.");
        }

        public static int Main()
        {
            TestHandMembership();
            TestSparseCellThreshold();
            TestSeededBaseline();
            TestOneSnapshotAcrossBatches();
            TestInjectedSchedulers();
            TestSchedulerFailure();
            TestGridLimitsAndCancellation();
            Console.WriteLine("GraphGround3D baseline: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
