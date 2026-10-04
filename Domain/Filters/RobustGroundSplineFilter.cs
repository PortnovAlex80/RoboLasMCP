// Domain/Filters/RobustGroundSplineFilter.cs
// Asymmetric iteratively reweighted B-spline for ground level extraction.
// Replaces MinWeightedGroundLevelMedianFilter entirely.
//
// REFACTORED: B-matrix computed once, buffers reused across iterations.
//
// BREAK-AWARE SEGMENTATION:
// The spline can receive external SegmentBoundary objects (from BreakDetector)
// which define "hard knots" - points the spline must pass through exactly.
// Boundaries are merged with auto-detected gaps (MaxGapMeters).
//
// See docs/BREAK_DETECTOR_DESIGN.md for architecture.

using System;
using System.Collections.Generic;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Robust B-сплайн нижней огибающей.
    ///
    /// На каждой итерации точки выше текущего сплайна получают вес exp(-r/sigma),
    /// точки ниже — вес 1.0. Сходится к земной поверхности без ступенек на откосах.
    ///
    /// Опционально: предварительный морфологический фильтр для рельсовых спаек.
    ///
    /// BREAK-AWARE:
    /// Принимает List{SegmentBoundary} — границы сегментов (изломы + зазоры).
    /// Каждый сегмент обрабатывается независимо, границы становятся жёсткими узлами.
    /// </summary>
    internal static class RobustGroundSplineFilter
    {
        // Numerical settings are supplied by the operation snapshot.

        internal static List<Vector2D> Apply(List<Vector2D> points,
            List<SegmentBoundary> externalBoundaries, FilterOperationSnapshot settings)
        {
            if (points == null || points.Count == 0)
                return new List<Vector2D>();

            if (points.Count < settings.SplineDegree + 1)
            {
                var pass = new List<Vector2D>(points.Count);
                for (int i = 0; i < points.Count; i++)
                    pass.Add(new Vector2D { X = points[i].X, Y = points[i].Y });
                return pass;
            }

            // [1] Опциональный рельсовый фильтр
            if (settings.SplineEnableRailFilter)
            {
                int k = ComputeKernel(points, settings.SplineRailFilterWindowMeters);
                points = MorphologicalOpen(points, k);
            }

            // [2] Сортировка по X
            int n = points.Count;
            var xs = new double[n];
            var ys = new double[n];
            SortByX(points, xs, ys);

            // [3] Детектируем зазоры как SegmentBoundary
            List<SegmentBoundary> gapBoundaries = DetectGapBoundaries(xs, ys, settings);

            // [4] Объединяем зазоры + внешние границы
            List<SegmentBoundary> allBoundaries = BoundaryHelper.MergeAndSort(
                gapBoundaries,
                externalBoundaries,
                1e-6);

            // [5] Обрабатываем сегменты между границами
            var result = new List<Vector2D>();
            ProcessSegmentsWithBoundaries(xs, ys, allBoundaries, result, settings);

            return result;
        }

        // ── Детекция зазоров как SegmentBoundary ─────────────────────────────────

        /// <summary>
        /// Преобразует зазоры (превышающие MaxGapMeters) в SegmentBoundary.
        /// </summary>
        private static List<SegmentBoundary> DetectGapBoundaries(double[] xs, double[] ys,
            FilterOperationSnapshot settings)
        {
            var gaps = new List<SegmentBoundary>();
            double maxGap = Math.Max(settings.SplineMaxGapMeters, 1e-6);
            int n = xs.Length;

            for (int i = 1; i < n; i++)
            {
                double gap = xs[i] - xs[i - 1];
                if (gap > maxGap)
                {
                    // Gap boundary: первая точка после зазора
                    gaps.Add(SegmentBoundary.FromGap(xs[i], ys[i], gap));
                }
            }

            return gaps;
        }

        // ── Обработка сегментов с границами ───────────────────────────────────────

        /// <summary>
        /// Разбивает профиль на сегменты по границам и обрабатывает каждый независимо.
        /// Границы становятся якорями — сплайн проходит точно через них.
        /// </summary>
        private static void ProcessSegmentsWithBoundaries(
            double[] xs,
            double[] ys,
            List<SegmentBoundary> boundaries,
            List<Vector2D> result,
            FilterOperationSnapshot settings)
        {
            int n = xs.Length;
            if (n == 0)
                return;

            // Нет границ — весь профиль как один сегмент
            if (boundaries == null || boundaries.Count == 0)
            {
                ApplySegment(xs, ys, result, settings);
                return;
            }

            int segStart = 0;
            int bCount = boundaries.Count;

            // Обрабатываем интервалы: [start, boundary1), [boundary1, boundary2), ..., [boundaryN, end]
            for (int bIdx = 0; bIdx <= bCount; bIdx++)
            {
                // Находим конец текущего сегмента
                int segEnd;
                if (bIdx < bCount)
                {
                    // Сегмент заканчивается на границе (поиск X в отсортированном массиве)
                    segEnd = FindIndexOfX(xs, segStart, boundaries[bIdx].X);
                    // Включаем точку границы если она есть в данных
                    if (segEnd < n && Math.Abs(xs[segEnd] - boundaries[bIdx].X) < 1e-6)
                        segEnd++;
                }
                else
                {
                    // Последний сегмент до конца данных
                    segEnd = n;
                }

                int segLen = segEnd - segStart;

                // Добавляем левый якорь (предыдущая граница)
                bool hasLeftAnchor = (bIdx > 0);
                SegmentBoundary leftBoundary = hasLeftAnchor ? boundaries[bIdx - 1] : null;

                // Добавляем правый якорь (текущая граница)
                bool hasRightAnchor = (bIdx < bCount);
                SegmentBoundary rightBoundary = hasRightAnchor ? boundaries[bIdx] : null;

                // Строим сегмент с якорями
                int totalPoints = segLen;
                if (hasLeftAnchor) totalPoints++;
                if (hasRightAnchor) totalPoints++;

                if (totalPoints >= settings.SplineDegree + 1)
                {
                    // Достаточно точек — строим сплайн с якорями
                    var segXs = new double[totalPoints];
                    var segYs = new double[totalPoints];
                    int pos = 0;

                    // Левый якорь
                    if (hasLeftAnchor)
                    {
                        segXs[pos] = leftBoundary.X;
                        segYs[pos] = leftBoundary.Y;
                        pos++;
                    }

                    // Точки сегмента
                    for (int i = segStart; i < segEnd; i++)
                    {
                        segXs[pos] = xs[i];
                        segYs[pos] = ys[i];
                        pos++;
                    }

                    // Правый якорь
                    if (hasRightAnchor)
                    {
                        segXs[pos] = rightBoundary.X;
                        segYs[pos] = rightBoundary.Y;
                        pos++;
                    }

                    ApplySegment(segXs, segYs, result, settings);
                }
                else if (segLen > 0)
                {
                    // Слишком мало точек — передаём как есть + якоря
                    if (hasLeftAnchor)
                        result.Add(new Vector2D { X = leftBoundary.X, Y = leftBoundary.Y });

                    for (int i = segStart; i < segEnd; i++)
                        result.Add(new Vector2D { X = xs[i], Y = ys[i] });

                    if (hasRightAnchor)
                        result.Add(new Vector2D { X = rightBoundary.X, Y = rightBoundary.Y });
                }
                else if (hasLeftAnchor || hasRightAnchor)
                {
                    // Сегмент пустой — только якоря (стык границ)
                    if (hasLeftAnchor && hasRightAnchor)
                    {
                        // Два якоря рядом — добавляем только левый (правый добавится в следующем сегменте)
                        result.Add(new Vector2D { X = leftBoundary.X, Y = leftBoundary.Y });
                    }
                }

                segStart = segEnd;
            }
        }

        /// <summary>
        /// Бинарный поиск индекса первого элемента >= x в отсортированном массиве.
        /// </summary>
        private static int FindIndexOfX(double[] xs, int start, double x)
        {
            int lo = start;
            int hi = xs.Length;

            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (xs[mid] < x)
                    lo = mid + 1;
                else
                    hi = mid;
            }

            return lo;
        }

        /// <summary>
        /// Обрабатывает один непрерывный сегмент.
        /// При Smooth≈0 пропускает итерации и пенальти.
        /// </summary>
        private static void ApplySegment(double[] xs, double[] ys, List<Vector2D> result,
            FilterOperationSnapshot settings)
        {
            int n = xs.Length;
            int m = ComputeCtrlCount(n, settings.SplineDegree, settings.SplineAutoCtrlMax);

            // При Smooth≈0 урезаем число базисов — иначе Runge
            // Без пенальти слишком много базисов даёт осцилляции вокруг выбросов
            if (settings.SplineSmooth < 1e-10)
            {
                // Эмпирика: sqrt(n) достаточно для стабильной аппроксимации
                int mStable = Math.Max(settings.SplineDegree + 1, (int)Math.Sqrt(n));
                mStable = Math.Min(mStable, settings.SplineAutoCtrlMax);
                m = Math.Min(m, mStable);
            }

            var basis  = new BSplineBasis(xs, settings.SplineDegree, m);
            var solver = new BSplineSolver(basis);

            double sigma = Math.Max(settings.SplineSigma, 1e-6);

            // [A] Ранний выход: Smooth≈0 → один проход без итераций
            if (settings.SplineSmooth < 1e-10)
            {
                // Без пенальти граничные базисы могут быть недоопределены.
                // Масштабируем ridge по дисперсии Y — достаточно чтобы стабилизировать,
                // недостаточно чтобы сместить результат.
                double yScale = ComputeYScale(ys);
                double stableRidge = Math.Max(settings.SplineRidgeEps, yScale * 1e-6);

                var ones = new double[n];
                for (int i = 0; i < n; i++) ones[i] = 1.0;

                solver.Solve(ys, ones, 0.0, stableRidge);
                // Сразу к сетке — робастность не нужна, почти интерполяция
            }
            else
            {
                // [B] Полный итерационный путь с робастностью
                var weights = new double[n];
                for (int i = 0; i < n; i++) weights[i] = 1.0;

                for (int iter = 0; iter < settings.SplineMaxIterations; iter++)
                {
                    solver.Solve(ys, weights, settings.SplineSmooth, settings.SplineRidgeEps);

                    double maxChange = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        double residual = ys[i] - solver.Eval(xs[i]);
                        double newW = residual > 0.0
                            ? Math.Exp(-residual / sigma)
                            : 1.0;

                        double delta = Math.Abs(newW - weights[i]);
                        if (delta > maxChange) maxChange = delta;
                        weights[i] = newW;
                    }

                    if (maxChange < settings.SplineConvergenceTol) break;
                }
            }

            // [C] Регулярная выходная сетка только внутри сегмента
            double xMin = xs[0];
            double xMax = xs[n - 1];
            double step = Math.Max(settings.SplineGridStep, 1e-6);
            int gridCount = Math.Max(2, (int)Math.Ceiling((xMax - xMin) / step) + 1);

            for (int i = 0; i < gridCount; i++)
            {
                double x = xMin + i * step;
                if (x > xMax) x = xMax;
                result.Add(new Vector2D { X = x, Y = solver.Eval(x) });
            }
        }

        // ── Утилита выбора числа базисов ───────────────────────────────────────

        private static int ComputeCtrlCount(int n, int degree, int autoCtrlMax)
        {
            int p = Math.Max(1, degree);
            int m = Math.Min(Math.Max(p + 1, n / 6), Math.Max(p + 1, autoCtrlMax));
            if (m < p + 1) m = p + 1;
            if (m > n) m = n;
            return m;
        }

        /// <summary>
        /// Оценка масштаба Y для адаптивного ridge.
        /// Грубая оценка: max - min (используем только для нормировки ridge).
        /// </summary>
        private static double ComputeYScale(double[] ys)
        {
            double min = ys[0], max = ys[0];
            for (int i = 1; i < ys.Length; i++)
            {
                if (ys[i] < min) min = ys[i];
                if (ys[i] > max) max = ys[i];
            }
            double scale = max - min;
            return scale < 1e-6 ? 1.0 : scale; // страховка от плоских данных
        }

        // ── Рельсовый фильтр (морфологическое открытие) ───────────────────────

        private static int ComputeKernel(List<Vector2D> points, double windowMeters)
        {
            if (points.Count < 2) return 1;
            double length  = points[points.Count - 1].X - points[0].X;
            double density = points.Count / Math.Max(length, 1.0);
            int k = (int)(windowMeters * density);
            return Math.Max(1, k % 2 == 0 ? k + 1 : k);
        }

        private static List<Vector2D> MorphologicalOpen(List<Vector2D> points, int kernelSize)
        {
            int n    = points.Count;
            int half = Math.Max(0, kernelSize / 2);

            // Erode — массив вместо List, не аллоцируем объекты в цикле
            var eroded = new double[n];
            for (int i = 0; i < n; i++)
            {
                int start = Math.Max(0, i - half);
                int end   = Math.Min(n - 1, i + half);
                double min = double.PositiveInfinity;
                for (int j = start; j <= end; j++)
                    if (points[j].Y < min) min = points[j].Y;
                eroded[i] = min;
            }

            // Dilate
            var opened = new List<Vector2D>(n);
            for (int i = 0; i < n; i++)
            {
                int start = Math.Max(0, i - half);
                int end   = Math.Min(n - 1, i + half);
                double max = double.NegativeInfinity;
                for (int j = start; j <= end; j++)
                    if (eroded[j] > max) max = eroded[j];
                opened.Add(new Vector2D { X = points[i].X, Y = max });
            }

            return opened;
        }

        // ── Утилита сортировки ─────────────────────────────────────────────────

        private static void SortByX(List<Vector2D> points, double[] xs, double[] ys)
        {
            int n   = points.Count;
            var idx = new int[n];

            for (int i = 0; i < n; i++)
            {
                idx[i] = i;
                xs[i]  = points[i].X;
            }

            Array.Sort(xs, idx);

            for (int i = 0; i < n; i++)
                ys[i] = points[idx[i]].Y;
        }

        // ══════════════════════════════════════════════════════════════════════
        // КЛАСС 1: BSplineBasis
        // Вычисляется ОДИН РАЗ до цикла итераций.
        // Хранит knots и матрицу B — то, что не меняется между итерациями.
        // ══════════════════════════════════════════════════════════════════════

        private sealed class BSplineBasis
        {
            public readonly int      P;        // степень сплайна
            public readonly int      M;        // число базисов
            public readonly int      N;        // число точек
            public readonly double[] Knots;    // вектор узлов
            public readonly double[,] B;       // матрица базиса n×m

            public BSplineBasis(double[] xSorted, int degree, int m)
            {
                N = xSorted.Length;
                P = degree;
                M = m;

                Knots = BuildKnotVector(xSorted, P, M);

                // Локальные буферы для конструктора (вызывается один раз на сегмент)
                var Nv    = new double[P + 1];
                var left  = new double[P + 1];
                var right = new double[P + 1];

                B = new double[N, M];
                for (int i = 0; i < N; i++)
                {
                    int span = FindSpan(Knots, P, xSorted[i], M);
                    BasisFuns(Knots, P, span, xSorted[i], Nv, left, right);
                    int start = span - P;
                    for (int j = 0; j <= P; j++)
                    {
                        int col = start + j;
                        if ((uint)col < (uint)M)
                            B[i, col] = Nv[j];
                    }
                }
            }

            // ── Статические методы B-сплайн математики (Piegl & Tiller) ──────

            public static double[] BuildKnotVector(double[] xSorted, int p, int m)
            {
                int    n         = xSorted.Length;
                int    knotCount = m + p + 1;
                var    U         = new double[knotCount];
                double xmin      = xSorted[0];
                double xmax      = xSorted[n - 1];
                if (xmax <= xmin) xmax = xmin + 1e-6; // защита от вырожденного сегмента

                for (int i = 0; i <= p; i++)                        U[i] = xmin;
                for (int i = knotCount - p - 1; i < knotCount; i++) U[i] = xmax;

                int inner = knotCount - 2 * (p + 1);
                for (int j = 1; j <= inner; j++)
                {
                    double q   = (double)j / (inner + 1);
                    double pos = q * (n - 1);
                    int    k0  = (int)Math.Floor(pos);
                    int    k1  = Math.Min(n - 1, k0 + 1);
                    double a   = pos - k0;
                    U[p + j]   = (1.0 - a) * xSorted[k0] + a * xSorted[k1];
                }
                return U;
            }

            public static int FindSpan(double[] U, int p, double x, int m)
            {
                int nMax = m - 1;
                if (x >= U[nMax + 1]) return nMax;
                if (x <= U[p])        return p;
                int low = p, high = nMax + 1, mid = (low + high) / 2;
                while (x < U[mid] || x >= U[mid + 1])
                {
                    if (x < U[mid]) high = mid; else low = mid;
                    mid = (low + high) / 2;
                }
                return mid;
            }

            public static double[] BasisFuns(double[] U, int p, int i, double x, double[] N, double[] left, double[] right)
            {
                N[0] = 1.0;
                for (int j = 1; j <= p; j++)
                {
                    left[j]  = x - U[i + 1 - j];
                    right[j] = U[i + j] - x;
                    double saved = 0.0;
                    for (int r = 0; r < j; r++)
                    {
                        double denom = right[r + 1] + left[j - r];
                        double term  = denom == 0.0 ? 0.0 : N[r] / denom;
                        N[r]   = saved + term * right[r + 1];
                        saved  = term * left[j - r];
                    }
                    N[j] = saved;
                }
                return N;
            }
        }

        // ══════════════════════════════════════════════════════════════════════
        // КЛАСС 2: BSplineSolver
        // Создаётся ОДИН РАЗ до цикла, вызывается каждую итерацию.
        // Хранит буферы A, b, L, C — переиспользует их.
        // ══════════════════════════════════════════════════════════════════════

        private sealed class BSplineSolver
        {
            private readonly BSplineBasis _basis;
            private readonly double[,]    _A;         // буфер m×m
            private readonly double[]     _b;         // буфер m
            private readonly double[,]    _L;         // буфер m×m для Cholesky
            private readonly double[]     _solveTmp;  // временный буфер для forward solve
            public  readonly double[]     C;          // коэффициенты — результат
            private readonly double[]     _basisN;    // буфер для BasisFuns (p+1)
            private readonly double[]     _basisLeft; // буфер для BasisFuns (p+1)
            private readonly double[]     _basisRight;// буфер для BasisFuns (p+1)

            public BSplineSolver(BSplineBasis basis)
            {
                _basis = basis;
                int m = basis.M;
                int p = basis.P;
                _A = new double[m, m];
                _b = new double[m];
                _L = new double[m, m];
                _solveTmp = new double[m];
                C = new double[m];
                // Буферы для BasisFuns — переиспользуются в Eval
                _basisN = new double[p + 1];
                _basisLeft = new double[p + 1];
                _basisRight = new double[p + 1];
            }

            /// <summary>
            /// Решает систему с новыми весами. Вызывается каждую итерацию.
            /// </summary>
            public void Solve(double[] y, double[] weights, double smooth, double ridgeEps)
            {
                int n = _basis.N;
                int m = _basis.M;

                // !! ОБЯЗАТЕЛЬНО — очистка буферов перед использованием
                Array.Clear(_A, 0, _A.Length);
                Array.Clear(_b, 0, _b.Length);

                // BᵀWB и BᵀWy — используем _basis.B, не пересчитываем
                for (int i = 0; i < n; i++)
                {
                    double wi = weights[i];
                    for (int j = 0; j < m; j++)
                    {
                        double wBij = wi * _basis.B[i, j];
                        if (wBij == 0.0) continue;
                        _b[j] += wBij * y[i];
                        for (int k = j; k < m; k++)
                            if (_basis.B[i, k] != 0.0)
                                _A[j, k] += wBij * _basis.B[i, k];
                    }
                }

                // Симметризация
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < j; k++)
                        _A[j, k] = _A[k, j];

                // Пенальти μ * D2ᵀD2 (вторые разности коэффициентов)
                // Пропускаем полностью если smooth ≈ 0 (совпадает с ранним выходом в ApplySegment)
                if (smooth > 1e-10 && m >= 3)
                {
                    double mu = smooth;
                    for (int r = 0; r <= m - 3; r++)
                    {
                        AddSym(_A, r,     r,     +1.0 * mu);
                        AddSym(_A, r + 1, r + 1, +4.0 * mu);
                        AddSym(_A, r + 2, r + 2, +1.0 * mu);
                        AddSym(_A, r,     r + 1, -2.0 * mu);
                        AddSym(_A, r,     r + 2, +1.0 * mu);
                        AddSym(_A, r + 1, r + 2, -2.0 * mu);
                    }
                    // Повторная симметризация после пенальти
                    for (int j = 0; j < m; j++)
                        for (int k = 0; k < j; k++)
                            _A[j, k] = _A[k, j];
                }

                // Диагональная страховка εI
                double eps = Math.Max(0.0, ridgeEps);
                if (eps > 0.0)
                    for (int j = 0; j < m; j++) _A[j, j] += eps;

                // Холецкий — результат в C
                SolveCholesky(_A, _b, _L, _solveTmp, C);
            }

            /// <summary>Значение сплайна в произвольной точке x.</summary>
            public double Eval(double x)
            {
                int    span  = BSplineBasis.FindSpan(_basis.Knots, _basis.P, x, _basis.M);
                int    start = span - _basis.P;
                double val   = 0.0;

                // Используем переиспользуемые буферы вместо аллокации
                BSplineBasis.BasisFuns(_basis.Knots, _basis.P, span, x, _basisN, _basisLeft, _basisRight);

                for (int j = 0; j <= _basis.P; j++)
                {
                    int col = start + j;
                    if ((uint)col < (uint)_basis.M)
                        val += _basisN[j] * C[col];
                }
                return val;
            }

            // ── Вспомогательные методы ────────────────────────────────────────

            private static void AddSym(double[,] A, int r, int c, double v)
            {
                A[r, c] += v;
                if (r != c) A[c, r] += v;
            }

            /// <summary>
            /// Холецкий с внешними буферами. Результат пишет в result[].
            /// </summary>
            private static void SolveCholesky(double[,] A, double[] b, double[,] L, double[] y, double[] result)
            {
                int n = b.Length;

                // !! ОБЯЗАТЕЛЬНО — очистка L перед использованием
                Array.Clear(L, 0, L.Length);

                // Разложение A = LLᵀ
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        double sum = A[i, j];
                        for (int k = 0; k < j; k++) sum -= L[i, k] * L[j, k];
                        if (i == j)
                        {
                            if (sum <= 0.0) sum = 1e-12;
                            L[i, j] = Math.Sqrt(sum);
                        }
                        else
                        {
                            L[i, j] = sum / L[j, j];
                        }
                    }
                }

                // Forward solve: Ly = b
                for (int i = 0; i < n; i++)
                {
                    double sum = b[i];
                    for (int k = 0; k < i; k++) sum -= L[i, k] * y[k];
                    y[i] = sum / L[i, i];
                }

                // Backward solve: Lᵀx = y
                for (int i = n - 1; i >= 0; i--)
                {
                    double sum = y[i];
                    for (int k = i + 1; k < n; k++) sum -= L[k, i] * result[k];
                    result[i] = sum / L[i, i];
                }
            }
        }
    }
}
