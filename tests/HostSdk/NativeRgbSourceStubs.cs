// Companion types for compiling the developer-supplied LidarBuffer.cs itself.
// The test uses real SDK vectors and real supplied FindPoints/LDAR v2 I/O.
using Topomatic.Cad.Foundation;
namespace Topomatic.Lidar
{
    public interface IProgressArgs { }
    public sealed class NativeTestBuffer<T>
    {
        private T[] data = new T[0];
        public int Count { get; set; }
        public int Capacity { get { return data.Length; } set { System.Array.Resize(ref data, value); } }
        public T[] GetBuffer() { return data; }
        public T this[int i] { get { return data[i]; } set { data[i] = value; } }
    }
    public class QuadTreeLeaf
    {
        public int start, count;
        public float minx, maxx, miny, maxy, minz, maxz;
        public QuadTreeLeaf[] leafs;
    }
    public sealed class QuadTreeIndexer : QuadTreeLeaf, System.IDisposable
    {
        public NativeTestBuffer<Vector3F> points = new NativeTestBuffer<Vector3F>();
        public NativeTestBuffer<byte> weights = new NativeTestBuffer<byte>();
        public NativeTestBuffer<byte> texture = new NativeTestBuffer<byte>();
        public Vector3D position, scale;
        public QuadTreeIndexer() { }
        public QuadTreeIndexer(LiDAR model, object[] records, IProgressArgs args, int classification) { }
        public void Transform(Matrix matrix) { }
        public void Dispose() { }
    }
    public sealed class LiDAR { public NativeTestRecords Records = new NativeTestRecords(); }
    public sealed class NativeTestRecords { public object[][] Buffer = new object[0][]; }
}
