# 012. Inject the host scheduler into the 3D ground filter

- **Status:** Superseded by ADR 028 on 2026-09-30
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and decision drivers

`GraphGround3DFilter` contains numerical grid, classification and demotion
logic, but directly invokes `Topomatic.FoundationClasses.Parallel.ForEach` in
three stages, including two nested loops. The sole production caller is
`reduce_with_ground_red_sector`. Its four numerical parameters are already
captured once per operation. The architecture checker forbids this scheduler
dependency in Domain while allowing SDK vector geometry.

Correctness and performance on large clouds matter as much as the boundary.
The command must retain the old classification order, phase barriers, nested
parallelism and source-order output until an isolated host benchmark can prove
a scheduler change is safe.

## Considered options

Scores are weighted engineering estimates on a 1–5 scale.

| Driver | Weight | A: inject same host scheduler | B: bounded .NET runner and flat lines | C: staged pure kernel |
|---|---:|---:|---:|---:|
| Output correctness | 5 | 5 | 4 | 3 |
| Throughput parity | 5 | 5 | 3 | 4 |
| Dependency isolation | 4 | 5 | 5 | 5 |
| Testability | 3 | 4 | 5 | 5 |
| Implementation cost | 4 | 4 | 4 | 1 |
| Reversibility | 4 | 5 | 4 | 2 |
| **Weighted total** | | **118** | **102** | **82** |

A adds a synchronous index scheduler delegate at the filter boundary. The
production command passes a narrow Infrastructure adapter that calls the same
Topomatic `Parallel.ForEach` method. The existing nested loops and their phase
barriers stay in place. The legacy internal overloads use a sequential
delegate, matching how the previous isolated fixture executed them.

B would use the existing bounded .NET 3.5 worker runner and flatten each pair
of coordinates into one work item. This removes nested workers, but changes
scheduling, exception and cancellation behavior before live measurements. C
would separate grid preparation, each classification/demotion kernel and final
collection into multiple objects. It offers a stronger boundary at a larger
algorithm rewrite cost.

## Pre-mortem and Red Team

- The production command accidentally uses the sequential overload. Its
  production-call fixture checks that each batch receives the host adapter.
- An injected scheduler returns before work completes. The contract requires
  synchronous completion; tests compare serial, reverse and bounded parallel
  execution on fixed point sets, including both demotion directions.
- Nested worker behavior differs in the live host. The adapter calls the
  original SDK helper with the same ranges and nesting; a live host timing and
  fault probe is still necessary.
- An exception is hidden by test stubs. Normal and diagnostic Rail 16 builds
  establish the real method signature, but host exception behavior remains a
  separate acceptance gate.

The independent Red Team emphasized that a serial fixture alone cannot prove
host parallel safety and that `Vector4D` remains an SDK geometry dependency.
Those limits are explicit. B is preferable only after evidence justifies a
scheduler change; C is too broad for this boundary correction.

## Decision and consequences

Choose A. Inject `Action<int[], Action<int>>` into the numerical filter and
move the Topomatic call to `Infrastructure/TopomaticIndexScheduler`. The sole
production command passes that adapter explicitly. Do not change grid math,
classification, demotion, progress or output collection. The architecture
checker should fall from 42 to 41 violations; the remaining mutable global
defaults are separate work.

The .NET 3.5 filter fixture passes 166 assertions, including source-order
parity under sequential, reverse and bounded concurrent traversal. The
production reduction-command fixture passes 98 checks and observes the host
scheduler delegate on both batches. A read-only probe against the copied Rail
16 FoundationClasses DLL confirms that nested `ForEach` calls finish before
their caller returns for a small index set. This does not exercise the GUI,
large clouds or worker exceptions. Normal and diagnostic Rail 16 builds pass.

## Decision Journal

**Ex-ante expectation:** output XYZ/W tuples and order are identical under
serial, reverse and concurrent scheduling on the same options; production
continues to use the host scheduler with the same nested phase structure. A
representative host run should show no material regression in time or memory.

**Check trigger:** an isolated Topomatic run on the reduction fixture with a
large cloud, including cancellation and worker-fault injection. **Revisit if:**
the host scheduler is not synchronous, the nested loops hang or output parity
fails, or measured throughput changes materially.
