# Card 06 — Привязка TIN-поверхности земли (Existing Ground)

> Тема: как к трассе/сечениям привязать существующую землю (TIN), чтобы получать высоты и считать объёмы.
> **Вердикт: ✅ VERIFIED**

---

## Ключевая идея

Земля привязывается к трассе **строкой-путём** через `Alignment.EgSurfaceRelativePaths` (список относительных путей к `.sfc`/DTM-файлам). При построении сечений движок Topomatic **автоматически** сэмплирует эти поверхности через `AlignLibrary.ScanCrossDtm` и кладёт результат в `Section.StaticEg`.

```
Alignment.EgSurfaceRelativePaths : IList<string>     ← ПУТЬ привязки (Alg.cs:4782)
    │
    ▼ при построении сечений (BuildExistentGround)
AlignLibrary.ScanCrossDtm(...) → CrsLine              ← сэмплирование
    │
    ▼
Section.StaticEg = crsLine                            ← результат
```

> ⚠️ **НЕ существует** `Alignment.EgSurface`, `Corridor.EgSurface`, `Alignment.Settings.EgSurface`, `GroundSurface`, `ExistingSurface`. Привязка — **только** через `IList<string> EgSurfaceRelativePaths`.

---

## Сигнатуры (verified)

### Привязка земли (на `Alignment`)
| Сигнатура | Файл:строка |
|---|---|
| **`public IList<string> EgSurfaceRelativePaths { get; }`** — пути к существующей земле (TIN) | `Topomatic.Alg.cs:4782` |
| `public IList<string> ProfileCuttingSurfacesRelativePaths { get; }` | `Topomatic.Alg.cs:4800` |
| `public IList<string> SectionCuttingSurfacesRelativePaths { get; }` | `Topomatic.Alg.cs:4809` |
| `public double DtmSizeLeft { get; set; }` — левая полуширина сканирования, м | `Topomatic.Alg.cs:4827` |
| `public double DtmSizeRight { get; set; }` — правая полуширина | `Topomatic.Alg.cs:4841` |
| `public bool FilterCrossPoint { get; set; }` | `Topomatic.Alg.cs:4923` |
| `public double FilterCrossPointFactor { get; set; }` | в теле |

### `AlignLibrary.ScanCrossDtm` — 3 перегрузки (`Topomatic.Alg.Runtime.cs`)
| Сигнатура | Файл:строка |
|---|---|
| **`public static CrsLine ScanCrossDtm(double station, IEnumerable<Surface> surfaces, CompoundLine planLine, double dtmSizeLeft, double dtmSizeRight, bool filterCrossPoint, double filterCrossPointFactor)`** | `Topomatic.Alg.Runtime.cs:52200` |
| `public static CrsLine ScanCrossDtm(double station, IEnumerable<Surface> egSurfaces, IEnumerable<Surface> projectSurfaces, CompoundLine planLine, double dtmSizeLeft, double dtmSizeRight, bool filterCrossPoint, double filterCrossPointFactor)` | `Topomatic.Alg.Runtime.cs:52308` |
| `public static CrsLine ScanCrossDtm(double station, CrsLine sl, IEnumerable<Surface> egSurfaces, IEnumerable<Surface> projectSurfaces, CompoundLine planLine, bool filterCrossPoints, double filterCrossPointFactor)` | `Topomatic.Alg.Runtime.cs:52321` |
| `public static void ScanCrossSingleLine(List<Vector2D> line, IEnumerable<Surface> surfaces, CompoundLine planLine, double deltax, bool filterCrossPoint, double filterCrossPointFactor)` | `Topomatic.Alg.Runtime.cs:52354` |
| `class AlignLibrary` (static) | `Topomatic.Alg.Runtime.cs:51955` |

### Разрешение поверхностей по путям
| Сигнатура | Файл:строка |
|---|---|
| `public static void FindSurfaces(IProjectModel model, IList<string> paths, IList<Surface> earth, IList<Surface> project)` | `Topomatic.Alg.Runtime.cs:54272` |
| 2-арг перегрузка / KeyValuePair перегрузка | `:54306`, `:54332` |

> Поверхности резолвятся из `IProjectModel` через `m.LockReadContainer<ISurfaceContainer>()`.

---

## 🥇 GOLD-паттерн: как Topomatic сэмплирует землю автоматически

Источник: `Topomatic.Alg.Runtime.cs` метод `BuildExistentGround` (≈ `:51665`) — тело построителя сечений:

