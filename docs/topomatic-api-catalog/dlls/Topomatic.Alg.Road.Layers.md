# Topomatic.Alg.Road.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Road.Layers`

### `AlgRoadUrbLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.AlgRoadUrbLayer` |
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
      - `Topomatic.Alg.Road.Layers.AlgRoadUrbLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `RoadAlignment` | `RoadAlignment` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Urb` | `UrbParams` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `UrbSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `EdgeTraysLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.EdgeTraysLayer` |
| **Base Type** | `Topomatic.Alg.Road.Layers.TraysLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.Layers.TraysLayer`
        - `Topomatic.Alg.Road.Layers.EdgeTraysLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.RoadPlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgPlanLayer`
        - `Topomatic.Alg.Road.Layers.RoadPlanLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadRenewSectionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.RoadRenewSectionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Alg.Road.Layers.RoadRenewSectionLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |

### `RoadSectionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.RoadSectionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.BaseSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Alg.Layers.BaseSectionLayer`
          - `Topomatic.Alg.Road.Layers.RoadSectionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadTransitionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.RoadTransitionsLayer` |
| **Base Type** | `Topomatic.Alg.Layers.ProjectTransitionsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseProfileLayer`
        - `Topomatic.Alg.Layers.ProjectTransitionsLayer`
          - `Topomatic.Alg.Road.Layers.RoadTransitionsLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |

### `ServiceConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.ServiceConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (41)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DescentL1` | `Int32` | Yes | `3` | `` |
| `DescentL2` | `Int32` | Yes | `4` | `` |
| `DescentRadius` | `Int32` | Yes | `2` | `` |
| `DirectionStripDividerLength` | `Int32` | Yes | `7` | `` |
| `DirectionStripDividerOtgon` | `Int32` | Yes | `9` | `` |
| `DirectionStripDividerWidth` | `Int32` | Yes | `8` | `` |
| `DirectionStripLength` | `Int32` | Yes | `5` | `` |
| `DirectionStripLengthAfter` | `Int32` | Yes | `12` | `` |
| `DirectionStripLengthBefore` | `Int32` | Yes | `11` | `` |
| `DirectionStripMiddleWidth` | `Int32` | Yes | `10` | `` |
| `DirectionStripWidth` | `Int32` | Yes | `6` | `` |
| `DividerColor` | `Int32` | Yes | `33` | `` |
| `DividerHatch` | `Int32` | Yes | `34` | `` |
| `DividerLength` | `Int32` | Yes | `19` | `` |
| `DividerOtgon` | `Int32` | Yes | `21` | `` |
| `DividerWidth` | `Int32` | Yes | `20` | `` |
| `DropShapedIslandLength` | `Int32` | Yes | `13` | `` |
| `DropShapedIslandWidth` | `Int32` | Yes | `14` | `` |
| `ExtendedPspLength` | `Int32` | Yes | `39` | `` |
| `ExtendedPspOtgon` | `Int32` | Yes | `41` | `` |
| `ExtendedPspWidth` | `Int32` | Yes | `40` | `` |
| `IslandBroadeningLength` | `Int32` | Yes | `36` | `` |
| `IslandBroadeningWidthLeft` | `Int32` | Yes | `37` | `` |
| `IslandBroadeningWidthRight` | `Int32` | Yes | `38` | `` |
| `LeftRotationRadius` | `Int32` | Yes | `1` | `` |
| `PspGrade` | `Int32` | Yes | `17` | `` |
| `PspJump` | `Int32` | Yes | `35` | `` |
| `PspLength` | `Int32` | Yes | `15` | `` |
| `PspOtgon` | `Int32` | Yes | `18` | `` |
| `PspWidth` | `Int32` | Yes | `16` | `` |
| `Side1WidthEnd` | `Int32` | Yes | `29` | `` |
| `Side1WidthMiddle` | `Int32` | Yes | `26` | `` |
| `Side1WidthStart` | `Int32` | Yes | `23` | `` |
| `Side3WidthEnd` | `Int32` | Yes | `30` | `` |
| `Side3WidthMiddle` | `Int32` | Yes | `27` | `` |
| `Side3WidthStart` | `Int32` | Yes | `24` | `` |
| `SideWidthEnd` | `Int32` | Yes | `28` | `` |
| `SideWidthMiddle` | `Int32` | Yes | `25` | `` |
| `SideWidthStart` | `Int32` | Yes | `22` | `` |
| `StripColor` | `Int32` | Yes | `31` | `` |
| `StripHatch` | `Int32` | Yes | `32` | `` |

### `TelescopicTraysLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.TelescopicTraysLayer` |
| **Base Type** | `Topomatic.Alg.Road.Layers.TraysLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.Layers.TraysLayer`
        - `Topomatic.Alg.Road.Layers.TelescopicTraysLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TraysLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.TraysLayer` |
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
      - `Topomatic.Alg.Road.Layers.TraysLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `RoadAlignment` | `RoadAlignment` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `UrbSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.AlgRoadUrbLayer+UrbSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Alg.Road.Layers.AlgRoadUrbLayer+UrbSelectionSet`

#### Constructors (1)

- `.ctor(AlgRoadUrbLayer layer)`

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
## Namespace: `Topomatic.Alg.Road.Layers.Design`

