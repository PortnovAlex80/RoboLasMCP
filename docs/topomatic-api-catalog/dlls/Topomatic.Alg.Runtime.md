# Topomatic.Alg.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Runtime.dll` |

---
## Namespace: `Topomatic.Alg.Runtime`

### `AgOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.AgOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, AgProfile profile` | `` |
| `PackNode` | `Void` | `Double left, Double right, Double grade, ref Int32 code, ref Int32 tag` | `` |
| `SaveToStream` | `Void` | `Stream stream, AgProfile profile` | `` |
| `UnpackNode` | `Void` | `Int32 code, Int32 tag, ref Double left, ref Double right, ref Double grade` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `24` | `` |

### `AlgOldBinarySerializer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.AlgOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, Alignment alg` | `` |
| `SaveToStream` | `Void` | `Stream stream, Alignment alg, ProgramType type` | `` |
| `SaveToStream` | `Void` | `Stream stream, Alignment alg, ProgramType type, Int32 version` | `` |

#### Fields (72)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ALG_RAIL_SIGNATURE` | `Int32` | Yes | `1179077698` | `` |
| `ALG_RAIL_VERSION` | `Int32` | Yes | `19` | `` |
| `ALG_ROAD_72_VERSION` | `Int32` | Yes | `17` | `` |
| `ALG_ROAD_73_VERSION` | `Int32` | Yes | `20` | `` |
| `ALG_ROAD_74_VERSION` | `Int32` | Yes | `21` | `` |
| `ALG_ROAD_SIGNATURE` | `Int32` | Yes | `1179077697` | `` |
| `ALG_ROAD_VERSION` | `Int32` | Yes | `21` | `` |
| `DEFAULT_VERSION` | `Int32` | Yes | `0` | `` |
| `GLG_SIGNATURE` | `Int32` | Yes | `1179077703` | `` |
| `GLG_VERSION` | `Int32` | Yes | `1` | `` |
| `rsBRIDGES` | `Int32` | Yes | `80` | `` |
| `rsCUTTING_LEDGE` | `Int32` | Yes | `160` | `` |
| `rsDITCH_UKR_POP` | `Int32` | Yes | `208` | `` |
| `rsDOD` | `Int32` | Yes | `96` | `` |
| `rsEXISTINGPAVEMENT` | `Int32` | Yes | `152` | `` |
| `rsGRB` | `Int32` | Yes | `136` | `` |
| `rsLOOSENINGSLOPES` | `Int32` | Yes | `152` | `` |
| `rsMRK` | `Int32` | Yes | `48` | `` |
| `rsOCCUPATION_EARTH_EXIST` | `Int32` | Yes | `148` | `` |
| `rsOCCUPATION_EARTH_PROJECT` | `Int32` | Yes | `144` | `` |
| `rsOLD_PRF` | `Int32` | Yes | `32` | `` |
| `rsOLD_URB` | `Int32` | Yes | `496` | `` |
| `rsPIPE` | `Int32` | Yes | `56` | `` |
| `rsPOP` | `Int32` | Yes | `180` | `` |
| `rsPOSARRAY` | `Int32` | Yes | `16` | `` |
| `rsPRF` | `Int32` | Yes | `40` | `` |
| `rsRAIL_CRS_POINT` | `Int32` | Yes | `24` | `` |
| `rsRAIL_EGCS_POINT` | `Int32` | Yes | `48` | `` |
| `rsRAIL_PKT` | `Int32` | Yes | `28` | `` |
| `rsRAIL_RBR` | `Int32` | Yes | `24` | `` |
| `rsRAIL_SLP` | `Int32` | Yes | `16412` | `` |
| `rsRAIL_TPK` | `Int32` | Yes | `28` | `` |
| `rsRAIL_TPL` | `Int32` | Yes | `144` | `` |
| `rsRAIL_URB` | `Int32` | Yes | `1120` | `` |
| `rsREN` | `Int32` | Yes | `36` | `` |
| `rsROAD_OLD_RBR` | `Int32` | Yes | `24` | `` |
| `rsROAD_OLD_SLP` | `Int32` | Yes | `248` | `` |
| `rsROAD_PKT` | `Int32` | Yes | `24` | `` |
| `rsROAD_RBR` | `Int32` | Yes | `36` | `` |
| `rsROAD_SLP` | `Int32` | Yes | `408` | `` |
| `rsROAD_TPK` | `Int32` | Yes | `12` | `` |
| `rsRSF` | `Int32` | Yes | `495` | `` |
| `rsRSFINTENSITIES` | `Int32` | Yes | `12` | `` |
| `rsRSFPIPES` | `Int32` | Yes | `72` | `` |
| `rsRSFROUNDED` | `Int32` | Yes | `495` | `` |
| `rsSECT` | `Int32` | Yes | `24` | `` |
| `rsSRB` | `Int32` | Yes | `104` | `` |
| `rsTIN` | `Int32` | Yes | `112` | `` |
| `rsTPL` | `Int32` | Yes | `146` | `` |
| `rsTSR` | `Int32` | Yes | `132` | `` |
| `rsUKR_PROEKT_EXCLUDE_POP` | `Int32` | Yes | `144` | `` |
| `rsUKR_PROEKT_SLOPES_POP` | `Int32` | Yes | `156` | `` |
| `rsUKR_SIDE_POP` | `Int32` | Yes | `176` | `` |
| `rsURB_GROUPS` | `Int32` | Yes | `68` | `` |
| `rsURB_MASTER_DATA_CONSTRUCTION` | `Int32` | Yes | `96` | `` |
| `rsURB_MASTER_DATA_TYPES` | `Int32` | Yes | `208` | `` |
| `rsURB_MASTER_DATA_UKLON_MAIN` | `Int32` | Yes | `88` | `` |
| `rsURB_MASTER_DATA_UKLON_RAZD` | `Int32` | Yes | `24` | `` |
| `rsURB_MASTER_DATA_UKLON_SIDES` | `Int32` | Yes | `24` | `` |
| `rsURB_MASTER_DATA_VARIABLES` | `Int32` | Yes | `20` | `` |
| `rsURB_MASTER_DATA_WIDTH_ADD` | `Int32` | Yes | `44` | `` |
| `rsURB_MASTER_DATA_WIDTH_MAIN` | `Int32` | Yes | `88` | `` |
| `rsURB_MASTER_DATA_WIDTH_RAZD` | `Int32` | Yes | `40` | `` |
| `rsURB_MASTER_DATA_WIDTH_SIDES` | `Int32` | Yes | `56` | `` |
| `rsVIRAGE_OTGON` | `Int32` | Yes | `64` | `` |
| `rsVRB` | `Int32` | Yes | `20` | `` |
| `rsVRG` | `Int32` | Yes | `88` | `` |
| `rsWRB` | `Int32` | Yes | `136` | `` |
| `rsWSR` | `Int32` | Yes | `64` | `` |
| `rsYRB` | `Int32` | Yes | `24` | `` |
| `URB_SIGNATURE` | `Int32` | Yes | `1431454291` | `` |
| `URB_VERSION` | `Int32` | Yes | `1` | `` |

#### Nested Types (1)

- `ProgramType` (enum)

### `CompoundLineExploder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.CompoundLineExploder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ArcItemToDwgArc` | `Void` | `ArcItem ArcItem, DwgArc Arc` | `` |
| `ClothoidItemToDwgClothoid` | `Void` | `ClothoidItem ClothoidItem, DwgClothoid Clot` | `` |
| `DrawCompoundLine` | `Void` | `CompoundLine line, Color color, DwgBlock block` | `` |
| `ExplodeToEntitySet` | `Void` | `CompoundLine line, List<DwgEntity> entityset` | `` |
| `IntersectWith` | `Boolean` | `CompoundLine line, BoundingBox2D frame` | `` |
| `SolvePtForClothoid` | `Vector2D` | `Double c, Double s, Double fi, Vector2D p` | `` |
| `StraightItemToDwgLine` | `Void` | `StraightItem StraightItem, DwgLine Line` | `` |

### `CrsDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.CrsDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Alg.Runtime.CrsDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `CrsSectionsOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.CrsSectionsOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, Corridor corridor, Int32[] recordSizes` | `` |
| `SaveToStream` | `Void` | `Stream stream, Corridor corridor, Int32 recordSize` | `` |

### `FixedPointsOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.FixedPointsOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, FixedPoints fixedPoints` | `` |
| `SaveToStream` | `Void` | `Stream stream, FixedPoints fixedPoints` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `56` | `` |

### `HOType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.HOType` |
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
      - `Topomatic.Alg.Runtime.HOType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `HOType` | Yes | `Both` | `` |
| `OnlyEg` | `HOType` | Yes | `OnlyEg` | `` |
| `OnlyFg` | `HOType` | Yes | `OnlyFg` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Both` | `0` |
| `OnlyEg` | `1` |
| `OnlyFg` | `2` |

**Underlying Type**: `System.Int32`

### `MockupDwlEditor` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Base Type** | `Topomatic.ApplicationPlatform.Core.DocumentModelEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromFile` | `Object` | `String fullpath` | `` |
| `SaveToFile` | `Void` | `Object model, String fullpath` | `` |

#### Nested Types (1)

- `Model` (class)

### `Model` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.MockupDwlEditor+Model` |
| **Base Type** | `Topomatic.Dtm.DrawingModel` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IStateController, System.IDisposable, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.FoundationClasses.StateControllerObject`
        - `Topomatic.Dtm.DrawingModel`
          - `Topomatic.Alg.Runtime.MockupDwlEditor+Model`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromFile` | `Void` | `String path` | `` |
| `SaveToFile` | `Void` | `String path` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlnOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.PlnOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStreamRail` | `Void` | `Stream stream, PlanLine planLine` | `` |
| `LoadFromStreamRoad` | `Void` | `Stream stream, PlanLine planLine` | `` |
| `SaveToStreamRail` | `Void` | `Stream stream, PlanLine plan` | `` |
| `SaveToStreamRoad` | `Void` | `Stream stream, PlanLine plan` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `52` | `` |
| `VERSION` | `Int32` | Yes | `1` | `` |

### `PrfDwlEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.PrfDwlEditor` |
| **Base Type** | `Topomatic.Alg.Runtime.MockupDwlEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.Core.ModelEditor`
    - `Topomatic.ApplicationPlatform.Core.DocumentModelEditor`
      - `Topomatic.Alg.Runtime.MockupDwlEditor`
        - `Topomatic.Alg.Runtime.PrfDwlEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ProfileOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ProfileOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, StaticProfile profile` | `` |
| `SaveToStream` | `Void` | `Stream stream, Profile profile` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `24` | `` |

### `ProgramType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.AlgOldBinarySerializer+ProgramType` |
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
      - `Topomatic.Alg.Runtime.AlgOldBinarySerializer+ProgramType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Rail` | `ProgramType` | Yes | `Rail` | `` |
| `Road` | `ProgramType` | Yes | `Road` | `` |
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

### `ProjectProfileOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ProjectProfileOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, SplineProfile profile` | `` |
| `LoadFromStream` | `Void` | `Stream stream, ProjectProfile profile` | `` |
| `SaveToStream` | `Void` | `Stream stream, ProjectProfile profile` | `` |
| `SaveToStream` | `Void` | `Stream stream, SplineProfile profile` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `24` | `` |
| `SPLINE_RECORD_SIZE` | `Int32` | Yes | `40` | `` |

### `RailStationingOldBinarySerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.RailStationingOldBinarySerializer` |
| **Base Type** | `Topomatic.Alg.Runtime.StationingOldBinarySerializer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.StationingOldBinarySerializer`
    - `Topomatic.Alg.Runtime.RailStationingOldBinarySerializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStreamRail` | `Void` | `Stream stream, AlgStationing stationing` | `` |
| `SaveToStreamRail` | `Void` | `Stream stream, AlgStationing stationing` | `` |

### `RoadStationingSerializer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.RoadStationingSerializer` |
| **Base Type** | `Topomatic.Alg.Runtime.StationingOldBinarySerializer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.StationingOldBinarySerializer`
    - `Topomatic.Alg.Runtime.RoadStationingSerializer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStreamRoad` | `Void` | `Stream stream, AlgStationing stationing` | `` |
| `SaveToStreamRoad` | `Void` | `Stream stream, AlgStationing stationing` | `` |
| `SaveToStreamTpk` | `Void` | `Stream stream, AlgStationing stationing` | `` |

### `StationingOldBinarySerializer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.StationingOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `TemplateBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.TemplateBuilder` |
| **Base Type** | `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder` |
| **Implements** | `Topomatic.Crs.ICrsBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Crs.Templates.CrsTemplateBuilder`
    - `Topomatic.Crs.Runtime.CrsTemplatePythonBuilder`
      - `Topomatic.Alg.Runtime.TemplateBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TrcDbfReader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.TrcDbfReader` |
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
| `FileName` | `String` | `get/set` | No | `` |
| `Line` | `CompoundLine` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `` | `` |

