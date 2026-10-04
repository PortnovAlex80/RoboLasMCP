# Topomatic.Glg.Model

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Glg.Model` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Glg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Glg.Model.dll` |

---
## Namespace: `Topomatic.Glg.Model`

### `GeologyModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.GeologyModel` |
| **Base Type** | `Topomatic.FoundationClasses.StateControllerObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, Topomatic.Glg.IGroundTableContainer, Topomatic.Glg.Style.IGlobalGeologyStyleContainer, Topomatic.Dwg.IDrawingContainer, Topomatic.Glg.ILabTableModelCollectionContainer, Topomatic.Glg.IBoreholeTableContainer, Topomatic.FoundationClasses.IHandledObject, System.IDisposable, Topomatic.Glg.IGlobalGeologyContainer, Topomatic.Glg.ILabTableContainer, Topomatic.Glg.IImpellerConstTableContainer, Topomatic.Glg.IConePenetrationTableContainer, Topomatic.Glg.IImpellerTestTableContainer, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Dwg.Smt.LayerLink.ILayerLinksContainer, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IStationingCurve` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Glg.Model.GeologyModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActivityManager` | `GlobalGeologyActivityManager` | `get` | No | `` |
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `BasisCurveRelativePath` | `String` | `get/set` | No | `` |
| `BoreholeEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `BoreholeTable` | `BoreholeTable` | `get` | No | `` |
| `BulkSurface` | `GeologyBulkSurface` | `get` | No | `` |
| `ConePenetrationTestEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `ConePenetrationTestTable` | `ConePenetrationTestTable` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `DtmRelativePath` | `String` | `get/set` | No | `` |
| `GroundTable` | `GroundTable` | `get` | No | `` |
| `HasBasisCurve` | `Boolean` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `ImpellerConstTable` | `ImpellerConstTable` | `get` | No | `` |
| `ImpellerTestEditableItems` | `SimpleEditedItemsTable` | `get` | No | `` |
| `ImpellerTestTable` | `ImpellerTestTable` | `get` | No | `` |
| `LabTable` | `LabTable` | `get` | No | `` |
| `LabTableModels` | `IList<LabTableModel>` | `get` | No | `` |
| `LayerLinks` | `LayerLinks` | `get` | No | `` |
| `Style` | `GlobalGeologyStyle` | `get` | No | `` |
| `UseDtmSurface` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddLabTableModel` | `LabTableModel` | `String name` | `` |
| `Dispose` | `Void` | `` | `` |
| `GetLayer` | `ILayer` | `GeologyLayerStyleItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveLabTableModel` | `Void` | `LabTableModel labTableModel` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SwapLabTableModels` | `Void` | `Int32 indexI, Int32 indexJ` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `SettingsChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGroundTableContainer` | `get_GroundTable` |
| `IGlobalGeologyStyleContainer` | `get_Style` |
| `IGlobalGeologyStyleContainer` | `GetLayer` |
| `IDrawingContainer` | `get_Drawing` |
| `ILabTableModelCollectionContainer` | `Topomatic.Glg.ILabTableModelCollectionContainer.get_LabTableModels` |
| `IBoreholeTableContainer` | `get_BoreholeTable` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IDisposable` | `Dispose` |
| `IGlobalGeologyContainer` | `get_Style` |
| `IGlobalGeologyContainer` | `get_BoreholeEditableItems` |
| `ILabTableContainer` | `get_LabTable` |
| `IImpellerConstTableContainer` | `get_ImpellerConstTable` |
| `IConePenetrationTableContainer` | `get_ConePenetrationTestTable` |
| `IImpellerTestTableContainer` | `get_ImpellerTestTable` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IKilometersRepository` | `Topomatic.Cad.Foundation.Stationing.IKilometersRepository.get_Kilometers` |
| `IStationingRepository` | `Topomatic.Cad.Foundation.Stationing.IStationingRepository.get_Stationing` |
| `ILayerLinksContainer` | `get_LayerLinks` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D0` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D1` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Project` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Tesselate` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.get_Length` |

### `LabTableModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.LabTableModel` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IHandledObject, Topomatic.Glg.ILabTableContainer, Topomatic.FoundationClasses.INamedObject, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransactable owner, String name)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `` |
| `LabTable` | `LabTable` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateNewId` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `ILabTableContainer` | `get_LabTable` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Glg.Model.Bulk`

### `BulkGround` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.Bulk.GeologyBulkSurface+BulkGround` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Guid groundId, Int32 cuttingNumber)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CuttingIndex` | `Int32` | No | `` | `` |
| `GroundId` | `Guid` | No | `` | `` |

### `GeologyBulkSurface` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.Bulk.GeologyBulkSurface` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GeologyModel owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IList<BulkLevel<BulkGround>[]>` | `get` | No | `` |
| `LayersVisibility` | `IDictionary<BulkGround Boolean>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Triangulation` | `Surface` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InterpolatedInPos` | `Boolean` | `Vector2D pos` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CurrentComparer` | `IEqualityComparer<BulkGround>` | Yes | `` | `` |
| `GetLayersFromPos` | `Func<Vector2D GeologyModel BulkLevel<BulkGround>[]>` | Yes | `` | `` |

#### Nested Types (1)

- `BulkGround` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Glg.Model.Bulk.BulkTools`

### `BulkGrounds` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.Bulk.BulkTools.BulkGrounds` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Levels` | `List<BulkLevel<BulkGround>>` | No | `` | `` |
| `Pos` | `Vector3D` | No | `` | `` |

### `Utils` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Glg.Model.Bulk.BulkTools.Utils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareLevels` | `Void` | `BulkGrounds a, BulkGrounds b, IEqualityComparer<BulkGround> comparer, Dictionary<Guid Int32> beddingGroups` | `` |
| `PrepareLevels` | `BulkLevel<Guid>[]` | `BulkLevel<Guid>[] a, BulkLevel<Guid>[] b, Dictionary<Guid Int32> beddingGroups` | `` |
| `RemoveZeroGrounds` | `Void` | `BulkGrounds[] bulkGrounds` | `` |
| `UpdateBoreholeByLayers` | `Void` | `Borehole borehole, BulkLevel<Guid>[] levels` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 6 |
| **Classes** | 6 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 19 |
| **Total Properties** | 29 |
| **Total Fields** | 6 |
| **Total Events** | 1 |
| **Total Constructors** | 6 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


