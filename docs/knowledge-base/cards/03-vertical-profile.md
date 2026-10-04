# Card 03 — Вертикальный профиль: Transition.RedProfile, ProjectNode

> Тема: задание проектного (красного) продольного профиля трассы.
> **Вердикт: ✅ VERIFIED** — и **исправляет критический фейк** в предыдущей базе знаний.

---

## ⚠️ Главное исправление (фейк разоблачён)

**Предыдущая база утверждала:** «`Corridor.RedProfile`, `Corridor.StaticEg`, `Corridor.DynamicEg`» — продольный профиль на коридоре.

**Реальность:** эти свойства **на `Transition`**, а не на `Corridor`! Цитированные строки 29643–29710 в `Topomatic.Alg.cs` находятся **внутри тела `class Transition`** (декларация на :29607), а не `Corridor`.

> У `Corridor` (`Topomatic.Alg.cs:18832`) **НЕТ** profile-свойств. Только `Sections`, `Constructions`, design-context builders.

---

## Ключевая идея

```
Alignment.Transitions : ITransitions          (Alg.cs:4878)
    └── Transition[i]                          (abstract, Alg.cs:29607)
            ├── RedProfile : ProjectProfile    (проектный/красный профиль, Alg.cs:29682)
            ├── StaticEg   : StaticProfile     (существующая земля, статичная, :29700)
            ├── DynamicEg  : DynamicProfile    (существующая земля, динамическая, :29691)
            ├── EgProfile  : Profile           (возвращает Eg: dynamic если IsDynamicEarth, иначе static, :29709)
            ├── AgProfile  : AgProfile         (:29643)
            └── UserProfiles : UserProfiles    (:29721)

ProjectProfile : IList<ProjectNode>           (Alg.cs:27243)
    └── ProjectNode { Station, Elevation, Length, Radius, Flags }  (struct, Alg.cs:27060)
```

`Transition` — это «одна секция трассы между переломами направления». Для большинства трасс есть **одна** transition (`Transitions[0]`). Профиль задаётся на ней.

---

## Сигнатуры (verified)

### Доступ к профилю
| Сигнатура | Файл:строка |
|---|---|
| `public ITransitions Transitions { get; }` (на Alignment) | `Topomatic.Alg.cs:4878` |
| `interface ITransitions : IEnumerable, IStgSerializable` (indexer `Transition this[int]`, `Count`, `IndexOf`, `GetPrevious`, `GetNext`, `Clear`) | `Topomatic.Alg.cs:25418` |
| `public abstract class Transition : UpdatableObject, IAlignmentContainer, IStgSerializable, ITransitionContainer, IOwned` | `Topomatic.Alg.cs:29607` |
| `public ProjectProfile RedProfile { get; }` (на Transition) | `Topomatic.Alg.cs:29682` |
| `public StaticProfile StaticEg { get; }` | `Topomatic.Alg.cs:29700` |
| `public DynamicProfile DynamicEg { get; }` | `Topomatic.Alg.cs:29691` |
| `public Profile EgProfile { get; }` (dynamic если `IsDynamicEarth`, иначе static) | `Topomatic.Alg.cs:29709` |
| `public AgProfile AgProfile { get; }` | `Topomatic.Alg.cs:29643` |
| `public UserProfiles UserProfiles { get; }` | `Topomatic.Alg.cs:29721` |

> ⚠️ У `ITransitions` **нет метода `Add`** — коллекция управляется `Alignment` внутренне. Для обычной трассы `Transitions[0]` уже существует после создания.

### `ProjectProfile` — это `IList<ProjectNode>`
| Сигнатура | Файл:строка |
|---|---|
| `public class ProjectProfile : UndoObject, IEnumerable<ProjectNode>, IList<ProjectNode>, ICollection<ProjectNode>, IStgSerializable, IOwned, ITransitionContainer, IProfile, IAlignmentContainer` | `Topomatic.Alg.cs:27243` |
| `public ProjectNode this[int index] { get; set; }` | `Topomatic.Alg.cs:27355` |
| backing store: `private TransactableList<ProjectNode>` | `Topomatic.Alg.cs:27263` |
| `FirstGrade`, `LastGrade` (double), `SplineMode` (bool) | ~`:27320` |

> `ProjectProfile` создаётся `Transition` внутренне и доступен только через `Transition.RedProfile`. **Прямой `new ProjectProfile()` не используется** плагинами.

