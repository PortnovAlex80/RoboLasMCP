# MCP: визуальная чистка сечений (PNG + точки + полигон + удаление)

Отдельная цепочка тулов «осмотрел → построил полигон → проверил глазами → вырезал»
для чистки облака лазерного сканирования по поперечникам. Даёт агенту с «глазами»
(vision-модель) тот же рабочий цикл, что у оператора Robur: сечение в высоком
разрешении, полигон поверх сечения, точный счёт точек под полигоном и удаление
точек в призме сечения.

Цепочка не зависит от хранилища полигонов (`las_add_polygon` /
`las_delete_points_by_polygons`) и от разбивки сечений трассы (`las_generate_sections`):
полигоны передаются аргументами stateless, существующие сечения не требуются.

## Цикл агента

1. `las_render_section` — PNG сечения (сетка, оси, калибровка пиксель↔метр) +
   компактные точки `[offset, Z]` в ответе + файл полного среза `*.points.json`.
2. `las_preview_section_polygon` — агент строит полигон в координатах сечения;
   тул рисует его поверх кадра (заливка + контур + вершины), возвращает эхо полигона
   и ТОЧНЫЙ dry-run счёт точек, которые попадут в призму удаления.
   Vision-агент сверяет картинку: попал ли полигон в нужный сектор сечения.
3. `las_delete_section_points` — удалить точки LAS в призмах (полигон × толщина
   сечения) по одному или нескольким пикетам одним проходом; результат — НОВЫЙ
   LAS-файл. Цикл повторяется на следующем пикете.

## Координаты сечения и ЕДИНСТВЕННЫЙ параметр толщины

Локальные координаты сечения — те же, что у `las_get_section_points` и CRS-полигонов:

- `offset` — поперечное смещение от оси трассы в метрах, влево отрицательное
  (область: `[-DtmSizeLeft, +DtmSizeRight]`);
- `Z` — высота проекта в метрах.

Геометрия среза строится через `StaOffsetToPos(station, ±DtmSize)` активной трассы,
как во всех сечениях RoboLas.

**Параметр толщины один — `thickness`** (полная толщина сечения, м). Отдельной
«глубины удаления» не существует: сечение физически и есть слой толщиной
`thickness`, который проекцируется на плоскость поперечника. Призма удаления —
тот же слой: полигон, вырезанный из сечения, уносит с собой все точки слоя в
пределах `|SliceDistance| < thickness/2`. Что видно в срезе под полигоном —
то и удаляется; счёт preview и удаление используют один и тот же предикат.

Агент управляет этой величиной сам: смотрит кадр — и запрашивает сечение толще
(больше точек в срезе и в призме) или уже (только точки, близкие к плоскости).
Картинка и счёт меняются вместе, «видел ≠ удалил» невозможно по построению.

**Предикат удаления** (единый для preview-счёта и delete, открытие границ):

```
|SliceDistance| < thickness/2  И  (offset, Z) внутри полигона (even-odd)
```

## Тула

### las_render_section (read-only, idempotent)

Сечение в PNG + точки. Только чтение; проект не меняется.

Аргументы (обязательные: `station`, `thickness`):

| Аргумент | Тип | Default | Описание |
|---|---|---|---|
| `station` | number ≥ 0 | — | пикет, м от начала активной трассы |
| `thickness` | number > 0 | — | полная толщина сечения, м |
| `width_px` | int 320..4096 | 2400 | ширина PNG |
| `height_px` | int 240..4096 | 1400 | высота PNG |
| `color_by` | enum `intensity`\|`z`\|`slice_distance` | `intensity` | окраска точек |
| `point_px` | int 1..8 | 2 | размер точки, px |
| `scale_mode` | enum `fit`\|`equal` | `fit` | `fit` — растянуть в канву, `equal` — равный масштаб осей |
| `z_min`, `z_max` | number | наблюдаемые | обрезка кадра по высоте |
| `grid_step` | number > 0 | авто | шаг сетки, м (авто: 1/2/5×10^k на 8–25 линий) |
| `max_points` | int 0..20000 | 2000 | точек `[offset, Z]` в ответе (0 — не включать) |
| `max_stored_points` | int 1000..1000000 | 300000 | сколько точек среза собирать (кадр+файл) |
| `include_points_file` | bool | true | писать `*.points.json` полного среза |
| `output_dir` | string | `%TEMP%\RoboLasSections` | абсолютный путь папки PNG |
| `request_id`, `expected_context` | string | — | общий контракт |

