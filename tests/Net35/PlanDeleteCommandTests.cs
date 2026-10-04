using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.UseCases;
using LAS_TERRAIN.Visualization;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    public static class PlanDeleteFixture
    {
        public static List<PlanPolygonEntry> Polygons;
        public static PlanOverlayLayer Overlay;
        public static int ClearAttempts, ClearCalls, OverlayClearCalls;
        public static int PreflightVisits, ExportVisits;
        public static int CancelPreflightAt, FailPreflightAt;
        public static int CancelExportAt, FailExportAt;
        public static bool WriterCreated, ExportPhase, MutateSourceAtWriter;
        public static bool MutatePolygonsOnPublish, PolygonsChanged, FailClear;

        public static void Reset()
        {
            CrsDeleteFixture.Reset();
            Topomatic.FoundationClasses.Parallel.Parallel.Reverse = false;
            Polygons = new List<PlanPolygonEntry> { new PlanPolygonEntry {
                Polygon = new List<Vector2D> {
                    new Vector2D(0, 0), new Vector2D(3, 0),
                    new Vector2D(0, 3) } } };
            Overlay = new PlanOverlayLayer();
            ClearAttempts = ClearCalls = OverlayClearCalls = 0;
            PreflightVisits = ExportVisits = 0;
            CancelPreflightAt = FailPreflightAt = 0;
            CancelExportAt = FailExportAt = 0;
            WriterCreated = ExportPhase = MutateSourceAtWriter = false;
            MutatePolygonsOnPublish = PolygonsChanged = FailClear = false;
        }

        public static void VisitPoint()
        {
            if (!WriterCreated && !ExportPhase)
            {
                PreflightVisits++;
                if (PreflightVisits == CancelPreflightAt)
                    WaitProgress.CancellationPending = true;
                if (PreflightVisits == FailPreflightAt)
                    throw new InvalidOperationException("injected preflight fault");
            }
            else
            {
                ExportVisits++;
                if (ExportVisits == CancelExportAt)
                    WaitProgress.CancellationPending = true;
                if (ExportVisits == FailExportAt)
                    throw new InvalidOperationException("injected export scan fault");
            }
        }

        public static void AddIndexer(params float[] worldX)
        {
            var points = new Vector3F[worldX.Length];
            var weights = new byte[worldX.Length];
            for (int i = 0; i < worldX.Length; i++)
            {
                points[i] = new Vector3F(worldX[i], 0, i + 2);
                weights[i] = (byte)(i + 1);
            }
            CrsDeleteFixture.Buffers[0].indexers.Add(new QuadTreeIndexer {
                points = new PointArray { Values = points },
                weights = new WeightArray { Values = weights }
            });
        }
    }

    public static class PlanDeleteCommandTests
    {
        private static int checks;
        private static void Check(bool condition, string reason)
        {
            checks++;
            if (!condition) throw new Exception(reason);
        }
        private static void Run()
        { new PlanDeletePointsUseCase().Run(new SectionEnv()); }

        private static void NoMatchesAndEarlyExit()
        {
            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(2, 2, 2);
            Run();
            Check(PlanDeleteFixture.PreflightVisits == 3, "no-match scans all points");
            Check(!PlanDeleteFixture.WriterCreated, "no-match creates no writer");
            Check(CrsDeleteFixture.PublishCalls == 0, "no-match preserves destination");
            Check(PlanDeleteFixture.ClearCalls == 0, "no-match preserves polygons");
            Check(CrsDeleteFixture.Published[0].X == 99, "no-match old LAS");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2, 2);
            Run();
            Check(PlanDeleteFixture.PreflightVisits == 1, "first match short circuits");
            Check(CrsDeleteFixture.Published.Count == 3, "first-match kept count");
            Check(PlanDeleteFixture.ClearCalls == 1, "first match clears");
            Check(PlanDeleteFixture.OverlayClearCalls == 1, "first match clears overlay");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("импортируйте LAS"),
                "Plan deletion must explain that the exported cloud is not attached");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(2, 2, 1);
            Run();
            Check(PlanDeleteFixture.PreflightVisits == 3, "last match scanned");
            Check(CrsDeleteFixture.Published.Count == 2, "last-match kept count");
            Check(CrsDeleteFixture.Published[0].Z == 2 &&
                CrsDeleteFixture.Published[1].Z == 3, "source record order");
        }

        private static void BoundedRecords()
        {
            PlanDeleteFixture.Reset();
            var x = new float[10001];
            for (int i = 0; i < x.Length; i++) x[i] = 2;
            x[0] = 1;
            PlanDeleteFixture.AddIndexer(x);
            Run();
            Check(CrsDeleteFixture.Published.Count == 10000, "huge indexer count");
            Check(CrsDeleteFixture.MaxBatch == 3, "huge indexer bounded batch");
            Check(PlanDeleteFixture.ClearCalls == 1, "huge indexer clears polygons");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 1);
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "all deleted publishes LAS");
            Check(CrsDeleteFixture.Published.Count == 0, "all deleted zero records");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2, 1);
            PlanDeleteFixture.AddIndexer(2, 1, 2);
            Run();
            var kept = CrsDeleteFixture.Published;
            Check(kept.Count == 4, "multiple indexer survivor count");
            Check(kept[0].Z == 3 && kept[1].Z == 4 &&
                kept[2].Z == 2 && kept[3].Z == 4, "per-indexer source order");
            Check(kept[0].W == 2.0 * 257.0,
                "weight uses source index");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
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
                PlanDeleteFixture.Reset();
                PlanDeleteFixture.AddIndexer(1, 2);
                WeightArray weights = CrsDeleteFixture.Buffers[0].indexers[0].weights;
                if (mode == 0) weights.Values = new byte[1];
                else if (mode == 1) weights.LogicalCount = 1;
                else weights.Values = null;
                Run();
                Check(CrsDeleteFixture.PublishCalls == 0,
                    "incomplete weights published LAS mode " + mode);
                Check(PlanDeleteFixture.ClearCalls == 0 &&
                    PlanDeleteFixture.OverlayClearCalls == 0,
                    "incomplete weights cleared polygons mode " + mode);
                Check(CrsDeleteFixture.Published.Count == 1 &&
                    CrsDeleteFixture.Published[0].X == 99,
                    "incomplete weights replaced existing LAS mode " + mode);
            }
        }

        private static void PreCommitFailures()
        {
            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(2, 2, 2, 1);
            PlanDeleteFixture.CancelPreflightAt = 2;
            Run();
            Check(!PlanDeleteFixture.WriterCreated, "preflight cancel no writer");
            Check(CrsDeleteFixture.PublishCalls == 0, "preflight cancel no publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "preflight cancel no clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(2, 2, 1);
            PlanDeleteFixture.FailPreflightAt = 2;
            Run();
            Check(!PlanDeleteFixture.WriterCreated, "preflight fault no writer");
            Check(CrsDeleteFixture.PublishCalls == 0, "preflight fault no publish");
            Check(MessageDlg.Messages.Count == 1, "preflight fault reported");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2, 2, 2, 2);
            PlanDeleteFixture.CancelExportAt = 5;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "export cancel no publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "export cancel no clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            PlanDeleteFixture.FailExportAt = 2;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "export fault no publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "export fault no clear");
            Check(MessageDlg.Messages.Count == 1, "export fault reported");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            PlanDeleteFixture.MutateSourceAtWriter = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "changed source no publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "changed source no clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            CrsDeleteFixture.FailComplete = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0, "complete fault no publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "complete fault no clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            CrsDeleteFixture.FailPublish = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "publish attempted");
            Check(PlanDeleteFixture.ClearCalls == 0, "publish fault no clear");
            Check(CrsDeleteFixture.Published[0].X == 99, "old LAS preserved");
        }

        private static void PostCommitOutcomes()
        {
            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            CrsDeleteFixture.CancelAfterPublish = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "late cancel after publish");
            Check(PlanDeleteFixture.ClearCalls == 1, "late cancel still clears");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            CrsDeleteFixture.ThrowAfterAction = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "progress cancellation before publication keeps destinations");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            CrsDeleteFixture.CancelAtCompletionProgress = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "final progress cancellation keeps both destinations");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            PlanDeleteFixture.MutatePolygonsOnPublish = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "changed polygons after commit");
            Check(PlanDeleteFixture.ClearAttempts == 1 &&
                PlanDeleteFixture.ClearCalls == 0, "changed polygons retained");
            Check(PlanDeleteFixture.OverlayClearCalls == 0,
                "changed polygons keep overlay");
            Check(MessageDlg.Messages.Count == 1, "partial outcome reported");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2, 2);
            PlanDeleteFixture.FailClear = true;
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1, "clear fault after publish");
            Check(PlanDeleteFixture.ClearCalls == 0, "clear fault retains polygons");
            Check(PlanDeleteFixture.OverlayClearCalls == 0,
                "clear fault keeps overlay");
            Check(MessageDlg.Messages.Count == 1, "clear fault reported");
        }

        private static void CapturedContext()
        {
            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnConfirm = delegate {
                Topomatic.ApplicationPlatform.ApplicationHost.Current.ActiveProject =
                    new Topomatic.ApplicationPlatform.Project(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "confirm project switch cannot publish or clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnSaveDialog = delegate {
                CrsDeleteFixture.Alignment = new Topomatic.Alg.Alignment(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "save dialog alignment switch cannot publish or clear");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                Topomatic.ApplicationPlatform.ApplicationHost.Current.ActiveDocument =
                    new object(); };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1,
                "source scanned before progress context switch");
            Check(CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "progress context switch discards staged LAS");
            Check(CrsDeleteFixture.Published[0].X == 99,
                "progress context switch keeps prior LAS");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers = new List<LidarBuffer> {
                    new LidarBuffer { fullpath = @"C:\fixture\cloud.las" } }; };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0,
                "same-directory buffer replacement discards staged LAS");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers[0].indexers.Clear(); };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0,
                "indexer list change discards staged LAS");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnProgressEnd = delegate {
                CrsDeleteFixture.Buffers[0].indexers[0].weights.LogicalCount = 0; };
            Run();
            Check(CrsDeleteFixture.CompleteCalls == 1 &&
                CrsDeleteFixture.PublishCalls == 0 &&
                PlanDeleteFixture.ClearCalls == 0,
                "weight logical count change discards staged Plan LAS");

            PlanDeleteFixture.Reset();
            PlanDeleteFixture.AddIndexer(1, 2);
            CrsDeleteFixture.OnPublish = delegate {
                Topomatic.ApplicationPlatform.ApplicationHost.Current.ActiveDocument =
                    new object(); };
            Run();
            Check(CrsDeleteFixture.PublishCalls == 1 &&
                PlanDeleteFixture.ClearCalls == 0,
                "post-publication context switch retains polygons");
            Check(PlanDeleteFixture.OverlayClearCalls == 0,
                "post-publication context switch retains overlay");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("LAS-файл сохранён"),
                "post-publication partial success reported");
        }

        public static int Main()
        {
            NoMatchesAndEarlyExit();
            BoundedRecords();
            RejectIncompleteWeights();
            PreCommitFailures();
            PostCommitOutcomes();
            CapturedContext();
            Console.WriteLine("PlanDeleteCommandTests: " + checks + " checks passed");
            return 0;
        }
    }
}
