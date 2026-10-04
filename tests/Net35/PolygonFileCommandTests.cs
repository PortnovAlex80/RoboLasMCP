using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.UseCases;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.Foundation;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.Tests
{
    internal static class PolygonFileCommandTests
    {
        private static int checks;
        private static void Check(bool value, string message) { if (!value) throw new Exception(message); checks++; }
        private static ScopedPolygonRecord Polygon(double x)
        { return ScopedPolygonRecord.Plan(DateTime.UtcNow, new List<Vector2D> {
            new Vector2D(x, 0), new Vector2D(x+4, 0), new Vector2D(x, 4) }); }
        private static void Reset()
        {
            PlanDrawFixture.Reset();
            OpenFileDialog.OnShow = null; OpenFileDialog.NextFiles = null; OpenFileDialog.NextFile = null;
            FolderBrowserDialog.NextFolder = null; FolderBrowserDialog.OnShow = null;
        }
        private static SectionEnv Env() { return new SectionEnv(PlanDrawFixture.View); }
        private static int Main()
        {
            Reset();
            try
            {
                var repository = PlanDrawFixture.Repo;
                repository.Commit(repository.Read(), new[] { Polygon(10), Polygon(20) });
                string folder = Path.Combine(PlanDrawFixture.Root, "export"); Directory.CreateDirectory(folder);
                PlanDrawFixture.Decisions.Enqueue(DialogResult.Yes); FolderBrowserDialog.NextFolder = folder;
                new SavePolygonsAsUseCase().Run(Env());
                string[] files = Directory.GetFiles(folder, "*.json"); Array.Sort(files);
                Check(files.Length == 2, "one file per polygon");
                Check(Path.GetFileName(files[0]) == "first.план.полигон.001.json", "readable numbering");
                Check(PortablePolygonFile.Load(files[1]).Polygon[0].X == 20, "geometry round trip");
                Check(!File.ReadAllText(files[0]).Contains("scopeKey"), "portable file has no project restriction");
                PlanDrawFixture.Switch(PlanDrawFixture.Second);
                repository = PlanDrawFixture.Repo; repository.Commit(repository.Read(), new[] { Polygon(99) });
                OpenFileDialog.NextFiles = files; PlanDrawFixture.Decisions.Enqueue(DialogResult.Yes);
                new LoadPolygonsUseCase().Run(Env());
                Check(repository.Read().Records.Count == 3, "cross-project multi-file append");
                Check(repository.Read().Records[0].Polygon[0].X == 99, "existing polygon preserved");
                Check(PlanDrawFixture.Overlay.PolygonCount == 3, "loaded Plan overlay updated");
                string bad = Path.Combine(folder, "bad.json"); File.WriteAllText(bad, "{broken");
                OpenFileDialog.NextFiles = new[] { files[0], bad };
                string before = repository.Read().Revision;
                new LoadPolygonsUseCase().Run(Env());
                Check(repository.Read().Revision == before, "one invalid file rejects entire load");
                OpenFileDialog.NextFiles = files; PlanDrawFixture.Decisions.Enqueue(DialogResult.No);
                new LoadPolygonsUseCase().Run(Env());
                Check(repository.Read().Revision == before, "cancel confirmation does not write");
                OpenFileDialog.NextFiles = files; OpenFileDialog.OnShow = delegate { ApplicationHost.Current.ActiveDocument = new object(); };
                new LoadPolygonsUseCase().Run(Env());
                Check(repository.Read().Revision == before, "changed owner cannot import");
                OpenFileDialog.OnShow = null;
                var crs = ScopedPolygonRecord.Crs(DateTime.UtcNow, Polygon(2).Polygon, 500, 123, 2.5);
                string crossFile = Path.Combine(folder, "cross.json"); PortablePolygonFile.Save(crossFile, crs);
                Check(PortablePolygonFile.Load(crossFile).Thickness == 2.5, "CRS thickness round trip");
                Check(PortablePolygonFile.Load(crossFile).SectionStation == 123, "source station preserved as metadata");
                PlanDrawFixture.ActiveAlignment.Corridor.Sections.Add(new TestSection { Id=88, Station=456 });
                OpenFileDialog.NextFile = crossFile; PlanDrawFixture.Decisions.Enqueue(DialogResult.Yes);
                new LoadPolygonsUseCase().Run(Env());
                var target = new ScopedPolygonRepository(PolygonContextResolver.ResolveProject(
                    PlanDrawFixture.ActiveAlignment, PolygonGeometryKind.Crs)).Read();
                Check(target.Records.Count == 1 && target.Records[0].SectionId == 88 &&
                    target.Records[0].SectionStation == 456, "CRS explicitly rebound to current section");
                byte[] prior = File.ReadAllBytes(files[0]);
                bool rejected = false;
                try { PortablePolygonFile.Save(files[0], ScopedPolygonRecord.Plan(DateTime.UtcNow,
                    new List<Vector2D> { new Vector2D(0,0) })); }
                catch (InvalidDataException) { rejected = true; }
                Check(rejected && Convert.ToBase64String(prior) == Convert.ToBase64String(File.ReadAllBytes(files[0])),
                    "invalid export preserves existing file");
                PlanDrawFixture.Switch(PlanDrawFixture.First);
                PlanDrawFixture.Decisions.Enqueue(DialogResult.Yes);
                FolderBrowserDialog.NextFolder = folder;
                PlanDrawFixture.Decisions.Enqueue(DialogResult.No);
                new SavePolygonsAsUseCase().Run(Env());
                Check(Convert.ToBase64String(prior) == Convert.ToBase64String(File.ReadAllBytes(files[0])), "declined overwrite preserves export");
                Console.WriteLine("Polygon file commands: " + checks + " checks passed."); return 0;
            }
            finally { PlanDrawFixture.Dispose(); }
        }
    }
}
