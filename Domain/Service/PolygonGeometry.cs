using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Service
{
    internal static class PolygonGeometry
    {
        internal static bool Contains(Vector2D point, List<Vector2D> polygon)
        {
            if (polygon == null || polygon.Count < 3) return false;
            return Contains(point.X, point.Y, polygon);
        }

        internal static bool Contains(double x, double y, List<Vector2D> polygon)
        {
            if (polygon == null || polygon.Count < 3) return false;

            int n = polygon.Count;
            bool inside = false;
            for (int i = 0, j = n - 1; i < n; j = i++)
            {
                double xi = polygon[i].X, yi = polygon[i].Y;
                double xj = polygon[j].X, yj = polygon[j].Y;

                if (((yi > y) != (yj > y)) &&
                    (x < (xj - xi) * (y - yi) / (yj - yi) + xi))
                {
                    inside = !inside;
                }
            }
            return inside;
        }
    }
}
