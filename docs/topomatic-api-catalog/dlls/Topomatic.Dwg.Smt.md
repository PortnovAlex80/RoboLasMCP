# Topomatic.Dwg.Smt

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Dwg.Smt` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Dwg.Smt.dll` |

---
## Namespace: `Topomatic.Dwg.Smt`

### `AcadLinetype` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AcadLinetype` |
| **Base Type** | `Topomatic.Dwg.Smt.OffsetedObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.Smt.OffsetedObject`
    - `Topomatic.Dwg.Smt.AcadLinetype`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Linetype` | `DwgLinetype` | `get` | No | `` |
| `Lineweight` | `Lineweight` | `get/set` | No | `` |
| `Scale` | `SemanticDependencyProperty` | `get` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OffsetedObject source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `AreaSign` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AreaSign` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Dwg.Smt.IResolvable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IDwgDatabase database)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackgroundColor` | `CadColor` | `get/set` | No | `` |
| `Block` | `DwgBlock` | `get/set` | No | `` |
| `Database` | `IDwgDatabase` | `get` | No | `` |
| `HatchColor` | `CadColor` | `get/set` | No | `` |
| `HatchPattern` | `HatchPattern` | `get/set` | No | `` |
| `HatchRotation` | `Single` | `get/set` | No | `` |
| `HatchScale` | `Single` | `get/set` | No | `` |
| `Linetype` | `DwgLinetype` | `get/set` | No | `` |
| `LinetypeColor` | `CadColor` | `get/set` | No | `` |
| `LinetypeLineweight` | `Lineweight` | `get/set` | No | `` |
| `LinetypeScale` | `SemanticDependencyProperty` | `get` | No | `` |
| `LinetypeWidth` | `Double` | `get/set` | No | `` |
| `RepeatGrid` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `AreaSign source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `AreaSign` | `BinaryReader reader` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IResolvable` | `Topomatic.Dwg.Smt.IResolvable.Copy` |

### `AreaSignCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AreaSignCache` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(AreaSign pattern, BoundaryPathList boundary, Double scale, Double rotation, Int32 density)`
- `.ctor(AreaSign pattern, BoundaryPathList boundary, Double scale, Double rotation, CadColor layerColor, CadColor blockColor, Int32 density, Double elevation)`
- `.ctor(AreaSign pattern, BoundaryPathList boundary, Double scale, Double rotation, CadColor layerColor, CadColor blockColor, Int32 density, Double elevation, SemanticDataSet semantic)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Layout` | `Void` | `DwgBlock block, Double elevation` | `` |
| `Layout` | `Void` | `DwgBlock block` | `` |
| `Paint` | `Void` | `CadPen pen, Boolean enable` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `AreaSigns` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AreaSigns` |
| **Base Type** | `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Dwg.Smt.AreaSigns`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Syncronize` | `UInt32` | `AreaSignxLibraryNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AreaSignxLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AreaSignxLibrary` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.AreaSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.AreaSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.AreaSignxLibrary`

#### Constructors (1)

- `.ctor(String environment)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `AreaSignxLibrary` | `get` | Yes | `` |
| `LibraryName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AreaSignxLibraryNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.AreaSignxLibraryNode` |
| **Base Type** | `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Smt.AreaSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.AreaSignxLibraryNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AreaSignDefaultTag` | `String` | Yes | `"AreaSign"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BlockLinetype` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.BlockLinetype` |
| **Base Type** | `Topomatic.Dwg.Smt.OffsetedObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.Smt.OffsetedObject`
    - `Topomatic.Dwg.Smt.BlockLinetype`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AbsoluteRotation` | `Boolean` | `get/set` | No | `` |
| `Attachment` | `BlockLinetypeItemAttachment` | `get/set` | No | `` |
| `AutoRotation` | `Boolean` | `get/set` | No | `` |
| `Block` | `DwgBlock` | `get` | No | `` |
| `FlipElevations` | `Boolean` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OffsetedObject source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BlockLinetypeItemAttachment` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.BlockLinetypeItemAttachment` |
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
      - `Topomatic.Dwg.Smt.BlockLinetypeItemAttachment`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `BlockLinetypeItemAttachment` | Yes | `End` | `` |
| `First` | `BlockLinetypeItemAttachment` | Yes | `First` | `` |
| `Last` | `BlockLinetypeItemAttachment` | Yes | `Last` | `` |
| `Middle` | `BlockLinetypeItemAttachment` | Yes | `Middle` | `` |
| `Start` | `BlockLinetypeItemAttachment` | Yes | `Start` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Start` | `0` |
| `End` | `1` |
| `Middle` | `2` |
| `First` | `3` |
| `Last` | `4` |

**Underlying Type**: `System.Byte`

### `BlockReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.BlockReference` |
| **Base Type** | `Topomatic.Dwg.DwgObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Stg.IStgSerializable, Topomatic.Dwg.Smt.IResolvable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Smt.BlockReference`

#### Constructors (2)

- `.ctor(IDwgDatabase database)`
- `.ctor(IDwgDatabase database, UInt32 block)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Block` | `DwgBlock` | `get/set` | No | `` |
| `Database` | `IDwgDatabase` | `get` | No | `` |
| `ObjectName` | `String` | `get` | No | `` |
| `OriginalColor` | `CadColor` | `get/set` | No | `` |
| `OriginalLineweight` | `Lineweight` | `get/set` | No | `` |
| `OriginalName` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCopy` | `Void` | `DwgObject obj, ReferencesContext context` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.SaveToStg` |
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.LoadFromStg` |
| `IResolvable` | `Topomatic.Dwg.Smt.IResolvable.Copy` |

