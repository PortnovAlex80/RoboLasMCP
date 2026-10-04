# Topomatic.Alg.Model

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Model` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Model.dll` |

---
## Namespace: `Topomatic.Alg.Model`

### `AlignmentActivityManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Model.AlignmentActivityManager` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Model.AlignmentActivityManager`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveTransitionIndex` | `Int32` | `get/set` | No | `` |
| `CurrentSection` | `Int32` | `get/set` | No | `` |
| `EndSection` | `Int32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Events (2)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ActiveTransitionIndexChanged` | `EventHandler` | No | `` |
| `CurrentSectionChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `AlignmentModel` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Model.AlignmentModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Sfc.ISurfaceContainer, Topomatic.Alg.IAlignmentContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Alg.Model.AlignmentModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActivityManager` | `AlignmentActivityManager` | `get` | No | `` |
| `Alignment` | `Alignment` | `get` | No | `` |
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `BasisCurveRelativePath` | `String` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `HasBasisCurve` | `Boolean` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImCollection` | `ImElementCollection` | `get` | No | `` |
| `LayerLinks` | `LayerLinks` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildSurface` | `Void` | `Surface surface, Boolean forced` | `` |
| `BuildSurface` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `GenerateNewId` | `Void` | `` | `` |
| `InvalidateSurface` | `Void` | `` | `` |
| `LoadFromFile` | `Void` | `String path` | `` |
| `LoadFromStream` | `Void` | `Stream stream` | `` |
| `RefreshRelativePaths` | `Void` | `URI folderUri` | `` |
| `SaveToFile` | `Void` | `String path` | `` |
| `SaveToStream` | `Void` | `Stream stream` | `` |
| `UpdateSurface` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurfaceContainer` | `get_Surface` |
| `IAlignmentContainer` | `get_Alignment` |
| `ILayerLinksContainer` | `get_LayerLinks` |
| `IDisposable` | `Dispose` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IDrawingContainer` | `get_Drawing` |
| `ImElementCollectionContainer` | `get_ImCollection` |
| `IKilometersRepository` | `Topomatic.Cad.Foundation.Stationing.IKilometersRepository.get_Kilometers` |
| `IBasisCurveContainer` | `get_BasisCurve` |
| `IStateElevationProviderFactory` | `Topomatic.Cad.Foundation.IStateElevationProviderFactory.CreateProvider` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D0` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D1` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Project` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Tesselate` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.get_Length` |
| `IStationingRepository` | `Topomatic.Cad.Foundation.Stationing.IStationingRepository.get_Stationing` |

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
| **Total Methods** | 11 |
| **Total Properties** | 14 |
| **Total Fields** | 0 |
| **Total Events** | 2 |
| **Total Constructors** | 2 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


