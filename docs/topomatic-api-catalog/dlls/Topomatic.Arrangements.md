# Topomatic.Arrangements

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Arrangements` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Arrangements, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Arrangements.dll` |

---
## Namespace: `Topomatic.Arrangements`

### `ArrangementModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Arrangements.ArrangementModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Stg.IStgSerializable, Topomatic.Rsf.IAlignmentRsfContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, System.IDisposable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Dwg.IDrawingContainer, Topomatic.Visualization.ImElementCollectionContainer, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer, Topomatic.Cad.Foundation.IStateElevationProviderFactory, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Arrangements.ArrangementModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `BasisCurveRelativePath` | `String` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `HasBasisCurve` | `Boolean` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImCollection` | `ImElementCollection` | `get` | No | `` |
| `LayerLinks` | `LayerLinks` | `get` | No | `` |
| `ProjectSurfacesRelativePaths` | `IList<String>` | `get` | No | `` |
| `Rsf` | `AlignmentRsf` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MODEL_TYPE` | `String` | Yes | `"arr"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentRsfContainer` | `get_Rsf` |
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
| **Total Types** | 1 |
| **Classes** | 1 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 3 |
| **Total Properties** | 9 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


