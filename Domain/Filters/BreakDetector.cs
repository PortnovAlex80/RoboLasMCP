// Domain/Filters/BreakDetector.cs
// Detects terrain breaks (sharp angles) in LiDAR profiles.
//
// PURPOSE:
// Standard B-spline smoothing blurs sharp terrain features like:
// - Curb edges (80-90°)
// - Embankment toes (20-40°)
// - Slope breaks (40-60°)
//
// BreakDetector finds these discontinuities so the spline can treat each
// segment independently, preserving the sharp angles.
//
// ALGORITHM:
// 1. Compute left and right local slopes at each point using LSQ
// 2. Convert slopes to angles via atan (required for linearity!)
// 3. Compute break strength = |angleRight - angleLeft|
// 4. Compute R² for both windows — true breaks have high R² on both sides
// 5. Find local maxima above threshold with suppression
// 6. Filter short segments (< MinSegmentPoints)
// 7. Compute precise break coordinates as intersection of LSQ lines
//
// KEY INSIGHT:
// atan() is CRITICAL. Slope differences are non-linear:
//   slope 1 → 45°
//   slope 10 → 84°
//   Difference: 8.0 in slope, but only 39° in angle
// Without atan, steep slopes produce false breaks.
//
// AGENT NOTES:
// - Parameters arrive through FilterOperationSnapshot
// - Output is List<SegmentBoundary> for compatibility with gap detection
// - R² criterion filters out noise and vegetation
// - Short segment filter prevents over-segmentation

