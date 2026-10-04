// Test-only SDK value types and Alignment. Filter, workflow, and RuntimeConfig
// sources in this runner are production files; no filter algorithm is replaced.
namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
        public static Vector2D operator +(Vector2D a, Vector2D b)
        { return new Vector2D(a.X + b.X, a.Y + b.Y); }
        public static Vector2D operator *(Vector2D a, double scale)
        { return new Vector2D(a.X * scale, a.Y * scale); }
    }

    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector3D(Vector2D xy, double z) { X = xy.X; Y = xy.Y; Z = z; }
    }

    public struct Vector4D
    {
        public double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }
}

namespace Topomatic.Alg
{
    public sealed class Alignment
    {
        public double DtmSizeLeft;
        public double DtmSizeRight;
    }
}

namespace Topomatic.Alg.Crs
{
    public sealed class Section { }
}

namespace Topomatic.Lidar
{
    public sealed class LidarBuffer { }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancelRequested;
        public static int Stage;
        public static int CancelOnProgressStage;
        public static bool CancelOnlyAtFinalProgress;
        public static bool ThrowOnCancellation;
        public static bool ResetCancellationOnClose;
        public static bool CancellationPending { get { return CancelRequested; } }
        public static void BeginProgress(string title, System.Action work, bool cancellable)
        {
            Stage++;
            try { work(); }
            finally { if (ResetCancellationOnClose) CancelRequested = false; }
        }
        public static void ProgressChange(float value)
        {
            if (Stage != CancelOnProgressStage ||
                (CancelOnlyAtFinalProgress && value < 1.0f)) return;
            CancelRequested = true;
            if (ThrowOnCancellation) throw new System.OperationCanceledException();
        }
    }
}

namespace LAS_TERRAIN.Tests
{
    internal static class CollectorFixture
    {
        internal static bool EmitPoints;

        internal static LAS_TERRAIN.Models.LasSectionPoints Create()
        {
            LAS_TERRAIN.Models.LasSectionPoints result =
                new LAS_TERRAIN.Models.LasSectionPoints();
            result.SectionPoints = EmitPoints
                ? LAS_TERRAIN.Tests.Fixtures.FixtureData.DuplicateXYSection()
                : new System.Collections.Generic.List<Topomatic.Cad.Foundation.Vector2D>();
            result.LeftMostPoint = new Topomatic.Cad.Foundation.Vector2D(100.0, 200.0);
            result.Direction = new Topomatic.Cad.Foundation.Vector2D(1.0, 0.0);
            result.OriginOffset = 2.0;
            return result;
        }
    }
}

namespace LAS_TERRAIN.Service
{
    internal static class LidarBufferService
    {
        internal static bool ValidateBuffers(System.Collections.Generic.List<Topomatic.Lidar.LidarBuffer> buffers)
        { return buffers != null && buffers.Count > 0; }
    }

    internal static class OnePassSectionCollector
    {
        internal static int Calls;
        internal static double? LastLeftOffset;
        internal static System.Collections.Generic.List<double> RequestedStations =
            new System.Collections.Generic.List<double>();
        internal static bool ReturnNull;
        internal static bool ThrowOutOfMemory;
        internal static LAS_TERRAIN.Models.LasSectionPoints[] CollectAllSections(
            Topomatic.Alg.Alignment alg,
            System.Collections.Generic.IList<Topomatic.Lidar.LidarBuffer> buffers,
            System.Collections.Generic.IList<Topomatic.Alg.Crs.Section> sections,
            LAS_TERRAIN.Models.LasFilterOptions options,
            System.Func<Topomatic.Cad.Foundation.Vector2D,
                System.Collections.Generic.List<Topomatic.Cad.Foundation.Vector2D>, bool> filter,
            System.Action<float> progress, System.Func<bool> cancellation)
        {
            Calls++;
            if (ThrowOutOfMemory) throw new System.OutOfMemoryException("OnePass fixture");
            if (ReturnNull) return null;
            LAS_TERRAIN.Models.LasSectionPoints[] result =
                new LAS_TERRAIN.Models.LasSectionPoints[sections.Count];
            for (int i = 0; i < result.Length; i++)
                result[i] = LAS_TERRAIN.Tests.CollectorFixture.Create();
            progress(1.0f);
            return result;
        }

