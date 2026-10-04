using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Service
{
    // Prepare and validate every station before changing the CAD corridor.
    internal static class SectionStationPlanner
    {
        internal const int MaxSections = 100000;

        internal static List<double> Plan(double length, double step)
        {
            if (double.IsNaN(length) || double.IsInfinity(length) || length < 0.0)
                throw new ArgumentOutOfRangeException("length", "The alignment length must be finite and non-negative.");
            if (double.IsNaN(step) || double.IsInfinity(step) || step <= 0.0)
                throw new ArgumentOutOfRangeException("step", "The section step must be finite and positive.");
            if (length / step >= MaxSections)
                throw new ArgumentOutOfRangeException("step", "Too many sections requested.");

            List<double> stations = new List<double>();
            double station = 0.0;
            while (station <= length)
            {
                if (stations.Count == MaxSections)
                    throw new ArgumentOutOfRangeException("step", "Too many sections requested.");
                stations.Add(station);
                double next = station + step;
                if (next <= station)
                    throw new ArgumentOutOfRangeException("step", "The section step does not advance the station.");
                station = next;
            }
            return stations;
        }
    }
}
