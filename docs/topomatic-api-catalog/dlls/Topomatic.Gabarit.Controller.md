# Topomatic.Gabarit.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Gabarit.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Gabarit.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Gabarit.Controller.dll` |

---
## Namespace: `Topomatic.Gabarit.Controller`

### `GabaritControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.GabaritControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Gabarit.Controller.GabaritControllerPluginHost`

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
## Namespace: `Topomatic.Gabarit.Controller.Layers`

### `GabaritItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Layers.GabaritPlanLayer+GabaritItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ControlPositions` | `List<KeyValuePair<Vector3D Double>>` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsWrong` | `Boolean` | No | `` | `` |
| `PointIndex` | `Int32` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

### `GabaritPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Layers.GabaritPlanLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Gabarit.Controller.Layers.GabaritPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Gabarits` | `IList<GabaritItem>` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Id` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GabaritItem` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Namespace: `Topomatic.Gabarit.Controller.Settings`

### `GabaritCommonEnvironmentSettingsFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Settings.GabaritCommonEnvironmentSettingsFrame` |
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
                - `Topomatic.Gabarit.Controller.Settings.GabaritCommonEnvironmentSettingsFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Gabarit.Controller.Style`

### `GabaritPlanDrawStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Style.GabaritPlanDrawStyle` |
| **Base Type** | `Topomatic.Gabarit.Controller.Style.GabaritStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Gabarit.Controller.Style.GabaritStyle, Topomatic.Gabarit.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Gabarit.Controller.Style.GabaritStyleItem`
    - `Topomatic.Gabarit.Controller.Style.GabaritPlanDrawStyle`

#### Constructors (1)

- `.ctor(GabaritStyle owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawCircle` | `Boolean` | `get/set` | No | `` |
| `DrawLines` | `Boolean` | `get/set` | No | `` |
| `LimitDistance` | `Double` | `get/set` | No | `` |
| `TextColor` | `CadColor` | `get/set` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `GabaritPlanDrawStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GabaritStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Style.GabaritStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Gabarit.Controller.Style.GabaritStyleItem, Topomatic.Gabarit.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<GabaritStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `GabaritStyleItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Style.GabaritStyleItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Gabarit.Controller.Style.GabaritStyle, Topomatic.Gabarit.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GabaritStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `GabaritStyle` | `get/set` | No | `` |

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
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |

### `GeneralGabaritStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Gabarit.Controller.Style.GeneralGabaritStyle` |
| **Base Type** | `Topomatic.Gabarit.Controller.Style.GabaritStyle` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Gabarit.Controller.Style.GabaritStyleItem, Topomatic.Gabarit.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Gabarit.Controller.Style.GabaritStyle`
    - `Topomatic.Gabarit.Controller.Style.GeneralGabaritStyle`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PlanDrawStyle` | `GabaritPlanDrawStyle` | `get` | No | `` |

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
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 8 |
| **Classes** | 6 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 2 |
| **Static Classes** | 0 |
| **Total Methods** | 12 |
| **Total Properties** | 14 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 8 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