### `DesignStandards` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.DesignStandards` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Instance` | `DesignStandards` | `get/set` | Yes | `` |
| `LayerStandardsKeys` | `IEnumerable<String>` | `get` | No | `` |
| `TextStandardsKeys` | `IEnumerable<String>` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ActivateLayer` | `Boolean` | `Drawing drawing, String id` | `` |
| `ActivateTextStyle` | `Boolean` | `Drawing drawing, String id` | `` |
| `AddLayerStandard` | `LayerStandard` | `String id` | `` |
| `AddTextStandard` | `TextStandard` | `String id` | `` |
| `ClearLayers` | `Void` | `` | `` |
| `ClearTexts` | `Void` | `` | `` |
| `Clone` | `DesignStandards` | `` | `` |
| `GetDwgLayer` | `DwgLayer` | `Drawing drawing, String id` | `` |
| `GetLayerStandard` | `LayerStandard` | `String id` | `` |
| `GetOrCreateDwgLayer` | `DwgLayer` | `Drawing drawing, String id, Boolean defaultVisible, Boolean defaultEnable` | `` |
| `GetOrCreateDwgTextStyle` | `DwgStyle` | `Drawing drawing, TextStandard standard` | `` |
| `GetOrCreateTextStandard` | `TextStandard` | `String id` | `` |
| `GetTextStandard` | `TextStandard` | `String id` | `` |
| `LoadFromFile` | `Void` | `String filename` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToFile` | `Void` | `String filename` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `DesignStandards` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DwgConventionalSign`1<T where IResolvable, IStgSerializable, class, IResolvable, IStgSerializable>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.DwgConventionalSign`1` |
| **Base Type** | `Topomatic.Dwg.DwgNamedObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.FoundationClasses.INamedObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgNamedObject`
      - `Topomatic.Dwg.Smt.DwgConventionalSign`1`

#### Constructors (1)

- `.ctor(DwgConventionalSigns<T> owner, String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `ObjectName` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSatelites` | `IEnumerable<String>` | `` | `` |
| `OnCopy` | `Void` | `DwgObject obj, ReferencesContext context` | `` |
| `SelectConventionalSign` | `T` | `Double scale` | `` |
| `SelectConventionalSign` | `T` | `Double scale, String satelite` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.SaveToStg` |
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.LoadFromStg` |

### `DwgConventionalSigns`1<T where IResolvable, IStgSerializable, class, IResolvable, IStgSerializable>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.DwgConventionalSigns`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, , System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - ``
      - ``
        - `Topomatic.Dwg.Smt.DwgConventionalSigns`1`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `DwgConventionalSign<T>` | `String name, String description` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DwgSmtExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.DwgSmtExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAreaSign` | `AreaSign` | `ImDocument doc` | `Extension` |
| `GetLinearSign` | `LinearSign` | `ImDocument doc` | `Extension` |

### `IResolvable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.IResolvable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Copy` | `Void` | `Object obj, ReferencesContext context` | `` |

### `LayerStandard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LayerStandard` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Layer` | `String` | `get/set` | No | `` |
| `Lineweight` | `Lineweight` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `Drawing drawing` | `` |
| `Assign` | `Void` | `LayerStandard other` | `` |
| `GetDwgLayer` | `DwgLayer` | `Drawing drawing` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LinearSign` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LinearSign` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Dwg.Smt.IResolvable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Smt.OffsetedObject, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IDwgDatabase database)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `OffsetedObject` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAcadLinetype` | `AcadLinetype` | `LinetypePattern linetype, String name, String description` | `` |
| `AddBlockLinetype` | `BlockLinetype` | `DwgBlock block, String name, String description` | `` |
| `Assign` | `Void` | `LinearSign source` | `` |
| `Copy` | `Void` | `Object obj, ReferencesContext context` | `` |
| `GetEnumerator` | `IEnumerator<OffsetedObject>` | `` | `` |
| `IndexOf` | `Int32` | `OffsetedObject item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `OffsetedObject item` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetIndex` | `Void` | `OffsetedObject item, Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IResolvable` | `Copy` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `LinearSignCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LinearSignCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LinearSign pattern, IPolyline3D polyline, Double scale, Double rotation, CadColor layer, CadColor block, SemanticDataSet semantic)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `DwgBlock block` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |
| `Paint` | `Void` | `CadPen pen, Boolean displayLineweight, Boolean enable` | `` |

