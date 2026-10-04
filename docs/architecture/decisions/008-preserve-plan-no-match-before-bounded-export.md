# 008. Preserve Plan no-match behavior before bounded LAS export

- **Status:** Accepted
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`PlanDeletePointsUseCase` counted every point inside Plan polygons in a
parallel preflight, returned without writing a LAS if the count was zero,
then scanned the points again for export. The export batch was flushed only
after a whole LiDAR buffer. One large indexer could therefore grow the batch
to the size of a cloud. The preflight used the SDK parallel helper without
guarding worker exceptions; the export checked a transient cancellation flag
after publishing and could skip polygon cleanup.

The refactoring plan requires no regression in no-match handling, bounded
point memory, preserved polygon geometry and point attributes, explicit
publication outcomes, and eventual removal of duplicate Plan/CRS machinery.
This is a complicated choice because one-pass streaming changes disk behavior
when no point matches, while immediate common-engine extraction touches two
commands with different geometry and no-match policies.

## Decision drivers and options

Scores are 1–5. The total multiplies each score by its driver weight.

| Driver | Weight | A: guarded Plan preflight and local stream | B: shared Plan/CRS export core | C: one-pass Plan staging |
|---|---:|---:|---:|---:|
| Bounded point memory | 5 | 5 | 5 | 5 |
| Geometry and attribute confidence | 5 | 5 | 4 | 4 |
| Exact no-match behavior | 5 | 5 | 5 | 3 |
| Throughput | 4 | 4 | 4 | 3 |
| SDK read confidence | 5 | 3 | 3 | 5 |
| Removes duplicate export logic | 3 | 1 | 5 | 1 |
| Implementation cost | 3 | 4 | 2 | 5 |
| Testability | 4 | 4 | 5 | 5 |
| Reversibility | 3 | 4 | 3 | 5 |
| Disk behavior | 3 | 5 | 5 | 3 |
| **Weighted total** | | **164** | **166** | **159** |

A keeps the no-match preflight but stops at the first match, guards every
worker callback, and streams the export with one bounded batch. B creates a
shared scan/write component with command-specific geometry and publication
policies. It can reduce duplication but would require simultaneous migration
or a temporary second pathway while its semantics are tested. C writes a
staged LAS during one scan, discarding it if nothing matched. C can report a
disk error for a no-match input that currently needs no writable destination.

## Pre-mortem and Red Team

- The preflight becomes slower. Keep it parallel and stop all workers after
  the first match. The no-match case still scans all points, as before.
  Measure same-data time in Topomatic before claiming performance parity.
- A worker fault strands the SDK parallel waiter. Catch inside every worker,
  record the first fault, let all workers finish, then surface that fault on
  the caller. Cancellation is latched in `PlanPolygonScanState`.
- Polygon vertices change between passes. Capture deep copies under the
  collection lock. If the preflight found a match but the export did not,
  discard the stage and report that the LiDAR source changed.
- An oversized indexer grows the write list. Flush within the point loop
  at a threshold capped at 65,536 points.
- Cancellation after `Publish` skips cleanup, or a newly added polygon is
  erased. Treat publication as the commit point. Compare the processed
  snapshot with the current collection and its selected path under the
  collection lock before clearing. Report LAS-saved/polygons-retained if
  they differ.

The Red Team rejected a serial full pre-count because two full serial
polygon scans could be a large performance regression. It also identified
the shallow copy returned by `GetAll()` and the risk of clearing polygons
added while export runs. A was changed to first-match parallel preflight,
deep snapshot, and conditional clear. The top two scores are within the
matrix uncertainty; A wins on reversibility and isolating behavior changes
to Plan. Extracting a shared bounded export core remains part of the broader
workflow migration after both command contracts are established.

## Decision

Choose **A**, with the Red Team changes. Keep the source order, coordinate
transform, weight normalization, and current no-match policy. Count actual
deletions during export with `long` counters. Publish only after successful
finalization and a positive actual deletion count. Clear only the polygon
snapshot that was processed; retain changed polygons and report a partial
outcome after LAS publication.

## Consequences and verification

Point output memory is one batch of at most 65,536 `Vector4D` records plus
the writer's fixed buffers. The indexer list remains proportional to the
number of indexers. The selected snapshot is scoped to the legacy collection
path and in-process contents. The old v1 collection still lacks a cross-process
revision check; the v2 repository migration remains necessary to prevent
an external process from changing the file between snapshot and clear.
Borrowed SDK LiDAR arrays also remain subject to a live-host lifetime check.

The production command and snapshot collection compile against Rail 16.
.NET 3.5 command tests cover first/last/no match, a 10,001-point indexer,
record order, intensity, preflight and export faults/cancellation, source
changes between passes, and partial outcomes after publication. Real writer
integration checks LAS 1.2 Point Format 1 records and unchanged destination
and `.ldr` bytes on canceled or failed operations.

On the same synthetic 250,000-point fixture with an 8,192-point configured
batch, three old-command runs used 31.54–31.56 MB additional private memory,
51.78–52.15 MB peak working set, and a single 214,285-point write batch.
Three new runs used 28.26–28.27 MB, 49.36–49.39 MB peak working set, and
at most 8,192 points per write. Both kept 214,285 records. Old elapsed time
was 82–83 ms; new was 78–91 ms. The fixture executes SDK parallel work
sequentially and its writer does no disk I/O, so host throughput parity
remains unverified.

## Decision Journal

**Ex-ante expectations:** On a representative host cloud, no-match operations
open no output writer; memory used for surviving records stays independent
of point count; success is reported only after LAS publication and clearing
the unchanged processed collection. Matching inputs should spend less time
in preflight than the former full count.

**Check trigger:** First isolated Topomatic Plan deletion run with a large
cloud, or a report of changed no-match behavior, throughput, or polygon
contents. **Revisit if:** guarded SDK parallel work still stalls, or a proven
common export core can preserve both Plan and CRS policies with less code.
