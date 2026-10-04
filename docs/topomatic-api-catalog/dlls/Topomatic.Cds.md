# Topomatic.Cds

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cds` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cds.dll` |

---
## Namespace: `Topomatic.Cds`

### `CdsDecoratorEssence` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsDecoratorEssence` |
| **Base Type** | `Topomatic.Cds.CdsEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DecoratedEssence` | `CdsEssence` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsDrawing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsDrawing` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsDrawing`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Boards` | `IList<CdsBoard>` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `ExtendedSnaps` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_HP` | `Double` | Yes | `150` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `CdsElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsElement` |
| **Base Type** | `Topomatic.Cds.CdsEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `Description` | `String` | `get/set` | No | `` |
| `HeightDimension` | `CdsHeightDimension` | `get/set` | No | `PropertyTypeConverter` |
| `HeightDimensionPosition` | `CdsDimensionPosition` | `get` | No | `Browsable` |
| `IdentDimension` | `CdsIdentDimension` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `IdentDimensionPositions` | `CdsDimensionPosition[]` | `get` | No | `Browsable` |
| `WidthDimension` | `CdsWidthDimension` | `get/set` | No | `PropertyTypeConverter` |
| `WidthDimensionPosition` | `CdsDimensionPosition` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BOTTOM` | `Int32` | Yes | `3` | `` |
| `LEFT` | `Int32` | Yes | `0` | `` |
| `RIGHT` | `Int32` | Yes | `2` | `` |
| `TOP` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsEssence` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsEssence` |
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
      - `Topomatic.Cds.CdsEssence`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `InsertionPos` | `Vector2D` | `get/set` | No | `Browsable` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `Regen` | `Void` | `RegenEventArgs args` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneEssence` | `CdsEssence` | `Object parent, CdsEssence value` | `` |
| `ConvertFromHpSize` | `String` | `Double value` | `` |
| `ConvertFromMillimetres` | `String` | `Double value, Double hp` | `` |
| `Find` | `T` | `CdsEssence essence` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `COLOR_BLUE` | `Int32` | Yes | `-16776961` | `` |
| `COLOR_BROWN` | `Int32` | Yes | `-7650029` | `` |
| `COLOR_GREEN` | `Int32` | Yes | `-16744448` | `` |
| `COLOR_ORANGE` | `Int32` | Yes | `-16640` | `` |
| `COLOR_RED` | `Int32` | Yes | `-65536` | `` |
| `COLOR_WHITE` | `Int32` | Yes | `-1` | `` |
| `COLOR_YELLOW` | `Int32` | Yes | `-256` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `CdsFontManager` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsFontManager` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `RoadSignsFont` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `IsValidAliace` | `Boolean` | `String aliace` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Current` | `CdsFontManager` | Yes | `` | `` |
| `DEFAULT_FONT` | `String` | Yes | `"default"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CdsModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Dwg.IDrawingContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Cds.CdsModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get` | No | `` |
| `SignDrawing` | `CdsDrawing` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"cds"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDrawingContainer` | `get_Drawing` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsSize` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsSize` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransactable owner, String size)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Size` | `String` | `get/set` | No | `` |
| `Value` | `Double` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, String defaultValue` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Regen` | `Void` | `Double hp` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Parse` | `Double` | `Double hp, String s` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsSizes` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.CdsSizes` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransactable owner, String size, Int32 count)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Double` | `get` | No | `` |
| `Size` | `String` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Regen` | `Void` | `Double hp` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToArray` | `Double[]` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DIVIDER` | `Char` | Yes | `;` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RegenEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.RegenEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cds.RegenEventArgs`

#### Constructors (1)

- `.ctor(Double hp)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Hp` | `Double` | `get` | No | `` |

---
## Namespace: `Topomatic.Cds.Boards`

### `CdsBoard` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsBoard` |
| **Base Type** | `Topomatic.Cds.Decorators.CdsCoordinateEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoardSize` | `CdsBoardSize` | `get/set` | No | `PropertyTypeConverter` |
| `EdgeColor` | `CadColor` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `EdgeRadiusDimension` | `CdsRadiusDimension` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `EdgeRadiusDimensionPositions` | `CdsDimensionPosition[]` | `get` | No | `Browsable` |
| `EdgeWidth` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Hp` | `CdsSize` | `get` | No | `PropertyEditor, PropertyProvider` |
| `IdentWidth` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Name` | `String` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Radius` | `CdsSizes` | `get` | No | `PropertyProvider` |
| `RealSize` | `String` | `get` | No | `` |
| `UserHeight` | `CdsSize` | `get` | No | `PropertyProvider` |
| `UserWidth` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `Regen` | `Void` | `RegenEventArgs args` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsBoardSize` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsBoardSize` |
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
      - `Topomatic.Cds.Boards.CdsBoardSize`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auto` | `CdsBoardSize` | Yes | `Auto` | `` |
