# Card 12 — Картограмма насыпи/выемки (Cartogram)

> Тема: построение картограммы (cut/fill map) между двумя TIN — сетка ячеек с объёмами насыпи/выемки.
> **Вердикт: ✅ VERIFIED**

---

## Ключевая идея

**Картограмма** — это альтернатива табличной ведомости объёмов: область работ разбивается регулярной сеткой ячеек, для каждой считается насыпь/выемка по разнице двух TIN (земля vs проект). Визуально — цветные квадраты с подписями высот/объёмов.

```
Cartogram : UndoObject                          Cartograms.cs:160
    ├── EarthRelativePath : string              (путь к TIN земли, :234)
    ├── ProjectRelativePath : string            (путь к TIN проекта, :248)
    ├── HorizontalStep / VerticalStep : double  (размер ячейки сетки, м)
    ├── Rotation : double                       (поворот сетки)
    ├── BuildByAlignment : bool                 (true → сетка по трассе)
    ├── AlignmentRelativePath : string          (трасса, если BuildByAlignment)
    ├── StationsStep / OffsetStep : double      (шаг по трассе)
    ├── CalculateVolumesByTriangles : bool      (точный метод по треугольникам)
    ├── RoundVolumesByElevations : bool         (округление по высотам)
    ├── SectWithSurfaceContour : bool           (обрезка по контуру поверхности)
    └── Cache : CartogramCache                  (результат: ячейки + контуры, :304)

CartogramCache                                 Cartograms.cs:1581
    ├── Cells : IList<CartogramCell>            (:1694)
    ├── Nodes : IList<CartogramNode>            (:1703)
    ├── FillContours / CutContours              (контуры насыпи/выемки)
    └── Volumes : IDictionary<int, VolumeItem>  (агрегат по столбцам, :1616)

CartogramCell                                  Cartograms.cs:1017
    ├── FillVolume / CutVolume : double         (:1065, :1079)
    ├── FillArea / CutArea : double             (:1093, :1107)
    └── Nodes : IList<IList<int>>               (индексы в Cache.Nodes)
```

---

## Сигнатуры (verified)

### `Cartogram` (`Topomatic.Cartograms.cs:160`)
| Сигнатура | Файл:строка |
|---|---|
| `public class Cartogram : UndoObject, IStgSerializable, IOwned, ICartogramContainer, IDrawingContainer, IObjectDisjoiner` | `Topomatic.Cartograms.cs:160` |
| **`public Cartogram(object owner, ICartogramBuilder builder)`** (public ctor) | `:650` |
| `public CartogramContour Contour { get; }` | `:225` |
| **`public string EarthRelativePath { get; set; }`** | `:234` |
| **`public string ProjectRelativePath { get; set; }`** | `:248` |
| **`public double HorizontalStep { get; set; }`** | `:262` |
| **`public double VerticalStep { get; set; }`** | `:276` |
| `public double Rotation { get; set; }` | `:290` |
| `public CartogramCache Cache { get; }` | `:304` |
| `public CartogramInnerContours InnerContours { get; }` | `:324` |
| `public CartogramStyle Style { get; }` | `:333` |
| `public Guid Id { get; }` | `:342` |
| **`public bool CalculateVolumesByTriangles { get; set; }`** | `:355` |
| `public string RenewSurfaceRelativePath { get; set; }` | `:369` |
| `public double RenewMaxFrez { get; set; }` | `:383` |
| `public IList<CartogramRenewLayer> RenewLayers { get; }` | `:397` |
| `public bool SectWithSurfaceContour { get; set; }` | `:406` |
| `public bool DynamicalUpdateAfterSurfaceChanged { get; set; }` | `:420` |
| `public bool RoundVolumesByElevations { get; set; }` | `:434` |
| `public bool RoundSummVolumes { get; set; }` | `:448` |
| `public BasicEditedItemsTable EditedItems { get; }` | `:462` |
| `public bool HasControlPosition { get; set; }` | `:471` |
| `public Vector2D ControlPosition { get; set; }` | `:485` |
| **`public bool BuildByAlignment { get; set; }`** | `:499` |
| **`public bool VertricalStepByOffsets { get; set; }`** | `:513` |
| **`public string AlignmentRelativePath { get; set; }`** | `:527` |
| **`public double StationsStep { get; set; }`** | `:541` |
| **`public double OffsetStep { get; set; }`** | `:555` |
| `public string AdditionalStations { get; set; }` | `:569` |
| `public object Owner { get; }` | `:583` |
| `public event EventHandler Regen` | `:619` |
| **`public void Clear()`** | `:721` |
| **`public void Refresh()`** — пересчёт ячеек через builder | `:730` |
| **`public void DoRegen()`** — регенерация | `:748` |
| `public void LoadFromStg(StgNode node)` | `:754` |
| `public void SaveToStg(StgNode node)` | `:810` |

