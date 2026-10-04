# Topomatic.Glg

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.dll` |

---
## Namespace: `Topomatic.Glg`

### `AlignmentGeology` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.AlignmentGeology` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Glg.IAlignmentGeologyContainer, Topomatic.Glg.References.IGeologyReferences, Topomatic.Glg.IAlignmentChangeLimits` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.AlignmentGeology`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `ConePenetrationTestEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `CrossSections` | `GeologyCrossSections` | `get` | No | `` |
| `EditableProfileSection` | `GeologySection` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `ImpellerTestEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `IsLimitsExists` | `Boolean` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parent` | `Object` | `get/set` | No | `` |
| `ProfileSection` | `GeologySection` | `get` | No | `` |
| `References` | `GeologyRelativeReferences` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Style` | `AlignmentGeologyStyle` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `Boolean clearOldreferences` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrsTaskId` | `Guid` | Yes | `` | `` |
| `m_BoundContourDepth` | `Double` | Yes | `` | `` |
| `PrfTaskId` | `Guid` | Yes | `` | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `EditableProfileSectionModified` | `EventHandler` | No | `` |
| `ProfileSectionModified` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentGeologyContainer` | `Topomatic.Glg.IAlignmentGeologyContainer.get_Geology` |
| `IGeologyReferences` | `Topomatic.Glg.References.IGeologyReferences.FindReference` |
| `IGeologyReferences` | `Topomatic.Glg.References.IGeologyReferences.GetReferences` |
| `IAlignmentChangeLimits` | `get_IsLimitsExists` |
| `IAlignmentChangeLimits` | `get_StartStation` |
| `IAlignmentChangeLimits` | `get_EndStation` |

### `AreaSignUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.AreaSignUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHatchById` | `Boolean` | `Guid areaSignId, ref AreaSign areaSign, ref String areaSignName` | `` |
| `GetHatchByName` | `Boolean` | `String hatchName, ref AreaSign areaSign, ref Guid areaSignId` | `` |
| `GetHatchName` | `Boolean` | `AreaSign areaSign, ref Guid areaSignId, ref String areaSignName` | `` |

### `CompleteResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlgSolveLib+CompleteResult` |
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
      - `Topomatic.Glg.GlgSolveLib+CompleteResult`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fail` | `CompleteResult` | Yes | `Fail` | `` |
| `Success` | `CompleteResult` | Yes | `Success` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Success` | `1` |
| `Fail` | `-1` |

**Underlying Type**: `System.Int32`

### `Dijkstra` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Dijkstra` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(List<KeyValuePair<Vector2D List<Vector2D>>> vertexRelations, Int32 startVertex)`
- `.ctor(Double[] graph, Int32 startVertex)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Graph` | `Double[]` | `get/set` | No | `` |
| `GraphRelations` | `List<KeyValuePair<Vector2D List<Vector2D>>>` | `get/set` | No | `` |
| `Solution` | `List<KeyValuePair<Double List<Int32>>>` | `get` | No | `` |
| `StartVertex` | `Int32` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `` | `` |
| `ExecuteEx` | `Boolean` | `` | `` |
| `ExecuteFast` | `List<Int32>` | `Int32 destinationVertex, ref Double minDist` | `` |
| `GetMinPathRoute` | `List<Int32>` | `Int32 destinationVertex` | `` |
| `GetMinPathValue` | `Double` | `Int32 destinationVertex` | `` |

### `DivideSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlgSolveLib+DivideSide` |
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
      - `Topomatic.Glg.GlgSolveLib+DivideSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `DivideSide` | Yes | `Left` | `` |
| `Right` | `DivideSide` | Yes | `Right` | `` |
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

### `DynamicGeology` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.DynamicGeology` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.DynamicGeology`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasDynamicGeology` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RelativeAlignmentPath` | `String` | `get/set` | No | `` |

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

### `GeologyConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologyConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BoreholesLayerName` | `String` | Yes | `` | `` |
| `ConePenetrationTestsLayerName` | `String` | Yes | `` | `` |
| `DummyDirectionsLayerName` | `String` | Yes | `` | `` |
| `DWL_CPT_MODEL_TYPE` | `String` | Yes | `"application/conepenetrationtest-dwl"` | `` |
| `DWL_GLOBAL_BOREHOLE_MODEL_TYPE` | `String` | Yes | `"application/global-borehole-dwl"` | `` |
| `DWL_MODEL_TYPE` | `String` | Yes | `"application/borehole-dwl"` | `` |
| `DynamicPluginUID` | `String` | Yes | `"DynamicGeology"` | `` |
| `FictiveBoreholesLayerName` | `String` | Yes | `` | `` |
| `GEOLOGY_SECTION_WINDOW` | `String` | Yes | `` | `` |
| `ImpellerTestsLayerName` | `String` | Yes | `` | `` |
| `MODEL_TYPE` | `String` | Yes | `"global_glg"` | `` |
| `PluginUID` | `String` | Yes | `"Geology"` | `` |

### `GeologyCrossSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologyCrossSection` |
| **Base Type** | `Topomatic.Glg.GeologySection` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.GeologySection`
        - `Topomatic.Glg.GeologyCrossSection`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |
| `LinkedContours` | `IList<GeometryLink>` | `get` | No | `` |
| `LinkedNodes` | `IList<GeometryLink>` | `get` | No | `` |
| `Splitters` | `IList<GeometryLink>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeologyCrossSections` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologyCrossSections` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Glg.GeologyCrossSection, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.GeologyCrossSections`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `GeologyCrossSection` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearSections` | `Void` | `` | `` |
| `ContainsSection` | `Boolean` | `UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<UInt32 GeologyCrossSection>>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `GeologySection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologySection` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.GeologySection`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, GroundReference ground)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoundContour` | `GeologyContour` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Lines` | `GeologyLines` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `GeologyStructureLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologyStructureLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.GeologyStructureLine`

#### Constructors (1)

- `.ctor(Object owner, String name)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `IsBorder` | `Boolean` | `get/set` | No | `SRDisplayName` |
| `IsValid` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `Guid` | `get/set` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `SRDisplayName` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Polyline` | `IList<Vector2D>` | `get` | No | `Browsable` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Borehole value` | `` |
| `Add` | `Void` | `Guid value` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `GetStation` | `Double` | `Guid id` | `` |
| `GetStation` | `Double` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `Guid guid` | `` |
| `Insert` | `Void` | `Int32 index, Guid value` | `` |
| `IsIntersect` | `Boolean` | `GeologyStructureLine line` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Guid value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |
| `TryConnect` | `Boolean` | `GeologyStructureLine line, List<Guid> resultList` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `GeologyStructureLines` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeologyStructureLines` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.GeologyStructureLines`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GeologyStructureLine` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `GeologyStructureLine` | `String name` | `` |
| `Clear` | `Void` | `` | `` |
| `IndexOf` | `Int32` | `GeologyStructureLine line` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `GeologyStructureLine line` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeometryLink` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GeometryLink` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.GeometryLink`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `GeometryLink` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `From` | `Vector2D` | No | `` | `` |
| `To` | `Vector2D` | No | `` | `` |

### `GlgSolveLib` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlgSolveLib` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (67)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AllVertexesInContour` | `Boolean` | `IList<Vector2D> vertexes, IList<Vector2D> contour` | `` |
| `AllVertexesInContourFast` | `Boolean` | `IList<Vector2D> vertexes, IList<Vector2D> contour` | `` |
| `AppendVertexToPolySet` | `Void` | `IList<IList<Vector2D>> polySet, Vector2D vertex` | `` |
| `AppendVerticesForPolySet` | `Void` | `IList<IList<Vector2D>> polySet` | `` |
| `AppendVerticesForPolySetFast` | `Void` | `IList<IList<Vector2D>> polySet` | `` |
| `AppendVerticesForPolySetVeryFast` | `Void` | `IList<IList<Vector2D>> polySet` | `` |
| `Classify_Point2D` | `Int32` | `Vector2D p0, Vector2D p1, Vector2D p2` | `` |
| `ClassifyPos` | `PosClassification` | `Vector2D pos1, Vector2D pos2, Vector2D pos` | `` |
| `ClipChilds` | `List<GeologyContour>` | `GeologyContour c` | `` |
| `ClipContour` | `Void` | `IList<Vector2D> contour, Double startSta, Double endSta, Boolean closed` | `` |
| `ClipLineByContour` | `List<List<Vector2D>>` | `IList<Vector2D> line, IList<Vector2D> contour` | `` |
| `ClipLinesByContour` | `GeologyLines` | `GeologyLines sourceLines, IList<Vector2D> contour, Object parent` | `` |
| `Clone` | `GeologyContour` | `GeologyContour contour, Object parent` | `Extension` |
| `Clone` | `GlgSmtLine` | `GlgSmtLine line, Object parent` | `Extension` |
| `ContourIsSimple` | `Boolean` | `IList<Vector2D> contour` | `` |
| `ContourIsSimple` | `CompleteResult` | `IList<Vector2D> contour, ISolveCancellator cancellator, ref Boolean res` | `` |
| `CopyGeologyLines` | `GeologyLines` | `GeologyLines sourceLines, Object parent` | `` |
| `EdgeIsCorrect` | `Boolean` | `IList<Vector2D> contour, Int32 index` | `` |
| `FillDepths` | `List<BulkLevel<Guid>>` | `GeologyContour contour, Double station` | `` |
| `FindClippedBorders` | `List<Double>` | `IList<Vector2D> contour, Double station` | `` |
| `FindClippedSegments` | `Void` | `IList<Vector2D> contour, Double station, Action<Double Double> func` | `` |
| `FindContourByPos` | `Boolean` | `Vector2D p, GeologyContour root, Ground ground, ref GeologyContour contour` | `` |
| `FindContourByPos` | `Boolean` | `Vector2D p, GeologyContour root, ref GeologyContour contour` | `` |
| `FindContourByPosEx` | `Boolean` | `Vector2D p, GeologyContour root, ref GeologyContour contour` | `` |
| `FindPosOnSegmentByX` | `Boolean` | `Vector2D p, Vector2D q, Double x, ref Vector2D pos` | `` |
| `FirstPolygonEntirelyInsideSecondPolygon` | `Boolean` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `FirstPolygonEntirelyInsideSecondPolygonFast` | `Boolean` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `FirstPolygonEntirelyInsideSecondPolygonFast` | `CompleteResult` | `IList<Vector2D> A, IList<Vector2D> B, ISolveCancellator cancellator, ref Boolean res` | `` |
| `FirstPolygonEntirelyOutsideSecondPolygon` | `Boolean` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `FirstPolygonEntirelyOutsideSecondPolygonFast` | `CompleteResult` | `IList<Vector2D> A, IList<Vector2D> B, ISolveCancellator cancellator, ref Boolean res` | `` |
| `FirstPolygonEntirelyOutsideSecondPolygonFast` | `Boolean` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `GetClockwised` | `IEnumerable<Vector2D>` | `IList<Vector2D> poly` | `` |
| `GetContourIndexPairsForPos` | `IEnumerable<KeyValuePair<GeologyContour Int32>>` | `Vector2D p, IEnumerable<GeologyContour> contours` | `` |
| `GetCounterClockwised` | `IEnumerable<Vector2D>` | `IList<Vector2D> poly` | `` |
| `GetInnerContours` | `IEnumerable<GeologyContour>` | `GeologyContour root` | `` |
| `IsPolyConvex` | `Boolean` | `IList<Vector2D> poly` | `` |
| `IsPosOnEdge` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b, Double epsilon` | `` |
| `IsSegmentsSectsWithoutEndings` | `Boolean` | `Vector2D a1, Vector2D a2, Vector2D b1, Vector2D b2, Boolean allowOverlay` | `` |
| `IsSimilarSmdx` | `Boolean` | `GeologyLine a, GeologyLine b` | `` |
| `MakeGraphForPolySet` | `Double[]` | `IList<IList<Vector2D>> polySet, List<KeyValuePair<Vector2D List<Vector2D>>> vertexRelations` | `` |
| `MakeGraphRelationsForPolySet` | `List<KeyValuePair<Vector2D List<Vector2D>>>` | `IList<IList<Vector2D>> polySet` | `` |
| `MakeGraphRelationsForPolySetFast` | `List<KeyValuePair<Vector2D List<Vector2D>>>` | `IList<IList<Vector2D>> polySet` | `` |
| `PolygonCentroid` | `Vector2D` | `IList<Vector2D> vertices` | `` |
| `PolygonCentroidEx` | `Vector2D` | `IList<Vector2D> vertices` | `` |
| `PolygonLineAmputation` | `Void` | `IList<Vector2D> polygon, Double sta, DivideSide side, List<List<Vector2D>> solution` | `` |
| `PolygonStripAmputation` | `Void` | `IList<Vector2D> polygon, Double start, Double end, List<List<Vector2D>> solution` | `` |
| `PolyOrientation` | `Int32` | `IList<Vector2D> poly` | `` |
| `PosInContour` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosInContourEdge` | `Boolean` | `Vector2D p, IList<Vector2D> contour, ref Int32 edgeIndex` | `` |
| `PosInContourEdge` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosInContourOrOnBorder` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosOnUnclosedLine` | `Boolean` | `Vector2D p, IList<Vector2D> line` | `` |
| `PosStrictlyInContour` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosStrictlyOutContour` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `RemoveDublicated` | `Void` | `GeologyContour contour, GeologyContour parent` | `` |
| `SegmCross` | `SegmCrossResult` | `Vector2D fl, Vector2D fr, Vector2D sl, Vector2D sr` | `` |
| `SegmentContainsPolygonExteriorPos` | `Boolean` | `Vector2D s, Vector2D f, IList<Vector2D> poly` | `` |
| `SegmentContainsPolygonInteriorPos` | `Boolean` | `Vector2D s, Vector2D f, IList<Vector2D> poly` | `` |
| `SegmentTouchCounterEdge` | `Boolean` | `Vector2D p, Vector2D q, IList<Vector2D> poly` | `` |
| `SegmentTouchExterior` | `Boolean` | `Vector2D s, Vector2D f, IList<Vector2D> poly` | `` |
| `SegmentTouchInterior` | `Boolean` | `Vector2D s, Vector2D f, IList<Vector2D> poly` | `` |
| `TessalateContour` | `Void` | `IList<Vector2D> contour, Double station, Boolean closed` | `` |
| `TrimChilds` | `List<GeologyContour>` | `GeologyContour c, Double startSta, Double endSta` | `` |
| `TrimContour` | `List<GeologyContour>` | `GeologyContour contour, Double startSta, Double endSta, IList<GeologyContour> parents` | `` |
| `TrimPoly` | `Void` | `IList<Vector2D> contour, Double startSta, Double endSta` | `` |
| `UniteContours` | `GeologyContour` | `GeologyContour cl, GeologyContour cr, GeologyContour parent, Boolean checkGrounds` | `` |
| `UniteLines` | `Void` | `IList<GeologyLine> leftLines, IList<GeologyLine> rightLines, IList<GeologyLine> res` | `` |

#### Nested Types (4)

- `CompleteResult` (enum)
- `DivideSide` (enum)
- `PosClassification` (enum)
- `SegmCrossResult` (enum)

### `GlobalGeologyActivityManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlobalGeologyActivityManager` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.GlobalGeologyActivityManager`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveSection` | `Int32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

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

