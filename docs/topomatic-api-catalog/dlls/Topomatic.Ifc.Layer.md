# Topomatic.Ifc.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Ifc.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Ifc.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Ifc.Layer.dll` |

---
## Namespace: `Topomatic.Ifc.Layer`

### `AffineAttachment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.AffineAttachment` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePosition` | `Vector3D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |
| `Transformation` | `Matrix` | `get` | No | `` |
| `Translation` | `Vector3D` | `get/set` | No | `` |

### `Attachment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.Attachment` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Affine` | `AffineAttachment` | `get` | No | `` |
| `CoordinateTransformation` | `CoordinateTransformationAttachment` | `get` | No | `` |
| `UseCoordinateTransformation` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Attachment` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetAffine` | `AffineAttachment` | `` | `` |

### `CoordinateTransformationAttachment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.CoordinateTransformationAttachment` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Source` | `HorizontalCoordinateSystem` | `get/set` | No | `` |
| `Target` | `HorizontalCoordinateSystem` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCoordinateTransformation` | `CoordinateTransformation` | `` | `` |

### `DrawingPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.DrawingPlanLayer` |
| **Base Type** | `Topomatic.Dwg.Layer.DrawingLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer, Topomatic.Ifc.Layer.IAttachable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Ifc.Layer.DrawingPlanLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attachment` | `Attachment` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get/set` | No | `` |
| `Model` | `Object` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `IDrawingContainer` | `get_Drawing` |
| `IAttachable` | `get_Model` |
| `IAttachable` | `get_Attachment` |
| `IAttachable` | `set_Attachment` |

### `IAttachable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.IAttachable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attachment` | `Attachment` | `get/set` | No | `` |
| `Model` | `Object` | `get` | No | `` |

### `IfcLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ifc.Layer.IfcLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Ifc.Layer.IAttachable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Ifc.Layer.IfcLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Attachment` | `Attachment` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Model` | `Object` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Project` | `IfcProject` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `IfcLayer` | `CadView cadView` | `` |
| `GetLayers` | `IEnumerable<IfcLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `IAttachable` | `get_Model` |
| `IAttachable` | `get_Attachment` |
| `IAttachable` | `set_Attachment` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 5 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 7 |
| **Total Properties** | 22 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


