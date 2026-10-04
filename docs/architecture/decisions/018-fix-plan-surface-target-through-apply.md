# 018. Fix the Plan surface source and destination through apply

- **Status:** Accepted for the two Plan surface commands; live host acceptance remains open
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`plan_polygon_grid_surface` and `plan_polygon_polynomial_surface` previously
opened one active-alignment receiver to find the legacy polygon directory
from a LiDAR buffer, then opened another receiver and collected the buffers
again for scanning. A user could switch the active alignment between those
steps, mixing polygons from one source with points from another. Both commands
then inserted points directly into the initially selected surface without
checking whether the CAD target had changed during the long scans.

The fork is **Complicated**: the SDK interfaces and command flow are available
for analysis, but receiver lifetime, UI dispatch, and Undo still need live
Topomatic checks. The change must preserve the v1 directory selected from
the first named LiDAR buffer. Moving to project-scoped polygon storage now
would change which polygons the commands read before the migration gate in
ADR 009 has passed.

## Decision drivers and options

Scores are 1–5, higher is better. Weights follow ADR 001: correctness and SDK
resource safety dominate cost and future flexibility.

| Driver | Weight | A: compare the two existing receivers | B: one capture, saved-reference check | C: captured source, live apply check |
|---|---:|---:|---:|---:|
| Correct source and destination | 5 | 2 | 2 | 5 |
| SDK resource safety | 5 | 4 | 5 | 4 |
| Testability | 3 | 3 | 4 | 5 |
| Implementation cost | 2 | 5 | 4 | 3 |
| Reversibility | 2 | 5 | 4 | 4 |
| **Weighted total** | | **59** | **63** | **74** |

A would compare the alignment used for the path with the one used for scan,
and possibly compare again before insertion. It leaves two separate buffer
collections and can miss a late switch or destination change. B would collect
once and validate the saved view, surface, model, project and alignment ID,
but cannot tell whether another alignment in the same project became active
during the scan. C captures the active alignment and buffers once, keeps the
first receiver alive through both scans, releases it, then obtains the live
alignment in a short second receiver immediately before synchronous apply.
It also checks the view, surface layer, surface, model, project and document.

## Pre-mortem and Red Team

Assume C failed six months later:

1. Borrowed LiDAR buffers change in place during scanning. Keeping the source
   receiver open matches the previous scan lifetime, and the plugin command
   gate limits its own commands, but neither guarantees exclusion of other
   Topomatic tools. Live host switching tests remain necessary.
2. A same-project alignment switch passes saved-reference checks. The Red
   Team identified this as the leading option's fatal gap. The final design
   opens a second receiver at apply and compares its alignment reference and
   ID; it also compares the model and project. The two receivers are
   sequential, avoiding an unverified nested-receiver call.
3. A view or layer wrapper is recreated while its underlying surface stays
   valid. Strict reference checks can reject a safe operation. This is a
   reversible failure and must be measured in the host before relaxing it.
4. A progress callback invokes apply from a worker thread. `PlanSurfaceTarget`
   dispatches the validation and writer together through `CadView.Invoke`
   when required, after checking that the view handle still exists. The
   fixture verifies dispatch selection; real message-pump behavior is open.
5. `FastSurfaceBuilder` throws after a partial SDK update. Its local tail
   compensation and status are retained. The commands suppress success and
   report when the SDK update state is unknown; they do not claim Undo or a
   complete rollback.

The Red Team favored C only after the active alignment was checked again
immediately before apply. It also required preserving the v1 path and keeping
the first receiver alive for both scans. Those conditions are implemented.

## Decision and consequences

Choose C. Both commands use `PlanSurfaceTarget` and the existing
`TopomaticSurfaceWriter`. No numerical scan, fitting, feature-detection,
polygon format, or command identifier changes. A failed target check cannot
call `FastSurfaceBuilder`, and success is shown only after apply returns.
The first nonempty LiDAR `fullpath` still selects the v1 polygon directory.

The production-command fixture now compiles the actual target and writer,
tests both commands across context changes during the second scan, and checks
one buffer collection, two sequential receiver acquisitions, v1 path,
insertion failures, and dispatch selection. It cannot establish native SDK
Undo, TIN state, buffer validity under another host tool, or UI scheduling.
Those remain acceptance checks in an isolated Topomatic profile and project.

## Decision Journal

**Ex-ante expectation:** Plan surface commands read one captured set of
buffers and never add points when the active alignment, document, project,
view, layer, surface or model changes before apply. Normal output and command
identifiers remain unchanged.

**Check trigger:** first isolated GUI run with a disposable Rail 16 project,
plus any change to receiver or `FastSurfaceBuilder` behavior.

**What would change this decision:** evidence that a receiver does not keep
borrowed buffers valid through progress work, or that stable SDK wrappers
change identity during normal uninterrupted calculations. Either finding
requires a narrower host-specific capture strategy, not an untested relaxed
target check.
