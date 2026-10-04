using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Controls;
using Topomatic.Controls.Dialogs;
using Topomatic.Lidar;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Tests
{
    internal static class PlanSurfaceFixture
    {
        internal static Alignment Alignment = new Alignment();
        internal static List<LidarBuffer> Buffers;
        internal static List<PlanPolygonEntry> Polygons;
        internal static int PolygonRevision;
        internal static int CancelStage;
        internal static int CancelAfterVisit;
        internal static int ThrowStage;
        internal static int ThrowAfterVisit;
        internal static int Visits;
        internal static bool EditSettingsDuringScan;
        internal static int ReceiverCalls;
        internal static int BufferCollections;
        internal static string InitializedPath;
        internal static CadView View;
        internal static string ChangeDuringSecondScan;
        internal static bool InvokeRequiredAtStart;

        internal static void VisitPoint()
        {
            Visits++;
            if (WaitProgress.Stage == 2 && Visits == 1 &&
                ChangeDuringSecondScan != null)
            {
                switch (ChangeDuringSecondScan)
                {
                    case "view": View.IsDisposed = true; break;
                    case "handle": View.IsHandleCreated = false; break;
                    case "layer": SurfaceLayer.Current = new SurfaceLayer(); break;
                    case "surface": SurfaceLayer.Current.Surface = new Surface(); break;
                    case "project": ApplicationHost.Current.ActiveProject = new Project(); break;
                    case "document": ApplicationHost.Current.ActiveDocument = new object(); break;
                    case "model": Alignment.Model = new FakeModel {
                        Project = ApplicationHost.Current.ActiveProject }; break;
                    case "alignment": Alignment = new Alignment {
                        Model = new FakeModel { Project = ApplicationHost.Current.ActiveProject } }; break;
                    case "source-path": Buffers[0].fullpath = @"C:\changed\cloud.las"; break;
                    case "source-points": Buffers[0].indexers[0].points.Values =
                        (Vector3F[])Buffers[0].indexers[0].points.Values.Clone(); break;
                    case "source-weights": Buffers[0].indexers[0].weights.Values =
                        new byte[1]; break;
                    case "source-scale": Buffers[0].indexers[0].scale =
                        new Vector3D(2, 1, 1); break;
                    case "source-provider": Buffers = new List<LidarBuffer> {
                        new LidarBuffer() }; break;
                    case "polygons": PolygonRevision++; break;
                    default: throw new Exception("Unknown fixture change");
                }
            }
            if (EditSettingsDuringScan && Visits == 1)
            {
                LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialDegree = 3;
                LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialRegularization = 0.9;
                LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialGridStep = 5;
            }
            if (WaitProgress.Stage == CancelStage && Visits == CancelAfterVisit)
                WaitProgress.CancellationPending = true;
            if (WaitProgress.Stage == ThrowStage && Visits == ThrowAfterVisit)
                throw new InvalidOperationException("injected LiDAR read error");
        }
    }

    internal static class PlanSurfaceCommandTests
    {
        private static int _checks;

        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        private static LidarBuffer Buffer(params Vector3F[] points)
        {
            var buffer = new LidarBuffer();
            buffer.indexers.Add(new QuadTreeIndexer { points = new PointArray { Values = points } });
            return buffer;
        }

        private static void Reset(bool large)
        {
            Topomatic.FoundationClasses.Parallel.Parallel.Reverse = false;
            Topomatic.FoundationClasses.Parallel.Parallel.Concurrent = false;
            WaitProgress.Stage = 0;
            WaitProgress.CancellationPending = false;
            MessageDlg.Messages.Clear();
            FastSurfaceBuilder.Calls = 0;
            FastSurfaceBuilder.PointCount = 0;
            FastSurfaceBuilder.ThrowOnInsert = false;
            FastSurfaceBuilder.ThrowUnknownOnInsert = false;
            PolynomialSurfaceFitter.Calls = 0;
            PolynomialSurfaceFitter.InputCount = 0;
            PlanSurfaceFixture.Visits = 0;
            PlanSurfaceFixture.CancelStage = 0;
            PlanSurfaceFixture.ThrowStage = 0;
            PlanSurfaceFixture.CancelAfterVisit = 0;
            PlanSurfaceFixture.ThrowAfterVisit = 0;
            PlanSurfaceFixture.EditSettingsDuringScan = false;
            PlanSurfaceFixture.ReceiverCalls = 0;
            PlanSurfaceFixture.BufferCollections = 0;
            PlanSurfaceFixture.InitializedPath = null;
            PlanSurfaceFixture.View = null;
            PlanSurfaceFixture.ChangeDuringSecondScan = null;
            PlanSurfaceFixture.InvokeRequiredAtStart = false;
            var project = new Project();
            ApplicationHost.Current = new ApplicationHost {
                ActiveProject = project, ActiveDocument = new object() };
            PlanSurfaceFixture.Alignment = new Alignment {
                Model = new FakeModel { Project = project } };
            SurfaceLayer.Current = new SurfaceLayer();
            LAS_TERRAIN.Configuration.RuntimeConfig.GridStep = 1;
            LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialDegree = 1;
            LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialRegularization = 0.01;
            LAS_TERRAIN.Configuration.RuntimeConfig.PolynomialGridStep = 1;
            PlanSurfaceFixture.Polygons = new List<PlanPolygonEntry> { new PlanPolygonEntry() };
            PlanSurfaceFixture.PolygonRevision = 0;
            PlanSurfaceFixture.Polygons[0].Polygon.Add(new Vector2D(0, 0));
            PlanSurfaceFixture.Polygons[0].Polygon.Add(new Vector2D(10, 0));
            PlanSurfaceFixture.Polygons[0].Polygon.Add(new Vector2D(0, 10));
            PlanSurfaceFixture.Buffers = new List<LidarBuffer>();
            if (large)
            {
                var points = new Vector3F[3072];
                for (int i = 0; i < points.Length; i++)
                    points[i] = new Vector3F(i % 10, (i / 10) % 10, i % 7);
                PlanSurfaceFixture.Buffers.Add(Buffer(points));
            }
            else
            {
                PlanSurfaceFixture.Buffers.Add(Buffer(
                    new Vector3F(0, 0, 1), new Vector3F(1, 0, 2),
                    new Vector3F(2, 0, 3), new Vector3F(11, 0, 4)));
                PlanSurfaceFixture.Buffers.Add(Buffer(
                    new Vector3F(3, 0, 4), new Vector3F(4, 0, 5)));
            }
        }

        private static void Run(ISectionUseCase command)
        {
            PlanSurfaceFixture.View = new CadView {
                InvokeRequired = PlanSurfaceFixture.InvokeRequiredAtStart };
            command.Run(new SectionEnv(PlanSurfaceFixture.View));
        }

        private static bool HasSuccess()
        {
            foreach (string message in MessageDlg.Messages)
                if (message.Contains("завершено")) return true;
            return false;
        }

        private static void Cancellation(Type commandType, int stage)
        {
            Reset(true);
            PlanSurfaceFixture.CancelStage = stage;
            PlanSurfaceFixture.CancelAfterVisit = 1300;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(WaitProgress.Stage == stage, commandType.Name + " stage reached");
            Check(!WaitProgress.CancellationPending, "dialog reset cancellation flag");
            Check(FastSurfaceBuilder.Calls == 0, "cancelled scan did not apply CAD");
            Check(PolynomialSurfaceFitter.Calls == 0, "cancelled scan did not fit");
            Check(!HasSuccess(), "cancelled scan did not report success");
        }

        private static void WorkerError(Type commandType, int stage)
        {
            Reset(true);
            PlanSurfaceFixture.ThrowStage = stage;
            PlanSurfaceFixture.ThrowAfterVisit = 1300;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(WaitProgress.Stage == stage, "error stage reached");
            Check(FastSurfaceBuilder.Calls == 0, "worker error did not apply CAD");
            Check(PolynomialSurfaceFitter.Calls == 0, "worker error did not fit");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("injected LiDAR read error"),
                "worker error is reported to user");
            Check(!HasSuccess(), "worker error did not report success");
        }

        private static void PolynomialSuccessAndSettings()
        {
            Reset(false);
            PlanSurfaceFixture.EditSettingsDuringScan = true;
            Run(new PlanPolygonPolynomialSurfaceUseCase());
            Check(WaitProgress.Stage == 2, "both scans completed");
            Check(PolynomialSurfaceFitter.Calls == 1, "fit called once");
            Check(PolynomialSurfaceFitter.InputCount == 5, "five inside points fitted");
            Check(PolynomialSurfaceFitter.CapturedDegree == 1 &&
                PolynomialSurfaceFitter.CapturedRegularization == 0.01 &&
                PolynomialSurfaceFitter.CapturedGridStep == 1,
                "settings captured before first scan remain in fit");
            Check(FastSurfaceBuilder.Calls == 1 && FastSurfaceBuilder.PointCount == 5,
                "successful fit applied once");
            Check(PlanSurfaceFixture.BufferCollections >= 3,
                "polynomial command rechecks current providers before apply");
            Check(PlanSurfaceFixture.ReceiverCalls >= 2,
                "polynomial command validates scan and apply receivers");
            Check(PlanSurfaceFixture.InitializedPath == null,
                "polynomial command does not initialize v1 collection");
            Check(HasSuccess(), "success reported after apply");
        }

        private static void GridSuccess()
        {
            Reset(false);
            PrepareGridFeatureCloud();
            Run(new PlanPolygonGridSurfaceUseCase());
            Check(WaitProgress.Stage == 2, "grid completed both scans");
            Check(FastSurfaceBuilder.Calls == 1 && FastSurfaceBuilder.PointCount > 0,
                "grid feature result applied once");
            Check(PlanSurfaceFixture.BufferCollections >= 3,
                "grid command rechecks current providers before apply");
            Check(PlanSurfaceFixture.ReceiverCalls >= 2,
                "grid command validates scan and apply receivers");
            Check(PlanSurfaceFixture.InitializedPath == null,
                "grid command does not initialize v1 collection");
            Check(HasSuccess(), "grid success reported after apply");
        }

        private static void PrepareGridFeatureCloud()
        {
            var points = new List<Vector3F>();
            for (int y = 0; y < 5; y++)
                for (int x = 0; x < 5; x++)
                    points.Add(new Vector3F(x, y, x == 2 && y == 2 ? 10 : 0));
            PlanSurfaceFixture.Buffers.Clear();
            PlanSurfaceFixture.Buffers.Add(Buffer(points.ToArray()));
        }

        private static void ChangedTarget(Type commandType, string change)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            PlanSurfaceFixture.ChangeDuringSecondScan = change;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(WaitProgress.Stage == 2,
                commandType.Name + " " + change + " completes both scans");
            Check(PlanSurfaceFixture.BufferCollections >= 1,
                commandType.Name + " " + change + " checked source");
            Check(PlanSurfaceFixture.InitializedPath == null,
                commandType.Name + " " + change + " does not initialize v1 collection");
            Check(FastSurfaceBuilder.Calls == 0,
                commandType.Name + " " + change + " does not mutate CAD");
            Check(!HasSuccess(),
                commandType.Name + " " + change + " does not report success");
        }

        private static void ChangedSource(Type commandType, string change)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            string originalPath = Path.GetDirectoryName(
                PlanSurfaceFixture.Buffers[0].fullpath);
            PlanSurfaceFixture.ChangeDuringSecondScan = change;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(WaitProgress.Stage == 2, commandType.Name + " " + change +
                " completes both scans");
            Check(PlanSurfaceFixture.BufferCollections >= 3,
                commandType.Name + " " + change + " rechecks providers (" +
                PlanSurfaceFixture.BufferCollections + ")");
            Check(PlanSurfaceFixture.InitializedPath == null,
                commandType.Name + " " + change + " does not initialize v1 collection");
            Check(PlanSurfaceFixture.ReceiverCalls >= 2,
                commandType.Name + " " + change + " validates at apply");
            Check(FastSurfaceBuilder.Calls == 0 && !HasSuccess(),
                commandType.Name + " " + change + " rejects stale source");
        }

        private static void InsertError(Type commandType)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            FastSurfaceBuilder.ThrowOnInsert = true;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(WaitProgress.Stage == 2,
                commandType.Name + " reaches insertion");
            Check(FastSurfaceBuilder.Calls == 0,
                commandType.Name + " reports failed insertion");
            Check(!HasSuccess(),
                commandType.Name + " does not report failed insertion as success");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("injected surface insert error"),
                commandType.Name + " reports insertion failure");
        }

        private static void UnknownInsertState(Type commandType)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            FastSurfaceBuilder.ThrowUnknownOnInsert = true;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(FastSurfaceBuilder.Calls == 0 && !HasSuccess(),
                commandType.Name + " uncertain SDK update is not success");
            Check(MessageDlg.Messages.Count == 1 &&
                MessageDlg.Messages[0].Contains("injected uncertain update") &&
                MessageDlg.Messages[0].Contains("SDK"),
                commandType.Name + " reports uncertain SDK update");
        }

        private static void ApplyOnViewThread(Type commandType)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            PlanSurfaceFixture.InvokeRequiredAtStart = true;
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(PlanSurfaceFixture.View.InvokeCount == 1,
                commandType.Name + " dispatches apply to captured view");
            Check(FastSurfaceBuilder.Calls == 1 && HasSuccess(),
                commandType.Name + " applies once after dispatch");
        }

        private static void PathFromFirstNamedBuffer(Type commandType)
        {
            Reset(false);
            if (commandType == typeof(PlanPolygonGridSurfaceUseCase))
                PrepareGridFeatureCloud();
            foreach (LidarBuffer buffer in PlanSurfaceFixture.Buffers)
                buffer.fullpath = null;
            PlanSurfaceFixture.Buffers.Add(new LidarBuffer {
                fullpath = @"C:\second-fixture\cloud.las" });
            Run((ISectionUseCase)Activator.CreateInstance(commandType));
            Check(PlanSurfaceFixture.BufferCollections >= 3,
                commandType.Name + " rechecks buffers with unnamed first buffer");
            Check(PlanSurfaceFixture.InitializedPath == null,
                commandType.Name + " does not bind polygons to first named buffer");
            Check(HasSuccess(),
                commandType.Name + " processes named second buffer");
        }

        private static void GridMinZTie()
        {
            Reset(false);
            PlanSurfaceFixture.Buffers.Clear();
            PlanSurfaceFixture.Buffers.Add(Buffer(
                new Vector3F(0.1f, 0.1f, 10), new Vector3F(0.2f, 0.2f, 4)));
            PlanSurfaceFixture.Buffers.Add(Buffer(new Vector3F(0.3f, 0.3f, 4)));
            var command = new PlanPolygonGridSurfaceUseCase();
            MethodInfo method = typeof(PlanPolygonGridSurfaceUseCase).GetMethod(
                "CollectGroundMinZInPolygonsParallel", BindingFlags.Instance | BindingFlags.NonPublic);
            var bounds = new BoundingBox2D(new Vector2D(0, 0), new Vector2D(10, 10));
            for (int pass = 0; pass < 3; pass++)
            {
                PlanSurfaceFixture.Buffers[0].indexers[0].points.DelayCountMs =
                    pass == 0 ? 0 : 30;
                var state = new PlanPolygonScanState();
                var result = (List<Vector3D>)method.Invoke(command, new object[] {
                    PlanSurfaceFixture.Buffers, PlanSurfaceFixture.Polygons, bounds, 1.0, state });
                Check(result.Count == 1, "one grid cell remains");
                Check(result[0].Z == 4, "minimum Z chosen");
                Check(Math.Abs(result[0].X - 0.2) < 1e-6,
                    "first equal-Z XY changed with worker completion order");
            }
        }

        private static void PolynomialBufferOrder()
        {
            Reset(false);
            var command = new PlanPolygonPolynomialSurfaceUseCase();
            MethodInfo method = typeof(PlanPolygonPolynomialSurfaceUseCase).GetMethod(
                "CollectAllPointsInPolygonsParallel", BindingFlags.Instance | BindingFlags.NonPublic);
            for (int pass = 0; pass < 3; pass++)
            {
                PlanSurfaceFixture.Buffers[0].indexers[0].points.DelayCountMs =
                    pass == 0 ? 0 : 30;
                var state = new PlanPolygonScanState();
                var result = (List<Vector3D>)method.Invoke(command, new object[] {
                    PlanSurfaceFixture.Buffers, PlanSurfaceFixture.Polygons, state });
                Check(result.Count == 5, "polynomial input point count changed");
                for (int i = 0; i < result.Count; i++)
                    Check(result[i].X == i,
                        "polynomial fit input order changed with worker completion order");
            }
        }

        public static int Main()
        {
            Type[] commands = { typeof(PlanPolygonGridSurfaceUseCase),
                typeof(PlanPolygonPolynomialSurfaceUseCase) };
            foreach (Type command in commands)
            {
                Cancellation(command, 1);
                Cancellation(command, 2);
                WorkerError(command, 1);
                WorkerError(command, 2);
                foreach (string change in new[] {
                    "view", "handle", "layer", "surface", "project",
                    "document", "model", "alignment", "polygons" })
                    ChangedTarget(command, change);
                foreach (string change in new[] {
                    "source-path", "source-points", "source-weights", "source-scale",
                    "source-provider" })
                    ChangedSource(command, change);
                InsertError(command);
                UnknownInsertState(command);
                ApplyOnViewThread(command);
                PathFromFirstNamedBuffer(command);
            }
            PolynomialSuccessAndSettings();
            GridSuccess();
            GridMinZTie();
            PolynomialBufferOrder();
            Console.WriteLine("Production Plan surface commands: " + _checks + " checks passed.");
            return 0;
        }
    }
}
