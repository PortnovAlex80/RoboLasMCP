using System;
using System.IO;
using System.Text;
using LAS_TERRAIN.UseCases;

namespace LAS_TERRAIN.Tests
{
    public static class CrsDeleteRealLasTests
    {
        private static int checks;
        private static void Check(bool yes, string label)
        {
            checks++;
            if (!yes) throw new Exception(label);
        }

        private static void Run()
        { new CrsDeletePointsUseCase().Run(new SectionEnv()); }

        private static double DecodedCoordinate(byte[] las, int record, int axis)
        {
            int value = BitConverter.ToInt32(las, 227 + record * 28 + axis * 4);
            double scale = BitConverter.ToDouble(las, 131 + axis * 8);
            double offset = BitConverter.ToDouble(las, 155 + axis * 8);
            return offset + value * scale;
        }

        private static void Near(double actual, double expected, string label)
        {
            Check(Math.Abs(actual - expected) <= 0.00005, label);
        }

        private static void AssertOldFinal(string path, byte[] oldBytes)
        {
            byte[] actual = File.ReadAllBytes(path);
            Check(actual.Length == oldBytes.Length, "previous LAS size");
            for (int i = 0; i < oldBytes.Length; i++)
                Check(actual[i] == oldBytes[i], "previous LAS byte " + i);
        }

        private static void AssertUnchanged(string path, byte[] expected, string label)
        {
            byte[] actual = File.ReadAllBytes(path);
            Check(actual.Length == expected.Length, label + " size");
            for (int i = 0; i < expected.Length; i++)
                Check(actual[i] == expected[i], label + " byte " + i);
        }

