# Topomatic.Sites.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sites.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sites.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sites.Core.dll` |

---
## Namespace: `Topomatic.Sites.Core`

### `SiteModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.SiteModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Dwg.IDrawingContainer, Topomatic.Sfc.ITerrainModel, Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IReferenceHolder, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Sfc.IEgContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Sites.ISiteContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Sites.Core.SiteModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get` | No | `` |
| `EgSurfaces` | `IEnumerable<Surface>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Site` | `Site` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSurface` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetReferences` | `IEnumerable<String>` | `` | `` |
| `InvalidateSurface` | `Void` | `` | `` |
| `LoadFromFile` | `Void` | `String fullpath` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToFile` | `Void` | `String fullpath` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |
| `UpdateSurface` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"site"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDrawingContainer` | `get_Drawing` |
| `ISurfaceContainer` | `get_Surface` |
| `IReferenceHolder` | `GetReferences` |
| `IDisposable` | `Dispose` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEgContainer` | `get_EgSurfaces` |
| `IStateElevationProviderFactory` | `Topomatic.Cad.Foundation.IStateElevationProviderFactory.CreateProvider` |
| `ISiteContainer` | `get_Site` |

### `SitesCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.SitesCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Sites.Core.SitesCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Sites.Core.Layers`

### `SitePlanCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.Layers.SitePlanCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Sfc.ISurfaceContainer, Topomatic.Dwg.IDrawingContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Sites.Core.Layers.SitePlanCompoundLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `SiteModel` | `SiteModel` | `get/set` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `Invalidate3d` | `Void` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayers` | `IEnumerable<SitePlanCompoundLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `GetSubLayers` |
| `ISurfaceContainer` | `get_Surface` |
| `IDrawingContainer` | `get_Drawing` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

---
## Namespace: `Topomatic.Sites.Core.Settings`

### `SiteDtmSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.Settings.SiteDtmSettings` |
| **Base Type** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.UserControl`
              - `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel`
                - `Topomatic.Sites.Core.Settings.SiteDtmSettings`

#### Constructors (1)

- `.ctor(Site site, URI folderUri)`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FilterModels` | `IEnumerable<KeyValuePair<String Boolean>>` | `String[] modelTypes, URI folderUri, String currentRelativePath, IList<String> relativePaths` | `` |
| `FilterSurfaces` | `IEnumerable<KeyValuePair<String Boolean>>` | `URI folderUri, String currentRelativePath, IList<String> relativePaths` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SitePropertiesSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.Settings.SitePropertiesSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Site site, URI folderUri)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

---
## Namespace: `Topomatic.Sites.Core.Tools`

### `SiteCoreTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Core.Tools.SiteCoreTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindSurfaces` | `Boolean` | `IProjectModel model, IList<String> paths, IList<Surface> result` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 21 |
| **Total Properties** | 10 |
| **Total Fields** | 2 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


