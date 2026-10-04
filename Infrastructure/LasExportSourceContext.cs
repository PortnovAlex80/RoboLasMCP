using System;
using System.Collections.Generic;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.View;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Pins a selected LAS export source across dialogs and progress windows.
    /// Capture and IsCurrent must run on the CAD UI thread. Neither operation
    /// reads point values or copies the potentially large point arrays.
    /// </summary>
    internal sealed class LasExportSourceContext
    {
        private readonly CadView _view;
        private readonly Alignment _alignment;
        private readonly Guid _alignmentId;
        private readonly object _host;
        private readonly object _model;
        private readonly object _project;
        private readonly object _document;
        private readonly double _planLength;
        private readonly double _dtmLeft;
        private readonly double _dtmRight;
        private readonly BorrowedLidarSourceSnapshot _buffers;

        private LasExportSourceContext(CadView view, Alignment alignment,
            Guid alignmentId, object host, object model,
            object project, object document,
            double planLength, double dtmLeft, double dtmRight,
            BorrowedLidarSourceSnapshot buffers)
        {
            _view = view;
            _alignment = alignment;
            _alignmentId = alignmentId;
            _host = host;
            _model = model;
            _project = project;
            _document = document;
            _planLength = planLength;
            _dtmLeft = dtmLeft;
            _dtmRight = dtmRight;
            _buffers = buffers;
        }

        internal static LasExportSourceContext Capture(CadView view,
            Alignment selected, List<LidarBuffer> buffers)
        {
            try
            {
                if (view == null || view.IsDisposed || !view.IsHandleCreated ||
                    selected == null || selected.Plan == null ||
                    selected.Plan.CompoundLine == null || buffers == null ||
                    buffers.Count == 0)
                    return null;

                var host = ApplicationHost.Current;
                var model = PluginCoreOps.FindModel(selected);
                if (host == null || host.ActiveProject == null ||
                    host.ActiveDocument == null || model == null ||
                    !Object.ReferenceEquals(model.Project, host.ActiveProject))
                    return null;

                double length = selected.Plan.CompoundLine.Length;
                double left = selected.DtmSizeLeft;
                double right = selected.DtmSizeRight;

                foreach (LidarBuffer buffer in buffers)
                    if (buffer == null) return null;
                var snapshots = BorrowedLidarSourceSnapshot.Capture(buffers);
                return new LasExportSourceContext(view, selected,
                    AlignmentValueConverter.GetId(selected), host, model,
                    host.ActiveProject, host.ActiveDocument, length, left, right,
                    snapshots);
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal bool IsCurrent()
        {
            try
            {
                var host = ApplicationHost.Current;
                if (_view == null || _view.IsDisposed || !_view.IsHandleCreated ||
                    !Object.ReferenceEquals(host, _host) ||
                    !Object.ReferenceEquals(host.ActiveProject, _project) ||
                    !Object.ReferenceEquals(host.ActiveDocument, _document) ||
                    AlignmentValueConverter.GetId(_alignment) != _alignmentId ||
                    _alignment.Plan == null || _alignment.Plan.CompoundLine == null ||
                    !SameBits(_alignment.Plan.CompoundLine.Length, _planLength) ||
                    !SameBits(_alignment.DtmSizeLeft, _dtmLeft) ||
                    !SameBits(_alignment.DtmSizeRight, _dtmRight))
                    return false;

                var model = PluginCoreOps.FindModel(_alignment);
                if (!Object.ReferenceEquals(model, _model) || model == null ||
                    !Object.ReferenceEquals(model.Project, _project))
                    return false;

                List<LidarBuffer> current = LidarBufferService.CollectBuffers(_alignment);
                return _buffers.Matches(current);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool SameBits(double current, double captured)
        {
            return BitConverter.DoubleToInt64Bits(current) ==
                BitConverter.DoubleToInt64Bits(captured);
        }

    }
}