        public static int Main()
        {
            string dir = Path.Combine(Path.GetTempPath(),
                "robolas-crs-real-las-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(dir);
            string las = Path.Combine(dir, "filtered.las");
            string ldr = Path.Combine(dir, "source.ldr");
            byte[] oldLas = Encoding.ASCII.GetBytes("previous destination");
            byte[] oldLdr = Encoding.ASCII.GetBytes("source descriptor");
            try
            {
                File.WriteAllBytes(ldr, oldLdr);
                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = ldr;
                CrsDeleteFixture.Buffers[0].fullpath = ldr;
                CrsDeleteFixture.AddIndexer(2, 1, 3, 4);
                Run();
                AssertUnchanged(ldr, oldLdr, "rejected CRS LDR destination");
                AssertUnchanged(las, oldLas, "rejected CRS LDR keeps LAS");
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "rejected CRS LDR keeps polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "rejected CRS LDR creates no stage");

                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(2, 1, 3, 4);
                var crsWeights = CrsDeleteFixture.Buffers[0].indexers[0].weights.Values;
                crsWeights[0] = 255;
                crsWeights[2] = 127;
                crsWeights[3] = 0;
                Run();
                byte[] bytes = File.ReadAllBytes(las);
                Check(Encoding.ASCII.GetString(bytes, 0, 4) == "LASF", "signature");
                Check(bytes[24] == 1 && bytes[25] == 2, "LAS 1.2");
                Check(bytes[104] == 1, "Point Format 1");
                Check(BitConverter.ToUInt16(bytes, 105) == 28, "record length");
                Check(BitConverter.ToUInt32(bytes, 107) == 3, "record count");
                Check(bytes.Length == 227 + 3 * 28, "file length");
                Check(BitConverter.ToInt32(bytes, 227 + 8) == 0, "first Z");
                Check(BitConverter.ToInt32(bytes, 255 + 8) == 10000, "second Z");
                Check(BitConverter.ToInt32(bytes, 283 + 8) == 20000, "third Z");
                Check(BitConverter.ToUInt32(bytes, 111) == 3,
                    "first-return header count");
                Check(bytes[227 + 14] == 9 && bytes[255 + 14] == 9 &&
                    bytes[283 + 14] == 9, "return 1 of 1");
                Check(BitConverter.ToUInt16(bytes, 227 + 12) == 65535 &&
                    BitConverter.ToUInt16(bytes, 255 + 12) == 127 * 257 &&
                    BitConverter.ToUInt16(bytes, 283 + 12) == 0,
                    "source byte weights expand to LAS intensity");
                Check(CrsDeleteFixture.ClearCalls == 1, "polygon clear after real LAS");
                AssertUnchanged(ldr, oldLdr, "source descriptor");

                // CRS geometry must use world coordinates, and the exported LAS
                // must preserve them after per-axis LDR scale/position decoding.
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(3, 1, 5, 7);
                var indexer = CrsDeleteFixture.Buffers[0].indexers[0];
                indexer.scale = new Topomatic.Cad.Foundation.Vector3D(0.01, -0.002, 0.5);
                indexer.position = new Topomatic.Cad.Foundation.Vector3D(0.49, 0.004, 0.5);
                for (int i = 0; i < indexer.points.Values.Length; i++)
                    indexer.points.Values[i] = new Topomatic.Cad.Foundation.Vector3F(
                        1, i + 1, indexer.points.Values[i].Z);
                Run();
                bytes = File.ReadAllBytes(las);
                Check(BitConverter.ToUInt32(bytes, 107) == 3,
                    "transformed CRS survivor count");
                Near(DecodedCoordinate(bytes, 0, 0), 0.5, "first CRS world X");
                Near(DecodedCoordinate(bytes, 0, 1), 0.002, "first CRS world Y");
                Near(DecodedCoordinate(bytes, 0, 2), 2, "first CRS world Z");
                Near(DecodedCoordinate(bytes, 1, 0), 0.5, "second CRS world X");
                Near(DecodedCoordinate(bytes, 1, 1), -0.002, "second CRS world Y");
                Near(DecodedCoordinate(bytes, 1, 2), 3, "second CRS world Z");
                Near(DecodedCoordinate(bytes, 2, 0), 0.5, "third CRS world X");
                Near(DecodedCoordinate(bytes, 2, 1), -0.004, "third CRS world Y");
                Near(DecodedCoordinate(bytes, 2, 2), 4, "third CRS world Z");
                Check(CrsDeleteFixture.ClearCalls == 1,
                    "transformed CRS clears polygon after LAS publication");
                AssertUnchanged(ldr, oldLdr, "transformed CRS source descriptor");

                // An invalid later indexer must not publish a partially
                // written stage or clear the selected polygons.
                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(1, 2, 2, 2);
                CrsDeleteFixture.AddIndexer(2, 2);
                CrsDeleteFixture.Buffers[0].indexers[1].weights.Values = new byte[1];
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "incomplete weights keep CRS polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "incomplete weights clean staged LAS");
                AssertUnchanged(ldr, oldLdr, "incomplete weights source descriptor");

                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(2, 3);
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "no match preserves polygons with real writer");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "no match cleans staging file");

                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(2, 2, 2, 2);
                CrsDeleteFixture.CancelAtVisit = 2;
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "cancel keeps polygons with real writer");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "cancel cleans staging file");

                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(2, 2, 2, 2, 2, 2);
                CrsDeleteFixture.CancelAtVisit = 4;
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "cancel after first batch keeps polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "cancel after first batch cleans staging");

                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(2, 2, 2, 2);
                CrsDeleteFixture.FailAtVisit = 2;
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "scan fault keeps polygons with real writer");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "scan fault cleans staging file");

                File.WriteAllBytes(las, oldLas);
                CrsDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                CrsDeleteFixture.AddIndexer(1, 2, 2);
                CrsDeleteFixture.OnProgressEnd = delegate {
                    Topomatic.ApplicationPlatform.ApplicationHost.Current.ActiveDocument =
                        new object(); };
                Run();
                AssertOldFinal(las, oldLas);
                Check(CrsDeleteFixture.ClearCalls == 0,
                    "context switch after prepare keeps polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "context switch after prepare cleans stage");
                AssertUnchanged(ldr, oldLdr, "fault keeps descriptor");
                Console.WriteLine("CrsDeleteRealLasTests: " + checks + " checks passed");
                return 0;
            }
            finally
            {
                if (File.Exists(las)) File.Delete(las);
                if (File.Exists(ldr)) File.Delete(ldr);
                if (File.Exists(las + ".lock")) File.Delete(las + ".lock");
                foreach (string stage in Directory.GetFiles(dir, "*.tmp"))
                    File.Delete(stage);
                Directory.Delete(dir, false);
            }
        }
    }
}
