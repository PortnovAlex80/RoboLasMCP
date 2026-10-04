# Topomatic.Proj

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Proj` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Proj, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Proj.dll` |

---
## Namespace: `Topomatic.Proj`

### `CoordinatePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Degree+CoordinatePosition` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Proj.Degree+CoordinatePosition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `E` | `CoordinatePosition` | Yes | `E` | `` |
| `N` | `CoordinatePosition` | Yes | `N` | `` |
| `S` | `CoordinatePosition` | Yes | `S` | `` |
| `value__` | `Int32` | No | `` | `` |
| `W` | `CoordinatePosition` | Yes | `W` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `N` | `0` |
| `E` | `1` |
| `S` | `2` |
| `W` | `3` |

**Underlying Type**: `System.Int32`

### `DefaultFoldersGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.DefaultFoldersGenerator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateDefaultFolders` | `Void` | `ProjEngine projEngine, Boolean createUserFolder` | `` |
| `GenerateLocaleFolder` | `Void` | `ProjEngine projEngine` | `` |

### `Degree` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Degree` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Degrees` | `Double` | `get` | No | `` |
| `Minutes` | `Double` | `get` | No | `` |
| `Position` | `String` | `get` | No | `` |
| `Seconds` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LatFromDouble` | `Degree` | `Double value` | `` |
| `LonFromDouble` | `Degree` | `Double value` | `` |

#### Nested Types (1)

- `CoordinatePosition` (enum)

### `Folder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Folder` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.Folder`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, FolderType folderType)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Children` | `NamedInfo[]` | `get` | No | `` |
| `Locale` | `Boolean` | `get/set` | No | `` |
| `Removable` | `Boolean` | `get` | No | `` |
| `Type` | `FolderType` | `get/set` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `IsAncestorOf` | `Boolean` | `Folder folder` | `` |

#### Nested Types (1)

- `FolderType` (enum)

### `FolderType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Folder+FolderType` |
| **Base Type** | `System.Enum` |
| **Implements** | `System.IComparable, System.IFormattable, System.IConvertible` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `System.Enum`
      - `Topomatic.Proj.Folder+FolderType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CRS` | `FolderType` | Yes | `CRS` | `` |
| `Datum` | `FolderType` | Yes | `Datum` | `` |
| `Ellipsoid` | `FolderType` | Yes | `Ellipsoid` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CRS` | `0` |
| `Datum` | `1` |
| `Ellipsoid` | `2` |

**Underlying Type**: `System.Int32`

### `IProjConsoleListener` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.IProjConsoleListener` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `WriteLine` | `Void` | `String text, Double x, Double y, Double z` | `` |
| `WriteLine` | `Void` | `String text, Double x, Double y` | `` |
| `WriteLine` | `Void` | `String text` | `` |

### `ProjConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.ProjConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CUSTOM_OBJECT_NAME` | `String` | Yes | `"CUSTOM"` | `` |
| `DEFAULT_NAME` | `String` | Yes | `"UNDEFINED"` | `` |
| `EPSG` | `String` | Yes | `"EPSG"` | `` |
| `ESRI` | `String` | Yes | `"ESRI"` | `` |

### `ProjEngine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.ProjEngine` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleUnits` | `AngleUnit[]` | `get` | No | `` |
| `Areas` | `Area[]` | `get` | No | `` |
| `AxisCoordinateSystems` | `AxisCoordinateSystem[]` | `get` | No | `` |
| `ConversedCoordinateSystems` | `ConversedCoordinateSystem[]` | `get` | No | `` |
| `Current` | `ProjEngine` | `get` | Yes | `` |
| `DerivedCoordinateSystems` | `DerivedCoordinateSystem[]` | `get` | No | `` |
| `DerivingConversionMethods` | `DerivingConversionMethod[]` | `get` | No | `` |
| `DerivingConversions` | `DerivingConversion[]` | `get` | No | `` |
| `Ellipsoids` | `Ellipsoid[]` | `get` | No | `` |
| `Folders` | `Folder[]` | `get` | No | `` |
| `GeographicCoordinateSystems` | `GeographicCoordinateSystem[]` | `get` | No | `` |
| `HelmertTransformations` | `HelmertTransformation[]` | `get` | No | `` |
| `HorizontalCoordinateSystems` | `HorizontalCoordinateSystem[]` | `get` | No | `` |
| `HorizontalDatums` | `HorizontalDatum[]` | `get` | No | `` |
| `Instance` | `ProjEngine` | `get` | Yes | `` |
| `LengthUnits` | `LengthUnit[]` | `get` | No | `` |
| `PrimeMeridians` | `PrimeMeridian[]` | `get` | No | `` |
| `ProjectedConversionMethods` | `ProjectedConversionMethod[]` | `get` | No | `` |
| `ProjectedCoordinateSystems` | `ProjectedCoordinateSystem[]` | `get` | No | `` |
| `Projections` | `Projection[]` | `get` | No | `` |
| `ScaleUnits` | `ScaleUnit[]` | `get` | No | `` |
| `Scopes` | `Scope[]` | `get` | No | `` |
| `Units` | `Unit[]` | `get` | No | `` |