        internal static LAS_TERRAIN.Models.LasSectionPoints[] CollectAllAtStations(
            Topomatic.Alg.Alignment alg,
            System.Collections.Generic.IList<Topomatic.Lidar.LidarBuffer> buffers,
            System.Collections.Generic.IList<double> stations,
            LAS_TERRAIN.Models.LasFilterOptions options,
            System.Action<float> progress, System.Func<bool> cancellation)
        {
            LastLeftOffset = options.CentralLeftOffset;
            RequestedStations.Clear();
            for (int i = 0; i < stations.Count; i++) RequestedStations.Add(stations[i]);
            Calls++;
            if (ThrowOutOfMemory) throw new System.OutOfMemoryException("OnePass fixture");
            if (ReturnNull) return null;
            LAS_TERRAIN.Models.LasSectionPoints[] result =
                new LAS_TERRAIN.Models.LasSectionPoints[stations.Count];
            for (int i = 0; i < result.Length; i++)
                result[i] = LAS_TERRAIN.Tests.CollectorFixture.Create();
            progress(1.0f);
            return result;
        }
    }
}

namespace LAS_TERRAIN.Service.Collector
{
    internal static class LasSectionPointsCollectorService
    {
        internal static int Calls;
        internal static bool ChangeAlignmentOffsetAfterFirst;
        internal static System.Action AfterFirstStationCollection;
        internal static System.Collections.Generic.List<double?> CapturedLeftOffsets =
            new System.Collections.Generic.List<double?>();
        internal static System.Collections.Generic.List<double> CapturedHalfBorders =
            new System.Collections.Generic.List<double>();
        internal static System.Collections.Generic.List<bool> CapturedPositiveBorders =
            new System.Collections.Generic.List<bool>();
        internal static System.Collections.Generic.List<double> RequestedStations =
            new System.Collections.Generic.List<double>();
        internal static LAS_TERRAIN.Models.SectionCollectStatus NextStatus;
        internal static LAS_TERRAIN.Models.LasSectionPoints Collect(
            Topomatic.Alg.Alignment alg,
            System.Collections.Generic.IList<Topomatic.Lidar.LidarBuffer> buffers,
            Topomatic.Alg.Crs.Section section,
            LAS_TERRAIN.Models.LasFilterOptions options,
            System.Func<Topomatic.Cad.Foundation.Vector2D,
                System.Collections.Generic.List<Topomatic.Cad.Foundation.Vector2D>, bool> filter,
            System.Func<bool> cancellation,
            out LAS_TERRAIN.Models.SectionCollectStatus status)
        {
            Calls++;
            status = NextStatus;
            LAS_TERRAIN.Models.LasSectionPoints result =
                LAS_TERRAIN.Tests.CollectorFixture.Create();
            if (status != LAS_TERRAIN.Models.SectionCollectStatus.Success)
                result.SectionPoints = null;
            return result;
        }

        internal static LAS_TERRAIN.Models.LasSectionPoints CollectAtStation(
            Topomatic.Alg.Alignment alg,
            System.Collections.Generic.IList<Topomatic.Lidar.LidarBuffer> buffers,
            double station, LAS_TERRAIN.Models.LasFilterOptions options,
            System.Func<bool> cancellation,
            out LAS_TERRAIN.Models.SectionCollectStatus status)
        {
            CapturedLeftOffsets.Add(options.CentralLeftOffset);
            CapturedHalfBorders.Add(options.HalfBorder);
            CapturedPositiveBorders.Add(options.IncludePositiveSliceBorder);
            if (ChangeAlignmentOffsetAfterFirst && CapturedLeftOffsets.Count == 1)
                alg.DtmSizeLeft = 100.0;
            if (CapturedLeftOffsets.Count == 1 && AfterFirstStationCollection != null)
                AfterFirstStationCollection();
            RequestedStations.Add(station);
            Calls++;
            status = NextStatus;
            LAS_TERRAIN.Models.LasSectionPoints result =
                LAS_TERRAIN.Tests.CollectorFixture.Create();
            if (status != LAS_TERRAIN.Models.SectionCollectStatus.Success)
                result.SectionPoints = null;
            return result;
        }
    }
}

namespace LAS_TERRAIN
{
    internal static class SettingsDefaults
    {
        internal const double SplitMergeTolerance = 0.07;
    }
}
