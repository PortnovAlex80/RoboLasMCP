// Compile against the production SamplingHelper and the test-only Vector4D shim.
// No application assembly or Topomatic host is needed.
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Helpers;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class SamplingDeterminismTests
    {
        private sealed class ScriptedRandom : Random
        {
            private readonly int[] values;
            private readonly int[] bounds;
            private int next;

            public ScriptedRandom(int[] values, int[] bounds)
            {
                this.values = values;
                this.bounds = bounds;
            }

            public override int Next(int maxValue)
            {
                Check(next < values.Length, "extra random draw");
                Check(maxValue == bounds[next], "wrong reservoir draw bound at " + next);
                return values[next++];
            }

            public void CheckComplete()
            {
                Check(next == values.Length, "missing random draw");
            }
        }

        private static void Check(bool condition, string message)
        {
            if (!condition) throw new Exception(message);
        }

        private static List<Vector4D> Source(int count)
        {
            List<Vector4D> points = new List<Vector4D>();
            for (int i = 0; i < count; i++) points.Add(new Vector4D(i, i + 10, i + 20, i + 30));
            return points;
        }

        private static void MustCancel(Action work, string label)
        {
            bool cancelled = false;
            try { work(); }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled, label);
        }

        public static int Main()
        {
            try
            {
                // Starting reservoir [0,1]: replace slot 0 with 2, skip 3,
                // replace slot 1 with 4, skip 5. The slot order is part of the
                // current algorithm and must not be sorted after sampling.
                ScriptedRandom draws = new ScriptedRandom(
                    new int[] { 0, 2, 1, 4 }, new int[] { 3, 4, 5, 6 });
                List<float> progress = new List<float>();
                List<Vector4D> exact = SamplingHelper.ReservoirSampleWithProgress(
                    Source(6), 2, delegate(float value) { progress.Add(value); }, draws);
                draws.CheckComplete();
                Check(exact.Count == 2 && exact[0].X == 2 && exact[1].X == 4,
                    "scripted membership or reservoir slot order changed");
                Check(progress.Count == 4 && progress[0] == 3f / 6f &&
                    progress[1] == 4f / 6f && progress[2] == 5f / 6f && progress[3] == 1f,
                    "progress sequence changed");
                ScriptedRandom observedDraws = new ScriptedRandom(
                    new int[] { 0, 2, 1, 4 }, new int[] { 3, 4, 5, 6 });
                List<Vector4D> observed = SamplingHelper.ReservoirSampleWithProgress(
                    Source(6), 2, null, observedDraws, delegate { return false; });
                observedDraws.CheckComplete();
                Check(observed.Count == 2 && observed[0].X == 2 &&
                    observed[1].X == 4,
                    "cancellation-aware path changed the normal random sequence");
                Console.WriteLine("PASS scripted exact membership, draw bounds, slot order and progress");

                bool stop = false;
                MustCancel(delegate
                {
                    SamplingHelper.ReservoirSampleWithProgress(Source(6), 2,
                        delegate(float value) { if (value >= 0.5f) stop = true; },
                        new Random(12345), delegate { return stop; });
                }, "mid-reservoir cancellation returned a partial sample");
                stop = false;
                MustCancel(delegate
                {
                    SamplingHelper.ReservoirSampleWithProgress(Source(6), 2,
                        delegate(float value) { if (value == 1f) stop = true; },
                        new Random(12345), delegate { return stop; });
                }, "final progress cancellation returned a sample");
                stop = false;
                MustCancel(delegate
                {
                    SamplingHelper.ReduceByPercentWithProgress(Source(0), 50,
                        delegate(float value) { stop = true; },
                        delegate { return stop; });
                }, "empty reduction ignored cancellation from progress");
                stop = false;
                MustCancel(delegate
                {
                    SamplingHelper.ReduceByPercentWithProgress(Source(6), 100,
                        delegate(float value) { stop = true; },
                        delegate { return stop; });
                }, "full-copy reduction ignored cancellation from progress");
                stop = false;
                MustCancel(delegate
                {
                    SamplingHelper.ReduceByPercentWithProgress(Source(1), 1,
                        delegate(float value) { stop = true; },
                        delegate { return stop; });
                }, "rounded-zero reduction ignored cancellation from progress");
                Console.WriteLine("PASS cancellation discards reservoir and fast-path results");

                // .NET Framework 3.5 Random(12345) yields replacement draws
                // 0, 0, 3, 3 for i=2..5, giving slots [3,1].
                List<Vector4D> seededSmall = SamplingHelper.ReservoirSampleWithProgress(
                    Source(6), 2, null, new Random(12345));
                Check(seededSmall.Count == 2 && seededSmall[0].X == 3 && seededSmall[1].X == 1,
                    "seeded exact membership changed");
                Console.WriteLine("PASS seeded exact membership on a tiny source");

                List<Vector4D> source = Source(20);
                List<Vector4D> first = SamplingHelper.ReservoirSampleWithProgress(
                    source, 5, null, new Random(12345));
                List<Vector4D> second = SamplingHelper.ReservoirSampleWithProgress(
                    source, 5, null, new Random(12345));
                Check(first.Count == 5 && second.Count == 5, "seeded sample size changed");
                HashSet<double> unique = new HashSet<double>();
                for (int i = 0; i < first.Count; i++)
                {
                    Check(first[i].X == second[i].X && first[i].Y == second[i].Y &&
                          first[i].Z == second[i].Z && first[i].W == second[i].W,
                        "same seed produced a different sample");
                    Check(first[i].X >= 0 && first[i].X < source.Count, "sample contains a foreign point");
                    Check(unique.Add(first[i].X), "sample contains a duplicate point");
                }
                Console.WriteLine("PASS seeded repeatability and membership invariants");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL sampling determinism: " + ex);
                return 1;
            }
        }
    }
}
