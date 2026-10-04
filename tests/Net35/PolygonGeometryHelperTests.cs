using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Tests
{
    internal static class PolygonGeometryHelperTests
    {
        private static int _checks;

        public static int Main()
        {
            try
            {
                List<Vector2D> square = new List<Vector2D> {
                    new Vector2D(0, 0), new Vector2D(10, 0),
                    new Vector2D(10, 10), new Vector2D(0, 10)
                };
                CheckBoth(square, 5, 5, true, "interior");
                CheckBoth(square, 0, 5, true, "left edge");
                CheckBoth(square, 5, 0, true, "bottom edge");
                CheckBoth(square, 10, 5, false, "right edge");
                CheckBoth(square, 5, 10, false, "top edge");
                CheckBoth(square, -0.001, 5, false, "left exterior");
                CheckBoth(square, 10.001, 5, false, "right exterior");

                List<Vector2D> reversed = new List<Vector2D>(square);
                reversed.Reverse();
                CheckBoth(reversed, 5, 5, true, "reverse winding interior");
                CheckBoth(reversed, 0, 5, true, "reverse winding left edge");
                CheckBoth(reversed, 10, 5, false, "reverse winding right edge");

                List<Vector2D> closed = new List<Vector2D>(square);
                closed.Add(square[0]);
                CheckBoth(closed, 5, 5, true, "repeated closing point");
                CheckBoth(closed, 5, 10, false, "repeated closing top edge");

                List<Vector2D> concave = new List<Vector2D> {
                    new Vector2D(0, 0), new Vector2D(4, 0),
                    new Vector2D(4, 4), new Vector2D(3, 4),
                    new Vector2D(3, 1), new Vector2D(1, 1),
                    new Vector2D(1, 4), new Vector2D(0, 4)
                };
                CheckBoth(concave, 0.5, 2, true, "concave arm");
                CheckBoth(concave, 2, 2, false, "concave notch");

                CheckBoth(null, 5, 5, false, "null polygon");
                CheckBoth(new List<Vector2D>(), 5, 5, false, "empty polygon");
                CheckBoth(square.GetRange(0, 2), 5, 5, false, "two-point polygon");
                CheckBoth(new List<Vector2D> {
                    new Vector2D(0, 0), new Vector2D(5, 0),
                    new Vector2D(10, 0)
                }, 5, 0, false, "collinear polygon");

                Console.WriteLine("PASS PolygonGeometry helper: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL PolygonGeometry helper: " + ex);
                return 1;
            }
        }

        private static void CheckBoth(List<Vector2D> polygon, double x, double y,
            bool expected, string name)
        {
            Check(PolygonGeometry.Contains(x, y, polygon) == expected,
                name + " (coordinates)");
            Check(PolygonGeometry.Contains(new Vector2D(x, y), polygon) == expected,
                name + " (point)");
        }

        private static void Check(bool condition, string name)
        {
            if (!condition) throw new Exception(name);
            _checks++;
        }
    }
}
