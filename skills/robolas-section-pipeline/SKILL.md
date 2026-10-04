---
name: robolas-section-pipeline
description: Change RoboLas section collection, filtering, pilot workflow, cancellation, or applying section-derived results to a surface or LAS output.
---

# RoboLas Section Pipeline

`calculation_async_section` uses the UI-free `SectionWorkflow` for filtering and
deduplication. The one-metre and custom-step commands calculate from planned
station values through `GroundPointsCollector.CollectAtStations`, then replace
CAD sections after calculation. They deliberately retain the legacy three-stage
filter path; `CollectPilotAtStations` has only fixture parity, not live host
acceptance for these commands. See ADR 021 and ADR 027 before changing this
boundary.

## Inspect

- `UseCases/CalculateSectionAsyncUseCase.cs`, `UseCases/SectionExecutionContext.cs`, and `Services/SectionBaseUseCase.cs` for the command adapter and commit order.
- `Services/GroundPointsCollector.cs` and `Application/SectionRequest.cs`, `Application/SectionWorkflow.cs`, `Application/OperationResult.cs` for the legacy and pilot calculation contracts.
- `Domain/Models/FilterOperationSnapshot.cs` and `Domain/Service/LasFilterService.cs` for fixed filter settings.
- `Infrastructure/UserDialogs.cs`, `Services/SectionStationPlanner.cs`, and `Services/SaveLidarPointsService.cs` when dialogs, section generation, or export are involved.

## Preserve the boundary

1. Collect required dialogs and validate station values before changing CAD sections. Generated-section commands already calculate from stations before `Clear/Add`; preserve the legacy filter/deduplicate order and the valid empty-result section behavior.
2. Capture the destination, alignment and section identities, scalar options, and one filter snapshot before calculation. Keep SDK preparation and access to borrowed LiDAR resources sequential until thread safety is verified.
3. Use `SectionWorkflow` for the pilot; its filter/deduplicate result has explicit success, empty, cancelled, failed, and overflow outcomes. Generated-section commands use the legacy three-stage filtering path. Keep numerical calculation separate from CAD mutation.
4. Before applying, recheck the captured CAD target on its UI thread. Generated-section replacement uses a project-owned `SectionList` transaction and reports partial surface application explicitly. Preserve `TopomaticSurfaceWriter` insertion and compensation behavior. The copied Rail 16 host verified section Rollback/Undo/Redo, but raw surface-point insertion has no proven Undo or TIN rebuild; do not claim a combined atomic commit.
5. Keep file export as an explicit request and completion/publish step. A CAD change and a LAS publish need separate outcome and retry handling.

Do not treat `OnePass` SDK trees or arrays as detached snapshots; their lifetime lasts through the operation.
