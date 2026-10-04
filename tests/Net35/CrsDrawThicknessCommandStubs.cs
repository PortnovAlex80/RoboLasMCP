using System;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public enum DialogResult { Yes, No, Cancel }
    public enum MessageBoxButtons { OK, YesNo, YesNoCancel }
    public enum MessageBoxIcon { Warning, Information, Error, Question }
    public static class MessageBox
    {
        public static DialogResult Show(string text, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.NextDecision(); }
    }
}

namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }
    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector2D Pos { get { return new Vector2D(X, Y); } }
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
    }
    public struct Vector3F
    {
        public float X, Y, Z;
    }
    public struct Vector4D
    {
        public double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }
}

namespace Topomatic.Cad.View
{
    using Topomatic.Cad.Foundation;
    public enum ArrayMode { Point }
    public delegate void DrawCursorEvent(CadPen pen, Vector3D vertex);
    public sealed class CadPen
    {
        public System.Drawing.Color Color;
        public float Width;
        public void BeginDraw() { }
        public void EndDraw() { }
        public void BeginArray() { }
        public void EndArray(ArrayMode mode) { }
        public void Vertex(Vector2D point) { }
        public void DrawLine(Vector2D first, Vector2D second) { }
    }
    public sealed class CadView
    {
        public bool IsDisposed;
        public bool IsHandleCreated = true;
        public event DrawCursorEvent DynamicDraw;
        public int HandlerCount { get { return DynamicDraw == null ? 0 : DynamicDraw.GetInvocationList().Length; } }
        public void Unlock() { }
        public void Invalidate() { }
    }
}

namespace Topomatic.Cad.View.Design
{
    public static class CadViewDesignUtils
    {
        public const string CrossSectionCadViewAlias = "cross";
        public static Topomatic.Cad.View.CadView OnCadViewSelect(string alias)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.CrossView; }
    }
}

namespace Topomatic.Cad.View.Hints
{
    using Topomatic.Cad.Foundation;
    using Topomatic.Cad.View;
    public static class CadCursors
    {
        public static bool GetPoint(CadView view, out Vector3D point, string prompt)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.NextPoint(out point); }
    }
}

namespace Topomatic.Alg
{
    using Topomatic.Cad.Foundation;
    public sealed class Section { public uint Id = 7; public double Station = 25; }
    public sealed class Corridor { public List<Section> Sections = new List<Section> { new Section() }; }
    public sealed class CompoundLine
    {
        public bool StaOffsetToPos(double station, double offset, out Vector2D result)
        { result = new Vector2D(offset, 0); return true; }
    }
    public sealed class Plan { public CompoundLine CompoundLine = new CompoundLine(); }
    public sealed class Alignment
    {
        public Corridor Corridor = new Corridor();
        public Plan Plan = new Plan();
        public double DtmSizeLeft = 1, DtmSizeRight = 1;
    }
}

namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public sealed class SectionManager { public int CurrentSection; }
    public sealed class ActiveAlignmentReciver<T> : IDisposable
    {
        public T Alignment;
        public SectionManager Manager;
        public static ActiveAlignmentReciver<T> CreateReciver(bool unused)
        {
            return new ActiveAlignmentReciver<T> {
                Alignment = (T)(object)LAS_TERRAIN.Tests.CrsDrawThicknessFixture.Alignment,
                Manager = LAS_TERRAIN.Tests.CrsDrawThicknessFixture.Manager };
        }
        public void Dispose() { }
    }
}

namespace Topomatic.ApplicationPlatform
{
    public sealed class Project { }
    public sealed class Model { public Project Project; }
    public sealed class ApplicationHost
    {
        public static ApplicationHost Current;
        public Project ActiveProject;
        public object ActiveDocument;
    }
}
namespace Topomatic.ApplicationPlatform.Plugins { }

