# База знаний Topomatic Robur SDK — Verified Knowledge Base

> **Цель:** выжимать максимум из ядра Topomatic Robur при написании плагинов (как Robolas).
> **Принцип:** каждая запись **верифицирована** по декомпилированному исходнику (`docs/topomatic-sweep/decompiled/*.cs`). Любая сигнатура без `file:line` считается неподтверждённой.

---

## 🔒 Правила базы знаний (для всех агентов и людей)

1. **Источник правды (ground truth):** `docs/topomatic-sweep/decompiled/*.cs` (189 декомпилированных сборок).
2. **Каждая сигнатура** должна сопровождаться `file:line` (например, `Topomatic.Alg.cs:4639`).
3. **Никаких галлюцинаций.** Если тип/метод не найден в декомпиляте — он помечается как `NOT FOUND` или `❌ не существует`.
4. **Доверять постраничным каталогам** `docs/topomatic-api-catalog/dlls/*.md` (они сгенерированы рефлексией и точны).
5. **НЕ доверять** `MASTER_INDEX.md` и нарративным гайдам без перекрёстной проверки — там найдены галлюцинации (см. `docs/CATALOG_HALLUCINATIONS.md`).
6. **GOLD-паттерн** — фрагмент реального кода ядра Topomatic, который демонстрирует каноничное использование API. Это высшая категория доказательства.
7. **Вердикты:** ✅ VERIFIED (есть file:line) · ⚠️ PARTIAL (сигнатура отличается) · ❌ FAKE/NOT FOUND · ❓ UNCLEAR.

---

## 📚 Структура базы

### `/cards/` — Верифицированные карточки API
По одной теме на файл. Каждая карточка: краткая сводка → сигнатуры с file:line → GOLD-паттерн → рецепт использования.

| Файл | Тема | Статус |
|---|---|---|
| `01-alignment-creation.md` | Создание Alignment и регистрация в проекте (RoadModel, PluginCoreOps.CreateModel) | ✅ |
| `02-planline-geometry.md` | План трассы: PlanLine, Vertex, VertexItem (PI-точки, радиусы, клотоиды) | ✅ |
| `03-vertical-profile.md` | Вертикальный профиль: Transition.RedProfile, ProjectNode, ProjectNodeFlags | ✅ |
| `04-corridor-sections.md` | Коридор и поперечники: Corridor, SectionList, Section, CrsLine, CrsLineNode | ✅ |
| `05-earthwork-volumes.md` | Объёмы земработ: Path 1 (VolumeCalcer) и Path 2 (AreaBetweenSurfacesCalculator) | ✅ |
| `06-ground-surface-binding.md` | Привязка TIN-поверхности земли: EgSurfaceRelativePaths, ScanCrossDtm | ✅ |
| `07-stations-generation.md` | Генерация пикетов: MakeWholeStations vs MakeStations | ✅ |
| `08-surface-tin-internals.md` | Внутренности Surface/TIN: triangulation, PointIndexer, FastSurfaceBuilder caveats | ✅ |
| `09-plugin-registration.md` | Регистрация плагина: [cmd], PluginInitializator, LAS_TERRAIN.plugin manifest | ✅ |
| `10-transactions-undo.md` | Транзакции и undo: BeginUpdate/EndUpdate, UpdateLoop | ✅ |
| `11-tables-export.md` | Таблицы и экспорт ведомости: TablesDocument, Table, TablesCSVExportService | ✅ |
| `12-cartograms.md` | Картограмма насыпи/выемки: Cartogram, CartogramCache, CartogramCell | ✅ |
| `13-automation-agent-control.md` | **Автоматизация и удалённое управление агентом** (IronPython, agent-plugin, RPC) | ✅ |

### `/recipes/` — Сквозные рецепты (end-to-end)
Полные сценарии «от и до» для типичных задач плагина.

