using System;
using System.Collections.Generic;

namespace LAS_TERRAIN
{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class SectionCmdAttribute : Attribute
    {
        public SectionCmdAttribute(string name) { }
    }

    internal interface ISectionUseCase
    {
        string Name { get; }
        void Run(SectionEnv env);
    }

    public sealed class SectionEnv
    {
        internal readonly object CadView = new TestCadView();
    }

    public sealed class TestCadView
    {
        public object Project = new object();
        public object Document = new object();
    }
}

namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }

    public struct Vector4D
    {
        public double X, Y, Z, W;
        public Vector4D(double x, double y, double z, double w)
        { X = x; Y = y; Z = z; W = w; }
    }
}

namespace Topomatic.Alg.Crs
{
    public sealed class Section
    {
        public double Station;
        public uint Id;
        public uint ConstructionId;
        public object SectionLine;
    }
}

namespace Topomatic.Alg
{
    using Topomatic.Alg.Crs;

    public sealed class TestCompoundLine
    {
        public double Length = 1.0;
    }

    public sealed class TestPlan
    {
        public TestCompoundLine CompoundLine = new TestCompoundLine();
    }

    public sealed class TestSectionList : List<Section>
    {
        public int ClearCalls;
        public int AddStationCalls;
        public void Add(double station)
        {
            AddStationCalls++;
            Add(new Section { Station = station });
        }
        public new void Clear() { ClearCalls++; base.Clear(); }
    }

    public sealed class TestCorridor
    {
        public TestSectionList Sections = new TestSectionList();
    }

    public sealed class Alignment
    {
        public TestPlan Plan = new TestPlan();
        public TestCorridor Corridor = new TestCorridor();
        public string SourceIdentity = "selected-alignment";
        public object Model = new object();
        public int GeometryRevision;
    }
}

namespace Topomatic.Lidar
{
    public sealed class LidarBuffer
    {
        public string SourcePath = "source.las";
        public object Index = new object();
        public int MetadataRevision;
    }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
        public static bool CancelAfterWork;
        public static bool ThrowCancellationAfterWork;
        public static bool ResetCancellationOnClose;
        public static Action AfterWork;
        public static bool InCallback;
        public static void BeginProgress(string title, Action work, bool cancellable)
        {
            try
            {
                InCallback = true;
                try { work(); }
                finally { InCallback = false; }
                if (AfterWork != null) AfterWork();
                if (CancelAfterWork) CancellationPending = true;
                if (ThrowCancellationAfterWork) throw new OperationCanceledException();
            }
            finally
            {
                if (ResetCancellationOnClose) CancellationPending = false;
            }
        }
        public static Action OnProgressChange;
        public static void ProgressChange(float value)
        { if (OnProgressChange != null) OnProgressChange(); }
    }
}

namespace Topomatic.Sfc
{
    public sealed class Surface { }
}

namespace LAS_TERRAIN.Collector
{
    internal sealed class NamespaceMarker { }
}

namespace LAS_TERRAIN.Infrastructure
{
    internal sealed class NamespaceMarker { }

    internal sealed class LasExportSourceContext
    {
        private readonly LAS_TERRAIN.TestCadView view;
        private readonly object project;
        private readonly object document;
        private readonly Topomatic.Alg.Alignment alignment;
        private readonly string sourceIdentity;
        private readonly object model;
        private readonly int geometryRevision;
        private readonly double length;
        private readonly Topomatic.Lidar.LidarBuffer buffer;
        private readonly string sourcePath;
        private readonly object index;
        private readonly int metadataRevision;
        internal static int CaptureCalls, IsCurrentCalls, IsCurrentInsideCallback;
        internal static bool ForceCaptureFailure;

        private LasExportSourceContext(LAS_TERRAIN.TestCadView cadView,
            Topomatic.Alg.Alignment selected, Topomatic.Lidar.LidarBuffer sourceBuffer)
        {
            view = cadView;
            project = cadView.Project;
            document = cadView.Document;
            alignment = selected;
            sourceIdentity = selected.SourceIdentity;
            model = selected.Model;
            geometryRevision = selected.GeometryRevision;
            length = selected.Plan.CompoundLine.Length;
            buffer = sourceBuffer;
            sourcePath = sourceBuffer.SourcePath;
            index = sourceBuffer.Index;
            metadataRevision = sourceBuffer.MetadataRevision;
        }