namespace Topomatic.Lidar
{
    using Topomatic.Cad.Foundation;
    public sealed class PointArray
    {
        public Vector3F[] Values = new Vector3F[0];
        public int Count { get { return Values.Length; } }
        public Vector3F[] GetBuffer() { return Values; }
    }
    public sealed class WeightArray
    {
        public byte[] Values = new byte[0];
        public int Count { get { return Values.Length; } }
        public byte[] GetBuffer() { return Values; }
    }
    public sealed class QuadTreeIndexer
    {
        public PointArray points;
        public WeightArray weights;
        public Vector3D scale = new Vector3D(1, 1, 1);
        public Vector3D position;
    }
    public sealed class LidarBuffer
    {
        public string fullpath = @"C:\fixture\cloud.las";
        public List<QuadTreeIndexer> indexers = new List<QuadTreeIndexer>();
    }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
        public static void BeginProgress(string title, Action action, bool cancellable) { action(); }
        public static void ProgressChange(float value) { }
    }
}
namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static readonly List<string> Messages = new List<string>();
        public static void Show(string text) { Messages.Add(text); }
        public static void Show(string text, System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon) { Messages.Add(text); }
    }
}
namespace Topomatic.FoundationClasses.Parallel
{
    public static class Parallel
    {
        public static void ForEach<T>(T[] items, Action<T> action)
        { foreach (T item in items) action(item); }
    }
}

namespace LAS_TERRAIN
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SectionCmdAttribute : Attribute
    { public SectionCmdAttribute(string name) { } }
    public interface ISectionUseCase
    { string Name { get; } void Run(SectionEnv env); }
    public sealed class SectionEnv
    {
        public Topomatic.Cad.View.CadView CadView;
        public SectionEnv(Topomatic.Cad.View.CadView view) { CadView = view; }
    }
}

namespace LAS_TERRAIN.Configuration
{
    public static class RuntimeConfig
    {
        private static double _border;
        public static int Reads;
        public static double CrsOverlayBorder
        {
            get { Reads++; return _border; }
            set { _border = value; }
        }
    }
}

namespace LAS_TERRAIN.Domain.Service
{
    using LAS_TERRAIN.Domain.Models;
    using Topomatic.Cad.Foundation;
    using System.IO;
    internal sealed class CrsPolygonSnapshot
    {
        internal readonly string FilePath;
        internal readonly List<CrsPolygonEntry> Polygons;
        internal readonly long Generation;
        internal CrsPolygonSnapshot(string path, List<CrsPolygonEntry> polygons, long generation)
        { FilePath = path; Polygons = polygons; Generation = generation; }
    }
    public static class CrsPolygonCollection
    {
        private static readonly Dictionary<string, List<CrsPolygonEntry>> Stores =
            new Dictionary<string, List<CrsPolygonEntry>>(StringComparer.OrdinalIgnoreCase);
        private static string _path;
        private static long _generation;
        public static bool FailNextAdd;
        public static List<CrsPolygonEntry> Entries
        { get { return _path == null ? null : Stores[_path]; } }
        public static void Reset()
        { Stores.Clear(); _path = null; _generation = 0; FailNextAdd = false; }
        public static void Initialize(string path)
        {
            _path = Path.Combine(Path.Combine(path, ".las_terrain"), "polygons.json");
            if (!Stores.ContainsKey(_path)) Stores[_path] = new List<CrsPolygonEntry>();
            _generation++;
        }
        public static int Count { get { return Entries.Count; } }
        public static void Add(CrsPolygonEntry entry) { Entries.Add(entry.Clone()); }
        internal static CrsPolygonSnapshot GetSnapshot()
        {
            var copy = new List<CrsPolygonEntry>();
            foreach (CrsPolygonEntry entry in Entries) copy.Add(entry.Clone());
            return new CrsPolygonSnapshot(_path, copy, _generation);
        }
        internal static bool TryAddIfUnchanged(CrsPolygonSnapshot expected, CrsPolygonEntry entry)
        {
            if (expected.Generation != _generation ||
                !String.Equals(expected.FilePath, _path, StringComparison.OrdinalIgnoreCase) ||
                !Same(Entries, expected.Polygons)) return false;
            if (FailNextAdd)
            {
                FailNextAdd = false;
                throw new IOException("Simulated polygon write failure.");
            }
            Add(entry);
            _generation++;
            return true;
        }
        private static bool Same(List<CrsPolygonEntry> a, List<CrsPolygonEntry> b)
        {
            if (a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].CreatedAt != b[i].CreatedAt ||
                    a[i].SectionIndex != b[i].SectionIndex ||
                    a[i].Station != b[i].Station || a[i].Thickness != b[i].Thickness ||
                    a[i].Polygon.Count != b[i].Polygon.Count) return false;
                for (int j = 0; j < a[i].Polygon.Count; j++)
                    if (a[i].Polygon[j].X != b[i].Polygon[j].X ||
                        a[i].Polygon[j].Y != b[i].Polygon[j].Y) return false;
            }
            return true;
        }
        public static int CountAt(string directory)
        {
            string path = Path.Combine(Path.Combine(directory, ".las_terrain"), "polygons.json");
            return Stores.ContainsKey(path) ? Stores[path].Count : 0;
        }
    }
    public static class ScanlineFillPlanner
    {
        public static bool TryPlan(double low, double high, double step, out double result)
        { result = step; return true; }
    }
    public static class PolygonGeometry
    {
        public static bool Contains(Vector2D point, List<Vector2D> polygon) { return false; }
    }
}

