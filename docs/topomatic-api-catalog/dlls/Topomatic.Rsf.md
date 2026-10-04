# Topomatic.Rsf

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Rsf` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Rsf.dll` |

---
## Namespace: `Topomatic.Rsf`

### `AlignmentRsf` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.AlignmentRsf` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Rsf.IAlignmentRsfContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Rsf.AlignmentRsf`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ManuallyFences` | `FenceTable` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PreliminaryFences` | `FenceTable` | `get` | No | `` |
| `RoundedFences` | `FenceTable` | `get` | No | `` |
| `Style` | `AlignmentRsfStyle` | `get` | No | `` |

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
| `IAlignmentRsfContainer` | `Topomatic.Rsf.IAlignmentRsfContainer.get_Rsf` |

### `Fence` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Fence` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IPolyline3D, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Rsf.IAlignmentRsfContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Rsf.Fence`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (26)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeamLen` | `Double` | `get/set` | No | `` |
| `BeamModel` | `Guid` | `get/set` | No | `` |
| `BearingModel` | `Guid` | `get/set` | No | `` |
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `FenceType` | `RsfSegmentType` | `get/set` | No | `` |
| `Flag` | `RsfFlag` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `BugleVector3D` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Location` | `String` | `get/set` | No | `` |
| `Mark` | `String` | `get/set` | No | `` |
| `Note` | `String` | `get/set` | No | `` |
| `ObjectType` | `RsfObjectType` | `get/set` | No | `` |
| `Offs` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PkE` | `Double` | `get/set` | No | `` |
| `PkS` | `Double` | `get/set` | No | `` |
| `PostStep` | `Double` | `get/set` | No | `` |
| `Rsf` | `AlignmentRsf` | `get` | No | `` |
| `SFL` | `String` | `get/set` | No | `` |
| `TypedObject` | `TypedObject` | `get` | No | `` |
| `UseVis` | `Boolean` | `get/set` | No | `` |
| `VisFenceSide` | `RsfVisFencePosition` | `get/set` | No | `` |
| `VisFenceTexture` | `RsfVisFenceTexture` | `get/set` | No | `` |
| `VisSignalPostSide` | `RsfVisPostPosition` | `get/set` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BugleVector3D item` | `` |
| `Assign` | `Void` | `Fence source` | `` |
| `AssignPoly` | `Void` | `IPolyline3D poly` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BugleVector3D item` | `` |
| `CopyProperties` | `Void` | `Fence source` | `` |
| `CopyTo` | `Void` | `BugleVector3D[] array, Int32 arrayIndex` | `` |
| `GetBounds` | `BoundingBox2D` | `Double width` | `` |
| `GetEnumerator` | `IEnumerator<BugleVector3D>` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `IndexOf` | `Int32` | `BugleVector3D item` | `` |
| `Insert` | `Void` | `Int32 index, BugleVector3D item` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double width` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BugleVector3D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPolyline3D` | `get_Closed` |
| `IPolyline3D` | `set_Closed` |
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
| `ILinearObject` | `GetPolyline` |
| `IAlignmentRsfContainer` | `get_Rsf` |

