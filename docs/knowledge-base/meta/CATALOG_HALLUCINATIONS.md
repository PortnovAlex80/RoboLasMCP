# Реестр галлюцинаций в базе знаний Topomatic

> **Цель:** предотвратить повторное использование фейковых сигнатур при написании плагинов.
> **Источник проверки:** `docs/topomatic-sweep/decompiled/*.cs` (ground truth).
> **Подозреваемые источники фейков:** `docs/topomatic-api-catalog/MASTER_INDEX.md` и нарративные гайды.

---

## Правило для всех агентов

> **Любая сигнатура без `file:line` в `decompiled/*.cs` считается неподтверждённой и подлежит проверке.**
> Если встречаешь тип/метод из этого реестра — **не используй**, бери верифицированную альтернативу.

---

## 📋 Сводная таблица фейков

| # | Фейк (как встречается) | Реальность | Категория |
|---|---|---|---|
| 1 | `Alignment.Profile` | Не существует. Профиль — на `Alignment.Transitions[i].RedProfile` | Полная выдумка |
| 2 | `Corridor.RedProfile` / `Corridor.StaticEg` / `Corridor.DynamicEg` / `Corridor.EgProfile` | Все на **`Transition`**, не на Corridor (строки Alg.cs:29643-29710 — внутри `class Transition`) | Ошибка атрибуции |
| 3 | `new Alignment()` | `Alignment` — **abstract**. Через `AlignmentModel.CreateAlignment()` | Несуществующий ctor |
| 4 | `CircleElement`, `ClothoidElement`, `SpiralElement`, `CurveElement`, `StraightElement`, `LineElement`, `TransitionCurve` | Не существуют. Кривая = `PlanLine.Vertex.VertexItem { L1, R, K, L2 }` | Полная выдумка |
| 5 | `PITable`, `PIRow`, `HPI`, `VPI` | Не существуют. PI = `PlanLine.Vertex`; вертик. PI = `ProjectNode` | Полная выдумка |
| 6 | `SpiralType`, `SpiralType.Clothoid` | Не существует. Тип клотоиды неявный (параметр K в VertexItem) | Полная выдумка |
| 7 | `EarthworkCalculator`, `MassDiagram`, `BalanceLine`, `QuantitiesTable`, `Quantities`, `SoilVolumes`, `VolumesCalculator` | Не существуют. Объёмы = `VolumeCalcer` или `AreaBetweenSurfacesCalculator` | Полная выдумка |
| 8 | `CadView.Alignments`, `AlignmentList`, `AddAlignment`, `OpenAlignment` | Не существуют. Регистрация через `PluginCoreOps.CreateModel(folderModel, "Road", name.roadx)` | Полная выдумка |
| 9 | `UserDialog` (без `s`) как класс SDK | Не существует в SDK. ⚠️ В **Robolas** есть свой `LAS_TERRAIN.Infrastructure.UserDialogs` — это код Robolas, не SDK | Ловушка |
| 10 | `ArrayMode.{Points, Lines, Triangles}` | Не существуют. Enum = `{Polyline, Polygon, Point}` (только 3 значения) | Полная выдумка |
| 11 | `CrsSurfaceBuilder` в **Topomatic.Crs.Runtime** | Реально в `Topomatic.Alg.Runtime.cs:55521` | Ошибка DLL |
| 12 | `PropertyExplorer` в **Topomatic.Controls** | Реально в `Topomatic.ComponentModel.cs:9649` | Ошибка DLL |
| 13 | `ProjectNodeFlag` (един. ч.) | Enum называется **`ProjectNodeFlags`** (множ. ч.) | Ошибка имени |
| 14 | `ProjectNodeFlag.None / .Fixed / .Curve` | Не существуют. Только `UseLength=0`, `UseRadius=1` | Полная выдумка |
| 15 | `ProjectNode(s, e, convexR, concaveR, flags)` ctor | Реально: `ProjectNode(x, y, length, radius, flags)` — flag выбирает length/radius | Неверная сигнатура |
| 16 | `Alignment.EgSurface`, `Corridor.EgSurface`, `GroundSurface`, `ExistingSurface` | Не существуют. Привязка земли — `Alignment.EgSurfaceRelativePaths : IList<string>` | Полная выдумка |
| 17 | `Alignment.Profile` для вертик. | (см. #1) | — |
| 18 | `Surface.EndUpdate()` = «O(n log n) Delaunay, 60× ускорение» | EndUpdate НЕ триангулирует (только undo bookkeeping). Реальный триангулятор — `DynamicCachedBuilder` | Миф о производительности |
| 19 | `ArrayMode.Polygon` = «10-100× GPU speedup» | `ArrayMode.Point` уже один `glDrawArrays`; Polygon = fill triangles, медленнее | Миф о производительности |
| 20 | «60× faster», «10-100× GPU», «~650 LOC экономии» | Не выводятся из кода — маркетинговый шум без бенчмарков | Маркетинг |
| 21 | `PointIndexer.Update` = «O(n log n) QuadTree rebuild» | O(n), параллельная 8×8 uniform-сетка | Неверный алгоритм |
| 22 | Регистрация плагина через `SectionCmdAttribute`/`SectionRegistry` | Это внутренний слой Robolas. Реальный механизм — `[cmd]` + manifest | Концептуальная ошибка |
| 23 | `ActiveRibsBuilder` как «главный триангулятор» | Это constraint-edge stitcher. Главный — `DynamicCachedBuilder` (`Cad.Foundation.cs:74248`) | Неверная роль |
| 24 | `ModelTemplateSettings.CreateModel` (`ApplicationPlatform.cs:13253`) как API регистрации | Это шаблон-райтер. Реальная фабрика — `PluginCoreOps.CreateModel` (`:18878`) | Подмена API |

---

## Что НАДЕЖНО (можно доверять без проверки)

### Постраничные каталоги `dlls/*.md`
Сгенерированы рефлексией (PowerShell), точны как сигнатурный индекс. ~171 DLL, ~6225 типов.

### Конкретные верифицированные API (из карточек и `MASTER_REPORT.md`)
- Все ключевые сигнатуры `Topomatic.Sfc`: `Surface`, `StructureLine`, `SurfaceTools`, `PointIndexer`
- `UpdateLoop`, `Logger` в `Topomatic.FoundationClasses`
- `Topomatic.Controls`: `PropertyGrid`, `SimpleDlg`, `MessageDlg`
- `AlignLibrary.ScanCrossDtm` (3 перегрузки)
- `PlanLine`/`Vertex`/`VertexItem`/`Corridor`/`SectionList`/`Section`
- `VolumeCalcer`/`VolumesBuilder`/`AreaBetweenSurfacesCalculator`
- `ApplicationHost.Current`, `PluginCoreOps.CreateModel`, `ModelProject`

---

## Где именно живут галлюцинации

| Документ | Статус |
|---|---|
| `docs/topomatic-api-catalog/dlls/*.md` (постраничные) | ✅ надёжны |
| `docs/topomatic-api-catalog/MASTER_INDEX.md` | ⚠️ содержит галлюцинации (преимущественно в нарративе) |
| `docs/topomatic-api-catalog/PERFORMANCE_GUIDE.md` | ⚠️ «60×», «EndUpdate=Delaunay» — мифы (см. `MASTER_REPORT.md` §1) |
| `docs/topomatic-api-catalog/GRAPHICS_OPTIMIZATION_GUIDE.md` | ⚠️ «ArrayMode.Polygon 10-100×» — миф |
| `docs/topomatic-sweep/reports/MASTER_REPORT.md` | ✅ надёжный (он же опровергает мифы) |
| `docs/knowledge-base/cards/*.md` | ✅ надёжные (верифицированы) |
| `FAQ_topomatic.txt` | ✅ компактный cheat-sheet (точный) |

---

## Процесс добавления новых фейков

Если при работе найден новый фейк:
1. Добавить строку в таблицу выше (с верифицированной альтернативой).
2. Если фейк в публичном документе (`MASTER_INDEX.md` и т.д.) — пометить там TODO или исправить.
3. При необходимости — создать/обновить карточку в `cards/` с верифицированным API.

---

## 🔗 Связанные
- `docs/PLUGIN_DEMO_VERIFICATION_REPORT.md` — исходный отчёт, где многие фейки обнаружены
- `docs/topomatic-sweep/reports/MASTER_REPORT.md` §1 — опровержение мифов о производительности
