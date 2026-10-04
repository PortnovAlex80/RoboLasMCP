# Topomatic.Pipes.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Pipes.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Pipes.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Pipes.Core.dll` |

---
## Namespace: `Topomatic.Pipes.Core`

### `PipeNetworkCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.PipeNetworkCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Pipes.Core.PipeNetworkCorePluginHost`

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

### `PipePrfDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.PipePrfDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Pipes.Core.PipePrfDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlanCrossDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.PlanCrossDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Pipes.Core.PlanCrossDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Pipes.Core.Design`

### `PnCrsSectionNameWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Design.PnCrsSectionNameWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnCrsSectionBase crsItem)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Section` | `PnCrsSectionBase` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

---
## Namespace: `Topomatic.Pipes.Core.Dialogs`

### `AcceptableDistancesDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Dialogs.AcceptableDistancesDlg` |
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
                - `Topomatic.Pipes.Core.Dialogs.AcceptableDistancesDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `PipeNetwork network` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrossingsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Dialogs.CrossingsDlg` |
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
                - `Topomatic.Pipes.Core.Dialogs.CrossingsDlg`

#### Constructors (1)

- `.ctor(PipeNetwork network, Boolean hightligthSelected)`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `CadView cadView, PipeNetwork network, List<KeyValuePair<String PipesCrossing>> pipesCrossings, Boolean highLightSelected` | `` |

#### Nested Types (1)

- `CrossingsWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CrossingsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Dialogs.CrossingsDlg+CrossingsWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Pipes.Core.Dialogs.CrossingsDlg+CrossingsWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetwork network, List<KeyValuePair<String PipesCrossing>> crossings, PnEiPlanCrossAtPipeController controller)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get/set` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |

---
## Namespace: `Topomatic.Pipes.Core.GridPanel`

### `GridLayerUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.GridPanel.GridLayerUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ProjectPoint` | `Point` | `CadView cadView, Vector2D position` | `` |

### `GridPanelPipesPaintEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.GridPanel.GridPanelPipesPaintEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs`
        - `Topomatic.Pipes.Core.GridPanel.GridPanelPipesPaintEventArgs`

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork, CadView cadView, Rectangle clientBounds, Graphics graphics, Font font, Boolean isWhiteBackColor)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

---
## Namespace: `Topomatic.Pipes.Core.ServiceClasses`

### `UserControlTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.ServiceClasses.UserControlTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddItemsToComboBox` | `Void` | `ComboBox cmb, Type enumType, BaseEnumConverter converter` | `` |

---
## Namespace: `Topomatic.Pipes.Core.Settings`

### `PipeNetworkGeneralDefaultParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Settings.PipeNetworkGeneralDefaultParams` |
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
                - `Topomatic.Pipes.Core.Settings.PipeNetworkGeneralDefaultParams`

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork, Action refreshAllCaches)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeNetworkModelSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Core.Settings.PipeNetworkModelSettings` |
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
                - `Topomatic.Pipes.Core.Settings.PipeNetworkModelSettings`

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork, Action refreshAllCaches)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 12 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 10 |
| **Total Properties** | 5 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 10 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


