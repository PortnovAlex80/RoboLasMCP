# Topomatic.Mockup

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Mockup` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Mockup, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Mockup.dll` |

---
## Namespace: `Topomatic.Mockup`

### `Mockup` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.Mockup` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Mockup.Mockup`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Breaks` | `MockupBreakCollection` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Origin` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Path` | `String` | `get/set` | No | `` |
| `ReferenceAlignments` | `MockupReferenceAlignmentCollection` | `get` | No | `` |
| `Template` | `Drawing` | `get/set` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearVariables` | `Void` | `` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetUnderlay` | `Drawing` | `UInt32 sectionId` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveMockupItem` | `Void` | `UInt32 sectionId, UInt32 fieldId, EditableItemsKey itemId` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetMockupItem` | `Void` | `UInt32 sectionId, UInt32 fieldId, EditableItemsKey itemId, MockupItem item` | `` |
| `SetVariable` | `Void` | `String name, Object value` | `` |
| `TryGetMockupItem` | `Boolean` | `UInt32 sectionId, UInt32 fieldId, EditableItemsKey itemId, ref MockupItem item` | `` |
| `TryGetVariable` | `Boolean` | `String name, ref Object value` | `` |
| `VariablesFromDictionary` | `Void` | `DynamicDictionary dictionary` | `` |
| `VariablesToDictionary` | `DynamicDictionary` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `MockupBreak` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupBreak` |
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
| `Station` | `Double` | `get/set` | No | `` |
| `Type` | `MockupBreakType` | `get/set` | No | `` |

### `MockupBreakCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupBreakCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransactable parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `MockupBreak` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `MockupBreak mockupBreak` | `` |
| `Clear` | `Void` | `` | `` |
| `FromList` | `Void` | `DynamicList list` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToList` | `DynamicList` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MockupBreakType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupBreakType` |
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
      - `Topomatic.Mockup.MockupBreakType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NewBreak` | `MockupBreakType` | Yes | `NewBreak` | `` |
| `NewSheet` | `MockupBreakType` | Yes | `NewSheet` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NewSheet` | `0` |
| `NewBreak` | `1` |

**Underlying Type**: `System.Int32`

### `MockupCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Mockup.MockupCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Mockup` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Mockup mockup` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `String description` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Modify` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MockupConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupConflictResolver` |
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
| `ResolveConflict` | `Boolean` | `MockupCollection origin, MockupCollection local, MockupCollection remote, MockupCollection result, VcsContext context` | `` |

### `MockupItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flipped` | `Boolean` | `get/set` | No | `` |
| `Hidden` | `Boolean` | `get/set` | No | `` |
| `Leader` | `Boolean` | `get/set` | No | `` |
| `Offset` | `Vector2D` | `get/set` | No | `` |
| `Ratio` | `Double` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromDictionary` | `Void` | `DwgDictionary dictionary` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToDictionary` | `Void` | `DwgDictionary dictionary` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MockupItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupItemWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FieldPos` | `Vector2D` | `get/set` | No | `` |
| `Item` | `MockupItem` | `get/set` | No | `` |
| `ItemPos` | `Vector2D` | `get/set` | No | `` |
| `TemplatePos` | `Vector2D` | `get/set` | No | `` |

### `MockupReferenceAlignmentCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Mockup.MockupReferenceAlignmentCollection` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransactable parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `String` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String item` | `` |
| `Clear` | `Void` | `` | `` |
| `FromList` | `Void` | `DynamicList list` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToDynamicList` | `DynamicList` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 9 |
| **Classes** | 8 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 41 |
| **Total Properties** | 27 |
| **Total Fields** | 3 |
| **Total Events** | 1 |
| **Total Constructors** | 8 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


