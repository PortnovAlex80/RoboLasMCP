# Topomatic.Alg.Rail

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Rail` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Rail.dll` |

---
## Namespace: `Topomatic.Alg.Rail`

### `BallastDepth` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.BallastDepth` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.BallastDepthSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.BallastDepth`

#### Constructors (1)

- `.ctor(IAlignmentContainer owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `BallastDepthSection` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BallastDepthSection section` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<BallastDepthSection>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BallastDepthSection section` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double elevation` | `` |

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

### `BallastDepthSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.BallastDepthSection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.BallastDepthSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.BallastDepthSection`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object owner, BallastDepthSection value)`
- `.ctor(Object owner, Double station, Double ballastDepth)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `BallastDepth` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `BallastDepthSection other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BallastSoiling` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.BallastSoiling` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.BallastSoilingSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.BallastSoiling`

#### Constructors (1)

- `.ctor(IAlignmentContainer owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `BallastSoilingSection` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BallastSoilingSection section` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<BallastSoilingSection>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BallastSoilingSection section` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double elevation` | `` |

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

### `BallastSoilingSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.BallastSoilingSection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer, System.IEquatable`1[[Topomatic.Alg.Rail.BallastSoilingSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.BallastSoilingSection`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, BallastSoilingSection value)`
- `.ctor(Object parent, Double station, Double ballastSoiling)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `BallastSoiling` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `BallastSoilingSection other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `get_Alignment` |
| `IEquatable`1` | `Equals` |

### `Category` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Category` |
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
      - `Topomatic.Alg.Rail.Category`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Freight` | `Category` | Yes | `Freight` | `` |
| `I` | `Category` | Yes | `I` | `` |
| `II` | `Category` | Yes | `II` | `` |
| `III` | `Category` | Yes | `III` | `` |
| `IV` | `Category` | Yes | `IV` | `` |
| `None` | `Category` | Yes | `None` | `` |
| `Speedway` | `Category` | Yes | `Speedway` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Speedway` | `1` |
| `Freight` | `2` |
| `I` | `3` |
| `II` | `4` |
| `III` | `5` |
| `IV` | `6` |

**Underlying Type**: `System.Int32`

### `ExistingCant` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.ExistingCant` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IList`1[[Topomatic.Alg.Rail.ExistingCantValue, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Rail.ExistingCantValue, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.ExistingCantValue, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.ExistingCant`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ExistingCantValue` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ExistingCantValue item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ExistingCantValue item` | `` |
| `CopyTo` | `Void` | `ExistingCantValue[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ExistingCantValue>` | `` | `` |
| `IndexOf` | `Int32` | `ExistingCantValue item` | `` |
| `Insert` | `Void` | `Int32 index, ExistingCantValue item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ExistingCantValue item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
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

### `ExistingCantValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.ExistingCantValue` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Rail.ExistingCantValue, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.ExistingCantValue`

#### Constructors (2)

- `.ctor(ExistingCantValue value)`
- `.ctor(Double station, Double value)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ExistingCantValue other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, ExistingCantValue defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ExistingCantValue` | `StgNode stgNode, ExistingCantValue defaultValue` | `` |
| `LoadFromStg` | `ExistingCantValue` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `ExistingCantValue prfNode, StgNode stgNode, ExistingCantValue defaultValue` | `` |
| `SaveToStg` | `Void` | `ExistingCantValue prfNode, StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Station` | `Double` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `PermanentWay` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.PermanentWay` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.PermanentWaySection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.PermanentWay`

#### Constructors (1)

