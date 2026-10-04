using System;
using System.IO;
using LAS_TERRAIN.Infrastructure;

internal static class LidarCacheHeaderTests
{
    private static int Main()
    {
        string path = Path.GetTempFileName();
        try
        {
            Check(path, new byte[] { 76, 68, 65, 82, 1 }, "ldar_v1_rgb_not_serialized", 1);
            Check(path, new byte[] { 76, 68, 65, 82, 2 }, "ldar_v2_rgb8_serialized", 2);
            Check(path, new byte[] { 76, 68, 65, 82, 3 }, "ldar_version_layout_unverified", 3);
            Check(path, new byte[] { 76, 68, 65, 82, 0 }, "ldar_version_layout_unverified", 0);
            Check(path, new byte[] { 76, 65, 83, 70, 1 }, "not_ldar_or_truncated", null);
            Check(path, new byte[] { 76, 68, 65, 82 }, "truncated_ldar_header", null);
            Check(path, new byte[0], "not_ldar_or_truncated", null);
            File.Delete(path);
            LidarCacheHeader missing = LidarCacheHeader.Inspect(path);
            if (missing.Status != "unavailable" || missing.ReadError == null || missing.Version.HasValue)
                throw new Exception("An unavailable cache must not imply a verified layout.");
            if (LidarCacheHeader.Inspect(null).Version.HasValue)
                throw new Exception("A missing cache path must not imply a version.");
            Console.WriteLine("PASS 9 tree header checks: LDAR v1/v2, unknown layouts, LAS and unavailable caches.");
            return 0;
        }
        finally { if (File.Exists(path)) File.Delete(path); }
    }

    private static void Check(string path, byte[] bytes, string status, int? version)
    {
        File.WriteAllBytes(path, bytes);
        LidarCacheHeader result = LidarCacheHeader.Inspect(path);
        if (result.Status != status || result.Version != version || result.ReadError != null)
            throw new Exception("Incorrect cache diagnostic for " + status);
    }
}
