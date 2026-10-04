// Mcp/LasMcpPluginHost.cs
// Точка загрузки плагина-адаптера LAS_TERRAIN.MCP. Плагин не имеет своего UI:
// он лишь отвечает на broadcast "tool_request" официального моста robur-mcp
// и регистрирует тулзы RoboLas в общем tools/list.
using System;
using Topomatic.ApplicationPlatform.Plugins;

namespace LAS_TERRAIN.Mcp
{
    [System.Reflection.Obfuscation(Exclude = true, ApplyToMembers = true)]
    public class LasMcpPluginHost : PluginHostInitializator
    {
        protected override Type[] GetTypes()
        {
            return new Type[] { typeof(Module) };
        }
    }
}
