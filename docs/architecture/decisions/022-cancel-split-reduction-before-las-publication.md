# 022. Cancel split reduction before LAS publication

- **Status:** Accepted
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`split_las_by_offset` checks cancellation after both raw collection dialogs,
but not after its two reduction dialogs. Cancelling during center or edge
sampling could still call `SaveTwoExternalProgress` and publish the LAS pair.
`SamplingHelper` also had no cancellation input, so a large reservoir continued
to scan after cancellation.

The no-cancellation path must retain the existing reservoir membership, slot
order, progress values and unseeded `Random` behavior. The final pair writer
and recovery journal are outside this change.

## Options

Scores are estimates on a 1–5 scale; higher is better.

| Driver | Weight | A: post-dialog check | B: cancellable sample and sticky state | C: leave unchanged |
|---|---:|---:|---:|---:|
| Prevent publication after observed cancel | 5 | 4 | 5 | 1 |
| Stop a large reduction promptly | 4 | 1 | 5 | 1 |
| Preserve normal numeric output | 5 | 5 | 5 | 5 |
| Implementation simplicity | 2 | 5 | 3 | 5 |
| Testability | 3 | 4 | 5 | 1 |
| **Weighted total** | | **71** | **91** | **47** |

Choose B. The old sampler overloads delegate to an internal five-argument
overload with a cancellation predicate. The split command catches cancellation
inside each progress callback, remembers it after the modal closes and stops
before the next reduction or save.

## Pre-mortem and independent Red Team

- Adding a four-argument cancellation overload beside the existing `Random`
  overload would make calls with `null` ambiguous. The new reservoir overload
  takes five arguments.
- The SDK progress window may swallow callback exceptions or clear its
  cancellation property on close. The command catches `OperationCanceledException`
  inside the callback and keeps a local flag; other callback failures are also
  captured and reported after the dialog.
- An empty, 100%, or rounded-zero reduction might return without checking
  cancellation. Every fast path checks before and after progress notification.
- A callback may signal cancellation at the final progress event. The sampler
  checks after that callback and before returning the result.
- The extra cancellation checks must not draw from `Random` or reorder points.
  Scripted seeded tests compare exact draws, bounds, membership and progress.
- A host cancellation arriving after the last callback check but cleared before
  modal return is still unverified. Only an isolated GUI run can characterize
  that narrow scheduling window.

## Decision Journal

**Ex-ante expectation:** cancellation observed during either reduction yields
no accepted sample and no LAS save; a run without cancellation produces the
same ordered points and random draw sequence as before.

**Check trigger:** changes to Topomatic's progress dialog, sampler loop, or
the split command's save ordering; first isolated GUI cancellation run.

## Follow-up: streamed reduction commands

The same cancellable sampler entry is now used by
`reduce_las_async_to_percent` and `reduce_with_ground_red_sector` inside their
single progress callbacks. Each command latches cancellation when the SDK
collector, sampler or writer observes it. A cancelled sample returns from the
callback before `WritePoints`, `Complete` or `Publish`, even if the modal
resets its flag on close. Normal batch order and counts are unchanged. A
published LAS remains reported as published if cancellation arrives after
publication. The command fixture passes 124 checks, including cancellation
on first and second batches with modal reset. GUI timing remains a host check.
