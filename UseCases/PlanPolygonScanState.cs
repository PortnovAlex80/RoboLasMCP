using System;
using System.Threading;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    // One instance belongs to one progress dialog. Keep its terminal state after
    // the SDK closes the dialog and may reset CancellationPending.
    internal sealed class PlanPolygonScanState
    {
        private int _cancelled;
        private int _failed;
        private Exception _firstError;
        private readonly object _errorSync = new object();

        internal bool ShouldStop()
        {
            if (WaitProgress.CancellationPending)
                Interlocked.Exchange(ref _cancelled, 1);
            return WorkerShouldStop();
        }

        // Workers must not read the host progress dialog. The caller polls it
        // while joining bounded workers and latches cancellation here.
        internal bool WorkerShouldStop()
        {
            return Thread.VolatileRead(ref _cancelled) != 0 ||
                Thread.VolatileRead(ref _failed) != 0;
        }

        internal void RecordFailure(Exception error)
        {
            lock (_errorSync)
            {
                if (_firstError == null)
                    _firstError = error;
                Interlocked.Exchange(ref _failed, 1);
            }
        }

        internal bool Cancelled
        {
            get { return Thread.VolatileRead(ref _cancelled) != 0; }
        }

        internal void ThrowIfFailed()
        {
            lock (_errorSync)
            {
                if (_firstError != null)
                    throw _firstError;
            }
        }

        internal void Execute(string title, int[] bufferIndexes, Action<int> worker)
        {
            WaitProgress.BeginProgress(title, () =>
            {
                try
                {
                    if (!ShouldStop())
                    {
                        // Keep the callback free to poll the host dialog even when
                        // there is only one buffer or one logical processor.
                        int workItemCount = Math.Max(2, bufferIndexes.Length);
                        int workers = Math.Max(2, Environment.ProcessorCount - 1);
                        ParallelWorkRunner.Run(workItemCount, workers,
                            delegate(int index, WorkCancellation stop)
                        {
                            try
                            {
                                if (index >= bufferIndexes.Length) return;
                                if (WorkerShouldStop()) return;
                                worker(bufferIndexes[index]);
                            }
                            catch (Exception error)
                            {
                                RecordFailure(error);
                                stop.Cancel();
                            }
                        }, ShouldStop, null);
                    }
                }
                catch (Exception error) { RecordFailure(error); }
                try { ShouldStop(); }
                catch (Exception error) { RecordFailure(error); }
            }, true);
            ThrowIfFailed();
        }
    }
}
