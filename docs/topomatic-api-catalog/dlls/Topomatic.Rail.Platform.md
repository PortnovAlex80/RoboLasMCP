# Topomatic.Rail.Platform

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Rail.Platform` |
| **Version** | `0.0.0.0` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Rail.Platform, Version=0.0.0.0, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Rail.Platform.dll` |

---
## Namespace: `Topomatic.Rail.Platform`

### `PlatformModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.PlatformModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Plugins.IAlignmentPluginInitializator, Topomatic.Alg.Layers.Plugins.IAlignmentPluginLayersInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Rail.Platform.PlatformModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeAlignment` | `Void` | `Alignment alignment` | `` |
| `ClosePlugins` | `Void` | `Alignment alignment` | `` |
| `CreatePlanLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreatePlugins` | `Void` | `Alignment alignment` | `` |
| `CreateProfileLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreateSectionLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `Initialize` | `Void` | `PluginFactory factory` | `` |
| `MergePlugins` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |
| `IAlignmentPluginInitializator` | `CreatePlugins` |
| `IAlignmentPluginInitializator` | `ChangeAlignment` |
| `IAlignmentPluginInitializator` | `ClosePlugins` |
| `IAlignmentPluginInitializator` | `MergePlugins` |
| `IAlignmentPluginLayersInitializator` | `CreatePlanLayers` |
| `IAlignmentPluginLayersInitializator` | `CreateProfileLayers` |
| `IAlignmentPluginLayersInitializator` | `CreateSectionLayers` |

### `PlatformObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.PlatformObject` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.IStationingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Rail.Platform.PlatformObject`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(PlatformObject pObject, Object parent)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `Browsable` |
| `Dimension` | `Double` | `get/set` | No | `` |
| `IsChanged` | `Boolean` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `Browsable, PropertyUpdateSequence` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `PlateLength` | `Double` | `get/set` | No | `` |
| `PlatesCount` | `Int32` | `get/set` | No | `` |
| `PlatformLength` | `Double` | `get` | No | `Browsable` |
| `PlatformSide` | `PlatformSide` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `Rotation` | `Double` | `get/set` | No | `Browsable` |
| `Station` | `Double` | `get/set` | No | `PropertyUpdateSequence, PropertyProvider` |
| `Stationing` | `IAlgStationing` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStationingContainer` | `get_Stationing` |

### `PlatformPlugin` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.PlatformPlugin` |
| **Base Type** | `Topomatic.Alg.Plugins.AlignmentPlugin` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Plugins.AlignmentPlugin`
        - `Topomatic.Rail.Platform.PlatformPlugin`

#### Constructors (1)

- `.ctor(Object obj)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `PlatformObjects` | `IList<PlatformObject>` | `get` | No | `` |
| `VisualEmpty` | `Boolean` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `UID` | `String` | Yes | `"Platform"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `PlatformPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.PlatformPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Rail.Platform.PlatformPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PluginFactory factory` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPluginInitializator` | `Initialize` |

### `PlatformSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.PlatformSide` |
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
      - `Topomatic.Rail.Platform.PlatformSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `PlatformSide` | Yes | `Left` | `` |
| `Right` | `PlatformSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Right` | `0` |
| `Left` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Rail.Platform.Drawers`

### `PlatformDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.Drawers.PlatformDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadView cadView, DeviceContext context, PlatformObject platformObject, Boolean enabled` | `` |
| `GetGrips` | `IEnumerable<IGrip>` | `PlatformObject platformObject, CadView cadView` | `` |
| `GetLimits` | `Boolean` | `PlatformObject platformObject, ref BoundingBox2D limits` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawPlatform` | `Void` | `CadView cadView, DeviceContext dc, Boolean enable, PlatformObject platformObject, Alignment alignment` | `` |

#### Nested Types (1)

- `PlatformPositionGrip` (class)

### `PlatformPositionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Rail.Platform.Drawers.PlatformDrawer+PlatformPositionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Rail.Platform.Drawers.PlatformDrawer+PlatformPositionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, PlatformObject platformObject)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayersExtensions` | `Object` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 7 |
| **Classes** | 6 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 18 |
| **Total Properties** | 17 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 7 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


