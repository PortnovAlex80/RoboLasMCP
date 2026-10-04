namespace LAS_TERRAIN.Domain.Models
{
    internal sealed class PlanSurfaceSettings
    {
        internal readonly double GridStep;
        internal readonly int PolynomialDegree;
        internal readonly double PolynomialRegularization;
        internal readonly double PolynomialGridStep;

        internal PlanSurfaceSettings(double gridStep, int polynomialDegree,
            double polynomialRegularization, double polynomialGridStep)
        {
            GridStep = gridStep;
            PolynomialDegree = polynomialDegree;
            PolynomialRegularization = polynomialRegularization;
            PolynomialGridStep = polynomialGridStep;
        }
    }
}
