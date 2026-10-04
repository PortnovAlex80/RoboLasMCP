# 015. Prepare generated-section calculation from station values

- **Status:** Accepted as a calculation boundary; CAD command switch awaits host verification
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and decision drivers

`calculation_async_one_meter_section` and
`calculation_async_custom_step` currently call
`Corridor.Sections.Clear/Add` before collecting or filtering points.
Cancellation, empty results and calculation failure can therefore leave
changed CAD sections. In both current collectors, when the contour predicate
is null, a `Section` contributes only its `Station`. The shared command
adapter always passes a null contour predicate.

The drivers are numerical parity, no early CAD mutation, explicit ownership
of calculation inputs, focused testability and implementation cost.

## Considered options

Scores are weighted engineering estimates on a 1–5 scale.

| Driver | Weight | A: station-value entry | B: detached SectionList | C: keep early replacement |
|---|---:|---:|---:|---:|
| Numerical parity | 5 | 4 | 5 | 5 |
| Calculation boundary | 5 | 5 | 3 | 1 |
| Testability | 4 | 5 | 3 | 2 |
| Implementation cost | 3 | 3 | 5 | 5 |
| Reversibility | 3 | 4 | 4 | 5 |
| Host independence | 5 | 4 | 3 | 1 |
| **Weighted total** | | **106** | **94** | **73** |

A adds station-only entry points to the legacy and OnePass collectors,
converging on their original numerical loops. `GroundPointsCollector`
captures section offsets once and passes the same filter snapshot and
station order to its existing calculation workflow. B creates
`SectionList(null)` from the planned values, avoiding collector changes but
retaining an SDK section object in the calculation input. C leaves the
known early-mutation defect.

## Pre-mortem and Red Team

- A station is normalized when added to a project-owned `SectionList`,
  so an offline calculation differs from the old command. A detached copied
  SDK probe preserves bits for five stations, but only the isolated host can
  prove project-owned behavior. Do not switch the commands before that check.
- OnePass source order, borders or negative indexer scales change. The test
  compiles the actual OnePass source and compares section and station entry
  paths over duplicate positions, open borders, parallel traversal and
  negative X scale. Hand-counted membership supplements parity. The station
  list is copied before SDK preparation; a test mutates the caller's list
  during the first geometry call.
- Legacy processing reads different alignment offsets between sections.
  The station entry captures left and right offsets into a new options
  object. A fixture changes the alignment after the first collection and
  checks that both sections use the captured value.
- A caller confuses a safe calculation with a safe CAD commit. The generated
  commands still use their old application path. The SDK exposes
  `SectionList.Clear/Add/Remove` but no public way to restore the original
  Section objects, IDs, design content and notifications after `Clear`.
  Surface-tail compensation alone cannot restore those. A target-validated
  combined CAD commit, undo behavior and TIN update still require an isolated
  host experiment.

The independent Red Team favored explicit station values over a detached
SDK list but warned against changing command commit order without proven
rollback. It also identified offset capture and Empty-result behavior as
regression points. The implementation prepares calculation only; it does not
claim PR-06 acceptance.

## Decision and consequences

Choose A. Expose `CollectAtStation`, `CollectAllAtStations` and
`CollectPilotAtStations`; validate all station values before SDK work.
Preserve the original Section entry points and numerical loops. Keep
generated-section commands on their existing route until a disposable
Topomatic project demonstrates station parity, exact old-section
preservation on failure, Undo/Redo and surface/TIN behavior.

The actual OnePass source passes 45 station-parity checks; the legacy
collector passes 43 status/parity checks; the production-chain fixture
passes 139 checks. The full .NET 3.5 runner, copied Rail 16 Release build
and zero-violation architecture check pass. No test here executes the
combined section/surface commit in a Topomatic GUI.

## Decision Journal

**Ex-ante expectation:** generated-section calculation can use the planned
station doubles with the same ordered point tuples as the Section entry,
while cancellation or filtering can finish before any CAD section change.

**Check trigger:** first isolated GUI comparison of old and station paths,
and any future change to `SectionList.Add`, collector geometry, or the
generated-section command application stage.
