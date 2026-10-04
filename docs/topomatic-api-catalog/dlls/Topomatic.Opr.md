# Topomatic.Opr

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Opr` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Opr.dll` |

---
## Namespace: `Topomatic.Opr`

### `AlignmentOpr` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AlignmentOpr` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Opr.IAlignmentOprContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Opr.AlignmentOpr`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AccCityRoadsMng` | `OprAccCityRoadsMng` | `get/set` | No | `` |
| `AccCntRoadsII_VMng` | `OprAccCntRoadsII_VMng` | `get/set` | No | `` |
| `AccCntRoadsIMng` | `OprAccCntRoadsIMng` | `get/set` | No | `` |
| `AccCntRoadsMng` | `OprAccCntRoadsMng` | `get/set` | No | `` |
| `CapacityMng` | `OprCapacityMng` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RatedSpeedMng` | `OprRatedSpeedMng` | `get/set` | No | `` |

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
| `IAlignmentOprContainer` | `Topomatic.Opr.IAlignmentOprContainer.get_Opr` |

### `BaseOprTable` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.BaseOprTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `IsEmpty` | `Boolean` | `` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IAlignmentOprContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.IAlignmentOprContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Opr` | `AlignmentOpr` | `get` | No | `` |

### `OprConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.OprConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AccidentInterpolate` | `Double` | `Double x1, Double y1, Double x2, Double y2, Double x` | `` |
| `CapacityInterpolate` | `Double` | `Double x1, Double y1, Double x2, Double y2, Double x` | `` |
| `GetOprContainer` | `IAlignmentOprContainer` | `IOwned item` | `` |
| `SpeedInterpolate` | `Double` | `Double x1, Double y1, Double x2, Double y2, Double x` | `` |

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `cOprCapacityB1` | `Int32` | Yes | `0` | `` |
| `cOprCapacityB10` | `Int32` | Yes | `9` | `` |
| `cOprCapacityB11` | `Int32` | Yes | `10` | `` |
| `cOprCapacityB12` | `Int32` | Yes | `11` | `` |
| `cOprCapacityB13` | `Int32` | Yes | `12` | `` |
| `cOprCapacityB14` | `Int32` | Yes | `13` | `` |
| `cOprCapacityB15` | `Int32` | Yes | `14` | `` |
| `cOprCapacityB2` | `Int32` | Yes | `1` | `` |
| `cOprCapacityB3` | `Int32` | Yes | `2` | `` |
| `cOprCapacityB4` | `Int32` | Yes | `3` | `` |
| `cOprCapacityB5` | `Int32` | Yes | `4` | `` |
| `cOprCapacityB6` | `Int32` | Yes | `5` | `` |
| `cOprCapacityB7` | `Int32` | Yes | `6` | `` |
| `cOprCapacityB8` | `Int32` | Yes | `7` | `` |
| `cOprCapacityB9` | `Int32` | Yes | `8` | `` |
| `OPR_CAPACITY_COUNT` | `Int32` | Yes | `14` | `` |
| `PluginUID` | `String` | Yes | `"Opr"` | `` |

