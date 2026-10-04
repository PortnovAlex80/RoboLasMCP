using System;

namespace LAS_TERRAIN
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed class SectionCmdAttribute : Attribute
    {
        public string Name { get; }
        public SectionCmdAttribute(string name) => Name = name;
    }

}