| `Custom` | `CdsBoardSize` | Yes | `Custom` | `` |
| `UZDP` | `CdsBoardSize` | Yes | `UZDP` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Auto` | `0` |
| `UZDP` | `1` |
| `Custom` | `2` |

**Underlying Type**: `System.Int32`

### `CdsDirectionBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsDirectionBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsDirectionBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CdsGuideBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsGuideBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsGuideBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BEAK_HP_KOEFF` | `Double` | Yes | `0.07` | `` |
| `BEAK_VALUE` | `Double` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CdsObjectNameBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsObjectNameBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsObjectNameBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CdsRouteBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsRouteBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsRouteBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CdsSettlementBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsSettlementBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsObjectNameBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsObjectNameBoard`
                - `Topomatic.Cds.Boards.CdsSettlementBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BandHeight` | `CdsSize` | `get` | No | `PropertyProvider` |
| `BandIdent` | `CdsSize` | `get` | No | `PropertyProvider` |
| `HasBand` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsUserBoard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Boards.CdsUserBoard` |
| **Base Type** | `Topomatic.Cds.Boards.CdsBoard` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Boards.CdsBoard`
              - `Topomatic.Cds.Boards.CdsUserBoard`

#### Constructors (1)

- `.ctor(Object parent)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Cds.Containers`

### `CdsBeakDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsBeakDirection` |
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
      - `Topomatic.Cds.Containers.CdsBeakDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `CdsBeakDirection` | Yes | `Left` | `` |
| `Right` | `CdsBeakDirection` | Yes | `Right` | `` |
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

### `CdsCoordinatePanel` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsCoordinatePanel` |
| **Base Type** | `Topomatic.Cds.Containers.CdsPanel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsCoordinatePanel`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Item` | `CdsCoordinateEssence` | `get` | No | `Browsable` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `CdsCoordinateEssence insertion` | `` |
| `Add` | `CdsCoordinateEssence<T>` | `String x, String y` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `IndexOf` | `Int32` | `CdsCoordinateEssence direction` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |

### `CdsDirection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsDirection` |
| **Base Type** | `Topomatic.Cds.CdsElement` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsDirection`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `HasLeftArrow` | `Boolean` | `get/set` | No | `` |
| `HasRightArrow` | `Boolean` | `get/set` | No | `` |
| `Item` | `CdsDirectionItem` | `get` | No | `Browsable` |
| `LeftArrow` | `CdsArrow` | `get` | No | `Browsable` |
| `RightArrow` | `CdsArrow` | `get` | No | `Browsable` |
| `Spacing` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `CdsDirectionItem` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Exchange` | `Void` | `Int32 from, Int32 to` | `` |
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `IndexOf` | `Int32` | `CdsDirectionItem text` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CdsDirectionInsertion` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsDirectionInsertion` |
| **Base Type** | `Topomatic.Cds.Containers.CdsPanel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsDirectionInsertion`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DistancesDotAlign` | `Boolean` | `get/set` | No | `` |
| `DistancesSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LeftArrowSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |
| `TextsSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsGuideDirectionInsertion` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsGuideDirectionInsertion` |
| **Base Type** | `Topomatic.Cds.Containers.CdsSingleDirectionInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsDirectionInsertion`
              - `Topomatic.Cds.Containers.CdsSingleDirectionInsertion`
                - `Topomatic.Cds.Containers.CdsGuideDirectionInsertion`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeakDirection` | `CdsBeakDirection` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsLinearJustify` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsLinearJustify` |
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
      - `Topomatic.Cds.Containers.CdsLinearJustify`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `CdsLinearJustify` | Yes | `Center` | `` |
| `Left` | `CdsLinearJustify` | Yes | `Left` | `` |
| `Right` | `CdsLinearJustify` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Center` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `CdsMultiDirectionInsertion` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsMultiDirectionInsertion` |
| **Base Type** | `Topomatic.Cds.Containers.CdsDirectionInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsDirectionInsertion`
              - `Topomatic.Cds.Containers.CdsMultiDirectionInsertion`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Item` | `CdsDirection` | `get` | No | `Browsable` |
