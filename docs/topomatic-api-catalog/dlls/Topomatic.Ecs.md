# Topomatic.Ecs

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Ecs` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Ecs.dll` |

---
## Namespace: `Topomatic.Ecs`

### `Ecs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Ecs` |
| **Base Type** | `Topomatic.Ecs.SystemClasses.EcsItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - `Topomatic.Ecs.SystemClasses.EcsItemWithId`
          - `Topomatic.Ecs.Ecs`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Masts` | `EcsMasts` | `get` | No | `` |
| `Style` | `EcsStyle` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Equals` | `Boolean` | `EcsItem other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `EcsConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EcsWindow` | `String` | Yes | `"ID_ECS"` | `` |
| `PluginID` | `String` | Yes | `"Ecs"` | `` |

### `EcsMast` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMast` |
| **Base Type** | `Topomatic.Ecs.SystemClasses.EcsItemWithId` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - `Topomatic.Ecs.SystemClasses.EcsItemWithId`
          - `Topomatic.Ecs.EcsMast`

#### Constructors (1)

- `.ctor(EcsMasts masts)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasementCutoffElev` | `Double` | `get/set` | No | `` |
| `Clearance` | `Double` | `get/set` | No | `` |
| `ClearanceCaptionX` | `Double` | `get/set` | No | `` |
| `ClearanceCaptionY` | `Double` | `get/set` | No | `` |
| `Coords` | `Vector3D` | `get/set` | No | `` |
| `DesignStatus` | `EcsMastDesignStatus` | `get/set` | No | `` |
| `FixedSta` | `Boolean` | `get/set` | No | `` |
| `InvertSpanText` | `Boolean` | `get/set` | No | `` |
| `InvertText` | `Boolean` | `get/set` | No | `` |
| `Masts` | `EcsMasts` | `get` | No | `` |
| `MastType` | `EcsMastType` | `get/set` | No | `` |
| `Material` | `EcsMastMaterial` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `NumberCaptionX` | `Double` | `get/set` | No | `` |
| `NumberCaptionY` | `Double` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `OffsetCaptionX` | `Double` | `get/set` | No | `` |
| `OffsetCaptionY` | `Double` | `get/set` | No | `` |
| `PercentSpan` | `Double` | `get/set` | No | `` |
| `SetZigZag` | `Boolean` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |
| `ZigzagDirection` | `EcsZigzagDirection` | `get/set` | No | `` |
| `ZigzagOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `EcsItem other` | `` |
| `Remove` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `EcsMastDesignStatus` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMastDesignStatus` |
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
      - `Topomatic.Ecs.EcsMastDesignStatus`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Design` | `EcsMastDesignStatus` | Yes | `Design` | `` |
| `Existent` | `EcsMastDesignStatus` | Yes | `Existent` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Existent` | `0` |
| `Design` | `1` |

**Underlying Type**: `System.Int32`

### `EcsMastMaterial` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMastMaterial` |
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
      - `Topomatic.Ecs.EcsMastMaterial`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Concrete` | `EcsMastMaterial` | Yes | `Concrete` | `` |
| `Metal` | `EcsMastMaterial` | Yes | `Metal` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Concrete` | `0` |
| `Metal` | `1` |

**Underlying Type**: `System.Int32`