        internal static LasExportSourceContext Capture(object cadView,
            Topomatic.Alg.Alignment selected,
            System.Collections.Generic.List<Topomatic.Lidar.LidarBuffer> buffers)
        {
            CaptureCalls++;
            if (ForceCaptureFailure) return null;
            LAS_TERRAIN.TestCadView view = cadView as LAS_TERRAIN.TestCadView;
            if (view == null || selected == null || buffers == null || buffers.Count != 1)
                return null;
            return new LasExportSourceContext(view, selected, buffers[0]);
        }

        internal bool IsCurrent()
        {
            IsCurrentCalls++;
            if (Topomatic.Controls.WaitProgress.InCallback)
            {
                IsCurrentInsideCallback++;
                throw new InvalidOperationException("CAD source probed inside progress callback");
            }
            return ReferenceEquals(view.Project, project) &&
                ReferenceEquals(view.Document, document) &&
                alignment.SourceIdentity == sourceIdentity &&
                ReferenceEquals(alignment.Model, model) &&
                alignment.GeometryRevision == geometryRevision &&
                BitConverter.DoubleToInt64Bits(alignment.Plan.CompoundLine.Length) ==
                    BitConverter.DoubleToInt64Bits(length) &&
                LAS_TERRAIN.Service.LidarBufferService.CurrentBuffers != null &&
                LAS_TERRAIN.Service.LidarBufferService.CurrentBuffers.Count == 1 &&
                ReferenceEquals(LAS_TERRAIN.Service.LidarBufferService.CurrentBuffers[0], buffer) &&
                buffer.SourcePath == sourcePath &&
                ReferenceEquals(buffer.Index, index) &&
                buffer.MetadataRevision == metadataRevision;
        }
    }

    internal static class TopomaticIndexScheduler
    {
        internal static int Calls;
        internal static void ForEach(int count, Action<int> body)
        {
            Calls++;
            for (int index = 0; index < count; index++) body(index);
        }
    }

    internal static class GraphGround3DSettingsAdapter
    {
        internal static LAS_TERRAIN.Models.GraphGround3DOptions Capture()
        { return new LAS_TERRAIN.Models.GraphGround3DOptions(); }
    }
}

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;

    internal static class LidarBufferService
    {
        internal static List<LidarBuffer> CurrentBuffers;
        internal static List<LidarBuffer> CollectBuffers(Alignment alignment)
        {
            CurrentBuffers = new List<LidarBuffer> { new LidarBuffer() };
            return CurrentBuffers;
        }
        internal static bool ValidateBuffers(List<LidarBuffer> buffers)
        { return buffers != null && buffers.Count != 0; }
    }

    internal static class UserDialogs
    {
        internal static int Warnings, Infos;
        internal static string LastInfo;
        internal static Alignment SelectedAlignment;
        internal static bool CancelPercentInput;
        internal static Action AfterPercentDialog;
        internal static Action AfterSaveDialog;
        internal static int SavePathRequests;
        internal static bool IsCadViewValid(object view) { return true; }
        internal static object GetSurfaceLayerOrShow(object view) { return new object(); }
        internal static Alignment SelectAlignment(object view)
        { return SelectedAlignment ?? new Alignment(); }
        internal static double? GetOptionalDouble(object view, string prompt, double initial)
        {
            if (AfterPercentDialog != null) AfterPercentDialog();
            return CancelPercentInput ? (double?)null : 50.0;
        }
        internal static string GetSaveFilePath(string prompt)
        {
            SavePathRequests++;
            if (AfterSaveDialog != null) AfterSaveDialog();
            return "fixture.las";
        }
        internal static void ShowWarning(string text) { Warnings++; }
        internal static void ShowInfo(string text) { Infos++; LastInfo = text; }
    }
}

namespace LAS_TERRAIN.Helpers
{
    using Topomatic.Cad.Foundation;

    internal static class MemoryStatus
    {
        internal static int CalcBatchSizeForReduceOnly() { return 1; }
        internal static int CalcBatchSizeForGroundReduce() { return 1; }
    }

