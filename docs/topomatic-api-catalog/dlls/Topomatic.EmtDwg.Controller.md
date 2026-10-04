# Topomatic.EmtDwg.Controller

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.EmtDwg.Controller` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.EmtDwg.Controller, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.EmtDwg.Controller.dll` |

---
## Namespace: `Topomatic.EmtDwg.Controller`

### `EmtDwgController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.EmtDwgController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.EmtDwg.Controller.EmtDwgController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `EmtDwgPluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.EmtDwgPluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.EmtDwg.Controller.EmtDwgPluginHost`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrajectorySettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.TrajectorySettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlphaCarHatch` | `Int32` | `get/set` | No | `` |
| `AlphaCarHatchValue` | `Int32` | `get` | No | `` |
| `AlphaCorridorHatch` | `Int32` | `get/set` | No | `` |
| `AlphaCorridorHatchValue` | `Int32` | `get` | No | `` |
| `CarColor` | `CadColor` | `get/set` | No | `` |
| `CarLineColor` | `CadColor` | `get/set` | No | `` |
| `CheckFolding` | `Boolean` | `get/set` | No | `` |
| `CorridorColor` | `CadColor` | `get/set` | No | `` |
| `DrawCarHatch` | `Boolean` | `get/set` | No | `` |
| `DrawHatch` | `Boolean` | `get/set` | No | `` |
| `DwgLineColor` | `CadColor` | `get/set` | No | `` |
| `Instance` | `TrajectorySettings` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Init` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `TypeAxis` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.TypeAxis` |
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
      - `Topomatic.EmtDwg.Controller.TypeAxis`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ForwardAxis` | `TypeAxis` | Yes | `ForwardAxis` | `` |
| `NormalAxis` | `TypeAxis` | Yes | `NormalAxis` | `` |
| `TurnAxis` | `TypeAxis` | Yes | `TurnAxis` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ForwardAxis` | `0` |
| `NormalAxis` | `1` |
| `TurnAxis` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.EmtDwg.Controller.CorridorCalculator`

### `CorridorCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.CorridorCalculator.CorridorCalculator` |
| **Base Type** | `Topomatic.Cad.Foundation.OverlayOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.BaseOverlayOperation`
      - `Topomatic.Cad.Foundation.OverlayOperation`
        - `Topomatic.EmtDwg.Controller.CorridorCalculator.CorridorCalculator`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcCorridor` | `List<List<Vector2D>>` | `Vector2D basis, List<List<Vector2D>> prevCor, List<List<Vector2D>> moveCor` | `` |
| `CalcCorridor` | `List<List<Vector2D>>` | `List<List<Vector2D>> prevCor, List<List<Vector2D>> moveCor` | `` |
| `Clear` | `Void` | `` | `` |
| `GetTriangles` | `List<Vector2F[]>` | `Vector2D basis, List<List<Vector2D>> corridors` | `` |

---
## Namespace: `Topomatic.EmtDwg.Controller.Design`

### `TypeAxisEnumConerter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.EmtDwg.Controller.Design.TypeAxisEnumConerter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.EmtDwg.Controller.Design.TypeAxisEnumConerter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 12 |
| **Total Properties** | 12 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


