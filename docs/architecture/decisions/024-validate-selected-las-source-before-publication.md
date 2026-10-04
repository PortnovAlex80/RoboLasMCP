# 024. Validate the selected LAS source before publication

- **Status:** Accepted for the three LAS-only commands; host identity checks remain open
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`split_las_by_offset`, `reduce_las_async_to_percent` and
`reduce_with_ground_red_sector` select an alignment and collect LiDAR buffers
before modal input. A project, document, alignment or buffer can then change
while the command is waiting or processing. The two reduce commands currently
publish a prepared LAS inside the progress callback. A saved file could thus
be presented as output from the originally selected source even after that
source changes.

The selected alignment is returned by `PickOneObjectAtScreen`; it need not be
the active alignment from `ActiveAlignmentReciver`. The v1 polygon context
also requires a named first-buffer directory, which LAS export does not.
The existing prepared-file writer validates the destination fingerprint and
the pair publisher journals a two-file commit. Those output safeguards do not
validate the input source.

## Decision drivers and options

Scores are engineering estimates from 1 to 5; larger is better. The weights
prioritize correctness and compatibility with a selected but nonactive
alignment, followed by testability and limited SDK assumptions.

| Driver | Weight | A: extend legacy polygon context | B: new context requiring active receiver | C: LAS context for selected alignment |
|---|---:|---:|---:|---:|
| Reject stale source before commit | 5 | 4 | 4 | 5 |
| Preserve selected-alignment behavior | 5 | 4 | 2 | 5 |
| Offline testability | 4 | 4 | 4 | 5 |
| Limited SDK assumptions | 5 | 4 | 2 | 4 |
| Implementation cost | 3 | 4 | 3 | 3 |
| Reversibility | 3 | 4 | 4 | 4 |
| Alignment with the operation boundary | 4 | 3 | 5 | 5 |
| **Weighted total** | | **112** | **97** | **131** |

A reuses the existing in-process matcher but couples LAS export to the legacy
first-buffer polygon directory and requires new selected-alignment semantics
inside a v1 storage class. B introduces a clean type but would reject a valid
selected alignment whenever it is not also active. C gives the three exports
their own immutable operation context and keeps their selection rule.

## Decision

Choose C. Capture the selected alignment, its model, the host project and
document, source view, station-planning length and offsets, and the ordered
LiDAR buffer/indexer structure before further dialogs. Include buffer paths,
point and weight container identity/count, and indexer transform values. A
check after each modal stage and immediately before publication rejects a
source whose observable identity or metadata changed. A buffer provider is
read once per enumeration so the capture is internally consistent.

The reduce commands complete a staged LAS inside the progress callback but
publish it on the command thread after the dialog closes, the borrowed source
is released, cancellation is latched, and the source check passes. The split
command validates again after preparing both LAS files, immediately before
the existing pair publisher runs. Existing destination fingerprint checks,
pair journal recovery, output format, command IDs, point order and normal
random sampling remain in place.

## Pre-mortem and independent challenge

- A same-reference LiDAR array changes its point values without changing its
  object or count. The context cannot detect this without a versioned SDK
  read lease or an expensive full copy. The plugin command gate limits its own
  commands, while external writers remain an open host constraint.
- The selected alignment geometry changes in place while retaining its
  length and offsets. Checking those fields rejects common changes, but is
  not a full geometry version. Test source mutation in the isolated host and
  seek a supported SDK revision or lock before claiming arbitrary concurrent
  safety.
- SDK buffer wrappers are re-created on each `CollectBuffers` call. A strict
  reference check would reject a stable source. Prefer a false rejection to
  publishing uncertain output until the copied Rail 16 host proves wrapper
  stability; adjust the fingerprint only with host evidence.
- The source changes between the final check and file replacement. There is
  no proven host-wide read transaction, so the check narrows this interval
  without making input and output an atomic transaction.
- A progress callback outlives the modal or a pair publication fails halfway.
  Focused tests must cover callback completion, stage disposal and the
  existing pair journal/recovery behavior. Actual UI scheduling and Undo/TIN
  are separate host checks.

The independent Red Team rejected B because selection does not activate the
alignment and identified same-reference mutations as C's strongest weakness.
The decision keeps C with metadata checks and an explicit residual SDK gate;
it does not describe the source as an immutable snapshot.

## Consequences and decision journal

This change adds a narrow context and a visible commit boundary for the three
exports. Rechecking buffers costs one SDK enumeration at stage boundaries,
not a copy of the point cloud. A stale source leaves prepared LAS files
unpublished and disposes their temporary files. It cannot guarantee safety
against arbitrary external in-place mutation of borrowed SDK arrays.

**Ex-ante expectation:** switching the project, document, selected alignment
or captured LiDAR topology during a dialog or progress stage will leave the
existing final LAS unchanged; an unchanged selected but nonactive alignment
will still export. Pair failure recovery will retain its prior semantics.

**Check trigger:** focused command tests, first run on the copied Rail 16
project in an isolated Windows profile, and any change to SDK buffer wrapper
or alignment geometry lifetime.
