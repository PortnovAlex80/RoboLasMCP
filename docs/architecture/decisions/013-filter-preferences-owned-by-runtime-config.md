# 013. Own filter preferences in RuntimeConfig

- **Status:** Accepted; live host execution remains to be verified
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and decision drivers

The active filter chain already receives an immutable 23-value
`FilterOperationSnapshot`. Its adapter formerly read two values from
`RuntimeConfig` and 21 mutable static fields in Domain filters. The UI also
wrote smoothing to two filters. An operation captured during settings loading
could observe a mixture, and the static fields violated the computation
boundary. Persisted storage has five historical keys and must retain them.

The drivers are numerical parity, zero new global owners, a coherent capture,
testability, implementation cost and reversibility.

## Considered options

Scores are weighted engineering estimates on a 1–5 scale.

| Driver | Weight | A: existing RuntimeConfig | B: immutable published reference | C: separate preference store |
|---|---:|---:|---:|---:|
| Correctness | 5 | 5 | 5 | 5 |
| Regression risk | 5 | 5 | 4 | 5 |
| Boundary isolation | 4 | 5 | 5 | 3 |
| Atomic capture | 4 | 5 | 5 | 4 |
| Implementation cost | 3 | 4 | 2 | 5 |
| Reversibility | 3 | 4 | 4 | 4 |
| Testability | 3 | 4 | 5 | 4 |
| **Weighted total** | | **126** | **118** | **117** |

A extends the existing lock and stores the 20 advanced preferences there;
`CSplineSmooth` remains the sole smooth value. B publishes a whole immutable
preference object after every edit, at the cost of another mapping layer and
more allocation. C adds another globally mutable object, contrary to the
refactor plan's state-ownership rule.

## Pre-mortem and Red Team

- A positional mapping error changes one of 23 algorithm inputs. The
  production-DLL adapter test writes distinct sentinels to every preference
  and verifies every captured field; the full chain retains its golden
  signatures.
- A settings load changes the algorithm choice before smoothing arrives.
  `ApplyStoredPreferences` publishes the five persisted values under one
  lock. A concurrent capture test rejects mixed generations.
- The UI smooth value diverges from spline smoothing. The panel and settings
  loader write only `RuntimeConfig.CSplineSmooth`; the snapshot reads it
  under the same lock.
- A hidden caller uses an old global-reading overload. Repository-wide search
  found no production caller, and the overloads are removed. Compilation of
  production and .NET 3.5 fixtures checks static call sites.

The independent Red Team argued that proxy properties on Domain filters would
retain a hidden dependency and that setting two smoothing fields sequentially
would still allow a mixed capture. Both were removed. It also favored B if
multiple writers must publish arbitrary complete advanced-setting batches;
current writes are individual preferences and the only persisted batch has an
atomic method. The two leading scores are close, so lower complexity and
reversibility decide for A.

## Decision and consequences

Use `RuntimeConfig` as the sole preference owner. Capture the complete
`FilterOperationSnapshot` under its existing lock before calculation.
Filters accept that snapshot and never read mutable preferences. Keep the
historical persisted keys and defaults. Delete the old mutable filter fields
and global-reading overloads.

The numerical filter chain baseline passes 131 checks. The full .NET 3.5
suite passes. The production DLL builds against the copied Rail 16 SDK, and
its reflection-backed adapter suite passes 1026 checks including concurrent
preference loading. Architecture findings fall from 37 to 16; the remaining
findings are legacy smoothing filters outside the active chain. These checks
do not establish behavior inside the live Topomatic GUI.

## Decision Journal

**Ex-ante expectation:** repeated runs with the same snapshot retain the
same numerical signatures; concurrent preference loading never gives a
mixed filter snapshot; no production filter accesses `RuntimeConfig` or
mutable filter parameters.

**Check trigger:** future UI/settings changes, a new filter parameter, and
the next isolated Topomatic host acceptance run.