| `Separate` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Spacing` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `CdsDirection` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Exchange` | `Void` | `Int32 from, Int32 to` | `` |
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `IndexOf` | `Int32` | `CdsDirection direction` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |

### `CdsPanel` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsPanel` |
| **Base Type** | `Topomatic.Cds.CdsElement` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`

#### Constructors (1)

- `.ctor(Object parent, CadColor color, CadColor borderColor, String borderHeight, String borderRadius, String marigns)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderColor` | `CadColor` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `BorderDimension` | `CdsBorderIdentDimension` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `BorderDimensionPositions` | `CdsDimensionPosition[]` | `get` | No | `Browsable` |
| `BorderHeight` | `CdsSize` | `get` | No | `PropertyProvider` |
| `BorderRadius` | `CdsSizes` | `get` | No | `PropertyProvider` |
| `BorderRadiusDimension` | `CdsRadiusDimension` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `BorderRadiusDimensionPositions` | `CdsDimensionPosition[]` | `get` | No | `Browsable` |
| `Marigns` | `CdsSizes` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Align` | `BoundingBox2D` | `IList<T> essences, CdsLinearJustify justify, Double lineSpacing` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CdsPictogrammPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsPictogrammPosition` |
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
      - `Topomatic.Cds.Containers.CdsPictogrammPosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `CdsPictogrammPosition` | Yes | `Left` | `` |
| `None` | `CdsPictogrammPosition` | Yes | `None` | `` |
| `Right` | `CdsPictogrammPosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |
| `None` | `2` |

**Underlying Type**: `System.Int32`

### `CdsRoute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsRoute` |
| **Base Type** | `Topomatic.Cds.Containers.CdsPanel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsRoute`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, String borderHeight)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Arrow` | `CdsArrow` | `get` | No | `Browsable` |
| `ArrowPosition` | `CdsRouteArrowPosition` | `get/set` | No | `PropertyTypeConverter` |
| `Text` | `CdsText` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |

### `CdsRouteArrowPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsRouteArrowPosition` |
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
      - `Topomatic.Cds.Containers.CdsRouteArrowPosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `CdsRouteArrowPosition` | Yes | `Left` | `` |
| `None` | `CdsRouteArrowPosition` | Yes | `None` | `` |
| `Right` | `CdsRouteArrowPosition` | Yes | `Right` | `` |
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

### `CdsRoutePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsRoutePosition` |
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
      - `Topomatic.Cds.Containers.CdsRoutePosition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `CdsRoutePosition` | Yes | `Center` | `` |
| `Down` | `CdsRoutePosition` | Yes | `Down` | `` |
| `None` | `CdsRoutePosition` | Yes | `None` | `` |
| `Up` | `CdsRoutePosition` | Yes | `Up` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Center` | `0` |
| `Up` | `1` |
| `Down` | `2` |
| `None` | `3` |

**Underlying Type**: `System.Int32`

### `CdsSingleDirectionInsertion` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsSingleDirectionInsertion` |
| **Base Type** | `Topomatic.Cds.Containers.CdsDirectionInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsDirectionInsertion`
              - `Topomatic.Cds.Containers.CdsSingleDirectionInsertion`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Direction` | `CdsDirection` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |

### `CdsTextInsertion` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Containers.CdsTextInsertion` |
| **Base Type** | `Topomatic.Cds.Containers.CdsPanel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Containers.CdsPanel`
            - `Topomatic.Cds.Containers.CdsTextInsertion`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, CadColor color, CadColor borderColor, String borderHeight, String borderRadius, String marigns)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Item` | `CdsText` | `get` | No | `Browsable` |
| `Justify` | `CdsLinearJustify` | `get/set` | No | `PropertyTypeConverter` |
| `LineSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Pictogramm` | `CdsPictogram` | `get` | No | `Browsable` |
| `PictogramPosition` | `CdsPictogrammPosition` | `get/set` | No | `PropertyTypeConverter` |
| `PictogramSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Route` | `CdsRoute` | `get` | No | `Browsable` |
| `RoutePosition` | `CdsRoutePosition` | `get/set` | No | `PropertyTypeConverter` |
| `RouteSpacing` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `CdsText` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Exchange` | `Void` | `Int32 from, Int32 to` | `` |
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `IndexOf` | `Int32` | `CdsText text` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |

---
## Namespace: `Topomatic.Cds.Decorators`

