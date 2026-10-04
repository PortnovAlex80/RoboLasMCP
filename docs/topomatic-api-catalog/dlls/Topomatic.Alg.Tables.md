# Topomatic.Alg.Tables

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Tables` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Tables, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Tables.dll` |

---
## Namespace: `Topomatic.Alg.Tables`

### `BaseAreasAndVolumes` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.BaseAreasAndVolumes` |
| **Base Type** | `Topomatic.Alg.Tables.TemplateStationingSheet` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Alg.Tables.IStationingUserSheet, Topomatic.Alg.IStationingContainer, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.UserSheet`
    - `Topomatic.Tables.Export.TemplateSheet`
      - `Topomatic.Alg.Tables.TemplateStationingSheet`
        - `Topomatic.Alg.Tables.BaseAreasAndVolumes`

#### Constructors (1)

- `.ctor(String id, String caption, String defaultName, Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `GenerateOnlySelected` | `Boolean` | `get/set` | No | `` |
| `Stationing` | `IAlgStationing` | `get` | No | `` |
| `Type` | `SheetType` | `get/set` | No | `` |

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
| `IStationingContainer` | `get_Stationing` |
| `IAlignmentContainer` | `get_Alignment` |

### `ExcludedVolumesFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.ExcludedVolumesFrame` |
| **Base Type** | `Topomatic.Tables.Export.UserSheetWizardFrame` |
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
              - `Topomatic.Tables.Export.UserSheetWizardFrame`
                - `Topomatic.Alg.Tables.ExcludedVolumesFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IStationingUserSheet` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.IStationingUserSheet` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Alg.IStationingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `All` | `Boolean` | `get/set` | No | `` |
| `FromStation` | `Double` | `get/set` | No | `` |
| `ToStation` | `Double` | `get/set` | No | `` |

### `SheetType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.SheetType` |
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
      - `Topomatic.Alg.Tables.SheetType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByCrossSections` | `SheetType` | Yes | `ByCrossSections` | `` |
| `ByKilometers` | `SheetType` | Yes | `ByKilometers` | `` |
| `ByPickets` | `SheetType` | Yes | `ByPickets` | `` |
| `Common` | `SheetType` | Yes | `Common` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ByCrossSections` | `0` |
| `ByPickets` | `1` |
| `ByKilometers` | `2` |
| `Common` | `3` |

**Underlying Type**: `System.Int32`

### `ShtSetting` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.ShtSetting` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ExcludedVolumes` | `ExcludedVolumesCollection` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Settings` | `Dictionary<Guid ShtSetting>` | Yes | `` | `` |

#### Nested Types (1)

- `ShtSettingsSerializer` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ShtSettingsSerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.ShtSetting+ShtSettingsSerializer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

### `StationingUserSheet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.StationingUserSheet` |
| **Base Type** | `Topomatic.Tables.Export.UserSheet` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Alg.Tables.IStationingUserSheet, Topomatic.Alg.IStationingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.UserSheet`
    - `Topomatic.Alg.Tables.StationingUserSheet`

#### Constructors (1)

- `.ctor(String id, String caption, String defaultName)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `All` | `Boolean` | `get/set` | No | `` |
| `FromStation` | `Double` | `get/set` | No | `` |
| `Stationing` | `IAlgStationing` | `get` | No | `` |
| `ToStation` | `Double` | `get/set` | No | `` |

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
| `IStationingUserSheet` | `get_FromStation` |
| `IStationingUserSheet` | `set_FromStation` |
| `IStationingUserSheet` | `get_ToStation` |
| `IStationingUserSheet` | `set_ToStation` |
| `IStationingUserSheet` | `get_All` |
| `IStationingUserSheet` | `set_All` |
| `IStationingContainer` | `get_Stationing` |

### `StationingUserSheetFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.StationingUserSheetFrame` |
| **Base Type** | `Topomatic.Tables.Export.UserSheetWizardFrame` |
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
              - `Topomatic.Tables.Export.UserSheetWizardFrame`
                - `Topomatic.Alg.Tables.StationingUserSheetFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnFinallize` | `Boolean` | `UserSheet sheet` | `` |
| `OnInitialize` | `Void` | `UserSheet sheet` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TemplateStationingSheet` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Tables.TemplateStationingSheet` |
| **Base Type** | `Topomatic.Tables.Export.TemplateSheet` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Alg.Tables.IStationingUserSheet, Topomatic.Alg.IStationingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.UserSheet`
    - `Topomatic.Tables.Export.TemplateSheet`
      - `Topomatic.Alg.Tables.TemplateStationingSheet`

#### Constructors (1)

- `.ctor(String id, String caption, String defaultName)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `All` | `Boolean` | `get/set` | No | `` |
| `FromStation` | `Double` | `get/set` | No | `` |
| `Stationing` | `IAlgStationing` | `get` | No | `` |
| `ToStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFrame` | `UserSheetWizardFrame` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable<Object>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareExcluded` | `IntervalSearcher` | `Alignment alignment` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IStationingUserSheet` | `get_FromStation` |
| `IStationingUserSheet` | `set_FromStation` |
| `IStationingUserSheet` | `get_ToStation` |
| `IStationingUserSheet` | `set_ToStation` |
| `IStationingUserSheet` | `get_All` |
| `IStationingUserSheet` | `set_All` |
| `IStationingContainer` | `get_Stationing` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 9 |
| **Classes** | 4 |
| **Interfaces** | 1 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 3 |
| **Static Classes** | 0 |
| **Total Methods** | 17 |
| **Total Properties** | 18 |
| **Total Fields** | 6 |
| **Total Events** | 0 |
| **Total Constructors** | 7 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


