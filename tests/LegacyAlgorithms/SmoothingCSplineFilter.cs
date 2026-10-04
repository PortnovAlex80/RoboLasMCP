using LAS_TERRAIN.Configuration;
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Кубический B-сплайн по X: y(x) ≈ Σ c_j * N_{j,p}(x).
    /// Возвращает те же X, сглаживает только Y.
    /// </summary>
    internal class SmoothingCSplineFilter
    {
        // ===== ПАРАМЕТРЫ (крутите в дебаге) ===================================

        /// <summary>Степень сплайна p (обычно 3).</summary>
        public static int Degree = 3;

        /// <summary>
        /// Кол-во управляющих точек (базисных функций). 0 — выбрать автоматически.
        /// Чем меньше — тем сильнее сглаживание по умолчанию.
        /// </summary>
        public static int ControlPointCount = 0;

        /// <summary>
        /// Вес сглаживания μ ≥ 0 для пенальти на вторые разности c (Δ² c).
        /// 0.0 — чистый МНК (может быть почти интерполирующим при большом ControlPointCount).
        /// Типичные значения: 0…10. Эффект стойкий, без резонансов.
        /// </summary>
        public static double Smooth
        {
            get => RuntimeConfig.CSplineSmooth;
            set => RuntimeConfig.CSplineSmooth = value;
        }

        /// <summary>Режим размещения внутренних узлов.</summary>
        public static KnotPlacement Knots = KnotPlacement.Quantile; // или Uniform

        /// <summary>
        /// Небольшая диагональная регуляризация (на случай вырождения).
        /// </summary>
        public static double RidgeEps = 1e-9;

        /// <summary>
        /// Ограничитель авто-выбора кол-ва базисов (для плотных данных).
        /// </summary>
        public static int AutoCtrlMax = 256;

        // ======================================================================

        public static List<Vector2D> Apply(List<Vector2D> points)
        {
            if (points == null || points.Count == 0) return new List<Vector2D>();

            // [OPTIMIZATION] При малом сглаживании (< 0.02) пропускаем B-сплайн
            // Эффект почти как интерполяция, но без O(n³) Холецкого и матриц
            if (Smooth < 0.02)
                return points;

            if (points.Count == 1)
                return new List<Vector2D>(1) { new Vector2D { X = points[0].X, Y = points[0].Y } };

            int n = points.Count;

            int need = Math.Max(2, Degree + 1);  // для кубика: need = 4
            if (n < need)
            {
                // мало точек – вернём как есть
                var passthrough = new List<Vector2D>(n);
                for (int i = 0; i < n; i++)
                    passthrough.Add(new Vector2D { X = points[i].X, Y = points[i].Y });
                return passthrough;
            }

            // 1) Скопируем и отсортируем по X (B-сплайн — 1D по X)
            var idx = new int[n];
            var x = new double[n];
            var y = new double[n];
            for (int i = 0; i < n; i++)
            {
                idx[i] = i;
                x[i] = points[i].X;
                y[i] = points[i].Y;
            }
            Array.Sort(x, idx); // сортируем x и переставляем idx соответственно
            // Переставим y по индексу
            var ySorted = new double[n];
            for (int i = 0; i < n; i++) ySorted[i] = y[idx[i]];

            // 2) Построим B-сплайн аппроксиматор по (x,ySorted)
            var bs = new BSplineApproximator(
                x: x,
                y: ySorted,
                degree: Degree,
                ctrlCount: ControlPointCount,
                smooth: Smooth,
                knotPlacement: Knots,
                ridgeEps: RidgeEps,
                autoCtrlMax: AutoCtrlMax
            );

            // 3) Получим сглажённые значения в тех же x (у нас уже матрица построена)
            var yHatSorted = bs.FittedValues(); // соответствует отсортированным x

            // 4) Вернём Y в исходном порядке X
            var yHatByOrig = new double[n];
            for (int i = 0; i < n; i++)
                yHatByOrig[idx[i]] = yHatSorted[i];

            var res = new List<Vector2D>(n);
            for (int i = 0; i < n; i++)
                res.Add(new Vector2D { X = points[i].X, Y = yHatByOrig[i] });

            return res;
        }

        public enum KnotPlacement { Uniform, Quantile }

        /// <summary>
        /// B-сплайн аппроксиматор y(x) в базе N_{j,p}(x).
        /// Решает (BᵀB + μ R + εI) c = Bᵀ y, где R ≈ D₂ᵀD₂ (вторые разности коэффициентов).
        /// </summary>
        internal class BSplineApproximator
        {
            private readonly int _p;            // степень
            private readonly int _m;            // число контрол-поинтов (базисов)
            private readonly double[] _knots;   // вектор узлов U
            private readonly double[,] _B;      // матрица базиса n×m
            private readonly double[] _c;       // коэффициенты
            private readonly int _n;

            public BSplineApproximator(
                double[] x,
                double[] y,
                int degree,
                int ctrlCount,
                double smooth,
                KnotPlacement knotPlacement,
                double ridgeEps,
                int autoCtrlMax)
            {
                if (x == null || y == null || x.Length != y.Length || x.Length == 0)
                {
                    _n = 0; _p = 1; _m = 1;
                    _knots = new double[0];
                    _B = new double[0, 0];
                    _c = new double[0];
                    return; // NO-THROW
                }

                _n = x.Length;
                _p = Math.Max(1, degree);

                // --- авто-выбор числа базисов ---
                int m = ctrlCount;
                if (m <= 0)
                {
                    // эмпирика: примерно n / 6 (не слишком жёстко), но с ограничителем
                    m = Math.Min(Math.Max(_p + 1, _n / 6), Math.Max(_p + 1, autoCtrlMax));
                }
                if (m < _p + 1) m = _p + 1;
                if (m > _n) m = _n; // перебор базисов не нужен

                _m = m;

                // --- построим узлы ---
                double xmin = x[0], xmax = x[_n - 1];
                if (xmax <= xmin) xmax = xmin + 1e-6; // страховка

                _knots = BuildOpenKnotVector(x, _p, _m, knotPlacement);

                // --- соберём матрицу базиса B (n × m), B[i,j] = N_{j,p}(x_i) ---
                _B = new double[_n, _m];
                for (int i = 0; i < _n; i++)
                {
                    int span = FindSpan(_knots, _p, x[i], _m);
                    var N = BasisFuns(_knots, _p, span, x[i]);
                    int start = span - _p; // глобальный индекс первого ненулевого базиса
                    for (int j = 0; j <= _p; j++)
                    {
                        int col = start + j;
                        if (col >= 0 && col < _m)
                            _B[i, col] = N[j];
                    }
                }

                // --- соберём нормальные уравнения ---
                // A = BᵀB + μ R + ε I ;  b = Bᵀ y
                var A = new double[_m, _m];
                var b = new double[_m];

                // BᵀB и Bᵀy
                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _m; j++)
                    {
                        double Bij = _B[i, j];
                        if (Bij == 0.0) continue;
                        b[j] += Bij * y[i];

                        // верхний треугольник
                        for (int k = j; k < _m; k++)
                        {
                            double Bik = _B[i, k];
                            if (Bik != 0.0) A[j, k] += Bij * Bik;
                        }
                    }
                }
                // симметризация
                for (int j = 0; j < _m; j++)
                    for (int k = 0; k < j; k++)
                        A[j, k] = A[k, j];

                // добавим сглаживание μ * R, где R ~ D2ᵀ D2 (Δ² по коэффициентам)
                double mu = Math.Max(0.0, smooth);
                if (mu > 0.0 && _m >= 3)
                {
                    for (int r = 0; r <= _m - 3; r++)
                    {
                        // вектор второго конечного различия: v[r]=1, v[r+1]=-2, v[r+2]=1
                        int a = r, b2 = r + 1, c2 = r + 2;

                        AddToA(A, a, a, +1.0 * mu);
                        AddToA(A, b2, b2, +4.0 * mu);
                        AddToA(A, c2, c2, +1.0 * mu);

                        AddToA(A, a, b2, -2.0 * mu);
                        AddToA(A, a, c2, +1.0 * mu);
                        AddToA(A, b2, c2, -2.0 * mu);
                    }
                    // симметризовать (мы добавляли оба треугольника), но на всякий случай:
                    for (int j = 0; j < _m; j++)
                        for (int k = 0; k < j; k++)
                            A[j, k] = A[k, j];
                }

                // диагональная страховка εI
                double eps = Math.Max(0.0, ridgeEps);
                if (eps > 0.0)
                {
                    for (int j = 0; j < _m; j++) A[j, j] += eps;
                }

                // --- решим SPD систему A c = b через Холецкого ---
                _c = SolveSPD_Cholesky(A, b);
            }

            public double[] FittedValues()
            {
                var yhat = new double[_n];
                for (int i = 0; i < _n; i++)
                {
                    double s = 0.0;
                    for (int j = 0; j < _m; j++)
                        s += _B[i, j] * _c[j];
                    yhat[i] = s;
                }
                return yhat;
            }

            // ============== ВСПОМОГАТЕЛЬНОЕ ===========================

            // Открытый (clamped) вектор узлов. Внутренние — равномерные либо по квантилям X.
            private static double[] BuildOpenKnotVector(double[] xSorted, int p, int m, KnotPlacement mode)
            {
                int n = xSorted.Length;
                double xmin = xSorted[0], xmax = xSorted[n - 1];
                if (xmax <= xmin) xmax = xmin + 1e-6;

                int knotCount = m + p + 1;
                var U = new double[knotCount];

                // зажим концов
                for (int i = 0; i <= p; i++) U[i] = xmin;
                for (int i = knotCount - p - 1; i < knotCount; i++) U[i] = xmax;

                int inner = knotCount - 2 * (p + 1);
                if (inner <= 0) return U;

                if (mode == KnotPlacement.Uniform)
                {
                    // равномерные по интервалу [xmin, xmax]
                    for (int j = 1; j <= inner; j++)
                    {
                        double t = (double)j / (inner + 1);
                        U[p + j] = xmin + t * (xmax - xmin);
                    }
                }
                else // Quantile
                {
                    // по квантилям x: более адаптивно к неравномерности
                    for (int j = 1; j <= inner; j++)
                    {
                        double q = (double)j / (inner + 1);
                        double pos = q * (n - 1);
                        int k0 = (int)Math.Floor(pos);
                        int k1 = Math.Min(n - 1, k0 + 1);
                        double alpha = pos - k0;
                        U[p + j] = (1.0 - alpha) * xSorted[k0] + alpha * xSorted[k1];
                    }
                }
                return U;
            }

            // Ищем span для x (Piegl & Tiller)
            private static int FindSpan(double[] U, int p, double x, int m /* num ctrl */)
            {
                int nSpanMax = m - 1;
                if (x >= U[nSpanMax + 1]) return nSpanMax;
                if (x <= U[p]) return p;

                int low = p;
                int high = nSpanMax + 1;
                int mid = (low + high) / 2;

                while (x < U[mid] || x >= U[mid + 1])
                {
                    if (x < U[mid]) high = mid;
                    else low = mid;
                    mid = (low + high) / 2;
                }
                return mid;
            }

            // Базисные функции N_{i-p..i, p}(x), возвращает массив длины p+1
            private static double[] BasisFuns(double[] U, int p, int i, double x)
            {
                var N = new double[p + 1];
                var left = new double[p + 1];
                var right = new double[p + 1];

                N[0] = 1.0;
                for (int j = 1; j <= p; j++)
                {
                    left[j] = x - U[i + 1 - j];
                    right[j] = U[i + j] - x;
                    double saved = 0.0;
                    for (int r = 0; r < j; r++)
                    {
                        double denom = right[r + 1] + left[j - r];
                        double term = (denom == 0.0) ? 0.0 : N[r] / denom;
                        double temp = term * right[r + 1];
                        N[r] = saved + temp;
                        saved = term * left[j - r];
                    }
                    N[j] = saved;
                }
                return N;
            }

            private static void AddToA(double[,] A, int r, int c, double v)
            {
                A[r, c] += v;
                if (r != c) A[c, r] += v;
            }

            // Плотный SPD Холецкий (A не портим, возвращаем решение)
            private static double[] SolveSPD_Cholesky(double[,] A, double[] b)
            {
                int n = b.Length;
                var L = new double[n, n];

                // разложение
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        double sum = A[i, j];
                        for (int k = 0; k < j; k++) sum -= L[i, k] * L[j, k];

                        if (i == j)
                        {
                            if (sum <= 0.0) sum = 1e-12; // страховка
                            L[i, j] = Math.Sqrt(sum);
                        }
                        else
                        {
                            L[i, j] = sum / L[j, j];
                        }
                    }
                }

                // Ly = b
                var y = new double[n];
                for (int i = 0; i < n; i++)
                {
                    double sum = b[i];
                    for (int k = 0; k < i; k++) sum -= L[i, k] * y[k];
                    y[i] = sum / L[i, i];
                }

                // Lᵀ x = y
                var x = new double[n];
                for (int i = n - 1; i >= 0; i--)
                {
                    double sum = y[i];
                    for (int k = i + 1; k < n; k++) sum -= L[k, i] * x[k];
                    x[i] = sum / L[i, i];
                }
                return x;
            }
        }
    }
}
