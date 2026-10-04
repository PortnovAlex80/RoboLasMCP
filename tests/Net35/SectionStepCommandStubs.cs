using System;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public delegate void MethodInvoker();
}

namespace Topomatic.Cad.Foundation
{
    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
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
        public bool InvokeRequired;
        public void Invoke(System.Windows.Forms.MethodInvoker action) { action(); }
    }
}
namespace Topomatic.Alg
{
    public sealed class Section
    {
        public uint Id;
        public uint ConstructionId;
        public object SectionLine;
        public double Station;
        public Section(double station)
        { Station = station; Id = (uint)(station + 100); SectionLine = new object(); }
    }
    public sealed class FakeTransactionManager { }
    public sealed class SectionList : List<Section>
    {
        public FakeTransactionManager TransactionManager = new FakeTransactionManager();
        public int FailAfterAdds = -1;
        public void Add(double station)
        {
            if (FailAfterAdds == 0) throw new InvalidOperationException("injected add failure");
            if (FailAfterAdds > 0) FailAfterAdds--;
            Add(new Section(station));
        }
    }
    public sealed class Corridor
    {
        public SectionList Sections = new SectionList();
    }
    public sealed class CompoundLine
    {
        public double Length = 3.0;
    }
    public sealed class Plan
    {
        public CompoundLine CompoundLine = new CompoundLine();
    }
    public sealed class Alignment
    {
        public Corridor Corridor = new Corridor();
        public Plan Plan = new Plan();
    }
}
namespace Topomatic.Alg.Crs { }
public static class UpdateLoop
{
    private static Topomatic.Alg.Section[] previous;
    public static void BeginTransaction(Topomatic.Alg.SectionList sections)
    { previous = sections.ToArray(); }
    public static void Commit(Topomatic.Alg.SectionList sections)
    { previous = null; }
    public static void Rollback(Topomatic.Alg.SectionList sections)
    {
        sections.Clear();
        sections.AddRange(previous);
        previous = null;
    }
}
namespace Topomatic.ApplicationPlatform.Plugins { }
namespace Topomatic.ApplicationPlatform
{
    public sealed class ApplicationHost
    {
        public static ApplicationHost Current = new ApplicationHost();
        public object ActiveProject;
        public object ActiveDocument;
    }
}
namespace Topomatic.Sfc
{
    public sealed class Surface { }
}
namespace Topomatic.Sfc.Layer
{
    using Topomatic.Cad.View;
    public sealed class SurfaceLayer
    {
        public Topomatic.Sfc.Surface Surface = new Topomatic.Sfc.Surface();
        public static SurfaceLayer GetSurfaceLayer(CadView view)
        { return LAS_TERRAIN.Tests.SectionStepFixture.Layer; }
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
    { public static bool OnePassActive; }
}
namespace LAS_TERRAIN.Application
{
    public sealed class SurfaceApplyException : Exception
    {
        public bool UpdateStateUnknown;
        public bool PointsRestored = true;
        public SurfaceApplyException(string message) : base(message) { }
    }
    public sealed class TopomaticSurfaceWriter
    {
        private readonly Func<bool> valid;
        public static int ApplyCalls;
        public static bool SawCommittedSections;
        public static bool FailApply;
        public TopomaticSurfaceWriter(Topomatic.Sfc.Surface surface, Func<bool> valid)
        { this.valid = valid; }
        public void Apply(List<Topomatic.Cad.Foundation.Vector3D> points)
        {
            if (!valid()) throw new InvalidOperationException("stale surface target");
            ApplyCalls++;
            SawCommittedSections = LAS_TERRAIN.Tests.SectionStepFixture.Alignment
                .Corridor.Sections.Count > 1;
            if (FailApply) throw new SurfaceApplyException("injected surface failure");
        }
    }
}
namespace LAS_TERRAIN.Domain.Service { }
namespace LAS_TERRAIN.Models
{
    public sealed class LasFilterOptions
    {
        public double HalfBorder;
        public bool Async;
        public static LasFilterOptions FromThickness(double thickness, bool async)
        { return new LasFilterOptions { HalfBorder = thickness / 2, Async = async }; }
    }
}
namespace LAS_TERRAIN.Infrastructure
{
    using Topomatic.Alg;
    using Topomatic.Cad.View;
    using Topomatic.Sfc.Layer;
    public static class UserDialogs
    {
        public static bool IsCadViewValid(CadView view) { return view != null; }
        public static SurfaceLayer GetSurfaceLayerOrShow(CadView view)
        { return LAS_TERRAIN.Tests.SectionStepFixture.Layer; }
        public static Alignment SelectAlignment(CadView view)
        { return LAS_TERRAIN.Tests.SectionStepFixture.Alignment; }
        public static double? GetSectionStep(CadView view, double defaultStep)
        { return LAS_TERRAIN.Tests.SectionStepFixture.NextSectionStep(defaultStep); }
        public static double? GetBorderThickness(CadView view, double defaultThickness)
        { return 0.25; }
        public static void ShowWarning(string warning)
        { LAS_TERRAIN.Tests.SectionStepFixture.Warnings.Add(warning); }
    }
    public static class PluginCoreOps
    {
        public static object FindModel(Alignment alignment)
        { return LAS_TERRAIN.Tests.SectionStepFixture.Model; }
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Alignment alignment)
        { return LAS_TERRAIN.Tests.SectionStepFixture.AlignmentId; }
    }
}
namespace LAS_TERRAIN.Service.Collector
{
    using LAS_TERRAIN.Application;
    using LAS_TERRAIN.Models;
    using Topomatic.Alg;
    using Topomatic.Cad.Foundation;
    using Topomatic.Lidar;
    public sealed class FilterOperationSnapshot { }
    public static class FilterSettingsSnapshotAdapter
    {
        public static FilterOperationSnapshot Capture()
        { return new FilterOperationSnapshot(); }
    }
    internal static class GroundPointsCollector
    {
        public static OperationResult<List<Vector3D>> NextStationResult =
            OperationResult<List<Vector3D>>.Empty();
        public static OperationResult<List<Vector3D>> NextPilotResult =
            OperationResult<List<Vector3D>>.Empty();
        public static Action DuringPilotCollect;
        public static Action DuringStationCollect;
        public static bool SawOriginalSections;
        public static int StationCalls;
        public static int PilotCalls;
        public static bool MutateSectionsDuringCollect;
        public static OperationResult<List<Vector3D>> CollectAtStations(Alignment alignment,
            List<LidarBuffer> buffers, IList<double> stations, LasFilterOptions options,
            FilterOperationSnapshot settings, bool onePass)
        {
            StationCalls++;
            if (DuringStationCollect != null) DuringStationCollect();
            SawOriginalSections = alignment.Corridor.Sections.Count == 1 &&
                Object.ReferenceEquals(alignment.Corridor.Sections[0],
                    LAS_TERRAIN.Tests.SectionStepFixture.OriginalSection);
            if (MutateSectionsDuringCollect)
                alignment.Corridor.Sections.Add(new Section(99.0));
            return NextStationResult;
        }
        public static OperationResult<List<Vector3D>> CollectPilot(Alignment alignment,
            List<LidarBuffer> buffers, List<Section> sections, LasFilterOptions options,
            object progress, FilterOperationSnapshot settings, bool onePass)
        {
            PilotCalls++;
            if (DuringPilotCollect != null) DuringPilotCollect();
            return NextPilotResult;
        }
    }
}
namespace Topomatic.Lidar
{
    public sealed class PointArray
    {
        public object[] Values = new object[0];
        public int Count { get { return Values.Length; } }
        public object[] GetBuffer() { return Values; }
    }
    public sealed class WeightArray
    {
        public byte[] Values = new byte[0];
        public int Count { get { return Values.Length; } }
        public byte[] GetBuffer() { return Values; }
    }
    public sealed class QuadTreeIndexer
    {
        public PointArray points = new PointArray();
        public WeightArray weights = new WeightArray();
        public Topomatic.Cad.Foundation.Vector3D scale;
        public Topomatic.Cad.Foundation.Vector3D position;
    }
    public sealed class LidarBuffer
    {
        public string fullpath = "fixture.las";
        public List<QuadTreeIndexer> indexers = new List<QuadTreeIndexer>();
    }
}
namespace LAS_TERRAIN.Service
{
    using LAS_TERRAIN.Application;
    using Topomatic.Alg;
    using Topomatic.Cad.Foundation;
    using Topomatic.Cad.View;
    using Topomatic.Lidar;
    using Topomatic.Sfc;
    public static class LidarBufferService
    {
        public static List<LidarBuffer> Buffers =
            new List<LidarBuffer> { new LidarBuffer() };
        public static List<LidarBuffer> CollectBuffers(Alignment alignment)
        { return Buffers; }
        public static bool ValidateBuffers(List<LidarBuffer> buffers) { return true; }
    }
}
