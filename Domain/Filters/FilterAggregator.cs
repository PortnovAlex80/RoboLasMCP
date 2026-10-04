// Domain/Filters/FilterAggregator.cs
// Applies the standard filter chain:
// OrderByX → GraphGround → BreakDetector → GroundFilter → SplitAndMerge
//
// BREAK-AWARE PIPELINE:
// After GraphGroundFilter extracts ground points, BreakDetector finds
// sharp terrain discontinuities (curbs, embankment toes, slope breaks).
// These boundaries are passed to RobustGroundSplineFilter which builds
// independent splines for each segment, preserving sharp angles.
//
// See docs/BREAK_DETECTOR_DESIGN.md for full architecture.

using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Standard filter chain for terrain points with optional progress reporting.
    ///
    /// PIPELINE (5 stages):
    /// 1. OrderByX - сортировка по X
    /// 2. GraphGroundFilter - выделение земной поверхности
    /// 3. BreakDetector - детекция изломов рельефа
    /// 4. GroundFilter (Spline/MinWeighted) - сглаживание по сегментам
    /// 5. SplitAndMerge - упрощение полилинии
    /// </summary>
    internal static class FilterAggregator
    {
        /// <summary>
        /// Total stages in filter chain (used for progress reporting).
        /// </summary>
        private const int TotalFilterStages = 5;

        // ══════════════════════════════════════════════════════════════════════
        // ТОЧКИ ВХОДА
        // ══════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Apply filter chain with optional progress callback.
        /// </summary>
        /// <param name="input">Input points to filter</param>
        /// <param name="sectionIndex">Index of current section (for progress reporting)</param>
        /// <param name="debugInfo">Debug information from GraphGroundFilter</param>
        /// <param name="progressCallback">Callback for progress updates: (sectionIndex, stageCompleted, totalStages)</param>
        internal static List<Vector2D> Apply(
            List<Vector2D> input,
            int sectionIndex,
            out GraphGroundDebugInfo debugInfo,
            Action<int, int, int> progressCallback,
            FilterOperationSnapshot settings)
        {
            debugInfo = null;

            if (input == null || input.Count == 0)
                return new List<Vector2D>();

            // ── Stage 1: Sort by X coordinate ────────────────────────────────
            List<Vector2D> ordered = OrderByX.Apply(input);
            progressCallback?.Invoke(sectionIndex, 1, TotalFilterStages);

            // ── Stage 2: Graph-based ground filter with relative classification ──
            List<Vector2D> ground = GraphGroundFilter.Apply(ordered, out debugInfo, settings);
            progressCallback?.Invoke(sectionIndex, 2, TotalFilterStages);

            // ── Stage 3: Detect terrain breaks (sharp angles) ──────────────────
            // These boundaries will be merged with gap boundaries in the spline filter
            List<SegmentBoundary> breaks = new List<SegmentBoundary>();
            if (settings.EnableBreakDetection && settings.UseSplineFilter)
            {
                breaks = BreakDetector.FindBreaks(ground, settings);
            }
            progressCallback?.Invoke(sectionIndex, 3, TotalFilterStages);

            // ── Stage 4: Ground filter (Spline or MinWeighted based on config) ──
            // Spline filter receives break boundaries and merges them with auto-detected gaps
            List<Vector2D> minweight;
            if (settings.UseSplineFilter)
            {
                // BREAK-AWARE: передаём границы изломов в сплайн
                minweight = RobustGroundSplineFilter.Apply(ground, breaks, settings);
            }
            else
            {
                minweight = MinWeightedGroundLevelMedianFilter.Apply(ground);
            }
            progressCallback?.Invoke(sectionIndex, 4, TotalFilterStages);

            // ── Stage 5: Split-and-merge simplification ───────────────────────
            List<Vector2D> merged = SplitAndMergeAlgorithm.Apply(minweight, settings.SplitMergeTolerance);
            progressCallback?.Invoke(sectionIndex, 5, TotalFilterStages);

            return merged;
        }
    }
}
