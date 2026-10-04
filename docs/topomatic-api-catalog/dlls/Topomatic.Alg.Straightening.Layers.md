# Topomatic.Alg.Straightening.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Straightening.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Straightening.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Straightening.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Straightening.Layers`

### `AlignmentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Layers.AlignmentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStraightening` | `Straightening` | `Alignment alignment` | `Extension` |
| `JoinStraightening` | `Void` | `Alignment alignment, AlignmentJoinType joinType, Alignment first, Alignment second` | `Extension` |
| `SplitStraightening` | `Void` | `Alignment alignment, Double station, Alignment before, Alignment after` | `Extension` |

### `StraighteningLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Layers.StraighteningLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Straightening.IStraighteningContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Straightening.Layers.StraighteningLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Straightening` | `Straightening` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IStraighteningContainer` | `get_Straightening` |

### `StraighteningPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Layers.StraighteningPlanLayer` |
| **Base Type** | `Topomatic.Alg.Straightening.Layers.StraighteningPlanSubLayer` |
| **Implements** | `Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.ILayer, Topomatic.Alg.Straightening.IStraighteningContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Straightening.Layers.StraighteningPlanSubLayer`
    - `Topomatic.Alg.Straightening.Layers.StraighteningPlanLayer`

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StraighteningPlanSubLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Layers.StraighteningPlanSubLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.ILayer, Topomatic.Alg.Straightening.IStraighteningContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `CadViewLayer` | `get/set` | No | `` |
| `Straightening` | `Straightening` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IStraighteningContainer` | `get_Straightening` |

---
## Namespace: `Topomatic.Alg.Straightening.Layers.Wrapper`

### `StraighteningWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Layers.Wrapper.StraighteningWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.ILinearObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Alg.Straightening.IStraighteningContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `Browsable` |
| `AlignmentName` | `String` | `get` | No | `` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Straightening` | `Straightening` | `get` | No | `Browsable` |
| `VertexesCount` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILinearObject` | `GetPolyline` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `IStraighteningContainer` | `get_Straightening` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 3 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 1 |
| **Total Methods** | 9 |
| **Total Properties** | 14 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 3 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