- `.ctor(IAlignmentContainer owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `PermanentWaySection` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `PermanentWaySection section` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<PermanentWaySection>` | `` | `` |
| `IndexOf` | `Int32` | `PermanentWaySection value` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `PermanentWaySection section` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetSection` | `Boolean` | `Double station, ref PermanentWaySection section` | `` |
| `TryGetValue` | `Boolean` | `Double station, Boolean useDeepening, ref Double elevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `PermanentWaySection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.PermanentWaySection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.PermanentWaySection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.PermanentWaySection`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object owner, PermanentWaySection value)`
- `.ctor(Object owner, Double station)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `Fastening` | `FasteningParams` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Rail` | `RailParams` | `get` | No | `` |
| `Sleeper` | `SleeperParams` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `PermanentWaySection other` | `` |
| `Height` | `Double` | `Boolean useDeepening` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RailAlignment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailAlignment` |
| **Base Type** | `Topomatic.Alg.Alignment` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IStationingContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Alignment`
        - `Topomatic.Alg.Rail.RailAlignment`

#### Constructors (1)

- `.ctor(INamedTransactable owner)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `Berms` | `BermsCollection` | `get` | No | `` |
| `Category` | `Category` | `get/set` | No | `` |
| `CustomDefaultRadius` | `Double` | `get/set` | No | `` |
| `DrainTable` | `DrainTable` | `get` | No | `` |
| `DynamicProjectSurfaceUseFactor` | `Boolean` | `get/set` | No | `` |
| `DynamicProjectSurfaceUserFactorValue` | `Double` | `get/set` | No | `` |
| `DynamicSurface` | `Boolean` | `get/set` | No | `` |
| `DynamicSurfaceFactor` | `RailDynamicSurfaceFactor` | `get/set` | No | `` |
| `DynamicSurfaceGaps` | `GapsCollection` | `get` | No | `` |
| `ExistingCant` | `ExistingCant` | `get` | No | `` |
| `FakeProfileElevationOnCrossSection` | `Boolean` | `get/set` | No | `` |
| `ProjectBallastDepth` | `BallastDepth` | `get` | No | `` |
| `ReconstructionData` | `ReconstructionData` | `get` | No | `` |
| `TrainSpeeds` | `TrainSpeeds` | `get` | No | `` |
| `TrayLayoutTable` | `TrayLayoutTable` | `get` | No | `` |
| `TrayTable` | `TrayTable` | `get` | No | `` |
| `UseCustomDefaultRadius` | `Boolean` | `get/set` | No | `` |
| `VirageTable` | `VirageTable` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EDGE_PROFILE_DESCRIPTION` | `String` | Yes | `"Профиль по внутренней бровке водоотвода"` | `` |
| `EDGE_PROFILE_NAME` | `String` | Yes | `"По внутренней бровке водоотвода"` | `` |
| `LIB_PREFIX_RAILS` | `String` | Yes | `"rails"` | `` |
| `LIB_PREFIX_SLEEPERS` | `String` | Yes | `"sleepers"` | `` |

### `RailDynamicSurfaceFactor` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailDynamicSurfaceFactor` |
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
      - `Topomatic.Alg.Rail.RailDynamicSurfaceFactor`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Hard` | `RailDynamicSurfaceFactor` | Yes | `Hard` | `` |
| `Light` | `RailDynamicSurfaceFactor` | Yes | `Light` | `` |
| `Medium` | `RailDynamicSurfaceFactor` | Yes | `Medium` | `` |
| `User` | `RailDynamicSurfaceFactor` | Yes | `User` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Light` | `0` |
| `Medium` | `1` |
| `Hard` | `2` |
| `User` | `3` |

**Underlying Type**: `System.Int32`

