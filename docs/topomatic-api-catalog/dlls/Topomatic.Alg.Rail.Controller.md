# Topomatic.Alg.Rail.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Rail.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v4.0.30319` |
| **Full Name** | `Topomatic.Alg.Rail.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Rail.Controller.dll` |

---
## Namespace: `Topomatic.Alg.Rail.Controller`

### `AlgRailControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.AlgRailControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Rail.Controller.AlgRailControllerPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |
| `IDisposable` | `Dispose` |

---
## Namespace: `Topomatic.Alg.Rail.Controller.Wrappers`

### `BallastDepthWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.BallastDepthWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Rail.Controller.Wrappers.BallastDepthWrapper`

#### Constructors (1)

- `.ctor(BallastDepth ballastDepth, Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanCopy` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanPaste` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Save` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Load` |
| `ISupportClipboard` | `get_AliasName` |

### `BallastSoilingWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.BallastSoilingWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Rail.Controller.Wrappers.BallastSoilingWrapper`

#### Constructors (1)

- `.ctor(BallastSoiling ballastSoiling, Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanCopy` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanPaste` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Save` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Load` |
| `ISupportClipboard` | `get_AliasName` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.SleepersDistributionWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SleepersCount` | `Int32` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |
| `Wrapper` | `SleepersDistributionWrapper` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingContainer` | `get_Stationing` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.PermanentWayWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Fastening` | `TypedObject` | `get/set` | No | `ImObjectPropertyProvider, PropertyUpdateSequence` |
| `Rail` | `TypedObject` | `get/set` | No | `ImObjectPropertyProvider, PropertyUpdateSequence` |
| `RailHeight` | `Double` | `get` | No | `` |
| `Sleeper` | `TypedObject` | `get/set` | No | `ImObjectPropertyProvider` |
| `SleeperDeepening` | `Double` | `get` | No | `` |
| `SleeperH` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |
| `TiePlateBot` | `Double` | `get` | No | `` |
| `TiePlateMid` | `Double` | `get` | No | `` |
| `TiePlateTop` | `Double` | `get` | No | `` |
| `Wrapper` | `PermanentWayWrapper` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingContainer` | `get_Stationing` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.BallastDepthWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BallastDepth` | `Double` | `get/set` | No | `DefaultDouble` |
| `Station` | `Double` | `get/set` | No | `PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingContainer` | `get_Stationing` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.BallastSoilingWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BallastSoiling` | `Double` | `get/set` | No | `DefaultDouble` |
| `Station` | `Double` | `get/set` | No | `PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingContainer` | `get_Stationing` |

### `PermanentWayWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.PermanentWayWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Rail.Controller.Wrappers.PermanentWayWrapper`

#### Constructors (1)

- `.ctor(Alignment alignment, PermanentWay permanentWay)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanCopy` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanPaste` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Save` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Load` |
| `ISupportClipboard` | `get_AliasName` |

### `SleepersDistributionWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.SleepersDistributionWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Rail.Controller.Wrappers.SleepersDistributionWrapper`

#### Constructors (1)

- `.ctor(Alignment alignment, SleepersDistribution sleepersDistribution)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Nested Types (1)

- `ItemWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanCopy` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.get_CanPaste` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Save` |
| `ISupportClipboard` | `Topomatic.ComponentModel.ISupportClipboard.Load` |
| `ISupportClipboard` | `get_AliasName` |

### `VirageWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Controller.Wrappers.VirageWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Virage virage)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BallastOffset` | `Double` | `get/set` | No | `Length` |
| `Direction` | `VirageDirection` | `get/set` | No | `PropertyTypeConverter` |
| `Elevation` | `Double` | `get/set` | No | `Length` |
| `EndStation` | `Double` | `get/set` | No | `PropertyProvider` |
| `L1` | `Double` | `get/set` | No | `Length` |
| `L2` | `Double` | `get/set` | No | `Length` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `Length` |
| `R` | `Double` | `get/set` | No | `ReadOnly, Radius` |
| `StartStation` | `Double` | `get/set` | No | `PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |
| `Velocity` | `Double` | `get/set` | No | `Length` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingContainer` | `get_Stationing` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 10 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 14 |
| **Total Properties** | 50 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 6 |
| **Nested Types** | 4 |
| **Extension Methods** | 0 |