### `TrcOldBinarySerializer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.TrcOldBinarySerializer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `Void` | `Stream stream, CompoundLine line` | `` |
| `SaveToStream` | `Void` | `Stream stream, CompoundLine line` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RECORD_SIZE` | `Int32` | Yes | `72` | `` |

---
## Namespace: `Topomatic.Alg.Runtime.Communications`

### `AlignmentCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.AlignmentCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double elevation, Double station, Alignment alignment, Boolean hasElevation, String text1, String text2, String name)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `HasElevation` | `Boolean` | `get` | No | `` |
| `HasMaxElevation` | `Boolean` | `get/set` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `MaxElevation` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `AlignmentCommunications` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.AlignmentCommunications` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.Communications` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`
      - `Topomatic.Alg.Runtime.Communications.AlignmentCommunications`

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Double` | `Double station` | `` |
| `GetIntersections` | `Void` | `Vector2D a, Vector2D b, IList<Double> stations` | `` |
| `GetIntersections` | `Void` | `Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations` | `` |
| `StationToPos` | `Vector2D` | `Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `AreaCommunicationProvider` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.AreaCommunicationProvider` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.CommunicationProvider` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Communications.CommunicationProvider`
    - `Topomatic.Alg.Runtime.Communications.AreaCommunicationProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `SemanticDependencyProperty` | `get` | No | `` |
| `Parallel` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCommunication` | `Void` | `Communications communications, Double s1, Double s2, Double elevation1, Double elevation2, IDictionary<String String> parameters` | `` |
| `CreateCommunication` | `Void` | `Communications communications, Double station, Double elevation, IDictionary<String String> parameters` | `` |
| `InitializeProperties` | `Boolean` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AreaCommunicationSemanticDataStyleProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.AreaCommunicationSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Alg.Runtime.Communications.AreaCommunicationSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `BridgeCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.BridgeCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Bridge bridge)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `CommunicationExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.CommunicationExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `HideEntity` | `Void` | `ICommunication communication, Drawing drawing, DwgEntity entity` | `Extension` |
| `LayoutLeader` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String str1, String str2, Vector2D pos, String id` | `Obsolete(Message: `Use LayoutElevation() instead`), Extension` |
| `LayoutLeader` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String str, Vector2D pos, String id` | `Obsolete(Message: `Use LayoutElevation() instead`), Extension` |
| `LayoutLeaderElevation` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String str1, String str2, Vector2D sign, Vector2D pos, String id` | `Extension` |
| `LayoutLeaderElevation` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String str, Vector2D sign, Vector2D pos, String id` | `Extension` |
| `LayoutMockupText` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String content, Vector3D position, Double rotation, TextAlignment justify, String id` | `Extension` |
| `LayoutPosition` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, ref Vector3D pos, ref Boolean hidden, String id` | `Extension` |
| `LayoutPosition` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, ref Vector3D pos, String id` | `Extension` |
| `LayoutText` | `Void` | `ICommunication communication, Drawing drawing, CommunicationStyle style, String str, Vector3D pos, Double rotation, TextAlignment justify, String id` | `Extension, Obsolete(Message: `Use LayoutMockupText() instead`)` |

### `CommunicationProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.CommunicationProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCommunication` | `Void` | `Communications communications, Double station, Double elevation, IDictionary<String String> parameters` | `` |
| `InitializeProperties` | `Boolean` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Deserialize` | `CommunicationProvider` | `Byte[] buffer` | `` |
| `Serialize` | `Byte[]` | `CommunicationProvider provider` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CommunicationProviderTag` | `String` | Yes | `"<class>CommunicationProvider</class>"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.SaveToStg` |
| `IStgSerializable` | `Topomatic.Stg.IStgSerializable.LoadFromStg` |

### `Communications` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.Communications` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetElevation` | `Double` | `Double station` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetIntersections` | `Void` | `Vector2D a, Vector2D b, IList<Double> stations` | `` |
| `GetIntersections` | `Void` | `Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `CadPen pen, CommunicationStyle style` | `` |
| `StationToPos` | `Vector2D` | `Double station` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossSection` | `String` | Yes | `"CrossSection"` | `` |
| `Profile` | `String` | Yes | `"Profile"` | `` |
| `Section` | `String` | Yes | `"Section"` | `` |

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

### `CommunicationStyle` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.CommunicationStyle` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomElevation` | `Double` | `get/set` | No | `` |
| `Font` | `CadFont` | `get/set` | No | `` |
| `FontHeight` | `Double` | `get/set` | No | `` |
| `FontOblique` | `Double` | `get/set` | No | `` |
| `FontRatio` | `Double` | `get/set` | No | `` |
| `PaperScale` | `Double` | `get/set` | No | `` |
| `TopElevation` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ScaleElevation` | `Double` | `Double elevation` | `` |
| `ScaleStation` | `Double` | `Double station` | `` |
| `StationString` | `String` | `Double station` | `` |

### `CrossSectionCommunications` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.CrossSectionCommunications` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.Communications` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Runtime.Communications.ICrossSectionCommunications` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`
      - `Topomatic.Alg.Runtime.Communications.CrossSectionCommunications`

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 sectionIndex)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Begin` | `Vector2D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `End` | `Vector2D` | `get` | No | `` |
| `Id` | `String` | `get` | No | `` |
| `Index` | `Int32` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Double` | `Double station` | `` |
| `GetIntersections` | `Void` | `Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations` | `` |
| `GetIntersections` | `Void` | `Vector2D a, Vector2D b, IList<Double> stations` | `` |
| `StationToPos` | `Vector2D` | `Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `ICrossSectionCommunications` | `get_Station` |

### `CuttingSurfaceCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.CuttingSurfaceCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.Prf.IProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String description, Int32 code, Alignment alignment)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get` | No | `` |
| `Codes` | `IList<Int32>` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Items` | `IList<Vector2D>` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStations` | `IEnumerable<Double>` | `Boolean onlyMarked` | `` |
| `GetY` | `Boolean` | `Double station, ref Double value` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IProfile` | `GetY` |
| `IProfile` | `GetStations` |

### `FixedPointCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.FixedPointCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(FixedPointNode node)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `IClearence` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.IClearence` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSegments` | `IEnumerable<KeyValuePair<Vector2D Vector2D>>` | `` | `` |

### `ICommunication` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

### `ICrossSectionCommunications` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.ICrossSectionCommunications` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get` | No | `` |

### `LineAttachment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SimpleDrawingCommunication+LineAttachment` |
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
      - `Topomatic.Alg.Runtime.Communications.SimpleDrawingCommunication+LineAttachment`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AboweCross` | `LineAttachment` | Yes | `AboweCross` | `` |
| `Bottom` | `LineAttachment` | Yes | `Bottom` | `` |
| `Cross` | `LineAttachment` | Yes | `Cross` | `` |
| `FixedAbove` | `LineAttachment` | Yes | `FixedAbove` | `` |
| `FixedBelow` | `LineAttachment` | Yes | `FixedBelow` | `` |
| `Top` | `LineAttachment` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Top` | `0` |
| `Bottom` | `1` |
| `Cross` | `2` |
| `FixedAbove` | `3` |
| `FixedBelow` | `4` |
| `AboweCross` | `5` |

**Underlying Type**: `System.Int32`

### `PipeCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.PipeCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Pipe pipe, Double station, Double elevation)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `PropertyTypeConverter` |
| `Diameter` | `Double` | `get/set` | No | `ConditionalBrowsable, Length` |
| `Elevation` | `Double` | `get` | No | `Browsable` |
| `ElevationEnd` | `Double` | `get/set` | No | `Elevation` |
| `ElevationStart` | `Double` | `get/set` | No | `Elevation` |
| `Height` | `Double` | `get/set` | No | `ConditionalBrowsable, Length` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `Browsable` |
| `LenghtEnd` | `Double` | `get/set` | No | `Length` |
| `LenghtStart` | `Double` | `get/set` | No | `Length` |
| `Material` | `PipeMaterial` | `get/set` | No | `PropertyTypeConverter` |
| `Mode` | `PipeMode` | `get/set` | No | `PropertyTypeConverter` |
| `Picket` | `String` | `get/set` | No | `` |
| `Section` | `PipeSection` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Station` | `Double` | `get` | No | `Browsable` |
| `Type` | `PipeType` | `get/set` | No | `PropertyTypeConverter` |
| `Width` | `Double` | `get/set` | No | `ConditionalBrowsable, Length` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `ProfileCommunications` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.ProfileCommunications` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.AlignmentCommunications` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Prf.ITransitionContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Alg.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Alg.Runtime.Communications.Communications`
      - `Topomatic.Alg.Runtime.Communications.AlignmentCommunications`
        - `Topomatic.Alg.Runtime.Communications.ProfileCommunications`

#### Constructors (2)

- `.ctor(Alignment alignment, Transition transition)`
- `.ctor(Alignment alignment, Int32 transitionIndex)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Transition` | `Transition` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransitionContainer` | `get_Transition` |

### `ScaleCommunicationStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.ScaleCommunicationStyle` |
| **Base Type** | `Topomatic.Alg.Runtime.Communications.CommunicationStyle` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Communications.CommunicationStyle`
    - `Topomatic.Alg.Runtime.Communications.ScaleCommunicationStyle`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ScaleX` | `Double` | `get/set` | No | `` |
| `ScaleY` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ScaleElevation` | `Double` | `Double elevation` | `` |
| `ScaleStation` | `Double` | `Double station` | `` |

### `SectionPipeCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SectionPipeCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Pipe pipe)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SimpleCommunicationKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SimpleCommunicationKey` |
| **Base Type** | `Topomatic.FoundationClasses.EditableItems.EditableItemsKey` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.EditableItems.EditableItemsKey`
    - `Topomatic.Alg.Runtime.Communications.SimpleCommunicationKey`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double station, String str)`
- `.ctor(Double station, Int32 number, String str)`

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

### `SimpleCommunicationSemanticDataStyleProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SimpleCommunicationSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Alg.Runtime.Communications.SimpleCommunicationSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `SimpleDrawingCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SimpleDrawingCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.IClearence, Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DwgBlock sign, Double station, Double elevation)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `DescriptionLeft` | `String` | `get/set` | No | `` |
| `DescriptionRight` | `String` | `get/set` | No | `` |
| `DisplayElevation` | `Boolean` | `get/set` | No | `` |
| `DisplayLine` | `Boolean` | `get/set` | No | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `LineFlag` | `LineAttachment` | `get/set` | No | `` |
| `OriginElevation` | `Boolean` | `get/set` | No | `` |
| `Scale` | `Nullable<Double>` | `get/set` | No | `` |
| `Station` | `Double` | `get` | No | `` |
| `TextFlag` | `TextAttachment` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSegments` | `IEnumerable<KeyValuePair<Vector2D Vector2D>>` | `` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Nested Types (2)

- `LineAttachment` (enum)
- `TextAttachment` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IClearence` | `GetSegments` |
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

