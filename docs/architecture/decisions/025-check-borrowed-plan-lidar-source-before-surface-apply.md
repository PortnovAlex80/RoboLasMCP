# 025. Check borrowed Plan LiDAR metadata before surface apply

- **Status:** Accepted for offline integration; Rail 16 host acceptance remains open
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

The two Plan surface commands capture one list of LiDAR buffers and scan it
twice. ADR 018 pins the view, active alignment, project, document and surface
through the final CAD insert, but it does not detect a replaced point array,
indexer or transform during the scans. The LAS export commands already compare
this metadata before publishing files. The fork is **Complicated** because the
SDK exposes borrowed arrays, while provider wrapper lifetime and mutation
events cannot be established from the available binary API.

## Options and decision drivers

Scores are 1-5, higher is better. Correctness and SDK resource safety carry
the greatest weight; cost and reversibility still matter for a host plugin.

| Driver | Weight | A: reuse LAS export context | B: shared captured snapshot | C: Plan-only snapshot with provider recollection |
|---|---:|---:|---:|---:|
| Detect stale metadata before insert | 5 | 2 | 4 | 5 |
| SDK resource safety | 5 | 2 | 4 | 2 |
| Testability | 3 | 3 | 5 | 4 |
| Implementation cost | 2 | 4 | 3 | 3 |
| Reversibility | 2 | 4 | 4 | 4 |
| **Weighted total** | | **45** | **69** | **61** |

A would require a Plan/compound-line/DTM-offset contract that the Plan surface
commands do not currently need. A and C would re-enumerate providers at each
check. Their `GetBuffer()` wrapper stability has not been verified in Rail 16,
and extra calls could reject an unchanged source or load/dispose SDK data.

Choose B. `BorrowedLidarSourceSnapshot` extracts the existing ordered
buffer/indexer metadata comparison from `LasExportSourceContext`. The export
commands still re-enumerate the selected alignment and compare that fresh
list. `PlanSurfaceTarget` compares its captured list before scanning and in
the synchronous writer validator before CAD insertion. Plan keeps its one
provider collection, two sequential active-alignment receivers, and v1
polygon directory from the first named buffer. Numeric algorithms, command
IDs, LAS and polygon formats do not change.

## Pre-mortem and Red Team

1. A normal host run recreates a point-array wrapper when `GetBuffer()` is
   called after the first receiver closes. The strict check would stop a
   valid insert. The isolated host run must measure wrapper identity before
   relaxing any check; the failure is reversible and leaves CAD untouched.
2. Another tool replaces a provider while the old captured buffer stays
   alive. The Plan check cannot see the new provider without re-enumeration.
   The active-alignment receiver still checks the selected alignment, but
   provider replacement within it remains an open host gate.
3. Another tool edits values in the same backing array, or changes a QuadTree
   leaf without changing checked metadata. The snapshot cannot detect it.
   It also provides no lock or version for the interval between validation
   and array reads. A stable SDK read lease or equivalent host guarantee is
   needed before claiming concurrent source safety.
4. A getter throws after disposal or replacement. Capture fails closed, and
   `IsCurrent` returns false; neither path may insert points. This is covered
   by the context fixture and command failure assertions.

The Red Team preferred B because it preserves the production Plan provider
enumeration contract while adding a check at the existing writer boundary.

## Verification and Decision Journal

The production Plan fixture now changes paths, point arrays, weight arrays
and transforms during each command's second scan. All eight runs reach the
apply validation, insert no points and report no success; unchanged runs
still succeed. It reports 200 checks. The existing LAS export context fixture
reports 72 checks, covering ordered buffers/indexers, counts, transforms and
getter failures after extraction. The full .NET 3.5 suite, architecture
checker, normal and diagnostic Rail 16 builds pass. This is offline evidence;
it cannot establish host wrapper lifetime, Undo or TIN behavior.

**Ex-ante expectation:** ordinary unchanged Plan runs still insert the same
points; a metadata replacement during a scan fails before CAD insertion.

**Check trigger:** first isolated Rail 16 run with the disposable copied
project, or any SDK version change affecting LiDAR source wrappers.

**What would change this decision:** evidence that ordinary unchanged runs
recreate array wrappers or invalidate `GetBuffer()` after receiver disposal,
or that provider replacement is common during a modal progress scan. Those
findings require a verified host API for identity or a read lease before a
broader Plan source check.
