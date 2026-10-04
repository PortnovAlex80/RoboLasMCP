using System;
using System.IO;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.UseCases;
using LAS_TERRAIN.Visualization;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class PolygonClearCommandTests
    {
        private static int _checks;

        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        private static ScopedPolygonRecord Plan(double x)
        {
            return ScopedPolygonRecord.Plan(DateTime.UtcNow, new[] {
                new Vector2D(x, 0), new Vector2D(x + 1, 0), new Vector2D(x, 1) });
        }

        private static ScopedPolygonRepository CrsRepo()
        {
            return new ScopedPolygonRepository(PolygonContextResolver.ResolveProject(
                PlanDrawFixture.ActiveAlignment, PolygonGeometryKind.Crs));
        }

        private static ScopedPolygonRecord Crs()
        {
            return ScopedPolygonRecord.Crs(DateTime.UtcNow, new[] {
                new Vector2D(0, 0), new Vector2D(1, 0), new Vector2D(0, 1) },
                41, 12.5, 0.4);
        }

        private static PlanOverlayLayer SeedPlan()
        {
            ScopedPolygonRepository repo = PlanDrawFixture.Repo;
            ScopedPolygonSnapshot saved = repo.Commit(repo.Read(), new[] { Plan(1) });
            PlanOverlayLayer overlay = new PlanOverlayLayer();
            PlanDrawFixture.View.AddLayer(overlay);
            ScopedPolygonOperationContext context = ScopedPolygonOperationContext.Capture(
                PlanDrawFixture.View, PolygonGeometryKind.Plan);
            overlay.ReplaceFromSnapshot(context, saved);
            return overlay;
        }

        private static void SeedCrs()
        {
            PlanDrawFixture.ActiveAlignment.Corridor.Sections.Add(
                new TestSection { Id = 41, Station = 12.5 });
            ScopedPolygonRepository repo = CrsRepo();
            repo.Commit(repo.Read(), new[] { Crs() });
        }

        private static void PlanCancelAndSuccess()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanOverlayLayer overlay = SeedPlan();
                string file = PlanDrawFixture.Repo.Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.No);
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(BytesEqual(before, File.ReadAllBytes(file)), "Plan cancel changed v2 bytes");
                Check(overlay.PolygonCount == 1, "Plan cancel changed overlay");
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(PlanDrawFixture.Repo.Read().Records.Count == 0,
                    "Plan clear did not commit empty v2 records");
                Check(overlay.PolygonCount == 0, "Plan clear left stale overlay");
            }
            finally { PlanDrawFixture.Dispose(); }
        }

        private static void PlanOwnerAndOverlaySwitch()
        {
            PlanDrawFixture.Reset();
            try
            {
                PlanOverlayLayer original = SeedPlan();
                string file = PlanDrawFixture.Repo.Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    ApplicationHost.Current.ActiveProject = new Project(); };
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(BytesEqual(before, File.ReadAllBytes(file)),
                    "Plan owner switch cleared old project");
                Check(original.PolygonCount == 1, "Plan owner switch changed overlay before paint");
            }
            finally { PlanDrawFixture.Dispose(); }

            PlanDrawFixture.Reset();
            try
            {
                SeedPlan();
                string file = PlanDrawFixture.Repo.Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    PlanDrawFixture.View.AddLayer(new PlanOverlayLayer()); };
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(BytesEqual(before, File.ReadAllBytes(file)),
                    "Plan overlay switch cleared v2 file");
            }
            finally { PlanDrawFixture.Dispose(); }
        }

        private static void PlanRevisionAndWriteFailure()
        {
            PlanDrawFixture.Reset();
            try
            {
                SeedPlan();
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    ScopedPolygonRepository repo = PlanDrawFixture.Repo;
                    repo.Commit(repo.Read(), new[] { Plan(1), Plan(5) }); };
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(PlanDrawFixture.Repo.Read().Records.Count == 2,
                    "Plan stale revision overwrote concurrent polygons");
            }
            finally { PlanDrawFixture.Dispose(); }

            PlanDrawFixture.Reset();
            FileStream held = null;
            try
            {
                PlanOverlayLayer overlay = SeedPlan();
                string file = PlanDrawFixture.Repo.Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    held = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None); };
                new PlanClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                held.Dispose(); held = null;
                Check(BytesEqual(before, File.ReadAllBytes(file)),
                    "Plan failed write changed v2 bytes");
                Check(overlay.PolygonCount == 1, "Plan failed write cleared overlay");
            }
            finally
            {
                if (held != null) held.Dispose();
                PlanDrawFixture.Dispose();
            }
        }

        private static void CrsCancelAndSuccess()
        {
            PlanDrawFixture.Reset();
            try
            {
                SeedCrs();
                string file = CrsRepo().Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.No);
                new CrsClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(BytesEqual(before, File.ReadAllBytes(file)), "CRS cancel changed v2 bytes");
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                new CrsClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(CrsRepo().Read().Records.Count == 0,
                    "CRS clear did not commit empty v2 records");
            }
            finally { PlanDrawFixture.Dispose(); }
        }

        private static void CrsSectionAndRevisionSwitch()
        {
            PlanDrawFixture.Reset();
            try
            {
                SeedCrs();
                string file = CrsRepo().Scope.FilePath;
                byte[] before = File.ReadAllBytes(file);
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    PlanDrawFixture.ActiveAlignment.Corridor.Sections[0].Station = 13; };
                new CrsClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(BytesEqual(before, File.ReadAllBytes(file)),
                    "CRS section drift cleared v2 file");
            }
            finally { PlanDrawFixture.Dispose(); }

            PlanDrawFixture.Reset();
            try
            {
                SeedCrs();
                PlanDrawFixture.Decisions.Enqueue(System.Windows.Forms.DialogResult.Yes);
                PlanDrawFixture.OnDecision = delegate {
                    ScopedPolygonRepository repo = CrsRepo();
                    repo.Commit(repo.Read(), new[] { Crs(), Crs() }); };
                new CrsClearPolygonsUseCase().Run(new SectionEnv(PlanDrawFixture.View));
                Check(CrsRepo().Read().Records.Count == 2,
                    "CRS stale revision overwrote concurrent polygons");
            }
            finally { PlanDrawFixture.Dispose(); }
        }

        private static bool BytesEqual(byte[] first, byte[] second)
        {
            if (first.Length != second.Length) return false;
            for (int i = 0; i < first.Length; i++)
                if (first[i] != second[i]) return false;
            return true;
        }

        public static void Main()
        {
            PlanCancelAndSuccess();
            PlanOwnerAndOverlaySwitch();
            PlanRevisionAndWriteFailure();
            CrsCancelAndSuccess();
            CrsSectionAndRevisionSwitch();
            Console.WriteLine("Polygon clear commands: " + _checks + " checks passed.");
        }
    }
}
