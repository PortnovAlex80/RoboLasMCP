using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN
{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class SectionCmdAttribute : Attribute
    {
        internal SectionCmdAttribute(string name) { }
    }
    internal interface ISectionUseCase
    {
        string Name { get; }
        void Run(SectionEnv env);
    }
    public sealed class SectionEnv
    {
        internal readonly object CadView = new object();
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
        public uint Id, ConstructionId;
        public object SectionLine;
    }
}

namespace Topomatic.Alg
{
    using Topomatic.Alg.Crs;
    public sealed class TestCompoundLine { public double Length = 1.0; }
    public sealed class TestPlan { public TestCompoundLine CompoundLine = new TestCompoundLine(); }
    public sealed class TestSectionList : List<Section>
    {
        public int ClearCalls, AddStationCalls;
        public new void Clear() { ClearCalls++; base.Clear(); }
        public void Add(double station)
        { AddStationCalls++; base.Add(new Section { Station = station }); }
    }
    public sealed class TestCorridor { public TestSectionList Sections = new TestSectionList(); }
    public sealed class Alignment
    {
        public TestPlan Plan = new TestPlan();
        public TestCorridor Corridor = new TestCorridor();
    }
}

namespace Topomatic.Lidar { public sealed class LidarBuffer { } }

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
        public static int Calls, CancelAfterCall, CancelDuringProgressCall;
        public static int SourceChangeAfterCall, SourceChangeDuringProgressCall;
        public static bool ResetOnClose;
        public static void BeginProgress(string title, Action body, bool cancellable)
        {
            Calls++;
            body();
            if (Calls == CancelAfterCall) CancellationPending = true;
            if (Calls == SourceChangeAfterCall)
                LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = false;
            if (ResetOnClose) CancellationPending = false;
        }
        public static void ProgressChange(float value)
        {
            if (Calls == CancelDuringProgressCall) CancellationPending = true;
            if (Calls == SourceChangeDuringProgressCall)
                LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = false;
        }
    }
}

namespace LAS_TERRAIN.Helpers
{
    using Topomatic.Cad.Foundation;
    internal static class SamplingHelper
    {
        internal static int ReduceCalls, ThrowOnReduceCall;
        internal static bool ReturnEmpty;
        internal static List<Vector4D> ReduceByPercentWithProgress(
            IList<Vector4D> points, double percent, Action<float> progress,
            Func<bool> cancellationPending)
        {
            ReduceCalls++;
            if (ThrowOnReduceCall == ReduceCalls)
                throw new InvalidOperationException("fixture reduction failure");
            if (cancellationPending != null && cancellationPending())
                throw new OperationCanceledException();
            if (progress != null) progress(1f);
            if (cancellationPending != null && cancellationPending())
                throw new OperationCanceledException();
            if (ReturnEmpty) return new List<Vector4D>();
            return new List<Vector4D>(points);
        }
    }
}

namespace LAS_TERRAIN.Infrastructure
{
    using Topomatic.Alg;
    using Topomatic.Cad.Foundation;
    using Topomatic.Lidar;

