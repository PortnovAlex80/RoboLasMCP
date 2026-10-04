// Domain/Service/FastSurfaceBuilder.cs
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Domain.Service
{
    /// <summary>
    /// Reports an apply failure whose local compensation or SDK update state
    /// cannot be certified. Raw SurfacePointArray operations have no SDK undo.
    /// </summary>
    internal sealed class SurfaceApplyException : InvalidOperationException
    {
        internal bool PointsRestored { get; private set; }
        internal bool DynamicRestored { get; private set; }
        internal bool IndexRestored { get; private set; }
        internal bool UpdateStateUnknown { get; private set; }
        internal Exception ApplyError { get; private set; }
        internal Exception CompensationError { get; private set; }

        internal SurfaceApplyException(string message, Exception applyError,
            Exception compensationError, bool pointsRestored, bool dynamicRestored,
            bool indexRestored, bool updateStateUnknown)
            : base(message, compensationError ?? applyError)
        {
            ApplyError = applyError;
            CompensationError = compensationError;
            PointsRestored = pointsRestored;
            DynamicRestored = dynamicRestored;
            IndexRestored = indexRestored;
            UpdateStateUnknown = updateStateUnknown;
        }
    }

    /// <summary>
    /// Centralized fast surface point insertion.
    /// Bypasses PointEditor (undo/events/indexer per point) and disables
    /// per-point TIN rebuild via Style.Dynamic = false.
    /// Uses SurfacePointArray.Add() directly (pure List.Add).
    /// BeginUpdate/EndUpdate preserve the existing SDK notification sequence;
    /// they are not an undo transaction or a proven TIN rebuild.
    /// </summary>
    internal static class FastSurfaceBuilder
    {
        private const long BytesPerPoint = 200L;
        private static readonly object ApplyGate = new object();

        public static void InsertPoints(List<Vector3D> points, Surface surface)
        {
            if (points == null || points.Count == 0)
                return;
            if (surface == null) throw new ArgumentNullException("surface");

            // Memory guard
            long estimatedBytes = points.Count * BytesPerPoint;
            long avail = MemoryStatus.AvailablePhysicalBytes();
            if (avail > 0 && estimatedBytes > avail * 4 / 5)
            {
                throw new OutOfMemoryException(
                    string.Format("Not enough memory for {0:N0} points (~{1:N0} MB needed, {2:N0} MB available)",
                        points.Count,
                        estimatedBytes / (1024 * 1024),
                        avail / (1024 * 1024)));
            }

            lock (ApplyGate)
            {
                int initialCount = surface.Points.Count;
                if (points.Count > Int32.MaxValue - initialCount)
                    throw new OutOfMemoryException("The destination surface cannot hold all points.");

                bool wasDynamic = surface.Style.Dynamic;
                bool updateAttempted = false;
                bool indexMayNeedRefresh = false;
                try
                {
                    surface.Style.Dynamic = false;
                    surface.Points.Capacity = initialCount + points.Count;
                    indexMayNeedRefresh = true;
                    for (int i = 0; i < points.Count; i++)
                        surface.Points.Add(new SurfacePoint(points[i]));
                    surface.PointIndexer.Invalidate();
                    // Preserve the existing notification order on success.
                    surface.Style.Dynamic = wasDynamic;
                    updateAttempted = true;
                    surface.BeginUpdate();
                    surface.EndUpdate();
                }
                catch (Exception insertionError)
                {
                    bool pointsRestored = false;
                    bool indexRestored = false;
                    bool dynamicRestored = false;
                    Exception compensationError = null;
                    try
                    {
                        // SurfacePointArray.Add bypasses the SDK undo manager.
                        // Reverse only this call's tail before returning failure.
                        while (surface.Points.Count > initialCount)
                            surface.Points.RemoveAt(surface.Points.Count - 1);
                        pointsRestored = surface.Points.Count == initialCount;
                        if (pointsRestored && indexMayNeedRefresh)
                            surface.PointIndexer.Invalidate();
                        indexRestored = pointsRestored;
                    }
                    catch (Exception error)
                    {
                        compensationError = error;
                    }
                    try
                    {
                        surface.Style.Dynamic = wasDynamic;
                        dynamicRestored = surface.Style.Dynamic == wasDynamic;
                    }
                    catch (Exception error)
                    {
                        if (compensationError == null) compensationError = error;
                    }

                    if (!pointsRestored || !indexRestored || !dynamicRestored || updateAttempted)
                        throw new SurfaceApplyException(
                            "Surface insertion failed and compensation was incomplete or SDK update state is unknown: "
                            + insertionError.Message, insertionError, compensationError,
                            pointsRestored, dynamicRestored, indexRestored, updateAttempted);
                    throw;
                }

            }
        }
    }
}
