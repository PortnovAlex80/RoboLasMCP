# Topomatic.Alg

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.dll` |

---
## Namespace: `Topomatic.Alg`

### `AlgConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.AlgConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BASE_VALUE` | `String` | Yes | `"BASE_VALUE"` | `` |
| `COORDINATE_MOVE_ALL` | `Int32` | Yes | `0` | `` |
| `COORDINATE_MOVE_LEFT_TANGENT` | `Int32` | Yes | `1` | `` |
| `COORDINATE_MOVE_RIGHT_TANGENT` | `Int32` | Yes | `2` | `` |
| `EG_LINE` | `Int32` | Yes | `510` | `` |
| `HARD_DYNAMIC_SURFACE_FACTOR` | `Double` | Yes | `0.001` | `` |
| `LIGHT_DYNAMIC_SURFACE_FACTOR` | `Double` | Yes | `0.1` | `` |
| `MEDIUM_DYNAMIC_SURFACE_FACTOR` | `Double` | Yes | `0.01` | `` |
| `OUR_VALUE` | `String` | Yes | `"OUR_VALUE"` | `` |
| `PLAN_UID` | `String` | Yes | `"Plan"` | `` |
| `PROFILE_UID` | `String` | Yes | `"Profile"` | `` |
| `RAIL_ALIAS` | `String` | Yes | `"Rail"` | `` |
| `ROAD_ALIAS` | `String` | Yes | `"Road"` | `` |
| `SECTION_UID` | `String` | Yes | `"Section"` | `` |
| `SURVEY_ALIAS` | `String` | Yes | `"Survey"` | `` |
| `THEIR_VALUE` | `String` | Yes | `"THEIR_VALUE"` | `` |
| `ZERO_GRADE_THRESHOLD` | `Double` | Yes | `0.09` | `` |

### `Alignment` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Alignment` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IStationingContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Alignment`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (33)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `AlignmentIntersectionsRelativePaths` | `IList<String>` | `get` | No | `` |
| `Bridges` | `BridgesCollection` | `get` | No | `` |
| `ConstructionTemplates` | `ConstructionTemplates` | `get` | No | `` |
| `Corridor` | `Corridor` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DtmSizeLeft` | `Double` | `get/set` | No | `` |
| `DtmSizeRight` | `Double` | `get/set` | No | `` |
| `EgSurfaceRelativePaths` | `IList<String>` | `get` | No | `` |
| `FilterCrossPoint` | `Boolean` | `get/set` | No | `` |
| `FilterCrossPointFactor` | `Double` | `get/set` | No | `` |
| `HasSynchronizedAlignment` | `Boolean` | `get/set` | No | `` |
| `IsLimitedChange` | `Boolean` | `get/set` | No | `` |
| `Kilometres` | `AlgAlignmentKilometres` | `get` | No | `` |
| `MaxChangeStation` | `Double` | `get/set` | No | `` |
| `MinChangeStation` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parameters` | `AlignmentParameters` | `get` | No | `` |
| `Pipes` | `PipesCollection` | `get` | No | `` |
| `Plan` | `PlanLine` | `get` | No | `` |
| `PlanLineSegmentsEditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `PlanVertexEditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `PlanVertexElementsEditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `Plugins` | `AlignmentPlugins` | `get` | No | `` |
| `ProfileCuttingSurfacesRelativePaths` | `IList<String>` | `get` | No | `` |
| `SectionCuttingSurfacesRelativePaths` | `IList<String>` | `get` | No | `` |
| `SelectedSections` | `SelectedSectionsCollection` | `get` | No | `` |
| `Signs` | `ConventionalSigns` | `get` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `Obsolete` |
| `Stationing` | `AlgBaseStationing` | `get` | No | `` |
| `Style` | `AlignmentStyle` | `get/set` | No | `` |
| `SynchronizedAlignmentIdRelativePath` | `String` | `get/set` | No | `` |
| `Transitions` | `ITransitions` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `SettingsChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `EndUpdate` |
| `IAlignmentContainer` | `Topomatic.Alg.IAlignmentContainer.get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IStationingContainer` | `Topomatic.Alg.IStationingContainer.get_Stationing` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `AlignmentJoinType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.AlignmentJoinType` |
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
      - `Topomatic.Alg.AlignmentJoinType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `JoinBeginToBegin` | `AlignmentJoinType` | Yes | `JoinBeginToBegin` | `` |
| `JoinBeginToEnd` | `AlignmentJoinType` | Yes | `JoinBeginToEnd` | `` |
| `JoinEndToBegin` | `AlignmentJoinType` | Yes | `JoinEndToBegin` | `` |
| `JoinEndToEnd` | `AlignmentJoinType` | Yes | `JoinEndToEnd` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `JoinEndToBegin` | `0` |
| `JoinEndToEnd` | `1` |
| `JoinBeginToBegin` | `2` |
| `JoinBeginToEnd` | `3` |

**Underlying Type**: `System.Int32`

### `AlignmentValueConverter` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.AlignmentValueConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToGMS` | `Void` | `Double radiansValue, ref Int32 grad, ref Double minutes` | `` |
| `AngleToGMS` | `Void` | `Double radiansValue, ref Int32 grad, ref Int32 minutes, ref Double seconds` | `` |
| `AngleToPosOY` | `Double` | `Vector2D pos1, Vector2D pos2` | `` |
| `CoordinateToStr` | `String` | `Alignment alignment, Double value` | `Extension` |
| `ElevationToStr` | `String` | `Alignment alignment, Double value` | `Extension` |
| `FindOrCreateContext` | `CrsDesignContext` | `Corridor corridor, Double station, BuildMode mode` | `Extension` |
| `FindOrCreateContext` | `CrsDesignContext` | `Corridor corridor, Double station` | `Extension` |
| `GetId` | `Guid` | `Alignment alignment` | `Extension` |
| `GradeToStr` | `String` | `Alignment alignment, Double value` | `Extension` |
| `LengthToStr` | `String` | `Alignment alignment, Double value` | `Extension` |
| `RadiusToStr` | `String` | `Alignment alignment, Double value` | `Extension` |
| `RoundByWholeStation` | `Double` | `IAlgStationing stationing, Double station, Double step` | `Extension` |
| `RumbString` | `String` | `Vector2D pos1, Vector2D pos2` | `` |
| `StationInLimits` | `Boolean` | `Double station, Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `StationInLimits` | `Boolean` | `Alignment alignment, Double station, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `StationsToString` | `String` | `Alignment alignment, IList<Double> stations` | `Extension` |
| `StationToStringSorted` | `String` | `IAlgStationing stationing, Double sta1, Double sta2` | `Extension` |
| `StringToStations` | `List<Double>` | `Alignment alignment, String value` | `Extension` |
| `StringToStationSorted` | `Void` | `IAlgStationing stationing, String value, ref Double min, ref Double max` | `Extension` |
| `TryStringToStationSorted` | `Boolean` | `IAlgStationing stationing, String value, ref Double min, ref Double max` | `Extension` |

### `DesignStatus` (enum)

