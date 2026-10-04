# ADR 034: Port the installer to .NET Framework 3.5

- **Status:** Accepted
- **Date:** 2026-09-30
- **Supersedes:** ADR 033
- **Decision-maker:** autonomous-decision skill, primary agent

## Context

The user requires the whole project to stay within .NET Framework 3.5. The
Topomatic plugin already targets CLR 2, while the standalone installer and its
tests target .NET 8. ADR 033 preserved that exception during the plugin
refactor and explicitly left the repository-wide requirement open. The new
requirement makes that exception unacceptable for completion.

The installer must keep rejecting unsafe package paths and duplicates before
writing, retain its Topomatic and per-user destinations, and install the
canonical `.tpm` package without changing its file bytes. The release build
must prove the target framework and CLR version of every managed project.

## Decision drivers

| Driver | Weight | Source |
|---|---:|---|
| Whole-repository .NET 3.5 ceiling | 35% | Explicit user requirement and refactor completion gate |
| Package and filesystem safety | 35% | Existing installer preflight and no-regression requirement |
| Release workflow continuity | 20% | Existing `.tpm` format and installer UI |
| Implementation and review cost | 10% | Refactor plan's narrow-change rule |

## Considered options

### Port the current installer

Compile the installer and its tests with the .NET 3.5 compiler. Replace the
.NET 8 ZIP and WinForms APIs with CLR 2 equivalents. Read only the explicitly
supported subset of canonical packages, reject other ZIP features before
writing, and verify entry checksums and decompressed sizes. Keep the current
destinations and UI. This is reversible in one focused commit. The unknown is
whether all packages built by the current packager fit the supported subset.

### Use a native MSI installer

Remove the managed installer runtime and gain transactional installation, but
redesign selection of the Topomatic root and per-user LocalAppData payload.
This changes the build and delivery toolchain and needs fresh upgrade and
rollback acceptance. It is substantially harder to reverse after release.

### Move the .NET 8 installer outside this repository

Keep the already tested installer and enforce CLR 2 on all remaining projects.
This improves repository boundaries but leaves the delivered installer on
.NET 8, so it does not satisfy the user's whole-product ceiling. It also adds
cross-repository artifact coordination.

## MCDA matrix

Scores are 1 to 5, higher is better.

| Option | Ceiling (35%) | Safety (35%) | Continuity (20%) | Cost (10%) | Weighted score / 5 |
|---|---:|---:|---:|---:|---:|
| Port current installer | 5 | 3 | 4 | 2 | 3.80 |
| Native MSI | 5 | 4 | 2 | 1 | 3.65 |
| External .NET 8 installer | 1 | 5 | 3 | 4 | 3.10 |

The port leads narrowly. Its safety score assumes a strict format contract,
tests against malformed archives, and complete extraction validation before
the first write. A target-framework edit alone would score much lower.

## Pre-mortem

Assume the port failed six months after release:

1. A ZIP variant or central/local header mismatch bypassed validation. Reject
   unsupported flags, headers, names and layouts; test corrupted archives.
2. An I/O failure left a partially replaced installation. Stage files and
   restore previous files on failure; test an injected mid-install fault.
3. A target PC lacked the Windows .NET 3.5 feature. Document this prerequisite
   and test the installer on a machine where the feature is enabled.
4. A future project silently retargeted to a newer runtime. Enumerate every
   managed project in the release gate and inspect built CLR metadata.

The option survived archive validation, isolated installation and rollback
tests. Windows startup without the .NET 3.5 feature remains a prerequisite.

## Red Team

The strongest objection is the new ZIP reader. The old installer delegates
archive parsing to `ZipArchive`; a custom reader can mishandle ZIP64, data
descriptors, name encodings, checksums, overlapping entries and size claims.
The response is to accept only the format emitted by the repository
packager, reject every unsupported variant before writes, and compare every
installed file against a real `.tpm`. Red Team also identified the existing
partial-install risk and the loss of .NET 8 self-contained deployment. Staging
and rollback tests address partial installation; the framework feature is a
deployment prerequisite.

Independent review found an inherited elevated path race: a user-writable
directory can become a junction between path inspection and installation.
Closing that race while preserving arbitrary installation roots requires
handle-relative native operations or unelevated writes. The canonical package
has no `files/` payload, and the usual Program Files root is protected.
Static junction tests do not prove the concurrent-swap case. The ZIP reader
checks expanded CRC and size but does not prove that Deflate consumed every
declared compressed byte; trailing compressed bytes do not change installed
content.

## Decision

Choose the focused installer port. It is the only option that meets the user's
framework ceiling while retaining the present package destinations and UI.
The safety margin over MSI is small, so the choice depends on strict parser
tests and rollback behavior. Both were demonstrated with an isolated install
of the current package; 76 installed files matched their ZIP entries by
SHA-256, 118 installer assertions passed on CLR 2, and a WinForms form smoke
test displayed and closed on CLR 2.

## Consequences

- Every managed project can be verified under CLR 2 / .NET 3.5.
- Unsupported ZIP variants are rejected; the canonical package remains the
  supported input.
- The installer requires the Windows .NET Framework 3.5 feature and loses its
  former self-contained .NET 8 launch behavior.
- Installer security and isolated installation tests become release gates.

## Decision Journal

**Date:** 2026-09-30. **Decision:** port the installer with a strict package
format contract.

- In 30 days, all three managed projects and their built artifacts still pass
  the .NET 3.5/CLR 2 release checks.
- In 90 days, canonical packages still install with byte-for-byte file parity,
  and malformed archives still fail before destination writes.

Review at the next package format or installer UI change. Reconsider native
MSI if the supported ZIP subset expands or rollback cannot be kept reliable.

## References

- [ADR 033](033-keep-installer-framework-migration-separate.md)
- [Refactoring plan](../../REFACTORING_PLAN_2026-09-27.md)
