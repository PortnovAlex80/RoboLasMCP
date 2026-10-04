# Free RoboLas on master with a native MCP agent contract

Date: 2026-10-01. Status: accepted implementation decision; product scope comes from the user's instructions.

## Context and drivers

The user requires one master branch, an entirely free product, removal of UC-23/24/27/28/30–35, correct RGB preservation (UC-38 is a defect), all plugin settings over MCP, actionable errors, scenario next steps, and an agent-harness-ready calculation pipeline. Current production code is authoritative. Personal local settings and research files must survive integration.

Native robur-mcp v0.1.0 source (24abd664a6201014c7730f2d7e3b8829ba5184de) registers attribute-based tools and calls each synchronously using CadView.Invoke. Its pipe serializes requests. ToolProvider has no supported dynamic schema hook. There are project/CAD tools but no alignment activation tool in this version: las_list_alignments/las_set_active_alignment extend the native bridge. We do not create a competing MCP server.

## Options and decision

Three independent read-only option briefs explored conservative native integration, metadata-first settings, and a minimal RGB/lifecycle path. A separate Red Team challenged the chosen hybrid.

Scores are 1–5; weighted criteria descend from existing SDK/threading, atomic publication and compatibility constraints.

| Option | Correctness .35 | SDK isolation .25 | Completeness/extensibility .20 | Cost .10 | Reversible .10 | Sum |
|---|---:|---:|---:|---:|---:|---:|
| Metadata catalog + native guarded tools + explicit synchronous lifecycle | 4 | 5 | 5 | 3 | 5 | 4.35 |
| Duplicate existing eight settings across UI/MCP | 2 | 5 | 2 | 5 | 5 | 3.25 |
| New async bridge and dispatcher immediately | 3 | 2 | 5 | 1 | 3 | 3.00 |

Choose the metadata/native hybrid. The catalog covers 29 writable RuntimeConfig preferences plus four 3D occupancy parameters; generated static schema is compared to runtime metadata. Validate the whole patch before writing anything, persist actual validated values, and capture settings consistently. Every own tool runs through one error/result contract including request examples, correlation, terminal outcome and next steps. Read-only capabilities/preflight/history support any harness consuming standard MCP JSON-RPC.

Keep native synchronous execution explicit. Stage/progress traces do not imply live polling or agent cancellation during a blocked native request. True async UI-capture/pure-worker/UI-commit remains a separate capability until implemented and exercised in a compatible host. UI cancellation already present remains cooperative.

RGB is not Vector4D.W: W is SDK byte-normalized intensity. Investigated LDAR v1 caches do not serialize RGB; this does not establish absence of colors in the entire loaded Robur cloud. A verified attribute-bearing host SDK API is required under the user's updated direction below. Do not fabricate RGB or claim color preservation from merely changing the output point format. Preserve staging, bounded memory, source validation and atomic publication when introducing color records.

For master, preserve its pre-integration tip under audit/master-before-free-20261001; merge the current authoritative free tree while preserving both histories, documenting superseded legacy changes. Do not rewrite history or force-push. Existing branch refs remain archival until a separate pruning decision.

## Pre-mortem and Red Team mitigations

* Catalog/schema drift: coverage/type/bounds parity tests and checked-in generated schema.
* Partial preference writes or mixed 3D snapshots: validate all fields first, shared lock, rollback, persistence roundtrip tests.
* UI-thread race disguised as async: capabilities advertise synchronous native transport and no live agent cancel.
* Retry after uncertain mutation: stable request_id, terminal operation lookup, explicit unknown apply state; no blind mutation retries in harness.
* RGB collisions/precision/source disappearance: retain record provenance when possible, reject conflicting joins, fingerprint sources, support black and 16-bit values without truncation.
* Master integration silently loses retained features: check actual entry points/build against the accepted registry; history inclusion alone is insufficient.

Native errors before a RoboLas provider is invoked (missing CadView, unknown tool, transport) cannot receive our correct_request envelope without changing native Robur. Document this boundary. Wrapper status=error is returned JSON, not automatically native MCP isError=true.

## Decision journal

Expectation: all currently exposed preferences roundtrip via get/set/persistence; removed commands cannot be discovered or compiled; each own error has a schema and syntactically valid corrective request; calculation responses have operation identity and terminal state. No unbounded point-attribute dictionary, hidden transport replacement or unreviewed SDK cross-thread access.

