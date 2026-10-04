using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class LasPairPublicationTests
    {
        private static int _checks;

        public static int Main()
        {
            string directory = Path.Combine(Path.GetTempPath(), "robolas-pair-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(directory);
            try
            {
                Success(directory);
                PartialAndRecovery(directory);
                ConflictAfterPartial(directory);
                Console.WriteLine("LAS pair publication: " + _checks + " checks passed.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return 1;
            }
            finally
            {
                Directory.Delete(directory, true);
            }
        }

        private static PreparedLasFile Prepare(string path, double x)
        {
            using (LasStreamWriter writer = new LasStreamWriter(path))
            {
                writer.WritePoints(new List<Vector4D> { new Vector4D(x, x + 1, x + 2, 7) });
                return writer.Complete();
            }
        }

        private static void Success(string directory)
        {
            string firstPath = Path.Combine(directory, "success.las");
            string secondPath = Path.Combine(directory, "success_edge.las");
            using (PreparedLasFile first = Prepare(firstPath, 1))
            using (PreparedLasFile second = Prepare(secondPath, 2))
                LasPairPublication.Publish(first, second);
            Check(File.Exists(firstPath) && File.Exists(secondPath), "both outputs published");
            Check(!File.Exists(LasPairPublication.JournalPath(firstPath)), "successful journal removed");
        }

        private static void PartialAndRecovery(string directory)
        {
            string firstPath = Path.Combine(directory, "partial.las");
            string secondPath = Path.Combine(directory, "partial_edge.las");
            File.WriteAllText(secondPath, "old-second");
            using (PreparedLasFile first = Prepare(firstPath, 10))
            using (PreparedLasFile second = Prepare(secondPath, 20))
            {
                File.WriteAllText(secondPath, "changed-second");
                bool failed = false;
                try { LasPairPublication.Publish(first, second); }
                catch (IOException) { failed = true; }
                Check(failed && first.IsPublished && !second.IsPublished, "second failure is partial");
                Check(File.Exists(second.StagePath), "second prepared stage retained");
                Check(File.Exists(LasPairPublication.JournalPath(firstPath)), "partial journal retained");
            }
            Check(File.ReadAllText(secondPath) == "changed-second", "changed final preserved");
            File.WriteAllText(secondPath, "old-second");
            string firstHash = LasPairPublication.Fingerprint(firstPath);
            LasPairPublication.Recover(firstPath);
            Check(LasPairPublication.Fingerprint(firstPath) == firstHash, "first output not republished");
            Check(File.ReadAllText(secondPath) != "old-second", "second output recovered");
            Check(!File.Exists(LasPairPublication.JournalPath(firstPath)), "recovery journal removed");
        }

        private static void ConflictAfterPartial(string directory)
        {
            string firstPath = Path.Combine(directory, "conflict.las");
            string secondPath = Path.Combine(directory, "conflict_edge.las");
            File.WriteAllText(secondPath, "old-second");
            using (PreparedLasFile first = Prepare(firstPath, 30))
            using (PreparedLasFile second = Prepare(secondPath, 40))
            {
                File.WriteAllText(secondPath, "changed-second");
                try { LasPairPublication.Publish(first, second); }
                catch (IOException) { }
            }
            File.WriteAllText(firstPath, "external-edit");
            bool failed = false;
            try { LasPairPublication.Recover(firstPath); }
            catch (IOException) { failed = true; }
            Check(failed, "modified first output blocks retry");
            Check(File.ReadAllText(firstPath) == "external-edit", "external first output preserved");
            Check(File.Exists(LasPairPublication.JournalPath(firstPath)), "conflict journal retained");
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }
    }
}