### `TextAttachment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.SimpleDrawingCommunication+TextAttachment` |
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
      - `Topomatic.Alg.Runtime.Communications.SimpleDrawingCommunication+TextAttachment`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Above` | `TextAttachment` | Yes | `Above` | `` |
| `Below` | `TextAttachment` | Yes | `Below` | `` |
| `Bottom` | `TextAttachment` | Yes | `Bottom` | `` |
| `CrossDown` | `TextAttachment` | Yes | `CrossDown` | `` |
| `CrossUp` | `TextAttachment` | Yes | `CrossUp` | `` |
| `Top` | `TextAttachment` | Yes | `Top` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Above` | `0` |
| `Below` | `1` |
| `Top` | `2` |
| `Bottom` | `3` |
| `CrossUp` | `4` |
| `CrossDown` | `5` |

**Underlying Type**: `System.Int32`

### `WaterDischargeCommunication` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Communications.WaterDischargeCommunication` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.Runtime.Communications.ICommunication` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double station, Double elevation, Boolean leftSide)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `Double` | `get` | No | `Browsable` |
| `IsEditable` | `Boolean` | `get` | No | `Browsable` |
| `Station` | `Double` | `get` | No | `Browsable` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `Layout` | `Void` | `Communications sender, Drawing drawing, CommunicationStyle style` | `` |
| `Paint` | `Void` | `Communications sender, CadPen pen, CommunicationStyle style` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetHint` | `Boolean` | `Communications sender, BoundingBox2D searchBox, ref String hint` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICommunication` | `get_Station` |
| `ICommunication` | `get_Elevation` |
| `ICommunication` | `get_IsEditable` |
| `ICommunication` | `Paint` |
| `ICommunication` | `Layout` |
| `ICommunication` | `TryGetHint` |

---
## Namespace: `Topomatic.Alg.Runtime.Controls`

### `GridPanelSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Controls.GridPanelSettings` |
| **Base Type** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.UserControl`
              - `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel`
                - `Topomatic.Alg.Runtime.Controls.GridPanelSettings`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manger)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.Design`

### `AciveAlignmentRelativePathWrapper` (class)

**Attributes**: [PropertyEditor]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.AciveAlignmentRelativePathWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String path)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Path` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindAlignment` | `Alignment` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `ModalAlignmentRelativePathAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.ModalAlignmentRelativePathAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.RelativePathAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.View.Design.ModelFinderAttribute`
        - `Topomatic.Cad.View.Design.RelativePathAttribute`
          - `Topomatic.Alg.Runtime.Design.ModalAlignmentRelativePathAttribute`

#### Constructors (2)

- `.ctor(String[] modelTypes)`
- `.ctor(Boolean hideSelf, String[] modelTypes)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModalAlignmentRelativePathProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.ModalAlignmentRelativePathProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.RelativePathProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.ModelFinderProvider`
      - `Topomatic.Cad.View.Design.RelativePathProvider`
        - `Topomatic.Alg.Runtime.Design.ModalAlignmentRelativePathProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `StationFromPlanAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.StationFromPlanAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Alg.Runtime.Design.StationFromPlanAttribute`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(String offset)`
- `.ctor(String offset, String elevation)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elevation` | `String` | `get` | No | `` |
| `Offset` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StationFromProfileAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.StationFromProfileAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Alg.Runtime.Design.StationFromProfileAttribute`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 transition)`
- `.ctor(Int32 transition, String elevationPropertyName)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElevationPropertyName` | `String` | `get` | No | `` |
| `Transition` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StationPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.StationPropertyProvider` |
| **Base Type** | `Topomatic.Cad.View.Design.StationProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Cad.View.Design.StationProvider`
      - `Topomatic.Alg.Runtime.Design.StationPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationing` | `IStationing` | `Object instance` | `` |

### `TransitionViolationTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Design.TransitionViolationTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Runtime.Design.TransitionViolationTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Alg.Runtime.Dialogs`

### `AlgMoveDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgMoveDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Alg.Runtime.Dialogs.AlgMoveDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `CadView cadView, Alignment alignment, IProfile profile, String caption, ref Double station, ref Double offset` | `` |

#### Nested Types (1)

- `ReturnResult` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgProjectProfileInformationDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgProjectProfileInformationDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.AlgProjectProfileInformationDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `String station, Nullable<Double> redElevation, Nullable<Double> blackElevation, Nullable<Double> grade, Nullable<Int32> elementType, String sumStation, Nullable<Double> sumElevation` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SEGMENT` | `Int32` | Yes | `0` | `` |
| `SPLINE` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgPropertiesDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgPropertiesDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.AlgPropertiesDlg`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(CreateAlignmentParams prms)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FolderUri` | `URI` | `get/set` | No | `` |
| `Prms` | `CreateAlignmentParams` | `get` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `tcMain` | `TabControl` | No | `` | `` |
| `tpCMR` | `TabPage` | No | `` | `` |
| `tpCuttingSurfaces` | `TabPage` | No | `` | `` |
| `tpGeneral` | `TabPage` | No | `` | `` |

#### Nested Types (1)

- `CreateAlignmentParams` (abstract class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgSelectSectorStationDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgSelectSectorStationDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.AlgSelectSectorStationDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `IAlgStationing stationing, Double startStation, Double endStation, Double station, ref Double resultStation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlgSelectStationDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgSelectStationDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.AlgSelectStationDlg`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String title, Alignment alg, Predicate<Double> match, String matchError, ref Double station` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CreateAlignmentParams` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgPropertiesDlg+CreateAlignmentParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyAlignmentParams` | `Void` | `Alignment alignment` | `` |
| `CommitDialog` | `Boolean` | `AlgPropertiesDlg dialog` | `` |
| `FillTemplateParams` | `Void` | `Alignment template, IProjectModel folder` | `` |
| `InitDialog` | `Void` | `AlgPropertiesDlg dialog` | `` |

### `MultiplyActionDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.MultiplyActionDlg` |
| **Base Type** | `System.Windows.Forms.Form` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Alg.Runtime.Dialogs.MultiplyActionDlg`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AssemblyTitle` | `String` | `get` | Yes | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Show` | `Result` | `String text` | `` |

#### Nested Types (1)

- `Result` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Result` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.MultiplyActionDlg+Result` |
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
      - `Topomatic.Alg.Runtime.Dialogs.MultiplyActionDlg+Result`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cancel` | `Result` | Yes | `Cancel` | `` |
| `No` | `Result` | Yes | `No` | `` |
| `NoToAll` | `Result` | Yes | `NoToAll` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Yes` | `Result` | Yes | `Yes` | `` |
| `YesToAll` | `Result` | Yes | `YesToAll` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Yes` | `0` |
| `YesToAll` | `1` |
| `No` | `2` |
| `NoToAll` | `3` |
| `Cancel` | `4` |

**Underlying Type**: `System.Int32`

### `ReturnResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.AlgMoveDlg+ReturnResult` |
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
      - `Topomatic.Alg.Runtime.Dialogs.AlgMoveDlg+ReturnResult`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `ReturnResult` | Yes | `None` | `` |
| `Station` | `ReturnResult` | Yes | `Station` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Station` | `1` |

**Underlying Type**: `System.Int32`

### `SelectTableElementDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.SelectTableElementDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Alg.Runtime.Dialogs.SelectTableElementDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String caption, IEnumerable wrapper, ref Int32 selectedIndex` | `` |
| `ExecuteMultiply` | `Boolean` | `String caption, IEnumerable wrapper, ref Int32[] indexes` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `roburPropertyGrid` | `PropertyGrid` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StraighteningSimplePlanSolverDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.StraighteningSimplePlanSolverDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.StraighteningSimplePlanSolverDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `ref Double acceptableAdjust, ref Double surveyFactor, ref Int32 minimumCurvePoints, ref Int32 maximumFracturesCount, ref Boolean useFractures, ref Boolean withoutClothoids, ref RoundTo l_RoundTo, ref RoundTo r_RoundTo` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UnderlayDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.UnderlayDlg` |
| **Base Type** | `System.Windows.Forms.Form` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Alg.Runtime.Dialogs.UnderlayDlg`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndPoint` | `Vector2D` | `get/set` | No | `` |
| `StartPoint` | `Vector2D` | `get/set` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `Drawing drawing, ref Vector2D a` | `` |
| `Execute` | `Boolean` | `Drawing drawing, ref Vector2D a, ref Vector2D b` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VolumeCipherDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Dialogs.VolumeCipherDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.Dialogs.VolumeCipherDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `Int32[] intervals, String[] applicability, Int32 userCode` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.ExpImp`

### `DbfFieldAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.DbfFieldAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Alg.Runtime.ExpImp.DbfFieldAttribute`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Byte width)`
- `.ctor(String name, Char fieldType, Int32 pos, Byte width, Byte decimals)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Decimals` | `Byte` | `get` | No | `` |
| `FieldType` | `Char` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Pos` | `Int32` | `get` | No | `` |
| `Width` | `Byte` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ExchangeCsvProvider`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ExchangeCsvProvider`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - ``
      - `Topomatic.Alg.Runtime.ExpImp.ExchangeCsvProvider`1`

#### Constructors (1)

- `.ctor(Encoding encoding)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `FileExtension` | `String` | `get` | No | `` |
| `FileFilter` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

### `ExchangeDbfProvider`2<T where class, U where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ExchangeDbfProvider`2` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - ``
      - `Topomatic.Alg.Runtime.ExpImp.ExchangeDbfProvider`2`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `FileExtension` | `String` | `get` | No | `` |
| `FileFilter` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

### `ExchangeProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `FileExtension` | `String` | `get` | No | `` |
| `FileFilter` | `String` | `get` | No | `` |
| `IsEnhancementSettings` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFileName` | `String` | `String path, String name` | `` |
| `ShowEnhancementSettings` | `Void` | `` | `` |

### `ExchangeProvider`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1` |
| **Base Type** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `String fileName, T value` | `` |
| `Import` | `Boolean` | `String fileName, T value` | `` |

### `ExchangeStgProvider`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ExchangeStgProvider`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - ``
      - `Topomatic.Alg.Runtime.ExpImp.ExchangeStgProvider`1`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `FileExtension` | `String` | `get` | No | `` |
| `FileFilter` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

### `ModelIndorXmlProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ModelIndorXmlProvider` |
| **Base Type** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Runtime.ExpImp.ModelIndorXmlProvider`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |

### `ModelLandXmlProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ModelLandXmlProvider` |
| **Base Type** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Runtime.ExpImp.ModelLandXmlProvider`

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExportCgPoints` | `Void` | `StreamWriter writer, SurfacePoint point, String name` | `` |
| `ExportCgPoints` | `Void` | `StreamWriter writer, SurfacePointArray points, Predicate<Int32> pointMatch` | `` |
| `ExportCompoundLine` | `Void` | `StreamWriter writer, CompoundLine line, Double startStation` | `` |
| `ExportProjectProfile` | `Void` | `StreamWriter writer, ProjectProfile profile, String name, Double startStation` | `` |
| `ExportStaticProfile` | `Void` | `StreamWriter writer, Profile profile, String name, Double startStation` | `` |
| `ExportStructureLine` | `Void` | `StreamWriter writer, StructureLine line, String name, Double startStation` | `` |
| `ExportSurface` | `Void` | `StreamWriter writer, Surface surface, Predicate<Int32> pointMatch, String name` | `` |