### `LinearSigns` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LinearSigns` |
| **Base Type** | `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Dwg.Smt.LinearSigns`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Syncronize` | `UInt32` | `LinearSignxLibraryNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinearSignxLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LinearSignxLibrary` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.LinearSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.LinearSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.LinearSignxLibrary`

#### Constructors (1)

- `.ctor(String environment)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `LinearSignxLibrary` | `get` | Yes | `` |
| `LibraryName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinearSignxLibraryNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LinearSignxLibraryNode` |
| **Base Type** | `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Smt.LinearSign, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.LinearSignxLibraryNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LinearSignDefaultTag` | `String` | Yes | `"LinearSign"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MapSignInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.MapSignInfo` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(xLibraryNode node)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Filename` | `String` | `get` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |
| `ScaleRelation` | `ScaleRelation` | `get/set` | No | `` |

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

### `MapSignxNode`1<T where IStgSerializable, class, IStgSerializable>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.MapSignxNode`1` |
| **Base Type** | `Topomatic.Libx.xLibraryNode` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Dwg.Smt.MapSignxNode`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SignsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSign` | `MapSignInfo` | `T data` | `` |
| `Assign` | `Void` | `MapSignxNode<T> node` | `` |
| `GetDefaultData` | `T` | `` | `` |
| `GetMapSignInfo` | `MapSignInfo` | `Int32 index` | `` |
| `GetSign` | `T` | `Int32 index` | `` |
| `RemoveSignAt` | `Void` | `Int32 index` | `` |
| `SelectSign` | `T` | `Double scale` | `` |
| `SetDefaultData` | `Void` | `T value` | `` |
| `SetSign` | `Void` | `Int32 index, T data` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `OffsetedObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.OffsetedObject` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IDwgDatabase database)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Database` | `IDwgDatabase` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `Offset` | `SemanticDependencyProperty` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `OffsetedObject source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PointSigns` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.PointSigns` |
| **Base Type** | `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.BlockReference, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.BlockReference, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.BlockReference, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Dwg.Smt.DwgConventionalSign`1[[Topomatic.Dwg.Smt.BlockReference, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Dwg.Smt.DwgConventionalSigns`1[[Topomatic.Dwg.Smt.BlockReference, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Dwg.Smt.PointSigns`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Syncronize` | `UInt32` | `PointSignxLibraryNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSignxLibrary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.PointSignxLibrary` |
| **Base Type** | `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.PointSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibrary, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryCollection`
    - `Topomatic.Libx.xLibraryCollection`1[[Topomatic.Dwg.Smt.PointSignxLibraryNode, Topomatic.Dwg.Smt, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.PointSignxLibrary`

#### Constructors (1)

- `.ctor(String environment)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `PointSignxLibrary` | `get` | Yes | `` |
| `LibraryName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSignxLibraryNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.PointSignxLibraryNode` |
| **Base Type** | `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Drawing, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[Topomatic.Libx.xLibraryNode, Topomatic.Libx, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Libx.xLibraryNode`
    - `Topomatic.Dwg.Smt.MapSignxNode`1[[Topomatic.Dwg.Drawing, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.Smt.PointSignxLibraryNode`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateMissingSign` | `Drawing` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MissingSignGuidBlockName` | `String` | Yes | `"MissingSign"` | `` |
| `PointSignDefaultTag` | `String` | Yes | `"PointSign"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleRelation` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.ScaleRelation` |
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
      - `Topomatic.Dwg.Smt.ScaleRelation`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Equal` | `ScaleRelation` | Yes | `Equal` | `` |
| `HigherOrEqual` | `ScaleRelation` | Yes | `HigherOrEqual` | `` |
| `LowerOrEqual` | `ScaleRelation` | Yes | `LowerOrEqual` | `` |
| `value__` | `Int16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Equal` | `0` |
| `LowerOrEqual` | `1` |
| `HigherOrEqual` | `2` |

**Underlying Type**: `System.Int16`

### `TextStandard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.TextStandard` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Filename` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Oblique` | `Double` | `get/set` | No | `` |
| `Ratio` | `Double` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Activate` | `Void` | `Drawing drawing` | `` |
| `Assign` | `Void` | `TextStandard other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Dwg.Smt.LayerLink`

### `ILayerLinksContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerLinks` | `LayerLinks` | `get` | No | `` |

### `LayerLinks` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Smt.LayerLink.LayerLinks` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Drawing drawing)`

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearDrawingLayer` | `Void` | `String name` | `` |
| `ClearDrawingLayers` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetLayer` | `DwgLayer` | `String standardName` | `` |
| `LayerInUse` | `Boolean` | `DwgLayer layer` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RefreshDrawingLayers` | `Void` | `` | `` |
| `RegisterDrawingLayer` | `Void` | `String standardName, Boolean defaultVisible, Boolean defaultEnable` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IDisposable` | `Dispose` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 30 |
| **Classes** | 22 |
| **Interfaces** | 2 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 3 |
| **Static Classes** | 1 |
| **Total Methods** | 92 |
| **Total Properties** | 61 |
| **Total Fields** | 15 |
| **Total Events** | 0 |
| **Total Constructors** | 28 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


