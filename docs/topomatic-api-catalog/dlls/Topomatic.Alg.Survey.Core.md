# Topomatic.Alg.Survey.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Survey.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Survey.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Survey.Core.dll` |

---
## Namespace: `Topomatic.Alg.Survey.Core`

### `SurveyCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Core.SurveyCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Survey.Core.SurveyCorePluginHost`

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

### `SurveyModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Core.SurveyModel` |
| **Base Type** | `Topomatic.Alg.Model.AlignmentModel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ISurfaceContainer, Topomatic.Alg.IAlignmentContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
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
          - `Topomatic.Alg.Survey.Core.SurveyModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSurface` | `Void` | `Surface surface, Boolean forced` | `` |
| `RefreshRelativePaths` | `Void` | `URI folderUri` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Survey.Core.Settings`

### `SurveyCrossSectionManagerSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Core.Settings.SurveyCrossSectionManagerSettings` |
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
| `Current` | `SurveyCrossSectionManagerSettings` | `get` | Yes | `` |

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

### `SurveyProfileManagerSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Core.Settings.SurveyProfileManagerSettings` |
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
| `Current` | `SurveyProfileManagerSettings` | `get` | Yes | `` |

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
| **Total Types** | 4 |
| **Classes** | 4 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 13 |
| **Total Properties** | 2 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 4 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


