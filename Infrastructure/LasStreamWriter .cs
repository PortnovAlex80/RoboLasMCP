using System;
using System.Collections.Generic;
using System.IO;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.IO
{
    public class LasStreamWriter : IDisposable
    {
        private const int PointRecordSize = 28;
        private readonly string filePath;
        private readonly string stagePath;
        private readonly string expectedFinalFingerprint;
        private readonly List<PointRecord> points = new List<PointRecord>();
        private bool disposed;
        private bool completionStarted;
        private bool completed;

        private double xMin = double.PositiveInfinity, xMax = double.NegativeInfinity;
        private double yMin = double.PositiveInfinity, yMax = double.NegativeInfinity;
        private double zMin = double.PositiveInfinity, zMax = double.NegativeInfinity;

        public Action<int, int> OnProgress { get; set; }
        public Func<bool> IsCancellationRequested { get; set; }

        public LasStreamWriter(string filePath)
        {
            if (String.IsNullOrEmpty(filePath)) throw new ArgumentException("LAS path is required.", "filePath");
            this.filePath = Path.GetFullPath(filePath);
            if (!String.Equals(Path.GetExtension(this.filePath), ".las",
                StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("LAS output must have a .las extension.", "filePath");
            stagePath = PreparedLasFile.CreateStagePath(this.filePath);
            expectedFinalFingerprint = PreparedLasFile.CaptureExpectedFinal(this.filePath);
        }

        public void WritePoints(List<Vector4D> rawPoints)
        {
            EnsureWritable();
            if (rawPoints == null) return;
            foreach (Vector4D pt in rawPoints)
            {
                CheckCancellation();
                if (!Finite(pt.X) || !Finite(pt.Y) || !Finite(pt.Z) || !Finite(pt.W))
                    throw new ArgumentException("LAS point coordinates and intensity must be finite.", "rawPoints");
                PointRecord p = new PointRecord(pt.X, pt.Y, pt.Z, pt.W);
                UpdateBounds(p.X, p.Y, p.Z);
                points.Add(p);
            }
        }

        private void UpdateBounds(double x, double y, double z)
        {
            if (x < xMin) xMin = x;
            if (x > xMax) xMax = x;
            if (y < yMin) yMin = y;
            if (y > yMax) yMax = y;
            if (z < zMin) zMin = z;
            if (z > zMax) zMax = z;
        }

        public PreparedLasFile Complete()
        {
            EnsureWritable();
            completionStarted = true;
            double xOffset = points.Count == 0 ? 0 : xMin;
            double yOffset = points.Count == 0 ? 0 : yMin;
            double zOffset = points.Count == 0 ? 0 : zMin;
            double xScale = PreparedLasFile.CoordinateScale(xOffset,
                points.Count == 0 ? 0 : xMax);
            double yScale = PreparedLasFile.CoordinateScale(yOffset,
                points.Count == 0 ? 0 : yMax);
            double zScale = PreparedLasFile.CoordinateScale(zOffset,
                points.Count == 0 ? 0 : zMax);
            int pointCount = points.Count;
            bool stageCreated = false;
            try
            {
                CheckCancellation();
                using (FileStream stream = new FileStream(stagePath, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    stageCreated = true;
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        WriteHeader(writer, pointCount, xOffset, yOffset, zOffset,
                            xScale, yScale, zScale);
                        int reportEvery = Math.Max(1, pointCount / 100);
                        for (int i = 0; i < pointCount; i++)
                        {
                            CheckCancellation();
                            PointRecord p = points[i];
                            writer.Write(Coordinate(p.X, xOffset, xScale));
                            writer.Write(Coordinate(p.Y, yOffset, yScale));
                            writer.Write(Coordinate(p.Z, zOffset, zScale));
                            writer.Write(Intensity(p.Intensity));
                            // One point per pulse: return 1 of 1 (low and next three bits).
                            writer.Write((byte)9);
                            writer.Write((byte)2);
                            writer.Write((sbyte)0);
                            writer.Write((byte)0);
                            writer.Write((ushort)0);
                            writer.Write(0.0);
                            if (OnProgress != null && (i % reportEvery == 0 || i == pointCount - 1))
                                OnProgress(i + 1, pointCount);
                        }
                        CheckCancellation();
                        writer.Flush();
                    }
                }
                PreparedLasFile.ValidateStage(stagePath);
                PreparedLasFile prepared = new PreparedLasFile(filePath, stagePath, expectedFinalFingerprint);
                completed = true;
                points.Clear();
                return prepared;
            }
            catch
            {
                if (stageCreated) PreparedLasFile.DeleteStageIfPresent(stagePath);
                throw;
            }
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;
            points.Clear();
            if (!completed) PreparedLasFile.DeleteStageIfPresent(stagePath);
        }

        private void EnsureWritable()
        {
            if (disposed) throw new ObjectDisposedException("LasStreamWriter");
            if (completionStarted) throw new InvalidOperationException("LAS completion has already started.");
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

        private static ushort Intensity(double value)
        {
            double rounded = Math.Round(value);
            if (rounded < 0) return 0;
            if (rounded > UInt16.MaxValue) return UInt16.MaxValue;
            return (ushort)rounded;
        }

        private void WriteHeader(BinaryWriter writer, int pointCount,
            double xOffset, double yOffset, double zOffset,
            double xScale, double yScale, double zScale)
        {
            byte[] header = new byte[227];

            header[0] = (byte)'L';
            header[1] = (byte)'A';
            header[2] = (byte)'S';
            header[3] = (byte)'F';

            header[24] = 1;
            header[25] = 2;

            BitConverter.GetBytes((ushort)227).CopyTo(header, 94);
            BitConverter.GetBytes((uint)227).CopyTo(header, 96);

            header[104] = 1;
            BitConverter.GetBytes((ushort)PointRecordSize).CopyTo(header, 105);
            BitConverter.GetBytes((uint)pointCount).CopyTo(header, 107);

            BitConverter.GetBytes((uint)pointCount).CopyTo(header, 111);

            BitConverter.GetBytes(xScale).CopyTo(header, 131);
            BitConverter.GetBytes(yScale).CopyTo(header, 139);
            BitConverter.GetBytes(zScale).CopyTo(header, 147);

            BitConverter.GetBytes(xOffset).CopyTo(header, 155);
            BitConverter.GetBytes(yOffset).CopyTo(header, 163);
            BitConverter.GetBytes(zOffset).CopyTo(header, 171);

            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(xMax, xOffset, xScale)).CopyTo(header, 179);
            BitConverter.GetBytes(pointCount == 0 ? 0 : xMin).CopyTo(header, 187);
            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(yMax, yOffset, yScale)).CopyTo(header, 195);
            BitConverter.GetBytes(pointCount == 0 ? 0 : yMin).CopyTo(header, 203);
            BitConverter.GetBytes(pointCount == 0 ? 0 : EncodedMaximum(zMax, zOffset, zScale)).CopyTo(header, 211);
            BitConverter.GetBytes(pointCount == 0 ? 0 : zMin).CopyTo(header, 219);

            writer.Write(header);
        }

        private struct PointRecord : IEquatable<PointRecord>
        {
            public double X;
            public double Y;
            public double Z;
            public double Intensity;

            public PointRecord(double x, double y, double z, double intensity)
            {
                X = x;
                Y = y;
                Z = z;
                Intensity = intensity;
            }

            public bool Equals(PointRecord other)
            {
                return X == other.X && Y == other.Y && Z == other.Z && Intensity == other.Intensity;
            }

            public override bool Equals(object obj)
            {
                if (obj is PointRecord)
                {
                    return Equals((PointRecord)obj);
                }
                return false;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + X.GetHashCode();
                    hash = hash * 23 + Y.GetHashCode();
                    hash = hash * 23 + Z.GetHashCode();
                    hash = hash * 23 + Intensity.GetHashCode();
                    return hash;
                }
            }
        }
    }
}
