# Topomatic.Alg.LandAllotment

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.LandAllotment` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.LandAllotment.dll` |

---
## Namespace: `Topomatic.Alg.LandAllotment`

### `CrsBoundsLandAllotmentLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.CrsBoundsLandAllotmentLine` |
| **Base Type** | `Topomatic.Alg.LandAllotment.LandAllotmentLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotmentLine`
        - `Topomatic.Alg.LandAllotment.CrsBoundsLandAllotmentLine`

#### Constructors (1)

- `.ctor(Object parent, LandAllotmentLineSide side, LandAllotmentLinesStyle style)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |

### `DesignLandAllotmentLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.DesignLandAllotmentLine` |
| **Base Type** | `Topomatic.Alg.LandAllotment.LandAllotmentLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotmentLine`
        - `Topomatic.Alg.LandAllotment.DesignLandAllotmentLine`

#### Constructors (1)

- `.ctor(Object parent, LandAllotmentLineSide side, LandAllotmentLinesStyle style)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `LandAllotmentLineType` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `eItemTransition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey+eItemTransition` |
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
      - `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey+eItemTransition`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DesignLeft` | `eItemTransition` | Yes | `DesignLeft` | `` |
| `DesignRight` | `eItemTransition` | Yes | `DesignRight` | `` |
| `ExistentLeft` | `eItemTransition` | Yes | `ExistentLeft` | `` |
| `ExistentRight` | `eItemTransition` | Yes | `ExistentRight` | `` |
| `TempLeft` | `eItemTransition` | Yes | `TempLeft` | `` |
| `TempRight` | `eItemTransition` | Yes | `TempRight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DesignLeft` | `0` |
| `DesignRight` | `1` |
| `ExistentLeft` | `2` |
| `ExistentRight` | `3` |
| `TempLeft` | `4` |
| `TempRight` | `5` |

**Underlying Type**: `System.Int32`

### `eItemType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey+eItemType` |
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
      - `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey+eItemType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Coordinates` | `eItemType` | Yes | `Coordinates` | `` |
| `Marker` | `eItemType` | Yes | `Marker` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Marker` | `0` |
| `Coordinates` | `1` |

**Underlying Type**: `System.Int32`

### `ExistentLandAllotmentLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.ExistentLandAllotmentLine` |
| **Base Type** | `Topomatic.Alg.LandAllotment.LandAllotmentLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotmentLine`
        - `Topomatic.Alg.LandAllotment.ExistentLandAllotmentLine`

#### Constructors (1)

- `.ctor(Object parent, LandAllotmentLineSide side, LandAllotmentLinesStyle style)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `LandAllotmentLineType` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ILandAllotmentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.ILandAllotmentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LandAllotment` | `LandAllotment` | `get` | No | `` |

### `LandAllotment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotment` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.IDisposable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.LandAllotment.ILandAllotmentContainer, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentLine, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotment`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `LeftDesignCrsLine` | `LandAllotmentLine` | `get` | No | `` |
| `LeftDesignLine` | `DesignLandAllotmentLine` | `get` | No | `` |
| `LeftExistentLine` | `ExistentLandAllotmentLine` | `get` | No | `` |
| `LeftTempLine` | `TempLandAllotmentLine` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RightDesignCrsLine` | `LandAllotmentLine` | `get` | No | `` |
| `RightDesignLine` | `DesignLandAllotmentLine` | `get` | No | `` |
| `RightExistentLine` | `ExistentLandAllotmentLine` | `get` | No | `` |
| `RightTempLine` | `TempLandAllotmentLine` | `get` | No | `` |
| `Style` | `LandAllotmentStyle` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<LandAllotmentLine>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `ILandAllotmentContainer` | `Topomatic.Alg.LandAllotment.ILandAllotmentContainer.get_LandAllotment` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `LandAllotmentConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LandAllotmentWindow` | `String` | Yes | `"id_landallotment"` | `` |
| `PluginID` | `String` | Yes | `"Landallotment"` | `` |

### `LandAllotmentEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentEditableItem` |
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
      - `Topomatic.Alg.LandAllotment.LandAllotmentEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalRotation` | `Double` | `get/set` | No | `` |
| `Flipped` | `Boolean` | `get/set` | No | `` |
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

### `LandAllotmentEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.LandAllotment.LandAllotmentEditableItemsKey`

#### Constructors (1)

- `.ctor(eItemType itemType, eItemTransition itemTransition, Double station, Double offset, LandAllotmentNode node, Int32 number)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemTransition` | `eItemTransition` | `get/set` | No | `` |
| `ItemType` | `eItemType` | `get/set` | No | `` |
| `Node` | `LandAllotmentNode` | `get/set` | No | `` |
| `Number` | `Int32` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (2)

- `eItemTransition` (enum)
- `eItemType` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LandAllotmentLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotmentLine`

