using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    internal class SmoothingSplineFilter
    {
        public static double Lambda = 0.1;

        public static List<Vector2D> Apply(List<Vector2D> points)
        {
            if (points == null || points.Count == 0) return new List<Vector2D>();
            if (points.Count == 1)
            {
                var r1 = new List<Vector2D>(1);
                r1.Add(new Vector2D { X = points[0].X, Y = points[0].Y });
                return r1;
            }

            int n = points.Count;
            var x = new double[n];
            var y = new double[n];
            for (int i = 0; i < n; i++) { x[i] = points[i].X; y[i] = points[i].Y; }

            var spline = new SmoothingSplineFast(x, y, Lambda);

            // S(x_i) == s_i, так что лишней интерполяции не делаем
            var s = spline.SmoothedValuesRef();
            var res = new List<Vector2D>(n);
            for (int i = 0; i < n; i++)
                res.Add(new Vector2D { X = points[i].X, Y = s[i] });
            return res;
        }
    }

    internal class SmoothingSplineFast
    {
        private readonly double[] _x;
        private readonly double[] _s;   // сглаженные значения в узлах
        private readonly double[] _M;   // вторые производные натурального сплайна

        public SmoothingSplineFast(double[] x, double[] y, double lambda)
        {
            if (x == null || y == null) throw new ArgumentNullException();
            if (x.Length != y.Length) throw new ArgumentException("x and y must have the same length");
            if (x.Length < 2) throw new ArgumentException("Need at least 2 points");

            _x = x;
            _s = SolveSmoothedValuesBand2(x, y, lambda < 0 ? 0 : lambda);
            _M = BuildNaturalSplineSecondDerivatives(_x, _s);
        }

        public double[] SmoothedValuesRef() { return _s; }

        public double Evaluate(double xv)
        {
            int n = _x.Length;
            int i = 0;
            while (i < n - 1 && _x[i + 1] <= xv) i++;
            if (i >= n - 1) i = n - 2;
            if (i < 0) i = 0;

            double h = _x[i + 1] - _x[i];
            if (h < 1e-12 && h > -1e-12) return _s[i];
            double dx = xv - _x[i];

            double a0 = _s[i];
            double b0 = (_s[i + 1] - _s[i]) / h - h * (2.0 * _M[i] + _M[i + 1]) / 6.0;
            double c0 = _M[i] / 2.0;
            double d0 = (_M[i + 1] - _M[i]) / (6.0 * h);
            return a0 + b0 * dx + c0 * dx * dx + d0 * dx * dx * dx;
        }

        // ---------- Шаг 1: решаем (I + λ D^T W D) s = y при ширине ленты 2 ----------
        private static double[] SolveSmoothedValuesBand2(double[] x, double[] y, double lambda)
        {
            int n = x.Length;
            var s = new double[n];
            if (lambda <= 0.0)
            {
                Array.Copy(y, s, n);
                return s;
            }

            var h = new double[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                double hi = x[i + 1] - x[i];
                if (hi <= 0) hi = 1e-12;
                h[i] = hi;
            }

            // Ленты A: d0 (diag), d1 (offset 1, т.е. A[i+1,i]), d2 (offset 2, A[i+2,i])
            var d0 = new double[n];
            var d1 = new double[n - 1];
            var d2 = new double[n - 2];
            for (int i = 0; i < n; i++) d0[i] = 1.0;
            for (int i = 0; i < n - 1; i++) d1[i] = 0.0;
            for (int i = 0; i < n - 2; i++) d2[i] = 0.0;

            // Добавляем вклад λ * D^T W D (каждый внутренний i порождает 3x3 блок в A)
            for (int i = 1; i <= n - 2; i++)
            {
                double hm = h[i - 1], hp = h[i];
                double denom_m = hm * (hm + hp);
                double denom_0 = hm * hp;
                double denom_p = hp * (hm + hp);

                double a = 2.0 / denom_m;
                double b = -2.0 / denom_0;
                double c = 2.0 / denom_p;

                double w = 0.5 * (hm + hp);
                double sw = Math.Sqrt(w);

                double ra = sw * a, rb = sw * b, rc = sw * c;
                double lam = lambda;

                int p = i - 1, q = i, r = i + 1;

                d0[p] += lam * (ra * ra);
                d0[q] += lam * (rb * rb);
                d0[r] += lam * (rc * rc);

                double pq = lam * (ra * rb);
                double pr = lam * (ra * rc);
                double qr = lam * (rb * rc);

                d1[p] += pq;      // A[q,p] = A[p,q] = d1[p]
                d1[q] += qr;      // A[r,q] = A[q,r] = d1[q]
                d2[p] += pr;      // A[r,p] = A[p,r] = d2[p]
            }

            // Решаем A s = y ленточным Холецким с шириной 2
            var xsol = SolveSPD_Band2_Cholesky(d0, d1, d2, y);
            Array.Copy(xsol, s, n);
            return s;
        }

        // Ленточный Холецкий для SPD (диагональ + 2 поддиагонали), затем прямой/обратный ход
        private static double[] SolveSPD_Band2_Cholesky(double[] d0, double[] d1, double[] d2, double[] b)
        {
            int n = d0.Length;
            var l0 = new double[n];
            var l1 = new double[n];   // L[i, i-1]
            var l2 = new double[n];   // L[i, i-2]

            // i = 0
            double diag = d0[0];
            if (diag <= 1e-20) diag = 1e-20;
            l0[0] = Math.Sqrt(diag);

            if (n >= 2)
            {
                l1[1] = d1[0] / l0[0];
                diag = d0[1] - l1[1] * l1[1];
                if (diag <= 1e-20) diag = 1e-20;
                l0[1] = Math.Sqrt(diag);
            }

            for (int i = 2; i < n; i++)
            {
                l2[i] = d2[i - 2] / l0[i - 2];

                double t = d1[i - 1] - l2[i] * l1[i - 1];
                l1[i] = t / l0[i - 1];

                diag = d0[i] - l1[i] * l1[i] - l2[i] * l2[i];
                if (diag <= 1e-20) diag = 1e-20;
                l0[i] = Math.Sqrt(diag);
            }

            // Прямой ход: L y = b
            var yv = new double[n];
            yv[0] = b[0] / l0[0];
            if (n >= 2) yv[1] = (b[1] - l1[1] * yv[0]) / l0[1];
            for (int i = 2; i < n; i++)
                yv[i] = (b[i] - l1[i] * yv[i - 1] - l2[i] * yv[i - 2]) / l0[i];

            // Обратный ход: L^T x = y
            var x = new double[n];
            x[n - 1] = yv[n - 1] / l0[n - 1];
            if (n >= 2) x[n - 2] = (yv[n - 2] - l1[n - 1] * x[n - 1]) / l0[n - 2];
            for (int i = n - 3; i >= 0; i--)
                x[i] = (yv[i] - l1[i + 1] * x[i + 1] - l2[i + 2] * x[i + 2]) / l0[i];

            return x;
        }

        // ---------- Шаг 2: вторые производные M натурального сплайна ----------
        private static double[] BuildNaturalSplineSecondDerivatives(double[] xx, double[] ss)
        {
            int n = xx.Length;
            if (n == 2) return new double[] { 0.0, 0.0 };

            var h = new double[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                double hi = xx[i + 1] - xx[i];
                if (hi <= 0) hi = 1e-12;
                h[i] = hi;
            }

            var rhs = new double[n]; // 0 на концах соответствует M0=Mn-1=0
            for (int i = 1; i < n - 1; i++)
                rhs[i] = 6.0 * ((ss[i + 1] - ss[i]) / h[i] - (ss[i] - ss[i - 1]) / h[i - 1]);

            var diag = new double[n];
            var sub = new double[n - 1];
            var sup = new double[n - 1];

            // Жёсткие границы: M0=0, Mn-1=0
            diag[0] = 1.0; sup[0] = 0.0;
            for (int i = 1; i < n - 1; i++)
            {
                sub[i - 1] = h[i - 1];
                diag[i] = 2.0 * (h[i - 1] + h[i]);
                sup[i] = h[i];
            }
            diag[n - 1] = 1.0; sub[n - 2] = 0.0;

            return SolveTridiagonal(sub, diag, sup, rhs);
        }

        private static double[] SolveTridiagonal(double[] a, double[] b, double[] c, double[] d)
        {
            int n = b.Length;
            var bb = (double[])b.Clone();
            var cc = (double[])c.Clone();
            var dd = (double[])d.Clone();

            for (int i = 1; i < n; i++)
            {
                double w = (bb[i - 1] == 0.0) ? 0.0 : (a[i - 1] / bb[i - 1]);
                bb[i] -= w * cc[i - 1];
                dd[i] -= w * dd[i - 1];
            }
            var x = new double[n];
            x[n - 1] = (bb[n - 1] == 0.0) ? 0.0 : (dd[n - 1] / bb[n - 1]);
            for (int i = n - 2; i >= 0; i--)
                x[i] = (dd[i] - cc[i] * x[i + 1]) / bb[i];
            return x;
        }
    }
}
