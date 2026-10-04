using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.UseCases;
using LAS_TERRAIN.Visualization;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Controls.Dialogs;
using Topomatic.FoundationClasses;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    public static class PlanDrawFixture
    {
        public static string Root, Cloud, First, Second;
        public static Alignment ActiveAlignment;
        public static Model Model;
        public static Guid AlignmentId;
        public static CadView View;
        public static List<LidarBuffer> Buffers;
        public static readonly Queue<Vector3D?> Cursor = new Queue<Vector3D?>();
        public static readonly Queue<System.Windows.Forms.DialogResult> Decisions =
            new Queue<System.Windows.Forms.DialogResult>();
        public static Action OnDecision;
        public static Action<string> OnMessage;
        public static int CursorCalls;
        public static void Reset()
        {
            Root = Path.Combine(Path.GetTempPath(), "LAS_TERRAIN-PlanDraw-" + Guid.NewGuid().ToString("N"));
            Cloud = Path.Combine(Root, "cloud");
            Directory.CreateDirectory(Cloud);
            First = Path.Combine(Root, "first.rbr");
            Second = Path.Combine(Root, "second.rbr");
            File.WriteAllText(First, "saved project 1");
            File.WriteAllText(Second, "saved project 2");
            View = new CadView();
            AlignmentId = Guid.NewGuid();
            ApplicationHost.Current = new ApplicationHost { ActiveDocument = new object() };
            Switch(First);
            Buffers = new List<LidarBuffer> { new LidarBuffer {
                fullpath = Path.Combine(Cloud, "shared.las") } };
            Cursor.Clear(); Decisions.Clear(); OnDecision = null; OnMessage = null; CursorCalls = 0;
            MessageDlg.Messages.Clear();
        }
        public static void Switch(string projectPath)
        {
            var project = new Project {
                Alias = Path.GetFileNameWithoutExtension(projectPath),
                TargetProjectUri = new URI(new Uri(projectPath).AbsoluteUri) };
            Model = new Model { Project = project, Uri = "model://" + project.Alias };
            ActiveAlignment = new Alignment();
            ApplicationHost.Current.ActiveProject = project;
        }
        public static ScopedPolygonRepository Repo
        {
            get { return new ScopedPolygonRepository(PolygonContextResolver.ResolveProject(
                ActiveAlignment, PolygonGeometryKind.Plan)); }
        }
        public static PlanOverlayLayer Overlay
        { get { return View[PlanOverlayLayer.GUID] as PlanOverlayLayer; } }
        public static void Polygon(double x)
        {
            Cursor.Enqueue(new Vector3D(x, 0, 0));
            Cursor.Enqueue(new Vector3D(x + 4, 0, 0));
            Cursor.Enqueue(new Vector3D(x, 4, 0));
            Cursor.Enqueue(null);
        }
        public static bool NextPoint(out Vector3D point)
        {
            CursorCalls++;
            if (Cursor.Count == 0) throw new Exception("unexpected point request");
            Vector3D? next = Cursor.Dequeue();
            point = next.HasValue ? next.Value : new Vector3D();
            return next.HasValue;
        }
        public static System.Windows.Forms.DialogResult NextDecision()
        {
            if (Decisions.Count == 0) throw new Exception("unexpected dialog");
            if (OnDecision != null) OnDecision();
            return Decisions.Dequeue();
        }
        public static void Dispose()
        {
            OnDecision = null; OnMessage = null;
            if (Root == null || !Directory.Exists(Root)) return;
            string target = Path.GetFullPath(Root).TrimEnd(Path.DirectorySeparatorChar);
            string temp = Path.GetFullPath(Path.GetTempPath()).TrimEnd(Path.DirectorySeparatorChar);
            string name = Path.GetFileName(target);
            const string prefix = "LAS_TERRAIN-PlanDraw-";
            if (!String.Equals(Path.GetDirectoryName(target), temp, StringComparison.OrdinalIgnoreCase) ||
                !name.StartsWith(prefix, StringComparison.Ordinal) ||
                name.Length != prefix.Length + 32 ||
                (File.GetAttributes(target) & FileAttributes.ReparsePoint) != 0)
                throw new Exception("unsafe fixture cleanup");
            new Guid(name.Substring(prefix.Length));
            Directory.Delete(target, true);
        }
    }
    public static class PlanDrawCommandTests
    {
        private static int checks;
        private static void Check(bool valid, string reason)
        { checks++; if (!valid) throw new Exception(reason); }
        private static void Run()
        { new PlanDrawPolygonUseCase().Run(new SectionEnv(PlanDrawFixture.View)); }
        private static void StableWrites()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanDrawFixture.Polygon(10); PlanDrawFixture.Polygon(20);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.No);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                Run();
                var records = PlanDrawFixture.Repo.Read().Records;
                Check(records.Count == 2, "two v2 writes");
                Check(records[0].Polygon[0].X == 10 && records[1].Polygon[0].X == 20,
                    "disk geometry and order");
                Check(PlanDrawFixture.Overlay.PolygonCount == 2, "overlay from snapshot");
                Check(PlanDrawFixture.View.HandlerCount == 0, "draw handler removed");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        private static void SeparateProjectOwners()
        {
            PlanDrawFixture.Reset();
            try
            {
                string firstFile = PlanDrawFixture.Repo.Scope.FilePath;
                PlanDrawFixture.Polygon(1);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                Run();
                PlanDrawFixture.Switch(PlanDrawFixture.Second);
                Check(PlanDrawFixture.Repo.Scope.FilePath != firstFile, "project owns v2 scope");
                Check(PlanDrawFixture.Repo.Read().Records.Count == 0, "shared cloud is isolated");
                PlanDrawFixture.Overlay.Paint(new CadPen());
                Check(PlanDrawFixture.Overlay.PolygonCount == 0, "stale overlay cleared on repaint");
                PlanDrawFixture.Polygon(50);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                Run();
                Check(PlanDrawFixture.Repo.Read().Records[0].Polygon[0].X == 50,
                    "second project polygon persisted");
                Check(PlanDrawFixture.Overlay.PolygonCount == 1, "overlay rebound to second owner");
                PlanDrawFixture.Switch(PlanDrawFixture.First);
                Check(PlanDrawFixture.Repo.Read().Records[0].Polygon[0].X == 1,
                    "first project polygon preserved");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        private static void SavedProjectWithoutCloud()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanDrawFixture.Buffers.Clear();
                PlanDrawFixture.Polygon(7);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                Run();
                Check(PlanDrawFixture.Repo.Read().Records.Count == 1,
                    "saved project can own Plan polygon without LiDAR buffers");
                Check(PlanDrawFixture.Repo.Read().Records[0].Polygon[0].X == 7,
                    "cloudless Plan geometry persists in project scope");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        private static void RejectChangedOwner(Action change, string name)
        {
            PlanDrawFixture.Reset();
            try
            {
                string file = PlanDrawFixture.Repo.Scope.FilePath;
                PlanDrawFixture.Polygon(0);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = change;
                Run();
                Check(!File.Exists(file), name + ": no write");
                Check(PlanDrawFixture.Overlay.PolygonCount == 0, name + ": no overlay update");
                Check(PlanDrawFixture.View.HandlerCount == 0, name + ": handler removed");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        private static void StaleRevision()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanDrawFixture.Polygon(0);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    var repo = PlanDrawFixture.Repo;
                    repo.Commit(repo.Read(), new[] { ScopedPolygonRecord.Plan(DateTime.UtcNow,
                        new List<Vector2D> { new Vector2D(80, 0), new Vector2D(84, 0),
                            new Vector2D(80, 4) }) });
                };
                Run();
                Check(PlanDrawFixture.Repo.Read().Records.Count == 1 &&
                    PlanDrawFixture.Repo.Read().Records[0].Polygon[0].X == 80,
                    "stale revision preserves concurrent disk write");
                Check(PlanDrawFixture.Overlay.PolygonCount == 0, "stale revision leaves overlay alone");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        private static void StaleOverlayRevision()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanDrawFixture.Polygon(3);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                Run();
                Check(PlanDrawFixture.Overlay.PolygonCount == 1, "overlay starts current");
                var repo = PlanDrawFixture.Repo;
                repo.Commit(repo.Read(), new[] { ScopedPolygonRecord.Plan(DateTime.UtcNow,
                    new List<Vector2D> { new Vector2D(90, 0), new Vector2D(94, 0),
                        new Vector2D(90, 4) }) });
                PlanDrawFixture.Overlay.Paint(new CadPen());
                Check(PlanDrawFixture.Overlay.PolygonCount == 0,
                    "overlay discards stale revision on repaint");
                Check(repo.Read().Records[0].Polygon[0].X == 90,
                    "overlay refresh does not overwrite disk");
            }
            finally { PlanDrawFixture.Dispose(); }
        }
        public static int Main()
        {
            StableWrites();
            SeparateProjectOwners();
            SavedProjectWithoutCloud();
            RejectChangedOwner(delegate { ApplicationHost.Current.ActiveProject = new Project(); },
                "project changed after dialog");
            RejectChangedOwner(delegate { ApplicationHost.Current.ActiveDocument = new object(); },
                "document changed after dialog");
            RejectChangedOwner(delegate { PlanDrawFixture.View.IsDisposed = true; },
                "view changed after dialog");
            StaleRevision();
            StaleOverlayRevision();
            Console.WriteLine("PlanDrawCommandTests: " + checks + " checks passed");
            return 0;
        }
    }
}
