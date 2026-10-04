using System;

namespace LAS_TERRAIN.Models
{
    /// <summary>
    /// Full-width XY millimetre cell for a single-valued terrain surface.
    /// Z is deliberately excluded: the caller keeps the first sample's height.
    /// Floor gives consistent cells on both sides of zero; this is not radius-based deduplication.
    /// </summary>
    internal struct PointKey2D : IEquatable<PointKey2D>
    {
        private readonly double x;
        private readonly double y;

        private PointKey2D(double x, double y)
        {
            if (!PointKey3D.IsFinite(x) || !PointKey3D.IsFinite(y))
                throw new ArgumentException("Point coordinates must be finite.");
            this.x = x;
            this.y = y;
        }

        public static PointKey2D Millimetre(double x, double y)
        {
            return new PointKey2D(Math.Floor(x * 1000.0), Math.Floor(y * 1000.0));
        }

        public bool Equals(PointKey2D other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointKey2D && Equals((PointKey2D)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (x.GetHashCode() * 397) ^ y.GetHashCode(); }
        }
    }
}
