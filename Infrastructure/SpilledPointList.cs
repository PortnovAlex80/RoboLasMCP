using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Read-only point list stored beside the requested LAS output. SamplingHelper
    /// reads it in source order without retaining both split categories in RAM.
    /// </summary>
    internal sealed class SpilledPointList : IList<Vector4D>, IDisposable
    {
        private const int RecordSize = 32;
        private readonly string _path;
        private readonly int _count;
        private FileStream _stream;
        private BinaryReader _reader;

        internal SpilledPointList(string path, int count)
        {
            _path = path;
            _count = count;
            _stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                if (_stream.Length != (long)count * RecordSize)
                    throw new InvalidDataException("Point spool length does not match its count.");
                _reader = new BinaryReader(_stream);
            }
            catch
            {
                _stream.Close();
                _stream = null;
                throw;
            }
        }

        public int Count { get { return _count; } }
        public bool IsReadOnly { get { return true; } }

        public Vector4D this[int index]
        {
            get
            {
                if (_reader == null) throw new ObjectDisposedException("SpilledPointList");
                if (index < 0 || index >= _count) throw new ArgumentOutOfRangeException("index");
                _stream.Position = (long)index * RecordSize;
                return new Vector4D(_reader.ReadDouble(), _reader.ReadDouble(),
                    _reader.ReadDouble(), _reader.ReadDouble());
            }
            set { throw new NotSupportedException("The point spool is read-only."); }
        }

        public int IndexOf(Vector4D item)
        {
            for (int i = 0; i < _count; i++)
                if (Object.Equals(this[i], item)) return i;
            return -1;
        }
        public bool Contains(Vector4D item) { return IndexOf(item) >= 0; }
        public void CopyTo(Vector4D[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (arrayIndex < 0 || arrayIndex > array.Length ||
                _count > array.Length - arrayIndex)
                throw new ArgumentOutOfRangeException("arrayIndex");
            for (int i = 0; i < _count; i++) array[arrayIndex + i] = this[i];
        }
        public IEnumerator<Vector4D> GetEnumerator()
        {
            for (int i = 0; i < _count; i++) yield return this[i];
        }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        public void Add(Vector4D item) { throw new NotSupportedException(); }
        public void Clear() { throw new NotSupportedException(); }
        public void Insert(int index, Vector4D item) { throw new NotSupportedException(); }
        public bool Remove(Vector4D item) { throw new NotSupportedException(); }
        public void RemoveAt(int index) { throw new NotSupportedException(); }

        public void Dispose()
        {
            if (_reader == null) return;
            _reader.Close();
            _reader = null;
            _stream = null;
            try { File.Delete(_path); }
            catch (IOException error) { Trace.WriteLine("[SpilledPointList] Cleanup failed: " + error); }
            catch (UnauthorizedAccessException error) { Trace.WriteLine("[SpilledPointList] Cleanup failed: " + error); }
        }
    }

    /// <summary>Writes accepted points in traversal order, without a category list.</summary>
    internal sealed class SpilledPointWriter : IDisposable
    {
        private readonly string _path;
        private FileStream _stream;
        private BinaryWriter _writer;
        private int _count;
        private bool _transferred;

        internal SpilledPointWriter(string outputPath)
        {
            if (String.IsNullOrEmpty(outputPath))
                throw new ArgumentException("Output path is required.", "outputPath");
            _path = Path.GetFullPath(outputPath) + "." +
                Guid.NewGuid().ToString("N") + ".points.tmp";
            _stream = new FileStream(_path, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            _writer = new BinaryWriter(_stream);
        }

        internal void Append(Vector4D point)
        {
            if (_writer == null) throw new ObjectDisposedException("SpilledPointWriter");
            if (_count == Int32.MaxValue)
                throw new OutOfMemoryException("Too many points for LAS split sampling.");
            _writer.Write(point.X);
            _writer.Write(point.Y);
            _writer.Write(point.Z);
            _writer.Write(point.W);
            _count++;
        }

        internal SpilledPointList Complete()
        {
            if (_writer == null) throw new ObjectDisposedException("SpilledPointWriter");
            _writer.Close();
            _writer = null;
            _stream = null;
            SpilledPointList points = new SpilledPointList(_path, _count);
            _transferred = true;
            return points;
        }

        public void Dispose()
        {
            if (_writer != null) _writer.Close();
            else if (_stream != null) _stream.Close();
            _writer = null;
            _stream = null;
            if (_transferred) return;
            try { if (File.Exists(_path)) File.Delete(_path); }
            catch (IOException error) { Trace.WriteLine("[SpilledPointWriter] Cleanup failed: " + error); }
            catch (UnauthorizedAccessException error) { Trace.WriteLine("[SpilledPointWriter] Cleanup failed: " + error); }
        }
    }
}
