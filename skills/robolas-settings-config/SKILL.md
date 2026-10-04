---
name: robolas-settings-config
description: Change RoboLas persisted preferences, runtime controls, and per-operation filter parameters without changing settings during a running calculation.
---

# RoboLas Settings Config

Saved preferences configure the next operation. Active filtering reads one immutable `FilterOperationSnapshot` captured under the `RuntimeConfig` lock and passed into the numerical code.

## Inspect

- `LaunchSettings/Settings.cs` for persisted keys and defaults.
- `Infrastructure/RuntimeConfig.cs`, `Infrastructure/FilterSettingsSnapshotAdapter.cs`, and `Infrastructure/UserControl/LasSettingsPanel.cs` for loading, capture, validation, and UI updates.
- `Domain/Models/FilterOperationSnapshot.cs`, `Domain/Service/LasFilterService.cs`, `Domain/Filters/FilterAggregator.cs`, and each invoked filter for the calculation path.

## Change a setting

1. Preserve existing storage keys and defaults unless the requested product behavior changes them. Validate loaded and UI values consistently.
2. Decide whether the value is a saved preference, an operation parameter, or an output option. Put calculation parameters into the immutable snapshot captured before work begins.
3. Pass the snapshot through service, aggregator, and filters. Verify that UI edits during a run affect the next run only.
4. `RuntimeConfig` stores preferences; filter algorithms receive the captured values. Do not reintroduce static filter fields or synchronize them from the settings panel. Inspect any remaining caller before removing its legacy overload.
5. Test the affected production path with distinct values and a preference edit during a run. Verify that the in-flight result uses its captured values.

An environment-only feature flag need not be persisted or shown in the panel.
