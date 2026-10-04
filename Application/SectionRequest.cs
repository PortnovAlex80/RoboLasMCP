using System;
using LAS_TERRAIN.Models;

namespace LAS_TERRAIN.Application
{
    /// <summary>
    /// Inputs for one calculation. The caller transfers exclusive ownership of
    /// sections and their point lists until Calculate returns. Filter settings
    /// and scalar inputs cannot change during the operation.
    /// </summary>
    internal sealed class SectionRequest
    {
        internal readonly LasSectionPoints[] Sections;
        internal readonly double DefaultOriginOffset;
        internal readonly bool Parallel;
        internal readonly FilterOperationSnapshot FilterSettings;

        internal SectionRequest(LasSectionPoints[] sections, double defaultOriginOffset,
            bool parallel, FilterOperationSnapshot filterSettings)
        {
            if (sections == null) throw new ArgumentNullException("sections");
            if (filterSettings == null) throw new ArgumentNullException("filterSettings");
            if (double.IsNaN(defaultOriginOffset) || double.IsInfinity(defaultOriginOffset))
                throw new ArgumentOutOfRangeException("defaultOriginOffset");

            Sections = sections;
            DefaultOriginOffset = defaultOriginOffset;
            Parallel = parallel;
            FilterSettings = filterSettings;
        }
    }
}
