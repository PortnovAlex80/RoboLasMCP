using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Tests
{
    internal static class FastSurfaceBuilderFailureTests
    {
        private static int assertions;

        private static void Check(bool condition, string description)
        {
            assertions++;
            if (!condition) throw new Exception(description);
        }

        private static Surface SeedSurface(bool dynamicValue,
            out SurfacePoint first, out SurfacePoint second)
        {
            Surface surface = new Surface();
            first = new SurfacePoint(new Vector3D(100, 200, 300));
            second = new SurfacePoint(new Vector3D(101, 201, 301));
            surface.Points.Add(first);
            surface.Points.Add(second);
            surface.Style.SetInitialDynamic(dynamicValue);
            surface.Points.AddCalls = 0;
            return surface;
        }

        private static List<Vector3D> NewPoints()
        {
            return new List<Vector3D> {
                new Vector3D(1, 2, 3),
                new Vector3D(4, 5, 6),
                new Vector3D(7, 8, 9)
            };
        }

        private static void CheckOriginalPrefix(Surface surface,
            SurfacePoint first, SurfacePoint second)
        {
            Check(surface.Points.Count == 2, "Original point count changed.");
            Check(object.ReferenceEquals(surface.Points[0], first), "First original point changed.");
            Check(object.ReferenceEquals(surface.Points[1], second), "Second original point changed.");
        }

        private static void TestSuccessfulInsertion()
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(true, out first, out second);
            FastSurfaceBuilder.InsertPoints(NewPoints(), surface);

            Check(surface.Points.Count == 5, "Successful insertion count is wrong.");
            Check(object.ReferenceEquals(surface.Points[0], first) &&
                object.ReferenceEquals(surface.Points[1], second), "Original points changed on success.");
            Check(surface.Points[2].Position.X == 1 &&
                surface.Points[3].Position.X == 4 &&
                surface.Points[4].Position.X == 7, "Inserted point order changed.");
            Check(surface.Style.Dynamic, "Dynamic was not restored on success.");
            Check(surface.PointIndexer.InvalidateCalls > 0, "Indexer was not invalidated on success.");
            Check(surface.BeginUpdateCalls == 1 && surface.EndUpdateCalls == 1,
                "Expected one update pair on success.");
        }

        private static void TestAddFailure(bool failAfterAppend, bool dynamicValue)
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(dynamicValue, out first, out second);
            surface.Points.FailOnAddCall = 2;
            surface.Points.FailAfterAppend = failAfterAppend;

            bool threw = false;
            try
            {
                FastSurfaceBuilder.InsertPoints(NewPoints(), surface);
            }
            catch (InvalidOperationException)
            {
                threw = true;
            }

            Check(threw, "Injected Add failure was hidden.");
            CheckOriginalPrefix(surface, first, second);
            Check(surface.Points.RemoveCalls == (failAfterAppend ? 2 : 1),
                "Rollback did not remove exactly the added tail.");
            Check(surface.Style.Dynamic == dynamicValue, "Dynamic was not restored after Add failure.");
            Check(surface.PointIndexer.InvalidateCalls > 0,
                "Indexer was not invalidated after Add failure.");
        }

        private static void TestMemoryGuard()
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(true, out first, out second);
            MemoryStatus.AvailableBytes = 100;
            bool threw = false;
            try
            {
                FastSurfaceBuilder.InsertPoints(NewPoints(), surface);
            }
            catch (OutOfMemoryException)
            {
                threw = true;
            }
            finally
            {
                MemoryStatus.AvailableBytes = 1024L * 1024L * 1024L;
            }

            Check(threw, "Insufficient memory was accepted.");
            CheckOriginalPrefix(surface, first, second);
            Check(surface.Points.AddCalls == 0 && surface.Points.RemoveCalls == 0 &&
                surface.Points.CapacityWrites == 0, "Memory guard changed the point array.");
            Check(surface.Style.Dynamic && surface.Style.DynamicWrites == 0,
                "Memory guard changed Dynamic.");
            Check(surface.PointIndexer.InvalidateCalls == 0 &&
                surface.BeginUpdateCalls == 0 && surface.EndUpdateCalls == 0,
                "Memory guard touched the index or update state.");
        }

        private static void TestCompensationFailureIsReported()
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(true, out first, out second);
            surface.Points.FailOnAddCall = 2;
            surface.Points.FailAfterAppend = true;
            surface.Points.FailOnRemoveAttempt = 1;

            InvalidOperationException failure = null;
            try
            {
                FastSurfaceBuilder.InsertPoints(NewPoints(), surface);
            }
            catch (InvalidOperationException error)
            {
                failure = error;
            }

            Check(failure != null, "Compensation failure was hidden.");
            Check(failure.Message.IndexOf("compensation was incomplete") >= 0,
                "Compensation failure was not identified to the caller.");
            Check(failure.InnerException != null &&
                failure.InnerException.Message == "Injected rollback failure.",
                "Original compensation error was lost.");
            Check(surface.Points.Count == 4 &&
                object.ReferenceEquals(surface.Points[0], first) &&
                object.ReferenceEquals(surface.Points[1], second),
                "Test did not reproduce a partially compensated surface.");
            Check(surface.Style.Dynamic, "Dynamic was not restored after compensation failure.");
            SurfaceApplyException status = failure as SurfaceApplyException;
            Check(status != null && !status.PointsRestored && status.DynamicRestored &&
                !status.UpdateStateUnknown && status.ApplyError != null,
                "Incomplete append compensation status was not exposed.");
        }

        private static void TestIndexFailure()
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(false, out first, out second);
            surface.PointIndexer.FailOnInvalidateCall = 1;
            bool failed = false;
            try { FastSurfaceBuilder.InsertPoints(NewPoints(), surface); }
            catch (InvalidOperationException error)
            {
                failed = error.Message == "Injected index invalidation failure.";
            }
            Check(failed, "Index failure was hidden after successful compensation.");
            CheckOriginalPrefix(surface, first, second);
            Check(!surface.Style.Dynamic, "Dynamic changed after index failure.");
            Check(surface.PointIndexer.InvalidateCalls == 2,
                "Indexer was not invalidated after point compensation.");
            Check(surface.BeginUpdateCalls == 0 && surface.EndUpdateCalls == 0,
                "Notification started after index failure.");
        }

        private static void TestNotificationFailure(bool failBegin, bool failAfterStateChange)
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(true, out first, out second);
            if (failBegin)
            {
                surface.FailOnBeginCall = 1;
                surface.FailAfterBegin = failAfterStateChange;
            }
            else
            {
                surface.FailOnEndCall = 1;
                surface.FailAfterEnd = failAfterStateChange;
            }

            SurfaceApplyException status = null;
            try { FastSurfaceBuilder.InsertPoints(NewPoints(), surface); }
            catch (SurfaceApplyException error) { status = error; }

            Check(status != null, "SDK notification failure was not classified.");
            Check(status.PointsRestored && status.IndexRestored && status.DynamicRestored,
                "Point, index or Dynamic compensation failed unexpectedly.");
            Check(status.UpdateStateUnknown && status.ApplyError != null,
                "SDK update state was incorrectly claimed to be restored.");
            Check(status.CompensationError == null,
                "Unexpected compensation error was reported.");
            CheckOriginalPrefix(surface, first, second);
            Check(surface.Style.Dynamic, "Dynamic was not restored after notification failure.");
            Check(surface.PointIndexer.InvalidateCalls == 2,
                "Indexer was not invalidated after notification failure.");
            Check(surface.BeginUpdateCalls == 1 &&
                surface.EndUpdateCalls == (failBegin ? 0 : 1),
                "Notification call order changed.");
            Check(surface.UpdateDepth == (failAfterStateChange && failBegin ||
                !failAfterStateChange && !failBegin ? 1 : 0),
                "Test did not model an uncertain SDK update state.");
        }

        private static void TestNotificationAndRollbackFailure()
        {
            SurfacePoint first, second;
            Surface surface = SeedSurface(true, out first, out second);
            surface.FailOnEndCall = 1;
            surface.Points.FailOnRemoveAttempt = 1;
            SurfaceApplyException status = null;
            try { FastSurfaceBuilder.InsertPoints(NewPoints(), surface); }
            catch (SurfaceApplyException error) { status = error; }

            Check(status != null && !status.PointsRestored && status.UpdateStateUnknown,
                "Combined notification and rollback failure was not classified.");
            Check(status.CompensationError != null && status.ApplyError != null,
                "Combined failure lost an error cause.");
            Check(surface.Points.Count == 5 &&
                object.ReferenceEquals(surface.Points[0], first) &&
                object.ReferenceEquals(surface.Points[1], second),
                "Combined failure did not preserve the original prefix.");
            Check(surface.Style.Dynamic, "Dynamic was not restored after rollback failure.");
        }

        public static int Main()
        {
            TestSuccessfulInsertion();
            TestAddFailure(false, true);
            TestAddFailure(true, false);
            TestMemoryGuard();
            TestCompensationFailureIsReported();
            TestIndexFailure();
            TestNotificationFailure(true, false);
            TestNotificationFailure(true, true);
            TestNotificationFailure(false, false);
            TestNotificationFailure(false, true);
            TestNotificationAndRollbackFailure();
            Console.WriteLine("FastSurfaceBuilder failure tests: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
