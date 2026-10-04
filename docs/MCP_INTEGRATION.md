# MCP-интеграция RoboLas (robur-mcp)

Историческое описание первоначальной интеграции, до расширения настроек и harness-контракта. Актуальный контракт и ограничения — [MCP_AGENT_CONTRACT.md](MCP_AGENT_CONTRACT.md); источник истины — код `master`.

## Что это

Основные расчётные функции плагина RoboLas доступны ИИ-агенту как MCP-тулзы через
**официальный плагин Robur MCP** («Топоматик», MIT). Каждый ответ тула содержит
`next_steps` — подсказку «какой тул вызывать дальше и с какими аргументами», а
тул `las_get_workflow_guide` отдаёт полные сценарии-цепочки. Ядро плагина
(LAS_TERRAIN, .NET 3.5) не изменилось — добавлены только новые файлы.

## Архитектура

```
MCP-клиент (Claude / Hermes / любой HTTP MCP)
    │ Streamable HTTP (stateless)
    ▼
http://127.0.0.1:8000/mcp/          ← robur_mcp_server.exe (ставится пакетом robur-mcp)
    │ named pipe \\.\pipe\robur_tool_bridge, JSON
    ▼
Topomatic.ToolBridge.dll           ← плагин robur-mcp внутри процесса Robur (net48)
    │ broadcast "tool_request" → всем плагинам при mcp_run
    ▼
LAS_TERRAIN.MCP.dll (НОВОЕ)        ← наш адаптер (net48): [ToolDef]-тулзы las_*
    │ прямой вызов, тот же процесс
    ▼
LAS_TERRAIN.Automation (НОВОЕ)     ← headless-фасад внутри LAS_TERRAIN.dll (net35):
    │   контекст/трассы/настройки/ЦММ/экспорт/полигоны
    ▼
существующие сервисы плагина (GroundPointsCollector, фильтры, LasBatchStreamWriter,
ScopedPolygonRepository, FastSurfaceBuilder …) — БЕЗ изменений
```

Регистрация — штатный механизм расширения robur-mcp: в манифесте
`Mcp/LAS_TERRAIN.MCP.plugin` объявлен `"broadcasts": {"tool_request": "las_generate_tools"}`;
обработчик `[cmd("las_generate_tools")]` в `Mcp/LasMcpModule.cs` добавляет 6
провайдеров в общий список. Тулзы исполняются на CAD UI-потоке (маршрутизация
ToolManager), долгие операции показывают стандартный прогресс-бар Robur.

## Требования

1. Установленный SDK Robur проверен: `Topomatic.ApplicationPlatform 16.0.64.2`.
   Скачанный официальный bridge ссылается на SDK `16.0.62.12` и Newtonsoft.Json 13.
   Это зависимости конкретного бинарного пакета, а не минимальная версия, объявленная в README.
   В папке Robur пока Newtonsoft.Json 6; официальный пакет содержит собственную DLL версии 13.
   Наш MCP-адаптер собран с зависимостью JSON 13 из официального пакета, основной плагин — с SDK 64.2.
   Установка официального пакета и проверка вызова в живом проекте остаются необходимыми.
2. **Плагин robur-mcp 0.1** — пакет `robur_mcp-0_1.tpm`:
   https://topomatic.ru/plugins-robur/free-plugins-robur/ (ставится Диспетчером
   пакетов Topomatic, `TopomaticPackageManager.exe`). Исходники:
   https://github.com/topomatic-code/robur-mcp
3. RoboLas (LAS_TERRAIN.dll) и LAS_TERRAIN.MCP.dll — см. «Деплой».

## Сборка

```bat
:: 1) основной плагин (net35) — как обычно
msbuild LAS_TERRAIN.csproj -p:Configuration=Release -p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 16.0"

:: 2) адаптер (net48)
cd Mcp
msbuild LasTerrain.Mcp.csproj -p:Configuration=Release -p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 16.0"
```

**Важно**: ProjectReference с сильным именем фиксирует версию LAS_TERRAIN (сейчас
1.0.3.0) — при изменении версии основного плагина адаптер нужно пересобрать,
иначе в рантайме будет BindingException. Адаптер в решение LAS_TERRAIN.sln не
включён (отдельная msbuild-команда выше) — не забывайте шаг 2 при релизе.

