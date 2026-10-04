using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace RoboLasInstaller
{
    // Strict reader for the ZIP subset emitted by build/package.ps1. ZIP64,
    // encryption, descriptors, split archives, and ambiguous names fail closed.
    internal sealed class PackageArchive : IDisposable
    {
        internal sealed class Entry
        {
            internal string Name;
            internal int Method;
            internal uint Crc;
            internal int CompressedSize;
            internal int Size;
            internal int DataOffset;
            internal int LocalOffset;
            internal int EndOffset;
        }

        private readonly byte[] bytes;
        private readonly List<Entry> entries = new List<Entry>();
        internal IList<Entry> Entries { get { return entries.AsReadOnly(); } }

        internal PackageArchive(string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                if (file.Length > 256 * 1024 * 1024 || file.Length < 22)
                    throw new InvalidDataException("Unsupported package size.");
                bytes = new byte[(int)file.Length];
                int offset = 0;
                while (offset < bytes.Length)
                {
                    int count = file.Read(bytes, offset, bytes.Length - offset);
                    if (count == 0) throw new InvalidDataException("Truncated package.");
                    offset += count;
                }
            }
            Parse();
        }

        private ushort U16(int p)
        {
            if (p < 0 || p > bytes.Length - 2) throw new InvalidDataException("Truncated ZIP header.");
            return (ushort)(bytes[p] | bytes[p + 1] << 8);
        }

        private uint U32(int p)
        {
            return (uint)(U16(p) | (uint)U16(p + 2) << 16);
        }

        private static int Int32(uint value)
        {
            if (value > int.MaxValue) throw new InvalidDataException("ZIP64 or oversized entry is unsupported.");
            return (int)value;
        }

        private string Name(int offset, int length)
        {
            if (length == 0 || offset < 0 || offset > bytes.Length - length)
                throw new InvalidDataException("Invalid ZIP entry name.");
            for (int i = offset; i < offset + length; i++)
                if (bytes[i] < 0x20 || bytes[i] > 0x7e)
                    throw new InvalidDataException("Non-ASCII package path is unsupported.");
            return Encoding.ASCII.GetString(bytes, offset, length);
        }

        private void Parse()
        {
            int eocd = bytes.Length - 22;
            if (U32(eocd) != 0x06054b50 || U16(eocd + 4) != 0 || U16(eocd + 6) != 0 ||
                U16(eocd + 8) != U16(eocd + 10) || U16(eocd + 20) != 0)
                throw new InvalidDataException("Unsupported ZIP end record.");
            int count = U16(eocd + 10);
            if (count == 0 || count > 4096) throw new InvalidDataException("Invalid ZIP entry count.");
            int centralSize = Int32(U32(eocd + 12));
            int centralStart = Int32(U32(eocd + 16));
            if ((long)centralStart + centralSize != eocd)
                throw new InvalidDataException("Invalid ZIP central directory.");
            int p = centralStart;
            HashSet<string> names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            long totalSize = 0;
            for (int i = 0; i < count; i++)
            {
                if (p > eocd - 46 || U32(p) != 0x02014b50)
                    throw new InvalidDataException("Invalid ZIP central entry.");
                int flags = U16(p + 8);
                int method = U16(p + 10);
                if ((flags != 0 && flags != 0x800) || (method != 0 && method != 8) ||
                    U16(p + 6) > 20 || U16(p + 34) != 0 || U16(p + 36) != 0 || U32(p + 38) != 0)
                    throw new InvalidDataException("Unsupported ZIP entry options.");
                int compressed = Int32(U32(p + 20));
                int size = Int32(U32(p + 24));
                if (size > 128 * 1024 * 1024 || (totalSize += size) > 1024L * 1024 * 1024)
                    throw new InvalidDataException("Package expansion limit exceeded.");
                int nameLength = U16(p + 28);
                int extraLength = U16(p + 30);
                int commentLength = U16(p + 32);
                long next = (long)p + 46 + nameLength + extraLength + commentLength;
                if (extraLength != 0 || commentLength != 0 || next > eocd)
                    throw new InvalidDataException("Unsupported ZIP central metadata.");
                string name = Name(p + 46, nameLength);
                if (!names.Add(name)) throw new InvalidDataException("Duplicate ZIP entry: " + name);
                int local = Int32(U32(p + 42));
                if (local > centralStart - 30 || U32(local) != 0x04034b50 ||
                    U16(local + 4) != U16(p + 6) ||
                    U16(local + 6) != flags || U16(local + 8) != method ||
                    U32(local + 14) != U32(p + 16) || U32(local + 18) != U32(p + 20) ||
                    U32(local + 22) != U32(p + 24) || U16(local + 26) != nameLength ||
                    U16(local + 28) != 0)
                    throw new InvalidDataException("ZIP local header differs from central directory.");
                int localName = local + 30;
                if (Name(localName, nameLength) != name)
                    throw new InvalidDataException("ZIP local name differs from central directory.");
                long data = (long)localName + nameLength;
                long end = data + compressed;
                if (end > centralStart || (name.EndsWith("/", StringComparison.Ordinal) && size != 0))
                    throw new InvalidDataException("ZIP entry overlaps central directory.");
                Entry entry = new Entry();
                entry.Name = name;
                entry.Method = method;
                entry.Crc = U32(p + 16);
                entry.CompressedSize = compressed;
                entry.Size = size;
                entry.DataOffset = (int)data;
                entry.LocalOffset = local;
                entry.EndOffset = (int)end;
                entries.Add(entry);
                p = (int)next;
            }
            if (p != eocd) throw new InvalidDataException("Unexpected ZIP central data.");
            List<Entry> ordered = new List<Entry>(entries);
            ordered.Sort(delegate(Entry a, Entry b) { return a.LocalOffset.CompareTo(b.LocalOffset); });
            int cursor = 0;
            foreach (Entry entry in ordered)
            {
                if (entry.LocalOffset != cursor)
                    throw new InvalidDataException("Unexpected or overlapping ZIP local data.");
                cursor = entry.EndOffset;
            }
            if (cursor != centralStart)
                throw new InvalidDataException("Unexpected data before ZIP central directory.");
        }

        internal void ValidateAll()
        {
            foreach (Entry entry in entries) ReadEntry(entry, Stream.Null);
        }

        internal void ExtractValidated(Entry entry, string destination)
        {
            using (FileStream output = new FileStream(destination, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                ReadEntry(entry, output);
        }

        private void ReadEntry(Entry entry, Stream output)
        {
            using (MemoryStream compressed = new MemoryStream(bytes, entry.DataOffset, entry.CompressedSize, false))
            {
                Stream source = compressed;
                if (entry.Method == 8) source = new DeflateStream(compressed, CompressionMode.Decompress);
                using (source)
                {
                    byte[] buffer = new byte[8192];
                    uint crc = 0xffffffff;
                    int total = 0;
                    int read;
                    while ((read = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (read > entry.Size - total)
                            throw new InvalidDataException("ZIP entry exceeds declared size: " + entry.Name);
                        total += read;
                        for (int i = 0; i < read; i++)
                        {
                            crc ^= buffer[i];
                            for (int bit = 0; bit < 8; bit++)
                                crc = (crc >> 1) ^ ((crc & 1) != 0 ? 0xedb88320u : 0u);
                        }
                        output.Write(buffer, 0, read);
                    }
                    if (total != entry.Size || (crc ^ 0xffffffff) != entry.Crc ||
                        (entry.Method == 0 && entry.CompressedSize != entry.Size))
                        throw new InvalidDataException("ZIP entry CRC or size mismatch: " + entry.Name);
                }
            }
        }

        public void Dispose() { }
    }
}
