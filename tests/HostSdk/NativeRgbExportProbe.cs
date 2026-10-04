using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.IO;
using LAS_TERRAIN.Helpers;
using LAS_TERRAIN.Filters;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

internal static class NativeRgbExportProbe
{
    private static int checks;
    private static string directory;
    private static void Check(bool value,string message)
    {checks++;if(!value)throw new InvalidOperationException(message);}
    private static object Colors(QuadTreeIndexer indexer)
    {return (indexer.GetType().GetField("texture")??indexer.GetType().GetField("clrs")).GetValue(indexer);}
    private static void Size(object buffer,int count)
    {buffer.GetType().GetProperty("Capacity").SetValue(buffer,count,null);buffer.GetType().GetProperty("Count").SetValue(buffer,count,null);}
    private static byte[] ColorBytes(QuadTreeIndexer indexer)
    {return (byte[])Colors(indexer).GetType().GetMethod("GetBuffer").Invoke(Colors(indexer),null);}
    private static QuadTreeIndexer Indexer(int number,int count,bool rgb)
    {
        var indexer=(QuadTreeIndexer)Activator.CreateInstance(typeof(QuadTreeIndexer),true);
        indexer.points.Capacity=count;indexer.points.Count=count;
        indexer.weights.Capacity=count;indexer.weights.Count=count;
        indexer.scale=new Vector3D(0.25,0.5,0.125);
        indexer.position=new Vector3D(100,200,300);
        indexer.count=count;indexer.start=0;indexer.minx=0;indexer.maxx=10;indexer.miny=0;indexer.maxy=10;indexer.minz=0;indexer.maxz=10;
        for(int i=0;i<count;i++)
        {
            var point=new Vector3F();point.X=i<2?0:i;point.Y=i<2?0:i;point.Z=i<2?0:i;
            indexer.points.GetBuffer()[i]=point;indexer.weights.GetBuffer()[i]=(byte)(17+i);
        }
        if(rgb)
        {
            Size(Colors(indexer),count*3);var bytes=ColorBytes(indexer);
            byte[] values={0,1,127,128,254,255};
            for(int i=0;i<count;i++){bytes[3*i]=values[(i+number)%6];bytes[3*i+1]=values[(i+number+2)%6];bytes[3*i+2]=values[(i+number+4)%6];}
            if(count>0&&number==0)bytes[0]=bytes[1]=bytes[2]=0;
        }
        return indexer;
    }
    private static LidarBuffer Buffer(bool rgb)
    {var buffer=new LidarBuffer();buffer.indexers=new[]{Indexer(0,6,rgb),Indexer(1,3,rgb),Indexer(2,0,false)};return buffer;}
    private static List<LasColoredPoint> Query(LidarBuffer buffer,RgbExportSession session,BoundingBox2D box)
    {var list=new List<LasColoredPoint>();session.FindPoints(buffer,box,list.Add,null);return list;}
    private static List<LasColoredPoint> Read(string path)
    {var points=new List<LasColoredPoint>();foreach(var point in LasRgbSourceReader.Read(path))points.Add(point);return points;}
    private static void WriteAndRead(IList<LasColoredPoint> points,string name)
    {
        var expanded=new List<LasColoredPoint>();foreach(var point in points)expanded.Add(RgbExportSession.ForLas(point));
        points=expanded;
        string path=Path.Combine(directory,name+".las");
        using(var writer=new LasBatchStreamWriter(path,true))
        {writer.WriteColoredPoints(points);using(var prepared=writer.Complete())prepared.Publish();}
        byte[] data=File.ReadAllBytes(path);
        Check(data[24]==1&&data[25]==2,"LAS version must be 1.2");
        Check(BitConverter.ToUInt16(data,94)==227&&BitConverter.ToUInt32(data,96)==227,"LAS header/offset");
        Check(data[104]==3&&BitConverter.ToUInt16(data,105)==34,"LAS point format/length");
        Check(data.Length==227+34*points.Count,"LAS file size");
        Check(BitConverter.ToUInt32(data,107)==points.Count&&BitConverter.ToUInt32(data,111)==points.Count,"LAS count/return count");
        var read=Read(path);Check(read.Count==points.Count,"RGB record count");
        for(int i=0;i<points.Count;i++)
        {
            var expected=points[i];var actual=read[i];
            Check(expected.Red==actual.Red&&expected.Green==actual.Green&&expected.Blue==actual.Blue,"RGB roundtrip");
            Check(expected.Position.W==actual.Position.W,"Existing native intensity expansion must be retained");
            Check(BitConverter.ToUInt16(data,227+34*i+28)==expected.Red&&BitConverter.ToUInt16(data,227+34*i+30)==expected.Green&&BitConverter.ToUInt16(data,227+34*i+32)==expected.Blue,"RGB field offsets");
            Check(Math.Abs(actual.Position.X-expected.Position.X)<0.00011&&Math.Abs(actual.Position.Y-expected.Position.Y)<0.00011&&Math.Abs(actual.Position.Z-expected.Position.Z)<0.00011,"XYZ encoding");
        }
    }
    private static void Exercise(LidarBuffer buffer,string label)
    {
        var buffers=new List<LidarBuffer>{buffer};string output=Path.Combine(directory,label+".las");
        using(var session=RgbExportSession.Create(buffers,output,null))
        {
            Check(session!=null,"Native colors not detected");
            var all=Query(buffer,session,new BoundingBox2D(new Vector2D(99,199),new Vector2D(104,207)));
            Check(all.Count==9,"Both colored indexers and empty indexer");
            Check(all[0].Red==0&&all[0].Green==0&&all[0].Blue==0,"Black is a real color");
            Check(all[0].Position.X==all[1].Position.X&&all[0].Red!=all[1].Red,"Coincident points must retain distinct RGB");
            Check(all[5].Red==65280,"8-bit 255 must normalize to 65280 per ASPRS");
            for(int i=0;i<all.Count;i++)Check(all[i].SourcePointIndex==i,"Exact native record identity");
            int ordinal=0;
            foreach(var indexer in buffer.indexers)
            {var rgb=ColorBytes(indexer);for(int i=0;i<indexer.points.Count;i++,ordinal++)
             Check(all[ordinal].Red==rgb[3*i]*256&&all[ordinal].Green==rgb[3*i+1]*256&&all[ordinal].Blue==rgb[3*i+2]*256,"Native RGB channel order and normalization");}
            for(int edge=0;edge<8;edge++)
            {
                double x=100+0.25*edge,y=200+0.5*edge;
                var box=new BoundingBox2D(new Vector2D(100,200),new Vector2D(x,y));
                var actual=Query(buffer,session,box);var expected=new List<Vector4D>();
#if REAL_SDK
                buffer.FindPoints(box,expected.Add);
#else
                buffer.FindPoints(box,delegate(LidarPoint p){expected.Add(new Vector4D(p.X,p.Y,p.Z,p.Weight));});
#endif
                Check(actual.Count==expected.Count,"SDK query boundary parity");
                for(int i=0;i<actual.Count;i++)Check(actual[i].Position.X==expected[i].X&&actual[i].Position.Y==expected[i].Y&&actual[i].Position.W==expected[i].W,"SDK query order/geometry/intensity parity");
            }
            using(var spool=new ColoredPointSpool(output))
            {foreach(var point in all)spool.Append(point);spool.Seal();for(int i=0;i<all.Count;i++)Check(spool[i].Red==all[i].Red&&spool[i].SourcePointIndex==all[i].SourcePointIndex,"Spill retains record and RGB");
             var sampled=SamplingHelper.ReservoirSampleWithProgress<LasColoredPoint>(spool,5,null,new Random(42),null);WriteAndRead(sampled,label+"-sample");
             using(var distinct=new ColoredPointSpool(output))
             {spool.CopyDistinctTo(distinct,null);Check(distinct.Count==5,"Split dedup count");Check(distinct[0].SourcePointIndex==0&&distinct[0].Red==0,"Split dedup must keep the first complete record including black RGB");WriteAndRead(distinct,label+"-split-dedup");}}
            var geometry=new List<Vector4D>();foreach(var p in all)geometry.Add(p.Position);
            var selected=new List<LasColoredPoint>();
            var ground=GraphGround3DFilter.ApplyWithSelection(geometry,new GraphGround3DOptions(1,1,1,1),null,
                delegate(int count,Action<int> action){for(int i=0;i<count;i++)action(i);},null,delegate(int i){selected.Add(all[i]);});
            Check(ground.Count==selected.Count,"Ground filter selection must retain native records");
            if(selected.Count>0)WriteAndRead(selected,label+"-ground");
            WriteAndRead(all,label+"-all");session.AssertCurrent(null);
            var bytes=ColorBytes(buffer.indexers[0]);bytes[0]^=1;bool rejected=false;
            try{session.AssertCurrent(null);}catch(InvalidOperationException){rejected=true;}finally{bytes[0]^=1;}
            Check(rejected,"In-place RGB mutation must stop publication");
            var pts=buffer.indexers[0].points.GetBuffer();var old=pts[0];var changed=old;changed.X+=1;pts[0]=changed;rejected=false;
            try{session.AssertCurrent(null);}catch(InvalidOperationException){rejected=true;}finally{pts[0]=old;}
            Check(rejected,"In-place geometry mutation must stop publication");
            var oldScale=buffer.indexers[0].scale;buffer.indexers[0].scale=new Vector3D(1,1,1);rejected=false;
            try{session.AssertCurrent(null);}catch(InvalidOperationException){rejected=true;}finally{buffer.indexers[0].scale=oldScale;}
            Check(rejected,"Changed transform must stop publication");
            int oldCount=buffer.indexers[0].count;buffer.indexers[0].count--;rejected=false;
            try{session.AssertCurrent(null);}catch(InvalidOperationException){rejected=true;}finally{buffer.indexers[0].count=oldCount;}
            Check(rejected,"Changed tree topology must stop publication");
        }
        string deletion=Path.Combine(directory,label+"-deletion.las");
        using(var writer=new ColorAwareLasWriter(buffers,deletion,null))
        {
            Check(writer.HasRgb,"Deletion must use colored writer");
            var points=new List<Vector4D>();
            for(int i=1;i<buffer.indexers[0].points.Count;i+=2)
            {var p=buffer.indexers[0].points[i];var geo=new Vector4D(p.X*0.25+100,p.Y*0.5+200,p.Z*0.125+300,(17+i)*257.0);writer.CaptureKeptPoint(buffer.indexers[0],i,geo);points.Add(geo);}
            writer.WritePoints(points);using(var prepared=writer.Complete())prepared.Publish();
        }
        var kept=Read(deletion);Check(kept.Count==3,"Deletion output count");
        var colors=ColorBytes(buffer.indexers[0]);for(int i=0;i<kept.Count;i++)
        {Check(kept[i].Red==colors[3*(2*i+1)]*256,"Deletion must keep RGB of the retained native point");Check(kept[i].Position.W==(18+2*i)*257,"Deletion intensity must remain unchanged");}
        string guarded=Path.Combine(directory,label+"-guarded.las");PreparedLasFile pending;
        using(var writer=new ColorAwareLasWriter(buffers,guarded,null))
        {var point=new Vector4D(100,200,300,17*257);writer.CaptureKeptPoint(buffer.indexers[0],0,point);writer.WritePoints(new List<Vector4D>{point});pending=writer.Complete();}
        using(pending)
        {colors[0]^=1;bool rejected=false;try{pending.Publish();}catch(InvalidOperationException){rejected=true;}finally{colors[0]^=1;}
         Check(rejected&&!File.Exists(guarded),"Source validation lease must survive writer disposal and prevent publication");}
        bool cancelled=false;try{using(var session=RgbExportSession.Create(buffers,output,delegate{return true;})){} }catch(OperationCanceledException){cancelled=true;}
        Check(cancelled,"Cancellation during native capture");
    }
    private static int Main(string[] args)
    {
        try
        {
            directory=args[0];Directory.CreateDirectory(directory);
            using(var buffer=Buffer(true))Exercise(buffer,"native");
#if !REAL_SDK
            using(var buffer=Buffer(true))
            {
                string path=Path.Combine(directory,"native.ldr");buffer.SaveToFile(path);
                Check(File.ReadAllBytes(path)[4]==2,"Colored Robur cache must be LDAR v2");
                using(var reloaded=new LidarBuffer()){reloaded.LoadFromFile(path);Check(reloaded.Colored,"LDAR reload must preserve color availability");Exercise(reloaded,"ldar-v2");}
            }
#endif
            using(var plain=Buffer(false))Check(RgbExportSession.Create(new List<LidarBuffer>{plain},null,null)==null,"Colorless clouds retain the legacy path without requiring a LAS");
#if !REAL_SDK
            using(var plain=Buffer(false))
            {string path=Path.Combine(directory,"plain.ldr");plain.SaveToFile(path);Check(File.ReadAllBytes(path)[4]==1,"Plain cache remains LDAR v1");
             using(var reloaded=new LidarBuffer()){reloaded.LoadFromFile(path);Check(!reloaded.Colored,"Plain cache must not invent RGB");}
             File.WriteAllBytes(path,new byte[]{76,68,65,82,3});bool rejected=false;
             try{using(var invalid=new LidarBuffer())invalid.LoadFromFile(path);}catch(FormatException){rejected=true;}Check(rejected,"Supplied Robur loader must reject an unknown LDAR version");}
#endif
            using(var invalid=Buffer(true))
            {Colors(invalid.indexers[0]).GetType().GetProperty("Count").SetValue(Colors(invalid.indexers[0]),1,null);bool rejected=false;
             try{using(var session=RgbExportSession.Create(new List<LidarBuffer>{invalid},null,null)){} }catch(InvalidDataException){rejected=true;}Check(rejected,"Malformed RGB count must fail");}
            using(var mixed=Buffer(true))
            {Colors(mixed.indexers[1]).GetType().GetProperty("Count").SetValue(Colors(mixed.indexers[1]),0,null);bool rejected=false;
             try{using(var session=RgbExportSession.Create(new List<LidarBuffer>{mixed},null,null)){} }catch(InvalidOperationException){rejected=true;}Check(rejected,"Mixed color availability must fail explicitly");}
            Check(Directory.GetFiles(directory,"*.rgb-*.tmp").Length==0,"Owned RGB temporary files must be cleaned");
            Console.WriteLine("PASS "+checks+" native Robur RGB checks");return 0;
        }
        catch(Exception error){Console.Error.WriteLine(error);return 1;}
    }
}