### `CdsCoordinateEssence` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Decorators.CdsCoordinateEssence` |
| **Base Type** | `Topomatic.Cds.CdsDecoratorEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Paddings` | `CdsSizes` | `get` | No | `PropertyProvider` |
| `X` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Y` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsCoordinateEssence`1<T where CdsEssence, INamedTransactable, ITransactable, IUpdatable, IStgSerializable, IOwned, class, CdsEssence>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Decorators.CdsCoordinateEssence`1` |
| **Base Type** | `Topomatic.Cds.Decorators.CdsCoordinateEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsCoordinateEssence`
            - `Topomatic.Cds.Decorators.CdsCoordinateEssence`1`

#### Constructors (1)

- `.ctor(Object parent)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CdsDirectionItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Decorators.CdsDirectionItem` |
| **Base Type** | `Topomatic.Cds.CdsDecoratorEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsDecoratorEssence`
          - `Topomatic.Cds.Decorators.CdsDirectionItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Distance` | `CdsText` | `get` | No | `Browsable` |
| `DistancePosition` | `CdsDistancePosition` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CdsDistancePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Decorators.CdsDistancePosition` |
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
      - `Topomatic.Cds.Decorators.CdsDistancePosition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `CdsDistancePosition` | Yes | `Center` | `` |
| `Down` | `CdsDistancePosition` | Yes | `Down` | `` |
| `None` | `CdsDistancePosition` | Yes | `None` | `` |
| `Up` | `CdsDistancePosition` | Yes | `Up` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Center` | `1` |
| `Up` | `2` |
| `Down` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Cds.Design`

### `CdsBorderDimensionTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsBorderDimensionTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Cds.Design.CdsBorderDimensionTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertHorizontal` | `String` | `CdsBorderDimension dimension, Boolean left` | `` |
| `ConvertVertical` | `String` | `CdsBorderDimension dimension, Boolean bottom` | `` |

### `CdsColorTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsColorTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Cds.Design.CdsColorTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `CdsDecoratedEssencePropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsDecoratedEssencePropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cds.Design.CdsDecoratedEssencePropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `CdsDistancePositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsDistancePositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Cds.Design.CdsDistancePositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CdsIdentDimensionTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsIdentDimensionTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Cds.Design.CdsIdentDimensionTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertHorizontal` | `String` | `CdsDistanceDimension dimension` | `` |
| `ConvertVertical` | `String` | `CdsDistanceDimension dimension` | `` |

### `CdsPictogrammPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsPictogrammPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Cds.Design.CdsPictogrammPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CdsRadiusDimensionTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsRadiusDimensionTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Cds.Design.CdsRadiusDimensionTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `CdsRoutePositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Design.CdsRoutePositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Cds.Design.CdsRoutePositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Cds.Dimensions`

### `CdsBorderDimension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsBorderDimension` |
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
      - `Topomatic.Cds.Dimensions.CdsBorderDimension`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Inside` | `CdsBorderDimension` | Yes | `Inside` | `` |
| `None` | `CdsBorderDimension` | Yes | `None` | `` |
| `OnBoard` | `CdsBorderDimension` | Yes | `OnBoard` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Inside` | `1` |
| `OnBoard` | `2` |

**Underlying Type**: `System.Int32`

### `CdsBorderIdentDimension` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsBorderIdentDimension` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cds.Dimensions.CdsBorderIdentDimension`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CdsBorderIdentDimension` | `StgNode node` | `` |

#### Fields (16)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BOTTOM_LEFT` | `Int32` | Yes | `5` | `` |
| `BOTTOM_RIGHT` | `Int32` | Yes | `4` | `` |
| `BottomLeft` | `CdsBorderDimension` | No | `` | `` |
| `BottomRight` | `CdsBorderDimension` | No | `` | `` |
| `LEFT_BOTTOM` | `Int32` | Yes | `6` | `` |
| `LEFT_TOP` | `Int32` | Yes | `7` | `` |
| `LeftBottom` | `CdsBorderDimension` | No | `` | `` |
| `LeftTop` | `CdsBorderDimension` | No | `` | `` |
| `RIGHT_BOTTOM` | `Int32` | Yes | `3` | `` |
| `RIGHT_TOP` | `Int32` | Yes | `2` | `` |
| `RightBottom` | `CdsBorderDimension` | No | `` | `` |
| `RightTop` | `CdsBorderDimension` | No | `` | `` |
| `TOP_LEFT` | `Int32` | Yes | `0` | `` |
| `TOP_RIGHT` | `Int32` | Yes | `1` | `` |
| `TopLeft` | `CdsBorderDimension` | No | `` | `` |
| `TopRight` | `CdsBorderDimension` | No | `` | `` |

