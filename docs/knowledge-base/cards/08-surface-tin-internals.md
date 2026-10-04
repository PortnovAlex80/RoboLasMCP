# Card 08 — Surface (TIN): внутренности, производительность, подводные камни

> Тема: TIN-поверхности — триангуляция, индексы, пакетная вставка.
> **Вердикт: ✅ VERIFIED** — опирается на `MASTER_REPORT.md` §3.

---

## Ключевые классы (verified)

| Сигнатура | Файл:строка |
|---|---|
| `public sealed class Surface : UndoObject, ...` | `Topomatic.Sfc.cs:17993` |
| `public class SurfacePointArray` (`Add` = O(1), `Alg.cs:23705`) — голый `InnerList.Add`, без триангуляции | `Topomatic.Sfc.cs:23705` |
| `public class PointIndexer` — O(n), параллельная 8×8 uniform-сетка (НЕ quadtree!) | `Topomatic.Sfc.cs:13529` |
| `public class TriangleIndexer` — бины существующих треугольников в 8×8 grid | в теле |
| `public class StructureLine` (breakline), `public bool IsLimitation` | `Topomatic.Sfc.cs:16506` |
| `public class SurfaceTools` (static helpers) | в теле |
| `public static class PointEditor` — `Add(Point)` = per-point BeginUpdate/EndUpdate + per-point `<AddPointCmd>` | `Topomatic.Sfc.cs:13928` |
| `Surface.PointIndexer` (property) | `Topomatic.Sfc.cs:18470` |
| `Surface.CreateSection(...)` (2 перегрузки) | `Topomatic.Sfc.cs:20356`, `:20380` |
| `SurfaceTools.AddPointToTriangulation(...)` (инкрементная, Dynamic-gated) | `Topomatic.Sfc.cs:25078` |
| `SurfaceTools.InsertOverPoints(...)` (breakline-densify, 2 перегрузки) | `Topomatic.Sfc.cs:25413`, `:25446` |
| `SurfaceTools.MergeSurfaces(...)` (Z-усреднение слияния двух TIN) | `Topomatic.Sfc.cs:25892` |
| `AreaBetweenSurfacesCalculator.Execute(...)` (3D cut/fill между TIN) | `Topomatic.Sfc.cs:27551` |

---

## 🚨 Главные факты (из MASTER_REPORT.md §3)

### Триангуляция
- **Реальный триангулятор:** `DynamicCachedBuilder` (`Topomatic.Cad.Foundation.cs:74248`) — инкрементальный Bowyer-Watson с edge-flip. O(n log n) среднее / O(n²) худшее.
- **float-точность** в incircle-предикате (`:74763-74795`) — **не double**.
- `ActiveRibsBuilder` (`:73466`) — НЕ триангулятор, это constraint-edge stitcher.
- **Нативного триангулятора НЕТ** — всё на managed C#.

### Индексы
- `PointIndexer.Update` / `TriangleIndexer.Update`: **O(n), параллельная 8×8 uniform-сетка** (НЕ quadtree, НЕ O(n log n)).
- `BoundingBox2D.Contains(point)` — epsilon 1e-6 (точка на границе считается внутри).

### Транзакции / undo
- `UndoObject.EndUpdate` **НЕ триангулирует** — только undo bookkeeping + событие (`FoundationClasses.cs:9272-9309`).
- Только **внешний** `EndUpdate` коммитит в undo-стек (`FoundationClasses.cs:25622`). Внутренние — чистая группировка.
- **НЕ потокобезопасно** — голый `int++` на счётчике (`FoundationClasses.cs:25864`).
- Лимит истории undo по умолчанию — 64 транзакции.
- Non-undoable команда **отравляет** всю историю (чистит redo, может чистить undo).

---

## 🚨 Критический баг Robolas: FastSurfaceBuilder оставляет пустой массив треугольников

Подробно в `docs/topomatic-sweep/reports/MASTER_REPORT.md` §C1.

**Симптом:** после bulk-вставки через `FastSurfaceBuilder` (`Style.Dynamic=false` + raw `surface.Points.Add`):
- `surface.Points.Count == N`
- `surface.Triangles.Count == 0` ← триангуляция НЕ запустилась

**Причина:** триангуляция gated на `if (!point.IsSituation && surface.Style.Dynamic)` (`Sfc.cs:13948-13951`). С `Dynamic=false` — не запускается. `UndoObject.EndUpdate` триангуляцией не занимается.

**Фикс (3 опции):**
1. После bulk-вставки — явная триангуляция: `new DynamicCachedBuilder().Build(nodes, triangles)` (`Cad.Foundation.cs:74248`) → push в `surface.Triangles` через `TriangleEditor` под одним `BeginUpdate/EndUpdate`.
2. Или вставка через `PointEditor` с `Dynamic=true` (инкрементная, тяжелее, undo-friendly).
3. Или push одной `IrreversibleCommand` (`Sfc.cs:19659`) + `Regen` (но `Regen` перестраивает только индексы, не треугольники).

> Сегодня это **латентный** баг: ни один потребитель Robolas не запрашивает высоты/контуры на этих поверхностях. Но любая будущая операция `GetElevation`/`FindTriangle` вернёт null/мусор.

---

## ✅ Рецепт: построить TIN из точек (правильно)

```csharp
using Topomatic.Sfc;
using Topomatic.Cad.Foundation;   // DynamicCachedBuilder, Node, Triangle

// 1. Bulk-вставка точек (без триангуляции)
surface.BeginUpdate();
try {
    foreach (var pt in points) {
        surface.Points.Add(new SurfacePoint(pt));   // raw Add, O(1)
    }
    surface.PointIndexer.Invalidate();
}
finally { surface.EndUpdate(); }

// 2. ЯВНАЯ триангуляция (если нужны высоты/контуры/объёмы)
surface.BeginUpdate();
try {
    var nodes = new List<Node>();
    var triangles = new List<Triangle>();
    // ... собрать nodes из surface.Points
    new DynamicCachedBuilder().Build(nodes, triangles);   // Cad.Foundation.cs:74248
    // ... push triangles в surface.Triangles через TriangleEditor
}
finally { surface.EndUpdate(); }
```

---

## ✅ Рецепт: получить высоту земли в точке

```csharp
// через FindTriangle (если TIN триангулирован):
int triIdx = surface.TriangleIndexer.FindTriangle(point);
if (triIdx >= 0) {
    double? elev = surface.GetElevation(point);   // интерполяция по треугольнику
}
```

> ⚠️ `FindTriangle` вернёт -1, `GetElevation` — null, если треугольников нет (см. баг FastSurfaceBuilder выше).

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| Думать, что `EndUpdate` перестроит TIN | НЕ перестроит — нужна явная триангуляция |
| Считать `PointIndexer` quadtree | это 8×8 uniform-grid, O(n) |
| `ArrayMode.Polygon` для ускорения рендера точек | `ArrayMode.Point` уже оптимальна (один `glDrawArrays`); Polygon = fill triangles, медленнее |
| Ожидать «60× ускорения» от `Surface.EndUpdate` | миф (MASTER_REPORT §1) — EndUpdate не триангулирует |

---

## 🔗 Связанные
- `docs/topomatic-sweep/reports/MASTER_REPORT.md` §1 (C1), §3 (triangulation/transactions)
- [05 — Объёмы (Path 2: TIN vs TIN)](05-earthwork-volumes.md)
- [06 — Привязка земли](06-ground-surface-binding.md)
- [10 — Транзакции](10-transactions-undo.md)
