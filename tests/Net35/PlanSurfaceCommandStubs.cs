using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Windows.Forms
{
    public delegate void MethodInvoker();
    public enum MessageBoxButtons { OK }
    public enum MessageBoxIcon { Error, Warning, Information }
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
    public struct BoundingBox2D
    {
        public Vector2D Min, Max;
        public BoundingBox2D(Vector2D min, Vector2D max) { Min = min; Max = max; }
    }
}

namespace Topomatic.Cad.View
{
    public sealed class CadView
    {
        public int Invalidations;
        public bool IsDisposed;
        public bool IsHandleCreated = true;
        public bool InvokeRequired;
        public int InvokeCount;
        public void Invoke(System.Windows.Forms.MethodInvoker work)
        { InvokeCount++; work(); }
        public void Unlock() { }
        public void Invalidate() { Invalidations++; }
    }
}

namespace Topomatic.Alg
{
    public sealed class Alignment
    {
        public Guid Id = Guid.NewGuid();
        public Topomatic.ApplicationPlatform.Plugins.FakeModel Model;
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Alignment alignment) { return alignment.Id; }
    }
}

namespace Topomatic.ApplicationPlatform
{
    public sealed class Project { }
    public sealed class ApplicationHost
    {
        public static ApplicationHost Current;
        public Project ActiveProject;
        public object ActiveDocument;
    }
}

namespace Topomatic.ApplicationPlatform.Plugins
{
    public sealed class FakeModel
    {
        public Topomatic.ApplicationPlatform.Project Project;
    }
    public static class PluginCoreOps
    {
        public static FakeModel FindModel(Topomatic.Alg.Alignment alignment)
        { return alignment == null ? null : alignment.Model; }
    }
}

namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public sealed class ActiveAlignmentReciver<T> : IDisposable
    {
        public T Alignment;
        public static ActiveAlignmentReciver<T> CreateReciver(bool unused)
        {
            LAS_TERRAIN.Tests.PlanSurfaceFixture.ReceiverCalls++;
            return new ActiveAlignmentReciver<T> { Alignment =
                (T)(object)LAS_TERRAIN.Tests.PlanSurfaceFixture.Alignment };
        }
        public void Dispose() { }
    }
}

namespace Topomatic.Lidar
{
    using Topomatic.Cad.Foundation;
    public sealed class PointArray
    {
        public Vector3F[] Values;
        public int DelayCountMs;
        public int Count
        {
            get
            {
                if (DelayCountMs > 0) Thread.Sleep(DelayCountMs);
                return Values.Length;
            }
        }
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
        public WeightArray weights = new WeightArray();
        public Vector3D scale = new Vector3D(1, 1, 1);
        public Vector3D position;
    }
    public sealed class LidarBuffer
    {
        public string fullpath = @"C:\fixture\cloud.las";
        public List<QuadTreeIndexer> indexers = new List<QuadTreeIndexer>();
    }
}

namespace Topomatic.Sfc
{
    public sealed class Surface { }
}

namespace Topomatic.Sfc.Layer
{
    public sealed class SurfaceLayer
    {
        public static SurfaceLayer Current;
        public Topomatic.Sfc.Surface Surface = new Topomatic.Sfc.Surface();
        public static SurfaceLayer GetSurfaceLayer(Topomatic.Cad.View.CadView view)
        { return Current; }
    }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
        public static int Stage;
        public static void BeginProgress(string title, Action work, bool cancellable)
        {
            Stage++;
            LAS_TERRAIN.Tests.PlanSurfaceFixture.Visits = 0;
            work();
            CancellationPending = false;
        }
    }
}

namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static readonly List<string> Messages = new List<string>();
        public static void Show(string message) { Messages.Add(message); }
        public static void Show(string message, System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon)
        {
            Messages.Add(message);
        }
    }
}

namespace Topomatic.FoundationClasses.Parallel
{
    public static class Parallel
    {
        public static bool Reverse;
        public static bool Concurrent;

        public static void ForEach<T>(IEnumerable<T> items, Action<T> work)
        {
            var scheduled = new List<T>(items);
            if (Reverse) scheduled.Reverse();
            if (!Concurrent)
            {
                foreach (T item in scheduled) work(item);
                return;
            }
            var threads = new Thread[scheduled.Count];
            Exception error = null;
            object errorSync = new object();
            for (int i = 0; i < scheduled.Count; i++)
            {
                T item = scheduled[i];
                threads[i] = new Thread(delegate()
                {
                    try { work(item); }
                    catch (Exception caught)
                    {
                        lock (errorSync) { if (error == null) error = caught; }
                    }
                });
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++) threads[i].Join();
            if (error != null) throw error;
        }
    }
}

namespace LAS_TERRAIN
{
    using Topomatic.Cad.View;
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SectionCmdAttribute : Attribute
    {
        public SectionCmdAttribute(string name) { }
    }
    public interface ISectionUseCase
    {
        string Name { get; }
        void Run(SectionEnv env);
    }
    public sealed class SectionEnv
    {
        public CadView CadView;
        public SectionEnv(CadView view) { CadView = view; }
    }
}

namespace LAS_TERRAIN.Configuration
{
    using LAS_TERRAIN.Domain.Models;
    public static class RuntimeConfig
    {
        public static double GridStep = 1;
        public static int PolynomialDegree = 1;
        public static double PolynomialRegularization = 0.01;
        public static double PolynomialGridStep = 1;
        internal static PlanSurfaceSettings CapturePlanSurfaceSettings()
        {
            return new PlanSurfaceSettings(GridStep, PolynomialDegree,
                PolynomialRegularization, PolynomialGridStep);
        }
    }
}

