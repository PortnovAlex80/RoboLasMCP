using System;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public enum DialogResult { Yes, No }
    public enum MessageBoxButtons { OK, YesNo }
    public enum MessageBoxIcon { Question, Warning, Information, Error }
    public static class MessageBox
    {
        public static DialogResult Show(string text, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.OnConfirm != null)
                LAS_TERRAIN.Tests.CrsDeleteFixture.OnConfirm();
            return DialogResult.Yes;
        }
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
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
    }
    public struct Vector3F
    {
        public float X, Y, Z;
        public Vector3F(float x, float y, float z) { X = x; Y = y; Z = z; }
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
    public sealed class CadView
    {
        public bool IsDisposed;
        public bool IsHandleCreated = true;
#if PLAN_DELETE_TESTS
        public object this[Guid id]
        { get { return LAS_TERRAIN.Tests.PlanDeleteFixture.Overlay; } }
#endif
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
        { return new Topomatic.Cad.View.CadView(); }
    }
}

namespace Topomatic.Alg
{
    using Topomatic.Cad.Foundation;
    public sealed class TestSection { public uint Id = 7; public double Station; }
    public sealed class TestCorridor
    { public List<TestSection> Sections = new List<TestSection> { new TestSection() }; }
    public sealed class TestCompoundLine
    {
        public bool FailAtStationOne;
        public bool DegenerateAtStationOne;
        public bool StaOffsetToPos(double station, double offset, out Vector2D result)
        {
            result = new Vector2D(station == 1 && DegenerateAtStationOne ? 0 : offset, 0);
            return !(station == 1 && FailAtStationOne);
        }
    }
    public sealed class TestPlan
    { public TestCompoundLine CompoundLine = new TestCompoundLine(); }
    public sealed class Alignment
    {
        public TestCorridor Corridor = new TestCorridor();
        public TestPlan Plan = new TestPlan();
        public double DtmSizeLeft = 1;
        public double DtmSizeRight = 1;
    }
}

namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public sealed class ActiveAlignmentReciver<T> : IDisposable
    {
        public T Alignment;
        public static ActiveAlignmentReciver<T> CreateReciver(bool unused)
        {
            return new ActiveAlignmentReciver<T> { Alignment =
                (T)(object)LAS_TERRAIN.Tests.CrsDeleteFixture.Alignment };
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
        public Vector3F[] Values;
        public int Count { get { return Values.Length; } }
        public Vector3F[] GetBuffer() { return Values; }
    }
    public sealed class WeightArray
    {
        public byte[] Values;
        public int LogicalCount = -1;
        public int Count { get { return LogicalCount < 0 ? Values.Length : LogicalCount; } }
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
        public static int Calls;
        public static void BeginProgress(string title, Action action, bool cancellable)
        {
            Calls++;
            try
            {
                action();
                if (LAS_TERRAIN.Tests.CrsDeleteFixture.OnProgressEnd != null)
                    LAS_TERRAIN.Tests.CrsDeleteFixture.OnProgressEnd();
                if (LAS_TERRAIN.Tests.CrsDeleteFixture.ThrowAfterAction)
                    throw new OperationCanceledException("late progress cancellation");
            }
            finally { CancellationPending = false; }
        }
        public static void ProgressChange(float value)
        {
#if PLAN_DELETE_TESTS
            if (value >= 0.2f)
                LAS_TERRAIN.Tests.PlanDeleteFixture.ExportPhase = true;
#endif
            if (value >= 1 && LAS_TERRAIN.Tests.CrsDeleteFixture.FailAtCompletionProgress)
                throw new InvalidOperationException("late progress error");
            if (value >= 1 && LAS_TERRAIN.Tests.CrsDeleteFixture.CancelAtCompletionProgress)
                CancellationPending = true;
        }
    }
}

namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static readonly List<string> Messages = new List<string>();
        public static void Show(string text, System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon) { Messages.Add(text); }
    }
}

namespace Topomatic.FoundationClasses.Parallel
{
    public static class Parallel
    {
        public static bool Reverse;
        public static void ForEach<T>(T[] items, Action<T> action)
        {
            if (Reverse)
                for (int i = items.Length - 1; i >= 0; i--) action(items[i]);
            else
                for (int i = 0; i < items.Length; i++) action(items[i]);
        }
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
        public Topomatic.Cad.View.CadView CadView = new Topomatic.Cad.View.CadView();
    }
}

namespace LAS_TERRAIN.Configuration
{
    public static class RuntimeConfig
    { public static double CrsOverlayBorder = 2; }
}

