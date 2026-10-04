using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.View;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Tests
{
    public static class SectionStepFixture
    {
        public static Alignment Alignment;
        public static SurfaceLayer Layer;
        public static Section OriginalSection;
        public static object Model;
        public static Guid AlignmentId;
        public static readonly Queue<double?> StepAnswers = new Queue<double?>();
        public static readonly List<double> StepDefaults = new List<double>();
        public static readonly List<string> Warnings = new List<string>();

        public static void Reset(double length)
        {
            Alignment = new Alignment();
            Alignment.Plan.CompoundLine.Length = length;
            Alignment.Corridor.Sections.Add(42.0);
            OriginalSection = Alignment.Corridor.Sections[0];
            Layer = new SurfaceLayer();
            Model = new object();
            ApplicationHost.Current = new ApplicationHost();
            ApplicationHost.Current.ActiveProject = new object();
            ApplicationHost.Current.ActiveDocument = new object();
            AlignmentId = Guid.NewGuid();
            GroundPointsCollector.NextStationResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Empty();
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Empty();
            GroundPointsCollector.DuringPilotCollect = null;
            GroundPointsCollector.DuringStationCollect = null;
            GroundPointsCollector.SawOriginalSections = false;
            GroundPointsCollector.StationCalls = 0;
            GroundPointsCollector.PilotCalls = 0;
            GroundPointsCollector.MutateSectionsDuringCollect = false;
            TopomaticSurfaceWriter.ApplyCalls = 0;
            TopomaticSurfaceWriter.SawCommittedSections = false;
            TopomaticSurfaceWriter.FailApply = false;
            LAS_TERRAIN.Service.LidarBufferService.Buffers =
                new List<Topomatic.Lidar.LidarBuffer> {
                    new Topomatic.Lidar.LidarBuffer() };
            StepAnswers.Clear();
            StepDefaults.Clear();
            Warnings.Clear();
        }

        public static double? NextSectionStep(double defaultStep)
        {
            StepDefaults.Add(defaultStep);
            if (StepAnswers.Count == 0)
                throw new Exception("Unexpected section-step prompt");
            return StepAnswers.Dequeue();
        }
    }

    public static class SectionStepCommandTests
    {
        private static int _checks;
        private static void Check(bool value, string reason)
        {
            _checks++;
            if (!value) throw new Exception(reason);
        }

        private static void CheckStations(params double[] expected)
        {
            SectionList sections = SectionStepFixture.Alignment.Corridor.Sections;
            Check(sections.Count == expected.Length, "station count");
            for (int i = 0; i < expected.Length; i++)
                Check(sections[i].Station == expected[i], "station " + i);
        }

        private static void Run(ISectionUseCase command)
        { command.Run(new SectionEnv(new CadView())); }

        private static void FixedStepAndCustomDefault()
        {
            SectionStepFixture.Reset(5.0);
            SectionStepFixture.StepAnswers.Enqueue(2.5);
            Run(new CalculateCustomStepSectionAsyncUseCase());
            Check(GroundPointsCollector.SawOriginalSections,
                "collector sees original sections until calculation ends");
            Check(SectionStepFixture.StepDefaults.Count == 1 &&
                SectionStepFixture.StepDefaults[0] == 1.0,
                "first custom command asks for step with initial default");
            CheckStations(0.0, 2.5, 5.0);

            SectionStepFixture.Alignment.Plan.CompoundLine.Length = 3.0;
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.StepDefaults.Count == 1,
                "fixed one-meter command does not prompt for step");
            CheckStations(0.0, 1.0, 2.0, 3.0);

            Section[] beforeCancel = SectionStepFixture.Alignment.Corridor.Sections.ToArray();
            SectionStepFixture.StepAnswers.Enqueue(null);
            Run(new CalculateCustomStepSectionAsyncUseCase());
            Check(SectionStepFixture.StepDefaults.Count == 2 &&
                SectionStepFixture.StepDefaults[1] == 2.5,
                "fixed one-meter command did not overwrite custom default");
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == beforeCancel.Length,
                "cancel keeps section count");
            for (int i = 0; i < beforeCancel.Length; i++)
                Check(Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[i],
                    beforeCancel[i]), "cancel keeps original section object " + i);

            SectionStepFixture.Alignment.Plan.CompoundLine.Length = 4.5;
            SectionStepFixture.StepAnswers.Enqueue(1.5);
            Run(new CalculateCustomStepSectionAsyncUseCase());
            Check(SectionStepFixture.StepDefaults.Count == 3 &&
                SectionStepFixture.StepDefaults[2] == 2.5,
                "next custom command still receives last user value");
            CheckStations(0.0, 1.5, 3.0, 4.5);
        }

        private static void StandardCommandDoesNotGenerate()
        {
            SectionStepFixture.Reset(3.0);
            Section section = SectionStepFixture.Alignment.Corridor.Sections[0];
            Run(new CalculateSectionAsyncUseCase());
            Check(GroundPointsCollector.PilotCalls == 1 &&
                GroundPointsCollector.StationCalls == 0,
                "standard command did not use the staged calculation path");
            Check(SectionStepFixture.StepDefaults.Count == 0,
                "standard command does not ask for generation step");
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0], section),
                "standard command leaves existing sections intact");
        }

        private static void StandardCommandRejectsChangedSection()
        {
            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            Run(new CalculateSectionAsyncUseCase());
            Check(TopomaticSurfaceWriter.ApplyCalls == 1,
                "unchanged standard section result reaches the surface");

            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            GroundPointsCollector.DuringPilotCollect = delegate {
                SectionStepFixture.OriginalSection.SectionLine = new object();
            };
            Run(new CalculateSectionAsyncUseCase());
            Check(TopomaticSurfaceWriter.ApplyCalls == 0 &&
                SectionStepFixture.Warnings.Count == 1,
                "changed section line prevents stale surface update");

            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            GroundPointsCollector.DuringPilotCollect = delegate {
                SectionStepFixture.OriginalSection.ConstructionId++;
            };
            Run(new CalculateSectionAsyncUseCase());
            Check(TopomaticSurfaceWriter.ApplyCalls == 0 &&
                SectionStepFixture.Warnings.Count == 1,
                "changed section construction prevents stale surface update");
        }

        private static void FailedCalculationPreservesSections()
        {
            SectionStepFixture.Reset(5.0);
            GroundPointsCollector.NextStationResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Cancelled(SectionStage.Collect);
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection),
                "cancelled calculation preserves original section object");
            Check(GroundPointsCollector.SawOriginalSections,
                "cancelled collector saw original sections");

            GroundPointsCollector.NextStationResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Failed(
                    SectionStage.Filter, new InvalidOperationException("injected filter failure"));
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection),
                "failed calculation preserves original section object");
            Check(SectionStepFixture.Warnings.Count > 0,
                "filter failure is reported");
        }

        private static void FailedCommitRollsBackSections()
        {
            SectionStepFixture.Reset(5.0);
            SectionStepFixture.Alignment.Corridor.Sections.FailAfterAdds = 1;
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection),
                "mid-commit Add failure restores original section object");
            Check(SectionStepFixture.Warnings.Count > 0,
                "commit failure is reported");
        }

        private static void SuccessfulCalculationStagesSectionsBeforeSurface()
        {
            SectionStepFixture.Reset(2.0);
            GroundPointsCollector.NextStationResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            Run(new CalculateOneMeterSectionAsyncUseCase());
            CheckStations(0.0, 1.0, 2.0);
            Check(TopomaticSurfaceWriter.ApplyCalls == 1 &&
                TopomaticSurfaceWriter.SawCommittedSections,
                "surface writer receives only committed section state");
        }

        private static void StaleTargetIsRejected()
        {
            SectionStepFixture.Reset(2.0);
            GroundPointsCollector.MutateSectionsDuringCollect = true;
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 2 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection),
                "stale result must not overwrite another section edit");
            Check(SectionStepFixture.Warnings.Count > 0,
                "stale target is reported");
        }

        private static void SwitchedDocumentCannotReceiveResults()
        {
            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            GroundPointsCollector.DuringPilotCollect = delegate {
                ApplicationHost.Current.ActiveDocument = new object();
            };
            Run(new CalculateSectionAsyncUseCase());
            Check(TopomaticSurfaceWriter.ApplyCalls == 0 &&
                SectionStepFixture.Warnings.Count == 1,
                "standard command rejects a switched active document");

            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.DuringStationCollect = delegate {
                ApplicationHost.Current.ActiveProject = new object();
            };
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection) &&
                SectionStepFixture.Warnings.Count == 1,
                "generated command rejects a switched active project");
        }

        private static void SurfaceFailureReportsPartialCommit()
        {
            SectionStepFixture.Reset(2.0);
            GroundPointsCollector.NextStationResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            TopomaticSurfaceWriter.FailApply = true;
            Run(new CalculateOneMeterSectionAsyncUseCase());
            CheckStations(0.0, 1.0, 2.0);
            Check(SectionStepFixture.Warnings.Count == 1 &&
                SectionStepFixture.Warnings[0].Contains("Сечения созданы"),
                "surface failure reports the committed sections");
        }

        private static void ReplacedLidarSourceCannotReceiveResults()
        {
            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.NextPilotResult =
                OperationResult<List<Topomatic.Cad.Foundation.Vector3D>>.Succeeded(
                    new List<Topomatic.Cad.Foundation.Vector3D> {
                        new Topomatic.Cad.Foundation.Vector3D(1, 2, 3) });
            GroundPointsCollector.DuringPilotCollect = delegate {
                LAS_TERRAIN.Service.LidarBufferService.Buffers =
                    new List<Topomatic.Lidar.LidarBuffer> {
                        new Topomatic.Lidar.LidarBuffer() };
            };
            Run(new CalculateSectionAsyncUseCase());
            Check(TopomaticSurfaceWriter.ApplyCalls == 0 &&
                SectionStepFixture.Warnings.Count == 1,
                "standard result from replaced LiDAR cannot reach surface");

            SectionStepFixture.Reset(3.0);
            GroundPointsCollector.DuringStationCollect = delegate {
                LAS_TERRAIN.Service.LidarBufferService.Buffers =
                    new List<Topomatic.Lidar.LidarBuffer> {
                        new Topomatic.Lidar.LidarBuffer() };
            };
            Run(new CalculateOneMeterSectionAsyncUseCase());
            Check(SectionStepFixture.Alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(SectionStepFixture.Alignment.Corridor.Sections[0],
                    SectionStepFixture.OriginalSection) &&
                SectionStepFixture.Warnings.Count == 1,
                "generated result from replaced LiDAR cannot replace sections");
        }

        public static int Main()
        {
            FixedStepAndCustomDefault();
            StandardCommandDoesNotGenerate();
            StandardCommandRejectsChangedSection();
            FailedCalculationPreservesSections();
            FailedCommitRollsBackSections();
            SuccessfulCalculationStagesSectionsBeforeSurface();
            StaleTargetIsRejected();
            SwitchedDocumentCannotReceiveResults();
            SurfaceFailureReportsPartialCommit();
            ReplacedLidarSourceCannotReceiveResults();
            Console.WriteLine("SectionStepCommandTests: " + _checks + " checks passed");
            return 0;
        }
    }
}
