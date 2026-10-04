using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Persistence
{
    public sealed class ScopedPolygonRecord
    {
        public PolygonGeometryKind GeometryKind { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public IList<Vector2D> Polygon { get; private set; }
        public uint SectionId { get; private set; }
        public double SectionStation { get; private set; }
        public double Thickness { get; private set; }

        private ScopedPolygonRecord(PolygonGeometryKind kind, DateTime createdAt,
            IList<Vector2D> polygon, uint sectionId, double station, double thickness)
        {
            if (polygon == null) throw new ArgumentNullException("polygon");
            List<Vector2D> copy = new List<Vector2D>(polygon.Count);
            foreach (Vector2D point in polygon)
            {
                Finite(point.X, "point.X");
                Finite(point.Y, "point.Y");
                copy.Add(new Vector2D(point.X, point.Y));
            }
            if (kind == PolygonGeometryKind.Crs)
            {
                Finite(station, "station");
                Finite(thickness, "thickness");
            }
            GeometryKind = kind;
            CreatedAt = createdAt;
            Polygon = new ReadOnlyCollection<Vector2D>(copy);
            SectionId = sectionId;
            SectionStation = station;
            Thickness = thickness;
        }

        public static ScopedPolygonRecord Plan(DateTime createdAt, IList<Vector2D> polygon)
        {
            return new ScopedPolygonRecord(PolygonGeometryKind.Plan, createdAt, polygon, 0, 0, 0);
        }

        public static ScopedPolygonRecord Crs(DateTime createdAt, IList<Vector2D> polygon,
            uint sectionId, double sectionStation, double thickness)
        {
            return new ScopedPolygonRecord(PolygonGeometryKind.Crs, createdAt, polygon,
                sectionId, sectionStation, thickness);
        }

        internal static void Finite(double value, string name)
        {
            if (Double.IsNaN(value) || Double.IsInfinity(value))
                throw new ArgumentException("A finite value is required.", name);
        }
    }

    // Captured section identity for validating the current host owner.
    public sealed class PolygonSectionBinding
    {
        public uint SectionId { get; private set; }
        public double Station { get; private set; }

        public PolygonSectionBinding(uint sectionId, double station)
        {
            ScopedPolygonRecord.Finite(station, "station");
            SectionId = sectionId;
            Station = station;
        }
    }

    public sealed class ScopedPolygonSnapshot
    {
        public string ScopeKey { get; private set; }
        public string Revision { get; private set; }
        public IList<ScopedPolygonRecord> Records { get; private set; }

        internal ScopedPolygonSnapshot(string scopeKey, string revision, IList<ScopedPolygonRecord> records)
        {
            ScopeKey = scopeKey;
            Revision = revision;
            Records = new ReadOnlyCollection<ScopedPolygonRecord>(new List<ScopedPolygonRecord>(records));
        }
    }

    public sealed class PolygonRevisionConflictException : InvalidOperationException
    {
        public PolygonRevisionConflictException()
            : base("The polygon file changed after it was read.") { }
    }
}