#### Constructors (1)

- `.ctor(Object parent, LandAllotmentLineSide side, LandAllotmentLinesStyle style)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `LandAllotmentNode` | `get/set` | No | `` |
| `LandAllotment` | `LandAllotment` | `get` | No | `` |
| `Side` | `LandAllotmentLineSide` | `get` | No | `` |
| `Style` | `LandAllotmentLinesStyle` | `get` | No | `` |
| `Type` | `LandAllotmentLineType` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `LandAllotmentNode node` | `` |
| `Clear` | `Void` | `` | `` |
| `CreateNode` | `LandAllotmentNode` | `Double station, Double offset` | `` |
| `FindNodes` | `List<Int32>` | `Double station` | `` |
| `GetEnumerator` | `IEnumerator<LandAllotmentNode>` | `` | `` |
| `GetOffsets` | `List<Double>` | `Double station` | `` |
| `GetOffsValue` | `Boolean` | `Int32 index, Double station, ref Double value` | `` |
| `Insert` | `Void` | `Int32 index, LandAllotmentNode node` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `LandAllotmentLineSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentLineSide` |
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
      - `Topomatic.Alg.LandAllotment.LandAllotmentLineSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `LandAllotmentLineSide` | Yes | `Left` | `` |
| `Right` | `LandAllotmentLineSide` | Yes | `Right` | `` |
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

### `LandAllotmentLineType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentLineType` |
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
      - `Topomatic.Alg.LandAllotment.LandAllotmentLineType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auxilary` | `LandAllotmentLineType` | Yes | `Auxilary` | `` |
| `Design` | `LandAllotmentLineType` | Yes | `Design` | `` |
| `Existent` | `LandAllotmentLineType` | Yes | `Existent` | `` |
| `Temporary` | `LandAllotmentLineType` | Yes | `Temporary` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Design` | `0` |
| `Existent` | `1` |
| `Temporary` | `2` |
| `Auxilary` | `3` |

**Underlying Type**: `System.Int32`

### `LandAllotmentNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentNode` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.IEquatable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.LandAllotment.LandAllotmentNode`

#### Constructors (1)

- `.ctor(LandAllotmentLine line)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get` | No | `` |
| `CurveExtra` | `Boolean` | `get/set` | No | `` |
| `Line` | `LandAllotmentLine` | `get` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `OsnCurveExtra` | `Boolean` | `get/set` | No | `` |
| `OsnCurveSegmentFactor` | `Double` | `get/set` | No | `` |
| `OsnExtra` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Pos` | `Vector2D` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Valid` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `LandAllotmentNode other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LandAllotmentOsnExtensions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.LandAllotmentOsnExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddExtraNodesForSpan` | `Void` | `List<LandAllotmentNode> nodes, LandAllotmentLine line, LandAllotmentNode n1, LandAllotmentNode n2, Double osnCurveSegmentFactor` | `` |

### `TempLandAllotmentLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.TempLandAllotmentLine` |
| **Base Type** | `Topomatic.Alg.LandAllotment.LandAllotmentLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.LandAllotmentNode, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.LandAllotmentLine`
        - `Topomatic.Alg.LandAllotment.TempLandAllotmentLine`

#### Constructors (1)