namespace LAS_TERRAIN.Domain.Models
{
    using Topomatic.Cad.Foundation;
    public sealed class PlanPolygonEntry
    {
        public DateTime CreatedAt;
        public List<Vector2D> Polygon = new List<Vector2D>();
    }
}

namespace LAS_TERRAIN.Domain.Service
{
    using LAS_TERRAIN.Domain.Models;
    using Topomatic.Cad.Foundation;
    using Topomatic.Sfc;

    internal sealed class SurfaceApplyException : InvalidOperationException
    {
        internal bool UpdateStateUnknown { get; private set; }
        internal SurfaceApplyException(string message, bool updateStateUnknown)
            : base(message) { UpdateStateUnknown = updateStateUnknown; }
    }

    public static class PlanPolygonCollection
    {
        public static void Initialize(string path)
        { LAS_TERRAIN.Tests.PlanSurfaceFixture.InitializedPath = path; }
        public static List<PlanPolygonEntry> GetAll()
        { return LAS_TERRAIN.Tests.PlanSurfaceFixture.Polygons; }
    }
    public static class PolygonGeometry
    {
        public static bool Contains(double x, double y, List<Vector2D> polygon)
        {
            LAS_TERRAIN.Tests.PlanSurfaceFixture.VisitPoint();
            return x >= 0 && x <= 10 && y >= 0 && y <= 10;
        }
    }
    public static class PolygonBounds
    {
        public static bool TryCompute(List<PlanPolygonEntry> polygons, out BoundingBox2D bounds)
        {
            bounds = new BoundingBox2D(new Vector2D(0, 0), new Vector2D(10, 10));
            return true;
        }
    }
    public static class FastSurfaceBuilder
    {
        public static int Calls;
        public static int PointCount;
        public static bool ThrowOnInsert;
        public static bool ThrowUnknownOnInsert;
        public static void InsertPoints(List<Vector3D> points, Surface surface)
        {
            if (ThrowUnknownOnInsert)
                throw new SurfaceApplyException("injected uncertain update", true);
            if (ThrowOnInsert) throw new InvalidOperationException("injected surface insert error");
            Calls++;
            PointCount = points.Count;
        }
    }
    public static class PolynomialSurfaceFitter
    {
        public static int Calls;
        public static int InputCount;
        public static int CapturedDegree;
        public static double CapturedRegularization;
        public static double CapturedGridStep;
        public static List<Vector3D> FitSurface(List<Vector3D> points, int degree,
            double regularization, double gridStep, BoundingBox2D bounds)
        {
            Calls++;
            InputCount = points.Count;
            CapturedDegree = degree;
            CapturedRegularization = regularization;
            CapturedGridStep = gridStep;
            return new List<Vector3D>(points);
        }
    }
}

namespace LAS_TERRAIN.Infrastructure
{
    using LAS_TERRAIN.Domain.Persistence;
    using Topomatic.Alg;
    using Topomatic.Cad.View;
    using Topomatic.Lidar;
    using Topomatic.Sfc.Layer;
    internal sealed class ScopedPolygonOperationContext
    {
        private readonly PolygonTestOwnerContext source;
        private readonly int revision;
        private ScopedPolygonOperationContext(PolygonTestOwnerContext source)
        { this.source = source; revision = LAS_TERRAIN.Tests.PlanSurfaceFixture.PolygonRevision; }
        internal static ScopedPolygonOperationContext Capture(CadView view, PolygonGeometryKind kind)
        {
            PolygonTestOwnerContext source = PolygonTestOwnerContext.Capture(view);
            return source == null ? null : new ScopedPolygonOperationContext(source);
        }
        internal bool TryRead(out ScopedPolygonSnapshot snapshot)
        {
            var records = new List<ScopedPolygonRecord>();
            foreach (var polygon in LAS_TERRAIN.Tests.PlanSurfaceFixture.Polygons)
                records.Add(ScopedPolygonRecord.Plan(polygon.CreatedAt, polygon.Polygon));
            snapshot = new ScopedPolygonSnapshot("plan-surface", revision.ToString(), records);
            return IsCurrent();
        }
        internal bool IsCurrent() { return source.IsCurrent(); }
        internal bool IsSourceCurrent() { return source.IsSourceCurrent(); }
        internal bool MatchesCapturedSource(Alignment alignment, List<LidarBuffer> buffers)
        { return source.MatchesCapturedSource(alignment, buffers); }
        internal bool IsSnapshotCurrent(ScopedPolygonSnapshot snapshot)
        {
            return IsCurrent() && snapshot != null &&
                snapshot.Revision == LAS_TERRAIN.Tests.PlanSurfaceFixture.PolygonRevision.ToString();
        }
    }
    public static class UserDialogs
    {
        public static bool IsCadViewValid(CadView view) { return view != null; }
        public static SurfaceLayer GetSurfaceLayerOrShow(CadView view)
        { return SurfaceLayer.GetSurfaceLayer(view); }
    }
}

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;
    public static class LidarBufferService
    {
        public static List<LidarBuffer> CollectBuffers(Alignment alignment)
        {
            LAS_TERRAIN.Tests.PlanSurfaceFixture.BufferCollections++;
            return LAS_TERRAIN.Tests.PlanSurfaceFixture.Buffers;
        }
    }
}
