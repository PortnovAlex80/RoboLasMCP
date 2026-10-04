# Topomatic.Turnouts

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Turnouts` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Turnouts.dll` |

---
## Namespace: `Topomatic.Turnouts`

### `AsymmetricTurnout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.AsymmetricTurnout` |
| **Base Type** | `Topomatic.Turnouts.Turnout` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`
            - `Topomatic.Turnouts.AsymmetricTurnout`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, AsymmetricTurnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, String firstAlignmentRealtivePath, String secondAlignmentRealtivePath, Boolean oneSide, TypedObject railType, SleeperMaterialType cantMaterial, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, TurnoutRotation rotationMechSide, Double mainAngle, Double m, Double a0, Double b0, Double q1, Double c)`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get` | No | `` |
| `A0` | `Double` | `get/set` | No | `` |
| `AdditionalPosition` | `Vector2D` | `get` | No | `` |
| `B0` | `Double` | `get/set` | No | `` |
| `C` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `FirstAlignmentRealtivePath` | `String` | `get/set` | No | `` |
| `FirstPosition` | `Vector2D` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `M` | `Double` | `get/set` | No | `` |
| `MainAngle` | `Double` | `get/set` | No | `` |
| `OneSide` | `Boolean` | `get/set` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `Q1` | `Double` | `get/set` | No | `` |
| `RampStartPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechDirectionPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechSide` | `TurnoutRotation` | `get/set` | No | `` |
| `SecondAlignmentRealtivePath` | `String` | `get/set` | No | `` |
| `SecondAngle` | `Double` | `get` | No | `` |
| `SecondPosition` | `Vector2D` | `get` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `Balancer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Balancer` |
| **Base Type** | `Topomatic.Turnouts.SwitchProduct` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Balancer`

#### Constructors (4)

- `.ctor(Object parent)`
- `.ctor(Object parent, Balancer joint)`
- `.ctor(Object parent, String name)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutDirection turnoutDirection, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, TypedObject railType, SleeperMaterialType cantStuff)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeginRampLength` | `Double` | `get/set` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `RampEndLength` | `Double` | `get/set` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `BlockJoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.BlockJoint` |
| **Base Type** | `Topomatic.Turnouts.Joint` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.Joint`
          - `Topomatic.Turnouts.BlockJoint`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, Joint joint)`
- `.ctor(Object parent, String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlockJointType` | `BlockJointType` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `BlockJointType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.BlockJointType` |
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
      - `Topomatic.Turnouts.BlockJointType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Glue` | `BlockJointType` | Yes | `Glue` | `` |
