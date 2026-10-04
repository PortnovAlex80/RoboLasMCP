// Mcp/SectionImageRenderer.cs
// GDI+ рендер кадра сечения для визуальной чистки (docs/MCP_SECTION_VISUAL.md):
// сетка с подписями, оси, окраска точек (intensity/z/slice_distance), полигоны,
// заголовок. Только System.Drawing — без JSON-зависимостей; каталог под PNG
// создаёт тул, а не рендер. Калибровка ответа: x = PlotLeftPx + (offset -
// OffsetFrom) * PixelsPerMeterX; y = PlotTopPx + (ZTo - z) * PixelsPerMeterY.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using LAS_TERRAIN.Automation;

namespace LAS_TERRAIN.Mcp
{
    /// <summary>Параметры рендера кадра сечения; default-ы как у las_render_section.</summary>
    internal sealed class SectionImageOptions
    {
        internal int WidthPx = 2400;
        internal int HeightPx = 1400;
        internal string ColorBy = "intensity";
        internal int PointPx = 2;
        internal string ScaleMode = "fit";
        internal double? ZMin;
        internal double? ZMax;
        internal double? GridStep;
        /// <summary>Вторая строка заголовка (null — строки нет).</summary>
        internal string Title = null;
    }

    /// <summary>Калибровка готового PNG: границы в метрах, plot-прямоугольник, пиксели/метр.</summary>
    internal sealed class SectionImageInfo
    {
        internal string Path;
        internal int WidthPx;
        internal int HeightPx;
        internal int PlotLeftPx;
        internal int PlotTopPx;
        internal int PlotWidthPx;
        internal int PlotHeightPx;
        internal double OffsetFrom;
        internal double OffsetTo;
        internal double ZFrom;
        internal double ZTo;
        internal double PixelsPerMeterX;
        internal double PixelsPerMeterY;
        internal double GridStepOffset;
        internal double GridStepZ;
        internal string ColorBy;
        internal double ColorMin;
        internal double ColorMax;
    }

    internal static class SectionImageRenderer
    {
        private static readonly double[] NoValues = new double[0];

