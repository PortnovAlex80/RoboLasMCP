using System;
using System.Diagnostics;
using LAS_TERRAIN.UseCases;

namespace LAS_TERRAIN.Tests
{
    // Optional same-data memory/time probe. Run old and new command sources
    // in separate processes with the same SDK stubs and fixture settings.
    public static class CrsDeleteBenchmark
    {
        public static int Main()
        {
            CrsDeleteFixture.Reset();
            CrsDeleteFixture.BatchSize = 8192;
            var heights = new float[250000];
            int expectedKept = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = i % 7 == 0 ? 1 : 2;
                if (heights[i] != 1) expectedKept++;
            }
            CrsDeleteFixture.AddIndexer(heights);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var process = Process.GetCurrentProcess();
            process.Refresh();
            long before = process.PrivateMemorySize64;
            var watch = Stopwatch.StartNew();
            new CrsDeletePointsUseCase().Run(new SectionEnv());
            watch.Stop();
            process.Refresh();
            if (CrsDeleteFixture.Published.Count != expectedKept)
                throw new Exception("benchmark output count differs");
            Console.WriteLine("elapsed_ms=" + watch.ElapsedMilliseconds +
                " private_delta_mb=" +
                ((process.PrivateMemorySize64 - before) / 1048576.0).ToString("F2") +
                " peak_working_mb=" +
                (process.PeakWorkingSet64 / 1048576.0).ToString("F2") +
                " max_batch=" + CrsDeleteFixture.MaxBatch +
                " writes=" + CrsDeleteFixture.WriteCalls +
                " kept=" + expectedKept);
            return 0;
        }
    }
}
