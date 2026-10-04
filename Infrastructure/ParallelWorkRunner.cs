using System;
using System.Threading;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>Cooperative cancellation without a dependency on .NET 4 or a UI SDK.</summary>
    internal sealed class WorkCancellation
    {
        private volatile bool requested;
        private readonly Func<bool> pollOnCaller;

        internal WorkCancellation(Func<bool> pollOnCaller)
        {
            this.pollOnCaller = pollOnCaller;
        }

        public bool IsCancellationRequested
        {
            get
            {
                if (!requested && pollOnCaller != null && pollOnCaller())
                    requested = true;
                return requested;
            }
        }

        internal void Cancel()
        {
            requested = true;
        }
    }

    /// <summary>
    /// Bounded .NET 3.5 workers. Each index has one owner. UI callbacks run only
    /// on the caller; all started threads are joined, including on failure.
    /// The body must poll cancellation during long jobs and must not mutate SDK objects.
    /// </summary>
    internal static class ParallelWorkRunner
    {
        private const int WorkerLimit = 8;

        public static bool Run(int count, bool parallel,
            Action<int, WorkCancellation> body, Func<bool> cancellationPending,
            Action<float> progress)
        {
            int workers = parallel
                ? Math.Min(WorkerLimit, Math.Max(1, Environment.ProcessorCount - 1))
                : 1;
            return Run(count, workers, body, cancellationPending, progress);
        }

        internal static bool Run(int count, int maxWorkers,
            Action<int, WorkCancellation> body, Func<bool> cancellationPending,
            Action<float> progress)
        {
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            if (maxWorkers < 1) throw new ArgumentOutOfRangeException("maxWorkers");
            if (body == null) throw new ArgumentNullException("body");
            if (cancellationPending != null && cancellationPending()) return false;
            if (progress != null) progress(count == 0 ? 1.0f : 0.0f);
            if (count == 0) return true;

            int workerCount = Math.Min(count, Math.Min(maxWorkers, WorkerLimit));
            if (workerCount == 1)
            {
                WorkCancellation serial = new WorkCancellation(cancellationPending);
                for (int i = 0; i < count; i++)
                {
                    if (serial.IsCancellationRequested) return false;
                    body(i, serial);
                    if (serial.IsCancellationRequested) return false;
                    if (progress != null) progress((i + 1) / (float)count);
                }
                return !serial.IsCancellationRequested;
            }

            // Workers never invoke cancellationPending (it may read a UI object).
            WorkCancellation stop = new WorkCancellation(null);
            int next = -1;
            int completed = 0;
            int reported = 0;
            Exception firstError = null;
            object errorLock = new object();
            Thread[] threads = new Thread[workerCount];
            int started = 0;

            ThreadStart work = delegate
            {
                try
                {
                    while (!stop.IsCancellationRequested)
                    {
                        int index = Interlocked.Increment(ref next);
                        if (index >= count) break;
                        if (stop.IsCancellationRequested) break;
                        body(index, stop);
                        if (!stop.IsCancellationRequested)
                            Interlocked.Increment(ref completed);
                    }
                }
                catch (Exception error)
                {
                    lock (errorLock)
                    {
                        if (firstError == null) firstError = error;
                    }
                    stop.Cancel();
                }
            };

            try
            {
                for (int i = 0; i < workerCount; i++)
                {
                    threads[i] = new Thread(work);
                    threads[i].IsBackground = true;
                    threads[i].Start();
                    started++;
                }

                for (int i = 0; i < started; i++)
                {
                    while (!threads[i].Join(25))
                    {
                        if (cancellationPending != null && cancellationPending())
                            stop.Cancel();
                        int current = Interlocked.CompareExchange(ref completed, 0, 0);
                        if (current > reported && current < count && !stop.IsCancellationRequested)
                        {
                            reported = current;
                            if (progress != null) progress(current / (float)count);
                        }
                    }
                }
                if (cancellationPending != null && cancellationPending()) stop.Cancel();
            }
            catch
            {
                // Also covers Thread.Start and caller-side progress callback failures.
                stop.Cancel();
                throw;
            }
            finally
            {
                for (int i = 0; i < started; i++) threads[i].Join();
            }

            if (firstError != null)
            {
                // ExceptionDispatchInfo/AggregateException are not available in .NET 3.5.
                // Preserve the original worker exception and its stack as InnerException.
                if (firstError is OutOfMemoryException)
                    throw new OutOfMemoryException("Point processing ran out of memory.", firstError);
                throw new InvalidOperationException("Parallel point processing failed.", firstError);
            }
            if (stop.IsCancellationRequested) return false;
            if (progress != null) progress(1.0f);
            return cancellationPending == null || !cancellationPending();
        }
    }
}
