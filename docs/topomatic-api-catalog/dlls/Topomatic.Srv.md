# Topomatic.Srv

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Srv` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Srv.dll` |

---
## Namespace: ``

### `DirectionAngleType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `DirectionAngleType` |
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
      - `DirectionAngleType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FromBasePointToTargetPoint` | `DirectionAngleType` | Yes | `FromBasePointToTargetPoint` | `` |
| `FromTaregtPointToBasePoint` | `DirectionAngleType` | Yes | `FromTaregtPointToBasePoint` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FromBasePointToTargetPoint` | `0` |
| `FromTaregtPointToBasePoint` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Srv`

### `AngleType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.AngleType` |
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
      - `Topomatic.Srv.AngleType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `AngleType` | Yes | `Left` | `` |
| `Right` | `AngleType` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

### `Basis` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Basis` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.Basis`

#### Constructors (1)

- `.ctor(SurveyItem parent, Point basePoint, DirectionAngleType directionAngleType)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Point` | `get` | No | `Browsable` |
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `ReadOnly, Indent, PropertyTypeConverter, RDisplayName` |
| `DirectionAngleType` | `DirectionAngleType` | `get` | No | `Browsable` |
| `TargetPoint` | `Point` | `get/set` | No | `Browsable` |
| `TargetPointEasting` | `Nullable<Double>` | `get/set` | No | `Browsable` |
| `TargetPointNorthing` | `Nullable<Double>` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Basis source` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DeviceType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.DeviceType` |
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
      - `Topomatic.Srv.DeviceType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Tacheometer` | `DeviceType` | Yes | `Tacheometer` | `` |
| `Theodolite` | `DeviceType` | Yes | `Theodolite` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Tacheometer` | `0` |
| `Theodolite` | `1` |

**Underlying Type**: `System.Int32`

### `DirectionAngleBasis` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.DirectionAngleBasis` |
| **Base Type** | `Topomatic.Srv.Basis` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.Basis`
        - `Topomatic.Srv.DirectionAngleBasis`

#### Constructors (1)

- `.ctor(SurveyItem parent, Point basePoint, DirectionAngleType directionAngleType)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `ReadOnly, RDisplayName, Indent, PropertyTypeConverter, PropertyUpdateSequence` |
| `DirectionAngleRef` | `DirectionAngle` | `get/set` | No | `RDisplayName, Indent, PropertyProvider, PropertyUpdateSequence` |
| `TargetPoint` | `Point` | `get/set` | No | `RDisplayName, PropertyProvider, Indent, ReadOnly` |
| `TargetPointEasting` | `Nullable<Double>` | `get/set` | No | `Browsable` |
| `TargetPointNorthing` | `Nullable<Double>` | `get/set` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Basis source` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `ElevationIdentType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ElevationIdentType` |
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
      - `Topomatic.Srv.ElevationIdentType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Calculated` | `ElevationIdentType` | Yes | `Calculated` | `` |
| `Source` | `ElevationIdentType` | Yes | `Source` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Source` | `0` |
| `Calculated` | `1` |

**Underlying Type**: `System.Int32`

### `ElevationStatus` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ElevationStatus` |
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
      - `Topomatic.Srv.ElevationStatus`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Calculated` | `ElevationStatus` | Yes | `Calculated` | `` |
| `Equated` | `ElevationStatus` | Yes | `Equated` | `` |
| `Polar` | `ElevationStatus` | Yes | `Polar` | `` |
| `Unprocessed` | `ElevationStatus` | Yes | `Unprocessed` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Equated` | `0` |
| `Calculated` | `1` |
| `Polar` | `2` |
| `Unprocessed` | `3` |

**Underlying Type**: `System.Int32`

### `EmptyBasis` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.EmptyBasis` |
| **Base Type** | `Topomatic.Srv.Basis` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.Basis`
        - `Topomatic.Srv.EmptyBasis`

#### Constructors (1)

- `.ctor(SurveyItem parent, Point basePoint, DirectionAngleType directionAngleType)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `Browsable` |
| `TargetPoint` | `Point` | `get/set` | No | `Browsable` |
| `TargetPointEasting` | `Nullable<Double>` | `get/set` | No | `Browsable` |
| `TargetPointNorthing` | `Nullable<Double>` | `get/set` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeightMeasuringPrecisionClass` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.HeightMeasuringPrecisionClass` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.HeightMeasuringPrecisionClass`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `DisplayName` |
| `SectionLengthAllowedDiscrepancy` | `Double` | `get/set` | No | `DisplayName, RCategory` |
| `TrigonometricAllowedDiscrepancy` | `Double` | `get/set` | No | `RCategory, DisplayName` |
| `TripodNumberAllowedDiscrepancy` | `Double` | `get/set` | No | `DisplayName, RCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeightMeasuringPrecisionClasses` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.HeightMeasuringPrecisionClasses` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.HeightMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.HeightMeasuringPrecisionClasses`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `SetDefaults` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `IProcessible` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.IProcessible` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enabled` | `Boolean` | `get/set` | No | `` |

### `ISrvContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ISrvContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Srv` | `Survey` | `get` | No | `` |

### `MeasuringMethod` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.MeasuringMethod` |
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
      - `Topomatic.Srv.MeasuringMethod`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HorizontalDistance_OverElevation` | `MeasuringMethod` | Yes | `HorizontalDistance_OverElevation` | `` |
| `HorizontalDistance_VerticalAngle` | `MeasuringMethod` | Yes | `HorizontalDistance_VerticalAngle` | `` |
| `SlantDistance_OverElevation` | `MeasuringMethod` | Yes | `SlantDistance_OverElevation` | `` |
| `SlantDistance_VerticalAngle` | `MeasuringMethod` | Yes | `SlantDistance_VerticalAngle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SlantDistance_VerticalAngle` | `0` |
| `HorizontalDistance_OverElevation` | `1` |
| `SlantDistance_OverElevation` | `2` |
| `HorizontalDistance_VerticalAngle` | `3` |

**Underlying Type**: `System.Int32`

### `NEIdentType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.NEIdentType` |
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
      - `Topomatic.Srv.NEIdentType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Calculated` | `NEIdentType` | Yes | `Calculated` | `` |
| `Preliminary` | `NEIdentType` | Yes | `Preliminary` | `` |
| `Source` | `NEIdentType` | Yes | `Source` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Source` | `0` |
| `Preliminary` | `1` |
| `Calculated` | `2` |

