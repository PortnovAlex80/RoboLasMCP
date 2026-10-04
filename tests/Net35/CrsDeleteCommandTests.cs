using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;
using Topomatic.Lidar;
using Topomatic.ApplicationPlatform;

namespace LAS_TERRAIN.Tests
{
    public static class CrsDeleteFixture
    {
        public static Alignment Alignment;
        public static Model Model;
        public static Guid AlignmentId;
        public static List<LidarBuffer> Buffers;
        public static List<CrsPolygonEntry> Polygons;
        public static List<Vector4D> Published;
        public static string OutputPath;
        public static int ClearCalls, WriteCalls, MaxBatch, CompleteCalls, PublishCalls;
        public static int BatchSize;
        public static int Visits, CancelAtVisit, FailAtVisit;
        public static bool CancelAfterWrite, CancelAfterPublish, ThrowAfterAction;
        public static bool FailAtCompletionProgress;
        public static bool CancelAtCompletionProgress;
        public static bool FailComplete, FailPublish, FailClear;
        public static bool PolygonsChanged;
        public static Action OnConfirm, OnSaveDialog, OnProgressEnd, OnPublish;

        public static void Reset()
        {
            Alignment = new Alignment();
            var project = new Project();
            Model = new Model { Project = project };
            AlignmentId = Guid.NewGuid();
            ApplicationHost.Current = new ApplicationHost {
                ActiveProject = project, ActiveDocument = new object() };
            Buffers = new List<LidarBuffer> { new LidarBuffer() };
            Polygons = new List<CrsPolygonEntry> {
                new CrsPolygonEntry { SectionIndex = 0, Station = 0,
                    Polygon = new List<Vector2D> { new Vector2D(0, 0) } } };
            Published = new List<Vector4D> { new Vector4D(99, 99, 99, 99) };
            OutputPath = @"C:\fixture\out.las";
            ClearCalls = WriteCalls = MaxBatch = CompleteCalls = PublishCalls = 0;
            BatchSize = 3;
            Visits = CancelAtVisit = FailAtVisit = 0;
            CancelAfterWrite = CancelAfterPublish = ThrowAfterAction = false;
            FailAtCompletionProgress = false;
            CancelAtCompletionProgress = false;
            FailComplete = FailPublish = FailClear = false;
            PolygonsChanged = false;
            ScopedPolygonOperationContext.Reset();
            OnConfirm = OnSaveDialog = OnProgressEnd = OnPublish = null;
            LAS_TERRAIN.Configuration.RuntimeConfig.CrsOverlayBorder = 2;
            WaitProgress.CancellationPending = false;
            MessageDlg.Messages.Clear();
            Topomatic.FoundationClasses.Parallel.Parallel.Reverse = true;
        }

        public static void VisitPoint()
        {
            Visits++;
            if (Visits == CancelAtVisit)
                WaitProgress.CancellationPending = true;
            if (Visits == FailAtVisit)
                throw new InvalidOperationException("injected scan error");
        }

        public static void AddIndexer(params float[] heights)
        {
            var points = new Vector3F[heights.Length];
            var weights = new byte[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                points[i] = new Vector3F(0.25f, 0, heights[i]);
                weights[i] = (byte)(i + 1);
            }
            Buffers[0].indexers.Add(new QuadTreeIndexer {
                points = new PointArray { Values = points },
                weights = new WeightArray { Values = weights },
                scale = new Vector3D(2, 1, 1)
            });
        }
    }

    public static class CrsDeleteCommandTests
    {
        private static int checks;
        private static void Check(bool condition, string reason)
        {
            checks++;
            if (!condition) throw new Exception(reason);
        }

        private static void Run()
        { new CrsDeletePointsUseCase().Run(new SectionEnv()); }

