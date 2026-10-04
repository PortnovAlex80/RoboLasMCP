# Recipe — Построить трассу с нуля (5 км, 3 угла, R250, клотоиды, поперечники, объёмы)

> **End-to-end рецепт:** создаёт трассу, план, профиль, поперечники и считает объёмы.
> Все сигнатуры верифицированы (см. ссылки на карточки). Это «сборка» карточек 01–07 в один сценарий.

---

## Постановка

- Длина ≈ 5 км
- 3 угла поворота (4 PI-точки)
- R = 250 м, симметричные клотоиды L = 80 м (K = √(250·80) ≈ 141.42)
- Поперечники каждые 20 м
- Ведомость объёмов насыпи/выемки

---

## Полный код

```csharp
using System;
using System.Collections.Generic;
using Topomatic.Alg;
using Topomatic.Alg.Road.Core;          // RoadModel
using Topomatic.Alg.Runtime;            // AlignLibrary, VolumeCalcer
using Topomatic.ApplicationPlatform;    // ApplicationHost, ModelProject, PluginCoreOps
using Topomatic.Cad.Foundation;         // Vector2D
using Topomatic.Crs.Runtime;            // VolumeCalcer
using Topomatic.FoundationClasses;      // TransactableUpdateLoop
using Topomatic.Sfc;                    // AreaBetweenSurfacesCalculator, Surface

public class RouteBuilderModule : PluginInitializator
{
    [cmd("build_demo_route")]
    private object BuildDemoRoute()
    {
        BuildRoute();
        return null;
    }

    private void BuildRoute()
    {
        // ─────────────────────────────────────────────────────────────
        // 1. Создать модель трассы и зарегистрировать (card 01)
        // ─────────────────────────────────────────────────────────────
        var project     = (ModelProject)ApplicationHost.Current.ActiveProject;
        var rootModel   = project.Model;
        var folderModel = PluginCoreOps.FindFolderModel(rootModel);

        using var loop = TransactableUpdateLoop.CreateProjectLoop();
        Alignment alg;
        IProjectModel roadPM;
        try
        {
            roadPM = PluginCoreOps.CreateModel(folderModel, "Road", "DemoRoute.roadx");
            roadPM.LockWrite();
            try
            {
                var roadModel = (RoadModel)roadPM.Model;
                alg = roadModel.Alignment;        // RoadAlignment (Alg.Road.Core.cs:15667)
                alg.Name = "Demo 5km";            // Alg.cs:5990

                // ─────────────────────────────────────────────────────
                // 2. План: 4 PI-точки (3 угла), R=250, клотоиды 80 (card 02)
                // ─────────────────────────────────────────────────────
                const double R = 250.0;
                const double L = 80.0;
                const double K = 141.42;   // √(250·80)

                var pi = new[] {
                    new Vector2D { X =     0.0, Y =     0.0 },
                    new Vector2D { X =  2000.0, Y =   500.0 },
                    new Vector2D { X =  3500.0, Y =   520.0 },
                    new Vector2D { X =  5000.0, Y =     0.0 },
                };

                alg.Plan.BeginUpdate();
                try
                {
                    alg.Plan.Add(new PlanLine.Vertex { Position = pi[0] });
                    for (int i = 1; i < pi.Length - 1; i++)
                    {
                        var v = new PlanLine.Vertex { Position = pi[i] };
                        v.Add(new PlanLine.Vertex.VertexItem { L1 = L, R = R, K = K, L2 = L });
                        alg.Plan.Add(v);
                    }
                    alg.Plan.Add(new PlanLine.Vertex { Position = pi[pi.Length - 1] });
                }
                finally { alg.Plan.EndUpdate(); }

                double routeLen = alg.Plan.CompoundLine.Length;   // O(1) cached

                // ─────────────────────────────────────────────────────
                // 3. Вертикальный профиль (на Transition!, card 03)
                // ─────────────────────────────────────────────────────
                var red = alg.Transitions[0].RedProfile;
                red.BeginUpdate();
                try
                {
                    red.Clear();
                    red.Add(new ProjectNode(station: 0,      elevation: 100.0,
                        length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
                    red.Add(new ProjectNode(station: routeLen/2, elevation: 102.5,
                        length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
                    red.Add(new ProjectNode(station: routeLen,   elevation: 105.0,
                        length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
                }
                finally { red.EndUpdate(); }

                // ─────────────────────────────────────────────────────
                // 4. Привязка существующей земли (card 06)
                //    Surface с землёй должен быть в проекте.
                // ─────────────────────────────────────────────────────
                alg.EgSurfaceRelativePaths.Add("Surfaces/ExistingGround.sfc");
                alg.DtmSizeLeft  = 50.0;
                alg.DtmSizeRight = 50.0;

                // ─────────────────────────────────────────────────────
                // 5. Поперечники каждые 20 м — НЕРАЗРУШАЮЩЕ (cards 04, 07)
                // ─────────────────────────────────────────────────────
                var stations = new List<double>();
                AlignLibrary.MakeWholeStations(alg, 0.0, routeLen, 20.0, stations, canTerminate: false);

                using (alg.Corridor.Sections.BeginUpdate())
                {
                    foreach (double s in stations)
                        alg.Corridor.Sections.Add(s);   // idempotent (НЕ вызывать Clear!)
                }

                // ─────────────────────────────────────────────────────
                // 6. Объёмы — Path 2 (TIN vs TIN), card 05.
                //    Нужны fg (проектная) и eg (земля) Surface.
                //    Здесь — заглушка; реальное получение Surface зависит
                //    от того, как построена проектная поверхность коридора.
                // ─────────────────────────────────────────────────────
                Surface fgSurface = GetDesignSurface(alg);   // TODO: из коридора/CRS
                Surface egSurface = GetExistingGroundSurface(project);

                if (fgSurface != null && egSurface != null)
                {
                    var calc = new AreaBetweenSurfacesCalculator();
                    var contour = new List<Vector2D> {
                        new Vector2D { X = 0,        Y = -50 },
                        new Vector2D { X = routeLen, Y = -50 },
                        new Vector2D { X = routeLen, Y =  50 },
                        new Vector2D { X = 0,        Y =  50 },
                    };
                    calc.Execute(fgSurface, egSurface, contour, additional: null,
                                 out double fillArea, out double fillVol,
                                 out double cutArea,  out double cutVol);
                    Console.WriteLine($"Насыпь: {fillVol:F1} м³, Выемка: {cutVol:F1} м³");
                }

                // ─────────────────────────────────────────────────────
                // 7. Экспорт ведомости объёмов в CSV (card 11).
                //    Альтернатива объёмам из коридора — Картограмма (card 12),
                //    которая даёт готовую ведомость + визуализацию.
                // ─────────────────────────────────────────────────────
                ExportVolumesToCsv(alg, @"D:\Work\volumes.csv");
            }
            finally { roadPM.UnlockWrite(); }
        }
        catch { loop.Commit = false; throw; }
        finally { loop.Commit = true; }
    }

    // Экспорт ведомости объёмов земработ (Path 1 + TablesCSVExportService)
    private static void ExportVolumesToCsv(Alignment alg, string csvPath)
    {
        var doc = new Topomatic.Tables.TablesDocument();
        var tbl = doc.AddTable("Ведомость объёмов земработ", "volumes");
        tbl.InsertRow(0);
        tbl.Cell(0, 0).Value = "ПК";
        tbl.Cell(0, 1).Value = "Выемка, м²";
        tbl.Cell(0, 2).Value = "Насыпь, м²";

        int row = 1;
        double totalCut = 0, totalFill = 0, prevSta = double.NaN;
        (double Cut, double Fill) prev = (0, 0);
        foreach (Section sec in alg.Corridor.Sections) {
            CrsDesignContext ctx = alg.Corridor[sec];   // BuildMode.Volume
            var list = new List<Topomatic.Crs.Runtime.VolumeCalcer.Volume>();
            Topomatic.Crs.Runtime.VolumeCalcer.CalcVolumes(list, ctx, modify: null, hasOffsets: false);
            double cut = 0, fill = 0;
            foreach (var v in list) {
                if (v.Code == 2736 || v.Code == 2740) fill += v.Value;
                else if (v.Code == 2737 || v.Code == 2741) cut += v.Value;
            }
            tbl.InsertRow(row);
            tbl.Cell(row, 0).Value = sec.Station.ToString("F2");
            tbl.Cell(row, 1).Value = cut.ToString("F2");
            tbl.Cell(row, 2).Value = fill.ToString("F2");
            if (!double.IsNaN(prevSta)) {
                double L = sec.Station - prevSta;
                totalCut  += (cut  + prev.Cut)  / 2 * L;
                totalFill += (fill + prev.Fill) / 2 * L;
            }
            prevSta = sec.Station; prev = (cut, fill); row++;
        }
        tbl.InsertRow(row);
        tbl.Cell(row, 0).Value = "ИТОГО (м³):";
        tbl.Cell(row, 1).Value = totalCut.ToString("F1");
        tbl.Cell(row, 2).Value = totalFill.ToString("F1");

        var csv = new Topomatic.Tables.Export.TablesCSVExportService();
        csv.URI = new Topomatic.FoundationClasses.URI(csvPath);
        csv.AbsoluteFilePath = true;
        csv.Export(doc);
    }

    // TODO: реализовать получение проектной поверхности из коридора (CrsDesignContext → Surface)
    private static Surface GetDesignSurface(Alignment alg) => null;

    // Получить Surface земли из проекта (через ISurfaceContainer)
    private static Surface GetExistingGroundSurface(ModelProject project) => null;
}
```

