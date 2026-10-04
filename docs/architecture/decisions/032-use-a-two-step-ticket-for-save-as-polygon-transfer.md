# 032. Use a two-step ticket for Save As polygon transfer

- **Status:** Implemented in plugin commands and .NET 3.5 fixtures; live Rail 16 acceptance open
- **Date:** 2026-09-30
- **Decision-maker:** primary agent after SDK and native Rail 16 research

## Context and drivers

The native Rail 16 Save As/reopen probe changed project and model URIs while
preserving the alignment GUID and all 2,925 ordered section ID/station pairs.
The installed SDK exposes no public Save As event or supported plugin hook
for capturing the old owner during the native operation. The plugin must
remain on .NET Framework 3.5, avoid opening or modifying the source project,
and never copy CRS polygons to an unrelated section set silently.

## Options

Scores are engineering estimates from 1 to 5; higher is better.

| Driver | Weight | A: pre/post ticket | B: after-the-fact source picker | C: hook internal Save As dialog |
|---|---:|---:|---:|---:|
| Source identity and section evidence | 5 | 5 | 2 | 4 |
| Source project stays untouched | 5 | 5 | 2 | 3 |
| Supported SDK and .NET 3.5 fit | 4 | 5 | 4 | 1 |
| Testability and failure recovery | 4 | 5 | 3 | 1 |
| User clarity | 3 | 3 | 4 | 4 |
| **Weighted total** | | **99** | **62** | **54** |

Choose A. Before the native Save As, an explicit plugin command saves a
ticket outside the project. It pins the canonical source project URI, model
URI, alignment GUID, ordered IDs and stations for **all** sections, Plan and
CRS scope keys/revisions, and streamed SHA-256 hashes of the source project
and model files. The ticket itself is written atomically. After native Save
As and reopening, another explicit command reads the ticket, rechecks the
source files/revisions without opening the source project, compares the live
destination alignment and every ordered section, and requires fresh
destination polygon files. It invokes the existing repository transfer
operations one geometry at a time. The user sees both owners before copying.

The command reports a copied Plan scope and an unhandled CRS scope
separately. It leaves the ticket available after a partial or failed copy so
the remaining geometry can be transferred. An existing destination scope is
a conflict, even if empty; it is never silently merged or replaced.

## Pre-mortem and limitations

- An unrelated project happens to share the alignment GUID and all section
  IDs/stations. The ticket checks these and source hashes, but the SDK offers
  no cryptographic Save As lineage proof. The UI calls this an explicit
  verified copy, shows source/destination, and requires user confirmation.
- A source polygon or source project/model file changes after preparation.
  Hash/revision checks reject the transfer before writing the destination.
- The destination has independently created polygons. Fresh-only transfer
  rejects it and preserves both scopes.
- Plan copies, then CRS fails. The command reports the Plan outcome and keeps
  the ticket; no claim of an atomic two-scope transaction is made.
- Sections are regenerated or reordered. Exact ordered ID/station parity
  rejects transfer; the CRS repository also validates every record against
  live sections immediately before copying.

Option B was rejected because after-the-fact file selection cannot inspect
the old model's full section sequence without opening it in the host or
writing a custom `.railx` parser. Option C depends on an internal dialog
method that is not a stable plugin contract.

## Verification and decision journal

The .NET 3.5 ticket fixture must cover exact section order, changed station,
changed source files, stale polygon revision, malformed ticket and
fresh-only destination behavior. Host acceptance uses only the isolated
scratch Rail 16 project and one native Save As. Evidence from the existing
probe remains valid for owner identity, but it does not exercise these new
plugin commands; that is a separate check.

**Expected result:** a prepared source can transfer its saved v2 polygons
into the fresh, matching Save As project without changing any source byte.
**Check trigger:** full ticket/command fixtures, Rail 16 Release/CLR verifier,
and a disposable host prepare/Save As/complete run.
