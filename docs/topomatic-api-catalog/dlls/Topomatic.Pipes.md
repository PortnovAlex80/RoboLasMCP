# Topomatic.Pipes

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Pipes` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Pipes.dll` |

---
## Namespace: `Topomatic.Pipes`

### `AcceptableDistances` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.AcceptableDistances` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAcceptableDistance` | `Double` | `String type_1, String type_2` | `` |
| `GetAcceptableDistances` | `Double[]` | `String type` | `` |
| `LoadDefaultDistances` | `Void` | `List<String> designationTypes` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetAcceptableDistance` | `Void` | `String type_1, String type_2, Double distance` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Coloured3DElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Coloured3DElement` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Pipes.Coloured3DElement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(CadColor color, ImElement element)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CommonConstructionParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CommonConstructionParams` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CommonConstructionParams`

#### Constructors (1)

- `.ctor(PipeNetworkItem pnItem, Action markChanged)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConstructionTypeFilter` | `String` | `get/set` | No | `` |
| `TemplateDescription` | `String` | `get/set` | No | `` |
| `TemplateMark` | `String` | `get/set` | No | `` |
| `UserTemplateMark` | `String` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetTemplateDescription` | `String` | `` | `` |
| `GetTemplateMark` | `String` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DefaultParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.StoredLeaderParams+DefaultParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BasePosOffset` | `Vector2D` | No | `` | `` |
| `FlipText` | `Boolean` | No | `` | `` |
| `HideLeader` | `Boolean` | No | `` | `` |
| `HideNetworkDesignation` | `Boolean` | No | `` | `` |
| `LeaderAngle` | `Double` | No | `` | `` |
| `TextPosOffset` | `Vector2D` | No | `` | `` |

### `eDitchType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.eDitchType` |
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
      - `Topomatic.Pipes.eDitchType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DitchPit` | `eDitchType` | Yes | `DitchPit` | `` |
| `NodeDitch` | `eDitchType` | Yes | `NodeDitch` | `` |
| `PipeDitch` | `eDitchType` | Yes | `PipeDitch` | `` |
| `ShaftDitch` | `eDitchType` | Yes | `ShaftDitch` | `` |
| `UnboundDitch` | `eDitchType` | Yes | `UnboundDitch` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `UnboundDitch` | `0` |
| `ShaftDitch` | `1` |
| `PipeDitch` | `2` |
| `NodeDitch` | `3` |
| `DitchPit` | `4` |

**Underlying Type**: `System.Int32`

### `EditedLabel` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditedLabel` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.EditedLabel`

#### Constructors (2)

- `.ctor(StgNode node)`
- `.ctor(Boolean flip)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateEditedLabel` | `EditedLabel` | `DwgEntity ent` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Flip` | `Boolean` | No | `` | `` |
| `PositionOffset` | `Vector2D` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |

### `ICrossingsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ICrossingsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAllCrosses` | `IEnumerable<PipesCrossing>` | `` | `` |

### `ILinetypeContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ILinetypeContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |

### `IPipeNetworkContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

### `IStoredLeaderParams` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.IStoredLeaderParams` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StoredLeaderParams` | `StoredLeaderParams` | `get` | No | `` |

### `ItemSelectorData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ItemSelectorData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ItemSelectorData`

#### Constructors (1)

- `.ctor(PipeNetwork network)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dictionary` | `IDictionary<String ImElement>` | `get` | No | `` |
| `LastInputConnection` | `String` | `get/set` | No | `` |
| `LastNodeConstructionAlbum` | `String` | `get/set` | No | `` |
| `LastNodeName` | `String` | `get/set` | No | `` |
| `LastOutputConnection` | `String` | `get/set` | No | `` |
| `LastSegmentConstructionTemplate` | `String` | `get/set` | No | `` |
| `LinearNodeByStepByObjectValue` | `Double` | `get/set` | No | `` |
| `LinearNodeByStepValue` | `Double` | `get/set` | No | `` |
| `LinearVertexType` | `LinearInsertVertexType` | `get/set` | No | `` |
| `UseCustomConstruction` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Nested Types (1)

- `LinearInsertVertexType` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `LibraryItemCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LibraryItemCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDouble` | `Double` | `ImElement element, String tag` | `` |
| `GetString` | `String` | `ImElement element, String tag` | `` |

### `LinearInsertVertexType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ItemSelectorData+LinearInsertVertexType` |
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
      - `Topomatic.Pipes.ItemSelectorData+LinearInsertVertexType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Node` | `LinearInsertVertexType` | Yes | `Node` | `` |
