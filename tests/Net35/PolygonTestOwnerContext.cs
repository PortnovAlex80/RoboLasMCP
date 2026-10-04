using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.View;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>Host ownership and borrowed-source guard for isolated command fixtures.</summary>
    internal sealed class PolygonTestOwnerContext
    {
        private readonly CadView _view;
        private readonly Alignment _alignment;
        private readonly Guid _alignmentId;
        private readonly object _model;
        private readonly object _project;
        private readonly object _document;
        private readonly BorrowedLidarSourceSnapshot _source;

        internal string DirectoryPath { get; private set; }

        private PolygonTestOwnerContext(CadView view, Alignment alignment,
            Guid alignmentId, object model, object project, object document,
            string directoryPath, List<LidarBuffer> buffers)
        {
            _view = view;
            _alignment = alignment;
            _alignmentId = alignmentId;
            _model = model;
            _project = project;
            _document = document;
            DirectoryPath = directoryPath;
            _source = BorrowedLidarSourceSnapshot.Capture(buffers);
        }

        internal static PolygonTestOwnerContext Capture(CadView view)
        {
            if (view == null || view.IsDisposed || !view.IsHandleCreated)
                return null;
            using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                Alignment alignment = receiver.Alignment;
                if (alignment == null) return null;
                var host = ApplicationHost.Current;
                var model = PluginCoreOps.FindModel(alignment);
                if (host == null || host.ActiveProject == null ||
                    host.ActiveDocument == null || model == null ||
                    !Object.ReferenceEquals(model.Project, host.ActiveProject))
                    return null;

                List<LidarBuffer> buffers = LidarBufferService.CollectBuffers(alignment);
                string path = GetDirectory(buffers);
                if (String.IsNullOrEmpty(path)) return null;
                return new PolygonTestOwnerContext(view, alignment,
                    AlignmentValueConverter.GetId(alignment), model,
                    host.ActiveProject, host.ActiveDocument, path, buffers);
            }
        }

        // Use after the long-running receiver has been disposed. The buffer
        // order and object identities must still match the command's source.
        internal bool IsSourceCurrent()
        {
            try
            {
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment active = receiver.Alignment;
                    return MatchesCapturedSource(active,
                        active == null ? null : LidarBufferService.CollectBuffers(active));
                }
            }
            catch (Exception) { return false; }
        }

        internal bool IsCurrent()
        {
            try
            {
                var host = ApplicationHost.Current;
                if (_view == null || _view.IsDisposed || !_view.IsHandleCreated ||
                    host == null || !Object.ReferenceEquals(host.ActiveProject, _project) ||
                    !Object.ReferenceEquals(host.ActiveDocument, _document))
                    return false;

                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment active = receiver.Alignment;
                    if (!Object.ReferenceEquals(active, _alignment) ||
                        AlignmentValueConverter.GetId(active) != _alignmentId)
                        return false;
                    var model = PluginCoreOps.FindModel(active);
                    return Object.ReferenceEquals(model, _model) && model != null &&
                        Object.ReferenceEquals(model.Project, _project) &&
                        String.Equals(GetDirectory(active), DirectoryPath,
                            StringComparison.OrdinalIgnoreCase);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Use with an already open receiver. The caller also checks IsCurrent
        // before opening it and again after disposing it, avoiding a nested
        // receiver while SDK-owned LiDAR buffers are borrowed for a scan.
        internal bool MatchesCapturedSource(Alignment alignment,
            List<LidarBuffer> buffers)
        {
            try
            {
                var host = ApplicationHost.Current;
                if (_view == null || _view.IsDisposed || !_view.IsHandleCreated ||
                    host == null || !Object.ReferenceEquals(host.ActiveProject, _project) ||
                    !Object.ReferenceEquals(host.ActiveDocument, _document) ||
                    !Object.ReferenceEquals(alignment, _alignment) ||
                    AlignmentValueConverter.GetId(alignment) != _alignmentId)
                    return false;
                var model = PluginCoreOps.FindModel(alignment);
                if (!Object.ReferenceEquals(model, _model) || model == null ||
                    !Object.ReferenceEquals(model.Project, _project) ||
                    buffers == null ||
                    !String.Equals(GetDirectory(buffers), DirectoryPath,
                        StringComparison.OrdinalIgnoreCase)) return false;
                return _source != null && _source.Matches(buffers);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static string GetDirectory(Alignment alignment)
        {
            return GetDirectory(LidarBufferService.CollectBuffers(alignment));
        }

        private static string GetDirectory(List<LidarBuffer> buffers)
        {
            if (buffers == null) return null;
            foreach (LidarBuffer buffer in buffers)
            {
                if (buffer != null && !String.IsNullOrEmpty(buffer.fullpath))
                    return Path.GetDirectoryName(buffer.fullpath);
            }
            return null;
        }
    }
}
