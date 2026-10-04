using System;
using System.Collections.Generic;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    // Polygon deletion selects exact SDK record indices. Attach color here,
    // before the plain geometry batch loses those indices.
    internal sealed class ColorAwareLasWriter : IDisposable
    {
        private readonly LasBatchStreamWriter _writer;
        private RgbExportSession _session;
        internal bool HasRgb{get;private set;}
        private readonly List<LasColoredPoint> _colors=new List<LasColoredPoint>();
        internal Func<bool> IsCancellationRequested
        {get{return _writer.IsCancellationRequested;}set{_writer.IsCancellationRequested=value;}}
        internal ColorAwareLasWriter(IList<LidarBuffer> buffers,string path,Func<bool> cancel)
        {
            _session=RgbExportSession.Create(buffers,path,cancel);
            HasRgb=_session!=null;
            try{_writer=new LasBatchStreamWriter(path,_session!=null);}
            catch{if(_session!=null)_session.Dispose();throw;}
            _writer.IsCancellationRequested=cancel;
        }
        internal void CaptureKeptPoint(QuadTreeIndexer indexer,int point,Vector4D geometry)
        {if(_session!=null)_colors.Add(_session.Get(indexer,point,geometry));}
        internal void WritePoints(List<Vector4D> points)
        {
            if(_session==null){_writer.WritePoints(points);return;}
            if(_colors.Count!=points.Count)throw new InvalidOperationException("RGB batch identity/count mismatch.");
            _writer.WriteColoredPoints(_colors);_colors.Clear();
        }
        internal PreparedLasFile Complete()
        {
            if(_colors.Count!=0)throw new InvalidOperationException("RGB batch was not flushed.");
            if(_session!=null)_session.AssertCurrent(_writer.IsCancellationRequested);
            var prepared=_writer.Complete();
            if(_session!=null)
            {
                var session=_session;var cancel=_writer.IsCancellationRequested;
                prepared.AttachSourceLease(delegate{session.AssertCurrent(cancel);if(cancel!=null&&cancel())throw new OperationCanceledException();},session);
                _session=null;
            }
            return prepared;
        }
        public void Dispose(){_writer.Dispose();if(_session!=null)_session.Dispose();_session=null;}
    }
}
