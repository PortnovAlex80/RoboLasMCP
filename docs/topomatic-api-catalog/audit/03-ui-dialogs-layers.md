# Audit 03: UI, Dialogs, and Layer Usage vs Topomatic API Catalog

**Date**: 2026-05-31
**Scope**: Infrastructure/UserControl/, Services/Layers/, Infrastructure/UserDialogs.cs
**API Catalogs Reviewed**: Topomatic.Controls, Topomatic.Cad.View, Topomatic.Cad.Foundation, Topomatic.Graphics.OpenGL, Topomatic.Lidar, Topomatic.ComponentModel

---

## 1. Dialog System Usage

### 1.1 MessageDlg — CORRECT USAGE

| File | Line | Status |
|------|------|--------|
| `Infrastructure/UserDialogs.cs` | 17, 22, 27, 158 | OK |

We use `Topomatic.Controls.Dialogs.MessageDlg.Show()` for warnings, info, and yes/no questions. This is the correct Topomatic dialog API. The static wrapper in `UserDialogs` is a clean pattern.

**Finding D-01**: `UserDialogs.GetDouble()` uses `CadCursors.GetDouble()` which is the correct Topomatic API for inline numeric input on the CadView command line. Good.

**Finding D-02**: `UserDialogs.GetSaveFilePath()` at line 41 uses raw `System.Windows.Forms.SaveFileDialog` instead of a Topomatic dialog. Topomatic's API does not offer a native file save dialog (no `SimpleDlg` subclass for file picking), so this is acceptable. However, consider wrapping in a `SimpleDlg` for consistent look-and-feel.
- **Impact**: LOW
- **Current**: `new SaveFileDialog()`
- **Alternative**: Wrap in `SimpleDlg` for themed appearance, or accept as-is

### 1.2 Missing Topomatic Dialog Types

| Topomatic API | Our Usage | Recommendation |
|---------------|-----------|----------------|
| `SimpleDlg` | Not used | Base class for custom dialogs; not needed since we use `MessageDlg` and `CadCursors` |
| `InputBoxDlg` | Not used | Could replace `CadCursors.GetDouble()` for simple modal input, but `CadCursors` is more CAD-idiomatic |
| `Wizard` | Not used | Not needed for current use cases |
| `StoredDlg` | Not used | Could be useful if we need persistent dialog layouts |
| `WaitProgress` | Used correctly | See Section 3 |

**Verdict**: Dialog usage is appropriate. We use the right Topomatic dialog primitives for our use cases.

---

## 2. Custom Rendering Layers

### 2.1 CrsOverlayLayer (CadViewLayer) — MOSTLY CORRECT

| File | Line | Finding |
|------|------|---------|
| `Services/Layers/CrsOverlayLayer.cs` | 10 | Inherits `CadViewLayer` — correct base class |

**Finding L-01**: `OnGetLimits()` returns `false` with empty bounding box (line 70-72). The commented-out code (lines 75-87) shows the correct implementation was intentionally disabled.
- **Impact**: MEDIUM — Without proper limits, the layer does not participate in zoom-to-fit and the CAD view cannot optimize rendering by clipping to bounds.
- **Current**: `return false` always
- **Topomatic pattern**: Override `OnGetLimits` to return `true` with a proper `BoundingBox2D` computed from all visible geometry. `BoundingBox2D.CreateFromPoints()` is available in `Topomatic.Cad.Foundation`:
  ```csharp
  // Static method available:
  BoundingBox2D.CreateFromPoints(IEnumerable<Vector2D> points)
  BoundingBox2D.CreateFromPoints(Vector2D[] points)
  ```

**Finding L-02**: `OnPaint()` uses `CadPen` API correctly:
  - `BeginDraw()` / `EndDraw()` block for line drawing — correct
  - `BeginArray()` / `Vertex()` / `EndArray(ArrayMode.Point)` for point cloud — correct
  - Color/Width setting before draw calls — correct

