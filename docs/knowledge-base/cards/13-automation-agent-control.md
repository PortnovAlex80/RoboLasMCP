# Card 13 — Автоматизация и удалённое управление агентом (Automation)

> Тема: как агент (LLM/внешний процесс) может управлять Topomatic Robur — чертить, строить трассы, считать объёмы **без человека и без взлома**.
> **Вердикт: ✅ VERIFIED** — только официальные точки входа vendor. Никакого injection/patching/DRM-bypass.

---

## ⚠️ Главный вывод (сначала — коротко)

**Topomatic НЕ предоставляет готового межпроцессного RPC.** Удалённое управление возможно **только через плагин**, который запускается **внутри** процесса Robur. Это не ограничение — это **канонический и единственно правильный** путь (так же работают все automation-мосты к AutoCAD, Revit, Civil 3D).

**Архитектура «агент чертит сам»:**
```
┌─────────────────────────────┐         ┌──────────────────────────────────┐
│  Внешний агент (LLM/Python) │         │  Robur + наш agent-plugin (DLL)  │
│                             │         │                                  │
│  - планирует действия       │◄───────►│  - внутри процесса Robur         │
│  - отправляет JSON-команды  │  TCP/   │  - полный доступ к ApplicationHost│
│  - читает результаты        │  HTTP/  │  - вызывает cards 01-12          │
│                             │  pipe   │  - marshal на UI-поток           │
└─────────────────────────────┘         └──────────────────────────────────┘
              вне процесса                           внутри процесса
```

Никакого взлома: agent-plugin — это **обычный плагин** (как Robolas), который **дополнительно** открывает localhost-сервер для внешнего оркестратора. Это 100% в рамках EULA и официального plugin-contract.

---

## 🔍 Что проверено (верификация каналов)

| Канал | Есть в ядре? | Пригоден для удалённого агента? | Источник |
|---|---|---|---|
| **`[cmd]` + `Plugins.Execute(cmd, args)`** | ✅ ДА (сотни вызовов в коде) | ✅ **ДА — основной путь** (внутрипроцессно) | `ApplicationPlatform.cs:19383` |
| **IronPython scripting (`loadpy`)** | ✅ ДА | ✅ **ДА — путь vendor'а** для скриптов | `Scripting.cs:4642`, `RegisterLoader(".py", "loadpy")` `:4639` |
| **Командная консоль `ConsoleListner`** | ✅ ДА | ⚠️ Только внутрипроцессно | `Cad.View.cs:24392` |
| **`RemoteApplicationHost : MarshalByRefObject`** | ✅ ДА | ❌ НЕТ — для **AppDomain**-изоляции, не межпроцессно. Remoting-канал **не регистрируется** | `ApplicationPlatform.cs:20015` |
| **`TcpListener` в Lidar.Controller** | ✅ ДА (private stub) | ❌ Недоступен извне, тела обфусцированы | `Lidar.Controller.cs:5715` |
| **COM-сервер (out-of-process)** | ❌ НЕТ | ❌ `ComVisible(true)` стоит на assembly-level во ВСЕХ DLL, но это для внутреннего ACAD-interop. `regasm`/`[ComRegisterFunction]` отсутствуют — как COM-сервер Robur не зарегистрирован | grep по corpus |
| **ACAX COM** | ✅ ДА | ❌ Это Robur **управляет AutoCAD** через COM (клиент), а не наоборот | `Acax.Com.Controller.cs:5909` |
| **Command-line args host EXE (`/script`)** | ❌ НЕТ | ❌ `RbRail.exe` не разбирает флаги запуска скрипта (код argparse — это разбор `args` для `[cmd]`, не глобальные аргументы) | `ApplicationPlatform.cs:4740` |

> **Вывод:** единственный легитимный канал для **внешнего** агента — через **плагин-мост** внутри Robur, который сам открывает сетевой/named-pipe эндпоинт. Это **мы** добавляем сервер, используя только публичный plugin-contract.

---

## Сигнатуры (verified) — три официальных способа управления

### Способ A — IronPython-плагин (vendor-native scripting)
Самый «нативный» путь: vendor сам предоставил IronPython как способ расширения.

| Сигнатура | Файл:строка |
|---|---|
| `public class ScriptingHost : PluginHostInitializator` | `Topomatic.Scripting.cs:4583` |
| `public class ScriptingModule : PluginInitializator` | `Topomatic.Scripting.cs:4590` |
| `factory.RegisterLoader(".py", "loadpy")` — `.py`-файлы = плагины | `Topomatic.Scripting.cs:4639` |
| **`[cmd("loadpy")] IPluginInitializator LoadScriptModule(string path, string assembly)`** | `Topomatic.Scripting.cs:4643` |
| `m_Runtime.LoadAssembly(typeof(ApplicationHost).Assembly)` — **ApplicationHost доступен из Python** | `Topomatic.Scripting.cs:4631` |
| Точка входа: `def initialize():` в `.py` (возвращает `IPluginInitializator`) | `:4652` |
| Вывод: `ConsoleListner.Current.WriteLine(...)` | `Cad.View.cs`, везде |

