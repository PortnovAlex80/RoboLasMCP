# Topomatic.Srv.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Srv.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Srv.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Srv.Core.dll` |

---
## Namespace: `Topomatic.Srv.Core`

### `SrvCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Core.SrvCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Srv.Core.SrvCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Srv.Core.Dialogs`

### `NewSurveyDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Core.Dialogs.NewSurveyDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Srv.Core.Dialogs.NewSurveyDlg`

#### Constructors (1)

- `.ctor(Surface surface)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SurveyName` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SelectSurveyDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Core.Dialogs.SelectSurveyDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
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
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Srv.Core.Dialogs.SelectSurveyDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `SurveyProxyProvider` | `Surface surface` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Srv.Core.Proxy`

### `SurveyProxyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Core.Proxy.SurveyProxyProvider` |
| **Base Type** | `Topomatic.Sfc.Proxy.GuidProxySourceProvider` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Sfc.Proxy.ProxyMoniker, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.IIconHolder, System.ComponentModel.ISupportInitialize, System.IDisposable, Topomatic.FoundationClasses.INamedObject, Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider, Topomatic.Srv.Layer.ISurveyProviderData, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Srv.Survey, Topomatic.Srv, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Proxy.ProxySourceProvider`
    - `Topomatic.Sfc.Proxy.GuidProxySourceProvider`
      - `Topomatic.Srv.Core.Proxy.SurveyProxyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HighlightedPointColor` | `Int32` | `get/set` | No | `` |
| `HighlightedStationColor` | `Int32` | `get/set` | No | `` |
| `HighlightedSurveyTraverseColor` | `Int32` | `get/set` | No | `` |
| `Icon` | `Bitmap` | `get` | No | `` |
| `IsConnected` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PointColor` | `Int32` | `get/set` | No | `` |
| `ShowSurvey` | `Boolean` | `get/set` | No | `` |
| `ShowSurveyMeasurings` | `Boolean` | `get/set` | No | `` |
| `ShowSurveyTraverses` | `Boolean` | `get/set` | No | `` |
| `ShowTacheometry` | `Boolean` | `get/set` | No | `` |
| `StationColor` | `Int32` | `get/set` | No | `` |
| `Survey` | `Survey` | `get/set` | No | `` |
| `SurveyTraverseColor` | `Int32` | `get/set` | No | `` |
| `WrappedObject` | `Survey` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInit` | `Void` | `` | `` |
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndInit` | `Void` | `` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |
| `GetSupportedMonikers` | `IEnumerable<ProxyMoniker>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryUpdateValue` | `Boolean` | `Int32 id, ref SurfacePoint point, SurfacePointExtensiveInformation information` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IIconHolder` | `get_Icon` |
| `ISupportInitialize` | `BeginInit` |
| `ISupportInitialize` | `EndInit` |
| `IDisposable` | `Dispose` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |
| `ISurveyProviderData` | `get_Survey` |
| `ISurveyProviderData` | `get_ShowSurvey` |
| `ISurveyProviderData` | `get_ShowSurveyMeasurings` |
| `ISurveyProviderData` | `get_ShowTacheometry` |
| `ISurveyProviderData` | `get_ShowSurveyTraverses` |
| `ISurveyProviderData` | `get_SurveyTraverseColor` |
| `ISurveyProviderData` | `get_HighlightedSurveyTraverseColor` |
| `ISurveyProviderData` | `get_StationColor` |
| `ISurveyProviderData` | `get_HighlightedStationColor` |
| `ISurveyProviderData` | `get_HighlightedPointColor` |
| `ISurveyProviderData` | `get_PointColor` |
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

---
## Namespace: `Topomatic.Srv.Core.Settings`

### `SurveyProxyProviderSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Core.Settings.SurveyProxyProviderSettingsFrame` |
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
                - `Topomatic.Srv.Core.Settings.SurveyProxyProviderSettingsFrame`

#### Constructors (1)

- `.ctor(SurveyProxyProvider provider)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 12 |
| **Total Properties** | 17 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


