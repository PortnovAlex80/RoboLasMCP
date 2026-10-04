# 030. Require a verified LiDAR read lease before claiming value stability

- **Status:** Accepted limitation; host investigation open
- **Date:** 2026-09-30
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

Plan and CRS point deletion borrow `Vector3F[]` points and `byte[]` weights from
Topomatic. `BorrowedLidarSourceSnapshot` detects a changed array, indexer,
count, path or transform before publishing LAS, but cannot detect an edit to
an element of the same array. The installed SDK exposes mutable arrays and no
verified LiDAR read lease, revision counter or mutation event. The alignment
receiver is held through scanning, but there is no evidence that it freezes
the LiDAR provider. The fork is **Complicated**: a content digest, a private
spool and continued metadata checking have different runtime costs, while
none proves an atomic snapshot without host synchronization.

## Decision drivers and options

Scores are 1-5, higher is better. Correctness means an *honest, supportable*
contract, not merely detection of one test mutation.

| Driver | Weight | A: SHA-256 before/after export | B: private disk spool | C: metadata guard, seek SDK lease |
|---|---:|---:|---:|---:|
| Supportable correctness | 5 | 2 | 3 | 2 |
| SDK lifetime safety | 5 | 2 | 2 | 5 |
| Memory bounds | 4 | 5 | 4 | 5 |
| Large-cloud throughput | 4 | 2 | 1 | 5 |
| Testability | 3 | 4 | 4 | 3 |
| **Weighted total** | | **60** | **57** | **84** |

A can detect a persistent mutation with bounded memory, but at least two
extra full-cloud reads add roughly 2.6 GB of reads for 100 million points
and weights. A digest after the receiver closes would dereference arrays with
unproven lifetime; a digest before it closes leaves a final race. Unsynchronized
writers can also create a mixed read or edit-and-restore values. SHA-256
collision probability is not the relevant risk. B freezes values after the
spool has been written, but its initial read can race and the spool requires
roughly 13 bytes per point plus framing and disk I/O. Loading a separate
`.ldr` also risks diverging from unsaved in-memory state and allocates another
cloud. No exposed SDK method has a verified matching LiDAR read-unlock
contract.

Choose C until a host read lease, revision, or equivalent source contract is
verified. The current metadata guard remains a fail-closed check for the
changes it can observe; this is **not** a claim of safety against concurrent
in-place writes. As a concrete improvement, capture and recheck the weight
array's logical `Count` as well as its backing length. Skip the count getter
when the backing array is null so malformed source data reaches the command's
existing validation path. Do not add a hidden full-cloud hash to ordinary
exports without a representative large-cloud baseline and an explicit
best-effort contract.

## Pre-mortem and Red Team

1. A host tool edits values in place while delete exports. The metadata guard
   misses it and the LAS may mix source revisions. The product must not claim
   atomic source capture; acquire a supported read lease or move to an owned
   source before that claim is made.
2. A future SDK changes provider wrapper lifetime. Re-reading after receiver
   disposal could fail or read unrelated data. Keep validation through fresh
   receiver collection and avoid a raw-array digest after disposal.
3. A very large cloud makes a full digest or spool unacceptable. Measure on
   the same machine and cloud before enabling either path by default.

The independent Red Team rejected A as a correctness gate: it narrows one
mutation window but leaves lifetime, torn-read and final publication races.
This is why the higher-scoring C is a temporary, explicit boundary rather
than a declaration that the original issue is fixed.

## Verification and Decision Journal

The .NET 3.5 source-context fixture rejects a changed logical weight count
with the same array. Plan and CRS command fixtures change that count after
LAS staging and require no publication or polygon clear. Existing tests cover
the unchanged and malformed null-weight paths. In-place element mutation
remains an open host/algorithm verification item.

**Ex-ante expectation:** normal large-cloud export has no additional
full-cloud pass; a logical weight count change after staging is rejected.
**Check trigger:** isolated Topomatic investigation of provider locking and
mutation events, or any future proposal to enable content hashing/spooling.
At that point, benchmark representative large clouds and add an in-place
point/weight mutation fixture before changing the contract.
