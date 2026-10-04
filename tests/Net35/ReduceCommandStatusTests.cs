using System;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Models;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Service.Collector;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Controls;

namespace LAS_TERRAIN.Tests
{
    internal static class ReduceCommandStatusTests
    {
        private static int checks;

        private static void Check(bool value, string name)
        {
            checks++;
            if (!value) throw new Exception(name);
        }

        private static Alignment SelectWithUserSection()
        {
            Alignment alignment = new Alignment();
            alignment.Corridor.Sections.Add(new Section {
                Station = 7.0, Id = 42, ConstructionId = 9,
                SectionLine = new object()
            });
            UserDialogs.SelectedAlignment = alignment;
            return alignment;
        }

        private static void CheckUserSection(Alignment alignment, Section original,
            string label)
        {
            Check(alignment.Corridor.Sections.ClearCalls == 0 &&
                alignment.Corridor.Sections.AddStationCalls == 0 &&
                alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(alignment.Corridor.Sections[0], original) &&
                original.Id == 42 && original.ConstructionId == 9 &&
                original.SectionLine != null && original.Station == 7.0,
                label + " changed a user section");
        }

        private static void RunCase(ISectionUseCase command, SectionCollectStatus status,
            bool unexpectedFailure)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.RequestedStations.Clear();
            LasSectionPointsCollectorService.TerminalCall =
                status == SectionCollectStatus.Success && !unexpectedFailure ? 0 : 2;
            LasSectionPointsCollectorService.TerminalStatus = status;
            LasSectionPointsCollectorService.ThrowUnexpected = unexpectedFailure;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.WrittenWeights.Clear();
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            SamplingHelper.ReduceToOne = false;
            GraphGround3DFilter.DuplicateOutput = false;
            LAS_TERRAIN.Infrastructure.TopomaticIndexScheduler.Calls = 0;

            command.Run(new SectionEnv());

            Check(LasSectionPointsCollectorService.Calls == 2,
                command.Name + " did not visit both sections");
            Check(LasSectionPointsCollectorService.RequestedStations.Count == 2 &&
                LasSectionPointsCollectorService.RequestedStations[0] == 0.0 &&
                LasSectionPointsCollectorService.RequestedStations[1] == 1.0,
                command.Name + " changed the station sequence");
            CheckUserSection(alignment, original, command.Name);
            UserDialogs.SelectedAlignment = null;
            if (status == SectionCollectStatus.Success && !unexpectedFailure)
            {
                if (command is ReduceWithGroundRedSectorUseCase)
                    Check(LAS_TERRAIN.Infrastructure.TopomaticIndexScheduler.Calls == 2,
                        "3D command did not pass the host scheduler to each batch");
                Check(LasBatchStreamWriter.Writes == 2 &&
                    LasBatchStreamWriter.Completes == 1 &&
                    LasBatchStreamWriter.Publishes == 1,
                    command.Name + " did not publish complete output");
                Check(LasBatchStreamWriter.WrittenWeights.Count == 2 &&
                    LasBatchStreamWriter.WrittenWeights[0] == 257 &&
                    LasBatchStreamWriter.WrittenWeights[1] == 514,
                    command.Name + " did not expand SDK byte weights for LAS");
                Check(UserDialogs.Infos == 1 && UserDialogs.Warnings == 0,
                    command.Name + " success UI");
                Check(UserDialogs.LastInfo != null &&
                    UserDialogs.LastInfo.Contains("импортируйте LAS"),
                    command.Name + " did not explain how to use the saved cloud");
            }
            else
            {
                Check(LasBatchStreamWriter.Writes == 1,
                    command.Name + " did not stage the first batch");
                Check(LasBatchStreamWriter.Completes == 0 &&
                    LasBatchStreamWriter.Publishes == 0,
                    command.Name + " published after terminal collection status");
                Check(UserDialogs.Infos == 0,
                    command.Name + " reported success after terminal status");
                Check(UserDialogs.Warnings ==
                    (status == SectionCollectStatus.Cancelled ? 0 : 1),
                    command.Name + " terminal UI");
            }
        }

