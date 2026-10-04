using System;
using System.Diagnostics;
using LAS_TERRAIN.UseCases;

namespace LAS_TERRAIN.Tests
{
    // Optional same-data old/new command probe. Its writer stub performs no I/O.
    public static class PlanDeleteBenchmark
    {
        public static int Main()
        {
            PlanDeleteFixture.Reset();
            CrsDeleteFixture.BatchSize = 8192;
            var x = new float[250000];
            int expectedKept = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i % 7 == 0 ? 1 : 2;
                if (x[i] != 1) expectedKept++;
            }
            PlanDeleteFixture.AddIndexer(x);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var process = Process.GetCurrentProcess();
            process.Refresh();
            long before = process.PrivateMemorySize64;
            var watch = Stopwatch.StartNew();
            new PlanDeletePointsUseCase().Run(new SectionEnv());
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
                " preflight_visits=" + PlanDeleteFixture.PreflightVisits +
                " kept=" + expectedKept);
            return 0;
        }
    }
}
