using System;
using System.Collections.Generic;
using System.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.IO
{
    /// <summary>
    /// Streaming LAS 1.2 writer — format 1 (28 bytes), or explicit RGB
    /// format 3 (34 bytes) using attributed source records.
    /// Peak memory for points: zero (writes raw records to disk immediately).
    /// Complete converts raw records in the staging file and validates the header.
    /// </summary>
    public class LasBatchStreamWriter : IDisposable
    {
        private const int HeaderSize = 227;
        private readonly int PointRecordSize;
        private readonly bool _hasRgb;

        private readonly string _filePath;
        private readonly string _stagePath;
        private readonly string _expectedFinalFingerprint;
        private FileStream _fileStream;
        private int _totalPoints;

        private double _xMin = double.PositiveInfinity, _xMax = double.NegativeInfinity;
        private double _yMin = double.PositiveInfinity, _yMax = double.NegativeInfinity;
        private double _zMin = double.PositiveInfinity, _zMax = double.NegativeInfinity;
        private bool _disposed;
        private bool _completionStarted;
        private bool _completed;

        public Action<int, int> OnProgress { get; set; }
        public Func<bool> IsCancellationRequested { get; set; }

        public LasBatchStreamWriter(string filePath) : this(filePath, false) { }

        public LasBatchStreamWriter(string filePath, bool hasRgb)
        {
            _hasRgb=hasRgb;
            PointRecordSize=hasRgb?34:28;
            if (String.IsNullOrEmpty(filePath)) throw new ArgumentException("LAS path is required.", "filePath");
            _filePath = Path.GetFullPath(filePath);
            if (!String.Equals(Path.GetExtension(_filePath), ".las",
                StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("LAS output must have a .las extension.", "filePath");
            _stagePath = PreparedLasFile.CreateStagePath(_filePath);
            _expectedFinalFingerprint = PreparedLasFile.CaptureExpectedFinal(_filePath);
            bool stageCreated = false;
            try
            {
                _fileStream = new FileStream(_stagePath, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);
                stageCreated = true;
                byte[] placeholder = new byte[HeaderSize];
                _fileStream.Write(placeholder, 0, HeaderSize);
            }
            catch
            {
                CloseStream(true);
                if (stageCreated) PreparedLasFile.DeleteStageIfPresent(_stagePath);
                throw;
            }
        }

        public void WritePoints(List<Vector4D> pts)
        {
            EnsureWritable();
            if(_hasRgb) throw new InvalidOperationException("A colored LAS writer requires attributed records; intensity cannot stand in for RGB.");
            if (pts == null || pts.Count == 0) return;

            int count = pts.Count;
            if (count > Int32.MaxValue - _totalPoints)
                throw new InvalidOperationException("LAS point count exceeds the supported record range.");

            byte[] buf = new byte[PointRecordSize];

            for (int i = 0; i < count; i++)
            {
                CheckCancellation();
                Vector4D pt = pts[i];

                double px = pt.X, py = pt.Y, pz = pt.Z;
                if (!Finite(px) || !Finite(py) || !Finite(pz) || !Finite(pt.W))
                    throw new ArgumentException("LAS point coordinates and intensity must be finite.", "pts");
                if (px < _xMin) _xMin = px;
                if (px > _xMax) _xMax = px;
                if (py < _yMin) _yMin = py;
                if (py > _yMax) _yMax = py;
                if (pz < _zMin) _zMin = pz;
                if (pz > _zMax) _zMax = pz;

                BitConverter.GetBytes(px).CopyTo(buf, 0);
                BitConverter.GetBytes(py).CopyTo(buf, 8);
                BitConverter.GetBytes(pz).CopyTo(buf, 16);

                BitConverter.GetBytes(Intensity(pt.W)).CopyTo(buf, 24);
                buf[26] = 0;
                buf[27] = 0;

                _fileStream.Write(buf, 0, PointRecordSize);
                _totalPoints++;
            }
        }

        public void WriteColoredPoints(IList<LasColoredPoint> points)
        {
            EnsureWritable();
            if(!_hasRgb) throw new InvalidOperationException("Create the LAS writer with hasRgb=true to preserve RGB.");
            if(points==null || points.Count==0) return;
            if(points.Count>Int32.MaxValue-_totalPoints) throw new InvalidOperationException("LAS point count exceeds the supported record range.");
            byte[] record=new byte[PointRecordSize];
            foreach(LasColoredPoint point in points)
            {
                CheckCancellation();
                Vector4D p=point.Position;
                if(!Finite(p.X) || !Finite(p.Y) || !Finite(p.Z) || !Finite(p.W)) throw new ArgumentException("Non-finite colored LAS record.");
                _xMin=Math.Min(_xMin,p.X); _xMax=Math.Max(_xMax,p.X);
                _yMin=Math.Min(_yMin,p.Y); _yMax=Math.Max(_yMax,p.Y);
                _zMin=Math.Min(_zMin,p.Z); _zMax=Math.Max(_zMax,p.Z);
                BitConverter.GetBytes(p.X).CopyTo(record,0); BitConverter.GetBytes(p.Y).CopyTo(record,8); BitConverter.GetBytes(p.Z).CopyTo(record,16);
                BitConverter.GetBytes(Intensity(p.W)).CopyTo(record,24);
                BitConverter.GetBytes(point.Red).CopyTo(record,28); BitConverter.GetBytes(point.Green).CopyTo(record,30); BitConverter.GetBytes(point.Blue).CopyTo(record,32);
                _fileStream.Write(record,0,record.Length); _totalPoints++;
            }
        }

        public PreparedLasFile Complete()
        {
            EnsureWritable();
            _completionStarted = true;

            int pointCount = _totalPoints;
            double xOffset = pointCount == 0 ? 0 : _xMin;
            double yOffset = pointCount == 0 ? 0 : _yMin;
            double zOffset = pointCount == 0 ? 0 : _zMin;
            double xScale = PreparedLasFile.CoordinateScale(xOffset,
                pointCount == 0 ? 0 : _xMax);
            double yScale = PreparedLasFile.CoordinateScale(yOffset,
                pointCount == 0 ? 0 : _yMax);
            double zScale = PreparedLasFile.CoordinateScale(zOffset,
                pointCount == 0 ? 0 : _zMax);

            long dataStart = HeaderSize;
            long dataEnd = dataStart + (long)pointCount * PointRecordSize;

            try
            {
                CheckCancellation();
                int pointsPerChunk = 10000;
                int bytesPerChunk = pointsPerChunk * PointRecordSize;
                byte[] chunk = new byte[bytesPerChunk];
                byte[] converted = new byte[bytesPerChunk];
                int reportEvery = Math.Max(1, pointCount / 100);
                int progressCounter = 0;

                for (long chunkStart = dataStart; chunkStart < dataEnd; chunkStart += bytesPerChunk)
                {
                    CheckCancellation();

                    int bytesInChunk = (int)Math.Min((long)bytesPerChunk, dataEnd - chunkStart);
                    _fileStream.Position = chunkStart;
                    ReadExactly(_fileStream, chunk, bytesInChunk);

                    int recordsInChunk = bytesInChunk / PointRecordSize;
                    for (int j = 0; j < recordsInChunk; j++)
                    {
                        CheckCancellation();
                        int off = j * PointRecordSize;

                        double x = BitConverter.ToDouble(chunk, off);
                        double y = BitConverter.ToDouble(chunk, off + 8);
                        double z = BitConverter.ToDouble(chunk, off + 16);
                        ushort intensity = BitConverter.ToUInt16(chunk, off + 24);

                        int Xi = Coordinate(x, xOffset, xScale);
                        int Yi = Coordinate(y, yOffset, yScale);
                        int Zi = Coordinate(z, zOffset, zScale);

                        BitConverter.GetBytes(Xi).CopyTo(converted, off);
                        BitConverter.GetBytes(Yi).CopyTo(converted, off + 4);
                        BitConverter.GetBytes(Zi).CopyTo(converted, off + 8);
                        BitConverter.GetBytes(intensity).CopyTo(converted, off + 12);
                        // One point per pulse: return 1 of 1 (low and next three bits).
                        converted[off + 14] = 9;
                        converted[off + 15] = 2;
                        converted[off + 16] = 0;
                        converted[off + 17] = 0;
                        BitConverter.GetBytes((ushort)0).CopyTo(converted, off + 18);
                        BitConverter.GetBytes(0.0).CopyTo(converted, off + 20);
                        if(_hasRgb) Buffer.BlockCopy(chunk,off+28,converted,off+28,6);

                        progressCounter++;
                        if (OnProgress != null && (progressCounter % reportEvery == 0 || progressCounter == pointCount))
                            OnProgress(progressCounter, pointCount);
                    }

                    _fileStream.Position = chunkStart;
                    _fileStream.Write(converted, 0, bytesInChunk);
                }

                CheckCancellation();
                _fileStream.Position = 0;
                WriteHeader(_fileStream, pointCount, xOffset, yOffset, zOffset,
                    xScale, yScale, zScale);
                _fileStream.Flush();
                CloseStream(false);
                PreparedLasFile.ValidateStage(_stagePath);
                PreparedLasFile prepared = new PreparedLasFile(_filePath, _stagePath, _expectedFinalFingerprint);
                _completed = true;
                return prepared;
            }
            catch
            {
                CloseStream(true);
                PreparedLasFile.DeleteStageIfPresent(_stagePath);
                throw;
            }
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            CloseStream(true);
            if (!_completed) PreparedLasFile.DeleteStageIfPresent(_stagePath);
        }

        private void EnsureWritable()
        {
            if (_disposed) throw new ObjectDisposedException("LasBatchStreamWriter");
            if (_completionStarted) throw new InvalidOperationException("LAS completion has already started.");
        }

        private void CheckCancellation()
        {
            if (IsCancellationRequested != null && IsCancellationRequested())
                throw new OperationCanceledException("LAS export was canceled.");
        }

        private static bool Finite(double value)
        {
            return !Double.IsNaN(value) && !Double.IsInfinity(value);
        }

        private static ushort Intensity(double value)
        {
            double rounded = Math.Round(value);
            if (rounded < 0) return 0;
            if (rounded > UInt16.MaxValue) return UInt16.MaxValue;
            return (ushort)rounded;
        }

        private static int Coordinate(double value, double offset, double scale)
        {
            double rounded = Math.Round((value - offset) / scale);
            if (!Finite(rounded) || rounded < Int32.MinValue || rounded > Int32.MaxValue)
                throw new InvalidDataException("LAS coordinate exceeds the signed 32-bit record range.");
            return (int)rounded;
        }

        private static double EncodedMaximum(double rawMaximum, double offset, double scale)
        {
            return offset + Coordinate(rawMaximum, offset, scale) * scale;
        }

        private static void ReadExactly(FileStream stream, byte[] buffer, int count)
        {
            int read = 0;
            while (read < count)
            {
                int next = stream.Read(buffer, read, count - read);
                if (next == 0) throw new EndOfStreamException("LAS staging point records are incomplete.");
                read += next;
            }
        }

        private void WriteHeader(FileStream stream, int pointCount,
            double xOffset, double yOffset, double zOffset,
            double xScale, double yScale, double zScale)
        {
            byte[] header = new byte[HeaderSize];

            header[0] = (byte)'L';
            header[1] = (byte)'A';
            header[2] = (byte)'S';
            header[3] = (byte)'F';

            header[24] = 1;
            header[25] = 2;

            BitConverter.GetBytes((ushort)HeaderSize).CopyTo(header, 94);
            BitConverter.GetBytes((uint)HeaderSize).CopyTo(header, 96);

            header[104] = (byte)(_hasRgb?3:1);
            BitConverter.GetBytes((ushort)PointRecordSize).CopyTo(header, 105);
            BitConverter.GetBytes((uint)pointCount).CopyTo(header, 107);

            BitConverter.GetBytes((uint)pointCount).CopyTo(header, 111);

            BitConverter.GetBytes(xScale).CopyTo(header, 131);
            BitConverter.GetBytes(yScale).CopyTo(header, 139);
            BitConverter.GetBytes(zScale).CopyTo(header, 147);

            BitConverter.GetBytes(xOffset).CopyTo(header, 155);
            BitConverter.GetBytes(yOffset).CopyTo(header, 163);
            BitConverter.GetBytes(zOffset).CopyTo(header, 171);

            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(_xMax, xOffset, xScale)).CopyTo(header, 179);
            BitConverter.GetBytes(pointCount == 0 ? 0 : _xMin).CopyTo(header, 187);
            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(_yMax, yOffset, yScale)).CopyTo(header, 195);
            BitConverter.GetBytes(pointCount == 0 ? 0 : _yMin).CopyTo(header, 203);
            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(_zMax, zOffset, zScale)).CopyTo(header, 211);
            BitConverter.GetBytes(pointCount == 0 ? 0 : _zMin).CopyTo(header, 219);

            stream.Write(header, 0, HeaderSize);
        }

        private void CloseStream(bool ignoreErrors)
        {
            if (_fileStream != null)
            {
                FileStream stream = _fileStream;
                _fileStream = null;
                if (ignoreErrors)
                {
                    try { stream.Close(); }
                    catch { }
                }
                else
                {
                    stream.Close();
                }
            }
        }
    }
}
