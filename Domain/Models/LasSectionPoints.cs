using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Models
{
    internal enum SectionCollectStatus
    {
        Success,
        Cancelled,
        Overflow
    }

    /// <summary>Section geometry and points (X is the signed lateral offset, Y is elevation).</summary>
    public struct LasSectionPoints
    {
        public Vector2D LeftMostPoint;
        public Vector2D RightMostPoint;
        public Vector2D Direction;
        public List<Vector2D> SectionPoints;

        /// <summary>
        /// Distance from LeftMostPoint to the section's zero offset. Null preserves
        /// the historical DtmSizeLeft convention for other section producers.
        /// </summary>
        public double? OriginOffset;
    }
}