Check trigger: regression and release verification on the consolidated master, then native tools/list and E2E in a compatible Robur host.

### RGB source clarification and implementation record

**Superseded source direction, 2026-10-01:** The user explicitly requires working with the cloud already loaded by Robur. The source-LAS recovery direction in the historical notes below is withdrawn. The root `LidarBuffer.cs` example exposes `Colored`, `texture`, LDAR v2 and a `FindPoints` callback carrying `LidarPoint.Red/Green/Blue`; this file is not compiled and does not by itself verify the installed host API. Preserve the existing `ILidarBufferContainer.GetBuffer()` retrieval and first verify actual host versions, color storage and callback behavior against the local DLL corpus. The revised work sequence and acceptance criteria are in `docs/TOPOMATIC_TREE_RGB.md`. This is a clear product-scope correction mandated by the user, not a choice among implementation options. Existing uncommitted LAS mapping integration must be replaced before release; standalone RGB writer tests remain useful.

Decision journal update: expect UI/MCP operations to preserve attributes of loaded Robur records without searching source LAS files. Review trigger: a real colored cloud processed and reopened in the supported Robur host, with matching selected-record RGB and no additional user source selection.

The user clarified that RGB must automatically follow the loaded cloud; no manually configured color source. Read-only scan located both EASY files on D: and 17 RGB-format LAS files among 76 inspected under D:/Development. This scan supplies test fixtures only, never production source selection.

Three follow-up read-only reviews agreed that FileProxySourceProvider.FileName is the public retrieval candidate, while its protected controller body is a disk stub and does not prove runtime semantics. Installed LDAR v1 serializes XYZ/weights/tree, not colors; clrs capacity does not prove populated RGB. A post-sampling XYZ join is ambiguous and loses source identity.

Scores 1–5; weights: correctness .40, provenance .25, SDK compatibility .20, memory .10, cost .05.

| RGB approach | Correctness | Provenance | SDK | Memory | Cost | Weighted |
|---|---:|---:|---:|---:|---:|---:|
| Automatic provider/source binding + attributed record pipeline | 5 | 5 | 4 | 5 | 3 | 4.70 |
| Assume clrs alone contains original RGB | 2 | 5 | 2 | 5 | 5 | 3.20 |
| Scan drive and guess LAS/XYZ match | 1 | 1 | 3 | 2 | 3 | 1.60 |

Choose automatic binding and attributed records. Implemented active-provider metadata discovery, LasColoredPoint with source ordinal, bounded LAS RGB reader, format3 writer with staging/validation/publication and explicit refusal to manufacture/drop RGB. 826 reader/writer checks include 64 points from four real sources, black, duplicate XYZ with different colors, reorder, extended format7 and cancellation. This does not prove end-to-end loaded SDK cloud provenance; collector/filter/spool/split wiring remains outstanding and capabilities state that RGB preservation is not yet available in MCP exports.

Red Team constraints: never interpret protected FileName disk stub as a genuine null; verify actual getter in host; never choose a similarly named file; preserve original ushort channel values rather than guessing normalization; preserve record identity through sampling; detect source changes before publication. Master history consolidation completed with both parents retained; prior master remains tagged. No remote push or SDK installation performed.


### Native RGB bug fix following independent analysis

2026-10-01: User identified LidarBuffer.cs as source supplied by Topomatic developers and explicitly requested an independent subagent audit. The read-only native_rgb_audit found RGB lost by the collector's Vector4D projection and plain format1 writer. Implement native texture/legacy clrs reading by exact record index; remove LAS catalog/mapping code. Root source confirms byte RGB, LDAR v2, RGB-bearing LidarPoint callbacks. Mirror native local-space query boundaries/order. Preserve attributed records through selection, existing split first-wins dedup, spill and output. ASPRS normalization is byte << 8; intensity retains its existing independent conversion. Red Team review covered empty/black buffers, malformed Counts, mixed color availability, query rounding and source mutation. Source fingerprints and explicit refusal handle those risks. Native/source tests include compiled supplied LidarBuffer.cs LDAR v2 save/reload and existing DLL compatibility. No interactive UI E2E claimed. Decision corrects the user's explicit scope; review trigger remains native host acceptance with no external LAS input selection.