| `Sectional` | `BlockJointType` | Yes | `Sectional` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Sectional` | `0` |
| `Glue` | `1` |

**Underlying Type**: `System.Int32`

### `BufferStop` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.BufferStop` |
| **Base Type** | `Topomatic.Turnouts.GridironObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.BufferStop`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, BufferStop bufferStop)`
- `.ctor(Object parent, String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `CustomProfileSign` | `Int32` | `get/set` | No | `` |
| `ModelId` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `UseCustomProfileSign` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `ConventionalJoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.ConventionalJoint` |
| **Base Type** | `Topomatic.Turnouts.Joint` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.Joint`
          - `Topomatic.Turnouts.ConventionalJoint`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, Joint joint)`
- `.ctor(Object parent, String name)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DeafCrossTurnout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.DeafCrossTurnout` |
| **Base Type** | `Topomatic.Turnouts.Turnout` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`
            - `Topomatic.Turnouts.DeafCrossTurnout`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, DeafCrossTurnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, String secondAlignmentRealtivePath, TypedObject railType, SleeperMaterialType cantMaterial, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, Double c, Double q1, Double k)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `C` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndPosition` | `Vector2D` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `K` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `Q1` | `Double` | `get/set` | No | `` |
| `SecondAlignmentRealtivePath` | `String` | `get/set` | No | `` |
| `SecondEndPosition` | `Vector2D` | `get` | No | `` |
| `SecondStartPosition` | `Vector2D` | `get` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `DoubleCrossTurnout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.DoubleCrossTurnout` |
| **Base Type** | `Topomatic.Turnouts.Turnout` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`
            - `Topomatic.Turnouts.DoubleCrossTurnout`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, DoubleCrossTurnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, String secondAlignmentRelativePath, TypedObject railType, SleeperMaterialType cantMaterial, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, Double c, Double q1, Double k)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `C` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndPosition` | `Vector2D` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `K` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `Q1` | `Double` | `get/set` | No | `` |
| `SecondAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `SecondEndPosition` | `Vector2D` | `get` | No | `` |
| `SecondStartPosition` | `Vector2D` | `get` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `DropArrow` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.DropArrow` |
| **Base Type** | `Topomatic.Turnouts.SwitchProduct` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.DropArrow`

#### Constructors (4)

- `.ctor(Object parent)`
- `.ctor(Object parent, DropArrow joint)`
- `.ctor(Object parent, String name)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean manual, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, TypedObject railType, SleeperMaterialType cantStuff)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BeginRampLength` | `Double` | `get/set` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `Manual` | `Boolean` | `get/set` | No | `` |
| `RampEndLength` | `Double` | `get/set` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `TurnoutSideType` | `TurnoutSideType` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `Gridiron` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Gridiron` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Alg.IAlignmentContainer, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Gridiron`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `GridironObject` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Style` | `GridironStyle` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `GridironObject item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `UInt32 key` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `GridironObject value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetValue` | `Boolean` | `UInt32 key, ref GridironObject value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EMPTY_ID` | `UInt32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IAlignmentContainer` | `get_Alignment` |
| `IGridironContainer` | `Topomatic.Turnouts.IGridironContainer.get_Gridiron` |

### `GridironConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.GridironConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PluginID` | `String` | Yes | `` | `` |

### `GridironElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.GridironElement` |
| **Base Type** | `Topomatic.Turnouts.GridironObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.GridironElement`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, GridironElement signal)`
- `.ctor(Object parent, String name, Double offset, Boolean drawBackward)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `DataHolder` | `SemanticDataHolder` | `get` | No | `` |
| `DrawBackward` | `Boolean` | `get/set` | No | `` |
| `IsDataHolderEmpty` | `Boolean` | `get` | No | `` |
| `ModelId` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `PointSign` | `UInt32` | `get/set` | No | `` |
| `ReferencedAlignment` | `String` | `get/set` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `SemanticCode` | `Int32` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `GridironObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.GridironObject` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, GridironObject obj)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `Direction` | `Vector2D` | `get` | No | `` |
| `DirectionValue` | `Vector2D` | `get/set` | No | `` |
| `Gridiron` | `Gridiron` | `get` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `Link` | `Link` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get` | No | `` |
| `PositionValue` | `Vector2D` | `get/set` | No | `` |
| `UserPosition` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IGridironContainer` | `get_Gridiron` |

### `IGridironContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.IGridironContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Gridiron` | `Gridiron` | `get` | No | `` |

### `Joint` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Joint` |
| **Base Type** | `Topomatic.Turnouts.GridironObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.Joint`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, Joint joint)`
- `.ctor(Object parent, String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `CustomProfileSign` | `Int32` | `get/set` | No | `` |
| `ModelId` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `UseCustomProfileSign` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetJointlesswayRailLength` | `Double` | `Alignment alignment, Double startSta, Double endSta, Boolean left` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `JointlessJoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.JointlessJoint` |
| **Base Type** | `Topomatic.Turnouts.Joint` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.Joint`
          - `Topomatic.Turnouts.JointlessJoint`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, Joint joint)`
- `.ctor(Object parent, String name)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `JointlessJointType` | `JointlessJointType` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `JointlessJointType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.JointlessJointType` |
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
      - `Topomatic.Turnouts.JointlessJointType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Aluminothermy` | `JointlessJointType` | Yes | `Aluminothermy` | `` |
