using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class CrsScopedSectionAssociationTests
    {
        private delegate void TestAction();
        private static int checks;
        private static void Check(bool yes, string label)
        {
            checks++;
            if (!yes) throw new Exception(label);
        }
        private static void Throws<T>(TestAction action, string label)
            where T : Exception
        {
            bool caught = false;
            try { action(); }
            catch (T) { caught = true; }
            Check(caught, label);
        }
        private static ScopedPolygonRecord Crs(uint id, double station)
        {
            return ScopedPolygonRecord.Crs(DateTime.UtcNow,
                new List<Vector2D> { new Vector2D(0, 0) }, id, station, 0.5);
        }
        private static bool Resolve(ScopedPolygonRecord record, uint[] ids,
            double[] stations, out int index)
        {
            return CrsScopedSectionAssociation.TryResolve(record, ids.Length,
                delegate(int i) { return ids[i]; },
                delegate(int i) { return stations[i]; }, out index);
        }

        public static int Main()
        {
            int index;
            ScopedPolygonRecord polygon = Crs(10, 5.0);
            Check(Resolve(polygon, new uint[] { 20, 10 },
                new double[] { 4, 5 }, out index) && index == 1,
                "reordered section retains identity");
            Check(Resolve(polygon, new uint[] { 10, 20 },
                new double[] { 5, 4 }, out index) && index == 0,
                "original order resolves");
            Check(!Resolve(polygon, new uint[] { 20 },
                new double[] { 5 }, out index) && index == -1,
                "same station with different ID rejected");
            Check(!Resolve(polygon, new uint[] { 10, 10 },
                new double[] { 5, 5 }, out index) && index == -1,
                "duplicate current ID rejected");
            Check(!Resolve(polygon, new uint[] { 10 },
                new double[] { 5.000002 }, out index) && index == -1,
                "moved station rejected");
            Check(Resolve(polygon, new uint[] { 10 },
                new double[] { 5.0000005 }, out index) && index == 0,
                "serialization roundoff accepted");
            Check(!Resolve(polygon, new uint[0],
                new double[0], out index) && index == -1,
                "missing section rejected");
            Check(!Resolve(polygon, new uint[] { 10 },
                new double[] { Double.NaN }, out index) && index == -1,
                "non-finite current station rejected");
            ScopedPolygonRecord plan = ScopedPolygonRecord.Plan(DateTime.UtcNow,
                new List<Vector2D> { new Vector2D(0, 0) });
            Throws<ArgumentException>(delegate {
                Resolve(plan, new uint[] { 10 }, new double[] { 5 }, out index);
            }, "Plan record rejected");
            Throws<ArgumentNullException>(delegate {
                CrsScopedSectionAssociation.TryResolve(null, 1,
                    delegate(int i) { return 10; },
                    delegate(int i) { return 5; }, out index);
            }, "null record rejected");
            Throws<ArgumentOutOfRangeException>(delegate {
                CrsScopedSectionAssociation.TryResolve(polygon, -1,
                    delegate(int i) { return 10; },
                    delegate(int i) { return 5; }, out index);
            }, "negative section count rejected");
            Console.WriteLine("CrsScopedSectionAssociation: " + checks + " checks passed");
            return 0;
        }
    }
}
