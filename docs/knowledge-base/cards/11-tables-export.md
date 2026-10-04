# Card 11 — Таблицы и экспорт ведомости (Tables API)

> Тема: программное построение таблицы и экспорт в CSV/Excel/RTF/HTML.
> **Вердикт: ✅ VERIFIED** — раньше `Topomatic.Tables.*` считались «отсутствующими», но они декомпилированы (corpus полон: 189/189 DLL).

---

## Ключевая идея

```
TablesDocument (контейнер таблиц)              Tables.Export.cs:11429
    └── AddTable(name, id) → Table             Tables.cs:11482
            ├── Cell(row, col) → TableCell     Tables.cs:9841
            ├── InsertRow(int)                 Tables.cs:10101
            └── InsertColumn(int, ...)         Tables.cs:10106

TableCell.Value (get/set string)               Tables.cs:10312

Экспорт:
TablesExportService.Export(TablesDocument)     Tables.Export.cs:18101
    ├── TablesCSVExportService                 Tables.Export.cs:18106  (CSV)
    ├── TablesExcelExportService               Tables.Export.cs:19977  (Excel)
    ├── TablesDrawingExportService             Tables.Export.cs:18563
    ├── TablesDwgTableExportService            Tables.Export.cs:18929
    └── TablesOpenOfficeExportService          Tables.Export.cs:20721
```

> ⚠️ `VolumeTable` в `Topomatic.Analysis.Controller.cs:14696` — **`internal class`**, недоступен из плагина. Но его `UpdateTable()` (`:14758`) показывает GOLD-паттерн наполнения данными через `VolumeCalcer` (см. card 05). Для экспорта **своей** ведомости — собирайте `TablesDocument` вручную.

---

## Сигнатуры (verified)

### `TablesDocument` — контейнер (`Topomatic.Tables.cs`)
| Сигнатура | Файл:строка |
|---|---|
| `public class TablesDocument : IEnumerable<Table>, IEnumerable` | `Topomatic.Tables.cs:11429` |
| **`public TablesDocument()`** (zero-arg ctor) | `Topomatic.Tables.cs:11516` |
| `public int TablesCount { get; }` | `:11452` |
| `public Table this[int index]` | `:11461` |
| `public Table this[string id]` | `:11470` |
| **`public Table AddTable(string name, string id)`** | `:11482` |
| `public Table AddTable(string name, string id, bool active)` | `:11490` |
| `public void RemoveTableAt(int index)` | `:11498` |

### `Table` — одна таблица (`Topomatic.Tables.cs:9616`)
| Сигнатура | Файл:строка |
|---|---|
| `public class Table : ISheetEditorModel` | `Topomatic.Tables.cs:9616` |
| `public bool Active { get; }` | `:9690` |
| `public int ColumnsCount { get; }` | `:9699` |
| `public int RowsCount { get; }` | `:9708` |
| `public string Name { get; }` | `:9717` |
| **`public TableCell Cell(int row, int column)`** — создаёт ячейку если её нет | `Topomatic.Tables.cs:9841` |
| `public bool TryGetCell(int row, int column, out TableCell cell)` | `:9865` |
| `public void SetStyle(int row, int column, int rows, int columns, Action<TableCellStyle> action)` | `:10038` |
| `public void SetBorderWidths(int row, int column, int rows, int columns, int BorderWidthSize)` | `:10027` |
| **`public void InsertRow(int rowIndex)`** | `Topomatic.Tables.cs:10101` |
| **`public void InsertColumn(int columnIndex, TableColumn.Option options, double width)`** | `Topomatic.Tables.cs:10106` |
| `public void InsertColumn(int columnIndex)` | `:10157` |
| `public void InsertSubtableByColumns(Table subtable, int rowIndex, int columnIndex)` | `:10165` |
| `public void RemoveRowAt(int rowIndex)` | `:10210` |
| `public void RemoveColumnAt(int columnIndex)` | `:10216` |

### `TableCell` — ячейка (`Topomatic.Tables.cs:10296`)
| Сигнатура | Файл:строка |
|---|---|
| `public class TableCell : ISheetEditorCell` | `Topomatic.Tables.cs:10296` |
| **`public string Value { get; set; }`** — содержимое | `:10312` |
| `public TableCellStyle Style { get; set; }` | `:10326` |
| `public int Row { get; }` | `:10344` |
| `public int Column { get; }` | `:10353` |
| `public int Rows { get; }` (для merged-ячеек) | `:10367` |
| `public int Columns { get; }` | `:10376` |
| `public string SourceText { get; }` | `:10426` |
| `public string Text { get; }` | `:10440` |

### Экспорт — `TablesExportService` (`Topomatic.Tables.Export.cs:17991`)
| Сигнатура | Файл:строка |
|---|---|
| `public abstract class TablesExportService` | `Topomatic.Tables.Export.cs:17991` |
| `public Guid Id { get; }` | `:18000` |
| **`public URI URI { get; set; }`** — путь файла экспорта | `:18018` |
| `public bool AbsoluteFilePath { get; set; }` | `:18032` |
| `public virtual bool Enable { get; }` | `:18048` |
| `public virtual string Extension { get; }` | `:18057` |
| `public abstract string Name { get; }` | `:18066` |
| `public abstract string Description { get; }` | `:18068` |
| `public virtual string ModelType { get; }` | `:18070` |
| `public TablesExportService(Guid id)` | `:18080` |
| `public virtual void PrepareData(string modelId, string cmd, string[] args, UserSheet sheet)` | `:18088` |
| `protected abstract void OnExport(TablesDocument document)` | `:18098` |
| **`public void Export(TablesDocument document)`** | `Topomatic.Tables.Export.cs:18101` |

