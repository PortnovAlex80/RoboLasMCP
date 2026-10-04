# Topomatic.Turnouts.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Turnouts.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Turnouts.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Turnouts.Layers.dll` |

---
## Namespace: `Topomatic.Turnouts.Layers`

### `BaseRailwaysPlanLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.BaseRailwaysPlanLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Turnouts.Layers.BaseRailwaysPlanLayer`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Centralized` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.LayersExtensions+Centralized` |
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
      - `Topomatic.Turnouts.Layers.LayersExtensions+Centralized`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Full` | `Centralized` | Yes | `Full` | `` |
| `None` | `Centralized` | Yes | `None` | `` |
| `Standart` | `Centralized` | Yes | `Standart` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Standart` | `1` |
| `Full` | `2` |

**Underlying Type**: `System.Int32`

### `GridironLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.GridironLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Turnouts.Layers.GridironLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Gridiron` | `Gridiron` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GridironSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `IGridironContainer` | `get_Gridiron` |

### `GridironSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.GridironLayer+GridironSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Turnouts.Layers.GridironLayer+GridironSelectionSet`

#### Constructors (1)

- `.ctor(GridironLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
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

### `GridironSubLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.GridironSubLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadViewLayer owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `CadViewLayer` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |

### `LayersExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.LayersExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (31)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateFlipPosition` | `Vector2D` | `Vector2D pos, Double textWidth, Double textHeight, Double angle, TextJustify justify` | `` |
| `CentralizeFromTurnout` | `Centralized` | `Turnout turnout` | `` |
| `CentralizeFromTurnout` | `Centralized` | `Turnout turnout, TurnoutPlanStyle style` | `` |
| `DrawAsymmetricTurnout` | `Void` | `CadView cadView, DeviceContext context, Vector2D start_pos, Vector2D center_pos, Vector2D add_center_pos, Vector2D first_pos, Vector2D second_pos, Vector2D rotation_mech_pos, Double m, Centralized centralized` | `` |
| `DrawAsymmetricTurnoutText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, AsymmetricTurnout turnout` | `` |
| `DrawBalancer` | `Void` | `CadView cadView, DeviceContext dc, Vector2D position, TurnoutDirection direction, Double length1, Double length2, Double rotation` | `` |
| `DrawBufferStop` | `Void` | `CadView cadView, DeviceContext dc, Vector2D position, Double rotation` | `` |
| `DrawDeafCrossTurnout` | `Void` | `CadView cadView, DeviceContext context, Vector2D start_pos, Vector2D end_pos, Vector2D center_pos, Vector2D second_start, Vector2D second_end` | `` |
| `DrawDeafCrossTurnoutText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, DeafCrossTurnout turnout` | `` |
| `DrawDoubleCrossTurnout` | `Void` | `CadView cadView, DeviceContext context, Vector2D start_pos, Vector2D end_pos, Vector2D center_pos, Vector2D second_start, Vector2D second_end, Centralized centralized` | `` |
| `DrawDoubleCrossTurnoutText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, DoubleCrossTurnout turnout` | `` |
| `DrawDropArrow` | `Void` | `CadView cadView, DeviceContext dc, Vector2D position, TurnoutDirection direction, TurnoutSideType side, Double length1, Double length2, Double rotation, Boolean manual` | `` |
| `DrawDropArrowText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, DropArrow turnout` | `` |
| `DrawJoint` | `Void` | `CadView cadView, DeviceContext dc, Vector2D position, Double rotation` | `` |
| `DrawJointlessJoint` | `Void` | `CadView cadView, DeviceContext dc, Vector2D position, Double rotation` | `` |
| `DrawSimpleTurnout` | `Void` | `CadView cadView, DeviceContext context, Vector2D start_pos, Vector2D center_pos, Vector2D end_pos, Vector2D second_pos, Vector2D rotation_mech_pos, Double m, Centralized centralized` | `` |
| `DrawSimpleTurnoutText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, SimpleTurnout turnout` | `` |
| `DrawSymmetricTurnout` | `Void` | `CadView cadView, DeviceContext context, Vector2D start_pos, Vector2D center_pos, Vector2D first_pos, Vector2D second_pos, Vector2D rotation_mech_pos, Double m, Centralized centralized` | `` |
| `DrawSymmetricTurnoutText` | `Void` | `CadView cadView, DeviceContext context, TextStandard standard, SymmetricTurnout turnout` | `` |
| `DrawTurnoutCommonBeam` | `Void` | `CadView cadView, GridironStyle style, DeviceContext context, IEnumerable<KeyValuePair<Vector2D Vector2D>> points` | `` |
| `DrawTurnoutControlPoints` | `Void` | `Turnout turnout, CadView cadView, GridironStyle style, DeviceContext context, TextStandard standard` | `` |
| `DrawTurnoutFoulingPoint` | `Void` | `DeviceContext context, Vector2D position` | `` |
| `GenerateBalancerJoint` | `Void` | `DwgBlock block, TurnoutDirection direction, Double length1, Double length2` | `` |
| `GenerateBufferStopBlock` | `Void` | `DwgBlock block` | `` |
| `GenerateDropArrow` | `Void` | `DwgBlock block, TurnoutDirection direction, TurnoutSideType side, Double length1, Double length2, Boolean manual` | `` |
| `GenerateJoint` | `Void` | `DwgBlock block` | `` |
| `GenerateJointlessJoint` | `Void` | `DwgBlock block` | `` |
| `GenerateSignalBlock` | `Void` | `ref DwgBlock block` | `` |
| `GetGridiron` | `Gridiron` | `Alignment alignment` | `Extension` |
| `HasGridiron` | `Boolean` | `Alignment alignment` | `Extension` |
| `TurnoutCrossMarkToString` | `String` | `TurnoutCrossMark crossMark, String crossMarkDescription` | `` |