        private static void PreservesRecordsAndBoundsBatch()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(2, 1, 3, 4, 5);
            CrsDeleteFixture.AddIndexer(6, 7, 1, 8);
            Run();
            var output = CrsDeleteFixture.Published;
            Check(CrsDeleteFixture.PublishCalls == 1, "successful export published once");
            Check(CrsDeleteFixture.ClearCalls == 1, "successful export clears polygons");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("импортируйте LAS"),
                "CRS deletion must explain that the exported cloud is not attached");
            Check(output.Count == 7, "kept point count");
            float[] expected = { 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < expected.Length; i++)
            {
                Check(output[i].Z == expected[i], "source record order " + i);
                Check(output[i].X == 0.5 && output[i].Y == 0, "world transform " + i);
            }
            Check(output[0].W == 1.0 * 257.0,
                "16-bit intensity expansion");
            Check(output[1].W == 3.0 * 257.0,
                "intensity keeps source point index after deletion");
            Check(CrsDeleteFixture.MaxBatch <= 3 && CrsDeleteFixture.MaxBatch > 0,
                "bounded batch even with multi-indexer input");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(2, 1);
            CrsDeleteFixture.Buffers[0].indexers[0].weights = null;
            Run();
            Check(CrsDeleteFixture.Published.Count == 1 &&
                CrsDeleteFixture.Published[0].W == UInt16.MaxValue,
                "missing weights use full LAS intensity");
        }

        private static void RejectIncompleteWeights()
        {
            for (int mode = 0; mode < 3; mode++)
            {
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.AddIndexer(1, 2);
                WeightArray weights = CrsDeleteFixture.Buffers[0].indexers[0].weights;
                if (mode == 0) weights.Values = new byte[1];
                else if (mode == 1) weights.LogicalCount = 1;
                else weights.Values = null;
                Run();
                Check(CrsDeleteFixture.PublishCalls == 0,
                    "incomplete weights published LAS mode " + mode);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "incomplete weights cleared polygons mode " + mode);
                Check(CrsDeleteFixture.Published.Count == 1 &&
                    CrsDeleteFixture.Published[0].X == 99,
                    "incomplete weights replaced existing LAS mode " + mode);
            }
        }

        private static void HugeSingleIndexer()
        {
            CrsDeleteFixture.Reset();
            var heights = new float[10001];
            for (int i = 0; i < heights.Length; i++) heights[i] = 2;
            heights[heights.Length - 1] = 1;
            CrsDeleteFixture.AddIndexer(heights);
            Run();
            Check(CrsDeleteFixture.Published.Count == heights.Length - 1,
                "single huge indexer fully exported");
            Check(CrsDeleteFixture.MaxBatch == 3, "huge indexer batch capped");
            Check(CrsDeleteFixture.ClearCalls == 1, "huge indexer clears");
        }

        private static void EmptyAndAllDeleted()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer();
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "empty input not published");
            Check(CrsDeleteFixture.ClearCalls == 0, "empty input retains polygons");
            Check(CrsDeleteFixture.Published[0].X == 99, "empty input retains destination");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 1);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "all deleted exports empty LAS");
            Check(CrsDeleteFixture.Published.Count == 0, "all deleted has zero records");
            Check(CrsDeleteFixture.ClearCalls == 1, "all deleted clears polygons");
        }

        private static void NoMatchAndInvalidGeometry()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(2, 3);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "no match does not publish LAS");
            Check(CrsDeleteFixture.ClearCalls == 0, "no match retains polygons");
            Check(CrsDeleteFixture.Published.Count == 1 &&
                CrsDeleteFixture.Published[0].X == 99, "no match retains destination");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("Точек для удаления не найдено"),
                "no match explains unchanged output");

            foreach (bool degenerate in new bool[] { false, true })
            {
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.AddIndexer(1, 2);
                CrsDeleteFixture.Alignment.Corridor.Sections.Add(
                    new TestSection { Id = 8, Station = 1 });
                CrsDeleteFixture.Polygons.Add(new CrsPolygonEntry {
                    SectionIndex = 1, Station = 1,
                    Polygon = new List<Vector2D> { new Vector2D(0, 0) } });
                CrsDeleteFixture.Alignment.Plan.CompoundLine.FailAtStationOne = !degenerate;
                CrsDeleteFixture.Alignment.Plan.CompoundLine.DegenerateAtStationOne = degenerate;
                Run();
                Check(CrsDeleteFixture.PublishCalls == 0,
                    "invalid section does not publish partial LAS");
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "invalid section retains all polygons");
                Check(CrsDeleteFixture.WriteCalls == 0,
                    "invalid section rejected before writer");
                Check(MessageDlg.Messages.Count == 1 &&
                    MessageDlg.Messages[0].Contains("Операция отменена"),
                    "invalid section reports cancellation");
            }
        }

        private static void AssociatesByPersistentSectionId()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.Alignment.Corridor.Sections.Insert(0,
                new TestSection { Id = 8, Station = 1 });
            CrsDeleteFixture.AddIndexer(1, 2);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.Published.Count == 1,
                "reordered section resolves by persistent ID and station");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.Alignment.Corridor.Sections[0].Id = 9;
            CrsDeleteFixture.AddIndexer(1, 2);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "missing section ID rejects export before publication");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.Alignment.Corridor.Sections.Add(
                new TestSection { Id = 7, Station = 0 });
            CrsDeleteFixture.AddIndexer(1, 2);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "ambiguous section ID rejects export before publication");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.Alignment.Corridor.Sections[0].Station = 0.1;
            CrsDeleteFixture.AddIndexer(1, 2);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "moved station rejects export before publication");
        }

        private static void PreCommitFailures()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(2, 2, 2, 2, 2, 2);
            CrsDeleteFixture.CancelAtVisit = 2;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "scan cancellation not published");
            Check(CrsDeleteFixture.ClearCalls == 0, "scan cancellation retains polygons");
            Check(CrsDeleteFixture.Published[0].X == 99, "scan cancellation retains final");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(2, 2, 2, 2);
            CrsDeleteFixture.FailAtVisit = 2;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "scan fault not published");
            Check(CrsDeleteFixture.ClearCalls == 0, "scan fault retains polygons");
            Check(MessageDlg.Messages.Count == 1, "scan fault reported");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2, 2, 2);
            CrsDeleteFixture.CancelAfterWrite = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "write cancellation not published");
            Check(CrsDeleteFixture.ClearCalls == 0, "write cancellation retains polygons");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.FailComplete = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "finalize fault not published");
            Check(CrsDeleteFixture.ClearCalls == 0, "finalize fault retains polygons");
            Check(CrsDeleteFixture.Published[0].X == 99, "finalize fault retains final");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.FailPublish = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "publication attempted");
            Check(CrsDeleteFixture.ClearCalls == 0, "publication fault retains polygons");
            Check(CrsDeleteFixture.Published[0].X == 99, "publication fault retains final");
        }

        private static void PostCommitOutcomes()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 3);
            CrsDeleteFixture.CancelAfterPublish = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "late cancel after publish");
            Check(CrsDeleteFixture.ClearCalls == 1, "late cancel still clears polygons");
            Check(CrsDeleteFixture.Published.Count == 1, "late cancel retains new LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 3);
            CrsDeleteFixture.ThrowAfterAction = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "progress failure keeps final LAS");
            Check(CrsDeleteFixture.ClearCalls == 0,
                "progress failure before publication keeps polygons");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 3);
            CrsDeleteFixture.FailAtCompletionProgress = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "late progress failure precedes publication");
            Check(CrsDeleteFixture.ClearCalls == 0,
                "late progress failure keeps polygons");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 3);
            CrsDeleteFixture.CancelAtCompletionProgress = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "cancellation at final progress keeps both destinations");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 3);
            CrsDeleteFixture.FailClear = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "clear failure follows publication");
            Check(CrsDeleteFixture.ClearCalls == 1, "clear attempted");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("LAS"), "partial completion reported");
        }

        private static void CapturedContextAndSnapshot()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnConfirm = delegate {
                ApplicationHost.Current.ActiveProject = new Project(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "confirm project switch cannot publish or clear");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnSaveDialog = delegate {
                CrsDeleteFixture.Alignment = new Alignment(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "save dialog alignment switch cannot publish or clear");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                ApplicationHost.Current.ActiveDocument = new object(); };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1,
                "source scanned before progress context switch");
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "progress context switch discards staged LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers = new List<LidarBuffer> {
                    new LidarBuffer { fullpath = @"C:\fixture\cloud.las" } }; };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0,
                "same-directory buffer replacement discards staged LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers[0].indexers.Clear(); };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0,
                "indexer list change discards staged LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers[0].indexers[0].weights.LogicalCount = 0; };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "weight logical count change discards staged CRS LAS");

            Action[] sourceChanges = {
                delegate { CrsDeleteFixture.Buffers[0].indexers[0].points.Values =
                    new Vector3F[] { new Vector3F(0, 0, 2) }; },
                delegate { CrsDeleteFixture.Buffers[0].indexers[0].weights.Values =
                    new byte[] { 1, 2 }; },
                delegate { CrsDeleteFixture.Buffers[0].indexers[0].scale =
                    new Vector3D(3, 1, 1); },
                delegate { CrsDeleteFixture.Buffers[0].indexers[0].position =
                    new Vector3D(0, 1, 0); }
            };
            foreach (Action change in sourceChanges)
            {
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.AddIndexer(1, 2);
                CrsDeleteFixture.OnProgressEnd = change;
                Run();
                Check(CrsDeleteFixture.CompleteCalls == 1 &&
                    CrsDeleteFixture.PublishCalls == 0 &&
                    CrsDeleteFixture.ClearCalls == 0,
                    "borrowed source metadata change discards staged LAS");
            }

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.PolygonsChanged = true; };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0,
                "snapshot conflict before publish discards staged LAS");
            Check(CrsDeleteFixture.ClearCalls == 0,
                "snapshot conflict before publish preserves polygons");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("LAS"),
                "snapshot conflict reports unpublished LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnPublish = delegate {
                CrsDeleteFixture.PolygonsChanged = true; };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.ClearCalls == 1,
                "post-publication polygon conflict reports partial completion");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("LAS"),
                "post-publication polygon conflict names saved LAS");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnPublish = delegate {
                ApplicationHost.Current.ActiveDocument = new object(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.ClearCalls == 0,
                "post-publication context switch retains polygons");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("LAS-файл сохранён"),
                "post-publication partial result reported");
        }

        private static void CapturedThicknessAcrossDialogs()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1);
            CrsDeleteFixture.Buffers[0].indexers[0].position =
                new Vector3D(0, 0.75, 0);
            CrsDeleteFixture.OnConfirm = delegate {
                LAS_TERRAIN.Configuration.RuntimeConfig.CrsOverlayBorder = 0.2;
            };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.Published.Count == 0,
                "CRS deletion uses thickness captured before confirmation");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1);
            CrsDeleteFixture.Buffers[0].indexers[0].position =
                new Vector3D(0, 0.75, 0);
            CrsDeleteFixture.OnSaveDialog = delegate {
                LAS_TERRAIN.Configuration.RuntimeConfig.CrsOverlayBorder = 0.2;
            };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.Published.Count == 0,
                "CRS deletion uses thickness captured before save dialog");
        }

        private static void SavedPolygonThickness()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1);
            CrsDeleteFixture.Buffers[0].indexers[0].position =
                new Vector3D(0, 0.75, 0);
            CrsDeleteFixture.Polygons[0].Thickness = 2.0;
            LAS_TERRAIN.Configuration.RuntimeConfig.CrsOverlayBorder = 0.2;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                CrsDeleteFixture.Published.Count == 0 &&
                CrsDeleteFixture.ClearCalls == 1,
                "saved wide polygon deletes after current setting narrows");

            CrsDeleteFixture.Reset();
            CrsDeleteFixture.AddIndexer(1);
            CrsDeleteFixture.Buffers[0].indexers[0].position =
                new Vector3D(0, 0.75, 0);
            CrsDeleteFixture.Polygons[0].Thickness = 0.2;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                CrsDeleteFixture.ClearCalls == 0,
                "saved narrow polygon does not widen with current setting");
        }

        public static int Main()
        {
            PreservesRecordsAndBoundsBatch();
            RejectIncompleteWeights();
            HugeSingleIndexer();
            EmptyAndAllDeleted();
            NoMatchAndInvalidGeometry();
            AssociatesByPersistentSectionId();
            PreCommitFailures();
            PostCommitOutcomes();
            CapturedContextAndSnapshot();
            CapturedThicknessAcrossDialogs();
            SavedPolygonThickness();
            Console.WriteLine("CrsDeleteCommandTests: " + checks + " checks passed");
            return 0;
        }
    }
}
