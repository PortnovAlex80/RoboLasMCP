using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.Service.Filter;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Service
{
    internal static class GroundPointsCollector
    {
        internal static OperationResult<List<Vector3D>> CollectPilot(Alignment alg,
            List<LidarBuffer> buffers, List<Section> sections, LasFilterOptions options,
            Func<Vector2D, List<Vector2D>, bool> filter, FilterOperationSnapshot settings,
            bool onePass)
        {
            return CollectPilotCore(alg, buffers, sections, null, options, filter,
                settings, onePass);
        }

        internal static OperationResult<List<Vector3D>> CollectPilotAtStations(Alignment alg,
            List<LidarBuffer> buffers, IList<double> stations, LasFilterOptions options,
            FilterOperationSnapshot settings, bool onePass)
        {
            double[] capturedStations;
            LasFilterOptions captured;
            CaptureStationInputs(alg, stations, options, out capturedStations, out captured);
            return CollectPilotCore(alg, buffers, null, capturedStations, captured, null,
                settings, onePass);
        }

        private static void CaptureStationInputs(Alignment alg, IList<double> stations,
            LasFilterOptions options, out double[] capturedStations,
            out LasFilterOptions capturedOptions)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (stations == null) throw new ArgumentNullException("stations");
            if (options == null) throw new ArgumentNullException("options");
            LasFilterOptions pinned = options.Copy();
            capturedStations = new double[stations.Count];
            for (int i = 0; i < stations.Count; i++)
            {
                if (!PointKey3D.IsFinite(stations[i]))
                    throw new ArgumentOutOfRangeException("stations");
                capturedStations[i] = stations[i];
            }
            double leftOffset = pinned.CentralLeftOffset ?? alg.DtmSizeLeft;
            double rightOffset = pinned.CentralRightOffset ?? alg.DtmSizeRight;
            if (!PointKey3D.IsFinite(leftOffset) || !PointKey3D.IsFinite(rightOffset))
                throw new ArgumentOutOfRangeException("options", "Offsets must be finite.");
            capturedOptions = new LasFilterOptions(pinned.Async,
                pinned.HalfBorder, leftOffset, rightOffset)
            {
                IncludePositiveSliceBorder = pinned.IncludePositiveSliceBorder
            };
        }

        private static OperationResult<List<Vector3D>> CollectPilotCore(Alignment alg,
            List<LidarBuffer> buffers, List<Section> sections, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            FilterOperationSnapshot settings, bool onePass)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (sections == null && stations == null) throw new ArgumentNullException("sections");
            if (options == null) throw new ArgumentNullException("options");
            if (settings == null) throw new ArgumentNullException("settings");
            options = options.Copy();

            if (!LidarBufferService.ValidateBuffers(buffers))
                return OperationResult<List<Vector3D>>.Failed(SectionStage.Collect,
                    new InvalidOperationException("Не найден источник точек LiDAR."));
            if ((sections != null ? sections.Count : stations.Count) == 0)
                return OperationResult<List<Vector3D>>.Empty();

            Func<bool> cancellation = delegate { return WaitProgress.CancellationPending; };
            OperationResult<LasSectionPoints[]> collection = null;
            bool cancelledDuringCollect = false;
            SectionStage currentStage = SectionStage.Collect;
            try
            {
                WaitProgress.BeginProgress("1/2 — Сбор точек LiDAR...", delegate
                {
                    collection = CollectAllSectionsCore(alg, buffers, sections, stations, options, filter,
                        onePass, cancellation);
                    cancelledDuringCollect = cancellation();
                }, true);
                if (collection == null)
                    return cancelledDuringCollect || cancellation()
                        ? OperationResult<List<Vector3D>>.Cancelled(SectionStage.Collect)
                        : OperationResult<List<Vector3D>>.Failed(SectionStage.Collect,
                            new InvalidOperationException("Сбор секций завершился без результата."));
                if (collection.Status != OperationStatus.Success)
                    return ForwardCollectionStatus(collection);
                if (cancelledDuringCollect || cancellation())
                    return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Collect);

                OperationResult<List<Vector3D>> result = null;
                bool cancelledDuringCalculate = false;
                SectionRequest request = new SectionRequest(collection.Value,
                    options.CentralLeftOffset ?? alg.DtmSizeLeft, options.Async, settings);
                currentStage = SectionStage.Filter;
                WaitProgress.BeginProgress("2/2 — Фильтрация и удаление дубликатов...", delegate
                {
                    result = SectionWorkflow.Calculate(request,
                        delegate(double offset, LasSectionPoints section, int index,
                            FilterOperationSnapshot snapshot)
                        {
                            GraphGroundDebugInfo debug;
                            return LasFilterService.ApplyFilter(offset, section, index,
                                out debug, null, snapshot);
                        }, cancellation,
                        delegate(SectionStage stage, float progress)
                        {
                            WaitProgress.ProgressChange(stage == SectionStage.Filter
                                ? progress * 0.7f : 0.7f + progress * 0.3f);
                        });
                    cancelledDuringCalculate = cancellation();
                }, true);
                if (result != null && result.Status == OperationStatus.Cancelled)
                    return result;
                if (cancelledDuringCalculate || cancellation())
                    return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Filter);
                return result ?? OperationResult<List<Vector3D>>.Failed(SectionStage.Filter,
                    new InvalidOperationException("Расчёт завершился без результата."));
            }
            catch (OperationCanceledException)
            {
                return OperationResult<List<Vector3D>>.Cancelled(currentStage);
            }
            catch (OutOfMemoryException error)
            {
                return OperationResult<List<Vector3D>>.Overflow(currentStage, error);
            }
            catch (Exception error)
            {
                return OperationResult<List<Vector3D>>.Failed(currentStage, error);
            }
        }

        public static OperationResult<List<Vector3D>> Collect(Alignment alg, List<LidarBuffer> buffers,
            List<Section> sections, LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            FilterOperationSnapshot settings, bool onePass)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (sections == null) throw new ArgumentNullException("sections");
            return CollectCore(alg, buffers, sections, null, options, filter, settings, onePass);
        }

        // Keep generated sections on the original three-stage filter/deduplicate path.
        // Only the collection input changes from registered Sections to station values.
        internal static OperationResult<List<Vector3D>> CollectAtStations(Alignment alg,
            List<LidarBuffer> buffers, IList<double> stations, LasFilterOptions options,
            FilterOperationSnapshot settings, bool onePass)
        {
            double[] capturedStations;
            LasFilterOptions captured;
            CaptureStationInputs(alg, stations, options, out capturedStations, out captured);
            return CollectCore(alg, buffers, null, capturedStations, captured, null,
                settings, onePass);
        }

        private static OperationResult<List<Vector3D>> CollectCore(Alignment alg,
            List<LidarBuffer> buffers, List<Section> sections, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            FilterOperationSnapshot settings, bool onePass)
        {
            if (alg == null) throw new ArgumentNullException("alg");
            if (sections == null && stations == null) throw new ArgumentNullException("sections");
            if (options == null) throw new ArgumentNullException("options");
            if (settings == null) throw new ArgumentNullException("settings");
            options = options.Copy();
            if (!LidarBufferService.ValidateBuffers(buffers))
                return OperationResult<List<Vector3D>>.Failed(SectionStage.Collect,
                    new InvalidOperationException("Не найден источник точек LiDAR."));
            if ((sections != null ? sections.Count : stations.Count) == 0)
                return OperationResult<List<Vector3D>>.Empty();

            bool parallel = options.Async;
            double originOffset = sections != null
                ? alg.DtmSizeLeft : options.CentralLeftOffset.Value;
            OperationResult<LasSectionPoints[]> collection = null;
            List<Vector3D> filtered = null;
            List<Vector3D> result = null;
            Func<bool> cancellation = delegate { return WaitProgress.CancellationPending; };
            bool cancelledDuringStage = false;
            SectionStage currentStage = SectionStage.Collect;
            try
            {
                WaitProgress.BeginProgress("1/3 — Сбор точек LiDAR...", delegate
                {
                    collection = CollectAllSectionsCore(alg, buffers, sections, stations, options,
                        filter, onePass, cancellation);
                    cancelledDuringStage = cancellation();
                }, true);
                if (collection == null)
                    return cancelledDuringStage || cancellation()
                        ? OperationResult<List<Vector3D>>.Cancelled(SectionStage.Collect)
                        : OperationResult<List<Vector3D>>.Failed(SectionStage.Collect,
                            new InvalidOperationException("Сбор секций завершился без результата."));
                if (collection.Status != OperationStatus.Success)
                    return ForwardCollectionStatus(collection);
                if (cancelledDuringStage || cancellation())
                    return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Collect);

                currentStage = SectionStage.Filter;
                cancelledDuringStage = false;
                WaitProgress.BeginProgress("2/3 — Фильтрация точек...", delegate
                {
                    filtered = FilterAllSections(originOffset, collection.Value, parallel, cancellation, settings);
                    cancelledDuringStage = cancellation();
                }, true);
                if (cancelledDuringStage || cancellation())
                    return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Filter);
                if (filtered == null)
                    return OperationResult<List<Vector3D>>.Failed(SectionStage.Filter,
                        new InvalidOperationException("Фильтрация завершилась без результата."));

                currentStage = SectionStage.Deduplicate;
                cancelledDuringStage = false;
                WaitProgress.BeginProgress("3/3 — Удаление дубликатов...", delegate
                {
                    result = RemoveDuplicatesByXY(filtered, cancellation);
                    cancelledDuringStage = cancellation();
                }, true);
                if (cancelledDuringStage || cancellation())
                    return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Deduplicate);
                if (result == null)
                    return OperationResult<List<Vector3D>>.Failed(SectionStage.Deduplicate,
                        new InvalidOperationException("Удаление дубликатов завершилось без результата."));
                return result.Count == 0
                    ? OperationResult<List<Vector3D>>.Empty()
                    : OperationResult<List<Vector3D>>.Succeeded(result);
            }
            catch (OperationCanceledException)
            {
                return OperationResult<List<Vector3D>>.Cancelled(currentStage);
            }
            catch (OutOfMemoryException error)
            {
                return OperationResult<List<Vector3D>>.Overflow(currentStage, error);
            }
            catch (Exception error)
            {
                return OperationResult<List<Vector3D>>.Failed(currentStage, error);
            }
        }

        private static OperationResult<LasSectionPoints[]> CollectAllSectionsCore(
            Alignment alg, List<LidarBuffer> buffers, List<Section> sections, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, List<Vector2D>, bool> filter,
            bool onePass, Func<bool> cancellation)
        {
            int count = sections != null ? sections.Count : stations.Count;
            if (onePass)
            {
                LasSectionPoints[] onePassSections = sections != null
                    ? OnePassSectionCollector.CollectAllSections(alg, buffers, sections,
                        options, filter, delegate(float p) { WaitProgress.ProgressChange(p); },
                        cancellation)
                    : OnePassSectionCollector.CollectAllAtStations(alg, buffers, stations,
                        options, delegate(float p) { WaitProgress.ProgressChange(p); },
                        cancellation);
                if (onePassSections == null)
                    return cancellation()
                        ? OperationResult<LasSectionPoints[]>.Cancelled(SectionStage.Collect)
                        : OperationResult<LasSectionPoints[]>.Failed(SectionStage.Collect,
                            new InvalidOperationException("OnePass collection returned no result."));
                return OperationResult<LasSectionPoints[]>.Succeeded(onePassSections);
            }

            // SDK traversal and corridor context construction remain serial until the
            // host documents concurrent access. Pure filtering below can still run in parallel.
            LasSectionPoints[] collected = new LasSectionPoints[count];
            for (int i = 0; i < count; i++)
            {
                if (cancellation()) return OperationResult<LasSectionPoints[]>.Cancelled(SectionStage.Collect);
                // The no-raw overload avoids allocating a discarded Vector4D list.
                SectionCollectStatus status;
                collected[i] = sections != null
                    ? LasSectionPointsCollectorService.Collect(alg, buffers, sections[i],
                        options, filter, cancellation, out status)
                    : LasSectionPointsCollectorService.CollectAtStation(alg, buffers,
                        stations[i], options, cancellation, out status);
                if (status == SectionCollectStatus.Overflow)
                    return OperationResult<LasSectionPoints[]>.Overflow(SectionStage.Collect,
                        new OutOfMemoryException("The per-section point limit was exceeded."));
                if (status == SectionCollectStatus.Cancelled)
                    return OperationResult<LasSectionPoints[]>.Cancelled(SectionStage.Collect);
                WaitProgress.ProgressChange((i + 1) / (float)count);
            }
            return cancellation()
                ? OperationResult<LasSectionPoints[]>.Cancelled(SectionStage.Collect)
                : OperationResult<LasSectionPoints[]>.Succeeded(collected);
        }

        private static OperationResult<List<Vector3D>> ForwardCollectionStatus(
            OperationResult<LasSectionPoints[]> collection)
        {
            if (collection.Status == OperationStatus.Cancelled)
                return OperationResult<List<Vector3D>>.Cancelled(SectionStage.Collect);
            if (collection.Status == OperationStatus.Overflow)
                return OperationResult<List<Vector3D>>.Overflow(SectionStage.Collect,
                    collection.Error as OutOfMemoryException ?? new OutOfMemoryException(collection.Error.Message));
            if (collection.Status == OperationStatus.Empty)
                return OperationResult<List<Vector3D>>.Empty();
            return OperationResult<List<Vector3D>>.Failed(SectionStage.Collect,
                collection.Error ?? new InvalidOperationException("Collection failed without an error."));
        }

        private static List<Vector3D> FilterAllSections(double originOffset, LasSectionPoints[] collected,
            bool parallel, Func<bool> cancellation, FilterOperationSnapshot filterSettings)
        {
            int count = collected.Length;
            List<Vector3D>[] sectionResults = new List<Vector3D>[count];
            bool completed = ParallelWorkRunner.Run(count, parallel,
                delegate(int index, WorkCancellation stop)
                {
                    if (stop.IsCancellationRequested) return;
                    GraphGroundDebugInfo unused;
                    sectionResults[index] = LasFilterService.ApplyFilter(
                        originOffset, collected[index], index, out unused, null, filterSettings);
                    // Release the raw section as soon as its filter has finished.
                    collected[index].SectionPoints = null;
                }, cancellation,
                delegate(float progress) { WaitProgress.ProgressChange(progress); });
            if (!completed) return null;

            long capacity = 0;
            for (int i = 0; i < count; i++)
                if (sectionResults[i] != null) capacity += sectionResults[i].Count;
            if (capacity > int.MaxValue)
                throw new OutOfMemoryException("The filtered point count exceeds List capacity.");
            List<Vector3D> merged = new List<Vector3D>((int)capacity);
            for (int i = 0; i < count; i++)
            {
                if (cancellation()) return null;
                if (sectionResults[i] != null) merged.AddRange(sectionResults[i]);
                sectionResults[i] = null;
            }
            return merged;
        }

        private static List<Vector3D> RemoveDuplicatesByXY(List<Vector3D> input, Func<bool> cancellation)
        {
            HashSet<PointKey2D> unique = new HashSet<PointKey2D>();
            List<Vector3D> result = new List<Vector3D>();
            int reportEvery = Math.Max(1, input.Count / 100);
            for (int i = 0; i < input.Count; i++)
            {
                if ((i & 1023) == 0 && cancellation()) return null;
                Vector3D point = input[i];
                if (unique.Add(PointKey2D.Millimetre(point.X, point.Y))) result.Add(point);
                if (i % reportEvery == 0) WaitProgress.ProgressChange((i + 1) / (float)input.Count);
            }
            if (cancellation()) return null;
            WaitProgress.ProgressChange(1.0f);
            return result;
        }
    }
}
