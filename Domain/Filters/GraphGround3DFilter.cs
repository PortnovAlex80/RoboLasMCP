// Domain/Filters/GraphGround3DFilter.cs
// 3D occupancy grid filter — world-space (Vector4D), axis-aligned 1x1x1 m bins
using System;
using System.Collections.Generic;
using LAS_TERRAIN.Models;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// 3D occupancy grid filter.
    /// Классифицирует ячейки: brown(1)=локальный минимум, blue(2)=следующий ярус, red(3)=высоко.
    /// Demote: паттерн Red→2-5 Brown→Red вдоль X и Y.
    /// Фильтрация: оставляет только brown + blue.
    /// </summary>
    internal static class GraphGround3DFilter
    {
        // cell types
        private const byte INACTIVE = 0;
        private const byte BROWN    = 1;
        private const byte BLUE     = 2;
        private const byte RED      = 3;
        // The three dense arrays must fit comfortably in a 32-bit CLR host.
        private const long MaximumGridBytes = 128L * 1024L * 1024L;

        internal static List<Vector4D> Apply(List<Vector4D> points,
            GraphGround3DOptions options, Action<float> onProgress)
        {
            return Apply(points, options, onProgress, ForEachSerial);
        }

        // A synchronous scheduler keeps all three classification/demotion barriers
        // while the host chooses how the independent lines are executed.
        internal static List<Vector4D> Apply(List<Vector4D> points,
            GraphGround3DOptions options, Action<float> onProgress,
            Action<int, Action<int>> forEachIndex)
        {
            return Apply(points, options, onProgress, forEachIndex, null);
        }

        internal static List<Vector4D> Apply(List<Vector4D> points,
            GraphGround3DOptions options, Action<float> onProgress,
            Action<int, Action<int>> forEachIndex, Func<bool> isCancelled)
        {
            return ApplyWithSelection(points,options,onProgress,forEachIndex,isCancelled,null);
        }

        internal static List<Vector4D> ApplyWithSelection(List<Vector4D> points,
            GraphGround3DOptions options,Action<float> onProgress,
            Action<int,Action<int>> forEachIndex,Func<bool> isCancelled,Action<int> selected)
        {
            if (points == null || points.Count == 0)
                return new List<Vector4D>();
            if (options == null) throw new ArgumentNullException("options");
            if (forEachIndex == null) throw new ArgumentNullException("forEachIndex");
            ThrowIfCancelled(isCancelled);

            double binX  = options.BinX;
            double binY  = options.BinY;
            double binZ  = options.BinZ;
            int    minPts = options.MinPts;

            // ── Шаг 1: Bounds + Occupancy Grid ──────────────────────────
            double xMin = points[0].X, xMax = points[0].X;
            double yMin = points[0].Y, yMax = points[0].Y;
            double zMin = points[0].Z, zMax = points[0].Z;
            EnsureFinitePoint(points[0]);

            for (int i = 1; i < points.Count; i++)
            {
                if ((i & 2047) == 0) ThrowIfCancelled(isCancelled);
                double px = points[i].X;
                double py = points[i].Y;
                double pz = points[i].Z;
                EnsureFinitePoint(points[i]);
                if (px < xMin) xMin = px; else if (px > xMax) xMax = px;
                if (py < yMin) yMin = py; else if (py > yMax) yMax = py;
                if (pz < zMin) zMin = pz; else if (pz > zMax) zMax = pz;
            }

            int nX = GridDimension(xMax - xMin, binX);
            int nY = GridDimension(yMax - yMin, binY);
            int nZ = GridDimension(zMax - zMin, binZ);
            long columns = (long)nX * nY;
            if (columns > int.MaxValue || nZ > int.MaxValue / columns)
                throw new InvalidOperationException("3D ground grid is too large.");
            int cellCount = (int)(columns * nZ);
            long requiredBytes = 5L * cellCount + 8L * columns + 4L * points.Count;
            if (requiredBytes > MaximumGridBytes)
                throw new InvalidOperationException("3D ground grid exceeds the memory limit.");
            ThrowIfCancelled(isCancelled);

            // grid[xi * nY * nZ + yi * nZ + zi] — Z innermost for cache
            var grid = new int[cellCount];
            var pointCells = new int[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                if ((i & 2047) == 0) ThrowIfCancelled(isCancelled);
                int xi = Clamp((int)((points[i].X - xMin) / binX), 0, nX - 1);
                int yi = Clamp((int)((points[i].Y - yMin) / binY), 0, nY - 1);
                int zi = Clamp((int)((points[i].Z - zMin) / binZ), 0, nZ - 1);
                int cell = xi * nY * nZ + yi * nZ + zi;
                pointCells[i] = cell;
                grid[cell]++;
            }

            // ── Шаг 2: Локальный минимум Z в каждом столбце (xi, yi) ──
            var colMinZ = new double[(int)columns];
            for (int i = 0; i < colMinZ.Length; i++)
            {
                if ((i & 2047) == 0) ThrowIfCancelled(isCancelled);
                colMinZ[i] = double.PositiveInfinity;
            }

            for (int i = 0; i < points.Count; i++)
            {
                if ((i & 2047) == 0) ThrowIfCancelled(isCancelled);
                int xi = Clamp((int)((points[i].X - xMin) / binX), 0, nX - 1);
                int yi = Clamp((int)((points[i].Y - yMin) / binY), 0, nY - 1);
                int zi = Clamp((int)((points[i].Z - zMin) / binZ), 0, nZ - 1);
                int cell = xi * nY * nZ + yi * nZ + zi;
                if (grid[cell] >= minPts && points[i].Z < colMinZ[xi * nY + yi])
                    colMinZ[xi * nY + yi] = points[i].Z;
            }

            // ── Шаг 3: Классификация ячеек (parallel по xi) ──────────
            if (onProgress != null) onProgress(0.3f);
            ThrowIfCancelled(isCancelled);
            var cellType = new byte[cellCount];

            forEachIndex(nX, xi =>
            {
                int xiBase = xi * nY * nZ;
                for (int yi = 0; yi < nY; yi++)
                {
                    double localMin = colMinZ[xi * nY + yi];
                    if (double.IsInfinity(localMin)) continue;

                    int yiBase = yi * nZ;
                    for (int zi = 0; zi < nZ; zi++)
                    {
                        int cellIdx = xiBase + yiBase + zi;
                        if (grid[cellIdx] < minPts) continue;

                        double cellZCenter = zMin + (zi + 0.5) * binZ;
                        double relDist = cellZCenter - localMin;
                        int relBin = (int)(relDist / binZ);

                        if (relBin <= 0)
                            cellType[cellIdx] = BROWN;
                        else if (relBin == 1)
                            cellType[cellIdx] = BLUE;
                        else
                            cellType[cellIdx] = RED;
                    }
                }
            });
            ThrowIfCancelled(isCancelled);

            // ── Шаг 4a: Demote вдоль X (одна независимая линия на пару Z/Y) ──
            if (onProgress != null) onProgress(0.5f);
            forEachIndex(checked(nZ * nY), line =>
            {
                int zi = line / nY;
                int yi = line % nY;
                int xi = 0;
                while (xi < nX)
                {
                    int cellIdx = xi * nY * nZ + yi * nZ + zi;
                    if (cellType[cellIdx] != RED)
                    {
                        xi++;
                        continue;
                    }

                    int brownStart = xi + 1;
                    int brownCount = 0;

                    while (brownStart + brownCount < nX)
                    {
                        if (cellType[(brownStart + brownCount) * nY * nZ + yi * nZ + zi] == BROWN)
                            brownCount++;
                        else
                            break;
                    }

                    if (brownCount >= 2 && brownCount <= 5)
                    {
                        int afterBrownXi = brownStart + brownCount;
                        if (afterBrownXi < nX
                            && cellType[afterBrownXi * nY * nZ + yi * nZ + zi] == RED)
                        {
                            for (int bx = brownStart; bx < brownStart + brownCount; bx++)
                                cellType[bx * nY * nZ + yi * nZ + zi] = RED;
                        }
                    }

                    xi = brownStart + brownCount;
                }
            });
            ThrowIfCancelled(isCancelled);

            // ── Шаг 4b: Demote вдоль Y (одна независимая линия на пару Z/X) ──
            if (onProgress != null) onProgress(0.65f);
            forEachIndex(checked(nZ * nX), line =>
            {
                int zi = line / nX;
                int xi = line % nX;
                int yi = 0;
                while (yi < nY)
                {
                    int cellIdx = xi * nY * nZ + yi * nZ + zi;
                    if (cellType[cellIdx] != RED)
                    {
                        yi++;
                        continue;
                    }

                    int brownStart = yi + 1;
                    int brownCount = 0;

                    while (brownStart + brownCount < nY)
                    {
                        if (cellType[xi * nY * nZ + (brownStart + brownCount) * nZ + zi] == BROWN)
                            brownCount++;
                        else
                            break;
                    }

                    if (brownCount >= 2 && brownCount <= 5)
                    {
                        int afterBrownYi = brownStart + brownCount;
                        if (afterBrownYi < nY
                            && cellType[xi * nY * nZ + afterBrownYi * nZ + zi] == RED)
                        {
                            for (int by = brownStart; by < brownStart + brownCount; by++)
                                cellType[xi * nY * nZ + by * nZ + zi] = RED;
                        }
                    }

                    yi = brownStart + brownCount;
                }
            });
            ThrowIfCancelled(isCancelled);

            // ── Шаг 5: Фильтрация — только brown + blue ──────────────
            var result = new List<Vector4D>(points.Count);
            int filterReportEvery = Math.Max(1, points.Count / 100);
            for (int i = 0; i < points.Count; i++)
            {
                if ((i & 2047) == 0) ThrowIfCancelled(isCancelled);
                byte ct = cellType[pointCells[i]];
                if (ct == BROWN || ct == BLUE)
                {
                    result.Add(points[i]);
                    if(selected!=null)selected(i);
                }
                if (onProgress != null && (i % filterReportEvery == 0 || i == points.Count - 1))
                    onProgress(0.8f + 0.2f * ((float)(i + 1) / (float)points.Count));
            }

            return result;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private static int GridDimension(double extent, double bin)
        {
            if (Double.IsNaN(extent) || Double.IsInfinity(extent) || extent < 0 ||
                Double.IsNaN(bin) || Double.IsInfinity(bin) || bin <= 0)
                throw new InvalidOperationException("Invalid 3D ground grid coordinates or bin size.");
            double count = Math.Ceiling(extent / bin) + 1.0;
            if (Double.IsNaN(count) || Double.IsInfinity(count) || count > int.MaxValue)
                throw new InvalidOperationException("3D ground grid dimension is too large.");
            return Math.Max(1, (int)count);
        }

        private static void EnsureFinitePoint(Vector4D point)
        {
            if (Double.IsNaN(point.X) || Double.IsInfinity(point.X) ||
                Double.IsNaN(point.Y) || Double.IsInfinity(point.Y) ||
                Double.IsNaN(point.Z) || Double.IsInfinity(point.Z))
                throw new InvalidOperationException("3D ground grid contains a non-finite point.");
        }

        private static void ThrowIfCancelled(Func<bool> isCancelled)
        {
            if (isCancelled != null && isCancelled())
                throw new OperationCanceledException();
        }

        private static void ForEachSerial(int count, Action<int> body)
        {
            for (int i = 0; i < count; i++) body(i);
        }
    }
}
