# 007. Stream CRS deletion in source order

- **Status:** Accepted
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`CrsDeletePointsUseCase` accumulated one list of surviving points for every
LiDAR indexer, then appended each entire list to a write batch. A single large
indexer could therefore retain the full cloud, and the batch could exceed the
configured threshold. The Topomatic parallel helper also lacks an exception
safe worker completion signal. A worker fault could strand its waiter.
After publication, a late cancellation could leave the new LAS in place while
skipping polygon cleanup.

The refactoring plan prioritizes no false success, bounded memory, preservation
of geometry and attributes, and explicit limits for unverified SDK behavior.
This is a complicated choice: three implementations are plausible, and output
order and throughput may change.

## Decision drivers and options

Scores are 1–5; totals multiply each score by the driver weight.

| Driver | Weight | A: disk spools and completion queue | B: parallel bounded windows | C: serial batches |
|---|---:|---:|---:|---:|
| Bounded point memory | 5 | 5 | 5 | 5 |
| Geometry and attribute confidence | 5 | 4 | 4 | 5 |
| Output order compatibility | 4 | 4 | 3 | 3 |
| SDK thread safety confidence | 5 | 2 | 2 | 5 |
| Throughput | 5 | 3 | 4 | 2 |
| Implementation cost | 3 | 1 | 2 | 5 |
| Disk behavior | 3 | 1 | 4 | 5 |
| Reversibility | 3 | 2 | 3 | 5 |
| Testability | 4 | 3 | 4 | 5 |
| **Weighted total** | | **110** | **130** | **162** |

A writes each indexer's kept points to a private spool and consumes completed
spools in a bounded queue. It approximates the old completion order, but adds
temporary disk I/O and a more complex cleanup protocol. B captures indexer
descriptors and processes bounded windows in parallel. It avoids spool I/O,
but assumes borrowed `GetBuffer()` arrays remain valid and safe for concurrent
reads. C scans on the progress callback thread and writes as soon as the batch
fills. It is easiest to verify, but may be slower on large clouds.

## Pre-mortem and Red Team

- A large cloud becomes slower because polygon checks are serial. The SDK
  fixture establishes correctness, not host throughput. Run a same-data host
  benchmark before claiming performance parity. If the measured regression
  matters, revisit bounded windows after proving array lifetime and thread
  safety in Topomatic.
- A change from old nondeterministic indexer completion order breaks an
  order-sensitive consumer. Keep source order stable in the new implementation
  and test every record; document that global record order may differ from old
  output. Geometry and intensity must not change.
- One oversized indexer or an `AddRange` expands the batch. Append one point
  at a time, flush at the threshold, and cap the threshold at 65,536 points.
- Cancellation, a writer fault, or an empty scan publishes an incomplete or
  empty destination. Check before `Complete` and `Publish`; let staging
  disposal clean unpublished data. An all-deleted cloud still validly produces
  a zero-point LAS.
- Cancellation after `Publish` leaves stale polygons. Treat `Publish` as
  the commit boundary and perform cleanup even if progress reports a late
  cancellation or throws after the callback.

The Red Team objected to B's unproven ownership and concurrent read of SDK
arrays. The 1-point provisional difference between B and C was below the
uncertainty of that premise; after scoring thread safety explicitly, C leads.
The Red Team also identified the stale comment claiming RGB/Point Format 3.
The production writer actually emits LAS 1.2 Point Format 1, so that comment
was corrected.

## Decision

Choose **C** now. Retain existing section geometry and point membership math,
but scan indexers in source order and pass at most one bounded batch to
`LasBatchStreamWriter`. Use the writer's staging and atomic publication
protocol. No polygon cleanup occurs before publication; no late cancellation
skips cleanup after it.

## Consequences and verification

The command no longer retains all surviving points. Its additional point
storage is at most 65,536 `Vector4D` records plus the writer's fixed
conversion buffers; the indexer reference list remains proportional to the
number of indexers. The LAS record order becomes deterministic source order,
where the old inter-indexer order depended on worker completion. A measured
host throughput comparison and SDK array lifetime probe remain open.

The production command compiled against the installed Rail 16 SDK. Its
.NET 3.5 command fixture covers a 10,001-point single indexer, exact source
record order, normalization, cancellation and faults before publication,
empty and all-deleted inputs, and cleanup after late cancellation. A second
fixture runs the command with the actual `LasBatchStreamWriter` and
`PreparedLasFile`, checking LAS header and records, unchanged old destination
on scan abort, and unchanged `.ldr` descriptor.

On the same synthetic 250,000-point fixture, comparing the committed old
command with the new command in separate .NET processes and the same
instrumented writer stub, three old runs used 45.75 MB additional private
memory and 66.38–66.72 MB peak working set; three new runs used
28.25–28.27 MB and 49.48–49.49 MB. The old writer call received 214,285
points at once; the new maximum was 8,192, with the same 214,285 survivors.
Elapsed times were 98–148 ms old and 70–84 ms new. The stub schedules
parallel work sequentially and performs no disk I/O, so this does not
establish a Topomatic throughput comparison.

## Decision Journal

**Ex-ante expectations:** At the next isolated Topomatic large-cloud run,
peak command-owned kept-point memory remains independent of point count;
source-order LAS records have the same coordinates and attributes as the
corresponding input survivors; no canceled or failed pre-publication run
changes the destination or clears polygons.

**Check trigger:** First isolated host CRS export on a representative large
cloud, or any report of changed record order/performance. **Revisit if:** the
serial scan exceeds the agreed host time threshold and concurrent SDK reads
have been proven safe.
