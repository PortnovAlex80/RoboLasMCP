using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Service;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.View;
using Topomatic.FoundationClasses;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// One CAD-thread polygon operation with a pinned project owner.
    /// </summary>
    internal sealed class ScopedPolygonOperationContext
    {
        private readonly CadView _view;
        private readonly Alignment _alignment;
        private readonly Guid _alignmentId;
        private readonly object _model;
        private readonly object _project;
        private readonly object _document;
        private readonly BorrowedLidarSourceSnapshot _source;
        private readonly PolygonScope _scope;
        private readonly ScopedPolygonRepository _repository;
        private readonly Dictionary<int, PolygonSectionBinding> _sections;

        internal PolygonScope Scope { get { return _scope; } }
        internal ScopedPolygonRepository Repository { get { return _repository; } }

        internal ScopedPolygonSnapshot Commit(ScopedPolygonSnapshot expected,
            IEnumerable<ScopedPolygonRecord> records)
        {
            if (!IsCurrent())
                throw new InvalidOperationException(
                    "Проект, трасса или сечения изменились до сохранения полигонов.");
            return _repository.Commit(expected, records);
        }

        private ScopedPolygonOperationContext(CadView view, Alignment alignment,
            Guid alignmentId, object model, object project, object document,
            BorrowedLidarSourceSnapshot source, PolygonScope scope,
            Dictionary<int, PolygonSectionBinding> sections)
        {
            _view = view;
            _alignment = alignment;
            _alignmentId = alignmentId;
            _model = model;
            _project = project;
            _document = document;
            _source = source;
            _scope = scope;
            _repository = new ScopedPolygonRepository(scope);
            _sections = sections;
        }

        internal static ScopedPolygonOperationContext Capture(CadView view,
            PolygonGeometryKind geometryKind)
        {
            if (view == null || view.IsDisposed || !view.IsHandleCreated) return null;
            PolygonScope scope;
            Dictionary<int, PolygonSectionBinding> sections;
            Alignment alignment;
            Guid alignmentId;
            object model;
            object project;
            object document;
            BorrowedLidarSourceSnapshot source;
            using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
            {
                alignment = receiver.Alignment;
                if (alignment == null) return null;
                var host = ApplicationHost.Current;
                var hostModel = PluginCoreOps.FindModel(alignment);
                if (host == null || host.ActiveProject == null ||
                    host.ActiveDocument == null || hostModel == null ||
                    !Object.ReferenceEquals(hostModel.Project, host.ActiveProject))
                    return null;
                scope = PolygonContextResolver.ResolveProject(alignment, geometryKind);
                alignmentId = AlignmentValueConverter.GetId(alignment);
                model = hostModel;
                project = host.ActiveProject;
                document = host.ActiveDocument;
                List<LidarBuffer> buffers = LidarBufferService.CollectBuffers(alignment);
                source = BorrowedLidarSourceSnapshot.Capture(buffers);
                sections = geometryKind == PolygonGeometryKind.Crs
                    ? CaptureSections(alignment) : null;
            }
            ScopedPolygonOperationContext context = new ScopedPolygonOperationContext(
                view, alignment, alignmentId, model, project, document,
                source, scope, sections);
            return context.IsCurrent() ? context : null;
        }

        internal bool IsCurrent()
        {
            try
            {
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    return MatchesOwner(receiver.Alignment);
                }
            }
            catch (Exception) { return false; }
        }

        internal bool IsSourceCurrent()
        {
            try
            {
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    Alignment alignment = receiver.Alignment;
                    return MatchesCapturedSource(alignment,
                        alignment == null ? null : LidarBufferService.CollectBuffers(alignment));
                }
            }
            catch (Exception) { return false; }
        }

        internal bool IsSnapshotCurrent(ScopedPolygonSnapshot snapshot)
        {
            try
            {
                return snapshot != null && IsCurrent() &&
                    snapshot.ScopeKey == _scope.ScopeKey &&
                    _repository.Read().Revision == snapshot.Revision;
            }
            catch (Exception) { return false; }
        }

        internal bool MatchesCapturedSource(Alignment alignment,
            List<LidarBuffer> buffers)
        {
            try
            {
                return MatchesOwner(alignment) && _source != null &&
                    _source.Matches(buffers);
            }
            catch (Exception) { return false; }
        }

        internal bool TryRead(out ScopedPolygonSnapshot snapshot)
        {
            snapshot = _repository.Read();
            return IsCurrent();
        }

        private bool MatchesOwner(Alignment alignment)
        {
            if (_view == null || _view.IsDisposed || !_view.IsHandleCreated ||
                !Object.ReferenceEquals(alignment, _alignment) ||
                AlignmentValueConverter.GetId(alignment) != _alignmentId)
                return false;
            var host = ApplicationHost.Current;
            if (host == null ||
                !Object.ReferenceEquals(host.ActiveProject, _project) ||
                !Object.ReferenceEquals(host.ActiveDocument, _document))
                return false;
            var model = PluginCoreOps.FindModel(alignment);
            if (!Object.ReferenceEquals(model, _model) || model == null ||
                !Object.ReferenceEquals(model.Project, _project))
                return false;
            return String.Equals(PolygonContextResolver.ResolveProject(alignment,
                _scope.GeometryKind).ScopeKey, _scope.ScopeKey,
                StringComparison.Ordinal) && SectionsAreCurrent(alignment);
        }

        private bool SectionsAreCurrent(Alignment alignment)
        {
            if (_sections == null) return true;
            var sections = alignment.Corridor == null ? null : alignment.Corridor.Sections;
            if (sections == null || sections.Count != _sections.Count) return false;
            for (int i = 0; i < sections.Count; i++)
            {
                PolygonSectionBinding expected;
                if (!_sections.TryGetValue(i, out expected) ||
                    sections[i].Id != expected.SectionId ||
                    Double.IsNaN(sections[i].Station) ||
                    Double.IsInfinity(sections[i].Station) ||
                    Math.Abs(sections[i].Station - expected.Station) > 0.000001)
                    return false;
            }
            return true;
        }

        private static Dictionary<int, PolygonSectionBinding> CaptureSections(Alignment alignment)
        {
            if (alignment.Corridor == null || alignment.Corridor.Sections == null)
                throw new InvalidOperationException("Не удалось получить сечения трассы для работы с поперечниками.");
            var sections = alignment.Corridor.Sections;
            Dictionary<int, PolygonSectionBinding> result =
                new Dictionary<int, PolygonSectionBinding>();
            for (int i = 0; i < sections.Count; i++)
                result.Add(i, new PolygonSectionBinding(sections[i].Id, sections[i].Station));
            return result;
        }
    }
}
