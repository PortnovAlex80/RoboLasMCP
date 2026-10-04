---
name: robolas-plan-crs-overlay
description: Change RoboLas Plan/CRS polygon drawing, project-scoped persistence, overlays, or polygon-driven point operations.
---

# RoboLas Plan/CRS Overlay

Production Plan and CRS polygon commands use the v2 scoped repository. Plan
polygons belong to the saved project; CRS polygons additionally belong to a
model and alignment. A saved project without a
cloud can still draw and clear polygons. LAS export and CAD operations that
read borrowed LiDAR data verify that source separately.

## Inspect

- `Infrastructure/ScopedPolygonOperationContext.cs` and
  `Infrastructure/PolygonContextResolver.cs` for the captured host owner,
  scope, source checks, and section identity.
- `Domain/Persistence/PolygonScope.cs` and
  `Domain/Persistence/ScopedPolygonRepository.cs` for storage, revision
  conflicts and portable JSON files.
- `UseCases/PolygonFileUseCase.cs` and `Domain/Persistence/PortablePolygonFile.cs` for save/load of user-selected polygon files.
- `Domain/Service/CrsScopedSectionAssociation.cs` for current CRS section
  ID/station validation.
- `Services/Layers/PlanOverlayLayer.cs` and the affected drawing handler for
  rendering and lifetime behavior.

## Rules

1. Capture project, document, model, alignment, scope, and current section
   identity on the CAD thread. Reject an unsaved or unidentified owner.
   Recheck the captured owner before committing; long scans must also recheck
   the repository revision and borrowed LiDAR source before publication.
2. Edit a repository snapshot and commit against its expected revision.
   Report conflicts and write failures. Update the persistent Plan overlay
   only from a committed snapshot. Its paint path clears stale owner or
   revision state; do not render one project's polygons in another view.
3. Export one JSON file per polygon to a user-selected folder. Import appends
   to the current captured scope; Plan keeps world X/Y, CRS explicitly binds
   to the selected current section. Validate every file before committing.
4. Before a CRS point operation, resolve each saved polygon to the current
   section ID and station. Preserve the current overlay thickness semantics
   until a separate behavior change is requested. If LAS publication succeeds
   but polygon clearing fails, report both outcomes distinctly.
5. Keep drawing previews transient and detach interactive handlers on
   success, cancellation, failure, and view closure. Release view-specific
   overlays when their view closes.

Run the .NET 3.5 polygon command fixtures and the signed Rail 16 Release
verifier after command or repository changes. Live host acceptance for the
polygon file commands is still open; fixtures alone do not
establish that UI behavior.
