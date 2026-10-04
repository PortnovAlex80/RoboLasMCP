# 029. Copy v2 polygons only to a fresh project scope

- **Status:** Accepted as a repository prerequisite; Save As identity observed, CRS rebinding API implemented, host workflow open
- **Date:** 2026-09-30
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and drivers

The v2 polygon scope includes the canonical saved project URI. Save As to a
different file therefore creates a different scope even if the alignment GUID
survives. Reopening the same copied Rail 16 project path kept its project and
model URI, alignment GUID and section IDs/stations; Save As itself has not
been verified. An explicit transfer must preserve the source, avoid silently
overwriting polygons already created in the destination, and work on .NET 3.5.

## Options

Scores are engineering estimates on a 1-5 scale, weighted by the plan's data
ownership, no-regression and reversibility requirements.

| Driver | Weight | A: fresh-only copy, dual locks | B: merge with provenance marker | C: activate UI transfer before host gate |
|---|---:|---:|---:|---:|
| Correct ownership | 5 | 5 | 3 | 3 |
| No silent overwrite | 5 | 5 | 3 | 4 |
| No duplicate retry | 4 | 4 | 4 | 3 |
| Host uncertainty tolerance | 4 | 4 | 3 | 1 |
| Reversibility | 4 | 5 | 4 | 3 |
| Testability | 3 | 5 | 3 | 3 |
| Implementation cost | 2 | 4 | 2 | 1 |
| Path to command cutover | 4 | 3 | 5 | 5 |
| **Weighted total** | | **137** | **107** | **94** |

A copies one pinned source revision into a missing destination v2 file. It
decodes the source under its own scope, creates a new destination document
with the destination's identity, and keeps the source bytes unchanged. Both
repository lock files are held in deterministic path order; either a changed
source revision or a pre-existing destination rejects the copy. Repeating a
transfer fails with a clear conflict and cannot duplicate records. Existing
v1 import markers are copied so a later explicit v1 import cannot silently
duplicate the same source.

B could merge into an existing destination and record source provenance for
idempotence. It cannot safely resolve later independent edits in both scopes
without a user-facing conflict policy; appending duplicates and replacing
destination records both lose correctness. C couples the same unresolved
storage policy to all eight commands and the overlay before the host Save As
behavior is known.

## Decision, pre-mortem and Red Team

Choose A. The repository exposes `CopyFromFreshProject` but does not call it
automatically. It requires project scopes of the same geometry and the exact
source/destination snapshots. CRS also requires the same model URI and
alignment ID plus a caller-supplied check of each record against current
sections. If Save As changes either identity, transfer stops until the host
observation establishes an explicit mapping rule.

- A source change after the user sees its records could copy stale geometry.
  The two locks and source revision check reject participating writers that
  changed it before the copy.
- A destination project may already contain independent polygons. Any
  existing destination file, including an empty one, is a conflict; no merge
  or replacement occurs.
- A CRS section may be regenerated or reused. The host caller must verify
  each section ID and station immediately before invoking the copy; the
  repository rejects failed validation and mismatched model/alignment IDs.
- External tools can edit files without taking repository locks. The method
  does not claim a transaction against non-participating writers. A future
  UI flow must show source/destination and require a fresh preview.

The independent Red Team found that hash-only markers cannot resolve a source
that changes after the first copy, and a destination lock alone does not
freeze a participating source writer. These findings favor fresh-only copy
and ordered dual locks over merge semantics. The operation remains explicit
and reversible: the original file is preserved, while the new project owns a
separate file.

## Verification and Decision Journal

The .NET 3.5 repository fixture covers cross-directory project copy, source
byte preservation, destination reopen, stale source/destination, repeat copy,
missing source and CRS model/section validation. The full fixture suite and
the pinned Rail 16 Release verifier pass. The installed Road 16 SDK has mixed assembly
versions and its independent build fails CS1705.

An isolated native Rail 16 Save As/reopen changed project and model URIs
to the new path while preserving the alignment GUID and all 2,925 ordered
section ID/station pairs. The original project's 23 file hashes stayed
unchanged. The ordinary equal-model-URI guard rejects a genuine CRS Save As
transfer. A separate `CopyAfterVerifiedSaveAs` operation now pins both
project/model URIs and the alignment GUID, validates every CRS section
through a caller predicate, and preserves the fresh-only/revision/dual-lock
contract. A host workflow must establish Save As lineage and verify live
sections before exposing this operation in production.

**Ex ante expectation:** on the same saved source revision, a new project
gets identical polygon records under its own key; neither source nor an
existing destination changes on rejection. **Check trigger:** copied-project
Save As/reopen in Rail 16, followed by a production command and overlay pilot.
If the host changes CRS identity, revise the mapping contract before enabling
CRS transfer. If users need to combine independently edited scopes, add an
explicit reconciliation flow rather than broadening this copy operation.
