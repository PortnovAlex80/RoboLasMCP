# Card 05 — Объёмы земработ: два пути

> Тема: расчёт объёмов земляных работ (насыпь/выемка).
> **Вердикт: ✅ VERIFIED** — два независимых, проверенных способа.

---

## Ключевая идея: ДВА пути

| | Path 1 — Cross-section (CRS) | Path 2 — TIN vs TIN |
|---|---|---|
| API | `VolumeCalcer.CalcVolumes` | `AreaBetweenSurfacesCalculator.Execute` |
| Что считает | площади сечений по регионам/материалам вдоль трассы | 3D-объёмы насыпи/выемки между двумя TIN |
| Нужна трасса? | да (Alignment + Corridor) | нет (только 2 Surface + контур) |
| Результат | `List<Volume>` (площади сечений, **не объёмы**) | `fillArea, fillVolume, cutArea, cutVolume` (**готовые 3D-объёмы**) |
| Интеграция по длине | руками (метод средних площадей) | уже сделана |
| Сложность | высокая | **низкая** |
| Файл | `Topomatic.Crs.Runtime.cs` | `Topomatic.Sfc.cs` |

> **Рекомендация:** для «ведомости объёмов насыпи/выемки» — **Path 2** (проще и даёт 3D-объёмы сразу). Path 1 — когда нужно разбить объёмы по конструктивным слоям/регионам вдоль трассы (как UI Topomatic).

---

## ❌ Фейки, которые разоблачает эта карточка

Следующие типы **НЕ существуют** в ядре: `EarthworkCalculator`, `MassDiagram`, `BalanceLine`, `QuantitiesTable`, `Quantities`, `SoilVolumes`, `VolumesCalculator`. Все встречающиеся упоминания в каталоге — галлюцинации.

---

# Path 1 — Cross-section CRS volumes (`VolumeCalcer`)

## Сигнатуры (verified)

### `VolumeCalcer` — `Topomatic.Crs.Runtime.cs:9407`
| Сигнатура | Файл:строка |
|---|---|
| `public static class VolumeCalcer` | `Topomatic.Crs.Runtime.cs:9407` |
| **`public static void CalcVolumes(List<Volume> result, CrsContainer container, Action<List<CrsModifiedVolume>> modify, bool hasOffsets)`** | `Topomatic.Crs.Runtime.cs:9517` |

### `VolumeCalcer.Volume` (nested struct)
| Сигнатура | Файл:строка |
|---|---|
| `public struct Volume` | `Topomatic.Crs.Runtime.cs:9409` |
| `public string Cipher;` (шифр материала/региона) | |
| `public string GroundId;` | |
| `public string Description;` | |
| `public double Left;` | |
| `public double Right;` | |
| `public double? LeftOffset, RightOffset;` | |
| `public int Code;` | |
| `public CrsVolumeMode Mode;` | |
| `public double Value { get; }` = `Left + Right` | `Topomatic.Crs.Runtime.cs:9441` |
| `public Volume(string cipher, string groundId, string description, double left, double right, double? loffs, double? roffs, int code, CrsVolumeMode mode)` | `Topomatic.Crs.Runtime.cs:9447` |

### `CrsContainer` и `CrsDesignContext`
| Сигнатура | Файл:строка |
|---|---|
| `public abstract class CrsContainer : CrsComponent, IEnumerable<CrsComponent>, IEnumerable` | `Topomatic.Crs.cs:21860` |
| **`public sealed class CrsDesignContext : CrsContainer`** — CrsDesignContext **ЕСТЬ** CrsContainer | `Topomatic.Crs.cs:47935` |
| `public CrsComponent this[string name]` / `this[int index]`, `Count`, `Add/AddRange/Remove/Clear` | в теле |

> ⚠️ **Интерфейса `ICrsContainer` НЕ существует**. `CrsContainer` — это abstract class.

### Получение `CrsDesignContext` из `Corridor` (это и есть CrsContainer)
| Сигнатура | Файл:строка |
|---|---|
| `public CrsDesignContext this[int index] { get; }` (дефолт `BuildMode.Volume`) | `Topomatic.Alg.cs:18934` |
| `public CrsDesignContext this[int index, BuildMode mode] { get; }` | `Topomatic.Alg.cs:18943` |
| `public CrsDesignContext CreateDesignContext(double station)` | `Topomatic.Alg.cs:19028` |

