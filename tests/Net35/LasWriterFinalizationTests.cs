using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class LasWriterFinalizationTests
    {
        private static int assertions;
        private static string root;

        private static void Check(bool condition, string message)
        {
            assertions++;
            if (!condition) throw new Exception(message);
        }

        private static string Folder(string name)
        {
            string path = Path.Combine(root, name);
            Directory.CreateDirectory(path);
            return path;
        }

        private static string PathIn(string folder, string name)
        {
            return Path.Combine(folder, name);
        }

        private static List<Vector4D> TinyPoints()
        {
            return new List<Vector4D> {
                new Vector4D(-10, 20, 30, -1),
                new Vector4D(-9, 21, 31, 70000)
            };
        }

        private static List<Vector4D> ManyPoints()
        {
            List<Vector4D> points = new List<Vector4D>(10001);
            for (int i = 0; i < 10001; i++)
                points.Add(new Vector4D(i * 0.01, i * 0.02, i * 0.03, i % 255));
            return points;
        }

        private static void SameBytes(byte[] expected, byte[] actual, string message)
        {
            Check(expected.Length == actual.Length, message + " length");
            for (int i = 0; i < expected.Length; i++)
                Check(expected[i] == actual[i], message + " byte " + i);
        }

        private static void CheckLas(byte[] data, int count)
        {
            Check(data.Length == 227 + count * 28, "LAS file length");
            Check(data[0] == 'L' && data[1] == 'A' && data[2] == 'S' && data[3] == 'F',
                "LASF signature");
            Check(data[24] == 1 && data[25] == 2 && data[104] == 1,
                "LAS 1.2 format 1 changed");
            Check(BitConverter.ToUInt16(data, 94) == 227 &&
                BitConverter.ToUInt16(data, 105) == 28 &&
                BitConverter.ToUInt32(data, 107) == count, "LAS header count/size");
            Check(BitConverter.ToUInt32(data, 111) == count,
                "LAS first-return count must equal the point count");
            for (int i = 1; i < 5; i++)
                Check(BitConverter.ToUInt32(data, 111 + i * 4) == 0,
                    "LAS unused return count must be zero");
            for (int i = 0; i < count; i++)
                Check(data[227 + i * 28 + 14] == 9,
                    "LAS point return number/count must be 1 of 1");
            Check(BitConverter.ToDouble(data, 131) == 0.0001,
                "LAS coordinate scale changed");
        }

        private static PreparedLasFile PrepareStream(string finalPath, List<Vector4D> points)
        {
            using (LasStreamWriter writer = new LasStreamWriter(finalPath))
            {
                writer.WritePoints(points);
                return writer.Complete();
            }
        }

        private static PreparedLasFile PrepareBatch(string finalPath, List<Vector4D> points)
        {
            using (LasBatchStreamWriter writer = new LasBatchStreamWriter(finalPath))
            {
                writer.WritePoints(points);
                return writer.Complete();
            }
        }

        private static void TestNormalParity()
        {
            string folder = Folder("parity");
            string streamPath = PathIn(folder, "stream.las");
            string batchPath = PathIn(folder, "batch.las");
            using (PreparedLasFile stream = PrepareStream(streamPath, TinyPoints()))
            using (PreparedLasFile batch = PrepareBatch(batchPath, TinyPoints()))
            {
                Check(!File.Exists(streamPath) && !File.Exists(batchPath),
                    "Complete published before Publish");
                Check(File.Exists(stream.StagePath) && File.Exists(batch.StagePath),
                    "Complete did not retain stages");
                Check(!stream.IsPublished && !batch.IsPublished, "Premature published status");
                stream.Publish();
                batch.Publish();
                Check(stream.IsPublished && batch.IsPublished, "Publish status missing");
            }
            byte[] streamBytes = File.ReadAllBytes(streamPath);
            byte[] batchBytes = File.ReadAllBytes(batchPath);
            CheckLas(streamBytes, 2);
            CheckLas(batchBytes, 2);
            SameBytes(streamBytes, batchBytes, "normal writer parity");
            Check(BitConverter.ToInt32(streamBytes, 227) == 0 &&
                BitConverter.ToInt32(streamBytes, 231) == 0 &&
                BitConverter.ToInt32(streamBytes, 235) == 0 &&
                BitConverter.ToInt32(streamBytes, 255) == 10000 &&
                BitConverter.ToInt32(streamBytes, 259) == 10000 &&
                BitConverter.ToInt32(streamBytes, 263) == 10000,
                "normal point coordinate bytes changed");
            Check(BitConverter.ToUInt16(streamBytes, 239) == 0 &&
                BitConverter.ToUInt16(streamBytes, 267) == 65535,
                "intensity clipping changed");
        }

        private static void TestDisposeWithoutComplete()
        {
            string folder = Folder("abandon");
            string finalPath = PathIn(folder, "old.las");
            byte[] previous = { 9, 8, 7, 6 };
            File.WriteAllBytes(finalPath, previous);

            using (LasStreamWriter writer = new LasStreamWriter(finalPath))
                writer.WritePoints(TinyPoints());
            SameBytes(previous, File.ReadAllBytes(finalPath), "stream abandon preserved old file");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "stream abandon left staging data");

            using (LasBatchStreamWriter writer = new LasBatchStreamWriter(finalPath))
                writer.WritePoints(TinyPoints());
            SameBytes(previous, File.ReadAllBytes(finalPath), "batch abandon preserved old file");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "batch abandon left raw staging data");

            using (PreparedLasFile prepared = PrepareBatch(finalPath, TinyPoints()))
                Check(File.Exists(prepared.StagePath), "prepared stage missing");
            SameBytes(previous, File.ReadAllBytes(finalPath), "prepared Dispose preserved old file");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "prepared Dispose left staging data");
        }

        private static void TestRejectNonLasDestination()
        {
            string folder = Folder("reject-source-format");
            string sourcePath = PathIn(folder, "source.ldr");
            byte[] source = { 76, 68, 65, 82, 1, 2, 3 };
            File.WriteAllBytes(sourcePath, source);
            bool rejectedStream = false;
            bool rejectedBatch = false;
            try { using (new LasStreamWriter(sourcePath)) { } }
            catch (ArgumentException) { rejectedStream = true; }
            try { using (new LasBatchStreamWriter(sourcePath)) { } }
            catch (ArgumentException) { rejectedBatch = true; }
            Check(rejectedStream && rejectedBatch,
                "writers accepted a non-LAS destination");
            SameBytes(source, File.ReadAllBytes(sourcePath),
                "non-LAS destination was modified");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "rejected destination created a stage");
        }

        private static void TestConversionCancellation(bool batch)
        {
            string folder = Folder(batch ? "cancel-batch" : "cancel-stream");
            string finalPath = PathIn(folder, "old.las");
            byte[] previous = { 3, 1, 4, 1, 5 };
            File.WriteAllBytes(finalPath, previous);
            bool cancel = false;
            bool caught = false;

            if (batch)
            {
                using (LasBatchStreamWriter writer = new LasBatchStreamWriter(finalPath))
                {
                    writer.IsCancellationRequested = delegate { return cancel; };
                    writer.OnProgress = delegate(int current, int total) { cancel = true; };
                    writer.WritePoints(ManyPoints());
                    try { writer.Complete(); }
                    catch (OperationCanceledException) { caught = true; }
                }
            }
            else
            {
                using (LasStreamWriter writer = new LasStreamWriter(finalPath))
                {
                    writer.IsCancellationRequested = delegate { return cancel; };
                    writer.OnProgress = delegate(int current, int total) { cancel = true; };
                    writer.WritePoints(ManyPoints());
                    try { writer.Complete(); }
                    catch (OperationCanceledException) { caught = true; }
                }
            }

            Check(caught, "conversion cancellation was not reported");
            SameBytes(previous, File.ReadAllBytes(finalPath),
                "conversion cancellation damaged previous final");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "conversion cancellation left raw or partial staging data");
        }

        private static void TestConversionProgressFailure(bool batch)
        {
            string folder = Folder(batch ? "progress-failure-batch" : "progress-failure-stream");
            string finalPath = PathIn(folder, "old.las");
            byte[] previous = { 8, 6, 7, 5, 3, 0, 9 };
            File.WriteAllBytes(finalPath, previous);
            bool caught = false;

            if (batch)
            {
                using (LasBatchStreamWriter writer = new LasBatchStreamWriter(finalPath))
                {
                    writer.OnProgress = delegate(int current, int total) {
                        throw new ApplicationException("progress sentinel");
                    };
                    writer.WritePoints(TinyPoints());
                    try { writer.Complete(); }
                    catch (ApplicationException ex) { caught = ex.Message == "progress sentinel"; }
                }
            }
            else
            {
                using (LasStreamWriter writer = new LasStreamWriter(finalPath))
                {
                    writer.OnProgress = delegate(int current, int total) {
                        throw new ApplicationException("progress sentinel");
                    };
                    writer.WritePoints(TinyPoints());
                    try { writer.Complete(); }
                    catch (ApplicationException ex) { caught = ex.Message == "progress sentinel"; }
                }
            }

            Check(caught, "progress failure was swallowed");
            SameBytes(previous, File.ReadAllBytes(finalPath),
                "progress failure damaged previous final");
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "progress failure left raw or partial staging data");
        }

        private static void TestEmptyComplete(bool batch)
        {
            string folder = Folder(batch ? "empty-batch" : "empty-stream");
            string finalPath = PathIn(folder, "old.las");
            byte[] previous = { 2, 7, 1, 8 };
            File.WriteAllBytes(finalPath, previous);
            PreparedLasFile prepared;
            if (batch)
            {
                using (LasBatchStreamWriter writer = new LasBatchStreamWriter(finalPath))
                    prepared = writer.Complete();
            }
            else
            {
                using (LasStreamWriter writer = new LasStreamWriter(finalPath))
                    prepared = writer.Complete();
            }
            using (prepared)
            {
                SameBytes(previous, File.ReadAllBytes(finalPath),
                    "empty Complete published before Publish");
                byte[] stage = File.ReadAllBytes(prepared.StagePath);
                CheckLas(stage, 0);
                CheckBounds(stage, 0, 0, 0, 0, 0, 0);
                prepared.Publish();
            }
            byte[] finalBytes = File.ReadAllBytes(finalPath);
            CheckLas(finalBytes, 0);
            CheckBounds(finalBytes, 0, 0, 0, 0, 0, 0);
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "empty export left a stage");
        }

        private static void CheckBounds(byte[] data, double xMin, double xMax,
            double yMin, double yMax, double zMin, double zMax)
        {
            Check(BitConverter.ToDouble(data, 155) == xMin &&
                BitConverter.ToDouble(data, 163) == yMin &&
                BitConverter.ToDouble(data, 171) == zMin, "LAS offsets changed");
            Check(BitConverter.ToDouble(data, 179) == xMax &&
                BitConverter.ToDouble(data, 187) == xMin &&
                BitConverter.ToDouble(data, 195) == yMax &&
                BitConverter.ToDouble(data, 203) == yMin &&
                BitConverter.ToDouble(data, 211) == zMax &&
                BitConverter.ToDouble(data, 219) == zMin, "LAS extrema are wrong");
        }

        private static void CheckRecordsWithinHeader(byte[] data, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int record = 227 + i * 28;
                for (int axis = 0; axis < 3; axis++)
                {
                    double scale = BitConverter.ToDouble(data, 131 + axis * 8);
                    double offset = BitConverter.ToDouble(data, 155 + axis * 8);
                    double max = BitConverter.ToDouble(data, 179 + axis * 16);
                    double min = BitConverter.ToDouble(data, 187 + axis * 16);
                    double decoded = offset + BitConverter.ToInt32(data,
                        record + axis * 4) * scale;
                    Check(decoded >= min && decoded <= max,
                        "decoded LAS point lies outside header bounds");
                }
            }
        }

        private static void CheckDecodedCoordinates(byte[] data, List<Vector4D> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                double[] expected = { points[i].X, points[i].Y, points[i].Z };
                for (int axis = 0; axis < 3; axis++)
                {
                    double scale = BitConverter.ToDouble(data, 131 + axis * 8);
                    double offset = BitConverter.ToDouble(data, 155 + axis * 8);
                    int encoded = BitConverter.ToInt32(data, 227 + i * 28 + axis * 4);
                    double decoded = offset + encoded * scale;
                    Check(Math.Abs(decoded - expected[axis]) <= scale / 2 + 1e-8,
                        "decoded LAS point exceeds coordinate quantization tolerance");
                }
            }
        }

        private static void TestExtrema(string name, List<Vector4D> points,
            double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
        {
            string folder = Folder(name);
            string streamPath = PathIn(folder, "stream.las");
            string batchPath = PathIn(folder, "batch.las");
            using (PreparedLasFile stream = PrepareStream(streamPath, points)) stream.Publish();
            using (PreparedLasFile batch = PrepareBatch(batchPath, points)) batch.Publish();
            byte[] streamBytes = File.ReadAllBytes(streamPath);
            byte[] batchBytes = File.ReadAllBytes(batchPath);
            CheckLas(streamBytes, points.Count);
            CheckLas(batchBytes, points.Count);
            CheckBounds(streamBytes, xMin, xMax, yMin, yMax, zMin, zMax);
            CheckBounds(batchBytes, xMin, xMax, yMin, yMax, zMin, zMax);
            CheckRecordsWithinHeader(streamBytes, points.Count);
            CheckRecordsWithinHeader(batchBytes, points.Count);
            CheckDecodedCoordinates(streamBytes, points);
            CheckDecodedCoordinates(batchBytes, points);
            SameBytes(streamBytes, batchBytes, name + " writer parity");
        }

        private static void TestWideCoordinateSpans()
        {
            // A fixed 0.0001 scale overflows LAS's signed 32-bit X and Z
            // coordinates for these spans. Y must retain the old precision.
            List<Vector4D> points = new List<Vector4D> {
                new Vector4D(-100000, 500000, -50, 1),
                new Vector4D(200000, 500001, 249950, 2),
                new Vector4D(123.4567, 500000.00006, 123.4567, 3)
            };
            string folder = Folder("wide-coordinate-spans");
            string streamPath = PathIn(folder, "stream.las");
            string batchPath = PathIn(folder, "batch.las");
            using (PreparedLasFile stream = PrepareStream(streamPath, points)) stream.Publish();
            using (PreparedLasFile batch = PrepareBatch(batchPath, points)) batch.Publish();
            byte[] streamBytes = File.ReadAllBytes(streamPath);
            byte[] batchBytes = File.ReadAllBytes(batchPath);
            Check(streamBytes.Length == 227 + points.Count * 28 &&
                streamBytes[24] == 1 && streamBytes[25] == 2 &&
                streamBytes[104] == 1 &&
                BitConverter.ToUInt32(streamBytes, 107) == points.Count,
                "wide output must remain LAS 1.2 point format 1");
            Check(BitConverter.ToDouble(streamBytes, 131) == 0.001 &&
                BitConverter.ToDouble(streamBytes, 139) == 0.0001 &&
                BitConverter.ToDouble(streamBytes, 147) == 0.001,
                "only overflowing axes should receive a larger scale");
            CheckBounds(streamBytes, -100000, 200000, 500000, 500001,
                -50, 249950);
            CheckRecordsWithinHeader(streamBytes, points.Count);
            CheckDecodedCoordinates(streamBytes, points);
            SameBytes(streamBytes, batchBytes, "wide writer parity");
        }

        private static void TestPublishFailureAndRetry()
        {
            string folder = Folder("publish-failure");
            string finalPath = PathIn(folder, "old.las");
            byte[] previous = { 4, 2, 4, 2 };
            File.WriteAllBytes(finalPath, previous);
            using (PreparedLasFile prepared = PrepareStream(finalPath, TinyPoints()))
            {
                Check(File.Exists(prepared.StagePath), "stage missing before failed publish");
                bool failed = false;
                using (FileStream held = new FileStream(finalPath, FileMode.Open, FileAccess.Read,
                    FileShare.None))
                {
                    try { prepared.Publish(); }
                    catch (IOException) { failed = true; }
                }
                Check(failed, "locked target was overwritten");
                SameBytes(previous, File.ReadAllBytes(finalPath),
                    "failed replacement damaged previous final");
                Check(File.Exists(prepared.StagePath), "failed publish lost retry stage");
                prepared.Publish();
                Check(prepared.IsPublished, "retry did not publish");
            }
            CheckLas(File.ReadAllBytes(finalPath), 2);
        }

        private static void TestNormalizedLidarWeightExport()
        {
            string folder = Folder("normalized-lidar-weight");
            List<Vector4D> points = new List<Vector4D> {
                new Vector4D(-10, 20, 30, 0),
                new Vector4D(-9, 20, 30, 127.0 / 255.0),
                new Vector4D(-8, 20, 30, 128.0 / 255.0),
                new Vector4D(-7, 20, 30, 1)
            };
            LidarIntensity.ExpandInPlace(points);
            string streamPath = PathIn(folder, "stream.las");
            string batchPath = PathIn(folder, "batch.las");
            using (PreparedLasFile stream = PrepareStream(streamPath, points))
            using (PreparedLasFile batch = PrepareBatch(batchPath, points))
            {
                stream.Publish();
                batch.Publish();
            }
            byte[] streamBytes = File.ReadAllBytes(streamPath);
            byte[] batchBytes = File.ReadAllBytes(batchPath);
            CheckLas(streamBytes, points.Count);
            SameBytes(streamBytes, batchBytes, "normalized weight writer parity");
            ushort[] expected = { 0, 32639, 32896, 65535 };
            for (int i = 0; i < expected.Length; i++)
                Check(BitConverter.ToUInt16(streamBytes, 227 + i * 28 + 12) == expected[i],
                    "LAS intensity lost an imported LiDAR byte weight");
        }

        private static void TestTargetConflict()
        {
            string folder = Folder("conflict");
            string finalPath = PathIn(folder, "old.las");
            File.WriteAllBytes(finalPath, new byte[] { 1, 2, 3 });
            using (PreparedLasFile prepared = PrepareBatch(finalPath, TinyPoints()))
            {
                byte[] changed = { 9, 9, 9, 9 };
                File.WriteAllBytes(finalPath, changed);
                bool rejected = false;
                try { prepared.Publish(); }
                catch (IOException) { rejected = true; }
                Check(rejected, "external target change was overwritten");
                SameBytes(changed, File.ReadAllBytes(finalPath),
                    "conflict damaged externally changed target");
                Check(File.Exists(prepared.StagePath), "conflict lost recovery stage");
            }
            Check(Directory.GetFiles(folder, "*.tmp").Length == 0,
                "conflict cleanup left staging data");
        }

        public static int Main()
        {
            root = Path.Combine(Path.GetTempPath(),
                "robolas-las-finalization-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(root);
            Console.WriteLine("ARTIFACTS " + root);
            TestNormalParity();
            TestRejectNonLasDestination();
            TestDisposeWithoutComplete();
            TestConversionCancellation(false);
            TestConversionCancellation(true);
            TestConversionProgressFailure(false);
            TestConversionProgressFailure(true);
            TestEmptyComplete(false);
            TestEmptyComplete(true);
            TestExtrema("single", new List<Vector4D> { new Vector4D(7, 8, 9, 42) },
                7, 7, 8, 8, 9, 9);
            TestExtrema("descending", new List<Vector4D> {
                    new Vector4D(3, 30, 300, 1),
                    new Vector4D(2, 20, 200, 2),
                    new Vector4D(1, 10, 100, 3) },
                1, 3, 10, 30, 100, 300);
            // The header must bound the decoded records, not unrounded input.
            TestExtrema("rounded-positive", new List<Vector4D> {
                    new Vector4D(0, 0, 0, 1),
                    new Vector4D(0.00006, 0.00006, 0.00006, 2) },
                0, 0.0001, 0, 0.0001, 0, 0.0001);
            TestExtrema("rounded-negative", new List<Vector4D> {
                    new Vector4D(-0.00006, -0.00006, -0.00006, 1),
                    new Vector4D(0, 0, 0, 2) },
                -0.00006, -0.00006 + 0.0001,
                -0.00006, -0.00006 + 0.0001,
                -0.00006, -0.00006 + 0.0001);
            TestExtrema("projected-offset", new List<Vector4D> {
                    new Vector4D(2046828.25, 5581263.5, -50.125, 1),
                    new Vector4D(2046829.25, 5581261.5, -48.125, 2),
                    new Vector4D(2046827.25, 5581264.5, -51.125, 3) },
                2046827.25, 2046829.25,
                5581261.5, 5581264.5,
                -51.125, -48.125);
            TestWideCoordinateSpans();
            TestNormalizedLidarWeightExport();
            TestPublishFailureAndRetry();
            TestTargetConflict();
            Console.WriteLine("LAS finalization: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
