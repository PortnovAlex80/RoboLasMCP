# Topomatic.Alg.Road.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.Core.dll` |

---
## Namespace: `Topomatic.Alg.Road.Core`

### `RoadCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.RoadCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Road.Core.RoadCorePluginHost`

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

### `RoadModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.RoadModel` |
| **Base Type** | `Topomatic.Alg.Model.AlignmentModel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ISurfaceContainer, Topomatic.Alg.IAlignmentContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.IChordCurve` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Alg.Model.AlignmentModel`
          - `Topomatic.Alg.Road.Core.RoadModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSurface` | `Void` | `Surface surface, Boolean forced` | `` |
| `GetChord` | `IStationingCurve` | `Int32 chord` | `` |
| `RefreshRelativePaths` | `Void` | `URI folderUri` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IChordCurve` | `GetChord` |

---
## Namespace: `Topomatic.Alg.Road.Core.Plt`

### `TrayNumber` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.Plt.TrayNumber` |
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
      - `Topomatic.Alg.Road.Core.Plt.TrayNumber`

#### Fields (19)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left1` | `TrayNumber` | Yes | `Left1` | `` |
| `Left2` | `TrayNumber` | Yes | `Left2` | `` |
| `Left3` | `TrayNumber` | Yes | `Left3` | `` |
| `Left4` | `TrayNumber` | Yes | `Left4` | `` |
| `Left5` | `TrayNumber` | Yes | `Left5` | `` |
| `Left6` | `TrayNumber` | Yes | `Left6` | `` |
| `Left7` | `TrayNumber` | Yes | `Left7` | `` |
| `Left8` | `TrayNumber` | Yes | `Left8` | `` |
| `LeftDitch` | `TrayNumber` | Yes | `LeftDitch` | `` |
| `Right1` | `TrayNumber` | Yes | `Right1` | `` |
| `Right2` | `TrayNumber` | Yes | `Right2` | `` |
| `Right3` | `TrayNumber` | Yes | `Right3` | `` |
| `Right4` | `TrayNumber` | Yes | `Right4` | `` |
| `Right5` | `TrayNumber` | Yes | `Right5` | `` |
| `Right6` | `TrayNumber` | Yes | `Right6` | `` |
| `Right7` | `TrayNumber` | Yes | `Right7` | `` |
| `Right8` | `TrayNumber` | Yes | `Right8` | `` |
| `RightDitch` | `TrayNumber` | Yes | `RightDitch` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left1` | `1` |
| `Right1` | `2` |
| `Left2` | `3` |
| `Right2` | `4` |
| `Left3` | `5` |
| `Right3` | `6` |
| `Left4` | `7` |
| `Right4` | `8` |
| `Left5` | `9` |
| `Right5` | `10` |
| `Left6` | `11` |
| `Right6` | `12` |
| `Left7` | `13` |
| `Right7` | `14` |
| `Left8` | `15` |
| `Right8` | `16` |
| `LeftDitch` | `17` |
| `RightDitch` | `18` |

**Underlying Type**: `System.Int32`

### `TrayNumberConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.Plt.TrayNumberConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Road.Core.Plt.TrayNumberConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Road.Core.Settings`

### `RoadCrossSectionManagerSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.Settings.RoadCrossSectionManagerSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `RoadCrossSectionManagerSettings` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `RoadProfileManagerSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Core.Settings.RoadProfileManagerSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `RoadProfileManagerSettings` | `get` | Yes | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 14 |
| **Total Properties** | 2 |
| **Total Fields** | 19 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


