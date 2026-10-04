# Topomatic.Alg.Rail.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Rail.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Rail.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Rail.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Rail.Layers`

### `DrainagePlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Layers.DrainagePlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Rail.Layers.DrainagePlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `RailPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Layers.RailPlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgPlanLayer`
        - `Topomatic.Alg.Rail.Layers.RailPlanLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailSectionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Layers.RailSectionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.BaseSectionLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseCrossSectionLayer`
        - `Topomatic.Alg.Layers.BaseSectionLayer`
          - `Topomatic.Alg.Rail.Layers.RailSectionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailTransitionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Layers.RailTransitionsLayer` |
| **Base Type** | `Topomatic.Alg.Layers.ProjectTransitionsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Layers.AlgBaseProfileLayer`
        - `Topomatic.Alg.Layers.ProjectTransitionsLayer`
          - `Topomatic.Alg.Rail.Layers.RailTransitionsLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |

---
## Namespace: `Topomatic.Alg.Rail.Layers.Design`

### `CategoryEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Rail.Layers.Design.CategoryEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Rail.Layers.Design.CategoryEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 5 |
| **Classes** | 5 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 1 |
| **Total Properties** | 3 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


