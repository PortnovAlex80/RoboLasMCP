using System;
using LAS_TERRAIN.Service;
using LAS_TERRAIN.Infrastructure;

internal static class SectionDensityTests
{
    private struct OldPoint { public double W; }
    private struct NewPoint { public double Weight; }
    private static int checks;
    private static void Check(bool value, string label) { checks++; if (!value) throw new Exception(label); }
    private static bool Near(double a, double b) { return Math.Abs(a-b) < 1e-9; }
    private static void Reject(Action action, string label)
    { bool rejected = false; try { action(); } catch (ArgumentException) { rejected = true; } Check(rejected, label); }
    public static int Main()
    {
        var a = new SectionDensityAccumulator(1);
        foreach (double x in new double[] {-2, -1.8, 0.2, 2}) a.Add(x);
        var r = a.Finish(-2, 2);
        Check(r.PointCount == 4 && r.Bins.Count == 4, "full count/domain");
        Check(r.Bins[0].Count == 2 && r.Bins[1].Count == 0 && r.Bins[2].Count == 1 && r.Bins[3].Count == 1, "signed bins and closed upper endpoint");
        Check(r.EmptyBins == 1 && r.LongestEmptyRun == 1 && Near(r.OccupiedBinFraction, .75), "coverage");
        Check(Near(r.PointsPerMeter.Value, 1) && Near(r.DomainPointsPerMeter.Value, 1), "axis density");
        Check(Near(r.MeanAdjacentSpacing.Value, 4.0/3), "adjacent spacing");
        var empty = new SectionDensityAccumulator(1).Finish(-2, 2);
        Check(empty.PointCount == 0 && empty.Bins.Count == 4 && empty.EmptyBins == 4 && empty.LongestEmptyRun == 4, "empty cloud retains requested domain");
        Check(empty.Minimum == null && empty.PointsPerMeter == null && empty.DomainPointsPerMeter == 0, "empty values finite/null");
        var none = new SectionDensityAccumulator(1).Finish(null, null);
        Check(none.Bins.Count == 0, "no observed elevation domain");
        var duplicates = new SectionDensityAccumulator(1); duplicates.Add(5); duplicates.Add(5);
        var duplicateResult = duplicates.Finish(null,null);
        Check(duplicateResult.PointsPerMeter == null && duplicateResult.MeanAdjacentSpacing == 0 && duplicateResult.Bins[0].Count == 2, "duplicate projection preserved");
        var edge = new SectionDensityAccumulator(1); edge.Add(-.25); edge.Add(.25);
        var e = edge.Finish(-.25,.25);
        Check(e.Bins.Count == 2 && Near(e.Bins[0].PointsPerMeter,4) && Near(e.Bins[1].PointsPerMeter,4), "clipped bins normalized by real width");
        Check(Near(e.DomainPointsPerMeter.Value,4), "slice thickness normalization");
        Reject(delegate { new SectionDensityAccumulator(0); }, "zero bin");
        Reject(delegate { new SectionDensityAccumulator(double.NaN); }, "NaN bin");
        Reject(delegate { a.Add(double.PositiveInfinity); }, "infinite coordinate");
        Reject(delegate { a.Finish(-2,10000); }, "domain cap");
        Reject(delegate { new SectionDensityAccumulator(1e-20).Add(1); }, "integer cast guard");
        Check(Near(NativeLidarPointAdapter.Weight(new OldPoint { W=.4 }), .4), "old SDK W");
        Check(Near(NativeLidarPointAdapter.Weight(new NewPoint { Weight=.7 }), .7), "current SDK Weight");
        Console.WriteLine("PASS " + checks + " section density/native SDK checks"); return 0;
    }
}
