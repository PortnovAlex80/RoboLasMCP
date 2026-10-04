using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Persistence
{
    /// <summary>File-backed v2 polygon store. Each instance has one immutable scope.</summary>
    public sealed class ScopedPolygonRepository
    {
        private readonly PolygonScope _scope;
        private const string MissingRevision = "missing";

        public ScopedPolygonRepository(PolygonScope scope)
        {
            if (scope == null) throw new ArgumentNullException("scope");
            _scope = scope;
        }

        public PolygonScope Scope { get { return _scope; } }

        public ScopedPolygonSnapshot Read()
        {
            byte[] bytes = ReadBytesIfPresent(_scope.FilePath);
            return Snapshot(bytes, bytes == null ? EmptyDocument() : Decode(bytes));
        }

        public ScopedPolygonSnapshot Commit(ScopedPolygonSnapshot expected,
            IEnumerable<ScopedPolygonRecord> records)
        {
            if (expected == null) throw new ArgumentNullException("expected");
            if (records == null) throw new ArgumentNullException("records");
            CheckScope(expected);
            List<ScopedPolygonRecord> candidate = CopyRecords(records);
            using (AcquireLock())
            {
                byte[] oldBytes = ReadBytesIfPresent(_scope.FilePath);
                CheckRevision(expected, oldBytes);
                FileDocument document = oldBytes == null ? EmptyDocument() : Decode(oldBytes);
                document.ProjectAlias = _scope.ProjectAlias;
                document.Polygons = EncodeRecords(candidate);
                byte[] newBytes = Encode(document);
                Publish(newBytes);
                return new ScopedPolygonSnapshot(_scope.ScopeKey, PolygonScope.Hash(newBytes), candidate);
            }
        }

        private List<ScopedPolygonRecord> CopyRecords(IEnumerable<ScopedPolygonRecord> records)
        {
            List<ScopedPolygonRecord> result = new List<ScopedPolygonRecord>();
            foreach (ScopedPolygonRecord record in records)
            {
                if (record == null || record.GeometryKind != _scope.GeometryKind)
                    throw new ArgumentException("The record does not belong to this polygon geometry.", "records");
                result.Add(record);
            }
            return result;
        }

        private FileDocument EmptyDocument()
        {
            return new FileDocument
            {
                Version = 2,
                ScopeKey = _scope.ScopeKey,
                ScopeKind = _scope.Kind.ToString(),
                GeometryKind = _scope.GeometryKind.ToString(),
                ProjectUri = _scope.ProjectUri,
                ProjectAlias = _scope.ProjectAlias,
                SharedCloudKey = _scope.SharedCloudKey,
                ModelUri = _scope.ModelUri,
                AlignmentId = _scope.AlignmentId.ToString("N"),
                Polygons = new List<RecordData>()
            };
        }

        private FileDocument Decode(byte[] bytes)
        {
            FileDocument document = Deserialize<FileDocument>(bytes);
            if (document == null || document.Version != 2 ||
                document.ScopeKey != _scope.ScopeKey ||
                document.ScopeKind != _scope.Kind.ToString() ||
                document.GeometryKind != _scope.GeometryKind.ToString() ||
                document.ProjectUri != _scope.ProjectUri ||
                document.SharedCloudKey != _scope.SharedCloudKey ||
                document.ModelUri != _scope.ModelUri ||
                document.AlignmentId != _scope.AlignmentId.ToString("N") ||
                document.Polygons == null)
                throw new InvalidDataException("Invalid or mismatched v2 polygon file.");
            DecodeRecords(document.Polygons);
            return document;
        }

        private ScopedPolygonSnapshot Snapshot(byte[] bytes, FileDocument document)
        {
            return new ScopedPolygonSnapshot(_scope.ScopeKey,
                bytes == null ? MissingRevision : PolygonScope.Hash(bytes),
                DecodeRecords(document.Polygons));
        }

        private List<ScopedPolygonRecord> DecodeRecords(List<RecordData> encoded)
        {
            List<ScopedPolygonRecord> result = new List<ScopedPolygonRecord>();
            foreach (RecordData item in encoded)
            {
                if (item == null || item.Polygon == null || item.CreatedAt == null)
                    throw new InvalidDataException("Invalid polygon record.");
                DateTime date;
                if (!DateTime.TryParseExact(item.CreatedAt, "O", CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind, out date))
                    throw new InvalidDataException("Invalid polygon creation date.");
                List<Vector2D> points = DecodePoints(item.Polygon);
                try
                {
                    result.Add(_scope.GeometryKind == PolygonGeometryKind.Plan
                        ? ScopedPolygonRecord.Plan(date, points)
                        : ScopedPolygonRecord.Crs(date, points, item.SectionId,
                            item.SectionStation, item.Thickness));
                }
                catch (ArgumentException ex)
                {
                    throw new InvalidDataException("Invalid polygon coordinates or section data.", ex);
                }
            }
            return result;
        }

        private static List<Vector2D> DecodePoints(double[][] encoded)
        {
            List<Vector2D> points = new List<Vector2D>();
            foreach (double[] pair in encoded)
            {
                if (pair == null || pair.Length != 2)
                    throw new InvalidDataException("A polygon point must have two coordinates.");
                if (Double.IsNaN(pair[0]) || Double.IsInfinity(pair[0]) ||
                    Double.IsNaN(pair[1]) || Double.IsInfinity(pair[1]))
                    throw new InvalidDataException("Polygon coordinates must be finite.");
                points.Add(new Vector2D(pair[0], pair[1]));
            }
            return points;
        }

        private static List<RecordData> EncodeRecords(IList<ScopedPolygonRecord> records)
        {
            List<RecordData> encoded = new List<RecordData>();
            foreach (ScopedPolygonRecord record in records)
            {
                double[][] points = new double[record.Polygon.Count][];
                for (int i = 0; i < points.Length; i++)
                    points[i] = new double[] { record.Polygon[i].X, record.Polygon[i].Y };
                encoded.Add(new RecordData
                {
                    CreatedAt = record.CreatedAt.ToString("O", CultureInfo.InvariantCulture),
                    Polygon = points,
                    SectionId = record.SectionId,
                    SectionStation = record.SectionStation,
                    Thickness = record.Thickness
                });
            }
            return encoded;
        }

        private static T Deserialize<T>(byte[] bytes)
        {
            try
            {
                // Accept an optional UTF-8 BOM before the JSON document.
                int offset = bytes.Length >= 3 && bytes[0] == 0xEF &&
                    bytes[1] == 0xBB && bytes[2] == 0xBF ? 3 : 0;
                using (MemoryStream stream = new MemoryStream(bytes, offset,
                    bytes.Length - offset, false))
                    return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(stream);
            }
            catch (SerializationException ex)
            {
                throw new InvalidDataException("Malformed polygon JSON.", ex);
            }
            catch (System.Xml.XmlException ex)
            {
                throw new InvalidDataException("Malformed polygon JSON.", ex);
            }
        }

        private static byte[] Encode(FileDocument document)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                new DataContractJsonSerializer(typeof(FileDocument)).WriteObject(stream, document);
                return stream.ToArray();
            }
        }

        private static byte[] ReadBytesIfPresent(string path)
        {
            try { return File.ReadAllBytes(path); }
            catch (FileNotFoundException) { return null; }
            catch (DirectoryNotFoundException) { return null; }
        }

        private void CheckScope(ScopedPolygonSnapshot expected)
        {
            if (!String.Equals(expected.ScopeKey, _scope.ScopeKey, StringComparison.Ordinal))
                throw new ArgumentException("The snapshot belongs to a different polygon scope.", "expected");
        }

        private void CheckRevision(ScopedPolygonSnapshot expected, byte[] bytes)
        {
            CheckScope(expected);
            string current = bytes == null ? MissingRevision : PolygonScope.Hash(bytes);
            if (!String.Equals(expected.Revision, current, StringComparison.Ordinal))
                throw new PolygonRevisionConflictException();
        }

        private FileStream AcquireLock()
        {
            string directory = Path.GetDirectoryName(_scope.FilePath);
            Directory.CreateDirectory(directory);
            string lockPath = _scope.FilePath + ".lock";
            DateTime deadline = DateTime.UtcNow.AddSeconds(5);
            while (true)
            {
                try { return new FileStream(lockPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
                catch (IOException)
                {
                    if (DateTime.UtcNow >= deadline) throw;
                    Thread.Sleep(50);
                }
            }
        }

        private void Publish(byte[] bytes)
        {
            string temporary = _scope.FilePath + "." + Guid.NewGuid().ToString("N") + ".tmp";
            try
            {
                using (FileStream stream = new FileStream(temporary, FileMode.CreateNew,
                    FileAccess.Write, FileShare.None)) stream.Write(bytes, 0, bytes.Length);
                byte[] verified = File.ReadAllBytes(temporary);
                if (verified.Length != bytes.Length ||
                    !String.Equals(PolygonScope.Hash(verified), PolygonScope.Hash(bytes), StringComparison.Ordinal))
                    throw new IOException("Polygon temporary file verification failed.");
                Decode(verified);
                if (File.Exists(_scope.FilePath)) File.Replace(temporary, _scope.FilePath, null);
                else File.Move(temporary, _scope.FilePath);
            }
            finally
            {
                if (File.Exists(temporary)) File.Delete(temporary);
            }
        }

        // DTO fields are assigned by DataContractJsonSerializer on read.
#pragma warning disable 0649
        [DataContract]
        private sealed class FileDocument
        {
            [DataMember(Name = "version", IsRequired = true)] public int Version;
            [DataMember(Name = "scopeKey", IsRequired = true)] public string ScopeKey;
            [DataMember(Name = "scopeKind", IsRequired = true)] public string ScopeKind;
            [DataMember(Name = "geometryKind", IsRequired = true)] public string GeometryKind;
            [DataMember(Name = "projectUri")] public string ProjectUri;
            [DataMember(Name = "projectAlias")] public string ProjectAlias;
            [DataMember(Name = "sharedCloudKey")] public string SharedCloudKey;
            [DataMember(Name = "modelUri")] public string ModelUri;
            [DataMember(Name = "alignmentId", IsRequired = true)] public string AlignmentId;
            [DataMember(Name = "polygons", IsRequired = true)] public List<RecordData> Polygons;
        }

        [DataContract]
        private sealed class RecordData
        {
            [DataMember(Name = "createdAt", IsRequired = true)] public string CreatedAt;
            [DataMember(Name = "polygon", IsRequired = true)] public double[][] Polygon;
            [DataMember(Name = "sectionId", IsRequired = true)] public uint SectionId;
            [DataMember(Name = "sectionStation", IsRequired = true)] public double SectionStation;
            [DataMember(Name = "thickness", IsRequired = true)] public double Thickness;
        }

#pragma warning restore 0649
    }
}