**Attributes**: [ComVisible, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.DesignStatus` |
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
      - `Topomatic.Alg.DesignStatus`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Designing` | `DesignStatus` | Yes | `Designing` | `` |
| `Dismantling` | `DesignStatus` | Yes | `Dismantling` | `` |
| `Existing` | `DesignStatus` | Yes | `Existing` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Existing` | `0` |
| `Designing` | `1` |
| `Dismantling` | `2` |

**Underlying Type**: `System.Int32`

### `IAlignmentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.IAlignmentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |

### `IStationingContainer` (interface)

**Attributes**: [Obsolete(Message: `Use Topomatic.Cad.Foundation.Stationing.IStationingRepository instead`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.IStationingContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Stationing` | `IAlgStationing` | `get` | No | `` |

---
## Namespace: `Topomatic.Alg.Bridges`

### `Bridge` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Bridges.Bridge` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Bridges.Bridge`

#### Constructors (1)

- `.ctor(BridgesCollection owned)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Base` | `BridgeBase` | `get/set` | No | `` |
| `Documents` | `String` | `get/set` | No | `` |
| `EndSlope` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Material` | `BridgeMaterial` | `get/set` | No | `` |
| `MeasurementDate` | `DateTime` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SectAngle` | `Double` | `get/set` | No | `` |
| `StartSlope` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Type` | `BridgeType` | `get/set` | No | `` |
| `WaterElevation` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Bridge bridge` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BridgeBase` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Bridges.BridgeBase` |
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
      - `Topomatic.Alg.Bridges.BridgeBase`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Conic` | `BridgeBase` | Yes | `Conic` | `` |
| `Straight` | `BridgeBase` | Yes | `Straight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Conic` | `0` |
| `Straight` | `1` |

**Underlying Type**: `System.Int32`

### `BridgeMaterial` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Bridges.BridgeMaterial` |
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
      - `Topomatic.Alg.Bridges.BridgeMaterial`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Concrete` | `BridgeMaterial` | Yes | `Concrete` | `` |
| `Metal` | `BridgeMaterial` | Yes | `Metal` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Wood` | `BridgeMaterial` | Yes | `Wood` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Metal` | `0` |
| `Concrete` | `1` |
| `Wood` | `2` |

**Underlying Type**: `System.Int32`

### `BridgesCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Bridges.BridgesCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Bridges.BridgesCollection`

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Bridge` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Bridge` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `get_Alignment` |

### `BridgeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Bridges.BridgeType` |
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
      - `Topomatic.Alg.Bridges.BridgeType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Big` | `BridgeType` | Yes | `Big` | `` |
| `Medium` | `BridgeType` | Yes | `Medium` | `` |
| `Small` | `BridgeType` | Yes | `Small` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Small` | `0` |
| `Medium` | `1` |
| `Big` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Crs`

### `Construction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.Construction` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.Construction`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActConstruction` | `ActConstruction` | `get/set` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `UserDefined` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `String caption` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConstructionCopyOnChange` | `Boolean` | `Alignment alignment, Int32 sectionIndex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConstructionDictionary` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.ConstructionDictionary` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Alg.Crs.Construction, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.ConstructionDictionary`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Construction` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Construction` | `String name, Boolean userDefined, ActConstruction actConstruction` | `` |
| `Clear` | `Void` | `` | `` |
| `CloneAndReplace` | `Construction` | `Construction construction` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `ContainsConstruction` | `Boolean` | `UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<UInt32 Construction>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EmptyConstructionId` | `UInt32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConstructionTemplate` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.ConstructionTemplate` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Crs.ConstructionTemplate`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ConstructionTemplate` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConstructionId` | `UInt32` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `Empty` | `ConstructionTemplate` | Yes | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `ConstructionTemplates` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.ConstructionTemplates` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Crs.ConstructionTemplate, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.ConstructionTemplates`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ConstructionTemplate` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Boolean` | `ConstructionTemplate template` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionTemplate>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref ConstructionTemplate template` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `Corridor` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.Corridor` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Crs.Corridor`

#### Constructors (1)

- `.ctor(ICrsBuilder builder, Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Constructions` | `ConstructionDictionary` | `get` | No | `` |
| `Item` | `CrsDesignContext` | `get` | No | `` |
| `Item` | `CrsDesignContext` | `get` | No | `` |
| `Listener` | `ICrsBuilderListener` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sections` | `SectionList` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDesignContext` | `CrsDesignContext` | `Double station, BuildMode mode, ICrsBuilderListener listener` | `` |
| `CreateDesignContext` | `CrsDesignContext` | `Double station, BuildMode mode, Boolean clipContours, ICrsBuilderListener listener` | `` |
| `CreateDesignContext` | `CrsDesignContext` | `Double station` | `` |
| `CreateDesignContext` | `CrsDesignContext` | `Double station, BuildMode mode` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveUnusedConstructions` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Section` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.Section` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Crs.Section, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.Section`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConstructionId` | `UInt32` | `get/set` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `IsProject` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SectionLine` | `CrsLine` | `get/set` | No | `` |
| `Selected` | `Boolean` | `get/set` | No | `` |
| `Signs` | `ConventionalSigns` | `get` | No | `` |
| `StaticEg` | `CrsLine` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Underlay` | `Drawing` | `get/set` | No | `` |
| `UnderlayEnd` | `Vector2D` | `get/set` | No | `` |
| `UnderlayStart` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyParameters` | `Void` | `Section section` | `` |
| `Equals` | `Boolean` | `Section other` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `SectionList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.SectionList` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Crs.Section, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Crs.SectionList`

#### Constructors (1)

- `.ctor(Corridor owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Section` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Double station` | `` |
| `Clear` | `Void` | `` | `` |
| `GetIndex` | `Int32` | `Double station` | `` |
| `GetIndexLess` | `Int32` | `Double station` | `` |
| `GetIndexMore` | `Int32` | `Double station` | `` |
| `Invalidate` | `Void` | `` | `` |
| `IsExist` | `Boolean` | `Double station` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Move` | `Void` | `Double station, Double delta` | `` |
| `Remove` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetSections` | `Boolean` | `Double station, ref Section first, ref Section last` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `IndexerEventHandler` | No | `` |
| `BeforeRemove` | `IndexerEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `System.Collections.Generic.IEnumerable<Topomatic.Alg.Crs.Section>.GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SelectedSections` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.SelectedSections` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.SelectedSections`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Double` | `get` | No | `` |
| `Item` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSection` | `Void` | `Double station` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SelectedSectionsCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Crs.SelectedSectionsCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Crs.SelectedSectionsCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `SelectedSections` | `get` | No | `` |
| `Items` | `IEnumerable<KeyValuePair<String SelectedSections>>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `SelectedSections` | `String name` | `` |
| `Clear` | `Void` | `` | `` |
| `IsExist` | `Boolean` | `String name` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `String name` | `` |
| `Rename` | `Void` | `String oldName, String newName` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.ExcludedVolumes`

### `ExcludedVolume` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ExcludedVolumes.ExcludedVolume` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |

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

### `ExcludedVolumesCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ExcludedVolumes.ExcludedVolumesCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ExcludedVolume` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `ExcludedVolume` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Gaps`

### `Gap` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Gaps.Gap` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Gaps.Gap, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Gaps.Gap`

#### Constructors (2)

- `.ctor(Gap gap)`
- `.ctor(Double startStation, Double endStation)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Gap other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, Gap defaultValue` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `StationInside` | `Boolean` | `Double station` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Gap` | `StgNode stgNode, Gap defaultValue` | `` |
| `LoadFromStg` | `Gap` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `Gap gap, StgNode stgNode, Gap defaultValue` | `` |
| `SaveToStg` | `Void` | `Gap gap, StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `GapExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Gaps.GapExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyFrom` | `Void` | `GapsCollection to, GapsCollection from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `GapsCollection current, GapsCollection gaps, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `GapsCollection current, GapsCollection gaps, Double station` | `Extension` |
| `Join` | `Void` | `GapsCollection current, AlignmentJoinType joinType, GapsCollection first, Double firstLength, GapsCollection second, Double secondLength` | `Extension` |
| `Split` | `Void` | `GapsCollection current, Double station, GapsCollection before, GapsCollection after` | `Extension` |

### `GapsCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Gaps.GapsCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Gaps.Gap, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Gaps.Gap, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Gaps.Gap, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Gaps.GapsCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Gap` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Gap item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Gap item` | `` |
| `ContainStation` | `Boolean` | `Double station` | `` |
| `ContainStation` | `Boolean` | `Double station, Boolean includeStart, Boolean includeEnd` | `` |
| `ContainStation` | `Boolean` | `Double station, ref Double start, ref Double end` | `` |
| `CopyTo` | `Void` | `Gap[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<Gap>` | `` | `` |
| `GetSegments` | `IEnumerable<GapSegment>` | `` | `` |
| `IndexOf` | `Int32` | `Gap item` | `` |
| `Insert` | `Void` | `Int32 index, Gap item` | `` |
| `IntersectSegment` | `Boolean` | `Double startStation, Double endStation, ref IEnumerable<KeyValuePair<Double Double>> pairs` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Gap item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `GapSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Gaps.GapSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Gaps.GapSegment`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `End` | `Double` | No | `` | `` |
| `Start` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.Kilometres`

### `AlgAlignmentKilometres` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Kilometres.AlgAlignmentKilometres` |
| **Base Type** | `Topomatic.Alg.Kilometres.AlgExtendedKilometres` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IKilometers, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Kilometers, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedKilometers`
      - `Topomatic.Cad.Foundation.Stationing.Kilometers`
        - `Topomatic.Alg.Kilometres.AlgExtendedKilometres`
          - `Topomatic.Alg.Kilometres.AlgAlignmentKilometres`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `AlgExtendedKilometres` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Kilometres.AlgExtendedKilometres` |
| **Base Type** | `Topomatic.Cad.Foundation.Stationing.Kilometers` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IKilometers, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Kilometers, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedKilometers`
      - `Topomatic.Cad.Foundation.Stationing.Kilometers`
        - `Topomatic.Alg.Kilometres.AlgExtendedKilometres`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanMakeDefault` | `Boolean` | `get` | No | `` |
| `Empty` | `Boolean` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `AlgExtendedKilometres kilometres` | `` |
| `CanJoin` | `String` | `AlignmentJoinType joinType, AlgExtendedKilometres firstKilometres, AlgExtendedKilometres secondKilometres` | `` |
| `CanSplit` | `String` | `Double station, AlgExtendedKilometres beforeSection, AlgExtendedKilometres afterSection` | `` |
| `Join` | `Void` | `AlignmentJoinType joinType, AlgExtendedKilometres firstKilometres, AlgExtendedKilometres secondKilometres, Double firstLen, Double secondLen` | `` |
| `KilometreToStation` | `Double` | `Int32 kilometre, Double plus` | `` |
| `MakeDefault` | `Void` | `Double startStation, Double traceLength` | `` |
| `Split` | `Void` | `Double station, AlgExtendedKilometres beforeSection, AlgExtendedKilometres afterSection` | `` |
| `TryKilometreToStation` | `Boolean` | `Int32 kilometre, ref Double station` | `` |
| `TryStationToKilometre` | `Boolean` | `Double station, ref Int32 kilometre` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.LinearObjects`

### `CrsLinearObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LinearObjects.CrsLinearObject` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Uid` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CrsLinearObjects`1<T where CrsLinearObject, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, class, CrsLinearObject>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LinearObjects.CrsLinearObjects`1` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObjects`1`

#### Constructors (1)

- `.ctor(Alignment owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsExists` | `Boolean` | `String uid` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `T value` | `` |
| `Remove` | `Void` | `String uid` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Offsets`

### `IOffset` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Offsets.IOffset` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Stations` | `Double[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Double lastValue` | `` |

### `Offset` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Offsets.Offset` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Offsets.IOffset, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Offsets.Offset`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `OffsetItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Stations` | `Double[]` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `OffsetItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `OffsetItem item` | `` |
| `CopyTo` | `Void` | `OffsetItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<OffsetItem>` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `IndexOf` | `Int32` | `OffsetItem item` | `` |
| `Insert` | `Void` | `Int32 index, OffsetItem item` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeEditable` | `Void` | `` | `` |
| `RefreshPoly` | `Void` | `Polyline3D polyline` | `` |
| `Remove` | `Boolean` | `OffsetItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Boolean` | `Double station, ref Int32 index` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Double lastValue` | `` |

#### Nested Types (1)

- `OffsetItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IOffset` | `TryGetValue` |
| `IOffset` | `get_Stations` |
| `IOffset` | `get_IsEmpty` |
| `ILinearObject` | `GetPolyline` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OffsetExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Offsets.OffsetExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyFrom` | `Void` | `Offset to, Offset from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `Offset current, Offset offset, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `Offset current, Offset offset, Double station` | `Extension` |
| `Join` | `Void` | `Offset current, AlignmentJoinType joinType, Offset first, Double firstLength, Offset second, Double secondLength` | `Extension` |
| `Split` | `Void` | `Offset current, Double station, Offset before, Offset after` | `Extension` |

### `OffsetItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Offsets.Offset+OffsetItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Offsets.Offset+OffsetItem`

#### Constructors (2)

- `.ctor(OffsetItem item)`
- `.ctor(Double station, Double offset)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `OffsetItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, OffsetItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `OffsetItem` | `StgNode stgNode, OffsetItem defaultValue` | `` |
| `LoadFromStg` | `OffsetItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `OffsetItem node, StgNode stgNode, OffsetItem defaultValue` | `` |
| `SaveToStg` | `Void` | `OffsetItem node, StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Offset` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ZeroOffset` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Offsets.ZeroOffset` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Offsets.IOffset, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Stations` | `Double[]` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Double lastValue` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOffset` | `TryGetValue` |
| `IOffset` | `get_Stations` |
| `IOffset` | `get_IsEmpty` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |

---
## Namespace: `Topomatic.Alg.Parameters`

### `AlignmentParameters` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.AlignmentParameters` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Parameters.AlignmentParameters`

#### Constructors (1)

- `.ctor(Alignment owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DefineComputedParameter` | `IParameter<T>` | `U sender, String variable, String caption, Func<U Double T> getValue, Action<U Double T> setValue, Boolean overrideExisting` | `` |
| `DefineComputedParameter` | `IParameter<T>` | `String variable, String caption, Func<Alignment Double T> getValue, Action<Alignment Double T> setValue, Boolean overrideExisting` | `` |
| `DefineParameterTable` | `IParameter<T>` | `String variable, String caption, BehaviorType behaviorType, T defaultValue, Boolean overrideExisting, Boolean isSystem` | `` |
| `DefineSectionParameter` | `IParameter<T>` | `String variable, String caption, BehaviorType behaviorType, T defaultValue, Boolean overrideExisting, SectionParameterAffect affect, Boolean canCopy` | `` |
| `GetComputedParameters` | `IEnumerable<KeyValuePair<String IParameter>>` | `` | `` |
| `GetStationParams` | `IDictionary<String T>` | `Double station` | `` |
| `GetTableParameters` | `IEnumerable<KeyValuePair<String IParameter>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `String key` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetTableValue` | `Boolean` | `String key, ref IParameter parameter` | `` |
| `TryGetTableValue` | `Boolean` | `String key, ref IParameter<T> parameter` | `` |
| `TryGetValue` | `Boolean` | `String key, ref IParameter parameter` | `` |
| `TryGetValue` | `Boolean` | `String key, ref IParameter<T> parameter` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `QuantityChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BehaviorType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.BehaviorType` |
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
      - `Topomatic.Alg.Parameters.BehaviorType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `BehaviorType` | Yes | `Default` | `` |
| `Discrete` | `BehaviorType` | Yes | `Discrete` | `` |
| `Interpolate` | `BehaviorType` | Yes | `Interpolate` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Discrete` | `0` |
| `Interpolate` | `1` |
| `Default` | `2` |

**Underlying Type**: `System.Int32`

### `BooleanParameter` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.BooleanParameter` |
| **Base Type** | `Topomatic.Alg.Parameters.ParameterTable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.Parameters.IParameterTable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameterTable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Parameters.IParameter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameter, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Parameters.ParameterTable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Alg.Parameters.BooleanParameter`

#### Constructors (3)

- `.ctor(Object parent, String caption, BehaviorType behavoirType)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Boolean defaultValue)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Boolean defaultValue, Boolean isSystem)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `Boolean` | `get/set` | No | `` |
| `ParameterType` | `ParameterType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IParameter`1` | `get_Item` |
| `IParameter`1` | `set_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.get_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.set_Item` |
| `IParameter` | `get_Caption` |
| `IParameter` | `get_ParameterType` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DoubleParameter` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.DoubleParameter` |
| **Base Type** | `Topomatic.Alg.Parameters.ParameterTable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.Parameters.IParameterTable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameterTable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Parameters.IParameter`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameter, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Parameters.ParameterTable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Alg.Parameters.DoubleParameter`

#### Constructors (3)

- `.ctor(Object parent, String caption, BehaviorType behavoirType)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Double defaultValue)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Double defaultValue, Boolean isSystem)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `Double` | `get/set` | No | `` |
| `ParameterType` | `ParameterType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IParameter`1` | `get_Item` |
| `IParameter`1` | `set_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.get_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.set_Item` |
| `IParameter` | `get_Caption` |
| `IParameter` | `get_ParameterType` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `IntegerParameter` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.IntegerParameter` |
| **Base Type** | `Topomatic.Alg.Parameters.ParameterTable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.Parameters.IParameterTable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameterTable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Parameters.IParameter`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameter, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Parameters.ParameterTable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Alg.Parameters.IntegerParameter`

#### Constructors (3)

- `.ctor(Object parent, String caption, BehaviorType behavoirType)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Int32 defaultValue)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, Int32 defaultValue, Boolean isSystem)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `Int32` | `get/set` | No | `` |
| `ParameterType` | `ParameterType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IParameter`1` | `get_Item` |
| `IParameter`1` | `set_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.get_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.set_Item` |
| `IParameter` | `get_Caption` |
| `IParameter` | `get_ParameterType` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `IParameter` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.IParameter` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `ParameterType` | `ParameterType` | `get` | No | `` |

### `IParameter`1<T where class>` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.IParameter`1` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Alg.Parameters.IParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `T` | `get/set` | No | `` |

### `IParameterTable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.IParameterTable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BehaviorType` | `BehaviorType` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsSystem` | `Boolean` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Boolean` | `Double station, Object obj` | `` |
| `Clear` | `Void` | `` | `` |
| `CloneValue` | `Object` | `Double station` | `` |
| `CloneValue` | `Object` | `Int32 index` | `` |
| `GetIndex` | `Int32` | `Double station` | `` |
| `GetStation` | `Double` | `Int32 index` | `` |
| `GetValue` | `Object` | `Int32 index` | `` |
| `Remove` | `Void` | `Double station` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SetValue` | `Void` | `Int32 index, Object obj` | `` |

### `IParameterTable`1<T where class>` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.IParameterTable`1` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Alg.Parameters.IParameterTable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultValue` | `T` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneValue` | `T` | `Int32 index` | `` |
| `CloneValue` | `T` | `Double station` | `` |
| `GetValue` | `T` | `Int32 index` | `` |
| `SetValue` | `Void` | `Int32 index, T obj` | `` |

### `ISectionParameter` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.ISectionParameter` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Affect` | `SectionParameterAffect` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |

### `ParameterTable`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.ParameterTable`1` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, , Topomatic.Alg.Parameters.IParameterTable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Parameters.ParameterTable`1`

#### Constructors (3)

- `.ctor(Object owner, BehaviorType behaviorType)`
- `.ctor(Object owner, BehaviorType behaviorType, T defaultValue)`
- `.ctor(Object owner, BehaviorType behaviorType, T defaultValue, Boolean isSystem)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BehaviorType` | `BehaviorType` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DefaultValue` | `T` | `get/set` | No | `` |
| `IsSystem` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Boolean` | `Double station, Object obj` | `` |
| `Clear` | `Void` | `` | `` |
| `CloneValue` | `T` | `Double station` | `` |
| `CloneValue` | `T` | `Int32 index` | `` |
| `GetIndex` | `Int32` | `Double station` | `` |
| `GetStation` | `Double` | `Int32 index` | `` |
| `GetValue` | `T` | `Int32 index` | `` |
| `Remove` | `Void` | `Double station` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SetValue` | `Void` | `Int32 index, T obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IParameterTable`1` | `SetValue` |
| `IParameterTable`1` | `GetValue` |
| `IParameterTable`1` | `CloneValue` |
| `IParameterTable`1` | `CloneValue` |
| `IParameterTable`1` | `get_DefaultValue` |
| `IParameterTable` | `Add` |
| `IParameterTable` | `Topomatic.Alg.Parameters.IParameterTable.SetValue` |
| `IParameterTable` | `Remove` |
| `IParameterTable` | `RemoveAt` |
| `IParameterTable` | `Topomatic.Alg.Parameters.IParameterTable.GetValue` |
| `IParameterTable` | `Topomatic.Alg.Parameters.IParameterTable.CloneValue` |
| `IParameterTable` | `Topomatic.Alg.Parameters.IParameterTable.CloneValue` |
| `IParameterTable` | `GetStation` |
| `IParameterTable` | `GetIndex` |
| `IParameterTable` | `Clear` |
| `IParameterTable` | `get_BehaviorType` |
| `IParameterTable` | `get_IsSystem` |
| `IParameterTable` | `get_Count` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ParameterType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.ParameterType` |
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
      - `Topomatic.Alg.Parameters.ParameterType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Boolean` | `ParameterType` | Yes | `Boolean` | `` |
| `Computed` | `ParameterType` | Yes | `Computed` | `` |
| `Double` | `ParameterType` | Yes | `Double` | `` |
| `Integer` | `ParameterType` | Yes | `Integer` | `` |
| `String` | `ParameterType` | Yes | `String` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Computed` | `0` |
| `Integer` | `1` |
| `Double` | `2` |
| `Boolean` | `3` |
| `String` | `4` |

**Underlying Type**: `System.Int32`

### `SectionParameterAffect` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.SectionParameterAffect` |
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
      - `Topomatic.Alg.Parameters.SectionParameterAffect`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `SectionParameterAffect` | Yes | `Left` | `` |
| `None` | `SectionParameterAffect` | Yes | `None` | `` |
| `Right` | `SectionParameterAffect` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Left` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `StringParameter` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Parameters.StringParameter` |
| **Base Type** | `Topomatic.Alg.Parameters.ParameterTable`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.Parameters.IParameterTable`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameterTable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Parameters.IParameter`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Alg.Parameters.IParameter, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Parameters.ParameterTable`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Alg.Parameters.StringParameter`

#### Constructors (3)

- `.ctor(Object parent, String caption, BehaviorType behavoirType)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, String defaultValue)`
- `.ctor(Object parent, String caption, BehaviorType behavoirType, String defaultValue, Boolean isSystem)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Item` | `String` | `get/set` | No | `` |
| `ParameterType` | `ParameterType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IParameter`1` | `get_Item` |
| `IParameter`1` | `set_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.get_Item` |
| `IParameter` | `Topomatic.Alg.Parameters.IParameter.set_Item` |
| `IParameter` | `get_Caption` |
| `IParameter` | `get_ParameterType` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Pipes`

### `IPipeContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.IPipeContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Pipe` | `Pipe` | `get` | No | `` |

### `Pipe` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.Pipe` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Pipes.IPipeContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Pipes.Pipe`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Diameter` | `Double` | `get/set` | No | `` |
| `Documents` | `String` | `get/set` | No | `` |
| `ElevationEnd` | `Double` | `get/set` | No | `` |
| `ElevationStart` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `LeaderFromStart` | `Boolean` | `get/set` | No | `` |
| `LeaderInverted` | `Boolean` | `get/set` | No | `` |
| `LeaderPosition` | `Vector2D` | `get/set` | No | `` |
| `LeaderRotation` | `Double` | `get/set` | No | `` |
| `LeaderVisible` | `Boolean` | `get/set` | No | `` |
| `LengthToEnd` | `Double` | `get/set` | No | `` |
| `LengthToStart` | `Double` | `get/set` | No | `` |
| `Material` | `PipeMaterial` | `get/set` | No | `` |
| `Mode` | `PipeMode` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Section` | `PipeSection` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Type` | `PipeType` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Pipe other` | `` |
| `IsEquals` | `Boolean` | `Pipe other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IPipeContainer` | `Topomatic.Alg.Pipes.IPipeContainer.get_Pipe` |

### `PipeExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipeExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndHeadPos` | `Boolean` | `Pipe pipe, Alignment alg, ref Vector2D pos` | `Extension` |
| `GetStartHeadPos` | `Boolean` | `Pipe pipe, Alignment alg, ref Vector2D pos` | `Extension` |
| `LeaderText1` | `String` | `Pipe pipe` | `Extension` |
| `LeaderText2` | `String` | `Pipe pipe` | `Extension` |

### `PipeMaterial` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipeMaterial` |
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
      - `Topomatic.Alg.Pipes.PipeMaterial`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Concrete` | `PipeMaterial` | Yes | `Concrete` | `` |
| `Corrugate` | `PipeMaterial` | Yes | `Corrugate` | `` |
| `Metal` | `PipeMaterial` | Yes | `Metal` | `` |
| `Spiral` | `PipeMaterial` | Yes | `Spiral` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Concrete` | `0` |
| `Metal` | `1` |
| `Corrugate` | `2` |
| `Spiral` | `3` |

**Underlying Type**: `System.Int32`

### `PipeMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipeMode` |
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
      - `Topomatic.Alg.Pipes.PipeMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `PipeMode` | Yes | `Bottom` | `` |
| `Top` | `PipeMode` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Bottom` | `0` |
| `Top` | `1` |

**Underlying Type**: `System.Int32`

### `PipesCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipesCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Pipes.PipesCollection`

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Pipe` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Pipe` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PipeSection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipeSection` |
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
      - `Topomatic.Alg.Pipes.PipeSection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Circular` | `PipeSection` | Yes | `Circular` | `` |
| `Rectangular` | `PipeSection` | Yes | `Rectangular` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Circular` | `0` |
| `Rectangular` | `1` |

**Underlying Type**: `System.Int32`

### `PipeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Pipes.PipeType` |
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
      - `Topomatic.Alg.Pipes.PipeType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Existing` | `PipeType` | Yes | `Existing` | `` |
| `Project` | `PipeType` | Yes | `Project` | `` |
| `Reconstructed` | `PipeType` | Yes | `Reconstructed` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Existing` | `0` |
| `Project` | `1` |
| `Reconstructed` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Plan`

### `DataItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+MultiPlanData+DataItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Plan.PlanLine+MultiPlanData+DataItem`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `D` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alpha` | `Double` | No | `` | `` |
| `CurveEnd` | `Double` | No | `` | `` |
| `CurveLength` | `Double` | No | `` | `` |
| `CurveStart` | `Double` | No | `` | `` |
| `M1` | `Double` | No | `` | `` |
| `M2` | `Double` | No | `` | `` |
| `P1` | `Double` | No | `` | `` |
| `P2` | `Double` | No | `` | `` |
| `RadialCurveEnd` | `Double` | No | `` | `` |
| `RadialCurveStart` | `Double` | No | `` | `` |
| `T1` | `Double` | No | `` | `` |
| `T2` | `Double` | No | `` | `` |

### `MultiPlanData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+MultiPlanData` |
| **Base Type** | `Topomatic.Alg.Plan.PlanLine+PlanData` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Plan.PlanLine+MultiPlanData+DataItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Plan.PlanLine+PlanData`
    - `Topomatic.Alg.Plan.PlanLine+MultiPlanData`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `Item` | `DataItem` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<DataItem>` | `` | `` |

#### Nested Types (1)

- `DataItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `PlanData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+PlanData` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `K` | `Double` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `T1` | `Double` | `get/set` | No | `` |
| `T2` | `Double` | `get/set` | No | `` |

### `PlanDataSolver` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLineSolver+PlanDataSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `SolverItem` | `get` | No | `` |
| `PlanData` | `PlanData` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `IList<VertexItem> items, Double beta, Double summKoeff, Double station, Boolean multiRadiusExtendedPCalculation` | `` |

#### Nested Types (1)

- `SolverItem` (struct)

### `PlanLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Plan.PlanLine+Vertex, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Plan.PlanLine+Vertex, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Plan.PlanLine+Vertex, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Plan.PlanLine, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Plan.PlanLine`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `AutomaticNames` | `Boolean` | `get/set` | No | `` |
| `CompoundLine` | `CompoundLine` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Vertex` | `get/set` | No | `` |
| `MaxLength` | `Double` | `get` | No | `` |
| `MaxRadius` | `Double` | `get` | No | `` |
| `MinLength` | `Double` | `get` | No | `` |
| `MinRadius` | `Double` | `get` | No | `` |
| `MultiRadius` | `Boolean` | `get` | No | `` |
| `MultiRadiusExtendedPCalculation` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (25)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Vertex item` | `` |
| `Assign` | `Void` | `PlanLine planLine` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Vertex item` | `` |
| `CopyTo` | `Void` | `Vertex[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `PlanLine other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<Vertex>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IndexOf` | `Int32` | `Vertex item` | `` |
| `Insert` | `Void` | `Int32 index, Vertex item` | `` |
| `Invert` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Vertex item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SearchNearest` | `Boolean` | `Double station, ref Int32 index` | `` |
| `SearchNearest` | `Vertex` | `Double station` | `` |
| `VertexChangeValid` | `VertexValidation` | `Int32 index, Vertex vertex` | `` |
| `VertexRemoveValid` | `VertexValidation` | `Int32 index` | `` |

#### Nested Types (5)

- `MultiPlanData` (class)
- `PlanData` (abstract class)
- `SinglePlanData` (class)
- `Vertex` (class)
- `VertexValidation` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `PlanLineSegmentEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLineSegmentEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Alg.Plan.PlanLineSegmentEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalAngle` | `Double` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |

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

### `PlanLineSegmentEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLineSegmentEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.Plan.PlanLineSegmentEditableItemsKey`

#### Constructors (1)

- `.ctor(Int32 firstVertexIndex, UInt32 firstVertexId, Int32 secondVertexIndex, UInt32 secondVertexId)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FirstVertexId` | `UInt32` | `get` | No | `` |
| `FirstVertexIndex` | `Int32` | `get` | No | `` |
| `SecondVertexId` | `UInt32` | `get` | No | `` |
| `SecondVertexIndex` | `Int32` | `get` | No | `` |

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

### `PlanLineSolver` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLineSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompoundLineToPlanVertexes` | `Void` | `PlanLine planLine, CompoundLine compoundLine` | `` |
| `GetVertexTopList` | `Boolean` | `Vertex vertex, List<Vector2D> tops, Boolean multiRadiusExtendedPCalculation` | `` |
| `Join` | `Void` | `PlanLine current, AlignmentJoinType joinType, PlanLine first, PlanLine second` | `Extension` |
| `JoinVertexes` | `Boolean` | `PlanLine current, Int32 index1, Int32 index2` | `Extension` |
| `PlanLineValid` | `KeyValuePair<Int32 VertexValidation>[]` | `PlanLine planLine` | `` |
| `PlanVertexesToCompoundLine` | `Void` | `IList<Vertex> vertexes, CompoundLine compoundLine` | `` |
| `PlanVertexesValid` | `Boolean` | `IList<Vertex> vertexes` | `` |
| `SolvekXY` | `Boolean` | `Vector2D pos1, Vector2D pos2, ref Double kX, ref Double kY` | `` |
| `SolvePlanData` | `PlanData` | `IList<VertexItem> items, Double station, Double beta, Double summKoeff, Boolean multiRadiusExtendedPCalculation` | `` |
| `Split` | `Void` | `PlanLine current, Double station, PlanLine before, PlanLine after` | `Extension` |

#### Nested Types (1)

- `PlanDataSolver` (class)

### `PlanVertexEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanVertexEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Alg.Plan.PlanVertexEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalAngle` | `Double` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |

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

### `PlanVertexEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanVertexEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.Plan.PlanVertexEditableItemsKey`

#### Constructors (1)

- `.ctor(Int32 vertexIndex, UInt32 id, Int32 dataIndex)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataIndex` | `Int32` | `get` | No | `` |
| `ID` | `UInt32` | `get` | No | `` |
| `VertexIndex` | `Int32` | `get` | No | `` |

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

### `PlanVertexElementEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanVertexElementEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Alg.Plan.PlanVertexElementEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalAngle` | `Double` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |

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

### `PlanVertexElementEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanVertexElementEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.Plan.PlanVertexElementEditableItemsKey`

#### Constructors (1)

- `.ctor(Int32 vertexIndex, UInt32 id, Int32 dataType, Int32 dataIndex)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataIndex` | `Int32` | `get` | No | `` |
| `DataType` | `Int32` | `get` | No | `` |
| `ID` | `UInt32` | `get` | No | `` |
| `VertexIndex` | `Int32` | `get` | No | `` |

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

### `SinglePlanData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+SinglePlanData` |
| **Base Type** | `Topomatic.Alg.Plan.PlanLine+PlanData` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Plan.PlanLine+PlanData`
    - `Topomatic.Alg.Plan.PlanLine+SinglePlanData`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `B` | `Double` | `get/set` | No | `` |
| `BCC` | `Double` | `get/set` | No | `` |
| `BTC` | `Double` | `get/set` | No | `` |
| `D` | `Double` | `get/set` | No | `` |
| `ECC` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `ETC` | `Double` | `get/set` | No | `` |
| `P1` | `Double` | `get/set` | No | `` |
| `P2` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

### `SolverItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLineSolver+PlanDataSolver+SolverItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Plan.PlanLineSolver+PlanDataSolver+SolverItem`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurveAngle` | `Double` | `get` | No | `` |
| `CurveEndPos` | `Vector2D` | `get` | No | `` |
| `CurveLength` | `Double` | `get` | No | `` |
| `CurveStartPos` | `Vector2D` | `get` | No | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Angle` | `Double` | No | `` | `` |
| `CenterPos` | `Vector2D` | No | `` | `` |
| `EndPos` | `Vector2D` | No | `` | `` |
| `L1` | `Double` | No | `` | `` |
| `L2` | `Double` | No | `` | `` |
| `LeftAngle` | `Double` | No | `` | `` |
| `P1` | `Double` | No | `` | `` |
| `P2` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `RightAngle` | `Double` | No | `` | `` |
| `StartPos` | `Vector2D` | No | `` | `` |

### `Vertex` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+Vertex` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Plan.PlanLine+Vertex, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Plan.PlanLine+Vertex`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vertex vertex)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `ID` | `UInt32` | `get/set` | No | `` |
| `IntermediateTops` | `IList<Vector2D>` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `VertexItem` | `get/set` | No | `` |
| `MinLineLength` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `PlanData` | `PlanData` | `get` | No | `` |
| `PlanLine` | `PlanLine` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `SummKoeff` | `Double` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `VertexItem item` | `` |
| `Assign` | `Void` | `Vertex item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `VertexItem item` | `` |
| `CopyTo` | `Void` | `VertexItem[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `Vertex other` | `` |
| `GetEnumerator` | `IEnumerator<VertexItem>` | `` | `` |
| `IndexOf` | `Int32` | `VertexItem item` | `` |
| `Insert` | `Void` | `Int32 index, VertexItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `VertexItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Valid` | `Boolean` | `` | `` |

#### Nested Types (1)

- `VertexItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `VertexItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Plan.PlanLine+Vertex+VertexItem`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `VertexItem other` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `K` | `Double` | No | `` | `` |
| `L1` | `Double` | No | `` | `` |
| `L2` | `Double` | No | `` | `` |
| `R` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `VertexValidation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plan.PlanLine+VertexValidation` |
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
      - `Topomatic.Alg.Plan.PlanLine+VertexValidation`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CurvesSects` | `VertexValidation` | Yes | `CurvesSects` | `` |
| `ElementsListWrong` | `VertexValidation` | Yes | `ElementsListWrong` | `` |
| `FirstVertexNotEmpty` | `VertexValidation` | Yes | `FirstVertexNotEmpty` | `` |
| `LastVertexNotEmpty` | `VertexValidation` | Yes | `LastVertexNotEmpty` | `` |
| `PositionsEquals` | `VertexValidation` | Yes | `PositionsEquals` | `` |
| `Valid` | `VertexValidation` | Yes | `Valid` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WrongClothLength` | `VertexValidation` | Yes | `WrongClothLength` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Valid` | `0` |
| `FirstVertexNotEmpty` | `1` |
| `LastVertexNotEmpty` | `2` |
| `WrongClothLength` | `3` |
| `CurvesSects` | `4` |
| `PositionsEquals` | `5` |
| `ElementsListWrong` | `6` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Plugins`

### `AlignmentPlugin` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plugins.AlignmentPlugin` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Plugins.AlignmentPlugin`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `VisualEmpty` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `ModifyVolumes` | `Void` | `List<CrsModifiedVolume> volumes, Section section` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `AlignmentPlugins` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plugins.AlignmentPlugins` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Alg.Plugins.AlignmentPlugin, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Item` | `AlignmentPlugin` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String uid, AlignmentPlugin plugin` | `` |
| `Contains` | `Boolean` | `String uid` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String AlignmentPlugin>>` | `` | `` |
| `IsVisualEmpty` | `Boolean` | `String uid` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `ModifyVolumes` | `Void` | `List<CrsModifiedVolume> volumes, Section section` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `String uid, ref AlignmentPlugin value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `IAlignmentPluginInitializator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plugins.IAlignmentPluginInitializator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeAlignment` | `Void` | `Alignment alignment` | `` |
| `ClosePlugins` | `Void` | `Alignment alignment` | `` |
| `CreatePlugins` | `Void` | `Alignment alignment` | `` |
| `MergePlugins` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |

### `IAlignmentPluginRelativePathsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Plugins.IAlignmentPluginRelativePathsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetRelativePaths` | `Void` | `Alignment alignment, IList<String> paths` | `` |
| `RefreshRelativePath` | `Void` | `Alignment alignment, URI folderUri` | `` |
| `ReplaceRelativePath` | `Void` | `Alignment alignment, String oldValue, String newValue` | `` |

---
## Namespace: `Topomatic.Alg.Prf`

### `AgProfile` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.AgProfile` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.AgProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.AgProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.AgProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.AgProfile`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `AgProfileNode` | `get/set` | No | `` |
| `MaxStation` | `Double` | `get` | No | `` |
| `MinStation` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Transition` | `Transition` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `AgProfileNode item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `AgProfileNode item` | `` |
| `CopyTo` | `Void` | `AgProfileNode[] array, Int32 arrayIndex` | `` |
| `FindFirstNode` | `Int32` | `Double station` | `` |
| `FindLastNode` | `Int32` | `Double station` | `` |
| `FindNodes` | `IEnumerable<Int32>` | `Double station` | `` |
| `GetEnumerator` | `IEnumerator<AgProfileNode>` | `` | `` |
| `GetY` | `Boolean` | `Double station, ref Value value` | `` |
| `GetY` | `Boolean` | `Double station, List<Value> values` | `` |
| `GetY` | `Boolean` | `Double station, List<KeyValuePair<Int32 Value>> values` | `` |
| `IndexOf` | `Int32` | `AgProfileNode item` | `` |
| `Insert` | `Void` | `Int32 index, AgProfileNode item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `AgProfileNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `Value` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITransitionContainer` | `get_Transition` |
| `IProfile` | `Topomatic.Alg.Prf.IProfile.GetY` |
| `IProfile` | `Topomatic.Alg.Prf.IProfile.GetStations` |
| `IAlignmentContainer` | `Topomatic.Alg.IAlignmentContainer.get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `AgProfileNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.AgProfileNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Prf.AgProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.AgProfileNode`

#### Constructors (1)

- `.ctor(AgProfileNode node)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `HasPositions` | `Boolean` | `get` | No | `` |
| `LeftPos` | `Vector2D` | `get` | No | `` |
| `RightPos` | `Vector2D` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `AgProfileNode other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `AgProfileNode` | `StgNode stgNode` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AgElevation` | `Double` | No | `` | `` |
| `EgElevation` | `Double` | No | `` | `` |
| `Grade` | `Double` | No | `` | `` |
| `LeftOffset` | `Double` | No | `` | `` |
| `RightOffset` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BuildProfileFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.BuildProfileFlags` |
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
      - `Topomatic.Alg.Prf.BuildProfileFlags`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AdditionalStations` | `BuildProfileFlags` | Yes | `AdditionalStations` | `` |
| `LinearCommunications` | `BuildProfileFlags` | Yes | `LinearCommunications` | `` |
| `PlanVertexes` | `BuildProfileFlags` | Yes | `PlanVertexes` | `` |
| `Ribs` | `BuildProfileFlags` | Yes | `Ribs` | `` |
| `Sections` | `BuildProfileFlags` | Yes | `Sections` | `` |
| `StepStations` | `BuildProfileFlags` | Yes | `StepStations` | `` |
| `UseCMMElevationsInsteadSections` | `BuildProfileFlags` | Yes | `UseCMMElevationsInsteadSections` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WholeStations` | `BuildProfileFlags` | Yes | `WholeStations` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `WholeStations` | `1` |
| `StepStations` | `2` |
| `PlanVertexes` | `4` |
| `Ribs` | `8` |
| `Sections` | `16` |
| `LinearCommunications` | `32` |
| `AdditionalStations` | `64` |
| `UseCMMElevationsInsteadSections` | `128` |

**Underlying Type**: `System.Int32`

### `DynamicProfile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.DynamicProfile` |
| **Base Type** | `Topomatic.Alg.Prf.Profile` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.Profile`
        - `Topomatic.Alg.Prf.DynamicProfile`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalStations` | `IList<Double>` | `get` | No | `` |
| `BuildFlags` | `BuildProfileFlags` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `MaxStation` | `Double` | `get` | No | `` |
| `MinStation` | `Double` | `get` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `InvalidateAndRefresh` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `UpdateDynamicProfile` | `EventHandler<DynamicProfileUpdateEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DynamicProfileUpdateEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.DynamicProfileUpdateEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Alg.Prf.DynamicProfileUpdateEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, BuildProfileFlags buildFlags, Double step, IEnumerable<Double> additionalStations, IList<ProfileNode> nodes, IOffset offset)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalStation` | `IEnumerable<Double>` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `BuildFlags` | `BuildProfileFlags` | `get` | No | `` |
| `Nodes` | `IList<ProfileNode>` | `get` | No | `` |
| `Offset` | `IOffset` | `get` | No | `` |
| `Step` | `Double` | `get` | No | `` |

### `FixedPointNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.FixedPointNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Prf.FixedPointNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.FixedPointNode`

#### Constructors (2)

- `.ctor(FixedPointNode node)`
- `.ctor(Double station, Double elevation, String descritpion, FixedPointsFlags flags)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `FixedPointNode other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, FixedPointNode defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `FixedPointNode` | `StgNode stgNode, FixedPointNode defaultValue` | `` |
| `LoadFromStg` | `FixedPointNode` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `FixedPointNode node, StgNode stgNode, FixedPointNode defaultValue` | `` |
| `SaveToStg` | `Void` | `FixedPointNode node, StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |
| `Flags` | `FixedPointsFlags` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `FixedPoints` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.FixedPoints` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.FixedPointNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.FixedPointNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.FixedPointNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Prf.FixedPoints`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `FixedPointNode` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Transition` | `Transition` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `FixedPointNode item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `FixedPointNode item` | `` |
| `CopyTo` | `Void` | `FixedPointNode[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<FixedPointNode>` | `` | `` |
| `IndexOf` | `Int32` | `FixedPointNode item` | `` |
| `Insert` | `Void` | `Int32 index, FixedPointNode item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `FixedPointNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IAlignmentContainer` | `get_Alignment` |
| `ITransitionContainer` | `get_Transition` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `FixedPointsFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.FixedPointsFlags` |
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
      - `Topomatic.Alg.Prf.FixedPointsFlags`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DrawDistance` | `FixedPointsFlags` | Yes | `DrawDistance` | `` |
| `None` | `FixedPointsFlags` | Yes | `None` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `DrawDistance` | `1` |

**Underlying Type**: `System.Byte`

### `IProfile` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.IProfile` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStations` | `IEnumerable<Double>` | `Boolean onlyMarked` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |

### `ITransitionContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ITransitionContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Transition` | `Transition` | `get` | No | `` |

### `ITransitions` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ITransitions` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Transition` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetNext` | `Int32` | `Int32 index` | `` |
| `GetPrevious` | `Int32` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `Transition item` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |
| `Undo` | `EventHandler` | No | `` |

### `ITransitionViolations` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ITransitionViolations` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Violations` | `IEnumerable<TransitionViolation>` | `get` | No | `` |

### `Profile` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.Profile` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.Profile`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ProfileNode` | `get` | No | `` |
| `MaxStation` | `Double` | `get` | No | `` |
| `MinStation` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Transition` | `Transition` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindFirstNode` | `Int32` | `Double station` | `` |
| `FindLastNode` | `Int32` | `Double station` | `` |
| `FindNodes` | `IEnumerable<Int32>` | `Double station` | `` |
| `GetStations` | `IEnumerable<Double>` | `Boolean onlyMarked` | `` |
| `GetY` | `Boolean` | `Double station, List<Double> values` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |
| `GetY` | `Boolean` | `Double station, List<KeyValuePair<Int32 Double>> values` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IProfile` | `GetY` |
| `IProfile` | `GetStations` |
| `ITransitionContainer` | `get_Transition` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ProfileExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProfileExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (35)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateArea` | `Void` | `SplineProfile spline, Profile eg, BridgesCollection bridges, ref Double fill, ref Double cut` | `Extension` |
| `CanSetSegmentGrade` | `Boolean` | `ProjectProfile profile, SegmentGradePosition position, Int32 startIndex, Double grade, Double distance` | `Extension` |
| `CopyFrom` | `Void` | `ProjectProfile to, ProjectProfile from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `CopyFrom` | `Void` | `AgProfile to, AgProfile from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `CopyFrom` | `Void` | `SplineProfile to, SplineProfile from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `CopyFrom` | `Void` | `FixedPoints to, FixedPoints from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `CopyFrom` | `Void` | `DynamicProfile to, DynamicProfile from` | `Extension` |
| `CopyFrom` | `Void` | `StaticProfile to, StaticProfile from, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `AgProfile current, AgProfile profile, Double station` | `Extension` |
| `EqualsWith` | `Boolean` | `ProjectProfile current, ProjectProfile profile, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `FixedPoints current, FixedPoints points, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `FixedPoints current, FixedPoints points, Double station` | `Extension` |
| `EqualsWith` | `Boolean` | `StaticProfile current, StaticProfile profile, Double station` | `Extension` |
| `EqualsWith` | `Boolean` | `SplineProfile current, SplineProfile profile, Double station` | `Extension` |
| `EqualsWith` | `Boolean` | `ProjectProfile current, ProjectProfile profile, Double station` | `Extension` |
| `EqualsWith` | `Boolean` | `StaticProfile current, StaticProfile profile, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `DynamicProfile current, DynamicProfile profile` | `Extension` |
| `EqualsWith` | `Boolean` | `SplineProfile current, SplineProfile profile, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `EqualsWith` | `Boolean` | `AgProfile current, AgProfile profile, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `Extension` |
| `GetFakeElevation` | `Boolean` | `ProjectProfile profile, Double station, ref Double value` | `Extension` |
| `GetSegmentGrade` | `Double` | `ProjectProfile profile, SegmentGradePosition position, Int32 startIndex` | `Extension` |
| `Invert` | `Void` | `ProjectProfile profile` | `Extension` |
| `Join` | `Void` | `StaticProfile current, AlignmentJoinType joinType, StaticProfile first, Double firstLength, StaticProfile second, Double secondLength` | `Extension` |
| `Join` | `Void` | `ProjectProfile current, AlignmentJoinType joinType, ProjectProfile first, Double firstLength, ProjectProfile second, Double secondLength` | `Extension` |
| `Join` | `Void` | `SplineProfile current, AlignmentJoinType joinType, SplineProfile first, Double firstLength, SplineProfile second, Double secondLength` | `Extension` |
| `Join` | `Void` | `FixedPoints current, AlignmentJoinType joinType, FixedPoints first, Double firstLength, FixedPoints second, Double secondLength` | `Extension` |
| `Join` | `Void` | `AgProfile current, AlignmentJoinType joinType, AgProfile first, Double firstLength, AgProfile second, Double secondLength` | `Extension` |
| `NodesChangeValid` | `Boolean` | `ProjectProfile profile, IList<KeyValuePair<Int32 ProjectNode>> nodes` | `Extension` |
| `SafeInsertNodes` | `Void` | `ProjectProfile profile, IList<ProjectNode> nodes` | `Extension` |
| `SetSegmentGrade` | `Boolean` | `ProjectProfile profile, SegmentGradePosition position, Int32 startIndex, Double grade, Double distance` | `Extension` |
| `Split` | `Void` | `StaticProfile current, Double station, StaticProfile before, StaticProfile after` | `Extension` |
| `Split` | `Void` | `AgProfile current, Double station, AgProfile before, AgProfile after` | `Extension` |
| `Split` | `Void` | `ProjectProfile current, Double station, ProjectProfile before, ProjectProfile after` | `Extension` |
| `Split` | `Void` | `SplineProfile current, Double station, SplineProfile before, SplineProfile after` | `Extension` |
| `Split` | `Void` | `FixedPoints current, Double station, FixedPoints before, FixedPoints after` | `Extension` |

#### Nested Types (1)

- `SegmentGradePosition` (enum)

### `ProfileNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProfileNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.ProfileNode`

#### Constructors (3)

- `.ctor(ProfileNode node)`
- `.ctor(Double station, Double elevation)`
- `.ctor(Double station, Double elevation, Int32 code, UInt32 displayFlags)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ProfileNode other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, ProfileNode defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ProfileNode` | `StgNode stgNode, ProfileNode defaultValue` | `` |
| `LoadFromStg` | `ProfileNode` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `ProfileNode prfNode, StgNode stgNode, ProfileNode defaultValue` | `` |
| `SaveToStg` | `Void` | `ProfileNode prfNode, StgNode stgNode` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `DEFAULT` | `UInt32` | Yes | `1` | `` |
| `DISPLAY_ELEVATION` | `UInt32` | Yes | `1` | `` |
| `DisplayFlags` | `UInt32` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |
| `HIDE_ELEVATION` | `UInt32` | Yes | `0` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ProjectNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProjectNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Prf.ProjectNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.ProjectNode`

#### Constructors (2)

- `.ctor(ProjectNode node)`
- `.ctor(Double x, Double y, Double length, Double radius, ProjectNodeFlags flags)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasCurve` | `Boolean` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ProjectNode other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, ProjectNode defaultValue` | `` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LengthByRadius` | `Double` | `Double g1, Double g2, Double radius` | `` |
| `LoadFromStg` | `ProjectNode` | `StgNode stgNode` | `` |
| `LoadFromStg` | `ProjectNode` | `StgNode stgNode, ProjectNode defaultValue` | `` |
| `RadiusByLength` | `Double` | `Double g1, Double g2, Double length` | `` |
| `SaveToStg` | `Void` | `ProjectNode prfNode, StgNode stgNode, ProjectNode defaultValue` | `` |
| `SaveToStg` | `Void` | `ProjectNode prfNode, StgNode stgNode` | `` |
| `TryCalculateGrade` | `Boolean` | `ProjectNode first, ProjectNode second, ref Double grade` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Elevation` | `Double` | No | `` | `` |
| `Flags` | `ProjectNodeFlags` | No | `` | `` |
| `Length` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ProjectNodeFlags` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProjectNodeFlags` |
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
      - `Topomatic.Alg.Prf.ProjectNodeFlags`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `UseLength` | `ProjectNodeFlags` | Yes | `UseLength` | `` |
| `UseRadius` | `ProjectNodeFlags` | Yes | `UseRadius` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `UseLength` | `0` |
| `UseRadius` | `1` |

**Underlying Type**: `System.Int32`

### `ProjectProfile` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProjectProfile` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.ProjectNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.ProjectNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.ProjectNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.ProjectProfile`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, ProjectProfile profile)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `FirstGrade` | `Double` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ProjectNode` | `get/set` | No | `` |
| `LastGrade` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SplineMode` | `Boolean` | `get/set` | No | `` |
| `SplineProfile` | `SplineProfile` | `get` | No | `` |
| `Transition` | `Transition` | `get` | No | `` |

#### Instance Methods (30)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ProjectNode item` | `` |
| `Assign` | `Void` | `ProjectProfile profile` | `` |
| `CalculateGrade` | `Void` | `Int32 index, ProjectNode node, ref Double g1, ref Double g2` | `` |
| `CalculateLengthByRadius` | `Double` | `Int32 index, ProjectNode node` | `` |
| `CalculateNodeLength` | `Double` | `Int32 index, ProjectNode node` | `` |
| `CalculateNodeRadius` | `Double` | `Int32 index, ProjectNode node` | `` |
| `CalculateRadiusByLength` | `Double` | `Int32 index, ProjectNode node` | `` |
| `ChangesInterval` | `Boolean` | `Int32 index, ProjectNode node, ref Double left, ref Double right` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ProjectNode item` | `` |
| `CopyTo` | `Void` | `ProjectNode[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ProjectNode>` | `` | `` |
| `GetStations` | `IEnumerable<Double>` | `Boolean onlyMarked` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |
| `GetYG` | `Boolean` | `Int32 index, ref Double y, ref Double g` | `` |
| `IndexOf` | `Int32` | `ProjectNode item` | `` |
| `Insert` | `Void` | `Int32 index, ProjectNode item` | `` |
| `InsertInterval` | `Boolean` | `Int32 index, ProjectNode node, ref Double left, ref Double right` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `NodeChangeValid` | `Boolean` | `Int32 index, ProjectNode node` | `` |
| `NodeInsertValid` | `Boolean` | `Int32 index, ProjectNode node` | `` |
| `NodeRemoveValid` | `Boolean` | `Int32 index` | `` |
| `Remove` | `Boolean` | `ProjectNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveInterval` | `Boolean` | `Int32 index, ref Double left, ref Double right` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Int32` | `Double x` | `` |
| `Search` | `Boolean` | `Double x, ref Int32 index` | `` |
| `SetYG` | `Boolean` | `Int32 index, Double y, Double g` | `` |
| `TryInsertNode` | `Boolean` | `ProjectNode item, Boolean hard` | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `IndexerEventHandler` | No | `` |
| `AfterModify` | `IndexerEventHandler` | No | `` |
| `BeforeRemove` | `IndexerEventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ITransitionContainer` | `get_Transition` |
| `IProfile` | `GetY` |
| `IProfile` | `GetStations` |
| `IAlignmentContainer` | `get_Alignment` |

### `SegmentGradePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.ProfileExtensions+SegmentGradePosition` |
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
      - `Topomatic.Alg.Prf.ProfileExtensions+SegmentGradePosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `SegmentGradePosition` | Yes | `Left` | `` |
| `Middle` | `SegmentGradePosition` | Yes | `Middle` | `` |
| `Right` | `SegmentGradePosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Middle` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `SplineNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.SplineNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Prf.SplineNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.SplineNode`

#### Constructors (2)

- `.ctor(SplineNode node)`
- `.ctor(Double station, Double elevation)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get` | No | `` |
| `B` | `Double` | `get` | No | `` |
| `C` | `Double` | `get` | No | `` |
| `D` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SplineNode other` | `` |
| `GetSum` | `Boolean` | `ref Double station, ref Double elevation` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, SplineNode defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SplineNode` | `StgNode stgNode, SplineNode defaultValue` | `` |
| `LoadFromStg` | `SplineNode` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `SplineNode prfNode, StgNode stgNode, SplineNode defaultValue` | `` |
| `SaveToStg` | `Void` | `SplineNode prfNode, StgNode stgNode` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Curvature` | `Double` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |
| `Grade` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `SplineProfile` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.SplineProfile` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.SplineNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.SplineNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.SplineNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Prf.SplineProfile`

#### Constructors (1)

- `.ctor(ProjectProfile projectProfile)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `InnerMaxRadius` | `Double` | `get` | No | `` |
| `InnerMinRadius` | `Double` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `SplineNode` | `get/set` | No | `` |
| `MaxGrade` | `Double` | `get` | No | `` |
| `MaxLength` | `Double` | `get` | No | `` |
| `MinGrade` | `Double` | `get` | No | `` |
| `MinLength` | `Double` | `get` | No | `` |
| `OuterMaxRadius` | `Double` | `get` | No | `` |
| `OuterMinRadius` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SplineNode item` | `` |
| `CanSafeChangeNode` | `Boolean` | `Int32 index, SplineNode node` | `` |
| `CanSafeInsertNode` | `Boolean` | `Int32 index, SplineNode node` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `SplineNode item` | `` |
| `CopyTo` | `Void` | `SplineNode[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<SplineNode>` | `` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |
| `GetYG` | `Boolean` | `Double station, ref Double value, ref Double grade` | `` |
| `IndexOf` | `Int32` | `SplineNode item` | `` |
| `Insert` | `Void` | `Int32 index, SplineNode item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `SplineNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SafeRemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Boolean` | `Double station, ref Int32 index` | `` |
| `SolveExtremum` | `Boolean` | `Double startStation, Double endStation, ref Double minimum, ref Double maximum` | `` |
| `SolveRadius` | `Boolean` | `Double station, ref Double radius` | `` |
| `TrySafeChangeNode` | `Boolean` | `Int32 index, SplineNode node` | `` |
| `TrySafeInsertNode` | `Boolean` | `Int32 index, SplineNode node` | `` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcSplineNode` | `Boolean` | `SplineNode nextNode, ref SplineNode node` | `` |
| `SolveCoeff` | `Void` | `Double x1, Double x2, Double y1, Double y2, Double g1, Double g2, ref Double a, ref Double b, ref Double c, ref Double d` | `` |
| `SolveCubic` | `Double[]` | `Double a, Double b, Double c, Double d` | `` |
| `SolveRadius` | `Boolean` | `SplineNode node1, SplineNode node2, ref Double radius1, ref Double radius2` | `` |
| `SolveSplineCoeff` | `Void` | `Double dx, Double dy, Double g1, Double g2, ref Double a, ref Double b` | `` |
| `SolveSquare` | `Double[]` | `Double a, Double b, Double c` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StaticProfile` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.StaticProfile` |
| **Base Type** | `Topomatic.Alg.Prf.Profile` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.Profile`
        - `Topomatic.Alg.Prf.StaticProfile`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, StaticProfile profile)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ProfileNode` | `get/set` | No | `` |
| `MaxStation` | `Double` | `get` | No | `` |
| `MinStation` | `Double` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ProfileNode item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ProfileNode item` | `` |
| `CopyTo` | `Void` | `ProfileNode[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ProfileNode>` | `` | `` |
| `IndexOf` | `Int32` | `ProfileNode item` | `` |
| `Insert` | `Void` | `Int32 index, ProfileNode item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ProfileNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

### `Transition` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.Transition` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Prf.Transition`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AgProfile` | `AgProfile` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `CutArea` | `Double` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DynamicEg` | `DynamicProfile` | `get` | No | `` |
| `EgProfile` | `Profile` | `get` | No | `` |
| `FillArea` | `Double` | `get` | No | `` |
| `FixedPoints` | `FixedPoints` | `get` | No | `` |
| `Gaps` | `GapsCollection` | `get` | No | `` |
| `IsDynamicEarth` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `IOffset` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RedProfile` | `ProjectProfile` | `get` | No | `` |
| `StaticEg` | `StaticProfile` | `get` | No | `` |
| `Underlay` | `Drawing` | `get/set` | No | `` |
| `UnderlayEnd` | `Vector2D` | `get/set` | No | `` |
| `UnderlayStart` | `Vector2D` | `get/set` | No | `` |
| `UserProfiles` | `UserProfiles` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanJoin` | `KeyValuePair<Boolean String>` | `AlignmentJoinType joinType, Transition first, Double firstLength, Transition second, Double secondLength` | `` |
| `CanSplit` | `KeyValuePair<Boolean String>` | `Double station, Transition before, Transition after` | `` |
| `Clear` | `Void` | `` | `` |
| `CopyFrom` | `Void` | `Transition transition, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `EqualsWith` | `Boolean` | `Transition transition, Double station` | `` |
| `EqualsWith` | `Boolean` | `Transition transition, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Join` | `Void` | `AlignmentJoinType joinType, Transition first, Double firstLength, Transition second, Double secondLength` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Split` | `Void` | `Double station, Transition before, Transition after` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITransitionContainer` | `Topomatic.Alg.Prf.ITransitionContainer.get_Transition` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `TransitionViolation` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.TransitionViolation` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.TransitionViolation+Violation, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.IComparable`1[[Topomatic.Alg.Prf.TransitionViolation, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double station)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Violation` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String description, TransitionViolationType type` | `` |
| `CompareTo` | `Int32` | `TransitionViolation other` | `` |
| `GetEnumerator` | `IEnumerator<Violation>` | `` | `` |

#### Nested Types (1)

- `Violation` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IComparable`1` | `CompareTo` |

### `TransitionViolationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.TransitionViolationType` |
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
      - `Topomatic.Alg.Prf.TransitionViolationType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeltaGrade` | `TransitionViolationType` | Yes | `DeltaGrade` | `` |
| `Geometry` | `TransitionViolationType` | Yes | `Geometry` | `` |
| `Grade` | `TransitionViolationType` | Yes | `Grade` | `` |
| `Length` | `TransitionViolationType` | Yes | `Length` | `` |
| `Radius` | `TransitionViolationType` | Yes | `Radius` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Geometry` | `0` |
| `DeltaGrade` | `1` |
| `Radius` | `2` |
| `Grade` | `3` |
| `Length` | `4` |

**Underlying Type**: `System.Int32`

### `UserProfile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.UserProfile` |
| **Base Type** | `Topomatic.Alg.Prf.StaticProfile` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.IProfile, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Prf.ProfileNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.Profile`
        - `Topomatic.Alg.Prf.StaticProfile`
          - `Topomatic.Alg.Prf.UserProfile`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, UserProfile profile)`
- `.ctor(Object parent, String name, String description, CadColor color, Boolean showDifference)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ShowDifference` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UserProfiles` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.UserProfiles` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Prf.ITransitionContainer, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Prf.UserProfile, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Prf.UserProfiles`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Transition` | `Transition` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `UserProfile profile` | `` |
| `Clear` | `Void` | `` | `` |
| `ContainsKey` | `Boolean` | `String key` | `` |
| `GetEnumerator` | `IEnumerator<UserProfile>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `UserProfile profile` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `String key, ref UserProfile profile` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITransitionContainer` | `get_Transition` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `Value` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.AgProfile+Value` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.AgProfile+Value`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ag` | `Double` | No | `` | `` |
| `Eg` | `Double` | No | `` | `` |
| `Elevation` | `Double` | No | `` | `` |

### `Violation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Prf.TransitionViolation+Violation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Prf.TransitionViolation+Violation`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Type` | `TransitionViolationType` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.ServiceClasses`

### `EditableItemsStationKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ServiceClasses.EditableItemsStationKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.ServiceClasses.EditableItemsStationKey`

#### Constructors (1)

- `.ctor(Double station, Int32 stepIndex)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get/set` | No | `` |
| `StepIndex` | `Int32` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICloneable` | `Clone` |

### `InterpolateSectionParametersBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ServiceClasses.InterpolateSectionParametersBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment, Double from, Double to)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Interpolate` | `Void` | `Double station, Predicate<ISectionParameter> match` | `` |

### `IntervalSearcher` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ServiceClasses.IntervalSearcher` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Intevals` | `IEnumerable<KeyValuePair<Double Double>>` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Double start, Double end` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Double start, Double end, ref IEnumerable<KeyValuePair<Double Double>> pairs` | `` |
| `Contains` | `Boolean` | `Double station, ref Double start, ref Double end` | `` |
| `Contains` | `Boolean` | `Double station` | `` |
| `Intersect` | `Boolean` | `Double start, Double end, ref IEnumerable<KeyValuePair<Double Double>> pairs` | `` |

### `SortedDoubleListWithDuplicated` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ServiceClasses.SortedDoubleListWithDuplicated` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Double value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Double value` | `` |
| `Convert` | `Void` | `List<Double> stations, Double duplicatedEps, Predicate<Double> canSplit` | `` |
| `IsDuplicated` | `Boolean` | `Double value` | `` |

### `StoreSectionParametersBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.ServiceClasses.StoreSectionParametersBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Restore` | `Void` | `Double station` | `` |
| `Store` | `Void` | `Double station` | `` |

---
## Namespace: `Topomatic.Alg.Signs`

### `ConventionalSign` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Signs.ConventionalSign` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Signs.ConventionalSign`

#### Constructors (2)

- `.ctor(Object owner, ConventionalSign sign)`
- `.ctor(Object owner, Int32 semanticCode)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `DataSet` | `SemanticDataSet` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `IsExist` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SemanticCode` | `Int32` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConventionalSigns` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Signs.ConventionalSigns` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Signs.ConventionalSign, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Signs.ConventionalSign, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Signs.ConventionalSign, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Signs.ConventionalSigns`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ConventionalSign` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ConventionalSign item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ConventionalSign item` | `` |
| `CopyTo` | `Void` | `ConventionalSign[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ConventionalSign>` | `` | `` |
| `IndexOf` | `Int32` | `ConventionalSign item` | `` |
| `Insert` | `Void` | `Int32 index, ConventionalSign item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ConventionalSign item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Alg.Solvers`

### `SplineProfileConverter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Solvers.SplineProfileConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SplineExplodeToProjectProfile` | `Void` | `SplineProfile splineProfile, ProjectProfile projectProfile` | `` |

---
## Namespace: `Topomatic.Alg.Stationing`

### `AlgBaseStationing` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.AlgBaseStationing` |
| **Base Type** | `Topomatic.Cad.Foundation.Stationing.Stationing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IStationing, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Stationing, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Alg.Stationing.IAlgStationing, System.IEquatable`1[[Topomatic.Alg.Stationing.IAlgStationing, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedStationing`
      - `Topomatic.Cad.Foundation.Stationing.Stationing`
        - `Topomatic.Alg.Stationing.AlgBaseStationing`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, AlgBaseStationing stationing)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanMakeDefault` | `Boolean` | `get` | No | `` |
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `Empty` | `Boolean` | `get` | No | `` |
| `StationLength` | `Double` | `get/set` | No | `Obsolete(Message: `Use WholeLength instead`)` |
| `Stations` | `IEnumerable<Double>` | `get` | No | `Obsolete(Message: `Use FillWholes instead`)` |

#### Instance Methods (24)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `IAlgStationing stationing` | `` |
| `CanJoin` | `String` | `AlignmentJoinType joinType, AlgBaseStationing firstStationing, AlgBaseStationing secondStationing` | `` |
| `CanSplit` | `String` | `Double station, AlgBaseStationing beforeSection, AlgBaseStationing afterSection` | `` |
| `ContainsWhole` | `Boolean` | `Double station` | `Obsolete(Message: `Use IsWhole instead`)` |
| `Equals` | `Boolean` | `IAlgStationing other` | `` |
| `Join` | `Void` | `AlignmentJoinType joinType, AlgBaseStationing firstStationing, AlgBaseStationing secondStationing, Double firstLen, Double secondLen` | `` |
| `MakeDefault` | `Void` | `Int32 startPk, Double startPlus, Double traceLength` | `` |
| `PkToStation` | `Double` | `Int32 number, Nullable<Char> index, Double plus` | `Obsolete(Message: `Use FromPk instead`)` |
| `Split` | `Void` | `Double station, AlgBaseStationing beforeSection, AlgBaseStationing afterSection` | `` |
| `StationToPk` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `Obsolete(Message: `Use ToPk instead`)` |
| `StationToPk` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `Obsolete(Message: `Use ToPk instead`)` |
| `StationToPkDecimal` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `Obsolete(Message: `Use ToPkDecimal instead`)` |
| `StationToPkDecimal` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `Obsolete(Message: `Use ToPkDecimal instead`)` |
| `StationToString` | `Void` | `Double station, ref String pk, ref String plus` | `Obsolete(Message: `Use ToString instead`)` |
| `StationToString` | `String` | `Double sta1, Double sta2` | `Obsolete(Message: `Use ToString instead`)` |
| `StationToString` | `Void` | `Double station, Int32 digits, Boolean showZeroFeet, ref String pk, ref String plus` | `Obsolete(Message: `Use ToString instead`)` |
| `StationToString` | `String` | `Double station` | `Obsolete(Message: `Use ToString instead`)` |
| `StringToStation` | `Double` | `String value` | `Obsolete(Message: `Use FromString instead`)` |
| `StringToStation` | `Double` | `String pk, String plus` | `Obsolete(Message: `Use FromString instead`)` |
| `StringToStation` | `Void` | `String value, ref Double sta1, ref Double sta2` | `Obsolete(Message: `Use FromString instead`)` |
| `TryPkToStation` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double station` | `Obsolete(Message: `Use FromPk instead`)` |
| `TryStringToStation` | `Boolean` | `String pk, String plus, ref Double station` | `Obsolete(Message: `Use FromString instead`)` |
| `TryStringToStation` | `Boolean` | `String value, ref Double sta1, ref Double sta2` | `Obsolete(Message: `Use FromString instead`)` |
| `TryStringToStation` | `Boolean` | `String value, ref Double station` | `Obsolete(Message: `Use FromString instead`)` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlgStationing` | `StationToString` |
| `IAlgStationing` | `StationToString` |
| `IAlgStationing` | `StationToString` |
| `IAlgStationing` | `StationToString` |
| `IAlgStationing` | `StationToPk` |
| `IAlgStationing` | `StationToPkDecimal` |
| `IAlgStationing` | `PkToStation` |
| `IAlgStationing` | `TryPkToStation` |
| `IAlgStationing` | `TryStringToStation` |
| `IAlgStationing` | `TryStringToStation` |
| `IAlgStationing` | `TryStringToStation` |
| `IAlgStationing` | `StringToStation` |
| `IAlgStationing` | `StringToStation` |
| `IAlgStationing` | `StringToStation` |
| `IAlgStationing` | `get_StationLength` |
| `IAlgStationing` | `set_StationLength` |
| `IAlgStationing` | `MakeDefault` |
| `IAlgStationing` | `get_CanMakeDefault` |
| `IAlgStationing` | `get_Empty` |
| `IAlgStationing` | `get_Stations` |
| `IAlgStationing` | `Assign` |
| `IAlgStationing` | `get_EditedItems` |
| `IAlgStationing` | `ContainsWhole` |
| `IEquatable`1` | `Equals` |

### `AlgStationing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.AlgStationing` |
| **Base Type** | `Topomatic.Alg.Stationing.AlgBaseStationing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IStationing, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Stationing, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Alg.Stationing.IAlgStationing, System.IEquatable`1[[Topomatic.Alg.Stationing.IAlgStationing, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedStationing`
      - `Topomatic.Cad.Foundation.Stationing.Stationing`
        - `Topomatic.Alg.Stationing.AlgBaseStationing`
          - `Topomatic.Alg.Stationing.AlgStationing`

#### Constructors (2)

- `.ctor(Alignment alignment)`
- `.ctor(Alignment alignment, AlgStationing stationing)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanMakeDefault` | `Boolean` | `get` | No | `` |
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `Empty` | `Boolean` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanJoin` | `String` | `AlignmentJoinType joinType, AlgBaseStationing firstStationing, AlgBaseStationing secondStationing` | `` |
| `CanSplit` | `String` | `Double station, AlgBaseStationing beforeSection, AlgBaseStationing afterSection` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeDefault` | `Void` | `Int32 startPk, Double startPlus, Double traceLength` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlgStationing` | `MakeDefault` |
| `IAlgStationing` | `get_CanMakeDefault` |
| `IAlgStationing` | `get_Empty` |
| `IAlgStationing` | `get_EditedItems` |
| `IAlignmentContainer` | `get_Alignment` |

### `IAlgStationing` (interface)

**Attributes**: [Obsolete(Message: `Use Topomatic.Cad.Stationing.IStationingRepository instead`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.IAlgStationing` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Stationing.IAlgStationing, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.Stationing.IStationing` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanMakeDefault` | `Boolean` | `get` | No | `` |
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `Empty` | `Boolean` | `get` | No | `` |
| `StationLength` | `Double` | `get/set` | No | `` |
| `Stations` | `IEnumerable<Double>` | `get` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `IAlgStationing stationing` | `` |
| `Clear` | `Void` | `` | `` |
| `ContainsWhole` | `Boolean` | `Double station` | `` |
| `MakeDefault` | `Void` | `Int32 startPk, Double startPlus, Double traceLength` | `` |
| `PkToStation` | `Double` | `Int32 number, Nullable<Char> index, Double plus` | `` |
| `StationToPk` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `` |
| `StationToPkDecimal` | `Boolean` | `Double station, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `` |
| `StationToString` | `String` | `Double station` | `` |
| `StationToString` | `Void` | `Double station, Int32 digits, Boolean showZeroFeet, ref String pk, ref String plus` | `` |
| `StationToString` | `String` | `Double sta1, Double sta2` | `` |
| `StationToString` | `Void` | `Double station, ref String pk, ref String plus` | `` |
| `StringToStation` | `Void` | `String value, ref Double sta1, ref Double sta2` | `` |
| `StringToStation` | `Double` | `String pk, String plus` | `` |
| `StringToStation` | `Double` | `String value` | `` |
| `TryPkToStation` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double station` | `` |
| `TryStringToStation` | `Boolean` | `String value, ref Double station` | `` |
| `TryStringToStation` | `Boolean` | `String pk, String plus, ref Double station` | `` |
| `TryStringToStation` | `Boolean` | `String value, ref Double sta1, ref Double sta2` | `` |

### `StaticStationing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.StaticStationing` |
| **Base Type** | `Topomatic.Alg.Stationing.AlgBaseStationing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IStationing, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Stationing, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Alg.Stationing.IAlgStationing, System.IEquatable`1[[Topomatic.Alg.Stationing.IAlgStationing, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedStationing`
      - `Topomatic.Cad.Foundation.Stationing.Stationing`
        - `Topomatic.Alg.Stationing.AlgBaseStationing`
          - `Topomatic.Alg.Stationing.StaticStationing`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, AlgStationing stationing)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanMakeDefault` | `Boolean` | `get` | No | `` |
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `Empty` | `Boolean` | `get` | No | `` |
| `TraceLength` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanJoin` | `String` | `AlignmentJoinType joinType, AlgBaseStationing firstStationing, AlgBaseStationing secondStationing` | `` |
| `CanSplit` | `String` | `Double station, AlgBaseStationing beforeSection, AlgBaseStationing afterSection` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeDefault` | `Void` | `Int32 startPk, Double startPlus, Double traceLength` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlgStationing` | `MakeDefault` |
| `IAlgStationing` | `get_CanMakeDefault` |
| `IAlgStationing` | `get_Empty` |
| `IAlgStationing` | `get_EditedItems` |

### `StationingEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.StationingEditableItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Alg.Stationing.StationingEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flipped` | `Boolean` | `get/set` | No | `` |
| `ItemStyle` | `StationingItemStyle` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |

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

### `StationingItemStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Stationing.StationingItemStyle` |
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
      - `Topomatic.Alg.Stationing.StationingItemStyle`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Decimal` | `StationingItemStyle` | Yes | `Decimal` | `` |
| `Default` | `StationingItemStyle` | Yes | `Default` | `` |
| `Full` | `StationingItemStyle` | Yes | `Full` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `Full` | `1` |
| `Decimal` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Strips`

### `Strip` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Strips.Strip` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Alg.Strips.StripNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Strips.StripNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Alg.Strips.StripNode, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(StripExtension length)`
- `.ctor(IEnumerable<StripNode> collection, StripExtension length)`
- `.ctor(Int32 capacity, StripExtension length)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Extension` | `StripExtension` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `StripNode` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `StripNode item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `StripNode item` | `` |
| `CopyTo` | `Void` | `StripNode[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<StripNode>` | `` | `` |
| `IndexOf` | `Int32` | `StripNode item` | `` |
| `Insert` | `Void` | `Int32 index, StripNode item` | `` |
| `Remove` | `Boolean` | `StripNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveDuplicated` | `Strip` | `` | `` |
| `Search` | `Boolean` | `Double station, ref Int32 index, ref Int32 count` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Double lastValue` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Boolean isFirstValue, ref Double lastValue, ref Boolean isLastValue` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

### `StripExtension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Strips.StripExtension` |
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
      - `Topomatic.Alg.Strips.StripExtension`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Final` | `StripExtension` | Yes | `Final` | `` |
| `Infinite` | `StripExtension` | Yes | `Infinite` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Infinite` | `0` |
| `Final` | `1` |

**Underlying Type**: `System.Int32`

### `StripNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Strips.StripNode` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Strips.StripNode`

#### Constructors (1)

- `.ctor(Double station, Double value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsAlone` | `Boolean` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Station` | `Double` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.Style`

### `AlignmentGripStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.AlignmentGripStyle` |
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
      - `Topomatic.Alg.Style.AlignmentGripStyle`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ExtendedGrips` | `AlignmentGripStyle` | Yes | `ExtendedGrips` | `` |
| `SimpleGrips` | `AlignmentGripStyle` | Yes | `SimpleGrips` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SimpleGrips` | `0` |
| `ExtendedGrips` | `1` |

**Underlying Type**: `System.Int32`

### `AlignmentLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultEnableValue` | `Boolean` | `get` | No | `` |
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDwgColor` | `CadColor` | `` | `` |
| `GetDwgEnable` | `Boolean` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `` | `` |
| `GetDwgVisible` | `Boolean` | `` | `` |
| `SetDwgEnable` | `Void` | `Boolean value` | `` |
| `SetDwgVisible` | `Void` | `Boolean value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlignmentStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.AlignmentStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Alg.Alignment, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment owner)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BridgesStyle` | `BridgesStyle` | `get` | No | `` |
| `CrossSectionStyle` | `CrossSectionStyle` | `get` | No | `` |
| `CurrentCrossSectionStyle` | `CurrentCrossSectionStyle` | `get` | No | `` |
| `CuttingSurfaceStyle` | `CuttingSurfacesStyle` | `get` | No | `` |
| `ElementsStyle` | `ElementsStyle` | `get` | No | `` |
| `KilometresStyle` | `KilometresStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `LineSegmentsStyle` | `LineSegmentsStyle` | `get` | No | `` |
| `Owner` | `Alignment` | `get/set` | No | `` |
| `PerspectiveStyle` | `PerspectiveStyle` | `get` | No | `` |
| `PipesStyle` | `PipesStyle` | `get` | No | `` |
| `PlanStyle` | `PlanStyle` | `get` | No | `` |
| `PrecisionStyle` | `PrecisionStyle` | `get` | No | `` |
| `ProfileStyle` | `ProfileStyle` | `get` | No | `` |
| `ProfileVisibleStyle` | `ProfileVisibleStyle` | `get` | No | `` |
| `Regions` | `Regions` | `get` | No | `` |
| `RegionStyles` | `RegionStyles` | `get` | No | `` |
| `StationingStyle` | `StationingStyle` | `get` | No | `` |
| `VertexesStyle` | `VertexesStyle` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `AlignmentStyle style` | `` |
| `GetCustomColor` | `Int32` | `String key, Int32 defaultColor` | `` |
| `GetCustomVisibleState` | `Boolean` | `String key, Boolean defaultValue` | `` |
| `GetEnumerator` | `IEnumerator<AlignmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetCustomColor` | `Void` | `String key, Int32 color, Int32 defaultColor` | `` |
| `SetCustomVisibleState` | `Void` | `String key, Boolean visible` | `` |

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

### `AlignmentStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BridgesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.BridgesStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Style.BridgesStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `BridgesStyle style` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrossSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.CrossSectionStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Style.CrossSectionStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `ElevationColor` | `CadColor` | `get/set` | No | `` |
| `ElevationFont` | `String` | `get/set` | No | `` |
| `ElevationFormat` | `String` | `get/set` | No | `` |
| `ElevationTextSize` | `Double` | `get/set` | No | `` |
| `GradeInceptionValue` | `Double` | `get/set` | No | `` |
| `HighlightPointsSize` | `Single` | `get/set` | No | `` |
| `LeftLineLength` | `Double` | `get/set` | No | `` |
| `RightLineLength` | `Double` | `get/set` | No | `` |
| `ShowCl` | `Boolean` | `get/set` | No | `` |
| `ShowErhElevation` | `Boolean` | `get/set` | No | `` |
| `ShowPkt` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandard` | `String` | `get` | No | `` |
| `UseGradeInceptionOnPanel` | `Boolean` | `get/set` | No | `` |
| `WithGrades` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `CrossSectionStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CurrentCrossSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.CurrentCrossSectionStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.CurrentCrossSectionStyle`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `LeftLineLength` | `Single` | `get/set` | No | `` |
| `RightLineLength` | `Single` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `CurrentCrossSectionStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CuttingSurfacesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.CuttingSurfacesStyle` |
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
      - `Topomatic.Alg.Style.CuttingSurfacesStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Codes` | `String` | `get/set` | No | `` |
| `DrawGabarits` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `CuttingSurfacesStyle style` | `` |
| `IsInCodes` | `Boolean` | `Int32 code` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsValidCodesString` | `Boolean` | `String codes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ElementsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.ElementsStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Style.ElementsStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `ElementsTextStandardName` | `String` | `get` | No | `` |
| `ShowAngle` | `Boolean` | `get/set` | No | `` |
| `ShowCircularCurveLength` | `Boolean` | `get/set` | No | `` |
| `ShowClothoidLength` | `Boolean` | `get/set` | No | `` |
| `ShowCurveLength` | `Boolean` | `get/set` | No | `` |
| `ShowPluses` | `Boolean` | `get/set` | No | `` |
| `ShowRadius` | `Boolean` | `get/set` | No | `` |
| `ShowTangents` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `WipeoutEntities` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `ElementsStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `KilometresStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.KilometresStyle` |
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
      - `Topomatic.Alg.Style.KilometresStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `KilometresStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LineSegmentsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.LineSegmentsStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Style.LineSegmentsStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisibleValue` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `LineSegmentsStyle style` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_OldLineSegmentTextSize` | `Double` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PerspectiveStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.PerspectiveStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.PerspectiveStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get/set` | No | `` |
| `WireFrame` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `PerspectiveStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PipesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.PipesStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Style.PipesStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `PipesStyle style` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.PlanStyle` |
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
      - `Topomatic.Alg.Style.PlanStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowGabarit` | `Boolean` | `get/set` | No | `` |
| `ArcColor` | `CadColor` | `get/set` | No | `` |
| `BordersColor` | `CadColor` | `get/set` | No | `` |
| `ClothColor` | `CadColor` | `get/set` | No | `` |
| `FlippedText` | `Boolean` | `get/set` | No | `` |
| `GripCurveColor` | `CadColor` | `get/set` | No | `` |
| `GripLineColor` | `CadColor` | `get/set` | No | `` |
| `GripStyle` | `AlignmentGripStyle` | `get/set` | No | `` |
| `ShowCurrentCross` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StraightColor` | `CadColor` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `PlanStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PrecisionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.PrecisionStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.PrecisionStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CoordinateDigits` | `Int32` | `get/set` | No | `` |
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `GradeDigits` | `Int32` | `get/set` | No | `` |
| `LengthDigits` | `Int32` | `get/set` | No | `` |
| `RadiusDigits` | `Int32` | `get/set` | No | `` |
| `RoundGrades` | `Boolean` | `get/set` | No | `` |
| `RoundValues` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CoordinateToStr` | `String` | `Double value` | `` |
| `CopyProperties` | `Void` | `PrecisionStyle style` | `` |
| `ElevationToStr` | `String` | `Double value` | `` |
| `GradeToStr` | `String` | `Double value` | `` |
| `LengthToStr` | `String` | `Double value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RadiusToStr` | `String` | `Double value` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfileDisplayStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.ProfileDisplayStyle` |
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
      - `Topomatic.Alg.Style.ProfileDisplayStyle`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DoubleLine` | `ProfileDisplayStyle` | Yes | `DoubleLine` | `` |
| `SingleLine` | `ProfileDisplayStyle` | Yes | `SingleLine` | `` |
| `SingleLineWithBasement` | `ProfileDisplayStyle` | Yes | `SingleLineWithBasement` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SingleLine` | `0` |
| `DoubleLine` | `1` |
| `SingleLineWithBasement` | `2` |

**Underlying Type**: `System.Int32`

### `ProfileStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.ProfileStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.ProfileStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AgProfileLineVisible` | `Boolean` | `get/set` | No | `` |
| `CurrentCrossTextSize` | `Double` | `get/set` | No | `` |
| `DefaultProjectNodeFlag` | `ProjectNodeFlags` | `get/set` | No | `` |
| `ElevationTextSize` | `Double` | `get/set` | No | `` |
| `GripCurveColor` | `CadColor` | `get/set` | No | `` |
| `GripLineColor` | `CadColor` | `get/set` | No | `` |
| `GripStyle` | `AlignmentGripStyle` | `get/set` | No | `` |
| `ProfileCommunicationVisible` | `Boolean` | `get/set` | No | `` |
| `ProfileDisplayStyle` | `ProfileDisplayStyle` | `get/set` | No | `` |
| `ProfileLineVisible` | `Boolean` | `get/set` | No | `` |
| `ShowCurrentCross` | `Boolean` | `get/set` | No | `` |
| `UserProfilesLineVisible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `ProfileStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfileVisibleStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.ProfileVisibleStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.ProfileVisibleStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Images` | `Image[]` | `get` | No | `` |
| `VisibleImage` | `Image` | `get` | No | `` |
| `VisibleImageIndex` | `Int32` | `get/set` | No | `` |
| `VisibleMaxSight` | `Double` | `get/set` | No | `` |
| `VisibleObjectHeight` | `Double` | `get/set` | No | `` |
| `VisibleStep` | `Double` | `get/set` | No | `` |
| `VisibleUserHeight` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `ProfileVisibleStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FIRST` | `Int32` | Yes | `0` | `` |
| `SECOND` | `Int32` | Yes | `1` | `` |
| `THIRD` | `Int32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Regions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.Regions` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.Regions`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Styles` | `List<KeyValuePair<Double Int32>>` | `get` | No | `` |

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

### `RegionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.RegionStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.RegionStyle`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Dismantle` | `Boolean` | `get/set` | No | `` |
| `Linetype` | `LinetypePattern` | `get/set` | No | `` |
| `Lineweight` | `Int32` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

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

### `RegionStyles` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.RegionStyles` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Alg.Style.RegionStyle, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.RegionStyles`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `` | `` |
| `Get` | `RegionStyle` | `Int32 id` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Int32 RegionStyle>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Int32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `StationingStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.StationingStyle` |
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
      - `Topomatic.Alg.Style.StationingStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultShowDecimal` | `Boolean` | `get/set` | No | `` |
| `NotchSizeLeft` | `Single` | `get/set` | No | `` |
| `NotchSizeRight` | `Single` | `get/set` | No | `` |
| `NotchStep` | `Double` | `get/set` | No | `` |
| `RoundStep` | `Boolean` | `get/set` | No | `` |
| `ShowChopPickets` | `Boolean` | `get/set` | No | `` |
| `ShowDecimal` | `Boolean` | `get/set` | No | `` |
| `ShowNotch` | `Boolean` | `get/set` | No | `` |
| `ShowPrefix` | `Boolean` | `get/set` | No | `` |
| `ShowStep` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |
| `StepTextStandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StationingStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `VertexesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Style.VertexesStyle` |
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
      - `Topomatic.Alg.Style.VertexesStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `VertexesStyle style` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.SystemClasses`

### `DesignStatusFemalePropertyTypeConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.SystemClasses.DesignStatusFemalePropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.SystemClasses.DesignStatusFemalePropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DesignStatusMalePropertyTypeConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.SystemClasses.DesignStatusMalePropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.SystemClasses.DesignStatusMalePropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Vcs`

### `AlgConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveConflict` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Find` | `Section` | `SectionList sections, Double station` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MERGE_CONSTRUCTION_ALIACES` | `String` | Yes | `"MERGE_CONSTRUCTION_ALIACES"` | `` |
| `MERGE_PLAN_ALIACES` | `String` | Yes | `"MERGE_PLAN_ALIACES"` | `` |
| `MERGE_SECTIONS` | `String` | Yes | `"MERGE_SECTIONS"` | `` |

#### Nested Types (6)

- `BoundedObject` (class)
- `MergedPlanVertexAlias` (struct)
- `MergedSectionTuple` (struct)
- `ProfileBoundedObject` (class)
- `SectionBoundedObject` (class)
- `WindowBoundedObject` (class)

### `BoundedObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Vector2D pos)`
- `.ctor(BoundingBox2D bounds)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `MergedPlanVertexAlias` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+MergedPlanVertexAlias` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Vcs.AlgConflictResolver+MergedPlanVertexAlias`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Index` | `Int32` | No | `` | `` |
| `UID` | `UInt32` | No | `` | `` |

### `MergedSectionTuple` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+MergedSectionTuple` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Vcs.AlgConflictResolver+MergedSectionTuple`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Local` | `Nullable<UInt32>` | No | `` | `` |
| `Origin` | `Nullable<UInt32>` | No | `` | `` |
| `Remote` | `Nullable<UInt32>` | No | `` | `` |
| `Result` | `UInt32` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `ProfileBoundedObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+ProfileBoundedObject` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject`
    - `Topomatic.Alg.Vcs.AlgConflictResolver+ProfileBoundedObject`

#### Constructors (2)

- `.ctor(BoundingBox2D bounds, Int32 transitionIndex)`
- `.ctor(Vector2D pos, Int32 transitionIndex)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TransitionIndex` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionBoundedObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+SectionBoundedObject` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject`
    - `Topomatic.Alg.Vcs.AlgConflictResolver+SectionBoundedObject`

#### Constructors (4)

- `.ctor(BoundingBox2D bounds, Double station)`
- `.ctor(Vector2D pos, Double station)`
- `.ctor(BoundingBox2D bounds, Double startStation, Double endStation)`
- `.ctor(Vector2D pos, Double startStation, Double endStation)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WindowBoundedObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Vcs.AlgConflictResolver+WindowBoundedObject` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver+BoundedObject`
    - `Topomatic.Alg.Vcs.AlgConflictResolver+WindowBoundedObject`

#### Constructors (2)

- `.ctor(BoundingBox2D bounds, String windowUID)`
- `.ctor(Vector2D pos, String windowUID)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WindowUID` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 157 |
| **Classes** | 83 |
| **Interfaces** | 16 |
| **Enums** | 22 |
| **Structs** | 17 |
| **Abstract Classes** | 11 |
| **Static Classes** | 8 |
| **Total Methods** | 693 |
| **Total Properties** | 538 |
| **Total Fields** | 200 |
| **Total Events** | 10 |
| **Total Constructors** | 132 |
| **Nested Types** | 19 |
| **Extension Methods** | 0 |