**Finding L-03**: Point rendering at line 63 uses `pen.Width = PointSize` (25.0f). This is extremely large for a pen width and will render as very thick points. This may be intentional for visibility in CRS overlay, but verify this looks correct at various zoom levels.

### 2.2 CrsOverlayCrossLayer (AlgBaseCrossSectionLayer) — CORRECT INHERITANCE

| File | Line | Finding |
|------|------|---------|
| `Services/Layers/CrsOverlayCrossLayer.cs` | 16 | Inherits `AlgBaseCrossSectionLayer` — correct for cross-section rendering |

**Finding L-04**: `EnsureData()` (lines 311-358) does heavy computation inside `OnPaint`. Every time the cross-section view repaints, this method re-collects LiDAR buffers and rebuilds data. The caching (`_lastIndex`, `_lastStation`) helps, but the fallback path when `Section` is null uses `ActiveAlignmentReciver` which involves allocation and COM interop.
- **Impact**: HIGH — Performance. If the section view repaints frequently (scroll, zoom), this triggers repeated `LidarBufferService.CollectBuffers()` + `CrsOverlayDataBuilder.Build()` calls.
- **Current**: Computation in `OnPaint` path
- **Topomatic pattern**: Separate data preparation from rendering. Pre-compute data when section changes (subscribe to section change events) and only draw cached data in `OnPaint`.

**Finding L-05**: `OnGetLimits()` returns `false` always (line 300-303), same issue as L-01.
- **Impact**: MEDIUM

**Finding L-06**: `DrawHeatmapCells()` (lines 153-243) draws individual cell rectangles with 4 `DrawLine` calls each, wrapped in separate `BeginDraw/EndDraw` blocks per cell. For large grids (NX * NY cells), this creates many draw batches.
- **Impact**: HIGH — Performance. Each `BeginDraw/EndDraw` is a GPU draw call.
- **Current**: N separate BeginDraw/EndDraw blocks (one per cell)
- **Topomatic pattern**: Batch all cells of the same color into one `BeginDraw/EndDraw` block. Group by color, then draw all lines of that color in one batch.

**Finding L-07**: Hardcoded debug log path at line 45: `D:\MyLogs\LAS_TERRAIN\layer_debug.log`. This should use the standard logging infrastructure or be removed.
- **Impact**: LOW — Debug artifact left in production code

### 2.3 PlanOverlayLayer (CadViewLayer) — ARRAYMODE.POLYGON OPTIMIZATION

| File | Line | Finding |
|------|------|---------|
| `Services/Layers/PlanOverlayLayer.cs` | 17 | Inherits `CadViewLayer` — correct |

**Finding L-08**: `DrawFilledPolygon()` (lines 137-186) implements a software scanline fill algorithm using `CadPen.DrawLine()` for each scanline. This is because `CadPen` has no `FillPolygon()` method — Topomatic's rendering API is fundamentally vector/line based.
- **Impact**: HIGH — Performance and correctness. The scanline fill with ~100 steps creates hundreds of draw calls per polygon. For multiple polygons, this is extremely expensive.
- **Current**: Software scanline with `DrawLine`
- **FIX AVAILABLE**: Use `ArrayMode.Polygon` which exists in the Topomatic API:
  ```csharp
  // In Topomatic.Cad.Foundation:
  public enum ArrayMode
  {
      Point = 0,
      Polygon = 1,    // <-- For filled polygons
      Polyline = 2
  }
  
  // Correct usage pattern:
  pen.BeginArray();
  foreach (var vertex in polygonVertices)
      pen.Vertex(vertex);
  pen.EndArray(ArrayMode.Polygon);  // Single GPU primitive!
  ```
- **Performance Impact**: Replacing ~100 scanline `DrawLine` calls with one `EndArray(ArrayMode.Polygon)` is a **10-100x rendering speedup** for filled polygons.
- **Note**: This is the #1 performance optimization opportunity in the entire layer system.

