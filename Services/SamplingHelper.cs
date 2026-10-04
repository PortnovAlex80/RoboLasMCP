using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Helpers
{
    internal static class SamplingHelper
    {
        public static List<Vector4D> ReservoirSampleWithProgress(
            IList<Vector4D> src, int k, Action<float> onProgress)
        {
            return ReservoirSampleWithProgress(src, k, onProgress, null);
        }

        // A fixed Random can be supplied by tests. The public path still creates
        // one unseeded Random per non-trivial sample, as it did before.
        internal static List<Vector4D> ReservoirSampleWithProgress(
            IList<Vector4D> src, int k, Action<float> onProgress, Random rnd)
        {
            return ReservoirSampleWithProgress(src, k, onProgress, rnd, null);
        }

        // A cancelled sample is discarded instead of returning a partial reservoir.
        internal static List<Vector4D> ReservoirSampleWithProgress(
            IList<Vector4D> src, int k, Action<float> onProgress, Random rnd,
            Func<bool> cancellationPending)
        { return ReservoirSampleWithProgress<Vector4D>(src,k,onProgress,rnd,cancellationPending); }

        internal static List<T> ReservoirSampleWithProgress<T>(IList<T> src,int k,
            Action<float> onProgress,Random rnd,Func<bool> cancellationPending)
        {
            ThrowIfCancelled(cancellationPending);
            if (src == null || src.Count == 0 || k <= 0)
            {
                if (onProgress != null) onProgress(1f);
                ThrowIfCancelled(cancellationPending);
                return new List<T>();
            }
            if (k >= src.Count)
            {
                if (onProgress != null) onProgress(1f);
                ThrowIfCancelled(cancellationPending);
                List<T> all = new List<T>(src);
                ThrowIfCancelled(cancellationPending);
                return all;
            }

            if (rnd == null) rnd = new Random();
            int n = src.Count;
            T[] reservoir = new T[k];

            int i = 0;
            for (; i < k; i++)
            {
                if ((i & 1023) == 0) ThrowIfCancelled(cancellationPending);
                reservoir[i] = src[i];
            }

            int processed = 0;
            int totalTail = n - k;
            int reportEvery = Math.Max(1, totalTail / 100);

            for (; i < n; i++)
            {
                if ((i & 1023) == 0) ThrowIfCancelled(cancellationPending);
                int j = rnd.Next(i + 1); // [0..i]
                if (j < k) reservoir[j] = src[i];

                processed++;
                if (onProgress != null && (processed % reportEvery == 0 || i == n - 1))
                {
                    onProgress((float)(i + 1) / (float)n);
                    ThrowIfCancelled(cancellationPending);
                }
            }

            ThrowIfCancelled(cancellationPending);
            List<T> sampled = new List<T>(reservoir);
            ThrowIfCancelled(cancellationPending);
            return sampled;
        }

        public static List<Vector4D> ReduceByPercentWithProgress(
            IList<Vector4D> src, double percent, Action<float> onProgress)
        {
            return ReduceByPercentWithProgress(src, percent, onProgress, null);
        }

        internal static List<Vector4D> ReduceByPercentWithProgress(
            IList<Vector4D> src, double percent, Action<float> onProgress,
            Func<bool> cancellationPending)
        {return ReduceByPercentWithProgress<Vector4D>(src,percent,onProgress,cancellationPending);}

        internal static List<T> ReduceByPercentWithProgress<T>(IList<T> src,double percent,
            Action<float> onProgress,Func<bool> cancellationPending)
        {
            ThrowIfCancelled(cancellationPending);
            if (src == null || src.Count == 0)
            {
                if (onProgress != null) onProgress(1f);
                ThrowIfCancelled(cancellationPending);
                return new List<T>();
            }
            if (percent >= 100.0)
            {
                if (onProgress != null) onProgress(1f);
                ThrowIfCancelled(cancellationPending);
                List<T> all = new List<T>(src);
                ThrowIfCancelled(cancellationPending);
                return all;
            }
            if (percent <= 0.0)
            {
                if (onProgress != null) onProgress(1f);
                ThrowIfCancelled(cancellationPending);
                return new List<T>();
            }

            int k = (int)Math.Round(src.Count * percent / 100.0);
            return ReservoirSampleWithProgress(src, k, onProgress, null,
                cancellationPending);
        }

        private static void ThrowIfCancelled(Func<bool> cancellationPending)
        {
            if (cancellationPending != null && cancellationPending())
                throw new OperationCanceledException("Point reduction was cancelled.");
        }

        /// <summary>
        /// Два набора подряд c прогресс-окном [start..start+span].
        /// Первая выборка занимает долю firstPart внутри окна.
        /// </summary>
        public static void ReduceTwoSetsByPercentWithProgress(
            IList<Vector4D> firstSrc, double firstPercent,
            IList<Vector4D> secondSrc, double secondPercent,
            float start, float span, float firstPart,
            Action<float> set,
            out List<Vector4D> first, out List<Vector4D> second)
        {
            if (set == null) set = _ => { };

            first = ReduceByPercentWithProgress(
                firstSrc, firstPercent,
                p => set(start + span * firstPart * p)
            );

            second = ReduceByPercentWithProgress(
                secondSrc, secondPercent,
                p => set(start + span * firstPart + span * (1f - firstPart) * p)
            );

            set(start + span);
        }
    }
}
