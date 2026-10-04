# Topomatic.Alg.LandAllotment.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.LandAllotment.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.LandAllotment.Layers.dll` |

---
## Namespace: `Topomatic.Alg.LandAllotment.Layers`

### `AlignmentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.AlignmentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLandAllotment` | `LandAllotment` | `Alignment alignment` | `Extension` |

### `CrsSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer+CrsSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer+CrsSet`

#### Constructors (1)

- `.ctor(LandAllotmentCrsLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `EditorSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer+EditorSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer+EditorSelectionSet`

#### Constructors (1)

- `.ctor(LandAllotmentEditorLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `LandAllotmentCrsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (2)

- `CrsSet` (class)
- `NodeGrip` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILandAllotmentContainer` | `get_LandAllotment` |

### `LandAllotmentEditorAuxilaryLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorAuxilaryLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorAuxilaryLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `ILandAllotmentContainer` | `get_LandAllotment` |

### `LandAllotmentEditorCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorCompoundLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Alg.Layers.AlgCompoundLayer`
        - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorCompoundLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAlgLandAllotmentCompoundLayer` | `LandAllotmentEditorCompoundLayer` | `CadView cadView, Boolean readOnly` | `` |
| `GetAlgLandAllotmentCompoundLayer` | `LandAllotmentEditorCompoundLayer` | `CadView cadView` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentEditorDesignLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorDesignLinesLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer`
        - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorDesignLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `LandAllotmentEditorExistentLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorExistentLinesLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer`
        - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorExistentLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `LandAllotmentEditorLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Nested Types (2)

- `EditorSelectionSet` (class)
- `NodeGrip` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILandAllotmentContainer` | `get_LandAllotment` |

### `LandAllotmentEditorSectLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorSectLinesLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorSectLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `ILandAllotmentContainer` | `get_LandAllotment` |

### `LandAllotmentEditorTempLinesLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorTempLinesLayer` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer`
        - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorTempLinesLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `LandAllotmentPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (2)

- `NodeGrip` (class)
- `PlanSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `ILandAllotmentContainer` | `get_LandAllotment` |

### `LandAllotmentSignDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentSignDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Drawing drawing, Double scale)`

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateVertexCoordsBlock` | `Void` | `ref DwgBlock block` | `` |
| `CreateVertexMarkersBlock_N` | `Void` | `ref DwgBlock block` | `` |
| `CreateVertexMarkersBlock_NOffs` | `Void` | `ref DwgBlock block` | `` |
| `CreateVertexMarkersBlock_Offs` | `Void` | `ref DwgBlock block` | `` |

### `LandAllotmentStyleExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentStyleExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `LandAllotmentLayerStyleItem style` | `Extension` |
| `GetEnable` | `Boolean` | `LandAllotmentLayerStyleItem style` | `Extension` |
| `GetLayer` | `DwgLayer` | `LandAllotmentLayerStyleItem style` | `Extension` |
| `GetVisible` | `Boolean` | `LandAllotmentLayerStyleItem style` | `Extension` |
| `SetEnable` | `Void` | `LandAllotmentLayerStyleItem style, Boolean value` | `Extension` |
| `SetVisible` | `Void` | `LandAllotmentLayerStyleItem style, Boolean value` | `Extension` |

### `NodeGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer+NodeGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentEditorLayer+NodeGrip`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnCreateMenu` |

### `NodeGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer+NodeGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentCrsLayer+NodeGrip`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SectionStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `NodeGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer+NodeGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer+NodeGrip`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnCreateMenu` |

### `PlanSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer+PlanSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.LandAllotment.Layers.LandAllotmentPlanLayer+PlanSelectionSet`

#### Constructors (1)

- `.ctor(LandAllotmentPlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Alg.LandAllotment.Layers.EditableItems`

### `LandAllotmentEiController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController` |
| **Base Type** | `Topomatic.Alg.Layers.AlgEditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get` | No | `` |
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `Style` | `LandAllotmentLinesStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadview` | `` |
| `GetLayer` | `ILayer` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentEiControllerDesign` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerDesign` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController`
        - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerDesign`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `LandAllotmentLinesStyle` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentEiControllerExist` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerExist` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController`
        - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerExist`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `LandAllotmentLinesStyle` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentEiControllerTemp` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerTemp` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Alg.Layers.AlgEditableItemsController`
      - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiController`
        - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiControllerTemp`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `LandAllotmentLinesStyle` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentEiDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Alg.LandAllotment.Layers.EditableItems.LandAllotmentEiDrawer`

#### Constructors (1)

- `.ctor(CadView cadview, Drawing drawing)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `CadView cadView, Drawing drawing, Boolean enabled, CadPen pen, LandAllotmentEditableItemsKey key, Vector2D textOffset, Double additionalRotation` | `` |
| `GetItemEntities` | `List<DwgEntity>` | `Drawing drawing, Double scale, LandAllotmentEditableItemsKey key, Vector2D textOffset, Double additionalRotation` | `` |
| `TextPosition` | `Vector2D` | `LandAllotmentEditableItemsKey key` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 23 |
| **Classes** | 19 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 2 |
| **Total Methods** | 68 |
| **Total Properties** | 34 |
| **Total Fields** | 11 |
| **Total Events** | 0 |
| **Total Constructors** | 18 |
| **Nested Types** | 6 |
| **Extension Methods** | 0 |


