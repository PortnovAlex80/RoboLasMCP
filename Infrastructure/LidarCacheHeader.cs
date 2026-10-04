using System;
using System.IO;

namespace LAS_TERRAIN.Infrastructure
{
    // Diagnostic only: the host SDK owns tree deserialization. Never infer the
    // format from a file extension or interpret an unknown version as LAS.
    internal sealed class LidarCacheHeader
    {
        internal string Status;
        internal int? Version;
        internal string ReadError;

        internal static LidarCacheHeader Inspect(string path)
        {
            var result = new LidarCacheHeader { Status = "unavailable" };
            if (String.IsNullOrEmpty(path)) return result;
            try
            {
                using (var file = new FileStream(path, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite | FileShare.Delete))
                {
                    if (file.ReadByte() != 'L' || file.ReadByte() != 'D' ||
                        file.ReadByte() != 'A' || file.ReadByte() != 'R')
                    {
                        result.Status = "not_ldar_or_truncated";
                        return result;
                    }
                    int version = file.ReadByte();
                    if (version < 0) { result.Status = "truncated_ldar_header"; return result; }
                    result.Version = version;
                    result.Status = version == 1 ? "ldar_v1_rgb_not_serialized" :
                        version == 2 ? "ldar_v2_rgb8_serialized" :
                        "ldar_version_layout_unverified";
                }
            }
            catch (Exception error) { result.ReadError = error.Message; }
            return result;
        }
    }
}
