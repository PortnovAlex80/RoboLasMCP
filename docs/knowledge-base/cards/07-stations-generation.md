# Card 07 — Генерация пикетов: MakeWholeStations vs MakeStations

> Тема: неразрушающая генерация списка пикетов (станций) для построения поперечников.
> **Вердикт: ✅ VERIFIED**

---

## Ключевая идея

`AlignLibrary.MakeWholeStations` — **неразрушающий** генератор списка пикетов. Возвращает `List<double>` станций, не трогая `Corridor.Sections`. Это **рекомендуемый** способ перед добавлением сечений (вместо `Sections.Clear()`).

```
MakeWholeStations(alg, start, end, step, outList, canTerminate)
    → заполняет outList двойными: start, end, и шагом step между каждой парой
      горизонтальных точек излома плана (Whole/круглые станции)
```

---

## Сигнатуры (verified)

### `MakeWholeStations` — основная (рабочая лошадка)
| Сигнатура | Файл:строка |
|---|---|
| `class AlignLibrary` (static) | `Topomatic.Alg.Runtime.cs:51955` |
| **`public static bool MakeWholeStations(Alignment alignment, double startStation, double endStation, double step, List<double> stations, bool canTerminate)`** | `Topomatic.Alg.Runtime.cs:52797` |

**Параметры (verified):**
- `alignment` — трасса
- `startStation`, `endStation` — диапазон
- `step` — шаг между пикетами, м
- `stations` — приёмник (заполняется)
- `canTerminate` — cooperativa cancellation flag

> ⚠️ **Параметра `includeEnds` НЕТ** — оба конца (start, end) всегда вставляются.

Поведение: вставляет `startStation` и `endStation`, затем между каждой парой `alignment.Stationing.Stations` (точек горизонтального излома плана) — точки с шагом `step`. Возвращает `false` при отмене.

### `MakeStations` — высокоуровневая обёртка
| Сигнатура | Файл:строка |
|---|---|
| `public static bool MakeStations(Alignment alignment, double startStation, double endStation, double step, BuildProfileFlags options, IEnumerable<double> additionalStations, Topomatic.Alg.Runtime.Communications.Communications communications, IEnumerable<Surface> surfaces, List<double> stations, bool canTerminate)` | `Topomatic.Alg.Runtime.cs:52844` |

Учитывает `BuildProfileFlags` (`StepStations`, `WholeStations`, `Sections`, …), добавляет `additionalStations`, вставляет станции из существующих `Corridor.Sections`. Внутри **вызывает `MakeWholeStations`** (`:52849`), если выставлен флаг `StepStations`.

---

## 🥇 GOLD-паттерн: call-site'ы MakeWholeStations в ядре

Подтверждённые места, где Topomatic САМ использует `MakeWholeStations` для построения сечений/профиля (`Topomatic.Alg.Runtime.cs`):
- `:21951`, `:22202`, `:22606`, `:22727`, `:22879`, `:25187`, `:25726`

Все вызывают одинаково: `AlignLibrary.MakeWholeStations(alignment, start, end, Step, list, canTerminate: false)`.

---

## ✅ Рецепт: получить список пикетов каждые 20 м

```csharp
using Topomatic.Alg;
using Topomatic.Alg.Runtime;

double length = alg.Plan.CompoundLine.Length;     // O(1) cached

var stations = new System.Collections.Generic.List<double>();
AlignLibrary.MakeWholeStations(
    alignment:    alg,
    startStation: 0.0,
    endStation:   length,
    step:         20.0,
    stations:     stations,
    canTerminate: false);

// stations теперь содержит [0, 20, 40, ..., length]
// (с дополнительными точками на переломах плана)
```

Затем добавить в коридор **неразрушающе** (см. card 04):

```csharp
using (alg.Corridor.Sections.BeginUpdate()) {
    foreach (double s in stations) {
        alg.Corridor.Sections.Add(s);   // idempotent на станции
    }
}   // EndUpdate в finally
```

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `Sections.Clear()` + ручной цикл станций | `MakeWholeStations` + merge-идиома (см. card 04) |
| `Stationing.Stations` свойство | `[Obsolete]` + аллоцирует `new List<double>()` на каждый вызов (`Alg.cs:17248`) — используйте `FillWholes(buffer)` |
| Думать, что `MakeWholeStations` добавляет сечения в Corridor | нет — он только заполняет `List<double>` |

---

## 🔗 Связанные карточки
- [04 — Коридор и поперечники](04-corridor-sections.md)
- [02 — План трассы](02-planline-geometry.md)