### `ModelStgProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.ModelStgProvider` |
| **Base Type** | `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`
    - `Topomatic.Alg.Runtime.ExpImp.ExchangeProvider`1[[Topomatic.Alg.Model.AlignmentModel, Topomatic.Alg.Model, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Alg.Runtime.ExpImp.ModelStgProvider`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanExport` | `Boolean` | `get` | No | `` |
| `CanImport` | `Boolean` | `get` | No | `` |

### `SelectExchangeProviderDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ExpImp.SelectExchangeProviderDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.StoredDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Controls.Dialogs.StoredDlg`
                  - `Topomatic.Alg.Runtime.ExpImp.SelectExchangeProviderDlg`

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Export` | `Void` | `T exportObject, String defaultFileName, ExchangeProvider[] providers` | `` |
| `Import` | `Boolean` | `T importObject, String defaultFileName, ExchangeProvider[] providers` | `` |
| `SelectExportProvider` | `KeyValuePair<String ExchangeProvider<T>>` | `String text, String defaultPath, String defaultName, ExchangeProvider[] providers` | `` |
| `SelectImportProvider` | `KeyValuePair<String ExchangeProvider<T>>` | `String text, String defaultPath, String defaultName, ExchangeProvider[] providers` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.GridPanel`

### `AgProfileGridElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.AgProfileGridElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.AgProfileGridElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AgProfileGridGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.AgProfileGridGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.AgProfileGridGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GridLayerUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FilterProfileStations` | `List<Int32>` | `Profile profile, CadView cadView, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |
| `FilterProfileStations` | `List<Int32>` | `AgProfile profile, CadView cadView, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |
| `FilterProjectProfileStations` | `List<Int32>` | `ProjectProfile profile, CadView cadView, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |
| `FilterProjectProfileStations` | `List<Int32>` | `SplineProfile profile, CadView cadView, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |
| `FilterSectionsStations` | `List<Int32>` | `SectionList sections, CadView cadView, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |
| `ProjectPoint` | `Point` | `CadView cadView, Vector2D position` | `` |

#### Nested Types (2)

- `ListStationsFilter` (class)
- `StationFilter`1` (abstract class)

### `GridPanelCrsSectionMouseEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridPanelCrsSectionMouseEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs`
        - `Topomatic.Alg.Runtime.GridPanel.GridPanelCrsSectionMouseEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, Rectangle clientBounds, Int32 x, Int32 y, MouseButtons button, Boolean ctrlPressed, Int32 currentSection, CrsDesignContext currentContext, Double profileElevation)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CurrentContext` | `CrsDesignContext` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get` | No | `` |
| `ProfileElevation` | `Double` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `GridPanelCrsSectionPaintEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridPanelCrsSectionPaintEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs`
        - `Topomatic.Alg.Runtime.GridPanel.GridPanelCrsSectionPaintEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, Rectangle clientBounds, Graphics graphics, Font font, Boolean isWhiteBackColor, Int32 currentSection, CrsDesignContext currentContext, Double profileElevation)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CurrentContext` | `CrsDesignContext` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `ProfileElevation` | `Double` | `get` | No | `` |
| `SmoothBorders` | `SmoothBorders` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindCrsComponent` | `T` | `T type` | `` |
| `FindCrsComponent` | `T` | `T type, CrsContainer container` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `GridPanelProfileMouseEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridPanelProfileMouseEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelMouseEventArgs`
        - `Topomatic.Alg.Runtime.GridPanel.GridPanelProfileMouseEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, Rectangle clientBounds, Int32 x, Int32 y, MouseButtons button, Boolean ctrlPressed, Transition transition, Int32 startSection, Int32 endSection)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndSection` | `Int32` | `get` | No | `` |
| `StartSection` | `Int32` | `get` | No | `` |
| `Transition` | `Transition` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `GridPanelProfilePaintEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridPanelProfilePaintEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPaintEventArgs`
        - `Topomatic.Alg.Runtime.GridPanel.GridPanelProfilePaintEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, Rectangle clientBounds, Graphics graphics, Font font, Boolean isWhiteBackColor, Transition transition, Int32 startSection, Int32 endSection)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndSection` | `Int32` | `get` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `LeftSmoothBorder` | `Int32` | `get` | No | `` |
| `RightSmoothBorder` | `Int32` | `get` | No | `` |
| `SmoothBorders` | `SmoothBorders` | `get` | No | `` |
| `StartSection` | `Int32` | `get` | No | `` |
| `Transition` | `Transition` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `GridPanelProfilePopupMenuEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridPanelProfilePopupMenuEventArgs` |
| **Base Type** | `Topomatic.Cad.View.Controls.GridPanelPopupMenuEventArgs` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.View.Controls.GridPanelLayerEventArgs`
      - `Topomatic.Cad.View.Controls.GridPanelPopupMenuEventArgs`
        - `Topomatic.Alg.Runtime.GridPanel.GridPanelProfilePopupMenuEventArgs`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, Rectangle clientBounds, Int32 x, Int32 y, MenuAction root, Transition transition, Int32 startSection, Int32 endSection)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `EndSection` | `Int32` | `get` | No | `` |
| `StartSection` | `Int32` | `get` | No | `` |
| `Transition` | `Transition` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

