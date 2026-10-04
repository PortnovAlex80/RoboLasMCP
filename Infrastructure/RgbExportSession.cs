using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    internal sealed class RgbExportSession : IDisposable
    {
        private readonly Dictionary<QuadTreeIndexer, NativeColors> _colors = new Dictionary<QuadTreeIndexer, NativeColors>();
        private readonly List<LidarBuffer> _buffers;
        private readonly BorrowedLidarSourceSnapshot _snapshot;
        private RgbExportSession(IList<LidarBuffer> buffers)
        { _buffers=new List<LidarBuffer>(buffers); _snapshot=BorrowedLidarSourceSnapshot.Capture(_buffers); }

        // Native Robur attributes only: no input files or coordinate joins.
        internal static RgbExportSession Create(IList<LidarBuffer> buffers,string outputPath,Func<bool> cancel)
        {
            var result=new RgbExportSession(buffers);bool rgb=false,plain=false;
            try
            {
                for(int b=0;b<buffers.Count;b++)
                {
                    var buffer=buffers[b];if(buffer==null||buffer.indexers==null)continue;
                    long ordinal=0;
                    foreach(var indexer in buffer.indexers)
                    {
                        CheckCancel(cancel);if(indexer==null)continue;
                        var colors=new NativeColors(indexer,"robur-buffer:"+b,ordinal,cancel);
                        ordinal+=indexer.points.Count;if(indexer.points.Count==0)continue;
                        if(colors.HasRgb){rgb=true;result._colors.Add(indexer,colors);}else plain=true;
                    }
                }
                if(!rgb){result.Dispose();return null;}
                if(plain)throw new InvalidOperationException("Selected Robur clouds mix colored and colorless points. Export them separately to preserve color availability.");
                result.AssertOutputPath(outputPath);return result;
            }
            catch{result.Dispose();throw;}
        }
        internal void AssertOutputPath(string path)
        {
            if(String.IsNullOrEmpty(path))return;
            foreach(var buffer in _buffers)
                if(buffer!=null && !String.IsNullOrEmpty(buffer.fullpath) &&
                   String.Equals(Path.GetFullPath(path),Path.GetFullPath(buffer.fullpath),StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Export cannot overwrite a loaded Robur cloud cache.");
        }
        internal void AssertCurrent(Func<bool> cancel)
        {
            CheckCancel(cancel);
            if(!_snapshot.Matches(_buffers))throw new InvalidOperationException("Loaded Robur cloud changed before RGB publication.");
            foreach(var colors in _colors.Values)colors.AssertCurrent(cancel);
        }
        internal LasColoredPoint Get(QuadTreeIndexer indexer,int point,Vector4D position)
        {
            NativeColors colors;if(!_colors.TryGetValue(indexer,out colors))throw new InvalidOperationException("RGB indexer no longer belongs to the loaded cloud.");
            return colors.Get(point,position);
        }
        internal static LasColoredPoint ForLas(LasColoredPoint point)
        {
            var p=point.Position;
            return new LasColoredPoint(new Vector4D(p.X,p.Y,p.Z,LidarIntensity.ExpandNormalized(p.W)),
                point.Red,point.Green,point.Blue,point.SourceIdentity,point.SourcePointIndex);
        }
        internal void FindPoints(LidarBuffer buffer,BoundingBox2D box,Action<LasColoredPoint> accept,Func<bool> cancel)
        {
            foreach(var indexer in buffer.indexers)
            {
                if(indexer==null||indexer.points.Count==0)continue;
                var localBox=box;
                localBox.Min=(box.Min-indexer.position.Pos)/indexer.scale.Pos;
                localBox.Max=(box.Max-indexer.position.Pos)/indexer.scale.Pos;
                FindLeaf(indexer,indexer,localBox,delegate(int i,Vector4D point){accept(Get(indexer,i,point));},cancel);
            }
        }
        private static void FindLeaf(QuadTreeIndexer indexer,QuadTreeLeaf leaf,BoundingBox2D box,Action<int,Vector4D> accept,Func<bool> cancel)
        {
            if(leaf==null)return;
            if(cancel!=null && cancel())throw new OperationCanceledException();
            BoundingBox2D bounds=new BoundingBox2D();
            bounds.Min=new Vector2D(leaf.minx,leaf.miny);bounds.Max=new Vector2D(leaf.maxx,leaf.maxy);
            if(box.Contains(bounds)==ContainmentType.Disjoint)return;
            if(leaf.leafs!=null){foreach(var child in leaf.leafs)FindLeaf(indexer,child,box,accept,cancel);return;}
            var points=indexer.points.GetBuffer();
            if(leaf.start<0 || leaf.count<0 || leaf.start>(long)indexer.points.Count-leaf.count)
                throw new InvalidDataException("Invalid loaded tree leaf range.");
            for(int i=leaf.start;i<leaf.start+leaf.count;i++)
            {
                if((i&1023)==0 && cancel!=null && cancel())throw new OperationCanceledException();
                var p=points[i];double x=p.X*indexer.scale.X+indexer.position.X,y=p.Y*indexer.scale.Y+indexer.position.Y;
                if(box.Contains(new Vector2D(p.X,p.Y))!=ContainmentType.Disjoint)
                    accept(i,new Vector4D(x,y,p.Z*indexer.scale.Z+indexer.position.Z,indexer.weights[i]/255.0));
            }
        }
        private static void CheckCancel(Func<bool> cancel)
        {if(cancel!=null&&cancel())throw new OperationCanceledException();}

        internal static long ColorByteCount(QuadTreeIndexer indexer)
        {
            var flags=System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public;
            var type=indexer.GetType();
            var member=(System.Reflection.MemberInfo)type.GetField("texture",flags)??type.GetProperty("texture",flags)
                ??(System.Reflection.MemberInfo)type.GetField("clrs",flags)??type.GetProperty("clrs",flags);
            if(member==null)return 0;
            var field=member as System.Reflection.FieldInfo;
            var storage=field!=null?field.GetValue(indexer):((System.Reflection.PropertyInfo)member).GetValue(indexer,null);
            if(storage==null)return 0;
            return Convert.ToInt64(storage.GetType().GetProperty("Count").GetValue(storage,null));
        }

        // Resolve texture (supplied Robur source) or clrs (older SDK) once per
        // indexer. Colors are attached by the exact point index, never by XYZ.
        private sealed class NativeColors
        {
            private readonly QuadTreeIndexer _indexer;
            private readonly string _identity;
            private readonly long _ordinal;
            private readonly System.Reflection.MemberInfo _member;
            private readonly object _storage;
            private readonly System.Reflection.PropertyInfo _count;
            private readonly System.Reflection.MethodInfo _getBuffer;
            private readonly byte[] _rgb,_fingerprint;
            internal bool HasRgb{get{return _rgb!=null;}}
            internal NativeColors(QuadTreeIndexer indexer,string identity,long ordinal,Func<bool> cancel)
            {
                _indexer=indexer;_identity=identity;_ordinal=ordinal;
                var type=indexer.GetType();
                foreach(string name in new string[]{"texture","clrs"})
                {
                    var flags=System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public;
                    var member=(System.Reflection.MemberInfo)type.GetField(name,flags)??type.GetProperty(name,flags);
                    if(member==null)continue;
                    var storage=ReadMember(member,indexer);if(storage==null)break;
                    var count=storage.GetType().GetProperty("Count");
                    var getBuffer=storage.GetType().GetMethod("GetBuffer",Type.EmptyTypes);
                    if(count==null||getBuffer==null)throw new InvalidOperationException("Unsupported Robur RGB buffer API.");
                    int size=Convert.ToInt32(count.GetValue(storage,null));if(size==0)break;
                    if((long)size!=3L*indexer.points.Count)throw new InvalidDataException("Robur RGB buffer must contain exactly three bytes per point.");
                    byte[] rgb=getBuffer.Invoke(storage,null) as byte[];
                    if(rgb==null||rgb.Length<size)throw new InvalidDataException("Invalid Robur RGB buffer storage.");
                    _member=member;_storage=storage;_count=count;_getBuffer=getBuffer;_rgb=rgb;
                    _fingerprint=Fingerprint(cancel);break;
                }
            }
            private static object ReadMember(System.Reflection.MemberInfo member,object owner)
            {
                var field=member as System.Reflection.FieldInfo;
                return field!=null?field.GetValue(owner):((System.Reflection.PropertyInfo)member).GetValue(owner,null);
            }
            internal LasColoredPoint Get(int point,Vector4D geometry)
            {
                if(point<0||point>=_indexer.points.Count)throw new ArgumentOutOfRangeException("point");
                int offset=checked(point*3);
                // ASPRS LAS: normalize 8-bit channels by multiplying by 256.
                return new LasColoredPoint(geometry,(ushort)(_rgb[offset]<<8),(ushort)(_rgb[offset+1]<<8),
                    (ushort)(_rgb[offset+2]<<8),_identity,_ordinal+point);
            }
            internal void AssertCurrent(Func<bool> cancel)
            {
                if(!Object.ReferenceEquals(_storage,ReadMember(_member,_indexer)) ||
                   Convert.ToInt64(_count.GetValue(_storage,null))!=3L*_indexer.points.Count ||
                   !Object.ReferenceEquals(_rgb,_getBuffer.Invoke(_storage,null)))
                    throw new InvalidOperationException("Loaded Robur RGB buffer changed before publication.");
                byte[] current=Fingerprint(cancel);
                for(int i=0;i<current.Length;i++)if(current[i]!=_fingerprint[i])
                    throw new InvalidOperationException("Loaded Robur points or colors changed before publication.");
            }
            private byte[] Fingerprint(Func<bool> cancel)
            {
                if(_indexer.weights.Count<_indexer.points.Count)throw new InvalidDataException("Robur point weights are incomplete.");
                using(var hash=System.Security.Cryptography.SHA256.Create())
                using(var stream=new System.Security.Cryptography.CryptoStream(Stream.Null,hash,System.Security.Cryptography.CryptoStreamMode.Write))
                {
                    var writer=new BinaryWriter(stream);var points=_indexer.points.GetBuffer();
                    for(int i=0;i<_indexer.points.Count;i++)
                    {
                        if((i&4095)==0)CheckCancel(cancel);
                        writer.Write(points[i].X);writer.Write(points[i].Y);writer.Write(points[i].Z);writer.Write(_indexer.weights[i]);
                    }
                    HashLeaf(writer,_indexer);
                    writer.Write(_rgb,0,checked(_indexer.points.Count*3));writer.Flush();stream.FlushFinalBlock();return hash.Hash;
                }
            }
            private static void HashLeaf(BinaryWriter writer,QuadTreeLeaf leaf)
            {
                writer.Write(leaf!=null);if(leaf==null)return;
                writer.Write(leaf.start);writer.Write(leaf.count);writer.Write(leaf.minx);writer.Write(leaf.maxx);
                writer.Write(leaf.miny);writer.Write(leaf.maxy);writer.Write(leaf.minz);writer.Write(leaf.maxz);
                writer.Write(leaf.leafs==null?-1:leaf.leafs.Length);
                if(leaf.leafs!=null)foreach(var child in leaf.leafs)HashLeaf(writer,child);
            }
        }
        public void Dispose(){_colors.Clear();}
    }
}
