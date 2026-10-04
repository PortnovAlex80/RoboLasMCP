using System;

namespace LAS_TERRAIN.Domain.Service
{
    // Computes the existing Plan/CRS preview row spacing and rejects ranges
    // where `y += stepY` cannot advance the scanline loop.
    internal static class ScanlineFillPlanner
    {
        internal static bool TryPlan(double minY, double maxY, double rowSpacing,
            out double stepY)
        {
            stepY = 0;
            double height = maxY - minY;
            if (Double.IsNaN(height) || Double.IsInfinity(height) ||
                height < 0.001 || Double.IsNaN(rowSpacing) ||
                Double.IsInfinity(rowSpacing) || rowSpacing <= 0)
                return false;

            int steps = Math.Min(100, Math.Max(20, (int)(height / rowSpacing)));
            stepY = height / steps;
            return stepY > 0 && minY + stepY > minY && maxY + stepY > maxY;
        }
    }
}
