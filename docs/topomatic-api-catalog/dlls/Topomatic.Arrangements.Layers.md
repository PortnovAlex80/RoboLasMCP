# Topomatic.Arrangements.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Arrangements.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Arrangements.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Arrangements.Layers.dll` |

---
## Namespace: `Topomatic.Arrangements.Layers`

### `ArrangementLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Arrangements.Layers.ArrangementLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Arrangements.Layers.ArrangementLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `ArrangementModel` | `ArrangementModel` | `get/set` | No | `` |
| `DrawingLayer` | `DrawingLayer` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 1 |
| **Classes** | 1 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 2 |
| **Total Properties** | 3 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


