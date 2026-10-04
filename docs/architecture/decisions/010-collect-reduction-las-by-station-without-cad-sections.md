# 010. Collect reduction LAS by station without changing CAD sections

- **Status:** Accepted; live host parity remains to be measured
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

Both LAS reduction commands cleared the alignment's `Corridor.Sections` and
inserted a 1 m list before collecting points. `SectionList.Clear()` destroys
existing section objects and their design data even when the export is later
canceled or fails. Restoring only station numbers would not restore section
IDs, construction links, project lines, underlays and other content.

The production `LasSectionPointsCollectorService` uses `Section` only to read
`Station`. It reads `Corridor.Sections` and the corridor `Map` only when a
non-null contour predicate is supplied. Both reduction commands supplied a
predicate that always returned `true`, so they paid for a corridor context but
used none of its data. The SDK's `Section` constructor is internal; constructing
an independent section through the public API is unavailable.

This is a complicated decision: source inspection establishes the collector
control flow, while a live host comparison is still needed to rule out station
normalization or hidden lifecycle effects of `SectionList.Add`.

## Options and MCDA

Scores are 1-5, higher is better, multiplied by the stated weights. They are
engineering estimates for this decision, not measured performance results.

| Driver | Weight | A: common collector core by station | B: save/restore sections | C: retain mutation, improve guards |
|---|---:|---:|---:|---:|
| CAD data safety | 5 | 5 | 1 | 2 |
| LAS geometry and attribute parity | 5 | 4 | 5 | 5 |
| SDK contract confidence | 5 | 4 | 2 | 3 |
| Testability | 4 | 5 | 2 | 4 |
| Throughput and memory | 4 | 5 | 2 | 4 |
| Implementation cost | 3 | 3 | 2 | 5 |
| Reversibility | 3 | 4 | 2 | 5 |
| **Weighted total** | | **126** | **68** | **112** |

A keeps the existing collector core and exposes a raw-output method accepting
an explicit station. The Section overloads forward `section.Station` to that
core. The reduction commands pass no contour predicate and iterate the same
planned station list without touching the CAD section collection. B snapshots
and restores live sections around export. It risks losing object identity and
design content, and restoration itself can fail. C retains the destructive
mutation but attempts better validation/status reporting; it leaves successful
exports destructive.

## Pre-mortem and Red Team

- `SectionList.Add` normalizes a station before the old collector receives it.
  The new command could sample a different slice. The test fixture compares
  station sequence and old/new collector tuples; a disposable host project must
  compare actual output tuples at stations near any normalization boundary.
- The collector still consults `Corridor.Sections` through a hidden branch.
  The new method fixes `pointFilter` to `null`; a production-source fixture
  makes `GetIndex` throw and verifies that collection still succeeds.
- Raw duplicates or boundary points change. Tests compare XYZ/W and order,
  duplicate XYZ with different W, open slice borders and along endpoints.
- A caller accidentally uses the station path where contour filtering matters.
  Its name is `CollectRawAtStation` and it has no predicate argument. Existing
  Section overloads retain the contour path.
- Sampling changes because command batching changes. The commands retain the
  same planned station sequence, flush condition, raw point order and per-batch
  sampling call. Command tests assert station order and publication outcomes.

The independent Red Team identified the always-true predicate as the critical
trap: changing the argument type alone would still require a live corridor
section. It also rejected temporary `Section` construction and station-only
save/restore as unsafe. A was adopted with the predicate removed and direct
collector/command tests added. Host parity remains an explicit acceptance gate.

## Decision

Choose **A**. Use the existing geometry and LiDAR traversal in one collector
core parameterized by station. Give raw exporters a method that cannot request
contours. Neither reduction command changes `Corridor.Sections`. Preserve
the current 0-to-length, 1 m station plan as a separate behavior; whether the
alignment start station should replace zero is outside this correction.

## Consequences and verification

The two commands no longer remove user sections on success, cancellation,
overflow, collection failure, writer failure or empty output. The actual
collector fixture verifies raw XYZ/W and order parity and confirms the new
path does not access `Corridor.Sections`; the command fixture verifies original
section object identity and fields across outcomes. Both compile against the
Rail 16 SDK and the full .NET 3.5 test runner passes. SDK-shaped fixtures
cannot prove live host `SectionList.Add` normalization, actual LiDAR buffer
timing or GUI status behavior. Those need the isolated host contour.

## Decision Journal

**Ex-ante expectation:** on a disposable Rail project, both commands export
the same point tuples, attributes and order as the prior build for the same
cloud while preserving the exact original section objects and design content.
The contour Map should no longer be read by these exporters.

**Check trigger:** first isolated Topomatic run of both reduction commands
against a project with custom section designs and an LAS input containing
boundary and duplicate points. **Revisit if:** the host normalizes `Add`
stations, changes `StaOffsetToPos` based on registered sections, or shows
output tuple differences.
