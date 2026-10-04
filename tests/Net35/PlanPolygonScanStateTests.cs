using System;
using System.Threading;
using LAS_TERRAIN.UseCases;

namespace Topomatic.Controls.Dialogs { }

namespace Topomatic.Controls
{
    internal static class WaitProgress
    {
        private static int _pending;
        internal static int OwnerThread;
        internal static int Reads;

        internal static bool CancellationPending
        {
            get
            {
                if (Thread.CurrentThread.ManagedThreadId != OwnerThread)
                    throw new InvalidOperationException("host progress read from worker");
                Interlocked.Increment(ref Reads);
                return Thread.VolatileRead(ref _pending) != 0;
            }
            set { Interlocked.Exchange(ref _pending, value ? 1 : 0); }
        }

        internal static void BeginProgress(string title, Action work, bool cancellable)
        {
            try
            {
                work();
            }
            finally { CancellationPending = false; }
        }
    }
}

namespace LAS_TERRAIN.Tests
{
    internal static class PlanPolygonScanStateTests
    {
        private static int _checks;

        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        private static void Reset()
        {
            Topomatic.Controls.WaitProgress.OwnerThread =
                Thread.CurrentThread.ManagedThreadId;
            Topomatic.Controls.WaitProgress.CancellationPending = false;
            Topomatic.Controls.WaitProgress.Reads = 0;
        }

        private static void PreCancelled()
        {
            Reset();
            Topomatic.Controls.WaitProgress.CancellationPending = true;
            PlanPolygonScanState state = new PlanPolygonScanState();
            int visited = 0;
            state.Execute("count", new[] { 0, 1 }, delegate(int i) { visited++; });
            Check(visited == 0, "pre-cancelled work skipped");
            Check(state.Cancelled, "pre-cancellation survived dialog reset");
            state.Execute("collect", new[] { 0 }, delegate(int i) { visited++; });
            Check(visited == 0, "later stage skipped");
        }

        private static void WorkerReadsOnlyLatchedState()
        {
            Reset();
            PlanPolygonScanState state = new PlanPolygonScanState();
            Topomatic.Controls.WaitProgress.CancellationPending = true;
            Check(!state.WorkerShouldStop(), "worker read host cancellation");
            Check(Topomatic.Controls.WaitProgress.Reads == 0, "host was read");
            Check(state.ShouldStop(), "caller failed to latch cancellation");
            Check(state.WorkerShouldStop(), "worker did not see cancellation");
        }

        private static void SingleBufferCancelsDuringScan()
        {
            Reset();
            PlanPolygonScanState state = new PlanPolygonScanState();
            ManualResetEvent started = new ManualResetEvent(false);
            Thread signal = new Thread(delegate()
            {
                if (started.WaitOne(5000))
                    Topomatic.Controls.WaitProgress.CancellationPending = true;
            });
            signal.IsBackground = true;
            signal.Start();
            int visited = 0;
            try
            {
                state.Execute("single buffer", new[] { 7 }, delegate(int i)
                {
                    Check(i == 7, "buffer index changed");
                    Interlocked.Increment(ref visited);
                    started.Set();
                    DateTime deadline = DateTime.UtcNow.AddSeconds(5);
                    while (!state.WorkerShouldStop() && DateTime.UtcNow < deadline)
                        Thread.Sleep(1);
                    Check(state.WorkerShouldStop(), "caller did not poll while worker ran");
                });
            }
            finally
            {
                started.Set();
                signal.Join();
                started.Close();
            }
            Check(visited == 1, "one buffer visited once");
            Check(state.Cancelled, "mid-scan cancellation latched");
            Check(Topomatic.Controls.WaitProgress.Reads > 1,
                "host progress was not polled by caller");
        }

        private static void CancellationAtCallbackEnd()
        {
            Reset();
            PlanPolygonScanState state = new PlanPolygonScanState();
            state.Execute("count", new[] { 0 }, delegate(int i)
            { Topomatic.Controls.WaitProgress.CancellationPending = true; });
            Check(state.Cancelled, "end-of-callback cancellation latched");
            Check(!Topomatic.Controls.WaitProgress.CancellationPending,
                "host flag reset after dialog");
        }

        private static void FailureJoinsWorkers()
        {
            Reset();
            PlanPolygonScanState state = new PlanPolygonScanState();
            InvalidOperationException expected = new InvalidOperationException("indexer");
            int active = 0;
            Exception observed = null;
            try
            {
                state.Execute("failure", new[] { 0, 1, 2, 3 }, delegate(int i)
                {
                    Interlocked.Increment(ref active);
                    try
                    {
                        if (i == 0) throw expected;
                        Thread.Sleep(20);
                    }
                    finally { Interlocked.Decrement(ref active); }
                });
            }
            catch (Exception error) { observed = error; }
            Check(Object.ReferenceEquals(expected, observed),
                "original worker failure returned");
            Check(active == 0, "workers joined before error returned");
            Check(!state.Cancelled, "failure is distinct from cancellation");
        }

        private static void Success()
        {
            Reset();
            PlanPolygonScanState state = new PlanPolygonScanState();
            int[] visits = new int[8];
            state.Execute("count", new[] { 0, 1, 2, 3, 4, 5, 6, 7 },
                delegate(int i) { Interlocked.Increment(ref visits[i]); });
            for (int i = 0; i < visits.Length; i++)
                Check(visits[i] == 1, "buffer lost or duplicated");
            Check(!state.Cancelled, "successful scan cancelled");
        }

        public static int Main()
        {
            PreCancelled();
            WorkerReadsOnlyLatchedState();
            SingleBufferCancelsDuringScan();
            CancellationAtCallbackEnd();
            FailureJoinsWorkers();
            Success();
            Console.WriteLine("Plan polygon scan state: " + _checks + " checks passed.");
            return 0;
        }
    }
}
