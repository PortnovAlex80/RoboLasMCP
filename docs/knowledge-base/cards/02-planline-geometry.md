# Card 02 — План трассы: PlanLine, Vertex, VertexItem

> Тема: задание плана трассы (PI-точки, радиусы круговых кривых, переходные клотоиды).
> **Вердикт: ✅ VERIFIED**

---

## Ключевая идея

План — это **`PlanLine`** (`Topomatic.Alg.cs:21444`), который реализует `IList<PlanLine.Vertex>`. **Каждая PI-точка** — это `PlanLine.Vertex` с координатой `Position` и **коллекцией параметров кривой** `VertexItem`.

```
Alignment.Plan : PlanLine (IList<Vertex>)
    └── Vertex[i]
            ├── Position : Vector2D          (координата PI)
            └── IList<VertexItem>            (параметры кривой в этой вершине)
                    └── VertexItem { L1, R, K, L2 }   (входная клотоида, радиус, параметр, выходная)
```

> ⚠️ **НЕТ классов** `CircleElement`, `ClothoidElement`, `SpiralElement`, `LineElement`, `TransitionCurve`, `PITable`, `PIRow`, `HPI`, `VPI`. Всё это — галлюцинации (см. `meta/CATALOG_HALLUCINATIONS.md`).

---

## Сигнатуры (verified)

### `PlanLine`
| Сигнатура | Файл:строка |
|---|---|
| `public class PlanLine : UndoObject, IEnumerable<PlanLine.Vertex>, IList<PlanLine.Vertex>, ICollection<PlanLine.Vertex>, IStgSerializable, IEquatable<PlanLine>, IObjectDisjoiner, IAlignmentContainer, IOwned` | `Topomatic.Alg.cs:21444` |
| `public void Add(Vertex item)` | `Topomatic.Alg.cs:23338` |
| `public void Insert(int index, Vertex item)` | `Topomatic.Alg.cs:23302` |
| `public Vertex this[int index]` (indexer) | (IList<Vertex>) |
| `public int Count` | (IList<Vertex>) |
| `public CompoundLine CompoundLine { get; }` (геометрическое представление, O(1) cached) | `Topomatic.Alg.cs` / `Cad.Foundation.cs:37245` |
| `public void Invert()` (развернуть направление) | в теле ядра |

### `PlanLine.Vertex`
| Сигнатура | Файл:строка |
|---|---|
| `public class Vertex : UpdatableObject, ICollection<VertexItem>, IList<VertexItem>, ...` | `Topomatic.Alg.cs:21446` |
| `public Vector2D Position { get; set; }` | `Topomatic.Alg.cs:21580` |
| `public uint ID { get; internal set; }` | `Topomatic.Alg.cs:21552` |
| `public double P { get; internal set; }` (внутренний параметр) | `Topomatic.Alg.cs:21589` |
| `public double Beta { get; internal set; }` | `Topomatic.Alg.cs:21605` |
| `public double MinLineLength { get; set; }` | `Topomatic.Alg.cs:21621` |
| `public PlanLine PlanLine { get; }` (back-reference) | ~`Topomatic.Alg.cs:21640` |
| `public void Add(VertexItem item)` | `Topomatic.Alg.cs:22065` |
| `public void Insert(int index, VertexItem item)` | `Topomatic.Alg.cs:22006` |
| `public void Clear()` (очищает VertexItem-ы) | в теле ядра |
| `public void Assign(Vertex other)` (копирует параметры из другой вершины) | в теле ядра |

### `PlanLine.Vertex.VertexItem` (struct!)
| Сигнатура | Файл:строка |
|---|---|
| `public struct VertexItem : IEquatable<VertexItem>` | `Topomatic.Alg.cs:21509` |
| `public double L1;` — длина входной переходной кривой, м | `Topomatic.Alg.cs:21511` |
| `public double R;` — радиус круговой кривой, м | `Topomatic.Alg.cs:21513` |
| `public double K;` — параметр клотоиды (K = √(R·L)) | `Topomatic.Alg.cs:21515` |
| `public double L2;` — длина выходной переходной кривой, м | `Topomatic.Alg.cs:21517` |

> **Поля — mutable public fields** (это struct). Используйте object initializer: `new VertexItem { L1=..., R=..., K=..., L2=... }`.

### Свойство `Alignment.Plan`
| Сигнатура | Файл:строка |
|---|---|
| `public PlanLine Plan { get; }` | `Topomatic.Alg.cs:4755` |

