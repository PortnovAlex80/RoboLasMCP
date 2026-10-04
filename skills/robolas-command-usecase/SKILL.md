---
name: robolas-command-usecase
description: Add or update RoboLas commands and their bound use cases safely. Use when a change touches `Module.cs`, `UseCases/*`, `CommandRegistry/*`, `LAS_TERRAIN.plugin`, command names, Topomatic menu or ribbon wiring, or any feature that must be invokable through a new or existing command string.
---

# Robolas Command Usecase

Implement command-facing changes by keeping the command string synchronized across every binding point. Treat command wiring as a literal-string contract.

## Read First

- Read `../../Module.cs`.
- Read `../../CommandRegistry/SectionCmdAttribute .cs`.
- Read `../../CommandRegistry/ISectionUseCase.cs`.
- Read `../../CommandRegistry/SectionRegistry.cs`.
- Read `../../CommandRegistry/SectionCommandRunner.cs`.
- Read `../../LAS_TERRAIN.plugin`.

## Workflow

1. Choose a stable command name in snake_case.
2. Create or update a use case class under `../../UseCases/` with `[SectionCmd("command_name")]`.
3. Keep `Name` equal to the same command string.
4. Keep the constructor parameterless. `SectionRegistry` uses `Activator.CreateInstance`.
5. Add or update the `[cmd("command_name")]` bridge method in `../../Module.cs`.
6. If the command is user-visible, add or update the matching action entry in `../../LAS_TERRAIN.plugin`.
7. Add or update every menu, toolbar, ribbon, or panel reference that should expose the command.
8. If the command is only a thin wrapper over the shared section pipeline, keep the use case thin and pass configuration through `SectionExecutionContext`.

## Wiring Rules

- Keep these values identical:
  - `[SectionCmd("...")]`
  - `Name => "..."`
  - `SectionCommandRunner.Run("...", CadView)` inside `Module.cs`
  - `"cmd": "..."` in `LAS_TERRAIN.plugin`
- If a plugin menu or ribbon references an action id, that action id must exist in the `actions` block.
- If a command stops being supported, remove both the action definition and every reference to its id.

## Preferred Patterns

- Prefer a thin use case when the feature is just a configuration variant of an existing workflow.
- Prefer a dedicated use case with internal logic when the feature has its own interaction model, persistence, or LAS export flow.

## Known Traps

- `SectionRegistry` auto-discovers only classes implementing `ISectionUseCase` and decorated with `SectionCmdAttribute`.
- `LAS_TERRAIN.plugin` is stringly typed. A single typo silently breaks discoverability.
- This repo already had a dangling menu reference without a matching action id. Always verify both directions.