Ответ `result`: `alignment`, `station`, `thickness`, `left_offset`, `right_offset`,
`total_points`, `stored_points`, `truncated`, `bounds{offset_from, offset_to, z_from, z_to}`,
`image{...}` (см. ниже), `points` — массив `[offset, Z]` (до `max_points` пар),
`points_file` — путь к JSON-файлу вида
`{alignment, station, thickness, total_points, stored_points, offset:[...], z:[...], intensity:[...], slice_distance:[...]}`.

Имена файлов: `section_{station:F1}_{yyyyMMdd_HHmmss}.png` и `.points.json`.

### las_preview_section_polygon (read-only, idempotent)

Полигон поверх кадра + dry-run удаления. Рисует срез и считает по одной и той же
толщине `thickness`.

Аргументы (обязательные: `station`, `thickness`, `polygons`):

| Аргумент | Тип | Default | Описание |
|---|---|---|---|
| `station` | number ≥ 0 | — | пикет сечения |
| `thickness` | number > 0 | — | полная толщина сечения = толщина призмы удаления |
| `polygons` | array 1..50 | — | полигоны: массивы вершин `[[ [offset, Z], ... ], ...]`, каждый ≥ 3 вершин |
| рендер-параметры | — | как у render | `width_px`, `height_px`, `color_by`, `point_px`, `scale_mode`, `z_min`, `z_max`, `grid_step`, `max_stored_points`, `output_dir` |

Ответ `result`: `image{...}`, `thickness` (эхо), `polygons` (эхо вершин),
`slice_points` — точек в срезе, `matched_points` — точек в призмах,
`polygons_counts[{index, inside_points}]` — по каждому полигону (первое совпадение).
Если `matched_points = 0` — в `description` предупреждение (полигон мимо).

### las_delete_section_points (destructive)

Удаляет точки, попадающие хотя бы в одну призму, и пишет результат в НОВЫЙ LAS 1.2
(Point Format 1, интенсивность 16-бит, RGB сохраняется `ColorAwareLasWriter`-ом).
Исходное облако в проекте НЕ меняется; хранилище полигонов не трогается.

Аргументы (обязательные: `output_path`, `sections`):

| Аргумент | Тип | Описание |
|---|---|---|
| `output_path` | string | абсолютный путь выходного `.las` |
| `sections` | array 1..200 | `{station, thickness, polygons}` — как в preview; толщина сечения = толщина призмы |
| `request_id`, `expected_context` | string | общий контракт |

Ответ `result`: `deleted`, `kept`, `published`, `rgb_preserved`, `cancelled`,
`sections` (число), `per_section[{index, deleted}]` — сколько точек вырезала
призма каждой секции (первое совпадение), `output_path`, `elapsed_seconds`, `note`.
Семантика отмены и публикации — как у `las_delete_points_by_polygons`.

## Калибровка изображения

`image` в ответе (одинаковая у render и preview) — чтобы vision-агент мог
сопоставлять пиксели и метры, а разработчик — воспроизвести отрисовку:

```json
{
  "path": "C:\\...\\section_1234.0_20261003_120000.png",
  "format": "png",
  "width_px": 2400, "height_px": 1400,
  "plot": { "left_px": 110, "top_px": 70, "width_px": 2250, "height_px": 1250 },
  "bounds": { "offset_from": -25.0, "offset_to": 25.0, "z_from": 100.2, "z_to": 118.4 },
  "pixels_per_meter_x": 45.0, "pixels_per_meter_y": 68.1,
  "y_axis": "z_up",
  "grid_step_offset_m": 5.0, "grid_step_z_m": 2.0,
  "color_by": "intensity", "color_min": 0.0, "color_max": 65535.0
}
```