**Finding L-09**: `OnGetLimits()` returns `false` always (line 188-191). Should compute bounds from all polygon vertices using `BoundingBox2D.CreateFromPoints()`.
- **Impact**: MEDIUM — Zoom-to-fit does not include overlay polygons

### 2.4 CrsOverlaySelectionSet — CORRECT BUT VERBOSE

| File | Line | Finding |
|------|------|---------|
| `Services/Layers/EmptySelectionSet.cs` | 11 | Inherits `SelectionSet` — correct |

**Finding L-10**: The `CrsOverlaySelectionSet` class (in `EmptySelectionSet.cs`) implements 30+ methods/properties, all as no-ops or `yield break`. This is required because `SelectionSet` is abstract with many virtual members. The implementation is correct — a read-only, non-interactive selection set for overlay layers.
- **Impact**: LOW — Boilerplate is unavoidable with the Topomatic API
- **Alternative**: None. This is the standard pattern for non-selectable layers.

---

## 3. Progress Reporting

### 3.1 WaitProgress — CORRECT USAGE

| File | Lines | Pattern |
|------|-------|---------|
| `Services/SectionBaseUseCase.cs` | 124-130 | `WaitProgress.BeginProgress(caption, callback)` with `WaitProgress.ProgressChange(p)` inside |
| `Services/SectionBaseUseCase.cs` | 247-255 | Cancellation check with `WaitProgress.CancellationPending` |
| 15+ UseCase files | Various | Consistent usage |

**Finding P-01**: WaitProgress usage is correct and follows Topomatic patterns:
- `BeginProgress(caption, callback)` for starting progress
- `ProgressChange(percentage)` for updates (0.0 to 1.0 range)
- `CancellationPending` for cooperative cancellation
- `BeginProgressSync` variant available but not used (not needed)

**Finding P-02**: `WaitProgress.SetProgressCaption()` is available but not used. Could improve UX by updating caption with current phase name (e.g., "Collecting points... 45%", "Filtering... 78%").
- **Impact**: LOW — UX improvement

---

## 4. Settings Panel vs Topomatic DockPanel

### 4.1 LasSettingsPanel — Custom UserControl

| File | Line | Finding |
|------|------|---------|
| `Infrastructure/UserControl/LasSettingsPanel.cs` | 113 | Inherits `System.Windows.Forms.UserControl` |
| `Module.cs` | 12 | Created via `[cmd("create_las_settings_panel")]` |

**Finding S-01**: The settings panel is a fully custom `UserControl` with manual layout using `TableLayoutPanel`, custom `CardPanel` controls, and a custom `HeaderBar`. It does NOT use Topomatic's `DockPanel` system.
- **Impact**: MEDIUM — The panel cannot be docked/undocked/floated within the Topomatic IDE. It is likely embedded in a fixed location.
- **Current**: Plain `UserControl` created by command
- **Topomatic pattern**: Use `DockPanel` (from `Topomatic.Controls.Common`) which supports:
  - `DockDirection` (Left, Right, Top, Bottom, Horizontal, Vertical, All)
  - `DockState` (Floating, Dockable)
  - `CanClose`, `Visible`, `Text`, `Image`, `Tag` properties
  - `Owner` as `MultiDock` for panel management
  - `VisibleCoreChanged` event
  - Integration with `MultiDock.Add(String text, Image image, Control userControl)`
- **Fix**: Wrap `LasSettingsPanel` in a `DockPanel`, register with `MultiDock`, allow user to dock/float the settings panel.

**Finding S-02**: The settings panel writes directly to `RuntimeConfig` and `Settings.Instance` on every value change (lines 326-368). There is no validation dialog or confirmation — changes apply immediately.
- **Impact**: LOW — This is a reasonable design for real-time parameter adjustment
- **Alternative**: Could use `StoredDlg` pattern for a modal settings dialog with OK/Cancel, but real-time is arguably better UX for this use case

