---
name: robolas-topomatic-build-verifier
description: Verify RoboLas changes against plugin wiring, build constraints, and Topomatic integration risks. Use when reviewing or finishing work that touches command registration, `LAS_TERRAIN.plugin`, the explicit `Compile Include` list in `LAS_TERRAIN.csproj`, Topomatic references, old .NET Framework 3.5 limitations, or any change that may compile yet fail because the plugin wiring is incomplete.
---

# Robolas Topomatic Build Verifier

Assume this project can fail through configuration drift as easily as through code bugs. Verify the wiring, not just the edited logic.

## Read First

- Read `../../LAS_TERRAIN.csproj`.
- Read `../../LAS_TERRAIN.plugin`.
- Read `../../LasTerrainPluginHost.cs`.
- Read `../../Module.cs`.
- Read `../../CommandRegistry/SectionRegistry.cs`.
- Read `../../build/build.ps1`.
- Read `../../build/BUILD_INSTRUCTIONS.md`.

## Verification Checklist

1. If a new source file was added, confirm `LAS_TERRAIN.csproj` contains an explicit `Compile Include`.
2. If a command was added or renamed, confirm the string is synchronized across the use case, `Module.cs`, and `LAS_TERRAIN.plugin`.
3. If a plugin menu, toolbar, ribbon, or panel references an action id, confirm the action id exists.
4. If a use case was added, confirm it has a parameterless constructor and `SectionCmdAttribute`.
5. If a setting was added, confirm the runtime mirror and UI or environment path are both complete.
6. If a build was attempted, report clearly whether Topomatic installation paths were available.

## Build Constraints

- The project targets .NET Framework 3.5.
- The project uses an old-style `.csproj` with explicit compile items.
- Build output depends on a valid `TopomaticPath` and installed Topomatic assemblies.
- Plugin loading depends on `LasTerrainPluginHost` returning `Module` and on the manifest pointing to the correct host type.

## Preferred Commands

- Use `rg` to verify command strings, action ids, and compile includes.
- Use `git diff --stat` and targeted file reads to confirm that every wiring point changed together.
