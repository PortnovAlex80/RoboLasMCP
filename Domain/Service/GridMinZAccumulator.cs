using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Service
{
    /// <summary>
    /// Keeps the first point with the minimum Z in each integer grid cell.
    /// Callers own synchronization and merge local accumulators in their
    /// existing traversal order.
    /// </summary>
    internal sealed class GridMinZAccumulator
    {
        private readonly double _originX;
        private readonly double _originY;
        private readonly double _step;
        private readonly Dictionary<GridCellIndex, Vector3D> _cells;

        internal GridMinZAccumulator(double originX, double originY,
            double step, int capacity)
        {
            _originX = originX;
            _originY = originY;
            _step = step;
            _cells = new Dictionary<GridCellIndex, Vector3D>(capacity);
        }

        internal void Add(double x, double y, double z)
        {
            int ix = (int)Math.Floor((x - _originX) / _step);
            int iy = (int)Math.Floor((y - _originY) / _step);
            PutLower(new GridCellIndex(ix, iy), new Vector3D(x, y, z));
        }

        internal void Merge(GridMinZAccumulator other)
        {
            foreach (KeyValuePair<GridCellIndex, Vector3D> entry in other._cells)
                PutLower(entry.Key, entry.Value);
        }

        internal List<Vector3D> ToList()
        {
            return new List<Vector3D>(_cells.Values);
        }

        private void PutLower(GridCellIndex key, Vector3D candidate)
        {
            Vector3D current;
            if (!_cells.TryGetValue(key, out current) || candidate.Z < current.Z)
                _cells[key] = candidate;
        }
    }
}