#### Instance Methods (48)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddArea` | `Void` | `Area area` | `` |
| `AddAxisCoordinateSystem` | `Void` | `AxisCoordinateSystem axisCoordinateSystem` | `` |
| `AddConversion` | `Void` | `Conversion conversion` | `` |
| `AddDerivingConversionMethod` | `Void` | `DerivingConversionMethod derivingConversionMethod` | `` |
| `AddEllipsoid` | `Void` | `Ellipsoid ellipsoid` | `` |
| `AddFolder` | `Void` | `Folder folder` | `` |
| `AddHelmertTransformation` | `Void` | `HelmertTransformation helmertTransformation` | `` |
| `AddHorizontalCoordinateSystem` | `Void` | `HorizontalCoordinateSystem horizontalCRS` | `` |
| `AddHorizontalDatum` | `Void` | `HorizontalDatum horizontalDatum` | `` |
| `AddPrimeMeridian` | `Void` | `PrimeMeridian primeMeridian` | `` |
| `AddProjectedConversionMethod` | `Void` | `ProjectedConversionMethod projectedConversionMethod` | `` |
| `AddScope` | `Void` | `Scope scope` | `` |
| `AddUnit` | `Void` | `Unit unit` | `` |
| `ClearLocales` | `Void` | `` | `` |
| `ClearUserData` | `Void` | `` | `` |
| `CommitChanges` | `Void` | `` | `` |
| `GenerateUniqueCRSName` | `String` | `String baseName` | `` |
| `GetDerivingConversionMethod` | `DerivingConversionMethod` | `DerivingConversionMethodType type` | `` |
| `GetEllipsoid` | `Ellipsoid` | `Guid id` | `` |
| `GetHelmertTransformation` | `HelmertTransformation` | `HorizontalDatum sourceDatum, HorizontalDatum targetDatum, ref Boolean inverted` | `` |
| `GetHelmertTransformation` | `HelmertTransformation` | `Guid id` | `` |
| `GetHorizontalCoordinateSystem` | `HorizontalCoordinateSystem` | `Guid id` | `` |
| `GetHorizontalDatum` | `HorizontalDatum` | `Guid id` | `` |
| `GetProjectedConversionMethod` | `ProjectedConversionMethod` | `ProjectedConversionMethodType type` | `` |
| `IsExistsArea` | `Boolean` | `Area area, ref Area existingArea` | `` |
| `IsExistsAxisCoordinateSystem` | `Boolean` | `AxisCoordinateSystem axisCoordinateSystem, ref AxisCoordinateSystem existingAxisCoordianteSystem` | `` |
| `IsExistsConversion` | `Boolean` | `Conversion conversion, ref Conversion existingConversion` | `` |
| `IsExistsEllipsoid` | `Boolean` | `Ellipsoid ellipsoid, ref Ellipsoid existingEllipsoid` | `` |
| `IsExistsHorizontalCRS` | `Boolean` | `HorizontalCoordinateSystem horizontalCRS, ref HorizontalCoordinateSystem existingHorizontalCRS` | `` |
| `IsExistsHorizontalDatum` | `Boolean` | `HorizontalDatum horizontalDatum, ref HorizontalDatum existingHorizontalDatum` | `` |
| `IsExistsPrimeMeridian` | `Boolean` | `PrimeMeridian primeMeridian, ref PrimeMeridian existingPrimeMeridian` | `` |
| `IsExistsScope` | `Boolean` | `Scope scope, ref Scope existingScope` | `` |
| `IsExistsUnit` | `Boolean` | `Unit unit, ref Unit existingUnit` | `` |
| `LoadFolders` | `Void` | `StgNode node` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveArea` | `Void` | `Area area` | `` |
| `RemoveConversedCoordinateSystem` | `Void` | `ConversedCoordinateSystem conversedCRS` | `` |
| `RemoveEllipsoid` | `Void` | `Ellipsoid ellipsoid` | `` |
| `RemoveFolder` | `Void` | `Folder folder` | `` |
| `RemoveHelmertTransformation` | `Void` | `HelmertTransformation helmertTransformation` | `` |
| `RemoveHorizontalDatum` | `Void` | `HorizontalDatum horizontalDatum` | `` |
| `SaveToStg` | `Void` | `StgNode node, Boolean locale` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetFolderForObject` | `Void` | `NamedInfo namedInfo, Folder folder` | `` |
| `UndoChanges` | `Void` | `` | `` |
| `WriteLog` | `Void` | `String text, Double x, Double y` | `` |
| `WriteLog` | `Void` | `String text, Double x, Double y, Double z` | `` |
| `WriteLog` | `Void` | `String text` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConsoleListener` | `IProjConsoleListener` | Yes | `` | `` |
| `DevMode` | `Boolean` | Yes | `` | `` |
| `UserDatabaseFilePath` | `String` | Yes | `` | `` |

---
## Namespace: `Topomatic.Proj.CoordinateSystems`

### `Alias` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Alias` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, String source)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Source` | `String` | `get` | No | `` |

### `AngleUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AngleUnit` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Unit` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.Unit`
        - `Topomatic.Proj.CoordinateSystems.AngleUnit`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArcSecond` | `AngleUnit` | `get` | Yes | `` |
| `Degrees` | `AngleUnit` | `get` | Yes | `` |
| `Gon` | `AngleUnit` | `get` | Yes | `` |
| `Grad` | `AngleUnit` | `get` | Yes | `` |
| `Radian` | `AngleUnit` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Area` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Area` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.DescriptedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Area`

#### Constructors (1)

- `.ctor(String name, Double southLat, Double westLon, Double northLat, Double eastLon, Authority authority, String description)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EastLon` | `Double` | `get/set` | No | `` |
| `EuropeED50` | `Area` | `get` | Yes | `` |
| `EuropeETRS89` | `Area` | `get` | Yes | `` |
| `NorthLat` | `Double` | `get/set` | No | `` |
| `SouthLat` | `Double` | `get/set` | No | `` |
| `WestLon` | `Double` | `get/set` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |
| `World` | `Area` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `NormalizeLat` | `Void` | `ref Double value` | `` |
| `NormalizeLon` | `Void` | `ref Double value` | `` |

### `Authority` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Authority` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String name, Int32 code)`
- `.ctor(String name, String code)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `String` | `get` | No | `` |
| `Default` | `Authority` | `get` | Yes | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

### `AuthorityInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Authority authority)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Authority` | `Authority` | `get/set` | No | `` |
| `Id` | `Guid` | `get` | No | `` |
| `ReadOnly` | `Boolean` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `AxisCoordinateSystem` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AxisCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.AxisCoordinateSystem`

#### Constructors (1)

- `.ctor(AxisCoordinateSytemType axisCoordinateSystemType, AxisInfo[] axisInfo, Authority authority)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultGeocentric` | `AxisCoordinateSystem` | `get` | Yes | `` |
| `DefaultGeodetic` | `AxisCoordinateSystem` | `get` | Yes | `` |
| `DefaultProjected` | `AxisCoordinateSystem` | `get` | Yes | `` |
| `Dimension` | `Int32` | `get` | No | `` |
| `Item` | `AxisInfo` | `get` | No | `` |
| `Type` | `AxisCoordinateSytemType` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `AxisCoordinateSytemType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AxisCoordinateSytemType` |
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
      - `Topomatic.Proj.CoordinateSystems.AxisCoordinateSytemType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cartesian` | `AxisCoordinateSytemType` | Yes | `Cartesian` | `` |
| `Ellipsoidal` | `AxisCoordinateSytemType` | Yes | `Ellipsoidal` | `` |
| `Ordinal` | `AxisCoordinateSytemType` | Yes | `Ordinal` | `` |
| `Spherical` | `AxisCoordinateSytemType` | Yes | `Spherical` | `` |
| `value__` | `Byte` | No | `` | `` |
| `Vertical` | `AxisCoordinateSytemType` | Yes | `Vertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Cartesian` | `0` |
| `Vertical` | `1` |
| `Ellipsoidal` | `2` |
| `Spherical` | `3` |
| `Ordinal` | `4` |

**Underlying Type**: `System.Byte`

### `AxisInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AxisInfo` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.AxisInfo`