### `BuildMode` enum — `Topomatic.Crs.cs:29564`
| Значение | Назначение |
|---|---|
| `Existing = 1` | |
| `Project = 3` | readOnly branch |
| **`Volume = 7`** | генерирует volume-region контуры (коды 2736–2745) |
| `ModifyParameters = 14` | |

> Enum **порядковый** (`>=` сравнения): `Volume`/`ModifyParameters` триггерят полную volume-конструкцию, `Existing`/`Project` — нет.

### `CrsVolumeMode` enum — `Topomatic.Crs.cs` (конвертер на :50120)
Значения: `Area`, `Length`, `Count`.

### `CrsVolume` — `Topomatic.Crs.cs:49619`
| Сигнатура | Файл:строка |
|---|---|
| `public class CrsVolume : CrsComponent` | `Topomatic.Crs.cs:49619` |
| `public IList<Vector2D> this[int index]` (кольца контура) | |
| `public int Count` | |
| `public double Factor { get; set; }` (default 1.0) | |
| `public int Code { get; set; }` | |
| `public CrsVolumeMode Mode { get; set; }` | |
| `public double Volume { get; }` = Factor × Σ (area/length/count) | |
| `public CrsContour Contour1, Contour2` | |
| `public CrsNode Begin, End` | |
| `public CrsVolume()` / `CrsVolume(CrsContour)` / `CrsVolume(IEnumerable<Vector2D>, CrsVolumeMode, int)` | |

---

## 🥇 GOLD-паттерн Path 1 (реальный код Topomatic)

Источник: `Topomatic.Analysis.Controller.cs:14748-14792` (`VolumeTable.UpdateTable`):

```csharp
ActiveAlignmentReciver<Alignment> recvr = ActiveAlignmentReciver<Alignment>.CreateReciver(readOnly: true);
Alignment alg = recvr.Alignment;

// 1. Получить CrsDesignContext (= CrsContainer) для конкретного сечения
CrsDesignContext ctx = alg.Corridor[recvr.Manager.CurrentSection];   // indexer → BuildMode.Volume

// 2. Подготовить приёмник
var list = new List<VolumeCalcer.Volume>();

// 3. Рассчитать объёмы для этого сечения
VolumeCalcer.CalcVolumes(list, ctx,
    values => alg.Plugins.ModifyVolumes(values, alg.Corridor.Sections[recvr.Manager.CurrentSection]),
    hasOffsets: false);

// 4. Прочитать результат — это ПЛОЩАДИ сечений, не 3D-объёмы!
foreach (var v in list) {
    // v.Cipher (материал/регион), v.Value (= Left+Right, площадь сечения), v.Description, v.Code, v.Mode
}
```

Другие call-site'ы того же паттерна: `Topomatic.Alg.Runtime.cs:20937, :21024, :61930, :62039`, `Topomatic.Soilworks.Controller.cs:871`.

> **Важно:** `VolumeCalcer.CalcVolumes` возвращает **площади сечений** (per-station), а не 3D-объёмы. Для ведомости объёмов между сечениями применяйте **метод средних площадей**: `V = (A1+A2)/2 × L` между соседними сечениями.

---

## ✅ Рецепт Path 1: ведомость объёмов по сечениям (с интеграцией)

```csharp
using Topomatic.Alg;
using Topomatic.Crs.Runtime;   // VolumeCalcer

double totalCut = 0, totalFill = 0;
var prevStation = double.NaN;
var prevAreas   = (cut: 0.0, fill: 0.0);

foreach (Section sec in alg.Corridor.Sections) {
    CrsDesignContext ctx = alg.Corridor[sec];   // BuildMode.Volume
    var list = new System.Collections.Generic.List<VolumeCalcer.Volume>();
    VolumeCalcer.CalcVolumes(list, ctx, modify: null, hasOffsets: false);

    double cut = 0, fill = 0;
    foreach (var v in list) {
        // классификация по Cipher/Code — зависит от шаблонов проекта
        // упрощённо: Code 2736/2740 = насыпь(fill), 2737/2741 = выемка(cut)
        if (v.Code == 2736 || v.Code == 2740) fill += v.Value;
        else if (v.Code == 2737 || v.Code == 2741) cut += v.Value;
    }

    if (!double.IsNaN(prevStation)) {
        double L = sec.Station - prevStation;
        // метод средних площадей между соседними сечениями
        totalCut  += (cut  + prevAreas.cut)  / 2 * L;
        totalFill += (fill + prevAreas.fill) / 2 * L;
    }
    prevStation = sec.Station;
    prevAreas   = (cut, fill);
}

Console.WriteLine($"Выемка: {totalCut:F1} м³, Насыпь: {totalFill:F1} м³");
```

