# 027. Stage generated sections after calculation

- **Status:** Accepted for the generated-section command migration
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

The one-metre and custom-step commands currently call `SectionList.Clear/Add`
before LiDAR collection. Cancellation or a filter error therefore discards
the user's former sections. ADR 021 supplied `CollectAtStations` on the same
three-stage filter path, but left the commands unchanged pending host evidence.

Rail 16 on a disposable project now confirms that a project-owned
`SectionList` transaction restores all 2,925 original section objects and
their checked metadata on Rollback and on Commit → Undo → Redo → Undo. Its
transaction manager is the same object used by the selected surface.
However, raw `Surface.Points.Add` does not register Undo; a live append of
three points to an empty surface also produced no TIN triangles or elevation.
`Surface.Invalidate()` without `false` would clear Undo history. Thus the
shared manager alone does not make the current surface writer atomic or
triangulated.

## Decision drivers

The refactoring plan prioritizes exact filter behavior, preservation of CAD
data on failure, bounded memory for large clouds, and verifiable host behavior.
The existing production commands and .NET 3.5 contract must remain available.

## Considered options

Scores are 1–5, higher is better; weights come from the plan's validation
criteria. These estimates rank implementation choices, not host proof.

| Driver | Weight | A: combined Undo journal | B: late section commit with explicit compensation | C: full surface snapshot |
|---|---:|---:|---:|---:|
| Failure correctness with present evidence | 5 | 2 | 4 | 2 |
| Numeric regression control | 5 | 4 | 5 | 4 |
| Bounded memory | 4 | 3 | 5 | 1 |
| Testability now | 4 | 2 | 5 | 3 |
| Implementation and recovery cost | 3 | 2 | 4 | 1 |
| **Weighted total** | | **49** | **94** | **46** |

**A:** Compute first, then combine section edits and a custom point-range
`ICommand` in the shared transaction. It could provide one Undo, but its
inverse must retain inserted points for Redo and verify the tail; TIN updates
on apply, Undo and Redo remain unproven. Shipping it now would claim more than
the host evidence supports.

**B:** Compute stations and points before touching CAD. On the UI thread,
validate the original target, replace sections inside the verified transaction,
then apply points with the existing writer. If insertion fails, compensate the
section commit by Undo only when its transaction is still on top; report any
incomplete or unknown surface state explicitly. This removes the early
mutation without changing the filter algorithm or copying the full surface.
The two stages are not falsely presented as a single atomic Undo.

**C:** Clone the whole surface before editing and restore on error. This may
double memory for multi-million-point clouds, can change object identity, and
has not been measured on a representative project.

## Decision and consequences

Choose B for the generated-section migration. Use `CollectAtStations`, retain
the old sections through calculation, and commit the replacement only after
success or a valid empty result. Roll back failures inside `Clear/Add`.
Validate project, alignment, surface, old section references and station bits
immediately before commit. Do not retry the entire command after a partial
apply, because raw point append can duplicate points. Surface Undo and TIN
construction remain separate implementation gates, not implied by this
decision.

## Pre-mortem and Red Team

- A filter returns slightly different ordered points on the station path.
  Mitigation: keep the legacy three-stage pipeline and compare ordered XYZ
  against the registered-section path in a host fixture before release.
- Another plugin edits sections during calculation. Mitigation: compare
  original references, IDs and exact station bits on the UI thread before
  mutation; reject stale results.
- Section commit succeeds, then point append fails. Mitigation: use the same
  manager's immediate Undo when verified safe, distinguish restored and
  unknown surface states, and prohibit automatic whole-command retry.
- The current batch writer reports success without a TIN. This was reproduced
  on the empty `Eg` surface. Treat surface triangulation as a separate gate;
  do not describe point count as proof of a usable surface.
- Undo restoration depends on the exact SDK path. Retain the live
  Commit → Undo → Redo fixture and add failure injection for the adapter.

The independent Red Team emphasized that a custom `ICommand` must return an
inverse command for Redo, retain inserted point data, verify that its tail is
still owned by this operation, and refresh the TIN on both directions. It also
found that `EndUpdate`, `PointIndexer.Invalidate`, and parameterless
`Surface.Invalidate` are unsuitable substitutes for a TIN rebuild. These
points reinforce deferring A until a bounded and host-verified implementation
exists.

## Decision Journal

**Ex-ante expectation:** cancelling or failing any calculation leaves all
former section objects unchanged; successful generated commands keep the
existing three-stage ordered XYZ output. Any surface apply error identifies
whether sections were restored and whether the surface state is uncertain.

**Check trigger:** first production command switch, failure-injection test,
host station parity test, or any new surface Undo/TIN strategy.
