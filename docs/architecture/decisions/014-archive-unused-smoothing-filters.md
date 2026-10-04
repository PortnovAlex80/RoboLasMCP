# 014. Archive unused smoothing filters outside the production DLL

- **Status:** Accepted; unknown external reflection consumers remain a risk
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context and decision drivers

The boundary checker reported 16 remaining Domain violations, all in three
legacy smoothing files. Repository-wide production call-site search found no
call to their `Apply` methods or helper classes. The active
`FilterAggregator` calls `RobustGroundSplineFilter` or
`MinWeightedGroundLevelMedianFilter`. Only the .NET 3.5 characterization
suite calls `SmoothingSplineFilter`. The three classes are internal and
have no serialization annotations or command attributes. The persisted
`csplineSmooth` preference still feeds the active robust spline.

The drivers are preserving production results, enforcing the Domain boundary,
keeping historical tests, maintenance cost and reversibility.

## Considered options

Scores are weighted engineering estimates on a 1–5 scale.

| Driver | Weight | A: archive outside DLL | B: refactor unused filters | C: leave compiled |
|---|---:|---:|---:|---:|
| Production behavior | 5 | 5 | 4 | 5 |
| Dependency boundary | 5 | 5 | 5 | 1 |
| Maintenance | 4 | 5 | 3 | 1 |
| Reversibility | 3 | 5 | 4 | 5 |
| Testability | 3 | 4 | 5 | 1 |
| Implementation cost | 3 | 5 | 2 | 5 |
| **Weighted total** | | **112** | **90** | **67** |

A moves the source into `tests/LegacyAlgorithms`; only the historical
`SmoothingSplineFilter` is compiled by characterization tests. B would
introduce immutable options and explicit overloads to all three, preserving
unused algorithms in the plugin at a larger implementation and test cost.
C keeps the 16 violations and stale mutable state.

## Pre-mortem and Red Team

- A hidden external tool reflects an internal type. The repository has no
  such use, but a binary-only tool cannot be excluded. The source remains in
  git and can be restored to the project file.
- Moving the old spline breaks one of two .NET 3.5 test entry points. Both
  runner paths are updated and both runners pass without changing the fixture.
- Removing the CSpline class accidentally removes the stored smooth setting.
  `RuntimeConfig.CSplineSmooth`, the `csplineSmooth` key, UI binding and
  active robust-spline snapshot remain in production and pass adapter tests.
- Documentation still describes CSpline as active. The current guidance is
  corrected; long historical diagrams are marked as historical.

The independent Red Team found no production call but highlighted reflection,
the two test scripts and documentation. Keeping source outside the DLL
mitigates reversibility; tests and guidance address the concrete failures.
No evidence justifies retaining mutable, unused code in the production DLL.

## Decision and consequences

Choose A. Exclude all three legacy filters from the project and place their
sources under `tests/LegacyAlgorithms`. Keep the historical
`SmoothingSplineFilter` characterization, with no numerical changes. The
active filter chain and preference storage stay intact.

The copied Rail 16 Release build, full .NET 3.5 suite, standalone
characterization suite (31 scenarios), filter-chain baseline (131 checks),
production-DLL snapshot adapter (1026 checks) and boundary checker pass.
The boundary checker now reports zero violations. No live GUI behavior is
claimed from these checks.

## Decision Journal

**Ex-ante expectation:** removing the internal types does not change command
registration or numerical output; historical spline results remain stable;
no new production caller requires these archived implementations.

**Check trigger:** next host acceptance run, any new smoothing feature, or a
reported reflection integration that names one of these internal types.