        internal static SectionImageInfo Render(LasSectionFrame frame, IList<double[][]> polygons,
            SectionImageOptions options, string pngPath)
        {
            if (options == null) throw new ArgumentNullException("options");
            if (string.IsNullOrEmpty(pngPath)) throw new ArgumentException("pngPath обязателен.", "pngPath");
            if (frame == null) frame = new LasSectionFrame();

            double[] offsets = frame.Offsets ?? NoValues;
            double[] elevations = frame.Elevations ?? NoValues;
            double[] weights = frame.Weights ?? NoValues;
            double[] sliceDistances = frame.SliceDistances ?? NoValues;
            int stored = Math.Min(frame.StoredPoints, Math.Min(offsets.Length, elevations.Length));
            if (stored < 0) stored = 0;

            // ── Границы кадра: сохранённые точки ∪ вершины полигонов, padding 2% по каждой оси ──
            double offsetFrom, offsetTo, zFrom, zTo;
            if (stored == 0 && !HasVertices(polygons))
            {
                offsetFrom = -Math.Abs(frame.LeftOffset);
                offsetTo = Math.Abs(frame.RightOffset);
                zFrom = 0.0;
                zTo = 1.0;
                if (offsetTo - offsetFrom <= 1e-9) { offsetFrom = -10.0; offsetTo = 10.0; }
            }
            else
            {
                double minO = double.PositiveInfinity, maxO = double.NegativeInfinity;
                double minZ = double.PositiveInfinity, maxZ = double.NegativeInfinity;
                for (int i = 0; i < stored; i++)
                {
                    if (offsets[i] < minO) minO = offsets[i];
                    if (offsets[i] > maxO) maxO = offsets[i];
                    if (elevations[i] < minZ) minZ = elevations[i];
                    if (elevations[i] > maxZ) maxZ = elevations[i];
                }
                CollectPolygonBounds(polygons, ref minO, ref maxO, ref minZ, ref maxZ);
                double padX = (maxO - minO) * 0.02;
                if (padX <= 0) padX = 0.5;
                double padZ = (maxZ - minZ) * 0.02;
                if (padZ <= 0) padZ = 0.5;
                offsetFrom = minO - padX;
                offsetTo = maxO + padX;
                zFrom = minZ - padZ;
                zTo = maxZ + padZ;
            }
            // z_min/z_max из options сужают/расширяют кадр по высоте (клампинг границ)
            if (options.ZMin.HasValue || options.ZMax.HasValue)
            {
                double newFrom = options.ZMin.HasValue ? options.ZMin.Value : zFrom;
                double newTo = options.ZMax.HasValue ? options.ZMax.Value : zTo;
                if (newTo - newFrom > 1e-9) { zFrom = newFrom; zTo = newTo; }
            }

            // ── Компоновка plot-области и масштабы ──
            int width = options.WidthPx;
            int height = options.HeightPx;
            int leftMargin = 84, rightMargin = 28;
            int topMargin = options.Title != null ? 100 : 78;
            int bottomMargin = 64;
            double availW = width - leftMargin - rightMargin;
            double availH = height - topMargin - bottomMargin;
            if (availW < 40) { leftMargin = 10; rightMargin = 4; availW = Math.Max(width - 14, 10); }
            if (availH < 40) { topMargin = 30; bottomMargin = 20; availH = Math.Max(height - 50, 10); }
            double spanX = offsetTo - offsetFrom;
            if (spanX <= 1e-9) { offsetFrom -= 0.5; offsetTo += 0.5; spanX = 1.0; }
            double spanZ = zTo - zFrom;
            if (spanZ <= 1e-9) { zFrom -= 0.5; zTo += 0.5; spanZ = 1.0; }
            double ppmX, ppmY;
            if (options.ScaleMode == "equal")
            {
                double ppm = Math.Min(availW / spanX, availH / spanZ);
                ppmX = ppm;
                ppmY = ppm;
            }
            else
            {
                ppmX = availW / spanX;
                ppmY = availH / spanZ;
            }
            double plotW = spanX * ppmX;
            double plotH = spanZ * ppmY;
            double plotL = leftMargin + (availW - plotW) / 2.0;
            double plotT = topMargin + (availH - plotH) / 2.0;
            double stepX = options.GridStep.HasValue && options.GridStep.Value > 0
                ? options.GridStep.Value : NiceStep(spanX);
            double stepZ = options.GridStep.HasValue && options.GridStep.Value > 0
                ? options.GridStep.Value : NiceStep(spanZ);

            // ── Диапазон окраски ──
            double colorMin, colorMax;
            if (options.ColorBy == "z") { colorMin = frame.ZMin; colorMax = frame.ZMax; }
            else if (options.ColorBy == "slice_distance")
            { colorMin = -frame.Thickness / 2.0; colorMax = frame.Thickness / 2.0; }
            else { colorMin = frame.WeightMin; colorMax = frame.WeightMax; }
            if (double.IsNaN(colorMin) || double.IsNaN(colorMax) || colorMax - colorMin <= 0)
                colorMax = colorMin + 1.0;

            SectionImageInfo info = new SectionImageInfo();
            info.Path = pngPath;
            info.WidthPx = width;
            info.HeightPx = height;
            info.PlotLeftPx = (int)Math.Round(plotL);
            info.PlotTopPx = (int)Math.Round(plotT);
            info.PlotWidthPx = (int)Math.Round(plotW);
            info.PlotHeightPx = (int)Math.Round(plotH);
            info.OffsetFrom = offsetFrom;
            info.OffsetTo = offsetTo;
            info.ZFrom = zFrom;
            info.ZTo = zTo;
            info.PixelsPerMeterX = ppmX;
            info.PixelsPerMeterY = ppmY;
            info.GridStepOffset = stepX;
            info.GridStepZ = stepZ;
            info.ColorBy = options.ColorBy;
            info.ColorMin = colorMin;
            info.ColorMax = colorMax;

            Bitmap bitmap = null;
            Graphics graphics = null;
            Font labelFont = null;
            Font titleFont = null;
            Font subtitleFont = null;
            try
            {
                bitmap = new Bitmap(width, height);
                graphics = Graphics.FromImage(bitmap);
                graphics.Clear(Color.White);
                labelFont = new Font("Arial", 9f);
                titleFont = new Font("Arial", 13f, FontStyle.Bold);
                subtitleFont = new Font("Arial", 10.5f);

                // Заголовок: строка 1 — всегда, строка 2 — options.Title (preview подставляет полигоны/глубину)
                using (StringFormat center = new StringFormat())
                {
                    center.Alignment = StringAlignment.Center;
                    string header = string.Format(CultureInfo.InvariantCulture,
                        "Сечение ПК {0:F1} м — {1}; срез ±{2:F2} м; точек: {3}",
                        frame.Station, frame.Alignment ?? "", frame.Thickness / 2.0, frame.TotalPoints);
                    graphics.DrawString(header, titleFont, Brushes.Black,
                        new RectangleF(0, 8, width, 30), center);
                    if (options.Title != null)
                        graphics.DrawString(options.Title, subtitleFont, Brushes.DimGray,
                            new RectangleF(0, 40, width, 24), center);
                }

                // Сетка и оси — со сглаживанием
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawGrid(graphics, labelFont, plotL, plotT, plotW, plotH,
                    offsetFrom, offsetTo, zFrom, zTo, ppmX, ppmY, stepX, stepZ);

                // Точки — без сглаживания, клип по plot-прямоугольнику, вне канвы не рисуем
                if (stored > 0)
                {
                    graphics.SmoothingMode = SmoothingMode.None;
                    graphics.SetClip(new RectangleF((float)plotL, (float)plotT, (float)plotW, (float)plotH));
                    DrawPoints(graphics, offsets, elevations, weights, sliceDistances, stored,
                        options.ColorBy, options.PointPx, plotL, plotT, offsetFrom, zTo, ppmX, ppmY,
                        frame.WeightMin, frame.WeightMax, frame.ZMin, frame.ZMax, frame.Thickness,
                        width, height);
                    graphics.ResetClip();
                }
                else
                {
                    using (StringFormat center = new StringFormat())
                    using (SolidBrush emptyBrush = new SolidBrush(Color.FromArgb(190, 30, 30)))
                    {
                        center.Alignment = StringAlignment.Center;
                        center.LineAlignment = StringAlignment.Center;
                        graphics.DrawString("В срезе нет точек", titleFont, emptyBrush,
                            new RectangleF((float)plotL, (float)plotT, (float)plotW, (float)plotH), center);
                    }
                }

                // Полигоны — со сглаживанием, поверх точек; клип берёт на себя GDI
                if (polygons != null && polygons.Count > 0)
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    DrawPolygons(graphics, polygons, plotL, plotT, offsetFrom, zTo, ppmX, ppmY);
                }

                bitmap.Save(pngPath, ImageFormat.Png);
            }
            finally
            {
                if (graphics != null) graphics.Dispose();
                if (bitmap != null) bitmap.Dispose();
                if (labelFont != null) labelFont.Dispose();
                if (titleFont != null) titleFont.Dispose();
                if (subtitleFont != null) subtitleFont.Dispose();
            }
            return info;
        }

