# Card 01 — Создание Alignment и регистрация в проекте

> Тема: создание новой трассы с нуля и её регистрация в активном проекте Robur.
> **Вердикт: ✅ VERIFIED** (все сигнатуры сверены с декомпилятом).

---

## Ключевая идея

`Alignment` — **abstract** (`Topomatic.Alg.cs:4639`). Его **нельзя** создать через `new`. Трасса создаётся **косвенно** через модель:

```
RoadModel (AlignmentModel)  ──CreateAlignment()──►  RoadAlignment (Alignment)
        ▲
        │ создаётся при регистрации
PluginCoreOps.CreateModel(folderModel, "Road", "name.roadx")
        ▲
        │ возвращает IProjectModel
(ModelProject)ApplicationHost.Current.ActiveProject
```

---

## Сигнатуры (verified)

| Сигнатура | Файл:строка |
|---|---|
| `public abstract class Alignment : UndoObject, IAlignmentContainer, IStgSerializable, IStationingContainer, IOwned` | `Topomatic.Alg.cs:4639` |
| `public sealed class RoadModel : AlignmentModel` | `Topomatic.Alg.Road.Core.cs:15519` |
| `public sealed class RailModel : AlignmentModel` | `Topomatic.Alg.Rail.Core.cs:26365` |
| `public sealed class SurveyModel : AlignmentModel` | `Topomatic.Alg.Survey.Core.cs:6006` |
| `public abstract class AlignmentModel : StateControllerObject, ISurfaceContainer, IAlignmentContainer, ...` | `Topomatic.Alg.Model.cs:4726` |
| `public Alignment Alignment { get; }` (на AlignmentModel) | `Topomatic.Alg.Model.cs:4875` |
| `protected abstract Alignment CreateAlignment();` (фабрика, override в RoadModel) | `Topomatic.Alg.Model.cs:5006` |
| `public RoadAlignment(this) { ... }` (тело RoadModel.CreateAlignment) | `Topomatic.Alg.Road.Core.cs:15593` |
| **`public RoadModel()` — zero-arg ctor** (вызывает `base..ctor()`) | `Topomatic.Alg.Road.Core.cs:15586` |
| `public string Name { get; set; }` (отображаемое имя трассы) | `Topomatic.Alg.cs:5990` |
| `public abstract string Alias { get; }` (read-only, типовой дискриминатор) | `Topomatic.Alg.cs:4739` |
| `RoadAlignment.Alias` override → `"Road"` | `Topomatic.Alg.Road.cs:47693` |
| `ROAD_ALIAS = "Road"`, `RAIL_ALIAS = "Rail"`, `SURVEY_ALIAS = "Survey"` | `Topomatic.Alg.cs:4602-4606` |

### Регистрация в проекте

| Сигнатура | Файл:строка |
|---|---|
| `public static IApplicationHost Current` (service locator) | `Topomatic.ApplicationPlatform.cs:4584` |
| `Project ActiveProject { get; }` (на IApplicationHost) | `Topomatic.ApplicationPlatform.cs:17330` |
| `public abstract class ModelProject : Project` (cast target для доступа к моделям) | `Topomatic.ApplicationPlatform.cs:11211` |
| `IProjectModel Model { get; }` (корень дерева моделей) | на ModelProject |
| `public static IProjectModel FindFolderModel(IProjectModel)` | `Topomatic.ApplicationPlatform.cs` (PluginCoreOps) |
| **`public static IProjectModel CreateModel(IProjectModel folderModel, string modelType, string prefferedName)`** — ВЫСОКОУРОВНЕВАЯ фабрика | `Topomatic.ApplicationPlatform.cs:18878` |
| `public static IProjectModel CreateModel(IProjectModel folderModel, string modelType)` (2-arg overload) | `Topomatic.ApplicationPlatform.cs:18903` |
| `internal IProjectModel Project.CreateModel(URI uri, string modelType)` (низкоуровневый) | `Topomatic.ApplicationPlatform.cs:12391` |
| `IProjectModel ProjectModel.Add(URI uri, string modelType)` (регистрация в папке) | `Topomatic.ApplicationPlatform.cs:15639` |
| `IProjectModel ProjectModel.Add(URI uri)` (вывод modelType из расширения) | `Topomatic.ApplicationPlatform.cs:15698` |

### URI

