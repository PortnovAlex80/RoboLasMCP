# ADR 033: Keep the installer runtime migration separate from the plugin refactor

Status: Superseded by ADR 034 (2026-09-30).

Date: 2026-09-30

## Context

Topomatic loads `LAS_TERRAIN.dll`, whose project targets .NET Framework 3.5.
The separate `RoboLasInstaller` executable and its tests target .NET 8.
The user requested a check across the whole project, so repository-wide
.NET 3.5 compatibility cannot be claimed.

The installer uses .NET 8 ZIP and WinForms APIs, async/Task, and a
self-contained single-file publish. Its archive preflight rejects unsafe
paths and duplicate destinations before writing. Changing only its target
framework would break compilation and could weaken those protections.

## Decision drivers

- Topomatic must load the plugin under CLR 2 without a newer framework.
- Installer extraction safety and the existing distribution path must hold.
- The repository-wide exception must remain visible until it is removed.
- A framework migration needs its own build and install acceptance evidence.

## Options considered

| Option | Host compatibility (30%) | Installer safety (30%) | Repository-wide ceiling (25%) | Delivery cost (15%) | Weighted score / 5 |
|---|---:|---:|---:|---:|---:|
| Keep separate installer and report the exception | 5 | 5 | 1 | 5 | 4.00 |
| Port installer and tests to .NET 3.5 | 5 | 2 | 5 | 1 | 3.50 |
| Replace installer with native MSI | 5 | 2 | 5 | 1 | 3.50 |

Scores describe the immediate refactor gate, not a waiver of the user's
repository-wide requirement. The latter remains unmet. A .NET 3.5 port
preserves the current installer workflow but needs a CLR2-compatible ZIP
implementation and revised packaging. Native MSI removes the managed
installer runtime but needs a new toolchain and upgrade/rollback tests.

## Decision

Keep the currently tested installer unchanged during the plugin refactor.
Enforce the .NET 3.5 ceiling on the Topomatic-loaded DLL with the release
verifier, and report the .NET 8 installer and test projects as explicit open
work. Do not describe the entire repository as .NET 3.5 compatible.

## Consequences and pre-mortem

The plugin's host compatibility is independently verifiable, while the
repository-wide ceiling remains open. If this decision fails later, likely
causes are: the exception is omitted from release notes; an installer library
is linked into the plugin; the installer stops receiving security fixes; or
a rushed retarget bypasses ZIP preflight. The release verifier checks DLL
references, this record names the exception, and any installer migration
must preserve extraction safety tests and exercise an isolated install root.

Red-team review found that the user's literal wording includes the
installer. That objection stands: this ADR records an incomplete
repository-wide requirement, not a claim that separate processes satisfy it.

## Decision journal

Expectation: subsequent plugin releases continue to pass the CLR2/.NET 3.5
verifier, and the installer remains explicitly listed as an exception until
its migration is complete. Review at the next release/package gate.
