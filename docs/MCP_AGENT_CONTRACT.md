# RoboLas MCP Free — контракт агента

Источник истины — код в `master`. Продукт полностью бесплатный: в текущем коде нет активации коммерческой лицензии, демо-лимитов или платных режимов. Проверено 2026-10-01.

## Подключение MCP-клиента

Расширяем официальный `topomatic-code/robur-mcp` v0.1.0, commit `24abd664a6201014c7730f2d7e3b8829ba5184de`. Регистрация выполняется через штатный `tool_request`: семь провайдеров добавляют 27 инструментов `las_*` в существующий сервер. Возможности проекта и CAD, уже предоставленные Robur, остаются у native tools. Выбор трассы — дополнение RoboLas: в исследованной версии native MCP такой команды нет.

Поток: MCP-клиент → Streamable HTTP `http://127.0.0.1:8000/mcp/` → штатный named pipe Robur → `Topomatic.ToolBridge` → `LAS_TERRAIN.MCP` (.NET 4.8) → `LAS_TERRAIN.Automation` (.NET 3.5).

Транспорт описан в документации robur-mcp; в настройке MCP-клиента укажите существующий Robur endpoint (см. пример конфигурации в [INSTRUKCIYA_ROBOLAS.md](INSTRUKCIYA_ROBOLAS.md)).

## Инструменты

| Группа | Инструменты |
|---|---|
| Контекст и сценарии | `las_get_context`, `las_get_workflow_guide` |
| Трассы | `las_list_alignments`, `las_set_active_alignment` |
| Настройки | `las_get_settings`, `las_set_settings` |
| Сечения и ЦММ | `las_list_sections`, `las_generate_sections`, `las_activate_surface_view`, `las_build_terrain` |
| Визуальная чистка сечений | `las_render_section`, `las_preview_section_polygon`, `las_delete_section_points` |
| Экспорт | `las_reduce_cloud`, `las_split_by_offset` |
| Полигоны | `las_list_polygons`, `las_add_polygon`, `las_clear_polygons`, `las_delete_points_by_polygons`, `las_build_surface_by_polygons` |
| Harness | `las_get_capabilities`, `las_preflight`, `las_get_operation`, `las_list_operations` |

MCP покрывает перечисленные операции. Интерактивный выбор мышью заменяется выбором трассы и координатами полигонов; legacy-import и перенос полигонов Save As пока имеют отдельные UI-команды.

`las_get_context.result.LidarSources` описывает провайдеры активного облака: `ProviderPath`, `CachePath`, диагностическую LAS-сигнатуру, число точек и логическую заполненность native `texture`/legacy `clrs`. Пути остаются диагностикой: экспорт RGB читает атрибуты самого загруженного буфера по индексу записи, без подбора файла или ручного RGB-источника.

## Настройки

`PluginSettings` — единый каталог 33 параметров: 29 writable свойств RuntimeConfig и четыре параметра 3D ground-фильтра. Параметры включают spline/minweight, толщину CRS, допуск упрощения, сбор, сетку, полином, детектор разрывов, параметры сплайна, rail-фильтр и 3D bins/minimum occupancy. Вычисляемый `max_filter_border` доступен только для чтения.

`las_get_settings` возвращает `values`, `schema`, `read_only`. Поля patch проверяются все до изменения настроек; неизвестные поля, строки вместо чисел/boolean, дробные integer, NaN/Infinity и недопустимые диапазоны отклоняются. Пустой patch отклоняется. Настройки сохраняются в хранилище Robur; прежние пять ключей поддержаны для загрузки старых проектов. Running operation использует свой снимок настроек.

Schema в native `tools/list` — compile-time константа, генерируется из того же каталога: `python tools/generate_mcp_settings_schema.py`; проверка drift — `--check`.

## Запросы и ответы

Перед записью вызывайте `las_preflight` с `tool` и `arguments`. Проверка возвращает `expected_context`: fingerprint сводного контекста и настроек. Это не проверка RGB, дисковой доступности или возможности исполнить SDK. Fingerprint не является полной ревизией геометрических данных; адаптеры дополнительно проверяют захваченные источники и цель перед применением результата.

Запись принимает optional `request_id` и `expected_context`. Пример:

```json
{"method":"tools/call","params":{"name":"las_build_terrain","arguments":{"thickness":0.25,"request_id":"terrain-001"}}}
```

После `las_generate_sections` вызывайте `las_build_terrain` без `step`, чтобы использовать созданные сечения. `step` в build намеренно пересоздаёт их.

Собственные ответы имеют `schema_version=1.0`, `status`, `result`, `description`, `next_steps`. Для записи добавлены `operation_id`, `request_id`, terminal operation с длительностью и событиями этапов. Статусы `cancelled` и `no_output` не означают успешную публикацию.

Собственная ошибка возвращает `error.code`, `message`, `retryable`, `mutation_state`, полный `input_schema`, `correct_request` в форме `tools/call`, `requires_binding` и следующий диагностический шаг. Пример запроса требует привязки к фактическим путям, трассе и координатам. Отмена или ошибка не означают гарантированный откат любого SDK-действия; при неопределённом состоянии проверяйте контекст.

