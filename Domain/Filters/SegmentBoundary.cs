// Domain/Filters/SegmentBoundary.cs
// Unified boundary representation for spline segmentation.
//
// CONTEXT:
// RobustGroundSplineFilter needs to split the profile into independent segments.
// There are multiple sources of segment boundaries:
//   1. Gaps in LiDAR data (physical voids > MaxGapMeters)
//   2. Terrain breaks detected by BreakDetector (sharp angles)
//   3. Manual boundaries from external code (future: UI annotations)
//
// This file provides a unified interface for all boundary types.
//
// AGENT NOTES:
// - When adding new boundary sources, extend BoundaryType enum
// - Boundaries are SORTED by X before use in spline
// - Y coordinate comes from intersection of LSQ lines (for Break) or nearest point (for Gap)

using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Тип границы сегмента.
    /// </summary>
    public enum BoundaryType
    {
        /// <summary>
        /// Gap in LiDAR data — physical void where distance between consecutive
        /// points exceeds MaxGapMeters. Caused by shadows, water, sensor gaps.
        /// </summary>
        Gap,

        /// <summary>
        /// Terrain break — detected sharp angle in profile.
        /// Examples: curb edge, embankment toe, slope break.
        /// Y coordinate is computed from intersection of left/right LSQ lines.
        /// </summary>
        Break,

        /// <summary>
        /// Manual boundary — explicitly set by external code.
        /// Future use: UI annotations, known feature locations.
        /// </summary>
        Manual
    }

    /// <summary>
    /// Represents a boundary point that splits the profile into independent segments.
    ///
    /// MATHEMATICAL MEANING:
    /// At a boundary, the spline is discontinuous. Each segment [X_prev, X_curr]
    /// gets its own independent spline fit. The Y value at the boundary is the
    /// "anchor" that both adjacent segments must pass through.
    ///
    /// FOR BREAK TYPE:
    /// X, Y are computed from intersection of two LSQ lines fitted to
    /// left and right windows around the break point. This gives sub-centimeter
    /// precision regardless of point density.
    ///
    /// FOR GAP TYPE:
    /// X, Y come from the nearest actual LiDAR point (gap boundaries are between points).
    /// </summary>
    public sealed class SegmentBoundary
    {
        /// <summary>
        /// X coordinate of the boundary (meters along profile).
        /// Must be within the profile's X range.
        /// </summary>
        public double X;

        /// <summary>
        /// Y coordinate (elevation) at the boundary.
        /// For Break type: intersection of left/right LSQ lines.
        /// For Gap type: nearest point's Y value.
        /// </summary>
        public double Y;

        /// <summary>
        /// Type of boundary — determines how it was created.
        /// </summary>
        public BoundaryType Type;

        /// <summary>
        /// Strength of the boundary signal.
        /// - Gap: distance in meters (gap size)
        /// - Break: angle in radians (0 to π)
        /// - Manual: not used (0)
        /// </summary>
        public double Strength;

        // ══════════════════════════════════════════════════════════════════════
        // FACTORY METHODS
        // ══════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Creates a Gap boundary from consecutive points.
        /// X and Y are taken from the first point after the gap.
        /// </summary>
        public static SegmentBoundary FromGap(double xAfter, double yAfter, double gapSize)
        {
            return new SegmentBoundary
            {
                X = xAfter,
                Y = yAfter,
                Type = BoundaryType.Gap,
                Strength = gapSize
            };
        }

        /// <summary>
        /// Creates a Break boundary with computed intersection coordinates.
        /// </summary>
        public static SegmentBoundary FromBreak(double xBreak, double yBreak, double angleDelta)
        {
            return new SegmentBoundary
            {
                X = xBreak,
                Y = yBreak,
                Type = BoundaryType.Break,
                Strength = angleDelta
            };
        }

        /// <summary>
        /// Creates a Manual boundary at a specific location.
        /// </summary>
        public static SegmentBoundary FromManual(double x, double y)
        {
            return new SegmentBoundary
            {
                X = x,
                Y = y,
                Type = BoundaryType.Manual,
                Strength = 0.0
            };
        }

        // ══════════════════════════════════════════════════════════════════════
        // UTILITIES
        // ══════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Returns human-readable description.
        /// </summary>
        public override string ToString()
        {
            string typeStr = Type.ToString();
            string strengthStr = Type == BoundaryType.Break
                ? string.Format("{0:F1}°", Strength * 180.0 / Math.PI)
                : string.Format("{0:F2}m", Strength);
            return string.Format("SegmentBoundary[{0}] X={1:F3} Y={2:F3} strength={3}",
                typeStr, X, Y, strengthStr);
        }
    }

    /// <summary>
    /// Utility class for working with boundary lists.
    /// </summary>
    internal static class BoundaryHelper
    {
        /// <summary>
        /// Merges multiple boundary lists, removes duplicates, sorts by X.
        /// Duplicates: boundaries with same X within tolerance are merged,
        /// keeping the one with higher strength.
        /// </summary>
        public static List<SegmentBoundary> MergeAndSort(
            List<SegmentBoundary> a,
            List<SegmentBoundary> b,
            double xTolerance)
        {
            var result = new List<SegmentBoundary>();

            if (a != null) result.AddRange(a);
            if (b != null) result.AddRange(b);

            if (result.Count == 0)
                return result;

            // Sort by X
            result.Sort((x, y) => x.X.CompareTo(y.X));

            // Remove duplicates within tolerance
            var filtered = new List<SegmentBoundary>();
            foreach (var boundary in result)
            {
                if (filtered.Count == 0)
                {
                    filtered.Add(boundary);
                    continue;
                }

                var last = filtered[filtered.Count - 1];
                if (Math.Abs(boundary.X - last.X) < xTolerance)
                {
                    // Merge: keep the one with higher strength
                    if (boundary.Strength > last.Strength)
                        filtered[filtered.Count - 1] = boundary;
                }
                else
                {
                    filtered.Add(boundary);
                }
            }

            return filtered;
        }

        /// <summary>
        /// Extracts X coordinates from boundaries for fast lookup.
        /// </summary>
        public static double[] ExtractX(List<SegmentBoundary> boundaries)
        {
            if (boundaries == null || boundaries.Count == 0)
                return new double[0];

            var xs = new double[boundaries.Count];
            for (int i = 0; i < boundaries.Count; i++)
                xs[i] = boundaries[i].X;
            return xs;
        }

        /// <summary>
        /// Finds all boundaries within a given X range.
        /// Assumes boundaries are sorted by X.
        /// </summary>
        public static List<SegmentBoundary> InRange(
            List<SegmentBoundary> boundaries,
            double xMin,
            double xMax)
        {
            var result = new List<SegmentBoundary>();
            if (boundaries == null)
                return result;

            foreach (var b in boundaries)
            {
                if (b.X >= xMin && b.X <= xMax)
                    result.Add(b);
            }
            return result;
        }
    }
}