#### Constructors (1)

- `.ctor(String name, AxisOrientation axisOrientation, Meridian meridian, Unit unit, Byte order, String abbrev, Authority authority)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Abbrev` | `String` | `get` | No | `` |
| `AxisOrientation` | `AxisOrientation` | `get` | No | `` |
| `DefaultGeocentricX` | `AxisInfo` | `get` | Yes | `` |
| `DefaultGeocentricY` | `AxisInfo` | `get` | Yes | `` |
| `DefaultGeocentricZ` | `AxisInfo` | `get` | Yes | `` |
| `DefaultLat` | `AxisInfo` | `get` | Yes | `` |
| `DefaultLon` | `AxisInfo` | `get` | Yes | `` |
| `DefaultX` | `AxisInfo` | `get` | Yes | `` |
| `DefaultY` | `AxisInfo` | `get` | Yes | `` |
| `Meridian` | `Meridian` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |
| `Unit` | `Unit` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `AxisOrientation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.AxisOrientation` |
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
      - `Topomatic.Proj.CoordinateSystems.AxisOrientation`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `down` | `AxisOrientation` | Yes | `down` | `` |
| `east` | `AxisOrientation` | Yes | `east` | `` |
| `geocentricX` | `AxisOrientation` | Yes | `geocentricX` | `` |
| `geocentricY` | `AxisOrientation` | Yes | `geocentricY` | `` |
| `geocentricZ` | `AxisOrientation` | Yes | `geocentricZ` | `` |
| `north` | `AxisOrientation` | Yes | `north` | `` |
| `other` | `AxisOrientation` | Yes | `other` | `` |
| `south` | `AxisOrientation` | Yes | `south` | `` |
| `up` | `AxisOrientation` | Yes | `up` | `` |
| `value__` | `Byte` | No | `` | `` |
| `west` | `AxisOrientation` | Yes | `west` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `other` | `0` |
| `north` | `1` |
| `south` | `2` |
| `east` | `3` |
| `west` | `4` |
| `up` | `5` |
| `down` | `6` |
| `geocentricX` | `7` |
| `geocentricY` | `8` |
| `geocentricZ` | `9` |

**Underlying Type**: `System.Byte`

### `BoundCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.BoundCoordinateSystem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CoordinateSystem geocCrsSource, CoordinateSystem geocCrsTarget, HelmertTransformation helmertTransformation)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `ConversedCoordinateSystem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem`
              - `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseCoordinateSystem` | `HorizontalCoordinateSystem` | `get` | No | `` |
| `GeographicCRS` | `GeographicCoordinateSystem` | `get/set` | No | `` |
| `Locale` | `Boolean` | `get/set` | No | `` |
| `Parent` | `Folder` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Conversion` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Conversion` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.DescriptedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Conversion`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Parameters` | `ConversionParameter[]` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `GetParameter` | `ConversionParameter` | `ConversionParameterType type` | `` |

### `ConversionParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ConversionParameter` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.ConversionParameter`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `ConversionParameterType` | `get` | No | `` |
| `Unit` | `Unit` | `get/set` | No | `` |
| `Value` | `Double` | `get/set` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertValue` | `Double` | `Unit unit` | `` |
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `ConversionParameterFactory` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ConversionParameterFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateConversionParameter` | `ConversionParameter` | `ConversionParameterType type, Double value, Unit unit` | `` |
| `CreateConversionParameter` | `ConversionParameter` | `String alias, Double value, Unit unit` | `` |

### `ConversionParameterType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ConversionParameterType` |
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
      - `Topomatic.Proj.CoordinateSystems.ConversionParameterType`