**Underlying Type**: `System.Int32`

### `NEStatus` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.NEStatus` |
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
      - `Topomatic.Srv.NEStatus`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Calculated` | `NEStatus` | Yes | `Calculated` | `` |
| `Equated` | `NEStatus` | Yes | `Equated` | `` |
| `Polar` | `NEStatus` | Yes | `Polar` | `` |
| `Unprocessed` | `NEStatus` | Yes | `Unprocessed` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Equated` | `0` |
| `Calculated` | `1` |
| `Polar` | `2` |
| `Unprocessed` | `3` |

**Underlying Type**: `System.Int32`

### `PlanMeasuringPrecisionClass` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.PlanMeasuringPrecisionClass` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.PlanMeasuringPrecisionClass`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleMeanSquareError` | `Double` | `get/set` | No | `RDisplayName, RCategory` |
| `DirectionAngleMeanSquareError` | `Double` | `get/set` | No | `RDisplayName, RCategory` |
| `DirectionMeanSquareError` | `Double` | `get/set` | No | `RCategory, RDisplayName` |
| `Name` | `String` | `get/set` | No | `RDisplayName` |
| `PhototachymeterNetVertexMeanSquareError` | `Double` | `get/set` | No | `RCategory, RDisplayName` |
| `PhototachymeterTraverseVertexesMeanSquareError` | `Double` | `get/set` | No | `RCategory, RDisplayName` |
| `TapeNetVertexMeanSquareError` | `Double` | `get/set` | No | `RCategory, RDisplayName` |
| `TapeTraverseVertexesMeanSquareError` | `Double` | `get/set` | No | `RCategory, RDisplayName` |
| `TraverseAngleMeanSquareError` | `Double` | `get/set` | No | `RDisplayName, RCategory` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanMeasuringPrecisionClasses` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.PlanMeasuringPrecisionClasses` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.PlanMeasuringPrecisionClass, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.PlanMeasuringPrecisionClasses`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `SetDefaults` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `Point` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Point` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Point`

#### Constructors (1)

- `.ctor(Points points)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlignmentName` | `String` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get/set` | No | `` |
| `EgProfile` | `Boolean` | `get/set` | No | `` |
| `Elevation` | `Nullable<Double>` | `get/set` | No | `` |
| `ElevationIdentType` | `ElevationIdentType` | `get/set` | No | `` |
| `ElevationStatus` | `ElevationStatus` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `NEIdentType` | `NEIdentType` | `get/set` | No | `` |
| `NEStatus` | `NEStatus` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get/set` | No | `` |
| `Points` | `Points` | `get` | No | `` |
| `RailSide` | `RailSide` | `get/set` | No | `` |
| `StationStr` | `String` | `get/set` | No | `` |
| `SurveyCode` | `String` | `get/set` | No | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Modify` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `PointModifiedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Points+PointModifiedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Srv.Points+PointModifiedEventArgs`

#### Constructors (1)

- `.ctor(Point point)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `point` | `Point` | `get` | No | `` |

### `Points` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Points` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Point, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.Points`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NullValue` | `Point` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadItemByIdFormStg` | `Point` | `StgNode node, String itemNodeName` | `` |
| `SaveItemIdToStg` | `Void` | `StgNode node, Point item, String itemNodeName` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `PointModified` | `EventHandler<PointModifiedEventArgs>` | No | `` |

#### Nested Types (1)

- `PointModifiedEventArgs` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSemantics` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.PointSemantics` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.PointSemantics`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `String` | `get/set` | No | `DefaultWidth, DisplayName` |
| `Point` | `Point` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailSide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.RailSide` |
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
      - `Topomatic.Srv.RailSide`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `RailSide` | Yes | `Left` | `` |
| `Right` | `RailSide` | Yes | `Right` | `` |
| `Undefined` | `RailSide` | Yes | `Undefined` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Undefined` | `0` |
| `Left` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `ReferencePointBasis` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ReferencePointBasis` |
| **Base Type** | `Topomatic.Srv.Basis` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.Basis`
        - `Topomatic.Srv.ReferencePointBasis`

#### Constructors (1)

