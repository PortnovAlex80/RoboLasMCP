# RoboLas (LAS_TERRAIN) — документация

Плагин **RoboLas** для **Topomatic Robur Rail 16.0**: обработка LiDAR-облаков
(LAS), построение ЦММ по сечениям трассы, визуальная чистка полигонами и
MCP-интерфейс для ИИ-агентов. Свободная редакция без ограничений.

| Характеристика | Значение |
|---|---|
| Язык | C# (ядро .NET Framework 3.5, MCP-адаптер .NET Framework 4.8) |
| Платформа | Windows |
| Хост | Topomatic Robur Rail 16.0 |
| Тип проекта | Class Library (плагин) + MCP-расширение |

## Документация

| Документ | Описание |
|---|---|
| [INSTRUKCIYA_ROBOLAS.md](INSTRUKCIYA_ROBOLAS.md) | Инструкция пользователя: установка, команды, сценарии работы |
| [MCP_AGENT_CONTRACT.md](MCP_AGENT_CONTRACT.md) | Контракт MCP-агента: подключение, 27 инструментов `las_*`, запросы/ответы, ограничения |
| [MCP_INTEGRATION.md](MCP_INTEGRATION.md) | История и устройство интеграции с robur-mcp |
| [MCP_SECTION_POINTS.md](MCP_SECTION_POINTS.md) | Контракт `las_get_section_points`: срезы точек по сечениям |
| [MCP_SECTION_VISUAL.md](MCP_SECTION_VISUAL.md) | Визуальная чистка сечений: PNG-рендер, полигоны, удаление точек |
| [INDEX.md](INDEX.md) | Полный индекс документации |
| [PLAN.md](PLAN.md) | План публикации репозитория и решения переноса |

Дополнительно:

- [architecture/decisions/](architecture/decisions/) — архитектурные решения (ADR);
- [knowledge-base/](knowledge-base/) — справочник по API Topomatic SDK;
- [topomatic-api-catalog/](topomatic-api-catalog/) — каталог DLL Topomatic SDK;
- [topomatic-sweep/](topomatic-sweep/) — обзор API Topomatic SDK;
- [../demo/ROBOLAS-MCP-DEMO.md](../demo/ROBOLAS-MCP-DEMO.md) — готовый демо-промпт для MCP-агента.

## Основные компоненты

```
Точка входа
    ↓
LasTerrainPluginHost.cs
    ↓
Module.cs (регистрация команд)
    ↓
SectionCommandRunner (выполнение)
    ↓
SectionRegistry (реестр Use-Case)
    ↓
ISectionUseCase (конкретная команда)
    ↓
Services (бизнес-логика)
```

MCP-слой: `Mcp/` (LAS_TERRAIN.MCP, .NET 4.8) расширяет официальный
`robur-mcp` и транслирует вызовы в `Automation/` плагина.

## Добавление новой команды

```csharp
// 1. Создайте Use-Case в UseCases/
[SectionCmdAttribute("my_command")]
public class MyCommandUseCase : ISectionUseCase
{
    public string Name => "my_command";
    public void Run(SectionEnv env) { /* логика */ }
}

// 2. Добавьте делегатор в Module.cs
[cmd("my_command")]
public void MyCommandExecutor()
{
    SectionCommandRunner.Run("my_command", CadView);
}
```

## Сборка

- **Целевые фреймворки:** .NET 3.5 (ядро), .NET 4.8 (MCP-адаптер)
- Инструкции: [../BUILD.md](../BUILD.md), [../build/BUILD_INSTRUCTIONS.md](../build/BUILD_INSTRUCTIONS.md)