**Пример `.py`-плагина** (синтаксис по декомпиляту):
```python
# my_agent.py — кладётся как плагин через manifest (как LAS_TERRAIN.plugin)
def initialize():
    # ApplicationHost уже в scope (загружен в ScriptingModule ctor)
    host = ApplicationHost.Current
    project = host.ActiveProject
    # ... вызовы API из cards 01-12
    return MyPluginInitializator()   # IPluginInitializator
```

### Способ B — C# agent-plugin (как Robolas + RPC-сервер)
Канонический плагин, который **дополнительно** открывает localhost-сервер.

| Сигнатура | Файл:строка |
|---|---|
| `public abstract object Execute(string uid, object[] args)` (на `PluginFactory`) | `Topomatic.ApplicationPlatform.cs:19383` |
| `public object Execute(string uid)` (без аргументов) | `:19386` |
| `public abstract void RegisterFunction(string name, PluginFunction function)` | `:19104` |
| `public abstract void RegisterLoader(string extension, string func)` | `:19108` |
| `public static IApplicationHost Current` (service locator: `.Plugins`, `.ActiveProject`, `.MainForm`, `.Settings`) | `Topomatic.ApplicationPlatform.cs:4584` |
| `public bool IsReady` (на `RemoteApplicationHost`) | `:20026` |

**GOLD-паттерн вызова команды** (повсеместно в коде Topomatic, ~700+ call sites):
```csharp
// Вызвать ЛЮБУЮ команду любого плагина:
object result = ApplicationHost.Current.Plugins.Execute("create_cartogram",
    new object[] { parentUri, ext, name });
```

### Способ C — Командная консоль (ConsoleListner)
Программная подача команд в встроенную консоль.

| Сигнатура | Файл:строка |
|---|---|
| `ConsoleListner.Current.ResponseString = command;` (записать команду) | `Topomatic.Cad.View.cs:24392` |
| `ConsoleListner.Current.Commit(silent: true);` (выполнить) | `:24393`, `:23239` |
| `ConsoleListner.Current.RequestString` (ввод) | `:4692` |
| `ConsoleListner.Current.WriteLine(string)` (вывод) | `:4710` |

> Только **внутрипроцессно** — из плагина. Не канал для внешнего агента напрямую.

---

## 🥇 Рекомендованная архитектура «агент чертит сам»

### Слои
```
1. LLM-агент (Python/вне процесса)
   ├─ читает задачу пользователя
   ├─ декомпозирует в последовательность high-level команд
   └─ отправляет JSON через HTTP POST на localhost:7341

2. agent-plugin (C# DLL внутри Robur)  ← МЫ ПИШЕМ
   ├─ HttpListener на localhost:7341 (ТОЛЬКО loopback — безопасность)
   ├─ endpoint /exec  → marshal на UI-поток → Plugins.Execute / cards 01-12
   ├─ endpoint /query → чтение состояния (список трасс, сечений, объёмов)
   ├─ endpoint /screenshot → CadView → PNG (для vision-агента)
   └─ endpoint /stream → поток логов/прогресса обратно агенту

3. Topomatic Robur (host)
   └─ обычный процесс, agent-plugin в нём как LAS_TERRAIN
```

### Почему так, а не иначе
- **Сервер внутри плагина** — единственный способ дать внешнему агенту доступ к `ApplicationHost.Current` (который существует только внутри процесса Robur).
- **Loopback-only** — никаких внешних сетей; агент и Robur на одной машине (или через SSH-туннель). Безопасно по умолчанию.
- **Marshal на UI-поток** — все правки модели Topomatic **НЕ потокобезопасны** (см. card 10). Сервер принимает запрос в фоне, а реальное выполнение — через `CadView.BeginInvoke(...)` на UI-поток.
- **JSON-RPC** — простой, без зависимостей, читаемый в логах.

### Минимальный каркас agent-plugin (C#, .NET, как Robolas)

