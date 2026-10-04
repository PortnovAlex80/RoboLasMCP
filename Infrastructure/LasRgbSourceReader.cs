using System;
using System.Collections.Generic;
using System.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.IO
{
    // Bounded streaming reader for verified LAS source paths. Binding a loaded
    // SDK cloud to this original record stream is a separate provenance check.
    public static class LasRgbSourceReader
    {
        public static IEnumerable<LasColoredPoint> Read(string path)
        {
            string identity=Path.GetFullPath(path);
            using(FileStream stream=new FileStream(identity,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                byte[] header=new byte[227]; ReadExactly(stream,header);
                if(header[0]!='L' || header[1]!='A' || header[2]!='S' || header[3]!='F' || header[24]!=1 || header[25]<2 || header[25]>4)
                    throw new InvalidDataException("Supported RGB sources are LAS 1.2 through 1.4.");
                if((header[104]&192)!=0) throw new NotSupportedException("Compressed LAZ requires a verified decompressor; it is not raw LAS.");
                int format=header[104]; int rgbOffset, minimumRecord;
                switch(format)
                {
                    case 2: rgbOffset=20; minimumRecord=26; break;
                    case 3: rgbOffset=28; minimumRecord=34; break;
                    case 5: rgbOffset=28; minimumRecord=63; break;
                    case 7: rgbOffset=30; minimumRecord=36; break;
                    case 8: rgbOffset=30; minimumRecord=38; break;
                    case 10: rgbOffset=30; minimumRecord=67; break;
                    default: throw new InvalidDataException("The source point format has no RGB channels.");
                }
                int headerSize=BitConverter.ToUInt16(header,94), recordSize=BitConverter.ToUInt16(header,105);
                long offset=BitConverter.ToUInt32(header,96), count=BitConverter.ToUInt32(header,107);
                if(headerSize<(header[25]==4?375:header[25]==3?235:227) || offset<headerSize || recordSize<minimumRecord ||
                    format>=7 && header[25]<4 || format==5 && header[25]<3)
                    throw new InvalidDataException("Invalid LAS source header or RGB record size.");
                if(header[25]==4)
                {
                    byte[] extra=new byte[148]; ReadExactly(stream,extra);
                    ulong extended=BitConverter.ToUInt64(extra,20);
                    if(extended>Int64.MaxValue) throw new InvalidDataException("LAS point count exceeds the supported stream range.");
                    if(extended!=0) count=(long)extended;
                }
                long expected;
                try { expected=checked(offset+count*recordSize); }
                catch(OverflowException) { throw new InvalidDataException("LAS source record range overflows."); }
                if(stream.Length<expected) throw new InvalidDataException("LAS source point data is truncated.");
                double[] scale=new double[3], origin=new double[3];
                for(int axis=0;axis<3;axis++)
                {
                    scale[axis]=BitConverter.ToDouble(header,131+axis*8);
                    origin[axis]=BitConverter.ToDouble(header,155+axis*8);
                    if(!Finite(scale[axis]) || scale[axis]<=0 || !Finite(origin[axis]))
                        throw new InvalidDataException("LAS source coordinate scale/offset is invalid.");
                }
                byte[] record=new byte[recordSize]; stream.Position=offset;
                for(long index=0;index<count;index++)
                {
                    ReadExactly(stream,record);
                    double x=BitConverter.ToInt32(record,0)*scale[0]+origin[0];
                    double y=BitConverter.ToInt32(record,4)*scale[1]+origin[1];
                    double z=BitConverter.ToInt32(record,8)*scale[2]+origin[2];
                    if(!Finite(x) || !Finite(y) || !Finite(z)) throw new InvalidDataException("Non-finite source coordinate.");
                    yield return new LasColoredPoint(new Vector4D(x,y,z,BitConverter.ToUInt16(record,12)),
                        BitConverter.ToUInt16(record,rgbOffset),BitConverter.ToUInt16(record,rgbOffset+2),
                        BitConverter.ToUInt16(record,rgbOffset+4),identity,index);
                }
            }
        }
        private static bool Finite(double value) { return !Double.IsNaN(value) && !Double.IsInfinity(value); }
        private static void ReadExactly(Stream stream,byte[] buffer)
        {
            int read=0;
            while(read<buffer.Length) { int n=stream.Read(buffer,read,buffer.Length-read);
                if(n==0) throw new EndOfStreamException("Incomplete LAS source."); read+=n; }
        }
    }
}