- `.ctor(SurveyItem parent, Point basePoint, DirectionAngleType directionAngleType)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `ReferencePoint` | `Point` | `get/set` | No | `Browsable` |
| `TargetPoint` | `Point` | `get/set` | No | `PropertyEditor, RDisplayName, Indent, Browsable, PropertyUpdateSequence, PropertyProvider` |
| `TargetPointEasting` | `Nullable<Double>` | `get/set` | No | `PropertyTypeConverter, Browsable, PropertyUpdateSequence, RDisplayName, Indent` |
| `TargetPointNorthing` | `Nullable<Double>` | `get/set` | No | `Browsable, Indent, RDisplayName, PropertyTypeConverter, PropertyUpdateSequence` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Basis source` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `Survey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Survey` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.Survey`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CompilationSurvey` | `CompilationSurvey` | `get` | No | `` |
| `DirectionAngles` | `DirectionAngles` | `get` | No | `` |
| `HeightMeasuringPrecisionClasses` | `HeightMeasuringPrecisionClasses` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `LevelingLines` | `LevelingLines` | `get` | No | `` |
| `MeasurementPoints` | `Points` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PlanMeasuringPrecisionClasses` | `PlanMeasuringPrecisionClasses` | `get` | No | `` |
| `Points` | `Points` | `get` | No | `` |
| `Srv` | `Survey` | `get` | No | `` |
| `SurveyTasks` | `SurveyTasks` | `get` | No | `` |
| `SurveyTraverses` | `SurveyTraverses` | `get` | No | `` |
| `SurveyTraverseSystems` | `SurveyTraverseSystems` | `get` | No | `` |
| `Tacheometry` | `Tacheometry` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Survey source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ISrvContainer` | `get_Srv` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `TraverseSolveMethod` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TraverseSolveMethod` |
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
      - `Topomatic.Srv.TraverseSolveMethod`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Equate` | `TraverseSolveMethod` | Yes | `Equate` | `` |
| `Solve` | `TraverseSolveMethod` | Yes | `Solve` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Solve` | `0` |
| `Equate` | `1` |

**Underlying Type**: `System.Int32`

### `VerticalAngleFormula` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.VerticalAngleFormula` |
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
      - `Topomatic.Srv.VerticalAngleFormula`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LM0_M0R` | `VerticalAngleFormula` | Yes | `LM0_M0R` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LM0_M0R` | `0` |

**Underlying Type**: `System.Int32`

### `VerticalWheelPosition` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.VerticalWheelPosition` |
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
      - `Topomatic.Srv.VerticalWheelPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `VerticalWheelPosition` | Yes | `Left` | `` |
| `Right` | `VerticalWheelPosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Srv.CompilationSurvey`

### `CompilationSurvey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.CompilationSurvey` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.CompilationSurvey.CompilationSurvey`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Stations` | `Stations` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DirectionAngle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.DirectionAngle` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.CompilationSurvey.DirectionAngle`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Azimuth` | `Nullable<Double>` | `get/set` | No | `` |
| `BasePoint` | `Point` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `PlanMeasuringPrecisionClass` | `PlanMeasuringPrecisionClass` | `get/set` | No | `` |
| `TargetPoint` | `Point` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `DirectionAngles` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.DirectionAngles` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.DirectionAngle, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.CompilationSurvey.DirectionAngles`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `NullValue` | `DirectionAngle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `Observation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.Observation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.CompilationSurvey.Observation`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnalyzeResult` | `String` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `MeasuringMethod` | `MeasuringMethod` | `get/set` | No | `` |
| `Measurings` | `ObservationMeasurings` | `get` | No | `` |
| `MeasuringsManagementRule` | `ObservationMeasuringsManagementRule` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `Observations` | `get` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `Station` | `Station` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `ObservationMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.ObservationMeasuring` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.CompilationSurvey.ObservationMeasuring`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnalyzeResult` | `String` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `HeightMeasuringPrecisionClass` | `HeightMeasuringPrecisionClass` | `get/set` | No | `` |
| `HorizontalDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `HorizontalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |
| `Humidity` | `Double` | `get/set` | No | `` |
| `Measurings` | `ObservationMeasurings` | `get` | No | `` |
| `Number` | `Int32` | `get` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `PlanMeasuringPrecisionClass` | `PlanMeasuringPrecisionClass` | `get/set` | No | `` |
| `Pressure` | `Double` | `get/set` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get/set` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `Temperature` | `Double` | `get/set` | No | `` |
| `VerticalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |
| `VerticalWheelPosition` | `VerticalWheelPosition` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `ObservationMeasurings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.ObservationMeasurings` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.CompilationSurvey.ObservationMeasurings`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Observation` | `Observation` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ObservationMeasuringsManagementRule` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRule` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRule`

#### Constructors (1)

- `.ctor(Observation observation)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalDistance` | `Nullable<Double>` | `get` | No | `` |
| `HorizontalLimbValue` | `Nullable<Double>` | `get` | No | `` |
| `Observation` | `Observation` | `get` | No | `Browsable` |
| `OverElevation` | `Nullable<Double>` | `get` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get` | No | `` |
| `VerticalLimbValue` | `Nullable<Double>` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ObservationMeasuringsManagementRuleAverage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRuleAverage` |
| **Base Type** | `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRule` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRule`
        - `Topomatic.Srv.CompilationSurvey.ObservationMeasuringsManagementRuleAverage`

#### Constructors (1)

- `.ctor(Observation observation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalDistance` | `Nullable<Double>` | `get` | No | `` |
| `HorizontalLimbValue` | `Nullable<Double>` | `get` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get` | No | `` |
| `VerticalLimbValue` | `Nullable<Double>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Observations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.Observations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.Observation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.CompilationSurvey.Observations`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Station` | `Station` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `Station` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.Station` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.CompilationSurvey.Station`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnalyzeResult` | `String` | `get/set` | No | `` |
| `Date` | `DateTime` | `get/set` | No | `` |
| `DeviceElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `DeviceType` | `DeviceType` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `Browsable` |
| `Humidity` | `Double` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `Observations` | `get` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `Pressure` | `Double` | `get/set` | No | `` |
| `Stations` | `Stations` | `get` | No | `` |
| `Temperature` | `Double` | `get/set` | No | `` |
| `ZeroAngle` | `Nullable<Double>` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `Stations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.CompilationSurvey.Stations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.CompilationSurvey.Station, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.CompilationSurvey.Stations`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `NullValue` | `Station` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `LoadItemByIdFormStg` | `Station` | `StgNode node, String itemNodeName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Srv.Leveling`

