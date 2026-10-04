using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class GridMinZAccumulatorTests
    {
        private static int _checks;

        private static void Check(bool condition, string message)
        {
            _checks++;
            if (!condition) throw new Exception(message);
        }

        private static void CheckPoint(Vector3D actual, double x, double y,
            double z, string message)
        {
            Check(actual.X == x && actual.Y == y && actual.Z == z, message);
        }

        private static void MinimumAndSignedCells()
        {
            GridMinZAccumulator map = new GridMinZAccumulator(0, 0, 1, 8);
            map.Add(0.1, 0.1, 5);
            map.Add(0.2, 0.2, 2);
            map.Add(0.3, 0.3, 2);
            map.Add(-0.1, -0.1, 9);
            map.Add(-0.2, -0.2, 1);
            map.Add(-1.1, 0.1, 4);
            List<Vector3D> result = map.ToList();
            Check(result.Count == 3, "three distinct signed cells");
            CheckPoint(result[0], 0.2, 0.2, 2,
                "lower Z replaces first and equal Z keeps first minimum");
            CheckPoint(result[1], -0.2, -0.2, 1,
                "negative cell retains its minimum");
            CheckPoint(result[2], -1.1, 0.1, 4,
                "floor separates adjacent negative cells");
            result.Clear();
            Check(map.ToList().Count == 3, "result list does not own cell state");
        }

        private static void MergeKeepsFirstEqualMinimum()
        {
            GridMinZAccumulator first = new GridMinZAccumulator(-10, -10, 1, 8);
            GridMinZAccumulator second = new GridMinZAccumulator(-10, -10, 1, 8);
            first.Add(-9.8, -9.8, 3);
            first.Add(-8.8, -9.8, 6);
            second.Add(-9.7, -9.7, 3);
            second.Add(-8.7, -9.7, 2);
            second.Add(-7.7, -9.7, 4);
            first.Merge(second);
            List<Vector3D> result = first.ToList();
            Check(result.Count == 3, "merge retains three cells");
            CheckPoint(result[0], -9.8, -9.8, 3,
                "first equal minimum across buffers is kept");
            CheckPoint(result[1], -8.7, -9.7, 2,
                "lower second-buffer value replaces first");
            CheckPoint(result[2], -7.7, -9.7, 4,
                "new second-buffer cell follows existing cells");
            Check(second.ToList().Count == 3, "merge leaves local buffer unchanged");
        }

        public static int Main()
        {
            MinimumAndSignedCells();
            MergeKeepsFirstEqualMinimum();
            Console.WriteLine("GridMinZAccumulatorTests: " + _checks + " checks passed");
            return 0;
        }
    }
}
