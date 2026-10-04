using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Rail 16 FindPoints returns its byte weight divided by 255. LAS point
    /// format 1 stores a 16-bit intensity. Restore the byte before expansion
    /// so a native re-import gets the original byte weight.
    /// </summary>
    internal static class LidarIntensity
    {
        internal static double ExpandNormalized(double weight)
        {
            if (Double.IsNaN(weight) || Double.IsInfinity(weight) ||
                weight < 0.0 || weight > 1.0)
                throw new ArgumentOutOfRangeException("weight",
                    "SDK LiDAR weight must be a normalized byte.");
            return Math.Round(weight * 255.0) * 257.0;
        }

        internal static void ExpandInPlace(List<Vector4D> points)
        {
            if (points == null) throw new ArgumentNullException("points");
            for (int i = 0; i < points.Count; i++)
            {
                Vector4D point = points[i];
                points[i] = new Vector4D(point.X, point.Y, point.Z,
                    ExpandNormalized(point.W));
            }
        }
    }
}
