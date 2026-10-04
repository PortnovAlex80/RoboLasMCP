using System;
using System.Collections.Generic;
using LAS_TERRAIN.Filters;
using Topomatic.Cad.Foundation;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Service.Filter
{
    internal static class LasFilterService
    {
        // Parallel callers pass a captured scalar and settings, not live CAD/configuration objects.
        internal static List<Vector3D> ApplyFilter(double defaultOriginOffset, LasSectionPoints section,
            int sectionIndex, out GraphGroundDebugInfo debug, Action<int, int, int> filterProgressCallback,
            FilterOperationSnapshot settings)
        {
            if (settings == null) throw new ArgumentNullException("settings");
            debug = null;
            List<Vector3D> result = new List<Vector3D>();
            if (section.SectionPoints == null || section.SectionPoints.Count == 0) return result;
            double offset = section.OriginOffset ?? defaultOriginOffset;
            Vector2D baseOffset = section.LeftMostPoint + section.Direction * offset;
            List<Vector2D> filtered = FilterAggregator.Apply(
                section.SectionPoints, sectionIndex, out debug, filterProgressCallback, settings);
            if (filtered == null) return result;
            for (int i = 0; i < filtered.Count; i++)
            {
                Vector2D pos = baseOffset + section.Direction * filtered[i].X;
                result.Add(new Vector3D(pos, filtered[i].Y));
            }
            return result;
        }
    }
}
