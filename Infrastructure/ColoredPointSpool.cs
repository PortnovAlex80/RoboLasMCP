using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Infrastructure
{
    internal sealed class ColoredPointSpool : IList<LasColoredPoint>,IDisposable
    {
        private const int RecordSize=50;
        private readonly string _path;
        private FileStream _stream;private BinaryWriter _writer;private BinaryReader _reader;
        private readonly List<string> _sources=new List<string>();
        private readonly Dictionary<string,int> _sourceIds=new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);
        private int _count;
        internal string DirectoryPath{get{return Path.GetDirectoryName(_path);}}
        internal ColoredPointSpool(string outputPath)
        { _path=Path.GetFullPath(outputPath)+"."+Guid.NewGuid().ToString("N")+".rgb-points.tmp";
          _stream=new FileStream(_path,FileMode.CreateNew,FileAccess.ReadWrite,FileShare.None);_writer=new BinaryWriter(_stream); }
        internal void Append(LasColoredPoint point)
        {
            if(_writer==null)throw new InvalidOperationException("Point spool has been sealed.");
            if(_count==Int32.MaxValue)throw new OutOfMemoryException("Point spool count exceeds supported sampling range.");
            int source;if(!_sourceIds.TryGetValue(point.SourceIdentity,out source))
            {source=_sources.Count;_sources.Add(point.SourceIdentity);_sourceIds.Add(point.SourceIdentity,source);}
            _writer.Write(point.Position.X);_writer.Write(point.Position.Y);_writer.Write(point.Position.Z);_writer.Write(point.Position.W);
            _writer.Write(point.Red);_writer.Write(point.Green);_writer.Write(point.Blue);_writer.Write(point.SourcePointIndex);_writer.Write(source);_count++;
        }
        internal void Seal(){_writer.Flush();_writer=null;_stream.Position=0;_reader=new BinaryReader(_stream);}
        // Retain the first complete record for each XYZ, as the existing split
        // does, then restore collection order. Never pick RGB independently.
        internal void CopyDistinctTo(ColoredPointSpool target,Func<bool> cancel)
        {
            using(var unique=new RgbExternalSort(DirectoryPath,cancel,200000))
            using(var order=new RgbExternalSort(DirectoryPath,cancel,200000))
            {
                for(int i=0;i<Count;i++)
                {
                    if((i&4095)==0&&cancel!=null&&cancel())throw new OperationCanceledException();
                    var p=this[i].Position;
                    unique.Append(new RgbSortRecord{X=BitConverter.DoubleToInt64Bits(p.X==0?0:p.X),
                        Y=BitConverter.DoubleToInt64Bits(p.Y==0?0:p.Y),Z=BitConverter.DoubleToInt64Bits(p.Z==0?0:p.Z),Id=i});
                }
                bool first=true;RgbSortRecord previous=new RgbSortRecord();
                foreach(var record in unique.Complete())
                {if(first||record.CompareKey(previous)!=0)order.Append(new RgbSortRecord{Id=record.Id});first=false;previous=record;}
                foreach(var record in order.Complete())target.Append(this[(int)record.Id]);
                target.Seal();
            }
        }
        public int Count{get{return _count;}}public bool IsReadOnly{get{return true;}}
        public LasColoredPoint this[int index]
        {
            get
            {if(_reader==null)throw new InvalidOperationException("Point spool is not readable.");
             if(index<0||index>=_count)throw new ArgumentOutOfRangeException("index");
             long offset=(long)index*RecordSize;if(_stream.Position!=offset)_stream.Position=offset;
             var position=new Vector4D(_reader.ReadDouble(),_reader.ReadDouble(),_reader.ReadDouble(),_reader.ReadDouble());
             ushort r=_reader.ReadUInt16(),g=_reader.ReadUInt16(),b=_reader.ReadUInt16();long ordinal=_reader.ReadInt64();int source=_reader.ReadInt32();
             return new LasColoredPoint(position,r,g,b,_sources[source],ordinal);}
            set{throw new NotSupportedException();}
        }
        public IEnumerator<LasColoredPoint> GetEnumerator(){for(int i=0;i<_count;i++)yield return this[i];}
        IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
        public void CopyTo(LasColoredPoint[] array,int index){for(int i=0;i<_count;i++)array[index+i]=this[i];}
        public int IndexOf(LasColoredPoint value){for(int i=0;i<_count;i++)if(this[i].Equals(value))return i;return -1;}
        public bool Contains(LasColoredPoint value){return IndexOf(value)>=0;}
        public void Add(LasColoredPoint value){throw new NotSupportedException();}
        public void Insert(int index,LasColoredPoint value){throw new NotSupportedException();}
        public void RemoveAt(int index){throw new NotSupportedException();}
        public bool Remove(LasColoredPoint value){throw new NotSupportedException();}
        public void Clear(){throw new NotSupportedException();}
        public void Dispose()
        {
            if(_stream!=null)_stream.Close();_stream=null;_writer=null;_reader=null;
            try{if(File.Exists(_path))File.Delete(_path);}catch(IOException e){System.Diagnostics.Trace.WriteLine(e);}
            catch(UnauthorizedAccessException e){System.Diagnostics.Trace.WriteLine(e);}
        }
    }
}
