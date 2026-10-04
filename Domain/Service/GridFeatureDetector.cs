using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Service
{
    internal static class GridFeatureDetector
    {
        public enum Mode { Ridges, Valleys, Both }

        private struct CellData
        {
            public readonly double X, Y, Z;
            public CellData(double x, double y, double z) { X = x; Y = y; Z = z; }
        }

        public static List<Vector3D> DetectFeatures(
            List<Vector3D> points,
            BoundingBox2D boxXY,
            double gridStep,
            double smallRadiusMeters,
            double largeRadiusMeters,
            double dogThreshold,
            double slopeThreshold,
            Mode mode)
        {
            var result = new List<Vector3D>();
            if (points == null || points.Count == 0 || gridStep <= 0.0)
                return result;

            double x0 = boxXY.Min.X, y0 = boxXY.Min.Y;
            var baseMap = new Dictionary<GridCellIndex, CellData>(points.Count);
            for (int i = 0; i < points.Count; i++)
            {
                Vector3D p = points[i];
                int ix = (int)Math.Floor((p.X - x0) / gridStep);
                int iy = (int)Math.Floor((p.Y - y0) / gridStep);
                var key = new GridCellIndex(ix, iy);

                CellData cur;
                if (!baseMap.TryGetValue(key, out cur) || p.Z < cur.Z)
                    baseMap[key] = new CellData(p.X, p.Y, p.Z);
            }

            int r1 = (int)Math.Round(smallRadiusMeters / gridStep);
            int r2 = (int)Math.Round(largeRadiusMeters / gridStep);
            if (r1 <= 0) r1 = 1;
            if (r2 <= r1) r2 = r1 * 2 + 1;

            var keys = new List<GridCellIndex>(baseMap.Keys);

            var smallMap = BoxBlur(baseMap, keys, r1);
            var largeMap = BoxBlur(baseMap, keys, r2);

            for (int k = 0; k < keys.Count; k++)
            {
                var c = keys[k];

                CellData s, l, b;
                if (!smallMap.TryGetValue(c, out s)) continue;
                if (!largeMap.TryGetValue(c, out l)) continue;
                if (!baseMap.TryGetValue(c, out b)) continue;

                double dog = s.Z - l.Z;

                if (mode == Mode.Ridges && !(dog >= dogThreshold)) continue;
                if (mode == Mode.Valleys && !(dog <= -dogThreshold)) continue;
                if (mode == Mode.Both && !(Math.Abs(dog) >= dogThreshold)) continue;

                double slope = ComputeSlopeMagnitude(smallMap, c, gridStep);
                if (slope < slopeThreshold) continue;

                result.Add(new Vector3D(b.X, b.Y, b.Z));
            }

            return result;
        }

        private static Dictionary<GridCellIndex, CellData> BoxBlur(
            Dictionary<GridCellIndex, CellData> src,
            List<GridCellIndex> keys,
            int r)
        {
            var dst = new Dictionary<GridCellIndex, CellData>(src.Count);
            for (int i = 0; i < keys.Count; i++)
            {
                var c = keys[i];
                CellData cd = src[c];

                double sum = 0.0;
                int cnt = 0;

                for (int dy = -r; dy <= r; dy++)
                {
                    int ny = c.Y + dy;
                    for (int dx = -r; dx <= r; dx++)
                    {
                        int nx = c.X + dx;
                        var nb = new GridCellIndex(nx, ny);

                        CellData nd;
                        if (src.TryGetValue(nb, out nd))
                        {
                            sum += nd.Z;
                            cnt++;
                        }
                    }
                }

                double z = (cnt > 0) ? (sum / cnt) : cd.Z;
                dst[c] = new CellData(cd.X, cd.Y, z);
            }
            return dst;
        }

        private static double ComputeSlopeMagnitude(Dictionary<GridCellIndex, CellData> map, GridCellIndex c, double step)
        {
            double zc = map[c].Z;

            double zx_p, zx_m, zy_p, zy_m;
            CellData tmp;

            if (map.TryGetValue(new GridCellIndex(c.X + 1, c.Y), out tmp)) zx_p = tmp.Z; else zx_p = zc;
            if (map.TryGetValue(new GridCellIndex(c.X - 1, c.Y), out tmp)) zx_m = tmp.Z; else zx_m = zc;
            if (map.TryGetValue(new GridCellIndex(c.X, c.Y + 1), out tmp)) zy_p = tmp.Z; else zy_p = zc;
            if (map.TryGetValue(new GridCellIndex(c.X, c.Y - 1), out tmp)) zy_m = tmp.Z; else zy_m = zc;

            double dzdx = (zx_p - zx_m) / (2.0 * step);
            double dzdy = (zy_p - zy_m) / (2.0 * step);

            return Math.Sqrt(dzdx * dzdx + dzdy * dzdy);
        }
    }
}