### `ProjectNode` (struct!)
| Сигнатура | Файл:строка |
|---|---|
| `public struct ProjectNode : IEquatable<ProjectNode>` | `Topomatic.Alg.cs:27060` |
| `public double Station;` | `Topomatic.Alg.cs:27061` |
| `public double Elevation;` | `Topomatic.Alg.cs:27063` |
| `public double Length;` | (поле между переломами) |
| `public double Radius;` | (радиус вертикальной кривой) |
| `public ProjectNodeFlags Flags;` | (выбирает Length vs Radius) |
| `public Vector2D Position { get; set; }` (x=Station, y=Elevation) | в теле |
| `public bool HasCurve { get; }` | в теле |
| **`public ProjectNode(double x, double y, double length, double radius, ProjectNodeFlags flags)`** | `Topomatic.Alg.cs:27097` |
| `public ProjectNode(ProjectNode node)` (копирующий) | `Topomatic.Alg.cs:27111` |
| `public static ProjectNode LoadFromStg(StgNode)` | `Topomatic.Alg.cs:27125` |

> ⚠️ **Сигнатура 5-аргументного ctor:** `(double x, double y, double length, double radius, ProjectNodeFlags flags)`.
> Это **НЕ** `(station, elevation, convexR, concaveR, flags)`, как писали раньше.
> **Параметр 3 — `length`, параметр 4 — `radius`.** Какой из них используется — решает `Flags`.

### `ProjectNodeFlags` enum
| Сигнатура | Файл:строка |
|---|---|
| `public enum ProjectNodeFlags` | `Topomatic.Alg.cs:27238` |
| `UseLength = 0` — использовать поле `Length` как параметр вертикальной кривой | |
| `UseRadius = 1` — использовать поле `Radius` | |

> ⚠️ Enum называется **`ProjectNodeFlags`** (множ. ч.), **не** `ProjectNodeFlag`. Значений `None`/`Fixed`/`Curve` **не существует** — это был фейк.

---

## Геометрический смысл

Продольный профиль — последовательность переломов (VPI). Между ними прямые участки (уклоны), в переломах — вертикальные кривые:

```
высота
  ▲
  │         ●─────●         (ProjectNode со Station, Elevation)
  │        /       \
  │       /         \       (вертикальная кривая в переломе,
  │      ●           ●       параметр Length или Radius)
  │
  └──────────────────────► пикет (Station)
```

- **`Station`** — пикет перелома (м).
- **`Elevation`** — проектная высота в этой точке (м).
- **`Length`/`Radius`** — параметр вертикальной кривой в этом переломе.
- **`Flags`** — какую из двух величин трактовать как параметр кривой.

---

## 🥇 GOLD-паттерн

Источник: контроллер Topomatic `Topomatic.Alg.Controller.cs:5494` — реальное создание `ProjectNode`:

```csharp
new ProjectNode(double station, double elevation, double convexRadius, double concaveRadius, ProjectNodeFlag flags)
//  ↑ БЫЛО в старом комментарии — НЕВЕРНО
// ВЕРНО (Alg.cs:27097):
new ProjectNode(double x /*station*/, double y /*elevation*/, double length, double radius, ProjectNodeFlags flags)
```

Применение (обобщено из контроллера):

```csharp
Transition t = alg.Transitions[0];
ProjectProfile red = t.RedProfile;
red.BeginUpdate();
try {
    red.Add(new ProjectNode(0,    100.0, length: 0,  radius: 5000, ProjectNodeFlags.UseRadius));
    red.Add(new ProjectNode(2500, 102.5, length: 0,  radius: 5000, ProjectNodeFlags.UseRadius));
    red.Add(new ProjectNode(5000, 105.0, length: 0,  radius: 5000, ProjectNodeFlags.UseRadius));
}
finally { red.EndUpdate(); }
```

---

## ✅ Рецепт: задать проектный профиль на новой трассе

```csharp
using Topomatic.Alg;

Transition t   = alg.Transitions[0];
ProjectProfile red = t.RedProfile;     // уже создан Transition'ом

red.BeginUpdate();
try {
    red.Clear();   // для новой трассы безопасно
    red.Add(new ProjectNode(station: 0,    elevation: 100.0,
                            length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
    red.Add(new ProjectNode(station: 2500, elevation: 102.5,
                            length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
    red.Add(new ProjectNode(station: 5000, elevation: 105.0,
                            length: 0, radius: 5000, ProjectNodeFlags.UseRadius));
}
finally { red.EndUpdate(); }
```

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `alg.Corridor.RedProfile` | `alg.Transitions[0].RedProfile` (на Transition!) |
| `alg.Profile` | такого свойства на Alignment **нет** |
| `ProjectNodeFlag` | `ProjectNodeFlags` (множ. ч.) |
| `ProjectNode(s, e, convexR, concaveR, flags)` | `ProjectNode(x, y, length, radius, flags)` — flag выбирает length/radius |
| `ProjectNodeFlags.None / .Fixed / .Curve` | их нет — только `UseLength`, `UseRadius` |
| Искать `VPI`/`ProfileNode` как класс PI-таблицы | вертикальный PI = `ProjectNode` (struct) |

---

## 🔗 Связанные карточки
- [01 — Создание Alignment](01-alignment-creation.md)
- [04 — Коридор и поперечники](04-corridor-sections.md)
- [06 — Привязка земли (StaticEg)](06-ground-surface-binding.md)
