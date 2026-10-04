using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace LAS_TERRAIN.IO
{
    /// <summary>
    /// A complete LAS file awaiting publication. The writer transfers ownership of
    /// its same-directory staging file to this object only after validation.
    /// </summary>
    public sealed class PreparedLasFile : IDisposable
    {
        private const int HeaderSize = 227;
        private const int PointRecordSize = 28;
        internal const double DefaultCoordinateScale = 0.0001;
        private readonly string _finalPath;
        private readonly string _stagePath;
        private readonly string _expectedFinalFingerprint;
        private bool _published;
        private bool _preserveForRecovery;
        private bool _disposed;
        private Action _sourceValidation;
        private IDisposable _sourceLease;

        internal void AttachSourceLease(Action validation,IDisposable lease)
        {
            if(_sourceLease!=null)throw new InvalidOperationException("A source lease is already attached.");
            _sourceValidation=validation;_sourceLease=lease;
        }

        internal PreparedLasFile(string finalPath, string stagePath, string expectedFinalFingerprint)
        {
            _finalPath = Path.GetFullPath(finalPath);
            _stagePath = Path.GetFullPath(stagePath);
            _expectedFinalFingerprint = expectedFinalFingerprint;
        }

        public string FinalPath { get { return _finalPath; } }
        public string StagePath { get { return _stagePath; } }
        public string ExpectedFinalFingerprint { get { return _expectedFinalFingerprint; } }
        public bool IsPublished { get { return _published; } }

        public static PreparedLasFile OpenForRecovery(
            string finalPath, string stagePath, string expectedFinalFingerprint)
        {
            if (String.IsNullOrEmpty(finalPath)) throw new ArgumentException("Final path is required.", "finalPath");
            if (String.IsNullOrEmpty(stagePath)) throw new ArgumentException("Stage path is required.", "stagePath");
            string final = Path.GetFullPath(finalPath);
            string stage = Path.GetFullPath(stagePath);
            ValidateStageName(final, stage);
            ValidateFingerprint(expectedFinalFingerprint);
            ValidateStage(stage);
            return new PreparedLasFile(final, stage, expectedFinalFingerprint);
        }

        /// <summary>
        /// Publishes once. A changed destination is rejected under the output lock;
        /// the staged file remains available for an explicit recovery decision.
        /// Cancellation is deliberately not checked in this commit step.
        /// </summary>
        public void Publish()
        {
            if (_disposed) throw new ObjectDisposedException("PreparedLasFile");
            if (_published) throw new InvalidOperationException("The LAS file has already been published.");
            if(_sourceValidation!=null)_sourceValidation();
            ValidateStageName(_finalPath, _stagePath);
            ValidateStage(_stagePath);
            using (AcquireOutputLock(_finalPath))
            {
                string actual = Fingerprint(_finalPath);
                if (!String.Equals(actual, _expectedFinalFingerprint, StringComparison.Ordinal))
                    throw new IOException("The destination LAS file changed after export preparation.");

                if (actual == "missing")
                    File.Move(_stagePath, _finalPath);
                else
                    File.Replace(_stagePath, _finalPath, null);

                _published = true;
            }
        }

        /// <summary>
        /// Retains an unpublished stage after Dispose so a persisted journal can
        /// reopen it with OpenForRecovery. The caller owns later cleanup.
        /// </summary>
        public void PreserveForRecovery()
        {
            if (_disposed) throw new ObjectDisposedException("PreparedLasFile");
            _preserveForRecovery = true;
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            try
            {if (!_published && !_preserveForRecovery)DeleteStageIfPresent(_stagePath);}
            finally
            {if(_sourceLease!=null)_sourceLease.Dispose();_sourceLease=null;_sourceValidation=null;}
        }

        internal static string CreateStagePath(string finalPath)
        {
            string final = Path.GetFullPath(finalPath);
            string directory = Path.GetDirectoryName(final);
            if (String.IsNullOrEmpty(directory) || !Directory.Exists(directory))
                throw new DirectoryNotFoundException("The LAS destination directory does not exist.");
            return final + "." + Guid.NewGuid().ToString("N") + ".tmp";
        }

        internal static string CaptureExpectedFinal(string finalPath)
        {
            string final = Path.GetFullPath(finalPath);
            using (AcquireOutputLock(final))
                return Fingerprint(final);
        }

        internal static void DeleteStageIfPresent(string stagePath)
        {
            if (File.Exists(stagePath)) File.Delete(stagePath);
        }

        internal static void ValidateStage(string stagePath)
        {
            using (FileStream stream = new FileStream(stagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                if (stream.Length < HeaderSize)
                    throw new InvalidDataException("LAS staging file is shorter than its header.");
                byte[] header = new byte[HeaderSize];
                int read = 0;
                while (read < header.Length)
                {
                    int count = stream.Read(header, read, header.Length - read);
                    if (count == 0) throw new EndOfStreamException("LAS staging header is incomplete.");
                    read += count;
                }
                if (header[0] != 'L' || header[1] != 'A' || header[2] != 'S' || header[3] != 'F' ||
                    header[24] != 1 || header[25] != 2 ||
                    BitConverter.ToUInt16(header, 94) != HeaderSize ||
                    BitConverter.ToUInt32(header, 96) != HeaderSize ||
                    !((header[104] == 1 && BitConverter.ToUInt16(header,105) == PointRecordSize) ||
                      (header[104] == 3 && BitConverter.ToUInt16(header,105) == 34)))
                    throw new InvalidDataException("LAS staging header does not match version 1.2 point format 1 or RGB format 3.");

                uint pointCount = BitConverter.ToUInt32(header, 107);
                if (stream.Length != HeaderSize + (long)pointCount * BitConverter.ToUInt16(header,105))
                    throw new InvalidDataException("LAS staging file length does not match its point count.");
                for (int i = 0; i < 3; i++)
                {
                    double scale = BitConverter.ToDouble(header, 131 + i * 8);
                    double offset = BitConverter.ToDouble(header, 155 + i * 8);
                    double max = BitConverter.ToDouble(header, 179 + i * 16);
                    double min = BitConverter.ToDouble(header, 187 + i * 16);
                    if (!Finite(scale) || scale <= 0 || !Finite(offset) ||
                        !Finite(max) || !Finite(min) || min > max ||
                        (pointCount == 0 && (offset != 0 || min != 0 || max != 0)))
                        throw new InvalidDataException("LAS staging coordinate metadata is invalid.");
                }
            }
        }

        // LAS stores each coordinate as a signed 32-bit integer. Keep the
        // historical precision when it fits, and enlarge only the axis whose
        // world-coordinate span would overflow that field.
        internal static double CoordinateScale(double minimum, double maximum)
        {
            if (!Finite(minimum) || !Finite(maximum) || maximum < minimum)
                throw new InvalidDataException("LAS coordinate bounds are invalid.");
            double span = maximum - minimum;
            if (!Finite(span))
                throw new InvalidDataException("LAS coordinate span is not representable.");
            double scale = DefaultCoordinateScale;
            while (Math.Round(span / scale) > Int32.MaxValue)
            {
                scale *= 10.0;
                if (!Finite(scale))
                    throw new InvalidDataException("LAS coordinate scale is not representable.");
            }
            return scale;
        }

        private static bool Finite(double value)
        {
            return !Double.IsNaN(value) && !Double.IsInfinity(value);
        }

        private static void ValidateStageName(string finalPath, string stagePath)
        {
            if (!stagePath.StartsWith(finalPath + ".", StringComparison.OrdinalIgnoreCase) ||
                !stagePath.EndsWith(".tmp", StringComparison.OrdinalIgnoreCase) ||
                !String.Equals(Path.GetDirectoryName(stagePath), Path.GetDirectoryName(finalPath),
                    StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("The LAS stage must be a sibling of its destination.", "stagePath");
        }

        private static void ValidateFingerprint(string fingerprint)
        {
            if (fingerprint == "missing") return;
            if (fingerprint == null || fingerprint.Length != 71 ||
                !fingerprint.StartsWith("sha256:", StringComparison.Ordinal))
                throw new ArgumentException("Invalid destination fingerprint.", "fingerprint");
            for (int i = 7; i < fingerprint.Length; i++)
            {
                char c = fingerprint[i];
                if (!((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f')))
                    throw new ArgumentException("Invalid destination fingerprint.", "fingerprint");
            }
        }

        private static string Fingerprint(string path)
        {
            if (!File.Exists(path)) return "missing";
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(stream);
                StringBuilder result = new StringBuilder(71);
                result.Append("sha256:");
                foreach (byte value in hash) result.Append(value.ToString("x2"));
                return result.ToString();
            }
        }

        private static FileStream AcquireOutputLock(string finalPath)
        {
            string lockPath = finalPath + ".lock";
            IOException lastError = null;
            for (int attempt = 0; attempt < 80; attempt++)
            {
                try { return new FileStream(lockPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
                catch (IOException ex) { lastError = ex; Thread.Sleep(25); }
            }
            throw new IOException("Could not acquire the LAS output lock: " + lockPath, lastError);
        }
    }
}
