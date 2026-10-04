// Domain/Filters/OrderByX.cs
// In-place sort by X coordinate with zero allocations
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Сортировка точек по координате X.
    /// In-place, O(n log n), ноль аллокаций на каждый вызов.
    /// </summary>
    internal static class OrderByX
    {
        // Кэшированный делегат — создаётся один раз при первом обращении к классу
        private static readonly Comparison<Vector2D> _compareByX = (a, b) => a.X.CompareTo(b.X);

        public static List<Vector2D> Apply(List<Vector2D> points)
        {
            if (points == null || points.Count <= 1)
                return points;

            // In-place сортировка — без создания нового списка
            points.Sort(_compareByX);
            return points;
        }
    }
}
