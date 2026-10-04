using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class GridFeatureDetectorTests
    {
        private static int _checks;

        private static void Check(bool condition, string reason)
        {
            _checks++;
            if (!condition) throw new Exception(reason);
        }

        private static List<Vector3D> Profile(bool valley)
        {
            List<Vector3D> points = new List<Vector3D>();
            for (int x = 0; x < 9; x++)
                points.Add(new Vector3D(x, 0, x == 4 ? (valley ? -4 : 4) : 0));
            return points;
        }

        private static List<Vector3D> Detect(List<Vector3D> points, double minX,
            double maxX, GridFeatureDetector.Mode mode)
        {
            return GridFeatureDetector.DetectFeatures(points,
                new BoundingBox2D(new Vector2D(minX, -1),
                    new Vector2D(maxX, 1)),
                1.0, 1.0, 3.0, 0.2, 0.0, mode);
        }

        private static void Expect(List<Vector3D> actual, string name,
            params int[] xAndZ)
        {
            Check(actual.Count * 2 == xAndZ.Length, name + " count");
            for (int i = 0; i < actual.Count; i++)
                Check(actual[i].X == xAndZ[i * 2] && actual[i].Y == 0 &&
                    actual[i].Z == xAndZ[i * 2 + 1],
                    name + " ordered XYZ at " + i);
        }

        private static void GoldenProfiles()
        {
            List<Vector3D> ridge = Profile(false);
            List<Vector3D> valley = Profile(true);
            Expect(Detect(ridge, -1, 9, GridFeatureDetector.Mode.Ridges),
                "ridge/Ridges", 3, 0, 4, 4, 5, 0);
            Expect(Detect(valley, -1, 9, GridFeatureDetector.Mode.Ridges),
                "valley/Ridges", 1, 0, 2, 0, 6, 0, 7, 0);
            Expect(Detect(ridge, -1, 9, GridFeatureDetector.Mode.Valleys),
                "ridge/Valleys", 1, 0, 2, 0, 6, 0, 7, 0);
            Expect(Detect(valley, -1, 9, GridFeatureDetector.Mode.Valleys),
                "valley/Valleys", 3, 0, 4, -4, 5, 0);
            Expect(Detect(ridge, -1, 9, GridFeatureDetector.Mode.Both),
                "ridge/Both", 1, 0, 2, 0, 3, 0, 4, 4, 5, 0, 6, 0, 7, 0);
            Expect(Detect(valley, -1, 9, GridFeatureDetector.Mode.Both),
                "valley/Both", 1, 0, 2, 0, 3, 0, 4, -4, 5, 0, 6, 0, 7, 0);
            Check(ridge[4].Z == 4 && valley[4].Z == -4,
                "feature detection does not mutate input");
        }

        private static void DuplicateAndEmptyCases()
        {
            List<Vector3D> points = new List<Vector3D>();
            for (int x = -4; x <= 4; x++)
                points.Add(new Vector3D(x, 0, x == 0 ? 4 : 0));
            points.Add(new Vector3D(0.1, 0, -1));
            points.Add(new Vector3D(0.2, 0, -1));
            Expect(Detect(points, -5, 5, GridFeatureDetector.Mode.Both),
                "negative cells and minimum duplicate", -3, 0, 3, 0);
            Check(points[9].Z == -1 && points[10].Z == -1,
                "duplicate candidates stay unchanged");

            BoundingBox2D box = new BoundingBox2D(new Vector2D(0, 0),
                new Vector2D(1, 1));
            Check(GridFeatureDetector.DetectFeatures(null, box, 1, 1, 3,
                0.2, 0, GridFeatureDetector.Mode.Both).Count == 0,
                "null points are empty");
            Check(GridFeatureDetector.DetectFeatures(new List<Vector3D>(),
                box, 1, 1, 3, 0.2, 0,
                GridFeatureDetector.Mode.Both).Count == 0,
                "empty points are empty");
            Check(GridFeatureDetector.DetectFeatures(points, box, 0, 1, 3,
                0.2, 0, GridFeatureDetector.Mode.Both).Count == 0,
                "nonpositive step is empty");
        }

        public static int Main()
        {
            GoldenProfiles();
            DuplicateAndEmptyCases();
            Console.WriteLine("GridFeatureDetectorTests: " + _checks + " checks passed");
            return 0;
        }
    }
}
