# Card 04 — Коридор и поперечники: Corridor, SectionList, Section, CrsLine

> Тема: управление поперечниками (cross-sections), доступ к содержимому сечения.
> **Вердикт: ✅ VERIFIED**

---

## Ключевая идея

```
Alignment.Corridor : Corridor                      (Alg.cs:4869)
    └── Sections : SectionList                     (Alg.cs:18916)
            └── Section[i]                         (Alg.cs:19615)
                    ├── Station : double            (:19711)
                    ├── StaticEg   : CrsLine        (существующая земля, :19739)
                    ├── SectionLine : CrsLine       (проектный шаблон, :19758)
                    ├── IsProject : bool            (true если SectionLine==null, :19778)
                    ├── Id, ConstructionId : uint   (:19688, :19700)
                    ├── Underlay : Drawing          (:19787)
                    └── Signs : ConventionalSigns   (:19843)
```

---

## Сигнатуры (verified)

### `Corridor`
| Сигнатура | Файл:строка |
|---|---|
| `public class Corridor : UndoObject, IOwned, IAlignmentContainer, IStgSerializable` | `Topomatic.Alg.cs:18832` |
| `public SectionList Sections { get; }` | `Topomatic.Alg.cs:18916` |
| `public ConstructionDictionary Constructions { get; }` | `Topomatic.Alg.cs:18925` |
| `public Alignment Alignment { get; }` | `Topomatic.Alg.cs:19003` |
| `public CrsDesignContext this[int index] { get; }` (indexer, дефолт `BuildMode.Volume`) | `Topomatic.Alg.cs:18934` |
| `public CrsDesignContext this[int index, BuildMode mode] { get; }` | `Topomatic.Alg.cs:18943` |
| `public CrsDesignContext CreateDesignContext(double station)` | `Topomatic.Alg.cs:19028` |
| `public CrsDesignContext CreateDesignContext(double station, BuildMode mode)` | `Topomatic.Alg.cs:19030` |
| `public CrsDesignContext CreateDesignContext(double station, BuildMode mode, ICrsBuilderListener listener)` | `Topomatic.Alg.cs:19037` |
| `public CrsDesignContext CreateDesignContext(double station, BuildMode mode, bool clipContours, ICrsBuilderListener listener)` | `Topomatic.Alg.cs:19046` |

> ⚠️ **`Corridor[i]` строит `CrsDesignContext` на КАЖДОМ доступе** — дорого при массовом опросе. Кешируйте или проходите `Sections[i]` напрямую, где нужен только `Station`. См. `MASTER_REPORT.md` §P5.

### `SectionList`
| Сигнатура | Файл:строка |
|---|---|
| `public class SectionList : UndoObject, IEnumerable<Section>, IOwned, IStgSerializable, IEnumerable` | `Topomatic.Alg.cs:20041` |
| **`public int Add(double station)`** — возвращает индекс вставки; **idempotent** (если станция уже есть — вернёт её индекс без перезаписи) | `Topomatic.Alg.cs:20175` |
| `public Section this[int index]` (indexer) | (IEnumerable/индексация) |
| `public int Count` | |
| `public void Clear()` — ⚠️ **РАЗРУШИТЕЛЬНЫЙ**, без бэкапа! | `Topomatic.Alg.cs:20206` |
| `public int IsExist(double)` / `GetIndex` / `GetIndexLess` / `GetIndexMore` — O(log n) BinarySearch | ~`:20190` |
| `public bool BeginUpdate() / EndUpdate()` (через UndoObject) | унаследовано |
| Events: `AfterInsert`, `BeforeRemove` (thread-safe, структурные только) | ~`:20250` |

### `Section`
| Сигнатура | Файл:строка |
|---|---|
| `public class Section : UpdatableObject, IOwned, IStgSerializable, IEquatable<Section>` | `Topomatic.Alg.cs:19615` |
| **ctor: `internal Section(object owner, uint id, uint constructionId, double station)`** — НЕЛЬЗЯ `new` снаружи | `Topomatic.Alg.cs:19873` |
| `public uint Id { get; }` | `Topomatic.Alg.cs:19688` |
| `public uint ConstructionId { get; }` | `Topomatic.Alg.cs:19700` |
| `public double Station { get; internal set; }` | `Topomatic.Alg.cs:19711` |
| `public bool Selected { get; set; }` | `Topomatic.Alg.cs:19725` |
| **`public CrsLine StaticEg { get; set; }`** — существующая земля (existing ground) | `Topomatic.Alg.cs:19739` |
| **`public CrsLine SectionLine { get; set; }`** — проектный шаблон сечения | `Topomatic.Alg.cs:19758` |
| `public bool IsProject { get; }` (=`SectionLine==null`) | `Topomatic.Alg.cs:19778` |
| `public Drawing Underlay { get; set; }` | `Topomatic.Alg.cs:19787` |
| `public Vector2D UnderlayStart / UnderlayEnd` | `:19801`, `:19815` |
| `public string Name { get; }` | `Topomatic.Alg.cs:19829` |
| `public ConventionalSigns Signs { get; }` | `Topomatic.Alg.cs:19843` |
| `public void Invalidate()` | `Topomatic.Alg.cs:19867` |
| `public void CopyParameters(Section section)` | `Topomatic.Alg.cs:19999` |