### `CdsDimensionPosition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsDimensionPosition` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CdsEssence parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Level` | `Int32` | `get/set` | No | `` |
| `Offset` | `Vector2D` | `get/set` | No | `` |

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

### `CdsDistanceDimension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsDistanceDimension` |
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
      - `Topomatic.Cds.Dimensions.CdsDistanceDimension`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `After` | `CdsDistanceDimension` | Yes | `After` | `` |
| `Before` | `CdsDistanceDimension` | Yes | `Before` | `` |
| `Inside` | `CdsDistanceDimension` | Yes | `Inside` | `` |
| `None` | `CdsDistanceDimension` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Inside` | `1` |
| `Before` | `2` |
| `After` | `3` |

**Underlying Type**: `System.Int32`

### `CdsHeightDimension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsHeightDimension` |
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
      - `Topomatic.Cds.Dimensions.CdsHeightDimension`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `CdsHeightDimension` | Yes | `Left` | `` |
| `LeftBoard` | `CdsHeightDimension` | Yes | `LeftBoard` | `` |
| `None` | `CdsHeightDimension` | Yes | `None` | `` |
| `Right` | `CdsHeightDimension` | Yes | `Right` | `` |
| `RightBoard` | `CdsHeightDimension` | Yes | `RightBoard` | `` |
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
| `LeftBoard` | `3` |
| `RightBoard` | `4` |

**Underlying Type**: `System.Int32`

### `CdsIdentDimension` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsIdentDimension` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cds.Dimensions.CdsIdentDimension`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CdsIdentDimension` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomIdent` | `CdsDistanceDimension` | No | `` | `` |
| `LeftIdent` | `CdsDistanceDimension` | No | `` | `` |
| `RightIdent` | `CdsDistanceDimension` | No | `` | `` |
| `TopIdent` | `CdsDistanceDimension` | No | `` | `` |

### `CdsLetterDimension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsLetterDimension` |
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
      - `Topomatic.Cds.Dimensions.CdsLetterDimension`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomBoard` | `CdsLetterDimension` | Yes | `BottomBoard` | `` |
| `None` | `CdsLetterDimension` | Yes | `None` | `` |
| `OverString` | `CdsLetterDimension` | Yes | `OverString` | `` |
| `TopBoard` | `CdsLetterDimension` | Yes | `TopBoard` | `` |
| `UnderString` | `CdsLetterDimension` | Yes | `UnderString` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `OverString` | `1` |
| `UnderString` | `2` |
| `TopBoard` | `3` |
| `BottomBoard` | `4` |

**Underlying Type**: `System.Int32`

### `CdsRadiusDimension` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsRadiusDimension` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cds.Dimensions.CdsRadiusDimension`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CdsRadiusDimension` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftBottom` | `Boolean` | No | `` | `` |
| `LeftTop` | `Boolean` | No | `` | `` |
| `RightBottom` | `Boolean` | No | `` | `` |
| `RightTop` | `Boolean` | No | `` | `` |

### `CdsWidthDimension` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Dimensions.CdsWidthDimension` |
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
      - `Topomatic.Cds.Dimensions.CdsWidthDimension`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `CdsWidthDimension` | Yes | `Bottom` | `` |
| `BottomBoard` | `CdsWidthDimension` | Yes | `BottomBoard` | `` |
| `None` | `CdsWidthDimension` | Yes | `None` | `` |
| `Top` | `CdsWidthDimension` | Yes | `Top` | `` |
| `TopBoard` | `CdsWidthDimension` | Yes | `TopBoard` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Top` | `1` |
| `Bottom` | `2` |
| `TopBoard` | `3` |
| `BottomBoard` | `4` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Cds.Elements`

