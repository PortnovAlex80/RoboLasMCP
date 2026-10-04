# RoboLasMCP — план полного переноса (ревизия 2)

Решение владельца: публичный репозиторий RoboLasMCP = **ВЕСЬ плагин RoboLas в
текущем виде** (все команды, UI, все MCP-тулы, иконки, тесты, установщик),
**свободная редакция без защит** (в текущем коде защит уже нет — ветка выросла
из free-линии), **без истории** (один initial commit). Не мини-вырезка.

Источник: D:\Development\Robolas\LAS_TERRAIN, ветка master, коммит bd7365c —
копировать ТОЛЬКО закоммиченное состояние через `git archive` (не рабочую копию).
Приёмник: D:\Development\Robolas\RoboLasMCP (старое содержимое — минимальная
версия — снесено полностью вместе с .git; бэкап-бандл сохранён снаружи:
D:\Development\Robolas\robolasmcp-minimal-20261004.bundle).

## Шаги

1. `git archive master | tar -x -C <temp>` — распаковать во временную папку,
   затем перенести в RoboLasMCP (после полной очистки папки, включая .git).
2. Гигиена — удалить из копии внутреннее (список — в «Решениях переноса»).
3. `topomatic-sweep/` и `knowledge-base/` — проверить grep'ом на внутренние
   упоминания; если чисты — оставить, иначе удалить. Решение записать.
4. Strong-name: убрать из LAS_TERRAIN.csproj и Mcp/LasTerrain.Mcp.csproj
   (SignAssembly/AssemblyOriginatorKeyFile/newkeysnk.snk файл удалить). Всё
   остальное — БЕЗ ИЗМЕНЕНИЙ: имена сборок LAS_TERRAIN(.MCP), манифесты, иконки,
   все команды, все 27 тулов.
5. README.md в корне: переписать — «RoboLas (free) + MCP»: полный плагин RoboLas,
   свободная редакция; два главных сценария (ЦММ по сечениям + визуальная чистка
   полигонами), плюс весь остальной функционал — таблица команд; сборка (2 msbuild),
   установка (installer/ или вручную), robur-mcp как зависимость, подключение
   MCP-клиента, список las_-тулов (27). Русский. Никаких внутренних деталей.
6. Сборка: Rebuild обоих csproj, 0 errors. Тесты: tests/Net35 ключевые
   (run_section_visual, run_section_probe) + tests/Mcp (run.ps1,
   run_section_renderer, verify_registration — счёт 27). Зелёные.
7. Grep-проверка по всему репо: `Семенов|Заслонов|ЛОЖД|PortnovAlex80-приватное|
   robolasfree|beta-wo-guard|LaunchGuard|LicenseGuard|ActivateLicense|BetaBuild|
   newkeysnk` — пусто по коду; в доках допустимы только нейтральные упоминания
   прошлого без деталей. Проверить отсутствие: session.json, .claude, bin/obj в индексе.
8. Git: `git init`, .gitignore как в источнике (+dist/), ОДИН commit. Не пушить.

## Решения переноса (зафиксировано при выполнении, 2026-10-04)

Копия получена `git archive master` (bd7365c) — только закоммиченное состояние.

### Удалено

- `.claude/` (внутренние скиллы с guard-историей), `.serena/` (память внутренних
  агентов, incl. positioning-заметки), `.vscode/`, `docs/.claude/`.
- `native/` — сторонние исходники robur-mcp; вместе с ним `build/build_native_mcp.ps1`
  (собирал только native/). Сборочная ссылка на мост осталась в `Mcp/refs/`
  (оригинальный `Topomatic.ToolBridge.dll` из официального tpm, см. `Mcp/refs/README.md`).
- `dist/` — бинарник установщика (в индекс не попадает, .gitignore уже содержит).
- `newkeysnk.snk` + SignAssembly/AssemblyOriginatorKeyFile из обоих csproj;
  проверки strong-name убраны из `build/verify_release.ps1` (файл ключа, сверка
  токена, sn.exe -vf для LAS_TERRAIN/MCP).
- `harness/` — внутренний dev-harness (машино-зависимые пути, инструкции
  внутреннему агенту). Публичное описание подключения — MCP_AGENT_CONTRACT.md и
  INSTRUKCIYA_ROBOLAS.md; ссылки на harness вычищены из MCP-док.
  `tests/Mcp/test_harness.py` удалён вместе с ним (импортировал harness/robolas_mcp.py).
- `pm-skills/` — пустой след git-submodule внутреннего репозитория.
- `CLAUDE.md` (внутренние инструкции агенту), `Contexter_RoboLas.txt` (внутренний
  дамп дерева; содержали guard-упоминания), `LAS_TERRAIN.plugin.bak` (устаревший
  бэкап манифеста с «Бета команды»).
- Бизнес/маркетинговые доки: ACQUISITION_CHANNELS, MARKETING_COPY(_FINAL),
  MARKET_RESEARCH_RAW, PRICING_STRATEGY, TAM_SAM_SOM_ANALYSIS, CHINA_MARKET_ANALYSIS,
  EXECUTIVE_SUMMARY, PRODUCT_ANALYSIS, PRODUCT_PLAN_ROBOLAS, PROTO_PERSONAS,
  FINAL_POSITIONING, OPENSOURCE_LAS_PROJECTS, ОБНОВЛЕНИЕ_ТАРИФНЫХ_ПЛАНОВ.
