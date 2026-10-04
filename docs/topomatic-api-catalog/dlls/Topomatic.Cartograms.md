# Topomatic.Cartograms

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cartograms` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cartograms.dll` |

---
## Namespace: `Topomatic.Cartograms`

### `Cartogram` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Cartogram` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Dwg.IDrawingContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cartograms.Cartogram`

#### Constructors (1)

- `.ctor(Object owner, ICartogramBuilder builder)`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalStations` | `String` | `get/set` | No | `` |
| `AlignmentRelativePath` | `String` | `get/set` | No | `` |
| `BuildByAlignment` | `Boolean` | `get/set` | No | `` |
| `Cache` | `CartogramCache` | `get` | No | `` |
| `CalculateVolumesByTriangles` | `Boolean` | `get/set` | No | `` |
| `Contour` | `CartogramContour` | `get` | No | `` |
| `ControlPosition` | `Vector2D` | `get/set` | No | `` |
| `DynamicalUpdateAfterSurfaceChanged` | `Boolean` | `get/set` | No | `` |
| `EarthRelativePath` | `String` | `get/set` | No | `` |
| `EditedItems` | `BasicEditedItemsTable` | `get` | No | `` |
| `HasControlPosition` | `Boolean` | `get/set` | No | `` |
| `HorizontalStep` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `InnerContours` | `CartogramInnerContours` | `get` | No | `` |
| `OffsetStep` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `ProjectRelativePath` | `String` | `get/set` | No | `` |
| `RenewLayers` | `IList<CartogramRenewLayer>` | `get` | No | `` |
| `RenewMaxFrez` | `Double` | `get/set` | No | `` |
| `RenewSurfaceRelativePath` | `String` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `RoundSummVolumes` | `Boolean` | `get/set` | No | `` |
| `RoundVolumesByElevations` | `Boolean` | `get/set` | No | `` |
| `SectWithSurfaceContour` | `Boolean` | `get/set` | No | `` |
| `StationsStep` | `Double` | `get/set` | No | `` |
| `Style` | `CartogramStyle` | `get` | No | `` |
| `VerticalStep` | `Double` | `get/set` | No | `` |
| `VertricalStepByOffsets` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `DoRegen` | `Void` | `` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Refresh` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Regen` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICartogramContainer` | `Topomatic.Cartograms.ICartogramContainer.get_Cartogram` |
| `IDrawingContainer` | `Topomatic.Dwg.IDrawingContainer.get_Drawing` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `CartogramCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get` | No | `` |
| `Cells` | `IList<CartogramCell>` | `get` | No | `` |
| `CutContours` | `IList<IList<Int32>>` | `get` | No | `` |
| `FillContours` | `IList<IList<Int32>>` | `get` | No | `` |
| `InfoPosition` | `Vector2D` | `get/set` | No | `` |
| `InfoRotation` | `Double` | `get/set` | No | `` |
| `Nodes` | `IList<CartogramNode>` | `get` | No | `` |
| `NullLines` | `IList<IList<Int32>>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `StartColumn` | `UInt32` | `get/set` | No | `` |
| `Volumes` | `IDictionary<Int32 VolumeItem>` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `LoadFromOldStg` | `Void` | `StgNode node` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `VolumeItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICartogramContainer` | `get_Cartogram` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CartogramCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramCell` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalElevations` | `IList<Int32>` | `get` | No | `` |
| `Cartogram` | `Cartogram` | `get` | No | `` |
| `Column` | `UInt32` | `get/set` | No | `` |
| `CutArea` | `Double` | `get/set` | No | `` |
| `CutVolume` | `Double` | `get/set` | No | `` |
| `FillArea` | `Double` | `get/set` | No | `` |
| `FillVolume` | `Double` | `get/set` | No | `` |
| `LeftBottom` | `Vector2D` | `get/set` | No | `` |
| `LeftTop` | `Vector2D` | `get/set` | No | `` |
| `Nodes` | `IList<IList<Int32>>` | `get` | No | `` |
| `Number` | `UInt32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RightBottom` | `Vector2D` | `get/set` | No | `` |
| `RightTop` | `Vector2D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |

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
| `ICartogramContainer` | `get_Cartogram` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CartogramConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"cartograms"` | `` |

### `CartogramContour` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramContour` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cartograms.CartogramContour`

#### Constructors (1)

- `.ctor(Object owner, String name)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `Cartogram` | `Cartogram` | `get` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Vector2D item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Vector2D item` | `` |
| `CopyTo` | `Void` | `Vector2D[] array, Int32 arrayIndex` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<Vector2D>` | `` | `Browsable` |
| `IndexOf` | `Int32` | `Vector2D item` | `` |
| `Insert` | `Void` | `Int32 index, Vector2D item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Vector2D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `EndUpdate` |
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
| `ICartogramContainer` | `get_Cartogram` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `CartogramContours`1<T where CartogramContour, INamedTransactable, ITransactable, IUpdatable, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IOwned, ICartogramContainer, IStgSerializable, IBoundedObject, class, CartogramContour>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramContours`1` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, , Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cartograms.CartogramContours`1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `CartogramContour contour` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICartogramContainer` | `get_Cartogram` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `CartogramExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ElevationToStr` | `String` | `Cartogram cartogram, Double value` | `Extension` |
| `Name` | `String` | `Cartogram cartogram` | `Extension` |
| `VolumeToStr` | `String` | `Cartogram cartogram, Double value` | `Extension` |

### `CartogramInnerContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramInnerContour` |
| **Base Type** | `Topomatic.Cartograms.CartogramContour` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cartograms.CartogramContour`
        - `Topomatic.Cartograms.CartogramInnerContour`