`request_id` предотвращает повторное выполнение идентичной сохранённой записи; другие аргументы под прежним ID отклоняются. Журнал ограничен 64 записями и живёт только в текущем процессе. После timeout не повторяйте запись вслепую: после завершения Robur найдите результат через `las_get_operation`. После перезапуска/вытеснения записи гарантия replay отсутствует.

## Этапы расчётов и ограничения

Terrain: capture → collect/filter → validate target → commit surface. Reduction: capture → collect → ground filter при необходимости → reduce → write staging → validate → publish. Split: capture → edge/center collection → reduction → preparation/validation/publication pair. Polygon surface: capture → count/collect → min-Z/features или polynomial fit → validate target → commit.

Telemetry не может превратить опубликованный результат в ошибку. События этапов доступны после завершения вызова. Native bridge выполняет команды последовательно на CAD UI-потоке: live polling и agent cancellation не поддерживаются. Пользовательская отмена через Robur остаётся доступной. Для настоящих start/poll/cancel требуется отдельный рефакторинг: immutable capture → worker без SDK объектов → проверка и применение на UI-потоке.

Ошибки startup/dispatch/transport до вызова нашего provider остаются ошибками native MCP. Native мост возвращает наш JSON `status=error` как text content и не выставляет `isError` автоматически; harness должен читать JSON-статус.

## Сборка, пакет и проверка

Формат native-хранилища облака: LidarSources сообщает CacheFormatStatus/Version/ReadError и SdkIndexerCount отдельно от цветов в памяти. LDAR v1 в исследованном SDK не сериализует RGB; LDAR v2 присланного класса сохраняет texture RGB8. Header diagnostic не валидирует всё содержимое дерева. Native storage читается через texture/legacy clrs.

Solution собирает core net35 и adapter net48. `build/package.ps1 -McpBuildPath <папка MCP>` добавляет в единый `.tpm` DLL и manifest расширения, проверяет identity, свежесть и соответствие содержимого; third-party DLL официального моста не переупаковываются.

Установленный SDK теперь 16.0.64.2. Адаптер собран без предупреждений с официальным ToolBridge и JSON 13 из официального TPM. В папке Robur до установки этого пакета находится JSON 6. Core + MCP release-package проверен. Официальный пакет скачан с сайта Topomatic, установка и native runtime E2E в открытом проекте ещё не выполнены.

Проверки: `tests/Net35/run.cmd`, `tests/Mcp/run.ps1` (89 контрактов), geometry reference (10), architecture boundary (0 нарушений), schema drift и release/package verification.

UC-38 — исправление цвета уже загруженного облака Robur. Native texture/legacy clrs читается по точному индексу до фильтрации; исходные LAS не нужны. UI/MCP reduce, ground reduce, split и polygon deletion используют цветной pipeline. Выход — LAS 1.2 Format 3, RGB16 = native RGB8 << 8 по ASPRS. Capability описывает реализованную native поддержку; интерактивный host E2E пока не выполнен.

Файловый слой уже реализован: `LasColoredPoint` переносит RGB вместе с исходной записью и ordinal; `LasRgbSourceReader` потоково читает RGB-форматы LAS 1.2–1.4. Explicit colored-mode `LasBatchStreamWriter` пишет format 3 с точными ushort RGB, а `PreparedLasFile` проверяет его staging и атомарно публикует. Writer отклоняет попытку подставить обычный Vector4D вместо цветных записей или потерять RGB в plain-mode. LAZ без проверенного decompressor явно не поддерживается. Layout сверён с [ASPRS LAS specification](https://www.asprs.org/wp-content/uploads/2019/03/LAS_1_4_r14.pdf).

NativeRgbExportProbe проверяет native texture и legacy clrs, сам присланный LidarBuffer.cs с LDAR v2 save/reload, LAS Format3 header/records, query parity, ground/sampling/spill/dedup/delete и изменение RGB перед публикацией. Файловые reader/writer проверки остаются отдельными. Цвет не восстанавливается сопоставлением XYZ.

EASY LAS использовались раньше как тестовые данные файлового reader/writer. Исправление получает цвет непосредственно из загруженного облака Robur и проверяется без входных LAS.

Сечение для подбора толщины: [контракт las_get_section_points](MCP_SECTION_POINTS.md).
Срезы `las_get_section_points` — только MCP, исходные точки облака Robur и полная статистика по трём локальным осям.
Визуальная чистка по сечениям (PNG + полигон + удаление): [контракт](MCP_SECTION_VISUAL.md). Отдельная stateless-цепочка: рендер среза → полигон в координатах (offset, Z) → dry-run счёт в призме → батч-удаление в новый LAS. Толщина одна: сечение и призма удаления — один и тот же слой thickness; отдельного параметра глубины нет. Хранилище полигонов и разбивка сечений трассы не требуются.


Обновление установки, 01.10.2026: официальный bridge, HTTP server и JSON 13, а также RoboLas core + MCP развернуты в Robur Rail 16.0. Robur остаётся закрыт; native runtime E2E требует открытия проекта.

Live MCP проверен 01.10.2026: ready=true, 57 native + 23 RoboLas tools, контекст трассы Rail и облака доступен. Новый инструмент сечения проверен на реальных точках; плотность, страницы и runtime recovery работают. Подключение: `http://127.0.0.1:8000/mcp/` — завершающий слеш нужен для POST без HTTP 307.
