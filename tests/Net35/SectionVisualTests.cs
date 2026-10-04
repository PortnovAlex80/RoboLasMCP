using System;
using System.Collections.Generic;
using LAS_TERRAIN.Automation;
using LAS_TERRAIN.Tests;
using Topomatic.Cad.Foundation;

// Host boundary doubles; the production DTO file, the SectionFrame facade and
// the real Domain\Service\PolygonGeometry.cs are compiled unchanged.
// Стабы повторяют подход SectionProbeTests (коллектор) и CrsDeleteCommandStubs
// (индексеры/writer/WaitProgress); конфликтов с подключаемыми продакшн-файлами нет.
namespace Topomatic.Cad.Foundation
{
    public struct Vector2D { public double X, Y; public Vector2D(double x, double y) { X = x; Y = y; } }
    public struct Vector3D { public double X, Y, Z; public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; } }
    public struct Vector3F { public float X, Y, Z; public Vector3F(float x, float y, float z) { X = x; Y = y; Z = z; } }
    public struct Vector4D
    {
        public double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }
    }
}
namespace Topomatic.Alg
{
    using Topomatic.Cad.Foundation;
    public class Line
    {
        public double Length = 100;
        // Мировая система стаба: StaOffsetToPos(station, offset) = (offset, station).
        // Тогда для сечения на пикете s: offset точки = p.X, SliceDistance = s - p.Y.
        public bool StaOffsetToPos(double station, double offset, out Vector2D value)
        { value = new Vector2D(offset, station); return true; }
    }
    public class Plan { public Line CompoundLine = new Line(); }
    public class Alignment
    {
        public string Alias = "Test";
        public double DtmSizeLeft = 2, DtmSizeRight = 2;
        public Plan Plan = new Plan();
    }
}
namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public class ActiveAlignmentReciver<T> : IDisposable where T : class
    {
        public T Alignment;
        public static ActiveAlignmentReciver<T> CreateReciver(bool ignored)
        { return new ActiveAlignmentReciver<T> { Alignment = LAS_TERRAIN.Tests.SectionVisualFixture.Alignment as T }; }
        public void Dispose() { }
    }
}
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
            try { action(); }
            finally { CancellationPending = false; }
        }
        public static void ProgressChange(float value) { }
    }
}
namespace LAS_TERRAIN.Models
{
    public class LasFilterOptions
    {
        public double HalfBorder;
        public static LasFilterOptions FromThickness(double thickness, bool async)
        { return new LasFilterOptions { HalfBorder = thickness / 2 }; }
    }
}
namespace LAS_TERRAIN.Service
{
    public static class LidarBufferService
    {
        public static List<Topomatic.Lidar.LidarBuffer> CollectBuffers(Topomatic.Alg.Alignment a)
        { return LAS_TERRAIN.Tests.SectionVisualFixture.Buffers; }
    }
}
namespace LAS_TERRAIN.Service.Collector
{
    using Topomatic.Cad.Foundation;
    public enum SectionCollectStatus { Success, Overflow, Cancelled }
    public static class LasSectionPointsCollectorService
    {
        public static List<Vector4D> Points = new List<Vector4D>();
        public static double LastHalfBorder;
        public static SectionCollectStatus Status = SectionCollectStatus.Success;
        // Зеркалирует точный предикат коллектора: |SliceDistance| < HalfBorder
        // (открытый интервал, без IncludePositiveSliceBorder).
        public static void StreamRawAtStation(Topomatic.Alg.Alignment alg,
            List<Topomatic.Lidar.LidarBuffer> buffers, double station,
            LAS_TERRAIN.Models.LasFilterOptions options, Action<Vector4D> accept,
            Func<bool> cancellation, out SectionCollectStatus status)
        {
            LastHalfBorder = options.HalfBorder;
            foreach (Vector4D p in Points)
            {
                double distance = station - p.Y;
                if (distance > -options.HalfBorder && distance < options.HalfBorder)
                    accept(p);
            }
            status = Status;
        }
    }
}
namespace LAS_TERRAIN.Infrastructure
{
    using Topomatic.Cad.Foundation;
    public class LasExportSourceContext
    {
        public static bool ChangesAfterRead;
        private int _checks;
        public static LasExportSourceContext Capture(object view, Topomatic.Alg.Alignment a,
            List<Topomatic.Lidar.LidarBuffer> buffers)
        { return new LasExportSourceContext(); }
        public bool IsCurrent() { return !ChangesAfterRead || ++_checks == 1; }
    }
    public static class MemoryStatus
    { public static int CalcBatchSizeForReduceOnly() { return 65536; } }
    // Стаб ColorAwareLasWriter: считает вызовы и копит удержанные точки.
    internal sealed class ColorAwareLasWriter : IDisposable
    {
        internal Func<bool> IsCancellationRequested;
        internal bool HasRgb = true;
        internal ColorAwareLasWriter(IList<Topomatic.Lidar.LidarBuffer> buffers,
            string path, Func<bool> cancel)
        { LAS_TERRAIN.Tests.SectionVisualFixture.WriterCreated++; }
        internal void CaptureKeptPoint(Topomatic.Lidar.QuadTreeIndexer indexer,
            int point, Vector4D geometry)
        { LAS_TERRAIN.Tests.SectionVisualFixture.CaptureCalls++; }
        internal void WritePoints(List<Vector4D> points)
        {
            LAS_TERRAIN.Tests.SectionVisualFixture.WriteCalls++;
            LAS_TERRAIN.Tests.SectionVisualFixture.WrittenPoints.AddRange(points);
        }
        internal LAS_TERRAIN.IO.PreparedLasFile Complete()
        {
            LAS_TERRAIN.Tests.SectionVisualFixture.CompleteCalls++;
            return new LAS_TERRAIN.IO.PreparedLasFile(
                LAS_TERRAIN.Tests.SectionVisualFixture.WrittenPoints);
        }
        public void Dispose() { }
    }
}
namespace LAS_TERRAIN.IO
{
    using Topomatic.Cad.Foundation;
    public sealed class PreparedLasFile : IDisposable
    {
        private readonly List<Vector4D> _points;
        public PreparedLasFile(List<Vector4D> points)
        { _points = new List<Vector4D>(points); }
        public void Publish()
        {
            LAS_TERRAIN.Tests.SectionVisualFixture.PublishCalls++;
            LAS_TERRAIN.Tests.SectionVisualFixture.Published = new List<Vector4D>(_points);
        }
        public void Dispose() { }
    }
}
namespace LAS_TERRAIN.Automation
{
    public class LasAutomationException : Exception
    { public LasAutomationException(string value) : base(value) { } }
    // Приватные члены других partial-частей фасада (LasAutomation.cs, Export.cs,
    // Polygons.cs) воспроизведены стабами — продакшн-файлы не компилируются.
    public static partial class LasAutomation
    {
        private class Lease : IDisposable { public void Dispose() { } }
        private static IDisposable EnterGate() { return new Lease(); }
        private static object RequireCadView() { return new object(); }
        private static Topomatic.Alg.Alignment RequireAlignment(
            Topomatic.Alg.Runtime.ServiceClasses.ActiveAlignmentReciver<Topomatic.Alg.Alignment> r)
        { return r.Alignment; }
        private static string ValidateLasPath(string outputPath)
        {
            if (string.IsNullOrEmpty(outputPath))
                throw new LasAutomationException("output_path обязателен.");
            if (!string.Equals(System.IO.Path.GetExtension(outputPath), ".las",
                StringComparison.OrdinalIgnoreCase))
                throw new LasAutomationException("Путь должен заканчиваться на .las: " + outputPath);
            return outputPath;
        }
        private static List<Topomatic.Lidar.QuadTreeIndexer> CollectIndexers(
            List<Topomatic.Lidar.LidarBuffer> buffers)
        {
            var indexerList = new List<Topomatic.Lidar.QuadTreeIndexer>();
            foreach (Topomatic.Lidar.LidarBuffer buffer in buffers)
            {
                if (buffer == null || buffer.indexers == null) continue;
                foreach (Topomatic.Lidar.QuadTreeIndexer indexer in buffer.indexers)
                    if (indexer != null && indexer.points != null)
                        indexerList.Add(indexer);
            }
            return indexerList;
        }
        private const string NoLidarSourceMessage = "No source", SourceChangedMessage = "Changed source";
    }
}
namespace LAS_TERRAIN.Tests
{
    public static class SectionVisualFixture
    {
        public static Topomatic.Alg.Alignment Alignment;
        public static List<Topomatic.Lidar.LidarBuffer> Buffers;
        public static List<Topomatic.Cad.Foundation.Vector4D> WrittenPoints =
            new List<Topomatic.Cad.Foundation.Vector4D>();
        public static List<Topomatic.Cad.Foundation.Vector4D> Published;
        public static int WriterCreated, WriteCalls, CompleteCalls, PublishCalls, CaptureCalls;
        public static void Reset()
        {
            Alignment = new Topomatic.Alg.Alignment();
            Buffers = new List<Topomatic.Lidar.LidarBuffer> { new Topomatic.Lidar.LidarBuffer() };
            WrittenPoints = new List<Topomatic.Cad.Foundation.Vector4D>();
            Published = null;
            WriterCreated = WriteCalls = CompleteCalls = PublishCalls = CaptureCalls = 0;
            LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Points.Clear();
            LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Status =
                LAS_TERRAIN.Service.Collector.SectionCollectStatus.Success;
            LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.LastHalfBorder = 0;
            LAS_TERRAIN.Infrastructure.LasExportSourceContext.ChangesAfterRead = false;
            Topomatic.Controls.WaitProgress.CancellationPending = false;
            Topomatic.Controls.WaitProgress.Calls = 0;
        }
        // Синтетическое облако: один индексер, scale=1, position=0, веса i+1.
        public static void SetCloud(params double[][] xyz)
        {
            var pts = new Topomatic.Cad.Foundation.Vector3F[xyz.Length];
            var wts = new byte[xyz.Length];
            for (int i = 0; i < xyz.Length; i++)
            {
                pts[i] = new Topomatic.Cad.Foundation.Vector3F(
                    (float)xyz[i][0], (float)xyz[i][1], (float)xyz[i][2]);
                wts[i] = (byte)(i + 1);
            }
            Buffers[0].indexers.Add(new Topomatic.Lidar.QuadTreeIndexer
            {
                points = new Topomatic.Lidar.PointArray { Values = pts },
                weights = new Topomatic.Lidar.WeightArray { Values = wts },
                scale = new Topomatic.Cad.Foundation.Vector3D(1, 1, 1),
                position = new Topomatic.Cad.Foundation.Vector3D(0, 0, 0)
            });
        }
    }
}
internal static class SectionVisualTests
{
    private static int _checks;
    private static void Check(bool v, string label) { _checks++; if (!v) throw new Exception(label); }
    private static void Reject(Action action, string label)
    {
        bool seen = false;
        try { action(); }
        catch (ArgumentException) { seen = true; }
        catch (LasAutomationException) { seen = true; }
        Check(seen, label);
    }

