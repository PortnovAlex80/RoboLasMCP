using System;
using LAS_TERRAIN.Infrastructure;
using Topomatic.ApplicationPlatform;

namespace LAS_TERRAIN.Testing.Remoting
{
    // Diagnostic IPC arrives on a Remoting thread. Keep SDK model access inside
    // the main form's synchronous UI dispatch and serialize it with commands.
    internal static class DiagnosticUiDispatcher
    {
        internal static T Invoke<T>(Func<T> work, T busy, T unavailable)
        {
            if (work == null) throw new ArgumentNullException("work");
            using (PluginOperationGate.Lease operation = PluginOperationGate.TryEnter())
            {
                if (operation == null) return busy;

                bool started = false;
                try
                {
                    IApplicationHost host = ApplicationHost.Current;
                    IMainForm form = host == null ? null : host.MainForm;
                    if (form == null) return unavailable;
                    if (!form.IsHandleCreated) return unavailable;
                    Func<T> dispatched = delegate
                    {
                        started = true;
                        return work();
                    };
                    return form.InvokeRequired ? (T)form.Invoke(dispatched) : dispatched();
                }
                catch (ObjectDisposedException)
                {
                    if (!started) return unavailable;
                    throw;
                }
                catch (InvalidOperationException)
                {
                    if (!started) return unavailable;
                    throw;
                }
            }
        }
    }
}
