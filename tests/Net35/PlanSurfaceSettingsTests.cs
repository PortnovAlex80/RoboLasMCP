using System;
using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Models;

namespace LAS_TERRAIN
{
    internal static class SettingsDefaults
    {
        internal const double SplitMergeTolerance = 0.1;
    }
}

namespace LAS_TERRAIN.Tests
{
    internal static class PlanSurfaceSettingsTests
    {
        private static int _checks;

        private static void Check(bool condition, string name)
        {
            _checks++;
            if (!condition) throw new Exception(name);
        }

        public static int Main()
        {
            double oldGrid = RuntimeConfig.GridStep;
            int oldDegree = RuntimeConfig.PolynomialDegree;
            double oldRegularization = RuntimeConfig.PolynomialRegularization;
            double oldPolynomialGrid = RuntimeConfig.PolynomialGridStep;
            try
            {
                RuntimeConfig.GridStep = 0.5;
                RuntimeConfig.PolynomialDegree = 2;
                RuntimeConfig.PolynomialRegularization = 0.01;
                RuntimeConfig.PolynomialGridStep = 1.5;
                PlanSurfaceSettings first = RuntimeConfig.CapturePlanSurfaceSettings();

                RuntimeConfig.GridStep = 2.0;
                RuntimeConfig.PolynomialDegree = 3;
                RuntimeConfig.PolynomialRegularization = 0.25;
                RuntimeConfig.PolynomialGridStep = 4.0;
                PlanSurfaceSettings second = RuntimeConfig.CapturePlanSurfaceSettings();

                Check(first.GridStep == 0.5, "grid step remains captured");
                Check(first.PolynomialDegree == 2, "degree remains captured");
                Check(first.PolynomialRegularization == 0.01,
                    "regularization remains captured");
                Check(first.PolynomialGridStep == 1.5,
                    "polynomial grid step remains captured");
                Check(second.GridStep == 2.0, "next run gets new grid step");
                Check(second.PolynomialDegree == 3, "next run gets new degree");
                Check(second.PolynomialRegularization == 0.25,
                    "next run gets new regularization");
                Check(second.PolynomialGridStep == 4.0,
                    "next run gets new polynomial grid step");
            }
            finally
            {
                RuntimeConfig.GridStep = oldGrid;
                RuntimeConfig.PolynomialDegree = oldDegree;
                RuntimeConfig.PolynomialRegularization = oldRegularization;
                RuntimeConfig.PolynomialGridStep = oldPolynomialGrid;
            }
            Console.WriteLine("Plan surface settings: " + _checks + " checks passed.");
            return 0;
        }
    }
}
