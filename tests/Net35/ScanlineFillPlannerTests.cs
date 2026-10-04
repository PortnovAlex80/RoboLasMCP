using System;
using LAS_TERRAIN.Domain.Service;

namespace LAS_TERRAIN.Tests
{
    internal static class ScanlineFillPlannerTests
    {
        private static int _checks;

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }

        public static int Main()
        {
            try
            {
                double step;
                Check(!ScanlineFillPlanner.TryPlan(5.0, 5.0, 0.5, out step),
                    "horizontal Plan polygon must not start a scanline loop");
                Check(!ScanlineFillPlanner.TryPlan(5.0, 5.0, 0.1, out step),
                    "horizontal CRS polygon must not start a scanline loop");
                Check(!ScanlineFillPlanner.TryPlan(5.0, 5.0009, 0.5, out step),
                    "near-zero height must not start a scanline loop");
                Check(!ScanlineFillPlanner.TryPlan(1e16, 1e16 + 2.0, 0.5, out step),
                    "non-advancing floating-point row must not start a scanline loop");

                Check(ScanlineFillPlanner.TryPlan(0.0, 10.0, 0.5, out step) &&
                    step == 0.5, "ordinary Plan row spacing changed");
                Check(ScanlineFillPlanner.TryPlan(0.0, 10.0, 0.1, out step) &&
                    Math.Abs(step - 0.1) < 1e-12, "ordinary CRS row spacing changed");
                Check(ScanlineFillPlanner.TryPlan(0.0, 0.001, 0.5, out step) &&
                    step > 0, "renderable thin polygon was rejected");

                Console.WriteLine("PASS scanline fill planner: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL scanline fill planner: " + ex);
                return 1;
            }
        }
    }
}