namespace LAS_TERRAIN.Domain.Service
{
    using LAS_TERRAIN.Domain.Models;
    using Topomatic.Cad.Foundation;
    internal sealed class CrsPolygonSnapshot
    {
        internal readonly string FilePath;
        internal readonly List<CrsPolygonEntry> Polygons;
        internal CrsPolygonSnapshot(List<CrsPolygonEntry> polygons)
        {
            Polygons = polygons;
            FilePath = System.IO.Path.Combine(System.IO.Path.Combine(@"C:\fixture",
                ".las_terrain"), "polygons.json");
        }
    }
    public static class CrsPolygonCollection
    {
        public static void Initialize(string path) { }
        public static List<CrsPolygonEntry> GetAll()
        { return LAS_TERRAIN.Tests.CrsDeleteFixture.Polygons; }
        internal static CrsPolygonSnapshot GetSnapshot()
        {
            var copy = new List<CrsPolygonEntry>();
            foreach (CrsPolygonEntry entry in LAS_TERRAIN.Tests.CrsDeleteFixture.Polygons)
                copy.Add(entry.Clone());
            return new CrsPolygonSnapshot(copy);
        }
        internal static bool TryClearIfUnchanged(CrsPolygonSnapshot snapshot)
        {
            LAS_TERRAIN.Tests.CrsDeleteFixture.ClearCalls++;
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.FailClear)
                throw new InvalidOperationException("injected polygon clear error");
            return !LAS_TERRAIN.Tests.CrsDeleteFixture.PolygonsChanged;
        }
        public static Dictionary<int, List<CrsPolygonEntry>> GroupBySection()
        {
            return new Dictionary<int, List<CrsPolygonEntry>> {
                { 0, LAS_TERRAIN.Tests.CrsDeleteFixture.Polygons } };
        }
        public static void Clear()
        {
            LAS_TERRAIN.Tests.CrsDeleteFixture.ClearCalls++;
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.FailClear)
                throw new InvalidOperationException("injected polygon clear error");
        }
    }
    public static class PolygonGeometry
    {
        public static bool Contains(Vector2D point, List<Vector2D> polygon)
        {
            LAS_TERRAIN.Tests.CrsDeleteFixture.VisitPoint();
            return point.Y == 1;
        }
#if PLAN_DELETE_TESTS
        public static bool Contains(double x, double y, List<Vector2D> polygon)
        {
            LAS_TERRAIN.Tests.PlanDeleteFixture.VisitPoint();
            return x == 1;
        }
#endif
    }

#if PLAN_DELETE_TESTS
    internal sealed class PlanPolygonSnapshot
    {
        internal readonly string FilePath;
        internal readonly List<LAS_TERRAIN.Domain.Models.PlanPolygonEntry> Polygons;
        internal PlanPolygonSnapshot(
            List<LAS_TERRAIN.Domain.Models.PlanPolygonEntry> polygons)
        {
            Polygons = polygons;
            FilePath = System.IO.Path.Combine(System.IO.Path.Combine(@"C:\fixture",
                ".las_terrain"), "plan_polygons.json");
        }
    }
    public static class PlanPolygonCollection
    {
        public static void Initialize(string path) { }
        public static List<LAS_TERRAIN.Domain.Models.PlanPolygonEntry> GetAll()
        { return LAS_TERRAIN.Tests.PlanDeleteFixture.Polygons; }
        public static void Clear()
        { LAS_TERRAIN.Tests.PlanDeleteFixture.ClearCalls++; }
        internal static PlanPolygonSnapshot GetSnapshot()
        {
            var copy = new List<LAS_TERRAIN.Domain.Models.PlanPolygonEntry>();
            foreach (var entry in LAS_TERRAIN.Tests.PlanDeleteFixture.Polygons)
                copy.Add(entry.Clone());
            return new PlanPolygonSnapshot(copy);
        }
        internal static bool TryClearIfUnchanged(PlanPolygonSnapshot snapshot)
        {
            LAS_TERRAIN.Tests.PlanDeleteFixture.ClearAttempts++;
            if (LAS_TERRAIN.Tests.PlanDeleteFixture.FailClear)
                throw new InvalidOperationException("injected Plan clear error");
            if (LAS_TERRAIN.Tests.PlanDeleteFixture.PolygonsChanged)
                return false;
            LAS_TERRAIN.Tests.PlanDeleteFixture.ClearCalls++;
            return true;
        }
    }
#endif
}

#if PLAN_DELETE_TESTS
namespace LAS_TERRAIN.Visualization
{
    public sealed class PlanOverlayLayer
    {
        public static readonly Guid GUID = Guid.Empty;
        public void ClearPolygons()
        { LAS_TERRAIN.Tests.PlanDeleteFixture.OverlayClearCalls++; }
    }
}
#endif