#### Fields (36)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A0` | `ConversionParameterType` | Yes | `A0` | `` |
| `A1` | `ConversionParameterType` | Yes | `A1` | `` |
| `A2` | `ConversionParameterType` | Yes | `A2` | `` |
| `AngleFromRectifiedtoSkewGrid` | `ConversionParameterType` | Yes | `AngleFromRectifiedtoSkewGrid` | `` |
| `AzimuthOfInialLine` | `ConversionParameterType` | Yes | `AzimuthOfInialLine` | `` |
| `B0` | `ConversionParameterType` | Yes | `B0` | `` |
| `B1` | `ConversionParameterType` | Yes | `B1` | `` |
| `B2` | `ConversionParameterType` | Yes | `B2` | `` |
| `CoLatitudeOfConeAxis` | `ConversionParameterType` | Yes | `CoLatitudeOfConeAxis` | `` |
| `EastingAtProjectionCentre` | `ConversionParameterType` | Yes | `EastingAtProjectionCentre` | `` |
| `EastingOfFalseOrigin` | `ConversionParameterType` | Yes | `EastingOfFalseOrigin` | `` |
| `FalseEasting` | `ConversionParameterType` | Yes | `FalseEasting` | `` |
| `FalseNorthing` | `ConversionParameterType` | Yes | `FalseNorthing` | `` |
| `LatitudeOfFalseOrigin` | `ConversionParameterType` | Yes | `LatitudeOfFalseOrigin` | `` |
| `LatitudeOfFirstStandartParallel` | `ConversionParameterType` | Yes | `LatitudeOfFirstStandartParallel` | `` |
| `LatitudeOfNaturalOrigin` | `ConversionParameterType` | Yes | `LatitudeOfNaturalOrigin` | `` |
| `LatitudeOfProjectionCentre` | `ConversionParameterType` | Yes | `LatitudeOfProjectionCentre` | `` |
| `LatitudeOfPseudoStandardParallel` | `ConversionParameterType` | Yes | `LatitudeOfPseudoStandardParallel` | `` |
| `LatitudeOfSecondStandartParallel` | `ConversionParameterType` | Yes | `LatitudeOfSecondStandartParallel` | `` |
| `LongitudeOfFalseOrigin` | `ConversionParameterType` | Yes | `LongitudeOfFalseOrigin` | `` |
| `LongitudeOfNaturalOrigin` | `ConversionParameterType` | Yes | `LongitudeOfNaturalOrigin` | `` |
| `LongitudeOfOrigin` | `ConversionParameterType` | Yes | `LongitudeOfOrigin` | `` |
| `LongitudeOfProjectionCentre` | `ConversionParameterType` | Yes | `LongitudeOfProjectionCentre` | `` |
| `NorthingAtProjectionCentre` | `ConversionParameterType` | Yes | `NorthingAtProjectionCentre` | `` |
| `NorthingOfFalseOrigin` | `ConversionParameterType` | Yes | `NorthingOfFalseOrigin` | `` |
| `ScaleDifference` | `ConversionParameterType` | Yes | `ScaleDifference` | `` |
| `ScaleFactorAtNaturalOrigin` | `ConversionParameterType` | Yes | `ScaleFactorAtNaturalOrigin` | `` |
| `ScaleFactorOfInitialLine` | `ConversionParameterType` | Yes | `ScaleFactorOfInitialLine` | `` |
| `ScaleFactorOnPseudoStandardParallel` | `ConversionParameterType` | Yes | `ScaleFactorOnPseudoStandardParallel` | `` |
| `value__` | `Int32` | No | `` | `` |
| `XAxisRotation` | `ConversionParameterType` | Yes | `XAxisRotation` | `` |
| `XAxisTranslation` | `ConversionParameterType` | Yes | `XAxisTranslation` | `` |
| `YAxisRotation` | `ConversionParameterType` | Yes | `YAxisRotation` | `` |
| `YAxisTranslation` | `ConversionParameterType` | Yes | `YAxisTranslation` | `` |
| `ZAxisRotation` | `ConversionParameterType` | Yes | `ZAxisRotation` | `` |
| `ZAxisTranslation` | `ConversionParameterType` | Yes | `ZAxisTranslation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CoLatitudeOfConeAxis` | `1036` |
| `XAxisTranslation` | `8605` |
| `YAxisTranslation` | `8606` |
| `ZAxisTranslation` | `8607` |
| `XAxisRotation` | `8608` |
| `YAxisRotation` | `8609` |
| `ZAxisRotation` | `8610` |
| `ScaleDifference` | `8611` |
| `A0` | `8623` |
| `A1` | `8624` |
| `A2` | `8625` |
| `B0` | `8639` |
| `B1` | `8640` |
| `B2` | `8641` |
| `LatitudeOfNaturalOrigin` | `8801` |
| `LongitudeOfNaturalOrigin` | `8802` |
| `ScaleFactorAtNaturalOrigin` | `8805` |
| `FalseEasting` | `8806` |
| `FalseNorthing` | `8807` |
| `LatitudeOfProjectionCentre` | `8811` |
| `LongitudeOfProjectionCentre` | `8812` |
| `AzimuthOfInialLine` | `8813` |
| `AngleFromRectifiedtoSkewGrid` | `8814` |
| `ScaleFactorOfInitialLine` | `8815` |
| `EastingAtProjectionCentre` | `8816` |
| `NorthingAtProjectionCentre` | `8817` |
| `LatitudeOfPseudoStandardParallel` | `8818` |
| `ScaleFactorOnPseudoStandardParallel` | `8819` |
| `LatitudeOfFalseOrigin` | `8821` |
| `LongitudeOfFalseOrigin` | `8822` |
| `LatitudeOfFirstStandartParallel` | `8823` |
| `LatitudeOfSecondStandartParallel` | `8824` |
| `EastingOfFalseOrigin` | `8826` |
| `NorthingOfFalseOrigin` | `8827` |
| `LongitudeOfOrigin` | `8833` |

**Underlying Type**: `System.Int32`

### `CoordinateSystem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.CoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.ScopedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AxisCoordinateSystem` | `AxisCoordinateSystem` | `get/set` | No | `` |
| `Dimension` | `Int32` | `get` | No | `` |
| `TextDefinition` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `GetAxis` | `AxisInfo` | `Int32 dimension` | `` |
| `GetUnit` | `Unit` | `Int32 dimension` | `` |

### `CoordinateSystemFactory` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.CoordinateSystemFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateAngleUnit` | `AngleUnit` | `String name, Double radiansPerUnit, Authority authority` | `` |
| `CreateAuthority` | `Authority` | `String name, String code` | `` |
| `CreateAxisCoordinateSystem` | `AxisCoordinateSystem` | `AxisCoordinateSytemType axisCoordinateSystemType, AxisInfo[] axisInfo, Authority authority` | `` |
| `CreateAxisInfo` | `AxisInfo` | `String name, AxisOrientation axisOrientation, Meridian meridian, Unit unit, Byte order, String abbrev, Authority authority` | `` |
| `CreateDerivedAffineCoordinateSystem` | `DerivedCoordinateSystem` | `String name` | `` |
| `CreateDerivedAffineCoordinateSystem` | `DerivedCoordinateSystem` | `` | `` |
| `CreateEllipsoid` | `Ellipsoid` | `String name` | `` |
| `CreateEllipsoid` | `Ellipsoid` | `String name, Double semiMajorAxis, Double semiMinorAxis, LengthUnit axisUnit, Authority authority, String description` | `` |
| `CreateFittedCoordinateSystem` | `FittedCoordinateSystem` | `String name, CoordinateSystem baseCoordinateSystem, String toBaseWkt, List<AxisInfo> arAxes` | `` |
| `CreateFlattenedSphere` | `Ellipsoid` | `String name, Double semiMajorAxis, Double invFlattening, LengthUnit axisUnit, Authority authority, String description` | `` |
| `CreateFromFile` | `CoordinateSystem` | `String fileName` | `` |
| `CreateFromWKTText` | `CoordinateSystem` | `String wktText` | `` |
| `CreateGeocentricCoordinateSystem` | `GeocentricCoordinateSystem` | `String name, AxisCoordinateSystem axisCoordinateSystem, HorizontalDatum datum, Usage usage` | `` |
| `CreateGeocentricCoordinateSystem` | `GeocentricCoordinateSystem` | `String name, AxisCoordinateSystem axisCoordinateSystem, HorizontalDatum datum, Usage usage, Authority authority, String description, String textDefinition` | `` |
| `CreateGeographicCoordinateSystem` | `GeographicCoordinateSystem` | `String name` | `` |
| `CreateHelmertTransformation` | `HelmertTransformation` | `HorizontalDatum sourceDatum, HorizontalDatum targetDatum, ConversionParameter[] parameters, Usage usage, Authority authority` | `` |
| `CreateHorizontalDatum` | `HorizontalDatum` | `String name` | `` |
| `CreateLengthUnit` | `LengthUnit` | `String name, Double metersPerUnit, Authority authority` | `` |
| `CreateMeridian` | `Meridian` | `Double longitude, AngleUnit angleUnit` | `` |
| `CreatePrimeMeridian` | `PrimeMeridian` | `String name, Double longitude, AngleUnit angularUnit, Authority authority` | `` |
| `CreateProjectedCoordinateSystem` | `ProjectedCoordinateSystem` | `String name` | `` |
| `CreateProjection` | `Projection` | `String name` | `` |
| `CreateScaleUnit` | `ScaleUnit` | `String name, Double scaleFactor, Authority authority` | `` |

