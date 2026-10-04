using System;
using System.Collections.Generic;

namespace Topomatic.Cad.View
{
    public sealed class CadView
    {
        public bool IsDisposed;
        public bool IsHandleCreated = true;
    }
}

namespace Topomatic.Alg
{
    public sealed class CompoundLine { public double Length = 10; }
    public sealed class Plan { public CompoundLine CompoundLine = new CompoundLine(); }
    public sealed class Alignment
    {
        public Guid Id = Guid.NewGuid();
        public Plan Plan = new Plan();
        public double DtmSizeLeft = 1;
        public double DtmSizeRight = 2;
        public Topomatic.ApplicationPlatform.Model Model;
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
        public Topomatic.Alg.Alignment ActiveAlignment;
    }
}

namespace Topomatic.ApplicationPlatform.Plugins
{
    public static class PluginCoreOps
    {
        public static Topomatic.ApplicationPlatform.Model FindModel(
            Topomatic.Alg.Alignment alignment)
        { return alignment.Model; }
    }

    public static class AlignmentValueConverter
    {
        public static Guid GetId(Topomatic.Alg.Alignment alignment)
        { return alignment.Id; }
    }
}

namespace Topomatic.Lidar
{
    public sealed class PointArray
    {
        public object[] Values = new object[0];
        public int Count;
        public bool ThrowOnGetBuffer;
        public object[] GetBuffer()
        {
            if (ThrowOnGetBuffer) throw new InvalidOperationException("point buffer unavailable");
            return Values;
        }
    }
    public sealed class WeightArray
    {
        public byte[] Values = new byte[0];
        public int Count;
        public byte[] GetBuffer() { return Values; }
    }
    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
    }
    public sealed class QuadTreeIndexer
    {
        public PointArray points = new PointArray();
        public WeightArray weights = new WeightArray();
        public Vector3D scale = new Vector3D(1, 1, 1);
        public Vector3D position;
    }
    public sealed class LidarBuffer
    {
        public string fullpath = @"C:\fixture\cloud.las";
        public QuadTreeIndexer[] indexers = new QuadTreeIndexer[] {
            new QuadTreeIndexer() };
    }
}

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;
    internal static class LidarBufferService
    {
        internal static Alignment LastSelected;
        internal static List<LidarBuffer> Buffers;
        internal static bool ThrowOnCollect;
        internal static List<LidarBuffer> CollectBuffers(Alignment alignment)
        {
            LastSelected = alignment;
            if (ThrowOnCollect) throw new InvalidOperationException("source unavailable");
            return Buffers;
        }
    }
}
