using System;
using System.Collections.Generic;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Tests
{
    internal static class TopomaticSurfaceWriterTests
    {
        private static int assertions;

        private static void Check(bool condition, string message)
        {
            assertions++;
            if (!condition) throw new Exception(message);
        }

        private static List<Vector3D> Points()
        {
            return new List<Vector3D> {
                new Vector3D(1, 2, 3), new Vector3D(4, 5, 6)
            };
        }

        private static void TestCapturedTarget()
        {
            Surface captured = new Surface();
            Surface other = new Surface();
            Surface active = captured;
            int checks = 0;
            TopomaticSurfaceWriter writer = new TopomaticSurfaceWriter(captured, delegate
            {
                checks++;
                return Object.ReferenceEquals(active, captured);
            });

            active = other;
            bool rejected = false;
            try { writer.Apply(Points()); }
            catch (InvalidOperationException) { rejected = true; }
            Check(rejected && checks == 1, "Changed target was not rejected once.");
            Check(captured.Points.Count == 0 && other.Points.Count == 0,
                "Changed target was mutated.");
            Check(captured.Style.DynamicWrites == 0 && captured.BeginUpdateCalls == 0,
                "Changed target entered SDK mutation.");

            active = captured;
            writer.Apply(Points());
            Check(checks == 2, "Target was not checked immediately before retry.");
            Check(captured.Points.Count == 2 && other.Points.Count == 0,
                "Result was not applied to the captured surface only.");
            Check(captured.Points[0].Position.X == 1 &&
                captured.Points[1].Position.X == 4,
                "Point order changed in the delegate builder path.");
            Check(captured.BeginUpdateCalls == 1 && captured.EndUpdateCalls == 1,
                "Writer bypassed the builder notification sequence.");
        }

        private static void TestEmptyResult()
        {
            Surface captured = new Surface();
            int checks = 0;
            TopomaticSurfaceWriter writer = new TopomaticSurfaceWriter(captured, delegate
            {
                checks++;
                return false;
            });
            writer.Apply(null);
            writer.Apply(new List<Vector3D>());
            Check(checks == 0 && captured.Points.Count == 0,
                "Empty result should not enter target validation or SDK mutation.");
            Check(captured.Style.DynamicWrites == 0 && captured.BeginUpdateCalls == 0,
                "Empty result changed SDK state.");
        }

        private static void TestValidationException()
        {
            Surface captured = new Surface();
            Exception expected = new InvalidOperationException("Target lookup failed.");
            TopomaticSurfaceWriter writer = new TopomaticSurfaceWriter(captured, delegate
            {
                throw expected;
            });
            Exception actual = null;
            try { writer.Apply(Points()); }
            catch (Exception error) { actual = error; }
            Check(Object.ReferenceEquals(expected, actual),
                "Target lookup failure was hidden or changed.");
            Check(captured.Points.Count == 0 && captured.Style.DynamicWrites == 0,
                "Target lookup failure reached SDK mutation.");
        }

        private static void TestBuilderFailure(bool afterAppend)
        {
            Surface captured = new Surface();
            SurfacePoint original = new SurfacePoint(new Vector3D(100, 200, 300));
            captured.Points.Add(original);
            captured.Points.AddCalls = 0;
            captured.Points.FailOnAddCall = 2;
            captured.Points.FailAfterAppend = afterAppend;
            TopomaticSurfaceWriter writer = new TopomaticSurfaceWriter(captured,
                delegate { return true; });
            bool failed = false;
            try { writer.Apply(Points()); }
            catch (InvalidOperationException error)
            {
                failed = error.Message.IndexOf("Injected Add failure") >= 0;
            }
            Check(failed, "Builder failure was not forwarded.");
            Check(captured.Points.Count == 1 &&
                Object.ReferenceEquals(captured.Points[0], original),
                "Writer failed to preserve builder tail compensation.");
            Check(captured.PointIndexer.InvalidateCalls == 1 &&
                captured.BeginUpdateCalls == 0,
                "Builder failure changed index or notification behavior.");
        }

        private static void TestUnknownSdkUpdateState()
        {
            Surface captured = new Surface();
            captured.FailOnEndCall = 1;
            TopomaticSurfaceWriter writer = new TopomaticSurfaceWriter(captured,
                delegate { return true; });
            SurfaceApplyException status = null;
            try { writer.Apply(Points()); }
            catch (SurfaceApplyException error) { status = error; }
            Check(status != null && status.PointsRestored && status.UpdateStateUnknown,
                "Writer hid the unknown SDK update state.");
            Check(captured.Points.Count == 0 && captured.Style.Dynamic == false,
                "Writer did not delegate point compensation.");
        }

        public static int Main()
        {
            TestCapturedTarget();
            TestEmptyResult();
            TestValidationException();
            TestBuilderFailure(false);
            TestBuilderFailure(true);
            TestUnknownSdkUpdateState();
            Console.WriteLine("Topomatic surface writer: {0} assertions passed.", assertions);
            return 0;
        }
    }
}