    internal static class SamplingHelper
    {
        internal static bool ReduceToOne;
        internal static int Calls;
        internal static int CancelOnCall;
        internal static int CancelOnPoll;
        internal static int Polls;
        internal static List<Vector4D> ReduceByPercentWithProgress(
            List<Vector4D> points, double percent, Action<float> progress)
        {
            if (!ReduceToOne || points.Count == 0) return points;
            return new List<Vector4D> { points[0] };
        }
        internal static List<Vector4D> ReduceByPercentWithProgress(
            List<Vector4D> points, double percent, Action<float> progress,
            Func<bool> isCancelled)
        {
            Calls++;
            for (int i = 0; i < 3; i++)
            {
                Polls++;
                if (Calls == CancelOnCall && i + 1 == CancelOnPoll)
                    Topomatic.Controls.WaitProgress.CancellationPending = true;
                if (isCancelled != null && isCancelled())
                    throw new OperationCanceledException();
            }
            return ReduceByPercentWithProgress(points, percent, progress);
        }
    }
}

namespace LAS_TERRAIN.Models
{
    internal sealed class GraphGround3DOptions { }
}

namespace LAS_TERRAIN.Filters
{
    using LAS_TERRAIN.Models;
    using Topomatic.Cad.Foundation;

    internal static class GraphGround3DFilter
    {
        internal static bool DuplicateOutput;
        internal static bool CancelDuringFilter;
        internal static List<Vector4D> Apply(List<Vector4D> points,
            GraphGround3DOptions options, Action<float> progress,
            Action<int, Action<int>> forEachIndex, Func<bool> isCancelled)
        {
            if (CancelDuringFilter)
            {
                Topomatic.Controls.WaitProgress.CancellationPending = true;
                if (isCancelled()) throw new OperationCanceledException();
            }
            forEachIndex(1, delegate(int ignored) { });
            if (!DuplicateOutput) return points;
            List<Vector4D> result = new List<Vector4D>(points);
            result.AddRange(points);
            return result;
        }
    }
}

namespace LAS_TERRAIN.Service.Collector
{
    using LAS_TERRAIN.Models;
    using Topomatic.Alg;
    using Topomatic.Alg.Crs;
    using Topomatic.Cad.Foundation;
    using Topomatic.Lidar;

    internal static class LasSectionPointsCollectorService
    {
        internal static int Calls;
        internal static readonly List<double> RequestedStations = new List<double>();
        internal static int TerminalCall;
        internal static SectionCollectStatus TerminalStatus;
        internal static bool ThrowUnexpected;
        internal static bool EmitEmpty;

        internal static void StreamRawAtStation(Alignment alg,
            IList<LidarBuffer> buffers, double station, LasFilterOptions options,
            Action<Vector4D> acceptPoint, Func<bool> cancellation,
            out SectionCollectStatus status)
        {
            Calls++;
            RequestedStations.Add(station);
            if (Calls == TerminalCall && ThrowUnexpected)
                throw new InvalidOperationException("SDK fixture failure");
            status = Calls == TerminalCall ? TerminalStatus : SectionCollectStatus.Success;
            if (!EmitEmpty || status != SectionCollectStatus.Success)
                acceptPoint(new Vector4D(Calls, 0, 0, Calls / 255.0));
        }
    }
}

namespace LAS_TERRAIN.IO
{
    using Topomatic.Cad.Foundation;

    internal sealed class LasBatchStreamWriter : IDisposable
    {
        internal static int Writes, Completes, Publishes, Disposes;
        internal static readonly List<double> WrittenWeights = new List<double>();
        internal static bool ThrowOnWrite, ThrowOnPublish;
        internal Func<bool> IsCancellationRequested;
        internal static int Opens;
        internal LasBatchStreamWriter(string path) { Opens++; }
        internal void WritePoints(List<Vector4D> points)
        {
            Writes++;
            if (ThrowOnWrite) throw new InvalidOperationException("write failure");
            foreach (Vector4D point in points) WrittenWeights.Add(point.W);
        }
        internal PreparedLasFile Complete() { Completes++; return new PreparedLasFile(); }
        public void Dispose() { Disposes++; }
    }

    internal sealed class PreparedLasFile : IDisposable
    {
        internal static int Disposes;
        internal static Action AfterPublish;
        internal bool IsPublished { get; private set; }
        internal void Publish()
        {
            if (LasBatchStreamWriter.Disposes == 0 ||
                Topomatic.Controls.WaitProgress.InCallback)
                throw new InvalidOperationException("publication before modal/writer closure");
            if (LasBatchStreamWriter.ThrowOnPublish)
                throw new InvalidOperationException("publication failure");
            LasBatchStreamWriter.Publishes++;
            IsPublished = true;
            if (AfterPublish != null) AfterPublish();
        }
        public void Dispose() { Disposes++; }
    }
}