Compile-time ссылка на `Topomatic.ToolBridge.dll` лежит в `Mcp/refs/` — это
**оригинальная DLL из официального tpm** (identity `Version=0.1.0.0,
PublicKeyToken=0af0f61cef2ab3a8`, `Private=False`, в дистрибутив не попадает;
обновление — см. `Mcp/refs/README.md`). В рантайме используется DLL из
установки robur-mcp у пользователя.

## Деплой

### Установщик (основной путь)

Собрать пакет (перед этим собрать оба проекта):

```bat
powershell -ExecutionPolicy Bypass -File installer\make_package.ps1
```

Результат: `..\dist\RoboLas-MCP-<версия>.zip`. Внутри: `install.cmd`,
`uninstall.cmd`, `Install-RoboLas.ps1`, `README-INSTALL.txt`, `files\*`
(DLL обоих плагинов, манифесты, иконки — только те, на которые ссылается
LAS_TERRAIN.plugin, со всеми размерными вариантами).

Установщик сам: находит все установки Robur (Program Files + реестр), проверяет
версию Robur (≥16.0.62.12 для MCP) и наличие robur-mcp, делает бэкап старых
файлов RoboLas в `C:\ProgramData\RoboLas\backups\`, копирует файлы, пишет
манифест установки для корректного удаления. UAC поднимает сам при нужде.
Тихий режим: `-Yes [-All | -Path "<каталог Robur>"]`; диагностика: `-ListOnly`.
Лог: `C:\ProgramData\RoboLas\install.log`. Пользователь ставит Robur и
robur-mcp (tpm) сам — установщик только предупреждает, если их нет/старые.

Robur на время установки/обновления должен быть ЗАКРЫТ (DLL заняты процессом);
при нескольких копиях Robur (Rail+Road) MCP-тулзы — только в той, где стоит
robur-mcp: тихий `-Yes` без `-Path`/`-All` останавливается, интерактивный режим
предлагает выбор. Обновление подхватывается ТОЛЬКО после перезапуска Robur —
запущенный экземпляр продолжает работать со старой DLL из памяти. Подробная
инструкция для пользователя — README-INSTALL.txt внутри пакета.

После установки MCP-сервер запускается автоматически при открытии проекта
(broadcast `projectopened` → `las_mcp_autostart`); ручной запуск — кнопка
«Запуск MCP» на вкладке RoboLas или команда `mcp_run`. Клиент:
`{"mcpServers":{"robur":{"type":"http","url":"http://127.0.0.1:8000/mcp/"}}}`.

### Вручную (для отладки; в корень установки Robur)

| Файл | Откуда |
|---|---|
| `LAS_TERRAIN.dll` | `bin\Release\` (сборка с Automation-фасадом) |
| `LAS_TERRAIN.plugin` | корень проекта (не менялся) |
| `LAS_TERRAIN.MCP.dll` | `Mcp\bin\Release\` |
| `LAS_TERRAIN.MCP.plugin` | `Mcp\` |
| иконки `icons\*.png` | как обычно для RoboLas |

## Каталог инструментов (27, включая harness)

| Тул | Что делает | Аннотации |
|---|---|---|
| `las_get_context` | Снимок: проект/трасса/сечения/ЦММ/LAS-облака/режимы. Стартовая точка. | ro, idem |
| `las_get_workflow_guide` | Сценарии-цепочки (5 шт.) с аргументами. | ro, idem |
| `las_list_alignments` | Список трасс + активная. | ro, idem |
| `las_set_active_alignment` | Активировать трассу по имени. | idem |
| `las_get_settings` / `las_set_settings` | Настройки фильтрации/полинома/сетки. | idem |
| `las_get_section_points` | Исходные точки сечения по пикету/толщине; полная плотность и пустоты по трём осям. [Контракт](MCP_SECTION_POINTS.md). | ro, idem |
| `las_render_section` | Сечение в PNG (сетка/оси/калибровка пиксель↔метр) + точки `[offset, Z]` + файл полного среза. | ro, idem |
| `las_preview_section_polygon` | Полигон поверх кадра + ТОЧНЫЙ dry-run счёт точек в призме (poly × толщина сечения). | ro, idem |
| `las_delete_section_points` | Удаление точек в призмах по секциям (полигон × толщина сечения) → новый LAS. | destr |
| `las_list_sections` | id/пикеты сечений (для CRS-полигонов). | ro, idem |
| `las_generate_sections` | Авторазбивка сечений (шаг). ЗАМЕНЯЕТ сечения. | destr, idem |
| `las_activate_surface_view` | Активировать окно поперечников (слой ЦММ) — подготовка вида к построению ЦММ. | idem |
| `las_build_terrain` | ГЛАВНЫЙ СЦЕНАРИЙ: сбор→фильтр земли→вставка в ЦММ. | destr |
| `las_reduce_cloud` | Прореживание облака (%, ground-фильтр) → новый LAS. | idem |
| `las_split_by_offset` | Разделение на полосу/обочины → 2 LAS. | idem |
| `las_list_polygons` | Полигоны scope plan/crs. | ro, idem |
| `las_add_polygon` | Добавить полигон вершинами (замена рисования мышью). | — |
| `las_clear_polygons` | Очистить полигоны scope. | destr, idem |
| `las_delete_points_by_polygons` | Экспорт LAS без точек полигонов (+очистка). | destr |
| `las_build_surface_by_polygons` | ЦММ по полигонам: grid min-Z / polynomial. | destr |

Дополнительно: `las_save_polygons`, `las_load_polygons` — сохранение/загрузка переносимых JSON без диалогов; `las_get_capabilities`, `las_preflight`, `las_get_operation`, `las_list_operations` — контракт harness.

## Формат ответа и next_steps

Каждый тул возвращает:

```json
{
  "result": { …данные операции… },
  "description": "человекочитаемая сводка",
  "status": "ok",
  "next_steps": [
    { "tool": "las_build_terrain", "when": "основной сценарий…",
      "args": { "thickness": 0.25, "step": 1.0 } }
  ]
}
```

Подсказки контекстные: `las_get_context` при отсутствии трассы предложит
`las_list_alignments` → `las_set_active_alignment`; при отсутствии сечений —
`las_generate_sections`; при готовности — `las_build_terrain`. Ошибки
(`LasAutomationException`) формулируются как инструкция («Трасса не найдена: X.
Вызовите las_list_alignments…») и попадают агенту как MCP error.

## Демо

`demo/ROBOLAS-MCP-DEMO.md` — готовые промпты для демонстрации заказчику
(включаются в установочный zip как `DEMO.md`): полное демо на 10–15 минут
(разведка → зонд облака → preflight → построение ЦММ → журнал операций →
экспорт, с таблицей «до/после»), экспресс на 3 минуты (только чтение) и
«навигатор сценариев» (агент пересказывает цепочки из workflow_guide).
Пишущие шаги демо прогоняются через контракт безопасности:
`las_preflight` → вызов с `request_id` + `expected_context`.

## Ограничения и поведение

- **Операции сериализованы** (`PluginOperationGate`): параллельный вызов вернёт
  ошибку «уже выполняется» — агент должен повторить позже.
- Долгие операции идут на UI-потоке Robur (как у встроенных тулов robur-mcp):
  интерфейс занят прогресс-баром; пользователь может отменить — вернётся
  `cancelled=true` без ошибки (единая семантика для build/reduce/split/delete/
  surface).
- Экспортные тулы пишут НОВЫЙ LAS-файл; облако в проекте не меняется.
  Импорт результата в Robur — вручную.
- Интерактивное рисование полигонов (`crs_draw_line`, `plan_draw_polygon`)
  заменено тулом `las_add_polygon` (вершины передаются массивом).
- Без установленного robur-mcp адаптер бездействует (broadcast некому слушать).
- Безопасность — на стороне robur-mcp 0.1: localhost-only, без токена
  (см. документацию robur-mcp; в версии 0.2 появились ACL/подтверждения).

## Что не менялось

- `LAS_TERRAIN.plugin`, меню/риббон, все существующие use case'ы и сервисы —
  нетронуты; `LAS_TERRAIN.csproj` — только добавлены Compile-включения Automation.
- Тесты Net35 не затронуты (компилируют свои подмножества файлов).


Обновление установки, 01.10.2026: официальный bridge, HTTP server и JSON 13, а также RoboLas core + MCP развернуты в Robur Rail 16.0. Robur остаётся закрыт; native runtime E2E требует открытия проекта.

Live MCP проверен 01.10.2026: ready=true, 57 native + 23 RoboLas tools, контекст трассы Rail и облака доступен. Новый инструмент сечения проверен на реальных точках; плотность, страницы и runtime recovery работают. Подключение: `http://127.0.0.1:8000/mcp/` — завершающий слеш нужен для POST без HTTP 307.