### `RailExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDefaultRadius` | `Double` | `RailAlignment alignment, Boolean reconstruction` | `Extension` |
| `GetDefaultRadius` | `Double` | `RailAlignment alignment` | `Extension` |
| `Join` | `Void` | `TrainSpeeds speeds, AlignmentJoinType joinType, TrainSpeeds first, TrainSpeeds second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `DrainTable table, AlignmentJoinType joinType, DrainTable first, DrainTable second, Double first_length, Double second_length` | `Extension` |
| `Split` | `Void` | `DrainTable table, Double station, DrainTable before, DrainTable after` | `Extension` |
| `Split` | `Void` | `TrainSpeeds speeds, Double station, TrainSpeeds before, TrainSpeeds after` | `Extension` |

### `RailTransition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailTransition` |
| **Base Type** | `Topomatic.Alg.Prf.Transition` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Prf.ITransitionViolations` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Prf.Transition`
      - `Topomatic.Alg.Rail.RailTransition`

#### Constructors (1)

- `.ctor(RailTransitions transitions)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Violations` | `IEnumerable<TransitionViolation>` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `CopyFrom` | `Void` | `Transition transition, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `EqualsWith` | `Boolean` | `Transition transition, Double station` | `` |
| `EqualsWith` | `Boolean` | `Transition transition, Double startStation, Double endStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Join` | `Void` | `AlignmentJoinType joinType, Transition first, Double firstLength, Transition second, Double secondLength` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Split` | `Void` | `Double station, Transition before, Transition after` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckGeometry` | `Void` | `RailTransitionsRestrictions restrictions, PlanLine plan, ProjectProfile profile, List<TransitionViolation> violations` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITransitionViolations` | `get_Violations` |

### `RailTransitions` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.RailTransitions` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, Topomatic.Alg.Prf.ITransitions, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.RailTransitions`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Transition` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Restrictions` | `RailTransitionsRestrictions` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetNext` | `Int32` | `Int32 index` | `` |
| `GetPrevious` | `Int32` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `Transition item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RefreshViolations` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (18)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TrasitionsCount` | `Int32` | Yes | `17` | `` |
| `trCL` | `Int32` | Yes | `0` | `` |
| `trL1` | `Int32` | Yes | `1` | `` |
| `trL2` | `Int32` | Yes | `3` | `` |
| `trL3` | `Int32` | Yes | `5` | `` |
| `trL4` | `Int32` | Yes | `7` | `` |
| `trL5` | `Int32` | Yes | `9` | `` |
| `trL6` | `Int32` | Yes | `11` | `` |
| `trL7` | `Int32` | Yes | `13` | `` |
| `trL8` | `Int32` | Yes | `15` | `` |
| `trR1` | `Int32` | Yes | `2` | `` |
| `trR2` | `Int32` | Yes | `4` | `` |
| `trR3` | `Int32` | Yes | `6` | `` |
| `trR4` | `Int32` | Yes | `8` | `` |
| `trR5` | `Int32` | Yes | `10` | `` |
| `trR6` | `Int32` | Yes | `12` | `` |
| `trR7` | `Int32` | Yes | `14` | `` |
| `trR8` | `Int32` | Yes | `16` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ITransitions` | `get_Item` |
| `ITransitions` | `Clear` |
| `ITransitions` | `IndexOf` |
| `ITransitions` | `GetPrevious` |
| `ITransitions` | `GetNext` |
| `ITransitions` | `get_Count` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Undo` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Undo` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |

