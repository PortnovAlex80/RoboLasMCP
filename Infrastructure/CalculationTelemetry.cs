using System;

namespace LAS_TERRAIN.Infrastructure
{
    // A single SDK operation owns the callback. No host objects escape here.
    public static class CalculationTelemetry
    {
        private static readonly object Sync = new object();
        private static Action<string, double> _observer;
        public static IDisposable Observe(Action<string, double> observer)
        {
            lock (Sync)
            {
                if (_observer != null) throw new InvalidOperationException("A calculation observer is already active.");
                _observer = observer;
                return new Subscription(observer);
            }
        }
        public static void Report(string stage, double progress)
        {
            Action<string,double> observer;
            lock (Sync) observer=_observer;
            if (observer != null)
            {
                // Telemetry must never turn a committed calculation into failure.
                try { observer(stage, Math.Max(0,Math.Min(1,progress))); }
                catch (Exception e) { System.Diagnostics.Trace.WriteLine(e.Message); }
            }
        }
        private sealed class Subscription : IDisposable
        {
            private Action<string,double> _owner;
            internal Subscription(Action<string,double> owner) { _owner=owner; }
            public void Dispose() { lock (Sync) { if(_owner!=null && _observer==_owner) _observer=null; _owner=null; } }
        }
    }
}
