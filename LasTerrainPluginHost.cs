using LAS_TERRAIN.Configuration;
#if DIAGNOSTIC
using LAS_TERRAIN.Testing.Remoting;
#endif
using System;
using Topomatic.ApplicationPlatform.Plugins;

namespace LAS_TERRAIN
{
    public class LasTerrainPluginHost : Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator
    {
        //тут мы возвращаем типы всех модулей, которые хотим подключить, в нашем примере только один тип
        protected override Type[] GetTypes()
        {
            return new Type[] { typeof(Module) };
        }

        //этот метод будет вызван в момент старта программного комплекса
        //при первой инициализации вашего модуля
        //после этого модуль будет закэширован
        public override void Initialize(PluginFactory factory)
        {
            base.Initialize(factory);
            Settings.Instance.PushToRuntimeConfig();

#if DIAGNOSTIC
            // Diagnostic builds explicitly expose the test endpoint.
            IpcTestServer.Start();
#endif
        }
    }
}
