using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Lidar;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Service.Collector;

namespace LAS_TERRAIN.Collector
{
    /// <summary>
    /// Deterministic raw collection. SDK FindPoints/Map access is serialized;
    /// Async does not opt into undocumented SDK thread safety. Deduplication is
    /// incremental, uses exact XYZ keys, and preserves the first point's weight.
    /// </summary>
    internal static class RawPointsCollector
    {
        public static OperationResult<List<Vector4D>> Collect(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter)
        {
            return Collect(alg, buffers, sections, options, filter, null);
        }

        public static OperationResult<List<Vector4D>> Collect(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            Action<float> onProgress)
        {
            return CollectInternal(alg, buffers, sections, null, options, filter, null,
                onProgress, true);
        }

        public static OperationResult<List<Vector4D>> CollectNoDedup(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter)
        {
            return CollectNoDedup(alg, buffers, sections, options, filter, null);
        }

        public static OperationResult<List<Vector4D>> CollectNoDedup(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            Action<float> onProgress)
        {
            return CollectInternal(alg, buffers, sections, null, options, filter, null,
                onProgress, false);
        }

        // Same exact-XYZ first-wins reducer, with a projected-coordinate filter
        // that does not need a registered CAD section or corridor design Map.
        internal static OperationResult<List<Vector4D>> CollectAtStations(
            Alignment alg, List<LidarBuffer> buffers, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, bool> filter, Action<float> onProgress)
        {
            if (stations == null) throw new ArgumentNullException("stations");
            if (filter == null) throw new ArgumentNullException("filter");
            return CollectInternal(alg, buffers, null, stations, options, null, filter,
                onProgress, true);
        }

        // The split exporter streams first-seen XYZ tuples into a point spool.
        // It retains only the deduplication keys, not full category or section lists.
        internal static OperationResult<int> StreamAtStations(
            Alignment alg, List<LidarBuffer> buffers, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, bool> filter,
            Action<Vector4D> acceptPoint, Action<float> onProgress)
        {
            if (stations == null) throw new ArgumentNullException("stations");
            if (filter == null) throw new ArgumentNullException("filter");
            if (acceptPoint == null) throw new ArgumentNullException("acceptPoint");
            if (options == null) throw new ArgumentNullException("options");
            options = options.Copy();
            Func<bool> cancellation = delegate { return WaitProgress.CancellationPending; };
            try
            {
                int count = 0;
                HashSet<PointKey3D> unique = new HashSet<PointKey3D>();
                if (onProgress != null) onProgress(0.0f);
                for (int i = 0; i < stations.Count; i++)
                {
                    if (cancellation()) return OperationResult<int>.Cancelled(SectionStage.Collect);
                    SectionCollectStatus status;
                    LasSectionPointsCollectorService.StreamRawAtStation(
                        alg, buffers, stations[i], options, filter,
                        delegate(Vector4D point)
                        {
                            if ((count & 1023) == 0 && cancellation())
                                throw new OperationCanceledException();
                            if (!unique.Add(PointKey3D.Exact(point.X, point.Y, point.Z)))
                                return;
                            if (count == Int32.MaxValue)
                                throw new OutOfMemoryException("Too many points for LAS split sampling.");
                            acceptPoint(point);
                            count++;
                        }, cancellation, out status);
                    if (status == SectionCollectStatus.Overflow)
                        return OperationResult<int>.Overflow(SectionStage.Collect,
                            new OutOfMemoryException("The per-section point limit was exceeded."));
                    if (status == SectionCollectStatus.Cancelled || cancellation())
                        return OperationResult<int>.Cancelled(SectionStage.Collect);
                    if (onProgress != null) onProgress((i + 1) / (float)stations.Count);
                }
                if (cancellation()) return OperationResult<int>.Cancelled(SectionStage.Collect);
                if (stations.Count == 0 && onProgress != null) onProgress(1.0f);
                return count == 0 ? OperationResult<int>.Empty()
                    : OperationResult<int>.Succeeded(count);
            }
            catch (OperationCanceledException)
            {
                return OperationResult<int>.Cancelled(SectionStage.Collect);
            }
            catch (OutOfMemoryException error)
            {
                return OperationResult<int>.Overflow(SectionStage.Collect, error);
            }
            catch (Exception error)
            {
                return OperationResult<int>.Failed(SectionStage.Collect, error);
            }
        }

        private static OperationResult<List<Vector4D>> CollectInternal(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, IList<double> stations, LasFilterOptions options,
            Func<Vector2D, List<Vector2D>, bool> filter, Func<Vector2D, bool> coordinateFilter,
            Action<float> onProgress, bool deduplicate)
        {
            if (sections == null && stations == null)
                throw new ArgumentNullException("sections");
            if (options == null) throw new ArgumentNullException("options");
            options = options.Copy();
            int sectionCount = sections == null ? stations.Count : sections.Count;
            Func<bool> cancellation = delegate { return WaitProgress.CancellationPending; };
            try
            {
                List<Vector4D> result = new List<Vector4D>();
                HashSet<PointKey3D> unique = deduplicate ? new HashSet<PointKey3D>() : null;
                if (onProgress != null) onProgress(0.0f);
                for (int i = 0; i < sectionCount; i++)
                {
                    if (cancellation()) return OperationResult<List<Vector4D>>.Cancelled(SectionStage.Collect);
                    List<Vector4D> raw;
                    SectionCollectStatus status;
                    if (sections == null)
                        LasSectionPointsCollectorService.CollectRawAtStation(
                            alg, buffers, stations[i], options, coordinateFilter,
                            out raw, cancellation, out status);
                    else
                        LasSectionPointsCollectorService.Collect(
                            alg, buffers, sections[i], options, out raw, filter,
                            cancellation, out status);
                    if (status == SectionCollectStatus.Overflow)
                        return OperationResult<List<Vector4D>>.Overflow(SectionStage.Collect,
                            new OutOfMemoryException("The per-section point limit was exceeded."));
                    if (status == SectionCollectStatus.Cancelled || cancellation())
                        return OperationResult<List<Vector4D>>.Cancelled(SectionStage.Collect);
                    if (raw == null)
                        return OperationResult<List<Vector4D>>.Failed(SectionStage.Collect,
                            new InvalidOperationException("The section collector returned no raw point list."));
                    for (int j = 0; j < raw.Count; j++)
                    {
                        if ((j & 1023) == 0 && cancellation())
                            return OperationResult<List<Vector4D>>.Cancelled(SectionStage.Collect);
                        Vector4D point = raw[j];
                        if (unique == null || unique.Add(PointKey3D.Exact(point.X, point.Y, point.Z)))
                            result.Add(point);
                    }
                    if (onProgress != null) onProgress((i + 1) / (float)sectionCount);
                }
                if (cancellation()) return OperationResult<List<Vector4D>>.Cancelled(SectionStage.Collect);
                if (sectionCount == 0 && onProgress != null) onProgress(1.0f);
                return result.Count == 0
                    ? OperationResult<List<Vector4D>>.Empty()
                    : OperationResult<List<Vector4D>>.Succeeded(result);
            }
            catch (OutOfMemoryException error)
            {
                return OperationResult<List<Vector4D>>.Overflow(SectionStage.Collect, error);
            }
            catch (Exception error)
            {
                return OperationResult<List<Vector4D>>.Failed(SectionStage.Collect, error);
            }
        }
    }
}
