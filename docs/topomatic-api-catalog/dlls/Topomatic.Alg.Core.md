# Topomatic.Alg.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Core.dll` |

---
## Namespace: `Topomatic.Alg.Core`

### `AlgCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Core.AlgCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Core.AlgCorePluginHost`

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

### `AlignmentModelEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Core.AlignmentModelEditor` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.PlanModelEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.PlanModelEditor`
      - `Topomatic.Alg.Core.AlignmentModelEditor`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHardReferences` | `ModelHardReference[]` | `IProjectModel model` | `` |
| `LoadFromFile` | `Object` | `String fullpath` | `` |
| `Open` | `IEditorResult` | `IProjectModel model` | `` |
| `ReplaceObjectHardReference` | `Void` | `Object model, URI oldValue, URI newValue` | `` |
| `ResolveConflict` | `Object` | `IProjectModel model, Object origin, Object local, Object remote, LogWriter writer` | `` |
| `SaveToFile` | `Void` | `Object model, String fullpath` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `StaticGeologyCrsCompoundId` | `Guid` | Yes | `` | `` |
| `StaticGeologyPrfCompoundId` | `Guid` | Yes | `` | `` |

---
## Namespace: `Topomatic.Alg.Core.Settings`

### `AlignmentsSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Core.Settings.AlignmentsSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossSectionVerticalScale` | `Double` | `get/set` | No | `` |
| `Current` | `AlignmentsSettings` | `get` | Yes | `` |
| `ProfileVerticalScale` | `Double` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPanelSettings` | `PanelSettings` | `String alias` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `` | `` |

#### Nested Types (1)

- `PanelSettings` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PanelSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Core.Settings.AlignmentsSettings+PanelSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FontEmSize` | `Single` | `get/set` | No | `` |
| `FontFamily` | `String` | `get/set` | No | `` |
| `FontGdiCharSet` | `Byte` | `get/set` | No | `` |
| `FontGdiVerticalFont` | `Boolean` | `get/set` | No | `` |
| `FontStyle` | `FontStyle` | `get/set` | No | `` |
| `FontUnit` | `GraphicsUnit` | `get/set` | No | `` |

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
## Namespace: `Topomatic.Alg.Core.Structure`

### `ProfileCoreItem`1<T where StaticProfile, INamedTransactable, ITransactable, IUpdatable, IAlignmentContainer, IProfile, ITransitionContainer, IOwned, ICollection`1, IEnumerable`1, IEnumerable, IList`1, class, StaticProfile>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Core.Structure.ProfileCoreItem`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreItemResolver`
    - ``
      - `Topomatic.Alg.Core.Structure.ProfileCoreItem`1`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 3 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 0 |
| **Total Methods** | 17 |
| **Total Properties** | 9 |
| **Total Fields** | 2 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