### `IAlignmentChangeLimits` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IAlignmentChangeLimits` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `get` | No | `` |
| `IsLimitsExists` | `Boolean` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

### `IAlignmentGeologyContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IAlignmentGeologyContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `AlignmentGeology` | `get` | No | `` |

### `IBoreholeTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IBoreholeTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |

### `IConePenetrationTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IConePenetrationTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConePenetrationTestTable` | `ConePenetrationTestTable` | `get` | No | `` |

### `IDynamicAlignmentGeologyContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IDynamicAlignmentGeologyContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Geology` | `DynamicGeology` | `get` | No | `` |

### `IGlobalGeologyContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IGlobalGeologyContainer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Glg.ILabTableContainer, Topomatic.Glg.IBoreholeTableContainer, Topomatic.Glg.IGroundTableContainer, Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Glg.IConePenetrationTableContainer, Topomatic.Glg.IImpellerTestTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `Style` | `GlobalGeologyStyle` | `get` | No | `` |

### `IGroundTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IGroundTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GroundTable` | `GroundTable` | `get` | No | `` |

### `IImpellerConstTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IImpellerConstTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `` |

### `IImpellerTestTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.IImpellerTestTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ImpellerTestTable` | `ImpellerTestTable` | `get` | No | `` |

### `ILabTableContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ILabTableContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LabTable` | `LabTable` | `get` | No | `` |

### `ILabTableModelCollectionContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ILabTableModelCollectionContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LabTableModels` | `IEnumerable<Object>` | `get` | No | `` |

### `ISolveCancellator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ISolveCancellator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsCancel` | `Boolean` | `get` | No | `` |

### `PosClassification` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlgSolveLib+PosClassification` |
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
      - `Topomatic.Glg.GlgSolveLib+PosClassification`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CLASSIFY_POS_BEHIND` | `PosClassification` | Yes | `CLASSIFY_POS_BEHIND` | `` |
| `CLASSIFY_POS_BETWEEN` | `PosClassification` | Yes | `CLASSIFY_POS_BETWEEN` | `` |
| `CLASSIFY_POS_BEYOND` | `PosClassification` | Yes | `CLASSIFY_POS_BEYOND` | `` |
| `CLASSIFY_POS_DESTINATION` | `PosClassification` | Yes | `CLASSIFY_POS_DESTINATION` | `` |
| `CLASSIFY_POS_LEFT` | `PosClassification` | Yes | `CLASSIFY_POS_LEFT` | `` |
| `CLASSIFY_POS_ORIGIN` | `PosClassification` | Yes | `CLASSIFY_POS_ORIGIN` | `` |
| `CLASSIFY_POS_RIGHT` | `PosClassification` | Yes | `CLASSIFY_POS_RIGHT` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CLASSIFY_POS_LEFT` | `0` |
| `CLASSIFY_POS_RIGHT` | `1` |
| `CLASSIFY_POS_BEYOND` | `2` |
| `CLASSIFY_POS_BEHIND` | `3` |
| `CLASSIFY_POS_BETWEEN` | `4` |
| `CLASSIFY_POS_ORIGIN` | `5` |
| `CLASSIFY_POS_DESTINATION` | `6` |

**Underlying Type**: `System.Int32`

### `SegmCrossResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.GlgSolveLib+SegmCrossResult` |
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
      - `Topomatic.Glg.GlgSolveLib+SegmCrossResult`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossAtEndPointsAndSegsNoLieOnSameLine` | `SegmCrossResult` | Yes | `CrossAtEndPointsAndSegsNoLieOnSameLine` | `` |
| `CrossAtMoreThanOnePointAndSegsLieOnSameLine` | `SegmCrossResult` | Yes | `CrossAtMoreThanOnePointAndSegsLieOnSameLine` | `` |
| `CrossAtOnePointAndSegsLieOnSameLine` | `SegmCrossResult` | Yes | `CrossAtOnePointAndSegsLieOnSameLine` | `` |
| `CrossAtOnePointNoMatchWithEndPointsAndSegsNoLieOnSameLine` | `SegmCrossResult` | Yes | `CrossAtOnePointNoMatchWithEndPointsAndSegsNoLieOnSameLine` | `` |
| `CrossPointLiesOnOneSegAndItIsEndPointOfOtherSeg` | `SegmCrossResult` | Yes | `CrossPointLiesOnOneSegAndItIsEndPointOfOtherSeg` | `` |
| `NoCrossAndSegsLieOnSameLine` | `SegmCrossResult` | Yes | `NoCrossAndSegsLieOnSameLine` | `` |
| `NoCrossAndSegsNoLieOnSameLine` | `SegmCrossResult` | Yes | `NoCrossAndSegsNoLieOnSameLine` | `` |
| `NoCrossSegsLieOnParallelLines` | `SegmCrossResult` | Yes | `NoCrossSegsLieOnParallelLines` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CrossAtOnePointAndSegsLieOnSameLine` | `0` |
| `NoCrossAndSegsLieOnSameLine` | `1` |
| `CrossAtMoreThanOnePointAndSegsLieOnSameLine` | `2` |
| `NoCrossSegsLieOnParallelLines` | `3` |
| `NoCrossAndSegsNoLieOnSameLine` | `4` |
| `CrossAtEndPointsAndSegsNoLieOnSameLine` | `5` |
| `CrossPointLiesOnOneSegAndItIsEndPointOfOtherSeg` | `6` |
| `CrossAtOnePointNoMatchWithEndPointsAndSegsNoLieOnSameLine` | `7` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Glg.Boreholes`

### `Assay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.Assay` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(AssayType type, Double depth, Double endDepth)`
- `.ctor(AssayType type, String probeNumber, Double depth, Double endDepth)`
- `.ctor(AssayType type, String cipher, String probeNumber, Double depth, Double endDepth)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cipher` | `String` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `EndDepth` | `Double` | `get` | No | `` |
| `ProbeNumber` | `String` | `get` | No | `` |
| `Type` | `AssayType` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `AssayType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.AssayType` |
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
      - `Topomatic.Glg.Boreholes.AssayType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DisturbedGround` | `AssayType` | Yes | `DisturbedGround` | `` |
| `Gross` | `AssayType` | Yes | `Gross` | `` |
| `Last` | `AssayType` | Yes | `Last` | `` |
| `None` | `AssayType` | Yes | `None` | `` |
| `UnDisturbedGround` | `AssayType` | Yes | `UnDisturbedGround` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Water` | `AssayType` | Yes | `Water` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Water` | `1` |
| `DisturbedGround` | `2` |
| `UnDisturbedGround` | `3` |
| `Gross` | `4` |
| `Last` | `5` |

**Underlying Type**: `System.Int32`

### `AssayTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.AssayTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Boreholes.AssayTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `Borehole` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.Borehole` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Boreholes.BoreholeGround, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Boreholes.BoreholeGround, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Boreholes.BoreholeGround, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Glg.IGroundTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Boreholes.Borehole`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object owner, Borehole borehole)`
- `.ctor(Object owner, Guid id)`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArchiveNumber` | `String` | `get/set` | No | `` |
| `Assays` | `IEnumerable<Assay>` | `get` | No | `` |
| `BoreholeType` | `BoreholeType` | `get/set` | No | `` |
| `BoringDate` | `String` | `get/set` | No | `` |
| `BulkCalculate` | `Boolean` | `get/set` | No | `` |
| `ConstructionType` | `String` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DrillingEquipmentType` | `String` | `get/set` | No | `` |
| `FrostLevelsTable` | `BoreholeFrostLevelsTable` | `get` | No | `` |
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `IsFictive` | `Boolean` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `BoreholeGround` | `get/set` | No | `` |
| `Marked` | `Boolean` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get` | No | `` |
| `SeasonFrostDepth` | `Nullable<Double>` | `get/set` | No | `` |
| `SeasonMeasurement` | `Boolean` | `get` | No | `` |
| `SeasonThawingDepth` | `Nullable<Double>` | `get/set` | No | `` |
| `WaterPlaneLevelsTable` | `BoreholeWaterPlaneLevelsTable` | `get` | No | `` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |
| `Z` | `Double` | `get/set` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BoreholeGround item` | `` |
| `Assign` | `Void` | `Borehole borehole` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `Contains` | `Boolean` | `BoreholeGround item` | `` |
| `CopyTo` | `Void` | `BoreholeGround[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<BoreholeGround>` | `` | `` |
| `IndexOf` | `Int32` | `BoreholeGround item` | `` |
| `Insert` | `Void` | `Int32 index, BoreholeGround item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext serializationContext` | `` |
| `Remove` | `Boolean` | `BoreholeGround item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext serializationContext` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxGeologyBorehole"` | `` |

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
| `IGroundTableContainer` | `get_GroundTable` |

