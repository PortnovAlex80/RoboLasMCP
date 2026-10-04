---
name: robolas-batch-las-io
description: Build RoboLas features that process large LAS point sets in batches and write LAS output safely. Use when implementing or changing reduction, splitting, export, point deletion, buffer rewrites, streaming writers, save-path prompts, chunked progress, or memory-sensitive loops over `LidarBuffer` data.
---

# Robolas Batch Las Io

Default to new LAS output files and chunked writing. This codebase already treats many destructive operations as "read buffers, compute, write a new LAS".

## Read First

- Read `../../Services/LidarBufferService.cs`.
- Read `../../Services/SaveLidarPointsService.cs`.
- Read `../../Infrastructure/LasBatchStreamWriter.cs`.
- Read `../../UseCases/ReduceLasAsyncToPercentUseCase.cs`.
- Read `../../UseCases/PlanDeletePointsUseCase.cs`.
- Read `../../UseCases/CrsDeletePointsUseCase.cs`.

## Workflow

1. Resolve the active alignment and collect `LidarBuffer` instances through `LidarBufferService`.
2. Validate buffers before any heavy work.
3. Ask for an output path when the feature produces a new LAS file.
4. Process points in chunks or section batches instead of materializing unnecessary giant arrays.
5. Stream writes through `LasBatchStreamWriter` or `LasStreamWriter`.
6. Report progress through `WaitProgress` at feature-level granularity.
7. Show a final summary with counts and output path.

## Guardrails

- Preserve point weight or intensity data when the writer supports it.
- Prefer `LasBatchStreamWriter` for very large outputs.
- Keep cancellation checks in long-running loops.
- Derive project-local persistence paths from `buffer.fullpath` only when the feature genuinely needs project-adjacent metadata.
- Mutate `.ldr` buffers only when the request explicitly calls for in-place buffer rewrite.
- New cloud exports use staged LAS publication; there is no supported in-place
  `.ldr` rewrite helper. Verify rollback and SDK buffer ownership before adding one.

## Preferred Feature Shapes

- For reduction features, process a tractable batch, reduce it, flush it, and continue.
- For polygon-delete features, keep geometry tests separate from writing so counters and progress remain understandable.
