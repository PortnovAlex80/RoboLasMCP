# Topomatic.Rsf.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Rsf.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Rsf.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Rsf.Layers.dll` |

---
## Namespace: `Topomatic.Rsf.Layers`

### `AlignmentRsfExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.AlignmentRsfExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetRsf` | `AlignmentRsf` | `Alignment alignment` | `Extension` |

### `RsfStyleExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.RsfStyleExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `RsfLayerStyleItem style` | `Extension` |
| `GetEnable` | `Boolean` | `RsfLayerStyleItem style` | `Extension` |
| `GetLayer` | `DwgLayer` | `RsfLayerStyleItem style` | `Extension` |
| `GetVisible` | `Boolean` | `RsfLayerStyleItem style` | `Extension` |
| `SetEnable` | `Void` | `RsfLayerStyleItem style, Boolean value` | `Extension` |
| `SetVisible` | `Void` | `RsfLayerStyleItem style, Boolean value` | `Extension` |

---
## Namespace: `Topomatic.Rsf.Layers.Design`

### `DesignConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Design.DesignConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFenceMarksDataBasePath` | `String` | `` | `` |
| `ValueIsLocationStr` | `Boolean` | `String s` | `` |
| `ValueIsSFLStr` | `Boolean` | `String s` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ERR_CAN_NOT_CHANGE_BRIDGE_BOUNDS` | `String` | Yes | `` | `` |
| `ERR_CAN_NOT_SET_INVALID_VALUE` | `String` | Yes | `` | `` |
| `sBridge` | `String` | Yes | `` | `` |
| `sPosts` | `String` | Yes | `` | `` |
| `U` | `String` | Yes | `` | `` |

### `IFenceWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Design.IFenceWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Fence` | `Fence` | `get` | No | `` |

---
## Namespace: `Topomatic.Rsf.Layers.Drawers`

### `FencesDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Drawers.FencesDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAnnotationScale` | `Double` | `` | `` |
| `GetCachedCirclePointsList` | `Void` | `FenceTable fenceTable, Fence fence, RsfPlanStyle style, RsfCommonPlanStyle commonStyle, List<Vector2D> list` | `` |
| `GetCachedCirclePointsList` | `Void` | `FenceTable fenceTable, Fence fence, RsfPlanStyle style, RsfCommonPlanStyle commonStyle, List<Vector2D> list, Double annotationScale` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawFence` | `Void` | `CadPen pen, Fence fence` | `` |
| `DrawFence` | `Void` | `CadPen pen, CadView cadView, Fence fence` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultDotStep` | `Double` | Yes | `` | `` |
| `DotDiameter` | `Double` | Yes | `` | `` |
| `LineWidth` | `Double` | Yes | `` | `` |

---
## Namespace: `Topomatic.Rsf.Layers.Layers`

### `FencesPlanLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Layers.FencesPlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Rsf.Layers.Layers.FencesPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonPlanStyle` | `RsfCommonPlanStyle` | `get` | No | `` |
| `Drawer` | `FencesDrawer` | `get` | No | `` |
| `FenceTable` | `FenceTable` | `get` | No | `` |
| `IsFullMode` | `Boolean` | `get` | No | `` |
| `Rsf` | `AlignmentRsf` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `RsfPlanStyle` | `Fence fence` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ManuallyFencesPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Layers.ManuallyFencesPlanLayer` |
| **Base Type** | `Topomatic.Rsf.Layers.Layers.FencesPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Rsf.Layers.Layers.FencesPlanLayer`
        - `Topomatic.Rsf.Layers.Layers.ManuallyFencesPlanLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FenceTable` | `FenceTable` | `get` | No | `` |