### `BoreholeFrostLevel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeFrostLevel` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomLevel` | `Nullable<Double>` | `get/set` | No | `` |
| `TopLevel` | `Nullable<Double>` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BoreholeFrostLevelsTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeFrostLevelsTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Boreholes.BoreholeFrostLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Boreholes.BoreholeFrostLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Boreholes.BoreholeFrostLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Boreholes.BoreholeFrostLevelsTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `BoreholeFrostLevel` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BoreholeFrostLevel item` | `` |
| `Assign` | `Void` | `BoreholeFrostLevelsTable boreholeFrostLevelTable` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BoreholeFrostLevel item` | `` |
| `CopyTo` | `Void` | `BoreholeFrostLevel[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<BoreholeFrostLevel>` | `` | `` |
| `IndexOf` | `Int32` | `BoreholeFrostLevel item` | `` |
| `Insert` | `Void` | `Int32 index, BoreholeFrostLevel item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BoreholeFrostLevel item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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

### `BoreholeGround` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeGround` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Boreholes.BoreholeGround`

#### Constructors (4)

- `.ctor(Object owner)`
- `.ctor(Object owner, BoreholeGround ground)`
- `.ctor(Object owner, Ground ground)`
- `.ctor(Object owner, Ground ground, Double depth)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CuttingIndex` | `Int32` | `get/set` | No | `` |
| `Depth` | `Double` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `ExcavationCategory` | `String` | `get/set` | No | `` |
| `Genesis` | `String` | `get/set` | No | `` |
| `Ground` | `Ground` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `GroundTable groundTable, StgNode node, ISerializationContext serializationContext` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext serializationContext` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxGeologyBoreholeGround"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BoreholeTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Glg.Boreholes.Borehole, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IHandledObject, Topomatic.Glg.ILabTableContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Glg.IGroundTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Boreholes.BoreholeTable`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Guid id)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Borehole` | `get/set` | No | `` |
| `LabTable` | `LabTable` | `get` | No | `` |
| `Lines` | `GeologyStructureLines` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Refresh` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Borehole item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `Contains` | `Boolean` | `Borehole item` | `` |
| `ContainsWithNumber` | `Boolean` | `String number` | `` |
| `CopyTo` | `Void` | `Borehole[] array, Int32 arrayIndex` | `` |
| `GetBorehole` | `Borehole` | `Guid id` | `` |
| `GetEnumerator` | `IEnumerator<Borehole>` | `` | `` |
| `IndexOf` | `Int32` | `Borehole item` | `` |
| `Insert` | `Void` | `Int32 index, Borehole item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext serializationContext` | `` |
| `LoadFromStg` | `Void` | `StgNode node, GroundTable groundTable, ISerializationContext serializationContext` | `` |
| `Remove` | `Boolean` | `Borehole item` | `` |
| `Remove` | `Boolean` | `Guid id` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveWithNumber` | `Boolean` | `String number` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext serializationContext` | `` |
| `TryGetBorehole` | `Boolean` | `Guid id, ref Borehole value` | `` |
| `TryGetBoreholeWithNumber` | `Boolean` | `String number, ref Borehole value` | `` |

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
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `ILabTableContainer` | `get_LabTable` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IGroundTableContainer` | `get_GroundTable` |

### `BoreholeType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeType` |
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
      - `Topomatic.Glg.Boreholes.BoreholeType`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Borehole` | `BoreholeType` | Yes | `Borehole` | `` |
| `BorePit` | `BoreholeType` | Yes | `BorePit` | `` |
| `ClearingHole` | `BoreholeType` | Yes | `ClearingHole` | `` |
| `DigHole` | `BoreholeType` | Yes | `DigHole` | `` |
| `Pipe` | `BoreholeType` | Yes | `Pipe` | `` |
| `Pit` | `BoreholeType` | Yes | `Pit` | `` |
| `SoundingHole` | `BoreholeType` | Yes | `SoundingHole` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DigHole` | `0` |
| `SoundingHole` | `1` |
| `ClearingHole` | `2` |
| `Borehole` | `3` |
| `Pit` | `4` |
| `BorePit` | `5` |
| `Pipe` | `6` |

**Underlying Type**: `System.Int32`

### `BoreholeTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Boreholes.BoreholeTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `BoreholeWaterPlaneLevel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevel` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevel`

#### Constructors (2)

- `.ctor(BoreholeWaterPlaneLevelsTable owner)`
- `.ctor(Nullable<Double> waterPlane, Nullable<Double> estWaterPlane, BoreholeWaterPlaneLevelsTable owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AbsoluteEstWaterPlane` | `Nullable<Double>` | `get/set` | No | `` |
| `AbsoluteWaterPlane` | `Nullable<Double>` | `get/set` | No | `` |
| `EstWaterPlane` | `Nullable<Double>` | `get/set` | No | `` |
| `EstWaterPlaneDate` | `String` | `get/set` | No | `` |
| `Flooding` | `Boolean` | `get/set` | No | `` |
| `FloodingAbsElevation` | `Nullable<Double>` | `get` | No | `` |
| `FloodingElevation` | `Nullable<Double>` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Table` | `BoreholeWaterPlaneLevelsTable` | `get` | No | `` |
| `WaterPlane` | `Nullable<Double>` | `get/set` | No | `` |
| `WaterPlaneDate` | `String` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `BoreholeWaterPlaneLevel boreholeWaterPlaneLevel` | `` |
| `Equals` | `Boolean` | `BoreholeWaterPlaneLevel boreholeWaterPlaneLevel` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BoreholeWaterPlaneLevelsTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevelsTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevel, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Boreholes.BoreholeWaterPlaneLevelsTable`

#### Constructors (2)

- `.ctor(Borehole borehole)`
- `.ctor(Borehole borehole, IEnumerable<BoreholeWaterPlaneLevel> collection)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borehole` | `Borehole` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `HasValues` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `BoreholeWaterPlaneLevel` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BoreholeWaterPlaneLevel item` | `` |
| `Assign` | `Void` | `BoreholeWaterPlaneLevelsTable boreholeFrostLevelTable` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BoreholeWaterPlaneLevel item` | `` |
| `CopyTo` | `Void` | `BoreholeWaterPlaneLevel[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `BoreholeWaterPlaneLevelsTable waterPlaneLevelsTable` | `` |
| `GetEnumerator` | `IEnumerator<BoreholeWaterPlaneLevel>` | `` | `` |
| `IndexOf` | `Int32` | `BoreholeWaterPlaneLevel item` | `` |
| `Insert` | `Void` | `Int32 index, BoreholeWaterPlaneLevel item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromStgOld` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BoreholeWaterPlaneLevel item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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

### `DummyType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.DummyType` |
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
      - `Topomatic.Glg.Boreholes.DummyType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossSectionOnly` | `DummyType` | Yes | `CrossSectionOnly` | `` |
| `No` | `DummyType` | Yes | `No` | `` |
| `ProfileOnly` | `DummyType` | Yes | `ProfileOnly` | `` |
| `value__` | `Int32` | No | `` | `` |
| `YesEverywhere` | `DummyType` | Yes | `YesEverywhere` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `No` | `0` |
| `YesEverywhere` | `1` |
| `ProfileOnly` | `2` |
| `CrossSectionOnly` | `3` |

**Underlying Type**: `System.Int32`

### `DummyTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Boreholes.DummyTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Boreholes.DummyTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Glg.Contours`

### `ContourGroundTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Contours.ContourGroundTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Glg.Contours.ContourGroundTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `GeologyContour` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Contours.GeologyContour` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Contours.GeologyContour`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, GroundReference ground)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSignExScale` | `Double` | `get` | No | `SRCategory, ConditionalBrowsable, DefaultDouble, SRDisplayName` |
| `AreaSignExWrapper` | `AreaSignWrapper` | `get` | No | `SRDisplayName, ConditionalBrowsable, SRCategory` |
| `AreaSignScale` | `Double` | `get` | No | `SRCategory, ConditionalBrowsable, DefaultDouble, SRDisplayName` |
| `AreaSignWrapper` | `AreaSignWrapper` | `get` | No | `SRCategory, ConditionalBrowsable, SRDisplayName` |
| `Count` | `Int32` | `get` | No | `SRDisplayName, SRCategory` |
| `Ground` | `GroundReference` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, SRCategory, ConditionalReadOnly, SRDisplayName, PropertyUpdateSequence` |
| `GroundColor` | `CadColor` | `get` | No | `SRCategory, ByLayer, ConditionalBrowsable, ByBlock, SRDisplayName` |
| `GroundWrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `ConditionalBrowsable, SRCategory, ReadOnly, WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |
| `HatchExScale` | `CadColor` | `get` | No | `ByLayer, SRDisplayName, SRCategory, ByBlock, ConditionalBrowsable` |
| `InnerContours` | `IList<GeologyContour>` | `get` | No | `Browsable` |
| `IsEmpty` | `Boolean` | `get` | No | `Browsable` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `ParentContour` | `GeologyContour` | `get` | No | `Browsable` |
| `Scale` | `Double` | `get/set` | No | `SRDescription, SRDisplayName, StepValue, MaxMinValue, SRCategory, PropertyEditor` |

#### Instance Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Vector2D item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Vector2D item` | `` |
| `ContainsContor` | `Boolean` | `GeologyContour geologyContour` | `Browsable` |
| `ContainsGround` | `Boolean` | `Ground ground` | `` |
| `CopyTo` | `Void` | `Vector2D[] array, Int32 arrayIndex` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<Vector2D>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IndexOf` | `Int32` | `Vector2D item` | `` |
| `Insert` | `Void` | `Int32 index, Vector2D item` | `` |
| `IntersectSnap` | `Boolean` | `BoundingBox2D box` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Vector2D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Glg.Cpt`

### `ConePenetrationTest` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.ConePenetrationTest` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Cpt.ConePenetrationTestMeasuring, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Cpt.ConePenetrationTest`

#### Constructors (3)

