# 009. Gate polygon v2 command cutover on live host identity

- **Status:** Accepted as migration sequence; PR-03 remains open
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

The v2 repository already supports immutable project/alignment scopes, revision
checks, verified replacement, and explicit import of legacy JSON. Eight polygon
commands and the persistent Plan overlay still use v1 collections. The current
resolver derives the owner from the active project and alignment, not a LiDAR
buffer. Its key includes project URI and alias; CRS also includes model URI and
alignment GUID. The SDK exposes these values, but their stability after Save As,
reopen, and section regeneration has not been observed in a running host.

The copied Rail 16 installation is suitable for isolated deployment, but a GUI
launch under the current account would share its existing Topomatic profile.
No separate profile or disposable project is available yet. The SDK-only probe
cannot establish the host identity lifecycle. Activating v2 now might hide
legacy polygons or orphan newly saved v2 polygons without a clear recovery
path.

## Options and MCDA

Scores are 1-5; larger is better. Totals are weighted sums. These are
engineering judgments about the *next sequencing step*, not measured runtime
results.

| Driver | Weight | A: cut over now | B: cut over with first-use import chooser now | C: prepare contracts, verify host identity, then cut over |
|---|---:|---:|---:|---:|
| Correct owner association | 5 | 3 | 4 | 5 |
| Legacy visibility and recovery | 5 | 1 | 5 | 5 |
| Regression confidence | 5 | 2 | 3 | 5 |
| Host identity evidence | 5 | 1 | 1 | 5 |
| Plan completion progress | 3 | 4 | 5 | 2 |
| Implementation cost | 3 | 4 | 2 | 4 |
| Testability | 4 | 3 | 3 | 5 |
| Reversibility | 3 | 4 | 3 | 5 |
| User clarity | 3 | 2 | 4 | 3 |
| **Weighted total** | | **89** | **119** | **162** |

A routes all commands directly to a project scope, leaving v1 records
invisible until a separate import. B shows the source file, target owner and
record count, and requires an explicit project/shared/skip choice before
import. C implements and tests the owner and section contracts while keeping
the existing command storage active until live identity evidence permits B.
The scores favor C only as a sequence gate; it is not the final PR-03 design.

## Pre-mortem and Red Team

- Project alias or model URI changes after Save As/reopen. A v2 scope key changes
  and polygons appear lost. Compare diagnostic snapshots before/after Save As
  and reopen; determine a stable key or explicit transfer before activation.
- Section index is reused for a different section. Match v2 records by section
  ID and station; reject missing, duplicate, moved, or non-finite matches.
- A first-use chooser silently imports a v1 file from an unrelated cloud. Show
  exact source path, target project/alignment and count, and require a choice.
  Preserve v1 bytes. Never infer ownership from the first LiDAR buffer.
- The overlay displays a different revision from the file. Update it only from
  a committed repository snapshot associated with that document view.
- The test copy alters the user's Topomatic profile. Run the GUI only under a
  separate Windows account/VM, or after an explicit profile recovery decision.

The independent Red Team found that the unresolved identity lifetime is a
stronger risk than repository implementation complexity. It specifically
rejected shared-cloud scope as a universal fallback and a bulk first-use
import without explicit source/owner selection. The decision therefore gates
command activation, while allowing independent workflow work to continue.

## Decision

Choose **C now, then B after the host gate**. Retain v1 command behavior while
preparing v2 context and CRS association contracts. In the host, collect
project URI/alias, model URI, alignment GUID, and section IDs/stations before
and after Save As, reopen, alignment switch, and section regeneration. Decide
which values define a stable owner and how Save As transfers polygons. Then
wire all eight commands and the overlay to per-operation repository snapshots,
with explicit legacy import choices and revision-guarded mutation.

## Consequences and verification

This change adds `CrsScopedSectionAssociation` and exercises the actual
`PolygonContextResolver` against .NET 3.5 SDK-shaped fixtures. The resolver's
22 checks cover two projects in one folder, two alignments, and rejection of
inactive, unsaved, missing or invalid owners. The CRS helper's 11 checks cover
reorder, duplicate/missing ID, moved/non-finite station, and invalid input.
These tests establish local contracts only; they cannot prove SDK identity
stability. The commands still use v1 and PR-03 is not accepted.

## Decision Journal

**Ex-ante expectation:** live snapshots will either show stable URI/alias and
alignment identity across reopen, or expose a concrete Save As/reopen transfer
rule. The first v2 command rollout will preserve legacy visibility through an
explicit import path, and cross-project/section tests will reject accidental
reuse.

**Check trigger:** first isolated Rail 16 GUI run with a disposable project.
**Revisit if:** the host cannot provide a stable owner, or v1 is proven to have
an intentional shared-cloud scope that the user wants to retain by default.

## 2026-09-30 refinement: alias is display metadata

The resolver proved that a saved project's URI identifies its actual project
file; two projects in one directory have different URIs. The v2 key therefore
uses the canonical project file URI, without the mutable `Project.Alias`.
The alias remains in the JSON for display and is refreshed on commit. Tests
cover an alias rename with unchanged file path, an empty alias, and two
different project files in one directory. This removes one way to orphan
polygons before v2 is activated. It does not establish Save As/reopen identity
or move any of the eight production polygon commands from v1. Experimental v2
files written with the earlier alias-dependent key are not automatically
discovered by the revised key; no production command has written such files.

## 2026-09-30 refinement: pin the selected v1 bytes before import

The accepted sequence remains unchanged: production commands stay on v1 until
the live Save As/reopen identity gate is verified. The explicit first-use import
flow needs a read-only preview before the user chooses an owner. The repository
now returns the selected source path, validated record count, source hash,
target scope key, and exact destination path. It copies verified CRS section
bindings into that preview and rejects empty or duplicate section IDs.
The preview-based import checks the source hash again under the destination
lock, before publishing any v2 JSON. A changed source or a preview for another
destination is rejected; the v1 file is not modified. The future host chooser
must recheck the current sections immediately before import; the repository
cannot observe CAD state. The old direct import API remains for
existing tests and compatibility, but the future chooser must use the preview
API. This preparation does not activate v2 or establish host identity stability.

## 2026-09-30 refinement: Save As uses a fresh destination scope

The current key contains the canonical project file URI. A new Save As path
therefore has a different owner by design. ADR 029 adds an explicit repository
copy from a pinned source revision into a missing destination, with both scope
locks and CRS section checks; it never overwrites an existing target or edits
the source. Production commands and overlay remain on v1 until the copied-host
Save As/reopen check and a visible transfer choice are integrated.

## 2026-09-30 SDK Save As probe limit

The copied Rail 16 host is running a disposable project, and diagnostic IPC
can read its project/model URI, alignment ID, and section IDs. The SDK exposes
`Project.TargetProjectUri` and `ModelProject.Save()`, but no supported Save As
call in the available diagnostic surface. Changing the URI and calling Save
would bypass the host's linked-file copy workflow and would not test real
Save As behavior. The internal `CreateNewRoburProjectDlg.ExecuteSaveAs` is a
GUI method whose implementation is unavailable in the decompiled copy. The
attempted GUI menu interaction did not open the command, so Save As identity
and file-copy behavior remain unverified. No production polygon command has been switched
to v2 on this evidence.
