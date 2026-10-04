using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Infrastructure
{
    internal static class MemoryStatus
    {
        internal static long AvailableBytes = 1024L * 1024L * 1024L;

        public static long AvailablePhysicalBytes()
        {
            return AvailableBytes;
        }
    }
}

namespace Topomatic.Cad.Foundation
{
    public struct Vector3D
    {
        public double X, Y, Z;

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

namespace Topomatic.Sfc
{
    using Topomatic.Cad.Foundation;

    public sealed class SurfacePoint
    {
        public readonly Vector3D Position;

        public SurfacePoint(Vector3D position)
        {
            Position = position;
        }
    }

    public sealed class SurfacePointArray
    {
        private readonly List<SurfacePoint> points = new List<SurfacePoint>();

        public int AddCalls;
        public int RemoveCalls;
        public int RemoveAttempts;
        public int CapacityWrites;
        public int FailOnAddCall;
        public int FailOnRemoveAttempt;
        public bool FailAfterAppend;

        public int Count { get { return points.Count; } }

        public int Capacity
        {
            get { return points.Capacity; }
            set
            {
                CapacityWrites++;
                points.Capacity = value;
            }
        }

        public SurfacePoint this[int index] { get { return points[index]; } }

        public void Add(SurfacePoint point)
        {
            AddCalls++;
            if (AddCalls == FailOnAddCall && !FailAfterAppend)
                throw new InvalidOperationException("Injected Add failure before append.");
            points.Add(point);
            if (AddCalls == FailOnAddCall && FailAfterAppend)
                throw new InvalidOperationException("Injected Add failure after append.");
        }

        public void RemoveAt(int index)
        {
            if (index != points.Count - 1)
                throw new InvalidOperationException("Rollback removed a point outside the tail.");
            RemoveAttempts++;
            if (RemoveAttempts == FailOnRemoveAttempt)
                throw new InvalidOperationException("Injected rollback failure.");
            RemoveCalls++;
            points.RemoveAt(index);
        }
    }

    public sealed class SurfaceStyle
    {
        private bool dynamicValue;
        public int DynamicWrites;

        public bool Dynamic
        {
            get { return dynamicValue; }
            set
            {
                DynamicWrites++;
                dynamicValue = value;
            }
        }

        public void SetInitialDynamic(bool value)
        {
            dynamicValue = value;
            DynamicWrites = 0;
        }
    }

    public sealed class PointIndexer
    {
        public int InvalidateCalls;
        public int FailOnInvalidateCall;

        public void Invalidate()
        {
            InvalidateCalls++;
            if (InvalidateCalls == FailOnInvalidateCall)
                throw new InvalidOperationException("Injected index invalidation failure.");
        }
    }

    public sealed class Surface
    {
        public readonly SurfacePointArray Points = new SurfacePointArray();
        public readonly SurfaceStyle Style = new SurfaceStyle();
        public readonly PointIndexer PointIndexer = new PointIndexer();
        public int BeginUpdateCalls;
        public int EndUpdateCalls;
        public int UpdateDepth;
        public int FailOnBeginCall;
        public int FailOnEndCall;
        public bool FailAfterBegin;
        public bool FailAfterEnd;

        public void BeginUpdate()
        {
            BeginUpdateCalls++;
            if (BeginUpdateCalls == FailOnBeginCall && !FailAfterBegin)
                throw new InvalidOperationException("Injected BeginUpdate failure before state change.");
            UpdateDepth++;
            if (BeginUpdateCalls == FailOnBeginCall && FailAfterBegin)
                throw new InvalidOperationException("Injected BeginUpdate failure after state change.");
        }

        public void EndUpdate()
        {
            EndUpdateCalls++;
            if (EndUpdateCalls == FailOnEndCall && !FailAfterEnd)
                throw new InvalidOperationException("Injected EndUpdate failure before state change.");
            UpdateDepth--;
            if (EndUpdateCalls == FailOnEndCall && FailAfterEnd)
                throw new InvalidOperationException("Injected EndUpdate failure after state change.");
        }
    }
}
