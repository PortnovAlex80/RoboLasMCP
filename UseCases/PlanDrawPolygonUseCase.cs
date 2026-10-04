// UseCases/PlanDrawPolygonUseCase.cs
// Интерактивная команда рисования полигона на виде сверху (Plan view)
using LAS_TERRAIN.Domain.Models;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Domain.Service;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Visualization;
using System;
using System.Collections.Generic;
using System.Drawing;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Hints;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    /// <summary>
    /// Интерактивная команда рисования полигона в окне Плана (вид сверху).
    /// Позволяет пользователю указывать точки мышкой для построения замкнутого полигона.
    /// Автоматически замыкает полигон при клике рядом с первой точкой.
    /// Координаты: X, Y в мировой системе (БЕЗ Z!).
    /// </summary>
    [SectionCmd("plan_draw_polygon")]
    public class PlanDrawPolygonUseCase : ISectionUseCase
    {
        public string Name => "plan_draw_polygon";

        // Snap distance in world units (метры)
        private const double SnapDistance = 1.0;

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;

            // Для Plan view используем env.CadView напрямую (это и есть главный вид сверху)
            CadView planCv = env.CadView;
            if (planCv == null)
            {
                MessageDlg.Show("Окно плана не найдено.");
                return;
            }

            ScopedPolygonOperationContext drawingContext;
            ScopedPolygonSnapshot polygonSnapshot;
            try
            {
                drawingContext = ScopedPolygonOperationContext.Capture(
                    planCv, PolygonGeometryKind.Plan);
                if (drawingContext == null)
                    throw new InvalidOperationException("Не удалось зафиксировать проект и трассу.");
                if (!drawingContext.TryRead(out polygonSnapshot)) return;
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[PlanDrawPolygon] Init error: " + ex.Message);
                MessageDlg.Show("Ошибка загрузки полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            // Получаем или создаём слой для отображения полигонов
            PlanOverlayLayer overlayLayer = planCv[PlanOverlayLayer.GUID] as PlanOverlayLayer;
            if (overlayLayer == null)
            {
                overlayLayer = new PlanOverlayLayer();
                planCv.AddLayer(overlayLayer);
            }

            try
            {
                overlayLayer.ReplaceFromSnapshot(drawingContext, polygonSnapshot);
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Не удалось обновить слой полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            // Основной цикл рисования полигонов
            bool continueDrawing = true;
            while (continueDrawing)
            {
                if (!IsDrawingContextCurrent(drawingContext, planCv, overlayLayer))
                {
                    ShowChangedContext();
                    return;
                }
                List<Vector2D> positions = new List<Vector2D>();
                bool addMore = DrawPolygon(env, planCv, positions, overlayLayer,
                    drawingContext, ref polygonSnapshot);

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

        private static bool IsDrawingContextCurrent(
            ScopedPolygonOperationContext context, CadView view,
            PlanOverlayLayer overlayLayer)
        {
            try
            {
                return context != null && context.IsCurrent() &&
                    Object.ReferenceEquals(view[PlanOverlayLayer.GUID], overlayLayer);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void ShowChangedContext()
        {
            MessageDlg.Show("Трасса, проект, окно или слой полигонов изменились во время рисования. Полигон не сохранён.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        private bool DrawPolygon(SectionEnv env, CadView planCv, List<Vector2D> positions,
            PlanOverlayLayer overlayLayer, ScopedPolygonOperationContext drawingContext,
            ref ScopedPolygonSnapshot polygonSnapshot)
        {
            // Локальная переменная для замыкания
            bool isPolygonClosed = false;

            // Делегат для динамической отрисовки
            DrawCursorEvent dynamicDraw = delegate(CadPen pen, Vector3D vertex)
            {
                if (positions.Count == 0) return;

                Vector2D mousePos = vertex.Pos;
                bool nearFirstPoint = positions.Count >= 3 && IsNearPoint(mousePos, positions[0], SnapDistance);

                pen.BeginDraw();
                try
                {
                    // 1. Draw polygon fill (if >= 3 points) - scanline fill
                    if (positions.Count >= 3)
                    {
                        List<Vector2D> fillPoints = new List<Vector2D>(positions);
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
                    foreach (Vector2D p in positions)
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
            planCv.DynamicDraw += dynamicDraw;
            try
            {
                Vector3D pos;
                string prompt = "Укажите первую точку полигона (X, Y)";

                // Просим пользователя указать точки
                while (CadCursors.GetPoint(planCv, out pos, prompt))
                {
                    Vector2D mousePos = pos.Pos;

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

                    // Calculate area (in square meters, world coordinates)
                    double area = CalculatePolygonArea(positions);

                    // Show 3-button dialog:
                    // Yes = "Удалить" (save to collection and finish)
                    // No = "Ещё полигон" (save to collection and continue)
                    // Cancel = "Отмена" (discard polygon)
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(
                        string.Format(
                            "Полигон создан!\nТочек: {0}\nПлощадь: {1:F2} кв.м\n\nДА = Сохранить и завершить\nНЕТ = Ещё полигон\nОТМЕНА = Отменить",
                            positions.Count,
                            area),
                        "Сохранение полигона",
                        System.Windows.Forms.MessageBoxButtons.YesNoCancel,
                        System.Windows.Forms.MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes || result == System.Windows.Forms.DialogResult.No)
                    {
                        if (!IsDrawingContextCurrent(drawingContext, planCv, overlayLayer))
                        {
                            ShowChangedContext();
                            return false;
                        }
                        try
                        {
                            List<ScopedPolygonRecord> candidate =
                                new List<ScopedPolygonRecord>(polygonSnapshot.Records);
                            candidate.Add(ScopedPolygonRecord.Plan(DateTime.Now, positions));
                            polygonSnapshot = drawingContext.Commit(polygonSnapshot, candidate);
                        }
                        catch (System.Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine("[PlanDrawPolygon] Error saving polygon: " + ex.Message);
                            MessageDlg.Show("Ошибка сохранения полигона: " + ex.Message,
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }

                        int polygonCount = polygonSnapshot.Records.Count;
                        try
                        {
                            if (IsDrawingContextCurrent(drawingContext, planCv, overlayLayer))
                                overlayLayer.ReplaceFromSnapshot(drawingContext, polygonSnapshot);
                            else
                                throw new InvalidOperationException("Окно или слой изменились после сохранения.");
                        }
                        catch (Exception ex)
                        {
                            MessageDlg.Show("Полигон сохранён, но слой плана не обновлён: " + ex.Message,
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Warning);
                            return false;
                        }

                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            MessageDlg.Show(
                                string.Format("Полигон сохранён!\nВсего полигонов: {0}\n\nТеперь выполните команду plan_delete_points для удаления точек.", polygonCount),
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageDlg.Show(
                                string.Format("Полигон сохранён!\nВсего полигонов: {0}\n\nРисуйте следующий полигон.", polygonCount),
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Information);
                            return true;
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
                planCv.DynamicDraw -= dynamicDraw;
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
            foreach (Vector2D p in points)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            // Шаг сканирования (адаптивный)
            double stepY;
            if (!ScanlineFillPlanner.TryPlan(minY, maxY, 0.5, out stepY))
                return;

            List<double> intersections = new List<double>();

            for (double y = minY; y <= maxY; y += stepY)
            {
                intersections.Clear();

                // Находим пересечения со всеми рёбрами
                for (int i = 0; i < points.Count; i++)
                {
                    Vector2D p1 = points[i];
                    Vector2D p2 = points[(i + 1) % points.Count];

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
