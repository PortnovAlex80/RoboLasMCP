// Domain/Models/CrsPolygonEntry.cs
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Models
{
    /// <summary>
    /// Запись о полигоне для удаления точек в поперечнике.
    /// </summary>
    public class CrsPolygonEntry
    {
        /// <summary>
        /// Индекс поперечника.
        /// </summary>
        public int SectionIndex { get; set; }

        /// <summary>
        /// Пикетаж (для отображения).
        /// </summary>
        public double Station { get; set; }

        /// <summary>
        /// Точки полигона в координатах поперечника (offset, z).
        /// </summary>
        public List<Vector2D> Polygon { get; set; }

        /// <summary>
        /// Толщина сечения (CrsOverlayBorder) на момент создания.
        /// </summary>
        public double Thickness { get; set; }

        /// <summary>
        /// Дата и время создания (для сортировки/отладки).
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Создаёт новую запись полигона.
        /// </summary>
        public CrsPolygonEntry()
        {
            Polygon = new List<Vector2D>();
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Создаёт копию полигона.
        /// </summary>
        public CrsPolygonEntry Clone()
        {
            var clone = new CrsPolygonEntry
            {
                SectionIndex = this.SectionIndex,
                Station = this.Station,
                Thickness = this.Thickness,
                CreatedAt = this.CreatedAt
            };
            
            if (this.Polygon != null)
            {
                foreach (var pt in this.Polygon)
                {
                    clone.Polygon.Add(new Vector2D(pt.X, pt.Y));
                }
            }
            
            return clone;
        }
    }
}
