using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;
using Topomatic.Alg.Crs;
using Topomatic.Crs.Templates;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Service.Collector
{
    /// <summary>
    /// Legacy SDK collector. Call sequentially: corridor.Map and FindPoints do not
    /// have a verified concurrent-read contract. OnePass handles parallel array reads.
    /// </summary>
    internal static partial class LasSectionPointsCollectorService
    {
        internal const int MaxSectionPoints = 33554432;

        internal static bool ReachedPointLimit(int pointCount, int limit)
        {
            return pointCount >= limit;
        }

        public static LasSectionPoints Collect(Alignment alg, IList<LidarBuffer> buffers,
            Section section, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> pointFilter,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            if (section == null) throw new ArgumentNullException("section");
            List<Vector4D> unused;
            return CollectInternal(alg, buffers, section.Station, options, out unused,
                pointFilter, null, false, cancellationPending, out status);
        }

        // Generated sections can be calculated before changing the corridor.
        // This path deliberately has no contour predicate or corridor Map read.
        internal static LasSectionPoints CollectAtStation(Alignment alg,
            IList<LidarBuffer> buffers, double station, LasFilterOptions options,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            if (!PointKey3D.IsFinite(station))
                throw new ArgumentOutOfRangeException("station");
            List<Vector4D> unused;
            return CollectInternal(alg, buffers, station, options, out unused,
                null, null, false, cancellationPending, out status);
        }

        public static LasSectionPoints Collect(Alignment alg, IList<LidarBuffer> buffers,
            Section section, LasFilterOptions options, out List<Vector4D> lidarRawPoints,
            Func<Vector2D, List<Vector2D>, bool> pointFilter, Func<bool> cancellationPending,
            out SectionCollectStatus status)
        {
            if (section == null) throw new ArgumentNullException("section");
            return CollectInternal(alg, buffers, section.Station, options, out lidarRawPoints,
                pointFilter, null, true, cancellationPending, out status);
        }

        // Export commands need the same raw slice without creating or replacing
        // persistent CAD sections. No contour predicate means no corridor Map read.
        internal static LasSectionPoints CollectRawAtStation(Alignment alg,
            IList<LidarBuffer> buffers, double station, LasFilterOptions options,
            out List<Vector4D> lidarRawPoints, Func<bool> cancellationPending,
            out SectionCollectStatus status)
        {
            if (!PointKey3D.IsFinite(station))
                throw new ArgumentOutOfRangeException("station");
            return CollectInternal(alg, buffers, station, options, out lidarRawPoints,
                null, null, true, cancellationPending, out status);
        }

        // Offset-only exporters filter the projected section coordinate without
        // loading design contours or mutating the corridor's section collection.
        internal static LasSectionPoints CollectRawAtStation(Alignment alg,
            IList<LidarBuffer> buffers, double station, LasFilterOptions options,
            Func<Vector2D, bool> coordinateFilter, out List<Vector4D> lidarRawPoints,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            if (!PointKey3D.IsFinite(station))
                throw new ArgumentOutOfRangeException("station");
            if (coordinateFilter == null) throw new ArgumentNullException("coordinateFilter");
            return CollectInternal(alg, buffers, station, options, out lidarRawPoints,
                null, coordinateFilter, true, cancellationPending, out status);
        }

        internal static void StreamRawAtStation(Alignment alg, IList<LidarBuffer> buffers,
            double station, LasFilterOptions options, Func<Vector2D, bool> coordinateFilter,
            Action<Vector4D> acceptPoint, Func<bool> cancellationPending,
            out SectionCollectStatus status)
        {
            if (!PointKey3D.IsFinite(station))
                throw new ArgumentOutOfRangeException("station");
            if (coordinateFilter == null) throw new ArgumentNullException("coordinateFilter");
            if (acceptPoint == null) throw new ArgumentNullException("acceptPoint");
            List<Vector4D> unused;
            CollectInternal(alg, buffers, station, options, out unused, null,
                coordinateFilter, false, acceptPoint, false, cancellationPending,
                out status);
        }

        internal static void StreamRawAtStation(Alignment alg, IList<LidarBuffer> buffers,
            double station, LasFilterOptions options, Action<Vector4D> acceptPoint,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            if (!PointKey3D.IsFinite(station))
                throw new ArgumentOutOfRangeException("station");
            if (acceptPoint == null) throw new ArgumentNullException("acceptPoint");
            List<Vector4D> unused;
            CollectInternal(alg, buffers, station, options, out unused, null,
                null, false, acceptPoint, false, cancellationPending, out status);
        }

        private static LasSectionPoints CollectInternal(Alignment alg, IList<LidarBuffer> buffers,
            double station, LasFilterOptions options, out List<Vector4D> lidarRawPoints,
            Func<Vector2D, List<Vector2D>, bool> pointFilter,
            Func<Vector2D, bool> coordinateFilter, bool collectRawPoints,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            return CollectInternal(alg, buffers, station, options, out lidarRawPoints,
                pointFilter, coordinateFilter, collectRawPoints, null, true,
                cancellationPending, out status);
        }

        private static LasSectionPoints CollectInternal(Alignment alg, IList<LidarBuffer> buffers,
            double station, LasFilterOptions options, out List<Vector4D> lidarRawPoints,
            Func<Vector2D, List<Vector2D>, bool> pointFilter,
            Func<Vector2D, bool> coordinateFilter, bool collectRawPoints,
            Action<Vector4D> rawSink, bool storeSectionPoints,
            Func<bool> cancellationPending, out SectionCollectStatus status)
        {
            return CollectInternal(alg,buffers,station,options,out lidarRawPoints,pointFilter,
                coordinateFilter,collectRawPoints,rawSink,storeSectionPoints,cancellationPending,out status,null);
        }

        private static LasSectionPoints CollectInternal(Alignment alg, IList<LidarBuffer> buffers,
            double station, LasFilterOptions options, out List<Vector4D> lidarRawPoints,
            Func<Vector2D,List<Vector2D>,bool> pointFilter,Func<Vector2D,bool> coordinateFilter,
            bool collectRawPoints,Action<Vector4D> rawSink,bool storeSectionPoints,
            Func<bool> cancellationPending,out SectionCollectStatus status,
            Action<LidarBuffer,BoundingBox2D,Action<Vector4D>> query)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (buffers == null) throw new ArgumentNullException("buffers");
            if (options == null) throw new ArgumentNullException("options");
            options = options.Copy();
            double halfBorder = options.HalfBorder;
            if (!PointKey3D.IsFinite(halfBorder) || halfBorder <= 0.0)
                throw new ArgumentOutOfRangeException("options", "HalfBorder must be finite and positive.");
            double leftOffset = options.CentralLeftOffset ?? alg.DtmSizeLeft;
            double rightOffset = options.CentralRightOffset ?? alg.DtmSizeRight;
            if (!PointKey3D.IsFinite(leftOffset) || !PointKey3D.IsFinite(rightOffset))
                throw new ArgumentOutOfRangeException("options", "Offsets must be finite.");

            status = SectionCollectStatus.Success;
            LasSectionPoints result = new LasSectionPoints();
            result.SectionPoints = storeSectionPoints ? new List<Vector2D>() : null;
            result.OriginOffset = leftOffset;
            List<Vector4D> raw = collectRawPoints ? new List<Vector4D>() : null;
            lidarRawPoints = raw;

            if (!alg.Plan.CompoundLine.StaOffsetToPos(station, -leftOffset, out result.LeftMostPoint)
                || !alg.Plan.CompoundLine.StaOffsetToPos(station, rightOffset, out result.RightMostPoint))
                return result;

            double dx = result.RightMostPoint.X - result.LeftMostPoint.X;
            double dy = result.RightMostPoint.Y - result.LeftMostPoint.Y;
            double length = Math.Sqrt(dx * dx + dy * dy);
            if (!PointKey3D.IsFinite(length) || length < 1e-9) return result;
            double dirX = dx / length, dirY = dy / length;
            result.Direction = new Vector2D(dirX, dirY);
            double leftX = result.LeftMostPoint.X, leftY = result.LeftMostPoint.Y;

            // A half-open split includes its positive border. Expand the SDK
            // broad-phase box slightly so an SDK with open box bounds still
            // passes that border to the exact predicate below.
            double searchHalfBorder = halfBorder;
            if (options.IncludePositiveSliceBorder)
            {
                double maxCoordinate = Math.Max(
                    Math.Max(Math.Abs(leftX), Math.Abs(leftY)),
                    Math.Max(Math.Abs(result.RightMostPoint.X),
                        Math.Abs(result.RightMostPoint.Y)));
                searchHalfBorder += Math.Max(1e-6, maxCoordinate * 1e-12);
            }

            BoundingBox2D box = new BoundingBox2D(result.LeftMostPoint, result.RightMostPoint);
            box.AddPoint(new Vector2D(leftX + searchHalfBorder * dirY, leftY - searchHalfBorder * dirX));
            box.AddPoint(new Vector2D(leftX - searchHalfBorder * dirY, leftY + searchHalfBorder * dirX));
            box.AddPoint(new Vector2D(result.RightMostPoint.X + searchHalfBorder * dirY,
                result.RightMostPoint.Y - searchHalfBorder * dirX));
            box.AddPoint(new Vector2D(result.RightMostPoint.X - searchHalfBorder * dirY,
                result.RightMostPoint.Y + searchHalfBorder * dirX));

            List<Vector2D> contours = null;
            if (pointFilter != null)
            {
                contours = new List<Vector2D>();
                var corridor = alg.Corridor;
                var context = corridor[corridor.Sections.GetIndex(station)];
                foreach (var entry in context.Map)
                {
                    if (entry.Key is CrsNode)
                    {
                        CrsNode node = (CrsNode)entry.Key;
                        contours.Add(new Vector2D(node.X, node.Y));
                    }
                }
                contours.Sort(delegate(Vector2D a, Vector2D b) { return a.X.CompareTo(b.X); });
            }

            bool overflow = false;
            bool cancelled = false;
            int visited = 0;
            int accepted = 0;
            try
            {
                foreach (LidarBuffer buffer in buffers)
                {
                    if (buffer == null) continue;
                    if (cancellationPending != null && cancellationPending()) { cancelled = true; break; }
                    // Filter directly in the SDK callback instead of staging millions
                    // of Vector4D values in a second list for every buffer.
                    Action<Vector4D> visit = pt =>
                    {
                        if (overflow || cancelled) return;
                        if ((visited++ & 1023) == 0 && cancellationPending != null && cancellationPending())
                        { cancelled = true; return; }
                        double px = pt.X - leftX, py = pt.Y - leftY;
                        double distance = px * dirY - py * dirX;
                        if (!options.ContainsSliceDistance(distance)) return;
                        double along = px * dirX + py * dirY;
                        if (!(along >= 0.0 && along <= length) || !PointKey3D.IsFinite(pt.Z)) return;
                        Vector2D sectionPoint = new Vector2D(along - leftOffset, pt.Z);
                        if (pointFilter != null && !pointFilter(sectionPoint, contours)) return;
                        if (coordinateFilter != null && !coordinateFilter(sectionPoint)) return;
                        if (ReachedPointLimit(accepted, MaxSectionPoints))
                        { overflow = true; return; }
                        accepted++;
                        if (storeSectionPoints) result.SectionPoints.Add(sectionPoint);
                        if (collectRawPoints || rawSink != null)
                        {
                            Vector4D point = new Vector4D(pt.X, pt.Y, pt.Z, pt.W);
                            if (collectRawPoints) raw.Add(point);
                            if (rawSink != null) rawSink(point);
                        }
                    };
                    if(query==null)buffer.FindPoints(box,pt => visit(new Vector4D(pt.X,pt.Y,pt.Z,
                        LAS_TERRAIN.Infrastructure.NativeLidarPointAdapter.Weight(pt))));else query(buffer,box,visit);
                    if (overflow || cancelled) break;
                }
            }
            catch (OutOfMemoryException)
            {
                overflow = true;
            }
            if (overflow || cancelled)
            {
                status = overflow ? SectionCollectStatus.Overflow : SectionCollectStatus.Cancelled;
                result.SectionPoints = null;
                lidarRawPoints = null;
            }
            return result;
        }
    }
}
