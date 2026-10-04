using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Service
{
    // Statistics over every source point, independent of the returned page.
    public sealed class SectionAxisDensity
    {
        public long PointCount;
        public double? Minimum, Maximum, PointsPerMeter, MeanAdjacentSpacing;
        public double BinSize;
        public double DomainFrom, DomainTo, OccupiedBinFraction, LongestEmptyRunMeters;
        public double? DomainPointsPerMeter;
        public int EmptyBins, LongestEmptyRun;
        public List<SectionDensityBin> Bins = new List<SectionDensityBin>();
    }

    public sealed class SectionDensityBin
    {
        public double From, To, PointsPerMeter;
        public long Count;
    }

    internal sealed class SectionDensityAccumulator
    {
        private readonly double _size;
        private readonly SortedDictionary<long, long> _counts = new SortedDictionary<long, long>();
        private long _total;
        private double _min = double.PositiveInfinity, _max = double.NegativeInfinity;
        internal SectionDensityAccumulator(double size)
        {
            if (double.IsNaN(size) || double.IsInfinity(size) || size <= 0)
                throw new ArgumentOutOfRangeException("bin_size", "Bin size must be finite and positive.");
            _size = size;
        }
        internal void Add(double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentException("Non-finite source coordinate.");
            double index = Math.Floor(value / _size);
            // Bound index magnitude as well as span: no overflowing casts or indistinguishable bin edges.
            if (Math.Abs(index) > 1e12)
                throw new ArgumentException("Increase bin_size: coordinate/bin_size is too large.");
            long key = (long)index;
            long count;
            _counts.TryGetValue(key, out count);
            if (count == 0 && _counts.Count >= 10000)
                throw new ArgumentException("Increase bin_size: more than 10000 occupied bins.");
            _counts[key] = count + 1;
            _total++;
            _min = Math.Min(_min, value); _max = Math.Max(_max, value);
        }
        internal SectionAxisDensity Finish(double? domainMin, double? domainMax)
        {
            var result = new SectionAxisDensity { PointCount = _total, BinSize = _size };
            if (_total > 0)
            {
                result.Minimum = _min; result.Maximum = _max;
                double span = _max - _min;
                result.PointsPerMeter = span > 0 ? (double?) (_total / span) : null;
                result.MeanAdjacentSpacing = _total > 1 ? (double?) (span / (_total - 1)) : null;
            }
            double lo = domainMin ?? (_total > 0 ? Math.Floor(_min / _size) * _size : 0);
            double hi = domainMax ?? (_total > 0 ? (Math.Floor(_max / _size) + 1) * _size : 0);
            result.DomainFrom = lo; result.DomainTo = hi;
            if (hi <= lo) return result;
            result.DomainPointsPerMeter = _total / (hi - lo);
            double firstValue = Math.Floor(lo / _size), lastValue = Math.Ceiling(hi / _size) - 1;
            if (Math.Abs(firstValue) > 1e12 || Math.Abs(lastValue) > 1e12 || lastValue - firstValue >= 10000)
                throw new ArgumentException("Increase bin_size: density domain needs more than 10000 bins.");
            long first = (long)firstValue, last = (long)lastValue;
            int emptyRun = 0;
            double emptyMeters = 0;
            for (long key = first; key <= last; key++)
            {
                long count; _counts.TryGetValue(key, out count);
                // Closed transverse domain includes its upper boundary in the final bin.
                if (key == last && domainMax.HasValue && hi / _size == Math.Floor(hi / _size))
                { long boundary; _counts.TryGetValue(last + 1, out boundary); count += boundary; }
                double from = Math.Max(lo, key * _size), to = Math.Min(hi, (key + 1) * _size);
                result.Bins.Add(new SectionDensityBin { From = from, To = to, Count = count,
                    PointsPerMeter = count / (to - from) });
                if (count == 0) { result.EmptyBins++; emptyRun++; emptyMeters += to - from;
                    result.LongestEmptyRun = Math.Max(result.LongestEmptyRun, emptyRun);
                    result.LongestEmptyRunMeters = Math.Max(result.LongestEmptyRunMeters, emptyMeters); }
                else { emptyRun = 0; emptyMeters = 0; }
            }
            result.OccupiedBinFraction = (double)(result.Bins.Count - result.EmptyBins) / result.Bins.Count;
            return result;
        }
    }
}
