# ADR 020: Capture polygon deletion source and publish LAS after progress

Date: 2026-09-29. Status: accepted for the legacy v1 delete commands.

## Context

`plan_delete_points` and `crs_delete_points` previously asked for confirmation,
resolved the polygon path with one active-alignment receiver, then opened a
second receiver for the LiDAR scan. A modal project/alignment switch could
mix polygon scope and source. CRS also read its polygon list and groups in
separate calls and cleared the process-global collection unconditionally
after publishing LAS. Plan used a conditional clear but could still publish
against a changed source. Both published from inside `WaitProgress`, whose
callback thread and modal scheduling are unverified in the real host.

This is a complicated boundary decision. It uses the existing v1 format while
the project-scoped repository awaits stable Topomatic identity verification.
The plan values fixed source and destination, verified publication, low
regression risk, and no SDK model reads from an arbitrary worker thread.

## Options and decision drivers

Scores are 1–5, higher is better; weights follow the refactoring plan's
correctness, regression, testability, implementation and host-thread concerns.

| Criterion (weight) | Patch CRS clear only | Validate inside progress | Stage then validate on command thread |
| --- | ---: | ---: | ---: |
| Correct source and scope (7) | 2 | 4 | 5 |
| Regression containment (5) | 5 | 3 | 3 |
| Testability (4) | 4 | 4 | 4 |
| Implementation cost (2) | 5 | 3 | 2 |
| Host thread/receiver safety (4) | 5 | 1 | 5 |
| Weighted score | 85 | 69 | 90 |

The first option leaves mixed source and polygon ownership. The second would
open another receiver or marshal a host call from the progress callback;
either may deadlock a modal UI. The third changes late-progress failure
timing but makes the final file commit occur after progress closes.

## Decision

Capture the active alignment, model, project, document, view, ordered LiDAR
buffers/indexers and first-buffer v1 directory before confirmation. Take one
deep polygon snapshot for each command; build CRS section groups only from
that snapshot. Recheck host/source after confirmation and the save dialog.
Keep the long-running alignment receiver alive for every LiDAR scan and
`LasBatchStreamWriter.Complete()`. The progress callback returns a
`PreparedLasFile`; after the progress closes and the receiver is disposed,
recheck host/source on the command thread and publish. A progress failure
before publication disposes the stage and preserves the final LAS. After
publication, conditionally clear exactly the original polygon snapshot.
Report LAS-saved/polygons-retained when scope or data changed; update the Plan
overlay only after the JSON clear commits and its captured view still matches.

The command IDs, v1 JSON, geometry, LAS point order, output format and bounded
batch size remain. This is an interim v1 safety boundary, not the v2
project/alignment repository cutover.

## Pre-mortem and Red Team

1. Borrowed LiDAR arrays fail after receiver disposal. The receiver now
   remains open through preparation; it closes before final host validation.
2. Progress runs off the CAD UI thread or blocks nested `Invoke`. No host
   lookup or nested receiver is made in its callback; final validation and
   publication occur after `WaitProgress` returns. The native scheduling
   contract still needs an isolated GUI test.
3. The source changes in the same directory. Ordered buffer and indexer
   references plus full paths are compared before scan and before publish.
   In-place edits to point arrays or metadata remain outside this check.
4. Progress throws after `Complete`. The prepared stage is owned by an outer
   `finally`, so a pre-publication exception leaves the prior final LAS and
   polygons intact.
5. LAS publishes but polygon clear conflicts or fails. The command reports
   the output path and leaves the polygons/overlay for explicit recovery.
   Retrying the whole export is not presented as an automatic fix.

The Red Team's strongest objection was provider-backed buffer lifetime and
unstable SDK wrapper identities. Retaining the original receiver through
preparation addresses lifetime; strict identity may conservatively reject a
valid operation. The isolated host test must decide whether that occurs.
There is no cross-process revision check for v1 JSON and no proof that
in-place source mutation is prevented by other host tools.

## Verification and consequences

Production-command fixtures pass 60 Plan and 65 CRS checks, including modal
switches, same-directory buffer and indexer replacement, post-publication
scope changes, final-progress cancellation and partial-result messaging. Real
LAS writer fixtures pass 132 and 140 checks, including staged-file cleanup
after a context switch; the full .NET 3.5 runner and both Rail 16 SDK builds pass.
These fixtures do not establish actual Topomatic GUI scheduling, source
locking, buffer wrapper stability, or native Undo behavior.

## Decision Journal

**Ex-ante expectation:** an interrupted delete before publication leaves the
existing final LAS and both polygon files untouched. A successful publication
clears only the snapshot used to produce it, or reports the exact partial
result. No nested receiver is opened while the scan receiver is alive.

**Check trigger:** first isolated Topomatic session with two saved projects,
multiple alignments, modal document switches, and a disposable LAS output.

**What would change this decision:** the host recreates buffer/indexer wrappers
during an ordinary uninterrupted operation, or `WaitProgress` returns before
its callback completes. Either requires a host-supported source generation or
commit API before further relaxation of the guard.