        private static void DrawGrid(Graphics g, Font labelFont, double plotL, double plotT,
            double plotW, double plotH, double offsetFrom, double offsetTo, double zFrom, double zTo,
            double ppmX, double ppmY, double stepX, double stepZ)
        {
            double plotB = plotT + plotH;
            string formatX = stepX < 0.95 ? "F1" : "F0";
            string formatZ = stepZ < 0.95 ? "F1" : "F0";
            using (Pen gridPen = new Pen(Color.FromArgb(210, 220, 230), 1f))
            using (Pen zeroPen = new Pen(Color.FromArgb(150, 160, 170), 1.6f))
            using (Pen framePen = new Pen(Color.FromArgb(70, 70, 70), 1.4f))
            using (StringFormat center = new StringFormat())
            using (StringFormat far = new StringFormat())
            using (StringFormat near = new StringFormat())
            {
                center.Alignment = StringAlignment.Center;
                far.Alignment = StringAlignment.Far;
                far.LineAlignment = StringAlignment.Center;
                // Вертикали по offset, подписи снизу; ось offset=0 чуть темнее
                int kFrom = (int)Math.Ceiling(offsetFrom / stepX - 1e-9);
                int kTo = (int)Math.Floor(offsetTo / stepX + 1e-9);
                for (int k = kFrom; k <= kTo; k++)
                {
                    double v = k * stepX;
                    float x = (float)(plotL + (v - offsetFrom) * ppmX);
                    g.DrawLine(Math.Abs(v) < stepX * 1e-6 ? zeroPen : gridPen,
                        x, (float)plotT, x, (float)plotB);
                    g.DrawString(v.ToString(formatX, CultureInfo.InvariantCulture), labelFont,
                        Brushes.DimGray, new RectangleF(x - 40f, (float)plotB + 4f, 80f, 16f), center);
                }
                // Горизонтали по Z, подписи слева
                kFrom = (int)Math.Ceiling(zFrom / stepZ - 1e-9);
                kTo = (int)Math.Floor(zTo / stepZ + 1e-9);
                for (int k = kFrom; k <= kTo; k++)
                {
                    double v = k * stepZ;
                    float y = (float)(plotT + (zTo - v) * ppmY);
                    g.DrawLine(gridPen, (float)plotL, y, (float)(plotL + plotW), y);
                    g.DrawString(v.ToString(formatZ, CultureInfo.InvariantCulture), labelFont,
                        Brushes.DimGray, new RectangleF((float)plotL - 74f, y - 8f, 68f, 16f), far);
                }
                g.DrawRectangle(framePen, (float)plotL, (float)plotT, (float)plotW, (float)plotH);
                // Подписи осей: offset — снизу по центру, Z — сверху слева над осью
                g.DrawString("Offset, м (минус — слева от оси)", labelFont, Brushes.Black,
                    new RectangleF((float)plotL, (float)plotB + 24f, (float)plotW, 18f), center);
                g.DrawString("Z, м", labelFont, Brushes.Black,
                    new RectangleF((float)plotL - 74f, (float)plotT - 20f, 90f, 16f), near);
            }
        }

