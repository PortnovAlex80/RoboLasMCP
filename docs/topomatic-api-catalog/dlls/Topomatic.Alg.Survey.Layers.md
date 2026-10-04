# Topomatic.Alg.Survey.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Survey.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Survey.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Survey.Layers.dll` |

---
## Namespace: `Topomatic.Alg.Survey.Layers`

### `SurveyTransitionLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Survey.Layers.SurveyTransitionLayer` |
| **Base Type** | `Topomatic.Alg.Layers.AlgBaseProfileLayer` |
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
        - `Topomatic.Alg.Survey.Layers.SurveyTransitionLayer`

#### Constructors (1)

- `.ctor(String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

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
| **Total Methods** | 7 |
| **Total Properties** | 2 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