#### Nested Types (1)

- `Centralized` (enum)

### `ProfileZoneLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.ProfileZoneLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseProfileLayer`
        - `Topomatic.Turnouts.Layers.ProfileZoneLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailWayLinkObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.RailwaysBuilder+RailWayLinkObject` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NextAlignment` | `Alignment` | No | `` | `` |
| `Object` | `GridironObject` | No | `` | `` |

### `RailwaysBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.RailwaysBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IModelFinder finder)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildRailway` | `List<CompoundLine>` | `RailWay way` | `` |
| `FindObject` | `RailWayLinkObject` | `RailWayLink l` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindStation` | `Double` | `Alignment alignment, GridironObject obj` | `` |
| `PrepareLine` | `CompoundLine` | `Alignment direction, GridironObject fromObj, GridironObject toObj` | `` |
| `SplitAlignment` | `CompoundLine` | `CompoundLine line, Double from, Double to` | `` |

#### Nested Types (1)

- `RailWayLinkObject` (class)

### `RailwaysCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.RailwaysCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Turnouts.Railways.IRailWaysContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Turnouts.Layers.RailwaysCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Model` | `RailwaysModel` | `get/set` | No | `` |
| `RailWays` | `RailWays` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `GetSubLayers` |
| `IRailWaysContainer` | `get_RailWays` |

### `RailwaysPlanCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.RailwaysPlanCompoundLayer` |
| **Base Type** | `Topomatic.Turnouts.Layers.RailwaysCompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Turnouts.Railways.IRailWaysContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Turnouts.Layers.RailwaysCompoundLayer`
        - `Topomatic.Turnouts.Layers.RailwaysPlanCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `RailwaysPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.RailwaysPlanLayer` |
| **Base Type** | `Topomatic.Turnouts.Layers.BaseRailwaysPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Turnouts.Layers.BaseRailwaysPlanLayer`
      - `Topomatic.Turnouts.Layers.RailwaysPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Namespace: `Topomatic.Turnouts.Layers.Design`

### `BlockJointTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.BlockJointTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.BlockJointTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `JointlessJointTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.JointlessJointTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.JointlessJointTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LinkTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.LinkTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.LinkTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RailWayTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.RailWayTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.RailWayTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SleeperMaterialTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.SleeperMaterialTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.SleeperMaterialTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TurnoutCrossMarkEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.TurnoutCrossMarkEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.TurnoutCrossMarkEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TurnoutDirectionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.TurnoutDirectionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.TurnoutDirectionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TurnoutRotationEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.TurnoutRotationEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.TurnoutRotationEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TurnoutSideTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.TurnoutSideTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.TurnoutSideTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TurnoutTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Design.TurnoutTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Turnouts.Layers.Design.TurnoutTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Turnouts.Layers.Wrappers`

### `GridironObjectWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Wrappers.GridironObjectWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `WrappedObject` | `GridironObject` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

### `RailWayWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Layers.Wrappers.RailWayWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Turnouts.Railways.RailWay, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IList<CompoundLine> lines, RailWay railway)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Lines` | `IEnumerable<CompoundLine>` | `get` | No | `Browsable` |
| `Number` | `String` | `get` | No | `` |
| `RailType` | `TypedObject` | `get/set` | No | `ImObjectPropertyProvider` |
| `RailwayType` | `RailwayType` | `get` | No | `PropertyTypeConverter` |
| `WrappedObject` | `RailWay` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 24 |
| **Classes** | 19 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 3 |
| **Static Classes** | 1 |
| **Total Methods** | 54 |
| **Total Properties** | 27 |
| **Total Fields** | 10 |
| **Total Events** | 0 |
| **Total Constructors** | 20 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


