using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// B-сплайн сглаживание: возвращает точки с теми же X, сглаживает Y.
    /// Все параметры — public static поля для удобного дебага.
    /// </summary>
    internal class SmoothingBSplineFilter
    {
        // ===== ПАРАМЕТРЫ (крутите в дебаге) ===================================

        /// <summary>Желаемая степень сплайна (обычно 3). Для малых n будет снижена автоматически.</summary>
        public static int Degree = 3;

        /// <summary>Число базисов/контрол-поинтов (m). 0 — авто (≈ n/6, но не более AutoCtrlMax).</summary>
        public static int ControlPointCount = 0;

        /// <summary>Параметр сглаживания μ ≥ 0 (штраф на вторые разности коэффициентов). 0 — чистый МНК.</summary>
        public static double Smooth = 0.0;

        /// <summary>Схема внутренних узлов.</summary>
        public static KnotPlacement Knots = KnotPlacement.Quantile; // или Uniform

        /// <summary>Небольшая диагональная регуляризация.</summary>
        public static double RidgeEps = 1e-9;

        /// <summary>Ограничитель на авто-число базисов.</summary>
        public static int AutoCtrlMax = 256;

        // ======================================================================

        public static List<Vector2D> Apply(List<Vector2D> points)
        {
            // [CHANGED] Мягкие фолбэки, без исключений:
            if (points == null || points.Count == 0)
                return new List<Vector2D>();

            if (points.Count == 1)
                return new List<Vector2D>(1) { new Vector2D { X = points[0].X, Y = points[0].Y } };

            int n = points.Count;

            // Копируем и сортируем по X, сохранив исходный порядок через индексы
            var idx = new int[n];
            var x = new double[n];
            var y = new double[n];
            for (int i = 0; i < n; i++)
            {
                idx[i] = i;
                x[i] = points[i].X;
                y[i] = points[i].Y;
            }
            Array.Sort(x, idx);

            var ySorted = new double[n];
            for (int i = 0; i < n; i++) ySorted[i] = y[idx[i]];

            double[] yHatSorted;

            // [NEW] Полный try/catch — без «проброса» исключений наружу
            try
            {
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

                yHatSorted = bs.FittedValues();          // [SAFEGUARD] вернёт ySorted, если аппроксимация невалидна
                if (yHatSorted == null || yHatSorted.Length != n)
                    yHatSorted = ySorted;                 // [SAFEGUARD]
            }
            catch
            {
                // [NEW] Фолбэк: любые ошибки → возвращаем исходные точки
                var passthrough = new List<Vector2D>(n);
                for (int i = 0; i < n; i++)
                    passthrough.Add(new Vector2D { X = points[i].X, Y = points[i].Y });
                return passthrough;
            }

            // Вернём в исходный порядок X
            var yHatByOrig = new double[n];
            for (int i = 0; i < n; i++)
                yHatByOrig[idx[i]] = yHatSorted[i];

            var res = new List<Vector2D>(n);
            for (int i = 0; i < n; i++)
                res.Add(new Vector2D { X = points[i].X, Y = yHatByOrig[i] });

            return res;
        }

        public enum KnotPlacement { Uniform, Quantile }

        internal class BSplineApproximator
        {
            private readonly int _p;            // степень
            private readonly int _m;            // число базисов
            private readonly double[] _knots;   // узловой вектор
            private readonly double[,] _B;      // матрица базиса n×m
            private readonly double[] _c;       // коэффициенты
            private readonly int _n;
            private readonly double[] _y;       // [NEW] сохраняем ySorted для безопасного возврата
            private readonly bool _isValid;     // [NEW] флаг валидности решения

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
                // [CHANGED] Никаких throw — только мягкая проверка
                _n = (x != null) ? x.Length : 0;
                if (_n == 0 || y == null || y.Length != _n)
                {
                    _p = 1; _m = 1; _knots = new double[] { 0, 0, 1, 1 };
                    _B = new double[0, 0];
                    _c = new double[0];
                    _y = y ?? new double[0];
                    _isValid = false;
                    return;
                }

                _y = (double[])y.Clone(); // [NEW] сохранили входной (отсортированный) y

                // === Мягкая адаптация к малым n (без исключений) ===
                int pDesired = degree;
                if (pDesired < 1) pDesired = 1;
                if (pDesired > _n - 1) pDesired = _n - 1;  // [CHANGED]
                if (pDesired < 1) pDesired = 1;
                _p = pDesired;

                // Автовыбор m (число базисов)
                int m = ctrlCount;
                if (m <= 0)
                {
                    int autoM = _n / 6;
                    if (autoM < _p + 1) autoM = _p + 1;
                    if (autoM > autoCtrlMax) autoM = autoCtrlMax;
                    if (autoM > _n) autoM = _n;
                    m = autoM;
                }
                if (m < _p + 1) m = _p + 1;
                if (m > _n) m = _n;
                _m = m;

                // Узлы (открытый, зажатый на концах) с защитой от вырождения
                _knots = BuildOpenKnotVector(x, _p, _m, knotPlacement);

                // Матрица базиса
                _B = new double[_n, _m];
                try
                {
                    for (int i = 0; i < _n; i++)
                    {
                        int span = FindSpan(_knots, _p, x[i], _m);
                        var N = BasisFuns(_knots, _p, span, x[i]);
                        int start = span - _p;
                        for (int j = 0; j <= _p; j++)
                        {
                            int col = start + j;
                            if (col >= 0 && col < _m)
                                _B[i, col] = N[j];
                        }
                    }
                }
                catch
                {
                    // [NEW] Если базис не собрался — помечаем невалидность
                    _isValid = false;
                    _c = new double[0];
                    return;
                }

                // Нормальные уравнения: (BᵀB + μR + εI) c = Bᵀ y
                var A = new double[_m, _m];
                var bb = new double[_m];

                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _m; j++)
                    {
                        double Bij = _B[i, j];
                        if (Bij == 0.0) continue;
                        bb[j] += Bij * y[i];

                        for (int k = j; k < _m; k++)
                        {
                            double Bik = _B[i, k];
                            if (Bik != 0.0) A[j, k] += Bij * Bik;
                        }
                    }
                }
                for (int j = 0; j < _m; j++)
                    for (int k = 0; k < j; k++)
                        A[j, k] = A[k, j];

                // Штраф на вторые разности коэффициентов (мягкое сглаживание)
                double mu = (smooth > 0.0) ? smooth : 0.0;
                if (mu > 0.0 && _m >= 3)
                {
                    for (int r = 0; r <= _m - 3; r++)
                    {
                        int a = r, b2 = r + 1, c2 = r + 2;
                        AddToA(A, a, a, +1.0 * mu);
                        AddToA(A, b2, b2, +4.0 * mu);
                        AddToA(A, c2, c2, +1.0 * mu);
                        AddToA(A, a, b2, -2.0 * mu);
                        AddToA(A, a, c2, +1.0 * mu);
                        AddToA(A, b2, c2, -2.0 * mu);
                    }
                }

                // Диагональная страховка
                double eps = (ridgeEps > 0.0) ? ridgeEps : 0.0;
                if (eps > 0.0) for (int j = 0; j < _m; j++) A[j, j] += eps;

                // Решаем SPD через Холецкого
                _c = SolveSPD_Cholesky(A, bb);  // [CHANGED] может вернуть null при неуспехе
                _isValid = (_c != null && _c.Length == _m);
                if (!_isValid) _c = new double[0]; // [SAFEGUARD]
            }

            public double[] FittedValues()
            {
                // [NEW] Если решение невалидно — возвращаем входной y (отсортированный)
                if (!_isValid || _B == null || _c == null || _c.Length == 0) return (double[])_y.Clone();

                var yhat = new double[_n];
                for (int i = 0; i < _n; i++)
                {
                    double s = 0.0;
                    for (int j = 0; j < _m; j++) s += _B[i, j] * _c[j];
                    if (double.IsNaN(s) || double.IsInfinity(s)) { yhat[i] = _y[i]; } // [SAFEGUARD]
                    else yhat[i] = s;
                }
                return yhat;
            }

            // ===== ВСПОМОГАТЕЛЬНОЕ ==============================================

            private static double[] BuildOpenKnotVector(double[] xSorted, int p, int m, KnotPlacement mode)
            {
                int n = xSorted.Length;
                double xmin = xSorted[0], xmax = xSorted[n - 1];
                if (xmax <= xmin) xmax = xmin + 1e-6; // [SAFEGUARD] чтобы узлы не скукожились

                int knotCount = m + p + 1;
                var U = new double[knotCount];

                // зажимаем концы по p+1 раз
                for (int i = 0; i <= p; i++) U[i] = xmin;
                for (int i = knotCount - p - 1; i < knotCount; i++) U[i] = xmax;

                int inner = knotCount - 2 * (p + 1);
                if (inner <= 0) return U;

                if (mode == KnotPlacement.Uniform)
                {
                    for (int j = 1; j <= inner; j++)
                    {
                        double t = (double)j / (inner + 1);
                        U[p + j] = xmin + t * (xmax - xmin);
                    }
                }
                else // Quantile
                {
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

            // [CHANGED] Возвращает null при неуспехе (никаких исключений)
            private static double[] SolveSPD_Cholesky(double[,] A, double[] b)
            {
                try
                {
                    int n = b.Length;
                    var L = new double[n, n];

                    // Разложение
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            double sum = A[i, j];
                            for (int k = 0; k < j; k++) sum -= L[i, k] * L[j, k];

                            if (i == j)
                            {
                                if (!(sum > 0.0)) sum = 1e-12; // [SAFEGUARD]
                                if (double.IsNaN(sum) || double.IsInfinity(sum)) return null;
                                L[i, j] = Math.Sqrt(sum);
                                if (double.IsNaN(L[i, j]) || double.IsInfinity(L[i, j])) return null;
                            }
                            else
                            {
                                if (L[j, j] == 0.0 || double.IsNaN(L[j, j]) || double.IsInfinity(L[j, j])) return null;
                                L[i, j] = sum / L[j, j];
                                if (double.IsNaN(L[i, j]) || double.IsInfinity(L[i, j])) return null;
                            }
                        }
                    }

                    // Ly = b
                    var y = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        double sum = b[i];
                        for (int k = 0; k < i; k++) sum -= L[i, k] * y[k];
                        if (L[i, i] == 0.0 || double.IsNaN(L[i, i]) || double.IsInfinity(L[i, i])) return null;
                        y[i] = sum / L[i, i];
                    }

                    // Lᵀx = y
                    var x = new double[n];
                    for (int i = n - 1; i >= 0; i--)
                    {
                        double sum = y[i];
                        for (int k = i + 1; k < n; k++) sum -= L[k, i] * x[k];
                        if (L[i, i] == 0.0 || double.IsNaN(L[i, i]) || double.IsInfinity(L[i, i])) return null;
                        x[i] = sum / L[i, i];
                        if (double.IsNaN(x[i]) || double.IsInfinity(x[i])) return null;
                    }
                    return x;
                }
                catch
                {
                    return null; // [NEW] молча сигналим неуспех
                }
            }
        }
    }
}