        private static void DrawPoints(Graphics g, double[] offsets, double[] elevations,
            double[] weights, double[] sliceDistances, int stored, string colorBy, int pointPx,
            double plotL, double plotT, double offsetFrom, double zTo, double ppmX, double ppmY,
            double weightMin, double weightMax, double zMin, double zMax, double thickness,
            int canvasW, int canvasH)
        {
            int half = pointPx / 2;
            SolidBrush brush = null;
            Color last = Color.FromArgb(0, 0, 0, 0);
            try
            {
                for (int i = 0; i < stored; i++)
                {
                    double x = plotL + (offsets[i] - offsetFrom) * ppmX;
                    double y = plotT + (zTo - elevations[i]) * ppmY;
                    if (x < -pointPx || y < -pointPx || x > canvasW + pointPx || y > canvasH + pointPx)
                        continue;
                    double w = i < weights.Length ? weights[i] : weightMin;
                    double d = i < sliceDistances.Length ? sliceDistances[i] : 0.0;
                    Color color = PointColor(colorBy, w, elevations[i], d, thickness,
                        weightMin, weightMax, zMin, zMax);
                    if (brush == null || color.ToArgb() != last.ToArgb())
                    {
                        if (brush != null) brush.Dispose();
                        brush = new SolidBrush(color);
                        last = color;
                    }
                    g.FillRectangle(brush, (float)(x - half), (float)(y - half),
                        (float)pointPx, (float)pointPx);
                }
            }
            finally
            {
                if (brush != null) brush.Dispose();
            }
        }

        private static void DrawPolygons(Graphics g, IList<double[][]> polygons, double plotL,
            double plotT, double offsetFrom, double zTo, double ppmX, double ppmY)
        {
            using (SolidBrush fill = new SolidBrush(Color.FromArgb(50, 200, 30, 30)))
            using (Pen outline = new Pen(Color.FromArgb(230, 180, 20, 20), 3f))
            using (SolidBrush vertex = new SolidBrush(Color.FromArgb(160, 30, 30)))
            {
                for (int p = 0; p < polygons.Count; p++)
                {
                    double[][] polygon = polygons[p];
                    if (polygon == null || polygon.Length == 0) continue;
                    PointF[] points = new PointF[polygon.Length];
                    bool valid = true;
                    for (int i = 0; i < polygon.Length; i++)
                    {
                        double[] v = polygon[i];
                        if (v == null || v.Length < 2) { valid = false; break; }
                        points[i] = new PointF(
                            (float)(plotL + (v[0] - offsetFrom) * ppmX),
                            (float)(plotT + (zTo - v[1]) * ppmY));
                    }
                    if (!valid) continue;
                    if (points.Length >= 3)
                    {
                        using (GraphicsPath path = new GraphicsPath())
                        {
                            path.AddPolygon(points);
                            g.FillPath(fill, path);
                            g.DrawPath(outline, path);
                        }
                    }
                    for (int i = 0; i < points.Length; i++)
                        g.FillEllipse(vertex, points[i].X - 5f, points[i].Y - 5f, 10f, 10f);
                }
            }
        }

