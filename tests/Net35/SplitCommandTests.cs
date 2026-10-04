using System;
using System.IO;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Collector;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.Alg.Crs;
using Topomatic.Controls;

namespace LAS_TERRAIN.Tests
{
    internal static class SplitCommandTests
    {
        private static int checks;
        private static Section expectedSection;
        private static void Check(bool value, string label)
        {
            checks++;
            if (!value) throw new Exception(label);
        }

        private static Alignment Reset()
        {
            Alignment alignment = new Alignment();
            expectedSection = new Section {
                Station = 7, Id = 42, ConstructionId = 9,
                SectionLine = new object()
            };
            alignment.Corridor.Sections.Add(expectedSection);
            UserDialogs.SelectedAlignment = alignment;
            UserDialogs.PrimaryPath = Path.Combine(Path.GetTempPath(),
                "split-command-" + Guid.NewGuid().ToString("N") + ".las");
            UserDialogs.Left = 2.0;
            UserDialogs.Right = 4.0;
            UserDialogs.Warnings = 0;
            UserDialogs.Infos = 0;
            UserDialogs.OptionalCalls = 0;
            UserDialogs.CancelDialogCall = 0;
            UserDialogs.SourceChangeOnDialogCall = 0;
            UserDialogs.SelectionChangeOnDialogCall = 0;
            UserDialogs.SourceChangeOnSaveDialog = false;
            UserDialogs.LastWarning = null;
            UserDialogs.LastInfo = null;
            RawPointsCollector.Calls = 0;
            RawPointsCollector.OptionsCorrect = true;
            RawPointsCollector.Stations.Clear();
            RawPointsCollector.FilterMasks.Clear();
            RawPointsCollector.OuterStatus = OperationStatus.Success;
            RawPointsCollector.InnerStatus = OperationStatus.Success;
            RawPointsCollector.EmitBeforeTerminal = false;
            SaveLidarPointsService.Saves = 0;
            SaveLidarPointsService.ThrowOnSave = false;
            SaveLidarPointsService.Center = null;
            SaveLidarPointsService.Edge = null;
            SaveLidarPointsService.Request = null;
            SaveLidarPointsService.ChangeSourceDuringPreparation = false;
            SaveLidarPointsService.RestoreSourceAfterRejectedHook = false;
            SaveLidarPointsService.CancelDuringPreparation = false;
            SaveLidarPointsService.BeforePublishCalls = 0;
            LasPairPublication.RecoverCalls = 0;
            LasPairPublication.ThrowOnRecover = false;
            WaitProgress.Calls = 0;
            WaitProgress.CancelAfterCall = 0;
            WaitProgress.CancelDuringProgressCall = 0;
            WaitProgress.SourceChangeAfterCall = 0;
            WaitProgress.SourceChangeDuringProgressCall = 0;
            WaitProgress.ResetOnClose = false;
            WaitProgress.CancellationPending = false;
            SamplingHelper.ReduceCalls = 0;
            SamplingHelper.ThrowOnReduceCall = 0;
            SamplingHelper.ReturnEmpty = false;
            LasExportSourceContext.Valid = true;
            LasExportSourceContext.ReturnNull = false;
            LasExportSourceContext.Captures = 0;
            LasExportSourceContext.Checks = 0;
            LasExportSourceContext.InvalidateOnCheck = 0;
            return alignment;
        }

        private static void Unchanged(Alignment alignment, string label)
        {
            Check(alignment.Corridor.Sections.ClearCalls == 0 &&
                alignment.Corridor.Sections.AddStationCalls == 0 &&
                alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(alignment.Corridor.Sections[0], expectedSection) &&
                alignment.Corridor.Sections[0].Station == 7 &&
                alignment.Corridor.Sections[0].Id == 42 &&
                alignment.Corridor.Sections[0].ConstructionId == 9 &&
                alignment.Corridor.Sections[0].SectionLine != null,
                label + " changed existing CAD section");
        }

        private static bool NoPointSpoolRemains()
        {
            string path = UserDialogs.PrimaryPath;
            return Directory.GetFiles(Path.GetDirectoryName(path),
                Path.GetFileName(path) + ".*.points.tmp").Length == 0;
        }