### `ICartogramBuilder` (`Topomatic.Cartograms.cs:7160`)
| Сигнатура | Файл:строка |
|---|---|
| `public interface ICartogramBuilder` | `Topomatic.Cartograms.cs:7160` |
| `void Build(CartogramCache cache)` | `:7162` |

> Реализация — `internal` в `Topomatic.Cartograms.Core.cs:6221` (наследник `BrepDelauney`). Создаётся ядром; плагину достаточно вызвать `cartogram.Refresh()`.

### `CartogramCache` (`Topomatic.Cartograms.cs:1581`)
| Сигнатура | Файл:строка |
|---|---|
| `public class CartogramCache : IOwned, ICartogramContainer, IStgSerializable` | `Topomatic.Cartograms.cs:1581` |
| `public struct VolumeItem { public double CutVolume; public double FillVolume; public double CutArea; public double FillArea; public string Description; }` | `:1583-1593` |
| `public IDictionary<int, VolumeItem> Volumes { get; }` (по столбцам) | `:1616` |
| `public uint StartColumn { get; }` | `:1625` |
| `public Vector2D InfoPosition { get; }` | `:1639` |
| `public double InfoRotation { get; }` | `:1653` |
| `public IList<IList<int>> NullLines { get; }` | `:1667` |
| `public IList<IList<int>> FillContours { get; }` | `:1676` |
| `public IList<IList<int>> CutContours { get; }` | `:1685` |
| **`public IList<CartogramCell> Cells { get; }`** | `:1694` |
| `public IList<CartogramNode> Nodes { get; }` | `:1703` |
| `public object Owner { get; }` | `:1712` |

### `CartogramCell` (`Topomatic.Cartograms.cs:1017`)
| Сигнатура | Файл:строка |
|---|---|
| `public class CartogramCell : IOwned, ICartogramContainer, IStgSerializable` | `Topomatic.Cartograms.cs:1017` |
| `public IList<IList<int>> Nodes { get; }` (индексы вершин ячейки) | `:1047` |
| `public IList<int> AdditionalElevations { get; }` | `:1056` |
| **`public double FillVolume { get; }`** | `:1065` |
| **`public double CutVolume { get; }`** | `:1079` |
| **`public double FillArea { get; }`** | `:1093` |
| **`public double CutArea { get; }`** | `:1107` |

---

## Команды Topomatic (для вызова через Plugins.Execute)

Из `Topomatic.Cartograms.Controller.cs`:
| Команда | Файл:строка | Назначение |
|---|---|---|
| **`create_cartogram`** | `:567` | Создать картограмму (диалог + регистрация) |
| **`cartogram_refresh`** | `:518` | Пересчитать |
| `cartogram_make_outer_contour` | `:232` | Внешний контур |
| `cartogram_add_inner_contour` | `:384` | Внутренний контур |
| `cartogram_add_additional_contour` | `:780` | Дополнительный контур |
| `cartogram_make_renew_surface` | `:715` | Поверхность планировки |
| `cartogram_align_cells` | `:915` | Выровнять ячейки |
| **`generate_cartograms_earth_work_sheet`** | `:964` | **Ведомость земработ из картограммы** |
| `cartograms_earth_work_sheet` | `:980` | Открыть ведомость |
| **`generate_cartograms_cell_sheet`** | `:996` | **Ведомость ячеек** |
| `cartogram_cell_sheet` | `:1015` | Открыть ведомость ячеек |
| `cartogram_append_station` | `:1031` | Добавить пикет |

---

## 🥇 GOLD-паттерн: создание и настройка картограммы

Источник: `Topomatic.Cartograms.Controller.cs:567-647` (`create_cartogram`). Реальная последовательность Topomatic:

```csharp
// 1. Создать модель картограммы через плагин-команду
IProjectModel projectModel2 = ApplicationHost.Current.Plugins.Execute(
    "<create_cmd>",                                    // обфусцировано, но есть
    new object[] { parentUriString, "<ext>", nameWithExt }) as IProjectModel;

projectModel2.LockWrite();
try {
    // 2. Получить объект Cartogram из контейнера модели
    Cartogram cartogram = ((ICartogramContainer)projectModel2.Model).Cartogram;

    // 3. Настроить свойства (транзакционно)
    INamedTransactable namedTransactable = ApplicationHost.Current.ActiveProject as INamedTransactable;
    namedTransactable?.BeginUpdate();
    try {
        cartogram.CalculateVolumesByTriangles   = true;       // точный метод
        cartogram.RoundVolumesByElevations      = false;
        cartogram.RoundSummVolumes              = false;
        cartogram.DynamicalUpdateAfterSurfaceChanged = true;
        cartogram.SectWithSurfaceContour        = true;       // обрезка по контуру TIN
        cartogram.ProjectRelativePath           = "Surfaces/Design.sfc";
        cartogram.EarthRelativePath             = "Surfaces/ExistingGround.sfc";
        cartogram.HorizontalStep                = 10.0;       // ячейка 10×10 м
        cartogram.VerticalStep                  = 10.0;
        cartogram.Rotation                      = 0.0;

        // 4а. Либо прямоугольная сетка (по умолчанию)
        //     cartogram.BuildByAlignment = false;

        // 4б. Либо сетка по трассе:
        cartogram.BuildByAlignment              = true;
        cartogram.AlignmentRelativePath         = "Alignments/MyRoad.roadx";
        cartogram.StationsStep                  = 20.0;       // пикет через 20 м
        cartogram.OffsetStep                    = 5.0;        // смещение через 5 м
        cartogram.VertricalStepByOffsets        = true;
    }
    finally { namedTransactable?.EndUpdate(); }
}
finally { projectModel2.UnlockWrite(); }
```

> Обфусцированные строки команд в реальном коде зашифрованы (`lELFS242Y(...)`), но **значения** имён команд известны из атрибутов `[cmd(...)]` (см. таблицу выше).

---

## ✅ Рецепт: построить картограмму и прочитать объёмы

```csharp
// (1) Допустим, cartogram уже создан и настроен (GOLD выше)
// (2) Пересчёт ячеек:
cartogram.Refresh();   // или DoRegen()

// (3) Чтение результатов из Cache
CartogramCache cache = cartogram.Cache;
double totalFill = 0, totalCut = 0;
foreach (CartogramCell cell in cache.Cells) {
    totalFill += cell.FillVolume;
    totalCut  += cell.CutVolume;
}

// (4) Агрегат по столбцам (для ведомости по пикетам):
foreach (var kv in cache.Volumes) {
    int column = kv.Key;
    CartogramCache.VolumeItem vi = kv.Value;
    Console.WriteLine($"Столбец {column}: насыпь={vi.FillVolume:F1}, выемка={vi.CutVolume:F1}");
}

Console.WriteLine($"ИТОГО: насыпь {totalFill:F1} м³, выемка {totalCut:F1} м³");
```

---

## ✅ Рецепт: ведомость ячеек картограммы (готовая команда)

```csharp
// Topomatic сам генерирует ведомость ячейек картограммы:
ApplicationHost.Current.Plugins.Execute("generate_cartograms_cell_sheet",
    new object[] { cartogramProjectModel });
```

---

## Сравнение с Path 2 (AreaBetweenSurfacesCalculator) из card 05

| | Cartogram | AreaBetweenSurfacesCalculator |
|---|---|---|
| Что даёт | сетка ячеек + визуализация + ведомость по столбцам | только 4 числа (fill/cut area+volume) |
| Сетка по трассе | ✅ (`BuildByAlignment`) | ❌ |
| Визуальная отрисовка | ✅ (контуры, ячейки, стили) | ❌ |
| Готовая ведомость | ✅ (`generate_cartograms_*_sheet`) | ❌ |
| Сложность настройки | средняя (много свойств) | низкая (один вызов) |
| Точность | по треугольникам (`CalculateVolumesByTriangles`) | Delaunay basis |

**Рекомендация:** для проекта с трассой — **Cartogram** (он интегрирован с трассой и даёт ведомость). Для быстрой оценки между двумя TIN без трассы — `AreaBetweenSurfacesCalculator`.

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| Думать, что картограмма — это только визуализация | это ещё и расчёт объёмов + ведомость |
| Искать `MassDiagram`/`BalanceLine` | не существуют — используйте `Cartogram` |
| Не вызвать `Refresh()` после настройки свойств | ячейки останутся пустыми |
| Использовать прямоугольную сетку для линейного объекта | `BuildByAlignment=true` + `StationsStep`/`OffsetStep` |
| Забыть `ProjectRelativePath` и `EarthRelativePath` | без двух TIN расчёт невозможен |

---

## 🔗 Связанные карточки
- [05 — Объёмы (VolumeCalcer / AreaBetweenSurfaces)](05-earthwork-volumes.md)
- [11 — Таблицы и экспорт](11-tables-export.md)
- [06 — Привязка земли (EgSurfaceRelativePaths)](06-ground-surface-binding.md)
- [08 — Surface/TIN internals](08-surface-tin-internals.md)
