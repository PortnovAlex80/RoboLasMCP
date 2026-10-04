using System;
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using Topomatic.Cad.Foundation;

// Host boundary doubles; the production probe and density calculations are compiled unchanged.
namespace Topomatic.Cad.Foundation
{
    public struct Vector2D { public double X,Y; public Vector2D(double x,double y) { X=x;Y=y; } }
    public struct Vector4D { public double X,Y,Z,W; public Vector4D(double x,double y,double z) { X=x;Y=y;Z=z;W=0; } }
}
namespace Topomatic.Alg
{
    public class Line
    {
        public double Length=100;
        public bool StaOffsetToPos(double station,double offset,out Vector2D value)
        { value=new Vector2D(offset,station); return true; }
    }
    public class Plan { public Line CompoundLine=new Line(); }
    public class Alignment { public string Alias="Test"; public double DtmSizeLeft=2,DtmSizeRight=2; public Plan Plan=new Plan(); }
}
namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public class ActiveAlignmentReciver<T> : IDisposable where T:class
    {
        public T Alignment;
        public static ActiveAlignmentReciver<T> CreateReciver(bool ignored)
        { return new ActiveAlignmentReciver<T> { Alignment=LAS_TERRAIN.Automation.LasAutomation.TestAlignment as T }; }
        public void Dispose() {}
    }
}
namespace LAS_TERRAIN.Models
{
    public class LasFilterOptions
    {
        public double HalfBorder;
        public static LasFilterOptions FromThickness(double thickness,bool async)
        { return new LasFilterOptions { HalfBorder=thickness/2 }; }
    }
}
namespace LAS_TERRAIN.Service
{
    public static class LidarBufferService
    {
        public static List<int> Buffers=new List<int> {1};
        public static List<int> CollectBuffers(Topomatic.Alg.Alignment a) { return Buffers; }
    }
}
namespace LAS_TERRAIN.Infrastructure
{
    public class LasExportSourceContext
    {
        public static bool ChangesAfterRead;
        private int _checks;
        public static LasExportSourceContext Capture(object view,Topomatic.Alg.Alignment a,List<int> buffers)
        { return new LasExportSourceContext(); }
        public bool IsCurrent() { return !ChangesAfterRead || ++_checks==1; }
    }
}
namespace LAS_TERRAIN.Service.Collector
{
    public enum SectionCollectStatus { Success,Overflow,Cancelled }
    public static class LasSectionPointsCollectorService
    {
        public static List<Vector4D> Points=new List<Vector4D>();
        public static double LastHalfBorder;
        public static SectionCollectStatus Status=SectionCollectStatus.Success;
        public static void StreamRawAtStation(Topomatic.Alg.Alignment alg,List<int> buffers,double station,
            LAS_TERRAIN.Models.LasFilterOptions options,Action<Vector4D> accept,Func<bool> cancellation,out SectionCollectStatus status)
        { LastHalfBorder=options.HalfBorder; foreach(var p in Points) accept(p); status=Status; }
    }
}
namespace LAS_TERRAIN.Automation
{
    public class LasAutomationException : Exception { public LasAutomationException(string value):base(value) {} }
    public static partial class LasAutomation
    {
        public static Topomatic.Alg.Alignment TestAlignment=new Topomatic.Alg.Alignment();
        private class Lease : IDisposable { public void Dispose() {} }
        private static IDisposable EnterGate() { return new Lease(); }
        private static object RequireCadView() { return new object(); }
        private static Topomatic.Alg.Alignment RequireAlignment(Topomatic.Alg.Runtime.ServiceClasses.ActiveAlignmentReciver<Topomatic.Alg.Alignment> r) { return r.Alignment; }
        private const string NoLidarSourceMessage="No source",SourceChangedMessage="Changed source";
    }
}
internal static class SectionProbeTests
{
    private static int _checks;
    private static void Check(bool v,string label) { _checks++; if(!v)throw new Exception(label); }
    private static void Reject(Action action,string label)
    { bool v=false;try { action(); }catch(ArgumentException) { v=true; }catch(LasAutomationException) { v=true; } Check(v,label); }
    public static int Main()
    {
        var collector=LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Points;
        collector.Add(new Vector4D(-1,9.9,4)); collector.Add(new Vector4D(0,10,5));collector.Add(new Vector4D(1,10.1,6));
        var r=LasAutomation.GetSectionPoints(10,.4,1,.1,1,1);
        Check(r.TotalPoints==3 && r.ReturnedPoints==1 && r.NextPointOffset==2,"page preserves full count");
        Check(r.Points[0].Offset==0 && r.Points[0].Elevation==5 && r.Points[0].SliceDistance==0,"local frame from SDK endpoints");
        Check(r.OffsetDensity.PointCount==3 && r.ElevationDensity.PointCount==3 && r.SliceDistanceDensity.PointCount==3,"all axes use full cloud");
        Check(LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.LastHalfBorder==.2,"full thickness converted once");
        r=LasAutomation.GetSectionPoints(10,.4,1,.1,2,2);
        Check(r.Points.Count==1 && r.NextPointOffset==null && Math.Abs(r.Points[0].SliceDistance+.1)<1e-9,"last page and signed SDK normal");
        r=LasAutomation.GetSectionPoints(10,.4,1,.1,99,2);
        Check(r.Points.Count==0 && r.NextPointOffset==null && r.TotalPoints==3,"out of range page still returns full stats");
        collector.Clear(); r=LasAutomation.GetSectionPoints(10,.4,1,.1,0,2);
        Check(r.TotalPoints==0 && r.OffsetDensity.EmptyBins==4 && r.Points.Count==0,"empty slice remains successful");
        Reject(delegate { LasAutomation.GetSectionPoints(101,.4,1,.1,0,2); },"station outside alignment");
        Reject(delegate { LasAutomation.GetSectionPoints(double.NaN,.4,1,.1,0,2); },"NaN station");
        Reject(delegate { LasAutomation.GetSectionPoints(10,0,1,.1,0,2); },"zero thickness");
        Reject(delegate { LasAutomation.GetSectionPoints(10,.4,1,.1,0,10001); },"response cap");
        Reject(delegate { LasAutomation.GetSectionPoints(10,.4,.00001,.1,0,2); },"bin cap before collection");
        LAS_TERRAIN.Service.LidarBufferService.Buffers.Clear();
        Reject(delegate { LasAutomation.GetSectionPoints(10,.4,1,.1,0,2); },"missing source");
        LAS_TERRAIN.Service.LidarBufferService.Buffers.Add(1);
        LAS_TERRAIN.Infrastructure.LasExportSourceContext.ChangesAfterRead=true;
        Reject(delegate { LasAutomation.GetSectionPoints(10,.4,1,.1,0,2); },"changed source rejects stats");
        LAS_TERRAIN.Infrastructure.LasExportSourceContext.ChangesAfterRead=false;
        LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Status=LAS_TERRAIN.Service.Collector.SectionCollectStatus.Overflow;
        Reject(delegate { LasAutomation.GetSectionPoints(10,.4,1,.1,0,2); },"overflow never publishes partial stats");
        Console.WriteLine("PASS "+_checks+" section probe checks");return 0;
    }
}