- `.ctor(Object parent, ConePenetrationTest cptData)`
- `.ctor(Object parent, Guid id)`
- `.ctor(Object parent, Guid id, SondeType penetrometerType)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeReference` | `Guid` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsFictive` | `Boolean` | `get/set` | No | `` |
| `Item` | `ConePenetrationTestMeasuring` | `get` | No | `` |
| `MaxQc` | `Double` | `get` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PenetrometerType` | `SondeType` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get` | No | `` |
| `ProbingUnitType` | `String` | `get/set` | No | `` |
| `TestingDate` | `String` | `get/set` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |
| `Z` | `Double` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `ConePenetrationTestMeasuring` | `` | `` |
| `Assign` | `Void` | `ConePenetrationTest cptData` | `` |
| `Clear` | `Void` | `` | `` |
| `Clone` | `ConePenetrationTest` | `Object parent` | `` |
| `CreateItem` | `ConePenetrationTestMeasuring` | `` | `` |
| `GetEnumerator` | `IEnumerator<ConePenetrationTestMeasuring>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConePenetrationTestExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.ConePenetrationTestExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinkedBorehole` | `Borehole` | `ConePenetrationTest conePenetrationTest` | `Extension` |

### `ConePenetrationTestMeasuring` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Qc` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `ConePenetrationTestMeasuring source` | `` |
| `Clone` | `ConePenetrationTestMeasuring` | `Object parent` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConePenetrationTestTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.ConePenetrationTestTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Glg.Cpt.ConePenetrationTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Cpt.ConePenetrationTestTable`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ConePenetrationTest` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Refresh` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ConePenetrationTest item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `Contains` | `Boolean` | `ConePenetrationTest item` | `` |
| `CopyTo` | `Void` | `ConePenetrationTest[] array, Int32 arrayIndex` | `` |
| `FindByBoehole` | `ConePenetrationTest[]` | `Guid boreholeReference` | `` |
| `GetEnumerator` | `IEnumerator<ConePenetrationTest>` | `` | `` |
| `IndexOf` | `Int32` | `ConePenetrationTest item` | `` |
| `Insert` | `Void` | `Int32 index, ConePenetrationTest item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Guid id` | `` |
| `Remove` | `Boolean` | `ConePenetrationTest item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Guid id, ref ConePenetrationTest value` | `` |

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

### `ElectricalConePenetrationTestMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.ElectricalConePenetrationTestMeasuring` |
| **Base Type** | `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring`
      - `Topomatic.Glg.Cpt.ElectricalConePenetrationTestMeasuring`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Fs` | `Double` | `get/set` | No | `` |
| `Rf` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `ConePenetrationTestMeasuring source` | `` |
| `Clone` | `ConePenetrationTestMeasuring` | `Object parent` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MechanicalConePenetrationTestMeasuring` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.MechanicalConePenetrationTestMeasuring` |
| **Base Type** | `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Cpt.ConePenetrationTestMeasuring`
      - `Topomatic.Glg.Cpt.MechanicalConePenetrationTestMeasuring`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Qs` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `ConePenetrationTestMeasuring source` | `` |
| `Clone` | `ConePenetrationTestMeasuring` | `Object parent` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SondeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Cpt.SondeType` |
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
      - `Topomatic.Glg.Cpt.SondeType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Electrical` | `SondeType` | Yes | `Electrical` | `` |
| `Mechanical` | `SondeType` | Yes | `Mechanical` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Mechanical` | `0` |
| `Electrical` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Glg.Design`

### `AreaSignWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Design.AreaSignWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Guid id)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `AreaSign` | `get` | No | `` |
| `Caption` | `String` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.Glg.EditableItems`

### `ConePenetrationEditableItemKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.EditableItems.ConePenetrationEditableItemKey` |
| **Base Type** | `Topomatic.Glg.EditableItems.GuidEditableItemKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Glg.EditableItems.GuidEditableItemKey`
      - `Topomatic.Glg.EditableItems.ConePenetrationEditableItemKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Guid guid, Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IndexInBorehole` | `Int32` | `get` | No | `` |

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

### `ConePenetrationReferenceEditableItemKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.EditableItems.ConePenetrationReferenceEditableItemKey` |
| **Base Type** | `Topomatic.Glg.EditableItems.ReferenceEditableItemKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Glg.EditableItems.ReferenceEditableItemKey`
      - `Topomatic.Glg.EditableItems.ConePenetrationReferenceEditableItemKey`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(GuidReference reference)`
- `.ctor(GuidReference reference, Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IndexInBorehole` | `Int32` | `get` | No | `` |

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

### `GuidEditableItemKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.EditableItems.GuidEditableItemKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Glg.EditableItems.GuidEditableItemKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Guid value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get` | No | `` |

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

### `ReferenceEditableItemKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.EditableItems.ReferenceEditableItemKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Glg.EditableItems.ReferenceEditableItemKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(GuidReference reference)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CollectionUid` | `UInt32` | `get` | No | `` |
| `OldUid` | `Nullable<Guid>` | `get` | No | `Obsolete` |
| `Uid` | `UInt32` | `get` | No | `` |

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

### `TextOffsetEditableItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.EditableItems.TextOffsetEditableItem` |
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
      - `Topomatic.Glg.EditableItems.TextOffsetEditableItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawJoinLine` | `Boolean` | `get/set` | No | `` |
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

---
## Namespace: `Topomatic.Glg.FastDijkstra`

### `BinaryPriorityQueue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.BinaryPriorityQueue` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable, Topomatic.Glg.FastDijkstra.IPriorityQueue, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (4)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 C)`
- `.ctor(IComparer c)`
- `.ctor(IComparer c, Int32 Capacity)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `Peek` | `Object` | `` | `` |
| `Pop` | `Object` | `` | `` |
| `Push` | `Int32` | `Object O` | `` |
| `Update` | `Void` | `Int32 i` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ReadOnly` | `BinaryPriorityQueue` | `BinaryPriorityQueue P` | `` |
| `Syncronized` | `BinaryPriorityQueue` | `BinaryPriorityQueue P` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |
| `IPriorityQueue` | `Push` |
| `IPriorityQueue` | `Pop` |
| `IPriorityQueue` | `Peek` |
| `IPriorityQueue` | `Update` |
| `IList` | `System.Collections.IList.get_Item` |
| `IList` | `System.Collections.IList.set_Item` |
| `IList` | `System.Collections.IList.Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `System.Collections.IList.get_IsReadOnly` |
| `IList` | `System.Collections.IList.get_IsFixedSize` |
| `IList` | `System.Collections.IList.IndexOf` |
| `IList` | `System.Collections.IList.Insert` |
| `IList` | `System.Collections.IList.Remove` |
| `IList` | `System.Collections.IList.RemoveAt` |
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `DijkstraFast` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.DijkstraFast` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 totalNodeCount, InternodeTraversalCost traversalCost, NearbyNodesHint hint)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMinimumPath` | `Int32[]` | `Int32 start, Int32 finish, ref Single minDist` | `` |
| `Perform` | `Results` | `Int32 start` | `` |
| `Perform2` | `Results` | `Int32 start` | `` |

#### Nested Types (4)

- `InternodeTraversalCost` (class)
- `NearbyNodesHint` (class)
- `QueueElement` (class)
- `Results` (struct)

### `HeapNode` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.HeapNode` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.FastDijkstra.HeapNode`

#### Constructors (1)

- `.ctor(Int32 i, Single w)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `index` | `Int32` | No | `` | `` |
| `weight` | `Single` | No | `` | `` |

### `InternodeTraversalCost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.DijkstraFast+InternodeTraversalCost` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Glg.FastDijkstra.DijkstraFast+InternodeTraversalCost`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Int32 start, Int32 finish, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Single` | `IAsyncResult result` | `` |
| `Invoke` | `Single` | `Int32 start, Int32 finish` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IPriorityQueue` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.IPriorityQueue` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Peek` | `Object` | `` | `` |
| `Pop` | `Object` | `` | `` |
| `Push` | `Int32` | `Object O` | `` |
| `Update` | `Void` | `Int32 i` | `` |

### `NearbyNodesHint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.DijkstraFast+NearbyNodesHint` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Glg.FastDijkstra.DijkstraFast+NearbyNodesHint`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `Int32 startingNode, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `IEnumerable<Int32>` | `IAsyncResult result` | `` |
| `Invoke` | `IEnumerable<Int32>` | `Int32 startingNode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `QueueElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.DijkstraFast+QueueElement` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IComparable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 i, Single val)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareTo` | `Int32` | `Object obj` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `index` | `Int32` | No | `` | `` |
| `weight` | `Single` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparable` | `CompareTo` |

### `Results` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.FastDijkstra.DijkstraFast+Results` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.FastDijkstra.DijkstraFast+Results`

#### Constructors (1)

- `.ctor(Int32[] minimumPath, Single[] minimumDistance)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MinimumDistance` | `Single[]` | No | `` | `` |
| `MinimumPath` | `Int32[]` | No | `` | `` |

---
## Namespace: `Topomatic.Glg.Grounds`

### `Ground` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.Ground` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Glg.IGroundTableContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Grounds.Ground`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Guid id)`

#### Properties (25)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `AreaSign` | `get` | No | `` |
| `AreaSignCaption` | `String` | `get` | No | `` |
| `AreaSignEx` | `AreaSign` | `get` | No | `` |
| `AreaSignExCaption` | `String` | `get` | No | `` |
| `AreaSignExId` | `Guid` | `get` | No | `` |
| `AreaSignId` | `Guid` | `get` | No | `` |
| `BeddingGroup` | `Int32` | `get/set` | No | `` |
| `Cipher` | `String` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Density` | `GroundDensity` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DrillingCategory` | `String` | `get/set` | No | `` |
| `ExcavationCategory` | `String` | `get/set` | No | `` |
| `Genesis` | `String` | `get/set` | No | `` |
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `HatchExColor` | `CadColor` | `get/set` | No | `` |
| `HatchExScale` | `Double` | `get/set` | No | `` |
| `HatchScale` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parallel3D` | `Boolean` | `get/set` | No | `` |
| `State` | `GroundState` | `get/set` | No | `` |
| `Subsidence` | `GroundSubsidense` | `get/set` | No | `` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplayProperties` | `Void` | `IEnumerable<ImProperty> imProperties` | `` |
| `Assign` | `Void` | `Ground ground` | `` |
| `Assign` | `Void` | `TypedObject aggregates` | `` |
| `ClearWedgingOrders` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetCustomHatch` | `Void` | `Guid id, String caption, AreaSign areaSign` | `` |
| `SetCustomHatchEx` | `Void` | `Guid id, String caption, AreaSign areaSign` | `` |
| `SetWedgingOrder` | `Void` | `UInt32 cuttingIndex, UInt32 wedgingOrder` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetGuid` | `Boolean` | `String tag, ref Guid guid` | `` |
| `TryGetWedgingOrder` | `Boolean` | `UInt32 cuttingIndex, ref UInt32 wedgingOrder` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxGeologyGround"` | `` |
| `SEMANTIC_CODE` | `Int32` | Yes | `999` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IGroundTableContainer` | `get_GroundTable` |

### `GroundDensity` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundDensity` |
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
      - `Topomatic.Glg.Grounds.GroundDensity`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dense` | `GroundDensity` | Yes | `Dense` | `` |
| `Mellow` | `GroundDensity` | Yes | `Mellow` | `` |
| `MiddleDense` | `GroundDensity` | Yes | `MiddleDense` | `` |
| `None` | `GroundDensity` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Dense` | `1` |
| `MiddleDense` | `2` |
| `Mellow` | `3` |

**Underlying Type**: `System.Int32`

### `GroundDensityTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundDensityTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Grounds.GroundDensityTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GroundState` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundState` |
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
      - `Topomatic.Glg.Grounds.GroundState`

