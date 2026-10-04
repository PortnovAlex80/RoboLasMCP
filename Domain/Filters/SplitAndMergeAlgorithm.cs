using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    internal class SplitAndMergeAlgorithm
    {
        private const double MinTolerance = 1e-9;

        internal static List<Vector2D> Apply(List<Vector2D> points, double tolerance)
        {
            if (double.IsNaN(tolerance) || double.IsInfinity(tolerance) || tolerance < 0.0)
                throw new ArgumentOutOfRangeException("tolerance");
            tolerance = Math.Max(tolerance, MinTolerance);
            if (points == null) return new List<Vector2D>();
            for (int i = 0; i < points.Count; i++)
            {
                if (!IsFinite(points[i].X) || !IsFinite(points[i].Y))
                    throw new ArgumentException("Polyline coordinates must be finite.", "points");
            }
            if (points.Count < 2) return new List<Vector2D>(points);

            bool[] keep = new bool[points.Count];
            keep[0] = true;
            keep[points.Count - 1] = true;
            Stack<IndexRange> ranges = new Stack<IndexRange>();
            ranges.Push(new IndexRange(0, points.Count - 1));
            double toleranceSq = tolerance * tolerance;

            while (ranges.Count > 0)
            {
                IndexRange range = ranges.Pop();
                Vector2D first = points[range.From];
                Vector2D last = points[range.To];
                double dx = last.X - first.X;
                double dy = last.Y - first.Y;
                double scale = Math.Max(Math.Abs(dx), Math.Abs(dy));
                if (!IsFinite(scale))
                    throw new ArgumentException("Polyline extent is too large.", "points");

                double length = 0.0, ux = 0.0, uy = 0.0;
                if (scale > 0.0)
                {
                    double sx = dx / scale, sy = dy / scale;
                    double norm = Math.Sqrt(sx * sx + sy * sy);
                    length = scale * norm;
                    if (!IsFinite(length))
                        throw new ArgumentException("Polyline extent is too large.", "points");
                    ux = sx / norm;
                    uy = sy / norm;
                }

                double maxDistanceSq = toleranceSq;
                int split = -1;
                for (int i = range.From + 1; i < range.To; i++)
                {
                    // Translate first: avoids cancellation of large world-coordinate products.
                    double px = points[i].X - first.X;
                    double py = points[i].Y - first.Y;
                    double along = px * ux + py * uy;
                    double distanceSq;
                    if (length == 0.0 || along <= 0.0)
                    {
                        distanceSq = px * px + py * py;
                    }
                    else if (along >= length)
                    {
                        double ex = points[i].X - last.X;
                        double ey = points[i].Y - last.Y;
                        distanceSq = ex * ex + ey * ey;
                    }
                    else
                    {
                        double perpendicular = px * uy - py * ux;
                        distanceSq = perpendicular * perpendicular;
                    }
                    if (distanceSq > maxDistanceSq)
                    {
                        maxDistanceSq = distanceSq;
                        split = i;
                    }
                }

                if (split >= 0)
                {
                    keep[split] = true;
                    ranges.Push(new IndexRange(split, range.To));
                    ranges.Push(new IndexRange(range.From, split));
                }
            }

            List<Vector2D> result = new List<Vector2D>();
            for (int i = 0; i < points.Count; i++)
            {
                if (!keep[i]) continue;
                // Only exact consecutive duplicates may be removed. Do not weaken
                // the simplification error bound with an additional epsilon filter.
                if (result.Count == 0 || result[result.Count - 1].X != points[i].X
                    || result[result.Count - 1].Y != points[i].Y)
                    result.Add(points[i]);
            }
            return result;
        }

        private static bool IsFinite(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }

        private struct IndexRange
        {
            public readonly int From;
            public readonly int To;
            public IndexRange(int from, int to) { From = from; To = to; }
        }
    }

    // Retained for existing callers; simplification itself only stores index ranges.
    public struct LineSegment
    {
        public Vector2D Start;
        public Vector2D End;
        public LineSegment(Vector2D start, Vector2D end) { Start = start; End = end; }
    }
}
