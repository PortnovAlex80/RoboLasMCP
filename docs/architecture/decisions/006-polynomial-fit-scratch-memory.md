# 006. Bound polynomial fitter scratch memory

- **Status:** Accepted
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

`PolynomialSurfaceFitter.FitSurface` held an `n × p` design matrix and an
observation vector for `n` input points and `p ≤ 10` coefficients. The Plan
command also holds all input points and the output grid, so this fitter copy
increased peak memory without serving a later stage. The plan requires a
same-data memory comparison and preservation of geometry unless a behavior
fix is separately justified. This is a complicated numerical compatibility
decision.

## Decision drivers and options

Scores use 1–5 and the weighted sum shown below.

| Driver | Weight | A: one reusable basis row | B: streaming QR and normalization | C: fixed matrix chunks |
|---|---:|---:|---:|---:|
| Output regression risk | 5 | 5 | 1 | 5 |
| Fitter scratch memory | 5 | 5 | 5 | 4 |
| Numerical robustness | 4 | 2 | 5 | 2 |
| Implementation cost | 3 | 5 | 1 | 4 |
| Testability | 3 | 5 | 3 | 5 |
| Whole command memory | 4 | 2 | 2 | 2 |
| Reversibility | 3 | 5 | 2 | 4 |
| **Total** | | **111** | **76** | **100** |

A forms the same basis for each point, immediately adds it to the same upper
triangle of `A'A` and `A'z` in input, `j`, `k` order, and uses the unchanged
Cholesky solver and grid generator. B improves conditioning but changes
coefficients, regularization semantics, and often geometry. C retains a bounded
matrix but allocates more memory and needs chunk bookkeeping without improving
output compatibility over A.

## Pre-mortem and Red Team

- A different floating-point evaluation order changes output. Mitigation:
  retain the original `Math.Pow` loops, regularization initialization, and
  accumulation order; compare output bytes with the frozen old implementation
  for degrees 1–3 on ordinary and large-coordinate inputs.
- A misleading memory claim hides `allPoints` and the output grid. Mitigation:
  report only fitter scratch reduction; keep whole-command memory open.
- A caller mutates the input list concurrently. The old method first copied
  every row and Z; the fused pass reads a row immediately before accumulation.
  The Plan command owns its completed list, but concurrent public-API mutation
  is not covered by this decision.
- Large coordinates remain ill-conditioned and the grid count can overflow.
  These are separate numerical and bounds defects; do not silently change
  ridge behavior while removing the memory copy.

The Red Team found no stronger no-regression option. Its strongest objection
was the lost full-input snapshot. For the current command-private list this is
acceptable, but the public `FitSurface` concurrency contract needs explicit
testing or documentation if another consumer appears.

## Decision

Choose **A**. Remove `double[n,p]` and `double[n]`, reuse one `double[p]`, and
leave the solver, method signature, validation order, and output grid unchanged.
This bounds fitter scratch to `O(p²)`; it does **not** make the full Plan command
streaming.

## Verification and consequences

The original implementation at `8688cde` and the new one pass the same 174
.NET 3.5 fitter assertions. SHA-256 over every output XYZ double matches
bit-for-bit for degrees 1–3 on two mixed fixtures, including coordinates near
500,000/600,000. On this machine, for 250,000 points and degree 3, old peak
private-memory increase was 37.5–40.1 MB in two runs; the new increase was
8.6 MB in two runs. Old elapsed time was 380–393 ms; new time was 233–284 ms.
These are local smoke measurements, not a broad performance guarantee. The
source point list and output grid still scale with input/output size.

## Decision Journal

**Ex-ante expectations:** On the next representative LiDAR fixture, fitter
scratch stays independent of input point count, bitwise output matches the old
finite-input path for a fixed input order, and the complete Plan command may
still be limited by its input/output lists.

**Check trigger:** First isolated Topomatic large-cloud run or a reported
polynomial geometry difference. **Revisit if:** large-coordinate accuracy is
unacceptable or a real consumer mutates the input list concurrently.