### `ListStationsFilter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils+ListStationsFilter` |
| **Base Type** | `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils+StationFilter`1[[System.Collections.Generic.List`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils+StationFilter`1[[System.Collections.Generic.List`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils+ListStationsFilter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ProfileGridCrossSectionsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProfileGridCrossSectionsLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProfileGridCrossSectionsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileGridElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProfileGridElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProfileGridElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileGridGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProfileGridGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProfileGridGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileGridPlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProfileGridPlanLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProfileGridPlanLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileGridStationingLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProfileGridStationingLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProfileGridStationingLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProjectProfileGradeDeltaLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGradeDeltaLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGradeDeltaLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |
| `DefaultVisible` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProjectProfileGridElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGridElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGridElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultProportion` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProjectProfileGridGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGridGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.ProjectProfileGridGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseDown` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnMouseUp` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `OnPopupMenu` | `Void` | `GridPanelPopupMenuEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProjectTransitionsViolationsLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.ProjectTransitionsViolationsLayer` |
| **Base Type** | `Topomatic.Alg.Runtime.GridPanel.TransitionViolationsLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.TransitionViolationsLayer`
        - `Topomatic.Alg.Runtime.GridPanel.ProjectTransitionsViolationsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultVisible` | `Boolean` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LayerId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridCuttingElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridCuttingElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridCuttingElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridCuttingGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridCuttingGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridCuttingGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridRedElevationLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridRedElevationLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridRedElevationLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionGridRedGradeLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.SectionGridRedGradeLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.SectionGridRedGradeLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, Int32 sortOrder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StationFilter`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.GridLayerUtils+StationFilter`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `List<Int32>` | `CadView cadView, T stations, Int32 start, Int32 end, Int32 minWidth, Boolean makeOptimization` | `` |

### `TransitionViolationsLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.GridPanel.TransitionViolationsLayer` |
| **Base Type** | `Topomatic.Cad.View.Controls.SimpleGridPanelLayer` |
| **Implements** | `Topomatic.FoundationClasses.IHandledObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Controls.GridPanelItem`
    - `Topomatic.Cad.View.Controls.SimpleGridPanelLayer`
      - `Topomatic.Alg.Runtime.GridPanel.TransitionViolationsLayer`

#### Constructors (1)

- `.ctor(BaseGridPanelManager manager, String name, String description, Guid guid, Int32 sortOrder)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnMouseMove` | `Void` | `GridPanelMouseEventArgs e` | `` |
| `Paint` | `Void` | `GridPanelPaintEventArgs e` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.Mockup`

### `CrsMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Mockup.CrsMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Alg.Runtime.Mockup.CrsMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CurrentSection` | `Int32` | `get` | No | `` |
| `DesignContext` | `CrsDesignContext` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `PickCrsContour` | `CrsContour` | `` | `` |
| `PickCrsContour` | `CrsContour` | `String msg` | `` |
| `PickCrsNode` | `CrsNode` | `` | `` |
| `PickCrsNode` | `CrsNode` | `String msg` | `` |
| `PickCrsVolume` | `CrsVolume` | `` | `` |
| `ProjectPos` | `Vector2D` | `Vector2D pos` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MockupExtention` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Mockup.MockupExtention` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAlignment` | `Alignment` | `Mockup mockup` | `Extension` |
| `GetTransition` | `Transition` | `Mockup mockup` | `Extension` |

### `MockupPrfWizardController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Mockup.MockupPrfWizardController` |
| **Base Type** | `Topomatic.Plt.PltSimpleWizardController` |
| **Implements** | `Topomatic.Controls.Dialogs.IWizardController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Controls.Dialogs.SimpleWizardController`
    - `Topomatic.Plt.PltSimpleWizardController`
      - `Topomatic.Alg.Runtime.Mockup.MockupPrfWizardController`

#### Constructors (1)

- `.ctor(Drawing dwg, WizardFrame[] frames)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `State` | `WizardState` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWizardController` | `get_State` |

### `PrfMockupLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Mockup.PrfMockupLayer` |
| **Base Type** | `Topomatic.Plt.Mockup.MockupLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`
      - `Topomatic.Plt.Mockup.MockupLayer`
        - `Topomatic.Alg.Runtime.Mockup.PrfMockupLayer`

#### Constructors (1)

- `.ctor(TemplateDwgGenerator generator, MockupGenerator templateGenerator)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndSta` | `Double` | `get` | No | `` |
| `ReferenceAlignments` | `DwgDictionary` | `get` | No | `` |
| `RegionIndex` | `Int32` | `get` | No | `` |
| `StartSta` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.Plt`

### `AlgVariableProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.AlgVariableProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Alg.Runtime.Plt.AlgVariableProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `CrsAlgVariableProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.CrsAlgVariableProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Alg.Runtime.Plt.CrsAlgVariableProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `CrsSimpleFieldsProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.CrsSimpleFieldsProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Alg.Runtime.Plt.CrsSimpleFieldsProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `CrsTemplateDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.CrsTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Alg.Runtime.Plt.CrsTemplateDwgGenerator`

#### Constructors (1)

- `.ctor(UInt32 id)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `CutEgLine` | `Boolean` | `get/set` | No | `` |
| `CutEgOffset` | `Double` | `get` | No | `` |
| `HorizontalScale` | `Double` | `get/set` | No | `` |
| `HOType` | `HOType` | `get` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `Layout` | `SheetLayout` | `get/set` | No | `` |
| `OnePerSheet` | `Boolean` | `get/set` | No | `` |
| `SelectedIds` | `UInt32[]` | `get/set` | No | `` |
| `SheetHeight1` | `Double` | `get/set` | No | `` |
| `SheetHeight2` | `Double` | `get/set` | No | `` |
| `SheetWidth1` | `Double` | `get/set` | No | `` |
| `SheetWidth2` | `Double` | `get/set` | No | `` |
| `VerticalHatOffset` | `Double` | `get/set` | No | `` |
| `VerticalScale` | `Double` | `get/set` | No | `` |

### `EgLineStyleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.EgLineStyleConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Alg.Runtime.Plt.EgLineStyleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `EgLineType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.EgLineType` |
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
      - `Topomatic.Alg.Runtime.Plt.EgLineType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Double` | `EgLineType` | Yes | `Double` | `` |
| `Single` | `EgLineType` | Yes | `Single` | `` |
| `SingleWithCellar` | `EgLineType` | Yes | `SingleWithCellar` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Single` | `0` |
| `Double` | `1` |
| `SingleWithCellar` | `2` |

**Underlying Type**: `System.Int32`

### `PrfAlgVariableProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.PrfAlgVariableProvider` |
| **Base Type** | `Topomatic.Plt.Templates.Common.PltVariableProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.PltVariableProvider`
    - `Topomatic.Alg.Runtime.Plt.PrfAlgVariableProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `PltVariables variables` | `` |

### `PrfSimpleFieldsProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.PrfSimpleFieldsProvider` |
| **Base Type** | `Topomatic.Plt.Templates.TemplateFieldProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.TemplateFieldProvider`
    - `Topomatic.Alg.Runtime.Plt.PrfSimpleFieldsProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Provide` | `Void` | `TemplateProcessor templateProcessor` | `` |

### `PrfTemplateDwgGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.PrfTemplateDwgGenerator` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateDwgGenerator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.DwgGenerator`
    - `Topomatic.Plt.Templates.Common.TemplateDwgGenerator`
      - `Topomatic.Alg.Runtime.Plt.PrfTemplateDwgGenerator`

#### Constructors (1)

- `.ctor(UInt32 id)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveTransition` | `Transition` | `get/set` | No | `` |
| `Alignment` | `Alignment` | `get/set` | No | `` |
| `Id` | `UInt32` | `get` | No | `` |
| `ProfileType` | `Int32` | `get` | No | `` |
| `Ranges` | `IEnumerable<StaRange>` | `get/set` | No | `` |
| `ReferenceAlignments` | `List<String>` | `get/set` | No | `` |
| `RegionIndex` | `Int32` | `get/set` | No | `` |
| `Sheets` | `IEnumerable<StaRange>` | `get/set` | No | `` |

### `ProfileType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.ProfileType` |
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
      - `Topomatic.Alg.Runtime.Plt.ProfileType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Contracted` | `ProfileType` | Yes | `Contracted` | `` |
| `Drainage` | `ProfileType` | Yes | `Drainage` | `` |
| `KapRem` | `ProfileType` | Yes | `KapRem` | `` |
| `SecondPath` | `ProfileType` | Yes | `SecondPath` | `` |
| `Standart` | `ProfileType` | Yes | `Standart` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Standart` | `0` |
| `Drainage` | `1` |
| `Contracted` | `2` |
| `SecondPath` | `3` |
| `KapRem` | `4` |

**Underlying Type**: `System.Int32`

### `SheetLayout` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.SheetLayout` |
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
      - `Topomatic.Alg.Runtime.Plt.SheetLayout`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HorizontalLeft` | `SheetLayout` | Yes | `HorizontalLeft` | `` |
| `HorizontalRight` | `SheetLayout` | Yes | `HorizontalRight` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VerticalDown` | `SheetLayout` | Yes | `VerticalDown` | `` |
| `VerticalUp` | `SheetLayout` | Yes | `VerticalUp` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `HorizontalRight` | `0` |
| `VerticalUp` | `1` |
| `HorizontalLeft` | `2` |
| `VerticalDown` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Runtime.Plt.Fields`

### `UnfoldedPlan` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.UnfoldedPlan` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.UnfoldedPlan`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.Plt.Fields.Prf`

### `BaseFlagsConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.BaseFlagsConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.BaseFlagsConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `CurveFormatPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.CurveFormatPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.CurveFormatPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `FlagsCountAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.FlagsCountAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.FlagsCountAttribute`

#### Constructors (1)

- `.ctor(Int32 count)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FlagsEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.FlagsEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.FlagsEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `Grades` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Grades` |
| **Base Type** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField`
        - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Grades`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `` |
| `Mode` | `Int32` | `get/set` | No | `PropertyProvider` |
| `ProfileStringID` | `String` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `Step` | `Double` | `get/set` | No | `Length` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Kilometers` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Kilometers` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Kilometers`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `CircleRadius` | `Double` | `get/set` | No | `` |
| `LineLength` | `Double` | `get/set` | No | `` |
| `PatternName` | `String` | `get/set` | No | `PropertyEditor` |
| `Precision` | `Int32` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `DefaultDouble` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Line` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Line` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Line`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Pkt` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pkt` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pkt`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Pln` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurveFormat` | `String` | `get/set` | No | `PropertyProvider` |
| `Offset` | `Double` | `get/set` | No | `` |
| `PlanPrecision` | `Int32` | `get/set` | No | `` |
| `PlusPrecision` | `Int32` | `get/set` | No | `` |
| `ProfileType` | `Int32` | `get` | No | `` |
| `RadiusPrecision` | `Int32` | `get/set` | No | `` |
| `UpsideDown` | `Boolean` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlnRail` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.PlnRail` |
| **Base Type** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln`
        - `Topomatic.Alg.Runtime.Plt.Fields.Prf.PlnRail`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PlnRoad` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.PlnRoad` |
| **Base Type** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Pln`
        - `Topomatic.Alg.Runtime.Plt.Fields.Prf.PlnRoad`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PltGaps` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.PltGaps` |
| **Base Type** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField`
        - `Topomatic.Alg.Runtime.Plt.Fields.Prf.PltGaps`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ProfileStringIdConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.ProfileStringIdConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.ProfileStringIdConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `ProfileStringIdEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.ProfileStringIdEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.ProfileStringIdEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |

### `RailPathField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathField` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PathIndex` | `Int32` | `get/set` | No | `PropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailPathTransitionField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathTransitionField` |
| **Base Type** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathField`
        - `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailPathTransitionField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Mode` | `Int32` | `get/set` | No | `PropertyProvider` |
| `ProfileStringID` | `String` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Step` | `Double` | `get/set` | No | `Length` |
| `TransitionIndex` | `Int32` | `get/set` | No | `PropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RailTwoPathField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailTwoPathField` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.RailTwoPathField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PathIndex1` | `Int32` | `get/set` | No | `PropertyProvider` |
| `PathIndex2` | `Int32` | `get/set` | No | `PropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleH` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.ScaleH` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.ScaleH`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ScaleV` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.ScaleV` |
| **Base Type** | `Topomatic.Plt.Templates.Common.TemplateField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.ScaleV`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SideIdPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.SideIdPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.SideIdPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `StandartValueProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.StandartValueProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.StandartValueProperty`

#### Constructors (3)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes, IEnumerable<KeyValuePair<Int32 String>> values)`
- `.ctor(PropertyInfo property, Object instance, Object[] attributes, String[] values)`
- `.ctor(PropertyInfo property, Object instance, Object[] attributes, String[] values, String defaultValue)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |

### `StepModePropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.StepModePropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.StepModePropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `TransitionField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Transition` | `Transition` | `get` | No | `` |
| `TransitionIndex` | `Int32` | `get/set` | No | `PropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TransitionIndexPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionIndexPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Alg.Runtime.Plt.Fields.Prf.TransitionIndexPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

---
## Namespace: `Topomatic.Alg.Runtime.Plt.Fields.Prf.Universal`

### `RailPathsField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Plt.Fields.Prf.Universal.RailPathsField` |
| **Base Type** | `Topomatic.Plt.Templates.Prf.PrfField` |
| **Implements** | `Topomatic.Plt.Mockup.IMockupable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Plt.Templates.Common.TemplateField`
    - `Topomatic.Plt.Templates.Prf.PrfField`
      - `Topomatic.Alg.Runtime.Plt.Fields.Prf.Universal.RailPathsField`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Indexes` | `String` | `get/set` | No | `PropertyProvider` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.RectificationPlan`

### `RectificationPlanDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.RectificationPlan.RectificationPlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Drawing drawing, Alignment alg, Double scale, Double start, Double end, Double height, Boolean reversed` | `` |

---
## Namespace: `Topomatic.Alg.Runtime.ServiceClasses`

### `ActiveAlignmentReciver`1<T where Alignment, INamedTransactable, ITransactable, IUpdatable, IAlignmentContainer, IStgSerializable, IStationingContainer, IOwned, class, Alignment>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.ActiveAlignmentReciver`1` |
| **Base Type** | `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ApplicationPlatform.ServiceClasses.ModelReceiver`
    - `Topomatic.ApplicationPlatform.ServiceClasses.ActiveModelReceiver`
      - `Topomatic.Alg.Runtime.ServiceClasses.ActiveAlignmentReciver`1`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveTransition` | `Transition` | `get` | No | `` |
| `Alignment` | `T` | `get` | No | `` |
| `AlignmentModel` | `AlignmentModel` | `get` | No | `` |
| `Manager` | `AlignmentActivityManager` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckActiveAlignment` | `Boolean` | `Predicate<AlignmentModel> match` | `` |
| `CheckActiveAlignment` | `Boolean` | `Predicate<AlignmentModel> match, Boolean readOnly` | `` |
| `CreateReciver` | `ActiveAlignmentReciver<T>` | `Predicate<AlignmentModel> match, Boolean readOnly` | `` |
| `CreateReciver` | `ActiveAlignmentReciver<T>` | `Boolean readOnly` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `AlgCoreItemResolver` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreItemResolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveAction` | `Object` | `Int32 action, Object[] prms` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ACT_EXPORT` | `Int32` | Yes | `0` | `` |
| `ACT_IMPORT` | `Int32` | Yes | `1` | `` |
| `ACT_OPEN` | `Int32` | Yes | `2` | `` |

### `AlgCoreTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindLastActiveAlignment` | `IProjectModel` | `` | `` |
| `FindModelName` | `String` | `Object obj` | `` |
| `FindStateController` | `StateControllerObject` | `Object obj` | `` |
| `LoadModelTemplate` | `T` | `String modelType` | `` |

#### Fields (33)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BROADCAST_CHANGED_ALIGNMENT` | `String` | Yes | `"broadcast_changed_alignment"` | `` |
| `CRS_DWL_MODEL` | `String` | Yes | `"application/crs-dwl"` | `` |
| `DTM_MODEL` | `String` | Yes | `"dtm"` | `` |
| `DWG_MODEL` | `String` | Yes | `"application/dwg"` | `` |
| `GEOLOGY_MODEL` | `String` | Yes | `"global_glg"` | `` |
| `OLD_SOIL_WORK_MODEL` | `String` | Yes | `"rsw"` | `` |
| `PLN_DWL_MODEL` | `String` | Yes | `"application/pln-dwl"` | `` |
| `PRF_DWL_MODEL` | `String` | Yes | `"application/prf-dwl"` | `` |
| `RAIL_MODEL` | `String` | Yes | `"rail"` | `` |
| `ROAD_MODEL` | `String` | Yes | `"road"` | `` |
| `SITE_MODEL` | `String` | Yes | `"site"` | `` |
| `SURVEY_MODEL` | `String` | Yes | `"survey"` | `` |
| `TASK_AFTER_RETRASE_TASK` | `String` | Yes | `"after_dynamic_retrace"` | `` |
| `TASK_BEFORE_RETRASE_TASK` | `String` | Yes | `"before_dynamic_retrace"` | `` |
| `TASK_CAN_JOIN_ALIGNMENT` | `String` | Yes | `"can_join_alignment"` | `` |
| `TASK_CAN_SPLIT_ALIGNMENT` | `String` | Yes | `"can_split_alignment"` | `` |
| `TASK_COPY` | `String` | Yes | `"alignment_copy"` | `` |
| `TASK_EQUALS_SEGMENT` | `String` | Yes | `"alignment_equlas_segment"` | `` |
| `TASK_EQUALS_STATION` | `String` | Yes | `"alignment_equlas_station"` | `` |
| `TASK_EXPORT_TO_INDOR_XML` | `String` | Yes | `"export_alignment_to_indor_xml"` | `` |
| `TASK_EXPORT_TO_LAND_XML` | `String` | Yes | `"export_alignment_to_land_xml"` | `` |
| `TASK_FILL_PROFILE_INTERVALS` | `String` | Yes | `"fill_profile_intervals"` | `` |
| `TASK_GET_PROVIDERS` | `String` | Yes | `"get_providers"` | `` |
| `TASK_GET_TASK_ID` | `String` | Yes | `"get_task_id"` | `` |
| `TASK_IMPORT_FROM_INDOR_XML` | `String` | Yes | `"import_alignment_from_indor_xml"` | `` |
| `TASK_IMPORT_FROM_LAND_XML` | `String` | Yes | `"import_alignment_from_land_xml"` | `` |
| `TASK_JOIN_ALIGNMENT` | `String` | Yes | `"join_alignment"` | `` |
| `TASK_PLT_FIELDS` | `String` | Yes | `"plt_fields"` | `` |
| `TASK_PLT_VALIDATORS` | `String` | Yes | `"plt_varidators"` | `` |
| `TASK_PLT_VARIABLES` | `String` | Yes | `"plt_variables"` | `` |
| `TASK_PLUGIN` | `String` | Yes | `"alg_plugins"` | `` |
| `TASK_REMOTE_SERVICE_PROVIDER` | `String` | Yes | `"get_remote_service_provider"` | `` |
| `TASK_SPLIT_ALIGNMENT` | `String` | Yes | `"split_alignment"` | `` |

### `CadViewPaintLocker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.UIUtils+CadViewPaintLocker` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean locked)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Lock` | `Void` | `` | `` |
| `Unlock` | `Void` | `Boolean invalidate` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CreateModelAsk` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.UIUtils+CreateModelAsk` |
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
      - `Topomatic.Alg.Runtime.ServiceClasses.UIUtils+CreateModelAsk`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ask` | `CreateModelAsk` | Yes | `Ask` | `` |
| `Preffered` | `CreateModelAsk` | Yes | `Preffered` | `` |
| `Replace` | `CreateModelAsk` | Yes | `Replace` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Ask` | `0` |
| `Replace` | `1` |
| `Preffered` | `2` |

**Underlying Type**: `System.Int32`

### `MultiplyActionQuery` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.MultiplyActionQuery` |
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
| `Status` | `MultiplyActionQueryStatus` | `get/set` | No | `` |

### `MultiplyActionQueryStatus` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.MultiplyActionQueryStatus` |
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
      - `Topomatic.Alg.Runtime.ServiceClasses.MultiplyActionQueryStatus`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cancel` | `MultiplyActionQueryStatus` | Yes | `Cancel` | `` |
| `NoToAll` | `MultiplyActionQueryStatus` | Yes | `NoToAll` | `` |
| `Query` | `MultiplyActionQueryStatus` | Yes | `Query` | `` |
| `value__` | `Int32` | No | `` | `` |
| `YesToAll` | `MultiplyActionQueryStatus` | Yes | `YesToAll` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Query` | `0` |
| `YesToAll` | `1` |
| `NoToAll` | `2` |
| `Cancel` | `3` |

**Underlying Type**: `System.Int32`

### `OffsetsBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.OffsetsBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alg, Double step, List<DwgPolyline> plines, Int32 transitionIndex)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `Offset offsets` | `` |

### `PltUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.PltUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AlignmentFromReferencePath` | `Alignment` | `PrfField field, Int32 pathIndex` | `` |
| `AlignmentFromSecondPath` | `Alignment` | `TemplateField field, Int32 pathIndex` | `` |

### `ProjectSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.ProjectSurfaceBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 capcity)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `SurfacePoint point` | `` |
| `BeginSection` | `Void` | `` | `` |
| `BuildSurface` | `Void` | `Surface surface` | `` |
| `EndSection` | `Void` | `` | `` |

### `SimpleCoreItemResolver`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.SimpleCoreItemResolver`1` |
| **Base Type** | `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreItemResolver` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreItemResolver`
    - `Topomatic.Alg.Runtime.ServiceClasses.SimpleCoreItemResolver`1`

### `SimpleCoreTransitionItemResolver`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.SimpleCoreTransitionItemResolver`1` |
| **Base Type** | `` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.ServiceClasses.AlgCoreItemResolver`
    - ``
      - `Topomatic.Alg.Runtime.ServiceClasses.SimpleCoreTransitionItemResolver`1`

### `UIUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ServiceClasses.UIUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateModel` | `IProjectModel` | `IProjectModel model, String[] folders, String modelType, String prefferedName, String message, ref CreateModelAsk ask` | `` |
| `DisableControls` | `Void` | `Control control, Boolean enable` | `` |
| `FillComboBox` | `Void` | `ComboBox box, BaseEnumConverter converter, Type enumType` | `` |
| `FilterAlignments` | `IEnumerable<KeyValuePair<String Boolean>>` | `URI folderUri, String currentRelativePath, IList<String> relativePaths` | `` |
| `FilterAlignments` | `IEnumerable<KeyValuePair<String Boolean>>` | `URI folderUri, IProjectModel model, IList<String> relativePaths` | `` |
| `FilterModels` | `IEnumerable<KeyValuePair<String Boolean>>` | `String[] modelTypes, URI folderUri, String currentRelativePath, IList<String> relativePaths` | `` |
| `FilterModels` | `IEnumerable<KeyValuePair<String Boolean>>` | `String[] modelTypes, URI folderUri, IProjectModel model, IList<String> relativePaths` | `` |
| `FilterSurfaces` | `IEnumerable<KeyValuePair<String Boolean>>` | `URI folderUri, String currentRelativePath, IList<String> relativePaths` | `` |
| `FilterSurfaces` | `IEnumerable<KeyValuePair<String Boolean>>` | `URI folderUri, IProjectModel model, IList<String> relativePaths` | `` |
| `FindInsideListBox` | `Int32` | `ListBox list, Int32 from, String pattern` | `` |
| `FindSimpleGridPanel` | `SimpleGridPanel` | `String windowUID` | `` |
| `GetStationsWithLimitations` | `Void` | `Alignment alignment, Double sourceFrom, Double sourceTo, Boolean allTrace, ref Double resultFrom, ref Double resultTo` | `` |
| `TextBoxModified` | `Boolean` | `Control control` | `` |
| `TryGetObjectFromPlan` | `T` | `String message, Predicate<T> match` | `` |
| `TryGetStationFromPlan` | `Boolean` | `Alignment alignment, String message, ref Double station, ref Double offset` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ALIGNMENTS_MASK` | `String[]` | Yes | `` | `` |
| `SURFACES_MASK` | `String[]` | Yes | `` | `` |

#### Nested Types (2)

- `CadViewPaintLocker` (class)
- `CreateModelAsk` (enum)

---
## Namespace: `Topomatic.Alg.Runtime.Settings`

### `AlignmentLineSegmentsSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.AlignmentLineSegmentsSettings` |
| **Base Type** | `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.UserControl`
              - `Topomatic.ApplicationPlatform.UserSettings.UserSettingsPanel`
                - `Topomatic.Alg.Runtime.Settings.AlignmentLineSegmentsSettings`

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AlignmentPropertiesSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.AlignmentPropertiesSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment, String modelType, URI folderUri)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `ExistingCrsSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.ExistingCrsSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `PerspectiveSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.PerspectiveSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `PlanSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.PlanSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `PrecisionSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.PrecisionSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `ProfileSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.ProfileSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `ProfileVisibilitySettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.ProfileVisibilitySettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

### `StationingSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Settings.StationingSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlignmentModel alignment, URI folderUri)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |

---
## Namespace: `Topomatic.Alg.Runtime.ShaftPipes`

### `Pipe` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ShaftPipes.Shaft+Pipe` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Diameter` | `String` | `get/set` | No | `` |
| `Elevation` | `String` | `get/set` | No | `` |
| `Material` | `String` | `get/set` | No | `` |
| `Num` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `PipeSemanticDataStyleProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ShaftPipes.PipeSemanticDataStyleProvider` |
| **Base Type** | `Topomatic.Smt.SemanticDataStyleProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Smt.SemanticDataStyleProvider`
    - `Topomatic.Alg.Runtime.ShaftPipes.PipeSemanticDataStyleProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateNode` | `SemanticNode` | `SemanticRootNode root, Int32 handle` | `` |

### `Shaft` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ShaftPipes.Shaft` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SurfacePoint point)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BotElev` | `String` | `get/set` | No | `` |
| `Destiny` | `String` | `get/set` | No | `` |
| `FirstInspectionDate` | `String` | `get/set` | No | `` |
| `Length` | `String` | `get/set` | No | `` |
| `Material` | `String` | `get/set` | No | `` |
| `NextInspectionDate` | `String` | `get/set` | No | `` |
| `Num` | `String` | `get/set` | No | `` |
| `Number` | `Int32` | `get/set` | No | `` |
| `Pipes` | `List<Pipe>` | `get/set` | No | `` |
| `Prim` | `String` | `get/set` | No | `` |
| `TopElev` | `String` | `get/set` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |
| `Width` | `String` | `get/set` | No | `` |

#### Nested Types (1)

- `Pipe` (class)

### `ShaftPipesProvider` (class)

**Attributes**: [DoNotObfuscate]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.ShaftPipes.ShaftPipesProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InitializeProperties` | `Boolean` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Deserialize` | `ShaftPipesProvider` | `Byte[] buffer` | `` |
| `Serialize` | `Byte[]` | `ShaftPipesProvider provider` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ShaftPipeProviderTag` | `String` | Yes | `"<class>ShaftPipeProvider</class>"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Runtime.Standards`

### `StandardLibrary` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Standards.StandardLibrary` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String version, String signature, String description)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get` | No | `` |
| `Version` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLibraryFileName` | `String` | `String libraryPrefix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StandardLibrary`1<T where class>` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Standards.StandardLibrary`1` |
| **Base Type** | `Topomatic.Alg.Runtime.Standards.StandardLibrary` |
| **Implements** | `Topomatic.Stg.IStgSerializable, , , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Standards.StandardLibrary`
    - `Topomatic.Alg.Runtime.Standards.StandardLibrary`1`

#### Constructors (1)

- `.ctor(String version, String signature, String description)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

---
## Namespace: `Topomatic.Alg.Runtime.Tools`

### `AlignLibrary` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.AlignLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (40)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcElevation` | `Boolean` | `CrsLine l, IEnumerable<Surface> surfaces, CompoundLine planLine, Double station, Double offset, ref Double value` | `` |
| `CalculateRetraceStations` | `Void` | `PlanLine planLine, Int32 start_index, Int32 end_index, ref Double start, ref Double end` | `` |
| `CalculateRetraceStations` | `Void` | `ProjectProfile profileLine, Int32 start_index, Int32 end_index, ref Double start, ref Double end` | `` |
| `CalculateSpecialPoints` | `Void` | `Alignment alignment, List<KeyValuePair<Double String>> points` | `` |
| `CenterProjectNode` | `Boolean` | `ProjectProfile profile, Int32 nodeIndex` | `` |
| `DesignSimilarConstruction` | `Void` | `Corridor corridor, Int32 destIndex1, Int32 destIndex2, Int32 sourceIndex` | `` |
| `FindAlignments` | `Boolean` | `IProjectModel model, IList<String> paths, IList<KeyValuePair<String Alignment>> result` | `` |
| `FindCrsNode` | `CrsNode` | `CrsDesignContext context, Int32 code` | `` |
| `FindSurfaces` | `Boolean` | `IProjectModel model, IList<String> paths, IList<Surface> earth, IList<Surface> project` | `` |
| `FindSurfaces` | `Boolean` | `IProjectModel model, IList<String> paths, IList<Surface> result` | `` |
| `FindSurfaces` | `Boolean` | `IProjectModel model, IList<String> paths, IList<KeyValuePair<String Surface>> result` | `` |
| `GetRelativePath` | `Boolean` | `IProjectModel model, String[] types, Boolean hideModel, ref String relativePath` | `` |
| `GetRelativePath` | `Boolean` | `IProjectModel model, String[] types, ref String relativePath` | `` |
| `GetTaskId` | `UInt32` | `Alignment alg, UInt32 id` | `` |
| `GetTemplatesPath` | `String` | `UInt32 id` | `` |
| `GetVar` | `Object` | `Alignment alg1, Alignment alg2, Double sta1, String key` | `` |
| `MakeAgProfile` | `Boolean` | `Profile egProfile, AgProfile profile, Int32 existentAxisCode, IEnumerable<Int32> interpolationCodes, Corridor corridor, Double startStation, Double endStation, Boolean canTerminate` | `` |
| `MakeAgProfile` | `Boolean` | `IList<Double> stations, CompoundLine planLine, Double dtmSizeLeft, Double dtmSizeRight, IEnumerable<Surface> surfaces, Int32 existentAxisCode, IEnumerable<Int32> interpolationCodes, Profile egProfile, AgProfile agProfile, Boolean filterCrossPoint, Double filterCrossPointFactor, Boolean canTerminate` | `` |
| `MakeCrossSectionsAtStations` | `Void` | `Alignment alignment, IEnumerable<Surface> surfaces, Double[] stations, Int32[] skipCodes, Double authenticityAngle, Double regionSize, Boolean interpolate` | `` |
| `MakeEgProfile` | `Boolean` | `IList<Double> stations, CompoundLine planLine, Corridor corridor, Double dtmSizeLeft, Double dtmSizeRight, IEnumerable<Surface> surfaces, IOffset offset, IList<ProfileNode> eg, Boolean use_sections, Boolean filterCrossPoint, Double filterCrossPointFactor, Boolean canTerminate` | `` |
| `MakeNullPointStations` | `Void` | `Transition cl, Double startStation, Double endStation, List<Double> stations` | `` |
| `MakeProjectProfileByEgOffset` | `Void` | `ProjectProfile profile, Profile eg, ProjectNodeFlags defaultFlag, Double startStation, Double endStation, Double offset` | `` |
| `MakeStations` | `Boolean` | `Alignment alignment, Double startStation, Double endStation, Double step, BuildProfileFlags options, IEnumerable<Double> additionalStations, Communications communications, IEnumerable<Surface> surfaces, List<Double> stations, Boolean canTerminate` | `` |
| `MakeWholeStations` | `Boolean` | `Alignment alignment, Double startStation, Double endStation, Double step, List<Double> stations, Boolean canTerminate` | `` |
| `OffsetPlan` | `Void` | `PlanLine plan1, PlanLine plan2, Double offset` | `` |
| `ScanCrossDtm` | `CrsLine` | `Double station, CrsLine sl, IEnumerable<Surface> egSurfaces, IEnumerable<Surface> projectSurfaces, CompoundLine planLine, Boolean filterCrossPoints, Double filterCrossPointFactor` | `` |
| `ScanCrossDtm` | `CrsLine` | `Double station, IEnumerable<Surface> surfaces, CompoundLine planLine, Double dtmSizeLeft, Double dtmSizeRight, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `ScanCrossDtm` | `CrsLine` | `Double station, IEnumerable<Surface> egSurfaces, IEnumerable<Surface> projectSurfaces, CompoundLine planLine, Double dtmSizeLeft, Double dtmSizeRight, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `ScanCrossMultiLine` | `List<KeyValuePair<Int32 CrsLine>>` | `Double station, IEnumerable<Surface> surfaces, CompoundLine planLine, Double dtmSizeLeft, Double dtmSizeRight, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `ScanCrossMultiLine` | `List<KeyValuePair<Int32 CrsLine>>` | `Double station, CrsLine sl, IEnumerable<Surface> surfaces, CompoundLine planLine, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `ScanCrossSingleLine` | `CrsLine` | `List<Vector2D> line, IEnumerable<Surface> surfaces, CompoundLine planLine, Double deltax, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `ScanCrossSingleLine` | `CrsLine` | `List<Vector2D> line, IEnumerable<Surface> egSurfaces, IEnumerable<Surface> projectSurfaces, CompoundLine planLine, Double deltax, Boolean filterCrossPoint, Double filterCrossPointFactor` | `` |
| `SelectFromCadView` | `T` | `CadView cadView, T active, String message` | `` |
| `SmashCenterLine` | `Void` | `Alignment alignment, Double lineStep, Double curveStep, List<Double> stations, Double min, Double max` | `` |
| `SmashCenterLine` | `Void` | `Alignment alignment, Double factor, Double min, Double max, List<Double> stations` | `` |
| `SmashCenterLine` | `Void` | `Alignment alignment, Double lineStep, Double curveStep, List<Double> stations` | `` |
| `SmashCenterLineFromWholeStations` | `Void` | `Alignment alignment, Double lineStep, Double curveStep, List<Double> stations` | `` |
| `SmashCenterLineOnSections` | `Void` | `Alignment alignment, Boolean interpolate, Boolean onlyMarked, Double step, List<Double> stations` | `` |
| `TransformProfile` | `Void` | `ProjectProfile profile, Double startStation, Double endStation, Double elevation, Double station, Double offset, Boolean verticalOffset, Boolean horizontalOffset` | `` |
| `TryGetRadius` | `Boolean` | `Item item, ref Double radius` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DoubleEpsComparer` | `IComparer<Double>` | Yes | `` | `` |

### `CodedVector` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.SurfaceBuilder+CodedVector` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Runtime.Tools.SurfaceBuilder+CodedVector`

#### Constructors (1)

- `.ctor(Vector3D p, Int32 c)`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `code` | `Int32` | No | `` | `` |
| `flags` | `Int32` | No | `` | `` |
| `pt` | `Vector3D` | No | `` | `` |

### `CompoundLineBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.CompoundLineBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConverToCompoundLine` | `Boolean` | `IList<DwgEntity> entities, CompoundLine line` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsEntitySopr` | `EntitiySoprType` | `DwgEntity e1, DwgEntity e2, ref Vector2D p1, ref Vector2D p2` | `` |
| `IsEntitySopr` | `EntitiySoprType` | `DwgEntity e1, DwgEntity e2` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Eps` | `Double` | Yes | `` | `` |

#### Nested Types (1)

- `EntitiySoprType` (enum)

### `CrsSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.CrsSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.SurfaceBuilder` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.SurfaceBuilder`
    - `Topomatic.Alg.Runtime.Tools.CrsSurfaceBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 stationsCount, Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AddedStation` | `Double` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSection` | `Void` | `Double station, CrsRedLine redLine, List<Double> smashPoints, Boolean addVerticalSegments` | `` |
| `AddSection` | `Void` | `Double station, CrsDesignContext designContext, List<Double> smashPoints` | `` |
| `AddSection` | `Void` | `Double station, Point[] line, List<Double> smashPoints` | `` |
| `AddSection` | `Void` | `Double station, CrsRedLine redLine, List<Double> smashPoints` | `` |
| `CreateBridgeBase` | `Void` | `IEnumerable<Surface> surfaces, BridgeBase basis, Double slope, Double sectang, Double lsize, Double rsize, Boolean start` | `` |
| `ResetSection` | `Void` | `` | `` |

#### Nested Types (1)

- `DynamicSurfaceListener` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Direction` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.ProfileVisibleCalculator+Direction` |
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
      - `Topomatic.Alg.Runtime.Tools.ProfileVisibleCalculator+Direction`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BackWard` | `Direction` | Yes | `BackWard` | `` |
| `Forward` | `Direction` | Yes | `Forward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `BackWard` | `1` |

**Underlying Type**: `System.Int32`

### `DynamicSurfaceBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.DynamicSurfaceBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildCrsSurface` | `Boolean` | `Alignment alignment, Surface surface, GapsCollection gaps, Boolean dynamic, Double factor` | `` |

### `DynamicSurfaceListener` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.CrsSurfaceBuilder+DynamicSurfaceListener` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Crs.ICrsBuilderListener` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Error` | `Void` | `String text` | `` |
| `Message` | `Void` | `String text` | `` |
| `Warning` | `Void` | `String text` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HasErrors` | `Boolean` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICrsBuilderListener` | `get_Station` |
| `ICrsBuilderListener` | `set_Station` |
| `ICrsBuilderListener` | `Error` |
| `ICrsBuilderListener` | `Warning` |
| `ICrsBuilderListener` | `Message` |
| `ICrsBuilderListener` | `Clear` |

### `EntitiySoprType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.CompoundLineBuilder+EntitiySoprType` |
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
      - `Topomatic.Alg.Runtime.Tools.CompoundLineBuilder+EntitiySoprType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `NotSopr` | `EntitiySoprType` | Yes | `NotSopr` | `` |
| `SoprBegin` | `EntitiySoprType` | Yes | `SoprBegin` | `` |
| `SoprEnd` | `EntitiySoprType` | Yes | `SoprEnd` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NotSopr` | `0` |
| `SoprBegin` | `1` |
| `SoprEnd` | `2` |

**Underlying Type**: `System.Int32`

### `LineSurfaceBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.LineSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.SurfaceBuilder` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.SurfaceBuilder`
    - `Topomatic.Alg.Runtime.Tools.LineSurfaceBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 stationsCount, Int32 index)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LineWithCodeSurfaceBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.LineWithCodeSurfaceBuilder` |
| **Base Type** | `Topomatic.Alg.Runtime.Tools.LineSurfaceBuilder` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Tools.SurfaceBuilder`
    - `Topomatic.Alg.Runtime.Tools.LineSurfaceBuilder`
      - `Topomatic.Alg.Runtime.Tools.LineWithCodeSurfaceBuilder`

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 code, Int32 stationsCount, Int32 index)`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildLineWithCodeSurface` | `Boolean` | `Alignment alignment, Surface surface, Int32 code, Double from, Double to, Boolean dynamic, Double lstep, Double cstep` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PathListExploder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.PathListExploder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPathListToBlockAsEntities` | `Void` | `IList<IPathItem> pathList, Color color, DwgBlock block` | `` |
| `AddPathListToBlockAsEntitiesDefaultColors` | `Void` | `IList<IPathItem> pathList, DwgBlock block` | `` |
| `ExplodeToEntitySet` | `Void` | `IList<IPathItem> pathList, IList<DwgEntity> entityset` | `` |

### `PrfInfoCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.PrfInfoCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Alg.Runtime.Tools.PrfInfoCursor`

#### Constructors (1)

- `.ctor(IProfile profile, IAlgStationing stationing, CadView cadView, String message, String[] args)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPoint` | `GetPointResult` | `ref Vector3D point` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D pos` | `` |
| `ToString` | `String` | `` | `` |

### `ProfileVisibleCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.ProfileVisibleCalculator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MaxSight` | `Double` | `get/set` | No | `` |
| `ObjectHeight` | `Double` | `get/set` | No | `` |
| `ObjectPosition` | `Vector2D` | `get` | No | `` |
| `SplineGrade` | `Double` | `get` | No | `` |
| `SplinePosition` | `Vector2D` | `get` | No | `` |
| `SplineProfile` | `SplineProfile` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |
| `UserHeight` | `Double` | `get/set` | No | `` |
| `UserPosition` | `Vector2D` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `Direction direction, ref Double distance` | `` |

#### Nested Types (1)

- `Direction` (enum)

### `ProjectProfileByLeadElevationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.ProjectProfileByLeadElevationBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultFlags` | `ProjectNodeFlags` | `get/set` | No | `` |
| `EarthProfile` | `Profile` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `LeadElevation` | `Double` | `get/set` | No | `` |
| `ProjectProfile` | `ProjectProfile` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Step` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `` | `` |

### `RadiusCursor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.RadiusCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.MessageCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Alg.Runtime.Tools.RadiusCursor`

#### Constructors (1)

- `.ctor(Alignment alignment, CadView cadView, String message, String[] args)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetStationAndOffset` | `Boolean` | `ref Double station, ref Double offset` | `` |
| `OnDraw` | `Void` | `DeviceContext dc, Vector3D pos` | `` |
| `ToString` | `String` | `` | `` |

### `RoadStationingConverter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.RoadStationingConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertFromRoadStationing` | `Void` | `List<RoadStationingConverterItem> sourceList, AlgStationing stationing` | `` |
| `ConvertToNewIndex` | `Nullable<Char>` | `Int32 oldIndex` | `` |
| `ConvertToOldIndex` | `Int32` | `Nullable<Char> index` | `` |

#### Nested Types (1)

- `RoadStationingConverterItem` (struct)

### `RoadStationingConverterItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.RoadStationingConverter+RoadStationingConverterItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Runtime.Tools.RoadStationingConverter+RoadStationingConverterItem`

#### Constructors (1)

- `.ctor(Double p1, Double p2, Int32 number, Int32 index)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Index` | `Int32` | No | `` | `` |
| `Number` | `Int32` | No | `` | `` |
| `P1` | `Double` | No | `` | `` |
| `P2` | `Double` | No | `` | `` |

### `RoundTo` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.StraighteningSimplePlanSolver+RoundTo` |
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
      - `Topomatic.Alg.Runtime.Tools.StraighteningSimplePlanSolver+RoundTo`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `d0` | `RoundTo` | Yes | `d0` | `` |
| `d1` | `RoundTo` | Yes | `d1` | `` |
| `d2` | `RoundTo` | Yes | `d2` | `` |
| `None` | `RoundTo` | Yes | `None` | `` |
| `o1` | `RoundTo` | Yes | `o1` | `` |
| `o2` | `RoundTo` | Yes | `o2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `d2` | `1` |
| `d1` | `2` |
| `d0` | `3` |
| `o1` | `4` |
| `o2` | `5` |

**Underlying Type**: `System.Int32`

### `StationingCursor` (class)

**Attributes**: [Obsolete(Message: `Use Topomatic.Cad.View.Hints.PlanStationCursor instead`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.StationingCursor` |
| **Base Type** | `Topomatic.Cad.View.Hints.PlanStationCursor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Hints.CadCursor`
    - `Topomatic.Cad.View.Hints.MessageCursor`
      - `Topomatic.Cad.View.Hints.PlanStationCursor`
        - `Topomatic.Alg.Runtime.Tools.StationingCursor`

#### Constructors (2)

- `.ctor(CompoundLine compoundLine, IStationing stationing, CadView cadView, String message, String[] args)`
- `.ctor(CompoundLine compoundLine, IStationing stationing, CadView cadView, String message, String[] args, Boolean showOffset)`

### `StraighteningCurveSolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.StraighteningCurveSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(IList<Vector2D> rectifiableVectors, PlanLine planLine, Int32 index)`
- `.ctor(IList<Vector2D> rectifiableVectors, PlanLine planLine, Int32 index, Int32 radiusStep)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateDeviation` | `Double` | `List<Double> values, Double middle_value` | `` |

### `StraighteningSimplePlanSolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.StraighteningSimplePlanSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AcceptableAdjustValue` | `Double` | `get/set` | No | `` |
| `L_RoundTo` | `RoundTo` | `get/set` | No | `` |
| `MaximumFractureCount` | `Int32` | `get/set` | No | `` |
| `MinimumCurvePoints` | `Int32` | `get/set` | No | `` |
| `R_RoundTo` | `RoundTo` | `get/set` | No | `` |
| `SurveyFactor` | `Double` | `get/set` | No | `` |
| `UseFractures` | `Boolean` | `get/set` | No | `` |
| `WithoutClothoids` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `IList<Vector2D> rectifiableAlignment, PlanLine planLine` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCurvatureFromRadius` | `Double` | `Double radius` | `` |
| `GetCurvatureFromThreePoints` | `Double` | `Vector2D pos1, Vector2D pos2, Vector2D pos3` | `` |
| `GetRadiusFromCurvature` | `Double` | `Double curvature` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MINIMUM_POINTS_COUNT` | `Int32` | Yes | `2` | `` |

#### Nested Types (1)

- `RoundTo` (enum)

### `SurfaceBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Tools.SurfaceBuilder` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Alignment alignment, Int32 stationsCount, Int32 index)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Index` | `Int32` | `get/set` | No | `` |
| `SurfacePoints` | `List<CodedVector>` | `get` | No | `` |
| `Triangles` | `List<SurfaceTriangle>` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FlushSurface` | `Void` | `Surface surface, IEnumerable<SurfaceBuilder> builders` | `` |

#### Nested Types (1)

- `CodedVector` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |

---
## Namespace: `Topomatic.Alg.Runtime.Volume`

### `VolumeCell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Volume.VolumeCell` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double left, Double right, Nullable<Double> loffset, Nullable<Double> roffset)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Both` | `Double` | `get` | No | `` |
| `Left` | `Double` | `get` | No | `` |
| `LeftOffset` | `Nullable<Double>` | `get` | No | `` |
| `Right` | `Double` | `get` | No | `` |
| `RightOffset` | `Nullable<Double>` | `get` | No | `` |

### `VolumeColumn` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Volume.VolumeColumn` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(Int32 code, String cipher)`
- `.ctor(Int32 code, String cipher, CrsVolumeMode mode)`
- `.ctor(Int32 code, String cipher, CrsVolumeMode mode, Boolean single)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cipher` | `String` | `get` | No | `` |
| `Code` | `Int32` | `get` | No | `` |
| `Mode` | `CrsVolumeMode` | `get` | No | `` |
| `Single` | `Boolean` | `get` | No | `` |

### `VolumeColumns` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Volume.VolumeColumns` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Int32 colCount)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `VolumeColumn` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindIndex` | `Int32` | `VolumeColumn column` | `` |

### `VolumeData` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Volume.VolumeData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Columns` | `VolumeColumns` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `VolumeRow` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Generate` | `Boolean` | `Alignment alg, Boolean useModifiers, Double startSta, Double endSta, Boolean hasOffsets` | `` |
| `Generate` | `Boolean` | `Alignment alg, Boolean useModifiers, Double startSta, Double endSta` | `` |
| `Generate` | `Boolean` | `Alignment alg, Boolean useModifiers` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCipher` | `String` | `SemanticDataSet semantic` | `` |

### `VolumeRow` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Volume.VolumeRow` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double sta, Int32 colCount, Boolean selected)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `VolumeCell` | `get/set` | No | `` |
| `Selected` | `Boolean` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

---
## Namespace: `Topomatic.Alg.Runtime.Wizard`

### `AlgWizardManager` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wizard.AlgWizardManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanAutoFill` | `Boolean` | `get` | No | `` |
| `DefaultMoniker` | `Moniker` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AutoFill` | `Boolean` | `` | `` |
| `CanExecute` | `Boolean` | `` | `` |
| `Execute` | `Boolean` | `String caption` | `` |
| `GetFrame` | `AlgWizardMasterFrame` | `Moniker moniker` | `` |
| `GetMonikers` | `IEnumerable<Moniker>` | `` | `` |

#### Nested Types (1)

- `Moniker` (class)

### `AlgWizardMasterFrame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wizard.AlgWizardMasterFrame` |
| **Base Type** | `System.Windows.Forms.UserControl` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.UserControl`
              - `Topomatic.Alg.Runtime.Wizard.AlgWizardMasterFrame`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanDisposeOnClear` | `Boolean` | `` | `` |
| `IsModified` | `Boolean` | `` | `` |
| `OnBeforeAutoFill` | `Void` | `AlgWizardManager manager` | `` |
| `OnFinitalize` | `Boolean` | `AlgWizardManager manager` | `` |
| `OnInitialize` | `Void` | `AlgWizardManager manager` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Moniker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wizard.AlgWizardManager+Moniker` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String menuText, String frameText, String groupText)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FrameText` | `String` | `get` | No | `` |
| `GroupText` | `String` | `get` | No | `` |
| `MenuText` | `String` | `get` | No | `` |

### `WizardMasterDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wizard.WizardMasterDlg` |
| **Base Type** | `Topomatic.Controls.Dialogs.SimpleDlg` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip, System.Windows.Forms.IContainerControl` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `System.Windows.Forms.ScrollableControl`
          - `System.Windows.Forms.ContainerControl`
            - `System.Windows.Forms.Form`
              - `Topomatic.Controls.Dialogs.SimpleDlg`
                - `Topomatic.Alg.Runtime.Wizard.WizardMasterDlg`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DoRefresh` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `String caption, AlgWizardManager manager` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `caption` | `Label` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Runtime.Wrappers`