    private static double[][] Square(double x0, double z0, double x1, double z1)
    {
        return new double[][] { new double[] { x0, z0 }, new double[] { x1, z0 },
            new double[] { x1, z1 }, new double[] { x0, z1 } };
    }
    private static double[][][] ManyPolygons(int count)
    {
        var polygons = new double[count][][];
        for (int i = 0; i < count; i++) polygons[i] = Square(0, 0, 1, 1);
        return polygons;
    }
    // DTO секции: 1..50 полигонов (Polygons = [[[offset, Z], ...], ...]).
    private static LasSectionPolygonSpec Spec(double station, double thickness, double[][] polygon)
    { return new LasSectionPolygonSpec { Station = station, Thickness = thickness,
        Polygons = new double[][][] { polygon } }; }
    private static LasSectionPolygonSpec Spec(double station, double thickness, double[][][] polygons)
    { return new LasSectionPolygonSpec { Station = station, Thickness = thickness, Polygons = polygons }; }

    // 1) Валидация аргументов всех трёх публичных методов.
    private static void ValidationTests()
    {
        SectionVisualFixture.Reset();
        Reject(delegate { LasAutomation.GetSectionFrame(double.NaN, 1, 10); }, "frame NaN station");
        Reject(delegate { LasAutomation.GetSectionFrame(-1, 1, 10); }, "frame negative station");
        Reject(delegate { LasAutomation.GetSectionFrame(0, 0, 10); }, "frame zero thickness");
        Reject(delegate { LasAutomation.GetSectionFrame(0, double.NaN, 10); }, "frame NaN thickness");
        Reject(delegate { LasAutomation.GetSectionFrame(0, 1, 0); }, "frame maxStoredPoints low");
        Reject(delegate { LasAutomation.GetSectionFrame(0, 1, 1000001); }, "frame maxStoredPoints high");
        Reject(delegate { LasAutomation.GetSectionFrame(101, 1, 10); }, "frame station beyond alignment");

        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 0, ManyPolygons(1)); }, "preview zero thickness");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, double.NaN, ManyPolygons(1)); }, "preview NaN thickness");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(double.NaN, 1, ManyPolygons(1)); }, "preview NaN station");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 1, null); }, "preview null polygons");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 1, new double[][][] { }); }, "preview no polygons");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 1, new double[][][] {
            new double[][] { new double[] { 0, 0 }, new double[] { 1, 0 } } }); }, "preview two vertices");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 1, new double[][][] {
            new double[][] { new double[] { 0, 0 }, new double[] { double.NaN, 0 }, new double[] { 1, 1 } } }); },
            "preview NaN vertex");
        Reject(delegate { LasAutomation.PreviewSectionPolygons(10, 1, ManyPolygons(51)); }, "preview too many polygons");

        Reject(delegate { LasAutomation.DeleteSectionPoints(null, @"C:\fixture\out.las"); }, "delete null sections");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new LasSectionPolygonSpec[0], @"C:\fixture\out.las"); },
            "delete empty sections");
        LasSectionPolygonSpec[] many = new LasSectionPolygonSpec[201];
        for (int i = 0; i < many.Length; i++) many[i] = Spec(0, 1, Square(0, 0, 1, 1));
        Reject(delegate { LasAutomation.DeleteSectionPoints(many, @"C:\fixture\out.las"); }, "delete too many sections");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(0, 1, Square(0, 0, 1, 1)) }, null); },
            "delete null path");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(0, 1, Square(0, 0, 1, 1)) }, @"C:\fixture\out.txt"); },
            "delete non-las path");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new LasSectionPolygonSpec[] { null }, @"C:\fixture\out.las"); },
            "delete null spec");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(0, 0, Square(0, 0, 1, 1)) }, @"C:\fixture\out.las"); },
            "delete zero thickness");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(-1, 1, Square(0, 0, 1, 1)) }, @"C:\fixture\out.las"); },
            "delete negative station");
        Reject(delegate
        {
            LasAutomation.DeleteSectionPoints(new LasSectionPolygonSpec[] {
                Spec(0, 1, new double[][] { new double[] { 0, 0 }, new double[] { 1, 0 } })
            }, @"C:\fixture\out.las");
        }, "delete two-vertex polygon");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(0, 1, new double[][][] { }) },
            @"C:\fixture\out.las"); }, "delete section without polygons");
        Reject(delegate { LasAutomation.DeleteSectionPoints(new[] { Spec(101, 1, Square(0, 0, 1, 1)) }, @"C:\fixture\out.las"); },
            "delete station beyond alignment");
        Console.WriteLine("validation checks passed");
    }

    // 2) Предикат призмы IsPointInSectionPrism: открытые границы thickness,
    //    полигон в (offset, Z), точки за пределами поперечника.
    private static void PrismPredicateTests()
    {
        // Геометрия: LeftMost=(0,0), орт вдоль X, нормаль +Y, DtmLeft=5
        // (полоса along [0..10] ↔ offset [-5..+5]).
        LasAutomation.SectionPrismGeom geometry = new LasAutomation.SectionPrismGeom
        {
            LeftMost = new Vector2D(0, 0),
            DirX = 1, DirY = 0,
            NormalX = 0, NormalY = 1,
            DtmLeft = 5
        };
        List<Vector2D> polygon = new List<Vector2D>();
        foreach (double[] v in Square(-4, 0, 4, 8)) polygon.Add(new Vector2D(v[0], v[1]));
        double halfThickness = 1;
        Check(LasAutomation.IsPointInSectionPrism(2, 0, 4, geometry, halfThickness, polygon),
            "prism: point at full thickness inside polygon");
        Check(LasAutomation.IsPointInSectionPrism(2, 0.999, 4, geometry, halfThickness, polygon),
            "prism: point just inside thickness");
        Check(!LasAutomation.IsPointInSectionPrism(2, 1, 4, geometry, halfThickness, polygon),
            "prism: exact +thickness/2 border excluded (open interval)");
        Check(!LasAutomation.IsPointInSectionPrism(2, -1, 4, geometry, halfThickness, polygon),
            "prism: exact -thickness/2 border excluded (open interval)");
        Check(!LasAutomation.IsPointInSectionPrism(2, 2, 4, geometry, halfThickness, polygon),
            "prism: beyond thickness excluded");
        Check(!LasAutomation.IsPointInSectionPrism(2, 0.5, 12, geometry, halfThickness, polygon),
            "prism: inside thickness but outside polygon");
        // along = wx - 0 < 0 → offset < -DtmSizeLeft: за пределами поперечника,
        // полигон полосы такую точку не накрывает.
        Check(!LasAutomation.IsPointInSectionPrism(-5.5, 0, 4, geometry, halfThickness, polygon),
            "prism: inside polygon plane but before section start (along<0)");
        Console.WriteLine("prism predicate checks passed");
    }

    // 3) GetSectionFrame на стаб-коллекторе.
    private static void FrameTests()
    {
        SectionVisualFixture.Reset();
        var collector = LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Points;
        // Сечение на пикете 10, DtmSize 2/2 → leftPoint=(-2,10), u=(1,0):
        // offset = p.X, sliceDistance = 10 - p.Y.
        collector.Add(new Vector4D(-1, 10, 4, 0.1));
        collector.Add(new Vector4D(0, 10, 5, 0.2));
        collector.Add(new Vector4D(1, 10.1, 6, 0.3));
        collector.Add(new Vector4D(2, 9.9, 7, 0.4));
        collector.Add(new Vector4D(3, 10, 8, 0.5));
        LasSectionFrame r = LasAutomation.GetSectionFrame(10, 0.6, 1000);
        Check(r.TotalPoints == 5 && r.StoredPoints == 5 && !r.Truncated, "frame: full slice stored");
        Check(r.Offsets.Length == 5 && r.Elevations.Length == 5 &&
            r.Weights.Length == 5 && r.SliceDistances.Length == 5, "frame: array lengths");
        Check(r.Offsets[0] == -1 && r.Elevations[0] == 4 && r.Weights[0] == 0.1 &&
            r.SliceDistances[0] == 0, "frame: local frame from SDK endpoints");
        Check(Math.Abs(r.SliceDistances[2] + 0.1) < 1e-9 &&
            Math.Abs(r.SliceDistances[3] - 0.1) < 1e-9, "frame: signed slice distance");
        Check(r.OffsetMin == -1 && r.OffsetMax == 3 && r.ZMin == 4 && r.ZMax == 8 &&
            r.WeightMin == 0.1 && r.WeightMax == 0.5, "frame: min/max over full slice");
        Check(r.LeftOffset == 2 && r.RightOffset == 2 && r.Alignment == "Test" &&
            r.Station == 10 && r.Thickness == 0.6, "frame: header fields");
        Check(LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.LastHalfBorder == 0.3,
            "frame: thickness converted to half border once");

        r = LasAutomation.GetSectionFrame(10, 0.6, 3);
        Check(r.TotalPoints == 5 && r.StoredPoints == 3 && r.Truncated, "frame: truncated flag");
        Check(r.Offsets.Length == 3 && r.Offsets[2] == 1, "frame: stored prefix");
        Check(r.OffsetMax == 3 && r.ZMax == 8 && r.WeightMax == 0.5,
            "frame: bounds track whole slice beyond stored prefix");

        collector.Clear();
        r = LasAutomation.GetSectionFrame(10, 0.6, 100);
        Check(r.TotalPoints == 0 && r.StoredPoints == 0 && !r.Truncated &&
            r.Offsets.Length == 0 && r.Elevations.Length == 0 &&
            r.Weights.Length == 0 && r.SliceDistances.Length == 0, "frame: empty slice arrays");
        Check(r.OffsetMin == -2 && r.OffsetMax == 2 && r.ZMin == 0 && r.ZMax == 0 &&
            r.WeightMin == 0 && r.WeightMax == 0, "frame: default bounds on empty slice");

        collector.Add(new Vector4D(0, 12, 5, 0.1));
        r = LasAutomation.GetSectionFrame(10, 0.6, 10);
        Check(r.TotalPoints == 0, "frame: point beyond thickness filtered by collector");

        LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Status =
            LAS_TERRAIN.Service.Collector.SectionCollectStatus.Overflow;
        Reject(delegate { LasAutomation.GetSectionFrame(10, 0.6, 10); }, "frame: overflow never returns partial stats");
        LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Status =
            LAS_TERRAIN.Service.Collector.SectionCollectStatus.Success;

        LAS_TERRAIN.Infrastructure.LasExportSourceContext.ChangesAfterRead = true;
        Reject(delegate { LasAutomation.GetSectionFrame(10, 0.6, 10); }, "frame: changed source rejected");
        LAS_TERRAIN.Infrastructure.LasExportSourceContext.ChangesAfterRead = false;
        Console.WriteLine("frame checks passed");
    }

    // 4) PreviewSectionPolygons на стаб-коллекторе.
    private static void PreviewTests()
    {
        SectionVisualFixture.Reset();
        var collector = LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.Points;
        // Сечение на пикете 10, thickness=2 → |10 - p.Y| < 1; offset = p.X.
        collector.Add(new Vector4D(-1.5, 10, 5, 0.1));   // только полигон A
        collector.Add(new Vector4D(-0.5, 10, 5, 0.2));   // A и B — первое совпадение A
        collector.Add(new Vector4D(0.5, 10, 5, 0.3));    // только полигон B
        collector.Add(new Vector4D(1.5, 10, 5, 0.4));    // вне полигонов
        collector.Add(new Vector4D(-0.5, 10.9, 5, 0.5)); // dist=-0.9 — внутри среза
        collector.Add(new Vector4D(-0.5, 11, 5, 0.6));   // dist=-1 — граница thickness, вне среза
        collector.Add(new Vector4D(-0.5, 9.1, 5, 0.7));  // dist=+0.9 — внутри среза
        collector.Add(new Vector4D(-0.5, 10, 12, 0.8));  // в срезе, но Z вне полигонов
        LasSectionPreviewResult res = LasAutomation.PreviewSectionPolygons(10, 2,
            new double[][][] { Square(-2, 0, 0, 10), Square(-1, 0, 1, 10) });
        Check(res.SlicePoints == 7, "preview: slice points count full thickness slice");
        Check(res.MatchedPoints == 5, "preview: matched points");
        Check(res.Polygons.Count == 2 && res.Polygons[0].Index == 0 &&
            res.Polygons[0].Count == 4 && res.Polygons[1].Index == 1 &&
            res.Polygons[1].Count == 1, "preview: per-polygon first match");
        Check(res.Alignment == "Test" && res.Station == 10 && res.Thickness == 2 &&
            res.PolygonCount == 2, "preview: header fields");
        Check(LAS_TERRAIN.Service.Collector.LasSectionPointsCollectorService.LastHalfBorder == 1,
            "preview: thickness converted to half border once");
        Console.WriteLine("preview checks passed");
    }

    // 5) DeleteSectionPoints: полный сценарий на синтетических индексерах
    //    (стабы writer/WaitProgress/MemoryStatus подключаются безболезненно,
    //    поэтому зеркалирование DeletePointsCrsCore покрыто end-to-end).
    private static void DeleteTests()
    {
        SectionVisualFixture.Reset();
        // DtmSize 2/2, station 0 → призма: offset = wx, dist = wy.
        SectionVisualFixture.SetCloud(new double[] { 0, 0, 5 },   // удаление (offset 0, Z 5, dist 0)
            new double[] { 3, 0, 5 },                              // вне полигона — оставлен
            new double[] { 0, 1, 5 },                              // ровно на границе thickness/2 — оставлен
            new double[] { 0, 0.9, 5 },                            // удаление (dist 0.9)
            new double[] { 0, 0, 15 },                             // Z вне полигона — оставлен
            new double[] { 0.2, -0.5, 2 });                        // удаление (dist -0.5)
        LasSectionDeleteResult res = LasAutomation.DeleteSectionPoints(
            new[] { Spec(0, 2, Square(-0.5, 0, 0.5, 10)) }, @"C:\fixture\out.las");
        Check(res.Deleted == 3 && res.Kept == 3, "delete: deleted/kept counts");
        Check(res.Sections == 1 && res.OutputPath == @"C:\fixture\out.las", "delete: header fields");
        Check(res.PerSection.Count == 1 && res.PerSection[0].Index == 0 &&
            res.PerSection[0].Count == 3, "delete: per-section counter");
        Check(res.Published && SectionVisualFixture.PublishCalls == 1 &&
            SectionVisualFixture.CompleteCalls == 1, "delete: published once");
        Check(res.RgbPreserved, "delete: rgb flag propagated");
        Check(res.ElapsedSeconds >= 0, "delete: elapsed seconds present");
        Check(SectionVisualFixture.WrittenPoints.Count == 3 &&
            SectionVisualFixture.WrittenPoints[0].X == 3 &&
            SectionVisualFixture.WrittenPoints[0].W == 2 * 257.0 &&
            SectionVisualFixture.WrittenPoints[1].Y == 1 &&
            SectionVisualFixture.WrittenPoints[1].W == 3 * 257.0 &&
            SectionVisualFixture.WrittenPoints[2].Z == 15 &&
            SectionVisualFixture.WrittenPoints[2].W == 5 * 257.0,
            "delete: kept points with byte weight expanded by 257");
        Check(SectionVisualFixture.Published != null &&
            SectionVisualFixture.Published.Count == 3, "delete: published LAS content");
        Check(res.Note != null && res.Note.Contains("Исходное облако"), "delete: success note");

        // Два полигона в ОДНОЙ секции: призма (глубина) общая, счёт секции суммарный.
        SectionVisualFixture.Reset();
        SectionVisualFixture.SetCloud(new double[] { 0, 0, 5 },    // полигон A (offset 0, Z 5)
            new double[] { 3, 0, 5 },                              // полигон B (offset 3, Z 5)
            new double[] { 9, 0, 5 });                             // вне обоих — оставлен
        LasSectionDeleteResult two = LasAutomation.DeleteSectionPoints(
            new[] { Spec(0, 2, new double[][][] { Square(-0.5, 0, 0.5, 10), Square(2.5, 0, 3.5, 10) }) },
            @"C:\fixture\out.las");
        Check(two.Deleted == 2 && two.Kept == 1 && two.Sections == 1 &&
            two.PerSection.Count == 1 && two.PerSection[0].Count == 2,
            "delete: two polygons in one section (shared prism, summed counter)");

        SectionVisualFixture.Reset();
        SectionVisualFixture.SetCloud(new double[] { 0, 0, 5 });
        res = LasAutomation.DeleteSectionPoints(new[] {
            Spec(0, 2, Square(-1, 0, 1, 10)), Spec(0, 2, Square(-1, 0, 1, 10))
        }, @"C:\fixture\out.las");
        Check(res.Deleted == 1 && res.Kept == 0 && res.Published,
            "delete: overlapping sections delete once");
        Check(res.PerSection[0].Count == 1 && res.PerSection[1].Count == 0,
            "delete: per-section first match");
        Check(SectionVisualFixture.Published.Count == 0, "delete: all-deleted exports empty LAS");

        SectionVisualFixture.Reset();
        SectionVisualFixture.SetCloud(new double[] { 3, 0, 5 });
        res = LasAutomation.DeleteSectionPoints(
            new[] { Spec(0, 2, Square(10, 20, 20, 30)) }, @"C:\fixture\out.las");
        Check(res.Deleted == 0 && !res.Published && SectionVisualFixture.PublishCalls == 0 &&
            SectionVisualFixture.CompleteCalls == 0, "delete: no match does not publish");
        Check(res.Note != null && res.Note.Contains("Точек для удаления не найдено"),
            "delete: no-match note");

        SectionVisualFixture.Reset();
        SectionVisualFixture.SetCloud(new double[] { 0, 0, 5 }, new double[] { 3, 0, 5 });
        Topomatic.Controls.WaitProgress.CancellationPending = true;
        res = LasAutomation.DeleteSectionPoints(
            new[] { Spec(0, 2, Square(-0.5, 0, 0.5, 10)) }, @"C:\fixture\out.las");
        Check(res.Cancelled && !res.Published && res.Deleted == 0 &&
            SectionVisualFixture.PublishCalls == 0, "delete: user cancellation without exception");
        Check(res.Note != null && res.Note.Contains("отменена"), "delete: cancellation note");

        SectionVisualFixture.Reset();
        SectionVisualFixture.SetCloud(new double[] { 0, 0, 5 }, new double[] { 3, 0, 5 });
        SectionVisualFixture.Buffers[0].indexers[0].weights = null;
        res = LasAutomation.DeleteSectionPoints(
            new[] { Spec(0, 2, Square(-0.5, 0, 0.5, 10)) }, @"C:\fixture\out.las");
        Check(res.Deleted == 1 && res.Kept == 1 && SectionVisualFixture.Published.Count == 1 &&
            SectionVisualFixture.Published[0].W == UInt16.MaxValue,
            "delete: missing weights use full LAS intensity");
        Console.WriteLine("delete checks passed");
    }

    public static int Main()
    {
        ValidationTests();
        PrismPredicateTests();
        FrameTests();
        PreviewTests();
        DeleteTests();
        Console.WriteLine("PASS " + _checks + " section visual checks");
        return 0;
    }
}
