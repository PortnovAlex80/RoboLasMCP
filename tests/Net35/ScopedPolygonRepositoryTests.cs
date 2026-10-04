using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using LAS_TERRAIN.Domain.Persistence;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class ScopedPolygonRepositoryTests
    {
        private delegate void TestAction();
        private static int _checks;

        private static int Main(string[] args)
        {
            if (args.Length == 3 && args[0] == "--child")
                return RunConcurrentChild(args[1], args[2]);
            string root = Path.Combine(Path.GetTempPath(), "polygon-v2-test-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(root);
            try
            {
                ProjectIsolation(root);
                AlignmentIsolation(root);
                StaleRevision(root);
                InterprocessStaleRevision(root);
                FailedWrite(root);
                Console.WriteLine("Scoped polygon repository: " + _checks + " checks passed.");
            }
            finally { Directory.Delete(root, true); }
            return 0;
        }

        private static ScopedPolygonRecord Plan(double x)
        {
            return ScopedPolygonRecord.Plan(new DateTime(2026, 9, 29, 12, 0, 0, DateTimeKind.Utc),
                new List<Vector2D> { new Vector2D(x, 2), new Vector2D(x + 1, 3) });
        }

        private static ScopedPolygonRecord Crs(uint sectionId)
        {
            return ScopedPolygonRecord.Crs(new DateTime(2026, 9, 29, 12, 0, 0, DateTimeKind.Utc),
                new List<Vector2D> { new Vector2D(1, 2) }, sectionId, 45.5, 0.25);
        }

        private static void ProjectIsolation(string root)
        {
            PolygonScope a = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///shared/a.trp", "a.trp", null, Guid.Empty);
            PolygonScope b = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///shared/b.trp", "b.trp", null, Guid.Empty);
            Check(a.FilePath != b.FilePath, "two projects in one directory share a file");
            ScopedPolygonRepository first = new ScopedPolygonRepository(a);
            ScopedPolygonRepository second = new ScopedPolygonRepository(b);
            Throws<ArgumentException>(delegate
            {
                second.Commit(first.Read(), new ScopedPolygonRecord[] { Plan(9) });
            }, "snapshot from another scope");
            first.Commit(first.Read(), new ScopedPolygonRecord[] { Plan(1) });
            Check(first.Read().Records.Count == 1, "project A did not persist");
            Check(second.Read().Records.Count == 0, "project B saw project A polygons");
            second.Commit(second.Read(), new ScopedPolygonRecord[] { Plan(2) });
            Check(first.Read().Records[0].Polygon[0].X == 1, "project B overwrote project A");
            Check(second.Read().Records[0].Polygon[0].X == 2, "project B failed to persist");
            PolygonScope renamed = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///shared/a.trp", "renamed.trp", null, Guid.Empty);
            Check(renamed.ScopeKey == a.ScopeKey && renamed.FilePath == a.FilePath,
                "renaming a project changed its polygon owner");
            ScopedPolygonRepository renamedRepository = new ScopedPolygonRepository(renamed);
            Check(renamedRepository.Read().Records.Count == 1 &&
                renamedRepository.Read().Records[0].Polygon[0].X == 1,
                "renamed project lost its polygons");
            renamedRepository.Commit(renamedRepository.Read(),
                new ScopedPolygonRecord[] { Plan(3) });
            Check(first.Read().Records[0].Polygon[0].X == 3,
                "old alias could not read the same project after rename");
            Check(File.ReadAllText(renamed.FilePath).Contains(
                "\"projectAlias\":\"renamed.trp\""),
                "renamed project display alias was not updated on commit");
            PolygonScope unnamed = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///shared/a.trp", "", null, Guid.Empty);
            Check(unnamed.ScopeKey == a.ScopeKey,
                "empty display alias changed a saved project owner");
            Throws<NotSupportedException>(delegate { first.Read().Records.Add(Plan(3)); }, "mutable snapshot list");
            Throws<NotSupportedException>(delegate { first.Read().Records[0].Polygon.Add(new Vector2D(3, 4)); }, "mutable polygon");

            PolygonScope shared = PolygonScope.ForSharedCloud(PolygonGeometryKind.Plan, root,
                "explicit-cloud", null, Guid.Empty);
            Check(shared.FilePath != a.FilePath && shared.FilePath != b.FilePath,
                "shared cloud aliases a project scope");
            Check(new ScopedPolygonRepository(shared).Read().Records.Count == 0,
                "shared cloud was enabled implicitly");
        }

        private static void AlignmentIsolation(string root)
        {
            Guid one = Guid.NewGuid(), two = Guid.NewGuid();
            PolygonScope a = PolygonScope.ForProject(PolygonGeometryKind.Crs, root,
                "file:///shared/project-a", "a.trp", "model://alignment-one", one);
            PolygonScope b = PolygonScope.ForProject(PolygonGeometryKind.Crs, root,
                "file:///shared/project-a", "a.trp", "model://alignment-two", two);
            Check(a.FilePath != b.FilePath, "two alignments share a CRS file");
            ScopedPolygonRepository first = new ScopedPolygonRepository(a);
            ScopedPolygonRepository second = new ScopedPolygonRepository(b);
            first.Commit(first.Read(), new ScopedPolygonRecord[] { Crs(7) });
            Check(first.Read().Records[0].SectionId == 7, "CRS section ID was lost");
            Check(first.Read().Records[0].SectionStation == 45.5, "CRS station was lost");
            Check(second.Read().Records.Count == 0, "second alignment saw first polygons");
        }

        private static void StaleRevision(string root)
        {
            PolygonScope scope = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///stale", "stale.trp", null, Guid.Empty);
            ScopedPolygonRepository first = new ScopedPolygonRepository(scope);
            ScopedPolygonRepository second = new ScopedPolygonRepository(scope);
            ScopedPolygonSnapshot initialA = first.Read();
            ScopedPolygonSnapshot initialB = second.Read();
            first.Commit(initialA, new ScopedPolygonRecord[] { Plan(1) });
            Throws<PolygonRevisionConflictException>(delegate
            {
                second.Commit(initialB, new ScopedPolygonRecord[] { Plan(2) });
            }, "stale writer");
            Check(first.Read().Records.Count == 1 && first.Read().Records[0].Polygon[0].X == 1,
                "stale writer changed current state");
        }

        private static PolygonScope ConcurrentScope(string root)
        {
            return PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///concurrent", "concurrent.trp", null, Guid.Empty);
        }

        private static int RunConcurrentChild(string root, string role)
        {
            try
            {
                if (role != "first" && role != "second") return 3;
                ScopedPolygonRepository repository = new ScopedPolygonRepository(ConcurrentScope(root));
                ScopedPolygonSnapshot stale = repository.Read();
                PublishMarker(Path.Combine(root, role + ".ready"), stale.Revision);
                WaitForFile(Path.Combine(root, role + ".go"), "release of " + role);
                if (role == "first")
                {
                    repository.Commit(stale, new ScopedPolygonRecord[] { Plan(42) });
                    PublishMarker(Path.Combine(root, role + ".done"), "committed");
                }
                else
                {
                    try
                    {
                        repository.Commit(stale, new ScopedPolygonRecord[] { Plan(99) });
                        PublishMarker(Path.Combine(root, role + ".done"), "wrongly committed");
                        return 4;
                    }
                    catch (PolygonRevisionConflictException)
                    {
                        PublishMarker(Path.Combine(root, role + ".done"), "conflict");
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(role + ": " + ex);
                return 5;
            }
        }

        private static void InterprocessStaleRevision(string root)
        {
            string directory = Path.Combine(root, "interprocess");
            Directory.CreateDirectory(directory);
            Process first = null, second = null;
            try
            {
                first = StartChild(directory, "first");
                second = StartChild(directory, "second");
                WaitForFile(Path.Combine(directory, "first.ready"), "first process read");
                WaitForFile(Path.Combine(directory, "second.ready"), "second process read");
                Check(File.ReadAllText(Path.Combine(directory, "first.ready")) ==
                    File.ReadAllText(Path.Combine(directory, "second.ready")),
                    "processes did not read the same revision");

                File.WriteAllText(Path.Combine(directory, "first.go"), String.Empty);
                WaitForFile(Path.Combine(directory, "first.done"), "first process commit");
                Check(first.WaitForExit(10000) && first.ExitCode == 0,
                    "first process did not commit");
                string destination = ConcurrentScope(directory).FilePath;
                byte[] committed = File.ReadAllBytes(destination);

                File.WriteAllText(Path.Combine(directory, "second.go"), String.Empty);
                WaitForFile(Path.Combine(directory, "second.done"), "second process conflict");
                Check(second.WaitForExit(10000) && second.ExitCode == 0 &&
                    File.ReadAllText(Path.Combine(directory, "second.done")) == "conflict",
                    "second process did not report a revision conflict");
                Check(BytesEqual(committed, File.ReadAllBytes(destination)),
                    "conflicting process changed committed bytes");
                ScopedPolygonSnapshot final = new ScopedPolygonRepository(ConcurrentScope(directory)).Read();
                Check(final.Records.Count == 1 && final.Records[0].Polygon[0].X == 42,
                    "interprocess result is not a valid first commit");
            }
            finally
            {
                StopChild(first);
                StopChild(second);
            }
        }

        private static Process StartChild(string root, string role)
        {
            string executable = Process.GetCurrentProcess().MainModule.FileName;
            ProcessStartInfo info = new ProcessStartInfo(executable,
                "--child " + Quote(root) + " " + role);
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            return Process.Start(info);
        }

        private static string Quote(string value)
        {
            return "\"" + value.Replace("\"", "\\\"") + "\"";
        }

        private static void PublishMarker(string path, string value)
        {
            string temporary = path + ".tmp";
            File.WriteAllText(temporary, value);
            File.Move(temporary, path);
        }

        private static void WaitForFile(string path, string operation)
        {
            DateTime deadline = DateTime.UtcNow.AddSeconds(10);
            while (!File.Exists(path))
            {
                if (DateTime.UtcNow >= deadline) throw new Exception("Timed out waiting for " + operation);
                Thread.Sleep(20);
            }
        }

        private static void StopChild(Process process)
        {
            if (process == null) return;
            try { if (!process.HasExited) process.Kill(); }
            finally { process.Dispose(); }
        }

        private static void FailedWrite(string root)
        {
            PolygonScope scope = PolygonScope.ForProject(PolygonGeometryKind.Plan, root,
                "file:///write-failure", "failure.trp", null, Guid.Empty);
            ScopedPolygonRepository repository = new ScopedPolygonRepository(scope);
            ScopedPolygonSnapshot committed = repository.Commit(repository.Read(),
                new ScopedPolygonRecord[] { Plan(5) });
            byte[] previous = File.ReadAllBytes(scope.FilePath);
            using (FileStream locked = new FileStream(scope.FilePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                Throws<IOException>(delegate
                {
                    repository.Commit(committed, new ScopedPolygonRecord[0]);
                }, "locked destination");
            }
            Check(BytesEqual(previous, File.ReadAllBytes(scope.FilePath)), "write failure changed original bytes");
            Check(repository.Read().Records.Count == 1, "write failure changed records");
            Check(Directory.GetFiles(Path.GetDirectoryName(scope.FilePath), "*.tmp").Length == 0,
                "temporary file leaked after failed replace");
        }


        private static bool BytesEqual(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++) if (a[i] != b[i]) return false;
            return true;
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }

        private static void Throws<T>(TestAction action, string name) where T : Exception
        {
            try { action(); }
            catch (T) { _checks++; return; }
            throw new Exception(name + ": expected " + typeof(T).Name);
        }
    }
}
