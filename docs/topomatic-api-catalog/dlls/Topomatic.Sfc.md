# Topomatic.Sfc

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sfc` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sfc.dll` |

---
## Namespace: `Topomatic.Sfc`

### `DirectrixFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.DirectrixFlags` |
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
      - `Topomatic.Sfc.DirectrixFlags`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `DirectrixFlags` | Yes | `None` | `` |
| `ThickOnly` | `DirectrixFlags` | Yes | `ThickOnly` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `ThickOnly` | `1` |

**Underlying Type**: `System.Byte`

### `ElevationBehaviour` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.ElevationBehaviour` |
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
      - `Topomatic.Sfc.ElevationBehaviour`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Absolute` | `ElevationBehaviour` | Yes | `Absolute` | `` |
| `Relative` | `ElevationBehaviour` | Yes | `Relative` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Relative` | `0` |
| `Absolute` | `1` |

**Underlying Type**: `System.Byte`

### `ExplorationCodeChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.ExplorationCodeChangedEventArgs` |
| **Base Type** | `Topomatic.FoundationClasses.Undo.IndexerEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.FoundationClasses.Undo.IndexerEventArgs`
      - `Topomatic.Sfc.ExplorationCodeChangedEventArgs`

#### Constructors (1)

- `.ctor(Int32 index, String code)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `String` | `get` | No | `` |

### `IEgContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.IEgContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EgSurfaces` | `IEnumerable<Surface>` | `get` | No | `` |

### `ISurfaceContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.ISurfaceContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Surface` | `Surface` | `get` | No | `` |

### `ITerrainModel` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.ITerrainModel` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IReferenceHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `PatchCodeModifyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PatchCodeModifyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.PatchCodeModifyEventArgs`

#### Constructors (1)

- `.ctor(SurfacePatch patch, Int32 oldValue)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OldValue` | `Int32` | `get` | No | `` |
| `Patch` | `SurfacePatch` | `get` | No | `` |

### `PatchFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PatchFlags` |
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
      - `Topomatic.Sfc.PatchFlags`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NoHorizontals` | `PatchFlags` | Yes | `NoHorizontals` | `` |
| `NoInclinations` | `PatchFlags` | Yes | `NoInclinations` | `` |
| `None` | `PatchFlags` | Yes | `None` | `` |
| `NoRibs` | `PatchFlags` | Yes | `NoRibs` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `NoHorizontals` | `1` |
| `NoRibs` | `2` |
| `NoInclinations` | `4` |

**Underlying Type**: `System.Byte`

### `PatchFlagsModifyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PatchFlagsModifyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.PatchFlagsModifyEventArgs`

#### Constructors (1)

- `.ctor(PatchFlags oldValue, PatchFlags newValue)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `NewValue` | `PatchFlags` | `get/set` | No | `` |
| `OldValue` | `PatchFlags` | `get/set` | No | `` |

### `PointCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointCell` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds2d` | `BoundingBox2D` | `get` | No | `` |
| `Bounds3d` | `BoundingBox3D` | `get/set` | No | `` |
| `Indexes` | `List<Int32>` | `get` | No | `` |
| `IsCell` | `Boolean` | `get` | No | `` |
| `SubCells` | `List<PointCell>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetIndexesCount` | `Int32` | `` | `` |

### `PointEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointEditor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Surface surface)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `SurfacePoint point` | `` |
| `Remove` | `Void` | `Int32 index` | `` |
| `SetValue` | `Void` | `Int32 index, SurfacePoint point` | `` |
| `SetVertex` | `Void` | `Int32 index, Vector3D vertex` | `` |
| `Transform` | `Void` | `IEnumerable<Int32> indexes, Matrix transform` | `` |

### `PointFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointFlags` |
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
      - `Topomatic.Sfc.PointFlags`

#### Fields (20)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DataFlags` | `PointFlags` | Yes | `DataFlags` | `` |
| `DataFlagsMask` | `PointFlags` | Yes | `DataFlagsMask` | `` |
| `Disable` | `PointFlags` | Yes | `Disable` | `` |
| `DrawLeader` | `PointFlags` | Yes | `DrawLeader` | `` |
| `Dynamic` | `PointFlags` | Yes | `Dynamic` | `` |
| `Extended` | `PointFlags` | Yes | `Extended` | `` |
| `Hidden` | `PointFlags` | Yes | `Hidden` | `` |
| `Highlighted` | `PointFlags` | Yes | `Highlighted` | `` |
| `Locked` | `PointFlags` | Yes | `Locked` | `` |
| `None` | `PointFlags` | Yes | `None` | `` |
| `Proxy` | `PointFlags` | Yes | `Proxy` | `` |
| `Removed` | `PointFlags` | Yes | `Removed` | `` |
| `Reserved1` | `PointFlags` | Yes | `Reserved1` | `` |
| `Reserved2` | `PointFlags` | Yes | `Reserved2` | `` |
| `Reserved3` | `PointFlags` | Yes | `Reserved3` | `` |
| `Selected` | `PointFlags` | Yes | `Selected` | `` |
| `Situation` | `PointFlags` | Yes | `Situation` | `` |
| `StatesCached` | `PointFlags` | Yes | `StatesCached` | `` |
| `Unconnected` | `PointFlags` | Yes | `Unconnected` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Situation` | `1` |
| `Extended` | `2` |
| `Locked` | `4` |
| `DrawLeader` | `8` |
| `Reserved1` | `16` |
| `DataFlags` | `31` |
| `Dynamic` | `32` |
| `Reserved2` | `64` |
| `Reserved3` | `128` |
| `DataFlagsMask` | `255` |
| `Highlighted` | `256` |
| `Hidden` | `512` |
| `Disable` | `1024` |
| `StatesCached` | `2048` |
| `Proxy` | `4096` |
| `Unconnected` | `8192` |
| `Removed` | `16384` |
| `Selected` | `32768` |

**Underlying Type**: `System.UInt16`

### `PointIndexer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointIndexer` |
| **Base Type** | `Topomatic.Sfc.PointCell` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.PointCell`
    - `Topomatic.Sfc.PointIndexer`

#### Constructors (1)

