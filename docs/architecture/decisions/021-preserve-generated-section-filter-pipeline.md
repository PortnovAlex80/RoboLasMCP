# 021. Preserve the generated-section filter pipeline before CAD staging

- **Status:** Superseded for the command switch by ADR 027 after the Rail 16 host probe
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

The generated-section commands replace `Corridor.Sections` before collection.
This can discard the old sections on cancellation or calculation failure.
ADR 015 introduced station-based collection, but its `CollectPilotAtStations`
uses the two-stage `SectionWorkflow`. The generated commands use the legacy
three-stage collect, filter and XY-deduplicate pipeline. Switching them to the
pilot would change both the computation path and CAD mutation order at once.

The copied SDK exposes `SectionList.Clear/Add(double)` but no public method
to reinsert an original `Section` with its ID and design data. A detached
`SectionList(null)` preserves tested station bits but has no transaction
manager. Project-owned station normalization, Undo, TIN and raw surface-point
insertion remain unverified.

## Options

Scores are estimates on a 1–5 scale; higher is better.

| Driver | Weight | A: prepare legacy station path | B: switch commands now | C: keep existing code |
|---|---:|---:|---:|---:|
| Numeric regression control | 5 | 5 | 3 | 5 |
| CAD failure safety today | 5 | 2 | 3 | 1 |
| Testability | 4 | 5 | 3 | 1 |
| Reversibility | 3 | 5 | 2 | 5 |
| Host evidence required | 4 | 4 | 1 | 5 |
| **Weighted total** | | **86** | **52** | **69** |

Option A adds `CollectAtStations` to the existing three-stage path and leaves
the commands on their current route. Option B calculates first and applies
sections later, with a partial-result policy if CAD application fails. Option
C does no preparatory work. A wins because it can be tested without changing
live command output while retaining the exact filtering and deduplication
methods used by the commands.

## Pre-mortem and independent Red Team

- Switching to `CollectPilotAtStations` would change filter and progress
  behavior; the new entry shares `CollectCore` and its three stages instead.
- Caller station values or alignment offsets could change between sections;
  the station entry copies every station and both offsets before collection.
  The existing `Collect(Section)` path retains its former origin-offset read.
- A non-null contour predicate would read the registered corridor and could
  make the station path invalid; the station entry always passes null.
- Generated sections might be normalized when added to a project-owned list.
  Detached SDK evidence does not rule this out. Compare old and station
  calculation on a disposable saved project before switching commands.
- A late `Clear/Add` failure cannot be rolled back by re-adding station
  numbers: IDs and design content would be lost. Verify actual project Undo
  and section/surface/TIN behavior before claiming a safe combined commit.
- The fixture uses production filtering with test SDK collectors. It proves
  shared downstream behavior, not full numeric parity inside the host.

## Decision and consequences

Add `GroundPointsCollector.CollectAtStations`, sharing the legacy filtering,
deduplication and result-status path with `Collect(Section)`. The Rail 16
probe later found exact ordered XYZ parity on 30 sampled sections (2,008
points in both legacy and OnePass modes) and verified project-owned section
Rollback/Undo/Redo. ADR 027 records the command switch and its remaining
surface Undo/TIN limitations.

## Decision Journal

**Ex-ante expectation:** identical collected section points produce identical
ordered XYZ through either entry, including the first point retained in each
millimetre XY cell; station and offset inputs stay fixed during a run.

**Check trigger:** project-owned station comparison, command switch, or any
change to the collector's stage sequencing, section geometry or SDK Undo API.
