using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Service;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;

namespace LAS_TERRAIN.Tests
{
    internal static class SaveLidarPointsServiceTests
    {
        private static int checks;
        private static string root;

        public static int Main()
        {
            root = Path.Combine(Path.GetTempPath(),
                "robolas-save-service-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(root);
            try
            {
                SingleAndDialogPath();
                FinalProgressFailureAfterPublish();
                CancellationPreservesOldFinal();
                InvalidPointPreservesOldFinal();
                OneSidedPairs();
                PairCancellationPreservesBothFinals();
                BeforePublishGuardPreservesFinals(false, false);
                BeforePublishGuardPreservesFinals(true, false);
                BeforePublishGuardPreservesFinals(true, true);
                BeforePublishGuardPreservesEdgeOnly();
                PairSuccess();
                SecondFileConflictAndRecovery();
                Console.WriteLine("Save LAS service: " + checks + " checks passed.");
                return 0;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error);
                return 1;
            }
            finally
            {
                WaitProgress.Reset();
                Directory.Delete(root, true);
            }
        }

        private static ExportRequest Request(string name)
        {
            return new ExportRequest(Path.Combine(root, name));
        }

        private static List<Vector4D> Points(double x)
        {
            return new List<Vector4D> { new Vector4D(x, 20, 30, 42) };
        }

        private static void SingleAndDialogPath()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("single.las");
            UserDialogs.SavePath = request.PrimaryPath;
            ExportRequest selected;
            Check(SaveLidarPointsService.TryAskSaveModeAndPath(null, out selected),
                "selected path rejected");
            Check(selected.PrimaryPath == request.PrimaryPath &&
                selected.EdgePath == request.EdgePath, "dialog path changed");
            SaveLidarPointsService.Save(Points(10), selected, true, 0.7f);
            CheckLas(request.PrimaryPath, 1, 10);
            string referencePath = Path.Combine(root, "single-reference.las");
            using (LasStreamWriter writer = new LasStreamWriter(referencePath))
            {
                writer.WritePoints(Points(10));
                using (PreparedLasFile prepared = writer.Complete()) prepared.Publish();
            }
            SameBytes(File.ReadAllBytes(referencePath), File.ReadAllBytes(request.PrimaryPath),
                "service changed LAS point bytes");
            Check(WaitProgress.ProgressCalls == 2, "single-file progress sequence changed");
        }

