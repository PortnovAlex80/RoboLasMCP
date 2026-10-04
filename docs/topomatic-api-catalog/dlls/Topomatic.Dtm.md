# Topomatic.Dtm

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Dtm` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Dtm, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Dtm.dll` |

---
## Namespace: `Topomatic.Dtm`

### `DrawingModel` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.DrawingModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, System.IDisposable, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Dtm.DrawingModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `LoadFromFile` | `Void` | `String path` | `` |
| `SaveToFile` | `Void` | `String path` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"application/dwg"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IDrawingContainer` | `get_Drawing` |

### `TerrainModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dtm.TerrainModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ITerrainModel, Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IReferenceHolder, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Dtm.TerrainModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `BasisCurveRelativePath` | `String` | `get/set` | No | `` |
| `HasBasisCurve` | `Boolean` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImCollection` | `ImElementCollection` | `get` | No | `` |
| `MaxSlopeOffset` | `Double` | `get/set` | No | `` |
| `References` | `IList<String>` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetReferences` | `IEnumerable<String>` | `` | `` |
| `LoadFromFile` | `Void` | `String path` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `SaveToFile` | `Void` | `String path` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"dtm"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurfaceContainer` | `Topomatic.Sfc.ISurfaceContainer.get_Surface` |
| `IReferenceHolder` | `GetReferences` |
| `IDisposable` | `Dispose` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IDrawingContainer` | `Topomatic.Dwg.IDrawingContainer.get_Drawing` |
| `ImElementCollectionContainer` | `get_ImCollection` |
| `IStationingRepository` | `Topomatic.Cad.Foundation.Stationing.IStationingRepository.get_Stationing` |
| `IKilometersRepository` | `Topomatic.Cad.Foundation.Stationing.IKilometersRepository.get_Kilometers` |
| `IStateElevationProviderFactory` | `Topomatic.Cad.Foundation.IStateElevationProviderFactory.CreateProvider` |
| `IBasisCurveContainer` | `get_BasisCurve` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D0` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D1` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Project` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Tesselate` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.get_Length` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 2 |
| **Classes** | 1 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 0 |
| **Total Methods** | 9 |
| **Total Properties** | 9 |
| **Total Fields** | 2 |
| **Total Events** | 0 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


