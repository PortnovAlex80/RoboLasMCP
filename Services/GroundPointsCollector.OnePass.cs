using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;
using Topomatic.Crs.Templates;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service.Collector;

namespace LAS_TERRAIN.Service
{
    /// <summary>
    /// Serial SDK preparation followed by bounded parallel traversal of read-only data.
    /// One job owns one section across all indexers: no indexer-by-section result matrix,
    /// no cross-thread List writes, and no second copy of every point during merging.
    /// SDK tree/point storage must remain unchanged until this synchronous call returns.
    /// </summary>
    internal static class OnePassSectionCollector
    {
        public delegate void CollectionProgressCallback(float progress);

        public static LasSectionPoints[] CollectAllSections(Alignment alg, IList<LidarBuffer> buffers,
            IList<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> pointFilter)
        {
            return CollectAllSections(alg, buffers, sections, options, pointFilter, null, null);
        }

        public static LasSectionPoints[] CollectAllSections(Alignment alg, IList<LidarBuffer> buffers,
            IList<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> pointFilter,
            CollectionProgressCallback progressCallback)
        {
            return CollectAllSections(alg, buffers, sections, options, pointFilter, progressCallback, null);
        }

        internal static LasSectionPoints[] CollectAllSections(Alignment alg, IList<LidarBuffer> buffers,
            IList<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> pointFilter,
            CollectionProgressCallback progressCallback, Func<bool> cancellationPending)
        {
            return CollectAllCore(alg, buffers, sections, null, options, pointFilter,
                progressCallback, cancellationPending);
        }

        // Calculate generated sections without first replacing the CAD section list.
        internal static LasSectionPoints[] CollectAllAtStations(Alignment alg,
            IList<LidarBuffer> buffers, IList<double> stations, LasFilterOptions options,
            CollectionProgressCallback progressCallback, Func<bool> cancellationPending)
        {
            if (stations == null) throw new ArgumentNullException("stations");
            double[] capturedStations = new double[stations.Count];
            for (int i = 0; i < stations.Count; i++)
            {
                if (!PointKey3D.IsFinite(stations[i]))
                    throw new ArgumentOutOfRangeException("stations");
                capturedStations[i] = stations[i];
            }
            return CollectAllCore(alg, buffers, null, capturedStations, options, null,
                progressCallback, cancellationPending);
        }

        private static LasSectionPoints[] CollectAllCore(Alignment alg,
            IList<LidarBuffer> buffers, IList<Section> sections, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> pointFilter,
            CollectionProgressCallback progressCallback, Func<bool> cancellationPending)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (buffers == null) throw new ArgumentNullException("buffers");
            if (sections == null && stations == null) throw new ArgumentNullException("sections");
            if (sections == null && pointFilter != null)
                throw new ArgumentException("A contour predicate requires registered sections.", "pointFilter");
            if (options == null) throw new ArgumentNullException("options");
            options = options.Copy();
            double halfBorder = options.HalfBorder;
            if (!PointKey3D.IsFinite(halfBorder) || halfBorder <= 0.0)
                throw new ArgumentOutOfRangeException("options", "HalfBorder must be finite and positive.");
            bool parallel = options.Async;
            double leftOffset = options.CentralLeftOffset ?? alg.DtmSizeLeft;
            double rightOffset = options.CentralRightOffset ?? alg.DtmSizeRight;
            if (!PointKey3D.IsFinite(leftOffset) || !PointKey3D.IsFinite(rightOffset))
                throw new ArgumentOutOfRangeException("options", "Offsets must be finite.");
            int count = sections != null ? sections.Count : stations.Count;
            if (progressCallback != null) progressCallback(0.0f);
            SectionGeometry[] geometry = new SectionGeometry[count];
            LasSectionPoints[] results = new LasSectionPoints[count];
            int reportEvery = Math.Max(1, count / 100);

            // No corridor/indexer SDK methods are invoked by workers below.
            for (int i = 0; i < count; i++)
            {
                if (cancellationPending != null && cancellationPending()) return null;
                SectionGeometry g = new SectionGeometry();
                results[i].SectionPoints = new List<Vector2D>();
                results[i].OriginOffset = leftOffset;
                double station = sections != null ? sections[i].Station : stations[i];
                if (alg.Plan.CompoundLine.StaOffsetToPos(station, -leftOffset, out g.Left)
                    && alg.Plan.CompoundLine.StaOffsetToPos(station, rightOffset, out g.Right))
                {
                    double dx = g.Right.X - g.Left.X, dy = g.Right.Y - g.Left.Y;
                    g.Length = Math.Sqrt(dx * dx + dy * dy);
                    if (PointKey3D.IsFinite(g.Length) && g.Length >= 1e-9)
                    {
                        g.DirX = dx / g.Length;
                        g.DirY = dy / g.Length;
                        g.Valid = true;
                        if (pointFilter != null)
                        {
                            g.Contours = new List<Vector2D>();
                            var corridor = alg.Corridor;
                            var context = corridor[corridor.Sections.GetIndex(station)];
                            foreach (var entry in context.Map)
                            {
                                if (entry.Key is CrsNode)
                                {
                                    CrsNode node = (CrsNode)entry.Key;
                                    g.Contours.Add(new Vector2D(node.X, node.Y));
                                }
                            }
                            g.Contours.Sort(delegate(Vector2D a, Vector2D b) { return a.X.CompareTo(b.X); });
                        }
                        results[i].LeftMostPoint = g.Left;
                        results[i].RightMostPoint = g.Right;
                        results[i].Direction = new Vector2D(g.DirX, g.DirY);
                    }
                }
                geometry[i] = g;
                if (progressCallback != null && (i % reportEvery == 0 || i == count - 1))
                    progressCallback(0.1f * (i + 1) / count);
            }

