# Topomatic.Soilworks.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Soilworks.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Soilworks.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Soilworks.Core.dll` |

---
## Namespace: `Topomatic.Soilworks.Controller.Design`

### `MaterialsListConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Controller.Design.MaterialsListConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Soilworks.Controller.Design.MaterialsListConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

---
## Namespace: `Topomatic.Soilworks.Core`

### `SoilworksCoreModule` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.SoilworksCoreModule` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginInitializator`
    - `Topomatic.Soilworks.Core.SoilworksCoreModule`

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

### `SoilworksCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.SoilworksCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Soilworks.Core.SoilworksCorePluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SoilworksModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.SoilworksModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Soilworks.ISoilworksContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Soilworks.Core.SoilworksModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Soilworks` | `Soilworks` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISoilworksContainer` | `get_Soilworks` |

---
## Namespace: `Topomatic.Soilworks.Core.Design`

### `LossCoeffDistConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Design.LossCoeffDistConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Soilworks.Core.Design.LossCoeffDistConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `MaterialsListEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Design.MaterialsListEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Soilworks.Core.Design.MaterialsListEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SectorTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Design.SectorTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Soilworks.Core.Design.SectorTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Soilworks.Core.Dialogs`

### `SelectMaterialsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Dialogs.SelectMaterialsDlg` |
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
                - `Topomatic.Soilworks.Core.Dialogs.SelectMaterialsDlg`

#### Constructors (1)

- `.ctor(Material[] materials, Material[] selectedMaterial)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SelectedMaterials` | `Material[]` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Core.Settings`

### `ApplicabilitiesSettingsControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.ApplicabilitiesSettingsControl` |
| **Base Type** | `Topomatic.Soilworks.Core.Settings.SettingsBaseControl` |
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
              - `Topomatic.Soilworks.Core.Settings.SettingsBaseControl`
                - `Topomatic.Soilworks.Core.Settings.ApplicabilitiesSettingsControl`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `Soilworks soilworks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GeneralSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.GeneralSettingsFrame` |
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
                - `Topomatic.Soilworks.Core.Settings.GeneralSettingsFrame`

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HaulageTypesSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.HaulageTypesSettingsFrame` |
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
                - `Topomatic.Soilworks.Core.Settings.HaulageTypesSettingsFrame`

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParticipantsSettingsControlRail` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsControlRail` |
| **Base Type** | `Topomatic.Soilworks.Core.Settings.SettingsBaseControl` |
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
              - `Topomatic.Soilworks.Core.Settings.SettingsBaseControl`
                - `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsControlRail`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `Soilworks soilworks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParticipantsSettingsControlRoad` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsControlRoad` |
| **Base Type** | `Topomatic.Soilworks.Core.Settings.SettingsBaseControl` |
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
              - `Topomatic.Soilworks.Core.Settings.SettingsBaseControl`
                - `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsControlRoad`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `Soilworks soilworks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ParticipantsSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsFrame` |
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
                - `Topomatic.Soilworks.Core.Settings.ParticipantsSettingsFrame`

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SettingsBaseControl` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Settings.SettingsBaseControl` |
| **Base Type** | `System.Windows.Forms.UserControl` |
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
              - `Topomatic.Soilworks.Core.Settings.SettingsBaseControl`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Void` | `` | `` |
| `Init` | `Void` | `Soilworks soilworks` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Soilworks.Core.Wrappers`

### `ApplicabilitiesWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Wrappers.ApplicabilitiesWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Core.Wrappers.ApplicabilitiesWrapper`

#### Constructors (1)

- `.ctor(Soilworks soilworks)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
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
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ItemWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Wrappers.TemplateItemsWrapper+ItemWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Soilworks.IApplicabilitiyStateWrapperContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(TemplateItem soilworksTempalteItem)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ApplicabilityStateWrappers` | `ApplicabilityStateWrapper[]` | `get/set` | No | `PropertyTypeConverter, DefaultWidth, PropertyEditor, ConditionalReadOnly` |
| `Code` | `Int32` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `ByLayer, ByBlock, DefaultWidth` |
| `Name` | `String` | `get/set` | No | `` |
| `SoilworksTemplateItem` | `TemplateItem` | `get` | No | `Browsable` |
| `SummSides` | `Boolean` | `get/set` | No | `` |
| `Type` | `SectorType` | `get/set` | No | `PropertyTypeConverter, DefaultWidth` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IApplicabilitiyStateWrapperContainer` | `get_ApplicabilityStateWrappers` |
| `IApplicabilitiyStateWrapperContainer` | `set_ApplicabilityStateWrappers` |

### `TemplateItemsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Core.Wrappers.TemplateItemsWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Soilworks.Core.Wrappers.TemplateItemsWrapper`

#### Constructors (1)

- `.ctor(ITemplateItemsContainer templateItemsContainer, TemplateItemModelType modelType)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Soilworks` | `Soilworks` | `get` | No | `` |

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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 18 |
| **Classes** | 18 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 22 |
| **Total Properties** | 14 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 18 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