### `CrsLine` (контейнер точек сечения)
| Сигнатура | Файл:строка |
|---|---|
| `public class CrsLine : UpdatableObject, IEnumerable<CrsLineNode>, IList<CrsLineNode>, ICloneable, IObjectDisjoiner, IEquatable<CrsLine>, IStgSerializable, IOwned` | `Topomatic.Crs.cs:20255` |
| `public CrsLineNode this[int index]` | `Topomatic.Crs.cs:20341` |
| `public int Count` | `Topomatic.Crs.cs:20355` |
| `public CrsLine()` (default ctor) | `Topomatic.Crs.cs:20388` |
| `public CrsLine(IEnumerable<CrsLineNode> nodes)` | `Topomatic.Crs.cs:20401` |
| `public CrsLine(IEnumerable<Vector2D> points)` | `Topomatic.Crs.cs:20415` |
| `public void Append(IEnumerable<CrsLineNode>)` | `Topomatic.Crs.cs:20437` |

### `CrsLineNode` (struct!)
| Сигнатура | Файл:строка |
|---|---|
| `public struct CrsLineNode : IEquatable<CrsLineNode>` | `Topomatic.Crs.cs:20779` |
| `public double Offset;` — смещение от оси влево/вправо (X, м) | |
| `public double Elevation;` — высота (Y, м) | |
| `public int Code;` — код точки (default 399) | |
| `public CrsLineNode(double offset, double elevation)` (Code=399) | `Topomatic.Crs.cs:20796` |
| `public CrsLineNode(double offset, double elevation, int code)` | `Topomatic.Crs.cs:20806` |

> ⚠️ У `CrsLineNode` **только `int Code`** — отдельного поля `Layer` нет.

---

## 🚨 Критический warning: НЕ вызывайте `Sections.Clear()`

`SectionList.Clear()` (`Alg.cs:20206`) — голый `.Clear()` без бэкапа. Уничтожает пользовательские CRS-данные (`StaticEg`, `SectionLine`, `Underlay`), которые живут **на объекте Section**.

7 call-site'ов в Robolas делают это (`SectionBaseUseCase.cs:211,216`, и др.) — это **bug** (см. `MASTER_REPORT.md` §C2).

**Правильно:** либо не трогать Sections вообще (использовать `MakeWholeStations` для получения списка пикетов), либо merge-идиома:

```csharp
using (alg.Corridor.Sections.BeginUpdate()) {
    foreach (double s in stations) {
        int idx = alg.Corridor.Sections.Add(s);   // idempotent на станции
        // ... устанавливать свойства через Sections[idx], всегда клонируя CrsLine
    }
}  // EndUpdate в finally
```

---

## 🥇 GOLD-паттерн (неразрушающее добавление сечений)

Источник: `Topomatic.Alg.cs:34252-34270` (`MergeCrossSections`) — каноническая идиома Topomatic:

```csharp
using (alg.Corridor.Sections.BeginUpdate()) {      // одна undo-единица
    foreach (double s in stations) {
        int idx = alg.Corridor.Sections.Add(s);    // idempotent на станции
        var sec = alg.Corridor.Sections[idx];
        // устанавливать свойства — НИКОГДА не присваивать CrsLine по ссылке,
        // всегда клонировать: new CrsLine(src)
    }
}  // EndUpdate в finally
```

И Robolas так и делает — `SectionBaseUseCase.cs:217`: `alg.Corridor.Sections.Add(station)`.

---

## ✅ Рецепт: создать поперечники каждые 20 м

```csharp
using Topomatic.Alg;
using Topomatic.Alg.Runtime;   // AlignLibrary

double length = alg.Plan.CompoundLine.Length;     // O(1) cached

// Неразрушающая генерация списка станций
var stations = new System.Collections.Generic.List<double>();
AlignLibrary.MakeWholeStations(alg, 0.0, length, 20.0, stations, canTerminate: false);

// Добавление в коридор (БЕЗ Clear!)
using (alg.Corridor.Sections.BeginUpdate()) {
    foreach (double s in stations) {
        alg.Corridor.Sections.Add(s);   // idempotent — вернёт существующий индекс, если есть
    }
}   // EndUpdate в finally (using-IDisposable паттерн)
```

## ✅ Рецепт: прочитать содержимое сечения

```csharp
foreach (Section sec in alg.Corridor.Sections) {
    Console.WriteLine($"ПК {sec.Station:F2}");

    // проектный шаблон (если построен):
    if (sec.SectionLine != null) {
        foreach (CrsLineNode n in sec.SectionLine) {
            Console.WriteLine($"  design: offset={n.Offset:F2}  elev={n.Elevation:F2}  code={n.Code}");
        }
    }

    // существующая земля:
    if (sec.StaticEg != null) {
        foreach (CrsLineNode n in sec.StaticEg) {
            Console.WriteLine($"  ground: offset={n.Offset:F2}  elev={n.Elevation:F2}");
        }
    }
}
```

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `align.Sections.Add(s)` | `align.Corridor.Sections.Add(s)` |
| `new Section(...)` | ctor internal — только через `SectionList.Add(station)` |
| `Sections.Clear()` перед добавлением | разрушает CRS-данные — **не делайте** (bug, см. C2) |
| `Sections` = `List<Section>` | тип — **`SectionList`** |
| Присваивать `Section.StaticEg = existingLine` по ссылке | клонировать: `new CrsLine(src)` (см. MergeCrossSections) |
| Вызывать `Corridor[i]` в цикле по всем точкам | дорого (строит CrsDesignContext) — только для нужного сечения |

---

## 🔗 Связанные карточки
- [03 — Вертикальный профиль](03-vertical-profile.md)
- [05 — Объёмы (VolumeCalcer)](05-earthwork-volumes.md)
- [06 — Привязка земли к StaticEg](06-ground-surface-binding.md)
- [07 — Генерация пикетов](07-stations-generation.md)