#### Fields (13)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Damp` | `GroundState` | Yes | `Damp` | `` |
| `DifPlastic` | `GroundState` | Yes | `DifPlastic` | `` |
| `Dry` | `GroundState` | Yes | `Dry` | `` |
| `Fluid` | `GroundState` | Yes | `Fluid` | `` |
| `FluidPlastic` | `GroundState` | Yes | `FluidPlastic` | `` |
| `Frost` | `GroundState` | Yes | `Frost` | `` |
| `HalfSolid` | `GroundState` | Yes | `HalfSolid` | `` |
| `None` | `GroundState` | Yes | `None` | `` |
| `Plastic` | `GroundState` | Yes | `Plastic` | `` |
| `SoftPlastic` | `GroundState` | Yes | `SoftPlastic` | `` |
| `Solid` | `GroundState` | Yes | `Solid` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WaterSaturated` | `GroundState` | Yes | `WaterSaturated` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Solid` | `1` |
| `HalfSolid` | `2` |
| `DifPlastic` | `3` |
| `Plastic` | `4` |
| `Damp` | `5` |
| `SoftPlastic` | `6` |
| `FluidPlastic` | `7` |
| `Fluid` | `8` |
| `Frost` | `9` |
| `Dry` | `10` |
| `WaterSaturated` | `11` |

**Underlying Type**: `System.Int32`

### `GroundStateTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundStateTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Grounds.GroundStateTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GroundSubsidense` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundSubsidense` |
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
      - `Topomatic.Glg.Grounds.GroundSubsidense`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `First` | `GroundSubsidense` | Yes | `First` | `` |
| `Fourth` | `GroundSubsidense` | Yes | `Fourth` | `` |
| `FourthA` | `GroundSubsidense` | Yes | `FourthA` | `` |
| `None` | `GroundSubsidense` | Yes | `None` | `` |
| `Second` | `GroundSubsidense` | Yes | `Second` | `` |
| `Third` | `GroundSubsidense` | Yes | `Third` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `First` | `1` |
| `Second` | `2` |
| `Third` | `3` |
| `Fourth` | `4` |
| `FourthA` | `5` |

**Underlying Type**: `System.Int32`

### `GroundSubsidenseTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundSubsidenseTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Grounds.GroundSubsidenseTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GroundTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Grounds.GroundTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Grounds.Ground, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Grounds.Ground, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Glg.Grounds.Ground, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Glg.IGroundTableContainer, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Grounds.GroundTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Ground` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Refresh` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Ground item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Ground item` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `CopyTo` | `Void` | `Ground[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<Ground>` | `` | `` |
| `IndexOf` | `Int32` | `Ground item` | `` |
| `Insert` | `Void` | `Int32 index, Ground item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `Ground item` | `` |
| `Remove` | `Boolean` | `Guid id` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetGround` | `Boolean` | `Guid id, ref Ground value` | `` |

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
| `IGroundTableContainer` | `Topomatic.Glg.IGroundTableContainer.get_GroundTable` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

---
## Namespace: `Topomatic.Glg.ImpellerTests`

### `ImpellerConstKeyRec` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Guid id)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Calibrating` | `Double` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `FactoryCalibrationDate` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImpellerConst` | `Double` | `get` | No | `` |
| `Key` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RegularCalibrationDate` | `String` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `ImpellerConstKeyRec source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ImpellerConstTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.ImpellerConstTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Glg.ImpellerTests.ImpellerConstKeyRec, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.ImpellerTests.ImpellerConstTable`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Guid id)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ImpellerConstKeyRec` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ImpellerConstKeyRec item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ImpellerConstKeyRec item` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `CopyTo` | `Void` | `ImpellerConstKeyRec[] array, Int32 arrayIndex` | `` |
| `CreateRecord` | `ImpellerConstKeyRec` | `` | `` |
| `GetEnumerator` | `IEnumerator<ImpellerConstKeyRec>` | `` | `` |
| `IndexOf` | `Int32` | `ImpellerConstKeyRec item` | `` |
| `Insert` | `Void` | `Int32 index, ImpellerConstKeyRec item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ImpellerConstKeyRec item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetRecord` | `Boolean` | `Guid id, ref ImpellerConstKeyRec value` | `` |
| `TryGetRecord` | `Boolean` | `String key, ref ImpellerConstKeyRec value` | `` |

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

### `ImpellerTest` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.ImpellerTest` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.ImpellerTests.ImpellerTestCalculation, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.ImpellerTests.ImpellerTestCalculation, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.ImpellerTests.ImpellerTestCalculation, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.ImpellerTests.ImpellerTest`

#### Constructors (3)

- `.ctor(Object owner)`
- `.ctor(Object parent, ImpellerTest impTest)`
- `.ctor(Object owner, Guid id)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `` |
| `ImpellerTestTable` | `ImpellerTestTable` | `get` | No | `` |
| `IsFictive` | `Boolean` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ImpellerTestCalculation` | `get/set` | No | `` |
| `Key` | `ImpellerConstKeyRec` | `get/set` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get` | No | `` |
| `TestingDate` | `String` | `get/set` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |
| `Z` | `Double` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ImpellerTestCalculation item` | `` |
| `Assign` | `Void` | `ImpellerTest it` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ImpellerTestCalculation item` | `` |
| `CopyTo` | `Void` | `ImpellerTestCalculation[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ImpellerTestCalculation>` | `` | `` |
| `IndexOf` | `Int32` | `ImpellerTestCalculation item` | `` |
| `Insert` | `Void` | `Int32 index, ImpellerTestCalculation item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ImpellerTestCalculation item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

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
| `IImpellerConstTableContainer` | `get_ImpellerConstTable` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ImpellerTestCalculation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.ImpellerTestCalculation` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.ImpellerTests.ImpellerTestCalculation`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `` |
| `M0` | `Nullable<Double>` | `get` | No | `` |
| `MEst` | `Nullable<Double>` | `get` | No | `` |
| `MMax` | `Nullable<Double>` | `get` | No | `` |
| `N0` | `Double` | `get/set` | No | `` |
| `NEst` | `Double` | `get/set` | No | `` |
| `NMax` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Refusing` | `RefusingState` | `get/set` | No | `` |
| `StructuralStrengthIndicator` | `Nullable<Double>` | `get` | No | `` |
| `TauDisturbed` | `Nullable<Double>` | `get` | No | `` |
| `TauDisturbedAlt` | `Nullable<Double>` | `get` | No | `` |
| `TauUnDisturbed` | `Nullable<Double>` | `get` | No | `` |
| `TauUnDisturbedAlt` | `Nullable<Double>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `ImpellerTestCalculation source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ImpellerTestTable` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.ImpellerTestTable` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Glg.ImpellerTests.ImpellerTest, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.ImpellerTests.ImpellerTestTable`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ImpellerTest` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Refresh` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ImpellerTest item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ImpellerTest item` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `CopyTo` | `Void` | `ImpellerTest[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ImpellerTest>` | `` | `` |
| `IndexOf` | `Int32` | `ImpellerTest item` | `` |
| `Insert` | `Void` | `Int32 index, ImpellerTest item` | `` |
| `Load_FromStg` | `Void` | `StgNode node` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ImpellerTest item` | `` |
| `Remove` | `Boolean` | `Guid id` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetImpellerTest` | `Boolean` | `Guid id, ref ImpellerTest value` | `` |

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
| `IImpellerConstTableContainer` | `get_ImpellerConstTable` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RefusingState` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.RefusingState` |
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
      - `Topomatic.Glg.ImpellerTests.RefusingState`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `No` | `RefusingState` | Yes | `No` | `` |
| `Razburka` | `RefusingState` | Yes | `Razburka` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `RefusingState` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `No` | `0` |
| `Yes` | `1` |
| `Razburka` | `2` |

**Underlying Type**: `System.Int32`

### `RefusingStateTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.ImpellerTests.RefusingStateTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.ImpellerTests.RefusingStateTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Glg.Laboratory`

### `AssayRecord` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.AssayRecord` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Glg.Laboratory.AssayValue, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Laboratory.AssayValue, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Laboratory.AssayValue, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<AssayValue> paramValues)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borehole` | `Borehole` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsEnabled` | `Boolean` | `get/set` | No | `` |
| `IsHighlighted` | `Boolean` | `get/set` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsRemoved` | `Boolean` | `get/set` | No | `` |
| `Item` | `AssayValue` | `get/set` | No | `` |
| `SortIndex` | `Int32` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `AssayValue item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `AssayValue item` | `` |
| `CopyTo` | `Void` | `AssayValue[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<AssayValue>` | `` | `` |
| `IndexOf` | `Int32` | `AssayValue item` | `` |
| `Insert` | `Void` | `Int32 index, AssayValue item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `AssayValue item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `AssayValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.AssayValue` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String value)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Format` | `String` | `get/set` | No | `` |
| `Highlighted` | `Boolean` | `get/set` | No | `` |
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `AssayValue source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `FooterRowsVisibility` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.FooterRowsVisibility` |
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
| `Assign` | `Void` | `FooterRowsVisibility source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (26)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Count` | `Boolean` | No | `` | `` |
| `FreedomDegrees` | `Boolean` | No | `` | `` |
| `Koeff85` | `Boolean` | No | `` | `` |
| `Koeff90` | `Boolean` | No | `` | `` |
| `Koeff95` | `Boolean` | No | `` | `` |
| `Koeff975` | `Boolean` | No | `` | `` |
| `Koeff98` | `Boolean` | No | `` | `` |
| `Koeff99` | `Boolean` | No | `` | `` |
| `Maximal` | `Boolean` | No | `` | `` |
| `MiddleSquareDeviation` | `Boolean` | No | `` | `` |
| `MiddleValue` | `Boolean` | No | `` | `` |
| `Minimal` | `Boolean` | No | `` | `` |
| `P85` | `Boolean` | No | `` | `` |
| `P90` | `Boolean` | No | `` | `` |
| `P95` | `Boolean` | No | `` | `` |
| `P975` | `Boolean` | No | `` | `` |
| `P98` | `Boolean` | No | `` | `` |
| `P99` | `Boolean` | No | `` | `` |
| `RootOfFreedomDegrees` | `Boolean` | No | `` | `` |
| `Solved85` | `Boolean` | No | `` | `` |
| `Solved90` | `Boolean` | No | `` | `` |
| `Solved95` | `Boolean` | No | `` | `` |
| `Solved975` | `Boolean` | No | `` | `` |
| `Solved98` | `Boolean` | No | `` | `` |
| `Solved99` | `Boolean` | No | `` | `` |
| `VariationCoeff` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GroundBasic` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.GroundBasic` |
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
| `Cipher` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `ExcavationCategory` | `String` | `get/set` | No | `` |
| `Genesis` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `GroundBasic source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GroundParameterColumn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.GroundParameterColumn` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String id)`
- `.ctor(String id, String name, String group)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ColumnRef` | `String` | `get/set` | No | `` |
| `Format` | `String` | `get/set` | No | `` |
| `Formula` | `String` | `get/set` | No | `` |
| `Group` | `String` | `get/set` | No | `` |
| `IdStr` | `String` | `get/set` | No | `` |
| `IsHidenAsEmpty` | `Boolean` | `get/set` | No | `` |
| `IsVisible` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `SummaryFormat` | `String` | `get/set` | No | `` |
| `SummaryFormula` | `String` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `GroundParameterColumn source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LabTable` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.LabTable` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Laboratory.AssayRecord, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Laboratory.LabTable`

#### Constructors (1)

