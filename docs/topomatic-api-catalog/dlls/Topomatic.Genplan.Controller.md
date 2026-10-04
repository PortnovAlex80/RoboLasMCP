# Topomatic.Genplan.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.GenPlan.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.GenPlan.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Genplan.Controller.dll` |

---
## Namespace: `Topomatic.GenPlan.Controller`

### `ConcentrationPointsParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanParams+ConcentrationPointsParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String[] eParams)`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ExecuteInSline` | `Boolean` | No | `` | `` |
| `ExecuteOnSline` | `Boolean` | No | `` | `` |
| `InLineStep` | `Double` | No | `` | `` |
| `InLineThreshold` | `Double` | No | `` | `` |
| `OnLineStep` | `Double` | No | `` | `` |
| `PointCode` | `Int32` | No | `` | `` |

### `GeneralLayoutExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GeneralLayoutExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `UInt32` | `Surface surface, xLibraryNode node` | `Extension` |
| `IsBase` | `Boolean` | `SurfacePoint point` | `Extension` |
| `IsConcentration` | `Boolean` | `SurfacePoint point` | `Extension` |
| `IsFixed` | `Boolean` | `SurfacePoint point` | `Extension` |
| `IsRelative` | `Boolean` | `SurfacePoint point` | `Extension` |
| `RefreshLineSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshPointSign` | `Void` | `Surface surface, SurfacePointExtensiveInformation information` | `Extension` |
| `RefreshPolygonSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshStructureLineSign` | `Void` | `Surface surface, Int32 index` | `Extension` |

### `GenPlanControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.GenPlan.Controller.GenPlanControllerPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GenPlanLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanLine` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(StructureLine structureLine)`
- `.ctor(List<Vector3D> pline)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GLPoint` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Points` | `List<GLPoint>` | `get` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExtractPart` | `Boolean` | `Double startSta, Double endSta, ref GenPlanLine extractedPart` | `` |
| `GetPositionsBetweenStations` | `List<Vector2D>` | `Double startSta, Double endSta, Boolean reverse` | `` |
| `PointIsCorner` | `Boolean` | `Double station` | `` |
| `PointIsCorner` | `Boolean` | `Int32 index` | `` |
| `PointIsInnerCorner` | `Boolean` | `Int32 index, Double offsetSign` | `` |
| `PosToSta` | `Double` | `Vector2D pos` | `` |
| `PosToSta` | `Double` | `Vector3D vertex` | `` |
| `PosToStaOffset` | `Boolean` | `Vector2D pos, ref Double sta, ref Double offset` | `` |
| `PosToStaOffset` | `Boolean` | `Vector3D pos, ref Double sta, ref Double offset` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double station, Double offset` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double station` | `` |
| `StaOffsetToPos` | `Vector2D[]` | `Double station, Double offset, Double angleThreshold` | `` |
| `StaOffsetToPos` | `Boolean` | `Double station, Double offset, ref Vector2D pos` | `` |
| `StaOffsetToPosWithElevation` | `Vector3D` | `Double station` | `` |
| `StationInLimits` | `Boolean` | `Double station, Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `StationInLimits` | `Boolean` | `Double station, Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd, Double eps` | `` |
| `TryGetElevation` | `Nullable<Double>` | `Vector2D pos` | `` |
| `TryGetElevation` | `Boolean` | `Double sta, ref Double elevation` | `` |
| `TryGetElevation` | `Boolean` | `Vector2D pos, ref Double elevation` | `` |
| `TryGetElevation` | `Nullable<Double>` | `Double sta` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsClosed` | `Boolean` | No | `` | `` |

#### Nested Types (1)

- `GLPoint` (class)

### `GenPlanParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_GenPlanDepthTag` | `String` | Yes | `"GenPlanDepth"` | `` |
| `c_GenPlanNameTag` | `String` | Yes | `"GenPlanName"` | `` |

#### Nested Types (4)

- `ConcentrationPointsParams` (class)
- `ObjectParams` (class)
- `SetPlaneElevationsMethod` (enum)
- `SetPlaneElevationsParams` (class)

### `GLPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanLine+GLPoint` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double station, Vector3D position, Double directionKx, Double directionKy, Double length, Double vertexKx, Double vertexKy)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionKxKy` | `Vector2D` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |
| `Vertex` | `Vector3D` | `get` | No | `` |
| `VertexKxKy` | `Vector2D` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OffsetToPosFromVertex` | `Vector2D` | `Double offset` | `` |
| `PosToStaOffset` | `Boolean` | `Vector2D pos, ref Double sta, ref Double offset` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double station, Double offset` | `` |

### `ObjectParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanParams+ObjectParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String[] parameters)`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AreaCode` | `Int32` | No | `` | `` |
| `CreatePatch` | `Boolean` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `IsClosed` | `Boolean` | No | `` | `` |
| `IsLimitation` | `Boolean` | No | `` | `` |
| `LinearCode` | `Int32` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `PointCode` | `Int32` | No | `` | `` |
| `ShowDialog` | `Boolean` | No | `` | `` |

