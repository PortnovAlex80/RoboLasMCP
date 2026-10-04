# Topomatic.Its.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Its.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Its.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Its.Layers.dll` |

---
## Namespace: `Topomatic.Its`

### `ItsEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Its.ItsEiDrawer`

#### Constructors (1)

- `.ctor(AlignmentIts algIts, CadView cadView)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `DrawItem` | `Void` | `CadPen pen, InterTrackSpace its, Vector2D textOffset, Boolean overrideRotation, Double textRotation` | `` |
| `DrawLayer` | `Void` | `Boolean enabled, CadPen pen` | `` |
| `GetItsAngle` | `Double` | `InterTrackSpace its, Boolean overrideRotation, Double overrideAngle` | `` |
| `GetItsPos` | `Vector2D` | `InterTrackSpace its, Double scale` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetItsAngle` | `Double` | `AlignmentIts algIts, InterTrackSpace its, Boolean overrideRotation, Double overrideAngle` | `` |
| `GetItsPos` | `Vector2D` | `AlignmentIts algIts, InterTrackSpace its, Double scale` | `` |

---
## Namespace: `Topomatic.Its.Layers`

### `AlignmentItsExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Layers.AlignmentItsExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetIts` | `AlignmentIts` | `Alignment alignment` | `Extension` |

### `ItsEiController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Layers.ItsEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgStyledEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.Layers.AlgStyledEditableItemsController`
        - `Topomatic.Its.Layers.ItsEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlgIts` | `AlignmentIts` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |

---
## Namespace: `Topomatic.Its.Layers.Utils`

### `ItsLayerUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Layers.Utils.ItsLayerUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetItsPlanLayers` | `IEnumerable<EditableItemsLayer>` | `` | `` |
| `GetLayer` | `T` | `CadView cadView, Guid compoundId, Guid layerId, Boolean readOnly` | `` |
| `GetLayer` | `T` | `CadView cadView, Guid compoundId, Guid layerId` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 4 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 15 |
| **Total Properties** | 1 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


