# 023. Guard interactive CRS polygon commits on the captured v1 source

- **Status:** Accepted for the live v1 command
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`crs_draw_line` initializes a process-wide `CrsPolygonCollection` before
interactive cursor input. Another command can reinitialize that collection
while the first command waits for a point or save choice. The old unconditional
`Add` then writes the polygon to the newly selected v1 file even when the CAD
project, alignment and section have not changed.

The v2 repository has project and alignment scopes, but project URI/model URI
and alignment GUID stability through Save As and reopen is not established in
an isolated Topomatic project. The current v1 directory is selected from the
first named LiDAR buffer; this command change preserves that location and
format.

## Options

Scores are estimates on a 1–5 scale; higher is better.

| Driver | Weight | A: guard v1 commit | B: immediate v2 cutover | C: keep current Add |
|---|---:|---:|---:|---:|
| Prevent wrong-file save | 5 | 5 | 5 | 1 |
| Current behavior compatibility | 5 | 5 | 2 | 3 |
| Preserve v1 bytes and ownership | 4 | 5 | 2 | 5 |
| Offline testability | 4 | 5 | 2 | 1 |
| Progress toward scoped storage | 4 | 2 | 5 | 1 |
| **Weighted total** | | **98** | **71** | **48** |

Choose A. Capture `LegacyPolygonOperationContext` and a deep collection
snapshot before cursor input. Recheck the host/source and add only if the
collection generation, path and polygon values still match. Refresh the
snapshot after a successful first polygon so the same command can save a
second one. A conflict leaves the intended polygon unsaved with a warning.

## Pre-mortem and independent review

- The global collection may be reinitialized to the same directory; the
  generation check rejects even that ambiguous reuse.
- A record obtained through the legacy shallow `GetAll` may be edited in
  place without increasing generation; deep comparison rejects the change.
- LiDAR buffers, fullpaths or indexers may change during modal input; the
  existing operation context checks their captured order and identities.
- A successful file write can be followed by a collection switch before the
  next snapshot. The command reports the polygon saved and stops drawing
  instead of continuing against the new collection.
- A write failure must preserve the prior collection and v1 file. Persistence
  tests lock the destination and compare its bytes.
- The v1 collection has no cross-process revision check. Only the v2
  repository addresses edits from another process; project ownership still
  gates command cutover.

## Decision Journal

**Ex-ante expectation:** two polygons drawn under one stable source save in
their original v1 file; reinitialization, source replacement and in-place
record edits prevent a new write. The command's section association and
thickness snapshot stay unchanged.

**Check trigger:** first isolated host test of cursor/receiver behavior,
project identity validation for the v2 cutover, or a change to static v1
collection lifetime.

## Follow-up: v1 collection ownership

Both live v1 collections now clone entries accepted by `Add` and returned by
`GetAll`; CRS `GroupBySection` also clones its entries. An external in-process
holder of a record can no longer mutate collection contents through that
record. The command's generation, source and snapshot checks remain in place
for actual collection changes and reinitialization. Cross-process file edits
and project ownership remain outside this v1 safeguard.