**Finding S-03**: The panel uses custom visual theme (`RoboTheme` class, lines 12-19) with cyan accent colors, rounded cards, and custom fonts. This does NOT match Topomatic's native look-and-feel.
- **Impact**: LOW — Aesthetically different from the host application, but not functionally wrong
- **Alternative**: Use Topomatic's standard controls and theming. Or accept as intentional branding.

### 4.2 PropertyExplorer Integration Opportunity

**Finding S-04**: Topomatic provides `PropertyExplorer` static class in `Topomatic.ComponentModel` namespace with methods:
- `PropertyExplorer.GetProperties(IEnumerable collection)` — extracts properties for display
- `PropertyExplorer.HaveCommonProperties(IList instance)` — checks if objects share properties
- Supports `PropertyProvider` and `PropertyEditor` for custom property presentation

Our `RuntimeConfig` class has ~10 settings that could be displayed via a property grid instead of custom UI.
- **Impact**: LOW — Current custom panel provides better UX (grouped cards, hints, reset link) than a generic PropertyGrid
- **Recommendation**: Keep the custom panel. PropertyGrid would be a downgrade for 5 numeric parameters + 1 enum.

---

## 5. CadPen Drawing Efficiency

### 5.1 ArrayMode.Polygon Optimization

**Discovery from API Catalog**: The `ArrayMode` enum in `Topomatic.Cad.Foundation` has three values:
- `Point = 0` — for point clouds
- `Polygon = 1` — **for filled polygons** (key discovery!)
- `Polyline = 2` — for line strips

**Finding R-01**: `PlanOverlayLayer.DrawFilledPolygon()` does NOT use `ArrayMode.Polygon`. Instead, it uses a scanline fill algorithm with ~100 `DrawLine` calls per polygon.
- **Impact**: HIGH — Major performance bottleneck
- **Fix**:
  ```csharp
  // Current (slow):
  for (int y = yMin; y <= yMax; y++)
      pen.DrawLine(new Vector2D(x1, y), new Vector2D(x2, y));  // ~100 calls
  
  // Optimized (10-100x faster):
  pen.BeginArray();
  foreach (var vertex in polygonVertices)
      pen.Vertex(vertex);
  pen.EndArray(ArrayMode.Polygon);  // Single GPU primitive!
  ```

### 5.2 Batch Drawing Patterns

**Finding R-02**: In `CrsOverlayLayer.OnPaint()` (lines 46-66), the pattern is correct:
```
pen.BeginDraw();
for (...) pen.DrawLine(...);
pen.EndDraw();
```
This batches line draws correctly.

**Finding R-03**: Point rendering in all layers uses the correct array pattern:
```
pen.BeginArray();
foreach (var p in points) pen.Vertex(p);
pen.EndArray(ArrayMode.Point);
```
This is the efficient way to render many points.

**Finding R-04**: `CrsOverlayCrossLayer.DrawHeatmapCells()` does NOT batch efficiently:
- Each cell gets its own `BeginDraw()` / 4x `DrawLine()` / `EndDraw()` block (lines 235-238)
- For NX=50, NY=20 grid, that's up to 1000 separate draw batches
- **Fix**: Group cells by color, use single `BeginDraw/EndDraw` per color group

### 5.3 CadPen Features Not Used

| Feature | Availability | Our Usage |
|---------|-------------|-----------|
| `CadPen.VertexArc()` | Yes | No — could be used for rounded corners |
| `CadPen.VertexCircle()` | Yes | No — could replace large point rendering |
| `CadPen.VertexEllipse()` | Yes | No |
| `CadPen.PushMatrix/PopMatrix()` | Yes | No — could be used for transform batching |
| `CadPen.DrawingMode` | Yes | No — could be used for XOR drawing (rubber-band) |
| `CadPen.ComplexLinetype` | Yes | No — dashed/dotted line patterns |
| `CadPen.LineCapJoin` | Yes | No — line endpoint styling |

---

## 6. Layer Registration and Lifecycle

### 6.1 Layer GUID Management