---

## Геометрический смысл полей `VertexItem`

Классическая схема «прямая → входная клотоида → круговая → выходная клотоида → прямая»:

```
┌─ прямая (tangent) ─┬─ клотоида L1 ─┬─ круговая R ─┬─ клотоида L2 ─┬─ прямая ─┐
                     ▲                              ▲                              ▲
                     │                              │                              │
                  точка TS                       точка SC/CS                    точка CS
```

- **`R`** — радиус круговой кривой в вершине поворота (например, 250 м).
- **`L1`** — длина входной клотоиды (переходной кривой), м.
- **`L2`** — длина выходной клотоиды, м.
- **`K`** — параметр клотоиды. **Связан с L и R: `K = √(R · L)`**. Для симметричной клотоиды L1=L2=L → K = √(R·L).
  - Пример: R=250 м, L1=L2=80 м → K = √(250·80) = √20000 ≈ **141.42**.

> **Нет enum `SpiralType`/`ClothoidType`.** Тип переходной кривой неявный — клотоида (радиоидальная спираль). Если нужны другие типы (кубическая парабола и т.п.) — это, скорее всего, настройки на уровне модели (требует отдельного ресёрча).

---

## 🥇 GOLD-паттерн (реальный код Topomatic)

Источник: `Topomatic.Alg.cs` функция `JoinVertexes` (~строки 25280–25400) — это **доказательство**, что API ниже каноничное:

```csharp
PlanLine planLine = new PlanLine(null);
planLine.BeginUpdate();
try {
    planLine.Add(new PlanLine.Vertex { Position = pos1 });

    PlanLine.Vertex v = new PlanLine.Vertex();
    v.Position = intersectionPoint;
    v.Add(new PlanLine.Vertex.VertexItem { L1 = lIn, R = radius, K = kParam, L2 = lOut });
    planLine.Add(v);

    planLine.Add(new PlanLine.Vertex { Position = pos2 });
}
finally { planLine.EndUpdate(); }

if (PlanLineValid(planLine).Length == 0) { /* OK */ }
```

---

## ✅ Рецепт: трасса с 3 углами поворота, R=250, симметричные клотоиды 80 м

4 PI-точки = 3 угла поворота (первая и последняя PI — без кривой):

```csharp
using Topomatic.Alg;
using Topomatic.Cad.Foundation;   // Vector2D

const double R = 250.0;          // радиус
const double L = 80.0;           // длина клотоиды (входная = выходная)
const double K = 141.42;         // √(250·80)

var pi = new[] {
    new Vector2D { X =     0.0, Y =     0.0 },
    new Vector2D { X =  2000.0, Y =   500.0 },
    new Vector2D { X =  3500.0, Y =   520.0 },
    new Vector2D { X =  5000.0, Y =     0.0 },
};

alg.Plan.BeginUpdate();
try {
    // первая PI — без кривой
    alg.Plan.Add(new PlanLine.Vertex { Position = pi[0] });

    // промежуточные PI (3 угла поворота) — с круговой + клотоидами
    for (int i = 1; i < pi.Length - 1; i++) {
        var v = new PlanLine.Vertex { Position = pi[i] };
        v.Add(new PlanLine.Vertex.VertexItem { L1 = L, R = R, K = K, L2 = L });
        alg.Plan.Add(v);
    }

    // последняя PI — без кривой
    alg.Plan.Add(new PlanLine.Vertex { Position = pi[pi.Length - 1] });
}
finally { alg.Plan.EndUpdate(); }

// длина трассы (O(1), cached):
double length = alg.Plan.CompoundLine.Length;
```

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `plan.Vertices.Add(new PIPoint{X,Y,R})` | `plan.Add(new PlanLine.Vertex{Position=...})` + `v.Add(new VertexItem{...})` |
| Искать `CircleElement`/`ClothoidElement` | их нет — кривая кодируется в `VertexItem{R,K,L1,L2}` |
| `SpiralType.Clothoid` | такого enum нет — клотоида неявная |
| Менять `Plan` без `BeginUpdate/EndUpdate` | всё редактирование — в транзакции (см. card 10) |
| Не оборачивать `EndUpdate` в `finally` | при исключении останется открытая транзакция |

---

## 🔗 Связанные карточки
- [01 — Создание Alignment](01-alignment-creation.md)
- [03 — Вертикальный профиль](03-vertical-profile.md)
- [10 — Транзакции](10-transactions-undo.md)
