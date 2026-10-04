using System;
using System.Collections.Generic;
using LAS_TERRAIN.Service;

namespace LAS_TERRAIN.Tests
{
    internal static class SectionStationPlannerTests
    {
        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
        }

        private static void Reject(double length, double step)
        {
            try { SectionStationPlanner.Plan(length, step); }
            catch (ArgumentOutOfRangeException) { return; }
            throw new Exception("Expected invalid station request");
        }

        public static int Main()
        {
            try
            {
                List<double> normal = SectionStationPlanner.Plan(2.5, 1.0);
                Check(normal.Count == 3 && normal[0] == 0.0 && normal[1] == 1.0 && normal[2] == 2.0,
                    "ordinary stations");
                List<double> exact = SectionStationPlanner.Plan(2.0, 1.0);
                Check(exact.Count == 3 && exact[2] == 2.0, "endpoint inclusion");
                List<double> emptyLength = SectionStationPlanner.Plan(0.0, 1.0);
                Check(emptyLength.Count == 1 && emptyLength[0] == 0.0, "zero-length alignment");
                Reject(10, 0);
                Reject(10, -1);
                Reject(10, double.NaN);
                Reject(10, double.PositiveInfinity);
                Reject(double.NaN, 1);
                Reject(double.PositiveInfinity, 1);
                Reject(-1, 1);
                Reject(100000, 1);
                Reject(1, 1e-300);
                Console.WriteLine("PASS section station planner contracts");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL section station planner: " + ex);
                return 1;
            }
        }
    }
}
