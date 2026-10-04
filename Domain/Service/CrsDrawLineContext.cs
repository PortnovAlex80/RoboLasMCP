using System;

namespace LAS_TERRAIN.Domain.Service
{
    /// <summary>
    /// Identity captured before interactive CRS input. SDK objects are compared by
    /// reference; section values are copied so a rebuilt list cannot alter the capture.
    /// </summary>
    internal sealed class CrsDrawLineContext
    {
        private readonly object _alignment;
        private readonly object _model;
        private readonly object _project;
        private readonly Guid _alignmentId;
        private readonly object _sourceView;
        private readonly object _crossView;
        private readonly object _activeDocument;
        private readonly uint[] _sectionIds;
        private readonly double[] _stations;

        internal int SectionIndex { get; private set; }
        internal uint SectionId { get { return _sectionIds[SectionIndex]; } }
        internal double SectionStation { get { return _stations[SectionIndex]; } }

        internal CrsDrawLineContext(object alignment, object model, object project,
            Guid alignmentId, object sourceView, object crossView, object activeDocument,
            int sectionIndex, uint[] sectionIds, double[] stations)
        {
            if (alignment == null || model == null || project == null ||
                alignmentId == Guid.Empty || sourceView == null || crossView == null ||
                activeDocument == null || sectionIds == null || stations == null ||
                sectionIds.Length != stations.Length || sectionIndex < 0 ||
                sectionIndex >= sectionIds.Length)
                throw new ArgumentException("A complete CRS drawing context is required.");
            for (int i = 0; i < stations.Length; i++)
                if (Double.IsNaN(stations[i]) || Double.IsInfinity(stations[i]))
                    throw new ArgumentException("Section stations must be finite.", "stations");

            _alignment = alignment;
            _model = model;
            _project = project;
            _alignmentId = alignmentId;
            _sourceView = sourceView;
            _crossView = crossView;
            _activeDocument = activeDocument;
            SectionIndex = sectionIndex;
            _sectionIds = (uint[])sectionIds.Clone();
            _stations = (double[])stations.Clone();
        }

        internal bool IsCurrent(object alignment, object model, object project,
            Guid alignmentId, object sourceView, object crossView, object activeDocument,
            bool viewsAlive, int sectionIndex, int sectionCount,
            Func<int, uint> sectionIdAt, Func<int, double> stationAt)
        {
            if (!viewsAlive || !Object.ReferenceEquals(_alignment, alignment) ||
                !Object.ReferenceEquals(_model, model) ||
                !Object.ReferenceEquals(_project, project) ||
                _alignmentId != alignmentId ||
                !Object.ReferenceEquals(_sourceView, sourceView) ||
                !Object.ReferenceEquals(_crossView, crossView) ||
                !Object.ReferenceEquals(_activeDocument, activeDocument) ||
                SectionIndex != sectionIndex || sectionCount != _sectionIds.Length ||
                sectionIdAt == null || stationAt == null)
                return false;

            try
            {
                for (int i = 0; i < sectionCount; i++)
                {
                    double currentStation = stationAt(i);
                    if (_sectionIds[i] != sectionIdAt(i) ||
                        Double.IsNaN(currentStation) || Double.IsInfinity(currentStation) ||
                        _stations[i] != currentStation)
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