        private static void FinalProgressFailureAfterPublish()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("final-progress.las");
            WaitProgress.ThrowOnCall = 2; // first call is the writer, second follows Publish.
            SaveLidarPointsService.Save(Points(11), request, true, 0.7f);
            CheckLas(request.PrimaryPath, 1, 11);
            Check(WaitProgress.ProgressCalls == 2,
                "final progress fault was not exercised after publication");
        }

        private static void CancellationPreservesOldFinal()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("cancel-before-publish.las");
            byte[] oldBytes = { 1, 2, 3, 4 };
            File.WriteAllBytes(request.PrimaryPath, oldBytes);
            WaitProgress.CancelOnCall = 1;
            bool cancelled = false;
            try { SaveLidarPointsService.Save(Points(12), request, true, 0.7f); }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled, "cancel during LAS writing did not stop publication");
            SameBytes(oldBytes, File.ReadAllBytes(request.PrimaryPath),
                "cancel changed previous final");
            Check(Directory.GetFiles(root, "cancel-before-publish.las.*.tmp").Length == 0,
                "cancel left an unowned stage");
        }

        private static void InvalidPointPreservesOldFinal()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("invalid-point.las");
            byte[] oldBytes = { 5, 6, 7 };
            File.WriteAllBytes(request.PrimaryPath, oldBytes);
            bool failed = false;
            try
            {
                SaveLidarPointsService.Save(
                    new List<Vector4D> { new Vector4D(Double.NaN, 0, 0, 1) },
                    request, false, 0);
            }
            catch (ArgumentException) { failed = true; }
            Check(failed, "invalid LAS point was accepted");
            SameBytes(oldBytes, File.ReadAllBytes(request.PrimaryPath),
                "invalid point changed previous final");
        }

        private static void OneSidedPairs()
        {
            WaitProgress.Reset();
            ExportRequest first = Request("only-first.las");
            byte[] oldEdge = { 8, 8, 8 };
            File.WriteAllBytes(first.EdgePath, oldEdge);
            SaveLidarPointsService.SaveTwoExternalProgress(Points(13),
                new List<Vector4D>(), first, 0);
            CheckLas(first.PrimaryPath, 1, 13);
            SameBytes(oldEdge, File.ReadAllBytes(first.EdgePath),
                "first-only export changed old edge destination");
            Check(!File.Exists(LasPairPublication.JournalPath(first.PrimaryPath)),
                "first-only export created pair journal");

            WaitProgress.Reset();
            ExportRequest second = Request("only-second.las");
            byte[] oldPrimary = { 9, 9, 9 };
            File.WriteAllBytes(second.PrimaryPath, oldPrimary);
            SaveLidarPointsService.SaveTwoExternalProgress(null, Points(14), second, 0);
            CheckLas(second.EdgePath, 1, 14);
            SameBytes(oldPrimary, File.ReadAllBytes(second.PrimaryPath),
                "second-only export changed old primary destination");
            Check(!File.Exists(LasPairPublication.JournalPath(second.PrimaryPath)),
                "second-only export created pair journal");
        }

        private static void PairSuccess()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("both.las");
            SaveLidarPointsService.SaveTwoExternalProgress(Points(15), Points(16), request, 0);
            CheckLas(request.PrimaryPath, 1, 15);
            CheckLas(request.EdgePath, 1, 16);
            Check(!File.Exists(LasPairPublication.JournalPath(request.PrimaryPath)),
                "successful pair retained journal");
        }

        private static void PairCancellationPreservesBothFinals()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("pair-cancel.las");
            byte[] oldFirst = { 4, 4, 4 };
            byte[] oldSecond = { 5, 5, 5 };
            File.WriteAllBytes(request.PrimaryPath, oldFirst);
            File.WriteAllBytes(request.EdgePath, oldSecond);
            WaitProgress.CancelOnCall = 2; // second writer callback, before either Publish.
            bool cancelled = false;
            try
            {
                SaveLidarPointsService.SaveTwoExternalProgress(
                    Points(19), Points(20), request, 0);
            }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled, "pair cancellation did not stop publication");
            SameBytes(oldFirst, File.ReadAllBytes(request.PrimaryPath),
                "pair cancel changed primary final");
            SameBytes(oldSecond, File.ReadAllBytes(request.EdgePath),
                "pair cancel changed edge final");
            Check(!File.Exists(LasPairPublication.JournalPath(request.PrimaryPath)),
                "pair cancellation created a recovery journal");
            Check(Directory.GetFiles(root, "pair-cancel*.tmp").Length == 0,
                "pair cancellation left an unowned stage");
        }

        private static void BeforePublishGuardPreservesFinals(bool pair, bool cancelInHook)
        {
            WaitProgress.Reset();
            string name = pair
                ? (cancelInHook ? "guard-pair-cancel.las" : "guard-pair.las")
                : "guard-single.las";
            ExportRequest request = Request(name);
            byte[] oldFirst = { 4, 7, 1 };
            byte[] oldSecond = { 2, 9, 3 };
            File.WriteAllBytes(request.PrimaryPath, oldFirst);
            File.WriteAllBytes(request.EdgePath, oldSecond);
            int calls = 0;
            int preparedCount = 0;
            Action beforePublish = delegate
            {
                calls++;
                preparedCount = Directory.GetFiles(root, name + ".*.tmp").Length +
                    Directory.GetFiles(root, Path.GetFileName(request.EdgePath) + ".*.tmp").Length;
                if (cancelInHook) WaitProgress.CancellationPending = true;
                else throw new OperationCanceledException("source changed");
            };
            bool cancelled = false;
            try
            {
                SaveLidarPointsService.SaveTwoExternalProgress(Points(21),
                    pair ? Points(22) : null, request, 0, beforePublish);
            }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled && calls == 1 && preparedCount == (pair ? 2 : 1),
                "before-publish guard did not run after all stages");
            SameBytes(oldFirst, File.ReadAllBytes(request.PrimaryPath),
                "guard changed primary final");
            SameBytes(oldSecond, File.ReadAllBytes(request.EdgePath),
                "guard changed edge final");
            Check(!File.Exists(LasPairPublication.JournalPath(request.PrimaryPath)),
                "guard created a pair journal");
            Check(Directory.GetFiles(root, name + ".*.tmp").Length == 0 &&
                Directory.GetFiles(root, Path.GetFileName(request.EdgePath) + ".*.tmp").Length == 0,
                "guard left unpublished stages");
        }

        private static void BeforePublishGuardPreservesEdgeOnly()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("guard-edge-only.las");
            byte[] oldFirst = { 6, 2, 1 };
            byte[] oldSecond = { 6, 2, 2 };
            File.WriteAllBytes(request.PrimaryPath, oldFirst);
            File.WriteAllBytes(request.EdgePath, oldSecond);
            int calls = 0;
            bool cancelled = false;
            try
            {
                SaveLidarPointsService.SaveTwoExternalProgress(null, Points(23),
                    request, 0, delegate
                    {
                        calls++;
                        Check(Directory.GetFiles(root,
                            Path.GetFileName(request.EdgePath) + ".*.tmp").Length == 1,
                            "edge stage was not prepared before guard");
                        throw new OperationCanceledException("source changed");
                    });
            }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled && calls == 1, "edge-only guard did not stop publication");
            SameBytes(oldFirst, File.ReadAllBytes(request.PrimaryPath),
                "edge-only guard changed primary final");
            SameBytes(oldSecond, File.ReadAllBytes(request.EdgePath),
                "edge-only guard changed edge final");
            Check(Directory.GetFiles(root,
                Path.GetFileName(request.EdgePath) + ".*.tmp").Length == 0,
                "edge-only guard left an unpublished stage");
        }

        private static void SecondFileConflictAndRecovery()
        {
            WaitProgress.Reset();
            ExportRequest request = Request("partial.las");
            byte[] oldFirst = { 1, 1, 1 };
            byte[] oldSecond = { 2, 2, 2 };
            byte[] changedSecond = { 3, 3, 3 };
            File.WriteAllBytes(request.PrimaryPath, oldFirst);
            File.WriteAllBytes(request.EdgePath, oldSecond);
            WaitProgress.OnProgress = delegate(float value)
            {
                if (WaitProgress.ProgressCalls == 2)
                    File.WriteAllBytes(request.EdgePath, changedSecond);
            };
            bool partial = false;
            try
            {
                SaveLidarPointsService.SaveTwoExternalProgress(
                    Points(17), Points(18), request, 0);
            }
            catch (IOException) { partial = true; }
            Check(partial, "changed second output did not report partial publication");
            CheckLas(request.PrimaryPath, 1, 17);
            SameBytes(changedSecond, File.ReadAllBytes(request.EdgePath),
                "second-file conflict overwrote external edit");
            Check(File.Exists(LasPairPublication.JournalPath(request.PrimaryPath)),
                "partial pair lost recovery journal");
            WaitProgress.Reset();
            File.WriteAllBytes(request.EdgePath, oldSecond);
            LasPairPublication.Recover(request.PrimaryPath);
            CheckLas(request.PrimaryPath, 1, 17);
            CheckLas(request.EdgePath, 1, 18);
            Check(!File.Exists(LasPairPublication.JournalPath(request.PrimaryPath)),
                "pair recovery retained journal");
        }

        private static void CheckLas(string path, int count, double x)
        {
            byte[] bytes = File.ReadAllBytes(path);
            Check(bytes.Length == 227 + count * 28, "LAS length changed: " + path);
            Check(bytes[0] == 'L' && bytes[1] == 'A' &&
                bytes[2] == 'S' && bytes[3] == 'F' &&
                bytes[24] == 1 && bytes[25] == 2,
                "LAS signature or version changed: " + path);
            Check(bytes[104] == 1 && BitConverter.ToUInt16(bytes, 105) == 28 &&
                BitConverter.ToUInt32(bytes, 107) == count,
                "LAS format or point count changed: " + path);
            Check(BitConverter.ToDouble(bytes, 131) == 0.0001 &&
                BitConverter.ToDouble(bytes, 155) == x,
                "LAS coordinate scale or offset changed: " + path);
            if (count > 0)
                Check(BitConverter.ToUInt16(bytes, 227 + 12) == 42 &&
                    bytes[227 + 15] == 2, "LAS intensity or classification changed: " + path);
        }

        private static void SameBytes(byte[] expected, byte[] actual, string message)
        {
            Check(expected.Length == actual.Length, message + " length");
            for (int i = 0; i < expected.Length; i++)
                if (expected[i] != actual[i]) throw new Exception(message + " byte " + i);
            checks++;
        }

        private static void Check(bool condition, string message)
        {
            if (!condition) throw new Exception(message);
            checks++;
        }
    }
}
