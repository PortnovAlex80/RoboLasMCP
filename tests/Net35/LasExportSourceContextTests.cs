using System;
using System.Collections.Generic;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.View;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Tests
{
    internal static class LasExportSourceContextTests
    {
        private static int _checks;
        private static CadView _view;
        private static Alignment _selected;
        private static List<LidarBuffer> _buffers;

        private static void Check(bool condition, string message)
        {
            _checks++;
            if (!condition) throw new Exception(message);
        }

        private static LasExportSourceContext Fresh()
        {
            var project = new Project();
            ApplicationHost.Current = new ApplicationHost {
                ActiveProject = project, ActiveDocument = new object() };
            _view = new CadView();
            _selected = new Alignment { Model = new Model { Project = project } };
            ApplicationHost.Current.ActiveAlignment = new Alignment();
            _buffers = new List<LidarBuffer> { new LidarBuffer() };
            LidarBufferService.Buffers = _buffers;
            LidarBufferService.LastSelected = null;
            LidarBufferService.ThrowOnCollect = false;
            LasExportSourceContext result = LasExportSourceContext.Capture(
                _view, _selected, _buffers);
            Check(result != null, "valid capture");
            return result;
        }

        private static void Reject(Action change, string message)
        {
            LasExportSourceContext context = Fresh();
            change();
            Check(!context.IsCurrent(), message);
        }

        public static int Main()
        {
            try
            {
                LasExportSourceContext unchanged = Fresh();
                Check(unchanged.IsCurrent(), "unchanged source remains current");
                Check(Object.ReferenceEquals(LidarBufferService.LastSelected, _selected),
                    "recollect selected alignment, not active alignment");

                // A selected alignment may differ from the host's active receiver.
                Check(!Object.ReferenceEquals(ApplicationHost.Current.ActiveAlignment,
                    _selected) && unchanged.IsCurrent(),
                    "no active alignment dependency");

                Reject(delegate { ApplicationHost.Current.ActiveProject = new Project(); },
                    "project switch");
                Reject(delegate { ApplicationHost.Current.ActiveDocument = new object(); },
                    "document switch");
                Reject(delegate { ApplicationHost.Current = new ApplicationHost {
                    ActiveProject = ApplicationHost.Current.ActiveProject,
                    ActiveDocument = ApplicationHost.Current.ActiveDocument }; },
                    "host switch");
                Reject(delegate { _view.IsDisposed = true; }, "view disposed");
                Reject(delegate { _view.IsHandleCreated = false; }, "view handle lost");
                Reject(delegate { _selected.Model = new Model {
                    Project = ApplicationHost.Current.ActiveProject }; }, "model switch");
                Reject(delegate { _selected.Model.Project = new Project(); },
                    "model project switch");
                Reject(delegate { _selected.Id = Guid.NewGuid(); }, "alignment ID switch");
                Reject(delegate { _selected.Plan = new Plan();
                    _selected.Plan.CompoundLine.Length = 11; }, "plan length change");
                Reject(delegate { _selected.DtmSizeLeft = 3; }, "left offset change");
                Reject(delegate { _selected.DtmSizeRight = 3; }, "right offset change");

                Fresh();
                _selected.Plan.CompoundLine.Length = Double.NaN;
                LasExportSourceContext invalidLength = LasExportSourceContext.Capture(
                    _view, _selected, _buffers);
                Check(invalidLength != null && invalidLength.IsCurrent(),
                    "NaN plan length reaches existing planner validation");
                _selected.Plan.CompoundLine.Length = Double.PositiveInfinity;
                Check(!invalidLength.IsCurrent(), "NaN-to-infinity plan change");

                Fresh();
                _selected.DtmSizeLeft = Double.NegativeInfinity;
                LasExportSourceContext invalidOffset = LasExportSourceContext.Capture(
                    _view, _selected, _buffers);
                Check(invalidOffset != null && invalidOffset.IsCurrent(),
                    "infinite offset reaches existing collector validation");
                _selected.DtmSizeLeft = Double.PositiveInfinity;
                Check(!invalidOffset.IsCurrent(), "infinite offset sign change");

                Reject(delegate { LidarBufferService.Buffers = new List<LidarBuffer> {
                    new LidarBuffer() }; }, "buffer identity switch");
                Reject(delegate { LidarBufferService.Buffers = new List<LidarBuffer>(); },
                    "buffer removal");
                Reject(delegate { LidarBufferService.Buffers = new List<LidarBuffer> {
                    _buffers[0], new LidarBuffer() }; }, "buffer addition");
                Reject(delegate { LidarBufferService.Buffers = new List<LidarBuffer> {
                    new LidarBuffer(), _buffers[0] }; }, "buffer reordering");
                LasExportSourceContext first = Fresh();
                _buffers.Add(new LidarBuffer());
                LasExportSourceContext ordered = LasExportSourceContext.Capture(
                    _view, _selected, _buffers);
                Check(first != null && ordered != null && ordered.IsCurrent(),
                    "two buffers captured");
                LidarBuffer swap = _buffers[0];
                _buffers[0] = _buffers[1];
                _buffers[1] = swap;
                Check(!ordered.IsCurrent(), "same-count buffer order change");
                Reject(delegate { _buffers[0].fullpath = @"C:\fixture\other.las"; },
                    "buffer path change");
                Reject(delegate { _buffers[0].indexers = new QuadTreeIndexer[] {
                    _buffers[0].indexers[0] }; }, "indexer array switch");
                Reject(delegate { _buffers[0].indexers[0] = new QuadTreeIndexer(); },
                    "indexer identity switch");
                Reject(delegate { _buffers[0].indexers[0].points = new PointArray(); },
                    "points object switch");
                Reject(delegate { _buffers[0].indexers[0].points.Values = new object[2]; },
                    "point array switch");
                Reject(delegate { _buffers[0].indexers[0].points.Count = 1; },
                    "point count change");
                Reject(delegate { _buffers[0].indexers[0].weights = new WeightArray(); },
                    "weight object switch");
                Reject(delegate { _buffers[0].indexers[0].weights.Values = new byte[1]; },
                    "weight array switch");
                Reject(delegate { _buffers[0].indexers[0].weights.Count = 1; },
                    "weight logical count change");
                Reject(delegate { _buffers[0].indexers[0].scale = new Vector3D(2, 1, 1); },
                    "scale change");
                Reject(delegate { _buffers[0].indexers[0].position = new Vector3D(1, 0, 0); },
                    "position change");

                Fresh();
                _buffers[0].indexers[0].scale = new Vector3D(Double.NaN, 1, 1);
                _buffers[0].indexers[0].position = new Vector3D(0, Double.NaN, 0);
                LasExportSourceContext nanTransform = LasExportSourceContext.Capture(
                    _view, _selected, _buffers);
                Check(nanTransform != null && nanTransform.IsCurrent(),
                    "unchanged NaN transform remains current");
                _buffers[0].indexers[0].position = new Vector3D(0, 0, 0);
                Check(!nanTransform.IsCurrent(), "NaN transform change detected");
                Reject(delegate { LidarBufferService.ThrowOnCollect = true; },
                    "collection exception fails closed");
                Reject(delegate { _buffers[0].indexers[0].points.ThrowOnGetBuffer = true; },
                    "point metadata exception fails closed");

                LasExportSourceContext noView = LasExportSourceContext.Capture(
                    null, _selected, _buffers);
                Check(noView == null, "invalid view capture");
                LasExportSourceContext noBuffers = LasExportSourceContext.Capture(
                    _view, _selected, new List<LidarBuffer>());
                Check(noBuffers == null, "empty buffer capture");
                Console.WriteLine("LAS export source context: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return 1;
            }
        }
    }
}
