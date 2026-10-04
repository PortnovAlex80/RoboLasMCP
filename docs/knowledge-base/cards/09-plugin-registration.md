# Card 09 — Регистрация плагина: [cmd], PluginInitializator, manifest

> Тема: как плагин (Robolas) регистрируется в хосте Robur и объявляет команды.
> **Вердикт: ✅ VERIFIED** — опирается на `MASTER_REPORT.md` §3 (Plugin loading contract).

---

## Контракт загрузки плагина (verified)

| Сигнатура | Файл:строка |
|---|---|
| `public abstract class PluginHostInitializator` — `protected abstract Type[] GetTypes()`; `public virtual Initialize(PluginFactory)` создаёт инстансы и вызывает `child.Initialize(factory)` | `Topomatic.ApplicationPlatform.cs:19191` |
| `public virtual void PluginInitializator.Initialize(PluginFactory)` — рефлексия по собственным методам с `[cmd(...)]` → `factory.RegisterFunction(cmd, PluginFunction)` | `Topomatic.ApplicationPlatform.cs:19352-19372` |
| `cmdAttribute` invocation разворачивает `TargetInvocationException` → исключение плагина всплывает | `Topomatic.ApplicationPlatform.cs:19261-19268` |
| `public static IApplicationHost Current` (service locator: `.Plugins`, `.ActiveProject`, `.Settings`, `.MainForm`) | `Topomatic.ApplicationPlatform.cs:4584` |

**Важно:** `PluginFactory` — ABSTRACT; реальная реализация — в host EXE (не в декомпилированном корпусе). В корпусе только декоратор `PluginFactoryWrapper`. Robolas **не вызывает** `Register*` напрямую — полагается на `[cmd]`-рефлексию + `LAS_TERRAIN.plugin` manifest.

---

## Manifest: `LAS_TERRAIN.plugin`

Discovery механизма в декомпилированном коде НЕТ (живёт в host EXE). Формат (из собственного манифеста Robolas):

```json
{
  "assemblies": {
    "Name": { "assembly": "dll, FullyQualifiedHostType" }
  },
  "actions":  { "id": { "cmd": "...", "title": "...", "icon": "..." } },
  "menubars":  [...],
  "rbcrs":     [...],
  "toolbars":  [...],
  "panels":    [...],
  "ribbon":    [...]
}
```

---

## Эталон Robolas: `Module.cs` + `LasTerrainPluginHost.cs`

Robolas реализует `PluginHostInitializator` (хост) → возвращает типы модулей; каждый `Module : PluginInitializator` → методы с `[cmd("...")]` становятся командами хоста. Плюс command-registry abstraction Robolas'а поверх (`CommandRegistry/`, `Infrastructure/UserDialogs.cs`).

Это **корректный** паттерн — `[cmd]` + manifest, а НЕ `SectionCmdAttribute`/`SectionRegistry` (это внутренний слой Robolas, не Topomatic — поправка в `MASTER_REPORT.md`).

---

## ✅ Рецепт: объявить команду плагина

```csharp
using Topomatic.ApplicationPlatform;
using Topomatic.Cad.View;          // CadView (через view)

public class MyModule : PluginInitializator
{
    [cmd("my_build_route")]
    private object BuildRoute()
    {
        // тело команды — здесь код из карточек 01-07
        var alg = /* ... создать/получить Alignment ... */;
        return null;
    }
}
```

И в `LAS_TERRAIN.plugin` добавить экшен:
```json
"my_build_route": { "cmd": "my_build_route", "title": "Построить трассу", "icon": "..." }
```

---

## ❌ Частые ошибки

| Ошибка | Правильно |
|---|---|
| `SectionCmdAttribute`/`SectionRegistry` как механизм регистрации | это внутренний слой Robolas; реальный — `[cmd]` + manifest |
| Искать `PluginFactory.RegisterFunction` в коде ядра | он в host EXE; плагин только ставит `[cmd]` |
| Регистрировать модель через `CadView` | модель регистрируется через `Project` (card 01) |

---

## 🔗 Связанные
- `docs/topomatic-sweep/reports/MASTER_REPORT.md` §3 (Plugin loading contract)
- [01 — Создание Alignment](01-alignment-creation.md)
- Robolas: `Module.cs`, `LasTerrainPluginHost.cs`, `CommandRegistry/`
