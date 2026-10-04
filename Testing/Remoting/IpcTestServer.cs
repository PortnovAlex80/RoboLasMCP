// Testing/Remoting/IpcTestServer.cs
// Starts/stops IPC remoting channel inside Topomatic process
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.View;

namespace LAS_TERRAIN.Testing.Remoting
{
    /// <summary>
    /// Manages the IPC remoting server lifecycle.
    /// Started only by an explicitly enabled diagnostic build.
    /// </summary>
    internal static class IpcTestServer
    {
        private static IpcChannel _channel;
        private static bool _started;

        public static bool IsRunning
        {
            get { return _started && _channel != null; }
        }

        public static string ServiceUrl
        {
            get { return "ipc://" + LasTerrainTestService.ChannelName + "/" + LasTerrainTestService.ServiceUri; }
        }

        internal static CadView CadView
        {
            // Call only inside DiagnosticUiDispatcher's main-form callback.
            // ActiveDocument belongs to the Topomatic UI thread.
            get { return TryGetActiveCadView(); }
        }

        /// <summary>
        /// Get CadView programmatically without user interaction.
        /// Chain: ApplicationHost.Current -> ActiveDocument -> ICadViewForm.CadView
        /// </summary>
        private static CadView TryGetActiveCadView()
        {
            try
            {
                IApplicationHost host = ApplicationHost.Current;
                if (host == null) return null;

                IDocumentWindow doc = host.ActiveDocument;
                if (doc == null) return null;

                ICadViewForm form = doc as ICadViewForm;
                if (form == null) return null;

                return form.CadView;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Start IPC server. Safe to call multiple times.
        /// </summary>
        public static void Start()
        {
            if (_started)
                return;

            try
            {
                _channel = new IpcChannel(LasTerrainTestService.ChannelName);
                ChannelServices.RegisterChannel(_channel, false);

                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(LasTerrainTestService),
                    LasTerrainTestService.ServiceUri,
                    WellKnownObjectMode.Singleton);

                AppDomain.CurrentDomain.DomainUnload += OnDomainEnd;
                AppDomain.CurrentDomain.ProcessExit += OnDomainEnd;
                _started = true;
            }
            catch (Exception ex)
            {
                if (_channel != null)
                {
                    try { ChannelServices.UnregisterChannel(_channel); }
                    catch { /* Preserve the original startup failure. */ }
                }
                _started = false;
                _channel = null;
                System.Diagnostics.Debug.WriteLine(
                    string.Format("[LasTerrainTestIPC] Failed to start: {0}", ex.Message));
            }
        }

        /// <summary>
        /// Stop IPC server. Called on plugin unload.
        /// </summary>
        public static void Stop()
        {
            if (!_started)
                return;

            try
            {
                if (_channel != null)
                {
                    ChannelServices.UnregisterChannel(_channel);
                    _channel = null;
                }
            }
            catch
            {
                // Best effort
            }
            finally
            {
                AppDomain.CurrentDomain.DomainUnload -= OnDomainEnd;
                AppDomain.CurrentDomain.ProcessExit -= OnDomainEnd;
                _started = false;
            }
        }

        private static void OnDomainEnd(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
