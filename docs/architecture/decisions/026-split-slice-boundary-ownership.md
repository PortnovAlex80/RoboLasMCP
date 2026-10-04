# 026. Half-open station slices for LAS split

- **Status:** Accepted; live split fixture remains required
- **Date:** 2026-09-29
- **Decision-maker:** primary agent, using the autonomous-decision skill

## Context

The split command collected 1 m slices with the legacy open test
`-halfBorder < distance < halfBorder`. A point exactly between two stations
therefore entered neither slice. Its lateral predicates also excluded points
exactly at `-leftOffset` and `rightOffset` from both output files. A fractional
alignment tail longer than half a slice was never visited. The user reported
missing points while cropping and saving new clouds.

## Options and MCDA

Scores are engineering estimates from 1 to 5. Weights emphasize data
correctness and avoiding changes to other LiDAR commands.

| Criterion | Weight | Global half-open slices | Split-only mode | Project all points to station |
|---|---:|---:|---:|---:|
| Correctness for the reported seam | 5 | 4 | 4 | 5 |
| Isolation from other commands | 5 | 1 | 5 | 4 |
| SDK contract confidence | 4 | 4 | 4 | 2 |
| Runtime and memory | 4 | 4 | 4 | 1 |
| Testability | 3 | 4 | 5 | 2 |
| Implementation cost | 2 | 5 | 4 | 1 |
| Future extension | 3 | 2 | 3 | 5 |
| **Weighted total** | | **85** | **109** | **80** |

The global change is small but alters reduction and ground collection.
Projection could assign each point uniquely on curved alignments, but changes
the collection algorithm, order, limits, and performance substantially. It
requires a separate prototype and live performance comparison.

## Pre-mortem and independent Red Team

The leading split-only option can fail if the SDK `FindPoints` excludes an
exact bounding-box edge before the predicate sees it. Split search boxes are
expanded slightly, while final membership remains exact. A focused test uses
an open-box SDK stub. The installed Rail 16 SDK still needs a controlled point
fixture to verify this behavior.

On curves, neighboring normal strips may overlap or leave wedge-shaped gaps.
Their transverse coordinate can also differ, so the same source point could
enter both output files. Per-output exact-XYZ dedup does not prove the two
files disjoint. Negative indexer scale and reversed section direction remain
host-test cases. The repo's `LidarBuffer.cs` is not compiled into the plugin
and cannot establish installed SDK behavior.

The Red Team also found the terminal tail and the distinction between DTM
collection width and user classification offsets. The former is covered by a
terminal station when needed. The latter is preserved as the existing command
contract: user offsets classify points within the DTM collection corridor.

## Decision

Use `-halfBorder < distance <= halfBorder` only when the split command sets
`LasFilterOptions.IncludePositiveSliceBorder`. Keep the open test as the
default. The serial and OnePass collectors share one membership predicate.
Split includes lateral cutoffs in the center output, making center and edge
predicates complementary for finite coordinates. When a fractional alignment
tail reaches or exceeds half a slice, add a station at the actual endpoint.

## Verification and decision journal

The collection fixture checks exact seams, XYZ/W order, first-weight dedup,
and an SDK stub with open bounding-box edges. OnePass tests cover split mode
with positive and negative indexer scales. Command tests pin complementary
lateral classification, finite offsets, and fractional terminal stations.

**Ex-ante expectation:** for a straight alignment, finite points inside the
DTM corridor and covered station range appear in exactly one of the two LAS
outputs at 100% retention, including exact lateral and longitudinal cutoffs.

**Revisit trigger:** a live Rail 16 fixture shows a missing or duplicated
point at a seam, a bent alignment produces material cross-file overlap, or
the SDK's broad-phase selection differs from the open-box test.
