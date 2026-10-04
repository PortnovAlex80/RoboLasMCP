# Topomatic Robur Rail 16.0 — Reverse-Engineering Master Report

**Date:** 2026-06-14
**Analyst:** Claude (glm-5.2), via decompilation (ilspycmd 8.2.0) + multi-agent deep analysis
**Scope:** Fresh analysis from scratch — all 4 fronts (Performance, Unused API, Integration Correctness, Architecture Patterns) × full sweep of `Topomatic.*.dll`
**Sources decompiled:** 189/189 DLLs from `C:\Program Files\Topomatic Robur Rail 16.0\` (corpus is COMPLETE — verified 2026-06-18; earlier "179/189" was a stale count, see Appendix A)
**Prior analysis status:** SUPERSEDED. All prior `docs/topomatic-api-catalog/` work was signature-only (PowerShell reflection). Every behavioral claim about Topomatic internals was inference. This report converts inference into decompiled facts.

---

## Executive Summary

**Headline:** Past analyses (GLM-5.1 and weaker) were working from method *signatures* only — they never read a single line of Topomatic method body. Several of their highest-confidence claims are **wrong in mechanism** (sometimes wrong in conclusion). Decompiling the real bodies overturns 3 myths, surfaces **1 latent correctness bug**, confirms **4 real bugs**, and identifies **~10 unused APIs worth adopting**.

### What changed vs prior analysis

| Prior claim | Status | Reality (decompiled) |
|---|---|---|
| "Surface.EndUpdate() = O(n log n) full Delaunay, 60× for 3M pts" (P1-6) | ❌ **REFUTED** | `UndoObject.EndUpdate` does NO triangulation — undo bookkeeping + event only (`FoundationClasses.cs:9272-9309`). |
| "ArrayMode.Polygon → 10-100× rendering speedup" (GRAPHICS guide) | ❌ **REFUTED** | `ArrayMode.Point` is already a single GPU `glDrawArrays(GL_POINTS)` (`Cad.Foundation.cs:45953-45969`). Polygon = filled triangles (wrong + slower). |
| "Adopt CrsSurfaceBuilder/ICrsBuilder" (audit/02) | ❌ **REJECTED** | Design-template lofting (red-line), not LiDAR→TIN. Wrong domain. |
| "Commands registered via SectionCmdAttribute/SectionRegistry" (CLAUDE.md) | ❌ **WRONG** | Those are OUR internal layer. Real mechanism: `[cmd]` attribute reflection in `PluginInitializator.Initialize` + `LAS_TERRAIN.plugin` manifest (`ApplicationPlatform.cs:19352-19372`). |
| "PointIndexer.Update = O(n log n) QuadTree rebuild" | ❌ **REFUTED** | O(n), parallelized 8×8 uniform grid (`Sfc.cs:13549-13682`). |
| "Sections.Clear() destroys user CRS data" (audit/02) | ✅ **CONFIRMED** | `Alg.cs:20206` — no backup, drops Section objects with StaticEg/SectionLine. |
| "FastSurfaceBuilder is correct & optimal" | ⚠️ **PARTIAL** | Insert path is optimal (no per-point cost). BUT leaves **empty triangle array** → latent correctness hole. |

---

## §1. Critical Findings (P0)

### C1. `FastSurfaceBuilder` leaves Surface with empty/stale triangle array — LATENT CORRECTNESS BUG

**Evidence chain (VERIFIED):**
- `FastSurfaceBuilder.cs:38-59` sets `Style.Dynamic=false`, calls raw `surface.Points.Add(...)` (→ `SurfacePointArray.Add`, `Sfc.cs:23705-23727` = plain `InnerList.Add`, no triangulation), `PointIndexer.Invalidate()`, single `BeginUpdate/EndUpdate`.
- Triangulation is gated: `if (!point.IsSituation && surface.Style.Dynamic) SurfaceTools.AddPointToTriangulation(...)` (`Sfc.cs:13948-13951`). With Dynamic=false, **never runs**.
- `UndoObject.EndUpdate` does NOT triangulate (`FoundationClasses.cs:9272-9309`).
- The lazy-rebuild rescue is FALSE: `SurfaceLayer.OnPaint`'s `ConnectPoints` branch is gated on `HasUnconnectedPoints` (never set by raw `Add`); grep of `Sfc.Layer.cs` for `BuildTriangles|EnsureTriangles|RebuildTriangles|Triangulate` → **0 hits**. `TriangleIndexer.Update` only bins EXISTING triangles into an 8×8 grid — with empty `Triangles`, `FindTriangle` returns -1, `GetElevation` returns null.
- Real triangulator = `DynamicCachedBuilder` (Bowyer-Watson incremental), `Cad.Foundation.cs:74248`. NOT `ActiveRibsBuilder` (that is only a constraint-edge stitcher at `:73466`).

**Result:** After our bulk insert, `surface.Points.Count == N` but `surface.Triangles.Count == 0`.

**Consumer audit — all "insert-and-forget" (no query today):**
- `SectionBaseUseCase`, `CalculateSectionAsyncWithZLoupeUseCase`, `BuildFullCloudBoundsMvp`, `PlanPolygonGrid/PolynomialSurfaceUseCase` — only call `CadView.Invalidate()` / show MessageDlg. None call `GetElevation`/`FindTriangle`/`SaveToFile`.
- Only `VerticalPlanningByContourStubUseCase.cs:68` calls `surface.Regen()` — and that path doesn't use FastSurfaceBuilder (and `Regen` only rebuilds indexers, not triangles).

**Severity:** HIGH (latent). Will silently return garbage/null the moment any tool queries elevation/contour on these surfaces.

**Fix options (.NET 3.5):**
1. After bulk insert, build triangles explicitly via `new DynamicCachedBuilder().Build(nodes, triangles)` (public, `Cad.Foundation.cs:74248`) → push into `surface.Triangles` via `TriangleEditor` under one `BeginUpdate/EndUpdate`. One O(n log n) pass.
2. Or insert via `PointEditor` with `Dynamic=true` (incremental triangulation per point) — heavier, undo-friendly.
3. Or push a single `IrreversibleCommand` (`Sfc.cs:19659`) to mark the bulk transaction non-undoable + call `Regen`.

> **Adversarial caveat:** claim 5.5/6 — the "empty forever globally" framing is only proven for the cited scope (Sfc + 4 methods). Full certainty needs the draw/Regen/proxy path in layer assembly. But every consumer audited does NOT trigger it, so today it is latent regardless.

---

### C2. `Sections.Clear()` is DESTRUCTIVE — destroys user CRS design data (7 call sites)

**Evidence (VERIFIED, adversarially confirmed):**
- `SectionList.Clear()` (`Alg.cs:20206`): bare `.Clear()` on backing `TransactableList<Section>` — no backup.
- `SectionList.Add(double station)` (`Alg.cs:20175-20185`): `new Section(this, id++, 0u, station)` — `ConstructionId=0u` (EmptyConstructionId sentinel, `:18669`), `StaticEg=null`, `SectionLine=null`, `Underlay=null`.
- User data lives ON the Section: `StaticEg` (`Alg.cs:19739`), `SectionLine` (`:19760`), `ConstructionId` (`:19776`), `Drawing Underlay`.
- `IsProject == (SectionLine == null)` (`:19778`) — fresh Add()'ed sections are implicitly "project" mode; user static line is gone.
- Consumer of these fields: corridor design builder `BuildTemplate` (`Alg.cs:18961-18964`) passes `section.StaticEg`/`section.SectionLine` → after our Clear+Add, both null → rebuilds with no user data.

**Destructive call sites (7):**
- `Services/SectionBaseUseCase.cs:211,216`
- `UseCases/CalculateSectionAsyncWithZLoupeUseCase.cs:144,149`
- `UseCases/SplitLasByOffsetUseCase.cs:33,35`
- `UseCases/ReduceWithGroundRedSectorUseCase.cs:38,40`
- `UseCases/ReduceLasAsyncToPercentUseCase.cs:39,41`
- `Testing/Remoting/LasTerrainTestService.cs:418,423`
- (also `ReduceLasAsyncToPercentPolygonUseCase.cs` — pattern match)

**Fix — non-destructive patterns (.NET 3.5):**

Option A (preferred — don't touch Sections at all):
```csharp
var stations = new List<double>();
AlignLibrary.MakeWholeStations(alg, 0.0, alg.Plan.CompoundLine.Length, step, stations, false);
// then pass stations to collectors; collectors only need section.Station
```

Option B (canonical merge idiom from Topomatic's own `MergeCrossSections`, `Alg.cs:34252-34270`):
```csharp
using (alg.Corridor.Sections.BeginUpdate()) {      // collapse into ONE undo unit
  foreach (double s in stations) {
    int idx = alg.Corridor.Sections.Add(s);         // idempotent on station (returns existing idx)
    var sec = alg.Corridor.Sections[idx];
    // set properties — NEVER assign CrsLine by reference; always clone: new CrsLine(src)
  }
}  // EndUpdate in finally
```

**Adversarial nuance:** `Add(station)` does NOT clobber an EXISTING section at that station (BinarySearch ≥0 → returns existing idx untouched). Destruction is specifically from the `Clear()` that precedes. Drop the `Clear()` → bug gone.

---

### C3. `Topomatic.FoundationClasses.Parallel.ForEach` deadlock hazard (7 of our call sites unguarded)

**Evidence (VERIFIED, adversarially confirmed):** `FoundationClasses.cs:13720-13724` — work-item body is `action((T)i); waiter.Signal();` with NO try/catch. On throw, `Signal()` is skipped → counter never reaches target → `ManualResetEvent.Set()` never fires → `waiter.Wait()` blocks forever. The waiter helper (`:13644-13648`) has no exception-collection field; `ForEach` body has no post-Wait rethrow. So BOTH the deadlock AND the "store-and-rethrow" mitigation are absent.

**Our unguarded sites:**
- `Services/GroundPointsCollector.OnePass.cs:148-213` — hand-rolled `Thread[]` pool, NO try/catch in lambda → throw silently kills one worker, `Join()` doesn't rethrow, returns "success" with missing results. **Worst.** Also no `CancellationPending` check.
- `Services/RawPointsCollector.cs:113-117` — holds `localLock` while invoking `onProgress.Invoke(...)` → stalls all workers if callback slow.
- `Domain/Filters/GraphGround3DFilter.cs:127/132, 173/175` — NESTED `Parallel.ForEach` → ThreadPool starvation.
- `Services/GroundPointsCollector.cs:120` — `TooManyPoints` read without `volatile`/`Interlocked` (racy early-abort; not correctness).
- All 7 `Parallel.ForEach` sites lack try/catch.

**Fix (.NET 3.5):**
```csharp
Exception firstErr = null;
Topomatic.FoundationClasses.Parallel.ForEach(items, item => {
  try { /* work */ }
  catch (Exception ex) { Interlocked.CompareExchange(ref firstErr, ex, null); }
});
if (firstErr != null) throw firstErr;
```
Plus: flatten nested ForEach; move `onProgress` out of `localLock`; add `CancellationPending` checks.

> **Note:** transactions are NOT thread-safe either (`bare int++` on counter, `FoundationClasses.cs:25864`). Our `BeginUpdate/EndUpdate` are all on UI thread — "correct by accident." Never move surface edits to worker threads without marshalling to UI.

---

### C4. `OnGetLimits` returns `false` on all 3 overlay layers — breaks zoom-to-fit

**Evidence (VERIFIED):** `CadView.SolveLimits` (`Cad.View.cs:24232-24273`) aborts entirely if `PerformGetLimits` returns false. Aggregate path (`Cad.View.cs:48945-48963`) SKIPS any layer returning false. Our 3 layers hardcode `return false`:
- `CrsOverlayLayer.cs:69-87` (real-bounds code is COMMENTED OUT at `:75-86`!)
- `CrsOverlayCrossLayer.cs:300-304`
- `PlanOverlayLayer.cs:188-192`

**Impact:** layer never contributes to "show all" / zoom-to-fit; if it's the only layer with data, framing aborts → user sees nothing. Rendering (`OnPaint`) is NOT gated by OnGetLimits (so draws still work).

**Fix:** uncomment/re-enable the real-bounds computation, return `true` when non-empty:
```csharp
protected override bool OnGetLimits(out BoundingBox2D lim) {
  if (_points.Count == 0 && _poly.Count == 0) { lim = BoundingBox2D.Empty; return false; }
  var box = new BoundingBox2D();
  foreach (var p in _points) box.AddPoint(p);
  foreach (var p in _poly) box.AddPoint(p);
  lim = box; return true;
}
```

---

## §2. Performance Findings

### P1. `FindPoints` allocates closure + fresh List per buffer × per section — P0
`LasSectionPointsCollectorService.cs:127-142`: `var pts = new List<Vector4D>(); buffer.FindPoints(box, pt => {...});` per buffer per section. 1000 sections × 3 buffers = 3000 closure + list allocations. The ENGINE itself (`Lidar.cs:5076`) allocates nothing — all on our side.
**Fix:** hoist `pts` out, `pts.Clear()` per iter; cache the `Action<Vector4D>` delegate as a field; eliminate closure.

### P2. Global-AABB `FindPoints` degenerates quadtree to full scan — P0
`full_cloud_bounds_mvp.cs:118,246,298,357`: passes the whole-cloud AABB → broad-phase `Contains(box)==Disjoint` (`Lidar.cs:5100`) never rejects → every leaf visited → O(N) per indexer with redundant per-point Contains.
**Fix:** bypass `FindPoints` for whole-cloud ops — walk `indexer.points.GetBuffer()` directly (pattern already in `PlanDeletePointsUseCase.cs:126-159`, `CrsDeletePointsUseCase.cs:192-254`, `PlanPolygonGridSurfaceUseCase.cs:246-294`).

### P3. `RemoveDuplicatesByXYZ` uses string keys — P1
`RawPointsCollector.cs:130-141`: `HashSet<string>`, million strings for million points. Sibling `GroundPointsCollector.cs:162-187` already packs X/Y into `ulong` (no strings).
**Fix:** port the int-packing approach.

### P4. No indexer-level AABB pre-cull before `FindPoints` — P1
`LasSectionPointsCollectorService.cs:88-105`: per-section box passed to every indexer; only per-leaf Contains rejects.
**Fix:** cache each indexer's root world-AABB once; `if (!rootBounds.Intersects(sectionBox)) continue;` before FindPoints.

### P5. `Corridor[i]` indexer builds a `CrsDesignContext` on EVERY access — P1
`Alg.cs:18934,18943`. Used at `LasSectionPointsCollectorService.cs:111-112`. `OnePass` already gates this behind `EnablePrecomputeNodeContours` (correct mitigation). Don't call per-point; only per-section when the map is genuinely needed.

### P6. Per-section `OrderBy(n => n.X).ToList()` reallocates — P2
`LasSectionPointsCollectorService.cs:121`. Use in-place `Sort`.

### P7. Layer loops lack `PaintTerminate` chunking → UI freeze on large sets — HIGH
`CrsOverlayLayer.cs:62-64`, `CrsOverlayCrossLayer.cs:116-118,146-148,291-294`, `PlanOverlayLayer.cs:129-133`. Topomatic's own surface point layer (`Sfc.Layer.cs:22366-22385`) chunks every ~100 verts via `EndArray/BeginArray` + `if (pen.PaintTerminate) break;` for cooperative cancellation.
**Fix:** add the chunk loop; it increases draw-call count by N/100 but lets the view abort mid-frame.

### P8. `pen.DrawLine` in a loop is NOT batched — MEDIUM
`CrsOverlayLayer.cs:51-53`, `CrsOverlayCrossLayer.cs:135-137`, `PlanOverlayLayer.cs:117-121`. Use `pen.DrawArray(list, ArrayMode.Polyline)` (single GPU LineStrip) or `BeginArray/Vertex*/EndArray(Polyline)`.

---

## §3. Verified Topomatic Internals (facts that replace inference)

### Triangulation
- **Real triangulator:** `DynamicCachedBuilder` (`Cad.Foundation.cs:74248`) — incremental Bowyer-Watson with edge-flip. Complexity O(n log n) avg / O(n²) worst (degenerate ordering). **float precision** (not double) in the incircle predicate (`:74763-74795`). Flip worklist capped at 2000 iters (`:74814`).
- `ActiveRibsBuilder` (`:73466`) is NOT the triangulator — it is a constraint-edge stitcher (advancing-front, cosine-similarity), invoked once inside `DynamicCachedLimitationBuilder.Build` (`:75667`).
- `Node` = 9B (float X/Y + bool), `Triangle` = 24B, `Edge` = 12B. 3M pts → ~150-200MB working set for triangulation.
- **No native triangulator.** All `[DllImport]` in Sfc/Cad.Foundation are kernel32 (license/DRM) + freetype/ImageProvider (fonts/tiles). Fully managed C#.
- `PointIndexer.Update` / `TriangleIndexer.Update`: O(n), **parallelized** 8×8 uniform grid (NOT quadtree, NOT O(n log n)).

### Transactions / Undo
- `UpdateLoop.BeginTransaction()` = pure alias for `BeginUpdate`/`EndUpdate` (`FoundationClasses.cs:25923-25935`).
- `UndoObject.BeginUpdate` opens empty parented `Transaction`, no snapshot (`:25854-25866`).
- Undo = **Command pattern, not memento**. `ICommand.Undo()` returns inverse (`:9321-9324`). `Transaction.Undo()` reverse-walks children.
- Only the OUTERMOST `EndUpdate` commits to undo stack (`:25622`). Inner closes = pure grouping.
- Non-undoable command POISONS the entire history (clears redo, may clear undo) (`:25650-25658`).
- Default history limit 64 transactions.
- **NOT thread-safe** — bare `int++`/`int--` on counter.
- `PointEditor.Add` (`Sfc.cs:13928`) = per-point `BeginUpdate/EndUpdate` + per-point `<AddPointCmd>` (~40B, holds surface ref + int index, NO vertex snapshot). For 3M pts in one transaction → ~144MB undo overhead, dominant risk is TIME (`Transaction.CanUndo` iterates all N).
- **Implication:** bypassing `PointEditor` for bulk (our `SurfacePointArray.Add` path) is correct for bulk loads.

### Plugin loading contract
- `PluginHostInitializator` (`ApplicationPlatform.cs:19191`): `protected abstract Type[] GetTypes()`; `public virtual Initialize(PluginFactory)` iterates types, `Activator.CreateInstance` (parameterless) + `child.Initialize(factory)`. No try/catch → child throw aborts remaining. No caching inside base.
- `PluginInitializator.Initialize` (`:19352-19372`): reflects over own methods for `[cmd(...)]` attributes → `factory.RegisterFunction(cmd, PluginFunction)`. License-guarded early-exit.
- `cmdAttribute` invocation unwraps `TargetInvocationException` → our exception surfaces (`:19261-19268`).
- `PluginFactory` is ABSTRACT; real backing store in host EXE (not in corpus). Only `PluginFactoryWrapper` (decorator) present. We call ZERO `Register*` methods — we rely entirely on `[cmd]` reflection + `LAS_TERRAIN.plugin` manifest.
- `ApplicationHost.Current` = static service locator (`:4584`). Pattern: `ApplicationHost.Current.Plugins/.ActiveProject/.Settings/.MainForm`.
- `.plugin` manifest discovery = UNKNOWN (host EXE). Format (from our manifest): `{"assemblies": {"Name": {"assembly": "dll, FullyQualifiedHostType"}}, "actions": {id: {cmd,title,icon}}, "menubars", "rbcrs", "toolbars", "panels", "ribbon"}`.

### Geometry kernel (Cad.Foundation)
- `Vector2D/3D/4D`: all `struct` (NO boxing). `LengthSquared`/`DistanceSquared` everywhere (avoid sqrt). `Dot`/`Cross` available.
- **Gotchas:** `Vector4D.Length()`/`LengthSquared()` are METHODS (not properties like 2D/3D). `Vector2D` has no `Zero` (use `Empty`); `Vector4D` has `Zero` (inconsistent). No `<`/`>` operators on vectors.
- `BoundingBox2D`: struct; `CreateFromPoints` single-pass (`:5273`); `Contains(point)` has 1e-6 epsilon (on-edge counts inside); `operator +` = union; `operator *` returns ContainmentType enum (NOT a box — footgun).
- `CadLibrary.PosInPolygon(point, polygon, checkBorder)` (`:18457`): ray-casting. `checkBorder:false` for perf (true = O(n) with 3 sqrt/edge).
- `Line2D.SectLines` (`:50528`): line/line intersection (Cramer's rule, throws on near-parallel). `TrySectLines` non-throwing.
- `CadLibrary.OffsetPolygons`/`PolygonsIntersection` (Clipper-backed), `PolygonOverlay.PosStrictlyInContour` family — robust polygon ops we hand-roll instead.
- **NO spatial index** in Cad.Foundation (no `FindPoints`). Only in `Lidar.QuadTreeIndexer`.

### LiDAR (Lidar.cs)
- `FindPoints(BoundingBox2D, Action<Vector4D>)` (`:5076`): tight quadtree walk, allocation-light on engine side. Callback receives fresh world-space `Vector4D` (X,Y,Z,W=byte-weight/255).
- `QuadTreeIndexer`: bucket capacity **128** (`:5278`), split on >128; termination by cell size <0.001 (`:5455`), NOT depth cap.
- `ChunkedArray<T>`: 32M elements/chunk (`:4557`). `PointDataRecord` struct ~20B (int x,y,z; uint weight; byte classification).
- Build is EAGER + PARALLEL (one raw `Thread` per chunk, `:4741-4759`). NO incremental edit API — every mutation = full rebuild.
- `clrs` RGB buffer exists (`:5286`) but our `LidarBufferWriter` doesn't populate it → free visualization signal unused (UNKNOWN if production-built buffers have it).
- `LiDAR` facade: no filtering/classification/thinning API. Confirmed empty.

### Alignment / Corridor / Section (Alg)
- `CompoundLine.Length` = **O(1)** cached (`Cad.Foundation.cs:37245`).
- `PlanLine.CompoundLine` getter: cheap steady-state (2 bool-flag checks); full re-solve only after edit.
- `StaOffsetToPos(sta, offset)` per-point safe (O(log items) BinarySearch).
- `SectionList.IsExist/GetIndex/GetIndexLess/GetIndexMore`: O(log n) BinarySearch, one throwaway `Section` key alloc per call (per-station, fine).
- `Stationing.Stations` is **[Obsolete]** + allocates `new List<double>()` per call (`Alg.cs:17248`) → use `FillWholes(buffer)`.
- `Alignment.Profile` does NOT exist — elevation data lives on `Transition` (`.EgProfile`/`.RedProfile`/`.StaticEg`/`.DynamicEg`).
- Events: `SectionList.AfterInsert/BeforeRemove` (thread-safe, structural only); `Alignment.SettingsChanged`; `CadView.AuxiliaryDraw`; `AlgLayer.BeforeAlignmentChange/AfterAlignmentChange`. No `Alignment.Changed +=`. No per-section content-change event.
- `ActiveAlignmentReciver<T>.CreateReciver(false)` acquires read/write lock + forces alignment active (`Alg.Runtime.cs:31028-31163`). Correct pattern; the bug is what we do after (Clear+Add).
- `AlignLibrary.MakeWholeStations` (`:52797`) = non-destructive, canonical station builder. `ScanCrossDtm` (`:52200`) = read-only surface ground sampler. `MakeStations` (`:52844`) = full builder (overkill for us).

---

## §4. Unused API Opportunities (Top 10, ranked)

| # | API | DLL:location | Payoff |
|---|---|---|---|
| 1 | `SurfaceSectByContour` | Extensiones.Controller `:32581` | Breakline-preserving polygon slice of Surface — upgrades our clip from "discard breaklines" to "preserve topology" |
| 2 | `CadLibrary.OffsetPolygons` | Cad.Foundation `~58840` | Clipper-based polygon offset; replace hand-rolled buffer/offset |
| 3 | `PolygonOverlay.PosStrictlyInContour` family | Cad.Foundation `~59868` | Robust point-in-polygon (border/degenerate/winding) — kills P2 O(n·m) ray-casting |
| 4 | `WaitProgress.BeginProgress`/`WaitForProgress` | Controls `:41754` | Platform progress+cancel; resolves P3 #12 blocking modal; free `OperationCanceledException` |
| 5 | `AreaBetweenSurfacesCalculator.Execute` | Sfc `:27550` | 3D cut/fill volume between two TINs; enables volume reporting |
| 6 | `SurfaceTools.MergeSurfaces` | Sfc `:25892` | Two-surface blend with Z-averaging for embankment merging |
| 7 | `CadLibrary.PolygonsIntersection` | Cad.Foundation | Clipper-backed polygon∩polygon |
| 8 | `[cmd("lidar_surface")]`, `[cmd("lidar_adddtmlayer")]` | Lidar.Controller | Official Topomatic command names for cloud→TIN / DTM-layer interop |
| 9 | `PointDataRecord.classification` byte | Lidar `:5264` | Direct LAS classification access (ground=2, veg=3-5) |
| 10 | `BoundingBox2D.AddPoint` / `CreateMerged` | Cad.Foundation `:5314,5235` | Replace manual min/max bbox loops (13 sites identified) |

---

## §5. Confirmed ABSENT APIs (Robolas owns these forever)

- **GPU / OpenCL / CUDA / compute** — none outside rendering shaders. For Intel Arc 140T, bring ComputeSharp/ILGPU/OpenCL yourself.
- **Point cloud thinning / decimation / downsampling / voxel grid** — zero matches.
- **LiDAR ground filtering / classification / vegetation / noise** — `ClassifyPoint` in Cad.Foundation is CAD-region (in/out/on-edge of Shell), NOT LiDAR. Our `Domain/Filters/` is the only ground-classification.
- **Spatial indexing** beyond `LidarBuffer.QuadTreeIndexer` and `Sfc.Quadtree` — none.
- **LAS/LAZ/E57/PLY reader/writer** outside `Topomatic.Lidar` — none. Our `LasStreamWriter` is the only writer.
- **TIN mesh simplification / edge collapse / decimation** — `Tools.SimplifyFaces/Edges` operate on `Shell` (CAD solid), not TIN.
- **Standalone contour/breakline builders** — none; contours via `SurfacePatch.GetContours`, breaklines via `Surface.StructureLines.Add`.
- **General CancellationToken / TaskRunner** — none; cancellation is cooperative via `WaitProgress` → `OperationCanceledException`.

---

## §6. Adversarial Verification (independent skeptic, 5.5/6 survived)

| # | Claim | Verdict |
|---|---|---|
| 1 | `UndoObject.EndUpdate` does NOT triangulate | ✅ CONFIRMED |
| 2 | Dynamic=false → Add is O(1), no triangulation, triangle array stale | ⚠️ PARTIALLY (per-method solid; "empty forever globally" needs draw/Regen path) |
| 3 | `Sections.Clear()` destructive; `Add` creates empty Section | ✅ CONFIRMED (nuance: Add returns existing idx if station present — doesn't clobber) |
| 4 | `MakeWholeStations` non-destructive | ✅ CONFIRMED |
| 5 | `Parallel.ForEach` naked-action deadlock hazard | ✅ CONFIRMED |
| 6 | `ArrayMode.Point` = single `DrawUserPrimitives(PointList)` | ✅ CONFIRMED |

**Net:** 0 refuted. All cited line numbers held up under grep.

---

## §7. Prioritized Roadmap

### P0 — Correctness & data-loss (do first)
1. **Drop `Sections.Clear()` + adopt `AlignLibrary.MakeWholeStations`** (C2) — 7 call sites, destroys user CRS data.
2. **Fix FastSurfaceBuilder triangle hole** (C1) — add explicit `DynamicCachedBuilder.Build` pass or document surfaces as "points-only, no TIN".
3. **Fix `OnGetLimits` on 3 layers** (C4) — uncomment existing code, return real bounds.

### P1 — High-impact perf
4. **Add try/catch + cancellation to all 7 `Parallel.ForEach` sites** (C3) — `OnePass.cs:148-213` first.
5. **Hoist allocations in `LasSectionPointsCollectorService.FindPoints`** (P1) — cache delegate, reuse List.
6. **Bypass `FindPoints` for whole-cloud ops** (P2) — direct indexer walk.
7. **Add `PaintTerminate` chunking** to overlay layer loops (P7).

### P2 — Cleanup & modernization
8. Port int-packing dedup to `RemoveDuplicatesByXYZ` (P3).
9. Add indexer-AABB pre-cull before `FindPoints` (P4).
10. Batch polylines via `pen.DrawArray` (P8).
11. Replace hand-rolled point-in-polygon with `PolygonOverlay.PosStrictlyInContour` (§4 #3).
12. Replace manual bbox loops with `BoundingBox2D.AddPoint` (13 sites).

### P3 — Documentation corrections (cheap, high-clarity)
13. **Fix `FastSurfaceBuilder.cs:57` comment** — "Flush undo transaction + notify proxies", NOT "single TIN rebuild".
14. **Fix `PERFORMANCE_GUIDE.md`** — EndUpdate ≠ Delaunay; PointIndexer = O(n) parallel 8×8 grid, not O(n log n) quadtree; InsertOverPoints = breakline densify, not batch insert.
15. **Fix `GRAPHICS_OPTIMIZATION_GUIDE.md`** — withdraw "ArrayMode.Polygon 10-100×" claim; ArrayMode.Point already optimal.
16. **Fix CLAUDE.md** — command registration is `[cmd]` + manifest, not SectionCmdAttribute/SectionRegistry.
17. Remove dead `using Topomatic.Crs.Templates` in `CrsOverlayDataBuilder.cs:15`.
18. Close prior "adopt CrsSurfaceBuilder" finding — **rejected** (wrong domain).

---

## §8. Correctness Self-Checks (what was verified correct, no change needed)

- `FastSurfaceBuilder` insert path (Dynamic=false + raw Points.Add) — optimal for bulk; only the triangle side-effect is the issue (C1).
- `SlopeAdjustmentService.cs:188-209` BeginUpdate/EndUpdate try/finally — correct.
- `SurfaceZScaleToggleTest` batch Transform — correct (XY unchanged → no re-triangulation).
- `CrsOverlayCrossLayer.AfterAlignmentChange` override — idiomatic.
- `OnePassSectionCollector` direct quadtree walk (no `Action` callback) — correct architecture, keep as default.
- `LasSectionPointsCollectorService` section box construction — correct AABB shape.
- `CompoundLine.Length` hoisting — fine (O(1) anyway).

---

## Appendix A — Decompiled corpus

- Location: `docs/topomatic-sweep/decompiled/` (gitignored)
- **STATUS (обновлено 2026-06-18): corpus ПОЛОН.** Сравнение с установкой `C:\Program Files\Topomatic Robur Rail 16.0\` показало **189/189 DLL декомпилированы** — наборы полностью совпадают. Раннее утверждение «11 missing (Visualization/Turnouts/Tables)» устарело: эти сборки декомпилированы, но ранее не исследовались глубоко. Теперь они покрыты карточками базы знаний:
  - `Topomatic.Tables.*` (3 DLL) — см. `docs/knowledge-base/cards/11-tables-export.md`
  - `Topomatic.Cartograms.*` (3 DLL) — см. `docs/knowledge-base/cards/12-cartograms.md`
- Decompiler: `ilspycmd 8.2.0` at `C:\Users\user\.dotnet\tools\ilspycmd.exe`. No PDBs ship — signatures accurate, line numbers approximate.

## Appendix B — Key file:line index

- `Topomatic.Sfc.cs:17993` — concrete `sealed class Surface : UndoObject`
- `Topomatic.Sfc.cs:13928` — `PointEditor.Add` (per-point undo command)
- `Topomatic.Sfc.cs:23705` — `SurfacePointArray.Add` (O(1), no triangulation)
- `Topomatic.Sfc.cs:20415/20429` — `Surface.OnModified/OnSetInternalModified`
- `Topomatic.Sfc.cs:25078` — `SurfaceTools.AddPointToTriangulation` (incremental, Dynamic-gated)
- `Topomatic.FoundationClasses.cs:9272-9309` — `UndoObject.EndUpdate` (no triangulation)
- `Topomatic.FoundationClasses.cs:13710-13727` — `Parallel.ForEach` (deadlock hazard)
- `Topomatic.FoundationClasses.cs:25854-25866` — `BeginUpdate` (bare int++)
- `Topomatic.Cad.Foundation.cs:74248` — `DynamicCachedBuilder.Build` (real triangulator)
- `Topomatic.Cad.Foundation.cs:45953-45969` — GPU `ArrayMode.Point` (single draw call)
- `Topomatic.Cad.Foundation.cs:4603-4608` — `ArrayMode` enum = {Polyline, Polygon, Point}
- `Topomatic.Cad.View.cs:24232-24273` — `SolveLimits` (OnGetLimits contract)
- `Topomatic.Alg.cs:20175-20209` — `SectionList.Add/Clear`
- `Topomatic.Alg.cs:34252-34270` — canonical merge idiom
- `Topomatic.Alg.cs:18934,18943` — `Corridor[i]` (expensive CrsDesignContext build)
- `Topomatic.Alg.Runtime.cs:52797` — `MakeWholeStations` (non-destructive)
- `Topomatic.Lidar.cs:5076-5135` — `FindPoints` quadtree walk
- `Topomatic.ApplicationPlatform.cs:19352-19372` — `PluginInitializator.Initialize` ([cmd] reflection)

## Appendix C — what prior analysis got RIGHT (keep)

- The reflection catalog (171 DLLs, ~6225 types) is accurate as a signature index.
- `our-api-usage.md` integration map is accurate.
- Identifying `Sections.Clear()` as suspicious — correct instinct, now proven.
- TIN-rebuild-somewhere-is-expensive intuition — correct in spirit (triangulation IS O(n log n)), just mis-located (EndUpdate is innocent; the real cost is the absent triangulation in our path, or per-point if Dynamic=true).