#### Constructors (1)

- `.ctor(Object parent, String name, Boolean additional)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsAdditional` | `Boolean` | `get` | No | `Browsable` |

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

### `CartogramInnerContours` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramInnerContours` |
| **Base Type** | `Topomatic.Cartograms.CartogramContours`1[[Topomatic.Cartograms.CartogramInnerContour, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cartograms.CartogramInnerContour, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.ICartogramContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cartograms.CartogramContours`1[[Topomatic.Cartograms.CartogramInnerContour, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Cartograms.CartogramInnerContours`

#### Constructors (1)

- `.ctor(Object parent)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `CartogramInnerContour` | `Boolean additional` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CartogramNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramNode` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cartograms.CartogramNode`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WorkElevation` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode stgNode, CartogramNode defaultValue` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CartogramNode` | `StgNode stgNode, CartogramNode defaultValue` | `` |
| `LoadFromStg` | `CartogramNode` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `CartogramNode cartogramNode, StgNode stgNode, CartogramNode defaultValue` | `` |
| `SaveToStg` | `Void` | `CartogramNode cartogramNode, StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Additional` | `Boolean` | No | `` | `` |
| `EarthElevation` | `Double` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `ProjectElevation` | `Double` | No | `` | `` |

### `CartogramRenewLayer` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramRenewLayer` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cartograms.CartogramRenewLayer`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Frez` | `Boolean` | `get/set` | No | `` |
| `MinThick` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Thick` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CartogramRenewLayer` | `StgNode node` | `` |

### `ICartogramBuilder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.ICartogramBuilder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `CartogramCache cache` | `` |

### `ICartogramContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.ICartogramContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cartogram` | `Cartogram` | `get` | No | `` |

### `VolumeItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.CartogramCache+VolumeItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cartograms.CartogramCache+VolumeItem`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CutArea` | `Double` | No | `` | `` |
| `CutVolume` | `Double` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FillArea` | `Double` | No | `` | `` |
| `FillVolume` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Cartograms.EditableItems`

### `CartogramEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.EditableItems.CartogramEditableItem` |
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
      - `Topomatic.Cartograms.EditableItems.CartogramEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalAngle` | `Double` | `get/set` | No | `` |
| `DrawLeader` | `Boolean` | `get/set` | No | `` |
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

### `CartogramEditableItemsKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.EditableItems.CartogramEditableItemsKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Cartograms.EditableItems.CartogramEditableItemsKey`

#### Constructors (1)

- `.ctor(eKeyType keyType, Int32 cellNumber, Int32 contourIndex, Int32 nodeIndex)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CellNumber` | `Int32` | `get/set` | No | `` |
| `ContourIndex` | `Int32` | `get/set` | No | `` |
| `ItemType` | `eKeyType` | `get/set` | No | `` |
| `NodeIndex` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `eKeyType` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `eKeyType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.EditableItems.CartogramEditableItemsKey+eKeyType` |
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
      - `Topomatic.Cartograms.EditableItems.CartogramEditableItemsKey+eKeyType`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cut` | `eKeyType` | Yes | `Cut` | `` |
| `EarthElevation` | `eKeyType` | Yes | `EarthElevation` | `` |
| `Fill` | `eKeyType` | Yes | `Fill` | `` |
| `GridNumber` | `eKeyType` | Yes | `GridNumber` | `` |
| `NodePosition` | `eKeyType` | Yes | `NodePosition` | `` |
| `ProjectElevation` | `eKeyType` | Yes | `ProjectElevation` | `` |
| `Unknown` | `eKeyType` | Yes | `Unknown` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WorkElevation` | `eKeyType` | Yes | `WorkElevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `WorkElevation` | `0` |
| `EarthElevation` | `1` |
| `ProjectElevation` | `2` |
| `Fill` | `3` |
| `Cut` | `4` |
| `GridNumber` | `5` |
| `NodePosition` | `6` |
| `Unknown` | `-1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Cartograms.Style`

### `CartogramInfoStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CartogramInfoStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.CartogramInfoStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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

### `CartogramLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
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

### `CartogramStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CartogramStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Cartogram, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cartograms.Style.CartogramStyleItem, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Cartogram owner)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackgroundFillColor` | `CadColor` | `get/set` | No | `` |
| `BackgroundFillType` | `BackgroundFillType` | `get/set` | No | `` |
| `CartogramInfoStyle` | `CartogramInfoStyle` | `get` | No | `` |
| `CellStyle` | `CellStyle` | `get` | No | `` |
| `ContourStyle` | `ContourStyle` | `get` | No | `` |
| `CutHatchStyle` | `CutHatchStyle` | `get` | No | `` |
| `CutStyle` | `CutStyle` | `get` | No | `` |
| `EarthElevationStyle` | `EarthElevationStyle` | `get` | No | `` |
| `FillHatchStyle` | `FillHatchStyle` | `get` | No | `` |
| `FillStyle` | `FillStyle` | `get` | No | `` |
| `GridStyle` | `GridStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<CartogramLayerStyleItem>` | `get` | No | `` |
| `NodesStyle` | `NodesStyle` | `get` | No | `` |
| `NodesTextStandardName` | `String` | `get` | No | `` |
| `NodeStyle` | `NodeStyle` | `get` | No | `` |
| `NullLineStyle` | `NullLineStyle` | `get` | No | `` |
| `Owner` | `Cartogram` | `get/set` | No | `` |
| `PrecisionStyle` | `PrecisionStyle` | `get` | No | `` |
| `ProjectElevationStyle` | `ProjectElevationStyle` | `get` | No | `` |
| `VolumesTextStandardName` | `String` | `get` | No | `` |
| `WorkElevationStyle` | `WorkElevationStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<CartogramStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

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

### `CartogramStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CartogramStyleItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `CartogramStyle` | `get/set` | No | `` |

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
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |

### `CellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CellStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.CellStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `ShowArea` | `Boolean` | `get/set` | No | `` |
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

### `ContourStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.ContourStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.ContourStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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

### `CutHatchStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CutHatchStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.CutHatchStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `Boolean` | `get/set` | No | `` |
| `AreaSignGuid` | `Guid` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
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

### `CutStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.CutStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.CutStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `EarthElevationStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.EarthElevationStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.EarthElevationStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `OffsetSize` | `Single` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `ElevationAlignment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.ElevationAlignment` |
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
      - `Topomatic.Cartograms.Style.ElevationAlignment`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftBottom` | `ElevationAlignment` | Yes | `LeftBottom` | `` |
| `LeftTop` | `ElevationAlignment` | Yes | `LeftTop` | `` |
| `RightBottom` | `ElevationAlignment` | Yes | `RightBottom` | `` |
| `RightTop` | `ElevationAlignment` | Yes | `RightTop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftTop` | `0` |
| `RightTop` | `1` |
| `LeftBottom` | `2` |
| `RightBottom` | `3` |

**Underlying Type**: `System.Int32`

### `FillHatchStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.FillHatchStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.FillHatchStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `Boolean` | `get/set` | No | `` |
| `AreaSignGuid` | `Guid` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
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

### `FillStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.FillStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.FillStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `GridStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.GridStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.GridStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `ISingleColorStyle` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |

### `NodesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.NodesStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.NodesStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OffsetSize` | `Single` | `get/set` | No | `` |
| `PointsSize` | `Single` | `get/set` | No | `` |
| `ShowZeroNodes` | `Boolean` | `get/set` | No | `` |

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

### `NodeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.NodeStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.NodeStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `OffsetSize` | `Single` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `NullLineStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.NullLineStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.NullLineStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
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

### `PrecisionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.PrecisionStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.PrecisionStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `VolumeDigits` | `Int32` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ElevationToStr` | `String` | `Double value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `VolumeToStr` | `String` | `Double value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProjectElevationStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.ProjectElevationStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.ProjectElevationStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `OffsetSize` | `Single` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

### `WorkElevationStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cartograms.Style.WorkElevationStyle` |
| **Base Type** | `Topomatic.Cartograms.Style.CartogramLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Cartograms.Style.CartogramStyle, Topomatic.Cartograms, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cartograms.Style.ISingleColorStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cartograms.Style.CartogramStyleItem`
    - `Topomatic.Cartograms.Style.CartogramLayerStyleItem`
      - `Topomatic.Cartograms.Style.WorkElevationStyle`

#### Constructors (1)

- `.ctor(CartogramStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `OffsetSize` | `Single` | `get/set` | No | `` |
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
| `ISingleColorStyle` | `get_Color` |
| `ISingleColorStyle` | `set_Color` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 24 |
| **Interfaces** | 3 |
| **Enums** | 2 |
| **Structs** | 3 |
| **Abstract Classes** | 3 |
| **Static Classes** | 2 |
| **Total Methods** | 99 |
| **Total Properties** | 143 |
| **Total Fields** | 24 |
| **Total Events** | 1 |
| **Total Constructors** | 27 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


