namespace LAS_TERRAIN.Models
{
    /// <summary>One immutable set of 3D occupancy parameters for an operation.</summary>
    internal sealed class GraphGround3DOptions
    {
        internal readonly double BinX;
        internal readonly double BinY;
        internal readonly double BinZ;
        internal readonly int MinPts;

        internal GraphGround3DOptions(double binX, double binY, double binZ, int minPts)
        {
            BinX = binX;
            BinY = binY;
            BinZ = binZ;
            MinPts = minPts;
        }
    }
}
