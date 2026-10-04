using System;
using System.IO;

namespace LAS_TERRAIN.Application
{
    /// <summary>Immutable output paths captured before an export starts.</summary>
    public sealed class ExportRequest
    {
        public readonly string PrimaryPath;
        public readonly string EdgePath;

        public ExportRequest(string primaryPath)
        {
            if (String.IsNullOrEmpty(primaryPath))
                throw new ArgumentException("LAS output path is required.", "primaryPath");
            PrimaryPath = Path.GetFullPath(primaryPath);
            EdgePath = Path.Combine(Path.GetDirectoryName(PrimaryPath),
                Path.GetFileNameWithoutExtension(PrimaryPath) + "_edge" + Path.GetExtension(PrimaryPath));
        }
    }
}
