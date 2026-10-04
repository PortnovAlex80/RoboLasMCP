using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LAS_TERRAIN.Domain.Persistence;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Visualization;
using Topomatic.Alg;
using Topomatic.Alg.Runtime.ServiceClasses;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("polygon_save_as")]
    public sealed class SavePolygonsAsUseCase : ISectionUseCase
    {
        public string Name { get { return "polygon_save_as"; } }
        public void Run(SectionEnv env)
        {
            int saved = 0;
            try
            {
                var plan = ScopedPolygonOperationContext.Capture(env.CadView, PolygonGeometryKind.Plan);
                if (plan == null) throw new InvalidOperationException("Откройте сохранённый проект и сделайте трассу активной.");
                var context = plan;
                var snapshot = plan.Repository.Read();
                // CRS selection is explicit; a Plan-only project needs no section access.
                var choice = MessageBox.Show("Какие полигоны сохранить?\nДа — план.\nНет — поперечники.\nОтмена — отменить сохранение.",
                    "Сохранить полигоны как…", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (choice == DialogResult.Cancel) return;
                if (!plan.IsCurrent()) throw new InvalidOperationException("Активный проект изменился.");
                if (choice == DialogResult.No)
                {
                    context = ScopedPolygonOperationContext.Capture(env.CadView, PolygonGeometryKind.Crs);
                    if (context == null) throw new InvalidOperationException("Поперечники текущей трассы недоступны.");
                    snapshot = context.Repository.Read();
                }
                if (snapshot.Records.Count == 0) { MessageDlg.Show("Нет полигонов для сохранения."); return; }
                string folder;
                using (var dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Выберите папку: каждый полигон будет сохранён в отдельный JSON-файл.";
                    dialog.SelectedPath = context.Scope.StorageRoot;
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    folder = dialog.SelectedPath;
                }
                List<string> paths = new List<string>();
                bool overwrites = false;
                for (int n = 0; n < snapshot.Records.Count; n++)
                {
                    string path = Path.Combine(folder, PortablePolygonFile.FileName(
                        context.Scope.ProjectAlias, context.Scope.GeometryKind, n + 1));
                    if (String.Equals(Path.GetFullPath(path), context.Scope.FilePath, StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Файл экспорта совпадает с хранилищем проекта.");
                    paths.Add(path); overwrites |= File.Exists(path);
                }
                if (overwrites && MessageBox.Show("В выбранной папке уже есть файлы с такими именами. Заменить их?",
                    "Сохранить полигоны", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                foreach (string path in paths)
                {
                    if (!context.IsSnapshotCurrent(snapshot)) throw new InvalidOperationException("Проект или полигоны изменились.");
                    PortablePolygonFile.Save(path, snapshot.Records[saved]); saved++;
                }
                MessageDlg.Show("Сохранено полигонов: " + saved + "\nПапка: " + folder);
            }
            catch (Exception ex) { MessageDlg.Show("Сохранение не завершено. Сохранено файлов: " + saved + "\n" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    [SectionCmd("polygon_load")]
    public sealed class LoadPolygonsUseCase : ISectionUseCase
    {
        public string Name { get { return "polygon_load"; } }
        public void Run(SectionEnv env)
        {
            bool committed = false;
            try
            {
                var owner = ScopedPolygonOperationContext.Capture(env.CadView, PolygonGeometryKind.Plan);
                if (owner == null) throw new InvalidOperationException("Откройте сохранённый проект и сделайте трассу активной.");
                string[] files;
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = "Загрузить полигоны"; dialog.Filter = "Полигоны RoboLas (*.json)|*.json";
                    dialog.CheckFileExists = true; dialog.Multiselect = true;
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    files = dialog.FileNames;
                }
                if (!owner.IsCurrent()) throw new InvalidOperationException("Активный проект изменился.");
                List<ScopedPolygonRecord> imported = new List<ScopedPolygonRecord>();
                foreach (string file in files) imported.Add(PortablePolygonFile.Load(file));
                if (imported.Count == 0) return;
                var kind = imported[0].GeometryKind;
                foreach (var record in imported)
                    if (record.GeometryKind != kind) throw new InvalidOperationException("Загрузите полигоны плана и поперечников отдельно.");
                var context = kind == PolygonGeometryKind.Plan ? owner :
                    ScopedPolygonOperationContext.Capture(env.CadView, kind);
                if (context == null || !owner.IsCurrent()) throw new InvalidOperationException("Активный проект или трасса изменились.");
                var snapshot = context.Repository.Read();
                if (kind == PolygonGeometryKind.Crs)
                {
                    using (var receiver = ActiveAlignmentReciver<Alignment>.CreateReciver(false))
                    {
                        var sections = receiver.Alignment.Corridor.Sections;
                        int index = receiver.Manager.CurrentSection;
                        if (index < 0 || index >= sections.Count) throw new InvalidOperationException("Выберите текущий поперечник.");
                        var section = sections[index];
                        if (MessageBox.Show("Загрузить контуры на текущий поперечник, станция " + section.Station +
                            "?\nСохраняются поперечные координаты и высоты из файла.", "Загрузить полигоны",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                        for (int n = 0; n < imported.Count; n++)
                        {
                            var record = imported[n];
                            imported[n] = ScopedPolygonRecord.Crs(record.CreatedAt, record.Polygon,
                                section.Id, section.Station, record.Thickness);
                        }
                        if (receiver.Manager.CurrentSection != index) throw new InvalidOperationException("Текущий поперечник изменился.");
                    }
                }
                else if (MessageBox.Show("Добавить полигонов: " + imported.Count +
                    "?\nКоординаты X/Y сохраняются. Система координат проекта должна совпадать с исходной.",
                    "Загрузить полигоны", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                if (!context.IsSnapshotCurrent(snapshot)) throw new InvalidOperationException("Проект или полигоны изменились.");
                var records = new List<ScopedPolygonRecord>(snapshot.Records); records.AddRange(imported);
                var result = context.Commit(snapshot, records); committed = true;
                if (kind == PolygonGeometryKind.Plan && context.IsCurrent())
                {
                    var layer = env.CadView[PlanOverlayLayer.GUID] as PlanOverlayLayer;
                    if (layer == null) { layer = new PlanOverlayLayer(); env.CadView.AddLayer(layer); }
                    layer.ReplaceFromSnapshot(context, result);
                }
                MessageDlg.Show("Добавлено полигонов: " + imported.Count + ". Имеющиеся полигоны сохранены.");
            }
            catch (Exception ex) { MessageDlg.Show((committed ? "Полигоны загружены, но отображение не обновлено: " :
                "Полигоны не загружены: ") + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