### `CdsArrow` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsArrow` |
| **Base Type** | `Topomatic.Cds.Elements.CdsDrawingInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Elements.CdsDrawingInsertion`
            - `Topomatic.Cds.Elements.CdsArrow`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, CdsArrowView arrowView, Double angle)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `ArrowView` | `CdsArrowView` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsArrowView` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsArrowView` |
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
      - `Topomatic.Cds.Elements.CdsArrowView`

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alt` | `CdsArrowView` | Yes | `Alt` | `` |
| `ByPassLeft` | `CdsArrowView` | Yes | `ByPassLeft` | `` |
| `ByPassRight` | `CdsArrowView` | Yes | `ByPassRight` | `` |
| `Full` | `CdsArrowView` | Yes | `Full` | `` |
| `LoopLeft` | `CdsArrowView` | Yes | `LoopLeft` | `` |
| `LoopRight` | `CdsArrowView` | Yes | `LoopRight` | `` |
| `RouteArrow` | `CdsArrowView` | Yes | `RouteArrow` | `` |
| `Short` | `CdsArrowView` | Yes | `Short` | `` |
| `Swerve120Left` | `CdsArrowView` | Yes | `Swerve120Left` | `` |
| `Swerve120Right` | `CdsArrowView` | Yes | `Swerve120Right` | `` |
| `Swerve60Left` | `CdsArrowView` | Yes | `Swerve60Left` | `` |
| `Swerve60Right` | `CdsArrowView` | Yes | `Swerve60Right` | `` |
| `TurnLeft` | `CdsArrowView` | Yes | `TurnLeft` | `` |
| `TurnRight` | `CdsArrowView` | Yes | `TurnRight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Full` | `0` |
| `Short` | `1` |
| `Swerve60Left` | `2` |
| `Swerve60Right` | `3` |
| `Swerve120Left` | `4` |
| `Swerve120Right` | `5` |
| `TurnLeft` | `6` |
| `TurnRight` | `7` |
| `LoopLeft` | `8` |
| `LoopRight` | `9` |
| `Alt` | `10` |
| `ByPassLeft` | `11` |
| `ByPassRight` | `12` |
| `RouteArrow` | `13` |

**Underlying Type**: `System.Int32`

### `CdsDrawingInsertion` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsDrawingInsertion` |
| **Base Type** | `Topomatic.Cds.CdsElement` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Elements.CdsDrawingInsertion`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Icon` | `Drawing` | `get` | No | `Browsable` |
| `Size` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsPictogram` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsPictogram` |
| **Base Type** | `Topomatic.Cds.Elements.CdsDrawingInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Elements.CdsDrawingInsertion`
            - `Topomatic.Cds.Elements.CdsPictogram`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `IconType` | `CdsPictogramIconType` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsPictogramIconType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsPictogramIconType` |
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
      - `Topomatic.Cds.Elements.CdsPictogramIconType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Airport` | `CdsPictogramIconType` | Yes | `Airport` | `` |
| `Highway` | `CdsPictogramIconType` | Yes | `Highway` | `` |
| `Memorial` | `CdsPictogramIconType` | Yes | `Memorial` | `` |
| `Museum` | `CdsPictogramIconType` | Yes | `Museum` | `` |
| `Park` | `CdsPictogramIconType` | Yes | `Park` | `` |
| `SportObject` | `CdsPictogramIconType` | Yes | `SportObject` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Airport` | `0` |
| `Highway` | `1` |
| `SportObject` | `2` |
| `Memorial` | `3` |
| `Museum` | `4` |
| `Park` | `5` |

**Underlying Type**: `System.Int32`

### `CdsStaticSign` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsStaticSign` |
| **Base Type** | `Topomatic.Cds.Elements.CdsDrawingInsertion` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Elements.CdsDrawingInsertion`
            - `Topomatic.Cds.Elements.CdsStaticSign`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsText` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.CdsText` |
| **Base Type** | `Topomatic.Cds.CdsElement` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.CdsElement`
          - `Topomatic.Cds.Elements.CdsText`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, String text, String height, String fontAliace, CdsLetterDimension dimensions, Boolean pressured)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FontAliace` | `String` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `LetterDimension` | `CdsLetterDimension` | `get/set` | No | `PropertyTypeConverter` |
| `LetterDimensionPosition` | `CdsDimensionPosition` | `get` | No | `Browsable` |
| `Pressured` | `Boolean` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `PropertyEditor` |
| `TextHeight` | `CdsSize` | `get` | No | `PropertyProvider, PropertyEditor` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPressure` | `Double` | `Boolean pressured` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Cds.Elements.Pointers`

### `ArcBranchDirectLeftRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcBranchDirectLeftRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchThreeDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchThreeDirection`
            - `Topomatic.Cds.Elements.Pointers.ArcBranchDirectLeftRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftRadius` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightRadius` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ArcBranchLeft` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcBranchLeft` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchOneDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchOneDirection`
            - `Topomatic.Cds.Elements.Pointers.ArcBranchLeft`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Radius` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ArcBranchLeftRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcBranchLeftRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchTwoDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchTwoDirection`
            - `Topomatic.Cds.Elements.Pointers.ArcBranchLeftRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftRadius` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightRadius` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ArcBranchRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcBranchRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchOneDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchOneDirection`
            - `Topomatic.Cds.Elements.Pointers.ArcBranchRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Radius` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ArcTurn` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcTurn` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`

