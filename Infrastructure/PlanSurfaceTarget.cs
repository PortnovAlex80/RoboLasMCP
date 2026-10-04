using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LAS_TERRAIN.Application;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Lidar;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Captures one Plan calculation's source and destination. The v1 polygon
    /// directory still comes from the first LiDAR buffer, not the project URI.
    /// Host state is read only on the CAD UI thread.
    /// </summary>
    internal sealed class PlanSurfaceTarget
    {
        private readonly CadView _view;
        private readonly SurfaceLayer _layer;
        private readonly Surface _surface;
        private readonly Alignment _alignment;
        private readonly Guid _alignmentId;
        private readonly object _model;
        private readonly object _project;
        private readonly object _document;
        private readonly BorrowedLidarSourceSnapshot _source;

        internal string ProjectPath { get; private set; }
        internal List<LidarBuffer> Buffers { get; private set; }

        private PlanSurfaceTarget(CadView view, SurfaceLayer layer, Alignment alignment,
            Guid alignmentId, object model, object project, object document,
            List<LidarBuffer> buffers, BorrowedLidarSourceSnapshot source,
            string projectPath)
        {
            _view = view;
            _layer = layer;
            _surface = layer.Surface;
            _alignment = alignment;
            _alignmentId = alignmentId;
            _model = model;
            _project = project;
            _document = document;
            _source = source;
            Buffers = buffers;
            ProjectPath = projectPath;
        }

        internal static PlanSurfaceTarget Capture(CadView view, SurfaceLayer layer,
            Alignment alignment, List<LidarBuffer> buffers)
        {
            if (view == null || layer == null || layer.Surface == null ||
                alignment == null || buffers == null || buffers.Count == 0)
                return null;

            string path = null;
            foreach (LidarBuffer buffer in buffers)
            {
                if (buffer != null && !String.IsNullOrEmpty(buffer.fullpath))
                {
                    path = Path.GetDirectoryName(buffer.fullpath);
                    break;
                }
            }
            if (String.IsNullOrEmpty(path)) return null;

            var host = ApplicationHost.Current;
            var model = PluginCoreOps.FindModel(alignment);
            if (host == null || host.ActiveProject == null || host.ActiveDocument == null ||
                model == null || !Object.ReferenceEquals(model.Project, host.ActiveProject))
                return null;

            try
            {
                Guid id = AlignmentValueConverter.GetId(alignment);
                var source = BorrowedLidarSourceSnapshot.Capture(buffers);
                return new PlanSurfaceTarget(view, layer, alignment, id, model,
                    host.ActiveProject, host.ActiveDocument, buffers, source, path);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>Checks the active receiver while it is already open for scanning.</summary>
        internal bool IsCurrent(Alignment activeAlignment)
        {
            try
            {
                var host = ApplicationHost.Current;
                if (_view == null || _view.IsDisposed || !_view.IsHandleCreated ||
                    host == null || !Object.ReferenceEquals(host.ActiveProject, _project) ||
                    !Object.ReferenceEquals(host.ActiveDocument, _document) ||
                    !Object.ReferenceEquals(SurfaceLayer.GetSurfaceLayer(_view), _layer) ||
                    !Object.ReferenceEquals(_layer.Surface, _surface) ||
                    !Object.ReferenceEquals(activeAlignment, _alignment) ||
                    AlignmentValueConverter.GetId(activeAlignment) != _alignmentId)
                    return false;

                var model = PluginCoreOps.FindModel(activeAlignment);
                return Object.ReferenceEquals(model, _model) &&
                    model != null && Object.ReferenceEquals(model.Project, _project) &&
                    _source.Matches(LidarBufferService.CollectBuffers(activeAlignment));
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal void Apply(List<Vector3D> points)
        {
            if (points == null) throw new ArgumentNullException("points");
            if (_view.IsDisposed || !_view.IsHandleCreated)
                throw new InvalidOperationException("Окно плана закрыто до применения результата.");

            MethodInvoker apply = delegate
            {
                if (points.Count == 0)
                {
                    using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                    {
                        if (!IsCurrent(receiver.Alignment))
                            throw new InvalidOperationException(
                                "Трасса, проект, окно или поверхность изменились до применения результата.");
                    }
                    return;
                }
                var writer = new TopomaticSurfaceWriter(_surface, delegate
                {
                    using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                        return IsCurrent(receiver.Alignment);
                });
                writer.Apply(points);
            };
            if (_view.InvokeRequired)
                _view.Invoke(apply);
            else
                apply();
        }
    }
}
