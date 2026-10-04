# 031. Cut over polygon commands with operation-scoped v2 state

- **Status:** Command and overlay cutover implemented; Save As ticket UI and live host acceptance open
- **Date:** 2026-09-30
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and drivers

The native Rail 16 Save As/reopen check changed both project and model URIs
while preserving the alignment GUID and all 2,925 ordered section ID/station
pairs. The v2 repository and project resolver exist, but five Plan commands,
three CRS commands, and the Plan overlay still use static v1 collections.
The v1 files may belong to more than one project using the same cloud
directory. An implicit import would assign that shared history without an
owner decision. The plugin must remain on .NET Framework 3.5.

The implementation must preserve geometry, command IDs, LAS publication
behavior, and CAD target checks while making project ownership explicit.

## Options

Scores are engineering estimates from 1 to 5. Higher is better.

| Driver | Weight | A: operation-scoped gateway and explicit migration | B: direct repository calls in each command | C: broad workflow rewrite |
|---|---:|---:|---:|---:|
| Correct project and section ownership | 5 | 5 | 3 | 5 |
| No silent data loss or overwrite | 5 | 5 | 3 | 4 |
| Regression risk during cutover | 5 | 4 | 2 | 1 |
| .NET 3.5 and SDK fit | 4 | 5 | 5 | 3 |
| Testability | 4 | 5 | 3 | 4 |
| Change size and reversibility | 3 | 4 | 4 | 1 |
| **Weighted total** | | **126** | **88** | **78** |

Choose A. A narrow operation-scoped adapter captures the active
project/document/model/alignment and saved `PolygonScope` on the CAD thread.
It owns one `ScopedPolygonRepository` and revision snapshot, converts
records at the command boundary, and revalidates host identity before a
commit, LAS publication, or CAD apply. Long-running commands also preserve
their existing borrowed LiDAR source checks. Repository `Commit` remains
the file revision compare-and-swap; it is not a substitute for host checks.

Implement and test the explicit import and transfer entry points before
switching readers. An empty v2 scope with available v1 data must report
that import is available, without displaying an empty collection as if
old data were deleted. Then the eight production commands and the Plan
overlay move as one storage cutover. Drawing and clear commands commit
complete v2 record lists against
the captured revision. Delete commands resolve and validate all polygons
before LAS publication, then clear by revision after successful publication;
a clear conflict reports that the LAS was saved while polygons remain.
Plan surface commands read pinned v2 records and retain their current
source-order and CAD target checks. Their polygon owner is resolved from
the project; `PlanSurfaceTarget.ProjectPath` currently comes from the first
LiDAR buffer and must no longer select polygon storage. CRS records use
section ID and station;
deletion maps them to current indices and rejects missing, duplicate or
shifted sections before writing LAS. Current CRS border settings remain the
calculation input, independent of the saved thickness metadata.

The overlay receives a committed snapshot bound to a view and scope key.
It replaces its render list on read/commit and clears it when the owner
changes. It never reads a global v1 collection during painting.

## Migration and Save As

The first v2 read does not import v1. A separate explicit command previews
the selected v1 file, absolute source path, record count/hash, target scope,
project and alignment; the user then imports or skips. `PreviewLegacy`
and `ImportLegacy` recheck exact source bytes and target revision. CRS
legacy index/station bindings are validated against current section IDs
again after the dialog. The original v1 file stays untouched.

Save As creates an empty destination scope until an explicit transfer.
`CopyFromFreshProject` keeps its same-model-URI guard. A separate,
narrowly named Save As transfer must pin old and new project/model URIs,
require the same alignment GUID, validate every source section ID/station
against the live destination, lock both scopes in a fixed order, and require
a missing destination file. This is a rebind of a proven copy, not a generic
permission to copy CRS polygons between models.

## Pre-mortem and Red Team

- A command reads one project's polygons but commits after a document
  switch. The adapter rechecks active host objects and scope on the CAD
  thread immediately before the write.
- A worker reads UI state or a mutable source while scanning. Existing
  source snapshots and caller-only progress polling remain in place.
- CRS sections are reordered or regenerated. Association is by ID and
  station; absent, duplicate or shifted matches abort before LAS publish.
- LAS publication succeeds but polygon clear conflicts. The command reports
  the two outcomes separately and does not claim the polygons were cleared.
- A Plan overlay survives Save As or project switch. Its owner key and
  document are checked before replacing or rendering its snapshot.
- A transfer is repeated or its source changes. Ordered locks, pinned
  revisions and fresh-only destination reject the retry/conflict.

The independent Red Team emphasized that repository CAS alone cannot
validate the live Topomatic owner, and that changing the existing CRS
model-URI check globally would allow unrelated model transfer. Both
points are incorporated above. Direct calls in each command were rejected
because they duplicate these checks; a broad workflow rewrite was rejected
because storage cutover needs a smaller regression surface.

## Verification and Decision Journal

Command fixtures must cover two projects sharing a cloud directory, Save
As/reopen, project and alignment switches after dialogs, stale revisions,
failed writes, v1 source preservation, explicit skip/import/repeat import,
cross-project overlay updates, and CRS section reorder/missing/duplicate/
station drift. Real LAS command tests must preserve publication and
partial-clear outcomes. Run the complete .NET 3.5 suite, architecture check,
isolated Rail 16 build and CLR/reference verifier. Road 16 compatibility is
not claimed while the installed SDK has mixed assembly versions.

**Ex ante expectation:** after cutover, no production polygon command or
overlay reads or writes a v1 collection, and no project can see another
project's polygons without an explicit import/transfer. **Check trigger:**
all eight command fixtures plus a disposable Rail 16 project/Save As run.
