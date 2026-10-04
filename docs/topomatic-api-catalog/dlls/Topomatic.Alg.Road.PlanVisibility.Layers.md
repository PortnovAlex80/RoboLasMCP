# Topomatic.Alg.Road.PlanVisibility.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road.PlanVisibility.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.PlanVisibility.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Road.PlanVisibility.Layers`

### `AlignmentPlanVisibilityExtension` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.AlignmentPlanVisibilityExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanVisibility` | `AlignmentPlanVisibility` | `Alignment alignment` | `Extension` |

---
## Namespace: `Topomatic.Alg.Road.PlanVisibility.Layers.Layers`

### `ArrowsVisibilityPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.ArrowsVisibilityPlanLayer` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer`
        - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.ArrowsVisibilityPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `PlanVisibilityPlanStyle` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `LinesVisibilityPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.LinesVisibilityPlanLayer` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer`
        - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.LinesVisibilityPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `PlanVisibilityPlanStyle` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

### `PlanVisibilityPlanLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CommonPlanStyle` | `PlanVisibilityCommonPlanStyle` | `get` | No | `` |
| `PlanVisibility` | `AlignmentPlanVisibility` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `PlanVisibilityPlanStyle` | `` | `` |
| `InvalidateDrawCache` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentPlanVisibilityContainer` | `get_PlanVisibility` |

### `PointsVisibilityPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PointsVisibilityPlanLayer` |
| **Base Type** | `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Road.PlanVisibility.IAlignmentPlanVisibilityContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Alg.Layers.AlgLayer`
      - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PlanVisibilityPlanLayer`
        - `Topomatic.Alg.Road.PlanVisibility.Layers.Layers.PointsVisibilityPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanStyle` | `PlanVisibilityPlanStyle` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Namespace: `Topomatic.Alg.Road.PlanVisibility.Layers.Utils`

### `PlanVisibilityLayerUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.PlanVisibility.Layers.Utils.PlanVisibilityLayerUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPlanVisibilityPlanLayers` | `IEnumerable<PlanVisibilityPlanLayer>` | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 3 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 2 |
| **Total Methods** | 7 |
| **Total Properties** | 9 |
| **Total Fields** | 3 |
| **Total Events** | 0 |
| **Total Constructors** | 4 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


