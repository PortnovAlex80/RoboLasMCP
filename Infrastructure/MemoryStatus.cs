using System;
using System.Runtime.InteropServices;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// P/Invoke wrapper for GlobalMemoryStatusEx — available physical memory.
    /// Works on .NET 3.5 x86/x64.
    /// </summary>
    internal static class MemoryStatus
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public uint ullTotalPhysLow;
            public uint ullTotalPhysHigh;
            public uint ullAvailPhysLow;
            public uint ullAvailPhysHigh;
            public uint ullTotalPageFileLow;
            public uint ullTotalPageFileHigh;
            public uint ullAvailPageFileLow;
            public uint ullAvailPageFileHigh;
            public uint ullTotalVirtualLow;
            public uint ullTotalVirtualHigh;
            public uint ullAvailVirtualLow;
            public uint ullAvailVirtualHigh;
            public uint ullAvailExtendedVirtualLow;
            public uint ullAvailExtendedVirtualHigh;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

        /// <summary>
        /// Available physical memory in bytes. Returns 0 on failure.
        /// </summary>
        public static long AvailablePhysicalBytes()
        {
            var mem = new MEMORYSTATUSEX();
            mem.dwLength = (uint)Marshal.SizeOf(mem);
            if (!GlobalMemoryStatusEx(ref mem))
                return 0L;

            long availLow = mem.ullAvailPhysLow;
            long availHigh = mem.ullAvailPhysHigh;
            return (availHigh << 32) | (availLow & 0xFFFFFFFFL);
        }

        /// <summary>
        /// Calculate batch point count for ground+reduce pipeline.
        /// Each point needs ~100 bytes (raw list + 3D grid + reduced list).
        /// Uses 80% of available physical memory, clamped to [10000, 300000].
        /// </summary>
        public static int CalcBatchSizeForGroundReduce()
        {
            long avail = AvailablePhysicalBytes();
            if (avail <= 0)
                return 100000; // fallback

            long usable = avail * 4 / 5; // 80%
            int batchSize = (int)(usable / 100); // ~100 bytes per point

            if (batchSize < 10000)
                batchSize = 10000;
            if (batchSize > 300000)
                batchSize = 300000;

            return batchSize;
        }

        /// <summary>
        /// Calculate batch point count for reduce-only pipeline.
        /// Each point needs ~64 bytes (raw list + reduced list).
        /// Uses 80% of available physical memory, clamped to [10000, 500000].
        /// </summary>
        public static int CalcBatchSizeForReduceOnly()
        {
            long avail = AvailablePhysicalBytes();
            if (avail <= 0)
                return 100000; // fallback

            long usable = avail * 4 / 5; // 80%
            int batchSize = (int)(usable / 64); // ~64 bytes per point

            if (batchSize < 10000)
                batchSize = 10000;
            if (batchSize > 500000)
                batchSize = 500000;

            return batchSize;
        }
    }
}