| Файл | Рецепт |
|---|---|
| `build-route-from-scratch.md` | Построить трассу с PI, кривыми, профилем, поперечниками и объёмами с нуля |
| `read-existing-alignment.md` | Прочитать существующую трассу (как Robolas) |
| `compute-cut-fill.md` | Подсчёт насыпи/выемки между двумя TIN |

### `/meta/` — Мета-документы
| Файл | Назначение |
|---|---|
| `CATALOG_HALLUCINATIONS.md` | Реестр найденных фейков в каталоге/MASTER_INDEX |
| `VERIFICATION_LOG.md` | Журнал верификаций (что проверено, когда, кем) |

---

## 🗺️ Карта DLL ядра (что в каких сборках)

> Corpus декомпиляции **полон**: 189/189 DLL из `C:\Program Files\Topomatic Robur Rail 16.0\` декомпилированы. Раньше считалось, что Tables/Visualization/Turnouts отсутствуют — это устарело.

| DLL | Ответственность | Ключевые классы |
|---|---|---|
| `Topomatic.Alg` | Трассы, коридоры, секции, переходы (Transition) | Alignment, Corridor, Section, PlanLine, Transition, ProjectProfile |
| `Topomatic.Alg.Core` | База плагинов трасс | AlignmentPlugin, AlignmentModel (abstract) |
| `Topomatic.Alg.Model` | Модель трассы (контейнер Alignment) | AlignmentModel, AlignmentModel.ProjectProfile |
| `Topomatic.Alg.Road.Core` | Дорожные модели | RoadModel, RoadAlignment, RoadEditorFactory |
| `Topomatic.Alg.Rail.Core` | Жездные модели | RailModel, RailAlignment |
| `Topomatic.Alg.Runtime` | Runtime-хелперы трасс | AlignLibrary, CreateAlignmentParams, CrsSurfaceBuilder |
| `Topomatic.Alg.Controller` | Контроллеры UI/документа | (cast ActiveProject → ModelProject) |
| `Topomatic.ApplicationPlatform` | Хост, проект, плагины | ApplicationHost, Project, ModelProject, PluginCoreOps, IProjectModel |
| `Topomatic.Crs` | Конструкции коридора (CRS) | CrsContainer, CrsDesignContext, CrsVolume, VolumesBuilder, CrsLine, CrsLineNode |
| `Topomatic.Crs.Runtime` | Runtime CRS, объёмы | VolumeCalcer, BuildMode, CrsVolumeMode |
| `Topomatic.Sfc` | TIN-поверхности (Surface) | Surface, StructureLine, PointIndexer, SurfaceTools, AreaBetweenSurfacesCalculator |
| `Topomatic.Cad.Foundation` | Геометрия, графика | Vector2D/3D/4D, BoundingBox2D, Line2D, CompoundLine, ArrayMode, DynamicCachedBuilder |
| `Topomatic.FoundationClasses` | Базовые классы | UndoObject, UpdateLoop, Logger, URI, TransactableField, Parallel |
| `Topomatic.Cad.View` | CAD-вид | CadView, SolveLimits, OnGetLimits |
| `Topomatic.Controls` | UI-контролы | PropertyGrid, SimpleDlg, MessageDlg, WaitProgress |
| `Topomatic.ComponentModel` | Component-модель | PropertyExplorer |
| `Topomatic.Lidar` | Облака точек (LAS) | LidarBuffer, QuadTreeIndexer, FindPoints |
| **`Topomatic.Tables`** | **Ядро таблиц** (документ/таблица/ячейка) | **TablesDocument, Table, TableCell, TableRow, TableColumn** |
| **`Topomatic.Tables.Core`** | **Редактор таблиц, Sheet UI** | **SheetEditor, ShtExporter, TablesCorePluginHost** |
| **`Topomatic.Tables.Export`** | **Экспорт таблиц в файл** | **TablesExportService, TablesCSVExportService, TablesExcelExportService, TablesOpenOfficeExportService** |
| **`Topomatic.Analysis.Controller`** | **Анализ трассы (VolumeTable)** | **VolumeTable (internal!)** |
| **`Topomatic.Cartograms`** | **Картограмма (модель)** | **Cartogram, CartogramCache, CartogramCell, CartogramStyle, ICartogramBuilder** |
| **`Topomatic.Cartograms.Core`** | **Построитель картограммы** | **CartogramCorePluginHost, ICartogramBuilder impl (internal, на BrepDelauney)** |
| **`Topomatic.Cartograms.Controller`** | **Команды картограммы** | **`create_cartogram`, `cartogram_refresh`, `generate_cartograms_*_sheet`** |
| **`Topomatic.Scripting`** | **Скриптовый движок (IronPython)** | **`ScriptingModule`, `[cmd("loadpy")]`, `RegisterLoader(".py")` — vendor-native automation** |
| **`Topomatic.Scripting.IronPython`** | **IronPython runtime + проверка параметров** | **`DlrModule`, `ParamsChecker`, `ResultChecker`** |

---

## ⚡ Краткая шпаргалка (quick reference)

### Создание трассы
```csharp
var project     = (ModelProject)ApplicationHost.Current.ActiveProject;
var rootModel   = project.Model;
var folderModel = PluginCoreOps.FindFolderModel(rootModel);
using var loop  = TransactableUpdateLoop.CreateProjectLoop();
var roadPM      = PluginCoreOps.CreateModel(folderModel, "Road", "MyRoad.roadx");
roadPM.LockWrite();
try {
    var roadModel = (RoadModel)roadPM.Model;
    var alg       = roadModel.Alignment;          // RoadAlignment
    alg.Name      = "My Road";                     // Alg.cs:5990
    // ... план, профиль, секции (см. cards 02-04)
} finally { roadPM.UnlockWrite(); }
```

### План (PI-точки + кривые)
```csharp
alg.Plan.BeginUpdate();
try {
    alg.Plan.Add(new PlanLine.Vertex { Position = new Vector2D { X=0, Y=0 } });
    var v = new PlanLine.Vertex { Position = new Vector2D { X=2000, Y=500 } };
    v.Add(new PlanLine.Vertex.VertexItem { L1=80, R=250, K=141.42, L2=80 });
    alg.Plan.Add(v);
} finally { alg.Plan.EndUpdate(); }
```

### Профиль (на Transition, НЕ на Corridor!)
```csharp
alg.Transitions[0].RedProfile.Add(
    new ProjectNode(sta, elev, length, radius, ProjectNodeFlags.UseRadius));
