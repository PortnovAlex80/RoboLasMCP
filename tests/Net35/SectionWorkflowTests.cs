using System;
using System.Collections.Generic;
using System.Threading;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace Topomatic.Cad.Foundation
{
    // Only the coordinates used by SectionWorkflow are needed in this test assembly.
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

namespace LAS_TERRAIN.Tests
{
    internal static class SectionWorkflowTests
    {
        private static int assertions;

        private static void Check(bool condition, string message)
        {
            Interlocked.Increment(ref assertions);
            if (!condition) throw new Exception(message);
        }

        private static FilterOperationSnapshot Settings()
        {
            return new FilterOperationSnapshot(
                true, true, 0.01, 1, 1, 1,
                5, 8, 0.175, 0.80, 6, 5,
                3, 8, 0.25, 0, 0.05, 1e-4,
                256, 1e-9, 1, false, 0.3);
        }

        private static SectionRequest Request(int count, bool parallel, FilterOperationSnapshot settings)
        {
            LasSectionPoints[] sections = new LasSectionPoints[count];
            for (int i = 0; i < count; i++)
                sections[i].SectionPoints = new List<Vector2D>();
            return new SectionRequest(sections, 5.0, parallel, settings);
        }

        private static List<Vector3D> SampleFilter(double offset, LasSectionPoints section,
            int index, FilterOperationSnapshot settings)
        {
            if (offset != 5.0 || settings == null)
                throw new InvalidOperationException("Request was not passed to filter.");
            if (index == 0)
                return new List<Vector3D> {
                    new Vector3D(0, 0, 10), new Vector3D(1, 1, 11),
                    new Vector3D(-0.0002, 0, 12) };
            if (index == 1)
                return new List<Vector3D> {
                    new Vector3D(0.0005, 0, 20), new Vector3D(-0.0008, 0, 30),
                    new Vector3D(2, 2, 40) };
            return new List<Vector3D> { new Vector3D(3, 3, 50) };
        }

        private static void TestOrderingAndParallelAgreement()
        {
            FilterOperationSnapshot settings = Settings();
            List<Vector3D> expected = null;
            for (int mode = 0; mode < 2; mode++)
            {
                SectionRequest request = Request(3, mode == 1, settings);
                int callerThread = Thread.CurrentThread.ManagedThreadId;
                int progressCalls = 0;
                OperationResult<List<Vector3D>> result = SectionWorkflow.Calculate(
                    request,
                    delegate(double offset, LasSectionPoints section, int index,
                        FilterOperationSnapshot received)
                    {
                        Check(object.ReferenceEquals(received, settings), "settings changed between sections");
                        return SampleFilter(offset, section, index, received);
                    },
                    delegate { return false; },
                    delegate(SectionStage stage, float value)
                    {
                        Check(Thread.CurrentThread.ManagedThreadId == callerThread,
                            "progress called on a worker");
                        Check(value >= 0 && value <= 1, "progress outside 0..1");
                        progressCalls++;
                    });
                Check(result.Status == OperationStatus.Success, "expected success");
                Check(result.Value.Count == 5, "XY duplicate count changed");
                Check(result.Value[0].Z == 10 && result.Value[1].Z == 11 &&
                    result.Value[2].Z == 12 && result.Value[3].Z == 40 &&
                    result.Value[4].Z == 50, "first point or section ordering changed");
                Check(progressCalls > 0, "progress missing");
                for (int i = 0; i < request.Sections.Length; i++)
                    Check(request.Sections[i].SectionPoints == null, "section points not released");
                if (expected != null)
                    for (int i = 0; i < expected.Count; i++)
                        Check(result.Value[i].X == expected[i].X &&
                            result.Value[i].Y == expected[i].Y &&
                            result.Value[i].Z == expected[i].Z,
                            "parallel result differs from sequential result");
                expected = result.Value;
            }
        }

        private static void TestEmptyAndCancellation()
        {
            OperationResult<List<Vector3D>> empty = SectionWorkflow.Calculate(
                Request(0, true, Settings()), SampleFilter, null, null);
            Check(empty.Status == OperationStatus.Empty, "zero sections are not empty");
            Check(empty.Value == null, "empty result carries a point list");

            OperationResult<List<Vector3D>> before = SectionWorkflow.Calculate(
                Request(2, false, Settings()), SampleFilter,
                delegate { return true; }, null);
            Check(before.Status == OperationStatus.Cancelled &&
                before.Stage == SectionStage.Filter, "initial cancellation lost");

            bool cancelled = false;
            OperationResult<List<Vector3D>> duringFilter = SectionWorkflow.Calculate(
                Request(2, false, Settings()),
                delegate(double offset, LasSectionPoints section, int index,
                    FilterOperationSnapshot settings)
                {
                    cancelled = true;
                    return SampleFilter(offset, section, index, settings);
                },
                delegate { return cancelled; }, null);
            Check(duringFilter.Status == OperationStatus.Cancelled &&
                duringFilter.Stage == SectionStage.Filter && duringFilter.Value == null,
                "filter cancellation returned partial points");

            cancelled = false;
            OperationResult<List<Vector3D>> duringDedup = SectionWorkflow.Calculate(
                Request(3, false, Settings()), SampleFilter,
                delegate { return cancelled; },
                delegate(SectionStage stage, float value)
                {
                    if (stage == SectionStage.Deduplicate && value > 0) cancelled = true;
                });
            Check(duringDedup.Status == OperationStatus.Cancelled &&
                duringDedup.Stage == SectionStage.Deduplicate && duringDedup.Value == null,
                "deduplication cancellation returned partial points");
        }

        private static void TestFailureAndOverflow()
        {
            OperationResult<List<Vector3D>> failure = SectionWorkflow.Calculate(
                Request(1, false, Settings()),
                delegate(double offset, LasSectionPoints section, int index,
                    FilterOperationSnapshot settings)
                {
                    throw new InvalidOperationException("filter failed");
                }, null, null);
            Check(failure.Status == OperationStatus.Failed && failure.Value == null &&
                failure.Error is InvalidOperationException, "filter failure hidden");

            OperationResult<List<Vector3D>> overflow = SectionWorkflow.Calculate(
                Request(2, true, Settings()),
                delegate(double offset, LasSectionPoints section, int index,
                    FilterOperationSnapshot settings)
                {
                    throw new OutOfMemoryException("simulated capacity failure");
                }, null, null);
            Check(overflow.Status == OperationStatus.Overflow && overflow.Value == null &&
                overflow.Error is OutOfMemoryException, "overflow hidden");
        }

        public static int Main()
        {
            TestOrderingAndParallelAgreement();
            TestEmptyAndCancellation();
            TestFailureAndOverflow();
            Console.WriteLine("SectionWorkflow: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
