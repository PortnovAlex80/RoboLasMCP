using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Infrastructure
{
    internal static class FilterSettingsSnapshotAdapter
    {
        internal static FilterOperationSnapshot Capture()
        {
            return RuntimeConfig.CaptureFilterSnapshot();
        }
    }
}
