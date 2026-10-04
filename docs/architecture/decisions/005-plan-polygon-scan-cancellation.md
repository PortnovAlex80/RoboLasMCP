# 005. Plan polygon scan cancellation

- **Status:** Accepted
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

Both Plan surface commands scan LiDAR twice. Their previous workers checked
`WaitProgress.CancellationPending` only before each buffer. Cancellation in a
long indexer could leave a partial count or point collection that the command
treated as complete and inserted into CAD. The installed Topomatic parallel
implementation can also leave its waiter unsignalled if a worker throws.

The refactoring plan and ADR 001 prioritize correctness, stable geometry and
point order, bounded memory, and reversible changes. The SDK progress dialog's
flag lifetime and worker completion need a GUI check.

## Decision drivers and options

Scores use 1–5; totals are weighted sums. The fork is **complicated**: the
existing numeric path can be inspected, but SDK callback behavior is uncertain.

| Driver | Weight | A: local latch and guarded workers | B: shared collector and typed result | C: deterministic buffer slots |
|---|---:|---:|---:|---:|
| Cancellation and fault correctness | 5 | 4 | 5 | 5 |
| Successful output compatibility | 5 | 5 | 3 | 2 |
| Bounded memory | 5 | 5 | 4 | 3 |
| Testability | 4 | 4 | 5 | 4 |
| Boundary isolation | 4 | 3 | 5 | 4 |
| Implementation cost | 3 | 5 | 3 | 2 |
| Reversibility | 3 | 5 | 4 | 2 |
| **Total** | | **128** | **121** | **94** |

A leaves each command's accumulation and lock merge in place. Its drawback is
that the command must check the operation state after both scans. B gives one
collector contract but moving the loops risks changing equal-Z selection and
polynomial input order. C joins workers and defines source order, but that
intentionally changes the current completion-order merge and can alter output.

## Pre-mortem and Red Team

- Cancellation arrives during the final 1023 points: sample again after each
  indexer, at worker exit, and inside the progress callback after `ForEach`.
- The SDK resets its cancellation flag on dialog close: keep a latched bit per
  command, and inspect it after each scan.
- A worker throws while reading a buffer: catch inside every worker, record the
  first exception, allow parallel joining, and report the error after the dialog.
- A command forgets to check the latch: both call sites after Count and Collect
  are checked, and cancellation scenarios are exercised in .NET 3.5 tests.
- A target surface changes during the scan: the captured destination and SDK
  identity contract still require an isolated host check.

The Red Team identified the unsignalled waiter risk as the strongest objection
to A. A now uses `PlanPolygonScanState.Execute`, which catches worker errors
before they can escape the SDK parallel callback. B would need the same guard.
C avoids this particular SDK parallel path but changes successful output.

## Decision

Choose **A with guarded workers**. Each command keeps its existing buffer loop,
min-Z comparison, and merge order. A scan polls cancellation at entry, between
indexers, every 1024 points, at worker exit, and before the progress callback
returns. It keeps cancellation and first failure for the whole command. The
command stops after either scan on cancellation or failure, before detection,
fitting, and surface insertion. Once insertion starts, it is one noncancellable
apply operation handled by `FastSurfaceBuilder`.

## Consequences

No extra full point-list copy or storage format change is introduced. A click
after the final callback sample remains an SDK timing boundary; host execution
must establish when the dialog closes relative to the callback. The existing
parallel merge order was already scheduling-dependent, so exact cross-run
ordering is not promised; this change does not add a new ordering rule.

## Decision Journal

**Ex-ante expectations:** At the next isolated Topomatic run, cancelling
either scan leaves the target surface untouched; worker read failure returns
without a hung progress dialog; successful geometry remains within the
production baseline. No Plan surface success message follows a cancelled scan.

**Check trigger:** First isolated GUI regression run or a reported Plan surface
cancel/failure discrepancy. **Revisit if:** the SDK invokes the progress
callback asynchronously without joining workers, or a measured cancellation
window remains after the final callback sample.