### `Datum` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Datum` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.ScopedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.Datum`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PublicationDate` | `String` | `get` | No | `` |
| `Removable` | `Boolean` | `get` | No | `` |

### `DatumType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DatumType` |
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
      - `Topomatic.Proj.CoordinateSystems.DatumType`

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HD_Classic` | `DatumType` | Yes | `HD_Classic` | `` |
| `HD_Geocentric` | `DatumType` | Yes | `HD_Geocentric` | `` |
| `HD_Max` | `DatumType` | Yes | `HD_Max` | `` |
| `HD_Min` | `DatumType` | Yes | `HD_Other` | `` |
| `HD_Other` | `DatumType` | Yes | `HD_Other` | `` |
| `LD_Max` | `DatumType` | Yes | `LD_Max` | `` |
| `LD_Min` | `DatumType` | Yes | `LD_Min` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VD_AltitudeBarometric` | `DatumType` | Yes | `VD_AltitudeBarometric` | `` |
| `VD_Depth` | `DatumType` | Yes | `VD_Depth` | `` |
| `VD_Ellipsoidal` | `DatumType` | Yes | `VD_Ellipsoidal` | `` |
| `VD_GeoidModelDerived` | `DatumType` | Yes | `VD_GeoidModelDerived` | `` |
| `VD_Max` | `DatumType` | Yes | `VD_Max` | `` |
| `VD_Min` | `DatumType` | Yes | `VD_Min` | `` |
| `VD_Normal` | `DatumType` | Yes | `VD_Normal` | `` |
| `VD_Orthometric` | `DatumType` | Yes | `VD_Orthometric` | `` |
| `VD_Other` | `DatumType` | Yes | `VD_Min` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `HD_Min` | `1000` |
| `HD_Other` | `1000` |
| `HD_Classic` | `1001` |
| `HD_Geocentric` | `1002` |
| `HD_Max` | `1999` |
| `VD_Min` | `2000` |
| `VD_Other` | `2000` |
| `VD_Orthometric` | `2001` |
| `VD_Ellipsoidal` | `2002` |
| `VD_AltitudeBarometric` | `2003` |
| `VD_Normal` | `2004` |
| `VD_GeoidModelDerived` | `2005` |
| `VD_Depth` | `2006` |
| `VD_Max` | `2999` |
| `LD_Min` | `10000` |
| `LD_Max` | `32767` |

**Underlying Type**: `System.Int32`

### `DerivedCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DerivedCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem`
              - `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem`
                - `Topomatic.Proj.CoordinateSystems.DerivedCoordinateSystem`

#### Constructors (1)

- `.ctor(String name, AxisCoordinateSystem axisCoordinateSystem, ProjectedCoordinateSystem projectedCoordinateSystem, DerivingConversion derivingConversion, Usage usage, Authority authority, String description, String textDefinition)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DerivingConversion` | `DerivingConversion` | `get/set` | No | `` |
| `GeographicCRS` | `GeographicCoordinateSystem` | `get/set` | No | `` |
| `HorizontalDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `ProjectedCRS` | `ProjectedCoordinateSystem` | `get/set` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `DerivingConversion` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DerivingConversion` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Conversion` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Conversion`
          - `Topomatic.Proj.CoordinateSystems.DerivingConversion`

#### Constructors (1)

- `.ctor(String name, DerivingConversionMethod conversionMethod, ConversionParameter[] parameters, Authority authority, String description)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Method` | `DerivingConversionMethod` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `DerivingConversionMethod` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DerivingConversionMethod` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.DerivingConversionMethod`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Affine` | `DerivingConversionMethod` | `get` | Yes | `` |
| `Type` | `DerivingConversionMethodType` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `DerivingConversionMethodFactory` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DerivingConversionMethodFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateConversionMethod` | `DerivingConversionMethod` | `String alias` | `` |
| `GetConversionMethod` | `DerivingConversionMethod` | `DerivingConversionMethodType type` | `` |
| `GetDefaultAlias` | `String` | `DerivingConversionMethodType type` | `` |

### `DerivingConversionMethodType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DerivingConversionMethodType` |
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
      - `Topomatic.Proj.CoordinateSystems.DerivingConversionMethodType`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Affine` | `DerivingConversionMethodType` | Yes | `Affine` | `` |
| `value__` | `Int16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Affine` | `9624` |

**Underlying Type**: `System.Int16`

### `DescriptedInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.DescriptedInfo` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`

#### Constructors (1)

- `.ctor(String name, Authority authority, String description)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |

### `Ellipsoid` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Ellipsoid` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.DescriptedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Ellipsoid`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AxisUnit` | `LengthUnit` | `get` | No | `` |
| `Clarke1866` | `Ellipsoid` | `get` | Yes | `` |
| `Clarke1880` | `Ellipsoid` | `get` | Yes | `` |
| `E` | `Double` | `get` | No | `` |
| `GRS80` | `Ellipsoid` | `get` | Yes | `` |
| `International1924` | `Ellipsoid` | `get` | Yes | `` |
| `InverseFlattening` | `Double` | `get/set` | No | `` |
| `Removable` | `Boolean` | `get` | No | `` |
| `SemiMajorAxis` | `Double` | `get/set` | No | `` |
| `SemiMinorAxis` | `Double` | `get/set` | No | `` |
| `Sphere` | `Ellipsoid` | `get` | Yes | `` |
| `WGS72` | `Ellipsoid` | `get` | Yes | `` |
| `WGS84` | `Ellipsoid` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `FittedCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.FittedCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.CoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.FittedCoordinateSystem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseCoordinateSystem` | `CoordinateSystem` | `get` | No | `` |
| `ToBaseTransform` | `MathTransform` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `GeocentricCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.GeocentricCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.CoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.GeocentricCoordinateSystem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `WGS84` | `GeocentricCoordinateSystem` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `GeographicCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.GeographicCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem`
              - `Topomatic.Proj.CoordinateSystems.GeographicCoordinateSystem`

#### Constructors (1)

- `.ctor(String name, AxisCoordinateSystem axisCoordinateSystem, HorizontalDatum horizontalDatum, Usage usage, Authority authority, String description, String textDefinition)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `Pulkovo1942` | `GeographicCoordinateSystem` | `get` | Yes | `` |
| `Pulkovo1995` | `GeographicCoordinateSystem` | `get` | Yes | `` |
| `PZ1990` | `GeographicCoordinateSystem` | `get` | Yes | `` |
| `WGS84` | `GeographicCoordinateSystem` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `HelmertTransformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.HelmertTransformation` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Conversion` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Conversion`
          - `Topomatic.Proj.CoordinateSystems.HelmertTransformation`

