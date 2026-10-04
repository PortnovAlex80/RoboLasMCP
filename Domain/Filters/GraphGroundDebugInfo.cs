// Domain/Filters/GraphGroundDebugInfo.cs
// Debug data container for GraphGroundFilter visualization
using System.Collections.Generic;

namespace LAS_TERRAIN.Filters
{
    /// <summary>
    /// Диагностические данные графового фильтра для визуализации.
    /// </summary>
    public class GraphGroundDebugInfo
    {
        /// <summary>Occupancy grid — количество точек в каждой ячейке [xi * nY + yi]</summary>
        public int[] Grid;

        /// <summary>Количество колонок по X</summary>
        public int NX;

        /// <summary>Количество строк по Y</summary>
        public int NY;

        /// <summary>Минимальная координата X (смещение)</summary>
        public double XMin;

        /// <summary>Минимальная координата Y (смещение)</summary>
        public double YMin;

        /// <summary>Ширина ячейки по X (метры)</summary>
        public double BinX;

        /// <summary>Высота ячейки по Y (метры)</summary>
        public double BinY;

        /// <summary>Ground path — выбранный yi для каждого xi (-1 = колонка пуста)</summary>
        public int[] Path;

        /// <summary>Финальная маска сохранённых ячеек [xi * nY + yi]</summary>
        public bool[] KeepMask;

        /// <summary>Тип ячейки после паттерн-детекции: 0=inactive, 1=brown, 2=blue, 3=red</summary>
        public byte[] CellType;

        /// <summary>Активные ячейки per column: Cols[xi] = список активных yi</summary>
        public List<int>[] Cols;

        /// <summary>Максимальное количество точек в ячейке (для нормализации heatmap)</summary>
        public int MaxCount;

        /// <summary>Общее количество точек на входе</summary>
        public int InputPointCount;

        /// <summary>Количество точек на выходе</summary>
        public int OutputPointCount;

        /// <summary>Порог минимального количества точек для активной ячейки</summary>
        public int MinPts;
    }
}
