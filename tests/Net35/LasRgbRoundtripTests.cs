using System;
using System.Collections.Generic;
using System.IO;
using LAS_TERRAIN.IO;
using Topomatic.Cad.Foundation;

class LasRgbRoundtripTests
{
    static int checks;
    static string root;
    static void Check(bool value,string name) { checks++; if(!value) throw new Exception(name); }
    static void Reject<T>(Action action,string name) where T:Exception
    { bool rejected=false; try { action(); } catch(T) { rejected=true; } Check(rejected,name); }
    static string Fixture()
    {
        string path=Path.Combine(root,"source-format2.las"); byte[] header=new byte[227];
        header[0]=(byte)'L';header[1]=(byte)'A';header[2]=(byte)'S';header[3]=(byte)'F';header[24]=1;header[25]=2;header[104]=2;
        BitConverter.GetBytes((ushort)227).CopyTo(header,94); BitConverter.GetBytes((uint)227).CopyTo(header,96);
        BitConverter.GetBytes((ushort)26).CopyTo(header,105); BitConverter.GetBytes((uint)4).CopyTo(header,107);
        for(int i=0;i<3;i++) { BitConverter.GetBytes(0.001).CopyTo(header,131+8*i); BitConverter.GetBytes(1000000.0).CopyTo(header,155+8*i); }
        ushort[][] rgb={new ushort[]{0,0,0},new ushort[]{1,32768,65535},new ushort[]{255,256,257},new ushort[]{123,456,789}};
        using(FileStream stream=File.Create(path))
        {
            stream.Write(header,0,header.Length);
            for(int i=0;i<rgb.Length;i++)
            {
                byte[] record=new byte[26];
                for(int axis=0;axis<3;axis++) BitConverter.GetBytes(i<2?0:i*100).CopyTo(record,axis*4);
                BitConverter.GetBytes((ushort)(40000+i)).CopyTo(record,12);
                for(int channel=0;channel<3;channel++) BitConverter.GetBytes(rgb[i][channel]).CopyTo(record,20+2*channel);
                stream.Write(record,0,record.Length);
            }
        }
        return path;
    }
    static List<LasColoredPoint> Sample(string path,int maximum)
    {
        List<LasColoredPoint> points=new List<LasColoredPoint>();
        foreach(LasColoredPoint point in LasRgbSourceReader.Read(path)) { points.Add(point); if(points.Count>=maximum) break; }
        return points;
    }
    static void Roundtrip(List<LasColoredPoint> input,string name)
    {
        string output=Path.Combine(root,name+".las");
        File.WriteAllBytes(output,new byte[]{9,8,7});
        using(var writer=new LasBatchStreamWriter(output,true))
        {
            writer.WriteColoredPoints(input);
            using(var prepared=writer.Complete()) { Check(File.ReadAllBytes(output).Length==3,"target untouched until publication"); prepared.Publish(); }
        }
        byte[] header=File.ReadAllBytes(output); Check(header[104]==3 && BitConverter.ToUInt16(header,105)==34,"actual LAS RGB format/record size");
        List<LasColoredPoint> actual=Sample(output,Int32.MaxValue); Check(actual.Count==input.Count,"point count");
        for(int i=0;i<actual.Count;i++)
        {
            LasColoredPoint p=actual[i],q=input[i];
            Check(p.Red==q.Red && p.Green==q.Green && p.Blue==q.Blue,"exact RGB16 including black");
            Check(p.Position.W==q.Position.W,"original ushort intensity retained");
            Check(Math.Abs(p.Position.X-q.Position.X)<=0.00011 && Math.Abs(p.Position.Y-q.Position.Y)<=0.00011 && Math.Abs(p.Position.Z-q.Position.Z)<=0.00011,"coordinate encoding");
        }
    }
    static int Main(string[] args)
    {
        root=Path.GetFullPath(Path.Combine("build",Path.Combine(".verification","rgb-roundtrip")));
        Directory.CreateDirectory(root);
        string fixture=Fixture(); List<LasColoredPoint> sample=Sample(fixture,4);
        Check(sample[0].SourcePointIndex==0 && sample[3].SourcePointIndex==3,"source record ordinals");
        Check(sample[0].Position.X==sample[1].Position.X && sample[0].Red!=sample[1].Red,"same XYZ with distinct RGB stay distinct records");
        Roundtrip(sample,"fixture-rgb");
        Roundtrip(new List<LasColoredPoint>{sample[3],sample[0],sample[1]},"reordered-subset");
        // LAS 1.4 uses extended counts and RGB at byte 30 for format 7.
        byte[] modern=new byte[375+36]; byte[] legacy=File.ReadAllBytes(fixture);
        Buffer.BlockCopy(legacy,0,modern,0,227); modern[25]=4; modern[104]=7;
        BitConverter.GetBytes((ushort)375).CopyTo(modern,94); BitConverter.GetBytes((uint)375).CopyTo(modern,96);
        BitConverter.GetBytes((ushort)36).CopyTo(modern,105); BitConverter.GetBytes((uint)0).CopyTo(modern,107);
        BitConverter.GetBytes((ulong)1).CopyTo(modern,247); BitConverter.GetBytes((ushort)45678).CopyTo(modern,375+12);
        BitConverter.GetBytes((ushort)123).CopyTo(modern,375+30); BitConverter.GetBytes((ushort)32768).CopyTo(modern,375+32); BitConverter.GetBytes((ushort)65535).CopyTo(modern,375+34);
        string modernPath=Path.Combine(root,"source-format7.las"); File.WriteAllBytes(modernPath,modern);
        List<LasColoredPoint> modernPoints=Sample(modernPath,2);
        Check(modernPoints.Count==1 && modernPoints[0].Red==123 && modernPoints[0].Green==32768 && modernPoints[0].Blue==65535,"extended count and format7 RGB offset");
        Roundtrip(modernPoints,"format7-to-format3");
        string output=Path.Combine(root,"no-implicit-colors.las");
        using(var colored=new LasBatchStreamWriter(output,true))
            Reject<InvalidOperationException>(()=>colored.WritePoints(new List<Vector4D>{sample[0].Position}),"cannot fabricate color from W");
        using(var plain=new LasBatchStreamWriter(output))
            Reject<InvalidOperationException>(()=>plain.WriteColoredPoints(sample),"cannot drop color into plain writer");
        byte[] source=File.ReadAllBytes(fixture); source[104]=130; string compressed=Path.Combine(root,"compressed.las");File.WriteAllBytes(compressed,source);
        Reject<NotSupportedException>(()=>Sample(compressed,1),"compressed point data rejected");
        source[104]=2;Array.Resize(ref source,source.Length-1);string truncated=Path.Combine(root,"truncated.las");File.WriteAllBytes(truncated,source);
        Reject<InvalidDataException>(()=>Sample(truncated,1),"truncated source rejected before export");
        string preserved=Path.Combine(root,"cancel-preserves-target.las"); File.WriteAllBytes(preserved,new byte[]{1,2,3});
        using(var writer=new LasBatchStreamWriter(preserved,true))
        { writer.WriteColoredPoints(sample);writer.IsCancellationRequested=()=>true;Reject<OperationCanceledException>(()=>writer.Complete(),"cancel staging"); }
        Check(File.ReadAllBytes(preserved).Length==3,"cancel leaves original target unchanged");
        for(int i=0;i<args.Length;i++) { List<LasColoredPoint> real=Sample(args[i],64); Check(real.Count>0,"real source has records"); Roundtrip(real,"real-"+i); }
        Console.WriteLine("PASS "+checks+" RGB reader/writer roundtrip checks; real sources: "+args.Length);
        return 0;
    }
}
