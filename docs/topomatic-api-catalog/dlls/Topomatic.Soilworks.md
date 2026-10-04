# Topomatic.Soilworks

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Soilworks` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Soilworks, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Soilworks.dll` |

---
## Namespace: `Topomatic.Soilworks`

### `Applicability` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Applicability` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Applicability`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Applicability applicability)`
- `.ctor(Soilworks soilworks)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BaseLinearSector` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.BaseLinearSector` |
| **Base Type** | `Topomatic.Soilworks.Sector` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.IMassContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Sector`
      - `Topomatic.Soilworks.BaseLinearSector`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(BaseLinearSector baseLinearSector)`
- `.ctor(LinearSoilworksObject owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Center` | `Vector2D` | `get` | No | `Browsable` |
| `End` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get` | No | `Browsable` |
| `Kilometers` | `IKilometers` | `get` | No | `Browsable` |
| `Length` | `Double` | `get/set` | No | `` |
| `LinearSoilworksObject` | `LinearSoilworksObject` | `get` | No | `Browsable` |
| `Start` | `Double` | `get/set` | No | `` |
| `Stationing` | `IStationing` | `get` | No | `Browsable` |
| `YOffset` | `Double` | `get/set` | No | `Browsable` |
| `YTopOffset` | `Double` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IMassContainer` | `get_Center` |
| `IMassContainer` | `get_Height` |

### `ConnectionLink` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ConnectionLink` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.ConnectionLink`

#### Constructors (2)

- `.ctor(Soilworks owner)`
- `.ctor(ConnectionPoint soilworksConnectionPoint1, ConnectionPoint soilworksConnectionPoint2, Soilworks owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionPoint1` | `ConnectionPoint` | `get/set` | No | `Browsable` |
| `ConnectionPoint2` | `ConnectionPoint` | `get/set` | No | `Browsable` |
| `Distance` | `Double` | `get/set` | No | `` |
| `LineColor` | `CadColor` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |
| `YPosition` | `Double` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AutoSetDistance` | `Void` | `` | `` |
| `AutoSetYPosition` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ConnectionPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ConnectionPoint` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.ConnectionPoint`

#### Constructors (2)

- `.ctor(ConnectionLink owner)`
- `.ctor(ConnectionLink owner, SoilworksObject soilworksObject, Object value)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionLink` | `ConnectionLink` | `get` | No | `` |
| `Object` | `SoilworksObject` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get` | No | `` |
| `Value` | `Object` | `get/set` | No | `` |
| `ValueText` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ConnectionPoint` | `ConnectionLink owner, SoilworksObject soilworksObject, Object value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ContainerSoilworksObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ContainerSoilworksObject` |
| **Base Type** | `Topomatic.Soilworks.SoilworksObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.SoilworksObject`
      - `Topomatic.Soilworks.ContainerSoilworksObject`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(ContainerSoilworksObject containerSoilworksObject)`
- `.ctor(Soilworks owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Sectors` | `Sector[]` | `get` | No | `Browsable` |
| `SectorsCount` | `Int32` | `get` | No | `Browsable` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSector` | `Void` | `Sector sector` | `` |
| `Contains` | `Boolean` | `IMassContainer massContainer` | `Browsable` |
| `DistanceBetweenSectors` | `Double` | `Sector sector1, Sector sector2` | `` |
| `GetSector` | `Sector` | `Int32 index` | `` |
| `GetSector` | `Sector` | `Guid id` | `` |
| `InnerDistance` | `Double` | `Sector sector, ConnectionPoint connectionPoint` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveSector` | `Void` | `Sector sector` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Haulage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Haulage` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Haulage`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Haulage haulage)`
- `.ctor(Soilworks owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CutVolume` | `Double` | `get/set` | No | `` |
| `Distance` | `Double` | `get/set` | No | `` |
| `FillVolume` | `Double` | `get/set` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `LineColor` | `CadColor` | `get` | No | `` |
| `Material` | `Material` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Recipient` | `IMassContainer` | `get/set` | No | `Browsable` |
| `RecipientConnectionPoint` | `Vector2D` | `get/set` | No | `Browsable` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |
| `Supplier` | `IMassContainer` | `get/set` | No | `Browsable` |
| `SupplierConnectionPoint` | `Vector2D` | `get/set` | No | `Browsable` |
| `TotalCompactionCoeff` | `Double` | `get` | No | `` |
| `Type` | `HaulageType` | `get/set` | No | `` |
| `YPosition` | `Double` | `get/set` | No | `Browsable` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsSame` | `Boolean` | `Haulage haulage` | `Browsable` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetAutoYPos` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `HaulagesGenerateMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.HaulagesGenerateMode` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Soilworks.HaulagesGenerateMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MinDistance` | `HaulagesGenerateMode` | Yes | `MinDistance` | `` |
| `Same` | `HaulagesGenerateMode` | Yes | `Same` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Same` | `0` |
| `MinDistance` | `1` |

**Underlying Type**: `System.Int32`

### `HaulageType` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.HaulageType` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.HaulageType`

#### Constructors (1)

- `.ctor(Soilworks owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get` | No | `Browsable` |
| `LineColor` | `CadColor` | `get/set` | No | `` |
| `LossCoeff` | `Double` | `get/set` | No | `` |
| `LossCoeffDist` | `Double` | `get/set` | No | `` |
| `Materials` | `Material[]` | `get` | No | `` |
| `MaxDistance` | `Double` | `get/set` | No | `` |
| `MinDistance` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `Browsable` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddMaterial` | `Void` | `Material material` | `` |
| `ApplicableForMaterial` | `Boolean` | `Material material` | `` |
| `GetLossCoeffForDist` | `Double` | `Double distance` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemovaApplicability` | `Void` | `Material material` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `IMassContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.IMassContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `IsRecipient` | `Boolean` | `get` | No | `` |
| `IsSupplier` | `Boolean` | `get` | No | `` |
| `MaterialContainer` | `MaterialContainer` | `get` | No | `` |
| `MustBeSolved` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ReHaulageAllowed` | `Boolean` | `get` | No | `` |
| `RemainingVolume` | `Double` | `get` | No | `` |
| `SoilworksObject` | `SoilworksObject` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |

### `IMassContainerWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.IMassContainerWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MassContainer` | `IMassContainer` | `get` | No | `` |

### `IMaterialsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.IMaterialsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Materials` | `Material[]` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddMaterial` | `Void` | `Material material` | `` |
| `RemoveMaterial` | `Void` | `Material material` | `` |

### `ISoilworksContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ISoilworksContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Soilworks` | `Soilworks` | `get` | No | `` |

### `ISoilworksObjectWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ISoilworksObjectWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SoilworksObject` | `SoilworksObject` | `get` | No | `` |

### `ITemplateItemsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ITemplateItemsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `TemplateItems` | `TemplateItem[]` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `RemoveTemplateItem` | `Void` | `TemplateItem templateItem` | `` |

### `LinearConnectionPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.LinearConnectionPoint` |
| **Base Type** | `Topomatic.Soilworks.ConnectionPoint` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.ConnectionPoint`
      - `Topomatic.Soilworks.LinearConnectionPoint`

#### Constructors (2)

- `.ctor(ConnectionLink connectionLink)`
- `.ctor(ConnectionLink connectionLink, LinearSoilworksObject connectableObject, Double value)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector2D` | `get` | No | `` |
| `ValueDouble` | `Double` | `get/set` | No | `` |
| `ValueText` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LinearSector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.LinearSector` |
| **Base Type** | `Topomatic.Soilworks.BaseLinearSector` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.IMassContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Sector`
      - `Topomatic.Soilworks.BaseLinearSector`
        - `Topomatic.Soilworks.LinearSector`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(LinearSector linearSector)`
- `.ctor(LinearSoilworksObject owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsRecipient` | `Boolean` | `get` | No | `` |
| `IsSupplier` | `Boolean` | `get` | No | `` |
| `Type` | `SectorType` | `get/set` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IMassContainer` | `get_IsRecipient` |
| `IMassContainer` | `get_IsSupplier` |

### `LinearSoilworksObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.LinearSoilworksObject` |
| **Base Type** | `Topomatic.Soilworks.ContainerSoilworksObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.SoilworksObject`
      - `Topomatic.Soilworks.ContainerSoilworksObject`
        - `Topomatic.Soilworks.LinearSoilworksObject`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(LinearSoilworksObject linearSoilworksObject)`
- `.ctor(Soilworks owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLinearSectors` | `BaseLinearSector[]` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `CreationSettings` | `LinearSoilworksObjectCreationSettings` | `get` | No | `` |
| `End` | `Double` | `get/set` | No | `` |
| `Kilometres` | `AlgExtendedKilometres` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `LinearSectors` | `LinearSector[]` | `get` | No | `` |
| `ParallelSectors` | `ParallelSector[]` | `get` | No | `` |
| `ParalleSectors` | `ParallelSector[]` | `get` | No | `` |
| `Start` | `Double` | `get/set` | No | `` |
| `Stationing` | `StaticStationing` | `get` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSector` | `Void` | `Sector sector` | `` |
| `CalculateYOffsetForSector` | `Void` | `BaseLinearSector sector` | `` |
| `ClearSectors` | `Void` | `Boolean saveHandled` | `` |
| `DistanceBetweenSectors` | `Double` | `Sector sector1, Sector sector2` | `` |
| `GetConnectionPointValueFromPosition` | `Boolean` | `Vector2D position, ref Object result` | `` |
| `GetCrossingsByXYSectors` | `List<LinearSector>` | `LinearSector sector` | `` |
| `GetSortedBYXParallelsSectorsList` | `List<ParallelSector>` | `` | `` |
| `GetSortedBYXSectorsList` | `List<LinearSector>` | `` | `` |
| `GetSpecialMassContainers` | `IMassContainer[]` | `Boolean IsSupplier, Boolean IsRecipient` | `` |
| `InnerDistance` | `Double` | `Sector sector, ConnectionPoint connectionPoint` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MergeSectors` | `Void` | `LinearSector[] linearSectors` | `` |
| `RefreshSectors` | `Void` | `` | `` |
| `RemoveSector` | `Void` | `Sector sector` | `` |
| `RemoveSector` | `Void` | `Sector sector, Boolean refresh` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LinearSoilworksObjectCreationSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.LinearSoilworksObjectCreationSettings` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Soilworks.ITemplateItemsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.LinearSoilworksObjectCreationSettings`

#### Constructors (2)

- `.ctor(LinearSoilworksObjectCreationSettings linearSoilworksObjectCreationSettings)`
- `.ctor(LinearSoilworksObject linearSoilworksObject)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PathId` | `String` | `get/set` | No | `` |
| `Stations` | `Double[]` | `get/set` | No | `` |
| `TemplateItems` | `TemplateItem[]` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITemplateItemsContainer` | `get_TemplateItems` |
| `ITemplateItemsContainer` | `RemoveTemplateItem` |
| `ITemplateItemsContainer` | `AddTemplateItem` |
| `ITemplateItemsContainer` | `get_Applicabilities` |

### `Material` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Material` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Material`

#### Constructors (3)

- `.ctor(Material material)`
- `.ctor(IMaterialsContainer owner)`
- `.ctor(Guid groundHash)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get/set` | No | `` |
| `Cipher` | `String` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `CompactionCoeff` | `Double` | `get/set` | No | `` |
| `DefaultBackGroundColor` | `CadColor` | `get` | Yes | `` |
| `DefaultColor` | `CadColor` | `get` | Yes | `` |
| `DefaultForegroundColor` | `CadColor` | `get` | Yes | `` |
| `GroundHash` | `Guid` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `IsUsed` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Priority` | `Int32` | `get/set` | No | `` |
| `Soilworks` | `Soilworks` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddApplicability` | `Void` | `Applicability applicability` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemovaApplicability` | `Void` | `Applicability applicability` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `MaterialContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.MaterialContainer` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.MaterialContainer`

#### Constructors (1)

- `.ctor(IMassContainer owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseMaterials` | `Material[]` | `get` | No | `` |
| `BaseMaterialsValues` | `MaterialData[]` | `get` | No | `` |
| `CurrentMaterials` | `Material[]` | `get` | No | `` |
| `CurrentMaterialsValues` | `MaterialData[]` | `get` | No | `` |
| `MassContainer` | `IMassContainer` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddMaterial` | `Void` | `Material material` | `` |
| `AddMaterialVolume` | `Void` | `Material material, Double value` | `` |
| `ContainsBaseMaterial` | `Boolean` | `Material material` | `` |
| `EqualBaseMaterials` | `Boolean` | `MaterialData[] materialDatas` | `` |
| `GetBaseVolume` | `Double` | `Material material` | `` |
| `GetCurrentValue` | `Double` | `Material material` | `` |
| `GetHaulagableValue` | `Double` | `Material material` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveMaterial` | `Void` | `Material material` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ScaleBaseValues` | `Void` | `Double scale` | `` |
| `SetMaterialsData` | `Void` | `MaterialData[] materialsData` | `` |
| `SetMaterialVolume` | `Void` | `Material material, Double value` | `` |

#### Nested Types (2)

- `MaterialData` (class)
- `MaterialValue` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `MaterialData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.MaterialContainer+MaterialData` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(MaterialData materialData)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_BaseValue` | `Double` | No | `` | `` |
| `m_CurrentValue` | `Double` | No | `` | `` |
| `m_HaulagableValue` | `Double` | No | `` | `` |
| `m_Material` | `Material` | No | `` | `` |

### `MaterialValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.MaterialContainer+MaterialValue` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.MaterialContainer+MaterialValue`

#### Constructors (2)

- `.ctor(MaterialContainer materialContainer)`
- `.ctor(MaterialContainer materialContainer, Material material)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Material` | `Material` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Value` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ParallelSector` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.ParallelSector` |
| **Base Type** | `Topomatic.Soilworks.BaseLinearSector` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.IMassContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Sector`
      - `Topomatic.Soilworks.BaseLinearSector`
        - `Topomatic.Soilworks.ParallelSector`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(ParallelSector parallelSector)`
- `.ctor(LinearSoilworksObject owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Distance` | `Double` | `get/set` | No | `` |
| `IsRecipient` | `Boolean` | `get/set` | No | `` |
| `IsSupplier` | `Boolean` | `get/set` | No | `` |
| `MustBeSolved` | `Boolean` | `get` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IMassContainer` | `get_IsRecipient` |
| `IMassContainer` | `get_IsSupplier` |
| `IMassContainer` | `get_MustBeSolved` |

### `PointConnectionPoint` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.PointConnectionPoint` |
| **Base Type** | `Topomatic.Soilworks.ConnectionPoint` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.ConnectionPoint`
      - `Topomatic.Soilworks.PointConnectionPoint`

#### Constructors (2)

- `.ctor(ConnectionLink connectionLink)`
- `.ctor(ConnectionLink connectionLink, PointSoilworksObject soilworksObject, Vector2D value)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector2D` | `get` | No | `` |
| `ValueText` | `String` | `get/set` | No | `` |
| `ValueVector2D` | `Vector2D` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PointSoilworksObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.PointSoilworksObject` |
| **Base Type** | `Topomatic.Soilworks.SoilworksObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.IMassContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.SoilworksObject`
      - `Topomatic.Soilworks.PointSoilworksObject`

#### Constructors (1)

- `.ctor(Soilworks owner)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get/set` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `HauledVolume` | `Double` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `IsRecipient` | `Boolean` | `get/set` | No | `` |
| `IsSupplier` | `Boolean` | `get/set` | No | `` |
| `MaterialContainer` | `MaterialContainer` | `get` | No | `` |
| `MaterialData` | `MaterialData[]` | `get/set` | No | `` |
| `MustBeSolved` | `Boolean` | `get` | No | `` |
| `ReHaulageAllowed` | `Boolean` | `get` | No | `` |
| `RemainingVolume` | `Double` | `get` | No | `` |
| `SoilworksObject` | `SoilworksObject` | `get` | No | `` |
| `Volume` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddApplicability` | `Void` | `Applicability applicability` | `` |
| `Contains` | `Boolean` | `IMassContainer massContainer` | `` |
| `GetConnectionPointValueFromPosition` | `Boolean` | `Vector2D position, ref Object value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `OrderHaulagesConnectionPoints` | `Vector2D[]` | `` | `` |
| `RemovaApplicability` | `Void` | `Applicability applicability` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IMassContainer` | `get_SoilworksObject` |
| `IMassContainer` | `get_IsRecipient` |
| `IMassContainer` | `get_IsSupplier` |
| `IMassContainer` | `get_MaterialContainer` |
| `IMassContainer` | `get_Volume` |
| `IMassContainer` | `get_RemainingVolume` |
| `IMassContainer` | `get_Applicabilities` |
| `IMassContainer` | `get_Center` |
| `IMassContainer` | `get_Height` |
| `IMassContainer` | `get_ReHaulageAllowed` |
| `IMassContainer` | `get_MustBeSolved` |

### `Sector` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Sector` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.IMassContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Sector`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Sector sector)`
- `.ctor(ContainerSoilworksObject owner)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `Browsable` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `HauledVolume` | `Double` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `Browsable` |
| `Id` | `Guid` | `get` | No | `` |
| `IncomingHaulages` | `Haulage[]` | `get` | No | `Browsable` |
| `IsRecipient` | `Boolean` | `get/set` | No | `` |
| `IsSupplier` | `Boolean` | `get/set` | No | `` |
| `MaterialContainer` | `MaterialContainer` | `get` | No | `Browsable` |
| `MustBeSolved` | `Boolean` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `OutgoingHaulages` | `Haulage[]` | `get` | No | `Browsable` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `ReHaulageAllowed` | `Boolean` | `get` | No | `Browsable` |
| `RemainingVolume` | `Double` | `get` | No | `` |
| `SoilworksObject` | `SoilworksObject` | `get` | No | `` |
| `Volume` | `Double` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddApplicabilities` | `Void` | `Applicability[] applicabilities` | `` |
| `AddApplicability` | `Void` | `Applicability applicability` | `` |
| `AddMaterial` | `Void` | `Material material` | `` |
| `ApplicabilitiesEquals` | `Boolean` | `Sector sector` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MaterialApplicability` | `Boolean` | `Material material` | `` |
| `MaterialsEquals` | `Boolean` | `Sector sector` | `` |
| `RemoveApplicability` | `Void` | `Applicability applicability` | `` |
| `RemoveMaterial` | `Void` | `Material material` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ScaleVolumes` | `Void` | `Double scale` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IMassContainer` | `get_Name` |
| `IMassContainer` | `get_Id` |
| `IMassContainer` | `get_SoilworksObject` |
| `IMassContainer` | `get_IsRecipient` |
| `IMassContainer` | `get_IsSupplier` |
| `IMassContainer` | `get_MaterialContainer` |
| `IMassContainer` | `get_Volume` |
| `IMassContainer` | `get_RemainingVolume` |
| `IMassContainer` | `get_Applicabilities` |
| `IMassContainer` | `get_Center` |
| `IMassContainer` | `get_Height` |
| `IMassContainer` | `get_ReHaulageAllowed` |
| `IMassContainer` | `get_MustBeSolved` |

### `SectorType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.SectorType` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Soilworks.SectorType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cut` | `SectorType` | Yes | `Cut` | `` |
| `Fill` | `SectorType` | Yes | `Fill` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Cut` | `0` |
| `Fill` | `1` |

**Underlying Type**: `System.Int32`

### `Soilworks` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.Soilworks` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Soilworks.ITemplateItemsContainer, Topomatic.Soilworks.IMaterialsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.Soilworks`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `ConnectionLinks` | `ConnectionLink[]` | `get` | No | `` |
| `ConnectionLinksCount` | `Int32` | `get` | No | `` |
| `ContainerSoilworksObjects` | `ContainerSoilworksObject[]` | `get` | No | `` |
| `DefaultDumpColor` | `CadColor` | `get/set` | No | `` |
| `DefaultHaulageType` | `HaulageType` | `get` | No | `` |
| `DefaultJunkyardColor` | `CadColor` | `get/set` | No | `` |
| `DefaultPitColor` | `CadColor` | `get/set` | No | `` |
| `DefaultSpoilBankColor` | `CadColor` | `get/set` | No | `` |
| `Haulages` | `Haulage[]` | `get` | No | `` |
| `HaulagesCount` | `Int32` | `get` | No | `` |
| `HaulageTypes` | `HaulageType[]` | `get` | No | `` |
| `HaulageTypesCount` | `Int32` | `get` | No | `` |
| `LinearSoilworksObjects` | `LinearSoilworksObject[]` | `get` | No | `` |
| `Materials` | `Material[]` | `get` | No | `` |
| `MaterialsCount` | `Int32` | `get` | No | `` |
| `MinimumVolume` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PointSoilworksObjects` | `PointSoilworksObject[]` | `get` | No | `` |
| `SoilworksObjects` | `SoilworksObject[]` | `get` | No | `` |
| `SoilworksObjectsCount` | `Int32` | `get` | No | `` |
| `TemplateItems` | `TemplateItem[]` | `get` | No | `` |
| `TransportTypes` | `IList<HaulageType>` | `get` | No | `` |

#### Instance Methods (44)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddApplicability` | `Void` | `Applicability applicability` | `` |
| `AddConnectionLink` | `Void` | `ConnectionLink soilworksConnectionLink` | `` |
| `AddHaulage` | `Void` | `Haulage haulage` | `` |
| `AddHaulageType` | `Void` | `HaulageType transportType` | `` |
| `AddMaterial` | `Void` | `Material material` | `` |
| `AddSectorsLink` | `Void` | `Sector sector1, Sector sector2, Double distance` | `` |
| `AddSoilworksObject` | `Void` | `SoilworksObject soilworksObject` | `` |
| `AddTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `Clear` | `Void` | `` | `` |
| `ContainsHaulageType` | `Boolean` | `HaulageType haulageType` | `` |
| `CreateDefaultHaulageTypes` | `Void` | `` | `` |
| `CreateDefaultTemplateItems` | `Void` | `` | `` |
| `DistanceBetweenMassContainers` | `Double` | `IMassContainer sector1, IMassContainer sector2` | `` |
| `GetApplicability` | `Applicability` | `String name` | `` |
| `GetApplicability` | `Applicability` | `Guid id` | `` |
| `GetAvailableHaulageTypes` | `HaulageType[]` | `IMassContainer[] suppliers, IMassContainer[] recipients, Material material, Boolean checkMaterialToRecipientApplicability` | `` |
| `GetAvailableMaterials` | `Material[]` | `IMassContainer[] suppliers, IMassContainer[] recipients, Boolean checkApplicability` | `` |
| `GetAvailableMaterials` | `Material[]` | `IMassContainer[] suppliers, IMassContainer[] recipients, HaulageType haulageType` | `` |
| `GetConnectionLink` | `ConnectionLink` | `Int32 index` | `` |
| `GetHaulage` | `Haulage` | `Int32 index` | `` |
| `GetHaulages` | `Haulage[]` | `IMassContainer massContainer` | `` |
| `GetHaulageType` | `HaulageType` | `Guid id` | `` |
| `GetHaulageType` | `HaulageType` | `Int32 index` | `` |
| `GetMassContainer` | `IMassContainer` | `Guid id` | `` |
| `GetMaterial` | `Material` | `Int32 index` | `` |
| `GetMaterial` | `Material` | `String materialId` | `` |
| `GetMaterials` | `Material[]` | `String name` | `` |
| `GetPreferredHaulageType` | `HaulageType` | `IMassContainer supplier, IMassContainer recipient, Material material` | `` |
| `GetSoilworksObject` | `SoilworksObject` | `Guid id` | `` |
| `GetSoilworksObject` | `SoilworksObject` | `String name` | `` |
| `GetSoilworksObject` | `SoilworksObject` | `Int32 index` | `` |
| `IsApplicable` | `Boolean` | `IMassContainer recipient, Material material` | `` |
| `IsValidHaulageType` | `Boolean` | `IMassContainer supplier, IMassContainer recipient, Material material, HaulageType haulageType, Boolean checkMaterialToRecipientApplicability` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `OrganizeHaulages` | `Void` | `IMassContainer[] massContainers` | `` |
| `RemoveApplicability` | `Void` | `Applicability applicability` | `` |
| `RemoveConnectionLink` | `Void` | `ConnectionLink soilworksConnectionLink` | `` |
| `RemoveHaulage` | `Void` | `Haulage haulage` | `` |
| `RemoveHaulageType` | `Void` | `HaulageType haulageType` | `` |
| `RemoveMaterial` | `Void` | `Material material` | `` |
| `RemoveSectorsLink` | `Void` | `Sector sector1, Sector sector2` | `` |
| `RemoveSoilworksObject` | `Void` | `SoilworksObject soilworksObject` | `` |
| `RemoveTemplateItem` | `Void` | `TemplateItem templateItem` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanHaulage` | `Boolean` | `Material material, IMassContainer recipient` | `` |
| `CanHaulageFrom` | `Boolean` | `IMassContainer massContainer` | `` |
| `CanHaulageTo` | `Boolean` | `IMassContainer recipient` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `ITemplateItemsContainer` | `get_TemplateItems` |
| `ITemplateItemsContainer` | `RemoveTemplateItem` |
| `ITemplateItemsContainer` | `AddTemplateItem` |
| `ITemplateItemsContainer` | `get_Applicabilities` |
| `IMaterialsContainer` | `get_Materials` |
| `IMaterialsContainer` | `RemoveMaterial` |
| `IMaterialsContainer` | `AddMaterial` |

### `SoilworksConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.SoilworksConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_POINT_SOILWORKS_OBJECT_AREA_QUANTITY` | `Int32` | Yes | `10000` | `` |
| `DEFAULT_SECTOR_COLOR` | `Int32` | Yes | `15` | `` |
| `HAULAGE_DEFAULT_Y_POSITION_OFFSET` | `Double` | Yes | `20` | `` |
| `LINEAR_SECTOR_AXIS_DIST` | `Double` | Yes | `10` | `` |
| `MATERIAL_PRIORITIES_COUNT` | `Int32` | Yes | `10` | `` |
| `MAXIMUM_SEGMENT_VISIBLE_QUANTITY` | `UInt32` | Yes | `10000` | `` |
| `MINIMUM_SEGMENT_VISIBLE_QUANTITY` | `UInt32` | Yes | `300` | `` |
| `MODEL_TYPE` | `String` | Yes | `"soilworks"` | `` |
| `PARALLEL_SECTOR_DEFAULT_OFFSET` | `Double` | Yes | `20` | `` |
| `POINT_SOILWORKS_OBJECT_DEFAULT_HEIGHT` | `Int32` | Yes | `50` | `` |
| `POINT_SOILWORKS_OBJECT_DEFAULT_WIDTH` | `Int32` | Yes | `50` | `` |
| `SEGMENT_HEIGHT_VISIBLE_COEFF` | `UInt32` | Yes | `20` | `` |

### `SoilworksObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.SoilworksObject` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.SoilworksObject`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(SoilworksObject soilworksObject)`
- `.ctor(Soilworks owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `ConnectedPointObjects` | `PointSoilworksObject[]` | `get` | No | `Browsable` |
| `ConnectionLinks` | `ConnectionLink[]` | `get` | No | `Browsable` |
| `Id` | `Guid` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Soilworks` | `Soilworks` | `get` | No | `Browsable` |
| `Transit` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConnectedWith` | `Boolean` | `SoilworksObject soilworksObject` | `` |
| `Contains` | `Boolean` | `IMassContainer massContainer` | `Browsable` |
| `GetConnectionPointValueFromPosition` | `Boolean` | `Vector2D position, ref Object value` | `` |
| `GetSpecialMassContainers` | `IMassContainer[]` | `Boolean IsSupplier, Boolean IsRecipient` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `TemplateItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.TemplateItem` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Soilworks.TemplateItem`

#### Constructors (3)

- `.ctor(ITemplateItemsContainer owner)`
- `.ctor(ITemplateItemsContainer owner, TemplateItem templateItem)`
- `.ctor(ITemplateItemsContainer owner, TemplateItemModelType modelType)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Applicabilities` | `Applicability[]` | `get` | No | `` |
| `Code` | `Int32` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `ModelType` | `TemplateItemModelType` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `SummSides` | `Boolean` | `get/set` | No | `` |
| `TemplateItemsContainer` | `ITemplateItemsContainer` | `get` | No | `` |
| `Type` | `SectorType` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddApplicability` | `Void` | `Applicability applicability` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveApplicability` | `Void` | `Applicability applicability` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TemplateItemModelType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Soilworks.TemplateItemModelType` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Soilworks.TemplateItemModelType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Rail` | `TemplateItemModelType` | Yes | `Rail` | `` |
| `Road` | `TemplateItemModelType` | Yes | `Road` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Road` | `0` |
| `Rail` | `1` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 32 |
| **Classes** | 18 |
| **Interfaces** | 6 |
| **Enums** | 3 |
| **Structs** | 0 |
| **Abstract Classes** | 4 |
| **Static Classes** | 1 |
| **Total Methods** | 167 |
| **Total Properties** | 200 |
| **Total Fields** | 25 |
| **Total Events** | 0 |
| **Total Constructors** | 51 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


