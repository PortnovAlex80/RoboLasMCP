# Topomatic.Dtm.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Dtm.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Dtm.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Dtm.Layer.dll` |

---
## Namespace: `Topomatic.Dtm.Layer`

### `DtmLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Layer.DtmLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Dtm.Layer.DtmLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `DrawingLayer` | `DrawingLayer` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `SurfaceLayer` | `SurfaceLayer` | `get` | No | `` |
| `TerrainModel` | `TerrainModel` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `Invalidate3d` | `Void` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDtmLayer` | `DtmLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetDtmLayer` | `DtmLayer` | `CadView cadview` | `` |
| `GetDtmLayers` | `IEnumerable<DtmLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `GetSubLayers` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |
| `ISurfaceContainer` | `get_Surface` |

### `VisualizationCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.Layer.VisualizationCache` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SurfaceLayer layer)`

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `OnDynamicDraw3d` | `Void` | `DeviceContext dc, Ray3D ray, BoundingFrustum frustum` | `` |
| `OnHighlightObject3d` | `Void` | `DeviceContext dc, Object obj` | `` |
| `OnPaint3d` | `Void` | `DeviceContext dc` | `` |
| `OnPointAdd` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnPointCodeChanged` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnPointModify` | `Void` | `Object sender, PointModifyEventArgs e` | `` |
| `OnPointRemoved` | `Void` | `Object sender, PointRemoveEventArgs e` | `` |
| `OnPointSemanticModify` | `Void` | `Object sender, SurfaceSemanticModify e` | `` |
| `OnStructureLinesAddLine` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnStructureLinesAddNode` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnStructureLinesModifyLine` | `Void` | `Object sender, EventArgs e` | `` |
| `OnStructureLinesRemoveLine` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnStructureLinesRemoveNode` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnSurfaceInvalidated` | `Void` | `Object sender, EventArgs e` | `` |
| `OnSurfacePatchFlagsModify` | `Void` | `Object sender, PatchFlagsModifyEventArgs e` | `` |
| `OnSurfacePatchModify` | `Void` | `Object sender, IndexerEventArgs e` | `` |
| `OnSurfacePatchSemanticModify` | `Void` | `Object sender, SurfaceSemanticModify e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 27 |
| **Total Properties** | 6 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