### `LevelingLine` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.LevelingLine` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.LevelingLine`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowedDiscrepancy` | `Int32` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get/set` | No | `` |
| `LevelingType` | `LevelingType` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `SolvedAllowedDiscrepancy` | `Nullable<Int32>` | `get/set` | No | `` |
| `SolvedMeasuringCount` | `Nullable<Int32>` | `get/set` | No | `` |
| `SolvedRmse` | `Nullable<Double>` | `get/set` | No | `` |
| `SolveMethod` | `TraverseSolveMethod` | `get/set` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |
| `StoredAllowedDiscrepancy` | `Int32` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `LevelingLines` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.LevelingLines` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.LevelingLine, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.LevelingLine, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.LevelingLine, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.LevelingLine, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.LevelingLine, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.LevelingLines`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `LevelingType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.LevelingType` |
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
      - `Topomatic.Srv.Leveling.LevelingType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ElNiv` | `LevelingType` | Yes | `ElNiv` | `` |
| `Geometric` | `LevelingType` | Yes | `Geometric` | `` |
| `Trigonometric` | `LevelingType` | Yes | `Trigonometric` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Geometric` | `0` |
| `ElNiv` | `1` |
| `Trigonometric` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Srv.Leveling.ElNiv`

### `ElNivLevelingLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLine` |
| **Base Type** | `Topomatic.Srv.Leveling.LevelingLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.LevelingLine`
          - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLine`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get/set` | No | `` |
| `LevelingType` | `LevelingType` | `get` | No | `` |
| `Sections` | `ElNivLevelingLineSections` | `get` | No | `` |
| `SolvedDiscrepancy` | `Nullable<Int32>` | `get/set` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElNivLevelingLineObservation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Correction` | `Nullable<Double>` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Distance` | `Nullable<Double>` | `get/set` | No | `` |
| `Observations` | `ElNivLevelingLineObservations` | `get` | No | `` |
| `ObservationType` | `ElNivObservationType` | `get/set` | No | `` |
| `Offset` | `Nullable<Double>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `Reading` | `Nullable<Double>` | `get/set` | No | `` |
| `Station` | `ElNivLevelingLineStation` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElNivLevelingLineObservations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineObservations`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Station` | `ElNivLevelingLineStation` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ElNivLevelingLineSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Discrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Sections` | `ElNivLevelingLineSections` | `get` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |
| `Stations` | `ElNivLevelingLineStations` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElNivLevelingLineSections` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSections` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineSections`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `First` | `ElNivLevelingLineSection` | `get` | No | `` |
| `Last` | `ElNivLevelingLineSection` | `get` | No | `` |
| `LevelingLine` | `ElNivLevelingLine` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ElNivLevelingLineStation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardObservation` | `ElNivLevelingLineObservation` | `get` | No | `` |
| `CalculatedElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `ForwardObservation` | `ElNivLevelingLineObservation` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Observations` | `ElNivLevelingLineObservations` | `get` | No | `` |
| `Stations` | `ElNivLevelingLineStations` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElNivLevelingLineStations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.ElNiv.ElNivLevelingLineStations`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `First` | `ElNivLevelingLineStation` | `get` | No | `` |
| `Last` | `ElNivLevelingLineStation` | `get` | No | `` |
| `Section` | `ElNivLevelingLineSection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ElNivObservationType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.ElNiv.ElNivObservationType` |
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
      - `Topomatic.Srv.Leveling.ElNiv.ElNivObservationType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `ElNivObservationType` | Yes | `Backward` | `` |
| `Forward` | `ElNivObservationType` | Yes | `Forward` | `` |
| `Intermediate` | `ElNivObservationType` | Yes | `Intermediate` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `Backward` | `1` |
| `Intermediate` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Srv.Leveling.Geometric`

### `GeometricLevelingLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLine` |
| **Base Type** | `Topomatic.Srv.Leveling.LevelingLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.LevelingLine`
          - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLine`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get/set` | No | `` |
| `LevelingType` | `LevelingType` | `get` | No | `` |
| `Points` | `GeometricLevelingLinePoints` | `get` | No | `` |
| `Sections` | `GeometricLevelingLineSections` | `get` | No | `` |
| `SolvedDiscrepancy` | `Nullable<Int32>` | `get/set` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeometricLevelingLinePoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AverageOverElevation` | `Nullable<Int32>` | `get/set` | No | `` |
| `CalculatedElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Correction` | `Nullable<Int32>` | `get/set` | No | `` |
| `DeviceElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `Points` | `GeometricLevelingLinePoints` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeometricLevelingLinePoints` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoints` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLinePoints`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `LevelingLine` | `LevelingLine` | `get` | No | `` |
| `NullValue` | `GeometricLevelingLinePoint` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `LoadItemByIdFormStg` | `GeometricLevelingLinePoint` | `StgNode node, String itemNodeName` | `` |
| `SaveItemIdToStg` | `Void` | `StgNode node, GeometricLevelingLinePoint item, String itemNodeName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `GeometricLevelingLineSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AvgOverElevation` | `Nullable<Int32>` | `get/set` | No | `` |
| `CorrectedOverelevation` | `Nullable<Int32>` | `get` | No | `` |
| `Correction` | `Nullable<Int32>` | `get/set` | No | `` |
| `Direction` | `LevelingDirection` | `get` | No | `` |
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Sections` | `GeometricLevelingLineSections` | `get` | No | `` |
| `StaffSampleDifference` | `Nullable<Int32>` | `get/set` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |
| `Tries` | `GeometricLevelingLineSectionTries` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeometricLevelingLineSections` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSections` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSection, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSections`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `First` | `GeometricLevelingLineSection` | `get` | No | `` |
| `Last` | `GeometricLevelingLineSection` | `get` | No | `` |
| `LevelingLine` | `GeometricLevelingLine` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `MeasuringsChange` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `GeometricLevelingLineSectionTries` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTries` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTries`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `FinalCalcTry` | `GeometricLevelingLineSectionTry` | `get/set` | No | `` |
| `Section` | `GeometricLevelingLineSection` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `GeometricLevelingLineSectionTry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Geometric.GeometricLevelingLineSectionTry`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Date` | `DateTime` | `get/set` | No | `` |
| `Direction` | `LevelingDirection` | `get/set` | No | `` |
| `DZA` | `Nullable<Int32>` | `get/set` | No | `` |
| `DZB` | `Nullable<Int32>` | `get/set` | No | `` |
| `DZR` | `Nullable<Int32>` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `Measurings` | `PointMeasurings` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `SelectedForFinalCalc` | `Boolean` | `get/set` | No | `` |
| `Tries` | `GeometricLevelingLineSectionTries` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `GeometricLevelingStaffReading` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.GeometricLevelingStaffReading` |
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
| `BlackScaleReading` | `Nullable<Int32>` | `get/set` | No | `DefaultWidth, RDisplayName, PropertyProvider` |
| `RedScaleReading` | `Nullable<Int32>` | `get/set` | No | `PropertyProvider, RDisplayName, DefaultWidth` |

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

### `LevelingDirection` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.LevelingDirection` |
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
      - `Topomatic.Srv.Leveling.Geometric.LevelingDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `LevelingDirection` | Yes | `Backward` | `` |
| `Forward` | `LevelingDirection` | Yes | `Forward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `Backward` | `1` |

