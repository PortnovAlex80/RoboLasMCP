using System;

namespace LAS_TERRAIN.Domain.Service
{
    internal static class CrsSectionAssociation
    {
        // JSON v1 stores station as a decimal number; tolerate only serialization
        // round-off, never a different generated section.
        internal const double StationTolerance = 0.000001;

        internal static bool IsCurrent(int savedIndex, double savedStation,
            int sectionCount, Func<int, double> stationAt)
        {
            if (stationAt == null) throw new ArgumentNullException("stationAt");
            if (savedIndex < 0 || savedIndex >= sectionCount ||
                double.IsNaN(savedStation) || double.IsInfinity(savedStation))
                return false;
            double current = stationAt(savedIndex);
            return !double.IsNaN(current) && !double.IsInfinity(current) &&
                Math.Abs(savedStation - current) <= StationTolerance;
        }
    }
}