- `.ctor(Object owner, BoreholeTable boreholeTable)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `ColumnsCount` | `Int32` | `get` | No | `` |
| `ContainsHiddenAsEmptyColumns` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `FooterRowsVisibility` | `FooterRowsVisibility` | `get` | No | `` |
| `FormulaEngine` | `LabTableFormulaEngine` | `get` | No | `` |
| `GroundBasicsList` | `List<GroundBasic>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RowsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (34)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddColumn` | `Int32` | `String columnIdStr, String columnName, String columnGroup` | `` |
| `AddRow` | `Int32` | `` | `` |
| `Assign` | `Void` | `LabTable source` | `` |
| `AssignWeak` | `Void` | `LabTable source` | `` |
| `BeginUpdate` | `Void` | `String caption` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `ClearRows` | `Void` | `` | `` |
| `ColumnIndexOf` | `Int32` | `GroundParameterColumn column` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Evaluate` | `Object` | `String expression, Object[] args` | `` |
| `Evaluate` | `Object` | `Int32 rowIndex, Int32 colIndex` | `` |
| `GetColumn` | `GroundParameterColumn` | `Int32 index` | `` |
| `GetColumnDataList` | `List<AssayValue>` | `Int32 index` | `` |
| `GetColumnIndexByIdStr` | `Int32` | `String idStr` | `` |
| `GetEnumerator` | `IEnumerator<AssayRecord>` | `` | `` |
| `GetHeaderColumn` | `GroundParameterColumn` | `Int32 index` | `` |
| `GetHighlighted` | `Boolean` | `Int32 columnIndex, Int32 index` | `` |
| `GetRawValue` | `String` | `Int32 columnIndex, Int32 index` | `` |
| `GetRow` | `AssayRecord` | `Int32 index` | `` |
| `GetValue` | `String` | `String idStr, Int32 index` | `` |
| `GetValue` | `String` | `Int32 columnIndex, Int32 index` | `` |
| `InsertColumn` | `Void` | `Int32 index, String columnIdStr, String columnName, String columnGroup` | `` |
| `InsertColumn` | `Void` | `Int32 index, GroundParameterColumn column` | `` |
| `InsertRow` | `Void` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveColumn` | `Void` | `Int32 columnIndex` | `` |
| `RemoveRow` | `Void` | `Int32 index` | `` |
| `ResolveBoreholesReferences` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetCellFormat` | `Void` | `Int32 columnIndex, Int32 index, String format` | `` |
| `SetColumnDataList` | `Void` | `Int32 index, List<AssayValue> dataList` | `` |
| `SetHighlighted` | `Void` | `Int32 columnIndex, Int32 index, Boolean value` | `` |
| `SetRowIndex` | `Void` | `Int32 oldIndex, Int32 newIndex` | `` |
| `SetValue` | `Void` | `Int32 columnIndex, Int32 index, String value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamedTransactable` | `BeginUpdate` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |

### `ParameterGroup` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.ParameterGroup` |
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
      - `Topomatic.Glg.Laboratory.ParameterGroup`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Chemical` | `ParameterGroup` | Yes | `Chemical` | `` |
| `Common` | `ParameterGroup` | Yes | `Common` | `` |
| `Ecology` | `ParameterGroup` | Yes | `Ecology` | `` |
| `Frozen` | `ParameterGroup` | Yes | `Frozen` | `` |
| `GarnuloMetric` | `ParameterGroup` | Yes | `GarnuloMetric` | `` |
| `Mechanical` | `ParameterGroup` | Yes | `Mechanical` | `` |
| `Organic` | `ParameterGroup` | Yes | `Organic` | `` |
| `Physical` | `ParameterGroup` | Yes | `Physical` | `` |
| `Rock` | `ParameterGroup` | Yes | `Rock` | `` |
| `Test` | `ParameterGroup` | Yes | `Test` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Common` | `0` |
| `GarnuloMetric` | `1` |
| `Physical` | `2` |
| `Organic` | `3` |
| `Mechanical` | `4` |
| `Frozen` | `5` |
| `Rock` | `6` |
| `Test` | `7` |
| `Chemical` | `8` |
| `Ecology` | `9` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Glg.Laboratory.Formulae`

### `Expression` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.Expression` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IComparable`1[[Topomatic.Glg.Laboratory.Formulae.Expression, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareTo` | `Int32` | `Expression other` | `` |
| `Evaluate` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparable`1` | `CompareTo` |

### `FormulaEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.FormulaEngine` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CultureInfo` | `CultureInfo` | `get/set` | No | `` |
| `Functions` | `Dictionary<String FunctionDefinition>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Evaluate` | `Object` | `String expression, Object[] args` | `` |
| `GetExternalObject` | `Object` | `String identifier, Object[] args` | `` |
| `Parse` | `Expression` | `String expression, Object[] args` | `` |
| `RegisterFunction` | `Void` | `String functionName, Int32 parmMin, Int32 parmMax, FormulaEngineFunction fn, FuncDefCategory category, String description, String syntax` | `` |
| `RegisterFunction` | `Void` | `String functionName, Int32 parmCount, FormulaEngineFunction fn, FuncDefCategory category, String descrition, String syntax` | `` |

### `FormulaEngineFunction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.FormulaEngineFunction` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Glg.Laboratory.Formulae.FormulaEngineFunction`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `List<Expression> parameters, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Object` | `IAsyncResult result` | `` |
| `Invoke` | `Object` | `List<Expression> parameters` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FuncDefCategory` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.FuncDefCategory` |
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
      - `Topomatic.Glg.Laboratory.Formulae.FuncDefCategory`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Logical` | `FuncDefCategory` | Yes | `Logical` | `` |
| `Mathematical` | `FuncDefCategory` | Yes | `Mathematical` | `` |
| `None` | `FuncDefCategory` | Yes | `None` | `` |
| `Textual` | `FuncDefCategory` | Yes | `Textual` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Logical` | `1` |
| `Mathematical` | `2` |
| `Textual` | `3` |

**Underlying Type**: `System.Int32`

### `FuncDefCategoryConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.FuncDefCategoryConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Laboratory.Formulae.FuncDefCategoryConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `FunctionDefinition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.FunctionDefinition` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 parmMin, Int32 parmMax, FormulaEngineFunction function, FuncDefCategory category, String desc, String syntax)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `FuncDefCategory` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Function` | `FormulaEngineFunction` | `get` | No | `` |
| `ParmMax` | `Int32` | `get` | No | `` |
| `ParmMin` | `Int32` | `get` | No | `` |
| `Syntax` | `String` | `get` | No | `` |

### `IValueObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.IValueObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |

