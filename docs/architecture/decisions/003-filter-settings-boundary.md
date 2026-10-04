# 003 — Capture filter settings at the operation boundary

Status: accepted for the next PR-04 slice, 2026-09-29.

## Context

The section workflow already passes an immutable `FilterOperationSnapshot`
through its active calculation path. Its capture still happens inside
`GroundPointsCollector` via `LasFilterService` and `FilterAggregator`, leaving
global-reading overloads in computation modules. The boundary check currently
reports 48 violations. The plan requires computation to receive operation
parameters explicitly while preserving established filter results.

## Decision

Move the existing 23-field capture, in the same read order, to an infrastructure
adapter. The section command captures once after cancellable inputs and just
before filtered collection, on the CAD UI thread. Both collectors require a
non-null snapshot and pass that exact object through every section and worker.
Remove unused global-reading overloads from the active computation chain after
callsite audit and production-chain characterization. Keep
`RuntimeConfig.CaptureFilterSettings` as the paired source of the two values it
already captures together. The raw LAS export path does not need a filter
snapshot.

## Options

Scores are 1–5, weighted by correctness, output regression risk, architectural
isolation, cost, reversibility, and testability. Three independent read-only
proposals informed the scoring.

| Criterion | Weight | A: adapter, retain legacy overloads | B: adapter, explicit-only chain | C: centralized atomic settings store |
|---|---:|---:|---:|---:|
| Correctness | 5 | 3 | 4 | 5 |
| Regression preservation | 5 | 5 | 4 | 2 |
| Isolation | 4 | 2 | 5 | 5 |
| Implementation cost | 3 | 5 | 3 | 1 |
| Reversibility | 3 | 5 | 4 | 2 |
| Testability | 3 | 3 | 4 | 4 |
| Weighted score | | **87** | **93** | **76** |

B and A are close. A is slightly easier to reverse but leaves the exact
global-reading entry points that the plan requires us to remove, so it cannot
finish this boundary. B changes no persisted data and can restore thin wrappers
if a hidden caller is found. C addresses atomic preference updates, but changes
many UI setters and has substantially higher output-regression risk; it may be
revisited separately if concurrent writes are observed.

## Pre-mortem and Red Team

Likely failures are a hidden overload caller, a reordered positional snapshot
field, capture before a long dialog or SDK operation, one worker receiving a
fresh snapshot, and a test suite that passes with a stub while the real chain
changes. Before deleting overloads, scan all source and assembly visibility;
add a real production-chain fixture for both spline branches and break modes;
compare all snapshot fields; pass one captured instance to every worker; and
run normal/diagnostic builds plus the host test. Independent Red Team review
found no fatal flaw under those conditions.

The 21 filter static preferences outside `RuntimeConfig` are read sequentially,
not atomically. Capture on the UI thread avoids ordinary UI edits during that
short interval, but no guarantee is made against other threads or plugins.
`EnableBreakDetection` also remains a mutable Domain field until its source is
moved. These limitations remain explicit acceptance items, not claimed fixes.

## Decision journal

2026-09-29: Classified as a complicated architecture fork. A conservative
compatibility option, an explicit-only boundary, and an atomic settings store
were evaluated in parallel. B was selected for the next measured slice after
Red Team review. Implementation starts with production-chain characterization;
the decision does not authorize removing overloads before that test passes.
