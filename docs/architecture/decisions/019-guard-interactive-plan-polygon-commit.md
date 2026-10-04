# 019. Guard an interactive Plan polygon commit

- **Status:** Accepted for Plan drawing; v1 storage and live host behavior remain limited
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`plan_draw_polygon` resolved the active alignment's first LiDAR directory,
initialized a process-global v1 collection, and then waited for cursor input
and a save dialog. It wrote to that collection without checking whether the
alignment, project, document, view, overlay, buffer directory or collection
binding had changed. A polygon drawn after a context switch could therefore
be saved under the old directory or into a newly initialized static file.

This is a **Complicated** fork. The existing CRS draw command demonstrates
host identity checks, and the Plan collection already exposes a deep snapshot
for long operations. The v2 polygon repository exists but its project identity
and migration policy still await an isolated host check under ADR 009.

## Decision drivers and options

Scores are 1–5, higher is better. Weights follow ADR 001 and the plan's
priority of preventing wrong-scope persistence without changing v1 data.

| Driver | Weight | A: local checks only | B: Plan drawing session | C: shared legacy host context and conditional add |
|---|---:|---:|---:|---:|
| Correct scope and collection | 5 | 2 | 3 | 4 |
| SDK and UI safety | 5 | 4 | 4 | 4 |
| Testability | 3 | 3 | 4 | 5 |
| Implementation cost | 4 | 5 | 3 | 3 |
| Reversibility | 2 | 5 | 4 | 4 |
| Future cutover seam | 1 | 2 | 4 | 4 |
| **Weighted total** | | **71** | **71** | **79** |

A checks the active host inline around the dialog but leaves the mutable
collection binding independent. B adds a Plan-only session that owns host and
storage checks. C uses a narrow `LegacyPolygonOperationContext` for host
identity and the exact legacy first-buffer directory, while
`PlanPolygonCollection.TryAddIfUnchanged` owns the atomic in-process storage
check. This separation also allows the two clear commands to reuse the host
check without making a v1 path policy part of the v2 repository.

## Pre-mortem and Red Team

Assume C failed after deployment:

1. A same-path `Initialize` during a modal dialog resets collection state.
   Comparing only `_filePath` would allow an old drawing session to write.
   The Red Team identified this gap. `PlanPolygonSnapshot` now includes a
   generation incremented on every successful in-process mutation or load;
   conditional add compares generation, path and polygon contents under one
   lock before writing.
2. Another process edits the v1 JSON after the snapshot. The static v1
   collection has no cross-process revision lock. This remains an explicit
   limitation until the versioned repository is connected; the new check
   must not be described as cross-process conflict protection.
3. Topomatic recreates an alignment or model wrapper without changing the
   user's target. Strict reference checks reject the save safely. The copied
   SDK build cannot establish wrapper lifetime during GUI switches; test it
   in an isolated host profile before relaxing the checks.
4. The view closes during cursor input or a modal dialog. The command checks
   the context before each polygon and after a save decision, and its
   `finally` removes `DynamicDraw`. A native cursor exception may still need
   host-specific handling, but it cannot reach the guarded commit.
5. The file commit succeeds and overlay update fails. The command reports
   that the polygon was saved and the overlay was not updated, so the user is
   not instructed to retry a completed write blindly.

The Red Team favored separating host validity from storage conflict checks.
It also noted that a path-only conditional add was insufficient; the
generation and snapshot comparison are the mitigation. Live external-file
conflicts remain the v2 migration gate.

## Decision and consequences

Choose C, implemented first for Plan drawing. Capture the legacy host context
once, recheck it before each polygon and immediately after Yes/No, then commit
through `TryAddIfUnchanged`. Update the overlay only after a successful file
write. Keep command ID, v1 directory selection, JSON format, cursor geometry
and Yes/No/Cancel meaning. Reuse the context for clear commands in a separate
verified step; their destructive confirmation requires its own snapshot test.

The production fixture executes the actual `Run` and actual v1 JSON code on
temporary directories. It tests normal one/two-polygon output, context
changes during interaction, same/different-path reinitialization, write
failure, overlay behavior and dynamic handler cleanup. These tests do not
prove native GUI scheduling, wrapper lifetime, or cross-process file locking.

## Decision Journal

**Ex-ante expectation:** an interactive Plan polygon writes only when the
startup alignment, model, project, document, view, overlay and first-buffer
directory remain current and the v1 collection has not been reinitialized or
changed since the preceding committed snapshot. A failed commit leaves the
overlay unchanged and releases the dynamic handler.

**Check trigger:** first isolated GUI drawing session with project and active
alignment switches, plus any future replacement of static v1 storage.

**What would change this decision:** stable host wrappers cannot be obtained
across ordinary uninterrupted cursor input, or an external-file conflict is
observed in v1 usage that cannot wait for the scoped repository cutover.

**Follow-up:** The same captured host context now guards both Plan and CRS
clear confirmations. CRS gained a generation and deep snapshot check before
conditional clear; Plan reuses its existing conditional clear. The command
fixture passes 18 checks on real temporary v1 files. Both clear commands and
Plan drawing also verify that a newly captured snapshot belongs to the
directory fixed at command start. Native modal behavior is still subject to
the isolated host acceptance cases.