#### Constructors (1)

- `.ctor(String name, HorizontalDatum sourceDatum, HorizontalDatum targetDatum, ConversionParameter[] parameters, Authority authority, String description)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IntermediateTransfroms` | `HelmertTransformation[]` | `get` | No | `` |
| `SourceDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `TargetDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddIntermediateTransform` | `Void` | `HelmertTransformation helmertTransformation` | `` |
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `RemoveLastIntermediateTransform` | `Void` | `` | `` |

### `HorizontalCoordinateSystem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.CoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HorizontalDatum` | `HorizontalDatum` | `get/set` | No | `` |

### `HorizontalDatum` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.HorizontalDatum` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Datum` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.Datum`
            - `Topomatic.Proj.CoordinateSystems.HorizontalDatum`

#### Constructors (1)

- `.ctor(String name, Ellipsoid ellipsoid, PrimeMeridian primeMeridian, Usage usage, Authority authority, String description, String publicationDate)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ellipsoid` | `Ellipsoid` | `get/set` | No | `` |
| `ETRF89` | `HorizontalDatum` | `get` | Yes | `` |
| `GSK2011` | `HorizontalDatum` | `get` | Yes | `` |
| `PrimeMeridian` | `PrimeMeridian` | `get/set` | No | `` |
| `Pulkovo1942` | `HorizontalDatum` | `get` | Yes | `` |
| `Pulkovo1995` | `HorizontalDatum` | `get` | Yes | `` |
| `PZ1990` | `HorizontalDatum` | `get` | Yes | `` |
| `PZ1990_02` | `HorizontalDatum` | `get` | Yes | `` |
| `PZ1990_11` | `HorizontalDatum` | `get` | Yes | `` |
| `ToWgs84` | `HelmertTransformation` | `get` | No | `` |
| `WGS72` | `HorizontalDatum` | `get` | Yes | `` |
| `WGS84` | `HorizontalDatum` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `LengthUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.LengthUnit` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Unit` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.Unit`
        - `Topomatic.Proj.CoordinateSystems.LengthUnit`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ClarkesFoot` | `LengthUnit` | `get` | Yes | `` |
| `Foot` | `LengthUnit` | `get` | Yes | `` |
| `Metre` | `LengthUnit` | `get` | Yes | `` |
| `NauticalMile` | `LengthUnit` | `get` | Yes | `` |
| `USSurveyFoot` | `LengthUnit` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Meridian` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Meridian` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double longitude, AngleUnit angularUnit)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngularUnit` | `AngleUnit` | `get` | No | `` |
| `Longitude` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `NamedInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`

#### Constructors (1)

- `.ctor(String name, Authority authority)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Aliases` | `Alias[]` | `get` | No | `` |
| `Hidden` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Parent` | `Folder` | `get/set` | No | `` |
| `Removable` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAlias` | `Void` | `Alias alias` | `` |
| `IsMatch` | `Boolean` | `String text` | `` |
| `ToString` | `String` | `` | `` |

### `PrimeMeridian` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.PrimeMeridian` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.PrimeMeridian`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleUnit` | `AngleUnit` | `get` | No | `` |
| `Athens` | `PrimeMeridian` | `get` | Yes | `` |
| `Bern` | `PrimeMeridian` | `get` | Yes | `` |
| `Bogota` | `PrimeMeridian` | `get` | Yes | `` |
| `Brussels` | `PrimeMeridian` | `get` | Yes | `` |
| `Ferro` | `PrimeMeridian` | `get` | Yes | `` |
| `Greenwich` | `PrimeMeridian` | `get` | Yes | `` |
| `Jakarta` | `PrimeMeridian` | `get` | Yes | `` |
| `Lisbon` | `PrimeMeridian` | `get` | Yes | `` |
| `Longitude` | `Double` | `get` | No | `` |
| `Madrid` | `PrimeMeridian` | `get` | Yes | `` |
| `Oslo` | `PrimeMeridian` | `get` | Yes | `` |
| `Paris` | `PrimeMeridian` | `get` | Yes | `` |
| `Rome` | `PrimeMeridian` | `get` | Yes | `` |
| `Stockholm` | `PrimeMeridian` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `ProjectedConversionMethod` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ProjectedConversionMethod` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.ProjectedConversionMethod`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TransverseMercator` | `ProjectedConversionMethod` | `get` | Yes | `` |
| `Type` | `ProjectedConversionMethodType` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `ProjectedConversionMethodFactory` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ProjectedConversionMethodFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateConversionMethod` | `ProjectedConversionMethod` | `String alias` | `` |
| `GetDefaultAlias` | `String` | `ProjectedConversionMethodType conversionMethodType` | `` |

### `ProjectedConversionMethodType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ProjectedConversionMethodType` |
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
      - `Topomatic.Proj.CoordinateSystems.ProjectedConversionMethodType`

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlbersEqualArea` | `ProjectedConversionMethodType` | Yes | `AlbersEqualArea` | `` |
| `AmericanPolyconic` | `ProjectedConversionMethodType` | Yes | `AmericanPolyconic` | `` |
| `CassiniSoldner` | `ProjectedConversionMethodType` | Yes | `CassiniSoldner` | `` |
| `HotineObliqueMercatorVarA` | `ProjectedConversionMethodType` | Yes | `HotineObliqueMercatorVarA` | `` |
| `HotineObliqueMercatorVarB` | `ProjectedConversionMethodType` | Yes | `HotineObliqueMercatorVarB` | `` |
| `Krovak` | `ProjectedConversionMethodType` | Yes | `Krovak` | `` |
| `LambertAzimuthalEqualArea` | `ProjectedConversionMethodType` | Yes | `LambertAzimuthalEqualArea` | `` |
| `LambertConicConformal2SP` | `ProjectedConversionMethodType` | Yes | `LambertConicConformal2SP` | `` |
| `MercatorVariantA` | `ProjectedConversionMethodType` | Yes | `MercatorVariantA` | `` |
| `MercatorVariantB` | `ProjectedConversionMethodType` | Yes | `MercatorVariantB` | `` |
| `ObliqueStereographic` | `ProjectedConversionMethodType` | Yes | `ObliqueStereographic` | `` |
| `PopularVisualiationPseudoMercator` | `ProjectedConversionMethodType` | Yes | `PopularVisualiationPseudoMercator` | `` |
| `TransverseMercator` | `ProjectedConversionMethodType` | Yes | `TransverseMercator` | `` |
| `value__` | `Int16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PopularVisualiationPseudoMercator` | `1024` |
| `LambertConicConformal2SP` | `9802` |
| `MercatorVariantA` | `9804` |
| `MercatorVariantB` | `9805` |
| `CassiniSoldner` | `9806` |
| `TransverseMercator` | `9807` |
| `ObliqueStereographic` | `9809` |
| `HotineObliqueMercatorVarA` | `9812` |
| `HotineObliqueMercatorVarB` | `9815` |
| `AmericanPolyconic` | `9818` |
| `Krovak` | `9819` |
| `LambertAzimuthalEqualArea` | `9820` |
| `AlbersEqualArea` | `9822` |

**Underlying Type**: `System.Int16`

### `ProjectedCoordinateSystem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ProjectedCoordinateSystem` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`
          - `Topomatic.Proj.CoordinateSystems.CoordinateSystem`
            - `Topomatic.Proj.CoordinateSystems.HorizontalCoordinateSystem`
              - `Topomatic.Proj.CoordinateSystems.ConversedCoordinateSystem`
                - `Topomatic.Proj.CoordinateSystems.ProjectedCoordinateSystem`

