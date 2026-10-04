# Topomatic.Cadastre

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cadastre` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cadastre.dll` |

---
## Namespace: `Topomatic.Cadastre`

### `Address` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Address` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Apartment` | `TypedString` | `get/set` | No | `` |
| `City` | `TypedString` | `get/set` | No | `` |
| `District` | `TypedString` | `get/set` | No | `` |
| `KLADR` | `String` | `get/set` | No | `` |
| `Level1` | `TypedString` | `get/set` | No | `` |
| `Level2` | `TypedString` | `get/set` | No | `` |
| `Locality` | `TypedString` | `get/set` | No | `` |
| `Note` | `String` | `get/set` | No | `` |
| `OKATO` | `String` | `get/set` | No | `` |
| `Other` | `String` | `get/set` | No | `` |
| `PostalCode` | `String` | `get/set` | No | `` |
| `ReadableAddress` | `String` | `get/set` | No | `` |
| `Region` | `String` | `get/set` | No | `` |
| `SovietVillage` | `TypedString` | `get/set` | No | `` |
| `Street` | `TypedString` | `get/set` | No | `` |
| `UrbanDistrict` | `TypedString` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Nested Types (1)

- `TypedString` (class)

### `Border` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Border` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Neighbours` | `String[]` | `get/set` | No | `` |
| `Point1` | `Int32` | `get/set` | No | `` |
| `Point2` | `Int32` | `get/set` | No | `` |
| `Spatial` | `Int32` | `get/set` | No | `` |

### `Borders` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Borders` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cadastre.Border, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cadastre.Borders`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Bound` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Bound` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BoundType boundType)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Boundaries` | `IList<Boundary>` | `get` | No | `` |
| `BoundType` | `BoundType` | `get` | No | `` |
| `Type` | `CadastralType` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RegistrationDate` | `String` | No | `` | `` |
| `RegNumbBorder` | `String` | No | `` | `` |

### `Boundary` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Boundary` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cadastre.EntitySpatial, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cadastre.Boundary`

#### Constructors (1)

- `.ctor(Bound owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bound` | `Bound` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BoundType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.BoundType` |
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
      - `Topomatic.Cadastre.BoundType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Coastline` | `BoundType` | Yes | `Coastline` | `` |
| `InhabitedLocality` | `BoundType` | Yes | `InhabitedLocality` | `` |
| `Municipal` | `BoundType` | Yes | `Municipal` | `` |
| `SpecialZone` | `BoundType` | Yes | `SpecialZone` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Municipal` | `0` |
| `InhabitedLocality` | `1` |
| `SpecialZone` | `2` |
| `Coastline` | `3` |

**Underlying Type**: `System.Int32`

### `CadastralNumber` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.CadastralNumber` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String sourceText)`
- `.ctor(String district, String area, String quarter, String number)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area` | `String` | `get` | No | `` |
| `District` | `String` | `get` | No | `` |
| `Number` | `String` | `get` | No | `` |
| `Part` | `String` | `get` | No | `` |
| `Quarter` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareTo` | `Int32` | `CadastralNumber cadastralNumber` | `` |
| `Equals` | `Boolean` | `Object cadastralNumber` | `` |
| `ToString` | `String` | `` | `` |

### `CadastralObject` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.CadastralObject` |
| **Base Type** | `System.Object` |
| **Implements** | `
.
, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area` | `String` | `get/set` | No | `` |
| `AscendantCadNumbers` | `IList<CadastralNumber>` | `get` | No | `` |
| `DescendantCadNumbers` | `IList<CadastralNumber>` | `get` | No | `` |
| `OldNumbers` | `IList<OldNumber>` | `get` | No | `` |
| `PermittedUses` | `IList<String>` | `get` | No | `` |
| `RegistrationDate` | `String` | `get/set` | No | `` |
| `Spatial` | `EntitySpatial` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CadastralNumber` | `CadastralNumber` | No | `` | `` |
| `Cost` | `Nullable<Double>` | No | `` | `` |
| `QuarterNumber` | `CadastralNumber` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `get_Area` |
| `
` | `set_Area` |
| `
` | `get_RegistrationDate` |
| `
` | `set_RegistrationDate` |

### `CadastralType` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.CadastralType` |
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
| `Code` | `String` | No | `` | `` |
| `Value` | `String` | No | `` | `` |

### `Cadastre` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Cadastre` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cadastre.Cadastre`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `IList<Bound>` | `get` | No | `` |
| `Districts` | `String[]` | `get` | No | `` |
| `ObjectsRealty` | `IList<Construction>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Parcels` | `IList<Parcel>` | `get` | No | `` |
| `RequestDate` | `String` | `get` | No | `` |
| `RightRecords` | `IEnumerable<RightRecord>` | `get` | No | `` |
| `SpatialData` | `IList<EntitySpatial>` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Boolean` | `CadastralObject cadastralObject` | `` |
| `GetAreasForDistrict` | `String[]` | `String district` | `` |
| `GetBound` | `Bound` | `String regNumber` | `` |
| `GetCadastralObject` | `CadastralObject` | `CadastralNumber cadastralNumber` | `` |
| `GetConstruction` | `Construction` | `CadastralNumber cadastralNumber` | `` |
| `GetParcel` | `Parcel` | `String district, String area, String quarter, String number` | `` |
| `GetParcel` | `Parcel` | `CadastralNumber cadastralNumber` | `` |
| `GetQuartersForArea` | `String[]` | `String district, String area` | `` |
| `LoadFromFile` | `Void` | `String fullpath` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `CoastlineBound` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.CoastlineBound` |
| **Base Type** | `Topomatic.Cadastre.Bound` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cadastre.Bound`
    - `Topomatic.Cadastre.CoastlineBound`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WaterObjectType` | `CadastralType` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `WaterObjectName` | `String` | No | `` | `` |

