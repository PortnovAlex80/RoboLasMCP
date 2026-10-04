using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Infrastructure
{
    // Legacy defaults live at the operation boundary. The filter receives only
    // the captured immutable values, including across multiple export batches.
    internal static class GraphGround3DSettingsAdapter
    {
        internal static double BinX = 1.0;
        internal static double BinY = 1.0;
        internal static double BinZ = 1.0;
        internal static int MinPts = 1;

        internal static GraphGround3DOptions Capture()
        {
            lock (LAS_TERRAIN.Configuration.RuntimeConfig.SyncRoot)
                return new GraphGround3DOptions(BinX, BinY, BinZ, MinPts);
        }
    }
}
