---
name: robolas-filter-pipeline
description: Change RoboLas terrain filtering logic without breaking the shared ground-processing chain. Use when modifying `FilterAggregator`, `LasFilterService`, graph ground classification, break detection, spline or morphology filters, split-and-merge simplification, or the runtime switches and progress contracts around those stages.
---

# Robolas Filter Pipeline

Treat filtering as a domain pipeline over section-local 2D points. Keep UI, Topomatic view logic, and command wiring outside the filters.

## Read First

- Read `../../Domain/Service/LasFilterService.cs`.
- Read `../../Domain/Filters/FilterAggregator.cs`.
- Read `../../Domain/Filters/GraphGroundFilter.cs`.
- Read `../../Domain/Filters/BreakDetector.cs`.
- Read `../../Domain/Filters/RobustGroundSplineFilter.cs`.
- Read `../../Domain/Filters/MinWeightedGroundLevelMedianFilter.cs`.
- Read `../../Domain/Filters/SplitAndMergeAlgorithm.cs`.
- Read `../../Infrastructure/RuntimeConfig.cs`.
- Read `../../LaunchSettings/Settings.cs`.

## Workflow

1. Identify whether the change belongs to classification, break detection, smoothing, simplification, or 2D-to-3D reconstruction.
2. Keep section input in section-local coordinates: `X` is along-track, `Y` is elevation.
3. If the change alters stage ordering or stage count, update the progress contract in every consumer.
4. If the algorithm is user-selectable, wire it through `RuntimeConfig` and `Settings`.
5. Reconstruct world-space 3D points only in `LasFilterService`.

## Guardrails

- `FilterAggregator` is the source of truth for stage order.
- `LasFilterService` must stay thin: it feeds the aggregator and converts filtered 2D points back into world 3D points.
- Keep runtime switches functional:
  - `RuntimeConfig.UseSplineFilter`
  - `FilterAggregator.EnableBreakDetection`
- Do not put `CadView`, dialogs, or file I/O into filter classes.

## Known Trap

- `GroundPointsCollector` currently assumes a hardcoded filter-stage count. If you add or remove stages, audit the collector-side progress math as part of the same change.