- `.ctor(Surface surface)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `Update` | `Void` | `` | `` |

### `PointModifyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointModifyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.PointModifyEventArgs`

#### Constructors (1)

- `.ctor(SurfacePoint oldValue, Int32 index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |
| `OldValue` | `SurfacePoint` | `get` | No | `` |

### `PointRemoveEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.PointRemoveEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.PointRemoveEventArgs`

#### Constructors (1)

- `.ctor(Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `SimpleArray`1<T where ValueType, struct, ValueType>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SimpleArray`1` |
| **Base Type** | `` |
| **Implements** | `, , , System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, , ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Sfc.SimpleArray`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromFile` | `Void` | `String path` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToFile` | `Void` | `String path` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StructureLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.StructureLine` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.StructureLineNode, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Sfc.StructureLineNode, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Sfc.StructureLineNode, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Sfc.ISurfaceContainer, System.IEquatable`1[[Topomatic.Sfc.StructureLine, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (25)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaCode` | `Int32` | `get/set` | No | `` |
| `AreaDataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `AreaSemantic` | `SemanticDataSet` | `get` | No | `` |
| `AreaSign` | `UInt32` | `get/set` | No | `` |
| `Bounds2d` | `BoundingBox2D` | `get` | No | `` |
| `Bounds3d` | `BoundingBox3D` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Density` | `Int32` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `ElevationBehaviour` | `ElevationBehaviour` | `get/set` | No | `` |
| `IsClosed` | `Boolean` | `get/set` | No | `` |
| `IsLimitation` | `Boolean` | `get/set` | No | `` |
| `IsPolygon` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSituation` | `Boolean` | `get/set` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `StructureLineNode` | `get/set` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `LinearCode` | `Int32` | `get/set` | No | `` |
| `LinearDataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `LinearSemantic` | `SemanticDataSet` | `get` | No | `` |
| `LinearSign` | `UInt32` | `get/set` | No | `` |
| `Surface` | `Surface` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Uid` | `Int32` | `get/set` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Int32 index` | `` |
| `Add` | `Void` | `StructureLineNode item` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `Contains` | `Boolean` | `Int32 index` | `` |
| `Contains` | `Boolean` | `StructureLineNode item` | `` |
| `CopyProperty` | `Void` | `StructureLine source` | `` |
| `CopyTo` | `Void` | `StructureLineNode[] array, Int32 arrayIndex` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `StructureLine other` | `` |
| `GetEnumerator` | `IEnumerator<StructureLineNode>` | `` | `` |
| `GetPosition` | `Vector3D` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `StructureLineNode item` | `` |
| `Insert` | `Void` | `Int32 index, StructureLineNode item` | `` |
| `Remove` | `Boolean` | `StructureLineNode item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `ToPolyline` | `Void` | `IList<Vector3D> polyline` | `` |
| `ToPolyline` | `List<Vector3D>` | `` | `` |

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
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ISurfaceContainer` | `get_Surface` |
| `IEquatable`1` | `Equals` |
| `ICloneable` | `Clone` |

### `StructureLineFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.StructureLineFlags` |
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
      - `Topomatic.Sfc.StructureLineFlags`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Closed` | `StructureLineFlags` | Yes | `Closed` | `` |
| `Situation` | `StructureLineFlags` | Yes | `Situation` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Closed` | `1` |
| `Situation` | `2` |

**Underlying Type**: `System.Byte`

### `StructureLineNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.StructureLineNode` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Sfc.StructureLineNode, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.StructureLineNode`

#### Constructors (2)

- `.ctor(Int32 index)`
- `.ctor(Int32 index, Double elevation)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `StructureLineNode other` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Elevation` | `Double` | No | `` | `` |
| `Index` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `StructureLines` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.StructureLines` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.StructureLine, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `StructureLine` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `StructureLine line` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Contains` | `Boolean` | `StructureLine item` | `` |
| `CopyTo` | `Void` | `StructureLine[] array, Int32 arrayIndex` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<StructureLine>` | `` | `` |
| `IndexOf` | `Int32` | `StructureLine item` | `` |
| `Remove` | `Boolean` | `StructureLine item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Events (5)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AddLine` | `EventHandler<IndexerEventArgs>` | No | `` |
| `AddNode` | `EventHandler<IndexerEventArgs>` | No | `` |
| `ModifyLine` | `EventHandler` | No | `` |
| `RemoveLine` | `EventHandler<IndexerEventArgs>` | No | `` |
| `RemoveNode` | `EventHandler<IndexerEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ISurfaceContainer` | `get_Surface` |

### `Surface` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Surface` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Sfc.ISurfaceContainer, System.IDisposable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.IElevationProvider, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Sfc.Surface`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Object owner, Boolean emptyTransactionManager)`

#### Properties (25)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSigns` | `AreaSigns` | `get` | No | `` |
| `Bounds2d` | `BoundingBox2D` | `get` | No | `` |
| `Bounds3d` | `BoundingBox3D` | `get` | No | `` |
| `Code` | `Int32` | `get/set` | No | `` |
| `Codifier` | `String` | `get/set` | No | `` |
| `Designed` | `Boolean` | `get/set` | No | `` |
| `Groups` | `SurfacePointsGroupArray` | `get` | No | `` |
| `HachureDirectrix` | `SurfaceDirectrixArray` | `get` | No | `` |
| `Hidden` | `Boolean` | `get/set` | No | `` |
| `HorizontalDirectrix` | `SurfaceDirectrixArray` | `get` | No | `` |
| `LayersMapping` | `IDictionary<String UInt32>` | `get` | No | `` |
| `LinearSigns` | `LinearSigns` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Patchs` | `SurfacePatchArray` | `get` | No | `` |
| `PointIndexer` | `PointIndexer` | `get` | No | `` |
| `Points` | `SurfacePointArray` | `get` | No | `` |
| `PointSigns` | `PointSigns` | `get` | No | `` |
| `ProxySourceProviders` | `ProxySourceProviderCollection` | `get` | No | `` |
| `Situation` | `Drawing` | `get` | No | `` |
| `StructureLines` | `StructureLines` | `get` | No | `` |
| `Style` | `SurfaceStyle` | `get` | No | `` |
| `SurfaceState` | `SurfaceState` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `TriangleIndexer` | `TriangleIndexer` | `get` | No | `` |
| `Triangles` | `SurfaceTriangleArray` | `get` | No | `` |

#### Instance Methods (35)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `CheckConnectivity` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `ClearTriangulation` | `Void` | `` | `` |
| `Clone` | `Surface` | `` | `` |
| `CreateSection` | `Section` | `IList<Vector2D> polyline, SectionFlags flags` | `` |
| `CreateSection` | `Void` | `IList<Vector2D> polyline, IList<SectionNode> section, SectionFlags flags` | `` |
| `CreateSections` | `List<IList<SectionNode>>` | `IList<Vector2D> polyline, SectionFlags flags` | `` |
| `CreateSections` | `List<IList<Vector3D>>` | `Vector3D a, Vector3D b, Vector3D c` | `` |
| `Dispose` | `Void` | `` | `` |
| `FindPoint` | `Int32` | `Vector2D point, Double eps` | `` |
| `FindPoints` | `Void` | `BoundingBox2D box, List<Int32> list, Predicate<Int32> match` | `` |
| `FindPoints` | `Void` | `BoundingBox2D box, List<Int32> list` | `` |
| `FindPoints` | `Void` | `BoundingBox2D box, List<Int32> list, Int32 maximum` | `` |
| `FindPoints` | `Void` | `BoundingFrustum frustum, List<KeyValuePair<Vector3D Int32>> list` | `` |
| `FindPoints` | `Void` | `BoundingBox2D box, List<Int32> list, Predicate<Int32> match, Int32 maximum` | `` |
| `FindTriangle` | `Int32` | `Vector2D point` | `` |
| `FindTriangles` | `Void` | `BoundingBox2D box, List<Int32> list` | `` |
| `FindTriangles` | `Void` | `BoundingBox2D box, List<Int32> list, Int32 maximum` | `` |
| `FindTriangles` | `Void` | `BoundingBox2D box, List<Int32> list, Predicate<Int32> match` | `` |
| `FindTriangles` | `Void` | `Vector3D a, Vector3D b, Vector3D c, List<Int32> list` | `` |
| `FindTriangles` | `Void` | `Ray3D ray, List<KeyValuePair<Double Int32>> list` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D point` | `` |
| `Invalidate` | `Void` | `` | `` |
| `Invalidate` | `Void` | `Boolean noundo` | `` |
| `LoadFromFile` | `Void` | `String path` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `Regen` | `Void` | `` | `` |
| `SaveToFileSfc` | `Void` | `String path, UInt16 version` | `` |
| `SaveToFileSfc` | `Void` | `String path` | `` |
| `SaveToFileSfcx` | `Void` | `String path` | `` |
| `SaveToStreamSfc` | `Void` | `Stream stream` | `` |
| `SaveToStreamSfc` | `Void` | `Stream stream, UInt16 version` | `` |
| `SaveToStreamSfcx` | `Void` | `Stream stream` | `` |
| `SaveToStreamSfcx` | `Void` | `Stream stream, UInt16 version` | `` |

#### Events (17)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Invalidated` | `EventHandler` | No | `` |
| `LoadFromStg` | `StgDocumentOperationEventHandler` | No | `` |
| `PatchFlagsModify` | `EventHandler<PatchFlagsModifyEventArgs>` | No | `` |
| `PatchModify` | `EventHandler<IndexerEventArgs>` | No | `` |
| `PatchSemanticModify` | `EventHandler<SurfaceSemanticModify>` | No | `` |
| `PointAdd` | `EventHandler<IndexerEventArgs>` | No | `` |
| `PointCodeChanged` | `EventHandler<IndexerEventArgs>` | No | `` |
| `PointExplorationCodeChanged` | `EventHandler<ExplorationCodeChangedEventArgs>` | No | `` |
| `PointLayerChanged` | `EventHandler<IndexerEventArgs>` | No | `` |
| `PointModify` | `EventHandler<PointModifyEventArgs>` | No | `` |
| `PointRemoved` | `EventHandler<PointRemoveEventArgs>` | No | `` |
| `PointSemanticModify` | `EventHandler<SurfaceSemanticModify>` | No | `` |
| `PointSignChanged` | `EventHandler<IndexerEventArgs>` | No | `` |
| `SaveToStg` | `StgDocumentOperationEventHandler` | No | `` |
| `TriangleAdd` | `EventHandler<IndexerEventArgs>` | No | `` |
| `TriangleModify` | `EventHandler<TriangleModifyEventArgs>` | No | `` |
| `TriangleRemoved` | `EventHandler<TriangleRemoveEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `ISurfaceContainer` | `Topomatic.Sfc.ISurfaceContainer.get_Surface` |
| `IDisposable` | `Dispose` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IElevationProvider` | `GetElevation` |
| `IDrawingContainer` | `Topomatic.Dwg.IDrawingContainer.get_Drawing` |

### `SurfaceDirectrix` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceDirectrix` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IEquatable`1[[Topomatic.Sfc.SurfaceDirectrix, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndPoint` | `Vector2D` | `get` | No | `` |
| `Flags` | `DirectrixFlags` | `get` | No | `` |
| `StartPoint` | `Vector2D` | `get` | No | `` |
| `ThickOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SurfaceDirectrix other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `SurfaceDirectrixArray` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceDirectrixArray` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.SurfaceDirectrix, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `SurfaceDirectrix` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `SurfaceDirectrix` | `Vector2D a, Vector2D b, DirectrixFlags flags` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<SurfaceDirectrix>` | `` | `` |
| `Remove` | `Boolean` | `SurfaceDirectrix directrix` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AddDirectrix` | `EventHandler` | No | `` |
| `RemoveDirectrix` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ISurfaceContainer` | `get_Surface` |

### `SurfacePatch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePatch` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, System.IEquatable`1[[Topomatic.Sfc.SurfacePatch, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `DataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `Density` | `Int32` | `get/set` | No | `` |
| `Flags` | `PatchFlags` | `get/set` | No | `` |
| `Handle` | `Int32` | `get/set` | No | `` |
| `IsNoHorizontals` | `Boolean` | `get/set` | No | `` |
| `IsNoInclinations` | `Boolean` | `get/set` | No | `` |
| `IsNoRibs` | `Boolean` | `get/set` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `Sign` | `UInt32` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `CopyProperty` | `Void` | `SurfacePatch source` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `SurfacePatch other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |
| `IEquatable`1` | `Equals` |
| `ISurfaceContainer` | `get_Surface` |

### `SurfacePatchArray` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePatchArray` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.SurfacePatch, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.SurfacePatch, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `SurfacePatch` | `get/set` | No | `` |
| `Keys` | `ICollection<Int32>` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Values` | `ICollection<SurfacePatch>` | `get` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KeyValuePair<Int32 SurfacePatch> item` | `` |
| `Add` | `SurfacePatch` | `` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KeyValuePair<Int32 SurfacePatch> item` | `` |
| `ContainsKey` | `Boolean` | `Int32 key` | `` |
| `CopyTo` | `Void` | `KeyValuePair<Int32 SurfacePatch>[] array, Int32 arrayIndex` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetContours` | `Void` | `Int32 handle, List<IList<Int32>> contours` | `` |
| `GetContours` | `Void` | `Int32 handle, List<List<Vector3D>> contours` | `` |
| `GetContours` | `Void` | `List<IList<Int32>> contours, List<Int32> indexes` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Int32 SurfacePatch>>` | `` | `` |
| `GetTriangles` | `Void` | `Int32 handle, List<Int32> list` | `` |
| `Remove` | `Boolean` | `Int32 handle` | `` |
| `Remove` | `Boolean` | `KeyValuePair<Int32 SurfacePatch> item` | `` |
| `TryGetValue` | `Boolean` | `Int32 handle, ref SurfacePatch value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `ISurfaceContainer` | `get_Surface` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |

### `SurfacePoint` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePoint` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Sfc.SurfacePoint, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.SurfacePoint`

#### Constructors (1)

- `.ctor(Vector3D vertex)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `ExplorationCode` | `String` | `get` | No | `` |
| `HasExtensiveInformation` | `Boolean` | `get` | No | `` |
| `IsDrawLeader` | `Boolean` | `get/set` | No | `` |
| `IsDynamic` | `Boolean` | `get/set` | No | `` |
| `IsExtended` | `Boolean` | `get/set` | No | `` |
| `IsHighlighted` | `Boolean` | `get/set` | No | `` |
| `IsLocked` | `Boolean` | `get/set` | No | `` |
| `IsProxy` | `Boolean` | `get/set` | No | `` |
| `IsRemoved` | `Boolean` | `get` | No | `` |
| `IsSelected` | `Boolean` | `get/set` | No | `` |
| `IsSituation` | `Boolean` | `get/set` | No | `` |
| `IsUnconnected` | `Boolean` | `get/set` | No | `` |
| `Layer` | `UInt32` | `get` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `Rotation` | `Double` | `get` | No | `` |
| `Scale` | `Double` | `get` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `Sign` | `UInt32` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `SurfacePoint` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `SurfacePoint other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetStringMoveing` | `Void` | `Int32 index, ref Double x, ref Double y, ref Double r, ref Boolean visible` | `` |
| `GetStringMoveing` | `Void` | `Int32 index, ref Double x, ref Double y, ref Double r` | `` |
| `HasSemantic` | `Boolean` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Flags` | `PointFlags` | No | `` | `` |
| `Vertex` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SurfacePointArray` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePointArray` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Capacity` | `Int32` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SurfacePoint` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SurfacePoint item` | `` |
| `Clear` | `Void` | `` | `` |
| `ConnectPoints` | `Void` | `` | `` |
| `GenerateHoles` | `Void` | `` | `` |
| `GetExtensiveInformation` | `SurfacePointExtensiveInformation` | `Int32 index` | `` |
| `GetNotRemovedCount` | `Int32` | `` | `` |
| `IsEmpty` | `Boolean` | `` | `` |
| `IsRemovedExists` | `Boolean` | `` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetExtensiveInformation` | `SurfacePointExtensiveInformation` | `ref SurfacePoint point` | `` |

### `SurfacePointExtensiveInformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePointExtensiveInformation` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Sfc.SurfacePointExtensiveInformation, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sfc.SurfacePointExtensiveInformation`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `DataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `ExplorationCode` | `String` | `get/set` | No | `` |
| `IsDataHolderEmpty` | `Boolean` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `NumberDescription` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `Sign` | `UInt32` | `get/set` | No | `` |
| `StringMoveingCount` | `Int32` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SurfacePointExtensiveInformation other` | `` |
| `Clone` | `Object` | `` | `` |
| `Copy` | `Void` | `SurfacePointExtensiveInformation other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `SurfacePointExtensiveInformation other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetStringMoveing` | `Void` | `Int32 index, ref Double x, ref Double y, ref Double r, ref Boolean visible` | `` |
| `GetStringMoveing` | `Void` | `Int32 index, ref Double x, ref Double y, ref Double r` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetStringMoveing` | `Void` | `Int32 index, Double x, Double y, Double r, Boolean visible` | `` |
| `SetStringMoveing` | `Void` | `Int32 index, Double x, Double y, Double r` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICloneable` | `Clone` |

### `SurfacePointsGroup` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePointsGroup` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, System.IEquatable`1[[Topomatic.Sfc.SurfacePointsGroup, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Handle` | `Int32` | `get/set` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `CopyProperty` | `Void` | `SurfacePointsGroup source` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `SurfacePointsGroup other` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |
| `IEquatable`1` | `Equals` |
| `ISurfaceContainer` | `get_Surface` |

### `SurfacePointsGroupArray` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfacePointsGroupArray` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.SurfacePointsGroup, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.SurfacePointsGroup, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `SurfacePointsGroup` | `get/set` | No | `` |
| `Keys` | `ICollection<Int32>` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Values` | `ICollection<SurfacePointsGroup>` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KeyValuePair<Int32 SurfacePointsGroup> item` | `` |
| `Add` | `SurfacePointsGroup` | `String name` | `` |
| `Add` | `SurfacePointsGroup` | `` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KeyValuePair<Int32 SurfacePointsGroup> item` | `` |
| `ContainsKey` | `Boolean` | `Int32 key` | `` |
| `CopyTo` | `Void` | `KeyValuePair<Int32 SurfacePointsGroup>[] array, Int32 arrayIndex` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Int32 SurfacePointsGroup>>` | `` | `` |
| `Remove` | `Boolean` | `Int32 handle` | `` |
| `Remove` | `Boolean` | `KeyValuePair<Int32 SurfacePointsGroup> item` | `` |
| `TryGetValue` | `Boolean` | `Int32 handle, ref SurfacePointsGroup value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `ISurfaceContainer` | `get_Surface` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |

### `SurfaceSemanticModify` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceSemanticModify` |
| **Base Type** | `Topomatic.Smt.DataSetModifyEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Smt.DataSetModifyEventArgs`
      - `Topomatic.Sfc.SurfaceSemanticModify`

#### Constructors (1)

- `.ctor(Int32 index, SemanticNode node, Object oldValue, Object newValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `SurfaceState` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceState` |
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
      - `Topomatic.Sfc.SurfaceState`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HasUnconnectedPoints` | `SurfaceState` | Yes | `HasUnconnectedPoints` | `` |
| `None` | `SurfaceState` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `HasUnconnectedPoints` | `1` |

**Underlying Type**: `System.Int32`

### `SurfaceTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPointToTriangulation` | `Void` | `Surface surface, Int32 pointIndex` | `` |
| `CheckStructureLinesCross` | `Void` | `Surface surface, Int32 index` | `` |
| `CheckStructureLinesCross` | `Int64` | `Surface surface, ProgressChangedEventHandler progress` | `` |
| `DoubleToString` | `String` | `Double value` | `` |
| `DoubleToStringNoTrim` | `String` | `Double value, Int32 digits` | `` |
| `GetExternalRibs` | `Void` | `Surface surface, List<Edge> edges` | `` |
| `GetExternalRibs` | `Void` | `Surface surface, List<Edge> edges, Dictionary<Edge Boolean> temporary` | `` |
| `GetEz` | `Double` | `Surface surface, Vector2D pt` | `` |
| `GetLimitationDictionary` | `IDictionary<Edge Int32>` | `Surface surface` | `` |
| `GetLinkedTriangle` | `Int32` | `Surface surface, Int32 a, Int32 b, List<Int32> temporary, Int32 except` | `` |
| `InsertOverPoints` | `Void` | `StructureLine line` | `` |
| `InsertOverPoints` | `Void` | `Surface surface, ProgressChangedEventHandler progress` | `` |
| `IsTriangleCrossedSegment` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c, Vector2D pos1, Vector2D pos2` | `` |
| `MergeSurfaces` | `Void` | `Surface result, Surface bottom, Surface upper, Double slope, Boolean smooth` | `` |
| `ParsePointTags` | `String` | `SurfacePoint point, Int32 digits, Boolean trimzero, String tag, Nullable<Double> ez` | `` |
| `ParsePointTags` | `String` | `SurfacePoint point, PointsStyle style, String tag, Nullable<Double> ez` | `` |
| `RemoveLimitations` | `Void` | `StructureLine line` | `` |
| `RemovePointFromTriangulation` | `Void` | `Surface surface, Int32 index` | `` |
| `RemoveStructureLine` | `Void` | `Surface surface, Int32 index` | `` |
| `RemoveStructureLine` | `Void` | `Surface surface, Int32 index, Boolean keepUsedDynamics` | `` |
| `UpdateLimitations` | `Void` | `StructureLine line` | `` |
| `UpdateLimitations` | `Void` | `Surface surface, Int32 aIndex, Int32 bIndex` | `` |
| `UpdateTriangulationUnderPoint` | `Void` | `Surface surface, Int32 index` | `` |

### `SurfaceTriangle` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceTriangle` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.SurfaceTriangle`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsRemoved` | `Boolean` | `get` | No | `` |
| `IsSelected` | `Boolean` | `get/set` | No | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `Int32` | No | `` | `` |
| `B` | `Int32` | No | `` | `` |
| `C` | `Int32` | No | `` | `` |
| `Flags` | `TriangleFlags` | No | `` | `` |
| `Patch` | `Int32` | No | `` | `` |

### `SurfaceTriangleArray` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.SurfaceTriangleArray` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Surface surface)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Capacity` | `Int32` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SurfaceTriangle` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SurfaceTriangle item` | `` |
| `Clear` | `Void` | `` | `` |
| `GetNotRemovedCount` | `Int32` | `` | `` |
| `IsEmpty` | `Boolean` | `` | `` |
| `IsRemovedExists` | `Boolean` | `` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `TrimExcess` | `Void` | `` | `` |

### `TriangleCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleCell` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds2d` | `BoundingBox2D` | `get` | No | `` |
| `Bounds3d` | `BoundingBox3D` | `get/set` | No | `` |
| `Indexes` | `List<Int32>` | `get` | No | `` |
| `IsCell` | `Boolean` | `get` | No | `` |
| `SubCells` | `List<TriangleCell>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetIndexesCount` | `Int32` | `` | `` |
| `UpdateBounds` | `Void` | `` | `` |

### `TriangleEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleEditor` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Surface surface)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `SurfaceTriangle triangle` | `` |
| `OnAdd` | `Void` | `Int32 index, SurfaceTriangle triangle` | `` |
| `Remove` | `Void` | `Int32 index` | `` |
| `SetValue` | `Void` | `Int32 index, SurfaceTriangle triangle` | `` |

### `TriangleFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleFlags` |
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
      - `Topomatic.Sfc.TriangleFlags`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `TriangleFlags` | Yes | `None` | `` |
| `Removed` | `TriangleFlags` | Yes | `Removed` | `` |
| `Selected` | `TriangleFlags` | Yes | `Selected` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Removed` | `16384` |
| `Selected` | `32768` |

**Underlying Type**: `System.UInt16`

### `TriangleIndexer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleIndexer` |
| **Base Type** | `Topomatic.Sfc.TriangleCell` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.TriangleCell`
    - `Topomatic.Sfc.TriangleIndexer`

#### Constructors (1)

- `.ctor(Surface surface)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `Update` | `Void` | `` | `` |

### `TriangleModifyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleModifyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.TriangleModifyEventArgs`

#### Constructors (1)

- `.ctor(SurfaceTriangle oldValue, Int32 index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |
| `OldValue` | `SurfaceTriangle` | `get` | No | `` |

### `TriangleRemoveEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.TriangleRemoveEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.TriangleRemoveEventArgs`

#### Constructors (1)

- `.ctor(Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `UnsupportedArrayVersionException` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.UnsupportedArrayVersionException` |
| **Base Type** | `System.InvalidOperationException` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `System.SystemException`
      - `System.InvalidOperationException`
        - `Topomatic.Sfc.UnsupportedArrayVersionException`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String message)`
- `.ctor(String message, Exception inner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Sfc.Entites`

### `ISurfaceProxyEntity` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Entites.ISurfaceProxyEntity` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SurfaceModified` | `Void` | `` | `` |

---
## Namespace: `Topomatic.Sfc.Proxy`

### `FileProxySourceProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.FileProxySourceProvider` |
| **Base Type** | `Topomatic.Sfc.Proxy.ProxySourceProvider` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.Proxy.ProxyMoniker, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.Undo.INamedTransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxySourceProvider`
    - `Topomatic.Sfc.Proxy.FileProxySourceProvider`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GuidMoniker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.GuidMoniker` |
| **Base Type** | `Topomatic.Sfc.Proxy.ProxyMoniker` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxyMoniker`
    - `Topomatic.Sfc.Proxy.GuidMoniker`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Guid` | `Guid` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GuidProxySourceProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.GuidProxySourceProvider` |
| **Base Type** | `Topomatic.Sfc.Proxy.ProxySourceProvider` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.Proxy.ProxyMoniker, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.Undo.INamedTransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxySourceProvider`
    - `Topomatic.Sfc.Proxy.GuidProxySourceProvider`

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

### `ProviderEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.ProviderEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Sfc.Proxy.ProviderEventArgs`

#### Constructors (1)

- `.ctor(ProxySourceProvider provider)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Provider` | `ProxySourceProvider` | `get` | No | `` |

### `ProxyMoniker` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.ProxyMoniker` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

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

### `ProxySourceProvider` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.ProxySourceProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.Proxy.ProxyMoniker, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.Undo.INamedTransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsConnected` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get/set` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `ProxyMoniker` | `get/set` | No | `` |
| `SourceCollection` | `ProxySourceProviderCollection` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `Uid` | `Guid` | `get` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `ProxyMoniker moniker` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `ContainsKey` | `Boolean` | `Int32 id` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Int32 ProxyMoniker>>` | `` | `` |
| `GetSupportedMonikers` | `IEnumerable<ProxyMoniker>` | `` | `` |
| `InvokeUpdate` | `Void` | `ProxyMoniker moniker` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Synchronize` | `Void` | `` | `` |
| `TryGetID` | `Boolean` | `ProxyMoniker moniker, ref Int32 id` | `` |
| `TryGetValue` | `Boolean` | `Int32 id, ref ProxyMoniker moniker` | `` |
| `TryUpdateValue` | `Boolean` | `Int32 id, ref SurfacePoint point, SurfacePointExtensiveInformation information` | `` |
| `Update` | `Void` | `ProxyMoniker moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `ITransactable` | `get_TransactionManager` |
| `INamedTransactable` | `BeginUpdate` |

### `ProxySourceProviderCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.ProxySourceProviderCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.Proxy.ProxySourceProvider, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ProxySourceProvider>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RegisterProvider` | `Void` | `ProxySourceProvider provider` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Synchronize` | `Void` | `` | `` |
| `UnregisterProvider` | `Void` | `ProxySourceProvider provider` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterAdd` | `EventHandler<ProviderEventArgs>` | No | `` |
| `BeforeRemove` | `EventHandler<ProviderEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IDisposable` | `Dispose` |

### `TextFileMoniker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.TextFileMoniker` |
| **Base Type** | `Topomatic.Sfc.Proxy.ProxyMoniker` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxyMoniker`
    - `Topomatic.Sfc.Proxy.TextFileMoniker`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `Int32` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TextFileSourceProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Proxy.TextFileSourceProvider` |
| **Base Type** | `Topomatic.Sfc.Proxy.ProxySourceProvider` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.Proxy.ProxyMoniker, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.Undo.INamedTransactable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxySourceProvider`
    - `Topomatic.Sfc.Proxy.TextFileSourceProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Filename` | `String` | `get/set` | No | `` |
| `IsConnected` | `Boolean` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSupportedMonikers` | `IEnumerable<ProxyMoniker>` | `` | `` |
| `Initialize` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Synchronize` | `Void` | `` | `` |
| `TryUpdateValue` | `Boolean` | `Int32 id, ref SurfacePoint point, SurfacePointExtensiveInformation information` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Sfc.Sections`

### `Section` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Sections.Section` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.Sections.SectionNode, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IEnumerable<SectionNode> collection, Int32 code)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `EpsilonX` | `Double` | `get/set` | No | `` |
| `EpsilonY` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<SectionNode>` | `` | `` |
| `SourceLine` | `IEnumerable<SectionNode>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SectionFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Sections.SectionFlags` |
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
      - `Topomatic.Sfc.Sections.SectionFlags`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `SectionFlags` | Yes | `Default` | `` |
| `FilterRibs` | `SectionFlags` | Yes | `FilterRibs` | `` |
| `FilterStructureLines` | `SectionFlags` | Yes | `FilterStructureLines` | `` |
| `IncludeHiddenPatches` | `SectionFlags` | Yes | `IncludeHiddenPatches` | `` |
| `InsertEnds` | `SectionFlags` | Yes | `InsertEnds` | `` |
| `None` | `SectionFlags` | Yes | `None` | `` |
| `OnlyStrucLines` | `SectionFlags` | Yes | `OnlyStrucLines` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `InsertEnds` | `1` |
| `OnlyStrucLines` | `2` |
| `FilterRibs` | `8` |
| `Default` | `9` |
| `FilterStructureLines` | `16` |
| `IncludeHiddenPatches` | `32` |

**Underlying Type**: `System.Int32`

### `SectionNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Sections.SectionNode` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sfc.Sections.SectionNode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `DataHolder` | `SemanticDataHolder` | No | `` | `` |
| `Source` | `SectionNodeSource` | No | `` | `` |
| `Vertex` | `Vector2D` | No | `` | `` |

### `SectionNodeSource` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Sections.SectionNodeSource` |
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
      - `Topomatic.Sfc.Sections.SectionNodeSource`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Other` | `SectionNodeSource` | Yes | `Other` | `` |
| `Patch` | `SectionNodeSource` | Yes | `Patch` | `` |
| `Projection` | `SectionNodeSource` | Yes | `Projection` | `` |
| `Rib` | `SectionNodeSource` | Yes | `Rib` | `` |
| `StructureLine` | `SectionNodeSource` | Yes | `StructureLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Other` | `0` |
| `StructureLine` | `1` |
| `Rib` | `2` |
| `Patch` | `3` |
| `Projection` | `4` |

**Underlying Type**: `System.Int32`

### `SectionsLinker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Sections.SectionsLinker` |
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
| `Link` | `Void` | `IList<IList<SectionNode>> sourceSections, IList<SectionNode> destSection` | `` |

---
## Namespace: `Topomatic.Sfc.Style`

### `AdditionalHorizontal` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.AdditionalHorizontal` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Int32` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `Style` | `AdditionalHorizontalStyle` | `get/set` | No | `` |
| `Width` | `Single` | `get/set` | No | `` |

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

### `AdditionalHorizontalList` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.AdditionalHorizontalList` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Sfc.Style.AdditionalHorizontal, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Sfc.Style.AdditionalHorizontal, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Sfc.Style.AdditionalHorizontal, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `AdditionalHorizontal` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `AdditionalHorizontal item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `AdditionalHorizontal item` | `` |
| `CopyTo` | `Void` | `AdditionalHorizontal[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<AdditionalHorizontal>` | `` | `` |
| `IndexOf` | `Int32` | `AdditionalHorizontal item` | `` |
| `Insert` | `Void` | `Int32 index, AdditionalHorizontal item` | `` |
| `Remove` | `Boolean` | `AdditionalHorizontal item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

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

### `AdditionalHorizontalStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.AdditionalHorizontalStyle` |
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
      - `Topomatic.Sfc.Style.AdditionalHorizontalStyle`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Additional` | `AdditionalHorizontalStyle` | Yes | `Additional` | `` |
| `Auxiliary` | `AdditionalHorizontalStyle` | Yes | `Auxiliary` | `` |
| `Overhang` | `AdditionalHorizontalStyle` | Yes | `Overhang` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Additional` | `1` |
| `Auxiliary` | `2` |
| `Overhang` | `3` |

**Underlying Type**: `System.Int32`

### `CommonStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.CommonStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.CommonStyle`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowElevationHint` | `Boolean` | `get/set` | No | `` |
| `ShowInclinationHint` | `Boolean` | `get/set` | No | `` |
| `ShowLinesHint` | `Boolean` | `get/set` | No | `` |
| `ShowPatchesHint` | `Boolean` | `get/set` | No | `` |
| `ShowPointsHint` | `Boolean` | `get/set` | No | `` |
| `TgFilterAngle` | `Double` | `get/set` | No | `` |

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

### `HorizontalSmoothing` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.HorizontalSmoothing` |
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
      - `Topomatic.Sfc.Style.HorizontalSmoothing`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `HorizontalSmoothing` | Yes | `None` | `` |
| `Polyline` | `HorizontalSmoothing` | Yes | `Polyline` | `` |
| `Spline` | `HorizontalSmoothing` | Yes | `Spline` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Spline` | `1` |
| `Polyline` | `2` |

**Underlying Type**: `System.Int32`

### `HorizontalsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.HorizontalsStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.HorizontalsStyle`

#### Properties (33)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalHorizontals` | `AdditionalHorizontalList` | `get` | No | `` |
| `AdditionalVisible` | `Boolean` | `get/set` | No | `` |
| `AuxiliaryVisible` | `Boolean` | `get/set` | No | `` |
| `BaseElevation` | `Double` | `get/set` | No | `` |
| `Digits` | `Int32` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `FontName` | `String` | `get/set` | No | `` |
| `HachureLength` | `Single` | `get/set` | No | `` |
| `HachureTextAbove` | `Boolean` | `get/set` | No | `` |
| `InclinationFilter` | `Single` | `get/set` | No | `` |
| `KeepHorizontalsLayerVisible` | `Boolean` | `get/set` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `MaximumTrianglesCount` | `Int32` | `get/set` | No | `` |
| `OverhangVisible` | `Boolean` | `get/set` | No | `` |
| `Smoothing` | `HorizontalSmoothing` | `get/set` | No | `` |
| `SmoothingFactor` | `Int32` | `get/set` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |
| `SupportInclinationsFilter` | `Boolean` | `get/set` | No | `` |
| `TextAbove` | `Boolean` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |
| `TextOblique` | `Single` | `get/set` | No | `` |
| `TextRatio` | `Single` | `get/set` | No | `` |
| `TextVisible` | `Boolean` | `get/set` | No | `` |
| `ThickColor` | `Int32` | `get/set` | No | `` |
| `ThickDivider` | `Int32` | `get/set` | No | `` |
| `ThickVisible` | `Boolean` | `get/set` | No | `` |
| `ThickWidth` | `Single` | `get/set` | No | `` |
| `ThinColor` | `Int32` | `get/set` | No | `` |
| `ThinVisible` | `Boolean` | `get/set` | No | `` |
| `ThinWidth` | `Single` | `get/set` | No | `` |
| `TrimIntegers` | `Boolean` | `get/set` | No | `` |
| `TrimZeros` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `DwgLayer` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `InclinationsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.InclinationsStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.InclinationsStyle`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrowSize` | `Single` | `get/set` | No | `` |
| `ArrowSizeDependent` | `Boolean` | `get/set` | No | `` |
| `BlueColor` | `Int32` | `get/set` | No | `` |
| `BlueVisible` | `Boolean` | `get/set` | No | `` |
| `Digits` | `Int32` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `FontName` | `String` | `get/set` | No | `` |
| `GreenColor` | `Int32` | `get/set` | No | `` |
| `GreenVisible` | `Boolean` | `get/set` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `MixColors` | `Boolean` | `get/set` | No | `` |
| `PurpleColor` | `Int32` | `get/set` | No | `` |
| `PurpleVisible` | `Boolean` | `get/set` | No | `` |
| `RedColor` | `Int32` | `get/set` | No | `` |
| `RedVisible` | `Boolean` | `get/set` | No | `` |
| `SymbolVisible` | `Boolean` | `get/set` | No | `` |
| `TextColor` | `Int32` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |
| `TextOblique` | `Single` | `get/set` | No | `` |
| `TextRatio` | `Single` | `get/set` | No | `` |
| `TextVisible` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `DwgLayer` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PointsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.PointsStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.PointsStyle`

#### Properties (27)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CodesVisible` | `Boolean` | `get/set` | No | `` |
| `DescriptionVisible` | `Boolean` | `get/set` | No | `` |
| `Digits` | `Int32` | `get/set` | No | `` |
| `ElevationVisible` | `Boolean` | `get/set` | No | `` |
| `ExtendedLayer` | `UInt32` | `get/set` | No | `` |
| `FontName` | `String` | `get/set` | No | `` |
| `GroundLayer` | `UInt32` | `get/set` | No | `` |
| `GroundPointsColor` | `Int32` | `get/set` | No | `` |
| `GroundPointsVisible` | `Boolean` | `get/set` | No | `` |
| `HighlightedPointsColor` | `Int32` | `get/set` | No | `` |
| `Mapsigns3d` | `Boolean` | `get/set` | Yes | `` |
| `MapSignsVisible` | `Boolean` | `get/set` | No | `` |
| `NumberVisible` | `Boolean` | `get/set` | No | `` |
| `PointsSize` | `Single` | `get/set` | No | `` |
| `ScalableMode` | `Boolean` | `get/set` | No | `` |
| `SelectedPointsColor` | `Int32` | `get/set` | No | `` |
| `SituationPointsColor` | `Int32` | `get/set` | No | `` |
| `SituationPointsVisible` | `Boolean` | `get/set` | No | `` |
| `TextColor` | `Int32` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |
| `TextOblique` | `Single` | `get/set` | No | `` |
| `TextRatio` | `Single` | `get/set` | No | `` |
| `TextStylesAdaptation` | `IDictionary<TextStyle TextStyle>` | `get` | No | `` |
| `TrimZeros` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |
| `WipeoutElevations` | `Boolean` | `get/set` | No | `` |
| `WipeoutScale` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetExtendedLayer` | `DwgLayer` | `` | `` |
| `GetGroundLayer` | `DwgLayer` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StructureLinesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.StructureLinesStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.StructureLinesStyle`

#### Constructors (1)

- `.ctor(SurfaceStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `ExtendedGrips` | `Boolean` | `get/set` | No | `` |
| `Layer` | `UInt32` | `get/set` | No | `` |
| `LimitationColor` | `CadColor` | `get/set` | No | `` |
| `SituationColor` | `CadColor` | `get/set` | No | `` |
| `TextStylesAdaptation` | `IDictionary<TextStyle TextStyle>` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `DwgLayer` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StyleObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.StyleObject` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SurfaceStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `SurfaceStyle` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Modify` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |

### `SurfaceStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.SurfaceStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Surface, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonStyle` | `CommonStyle` | `get` | No | `` |
| `Dynamic` | `Boolean` | `get/set` | No | `` |
| `HorizontalsStyle` | `HorizontalsStyle` | `get` | No | `` |
| `InclinationsStyle` | `InclinationsStyle` | `get` | No | `` |
| `Owner` | `Surface` | `get/set` | No | `` |
| `PointsStyle` | `PointsStyle` | `get` | No | `` |
| `StructureLinesStyle` | `StructureLinesStyle` | `get` | No | `` |
| `TrianglesStyle` | `TrianglesStyle` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `SurfaceStyle source` | `` |
| `Clone` | `Object` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |

### `TextStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.TextStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FontName` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Oblique` | `Double` | `get/set` | No | `` |
| `Ratio` | `Double` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICloneable` | `Clone` |

### `TrianglesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Style.TrianglesStyle` |
| **Base Type** | `Topomatic.Sfc.Style.StyleObject` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Sfc.Style.SurfaceStyle, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Style.StyleObject`
    - `Topomatic.Sfc.Style.TrianglesStyle`

#### Constructors (1)

- `.ctor(SurfaceStyle owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Azimuth` | `Single` | `get/set` | No | `` |
| `Gradient` | `Byte[]` | `get/set` | No | `` |
| `GroundColor` | `Int32` | `get/set` | No | `` |
| `Realistic` | `Boolean` | `get/set` | No | `` |
| `RibsColor` | `Int32` | `get/set` | No | `` |
| `RibsEnable` | `Boolean` | `get/set` | No | `` |
| `RibsLayer` | `UInt32` | `get/set` | No | `` |
| `RibsVisible` | `Boolean` | `get/set` | No | `` |
| `SunDirection` | `Vector3D` | `get` | No | `` |
| `TrianglesEnable` | `Boolean` | `get/set` | No | `` |
| `TrianglesLayer` | `UInt32` | `get/set` | No | `` |
| `TrianglesVisible` | `Boolean` | `get/set` | No | `` |
| `Vertical` | `Single` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetRibsLayer` | `DwgLayer` | `` | `` |
| `GetTrianglesLayer` | `DwgLayer` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Sfc.Utils`

### `AreaBetweenSurfacesCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Utils.AreaBetweenSurfacesCalculator` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Sfc.Utils.AreaBetweenSurfacesCalculator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `Surface fg, Surface eg, List<Vector2D> contour, List<Vector2D> additional, ref Double fillArea, ref Double fillVolume, ref Double cutArea, ref Double cutVolume` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateElevations` | `Boolean` | `Surface fg, Surface eg, Vector2D position, ref Double fgElevation, ref Double egElevation` | `` |
| `FindNewNode` | `Boolean` | `Vector2D pos1, Double fg1, Double eg1, Vector2D pos2, Double fg2, Double eg2, ref Vector2D pos, ref Double elevation` | `` |
| `TrySectLines` | `Boolean` | `Line2D l1, Line2D l2, ref Vector2D point` | `` |

---
## Namespace: `Topomatic.Sfc.Vcs`

### `SfcConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Vcs.SfcConflictResolver` |
| **Base Type** | `Topomatic.Dwg.Vcs.DwgConflictResolver` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.Vcs.DwgConflictResolver`
    - `Topomatic.Sfc.Vcs.SfcConflictResolver`

#### Constructors (1)

- `.ctor(Surface origin, Surface local, Surface remote, Surface result, VcsContext context)`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PreparePoints` | `Vector2D` | `Surface surface, Vector3D[] points, SurfaceTriangle triangle` | `` |
| `ResolveConflict` | `Boolean` | `Surface origin, Surface local, Surface remote, Surface result, VcsContext context` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 72 |
| **Classes** | 47 |
| **Interfaces** | 4 |
| **Enums** | 11 |
| **Structs** | 4 |
| **Abstract Classes** | 5 |
| **Static Classes** | 1 |
| **Total Methods** | 285 |
| **Total Properties** | 319 |
| **Total Fields** | 76 |
| **Total Events** | 27 |
| **Total Constructors** | 37 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


