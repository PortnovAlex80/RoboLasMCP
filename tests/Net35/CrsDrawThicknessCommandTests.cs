using System;
using System.Collections.Generic;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Controls.Dialogs;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    public static class CrsDrawThicknessFixture
    {
        public static Alignment Alignment;
        public static SectionManager Manager;
        public static Model Model;
        public static Guid AlignmentId;
        public static CadView SourceView, CrossView;
        public static List<LidarBuffer> Buffers;
        public static readonly Queue<Vector3D?> Cursor = new Queue<Vector3D?>();
        public static readonly Queue<System.Windows.Forms.DialogResult> Decisions =
            new Queue<System.Windows.Forms.DialogResult>();
        public static int CursorCalls, DecisionCalls;
        public static double FirstCursorBorder, BetweenPolygonsBorder;
        public static Action FirstPointAction, DecisionAction;
        public const string SourceDirectory = @"C:\fixture";

        public static void Reset(double initialBorder)
        {
            Alignment = new Alignment();
            Manager = new SectionManager();
            var project = new Project();
            Model = new Model { Project = project };
            AlignmentId = Guid.NewGuid();
            SourceView = new CadView();
            CrossView = new CadView();
            ApplicationHost.Current = new ApplicationHost {
                ActiveProject = project, ActiveDocument = new object() };
            Buffers = new List<LidarBuffer> { new LidarBuffer() };
            ScopedPolygonOperationContext.Reset();
            MessageDlg.Messages.Clear();
            Cursor.Clear();
            Decisions.Clear();
            CursorCalls = DecisionCalls = RuntimeConfig.Reads = 0;
            RuntimeConfig.CrsOverlayBorder = initialBorder;
            FirstCursorBorder = BetweenPolygonsBorder = Double.NaN;
            FirstPointAction = DecisionAction = null;
        }

        public static void Polygon(double x)
        {
            Cursor.Enqueue(new Vector3D(x, 0, 0));
            Cursor.Enqueue(new Vector3D(x + 2, 0, 0));
            Cursor.Enqueue(new Vector3D(x, 2, 0));
            Cursor.Enqueue(null);
        }

        public static bool NextPoint(out Vector3D result)
        {
            CursorCalls++;
            if (CursorCalls == 1 && !Double.IsNaN(FirstCursorBorder))
                RuntimeConfig.CrsOverlayBorder = FirstCursorBorder;
            if (CursorCalls == 1 && FirstPointAction != null) FirstPointAction();
            if (Cursor.Count == 0)
                throw new InvalidOperationException("Unexpected cursor request");
            Vector3D? next = Cursor.Dequeue();
            result = next.HasValue ? next.Value : new Vector3D();
            return next.HasValue;
        }

        public static System.Windows.Forms.DialogResult NextDecision()
        {
            DecisionCalls++;
            if (Decisions.Count == 0)
                throw new InvalidOperationException("Unexpected polygon decision");
            var decision = Decisions.Dequeue();
            if (DecisionAction != null)
            {
                Action action = DecisionAction;
                DecisionAction = null;
                action();
            }
            if (decision == System.Windows.Forms.DialogResult.No &&
                !Double.IsNaN(BetweenPolygonsBorder))
                RuntimeConfig.CrsOverlayBorder = BetweenPolygonsBorder;
            return decision;
        }
    }

    public static class CrsDrawThicknessCommandTests
    {
        private static int _checks;
        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        private static void OnePolygon()
        {
            CrsDrawThicknessFixture.Reset(2.0);
            CrsDrawThicknessFixture.FirstCursorBorder = 5.0;
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);

            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));

            Check(ScopedPolygonOperationContext.Records.Count == 1, "one polygon saved");
            Check(ScopedPolygonOperationContext.Records[0].Thickness == 2.0,
                "thickness is captured before cursor input");
            Check(RuntimeConfig.CrsOverlayBorder == 5.0, "settings changed during cursor input");
            Check(ScopedPolygonOperationContext.Records[0].Polygon.Count >= 3,
                "real command stored cursor geometry");
            Check(ScopedPolygonOperationContext.Records[0].SectionId == 7,
                "persistent section ID stored");
            Check(CrsDrawThicknessFixture.CrossView.HandlerCount == 0,
                "dynamic drawing handler removed");
            Check(CrsDrawThicknessFixture.Cursor.Count == 0, "all cursor inputs consumed");
            Check(CrsDrawThicknessFixture.DecisionCalls == 1, "save decision reached");
        }

        private static void TwoPolygons()
        {
            CrsDrawThicknessFixture.Reset(3.0);
            CrsDrawThicknessFixture.FirstCursorBorder = 6.0;
            CrsDrawThicknessFixture.BetweenPolygonsBorder = 9.0;
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Polygon(10);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.No);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);

            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));

            Check(ScopedPolygonOperationContext.Records.Count == 2, "two polygons saved");
            Check(ScopedPolygonOperationContext.Records[0].Thickness == 3.0,
                "first polygon uses command snapshot");
            Check(ScopedPolygonOperationContext.Records[1].Thickness == 3.0,
                "second polygon uses same command snapshot");
            Check(ScopedPolygonOperationContext.Records[0].SectionStation == 25 &&
                ScopedPolygonOperationContext.Records[1].SectionStation == 25,
                "section association retained");
            Check(ScopedPolygonOperationContext.Records[1].Polygon[0].X == 10,
                "second cursor geometry retained");
            Check(CrsDrawThicknessFixture.DecisionCalls == 2,
                "continue and finish decisions reached");
            Check(CrsDrawThicknessFixture.Cursor.Count == 0, "both polygon inputs consumed");
            Check(CrsDrawThicknessFixture.CrossView.HandlerCount == 0,
                "drawing handler removed after second polygon");
            Check(RuntimeConfig.Reads == 1,
                "command reads current thickness exactly once");
        }

        private static void CancelPreservesCollection()
        {
            CrsDrawThicknessFixture.Reset(1);
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Cancel);
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 0,
                "cancel does not save a polygon");
            Check(CrsDrawThicknessFixture.CrossView.HandlerCount == 0,
                "cancel removes drawing handler");
        }

        private static void RejectCollectionSwitch(string destination)
        {
            CrsDrawThicknessFixture.Reset(1);
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            CrsDrawThicknessFixture.DecisionAction = delegate {
                ScopedPolygonOperationContext.ConcurrentAdd(
                    ScopedPolygonRecord.Crs(DateTime.Now,
                        new List<Vector2D> { new Vector2D(5, 5) }, 7, 25, 1));
            };
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 1,
                "concurrent v2 update prevents stale drawing commit");
            Check(CrsDrawThicknessFixture.CrossView.HandlerCount == 0,
                "collection switch removes drawing handler");
        }

        private static void RejectInPlaceEdit()
        {
            CrsDrawThicknessFixture.Reset(1);
            ScopedPolygonOperationContext.ConcurrentAdd(ScopedPolygonRecord.Crs(
                DateTime.Now, new List<Vector2D> { new Vector2D(1, 2) }, 7, 25, 1));
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            CrsDrawThicknessFixture.DecisionAction = delegate {
                ScopedPolygonOperationContext.ConcurrentAdd(ScopedPolygonRecord.Crs(
                    DateTime.Now, new List<Vector2D> { new Vector2D(9, 9) }, 7, 25, 1));
            };
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 2,
                "concurrent add rejects drawn polygon");
            Check(ScopedPolygonOperationContext.Records[1].Polygon[0].X == 9,
                "concurrent update remains available");
        }

        private static void RejectSourceSwitch()
        {
            CrsDrawThicknessFixture.Reset(1);
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            CrsDrawThicknessFixture.DecisionAction = delegate {
                CrsDrawThicknessFixture.Buffers[0] = new LidarBuffer();
            };
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 0,
                "replaced LiDAR source rejects save");
        }

        private static void RejectSourceMutation()
        {
            CrsDrawThicknessFixture.Reset(1);
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            CrsDrawThicknessFixture.DecisionAction = delegate {
                CrsDrawThicknessFixture.Buffers[0].fullpath = @"C:\fixture\changed.las";
            };
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 0,
                "changed LiDAR path rejects save");

            CrsDrawThicknessFixture.Reset(1);
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            CrsDrawThicknessFixture.DecisionAction = delegate {
                CrsDrawThicknessFixture.Buffers[0].indexers.Add(new QuadTreeIndexer());
            };
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 0,
                "changed LiDAR indexer list rejects save");
        }

        private static void WriteFailurePreservesCollection()
        {
            CrsDrawThicknessFixture.Reset(1);
            ScopedPolygonOperationContext.FailNextCommit = true;
            CrsDrawThicknessFixture.Polygon(0);
            CrsDrawThicknessFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
            new CrsDrawLineUseCase().Run(new SectionEnv(CrsDrawThicknessFixture.SourceView));
            Check(ScopedPolygonOperationContext.Records.Count == 0,
                "write failure does not save a polygon");
            Check(CrsDrawThicknessFixture.CrossView.HandlerCount == 0,
                "write failure removes drawing handler");
        }

        public static int Main()
        {
            OnePolygon();
            TwoPolygons();
            CancelPreservesCollection();
            RejectCollectionSwitch(CrsDrawThicknessFixture.SourceDirectory);
            RejectCollectionSwitch(@"C:\another-cloud");
            RejectInPlaceEdit();
            RejectSourceSwitch();
            RejectSourceMutation();
            WriteFailurePreservesCollection();
            Console.WriteLine("CrsDrawThicknessCommandTests: " + _checks + " checks passed");
            return 0;
        }
    }
}
