// Existing command regression fixtures contain colorless synthetic buffers.
// Their RGB facade declines handling; real colored SDK tests compile the actual
// mapper, collector/selection primitives, spool and writers independently.
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Service
{
#if !DELETE_RGB_STUBS
    internal sealed class RgbExportOutcome
    {internal long Written,Center,Edge;internal bool Cancelled,Published;}
    internal static class RgbExportPipeline
    {
        internal static bool TryReduce(object alg,object buffers,object context,double percent,string path,bool ground,out RgbExportOutcome outcome)
        {outcome=null;return false;}
        internal static bool TrySplit(object alg,object buffers,object context,double left,double right,double center,double edge,object request,out RgbExportOutcome outcome)
        {outcome=null;return false;}
    }
#endif
}
namespace LAS_TERRAIN.Infrastructure
{
#if DELETE_RGB_STUBS
    internal static class RgbExportSession
    {internal static object CaptureSources(object alignment){return null;}}
    internal sealed class ColorAwareLasWriter:IDisposable
    {
        private readonly LAS_TERRAIN.IO.LasBatchStreamWriter _writer;
        internal Func<bool> IsCancellationRequested{get{return _writer.IsCancellationRequested;}set{_writer.IsCancellationRequested=value;}}
        internal ColorAwareLasWriter(object buffers,string path,Func<bool> cancel)
        {_writer=new LAS_TERRAIN.IO.LasBatchStreamWriter(path);_writer.IsCancellationRequested=cancel;}
        internal void CaptureKeptPoint(object indexer,int index,object geometry){}
        internal void WritePoints(List<Vector4D> points){_writer.WritePoints(points);}
        internal LAS_TERRAIN.IO.PreparedLasFile Complete(){return _writer.Complete();}
        public void Dispose(){_writer.Dispose();}
    }
#endif
}
