// Domain/Models/PlanPolygonEntry.cs
using System;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Domain.Models
{
    /// <summary>
    /// Запись о полигоне для удаления точек на виде сверху (Plan view).
    /// Координаты X, Y в мировой системе (БЕZ Z!).
    /// </summary>
    public class PlanPolygonEntry
    {
        /// <summary>
        /// Точки полигона в мировых координатах (X, Y).
        /// </summary>
        public List<Vector2D> Polygon { get; set; }

        /// <summary>
        /// Дата и время создания (для сортировки/отладки).
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Создаёт новую запись полигона.
        /// </summary>
        public PlanPolygonEntry()
        {
            Polygon = new List<Vector2D>();
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Создаёт копию полигона.
        /// </summary>
        public PlanPolygonEntry Clone()
        {
            PlanPolygonEntry clone = new PlanPolygonEntry
            {
                CreatedAt = this.CreatedAt
            };

            if (this.Polygon != null)
            {
                foreach (Vector2D pt in this.Polygon)
                {
                    clone.Polygon.Add(new Vector2D(pt.X, pt.Y));
                }
            }

            return clone;
        }
    }
}