```csharp
using System.Net;
using System.Threading;
using Topomatic.ApplicationPlatform;

public class AgentBridgeModule : PluginInitializator
{
    private HttpListener _listener;
    private Thread _serverThread;

    public override void Initialize(PluginFactory factory)
    {
        base.Initialize(factory);
        StartLoopbackServer();
    }

    private void StartLoopbackServer()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add("http://localhost:7341/");   // ТОЛЬКО loopback
        _listener.Start();
        _serverThread = new Thread(() => {
            while (_listener.IsListening) {
                var ctx = _listener.GetContext();
                ThreadPool.QueueUserWorkItem(_ => Handle(ctx));
            }
        }) { IsBackground = true };
        _serverThread.Start();
    }

    private void Handle(HttpListenerContext ctx)
    {
        // Десериализовать JSON-команду { "cmd": "build_route", "args": {...} }
        // Marshal на UI-поток (CRITICAL — Topomatic не потокобезопасен!):
        CadView.BeginInvoke((MethodInvoker)delegate {
            try {
                object result = Dispatch(ctx.RequestJson);
                ctx.Respond(200, result);
            } catch (Exception ex) {
                ctx.Respond(500, new { error = ex.Message });
            }
        });
    }

    private object Dispatch(dynamic req)
    {
        switch ((string)req.cmd)
        {
            case "build_route":
                return RouteBuilder.Build(req.args);     // см. recipe build-route-from-scratch.md
            case "create_cartogram":
                return ApplicationHost.Current.Plugins.Execute(
                    "create_cartogram", new object[] { (string)req.args.parentUri });
            case "query_alignments":
                return QueryAlignments();
            case "screenshot":
                return Screenshot();                     // CadView → PNG → base64
            // ... любые команды из cards 01-12
            default:
                throw new ArgumentException($"Unknown cmd: {req.cmd}");
        }
    }
}
```

### Manifest (как LAS_TERRAIN.plugin, но без UI-кнопок)
```json
{
  "assemblies": {
    "AgentBridge": { "assembly": "AgentBridge.dll, AgentBridge.AgentPluginHost" }
  },
  "actions": { "id_start_agent": { "cmd": "start_agent_bridge", "title": "Старт агент-мост" } },
  "ribbon": { "rbproj": { "items": [ { "group": "agent", "title": "Agent" } ] } }
}
```

---

## ✅ Что агент сможет делать (карты возможностей)

После запуска agent-plugin агент через JSON-RPC получает доступ ко **всему**, что задокументировано в базе знаний:

| Категория | Команды | Карточка |
|---|---|---|
| Трасса | создать, задать план (PI/кривые), профиль | 01, 02, 03 |
| Коридор | поперечники, чтение сечений | 04, 07 |
| Поверхности | создать TIN, привязать землю | 06, 08 |
| Объёмы | VolumeCalcer, AreaBetweenSurfaces | 05 |
| Картограмма | создать + пересчёт | 12 |
| Таблицы | построить ведомость, экспорт CSV/Excel | 11 |
| LiDAR | загрузить облако, surface из облака | (`lidar_surface`, `int_lidar_*`) |
| Любая `[cmd]` Topomatic | `Plugins.Execute(cmd, args)` | эта карточка |

То есть **агент может полностью заменить человека** в цикле «получить задачу → построить → проверить → выгрузить результат».

---

## 🥇 Альтернатива: IronPython как agent-runtime (без C#-компиляции)

Если не хочется компилировать C# DLL — IronPython даёт **скриптовый** путь:

1. Agent-plugin (минимальный C# stub) просто запускает IronPython-engine и читает `.py`-файлы из папки.
2. LLM-агент **генерирует** `.py`-скрипт (с вызовами `ApplicationHost.Current.*`), кладёт его в папку.
3. Agent-plugin перезагружает скрипт и выполняет.

Плюсы: без перекомпиляции на каждое изменение; цикл агент→код→результат быстрее.
Минусы: медленнее C#; отладка сложнее; типизация слабая.

> IronPython уже загружает `ApplicationHost` в scope (`Scripting.cs:4631`) — всё API доступно.

---

## ❌ Чего НЕ делать (и почему)

| Подход | Почему нет |
|---|---|
| Патчить память Robur / inject DLL | **Взлом** — нарушает EULA, ломает лицензию, недетерминированно |
| Обход DRM (Hasp/sentinel) | **Взлом** — `HaspAssistant.exe` в папке установки = аппаратный ключ. Не трогать |
| Регистрировать Robur как COM-сервер через `regasm` | Не сработает — нет `[ComRegisterFunction]`, нет CCW; плюс нарушит целостность установки |
| Декомпилировать → перекомпилировать host EXE | **Взлом** + потеря поддержки |
| Пробовать `RemoteApplicationHost` через .NET Remoting | Бесполезно — канал не регистрируется, MarshalByRefObject для AppDomain-изоляции (лицензия) |
| Читать/писать файлы проекта `.glgx` напрямую, минуя Robur | Формат бинарный/`StgNode`, риск corruption; лучше через API |

---

## 🔗 Связанные карточки
- [01 — Создание Alignment](01-alignment-creation.md)
- [09 — Регистрация плагина](09-plugin-registration.md)
- [10 — Транзакции (marshal на UI!)](10-transactions-undo.md)
- [recipes/build-route-from-scratch.md](../recipes/build-route-from-scratch.md) — что агент сможет вызывать
- `docs/knowledge-base/meta/CATALOG_HALLUCINATIONS.md` — что НЕ существует
