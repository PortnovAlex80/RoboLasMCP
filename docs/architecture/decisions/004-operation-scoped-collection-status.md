# 004. Operation-scoped LiDAR collection status

- **Status:** Accepted
- **Date:** 2026-09-29
- **Supersedes:** —
- **Superseded by:** —
- **Decision-maker:** autonomous-decision skill

## Context

`LasSectionPointsCollectorService.TooManyPoints` is a mutable process-wide
status. Each section resets it, and callers inspect it after collection. A
cancelled SDK callback clears its partial lists but leaves the flag false, so
some commands can mistake cancellation for a valid empty result. Two commands
can overwrite each other's flag. Plan section 4 requires a distinct cancelled,
overflow, failed, and empty outcome and no extra copies of large point lists.
ADR 001 prioritizes correctness, bounded memory, and reversible migration.

## Decision drivers

| Driver | Weight | Why it matters here |
|---|---:|---|
| Correctness and state ownership | 5 | A command must not use another operation's status. |
| Bounded memory | 5 | A section can contain millions of points. |
| Output regression risk | 5 | Point order and LAS publication behavior must be preserved. |
| Testability | 4 | Cancellation and overflow need isolated tests. |
| Boundary isolation | 4 | The SDK collector must not depend on UI workflow types. |
| Implementation cost | 3 | All active callers need a coherent migration. |
| Reversibility | 3 | A failed rollout must not affect persisted files. |

## Considered options

### A — Typed result for every section

Return an `OperationResult<CollectedSection>` from the SDK collector and pass
typed results through all outer collectors. This prevents an omitted status
argument and reuses one result vocabulary. It requires a new result wrapper
for every section or a dependency from the SDK collection layer on the
application workflow. Existing lists need not be copied. Reversal is local to
the collector APIs; per-section allocation and broader API migration are costs.

### B — Local section status, typed operation result

Return the existing `LasSectionPoints` and optional raw list with an `out
SectionCollectStatus` (`Success`, `Cancelled`, `Overflow`). Remove all overloads
that omit the status. `RawPointsCollector` and `GroundPointsCollector` return
one `OperationResult<T>` per command and all callers branch before consuming
payloads. This preserves list ownership and adds no per-section result object.
The extra `out` argument can be ignored accidentally, so exhaustive callsite
review and tests are mandatory. Reversal changes only internal APIs.

### C — Deferred exceptions from the SDK collector

After `FindPoints` returns, throw for cancellation or overflow and translate
the exception at the outer collector. This avoids status plumbing and copies,
but exception propagation through SDK traversal and `WaitProgress` is not
verified. It also conflates expected cancellation with unexpected failure in
legacy callers. Reversal is simple, but host behavior is an uncertainty.

## MCDA matrix

Scores are 1–5; totals are weighted sums.

| Driver | Weight | A | B | C |
|---|---:|---:|---:|---:|
| Correctness and state ownership | 5 | 5 | 4 | 4 |
| Bounded memory | 5 | 4 | 5 | 5 |
| Output regression risk | 5 | 3 | 4 | 3 |
| Testability | 4 | 5 | 4 | 3 |
| Boundary isolation | 4 | 4 | 5 | 5 |
| Implementation cost | 3 | 2 | 3 | 4 |
| Reversibility | 3 | 3 | 4 | 4 |
| **Weighted total** | | **111** | **122** | **116** |

The six-point lead over C is small. B is chosen because it keeps expected
status within the SDK callback boundary without relying on unverified host
exception propagation; both have the same reversibility score.

## Pre-mortem

Assume B was deployed and failed six months later:

1. A caller passed `out ignored` and published cleared partial output.
   Mitigation: remove old overloads, audit every callsite, and test command
   publication suppression on non-success.
2. An early invalid-geometry return forgot to set status. Mitigation:
   initialize `Success` before all geometry exits and test empty geometry.
3. OnePass reported OOM differently from the legacy collector. Mitigation:
   translate its exception and null/cancel result at the outer boundary.
4. An export command completed a staged LAS file after a later section failed.
   Mitigation: propagate the terminal status out of the progress callback and
   guard `Complete` and `Publish`.
5. A test with a tiny point cap passed while the real cap path differed.
   Mitigation: use the same comparison branch with a test-only injected cap,
   then run the isolated host fixture when available.

## Red Team

The strongest objection is that C# requires an `out` variable but does not
require the caller to inspect its value. Existing reduction commands already
stage earlier batches and could publish them after a later cancellation. The
response is to delete every no-status overload, return operation-level typed
results, require success before consuming points or publishing, and test these
callers. Red Team preferred B to C under those conditions because propagation
through `FindPoints` and `WaitProgress` has not been proved.

## Decision

Choose **B**. The low-level SDK collector keeps local status and existing
point-list ownership. Outer collectors translate it to `OperationResult<T>`;
commands treat `Empty`, `Cancelled`, `Overflow`, and `Failed` separately. Remove
the process-wide flag only after every production caller has migrated. This
addresses the shared-state defect without increasing large-buffer copies.

## Consequences

All active collector and command callsites must change together. SDK GUI
traversal, cancellation, and low-memory behavior still need an isolated host
check. The test suite must cover point order and first-weight preservation,
empty geometry, cancellation inside a callback, overflow, interleaved calls,
and no LAS or CAD publication after a terminal status.

## Decision Journal

**Date:** 2026-09-29. **Decision:** Local section status and one typed result
per command.

**Ex-ante expectations:** Within 30 days or the next host check, no command
reads `TooManyPoints`, cancellation publishes no LAS/CAD result, and the same
input produces identical raw point order. Within 90 days, overlapping command
attempts cannot exchange overflow outcomes.

**Check trigger:** The first isolated Topomatic regression run or a reported
cancel/overflow discrepancy. **What would change this decision:** a verified
SDK callback/WaitProgress contract showing deferred exceptions are safer, or
measured status misuse despite exhaustive callsite tests.

## References

- [Refactoring plan](../../REFACTORING_PLAN_2026-09-27.md), section 4.
- [ADR 001](001-modular-topomatic-plugin.md).
