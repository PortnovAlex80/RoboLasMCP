using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Collector;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service.Collector;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    internal static class CollectionStatusTests
    {
        private static int checks;

        private static void Check(bool condition, string name)
        {
            checks++;
            if (!condition) throw new Exception(name);
        }

        private static LasFilterOptions Options()
        {
            return LasFilterOptions.FromThickness(2.0, false);
        }

        private static LidarBuffer NormalBuffer()
        {
            LidarBuffer buffer = new LidarBuffer();
            buffer.Points.Add(new Vector4D(5, 0, 3, 10));
            buffer.Points.Add(new Vector4D(5, 0, 3, 20));
            buffer.Points.Add(new Vector4D(5, 0, 4, 30));
            buffer.Points.Add(new Vector4D(5, 1, 5, 40)); // open slice boundary
            return buffer;
        }

        private static void NormalAndEmpty()
        {
            Alignment alg = new Alignment();
            Section section = new Section();
            LidarBuffer buffer = NormalBuffer();
            List<Vector4D> raw;
            SectionCollectStatus status;
            LasSectionPoints result = LasSectionPointsCollectorService.Collect(
                alg, new List<LidarBuffer> { buffer }, section, Options(), out raw,
                null, delegate { return false; }, out status);
            Check(status == SectionCollectStatus.Success, "normal status");
            Check(result.SectionPoints.Count == 3 && raw.Count == 3, "source order count");
            Check(raw[0].W == 10 && raw[1].W == 20 && raw[2].W == 30,
                "source order and weights");
            Check(result.SectionPoints[0].X == 5 && result.SectionPoints[0].Y == 3 &&
                result.SectionPoints[2].Y == 4, "section projection");

            List<Section> sections = new List<Section> { section };
            OperationResult<List<Vector4D>> dedup = RawPointsCollector.Collect(
                alg, new List<LidarBuffer> { buffer }, sections, Options(), null);
            Check(dedup.Status == OperationStatus.Success && dedup.Value.Count == 2,
                "raw dedup status and count");
            Check(dedup.Value[0].W == 10 && dedup.Value[1].W == 30,
                "first weight survives exact XYZ dedup");
            OperationResult<List<Vector4D>> noDedup = RawPointsCollector.CollectNoDedup(
                alg, new List<LidarBuffer> { buffer }, sections, Options(), null);
            Check(noDedup.Status == OperationStatus.Success && noDedup.Value.Count == 3 &&
                noDedup.Value[1].W == 20, "no-dedup order");

            alg.Plan.CompoundLine.Valid = false;
            result = LasSectionPointsCollectorService.Collect(
                alg, new List<LidarBuffer> { buffer }, section, Options(), out raw,
                null, delegate { return false; }, out status);
            Check(status == SectionCollectStatus.Success && raw != null && raw.Count == 0 &&
                result.SectionPoints != null && result.SectionPoints.Count == 0,
                "invalid section geometry is a valid empty result");
            OperationResult<List<Vector4D>> empty = RawPointsCollector.Collect(
                alg, new List<LidarBuffer> { buffer }, sections, Options(), null);
            Check(empty.Status == OperationStatus.Empty, "raw empty is distinct from cancel");
            alg.Plan.CompoundLine.Valid = true;
        }

        private static void CancellationInsideCallback()
        {
            Alignment alg = new Alignment();
            Section section = new Section();
            LidarBuffer buffer = new LidarBuffer();
            for (int i = 0; i < 1025; i++)
                buffer.Points.Add(new Vector4D(5, 0, i, i));
            buffer.OnPoint = delegate(int index)
            {
                if (index == 1) WaitProgress.CancellationPending = true;
            };
            WaitProgress.CancellationPending = false;
            List<Vector4D> raw;
            SectionCollectStatus status;
            LasSectionPoints result = LasSectionPointsCollectorService.Collect(
                alg, new List<LidarBuffer> { buffer }, section, Options(), out raw,
                null, delegate { return WaitProgress.CancellationPending; }, out status);
            Check(status == SectionCollectStatus.Cancelled, "callback cancellation status");
            Check(raw == null && result.SectionPoints == null, "cancelled partial payload hidden");

            WaitProgress.CancellationPending = false;
            OperationResult<List<Vector4D>> outcome = RawPointsCollector.Collect(
                alg, new List<LidarBuffer> { buffer }, new List<Section> { section },
                Options(), null);
            Check(outcome.Status == OperationStatus.Cancelled && outcome.Value == null,
                "raw collector does not return partial points after callback cancellation");
            WaitProgress.CancellationPending = false;
        }

        private static void StationOnlyRawParity()
        {
            Alignment alg = new Alignment();
            Section section = new Section { Station = 2.5 };
            List<LidarBuffer> buffers = new List<LidarBuffer> { NormalBuffer() };
            List<Vector4D> oldRaw;
            List<Vector4D> newRaw;
            SectionCollectStatus oldStatus, newStatus;
            LasSectionPoints oldResult = LasSectionPointsCollectorService.Collect(
                alg, buffers, section, Options(), out oldRaw, null,
                delegate { return false; }, out oldStatus);
            alg.Corridor.Sections.ThrowOnRead = true;
            LasSectionPoints newResult = LasSectionPointsCollectorService.CollectRawAtStation(
                alg, buffers, 2.5, Options(), out newRaw,
                delegate { return false; }, out newStatus);
            List<Vector4D> streamedRaw = new List<Vector4D>();
            SectionCollectStatus streamedStatus;
            LasSectionPointsCollectorService.StreamRawAtStation(
                alg, buffers, 2.5, Options(), streamedRaw.Add,
                delegate { return false; }, out streamedStatus);
            Check(oldStatus == SectionCollectStatus.Success &&
                newStatus == oldStatus && alg.Plan.CompoundLine.LastStation == 2.5,
                "station collection uses requested station without section lookup");
            Check(streamedStatus == oldStatus && streamedRaw.Count == oldRaw.Count,
                "unfiltered streamed station status/count changed");
            Check(newRaw.Count == oldRaw.Count &&
                newResult.SectionPoints.Count == oldResult.SectionPoints.Count,
                "station raw count and open slice boundary match section path");
            for (int i = 0; i < oldRaw.Count; i++)
            {
                Check(newRaw[i].X == oldRaw[i].X && newRaw[i].Y == oldRaw[i].Y &&
                    newRaw[i].Z == oldRaw[i].Z && newRaw[i].W == oldRaw[i].W &&
                    newResult.SectionPoints[i].X == oldResult.SectionPoints[i].X &&
                    newResult.SectionPoints[i].Y == oldResult.SectionPoints[i].Y,
                    "station path changed raw tuple, weight, projection or order");
                Check(streamedRaw[i].X == oldRaw[i].X &&
                    streamedRaw[i].Y == oldRaw[i].Y &&
                    streamedRaw[i].Z == oldRaw[i].Z &&
                    streamedRaw[i].W == oldRaw[i].W,
                    "unfiltered stream changed raw tuple or order");
            }
            Check(newRaw[0].W == 10 && newRaw[1].W == 20 && newRaw[2].W == 30,
                "station path preserves duplicate XYZ with different weights");
            LidarBuffer edges = new LidarBuffer();
            edges.Points.Add(new Vector4D(0, 0, 1, 101));
            edges.Points.Add(new Vector4D(10, 0, 2, 102));
            edges.Points.Add(new Vector4D(5, 1, 3, 103));
            edges.Points.Add(new Vector4D(5, -1, 4, 104));
            LasSectionPointsCollectorService.CollectRawAtStation(
                alg, new List<LidarBuffer> { edges }, 2.5, Options(), out newRaw,
                delegate { return false; }, out newStatus);
            Check(newStatus == SectionCollectStatus.Success && newRaw.Count == 2 &&
                newRaw[0].W == 101 && newRaw[1].W == 102,
                "station slice keeps along endpoints and excludes both open borders");
            bool invalidRejected = false;
            try
            {
                LasSectionPointsCollectorService.CollectRawAtStation(
                    alg, buffers, Double.NaN, Options(), out newRaw,
                    delegate { return false; }, out newStatus);
            }
            catch (ArgumentOutOfRangeException) { invalidRejected = true; }
            Check(invalidRejected, "nonfinite station rejected before SDK call");
        }

        private static void StationOnlyGroundParity()
        {
            Alignment alg = new Alignment();
            Section section = new Section { Station = 2.5 };
            List<LidarBuffer> buffers = new List<LidarBuffer> { NormalBuffer() };
            SectionCollectStatus oldStatus, newStatus;
            LasSectionPoints oldResult = LasSectionPointsCollectorService.Collect(
                alg, buffers, section, Options(), null,
                delegate { return false; }, out oldStatus);
            alg.Corridor.Sections.ThrowOnRead = true;
            LasSectionPoints newResult = LasSectionPointsCollectorService.CollectAtStation(
                alg, buffers, 2.5, Options(), delegate { return false; }, out newStatus);
            Check(oldStatus == SectionCollectStatus.Success && newStatus == oldStatus,
                "ground station status matches section path without corridor read");
            Check(oldResult.SectionPoints.Count == newResult.SectionPoints.Count &&
                newResult.SectionPoints.Count == 3, "ground station point count");
            Check(oldResult.LeftMostPoint.X == newResult.LeftMostPoint.X &&
                oldResult.LeftMostPoint.Y == newResult.LeftMostPoint.Y &&
                oldResult.RightMostPoint.X == newResult.RightMostPoint.X &&
                oldResult.RightMostPoint.Y == newResult.RightMostPoint.Y &&
                oldResult.Direction.X == newResult.Direction.X &&
                oldResult.Direction.Y == newResult.Direction.Y &&
                oldResult.OriginOffset == newResult.OriginOffset,
                "ground station geometry matches section path");
            for (int i = 0; i < oldResult.SectionPoints.Count; i++)
                Check(oldResult.SectionPoints[i].X == newResult.SectionPoints[i].X &&
                    oldResult.SectionPoints[i].Y == newResult.SectionPoints[i].Y,
                    "ground station point tuple and order");

            bool invalidRejected = false;
            try
            {
                LasSectionPointsCollectorService.CollectAtStation(
                    alg, buffers, Double.PositiveInfinity, Options(),
                    delegate { return false; }, out newStatus);
            }
            catch (ArgumentOutOfRangeException) { invalidRejected = true; }
            Check(invalidRejected, "ground station rejects nonfinite input before SDK call");
            newResult = LasSectionPointsCollectorService.CollectAtStation(
                alg, buffers, 2.5, Options(), delegate { return true; }, out newStatus);
            Check(newStatus == SectionCollectStatus.Cancelled &&
                newResult.SectionPoints == null, "ground station cancels without partial points");
        }

        private static void OverflowAndIsolation()
        {
            Alignment alg = new Alignment();
            Section section = new Section();
            LidarBuffer failing = NormalBuffer();
            failing.OnPoint = delegate(int index)
            {
                if (index == 1) throw new OutOfMemoryException("SDK callback probe");
            };
            List<Vector4D> raw;
            SectionCollectStatus firstStatus;
            LasSectionPoints partial = LasSectionPointsCollectorService.Collect(
                alg, new List<LidarBuffer> { failing }, section, Options(), out raw,
                null, delegate { return false; }, out firstStatus);
            Check(firstStatus == SectionCollectStatus.Overflow, "callback OOM status");
            Check(raw == null && partial.SectionPoints == null, "OOM partial payload hidden");

            SectionCollectStatus secondStatus;
            LasSectionPoints complete = LasSectionPointsCollectorService.Collect(
                alg, new List<LidarBuffer> { NormalBuffer() }, section, Options(), out raw,
                null, delegate { return false; }, out secondStatus);
            Check(firstStatus == SectionCollectStatus.Overflow &&
                secondStatus == SectionCollectStatus.Success && complete.SectionPoints.Count == 3,
                "later call cannot overwrite earlier status");
            OperationResult<List<Vector4D>> overflow = RawPointsCollector.Collect(
                alg, new List<LidarBuffer> { failing }, new List<Section> { section },
                Options(), null);
            Check(overflow.Status == OperationStatus.Overflow && overflow.Value == null,
                "raw collector maps OOM to overflow");

            LidarBuffer broken = NormalBuffer();
            broken.OnPoint = delegate(int index)
            {
                if (index == 1) throw new InvalidOperationException("SDK traversal probe");
            };
            OperationResult<List<Vector4D>> failed = RawPointsCollector.Collect(
                alg, new List<LidarBuffer> { broken }, new List<Section> { section },
                Options(), null);
            Check(failed.Status == OperationStatus.Failed && failed.Value == null &&
                failed.Error is InvalidOperationException, "unexpected SDK failure is explicit");

            Check(!LasSectionPointsCollectorService.ReachedPointLimit(1, 2) &&
                LasSectionPointsCollectorService.ReachedPointLimit(2, 2),
                "production point-cap comparison includes exact limit");
        }

        private static void OffsetSplitParity()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 3.0;
            alg.DtmSizeRight = 7.0;
            LidarBuffer buffer = new LidarBuffer();
            buffer.Points.Add(new Vector4D(-2.1, 0, 1, 101));
            buffer.Points.Add(new Vector4D(-2.0, 0, 2, 102));
            buffer.Points.Add(new Vector4D(0, 0, 3, 103));
            buffer.Points.Add(new Vector4D(0, 0, 3, 104));
            buffer.Points.Add(new Vector4D(4.0, 0, 4, 105));
            buffer.Points.Add(new Vector4D(4.1, 0, 5, 106));
            buffer.Points.Add(new Vector4D(0, 1, 6, 107));
            buffer.Points.Add(new Vector4D(0, -1, 7, 108));
            List<LidarBuffer> buffers = new List<LidarBuffer> { buffer };
            List<Section> sections = new List<Section> {
                new Section { Station = 0 }, new Section { Station = 1 }
            };
            List<double> stations = new List<double> { 0, 1 };
            Func<Vector2D, List<Vector2D>, bool> oldOuter =
                delegate(Vector2D p, List<Vector2D> ignored) {
                    return p.X < -2.0 || p.X > 4.0;
                };
            Func<Vector2D, List<Vector2D>, bool> oldInner =
                delegate(Vector2D p, List<Vector2D> ignored) {
                    return p.X > -2.0 && p.X < 4.0;
                };
            OperationResult<List<Vector4D>> oldEdge = RawPointsCollector.Collect(
                alg, buffers, sections, Options(), oldOuter);
            OperationResult<List<Vector4D>> oldCenter = RawPointsCollector.Collect(
                alg, buffers, sections, Options(), oldInner);
            alg.Corridor.Sections.ThrowOnRead = true;
            OperationResult<List<Vector4D>> edge = RawPointsCollector.CollectAtStations(
                alg, buffers, stations, Options(),
                delegate(Vector2D p) { return p.X < -2.0 || p.X > 4.0; }, null);
            OperationResult<List<Vector4D>> center = RawPointsCollector.CollectAtStations(
                alg, buffers, stations, Options(),
                delegate(Vector2D p) { return p.X > -2.0 && p.X < 4.0; }, null);
            Check(oldEdge.Status == OperationStatus.Success &&
                oldCenter.Status == OperationStatus.Success &&
                edge.Status == oldEdge.Status && center.Status == oldCenter.Status,
                "split station path should work without corridor section lookup");
            Check(edge.Value.Count == oldEdge.Value.Count && edge.Value.Count == 2 &&
                center.Value.Count == oldCenter.Value.Count && center.Value.Count == 1,
                "split cutoffs or exact XYZ dedup changed");
            for (int i = 0; i < edge.Value.Count; i++)
                Check(edge.Value[i].X == oldEdge.Value[i].X &&
                    edge.Value[i].Y == oldEdge.Value[i].Y &&
                    edge.Value[i].Z == oldEdge.Value[i].Z &&
                    edge.Value[i].W == oldEdge.Value[i].W,
                    "outer tuple or order changed");
            Check(center.Value[0].X == oldCenter.Value[0].X &&
                center.Value[0].Y == oldCenter.Value[0].Y &&
                center.Value[0].Z == oldCenter.Value[0].Z &&
                center.Value[0].W == 103 &&
                center.Value[0].W == oldCenter.Value[0].W,
                "inner tuple or first weight changed");
            Check(edge.Value[0].W == 101 && edge.Value[1].W == 106,
                "points on classification cutoffs must belong to neither output");
        }

        private static void StationCollectorTerminalStatuses()
        {
            Alignment alg = new Alignment();
            alg.Corridor.Sections.ThrowOnRead = true;
            List<double> stations = new List<double> { 0 };
            LidarBuffer cancel = new LidarBuffer();
            for (int i = 0; i < 1025; i++)
                cancel.Points.Add(new Vector4D(5, 0, i, i));
            cancel.OnPoint = delegate(int index) {
                if (index == 1) WaitProgress.CancellationPending = true;
            };
            WaitProgress.CancellationPending = false;
            OperationResult<List<Vector4D>> outcome = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { cancel }, stations, Options(),
                delegate(Vector2D p) { return true; }, null);
            Check(outcome.Status == OperationStatus.Cancelled && outcome.Value == null,
                "station collector exposed partial canceled output");
            WaitProgress.CancellationPending = false;

            LidarBuffer overflow = NormalBuffer();
            overflow.OnPoint = delegate(int index) {
                if (index == 1) throw new OutOfMemoryException("fixture");
            };
            outcome = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { overflow }, stations, Options(),
                delegate(Vector2D p) { return true; }, null);
            Check(outcome.Status == OperationStatus.Overflow && outcome.Value == null,
                "station collector lost overflow status");

            LidarBuffer broken = NormalBuffer();
            broken.OnPoint = delegate(int index) {
                if (index == 1) throw new InvalidOperationException("fixture");
            };
            outcome = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { broken }, stations, Options(),
                delegate(Vector2D p) { return true; }, null);
            Check(outcome.Status == OperationStatus.Failed && outcome.Value == null &&
                outcome.Error is InvalidOperationException,
                "station collector lost unexpected fault");
        }

        private static void SplitSliceBoundaryOwnership()
        {
            Alignment alg = new Alignment();
            alg.Plan.CompoundLine.UseStationAsY = true;
            alg.Corridor.Sections.ThrowOnRead = true;
            LidarBuffer buffer = new LidarBuffer();
            buffer.OpenBox = true;
            double[] y = { -0.5, 0.0, 0.5, 1.0, 1.5 };
            for (int i = 0; i < y.Length; i++)
                buffer.Points.Add(new Vector4D(5, y[i], i, 10 + i));
            var stations = new List<double> { 0, 1, 2 };
            var options = LasFilterOptions.FromThickness(1.0, false);
            options.IncludePositiveSliceBorder = true;
            OperationResult<List<Vector4D>> result = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { buffer }, stations, options,
                delegate(Vector2D point) { return true; }, null);
            Check(result.Status == OperationStatus.Success && result.Value.Count == 5,
                "half-open split slices keep all exact seam points through open SDK box");
            for (int i = 0; i < y.Length; i++)
                Check(result.Value[i].Y == y[i] && result.Value[i].Z == i &&
                    result.Value[i].W == 10 + i,
                    "half-open split keeps source coordinates, weights, and station order");

            var legacy = LasFilterOptions.FromThickness(1.0, false);
            result = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { buffer }, stations, legacy,
                delegate(Vector2D point) { return true; }, null);
            Check(result.Status == OperationStatus.Success && result.Value.Count == 2 &&
                result.Value[0].Y == 0.0 && result.Value[1].Y == 1.0,
                "other commands retain legacy open-slice behavior");

            LidarBuffer routed = new LidarBuffer();
            routed.OpenBox = true;
            for (int x = 4; x <= 6; x++)
                routed.Points.Add(new Vector4D(x, 0.5, x, 20 + x));
            var source = new List<LidarBuffer> { routed };
            var pairStations = new List<double> { 0, 1 };
            OperationResult<List<Vector4D>> edge = RawPointsCollector.CollectAtStations(
                alg, source, pairStations, options,
                delegate(Vector2D p) { return p.X < 5 || p.X > 5; }, null);
            OperationResult<List<Vector4D>> center = RawPointsCollector.CollectAtStations(
                alg, source, pairStations, options,
                delegate(Vector2D p) { return p.X >= 5 && p.X <= 5; }, null);
            Check(edge.Status == OperationStatus.Success && edge.Value.Count == 2 &&
                center.Status == OperationStatus.Success && center.Value.Count == 1,
                "real collector partitions exact lateral and station boundaries");
            Check(edge.Value[0].X == 4 && edge.Value[1].X == 6 &&
                center.Value[0].X == 5 && center.Value[0].W == 25,
                "split outputs have full union, empty intersection, and source weights");

            var mutable = LasFilterOptions.FromThickness(1.0, false);
            mutable.IncludePositiveSliceBorder = true;
            bool changed = false;
            result = RawPointsCollector.CollectAtStations(
                alg, new List<LidarBuffer> { buffer }, stations, mutable,
                delegate(Vector2D point) { return true; },
                delegate(float progress)
                {
                    if (progress == 0.0f)
                    {
                        mutable.HalfBorder = 0.01;
                        mutable.IncludePositiveSliceBorder = false;
                        changed = true;
                    }
                });
            Check(changed && result.Status == OperationStatus.Success &&
                result.Value.Count == 5,
                "raw station collection pins slice options before progress callbacks");

            mutable = LasFilterOptions.FromThickness(1.0, false);
            mutable.IncludePositiveSliceBorder = true;
            changed = false;
            List<Vector4D> streamed = new List<Vector4D>();
            OperationResult<int> streamedStatus = RawPointsCollector.StreamAtStations(
                alg, new List<LidarBuffer> { buffer }, stations, mutable,
                delegate(Vector2D point) { return true; }, streamed.Add,
                delegate(float progress)
                {
                    if (progress == 0.0f)
                    {
                        mutable.HalfBorder = 0.01;
                        mutable.IncludePositiveSliceBorder = false;
                        changed = true;
                    }
                });
            Check(changed && streamedStatus.Status == OperationStatus.Success &&
                streamed.Count == 5,
                "streamed station collection pins slice options before progress callbacks");

            mutable = LasFilterOptions.FromThickness(1.0, false);
            mutable.IncludePositiveSliceBorder = true;
            buffer.OnPoint = delegate(int index)
            {
                if (index == 0)
                {
                    mutable.HalfBorder = 0.01;
                    mutable.IncludePositiveSliceBorder = false;
                }
            };
            try
            {
                List<Vector4D> direct;
                SectionCollectStatus directStatus;
                LasSectionPointsCollectorService.CollectRawAtStation(
                    alg, new List<LidarBuffer> { buffer }, 0.0, mutable,
                    out direct, delegate { return false; }, out directStatus);
                Check(directStatus == SectionCollectStatus.Success &&
                    direct.Count == 2 && direct[0].Y == -0.5 && direct[1].Y == 0.0,
                    "direct SDK callback cannot change the active slice options");
            }
            finally { buffer.OnPoint = null; }
        }

        private static void StreamCollectionParity()
        {
            Alignment alg = new Alignment();
            alg.Plan.CompoundLine.UseStationAsY = true;
            alg.Corridor.Sections.ThrowOnRead = true;
            LidarBuffer first = new LidarBuffer();
            first.OpenBox = true;
            first.Points.Add(new Vector4D(2, -0.5, 3, 11));
            first.Points.Add(new Vector4D(5, 0.5, 4, 12));
            first.Points.Add(new Vector4D(5, 0.5, 4, 13));
            first.Points.Add(new Vector4D(8, 1.5, 5, 14));
            LidarBuffer second = new LidarBuffer();
            second.OpenBox = true;
            second.Points.Add(new Vector4D(5, 0.5, 4, 99));
            second.Points.Add(new Vector4D(3, 1.0, 6, 15));
            second.Points.Add(new Vector4D(6, 1.0, 7, 16));
            List<LidarBuffer> buffers = new List<LidarBuffer> { first, second };
            List<double> stations = new List<double> { 0, 1, 2 };
            LasFilterOptions options = LasFilterOptions.FromThickness(1.0, false);
            options.IncludePositiveSliceBorder = true;
            Func<Vector2D, bool> filter = delegate(Vector2D p) { return p.X <= 6; };
            OperationResult<List<Vector4D>> baseline = RawPointsCollector.CollectAtStations(
                alg, buffers, stations, options, filter, null);
            List<Vector4D> streamed = new List<Vector4D>();
            OperationResult<int> outcome = RawPointsCollector.StreamAtStations(
                alg, buffers, stations, options, filter, streamed.Add, null);
            Check(outcome.Status == baseline.Status && outcome.Status == OperationStatus.Success &&
                outcome.Value == baseline.Value.Count && streamed.Count == baseline.Value.Count,
                "streamed collection status/count differ from list path");
            for (int i = 0; i < streamed.Count; i++)
                Check(streamed[i].X == baseline.Value[i].X &&
                    streamed[i].Y == baseline.Value[i].Y &&
                    streamed[i].Z == baseline.Value[i].Z &&
                    streamed[i].W == baseline.Value[i].W,
                    "streamed XYZ, weight or traversal order changed");
            Check(streamed.Count == 4 && streamed[1].W == 12,
                "streamed dedup did not keep the first weight across buffers/stations");

            List<Vector4D> raw;
            SectionCollectStatus oldStatus, newStatus;
            LasSectionPointsCollectorService.CollectRawAtStation(
                alg, buffers, 1, options, filter, out raw,
                delegate { return false; }, out oldStatus);
            List<Vector4D> rawStream = new List<Vector4D>();
            LasSectionPointsCollectorService.StreamRawAtStation(
                alg, buffers, 1, options, filter, rawStream.Add,
                delegate { return false; }, out newStatus);
            Check(newStatus == oldStatus && rawStream.Count == raw.Count,
                "streamed section slice differs from list path");
            for (int i = 0; i < raw.Count; i++)
                Check(rawStream[i].X == raw[i].X && rawStream[i].Y == raw[i].Y &&
                    rawStream[i].Z == raw[i].Z && rawStream[i].W == raw[i].W,
                    "streamed section point changed");

            WaitProgress.CancellationPending = false;
            streamed.Clear();
            outcome = RawPointsCollector.StreamAtStations(
                alg, buffers, stations, options, filter,
                delegate(Vector4D point) {
                    streamed.Add(point);
                    WaitProgress.CancellationPending = true;
                }, null);
            Check(outcome.Status == OperationStatus.Cancelled && streamed.Count == 1,
                "streamed cancellation returned a successful partial output");
            WaitProgress.CancellationPending = false;
            outcome = RawPointsCollector.StreamAtStations(
                alg, buffers, stations, options, filter,
                delegate(Vector4D point) { throw new IOException("sink fixture"); }, null);
            Check(outcome.Status == OperationStatus.Failed && outcome.Error is IOException,
                "streamed sink failure was hidden");
        }

        private static void LidarWeightExpansion()
        {
            for (int value = 0; value <= 255; value++)
                Check(LidarIntensity.ExpandNormalized(value / 255.0) == value * 257.0,
                    "normalized SDK weight did not round-trip through LAS intensity");
            List<Vector4D> points = new List<Vector4D> {
                new Vector4D(-10.5, 2000000.25, 42.125, 127.0 / 255.0),
                new Vector4D(9.5, -3.0, 0.0, 128.0 / 255.0)
            };
            LidarIntensity.ExpandInPlace(points);
            Check(points[0].X == -10.5 && points[0].Y == 2000000.25 &&
                points[0].Z == 42.125 && points[0].W == 32639 &&
                points[1].X == 9.5 && points[1].Y == -3.0 &&
                points[1].Z == 0.0 && points[1].W == 32896,
                "weight expansion changed coordinates or middle byte weights");
            bool invalidRejected = false;
            try { LidarIntensity.ExpandNormalized(1.01); }
            catch (ArgumentOutOfRangeException) { invalidRejected = true; }
            Check(invalidRejected, "invalid SDK weight was accepted as LAS intensity");
        }

        public static int Main(string[] args)
        {
            NormalAndEmpty();
            StationOnlyRawParity();
            StationOnlyGroundParity();
            CancellationInsideCallback();
            OverflowAndIsolation();
            OffsetSplitParity();
            StationCollectorTerminalStatuses();
            SplitSliceBoundaryOwnership();
            StreamCollectionParity();
            LidarWeightExpansion();
            Console.WriteLine("Collection status: " + checks + " checks passed.");
            return 0;
        }
    }
}