#### Constructors (1)

- `.ctor(Object parent, Boolean isLeft, Int32 connectorsCount)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `IsLeft` | `Boolean` | `get` | No | `Browsable` |
| `Radius` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ArcTurnLeft` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcTurnLeft` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.ArcTurn` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.ArcTurnLeft`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ArcTurnRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.ArcTurnRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.ArcTurn` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.ArcTurnRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BranchOneDirection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.BranchOneDirection` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchOneDirection`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AfterLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `BeforeLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `ForwardSmaller` | `Boolean` | `get/set` | No | `` |
| `TurnSmaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FORWARD_CONNECTOR` | `Int32` | Yes | `0` | `` |
| `TURN_CONNECTOR` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BranchThreeDirection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.BranchThreeDirection` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchThreeDirection`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AfterLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `BeforeLeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `BeforeRightLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `ForwardSmaller` | `Boolean` | `get/set` | No | `` |
| `LeftAngle` | `Double` | `get/set` | No | `Angle` |
| `LeftSmaller` | `Boolean` | `get/set` | No | `` |
| `RightAngle` | `Double` | `get/set` | No | `Angle` |
| `RightSmaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FORWARD_CONNECTOR` | `Int32` | Yes | `0` | `` |
| `LEFT_CONNECTOR` | `Int32` | Yes | `1` | `` |
| `RIGHT_CONNECTOR` | `Int32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BranchTwoDirection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.BranchTwoDirection` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchTwoDirection`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeforeLeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `BeforeRightLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LeftAngle` | `Double` | `get/set` | No | `Angle` |
| `LeftSmaller` | `Boolean` | `get/set` | No | `` |
| `RightAngle` | `Double` | `get/set` | No | `Angle` |
| `RightSmaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LEFT_CONNECTOR` | `Int32` | Yes | `0` | `` |
| `RIGHT_CONNECTOR` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CdsPointerElem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Base Type** | `Topomatic.Cds.CdsEssence` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`

#### Constructors (1)

- `.ctor(Object parent, Int32 connectorsCount)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Connectors` | `Vector2D[]` | `get` | No | `Browsable` |
| `Path` | `BoundaryPathList` | `get` | No | `Browsable` |
| `Rotation` | `Double` | `get/set` | No | `Browsable` |
| `Width` | `Double` | `get/set` | No | `Browsable` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Connect` | `Void` | `CdsPointerElem element, Int32 connector` | `` |
| `ConnectedEssence` | `CdsPointerElem` | `Int32 index` | `` |
| `Disconnect` | `Boolean` | `CdsPointerElem element` | `` |
| `GetEnumerator` | `IEnumerator<CdsEssence>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `Regen` | `Void` | `RegenEventArgs args` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CircleJunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.CircleJunction` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.CircleJunction`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `LengthAfter` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LengthBefore` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DoubleCircleJunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.DoubleCircleJunction` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.DoubleCircleJunction`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeforeLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LeftAngle` | `Double` | `get/set` | No | `Angle` |
| `LeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LeftSmaller` | `Boolean` | `get/set` | No | `` |
| `RightAngle` | `Double` | `get/set` | No | `Angle` |
| `RightLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightSmaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LEFT_CONNECTOR` | `Int32` | Yes | `0` | `` |
| `RIGHT_CONNECTOR` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `HeadArrow` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.HeadArrow` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.HeadArrow`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LeftRingBranchIn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LeftRingBranchIn` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingBranch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingBranch`
              - `Topomatic.Cds.Elements.Pointers.LeftRingBranchIn`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftRingBranchOut` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LeftRingBranchOut` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingBranch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingBranch`
              - `Topomatic.Cds.Elements.Pointers.LeftRingBranchOut`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftRingEntry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LeftRingEntry` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingEntry` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingEntry`
              - `Topomatic.Cds.Elements.Pointers.LeftRingEntry`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LeftRingOutlet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LeftRingOutlet` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingEntry` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingEntry`
              - `Topomatic.Cds.Elements.Pointers.LeftRingOutlet`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LineSegment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LineSegment` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.LineSegment`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LineSegmentOverBridge` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.LineSegmentOverBridge` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.LineSegmentOverBridge`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AfterLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `BeforeLength` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PointerRoot` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.PointerRoot` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.PointerRoot`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |
