namespace LAS_TERRAIN.Models
{
    // Captured once before filtering starts. All values used by the standard
    // filter chain are immutable for the lifetime of an operation.
    internal sealed class FilterOperationSnapshot
    {
        internal readonly bool UseSplineFilter;
        internal readonly bool EnableBreakDetection;
        internal readonly double SplitMergeTolerance;

        internal readonly double GraphBinX;
        internal readonly double GraphBinY;
        internal readonly int GraphMinPts;

        internal readonly int BreakSlopeWindow;
        internal readonly int BreakR2Window;
        internal readonly double BreakAngleThreshold;
        internal readonly double BreakMinR2;
        internal readonly int BreakMinSegmentPoints;
        internal readonly int BreakSuppressRadius;

        internal readonly int SplineDegree;
        internal readonly int SplineMaxIterations;
        internal readonly double SplineSigma;
        internal readonly double SplineSmooth;
        internal readonly double SplineGridStep;
        internal readonly double SplineConvergenceTol;
        internal readonly int SplineAutoCtrlMax;
        internal readonly double SplineRidgeEps;
        internal readonly double SplineMaxGapMeters;
        internal readonly bool SplineEnableRailFilter;
        internal readonly double SplineRailFilterWindowMeters;

        internal FilterOperationSnapshot(
            bool useSplineFilter, bool enableBreakDetection, double splitMergeTolerance,
            double graphBinX, double graphBinY, int graphMinPts,
            int breakSlopeWindow, int breakR2Window, double breakAngleThreshold,
            double breakMinR2, int breakMinSegmentPoints, int breakSuppressRadius,
            int splineDegree, int splineMaxIterations, double splineSigma,
            double splineSmooth, double splineGridStep, double splineConvergenceTol,
            int splineAutoCtrlMax, double splineRidgeEps, double splineMaxGapMeters,
            bool splineEnableRailFilter, double splineRailFilterWindowMeters)
        {
            UseSplineFilter = useSplineFilter;
            EnableBreakDetection = enableBreakDetection;
            SplitMergeTolerance = splitMergeTolerance;
            GraphBinX = graphBinX;
            GraphBinY = graphBinY;
            GraphMinPts = graphMinPts;
            BreakSlopeWindow = breakSlopeWindow;
            BreakR2Window = breakR2Window;
            BreakAngleThreshold = breakAngleThreshold;
            BreakMinR2 = breakMinR2;
            BreakMinSegmentPoints = breakMinSegmentPoints;
            BreakSuppressRadius = breakSuppressRadius;
            SplineDegree = splineDegree;
            SplineMaxIterations = splineMaxIterations;
            SplineSigma = splineSigma;
            SplineSmooth = splineSmooth;
            SplineGridStep = splineGridStep;
            SplineConvergenceTol = splineConvergenceTol;
            SplineAutoCtrlMax = splineAutoCtrlMax;
            SplineRidgeEps = splineRidgeEps;
            SplineMaxGapMeters = splineMaxGapMeters;
            SplineEnableRailFilter = splineEnableRailFilter;
            SplineRailFilterWindowMeters = splineRailFilterWindowMeters;
        }
    }
}
