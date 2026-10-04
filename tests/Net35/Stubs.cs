// Test-only type shims, NOT a substitute for a Topomatic integration build.
namespace Topomatic.Cad.Foundation
{
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }
}
namespace LAS_TERRAIN.Configuration
{
    internal static class RuntimeConfig
    {
        public static double SplitMergeTolerance = 0.01;
    }
}
