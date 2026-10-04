// tests/Net35/CharacterizationStubs.cs
// Test-only type shims for CharacterizationTests. Companion to Stubs.cs —
// deliberately does NOT redefine Topomatic.Cad.Foundation.Vector2D or
// LAS_TERRAIN.Configuration.RuntimeConfig (those live in Stubs.cs and are
// lead-owned; duplicating them here would be a CS0101 error).
//
// Vector4D layout verified against the decompiled SDK
// (docs/topomatic-sweep/decompiled/Topomatic.Cad.Foundation.cs):
// public struct with fields X, Y, Z and a fourth intensity component used by
// LasSectionPointsCollectorService as `new Vector4D(pt.X, pt.Y, pt.Z, pt.W)`.
namespace Topomatic.Cad.Foundation
{
    public struct Vector4D
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public Vector4D(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