        private static void Success()
        {
            Alignment alignment = Reset();
            Section original = alignment.Corridor.Sections[0];
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "success");
            Check(Object.ReferenceEquals(original, alignment.Corridor.Sections[0]),
                "success replaced section object");
            Check(RawPointsCollector.Calls == 2 &&
                RawPointsCollector.Stations.Count == 4 &&
                RawPointsCollector.Stations[0] == 0 &&
                RawPointsCollector.Stations[1] == 1 &&
                RawPointsCollector.Stations[2] == 0 &&
                RawPointsCollector.Stations[3] == 1,
                "outer and inner station order changed");
            Check(RawPointsCollector.FilterMasks.Count == 2 &&
                RawPointsCollector.FilterMasks[0] == 17 &&
                RawPointsCollector.FilterMasks[1] == 14,
                "boundary points belong to the center exactly once");
            Check(RawPointsCollector.OptionsCorrect,
                "slice thickness or alignment geometry offsets changed");
            Check(SaveLidarPointsService.Saves == 1 &&
                SaveLidarPointsService.Center.Count == 1 &&
                SaveLidarPointsService.Center[0].W == 22 * 257 &&
                SaveLidarPointsService.Edge.Count == 1 &&
                SaveLidarPointsService.Edge[0].W == 11 * 257,
                "primary and edge outputs were swapped");
            Check(SaveLidarPointsService.Request.EdgePath.EndsWith("_edge.las") &&
                UserDialogs.Warnings == 0, "pair path or success status changed");
            Check(LasExportSourceContext.Captures == 1 &&
                SaveLidarPointsService.BeforePublishCalls == 1,
                "source was not checked at the publication boundary");
            Check(NoPointSpoolRemains(), "successful split left point spools");
            Check(UserDialogs.Infos == 1 &&
                UserDialogs.LastInfo.Contains("импортируйте LAS") &&
                UserDialogs.LastInfo.Contains(UserDialogs.PrimaryPath),
                "split did not explain where its exported cloud is available");
        }

