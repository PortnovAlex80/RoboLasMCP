# RoboLas (free) + MCP

**RoboLas** — плагин для **Topomatic Robur Rail 16.0**: обработка LiDAR-облаков
(LAS), построение цифровой модели местности (ЦММ) по поперечным сечениям трассы
и визуальная чистка облака полигонами. Свободная редакция — без активации,
демо-лимитов и платных режимов.

Плагин включает **MCP-адаптер**: 27 инструментов `las_*` доступны ИИ-агентам
(Claude, Cursor и любой HTTP MCP-клиент) через официальный сервер
[`robur-mcp`](https://github.com/topomatic-code/robur-mcp) — можно строить ЦММ,
чистить облако и экспортировать LAS скриптами и агентами, без ручных кликов.

## Два главных сценария

1. **ЦММ по сечениям.** Загруженное в Robur облако LAS нарезается по поперечным
   сечениям выбранной трассы; характерные точки земли (после фильтрации и
   упрощения) вставляются в поверхность ЦММ проекта. Шаг сечений — стандартный,
   1 м или произвольный.
2. **Визуальная чистка полигонами.** В поперечнике (CRS) или на плане
   рисуются полигоны вокруг мусорных точек (трава, конструкции, сигнатура
   проезжей части) — точки внутри полигонов удаляются из облака. По сечениям
   доступен полностью автоматический MCP-конвейер: PNG-рендер среза → полигон
   в координатах кадра → подсчёт и удаление точек в призме.

## Команды плагина

| Команда | Название | Описание |
|---|---|---|
| `create_las_settings_panel` | Открыть настройки | Настройки обработки облака, фильтров и построения поверхностей |
| `calculation_async_section` | Построить ЦММ | ЦММ по точкам облака на существующих поперечниках трассы |
| `calculation_async_one_meter_section` | Построить ЦММ (шаг 1 м) | ЦММ вдоль трассы с шагом 1 м |
| `calculation_async_custom_step_section` | Построить ЦММ (с заданным шагом) | ЦММ с произвольным шагом сечений |
| `reduce_las_async_to_percent` | Проредить облако | Равномерное прореживание облака до процента точек |
| `reduce_with_ground_red_sector` | Проредить облако с фильтром земли | Прореживание с сохранением рельефа (фильтр земли по секторам) |
| `split_las_by_offset` | Разделить облако на коридор и обочины | Разделение облака по смещениям от оси трассы |
| `set_split_merge_tolerance` | Настроить допуск рельефа | Допуск объединения точек при упрощении рельефа |
| `crs_draw_line` | Рисовать контур на поперечнике | Интерактивное рисование полигона в CRS |
| `crs_delete_points` | Удалить точки по полигонам | Удаление точек по полигонам в CRS |
| `crs_clear_polygons` | Очистить коллекцию полигонов | Удалить все полигоны CRS |
| `plan_draw_polygon` | Рисовать полигон на плане | Интерактивное рисование полигона на плане |
| `plan_delete_points` | Удалить точки по полигонам плана | Удаление точек по полигонам плана |
| `plan_clear_polygons` | Удалить полигоны плана | Удалить все полигоны плана |
| `polygon_save_as` / `polygon_load` | Сохранить/загрузить полигоны | Переносные JSON-файлы полигонов |
| `plan_polygon_grid_surface` | Построить ЦММ по полигонам (сетка) | Поверхность по точкам в полигонах, сетка |
| `plan_polygon_polynomial_surface` | Построить ЦММ по полигонам (полином) | Поверхность полиномиальным выравниванием |
| `las_start_mcp` | Подключить MCP | Запуск/перезапуск MCP-сервера Robur |

Инструкция пользователя: [docs/INSTRUKCIYA_ROBOLAS.md](docs/INSTRUKCIYA_ROBOLAS.md).

## MCP для ИИ-агентов

Требуется установленный официальный плагин **robur-mcp** (пакет Топоматика,
[robur-mcp на GitHub](https://github.com/topomatic-code/robur-mcp)) — RoboLas
расширяет его своими инструментами, отдельный сервер не нужен.

Подключение MCP-клиента (сервер стартует при открытии проекта; иначе — команда
«Подключить MCP» на вкладке RoboLas):

```json
{ "mcpServers": { "robur": { "type": "http", "url": "http://127.0.0.1:8000/mcp/" } } }
```

### 27 инструментов `las_*`

| Группа | Инструменты |
|---|---|
| Контекст и сценарии | `las_get_context`, `las_get_workflow_guide` |
| Трассы | `las_list_alignments`, `las_set_active_alignment` |
| Настройки | `las_get_settings`, `las_set_settings` |
| Сечения и ЦММ | `las_list_sections`, `las_generate_sections`, `las_activate_surface_view`, `las_build_terrain` |
| Точки сечений | `las_get_section_points` |
| Визуальная чистка сечений | `las_render_section`, `las_preview_section_polygon`, `las_delete_section_points` |
| Экспорт | `las_reduce_cloud`, `las_split_by_offset` |
| Полигоны | `las_list_polygons`, `las_add_polygon`, `las_clear_polygons`, `las_delete_points_by_polygons`, `las_build_surface_by_polygons`, `las_save_polygons`, `las_load_polygons` |
| Контракт агента | `las_get_capabilities`, `las_preflight`, `las_get_operation`, `las_list_operations` |

Полный контракт (запросы/ответы, ошибки, ограничения): 
[docs/MCP_AGENT_CONTRACT.md](docs/MCP_AGENT_CONTRACT.md). Готовый демо-промпт:
[demo/ROBOLAS-MCP-DEMO.md](demo/ROBOLAS-MCP-DEMO.md).

## Сборка

Требуется Visual Studio 2022 (MSBuild) и установленный
Topomatic Robur Rail 16.0. Два проекта:

```bat
:: Ядро (NET35)
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" ^
  LAS_TERRAIN.csproj -t:Rebuild -p:Configuration=Release ^
  -p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 16.0"

:: MCP-адаптер (NET48)
"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" ^
  Mcp\LasTerrain.Mcp.csproj -t:Rebuild -p:Configuration=Release ^
  -p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 16.0"
```

Подробности: [BUILD.md](BUILD.md), [build/BUILD_INSTRUCTIONS.md](build/BUILD_INSTRUCTIONS.md).
Упаковка `.tpm`: `build/package.ps1`. Тесты: `tests/Net35/`, `tests/Mcp/`.

## Установка

- Установщиком: собрать `RoboLasInstaller` (или взять пакет) и следовать
  [installer/README-УСТАНОВКА.txt](installer/README-УСТАНОВКА.txt);
  скрипт `installer/Install-RoboLas.ps1` ставит всё автоматически.
- Вручную: скопировать `LAS_TERRAIN.dll`, `LAS_TERRAIN.plugin`,
  `LAS_TERRAIN.MCP.dll`, `LAS_TERRAIN.MCP.plugin` в корень установки Robur,
  иконки из `RobolasIcons` — в `<Robur>\icons\`, затем очистить кэш сборок Robur
  (`%LOCALAPPDATA%\Topomatic\<Robur>\<версия>\assemblies`) и перезапустить Robur.
  Проще собрать пакет `build\package.ps1` и поставить `.tpm` через
  Диспетчер пакетов Topomatic.

## Структура репозитория

```
├── LAS_TERRAIN.csproj / .plugin / Module.cs   # ядро плагина (NET35)
├── Mcp/                                        # MCP-адаптер LAS_TERRAIN.MCP (NET48)
├── UseCases/, CommandRegistry/, Domain/        # команды и логика
├── Services/, Infrastructure/, Automation/     # сервисы и автоматизация
├── RobolasIcons/                               # иконки команд
├── installer/, RoboLasInstaller/               # установка
├── build/                                      # сборка, пакет tpm, верификация
├── tests/                                      # тесты (Net35, Mcp, ...)
├── docs/                                       # документация и контракты MCP
└── demo/                                       # демо-промпт для MCP-агента
```

> **Примечание.** Система предоставляется **«как есть»** (as is). Разработчик
> не гарантирует отсутствие ошибок и пригодность для любых задач и
> **не принимает претензий** по последствиям использования. Проверяйте
> результаты расчётов перед применением в проектах.

## Лицензия

Свободное использование. При применении в коммерческих проектах — обязательное
указание авторства: **«Применяется RoboLas — AlexPo»** (документация, описание
продукта или экран «О программе»). Полный текст — [LICENSE](LICENSE).
