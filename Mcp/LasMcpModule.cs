// Mcp/LasMcpModule.cs
// Broadcast-обработчик robur-mcp: при инициализации моста платформа рассылает
// "tool_request" всем плагинам; добавляем провайдеров тулзов RoboLas в общий
// список. Требует установленный robur-mcp (Topomatic.ToolBridge.dll) и его
// автоматически запускается после открытия проекта через штатную команду mcp_run.
using System;
using System.Collections.Generic;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.ToolBridge;

namespace LAS_TERRAIN.Mcp
{
    [System.Reflection.Obfuscation(Exclude = true, ApplyToMembers = true)]
    internal sealed class Module : PluginInitializator
    {
        private bool _startupScheduled;
        private bool _starting;
        private int _readinessAttempts;

        [cmd("las_mcp_autostart")]
        private void StartMcpAfterProjectOpened()
        {
            if (_startupScheduled || _starting) return;
            var host = ApplicationHost.Current;
            if (host == null) return;
            _startupScheduled = true;
            _readinessAttempts = 0;
            try
            {
                // Return from the project-open broadcast before loading the native bridge.
                // Its tool_request broadcast must see fully registered plugin commands.
                host.InvokeDelayed(100, TryStartNativeMcp, false, true);
            }
            catch (Exception error)
            {
                _startupScheduled = false;
                LogStartupError(error);
            }
        }

        private void TryStartNativeMcp()
        {
            if (!_startupScheduled || _starting) return;
            var host = ApplicationHost.Current;
            if (host == null)
            {
                _startupScheduled = false;
                return;
            }
            try
            {
                if (host.MainForm == null || !host.MainForm.IsHandleCreated || !host.ReadyForAsyncWork)
                {
                    if (++_readinessAttempts < 120)
                    {
                        host.InvokeDelayed(250, TryStartNativeMcp, false, true);
                        return;
                    }
                    _startupScheduled = false;
                    LogStartupError(new InvalidOperationException("Robur is not ready for MCP startup. Run las_start_mcp when the project finishes opening."));
                    return;
                }
                _startupScheduled = false;
                _starting = true;
                // Preserve native providers, transport and process lifetime management.
                // No watchdog: a manually stopped server stays stopped until the next project opens.
                host.Plugins.Execute("mcp_run");
            }
            catch (Exception error)
            {
                _startupScheduled = false;
                LogStartupError(error);
            }
            finally
            {
                _starting = false;
            }
        }

        private static void LogStartupError(Exception error)
        {
            try
            {
                var host = ApplicationHost.Current;
                if (host != null && host.Log != null)
                    host.Log.WriteLine("RoboLas MCP startup: " + error.Message);
            }
            catch (Exception)
            {
                // MCP startup must never interrupt opening the user's project.
            }
        }

        [cmd("las_generate_tools")]
        private void GenerateTools(object[] args)
        {
            if (args == null || args.Length == 0) return;
            List<ToolProvider> providers = args[0] as List<ToolProvider>;
            if (providers == null) return;
            providers.AddRange(new ToolProvider[]
            {
                new LasContextTools(),
                new LasSettingsTools(),
                new LasTerrainTools(),
                new LasExportTools(),
                new LasPolygonTools(),
                new LasHarnessTools(),
                new LasSectionVisualTools()
            });
        }
    }
}
