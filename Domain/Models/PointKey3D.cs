using System;

namespace LAS_TERRAIN.Models
{
    /// <summary>
    /// Equality uses all three coordinates, never a packed/truncated hash alone.
    /// Exact keys preserve raw LAS precision, including distinct elevations at the same XY.
    /// </summary>
    internal struct PointKey3D : IEquatable<PointKey3D>
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;

        private PointKey3D(double x, double y, double z)
        {
            if (!IsFinite(x) || !IsFinite(y) || !IsFinite(z))
                throw new ArgumentException("Point coordinates must be finite.");
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static PointKey3D Exact(double x, double y, double z)
        {
            return new PointKey3D(x, y, z);
        }

        public bool Equals(PointKey3D other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            return obj is PointKey3D && Equals((PointKey3D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = x.GetHashCode();
                hash = (hash * 397) ^ y.GetHashCode();
                return (hash * 397) ^ z.GetHashCode();
            }
        }

        internal static bool IsFinite(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }
    }
}
