# 011. Split LAS by station with an in-collector coordinate filter

- **Status:** Accepted; live host parity still required
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`split_las_by_offset` replaced all CAD sections with a 1 m list, then made
separate outer and inner LiDAR collection passes. The command does not publish
CAD sections as a result; replacing them destroys section design data even on
a successful LAS split. Unlike the reduction commands in ADR 010, it filters
points by projected `sectionPoint.X`. The two predicates use strict cutoffs:
outer `x < -left || x > right`, inner `x > -left && x < right`. Points exactly
at either cutoff enter neither output.

The legacy collector applies the predicate inside `FindPoints`, before its
per-section point cap and raw append. `RawPointsCollector` then removes exact
XYZ duplicates separately for each pass, retaining the first point's weight.
It reads corridor design contours merely because its predicate type accepts
them; this split predicate ignores contours. The actual geometry still uses
`alg.DtmSizeLeft/Right`. User offsets are classification cutoffs, not geometry
extents.

## Options and MCDA

Scores 1-5 are weighted engineering estimates, not measured performance.

| Driver | Weight | A: station and coordinate predicate in existing collector | B: collect all then partition | C: retain section mutation with guards |
|---|---:|---:|---:|---:|
| CAD data safety | 5 | 5 | 2 | 1 |
| Filter and point-cap parity | 5 | 5 | 2 | 5 |
| Dedup and source order parity | 5 | 5 | 2 | 5 |
| Throughput and memory | 4 | 4 | 2 | 4 |
| SDK contract confidence | 4 | 4 | 4 | 2 |
| Testability | 4 | 5 | 3 | 4 |
| Implementation cost | 3 | 3 | 2 | 5 |
| Reversibility | 3 | 4 | 3 | 5 |
| **Weighted total** | | **148** | **81** | **125** |

A adds a projected-coordinate predicate to the existing collector core, called
before the point cap. A station-based `RawPointsCollector` entry retains the
same loop, cancellation, exact-XYZ first-wins set, progress, and status
handling. Split still makes outer then inner passes but never modifies CAD
sections. B collects every point once and partitions later; it moves the cap
before filtering and can overflow or allocate much more memory where the
legacy command succeeds. C keeps the destructive section replacement and
cannot restore all section-owned data with a station-only snapshot.

## Pre-mortem and Red Team

- The new station path calls `corridor.Map`. The coordinate predicate is a
  separate one-argument delegate; the contour predicate is null. A production
  collector fixture makes section lookup fail and verifies collection still
  succeeds.
- A cutoff or origin changes. Tests use asymmetric alignment geometry and
  user cutoffs, check exact-boundary exclusion, and compare old/new raw XYZ/W
  tuples and order. Classification remains on `sectionPoint.X`.
- A duplicate with different `W` selects a different record. Both paths use
  the same `HashSet<PointKey3D>` loop. Tests pin first-weight wins across
  repeated station visits.
- A one-pass optimization changes point-cap or cancellation semantics. The
  two original collection and progress stages are retained. Coordinate
  filtering runs before the cap and raw append.
- Pair output files are swapped or a failed second publish causes recollection.
  The command still passes center first and edge second to the existing pair
  publication service. Its recovery journal check remains before collection.

The independent Red Team highlighted postfiltering as the most dangerous
shortcut: it changes per-bucket overflow behavior. It also identified the
distinction between geometry extents and user classification cutoffs. The
chosen API encodes that separation and keeps the paired export service intact.

## Decision

Choose **A**. Add a station collector overload with `Func<Vector2D,bool>`
applied inside `FindPoints`. Keep the existing Section/contour overloads.
Add `RawPointsCollector.CollectAtStations` using the existing dedup/status
loop. Plan stations before collection, then run the same outer and inner
predicates in the same order. Do not touch `Corridor.Sections`.

## Consequences and verification

The actual collector fixture covers old/new tuple/order parity, exact cutoff
gaps, open slice borders, asymmetric geometry, duplicate XYZ/first `W`, and
cancel/overflow/fault statuses without section lookup. A fixture executing
the production split command verifies station order, output routing, pair
recovery, one-sided output, cancellation/failure statuses, invalid length and
unchanged section object identity. Both compile against Rail 16 and the full
.NET 3.5 suite passes. Live host station normalization, actual LAS tuple parity
and GUI lifecycle are still unverified.

## Decision Journal

**Ex-ante expectation:** a disposable Rail project with custom sections keeps
its exact section objects after any split outcome, and old/new builds emit
identical primary and edge LAS point tuples for the same source cloud. The
recovery journal still resolves an interrupted pair without recollection.

**Check trigger:** first isolated Topomatic split run using asymmetric DTM
widths, offset-boundary points, duplicate XYZ with different weights and an
injected second-file publication failure. **Revisit if:** the host normalizes
added stations or if live LAS tuples differ despite local parity tests.
