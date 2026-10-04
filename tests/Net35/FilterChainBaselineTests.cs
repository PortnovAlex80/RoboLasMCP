using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.Service.Filter;
using LAS_TERRAIN.Tests.Fixtures;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    // Compiled with the real production filter/service/workflow sources. Only
    // Topomatic value types, Alignment, and RuntimeConfig are test shims.
    internal static class FilterChainBaselineTests
    {
        private static int checks;
        private static bool record;

        private static void Check(bool condition, string message)
        {
            checks++;
            if (!condition) throw new Exception(message);
        }

        private static FilterOperationSnapshot Settings(bool spline, bool breaks,
            double tolerance)
        {
            return new FilterOperationSnapshot(
                spline, breaks, tolerance,
                1.0, 1.0, 1,
                5, 8, 0.175, 0.80, 6, 5,
                3, 8, 0.25, 0.0, 0.25, 1e-4,
                256, 1e-9, 1.0, false, 0.3);
        }

        private static void AddDouble(ref ulong hash, double value)
        {
            byte[] data = BitConverter.GetBytes(value);
            for (int i = 0; i < data.Length; i++)
                hash = unchecked((hash ^ data[i]) * 1099511628211UL);
        }

        private static void AddInt(ref ulong hash, int value)
        {
            byte[] data = BitConverter.GetBytes(value);
            for (int i = 0; i < data.Length; i++)
                hash = unchecked((hash ^ data[i]) * 1099511628211UL);
        }

        private static string Signature(List<Vector2D> points)
        {
            ulong hash = 14695981039346656037UL;
            for (int i = 0; i < points.Count; i++)
            {
                AddDouble(ref hash, points[i].X);
                AddDouble(ref hash, points[i].Y);
            }
            return hash.ToString("x16");
        }

        private static string Signature3(List<Vector3D> points)
        {
            ulong hash = 14695981039346656037UL;
            for (int i = 0; i < points.Count; i++)
            {
                AddDouble(ref hash, points[i].X);
                AddDouble(ref hash, points[i].Y);
                AddDouble(ref hash, points[i].Z);
            }
            return hash.ToString("x16");
        }

        private static string DebugSignature(GraphGroundDebugInfo debug)
        {
            ulong hash = 14695981039346656037UL;
            AddInt(ref hash, debug.NX);
            AddInt(ref hash, debug.NY);
            AddDouble(ref hash, debug.XMin);
            AddDouble(ref hash, debug.YMin);
            AddDouble(ref hash, debug.BinX);
            AddDouble(ref hash, debug.BinY);
            AddInt(ref hash, debug.MaxCount);
            AddInt(ref hash, debug.InputPointCount);
            AddInt(ref hash, debug.OutputPointCount);
            AddInt(ref hash, debug.MinPts);
            for (int i = 0; i < debug.Grid.Length; i++) AddInt(ref hash, debug.Grid[i]);
            for (int i = 0; i < debug.Path.Length; i++) AddInt(ref hash, debug.Path[i]);
            for (int i = 0; i < debug.KeepMask.Length; i++)
                AddInt(ref hash, debug.KeepMask[i] ? 1 : 0);
            for (int i = 0; i < debug.CellType.Length; i++)
                AddInt(ref hash, debug.CellType[i]);
            AddInt(ref hash, debug.Cols == null ? -1 : debug.Cols.Length);
            for (int i = 0; debug.Cols != null && i < debug.Cols.Length; i++)
            {
                AddInt(ref hash, debug.Cols[i].Count);
                for (int j = 0; j < debug.Cols[i].Count; j++)
                    AddInt(ref hash, debug.Cols[i][j]);
            }
            return hash.ToString("x16");
        }

        private static void Case(string name, List<Vector2D> points,
            FilterOperationSnapshot settings, int count, string geometry,
            string debugSignature)
        {
            List<int> stages = new List<int>();
            GraphGroundDebugInfo debug;
            List<Vector2D> output = FilterAggregator.Apply(points, 17, out debug,
                delegate(int index, int stage, int total)
                {
                    Check(index == 17 && total == 5, name + " progress metadata");
                    stages.Add(stage);
                }, settings);
            Check(debug != null, name + " debug missing");
            Check(stages.Count == 5, name + " progress count");
            for (int i = 0; i < 5; i++) Check(stages[i] == i + 1, name + " progress order");
            Check(debug.InputPointCount == points.Count, name + " debug input count");
            string actual = Signature(output);
            string dbg = DebugSignature(debug);
            if (record)
                Console.WriteLine(name + " count=" + output.Count + " geometry=" + actual +
                    " debug=" + dbg + " graph=" + debug.OutputPointCount);
            else
            {
                Check(output.Count == count, name + " geometry count");
                Check(actual == geometry, name + " geometry/order hash");
                Check(dbg == debugSignature, name + " debug hash");
            }
        }

        private static LasSectionPoints Section(List<Vector2D> points, double baseY)
        {
            LasSectionPoints section = new LasSectionPoints();
            section.LeftMostPoint = new Vector2D(100.0, baseY);
            section.Direction = new Vector2D(1.0, 0.0);
            section.SectionPoints = points;
            section.OriginOffset = 2.0;
            return section;
        }

        private static List<Vector3D> Workflow(bool parallel, FilterOperationSnapshot settings)
        {
            LasSectionPoints[] sections = new LasSectionPoints[]
            {
                Section(FixtureData.DuplicateXYSection(), 200.0),
                Section(FixtureData.DuplicateXYSection(), 200.0),
                Section(FixtureData.ProfileBreakSection(), 300.0)
            };
            SectionRequest request = new SectionRequest(sections, 3.0, parallel, settings);
            OperationResult<List<Vector3D>> result = SectionWorkflow.Calculate(request,
                delegate(double offset, LasSectionPoints section, int index,
                    FilterOperationSnapshot captured)
                {
                    GraphGroundDebugInfo debug;
                    return LasFilterService.ApplyFilter(offset, section, index,
                        out debug, null, captured);
                }, null, null);
            Check(result.Status == OperationStatus.Success, "workflow status " + result.Status);
            Check(sections[0].SectionPoints == null && sections[1].SectionPoints == null &&
                sections[2].SectionPoints == null, "workflow section ownership");
            return result.Value;
        }

        private static void CheckWorkflow()
        {
            FilterOperationSnapshot settings = Settings(true, true, 0.01);
            List<Vector3D> serial = Workflow(false, settings);
            List<Vector3D> parallel = Workflow(true, settings);
            string a = Signature3(serial);
            string b = Signature3(parallel);
            Check(a == b, "serial/parallel geometry or order changed");
            if (record) Console.WriteLine("workflow count=" + serial.Count + " geometry=" + a);
            else
            {
                Check(serial.Count == 7, "workflow count");
                Check(a == "3ec2a3286390533d", "workflow geometry/order hash");
            }
        }

        private static void CheckStaticMutation()
        {
            FilterOperationSnapshot settings = Settings(true, true, 0.01);
            GraphGroundDebugInfo debug;
            string expected = Signature(FilterAggregator.Apply(FixtureData.ProfileBreakSection(),
                0, out debug, null, settings));
            string expectedDebug = DebugSignature(debug);
            int minPts = RuntimeConfig.GraphMinPts;
            double angle = RuntimeConfig.BreakAngleThreshold;
            double step = RuntimeConfig.SplineGridStep;
            bool spline = RuntimeConfig.UseSplineFilter;
            double tolerance = RuntimeConfig.SplitMergeTolerance;
            try
            {
                RuntimeConfig.GraphMinPts = int.MaxValue;
                RuntimeConfig.BreakAngleThreshold = 100.0;
                RuntimeConfig.SplineGridStep = 1.0;
                RuntimeConfig.UseSplineFilter = false;
                RuntimeConfig.SplitMergeTolerance = 1.0;
                string actual = Signature(FilterAggregator.Apply(FixtureData.ProfileBreakSection(),
                    1, out debug, null, settings));
                Check(actual == expected, "explicit snapshot changed after static mutation");
                Check(DebugSignature(debug) == expectedDebug,
                    "explicit snapshot debug changed after static mutation");
            }
            finally
            {
                RuntimeConfig.GraphMinPts = minPts;
                RuntimeConfig.BreakAngleThreshold = angle;
                RuntimeConfig.SplineGridStep = step;
                RuntimeConfig.UseSplineFilter = spline;
                RuntimeConfig.SplitMergeTolerance = tolerance;
            }
        }

        private static void CheckCapture()
        {
            FilterOperationSnapshot original = FilterSettingsSnapshotAdapter.Capture();
            RuntimeConfig.UseSplineFilter = false;
            RuntimeConfig.SplitMergeTolerance = 0.2;
            RuntimeConfig.EnableBreakDetection = false;
            RuntimeConfig.GraphBinX = 1.1;
            RuntimeConfig.GraphBinY = 2.2;
            RuntimeConfig.GraphMinPts = 3;
            RuntimeConfig.BreakSlopeWindow = 4;
            RuntimeConfig.BreakR2Window = 5;
            RuntimeConfig.BreakAngleThreshold = 0.6;
            RuntimeConfig.BreakMinR2 = 0.7;
            RuntimeConfig.BreakMinSegmentPoints = 8;
            RuntimeConfig.BreakSuppressRadius = 9;
            RuntimeConfig.SplineDegree = 2;
            RuntimeConfig.SplineMaxIterations = 11;
            RuntimeConfig.SplineSigma = 0.12;
            RuntimeConfig.CSplineSmooth = 0.13;
            RuntimeConfig.SplineGridStep = 0.14;
            RuntimeConfig.SplineConvergenceTol = 0.015;
            RuntimeConfig.SplineAutoCtrlMax = 16;
            RuntimeConfig.SplineRidgeEps = 0.00017;
            RuntimeConfig.SplineMaxGapMeters = 0.18;
            RuntimeConfig.SplineEnableRailFilter = true;
            RuntimeConfig.SplineRailFilterWindowMeters = 0.19;
            FilterOperationSnapshot captured = FilterSettingsSnapshotAdapter.Capture();
            Check(!captured.UseSplineFilter, "capture spline choice");
            Check(captured.SplitMergeTolerance == 0.2, "capture tolerance");
            Check(!captured.EnableBreakDetection, "capture break flag");
            Check(captured.GraphBinX == 1.1 && captured.GraphBinY == 2.2 &&
                captured.GraphMinPts == 3, "capture graph options");
            Check(captured.BreakSlopeWindow == 4 && captured.BreakR2Window == 5 &&
                captured.BreakAngleThreshold == 0.6 && captured.BreakMinR2 == 0.7 &&
                captured.BreakMinSegmentPoints == 8 && captured.BreakSuppressRadius == 9,
                "capture break options");
            Check(captured.SplineDegree == 2 && captured.SplineMaxIterations == 11 &&
                captured.SplineSigma == 0.12 && captured.SplineSmooth == 0.13 &&
                captured.SplineGridStep == 0.14 && captured.SplineConvergenceTol == 0.015 &&
                captured.SplineAutoCtrlMax == 16 && captured.SplineRidgeEps == 0.00017 &&
                captured.SplineMaxGapMeters == 0.18 && captured.SplineEnableRailFilter &&
                captured.SplineRailFilterWindowMeters == 0.19,
                "capture spline options");
            RuntimeConfig.SplitMergeTolerance = 0.4;
            Check(RuntimeConfig.SplitMergeTolerance == 0.4,
                "tolerance after preference update");
            RuntimeConfig.UseSplineFilter = original.UseSplineFilter;
            RuntimeConfig.SplitMergeTolerance = original.SplitMergeTolerance;
            RuntimeConfig.EnableBreakDetection = original.EnableBreakDetection;
            RuntimeConfig.GraphBinX = original.GraphBinX;
            RuntimeConfig.GraphBinY = original.GraphBinY;
            RuntimeConfig.GraphMinPts = original.GraphMinPts;
            RuntimeConfig.BreakSlopeWindow = original.BreakSlopeWindow;
            RuntimeConfig.BreakR2Window = original.BreakR2Window;
            RuntimeConfig.BreakAngleThreshold = original.BreakAngleThreshold;
            RuntimeConfig.BreakMinR2 = original.BreakMinR2;
            RuntimeConfig.BreakMinSegmentPoints = original.BreakMinSegmentPoints;
            RuntimeConfig.BreakSuppressRadius = original.BreakSuppressRadius;
            RuntimeConfig.SplineDegree = original.SplineDegree;
            RuntimeConfig.SplineMaxIterations = original.SplineMaxIterations;
            RuntimeConfig.SplineSigma = original.SplineSigma;
            RuntimeConfig.CSplineSmooth = original.SplineSmooth;
            RuntimeConfig.SplineGridStep = original.SplineGridStep;
            RuntimeConfig.SplineConvergenceTol = original.SplineConvergenceTol;
            RuntimeConfig.SplineAutoCtrlMax = original.SplineAutoCtrlMax;
            RuntimeConfig.SplineRidgeEps = original.SplineRidgeEps;
            RuntimeConfig.SplineMaxGapMeters = original.SplineMaxGapMeters;
            RuntimeConfig.SplineEnableRailFilter = original.SplineEnableRailFilter;
            RuntimeConfig.SplineRailFilterWindowMeters = original.SplineRailFilterWindowMeters;
        }

        private static void CheckCollectorChoice()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 2.0;
            List<LidarBuffer> buffers = new List<LidarBuffer>();
            buffers.Add(new LidarBuffer());
            List<Section> sections = new List<Section>();
            sections.Add(new Section());
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(true, true, 0.01);
            bool original = RuntimeConfig.OnePassActive;
            try
            {
                OnePassSectionCollector.Calls = 0;
                LasSectionPointsCollectorService.Calls = 0;
                RuntimeConfig.OnePassActive = false;
                bool capturedLegacy = RuntimeConfig.OnePassActive;
                RuntimeConfig.OnePassActive = true;
                OperationResult<List<Vector3D>> pilotLegacy =
                    GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                        null, settings, capturedLegacy);
                Check(pilotLegacy.Status == OperationStatus.Empty, "pilot legacy result");
                Check(LasSectionPointsCollectorService.Calls == 1 &&
                    OnePassSectionCollector.Calls == 0,
                    "pilot ignored captured legacy collection choice");

                RuntimeConfig.OnePassActive = true;
                bool capturedOnePass = RuntimeConfig.OnePassActive;
                RuntimeConfig.OnePassActive = false;
                OperationResult<List<Vector3D>> pilotOnePass =
                    GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                        null, settings, capturedOnePass);
                Check(pilotOnePass.Status == OperationStatus.Empty, "pilot onepass result");
                Check(LasSectionPointsCollectorService.Calls == 1 &&
                    OnePassSectionCollector.Calls == 1,
                    "pilot ignored captured onepass collection choice");

                RuntimeConfig.OnePassActive = true;
                OperationResult<List<Vector3D>> legacy = GroundPointsCollector.Collect(
                    alg, buffers, sections, options, null, settings, capturedLegacy);
                Check(legacy.Status == OperationStatus.Empty, "legacy collection result");
                Check(LasSectionPointsCollectorService.Calls == 2 &&
                    OnePassSectionCollector.Calls == 1,
                    "collector ignored captured legacy collection choice");

                RuntimeConfig.OnePassActive = false;
                OperationResult<List<Vector3D>> onePass = GroundPointsCollector.Collect(
                    alg, buffers, sections, options, null, settings, capturedOnePass);
                Check(onePass.Status == OperationStatus.Empty, "onepass collection result");
                Check(LasSectionPointsCollectorService.Calls == 2 &&
                    OnePassSectionCollector.Calls == 2,
                    "collector ignored captured onepass collection choice");

                bool rejected = false;
                try
                {
                    GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                        null, null, true);
                }
                catch (ArgumentNullException error)
                {
                    rejected = error.ParamName == "settings";
                }
                Check(rejected, "pilot null snapshot not rejected");
                rejected = false;
                try
                {
                    GroundPointsCollector.Collect(alg, buffers, sections, options,
                        null, null, false);
                }
                catch (ArgumentNullException error)
                {
                    rejected = error.ParamName == "settings";
                }
                Check(rejected, "collector null snapshot not rejected");
                Check(LasSectionPointsCollectorService.Calls == 2,
                    "null snapshot caused an SDK collection call");
            }
            finally
            {
                RuntimeConfig.OnePassActive = original;
            }
        }

        private static void CheckCollectorStatus()
        {
            Alignment alg = new Alignment();
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<Section> sections = new List<Section> { new Section() };
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(true, true, 0.01);
            try
            {
                Topomatic.Controls.WaitProgress.CancelRequested = false;
                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Overflow;
                Check(GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                    null, settings, false).Status == OperationStatus.Overflow,
                    "pilot legacy overflow is local");
                Check(GroundPointsCollector.Collect(alg, buffers, sections, options,
                    null, settings, false).Status == OperationStatus.Overflow,
                    "legacy overflow is local");

                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Cancelled;
                Check(GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                    null, settings, false).Status == OperationStatus.Cancelled,
                    "pilot legacy cancellation is local");
                Check(GroundPointsCollector.Collect(alg, buffers, sections, options,
                    null, settings, false).Status == OperationStatus.Cancelled,
                    "legacy cancellation is local");

                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Success;
                OnePassSectionCollector.ThrowOutOfMemory = true;
                Check(GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                    null, settings, true).Status == OperationStatus.Overflow,
                    "pilot OnePass OOM is overflow");
                Check(GroundPointsCollector.Collect(alg, buffers, sections, options,
                    null, settings, true).Status == OperationStatus.Overflow,
                    "OnePass OOM is overflow");

                OnePassSectionCollector.ThrowOutOfMemory = false;
                OnePassSectionCollector.ReturnNull = true;
                Check(GroundPointsCollector.CollectPilot(alg, buffers, sections, options,
                    null, settings, true).Status == OperationStatus.Failed,
                    "pilot OnePass null without cancellation is failed");
                Check(GroundPointsCollector.Collect(alg, buffers, sections, options,
                    null, settings, true).Status == OperationStatus.Failed,
                    "OnePass null without cancellation is failed");
            }
            finally
            {
                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Success;
                OnePassSectionCollector.ThrowOutOfMemory = false;
                OnePassSectionCollector.ReturnNull = false;
                Topomatic.Controls.WaitProgress.CancelRequested = false;
            }
        }

        private static void CheckStationPilot()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 2.0;
            alg.DtmSizeRight = 10.0;
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<double> stations = new List<double> { 2.5, 7.5 };
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(true, true, 0.01);
            int legacyCalls = LasSectionPointsCollectorService.Calls;
            int onePassCalls = OnePassSectionCollector.Calls;
            LasSectionPointsCollectorService.RequestedStations.Clear();
            LasSectionPointsCollectorService.CapturedLeftOffsets.Clear();
            OnePassSectionCollector.RequestedStations.Clear();
            try
            {
                LasSectionPointsCollectorService.ChangeAlignmentOffsetAfterFirst = true;
                LasSectionPointsCollectorService.AfterFirstStationCollection =
                    delegate { stations[1] = 99.0; };
                OperationResult<List<Vector3D>> legacy =
                    GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                        options, settings, false);
                Check(legacy.Status == OperationStatus.Empty &&
                    LasSectionPointsCollectorService.Calls == legacyCalls + 2 &&
                    OnePassSectionCollector.Calls == onePassCalls,
                    "planned stations use the legacy collector twice");
                Check(LasSectionPointsCollectorService.RequestedStations.Count == 2 &&
                    LasSectionPointsCollectorService.RequestedStations[0] == 2.5 &&
                    LasSectionPointsCollectorService.RequestedStations[1] == 7.5,
                    "legacy station order stays fixed after caller mutation");
                Check(LasSectionPointsCollectorService.CapturedLeftOffsets.Count == 2 &&
                    LasSectionPointsCollectorService.CapturedLeftOffsets[0] == 2.0 &&
                    LasSectionPointsCollectorService.CapturedLeftOffsets[1] == 2.0 &&
                    options.CentralLeftOffset == null,
                    "station operation retains one offset despite later alignment edits");

                LasSectionPointsCollectorService.ChangeAlignmentOffsetAfterFirst = false;
                LasSectionPointsCollectorService.AfterFirstStationCollection = null;
                alg.DtmSizeLeft = 2.0;
                stations[1] = 7.5;
                OperationResult<List<Vector3D>> onePass =
                    GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                        options, settings, true);
                Check(onePass.Status == OperationStatus.Empty &&
                    OnePassSectionCollector.Calls == onePassCalls + 1 &&
                    OnePassSectionCollector.RequestedStations.Count == 2 &&
                    OnePassSectionCollector.RequestedStations[0] == 2.5 &&
                    OnePassSectionCollector.RequestedStations[1] == 7.5,
                    "planned stations use OnePass in exact order");
                Check(OnePassSectionCollector.LastLeftOffset == 2.0,
                    "OnePass receives the captured origin offset");

                bool rejected = false;
                try
                {
                    GroundPointsCollector.CollectPilotAtStations(alg, buffers,
                        new List<double> { 2.5, Double.NaN }, options, settings, false);
                }
                catch (ArgumentOutOfRangeException) { rejected = true; }
                Check(rejected &&
                    LasSectionPointsCollectorService.Calls == legacyCalls + 2,
                    "invalid station is rejected before collection");
                Check(GroundPointsCollector.CollectPilotAtStations(alg, buffers,
                    new List<double>(), options, settings, false).Status == OperationStatus.Empty,
                    "empty planned station list is an empty result");
                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Overflow;
                Check(GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                    options, settings, false).Status == OperationStatus.Overflow,
                    "station path preserves overflow");
            }
            finally
            {
                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Success;
                LasSectionPointsCollectorService.ChangeAlignmentOffsetAfterFirst = false;
                LasSectionPointsCollectorService.AfterFirstStationCollection = null;
            }
        }

        private static void CheckStationLegacyPipeline()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 2.0;
            alg.DtmSizeRight = 10.0;
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<Section> sections = new List<Section> { new Section() };
            List<double> stations = new List<double> { 2.5 };
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(false, false, 0.2);
            try
            {
                CollectorFixture.EmitPoints = true;
                foreach (bool onePass in new bool[] { false, true })
                {
                    OperationResult<List<Vector3D>> oldResult = GroundPointsCollector.Collect(
                        alg, buffers, sections, options, null, settings, onePass);
                    OperationResult<List<Vector3D>> stationResult =
                        GroundPointsCollector.CollectAtStations(alg, buffers, stations,
                            options, settings, onePass);
                    OperationResult<List<Vector3D>> workflowResult =
                        GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                            options, settings, onePass);
                    Check(oldResult.Status == OperationStatus.Success &&
                        stationResult.Status == OperationStatus.Success &&
                        workflowResult.Status == OperationStatus.Success,
                        "section, station and workflow routes succeed");
                    Check(oldResult.Value.Count > 0 &&
                        oldResult.Value.Count == stationResult.Value.Count &&
                        stationResult.Value.Count == workflowResult.Value.Count,
                        "station workflow retains filtered point count");
                    Check(Signature3(oldResult.Value) == Signature3(stationResult.Value) &&
                        Signature3(stationResult.Value) == Signature3(workflowResult.Value),
                        "station workflow retains XYZ values and order");
                }
                stations.Add(7.5);
                foreach (bool onePass in new bool[] { false, true })
                foreach (bool parallel in new bool[] { false, true })
                {
                    options.Async = parallel;
                    OperationResult<List<Vector3D>> original =
                        GroundPointsCollector.CollectAtStations(alg, buffers, stations,
                            options, settings, onePass);
                    OperationResult<List<Vector3D>> workflow =
                        GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                            options, settings, onePass);
                    Check(original.Status == OperationStatus.Success &&
                        workflow.Status == OperationStatus.Success &&
                        Signature3(original.Value) == Signature3(workflow.Value),
                        "two-station workflow retains first-wins deduplication and order");
                }
                stations.RemoveAt(1);
                options.Async = false;
                CollectorFixture.EmitPoints = false;
                OperationResult<List<Vector3D>> empty =
                    GroundPointsCollector.CollectAtStations(alg, buffers, stations,
                        options, settings, false);
                Check(empty.Status == OperationStatus.Empty,
                    "station route preserves empty result");

                List<double> movingStations = new List<double> { 2.5, 7.5 };
                LasSectionPointsCollectorService.CapturedLeftOffsets.Clear();
                LasSectionPointsCollectorService.RequestedStations.Clear();
                LasSectionPointsCollectorService.ChangeAlignmentOffsetAfterFirst = true;
                LasSectionPointsCollectorService.AfterFirstStationCollection =
                    delegate { movingStations[1] = 99.0; };
                OperationResult<List<Vector3D>> captured =
                    GroundPointsCollector.CollectAtStations(alg, buffers, movingStations,
                        options, settings, false);
                Check(captured.Status == OperationStatus.Empty &&
                    LasSectionPointsCollectorService.RequestedStations.Count == 2 &&
                    LasSectionPointsCollectorService.RequestedStations[0] == 2.5 &&
                    LasSectionPointsCollectorService.RequestedStations[1] == 7.5,
                    "three-stage route uses captured station order");
                Check(LasSectionPointsCollectorService.CapturedLeftOffsets.Count == 2 &&
                    LasSectionPointsCollectorService.CapturedLeftOffsets[0] == 2.0 &&
                    LasSectionPointsCollectorService.CapturedLeftOffsets[1] == 2.0,
                    "three-stage route uses captured offset");

                bool rejected = false;
                try
                {
                    GroundPointsCollector.CollectAtStations(alg, buffers,
                        new List<double> { Double.NaN }, options, settings, false);
                }
                catch (ArgumentOutOfRangeException) { rejected = true; }
                Check(rejected, "three-stage route rejects invalid station before SDK work");
            }
            finally
            {
                CollectorFixture.EmitPoints = false;
                LasSectionPointsCollectorService.ChangeAlignmentOffsetAfterFirst = false;
                LasSectionPointsCollectorService.AfterFirstStationCollection = null;
                LasSectionPointsCollectorService.NextStatus = SectionCollectStatus.Success;
            }
        }

        private static void CheckStationOptionsAreCaptured()
        {
            Alignment alg = new Alignment();
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<double> stations = new List<double> { 2.5, 7.5 };
            FilterOperationSnapshot settings = Settings(false, false, 0.2);
            try
            {
                CollectorFixture.EmitPoints = false;
                foreach (bool pilot in new bool[] { false, true })
                {
                    LasFilterOptions options = LasFilterOptions.FromThickness(2.0, false);
                    options.IncludePositiveSliceBorder = true;
                    LasSectionPointsCollectorService.CapturedLeftOffsets.Clear();
                    LasSectionPointsCollectorService.CapturedHalfBorders.Clear();
                    LasSectionPointsCollectorService.CapturedPositiveBorders.Clear();
                    LasSectionPointsCollectorService.AfterFirstStationCollection = delegate
                    {
                        options.HalfBorder = 0.01;
                        options.IncludePositiveSliceBorder = false;
                    };
                    OperationResult<List<Vector3D>> result = pilot
                        ? GroundPointsCollector.CollectPilotAtStations(alg, buffers,
                            stations, options, settings, false)
                        : GroundPointsCollector.CollectAtStations(alg, buffers,
                            stations, options, settings, false);
                    Check(result.Status == OperationStatus.Empty &&
                        LasSectionPointsCollectorService.CapturedHalfBorders.Count == 2 &&
                        LasSectionPointsCollectorService.CapturedHalfBorders[0] == 1.0 &&
                        LasSectionPointsCollectorService.CapturedHalfBorders[1] == 1.0 &&
                        LasSectionPointsCollectorService.CapturedPositiveBorders.Count == 2 &&
                        LasSectionPointsCollectorService.CapturedPositiveBorders[0] &&
                        LasSectionPointsCollectorService.CapturedPositiveBorders[1],
                        "station workflow pins slice width and positive border across sections");
                }
            }
            finally
            {
                LasSectionPointsCollectorService.AfterFirstStationCollection = null;
                CollectorFixture.EmitPoints = false;
            }
        }

        private static void CheckThreeStageModalCancellation()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 2.0;
            alg.DtmSizeRight = 10.0;
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<Section> sections = new List<Section> { new Section() };
            List<double> stations = new List<double> { 2.5 };
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(false, false, 0.2);
            try
            {
                CollectorFixture.EmitPoints = true;
                Topomatic.Controls.WaitProgress.ResetCancellationOnClose = true;
                Topomatic.Controls.WaitProgress.CancelOnlyAtFinalProgress = true;
                foreach (bool stationRoute in new bool[] { false, true })
                foreach (bool onePass in new bool[] { false, true })
                for (int stage = 1; stage <= 3; stage++)
                foreach (bool throwOnCancellation in new bool[] { false, true })
                {
                    Topomatic.Controls.WaitProgress.Stage = 0;
                    Topomatic.Controls.WaitProgress.CancelRequested = false;
                    Topomatic.Controls.WaitProgress.CancelOnProgressStage = stage;
                    Topomatic.Controls.WaitProgress.ThrowOnCancellation = throwOnCancellation;
                    OperationResult<List<Vector3D>> result = stationRoute
                        ? GroundPointsCollector.CollectAtStations(alg, buffers, stations,
                            options, settings, onePass)
                        : GroundPointsCollector.Collect(alg, buffers, sections,
                            options, null, settings, onePass);
                    SectionStage expected = stage == 1 ? SectionStage.Collect
                        : stage == 2 ? SectionStage.Filter : SectionStage.Deduplicate;
                    string label = (stationRoute ? "station" : "section") +
                        (onePass ? " OnePass" : " serial") + " stage " + stage +
                        (throwOnCancellation ? " thrown" : " flagged");
                    Check(result.Status == OperationStatus.Cancelled &&
                        result.Stage == expected && result.Value == null,
                        label + " retains cancellation after modal reset");
                    Check(Topomatic.Controls.WaitProgress.Stage == stage,
                        label + " does not start a later stage");
                    Check(!Topomatic.Controls.WaitProgress.CancelRequested,
                        label + " exercises the reset on modal close");
                }
            }
            finally
            {
                CollectorFixture.EmitPoints = false;
                Topomatic.Controls.WaitProgress.CancelRequested = false;
                Topomatic.Controls.WaitProgress.CancelOnProgressStage = 0;
                Topomatic.Controls.WaitProgress.CancelOnlyAtFinalProgress = false;
                Topomatic.Controls.WaitProgress.ThrowOnCancellation = false;
                Topomatic.Controls.WaitProgress.ResetCancellationOnClose = false;
                Topomatic.Controls.WaitProgress.Stage = 0;
            }
        }

        private static void CheckPilotModalCancellation()
        {
            Alignment alg = new Alignment();
            alg.DtmSizeLeft = 2.0;
            alg.DtmSizeRight = 10.0;
            List<LidarBuffer> buffers = new List<LidarBuffer> { new LidarBuffer() };
            List<Section> sections = new List<Section> { new Section() };
            List<double> stations = new List<double> { 2.5 };
            LasFilterOptions options = new LasFilterOptions();
            options.Async = false;
            FilterOperationSnapshot settings = Settings(false, false, 0.2);
            try
            {
                CollectorFixture.EmitPoints = true;
                Topomatic.Controls.WaitProgress.ResetCancellationOnClose = true;
                Topomatic.Controls.WaitProgress.CancelOnlyAtFinalProgress = true;
                foreach (bool stationRoute in new bool[] { false, true })
                foreach (bool onePass in new bool[] { false, true })
                for (int stage = 1; stage <= 2; stage++)
                foreach (bool throwOnCancellation in new bool[] { false, true })
                {
                    Topomatic.Controls.WaitProgress.Stage = 0;
                    Topomatic.Controls.WaitProgress.CancelRequested = false;
                    Topomatic.Controls.WaitProgress.CancelOnProgressStage = stage;
                    Topomatic.Controls.WaitProgress.ThrowOnCancellation = throwOnCancellation;
                    OperationResult<List<Vector3D>> result = stationRoute
                        ? GroundPointsCollector.CollectPilotAtStations(alg, buffers, stations,
                            options, settings, onePass)
                        : GroundPointsCollector.CollectPilot(alg, buffers, sections,
                            options, null, settings, onePass);
                    string label = (stationRoute ? "pilot station" : "pilot section") +
                        (onePass ? " OnePass" : " serial") + " stage " + stage +
                        (throwOnCancellation ? " thrown" : " flagged");
                    Check(result.Status == OperationStatus.Cancelled && result.Value == null,
                        label + " retains cancellation after modal reset");
                    Check(Topomatic.Controls.WaitProgress.Stage == stage,
                        label + " does not start a later stage");
                    Check(!Topomatic.Controls.WaitProgress.CancelRequested,
                        label + " exercises the reset on modal close");
                }
            }
            finally
            {
                CollectorFixture.EmitPoints = false;
                Topomatic.Controls.WaitProgress.CancelRequested = false;
                Topomatic.Controls.WaitProgress.CancelOnProgressStage = 0;
                Topomatic.Controls.WaitProgress.CancelOnlyAtFinalProgress = false;
                Topomatic.Controls.WaitProgress.ThrowOnCancellation = false;
                Topomatic.Controls.WaitProgress.ResetCancellationOnClose = false;
                Topomatic.Controls.WaitProgress.Stage = 0;
            }
        }

        public static int Main(string[] args)
        {
            record = args.Length > 0 && args[0] == "--record";
            Case("ordinary-spline", FixtureData.OrdinarySection(), Settings(true, true, 0.01),
                3, "c6f155e595295256", "035cb001c738ef43");
            Case("break-on-lowtol", FixtureData.ProfileBreakSection(), Settings(true, true, 0.01),
                4, "2b29fa6ff7037d46", "ff0047c0b528590a");
            Case("break-off-lowtol", FixtureData.ProfileBreakSection(), Settings(true, false, 0.01),
                18, "c40e2ccda06d3807", "ff0047c0b528590a");
            Case("break-on-hightol", FixtureData.ProfileBreakSection(), Settings(true, true, 0.2),
                3, "3e1bbd5d17df2157", "ff0047c0b528590a");
            Case("ordinary-median", FixtureData.OrdinarySection(), Settings(false, true, 0.01),
                9, "e96b35b818c60eeb", "035cb001c738ef43");
            Case("duplicate-median", FixtureData.DuplicateXYSection(), Settings(false, false, 0.2),
                2, "bb9b5acc3e2e9425", "39a977b2856ee486");
            CheckWorkflow();
            CheckStaticMutation();
            CheckCapture();
            CheckCollectorChoice();
            CheckCollectorStatus();
            CheckStationPilot();
            CheckStationLegacyPipeline();
            CheckStationOptionsAreCaptured();
            CheckThreeStageModalCancellation();
            CheckPilotModalCancellation();
            Console.WriteLine("Filter chain baseline passed: " + checks + " checks.");
            return 0;
        }
    }
}
