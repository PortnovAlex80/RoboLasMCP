using System.Collections.Generic;
using LAS_TERRAIN.Domain.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Service
{
    internal static class PolygonBounds
    {
        internal static bool TryCompute(List<PlanPolygonEntry> polygons, out BoundingBox2D bounds)
        {
            bounds = default(BoundingBox2D);
            if (polygons == null || polygons.Count == 0) return false;

            double minX = double.PositiveInfinity, minY = double.PositiveInfinity;
            double maxX = double.NegativeInfinity, maxY = double.NegativeInfinity;
            bool any = false;

            foreach (var entry in polygons)
            {
                if (entry.Polygon == null) continue;
                foreach (var pt in entry.Polygon)
                {
                    if (pt.X < minX) minX = pt.X;
                    if (pt.Y < minY) minY = pt.Y;
                    if (pt.X > maxX) maxX = pt.X;
                    if (pt.Y > maxY) maxY = pt.Y;
                    any = true;
                }
            }

            if (!any) return false;

            bounds = new BoundingBox2D(new Vector2D(minX, minY), new Vector2D(maxX, maxY));
            bounds.Inflate(1.0, 1.0); // margin
            return true;
        }
    }
}
