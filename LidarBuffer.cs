using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using Topomatic.Cad.Foundation;

namespace Topomatic.Lidar
{
    public class LidarBuffer : IDisposable
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private unsafe static extern int WriteFile(SafeFileHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

        [DllImport("kernel32.dll", SetLastError = true)]
        private unsafe static extern int ReadFile(SafeFileHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, IntPtr mustBeZero);

        public QuadTreeIndexer[] indexers;
        public float maxz;
        public float minz;
        public string fullpath;

        public LidarBuffer(LiDAR model, IProgressArgs args, int classification)
        {
            var buffer = model.Records.Buffer;
            ParameterizedThreadStart runable = delegate(object obj)
            {
                var index = (int)obj;
                var buf = buffer[index];
                indexers[index] = new QuadTreeIndexer(model, buf, args, classification);
            };
            indexers = new QuadTreeIndexer[buffer.Length];
            if (buffer.Length > 0)
            {
                Thread[] threads = new Thread[buffer.Length - 1];
                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i] = new Thread(runable);
                    threads[i].Start(i);
                }
                runable(threads.Length);
                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i].Join();
                }
            }
            UpdateMinMaxZ();
         }

        private void UpdateMinMaxZ()
        {
            minz = float.MaxValue;
            maxz = float.MinValue;
            for (int i = 0; i < indexers.Length; i++)
            {
                var m = indexers[i];
                minz = Math.Min(minz, m.minz);
                maxz = Math.Max(maxz, m.maxz);
            }
            var h = maxz - minz;
            var lmin = minz + 0.05 * h;
            var lmax = maxz - 0.05 * h; 
            maxz = float.MinValue;
            minz = float.MaxValue;
            for (int i = 0; i < indexers.Length; i++)
            {
                var m = indexers[i];
                var l = m.points.Count;
                var pnts = m.points.GetBuffer();
                for (int j = 0; j < l; j++)
                {
                    var pt = pnts[j];
                    if ((pt.Z > lmin) && (pt.Z < lmax))
                    {
                        minz = Math.Min(minz, pt.Z);
                        maxz = Math.Max(maxz, pt.Z);
                    }
                }
            }
        }

        public LidarBuffer()
        {
            indexers = new QuadTreeIndexer[0];
        }

        public void SaveToFile(string filename)
        {
            fullpath = filename;
            using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                stream.WriteByte((byte)'L');
                stream.WriteByte((byte)'D');
                stream.WriteByte((byte)'A');
                stream.WriteByte((byte)'R');
                var version = Colored ? (byte)2 : (byte)1;
                stream.WriteByte(version);
                var handle = stream.SafeFileHandle;
                WriteInteger(handle, indexers.Length);
                using (var ms = new MemoryStream())
                {
                    using (var writer = new BinaryWriter(ms))
                    {
                        for (int i = 0; i < indexers.Length; i++)
                        {
                            var indexer = indexers[i];
                            WriteVector3D(handle, indexer.position);
                            WriteVector3D(handle, indexer.scale);
                            var cnt = indexer.points.Count;
                            WriteInteger(handle, cnt);
                            unsafe
                            {
                                fixed (Vector3F* points = indexer.points.GetBuffer())
                                {
                                    WriteBuffer(handle, points, 12 * cnt);
                                }
                                fixed (byte* w = indexer.weights.GetBuffer())
                                {
                                    WriteBuffer(handle, w, cnt);
                                }
                                if (version > 1)
                                {
                                    fixed (byte* w = indexer.texture.GetBuffer())
                                    {
                                        WriteBuffer(handle, w, cnt * 3);
                                    }
                                }
                                WriteLeaf(writer, indexer);
                                writer.Flush();
                                var buffer = ms.GetBuffer();
                                WriteInteger(handle, (int)ms.Position);
                                fixed (byte* pbuffer = buffer)
                                {
                                    WriteBuffer(handle, pbuffer, (int)ms.Position);
                                }
                                ms.Position = 0;
                            }
                        }
                    }
                }
                Topomatic.Stg.StreamExtentions.FlushFile(stream);
            }
        }

        private static void WriteLeaf(BinaryWriter writer, QuadTreeLeaf leaf)
        {
            writer.Write((int)leaf.start);
            writer.Write((int)leaf.count);
            if (leaf.leafs == null)
            {
                writer.Write((byte)0);
            }
            else
            {
                byte flags = 0;
                for (int i = 0; i < leaf.leafs.Length; i++)
                {
                    if (leaf.leafs[i] != null)
                    {
                        flags |= (byte)(1 << i);
                    }
                }
                writer.Write((byte)flags);
                for (int i = 0; i < leaf.leafs.Length; i++)
                {
                    if (leaf.leafs[i] != null)
                    {
                        WriteLeaf(writer, leaf.leafs[i]);
                    }
                }
            }
        }

        private unsafe static void ReadLeaf(ref byte* buffer, QuadTreeLeaf leaf, Vector3F[] points)
        {
            leaf.start = *(int*)buffer;
            buffer += 4;
            leaf.count = *(int*)buffer;
            buffer += 4;
            var flags = *buffer;
            buffer++;
            if (flags == 0)
            {
                leaf.leafs = null;
                if (leaf.count > 0)
                {
                    var pt = points[leaf.start];
                    leaf.minx = leaf.maxx = pt.X;
                    leaf.miny = leaf.maxy = pt.Y;
                    leaf.minz = leaf.maxz = pt.Z;
                    for (int i = 1; i < leaf.count; i++)
                    {
                        pt = points[leaf.start + i];
                        leaf.minx = Math.Min(leaf.minx, pt.X);
                        leaf.maxx = Math.Max(leaf.maxx, pt.X);
                        leaf.miny = Math.Min(leaf.miny, pt.Y);
                        leaf.maxy = Math.Max(leaf.maxy, pt.Y);
                        leaf.minz = Math.Min(leaf.minz, pt.Z);
                        leaf.maxz = Math.Max(leaf.maxz, pt.Z);
                    }
                }
            }
            else
            {
                leaf.leafs = new QuadTreeLeaf[4];
                bool initialized = false;
                for (int i = 0; i < leaf.leafs.Length; i++)
                {
                    if ((flags & (1 << i)) != 0)
                    {
                        leaf.leafs[i] = new QuadTreeLeaf();
                        ReadLeaf(ref buffer, leaf.leafs[i], points);
                        if (initialized)
                        {
                            leaf.minx = Math.Min(leaf.minx, leaf.leafs[i].minx);
                            leaf.maxx = Math.Max(leaf.maxx, leaf.leafs[i].maxx);
                            leaf.miny = Math.Min(leaf.miny, leaf.leafs[i].miny);
                            leaf.maxy = Math.Max(leaf.maxy, leaf.leafs[i].maxy);
                            leaf.minz = Math.Min(leaf.minz, leaf.leafs[i].minz);
                            leaf.maxz = Math.Max(leaf.maxz, leaf.leafs[i].maxz);
                        }
                        else
                        {
                            initialized = true;
                            leaf.minx = leaf.leafs[i].minx;
                            leaf.maxx = leaf.leafs[i].maxx;
                            leaf.miny = leaf.leafs[i].miny;
                            leaf.maxy = leaf.leafs[i].maxy;
                            leaf.minz = leaf.leafs[i].minz;
                            leaf.maxz = leaf.leafs[i].maxz;
                        }
                    }
                }
            }
        }

        private unsafe static void WriteBuffer(SafeFileHandle handle, void* ptr, int size)
        {
            int result;
            var cres = WriteFile(handle, (byte*)ptr, size, out result, IntPtr.Zero);
            if (cres == 0)
            {
                var hr = Marshal.GetHRForLastWin32Error();
                Marshal.ThrowExceptionForHR(hr);
            }
        }

        private unsafe static void ReadBuffer(SafeFileHandle handle, void* ptr, int size)
        {
            int result;
            var cres = ReadFile(handle, (byte*)ptr, size, out result, IntPtr.Zero);
            if (cres == 0)
            {
                var hr = Marshal.GetHRForLastWin32Error();
                Marshal.ThrowExceptionForHR(hr);
            }
        }

        private unsafe static void WriteInteger(SafeFileHandle handle, int value)
        {
            WriteBuffer(handle, &value, 4);
        }

        private unsafe static int ReadInteger(SafeFileHandle handle)
        {
            int value;
            ReadBuffer(handle, &value, 4);
            return value;
        }

        private unsafe static void WriteByte(SafeFileHandle handle, byte value)
        {
            WriteBuffer(handle, &value, 1);
        }

        private unsafe static byte ReadByte(SafeFileHandle handle)
        {
            byte value;
            ReadBuffer(handle, &value, 1);
            return value;
        }

        private unsafe static void WriteVector3D(SafeFileHandle handle, Vector3D value)
        {
            WriteBuffer(handle, &value, 8 * 3);
        }

        private unsafe static Vector3D ReadVector3D(SafeFileHandle handle)
        {
            Vector3D value;
            ReadBuffer(handle, &value, 8 * 3);
            return value;
        }

        public void LoadFromFile(string filename)
        {
            fullpath = filename;
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var handle = stream.SafeFileHandle;
                var signature = (uint)ReadInteger(handle);
                if (signature != 0x5241444C)
                {
                    throw new FormatException();
                }
                var version = ReadByte(handle);
                if (version > 2)
                {
                    throw new FormatException();
                }
                var l = ReadInteger(handle);
                indexers = new QuadTreeIndexer[l];
                byte[] buffer = null;
                for (int i = 0; i < indexers.Length; i++)
                {
                    var indexer = new QuadTreeIndexer();
                    indexers[i] = indexer;
                    indexer.position = ReadVector3D(handle);
                    indexer.scale = ReadVector3D(handle);
                    var cnt = ReadInteger(handle);
                    indexer.points.Capacity = cnt;
                    indexer.points.Count = cnt;
                    indexer.weights.Capacity = cnt;
                    indexer.weights.Count = cnt;
                    unsafe
                    {
                        fixed (Vector3F* p = indexer.points.GetBuffer())
                        {
                            ReadBuffer(handle, p, 12 * cnt);
                        }
                        fixed (byte* w = indexer.weights.GetBuffer())
                        {
                            ReadBuffer(handle, w, cnt);
                        }
                        if (version > 1)
                        {
                            indexer.texture.Capacity = cnt * 3;
                            indexer.texture.Count = cnt * 3;
                            fixed (byte* w = indexer.texture.GetBuffer())
                            {
                                ReadBuffer(handle, w, cnt * 3);
                            }
                        }
                        var size = ReadInteger(handle);
                        if ((buffer == null) || (buffer.Length < size))
                        {
                            buffer = new byte[size + size / 8];
                        }
                        fixed (byte* pbuffer = buffer)
                        {
                            ReadBuffer(handle, pbuffer, size);
                            byte* ptr = pbuffer;
                            ReadLeaf(ref ptr, indexer, indexer.points.GetBuffer());
                        }
                    }
                }
                UpdateMinMaxZ();
            }
        }

        public void FindPoints(BoundingBox2D bounds, Action<LidarPoint> action)
        {
            for (int i = 0; i < indexers.Length; i++)
            {
                var model = indexers[i];
                var box = bounds;
                box.Min = (box.Min - model.position.Pos) / model.scale.Pos;
                box.Max = (box.Max - model.position.Pos) / model.scale.Pos;
                FindPoints(model, model, ref box, action);
            }
        }

        public void Transform(Matrix matrix)
        {
            foreach (var index in indexers)
            {
                index.Transform(matrix);
            }
            UpdateMinMaxZ();
        }

        private static void FindPoints(QuadTreeIndexer model, QuadTreeLeaf leaf, ref BoundingBox2D box, Action<LidarPoint> action)
        {
            if (leaf == null)
            {
                return;
            }
            BoundingBox2D lbounds;
            lbounds.Min.X = leaf.minx;
            lbounds.Min.Y = leaf.miny;
            lbounds.Max.X = leaf.maxx;
            lbounds.Max.Y = leaf.maxy;
            if (box.Contains(lbounds) != ContainmentType.Disjoint)
            {
                if (leaf.leafs == null)
                {
                    var points = model.points.GetBuffer();
                    for (int i = 0; i < leaf.count; i++)
                    {
                        var pt = points[i + leaf.start];
                        if (box.Contains(new Vector2D(pt.X, pt.Y)) != ContainmentType.Disjoint)
                        {
                            var weight = (double)model.weights[i + leaf.start] / 255;
                            var lpt = new LidarPoint();
                            lpt.X = pt.X * model.scale.X + model.position.X;
                            lpt.Y = pt.Y * model.scale.Y + model.position.Y;
                            lpt.Z = pt.Z * model.scale.Z + model.position.Z;
                            lpt.Weight = weight;
                            if (model.texture.Count > 0)
                            {
                                lpt.Red = model.texture[(i + leaf.start) * 3];
                                lpt.Green = model.texture[(i + leaf.start) * 3 + 1];
                                lpt.Blue = model.texture[(i + leaf.start) * 3 + 2];
                            }
                            action(lpt);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < leaf.leafs.Length; i++)
                    {
                        FindPoints(model, leaf.leafs[i], ref box, action);
                    }
                }
            }
        }
        public bool Colored
        {
            get
            {
                return indexers.Length > 0 && indexers[0].texture.Count > 0;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            for (int i = 0; i < indexers.Length; i++)
            {
                indexers[i].Dispose();
            }
            indexers = new QuadTreeIndexer[0];
        }

        #endregion
    }
    public struct LidarPoint
    {
        public double X;
        public double Y;
        public double Z;
        public double Weight;
        public byte Red;
        public byte Green;
        public byte Blue;
    }
}