| `ElectricalContact` | `JointlessJointType` | Yes | `ElectricalContact` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Aluminothermy` | `0` |
| `ElectricalContact` | `1` |

**Underlying Type**: `System.Int32`

### `SimpleTurnout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.SimpleTurnout` |
| **Base Type** | `Topomatic.Turnouts.Turnout` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`
            - `Topomatic.Turnouts.SimpleTurnout`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, SimpleTurnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, String secondAlignmentRelativePath, TurnoutSideType turnoutSide, TypedObject railType, SleeperMaterialType cantMaterial, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, TurnoutRotation rotationMechSide, Double m, Double a0, Double b0, Double q1)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get` | No | `` |
| `A0` | `Double` | `get/set` | No | `` |
| `B` | `Double` | `get` | No | `` |
| `B0` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndPosition` | `Vector2D` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `M` | `Double` | `get/set` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `Q1` | `Double` | `get/set` | No | `` |
| `RampStartPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechDirectionPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechSide` | `TurnoutRotation` | `get/set` | No | `` |
| `SecondAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `SecondPosition` | `Vector2D` | `get` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `SleeperMaterialType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.SleeperMaterialType` |
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
      - `Topomatic.Turnouts.SleeperMaterialType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Concrete` | `SleeperMaterialType` | Yes | `Concrete` | `` |
| `Other` | `SleeperMaterialType` | Yes | `Other` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Wood` | `SleeperMaterialType` | Yes | `Wood` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Wood` | `0` |
| `Concrete` | `1` |
| `Other` | `2` |

**Underlying Type**: `System.Int32`

### `SwitchProduct` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.SwitchProduct` |
| **Base Type** | `Topomatic.Turnouts.GridironObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`

#### Constructors (3)

- `.ctor(Object owner, SwitchProduct obj)`
- `.ctor(Object owner, String name)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutDirection turnoutDirection, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, TypedObject railType, SleeperMaterialType cantStuff)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CantStuff` | `SleeperMaterialType` | `get/set` | No | `` |
| `CustomProfileSign` | `Int32` | `get/set` | No | `` |
| `CustomTextPosition` | `Boolean` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `FlipText` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `NameTextOffset` | `Vector2D` | `get/set` | No | `` |
| `ProjectName` | `String` | `get/set` | No | `` |
| `RailType` | `TypedObject` | `get/set` | No | `` |
| `TurnoutDirection` | `TurnoutDirection` | `get/set` | No | `` |
| `TurnoutModelId` | `Guid` | `get/set` | No | `` |
| `TypeTextOffset` | `Vector2D` | `get/set` | No | `` |
| `UseCustomProfileSign` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `SymmetricTurnout` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.SymmetricTurnout` |
| **Base Type** | `Topomatic.Turnouts.Turnout` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`
            - `Topomatic.Turnouts.SymmetricTurnout`

#### Constructors (3)