### `OprTable`1<T where IStgSerializable, IOwned, class, IStgSerializable, IOwned>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.OprTable`1` |
| **Base Type** | `Topomatic.Opr.BaseOprTable` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, , , System.Collections.IEnumerable, , Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `Assign` | `Void` | `OprTable<T> source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `IsEmpty` | `Boolean` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SegmentKoeffStruc` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.SegmentKoeffStruc` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.SegmentKoeffStruc`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2, Double value)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Value` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SegmentKoeffStruc other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Sta1` | `Double` | No | `` | `` |
| `m_Sta2` | `Double` | No | `` | `` |
| `m_Value` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Opr.AccCityRoads`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

### `OprAccCityRoadsK1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK11` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK11PositionEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11PositionEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11PositionEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK11PositionEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK11PositionEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK11PositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11PositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11PositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK11Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK11Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `OprAccCityRoadsK11PositionEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK11Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `PositionArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK12` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK12PositionEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12PositionEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12PositionEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK12PositionEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK12PositionEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK12PositionEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK12PositionEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK12PositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12PositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12PositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK12Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK12Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `OprAccCityRoadsK12PositionEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK12Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `PositionArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK13` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK13Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK13Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `PMan` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK13Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK14` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK14FeaturesEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14FeaturesEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14FeaturesEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK14FeaturesEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK14FeaturesEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK14FeaturesEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14FeaturesEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14FeaturesEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK14PositionEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14PositionEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14PositionEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK14PositionEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK14PositionEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK14PositionEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK14PositionEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK14PositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14PositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14PositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK14Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK14Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Features` | `OprAccCityRoadsK14FeaturesEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `OprAccCityRoadsK14PositionEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK14Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FeaturesArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `PositionArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK15` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK15Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK15Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Grade` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK15Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK16` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK16Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK16Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK16Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK17` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK17PositionEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17PositionEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17PositionEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK17PositionEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK17PositionEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK17PositionEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK17PositionEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK17PositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17PositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17PositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK17Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK17Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `OprAccCityRoadsK17PositionEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK17Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `PositionArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK18` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK18FeatureEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18FeatureEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18FeatureEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK18FeatureEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK18FeatureEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK18FeatureEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK18FeatureEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK18FeatureEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18FeatureEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18FeatureEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK18Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK18Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Feature` | `OprAccCityRoadsK18FeatureEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK18Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FeatureArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Quantity` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Speed` | `OprAccCityRoadsK4SpeedEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SpeedArray` | `Double[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK4SpeedEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4SpeedEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4SpeedEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_30` | `OprAccCityRoadsK4SpeedEnum` | Yes | `v_30` | `` |
| `v_40` | `OprAccCityRoadsK4SpeedEnum` | Yes | `v_40` | `` |
| `v_50` | `OprAccCityRoadsK4SpeedEnum` | Yes | `v_50` | `` |
| `v_55` | `OprAccCityRoadsK4SpeedEnum` | Yes | `v_55` | `` |
| `v_60` | `OprAccCityRoadsK4SpeedEnum` | Yes | `v_60` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_30` | `0` |
| `v_40` | `1` |
| `v_50` | `2` |
| `v_55` | `3` |
| `v_60` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK4SpeedEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4SpeedEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK4SpeedEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Strips` | `Int32` | `get/set` | No | `` |
| `Traffic` | `OprAccCityRoadsK5TrafficEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `TrafficArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK5TrafficEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5TrafficEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5TrafficEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK5TrafficEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK5TrafficEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK5TrafficEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5TrafficEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK5TrafficEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK6LightEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6LightEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6LightEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK6LightEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK6LightEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK6LightEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK6LightEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK6LightEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6LightEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6LightEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Light` | `OprAccCityRoadsK6LightEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LightArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsK7CrossTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7CrossTypeEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7CrossTypeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK7CrossTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK7CrossTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCityRoadsK7CrossTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCityRoadsK7CrossTypeEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK7CrossTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7CrossTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7CrossTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK7EquipmentEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7EquipmentEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7EquipmentEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCityRoadsK7EquipmentEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCityRoadsK7EquipmentEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK7EquipmentEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7EquipmentEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7EquipmentEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsK7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossType` | `OprAccCityRoadsK7CrossTypeEnum` | `get/set` | No | `` |
| `Equipment` | `OprAccCityRoadsK7EquipmentEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PAutoSum` | `Double` | `get/set` | No | `` |
| `PMansSum` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `OprAccCityRoadsK7VisibleEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsK7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossTypeArray` | `String[]` | Yes | `` | `` |
| `EquipmentArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleArray` | `Double[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsK7VisibleEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7VisibleEnum` |
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
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7VisibleEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_20` | `OprAccCityRoadsK7VisibleEnum` | Yes | `v_20` | `` |
| `v_30` | `OprAccCityRoadsK7VisibleEnum` | Yes | `v_30` | `` |
| `v_40` | `OprAccCityRoadsK7VisibleEnum` | Yes | `v_40` | `` |
| `v_50` | `OprAccCityRoadsK7VisibleEnum` | Yes | `v_50` | `` |
| `v_60` | `OprAccCityRoadsK7VisibleEnum` | Yes | `v_60` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_20` | `0` |
| `v_30` | `1` |
| `v_40` | `2` |
| `v_50` | `3` |
| `v_60` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCityRoadsK7VisibleEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7VisibleEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsK7VisibleEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCityRoadsKAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCityRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMaxK` | `Double` | `` | `` |
| `GetMinK` | `Double` | `` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCityRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCityRoadsKAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsKAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `Double` | `get/set` | No | `` |
| `K10` | `Double` | `get/set` | No | `` |
| `K11` | `Double` | `get/set` | No | `` |
| `K12` | `Double` | `get/set` | No | `` |
| `K13` | `Double` | `get/set` | No | `` |
| `K14` | `Double` | `get/set` | No | `` |
| `K15` | `Double` | `get/set` | No | `` |
| `K16` | `Double` | `get/set` | No | `` |
| `K17` | `Double` | `get/set` | No | `` |
| `K18` | `Double` | `get/set` | No | `` |
| `K2` | `Double` | `get/set` | No | `` |
| `K3` | `Double` | `get/set` | No | `` |
| `K4` | `Double` | `get/set` | No | `` |
| `K5` | `Double` | `get/set` | No | `` |
| `K6` | `Double` | `get/set` | No | `` |
| `K7` | `Double` | `get/set` | No | `` |
| `K8` | `Double` | `get/set` | No | `` |
| `K9` | `Double` | `get/set` | No | `` |
| `KResult` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsKAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `OprAccCityRoadsK1` | `get/set` | No | `` |
| `K11` | `OprAccCityRoadsK11` | `get/set` | No | `` |
| `K12` | `OprAccCityRoadsK12` | `get/set` | No | `` |
| `K13` | `OprAccCityRoadsK13` | `get/set` | No | `` |
| `K14` | `OprAccCityRoadsK14` | `get/set` | No | `` |
| `K15` | `OprAccCityRoadsK15` | `get/set` | No | `` |
| `K16` | `OprAccCityRoadsK16` | `get/set` | No | `` |
| `K17` | `OprAccCityRoadsK17` | `get/set` | No | `` |
| `K18` | `OprAccCityRoadsK18` | `get/set` | No | `` |
| `K2` | `OprAccCityRoadsK2` | `get/set` | No | `` |
| `K3` | `OprAccCityRoadsK3` | `get/set` | No | `` |
| `K4` | `OprAccCityRoadsK4` | `get/set` | No | `` |
| `K5` | `OprAccCityRoadsK5` | `get/set` | No | `` |
| `K6` | `OprAccCityRoadsK6` | `get/set` | No | `` |
| `K7` | `OprAccCityRoadsK7` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `OprAccCityRoadsKAll` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsMng source` | `` |
| `Calculate` | `Void` | `Boolean checkZones` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSections` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCityRoadsStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCityRoads.OprAccCityRoadsStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.AccCityRoads.OprAccCityRoadsStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCityRoadsStaRec source` | `` |

---
## Namespace: `Topomatic.Opr.AccCntRoads`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

### `OprAccCntRoadsK1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK12` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK12Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `SideCount` | `OprAccCntRoadsK12SideCountEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK12Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SideCountArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK12SideCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12SideCountEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12SideCountEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK12SideCountEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK12SideCountEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK12SideCountEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK12SideCountEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsK12SideCountEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK12SideCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12SideCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK12SideCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK13` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK13LHouseEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13LHouseEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13LHouseEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK13LHouseEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK13LHouseEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK13LHouseEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK13LHouseEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13LHouseEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13LHouseEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK13Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LHouse` | `OprAccCntRoadsK13LHouseEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `TypHouse` | `OprAccCntRoadsK13TypHouseEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK13Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LHouseArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `TypHouseArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK13TypHouseEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13TypHouseEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13TypHouseEnum`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_4` | `` |
| `v_5` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_5` | `` |
| `v_6` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_6` | `` |
| `v_7` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_7` | `` |
| `v_8` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_8` | `` |
| `v_9` | `OprAccCntRoadsK13TypHouseEnum` | Yes | `v_9` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |
| `v_5` | `5` |
| `v_6` | `6` |
| `v_7` | `7` |
| `v_8` | `8` |
| `v_9` | `9` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK13TypHouseEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13TypHouseEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK13TypHouseEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK16` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK16Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `RoadBedType` | `OprAccCntRoadsK16RoadBedTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK16Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadBedTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK16RoadBedTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16RoadBedTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16RoadBedTypeEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK16RoadBedTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK16RoadBedTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK16RoadBedTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK16RoadBedTypeEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsK16RoadBedTypeEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK16RoadBedTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16RoadBedTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK16RoadBedTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK17` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK17Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK17Rec`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DivideSize` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK17Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK18` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK18DeltaEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18DeltaEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18DeltaEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0_5` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_0_5` | `` |
| `v_1_0` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_1_0` | `` |
| `v_1_5` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_1_5` | `` |
| `v_2_0` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_2_0` | `` |
| `v_3_0` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_3_0` | `` |
| `v_5_0` | `OprAccCntRoadsK18DeltaEnum` | Yes | `v_5_0` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0_5` | `0` |
| `v_1_0` | `1` |
| `v_1_5` | `2` |
| `v_2_0` | `3` |
| `v_3_0` | `4` |
| `v_5_0` | `5` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK18DeltaEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18DeltaEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18DeltaEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK18OgrEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18OgrEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18OgrEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK18OgrEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK18OgrEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK18OgrEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18OgrEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18OgrEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK18Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK18Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Delta` | `OprAccCntRoadsK18DeltaEnum` | `get/set` | No | `` |
| `Ogr` | `OprAccCntRoadsK18OgrEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK18Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeltaTypeArray` | `Double[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `OgrArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `RoadType` | `OprAccCntRoadsK1RoadTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK1RoadTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1RoadTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1RoadTypeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK1RoadTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK1RoadTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK1RoadTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK1RoadTypeEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK1RoadTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1RoadTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK1RoadTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `SizeType` | `OprAccCntRoadsK2SizeTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SizeTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK2SizeTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2SizeTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2SizeTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK2SizeTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK2SizeTypeEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK2SizeTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2SizeTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK2SizeTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Uklon` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `Double` | `get/set` | No | `` |
| `VisibleType` | `OprAccCntRoadsK6VisibleTypeEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK6VisibleTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6VisibleTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6VisibleTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK6VisibleTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK6VisibleTypeEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK6VisibleTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6VisibleTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK6VisibleTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `WidthType` | `OprAccCntRoadsK7WidthTypeEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `WidthTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK7WidthTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7WidthTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7WidthTypeEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK7WidthTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK7WidthTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK7WidthTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK7WidthTypeEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsK7WidthTypeEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK7WidthTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7WidthTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK7WidthTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK8` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK8Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK8Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK8Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK9` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsK9CrossTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9CrossTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9CrossTypeEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK9CrossTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK9CrossTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK9CrossTypeEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK9CrossTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9CrossTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9CrossTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK9PMainEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PMainEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PMainEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK9PMainEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK9PMainEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK9PMainEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK9PMainEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK9PMainEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PMainEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PMainEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK9PSecondEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PSecondEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PSecondEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK9PSecondEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK9PSecondEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK9PSecondEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK9PSecondEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PSecondEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9PSecondEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsK9Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossType` | `OprAccCntRoadsK9CrossTypeEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PMain` | `OprAccCntRoadsK9PMainEnum` | `get/set` | No | `` |
| `PSecond` | `OprAccCntRoadsK9PSecondEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `VisibleType` | `OprAccCntRoadsK9VisibleTypeEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsK9Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossTypeArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `PMainTypeArray` | `String[]` | Yes | `` | `` |
| `PSecondTypeArray` | `String[]` | Yes | `` | `` |
| `VisibleTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsK9VisibleTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9VisibleTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9VisibleTypeEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsK9VisibleTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsK9VisibleTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsK9VisibleTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsK9VisibleTypeEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsK9VisibleTypeEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsK9VisibleTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9VisibleTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsK9VisibleTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsKAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoads.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMaxK` | `Double` | `` | `` |
| `GetMinK` | `Double` | `` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsKAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsKAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `Double` | `get/set` | No | `` |
| `K10` | `Double` | `get/set` | No | `` |
| `K11` | `Double` | `get/set` | No | `` |
| `K12` | `Double` | `get/set` | No | `` |
| `K13` | `Double` | `get/set` | No | `` |
| `K14` | `Double` | `get/set` | No | `` |
| `K15` | `Double` | `get/set` | No | `` |
| `K16` | `Double` | `get/set` | No | `` |
| `K17` | `Double` | `get/set` | No | `` |
| `K18` | `Double` | `get/set` | No | `` |
| `K2` | `Double` | `get/set` | No | `` |
| `K3` | `Double` | `get/set` | No | `` |
| `K4` | `Double` | `get/set` | No | `` |
| `K5` | `Double` | `get/set` | No | `` |
| `K6` | `Double` | `get/set` | No | `` |
| `K7` | `Double` | `get/set` | No | `` |
| `K8` | `Double` | `get/set` | No | `` |
| `K9` | `Double` | `get/set` | No | `` |
| `KResult` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsKAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `OprAccCntRoadsK1` | `get/set` | No | `` |
| `K12` | `OprAccCntRoadsK12` | `get/set` | No | `` |
| `K13` | `OprAccCntRoadsK13` | `get/set` | No | `` |
| `K16` | `OprAccCntRoadsK16` | `get/set` | No | `` |
| `K17` | `OprAccCntRoadsK17` | `get/set` | No | `` |
| `K18` | `OprAccCntRoadsK18` | `get/set` | No | `` |
| `K2` | `OprAccCntRoadsK2` | `get/set` | No | `` |
| `K3` | `OprAccCntRoadsK3` | `get/set` | No | `` |
| `K4` | `OprAccCntRoadsK4` | `get/set` | No | `` |
| `K5` | `OprAccCntRoadsK5` | `get/set` | No | `` |
| `K6` | `OprAccCntRoadsK6` | `get/set` | No | `` |
| `K7` | `OprAccCntRoadsK7` | `get/set` | No | `` |
| `K8` | `OprAccCntRoadsK8` | `get/set` | No | `` |
| `K9` | `OprAccCntRoadsK9` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `OprAccCntRoadsKAll` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsMng source` | `` |
| `Calculate` | `Void` | `Boolean checkZones` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSections` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoads.OprAccCntRoadsStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.AccCntRoads.OprAccCntRoadsStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsStaRec source` | `` |

---
## Namespace: `Topomatic.Opr.AccCntRoadsI`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

### `OprAccCntRoadsIK1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK10` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK10BarrierEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10BarrierEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10BarrierEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK10BarrierEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK10BarrierEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK10BarrierEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10BarrierEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10BarrierEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK10DistEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10DistEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10DistEnum`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_4` | `` |
| `v_5` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_5` | `` |
| `v_6` | `OprAccCntRoadsIK10DistEnum` | Yes | `v_6` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |
| `v_5` | `5` |
| `v_6` | `6` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK10DistEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10DistEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10DistEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK10Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK10Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Barrier` | `OprAccCntRoadsIK10BarrierEnum` | `get/set` | No | `` |
| `Dist` | `OprAccCntRoadsIK10DistEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK10Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BarrierArray` | `String[]` | Yes | `` | `` |
| `DistArray` | `Double[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK11` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK11Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Typ` | `OprAccCntRoadsIK11TypEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK11Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `TypArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK11TypEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11TypEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11TypEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK11TypEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK11TypEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK11TypEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsIK11TypEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK11TypEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11TypEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK11TypEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `RoadType` | `OprAccCntRoadsIK1RoadTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK1RoadTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1RoadTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1RoadTypeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK1RoadTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK1RoadTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK1RoadTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsIK1RoadTypeEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK1RoadTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1RoadTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK1RoadTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `SizeType` | `OprAccCntRoadsIK2SizeTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SizeTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK2SizeTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2SizeTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2SizeTypeEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK2SizeTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK2SizeTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK2SizeTypeEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK2SizeTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2SizeTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK2SizeTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Typ` | `OprAccCntRoadsIK3TypEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `TypArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK3TypEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3TypEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3TypEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK3TypEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK3TypEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK3TypEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK3TypEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3TypEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK3TypEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Uklon` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK8` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK8Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Typ` | `OprAccCntRoadsIK8TypEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK8Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `TypArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK8TypEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8TypEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8TypEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK8TypEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK8TypEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK8TypEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsIK8TypEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK8TypEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8TypEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK8TypEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIK9` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIK9Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Typ` | `OprAccCntRoadsIK9TypEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIK9Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `TypArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIK9TypEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9TypEnum` |
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
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9TypEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsIK9TypEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsIK9TypEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsIK9TypEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsIK9TypEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9TypEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIK9TypEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsIKAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsI.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMaxK` | `Double` | `` | `` |
| `GetMinK` | `Double` | `` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsIStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsIKAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIKAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `Double` | `get/set` | No | `` |
| `K10` | `Double` | `get/set` | No | `` |
| `K11` | `Double` | `get/set` | No | `` |
| `K2` | `Double` | `get/set` | No | `` |
| `K3` | `Double` | `get/set` | No | `` |
| `K4` | `Double` | `get/set` | No | `` |
| `K5` | `Double` | `get/set` | No | `` |
| `K6` | `Double` | `get/set` | No | `` |
| `K7` | `Double` | `get/set` | No | `` |
| `K8` | `Double` | `get/set` | No | `` |
| `K9` | `Double` | `get/set` | No | `` |
| `KResult` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIKAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `OprAccCntRoadsIK1` | `get/set` | No | `` |
| `K10` | `OprAccCntRoadsIK10` | `get/set` | No | `` |
| `K11` | `OprAccCntRoadsIK11` | `get/set` | No | `` |
| `K2` | `OprAccCntRoadsIK2` | `get/set` | No | `` |
| `K3` | `OprAccCntRoadsIK3` | `get/set` | No | `` |
| `K4` | `OprAccCntRoadsIK4` | `get/set` | No | `` |
| `K5` | `OprAccCntRoadsIK5` | `get/set` | No | `` |
| `K6` | `OprAccCntRoadsIK6` | `get/set` | No | `` |
| `K7` | `OprAccCntRoadsIK7` | `get/set` | No | `` |
| `K8` | `OprAccCntRoadsIK8` | `get/set` | No | `` |
| `K9` | `OprAccCntRoadsIK9` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `OprAccCntRoadsIKAll` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIMng source` | `` |
| `Calculate` | `Void` | `Boolean checkZones` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSections` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsIStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.AccCntRoadsI.OprAccCntRoadsIStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsIStaRec source` | `` |

---
## Namespace: `Topomatic.Opr.AccCntRoadsII_V`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

### `OprAccCntRoadsII_VK1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK12` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK12Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `SideCount` | `OprAccCntRoadsII_VK12SideCountEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK12Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SideCountArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK12SideCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12SideCountEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12SideCountEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK12SideCountEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK12SideCountEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK12SideCountEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK12SideCountEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK12SideCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12SideCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK12SideCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK13` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK13LHouseEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13LHouseEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13LHouseEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK13LHouseEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK13LHouseEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK13LHouseEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK13LHouseEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13LHouseEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13LHouseEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK13Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LHouse` | `OprAccCntRoadsII_VK13LHouseEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `TypHouse` | `OprAccCntRoadsII_VK13TypHouseEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK13Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LHouseArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `TypHouseArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK13TypHouseEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13TypHouseEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13TypHouseEnum`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_4` | `` |
| `v_5` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_5` | `` |
| `v_6` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_6` | `` |
| `v_7` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_7` | `` |
| `v_8` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_8` | `` |
| `v_9` | `OprAccCntRoadsII_VK13TypHouseEnum` | Yes | `v_9` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |
| `v_5` | `5` |
| `v_6` | `6` |
| `v_7` | `7` |
| `v_8` | `8` |
| `v_9` | `9` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK13TypHouseEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13TypHouseEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK13TypHouseEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK16` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK16Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `RoadBedType` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK16Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadBedTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK16RoadBedTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16RoadBedTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16RoadBedTypeEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsII_VK16RoadBedTypeEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK16RoadBedTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16RoadBedTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK16RoadBedTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK17` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK17DeltaEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17DeltaEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17DeltaEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0_5` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_0_5` | `` |
| `v_1_0` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_1_0` | `` |
| `v_1_5` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_1_5` | `` |
| `v_2_0` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_2_0` | `` |
| `v_3_0` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_3_0` | `` |
| `v_5_0` | `OprAccCntRoadsII_VK17DeltaEnum` | Yes | `v_5_0` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0_5` | `0` |
| `v_1_0` | `1` |
| `v_1_5` | `2` |
| `v_2_0` | `3` |
| `v_3_0` | `4` |
| `v_5_0` | `5` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK17DeltaEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17DeltaEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17DeltaEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK17OgrEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17OgrEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17OgrEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK17OgrEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK17OgrEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK17OgrEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17OgrEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17OgrEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK17Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK17Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Delta` | `OprAccCntRoadsII_VK17DeltaEnum` | `get/set` | No | `` |
| `Ogr` | `OprAccCntRoadsII_VK17OgrEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK17Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeltaTypeArray` | `Double[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `OgrArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `RoadType` | `OprAccCntRoadsII_VK1RoadTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK1RoadTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1RoadTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1RoadTypeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK1RoadTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK1RoadTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK1RoadTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK1RoadTypeEnum` | Yes | `v_3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK1RoadTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1RoadTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK1RoadTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK2DivLineEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2DivLineEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2DivLineEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK2DivLineEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK2DivLineEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK2DivLineEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2DivLineEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2DivLineEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DivLine` | `OprAccCntRoadsII_VK2DivLineEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SizeType` | `OprAccCntRoadsII_VK2SizeTypeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DivLineArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `SizeTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK2SizeTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2SizeTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2SizeTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK2SizeTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK2SizeTypeEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK2SizeTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2SizeTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK2SizeTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Uklon` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `Double` | `get/set` | No | `` |
| `VisibleType` | `OprAccCntRoadsII_VK6VisibleTypeEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK6VisibleTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6VisibleTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6VisibleTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK6VisibleTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK6VisibleTypeEnum` | Yes | `v_1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK6VisibleTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6VisibleTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK6VisibleTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `WidthType` | `OprAccCntRoadsII_VK7WidthTypeEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `WidthTypeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK7WidthTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7WidthTypeEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7WidthTypeEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK7WidthTypeEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK7WidthTypeEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK7WidthTypeEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK7WidthTypeEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsII_VK7WidthTypeEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK7WidthTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7WidthTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK7WidthTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK8` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK8Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK8Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK8Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK9` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VK9PMainEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PMainEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PMainEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK9PMainEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK9PMainEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK9PMainEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK9PMainEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PMainEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PMainEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK9PSecondEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PSecondEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PSecondEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK9PSecondEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK9PSecondEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK9PSecondEnum` | Yes | `v_2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK9PSecondEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PSecondEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9PSecondEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VK9Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `PMain` | `OprAccCntRoadsII_VK9PMainEnum` | `get/set` | No | `` |
| `PSecond` | `OprAccCntRoadsII_VK9PSecondEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `OprAccCntRoadsII_VK9VisibleEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VK9Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `PMainArray` | `String[]` | Yes | `` | `` |
| `PSecondArray` | `String[]` | Yes | `` | `` |
| `VisibleArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VK9VisibleEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9VisibleEnum` |
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
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9VisibleEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprAccCntRoadsII_VK9VisibleEnum` | Yes | `v_0` | `` |
| `v_1` | `OprAccCntRoadsII_VK9VisibleEnum` | Yes | `v_1` | `` |
| `v_2` | `OprAccCntRoadsII_VK9VisibleEnum` | Yes | `v_2` | `` |
| `v_3` | `OprAccCntRoadsII_VK9VisibleEnum` | Yes | `v_3` | `` |
| `v_4` | `OprAccCntRoadsII_VK9VisibleEnum` | Yes | `v_4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_1` | `1` |
| `v_2` | `2` |
| `v_3` | `3` |
| `v_4` | `4` |

**Underlying Type**: `System.Int32`

### `OprAccCntRoadsII_VK9VisibleEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9VisibleEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VK9VisibleEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprAccCntRoadsII_VKAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.AccCntRoadsII_V.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMaxK` | `Double` | `` | `` |
| `GetMinK` | `Double` | `` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprAccCntRoadsII_VStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprAccCntRoadsII_VKAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VKAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `Double` | `get/set` | No | `` |
| `K10` | `Double` | `get/set` | No | `` |
| `K11` | `Double` | `get/set` | No | `` |
| `K12` | `Double` | `get/set` | No | `` |
| `K13` | `Double` | `get/set` | No | `` |
| `K14` | `Double` | `get/set` | No | `` |
| `K15` | `Double` | `get/set` | No | `` |
| `K16` | `Double` | `get/set` | No | `` |
| `K17` | `Double` | `get/set` | No | `` |
| `K2` | `Double` | `get/set` | No | `` |
| `K3` | `Double` | `get/set` | No | `` |
| `K4` | `Double` | `get/set` | No | `` |
| `K5` | `Double` | `get/set` | No | `` |
| `K6` | `Double` | `get/set` | No | `` |
| `K7` | `Double` | `get/set` | No | `` |
| `K8` | `Double` | `get/set` | No | `` |
| `K9` | `Double` | `get/set` | No | `` |
| `KResult` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VKAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `K1` | `OprAccCntRoadsII_VK1` | `get/set` | No | `` |
| `K12` | `OprAccCntRoadsII_VK12` | `get/set` | No | `` |
| `K13` | `OprAccCntRoadsII_VK13` | `get/set` | No | `` |
| `K16` | `OprAccCntRoadsII_VK16` | `get/set` | No | `` |
| `K17` | `OprAccCntRoadsII_VK17` | `get/set` | No | `` |
| `K2` | `OprAccCntRoadsII_VK2` | `get/set` | No | `` |
| `K3` | `OprAccCntRoadsII_VK3` | `get/set` | No | `` |
| `K4` | `OprAccCntRoadsII_VK4` | `get/set` | No | `` |
| `K5` | `OprAccCntRoadsII_VK5` | `get/set` | No | `` |
| `K6` | `OprAccCntRoadsII_VK6` | `get/set` | No | `` |
| `K7` | `OprAccCntRoadsII_VK7` | `get/set` | No | `` |
| `K8` | `OprAccCntRoadsII_VK8` | `get/set` | No | `` |
| `K9` | `OprAccCntRoadsII_VK9` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `OprAccCntRoadsII_VKAll` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VMng source` | `` |
| `Calculate` | `Void` | `Boolean checkZones` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSections` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprAccCntRoadsII_VStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.AccCntRoadsII_V.OprAccCntRoadsII_VStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprAccCntRoadsII_VStaRec source` | `` |

---
## Namespace: `Topomatic.Opr.Capacity`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

### `OprCapacityB1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `PrepareValues` | `Void` | `Double searchSta, Dictionary<String Object> dic` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB10` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB10` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB10Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB10`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB10Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB10Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB10Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `State` | `OprCapacityB10StateEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB10Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `StateArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB10StateEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB10StateEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB10StateEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprCapacityB10StateEnum` | Yes | `V0` | `` |
| `V1` | `OprCapacityB10StateEnum` | Yes | `V1` | `` |
| `V2` | `OprCapacityB10StateEnum` | Yes | `V2` | `` |
| `V3` | `OprCapacityB10StateEnum` | Yes | `V3` | `` |
| `V4` | `OprCapacityB10StateEnum` | Yes | `V4` | `` |
| `V5` | `OprCapacityB10StateEnum` | Yes | `V5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |
| `V5` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB10StateEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB10StateEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB10StateEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB11` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB11` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB11Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB11`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB11Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB11Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB11Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `RoadBed` | `OprCapacityB11RoadBedEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB11Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `RoadBedArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB11RoadBedEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB11RoadBedEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB11RoadBedEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprCapacityB11RoadBedEnum` | Yes | `V0` | `` |
| `V1` | `OprCapacityB11RoadBedEnum` | Yes | `V1` | `` |
| `V2` | `OprCapacityB11RoadBedEnum` | Yes | `V2` | `` |
| `V3` | `OprCapacityB11RoadBedEnum` | Yes | `V3` | `` |
| `V4` | `OprCapacityB11RoadBedEnum` | Yes | `V4` | `` |
| `V5` | `OprCapacityB11RoadBedEnum` | Yes | `V5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |
| `V5` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB11RoadBedEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB11RoadBedEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB11RoadBedEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB12` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB12` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB12Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB12`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB12Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB12Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB12Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Service` | `OprCapacityB12ServiceEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB12Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `ServiceArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB12ServiceEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB12ServiceEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB12ServiceEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprCapacityB12ServiceEnum` | Yes | `V0` | `` |
| `V1` | `OprCapacityB12ServiceEnum` | Yes | `V1` | `` |
| `V2` | `OprCapacityB12ServiceEnum` | Yes | `V2` | `` |
| `V3` | `OprCapacityB12ServiceEnum` | Yes | `V3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |

**Underlying Type**: `System.Int32`

### `OprCapacityB12ServiceEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB12ServiceEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB12ServiceEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB13` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB13` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB13Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB13`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB13MarkingEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB13MarkingEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB13MarkingEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprCapacityB13MarkingEnum` | Yes | `V0` | `` |
| `V1` | `OprCapacityB13MarkingEnum` | Yes | `V1` | `` |
| `V2` | `OprCapacityB13MarkingEnum` | Yes | `V2` | `` |
| `V3` | `OprCapacityB13MarkingEnum` | Yes | `V3` | `` |
| `V4` | `OprCapacityB13MarkingEnum` | Yes | `V4` | `` |
| `V5` | `OprCapacityB13MarkingEnum` | Yes | `V5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |
| `V5` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB13MarkingEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB13MarkingEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB13MarkingEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB13Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB13Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB13Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Marking` | `OprCapacityB13MarkingEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB13Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `MarkingArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB14` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB14` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB14Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB14`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB14PointersEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB14PointersEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB14PointersEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `No` | `OprCapacityB14PointersEnum` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `OprCapacityB14PointersEnum` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Yes` | `0` |
| `No` | `1` |

**Underlying Type**: `System.Int32`

### `OprCapacityB14PointersEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB14PointersEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB14PointersEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB14Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB14Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB14Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Pointers` | `OprCapacityB14PointersEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB14Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `MarkingArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB15` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB15Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB15`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB15AutoCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15AutoCountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB15AutoCountEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_10` | `OprCapacityB15AutoCountEnum` | Yes | `v_10` | `` |
| `v_20` | `OprCapacityB15AutoCountEnum` | Yes | `v_20` | `` |
| `v_30` | `OprCapacityB15AutoCountEnum` | Yes | `v_30` | `` |
| `v_40` | `OprCapacityB15AutoCountEnum` | Yes | `v_40` | `` |
| `v_50` | `OprCapacityB15AutoCountEnum` | Yes | `v_50` | `` |
| `v_70` | `OprCapacityB15AutoCountEnum` | Yes | `v_70` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_70` | `0` |
| `v_50` | `1` |
| `v_40` | `2` |
| `v_30` | `3` |
| `v_20` | `4` |
| `v_10` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB15AutoCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15AutoCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB15AutoCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB15BusCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15BusCountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB15BusCountEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_1` | `OprCapacityB15BusCountEnum` | Yes | `v_1` | `` |
| `v_10` | `OprCapacityB15BusCountEnum` | Yes | `v_10` | `` |
| `v_15` | `OprCapacityB15BusCountEnum` | Yes | `v_15` | `` |
| `v_20` | `OprCapacityB15BusCountEnum` | Yes | `v_20` | `` |
| `v_30` | `OprCapacityB15BusCountEnum` | Yes | `v_30` | `` |
| `v_5` | `OprCapacityB15BusCountEnum` | Yes | `v_5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_1` | `0` |
| `v_5` | `1` |
| `v_10` | `2` |
| `v_15` | `3` |
| `v_20` | `4` |
| `v_30` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB15BusCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15BusCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB15BusCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB15Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB15Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB15Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoCount` | `OprCapacityB15AutoCountEnum` | `get/set` | No | `` |
| `BusCount` | `OprCapacityB15BusCountEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB15Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AutoCountArray` | `Double[]` | Yes | `` | `` |
| `BusCountArray` | `Int32[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB2`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB3DistEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3DistEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB3DistEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0_0` | `OprCapacityB3DistEnum` | Yes | `v_0_0` | `` |
| `v_0_5` | `OprCapacityB3DistEnum` | Yes | `v_0_5` | `` |
| `v_1_0` | `OprCapacityB3DistEnum` | Yes | `v_1_0` | `` |
| `v_1_5` | `OprCapacityB3DistEnum` | Yes | `v_1_5` | `` |
| `v_2_0` | `OprCapacityB3DistEnum` | Yes | `v_2_0` | `` |
| `v_2_5` | `OprCapacityB3DistEnum` | Yes | `v_2_5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_2_5` | `0` |
| `v_2_0` | `1` |
| `v_1_5` | `2` |
| `v_1_0` | `3` |
| `v_0_5` | `4` |
| `v_0_0` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB3DistEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3DistEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB3DistEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dist` | `OprCapacityB3DistEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `OprCapacityB3SideEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DistArray` | `Double[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |
| `SideArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB3SideEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3SideEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB3SideEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BothSides` | `OprCapacityB3SideEnum` | Yes | `BothSides` | `` |
| `OneSide` | `OprCapacityB3SideEnum` | Yes | `OneSide` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `OneSide` | `0` |
| `BothSides` | `1` |

**Underlying Type**: `System.Int32`

### `OprCapacityB3SideEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB3SideEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB3SideEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB4AGCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4AGCountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB4AGCountEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_10` | `OprCapacityB4AGCountEnum` | Yes | `v_10` | `` |
| `v_20` | `OprCapacityB4AGCountEnum` | Yes | `v_20` | `` |
| `v_50` | `OprCapacityB4AGCountEnum` | Yes | `v_50` | `` |
| `v_60` | `OprCapacityB4AGCountEnum` | Yes | `v_60` | `` |
| `v_70` | `OprCapacityB4AGCountEnum` | Yes | `v_70` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_10` | `0` |
| `v_20` | `1` |
| `v_50` | `2` |
| `v_60` | `3` |
| `v_70` | `4` |

**Underlying Type**: `System.Int32`

### `OprCapacityB4AGCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4AGCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB4AGCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB4APCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4APCountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB4APCountEnum`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_1` | `OprCapacityB4APCountEnum` | Yes | `v_1` | `` |
| `v_10` | `OprCapacityB4APCountEnum` | Yes | `v_10` | `` |
| `v_15` | `OprCapacityB4APCountEnum` | Yes | `v_15` | `` |
| `v_20` | `OprCapacityB4APCountEnum` | Yes | `v_20` | `` |
| `v_25` | `OprCapacityB4APCountEnum` | Yes | `v_25` | `` |
| `v_30` | `OprCapacityB4APCountEnum` | Yes | `v_30` | `` |
| `v_5` | `OprCapacityB4APCountEnum` | Yes | `v_5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_1` | `0` |
| `v_5` | `1` |
| `v_10` | `2` |
| `v_15` | `3` |
| `v_20` | `4` |
| `v_25` | `5` |
| `v_30` | `6` |

**Underlying Type**: `System.Int32`

### `OprCapacityB4APCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4APCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB4APCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AGCount` | `OprCapacityB4AGCountEnum` | `get/set` | No | `` |
| `APCount` | `OprCapacityB4APCountEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AGCountArray` | `Double[]` | Yes | `` | `` |
| `APCountArray` | `Int32[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB5APCountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB5APCountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB5APCountEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_10` | `OprCapacityB5APCountEnum` | Yes | `v_10` | `` |
| `v_15` | `OprCapacityB5APCountEnum` | Yes | `v_15` | `` |
| `v_2` | `OprCapacityB5APCountEnum` | Yes | `v_2` | `` |
| `v_5` | `OprCapacityB5APCountEnum` | Yes | `v_5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_2` | `0` |
| `v_5` | `1` |
| `v_10` | `2` |
| `v_15` | `3` |

**Underlying Type**: `System.Int32`

### `OprCapacityB5APCountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB5APCountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB5APCountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `APCount` | `OprCapacityB5APCountEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Uklon` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `APCountArray` | `Int32[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `OprCapacityB6VisibleEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB6VisibleEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB6VisibleEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB6VisibleEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V_100_150` | `OprCapacityB6VisibleEnum` | Yes | `V_100_150` | `` |
| `V_150_250` | `OprCapacityB6VisibleEnum` | Yes | `V_150_250` | `` |
| `V_250_350` | `OprCapacityB6VisibleEnum` | Yes | `V_250_350` | `` |
| `V_50_100` | `OprCapacityB6VisibleEnum` | Yes | `V_50_100` | `` |
| `V_Less50` | `OprCapacityB6VisibleEnum` | Yes | `V_Less50` | `` |
| `V_More350` | `OprCapacityB6VisibleEnum` | Yes | `V_More350` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V_Less50` | `0` |
| `V_50_100` | `1` |
| `V_100_150` | `2` |
| `V_150_250` | `3` |
| `V_250_350` | `4` |
| `V_More350` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB6VisibleEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB6VisibleEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB6VisibleEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB8` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB8` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB8`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB8OgrEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB8OgrEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB8OgrEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V_10` | `OprCapacityB8OgrEnum` | Yes | `V_10` | `` |
| `V_20` | `OprCapacityB8OgrEnum` | Yes | `V_20` | `` |
| `V_30` | `OprCapacityB8OgrEnum` | Yes | `V_30` | `` |
| `V_40` | `OprCapacityB8OgrEnum` | Yes | `V_40` | `` |
| `V_50` | `OprCapacityB8OgrEnum` | Yes | `V_50` | `` |
| `V_60` | `OprCapacityB8OgrEnum` | Yes | `V_60` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V_10` | `0` |
| `V_20` | `1` |
| `V_30` | `2` |
| `V_40` | `3` |
| `V_50` | `4` |
| `V_60` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB8OgrEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB8OgrEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB8OgrEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB8Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB8Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB8Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ogr` | `OprCapacityB8OgrEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB8Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `OgrArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityB9` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityB9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityB9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityB9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityB9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityB9`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `SetSummaryKoeff` | `Void` | `Object rec, Double koeff` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityB9ACountEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9ACountEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB9ACountEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `v_0` | `OprCapacityB9ACountEnum` | Yes | `v_0` | `` |
| `v_20` | `OprCapacityB9ACountEnum` | Yes | `v_20` | `` |
| `v_40` | `OprCapacityB9ACountEnum` | Yes | `v_40` | `` |
| `v_60` | `OprCapacityB9ACountEnum` | Yes | `v_60` | `` |
| `v_80` | `OprCapacityB9ACountEnum` | Yes | `v_80` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `v_0` | `0` |
| `v_20` | `1` |
| `v_40` | `2` |
| `v_60` | `3` |
| `v_80` | `4` |

**Underlying Type**: `System.Int32`

### `OprCapacityB9ACountEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9ACountEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB9ACountEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB9CrossTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9CrossTypeEnum` |
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
      - `Topomatic.Opr.Capacity.OprCapacityB9CrossTypeEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprCapacityB9CrossTypeEnum` | Yes | `V0` | `` |
| `V1` | `OprCapacityB9CrossTypeEnum` | Yes | `V1` | `` |
| `V2` | `OprCapacityB9CrossTypeEnum` | Yes | `V2` | `` |
| `V3` | `OprCapacityB9CrossTypeEnum` | Yes | `V3` | `` |
| `V4` | `OprCapacityB9CrossTypeEnum` | Yes | `V4` | `` |
| `V5` | `OprCapacityB9CrossTypeEnum` | Yes | `V5` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |
| `V5` | `5` |

**Underlying Type**: `System.Int32`

### `OprCapacityB9CrossTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9CrossTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.Capacity.OprCapacityB9CrossTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprCapacityB9Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityB9Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityB9Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ACount` | `OprCapacityB9ACountEnum` | `get/set` | No | `` |
| `CrossType` | `OprCapacityB9CrossTypeEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityB9Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ACountArray` | `Int32[]` | Yes | `` | `` |
| `CrossTypeArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityBAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityBAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityBAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityBAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityBAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityBAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityBAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityBAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMaxPsp` | `Double` | `` | `` |
| `GetMinPsp` | `Double` | `` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityBAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityBAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityBAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `B1` | `Double` | `get/set` | No | `` |
| `B10` | `Double` | `get/set` | No | `` |
| `B11` | `Double` | `get/set` | No | `` |
| `B12` | `Double` | `get/set` | No | `` |
| `B13` | `Double` | `get/set` | No | `` |
| `B14` | `Double` | `get/set` | No | `` |
| `B15` | `Double` | `get/set` | No | `` |
| `B2` | `Double` | `get/set` | No | `` |
| `B3` | `Double` | `get/set` | No | `` |
| `B4` | `Double` | `get/set` | No | `` |
| `B5` | `Double` | `get/set` | No | `` |
| `B6` | `Double` | `get/set` | No | `` |
| `B7` | `Double` | `get/set` | No | `` |
| `B8` | `Double` | `get/set` | No | `` |
| `B9` | `Double` | `get/set` | No | `` |
| `BResult` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Psp` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Zagr` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityBAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityIntens` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityIntens` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityIntensRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityIntensRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityIntensRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityIntensRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityIntensRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityIntens`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityIntensRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityIntensRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityIntensRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Intens` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityIntensRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `B1` | `OprCapacityB1` | `get/set` | No | `` |
| `B10` | `OprCapacityB10` | `get/set` | No | `` |
| `B11` | `OprCapacityB11` | `get/set` | No | `` |
| `B12` | `OprCapacityB12` | `get/set` | No | `` |
| `B13` | `OprCapacityB13` | `get/set` | No | `` |
| `B14` | `OprCapacityB14` | `get/set` | No | `` |
| `B15` | `OprCapacityB15` | `get/set` | No | `` |
| `B2` | `OprCapacityB2` | `get/set` | No | `` |
| `B3` | `OprCapacityB3` | `get/set` | No | `` |
| `B4` | `OprCapacityB4` | `get/set` | No | `` |
| `B5` | `OprCapacityB5` | `get/set` | No | `` |
| `B6` | `OprCapacityB6` | `get/set` | No | `` |
| `B7` | `OprCapacityB7` | `get/set` | No | `` |
| `B8` | `OprCapacityB8` | `get/set` | No | `` |
| `B9` | `OprCapacityB9` | `get/set` | No | `` |
| `Intens` | `OprCapacityIntens` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PspMax` | `OprCapacityPspMax` | `get/set` | No | `` |
| `Result` | `OprCapacityBAll` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityMng source` | `` |
| `Calculate` | `Void` | `` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSections` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityPspMax` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityPspMax` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityPspMaxRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.Capacity.OprCapacityPspMaxRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.Capacity.OprCapacityPspMaxRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.Capacity.OprCapacityPspMaxRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.Capacity.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.Capacity.OprCapacityPspMaxRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.Capacity.OprCapacityPspMax`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprCapacityStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |

### `OprCapacityPspMaxRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityPspMaxRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.Capacity.OprCapacityPspMaxRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `PspMax` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityPspMaxRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprCapacityStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.Capacity.OprCapacityStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.Capacity.OprCapacityStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprCapacityStaRec source` | `` |

---
## Namespace: `Topomatic.Opr.RatedSpeed`

### `ISegBordersByIndexContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

### `OprRatedSpeedAuto` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAuto` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAuto`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |
| `SortType` | `OprRatedSpeedAutoSortTypeEnum` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedAuto auto` | `` |
| `GetGear` | `Int32` | `Double curSpeed` | `` |
| `GetThrottle` | `Double` | `Double g` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Int32` | `Int32 gear, Double throttle, ref Double a, ref Double b, ref Double mu, ref Double teta` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `OprRatedSpeedAutoCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAuto, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAuto, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedAuto, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `OprRatedSpeedAuto` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `OprRatedSpeedAuto item` | `` |
| `Assign` | `Void` | `OprRatedSpeedAutoCollection source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `OprRatedSpeedAuto item` | `` |
| `CopyTo` | `Void` | `OprRatedSpeedAuto[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<OprRatedSpeedAuto>` | `` | `` |
| `IndexOf` | `Int32` | `OprRatedSpeedAuto item` | `` |
| `Insert` | `Void` | `Int32 index, OprRatedSpeedAuto item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `OprRatedSpeedAuto item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Int32` | `String name` | `` |

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedAutoGearEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoGearEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoGearEnum`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V_1` | `OprRatedSpeedAutoGearEnum` | Yes | `V_1` | `` |
| `V_2` | `OprRatedSpeedAutoGearEnum` | Yes | `V_2` | `` |
| `V_3` | `OprRatedSpeedAutoGearEnum` | Yes | `V_3` | `` |
| `V_4` | `OprRatedSpeedAutoGearEnum` | Yes | `V_4` | `` |
| `V_5` | `OprRatedSpeedAutoGearEnum` | Yes | `V_5` | `` |
| `V_6` | `OprRatedSpeedAutoGearEnum` | Yes | `V_6` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V_1` | `0` |
| `V_2` | `1` |
| `V_3` | `2` |
| `V_4` | `3` |
| `V_5` | `4` |
| `V_6` | `5` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedAutoGearEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoGearEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoGearEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedAutoRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get/set` | No | `` |
| `B` | `Double` | `get/set` | No | `` |
| `Gear` | `OprRatedSpeedAutoGearEnum` | `get/set` | No | `` |
| `Mu` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Speed` | `Double` | `get/set` | No | `` |
| `Teta` | `Double` | `get/set` | No | `` |
| `Throttle` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedAutoRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedAutoSortTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoSortTypeEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoSortTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByGear` | `OprRatedSpeedAutoSortTypeEnum` | Yes | `ByGear` | `` |
| `ByThrottle` | `OprRatedSpeedAutoSortTypeEnum` | Yes | `ByThrottle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ByGear` | `0` |
| `ByThrottle` | `1` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedAutoSortTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoSortTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedAutoSortTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedGraphSpeed` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeed` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeed`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `GetMaxY` | `Double` | `` | `` |
| `GetMinY` | `Double` | `` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedGraphSpeedRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedGraphSpeedRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Vkb` | `Double` | `get/set` | No | `` |
| `Vkf` | `Double` | `get/set` | No | `` |
| `Vnb` | `Double` | `get/set` | No | `` |
| `Vnf` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedGraphSpeedRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK1` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK1Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `OprRatedSpeedK1VisibleEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK1Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK1VisibleEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1VisibleEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1VisibleEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK1VisibleEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK1VisibleEnum` | Yes | `V1` | `` |
| `V2` | `OprRatedSpeedK1VisibleEnum` | Yes | `V2` | `` |
| `V3` | `OprRatedSpeedK1VisibleEnum` | Yes | `V3` | `` |
| `V4` | `OprRatedSpeedK1VisibleEnum` | Yes | `V4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK1VisibleEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1VisibleEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK1VisibleEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK2Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Visible` | `OprRatedSpeedK2VisibleEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK2Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `VisibleArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK2VisibleEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2VisibleEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2VisibleEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK2VisibleEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK2VisibleEnum` | Yes | `V1` | `` |
| `V2` | `OprRatedSpeedK2VisibleEnum` | Yes | `V2` | `` |
| `V3` | `OprRatedSpeedK2VisibleEnum` | Yes | `V3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK2VisibleEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2VisibleEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK2VisibleEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK3` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK3` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK3`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK3Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK3Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Beta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK3Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK4` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK4Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `OprRatedSpeedK4WidthEnum` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK4Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `WidthArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK4WidthEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4WidthEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4WidthEnum`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK4WidthEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK4WidthEnum` | Yes | `V1` | `` |
| `V2` | `OprRatedSpeedK4WidthEnum` | Yes | `V2` | `` |
| `V3` | `OprRatedSpeedK4WidthEnum` | Yes | `V3` | `` |
| `V4` | `OprRatedSpeedK4WidthEnum` | Yes | `V4` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |
| `V4` | `4` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK4WidthEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4WidthEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK4WidthEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK5` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK5CrossTypeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5CrossTypeEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5CrossTypeEnum`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK5CrossTypeEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK5CrossTypeEnum` | Yes | `V1` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK5CrossTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5CrossTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5CrossTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK5Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK5Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossType` | `OprRatedSpeedK5CrossTypeEnum` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK5Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossTypeArray` | `String[]` | Yes | `` | `` |
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK6` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK6` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK6`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK6Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK6Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK6Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK7` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK7Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Size` | `OprRatedSpeedK7SizeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK7Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SizeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK7SizeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7SizeEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7SizeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK7SizeEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK7SizeEnum` | Yes | `V1` | `` |
| `V2` | `OprRatedSpeedK7SizeEnum` | Yes | `V2` | `` |
| `V3` | `OprRatedSpeedK7SizeEnum` | Yes | `V3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK7SizeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7SizeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK7SizeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK8` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetKoeff` | `Boolean` | `Double searchSta, Dictionary<String Object> dic, ref Double koeff` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK8Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Size` | `OprRatedSpeedK8SizeEnum` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK8Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |
| `SizeArray` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedK8SizeEnum` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8SizeEnum` |
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
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8SizeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `V0` | `OprRatedSpeedK8SizeEnum` | Yes | `V0` | `` |
| `V1` | `OprRatedSpeedK8SizeEnum` | Yes | `V1` | `` |
| `V2` | `OprRatedSpeedK8SizeEnum` | Yes | `V2` | `` |
| `V3` | `OprRatedSpeedK8SizeEnum` | Yes | `V3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `V0` | `0` |
| `V1` | `1` |
| `V2` | `2` |
| `V3` | `3` |

**Underlying Type**: `System.Int32`

### `OprRatedSpeedK8SizeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8SizeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK8SizeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `OprRatedSpeedK9` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK9` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK9`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedK9Rec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedK9Rec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Speed` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedK9Rec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedKAll` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedKAll` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedKAll`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedKAllRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedKAllRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `SpeedBwd` | `Double` | `get/set` | No | `` |
| `SpeedFwd` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedKAllRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedKResult` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedKResult` |
| **Base Type** | `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Opr.RatedSpeed.ISegBordersByIndexContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.BaseOprTable`
      - `Topomatic.Opr.OprTable`1[[Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec, Topomatic.Opr, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Opr.RatedSpeed.OprRatedSpeedKResult`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStations` | `Void` | `IList<Double> list` | `` |
| `GetMaxY` | `Double` | `` | `` |
| `GetMinY` | `Double` | `` | `` |
| `Search` | `Int32` | `Double sta` | `` |
| `TryGetSegmentBorders` | `Boolean` | `Int32 index, ref OprRatedSpeedStaRec rec` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegBordersByIndexContainer` | `TryGetSegmentBorders` |
| `ISegBordersByIndexContainer` | `Search` |

### `OprRatedSpeedKResultRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedKResultRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `Double` | `get/set` | No | `` |
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedKResultRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Owner` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedMng` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedMng` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedMng`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoCollection` | `OprRatedSpeedAutoCollection` | `get/set` | No | `` |
| `CorrectSpeed` | `OprRatedSpeedGraphSpeed` | `get/set` | No | `` |
| `K1` | `OprRatedSpeedK1` | `get/set` | No | `` |
| `K2` | `OprRatedSpeedK2` | `get/set` | No | `` |
| `K3` | `OprRatedSpeedK3` | `get/set` | No | `` |
| `K4` | `OprRatedSpeedK4` | `get/set` | No | `` |
| `K5` | `OprRatedSpeedK5` | `get/set` | No | `` |
| `K6` | `OprRatedSpeedK6` | `get/set` | No | `` |
| `K7` | `OprRatedSpeedK7` | `get/set` | No | `` |
| `K8` | `OprRatedSpeedK8` | `get/set` | No | `` |
| `K9` | `OprRatedSpeedK9` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Result` | `OprRatedSpeedKAll` | `get/set` | No | `` |
| `Safety` | `OprRatedSpeedKResult` | `get/set` | No | `` |
| `Speed` | `OprRatedSpeedGraphSpeed` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedMng source` | `` |
| `Calculate` | `Void` | `Alignment alg, Double f, Double fwdSpeed, Double bwdSpeed, Double throttle, Double curveStep, Int32 currentAutoCollectionItem` | `` |
| `GetKoeffsTables` | `IEnumerable<BaseOprTable>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeSection` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OprRatedSpeedStaRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Opr.RatedSpeed.OprRatedSpeedStaRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Opr.RatedSpeed.OprRatedSpeedStaRec`

#### Constructors (1)

- `.ctor(Double sta1, Double sta2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sta1` | `Double` | `get/set` | No | `` |
| `Sta2` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OprRatedSpeedStaRec source` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 345 |
| **Classes** | 257 |
| **Interfaces** | 7 |
| **Enums** | 72 |
| **Structs** | 7 |
| **Abstract Classes** | 1 |
| **Static Classes** | 1 |
| **Total Methods** | 811 |
| **Total Properties** | 698 |
| **Total Fields** | 551 |
| **Total Events** | 0 |
| **Total Constructors** | 264 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