| `NodeByStep` | `LinearInsertVertexType` | Yes | `NodeByStep` | `` |
| `NodeByStepByObject` | `LinearInsertVertexType` | Yes | `NodeByStepByObject` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vertex` | `LinearInsertVertexType` | Yes | `Vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Node` | `0` |
| `NodeByStep` | `1` |
| `Vertex` | `2` |
| `NodeByStepByObject` | `3` |

**Underlying Type**: `System.Int32`

### `LineChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+LineChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+LineChangedEventArgs`

#### Constructors (1)

- `.ctor(PnLine line, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Line` | `PnLine` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `LineSurfacePoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineSurfacePoint` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vector2D pos, String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GapAfter` | `Boolean` | `get/set` | No | `` |
| `ParentSurfaceName` | `String` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Visible` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LinetypeContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LinetypeContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LinetypeContainer`

#### Constructors (1)

- `.ctor(PipeNetworkItem owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Linetype` | `DwgLinetype` | `get/set` | No | `` |
| `LinetypeScale` | `Double` | `get/set` | No | `` |
| `Lineweight` | `Lineweight` | `get/set` | No | `` |

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

### `MassiveChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+MassiveChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+MassiveChangedEventArgs`

#### Constructors (1)

- `.ctor(MassiveObject massive, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Massive` | `MassiveObject` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `MassiveObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.MassiveObject` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.MassiveObject`

#### Constructors (1)

- `.ctor(Object parent, UInt32 id, ImElement element, Vector2D position)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BotElevation` | `Double` | `get/set` | No | `` |
| `Components` | `String` | `get/set` | No | `` |
| `Connections` | `IEnumerable<KeyValuePair<String Vector3D>>` | `get` | No | `` |
| `ConnectionsCount` | `Int32` | `get` | No | `` |
| `DiameterIn` | `String` | `get` | No | `` |
| `DiameterOut` | `String` | `get` | No | `` |
| `Document` | `String` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `FullName` | `String` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Mass` | `String` | `get` | No | `` |
| `MassBrutto` | `String` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PlanDrawing` | `Drawing` | `get/set` | No | `Obsolete` |
| `PlanRotation` | `Double` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `TopElevation` | `Double` | `get/set` | No | `` |
| `Volume` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetConnectionPos` | `Boolean` | `String name, ref Vector3D vertex` | `` |
| `UpdateAllPipes` | `Void` | `PnNode node` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DiameterInTag` | `String` | Yes | `"DiameterIn"` | `` |
| `DiameterOutTag` | `String` | Yes | `"DiameterOut"` | `` |
| `DocumentTag` | `String` | Yes | `"Document"` | `` |
| `FullNameTag` | `String` | Yes | `"FullName"` | `` |
| `HeightTag` | `String` | Yes | `"Height"` | `` |
| `MassBruttoTag` | `String` | Yes | `"MassBrutto"` | `` |
| `MassTag` | `String` | Yes | `"Mass"` | `` |
| `VolumeTag` | `String` | Yes | `"Volume"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `MassiveObjects` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.MassiveObjects` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.MassiveObject, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.MassiveObjects`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `CurrentId` | `UInt32` | `get` | No | `` |
| `Item` | `MassiveObject` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `MassiveObject` | `Nullable<UInt32> id, Vector2D position, ImElement element` | `` |
| `Add` | `MassiveObject` | `Vector2D position, ImElement element` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<MassiveObject>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `MaterialType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.MaterialType` |
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
      - `Topomatic.Pipes.MaterialType`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CastIron` | `MaterialType` | Yes | `CastIron` | `` |
| `Concerete` | `MaterialType` | Yes | `Concerete` | `` |
| `PE` | `MaterialType` | Yes | `PE` | `` |
| `PE100` | `MaterialType` | Yes | `PE100` | `` |
| `PE32` | `MaterialType` | Yes | `PE32` | `` |
| `PE63` | `MaterialType` | Yes | `PE63` | `` |
| `PE80` | `MaterialType` | Yes | `PE80` | `` |
| `PP` | `MaterialType` | Yes | `PP` | `` |
| `Steel` | `MaterialType` | Yes | `Steel` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Concerete` | `0` |
| `PP` | `1` |
| `PE` | `2` |
| `CastIron` | `3` |
| `Steel` | `4` |
| `PE32` | `5` |
| `PE63` | `6` |
| `PE80` | `7` |
| `PE100` | `8` |

**Underlying Type**: `System.Int32`

### `NamedNetwork` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NamedNetwork` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NamedNetwork`

#### Constructors (1)

- `.ctor(PipeNetwork network, String name)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Name` | `String` | No | `` | `` |
| `Network` | `PipeNetwork` | No | `` | `` |

### `NetworkTypeParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NetworkTypeParams` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneFrom` | `Void` | `NetworkTypeParams source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GOST` | `String` | No | `` | `` |
| `Guid` | `Guid` | No | `` | `` |
| `IsPressure` | `Boolean` | No | `` | `` |
| `NetworkType` | `String` | No | `` | `` |
| `NetworkTypeDesignation` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `NodeChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+NodeChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+NodeChangedEventArgs`

#### Constructors (1)

- `.ctor(PnNode node, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Node` | `PnNode` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PipeChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+PipeChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+PipeChangedEventArgs`

#### Constructors (1)

- `.ctor(PnSegment pipe, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Segment` | `PnSegment` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PipeNetwork` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ISurfaceContainer, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetwork`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (36)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisAlignmentId` | `String` | `get/set` | No | `` |
| `CrossSections` | `PnCrsSections` | `get` | No | `` |
| `CrSurfaceIDs` | `IList<String>` | `get` | No | `` |
| `DefaultParams` | `PipeNetworkDefaultParams` | `get` | No | `` |
| `Demo` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Ditches` | `Ditches` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `EgSurfaceIDs` | `IList<String>` | `get` | No | `` |
| `EiTablePlanPipeCrosses` | `SimpleEditedItemsTable` | `get` | No | `` |
| `EiTableProfilePipeCrosses` | `SimpleEditedItemsTable` | `get` | No | `` |
| `EiTableProfileShaftCrosses` | `SimpleEditedItemsTable` | `get` | No | `` |
| `FdOffsets` | `String` | `get/set` | No | `` |
| `FilteredProfiles` | `IList<UInt32>` | `get` | No | `` |
| `GnbPltSheets` | `IList<Int32>` | `get` | No | `` |
| `ID` | `Guid` | `get` | No | `Obsolete` |
| `ItemSelectorData` | `ItemSelectorData` | `get` | No | `` |
| `Lines` | `PnLines` | `get` | No | `` |
| `MassiveObjects` | `MassiveObjects` | `get` | No | `` |
| `Modified` | `Boolean` | `get/set` | No | `` |
| `NetworkTypeIsPressure` | `Boolean` | `get` | No | `` |
| `NetworkTypeParams` | `NetworkTypeParams` | `get/set` | No | `` |
| `Nodes` | `PnNodes` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parent` | `Object` | `get/set` | No | `` |
| `PgSurfaceIDs` | `IList<String>` | `get` | No | `` |
| `PipeCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `` |
| `PltSheets` | `IList<Int32>` | `get` | No | `` |
| `ProfileMockups` | `MockupCollection` | `get` | No | `` |
| `ProfileScreenRatio` | `Double` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Segments` | `IEnumerable<PnSegment>` | `get` | No | `` |
| `SelectedProfiles` | `List<UInt32>` | `get` | No | `` |
| `SheetFilterDictionary` | `SheetItemsFilterDictionary` | `get` | No | `` |
| `Styles` | `PipeNetworkStyle` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneParamsFrom` | `Void` | `PipeNetwork source` | `` |
| `GetBlockName` | `String` | `String blockIdString` | `` |
| `GetDefaultSegmentElevation` | `Double` | `` | `` |
| `GetLineProfileStation` | `Double` | `UInt32 lineId` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MoveNodeWithRefreshPlanThrough` | `Void` | `PnNode node` | `` |
| `MoveNodeWithRefreshPlanThrough` | `Void` | `PnNode node, Vector2D newPosition` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SurfacesChanged` | `Void` | `` | `` |
| `UpdateDrawingSign` | `DwgBlock` | `ImElement item, String signTag` | `` |
| `UpdateDrawingSign` | `DwgBlock` | `String blockIdString` | `` |
| `UpdateNodeDrawingSigns` | `Void` | `ImElement item` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AcceptableValuesContainer` | `AcceptableValuesContainer` | No | `` | `` |
| `AttachNewNodeToPipe` | `Boolean` | No | `` | `` |
| `Calculations` | `CalculationsContainer` | No | `` | `` |
| `LastRailContactNetworkLineParamsData` | `RailContactNetworkLineParamsData` | No | `` | `` |
| `PnLineProfileStepLength` | `Double` | No | `` | `` |
| `ProfileStep` | `Int32` | Yes | `20` | `` |

#### Events (7)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `LineChanged` | `EventHandler<LineChangedEventArgs>` | No | `` |
| `MassiveChanged` | `EventHandler<MassiveChangedEventArgs>` | No | `` |
| `NodeChanged` | `EventHandler<NodeChangedEventArgs>` | No | `` |
| `PipeChanged` | `EventHandler<PipeChangedEventArgs>` | No | `` |
| `ShellChanged` | `EventHandler<ShellChangedEventArgs>` | No | `` |
| `SurfaceProfileLineChanged` | `EventHandler<SurfaceProfileLineChangedEventArgs>` | No | `` |
| `WholeNetworkChanged` | `EventHandler<WholeNetworkChangedEventArgs>` | No | `` |

#### Nested Types (8)

- `LineChangedEventArgs` (class)
- `MassiveChangedEventArgs` (class)
- `NodeChangedEventArgs` (class)
- `PipeChangedEventArgs` (class)
- `ProfileSortComparer` (class)
- `ShellChangedEventArgs` (class)
- `SurfaceProfileLineChangedEventArgs` (class)
- `WholeNetworkChangedEventArgs` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStateController` | `get_Modified` |
| `IStateController` | `set_Modified` |
| `IStateController` | `get_ReadOnly` |
| `IStateController` | `set_ReadOnly` |
| `ISurfaceContainer` | `get_Surface` |
| `IDrawingContainer` | `get_Drawing` |

### `PipeNetworkChangedEventArgs` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`

#### Constructors (1)

- `.ctor(FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ChangedType` | `FieldChangedType` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PipeNetworkCollections` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkCollections` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAllDitchChunks` | `IEnumerable<ConstructionChunkDitch>` | `PipeNetwork network` | `Extension` |
| `GetAllLongChunks` | `IEnumerable<ConstructionChunkLong>` | `PipeNetwork network` | `Extension` |
| `GetAllPointChunks` | `IEnumerable<ConstructionChunkPoint>` | `PipeNetwork network` | `Extension` |
| `GetAllShellChunks` | `IEnumerable<ConstructionChunkShell>` | `PipeNetwork network` | `Extension` |

### `PipeNetworkConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (49)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ApplyDitchTemplate` | `String` | Yes | `"pipes_ditch_apply_template"` | `` |
| `CheckNetworkErrors` | `String` | Yes | `"check_network_errors"` | `` |
| `ComponentCommentTag` | `String` | Yes | `"SpNote"` | `` |
| `ComponentDocumentTag` | `String` | Yes | `"SpDocument"` | `` |
| `ComponentProductCodeTag` | `String` | Yes | `"SpProductCode"` | `` |
| `ComponentWeightTag` | `String` | Yes | `"SpWeight"` | `` |
| `CreateDitchLayers` | `String` | Yes | `"pipes_create_ditch_layers"` | `` |
| `CreateDitchSurface` | `String` | Yes | `"pipes_create_ditch_surface"` | `` |
| `DefaultNodePointRadius` | `Double` | Yes | `0.25` | `` |
| `DWL_MODEL_TYPE` | `String` | Yes | `"application/pn-prf-dwl"` | `` |
| `DWL_PLAN_CROSS_MODEL_TYPE` | `String` | Yes | `"application/pn-plan-cross-dwl"` | `` |
| `FillMassivePlanBlock` | `String` | Yes | `"pipes_fill_massive_plan_block"` | `` |
| `GetAlignmentByIdCmd` | `String` | Yes | `"pipes_get_alignment_by_id"` | `` |
| `GetAlignmentCmd` | `String` | Yes | `"pipe_network_get_alignment"` | `` |
| `GetAlignmentIdCmd` | `String` | Yes | `"pipes_get_alignment_id"` | `` |
| `GetAllNetworkPipeCrosses` | `String` | Yes | `"pipe_network_get_all_network_pipe_crosses"` | `` |
| `GetAllPipeNetworksCmd` | `String` | Yes | `"pipe_network_get_all_pipe_networks"` | `` |
| `GetAllPipeNetworksWithLockReadCmd` | `String` | Yes | `"pipe_network_get_all_pipe_networks_with_lock_read"` | `` |
| `GetBasisAlignmentCmd` | `String` | Yes | `"pipes_get_basis_alignment"` | `` |
| `GetNetworkBasisStationCmd` | `String` | Yes | `"pipe_network_get_basis_station"` | `` |
| `GetNodeReference` | `String` | Yes | `"pipe_network_get_node_reference"` | `` |
| `GetOpenedPipeNetworksCmd` | `String` | Yes | `"pipe_network_get_opened_pipe_networks"` | `` |
| `GetSurfacesCmd` | `String` | Yes | `"pipe_network_get_surfaces"` | `` |
| `LIB_PREFIX_SHAFT_SECTION_TEMPLATES` | `String` | Yes | `"shaft_sections_templates"` | `` |
| `MassiveConnectionPrefix` | `String` | Yes | `"-"` | `` |
| `MassivePlanBlockFileName` | `String` | Yes | `"MassivePlanBlock.dxf"` | `` |
| `MODEL_TYPE` | `String` | Yes | `"pipe"` | `` |
| `MoveLeader` | `String` | Yes | `"pipes_move_pipe_leader"` | `` |
| `PipeNetworkProfileWindowID` | `String` | Yes | `` | `` |
| `PipeNetworkProjectSettingsName` | `String` | Yes | `"PipeNetworkProjectSettings"` | `` |
| `PipeNetworkSegmentCrsWindowID` | `String` | Yes | `` | `` |
| `RecreateDitchesLayers` | `String` | Yes | `"pipes_recreate_ditches_layers"` | `` |
| `RecreateDitchLayers` | `String` | Yes | `"pipes_recreate_ditch_layers"` | `` |
| `RecreateDitchSurface` | `String` | Yes | `"pipes_recreate_ditch_surface"` | `` |
| `RefreshAllCachesCmd` | `String` | Yes | `"pipes_refresh_all_caches"` | `` |
| `RefreshCommunicationsLayerCmd` | `String` | Yes | `"pipe_network_refresh_communications_layer"` | `` |
| `RefreshDitchPositions` | `String` | Yes | `"pipe_network_refresh_ditch_positions"` | `` |
| `RefreshNearestCachesCmd` | `String` | Yes | `"pipes_refresh_nearest_caches"` | `` |
| `RemoveDitch` | `String` | Yes | `"pipes_remove_ditch"` | `` |
| `RemoveLine` | `String` | Yes | `"pipes_remove_line"` | `` |
| `RemoveNode` | `String` | Yes | `"pipes_remove_node"` | `` |
| `RemovePipeLeader` | `String` | Yes | `"pipes_remove_pipe_leader"` | `` |
| `SegmentCrsBlockFileName` | `String` | Yes | `"SegmentCrsDrawing.dxf"` | `` |
| `SegmentCrsDataFileName` | `String` | Yes | `"SegmentCrsData.dat"` | `` |
| `SetNodeReference` | `String` | Yes | `"pipe_network_set_node_reference"` | `` |
| `SmdxTypePipe` | `String` | Yes | `"SmdxNetworksPipe"` | `` |
| `SmdxTypeWire` | `String` | Yes | `"SmdxNetworksWire"` | `` |
| `UpdateOneNodeReferenceCmd` | `String` | Yes | `"pipes_update_one_node_reference"` | `` |
| `UpdateRailContactWireLineByNodeCmd` | `String` | Yes | `"pipes_update_rail_contact_wire_line_by_node"` | `` |

### `PipeNetworkDefaultParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkDefaultParams` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.PipeNetworkDefaultParams`

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultDeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `DefaultElevationIsDepth` | `Boolean` | `get/set` | No | `` |
| `DefaultFoundationDepth` | `Double` | `get/set` | No | `` |
| `DefaultPipeEarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `` |
| `DefaultPipeElevation` | `Double` | `get/set` | No | `` |
| `DefaultPipeFoundationType` | `String` | `get/set` | No | `` |
| `DefaultPipeIsolationType` | `String` | `get/set` | No | `` |
| `ReserveParamsContainer` | `ReserveParamsContainer` | `get` | No | `` |

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

### `PipeNetworkInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, String uid, PipeNetwork network)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Name` | `String` | No | `` | `` |
| `PipeNetwork` | `PipeNetwork` | No | `` | `` |
| `Uid` | `String` | No | `` | `` |

### `PipeNetworkItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkItem` |
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
      - `Topomatic.Pipes.PipeNetworkItem`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `PipeNetworkValueConverter` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetworkValueConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `CoordinateToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `ElevationToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `GradeThousandsToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `GradeToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `LengthToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `RadiusToStr` | `String` | `PipeNetwork pipeNetwork, Double value` | `Extension` |
| `TryStrToAngle` | `Boolean` | `PipeNetwork pipeNetwork, String value, ref Double angle` | `Extension` |

### `PipesBentleyOttmanAlghorithm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipesBentleyOttmanAlghorithm` |
| **Base Type** | `Topomatic.Cad.Foundation.VariationBentleyOttmanAlgorithm`1[[Topomatic.Cad.Foundation.BentleyOttmanSegment, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.VariationBentleyOttmanAlgorithm`1[[Topomatic.Cad.Foundation.BentleyOttmanSegment, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Pipes.PipesBentleyOttmanAlghorithm`

#### Constructors (1)

- `.ctor(Int32 segmentsCount)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RemoveSelfCrossings` | `Void` | `List<Vector3D> points` | `` |

### `PipesCrossing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipesCrossing` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String baseModelUid, PnSegment basePipe, Double baseStation, String crossModeluid, PnSegment crossPipe, Double crossStation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseModelUid` | `String` | `get/set` | No | `` |
| `BaseSegment` | `PnSegment` | `get/set` | No | `` |
| `BaseStation` | `Double` | `get/set` | No | `` |
| `CrossModelUid` | `String` | `get/set` | No | `` |
| `CrossSegment` | `PnSegment` | `get/set` | No | `` |
| `CrossStation` | `Double` | `get/set` | No | `` |

### `ProfileSortComparer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+ProfileSortComparer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IComparer`1[[Topomatic.Pipes.LineFolder.PnLine, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Compare` | `Int32` | `PnLine x, PnLine y` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparer`1` | `Compare` |

### `ShellChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+ShellChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+ShellChangedEventArgs`

#### Constructors (1)

- `.ctor(Shell shell, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Shell` | `Shell` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `StgTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.StgTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyViaStg` | `Void` | `IStgSerializable source, IStgSerializable target` | `` |
| `CopyViaStg` | `Void` | `Object contextOwner, IStgContextSerializable source, IStgContextSerializable target` | `` |
| `GetNodeFromString` | `Boolean` | `String s, ref StgNode node` | `` |
| `GetOldOrNewNode` | `StgNode` | `String nodeName, StgNode node` | `` |
| `GetStringFromNode` | `String` | `StgDocument document` | `` |

### `StoredLeaderParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.StoredLeaderParams` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.StoredLeaderParams`

#### Constructors (2)

- `.ctor(PipeNetworkItem item, Action onChanged)`
- `.ctor(PipeNetworkItem item, DefaultParams defaultParams, Action onChanged)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FlipText` | `Boolean` | `get/set` | No | `` |
| `HideLeader` | `Boolean` | `get/set` | No | `` |
| `HideNetworkDesignation` | `Boolean` | `get/set` | No | `` |
| `LeaderAngle` | `Double` | `get/set` | No | `` |
| `LeaderBaseOffset` | `Double` | `get` | No | `` |
| `LeaderBasePosOffset` | `Vector2D` | `get/set` | No | `` |
| `LeaderTextPosOffset` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPropertiesFrom` | `Void` | `StoredLeaderParams source` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `DefaultParams` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SurfaceProfileLineChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+SurfaceProfileLineChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+SurfaceProfileLineChangedEventArgs`

#### Constructors (1)

- `.ctor(PnLine line, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PnLine` | `PnLine` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `SurfacesLineParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SurfacesLineParams` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SurfacesLineParams`

#### Constructors (1)

- `.ctor(PnLine parent)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoHideEdges` | `Boolean` | `get/set` | No | `` |
| `CalcCommunicationCross` | `Boolean` | `get/set` | No | `` |
| `CalcEdges` | `Boolean` | `get/set` | No | `` |
| `CalcPipeCharacterPoints` | `Boolean` | `get/set` | No | `` |
| `CalcStepLength` | `Boolean` | `get/set` | No | `` |
| `CalcUserStations` | `Boolean` | `get/set` | No | `` |
| `EgUserDefinedSurface` | `IList<LineSurfacePoint>` | `get` | No | `` |
| `IsDynamicCalc` | `Boolean` | `get/set` | No | `` |
| `PgUserDefinedSurface` | `IList<LineSurfacePoint>` | `get` | No | `` |
| `SurfaceProfileStepLength` | `Double` | `get/set` | No | `` |
| `UserPointVisibility` | `IDictionary<Double SurfacePointVisibility>` | `get` | No | `` |
| `UserProfileStations` | `IList<Double>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSurfacePointVisibility` | `SurfacePointVisibility` | `Double station` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `WholeNetworkChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PipeNetwork+WholeNetworkChangedEventArgs` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkChangedEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.PipeNetworkChangedEventArgs`
      - `Topomatic.Pipes.PipeNetwork+WholeNetworkChangedEventArgs`

#### Constructors (1)

- `.ctor(PipeNetwork network, FieldChangedType changedType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_PipeNetwork` | `PipeNetwork` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

---
## Namespace: `Topomatic.Pipes.AcceptableValues`

### `AcceptableValuesContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.AcceptableValues.AcceptableValuesContainer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AcceptableDistances` | `AcceptableDistances` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.CadViewTransform`

### `ICloneableWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CadViewTransform.ICloneableWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddInstanceToCollection` | `Void` | `ITransformable item` | `` |
| `CloneWrappedObject` | `ITransformable` | `` | `` |

### `ITransformable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

---
## Namespace: `Topomatic.Pipes.Calculations`

### `CalculationsContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.CalculationsContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.Calculations.CalculationsContainer`

#### Constructors (1)

- `.ctor(PipeNetwork network)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HydraulicNonPressure` | `HydraulicNonPressureDataDict` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.Calculations.HydraulicNonPressure00`

### `Calculator` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.HydraulicNonPressure00.Calculator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EmptyOutput` | `OutputData` | `get` | Yes | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Calculate` | `OutputData` | `InputData input` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ViableNetworkTypes` | `HashSet<Guid>` | Yes | `` | `` |

### `HydraulicNonPressureDataDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.HydraulicNonPressure00.HydraulicNonPressureDataDict` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.Calculations.HydraulicNonPressure00.HydraulicNonPressureDataDict`

#### Constructors (1)

- `.ctor(PipeNetwork network)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `InputData` | `get/set` | No | `` |
| `Item` | `InputData` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalculationId` | `String` | Yes | `"Hydraulic_Non_Pressure_00"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `InputData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.HydraulicNonPressure00.InputData` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Calculations.HydraulicNonPressure00.InputData`

#### Constructors (1)

- `.ctor(String startNodeName, String endNodeName, SegmentProfileType profileType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Invalid` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillSegmentData` | `Void` | `ConstructionChunkLong chunk` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `b` | `Double` | No | `` | `` |
| `d` | `Double` | No | `` | `` |
| `EndNodeName` | `String` | No | `` | `` |
| `h` | `Double` | No | `` | `` |
| `i` | `Double` | No | `` | `` |
| `LineId` | `Int32` | No | `` | `` |
| `n` | `Double` | No | `` | `` |
| `ProfileType` | `SegmentProfileType` | No | `` | `` |
| `Q` | `Double` | No | `` | `` |
| `SegmentId` | `Int32` | No | `` | `` |
| `SegmentIndex` | `Int32` | No | `` | `` |
| `StartNodeName` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OutputData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.HydraulicNonPressure00.OutputData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Calculations.HydraulicNonPressure00.OutputData`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `C_Calc` | `Double` | No | `` | `` |
| `Calculated` | `Boolean` | No | `` | `` |
| `h_d_Calc` | `Double` | No | `` | `` |
| `h_d_Max` | `Double` | No | `` | `` |
| `omega_Calc` | `Double` | No | `` | `` |
| `Q_Calc` | `Double` | No | `` | `` |
| `Q_Max` | `Double` | No | `` | `` |
| `Q_Valid` | `Boolean` | No | `` | `` |
| `R_Calc` | `Double` | No | `` | `` |
| `V_Calc` | `Double` | No | `` | `` |
| `V_Max` | `Double` | No | `` | `` |
| `xi_Calc` | `Double` | No | `` | `` |

### `Values` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Calculations.HydraulicNonPressure00.Values` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Calculations.HydraulicNonPressure00.Values`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `C` | `Double` | No | `` | `` |
| `gamma` | `Double` | No | `` | `` |
| `h_d` | `Double` | No | `` | `` |
| `omega` | `Double` | No | `` | `` |
| `phi` | `Double` | No | `` | `` |
| `q` | `Double` | No | `` | `` |
| `R` | `Double` | No | `` | `` |
| `V` | `Double` | No | `` | `` |
| `xi` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.CrsSectionFolder`

### `PnCrsMainSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsMainSection` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsMainSection`

#### Constructors (1)

- `.ctor(Object owner, UInt32 id, Boolean isReference)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllItems` | `IEnumerable<PnCrsSectionItem>` | `get` | No | `` |
| `Borders` | `IList<PnCrsBorder>` | `get` | No | `` |
| `Contours` | `IList<PnCrsContour>` | `get` | No | `` |
| `ElevationProfiles` | `IList<PnCrsElevationProfile>` | `get` | No | `` |
| `Farms` | `IList<PnCrsFarm>` | `get` | No | `` |
| `IsReference` | `Boolean` | `get` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |
| `Slots` | `IList<PnCrsSlot>` | `get` | No | `` |
| `Underlay` | `PnCrsSectionUnderlay` | `get` | No | `` |
| `UserEntities` | `IList<UserProfileEntity>` | `get` | No | `` |

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

### `PnCrsReferenceSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsReferenceSection` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsReferenceSection`

#### Constructors (1)

- `.ctor(PnCrsSections sections, UInt32 id)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CachedSection` | `PnCrsMainSection` | `get` | No | `` |
| `OverridedSlots` | `IEnumerable<KeyValuePair<String ImElement>>` | `get` | No | `` |
| `ReferenceModelUid` | `String` | `get/set` | No | `` |
| `SectionId` | `UInt32` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `HasOverrideSlot` | `Boolean` | `String id` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `RemoveOverrideSlot` | `Void` | `String id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |
| `UpdateCachedSection` | `Void` | `PnCrsMainSection section` | `` |
| `UpdateOverrideSlot` | `Void` | `String id, ImElement segmentCrsSlot` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `PnCrsSectionBase` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase`

#### Constructors (1)

- `.ctor(Object owner, UInt32 id)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |
| `NameId` | `String` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneFrom` | `Void` | `PnCrsSectionBase source` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetItemType` | `PnCrsSectionType` | `PnCrsSectionBase item` | `` |
| `LoadSectionItem` | `PnCrsSectionBase` | `PnCrsSections sections, StgNode node, ISerializationContext context` | `` |
| `SaveSectionItem` | `Void` | `PnCrsSectionBase item, StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `PnCrsSections` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSections` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.CrsSectionFolder.PnCrsSectionBase, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSections`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `CurrentId` | `UInt32` | `get` | No | `` |
| `Item` | `PnCrsSectionBase` | `get` | No | `` |
| `SelectedSection` | `PnCrsSectionBase` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `PnCrsSectionBase` | `Nullable<UInt32> id, PnCrsSectionType itemType` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<PnCrsSectionBase>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `NameIsUnique` | `Boolean` | `ref String nameId` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `UpdateReference` | `Void` | `String networkId, PnCrsMainSection section` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `PnCrsSectionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionType` |
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
      - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrsReference` | `PnCrsSectionType` | Yes | `CrsReference` | `` |
| `CrsSection` | `PnCrsSectionType` | Yes | `CrsSection` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CrsSection` | `0` |
| `CrsReference` | `1` |

**Underlying Type**: `System.Int32`

### `PnCrsSectionUnderlay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionUnderlay` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionUnderlay`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get/set` | No | `` |
| `DrawingBasePosition` | `Vector2D` | `get/set` | No | `` |
| `ParentSection` | `PnCrsMainSection` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder`

### `PnCrsBorder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsBorder` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsBorder`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Left` | `Vector2D` | `get/set` | No | `` |
| `Opacity` | `Double` | `get/set` | No | `` |
| `Right` | `Vector2D` | `get/set` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Transform` | `Void` | `Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ITransformable` | `Transform` |

### `PnCrsContour` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsContour` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsContour`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `IList<Vector2D>` | `get` | No | `` |
| `PatternAngle` | `Double` | `get/set` | No | `` |
| `PatternName` | `String` | `get/set` | No | `` |
| `PatternScale` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Transform` | `Void` | `Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ITransformable` | `Transform` |

### `PnCrsElevationProfile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsElevationProfile` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsElevationProfile`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `PnCrsFarm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsFarm` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsFarm`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `PnCrsSectionItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `NameId` | `String` | `get/set` | No | `` |
| `ParentSection` | `PnCrsMainSection` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneFrom` | `Void` | `PnCrsSectionItem source` | `` |
| `CreateNewInstance` | `ITransformable` | `` | `` |
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Transform` | `Void` | `Matrix matrix` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetUniqueName` | `Void` | `ref String nameId, IEnumerable<PnCrsSectionItem> collection` | `` |
| `NameIsUnique` | `Boolean` | `ref String nameId, IEnumerable<PnCrsSectionItem> collection` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ITransformable` | `Transform` |

### `PnCrsSlot` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSlot` |
| **Base Type** | `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSectionItem`
          - `Topomatic.Pipes.CrsSectionFolder.PnCrsSectionItemFolder.PnCrsSlot`

#### Constructors (1)

- `.ctor(PnCrsMainSection section)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectedElement` | `ImElement` | `get/set` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNewItem` | `PnCrsSectionItem` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetCollection` | `IEnumerable<PnCrsSectionItem>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

---
## Namespace: `Topomatic.Pipes.DitchFolder`

### `ConnectedDitchPit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.ConnectedDitchPit` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.DitchPit` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable, Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.DitchPit`
            - `Topomatic.Pipes.DitchFolder.ConnectedDitchPit`

#### Constructors (3)

- `.ctor(Object parent, eDitchType ditchType, UInt32 id)`
- `.ctor(Object parent, eDitchType ditchType, UInt32 id, UInt32 nodeId)`
- `.ctor(Object parent, eDitchType ditchType, UInt32 id, UInt32 nodeId, Double depth)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectedNode` | `PnNode` | `get` | No | `` |
| `NodeId` | `UInt32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnLoadFromStg` | `Void` | `StgNode node` | `` |
| `OnSaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NodeIdName` | `String` | Yes | `"NodeId"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Ditch` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.Ditch` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`

#### Constructors (2)

- `.ctor(Object parent, eDitchType ditchType, UInt32 id)`
- `.ctor(Object parent, UInt32 id, UInt32 lineId, Int32 pipeIndex, Double depth)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `CutPriority` | `Int32` | `get/set` | No | `` |
| `CutVolume` | `Double` | `get/set` | No | `` |
| `DitchSolid` | `Shell` | `get/set` | No | `` |
| `DitchSurfaceInfoContainer` | `DitchSurfaceInfoContainer` | `get` | No | `` |
| `EgSurfaceId` | `String` | `get/set` | No | `` |
| `GeologyModelRelativePath` | `String` | `get/set` | No | `` |
| `GroundInfos` | `IList<GroundInfoContainer>` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Layers` | `IList<DitchLayer>` | `get` | No | `` |
| `LayingMethod` | `eDitchLayingMethod` | `get/set` | No | `` |
| `LeftSlope` | `Double` | `get/set` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PgSurfaceId` | `String` | `get/set` | No | `` |
| `PlanBounds` | `BoundingBox2D` | `get` | No | `` |
| `Positions` | `IList<Vector3D>` | `get` | No | `` |
| `RightSlope` | `Double` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TemplateName` | `String` | `get/set` | No | `` |
| `Type` | `eDitchType` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `OnLoadFromStg` | `Void` | `StgNode node` | `` |
| `OnSaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (2)

- `DitchTransactableField`1` (class)
- `DitchTransactableList`1` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitch` | `get_Id` |
| `ICreatableDitch` | `get_Name` |
| `ICreatableDitch` | `get_Type` |
| `ICreatableDitch` | `Topomatic.Pipes.DitchFolder.ICreatableDitch.get_Layers` |
| `ICreatableDitch` | `get_EgSurfaceId` |
| `ICreatableDitch` | `get_PgSurfaceId` |
| `ICreatableDitch` | `get_TemplateName` |
| `ICreatableDitch` | `get_Width` |
| `ICreatableDitch` | `get_LeftSlope` |
| `ICreatableDitch` | `get_RightSlope` |
| `ICreatableDitch` | `get_Closed` |
| `ICreatableDitch` | `get_CutVolume` |
| `ICreatableDitch` | `set_CutVolume` |
| `ICreatableDitch` | `get_Positions` |
| `ICreatableDitch` | `get_Length3D` |
| `ICreatableDitch` | `get_Surface` |
| `ICreatableDitch` | `get_DitchSurfaceInfoContainer` |
| `ICreatableDitch` | `get_CutPriority` |
| `ICreatableDitch` | `set_CutPriority` |
| `ICreatableDitch` | `get_DitchSolid` |
| `ICreatableDitch` | `set_DitchSolid` |
| `ICreatableDitch` | `get_GroundInfos` |
| `ICreatableDitch` | `get_GeologyModelRelativePath` |
| `ICreatableDitch` | `set_GeologyModelRelativePath` |
| `ICreatableDitch` | `get_LayingMethod` |
| `ICreatableDitch` | `set_LayingMethod` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DitchBuilder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSurfacePoint` | `Int32` | `Surface surface, Vector3D vertex, PointEditor editor` | `` |
| `DrawCreation` | `Void` | `Surface surface, PointEditor pointEditor, TriangleEditor triangleEditor, List<Vector3D> first, List<Vector3D> second, ICreatableDitchLayer layer` | `` |
| `Execute` | `Boolean` | `Surface egSurface, ref SlopeSection section` | `` |
| `OffsetLine` | `List<Vector3D>` | `IList<Vector3D> line, Double offset` | `` |
| `PointIsInnerCorner` | `Boolean` | `Vector2D prev, Vector2D curr, Vector2D next, Int32 index, Double offsetSign` | `` |

#### Nested Types (1)

- `SlopeSection` (class)

### `Ditches` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.Ditches` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.DitchFolder.Ditch, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditches`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentId` | `UInt32` | `get` | No | `` |
| `Item` | `Ditch` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Ditch` | `PnNode node, Double width, Double length, Double depth` | `` |
| `Add` | `Ditch` | `PnSegment segment` | `` |
| `Add` | `Ditch` | `List<Vector3D> positions, Boolean closed` | `` |
| `Add` | `Ditch` | `PnNode node, Double width, Double depth` | `` |
| `Contains` | `Boolean` | `UInt32 index` | `` |
| `GetEnumerator` | `IEnumerator<Ditch>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Void` | `Ditch ditch` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `DitchLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchLayer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitchLayer, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.DitchLayer`

#### Constructors (1)

- `.ctor(Ditch ditch, String name, Double height)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Diameters` | `IList<Double>` | `get` | No | `` |
| `Ditch` | `ICreatableDitch` | `get` | No | `` |
| `FillVolume` | `Double` | `get/set` | No | `` |
| `Has3DModel` | `Boolean` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `LayerSolid` | `Shell` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PatchHandle` | `Int32` | `get/set` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `PnItem` | `PipeNetworkItem` | `get` | No | `` |
| `Points` | `IList<Int32>` | `get` | No | `` |
| `ShowDiameters` | `Boolean` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `Int32 index` | `` |
| `ResetSolidInfo` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DitchLayer` | `Ditch ditch, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitchLayer` | `get_Index` |
| `ICreatableDitchLayer` | `get_Name` |
| `ICreatableDitchLayer` | `set_Name` |
| `ICreatableDitchLayer` | `get_Ditch` |
| `ICreatableDitchLayer` | `get_PnItem` |
| `ICreatableDitchLayer` | `get_Height` |
| `ICreatableDitchLayer` | `set_Height` |
| `ICreatableDitchLayer` | `get_Diameters` |
| `ICreatableDitchLayer` | `get_ShowDiameters` |
| `ICreatableDitchLayer` | `set_ShowDiameters` |
| `ICreatableDitchLayer` | `get_Points` |
| `ICreatableDitchLayer` | `get_PatchHandle` |
| `ICreatableDitchLayer` | `set_PatchHandle` |
| `ICreatableDitchLayer` | `get_FillVolume` |
| `ICreatableDitchLayer` | `set_FillVolume` |
| `ICreatableDitchLayer` | `AddPoint` |
| `ICreatableDitchLayer` | `get_Surface` |
| `ICreatableDitchLayer` | `get_Color` |
| `ICreatableDitchLayer` | `set_Color` |
| `ICreatableDitchLayer` | `get_LayerSolid` |
| `ICreatableDitchLayer` | `set_LayerSolid` |
| `ICreatableDitchLayer` | `get_Has3DModel` |
| `ICreatableDitchLayer` | `ResetSolidInfo` |
| `ICreatableDitchLayer` | `get_Id` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `DitchLayersWrapper` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchLayersWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Ditch ditch)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Ditch` | `Ditch` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `DitchPit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchPit` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.Ditch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable, Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.DitchPit`

#### Constructors (1)

- `.ctor(Object parent, eDitchType ditchType, Double depth, UInt32 id)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Closed` | `Boolean` | `get` | No | `` |
| `Depth` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetVertices` | `List<Vector2D>` | `Double angle` | `` |
| `OnLoadFromStg` | `Void` | `StgNode node` | `` |
| `OnSaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitch` | `get_Closed` |
| `IDitchVerticalOffsetted` | `get_Depth` |
| `IDitchVerticalOffsetted` | `set_Depth` |

### `DitchSurfaceInfoContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchSurfaceInfoContainer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PatchsCount` | `Int32` | `get` | No | `` |
| `PatchsStartIndex` | `Int32` | `get` | No | `` |
| `PointsCount` | `Int32` | `get` | No | `` |
| `PointsStartIndex` | `Int32` | `get` | No | `` |
| `StructureLinesCount` | `Int32` | `get` | No | `` |
| `StructureLinesStartIndex` | `Int32` | `get` | No | `` |
| `TrianglesCount` | `Int32` | `get` | No | `` |
| `TrianglesStartIndex` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetInfo` | `Void` | `Surface networkSurface, Surface ditchGeneratedSurface` | `` |
| `Update` | `Void` | `DitchSurfaceInfoContainer other` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DitchTransactableField`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.Ditch+DitchTransactableField`1` |
| **Base Type** | `` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Pipes.DitchFolder.Ditch+DitchTransactableField`1`

#### Constructors (1)

- `.ctor(Ditch owner, T initialize)`

### `DitchTransactableList`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.Ditch+DitchTransactableList`1` |
| **Base Type** | `` |
| **Implements** | `, System.Collections.IEnumerable, , , System.Collections.ICollection, System.Collections.IList` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Pipes.DitchFolder.Ditch+DitchTransactableList`1`

#### Constructors (1)

- `.ctor(Ditch owner)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GroundInfoContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.GroundInfoContainer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 index, String name, String description, String cipher, String excavationCategory, Double volume)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cipher` | `String` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `ExcavationCategory` | `String` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |

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

### `ICreatableDitch` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.ICreatableDitch` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `` |
| `CutPriority` | `Int32` | `get/set` | No | `` |
| `CutVolume` | `Double` | `get/set` | No | `` |
| `DitchSolid` | `Shell` | `get/set` | No | `` |
| `DitchSurfaceInfoContainer` | `DitchSurfaceInfoContainer` | `get` | No | `` |
| `EgSurfaceId` | `String` | `get` | No | `` |
| `GeologyModelRelativePath` | `String` | `get/set` | No | `` |
| `GroundInfos` | `IList<GroundInfoContainer>` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Layers` | `IList<ICreatableDitchLayer>` | `get` | No | `` |
| `LayingMethod` | `eDitchLayingMethod` | `get/set` | No | `` |
| `LeftSlope` | `Double` | `get` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PgSurfaceId` | `String` | `get` | No | `` |
| `Positions` | `IList<Vector3D>` | `get` | No | `` |
| `RightSlope` | `Double` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TemplateName` | `String` | `get` | No | `` |
| `Type` | `eDitchType` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |

### `ICreatableDitchLayer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.ICreatableDitchLayer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Diameters` | `IList<Double>` | `get` | No | `` |
| `Ditch` | `ICreatableDitch` | `get` | No | `` |
| `FillVolume` | `Double` | `get/set` | No | `` |
| `Has3DModel` | `Boolean` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `LayerSolid` | `Shell` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PatchHandle` | `Int32` | `get/set` | No | `` |
| `PnItem` | `PipeNetworkItem` | `get` | No | `` |
| `Points` | `IList<Int32>` | `get` | No | `` |
| `ShowDiameters` | `Boolean` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `Int32 index` | `` |
| `ResetSolidInfo` | `Void` | `` | `` |

### `IDitchVerticalOffsetted` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Depth` | `Double` | `get/set` | No | `` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchLayersWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `` |
| `Layer` | `DitchLayer` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |

### `NodeConnectedDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.NodeConnectedDitch` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.ConnectedDitchPit` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable, Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.DitchPit`
            - `Topomatic.Pipes.DitchFolder.ConnectedDitchPit`
              - `Topomatic.Pipes.DitchFolder.NodeConnectedDitch`

#### Constructors (3)

- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, UInt32 nodeId)`
- `.ctor(Object parent, UInt32 id, UInt32 nodeId, Double depth)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetVertices` | `List<Vector2D>` | `Double angle` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeConnectedDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.PipeConnectedDitch` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.Ditch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.PipeConnectedDitch`

#### Constructors (3)

- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, PnSegment segment, Double depth)`
- `.ctor(Object parent, UInt32 id, UInt32 lineId, UInt32 segmentId, Double depth, Double startStation, Double endStation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `` |
| `ConnectedLineId` | `UInt32` | `get` | No | `` |
| `EndSta` | `Double` | `get/set` | No | `` |
| `PipeDepth` | `Double` | `get/set` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `StartSta` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnLoadFromStg` | `Void` | `StgNode node` | `` |
| `OnSaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConnectedPipeIndexName` | `String` | Yes | `"ConnectedPipeIndex"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitch` | `get_Closed` |

### `ShaftConnectedDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.ShaftConnectedDitch` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.ConnectedDitchPit` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable, Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.DitchPit`
            - `Topomatic.Pipes.DitchFolder.ConnectedDitchPit`
              - `Topomatic.Pipes.DitchFolder.ShaftConnectedDitch`

#### Constructors (3)

- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, UInt32 nodeId)`
- `.ctor(Object parent, UInt32 id, UInt32 nodeId, Double depth)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetVertices` | `List<Vector2D>` | `Double angle` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SlopeSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.DitchBuilder+SlopeSection` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(List<Vector3D> baseLine, Int32 offsetSide, Double layout, Double height)`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BaseLine` | `List<Vector3D>` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `Layout` | `Double` | No | `` | `` |
| `OffsetSide` | `Int32` | No | `` | `` |
| `TargetLine` | `List<Vector3D>` | No | `` | `` |

### `UnboundedDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.DitchFolder.UnboundedDitch` |
| **Base Type** | `Topomatic.Pipes.DitchFolder.Ditch` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.DitchFolder.Ditch`
          - `Topomatic.Pipes.DitchFolder.UnboundedDitch`

#### Constructors (2)

- `.ctor(Object parent, UInt32 id)`
- `.ctor(Object parent, UInt32 id, List<Vector3D> positions, Boolean closed)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnLoadFromStg` | `Void` | `StgNode node` | `` |
| `OnSaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitch` | `get_Closed` |

---
## Namespace: `Topomatic.Pipes.EditableItems`

### `EiCrossChunkKeyData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.EiCrossChunkKeyData` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ConstructionChunk chunk)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Chunk` | `ConstructionChunk` | `get/set` | No | `` |
| `CrossAxisId` | `UInt32` | `get/set` | No | `` |
| `CrossChunkId` | `UInt32` | `get/set` | No | `` |
| `CrossLineId` | `UInt32` | `get/set` | No | `` |
| `CrossNetworkName` | `String` | `get/set` | No | `` |
| `CrossNetworkUid` | `String` | `get/set` | No | `` |
| `CrossSegmentIndex` | `Int32` | `get/set` | No | `` |
| `FromRightSide` | `Boolean` | `get/set` | No | `` |
| `IsLong` | `Boolean` | `get/set` | No | `` |

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

---
## Namespace: `Topomatic.Pipes.EditableItems.Plan`

### `PnEiPlanCrossAtPipeItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Plan.PnEiPlanCrossAtPipeItem` |
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
      - `Topomatic.Pipes.EditableItems.Plan.PnEiPlanCrossAtPipeItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `CrossName` | `String` | `get/set` | No | `` |
| `HideOnPlan` | `Boolean` | `get/set` | No | `` |
| `LabelParams` | `LabelParams` | `get` | No | `` |
| `PlanCrossProfileDrawing` | `PlanCrossProfileDrawing` | `get/set` | No | `` |
| `PlanCrossSectionDrawing` | `PlanCrossSectionDrawing` | `get/set` | No | `` |
| `PlanNumber` | `String` | `get/set` | No | `` |
| `ProfileWidth` | `Double` | `get/set` | No | `` |
| `SectionWidth` | `Double` | `get/set` | No | `` |

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

### `PnEiPlanCrossAtPipeKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Plan.PnEiPlanCrossAtPipeKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Pipes.EditableItems.Plan.PnEiPlanCrossAtPipeKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(PipesCrossing cross)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLineId` | `UInt32` | `get/set` | No | `` |
| `BaseModelUid` | `String` | `get/set` | No | `` |
| `BasePipe` | `PnSegment` | `get/set` | No | `` |
| `BasePipeIndex` | `Int32` | `get/set` | No | `` |
| `BaseStation` | `Double` | `get/set` | No | `` |
| `CrossLineId` | `UInt32` | `get/set` | No | `` |
| `CrossModelUid` | `String` | `get/set` | No | `` |
| `CrossPipeIndex` | `Int32` | `get/set` | No | `` |
| `CrossSegment` | `PnSegment` | `get/set` | No | `` |
| `CrossStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStringKey` | `String` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.EditableItems.Profile`

### `PnEiProfileCrossAtBaseItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IColoredProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |
| `ShowDiameters` | `CrossDrawContour` | `get/set` | No | `` |
| `UseDefaultShowDiameters` | `Boolean` | `get/set` | No | `` |

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
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |

### `PnEiProfileCrossAtNodeItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtNodeItem` |
| **Base Type** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IColoredProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem`
        - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtNodeItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossAtNodeCharacterPoint` | `CrossAtNodeCharacterPoint` | `get/set` | No | `` |
| `DrawTypeAtNode` | `CrossDrawType` | `get/set` | No | `` |
| `UseDefaultCharacterPoint` | `Boolean` | `get/set` | No | `` |
| `UseDefaultDrawType` | `Boolean` | `get/set` | No | `` |

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

### `PnEiProfileCrossAtNodeKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtNodeKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtNodeKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(UInt32 lineId, Int32 shaftIndex, String otherNetworkGuid, String otherLineNetworkName, PipeNetwork pipeNetwork, Boolean atStart, ConstructionChunk crossChunk, Boolean fromRightSide)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AtStart` | `Boolean` | `get/set` | No | `` |
| `CrossChunkData` | `EiCrossChunkKeyData` | `get/set` | No | `` |
| `LineId` | `UInt32` | `get/set` | No | `` |
| `NodeIndex` | `Int32` | `get/set` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

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

### `PnEiProfileCrossAtSegmentItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtSegmentItem` |
| **Base Type** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IColoredProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.EditableItems.EditableItem`
      - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtBaseItem`
        - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtSegmentItem`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossAtPipeCharacterPoint` | `CrossAtPipeCharacterPoint` | `get/set` | No | `` |
| `DistanceOffset` | `Vector2D` | `get/set` | No | `` |
| `DrawTypeAtPipe` | `CrossDrawType` | `get/set` | No | `` |
| `ShellLeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `ShowDistanceInLight` | `ShowDistanceInLight` | `get/set` | No | `` |
| `UseDefaultCrossAtPipeCharacterPoint` | `Boolean` | `get/set` | No | `` |
| `UseDefaultDrawTypeAtPipe` | `Boolean` | `get/set` | No | `` |

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

### `PnEiProfileCrossAtSegmentKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtSegmentKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Pipes.EditableItems.Profile.PnEiProfileCrossAtSegmentKey`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String otherNetworkGuid, String otherLineNetworkName, PnSegment segment, Double station, ConstructionChunk crossChunk, Double crossStation, Boolean fromRightSide)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossChunkData` | `EiCrossChunkKeyData` | `get/set` | No | `` |
| `CrossStation` | `Double` | `get/set` | No | `` |
| `LineId` | `UInt32` | `get/set` | No | `` |
| `Segment` | `PnSegment` | `get/set` | No | `` |
| `SegmentId` | `UInt32` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.Enums`

### `CrossAtNodeCharacterPoint` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.CrossAtNodeCharacterPoint` |
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
      - `Topomatic.Pipes.Enums.CrossAtNodeCharacterPoint`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InnerBot` | `CrossAtNodeCharacterPoint` | Yes | `InnerBot` | `` |
| `InnerTop` | `CrossAtNodeCharacterPoint` | Yes | `InnerTop` | `` |
| `Middle` | `CrossAtNodeCharacterPoint` | Yes | `Middle` | `` |
| `No` | `CrossAtNodeCharacterPoint` | Yes | `No` | `` |
| `OuterBot` | `CrossAtNodeCharacterPoint` | Yes | `OuterBot` | `` |
| `OuterTop` | `CrossAtNodeCharacterPoint` | Yes | `OuterTop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InnerBot` | `0` |
| `InnerTop` | `1` |
| `OuterBot` | `2` |
| `OuterTop` | `3` |
| `Middle` | `4` |
| `No` | `5` |

**Underlying Type**: `System.Int32`

### `CrossAtPipeCharacterPoint` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.CrossAtPipeCharacterPoint` |
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
      - `Topomatic.Pipes.Enums.CrossAtPipeCharacterPoint`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InnerAuto` | `CrossAtPipeCharacterPoint` | Yes | `InnerAuto` | `` |
| `InnerBot` | `CrossAtPipeCharacterPoint` | Yes | `InnerBot` | `` |
| `InnerTop` | `CrossAtPipeCharacterPoint` | Yes | `InnerTop` | `` |
| `Middle` | `CrossAtPipeCharacterPoint` | Yes | `Middle` | `` |
| `No` | `CrossAtPipeCharacterPoint` | Yes | `No` | `` |
| `OuterAuto` | `CrossAtPipeCharacterPoint` | Yes | `OuterAuto` | `` |
| `OuterBot` | `CrossAtPipeCharacterPoint` | Yes | `OuterBot` | `` |
| `OuterTop` | `CrossAtPipeCharacterPoint` | Yes | `OuterTop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InnerAuto` | `0` |
| `InnerBot` | `1` |
| `InnerTop` | `2` |
| `OuterAuto` | `3` |
| `OuterTop` | `4` |
| `OuterBot` | `5` |
| `Middle` | `6` |
| `No` | `7` |

**Underlying Type**: `System.Int32`

### `CrossDrawContour` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.CrossDrawContour` |
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
      - `Topomatic.Pipes.Enums.CrossDrawContour`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DontShow` | `CrossDrawContour` | Yes | `DontShow` | `` |
| `Inner` | `CrossDrawContour` | Yes | `Inner` | `` |
| `Outer` | `CrossDrawContour` | Yes | `Outer` | `` |
| `OuterAndWall` | `CrossDrawContour` | Yes | `OuterAndWall` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DontShow` | `0` |
| `Inner` | `1` |
| `Outer` | `2` |
| `OuterAndWall` | `3` |

**Underlying Type**: `System.Int32`

### `CrossDrawType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.CrossDrawType` |
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
      - `Topomatic.Pipes.Enums.CrossDrawType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Inner` | `CrossDrawType` | Yes | `Inner` | `` |
| `InnerAndOuter` | `CrossDrawType` | Yes | `InnerAndOuter` | `` |
| `Outer` | `CrossDrawType` | Yes | `Outer` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InnerAndOuter` | `0` |
| `Inner` | `1` |
| `Outer` | `2` |

**Underlying Type**: `System.Int32`

### `DeterminationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.DeterminationType` |
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
      - `Topomatic.Pipes.Enums.DeterminationType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dismantling` | `DeterminationType` | Yes | `Dismantling` | `` |
| `Exist` | `DeterminationType` | Yes | `Exist` | `` |
| `Inactive` | `DeterminationType` | Yes | `Inactive` | `` |
| `Project` | `DeterminationType` | Yes | `Project` | `` |
| `Reconstruction` | `DeterminationType` | Yes | `Reconstruction` | `` |
| `Temporary` | `DeterminationType` | Yes | `Temporary` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Project` | `0` |
| `Exist` | `1` |
| `Dismantling` | `2` |
| `Inactive` | `3` |
| `Temporary` | `4` |
| `Reconstruction` | `5` |

**Underlying Type**: `System.Int32`

### `eDitchLayingMethod` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.eDitchLayingMethod` |
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
      - `Topomatic.Pipes.Enums.eDitchLayingMethod`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Aboveground` | `eDitchLayingMethod` | Yes | `Aboveground` | `` |
| `Underground` | `eDitchLayingMethod` | Yes | `Underground` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Underground` | `0` |
| `Aboveground` | `1` |

**Underlying Type**: `System.Int32`

### `FieldChangedType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.FieldChangedType` |
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
      - `Topomatic.Pipes.Enums.FieldChangedType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Geometry` | `FieldChangedType` | Yes | `Geometry` | `` |
| `Label` | `FieldChangedType` | Yes | `Label` | `` |
| `RefreshCache` | `FieldChangedType` | Yes | `RefreshCache` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Geometry` | `0` |
| `Label` | `1` |
| `RefreshCache` | `2` |

**Underlying Type**: `System.Int32`

### `GnbPipeDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.GnbPipeDirection` |
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
      - `Topomatic.Pipes.Enums.GnbPipeDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `GnbPipeDirection` | Yes | `Backward` | `` |
| `Forward` | `GnbPipeDirection` | Yes | `Forward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `Backward` | `1` |

**Underlying Type**: `System.Int32`

### `IncutProfileDrawType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.IncutProfileDrawType` |
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
      - `Topomatic.Pipes.Enums.IncutProfileDrawType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossLeft` | `IncutProfileDrawType` | Yes | `CrossLeft` | `` |
| `CrossRight` | `IncutProfileDrawType` | Yes | `CrossRight` | `` |
| `Left` | `IncutProfileDrawType` | Yes | `Left` | `` |
| `Right` | `IncutProfileDrawType` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `CrossLeft` | `1` |
| `CrossRight` | `2` |
| `Right` | `3` |

**Underlying Type**: `System.Int32`

### `NetworkCoreType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NetworkCoreType` |
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
      - `Topomatic.Pipes.Enums.NetworkCoreType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PipeNetwork` | `NetworkCoreType` | Yes | `PipeNetwork` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WireNetwork` | `NetworkCoreType` | Yes | `WireNetwork` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PipeNetwork` | `0` |
| `WireNetwork` | `1` |

**Underlying Type**: `System.Int32`

### `NetworkCoreTypeObsolete` (enum)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NetworkCoreTypeObsolete` |
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
      - `Topomatic.Pipes.Enums.NetworkCoreTypeObsolete`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PipeNetwork` | `NetworkCoreTypeObsolete` | Yes | `PipeNetwork` | `` |
| `RailContactWireNetwork` | `NetworkCoreTypeObsolete` | Yes | `RailContactWireNetwork` | `` |
| `TechDuctNetwork` | `NetworkCoreTypeObsolete` | Yes | `TechDuctNetwork` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WireNetwork` | `NetworkCoreTypeObsolete` | Yes | `WireNetwork` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PipeNetwork` | `0` |
| `WireNetwork` | `1` |
| `TechDuctNetwork` | `2` |
| `RailContactWireNetwork` | `3` |

**Underlying Type**: `System.Int32`

### `NetworkSchemePipeDirectionEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NetworkSchemePipeDirectionEnum` |
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
      - `Topomatic.Pipes.Enums.NetworkSchemePipeDirectionEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `NetworkSchemePipeDirectionEnum` | Yes | `Backward` | `` |
| `Forward` | `NetworkSchemePipeDirectionEnum` | Yes | `Forward` | `` |
| `Grade` | `NetworkSchemePipeDirectionEnum` | Yes | `Grade` | `` |
| `HideOnPlan` | `NetworkSchemePipeDirectionEnum` | Yes | `HideOnPlan` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Grade` | `0` |
| `Forward` | `1` |
| `Backward` | `2` |
| `HideOnPlan` | `3` |

**Underlying Type**: `System.Int32`

### `NodeBySegmentSelector` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NodeBySegmentSelector` |
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
      - `Topomatic.Pipes.Enums.NodeBySegmentSelector`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MostBot` | `NodeBySegmentSelector` | Yes | `MostBot` | `` |
| `MostTop` | `NodeBySegmentSelector` | Yes | `MostTop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MostTop` | `0` |
| `MostBot` | `1` |

**Underlying Type**: `System.Int32`

### `NodeParamsThroughTypeEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NodeParamsThroughTypeEnum` |
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
      - `Topomatic.Pipes.Enums.NodeParamsThroughTypeEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Library` | `NodeParamsThroughTypeEnum` | Yes | `Library` | `` |
| `No` | `NodeParamsThroughTypeEnum` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `NodeParamsThroughTypeEnum` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Library` | `0` |
| `Yes` | `1` |
| `No` | `-1` |

**Underlying Type**: `System.Int32`

### `NodePlanThroughTypeEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NodePlanThroughTypeEnum` |
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
      - `Topomatic.Pipes.Enums.NodePlanThroughTypeEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `NodePlanThroughTypeEnum` | Yes | `Default` | `` |
| `Library` | `NodePlanThroughTypeEnum` | Yes | `Library` | `` |
| `StraightLine` | `NodePlanThroughTypeEnum` | Yes | `StraightLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Library` | `0` |
| `StraightLine` | `1` |
| `Default` | `-1` |

**Underlying Type**: `System.Int32`

### `NodeProfileDrawType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NodeProfileDrawType` |
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
      - `Topomatic.Pipes.Enums.NodeProfileDrawType`

#### Fields (29)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AirOut` | `NodeProfileDrawType` | Yes | `AirOut` | `` |
| `AirOutInHalfShaft` | `NodeProfileDrawType` | Yes | `AirOutInHalfShaft` | `` |
| `AirOutInShaft` | `NodeProfileDrawType` | Yes | `AirOutInShaft` | `` |
| `BuildingAdjoining` | `NodeProfileDrawType` | Yes | `BuildingAdjoining` | `` |
| `ControlDeviceOnPole` | `NodeProfileDrawType` | Yes | `ControlDeviceOnPole` | `` |
| `ControlDeviceUnderCover` | `NodeProfileDrawType` | Yes | `ControlDeviceUnderCover` | `` |
| `ControlPipeUnderCover` | `NodeProfileDrawType` | Yes | `ControlPipeUnderCover` | `` |
| `Damper` | `NodeProfileDrawType` | Yes | `Damper` | `` |
| `DamperInHalfShaft` | `NodeProfileDrawType` | Yes | `DamperInHalfShaft` | `` |
| `DamperInShaft` | `NodeProfileDrawType` | Yes | `DamperInShaft` | `` |
| `Default` | `NodeProfileDrawType` | Yes | `Default` | `` |
| `DiameterChanger` | `NodeProfileDrawType` | Yes | `DiameterChanger` | `` |
| `EndCap` | `NodeProfileDrawType` | Yes | `EndCap` | `` |
| `EndCapInHalfShaft` | `NodeProfileDrawType` | Yes | `EndCapInHalfShaft` | `` |
| `EndCapInShaft` | `NodeProfileDrawType` | Yes | `EndCapInShaft` | `` |
| `GroundExit` | `NodeProfileDrawType` | Yes | `GroundExit` | `` |
| `HalfShaft` | `NodeProfileDrawType` | Yes | `HalfShaft` | `` |
| `Hydrant` | `NodeProfileDrawType` | Yes | `Hydrant` | `` |
| `HydrantInHalfShaft` | `NodeProfileDrawType` | Yes | `HydrantInHalfShaft` | `` |
| `HydrantInShaft` | `NodeProfileDrawType` | Yes | `HydrantInShaft` | `` |
| `MaterialChanger` | `NodeProfileDrawType` | Yes | `MaterialChanger` | `` |
| `PlanAngleNode` | `NodeProfileDrawType` | Yes | `PlanAngleNode` | `` |
| `PlanAngleWithControlPipeNode` | `NodeProfileDrawType` | Yes | `PlanAngleWithControlPipeNode` | `` |
| `PoleFixed` | `NodeProfileDrawType` | Yes | `PoleFixed` | `` |
| `PoleMovable` | `NodeProfileDrawType` | Yes | `PoleMovable` | `` |
| `Shaft` | `NodeProfileDrawType` | Yes | `Shaft` | `` |
| `StreetlightAnchored` | `NodeProfileDrawType` | Yes | `StreetlightAnchored` | `` |
| `StreetlightIntermediate` | `NodeProfileDrawType` | Yes | `StreetlightIntermediate` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `Shaft` | `1` |
| `HalfShaft` | `2` |
| `Hydrant` | `3` |
| `HydrantInShaft` | `4` |
| `HydrantInHalfShaft` | `5` |
| `Damper` | `6` |
| `DamperInShaft` | `7` |
| `DamperInHalfShaft` | `8` |
| `EndCap` | `9` |
| `EndCapInShaft` | `10` |
| `EndCapInHalfShaft` | `11` |
| `AirOut` | `12` |
| `AirOutInShaft` | `13` |
| `AirOutInHalfShaft` | `14` |
| `DiameterChanger` | `15` |
| `MaterialChanger` | `16` |
| `GroundExit` | `17` |
| `ControlPipeUnderCover` | `18` |
| `ControlDeviceUnderCover` | `19` |
| `ControlDeviceOnPole` | `20` |
| `PlanAngleNode` | `21` |
| `PlanAngleWithControlPipeNode` | `22` |
| `BuildingAdjoining` | `23` |
| `PoleMovable` | `24` |
| `PoleFixed` | `25` |
| `StreetlightIntermediate` | `26` |
| `StreetlightAnchored` | `27` |

**Underlying Type**: `System.Int32`

### `NodeProfileThroughTypeEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.NodeProfileThroughTypeEnum` |
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
      - `Topomatic.Pipes.Enums.NodeProfileThroughTypeEnum`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `False` | `NodeProfileThroughTypeEnum` | Yes | `False` | `` |
| `Joint` | `NodeProfileThroughTypeEnum` | Yes | `Joint` | `` |
| `Library` | `NodeProfileThroughTypeEnum` | Yes | `Library` | `` |
| `StraightLine` | `NodeProfileThroughTypeEnum` | Yes | `StraightLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Library` | `0` |
| `StraightLine` | `1` |
| `Joint` | `2` |
| `False` | `-1` |

**Underlying Type**: `System.Int32`

### `ParamsThroughType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ParamsThroughType` |
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
      - `Topomatic.Pipes.Enums.ParamsThroughType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `No` | `ParamsThroughType` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `ParamsThroughType` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `No` | `0` |
| `Yes` | `1` |

**Underlying Type**: `System.Int32`

### `PipeCharacterPoint` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PipeCharacterPoint` |
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
      - `Topomatic.Pipes.Enums.PipeCharacterPoint`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInner` | `PipeCharacterPoint` | Yes | `BotInner` | `` |
| `BotOuter` | `PipeCharacterPoint` | Yes | `BotOuter` | `` |
| `Middle` | `PipeCharacterPoint` | Yes | `Middle` | `` |
| `TopInner` | `PipeCharacterPoint` | Yes | `TopInner` | `` |
| `TopOuter` | `PipeCharacterPoint` | Yes | `TopOuter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopOuter` | `0` |
| `TopInner` | `1` |
| `Middle` | `2` |
| `BotInner` | `3` |
| `BotOuter` | `4` |

**Underlying Type**: `System.Int32`

### `PipeEarthWorkType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PipeEarthWorkType` |
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
      - `Topomatic.Pipes.Enums.PipeEarthWorkType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Closed` | `PipeEarthWorkType` | Yes | `Closed` | `` |
| `Open` | `PipeEarthWorkType` | Yes | `Open` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Open` | `0` |
| `Closed` | `1` |

**Underlying Type**: `System.Int32`

### `PipeFoundationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PipeFoundationType` |
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
      - `Topomatic.Pipes.Enums.PipeFoundationType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PipeFoundationNatural` | `PipeFoundationType` | Yes | `PipeFoundationNatural` | `` |
| `PipeFoundationSand010` | `PipeFoundationType` | Yes | `PipeFoundationSand010` | `` |
| `PipeFoundationWithout` | `PipeFoundationType` | Yes | `PipeFoundationWithout` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PipeFoundationWithout` | `0` |
| `PipeFoundationNatural` | `1` |
| `PipeFoundationSand010` | `2` |

**Underlying Type**: `System.Int32`

### `PipeIsolationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PipeIsolationType` |
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
      - `Topomatic.Pipes.Enums.PipeIsolationType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NoIsolation` | `PipeIsolationType` | Yes | `NoIsolation` | `` |
| `PipeIsolationNormal` | `PipeIsolationType` | Yes | `PipeIsolationNormal` | `` |
| `PipeIsolationReinforced` | `PipeIsolationType` | Yes | `PipeIsolationReinforced` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NoIsolation` | `0` |
| `PipeIsolationNormal` | `1` |
| `PipeIsolationReinforced` | `2` |

**Underlying Type**: `System.Int32`

### `PipeRadiusForPlt` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PipeRadiusForPlt` |
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
      - `Topomatic.Pipes.Enums.PipeRadiusForPlt`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Inner` | `PipeRadiusForPlt` | Yes | `Inner` | `` |
| `InnerAndOuter` | `PipeRadiusForPlt` | Yes | `InnerAndOuter` | `` |
| `Middle` | `PipeRadiusForPlt` | Yes | `Middle` | `` |
| `Outer` | `PipeRadiusForPlt` | Yes | `Outer` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Inner` | `0` |
| `Outer` | `1` |
| `Middle` | `2` |
| `InnerAndOuter` | `3` |

**Underlying Type**: `System.Int32`

### `PlanCrossProfileDrawing` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PlanCrossProfileDrawing` |
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
      - `Topomatic.Pipes.Enums.PlanCrossProfileDrawing`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossLine` | `PlanCrossProfileDrawing` | Yes | `CrossLine` | `` |
| `CrossLineWithShell` | `PlanCrossProfileDrawing` | Yes | `CrossLineWithShell` | `` |
| `No` | `PlanCrossProfileDrawing` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CrossLine` | `0` |
| `CrossLineWithShell` | `1` |
| `No` | `2` |

**Underlying Type**: `System.Int32`

### `PlanCrossSectionDrawing` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PlanCrossSectionDrawing` |
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
      - `Topomatic.Pipes.Enums.PlanCrossSectionDrawing`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Line` | `PlanCrossSectionDrawing` | Yes | `Line` | `` |
| `LineWithShell` | `PlanCrossSectionDrawing` | Yes | `LineWithShell` | `` |
| `No` | `PlanCrossSectionDrawing` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Line` | `0` |
| `LineWithShell` | `1` |
| `No` | `2` |

**Underlying Type**: `System.Int32`

### `PlanThroughType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.PlanThroughType` |
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
      - `Topomatic.Pipes.Enums.PlanThroughType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `PlanThroughType` | Yes | `Default` | `` |
| `StraightLine` | `PlanThroughType` | Yes | `StraightLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `StraightLine` | `1` |

**Underlying Type**: `System.Int32`

### `ProfileSegmentDrawType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ProfileSegmentDrawType` |
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
      - `Topomatic.Pipes.Enums.ProfileSegmentDrawType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInner` | `ProfileSegmentDrawType` | Yes | `BotInner` | `` |
| `BotOuter` | `ProfileSegmentDrawType` | Yes | `BotOuter` | `` |
| `Middle` | `ProfileSegmentDrawType` | Yes | `Middle` | `` |
| `TopInner` | `ProfileSegmentDrawType` | Yes | `TopInner` | `` |
| `TopOuter` | `ProfileSegmentDrawType` | Yes | `TopOuter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopOuter` | `0` |
| `TopInner` | `1` |
| `Middle` | `2` |
| `BotInner` | `3` |
| `BotOuter` | `4` |

**Underlying Type**: `System.Int32`

### `ProfileThroughType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ProfileThroughType` |
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
      - `Topomatic.Pipes.Enums.ProfileThroughType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `ProfileThroughType` | Yes | `Default` | `` |
| `Joint` | `ProfileThroughType` | Yes | `Joint` | `` |
| `StraightLine` | `ProfileThroughType` | Yes | `StraightLine` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Default` | `0` |
| `StraightLine` | `1` |
| `Joint` | `2` |

**Underlying Type**: `System.Int32`

### `RailContactWireSupportZigzagType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.RailContactWireSupportZigzagType` |
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
      - `Topomatic.Pipes.Enums.RailContactWireSupportZigzagType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `RailContactWireSupportZigzagType` | Yes | `Backward` | `` |
| `Forward` | `RailContactWireSupportZigzagType` | Yes | `Forward` | `` |
| `NoZigzag` | `RailContactWireSupportZigzagType` | Yes | `NoZigzag` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NoZigzag` | `0` |
| `Forward` | `1` |
| `Backward` | `-1` |

**Underlying Type**: `System.Int32`

### `SectionProfileType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SectionProfileType` |
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
      - `Topomatic.Pipes.Enums.SectionProfileType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Circle` | `SectionProfileType` | Yes | `Circle` | `` |
| `Rectangular` | `SectionProfileType` | Yes | `Rectangular` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Circle` | `0` |
| `Rectangular` | `1` |

**Underlying Type**: `System.Int32`

### `SegmentDepthCharacterPointType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentDepthCharacterPointType` |
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
      - `Topomatic.Pipes.Enums.SegmentDepthCharacterPointType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInner` | `SegmentDepthCharacterPointType` | Yes | `BotInner` | `` |
| `BotOuter` | `SegmentDepthCharacterPointType` | Yes | `BotOuter` | `` |
| `Middle` | `SegmentDepthCharacterPointType` | Yes | `Middle` | `` |
| `No` | `SegmentDepthCharacterPointType` | Yes | `No` | `` |
| `TopInner` | `SegmentDepthCharacterPointType` | Yes | `TopInner` | `` |
| `TopOuter` | `SegmentDepthCharacterPointType` | Yes | `TopOuter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TopOuter` | `0` |
| `TopInner` | `1` |
| `Middle` | `2` |
| `BotInner` | `3` |
| `BotOuter` | `4` |
| `No` | `5` |

**Underlying Type**: `System.Int32`

### `SegmentHatchStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentHatchStyle` |
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
      - `Topomatic.Pipes.Enums.SegmentHatchStyle`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PltField` | `SegmentHatchStyle` | Yes | `PltField` | `` |
| `ProfileWindow` | `SegmentHatchStyle` | Yes | `ProfileWindow` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ProfileWindow` | `0` |
| `PltField` | `1` |

**Underlying Type**: `System.Int32`

### `SegmentLayoutType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentLayoutType` |
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
      - `Topomatic.Pipes.Enums.SegmentLayoutType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BySegmentCenter` | `SegmentLayoutType` | Yes | `BySegmentCenter` | `` |
| `Overground` | `SegmentLayoutType` | Yes | `Overground` | `` |
| `Underground` | `SegmentLayoutType` | Yes | `Underground` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `BySegmentCenter` | `0` |
| `Underground` | `1` |
| `Overground` | `2` |

**Underlying Type**: `System.Int32`

### `SegmentReserveRoundingType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentReserveRoundingType` |
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
      - `Topomatic.Pipes.Enums.SegmentReserveRoundingType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DoNotRound` | `SegmentReserveRoundingType` | Yes | `DoNotRound` | `` |
| `RoundTo` | `SegmentReserveRoundingType` | Yes | `RoundTo` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DoNotRound` | `0` |
| `RoundTo` | `1` |

**Underlying Type**: `System.Int32`

### `SegmentReserveType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentReserveType` |
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
      - `Topomatic.Pipes.Enums.SegmentReserveType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Meters` | `SegmentReserveType` | Yes | `Meters` | `` |
| `Percent` | `SegmentReserveType` | Yes | `Percent` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Percent` | `0` |
| `Meters` | `1` |

**Underlying Type**: `System.Int32`

### `SegmentStationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentStationType` |
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
      - `Topomatic.Pipes.Enums.SegmentStationType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FromEnd` | `SegmentStationType` | Yes | `FromEnd` | `` |
| `FromStart` | `SegmentStationType` | Yes | `FromStart` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FromStart` | `0` |
| `FromEnd` | `1` |

**Underlying Type**: `System.Int32`

### `SegmentVertexCharacterPointType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SegmentVertexCharacterPointType` |
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
      - `Topomatic.Pipes.Enums.SegmentVertexCharacterPointType`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInner` | `SegmentVertexCharacterPointType` | Yes | `BotInner` | `` |
| `BotOuter` | `SegmentVertexCharacterPointType` | Yes | `BotOuter` | `` |
| `CharacterPoint` | `SegmentVertexCharacterPointType` | Yes | `CharacterPoint` | `` |
| `EgDepth` | `SegmentVertexCharacterPointType` | Yes | `EgDepth` | `` |
| `Middle` | `SegmentVertexCharacterPointType` | Yes | `Middle` | `` |
| `No` | `SegmentVertexCharacterPointType` | Yes | `No` | `` |
| `PgDepth` | `SegmentVertexCharacterPointType` | Yes | `PgDepth` | `` |
| `TopInner` | `SegmentVertexCharacterPointType` | Yes | `TopInner` | `` |
| `TopOuter` | `SegmentVertexCharacterPointType` | Yes | `TopOuter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CharacterPoint` | `0` |
| `EgDepth` | `1` |
| `PgDepth` | `2` |
| `TopOuter` | `3` |
| `TopInner` | `4` |
| `Middle` | `5` |
| `BotInner` | `6` |
| `BotOuter` | `7` |
| `No` | `8` |

**Underlying Type**: `System.Int32`

### `ShaftBotElevationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ShaftBotElevationType` |
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
      - `Topomatic.Pipes.Enums.ShaftBotElevationType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalculatedSections` | `ShaftBotElevationType` | Yes | `CalculatedSections` | `` |
| `FixedDepth` | `ShaftBotElevationType` | Yes | `FixedDepth` | `` |
| `FixedElevation` | `ShaftBotElevationType` | Yes | `FixedElevation` | `` |
| `FixedPipeSurplus` | `ShaftBotElevationType` | Yes | `FixedPipeSurplus` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FixedElevation` | `0` |
| `FixedPipeSurplus` | `1` |
| `FixedDepth` | `2` |
| `CalculatedSections` | `-1` |

**Underlying Type**: `System.Int32`

### `ShellControlPipeCount` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ShellControlPipeCount` |
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
      - `Topomatic.Pipes.Enums.ShellControlPipeCount`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `ShellControlPipeCount` | Yes | `Both` | `` |
| `End` | `ShellControlPipeCount` | Yes | `End` | `` |
| `No` | `ShellControlPipeCount` | Yes | `No` | `` |
| `Start` | `ShellControlPipeCount` | Yes | `Start` | `` |
| `Top` | `ShellControlPipeCount` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `No` | `0` |
| `Start` | `1` |
| `End` | `2` |
| `Both` | `3` |
| `Top` | `4` |

**Underlying Type**: `System.Int32`

### `ShowDistanceInLight` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.ShowDistanceInLight` |
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
      - `Topomatic.Pipes.Enums.ShowDistanceInLight`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Defalut` | `ShowDistanceInLight` | Yes | `Defalut` | `` |
| `No` | `ShowDistanceInLight` | Yes | `No` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `ShowDistanceInLight` | Yes | `Yes` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Defalut` | `0` |
| `Yes` | `1` |
| `No` | `2` |

**Underlying Type**: `System.Int32`

### `SimpleBaseElevationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SimpleBaseElevationType` |
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
      - `Topomatic.Pipes.Enums.SimpleBaseElevationType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByBasis` | `SimpleBaseElevationType` | Yes | `ByBasis` | `` |
| `Dynamic` | `SimpleBaseElevationType` | Yes | `Dynamic` | `` |
| `FixedDepth` | `SimpleBaseElevationType` | Yes | `FixedDepth` | `` |
| `FixedElevation` | `SimpleBaseElevationType` | Yes | `FixedElevation` | `` |
| `FixedSurplus` | `SimpleBaseElevationType` | Yes | `FixedSurplus` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FixedElevation` | `0` |
| `FixedSurplus` | `1` |
| `FixedDepth` | `2` |
| `ByBasis` | `3` |
| `Dynamic` | `-1` |

**Underlying Type**: `System.Int32`

### `SurfacePointVisibility` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.SurfacePointVisibility` |
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
      - `Topomatic.Pipes.Enums.SurfacePointVisibility`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auto` | `SurfacePointVisibility` | Yes | `Auto` | `` |
| `Hide` | `SurfacePointVisibility` | Yes | `Hide` | `` |
| `Show` | `SurfacePointVisibility` | Yes | `Show` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Show` | `0` |
| `Hide` | `1` |
| `Auto` | `-1` |

**Underlying Type**: `System.Int32`

### `WireSagType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.WireSagType` |
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
      - `Topomatic.Pipes.Enums.WireSagType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FixedSag` | `WireSagType` | Yes | `FixedSag` | `` |
| `NoSag` | `WireSagType` | Yes | `NoSag` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NoSag` | `0` |
| `FixedSag` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Pipes.Enums.Converters`

### `CrossAtNodeCharacterPointEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.CrossAtNodeCharacterPointEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.CrossAtNodeCharacterPointEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CrossAtPipeCharacterPointEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.CrossAtPipeCharacterPointEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.CrossAtPipeCharacterPointEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CrossDrawDiameterConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.CrossDrawDiameterConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.CrossDrawDiameterConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CrossDrawTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.CrossDrawTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.CrossDrawTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DeterminationTypeCutEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.DeterminationTypeCutEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.DeterminationTypeCutEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DeterminationTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.DeterminationTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.DeterminationTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DitchLayingMethodEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.DitchLayingMethodEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.DitchLayingMethodEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GnbPipeDirectionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.GnbPipeDirectionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.GnbPipeDirectionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `IncutProfileDrawTypeTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.IncutProfileDrawTypeTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.IncutProfileDrawTypeTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LinetypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.LinetypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.LinetypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `MaterialTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.MaterialTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.MaterialTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `MaterialTextConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.MaterialTextConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.MaterialTextConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NetworkCoreTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NetworkCoreTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NetworkCoreTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NetworkSchemePipeDirectionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NetworkSchemePipeDirectionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NetworkSchemePipeDirectionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NodeBySegmentSelectorConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NodeBySegmentSelectorConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NodeBySegmentSelectorConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NodeParamsThroughTypeTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NodeParamsThroughTypeTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NodeParamsThroughTypeTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NodePlanThroughTypeTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NodePlanThroughTypeTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NodePlanThroughTypeTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NodeProfileThroughTypeTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NodeProfileThroughTypeTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NodeProfileThroughTypeTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `NodeProfileTypeTagConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.NodeProfileTypeTagConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.NodeProfileTypeTagConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeCharacterPointConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PipeCharacterPointConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PipeCharacterPointConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeEarthWorkTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PipeEarthWorkTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PipeEarthWorkTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeFoundationTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PipeFoundationTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PipeFoundationTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeIsolationTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PipeIsolationTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PipeIsolationTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PipeRadiusForPltConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PipeRadiusForPltConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PipeRadiusForPltConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlanCrossProfileDrawingConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PlanCrossProfileDrawingConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PlanCrossProfileDrawingConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlanCrossSectionDrawingConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.PlanCrossSectionDrawingConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.PlanCrossSectionDrawingConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ProfileSegmentDrawTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.ProfileSegmentDrawTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.ProfileSegmentDrawTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RailContactWireSupportZigzagTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.RailContactWireSupportZigzagTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.RailContactWireSupportZigzagTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentDepthCharacterPointTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentDepthCharacterPointTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentDepthCharacterPointTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertToPipeCharacterPoint` | `PipeCharacterPoint` | `SegmentDepthCharacterPointType cp` | `` |

### `SegmentLayoutTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentLayoutTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentLayoutTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentReserveRoundingTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentReserveRoundingTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentReserveRoundingTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentReserveTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentReserveTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentReserveTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentStationTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentStationTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentStationTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentVertexCharacterPointTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.SegmentVertexCharacterPointTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.SegmentVertexCharacterPointTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ShowDistanceInLightEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.ShowDistanceInLightEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.ShowDistanceInLightEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `VisibleSurfacePointEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.VisibleSurfacePointEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.VisibleSurfacePointEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `WireSagEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Enums.Converters.WireSagEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Enums.Converters.WireSagEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Pipes.LightweightLine`

### `GeometryChangedEventArgs<T where LightweightLineVertex, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, class, LightweightLineVertex>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLine`1+GeometryChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.LightweightLine.LightweightLine`1+GeometryChangedEventArgs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LabelField`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.PlanVertex+LabelField`1` |
| **Base Type** | `` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Pipes.LightweightLine.PlanVertex+LabelField`1`

#### Constructors (1)

- `.ctor(ITransactable owner, T initialize)`

### `LightweightLine`1<T where LightweightLineVertex, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, class, LightweightLineVertex>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLine`1` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, , System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.LightweightLine.LightweightLine`1`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, Vector2D[] positions)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `CompoundLine` | `CompoundLine` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `LightweightLineVertex` | `` | `` |
| `Add` | `LightweightLineVertex` | `Vector2D position` | `` |
| `Add` | `LightweightLineVertex` | `Vector2D position, Double radius` | `` |
| `AfterLoad` | `Void` | `` | `` |
| `Assign` | `Void` | `LightweightLine<T> line` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `GetInfo` | `VertexInfo<T>` | `Int32 index` | `` |
| `Insert` | `T` | `Int32 index` | `` |
| `Insert` | `T` | `Int32 index, T vertex` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Offset` | `Boolean` | `Double offset, LightweightLine<T> destination` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Reverse` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `GeometryChanged` | `EventHandler<GeometryChangedEventArgs<T>>` | No | `` |

#### Nested Types (3)

- `GeometryChangedEventArgs` (class)
- `State` (enum)
- `VertexInfo` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LightweightLineExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLineExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExtractLine` | `Void` | `LightweightLine<T> planLine, LightweightLine<T> destination, Double startStation, Double endStation` | `Extension` |
| `GetPieceLine` | `Void` | `LightweightLine<T> source, LightweightLine<T> destination, Int32 index` | `Extension` |
| `NodeChangeValid` | `Boolean` | `LightweightLine<T> source, Int32 index, T vertex` | `Extension` |
| `NodeInsertValid` | `Boolean` | `LightweightLine<T> source, Int32 index, T vertex` | `Extension` |
| `NodeRemoveValid` | `Boolean` | `LightweightLine<T> source, Int32 index` | `Extension` |
| `PrepareAfter` | `Void` | `LightweightLine<T> source, LightweightLine<U> destination, Int32 indexNear` | `` |
| `PrepareBefore` | `Void` | `LightweightLine<T> source, LightweightLine<U> destination, Int32 indexNear` | `` |
| `Valid` | `Boolean` | `LightweightProfile source` | `Extension` |
| `Valid` | `Boolean` | `LightweightPlan source` | `Extension` |

### `LightweightLineVertex` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLineVertex` |
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
      - `Topomatic.Pipes.LightweightLine.LightweightLineVertex`

#### Constructors (1)

- `.ctor(Object parent, Vector2D position)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsParabola` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Source` | `String` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LightweightLineVertex vertex` | `` |
| `AssignLeaderParams` | `Void` | `LightweightLineVertex vertex` | `` |
| `Equals` | `Boolean` | `LightweightLineVertex v` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SourceConnectionSegmentEnd` | `String` | Yes | `"SourceConnectionSegmentEnd"` | `` |
| `SourceConnectionSegmentStart` | `String` | Yes | `"SourceConnectionSegmentStart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LightweightPlan` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightPlan` |
| **Base Type** | `Topomatic.Pipes.LightweightLine.LightweightLine`1[[Topomatic.Pipes.LightweightLine.PlanVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.LightweightLine.PlanVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.LightweightLine.LightweightLine`1[[Topomatic.Pipes.LightweightLine.PlanVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Pipes.LightweightLine.LightweightPlan`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, LightweightPlan plan)`
- `.ctor(Object parent, Vector2D[] positions)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExtractPlanLine` | `LightweightPlan` | `Double startStation, Double endStation` | `` |
| `TryGetTangentVector` | `Boolean` | `Double station, ref Vector2D tangent` | `` |
| `TryGetTangentVector` | `Boolean` | `Boolean atStart, ref Vector2D tangent` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `LabelChanged` | `EventHandler<PlanLineLabelChangedEventArgs>` | No | `` |

#### Nested Types (1)

- `PlanLineLabelChangedEventArgs` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LightweightProfile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightProfile` |
| **Base Type** | `Topomatic.Pipes.LightweightLine.LightweightLine`1[[Topomatic.Pipes.LightweightLine.ProfileVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.LightweightLine.ProfileVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.LightweightLine.LightweightLine`1[[Topomatic.Pipes.LightweightLine.ProfileVertex, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Pipes.LightweightLine.LightweightProfile`

#### Constructors (4)

- `.ctor(Object parent)`
- `.ctor(Object parent, LightweightProfile profile)`
- `.ctor(Object parent, Double length)`
- `.ctor(Object parent, Vector2D[] positions)`

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddElevation` | `Void` | `Double delta` | `` |
| `AfterLoad` | `Void` | `` | `` |
| `ExtractProfileLine` | `LightweightProfile` | `Double startStation, Double endStation` | `` |
| `GetElevation` | `Boolean` | `Double station, ref Double startY, ref Double endY` | `` |
| `GetElevation` | `Boolean` | `Boolean atStart, ref Double startY, ref Double endY` | `` |
| `GetExtremumPoint` | `Vector2D` | `Boolean top` | `` |
| `GetHorizontalOffset` | `LightweightProfile` | `Double offset` | `` |
| `Offset` | `Boolean` | `Double offset, LightweightLine<ProfileVertex> destination, Boolean trimWalls` | `` |
| `Offset` | `Boolean` | `Double offset, LightweightLine<ProfileVertex> destination` | `` |
| `Reverse` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Boolean` | `CompoundLine cl, Double station, ref Double startY, ref Double endY` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanLineLabelChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightPlan+PlanLineLabelChangedEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Pipes.LightweightLine.LightweightPlan+PlanLineLabelChangedEventArgs`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlanVertex` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.PlanVertex` |
| **Base Type** | `Topomatic.Pipes.LightweightLine.LightweightLineVertex` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.LightweightLine.LightweightLineVertex`
        - `Topomatic.Pipes.LightweightLine.PlanVertex`

#### Constructors (1)

- `.ctor(Object parent, Vector2D position)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeaderAngle` | `Double` | `get/set` | No | `` |
| `LeaderFlipText` | `Boolean` | `get/set` | No | `` |
| `LeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `TextAlignment` | `LeaderTextAlignment` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignLeaderParams` | `Void` | `LightweightLineVertex vertex` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `LabelField`1` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfileVertex` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.ProfileVertex` |
| **Base Type** | `Topomatic.Pipes.LightweightLine.LightweightLineVertex` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.LightweightLine.LightweightLineVertex`
        - `Topomatic.Pipes.LightweightLine.ProfileVertex`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, Vector2D position)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `State<T where LightweightLineVertex, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, class, LightweightLineVertex>` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLine`1+State` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Pipes.LightweightLine.LightweightLine`1+State`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CurvesSects` | `State<T>` | Yes | `CurvesSects` | `` |
| `LessThanTwoElements` | `State<T>` | Yes | `LessThanTwoElements` | `` |
| `PositionEquals` | `State<T>` | Yes | `PositionEquals` | `` |
| `RadiusMustBeEmpty` | `State<T>` | Yes | `RadiusMustBeEmpty` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LessThanTwoElements` | `?` |
| `RadiusMustBeEmpty` | `?` |
| `PositionEquals` | `?` |
| `CurvesSects` | `?` |

**Underlying Type**: `System.Int32`

### `VertexInfo<T where LightweightLineVertex, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgSerializable, class, LightweightLineVertex>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LightweightLine.LightweightLine`1+VertexInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.LightweightLine.LightweightLine`1+VertexInfo`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Beta` | `Double` | No | `` | `` |
| `CurveEnd` | `Double` | No | `` | `` |
| `CurveStart` | `Double` | No | `` | `` |
| `Tangent` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.LineFolder`

### `InternalAddLineArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.InternalAddLineArgs` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CreatedLines` | `List<PnLine>` | No | `` | `` |
| `CreatedNodes` | `List<PnNode>` | No | `` | `` |
| `NodePositions` | `List<Vector3D>` | No | `` | `` |
| `SelectedLineTypeGuid` | `Guid` | No | `` | `` |
| `SelectedNodeGuid` | `Guid` | No | `` | `` |
| `SelectedSegmentGuid` | `Guid` | No | `` | `` |

### `PnLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLine` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Visualization.IStgContextSerializable, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Pipes.ILinetypeContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.PnLine`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllSegments` | `IEnumerable<PnSegment>` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Data` | `PnLineData` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `GeologyAlignmentId` | `String` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Kilometers` | `IKilometers` | `get` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `LineStationing` | `PnLineStationingContainer` | `get` | No | `` |
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Nodes` | `List<PnNode>` | `get` | No | `` |
| `PlanBounds` | `BoundingBox2D` | `get` | No | `` |
| `PlanCompoundLine` | `CompoundLine` | `get` | No | `` |
| `PlanLength` | `Double` | `get` | No | `` |
| `Segments` | `IList<PnSegment>` | `get` | No | `` |
| `SegmentsCount` | `Int32` | `get` | No | `` |
| `ShaftIds` | `IEnumerable<UInt32>` | `get` | No | `` |
| `SortOrder` | `Int32` | `get/set` | No | `` |
| `Stationing` | `IStationing` | `get` | No | `` |
| `SurfacesParams` | `SurfacesLineParams` | `get` | No | `` |
| `TextParams` | `PnLineTextParams` | `get` | No | `` |
| `UserEntities` | `IList<UserProfileEntity>` | `get` | No | `` |

#### Instance Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeNode` | `Void` | `UInt32 oldShaftId, UInt32 newShaftId` | `` |
| `ContainsSegmentWithId` | `Boolean` | `UInt32 id` | `` |
| `GetNodeStation` | `Double` | `Int32 nodeIndex` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetProfileShaftTextOffset` | `Vector2D` | `Int32 index, UInt32 id` | `` |
| `GetSegmentById` | `PnSegment` | `UInt32 id` | `` |
| `GetSegmentIdWithIncrement` | `UInt32` | `` | `` |
| `InsertNode` | `Void` | `Int32 index, UInt32 id` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, UInt32 shaftIdOffset, ISerializationContext context` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `RefreshThroughPlanAtNode` | `Void` | `Int32 nodeIndex` | `` |
| `RefreshThroughPlanAtVertex` | `Void` | `Int32 pipeIndex, Int32 vertexIndex` | `` |
| `RefreshThroughProfilesAtPipe` | `Void` | `Int32 fixedPipeIndex` | `` |
| `RemoveFirstPipe` | `Void` | `` | `` |
| `RemoveLastPipe` | `Void` | `Boolean removeNodes` | `` |
| `ReverseLine` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetNewData` | `Void` | `PnLineData data` | `` |
| `SetProfileShaftTextOffset` | `Void` | `Int32 index, UInt32 id, Vector2D offset` | `` |
| `ToString` | `String` | `` | `` |
| `TrySetThroughProfileNode` | `Void` | `Int32 nodeIndex, Boolean fixedLeft` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D0` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D1` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Project` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Tesselate` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.get_Length` |
| `IStationingRepository` | `get_Stationing` |
| `IKilometersRepository` | `get_Kilometers` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ILinearObject` | `GetPolyline` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `ILinetypeContainer` | `get_LinetypeContainer` |

### `PnLineKilometers` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLineKilometers` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.Stationing.IKilometers` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine parent)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromKm` | `Boolean` | `Int32 number, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToKm` | `Boolean` | `Double u, ref Int32 number, ref Double plus, ref Boolean forward` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IKilometers` | `ToKm` |
| `IKilometers` | `FromKm` |
| `IKilometers` | `FromString` |
| `IKilometers` | `IsWhole` |
| `IKilometers` | `IsChop` |

### `PnLines` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLines` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.LineFolder.PnLine, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.PnLines`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `PnLine` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `PnLine` | `List<PnSegment> pipes, ImElement element` | `` |
| `Add` | `PnLine` | `PnSegment segment` | `` |
| `Add` | `PnLine` | `` | `` |
| `Contains` | `Boolean` | `UInt32 index` | `` |
| `GetEnumerator` | `IEnumerator<PnLine>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `PnLineStationing` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLineStationing` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.Stationing.IStationing` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WholeLength` | `Double` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillWholes` | `Boolean` | `IList<Double> values` | `` |
| `FromPk` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToPk` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |
| `ToPkDecimal` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationing` | `ToPk` |
| `IStationing` | `ToPkDecimal` |
| `IStationing` | `FromPk` |
| `IStationing` | `FromString` |
| `IStationing` | `get_WholeLength` |
| `IStationing` | `FillWholes` |
| `IStationing` | `IsWhole` |
| `IStationing` | `IsChop` |

### `PnLineStationingContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLineStationingContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.PnLineStationingContainer`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Kilometers` | `PnLineKilometers` | `get` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Stationing` | `PnLineStationing` | `get` | No | `` |
| `StationingPrefix` | `String` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillPkPlus` | `Void` | `Double station, ref String pk, ref String plus` | `` |
| `GetPkString` | `String` | `Double station` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PnLineTextParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.PnLineTextParams` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.PnLineTextParams`

#### Constructors (1)

- `.ctor(PnLine line)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `PnLine` | `get` | No | `` |
| `NetworkTypeDesignation` | `String` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.LineFolder.DataTypes`

### `PnLineData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.DataTypes.PnLineData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.DataTypes.PnLineData`

#### Constructors (1)

- `.ctor(PnLine parentLine)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `PnLine` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `PnLineData other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `RailContactNetworkLineData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineData` |
| **Base Type** | `Topomatic.Pipes.LineFolder.DataTypes.PnLineData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.DataTypes.PnLineData`
          - `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineData`

#### Constructors (1)

- `.ctor(PnLine parentLine)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoUpdateOnChanged` | `Boolean` | `get/set` | No | `` |
| `ConstructionData` | `RcnConstructionData` | `get` | No | `` |
| `ParamsData` | `RailContactNetworkLineParamsData` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PatternSeparators` | `Char[]` | Yes | `` | `` |

#### Nested Types (1)

- `RcnConstructionData` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `RailContactNetworkLineParamsData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineParamsData` |
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
      - `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineParamsData`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasementCutoffElev` | `Double` | `get/set` | No | `` |
| `CreateZigzag` | `Int32` | `get/set` | No | `` |
| `CurvedSegmentPattern` | `String` | `get/set` | No | `` |
| `HideEndZigzag` | `Boolean` | `get/set` | No | `` |
| `NextNameOverStep` | `Boolean` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PlanAlignmentId` | `String` | `get/set` | No | `` |
| `ProfileAlignmentId` | `String` | `get/set` | No | `` |
| `ReverseNames` | `Boolean` | `get/set` | No | `` |
| `StartNodeName` | `String` | `get/set` | No | `` |
| `StationingAlignmentId` | `String` | `get/set` | No | `` |
| `StraightSegmentPattern` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `RailContactNetworkLineParamsData other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RcnConstructionData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineData+RcnConstructionData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.LineFolder.DataTypes.RailContactNetworkLineData+RcnConstructionData`

#### Constructors (1)

- `.ctor(RailContactNetworkLineData rcnlData)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LineType` | `ImElement` | `get/set` | No | `` |
| `NodeConstructionAlbum` | `String` | `get/set` | No | `` |
| `NodeInsideConnection` | `String` | `get/set` | No | `` |
| `NodeOutsideConnection` | `String` | `get/set` | No | `` |
| `NodeType` | `ImElement` | `get/set` | No | `` |
| `SegmentType` | `ImElement` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.NetworkFolder`

### `ItemFilterSet` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NetworkFolder.ItemFilterSet` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NetworkFolder.ItemFilterSet`

#### Constructors (1)

- `.ctor(Boolean defaultState)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Boolean` | `get/set` | No | `` |

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

### `SheetItemsFilterDictionary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NetworkFolder.SheetItemsFilterDictionary` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NetworkFolder.SheetItemsFilterDictionary`

#### Constructors (1)

- `.ctor(PipeNetwork network, Boolean defaultItemState)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetItemSet` | `ItemFilterSet` | `String key` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetItemSet` | `Void` | `String setKey, ItemFilterSet set` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.NodeFolder`

### `ElevationContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.ElevationContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.ElevationContainer`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BySegmentCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `` |
| `BySegmentSelector` | `NodeBySegmentSelector` | `get/set` | No | `` |
| `CachedBasisVerticalOffset` | `Double` | `get/set` | No | `` |
| `CachedBotElevation` | `Double` | `get/set` | No | `` |
| `FixType` | `SimpleBaseElevationType` | `get` | No | `` |
| `StoredElevation` | `Double` | `get` | No | `` |
| `StoredSurplus` | `Double` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `ElevationContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetBasisVerticalOffset` | `Void` | `Double value` | `` |
| `SetElevation` | `Void` | `Double value, Double surfaceElevation` | `` |
| `SetFixType` | `Void` | `SimpleBaseElevationType value, Double botElevation, Double surplus` | `` |
| `SetFixType` | `Void` | `SimpleBaseElevationType value` | `` |
| `SetSurplus` | `Void` | `Double value, Double surfaceElevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `NodeBlocks` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.NodeBlocks` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.NodeBlocks`

#### Constructors (1)

- `.ctor(PnNode node)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EditedLabelsInSchemePlanSign` | `TransactableDictionary<Int32 EditedLabel>` | `get` | No | `` |
| `EditedLabelsInSign` | `TransactableDictionary<Int32 EditedLabel>` | `get` | No | `` |
| `EditedLabelsInSignLabel` | `TransactableDictionary<Int32 EditedLabel>` | `get` | No | `` |
| `EditedLabelsInSignLabelForScheme` | `TransactableDictionary<Int32 EditedLabel>` | `get` | No | `` |
| `HideLeader` | `Boolean` | `get/set` | No | `` |
| `PlanRotation` | `Double` | `get/set` | No | `` |
| `PlanSignLabelName` | `String` | `get/set` | No | `` |
| `PlanSignName` | `String` | `get/set` | No | `` |
| `ProfileBotSignName` | `String` | `get/set` | No | `` |
| `SchemeHideOnPlan` | `Boolean` | `get/set` | No | `` |
| `SchemePlanRotation` | `Double` | `get/set` | No | `` |
| `SchemePlanSignName` | `String` | `get/set` | No | `` |
| `SimplifiedPlanSignName` | `String` | `get/set` | No | `` |

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

### `NodeConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.NodeConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (34)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ElevationFixTypeTag` | `String` | Yes | `"NodeElevationFixType"` | `` |
| `NodeDrawPlanAngleOuterTag` | `String` | Yes | `"<%NodePlanAngleOuter%>"` | `` |
| `NodeDrawPlanAngleTag` | `String` | Yes | `"<%NodePlanAngle%>"` | `` |
| `NodeDrawProfileDepthExtendedTag` | `String` | Yes | `"<%NodeDepthExtended%>"` | `` |
| `NodeDrawProfileDepthTag` | `String` | Yes | `"<%NodeDepth%>"` | `` |
| `NodeDrawProfileNameTemplateMarkTag` | `String` | Yes | `"<%NodeNameTemplateMark%>"` | `` |
| `NodeDrawSimplePlanAngleOuterTag` | `String` | Yes | `"<%NodeAngleOuter%>"` | `` |
| `NodeDrawSimplePlanAngleTag` | `String` | Yes | `"<%NodeAngle%>"` | `` |
| `NodeRailCableNetworkSignLinesTag` | `String` | Yes | `"<%RcnSignLinesTag%>"` | `` |
| `PipeNetworkAlignmentCrossIdentifier` | `String` | Yes | `"PipeNetworkAlignmentCross"` | `` |
| `PipeNetworkElementIdentifier` | `String` | Yes | `"PipeNetworkElement"` | `` |
| `PipeNetworkMassiveConnectionIdentifier` | `String` | Yes | `"PipeNetworkMassiveConnection"` | `` |
| `PipeNetworkNodePlanSignLabelTag` | `String` | Yes | `"NodePlanSignLabel"` | `` |
| `PipeNetworkNodePlanSignTag` | `String` | Yes | `"NodePlanSign"` | `` |
| `PipeNetworkNodeProfileBotSignTag` | `String` | Yes | `"NodeProfileBotSign"` | `` |
| `PipeNetworkNodeProfileSignTag` | `String` | Yes | `"NodeProfileSign"` | `` |
| `PipeNetworkNodeReferenceIdentifier` | `String` | Yes | `"PipeNetworkNodeReference"` | `` |
| `PipeNetworkNodeSchemePlanSignTag` | `String` | Yes | `"NodeSchemePlanSign"` | `` |
| `PipeNetworkNodeSimplifiedPlanSignTag` | `String` | Yes | `"NodeSimplifiedPlanSign"` | `` |
| `PipeNetworkPipeDamperIdentifier` | `String` | Yes | `"PipeDamper"` | `` |
| `PipeNetworkPipeHydrantIdentifier` | `String` | Yes | `"PipeHydrant"` | `` |
| `PipeNetworkPoleIdentifier` | `String` | Yes | `"PipeNetworkPole"` | `` |
| `PipeNetworkRailContactWireSupportIdentifier` | `String` | Yes | `"PipeNetworkRailContactWireSupport"` | `` |
| `PipeNetworkShaftCircleShaft` | `String` | Yes | `"CircleShaft"` | `` |
| `PipeNetworkShaftCommLinkShaft` | `String` | Yes | `"CommLinkShaft"` | `` |
| `PipeNetworkShaftIdentifier` | `String` | Yes | `"PipeNetworkShaft"` | `` |
| `PipeNetworkStreetlightIdentifier` | `String` | Yes | `"PipeNetworkStreetlight"` | `` |
| `PipeNetworkThroughParamsNodeTag` | `String` | Yes | `"ThroughParamsNode"` | `` |
| `PipeNetworkThroughPlanNodeTag` | `String` | Yes | `"ThroughPlanNode"` | `` |
| `PipeNetworkThroughProfileNodeTag` | `String` | Yes | `"ThroughProfileNode"` | `` |
| `SchemeElevationTag` | `String` | Yes | `` | `` |
| `SchemeElevationTemplate` | `String` | Yes | `` | `` |
| `SchemePlanSignNameDefault` | `String` | Yes | `` | `` |
| `UndefinedBlock` | `String` | Yes | `` | `` |

### `NodeExtensions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.NodeExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `MoveConnectedSegmentByNode` | `Void` | `PnSegment segment, Boolean atStart` | `` |
| `MoveConnectedSegmentByNode` | `Void` | `PnSegment segment, Boolean atStart, PnNode node` | `` |
| `MoveConnectedSegments` | `Void` | `PnNode node` | `` |
| `MoveConnectedSegments` | `Void` | `PnNode node, PnNode positionNode` | `` |

### `NodeTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.NodeTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateNewName` | `String` | `String oldName` | `` |
| `GetDefaultLeaderOffset` | `Vector2D` | `Double angle` | `` |
| `GetRotatedLabels` | `List<KeyValuePair<Int32 EditedLabel>>` | `DwgBlock block, Double angle` | `` |

### `PnNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.PnNode` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.INamed, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.PnInterfaces.IDeterminated, Topomatic.Pipes.PnInterfaces.IDeterminationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.PnNode`

#### Constructors (1)

- `.ctor(Object parent, UInt32 id)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLine` | `PnLine` | `get` | No | `` |
| `Construction` | `NodeConstruction` | `get` | No | `` |
| `Data` | `NodeData` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `Documents` | `String` | `get/set` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `Elevation` | `ElevationContainer` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `NodeBlocks` | `NodeBlocks` | `get` | No | `` |
| `NodeIdentifierType` | `String` | `get` | No | `` |
| `NodeSubTypeName` | `String` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |
| `ThroughProps` | `ThroughPropsResolver` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INamed` | `get_Name` |
| `INamed` | `set_Name` |
| `IUintId` | `get_Id` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `IDeterminated` | `get_DeterminationTypes` |
| `IDeterminationContainer` | `get_DeterminationType` |
| `IDeterminationContainer` | `set_DeterminationType` |

### `PnNodes` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.PnNodes` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.NodeFolder.PnNode, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.PnNodes`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `CurrentId` | `UInt32` | `get` | No | `` |
| `Item` | `PnNode` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `PnNode` | `Nullable<UInt32> id, Vector2D position, ImElement element` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `FindNodes` | `Void` | `BoundingBox2D box, Predicate<UInt32> match, ref List<UInt32> nodes` | `` |
| `GetEnumerator` | `IEnumerator<PnNode>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ThroughPropsResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.ThroughPropsResolver` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.ThroughPropsResolver`

#### Constructors (1)

- `.ctor(PnNode node)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsParamsThroughNode` | `Boolean` | `get` | No | `` |
| `NodePlanThroughType` | `PlanThroughType` | `get` | No | `` |
| `NodeProfileThroughType` | `ProfileThroughType` | `get` | No | `` |
| `ParamsThroughNode` | `NodeParamsThroughTypeEnum` | `get/set` | No | `` |
| `PlanThroughNode` | `NodePlanThroughTypeEnum` | `get/set` | No | `` |
| `ProfileThroughNode` | `NodeProfileThroughTypeEnum` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.NodeFolder.Construction`

### `ConstructionChunk` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionChunk` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NodeFolder.Construction.ConstructionChunk`

#### Constructors (1)

- `.ctor(ImElement element)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comment` | `String` | `get` | No | `` |
| `Document` | `String` | `get` | No | `` |
| `ElementHeight` | `Double` | `get` | No | `` |
| `Height` | `Int32` | `get` | No | `` |
| `InnerDiameter` | `Int32` | `get` | No | `` |
| `Length` | `Int32` | `get` | No | `` |
| `Mark` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `OuterDiameter` | `Int32` | `get` | No | `` |
| `ProductCode` | `String` | `get` | No | `` |
| `TopPosition` | `Vector3D` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |
| `Weight` | `Double` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConnectionPrefix` | `String` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `DeterminationType` | `DeterminationType` | No | `` | `` |
| `Element` | `ImElement` | No | `` | `` |
| `FilterPropertyTag` | `String` | No | `` | `` |
| `FilterPropertyValue` | `String` | No | `` | `` |
| `GenerationPriority` | `Int32` | No | `` | `` |
| `GroupName` | `String` | No | `` | `` |
| `HeightTag` | `String` | Yes | `"Height"` | `` |
| `Position` | `Vector3D` | No | `` | `` |
| `Rotation` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionChunks` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionChunks` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.NodeFolder.Construction.ConstructionChunk, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.Construction.ConstructionChunks`

#### Constructors (1)

- `.ctor(NodeConstruction construction)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ConstructionChunk` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionChunk>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetChunks` | `Void` | `IList<ConstructionChunk> chunks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionComponent` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionComponent` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NodeFolder.Construction.ConstructionComponent`

#### Constructors (1)

- `.ctor(ModelComponent modelComponent)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Count` | `Double` | No | `` | `` |
| `CountMeasure` | `ComponentCountType` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `Element` | `ImElement` | No | `` | `` |
| `FilterPropertyTag` | `String` | No | `` | `` |
| `FilterPropertyValue` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionComponents` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionComponents` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.NodeFolder.Construction.ConstructionComponent, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.Construction.ConstructionComponents`

#### Constructors (1)

- `.ctor(NodeConstruction construction)`

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionComponent>` | `` | `` |
| `GetModelComponentsString` | `String` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetComponents` | `Void` | `String componentsString` | `` |
| `SetComponents` | `Void` | `IEnumerable<ConstructionComponent> components` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionConnection` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionConnection` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NodeFolder.Construction.ConstructionConnection`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Color` | `CadColor` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Vertex` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `Clone` |

### `ConstructionConnections` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionConnections` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.Construction.ConstructionConnections`

#### Constructors (1)

- `.ctor(NodeConstruction construction)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `ConstructionConnection` | `get` | No | `` |
| `ParentNode` | `PnNode` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearCustomConnections` | `Void` | `` | `` |
| `GetAllConnections` | `ConstructionConnection[]` | `` | `` |
| `GetCustomConnections` | `IEnumerable<ConstructionConnection>` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetCustomConnections` | `Void` | `IEnumerable<ConstructionConnection> connections` | `` |
| `UpdateAllConnectedPipes` | `Void` | `Double botElevation` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetConnectionsFromModels` | `IEnumerable<ConstructionConnection>` | `IEnumerable<ConstructionChunk> items` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConstructionGroup` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionGroup` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.NodeFolder.Construction.ConstructionGroup`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BaseGroupName` | `String` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `GroupName` | `String` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ConstructionGroups` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.ConstructionGroups` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.NodeFolder.Construction.ConstructionGroup, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.Construction.ConstructionGroups`

#### Constructors (1)

- `.ctor(NodeConstruction construction)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionGroup>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetGroups` | `Void` | `IList<ConstructionGroup> attachments` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `NodeConstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.Construction.NodeConstruction` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.Construction.NodeConstruction`

#### Constructors (1)

- `.ctor(PnNode node)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Chunks` | `ConstructionChunks` | `get` | No | `` |
| `Components` | `ConstructionComponents` | `get` | No | `` |
| `Connections` | `ConstructionConnections` | `get` | No | `` |
| `ConstructionParams` | `CommonConstructionParams` | `get` | No | `` |
| `Groups` | `ConstructionGroups` | `get` | No | `` |
| `ModelNotEmpty` | `Boolean` | `get` | No | `` |
| `Node` | `PnNode` | `get` | No | `` |
| `TemplateDescription` | `String` | `get` | No | `` |
| `TemplateMark` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAllChunksPositioned` | `IEnumerable<ConstructionChunk>` | `` | `` |
| `GetCompoundElement` | `ImElement` | `CadColor color` | `` |
| `GetHeight` | `Double` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCompoundElement` | `ImElement` | `CadColor color, IEnumerable<ConstructionChunk> chunks, Compound3DElement compound` | `` |
| `GetPositionedChunks` | `IEnumerable<ConstructionChunk>` | `IEnumerable<ConstructionGroup> groups, IEnumerable<ConstructionChunk> chunks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

---
## Namespace: `Topomatic.Pipes.NodeFolder.DataTypes`

### `AlignmentCrossNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.AlignmentCrossNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.NodeFolder.DataTypes.ILinkedPositionData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.AlignmentCrossNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossedAlingmentId` | `String` | `get/set` | No | `` |
| `LinkedPosition` | `Vector2D` | `get` | No | `` |
| `PositionIsLinked` | `Boolean` | `get` | No | `` |
| `ReferenceName` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `UpdateReference` | `Void` | `Alignment alg, String referenceName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ILinkedPositionData` | `get_PositionIsLinked` |
| `ILinkedPositionData` | `get_LinkedPosition` |

### `IBasisSizeOffset` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.IBasisSizeOffset` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisSizeOffset` | `Double` | `get` | No | `` |

### `ILinkedElevationData` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.ILinkedElevationData` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElevationIsLinked` | `Boolean` | `get` | No | `` |
| `LinkedElevation` | `Double` | `get` | No | `` |

### `ILinkedPositionData` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.ILinkedPositionData` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LinkedPosition` | `Vector2D` | `get` | No | `` |
| `PositionIsLinked` | `Boolean` | `get` | No | `` |

### `IncutNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.IncutNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.IncutNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Diameter` | `Double` | `get/set` | No | `` |
| `LeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `ProfileDrawType` | `IncutProfileDrawType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DrawTypeTag` | `String` | Yes | `"IncutDataDrawType"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ManholePosition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.ManholePosition` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MassiveConnectionData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.MassiveConnectionData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.NodeFolder.DataTypes.ILinkedPositionData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.MassiveConnectionData`

#### Constructors (1)

- `.ctor(PnNode parentNode, Vector2D storedPosition)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionName` | `String` | `get` | No | `` |
| `LinkCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `` |
| `LinkedPosition` | `Vector2D` | `get` | No | `` |
| `LinkElevation` | `Boolean` | `get/set` | No | `` |
| `MassiveConnection` | `String` | `get/set` | No | `` |
| `MassiveId` | `UInt32` | `get/set` | No | `` |
| `MassiveObject` | `MassiveObject` | `get` | No | `` |
| `PositionIsLinked` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetElevation` | `Boolean` | `ref Double elevation` | `` |
| `TryGetPosition` | `Boolean` | `ref Vector2D position` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ILinkedPositionData` | `get_PositionIsLinked` |
| `ILinkedPositionData` | `get_LinkedPosition` |

### `NodeData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Node` | `PnNode` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `NodeData otherData` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ReferenceNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.ReferenceNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.NodeFolder.DataTypes.ILinkedPositionData, Topomatic.Pipes.NodeFolder.DataTypes.ILinkedElevationData` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.ReferenceNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElevationIsLinked` | `Boolean` | `get` | No | `` |
| `LinkedElevation` | `Double` | `get` | No | `` |
| `LinkedPosition` | `Vector2D` | `get` | No | `` |
| `NodeId` | `UInt32` | `get/set` | No | `` |
| `PositionIsLinked` | `Boolean` | `get` | No | `` |
| `ReferenceModelUid` | `String` | `get/set` | No | `` |
| `ReferenceName` | `String` | `get/set` | No | `` |
| `UseReferenceElevation` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `UpdateReference` | `Void` | `PnNode node, String referenceName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ILinkedPositionData` | `get_PositionIsLinked` |
| `ILinkedPositionData` | `get_LinkedPosition` |
| `ILinkedElevationData` | `get_ElevationIsLinked` |
| `ILinkedElevationData` | `get_LinkedElevation` |

### `SimpleNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.SimpleNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.SimpleNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

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
## Namespace: `Topomatic.Pipes.NodeFolder.DataTypes.RailContactWireSupport`

### `RailContactWireSupportNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.RailContactWireSupport.RailContactWireSupportNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IStationingAlignmentContainer, Topomatic.Pipes.NodeFolder.DataTypes.IBasisSizeOffset, Topomatic.Pipes.PnInterfaces.IProfileAlignmentContainer, Topomatic.Pipes.PnInterfaces.IPlanAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.RailContactWireSupport.RailContactWireSupportNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisSizeOffset` | `Double` | `get` | No | `` |
| `DiameterMM` | `Double` | `get` | No | `` |
| `FoundationHalfInMeters` | `Double` | `get` | No | `` |
| `FoundationSizeMM` | `Double` | `get` | No | `` |
| `HeightMM` | `Double` | `get` | No | `` |
| `IsFixed` | `Boolean` | `get/set` | No | `` |
| `LengthMM` | `Double` | `get` | No | `` |
| `Material` | `String` | `get` | No | `` |
| `PlanAlignmentId` | `String` | `get/set` | No | `` |
| `Profile` | `SectionProfileType` | `get` | No | `` |
| `ProfileAlignmentId` | `String` | `get/set` | No | `` |
| `SizeOffset` | `Double` | `get/set` | No | `` |
| `StationingAlignmentId` | `String` | `get/set` | No | `` |
| `SupportType` | `String` | `get` | No | `` |
| `WidthInProfileMeters` | `Double` | `get` | No | `` |
| `WidthMM` | `Double` | `get` | No | `` |
| `Zigzag` | `Int32` | `get/set` | No | `` |
| `ZigzagOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `NodeData otherData` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DiameterTag` | `String` | Yes | `"Diameter"` | `` |
| `HeightTag` | `String` | Yes | `"Height"` | `` |
| `LengthTag` | `String` | Yes | `"Length"` | `` |
| `MaterialTag` | `String` | Yes | `"Material"` | `` |
| `SupportTypeTag` | `String` | Yes | `"Type"` | `` |
| `WidthTag` | `String` | Yes | `"Width"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IStationingAlignmentContainer` | `get_StationingAlignmentId` |
| `IBasisSizeOffset` | `get_BasisSizeOffset` |
| `IProfileAlignmentContainer` | `get_ProfileAlignmentId` |
| `IPlanAlignmentContainer` | `get_PlanAlignmentId` |

---
## Namespace: `Topomatic.Pipes.NodeFolder.DataTypes.Shaft`

### `EShaftType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftNodeData+EShaftType` |
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
      - `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftNodeData+EShaftType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CircleShaft` | `EShaftType` | Yes | `CircleShaft` | `` |
| `CommLinkShaft` | `EShaftType` | Yes | `CommLinkShaft` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CircleShaft` | `0` |
| `CommLinkShaft` | `1` |

**Underlying Type**: `System.Int32`

### `ShaftNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalDepth` | `Double` | `get` | No | `` |
| `AdditionalPipeSurplus` | `Double` | `get` | No | `` |
| `AdditionalTopSurfaceSurplus` | `Double` | `get` | No | `` |
| `BotElevation` | `Double` | `get` | No | `` |
| `BotElevationFixType` | `ShaftBotElevationType` | `get/set` | No | `` |
| `Diameter` | `Double` | `get` | No | `` |
| `KeepSurfaceSurplus` | `Boolean` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `LibraryDepth` | `Double` | `get` | No | `` |
| `LibraryPipeSurplus` | `Double` | `get` | No | `` |
| `LibrarySurfaceSurplus` | `Double` | `get` | No | `` |
| `Profile` | `SectionProfileType` | `get` | No | `` |
| `ShaftType` | `EShaftType` | `get` | No | `` |
| `StoredBotElevation` | `Double` | `get` | No | `` |
| `StoredTopElevation` | `Double` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |
| `WidthInProfile` | `Double` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `NodeData otherData` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetBotElevation` | `Void` | `Double topElevation, Double botElevation, Double segmentElevation` | `` |
| `SetBotElevationFixType` | `Void` | `ShaftBotElevationType newFixType, Double topElevation, Double botElevation, Double minSegmentElevation` | `` |
| `SetKeepSurfaceSurplus` | `Void` | `Boolean value, Double surfaceSurplus, Double topElevation` | `` |
| `SetTopElevation` | `Void` | `Double topElevation, Double surfaceElevation` | `` |
| `SetTopElevationFixType` | `Void` | `Boolean newFixType, Double topElevation, Double surfaceElevation` | `` |

#### Fields (13)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultBotFixDepthTag` | `String` | Yes | `"BotFixPointDepth"` | `` |
| `DefaultBotFixElevationTag` | `String` | Yes | `"BotFixPointElevation"` | `` |
| `DefaultBotFixPipeSurplusTag` | `String` | Yes | `"BotFixPointPipeSurplus"` | `` |
| `DefaultBotFixSectionsTag` | `String` | Yes | `"BotFixPointSections"` | `` |
| `DefaultBotFixTag` | `String` | Yes | `"BotFixPoint"` | `` |
| `DiameterTag` | `String` | Yes | `"Diameter"` | `` |
| `LengthTag` | `String` | Yes | `"Length"` | `` |
| `ManholeGroupName` | `String` | Yes | `"Горловина"` | `` |
| `PipeSurplusTag` | `String` | Yes | `"PipeSurplus"` | `` |
| `ShaftDepthTag` | `String` | Yes | `"ShaftDepth"` | `` |
| `SurfaceSurplusTag` | `String` | Yes | `"SurfaceSurplus"` | `` |
| `WidthTag` | `String` | Yes | `"Width"` | `` |
| `WorkChamberGroupName` | `String` | Yes | `"Рабочая камера"` | `` |

#### Nested Types (1)

- `EShaftType` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `
` | `get_BotElevation` |

### `ShaftSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftSection` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftSection`

#### Constructors (1)

- `.ctor(Object parent, ImElement element)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comment` | `String` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Document` | `String` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `InnerDiameter` | `Int32` | `get` | No | `` |
| `Length` | `Int32` | `get` | No | `` |
| `Mark` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `OuterDiameter` | `Int32` | `get` | No | `` |
| `Placement` | `ImElementPlacement` | `get` | No | `` |
| `PositionOffset` | `Vector3D` | `get/set` | No | `` |
| `ProductCode` | `String` | `get` | No | `` |
| `RotationAngle` | `Double` | `get/set` | No | `` |
| `Volume` | `Double` | `get` | No | `` |
| `Weight` | `Double` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ShaftSection` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSectionType` | `Int32` | `ImElement item` | `` |
| `ItemHasBottom` | `Boolean` | `ImElement item` | `` |
| `ItemIsBottomOrWall` | `Boolean` | `ImElement item` | `` |
| `ItemIsBottomPlate` | `Boolean` | `ImElement item` | `` |
| `ItemIsChangingPlate` | `Boolean` | `ImElement item` | `` |
| `ItemIsHatch` | `Boolean` | `ImElement item` | `` |
| `ItemIsRoadPlate` | `Boolean` | `ImElement item` | `` |
| `ItemIsSupportRing` | `Boolean` | `ImElement item` | `` |
| `ItemIsWallOrWork` | `Boolean` | `ImElement item` | `` |
| `ItemIsWorkChamber` | `Boolean` | `ImElement item` | `` |
| `LoadSectionFromOldStg` | `ImElement` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HeightTag` | `String` | Yes | `"Height"` | `` |
| `ShaftSectionCategory` | `String` | Yes | `"PipeNetworkShaftSection"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ShaftSectionContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftSectionContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.Shaft.ShaftSectionContainer`

#### Constructors (1)

- `.ctor(NodeData parent)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseSections` | `IList<ShaftSection>` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `ManholePositions` | `IList<ManholePosition>` | `get` | No | `` |
| `ManholeSections` | `IList<ShaftSection>` | `get` | No | `` |
| `SectionsAutoCreated` | `Boolean` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.NodeFolder.DataTypes.Streetlight`

### `StreetlightNodeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.DataTypes.Streetlight.StreetlightNodeData` |
| **Base Type** | `Topomatic.Pipes.NodeFolder.DataTypes.NodeData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.NodeFolder.DataTypes.NodeData`
          - `Topomatic.Pipes.NodeFolder.DataTypes.Streetlight.StreetlightNodeData`

#### Constructors (1)

- `.ctor(PnNode parentNode)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Diameter` | `Double` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Profile` | `SectionProfileType` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |
| `WidthInProfile` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyPropertiesFrom` | `Void` | `NodeData otherData` | `` |
| `LoadFromOldStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DiameterTag` | `String` | Yes | `"Diameter"` | `` |
| `HeightTag` | `String` | Yes | `"Height"` | `` |
| `LengthTag` | `String` | Yes | `"Length"` | `` |
| `WidthTag` | `String` | Yes | `"Width"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

---
## Namespace: `Topomatic.Pipes.NodeFolder.RenameTool`

### `NodeRenameRule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.RenameTool.NodeRenameRule` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(StgNode node)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ItemSet` | `ItemFilterSet` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetNewName` | `String` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Checked` | `Boolean` | No | `` | `` |
| `FilterDictionary` | `SheetItemsFilterDictionary` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Number` | `Int32` | No | `` | `` |
| `Prefix` | `String` | No | `` | `` |
| `Suffix` | `String` | No | `` | `` |

### `NodeRenameRuleCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.NodeFolder.RenameTool.NodeRenameRuleCollection` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String folderPath)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToFolder` | `Void` | `String folderPath` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Rules` | `List<NodeRenameRule>` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.PnInterfaces`

### `IColoredProfile` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IColoredProfile` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProfileColor` | `CadColor` | `get/set` | No | `` |

### `IDeterminated` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IDeterminated` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |

### `IDeterminationContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IDeterminationContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |

### `IFilteredElementContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IFilteredElementContainer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Pipes.PnInterfaces.IImElementContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FilterPropertyTag` | `String` | `get/set` | No | `` |
| `FilterPropertyValue` | `String` | `get/set` | No | `` |

### `IImElementContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IImElementContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get/set` | No | `` |

### `INamed` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.INamed` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |

### `IOrdered` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IOrdered` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Order` | `UInt32` | `get` | No | `` |

### `IPlanAlignmentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IPlanAlignmentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PlanAlignmentId` | `String` | `get` | No | `` |

### `IPlanObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IPlanObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |

### `IProfileAlignmentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IProfileAlignmentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProfileAlignmentId` | `String` | `get` | No | `` |

### `IProfileCrossingObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IProfileCrossingObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowOnProfileCrossing` | `Boolean` | `get/set` | No | `` |

### `IProfileObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IProfileObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |

### `ISegmentAxisContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.ISegmentAxisContainer` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.SegmentFolder.Construction.ConstructionAxis, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `ConstructionAxis` | `` | `` |
| `SetAxisList` | `Void` | `IEnumerable<ConstructionAxis> list` | `` |

### `IStationingAlignmentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IStationingAlignmentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StationingAlignmentId` | `String` | `get` | No | `` |

### `IStringId` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IStringId` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |

### `IUintId` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.PnInterfaces.IUintId` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get` | No | `` |

---
## Namespace: `Topomatic.Pipes.SegmentFolder`

### `DisplaySettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DisplaySettings` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DisplaySettings`

#### Constructors (1)

- `.ctor(Object owner, Action onChanged)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowOnCrossing` | `Boolean` | `get/set` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |

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

### `FakeSegmentElementContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.FakeSegmentElementContainer` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.SegmentElementContainer` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentElementContainer`
          - `Topomatic.Pipes.SegmentFolder.FakeSegmentElementContainer`

#### Constructors (1)

- `.ctor(ImElement element)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetElevation` | `Boolean` | `PipeCharacterPoint characterPoint, Double station, ref Double startElevation, ref Double endElevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |

### `IProfileUserDefinedValuesContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.IProfileUserDefinedValuesContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UserHeight` | `Double` | `get` | No | `` |
| `UserInnerDiameter` | `Double` | `get` | No | `` |
| `UserOuterDiameter` | `Double` | `get` | No | `` |
| `UserThickness` | `Double` | `get` | No | `` |
| `UserWidth` | `Double` | `get` | No | `` |
| `UserWireDiameter` | `Double` | `get` | No | `` |

### `PnSegment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.PnSegment` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.SegmentElementContainer` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.ILinetypeContainer, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.Pipes.PnInterfaces.IDeterminated` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentElementContainer`
          - `Topomatic.Pipes.SegmentFolder.PnSegment`

#### Constructors (1)

- `.ctor(PnLine parentLine, UInt32 id, UInt32 startShaftId, UInt32 endShaftId)`

#### Properties (56)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardGrade` | `Double` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Components` | `String` | `get/set` | No | `` |
| `Construction` | `SegmentConstructionContainer` | `get` | No | `` |
| `Data` | `SegmentData` | `get` | No | `` |
| `DeterminationLeaderParams` | `StoredLeaderParams` | `get` | No | `` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `Documents` | `String` | `get/set` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `EndNode` | `PnNode` | `get` | No | `` |
| `EndNodeConnection` | `SegmentNodeConnection` | `get` | No | `` |
| `EndNodeId` | `UInt32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `Grade` | `Double` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `InnerRadius` | `Double` | `get` | No | `` |
| `InsideMassive` | `Boolean` | `get` | No | `` |
| `LayoutType` | `SegmentLayoutType` | `get/set` | No | `` |
| `Line` | `PnLine` | `get` | No | `` |
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `NetworkTextPos` | `Double` | `get/set` | No | `` |
| `OuterRadius` | `Double` | `get` | No | `` |
| `Params` | `SegmentElementParams` | `get` | No | `` |
| `ParamsThroughCompoundLine` | `CompoundLine` | `get` | No | `` |
| `PlanAndProfileIsDifferent` | `Boolean` | `get` | No | `` |
| `PlanFlipLineText` | `Boolean` | `get/set` | No | `` |
| `PlanLength` | `Double` | `get` | No | `` |
| `PlanLine` | `LightweightPlan` | `get` | No | `` |
| `PlanLineIsSimple` | `Boolean` | `get` | No | `` |
| `PlanName` | `String` | `get/set` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |
| `ProfileLength` | `Double` | `get` | No | `` |
| `ProfileLine` | `LightweightProfile` | `get` | No | `` |
| `ProfileLineIsSimple` | `Boolean` | `get` | No | `` |
| `ProfileStation` | `Double` | `get` | No | `` |
| `SchemeData` | `SegmentSchemeData` | `get` | No | `` |
| `SelectedCharacterPoint` | `PipeCharacterPoint` | `get` | No | `` |
| `Shells` | `Shells` | `get` | No | `` |
| `ShowNetworkText` | `Boolean` | `get/set` | No | `` |
| `StartNode` | `PnNode` | `get` | No | `` |
| `StartNodeConnection` | `SegmentNodeConnection` | `get` | No | `` |
| `StartNodeId` | `UInt32` | `get` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `SteelMark` | `String` | `get/set` | No | `` |
| `StoredLeaderParams` | `StoredLeaderParams` | `get` | No | `` |
| `ThroughPlanLength` | `Double` | `get` | No | `` |
| `ThroughProfileLength` | `Double` | `get` | No | `` |
| `TypeName` | `String` | `get` | No | `` |
| `UserDefinedHeight` | `Double` | `get` | No | `` |
| `UserDefinedInnerDiameter` | `Double` | `get` | No | `` |
| `UserDefinedOuterDiameter` | `Double` | `get` | No | `` |
| `UserDefinedThickness` | `Double` | `get` | No | `` |
| `UserDefinedWidth` | `Double` | `get` | No | `` |

#### Instance Methods (26)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPropertiesFrom` | `Void` | `PnSegment source` | `` |
| `CloneTo` | `PnSegment` | `PnLine line, UInt32 startNodeId, UInt32 endNodeId` | `` |
| `CloneTo` | `PnSegment` | `PnLine line` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetCharacterProfile` | `LightweightProfile` | `` | `` |
| `GetCharacterProfile` | `LightweightProfile` | `PipeCharacterPoint cp` | `` |
| `GetElevation` | `Double` | `PipeCharacterPoint characterPoint, Boolean atStart` | `` |
| `GetElevation` | `Double` | `PipeCharacterPoint characterPoint, Double station` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetMiddleElevationForSlope` | `Double` | `PipeCharacterPoint cp, Double elevation, Boolean atStart` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetShell` | `Shell` | `Double station` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ParseLeaderString` | `String` | `String s, String networkName` | `` |
| `Reverse` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetIndex` | `Void` | `Int32 index` | `` |
| `SetProfileLineToPlanLength` | `Void` | `` | `` |
| `SetProfileLineToPlanLength` | `Void` | `Boolean atStart` | `` |
| `SetSimplePlan` | `Void` | `` | `` |
| `SetSimpleProfile` | `Void` | `Double startElevation, Double endElevation` | `` |
| `SetSimpleProfile` | `Void` | `PipeCharacterPoint cp, Double startElevation, Double endElevation` | `` |
| `SetSimpleProfile` | `Void` | `PipeCharacterPoint cp, Double elevation, Boolean atStart` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetElevation` | `Boolean` | `PipeCharacterPoint characterPoint, Double station, ref Double startElevation, ref Double endElevation` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NoIsolation` | `String` | Yes | `` | `` |
| `UserDefinedPipeCircle` | `String` | Yes | `` | `` |
| `UserDefinedPipeRectangle` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ILinetypeContainer` | `get_LinetypeContainer` |
| `ILinearObject` | `GetPolyline` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IDeterminationContainer` | `get_DeterminationType` |
| `IDeterminationContainer` | `set_DeterminationType` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `IUintId` | `get_Id` |
| `IDeterminated` | `get_DeterminationTypes` |

### `ProfileUserDefinedValuesContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.ProfileUserDefinedValuesContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.SegmentFolder.IProfileUserDefinedValuesContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.ProfileUserDefinedValuesContainer`

#### Constructors (1)

- `.ctor(Object owner, Action onChanged)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UserHeight` | `Double` | `get/set` | No | `` |
| `UserInnerDiameter` | `Double` | `get/set` | No | `` |
| `UserOuterDiameter` | `Double` | `get/set` | No | `` |
| `UserThickness` | `Double` | `get/set` | No | `` |
| `UserWidth` | `Double` | `get/set` | No | `` |
| `UserWireDiameter` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillFromOtherContainer` | `Void` | `IProfileUserDefinedValuesContainer container` | `` |
| `FillFromSegment` | `Void` | `PnSegment segment` | `Obsolete` |
| `FillFromShell` | `Void` | `Shell shell` | `Obsolete` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IProfileUserDefinedValuesContainer` | `get_UserOuterDiameter` |
| `IProfileUserDefinedValuesContainer` | `get_UserInnerDiameter` |
| `IProfileUserDefinedValuesContainer` | `get_UserWireDiameter` |
| `IProfileUserDefinedValuesContainer` | `get_UserWidth` |
| `IProfileUserDefinedValuesContainer` | `get_UserHeight` |
| `IProfileUserDefinedValuesContainer` | `get_UserThickness` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ReserveParamsContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.ReserveParamsContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.ReserveParamsContainer`

#### Constructors (1)

- `.ctor(PipeNetworkItem owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Reserve` | `Double` | `get/set` | No | `` |
| `ReserveAtEnd` | `Double` | `get/set` | No | `` |
| `ReserveAtStart` | `Double` | `get/set` | No | `` |
| `ReserveRounding` | `Double` | `get/set` | No | `` |
| `ReserveRoundingType` | `SegmentReserveRoundingType` | `get/set` | No | `` |
| `ReserveType` | `SegmentReserveType` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneFrom` | `Void` | `ReserveParamsContainer other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SegmentConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SegmentElementFilterPipe` | `String` | Yes | `"PipeNetworkPipe"` | `` |
| `SegmentElementFilterSegmentReference` | `String` | Yes | `"PipeNetworkSegmentReference"` | `` |
| `SegmentElementFilterTechDuct` | `String` | Yes | `"PipeNetworkTechDuct"` | `` |
| `SegmentElementFilterWire` | `String` | Yes | `"PipeNetworkCable"` | `` |
| `SegmentElementReferenceTag` | `String` | Yes | `"PipeNetworkSegmentReferenceTag"` | `` |

### `SegmentElementContainer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentElementContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentElementContainer`

#### Constructors (1)

- `.ctor(PipeNetworkItem parent)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BotInnerLine` | `LightweightProfile` | `get` | No | `` |
| `BotOuterLine` | `LightweightProfile` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `InnerRadius` | `Double` | `get` | No | `` |
| `LeftOuterLine` | `LightweightPlan` | `get` | No | `` |
| `MiddleLine` | `LightweightProfile` | `get` | No | `` |
| `OuterRadius` | `Double` | `get` | No | `` |
| `Params` | `SegmentElementParams` | `get` | No | `` |
| `RightOuterLine` | `LightweightPlan` | `get` | No | `` |
| `SteelMark` | `String` | `get/set` | No | `` |
| `TopInnerLine` | `LightweightProfile` | `get` | No | `` |
| `TopOuterLine` | `LightweightProfile` | `get` | No | `` |
| `UserDefinedHeight` | `Double` | `get` | No | `` |
| `UserDefinedInnerDiameter` | `Double` | `get` | No | `` |
| `UserDefinedOuterDiameter` | `Double` | `get` | No | `` |
| `UserDefinedThickness` | `Double` | `get` | No | `` |
| `UserDefinedWidth` | `Double` | `get` | No | `` |
| `UserDefinedWireDiameter` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillSteelMark` | `String` | `String text` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetElevation` | `Boolean` | `PipeCharacterPoint characterPoint, Double station, ref Double startElevation, ref Double endElevation` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SteelMarkTag` | `String` | Yes | `"%SM%"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `SegmentElementParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentElementParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IImElementContainer container)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Document` | `String` | `get` | No | `` |
| `FullName` | `String` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `HeightString` | `String` | `get` | No | `` |
| `InnerDiameter` | `Double` | `get` | No | `` |
| `InnerDiameterString` | `String` | `get` | No | `` |
| `LengthWithBell` | `Double` | `get` | No | `` |
| `LengthWithoutBell` | `Double` | `get` | No | `` |
| `NS` | `Double` | `get` | No | `` |
| `OuterDiameter` | `Double` | `get` | No | `` |
| `OuterDiameterString` | `String` | `get` | No | `` |
| `PlanName` | `String` | `get` | No | `` |
| `PN` | `Double` | `get` | No | `` |
| `ProductCode` | `String` | `get` | No | `` |
| `ProfileType` | `SegmentProfileType` | `get` | No | `` |
| `SDR` | `Double` | `get` | No | `` |
| `SN` | `Double` | `get` | No | `` |
| `Thickness` | `Double` | `get` | No | `` |
| `TypeName` | `String` | `get` | No | `` |
| `Weight` | `Double` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `` |
| `WidthString` | `String` | `get` | No | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetInnerDiameter` | `Double` | `ImElement item` | `` |
| `GetOuterDiameter` | `Double` | `ImElement item` | `` |
| `LoadFromOldStg` | `ImElement` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HeightTag` | `String` | Yes | `"PipeHeight"` | `` |
| `InnerDiameterTag` | `String` | Yes | `"PipeInnerDiameter"` | `` |
| `OuterDiameterTag` | `String` | Yes | `"PipeOuterDiameter"` | `` |
| `WidthTag` | `String` | Yes | `"PipeWidth"` | `` |

### `SegmentHatchPattern` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentHatchPattern` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHatchPattern` | `HatchPattern` | `SegmentHatchStyle hatchStyle` | `` |

### `SegmentNodeConnection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentNodeConnection` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentNodeConnection`

#### Constructors (1)

- `.ctor(PnSegment segment, Boolean atSegmentStart)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `All` | `IEnumerable<ConstructionConnection>` | `get` | No | `` |
| `AllConnectionsNames` | `String` | `get` | No | `` |
| `IsSimple` | `Boolean` | `get` | No | `` |
| `Node` | `PnNode` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetConnections` | `Void` | `SegmentNodeConnection other, Double nodeElevation` | `` |
| `SetConnections` | `Void` | `String[] connections, Double nodeElevation` | `` |
| `UpdateProfile` | `Void` | `Double nodeElevation` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ParseConnectionsString` | `String[]` | `String connectionsString` | `` |
| `SplitConnections` | `Void` | `String input, String output, ref List<String> inputs, ref List<String> outputs` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConnectionsSeparators` | `Char[]` | Yes | `` | `` |
| `LineSeparators` | `Char[]` | Yes | `` | `` |
| `NodeAxisConnectionLocalisation` | `String` | Yes | `` | `` |
| `NodeAxisConnectionName` | `String` | Yes | `"NodeAxisDefaultConnection"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SegmentProfileType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentProfileType` |
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
      - `Topomatic.Pipes.SegmentFolder.SegmentProfileType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Circle` | `SegmentProfileType` | Yes | `Circle` | `` |
| `Rectangle` | `SegmentProfileType` | Yes | `Rectangle` | `` |
| `UserDefinedCircle` | `SegmentProfileType` | Yes | `UserDefinedCircle` | `` |
| `UserDefinedRectangle` | `SegmentProfileType` | Yes | `UserDefinedRectangle` | `` |
| `UserDefinedTechDuct` | `SegmentProfileType` | Yes | `UserDefinedTechDuct` | `` |
| `UserDefinedWire` | `SegmentProfileType` | Yes | `UserDefinedWire` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `UserDefinedCircle` | `0` |
| `UserDefinedRectangle` | `1` |
| `UserDefinedWire` | `2` |
| `UserDefinedTechDuct` | `3` |
| `Circle` | `4` |
| `Rectangle` | `5` |

**Underlying Type**: `System.Int32`

### `SegmentSchemeData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.SegmentSchemeData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentSchemeData`

#### Constructors (1)

- `.ctor(PnSegment parentSegment)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HideVertexInfo` | `Boolean` | `get` | No | `` |
| `NetworkSchemePipeDirection` | `NetworkSchemePipeDirectionEnum` | `get/set` | No | `` |
| `NetworkSchemePlanArrowOffset` | `Vector2D` | `get/set` | No | `` |
| `NetworkSchemePlanLeaderTemplate` | `String` | `get/set` | No | `` |
| `SchemeColor` | `CadColor` | `get/set` | No | `` |
| `SchemeEndHideOnPlan` | `Boolean` | `get/set` | No | `` |
| `SchemePlanAngleEnd` | `Double` | `get/set` | No | `` |
| `SchemePlanAngleStart` | `Double` | `get/set` | No | `` |
| `SchemePlanFlipText` | `Boolean` | `get/set` | No | `` |
| `SchemePlanLeaderAngle` | `Double` | `get/set` | No | `` |
| `SchemePlanLeaderBaseOffset` | `Double` | `get/set` | No | `` |
| `SchemePlanLeaderHide` | `Boolean` | `get/set` | No | `` |
| `SchemePlanLeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `SchemePlanSignNameEnd` | `String` | `get/set` | No | `` |
| `SchemePlanSignNameStart` | `String` | `get/set` | No | `` |
| `SchemeStartHideOnPlan` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignProperties` | `Void` | `SegmentSchemeData source` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EditedLabelsInSchemePlanSignEnd` | `TransactableDictionary<Int32 EditedLabel>` | No | `` | `` |
| `EditedLabelsInSchemePlanSignStart` | `TransactableDictionary<Int32 EditedLabel>` | No | `` | `` |
| `ElevationEgTag` | `String` | Yes | `"%ElevationEg%"` | `` |
| `ElevationPgEgTag` | `String` | Yes | `"%ElevationPgEg%"` | `` |
| `ElevationPgTag` | `String` | Yes | `"%ElevationPg%"` | `` |
| `NetworkSchemePlanLeaderGradeTag` | `String` | Yes | `"%Grade%"` | `` |
| `NetworkSchemePlanPipeElevationEndTag` | `String` | Yes | `"%ElevationEndCP%"` | `` |
| `NetworkSchemePlanPipeElevationEndTemplate` | `String` | Yes | `` | `` |
| `NetworkSchemePlanPipeElevationStartTag` | `String` | Yes | `"%ElevationStartCP%"` | `` |
| `NetworkSchemePlanPipeElevationStartTemplate` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Shell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Shell` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.SegmentElementContainer` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Visualization.IStgContextSerializable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Pipes.ILinetypeContainer, Topomatic.Pipes.PnInterfaces.IDeterminationContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.SegmentElementContainer`
          - `Topomatic.Pipes.SegmentFolder.Shell`

#### Constructors (1)

- `.ctor(Shells owner)`

#### Properties (32)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Components` | `String` | `get/set` | No | `` |
| `ControlPipeCount` | `ShellControlPipeCount` | `get/set` | No | `` |
| `ControlPipePlanSignName` | `String` | `get/set` | No | `` |
| `ControlPipeProfileBotSignName` | `String` | `get/set` | No | `` |
| `ControlPipeSimplifiedPlanSignName` | `String` | `get/set` | No | `` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `Documents` | `String` | `get/set` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `EndControlPipeOffset` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `EndStationingLeaderPrms` | `StoredLeaderParams` | `get` | No | `` |
| `FoundationDepth` | `Double` | `get/set` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `Length2D` | `Double` | `get` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |
| `PipeToShellBottomDiff` | `Double` | `get/set` | No | `` |
| `PlanEndPosition` | `Vector2D` | `get` | No | `` |
| `PlanLine` | `LightweightPlan` | `get` | No | `` |
| `PlanName` | `String` | `get/set` | No | `` |
| `PlanStartPosition` | `Vector2D` | `get` | No | `` |
| `ProfileLeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `ProfileLine` | `LightweightProfile` | `get` | No | `` |
| `ProfileOffset` | `Double` | `get/set` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `StartControlPipeOffset` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `StartStationingLeaderPrms` | `StoredLeaderParams` | `get` | No | `` |
| `StoredLeaderParams` | `StoredLeaderParams` | `get` | No | `` |
| `TopControlPipeOffset` | `Double` | `get/set` | No | `` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignProperties` | `Void` | `Shell source` | `` |
| `GetElevation` | `Double` | `PipeCharacterPoint characterPoint, Boolean atStart` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ParseLeaderString` | `String` | `String s, String networkName` | `` |
| `Reverse` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetElevation` | `Boolean` | `PipeCharacterPoint characterPoint, Double station, ref Double startElevation, ref Double endElevation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `ILinetypeContainer` | `get_LinetypeContainer` |
| `IDeterminationContainer` | `get_DeterminationType` |
| `IDeterminationContainer` | `set_DeterminationType` |

### `Shells` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Shells` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.SegmentFolder.Shell, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.Shells`

#### Constructors (1)

- `.ctor(PnSegment parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Shell` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Shell` | `ImElement element, Double startStation, Double endStation` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<Shell>` | `` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Void` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

---
## Namespace: `Topomatic.Pipes.SegmentFolder.Construction`

### `ConstructionAxis` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionAxis` |
| **Base Type** | `Topomatic.Pipes.ServiceClasses.IdItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IOrdered` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionAxis`

#### Constructors (1)

- `.ctor(Object owner, UInt32 id)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConstructionContainer` | `SegmentConstructionContainer` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DitchChunks` | `IdItemsDictionary<ConstructionChunkDitch>` | `get` | No | `` |
| `LongChunks` | `IdItemsDictionary<ConstructionChunkLong>` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Order` | `UInt32` | `get/set` | No | `` |
| `PointChunks` | `IdItemsDictionary<ConstructionChunkPoint>` | `get` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `ProfileChunks` | `IdItemsDictionary<ConstructionChunkProfile>` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `ShellChunks` | `IdItemsDictionary<ConstructionChunkShell>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAllChunks` | `IEnumerable<ConstructionChunk>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PreviewParams` | `Preview3dParams` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IOrdered` | `get_Order` |

### `ConstructionChunk` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Base Type** | `Topomatic.Pipes.ServiceClasses.IdItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `ConstructionAxis` | `get` | No | `` |
| `ChunkPosition` | `Vector2D` | `get/set` | No | `` |
| `DefaultName` | `String` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `EndStationParams` | `SegmentConstructionStation` | `get` | No | `` |
| `InvalidPosition` | `Boolean` | `get` | No | `` |
| `Line` | `PnLine` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Order` | `UInt32` | `get/set` | No | `` |
| `PlanName` | `String` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `StartStationParams` | `SegmentConstructionStation` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExistAtLineStation` | `Boolean` | `Double station` | `` |
| `ExistAtStation` | `Boolean` | `Double station` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetPlanLength` | `Void` | `Double length` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IDeterminationContainer` | `get_DeterminationType` |
| `IDeterminationContainer` | `set_DeterminationType` |
| `IOrdered` | `get_Order` |
| `IStationsContainer` | `get_StartStationParams` |
| `IStationsContainer` | `get_EndStationParams` |

### `ConstructionChunkDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkDitch` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer, Topomatic.Pipes.DitchFolder.ICreatableDitch, Topomatic.Pipes.DitchFolder.IDitchVerticalOffsetted, Topomatic.Pipes.PnInterfaces.IDeterminated` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`
            - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkDitch`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get` | No | `` |
| `CutPriority` | `Int32` | `get/set` | No | `` |
| `CutVolume` | `Double` | `get/set` | No | `` |
| `DefaultName` | `String` | `get` | No | `` |
| `Depth` | `Double` | `get/set` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `DitchSolid` | `Shell` | `get/set` | No | `` |
| `DitchSurfaceInfoContainer` | `DitchSurfaceInfoContainer` | `get` | No | `` |
| `EgSurfaceId` | `String` | `get/set` | No | `` |
| `GeologyModelRelativePath` | `String` | `get/set` | No | `` |
| `GroundInfos` | `IList<GroundInfoContainer>` | `get` | No | `` |
| `Layers` | `IList<ConstructionChunkDitchLayer>` | `get` | No | `` |
| `LayingMethod` | `eDitchLayingMethod` | `get/set` | No | `` |
| `LeftSlope` | `Double` | `get/set` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `PgSurfaceId` | `String` | `get/set` | No | `` |
| `Positions` | `IList<Vector3D>` | `get` | No | `` |
| `RightSlope` | `Double` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |
| `TemplateName` | `String` | `get/set` | No | `` |
| `Type` | `eDitchType` | `get` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Nested Types (1)

- `ConstructionChunkDitchLayer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ICreatableDitch` | `get_Type` |
| `ICreatableDitch` | `Topomatic.Pipes.DitchFolder.ICreatableDitch.get_Layers` |
| `ICreatableDitch` | `get_EgSurfaceId` |
| `ICreatableDitch` | `get_PgSurfaceId` |
| `ICreatableDitch` | `get_TemplateName` |
| `ICreatableDitch` | `get_Width` |
| `ICreatableDitch` | `get_LeftSlope` |
| `ICreatableDitch` | `get_RightSlope` |
| `ICreatableDitch` | `get_Closed` |
| `ICreatableDitch` | `get_CutVolume` |
| `ICreatableDitch` | `set_CutVolume` |
| `ICreatableDitch` | `get_Positions` |
| `ICreatableDitch` | `get_Length3D` |
| `ICreatableDitch` | `get_Surface` |
| `ICreatableDitch` | `get_DitchSurfaceInfoContainer` |
| `ICreatableDitch` | `get_CutPriority` |
| `ICreatableDitch` | `set_CutPriority` |
| `ICreatableDitch` | `get_DitchSolid` |
| `ICreatableDitch` | `set_DitchSolid` |
| `ICreatableDitch` | `get_GroundInfos` |
| `ICreatableDitch` | `get_GeologyModelRelativePath` |
| `ICreatableDitch` | `set_GeologyModelRelativePath` |
| `ICreatableDitch` | `get_LayingMethod` |
| `ICreatableDitch` | `set_LayingMethod` |
| `IDitchVerticalOffsetted` | `get_Depth` |
| `IDitchVerticalOffsetted` | `set_Depth` |
| `IDeterminated` | `get_DeterminationTypes` |

### `ConstructionChunkDitchLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkDitch+ConstructionChunkDitchLayer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.DitchFolder.ICreatableDitchLayer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkDitch+ConstructionChunkDitchLayer`

#### Constructors (1)

- `.ctor(ConstructionChunkDitch ditch, String name, Double height)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Diameters` | `IList<Double>` | `get` | No | `` |
| `Ditch` | `ICreatableDitch` | `get` | No | `` |
| `FillVolume` | `Double` | `get/set` | No | `` |
| `Has3DModel` | `Boolean` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `LayerSolid` | `Shell` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PatchHandle` | `Int32` | `get/set` | No | `` |
| `PnItem` | `PipeNetworkItem` | `get` | No | `` |
| `Points` | `IList<Int32>` | `get` | No | `` |
| `ShowDiameters` | `Boolean` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `Int32 index` | `` |
| `ResetSolidInfo` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ConstructionChunkDitchLayer` | `ConstructionChunkDitch ditch, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICreatableDitchLayer` | `get_Index` |
| `ICreatableDitchLayer` | `get_Name` |
| `ICreatableDitchLayer` | `set_Name` |
| `ICreatableDitchLayer` | `get_Ditch` |
| `ICreatableDitchLayer` | `get_PnItem` |
| `ICreatableDitchLayer` | `get_Height` |
| `ICreatableDitchLayer` | `set_Height` |
| `ICreatableDitchLayer` | `get_Diameters` |
| `ICreatableDitchLayer` | `get_ShowDiameters` |
| `ICreatableDitchLayer` | `set_ShowDiameters` |
| `ICreatableDitchLayer` | `get_Points` |
| `ICreatableDitchLayer` | `get_PatchHandle` |
| `ICreatableDitchLayer` | `set_PatchHandle` |
| `ICreatableDitchLayer` | `get_FillVolume` |
| `ICreatableDitchLayer` | `set_FillVolume` |
| `ICreatableDitchLayer` | `AddPoint` |
| `ICreatableDitchLayer` | `get_Surface` |
| `ICreatableDitchLayer` | `get_Color` |
| `ICreatableDitchLayer` | `set_Color` |
| `ICreatableDitchLayer` | `get_LayerSolid` |
| `ICreatableDitchLayer` | `set_LayerSolid` |
| `ICreatableDitchLayer` | `get_Has3DModel` |
| `ICreatableDitchLayer` | `ResetSolidInfo` |
| `ICreatableDitchLayer` | `get_Id` |

### `ConstructionChunkLong` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkLong` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer, Topomatic.Pipes.PnInterfaces.IFilteredElementContainer, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Pipes.PnInterfaces.IProfileObject, Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainer, Topomatic.Pipes.PnInterfaces.IPlanObject, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Pipes.PnInterfaces.IDeterminated, Topomatic.Pipes.PnInterfaces.IProfileCrossingObject, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.ILinetypeContainer, Topomatic.Pipes.IStoredLeaderParams` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`
            - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkLong`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DefaultName` | `String` | `get` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `FilterPropertyTag` | `String` | `get/set` | No | `` |
| `FilterPropertyValue` | `String` | `get/set` | No | `` |
| `IsMainChunk` | `Boolean` | `get` | No | `` |
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |
| `PlanName` | `String` | `get/set` | No | `` |
| `PreviewParams` | `Preview3dParams` | `get` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |
| `ProfileUserValues` | `ProfileUserDefinedValuesContainer` | `get` | No | `` |
| `ReserveParams` | `ReserveParamsContainer` | `get` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfileCrossing` | `Boolean` | `get/set` | No | `` |
| `StoredLeaderParams` | `StoredLeaderParams` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetReserveLength` | `Double` | `Double chunkLength` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IFilteredElementContainer` | `get_FilterPropertyTag` |
| `IFilteredElementContainer` | `set_FilterPropertyTag` |
| `IFilteredElementContainer` | `get_FilterPropertyValue` |
| `IFilteredElementContainer` | `set_FilterPropertyValue` |
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IProfileObject` | `get_ShowOnProfile` |
| `IProfileObject` | `set_ShowOnProfile` |
| `ISegmentProfileContainer` | `Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainer.get_ProfileUserValues` |
| `IPlanObject` | `get_ShowOnPlan` |
| `IPlanObject` | `set_ShowOnPlan` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IDeterminated` | `get_DeterminationTypes` |
| `IProfileCrossingObject` | `get_ShowOnProfileCrossing` |
| `IProfileCrossingObject` | `set_ShowOnProfileCrossing` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `ILinetypeContainer` | `get_LinetypeContainer` |
| `IStoredLeaderParams` | `get_StoredLeaderParams` |

### `ConstructionChunkPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkPoint` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer, Topomatic.Pipes.PnInterfaces.IFilteredElementContainer, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Pipes.PnInterfaces.IDeterminated` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`
            - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkPoint`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultName` | `String` | `get` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `FilterPropertyTag` | `String` | `get/set` | No | `` |
| `FilterPropertyValue` | `String` | `get/set` | No | `` |
| `Rotation` | `Vector3D` | `get/set` | No | `` |
| `StationStep` | `Double` | `get/set` | No | `` |
| `UseProfileGrade` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCount` | `Int32` | `List<Vector3D> profile` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPositions` | `List<DirectedVector3d>` | `List<Vector3D> profile, Double stationStep` | `` |

#### Nested Types (1)

- `DirectedVector3d` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IFilteredElementContainer` | `get_FilterPropertyTag` |
| `IFilteredElementContainer` | `set_FilterPropertyTag` |
| `IFilteredElementContainer` | `get_FilterPropertyValue` |
| `IFilteredElementContainer` | `set_FilterPropertyValue` |
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IDeterminated` | `get_DeterminationTypes` |

### `ConstructionChunkProfile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkProfile` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`
            - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkProfile`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultName` | `String` | `get` | No | `` |
| `ProfileNum` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PreviewParams` | `Preview3dParams` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionChunkShell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkShell` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IOrdered, Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer, Topomatic.Pipes.PnInterfaces.IFilteredElementContainer, Topomatic.Pipes.PnInterfaces.IImElementContainer, Topomatic.Pipes.PnInterfaces.IProfileObject, Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainer, Topomatic.Pipes.PnInterfaces.IPlanObject, Topomatic.Cad.Foundation.IColoredObject, Topomatic.Pipes.PnInterfaces.IDeterminated, Topomatic.Pipes.PnInterfaces.IProfileCrossingObject, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.ILinetypeContainer, Topomatic.Pipes.IStoredLeaderParams` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`
          - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunk`
            - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkShell`

#### Constructors (1)

- `.ctor(Object axis, UInt32 id)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DefaultName` | `String` | `get` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `EndStationingLeaderPrms` | `StoredLeaderParams` | `get` | No | `` |
| `FilterPropertyTag` | `String` | `get/set` | No | `` |
| `FilterPropertyValue` | `String` | `get/set` | No | `` |
| `FoundationDepth` | `Double` | `get/set` | No | `` |
| `LinetypeContainer` | `LinetypeContainer` | `get` | No | `` |
| `PlanLeaderSide` | `Boolean` | `get/set` | No | `` |
| `PlanName` | `String` | `get/set` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |
| `ProfileLeaderPosition` | `Vector2D` | `get/set` | No | `` |
| `ProfileUserValues` | `ProfileUserDefinedValuesContainer` | `get` | No | `` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `` |
| `ShowOnProfileCrossing` | `Boolean` | `get/set` | No | `` |
| `StartStationingLeaderPrms` | `StoredLeaderParams` | `get` | No | `` |
| `StoredLeaderParams` | `StoredLeaderParams` | `get` | No | `` |
| `StoredSchemeLeaderParams` | `StoredLeaderParams` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ControlPipes` | `ConstructionChunkShellControlPipes` | No | `` | `` |
| `DefaultLeaderOffset` | `Vector2D` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IFilteredElementContainer` | `get_FilterPropertyTag` |
| `IFilteredElementContainer` | `set_FilterPropertyTag` |
| `IFilteredElementContainer` | `get_FilterPropertyValue` |
| `IFilteredElementContainer` | `set_FilterPropertyValue` |
| `IImElementContainer` | `get_Element` |
| `IImElementContainer` | `set_Element` |
| `IProfileObject` | `get_ShowOnProfile` |
| `IProfileObject` | `set_ShowOnProfile` |
| `ISegmentProfileContainer` | `Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainer.get_ProfileUserValues` |
| `IPlanObject` | `get_ShowOnPlan` |
| `IPlanObject` | `set_ShowOnPlan` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IDeterminated` | `get_DeterminationTypes` |
| `IProfileCrossingObject` | `get_ShowOnProfileCrossing` |
| `IProfileCrossingObject` | `set_ShowOnProfileCrossing` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `ILinetypeContainer` | `get_LinetypeContainer` |
| `IStoredLeaderParams` | `get_StoredLeaderParams` |

### `ConstructionChunkShellControlPipes` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkShellControlPipes` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkShellControlPipes`

#### Constructors (1)

- `.ctor(ConstructionChunkShell shell)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ControlPipeCount` | `ShellControlPipeCount` | `get/set` | No | `` |
| `ControlPipePlanSignName` | `String` | `get/set` | No | `` |
| `ControlPipeProfileBotSignName` | `String` | `get/set` | No | `` |
| `ControlPipeSimplifiedPlanSignName` | `String` | `get/set` | No | `` |
| `EndControlPipeOffset` | `Double` | `get/set` | No | `` |
| `StartControlPipeOffset` | `Double` | `get/set` | No | `` |
| `TopControlPipeOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillFromShell` | `Void` | `Shell shell` | `Obsolete` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DirectedVector3d` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkPoint+DirectedVector3d` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.SegmentFolder.Construction.ConstructionChunkPoint+DirectedVector3d`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Direction` | `Vector3D` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |

### `ISegmentProfileContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainer` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Pipes.PnInterfaces.IImElementContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProfileUserValues` | `IProfileUserDefinedValuesContainer` | `get` | No | `` |

### `ISegmentProfileContainerExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.ISegmentProfileContainerExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDocument` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetFullName` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetHeight` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetHeightString` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetInnerBounds` | `BoundingBox2D` | `ISegmentProfileContainer profile` | `Extension` |
| `GetInnerDiameter` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetInnerDiameterString` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetInnerRadius` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetMaterial` | `MaterialType` | `ISegmentProfileContainer profile` | `Extension` |
| `GetNominalDiameter` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetOuterBounds` | `BoundingBox2D` | `ISegmentProfileContainer profile` | `Extension` |
| `GetOuterDiameter` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetOuterDiameterString` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetOuterRadius` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetPlanName` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetProfileType` | `SegmentProfileType` | `ISegmentProfileContainer profile` | `Extension` |
| `GetThickness` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetTypeName` | `String` | `ISegmentProfileContainer profile` | `Extension` |
| `GetWidth` | `Double` | `ISegmentProfileContainer profile` | `Extension` |
| `GetWidthString` | `String` | `ISegmentProfileContainer profile` | `Extension` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HeightTag` | `String` | Yes | `"PipeHeight"` | `` |
| `InnerDiameterTag` | `String` | Yes | `"PipeInnerDiameter"` | `` |
| `OuterDiameterTag` | `String` | Yes | `"PipeOuterDiameter"` | `` |
| `WidthTag` | `String` | Yes | `"PipeWidth"` | `` |

### `IStationsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.IStationsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStationParams` | `SegmentConstructionStation` | `get` | No | `` |
| `StartStationParams` | `SegmentConstructionStation` | `get` | No | `` |

### `Preview3dParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.Preview3dParams` |
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
| `AssignFrom` | `Void` | `Preview3dParams other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultColor` | `CadColor` | No | `` | `` |
| `Preview3dColor` | `CadColor` | No | `` | `` |
| `Preview3dSize` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SegmentConstructionContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.SegmentConstructionContainer` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.PnInterfaces.ISegmentAxisContainer, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.SegmentFolder.Construction.ConstructionAxis, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.Construction.SegmentConstructionContainer`

#### Constructors (1)

- `.ctor(PnSegment segment)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllChunks` | `IEnumerable<ConstructionChunk>` | `get` | No | `` |
| `AllDitches` | `IEnumerable<ConstructionChunkDitch>` | `get` | No | `` |
| `AllLongs` | `IEnumerable<ConstructionChunkLong>` | `get` | No | `` |
| `AllPoints` | `IEnumerable<ConstructionChunkPoint>` | `get` | No | `` |
| `AllProfiles` | `IEnumerable<ConstructionChunkProfile>` | `get` | No | `` |
| `AllShells` | `IEnumerable<ConstructionChunkShell>` | `get` | No | `` |
| `AxisDict` | `IdItemsDictionary<ConstructionAxis>` | `get` | No | `` |
| `ConstructionParams` | `CommonConstructionParams` | `get` | No | `` |
| `GetMainAxis` | `ConstructionAxis` | `get` | No | `` |
| `GetMainLongChunk` | `ConstructionChunkLong` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `TemplateDescription` | `String` | `get` | No | `` |
| `TemplateMark` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `ConstructionAxis` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `GetConstructionChunksAtStation` | `IEnumerable<ConstructionChunk>` | `Double station` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionAxis>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `RefreshBaseSegAndShellAxis` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetAxis` | `UInt32` | `ConstructionAxis axis` | `` |
| `SetAxisList` | `Void` | `IEnumerable<ConstructionAxis> list` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentAxisContainer` | `SetAxisList` |
| `ISegmentAxisContainer` | `Add` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `SegmentConstructionStation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.Construction.SegmentConstructionStation` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.SegmentFolder.Construction.SegmentConstructionStation`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, SegmentStationType initialStationType)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `StationOffset` | `Double` | `get/set` | No | `` |
| `StationOffsetType` | `SegmentStationType` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationBySegment` | `Double` | `Boolean inPlan` | `` |
| `GetStationBySegment` | `Double` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationBySegment` | `Double` | `PnSegment segment, SegmentStationType stationType, Double m_Station, Boolean inPlan` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.SegmentFolder.DataTypes`

### `GnbInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.GnbInfo` |
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
      - `Topomatic.Pipes.SegmentFolder.DataTypes.GnbInfo`

#### Constructors (1)

- `.ctor(SegmentData parentData)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GnbForwardDirection` | `GnbPipeDirection` | `get/set` | No | `` |
| `GnbSheetDirectionReverse` | `Boolean` | `get/set` | No | `` |
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

### `IEarthWorkContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.IEarthWorkContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `` |

### `IGnbInfoContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.IGnbInfoContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GnbInfo` | `GnbInfo` | `get` | No | `` |

### `ITechDuctSlotConnectable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.ITechDuctSlotConnectable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TechDuctSlotConnection` | `TechDuctSlotConnection` | `get` | No | `` |

### `PipeSegmentData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.PipeSegmentData` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.SegmentFolder.DataTypes.ITechDuctSlotConnectable, Topomatic.Pipes.SegmentFolder.DataTypes.IEarthWorkContainer, Topomatic.Pipes.SegmentFolder.DataTypes.IGnbInfoContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData`
          - `Topomatic.Pipes.SegmentFolder.DataTypes.PipeSegmentData`

#### Constructors (1)

- `.ctor(PnSegment segment)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `` |
| `Foundation` | `String` | `get/set` | No | `` |
| `FoundationDepth` | `Double` | `get/set` | No | `` |
| `GnbInfo` | `GnbInfo` | `get` | No | `` |
| `Isolation` | `String` | `get/set` | No | `` |
| `SelectedCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `` |
| `TechDuctSlotConnection` | `TechDuctSlotConnection` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPropertiesFrom` | `Void` | `SegmentData other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ITechDuctSlotConnectable` | `get_TechDuctSlotConnection` |
| `IEarthWorkContainer` | `get_EarthWorkType` |
| `IEarthWorkContainer` | `set_EarthWorkType` |
| `IGnbInfoContainer` | `get_GnbInfo` |

### `ReferenceSegmentData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.ReferenceSegmentData` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData`
          - `Topomatic.Pipes.SegmentFolder.DataTypes.ReferenceSegmentData`

#### Constructors (1)

- `.ctor(PnSegment parentSegment)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CachedReferenceSegment` | `PnSegment` | `get` | No | `` |
| `LineId` | `UInt32` | `get/set` | No | `` |
| `ReferenceModelUid` | `String` | `get/set` | No | `` |
| `SegmentId` | `UInt32` | `get/set` | No | `` |
| `TechDuctConnectedElements` | `IDictionary<String ImElement>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `UpdateReference` | `Void` | `PnSegment segment` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `SegmentData` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData`

#### Constructors (1)

- `.ctor(PnSegment segment)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `PnLine` | `get` | No | `` |
| `ParentSegment` | `PnSegment` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPropertiesFrom` | `Void` | `SegmentData other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `TechDuctItems` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSegmentData+TechDuctItems` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSegmentData+TechDuctItems`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConnectedElements` | `List<ImElement>` | No | `` | `` |

### `TechDuctSegmentData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSegmentData` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IDeterminationContainer, Topomatic.Pipes.PnInterfaces.IDeterminated` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData`
          - `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSegmentData`

#### Constructors (1)

- `.ctor(PnSegment segment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrsEndId` | `UInt32` | `get/set` | No | `` |
| `CrsStartId` | `UInt32` | `get/set` | No | `` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `` |
| `DeterminationTypes` | `HashSet<DeterminationType>` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPropertiesFrom` | `Void` | `SegmentData other` | `` |
| `GetAllItems` | `TechDuctItems` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Nested Types (1)

- `TechDuctItems` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IDeterminationContainer` | `get_DeterminationType` |
| `IDeterminationContainer` | `set_DeterminationType` |
| `IDeterminated` | `get_DeterminationTypes` |

### `TechDuctSlotConnection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSlotConnection` |
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
      - `Topomatic.Pipes.SegmentFolder.DataTypes.TechDuctSlotConnection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LineId` | `UInt32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `ReferenceModelUid` | `String` | `get/set` | No | `` |
| `SegmentId` | `UInt32` | `get/set` | No | `` |
| `SlotNameId` | `String` | `get/set` | No | `` |

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

### `WireSegmentData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.SegmentFolder.DataTypes.WireSegmentData` |
| **Base Type** | `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.SegmentFolder.DataTypes.ITechDuctSlotConnectable, Topomatic.Pipes.SegmentFolder.DataTypes.IEarthWorkContainer, Topomatic.Pipes.SegmentFolder.DataTypes.IGnbInfoContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.SegmentFolder.DataTypes.SegmentData`
          - `Topomatic.Pipes.SegmentFolder.DataTypes.WireSegmentData`

#### Constructors (1)

- `.ctor(PnSegment segment)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `` |
| `GnbInfo` | `GnbInfo` | `get` | No | `` |
| `SelectedCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `` |
| `StoredSagValue` | `Double` | `get/set` | No | `` |
| `TechDuctSlotConnection` | `TechDuctSlotConnection` | `get` | No | `` |
| `WireSagType` | `WireSagType` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateParabolaCenterBySagF` | `Vector2D` | `Vector2D start, Vector2D end, Double f` | `` |
| `CalculateSagParams` | `Void` | `Vector2D start, Vector2D end, Double gamma, Double sigma, ref List<Vector2D> positions` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ChainFormulaThreshold` | `Double` | Yes | `500` | `` |
| `SagParabolStepCount` | `Double` | Yes | `32` | `` |
| `WireSelfWeightTag` | `String` | Yes | `"WireSelfWeight"` | `` |
| `WireTensionCapTag` | `String` | Yes | `"WireTensionCap"` | `` |
| `WireTensionMedianTag` | `String` | Yes | `"WireTensionMedian"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ITechDuctSlotConnectable` | `get_TechDuctSlotConnection` |
| `IEarthWorkContainer` | `get_EarthWorkType` |
| `IEarthWorkContainer` | `set_EarthWorkType` |
| `IGnbInfoContainer` | `get_GnbInfo` |

---
## Namespace: `Topomatic.Pipes.ServiceClasses`

### `IdItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.IdItem` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Pipes.PnInterfaces.IUintId, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItem`

#### Constructors (1)

- `.ctor(Object owner, UInt32 id)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `UInt32` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

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
| `IUintId` | `get_Id` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `IdItemsDictionary`1<T where IdItem, INamedTransactable, ITransactable, IUpdatable, IOwned, IStgContextSerializable, IUintId, INamedObject, class, IdItem>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.IdItemsDictionary`1` |
| **Base Type** | `Topomatic.Pipes.PipeNetworkItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, , System.Collections.IEnumerable, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.PipeNetworkItem`
        - `Topomatic.Pipes.ServiceClasses.IdItemsDictionary`1`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dictionary` | `IDictionary<UInt32 T>` | `get` | No | `` |
| `Item` | `T` | `get` | No | `` |
| `Keys` | `IEnumerable<UInt32>` | `get` | No | `` |
| `OrderedValues` | `IList<T>` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `T` | `Object owner` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `UInt32 id` | `` |
| `CreateItem` | `T` | `Object owner, UInt32 id` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `UInt32 id` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Set` | `UInt32` | `T item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `LabelParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.LabelParams` |
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
      - `Topomatic.Pipes.ServiceClasses.LabelParams`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Vector2D offset, Double angle, Boolean flip)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Flip` | `Boolean` | `get/set` | No | `` |
| `Offset` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `LabelParams labelParams` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ListComparer`1<T where class>` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.StringComparers+ListComparer`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSortedList` | `List<T>` | `IEnumerable<T> list, Func<T String> getString, Boolean digitFirst` | `` |
| `GetSortedList` | `List<T>` | `IEnumerable<T> list, Func<T String> getString` | `` |

### `Model3DElementTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.Model3DElementTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlankDescriptor` | `ImTypeDescriptor` | `get` | Yes | `Obsolete` |
| `BlankDocs` | `ImDocuments` | `get` | Yes | `Obsolete` |
| `BlankProps` | `ImProperties` | `get` | Yes | `Obsolete` |

#### Static Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddToCompoundElement` | `Void` | `Compound3DElement compound, ImElement element` | `` |
| `AddToCompoundElement` | `Void` | `Compound3DElement compound, ImElement element, Vector3D position, Vector3D ox, Vector3D oy` | `` |
| `CreateBlankCompoundElement` | `Compound3DElement` | `String name` | `` |
| `CreateCompoundElement` | `Compound3DElement` | `String name, ImElement element` | `` |
| `CreateStaticElementWithCustomModel` | `Static3DElement` | `ImElement element, GeometryModel3D model` | `` |
| `CreateStaticElementWithCustomModel` | `Static3DElement` | `String name, ImElement element, GeometryModel3D model` | `` |
| `GetElementDocuments` | `ImDocuments` | `ImElement element` | `` |
| `LoadModel3DElement` | `ImElement` | `StgNode node, ISerializationContext context` | `` |
| `LoadModel3DElementWithOldSupport` | `ImElement` | `StgNode node, ISerializationContext context, String specificName, Boolean fromAttribute` | `` |
| `ModelContainsPlanBlock` | `Boolean` | `ImElement item` | `` |
| `ModelIsLineType` | `Boolean` | `ImElement item` | `` |
| `ModelIsNode` | `Boolean` | `ImElement item` | `` |
| `ModelIsPipe` | `Boolean` | `ImElement item` | `` |
| `ModelIsPipeOrCable` | `Boolean` | `ImElement item` | `` |
| `ModelIsShaftSection` | `Boolean` | `ImElement item` | `` |
| `ModelIsStreetlight` | `Boolean` | `ImElement item` | `` |
| `ModelIsStreetlightArm` | `Boolean` | `ImElement item` | `` |
| `ModelIsStreetlightFoundation` | `Boolean` | `ImElement item` | `` |
| `ModelIsStreetlightLamp` | `Boolean` | `ImElement item` | `` |
| `ModelIsStreetlightPole` | `Boolean` | `ImElement item` | `` |
| `SaveModel3DElement` | `Void` | `StgNode node, ISerializationContext context, ImElement element` | `` |
| `TryLoadModel3DElementWithOldSupport` | `Boolean` | `StgNode node, ISerializationContext context, String specificName, Boolean fromAttribute, ref ImElement element` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultElementNodeName` | `String` | Yes | `` | `` |

### `PipeExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.PipeExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BotOuterLineWithShell` | `LightweightProfile` | `PnSegment pipe` | `Extension` |
| `GetDitchProfileLine` | `LightweightProfile` | `PnSegment segment` | `Extension` |
| `GetFromStations` | `LightweightProfile` | `LightweightProfile source, Double startSta, Double endSta` | `` |
| `GetNominalFoundationProfileStations` | `IList<Double>` | `PnSegment pipe` | `Extension` |
| `GetProfileLineGeometry` | `LightweightProfile` | `PnSegment pipe, Boolean isTopLine` | `` |
| `TopOuterLineWithShell` | `LightweightProfile` | `PnSegment pipe` | `Extension` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsFoundationDepth` | `Boolean` | Yes | `` | `` |
| `IsNominalProfile` | `Boolean` | Yes | `` | `` |

### `PipeNetworkExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.PipeNetworkExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CadViewCurrentScaleChanged` | `Boolean` | `PipeNetwork network, CadView cadView, ref Double storedScale` | `Extension` |
| `Get3DModelsPivot` | `Vector3D` | `PipeNetwork network` | `Extension` |
| `GetBlockGuid` | `Nullable<Guid>` | `String blockName` | `` |
| `GetBlockName` | `String` | `String signNodeCaption, String blockIdString` | `` |
| `TryGetProfileAnnotativeTextHeight` | `Nullable<Double>` | `PipeNetwork network, CadView cadView` | `Extension` |
| `TryGetProfileAnnotativeTextHeight` | `Boolean` | `PipeNetwork network, CadView cadView, ref Double height` | `Extension` |

### `PolylineTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.PolylineTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateVertexGeometryByChord` | `List<Vector2D>` | `List<BugleVector2D> line, Double chordHeight` | `` |
| `CreateVertexGeometryByStep` | `List<Vector2D>` | `List<BugleVector2D> line, Double stepLength` | `` |

### `SegmentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.SegmentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationInPlan` | `Double` | `PnSegment segment, Double station` | `Extension` |

### `StringComparers` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.StringComparers` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Nested Types (2)

- `ListComparer`1` (abstract class)
- `TextWithNumbersComparer` (class)

### `TextWithNumbersComparer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.ServiceClasses.StringComparers+TextWithNumbersComparer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IComparer`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Boolean digitsBeforeLetters)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Compare` | `Int32` | `String x, String y` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparer`1` | `Compare` |

---
## Namespace: `Topomatic.Pipes.Style`

### `CommonProfileLayerStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.CommonProfileLayerStyle` |
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
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

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

### `CustomFrameLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Base Type** | `Topomatic.Pipes.Style.PipeNetworkStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Layer` | `ILayer` | `get` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

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

### `PipeNetworkStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.PipeNetworkStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.PipeNetwork, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Pipes.Style.PipeNetworkStyleItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork owner)`

#### Properties (74)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommunicationsStyle` | `CommonProfileLayerStyle` | `get` | No | `` |
| `FlipText` | `Boolean` | `get/set` | No | `` |
| `GeologyProfileStyle` | `GeologyProfileStyle` | `get` | No | `` |
| `GeologyStyle` | `CommonProfileLayerStyle` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `NetworkCoreType` | `NetworkCoreType` | `get/set` | No | `` |
| `Override3dColor` | `CadColor` | `get/set` | No | `` |
| `OverrideLongPipe3dColor` | `CadColor` | `get/set` | No | `` |
| `OverrideLongWire3dColor` | `CadColor` | `get/set` | No | `` |
| `OverrideNode3dColor` | `CadColor` | `get/set` | No | `` |
| `OverridePoint3dColor` | `CadColor` | `get/set` | No | `` |
| `OverrideProfileCrossColor` | `CadColor` | `get/set` | No | `` |
| `OverrideShell3dColor` | `CadColor` | `get/set` | No | `` |
| `Owner` | `PipeNetwork` | `get/set` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `PlanDitchLayersStyle` | `PlanDitchLayersStyle` | `get` | No | `` |
| `PlanDitchStyle` | `PlanDitchStyle` | `get` | No | `` |
| `PlanLineLabelStyle` | `PlanLineLabelStyle` | `get` | No | `` |
| `PlanLineStationingStyle` | `PlanLineStationingStyle` | `get` | No | `` |
| `PlanLineStyle` | `PlanLineStyle` | `get` | No | `` |
| `PlanMassiveElementStyle` | `PlanMassiveElementStyle` | `get` | No | `` |
| `PlanMassiveStyle` | `PlanMassiveStyle` | `get` | No | `` |
| `PlanNetworkCrossesStyle` | `PlanNetworkCrossesStyle` | `get` | No | `` |
| `PlanNetworkSchemeStyle` | `PlanNetworkSchemeStyle` | `get` | No | `` |
| `PlanNodeDismantleStyle` | `PlanNodeDismantleStyle` | `get` | No | `` |
| `PlanNodeElementStyle` | `PlanNodeElementStyle` | `get` | No | `` |
| `PlanNodeLabelStyle` | `PlanNodeLabelStyle` | `get` | No | `` |
| `PlanNodeStyle` | `PlanNodeStyle` | `get` | No | `` |
| `PlanPipeRealSizeStyle` | `PlanRealSizeStyle` | `get` | No | `` |
| `PlanSegmentDismantleStyle` | `PlanSegmentDismantleStyle` | `get` | No | `` |
| `PlanSegmentLabelStyle` | `PlanSegmentLabelStyle` | `get` | No | `` |
| `PlanSegmentLongChunkLabelStyle` | `PlanSegmentLongChunkLabelStyle` | `get` | No | `` |
| `PlanSegmentLongChunkStyle` | `PlanSegmentLongChunkStyle` | `get` | No | `` |
| `PlanSegmentPointChunkStyle` | `PlanSegmentPointChunkStyle` | `get` | No | `` |
| `PlanSegmentStyle` | `PlanSegmentStyle` | `get` | No | `` |
| `PlanSegmentVertexStyle` | `PlanSegmentVertexStyle` | `get` | No | `` |
| `PlanShellLabelStyle` | `PlanShellLabelStyle` | `get` | No | `` |
| `PlanShellStationingStyle` | `PlanShellStationingStyle` | `get` | No | `` |
| `PlanShellStyle` | `PlanShellStyle` | `get` | No | `` |
| `PlanStyles` | `IEnumerable<PipesPlanLayerStyleItem>` | `get` | No | `` |
| `PrecisionStyle` | `PrecisionStyle` | `get` | No | `` |
| `ProfileAnnotativeTextHeight` | `Double` | `get/set` | No | `` |
| `ProfileCrossPipeStyle` | `ProfileCrossPipeStyle` | `get` | No | `` |
| `ProfileCrossShaftStyle` | `ProfileCrossShaftStyle` | `get` | No | `` |
| `ProfileCrSurfaceStyle` | `ProfileSurfaceStyle` | `get` | No | `` |
| `ProfileDimensionStyle` | `ProfileDimensionStyle` | `get` | No | `` |
| `ProfileEgSurfaceStyle` | `ProfileSurfaceStyle` | `get` | No | `` |
| `ProfileElementStyle` | `ProfileNodeElementStyle` | `get` | No | `` |
| `ProfileFdSurfaceStyle` | `ProfileSurfaceStyle` | `get` | No | `` |
| `ProfileLineNameStyle` | `ProfileLineNameStyle` | `get` | No | `` |
| `ProfileLongChunkStyle` | `ProfileLongChunkStyle` | `get` | No | `` |
| `ProfileNodeStyle` | `ProfileNodeStyle` | `get` | No | `` |
| `ProfilePgSurfaceStyle` | `ProfileSurfaceStyle` | `get` | No | `` |
| `ProfilePipeStyle` | `ProfilePipeStyle` | `get` | No | `` |
| `ProfileSegmentVertexStyle` | `ProfileSegmentVerticesStyle` | `get` | No | `` |
| `ProfileShellChunkStyle` | `ProfileShellChunkStyle` | `get` | No | `` |
| `ProfileShellStyle` | `ProfileShellStyle` | `get` | No | `` |
| `ProfileUseAnnotativeTextSize` | `Boolean` | `get/set` | No | `` |
| `ProfileUserEntitiesStyle` | `ProfileUserEntitiesStyle` | `get` | No | `` |
| `ProfileWaterLevelStyle` | `ProfileWaterLevelStyle` | `get` | No | `` |
| `SegmentCrsBordersStyle` | `SegmentCrsBordersStyle` | `get` | No | `` |
| `SegmentCrsCenterStyle` | `SegmentCrsCenterStyle` | `get` | No | `` |
| `SegmentCrsContourStyle` | `SegmentCrsContourStyle` | `get` | No | `` |
| `SegmentCrsElevationProfileStyle` | `SegmentCrsElevationProfileStyle` | `get` | No | `` |
| `SegmentCrsFarmStyle` | `SegmentCrsFarmStyle` | `get` | No | `` |
| `SegmentCrsSlotStyle` | `SegmentCrsSlotStyle` | `get` | No | `` |
| `SegmentCrsSlotUserEntityStyle` | `SegmentCrsUserEntityStyle` | `get` | No | `` |
| `SegmentCrsUnderlayStyle` | `SegmentCrsUnderlayStyle` | `get` | No | `` |
| `SegmentElementFilter` | `String` | `get` | No | `` |
| `ShaftSectionsStyle` | `CommonProfileLayerStyle` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |
| `WipeoutLineText` | `Boolean` | `get/set` | No | `` |
| `WipeoutNodeText` | `Boolean` | `get/set` | No | `` |
| `WipeoutSegmentText` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<PipeNetworkStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `ITransactable` | `get_TransactionManager` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PipeNetworkStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.PipeNetworkStyleItem` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `PipeNetworkStyle` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CloneFrom` | `Void` | `PipeNetworkStyleItem source` | `` |
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

### `PipesPlanLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Base Type** | `Topomatic.Pipes.Style.PipeNetworkStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

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

### `PipesStyleItemLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.PipesStyleItemLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |

### `PrecisionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.PrecisionStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipeNetworkStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PrecisionStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleDigits` | `Int32` | `get/set` | No | `` |
| `AngleUnit` | `AngleUnits` | `get/set` | No | `` |
| `CoordinateDigits` | `Int32` | `get/set` | No | `` |
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `GradeDigits` | `Int32` | `get/set` | No | `` |
| `LengthDigits` | `Int32` | `get/set` | No | `` |
| `RadiusDigits` | `Int32` | `get/set` | No | `` |
| `ShowAngleEndZeroFeet` | `Boolean` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |
| `StationingDigits` | `Int32` | `get/set` | No | `` |
| `UseRoundedElevationsInDepths` | `Boolean` | `get/set` | No | `` |
| `UseRoundedElevationsInGrades` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToStr` | `String` | `Double value` | `` |
| `CoordinateToStr` | `String` | `Double value` | `` |
| `CopyProperties` | `Void` | `PrecisionStyle style` | `` |
| `ElevationToStr` | `String` | `Double value` | `` |
| `GradeThousandsToStr` | `String` | `Double value` | `` |
| `GradeToStr` | `String` | `Double value` | `` |
| `LengthToStr` | `String` | `Double value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RadiusToStr` | `String` | `Double value` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryStrToAngle` | `Boolean` | `String value, ref Double result` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Pipes.Style.Plan`

### `PlanDitchLayersStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanDitchLayersStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanDitchLayersStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDitchLayerColor` | `CadColor` | `Int32 index` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LayersColorList` | `CadColor[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanDitchStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanDitchStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanDitchStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanLabelStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TextStandard` | `TextStandard` | `get` | No | `` |
| `TextStyle` | `DwgStyle` | `get` | No | `` |

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

### `PlanLineLabelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanLineLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`
            - `Topomatic.Pipes.Style.Plan.PlanLineLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanLineStationingStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanLineStationingStyle` |
| **Base Type** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`
            - `Topomatic.Pipes.Style.Plan.PlanLineStationingStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanLineStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanLineStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLineStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RemoveShaftsWhenRemoveLine` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlanMassiveElementStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanMassiveElementStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanMassiveElementStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanMassiveStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanMassiveStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanMassiveStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNetworkCrossesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNetworkCrossesStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanNetworkCrossesStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNetworkSchemeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNetworkSchemeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanNetworkSchemeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNodeDismantleStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNodeDismantleStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanNodeDismantleStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNodeElementStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNodeElementStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanNodeElementStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNodeLabelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNodeLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`
            - `Topomatic.Pipes.Style.Plan.PlanNodeLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanNodeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanNodeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanNodeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |
| `ShowExtendedGrips` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanRealSizeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanRealSizeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanRealSizeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanSegmentDismantleStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentDismantleStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentDismantleStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanSegmentLabelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`
            - `Topomatic.Pipes.Style.Plan.PlanSegmentLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanSegmentLongChunkLabelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentLongChunkLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentLongChunkLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |
| `LongStrings` | `String[]` | `get/set` | No | `` |

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

### `PlanSegmentLongChunkStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentLongChunkStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentLongChunkStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanSegmentPointChunkStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentPointChunkStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentPointChunkStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanSegmentStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultSegmentReserveRoundingCeil` | `Boolean` | `get/set` | No | `` |
| `LayerStandardName` | `String` | `get` | No | `` |
| `PipeStrings` | `String[]` | `get/set` | No | `` |

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

### `PlanSegmentVertexStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanSegmentVertexStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanSegmentVertexStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GripCurveColor` | `CadColor` | `get` | No | `` |
| `GripLineColor` | `CadColor` | `get` | No | `` |
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanShellLabelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanShellLabelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanShellLabelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanShellStationingStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanShellStationingStyle` |
| **Base Type** | `Topomatic.Pipes.Style.Plan.PlanLabelStyle` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanLabelStyle`
            - `Topomatic.Pipes.Style.Plan.PlanShellStationingStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlanShellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Plan.PlanShellStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipesPlanLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.PipesPlanLayerStyleItem`
          - `Topomatic.Pipes.Style.Plan.PlanShellStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerStandardName` | `String` | `get` | No | `` |
| `ShellStrings` | `String[]` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Pipes.Style.Profile`

### `AnchorPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfilePipeStyle+AnchorPosition` |
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
      - `Topomatic.Pipes.Style.Profile.ProfilePipeStyle+AnchorPosition`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `AnchorPosition` | Yes | `End` | `` |
| `Middle` | `AnchorPosition` | Yes | `Middle` | `` |
| `Start` | `AnchorPosition` | Yes | `Start` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Start` | `0` |
| `Middle` | `1` |
| `End` | `2` |

**Underlying Type**: `System.Int32`

### `LineTypePatternStored` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileSurfaceStyle+LineTypePatternStored` |
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
      - `Topomatic.Pipes.Style.Profile.ProfileSurfaceStyle+LineTypePatternStored`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Continious` | `LineTypePatternStored` | Yes | `Continious` | `` |
| `DashDot` | `LineTypePatternStored` | Yes | `DashDot` | `` |
| `Dashed` | `LineTypePatternStored` | Yes | `Dashed` | `` |
| `LongDashed` | `LineTypePatternStored` | Yes | `LongDashed` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Continious` | `0` |
| `Dashed` | `1` |
| `LongDashed` | `2` |
| `DashDot` | `3` |

**Underlying Type**: `System.Int32`

### `ProfileCrossPipeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileCrossPipeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileCrossPipeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossCharacterPoint` | `CrossAtPipeCharacterPoint` | `get/set` | No | `` |
| `CrossDrawType` | `CrossDrawType` | `get/set` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `ShowDiameters` | `CrossDrawContour` | `get/set` | No | `` |

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

### `ProfileCrossShaftStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileCrossShaftStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileCrossShaftStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossCharacterPoint` | `CrossAtNodeCharacterPoint` | `get/set` | No | `` |
| `CrossDrawType` | `CrossDrawType` | `get/set` | No | `` |
| `ExistColor` | `CadColor` | `get/set` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `ProjectColor` | `CadColor` | `get/set` | No | `` |
| `ShowDiameters` | `CrossDrawContour` | `get/set` | No | `` |
| `ShowFromToLabels` | `Boolean` | `get/set` | No | `` |

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

### `ProfileDimensionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileDimensionStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileDimensionStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileLineNameStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileLineNameStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileLineNameStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileLongChunkStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileLongChunkStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileLongChunkStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

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

### `ProfileNodeElementStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileNodeElementStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileNodeElementStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileNodeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileNodeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileNodeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |
| `SegmentDepthCharacterPointType` | `SegmentDepthCharacterPointType` | `get/set` | No | `` |
| `ShaftSectionsColor` | `CadColor` | `get/set` | No | `` |
| `ShaftSectionsHeightDelta` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultShaftSectionsColor` | `CadColor` | Yes | `` | `` |
| `DefaultShaftSectionsSelectedColor` | `CadColor` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfilePipeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfilePipeStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfilePipeStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultLayoutType` | `SegmentLayoutType` | `get/set` | No | `` |
| `GradeAnchor` | `AnchorPosition` | `get/set` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `RadiusForPlt` | `PipeRadiusForPlt` | `get/set` | No | `` |
| `SegmentDrawType` | `HashSet<ProfileSegmentDrawType>` | `get/set` | No | `` |
| `SegmentVertexCharacterPointType` | `SegmentVertexCharacterPointType` | `get/set` | No | `` |
| `ShowSegmentHatch` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `AnchorPosition` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfileSegmentVerticesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileSegmentVerticesStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileSegmentVerticesStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileShellChunkStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileShellChunkStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileShellChunkStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

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

### `ProfileShellStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileShellStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileShellStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultControlPipePlanSignName` | `String` | `get/set` | No | `` |
| `DefaultControlPipeProfileBotSignName` | `String` | `get/set` | No | `` |
| `DefaultControlPipeSimplifiedPlanSignName` | `String` | `get/set` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `ShellStrings` | `String[]` | `get/set` | No | `` |

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

### `ProfileSurfaceStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileSurfaceStyle` |
| **Base Type** | `Topomatic.Pipes.Style.PipeNetworkStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.Profile.ProfileSurfaceStyle`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `Enable` | `Boolean` | `get/set` | No | `` |
| `GetLinetypePattern` | `LinetypePattern` | `get` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `LinePattern` | `LineTypePatternStored` | `get/set` | No | `` |
| `Lineweight` | `Lineweight` | `get/set` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCrStyle` | `ProfileSurfaceStyle` | `PipeNetworkStyle owner` | `` |
| `CreateEgStyle` | `ProfileSurfaceStyle` | `PipeNetworkStyle owner` | `` |
| `CreateFdStyle` | `ProfileSurfaceStyle` | `PipeNetworkStyle owner` | `` |
| `CreatePgStyle` | `ProfileSurfaceStyle` | `PipeNetworkStyle owner` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrDefaultColor` | `CadColor` | Yes | `` | `` |
| `CrDefaultLayerName` | `String` | Yes | `` | `` |
| `CrStgNodeName` | `String` | Yes | `` | `` |
| `EgDefaultColor` | `CadColor` | Yes | `` | `` |
| `EgDefaultLayerName` | `String` | Yes | `` | `` |
| `EgStgNodeName` | `String` | Yes | `` | `` |
| `FdDefaultColor` | `CadColor` | Yes | `` | `` |
| `FdDefaultLayerName` | `String` | Yes | `` | `` |
| `FdStgNodeName` | `String` | Yes | `` | `` |
| `PgDefaultColor` | `CadColor` | Yes | `` | `` |
| `PgDefaultLayerName` | `String` | Yes | `` | `` |
| `PgStgNodeName` | `String` | Yes | `` | `` |

#### Nested Types (1)

- `LineTypePatternStored` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ProfileUserEntitiesStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileUserEntitiesStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileUserEntitiesStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileWaterLevelStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.Profile.ProfileWaterLevelStyle` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.Profile.ProfileWaterLevelStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Style.SegmentCrs`

### `SegmentCrsBordersStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsBordersStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsBordersStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsCenterStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsCenterStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsCenterStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsContourStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsContourStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsContourStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsElevationProfileStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsElevationProfileStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsElevationProfileStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsFarmStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsFarmStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsFarmStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsSlotStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsSlotStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsSlotStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Base Type** | `Topomatic.Pipes.Style.CustomFrameLayerStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

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

### `SegmentCrsUnderlayStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsUnderlayStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsUnderlayStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsUserEntityStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsUserEntityStyle` |
| **Base Type** | `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Pipes.Style.PipeNetworkStyle, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Pipes.Style.PipeNetworkStyleItem`
        - `Topomatic.Pipes.Style.CustomFrameLayerStyleItem`
          - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsStyleItem`
            - `Topomatic.Pipes.Style.SegmentCrs.SegmentCrsUserEntityStyle`

#### Constructors (1)

- `.ctor(PipeNetworkStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.UserProfileEntities`

### `CircleProfileEntity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.CircleProfileEntity` |
| **Base Type** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`
      - `Topomatic.Pipes.UserProfileEntities.CircleProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Center` | `Vector2D` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransformable` | `Transform` |

### `DimensionProfileEntity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.DimensionProfileEntity` |
| **Base Type** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`
      - `Topomatic.Pipes.UserProfileEntities.DimensionProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefPos` | `Vector2D` | `get/set` | No | `` |
| `EndPos` | `Vector2D` | `get/set` | No | `` |
| `NotchSize` | `Double` | `get/set` | No | `` |
| `StartPos` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DimensionIsHorizontal` | `Boolean` | `Vector2D p0, Vector2D p1, Vector2D def` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransformable` | `Transform` |

### `ElevationProfileEntity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.ElevationProfileEntity` |
| **Base Type** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`
      - `Topomatic.Pipes.UserProfileEntities.ElevationProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flip` | `Boolean` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `TextOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransformable` | `Transform` |

### `LeaderProfileEntity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.LeaderProfileEntity` |
| **Base Type** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`
      - `Topomatic.Pipes.UserProfileEntities.LeaderProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePosition` | `Vector2D` | `get/set` | No | `` |
| `BottomText` | `String` | `get/set` | No | `` |
| `Flip` | `Boolean` | `get/set` | No | `` |
| `LeaderType` | `LeaderType` | `get/set` | No | `` |
| `Orthogonal` | `Boolean` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |
| `UpperText` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransformable` | `Transform` |

### `LineProfileEntity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.LineProfileEntity` |
| **Base Type** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`
      - `Topomatic.Pipes.UserProfileEntities.LineProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Positions` | `IList<Vector2D>` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransformable` | `Transform` |

### `UserProfileEntity` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.UserProfileEntities.UserProfileEntity` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.ICloneable, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ITransformable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Pipes.UserProfileEntities.UserProfileEntity`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, Vector2D offset, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Transform` | `Void` | `Matrix transformMatrix` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadEntitiesFromStg` | `Void` | `IStgArray stgArray, TransactableList<UserProfileEntity> entities, Object parent` | `` |
| `SaveEntitiesToStg` | `Void` | `IStgArray stgArray, IList<UserProfileEntity> entities` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ICloneable` | `Clone` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `ITransformable` | `Transform` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 362 |
| **Classes** | 226 |
| **Interfaces** | 34 |
| **Enums** | 52 |
| **Structs** | 13 |
| **Abstract Classes** | 18 |
| **Static Classes** | 19 |
| **Total Methods** | 777 |
| **Total Properties** | 1159 |
| **Total Fields** | 574 |
| **Total Events** | 9 |
| **Total Constructors** | 274 |
| **Nested Types** | 28 |
| **Extension Methods** | 0 |


