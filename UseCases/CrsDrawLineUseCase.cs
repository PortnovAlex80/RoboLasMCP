using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Design;
using Topomatic.Cad.View.Hints;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    /// <summary>
    /// Интерактивная команда рисования полигона в окне поперечника.
    /// Позволяет пользователю указывать точки мышкой для построения замкнутого полигона.
    /// Автоматически замыкает полигон при клике рядом с первой точкой.
    /// </summary>
    [SectionCmd("crs_draw_line")]
    public class CrsDrawLineUseCase : ISectionUseCase
    {
        public string Name => "crs_draw_line";

        // Snap distance in world units (метры)
        private const double SnapDistance = 0.5;

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;

            // Получаем окно поперечника
            var crossCv = CadViewDesignUtils.OnCadViewSelect(CadViewDesignUtils.CrossSectionCadViewAlias);
            if (crossCv == null)
            {
                MessageDlg.Show("Окно поперечных профилей не найдено.");
                return;
            }

            Alignment capturedAlignment;
            CrsDrawLineContext drawingContext;
            ScopedPolygonOperationContext source;
            try
            {
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    capturedAlignment = receiver.Alignment;
                    if (capturedAlignment == null) throw new InvalidOperationException("Сделайте трассу активной.");
                    var model = PluginCoreOps.FindModel(capturedAlignment);
                    var host = ApplicationHost.Current;
                    if (model == null || host == null || host.ActiveProject == null ||
                        !Object.ReferenceEquals(model.Project, host.ActiveProject))
                        throw new InvalidOperationException("Не удалось определить проект активной трассы.");

                    var sections = capturedAlignment.Corridor.Sections;
                    uint[] sectionIds = new uint[sections.Count];
                    double[] stations = new double[sections.Count];
                    for (int i = 0; i < sections.Count; i++)
                    {
                        sectionIds[i] = sections[i].Id;
                        stations[i] = sections[i].Station;
                    }
                    drawingContext = new CrsDrawLineContext(capturedAlignment, model,
                        host.ActiveProject, AlignmentValueConverter.GetId(capturedAlignment),
                        env.CadView, crossCv, host.ActiveDocument, receiver.Manager.CurrentSection,
                        sectionIds, stations);
                }
                source = ScopedPolygonOperationContext.Capture(env.CadView,
                    PolygonGeometryKind.Crs);
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Не удалось зафиксировать трассу и сечение: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            if (source == null)
            {
                MessageDlg.Show("Не удалось определить путь к проекту.");
                return;
            }

            ScopedPolygonSnapshot polygonSnapshot;
            try
            {
                if (!source.TryRead(out polygonSnapshot)) return;
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[CrsDrawLine] Init error: " + ex.Message);
                MessageDlg.Show("Ошибка загрузки полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            // One interactive command retains the border setting used when it began.
            double capturedThickness = RuntimeConfig.CrsOverlayBorder;

            // Основной цикл рисования полигонов
            bool continueDrawing = true;
            while (continueDrawing)
            {
                if (!IsContextCurrent(drawingContext, source, env, crossCv))
                {
                    ShowChangedContext();
                    return;
                }
                var positions = new List<Vector2D>();
                bool addMore = DrawPolygon(env, crossCv, positions, drawingContext,
                    source, capturedThickness, ref polygonSnapshot);

                if (addMore)
                {
                    // Пользователь хочет ещё полигон - продолжаем
                    continueDrawing = true;
                }
                else
                {
                    // Пользователь завершил
                    continueDrawing = false;
                }
            }
        }

        private static bool IsContextCurrent(CrsDrawLineContext context,
            ScopedPolygonOperationContext source, SectionEnv env, CadView crossCv)
        {
            try
            {
                var host = ApplicationHost.Current;
                if (host == null || host.ActiveProject == null || env.CadView == null ||
                    crossCv == null) return false;
                using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                {
                    var alignment = receiver.Alignment;
                    if (alignment == null) return false;
                    var model = PluginCoreOps.FindModel(alignment);
                    if (model == null || !Object.ReferenceEquals(model.Project, host.ActiveProject))
                        return false;
                    var sections = alignment.Corridor.Sections;
                    return source != null && source.MatchesCapturedSource(alignment,
                        LidarBufferService.CollectBuffers(alignment)) &&
                        context.IsCurrent(alignment, model, host.ActiveProject,
                        AlignmentValueConverter.GetId(alignment), env.CadView, crossCv,
                        host.ActiveDocument,
                        !env.CadView.IsDisposed && env.CadView.IsHandleCreated &&
                        !crossCv.IsDisposed && crossCv.IsHandleCreated,
                        receiver.Manager.CurrentSection, sections.Count,
                        delegate(int i) { return sections[i].Id; },
                        delegate(int i) { return sections[i].Station; });
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void ShowChangedContext()
        {
            MessageDlg.Show("Трасса, проект, окно или сечения изменились во время рисования. Полигон не сохранён.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        private bool DrawPolygon(SectionEnv env, CadView crossCv, List<Vector2D> positions,
            CrsDrawLineContext drawingContext, ScopedPolygonOperationContext source,
            double capturedThickness, ref ScopedPolygonSnapshot polygonSnapshot)
        {
            // Локальная переменная для замыкания (вместо ref параметра)
            bool isPolygonClosed = false;

            // Делегат для динамической отрисовки
            DrawCursorEvent dynamicDraw = delegate(CadPen pen, Vector3D vertex)
            {
                if (positions.Count == 0) return;

                var mousePos = vertex.Pos;
                bool nearFirstPoint = positions.Count >= 3 && IsNearPoint(mousePos, positions[0], SnapDistance);

                pen.BeginDraw();
                try
                {
                    // 1. Draw polygon fill (if >= 3 points) - scanline fill
                    if (positions.Count >= 3)
                    {
                        var fillPoints = new List<Vector2D>(positions);
                        if (!isPolygonClosed)
                            fillPoints.Add(mousePos); // Add mouse position for preview

                        // Simple scanline fill - draw horizontal lines
                        pen.Color = Color.FromArgb(60, Color.Lime);
                        DrawFilledPolygon(pen, fillPoints);
                    }

                    // 2. Draw polygon outline
                    pen.Color = Color.Lime;
                    pen.Width = 2f;

                    // Draw lines between points
                    for (int i = 1; i < positions.Count; i++)
                    {
                        pen.DrawLine(positions[i - 1], positions[i]);
                    }

                    // Draw line to mouse position (or close to first point)
                    if (!isPolygonClosed)
                    {
                        if (nearFirstPoint && positions.Count >= 3)
                        {
                            // Snap to first point - draw closing line
                            pen.DrawLine(positions[positions.Count - 1], positions[0]);
                        }
                        else
                        {
                            // Draw rubber band to mouse
                            pen.DrawLine(positions[positions.Count - 1], mousePos);
                        }
                    }

                    pen.Width = 1f;

                    // 3. Draw points
                    pen.Color = Color.Orange;
                    pen.Width = 4f;
                    pen.BeginArray();
                    foreach (var p in positions)
                    {
                        pen.Vertex(p);
                    }
                    pen.EndArray(ArrayMode.Point);
                    pen.Width = 1f;

                    // 4. Highlight first point when near (for snapping)
                    if (nearFirstPoint && positions.Count >= 3)
                    {
                        pen.Color = Color.Yellow;
                        pen.Width = 8f;
                        pen.BeginArray();
                        pen.Vertex(positions[0]);
                        pen.EndArray(ArrayMode.Point);
                        pen.Width = 1f;
                    }
                }
                finally
                {
                    pen.EndDraw();
                }
            };

            // Подписываемся на событие отрисовки
            crossCv.DynamicDraw += dynamicDraw;
            try
            {
                Vector3D pos;
                string prompt = "Укажите первую точку полигона";

                // Просим пользователя указать точки
                while (CadCursors.GetPoint(crossCv, out pos, prompt))
                {
                    var mousePos = pos.Pos;

                    // Check if clicking near first point (to close polygon)
                    if (positions.Count >= 3 && IsNearPoint(mousePos, positions[0], SnapDistance))
                    {
                        // Close polygon
                        isPolygonClosed = true;
                        break;
                    }

                    positions.Add(mousePos);

                    // Update prompt
                    if (positions.Count == 1)
                        prompt = "Укажите следующую точку (клик рядом с первой для замыкания)";
                    else if (positions.Count == 2)
                        prompt = "Укажите следующую точку (минимум 3 для полигона)";
                    else
                        prompt = string.Format("Точек: {0} | Клик рядом с первой точкой для замыкания", positions.Count);
                }

                // Result
                if (positions.Count >= 3)
                {
                    // Ensure polygon is closed
                    if (!isPolygonClosed)
                    {
                        // Auto-close if user pressed Enter/Esc
                        positions.Add(positions[0]); // Close to first point
                    }

                    // Calculate area
                    double area = CalculatePolygonArea(positions);

                    // Show 3-button dialog:
                    // Yes = "Удалить" (save to collection and finish)
                    // No = "Ещё полигон" (save to collection and continue)
                    // Cancel = "Отмена" (discard polygon)
                    var result = System.Windows.Forms.MessageBox.Show(
                        string.Format(
                            "Полигон создан!\nТочек: {0}\nПлощадь: {1:F2} кв.м\n\nДА = Сохранить и завершить\nНЕТ = Ещё полигон\nОТМЕНА = Отменить",
                            positions.Count,
                            area),
                        "Сохранение полигона",
                        System.Windows.Forms.MessageBoxButtons.YesNoCancel,
                        System.Windows.Forms.MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes || result == System.Windows.Forms.DialogResult.No)
                    {
                        if (!IsContextCurrent(drawingContext, source, env, crossCv))
                        {
                            ShowChangedContext();
                            return false;
                        }
                        // Commit to the captured project and alignment scope.
                        try
                        {
                            var records = new List<ScopedPolygonRecord>(polygonSnapshot.Records);
                            records.Add(ScopedPolygonRecord.Crs(DateTime.Now, positions,
                                drawingContext.SectionId, drawingContext.SectionStation,
                                capturedThickness));
                            polygonSnapshot = source.Commit(polygonSnapshot, records);
                            int polygonCount = polygonSnapshot.Records.Count;

                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                // "Удалить" - save and finish
                                MessageDlg.Show(
                                    string.Format("Полигон сохранён!\nВсего полигонов: {0}\n\nТеперь выполните команду crs_delete_points для удаления точек.", polygonCount),
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Information);
                            }
                            else
                            {
                                // "Ещё полигон" - save and continue
                                MessageDlg.Show(
                                    string.Format("Полигон сохранён!\nВсего полигонов: {0}\n\nРисуйте следующий полигон.", polygonCount),
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Information);
                                // Continue drawing
                                return true;
                            }
                        }
                        catch (System.Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine("[CrsDrawLine] Error saving polygon: " + ex.Message);
                            MessageDlg.Show("Ошибка сохранения полигона: " + ex.Message,
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Error);
                        }
                    }
                    // else Cancel - polygon discarded, return false
                }
                else if (positions.Count > 0)
                {
                    MessageDlg.Show(string.Format("Собрано точек: {0} (минимум 3 для полигона)", positions.Count),
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            finally
            {
                // Отписываемся от события отрисовки
                crossCv.DynamicDraw -= dynamicDraw;
            }

            return false;
        }

        /// <summary>
        /// Проверяет, находится ли точка рядом с целевой точкой.
        /// </summary>
        private bool IsNearPoint(Vector2D point, Vector2D target, double distance)
        {
            double dx = point.X - target.X;
            double dy = point.Y - target.Y;
            return (dx * dx + dy * dy) <= (distance * distance);
        }

        /// <summary>
        /// Вычисляет площадь полигона по формуле шнуровки (Shoelace formula).
        /// </summary>
        private double CalculatePolygonArea(List<Vector2D> points)
        {
            if (points.Count < 3) return 0;

            double area = 0;
            int n = points.Count;

            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += points[i].X * points[j].Y;
                area -= points[j].X * points[i].Y;
            }

            return System.Math.Abs(area) / 2.0;
        }

        /// <summary>
        /// Заливает полигон горизонтальными линиями (scanline fill).
        /// Внимание: должен вызываться внутри BeginDraw/EndDraw!
        /// </summary>
        private void DrawFilledPolygon(CadPen pen, List<Vector2D> points)
        {
            if (points.Count < 3) return;

            // Находим границы по Y
            double minY = double.MaxValue;
            double maxY = double.MinValue;
            foreach (var p in points)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            // Шаг сканирования (адаптивный)
            double stepY;
            if (!ScanlineFillPlanner.TryPlan(minY, maxY, 0.1, out stepY))
                return;

            var intersections = new List<double>();

            for (double y = minY; y <= maxY; y += stepY)
            {
                intersections.Clear();

                // Находим пересечения со всеми рёбрами
                for (int i = 0; i < points.Count; i++)
                {
                    var p1 = points[i];
                    var p2 = points[(i + 1) % points.Count];

                    double y1 = p1.Y, y2 = p2.Y;
                    double x1 = p1.X, x2 = p2.X;

                    // Пропускаем горизонтальные рёбра
                    if (System.Math.Abs(y2 - y1) < 0.0001) continue;

                    // Проверяем, пересекает ли ребро линию y
                    if ((y1 <= y && y < y2) || (y2 <= y && y < y1))
                    {
                        // Находим X пересечения
                        double t = (y - y1) / (y2 - y1);
                        double x = x1 + t * (x2 - x1);
                        intersections.Add(x);
                    }
                }

                // Сортируем пересечения
                intersections.Sort();

                // Рисуем линии между парами пересечений
                for (int i = 0; i + 1 < intersections.Count; i += 2)
                {
                    pen.DrawLine(new Vector2D(intersections[i], y), new Vector2D(intersections[i + 1], y));
                }
            }
        }
    }

}
