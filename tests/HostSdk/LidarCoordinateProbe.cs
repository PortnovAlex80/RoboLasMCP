using System;
using System.Diagnostics;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

// Read-only check against the installed Rail 16 SDK and an existing LDR.
// The plugin receives these indexers after Topomatic imports a LAS file.
internal static class LidarCoordinateProbe
{
    private sealed class Bounds
    {
        internal long Count;
        internal double MinX = Double.PositiveInfinity, MaxX = Double.NegativeInfinity;
        internal double MinY = Double.PositiveInfinity, MaxY = Double.NegativeInfinity;
        internal double MinZ = Double.PositiveInfinity, MaxZ = Double.NegativeInfinity;
        internal ulong HashSum, HashSquareSum;

        private static ulong PointHash(double x, double y, double z)
        {
            unchecked
            {
                ulong hash = 1469598103934665603UL;
                hash = (hash ^ (ulong)BitConverter.DoubleToInt64Bits(x)) * 1099511628211UL;
                hash = (hash ^ (ulong)BitConverter.DoubleToInt64Bits(y)) * 1099511628211UL;
                return (hash ^ (ulong)BitConverter.DoubleToInt64Bits(z)) * 1099511628211UL;
            }
        }

        internal void Add(double x, double y, double z)
        {
            if (Double.IsNaN(x) || Double.IsInfinity(x) ||
                Double.IsNaN(y) || Double.IsInfinity(y) ||
                Double.IsNaN(z) || Double.IsInfinity(z))
                throw new InvalidOperationException("The LDR contains a non-finite world coordinate.");
            Count++;
            if (x < MinX) MinX = x;
            if (x > MaxX) MaxX = x;
            if (y < MinY) MinY = y;
            if (y > MaxY) MaxY = y;
            if (z < MinZ) MinZ = z;
            if (z > MaxZ) MaxZ = z;
            unchecked
            {
                ulong hash = PointHash(x, y, z);
                HashSum += hash;
                HashSquareSum += hash * hash;
            }
        }
    }

    private static void Same(double actual, double expected, string label)
    {
        if (Math.Abs(actual - expected) > 0.000001)
            throw new InvalidOperationException(label + " differs: " + actual + " vs " + expected);
    }

    private static int Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.Error.WriteLine("Usage: LidarCoordinateProbe <existing-file.ldr>");
            return 2;
        }
        try
        {
            Stopwatch watch = Stopwatch.StartNew();
            LidarCacheHeader header = LidarCacheHeader.Inspect(args[0]);
            Console.WriteLine("cache_status={0} version={1} read_error={2}",
                header.Status, header.Version, header.ReadError);
            if (header.ReadError != null || !header.Version.HasValue)
                throw new InvalidOperationException("Expected a readable LDAR header.");
            using (LidarBuffer buffer = new LidarBuffer())
            {
                buffer.LoadFromFile(args[0]);
                Bounds direct = new Bounds();
                for (int n = 0; n < buffer.indexers.Length; n++)
                {
                    QuadTreeIndexer indexer = buffer.indexers[n];
                    Vector3F[] points = indexer.points.GetBuffer();
                    Console.WriteLine("indexer={0} count={1} scale={2} position={3}",
                        n, indexer.points.Count, indexer.scale, indexer.position);
                    Console.WriteLine("weights_count={0} rgb_byte_count={1}",
                        indexer.weights == null ? 0 : indexer.weights.Count,
                        indexer.clrs == null ? 0 : indexer.clrs.Count);
                    for (int i = 0; i < indexer.points.Count; i++)
                    {
                        Vector3F p = points[i];
                        direct.Add(p.X * indexer.scale.X + indexer.position.X,
                            p.Y * indexer.scale.Y + indexer.position.Y,
                            p.Z * indexer.scale.Z + indexer.position.Z);
                    }
                }
                if (direct.Count == 0)
                {
                    Console.WriteLine("PASS empty LDR");
                    return 0;
                }
                Bounds queried = new Bounds();
                BoundingBox2D query = new BoundingBox2D(
                    new Vector2D(direct.MinX - 1, direct.MinY - 1),
                    new Vector2D(direct.MaxX + 1, direct.MaxY + 1));
                buffer.FindPoints(query, delegate(Vector4D p)
                {
                    queried.Add(p.X, p.Y, p.Z);
                });
                if (direct.Count != queried.Count)
                    throw new InvalidOperationException("Direct and FindPoints counts differ: " +
                        direct.Count + " vs " + queried.Count);
                if (direct.HashSum != queried.HashSum ||
                    direct.HashSquareSum != queried.HashSquareSum)
                    throw new InvalidOperationException("Direct and FindPoints coordinate fingerprints differ.");
                Same(queried.MinX, direct.MinX, "minimum X");
                Same(queried.MaxX, direct.MaxX, "maximum X");
                Same(queried.MinY, direct.MinY, "minimum Y");
                Same(queried.MaxY, direct.MaxY, "maximum Y");
                Same(queried.MinZ, direct.MinZ, "minimum Z");
                Same(queried.MaxZ, direct.MaxZ, "maximum Z");
                watch.Stop();
                Console.WriteLine("PASS count={0} X=[{1:R},{2:R}] Y=[{3:R},{4:R}] Z=[{5:R},{6:R}] fingerprint={7:X16}-{8:X16} elapsed_ms={9} peak_working_set_bytes={10}",
                    direct.Count, direct.MinX, direct.MaxX, direct.MinY, direct.MaxY,
                    direct.MinZ, direct.MaxZ, direct.HashSum, direct.HashSquareSum,
                    watch.ElapsedMilliseconds,
                    Process.GetCurrentProcess().PeakWorkingSet64);
            }
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
    }
}
