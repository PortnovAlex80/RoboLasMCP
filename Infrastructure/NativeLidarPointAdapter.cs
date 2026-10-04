using System;
using System.Linq.Expressions;

namespace LAS_TERRAIN.Infrastructure
{
    // FindPoints changed from Vector4D.W to LidarPoint.Weight in the current SDK.
    // Infer T from the SDK callback; resolve its accessor once, never reflect per point.
    internal static class NativeLidarPointAdapter
    {
        internal static double Weight<T>(T point) { return Accessor<T>.Read(point); }
        private static class Accessor<T>
        {
            internal static readonly Func<T, double> Read = Create();
            private static Func<T, double> Create()
            {
                var parameter = Expression.Parameter(typeof(T), "point");
                string member = typeof(T).GetField("Weight") != null || typeof(T).GetProperty("Weight") != null
                    ? "Weight" : "W";
                var value = Expression.PropertyOrField(parameter, member);
                return Expression.Lambda<Func<T, double>>(Expression.Convert(value, typeof(double)), parameter).Compile();
            }
        }
    }
}