- Внутренние research/аудит-логи: ANALYSIS_RESEARCH_LOG, ARCHITECTURAL_ANALYSIS_REPORT,
  ARCHITECTURE_ANALYSIS_2026-03-15, ARCHITECTURE_REVIEW_2026-09-27,
  GRAPH-ground-debug-viz-context, HOST_*_2026-09-29, IPC_REMOTING_POC,
  LIDAR_BUFFER_GAPS_2026-09-29, NET35_CONCURRENCY_GEOMETRY_AUDIT, REFACTORING_*,
  SECTION_PILOT_HOST_CHECK, SPLIT_MERGE_BUG_ANALYSIS, TOPOMATIC_TREE_RGB,
  WORLD_BENCHMARKS, OPENCL_DRIVER_SETUP, FILTERING_PIPELINE, FILTER_CODE_COMPARISON,
  FILTER_EVOLUTION_*, BREAK_DETECTOR_DESIGN, las-writer-baseline,
  algorithm-test-matrix, BUILD_DEPLOY_VERIFICATION, PLUGIN_DEMO_VERIFICATION_REPORT,
  2026-03-14-crs-interactive-drawing, CONTEXT_FOR_AGENTS.
- Каталоги аудита/анализа: `docs/branch-audit-2026-10-01/`, `docs/free-edition-2026-10-01/`,
  `docs/app-deep-analysis/`, `docs/plans/`, `docs/ui/`.
- `docs/PROJECT_STRUCTURE.md` и `docs/CLASS_DIAGRAM.md` — удалены (описывают
  LaunchGuard/LicenseGuard, которых в коде нет; вычищать дороже, чем удалить).
- `docs/topomatic-api-catalog/ARCHITECTURE_GUIDE.md` (описывает guard-архитектуру
  старой версии) и `docs/topomatic-api-catalog/audit/2026-09-27-sdk-verification.md`
  (упоминание внутренней ветки-предка) — грязные по п.7, удалены; остальной каталог чист.
- `build/BASELINE_RECIPE.md` — внутренний рецепт с упоминанием внутренней ветки-предка.
- `Testing/TestClient/LasTerrainTestClient.exe` — бинарный артефакт.

### Оставлено (спорное — с обоснованием)

- `docs/knowledge-base/` — grep по п.7 чист; единственные «beta» — математический
  параметр сплайна в карточке 02-planline-geometry. Полезный публичный справочник
  по API Topomatic.
- `docs/topomatic-sweep/` — grep по п.7 чист. Отчёт по API Topomatic SDK.
- `docs/topomatic-api-catalog/` (без двух удалённых файлов, см. выше) — чистый
  каталог DLL SDK, гайды, our-api-usage.
- `docs/architecture/decisions/` — 34 ADR; по терминам п.7 чисты, упоминают
  прошлое нейтрально и без деталей (историческая ссылка ADR-001 на
  docs/TOPOMATIC_TREE_RGB.md не правилась — это запись о решении своего времени).
- `skills/` (корень) — упакованные агентные скиллы robolas-* (роутер фич,
  пайплайны, verifier сборки); grep чист, полезны контрибьюторам и агентам.
- `demo/ROBOLAS-MCP-DEMO.md` — публичный демо-промпт для MCP-агента, grep чист.
- `tools/` — генератор MCP-схемы настроек, проверка границ архитектуры, утилиты иконок.
- `FAQ_topomatic.txt`, `panels.txt` — чистые SDK-заметки (FAQ включён в csproj
  как Content).
- `BUILD.md`, `build/BUILD_INSTRUCTIONS.md`, `build/build*.ps1/.bat/.sh`,
  `build/package.ps1`, `build/verify_release.ps1` — техническая поставка tpm.
- `Testing/Remoting/` — компилируется в LAS_TERRAIN.csproj под `Diagnostic=true`;
  `Testing/TestClient/*.cs` + `build_and_run.bat` — исходник тест-клиента.
- `LidarBuffer.cs` (корень) — некомпилируемый справочный пример LDAR v2
  (упомянут в ADR-001); правки кода планом запрещены.
- `Mcp/refs/` — compile-time ссылка на официальный Topomatic.ToolBridge.dll.
- `installer/`, `RoboLasInstaller/` — установка; sign_installer.ps1 без секретов.

### Правки вне гигиены (вынужденные, минимальные)

- `build/verify_release.ps1` — убраны strong-name проверки (см. выше).
- `tests/Mcp/verify_registration.py` — убран блок сверки с
  `docs/branch-audit-2026-10-01/register.json` (внутренний аудит-артефакт удалён);
  проверка «27 схем + регистрация всех провайдеров» сохранена.
- `docs/MCP_AGENT_CONTRACT.md`, `docs/MCP_INTEGRATION.md` — вычищены ссылки на
  удалённые harness/ и TOPOMATIC_TREE_RGB.md, упоминание проверки подписи пакета.
- `docs/README.md` — переписан (старый содержал LicenseGuard/PortnovAlex80).
- `docs/INDEX.md` — перестроен под оставшиеся технические доки.
- Комментарий в `installer/Install-RoboLas.ps1` со ссылкой на удалённый
  docs/PROJECT_STRUCTURE.md оставлен как есть (код не меняем).