            List<IndexerSnapshot> snapshots = new List<IndexerSnapshot>();
            foreach (LidarBuffer buffer in buffers)
            {
                if (cancellationPending != null && cancellationPending()) return null;
                if (buffer == null || buffer.indexers == null) continue;
                for (int i = 0; i < buffer.indexers.Length; i++)
                {
                    QuadTreeIndexer indexer = buffer.indexers[i];
                    if (indexer == null || indexer.points.Count == 0) continue;
                    IndexerSnapshot snapshot = new IndexerSnapshot();
                    snapshot.Tree = indexer;
                    snapshot.PointCount = indexer.points.Count;
                    snapshot.Points = indexer.points.GetBuffer();
                    snapshot.ScaleX = indexer.scale.X;
                    snapshot.ScaleY = indexer.scale.Y;
                    snapshot.ScaleZ = indexer.scale.Z;
                    snapshot.PosX = indexer.position.X;
                    snapshot.PosY = indexer.position.Y;
                    snapshot.PosZ = indexer.position.Z;
                    if (snapshot.Points == null || snapshot.PointCount > snapshot.Points.Length)
                        throw new InvalidOperationException("Inconsistent LiDAR point storage.");
                    snapshots.Add(snapshot);
                }
            }

            bool completed = ParallelWorkRunner.Run(count, parallel,
                delegate(int sectionIndex, WorkCancellation cancellation)
                {
                    SectionGeometry g = geometry[sectionIndex];
                    if (!g.Valid) return;
                    List<Vector2D> output = results[sectionIndex].SectionPoints;
                    for (int i = 0; i < snapshots.Count; i++)
                    {
                        if (cancellation.IsCancellationRequested) return;
                        Traverse(snapshots[i], snapshots[i].Tree, ref g, options,
                            leftOffset, output, pointFilter, cancellation);
                    }
                }, cancellationPending,
                delegate(float progress)
                {
                    if (progressCallback != null) progressCallback(0.1f + 0.9f * progress);
                });
            return completed ? results : null;
        }

        private static void Traverse(IndexerSnapshot source, QuadTreeLeaf leaf, ref SectionGeometry section,
            LasFilterOptions options, double leftOffset, List<Vector2D> output,
            Func<Vector2D, List<Vector2D>, bool> pointFilter, WorkCancellation cancellation)
        {
            if (leaf == null || leaf.count == 0 || cancellation.IsCancellationRequested) return;
            double halfBorder = options.HalfBorder;
            double x1 = leaf.minx * source.ScaleX + source.PosX;
            double x2 = leaf.maxx * source.ScaleX + source.PosX;
            double y1 = leaf.miny * source.ScaleY + source.PosY;
            double y2 = leaf.maxy * source.ScaleY + source.PosY;
            // Negative indexer scales reverse the bounds.
            double minX = Math.Min(x1, x2), maxX = Math.Max(x1, x2);
            double minY = Math.Min(y1, y2), maxY = Math.Max(y1, y2);
            double rx = (maxX - minX) * 0.5, ry = (maxY - minY) * 0.5;
            double cx = minX + rx - section.Left.X, cy = minY + ry - section.Left.Y;
            double normalRadius = rx * Math.Abs(section.DirY) + ry * Math.Abs(section.DirX);
            if (Math.Abs(cx * section.DirY - cy * section.DirX) > halfBorder + normalRadius) return;
            double alongRadius = rx * Math.Abs(section.DirX) + ry * Math.Abs(section.DirY);
            double alongCenter = cx * section.DirX + cy * section.DirY;
            if (alongCenter < -alongRadius || alongCenter > section.Length + alongRadius) return;

            if (leaf.leafs != null)
            {
                for (int i = 0; i < leaf.leafs.Length; i++)
                {
                    if (cancellation.IsCancellationRequested) return;
                    Traverse(source, leaf.leafs[i], ref section, options, leftOffset,
                        output, pointFilter, cancellation);
                }
                return;
            }
            if (leaf.start < 0 || leaf.count < 0 || leaf.start > source.PointCount
                || leaf.count > source.PointCount - leaf.start)
                throw new InvalidOperationException("Inconsistent LiDAR leaf range.");
            int end = leaf.start + leaf.count;
            for (int i = leaf.start; i < end; i++)
            {
                if ((i & 1023) == 0 && cancellation.IsCancellationRequested) return;
                double px = source.Points[i].X * source.ScaleX + source.PosX - section.Left.X;
                double py = source.Points[i].Y * source.ScaleY + source.PosY - section.Left.Y;
                double distance = px * section.DirY - py * section.DirX;
                if (!options.ContainsSliceDistance(distance)) continue;
                double along = px * section.DirX + py * section.DirY;
                if (!(along >= 0.0 && along <= section.Length)) continue;
                double z = source.Points[i].Z * source.ScaleZ + source.PosZ;
                if (!PointKey3D.IsFinite(z)) continue;
                Vector2D point = new Vector2D(along - leftOffset, z);
                if (pointFilter != null && !pointFilter(point, section.Contours)) continue;
                if (output.Count >= LasSectionPointsCollectorService.MaxSectionPoints)
                    throw new OutOfMemoryException("The per-section point limit was exceeded. Reduce the cloud first.");
                output.Add(point);
            }
        }

        private sealed class IndexerSnapshot
        {
            public QuadTreeIndexer Tree;
            public Vector3F[] Points;
            public int PointCount;
            public double ScaleX, ScaleY, ScaleZ;
            public double PosX, PosY, PosZ;
        }

        private struct SectionGeometry
        {
            public Vector2D Left, Right;
            public double DirX, DirY, Length;
            public List<Vector2D> Contours;
            public bool Valid;
        }
    }
}
