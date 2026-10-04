# Topomatic.ApplicationEnvironment

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.ApplicationEnvironment` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.ApplicationEnvironment, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.ApplicationEnvironment.dll` |

---
## Namespace: `Topomatic.ApplicationEnvironment`

### `EnvironmentModifier` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationEnvironment.EnvironmentModifier` |
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
      - `Topomatic.ApplicationEnvironment.EnvironmentModifier`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dynamic` | `EnvironmentModifier` | Yes | `Dynamic` | `` |
| `Process` | `EnvironmentModifier` | Yes | `Process` | `` |
| `Public` | `EnvironmentModifier` | Yes | `Public` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Process` | `0` |
| `Dynamic` | `1` |
| `Public` | `2` |

**Underlying Type**: `System.UInt16`

### `ProcessEnvironment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.ApplicationEnvironment.ProcessEnvironment` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `ProcessEnvironment` | `get` | Yes | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExpandEnvironmentVariables` | `String` | `String name` | `` |
| `GetDirectories` | `String[]` | `String key` | `` |
| `GetVariable` | `String` | `String key, RegistryValueOptions options, EnvironmentModifier modifier` | `` |
| `GetVariable` | `String` | `String key, RegistryValueOptions options` | `` |
| `Insert` | `Void` | `Int32 index, EnvironmentModifier modifier, String key, String path` | `` |
| `Load` | `Void` | `RegistryKey registry, EnvironmentModifier modifier` | `` |
| `Remove` | `Boolean` | `EnvironmentModifier modifier, String key, String path` | `` |
| `Save` | `Void` | `RegistryKey registry, EnvironmentModifier modifier` | `` |
| `SearchFiles` | `String[]` | `String key, String searchPattern` | `` |
| `SetVariable` | `Void` | `String key, String value, EnvironmentModifier modifier` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 1 |
| **Interfaces** | 0 |
| **Enums** | 1 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 10 |
| **Total Properties** | 1 |
| **Total Fields** | 4 |
| **Total Events** | 0 |
| **Total Constructors** | 0 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


