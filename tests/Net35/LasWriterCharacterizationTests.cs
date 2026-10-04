// Historical pre-PR-07 characterization. These tests deliberately assert the
// old Dispose finalization defects and are excluded from run.cmd. The active
// contract is LasWriterFinalizationTests; measured old behavior is documented
// in docs/las-writer-baseline.md.
using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;
using Topomatic.Controls;

namespace LAS_TERRAIN.Tests
{
    internal static class LasWriterCharacterizationTests
    {
        private static int passed;
        private static string outputDirectory;

        private static void Check(bool condition, string message)
        {
            if (!condition) throw new Exception(message);
        }

        private static void Test(string name, Action body)
        {
            body();
            passed++;
            Console.WriteLine("PASS " + name);
        }

        private static List<Vector4D> TinyPoints()
        {
            return new List<Vector4D> {
                new Vector4D(-10, 20, 30, -1),
                new Vector4D(-9, 21, 31, 70000)
            };
        }

        private static string Output(string name)
        {
            return Path.Combine(outputDirectory, name);
        }

        private static byte[] CheckLas(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            Check(data.Length == 227 + 2 * 28, "wrong file length for " + path);
            Check(data[0] == 'L' && data[1] == 'A' && data[2] == 'S' && data[3] == 'F',
                "missing LASF signature");
            Check(data[24] == 1 && data[25] == 2, "expected LAS version 1.2");
            Check(BitConverter.ToUInt16(data, 94) == 227 && BitConverter.ToUInt32(data, 96) == 227,
                "header size or data offset changed");
            Check(data[104] == 1 && BitConverter.ToUInt16(data, 105) == 28,
                "current point format 1 / 28-byte contract changed");
            Check(BitConverter.ToUInt32(data, 107) == 2, "header point count changed");
            for (int i = 0; i < 5; i++)
                Check(BitConverter.ToUInt32(data, 111 + i * 4) == 0,
                    "current per-return header counts changed");
            Check(BitConverter.ToDouble(data, 131) == 0.0001 &&
                  BitConverter.ToDouble(data, 139) == 0.0001 &&
                  BitConverter.ToDouble(data, 147) == 0.0001,
                "coordinate scales changed");
            Check(BitConverter.ToDouble(data, 155) == -10 &&
                  BitConverter.ToDouble(data, 163) == 20 &&
                  BitConverter.ToDouble(data, 171) == 30,
                "coordinate offsets changed");
            Check(BitConverter.ToDouble(data, 179) == -9 && BitConverter.ToDouble(data, 187) == -10 &&
                  BitConverter.ToDouble(data, 195) == 21 && BitConverter.ToDouble(data, 203) == 20 &&
                  BitConverter.ToDouble(data, 211) == 31 && BitConverter.ToDouble(data, 219) == 30,
                "header bounds changed");
            Check(BitConverter.ToInt32(data, 227) == 0 &&
                  BitConverter.ToInt32(data, 231) == 0 &&
                  BitConverter.ToInt32(data, 235) == 0 &&
                  BitConverter.ToUInt16(data, 239) == 0 && data[242] == 2,
                "first point fields changed");
            Check(BitConverter.ToInt32(data, 255) == 10000 &&
                  BitConverter.ToInt32(data, 259) == 10000 &&
                  BitConverter.ToInt32(data, 263) == 10000 &&
                  BitConverter.ToUInt16(data, 267) == 65535 && data[270] == 2,
                "second point fields changed");
            return data;
        }

        private static bool ZeroHeader(byte[] data)
        {
            for (int i = 0; i < 227; i++) if (data[i] != 0) return false;
            return true;
        }

        private static void CheckEdgeHeader(byte[] data, int count,
            double xOffset, double yOffset, double zOffset,
            double xMax, double xMin, double yMax, double yMin, double zMax, double zMin)
        {
            Check(data.Length == 227 + count * 28, "edge file length changed");
            Check(data[0] == 'L' && data[1] == 'A' && data[2] == 'S' && data[3] == 'F' &&
                  data[24] == 1 && data[25] == 2 &&
                  BitConverter.ToUInt16(data, 94) == 227 && BitConverter.ToUInt32(data, 96) == 227 &&
                  data[104] == 1 && BitConverter.ToUInt16(data, 105) == 28 &&
                  BitConverter.ToUInt32(data, 107) == count,
                "edge LAS signature/version/format/count changed");
            Check(BitConverter.ToDouble(data, 155) == xOffset &&
                  BitConverter.ToDouble(data, 163) == yOffset &&
                  BitConverter.ToDouble(data, 171) == zOffset,
                "edge header offsets changed");
            Check(BitConverter.ToDouble(data, 179) == xMax &&
                  BitConverter.ToDouble(data, 187) == xMin &&
                  BitConverter.ToDouble(data, 195) == yMax &&
                  BitConverter.ToDouble(data, 203) == yMin &&
                  BitConverter.ToDouble(data, 211) == zMax &&
                  BitConverter.ToDouble(data, 219) == zMin,
                "edge header bounds changed");
        }