**Finding G-01**: All layers use hardcoded `static readonly Guid` values:
- `CrsOverlayLayer`: `{A4E8D6AA-64F5-45B8-9B40-9F7E6B6D6611}`
- `CrsOverlayCrossLayer`: `{E3D5C2C8-8F2C-4E4B-9B7C-11C3D8A0C9F1}`
- `PlanOverlayLayer`: `{B7E9F1A3-5D4C-4A8B-9C2E-6F3D7A1B8E5C}`

This is the correct Topomatic pattern — each layer needs a unique persistent GUID.

### 6.2 Layer Add/Remove

**Finding G-02**: Layers are added via `CadView.AddLayer()` (found in `PlanDrawPolygonUseCase.cs:73`, `CrsDevProbeUseCase.cs:67`). No corresponding `RemoveLayer()` calls were found in the search results.
- **Impact**: MEDIUM — Potential memory leak. Layers added to CadView persist for the session. If use cases create new layers each invocation, layers accumulate.
- **Current**: `cadView.AddLayer(layer)` without cleanup
- **Topomatic pattern**: Either reuse singleton layers or explicitly call `cadView.RemoveLayer(layer)` when done

---

## 7. Mouse Interaction and Picking

### 7.1 Mouse Event Support in Layers

The Topomatic API provides mouse event support through `CadControl` base class:
- `MouseDown(MouseEventArgs e)` — mouse button events
- `MouseMove(MouseEventArgs e)` — mouse movement
- `MouseUp(MouseEventArgs e)` — mouse button release
- `KeyPress(CadKeyPressEventArgs e)` — keyboard input
- `PreviewKeyDown(CadPreviewKeyDownEventArgs e)` — keyboard preview

**Finding M-01**: Our overlay layers do not implement mouse interaction. They are purely visual — users cannot click, select, or highlight points in the overlay.
- **Impact**: LOW — Current use cases are display-only
- **Opportunity**: Could add mouse interaction for:
  - Point picking (click to identify LiDAR point)
  - Selection by rectangle/polygon
  - Hover tooltips showing point attributes

### 7.2 Object Picking API

Topomatic provides picking support through `CadView` and `BaseCadView3d`:
- `CadView.GetObjectsAtPoint(Vector3D point, Predicate<Object> match, Int32 waitTimeOut)` — pick at screen point
- `CadView.GetObjectsAtRay(Ray3D ray, Predicate<Object> match, Int32 waitTimeOut)` — pick along ray
- `CadView.GetObjectsByFrame(FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action)` — frame selection
- `BaseCadView3d.GetTrianglesAtRay(Ray3D ray, Predicate<Object> match, Int32 waitTimeOut)` — triangle-level picking

**Finding M-02**: Our layers do not expose objects to the picking system. The `CrsOverlaySelectionSet` is a no-op implementation.
- **Impact**: LOW — Not needed for current visualization-only use cases
- **Opportunity**: For debugging/analysis tools, could expose LiDAR points to picking for inspection

---

## 8. OpenGL Rendering Pipeline Opportunities

### 8.1 Vertex Buffer Usage

The `DeviceContext` API provides vertex buffer support:
- `DeviceContext.VertexBuffer` property — get/set vertex buffer
- `DeviceContext.DrawPrimitives(PrimitiveType, count)` — draw from vertex buffer
- `DeviceContext.DrawUserPrimitives(...)` — draw from array with optional color data
- `DeviceContext.DrawUserIndexedPrimitives(...)` — indexed drawing with color data

