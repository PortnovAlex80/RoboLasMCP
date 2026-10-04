# 002 — Explicit LAS completion and publication

Status: accepted for PR-07, 2026-09-29.

## Context

Both existing LAS writers finalize inside `Dispose`. The batch writer opens the final path before conversion; cancellation can leave raw doubles under an unfinished LAS header. The buffered writer opens the final path during disposal. The plan requires cancellation and failure to preserve an existing final file, and two outputs to report partial publication explicitly.

## Decision

Keep both existing encoding paths for this migration. Each writer prepares a same-directory temporary LAS file through an explicit `Complete` call. `Dispose` releases resources and removes an unfinished stage. A prepared file validates its header, length, point count, and target fingerprint before `Publish` replaces or creates the final path. A failed publish leaves the stage available for a specific retry. The service prepares both files before publishing either and records the pair's stages before the first publication. A valid zero-point LAS is allowed, preserving delete-all output behavior while fixing its old invalid bounds.

This preserves the normal point-record bytes and existing peak-memory class of each writer. A later change may unify encoders after a separate memory and byte comparison.

## Options and scoring

Scores use 1–5; weighted sum is shown in the last row. Criteria follow the plan's emphasis on correctness, reference-output preservation, bounded memory in batch commands, reversible rollout, and testability.

| Criterion | Weight | A: explicit completion in both writers | B: publication wrapper around old stream disposal | C: unified streaming writer |
|---|---:|---:|---:|---:|
| Correctness and failure semantics | 5 | 4 | 5 | 5 |
| Output regression risk | 5 | 5 | 4 | 2 |
| Batch memory bound | 4 | 5 | 4 | 5 |
| Implementation cost | 3 | 4 | 2 | 2 |
| Reversibility | 3 | 4 | 3 | 3 |
| Testability | 3 | 4 | 4 | 5 |
| Weighted score | | **101** | **88** | **85** |

## Pre-mortem and review

The likely failure modes are an unmigrated caller relying on disposal, an incomplete conversion mistaken for success, invalid bounds for one-point or descending inputs, replacement of an externally changed final, and loss of the second stage after a partial pair publication. The implementation therefore migrates every direct writer caller, rejects cancellation before handing out a prepared file, validates converted data, checks the target fingerprint under an output lock, and preserves the second stage with a recovery record.

Independent Red Team review found no fatal flaw in A. It identified strict stage ownership, short-read handling, count and coordinate overflow, same-directory replacement assumptions, and crash recovery as required conditions. The batch writer must retain bounded chunk memory; the stream writer retains its existing O(N) list until a separate measured migration.

## Consequences and limits

Two final-path publications are not an atomic transaction. A pair recovery record identifies a published first output and an uncommitted second output; recovery must verify hashes and publish only the missing stage. Same-directory replacement behavior on network shares remains a host-specific verification item. The normal and diagnostic builds, byte characterization, cancellation and fault tests, and an isolated Topomatic host run are the acceptance gates.

## Decision journal

2026-09-29: Classified as a complicated design fork. Three independent proposals were compared. Option A was selected because it retains existing bytes and batch memory behavior while making completion observable. Red Team findings were incorporated as implementation requirements.
