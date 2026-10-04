// Automation/LasAutomationSectionVisualDtos.cs
// DTO визуальной чистки сечений (docs/MCP_SECTION_VISUAL.md): кадр сечения
// для рендера, полигон с толщиной сечения (= толщина призмы удаления),
// результаты dry-run счёта и удаления.
// Только примитивы/массивы — без типов Topomatic SDK, чтобы net48-адаптер
// сериализовал их в JSON как есть.
using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Automation
{
    /// <summary>
    /// Кадр сечения в локальных координатах: offset — поперечное смещение от оси
    /// трассы (влево отрицательное), Z — высота проекта; Weight — интенсивность
    /// 0..65535; SliceDistance — расстояние до плоскости сечения со знаком.
    /// Массивы имеют длину StoredPoints; TotalPoints — весь срез.
    /// </summary>
    public sealed class LasSectionFrame
    {
        public string Alignment { get; set; }
        public double Station { get; set; }
        public double Thickness { get; set; }
        public double LeftOffset { get; set; }
        public double RightOffset { get; set; }
        public long TotalPoints { get; set; }
        public int StoredPoints { get; set; }
        /// <summary>true — срез собран не полностью (StoredPoints &lt; TotalPoints).</summary>
        public bool Truncated { get; set; }
        public double OffsetMin { get; set; }
        public double OffsetMax { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public double WeightMin { get; set; }
        public double WeightMax { get; set; }
        public double[] Offsets { get; set; }
        public double[] Elevations { get; set; }
        public double[] Weights { get; set; }
        public double[] SliceDistances { get; set; }
    }

    /// <summary>Секция удаления: полигоны в плоскости сечения + толщина сечения.</summary>
    public sealed class LasSectionPolygonSpec
    {
        public double Station { get; set; }
        /// <summary>Полная толщина сечения, м: она же — толщина удаляемой призмы вдоль нормали.</summary>
        public double Thickness { get; set; }
        /// <summary>Полигоны [[[offset, Z], ...], ...]: 1..50 на секцию, каждый ≥ 3 вершин.</summary>
        public double[][][] Polygons { get; set; }
    }

    /// <summary>Счёт точек в призме одного полигона/секции.</summary>
    public sealed class LasSectionPolygonCount
    {
        public int Index { get; set; }
        public long Count { get; set; }
    }

    /// <summary>Результат las_preview_section_polygon: сухой прогон удаления.</summary>
    public sealed class LasSectionPreviewResult
    {
        public string Alignment { get; set; }
        public double Station { get; set; }
        public double Thickness { get; set; }
        public int PolygonCount { get; set; }
        /// <summary>Точек в срезе толщиной Thickness (вся область DtmSize).</summary>
        public long SlicePoints { get; set; }
        /// <summary>Точек в призмах полигонов (по первому совпадению).</summary>
        public long MatchedPoints { get; set; }
        public List<LasSectionPolygonCount> Polygons { get; set; }

        public LasSectionPreviewResult()
        {
            Polygons = new List<LasSectionPolygonCount>();
        }
    }

    /// <summary>Результат las_delete_section_points.</summary>
    public sealed class LasSectionDeleteResult
    {
        public string OutputPath { get; set; }
        public int Sections { get; set; }
        public long Deleted { get; set; }
        public long Kept { get; set; }
        /// <summary>Удалено точек призмой каждой секции (по первому совпадению).</summary>
        public List<LasSectionPolygonCount> PerSection { get; set; }
        public bool Published { get; set; }
        public bool RgbPreserved { get; set; }
        public bool Cancelled { get; set; }
        public double ElapsedSeconds { get; set; }
        public string Note { get; set; }

        public LasSectionDeleteResult()
        {
            PerSection = new List<LasSectionPolygonCount>();
        }
    }
}