### `AlgKilometresWrapper` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.AlgKilometresWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, Topomatic.ComponentModel.ISupportClipboard, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AlgExtendedKilometres kilometres)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `CanPaste` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Load` | `Void` | `Object obj, StgNode node` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Save` | `Void` | `Object obj, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `ISupportClipboard` | `get_CanCopy` |
| `ISupportClipboard` | `get_CanPaste` |
| `ISupportClipboard` | `Save` |
| `ISupportClipboard` | `Load` |
| `ISupportClipboard` | `get_AliasName` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `AlgStationingWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.AlgStationingWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Runtime.Wrappers.AlgStationingWrapper`

#### Constructors (1)

- `.ctor(AlgStationing stationing)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `CanPaste` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `Load` | `Void` | `Object obj, StgNode node` | `` |
| `Save` | `Void` | `Object obj, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `get_CanCopy` |
| `ISupportClipboard` | `get_CanPaste` |
| `ISupportClipboard` | `Save` |
| `ISupportClipboard` | `Load` |
| `ISupportClipboard` | `get_AliasName` |

### `ExcludedVolumesWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.ExcludedVolumesWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Runtime.Wrappers.ExcludedVolumesWrapper`

#### Constructors (1)

- `.ctor(ExcludedVolumesCollection excludedVolumes, Alignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `ExcludedVolumes` | `ExcludedVolumesCollection` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `GapsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.GapsWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Runtime.Wrappers.GapsWrapper`

#### Constructors (1)

- `.ctor(GapsCollection gaps, Alignment alignment, Boolean hasTransition)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `CanPaste` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `Load` | `Void` | `Object obj, StgNode node` | `` |
| `Save` | `Void` | `Object obj, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `get_CanCopy` |
| `ISupportClipboard` | `get_CanPaste` |
| `ISupportClipboard` | `Save` |
| `ISupportClipboard` | `Load` |
| `ISupportClipboard` | `get_AliasName` |

### `Item` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.TransitionItemsWrapper+Item` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransitions transitions, Int32 index, Boolean use)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `Browsable` |
| `Name` | `String` | `get` | No | `` |
| `Use` | `Boolean` | `get/set` | No | `` |