```csharp
protected override void BuildExistentGround(CrsDesignContext context, double station,
                                            CrsLine staticEg, CrsLine sectionLine)
{
    CrsLine crsLine = null;
    if (staticEg != null) {
        crsLine = staticEg;                    // если StaticEg уже задано — используем его
    } else {
        var earth   = new List<Surface>();     // поверхности земли (EG)
        var project = new List<Surface>();     // проектные поверхности
        IProjectModel projectModel = PluginCoreOps.FindModel(m_Alignment.Owner);
        if (projectModel != null) {
            AlignLibrary.FindSurfaces(projectModel, m_Alignment.EgSurfaceRelativePaths, earth, project);
            crsLine = (sectionLine != null)
                ? AlignLibrary.ScanCrossDtm(station, sectionLine, earth, project,
                          m_Alignment.Plan.CompoundLine, m_Alignment.FilterCrossPoint,
                          m_Alignment.FilterCrossPointFactor)
                : AlignLibrary.ScanCrossDtm(station, earth, project,
                          m_Alignment.Plan.CompoundLine, m_Alignment.DtmSizeLeft,
                          m_Alignment.DtmSizeRight, m_Alignment.FilterCrossPoint,
                          m_Alignment.FilterCrossPointFactor);
        }
    }
    // ... crsLine пакуется в CrsExistentGround компонент context'а
}
```

**Вывод:** если в `Section.StaticEg` уже что-то лежит — оно используется как есть. Иначе движок сэмплирует автоматически из `EgSurfaceRelativePaths`. Это и есть **правильный способ** привязать землю.

---

## ✅ Рецепт A: автоматическая привязка (рекомендуется)

```csharp
// 1. Привязать поверхность земли по относительному пути
alg.EgSurfaceRelativePaths.Add("Surfaces/ExistingGround.sfc");

// 2. Задать полуширины сканирования
alg.DtmSizeLeft  = 50.0;   // 50 м влево от оси
alg.DtmSizeRight = 50.0;   // 50 м вправо

// 3. При последующем построении коридора/сечений земля автоматически
//    сэмплируется в Section.StaticEg через ScanCrossDtm.
```

Путь — **относительный** к проекту (формат .sfc — файл Surface). Используйте прямые слэши `/`.

## ✅ Рецепт B: ручное сэмплирование одного сечения

```csharp
using Topomatic.Alg.Runtime;   // AlignLibrary

// Получить Surface (TIN) из проекта — например, через LayerView или ISurfaceContainer
IEnumerable<Surface> egSurfaces = /* ... */;

CrsLine ground = AlignLibrary.ScanCrossDtm(
    station:        sec.Station,
    surfaces:       egSurfaces,
    planLine:       alg.Plan.CompoundLine,
    dtmSizeLeft:    alg.DtmSizeLeft,
    dtmSizeRight:   alg.DtmSizeRight,
    filterCrossPoint:      alg.FilterCrossPoint,
    filterCrossPointFactor: alg.FilterCrossPointFactor);

sec.StaticEg = ground;   // назначаем — при следующей перестройке будет переиспользовано
```

## ✅ Рецепт C: продольный профиль земли (StaticEg на Transition)

Для продольного существующего профиля (не сечения, а沿-оси) — `Transition.StaticEg`:

```csharp
var staticEg = alg.Transitions[0].StaticEg;   // StaticProfile
staticEg.BeginUpdate();
try {
    staticEg.Clear();
    staticEg.Add(new ProfileNode(/* station, elevation, ... */));
}
finally { staticEg.EndUpdate(); }
```

GOLD: `Topomatic.Alg.Runtime.cs:49131-49142` (populates `transition.StaticEg`).

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| Искать `Alignment.EgSurface : Surface` | такого нет — только `EgSurfaceRelativePaths : IList<string>` |
| Передавать абсолютный путь в `EgSurfaceRelativePaths` | относительный к проекту |
| Думать, что нужно вручную сэмплировать каждое сечение | автоматически через `BuildExistentGround` (если путь задан) |
| Смешивать `Section.StaticEg` и `Transition.StaticEg` | первое — поперечник, второе — продольный профиль |

---

## 🔗 Связанные карточки
- [03 — Вертикальный профиль (Transition)](03-vertical-profile.md)
- [04 — Коридор и поперечники](04-corridor-sections.md)
- [05 — Объёмы (Path 2: TIN vs TIN)](05-earthwork-volumes.md)
- [08 — Surface/TIN internals](08-surface-tin-internals.md)