| `IsFullMode` | `Boolean` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `RsfPlanStyle` | `Fence fence` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `ManuallyFencesPlanLayerOld` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Layers.ManuallyFencesPlanLayerOld` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Rsf.Layers.Layers.ManuallyFencesPlanLayerOld`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawer` | `FencesDrawer` | `get` | No | `` |
| `FenceTable` | `FenceTable` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Rsf` | `AlignmentRsf` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `PreliminaryFencesPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Layers.PreliminaryFencesPlanLayer` |
| **Base Type** | `Topomatic.Rsf.Layers.Layers.FencesPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Rsf.Layers.Layers.FencesPlanLayer`
        - `Topomatic.Rsf.Layers.Layers.PreliminaryFencesPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FenceTable` | `FenceTable` | `get` | No | `` |
| `IsFullMode` | `Boolean` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `RsfPlanStyle` | `Fence fence` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `RoundedFencesPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Layers.RoundedFencesPlanLayer` |
| **Base Type** | `Topomatic.Rsf.Layers.Layers.FencesPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Rsf.Layers.Layers.FencesPlanLayer`
        - `Topomatic.Rsf.Layers.Layers.RoundedFencesPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FenceTable` | `FenceTable` | `get` | No | `` |
| `IsFullMode` | `Boolean` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `RsfPlanStyle` | `Fence fence` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Namespace: `Topomatic.Rsf.Layers.Solvers`

### `RsfCommonSolving` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Solvers.RsfCommonSolving` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LocationSmtTitleTo_Chord` | `Int32` | `String title` | `` |
| `LocationSmtTitleTo_pcCode` | `Int32` | `String title` | `` |
| `MakeFencePoly` | `Polyline3D` | `RoadAlignment alignment, Double station1, Double station2, Double indentDist, Int32 pcCode` | `` |
| `MakeFencePolyEx` | `Polyline3D` | `RoadAlignment alignment, Double station1, Double station2, Double indentDist, Int32 pcCode, Dictionary<Double Dictionary<Int32 Double>> dic` | `` |

---
## Namespace: `Topomatic.Rsf.Layers.Utils`

### `FencePktStuff` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Utils.FencePktStuff` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `UpdatePkEByLastPoint` | `Void` | `Alignment alg, Fence fence` | `` |
| `UpdatePkSByFirstPoint` | `Void` | `Alignment alg, Fence fence` | `` |

---
## Namespace: `Topomatic.Rsf.Layers.Wrappers`

### `FenceWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Layers.Wrappers.FenceWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Rsf.Layers.Design.IFenceWrapper, Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Rsf.Fence, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICompoundLinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Fence fence)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeamLength` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `BeamModel` | `Guid` | `get/set` | No | `ConditionalBrowsable, Model3DLibraryItemGuid` |
| `BearingModel` | `Guid` | `get/set` | No | `ConditionalBrowsable, Model3DLibraryItemGuid` |
| `Fence` | `Fence` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence, PropertyTypeConverter` |
| `FenceMark` | `String` | `get/set` | No | `ConditionalBrowsable, PropertyEditor, PropertyUpdateSequence` |
| `FenceType` | `RsfSegmentType` | `get/set` | No | `ConditionalBrowsable` |
| `Flag` | `RsfFlag` | `get/set` | No | `` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `ObjectType` | `RsfObjectType` | `get/set` | No | `PropertyUpdateSequence` |
| `PostsStep` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `SegLength` | `Double` | `get` | No | `Length` |
| `SignalBarModel` | `Guid` | `get/set` | No | `ConditionalBrowsable, Model3DLibraryItemGuid` |
| `TypedObject` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |
| `VisFenceSide` | `RsfVisFencePosition` | `get/set` | No | `ConditionalBrowsable` |
| `VisFenceTexture` | `RsfVisFenceTexture` | `get/set` | No | `ConditionalBrowsable` |
| `VisSignalPostSide` | `RsfVisPostPosition` | `get/set` | No | `ConditionalBrowsable` |
| `WrappedObject` | `Fence` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IFenceWrapper` | `get_Fence` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IWrapped`1` | `get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `ILinearObject` | `GetPolyline` |
| `ICompoundLinearObject` | `GetPathList` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 13 |
| **Classes** | 6 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 5 |
| **Total Methods** | 30 |
| **Total Properties** | 42 |
| **Total Fields** | 12 |
| **Total Events** | 0 |
| **Total Constructors** | 7 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