        private static void CancellationAfterWorkRejectsPreparedResult(ISectionUseCase command,
            bool throwAfterWork)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.RequestedStations.Clear();
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.Disposes = 0;
            PreparedLasFile.Disposes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = true;
            WaitProgress.ThrowCancellationAfterWork = throwAfterWork;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            try
            {
                command.Run(new SectionEnv());
                Check(LasBatchStreamWriter.Completes == 1 &&
                    LasBatchStreamWriter.Publishes == 0 &&
                    LasBatchStreamWriter.Disposes == 1 && PreparedLasFile.Disposes == 1,
                    command.Name + " published or leaked after modal cancellation");
                Check(UserDialogs.Infos == 0 && UserDialogs.Warnings == 0,
                    command.Name + " reported a canceled prepared LAS");
                CheckUserSection(alignment, original, command.Name + " modal cancel");
            }
            finally
            {
                WaitProgress.CancelAfterWork = false;
                WaitProgress.ThrowCancellationAfterWork = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void PublishedResultSurvivesLateCancellation(ISectionUseCase command,
            bool throwAfterPublish)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.Disposes = 0;
            PreparedLasFile.Disposes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            PreparedLasFile.AfterPublish = delegate
            {
                WaitProgress.CancellationPending = true;
                if (throwAfterPublish) throw new OperationCanceledException();
            };
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            try
            {
                command.Run(new SectionEnv());
                Check(LasBatchStreamWriter.Publishes == 1 &&
                    LasBatchStreamWriter.Completes == 1 &&
                    LasBatchStreamWriter.Disposes == 1 && PreparedLasFile.Disposes == 1,
                    command.Name + " lost an already published LAS");
                Check(UserDialogs.Infos == 1 && UserDialogs.Warnings == 0,
                    command.Name + " hid a committed LAS after late cancellation");
                CheckUserSection(alignment, original, command.Name + " late cancel");
            }
            finally
            {
                PreparedLasFile.AfterPublish = null;
                WaitProgress.CancellationPending = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void GroundCountPrecedesReduction()
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasBatchStreamWriter.Publishes = 0;
            UserDialogs.Infos = 0;
            UserDialogs.LastInfo = null;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            GraphGround3DFilter.DuplicateOutput = true;
            SamplingHelper.ReduceToOne = true;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            try
            {
                new ReduceWithGroundRedSectorUseCase().Run(new SectionEnv());
                Check(LasBatchStreamWriter.Publishes == 1 && UserDialogs.Infos == 1,
                    "ground reduction fixture did not publish");
                Check(UserDialogs.LastInfo != null &&
                    UserDialogs.LastInfo.Contains("Ground Filter: 4") &&
                    UserDialogs.LastInfo.Contains(": 2\n"),
                    "ground and reduced counts must describe different stages");
                CheckUserSection(alignment, original, "ground counts");
            }
            finally
            {
                GraphGround3DFilter.DuplicateOutput = false;
                SamplingHelper.ReduceToOne = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void CancellationDuringGroundFilter()
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            UserDialogs.Infos = 0;
            UserDialogs.Warnings = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            GraphGround3DFilter.CancelDuringFilter = true;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            try
            {
                new ReduceWithGroundRedSectorUseCase().Run(new SectionEnv());
                CheckUserSection(alignment, original, "ground filter cancellation");
                Check(LasSectionPointsCollectorService.Calls == 1 &&
                    LasBatchStreamWriter.Writes == 0 &&
                    LasBatchStreamWriter.Completes == 0 &&
                    LasBatchStreamWriter.Publishes == 0,
                    "Ground filter published a cancelled batch.");
                Check(UserDialogs.Infos == 0 && UserDialogs.Warnings == 0,
                    "Ground filter cancellation reported success or failure.");
            }
            finally
            {
                GraphGround3DFilter.CancelDuringFilter = false;
                WaitProgress.CancellationPending = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void InvalidStationPlanPreservesSections(ISectionUseCase command,
            double length)
        {
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            alignment.Plan.CompoundLine.Length = length;
            UserDialogs.Infos = 0;
            UserDialogs.Warnings = 0;
            LasSectionPointsCollectorService.Calls = 0;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Publishes = 0;
            WaitProgress.CancellationPending = false;
            try
            {
                command.Run(new SectionEnv());
                CheckUserSection(alignment, original, command.Name + " invalid plan");
                Check(LasSectionPointsCollectorService.Calls == 0 &&
                    LasBatchStreamWriter.Writes == 0 &&
                    LasBatchStreamWriter.Publishes == 0 &&
                    UserDialogs.Warnings == 1 && UserDialogs.Infos == 0,
                    command.Name + " continued after invalid stations");
            }
            finally { UserDialogs.SelectedAlignment = null; }
        }

        private static void ExportOutcomeKeepsSections(ISectionUseCase command,
            bool empty, bool writeFailure, bool publishFailure)
        {
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasSectionPointsCollectorService.EmitEmpty = empty;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.Disposes = 0;
            PreparedLasFile.Disposes = 0;
            LasBatchStreamWriter.ThrowOnWrite = writeFailure;
            LasBatchStreamWriter.ThrowOnPublish = publishFailure;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            try
            {
                command.Run(new SectionEnv());
                CheckUserSection(alignment, original, command.Name + " export outcome");
                Check(LasBatchStreamWriter.Publishes == 0 &&
                    UserDialogs.Infos == 0 && UserDialogs.Warnings == 1,
                    command.Name + " reported unpublished output as success");
                Check(LasBatchStreamWriter.Disposes == 1 &&
                    PreparedLasFile.Disposes == (publishFailure ? 1 : 0),
                    command.Name + " leaked an unpublished LAS stage");
                Check(LasSectionPointsCollectorService.Calls ==
                    (writeFailure ? 1 : 2),
                    command.Name + " changed collection sequence");
            }
            finally
            {
                LasSectionPointsCollectorService.EmitEmpty = false;
                LasBatchStreamWriter.ThrowOnWrite = false;
                LasBatchStreamWriter.ThrowOnPublish = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void CancelPercentPreservesSectionsAndOutput(ISectionUseCase command)
        {
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            LasSectionPointsCollectorService.Calls = 0;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            UserDialogs.SavePathRequests = 0;
            LasBatchStreamWriter.Opens = 0;
            UserDialogs.CancelPercentInput = true;
            try
            {
                command.Run(new SectionEnv());
                CheckUserSection(alignment, original, command.Name + " cancelled percent");
                Check(LasSectionPointsCollectorService.Calls == 0 &&
                    UserDialogs.SavePathRequests == 0 &&
                    LasBatchStreamWriter.Opens == 0 &&
                    LasBatchStreamWriter.Writes == 0 &&
                    LasBatchStreamWriter.Completes == 0 &&
                    LasBatchStreamWriter.Publishes == 0 &&
                    UserDialogs.Warnings == 0 && UserDialogs.Infos == 0,
                    command.Name + " continued after cancelled percent input");
            }
            finally
            {
                UserDialogs.CancelPercentInput = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void CancellationDuringSampling(ISectionUseCase command,
            int sampleCall, bool resetOnClose)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasSectionPointsCollectorService.EmitEmpty = false;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.ThrowOnWrite = false;
            LasBatchStreamWriter.ThrowOnPublish = false;
            SamplingHelper.Calls = 0;
            SamplingHelper.Polls = 0;
            SamplingHelper.CancelOnCall = sampleCall;
            SamplingHelper.CancelOnPoll = 2;
            SamplingHelper.ReduceToOne = false;
            GraphGround3DFilter.DuplicateOutput = false;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            WaitProgress.ResetCancellationOnClose = resetOnClose;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            try
            {
                command.Run(new SectionEnv());
                CheckUserSection(alignment, original, command.Name + " sampling cancel");
                Check(SamplingHelper.Calls == sampleCall &&
                    SamplingHelper.Polls == (sampleCall - 1) * 3 + 2,
                    command.Name + " continued sampling after cancellation");
                Check(LasSectionPointsCollectorService.Calls == sampleCall,
                    command.Name + " visited another section after sampling cancellation");
                Check(LasBatchStreamWriter.Writes == sampleCall - 1 &&
                    LasBatchStreamWriter.Completes == 0 &&
                    LasBatchStreamWriter.Publishes == 0,
                    command.Name + " committed a cancelled sample");
                Check(UserDialogs.Infos == 0 && UserDialogs.Warnings == 0,
                    command.Name + " reported success or failure for cancellation");
                if (resetOnClose)
                    Check(!WaitProgress.CancellationPending,
                        command.Name + " fixture did not reset modal cancellation flag");
            }
            finally
            {
                SamplingHelper.CancelOnCall = 0;
                SamplingHelper.CancelOnPoll = 0;
                WaitProgress.ResetCancellationOnClose = false;
                WaitProgress.CancellationPending = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void ChangedSourceRejectsOutput(ISectionUseCase command,
            string stage, string change, Action<TestCadView, Alignment> mutate)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasSectionPointsCollectorService.EmitEmpty = false;
            LasBatchStreamWriter.Opens = 0;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.Disposes = 0;
            PreparedLasFile.Disposes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            UserDialogs.SavePathRequests = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            WaitProgress.AfterWork = null;
            WaitProgress.OnProgressChange = null;
            LasExportSourceContext.CaptureCalls = 0;
            LasExportSourceContext.IsCurrentCalls = 0;
            LasExportSourceContext.IsCurrentInsideCallback = 0;
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            SectionEnv env = new SectionEnv();
            TestCadView view = (TestCadView)env.CadView;
            Action changeSource = delegate { mutate(view, alignment); };
            if (stage == "percent") UserDialogs.AfterPercentDialog = changeSource;
            else if (stage == "save") UserDialogs.AfterSaveDialog = changeSource;
            else if (stage == "progress") WaitProgress.OnProgressChange = changeSource;
            else if (stage == "modal-close") WaitProgress.AfterWork = changeSource;
            else throw new ArgumentException("Unknown switch stage", "stage");
            try
            {
                command.Run(env);
                Check(LasExportSourceContext.CaptureCalls == 1 &&
                    LasExportSourceContext.IsCurrentInsideCallback == 0,
                    command.Name + " did not capture source or probed CAD in callback: " + stage + change);
                Check(LasBatchStreamWriter.Publishes == 0 &&
                    UserDialogs.Infos == 0 && UserDialogs.Warnings == 1,
                    command.Name + " published changed source: " + stage + change);
                if (stage == "percent" || stage == "save")
                {
                    Check(LasBatchStreamWriter.Opens == 0 &&
                        LasSectionPointsCollectorService.Calls == 0 &&
                        UserDialogs.SavePathRequests == (stage == "percent" ? 0 : 1),
                        command.Name + " started export after dialog source change: " + stage + change);
                }
                else
                {
                    Check(LasBatchStreamWriter.Opens == 1 &&
                        LasBatchStreamWriter.Completes == 1 &&
                        LasBatchStreamWriter.Disposes == 1 &&
                        PreparedLasFile.Disposes == 1,
                        command.Name + " retained a prepared stage after source change: " + stage + change);
                    Check(LasSectionPointsCollectorService.Calls == 2,
                        command.Name + " changed collection order: " + stage + change);
                }
                CheckUserSection(alignment, original, command.Name + " source switch " + stage + change);
            }
            finally
            {
                UserDialogs.AfterPercentDialog = null;
                UserDialogs.AfterSaveDialog = null;
                WaitProgress.OnProgressChange = null;
                WaitProgress.AfterWork = null;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void SourceChangeCases(ISectionUseCase command)
        {
            ChangedSourceRejectsOutput(command, "percent", "project",
                delegate(TestCadView view, Alignment alignment) { view.Project = new object(); });
            ChangedSourceRejectsOutput(command, "save", "document",
                delegate(TestCadView view, Alignment alignment) { view.Document = new object(); });
            ChangedSourceRejectsOutput(command, "progress", "model",
                delegate(TestCadView view, Alignment alignment) { alignment.Model = new object(); });
            ChangedSourceRejectsOutput(command, "progress", "alignment identity",
                delegate(TestCadView view, Alignment alignment) { alignment.SourceIdentity += "-edited"; });
            ChangedSourceRejectsOutput(command, "progress", "buffer",
                delegate(TestCadView view, Alignment alignment)
                { LidarBufferService.CurrentBuffers = new System.Collections.Generic.List<Topomatic.Lidar.LidarBuffer>
                    { new Topomatic.Lidar.LidarBuffer() }; });
            ChangedSourceRejectsOutput(command, "progress", "index",
                delegate(TestCadView view, Alignment alignment)
                { LidarBufferService.CurrentBuffers[0].Index = new object(); });
            ChangedSourceRejectsOutput(command, "progress", "source metadata",
                delegate(TestCadView view, Alignment alignment)
                { LidarBufferService.CurrentBuffers[0].MetadataRevision++; });
            ChangedSourceRejectsOutput(command, "progress", "source path",
                delegate(TestCadView view, Alignment alignment)
                { LidarBufferService.CurrentBuffers[0].SourcePath += ".moved"; });
            ChangedSourceRejectsOutput(command, "progress", "geometry",
                delegate(TestCadView view, Alignment alignment)
                { alignment.GeometryRevision++; });
            ChangedSourceRejectsOutput(command, "modal-close", "alignment length",
                delegate(TestCadView view, Alignment alignment)
                { alignment.Plan.CompoundLine.Length += 1.0; });
        }

        private static void CaptureFailureRejectsOutput(ISectionUseCase command)
        {
            Alignment alignment = SelectWithUserSection();
            Section original = alignment.Corridor.Sections[0];
            LasExportSourceContext.ForceCaptureFailure = true;
            LasBatchStreamWriter.Opens = 0;
            LasBatchStreamWriter.Publishes = 0;
            UserDialogs.SavePathRequests = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            try
            {
                command.Run(new SectionEnv());
                Check(LasBatchStreamWriter.Opens == 0 &&
                    LasBatchStreamWriter.Publishes == 0 &&
                    UserDialogs.SavePathRequests == 0 &&
                    UserDialogs.Warnings == 1 && UserDialogs.Infos == 0,
                    command.Name + " continued after source capture failed");
                CheckUserSection(alignment, original, command.Name + " source capture failure");
            }
            finally
            {
                LasExportSourceContext.ForceCaptureFailure = false;
                UserDialogs.SelectedAlignment = null;
            }
        }

        private static void SelectionOnlyChangeRetainsCapturedSource(ISectionUseCase command)
        {
            LasSectionPointsCollectorService.Calls = 0;
            LasSectionPointsCollectorService.TerminalCall = 0;
            LasSectionPointsCollectorService.ThrowUnexpected = false;
            LasBatchStreamWriter.Writes = 0;
            LasBatchStreamWriter.Completes = 0;
            LasBatchStreamWriter.Publishes = 0;
            LasBatchStreamWriter.Disposes = 0;
            PreparedLasFile.Disposes = 0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            WaitProgress.CancellationPending = false;
            WaitProgress.CancelAfterWork = false;
            WaitProgress.ThrowCancellationAfterWork = false;
            Alignment captured = SelectWithUserSection();
            Section original = captured.Corridor.Sections[0];
            UserDialogs.AfterSaveDialog = delegate { UserDialogs.SelectedAlignment = new Alignment(); };
            try
            {
                command.Run(new SectionEnv());
                Check(LasBatchStreamWriter.Publishes == 1 &&
                    LasBatchStreamWriter.Disposes == 1 &&
                    PreparedLasFile.Disposes == 1 &&
                    UserDialogs.Infos == 1 && UserDialogs.Warnings == 0,
                    command.Name + " rejected unchanged captured source after UI selection moved");
                CheckUserSection(captured, original, command.Name + " UI selection change");
            }
            finally
            {
                UserDialogs.AfterSaveDialog = null;
                UserDialogs.SelectedAlignment = null;
            }
        }

        public static int Main(string[] args)
        {
            ISectionUseCase[] commands = new ISectionUseCase[]
            {
                new ReduceLasAsyncToPercentUseCase(),
                new ReduceWithGroundRedSectorUseCase()
            };
            foreach (ISectionUseCase command in commands)
            {
                CancelPercentPreservesSectionsAndOutput(command);
                RunCase(command, SectionCollectStatus.Success, false);
                RunCase(command, SectionCollectStatus.Overflow, false);
                RunCase(command, SectionCollectStatus.Cancelled, false);
                RunCase(command, SectionCollectStatus.Success, true);
                CancellationAfterWorkRejectsPreparedResult(command, false);
                CancellationAfterWorkRejectsPreparedResult(command, true);
                PublishedResultSurvivesLateCancellation(command, false);
                PublishedResultSurvivesLateCancellation(command, true);
                InvalidStationPlanPreservesSections(command, Double.NaN);
                InvalidStationPlanPreservesSections(command, Double.PositiveInfinity);
                InvalidStationPlanPreservesSections(command, 100001.0);
                ExportOutcomeKeepsSections(command, true, false, false);
                ExportOutcomeKeepsSections(command, false, true, false);
                ExportOutcomeKeepsSections(command, false, false, true);
                CancellationDuringSampling(command, 1, false);
                CancellationDuringSampling(command, 2, true);
                SourceChangeCases(command);
                CaptureFailureRejectsOutput(command);
                SelectionOnlyChangeRetainsCapturedSource(command);
            }
            GroundCountPrecedesReduction();
            CancellationDuringGroundFilter();
            Console.WriteLine("Reduce command publication: " + checks + " checks passed.");
            return 0;
        }
    }
}