### `LabTableFormulaEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Laboratory.Formulae.LabTableFormulaEngine` |
| **Base Type** | `Topomatic.Glg.Laboratory.Formulae.FormulaEngine` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Laboratory.Formulae.FormulaEngine`
    - `Topomatic.Glg.Laboratory.Formulae.LabTableFormulaEngine`

#### Constructors (1)

- `.ctor(LabTable parentLabTable)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetExternalObject` | `Object` | `String identifier, Object[] args` | `` |

---
## Namespace: `Topomatic.Glg.Permafrost`

### `FrostBorderTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.FrostBorderTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Permafrost.FrostBorderTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GeologyLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GeologyLine` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.Permafrost.GeologyLine`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `SRDisplayName` |
| `GroundColor` | `CadColor` | `get/set` | No | `SRDisplayName, ByLayer, SRCategory, ByBlock` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `SmtLine` | `GlgSmtLine` | `get/set` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `SRCategory, WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Vector2D item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Vector2D item` | `` |
| `CopyTo` | `Void` | `Vector2D[] array, Int32 arrayIndex` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<Vector2D>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IndexOf` | `Int32` | `Vector2D item` | `` |
| `Insert` | `Void` | `Int32 index, Vector2D item` | `` |
| `IntersectSnap` | `Boolean` | `BoundingBox2D box` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `Vector2D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

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
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `GeologyLines` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GeologyLines` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Glg.Permafrost.GeologyLine, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Permafrost.GeologyLine, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Glg.Permafrost.GeologyLine, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Permafrost.GeologyLines`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `GeologyLine` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `GeologyLine item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `GeologyLine item` | `` |
| `CopyTo` | `Void` | `GeologyLine[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<GeologyLine>` | `` | `` |
| `IndexOf` | `Int32` | `GeologyLine item` | `` |
| `Insert` | `Void` | `Int32 index, GeologyLine item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `GeologyLine item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

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

### `GlgFrostLineBorderType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgFrostLineBorderType` |
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
      - `Topomatic.Glg.Permafrost.GlgFrostLineBorderType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `GlgFrostLineBorderType` | Yes | `Bottom` | `` |
| `Top` | `GlgFrostLineBorderType` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `0` |
| `Bottom` | `1` |

**Underlying Type**: `System.Int32`

### `GlgSmtFrostLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgSmtFrostLine` |
| **Base Type** | `Topomatic.Glg.Permafrost.GlgSmtLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Permafrost.GlgSmtLine`
        - `Topomatic.Glg.Permafrost.GlgSmtFrostLine`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderType` | `GlgFrostLineBorderType` | `get/set` | No | `` |
| `LinearSign` | `LinearSign` | `get` | No | `` |
| `LineType` | `GlgSmtFrostLineLinetype` | `get/set` | No | `` |
| `PARENT_SMDX` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SEMANTIC_CODE` | `Int32` | Yes | `998` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgSmtFrostLineLinetype` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgSmtFrostLineLinetype` |
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
      - `Topomatic.Glg.Permafrost.GlgSmtFrostLineLinetype`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Frost` | `GlgSmtFrostLineLinetype` | Yes | `Frost` | `` |
| `SeasonFrost` | `GlgSmtFrostLineLinetype` | Yes | `SeasonFrost` | `` |
| `SeasonThawing` | `GlgSmtFrostLineLinetype` | Yes | `SeasonThawing` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Frost` | `4` |
| `SeasonFrost` | `6` |
| `SeasonThawing` | `9` |

**Underlying Type**: `System.Int32`

### `GlgSmtLine` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgSmtLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Permafrost.GlgSmtLine`

#### Constructors (1)

- `.ctor(Object owner, Int32 code)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PARENT_SMDX` | `String` | `get` | No | `` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `GlgSmtLine glgSmtLine` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `GlgSmtWaterLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgSmtWaterLine` |
| **Base Type** | `Topomatic.Glg.Permafrost.GlgSmtLine` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Permafrost.GlgSmtLine`
        - `Topomatic.Glg.Permafrost.GlgSmtWaterLine`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LinearSign` | `LinearSign` | `get` | No | `` |
| `PARENT_SMDX` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SEMANTIC_CODE` | `Int32` | Yes | `997` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlgSmtWaterLineType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.GlgSmtWaterLineType` |
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
      - `Topomatic.Glg.Permafrost.GlgSmtWaterLineType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DashDotted` | `GlgSmtWaterLineType` | Yes | `DashDotted` | `` |
| `Solid` | `GlgSmtWaterLineType` | Yes | `Solid` | `` |
| `Supposed` | `GlgSmtWaterLineType` | Yes | `Supposed` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Solid` | `3` |
| `Supposed` | `5` |
| `DashDotted` | `7` |

**Underlying Type**: `System.Int32`

### `SeasonFrostThawingLine` (class)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Permafrost.SeasonFrostThawingLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.Permafrost.SeasonFrostThawingLine`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `Frost` | `Boolean` | `get/set` | No | `` |
| `Holder` | `SemanticDataHolder` | `get` | No | `` |
| `LinearSign` | `LinearSign` | `get` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `UpDirection` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SEMANTIC_CODE` | `Int32` | Yes | `996` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Glg.References`

### `BoreholeCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.BoreholeCollection` |
| **Base Type** | `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.ReferenceCollection`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.References.GuidCollection`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.BoreholeReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
            - `Topomatic.Glg.References.BoreholeCollection`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoreholeReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.BoreholeReference` |
| **Base Type** | `Topomatic.Glg.References.StationedReference` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`
        - `Topomatic.Glg.References.StationedReference`
          - `Topomatic.Glg.References.BoreholeReference`

#### Constructors (2)

- `.ctor(BoreholeCollection collection, BoreholeReference reference)`
- `.ctor(BoreholeCollection collection, Guid id)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borehole` | `Borehole` | `get` | No | `` |
| `DummyType` | `DummyType` | `get/set` | No | `` |
| `ReferenceNumber` | `String` | `get/set` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConePenetrationCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ConePenetrationCollection` |
| **Base Type** | `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.ConePenetrationTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.References.ConePenetrationTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.ReferenceCollection`1[[Topomatic.Glg.References.ConePenetrationTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.References.GuidCollection`1[[Topomatic.Glg.References.ConePenetrationTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.ConePenetrationTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
            - `Topomatic.Glg.References.ConePenetrationCollection`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConePenetrationTestReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ConePenetrationTestReference` |
| **Base Type** | `Topomatic.Glg.References.StationedReference` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`
        - `Topomatic.Glg.References.StationedReference`
          - `Topomatic.Glg.References.ConePenetrationTestReference`

#### Constructors (2)

- `.ctor(ConePenetrationCollection collection, ConePenetrationTestReference reference)`
- `.ctor(ConePenetrationCollection collection, Guid id)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConePenetrationTest` | `ConePenetrationTest` | `get` | No | `` |
| `ReferenceNumber` | `String` | `get/set` | No | `` |
| `SondeType` | `SondeType` | `get/set` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `GeologyReferenceExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GeologyReferenceExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `IGeologyReference reference` | `Extension` |
| `IsEmpty` | `Boolean` | `IGeologyReference reference` | `Extension` |

### `GeologyReferenceKey` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GeologyReferenceKey` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Glg.References.GeologyReferenceKey, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Glg.References.GeologyReferenceKey`

#### Constructors (1)

- `.ctor(ReferenceValue value)`

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertToString` | `String` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `GeologyReferenceKey other` | `` |
| `Find` | `GroundReference` | `AlignmentGeology geology` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, String oldNode` | `Obsolete` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertFromString` | `GeologyReferenceKey` | `String value` | `` |
| `LoadFromStg` | `GeologyReferenceKey` | `StgNode node` | `` |
| `LoadFromStg` | `GeologyReferenceKey` | `StgNode node, String newNode, String oldNode` | `Obsolete` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CollectionUid` | `UInt32` | No | `` | `` |
| `Empty` | `GeologyReferenceKey` | Yes | `` | `` |
| `IsEmpty` | `Boolean` | No | `` | `` |
| `OldId` | `Nullable<Guid>` | No | `` | `Obsolete` |
| `Uid` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `GeologyReferencesExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GeologyReferencesExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearBoreholes` | `Void` | `IGeologyReferences references` | `Extension` |
| `ClearConePenetrations` | `Void` | `IGeologyReferences references` | `Extension` |
| `ClearGrounds` | `Void` | `IGeologyReferences references, Predicate<Guid> match` | `Extension` |
| `ClearGrounds` | `Void` | `IGeologyReferences references` | `Extension` |
| `ClearGrounds` | `Void` | `GroundCollection collection, Predicate<GroundReference> isUsed` | `` |
| `ClearImpellerTests` | `Void` | `IGeologyReferences references` | `Extension` |
| `FindBorehole` | `BoreholeReference` | `IGeologyReferences references, UInt32 collection, UInt32 uid` | `Extension` |
| `FindConePenetrationTest` | `ConePenetrationTestReference` | `IGeologyReferences references, UInt32 collection, UInt32 uid` | `Extension` |
| `FindGround` | `GroundReference` | `IGeologyReferences references, UInt32 collection, UInt32 uid` | `Extension` |
| `FindImpellerTest` | `ImpellerTestReference` | `IGeologyReferences references, UInt32 collection, UInt32 uid` | `Extension` |
| `FindPrefferedBoreholeReference` | `BoreholeReference` | `IGeologyReferences references, Predicate<BoreholeReference> match, UInt32 uid` | `Extension` |
| `FindPrefferedGroundReference` | `GroundReference` | `IGeologyReferences references, Predicate<GroundReference> match, UInt32 uid` | `Extension` |
| `GetBoreholes` | `IEnumerable<BoreholeReference>` | `IGeologyReferences references` | `Extension` |
| `GetBoreholes` | `IEnumerable<BoreholeReference>` | `IGeologyReferences references, Double station` | `Extension` |
| `GetConePenetrations` | `IEnumerable<ConePenetrationTestReference>` | `IGeologyReferences references, Double station` | `Extension` |
| `GetConePenetrations` | `IEnumerable<ConePenetrationTestReference>` | `IGeologyReferences references` | `Extension` |
| `GetGrounds` | `IEnumerable<GroundReference>` | `IGeologyReferences references` | `Extension` |
| `GetImpellerTests` | `IEnumerable<ImpellerTestReference>` | `IGeologyReferences references, Double station` | `Extension` |
| `GetImpellerTests` | `IEnumerable<ImpellerTestReference>` | `IGeologyReferences references` | `Extension` |

### `GeologyRelativeReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GeologyRelativeReference` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Glg.References.IGeologyReference` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.GeologyRelativeReference`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Boreholes` | `BoreholeCollection` | `get` | No | `` |
| `ConePenetrations` | `ConePenetrationCollection` | `get` | No | `` |
| `Grounds` | `GroundCollection` | `get` | No | `` |
| `ImpellerTests` | `ImpellerTestCollection` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RelativePath` | `String` | `get/set` | No | `` |
| `Uid` | `UInt32` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindContainer` | `T` | `` | `` |
| `FindModel` | `Object` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IGeologyReference` | `get_Grounds` |
| `IGeologyReference` | `get_Boreholes` |
| `IGeologyReference` | `get_ConePenetrations` |
| `IGeologyReference` | `get_ImpellerTests` |
| `IGeologyReference` | `get_Uid` |
| `IGeologyReference` | `FindContainer` |

### `GeologyRelativeReferences` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GeologyRelativeReferences` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Glg.References.IGeologyReferences` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.GeologyRelativeReferences`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GeologyRelativeReference` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `GeologyRelativeReference` | `Object projectModel` | `` |
| `Add` | `GeologyRelativeReference` | `String relativePath` | `` |
| `Clear` | `Void` | `` | `` |
| `FindReference` | `IGeologyReference` | `UInt32 uid` | `` |
| `GetReferences` | `IGeologyReference[]` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_UID` | `UInt32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IGeologyReferences` | `FindReference` |
| `IGeologyReferences` | `GetReferences` |

### `GroundCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GroundCollection` |
| **Base Type** | `Topomatic.Glg.References.GuidCollection`1[[Topomatic.Glg.References.GroundReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.References.GroundReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.ReferenceCollection`1[[Topomatic.Glg.References.GroundReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.References.GuidCollection`1[[Topomatic.Glg.References.GroundReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.References.GroundCollection`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindReferences` | `GroundReference[]` | `Guid id` | `` |
| `IndexOf` | `Int32` | `GroundReference item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GroundReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GroundReference` |
| **Base Type** | `Topomatic.Glg.References.GuidReference` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`
        - `Topomatic.Glg.References.GroundReference`

#### Constructors (2)

- `.ctor(GroundCollection owner, GroundReference reference)`
- `.ctor(GroundCollection owner, Guid id)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ground` | `Ground` | `get` | No | `` |
| `ReferenceCipher` | `String` | `get/set` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `GuidCollection`1<T where GuidReference, INamedTransactable, ITransactable, IUpdatable, IOwned, IWrapped, IStgContextSerializable, class, GuidReference>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GuidCollection`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, , Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - ``
        - `Topomatic.Glg.References.GuidCollection`1`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindReferences` | `T[]` | `Guid id` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GuidReference` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.GuidReference` |
| **Base Type** | `Topomatic.Glg.References.ReferenceValue` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`

#### Constructors (1)

- `.ctor(Object owner, Guid id)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ReferenceId` | `Guid` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `IGeologyReference` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.IGeologyReference` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Boreholes` | `BoreholeCollection` | `get` | No | `` |
| `ConePenetrations` | `ConePenetrationCollection` | `get` | No | `` |
| `Grounds` | `GroundCollection` | `get` | No | `` |
| `ImpellerTests` | `ImpellerTestCollection` | `get` | No | `` |
| `Uid` | `UInt32` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindContainer` | `T` | `` | `` |

### `IGeologyReferences` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.IGeologyReferences` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindReference` | `IGeologyReference` | `UInt32 uid` | `` |
| `GetReferences` | `IGeologyReference[]` | `` | `` |

### `ImpellerTestCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ImpellerTestCollection` |
| **Base Type** | `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.ImpellerTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.References.ImpellerTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.ReferenceCollection`1[[Topomatic.Glg.References.ImpellerTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Glg.References.GuidCollection`1[[Topomatic.Glg.References.ImpellerTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
          - `Topomatic.Glg.References.StationedCollection`1[[Topomatic.Glg.References.ImpellerTestReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
            - `Topomatic.Glg.References.ImpellerTestCollection`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImpellerTestReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ImpellerTestReference` |
| **Base Type** | `Topomatic.Glg.References.StationedReference` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`
        - `Topomatic.Glg.References.StationedReference`
          - `Topomatic.Glg.References.ImpellerTestReference`

#### Constructors (2)

- `.ctor(ImpellerTestCollection collection, ImpellerTestReference reference)`
- `.ctor(ImpellerTestCollection collection, Guid id)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ImpellerTest` | `ImpellerTest` | `get` | No | `` |
| `ReferenceNumber` | `String` | `get/set` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `get_WrappedObject` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ReferenceCollection`1<T where ReferenceValue, INamedTransactable, ITransactable, IUpdatable, IOwned, IWrapped, IStgContextSerializable, class, ReferenceValue>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ReferenceCollection`1` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, , Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Glg.References.ReferenceCollection`1`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Owner` | `IGeologyReference` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Boolean` | `T value` | `` |
| `ApplyRange` | `Void` | `IEnumerable<T> values` | `` |
| `Clear` | `Void` | `` | `` |
| `FindReference` | `T` | `UInt32 uid` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Void` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |

### `ReferenceValue` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.ReferenceValue` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CollectionUid` | `UInt32` | `get` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Uid` | `UInt32` | `get/set` | No | `` |
| `WrappedObject` | `Object` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IWrapped` | `get_WrappedObject` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `StationedCollection`1<T where StationedReference, INamedTransactable, ITransactable, IUpdatable, IOwned, IWrapped, IStgContextSerializable, class, StationedReference>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.StationedCollection`1` |
| **Base Type** | `` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, , Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.References.IGeologyReference, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - ``
        - ``
          - `Topomatic.Glg.References.StationedCollection`1`

#### Constructors (1)

- `.ctor(IGeologyReference owner)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindReferences` | `T[]` | `Double station` | `` |
| `FindReferences` | `Void` | `IList<T> references, Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StationedReference` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.References.StationedReference` |
| **Base Type** | `Topomatic.Glg.References.GuidReference` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IWrapped, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Glg.References.ReferenceValue`
      - `Topomatic.Glg.References.GuidReference`
        - `Topomatic.Glg.References.StationedReference`

#### Constructors (2)

- `.ctor(Object collection, StationedReference reference)`
- `.ctor(Object collection, Guid id)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawOnCrs` | `Boolean` | `get/set` | No | `` |
| `DrawOnPln` | `Boolean` | `get/set` | No | `` |
| `DrawOnPrf` | `Boolean` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

---
## Namespace: `Topomatic.Glg.Style`

### `AlignmentGeologyStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.AlignmentGeologyStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Style.GeologyStyleItem, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyle`
    - `Topomatic.Glg.Style.AlignmentGeologyStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeDrawStyle` | `BoreholeDrawStyle` | `get` | No | `` |
| `CommonStyle` | `GeologyCommonStyle` | `get` | No | `` |
| `CrossSectionStyle` | `GeologyCrossSectionStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<GeologyLayerStyleItem>` | `get` | No | `` |
| `PlanStyle` | `GeologyPlanStyleBoreholes` | `get` | No | `` |
| `PlanStyleConePenetration` | `GeologyPlanStyleConePenetration` | `get` | No | `` |
| `PlanStyleDummyDirection` | `GeologyPlanStyleDummyDirection` | `get` | No | `` |
| `PlanStyleImpeller` | `GeologyPlanStyleImpeller` | `get` | No | `` |
| `ProfileStyle` | `GeologyProfileStyle` | `get` | No | `` |

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

### `AssayGrossDepthAlign` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.AssayGrossDepthAlign` |
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
      - `Topomatic.Glg.Style.AssayGrossDepthAlign`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Borders` | `AssayGrossDepthAlign` | Yes | `Borders` | `` |
| `Center` | `AssayGrossDepthAlign` | Yes | `Center` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Center` | `0` |
| `Borders` | `1` |

**Underlying Type**: `System.Int32`

### `AssayGrossDepthAlignConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.AssayGrossDepthAlignConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Style.AssayGrossDepthAlignConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `BoreholeAssayStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.BoreholeAssayStyle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DepthDigits` | `Byte` | `get/set` | No | `` |
| `GrossDepthAlign` | `AssayGrossDepthAlign` | `get/set` | No | `` |
| `GrossDepthDigits` | `Byte` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `ShowAssay` | `Boolean` | `get/set` | No | `` |
| `ShowDepth` | `Boolean` | `get/set` | No | `` |
| `ShowGrossDepth` | `Boolean` | `get/set` | No | `` |
| `ShowGroundCipherForAssay` | `Boolean` | `get/set` | No | `` |
| `ShowProbeNumber` | `Boolean` | `get/set` | No | `` |
| `SignAlign` | `VerticalAlign` | `get/set` | No | `` |
| `SignSize` | `SignSize` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `BoreholeDrawStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.BoreholeDrawStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.BoreholeDrawStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeWidth` | `Double` | `get/set` | No | `` |
| `EmptyBoreholeHeight` | `Double` | `get/set` | No | `` |
| `EmptyImpellerTestHeight` | `Double` | `get/set` | No | `` |
| `ImpellerTestWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `BoreholeDrawStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BoreholeFrostDepthsFormat` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.BoreholeFrostDepthsFormat` |
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
      - `Topomatic.Glg.Style.BoreholeFrostDepthsFormat`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Display` | `BoreholeFrostDepthsFormat` | Yes | `Display` | `` |
| `DisplayWithAbsElevation` | `BoreholeFrostDepthsFormat` | Yes | `DisplayWithAbsElevation` | `` |
| `NotDisplay` | `BoreholeFrostDepthsFormat` | Yes | `NotDisplay` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NotDisplay` | `0` |
| `Display` | `1` |
| `DisplayWithAbsElevation` | `2` |

**Underlying Type**: `System.Int32`

### `BoreholeFrostDepthsFormatEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.BoreholeFrostDepthsFormatEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Style.BoreholeFrostDepthsFormatEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GeologyCommonStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyCommonStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyCommonStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoundContourDepth` | `Double` | `get/set` | No | `` |
| `DepthDigits` | `Int32` | `get/set` | No | `` |
| `ElevDigits` | `Int32` | `get/set` | No | `` |
| `IntImpellerElevs` | `Boolean` | `get/set` | No | `` |
| `PowerDigits` | `Int32` | `get/set` | No | `` |
| `ResistDigits` | `Int32` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |
| `ShowWaterPressureLine` | `Boolean` | `get/set` | No | `` |
| `WaterDigits` | `Int32` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyCommonStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyCrossSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyCrossSectionStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologySectionStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologySectionStyle`
      - `Topomatic.Glg.Style.GeologyCrossSectionStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

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

### `GeologyLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultEnable` | `Boolean` | `get` | No | `` |
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeologyPlanStyleBoreholes` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleBoreholes` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleBoreholes`

#### Constructors (1)

- `.ctor(GeologyStyle owner, String standard)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeBigRadiusSize` | `Single` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `UseJoinLines` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyPlanStyleBoreholes style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyPlanStyleConePenetration` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleConePenetration` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleConePenetration`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SignSize` | `Single` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `UseJoinLines` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyPlanStyleConePenetration style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyPlanStyleDummyDirection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleDummyDirection` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleDummyDirection`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeologyPlanStyleImpeller` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleImpeller` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleImpeller`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ImpellerBigRadiusSize` | `Single` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `UseJoinLines` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyPlanStyleImpeller style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyPlanStyleLines` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleLines` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleLines`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyPlanStyleSections style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyPlanStyleSections` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyPlanStyleSections` |
| **Base Type** | `Topomatic.Glg.Style.GeologyLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologyLayerStyleItem`
      - `Topomatic.Glg.Style.GeologyPlanStyleSections`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeFindingSize` | `Double` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GeologyPlanStyleSections style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeologyProfileStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyProfileStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologySectionStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologySectionStyle`
      - `Topomatic.Glg.Style.GeologyProfileStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SectionScale` | `Double` | `get/set` | No | `` |

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

### `GeologySectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologySectionStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GeologySectionStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeAssayStyle` | `BoreholeAssayStyle` | `get/set` | No | `` |
| `BoreholeFrostDepthsFormat` | `BoreholeFrostDepthsFormat` | `get/set` | No | `` |
| `BoreholeGroundDepthAlign` | `Int32` | `get/set` | No | `` |
| `ConePenetrationTestStyle` | `StaticSoundingPointSectionStyle` | `get` | No | `` |
| `ContourGroundNotesTextSize` | `Single` | `get/set` | No | `` |
| `ContoursHatch` | `Boolean` | `get/set` | No | `` |
| `FillBoreholes` | `Boolean` | `get/set` | No | `` |
| `FillContours` | `Boolean` | `get/set` | No | `` |
| `FullyFillBoreholes` | `Boolean` | `get/set` | No | `` |
| `GeneralScale` | `Double` | `get/set` | No | `` |
| `ImpellerTestStyle` | `ImpellerTestSectionStyle` | `get/set` | No | `` |
| `LayerPowersSpecifyContour` | `Boolean` | `get/set` | No | `` |
| `ShowAbsDepths` | `Boolean` | `get/set` | No | `` |
| `ShowAbsoluteElevations` | `Boolean` | `get/set` | No | `` |
| `ShowContourGroundNotes` | `Boolean` | `get/set` | No | `` |
| `ShowGroundInfo` | `Boolean` | `get/set` | No | `` |
| `ShowRelDepths` | `Boolean` | `get/set` | No | `` |
| `TextSize` | `Single` | `get/set` | No | `` |

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

### `GeologyStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Style.GeologyStyleItem, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStyles` | `IEnumerable<GeologyLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<GeologyStyleItem>` | `` | `` |
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

### `GeologyStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `GeologyStyle` | `get/set` | No | `` |

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

### `GlobalGeologyCommonStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GlobalGeologyCommonStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Glg.Style.GeologyStyle, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyleItem`
    - `Topomatic.Glg.Style.GlobalGeologyCommonStyle`

#### Constructors (1)

- `.ctor(GeologyStyle owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DepthDigits` | `Int32` | `get/set` | No | `` |
| `ElevDigits` | `Int32` | `get/set` | No | `` |
| `PowerDigits` | `Int32` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |
| `WaterDigits` | `Int32` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GlobalGeologyCommonStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GlobalGeologyStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.GlobalGeologyStyle` |
| **Base Type** | `Topomatic.Glg.Style.GeologyStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Glg.Style.GeologyStyleItem, Topomatic.Glg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Glg.Style.GeologyStyle`
    - `Topomatic.Glg.Style.GlobalGeologyStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BoreholeDrawStyle` | `BoreholeDrawStyle` | `get` | No | `` |
| `CommonStyle` | `GeologyCommonStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<GeologyLayerStyleItem>` | `get` | No | `` |
| `PlanFictionBoreholes` | `GeologyPlanStyleBoreholes` | `get` | No | `` |
| `PlanStyleBoreholes` | `GeologyPlanStyleBoreholes` | `get` | No | `` |
| `PlanStyleConePenetration` | `GeologyPlanStyleConePenetration` | `get` | No | `` |
| `PlanStyleImpeller` | `GeologyPlanStyleImpeller` | `get` | No | `` |
| `PlanStyleLines` | `GeologyPlanStyleLines` | `get` | No | `` |
| `ProfileStyle` | `GeologyProfileStyle` | `get` | No | `` |

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

### `IGlobalGeologyStyleContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.IGlobalGeologyStyleContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Style` | `GlobalGeologyStyle` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `ILayer` | `GeologyLayerStyleItem item` | `` |

### `ImpellerTestSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.ImpellerTestSectionStyle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Digits` | `Byte` | `get/set` | No | `` |
| `Dimension` | `Int16` | `get/set` | No | `` |
| `Show` | `Boolean` | `get/set` | No | `` |
| `ShowUnsignificantZeros` | `Boolean` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `Side` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.Side` |
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
      - `Topomatic.Glg.Style.Side`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `Side` | Yes | `Left` | `` |
| `Right` | `Side` | Yes | `Right` | `` |
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

### `SignSize` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.SignSize` |
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
      - `Topomatic.Glg.Style.SignSize`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Average` | `SignSize` | Yes | `Average` | `` |
| `Big` | `SignSize` | Yes | `Big` | `` |
| `Small` | `SignSize` | Yes | `Small` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Small` | `0` |
| `Average` | `1` |
| `Big` | `2` |

**Underlying Type**: `System.Int32`

### `SignSizeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.SignSizeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Style.SignSizeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StaticSoundingPointSectionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.StaticSoundingPointSectionStyle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DepthStep` | `Double` | `get/set` | No | `` |
| `DisplayGraph` | `Boolean` | `get/set` | No | `` |
| `DistBetweenGraphs` | `Double` | `get/set` | No | `` |
| `DistFromBorehole` | `Double` | `get/set` | No | `` |
| `Draw` | `Boolean` | `get/set` | No | `` |
| `QcWidth` | `Double` | `get/set` | No | `` |
| `Side` | `Side` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `VerticalAlign` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.VerticalAlign` |
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
      - `Topomatic.Glg.Style.VerticalAlign`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bottom` | `VerticalAlign` | Yes | `Bottom` | `` |
| `Center` | `VerticalAlign` | Yes | `Center` | `` |
| `Top` | `VerticalAlign` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `0` |
| `Center` | `1` |
| `Bottom` | `2` |

**Underlying Type**: `System.Int32`

### `VerticalAlignConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Style.VerticalAlignConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Glg.Style.VerticalAlignConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 157 |
| **Classes** | 97 |
| **Interfaces** | 17 |
| **Enums** | 22 |
| **Structs** | 4 |
| **Abstract Classes** | 11 |
| **Static Classes** | 6 |
| **Total Methods** | 596 |
| **Total Properties** | 495 |
| **Total Fields** | 182 |
| **Total Events** | 2 |
| **Total Constructors** | 146 |
| **Nested Types** | 8 |
| **Extension Methods** | 0 |