### `ReconstructionData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.ReconstructionData` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.ReconstructionData`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ExistBallastDepth` | `BallastDepth` | `get` | No | `` |
| `ExistBallastSoiling` | `BallastSoiling` | `get` | No | `` |
| `ExistPermanentWay` | `PermanentWay` | `get` | No | `` |
| `MinBallastDepth` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `ProjectPermanentWay` | `PermanentWay` | `get` | No | `` |
| `ShowBallastLine` | `Boolean` | `get/set` | No | `` |
| `ShowRatedRailHeadLine` | `Boolean` | `get/set` | No | `` |
| `SleepersDistribution` | `SleepersDistribution` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetExistBallastLine` | `Boolean` | `ref List<Vector3D> ballastLine` | `` |
| `GetExistRailHeadLine` | `Boolean` | `ref List<Vector3D> existRailHeadLine` | `` |
| `GetRatedRailHeadElevation` | `Double` | `Double station` | `` |
| `GetRatedRailHeadLine` | `Boolean` | `ref List<Vector3D> ratedRailHeadLine` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RuleItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.SleepersDistribution+RuleItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.SleepersDistribution+RuleItem`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `RuleItem` | `StgNode node` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CategoryI` | `Int32` | No | `` | `` |
| `CategoryII` | `Int32` | No | `` | `` |
| `CategoryIII` | `Int32` | No | `` | `` |
| `CategoryIV` | `Int32` | No | `` | `` |
| `Freight` | `Int32` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `SpeedWay` | `Int32` | No | `` | `` |

### `RuleType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.SleepersDistribution+RuleType` |
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
      - `Topomatic.Alg.Rail.SleepersDistribution+RuleType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CPT_53` | `RuleType` | Yes | `CPT_53` | `` |
| `SP_119_13330_2017` | `RuleType` | Yes | `SP_119_13330_2017` | `` |
| `SP_37_13330_2012` | `RuleType` | Yes | `SP_37_13330_2012` | `` |
| `User` | `RuleType` | Yes | `User` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `User` | `0` |
| `CPT_53` | `1` |
| `SP_119_13330_2017` | `2` |
| `SP_37_13330_2012` | `3` |

**Underlying Type**: `System.Int32`

### `SleepersDistribution` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.SleepersDistribution` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.SleepersDistributionSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.SleepersDistribution`

#### Constructors (1)

- `.ctor(IAlignmentContainer owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SleepersDistributionSection` | `get/set` | No | `` |
| `LastRule` | `RuleType` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `UserRule` | `IList<RuleItem>` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SleepersDistributionSection section` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<SleepersDistributionSection>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `SleepersDistributionSection section` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetSection` | `Boolean` | `Double station, ref SleepersDistributionSection section` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Int32 sleepersCount` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateItems` | `IList<RuleItem>` | `RuleType ruleType` | `` |
| `PrepareSleeperCount` | `IList<KeyValuePair<Double Int32>>` | `Alignment alignment, Category category, RuleType ruleType, IList<RuleItem> userRuleValues` | `` |

#### Nested Types (2)

- `RuleItem` (struct)
- `RuleType` (enum)

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

### `SleepersDistributionSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.SleepersDistributionSection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.SleepersDistributionSection, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.SleepersDistributionSection`

#### Constructors (4)

- `.ctor(Object owner)`
- `.ctor(Object parent, SleepersDistributionSection value)`
- `.ctor(Object owner, Double station)`
- `.ctor(Object owner, Double station, Int32 sleepersCount)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SleepersCount` | `Int32` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SleepersDistributionSection other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Alg.Rail.Berm`

### `BaseBerm` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.BaseBerm` |
| **Base Type** | `Topomatic.Alg.LinearObjects.CrsLinearObject` |
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
        - `Topomatic.Alg.Rail.Berm.BaseBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `BermSide` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `ValueItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BermsCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.BermsCollection` |
| **Base Type** | `Topomatic.Alg.LinearObjects.CrsLinearObjects`1[[Topomatic.Alg.Rail.Berm.BaseBerm, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObjects`1[[Topomatic.Alg.Rail.Berm.BaseBerm, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Alg.Rail.Berm.BermsCollection`

#### Constructors (1)

- `.ctor(Alignment owner)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDrainageBerm` | `DrainageBerm` | `String uid` | `` |
| `AddExistingSlopeBerm` | `ExistingSlopeBerm` | `String uid` | `` |
| `AddHeatingBerm` | `HeatingBerm` | `String uid` | `` |
| `AddStreghteningBerm` | `StrengthenBerm` | `String uid` | `` |
| `AddTwoLayerBerm` | `TwoLayerBerm` | `String uid` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BermSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.BermSide` |
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
      - `Topomatic.Alg.Rail.Berm.BermSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `BermSide` | Yes | `Left` | `` |
| `Right` | `BermSide` | Yes | `Right` | `` |
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

### `DrainageBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.DrainageBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`
            - `Topomatic.Alg.Rail.Berm.DrainageBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `DoubleParameter` | `get` | No | `` |

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

### `ExistingSlopeBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.ExistingSlopeBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`
            - `Topomatic.Alg.Rail.Berm.ExistingSlopeBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `DoubleParameter` | `get` | No | `` |

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

### `HeatingBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.HeatingBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`
            - `Topomatic.Alg.Rail.Berm.HeatingBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `DoubleParameter` | `get` | No | `` |

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

### `LinearBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.BaseBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LedgeInclination` | `DoubleParameter` | `get` | No | `` |
| `Length` | `DoubleParameter` | `get` | No | `` |
| `SecondLayerHeight` | `DoubleParameter` | `get` | No | `` |
| `SlopeInclination` | `DoubleParameter` | `get` | No | `` |

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

### `StrengthenBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.StrengthenBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`
            - `Topomatic.Alg.Rail.Berm.StrengthenBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Delta` | `DoubleParameter` | `get` | No | `` |

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

### `TwoLayerBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.TwoLayerBerm` |
| **Base Type** | `Topomatic.Alg.Rail.Berm.LinearBerm` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LinearObjects.CrsLinearObject`
        - `Topomatic.Alg.Rail.Berm.BaseBerm`
          - `Topomatic.Alg.Rail.Berm.LinearBerm`
            - `Topomatic.Alg.Rail.Berm.TwoLayerBerm`

#### Constructors (1)

- `.ctor(Object owner, String uid)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FirstLayerHeight` | `DoubleParameter` | `get` | No | `` |
| `Height` | `DoubleParameter` | `get` | No | `` |

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

### `ValueItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Berm.BaseBerm+ValueItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.Berm.BaseBerm+ValueItem`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Station` | `Double` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Alg.Rail.Drain`

### `Drain` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Drain.Drain` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Rail.Drain.Drain, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Drain.Drain`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object parent, Drain drain)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `BottomIn` | `String` | `get/set` | No | `` |
| `BottomOut` | `String` | `get/set` | No | `` |
| `Construction` | `String` | `get/set` | No | `` |
| `EdgeNode` | `String` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `DrainSide` | `get` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Strengthened` | `Boolean` | `get/set` | No | `` |
| `TransitionIndex` | `Int32` | `get/set` | No | `` |
| `Type` | `DrainType` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Drain other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `StationInside` | `Boolean` | `Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `DrainSide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Drain.DrainSide` |
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
      - `Topomatic.Alg.Rail.Drain.DrainSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `DrainSide` | Yes | `Left` | `` |
| `Right` | `DrainSide` | Yes | `Right` | `` |
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

### `DrainTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Drain.DrainTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Drain.DrainTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Drain` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Drain drain` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IsValid` | `Boolean` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `System.Collections.ICollection.CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `System.Collections.ICollection.get_SyncRoot` |
| `ICollection` | `System.Collections.ICollection.get_IsSynchronized` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList` | `System.Collections.IList.get_Item` |
| `IList` | `System.Collections.IList.set_Item` |
| `IList` | `System.Collections.IList.Add` |
| `IList` | `System.Collections.IList.Contains` |
| `IList` | `Clear` |
| `IList` | `System.Collections.IList.get_IsReadOnly` |
| `IList` | `System.Collections.IList.get_IsFixedSize` |
| `IList` | `System.Collections.IList.IndexOf` |
| `IList` | `System.Collections.IList.Insert` |
| `IList` | `System.Collections.IList.Remove` |
| `IList` | `System.Collections.IList.RemoveAt` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DrainType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Drain.DrainType` |
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
      - `Topomatic.Alg.Rail.Drain.DrainType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ditch` | `DrainType` | Yes | `Ditch` | `` |
| `Drain` | `DrainType` | Yes | `Drain` | `` |
| `Tray` | `DrainType` | Yes | `Tray` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Drain` | `0` |
| `Ditch` | `1` |
| `Tray` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Rail.LibraryTypes`

### `FasteningParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.LibraryTypes.FasteningParams` |
| **Base Type** | `Topomatic.Visualization.TypedObjectField` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`
      - `Topomatic.Visualization.TypedObjectField`
        - `Topomatic.Alg.Rail.LibraryTypes.FasteningParams`

#### Constructors (2)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, TypedObject obj)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `TiePlateBot` | `Double` | `get/set` | No | `` |
| `TiePlateMid` | `Double` | `get/set` | No | `` |
| `TiePlateTop` | `Double` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `TypedObject` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.LibraryTypes.RailParams` |
| **Base Type** | `Topomatic.Visualization.TypedObjectField` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`
      - `Topomatic.Visualization.TypedObjectField`
        - `Topomatic.Alg.Rail.LibraryTypes.RailParams`

#### Constructors (2)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, TypedObject obj)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `DefaultP50` | `TypedObject` | `get` | Yes | `` |
| `DefaultP65` | `TypedObject` | `get` | Yes | `` |
| `Height` | `Double` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SleeperParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.LibraryTypes.SleeperParams` |
| **Base Type** | `Topomatic.Visualization.TypedObjectField` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`
      - `Topomatic.Visualization.TypedObjectField`
        - `Topomatic.Alg.Rail.LibraryTypes.SleeperParams`

#### Constructors (2)

- `.ctor(ITransactable owner)`
- `.ctor(ITransactable owner, TypedObject obj)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caption` | `String` | `get` | No | `` |
| `Depth` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `Material` | `TypedObject` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `TypedObject` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Rail.Restrictions`

### `RailTransitionsRestrictions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Restrictions.RailTransitionsRestrictions` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Restrictions.RailTransitionsRestrictions`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, RailTransitionsRestrictions restirctions)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CheckDeltaGrade` | `Boolean` | `get/set` | No | `` |
| `CheckDsm` | `Boolean` | `get/set` | No | `` |
| `CheckMaxGrade` | `Boolean` | `get/set` | No | `` |
| `CheckMinLength` | `Boolean` | `get/set` | No | `` |
| `CheckPlanProfileCurveCross` | `Boolean` | `get/set` | No | `` |
| `DeltaGradeBottom` | `Double` | `get/set` | No | `` |
| `DeltaGradeTop` | `Double` | `get/set` | No | `` |
| `MaxGradeBackward` | `Double` | `get/set` | No | `` |
| `MaxGradeForward` | `Double` | `get/set` | No | `` |
| `MinLength` | `Double` | `get/set` | No | `` |
| `MinLengthUseRadius` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TrainLength` | `Double` | `get/set` | No | `` |

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

---
## Namespace: `Topomatic.Alg.Rail.Style`

### `CurveShowMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Style.RailProfileStyle+CurveShowMode` |
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
      - `Topomatic.Alg.Rail.Style.RailProfileStyle+CurveShowMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ArcInTop` | `CurveShowMode` | Yes | `ArcInTop` | `` |
| `Default` | `CurveShowMode` | Yes | `Default` | `` |
| `None` | `CurveShowMode` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `ArcInTop` | `1` |
| `None` | `2` |

**Underlying Type**: `System.Int32`

### `DrainageStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Style.DrainageStyle` |
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
      - `Topomatic.Alg.Rail.Style.DrainageStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BreakColor` | `CadColor` | `get/set` | No | `` |
| `CaptionColor` | `CadColor` | `get/set` | No | `` |
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `GradeDigits` | `Int32` | `get/set` | No | `` |
| `LengthDigits` | `Int32` | `get/set` | No | `` |
| `LineColor` | `CadColor` | `get/set` | No | `` |
| `RoundGrades` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandard` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ElevationToStr` | `String` | `Double elevation` | `` |
| `GradeToStr` | `String` | `Double grade` | `` |
| `LengthToStr` | `String` | `Double length` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RailAlignmentStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Style.RailAlignmentStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyle` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Alg.Alignment, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyle`
    - `Topomatic.Alg.Rail.Style.RailAlignmentStyle`

#### Constructors (1)

- `.ctor(RailAlignment owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrainageStyle` | `DrainageStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `RailProfileStyle` | `RailProfileStyle` | `get` | No | `` |

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

### `RailProfileStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Style.RailProfileStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Rail.Style.RailProfileStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurvesShowMode` | `CurveShowMode` | `get/set` | No | `` |
| `DiscreteGripMoveHorizontal` | `Boolean` | `get/set` | No | `` |
| `DiscreteGripMoveHorizontalStep` | `Double` | `get/set` | No | `` |
| `DiscreteGripMoveVertical` | `Boolean` | `get/set` | No | `` |
| `DiscreteGripMoveVerticalGrade` | `Boolean` | `get/set` | No | `` |
| `DiscreteGripMoveVerticalGradeStep` | `Double` | `get/set` | No | `` |
| `DiscreteGripMoveVerticalStep` | `Double` | `get/set` | No | `` |
| `DiscreteGripRoundOxy` | `Boolean` | `get/set` | No | `` |
| `ShowRadius` | `Boolean` | `get/set` | No | `` |
| `ShowZone` | `Boolean` | `get/set` | No | `` |
| `TransitionCurveColor` | `CadColor` | `get/set` | No | `` |
| `VerticalCurveColor` | `CadColor` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `CurveShowMode` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Rail.SystemClasses`

### `DsmCalcer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.SystemClasses.DsmCalcer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PlanLine planLine, Double trainLength)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDsm` | `Double` | `Double sta1, Double sta2` | `` |

---
## Namespace: `Topomatic.Alg.Rail.Trains`

### `TrainSpeed` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Trains.TrainSpeed` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Rail.Trains.TrainSpeed, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.Trains.TrainSpeed`

#### Constructors (2)

- `.ctor(TrainSpeed speed)`
- `.ctor(Double station, Double passenger, Double cargo, Double empty)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `TrainSpeed other` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `TrainSpeed` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, TrainSpeed value` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cargo` | `Double` | No | `` | `` |
| `Empty` | `Double` | No | `` | `` |
| `Passenger` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `TrainSpeeds` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Trains.TrainSpeeds` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Rail.Trains.TrainSpeed, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Rail.Trains.TrainSpeed, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Rail.Trains.TrainSpeed, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Rail.Trains.TrainSpeeds`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `TrainSpeed` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `TrainSpeed item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `TrainSpeed item` | `` |
| `CopyTo` | `Void` | `TrainSpeed[] array, Int32 arrayIndex` | `` |
| `FindCargoSpeed` | `Nullable<Double>` | `Double sta1, Double sta2` | `` |
| `GetEnumerator` | `IEnumerator<TrainSpeed>` | `` | `` |
| `IndexOf` | `Int32` | `TrainSpeed item` | `` |
| `Insert` | `Void` | `Int32 index, TrainSpeed item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `TrainSpeed item` | `` |
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
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Alg.Rail.Tray`

### `Tray` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.Tray` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.Tray.Tray, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Tray.Tray`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object owner, Tray value)`
- `.ctor(Object owner, Double length, Double height)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Tray other` | `` |
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

### `TrayCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.TrayCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Tray.TrayCollection`

#### Constructors (1)

- `.ctor(TrayTable trayTable)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Int32` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Int32 value` | `` |
| `Clear` | `Void` | `` | `` |
| `FindIndex` | `Int32` | `Double sta` | `` |
| `GetIntervals` | `Void` | `List<TrayInterval> intervals` | `` |
| `GetLengthAt` | `Double` | `Int32 index` | `` |
| `GetTrayCount` | `Void` | `Int32[] counts` | `` |
| `Insert` | `Void` | `Int32 index, Int32 value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetTrayHeight` | `Boolean` | `Double sta, ref Double value` | `` |

#### Nested Types (1)

- `TrayInterval` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TrayInterval` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.TrayCollection+TrayInterval` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Rail.Tray.TrayCollection+TrayInterval`

#### Constructors (1)

- `.ctor(Double startSta, Double endSta, Int32 type, Int32 count)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Count` | `Int32` | No | `` | `` |
| `EndSta` | `Double` | No | `` | `` |
| `StartSta` | `Double` | No | `` | `` |
| `Type` | `Int32` | No | `` | `` |

### `TrayLayout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.TrayLayout` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.Tray.TrayLayout, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Tray.TrayLayout`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Int32 transitionIndex, Double startSta, Double endSta, TrayCollection trayCollection)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndSta` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `StartSta` | `Double` | `get/set` | No | `` |
| `TransitionIndex` | `Int32` | `get/set` | No | `` |
| `TrayCollection` | `TrayCollection` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `TrayLayout other` | `` |
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

### `TrayLayoutTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.TrayLayoutTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Tray.TrayLayoutTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `TrayLayout` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `TrayLayout trayLayout` | `` |
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

### `TrayTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Tray.TrayTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Tray.TrayTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Tray` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Tray tray` | `` |
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

---
## Namespace: `Topomatic.Alg.Rail.Vcs`

### `RailConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Vcs.RailConflictResolver` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver`
    - `Topomatic.Alg.Rail.Vcs.RailConflictResolver`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveConflict` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |

---
## Namespace: `Topomatic.Alg.Rail.Virage`

### `Virage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Virage.Virage` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Rail.Virage.Virage, Topomatic.Alg.Rail, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Virage.Virage`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object owner, Virage virage)`
- `.ctor(Object owner, String name, Double startSta, Double endSta, Double l1, Double l2, VirageDirection dir)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BallastOffset` | `Double` | `get/set` | No | `` |
| `Direction` | `VirageDirection` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `L1` | `Double` | `get/set` | No | `` |
| `L2` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Velocity` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Virage other` | `` |
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

### `VirageDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Virage.VirageDirection` |
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
      - `Topomatic.Alg.Rail.Virage.VirageDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `VirageDirection` | Yes | `Left` | `` |
| `Right` | `VirageDirection` | Yes | `Right` | `` |
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

### `VirageTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Virage.VirageTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Rail.Virage.VirageTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Virage` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Add` | `Void` | `Virage virage` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Refresh` | `Void` | `` | `` |
| `Remove` | `Void` | `Virage virage` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IList` | `System.Collections.IList.get_Item` |
| `IList` | `System.Collections.IList.set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 55 |
| **Classes** | 39 |
| **Interfaces** | 0 |
| **Enums** | 8 |
| **Structs** | 5 |
| **Abstract Classes** | 1 |
| **Static Classes** | 2 |
| **Total Methods** | 194 |
| **Total Properties** | 201 |
| **Total Fields** | 78 |
| **Total Events** | 0 |
| **Total Constructors** | 64 |
| **Nested Types** | 5 |
| **Extension Methods** | 0 |


