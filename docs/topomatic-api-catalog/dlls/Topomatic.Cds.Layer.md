# Topomatic.Cds.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cds.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cds.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cds.Layer.dll` |

---
## Namespace: `Topomatic.Cds.Layer`

### `CdsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Layer.CdsLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cds.Layer.CdsLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `CdsDrawing` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindWrapper` | `IWrapped<CdsEssence>` | `Vector3D position, Predicate<CdsEssence> contains` | `` |
| `FindWrapper` | `IWrapped<CdsEssence>` | `CdsEssence essence` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCdsLayer` | `CdsLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetCdsLayer` | `CdsLayer` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Namespace: `Topomatic.Cds.Layer.Drawers`

### `EssencesDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Layer.Drawers.EssencesDrawer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Essences` | `IEnumerable<CdsEssence>` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `Drawing drawing` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Invalidate` | `Void` | `` | `` |
| `Layout` | `Void` | `Drawing drawing` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

---
## Namespace: `Topomatic.Cds.Layer.Tools`

### `CdsDrawingTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Layer.Tools.CdsDrawingTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PaintConnectors` | `Vector2D` | `IList<ConnectorIndex> connectors, CadPen pen, CdsPointerElem essence, BoundingBox2D frame, Vector2D position` | `` |
| `PrepareConnectors` | `IList<ConnectorIndex>` | `IEnumerable<CdsBoard> boards, CdsPointerElem element` | `` |
| `PrepareMatrix` | `Matrix` | `CdsEssence essence, Matrix init` | `` |

#### Nested Types (1)

- `ConnectorIndex` (struct)

### `ConnectorIndex` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Layer.Tools.CdsDrawingTools+ConnectorIndex` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cds.Layer.Tools.CdsDrawingTools+ConnectorIndex`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Element` | `CdsPointerElem` | No | `` | `` |
| `Index` | `Int32` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 4 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 18 |
| **Total Properties** | 5 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


