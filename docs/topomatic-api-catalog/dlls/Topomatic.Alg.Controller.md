# Topomatic.Alg.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Controller.dll` |

---
## Namespace: `Topomatic.Alg.Controller`

### `AlgControllerPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Controller.AlgControllerPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Controller.AlgControllerPluginHost`

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
## Namespace: `Topomatic.Alg.Controller.Plt`

### `PltPrfWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Controller.Plt.PltPrfWizardController` |
| **Base Type** | `Topomatic.Plt.PltSimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`
      - `Topomatic.Alg.Controller.Plt.PltPrfWizardController`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator g, WizardFrame[] frames)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GoNext` | `Void` | `` | `` |
| `GoPrevious` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWizardController` | `GoNext` |
| `IWizardController` | `GoPrevious` |

---
## Namespace: `Topomatic.Alg.Controller.Tools`

### `SimplePlanItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Controller.Tools.SimplePlanItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Controller.Tools.SimplePlanItem`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Length` | `Double` | No | `` | `` |
| `RadiusIn` | `Double` | No | `` | `` |
| `RadiusOut` | `Double` | No | `` | `` |

### `SquaredSurfaceType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Controller.Tools.SquaredSurfaceType` |
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
      - `Topomatic.Alg.Controller.Tools.SquaredSurfaceType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Sections` | `SquaredSurfaceType` | Yes | `Sections` | `` |
| `Step` | `SquaredSurfaceType` | Yes | `Step` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Sections` | `0` |
| `Step` | `1` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 4 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 3 |
| **Total Properties** | 0 |
| **Total Fields** | 6 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


