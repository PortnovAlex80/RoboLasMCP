# Topomatic.Its.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Its.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Its.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Its.Core.dll` |

---
## Namespace: `Topomatic.Its.Core`

### `ItsCoreModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Core.ItsCoreModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Plugins.IAlignmentPluginInitializator, Topomatic.Alg.Layers.Plugins.IAlignmentPluginLayersInitializator, Topomatic.Alg.Plugins.IAlignmentPluginRelativePathsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Its.Core.ItsCoreModule`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SerializationKey` | `String` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeAlignment` | `Void` | `Alignment alignment` | `` |
| `ClosePlugins` | `Void` | `Alignment alignment` | `` |
| `CreatePlanLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreatePlugins` | `Void` | `Alignment alignment` | `` |
| `CreateProfileLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `CreateSectionLayers` | `Void` | `Alignment alignment, AlgCompoundLayer compoundLayer` | `` |
| `GetRelativePaths` | `Void` | `Alignment alignment, IList<String> paths` | `` |
| `MergePlugins` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |
| `RefreshRelativePath` | `Void` | `Alignment alignment, URI folderUri` | `` |
| `ReplaceRelativePath` | `Void` | `Alignment alignment, String oldValue, String newValue` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentPluginInitializator` | `CreatePlugins` |
| `IAlignmentPluginInitializator` | `ChangeAlignment` |
| `IAlignmentPluginInitializator` | `ClosePlugins` |
| `IAlignmentPluginInitializator` | `MergePlugins` |
| `IAlignmentPluginLayersInitializator` | `CreatePlanLayers` |
| `IAlignmentPluginLayersInitializator` | `CreateProfileLayers` |
| `IAlignmentPluginLayersInitializator` | `CreateSectionLayers` |
| `IAlignmentPluginRelativePathsContainer` | `RefreshRelativePath` |
| `IAlignmentPluginRelativePathsContainer` | `GetRelativePaths` |
| `IAlignmentPluginRelativePathsContainer` | `ReplaceRelativePath` |

### `ItsCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Its.Core.ItsCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Its.Core.ItsCorePluginHost`

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 11 |
| **Total Properties** | 1 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