    internal sealed class LasExportSourceContext
    {
        internal static bool Valid = true;
        internal static bool ReturnNull;
        internal static int Captures, Checks, InvalidateOnCheck;
        private LasExportSourceContext() { }
        internal static LasExportSourceContext Capture(object view, Alignment alignment,
            List<LidarBuffer> buffers)
        {
            Captures++;
            if (ReturnNull) return null;
            return new LasExportSourceContext();
        }
        internal bool IsCurrent()
        {
            Checks++;
            if (Checks == InvalidateOnCheck) Valid = false;
            return Valid;
        }
    }
}
namespace LAS_TERRAIN.Service.Collector { internal sealed class NamespaceMarker { } }

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;
    using Topomatic.Cad.Foundation;

    internal static class LidarBufferService
    {
        internal static List<LidarBuffer> CollectBuffers(Alignment alignment)
        { return new List<LidarBuffer> { new LidarBuffer() }; }
        internal static bool ValidateBuffers(List<LidarBuffer> buffers)
        { return buffers != null && buffers.Count > 0; }
    }

    internal static class UserDialogs
    {
        internal static Alignment SelectedAlignment;
        internal static int Warnings, Infos, OptionalCalls, CancelDialogCall;
        internal static int SourceChangeOnDialogCall;
        internal static int SelectionChangeOnDialogCall;
        internal static bool SourceChangeOnSaveDialog;
        internal static string LastWarning;
        internal static double Left = 2.0, Right = 4.0;
        internal static string PrimaryPath;
        internal static bool IsCadViewValid(object view) { return true; }
        internal static object GetSurfaceLayerOrShow(object view) { return new object(); }
        internal static Alignment SelectAlignment(object view) { return SelectedAlignment; }
        internal static double? GetOptionalDouble(object view, string prompt, double initial)
        {
            OptionalCalls++;
            if (OptionalCalls == SourceChangeOnDialogCall)
                LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = false;
            if (OptionalCalls == SelectionChangeOnDialogCall)
                SelectedAlignment = new Alignment();
            if (OptionalCalls == CancelDialogCall) return null;
            if (OptionalCalls == 1) return Left;
            if (OptionalCalls == 2) return Right;
            return OptionalCalls == 3 ? 50.0 : 10.0;
        }
        internal static void ShowWarning(string message)
        { Warnings++; LastWarning = message; }
        internal static string LastInfo;
        internal static void ShowInfo(string message) { Infos++; LastInfo = message; }
    }

    internal static class SaveLidarPointsService
    {
        internal static int Saves;
        internal static bool ThrowOnSave;
        internal static bool ChangeSourceDuringPreparation;
        internal static bool RestoreSourceAfterRejectedHook;
        internal static bool CancelDuringPreparation;
        internal static int BeforePublishCalls;
        internal static List<Vector4D> Center, Edge;
        internal static ExportRequest Request;
        internal static bool TryAskSaveModeAndPath(object view, out ExportRequest request)
        {
            if (UserDialogs.SourceChangeOnSaveDialog)
                LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = false;
            request = new ExportRequest(UserDialogs.PrimaryPath);
            return true;
        }
        internal static void SaveTwoExternalProgress(List<Vector4D> center,
            List<Vector4D> edge, ExportRequest request, float startOffset,
            Action beforePublish)
        {
            if (ChangeSourceDuringPreparation)
                LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = false;
            if (CancelDuringPreparation) throw new OperationCanceledException();
            BeforePublishCalls++;
            try { if (beforePublish != null) beforePublish(); }
            finally
            {
                if (RestoreSourceAfterRejectedHook)
                    LAS_TERRAIN.Infrastructure.LasExportSourceContext.Valid = true;
            }
            Saves++;
            Center = center;
            Edge = edge;
            Request = request;
            if (ThrowOnSave) throw new InvalidOperationException("writer failure");
        }
    }
}

namespace LAS_TERRAIN.IO
{
    internal static class LasPairPublication
    {
        internal static int RecoverCalls;
        internal static bool ThrowOnRecover;
        internal static string JournalPath(string primaryPath)
        { return primaryPath + ".journal"; }
        internal static void Recover(string primaryPath)
        {
            RecoverCalls++;
            if (ThrowOnRecover) throw new InvalidOperationException("recovery failure");
        }
    }
}

namespace LAS_TERRAIN.Collector
{
    using Topomatic.Alg;
    using Topomatic.Cad.Foundation;
    using Topomatic.Lidar;

    internal static class RawPointsCollector
    {
        internal static int Calls;
        internal static bool OptionsCorrect = true;
        internal static readonly List<double> Stations = new List<double>();
        internal static readonly List<int> FilterMasks = new List<int>();
        internal static OperationStatus OuterStatus = OperationStatus.Success;
        internal static OperationStatus InnerStatus = OperationStatus.Success;
        internal static bool EmitBeforeTerminal;
        internal static OperationResult<int> StreamAtStations(
            Alignment alg, List<LidarBuffer> buffers, IList<double> stations,
            LasFilterOptions options, Func<Vector2D, bool> filter,
            Action<Vector4D> acceptPoint, Action<float> onProgress)
        {
            Calls++;
            OptionsCorrect = OptionsCorrect && options.HalfBorder == 0.5 &&
                options.IncludePositiveSliceBorder &&
                options.CentralLeftOffset == null &&
                options.CentralRightOffset == null;
            foreach (double station in stations) Stations.Add(station);
            double[] probes = { -6.0, -2.0, 0.0, 4.0, 6.0 };
            int mask = 0;
            for (int i = 0; i < probes.Length; i++)
                if (filter(new Vector2D(probes[i], 0))) mask |= 1 << i;
            FilterMasks.Add(mask);
            OperationStatus selected = Calls == 1 ? OuterStatus : InnerStatus;
            if (EmitBeforeTerminal && selected != OperationStatus.Success &&
                selected != OperationStatus.Empty)
                acceptPoint(new Vector4D(Calls, 0, 0, 77.0 / 255.0));
            if (selected == OperationStatus.Cancelled)
                return OperationResult<int>.Cancelled(SectionStage.Collect);
            if (selected == OperationStatus.Overflow)
                return OperationResult<int>.Overflow(SectionStage.Collect,
                    new OutOfMemoryException("fixture"));
            if (selected == OperationStatus.Failed)
                return OperationResult<int>.Failed(SectionStage.Collect,
                    new InvalidOperationException("fixture"));
            if (selected == OperationStatus.Empty)
                return OperationResult<int>.Empty();
            if (onProgress != null) onProgress(1.0f);
            acceptPoint(new Vector4D(Calls, 0, 0,
                Calls == 1 ? 11.0 / 255.0 : 22.0 / 255.0));
            return OperationResult<int>.Succeeded(1);
        }
    }
}
