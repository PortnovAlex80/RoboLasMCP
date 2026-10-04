using System;
using System.Collections.Generic;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.Tools;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;
using Topomatic.Sfc;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.Tests
{
    public static class LidarBufferServiceTests
    {
        private sealed class ChangingProvider : ILidarBufferContainer
        {
            private readonly LidarBuffer _first;
            private readonly LidarBuffer _later;
            public int Calls;

            public ChangingProvider(LidarBuffer first, LidarBuffer later)
            { _first = first; _later = later; }

            public LidarBuffer GetBuffer()
            { return ++Calls == 1 ? _first : _later; }
        }

        private static int _checks;
        private static void Check(bool condition, string message)
        {
            _checks++;
            if (!condition) throw new Exception(message);
        }

        private static void CollectsEachProviderOnceInSurfaceOrder()
        {
            AlignLibrary.Results.Clear();
            AlignLibrary.Found = true;
            Alignment alignment = new Alignment();
            alignment.Model = new object();
            alignment.EgSurfaceRelativePaths.Add("first");
            alignment.EgSurfaceRelativePaths.Add("second");

            LidarBuffer first = new LidarBuffer();
            LidarBuffer second = new LidarBuffer();
            ChangingProvider changing = new ChangingProvider(first, second);
            ChangingProvider empty = new ChangingProvider(null, second);
            Surface left = new Surface();
            left.ProxySourceProviders.Add(new object());
            left.ProxySourceProviders.Add(changing);
            left.ProxySourceProviders.Add(empty);
            Surface right = new Surface();
            right.ProxySourceProviders.Add(new ChangingProvider(second, first));
            AlignLibrary.Results.Add(null);
            AlignLibrary.Results.Add(left);
            AlignLibrary.Results.Add(right);

            List<LidarBuffer> buffers = LidarBufferService.CollectBuffers(alignment);
            Check(buffers.Count == 2, "only non-null buffers are returned");
            Check(Object.ReferenceEquals(buffers[0], first), "first provider's first buffer");
            Check(Object.ReferenceEquals(buffers[1], second), "surface and provider order");
            Check(changing.Calls == 1, "stateful provider queried once");
            Check(empty.Calls == 1, "null-producing provider queried once");
            Check(Object.ReferenceEquals(AlignLibrary.LastModel, alignment.Model),
                "selected alignment model supplied to SDK");
            Check(Object.ReferenceEquals(AlignLibrary.LastPaths,
                alignment.EgSurfaceRelativePaths), "selected source paths supplied to SDK");

            AlignLibrary.Found = false;
            buffers = LidarBufferService.CollectBuffers(alignment);
            Check(buffers.Count == 0, "failed SDK lookup returns empty source list");
            Check(changing.Calls == 1, "failed lookup never queries providers");
        }

        private static void PreservesPointOrderAndWeight()
        {
            LidarBuffer first = new LidarBuffer();
            first.Points.Add(new LidarPoint(1, 2, 3, 4));
            first.Points.Add(new LidarPoint(-5, 6, 7, 8));
            LidarBuffer second = new LidarBuffer();
            second.Points.Add(new LidarPoint(9, 10, 11, 12));
            List<Vector4D> result = LidarBufferService.FindPoints(
                new LidarBuffer[] { first, null, second }, new BoundingBox2D());
            Check(result.Count == 3, "all points from non-null buffers");
            Check(result[0].X == 1 && result[0].W == 4,
                "first point and weight");
            Check(result[1].X == -5 && result[1].W == 8,
                "second point and weight");
            Check(result[2].X == 9 && result[2].W == 12,
                "next buffer follows first");

            MessageDlg.Calls = 0;
            Check(!LidarBufferService.ValidateBuffers(new List<LidarBuffer>()),
                "missing source rejected");
            Check(MessageDlg.Calls == 1, "missing source reported");
            Check(LidarBufferService.ValidateBuffers(new List<LidarBuffer> { first }),
                "present source accepted");
            Check(MessageDlg.Calls == 1, "present source has no warning");
        }

        private static void SharedBufferIsCountedOnce()
        {
            AlignLibrary.Results.Clear();
            AlignLibrary.Found = true;
            Alignment alignment = new Alignment();
            LidarBuffer shared = new LidarBuffer();
            LidarBuffer distinct = new LidarBuffer();
            Surface first = new Surface();
            Surface second = new Surface();
            first.ProxySourceProviders.Add(new ChangingProvider(shared, distinct));
            second.ProxySourceProviders.Add(new ChangingProvider(shared, distinct));
            second.ProxySourceProviders.Add(new ChangingProvider(distinct, shared));
            AlignLibrary.Results.Add(first);
            AlignLibrary.Results.Add(second);

            List<LidarBuffer> buffers = LidarBufferService.CollectBuffers(alignment);
            Check(buffers.Count == 2, "shared cloud must not be exported twice");
            Check(Object.ReferenceEquals(buffers[0], shared) &&
                Object.ReferenceEquals(buffers[1], distinct),
                "first encounter determines stable cloud order");
        }

        public static int Main()
        {
            CollectsEachProviderOnceInSurfaceOrder();
            PreservesPointOrderAndWeight();
            SharedBufferIsCountedOnce();
            Console.WriteLine("LidarBufferServiceTests: " + _checks + " checks passed");
            return 0;
        }
    }
}