### `Construction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Construction` |
| **Base Type** | `Topomatic.Cadastre.CadastralObject` |
| **Implements** | `
.
, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cadastre.CadastralObject`
    - `Topomatic.Cadastre.Construction`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Address` | `Address` | `get` | No | `` |
| `Assignation` | `String` | `get/set` | No | `` |
| `ConstructionType` | `ConstructionType` | `get/set` | No | `` |
| `LandCadNumbers` | `IList<CadastralNumber>` | `get` | No | `` |
| `Purpose` | `CadastralType` | `get` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Floors` | `Nullable<Byte>` | No | `` | `` |
| `UndergroundFloors` | `Nullable<Byte>` | No | `` | `` |
| `YearBuilt` | `Nullable<UInt16>` | No | `` | `` |
| `YearCommisioning` | `Nullable<UInt16>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ConstructionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.ConstructionType` |
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
      - `Topomatic.Cadastre.ConstructionType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Building` | `ConstructionType` | Yes | `Building` | `` |
| `Construction` | `ConstructionType` | Yes | `Construction` | `` |
| `Uncompleted` | `ConstructionType` | Yes | `Uncompleted` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Building` | `0` |
| `Construction` | `1` |
| `Uncompleted` | `2` |

**Underlying Type**: `System.Int32`

### `EntitySpatial` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.EntitySpatial` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Borders` | `IList<Borders>` | `get` | No | `` |
| `Elements` | `IList<SpatialElement>` | `get` | No | `` |
| `InnerContours` | `SpatialElement[]` | `get` | No | `` |
| `OuterContours` | `SpatialElement[]` | `get` | No | `` |
| `Owner` | `Object` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Sk_Id` | `String` | No | `` | `` |

### `LandPlotPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.LandPlotPart` |
| **Base Type** | `System.Object` |
| **Implements** | `
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Parcel owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area` | `String` | `get/set` | No | `` |
| `Parcel` | `Parcel` | `get` | No | `` |
| `Restriction` | `Restriction` | `get` | No | `` |
| `Spatial` | `EntitySpatial` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Date` | `String` | No | `` | `` |
| `Mnemonic` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `get_Area` |
| `
` | `set_Area` |

### `OldNumber` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.OldNumber` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `CadastralType` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Assigner` | `String` | No | `` | `` |
| `AssignmentDate` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |

### `Parcel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Parcel` |
| **Base Type** | `Topomatic.Cadastre.CadastralObject` |
| **Implements** | `
.
, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cadastre.CadastralObject`
    - `Topomatic.Cadastre.Parcel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Addresses` | `IList<Address>` | `get` | No | `` |
| `Category` | `CadastralType` | `get` | No | `` |
| `IncludedObjects` | `IList<CadastralNumber>` | `get` | No | `` |
| `Restrictions` | `IList<Restriction>` | `get` | No | `` |
| `SubParcels` | `LandPlotPart[]` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSubParcel` | `Void` | `LandPlotPart landPlotPart` | `` |
| `GetSubParcel` | `LandPlotPart` | `String partNumber` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Restriction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Restriction` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEasement` | `Boolean` | `get` | No | `` |
| `Type` | `CadastralType` | `get` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Content` | `String` | No | `` | `` |
| `PartNumber` | `String` | No | `` | `` |
| `RegNumberBorder` | `String` | No | `` | `` |

### `RightHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.RightHolder` |
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
| `Individual` | `Boolean` | No | `` | `` |
| `Name` | `String` | No | `` | `` |

### `RightRecord` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.RightRecord` |
| **Base Type** | `System.Object` |
| **Implements** | `
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RegistrationDate` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RightHolders` | `List<RightHolder>` | No | `` | `` |
| `RightNumber` | `String` | No | `` | `` |
| `RightType` | `CadastralType` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `get_RegistrationDate` |
| `
` | `set_RegistrationDate` |

### `SpatialElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.SpatialElement` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cadastre.SpelementUnit, Topomatic.Cadastre, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cadastre.SpatialElement`

#### Constructors (1)

- `.ctor(EntitySpatial entitySpatial)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `Vector2D[]` | `get` | No | `` |
| `EntitySpatial` | `EntitySpatial` | `get` | No | `` |
| `Guid` | `Guid` | `get` | No | `` |
| `InnerContours` | `SpatialElement[]` | `get` | No | `` |
| `IsClosed` | `Boolean` | `get` | No | `` |
| `IsOuter` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SpelementUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.SpelementUnit` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Number` | `Int32` | `get/set` | No | `` |
| `R` | `Nullable<Double>` | `get/set` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToVector2D` | `Vector2D` | `` | `` |

### `TypedString` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.Address+TypedString` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `String` | `get/set` | No | `` |
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `ZoneBound` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cadastre.ZoneBound` |
| **Base Type** | `Topomatic.Cadastre.Bound` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cadastre.Bound`
    - `Topomatic.Cadastre.ZoneBound`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TypeZone` | `CadastralType` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Index` | `String` | No | `` | `` |
| `Number` | `String` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 24 |
| **Classes** | 22 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 20 |
| **Total Properties** | 81 |
| **Total Fields** | 38 |
| **Total Events** | 0 |
| **Total Constructors** | 23 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


