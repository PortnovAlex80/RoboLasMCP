using System;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Visualization;
using Topomatic.Cad.View;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("plan_clear_polygons")]
    public class PlanClearPolygonsUseCase : ISectionUseCase
    {
        public string Name { get { return "plan_clear_polygons"; } }

        public void Run(SectionEnv env)
        {
            CadView view = env == null ? null : env.CadView;
            ScopedPolygonOperationContext context;
            try { context = ScopedPolygonOperationContext.Capture(view, PolygonGeometryKind.Plan); }
            catch (Exception ex)
            {
                MessageDlg.Show("Не удалось определить проект полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            if (context == null)
            {
                MessageDlg.Show("Не удалось зафиксировать трассу, проект, окно или путь к полигонам.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            ScopedPolygonSnapshot snapshot;
            PlanOverlayLayer overlay;
            try
            {
                if (!context.TryRead(out snapshot)) return;
                overlay = view[PlanOverlayLayer.GUID] as PlanOverlayLayer;
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка инициализации коллекции полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            System.Windows.Forms.DialogResult confirm = System.Windows.Forms.MessageBox.Show(
                "Очистить коллекцию полигонов (Plan view)?",
                "Очистка коллекции",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question);
            if (confirm != System.Windows.Forms.DialogResult.Yes) return;

            if (!context.IsCurrent() ||
                !Object.ReferenceEquals(view[PlanOverlayLayer.GUID], overlay))
            {
                MessageDlg.Show("Трасса, проект, окно или слой изменились. Полигоны не очищены.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            int count = snapshot.Records.Count;
            if (count == 0)
            {
                MessageDlg.Show("Коллекция полигонов пуста.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }

            try
            {
                context.Commit(snapshot, new ScopedPolygonRecord[0]);
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка очистки полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            if (overlay != null)
            {
                try
                {
                    if (context.IsCurrent() &&
                        Object.ReferenceEquals(view[PlanOverlayLayer.GUID], overlay))
                        overlay.ClearPolygons();
                    else
                        throw new InvalidOperationException("Окно или слой изменились после сохранения.");
                }
                catch (Exception ex)
                {
                    MessageDlg.Show("Полигоны очищены, но слой плана не обновлён: " + ex.Message,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                    return;
                }
            }

            MessageDlg.Show(string.Format("Очищено полигонов: {0} штук", count),
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
