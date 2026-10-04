using System;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Filters
{
    // The snapshot tests call the explicit RobustGroundSplineFilter overload.
    // Its legacy overload references FilterAggregator, which is not compiled
    // into the .NET 3.5 source-level test assembly.
    internal static class FilterAggregator
    {
        internal static FilterOperationSnapshot CaptureOperationSnapshot()
        {
            throw new NotSupportedException("Use the explicit snapshot overload in these tests.");
        }
    }
}