### `FenceTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FenceTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Rsf.Fence, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Rsf.Fence, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Rsf.Fence, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Rsf.IAlignmentRsfContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Rsf.FenceTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImCollection` | `ImElementCollection` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Fence` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Rsf` | `AlignmentRsf` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Fence item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Fence item` | `` |
| `CopyTo` | `Void` | `Fence[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<Fence>` | `` | `` |
| `IndexOf` | `Int32` | `Fence item` | `` |
| `Insert` | `Void` | `Int32 index, Fence item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Fence item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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
| `IAlignmentRsfContainer` | `get_Rsf` |
| `ImElementCollectionContainer` | `get_ImCollection` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `IAlignmentRsfContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.IAlignmentRsfContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Rsf` | `AlignmentRsf` | `get` | No | `` |

### `PipeHeadSide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.PipeHeadSide` |
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
      - `Topomatic.Rsf.PipeHeadSide`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `PipeHeadSide` | Yes | `Left` | `` |
| `LeftAndRight` | `PipeHeadSide` | Yes | `LeftAndRight` | `` |
| `Right` | `PipeHeadSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftAndRight` | `0` |
| `Right` | `1` |
| `Left` | `-1` |

**Underlying Type**: `System.Int32`

### `PipeHeadSideConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.PipeHeadSideConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.PipeHeadSideConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TruncEx` | `Int32` | `Double x` | `` |

#### Fields (36)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CaptionBridges` | `String` | Yes | `` | `` |
| `CaptionIntensities` | `String` | Yes | `` | `` |
| `CurveSideIn` | `Int32` | Yes | `-1` | `` |
| `CurveSideNone` | `Int32` | Yes | `0` | `` |
| `CurveSideOut` | `Int32` | Yes | `1` | `` |
| `DEFAULT_MODEL_UID` | `String` | Yes | `"{00000000-0000-0000-0000-000000000000}"` | `` |
| `DivLoc` | `Int32` | Yes | `0` | `` |
| `DoubleFaced` | `String` | Yes | `` | `` |
| `FenceLayerName` | `String` | Yes | `` | `` |
| `FencePrevLayerName` | `String` | Yes | `` | `` |
| `FreeLoc` | `Int32` | Yes | `2` | `` |
| `GabHeigth` | `String` | Yes | `` | `` |
| `Infinity` | `Double` | Yes | `1.7E+308` | `` |
| `LeftLoc` | `Int32` | Yes | `-1` | `` |
| `LevelValueKJ` | `String` | Yes | `` | `` |
| `Loc_Line` | `String` | Yes | `` | `` |
| `Loc_Offs` | `String` | Yes | `` | `` |
| `Mark_or_Posts` | `String` | Yes | `` | `` |
| `NonAssigned` | `String` | Yes | `` | `` |
| `NotaBene` | `String` | Yes | `` | `` |
| `PluginUID` | `String` | Yes | `"Rsf"` | `` |
| `PostLayerName` | `String` | Yes | `` | `` |
| `PostPrevLayerName` | `String` | Yes | `` | `` |
| `PostStep` | `String` | Yes | `` | `` |
| `RightLoc` | `Int32` | Yes | `1` | `` |
| `RsfBridgeBanquetteNo` | `String` | Yes | `` | `` |
| `RsfBridgeBanquetteYes` | `String` | Yes | `` | `` |
| `RsfPipeSideLeft` | `String` | Yes | `` | `` |
| `RsfPipeSideLeftAndRight` | `String` | Yes | `` | `` |
| `RsfPipeSideRight` | `String` | Yes | `` | `` |
| `SaveForceLevel` | `String` | Yes | `` | `` |
| `Section` | `String` | Yes | `` | `` |
| `SectionEnd` | `String` | Yes | `` | `` |
| `SectionStart` | `String` | Yes | `` | `` |
| `StepMain` | `String` | Yes | `` | `` |
| `СaptionPipes` | `String` | Yes | `` | `` |

### `RsfFlag` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfFlag` |
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
      - `Topomatic.Rsf.RsfFlag`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Exist` | `RsfFlag` | Yes | `Exist` | `` |
| `Project` | `RsfFlag` | Yes | `Project` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Project` | `0` |
| `Exist` | `1` |

**Underlying Type**: `System.Int32`