        public static int Main()
        {
            outputDirectory = Path.Combine(Path.GetTempPath(),
                "robolas-las-writer-baseline-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(outputDirectory);
            Console.WriteLine("ARTIFACTS " + outputDirectory);
            try
            {
                Test("stream writes only on Dispose; LAS 1.2 format 1 bytes", delegate
                {
                    string path = Output("stream.las");
                    List<int> progress = new List<int>();
                    LasStreamWriter writer = new LasStreamWriter(path);
                    writer.OnProgress = delegate(int current, int total) {
                        Check(total == 2, "stream total changed"); progress.Add(current);
                    };
                    writer.WritePoints(TinyPoints());
                    Check(!File.Exists(path), "stream wrote before Dispose");
                    writer.Dispose();
                    CheckLas(path);
                    Check(progress.Count == 2 && progress[0] == 1 && progress[1] == 2,
                        "stream progress changed");
                });

                Test("batch stages raw doubles then finalizes on Dispose", delegate
                {
                    string path = Output("batch.las");
                    List<int> progress = new List<int>();
                    LasBatchStreamWriter writer = new LasBatchStreamWriter(path);
                    writer.OnProgress = delegate(int current, int total) {
                        Check(total == 2, "batch total changed"); progress.Add(current);
                    };
                    writer.WritePoints(TinyPoints());
                    // FileShare.None prevents inspecting the open stream here.
                    // The canceled case below verifies the raw layout after close.
                    Check(File.Exists(path), "batch did not open target before Dispose");
                    writer.Dispose();
                    byte[] batchBytes = CheckLas(path);
                    byte[] streamBytes = File.ReadAllBytes(Output("stream.las"));
                    Check(batchBytes.Length == streamBytes.Length, "writers have different file lengths");
                    for (int i = 0; i < batchBytes.Length; i++)
                        Check(batchBytes[i] == streamBytes[i], "writers differ at byte " + i);
                    Check(progress.Count == 2 && progress[0] == 1 && progress[1] == 2,
                        "batch progress changed");
                });

                Test("batch cancellation leaves truncated target with raw records", delegate
                {
                    string path = Output("batch-canceled.las");
                    File.WriteAllBytes(path, new byte[] { 9, 8, 7 });
                    LasBatchStreamWriter writer = new LasBatchStreamWriter(path);
                    writer.WritePoints(TinyPoints());
                    WaitProgress.CancellationPending = true;
                    try { writer.Dispose(); }
                    finally { WaitProgress.CancellationPending = false; }
                    byte[] data = File.ReadAllBytes(path);
                    Check(data.Length == 283 && ZeroHeader(data),
                        "canceled batch output shape changed");
                    Check(BitConverter.ToDouble(data, 227) == -10 &&
                          BitConverter.ToDouble(data, 235) == 20 &&
                          BitConverter.ToDouble(data, 243) == 30,
                        "canceled batch raw point changed");
                    Check(data[0] != 9, "batch constructor no longer overwrites old target");
                });

                Test("stream progress failure leaves header claiming unwritten points", delegate
                {
                    string path = Output("stream-progress-failed.las");
                    LasStreamWriter writer = new LasStreamWriter(path);
                    writer.WritePoints(TinyPoints());
                    writer.OnProgress = delegate(int current, int total) {
                        throw new ApplicationException("progress sentinel");
                    };
                    bool caught = false;
                    try { writer.Dispose(); }
                    catch (ApplicationException ex) { caught = ex.Message == "progress sentinel"; }
                    Check(caught, "stream progress failure was swallowed");
                    byte[] data = File.ReadAllBytes(path);
                    Check(data.Length == 255 && BitConverter.ToUInt32(data, 107) == 2,
                        "partial stream output changed");
                });

                Test("batch progress failure leaves raw records and zero header", delegate
                {
                    string path = Output("batch-progress-failed.las");
                    LasBatchStreamWriter writer = new LasBatchStreamWriter(path);
                    writer.WritePoints(TinyPoints());
                    writer.OnProgress = delegate(int current, int total) {
                        throw new ApplicationException("progress sentinel");
                    };
                    bool caught = false;
                    try { writer.Dispose(); }
                    catch (ApplicationException ex) { caught = ex.Message == "progress sentinel"; }
                    Check(caught, "batch progress failure was swallowed");
                    byte[] data = File.ReadAllBytes(path);
                    Check(data.Length == 283 && ZeroHeader(data) &&
                          BitConverter.ToDouble(data, 227) == -10,
                        "partial batch output changed");
                });

                Test("single point exposes batch max-bound initialization bug", delegate
                {
                    List<Vector4D> points = new List<Vector4D> { new Vector4D(7, 8, 9, 42) };
                    string streamPath = Output("stream-single.las");
                    LasStreamWriter stream = new LasStreamWriter(streamPath);
                    stream.WritePoints(points);
                    stream.Dispose();
                    byte[] a = File.ReadAllBytes(streamPath);
                    CheckEdgeHeader(a, 1, 7, 8, 9, 7, 7, 8, 8, 9, 9);

                    string batchPath = Output("batch-single.las");
                    LasBatchStreamWriter batch = new LasBatchStreamWriter(batchPath);
                    batch.WritePoints(points);
                    batch.Dispose();
                    byte[] b = File.ReadAllBytes(batchPath);
                    CheckEdgeHeader(b, 1, 7, 8, 9,
                        double.MinValue, 7, double.MinValue, 8, double.MinValue, 9);
                    for (int i = 227; i < a.Length; i++)
                        Check(a[i] == b[i], "single point records differ at " + i);
                });

                Test("strictly descending XYZ leaves batch max bounds unset", delegate
                {
                    List<Vector4D> points = new List<Vector4D> {
                        new Vector4D(3, 30, 300, 1),
                        new Vector4D(2, 20, 200, 2),
                        new Vector4D(1, 10, 100, 3)
                    };
                    string streamPath = Output("stream-descending.las");
                    LasStreamWriter stream = new LasStreamWriter(streamPath);
                    stream.WritePoints(points);
                    stream.Dispose();
                    byte[] a = File.ReadAllBytes(streamPath);
                    CheckEdgeHeader(a, 3, 1, 10, 100, 3, 1, 30, 10, 300, 100);

                    string batchPath = Output("batch-descending.las");
                    LasBatchStreamWriter batch = new LasBatchStreamWriter(batchPath);
                    batch.WritePoints(points);
                    batch.Dispose();
                    byte[] b = File.ReadAllBytes(batchPath);
                    CheckEdgeHeader(b, 3, 1, 10, 100,
                        double.MinValue, 1, double.MinValue, 10, double.MinValue, 100);
                    for (int i = 227; i < a.Length; i++)
                        Check(a[i] == b[i], "descending point records differ at " + i);
                });

                Test("empty outputs diverge in offsets and retain invalid bounds", delegate
                {
                    string streamPath = Output("stream-empty.las");
                    LasStreamWriter stream = new LasStreamWriter(streamPath);
                    stream.Dispose();
                    byte[] a = File.ReadAllBytes(streamPath);
                    CheckEdgeHeader(a, 0,
                        double.MaxValue, double.MaxValue, double.MaxValue,
                        double.MinValue, double.MaxValue, double.MinValue, double.MaxValue,
                        double.MinValue, double.MaxValue);
                    string batchPath = Output("batch-empty.las");
                    LasBatchStreamWriter batch = new LasBatchStreamWriter(batchPath);
                    batch.Dispose();
                    byte[] b = File.ReadAllBytes(batchPath);
                    CheckEdgeHeader(b, 0, 0, 0, 0,
                        double.MinValue, double.MaxValue, double.MinValue, double.MaxValue,
                        double.MinValue, double.MaxValue);
                });

                Console.WriteLine("PASS " + passed + " LAS writer baseline groups");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL after " + passed + " LAS writer groups: " + ex);
                return 1;
            }
            finally
            {
                WaitProgress.CancellationPending = false;
            }
        }
    }
}