#### Constructors (1)

- `.ctor(String name, AxisCoordinateSystem axisCoordinateSystem, GeographicCoordinateSystem geographicCoordinateSystem, Projection projection, Usage usage, Authority authority, String description, String textDefinition)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeographicCRS` | `GeographicCoordinateSystem` | `get/set` | No | `` |
| `HorizontalDatum` | `HorizontalDatum` | `get/set` | No | `` |
| `Projection` | `Projection` | `get` | No | `` |
| `WebMercator` | `ProjectedCoordinateSystem` | `get` | Yes | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `WGS84_UTM` | `ProjectedCoordinateSystem` | `Int32 zone, Boolean zoneIsNorth` | `` |

### `Projection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Projection` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Conversion` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.Conversion`
          - `Topomatic.Proj.CoordinateSystems.Projection`

#### Constructors (1)

- `.ctor(String name, ProjectedConversionMethod conversionMethod, ConversionParameter[] parameters, Authority authority, String description)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Method` | `ProjectedConversionMethod` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `ScaleUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ScaleUnit` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Unit` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.Unit`
        - `Topomatic.Proj.CoordinateSystems.ScaleUnit`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PartsPerMillion` | `ScaleUnit` | `get` | Yes | `` |
| `Unity` | `ScaleUnit` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Scope` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Scope` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.AuthorityInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.Scope`

#### Constructors (1)

- `.ctor(String name, Authority authority)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `Scope` | `get` | Yes | `` |
| `Name` | `String` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |
| `ToString` | `String` | `` | `` |

### `ScopedInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.ScopedInfo` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.DescriptedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.DescriptedInfo`
        - `Topomatic.Proj.CoordinateSystems.ScopedInfo`

#### Constructors (1)

- `.ctor(String name, Usage usage, Authority authority, String description)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Usage` | `Usage` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Unit` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Unit` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.NamedInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.AuthorityInfo`
    - `Topomatic.Proj.CoordinateSystems.NamedInfo`
      - `Topomatic.Proj.CoordinateSystems.Unit`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConversionFactor` | `Double` | `get` | No | `` |
| `WktNode` | `WKTNode` | `get` | No | `` |

### `Usage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Usage` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Area area, Scope scope)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area` | `Area` | `get` | No | `` |
| `Default` | `Usage` | `get` | Yes | `` |
| `Scope` | `Scope` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualParams` | `Boolean` | `Object obj` | `` |

### `Wgs84ConversionInfo` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Wgs84ConversionInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double dx, Double dy, Double dz, Double ex, Double ey, Double ez, Double ppm)`
- `.ctor(Double dx, Double dy, Double dz, Double ex, Double ey, Double ez, Double ppm, String areaOfUse)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HasZeroValuesOnly` | `Boolean` | `get` | No | `` |
| `WKT` | `String` | `get` | No | `` |
| `XML` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Wgs84ConversionInfo obj` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetAffineTransform` | `Double[]` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AreaOfUse` | `String` | No | `` | `` |
| `Dx` | `Double` | No | `` | `` |
| `Dy` | `Double` | No | `` | `` |
| `Dz` | `Double` | No | `` | `` |
| `Ex` | `Double` | No | `` | `` |
| `Ey` | `Double` | No | `` | `` |
| `Ez` | `Double` | No | `` | `` |
| `Ppm` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Proj.CoordinateSystems.Projections`

### `LambertAzimuthalEqualAreaProjection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Projections.LambertAzimuthalEqualAreaProjection` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Projections.MapProjection` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform`
    - `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform`
      - `Topomatic.Proj.CoordinateSystems.Projections.MapProjection`
        - `Topomatic.Proj.CoordinateSystems.Projections.LambertAzimuthalEqualAreaProjection`

#### Constructors (2)

- `.ctor(Ellipsoid ellipsoid, AxisCoordinateSystem csSource, AxisCoordinateSystem csTarget, IEnumerable<ConversionParameter> parameters)`
- `.ctor(Ellipsoid ellipsoid, AxisCoordinateSystem csSource, AxisCoordinateSystem csTarget, IEnumerable<ConversionParameter> parameters, MapProjection inverse)`

### `MapProjection` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Projections.MapProjection` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform`
    - `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform`
      - `Topomatic.Proj.CoordinateSystems.Projections.MapProjection`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DimSource` | `Int32` | `get` | No | `` |
| `DimTarget` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Inverse` | `MathTransform` | `` | `` |
| `Invert` | `Void` | `` | `` |
| `Transform` | `Void` | `ref Double x, ref Double y, ref Double z` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcUtmZone` | `Int64` | `Double lon` | `` |

### `ProjectionParameterSet` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Projections.ProjectionParameterSet` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IEquatable`1[[Topomatic.Proj.CoordinateSystems.Projections.ProjectionParameterSet, Topomatic.Proj, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `ConversionParameter` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ProjectionParameterSet other` | `` |
| `GetOptionalParameterValue` | `Double` | `ConversionParameterType type, Unit unit, Double defaultValue` | `` |
| `ToProjectionParameter` | `IEnumerable<ConversionParameter>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Proj.CoordinateSystems.Transformations`

### `AffineTransform` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.AffineTransform` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform`
    - `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform`
      - `Topomatic.Proj.CoordinateSystems.Transformations.AffineTransform`

#### Constructors (1)

