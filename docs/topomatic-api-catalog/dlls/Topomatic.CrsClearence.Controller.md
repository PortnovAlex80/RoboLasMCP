# Topomatic.CrsClearence.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.CrsClearence.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.CrsClearence.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.CrsClearence.Controller.dll` |

---
## Namespace: `Topomatic.CrsClearence.Controller`

### `CrsPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.CrsClearence.Controller.CrsPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.CrsClearence.Controller.CrsPluginHost`

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

### `PltCrsFieldCrsClearence` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.CrsClearence.Controller.PltCrsFieldCrsClearence` |
| **Base Type** | `Topomatic.Plt.Templates.Crs.CrsField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Crs.CrsField`
      - `Topomatic.CrsClearence.Controller.PltCrsFieldCrsClearence`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.CrsClearence.Controller.SettingsEnum`

### `VoltageType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.CrsClearence.Controller.SettingsEnum.VoltageType` |
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
      - `Topomatic.CrsClearence.Controller.SettingsEnum.VoltageType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HightVoltage` | `VoltageType` | Yes | `HightVoltage` | `` |
| `LowVoltage` | `VoltageType` | Yes | `LowVoltage` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `HightVoltage` | `0` |
| `LowVoltage` | `1` |

**Underlying Type**: `System.Int32`

### `WayType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.CrsClearence.Controller.SettingsEnum.WayType` |
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
      - `Topomatic.CrsClearence.Controller.SettingsEnum.WayType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AccessRoad` | `WayType` | Yes | `AccessRoad` | `` |
| `StationAndStop` | `WayType` | Yes | `StationAndStop` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `StationAndStop` | `0` |
| `AccessRoad` | `1` |

**Underlying Type**: `System.Int32`

### `WayWidth` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.CrsClearence.Controller.SettingsEnum.WayWidth` |
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
      - `Topomatic.CrsClearence.Controller.SettingsEnum.WayWidth`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LargeWidth` | `WayWidth` | Yes | `LargeWidth` | `` |
| `SmallWidth` | `WayWidth` | Yes | `SmallWidth` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SmallWidth` | `0` |
| `LargeWidth` | `1` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 3 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 1 |
| **Total Properties** | 0 |
| **Total Fields** | 9 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


