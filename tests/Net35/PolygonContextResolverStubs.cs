using System;

namespace Topomatic.FoundationClasses
{
    public sealed class URI
    {
        private readonly Uri _value;
        public URI(string text) { _value = new Uri(text, UriKind.RelativeOrAbsolute); }
        public bool IsAbsoluteUri { get { return _value.IsAbsoluteUri; } }
        public string AsAbsoluteUri { get { return _value.AbsoluteUri; } }
        public string AsFilePath { get { return _value.LocalPath; } }
    }
}

namespace Topomatic.ApplicationPlatform
{
    public sealed class Project
    {
        public string Alias;
        public Topomatic.FoundationClasses.URI TargetProjectUri;
    }
    public sealed class ApplicationHost
    {
        public static ApplicationHost Current;
        public Project ActiveProject;
    }
}

namespace Topomatic.Alg
{
    public sealed class Alignment
    {
        public Guid Id;
        public Topomatic.ApplicationPlatform.Plugins.FakeModel Model;
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Alignment value) { return value.Id; }
    }
}

namespace Topomatic.ApplicationPlatform.Plugins
{
    public sealed class FakeModel
    {
        public Topomatic.ApplicationPlatform.Project Project;
        public object Uri;
    }
    public static class PluginCoreOps
    {
        public static FakeModel FindModel(Topomatic.Alg.Alignment alignment)
        { return alignment.Model; }
    }
}
