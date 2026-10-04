---
name: robolas-feature-router
description: Classify RoboLas feature requests and route them to the correct implementation path before editing code. Use when a request touches LAS_TERRAIN commands, use cases, section-based terrain generation, filter-chain logic, batch LAS processing, Plan or CRS overlay tools, settings wiring, or plugin and build verification and you need to decide which RoboLas skill should drive the change.
---

# Robolas Feature Router

Read the request and classify it before changing code. Prefer one primary skill and at most one secondary verifier skill.

## Route Table

- Choose `robolas-command-usecase` when the request adds, removes, renames, or rewires a Topomatic command, action, toolbar button, ribbon item, or use case class.
- Choose `robolas-section-pipeline` when the request builds surface points from corridor sections, clips by contour, saves section-derived LAS output, or changes `SectionExecutionContext` and `SectionBaseUseCase`.
- Choose `robolas-filter-pipeline` when the request changes terrain filtering, spline or morphology behavior, break detection, simplification, or stage ordering inside the ground-processing chain.
- Choose `robolas-batch-las-io` when the request reduces, splits, exports, rewrites, or streams large LAS point sets and the result is a new LAS file or rewritten buffer data.
- Choose `robolas-plan-crs-overlay` when the request adds or changes interactive polygon drawing, overlay layers, persistent polygon storage, or point deletion by polygon in Plan or CRS views.
- Choose `robolas-settings-config` when the request adds a new runtime knob, persisted option, settings-panel control, or config-backed algorithm switch.
- Choose `robolas-topomatic-build-verifier` when the main need is validation: command wiring, manifest consistency, old-style project file updates, .NET 3.5 constraints, or Topomatic build risk review.

## Read First

- Read `../../Module.cs`.
- Read `../../CommandRegistry/SectionRegistry.cs`.
- Read `../../UseCases/SectionExecutionContext.cs`.
- Read `../../Services/SectionBaseUseCase.cs`.
- Read `../../LAS_TERRAIN.plugin`.

## Decision Rules

- If the request affects what the user can click or call, include `robolas-command-usecase`.
- If the request changes how section points are collected or inserted into surfaces, include `robolas-section-pipeline`.
- If the request changes only math on section-local points, prefer `robolas-filter-pipeline` over editing use cases directly.
- If the request writes LAS output in batches, include `robolas-batch-las-io`.
- If the request touches polygon collections or overlay layers, include `robolas-plan-crs-overlay`.
- If the request adds a user-controlled parameter, include `robolas-settings-config`.
- Before finishing substantial work, run through `robolas-topomatic-build-verifier`.

## Guardrails

- Do not start by editing random use cases. Classify first, then follow the dominant pattern already used in this repo.
- Do not assume folder names match namespaces. This codebase has logical namespaces that cross physical folders.
- Do not trust only documentation. Confirm the live wiring in code and in `LAS_TERRAIN.plugin`.
- Do not finish a feature without checking whether the old-style `LAS_TERRAIN.csproj` also needs an explicit `Compile Include`.
