using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.IO
{
    // RGB belongs to this exact source record, never to a later XYZ lookup.
    public struct LasColoredPoint
    {
        public readonly Vector4D Position;
        public readonly ushort Red, Green, Blue;
        public readonly string SourceIdentity;
        public readonly long SourcePointIndex;
        public LasColoredPoint(Vector4D position, ushort red, ushort green, ushort blue,
            string sourceIdentity, long sourcePointIndex)
        {
            Position=position; Red=red; Green=green; Blue=blue;
            SourceIdentity=sourceIdentity; SourcePointIndex=sourcePointIndex;
        }
    }
}
