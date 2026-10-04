# Topomatic.Alg.Road.Crossing.Core

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.Crossing.Core` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.Crossing.Core, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.Crossing.Core.dll` |

---
## Namespace: `Topomatic.Alg.Road.Crossing.Core`

### `AlgRoadCrossingCorePluginHost` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Core.AlgRoadCrossingCorePluginHost` |
| **Base Type** | `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator` |
| **Implements** | `Topomatic.ApplicationPlatform.Plugins.IPluginInitializator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Plugins.PluginHostInitializator`
    - `Topomatic.Alg.Road.Crossing.Core.AlgRoadCrossingCorePluginHost`

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
## Namespace: `Topomatic.Alg.Road.Crossing.Core.Layers`

### `CropssingsStyleExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Core.Layers.CropssingsStyleExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Intersection intersection, CadView cadView, CadPen pen, CadFont font, Single textSize, Vector2D pos, Vector2D delta` | `Extension` |

---
## Namespace: `Topomatic.Alg.Road.Crossing.Core.Wrappers`

### `IntersectionWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Crossing.Core.Wrappers.IntersectionWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Alg.Road.Crossing.Intersection, Topomatic.Alg.Road.Crossing, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Intersection intersection, Int32 index)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get` | No | `` |
| `WrappedObject` | `Intersection` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 3 |
| **Classes** | 2 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 1 |
| **Total Methods** | 3 |
| **Total Properties** | 4 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


