using System;
using System.Collections.Generic;
using LAS_TERRAIN.Domain.Service;
using Topomatic.Cad.Foundation;
using Topomatic.Sfc;

namespace LAS_TERRAIN.Tests.HostSdk
{
    internal static class SurfaceProbe
    {
        private static int Main()
        {
            try
            {
                Surface surface = new Surface();
                int original = surface.Points.Count;
                bool dynamic = surface.Style.Dynamic;
                Console.WriteLine("surface-created count=" + original + " dynamic=" + dynamic);
                Console.WriteLine("transaction-manager=" +
                    (surface.TransactionManager == null ? "null" : "present"));

                surface.Style.Dynamic = false;
                surface.Points.Add(new SurfacePoint(new Vector3D(1, 2, 3)));
                surface.PointIndexer.Invalidate();
                surface.Style.Dynamic = dynamic;
                surface.BeginUpdate();
                surface.EndUpdate();
                if (surface.Points.Count != original + 1)
                    throw new InvalidOperationException("Point append did not complete.");
                surface.Points.RemoveAt(surface.Points.Count - 1);
                surface.PointIndexer.Invalidate();
                if (surface.Points.Count != original)
                    throw new InvalidOperationException("Tail removal did not restore the count.");
                Console.WriteLine("PASS actual SDK append, notification, and tail removal");

                FastSurfaceBuilder.InsertPoints(new List<Vector3D>
                {
                    new Vector3D(-10, 5, 7),
                    new Vector3D(-9, 6, 8)
                }, surface);
                if (surface.Points.Count != original + 2 || surface.Style.Dynamic != dynamic)
                    throw new InvalidOperationException("Production builder did not preserve surface state.");
                Console.WriteLine("PASS production FastSurfaceBuilder against actual SDK Surface");
                return 0;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error.ToString());
                return 1;
            }
        }
    }
}
