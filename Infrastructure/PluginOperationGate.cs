using System;
using System.Threading;

namespace LAS_TERRAIN.Infrastructure
{
    // A process-local guard for plugin operations that borrow Topomatic model data.
    // Waiting here could deadlock a modal CAD command or an IPC call to CadView.Invoke.
    internal static class PluginOperationGate
    {
        private static int _busy;

        internal static Lease TryEnter()
        {
            if (Interlocked.CompareExchange(ref _busy, 1, 0) != 0)
                return null;
            try { return new Lease(); }
            catch
            {
                Interlocked.Exchange(ref _busy, 0);
                throw;
            }
        }

        internal sealed class Lease : IDisposable
        {
            private int _disposed;

            internal Lease() { }

            public void Dispose()
            {
                if (Interlocked.Exchange(ref _disposed, 1) == 0)
                    Interlocked.Exchange(ref _busy, 0);
            }
        }
    }
}