### `SetPlaneElevationsMethod` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanParams+SetPlaneElevationsMethod` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.GenPlan.Controller.GenPlanParams+SetPlaneElevationsMethod`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByApproximatePlane` | `SetPlaneElevationsMethod` | Yes | `ByApproximatePlane` | `` |
| `ByThreePoints` | `SetPlaneElevationsMethod` | Yes | `ByThreePoints` | `` |
| `Unknown` | `SetPlaneElevationsMethod` | Yes | `Unknown` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Unknown` | `0` |
| `ByThreePoints` | `1` |
| `ByApproximatePlane` | `2` |

**Underlying Type**: `System.Int32`

### `SetPlaneElevationsParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.GenPlanParams+SetPlaneElevationsParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String[] eParams)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Method` | `SetPlaneElevationsMethod` | No | `` | `` |
| `Regen` | `Boolean` | No | `` | `` |

---
## Namespace: `Topomatic.GenPlan.Controller.Builders`

### `GenPlanConcentrationPointsBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.Builders.GenPlanConcentrationPointsBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearConcentrationPointsInsideSline` | `Void` | `Surface surface, StructureLine sline` | `` |
| `ClearConcentrationPointsOnSline` | `Void` | `Surface surface, StructureLine sline` | `` |
| `GenerateConcentrationPointsInsideSline` | `Void` | `Surface surface, StructureLine sline, Double step, Double threshold, Int32 pointCode` | `` |
| `GenerateConcentrationPointsOnSline` | `Void` | `Surface surface, StructureLine sline, Double step, Int32 pointCode` | `` |

---
## Namespace: `Topomatic.GenPlan.Controller.PartialDynamic`

### `AttributeEditorDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.AttributeEditorDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.GenPlan.Controller.PartialDynamic.AttributeEditorDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref Nullable<Int32> code, ref Nullable<Double> depth, ref Nullable<CadColor> color` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `eClickType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.PartDynamicGrip+eClickType` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.GenPlan.Controller.PartialDynamic.PartDynamicGrip+eClickType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AdvancedGrip` | `eClickType` | Yes | `AdvancedGrip` | `` |
| `Menu` | `eClickType` | Yes | `Menu` | `` |
| `Move` | `eClickType` | Yes | `Move` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Move` | `0` |
| `Menu` | `1` |
| `AdvancedGrip` | `2` |

**Underlying Type**: `System.Int32`

### `PartDynamicGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.PartDynamicGrip` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (4)

- `.ctor(Vector3D position, String moveMsg)`
- `.ctor(Vector3D position, String menuMsg, String[] menuItems, String selectedMenuItem)`
- `.ctor(Vector2D position, String[] menuItems, String menuMsg, Object[] storedObjects)`
- `.ctor(Vector2D position, String menuItem, String menuMsg, Object[] storedObjects)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Type` | `GripType` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawedPosition` | `Vector2D` | `CadView cadView` | `` |
| `GetInfo` | `Object` | `String key` | `` |
| `SetAngle` | `Void` | `Double angle, CadView cadView` | `` |
| `SetAngle` | `Void` | `Vector2D dirPos, CadView cadView` | `` |
| `SetInfo` | `Void` | `String key, Object value` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ClickType` | `eClickType` | No | `` | `` |
| `MenuItems` | `String[]` | No | `` | `` |
| `MenuMsg` | `String` | No | `` | `` |
| `SelectedItem` | `String` | No | `` | `` |
| `StoredObjects` | `Object[]` | No | `` | `` |

#### Nested Types (1)

- `eClickType` (enum)

---
## Namespace: `Topomatic.GenPlan.Controller.PartialDynamic.EarthWork`

### `EarthVolumesProgressBar` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.EarthWork.EarthVolumesProgressBar` |
| **Base Type** | `System.Windows.Forms.ProgressBar` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ProgressBar`
          - `Topomatic.GenPlan.Controller.PartialDynamic.EarthWork.EarthVolumesProgressBar`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.GenPlan.Controller.PartialDynamic.Road`

### `Road` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.Road.Road` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(StgNode node)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ID` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Road` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (16)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AddPointsEvenly` | `Boolean` | No | `` | `` |
| `AddPointsStep` | `Double` | No | `` | `` |
| `Code` | `Int32` | No | `` | `` |
| `Color` | `CadColor` | No | `` | `` |
| `ContourLineID` | `String` | No | `` | `` |
| `Depth` | `Double` | No | `` | `` |
| `DrawTestLines` | `Boolean` | No | `` | `` |
| `EdgeLineID` | `String` | No | `` | `` |
| `EndBasePos` | `Vector2D` | No | `` | `` |
| `EndEdgePos` | `Vector2D` | No | `` | `` |
| `EndGrade` | `Double` | No | `` | `` |
| `Grade` | `Double` | No | `` | `` |
| `SetAddPoints` | `Boolean` | No | `` | `` |
| `StartBasePos` | `Vector2D` | No | `` | `` |
| `StartEdgePos` | `Vector2D` | No | `` | `` |
| `UseEndGrade` | `Boolean` | No | `` | `` |

### `RoadDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.GenPlan.Controller.PartialDynamic.Road.RoadDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.GenPlan.Controller.PartialDynamic.Road.RoadDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref Road road` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 16 |
| **Classes** | 13 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 45 |
| **Total Properties** | 13 |
| **Total Fields** | 49 |
| **Total Events** | 0 |
| **Total Constructors** | 18 |
| **Nested Types** | 6 |
| **Extension Methods** | 0 |