        private static void OffsetBoundaryOwnership(double left, double right,
            int expectedOuter, int expectedInner)
        {
            Alignment alignment = Reset();
            UserDialogs.Left = left;
            UserDialogs.Right = right;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "offset boundary");
            Check(RawPointsCollector.FilterMasks.Count == 2 &&
                RawPointsCollector.FilterMasks[0] == expectedOuter &&
                RawPointsCollector.FilterMasks[1] == expectedInner,
                "offset boundary routing changed");
            Check((expectedOuter & expectedInner) == 0 &&
                (expectedOuter | expectedInner) == 31,
                "finite probe point was lost or duplicated at an offset boundary");
        }

        private static void FractionalAlignmentTail()
        {
            Alignment alignment = Reset();
            alignment.Plan.CompoundLine.Length = 2.75;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "fractional alignment tail");
            Check(RawPointsCollector.Stations.Count == 8 &&
                RawPointsCollector.Stations[0] == 0 &&
                RawPointsCollector.Stations[1] == 1 &&
                RawPointsCollector.Stations[2] == 2 &&
                RawPointsCollector.Stations[3] == 2.75 &&
                RawPointsCollector.Stations[7] == 2.75,
                "fractional tail reaches alignment endpoint in both LAS passes");

            alignment = Reset();
            alignment.Plan.CompoundLine.Length = 2.25;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Check(RawPointsCollector.Stations.Count == 6 &&
                RawPointsCollector.Stations[2] == 2 &&
                RawPointsCollector.Stations[5] == 2,
                "covered fractional tail does not add a redundant station");
        }

        private static void InvalidOffset(bool left)
        {
            Alignment alignment = Reset();
            if (left) UserDialogs.Left = Double.NaN;
            else UserDialogs.Right = Double.PositiveInfinity;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "invalid offset");
            Check(UserDialogs.OptionalCalls == (left ? 1 : 2) &&
                RawPointsCollector.Calls == 0 &&
                SaveLidarPointsService.Saves == 0 && UserDialogs.Warnings == 1,
                "nonfinite offset reached collection or publication");
        }

        private static void SourceChangeDuringModal(int stage, bool duringProgress)
        {
            Alignment alignment = Reset();
            if (duringProgress) WaitProgress.SourceChangeDuringProgressCall = stage;
            else WaitProgress.SourceChangeAfterCall = stage;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "source change during modal");
            Check(WaitProgress.Calls == stage &&
                SaveLidarPointsService.Saves == 0 &&
                SourceWarningShown(),
                "stale source reached a later stage or publication");
        }

        private static void SourceChangeAfterSpool(int check, int collectionCalls)
        {
            Alignment alignment = Reset();
            LasExportSourceContext.InvalidateOnCheck = check;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "source change after point spool");
            Check(RawPointsCollector.Calls == collectionCalls &&
                SaveLidarPointsService.Saves == 0 && SourceWarningShown(),
                "changed source reached the next split stage after spooling");
            Check(NoPointSpoolRemains(), "source change left point spools");
        }

        private static void SourceUnavailableAtCapture()
        {
            Alignment alignment = Reset();
            LasExportSourceContext.ReturnNull = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "unavailable source");
            Check(LasExportSourceContext.Captures == 1 &&
                UserDialogs.OptionalCalls == 0 && WaitProgress.Calls == 0 &&
                SaveLidarPointsService.Saves == 0 && SourceWarningShown(),
                "unavailable source reached dialogs or publication");
        }

        private static void SourceChangeDuringDialog(int dialog)
        {
            Alignment alignment = Reset();
            UserDialogs.SourceChangeOnDialogCall = dialog;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "source change during dialog");
            Check(UserDialogs.OptionalCalls == dialog &&
                WaitProgress.Calls == 0 && SaveLidarPointsService.Saves == 0 &&
                SourceWarningShown(),
                "stale source passed a parameter dialog");
        }

        private static void SourceChangeDuringSaveDialog()
        {
            Alignment alignment = Reset();
            UserDialogs.SourceChangeOnSaveDialog = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "source change during save dialog");
            Check(WaitProgress.Calls == 0 &&
                SaveLidarPointsService.Saves == 0 && SourceWarningShown(),
                "stale source passed save dialog");
        }

        private static void SourceChangeDuringLasPreparation()
        {
            Alignment alignment = Reset();
            SaveLidarPointsService.ChangeSourceDuringPreparation = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "source change during LAS preparation");
            Check(WaitProgress.Calls == 4 &&
                SaveLidarPointsService.BeforePublishCalls == 1 &&
                SaveLidarPointsService.Saves == 0 && SourceWarningShown(),
                "stale source was published after LAS preparation");
        }

        private static void TransientSourceChangeDuringLasPreparation()
        {
            Alignment alignment = Reset();
            SaveLidarPointsService.ChangeSourceDuringPreparation = true;
            SaveLidarPointsService.RestoreSourceAfterRejectedHook = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "transient source change during LAS preparation");
            Check(LasExportSourceContext.Valid &&
                SaveLidarPointsService.BeforePublishCalls == 1 &&
                SaveLidarPointsService.Saves == 0 && SourceWarningShown(),
                "transient source rejection was reported as success or silently cancelled");
        }

        private static void CancellationDuringLasPreparationStaysSilent()
        {
            Alignment alignment = Reset();
            SaveLidarPointsService.CancelDuringPreparation = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "cancellation during LAS preparation");
            Check(SaveLidarPointsService.BeforePublishCalls == 0 &&
                SaveLidarPointsService.Saves == 0 && UserDialogs.Warnings == 0,
                "ordinary LAS preparation cancellation showed a source warning");
        }

        private static bool SourceWarningShown()
        {
            return UserDialogs.Warnings == 1 &&
                UserDialogs.LastWarning != null &&
                UserDialogs.LastWarning.Contains("LAS-файлы не сохранены");
        }

        private static void SelectionOnlyChangeKeepsCapturedSource()
        {
            Alignment alignment = Reset();
            UserDialogs.SelectionChangeOnDialogCall = 2;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "selection-only change");
            Check(!Object.ReferenceEquals(UserDialogs.SelectedAlignment, alignment) &&
                RawPointsCollector.Calls == 2 && SaveLidarPointsService.Saves == 1 &&
                UserDialogs.Warnings == 0,
                "selection-only change rejected the captured LAS source");
        }

        private static void Terminal(int stage, OperationStatus status)
        {
            Alignment alignment = Reset();
            if (stage == 1) RawPointsCollector.OuterStatus = status;
            else RawPointsCollector.InnerStatus = status;
            RawPointsCollector.EmitBeforeTerminal = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "terminal collection");
            Check(RawPointsCollector.Calls == stage &&
                SaveLidarPointsService.Saves == 0,
                "published after terminal collection status");
            Check(UserDialogs.Warnings == (status == OperationStatus.Cancelled ? 0 : 1),
                "wrong terminal collection warning");
            Check(NoPointSpoolRemains(),
                "partial point spool remained after terminal collection status");
        }

        private static void EmptyOutput(OperationStatus outer, OperationStatus inner)
        {
            Alignment alignment = Reset();
            RawPointsCollector.OuterStatus = outer;
            RawPointsCollector.InnerStatus = inner;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "empty output");
            bool bothEmpty = outer == OperationStatus.Empty && inner == OperationStatus.Empty;
            Check(SaveLidarPointsService.Saves == (bothEmpty ? 0 : 1),
                "empty output publication policy changed");
            if (bothEmpty)
                Check(UserDialogs.Warnings == 1, "both-empty warning missing");
            else
                Check(SaveLidarPointsService.Center.Count ==
                    (inner == OperationStatus.Empty ? 0 : 1) &&
                    SaveLidarPointsService.Edge.Count ==
                    (outer == OperationStatus.Empty ? 0 : 1),
                    "one-sided output was routed incorrectly");
        }

        private static void InvalidLength(double length)
        {
            Alignment alignment = Reset();
            alignment.Plan.CompoundLine.Length = length;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "invalid length");
            Check(RawPointsCollector.Calls == 0 &&
                SaveLidarPointsService.Saves == 0 && UserDialogs.Warnings == 1,
                "invalid length reached collection or export");
        }

        private static void Cancellation(int stage)
        {
            Alignment alignment = Reset();
            WaitProgress.CancelAfterCall = stage;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "progress cancellation");
            Check(RawPointsCollector.Calls == stage &&
                SaveLidarPointsService.Saves == 0,
                "progress cancellation reached publication");
        }

        private static void CollectionCancellationResetOnClose(int stage)
        {
            Alignment alignment = Reset();
            WaitProgress.CancelDuringProgressCall = stage;
            WaitProgress.ResetOnClose = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "collection cancellation reset on close");
            Check(RawPointsCollector.Calls == stage &&
                WaitProgress.Calls == stage &&
                !WaitProgress.CancellationPending &&
                SamplingHelper.ReduceCalls == 0 &&
                SaveLidarPointsService.Saves == 0 && UserDialogs.Warnings == 0,
                "closed collection modal lost cancellation and continued export");
        }

        private static void ReductionCancellation(int stage, bool resetOnClose)
        {
            Alignment alignment = Reset();
            WaitProgress.ResetOnClose = resetOnClose;
            if (resetOnClose) WaitProgress.CancelDuringProgressCall = stage;
            else WaitProgress.CancelAfterCall = stage;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "reduction cancellation");
            Check(RawPointsCollector.Calls == 2 &&
                SamplingHelper.ReduceCalls == stage - 2 &&
                WaitProgress.Calls == stage &&
                SaveLidarPointsService.Saves == 0,
                "reduction cancellation reached another stage or publication");
            Check(UserDialogs.Warnings == 0,
                "reduction cancellation was reported as a failure");
        }

        private static void ReductionFailure(int stage)
        {
            Alignment alignment = Reset();
            SamplingHelper.ThrowOnReduceCall = stage - 2;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "reduction failure");
            Check(SamplingHelper.ReduceCalls == stage - 2 &&
                WaitProgress.Calls == stage &&
                SaveLidarPointsService.Saves == 0 && UserDialogs.Warnings == 1,
                "reduction failure was not contained before publication");
        }

        private static void SaveFailure()
        {
            Alignment alignment = Reset();
            SaveLidarPointsService.ThrowOnSave = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "save failure");
            Check(SaveLidarPointsService.Saves == 1 && UserDialogs.Warnings == 1 &&
                UserDialogs.Infos == 0,
                "save failure was not reported");
            Check(NoPointSpoolRemains(), "failed split left point spools");
        }

        private static void EmptyAfterReduction()
        {
            Alignment alignment = Reset();
            SamplingHelper.ReturnEmpty = true;
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Unchanged(alignment, "empty reduction");
            Check(SaveLidarPointsService.Saves == 0 &&
                UserDialogs.Warnings == 1 && UserDialogs.Infos == 0,
                "empty reduction reported a saved LAS");
            Check(NoPointSpoolRemains(), "empty reduction left point spools");
        }

        private static void EmptyCorridorSuccess()
        {
            Alignment alignment = Reset();
            alignment.Corridor.Sections.RemoveAt(0);
            new SplitLasByOffsetUseCase().Run(new SectionEnv());
            Check(alignment.Corridor.Sections.ClearCalls == 0 &&
                alignment.Corridor.Sections.AddStationCalls == 0 &&
                alignment.Corridor.Sections.Count == 0 &&
                SaveLidarPointsService.Saves == 1,
                "split created CAD sections in an empty corridor");
        }

        private static void Recovery(bool fail)
        {
            Alignment alignment = Reset();
            string journal = LasPairPublication.JournalPath(UserDialogs.PrimaryPath);
            File.WriteAllText(journal, "fixture");
            LasPairPublication.ThrowOnRecover = fail;
            try
            {
                new SplitLasByOffsetUseCase().Run(new SectionEnv());
                Unchanged(alignment, "pair recovery");
                Check(LasPairPublication.RecoverCalls == 1 &&
                    RawPointsCollector.Calls == 0 &&
                    SaveLidarPointsService.Saves == 0,
                    "journal recovery did not stop recollection");
                Check(UserDialogs.Warnings == (fail ? 1 : 0) &&
                    UserDialogs.Infos == (fail ? 0 : 1),
                    "journal recovery status changed");
            }
            finally { File.Delete(journal); }
        }

        public static int Main()
        {
            Success();
            FractionalAlignmentTail();
            OffsetBoundaryOwnership(0, 0, 27, 4);
            OffsetBoundaryOwnership(-2, 4, 23, 8);
            OffsetBoundaryOwnership(-5, 4, 31, 0);
            InvalidOffset(true);
            InvalidOffset(false);
            Terminal(1, OperationStatus.Cancelled);
            Terminal(1, OperationStatus.Overflow);
            Terminal(1, OperationStatus.Failed);
            Terminal(2, OperationStatus.Cancelled);
            Terminal(2, OperationStatus.Overflow);
            Terminal(2, OperationStatus.Failed);
            EmptyOutput(OperationStatus.Empty, OperationStatus.Empty);
            EmptyOutput(OperationStatus.Empty, OperationStatus.Success);
            EmptyOutput(OperationStatus.Success, OperationStatus.Empty);
            InvalidLength(Double.NaN);
            InvalidLength(Double.PositiveInfinity);
            InvalidLength(100001.0);
            Cancellation(1);
            Cancellation(2);
            CollectionCancellationResetOnClose(1);
            CollectionCancellationResetOnClose(2);
            ReductionCancellation(3, false);
            ReductionCancellation(4, false);
            ReductionCancellation(3, true);
            ReductionCancellation(4, true);
            ReductionFailure(3);
            ReductionFailure(4);
            SaveFailure();
            EmptyAfterReduction();
            EmptyCorridorSuccess();
            Recovery(false);
            Recovery(true);
            SourceUnavailableAtCapture();
            SelectionOnlyChangeKeepsCapturedSource();
            for (int dialog = 1; dialog <= 4; dialog++)
                SourceChangeDuringDialog(dialog);
            SourceChangeDuringSaveDialog();
            for (int stage = 1; stage <= 4; stage++)
            {
                SourceChangeDuringModal(stage, false);
                SourceChangeDuringModal(stage, true);
            }
            SourceChangeDuringLasPreparation();
            SourceChangeAfterSpool(9, 1);
            SourceChangeAfterSpool(11, 2);
            TransientSourceChangeDuringLasPreparation();
            CancellationDuringLasPreparationStaysSilent();
            Console.WriteLine("Split command: " + checks + " checks passed.");
            return 0;
        }
    }
}