```

### Поперечники (неразрушающе)
```csharp
var stations = new List<double>();
AlignLibrary.MakeWholeStations(alg, 0, alg.Plan.CompoundLine.Length, 20, stations, false);
using (alg.Corridor.Sections.BeginUpdate()) {
    foreach (double s in stations) alg.Corridor.Sections.Add(s);  // НЕ вызывать Clear()!
}
```

### Объёмы (два пути — см. card 05)
```csharp
// Path 2 (проще, 3D-объёмы между двумя TIN):
var calc = new AreaBetweenSurfacesCalculator();
calc.Execute(fgSurface, egSurface, contourPolygon, null,
             out double fillArea, out double fillVol,
             out double cutArea,  out double cutVol);
```

> ⚠️ **НЕ вызывайте `Sections.Clear()`** — это разрушает данные CRS пользователя (см. `MASTER_REPORT.md` §C2).

---

## 🔗 Связанные документы
- `docs/topomatic-sweep/reports/MASTER_REPORT.md` — главный reverse-engineering отчёт (P0/P1-находки, верифицированные факты ядра).
- `docs/topomatic-api-catalog/dlls/*.md` — постраничные каталоги API (надёжны).
- `docs/topomatic-api-catalog/MASTER_INDEX.md` — ⚠️ содержит галлюцинации, см. `meta/CATALOG_HALLUCINATIONS.md`.
- `docs/PLUGIN_DEMO_VERIFICATION_REPORT.md` — отчёт о верификации через демо-плагин.
- `FAQ_topomatic.txt` — компактный cheat-sheet.