### `RsfFlagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfFlagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfFlagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfLocation` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfLocation` |
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
      - `Topomatic.Rsf.RsfLocation`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftEdgeIn` | `RsfLocation` | Yes | `LeftEdgeIn` | `` |
| `LeftEdgeInCenterMall` | `RsfLocation` | Yes | `LeftEdgeInCenterMall` | `` |
| `LeftEdgeOut` | `RsfLocation` | Yes | `LeftEdgeOut` | `` |
| `RightEdgeIn` | `RsfLocation` | Yes | `RightEdgeIn` | `` |
| `RightEdgeInCenterMall` | `RsfLocation` | Yes | `RightEdgeInCenterMall` | `` |
| `RightEdgeOut` | `RsfLocation` | Yes | `RightEdgeOut` | `` |
| `TraceLine` | `RsfLocation` | Yes | `TraceLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TraceLine` | `0` |
| `LeftEdgeOut` | `1` |
| `RightEdgeOut` | `2` |
| `LeftEdgeIn` | `3` |
| `RightEdgeIn` | `4` |
| `LeftEdgeInCenterMall` | `5` |
| `RightEdgeInCenterMall` | `6` |

**Underlying Type**: `System.Int32`

### `RsfLocationConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfLocationConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfLocationConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfMarkTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfMarkTable` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Rsf.Marks.RsfMarkRec, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Rsf.Marks.RsfMarkRec, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Rsf.Marks.RsfMarkRec, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IHandledObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<RsfMarkRec> records)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `RsfMarkRec` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `RsfMarkRec item` | `` |
| `Assign` | `Void` | `RsfMarkTable source` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `RsfMarkRec item` | `` |
| `CopyTo` | `Void` | `RsfMarkRec[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<RsfMarkRec>` | `` | `` |
| `IndexOf` | `Int32` | `RsfMarkRec item` | `` |
| `Insert` | `Void` | `Int32 index, RsfMarkRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `RsfMarkRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Search` | `Int32` | `String mark` | `` |

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
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfObjectType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfObjectType` |
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
      - `Topomatic.Rsf.RsfObjectType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RoadFence` | `RsfObjectType` | Yes | `RoadFence` | `` |
| `RoadPost` | `RsfObjectType` | Yes | `RoadPost` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RoadFence` | `0` |
| `RoadPost` | `1` |

**Underlying Type**: `System.Int32`

### `RsfObjectTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfObjectTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfObjectTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfSegmentType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfSegmentType` |
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
      - `Topomatic.Rsf.RsfSegmentType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bridge` | `RsfSegmentType` | Yes | `Bridge` | `` |
| `Conn` | `RsfSegmentType` | Yes | `Conn` | `` |
| `Fin` | `RsfSegmentType` | Yes | `Fin` | `` |
| `Open` | `RsfSegmentType` | Yes | `Open` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Work` | `RsfSegmentType` | Yes | `Work` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Work` | `0` |
| `Open` | `1` |
| `Fin` | `2` |
| `Conn` | `3` |
| `Bridge` | `4` |

**Underlying Type**: `System.Int32`

### `RsfSegmentTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfSegmentTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfSegmentTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfSFL` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfSFL` |
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
      - `Topomatic.Rsf.RsfSFL`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `U1` | `RsfSFL` | Yes | `U1` | `` |
| `U10` | `RsfSFL` | Yes | `U10` | `` |
| `U2` | `RsfSFL` | Yes | `U2` | `` |
| `U3` | `RsfSFL` | Yes | `U3` | `` |
| `U4` | `RsfSFL` | Yes | `U4` | `` |
| `U5` | `RsfSFL` | Yes | `U5` | `` |
| `U6` | `RsfSFL` | Yes | `U6` | `` |
| `U7` | `RsfSFL` | Yes | `U7` | `` |
| `U8` | `RsfSFL` | Yes | `U8` | `` |
| `U9` | `RsfSFL` | Yes | `U9` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `U1` | `0` |
| `U2` | `1` |
| `U3` | `2` |
| `U4` | `3` |
| `U5` | `4` |
| `U6` | `5` |
| `U7` | `6` |
| `U8` | `7` |
| `U9` | `8` |
| `U10` | `9` |

**Underlying Type**: `System.Int32`

### `RsfSFLConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfSFLConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfSFLConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfVisFencePosition` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisFencePosition` |
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
      - `Topomatic.Rsf.RsfVisFencePosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `RsfVisFencePosition` | Yes | `Both` | `` |
| `Left` | `RsfVisFencePosition` | Yes | `Left` | `` |
| `Right` | `RsfVisFencePosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |
| `Both` | `2` |

**Underlying Type**: `System.Int32`

### `RsfVisFencePositionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisFencePositionConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfVisFencePositionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfVisFenceTexture` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisFenceTexture` |
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
      - `Topomatic.Rsf.RsfVisFenceTexture`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Blank` | `RsfVisFenceTexture` | Yes | `Blank` | `` |
| `Danger` | `RsfVisFenceTexture` | Yes | `Danger` | `` |
| `Standard` | `RsfVisFenceTexture` | Yes | `Standard` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Blank` | `0` |
| `Danger` | `1` |
| `Standard` | `2` |

**Underlying Type**: `System.Int32`

### `RsfVisFenceTextureConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisFenceTextureConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfVisFenceTextureConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RsfVisPostPosition` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisPostPosition` |
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
      - `Topomatic.Rsf.RsfVisPostPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `RsfVisPostPosition` | Yes | `Left` | `` |
| `Right` | `RsfVisPostPosition` | Yes | `Right` | `` |
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

### `RsfVisPostPositionConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.RsfVisPostPositionConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Rsf.RsfVisPostPositionConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Rsf.FillTables`

### `RsfBridgeRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfBridgeRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Rsf.FillTables.RsfBridgeRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Banquette` | `String` | `get/set` | No | `` |
| `ModelUid` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PkE` | `Double` | `get/set` | No | `` |
| `PkS` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfBridgeRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfFillRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfFillRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Rsf.FillTables.RsfFillRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeamLen` | `Double` | `get/set` | No | `` |
| `BeamModel` | `Guid` | `get/set` | No | `` |
| `BearingModel` | `Guid` | `get/set` | No | `` |
| `Location` | `String` | `get/set` | No | `` |
| `Mark` | `String` | `get/set` | No | `` |
| `ModelUid` | `String` | `get/set` | No | `` |
| `Note` | `String` | `get/set` | No | `` |
| `Offs` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PkE` | `Double` | `get/set` | No | `` |
| `PkS` | `Double` | `get/set` | No | `` |
| `PostStep` | `Double` | `get/set` | No | `` |
| `SFL` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfFillRec source` | `` |
| `EqualsRec` | `Boolean` | `RsfFillRec other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfIntensityRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfIntensityRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Rsf.FillTables.RsfIntensityRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Intensity` | `Int32` | `get/set` | No | `` |
| `ModelUid` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Sta` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfIntensityRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfPipeRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfPipeRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Rsf.FillTables.RsfPipeRec`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ModelUid` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `PipeHeadSide` | `get/set` | No | `` |
| `Sta` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfPipeRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfSFLFillRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfSFLFillRec` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSFLFillRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `String` | No | `` | `` |
| `Right` | `String` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RsfTable`1<T where IOwned, IStgSerializable, class, IOwned, IStgSerializable>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.FillTables.RsfTable`1` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, , System.Collections.IEnumerable, , , Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Rsf.FillTables.RsfTable`1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `T item` | `` |
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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Rsf.Marks`

### `RsfMarkRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Marks.RsfMarkRec` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfMarkRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BeamModel` | `Guid` | No | `` | `` |
| `BearingModel` | `Guid` | No | `` | `` |
| `Descr` | `String` | No | `` | `` |
| `DoubleFace` | `Int32` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `Len_Beg` | `Double` | No | `` | `` |
| `Len_Conn` | `Double` | No | `` | `` |
| `Len_End` | `Double` | No | `` | `` |
| `LevelV_KJ` | `Double` | No | `` | `` |
| `Mark` | `String` | No | `` | `` |
| `Mark_Beg` | `String` | No | `` | `` |
| `Mark_Conn` | `String` | No | `` | `` |
| `Mark_End` | `String` | No | `` | `` |
| `SFL` | `String` | No | `` | `` |
| `Step_Main` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Rsf.Solve`

### `RsfSlpDataRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSlpDataRec` |
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
| `Assign` | `Void` | `RsfSlpDataRec source` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HnLeft` | `Double` | No | `` | `` |
| `HnRight` | `Double` | No | `` | `` |
| `LandGrade` | `Double` | No | `` | `` |
| `NumStrips` | `Double` | No | `` | `` |
| `OnVognPrf` | `Double` | No | `` | `` |
| `PrfGrade` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `SideLeft` | `Double` | No | `` | `` |
| `SideRight` | `Double` | No | `` | `` |
| `SlopeLeft` | `Double` | No | `` | `` |
| `SlopeRight` | `Double` | No | `` | `` |
| `Sta` | `Double` | No | `` | `` |

### `RsfSolveOptions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSolveOptions` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSolveOptions source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CriticalPrfGrade` | `Double` | No | `` | `` |
| `MaxRadiusForConcaveCurveInPrf` | `Double` | No | `` | `` |
| `MaxSlopeKoeff` | `Double` | No | `` | `` |
| `MinPrfGrade` | `Double` | No | `` | `` |
| `ZoneLenForGradesFromMinToCritical` | `Double` | No | `` | `` |
| `ZoneLenForGradesMoreThanCritical` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfSolveOptionsBankHeight` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSolveOptionsBankHeight` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSolveOptionsBankHeight source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MaxGrade` | `Double` | No | `` | `` |
| `MaxOffset` | `Double` | No | `` | `` |
| `UseKosogornost` | `Boolean` | No | `` | `` |
| `UseReconstruct` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfSolveOptionsOther` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSolveOptionsOther` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSolveOptionsOther source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `UseSnipSignalPostsMethod` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfSolveOptionsRound` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSolveOptionsRound` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSolveOptionsRound source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CenterLineIndent` | `Double` | No | `` | `` |
| `LeftDivIndent` | `Double` | No | `` | `` |
| `LeftInEdgeIndent` | `Double` | No | `` | `` |
| `LeftOutEdgeIndent` | `Double` | No | `` | `` |
| `MinInterval` | `Double` | No | `` | `` |
| `RightDivIndent` | `Double` | No | `` | `` |
| `RightInEdgeIndent` | `Double` | No | `` | `` |
| `RightOutEdgeIndent` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfSolveOptionsTable13` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Solve.RsfSolveOptionsTable13` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `RsfSolveOptionsTable13 source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConcaveCurveInPrfAbsDiffGradesMore50_Hn_100` | `Double` | No | `` | `` |
| `ConcaveCurveInPrfAbsDiffGradesMore50_Hn_2000` | `Double` | No | `` | `` |
| `Less600DownCurveOutSideAndAfter_Less40_Hn_100` | `Double` | No | `` | `` |
| `Less600DownCurveOutSideAndAfter_Less40_Hn_2000` | `Double` | No | `` | `` |
| `Less600DownCurveOutSideAndAfter_More40_Hn_100` | `Double` | No | `` | `` |
| `Less600DownCurveOutSideAndAfter_More40_Hn_2000` | `Double` | No | `` | `` |
| `More600_Less600DownCurveInSideAndAfter_Less40_Hn_100` | `Double` | No | `` | `` |
| `More600_Less600DownCurveInSideAndAfter_Less40_Hn_2000` | `Double` | No | `` | `` |
| `More600_Less600DownCurveInSideAndAfter_More40_Hn_100` | `Double` | No | `` | `` |
| `More600_Less600DownCurveInSideAndAfter_More40_Hn_2000` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Rsf.Style`

### `AlignmentRsfStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.AlignmentRsfStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Rsf.Style.RsfStyleItem, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyle`
    - `Topomatic.Rsf.Style.AlignmentRsfStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonPlanStyle` | `RsfCommonPlanStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<RsfLayerStyleItem>` | `get` | No | `` |
| `ManuallyFencesPlanStyle` | `ManuallyFencesPlanStyle` | `get` | No | `` |
| `PreliminaryAutoFencesPlanStyle` | `PreliminaryAutoFencesPlanStyle` | `get` | No | `` |
| `PreliminaryAutoPostsPlanStyle` | `PreliminaryAutoPostsPlanStyle` | `get` | No | `` |
| `RoundedAutoFencesPlanStyle` | `RoundedAutoFencesPlanStyle` | `get` | No | `` |
| `RoundedAutoPostsPlanStyle` | `RoundedAutoPostsPlanStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `AlignmentRsfStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ManuallyFencesPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.ManuallyFencesPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`
        - `Topomatic.Rsf.Style.ManuallyFencesPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PreliminaryAutoFencesPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.PreliminaryAutoFencesPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`
        - `Topomatic.Rsf.Style.PreliminaryAutoFencesPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PreliminaryAutoPostsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.PreliminaryAutoPostsPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`
        - `Topomatic.Rsf.Style.PreliminaryAutoPostsPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoundedAutoFencesPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RoundedAutoFencesPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`
        - `Topomatic.Rsf.Style.RoundedAutoFencesPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoundedAutoPostsPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RoundedAutoPostsPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`
        - `Topomatic.Rsf.Style.RoundedAutoPostsPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RsfCommonPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RsfCommonPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfCommonPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `OneWay` | `Boolean` | `get/set` | No | `` |
| `Reverse` | `Boolean` | `get/set` | No | `` |
| `UseFixDrawStep` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `RsfCommonPlanStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RsfLayerStyleItem` |
| **Base Type** | `Topomatic.Rsf.Style.RsfStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RsfPlanStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RsfPlanStyle` |
| **Base Type** | `Topomatic.Rsf.Style.RsfLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Rsf.Style.RsfStyleItem`
    - `Topomatic.Rsf.Style.RsfLayerStyleItem`
      - `Topomatic.Rsf.Style.RsfPlanStyle`

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `RsfPlanStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RsfStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RsfStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Rsf.Style.RsfStyleItem, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStyles` | `IEnumerable<RsfLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<RsfStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `RsfStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rsf.Style.RsfStyleItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Rsf.Style.RsfStyle, Topomatic.Rsf, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(RsfStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `RsfStyle` | `get/set` | No | `` |

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 48 |
| **Classes** | 33 |
| **Interfaces** | 1 |
| **Enums** | 9 |
| **Structs** | 0 |
| **Abstract Classes** | 4 |
| **Static Classes** | 1 |
| **Total Methods** | 105 |
| **Total Properties** | 98 |
| **Total Fields** | 141 |
| **Total Events** | 0 |
| **Total Constructors** | 38 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