namespace LAS_TERRAIN.Infrastructure
{
    using LAS_TERRAIN.Domain.Persistence;
    using Topomatic.Alg;
    using Topomatic.Cad.View;
    using Topomatic.ApplicationPlatform;
    internal sealed class ScopedPolygonOperationContext
    {
        private readonly PolygonTestOwnerContext _source;
        private static readonly List<ScopedPolygonRecord> Stored =
            new List<ScopedPolygonRecord>();
        private static int _revision;
        internal static bool FailNextCommit;
        internal static IList<ScopedPolygonRecord> Records { get { return Stored.AsReadOnly(); } }
        internal static void Reset()
        {
            Stored.Clear();
            _revision = 0;
            FailNextCommit = false;
        }
        internal static void ConcurrentAdd(ScopedPolygonRecord record)
        { Stored.Add(record); _revision++; }
        private ScopedPolygonOperationContext(PolygonTestOwnerContext source)
        { _source = source; }
        internal static ScopedPolygonOperationContext Capture(CadView view,
            PolygonGeometryKind kind)
        {
            var source = PolygonTestOwnerContext.Capture(view);
            return source == null ? null : new ScopedPolygonOperationContext(source);
        }
        internal bool IsCurrent() { return _source.IsCurrent(); }
        internal bool IsSourceCurrent() { return _source.IsSourceCurrent(); }
        internal bool MatchesCapturedSource(Alignment alignment,
            List<Topomatic.Lidar.LidarBuffer> buffers)
        { return _source.MatchesCapturedSource(alignment, buffers); }
        internal bool TryRead(out ScopedPolygonSnapshot snapshot)
        {
            snapshot = new ScopedPolygonSnapshot("crs-test", _revision.ToString(), Stored);
            return IsCurrent();
        }
        internal ScopedPolygonSnapshot Commit(ScopedPolygonSnapshot expected,
            IEnumerable<ScopedPolygonRecord> records)
        {
            if (!IsCurrent() || expected.Revision != _revision.ToString())
                throw new PolygonRevisionConflictException();
            if (FailNextCommit)
            {
                FailNextCommit = false;
                throw new System.IO.IOException("Injected v2 commit failure");
            }
            Stored.Clear();
            Stored.AddRange(records);
            _revision++;
            return new ScopedPolygonSnapshot("crs-test", _revision.ToString(), Stored);
        }
    }
    public static class UserDialogs
    {
        public static bool IsCadViewValid(CadView view) { return view != null; }
        public static string GetSaveFilePath(string title) { return null; }
    }
    public static class PluginCoreOps
    {
        public static Model FindModel(Alignment alignment)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.Model; }
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Alignment alignment)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.AlignmentId; }
    }
}

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;
    public static class LidarBufferService
    {
        public static List<LidarBuffer> CollectBuffers(Alignment alignment)
        { return LAS_TERRAIN.Tests.CrsDrawThicknessFixture.Buffers; }
        public static bool ValidateBuffers(List<LidarBuffer> buffers) { return true; }
    }
}
namespace LAS_TERRAIN.Service.Collector { }
namespace LAS_TERRAIN.Models { }

namespace LAS_TERRAIN.IO
{
    using Topomatic.Cad.Foundation;
    public sealed class LasBatchStreamWriter : IDisposable
    {
        public Func<bool> IsCancellationRequested;
        public LasBatchStreamWriter(string path) { }
        public void WritePoints(List<Vector4D> points) { }
        public PreparedLasFile Complete() { return new PreparedLasFile(); }
        public void Dispose() { }
    }
    public sealed class PreparedLasFile : IDisposable
    {
        public void Publish() { }
        public void Dispose() { }
    }
}
