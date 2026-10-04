namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public readonly double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }

    public struct Vector3D
    {
        public readonly double X, Y, Z;
        public Vector3D(double x, double y, double z)
        { X = x; Y = y; Z = z; }
    }

    public struct BoundingBox2D
    {
        public readonly Vector2D Min, Max;
        public BoundingBox2D(Vector2D min, Vector2D max)
        { Min = min; Max = max; }
    }
}
