using System;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using Topomatic.Cad.View;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("crs_clear_polygons")]
    public class CrsClearPolygonsUseCase : ISectionUseCase
    {
        public string Name { get { return "crs_clear_polygons"; } }

        public void Run(SectionEnv env)
        {
            CadView view = env == null ? null : env.CadView;
            ScopedPolygonOperationContext context;
            try { context = ScopedPolygonOperationContext.Capture(view, PolygonGeometryKind.Crs); }
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
            try
            {
                if (!context.TryRead(out snapshot)) return;
            }
            catch (Exception ex)
            {
                MessageDlg.Show("Ошибка инициализации коллекции полигонов: " + ex.Message,
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            System.Windows.Forms.DialogResult confirm = System.Windows.Forms.MessageBox.Show(
                "Очистить коллекцию полигонов?",
                "Очистка коллекции",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question);
            if (confirm != System.Windows.Forms.DialogResult.Yes) return;

            if (!context.IsCurrent())
            {
                MessageDlg.Show("Трасса, проект или окно изменились. Полигоны не очищены.",
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

            MessageDlg.Show(string.Format("Очищено полигонов: {0} штук", count),
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
