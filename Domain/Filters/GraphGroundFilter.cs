// Domain/Filters/GraphGroundFilter.cs
// Simple occupancy grid filter
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Простой фильтр на основе occupancy grid.
    /// Активная ячейка = количество точек >= minPts.
    /// Все точки из активных ячеек проходят в результат.
    /// </summary>
    internal static class GraphGroundFilter
    {

        internal static List<Vector2D> Apply(List<Vector2D> points, out GraphGroundDebugInfo debug,
            FilterOperationSnapshot settings)
        {
            return ApplyCore(points, out debug, settings.GraphBinX, settings.GraphBinY, settings.GraphMinPts);
        }

        private static List<Vector2D> ApplyCore(List<Vector2D> points, out GraphGroundDebugInfo debug,
            double binX, double binY, int minPts)
        {
            debug = null;

            if (points == null || points.Count == 0)
                return new List<Vector2D>();

            // ── Шаг 1: Occupancy Grid ─────────────────────────────────────────
            double xMin = points[0].X, xMax = points[0].X;
            double yMin = points[0].Y, yMax = points[0].Y;
            foreach (var p in points)
            {
                if (p.X < xMin) xMin = p.X; else if (p.X > xMax) xMax = p.X;
                if (p.Y < yMin) yMin = p.Y; else if (p.Y > yMax) yMax = p.Y;
            }

            int nX = Math.Max(1, (int)Math.Ceiling((xMax - xMin) / binX) + 1);
            int nY = Math.Max(1, (int)Math.Ceiling((yMax - yMin) / binY) + 1);

            var grid       = new int[nX * nY];
            var pointCells = new int[points.Count];

            // maxCount накапливаем здесь — убираем отдельный проход в конце
            int maxCount = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int xi   = Clamp((int)((points[i].X - xMin) / binX), 0, nX - 1);
                int yi   = Clamp((int)((points[i].Y - yMin) / binY), 0, nY - 1);
                int cell = xi * nY + yi;
                pointCells[i] = cell;
                int cnt = ++grid[cell];
                if (cnt > maxCount) maxCount = cnt;
            }

            // ── Шаг 2b: Найти локальный минимум Y в каждом столбце ──
            // ВАЖНО: Используем реальное значение Y, а не индекс бина!
            // Это позволяет классификации следовать за рельефом на уклонах.
            var colLocalMinY = new double[nX];
            for (int xi = 0; xi < nX; xi++)
                colLocalMinY[xi] = double.PositiveInfinity;

            // Проход 1: найти минимум Y в каждом столбце (только активные ячейки)
            for (int i = 0; i < points.Count; i++)
            {
                int xi = Clamp((int)((points[i].X - xMin) / binX), 0, nX - 1);
                int yi = Clamp((int)((points[i].Y - yMin) / binY), 0, nY - 1);
                int cell = xi * nY + yi;
                if (grid[cell] >= minPts && points[i].Y < colLocalMinY[xi])
                    colLocalMinY[xi] = points[i].Y;
            }

            // ── Шаг 2c: Классификация ячеек (0=inactive, 1=brown, 2=blue, 3=red) ──
            // Классификация ОТНОСИТЕЛЬНО локального минимума колонки, не абсолютных бинов!
            var cellType = new byte[nX * nY];
            for (int xi = 0; xi < nX; xi++)
            {
                double localMinY = colLocalMinY[xi];
                if (double.IsInfinity(localMinY)) continue;  // нет активных ячеек в колонке

                for (int yi = 0; yi < nY; yi++)
                {
                    int cellIdx = xi * nY + yi;
                    if (grid[cellIdx] < minPts) continue;  // inactive = 0

                    // Вычисляем относительное расстояние от локального минимума
                    double cellYCenter = yMin + (yi + 0.5) * binY;
                    double relDist = cellYCenter - localMinY;
                    int relBin = (int)(relDist / binY);  // 0 = lowest, 1 = next, 2+ = high

                    if (relBin <= 0)
                        cellType[cellIdx] = 1;  // brown = локальный минимум
                    else if (relBin == 1)
                        cellType[cellIdx] = 2;  // blue = следующий над минимумом
                    else
                        cellType[cellIdx] = 3;  // red = высоко над минимумом
                }
            }

            // ── Шаг 2d: Горизонтальный паттерн Red → 2-5 Brown → Red → demote ──
            for (int yi = 0; yi < nY; yi++)
            {
                int xi = 0;
                while (xi < nX)
                {
                    int cellIdx = xi * nY + yi;

                    if (cellType[cellIdx] != 3)
                    {
                        xi++;
                        continue;
                    }

                    int brownStart = xi + 1;
                    int brownCount = 0;

                    while (brownStart + brownCount < nX)
                    {
                        if (cellType[(brownStart + brownCount) * nY + yi] == 1)
                            brownCount++;
                        else
                            break;
                    }

                    if (brownCount >= 2 && brownCount <= 5)
                    {
                        int afterBrownXi = brownStart + brownCount;
                        if (afterBrownXi < nX && cellType[afterBrownXi * nY + yi] == 3)
                        {
                            for (int bx = brownStart; bx < brownStart + brownCount; bx++)
                                cellType[bx * nY + yi] = 3;
                        }
                    }

                    xi = brownStart + brownCount;  // было: xi = startXi + 1 + brownCount
                                                   // startXi+1 == brownStart, результат тот же
                }
            }

            // Шаг 2e удалён: "заражение соседей" было нужно для горизонтальных бинов,
            // но с относительной классификацией оно больше не требуется и даже вредно.

            // ── Шаг 3: Фильтрация — только brown (1) и blue (2) ──────────────
            var result = new List<Vector2D>(points.Count);
            for (int i = 0; i < points.Count; i++)
            {
                byte ct = cellType[pointCells[i]];
                if (ct == 1 || ct == 2)
                    result.Add(points[i]);
            }

            // ── Debug info ───────────────────────────────────────────────────
            // keepCell восстанавливаем для совместимости с DebugInfo
            var keepCell = new bool[nX * nY];
            for (int i = 0; i < grid.Length; i++)
                keepCell[i] = grid[i] >= minPts;

            var emptyPath = new int[nX];
            for (int i = 0; i < nX; i++) emptyPath[i] = -1;

            debug = new GraphGroundDebugInfo
            {
                Grid             = grid,
                NX               = nX,
                NY               = nY,
                XMin             = xMin,
                YMin             = yMin,
                BinX             = binX,
                BinY             = binY,
                Path             = emptyPath,
                KeepMask         = keepCell,
                CellType         = cellType,
                Cols             = null,
                MaxCount         = maxCount,
                InputPointCount  = points.Count,
                OutputPointCount = result.Count,
                MinPts           = minPts
            };

            return result;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