### `SimpleChangeTrackingWrapper` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsChanged` | `Boolean` | `get/set` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `IChangeTracking` | `get_IsChanged` |
| `IChangeTracking` | `AcceptChanges` |

### `StaticStationingWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.StaticStationingWrapper` |
| **Base Type** | `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator, Topomatic.ComponentModel.ISupportClipboard` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Runtime.Wrappers.SimpleChangeTrackingWrapper`
    - `Topomatic.Alg.Runtime.Wrappers.StaticStationingWrapper`

#### Constructors (1)

- `.ctor(StaticStationing stationing)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliasName` | `String` | `get` | No | `` |
| `CanCopy` | `Boolean` | `get` | No | `` |
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `CanPaste` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `Load` | `Void` | `Object obj, StgNode node` | `` |
| `Save` | `Void` | `Object obj, StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList` | `get_IsReadOnly` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |
| `ISupportClipboard` | `get_CanCopy` |
| `ISupportClipboard` | `get_CanPaste` |
| `ISupportClipboard` | `Save` |
| `ISupportClipboard` | `Load` |
| `ISupportClipboard` | `get_AliasName` |

### `TransitionItemsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Runtime.Wrappers.TransitionItemsWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ITransitions transitions, Dictionary<Int32 Boolean> values)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator` | `` | `` |

#### Nested Types (1)

- `Item` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Runtime.Design`

### `SemanticEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Runtime.Design.SemanticEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Runtime.Design.SemanticEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SemanticEditorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Runtime.Design.SemanticEditorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditorAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyEditorAttribute`
      - `Topomatic.Runtime.Design.SemanticEditorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 213 |
| **Classes** | 149 |
| **Interfaces** | 3 |
| **Enums** | 14 |
| **Structs** | 2 |
| **Abstract Classes** | 28 |
| **Static Classes** | 17 |
| **Total Methods** | 454 |
| **Total Properties** | 348 |
| **Total Fields** | 212 |
| **Total Events** | 0 |
| **Total Constructors** | 174 |
| **Nested Types** | 20 |
| **Extension Methods** | 0 |


