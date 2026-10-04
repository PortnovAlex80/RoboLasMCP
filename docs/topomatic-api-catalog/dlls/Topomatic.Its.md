# Topomatic.Its

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Its` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Its, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Its.dll` |

---
## Namespace: `Topomatic.Its`

### `AlignmentIts` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.AlignmentIts` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Its.IAlignmentItsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Its.AlignmentIts`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `ApplyExtraOnly` | `Boolean` | `get/set` | No | `` |
| `ApplyShifts` | `Boolean` | `get/set` | No | `` |
| `ApplyTemporary` | `Boolean` | `get/set` | No | `` |
| `Cache` | `ItsCache` | `get` | No | `` |
| `EditedItems` | `ItsEditedItemsTable` | `get` | No | `` |
| `ExStations` | `ItsExStationsTable` | `get/set` | No | `` |
| `ItsTable` | `ItsTable` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |
| `Style` | `AlignmentItsStyle` | `get` | No | `` |

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
| `IAlignmentContainer` | `get_Alignment` |
| `IAlignmentItsContainer` | `Topomatic.Its.IAlignmentItsContainer.get_Its` |

### `IAlignmentItsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.IAlignmentItsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Its` | `AlignmentIts` | `get` | No | `` |

### `IItsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.IItsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Its` | `AlignmentIts` | `get` | No | `` |

### `IItsTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.IItsTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItsTable` | `ItsTable` | `get` | No | `` |

### `InterTrackSpace` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.InterTrackSpace` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ItPos ex, ItPos des, ItPos exNext, ItPos desNext, Nullable<Double> desV, Nullable<Double> exV, Nullable<Double> temp1V, Nullable<Double> temp2V)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasicNotePos` | `Vector2D` | `get` | No | `` |
| `MaxOffset` | `Nullable<Double>` | `get` | No | `` |
| `MaxOffsetPos` | `Nullable<Vector2D>` | `get` | No | `` |
| `MaxOffsItPos` | `ItPos` | `get` | No | `` |
| `MinOffset` | `Nullable<Double>` | `get` | No | `` |
| `MinOffsetPos` | `Nullable<Vector2D>` | `get` | No | `` |
| `MinOffsItPos` | `ItPos` | `get` | No | `` |
| `NoteNormal` | `Vector2D` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetNote` | `String` | `Boolean applyTemporary, Int32 digits` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Des` | `ItPos` | No | `` | `` |
| `DesNext` | `ItPos` | No | `` | `` |
| `DesValue` | `Nullable<Double>` | No | `` | `` |
| `Ex` | `ItPos` | No | `` | `` |
| `ExNext` | `ItPos` | No | `` | `` |
| `ExValue` | `Nullable<Double>` | No | `` | `` |
| `Temp1Value` | `Nullable<Double>` | No | `` | `` |
| `Temp2Value` | `Nullable<Double>` | No | `` | `` |

### `ItPos` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItPos` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D pos, String relativePath, Double offs)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlgRelativePath` | `String` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `Pos` | `Vector2D` | No | `` | `` |

### `ItsBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment main, ItsTable itsTable)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `List<InterTrackSpace>` | `Double sta` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `StaToSlaveAlignment` | `Boolean` | `CompoundLine master, CompoundLine slave, Double sta, ref Vector2D pos, ref Double beta, ref Vector2D masterPos` | `` |

### `ItsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlignmentIts its)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePos` | `Vector2D` | `get` | No | `` |
| `ItsList` | `List<InterTrackSpace>` | `get` | No | `` |
| `LinesManagedBuffer` | `ManagedBuffer<Vector2F>` | `get` | No | `` |
| `Stations` | `List<Double>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

### `ItsConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DWL_MODEL_TYPE` | `String` | Yes | `"application/its-dwl"` | `` |
| `PluginUID` | `String` | Yes | `"Its"` | `` |

### `ItsEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsEditableItem` |
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
      - `Topomatic.Its.ItsEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TextOffset` | `Vector2D` | `get/set` | No | `` |
| `TextOverrideRotation` | `Boolean` | `get/set` | No | `` |
| `TextRotation` | `Double` | `get/set` | No | `` |

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

### `ItsEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Its.ItsEditableItemsKey`

#### Constructors (1)

- `.ctor(Int32 itsIndex, InterTrackSpace its, Double station)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItsHash` | `String` | `get` | No | `` |
| `ItsIndex` | `Int32` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateItsHash` | `String` | `InterTrackSpace its` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ItsEditedItemsTable` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsEditedItemsTable` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.EditableItems.BasicEditedItemsTable`
        - `Topomatic.Its.ItsEditedItemsTable`

#### Constructors (1)

- `.ctor(AlignmentIts algIts)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateItem` | `EditableItem` | `` | `` |
| `CreateKey` | `EditableItemsKey` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ItsExStationsTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsExStationsTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IList`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Its.IAlignmentItsContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Its.ItsExStationsTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Double` | `get/set` | No | `` |
| `Its` | `AlignmentIts` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Double item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Double item` | `` |
| `CopyTo` | `Void` | `Double[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<Double>` | `` | `` |
| `IndexOf` | `Int32` | `Double item` | `` |
| `Insert` | `Void` | `Int32 index, Double item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Double item` | `` |
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
| `IAlignmentItsContainer` | `get_Its` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Itspace` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Itspace` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Its.IItsTableContainer, Topomatic.Its.IAlignmentItsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Its.Itspace`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DesAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `ExAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `Its` | `AlignmentIts` | `get` | No | `` |
| `ItsTable` | `ItsTable` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Itspace source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IItsTableContainer` | `get_ItsTable` |
| `IAlignmentItsContainer` | `get_Its` |

### `ItsTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.ItsTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Its.Itspace, Topomatic.Its, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Its.Itspace, Topomatic.Its, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Its.Itspace, Topomatic.Its, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Its.IAlignmentItsContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Its.ItsTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Itspace` | `get/set` | No | `` |
| `Its` | `AlignmentIts` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Itspace item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Itspace item` | `` |
| `CopyTo` | `Void` | `Itspace[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<Itspace>` | `` | `` |
| `IndexOf` | `Int32` | `Itspace item` | `` |
| `Insert` | `Void` | `Int32 index, Itspace item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Itspace item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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
| `IAlignmentItsContainer` | `get_Its` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Its.Style`

### `AlignmentItsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Style.AlignmentItsStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrsStyle` | `ItsCrsStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `LimitValue` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PlanStyle` | `ItsPlanStyle` | `get` | No | `` |

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

### `ItsCrsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Style.ItsCrsStyle` |
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
      - `Topomatic.Its.Style.ItsCrsStyle`

#### Constructors (1)

- `.ctor(AlignmentItsStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |

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

### `ItsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Style.ItsPlanStyle` |
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
      - `Topomatic.Its.Style.ItsPlanStyle`

#### Constructors (1)

- `.ctor(AlignmentItsStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawLines` | `Boolean` | `get/set` | No | `` |
| `MaskText` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextAngle` | `Double` | `get/set` | No | `` |
| `TextHorizontalOffset` | `Double` | `get/set` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `TextVerticalOffset` | `Double` | `get/set` | No | `` |

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 18 |
| **Classes** | 14 |
| **Interfaces** | 3 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 46 |
| **Total Properties** | 66 |
| **Total Fields** | 13 |
| **Total Events** | 0 |
| **Total Constructors** | 14 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


