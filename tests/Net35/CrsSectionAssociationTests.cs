using System;
using LAS_TERRAIN.Domain.Service;

namespace LAS_TERRAIN.Tests
{
    internal static class CrsSectionAssociationTests
    {
        private static void Check(bool actual, bool expected, string name)
        {
            if (actual != expected) throw new Exception(name);
        }

        public static int Main()
        {
            try
            {
                double[] stations = { 0.0, 5.0, 10.0 };
                Func<int, double> at = delegate(int i) { return stations[i]; };
                Check(CrsSectionAssociation.IsCurrent(1, 5.0, stations.Length, at), true, "same section");
                Check(CrsSectionAssociation.IsCurrent(1, 5.0 + 1e-7, stations.Length, at), true, "JSON rounding");
                Check(CrsSectionAssociation.IsCurrent(1, 5.1, stations.Length, at), false, "changed station");
                Check(CrsSectionAssociation.IsCurrent(2, 5.0, stations.Length, at), false, "reordered section");
                Check(CrsSectionAssociation.IsCurrent(-1, 0.0, stations.Length, at), false, "negative index");
                Check(CrsSectionAssociation.IsCurrent(3, 10.0, stations.Length, at), false, "deleted section");
                Check(CrsSectionAssociation.IsCurrent(1, double.NaN, stations.Length, at), false, "invalid saved station");
                stations[1] = double.PositiveInfinity;
                Check(CrsSectionAssociation.IsCurrent(1, 5.0, stations.Length, at), false, "invalid current station");
                Console.WriteLine("PASS CRS section association contracts");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL CRS section association: " + ex);
                return 1;
            }
        }
    }
}