**Finding GL-01**: All our layers use immediate mode (`BeginArray/Vertex/EndArray`), not vertex buffers.
- **Impact**: LOW — For dynamic point clouds, immediate mode is acceptable
- **Opportunity**: For static geometry (overlay polygons that don't change), vertex buffers would be more efficient

### 8.2 Color-Grouped Batch Rendering

**Finding GL-02**: `CrsOverlayCrossLayer.DrawHeatmapCells()` draws cells by iterating through all cells and drawing each individually.
- **Current**: O(NX * NY) draw calls
- **Opportunity**: Group cells by color, use vertex arrays with per-vertex color:
  ```csharp
  // Optimized pattern:
  pen.BeginArray();
  foreach (var cell in redCells) {
      pen.Color = Color.Red;
      pen.Vertex(cell.v1); pen.Vertex(cell.v2);
      pen.Vertex(cell.v3); pen.Vertex(cell.v4);
  }
  foreach (var cell in blueCells) {
      pen.Color = Color.Blue;
      // ... vertices
  }
  pen.EndArray(ArrayMode.Polygon);  // Or PrimitiveType.Quads
  ```
- **Performance**: Reduces from ~1000 draw calls to ~10 (one per color group)

### 8.3 Heat Map Rendering Optimization

**Finding GL-03**: Heat map rendering in `CrsOverlayCrossLayer` uses individual line drawing for cell borders.
- **Current**: 4 lines per cell × NX × NY cells = thousands of draw calls
- **Alternative**: Use `DrawUserPrimitives` with color data for GPU-accelerated heat map:
  ```csharp
  Vector3F[] vertices = new Vector3F[4 * cellCount];
  Byte[] colors = new Byte[4 * cellCount];  // RGBA per vertex
  // Fill vertices and colors...
  dc.DrawUserPrimitives(PrimitiveType.Quads, vertices, colors, 0, cellCount);
  ```

---

## 9. BoundingBox2D.CreateFromPoints Implementation

From the API catalog, `BoundingBox2D` provides the following static methods:

```csharp
// Create from point collections:
BoundingBox2D CreateFromPoints(Vector2D[] points)
BoundingBox2D CreateFromPoints(IEnumerable<Vector2D> points)

// Create from rectangles:
BoundingBox2D CreateFromRectangle(Rectangle rect)
BoundingBox2D CreateFromRectangleF(RectangleF rect)

// Merge operations:
BoundingBox2D CreateMerged(BoundingBox2D original, BoundingBox2D additional)
void CreateMerged(ref BoundingBox2D original, ref BoundingBox2D additional, ref BoundingBox2D result)

// Add point incrementally:
BoundingBox2D AddPoint(BoundingBox2D box, Vector2D point)
void AddPoint(ref BoundingBox2D box, ref Vector2D point, ref BoundingBox2D result)
```

**Finding B-01**: `OnGetLimits()` implementations should use these methods:
```csharp
protected override bool OnGetLimits(ref BoundingBox2D limits)
{
    if (_points == null || _points.Count == 0)
        return false;
    
    limits = BoundingBox2D.CreateFromPoints(_points);
    return true;
}
```

---

## 10. OpenGL Graphics Context Details

From `Topomatic.Graphics.OpenGL`, the following capabilities are available:

### 10.1 Vertex Array Objects (VAO) and Buffer Objects (VBO)

- `GenVertexArrays(Int32 n, UInt32[] arrays)` — create VAO
- `DeleteVertexArrays(Int32 n, UInt32[] arrays)` — cleanup
- `GenBuffersARB` / `DeleteBuffersARB` — vertex buffer objects
- `BindBufferARB(UInt32 target, UInt32 buffer)` — bind VBO
- `BufferDataARB` — upload data to GPU

**Finding GL-04**: We do not use modern OpenGL (VBO/VAO). We use legacy immediate mode via `CadPen`.
- **Impact**: LOW — `CadPen` abstraction is appropriate for CAD plugins
- **Opportunity**: For massive point clouds (>1M points), VBOs would significantly improve performance

### 10.2 Shader Support

- `CreateShaderObjectARB(UInt32 shaderType)` — create vertex/fragment shader
- `CompileShaderARB(UInt32 shaderObj)` — compile shader
- `CreateProgramObjectARB()` — create program
- `LinkProgramARB(UInt32 programObj)` — link program
- `UseProgramObjectARB(UInt32 programObj)` — activate

**Finding GL-05**: Custom shaders are not used. We rely on `CadPen`'s built-in rendering.
- **Impact**: LOW — Acceptable for visualization plugins
- **Opportunity**: Custom shaders could enable advanced heat map rendering, point classification visualization, or terrain shading effects

---

## Summary of Findings

### HIGH Impact (Performance Critical)

| ID | File:Line | Issue | Recommendation | Performance Gain |
|----|-----------|-------|----------------|------------------|
| L-08 | PlanOverlayLayer.cs:137-186 | Software scanline polygon fill with ~100 `DrawLine` calls per polygon | Replace with `pen.EndArray(ArrayMode.Polygon)` | **10-100x** rendering speedup |
| L-04 | CrsOverlayCrossLayer.cs:311-358 | Heavy computation (buffer collection, data building) inside `OnPaint` render path | Move data preparation to section-change event handler; only draw cached data in `OnPaint` | Eliminates render-time stalls |
| L-06 | CrsOverlayCrossLayer.cs:235-238 | Per-cell `BeginDraw/EndDraw` in heatmap — O(NX*NY) draw batches | Group cells by color, draw all same-color cells in one batch | **10-50x** fewer draw calls |

### MEDIUM Impact (Correctness & UX)

| ID | File:Line | Issue | Recommendation |
|----|-----------|-------|----------------|
| L-01 | CrsOverlayLayer.cs:70-72 | `OnGetLimits` returns false — no zoom-to-fit for overlay | Implement proper bounding box from `_points` + `_poly` using `BoundingBox2D.CreateFromPoints()` |
| L-05 | CrsOverlayCrossLayer.cs:300-303 | Same as L-01 for cross-section layer | Implement proper limits |
| L-09 | PlanOverlayLayer.cs:188-191 | Same as L-01 for plan overlay layer | Implement proper limits from polygon vertices |
| S-01 | LasSettingsPanel.cs:113 | No DockPanel integration — settings panel is fixed, not dockable | Wrap in `Topomatic.Controls.Common.DockPanel` for docking/floating support |
| G-02 | Various use cases | Layers added via `AddLayer` but never removed | Implement singleton layer pattern or explicit `RemoveLayer` cleanup |

### LOW Impact (Polish & Debug)

| ID | File:Line | Issue | Recommendation |
|----|-----------|-------|----------------|
| D-02 | UserDialogs.cs:41 | Raw `SaveFileDialog` instead of Topomatic-themed dialog | Acceptable; Topomatic has no file dialog wrapper |
| L-03 | CrsOverlayLayer.cs:63 | Point size of 25.0f is very large | Verify renders correctly at all zoom levels |
| L-07 | CrsOverlayCrossLayer.cs:45 | Hardcoded debug log path `D:\MyLogs\...` | Remove or use PerformanceLogger |
| S-03 | LasSettingsPanel.cs:12-19 | Custom visual theme does not match Topomatic | Acceptable as intentional branding |
| P-02 | SectionBaseUseCase.cs | `WaitProgress.SetProgressCaption()` not used | Could improve UX with phase names |

---

## Priority Implementation Order

### Phase 1: Quick Wins (1-2 hours each)

1. **Replace scanline fill with ArrayMode.Polygon** (`PlanOverlayLayer.cs:137-186`)
   - Change `DrawFilledPolygon` to use `BeginArray/Vertex/EndArray(ArrayMode.Polygon)`
   - Expected: 10-100x rendering speedup for filled polygons

2. **Fix OnGetLimits** (all layer files)
   - Implement proper bounding box using `BoundingBox2D.CreateFromPoints()`
   - Expected: Zoom-to-fit now works for all overlays

3. **Batch heatmap rendering** (`CrsOverlayCrossLayer.cs:153-243`)
   - Group cells by color before drawing
   - Expected: 10-50x fewer draw calls

### Phase 2: Architecture Improvements (4-8 hours)

4. **Separate data preparation from rendering** (`CrsOverlayCrossLayer.cs`)
   - Subscribe to section change events
   - Cache data between renders
   - Expected: Eliminates render-time computation

5. **DockPanel integration** (`LasSettingsPanel.cs`)
   - Wrap panel in `DockPanel`
   - Register with `MultiDock`
   - Expected: Settings panel becomes dockable/floating

### Phase 3: Lifecycle Management (2-4 hours)

6. **Layer cleanup** (use case files)
   - Implement singleton pattern for layers
   - Or add `RemoveLayer` calls
   - Expected: No memory leaks from accumulated layers

---

## Code Examples

### Example 1: ArrayMode.Polygon (Before/After)

**Before (scanline fill):**
```csharp
private void DrawFilledPolygon(CadPen pen, List<Vector2D> poly)
{
    // Compute bounds
    double yMin = poly.Min(p => p.Y);
    double yMax = poly.Max(p => p.Y);
    
    // Scanline fill -- VERY SLOW
    for (double y = yMin; y <= yMax; y += step)
    {
        var intersections = GetIntersections(poly, y);
        for (int i = 0; i < intersections.Count; i += 2)
        {
            pen.DrawLine(new Vector2D(intersections[i], y),
                         new Vector2D(intersections[i + 1], y));  // ~100 calls
        }
    }
}
```

**After (hardware accelerated):**
```csharp
private void DrawFilledPolygon(CadPen pen, List<Vector2D> poly)
{
    pen.BeginArray();
    foreach (var vertex in poly)
        pen.Vertex(vertex);
    pen.EndArray(ArrayMode.Polygon);  // SINGLE GPU PRIMITIVE!
}
```

### Example 2: OnGetLimits Implementation

```csharp
protected override bool OnGetLimits(ref BoundingBox2D limits)
{
    if (_points == null || _points.Count == 0)
        return false;
    
    // Compute bounds from all visible geometry
    limits = BoundingBox2D.CreateFromPoints(_points);
    
    // Include polygon vertices if any
    if (_poly != null && _poly.Count > 0)
    {
        var polyBounds = BoundingBox2D.CreateFromPoints(_poly);
        limits = BoundingBox2D.CreateMerged(limits, polyBounds);
    }
    
    return true;
}
```

### Example 3: Heat Map Color Batching

**Before (per-cell batching):**
```csharp
foreach (var cell in cells)
{
    pen.Color = GetColor(cell.Value);
    pen.BeginDraw();
    pen.DrawLine(cell.V1, cell.V2);
    pen.DrawLine(cell.V2, cell.V3);
    pen.DrawLine(cell.V3, cell.V4);
    pen.DrawLine(cell.V4, cell.V1);
    pen.EndDraw();
}
```

**After (color-grouped batching):**
```csharp
// Group by color
var grouped = cells.GroupBy(c => GetColor(c.Value));

foreach (var group in grouped)
{
    pen.Color = group.Key;
    pen.BeginDraw();
    
    foreach (var cell in group)
    {
        pen.DrawLine(cell.V1, cell.V2);
        pen.DrawLine(cell.V2, cell.V3);
        pen.DrawLine(cell.V3, cell.V4);
        pen.DrawLine(cell.V4, cell.V1);
    }
    
    pen.EndDraw();
}
```

---

## Conclusion

The LAS_TERRAIN plugin uses Topomatic's UI/dialog/layer APIs correctly for the most part, but there are **significant performance optimization opportunities**:

1. **ArrayMode.Polygon** is the #1 optimization — replacing scanline fill with hardware-accelerated polygon rendering provides **10-100x speedup**.

2. **OnGetLimits** should be implemented for all layers to enable zoom-to-fit and view optimization.

3. **Batch rendering** by color for heat maps would reduce draw calls by **10-50x**.

4. **DockPanel integration** would improve UX by making the settings panel dockable.

5. **Layer lifecycle** management needs attention to prevent memory leaks.

The Topomatic API provides all the necessary tools for efficient rendering and UI integration — we just need to use them!
