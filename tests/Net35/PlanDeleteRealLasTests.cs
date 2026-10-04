using System;
using System.IO;
using System.Text;
using LAS_TERRAIN.UseCases;

namespace LAS_TERRAIN.Tests
{
    public static class PlanDeleteRealLasTests
    {
        private static int checks;
        private static void Check(bool yes, string label)
        {
            checks++;
            if (!yes) throw new Exception(label);
        }
        private static void SameBytes(string path, byte[] expected, string label)
        {
            byte[] actual = File.ReadAllBytes(path);
            Check(actual.Length == expected.Length, label + " length");
            for (int i = 0; i < expected.Length; i++)
                Check(actual[i] == expected[i], label + " byte " + i);
        }
        private static void Run()
        { new PlanDeletePointsUseCase().Run(new SectionEnv()); }

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

        public static int Main()
        {
            string dir = Path.Combine(Path.GetTempPath(),
                "robolas-plan-real-las-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(dir);
            string las = Path.Combine(dir, "filtered.las");
            string ldr = Path.Combine(dir, "source.ldr");
            byte[] oldLas = Encoding.ASCII.GetBytes("previous Plan output");
            byte[] oldLdr = Encoding.ASCII.GetBytes("unchanged LDR");
            try
            {
                File.WriteAllBytes(las, oldLas);
                File.WriteAllBytes(ldr, oldLdr);
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = ldr;
                CrsDeleteFixture.Buffers[0].fullpath = ldr;
                PlanDeleteFixture.AddIndexer(1, 2, 2);
                Run();
                SameBytes(ldr, oldLdr, "rejected LDR destination");
                SameBytes(las, oldLas, "rejected LDR keeps previous LAS");
                Check(PlanDeleteFixture.ClearCalls == 0 &&
                    PlanDeleteFixture.OverlayClearCalls == 0,
                    "rejected LDR keeps polygons and overlay");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "rejected LDR creates no stage");

                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(2, 2, 2);
                Run();
                SameBytes(las, oldLas, "no-match destination");
                Check(PlanDeleteFixture.ClearCalls == 0, "no-match polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "no-match creates no stage");

                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(1, 2, 2, 2);
                var planWeights = CrsDeleteFixture.Buffers[0].indexers[0].weights.Values;
                planWeights[1] = 0;
                planWeights[2] = 127;
                planWeights[3] = 255;
                Run();
                byte[] bytes = File.ReadAllBytes(las);
                Check(Encoding.ASCII.GetString(bytes, 0, 4) == "LASF", "LAS signature");
                Check(bytes[24] == 1 && bytes[25] == 2, "LAS 1.2");
                Check(bytes[104] == 1, "Point Format 1");
                Check(BitConverter.ToUInt16(bytes, 105) == 28, "record size");
                Check(BitConverter.ToUInt32(bytes, 107) == 3, "survivor count");
                Check(bytes.Length == 227 + 3 * 28, "file size");
                Check(BitConverter.ToInt32(bytes, 227 + 8) == 0, "first Z");
                Check(BitConverter.ToInt32(bytes, 255 + 8) == 10000, "second Z");
                Check(BitConverter.ToInt32(bytes, 283 + 8) == 20000, "third Z");
                Check(BitConverter.ToUInt32(bytes, 111) == 3,
                    "first-return header count");
                Check(bytes[227 + 14] == 9 && bytes[255 + 14] == 9 &&
                    bytes[283 + 14] == 9, "return 1 of 1");
                Check(BitConverter.ToUInt16(bytes, 227 + 12) == 0 &&
                    BitConverter.ToUInt16(bytes, 255 + 12) == 127 * 257 &&
                    BitConverter.ToUInt16(bytes, 283 + 12) == 65535,
                    "source byte weights expand to LAS intensity");
                Check(PlanDeleteFixture.ClearCalls == 1, "real writer clears polygons");
                Check(PlanDeleteFixture.OverlayClearCalls == 1,
                    "real writer clears overlay");
                SameBytes(ldr, oldLdr, "successful export LDR");

                // The native LDR indexer stores local floats with a separate
                // scale and position. Check all axes, including a negative scale,
                // through the production delete command and the actual LAS writer.
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(0, 1000, 2000);
                var indexer = CrsDeleteFixture.Buffers[0].indexers[0];
                indexer.points.Values[0] = new Topomatic.Cad.Foundation.Vector3F(0, 1, 2);
                indexer.points.Values[1] = new Topomatic.Cad.Foundation.Vector3F(1000, 2, 3);
                indexer.points.Values[2] = new Topomatic.Cad.Foundation.Vector3F(2000, 3, 4);
                indexer.scale = new Topomatic.Cad.Foundation.Vector3D(0.001, -0.002, 0.1);
                indexer.position = new Topomatic.Cad.Foundation.Vector3D(1, 20, 30);
                Run();
                bytes = File.ReadAllBytes(las);
                Check(BitConverter.ToUInt32(bytes, 107) == 2,
                    "transformed source survivor count");
                Near(DecodedCoordinate(bytes, 0, 0), 2, "first world X");
                Near(DecodedCoordinate(bytes, 0, 1), 19.996, "first world Y");
                Near(DecodedCoordinate(bytes, 0, 2), 30.3, "first world Z");
                Near(DecodedCoordinate(bytes, 1, 0), 3, "second world X");
                Near(DecodedCoordinate(bytes, 1, 1), 19.994, "second world Y");
                Near(DecodedCoordinate(bytes, 1, 2), 30.4, "second world Z");
                Check(PlanDeleteFixture.ClearCalls == 1,
                    "transformed source clears polygons after LAS publication");
                SameBytes(ldr, oldLdr, "transformed export LDR");

                // A later malformed indexer must discard an already written
                // stage and leave the previous destination untouched.
                File.WriteAllBytes(las, oldLas);
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(1, 2, 2, 2);
                PlanDeleteFixture.AddIndexer(2, 2);
                CrsDeleteFixture.Buffers[0].indexers[1].weights.Values = new byte[1];
                Run();
                SameBytes(las, oldLas, "incomplete weights destination");
                Check(PlanDeleteFixture.ClearCalls == 0 &&
                    PlanDeleteFixture.OverlayClearCalls == 0,
                    "incomplete weights keep polygons and overlay");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "incomplete weights clean staged LAS");
                SameBytes(ldr, oldLdr, "incomplete weights LDR");

                File.WriteAllBytes(las, oldLas);
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(1, 2, 2, 2, 2, 2);
                PlanDeleteFixture.CancelExportAt = 5;
                Run();
                SameBytes(las, oldLas, "canceled export destination");
                Check(PlanDeleteFixture.ClearCalls == 0, "canceled polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "canceled stage cleaned");

                File.WriteAllBytes(las, oldLas);
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(1, 2, 2, 2);
                PlanDeleteFixture.FailExportAt = 2;
                Run();
                SameBytes(las, oldLas, "failed export destination");
                Check(PlanDeleteFixture.ClearCalls == 0, "failed polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "failed stage cleaned");

                File.WriteAllBytes(las, oldLas);
                PlanDeleteFixture.Reset();
                CrsDeleteFixture.OutputPath = las;
                PlanDeleteFixture.AddIndexer(1, 2, 2);
                CrsDeleteFixture.OnProgressEnd = delegate {
                    Topomatic.ApplicationPlatform.ApplicationHost.Current.ActiveDocument =
                        new object(); };
                Run();
                SameBytes(las, oldLas, "context switch after prepare destination");
                Check(PlanDeleteFixture.ClearCalls == 0,
                    "context switch after prepare keeps polygons");
                Check(Directory.GetFiles(dir, "*.tmp").Length == 0,
                    "context switch after prepare cleans stage");
                SameBytes(ldr, oldLdr, "failed export LDR");
                Console.WriteLine("PlanDeleteRealLasTests: " + checks + " checks passed");
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
