using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Persistence
{
    /// <summary>A user-owned polygon file without any project identity restriction.</summary>
    public static class PortablePolygonFile
    {
        public static string FileName(string project, PolygonGeometryKind kind, int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException("number");
            string name = String.IsNullOrEmpty(project) ? "Проект" : project;
            foreach (char invalid in Path.GetInvalidFileNameChars()) name = name.Replace(invalid, '_');
            name = name.Trim().TrimEnd('.');
            if (name.Length == 0) name = "Проект";
            if (name.Length > 100) name = name.Substring(0, 100);
            return name + (kind == PolygonGeometryKind.Plan ? ".план" : ".поперечник") +
                ".полигон." + number.ToString("D3", CultureInfo.InvariantCulture) + ".json";
        }

        public static void Save(string path, ScopedPolygonRecord record)
        {
            if (record == null) throw new ArgumentNullException("record");
            if (record.Polygon.Count < 3) throw new InvalidDataException("Полигон должен содержать не менее трёх вершин.");
            double[][] vertices = new double[record.Polygon.Count][];
            for (int i = 0; i < vertices.Length; i++)
                vertices[i] = new double[] { record.Polygon[i].X, record.Polygon[i].Y };
            FileData data = new FileData { Format = "robolas-polygon", Version = 1,
                Geometry = record.GeometryKind.ToString(),
                Coordinates = record.GeometryKind == PolygonGeometryKind.Plan ? "project-xy" : "section-offset-elevation",
                CreatedAt = record.CreatedAt.ToString("O", CultureInfo.InvariantCulture),
                Vertices = vertices, Station = record.SectionStation, Thickness = record.Thickness };
            string destination = Path.GetFullPath(path);
            string stage = destination + "." + Guid.NewGuid().ToString("N") + ".tmp";
            try
            {
                using (FileStream stream = new FileStream(stage, FileMode.CreateNew, FileAccess.Write))
                    new DataContractJsonSerializer(typeof(FileData)).WriteObject(stream, data);
                // Validate the complete file before replacing an existing user file.
                Load(stage);
                if (File.Exists(destination)) File.Replace(stage, destination, null);
                else File.Move(stage, destination);
            }
            finally { if (File.Exists(stage)) File.Delete(stage); }
        }

        public static ScopedPolygonRecord Load(string path)
        {
            FileData data;
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    if (stream.Length > 16 * 1024 * 1024) throw new InvalidDataException("Файл полигона слишком большой.");
                    data = (FileData)new DataContractJsonSerializer(typeof(FileData)).ReadObject(stream);
                }
            }
            catch (SerializationException ex) { throw new InvalidDataException("Некорректный JSON полигона.", ex); }
            catch (System.Xml.XmlException ex) { throw new InvalidDataException("Некорректный JSON полигона.", ex); }
            if (data == null || data.Format != "robolas-polygon" || data.Version != 1 ||
                data.Vertices == null || data.Vertices.Length < 3 ||
                (data.Geometry != "Plan" && data.Geometry != "Crs") ||
                data.Coordinates != (data.Geometry == "Plan" ? "project-xy" : "section-offset-elevation"))
                throw new InvalidDataException("Неверный формат файла полигона.");
            DateTime created;
            if (!DateTime.TryParseExact(data.CreatedAt, "O", CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind, out created)) throw new InvalidDataException("Неверная дата полигона.");
            List<Vector2D> points = new List<Vector2D>();
            foreach (double[] pair in data.Vertices)
            {
                if (pair == null || pair.Length != 2) throw new InvalidDataException("Неверные координаты вершины.");
                points.Add(new Vector2D(pair[0], pair[1]));
            }
            try
            {
                return data.Geometry == "Plan" ? ScopedPolygonRecord.Plan(created, points) :
                    ScopedPolygonRecord.Crs(created, points, 0, data.Station, data.Thickness);
            }
            catch (ArgumentException ex) { throw new InvalidDataException("Неверные координаты или параметры полигона.", ex); }
        }

#pragma warning disable 0649
        [DataContract]
        private sealed class FileData
        {
            [DataMember(Name = "format", IsRequired = true)] public string Format;
            [DataMember(Name = "version", IsRequired = true)] public int Version;
            [DataMember(Name = "geometry", IsRequired = true)] public string Geometry;
            [DataMember(Name = "coordinates", IsRequired = true)] public string Coordinates;
            [DataMember(Name = "createdAt", IsRequired = true)] public string CreatedAt;
            [DataMember(Name = "vertices", IsRequired = true)] public double[][] Vertices;
            [DataMember(Name = "sectionStation", IsRequired = true)] public double Station;
            [DataMember(Name = "thickness", IsRequired = true)] public double Thickness;
        }
#pragma warning restore 0649
    }
}
