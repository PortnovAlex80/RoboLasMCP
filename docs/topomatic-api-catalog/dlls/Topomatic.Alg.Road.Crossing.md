# Topomatic.Alg.Road.Crossing

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.Crossing` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.Crossing.dll` |

---
## Namespace: `Topomatic.Alg.Road.Crossing`

### `Crossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.OtherRoadContainer` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`

#### Constructors (3)

- `.ctor(Object parent, Crossing crossing)`
- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, String relativePath)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RoadRelativePath` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `CrossingConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.CrossingConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (23)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ALIAS_BACKWARD_DIRECTION_ISLAND` | `UInt32` | Yes | `15` | `` |
| `ALIAS_BACKWARD_DROP_SHAPED_ISLAND` | `UInt32` | Yes | `1` | `` |
| `ALIAS_EMPTY` | `UInt32` | Yes | `0` | `` |
| `ALIAS_FORWARD_DIRECTION_ISLAND` | `UInt32` | Yes | `16` | `` |
| `ALIAS_FORWARD_DROP_SHAPED_ISLAND` | `UInt32` | Yes | `2` | `` |
| `ALIAS_LEFT_BACKWARD_BROADENING_STRIP` | `UInt32` | Yes | `20` | `` |
| `ALIAS_LEFT_BACKWARD_DESCENT` | `UInt32` | Yes | `8` | `` |
| `ALIAS_LEFT_EXCLUDE` | `UInt32` | Yes | `13` | `` |
| `ALIAS_LEFT_FORWARD_BROADENING_STRIP` | `UInt32` | Yes | `18` | `` |
| `ALIAS_LEFT_FORWARD_DESCENT` | `UInt32` | Yes | `7` | `` |
| `ALIAS_LEFT_HOLE` | `UInt32` | Yes | `11` | `` |
| `ALIAS_RIGHT_BACKWARD_BROADENING_STRIP` | `UInt32` | Yes | `21` | `` |
| `ALIAS_RIGHT_BACKWARD_DESCENT` | `UInt32` | Yes | `10` | `` |
| `ALIAS_RIGHT_EXCLUDE` | `UInt32` | Yes | `14` | `` |
| `ALIAS_RIGHT_FORWARD_BROADENING_STRIP` | `UInt32` | Yes | `19` | `` |
| `ALIAS_RIGHT_FORWARD_DESCENT` | `UInt32` | Yes | `9` | `` |
| `ALIAS_RIGHT_HOLE` | `UInt32` | Yes | `12` | `` |
| `ALIAS_TRIANGLE_ISLAND_END` | `UInt32` | Yes | `6` | `` |
| `ALIAS_TRIANGLE_ISLAND_MIDDLE_WITH_MARKING` | `UInt32` | Yes | `4` | `` |
| `ALIAS_TRIANGLE_ISLAND_MIDDLE_WITHOUT_MARKING` | `UInt32` | Yes | `5` | `` |
| `ALIAS_TRIANGLE_ISLAND_START` | `UInt32` | Yes | `3` | `` |
| `ALIAS_TRIANGLE_ISLAND_START_DIVIDER` | `UInt32` | Yes | `17` | `` |
| `PluginID` | `String` | Yes | `` | `` |

### `Crossings` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Crossings` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Road.Crossing.ICrossingContainer, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Crossing.Crossings`

#### Constructors (1)

- `.ctor(Object owner, IntersectionBuilder[] builders)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Intersection` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Style` | `CrossingsStyle` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Intersection intersection` | `` |
| `Build` | `Void` | `Intersection item` | `` |
| `Clear` | `Void` | `Boolean removeLinked` | `` |
| `InsideLimits` | `Boolean` | `Intersection item, Double startstation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `Intersection intersection` | `` |
| `RemoveAt` | `Void` | `Int32 index, Boolean removeLinked` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICrossingContainer` | `Topomatic.Alg.Road.Crossing.ICrossingContainer.get_Crossings` |
| `IAlignmentContainer` | `get_Alignment` |

### `CrossingsExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.CrossingsExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCrossings` | `Crossings` | `Alignment alignment` | `Extension` |
| `RemoveLinkedObjects` | `Void` | `Intersection intersection` | `Extension` |
| `TryIntersectDescentAlignments` | `Boolean` | `CompoundLine majorRoad, CompoundLine minorRoad, DescentDirection descentDirection, ref Vector2D intersectionPosition, ref Double majorStation, ref Double minorStation, ref Double tangent` | `` |

### `DescentDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.DescentDirection` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Crossing.DescentDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `First` | `DescentDirection` | Yes | `First` | `` |
| `Last` | `DescentDirection` | Yes | `Last` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `First` | `0` |
| `Last` | `1` |

**Underlying Type**: `System.Int32`

### `ICrossingContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.ICrossingContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Crossings` | `Crossings` | `get` | No | `` |

### `Intersection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Intersection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.Intersection, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.Intersection`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Intersection intersection)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CrossPosition` | `Vector2D` | `get/set` | No | `` |
| `CrossPositionFinded` | `Boolean` | `get/set` | No | `` |
| `Direction` | `IntersectionDirection` | `get/set` | No | `` |
| `LastCrossStation` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `UserSignatureDelta` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Intersection` | `Object parent` | `` |
| `Equals` | `Boolean` | `Intersection other` | `` |
| `GetContainers` | `IEnumerable<KeyValuePair<OtherRoadAttachment Crossing>>` | `` | `` |
| `GetUrbObjectAttachment` | `KeyValuePair<UInt32 OtherRoadAttachment>` | `Guid id` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `IntersectionBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.IntersectionBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IntersectionType` | `Type` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `Intersection current` | `` |
| `InsideLimits` | `Boolean` | `Intersection intersection, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Remove` | `Void` | `Intersection current` | `` |

### `IntersectionDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.IntersectionDirection` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Crossing.IntersectionDirection`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Intersection` | `IntersectionDirection` | Yes | `Intersection` | `` |
| `LeftDescent` | `IntersectionDirection` | Yes | `LeftDescent` | `` |
| `RightDescent` | `IntersectionDirection` | Yes | `RightDescent` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftDescent` | `0` |
| `RightDescent` | `1` |
| `Intersection` | `2` |