### `BorderPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.BorderPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.BorderPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DescentDirectionPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.DescentDirectionPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.DescentDirectionPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DescentExcludedPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.DescentExcludedPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.DescentExcludedPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DescentPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.DescentPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.DescentPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DropShapedIslandRadiusPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.DropShapedIslandRadiusPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.DropShapedIslandRadiusPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `EdgeTrayTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.EdgeTrayTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.EdgeTrayTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `HolePositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.HolePositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.HolePositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `IslandDirectionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.IslandDirectionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.IslandDirectionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ReversalAreaTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.ReversalAreaTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.ReversalAreaTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StopPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.StopPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.StopPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StripExtensionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.StripExtensionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.StripExtensionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StripHatchEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.StripHatchEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.StripHatchEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StripPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.StripPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.StripPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TelescopicTrayTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TelescopicTrayTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TelescopicTrayTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrayBottomTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TrayBottomTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TrayBottomTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrayDirectionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TrayDirectionConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TrayDirectionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrayHeadTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TrayHeadTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TrayHeadTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrayHeadWaterTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TrayHeadWaterTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TrayHeadWaterTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrayPositionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TrayPositionConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TrayPositionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TraySideConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TraySideConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TraySideConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TriangleIslandPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.TriangleIslandPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.TriangleIslandPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `UserStripAppointmentEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.UserStripAppointmentEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.UserStripAppointmentEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `UserStripPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.UserStripPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.UserStripPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `UserStripPriorityEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Design.UserStripPriorityEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Layers.Design.UserStripPriorityEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Road.Layers.Wrappers`

### `BaseTrayWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Wrappers.BaseTrayWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ILayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `WrappedObject` | `Object` | `get/set` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Double annotationScale, Boolean enable` | `` |
| `GetDisjoiner` | `IObjectDisjoiner` | `` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `EdgeTrayWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Wrappers.EdgeTrayWrapper` |
| **Base Type** | `Topomatic.Alg.Road.Layers.Wrappers.BaseTrayWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Road.Layers.Wrappers.BaseTrayWrapper`
    - `Topomatic.Alg.Road.Layers.Wrappers.EdgeTrayWrapper`

#### Constructors (1)

- `.ctor(ILayer layer, EdgeTray tray)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Direction` | `TrayDirection` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `EndStation` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `Offset` | `Double` | `get/set` | No | `PropertyUpdateSequence, Length` |
| `Position` | `TrayPosition` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `Side` | `TraySide` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `StartStation` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `TrayType` | `EdgeTrayType` | `get/set` | No | `PropertyTypeConverter` |
| `WrappedObject` | `Object` | `get/set` | No | `Browsable` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Double annotationScale, Boolean enable` | `` |
| `GetDisjoiner` | `IObjectDisjoiner` | `` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateEntitys` | `List<DwgEntity>` | `RoadAlignment alignment, EdgeTraysStyle style, TraySide side, TrayPosition position, TrayDirection direction, Double from, Double to, Double trayOffset` | `` |
| `CreatePolyline` | `DwgPolyline` | `RoadAlignment alignment, TraySide side, TrayPosition position, Double from, Double to, Double trayOffset` | `` |
| `CreatePolyline3D` | `Polyline3D` | `RoadAlignment alignment, TraySide side, TrayPosition position, Double from, Double to, Double trayOffset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |

### `TelescopicTrayWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Layers.Wrappers.TelescopicTrayWrapper` |
| **Base Type** | `Topomatic.Alg.Road.Layers.Wrappers.BaseTrayWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Alg.Layers.Design.IOrientation, Topomatic.Cad.Foundation.IPointObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Road.Layers.Wrappers.BaseTrayWrapper`
    - `Topomatic.Alg.Road.Layers.Wrappers.TelescopicTrayWrapper`

#### Constructors (1)

- `.ctor(ILayer layer, TelescopicTray tray)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get` | No | `Browsable` |
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `BottomType` | `TrayBottomType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `HeadType` | `TrayHeadType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Offset` | `Double` | `get/set` | No | `Length, PropertyUpdateSequence` |
| `Rotation` | `Double` | `get/set` | No | `Orientation, PropertyUpdateSequence` |
| `Side` | `TraySide` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Station` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `TrayType` | `TelescopicTrayType` | `get/set` | No | `PropertyTypeConverter` |
| `WaterType` | `TelescopicTrayWaterType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `WrappedObject` | `Object` | `get/set` | No | `Browsable` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Double annotationScale, Boolean enable` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetDisjoiner` | `IObjectDisjoiner` | `` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `CadView cadView` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateEntitys` | `List<DwgEntity>` | `RoadAlignment alignment, TelescopicTraysStyle style, TraySide side, TrayHeadType headType, TelescopicTrayWaterType waterType, TrayBottomType bottomType, Double station, Double length, Vector2D textOffset, Vector2D axis, Vector2D head, Vector2D start, Vector2D end` | `` |
| `GetDefaultLinePositions` | `Vector2D` | `RoadAlignment alignment, TextStandard standard, Vector2D start, Vector2D end` | `` |
| `GetDefaultTextPositions` | `Vector2D` | `RoadAlignment alignment, TextStandard standard, TraySide side, Vector2D start, Vector2D end` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IOrientation` | `get_Angle` |
| `IPointObject` | `get_BasePoint` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 34 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 1 |
| **Total Methods** | 40 |
| **Total Properties** | 35 |
| **Total Fields** | 45 |
| **Total Events** | 0 |
| **Total Constructors** | 36 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