| Сигнатура | Файл:строка |
|---|---|
| `public class URI` | `Topomatic.FoundationClasses.cs:25986` |
| `public URI(string uri)` | `Topomatic.FoundationClasses.cs:26075` |
| `public URI(string baseUri, string relative)` | `Topomatic.FoundationClasses.cs:26094` |
| `public URI(URI baseUri, string relative)` | `Topomatic.FoundationClasses.cs:26125` |

> ⚠️ У `URI` **нет** `Parse` и **нет** неявного преобразования из `string` — только `new URI(...)`.

---

## ⚠️ Важное предупреждение: `modelType`

`modelType` для дорожной модели = **строка `"Road"`** (совпадает с `ROAD_ALIAS`).
**НЕ путать** с `ModelTemplateSettings.CreateModel` (`ApplicationPlatform.cs:13253`) — это шаблон-райтер, **не** API регистрации. Реальная фабрика — `PluginCoreOps.CreateModel` (`:18878`).

---

## 🥇 GOLD-паттерн (реальный код Topomatic)

Источник: `Topomatic.Glg.Controller.cs:60084` (конкретный call-site в ядре):

```csharp
IProjectModel folderModel = PluginCoreOps.FindFolderModel(activeAlignmentReciver.ProjectModel);
using TransactableUpdateLoop loop = TransactableUpdateLoop.CreateProjectLoop();
try {
    IProjectModel projectModel = PluginCoreOps.CreateModel(
        folderModel, "<modelType>", activeAlignmentReciver.Name + "<ext>");
    projectModel.LockWrite();
    try {
        /* populate the model */
    } finally { projectModel.UnlockWrite(); }
}
catch { loop.Commit = false; }
finally { loop.Commit = true; }
```

Другие call-site'ы: `Topomatic.Alg.Controller.cs:10222/10232/11801/12097`, `Topomatic.Extentions.Controller.cs:13859/34292/35875`, `Topomatic.Alg.Runtime.cs:46872`, `Topomatic.Sites.Controller.cs:12659`, `Topomatic.Genplan.Controller.cs:20999`.

---

## ✅ Рецепт: создать и зарегистрировать RoadModel

```csharp
using Topomatic.Alg.Road.Core;          // RoadModel
using Topomatic.ApplicationPlatform;    // ApplicationHost, ModelProject, PluginCoreOps
using Topomatic.FoundationClasses;      // URI, TransactableUpdateLoop

// 1. Получить активный проект и его корневую модель
var project     = (ModelProject)ApplicationHost.Current.ActiveProject;
var rootModel   = project.Model;
var folderModel = PluginCoreOps.FindFolderModel(rootModel);

// 2. Зарегистрировать новую модель (транзакционно)
using var loop = TransactableUpdateLoop.CreateProjectLoop();
IProjectModel roadPM;
try {
    roadPM = PluginCoreOps.CreateModel(folderModel, "Road", "MyRoad.roadx");
    roadPM.LockWrite();
    try {
        // 3. Модель и трасса уже материализованы через плагин-фабрику
        var roadModel = (RoadModel)roadPM.Model;     // RoadModel.CreateAlignment() уже вызвана
        var alg       = roadModel.Alignment;          // RoadAlignment

        // 4. Задать имя (Alias "Road" — read-only)
        alg.Name = "My Road";

        // ... здесь: план (card 02), профиль (card 03), поперечники (card 04)
    }
    finally { roadPM.UnlockWrite(); }
}
catch {
    loop.Commit = false;   // откатить при ошибке
    throw;
}
finally { loop.Commit = true; }
```

---

## ❌ Частые ошибки (что НЕ работает)

| Ошибка | Почему не работает |
|---|---|
| `new Alignment()` | `Alignment` — abstract (`Alg.cs:4639`) |
| `new RoadAlignment()` | конструктор внутренний |
| `view.Document.Alignments.Add(alg)` | у CadView нет коллекции `Alignments` |
| `ApplicationHost.Current.ActiveProject.AddAlignment(...)` | нет такого метода у Project |
| `new URI("path")` → ожидать `Parse`/implicit | у URI нет ни `Parse`, ни implicit-каста |
| Вызвать `ModelTemplateSettings.CreateModel` (`:13253`) вместо `PluginCoreOps.CreateModel` (`:18878`) | первый — шаблон-райтер, не регистрирует модель |

---

## 🔗 Связанные карточки
- [02 — План трассы (PlanLine)](02-planline-geometry.md)
- [09 — Регистрация плагина ([cmd])](09-plugin-registration.md)
- [10 — Транзакции (UpdateLoop)](10-transactions-undo.md)