namespace LAS_TERRAIN.Infrastructure
{
    using LAS_TERRAIN.Domain.Persistence;
    using Topomatic.Alg;
    using Topomatic.Cad.View;
    using Topomatic.Lidar;
    internal sealed class ScopedPolygonOperationContext
    {
        private readonly PolygonTestOwnerContext _source;
        private readonly PolygonGeometryKind _kind;
        private readonly int _revision;
        private static int Revision;
        private ScopedPolygonOperationContext(PolygonTestOwnerContext source,
            PolygonGeometryKind kind)
        { _source = source; _kind = kind; _revision = Revision; }
        internal static void Reset() { Revision = 0; }
        internal static ScopedPolygonOperationContext Capture(CadView view,
            PolygonGeometryKind kind)
        {
            var source = PolygonTestOwnerContext.Capture(view);
            return source == null ? null : new ScopedPolygonOperationContext(source, kind);
        }
        internal bool IsCurrent() { return _source.IsCurrent(); }
        internal bool IsSourceCurrent() { return _source.IsSourceCurrent(); }
        internal bool IsSnapshotCurrent(ScopedPolygonSnapshot snapshot)
        {
            return IsCurrent() && snapshot != null &&
                snapshot.Revision == Revision.ToString() &&
                (_kind == PolygonGeometryKind.Plan
#if PLAN_DELETE_TESTS
                    ? !LAS_TERRAIN.Tests.PlanDeleteFixture.PolygonsChanged
#else
                    ? true
#endif
                    : !LAS_TERRAIN.Tests.CrsDeleteFixture.PolygonsChanged);
        }
        internal bool MatchesCapturedSource(Alignment alignment,
            List<LidarBuffer> buffers)
        { return _source.MatchesCapturedSource(alignment, buffers); }
        internal bool TryRead(out ScopedPolygonSnapshot snapshot)
        {
            var records = new List<ScopedPolygonRecord>();
            if (_kind == PolygonGeometryKind.Plan)
            {
#if PLAN_DELETE_TESTS
                foreach (var entry in LAS_TERRAIN.Tests.PlanDeleteFixture.Polygons)
                    records.Add(ScopedPolygonRecord.Plan(entry.CreatedAt, entry.Polygon));
#endif
                snapshot = new ScopedPolygonSnapshot("plan-test", Revision.ToString(), records);
                return IsCurrent();
            }
            foreach (var entry in LAS_TERRAIN.Tests.CrsDeleteFixture.Polygons)
            {
                // The fixture seeds an explicit persistent ID. A legacy section
                // index is used only to build the fixture's initial v2 record.
                uint id = entry.SectionIndex == 0 ? 7u : 8u;
                records.Add(ScopedPolygonRecord.Crs(entry.CreatedAt,
                    entry.Polygon, id, entry.Station, entry.Thickness));
            }
            snapshot = new ScopedPolygonSnapshot("crs-test", Revision.ToString(), records);
            return IsCurrent();
        }
        internal ScopedPolygonSnapshot Commit(ScopedPolygonSnapshot expected,
            IEnumerable<ScopedPolygonRecord> records)
        {
            if (_kind == PolygonGeometryKind.Plan)
            {
#if PLAN_DELETE_TESTS
                LAS_TERRAIN.Tests.PlanDeleteFixture.ClearAttempts++;
                if (LAS_TERRAIN.Tests.PlanDeleteFixture.FailClear)
                    throw new InvalidOperationException("injected Plan clear error");
                if (LAS_TERRAIN.Tests.PlanDeleteFixture.PolygonsChanged ||
                    !IsCurrent() || expected.Revision != Revision.ToString())
                    throw new PolygonRevisionConflictException();
                Revision++;
                LAS_TERRAIN.Tests.PlanDeleteFixture.ClearCalls++;
                LAS_TERRAIN.Tests.PlanDeleteFixture.Polygons.Clear();
#endif
                return new ScopedPolygonSnapshot("plan-test", Revision.ToString(),
                    new List<ScopedPolygonRecord>(records));
            }
            LAS_TERRAIN.Tests.CrsDeleteFixture.ClearCalls++;
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.FailClear)
                throw new InvalidOperationException("injected polygon clear error");
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.PolygonsChanged ||
                !IsCurrent() || expected.Revision != Revision.ToString())
                throw new PolygonRevisionConflictException();
            Revision++;
            LAS_TERRAIN.Tests.CrsDeleteFixture.Polygons.Clear();
            return new ScopedPolygonSnapshot("crs-test", Revision.ToString(),
                new List<ScopedPolygonRecord>(records));
        }
    }
    public static class PluginCoreOps
    {
        public static Topomatic.ApplicationPlatform.Model FindModel(Topomatic.Alg.Alignment alignment)
        { return LAS_TERRAIN.Tests.CrsDeleteFixture.Model; }
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Topomatic.Alg.Alignment alignment)
        { return LAS_TERRAIN.Tests.CrsDeleteFixture.AlignmentId; }
    }
    public static class UserDialogs
    {
        public static string GetSaveFilePath(string title)
        {
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.OnSaveDialog != null)
                LAS_TERRAIN.Tests.CrsDeleteFixture.OnSaveDialog();
            return LAS_TERRAIN.Tests.CrsDeleteFixture.OutputPath;
        }
        public static void ShowWarning(string text)
        { Topomatic.Controls.Dialogs.MessageDlg.Messages.Add(text); }
    }
    public static class MemoryStatus
    {
        public static int CalcBatchSizeForReduceOnly()
        { return LAS_TERRAIN.Tests.CrsDeleteFixture.BatchSize; }
    }
}

