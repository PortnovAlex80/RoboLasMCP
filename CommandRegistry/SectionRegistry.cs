using System;
using System.Collections.Generic;
using System.Reflection;

namespace LAS_TERRAIN
{
    internal static class SectionRegistry
    {
        private static readonly Dictionary<string, ISectionUseCase> _map;

        static SectionRegistry()
        {
            _map = new Dictionary<string, ISectionUseCase>();

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsAbstract) continue;
                if (!typeof(ISectionUseCase).IsAssignableFrom(type)) continue;

                object[] attrs = type.GetCustomAttributes(typeof(SectionCmdAttribute), false);
                if (attrs.Length == 0) continue;

                var attr = (SectionCmdAttribute)attrs[0];
                var instance = (ISectionUseCase)Activator.CreateInstance(type);

                _map[attr.Name] = instance;
            }
        }

        public static ISectionUseCase Resolve(string name)
        {
            ISectionUseCase useCase;
            return _map.TryGetValue(name, out useCase) ? useCase : null;
        }
    }
}