- `.ctor(Object parent)`
- `.ctor(Object parent, SymmetricTurnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, String firstAlignmentRealtivePath, String secondAlignmentRealtivePath, TypedObject railType, SleeperMaterialType cantMaterial, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, TurnoutRotation rotationMechSide, Double m, Double a0, Double b0, Double q1)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get` | No | `` |
| `A0` | `Double` | `get/set` | No | `` |
| `B` | `Double` | `get` | No | `` |
| `B0` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ConnectorCount` | `Int32` | `get` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `FirstAlignmentRealtivePath` | `String` | `get/set` | No | `` |
| `FirstPosition` | `Vector2D` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `M` | `Double` | `get/set` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `Q1` | `Double` | `get/set` | No | `` |
| `RampStartPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechDirectionPosition` | `Vector2D` | `get` | No | `` |
| `RotationMechSide` | `TurnoutRotation` | `get/set` | No | `` |
| `SecondAlignmentRealtivePath` | `String` | `get/set` | No | `` |
| `SecondPosition` | `Vector2D` | `get` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `GridironObject` | `Object parent` | `` |
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetConnector` | `Connector` | `Int32 index` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `Turnout` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Turnout` |
| **Base Type** | `Topomatic.Turnouts.SwitchProduct` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, System.IEquatable`1[[Topomatic.Turnouts.GridironObject, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.INamedObject, Topomatic.Turnouts.IGridironContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.GridironObject`
        - `Topomatic.Turnouts.SwitchProduct`
          - `Topomatic.Turnouts.Turnout`

#### Constructors (2)

- `.ctor(Object parent, Turnout turnout)`
- `.ctor(Object parent, String name, String description, String typeProjectName, TurnoutType turnoutType, TurnoutDirection turnoutDirection, TurnoutSideType side, Boolean customTextPosition, Boolean flipText, Vector2D nameTextOffset, Vector2D typeTextOffset, TurnoutCrossMark crossMark, Double crossAngle, String crossMarkDescription, TypedObject railType, SleeperMaterialType cantStuff, Boolean foulingPointShow, Double foulingPointOffset, Double foulingPointDeltaOffsetCurveMain, Double foulingPointDeltaOffsetCurveSecond, Boolean centralized)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AfterCommonBeamDistance` | `Double` | `get/set` | No | `` |
| `Centralized` | `Boolean` | `get/set` | No | `` |
| `CommonBeamDistance` | `Double` | `get/set` | No | `` |
| `CommonBeamMainWayPosition` | `Vector2D` | `get` | No | `` |
| `CommonBeamSecondWayPosition` | `Vector2D` | `get` | No | `` |
| `ControlPoints` | `IList<TurnoutControlPoint>` | `get` | No | `` |
| `CrossAngle` | `Double` | `get/set` | No | `` |
| `CrossMark` | `TurnoutCrossMark` | `get/set` | No | `` |
| `CrossMarkDescription` | `String` | `get/set` | No | `` |
| `EndConnectorIndex` | `Int32` | `get` | No | `` |
| `EndStation` | `Double` | `get` | No | `` |
| `FoulingPointDeltaOffsetCurveMain` | `Double` | `get/set` | No | `` |
| `FoulingPointDeltaOffsetCurveSecond` | `Double` | `get/set` | No | `` |
| `FoulingPointModelId` | `Guid` | `get/set` | No | `` |
| `FoulingPointOffset` | `Double` | `get/set` | No | `` |
| `FoulingPointShow` | `Boolean` | `get/set` | No | `` |
| `PointConnectorCount` | `Int32` | `get` | No | `` |
| `ShowCommonBeamDistance` | `Boolean` | `get/set` | No | `` |
| `StartConnectorIndex` | `Int32` | `get` | No | `` |
| `StartStation` | `Double` | `get` | No | `` |
| `TurnoutSideType` | `TurnoutSideType` | `get/set` | No | `` |
| `TurnoutType` | `TurnoutType` | `get/set` | No | `` |
| `Ways` | `TurnoutWay[]` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GridironObject other` | `` |
| `GetFoulingPoints` | `IEnumerable<Vector2D>` | `` | `` |
| `GetPointConnector` | `KeyValuePair<String Vector2D>` | `Int32 index` | `` |
| `GetSecondWays` | `IEnumerable<String>` | `` | `Obsolete` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Nested Types (1)

- `TurnoutWay` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IEquatable`1` | `Equals` |

### `TurnoutConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CrossMarkToAngle` | `Double` | `TurnoutCrossMark mark` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `a1_11` | `Double` | Yes | `0.0906601583674832` | `` |
| `a1_18` | `Double` | Yes | `0.0553293613566258` | `` |
| `a1_22` | `Double` | Yes | `0.0453300791837416` | `` |
| `a1_6` | `Double` | Yes | `0.165151780469963` | `` |
| `a1_9` | `Double` | Yes | `0.110658722713252` | `` |
| `a2_11` | `Double` | Yes | `0.181320316734966` | `` |
| `a2_6` | `Double` | Yes | `0.330303560939927` | `` |
| `a2_9` | `Double` | Yes | `0.221317445426503` | `` |
| `RAILWAYS_MODEL_TYPE` | `String` | Yes | `` | `` |

### `TurnoutCrossMark` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutCrossMark` |
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
      - `Topomatic.Turnouts.TurnoutCrossMark`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m1_11` | `TurnoutCrossMark` | Yes | `m1_11` | `` |
| `m1_18` | `TurnoutCrossMark` | Yes | `m1_18` | `` |
| `m1_22` | `TurnoutCrossMark` | Yes | `m1_22` | `` |
| `m1_6` | `TurnoutCrossMark` | Yes | `m1_6` | `` |
| `m1_9` | `TurnoutCrossMark` | Yes | `m1_9` | `` |
| `m2_11` | `TurnoutCrossMark` | Yes | `m2_11` | `` |
| `m2_6` | `TurnoutCrossMark` | Yes | `m2_6` | `` |
| `m2_9` | `TurnoutCrossMark` | Yes | `m2_9` | `` |
| `Other` | `TurnoutCrossMark` | Yes | `Other` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `m1_9` | `0` |
| `m1_18` | `1` |
| `m1_11` | `2` |
| `m1_22` | `3` |
| `Other` | `4` |
| `m1_6` | `5` |
| `m2_6` | `6` |
| `m2_9` | `7` |
| `m2_11` | `8` |

**Underlying Type**: `System.Int32`

### `TurnoutDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutDirection` |
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
      - `Topomatic.Turnouts.TurnoutDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `TurnoutDirection` | Yes | `Backward` | `` |
| `Forward` | `TurnoutDirection` | Yes | `Forward` | `` |
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

### `TurnoutExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateAsymmetricTurnoutPositions` | `Void` | `TurnoutDirection direction, Vector2D center_pos, Vector2D forward_pos, TurnoutSideType side, TurnoutRotation rotationMechSide, Boolean oneSide, Double a, Double b0, Double c, Double q1, Double firstAngle, Double secondAngle, ref Vector2D start_pos, ref Vector2D add_center_pos, ref Vector2D first_pos, ref Vector2D second_pos, ref Vector2D rotation_mech_pos` | `` |
| `CalculateDeafCrossTurnoutPositions` | `Void` | `TurnoutDirection direction, TurnoutSideType side, Vector2D center_pos, Vector2D forward_pos, Double cq1, Double k, Double angle, ref Vector2D start_pos, ref Vector2D end_pos, ref Vector2D second_start, ref Vector2D second_end` | `` |
| `CalculateDoubleCrossTurnoutPositions` | `Void` | `TurnoutDirection direction, TurnoutSideType side, Vector2D center_pos, Vector2D forward_pos, Double cq1, Double k, Double angle, ref Vector2D start_pos, ref Vector2D end_pos, ref Vector2D second_start, ref Vector2D second_end` | `` |
| `CalculateFoulingPointPosition` | `Boolean` | `Alignment main, Alignment second, Vector2D position, Vector2D direction, Double foulingOffset, Double deltaMain, Double deltaSecond, ref Vector2D pos` | `` |
| `CalculatePositionAndDirection` | `Boolean` | `Alignment alignment, Double station, ref Vector2D position, ref Vector2D direction` | `` |
| `CalculateSimpleTurnoutPositions` | `Void` | `TurnoutDirection direction, TurnoutSideType side, TurnoutRotation rotationMechSide, Vector2D center_pos, Vector2D forward_pos, Double a, Double b, Double angle, ref Vector2D start_pos, ref Vector2D end_pos, ref Vector2D second_pos, ref Vector2D rotation_mech_pos` | `` |
| `CalculateSymmetricTurnoutPositions` | `Void` | `TurnoutDirection direction, TurnoutSideType side, TurnoutRotation rotationMechSide, Vector2D center_pos, Vector2D forward_pos, Double a, Double b, Double angle, ref Vector2D start_pos, ref Vector2D first_pos, ref Vector2D second_pos, ref Vector2D rotation_mech_pos` | `` |
| `CalculateTextOffset` | `Vector2D` | `Vector2D center_pos, Vector2D forward_pos, Vector2D position` | `` |
| `CalculateTextPosition` | `Vector2D` | `Vector2D center_pos, Vector2D forward_pos, Vector2D offset` | `` |
| `RefreshPointSign` | `Void` | `GridironElement element` | `Extension` |

### `TurnoutRotation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutRotation` |
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
      - `Topomatic.Turnouts.TurnoutRotation`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `TurnoutRotation` | Yes | `Left` | `` |
| `Right` | `TurnoutRotation` | Yes | `Right` | `` |
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

### `TurnoutSideType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutSideType` |
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
      - `Topomatic.Turnouts.TurnoutSideType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftSideTurnout` | `TurnoutSideType` | Yes | `LeftSideTurnout` | `` |
| `RightSideTurnout` | `TurnoutSideType` | Yes | `RightSideTurnout` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftSideTurnout` | `0` |
| `RightSideTurnout` | `1` |

**Underlying Type**: `System.Int32`

### `TurnoutType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.TurnoutType` |
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
      - `Topomatic.Turnouts.TurnoutType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Exist` | `TurnoutType` | Yes | `Exist` | `` |
| `Project` | `TurnoutType` | Yes | `Project` | `` |
| `Rebuild` | `TurnoutType` | Yes | `Rebuild` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Exist` | `0` |
| `Project` | `1` |
| `Rebuild` | `2` |

**Underlying Type**: `System.Int32`

### `TurnoutWay` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Turnout+TurnoutWay` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Turnout+TurnoutWay`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndCommon` | `Vector2D` | `get` | No | `` |
| `StartCommon` | `Vector2D` | `get` | No | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AfterCommonBeam` | `Double` | No | `` | `` |
| `BothCommonBeam` | `Boolean` | No | `` | `` |
| `End` | `Vector2D` | No | `` | `` |
| `MainWay` | `Boolean` | No | `` | `` |
| `RelativePath` | `String` | No | `` | `` |
| `Start` | `Vector2D` | No | `` | `` |

---
## Namespace: `Topomatic.Turnouts.ControlPoints`

### `TurnoutControlPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.ControlPoints.TurnoutControlPoint` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Turnouts.IGridironContainer, System.IEquatable`1[[Topomatic.Turnouts.ControlPoints.TurnoutControlPoint, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.ControlPoints.TurnoutControlPoint`

#### Constructors (2)

- `.ctor(Turnout turnout)`
- `.ctor(Turnout turnout, Double x, Double y, Boolean connected, Int32 index)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Connected` | `Boolean` | `get/set` | No | `` |
| `Distance` | `Double` | `get` | No | `` |
| `Gridiron` | `Gridiron` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PointConnectorIndex` | `Int32` | `get/set` | No | `` |
| `Turnout` | `Turnout` | `get` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `TurnoutControlPoint other` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IGridironContainer` | `get_Gridiron` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

---
## Namespace: `Topomatic.Turnouts.Links`

### `Connector` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Links.Connector` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetStation` | `Boolean` | `Double delta, ref Double station` | `` |

### `Link` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Links.Link` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Turnouts.IGridironContainer, System.IEquatable`1[[Topomatic.Turnouts.Links.Link, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Links.Link`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Link link)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `ConnectorNumber` | `Int32` | `get/set` | No | `` |
| `Gridiron` | `Gridiron` | `get` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `LinkedId` | `UInt32` | `get/set` | No | `` |
| `LinkType` | `LinkType` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Value` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Link` | `Object parent` | `` |
| `Equals` | `Boolean` | `Link other` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IGridironContainer` | `get_Gridiron` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `LinkType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Links.LinkType` |
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
      - `Topomatic.Turnouts.Links.LinkType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Connector` | `LinkType` | Yes | `Connector` | `` |
| `Direct` | `LinkType` | Yes | `Direct` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Direct` | `0` |
| `Connector` | `1` |

**Underlying Type**: `System.Int32`

### `SimpleConnector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Links.SimpleConnector` |
| **Base Type** | `Topomatic.Turnouts.Links.Connector` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Turnouts.Links.Connector`
    - `Topomatic.Turnouts.Links.SimpleConnector`

#### Constructors (1)

- `.ctor(GridironObject parent)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |
| `TryGetStation` | `Boolean` | `Double delta, ref Double station` | `` |

---
## Namespace: `Topomatic.Turnouts.Railways`

### `IRailWaysContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.IRailWaysContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RailWays` | `RailWays` | `get` | No | `` |

### `RailWay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.RailWay` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Railways.RailWay`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `EndLink` | `RailWayLink` | `get/set` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `Links` | `IList<RailWayLink>` | `get` | No | `` |
| `Number` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RailType` | `TypedObject` | `get/set` | No | `` |
| `RailwayType` | `RailwayType` | `get/set` | No | `` |
| `StartLink` | `RailWayLink` | `get/set` | No | `` |
| `UsedRelativePaths` | `IEnumerable<String>` | `get` | No | `` |

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RailWayLink` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.RailWayLink` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.RailWayLink`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `RailWayLink` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, RailWayLink value` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DirectionPath` | `String` | No | `` | `` |
| `Empty` | `RailWayLink` | Yes | `` | `` |
| `GridironUid` | `UInt32` | No | `` | `` |
| `RelativePath` | `String` | No | `` | `` |

### `RailWays` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.RailWays` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Railways.RailWays`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `RailWay` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `RailWay` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `UInt32 key` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `Remove` | `Boolean` | `RailWay value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `TryGetValue` | `Boolean` | `UInt32 key, ref RailWay value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EMPTY_ID` | `UInt32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RailwayType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.RailwayType` |
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
      - `Topomatic.Turnouts.Railways.RailwayType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Major` | `RailwayType` | Yes | `Major` | `` |
| `Other` | `RailwayType` | Yes | `Other` | `` |
| `SendReceive` | `RailwayType` | Yes | `SendReceive` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Major` | `0` |
| `SendReceive` | `1` |
| `Other` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Turnouts.Railways.Master`

### `DismantileRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.DismantileRecord` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.DismantileRecord`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fastening` | `String` | No | `` | `` |
| `RailType` | `String` | No | `` | `` |
| `RailwayType` | `String` | No | `` | `` |
| `SleeperDiagram` | `String` | No | `` | `` |
| `SleeperType` | `String` | No | `` | `` |
| `Summary` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GridironObjectRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.GridironObjectRecord` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.GridironObjectRecord`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |
| `PriceGrown` | `String` | No | `` | `` |
| `RailType` | `String` | No | `` | `` |
| `Side` | `String` | No | `` | `` |
| `State` | `State` | No | `` | `` |
| `TimberMaterial` | `String` | No | `` | `` |
| `TypeProject` | `String` | No | `` | `` |
| `TypeStr` | `String` | No | `` | `` |
| `Way` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LayRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.LayRecord` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.LayRecord`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ballast` | `String` | No | `` | `` |
| `Fastening` | `String` | No | `` | `` |
| `Length` | `String` | No | `` | `` |
| `RailType` | `String` | No | `` | `` |
| `RailwayType` | `String` | No | `` | `` |
| `SleeperDiagram` | `String` | No | `` | `` |
| `SleeperType` | `String` | No | `` | `` |
| `Summary` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RailWayDismantileColumn` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.RailWayDismantileColumn` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.RailWayDismantileColumn`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Enabled` | `Boolean` | No | `` | `` |
| `PriceGrown` | `String` | No | `` | `` |
| `Prices` | `String[]` | No | `` | `` |
| `Value` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RailWayLayColumn` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.RailWayLayColumn` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.RailWayLayColumn`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Divider` | `String` | No | `` | `` |
| `Enabled` | `Boolean` | No | `` | `` |
| `PriceGrown` | `String` | No | `` | `` |
| `Prices` | `String[]` | No | `` | `` |
| `Value` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RailWayMasterLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.RailWayMasterLayer` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Railways.Master.RailWayMasterLayer`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (25)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BuildingLength` | `String` | `get/set` | No | `` |
| `DismantileTurnouts` | `String` | `get/set` | No | `` |
| `DismantileWay` | `String` | `get/set` | No | `` |
| `DismatileRecords` | `IList<DismantileRecord>` | `get` | No | `` |
| `FullLength` | `String` | `get/set` | No | `` |
| `GridironObjects` | `IList<GridironObjectRecord>` | `get` | No | `` |
| `Id` | `UInt32` | `get/set` | No | `` |
| `JointLength` | `String` | `get/set` | No | `` |
| `JointlessLength` | `String` | `get/set` | No | `` |
| `LayJoints` | `String` | `get/set` | No | `` |
| `LayRecrords` | `IList<LayRecord>` | `get` | No | `` |
| `LayTurnouts` | `String` | `get/set` | No | `` |
| `MainLength` | `String` | `get/set` | No | `` |
| `Move2k` | `String` | `get/set` | No | `` |
| `Move2kSummary` | `String` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `OtherLength` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RailwaysRecord` | `IList<RailWayRecord>` | `get` | No | `` |
| `Straightening` | `String` | `get/set` | No | `` |
| `StraighteningSummary` | `String` | `get/set` | No | `` |
| `SummaryDismantile` | `String` | `get/set` | No | `` |
| `SummaryLay` | `String` | `get/set` | No | `` |
| `VolumeRecords` | `IList<VolumeRecord>` | `get` | No | `` |
| `VolumeSections` | `IList<String>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RailWayMasterLayers` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.RailWayMasterLayers` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Turnouts.Railways.Master.RailWayMasterLayers`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BuildingLength` | `String` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DismantileTurnouts` | `String` | `get/set` | No | `` |
| `DismantileWay` | `String` | `get/set` | No | `` |
| `FullLength` | `String` | `get/set` | No | `` |
| `Item` | `RailWayMasterLayer` | `get` | No | `` |
| `JointLength` | `String` | `get/set` | No | `` |
| `JointlessLength` | `String` | `get/set` | No | `` |
| `LayJoints` | `String` | `get/set` | No | `` |
| `LayTurnouts` | `String` | `get/set` | No | `` |
| `MainLength` | `String` | `get/set` | No | `` |
| `Move2kSummary` | `String` | `get/set` | No | `` |
| `OtherLength` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `StraighteningSummary` | `String` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `RailWayMasterLayer` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `UInt32 key` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `RailWayMasterLayer value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `UInt32 key, ref RailWayMasterLayer value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EMPTY_ID` | `UInt32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RailWayRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.RailWayRecord` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.RailWayRecord`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (21)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FullLength` | `String` | No | `` | `` |
| `IsDismantile` | `Boolean` | No | `` | `` |
| `IsGeneral` | `Boolean` | No | `` | `` |
| `IsLay` | `Boolean` | No | `` | `` |
| `LayFrom` | `String` | No | `` | `` |
| `LayLength` | `String` | No | `` | `` |
| `LayThrough` | `String` | No | `` | `` |
| `LayTo` | `String` | No | `` | `` |
| `MAXIMUM_COLUMN_COUNT` | `Int32` | Yes | `100` | `` |
| `Move2k` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |
| `RailType` | `String` | No | `` | `` |
| `RailWayDismantileColumns` | `RailWayDismantileColumn[]` | No | `` | `` |
| `RailWayDismantilePriceNames` | `String[]` | No | `` | `` |
| `RailWayLayColumn` | `RailWayLayColumn[]` | No | `` | `` |
| `RailWayLayRowPriceNames` | `String[]` | No | `` | `` |
| `Straightening` | `String` | No | `` | `` |
| `SummaryDismantile` | `String` | No | `` | `` |
| `SummaryLay` | `String` | No | `` | `` |
| `Type` | `String` | No | `` | `` |
| `UsefulLength` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `State` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.State` |
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
      - `Topomatic.Turnouts.Railways.Master.State`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dismantile` | `State` | Yes | `Dismantile` | `` |
| `Lay` | `State` | Yes | `Lay` | `` |
| `Stay` | `State` | Yes | `Stay` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Lay` | `0` |
| `Dismantile` | `1` |
| `Stay` | `2` |

**Underlying Type**: `System.Int32`

### `VolumeRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Railways.Master.VolumeRecord` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Turnouts.Railways.Master.VolumeRecord`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DrawingLinks` | `String` | No | `` | `` |
| `Formula` | `String` | No | `` | `` |
| `MainWays` | `String` | No | `` | `` |
| `Measure` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |
| `OtherWays` | `String` | No | `` | `` |
| `PriceGrown` | `String` | No | `` | `` |
| `Section` | `Int32` | No | `` | `` |
| `WorkName` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Turnouts.Style`

### `BufferStopPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.BufferStopPlanStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.BufferStopPlanStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
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

### `GridironLayerStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GridironStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.GridironStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Turnouts.Gridiron, Topomatic.Turnouts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Gridiron owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BufferStopPlanStyle` | `BufferStopPlanStyle` | `get` | No | `` |
| `JointBlockPlanStyle` | `JointBlockPlanStyle` | `get` | No | `` |
| `JointJointlessPlanStyle` | `JointJointlessPlanStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<GridironLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Gridiron` | `get/set` | No | `` |
| `SignalPlanStyle` | `SignalPlanStyle` | `get` | No | `` |
| `TurnoutControlPointsStyle` | `TurnoutControlPointsStyle` | `get` | No | `` |
| `TurnoutPlanStyle` | `TurnoutPlanStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<AlignmentStyleItem>` | `` | `` |
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

### `JointBlockPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.JointBlockPlanStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.JointBlockPlanStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
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

### `JointJointlessPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.JointJointlessPlanStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.JointJointlessPlanStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
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

### `SignalPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.SignalPlanStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.SignalPlanStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
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

### `TurnoutControlPointsStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.TurnoutControlPointsStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.TurnoutControlPointsStyle`

#### Constructors (1)

- `.ctor(GridironStyle owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `PointsSize` | `Single` | `get/set` | No | `` |
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

### `TurnoutPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Style.TurnoutPlanStyle` |
| **Base Type** | `Topomatic.Turnouts.Style.GridironLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Turnouts.Style.GridironLayerStyleItem`
        - `Topomatic.Turnouts.Style.TurnoutPlanStyle`

#### Constructors (1)

- `.ctor(GridironStyle owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `FullCentralized` | `Boolean` | `get/set` | No | `` |
| `ShowZone` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `TurnoutColor` | `CadColor` | `get/set` | No | `` |

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
| **Total Types** | 58 |
| **Classes** | 27 |
| **Interfaces** | 2 |
| **Enums** | 11 |
| **Structs** | 9 |
| **Abstract Classes** | 6 |
| **Static Classes** | 3 |
| **Total Methods** | 176 |
| **Total Properties** | 309 |
| **Total Fields** | 130 |
| **Total Events** | 0 |
| **Total Constructors** | 66 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