using System;
using System.Collections.Generic;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Детектор изломов профиля.
    ///
    /// Находит точки, где профиль резко меняет направление.
    /// Использует двойной критерий: угол излома + R² goodness-of-fit.
    ///
    /// МАТЕМАТИКА:
    /// В каждой точке вычисляем два локальных наклона (левый и правый) через МНК.
    /// Угол между ними — break strength. Истинный излом даёт высокий R²
    /// с обеих сторон (точки хорошо ложатся на прямую), шум — низкий R².
    /// </summary>
    internal static class BreakDetector
    {
        // Detection settings are supplied by the operation snapshot.

        internal static List<SegmentBoundary> FindBreaks(List<Vector2D> points,
            FilterOperationSnapshot settings)
        {
            return FindBreaksCore(points, settings.BreakSlopeWindow, settings.BreakR2Window,
                settings.BreakAngleThreshold, settings.BreakMinR2,
                settings.BreakMinSegmentPoints, settings.BreakSuppressRadius);
        }

        private static List<SegmentBoundary> FindBreaksCore(List<Vector2D> points,
            int slopeWindow, int r2Window, double angleThreshold, double minR2,
            int minSegmentPoints, int suppressRadius)
        {
            int n = points.Count;
            int wSlope = Math.Max(2, slopeWindow);
            int wR2 = Math.Max(3, r2Window);
            int suppressR = Math.Max(1, suppressRadius);

            // Слишком мало точек — не детектируем
            if (n < wSlope * 2 + 1)
                return new List<SegmentBoundary>();

            // ── Шаг 1: Угол излома и R² в каждой точке ───────────────────────
            var strength = new double[n];
            var r2L = new double[n];
            var r2R = new double[n];

            for (int i = 0; i < n; i++)
            {
                // Окна для наклона
                int lFromS = Math.Max(0, i - wSlope);
                int lToS = i;
                int rFromS = i;
                int rToS = Math.Min(n - 1, i + wSlope);

                // Окна для R² (могут быть больше)
                int lFromR = Math.Max(0, i - wR2);
                int lToR = i;
                int rFromR = i;
                int rToR = Math.Min(n - 1, i + wR2);

                // Наклоны через МНК
                double sL, bL, sR, bR;
                FitLine(points, lFromS, lToS, out sL, out bL);
                FitLine(points, rFromS, rToS, out sR, out bR);

                // R² на больших окнах
                r2L[i] = ComputeR2(points, lFromR, lToR, sL, bL);
                r2R[i] = ComputeR2(points, rFromR, rToR, sR, bR);

                // Угол излома: atan обязателен!
                double angL = Math.Atan(sL);
                double angR = Math.Atan(sR);
                strength[i] = Math.Abs(angR - angL);
            }

            // ── Шаг 2: Кандидаты — локальные максимумы с двойным критерием ──
            var candidates = new List<int>();

            for (int i = 1; i < n - 1; i++)
            {
                // Фильтр по углу
                if (strength[i] < angleThreshold)
                    continue;

                // Фильтр по R² — оба окна должны быть "прямыми"
                if (r2L[i] < minR2 || r2R[i] < minR2)
                    continue;

                // Локальный максимум?
                bool isMax = true;
                int jFrom = Math.Max(0, i - suppressR);
                int jTo = Math.Min(n - 1, i + suppressR);

                for (int j = jFrom; j <= jTo; j++)
                {
                    if (j != i && strength[j] > strength[i])
                    {
                        isMax = false;
                        break;
                    }
                }

                if (isMax)
                    candidates.Add(i);
            }

            // ── Шаг 3: Фильтр коротких сегментов ─────────────────────────────
            // Если два разлома слишком близко — оставляем более сильный
            var filtered = new List<int>();
            int prev = -minSegmentPoints;

            foreach (int ci in candidates)
            {
                if (ci - prev < minSegmentPoints)
                {
                    // Слишком близко — заменяем предыдущий если текущий сильнее
                    if (filtered.Count > 0)
                    {
                        int lastIdx = filtered[filtered.Count - 1];
                        if (strength[ci] > strength[lastIdx])
                            filtered[filtered.Count - 1] = ci;
                    }
                }
                else
                {
                    filtered.Add(ci);
                    prev = ci;
                }
            }

            // ── Шаг 4: Строим SegmentBoundary с точными координатами ─────────
            var result = new List<SegmentBoundary>();

            foreach (int bi in filtered)
            {
                // Пересечение двух МНК-прямых
                int lFrom = Math.Max(0, bi - wSlope);
                int rTo = Math.Min(n - 1, bi + wSlope);

                double sL, bL, sR, bR;
                FitLine(points, lFrom, bi, out sL, out bL);
                FitLine(points, bi, rTo, out sR, out bR);

                double xBreak, yBreak;

                // Проверка на почти параллельные прямые
                double denom = sL - sR;
                if (Math.Abs(denom) < 0.1) // ~6° разница — недостаточно
                {
                    // Используем ближайшую точку
                    xBreak = points[bi].X;
                    yBreak = points[bi].Y;
                }
                else
                {
                    // Точное пересечение
                    xBreak = (bR - bL) / denom;

                    // Проверка: пересечение в разумных пределах
                    double xMin = points[Math.Max(0, bi - wSlope)].X;
                    double xMax = points[Math.Min(n - 1, bi + wSlope)].X;

                    if (xBreak < xMin || xBreak > xMax)
                    {
                        // Выпадает из окна — используем ближайшую точку
                        xBreak = points[bi].X;
                        yBreak = points[bi].Y;
                    }
                    else
                    {
                        yBreak = sL * xBreak + bL;
                    }
                }

                result.Add(SegmentBoundary.FromBreak(xBreak, yBreak, strength[bi]));
            }

            return result;
        }

        // ══════════════════════════════════════════════════════════════════════
        // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ (МНК)
        // ══════════════════════════════════════════════════════════════════════

        /// <summary>
        /// МНК: подгонка прямой y = slope * x + intercept.
        /// </summary>
        private static void FitLine(List<Vector2D> pts, int from, int to,
            out double slope, out double intercept)
        {
            int cnt = to - from + 1;
            if (cnt < 2)
            {
                slope = 0;
                intercept = pts[from].Y;
                return;
            }

            double sx = 0, sy = 0, sxx = 0, sxy = 0;
            for (int i = from; i <= to; i++)
            {
                double x = pts[i].X;
                double y = pts[i].Y;
                sx += x;
                sy += y;
                sxx += x * x;
                sxy += x * y;
            }

            double d = cnt * sxx - sx * sx;
            if (Math.Abs(d) < 1e-12)
            {
                // Вырожденный случай (все X одинаковы)
                slope = 0;
                intercept = sy / cnt;
                return;
            }

            slope = (cnt * sxy - sx * sy) / d;
            intercept = (sy - slope * sx) / cnt;
        }

        /// <summary>
        /// Вычисляет R² (коэффициент детерминации).
        /// R² = 1 - SS_res / SS_tot
        /// </summary>
        private static double ComputeR2(List<Vector2D> pts, int from, int to,
            double slope, double intercept)
        {
            int cnt = to - from + 1;
            if (cnt < 2)
                return 0;

            // Среднее Y
            double meanY = 0;
            for (int i = from; i <= to; i++)
                meanY += pts[i].Y;
            meanY /= cnt;

            // SS_tot и SS_res
            double ssTot = 0, ssRes = 0;
            for (int i = from; i <= to; i++)
            {
                double y = pts[i].Y;
                double predicted = slope * pts[i].X + intercept;
                ssTot += (y - meanY) * (y - meanY);
                ssRes += (y - predicted) * (y - predicted);
            }

            // Горизонтальный участок — прямая идеальна
            if (ssTot < 1e-12)
                return 1.0;

            return 1.0 - ssRes / ssTot;
        }
    }
}