Пересчёт: `x = left_px + (offset - offset_from) * pixels_per_meter_x`;
`y = top_px + (z_to - z) * pixels_per_meter_y`. На самом кадре: белое поле,
сетка с подписями (offset внизу, Z слева), заголовок (трасса, пикет, толщина,
число точек; в preview — ещё полигоны и толщина удаления), легенда окраски.
Полигон: полупрозрачная красная заливка + контур 3 px + вершины. `scale_mode=equal`
подбирает единый px/м по обеим осям (стороны не искажены).

## Файлы в кодовой базе

| Файл | Проект | Содержимое |
|---|---|---|
| `Automation/LasAutomationSectionVisualDtos.cs` | LAS_TERRAIN (net35) | DTO: `LasSectionFrame`, `LasSectionPolygonSpec`, `LasSectionPolygonCount`, `LasSectionPreviewResult`, `LasSectionDeleteResult` |
| `Automation/LasAutomation.SectionFrame.cs` | LAS_TERRAIN (net35) | фасад: `GetSectionFrame`, `PreviewSectionPolygons`, `DeleteSectionPoints` + предикат призмы |
| `Mcp/SectionImageRenderer.cs` | LAS_TERRAIN.MCP (net48) | GDI+ рендер кадра: сетка, оси, окраска, полигоны, заголовок; `SectionImageInfo` |
| `Mcp/Tools/LasSectionVisualTools.cs` | LAS_TERRAIN.MCP (net48) | 3 `[ToolDef]`-тула + запись `*.points.json` |
| `Mcp/McpToolContract.cs` | LAS_TERRAIN.MCP (net48) | регистрация провайдера `LasSectionVisualTools` (23 → 26 тулов) |
| `tests/Net35/run_section_visual.ps1` + `SectionVisualTests.cs` | тесты | валидация фасада + предикат призмы (стабы SDK, как `run_section_probe.ps1`) |
| `tests/Mcp/run_section_renderer.ps1` + `SectionRendererTests.cs` | тесты | рендер синтетики без Robur: файл/размеры/калибровка |
| `tests/Mcp/ContractTests.cs` | тесты | каталог 26, схемы трёх новых тулов, валидация `polygons`/`sections` |

Правки csproj: `LAS_TERRAIN.csproj` (+2 Compile), `LasTerrain.Mcp.csproj`
(+`System.Drawing`, +2 Compile).

## Сборка и доставка

1. `MSBuild LAS_TERRAIN.csproj -p:Configuration=Release -p:TopomaticPath="C:\Program Files\Topomatic Robur Rail 16.0"`
2. `MSBuild Mcp\LasTerrain.Mcp.csproj` (те же свойства)
3. Тесты: `tests\Net35\run_section_visual.ps1`, `run_section_probe.ps1`, `tests\Mcp\run.ps1`, `tests\Mcp\run_section_renderer.ps1`
4. `installer\make_package.ps1` → `dist\RoboLas-MCP-<ver>.zip`; основной путь — `build\package.ps1` → tpm (состав пакета не меняется)

## Ограничения

- Удаление всегда пишет новый LAS (облако проекта не редактируется) — повторный
  `las_render_section` после delete покажет прежнюю картинку; результат
  импортируется в Robur вручную. Подтверждение корректности — preview-счёт
  (точный предикат) и картинка с полигоном ДО удаления.
- Все три тула требуют активной трассы и загруженного облака (как `las_get_section_points`).
- `sections` в delete ≤ 200, полигоны ≤ 50 на вызов — граница ответа/памяти.
- Границы призмы открытые (`< thickness/2`), попадание в полигон even-odd —
  как `PolygonGeometry.Contains` у существующего CRS-удаления.
- Кадр пустого среза валиден: сетка + подпись «нет точек» (+ полигоны в preview).
