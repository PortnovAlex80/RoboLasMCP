using System;
using System.Collections.Generic;
using System.IO;

namespace LAS_TERRAIN.Infrastructure
{
    // Fixed 40-byte records. Sorting is bounded by RunCapacity and merge fan-in,
    // independent of cloud size. IDs address disk maps, never RGB inferred later.
    internal struct RgbSortRecord : IComparable<RgbSortRecord>
    {
        internal long X, Y, Z;
        internal long Id;
        internal ushort R, G, B, Intensity;
        internal int CompareKey(RgbSortRecord other)
        {
            int c=X.CompareTo(other.X); if(c!=0) return c;
            c=Y.CompareTo(other.Y); return c!=0 ? c : Z.CompareTo(other.Z);
        }
        public int CompareTo(RgbSortRecord other)
        { int c=CompareKey(other); return c!=0 ? c : Id.CompareTo(other.Id); }
        internal void Write(BinaryWriter writer)
        { writer.Write(X);writer.Write(Y);writer.Write(Z);writer.Write(Id);
          writer.Write(R);writer.Write(G);writer.Write(B);writer.Write(Intensity); }
        internal static RgbSortRecord Read(BinaryReader reader)
        { return new RgbSortRecord {X=reader.ReadInt64(),Y=reader.ReadInt64(),Z=reader.ReadInt64(),
            Id=reader.ReadInt64(),R=reader.ReadUInt16(),G=reader.ReadUInt16(),B=reader.ReadUInt16(),Intensity=reader.ReadUInt16()}; }
    }

    internal sealed class RgbExternalSort : IDisposable
    {
        private readonly string _directory;
        private readonly int _capacity;
        private readonly Func<bool> _cancel;
        private readonly List<RgbSortRecord> _buffer;
        private readonly List<string> _owned=new List<string>();
        private List<string> _runs=new List<string>();
        internal RgbExternalSort(string directory, Func<bool> cancel, int capacity)
        { _directory=directory;_cancel=cancel;_capacity=capacity;
          if(capacity<1) throw new ArgumentOutOfRangeException("capacity");
          _buffer=new List<RgbSortRecord>(capacity); }
        internal void Append(RgbSortRecord record)
        { _buffer.Add(record);if(_buffer.Count>=_capacity) Flush(); }
        private void CheckCancel()
        { if(_cancel!=null && _cancel()) throw new OperationCanceledException(); }
        private string NewPath()
        { string path=Path.Combine(_directory,Guid.NewGuid().ToString("N")+".rgb-sort.tmp");_owned.Add(path);return path; }
        private void Flush()
        {
            CheckCancel(); if(_buffer.Count==0) return;
            _buffer.Sort();string path=NewPath();
            using(var writer=new BinaryWriter(new FileStream(path,FileMode.CreateNew,FileAccess.Write,FileShare.None)))
                foreach(var record in _buffer) record.Write(writer);
            _runs.Add(path);_buffer.Clear();CheckCancel();
        }
        internal IEnumerable<RgbSortRecord> Complete()
        {
            Flush();
            while(_runs.Count>16)
            {
                var next=new List<string>();
                for(int start=0;start<_runs.Count;start+=16)
                {
                    var batch=_runs.GetRange(start,Math.Min(16,_runs.Count-start));
                    string path=NewPath();
                    using(var writer=new BinaryWriter(new FileStream(path,FileMode.CreateNew,FileAccess.Write,FileShare.None)))
                        foreach(var record in Merge(batch)) record.Write(writer);
                    next.Add(path);foreach(string old in batch) File.Delete(old);
                }
                _runs=next;
            }
            return Merge(_runs);
        }
        // At most sixteen buffered streams open. The small heap avoids scanning
        // all streams for every record of a large cloud.
        private IEnumerable<RgbSortRecord> Merge(List<string> paths)
        {
            var readers=new List<BinaryReader>();var heap=new List<Head>();
            try
            {
                for(int i=0;i<paths.Count;i++)
                {
                    var reader=new BinaryReader(new FileStream(paths[i],FileMode.Open,FileAccess.Read,FileShare.Read));
                    readers.Add(reader);
                    if(reader.BaseStream.Length>0) Push(heap,new Head(i,RgbSortRecord.Read(reader)));
                }
                int visited=0;
                while(heap.Count>0)
                {
                    if((visited++ & 4095)==0) CheckCancel();
                    Head head=Pop(heap);yield return head.Value;
                    var reader=readers[head.Reader];
                    if(reader.BaseStream.Position<reader.BaseStream.Length)
                        Push(heap,new Head(head.Reader,RgbSortRecord.Read(reader)));
                }
                CheckCancel();
            }
            finally { foreach(var reader in readers) reader.Close(); }
        }
        private struct Head
        { internal int Reader;internal RgbSortRecord Value;
          internal Head(int reader,RgbSortRecord value){Reader=reader;Value=value;} }
        private static void Push(List<Head> heap,Head value)
        {
            heap.Add(value);int index=heap.Count-1;
            while(index>0)
            {int parent=(index-1)/2;if(heap[parent].Value.CompareTo(value.Value)<=0) break;
             heap[index]=heap[parent];index=parent;}heap[index]=value;
        }
        private static Head Pop(List<Head> heap)
        {
            Head result=heap[0],last=heap[heap.Count-1];heap.RemoveAt(heap.Count-1);
            if(heap.Count==0) return result;
            int index=0;
            while(index*2+1<heap.Count)
            { int child=index*2+1;
              if(child+1<heap.Count && heap[child+1].Value.CompareTo(heap[child].Value)<0) child++;
              if(last.Value.CompareTo(heap[child].Value)<=0) break;
              heap[index]=heap[child];index=child; }heap[index]=last;return result;
        }
        public void Dispose()
        { foreach(string path in _owned) try { if(File.Exists(path)) File.Delete(path); }
          catch(IOException error){System.Diagnostics.Trace.WriteLine(error);}
          catch(UnauthorizedAccessException error){System.Diagnostics.Trace.WriteLine(error);} }
    }
}