- `.ctor(Object parent, LandAllotmentLineSide side, LandAllotmentLinesStyle style)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `LandAllotmentLineType` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.LandAllotment.Style`

### `LandAllotmentLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`
        - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LandAllotmentLineCrossSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLineCrossSectionStyle` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`
        - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem`
          - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLineCrossSectionStyle`

#### Constructors (1)

- `.ctor(LandAllotmentLinesStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MarkersTextSize` | `Double` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

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

### `LandAllotmentLineEditorStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLineEditorStyle` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`
        - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem`
          - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLineEditorStyle`

#### Constructors (1)

- `.ctor(LandAllotmentLinesStyle owner, Boolean showLines)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowLines` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandard` | `String` | `get` | No | `` |

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

### `LandAllotmentLinesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLinesStyle` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`
        - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLayerStyleItem`
          - `Topomatic.Alg.LandAllotment.Style.LandAllotmentLinesStyle`

#### Constructors (1)

- `.ctor(LandAllotmentStyle owner, String standardId, Boolean showLines)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `CrossSectionStyle` | `LandAllotmentLineCrossSectionStyle` | `get` | No | `` |
| `DefaultColor` | `CadColor` | `get/set` | No | `` |
| `DefaultLeftLineTitle` | `String` | `get/set` | No | `` |
| `DefaultMarkersBlockName` | `String` | `get/set` | No | `` |
| `DefaultMarkersColor` | `CadColor` | `get/set` | No | `` |
| `DefaultMarkersPrefix` | `String` | `get/set` | No | `` |
| `DefaultRightLineTitle` | `String` | `get/set` | No | `` |
| `DefaultShowMarkers` | `Boolean` | `get/set` | No | `` |
| `DefaultShowVertexCoords` | `Boolean` | `get/set` | No | `` |
| `DefaultVertexCoordsBlockName` | `String` | `get/set` | No | `` |
| `DefaultVertexCoordsExtLine` | `Boolean` | `get/set` | No | `` |
| `EditorStyle` | `LandAllotmentLineEditorStyle` | `get` | No | `` |
| `LeftLineTitle` | `String` | `get/set` | No | `` |
| `MarkersBlockName` | `String` | `get/set` | No | `` |
| `MarkersColor` | `CadColor` | `get/set` | No | `` |
| `MarkersPrefix` | `String` | `get/set` | No | `` |
| `RightLineTitle` | `String` | `get/set` | No | `` |
| `ShowMarkers` | `Boolean` | `get/set` | No | `` |
| `ShowVertexCoords` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `VertexCoordsBlockName` | `String` | `get/set` | No | `` |
| `VertexCoordsExtLine` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<LandAllotmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `LandAllotmentStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyle` |
| **Base Type** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem, Topomatic.Alg.LandAllotment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`
        - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyle`

#### Constructors (1)

- `.ctor(LandAllotment owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurveSplitSegment` | `Double` | `get/set` | No | `` |
| `DesignLinesStyle` | `LandAllotmentLinesStyle` | `get/set` | No | `` |
| `DesignOffset` | `Double` | `get/set` | No | `` |
| `ExistentCodes` | `String` | `get/set` | No | `` |
| `ExistentLinesStyle` | `LandAllotmentLinesStyle` | `get` | No | `` |
| `ExistentOffset` | `Double` | `get/set` | No | `` |
| `LandAllotment` | `LandAllotment` | `get/set` | No | `` |
| `LayerStyles` | `IEnumerable<LandAllotmentLayerStyleItem>` | `get` | No | `` |
| `TempLinesStyle` | `LandAllotmentLinesStyle` | `get` | No | `` |
| `TempOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<LandAllotmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `LandAllotmentStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem` |
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
      - `Topomatic.Alg.LandAllotment.Style.LandAllotmentStyleItem`

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 22 |
| **Classes** | 14 |
| **Interfaces** | 1 |
| **Enums** | 4 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 1 |
| **Total Methods** | 36 |
| **Total Properties** | 84 |
| **Total Fields** | 20 |
| **Total Events** | 1 |
| **Total Constructors** | 16 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


