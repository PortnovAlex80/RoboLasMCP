using System;
using System.Collections.Generic;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Application
{
    internal delegate List<Vector3D> SectionFilter(
        double defaultOriginOffset, LasSectionPoints section, int sectionIndex,
        FilterOperationSnapshot settings);

    /// <summary>
    /// Calculates and deduplicates already collected sections. No UI or CAD
    /// object is accessed here. Progress runs on the caller thread; the filter
    /// delegate must be pure and must not access UI or mutable SDK objects.
    /// </summary>
    internal static class SectionWorkflow
    {
        internal static OperationResult<List<Vector3D>> Calculate(
            SectionRequest request, SectionFilter filter,
            Func<bool> cancellationPending, Action<SectionStage, float> progress)
        {
            if (request == null) throw new ArgumentNullException("request");
            if (filter == null) throw new ArgumentNullException("filter");

            SectionStage stage = SectionStage.Filter;
            try
            {
                if (IsCancelled(cancellationPending))
                    return OperationResult<List<Vector3D>>.Cancelled(stage);

                int count = request.Sections.Length;
                List<Vector3D>[] sectionResults = new List<Vector3D>[count];
                bool completed = ParallelWorkRunner.Run(count, request.Parallel,
                    delegate(int index, WorkCancellation stop)
                    {
                        if (stop.IsCancellationRequested) return;
                        sectionResults[index] = filter(request.DefaultOriginOffset,
                            request.Sections[index], index, request.FilterSettings);
                        if (sectionResults[index] == null)
                            throw new InvalidOperationException("The section filter returned null.");
                        request.Sections[index].SectionPoints = null;
                    }, cancellationPending,
                    delegate(float value) { Report(progress, stage, value); });

                if (!completed || IsCancelled(cancellationPending))
                    return OperationResult<List<Vector3D>>.Cancelled(stage);

                stage = SectionStage.Deduplicate;
                long total = 0;
                for (int i = 0; i < count; i++)
                {
                    total += sectionResults[i].Count;
                    if (total > int.MaxValue)
                        throw new OutOfMemoryException("The filtered point count exceeds List capacity.");
                }

                HashSet<PointKey2D> seen = new HashSet<PointKey2D>();
                List<Vector3D> result = new List<Vector3D>();
                long processed = 0;
                int reportEvery = Math.Max(1, (int)(total / 100));
                Report(progress, stage, total == 0 ? 1.0f : 0.0f);

                for (int sectionIndex = 0; sectionIndex < count; sectionIndex++)
                {
                    List<Vector3D> points = sectionResults[sectionIndex];
                    for (int pointIndex = 0; pointIndex < points.Count; pointIndex++)
                    {
                        if ((processed & 1023) == 0 && IsCancelled(cancellationPending))
                            return OperationResult<List<Vector3D>>.Cancelled(stage);
                        Vector3D point = points[pointIndex];
                        if (seen.Add(PointKey2D.Millimetre(point.X, point.Y)))
                            result.Add(point);
                        processed++;
                        if (processed % reportEvery == 0)
                            Report(progress, stage, processed / (float)total);
                    }
                    sectionResults[sectionIndex] = null;
                }

                if (IsCancelled(cancellationPending))
                    return OperationResult<List<Vector3D>>.Cancelled(stage);
                Report(progress, stage, 1.0f);
                return result.Count == 0
                    ? OperationResult<List<Vector3D>>.Empty()
                    : OperationResult<List<Vector3D>>.Succeeded(result);
            }
            catch (OutOfMemoryException error)
            {
                return OperationResult<List<Vector3D>>.Overflow(stage, error);
            }
            catch (Exception error)
            {
                return OperationResult<List<Vector3D>>.Failed(stage, error);
            }
        }

        private static bool IsCancelled(Func<bool> cancellationPending)
        {
            return cancellationPending != null && cancellationPending();
        }

        private static void Report(Action<SectionStage, float> progress,
            SectionStage stage, float value)
        {
            if (progress != null) progress(stage, value);
        }
    }
}
