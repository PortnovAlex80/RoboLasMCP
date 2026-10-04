// Narrow SDK substitutes for the production section and raw collectors.
using System;
using System.Collections.Generic;

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

    public struct Vector3F
    {
        public float X, Y, Z;
        public Vector3F(float x, float y, float z) { X = x; Y = y; Z = z; }
    }

    public sealed class BoundingBox2D
    {
        public double MinX, MaxX, MinY, MaxY;
        public BoundingBox2D(Vector2D a, Vector2D b)
        {
            MinX = Math.Min(a.X, b.X); MaxX = Math.Max(a.X, b.X);
            MinY = Math.Min(a.Y, b.Y); MaxY = Math.Max(a.Y, b.Y);
        }
        public void AddPoint(Vector2D point)
        {
            MinX = Math.Min(MinX, point.X); MaxX = Math.Max(MaxX, point.X);
            MinY = Math.Min(MinY, point.Y); MaxY = Math.Max(MaxY, point.Y);
        }
    }
}

namespace Topomatic.Alg.Crs
{
    public sealed class Section
    {
        public double Station;
    }
}

namespace Topomatic.Crs.Templates
{
    public sealed class CrsNode
    {
        public double X, Y;
    }
}

namespace Topomatic.Alg
{
    using Topomatic.Cad.Foundation;

    public sealed class TestCompoundLine
    {
        public bool Valid = true;
        public bool UseStationAsY;
        public Action OnFirstPosition;
        private int calls;
        public double LastStation;
        public bool StaOffsetToPos(double station, double offset, out Vector2D point)
        {
            if (calls++ == 0 && OnFirstPosition != null) OnFirstPosition();
            LastStation = station;
            point = new Vector2D(offset, UseStationAsY ? station : 0.0);
            return Valid;
        }
    }

    public sealed class TestPlan
    {
        public TestCompoundLine CompoundLine = new TestCompoundLine();
    }

    public sealed class TestSections
    {
        public bool ThrowOnRead;
        public int GetIndex(double station)
        {
            if (ThrowOnRead) throw new InvalidOperationException("section lookup forbidden");
            return 0;
        }
    }

    public sealed class TestCorridorContext
    {
        public Dictionary<object, object> Map = new Dictionary<object, object>();
    }

    public sealed class TestCorridor
    {
        public TestSections Sections = new TestSections();
        public TestCorridorContext this[int index] { get { return new TestCorridorContext(); } }
    }

    public sealed class Alignment
    {
        public double DtmSizeLeft = 0.0;
        public double DtmSizeRight = 10.0;
        public TestPlan Plan = new TestPlan();
        public TestCorridor Corridor = new TestCorridor();
    }
}

namespace Topomatic.Lidar
{
    using Topomatic.Cad.Foundation;

    public class QuadTreeLeaf
    {
        public int minx, maxx, miny, maxy, start, count;
        public QuadTreeLeaf[] leafs;
    }

    public sealed class TestPointArray
    {
        private readonly Vector3F[] values;
        public TestPointArray(Vector3F[] points) { values = points; }
        public int Count { get { return values.Length; } }
        public Vector3F[] GetBuffer() { return values; }
    }

    public sealed class QuadTreeIndexer : QuadTreeLeaf
    {
        public TestPointArray points;
        public Vector3F scale = new Vector3F(1, 1, 1);
        public Vector3F position;
    }

    public sealed class LidarBuffer
    {
        public List<Vector4D> Points = new List<Vector4D>();
        public QuadTreeIndexer[] indexers = new QuadTreeIndexer[0];
        public Action<int> OnPoint;
        public bool ThrowOutOfMemory;
        public bool OpenBox;

        public void FindPoints(BoundingBox2D box, Action<Vector4D> callback)
        {
            if (ThrowOutOfMemory) throw new OutOfMemoryException("SDK probe");
            for (int i = 0; i < Points.Count; i++)
            {
                if (OnPoint != null) OnPoint(i);
                if (OpenBox && !(Points[i].X > box.MinX && Points[i].X < box.MaxX &&
                    Points[i].Y > box.MinY && Points[i].Y < box.MaxY)) continue;
                callback(Points[i]);
            }
        }
    }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
    }
}

namespace LAS_TERRAIN.Service
{
    internal static class LidarBufferService
    {
        internal static bool ValidateBuffers(List<Topomatic.Lidar.LidarBuffer> buffers)
        { return buffers != null && buffers.Count > 0; }
    }
}