- `.ctor(AxisCoordinateSystem csSource, AxisCoordinateSystem csTarget, IEnumerable<ConversionParameter> parameters)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DimSource` | `Int32` | `get` | No | `` |
| `DimTarget` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Inverse` | `MathTransform` | `` | `` |
| `Invert` | `Void` | `` | `` |
| `Transform` | `Void` | `ref Double x, ref Double y, ref Double z` | `` |

### `ConversedCoordinateTransformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.ConversedCoordinateTransformation` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateTransformation` |
| **Implements** | `Topomatic.Proj.CoordinateSystems.Transformations.ICoordinateTransformationCore` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateTransformation`
    - `Topomatic.Proj.CoordinateSystems.Transformations.ConversedCoordinateTransformation`

#### Constructors (1)

- `.ctor(ConversedCoordinateSystem sourceCRS, ConversedCoordinateSystem targetCRS, TransformType transformType, MathTransform mathTransform)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMatrix` | `Matrix` | `Vector2D point, Double l` | `` |
| `GetMatrix` | `Matrix` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CoordinateSystemsTransform` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform`
    - `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateSystemsTransform`

### `CoordinateTransformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateTransformation` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Proj.CoordinateSystems.Transformations.ICoordinateTransformationCore` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MathTransform` | `MathTransform` | `get` | No | `` |
| `SourceCS` | `CoordinateSystem` | `get` | No | `` |
| `TargetCS` | `CoordinateSystem` | `get` | No | `` |
| `TransformType` | `TransformType` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICoordinateTransformationCore` | `get_SourceCS` |
| `ICoordinateTransformationCore` | `get_TargetCS` |

### `CoordinateTransformationFactory` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.CoordinateTransformationFactory` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromCoordinateSystems` | `CoordinateTransformation` | `CoordinateSystem sourceCS, CoordinateSystem targetCS` | `` |

### `GeographicTransform` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.GeographicTransform` |
| **Base Type** | `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform`
    - `Topomatic.Proj.CoordinateSystems.Transformations.GeographicTransform`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DimSource` | `Int32` | `get` | No | `` |
| `DimTarget` | `Int32` | `get` | No | `` |
| `IsInverse` | `Boolean` | `get/set` | No | `` |
| `SourceGCS` | `GeographicCoordinateSystem` | `get` | No | `` |
| `TargetGCS` | `GeographicCoordinateSystem` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Inverse` | `MathTransform` | `` | `` |
| `Invert` | `Void` | `` | `` |
| `Transform` | `Void` | `ref Double x, ref Double y, ref Double z` | `` |

### `ICoordinateTransformationCore` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.ICoordinateTransformationCore` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SourceCS` | `CoordinateSystem` | `get` | No | `` |
| `TargetCS` | `CoordinateSystem` | `get` | No | `` |

### `MathTransform` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.MathTransform` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DimSource` | `Int32` | `get` | No | `` |
| `DimTarget` | `Int32` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Inverse` | `MathTransform` | `` | `` |
| `Invert` | `Void` | `` | `` |
| `Transform` | `Vector2D` | `Vector2D vector2D` | `` |
| `Transform` | `Void` | `ref Double x, ref Double y, ref Double z` | `` |
| `Transform` | `XYZ[]` | `XYZ[] xyz` | `` |
| `Transform` | `XY[]` | `XY[] xy` | `` |
| `Transform` | `Void` | `ref Double x, ref Double y` | `` |
| `Transform` | `Double[]` | `Double[] point` | `` |
| `Transform` | `XY` | `Double x, Double y` | `` |
| `Transform` | `XYZ` | `Double x, Double y, Double z` | `` |
| `TransformList` | `IList<Double[]>` | `IList<Double[]> points` | `` |

### `TransformType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.CoordinateSystems.Transformations.TransformType` |
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
      - `Topomatic.Proj.CoordinateSystems.Transformations.TransformType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Conversion` | `TransformType` | Yes | `Conversion` | `` |
| `ConversionAndTransformation` | `TransformType` | Yes | `ConversionAndTransformation` | `` |
| `Other` | `TransformType` | Yes | `Other` | `` |
| `Transformation` | `TransformType` | Yes | `Transformation` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Other` | `0` |
| `Conversion` | `1` |
| `Transformation` | `2` |
| `ConversionAndTransformation` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Proj.Geometries`

### `XY` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Geometries.XY` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Proj.Geometries.XY, Topomatic.Proj, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Proj.Geometries.XY`

#### Constructors (1)

- `.ctor(Double x, Double y)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `XY other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `XYZ` (struct)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Geometries.XYZ` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Proj.Geometries.XYZ, Topomatic.Proj, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Proj.Geometries.XYZ`

#### Constructors (1)

- `.ctor(Double x, Double y, Double z)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `XYZ other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |
| `Z` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Proj.Utils`

### `StringUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Utils.StringUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsNullOrWhiteSpaces` | `Boolean` | `String s` | `` |

### `Translations` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.Utils.Translations` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetTranslation` | `String` | `String value` | `` |

---
## Namespace: `Topomatic.Proj.WKT`

### `WKTException` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.WKT.WKTException` |
| **Base Type** | `System.Exception` |
| **Implements** | `System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Exception`
    - `Topomatic.Proj.WKT.WKTException`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WKTNode` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Proj.WKT.WKTNode` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get/set` | No | `` |
| `Shifting` | `Int32` | `get/set` | No | `` |
| `SubNodes` | `WKTNode[]` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSubNode` | `WKTNode` | `WKTNode subNode` | `` |
| `GenerateString` | `String` | `Int32 offset` | `` |
| `GetDoubleValue` | `Double` | `Int32 index` | `` |
| `GetEnumValue` | `Object` | `Int32 index, Type type` | `` |
| `GetIntValue` | `Int32` | `Int32 index` | `` |
| `GetStringValue` | `String` | `Int32 index` | `` |
| `GetSubNodesByAlias` | `WKTNode[]` | `String alias` | `` |
| `ToByteArray` | `Byte[]` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromByteArray` | `WKTNode` | `Byte[] array` | `` |
| `CreateFromWKTText` | `WKTNode` | `String wktText` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 73 |
| **Classes** | 39 |
| **Interfaces** | 2 |
| **Enums** | 9 |
| **Structs** | 2 |
| **Abstract Classes** | 13 |
| **Static Classes** | 8 |
| **Total Methods** | 190 |
| **Total Properties** | 219 |
| **Total Fields** | 120 |
| **Total Events** | 0 |
| **Total Constructors** | 33 |
| **Nested Types** | 2 |
| **Extension Methods** | 0 |


