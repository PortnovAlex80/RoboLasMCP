using System;
using System.Collections.Generic;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Service.Collector;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Automation
{
    public sealed class LasSectionProbePoint
    {
        public double X, Y, Z, Offset, Elevation, SliceDistance;
    }
    public sealed class LasSectionProbeResult
    {
        public string Alignment, CoordinateUnits = "meters", Selection = "raw_unfiltered";
        public double Station, Thickness, LeftOffset, RightOffset;
        public long TotalPoints;
        public int PointOffset, ReturnedPoints;
        public long? NextPointOffset;
        public List<LasSectionProbePoint> Points = new List<LasSectionProbePoint>();
        public SectionAxisDensity OffsetDensity, ElevationDensity, SliceDistanceDensity;
    }
    public static partial class LasAutomation
    {
        // No persistent section, terrain edit, filtering, thinning or setting change.
        public static LasSectionProbeResult GetSectionPoints(double station, double thickness,
            double binSize, double sliceBinSize, int pointOffset, int maxPoints)
        {
            if (double.IsNaN(station) || double.IsInfinity(station) || station < 0)
                throw new ArgumentOutOfRangeException("station", "Station must be finite, in meters from the alignment start.");
            if (double.IsNaN(thickness) || double.IsInfinity(thickness) || thickness <= 0)
                throw new ArgumentOutOfRangeException("thickness", "Thickness must be finite and positive.");
            if (pointOffset < 0 || maxPoints < 1 || maxPoints > 10000)
                throw new ArgumentOutOfRangeException("point_offset/max_points");
            var offsetStats = new SectionDensityAccumulator(binSize);
            var elevationStats = new SectionDensityAccumulator(binSize);
            var sliceStats = new SectionDensityAccumulator(sliceBinSize);
            using (EnterGate())
            {
                var view = RequireCadView();
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alg = RequireAlignment(receiver);
                    if (station > alg.Plan.CompoundLine.Length)
                        throw new ArgumentOutOfRangeException("station", "Station exceeds the active alignment length.");
                    double left = alg.DtmSizeLeft, right = alg.DtmSizeRight;
                    Vector2D leftPoint, rightPoint;
                    if (double.IsNaN(left) || double.IsInfinity(left) || left < 0 ||
                        double.IsNaN(right) || double.IsInfinity(right) || right < 0 ||
                        !alg.Plan.CompoundLine.StaOffsetToPos(station, -left, out leftPoint) ||
                        !alg.Plan.CompoundLine.StaOffsetToPos(station, right, out rightPoint))
                        throw new LasAutomationException("Cannot construct section geometry at this station.");
                    double dx = rightPoint.X - leftPoint.X, dy = rightPoint.Y - leftPoint.Y;
                    double length = Math.Sqrt(dx * dx + dy * dy);
                    if (double.IsNaN(length) || double.IsInfinity(length) || length < 1e-9)
                        throw new LasAutomationException("The section width is zero or invalid.");
                    double ux = dx / length, uy = dy / length;
                    // Validate requested bin counts before reading a potentially large cloud.
                    offsetStats.Finish(-left, length - left);
                    sliceStats.Finish(-thickness / 2, thickness / 2);
                    var buffers = LidarBufferService.CollectBuffers(alg);
                    if (buffers == null || buffers.Count == 0) throw new LasAutomationException(NoLidarSourceMessage);
                    var source = LasExportSourceContext.Capture(view, alg, buffers);
                    if (source == null || !source.IsCurrent()) throw new LasAutomationException(SourceChangedMessage);
                    var result = new LasSectionProbeResult { Alignment = alg.Alias, Station = station,
                        Thickness = thickness, LeftOffset = left, RightOffset = right, PointOffset = pointOffset };
                    SectionCollectStatus status;
                    LasSectionPointsCollectorService.StreamRawAtStation(alg, buffers, station,
                        LasFilterOptions.FromThickness(thickness, false), delegate(Vector4D p)
                        {
                            double px = p.X - leftPoint.X, py = p.Y - leftPoint.Y;
                            double offset = px * ux + py * uy - left;
                            double distance = px * uy - py * ux;
                            offsetStats.Add(offset); elevationStats.Add(p.Z); sliceStats.Add(distance);
                            if (result.TotalPoints >= pointOffset && result.Points.Count < maxPoints)
                                result.Points.Add(new LasSectionProbePoint { X = p.X, Y = p.Y, Z = p.Z,
                                    Offset = offset, Elevation = p.Z, SliceDistance = distance });
                            result.TotalPoints++;
                        }, null, out status);
                    if (status != SectionCollectStatus.Success)
                        throw new LasAutomationException("Section point limit exceeded. Use a thinner slice; partial statistics are not returned.");
                    if (!source.IsCurrent()) throw new LasAutomationException(SourceChangedMessage);
                    result.OffsetDensity = offsetStats.Finish(-left, length - left);
                    result.ElevationDensity = elevationStats.Finish(null, null);
                    result.SliceDistanceDensity = sliceStats.Finish(-thickness / 2, thickness / 2);
                    result.ReturnedPoints = result.Points.Count;
                    long next = (long)pointOffset + result.ReturnedPoints;
                    result.NextPointOffset = next < result.TotalPoints ? (long?)next : null;
                    return result;
                }
            }
        }
    }
}
