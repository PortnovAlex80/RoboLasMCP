namespace LAS_TERRAIN.Domain.Service
{
    internal struct GridCellIndex
    {
        public readonly int X;
        public readonly int Y;
        public GridCellIndex(int x, int y) { X = x; Y = y; }

        public override bool Equals(object obj)
        {
            if (!(obj is GridCellIndex)) return false;
            var o = (GridCellIndex)obj;
            return X == o.X && Y == o.Y;
        }

        public override int GetHashCode()
        {
            unchecked { return (X * 397) ^ Y; }
        }
    }
}