        private static Color PointColor(string colorBy, double weight, double z, double sliceDistance,
            double thickness, double weightMin, double weightMax, double zMin, double zMax)
        {
            if (colorBy == "z")
                return Spectrum(Normalized(z, zMin, zMax));
            if (colorBy == "slice_distance")
            {
                double half = thickness / 2.0;
                if (double.IsNaN(half) || half <= 0) half = 1.0;
                return Spectrum(Normalized(Math.Abs(sliceDistance) / half, 0.0, 1.0));
            }
            // intensity: светло-серый (220) при минимуме → чёрный при максимуме
            double t = Normalized(weight, weightMin, weightMax);
            int gray = (int)Math.Round(220.0 * (1.0 - t));
            return Color.FromArgb(gray, gray, gray);
        }

        private static double Normalized(double value, double min, double max)
        {
            double span = max - min;
            if (double.IsNaN(span) || span <= 0) span = 1.0;
            double t = (value - min) / span;
            if (t < 0.0) t = 0.0;
            if (t > 1.0) t = 1.0;
            return t;
        }

        /// <summary>Спектр: синий (t=0) → красный (t=1), HSV вручную.</summary>
        private static Color Spectrum(double t)
        {
            return Hsv(240.0 * (1.0 - t), 1.0, 1.0);
        }

        private static Color Hsv(double hue, double saturation, double value)
        {
            double c = value * saturation;
            double hp = hue / 60.0;
            double x = c * (1.0 - Math.Abs(hp % 2.0 - 1.0));
            double r = 0.0, g = 0.0, b = 0.0;
            if (hp < 1.0) { r = c; g = x; }
            else if (hp < 2.0) { r = x; g = c; }
            else if (hp < 3.0) { g = c; b = x; }
            else if (hp < 4.0) { g = x; b = c; }
            else if (hp < 5.0) { r = x; b = c; }
            else { r = c; b = x; }
            double m = value - c;
            return Color.FromArgb((int)Math.Round((r + m) * 255.0),
                (int)Math.Round((g + m) * 255.0), (int)Math.Round((b + m) * 255.0));
        }

        /// <summary>Шаг сетки 1/2/5×10^k: целевая плотность 16 линий, гарантированный диапазон 8..25.</summary>
        private static double NiceStep(double span)
        {
            double raw = span / 16.0;
            if (double.IsNaN(raw) || raw <= 0) return 1.0;
            double magnitude = Math.Pow(10.0, Math.Floor(Math.Log10(raw)));
            double norm = raw / magnitude;
            double factor = norm < 1.5 ? 1.0 : norm < 3.0 ? 2.0 : norm < 7.0 ? 5.0 : 10.0;
            double step = factor * magnitude;
            if (double.IsNaN(step) || step <= 0 || double.IsInfinity(step)) return 1.0;
            return step;
        }

        private static bool HasVertices(IList<double[][]> polygons)
        {
            if (polygons == null) return false;
            for (int p = 0; p < polygons.Count; p++)
            {
                double[][] polygon = polygons[p];
                if (polygon != null && polygon.Length > 0) return true;
            }
            return false;
        }

        private static void CollectPolygonBounds(IList<double[][]> polygons,
            ref double minO, ref double maxO, ref double minZ, ref double maxZ)
        {
            if (polygons == null) return;
            for (int p = 0; p < polygons.Count; p++)
            {
                double[][] polygon = polygons[p];
                if (polygon == null) continue;
                for (int i = 0; i < polygon.Length; i++)
                {
                    double[] v = polygon[i];
                    if (v == null || v.Length < 2) continue;
                    if (v[0] < minO) minO = v[0];
                    if (v[0] > maxO) maxO = v[0];
                    if (v[1] < minZ) minZ = v[1];
                    if (v[1] > maxZ) maxZ = v[1];
                }
            }
        }
    }
}
