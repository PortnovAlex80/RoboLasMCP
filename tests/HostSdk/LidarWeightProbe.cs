using System;
using Topomatic.Cad.Foundation;
using Topomatic.Lidar;

// Read-only comparison of LDR byte weights with the public FindPoints W value.
internal static class LidarWeightProbe
{
    private static ulong PointHash(double x, double y, double z, byte weight)
    {
        unchecked
        {
            ulong hash = 1469598103934665603UL;
            hash = (hash ^ (ulong)BitConverter.DoubleToInt64Bits(x)) * 1099511628211UL;
            hash = (hash ^ (ulong)BitConverter.DoubleToInt64Bits(y)) * 1099511628211UL;
            hash = (hash ^ (ulong)BitConverter.DoubleToInt64Bits(z)) * 1099511628211UL;
            return (hash ^ weight) * 1099511628211UL;
        }
    }

    private static int Main(string[] args)
    {
        if (args.Length != 1) return 2;
        try
        {
            using (LidarBuffer buffer = new LidarBuffer())
            {
                buffer.LoadFromFile(args[0]);
                int directCount = 0;
                long directWeightSum = 0;
                ulong directHash = 0;
                double minX = Double.PositiveInfinity, minY = Double.PositiveInfinity;
                double maxX = Double.NegativeInfinity, maxY = Double.NegativeInfinity;
                for (int n = 0; n < buffer.indexers.Length; n++)
                {
                    QuadTreeIndexer indexer = buffer.indexers[n];
                    Vector3F[] points = indexer.points.GetBuffer();
                    byte[] weights = indexer.weights == null ? null : indexer.weights.GetBuffer();
                    if (weights == null || indexer.weights.Count < indexer.points.Count ||
                        weights.Length < indexer.points.Count)
                        throw new InvalidOperationException("LDR indexer has no complete weight array.");
                    for (int i = 0; i < indexer.points.Count; i++)
                    {
                        double x = points[i].X * indexer.scale.X + indexer.position.X;
                        double y = points[i].Y * indexer.scale.Y + indexer.position.Y;
                        double z = points[i].Z * indexer.scale.Z + indexer.position.Z;
                        if (x < minX) minX = x;
                        if (x > maxX) maxX = x;
                        if (y < minY) minY = y;
                        if (y > maxY) maxY = y;
                        directWeightSum += weights[i];
                        unchecked { directHash += PointHash(x, y, z, weights[i]); }
                        directCount++;
                        if (directCount <= 8)
                            Console.WriteLine("direct[{0}] XY=({1:R},{2:R}) byte={3}",
                                directCount - 1, x, y, weights[i]);
                    }
                }
                if (directCount == 0) throw new InvalidOperationException("LDR is empty.");
                int queriedCount = 0;
                double queriedWeightSum = 0;
                ulong queriedHash = 0;
                BoundingBox2D box = new BoundingBox2D(
                    new Vector2D(minX - 1, minY - 1),
                    new Vector2D(maxX + 1, maxY + 1));
                buffer.FindPoints(box, delegate(Vector4D point)
                {
                    double byteWeight = point.W * 255.0;
                    if (Math.Abs(byteWeight - Math.Round(byteWeight)) > 1e-8)
                        throw new InvalidOperationException("FindPoints W is not a normalized byte.");
                    queriedWeightSum += Math.Round(byteWeight);
                    unchecked
                    {
                        queriedHash += PointHash(point.X, point.Y, point.Z,
                            (byte)Math.Round(byteWeight));
                    }
                    if (queriedCount < 8)
                        Console.WriteLine("query[{0}] XY=({1:R},{2:R}) W={3:R}",
                            queriedCount, point.X, point.Y, point.W);
                    queriedCount++;
                });
                if (queriedCount != directCount || queriedWeightSum != directWeightSum ||
                    queriedHash != directHash)
                    throw new InvalidOperationException("FindPoints normalized weight tuples differ from byte weights.");
                Console.WriteLine("PASS points={0} byte_weight_sum={1} query_normalized_byte_sum={2:R}",
                    directCount, directWeightSum, queriedWeightSum);
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