### `EcsMasts` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMasts` |
| **Base Type** | `Topomatic.Ecs.SystemClasses.EcsItemWithIdCollection`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, System.Collections.Generic.ICollection`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - `Topomatic.Ecs.SystemClasses.EcsItemCollection`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Ecs.SystemClasses.EcsItemWithIdCollection`1[[Topomatic.Ecs.EcsMast, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
            - `Topomatic.Ecs.EcsMasts`

#### Constructors (1)

- `.ctor(Ecs ecs)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ecs` | `Ecs` | `get` | No | `` |
| `Style` | `EcsMastsStyle` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Sort` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EcsMastShape` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMastShape` |
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
      - `Topomatic.Ecs.EcsMastShape`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Rect` | `EcsMastShape` | Yes | `Rect` | `` |
| `Round` | `EcsMastShape` | Yes | `Round` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Round` | `0` |
| `Rect` | `1` |

**Underlying Type**: `System.Int32`

### `EcsMastType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsMastType` |
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
      - `Topomatic.Ecs.EcsMastType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Double` | `EcsMastType` | Yes | `Double` | `` |
| `Intermediate` | `EcsMastType` | Yes | `Intermediate` | `` |
| `Single` | `EcsMastType` | Yes | `Single` | `` |
| `Transition` | `EcsMastType` | Yes | `Transition` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Single` | `0` |
| `Double` | `1` |
| `Intermediate` | `2` |
| `Transition` | `3` |

**Underlying Type**: `System.Int32`

### `EcsZigzagDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.EcsZigzagDirection` |
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
      - `Topomatic.Ecs.EcsZigzagDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Direct` | `EcsZigzagDirection` | Yes | `Direct` | `` |
| `Reverse` | `EcsZigzagDirection` | Yes | `Reverse` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Direct` | `0` |
| `Reverse` | `1` |

**Underlying Type**: `System.Int32`

### `IEcsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.IEcsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ecs` | `Ecs` | `get` | No | `` |

---
## Namespace: `Topomatic.Ecs.Style`

### `EcsClearenceStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsClearenceStyle` |
| **Base Type** | `Topomatic.Ecs.Style.EcsLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Style.EcsStyleItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsLayerStyleItem`
          - `Topomatic.Ecs.Style.EcsClearenceStyle`

#### Constructors (1)

- `.ctor(EcsStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<EcsLayerStyleItem>` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StyleText` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<EcsStyleItem>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EcsLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsLayerStyleItem` |
| **Base Type** | `Topomatic.Ecs.Style.EcsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsLayerStyleItem`

#### Constructors (1)

- `.ctor(EcsStyleItem parent, String styleText)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Precision` | `Int32` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StyleText` | `String` | `get` | No | `` |

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

### `EcsMastsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsMastsStyle` |
| **Base Type** | `Topomatic.Ecs.Style.EcsLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Style.EcsStyleItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsLayerStyleItem`
          - `Topomatic.Ecs.Style.EcsMastsStyle`

#### Constructors (1)

- `.ctor(EcsStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStyles` | `IEnumerable<EcsLayerStyleItem>` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StyleText` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColor` | `CadColor` | `EcsMastDesignStatus designStatus` | `` |
| `GetEnumerator` | `IEnumerator<EcsStyleItem>` | `` | `` |
| `GetSignGuid` | `Guid` | `EcsMastMaterial material` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EcsOffsetsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsOffsetsStyle` |
| **Base Type** | `Topomatic.Ecs.Style.EcsLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Style.EcsStyleItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsLayerStyleItem`
          - `Topomatic.Ecs.Style.EcsOffsetsStyle`

#### Constructors (1)

- `.ctor(EcsStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<EcsLayerStyleItem>` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StyleText` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<EcsStyleItem>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EcsSpansStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsSpansStyle` |
| **Base Type** | `Topomatic.Ecs.Style.EcsLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Style.EcsStyleItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsLayerStyleItem`
          - `Topomatic.Ecs.Style.EcsSpansStyle`

#### Constructors (1)

- `.ctor(EcsStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<EcsLayerStyleItem>` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `StyleText` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<EcsStyleItem>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EcsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsStyle` |
| **Base Type** | `Topomatic.Ecs.Style.EcsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Ecs.Style.EcsStyleItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`
        - `Topomatic.Ecs.Style.EcsStyle`

#### Constructors (1)

- `.ctor(Ecs ecs)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Background` | `Boolean` | `get/set` | No | `` |
| `ClearenceStyle` | `EcsClearenceStyle` | `get` | No | `` |
| `DrawSpanLine` | `Boolean` | `get/set` | No | `` |
| `Ecs` | `Ecs` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<EcsLayerStyleItem>` | `get` | No | `` |
| `MastsStyle` | `EcsMastsStyle` | `get` | No | `` |
| `MaxCurveSpan` | `Double` | `get/set` | No | `` |
| `MaxStraightSpan` | `Double` | `get/set` | No | `` |
| `OffsetsStyle` | `EcsOffsetsStyle` | `get` | No | `` |
| `SpansStyle` | `EcsSpansStyle` | `get` | No | `` |
| `TextInvert` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<EcsStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `EcsStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.Style.EcsStyleItem` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.Style.EcsStyleItem`

#### Constructors (1)

- `.ctor(EcsStyleItem parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Parent` | `EcsStyleItem` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Ecs.SystemClasses`

### `EcsItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.SystemClasses.EcsItem` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ecs` | `Ecs` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `EcsItem other` | `` |
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
| `IEcsContainer` | `get_Ecs` |

### `EcsItemCollection`1<T where EcsItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, IEquatable`1, IEcsContainer, class, EcsItem>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.SystemClasses.EcsItemCollection`1` |
| **Base Type** | `Topomatic.Ecs.SystemClasses.EcsItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, , , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - `Topomatic.Ecs.SystemClasses.EcsItemCollection`1`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `EcsItem other` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |
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

### `EcsItemWithId` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.SystemClasses.EcsItemWithId` |
| **Base Type** | `Topomatic.Ecs.SystemClasses.EcsItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - `Topomatic.Ecs.SystemClasses.EcsItemWithId`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `EcsItemWithId source` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

### `EcsItemWithIdCollection`1<T where EcsItemWithId, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, IEquatable`1, IEcsContainer, IHandledObject, class, EcsItemWithId>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Ecs.SystemClasses.EcsItemWithIdCollection`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Ecs.SystemClasses.EcsItem, Topomatic.Ecs, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Ecs.IEcsContainer, , , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Ecs.SystemClasses.EcsItem`
        - ``
          - `Topomatic.Ecs.SystemClasses.EcsItemWithIdCollection`1`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadItemByIdFormStg` | `T` | `StgNode node, String itemNodeName` | `` |
| `SaveItemIdToStg` | `Void` | `StgNode node, T item, String itemNodeName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 21 |
| **Classes** | 10 |
| **Interfaces** | 1 |
| **Enums** | 5 |
| **Structs** | 0 |
| **Abstract Classes** | 4 |
| **Static Classes** | 1 |
| **Total Methods** | 34 |
| **Total Properties** | 66 |
| **Total Fields** | 19 |
| **Total Events** | 0 |
| **Total Constructors** | 10 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


