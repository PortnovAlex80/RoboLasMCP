using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Application
{
    /// <summary>
    /// Applies a calculated section result to the surface captured when the
    /// operation started. Call on the CAD UI thread after background collection
    /// has completed. The validator must compare the live view, layer, project,
    /// alignment and section identity with that captured operation state.
    /// </summary>
    internal sealed class TopomaticSurfaceWriter
    {
        private readonly Surface _capturedSurface;
        private readonly Func<bool> _isTargetCurrent;

        internal TopomaticSurfaceWriter(Surface capturedSurface, Func<bool> isTargetCurrent)
        {
            if (capturedSurface == null) throw new ArgumentNullException("capturedSurface");
            if (isTargetCurrent == null) throw new ArgumentNullException("isTargetCurrent");
            _capturedSurface = capturedSurface;
            _isTargetCurrent = isTargetCurrent;
        }

        /// <summary>
        /// Validates immediately before the synchronous SDK mutation. The
        /// builder owns append and local tail compensation; raw point additions
        /// do not register SDK undo commands.
        /// </summary>
        internal void Apply(List<Vector3D> points)
        {
            if (points == null || points.Count == 0) return;
            if (!_isTargetCurrent())
                throw new InvalidOperationException(
                    "The CAD surface or its source context changed before the result could be applied.");

            FastSurfaceBuilder.InsertPoints(points, _capturedSurface);
        }
    }
}
