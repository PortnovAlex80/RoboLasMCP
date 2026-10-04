using System;
using System.Collections.Generic;
using System.Threading;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

internal static class RegressionTests
{
    private static int passed;

    private static void Assert(bool value, string message)
    {
        if (!value) throw new Exception(message);
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
        for (int i = 0; i < xy.Length; i += 2) result.Add(new Vector2D(xy[i], xy[i + 1]));
        return result;
    }

    public static int Main()
    {
        try
        {
            Test("raw XYZ preserves distinct Z", delegate
            {
                HashSet<PointKey3D> keys = new HashSet<PointKey3D>();
                keys.Add(PointKey3D.Exact(1, 2, 3));
                keys.Add(PointKey3D.Exact(1, 2, 4));
                Assert(keys.Count == 2, "Z was lost");
            });
            Test("surface XY has no 32-bit wrap", delegate
            {
                Assert(!PointKey2D.Millimetre(0, 0).Equals(PointKey2D.Millimetre(4294967.296, 0)), "X wrapped");
                Assert(!PointKey2D.Millimetre(0, 0).Equals(PointKey2D.Millimetre(0, -4294967.296)), "Y wrapped");
            });
            Test("surface bins are consistent across zero", delegate
            {
                Assert(!PointKey2D.Millimetre(-0.0001, 0).Equals(PointKey2D.Millimetre(0.0001, 0)), "zero cell merged");
                Assert(PointKey2D.Millimetre(-0.0001, 0).Equals(PointKey2D.Millimetre(-0.0002, 0)), "same cell split");
            });
            Test("raw precision and zero equality", delegate
            {
                Assert(!PointKey3D.Exact(1, 2, 3).Equals(PointKey3D.Exact(1, 2, 3.000000001)), "raw precision lost");
                PointKey3D a = PointKey3D.Exact(0.0, 0, 0), b = PointKey3D.Exact(-0.0, 0, 0);
                Assert(a.Equals(b) && a.GetHashCode() == b.GetHashCode(), "zero equality/hash mismatch");
            });
            Test("invalid keys rejected", delegate
            {
                bool rejected = false;
                try { PointKey3D.Exact(double.NaN, 0, 0); }
                catch (ArgumentException) { rejected = true; }
                Assert(rejected, "NaN accepted");
            });
            Test("closed polyline retains excursion", delegate
            {
                List<Vector2D> result = SplitAndMergeAlgorithm.Apply(Points(0, 0, 1, 1, 0, 0), 0.01);
                Assert(result.Count == 3, "closed excursion collapsed");
            });
            Test("backtracking uses segment distance", delegate
            {
                Assert(SplitAndMergeAlgorithm.Apply(Points(0, 0, 2, 0, 1, 0), 0.01).Count == 3, "backtracking lost");
            });
            Test("straight line and exact duplicates", delegate
            {
                Assert(SplitAndMergeAlgorithm.Apply(Points(0, 0, 1, 1, 2, 2), 0.01).Count == 2, "line not simplified");
                Assert(SplitAndMergeAlgorithm.Apply(Points(1, 1, 1, 1, 1, 1), 0.01).Count == 1, "duplicates kept");
            });
            Test("large-coordinate translation stability", delegate
            {
                List<Vector2D> local = Points(0, 0, 1, 0.025, 2, 0, 3, 0.05, 4, 0);
                List<Vector2D> shifted = new List<Vector2D>();
                foreach (Vector2D p in local) shifted.Add(new Vector2D(p.X + 1000000000, p.Y + 1000000000));
                List<Vector2D> a = SplitAndMergeAlgorithm.Apply(local, 0.01);
                List<Vector2D> b = SplitAndMergeAlgorithm.Apply(shifted, 0.01);
                Assert(a.Count == b.Count, "translation changed vertices");
                for (int i = 0; i < a.Count; i++) Assert(Math.Abs(a[i].X - (b[i].X - 1000000000)) < 1e-6, "vertex changed");
            });
            Test("invalid tolerance rejected", delegate
            {
                bool rejected = false;
                try { SplitAndMergeAlgorithm.Apply(Points(0, 0, 1, 1), double.NaN); }
                catch (ArgumentOutOfRangeException) { rejected = true; }
                Assert(rejected, "NaN tolerance accepted");
            });
            Test("serial jobs run on caller", delegate
            {
                int owner = Thread.CurrentThread.ManagedThreadId, calls = 0;
                bool done = ParallelWorkRunner.Run(30, false, delegate(int index, WorkCancellation stop)
                {
                    Assert(Thread.CurrentThread.ManagedThreadId == owner, "serial ran on worker"); calls++;
                }, null, null);
                Assert(done && calls == 30, "serial work lost");
            });
            Test("parallel jobs execute exactly once", delegate
            {
                int[] visits = new int[1000];
                Assert(ParallelWorkRunner.Run(visits.Length, 3, delegate(int index, WorkCancellation stop)
                { Interlocked.Increment(ref visits[index]); }, null, null), "parallel did not finish");
                for (int i = 0; i < visits.Length; i++) Assert(visits[i] == 1, "job lost or repeated");
            });
            Test("progress and cancellation callbacks stay on caller", delegate
            {
                int owner = Thread.CurrentThread.ManagedThreadId;
                float previous = -1;
                Assert(ParallelWorkRunner.Run(90, 3, delegate(int i, WorkCancellation stop) { Thread.Sleep(1); },
                    delegate { Assert(Thread.CurrentThread.ManagedThreadId == owner, "cancel callback on worker"); return false; },
                    delegate(float p)
                    {
                        Assert(Thread.CurrentThread.ManagedThreadId == owner, "progress callback on worker");
                        Assert(p >= previous && p >= 0 && p <= 1, "invalid progress"); previous = p;
                    }), "work failed");
                Assert(previous == 1, "progress incomplete");
            });
            Test("worker exception returned with original cause", delegate
            {
                bool caught = false;
                try
                {
                    ParallelWorkRunner.Run(30, 3, delegate(int i, WorkCancellation stop)
                    { throw new ApplicationException("sentinel"); }, null, null);
                }
                catch (InvalidOperationException ex)
                { caught = ex.InnerException is ApplicationException && ex.InnerException.Message == "sentinel"; }
                Assert(caught, "worker cause lost");
            });
            Test("cooperative cancellation joins all workers", delegate
            {
                int entered = 0, active = 0;
                bool done = ParallelWorkRunner.Run(30, 3, delegate(int i, WorkCancellation stop)
                {
                    Interlocked.Increment(ref entered); Interlocked.Increment(ref active);
                    try { while (!stop.IsCancellationRequested) Thread.Sleep(1); }
                    finally { Interlocked.Decrement(ref active); }
                }, delegate { return Interlocked.CompareExchange(ref entered, 0, 0) > 0; }, null);
                Assert(!done && active == 0, "cancel leaked a worker");
            });
            Test("progress callback failure joins workers", delegate
            {
                int active = 0;
                bool caught = false;
                try
                {
                    ParallelWorkRunner.Run(1000, 3, delegate(int i, WorkCancellation stop)
                    {
                        Interlocked.Increment(ref active);
                        try { Thread.Sleep(3); } finally { Interlocked.Decrement(ref active); }
                    }, null, delegate(float p) { if (p > 0) throw new ApplicationException("progress"); });
                }
                catch (ApplicationException) { caught = true; }
                Assert(caught && active == 0, "callback failure leaked a worker");
            });
            Test("empty and pre-cancelled work", delegate
            {
                int calls = 0;
                Assert(ParallelWorkRunner.Run(0, 3, delegate(int i, WorkCancellation stop) { calls++; }, null, null), "empty failed");
                Assert(!ParallelWorkRunner.Run(20, 3, delegate(int i, WorkCancellation stop) { calls++; }, delegate { return true; }, null), "pre-cancel ignored");
                Assert(calls == 0, "unexpected work");
            });
            Console.WriteLine("PASS: " + passed + " regression groups.");
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
    }
}
