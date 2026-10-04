# Topomatic.Turnouts.Model

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Turnouts.Model` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Turnouts.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Turnouts.Model.dll` |

---
## Namespace: `Topomatic.Turnouts.Model`

### `RailwaysModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Turnouts.Model.RailwaysModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IHandledObject, System.IDisposable, Topomatic.Turnouts.Railways.IRailWaysContainer, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Turnouts.Model.RailwaysModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Drawing` | `Drawing` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `LayerLinks` | `LayerLinks` | `get` | No | `` |
| `MasterLayers` | `RailWayMasterLayers` | `get` | No | `` |
| `RailWays` | `RailWays` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IDisposable` | `Dispose` |
| `IRailWaysContainer` | `get_RailWays` |
| `ILayerLinksContainer` | `get_LayerLinks` |
| `IDrawingContainer` | `get_Drawing` |

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
| **Total Properties** | 5 |
| **Total Fields** | 0 |
| **Total Events** | 0 |
| **Total Constructors** | 1 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


