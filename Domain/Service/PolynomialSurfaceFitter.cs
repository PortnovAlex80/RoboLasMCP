// Domain/Service/PolynomialSurfaceFitter.cs
// Polynomial surface fitting using least squares method.
// Fits Z = f(x,y) to 3D points and generates a regular grid.
//
// Supported degrees:
//   1 = linear (3 params):     Z = c0 + c1*x + c2*y
//   2 = quadratic (6 params):  Z = c0 + c1*x + c2*y + c3*x² + c4*xy + c5*y²
//   3 = cubic (10 params):     Z = c0 + c1*x + c2*y + c3*x² + c4*xy + c5*y² + c6*x³ + c7*x²y + c8*xy² + c9*y³
//
// Uses ridge regression (L2 regularization) for numerical stability.
// Solves (A'A + λI)c = A'z using Cholesky decomposition.

using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Service
{
    /// <summary>
    /// Polynomial surface fitter using least squares method.
    /// Fits Z = f(x,y) to 3D points and generates a regular grid from the fitted surface.
    /// </summary>
    public static class PolynomialSurfaceFitter
    {
        /// <summary>
        /// Fits a polynomial surface Z = f(x,y) to points using least squares.
        /// </summary>
        /// <param name="points">Input 3D points to fit</param>
        /// <param name="degree">Polynomial degree (1=linear, 2=quadratic, 3=cubic)</param>
        /// <param name="regularization">Ridge parameter for numerical stability (typical: 1e-6 to 1e-3)</param>
        /// <param name="gridStep">Grid spacing for output points</param>
        /// <param name="bounds">Bounding box for grid generation</param>
        /// <returns>List of grid points evaluated from fitted surface</returns>
        public static List<Vector3D> FitSurface(
            List<Vector3D> points,
            int degree,
            double regularization,
            double gridStep,
            BoundingBox2D bounds)
        {
            if (points == null || points.Count == 0)
            {
                return new List<Vector3D>();
            }

            if (degree < 1 || degree > 3)
            {
                throw new ArgumentException("Degree must be 1, 2, or 3", "degree");
            }

            if (regularization < 0.0)
            {
                throw new ArgumentException("Regularization must be non-negative", "regularization");
            }

            if (gridStep <= 0.0)
            {
                throw new ArgumentException("Grid step must be positive", "gridStep");
            }

            // Number of parameters: p = (degree + 1) * (degree + 2) / 2
            int p = (degree + 1) * (degree + 2) / 2;

            int n = points.Count;
            if (n < p)
            {
                throw new ArgumentException(
                    String.Format("Insufficient points: {0} points required, got {1}", p, n),
                    "points");
            }

            // Accumulate the same normal equations in input order without an n × p matrix.
            double[] coefficients = SolveNormalEquations(points, degree, p, regularization);

            // Generate grid points
            List<Vector3D> gridPoints = new List<Vector3D>();

            Vector2D min = bounds.Min;
            Vector2D max = bounds.Max;

            // Calculate number of grid points in each direction
            int nx = (int)Math.Ceiling((max.X - min.X) / gridStep) + 1;
            int ny = (int)Math.Ceiling((max.Y - min.Y) / gridStep) + 1;

            // Evaluate polynomial at each grid point
            for (int ix = 0; ix < nx; ix++)
            {
                double x = min.X + ix * gridStep;
                if (x > max.X) x = max.X;

                for (int iy = 0; iy < ny; iy++)
                {
                    double y = min.Y + iy * gridStep;
                    if (y > max.Y) y = max.Y;

                    double z = EvaluatePolynomial(x, y, degree, coefficients);
                    gridPoints.Add(new Vector3D(x, y, z));
                }
            }

            return gridPoints;
        }

        /// <summary>
        /// Builds design matrix row for (x,y) at given degree.
        /// Returns basis vector: [1, x, y, x², xy, y², x³, x²y, xy², y³, ...]
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="degree">Polynomial degree</param>
        /// <returns>Basis vector of length p = (degree+1)*(degree+2)/2</returns>
        private static double[] BuildBasis(double x, double y, int degree)
        {
            int p = (degree + 1) * (degree + 2) / 2;
            double[] basis = new double[p];

            basis[0] = 1.0; // Constant term

            int basisIdx = 1;
            for (int d = 1; d <= degree; d++)
            {
                for (int xPower = d; xPower >= 0; xPower--)
                {
                    int yPower = d - xPower;
                    double xTerm = Math.Pow(x, xPower);
                    double yTerm = Math.Pow(y, yPower);
                    basis[basisIdx] = xTerm * yTerm;
                    basisIdx++;
                }
            }

            return basis;
        }

        /// <summary>
        /// Evaluates the fitted polynomial at (x,y).
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="degree">Polynomial degree</param>
        /// <param name="coefficients">Fitted coefficients [c0, c1, ..., c(p-1)]</param>
        /// <returns>Z value at (x,y)</returns>
        private static double EvaluatePolynomial(double x, double y, int degree, double[] coefficients)
        {
            double[] basis = BuildBasis(x, y, degree);
            double z = 0.0;

            for (int i = 0; i < basis.Length; i++)
            {
                z += coefficients[i] * basis[i];
            }

            return z;
        }

        /// <summary>
        /// Solves (A'A + λI)c = A'z using Cholesky decomposition.
        /// This is the normal equations form of least squares with ridge regularization.
        /// </summary>
        /// <param name="points">Input points in accumulation order</param>
        /// <param name="degree">Polynomial degree</param>
        /// <param name="p">Number of parameters</param>
        /// <param name="regularization">Ridge parameter λ</param>
        /// <returns>Solution vector c (p)</returns>
        private static double[] SolveNormalEquations(
            List<Vector3D> points, int degree, int p, double regularization)
        {
            int n = points.Count;

            // Compute A'A (p × p) and A'z (p)
            double[,] ata = new double[p, p];
            double[] atz = new double[p];

            // Initialize A'A with regularization term λI
            for (int i = 0; i < p; i++)
            {
                ata[i, i] = regularization;
            }

            // Reuse one row. The i -> j -> k summation order and Math.Pow calls
            // match the former design-matrix implementation for finite input.
            double[] basis = new double[p];
            for (int i = 0; i < n; i++)
            {
                Vector3D pt = points[i];
                basis[0] = 1.0;
                int basisIdx = 1;
                for (int d = 1; d <= degree; d++)
                {
                    for (int xPower = d; xPower >= 0; xPower--)
                    {
                        int yPower = d - xPower;
                        double xTerm = Math.Pow(pt.X, xPower);
                        double yTerm = Math.Pow(pt.Y, yPower);
                        basis[basisIdx] = xTerm * yTerm;
                        basisIdx++;
                    }
                }

                for (int j = 0; j < p; j++)
                {
                    double aij = basis[j];

                    // A'z
                    atz[j] += aij * pt.Z;

                    // A'A (symmetric, only compute upper triangle)
                    for (int k = j; k < p; k++)
                    {
                        ata[j, k] += aij * basis[k];
                    }
                }
            }

            // Copy upper triangle to lower triangle (symmetric)
            for (int i = 0; i < p; i++)
            {
                for (int j = i + 1; j < p; j++)
                {
                    ata[j, i] = ata[i, j];
                }
            }

            // Solve (A'A + λI)c = A'z using Cholesky
            return CholeskySolve(ata, atz);
        }

        /// <summary>
        /// Solves Ax = b using Cholesky decomposition.
        /// Assumes A is symmetric positive-definite.
        /// Reference: RobustGroundSplineFilter.cs:706-747
        /// </summary>
        /// <param name="A">Symmetric positive-definite matrix</param>
        /// <param name="b">Right-hand side vector</param>
        /// <returns>Solution vector x</returns>
        private static double[] CholeskySolve(double[,] A, double[] b)
        {
            int n = b.Length;

            // Cholesky decomposition: A = LLᵀ
            double[,] L = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double sum = A[i, j];

                    for (int k = 0; k < j; k++)
                    {
                        sum -= L[i, k] * L[j, k];
                    }

                    if (i == j)
                    {
                        // Diagonal element: ensure positive for numerical stability
                        if (sum <= 0.0)
                        {
                            sum = 1e-12;
                        }
                        L[i, j] = Math.Sqrt(sum);
                    }
                    else
                    {
                        L[i, j] = sum / L[j, j];
                    }
                }
            }

            // Forward solve: Ly = b
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                double sum = b[i];
                for (int k = 0; k < i; k++)
                {
                    sum -= L[i, k] * y[k];
                }
                y[i] = sum / L[i, i];
            }

            // Backward solve: Lᵀx = y
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = y[i];
                for (int k = i + 1; k < n; k++)
                {
                    sum -= L[k, i] * x[k];
                }
                x[i] = sum / L[i, i];
            }

            return x;
        }
    }
}