| `PointerHeight` | `CdsSize` | `get` | No | `PropertyProvider` |
| `Smaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RightRingBranchIn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RightRingBranchIn` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingBranch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingBranch`
              - `Topomatic.Cds.Elements.Pointers.RightRingBranchIn`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightRingBranchOut` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RightRingBranchOut` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingBranch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingBranch`
              - `Topomatic.Cds.Elements.Pointers.RightRingBranchOut`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightRingEntry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RightRingEntry` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingEntry` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingEntry`
              - `Topomatic.Cds.Elements.Pointers.RightRingEntry`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RightRingOutlet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RightRingOutlet` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.RingEntry` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingEntry`
              - `Topomatic.Cds.Elements.Pointers.RightRingOutlet`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RingBranch` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RingBranch` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.ArcTurn` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingBranch`

#### Constructors (1)

- `.ctor(Object parent, Boolean isLeft, Boolean inside)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DirectionSmaller` | `Boolean` | `get/set` | No | `` |
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ARC_CONNECTOR` | `Int32` | Yes | `1` | `` |
| `DIRECTION_CONNECTOR` | `Int32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RingEntry` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.RingEntry` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.ArcTurn` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.ArcTurn`
            - `Topomatic.Cds.Elements.Pointers.RingEntry`

#### Constructors (1)

- `.ctor(Object parent, Boolean isLeft, Boolean outlet)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StraightBranchDirectLeftRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.StraightBranchDirectLeftRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchThreeDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchThreeDirection`
            - `Topomatic.Cds.Elements.Pointers.StraightBranchDirectLeftRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightLength` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StraightBranchLeft` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.StraightBranchLeft` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchOneDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchOneDirection`
            - `Topomatic.Cds.Elements.Pointers.StraightBranchLeft`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StraightBranchLeftRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.StraightBranchLeftRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchTwoDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchTwoDirection`
            - `Topomatic.Cds.Elements.Pointers.StraightBranchLeftRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightLength` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StraightBranchRight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.StraightBranchRight` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.BranchOneDirection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.BranchOneDirection`
            - `Topomatic.Cds.Elements.Pointers.StraightBranchRight`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `CdsSize` | `get` | No | `PropertyProvider` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TripleCircleJunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Elements.Pointers.TripleCircleJunction` |
| **Base Type** | `Topomatic.Cds.Elements.Pointers.CdsPointerElem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Cds.CdsEssence, Topomatic.Cds, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cds.CdsEssence`
        - `Topomatic.Cds.Elements.Pointers.CdsPointerElem`
          - `Topomatic.Cds.Elements.Pointers.TripleCircleJunction`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeforeLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `ForwardAngle` | `Double` | `get/set` | No | `Angle` |
| `ForwardLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `ForwardSmaller` | `Boolean` | `get/set` | No | `` |
| `LeftAngle` | `Double` | `get/set` | No | `Angle` |
| `LeftLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `LeftSmaller` | `Boolean` | `get/set` | No | `` |
| `RightAngle` | `Double` | `get/set` | No | `Angle` |
| `RightLength` | `CdsSize` | `get` | No | `PropertyProvider` |
| `RightSmaller` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FORWARD_CONNECTOR` | `Int32` | Yes | `0` | `` |
| `LEFT_CONNECTOR` | `Int32` | Yes | `1` | `` |
| `RIGHT_CONNECTOR` | `Int32` | Yes | `2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Cds.Font`

### `RoadSignsFont` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Font.RoadSignsFont` |
| **Base Type** | `Topomatic.Cad.Foundation.CadFont` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CadFont`
    - `Topomatic.Cds.Font.RoadSignsFont`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetActualCharSpaces` | `Boolean` | `Char c, Double height, Double ratio, Double pressure, ref Double WidthSpace, ref Double LeftSpace, ref Double RightSpace` | `` |
| `Layout` | `Void` | `String s, Vector3D point, Double sinA, Double cosA, Double height, Double ratio, Double oblique, Double pressure, TextJustify justify, DwgBlock block, Matrix matrix, DwgLayer layer, CadColor color` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadSignsLetter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cds.Font.RoadSignsLetter` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double width, Double leftspace)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoundaryPath` | `BoundaryPathList` | `get/set` | No | `` |
| `Hatch` | `DwgHatch` | `get` | No | `` |
| `LeftSpace` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 93 |
| **Classes** | 61 |
| **Interfaces** | 0 |
| **Enums** | 14 |
| **Structs** | 3 |
| **Abstract Classes** | 15 |
| **Static Classes** | 0 |
| **Total Methods** | 213 |
| **Total Properties** | 175 |
| **Total Fields** | 134 |
| **Total Events** | 0 |
| **Total Constructors** | 78 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