---

# Path 2 — TIN vs TIN (`AreaBetweenSurfacesCalculator`)

## Сигнатуры (verified)

### `AreaBetweenSurfacesCalculator` — `Topomatic.Sfc.cs:26676`
| Сигнатура | Файл:строка |
|---|---|
| `public class AreaBetweenSurfacesCalculator : BrepDelauney` | `Topomatic.Sfc.cs:26676` |
| `public AreaBetweenSurfacesCalculator()` (default ctor) | `Topomatic.Sfc.cs:27587` |
| **`public void Execute(Surface fg, Surface eg, List<Vector2D> contour, List<Vector2D> additional, out double fillArea, out double fillVolume, out double cutArea, out double cutVolume)`** | `Topomatic.Sfc.cs:27551` |
| `public static bool CalculateElevations(Surface fg, Surface eg, Vector2D position, out double fgElevation, out double egElevation)` | `Topomatic.Sfc.cs:27566` |

Где:
- `fg` — законченная/проектная поверхность (Finished Ground)
- `eg` — существующая земля (Existing Ground)
- `contour` — 2D-полигон границы расчёта (можно периметр области работ)
- `additional` — опциональный, обычно `null`

## 🥇 GOLD-паттерн Path 2 (реальный код Topomatic)

Источник: `Topomatic.Genplan.Controller.cs:18666-18674` и `:18736`:

```csharp
var calculator = new AreaBetweenSurfacesCalculator();
calculator.Execute(dgSurface, egSurface,            // две Surface
    contour2D, null,                                // граница-полигон + опциональное
    out fillArea, out fillVolume,
    out cutArea,  out cutVolume);
```

---

## ✅ Рецепт Path 2: 3D-объёмы насыпи/выемки между двумя TIN

```csharp
using Topomatic.Sfc;
using Topomatic.Cad.Foundation;   // Vector2D

// fg — проектная поверхность (TIN), eg — существующая земля (TIN)
// обе должны быть триангулированы (см. card 08: surface.Triangles.Count > 0!)

var calc = new AreaBetweenSurfacesCalculator();

// граница расчёта — периметр области работ (полигон в плане)
var contour = new System.Collections.Generic.List<Vector2D> {
    new Vector2D { X = 0,    Y = -50 },
    new Vector2D { X = 5000, Y = -50 },
    new Vector2D { X = 5000, Y =  50 },
    new Vector2D { X = 0,    Y =  50 },
};

calc.Execute(fgSurface, egSurface, contour, additional: null,
             out double fillArea, out double fillVolume,
             out double cutArea,  out double cutVolume);

Console.WriteLine($"Насыпь: {fillVolume:F1} м³ (пл. {fillArea:F0} м²)");
Console.WriteLine($"Выемка: {cutVolume:F1} м³ (пл. {cutArea:F0} м²)");
```

---

## Сравнение путей: что выбрать

| Критерий | Path 1 (VolumeCalcer) | Path 2 (AreaBetweenSurfaces) |
|---|---|---|
| Нужна трасса? | да | нет |
| Нужен коридор с шаблонами? | да | нет |
| Разбивка по материалам/регионам | ✅ да (через Cipher/Code) | ❌ только насыпь/выемка |
| Возвращает 3D-объёмы | ❌ площади сечений (нужна интеграция) | ✅ сразу объёмы |
| Сложность подготовки | высокая (построить коридор) | низкая (2 TIN + контур) |
| Когда использовать | UI-таблица Topomatic, разбивка по слоям | быстрая оценка насыпи/выемки |

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `new EarthworkCalculator()` | такого класса нет — `VolumeCalcer` или `AreaBetweenSurfacesCalculator` |
| `MassDiagram`, `BalanceLine`, `QuantitiesTable` | не существуют |
| Думать, что `VolumeCalcer` вернёт 3D-объёмы | возвращает площади сечений — нужна интеграция методом средних площадей |
| Передавать в Path 2 поверхности без треугольников | `Execute` вернёт мусор — оба TIN должны быть триангулированы (см. card 08) |
| Использовать `BuildMode.Project` вместо `BuildMode.Volume` | volume-контуры не построятся |

---

## 🔗 Связанные карточки
- [04 — Коридор и поперечники](04-corridor-sections.md)
- [06 — Привязка земли к StaticEg](06-ground-surface-binding.md)
- [08 — Surface/TIN internals](08-surface-tin-internals.md)
