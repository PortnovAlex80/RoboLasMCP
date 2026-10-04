using System;
using System.IO;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.FoundationClasses;

namespace LAS_TERRAIN.Tests
{
    internal static class PolygonContextResolverTests
    {
        private delegate void TestAction();
        private static int checks;
        private static void Check(bool condition, string reason)
        {
            checks++;
            if (!condition) throw new Exception(reason);
        }
        private static void Reject(TestAction action, string reason)
        {
            bool threw = false;
            try { action(); }
            catch (InvalidOperationException) { threw = true; }
            Check(threw, reason);
        }

        private static Alignment Active(string projectPath, string alias,
            string modelUri, Guid alignmentId)
        {
            var project = new Project {
                Alias = alias,
                TargetProjectUri = new URI(new Uri(projectPath).AbsoluteUri)
            };
            var alignment = new Alignment {
                Id = alignmentId,
                Model = new FakeModel { Project = project, Uri = modelUri }
            };
            ApplicationHost.Current = new ApplicationHost { ActiveProject = project };
            return alignment;
        }

        private static void ScopeContracts(string root)
        {
            string firstPath = Path.Combine(root, "first.rbr");
            string secondPath = Path.Combine(root, "second.rbr");
            File.WriteAllText(firstPath, "first");
            File.WriteAllText(secondPath, "second");
            Guid id = Guid.NewGuid();
            Alignment first = Active(firstPath, "first", "model://one", id);
            PolygonScope planA = PolygonContextResolver.ResolveProject(
                first, PolygonGeometryKind.Plan);
            Check(planA.StorageRoot == Path.GetFullPath(root), "project directory");
            Check(planA.ProjectUri == new Uri(firstPath).AbsoluteUri, "project URI");
            Check(planA.Kind == PolygonScopeKind.Project, "project scope selected");
            Check(planA.AlignmentId == Guid.Empty, "Plan not alignment scoped");
            Check(planA.FilePath.Contains("polygon_scopes_v2"), "v2 location");
            Check(planA.FilePath.EndsWith(".plan.json"), "Plan suffix");

            // Rail 16 persists project URIs with the local:/// scheme.
            first.Model.Project.TargetProjectUri = new URI(
                "local:///" + new Uri(firstPath).AbsolutePath.TrimStart('/'));
            PolygonScope nativePlan = PolygonContextResolver.ResolveProject(
                first, PolygonGeometryKind.Plan);
            Check(nativePlan.StorageRoot == planA.StorageRoot,
                "native local URI resolves to the project directory");
            Check(nativePlan.ProjectUri == planA.ProjectUri,
                "native local and file URI share a canonical project URI");
            Check(nativePlan.ScopeKey == planA.ScopeKey,
                "native local and file URI do not split one project scope");

            string unicodePath = Path.Combine(root, "Проект с пробелом.rbr");
            File.WriteAllText(unicodePath, "unicode");
            Alignment unicode = Active(unicodePath, "unicode", "model://unicode", id);
            unicode.Model.Project.TargetProjectUri = new URI(
                "local:///" + new Uri(unicodePath).AbsolutePath.TrimStart('/'));
            PolygonScope unicodeScope = PolygonContextResolver.ResolveProject(
                unicode, PolygonGeometryKind.Plan);
            Check(unicodeScope.ProjectUri == new Uri(unicodePath).AbsoluteUri,
                "native local URI round-trips Unicode and spaces");
            Check(unicodeScope.StorageRoot == Path.GetFullPath(root),
                "Unicode project resolves to its directory");
            ApplicationHost.Current.ActiveProject = first.Model.Project;

            PolygonScope planAgain = PolygonContextResolver.ResolveProject(
                first, PolygonGeometryKind.Plan);
            Check(planAgain.ScopeKey == planA.ScopeKey, "same context stable");
            first.Model.Project.Alias = "renamed";
            PolygonScope renamedPlan = PolygonContextResolver.ResolveProject(
                first, PolygonGeometryKind.Plan);
            Check(renamedPlan.ScopeKey == planA.ScopeKey &&
                renamedPlan.FilePath == planA.FilePath,
                "display alias rename orphaned saved project polygons");
            first.Model.Project.Alias = "first";
            Alignment second = Active(secondPath, "second", "model://one", id);
            PolygonScope planB = PolygonContextResolver.ResolveProject(
                second, PolygonGeometryKind.Plan);
            Check(planB.ScopeKey != planA.ScopeKey,
                "two projects sharing a folder remain isolated");
            PolygonScope crsB = PolygonContextResolver.ResolveProject(
                second, PolygonGeometryKind.Crs);
            Check(crsB.FilePath.EndsWith(".crs.json"), "CRS suffix");
            Check(crsB.AlignmentId == id && crsB.ModelUri == "model://one",
                "CRS identity captured");
            Check(crsB.ScopeKey != planB.ScopeKey, "Plan and CRS separated");

            second.Id = Guid.NewGuid();
            PolygonScope anotherAlignment = PolygonContextResolver.ResolveProject(
                second, PolygonGeometryKind.Crs);
            Check(anotherAlignment.ScopeKey != crsB.ScopeKey,
                "two alignments in one project separated");
            second.Id = id;
            second.Model.Uri = "model://two";
            Check(PolygonContextResolver.ResolveProject(second,
                PolygonGeometryKind.Crs).ScopeKey != crsB.ScopeKey,
                "model URI contributes to CRS owner");
        }

        private static void Rejections(string root)
        {
            string projectPath = Path.Combine(root, "first.rbr");
            Alignment alignment = Active(projectPath, "first", "model://one",
                Guid.NewGuid());
            ApplicationHost.Current.ActiveProject = new Project();
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "inactive project rejected");
            ApplicationHost.Current.ActiveProject = alignment.Model.Project;
            alignment.Model.Project.TargetProjectUri = null;
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "unsaved project rejected");
            alignment.Model.Project.TargetProjectUri = new URI("relative.rbr");
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "relative project URI rejected");
            alignment.Model.Project.TargetProjectUri = new URI("https://example.test/a.rbr");
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "remote project rejected");
            alignment.Model.Project.TargetProjectUri = new URI("local://remote-host/D:/first.rbr");
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "remote local authority rejected");
            alignment.Model.Project.TargetProjectUri = new URI(
                new Uri(Path.Combine(root, "missing.rbr")).AbsoluteUri);
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "missing project file rejected");
            alignment.Model.Project.TargetProjectUri = new URI(
                new Uri(projectPath).AbsoluteUri);
            alignment.Id = Guid.Empty;
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Crs); }, "empty alignment ID rejected");
            alignment.Id = Guid.NewGuid();
            alignment.Model.Uri = null;
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "missing model URI rejected");
            alignment.Model = null;
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "unowned alignment rejected");
            ApplicationHost.Current = null;
            Reject(delegate { PolygonContextResolver.ResolveProject(
                alignment, PolygonGeometryKind.Plan); }, "missing host rejected");
        }

        public static int Main()
        {
            string root = Path.Combine(Path.GetTempPath(),
                "polygon-context-test-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(root);
            try
            {
                ScopeContracts(root);
                Rejections(root);
                Console.WriteLine("PolygonContextResolver: " + checks + " checks passed");
                return 0;
            }
            finally
            {
                foreach (string file in Directory.GetFiles(root))
                    File.Delete(file);
                Directory.Delete(root, false);
            }
        }
    }
}