---

## Что осталось TODO (открытые пробелы для следующего цикла реверса)

| # | Пробел | Где копать | Статус |
|---|---|---|---|
| ~~3~~ | ~~**Экспорт ведомости в CSV/Excel**~~ | `Topomatic.Tables.*` | ✅ **ЗАКРЫТО** — corpus полон (189/189), API задокументирован в `cards/11-tables-export.md` |
| 1 | **Получение проектной `Surface` (TIN) из коридора** — для Path 2 объёмов | `CrsDesignContext` → триангуляция контуров коридора в `Surface`. Возможный путь: `Corridor.CreateDesignContext(...)`, собрать узлы из `CrsVolume.Contour`, триангулировать `DynamicCachedBuilder`. | открыт |
| 2 | **Получение `Surface` земли из проекта** | `ISurfaceContainer` через `IProjectModel.LockReadContainer<ISurfaceContainer>()` (см. `AlignLibrary.FindSurfaces` в card 06). | открыт |
| 4 | **Per-region объёмы Path 1** | Пройти `alg.Corridor[i]` → `VolumeCalcer.CalcVolumes`, интегрировать методом средних площадей (см. card 05 Path 1). | рецепт готов в card 11 |
| 5 | **Создание `.sfc` Surface программно** | `PluginCoreOps.CreateModel(folderModel, "<surface-modelType>", name)` — точное значение `modelType` для Surface требует проверки (вероятно `"dtm"`, судя по `Extentions.Controller.cs:35875`). | открыт |

> **Альтернатива для объёмов + ведомости + визуализации — Картограмма** (`cards/12-cartograms.md`): вместо Path 2 (TIN vs TIN вручную) можно создать модель картограммы через `create_cartogram` с двумя `Surface` (земля + проект) и получить готовую сетку ячеек с объёмами + команду `generate_cartograms_earth_work_sheet` для ведомости. Это полностью интегрированный в Topomatic путь.

---

## Связанные карточки
- [01 — Создание Alignment](../cards/01-alignment-creation.md)
- [02 — План](../cards/02-planline-geometry.md)
- [03 — Профиль](../cards/03-vertical-profile.md)
- [04 — Коридор/поперечники](../cards/04-corridor-sections.md)
- [05 — Объёмы](../cards/05-earthwork-volumes.md)
- [06 — Привязка земли](../cards/06-ground-surface-binding.md)
- [07 — Пикеты](../cards/07-stations-generation.md)
- [10 — Транзакции](../cards/10-transactions-undo.md)
- [11 — Таблицы и экспорт ведомости](../cards/11-tables-export.md)
- [12 — Картограмма (альтернатива объёмам + ведомость + визуализация)](../cards/12-cartograms.md)