**Underlying Type**: `System.Int32`

### `PointMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.PointMeasuring` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Geometric.PointMeasuring`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardStaffReading` | `GeometricLevelingStaffReading` | `get/set` | No | `` |
| `ForwardStaffReading` | `GeometricLevelingStaffReading` | `get/set` | No | `` |
| `IntermediateStaffReading` | `GeometricLevelingStaffReading` | `get/set` | No | `` |
| `LevelingLinePoint` | `GeometricLevelingLinePoint` | `get/set` | No | `` |
| `Measurings` | `PointMeasurings` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointMeasurings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Geometric.PointMeasurings` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.PointMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.Geometric.PointMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.Geometric.PointMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.Geometric.PointMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Geometric.PointMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.Leveling.Geometric.PointMeasurings`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `First` | `PointMeasuring` | `get` | No | `` |
| `Last` | `PointMeasuring` | `get` | No | `` |
| `Try` | `GeometricLevelingLineSectionTry` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

---
## Namespace: `Topomatic.Srv.Leveling.Trigonometric`

### `TrigLevelingLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLine` |
| **Base Type** | `Topomatic.Srv.Leveling.LevelingLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.LevelingLine`
          - `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLine`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndReper` | `Point` | `get` | No | `` |
| `Length` | `Nullable<Double>` | `get/set` | No | `` |
| `LevelingType` | `LevelingType` | `get` | No | `` |
| `OverElevationSum` | `Nullable<Double>` | `get/set` | No | `` |
| `Points` | `TrigLevelingLinePoints` | `get` | No | `` |
| `RepersElevationDiff` | `Nullable<Double>` | `get` | No | `` |
| `SolvedDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `StartReper` | `Point` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrigLevelingLinePoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AverageOverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `BackwardMeasuring` | `TrigLevelingLinePointMeasuring` | `get` | No | `` |
| `ForwardMeasuring` | `TrigLevelingLinePointMeasuring` | `get` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `OverElevationCorrection` | `Nullable<Int32>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `Points` | `TrigLevelingLinePoints` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrigLevelingLinePointMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePointMeasuring` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePointMeasuring`

#### Constructors (1)

- `.ctor(TrigLevelingLinePoint point)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeviceElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `HorizontalDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `MeasuringMethod` | `TrigLevelingMeasuringMethod` | `get/set` | No | `` |
| `Point` | `TrigLevelingLinePoint` | `get` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get/set` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `SubOverElevation1` | `Nullable<Double>` | `get/set` | No | `` |
| `SubOverElevation2` | `Nullable<Double>` | `get/set` | No | `` |
| `VerticalAngle` | `Nullable<Double>` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrigLevelingLinePoints` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoints` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1[[Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingLinePoints`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `LevelingLine` | `LevelingLine` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `TrigLevelingMeasuringMethod` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingMeasuringMethod` |
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
      - `Topomatic.Srv.Leveling.Trigonometric.TrigLevelingMeasuringMethod`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HorizontalDistance_OverElevation` | `TrigLevelingMeasuringMethod` | Yes | `HorizontalDistance_OverElevation` | `` |
| `HorizontalDistance_VerticalAngle` | `TrigLevelingMeasuringMethod` | Yes | `HorizontalDistance_VerticalAngle` | `` |
| `SlantDistance_OverElevation` | `TrigLevelingMeasuringMethod` | Yes | `SlantDistance_OverElevation` | `` |
| `SlantDistance_VerticalAngle` | `TrigLevelingMeasuringMethod` | Yes | `SlantDistance_VerticalAngle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SlantDistance_VerticalAngle` | `0` |
| `HorizontalDistance_VerticalAngle` | `1` |
| `HorizontalDistance_OverElevation` | `2` |
| `SlantDistance_OverElevation` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Srv.ObjectInspectionHelpers`

### `DirectionAngleProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.DirectionAngleProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Srv.ObjectInspectionHelpers.DirectionAngleProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `PropertyType` | `Type` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetValue` | `Void` | `Object value` | `` |

---
## Namespace: `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters`

### `NullableAngleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableAngleConverter` |
| **Base Type** | `Topomatic.ComponentModel.DoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableAngleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleDigits` | `Int32` | `get/set` | Yes | `` |
| `AngleUnit` | `AngleUnits` | `get/set` | Yes | `` |
| `Default` | `NullableAngleConverter` | `get` | Yes | `` |
| `ShowAngleEndZeroFeet` | `Boolean` | `get/set` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |

### `NullableCoordsConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableCoordsConverter` |
| **Base Type** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter`
          - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableCoordsConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `NullableCoordsConverter` | `get` | Yes | `` |

### `NullableDistanceConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDistanceConverter` |
| **Base Type** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter`
          - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDistanceConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `NullableDistanceConverter` | `get` | Yes | `` |

### `NullableDoubleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter` |
| **Base Type** | `Topomatic.ComponentModel.DoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `NullableDoubleConverter` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |

### `NullableElevConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableElevConverter` |
| **Base Type** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableDoubleConverter`
          - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableElevConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `NullableElevConverter` | `get` | Yes | `` |

### `NullableIntConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableIntConverter` |
| **Base Type** | `Topomatic.ComponentModel.IntegerConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.IntegerConverter`
        - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.NullableIntConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `NullableIntConverter` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |

### `RailSidePropertyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.RailSidePropertyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Srv.ObjectInspectionHelpers.PropertyTypeConverters.RailSidePropertyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Srv.SurveyTasks`

### `DirectNotchTask` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.DirectNotchTask` |
| **Base Type** | `Topomatic.Srv.SurveyTasks.SurveyTask` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTasks.SurveyTask`
          - `Topomatic.Srv.SurveyTasks.DirectNotchTask`

#### Constructors (1)

- `.ctor(SurveyTasks surveyTasks)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AB` | `SurveyTaskObservation` | `get` | No | `` |
| `Alfa` | `Nullable<Double>` | `get` | No | `` |
| `AP` | `SurveyTaskObservation` | `get` | No | `` |
| `BA` | `SurveyTaskObservation` | `get` | No | `` |
| `BaseStation1` | `Station` | `get` | No | `` |
| `BaseStation2` | `Station` | `get` | No | `` |
| `Betta` | `Nullable<Double>` | `get` | No | `` |
| `BP` | `SurveyTaskObservation` | `get` | No | `` |
| `DirectNotchType` | `DirectNotchType` | `get/set` | No | `` |
| `Observations1` | `SurveyTaskObservations` | `get` | No | `` |
| `Observations2` | `SurveyTaskObservations` | `get` | No | `` |
| `SolvePoint` | `Point` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DirectNotchType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.DirectNotchType` |
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
      - `Topomatic.Srv.SurveyTasks.DirectNotchType`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Angular` | `DirectNotchType` | Yes | `Angular` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Angular` | `0` |

**Underlying Type**: `System.Int32`

### `HansenTask` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.HansenTask` |
| **Base Type** | `Topomatic.Srv.SurveyTasks.SurveyTask` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTasks.SurveyTask`
          - `Topomatic.Srv.SurveyTasks.HansenTask`

#### Constructors (1)

- `.ctor(SurveyTasks surveyTasks)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint1` | `Point` | `get/set` | No | `` |
| `BasePoint2` | `Point` | `get/set` | No | `` |
| `Betta1` | `Nullable<Double>` | `get` | No | `` |
| `Betta2` | `Nullable<Double>` | `get` | No | `` |
| `Betta3` | `Nullable<Double>` | `get` | No | `` |
| `Betta4` | `Nullable<Double>` | `get` | No | `` |
| `Observations1` | `SurveyTaskObservations` | `get` | No | `` |
| `Observations2` | `SurveyTaskObservations` | `get` | No | `` |
| `PA` | `SurveyTaskObservation` | `get` | No | `` |
| `PB` | `SurveyTaskObservation` | `get` | No | `` |
| `PQ` | `SurveyTaskObservation` | `get` | No | `` |
| `QA` | `SurveyTaskObservation` | `get` | No | `` |
| `QB` | `SurveyTaskObservation` | `get` | No | `` |
| `QP` | `SurveyTaskObservation` | `get` | No | `` |
| `SolveStation1` | `Station` | `get` | No | `` |
| `SolveStation2` | `Station` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ResectionTask` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.ResectionTask` |
| **Base Type** | `Topomatic.Srv.SurveyTasks.SurveyTask` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTasks.SurveyTask`
          - `Topomatic.Srv.SurveyTasks.ResectionTask`

#### Constructors (1)

- `.ctor(SurveyTasks surveyTasks)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Date` | `DateTime` | `get` | No | `` |
| `DeviceElevation` | `Nullable<Double>` | `get` | No | `` |
| `DeviceType` | `DeviceType` | `get` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Humidity` | `Double` | `get` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `SurveyTaskObservations` | `get` | No | `` |
| `Point` | `Point` | `get` | No | `` |
| `Pressure` | `Double` | `get` | No | `` |
| `ResectionType` | `ResectionType` | `get/set` | No | `` |
| `Temperature` | `Double` | `get` | No | `` |
| `ZeroAngle` | `Nullable<Double>` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ResectionType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.ResectionType` |
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
      - `Topomatic.Srv.SurveyTasks.ResectionType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Angular` | `ResectionType` | Yes | `Angular` | `` |
| `Linear` | `ResectionType` | Yes | `Linear` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Angular` | `0` |
| `Linear` | `1` |

**Underlying Type**: `System.Int32`

### `SurveyTask` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.SurveyTask` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTasks.SurveyTask`

#### Constructors (1)

- `.ctor(SurveyTasks surveyTasks)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `SurveyTaskObservation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.SurveyTaskObservation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTasks.SurveyTaskObservation`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `HorizontalDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `HorizontalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |
| `MeasuringMethod` | `MeasuringMethod` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `SurveyTaskObservations` | `get` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get/set` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `SourceObservation` | `Observation` | `get/set` | No | `` |
| `VerticalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `SurveyTaskObservations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.SurveyTaskObservations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTasks.SurveyTaskObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.SurveyTasks.SurveyTaskObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.SurveyTasks.SurveyTaskObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.SurveyTasks.SurveyTaskObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTasks.SurveyTaskObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SurveyTasks.SurveyTaskObservations`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `SourceStation` | `Station` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `SurveyTasks` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTasks.SurveyTasks` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTasks.SurveyTask, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.SurveyTasks.SurveyTask, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.SurveyTasks.SurveyTask, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.SurveyTasks.SurveyTask, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTasks.SurveyTask, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SurveyTasks.SurveyTasks`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

---
## Namespace: `Topomatic.Srv.SurveyTraversing`

### `SurveyTraverse` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraverse` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraverse`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowedAngleDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `AnglesTypes` | `AngleType` | `get/set` | No | `` |
| `Date` | `DateTime` | `get/set` | No | `` |
| `DeviceType` | `DeviceType` | `get/set` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `Browsable` |
| `FiniteBasis` | `Basis` | `get/set` | No | `` |
| `HeightMeasuringPrecisionClass` | `HeightMeasuringPrecisionClass` | `get/set` | No | `` |
| `Humidity` | `Double` | `get/set` | No | `` |
| `InitialBasis` | `Basis` | `get/set` | No | `` |
| `MeasuredDistanceSum` | `Nullable<Double>` | `get/set` | No | `` |
| `MeasuringMethod` | `MeasuringMethod` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `NormativeAngleDiscrepancy` | `Int32` | `get/set` | No | `` |
| `NormativeLinearDiscrepancy` | `Int32` | `get/set` | No | `` |
| `PlanMeasuringPrecisionClass` | `PlanMeasuringPrecisionClass` | `get/set` | No | `` |
| `Pressure` | `Double` | `get/set` | No | `` |
| `SolvedAngleDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedHorizontalAnglesSum` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedLinearDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedXAxisDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedXYRmse` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedYAxisDiscrepancy` | `Nullable<Double>` | `get/set` | No | `` |
| `SolveMethod` | `TraverseSolveMethod` | `get/set` | No | `` |
| `StoredNormativeAngleDiscrepancy` | `Int32` | `get/set` | No | `` |
| `StoredNormativeLinearDiscrepancy` | `Int32` | `get/set` | No | `` |
| `SurveyTraverses` | `SurveyTraverses` | `get` | No | `` |
| `Temperature` | `Double` | `get/set` | No | `` |
| `TraversePoints` | `SurveyTraversePoints` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `SurveyTraversePoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraversePoint` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraversePoint`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Distance` | `Nullable<Double>` | `get/set` | No | `` |
| `HorizontalAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `SolvedDeltaX` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedDeltaY` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedDirectionAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedHorizontalAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedHorizontalAngleDelta` | `Nullable<Double>` | `get/set` | No | `` |
| `SolvedHorizontalDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `TraversePoints` | `SurveyTraversePoints` | `get` | No | `` |
| `VerticalAngle` | `Nullable<Double>` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SurveyTraversePoint source` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SurveyTraversePoints` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraversePoints` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraversePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.SurveyTraversing.SurveyTraversePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraversePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.SurveyTraversing.SurveyTraversePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraversePoint, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraversePoints`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `First` | `SurveyTraversePoint` | `get` | No | `` |
| `Last` | `SurveyTraversePoint` | `get` | No | `` |
| `Traverse` | `SurveyTraverse` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `SurveyTraverses` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraverses` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverse, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverse, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverse, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverse, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverse, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraverses`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `SurveyTraverseSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enabled` | `Boolean` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Traverses` | `SurveyTraverses` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `SurveyTraverseSystems` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SurveyTraversing.SurveyTraverseSystems` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.SurveyTraversing.SurveyTraverseSystem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.SurveyTraversing.SurveyTraverseSystems`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

---
## Namespace: `Topomatic.Srv.SystemClasses`

### `SurveyItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `SurveyItem` | `get/set` | No | `Browsable` |
| `Srv` | `Survey` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ISrvContainer` | `get_Srv` |

### `SurveyItemCollection`1<T where SurveyItem, INamedTransactable, ITransactable, IUpdatable, IOwned`1, IOwned, IStgSerializable, ISrvContainer, class, SurveyItem>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, , , , Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Events (7)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `EventHandler<IndexerEventArgs>` | No | `` |
| `AfterModify` | `EventHandler<IndexerEventArgs>` | No | `` |
| `AfterRemove` | `EventHandler<IndexerEventArgs>` | No | `` |
| `BeforeInsert` | `EventHandler<IndexerEventArgs>` | No | `` |
| `BeforeModify` | `EventHandler<IndexerEventArgs>` | No | `` |
| `BeforeRemove` | `EventHandler<IndexerEventArgs>` | No | `` |
| `Modify` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `System.Collections.ICollection.CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `System.Collections.ICollection.get_SyncRoot` |
| `ICollection` | `System.Collections.ICollection.get_IsSynchronized` |
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
| `IEnumerable`1` | `GetEnumerator` |
| `ISurveyItemCollection` | `add_Modify` |
| `ISurveyItemCollection` | `remove_Modify` |
| `ISurveyItemCollection` | `add_AfterInsert` |
| `ISurveyItemCollection` | `remove_AfterInsert` |
| `ISurveyItemCollection` | `add_BeforeInsert` |
| `ISurveyItemCollection` | `remove_BeforeInsert` |
| `ISurveyItemCollection` | `add_AfterRemove` |
| `ISurveyItemCollection` | `remove_AfterRemove` |
| `ISurveyItemCollection` | `add_BeforeRemove` |
| `ISurveyItemCollection` | `remove_BeforeRemove` |
| `ISurveyItemCollection` | `add_AfterModify` |
| `ISurveyItemCollection` | `remove_AfterModify` |
| `ISurveyItemCollection` | `add_BeforeModify` |
| `ISurveyItemCollection` | `remove_BeforeModify` |
| `IList` | `System.Collections.IList.get_Item` |
| `IList` | `System.Collections.IList.set_Item` |
| `IList` | `System.Collections.IList.Add` |
| `IList` | `System.Collections.IList.Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `System.Collections.IList.get_IsFixedSize` |
| `IList` | `System.Collections.IList.IndexOf` |
| `IList` | `System.Collections.IList.Insert` |
| `IList` | `System.Collections.IList.Remove` |
| `IList` | `RemoveAt` |

### `SurveyItemWithId` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SurveyItemWithId source` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

### `SurveyItemWithIdCollection`1<T where SurveyItemWithId, INamedTransactable, ITransactable, IUpdatable, IOwned`1, IOwned, IStgSerializable, ISrvContainer, IHandledObject, class, SurveyItemWithId>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, , , , Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - ``
        - `Topomatic.Srv.SystemClasses.SurveyItemWithIdCollection`1`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadItemByIdFormStg` | `T` | `StgNode node, String itemNodeName` | `` |
| `SaveItemIdToStg` | `Void` | `StgNode node, T item, String itemNodeName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Srv.TacheometricSurveying`

### `TacheometricObservation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricObservation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.TacheometricSurveying.TacheometricObservation`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionAngle` | `Nullable<Double>` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `HorizontalDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `HorizontalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |
| `MeasuringMethod` | `MeasuringMethod` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `TacheometricObservations` | `get` | No | `` |
| `OverElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Point` | `Point` | `get/set` | No | `` |
| `ReflectorHeight` | `Nullable<Double>` | `get/set` | No | `` |
| `SlantDistance` | `Nullable<Double>` | `get/set` | No | `` |
| `SourceObservation` | `Observation` | `get/set` | No | `` |
| `Station` | `TacheometricStation` | `get` | No | `` |
| `VerticalLimbValue` | `Nullable<Double>` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `TacheometricObservationMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricObservationMeasuring` |
| **Base Type** | `Topomatic.Srv.CompilationSurvey.ObservationMeasuring` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.CompilationSurvey.ObservationMeasuring`
          - `Topomatic.Srv.TacheometricSurveying.TacheometricObservationMeasuring`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TacheometricObservationMeasurings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricObservationMeasurings` |
| **Base Type** | `Topomatic.Srv.CompilationSurvey.ObservationMeasurings` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.CompilationSurvey.ObservationMeasuring, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.CompilationSurvey.ObservationMeasurings`
          - `Topomatic.Srv.TacheometricSurveying.TacheometricObservationMeasurings`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `CreateInstance` |

### `TacheometricObservations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricObservations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.TacheometricSurveying.TacheometricObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.TacheometricSurveying.TacheometricObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricObservation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.TacheometricSurveying.TacheometricObservations`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Station` | `TacheometricStation` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `TacheometricStation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricStation` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Srv.IProcessible` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemWithId`
        - `Topomatic.Srv.TacheometricSurveying.TacheometricStation`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Basis` | `Basis` | `get/set` | No | `` |
| `Date` | `DateTime` | `get/set` | No | `` |
| `DeviceElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `DeviceType` | `DeviceType` | `get/set` | No | `` |
| `Easting` | `Nullable<Double>` | `get` | No | `` |
| `Elevation` | `Nullable<Double>` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `Browsable` |
| `Humidity` | `Double` | `get/set` | No | `` |
| `Northing` | `Nullable<Double>` | `get` | No | `` |
| `Observations` | `TacheometricObservations` | `get` | No | `` |
| `Point` | `Point` | `get` | No | `` |
| `Pressure` | `Double` | `get/set` | No | `` |
| `SourceStation` | `Station` | `get/set` | No | `` |
| `Temperature` | `Double` | `get/set` | No | `` |
| `ZeroAngle` | `Nullable<Double>` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProcessible` | `get_Enabled` |
| `IProcessible` | `set_Enabled` |

### `TacheometricStations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.TacheometricStations` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Srv.TacheometricSurveying.TacheometricStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Srv.TacheometricSurveying.TacheometricStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Srv.SystemClasses.ISurveyItemCollection, System.Collections.IList, Topomatic.ComponentModel.IActivator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.SystemClasses.SurveyItemCollection`1[[Topomatic.Srv.TacheometricSurveying.TacheometricStation, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Srv.TacheometricSurveying.TacheometricStations`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateInstance` | `Object` | `` | `` |
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `IDisposable` | `Dispose` |

### `Tacheometry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.TacheometricSurveying.Tacheometry` |
| **Base Type** | `Topomatic.Srv.SystemClasses.SurveyItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Srv.SystemClasses.SurveyItem, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Srv.ISrvContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Srv.SystemClasses.SurveyItem`
      - `Topomatic.Srv.TacheometricSurveying.Tacheometry`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Stations` | `TacheometricStations` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 99 |
| **Classes** | 74 |
| **Interfaces** | 2 |
| **Enums** | 18 |
| **Structs** | 0 |
| **Abstract Classes** | 5 |
| **Static Classes** | 0 |
| **Total Methods** | 71 |
| **Total Properties** | 436 |
| **Total Fields** | 64 |
| **Total Events** | 10 |
| **Total Constructors** | 23 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


