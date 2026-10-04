using System;
using System.Collections.Generic;
using Topomatic.Lidar;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Records the identity and metadata of borrowed LiDAR buffers without
    /// copying point values. Capture and Matches must run on the CAD UI thread.
    /// This detects stale results; it does not lock arrays during a scan.
    /// </summary>
    internal sealed class BorrowedLidarSourceSnapshot
    {
        private readonly List<BufferSnapshot> _buffers;

        private BorrowedLidarSourceSnapshot(IList<LidarBuffer> buffers)
        {
            _buffers = new List<BufferSnapshot>(buffers.Count);
            foreach (LidarBuffer buffer in buffers)
                _buffers.Add(new BufferSnapshot(buffer));
        }

        internal static BorrowedLidarSourceSnapshot Capture(IList<LidarBuffer> buffers)
        {
            return buffers == null ? null : new BorrowedLidarSourceSnapshot(buffers);
        }

        internal bool Matches(IList<LidarBuffer> buffers)
        {
            if (buffers == null || buffers.Count != _buffers.Count) return false;
            for (int i = 0; i < buffers.Count; i++)
                if (!_buffers[i].Matches(buffers[i])) return false;
            return true;
        }

        private static bool SameBits(double current, double captured)
        {
            return BitConverter.DoubleToInt64Bits(current) ==
                BitConverter.DoubleToInt64Bits(captured);
        }

        private sealed class BufferSnapshot
        {
            private readonly LidarBuffer _buffer;
            private readonly string _path;
            private readonly object _indexerArray;
            private readonly List<IndexerSnapshot> _indexers;

            internal BufferSnapshot(LidarBuffer buffer)
            {
                _buffer = buffer;
                _indexers = new List<IndexerSnapshot>();
                if (buffer == null) return;
                _path = buffer.fullpath;
                _indexerArray = buffer.indexers;
                if (buffer.indexers != null)
                    foreach (QuadTreeIndexer indexer in buffer.indexers)
                        _indexers.Add(new IndexerSnapshot(indexer));
            }

            internal bool Matches(LidarBuffer buffer)
            {
                if (!Object.ReferenceEquals(buffer, _buffer)) return false;
                if (buffer == null) return true;
                if (!String.Equals(buffer.fullpath, _path,
                        StringComparison.OrdinalIgnoreCase) ||
                    !Object.ReferenceEquals(buffer.indexers, _indexerArray))
                    return false;
                if (buffer.indexers == null) return _indexers.Count == 0;
                int index = 0;
                foreach (QuadTreeIndexer current in buffer.indexers)
                {
                    if (index >= _indexers.Count || !_indexers[index].Matches(current))
                        return false;
                    index++;
                }
                return index == _indexers.Count;
            }
        }

        private sealed class IndexerSnapshot
        {
            private readonly QuadTreeIndexer _indexer;
            private readonly object _points;
            private readonly object _pointArray;
            private readonly int _pointCount;
            private readonly object _weights;
            private readonly object _weightArray;
            private readonly int _weightCount;
            private readonly int _weightLogicalCount;
            private readonly double _scaleX, _scaleY, _scaleZ;
            private readonly double _positionX, _positionY, _positionZ;

            internal IndexerSnapshot(QuadTreeIndexer indexer)
            {
                _indexer = indexer;
                if (indexer == null) return;
                _points = indexer.points;
                _pointArray = indexer.points == null ? null : indexer.points.GetBuffer();
                _pointCount = indexer.points == null ? 0 : indexer.points.Count;
                _weights = indexer.weights;
                _weightArray = indexer.weights == null ? null : indexer.weights.GetBuffer();
                _weightCount = _weightArray == null ? 0 : ((Array)_weightArray).Length;
                _weightLogicalCount = _weightArray == null ? -1 : indexer.weights.Count;
                _scaleX = indexer.scale.X;
                _scaleY = indexer.scale.Y;
                _scaleZ = indexer.scale.Z;
                _positionX = indexer.position.X;
                _positionY = indexer.position.Y;
                _positionZ = indexer.position.Z;
            }

            internal bool Matches(QuadTreeIndexer indexer)
            {
                if (!Object.ReferenceEquals(indexer, _indexer)) return false;
                if (indexer == null) return true;
                if (!Object.ReferenceEquals(indexer.points, _points) ||
                    !Object.ReferenceEquals(indexer.weights, _weights) ||
                    !SameBits(indexer.scale.X, _scaleX) ||
                    !SameBits(indexer.scale.Y, _scaleY) ||
                    !SameBits(indexer.scale.Z, _scaleZ) ||
                    !SameBits(indexer.position.X, _positionX) ||
                    !SameBits(indexer.position.Y, _positionY) ||
                    !SameBits(indexer.position.Z, _positionZ))
                    return false;

                object points = indexer.points == null ? null : indexer.points.GetBuffer();
                int pointCount = indexer.points == null ? 0 : indexer.points.Count;
                object weights = indexer.weights == null ? null : indexer.weights.GetBuffer();
                int weightCount = weights == null ? 0 : ((Array)weights).Length;
                int weightLogicalCount = weights == null ? -1 : indexer.weights.Count;
                return Object.ReferenceEquals(points, _pointArray) &&
                    pointCount == _pointCount &&
                    Object.ReferenceEquals(weights, _weightArray) &&
                    weightCount == _weightCount &&
                    weightLogicalCount == _weightLogicalCount;
            }
        }
    }
}
