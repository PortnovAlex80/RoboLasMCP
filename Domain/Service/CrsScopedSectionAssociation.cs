using System;
using LAS_TERRAIN.Domain.Persistence;

namespace LAS_TERRAIN.Domain.Service
{
    /// <summary>
    /// Resolves a v2 CRS polygon to the current section by persistent section ID.
    /// Reordering is allowed; missing or ambiguous IDs and moved stations are not.
    /// </summary>
    internal static class CrsScopedSectionAssociation
    {
        internal static bool TryResolve(ScopedPolygonRecord record, int sectionCount,
            Func<int, uint> idAt, Func<int, double> stationAt, out int sectionIndex)
        {
            if (record == null) throw new ArgumentNullException("record");
            if (record.GeometryKind != PolygonGeometryKind.Crs)
                throw new ArgumentException("A CRS polygon record is required.", "record");
            if (sectionCount < 0) throw new ArgumentOutOfRangeException("sectionCount");
            if (idAt == null) throw new ArgumentNullException("idAt");
            if (stationAt == null) throw new ArgumentNullException("stationAt");

            sectionIndex = -1;
            if (Double.IsNaN(record.SectionStation) ||
                Double.IsInfinity(record.SectionStation))
                return false;

            for (int i = 0; i < sectionCount; i++)
            {
                if (idAt(i) != record.SectionId) continue;
                if (sectionIndex >= 0)
                {
                    sectionIndex = -1;
                    return false;
                }
                sectionIndex = i;
            }

            if (sectionIndex < 0) return false;
            double current = stationAt(sectionIndex);
            if (Double.IsNaN(current) || Double.IsInfinity(current) ||
                Math.Abs(record.SectionStation - current) >
                    CrsSectionAssociation.StationTolerance)
            {
                sectionIndex = -1;
                return false;
            }
            return true;
        }
    }
}