### Конкретные экспортёры
| Класс | Файл:строка | Формат |
|---|---|---|
| `public class TablesCSVExportService : TablesExportService` | `Topomatic.Tables.Export.cs:18106` | **CSV** |
| `public static readonly Guid Guid;` (CSV) | `:18133` | |
| **`public TablesCSVExportService()`** (zero-arg) | `:18172` | |
| `public class TablesExcelExportService : TablesExportService` | `Topomatic.Tables.Export.cs:19977` | **Excel** |
| `public class TablesDrawingExportService : TablesExportService` | `:18563` | Drawing |
| `public class TablesDwgTableExportService : TablesExportService` | `:18929` | DWG-таблица |
| `public class TablesOpenOfficeExportService : TablesExportService` | `:20721` | OpenOffice |
| `public class TablesExportServices : IEnumerable<TablesExportService>` | `:20675` | реестр всех сервисов |

### Прочее (UI-уровень, для справки)
| Сигнатура | Файл:строка |
|---|---|
| `public static class ShtExporter` | `Topomatic.Tables.Core.cs:10535` |
| `public static bool ShtExporter.ExportWithDialog(Drawing drawing, StgDocumentOperationEventHandler additionalSettings, bool useDrawingExportProviders, ref string defaultFilename)` | `Topomatic.Tables.Core.cs:10540` |
| `internal class VolumeTable : UserControl` (недоступен!) | `Topomatic.Analysis.Controller.cs:14696` |
| `public bool VolumeTable.UpdateTable()` (недоступен, но см. как GOLD в card 05) | `:14758` |

---

## 🥇 GOLD-паттерн: наполнение таблицы объёмами

Источник: `Topomatic.Analysis.Controller.cs:14748-14792` (`VolumeTable.UpdateTable`, internal). Это **доказательство**, как Topomatic наполняет таблицу объёмами:

```csharp
CrsDesignContext ctx = alg.Corridor[sectionIndex];   // BuildMode.Volume
var list = new List<VolumeCalcer.Volume>();
VolumeCalcer.CalcVolumes(list, ctx,
    values => alg.Plugins.ModifyVolumes(values, alg.Corridor.Sections[sectionIndex]),
    hasOffsets: false);
foreach (var v in list) {
    // v.Cipher, v.Value, v.Description — идут в ячейки таблицы
}
```

---

## ✅ Рецепт: построить и экспортировать ведомость объёмов в CSV

```csharp
using Topomatic.Alg;
using Topomatic.Alg.Runtime;          // AlignLibrary
using Topomatic.Crs.Runtime;          // VolumeCalcer
using Topomatic.FoundationClasses;    // URI
using Topomatic.Tables;               // TablesDocument, Table, TableCell
using Topomatic.Tables.Export;        // TablesCSVExportService

// 1. Создать документ и таблицу
var doc = new TablesDocument();
Table tbl = doc.AddTable("Ведомость объёмов земработ", "volumes");

// 2. Шапка
tbl.InsertRow(0);
tbl.Cell(0, 0).Value = "ПК";
tbl.Cell(0, 1).Value = "Выемка, м²";
tbl.Cell(0, 2).Value = "Насыпь, м²";

// 3. Наполнить строками из сечений (Path 1 из card 05)
int row = 1;
double prevSta = double.NaN; (double Cut, double Fill) prev = (0, 0);
double totalCut = 0, totalFill = 0;
foreach (Section sec in alg.Corridor.Sections) {
    CrsDesignContext ctx = alg.Corridor[sec];        // BuildMode.Volume
    var list = new System.Collections.Generic.List<VolumeCalcer.Volume>();
    VolumeCalcer.CalcVolumes(list, ctx, modify: null, hasOffsets: false);

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
    prevSta = sec.Station; prev = (cut, fill);
    row++;
}

// 4. Строка ИТОГО
tbl.InsertRow(row);
tbl.Cell(row, 0).Value = "ИТОГО (м³):";
tbl.Cell(row, 1).Value = totalCut.ToString("F1");
tbl.Cell(row, 2).Value = totalFill.ToString("F1");

// 5. Экспорт в CSV
var csv = new TablesCSVExportService();
csv.URI = new URI(@"D:\Work\volumes.csv");
csv.AbsoluteFilePath = true;
csv.Export(doc);
```

> Для Excel — замените `TablesCSVExportService` на `TablesExcelExportService` (`:19977`). Для перебора всех доступных форматов — итерируйте `TablesExportServices.Current` (`:20675`).

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| Искать `QuantitiesTable`/`EarthworkTable` | не существуют — собирайте `TablesDocument` вручную |
| Использовать `VolumeTable` напрямую | он `internal` — недоступен из плагина |
| Забыть `csv.URI = new URI(path)` | `Export` упадёт — путь не задан |
| `csv.URI = "path"` (string) | у `URI` нет implicit-каста — `new URI(path)` |
| Думать, что `Topomatic.Tables.*` отсутствуют | они декомпилированы (corpus 189/189) |

---

## 🔗 Связанные карточки
- [05 — Объёмы (VolumeCalcer)](05-earthwork-volumes.md)
- [12 — Картограммы (Cartogram)](12-cartograms.md)
- [01 — URI класс](01-alignment-creation.md)