namespace LAS_TERRAIN.Service
{
    public static class LidarBufferService
    {
        public static List<Topomatic.Lidar.LidarBuffer> CollectBuffers(Topomatic.Alg.Alignment alg)
        { return LAS_TERRAIN.Tests.CrsDeleteFixture.Buffers; }
    }
}

#if !REAL_LAS_WRITER
namespace LAS_TERRAIN.IO
{
    using Topomatic.Cad.Foundation;
    public sealed class LasBatchStreamWriter : IDisposable
    {
        public Func<bool> IsCancellationRequested;
        private readonly List<Vector4D> _staged = new List<Vector4D>();
        public LasBatchStreamWriter(string path)
        {
#if PLAN_DELETE_TESTS
            LAS_TERRAIN.Tests.PlanDeleteFixture.WriterCreated = true;
            if (LAS_TERRAIN.Tests.PlanDeleteFixture.MutateSourceAtWriter)
            {
                var indexer = LAS_TERRAIN.Tests.CrsDeleteFixture.Buffers[0].indexers[0];
                if (indexer.points.Values.Length > 0)
                    indexer.points.Values[0].X = 2;
            }
#endif
        }
        public void WritePoints(List<Vector4D> points)
        {
            if (IsCancellationRequested != null && IsCancellationRequested())
                throw new OperationCanceledException();
            LAS_TERRAIN.Tests.CrsDeleteFixture.WriteCalls++;
            if (points.Count > LAS_TERRAIN.Tests.CrsDeleteFixture.MaxBatch)
                LAS_TERRAIN.Tests.CrsDeleteFixture.MaxBatch = points.Count;
            _staged.AddRange(points);
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.CancelAfterWrite &&
                LAS_TERRAIN.Tests.CrsDeleteFixture.WriteCalls == 1)
                Topomatic.Controls.WaitProgress.CancellationPending = true;
        }
        public PreparedLasFile Complete()
        {
            LAS_TERRAIN.Tests.CrsDeleteFixture.CompleteCalls++;
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.FailComplete)
                throw new InvalidOperationException("injected complete error");
            if (IsCancellationRequested != null && IsCancellationRequested())
                throw new OperationCanceledException();
            return new PreparedLasFile(_staged);
        }
        public void Dispose() { }
    }
    public sealed class PreparedLasFile : IDisposable
    {
        private readonly List<Vector4D> _points;
        public PreparedLasFile(List<Vector4D> points)
        { _points = new List<Vector4D>(points); }
        public void Publish()
        {
            LAS_TERRAIN.Tests.CrsDeleteFixture.PublishCalls++;
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.FailPublish)
                throw new InvalidOperationException("injected publish error");
            LAS_TERRAIN.Tests.CrsDeleteFixture.Published = new List<Vector4D>(_points);
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.OnPublish != null)
                LAS_TERRAIN.Tests.CrsDeleteFixture.OnPublish();
#if PLAN_DELETE_TESTS
            if (LAS_TERRAIN.Tests.PlanDeleteFixture.MutatePolygonsOnPublish)
                LAS_TERRAIN.Tests.PlanDeleteFixture.PolygonsChanged = true;
#endif
            if (LAS_TERRAIN.Tests.CrsDeleteFixture.CancelAfterPublish)
                Topomatic.Controls.WaitProgress.CancellationPending = true;
        }
        public void Dispose() { }
    }
}
#endif
