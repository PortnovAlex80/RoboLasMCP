# 028. Bound parallel 3D phases on .NET Framework 3.5

- **Status:** Accepted; large-cloud throughput still requires host measurement
- **Date:** 2026-09-30
- **Decision-maker:** primary agent, revisiting ADR 012

## Context

ADR 012 moved the Topomatic scheduler behind an adapter but kept nested
`Parallel.ForEach` calls in the 3D ground filter. The adapter was synchronous
on the small success-path probe. A separate Rail 16 SDK probe now throws from
one worker in a short-lived, isolated .NET 3.5 process. The worker exception
is unhandled on the ThreadPool and terminates the process instead of reaching
the caller. This makes the old adapter unsuitable for a numerical filter whose
worker can fail (for example, through allocation or an unexpected input).

Two other production uses of the SDK helper catch failures inside every
worker and report them after the helper returns. The public legacy
`LidarBuffer(LiDAR, ...)` constructor also starts one thread per input buffer
without forwarding worker exceptions, but this repository has no production
call to that constructor. Its behavior is outside this command change.

## Options and decision

Scores are engineering estimates on a 1-5 scale. Safety now includes the
observed worker-failure behavior, not only successful output parity.

| Driver | Weight | Keep SDK nested loops | Bounded flat lines | Serial phases |
|---|---:|---:|---:|---:|
| Output parity | 5 | 5 | 5 | 5 |
| Worker failure safety | 5 | 1 | 5 | 5 |
| Thin-cloud throughput | 4 | 4 | 4 | 1 |
| .NET 3.5 compatibility | 4 | 5 | 5 | 5 |
| Change size and reversibility | 3 | 5 | 4 | 5 |
| **Weighted total** | | **81** | **98** | **89** |

Choose bounded flat lines. `TopomaticIndexScheduler` uses the existing
`ParallelWorkRunner`, which caps workers at eight, joins them on failure and
returns the original cause as the inner exception. Classification owns one X
column per work item. X demotion owns one `(Z,Y)` line and Y demotion owns one
`(Z,X)` line. These lines write disjoint cells within each phase. The three
synchronous calls preserve the classification/X/Y barriers. Flattening the
line coordinates retains parallel work when a cloud has only one Z layer.
The final output pass remains serial and preserves source order.

## Pre-mortem and verification

- A nested call could return early or crash the host. The filter fixture
  asserts exactly three scheduler calls with no nesting; the production
  adapter's worker-failure test checks exception forwarding.
- Reordered lines could change demotion membership. Fixed hand, seeded,
  demotion and thin-cloud fixtures compare serial, reverse, two-worker and
  production scheduler outputs including original point order.
- A lane calculation could overflow. The two flattened line counts use
  checked integer arithmetic before scheduling.
- Thread creation per phase can cost more than the SDK ThreadPool helper on
  small batches. The adapter runs a one-item phase on the caller, and the
  large-cloud throughput difference remains an explicit host acceptance gate.

The .NET 3.5 characterization suite and architecture checks pass. Isolated
Release builds against Rail 16 and Road 16 pass the release verifier: the
plugin targets CLR v2.0.50727 and has no framework references newer than
.NET 3.5. The isolated SDK failure probe establishes the failure mode without
starting the Topomatic GUI or opening a user project.

## Decision Journal

**Expectation:** identical kept XYZ/W tuples and source order for the same
batch, with bounded workers, no nested scheduling and a surfaced worker
failure. **Revisit if:** a representative isolated host run finds a material
throughput or memory regression, or if the host SDK exposes a documented safe
worker-failure contract. The broader LAS buffer and host TIN checks remain
separate refactoring gates.
