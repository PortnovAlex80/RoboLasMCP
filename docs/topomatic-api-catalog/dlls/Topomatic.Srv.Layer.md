# Topomatic.Srv.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Srv.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Srv.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Srv.Layer.dll` |

---
## Namespace: `Topomatic.Srv.Layer`

### `ISurveyProviderData` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Layer.ISurveyProviderData` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HighlightedPointColor` | `Int32` | `get` | No | `` |
| `HighlightedStationColor` | `Int32` | `get` | No | `` |
| `HighlightedSurveyTraverseColor` | `Int32` | `get` | No | `` |
| `PointColor` | `Int32` | `get` | No | `` |
| `ShowSurvey` | `Boolean` | `get` | No | `` |
| `ShowSurveyMeasurings` | `Boolean` | `get` | No | `` |
| `ShowSurveyTraverses` | `Boolean` | `get` | No | `` |
| `ShowTacheometry` | `Boolean` | `get` | No | `` |
| `StationColor` | `Int32` | `get` | No | `` |
| `Survey` | `Survey` | `get` | No | `` |
| `SurveyTraverseColor` | `Int32` | `get` | No | `` |

### `SrvPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Srv.Layer.SrvPlanLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Srv.Layer.SrvPlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HighlightedLevelingLines` | `IEnumerable<LevelingLine>` | `get/set` | No | `` |
| `HighlightedPoints` | `IEnumerable<Point>` | `get/set` | No | `` |
| `HighlightedStations` | `IEnumerable<Station>` | `get/set` | No | `` |
| `HighlightedTacheometricStations` | `IEnumerable<TacheometricStation>` | `get/set` | No | `` |
| `HighlightedTraverses` | `IEnumerable<SurveyTraverse>` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PointSize` | `Single` | `get/set` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 1 |
| **Interfaces** | 1 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 0 |
| **Total Properties** | 21 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