**Underlying Type**: `System.Int32`

### `MinorRoadPspPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.MinorRoadPspPosition` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Crossing.MinorRoadPspPosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `After` | `MinorRoadPspPosition` | Yes | `After` | `` |
| `Before` | `MinorRoadPspPosition` | Yes | `Before` | `` |
| `Both` | `MinorRoadPspPosition` | Yes | `Both` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Both` | `0` |
| `Before` | `1` |
| `After` | `2` |

**Underlying Type**: `System.Int32`

### `MultiLevelMajorRoadDescentCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.MultiLevelMajorRoadDescentCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.MultiLevelMajorRoadDescentCrossing`

#### Constructors (2)

- `.ctor(Object parent, MultiLevelMajorRoadDescentCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ExtendedPspLength` | `Double` | `get/set` | No | `` |
| `ExtendedPspOtgon` | `Double` | `get/set` | No | `` |
| `ExtendedPspWidth` | `Double` | `get/set` | No | `` |
| `HasPsp` | `Boolean` | `get/set` | No | `` |
| `PspDividerLength` | `Double` | `get/set` | No | `` |
| `PspDividerOtgon` | `Double` | `get/set` | No | `` |
| `PspDividerWidth` | `Double` | `get/set` | No | `` |
| `PspGrade` | `Double` | `get/set` | No | `` |
| `PspJump` | `Double` | `get/set` | No | `` |
| `PspLength` | `Double` | `get/set` | No | `` |
| `PspOtgon` | `Double` | `get/set` | No | `` |
| `PspWidth` | `Double` | `get/set` | No | `` |
| `Side1WidthEnd` | `Double` | `get/set` | No | `` |
| `Side1WidthMiddle` | `Double` | `get/set` | No | `` |
| `Side1WidthStart` | `Double` | `get/set` | No | `` |
| `Side3WidthEnd` | `Double` | `get/set` | No | `` |
| `Side3WidthMiddle` | `Double` | `get/set` | No | `` |
| `Side3WidthStart` | `Double` | `get/set` | No | `` |
| `SideWidthEnd` | `Double` | `get/set` | No | `` |
| `SideWidthMiddle` | `Double` | `get/set` | No | `` |
| `SideWidthStart` | `Double` | `get/set` | No | `` |
| `UsePspGrade` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `MultiLevelMinorRoadDescentCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.MultiLevelMinorRoadDescentCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.MultiLevelMinorRoadDescentCrossing`

#### Constructors (2)

- `.ctor(Object parent, MultiLevelMinorRoadDescentCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `MultiLevelRoadDescent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.MultiLevelRoadDescent` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Intersection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.Intersection, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.Intersection`
      - `Topomatic.Alg.Road.Crossing.MultiLevelRoadDescent`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, MultiLevelRoadDescent intersection)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsphaltSectionCount` | `Int32` | `get/set` | No | `` |
| `DescentCrossing` | `MultiLevelMinorRoadDescentCrossing` | `get` | No | `` |
| `DescentDirection` | `MultiLevelRoadDescentDirection` | `get/set` | No | `` |
| `DividerColor` | `CadColor` | `get/set` | No | `` |
| `DividerHatch` | `StripHatch` | `get/set` | No | `` |
| `LinkingInEdgeRadius` | `Double` | `get/set` | No | `` |
| `LinkingOutEdgeRadius` | `Double` | `get/set` | No | `` |
| `MajorCrossing` | `MultiLevelMajorRoadDescentCrossing` | `get` | No | `` |
| `RadiusSectionCount` | `Int32` | `get/set` | No | `` |
| `SideSectionCount` | `Int32` | `get/set` | No | `` |
| `StripColor` | `CadColor` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `UseLinkingRadius` | `Boolean` | `get/set` | No | `` |
| `UseUrbSides` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Intersection` | `Object parent` | `` |
| `Equals` | `Boolean` | `Intersection other` | `` |
| `GetContainers` | `IEnumerable<KeyValuePair<OtherRoadAttachment Crossing>>` | `` | `` |
| `GetUrbObjectAttachment` | `KeyValuePair<UInt32 OtherRoadAttachment>` | `Guid id` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MAJOR_ID` | `UInt32` | Yes | `1` | `` |
| `MINOR_ID` | `UInt32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `MultiLevelRoadDescentDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.MultiLevelRoadDescentDirection` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Crossing.MultiLevelRoadDescentDirection`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auto` | `MultiLevelRoadDescentDirection` | Yes | `Auto` | `` |
| `First` | `MultiLevelRoadDescentDirection` | Yes | `First` | `` |
| `Last` | `MultiLevelRoadDescentDirection` | Yes | `Last` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Auto` | `0` |
| `First` | `1` |
| `Last` | `2` |

**Underlying Type**: `System.Int32`

### `OtherRoadAttachment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.OtherRoadAttachment` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Alg.Road.Crossing.OtherRoadAttachment`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Descent` | `OtherRoadAttachment` | Yes | `Descent` | `` |
| `Major` | `OtherRoadAttachment` | Yes | `Major` | `` |
| `Minor` | `OtherRoadAttachment` | Yes | `Minor` | `` |
| `None` | `OtherRoadAttachment` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Minor` | `1` |
| `Major` | `2` |
| `Descent` | `3` |

**Underlying Type**: `System.Int32`

### `OtherRoadContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.OtherRoadContainer` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`

#### Constructors (2)

- `.ctor(Object owner, OtherRoadContainer container)`
- `.ctor(Object owner, UInt32 id)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `LockedObjectKeysCount` | `Int32` | `get` | No | `` |
| `LockedSectionIdsCount` | `Int32` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddLockedObjectKey` | `Void` | `Guid id, UInt32 alias` | `` |
| `AddLockedSectionId` | `Void` | `UInt32 id` | `` |
| `Clear` | `Void` | `` | `` |
| `ContainsLockedObjectKey` | `UInt32` | `Guid id` | `` |
| `ContainsLockedSectionId` | `Boolean` | `UInt32 id` | `` |
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `GetLockedObjectKey` | `KeyValuePair<Guid UInt32>` | `Int32 index` | `` |
| `GetLockedSectionId` | `UInt32` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveLockedObjectKey` | `Boolean` | `Guid id` | `` |
| `RemoveLockedSectionId` | `Boolean` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `SingleLevelDescentCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelDescentCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.SingleLevelDescentCrossing`

#### Constructors (3)

- `.ctor(Object parent, SingleLevelDescentCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, String roadRelativePath, Double l1, Double radius, Double l2)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `L1` | `Double` | `get/set` | No | `` |
| `L2` | `Double` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelMajorRoadDescentCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelMajorRoadDescentCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.SingleLevelMajorRoadDescentCrossing`

#### Constructors (2)

- `.ctor(Object parent, SingleLevelMajorRoadDescentCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Properties (46)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardPspDividerLength` | `Double` | `get/set` | No | `` |
| `BackwardPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `BackwardPspDividerWidth` | `Double` | `get/set` | No | `` |
| `BackwardPspGrade` | `Double` | `get/set` | No | `` |
| `BackwardPspJump` | `Double` | `get/set` | No | `` |
| `BackwardPspLength` | `Double` | `get/set` | No | `` |
| `BackwardPspOtgon` | `Double` | `get/set` | No | `` |
| `BackwardPspUseGrade` | `Boolean` | `get/set` | No | `` |
| `BackwardPspWidth` | `Double` | `get/set` | No | `` |
| `BackwardSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardSide1WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardSide3WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardSideWidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardSideWidthStart` | `Double` | `get/set` | No | `` |
| `ForwardPspDividerLength` | `Double` | `get/set` | No | `` |
| `ForwardPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `ForwardPspDividerWidth` | `Double` | `get/set` | No | `` |
| `ForwardPspGrade` | `Double` | `get/set` | No | `` |
| `ForwardPspJump` | `Double` | `get/set` | No | `` |
| `ForwardPspLength` | `Double` | `get/set` | No | `` |
| `ForwardPspOtgon` | `Double` | `get/set` | No | `` |
| `ForwardPspUseGrade` | `Boolean` | `get/set` | No | `` |
| `ForwardPspWidth` | `Double` | `get/set` | No | `` |
| `ForwardSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardSide1WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardSide3WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardSideWidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardSideWidthStart` | `Double` | `get/set` | No | `` |
| `IslandLength` | `Double` | `get/set` | No | `` |
| `IslandWidth` | `Double` | `get/set` | No | `` |
| `LengthAfterMiddle` | `Double` | `get/set` | No | `` |
| `LengthBeforeMiddle` | `Double` | `get/set` | No | `` |
| `MiddleWidth` | `Double` | `get/set` | No | `` |
| `StopDividerLength` | `Double` | `get/set` | No | `` |
| `StopDividerOtgon` | `Double` | `get/set` | No | `` |
| `StopDividerWidth` | `Double` | `get/set` | No | `` |
| `StopLength` | `Double` | `get/set` | No | `` |
| `StopWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelMajorRoadInterSectionCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelMajorRoadInterSectionCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.SingleLevelMajorRoadInterSectionCrossing`

#### Constructors (2)

- `.ctor(Object parent, SingleLevelMajorRoadInterSectionCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Properties (88)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardLeftPspDividerLength` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspDividerWidth` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspGrade` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspJump` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspLength` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspOtgon` | `Double` | `get/set` | No | `` |
| `BackwardLeftPspWidth` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide1WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardLeftSide3WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardLeftSideWidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardLeftSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardLeftSideWidthStart` | `Double` | `get/set` | No | `` |
| `BackwardLeftUsePspGrade` | `Boolean` | `get/set` | No | `` |
| `BackwardLengthAfterMiddle` | `Double` | `get/set` | No | `` |
| `BackwardLengthBeforeMiddle` | `Double` | `get/set` | No | `` |
| `BackwardMiddleWidth` | `Double` | `get/set` | No | `` |
| `BackwardRightPspDividerLength` | `Double` | `get/set` | No | `` |
| `BackwardRightPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `BackwardRightPspDividerWidth` | `Double` | `get/set` | No | `` |
| `BackwardRightPspGrade` | `Double` | `get/set` | No | `` |
| `BackwardRightPspJump` | `Double` | `get/set` | No | `` |
| `BackwardRightPspLength` | `Double` | `get/set` | No | `` |
| `BackwardRightPspOtgon` | `Double` | `get/set` | No | `` |
| `BackwardRightPspWidth` | `Double` | `get/set` | No | `` |
| `BackwardRightSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardRightSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardRightSide1WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardRightSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardRightSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardRightSide3WidthStart` | `Double` | `get/set` | No | `` |
| `BackwardRightSideWidthEnd` | `Double` | `get/set` | No | `` |
| `BackwardRightSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `BackwardRightSideWidthStart` | `Double` | `get/set` | No | `` |
| `BackwardRightUsePspGrade` | `Boolean` | `get/set` | No | `` |
| `BackwardStopDividerLength` | `Double` | `get/set` | No | `` |
| `BackwardStopDividerOtgon` | `Double` | `get/set` | No | `` |
| `BackwardStopDividerWidth` | `Double` | `get/set` | No | `` |
| `BackwardStopLength` | `Double` | `get/set` | No | `` |
| `BackwardStopWidth` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspDividerLength` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspDividerWidth` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspGrade` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspJump` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspLength` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspOtgon` | `Double` | `get/set` | No | `` |
| `ForwardLeftPspWidth` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide1WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardLeftSide3WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardLeftSideWidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardLeftSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardLeftSideWidthStart` | `Double` | `get/set` | No | `` |
| `ForwardLeftUsePspGrade` | `Boolean` | `get/set` | No | `` |
| `ForwardLengthAfterMiddle` | `Double` | `get/set` | No | `` |
| `ForwardLengthBeforeMiddle` | `Double` | `get/set` | No | `` |
| `ForwardMiddleWidth` | `Double` | `get/set` | No | `` |
| `ForwardRightPspDividerLength` | `Double` | `get/set` | No | `` |
| `ForwardRightPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `ForwardRightPspDividerWidth` | `Double` | `get/set` | No | `` |
| `ForwardRightPspGrade` | `Double` | `get/set` | No | `` |
| `ForwardRightPspJump` | `Double` | `get/set` | No | `` |
| `ForwardRightPspLength` | `Double` | `get/set` | No | `` |
| `ForwardRightPspOtgon` | `Double` | `get/set` | No | `` |
| `ForwardRightPspWidth` | `Double` | `get/set` | No | `` |
| `ForwardRightSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardRightSide1WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardRightSide1WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardRightSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardRightSide3WidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardRightSide3WidthStart` | `Double` | `get/set` | No | `` |
| `ForwardRightSideWidthEnd` | `Double` | `get/set` | No | `` |
| `ForwardRightSideWidthMiddle` | `Double` | `get/set` | No | `` |
| `ForwardRightSideWidthStart` | `Double` | `get/set` | No | `` |
| `ForwardRightUsePspGrade` | `Boolean` | `get/set` | No | `` |
| `ForwardStopDividerLength` | `Double` | `get/set` | No | `` |
| `ForwardStopDividerOtgon` | `Double` | `get/set` | No | `` |
| `ForwardStopDividerWidth` | `Double` | `get/set` | No | `` |
| `ForwardStopLength` | `Double` | `get/set` | No | `` |
| `ForwardStopWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelMinorRoadDescentCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelMinorRoadDescentCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.SingleLevelMinorRoadDescentCrossing`

#### Constructors (2)

- `.ctor(Object parent, SingleLevelMinorRoadDescentCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasIslandBroadening` | `Boolean` | `get/set` | No | `` |
| `IslandBroadeningLength` | `Double` | `get/set` | No | `` |
| `IslandBroadeningWidthAfter` | `Double` | `get/set` | No | `` |
| `IslandBroadeningWidthBefore` | `Double` | `get/set` | No | `` |
| `IslandLength` | `Double` | `get/set` | No | `` |
| `IslandWidth` | `Double` | `get/set` | No | `` |
| `MajorRoadLeftRotationRadius` | `Double` | `get/set` | No | `` |
| `MinorRoadPspPosition` | `MinorRoadPspPosition` | `get/set` | No | `` |
| `PspBackwardLength` | `Double` | `get/set` | No | `` |
| `PspForwardLength` | `Double` | `get/set` | No | `` |
| `PspJump` | `Double` | `get/set` | No | `` |
| `PspLength` | `Double` | `get/set` | No | `` |
| `PspWidth` | `Double` | `get/set` | No | `` |
| `Side1WidthEnd` | `Double` | `get/set` | No | `` |
| `Side1WidthStart` | `Double` | `get/set` | No | `` |
| `Side3WidthEnd` | `Double` | `get/set` | No | `` |
| `Side3WidthStart` | `Double` | `get/set` | No | `` |
| `SideWidthEnd` | `Double` | `get/set` | No | `` |
| `SideWidthStart` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelMinorRoadInterSectionCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelMinorRoadInterSectionCrossing` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Crossing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.OtherRoadContainer, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.OtherRoadContainer`
      - `Topomatic.Alg.Road.Crossing.Crossing`
        - `Topomatic.Alg.Road.Crossing.SingleLevelMinorRoadInterSectionCrossing`

#### Constructors (2)

- `.ctor(Object parent, SingleLevelMinorRoadInterSectionCrossing crossing)`
- `.ctor(Object parent, UInt32 id)`

#### Properties (34)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasIslandBroadening` | `Boolean` | `get/set` | No | `` |
| `IslandBroadeningLength` | `Double` | `get/set` | No | `` |
| `IslandBroadeningWidthAfter` | `Double` | `get/set` | No | `` |
| `IslandBroadeningWidthBefore` | `Double` | `get/set` | No | `` |
| `LeftIslandLength` | `Double` | `get/set` | No | `` |
| `LeftIslandWidth` | `Double` | `get/set` | No | `` |
| `LeftPspBackwardLength` | `Double` | `get/set` | No | `` |
| `LeftPspForwardLength` | `Double` | `get/set` | No | `` |
| `LeftPspJump` | `Double` | `get/set` | No | `` |
| `LeftPspLength` | `Double` | `get/set` | No | `` |
| `LeftPspWidth` | `Double` | `get/set` | No | `` |
| `LeftSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `LeftSide1WidthStart` | `Double` | `get/set` | No | `` |
| `LeftSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `LeftSide3WidthStart` | `Double` | `get/set` | No | `` |
| `LeftSideWidthEnd` | `Double` | `get/set` | No | `` |
| `LeftSideWidthStart` | `Double` | `get/set` | No | `` |
| `MajorRoadLeftLeftRotationRadius` | `Double` | `get/set` | No | `` |
| `MajorRoadRightLeftRotationRadius` | `Double` | `get/set` | No | `` |
| `MinorRoadLeftPspPosition` | `MinorRoadPspPosition` | `get/set` | No | `` |
| `MinorRoadRightPspPosition` | `MinorRoadPspPosition` | `get/set` | No | `` |
| `RightIslandLength` | `Double` | `get/set` | No | `` |
| `RightIslandWidth` | `Double` | `get/set` | No | `` |
| `RightPspBackwardLength` | `Double` | `get/set` | No | `` |
| `RightPspForwardLength` | `Double` | `get/set` | No | `` |
| `RightPspJump` | `Double` | `get/set` | No | `` |
| `RightPspLength` | `Double` | `get/set` | No | `` |
| `RightPspWidth` | `Double` | `get/set` | No | `` |
| `RightSide1WidthEnd` | `Double` | `get/set` | No | `` |
| `RightSide1WidthStart` | `Double` | `get/set` | No | `` |
| `RightSide3WidthEnd` | `Double` | `get/set` | No | `` |
| `RightSide3WidthStart` | `Double` | `get/set` | No | `` |
| `RightSideWidthEnd` | `Double` | `get/set` | No | `` |
| `RightSideWidthStart` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OtherRoadContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelRoadDescent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelRoadDescent` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Intersection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.Intersection, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.Intersection`
      - `Topomatic.Alg.Road.Crossing.SingleLevelRoadDescent`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, SingleLevelRoadDescent intersection)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `CalculateElevationFromEdge` | `Boolean` | `get/set` | No | `` |
| `DescentDirection` | `DescentDirection` | `get/set` | No | `` |
| `DividerColor` | `CadColor` | `get/set` | No | `` |
| `DividerHatch` | `StripHatch` | `get/set` | No | `` |
| `ForwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `HasLeftRotation` | `Boolean` | `get/set` | No | `` |
| `InterpolateSlopes` | `Boolean` | `get/set` | No | `` |
| `MajorRoadCrossing` | `SingleLevelMajorRoadDescentCrossing` | `get` | No | `` |
| `MinorRoadCrossing` | `SingleLevelMinorRoadDescentCrossing` | `get` | No | `` |
| `ProfileDeltaWidth` | `Double` | `get/set` | No | `` |
| `StripColor` | `CadColor` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `UseR1R2Cloth` | `Boolean` | `get/set` | No | `` |
| `UseUrbSides` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Intersection` | `Object parent` | `` |
| `Equals` | `Boolean` | `Intersection other` | `` |
| `GetContainers` | `IEnumerable<KeyValuePair<OtherRoadAttachment Crossing>>` | `` | `` |
| `GetUrbObjectAttachment` | `KeyValuePair<UInt32 OtherRoadAttachment>` | `Guid id` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BACKWARD_DESCENT_ID` | `UInt32` | Yes | `4` | `` |
| `FORWARD_DESCENT_ID` | `UInt32` | Yes | `3` | `` |
| `MAJOR_ID` | `UInt32` | Yes | `1` | `` |
| `MINOR_ID` | `UInt32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SingleLevelRoadIntersection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.SingleLevelRoadIntersection` |
| **Base Type** | `Topomatic.Alg.Road.Crossing.Intersection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.IEquatable`1[[Topomatic.Alg.Road.Crossing.Intersection, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Crossing.Intersection`
      - `Topomatic.Alg.Road.Crossing.SingleLevelRoadIntersection`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, SingleLevelRoadIntersection intersection)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CalculateElevationFromEdge` | `Boolean` | `get/set` | No | `` |
| `DividerColor` | `CadColor` | `get/set` | No | `` |
| `DividerHatch` | `StripHatch` | `get/set` | No | `` |
| `InterpolateSlopes` | `Boolean` | `get/set` | No | `` |
| `IntersectionIndex` | `Int32` | `get/set` | No | `` |
| `LeftBackwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `LeftForwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `MajorRoadCrossing` | `SingleLevelMajorRoadInterSectionCrossing` | `get` | No | `` |
| `MinorRoadCrossing` | `SingleLevelMinorRoadInterSectionCrossing` | `get` | No | `` |
| `ProfileDeltaWidth` | `Double` | `get/set` | No | `` |
| `RightBackwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `RightForwardDescent` | `SingleLevelDescentCrossing` | `get` | No | `` |
| `StripColor` | `CadColor` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `UseR1R2Cloth` | `Boolean` | `get/set` | No | `` |
| `UseUrbSides` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Intersection` | `Object parent` | `` |
| `Equals` | `Boolean` | `Intersection other` | `` |
| `GetContainers` | `IEnumerable<KeyValuePair<OtherRoadAttachment Crossing>>` | `` | `` |
| `GetUrbObjectAttachment` | `KeyValuePair<UInt32 OtherRoadAttachment>` | `Guid id` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LEFT_BACKWARD_DESCENT_ID` | `UInt32` | Yes | `4` | `` |
| `LEFT_FORWARD_DESCENT_ID` | `UInt32` | Yes | `3` | `` |
| `MAJOR_ID` | `UInt32` | Yes | `1` | `` |
| `MINOR_ID` | `UInt32` | Yes | `2` | `` |
| `RIGHT_BACKWARD_DESCENT_ID` | `UInt32` | Yes | `6` | `` |
| `RIGHT_FORWARD_DESCENT_ID` | `UInt32` | Yes | `5` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Alg.Road.Crossing.Style`

### `CrossingsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Style.CrossingsPlanStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Crossing.Style.CrossingsPlanStyle`

#### Constructors (1)

- `.ctor(CrossingsStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextSize` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CrossingsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Style.CrossingsStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Alg.Road.Crossing.Crossings, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Crossings owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Crossings` | `get/set` | No | `` |
| `PlanStyle` | `CrossingsPlanStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<AlignmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 25 |
| **Classes** | 15 |
| **Interfaces** | 1 |
| **Enums** | 5 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 2 |
| **Total Methods** | 78 |
| **Total Properties** | 284 |
| **Total Fields** | 55 |
| **Total Events** | 0 |
| **Total Constructors** | 31 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


