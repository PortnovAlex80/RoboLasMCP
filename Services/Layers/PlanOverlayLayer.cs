// Services/Layers/PlanOverlayLayer.cs
// Permanent overlay layer for displaying plan polygons on the Plan view
using System;
using System.Collections.Generic;
using System.Drawing;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;

namespace LAS_TERRAIN.Visualization
{
    /// <summary>
    /// Слой для постоянного отображения полигонов Plan view.
    /// Полигоны остаются видимыми после отрисовки.
    /// </summary>
    public sealed class PlanOverlayLayer : CadViewLayer
    {
        public static readonly Guid GUID = new Guid("{B7E9F1A3-5D4C-4A8B-9C2E-6F3D7A1B8E5C}");
        public override Guid LayerGuid => GUID;
        public override string Name => "LAS Terrain Plan Overlay";

        private readonly SelectionSet _selectionSet;
        private readonly List<ScopedPolygonRecord> _polygons = new List<ScopedPolygonRecord>();
        private readonly object _lock = new object();
        private Func<bool> _ownerIsCurrent;

        public Color PolygonFillColor { get; set; } = Color.FromArgb(40, Color.Lime);
        public Color PolygonBorderColor { get; set; } = Color.Lime;
        public Color PolygonPointColor { get; set; } = Color.Orange;
        public float BorderWidth { get; set; } = 2f;
        public float PointSize { get; set; } = 4f;

        public PlanOverlayLayer()
        {
            _selectionSet = new CrsOverlaySelectionSet(this);
        }

        public override SelectionSet SelectionSet => _selectionSet;

        /// <summary>
        /// Replaces the rendered polygons for the pinned project owner.
        /// </summary>
        internal void ReplaceFromSnapshot(ScopedPolygonOperationContext context,
            ScopedPolygonSnapshot snapshot)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (snapshot == null || snapshot.ScopeKey != context.Scope.ScopeKey)
                throw new ArgumentException("The Plan snapshot belongs to another project.", "snapshot");
            if (!context.IsCurrent())
                throw new InvalidOperationException("The Plan polygon owner changed.");
            List<ScopedPolygonRecord> records = new List<ScopedPolygonRecord>();
            foreach (ScopedPolygonRecord record in snapshot.Records)
            {
                if (record.GeometryKind != PolygonGeometryKind.Plan)
                    throw new ArgumentException("A non-Plan polygon reached the Plan overlay.", "snapshot");
                records.Add(record);
            }
            lock (_lock)
            {
                _polygons.Clear();
                _polygons.AddRange(records);
                _ownerIsCurrent = delegate { return context.IsSnapshotCurrent(snapshot); };
            }
            CadView?.Unlock();
            CadView?.Invalidate();
        }

        /// <summary>
        /// Очищает все полигоны из слоя.
        /// </summary>
        public void ClearPolygons()
        {
            lock (_lock)
            {
                _polygons.Clear();
                _ownerIsCurrent = null;
            }
            CadView?.Unlock();
            CadView?.Invalidate();
        }

        /// <summary>
        /// Возвращает количество полигонов в слое.
        /// </summary>
        public int PolygonCount
        {
            get { lock (_lock) { return _polygons.Count; } }
        }

        protected override void OnPaint(CadPen pen)
        {
            Func<bool> owner;
            lock (_lock) owner = _ownerIsCurrent;
            bool current = true;
            if (owner != null)
            {
                try { current = owner(); }
                catch (Exception) { current = false; }
            }
            List<ScopedPolygonRecord> snapshot;
            lock (_lock)
            {
                if (!current && Object.ReferenceEquals(owner, _ownerIsCurrent))
                {
                    _polygons.Clear();
                    _ownerIsCurrent = null;
                }
                snapshot = Object.ReferenceEquals(owner, _ownerIsCurrent)
                    ? new List<ScopedPolygonRecord>(_polygons)
                    : new List<ScopedPolygonRecord>();
            }

            foreach (var entry in snapshot)
            {
                DrawPolygon(pen, entry.Polygon);
            }
        }

        private void DrawPolygon(CadPen pen, IList<Vector2D> polygon)
        {
            if (polygon == null || polygon.Count < 3) return;

            int n = polygon.Count;

            // 1. Fill polygon (scanline)
            pen.Color = PolygonFillColor;
            DrawFilledPolygon(pen, polygon);

            // 2. Draw border
            pen.Color = PolygonBorderColor;
            pen.Width = BorderWidth;
            pen.BeginDraw();
            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                pen.DrawLine(polygon[i], polygon[j]);
            }
            pen.EndDraw();
            pen.Width = 1f;

            // 3. Draw vertices
            pen.Color = PolygonPointColor;
            pen.Width = PointSize;
            pen.BeginArray();
            foreach (var pt in polygon)
            {
                pen.Vertex(pt);
            }
            pen.EndArray(ArrayMode.Point);
            pen.Width = 1f;
        }

        private void DrawFilledPolygon(CadPen pen, IList<Vector2D> points)
        {
            if (points.Count < 3) return;

            double minY = double.MaxValue;
            double maxY = double.MinValue;
            foreach (var p in points)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            double height = maxY - minY;
            if (height < 0.001) return;

            int steps = Math.Min(100, Math.Max(20, (int)(height / 0.5)));
            double stepY = height / steps;

            var intersections = new List<double>();

            for (double y = minY; y <= maxY; y += stepY)
            {
                intersections.Clear();

                for (int i = 0; i < points.Count; i++)
                {
                    var p1 = points[i];
                    var p2 = points[(i + 1) % points.Count];

                    double y1 = p1.Y, y2 = p2.Y;
                    double x1 = p1.X, x2 = p2.X;

                    if (Math.Abs(y2 - y1) < 0.0001) continue;

                    if ((y1 <= y && y < y2) || (y2 <= y && y < y1))
                    {
                        double t = (y - y1) / (y2 - y1);
                        double x = x1 + t * (x2 - x1);
                        intersections.Add(x);
                    }
                }

                intersections.Sort();

                for (int i = 0; i + 1 < intersections.Count; i += 2)
                {
                    pen.DrawLine(new Vector2D(intersections[i], y), new Vector2D(intersections[i + 1], y));
                }
            }
        }

        protected override bool OnGetLimits(out BoundingBox2D lim)
        {
            lim = new BoundingBox2D(new Vector2D(0, 0), new Vector2D(0, 0));
            return false;
        }

        protected override void OnGetSnapObjects(ObjectSnapEventArgs e)
        {
            // No snap for overlay
        }
    }
}
