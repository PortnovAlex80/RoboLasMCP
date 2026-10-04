using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;

// Minimal stand-in for the SDK value type. The reflection baseline uses the real SDK.
namespace Topomatic.Cad.Foundation
{
    public struct BoundingBox2D
    {
        public Vector2D Min;
        public Vector2D Max;

        public BoundingBox2D(Vector2D min, Vector2D max)
        {
            Min = min;
            Max = max;
        }

        public void Inflate(double x, double y)
        {
            Min = new Vector2D(Min.X - x, Min.Y - y);
            Max = new Vector2D(Max.X + x, Max.Y + y);
        }
    }
}

namespace LAS_TERRAIN.Tests
{
    internal static class PolygonBoundsHelperTests
    {
        private static int _checks;

        public static int Main()
        {
            try
            {
                CheckEmpty(null, "null collection");
                CheckEmpty(new List<PlanPolygonEntry>(), "empty collection");
                CheckEmpty(new List<PlanPolygonEntry> { Entry() }, "empty polygon");
                CheckEmpty(new List<PlanPolygonEntry> {
                    new PlanPolygonEntry { Polygon = null }, Entry()
                }, "null polygon and empty polygon");

                CheckBounds(new List<PlanPolygonEntry> {
                    Entry(new Vector2D(4, 7))
                }, 3, 6, 5, 8, "one point");
                CheckBounds(new List<PlanPolygonEntry> {
                    Entry(new Vector2D(2, 3), new Vector2D(4, 7))
                }, 1, 2, 5, 8, "two points");
                CheckBounds(new List<PlanPolygonEntry> {
                    Entry(new Vector2D(2, 9), new Vector2D(4, 7)),
                    new PlanPolygonEntry { Polygon = null },
                    Entry(),
                    Entry(new Vector2D(-5, -3), new Vector2D(10, 2))
                }, -6, -4, 11, 10, "union across polygons");

                bool threw = false;
                try
                {
                    BoundingBox2D bounds;
                    PolygonBounds.TryCompute(new List<PlanPolygonEntry> { null }, out bounds);
                }
                catch (NullReferenceException)
                {
                    threw = true;
                }
                Check(threw, "null entry still throws");

                Console.WriteLine("PASS PolygonBounds helper: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL PolygonBounds helper: " + ex);
                return 1;
            }
        }

        private static PlanPolygonEntry Entry(params Vector2D[] points)
        {
            return new PlanPolygonEntry { Polygon = new List<Vector2D>(points) };
        }

        private static void CheckEmpty(List<PlanPolygonEntry> polygons, string name)
        {
            BoundingBox2D bounds;
            Check(!PolygonBounds.TryCompute(polygons, out bounds), name + " result");
            Check(bounds.Min.X == 0 && bounds.Min.Y == 0 &&
                bounds.Max.X == 0 && bounds.Max.Y == 0, name + " default bounds");
        }

        private static void CheckBounds(List<PlanPolygonEntry> polygons,
            double minX, double minY, double maxX, double maxY, string name)
        {
            BoundingBox2D bounds;
            Check(PolygonBounds.TryCompute(polygons, out bounds), name + " result");
            Check(bounds.Min.X == minX && bounds.Min.Y == minY &&
                bounds.Max.X == maxX && bounds.Max.Y == maxY, name + " bounds");
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }
    }
}
