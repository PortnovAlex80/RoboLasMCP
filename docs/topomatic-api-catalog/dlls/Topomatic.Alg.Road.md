# Topomatic.Alg.Road

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Road` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Road.dll` |

---
## Namespace: `Topomatic.Alg.Road`

### `BaseRoadTransition` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.BaseRoadTransition` |
| **Base Type** | `Topomatic.Alg.Prf.Transition` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.Prf.ITransitionContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.Prf.ITransitionViolations` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Prf.Transition`
      - `Topomatic.Alg.Road.BaseRoadTransition`

#### Constructors (1)

- `.ctor(RoadTransitions transitions)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Violations` | `IEnumerable<TransitionViolation>` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckGeometry` | `Void` | `RoadTransitionsRestrictions restrictions, ProjectProfile profile, List<TransitionViolation> violations` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransitionViolations` | `get_Violations` |

### `RoadAlignment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadAlignment` |
| **Base Type** | `Topomatic.Alg.Alignment` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IStationingContainer, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Alignment`
        - `Topomatic.Alg.Road.RoadAlignment`

#### Constructors (1)

- `.ctor(INamedTransactable owner)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alias` | `String` | `get` | No | `` |
| `Category` | `RoadCategory` | `get/set` | No | `` |
| `DynamicProjectSurfaceUseFactor` | `Boolean` | `get/set` | No | `` |
| `DynamicProjectSurfaceUserFactorValue` | `Double` | `get/set` | No | `` |
| `DynamicSurface` | `Boolean` | `get/set` | No | `` |
| `DynamicSurfaceFactor` | `RoadDynamicSurfaceFactor` | `get/set` | No | `` |
| `DynamicSurfaceGaps` | `GapsCollection` | `get` | No | `` |
| `DynamicSurfaceType` | `RoadDynamicSurfaceType` | `get/set` | No | `` |
| `EdgeTrays` | `EdgeTrays` | `get` | No | `` |
| `ExistingRoadBedCorrection` | `ExistingRoadBedCorrection` | `get` | No | `` |
| `GrassCorrection` | `GrassCorrection` | `get` | No | `` |
| `Intensities` | `IntensitiesCollection` | `get` | No | `` |
| `LeftDitchBankCorrection` | `DitchBankCorrection` | `get` | No | `` |
| `LeftSlopeLoosening` | `SlopeLoosening` | `get` | No | `` |
| `ReconstructionCorrection` | `ReconstructionCorrection` | `get` | No | `` |
| `RenewCorrection` | `RenewCorrection` | `get` | No | `` |
| `RightDitchBankCorrection` | `DitchBankCorrection` | `get` | No | `` |
| `RightSlopeLoosening` | `SlopeLoosening` | `get` | No | `` |
| `RoadSideCorrection` | `RoadSideCorrection` | `get` | No | `` |
| `SlopeBankCorrection` | `SlopeBankCorrection` | `get` | No | `` |
| `Style` | `RoadAlignmentStyle` | `get` | No | `` |
| `SurfaceVolumes` | `IList<RoadSurfaceVolume>` | `get` | No | `` |
| `TelescopicTrays` | `TelescopicTrays` | `get` | No | `` |
| `Urb` | `UrbParams` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RoadAlignmentExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadAlignmentExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DynamicSurfaceFactorValue` | `Double` | `RoadAlignment alignment` | `Extension` |
| `GetGrade` | `Boolean` | `RoadAlignment alignment, Double station, GradePosition position, Boolean ignoreOptions, ref Double value` | `Extension` |
| `GetParam` | `Boolean` | `RoadAlignment alignment, Double station, ParamPosition position, ref Double value` | `Extension` |
| `GetWidthAndElevation` | `Boolean` | `RoadAlignment alignment, Double station, Int32 category1, Int32 category2, ref Double width, ref Double elevation` | `Extension` |
| `GetWidthAndElevation` | `Boolean` | `RoadAlignment alignment, Double station, StripPosition position, ref Double width, ref Double elevation` | `Extension` |
| `RefreshSections` | `Void` | `RoadAlignment alignment, List<MaskedStation> maskedStations, Int32[] usedFlags, Double from, Double to, Boolean interpolate, Boolean mark` | `Extension` |
| `SectUrbParams` | `Void` | `RoadAlignment alignment, Double from, Double to, Double offset, Int32 category, Line2D line, ref List<Vector2D> crossPositions` | `Extension` |
| `SectUrbParams` | `Void` | `RoadAlignment alignment, Double offset, Int32 category, Line2D line, ref List<Vector2D> crossPositions` | `Extension` |

### `RoadCategory` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadCategory` |
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
      - `Topomatic.Alg.Road.RoadCategory`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `I_a` | `RoadCategory` | Yes | `I_a` | `` |
| `I_b` | `RoadCategory` | Yes | `I_b` | `` |
| `I_v` | `RoadCategory` | Yes | `I_v` | `` |
| `II` | `RoadCategory` | Yes | `II` | `` |
| `III` | `RoadCategory` | Yes | `III` | `` |
| `IV` | `RoadCategory` | Yes | `IV` | `` |
| `None` | `RoadCategory` | Yes | `None` | `` |
| `V` | `RoadCategory` | Yes | `V` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `I_a` | `1` |
| `I_b` | `2` |
| `II` | `3` |
| `III` | `4` |
| `IV` | `5` |
| `V` | `6` |
| `I_v` | `7` |

**Underlying Type**: `System.Int32`

### `RoadConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (252)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AXIS_SAND` | `Int32` | Yes | `255` | `` |
| `AXIS_TOP_SAND` | `Int32` | Yes | `254` | `` |
| `BANK_LEFT_SIDE_BANK_HEIGHT` | `String` | Yes | `"BANK_LEFT_SIDE_BANK_HEIGHT"` | `` |
| `BANK_LEFT_SIDE_BANK_LENGTH` | `String` | Yes | `"BANK_LEFT_SIDE_BANK_LENGTH"` | `` |
| `BANK_LEFT_SIDE_BANK_LENGTH_TYPE` | `String` | Yes | `"BANK_LEFT_SIDE_BANK_LENGTH_TYPE"` | `` |
| `BANK_LEFT_SIDE_STRONG_BANK_HEIGHT` | `String` | Yes | `"BANK_LEFT_SIDE_STRONG_BANK_HEIGHT"` | `` |
| `BANK_LEFT_SLOPE_DITCH_DEPTH` | `String` | Yes | `"BANK_LEFT_SLOPE_DITCH_DEPTH"` | `` |
| `BANK_LEFT_SLOPE_DITCH_HEIGHT_BOTTOM` | `String` | Yes | `"BANK_LEFT_SLOPE_DITCH_HEIGHT_BOTTOM"` | `` |
| `BANK_LEFT_SLOPE_DITCH_HEIGHT_SLOPE` | `String` | Yes | `"BANK_LEFT_SLOPE_DITCH_HEIGHT_SLOPE"` | `` |
| `BANK_LEFT_SLOPE_FILL_DEPTH` | `String` | Yes | `"BANK_LEFT_SLOPE_FILL_DEPTH"` | `` |
| `BANK_LEFT_SLOPE_FILL_ELEVATION` | `String` | Yes | `"BANK_LEFT_SLOPE_FILL_ELEVATION"` | `` |
| `BANK_LEFT_SLOPE_FILL_HEIGHT_BOTTOM` | `String` | Yes | `"BANK_LEFT_SLOPE_FILL_HEIGHT_BOTTOM"` | `` |
| `BANK_LEFT_SLOPE_FILL_HEIGHT_TOP` | `String` | Yes | `"BANK_LEFT_SLOPE_FILL_HEIGHT_TOP"` | `` |
| `BANK_LEFT_SLOPE_FILL_TYPE` | `String` | Yes | `"BANK_LEFT_SLOPE_FILL_TYPE"` | `` |
| `BANK_RIGHT_SIDE_BANK_HEIGHT` | `String` | Yes | `"BANK_RIGHT_SIDE_BANK_HEIGHT"` | `` |
| `BANK_RIGHT_SIDE_BANK_LENGTH` | `String` | Yes | `"BANK_RIGHT_SIDE_BANK_LENGTH"` | `` |
| `BANK_RIGHT_SIDE_BANK_LENGTH_TYPE` | `String` | Yes | `"BANK_RIGHT_SIDE_BANK_LENGTH_TYPE"` | `` |
| `BANK_RIGHT_SIDE_STRONG_BANK_HEIGHT` | `String` | Yes | `"BANK_RIGHT_SIDE_STRONG_BANK_HEIGHT"` | `` |
| `BANK_RIGHT_SLOPE_DITCH_DEPTH` | `String` | Yes | `"BANK_RIGHT_SLOPE_DITCH_DEPTH"` | `` |
| `BANK_RIGHT_SLOPE_DITCH_HEIGHT_BOTTOM` | `String` | Yes | `"BANK_RIGHT_SLOPE_DITCH_HEIGHT_BOTTOM"` | `` |
| `BANK_RIGHT_SLOPE_DITCH_HEIGHT_SLOPE` | `String` | Yes | `"BANK_RIGHT_SLOPE_DITCH_HEIGHT_SLOPE"` | `` |
| `BANK_RIGHT_SLOPE_FILL_DEPTH` | `String` | Yes | `"BANK_RIGHT_SLOPE_FILL_DEPTH"` | `` |
| `BANK_RIGHT_SLOPE_FILL_ELEVATION` | `String` | Yes | `"BANK_RIGHT_SLOPE_FILL_ELEVATION"` | `` |
| `BANK_RIGHT_SLOPE_FILL_HEIGHT_BOTTOM` | `String` | Yes | `"BANK_RIGHT_SLOPE_FILL_HEIGHT_BOTTOM"` | `` |
| `BANK_RIGHT_SLOPE_FILL_HEIGHT_TOP` | `String` | Yes | `"BANK_RIGHT_SLOPE_FILL_HEIGHT_TOP"` | `` |
| `BANK_RIGHT_SLOPE_FILL_TYPE` | `String` | Yes | `"BANK_RIGHT_SLOPE_FILL_TYPE"` | `` |
| `BLACK_CENTER_LINE` | `Int32` | Yes | `5` | `` |
| `BLACK_IN_EDGE` | `Int32` | Yes | `4` | `` |
| `BLACK_OUT_EDGE` | `Int32` | Yes | `3` | `` |
| `CENTER_LINE` | `Int32` | Yes | `257` | `` |
| `DIVIDER_AVAILABILITY` | `String` | Yes | `"DIVIDER_AVAILABILITY"` | `` |
| `DIVIDER_AVAILABLE` | `Int32` | Yes | `1` | `` |
| `DIVIDER_NOT_AVAILABLE` | `Int32` | Yes | `0` | `` |
| `EXISTING_ROADBED_CORRECTION_CONSTRUCTION_HEIGHT` | `String` | Yes | `"EXISTING_ROADBED_CORRECTION_CONSTRUCTION_HEIGHT"` | `` |
| `EXISTING_ROADBED_CORRECTION_CUT_HEIGHT` | `String` | Yes | `"EXISTING_ROADBED_CORRECTION_CUT_HEIGHT"` | `` |
| `GRASS_CORRECTION_FOOT_CODE` | `String` | Yes | `"GRASS_CORRECTION_FOOT_CODE"` | `` |
| `GRASS_CORRECTION_SLOPE_CODE` | `String` | Yes | `"GRASS_CORRECTION_SLOPE_CODE"` | `` |
| `GRASS_CORRECTION_SLOPE_THICKNESS` | `String` | Yes | `"GRASS_CORRECTION_SLOPE_THICKNESS"` | `` |
| `GRASS_CORRECTION_SOIL_THICKNESS` | `String` | Yes | `"GRASS_CORRECTION_SOIL_THICKNESS"` | `` |
| `GRASS_CORRECTION_TYPE` | `String` | Yes | `"GRASS_CORRECTION_TYPE"` | `` |
| `LEFT_1_STRIP` | `Int32` | Yes | `310` | `` |
| `LEFT_2_STRIP` | `Int32` | Yes | `312` | `` |
| `LEFT_3_STRIP` | `Int32` | Yes | `314` | `` |
| `LEFT_4_STRIP` | `Int32` | Yes | `316` | `` |
| `LEFT_5_STRIP` | `Int32` | Yes | `318` | `` |
| `LEFT_BROADENING_AXIS_SAND` | `Int32` | Yes | `248` | `` |
| `LEFT_BUS_POCKET_ELEVATION` | `String` | Yes | `"LEFT_BUS_POCKET_ELEVATION"` | `` |
| `LEFT_BUS_POCKET_WIDTH` | `String` | Yes | `"LEFT_BUS_POCKET_WIDTH"` | `` |
| `LEFT_CATCH` | `Int32` | Yes | `328` | `` |
| `LEFT_DITCH_BOTTOM_END` | `Int32` | Yes | `378` | `` |
| `LEFT_DITCH_BOTTOM_START` | `Int32` | Yes | `376` | `` |
| `LEFT_DITCH_START` | `Int32` | Yes | `374` | `` |
| `LEFT_DIVIDER_EDGE` | `Int32` | Yes | `262` | `` |
| `LEFT_DIVIDER_EDGE_WITH_BORDER` | `Int32` | Yes | `324` | `` |
| `LEFT_FORCE_DIV_ELEVATION` | `String` | Yes | `"LEFT_FORCE_DIV_ELEVATION"` | `` |
| `LEFT_FORCE_DIV_WIDTH` | `String` | Yes | `"LEFT_FORCE_DIV_WIDTH"` | `` |
| `LEFT_HAS_EXCLUDED` | `String` | Yes | `"LEFT_HAS_EXCLUDED"` | `` |
| `LEFT_HAS_HOLE` | `String` | Yes | `"LEFT_HAS_HOLE"` | `` |
| `LEFT_HAS_MANUAL_OFFSET` | `String` | Yes | `"LEFT_HAS_MANUAL_OFFSET"` | `` |
| `LEFT_HAS_SECTION_HOLE` | `String` | Yes | `"LEFT_HAS_SECTION_HOLE"` | `` |
| `LEFT_IN_EDGE` | `Int32` | Yes | `260` | `` |
| `LEFT_IN_EDGE_WITHOUT_BORDER` | `Int32` | Yes | `320` | `` |
| `LEFT_MANUAL_OFFSET` | `String` | Yes | `"LEFT_MANUAL_OFFSET"` | `` |
| `LEFT_OUT_EDGE` | `Int32` | Yes | `258` | `` |
| `LEFT_PSP_ELEVATION` | `String` | Yes | `"LEFT_PSP_ELEVATION"` | `` |
| `LEFT_PSP_OFFSET` | `String` | Yes | `"LEFT_PSP_OFFSET"` | `` |
| `LEFT_PSP_WIDTH` | `String` | Yes | `"LEFT_PSP_WIDTH"` | `` |
| `LEFT_SAND` | `Int32` | Yes | `268` | `` |
| `LEFT_SIDE1_ELEVATION` | `String` | Yes | `"LEFT_SIDE1_ELEVATION"` | `` |
| `LEFT_SIDE1_WIDTH` | `String` | Yes | `"LEFT_SIDE1_WIDTH"` | `` |
| `LEFT_SIDE2_ELEVATION` | `String` | Yes | `"LEFT_SIDE2_ELEVATION"` | `` |
| `LEFT_SIDE2_WIDTH` | `String` | Yes | `"LEFT_SIDE2_WIDTH"` | `` |
| `LEFT_SLOPE_DITCH_CUT_CONTOUR` | `String` | Yes | `"LeftSlopeDitchCutSlopeContour"` | `` |
| `LEFT_SLOPE_END` | `Int32` | Yes | `396` | `` |
| `LEFT_SLOPE_FILL_CONTOUR` | `String` | Yes | `"LeftSlopeFillContour"` | `` |
| `LEFT_SLOPE_LOOSENING_CODE1` | `String` | Yes | `"LEFT_SLOPE_LOOSENING_CODE1"` | `` |
| `LEFT_SLOPE_LOOSENING_CODE2` | `String` | Yes | `"LEFT_SLOPE_LOOSENING_CODE2"` | `` |
| `LEFT_SLOPE_LOOSENING_CODE3` | `String` | Yes | `"LEFT_SLOPE_LOOSENING_CODE3"` | `` |
| `LEFT_SLOPE_START` | `Int32` | Yes | `394` | `` |
| `LEFT_STRONG_SAND` | `Int32` | Yes | `272` | `` |
| `LEFT_STRONG_SIDE` | `Int32` | Yes | `322` | `` |
| `LEFT_STRONG_SIDE_WITHOUT_BORDER` | `Int32` | Yes | `326` | `` |
| `LEFT_TOP_AXIS_SAND` | `Int32` | Yes | `250` | `` |
| `LEFT_TOP_SAND` | `Int32` | Yes | `266` | `` |
| `LEFT_TOP_STRONG_SAND` | `Int32` | Yes | `274` | `` |
| `LEFT_WORK_SAND` | `Int32` | Yes | `270` | `` |
| `LIB_PREFIX_BUS_STOPS` | `String` | Yes | `"busstops"` | `` |
| `LIB_PREFIX_DESCENTS` | `String` | Yes | `"descents"` | `` |
| `LIB_PREFIX_INTERSECTIONS` | `String` | Yes | `"intersections"` | `` |
| `LIB_PREFIX_MULTI_LEVEL_DESCENTS` | `String` | Yes | `"multi_level_descents"` | `` |
| `LIB_PREFIX_REVERSAL_AREA` | `String` | Yes | `"reversalarea"` | `` |
| `LIB_PREFIX_SLOPES` | `String` | Yes | `"slopes"` | `` |
| `RECONSTRUCTION_CORRECTION_BORDER_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_BORDER_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_BORDER_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_BORDER_RIGHT"` | `` |
| `RECONSTRUCTION_CORRECTION_BORDER_VALUE_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_BORDER_VALUE_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_BORDER_VALUE_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_BORDER_VALUE_RIGHT"` | `` |
| `RECONSTRUCTION_CORRECTION_EDGE_OFFSET_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_EDGE_OFFSET_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_EDGE_OFFSET_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_EDGE_OFFSET_RIGHT"` | `` |
| `RECONSTRUCTION_CORRECTION_MIN_TRENCH_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_MIN_TRENCH_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_MIN_TRENCH_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_MIN_TRENCH_RIGHT"` | `` |
| `RECONSTRUCTION_CORRECTION_TYPE_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_TYPE_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_TYPE_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_TYPE_RIGHT"` | `` |
| `RECONSTRUCTION_CORRECTION_UNDERCUT_LEFT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_UNDERCUT_LEFT"` | `` |
| `RECONSTRUCTION_CORRECTION_UNDERCUT_RIGHT` | `String` | Yes | `"RECONSTRUCTION_CORRECTION_UNDERCUT_RIGHT"` | `` |
| `RENEW_CORRECTION_ITEM` | `String` | Yes | `"RENEW_CORRECTION_ITEM"` | `` |
| `RIGHT_1_STRIP` | `Int32` | Yes | `311` | `` |
| `RIGHT_2_STRIP` | `Int32` | Yes | `313` | `` |
| `RIGHT_3_STRIP` | `Int32` | Yes | `315` | `` |
| `RIGHT_4_STRIP` | `Int32` | Yes | `317` | `` |
| `RIGHT_5_STRIP` | `Int32` | Yes | `319` | `` |
| `RIGHT_BROADENING_AXIS_SAND` | `Int32` | Yes | `249` | `` |
| `RIGHT_BUS_POCKET_ELEVATION` | `String` | Yes | `"RIGHT_BUS_POCKET_ELEVATION"` | `` |
| `RIGHT_BUS_POCKET_WIDTH` | `String` | Yes | `"RIGHT_BUS_POCKET_WIDTH"` | `` |
| `RIGHT_CATCH` | `Int32` | Yes | `329` | `` |
| `RIGHT_DITCH_BOTTOM_END` | `Int32` | Yes | `379` | `` |
| `RIGHT_DITCH_BOTTOM_START` | `Int32` | Yes | `377` | `` |
| `RIGHT_DITCH_START` | `Int32` | Yes | `375` | `` |
| `RIGHT_DIVIDER_EDGE` | `Int32` | Yes | `263` | `` |
| `RIGHT_DIVIDER_EDGE_WITH_BORDER` | `Int32` | Yes | `325` | `` |
| `RIGHT_FORCE_DIV_ELEVATION` | `String` | Yes | `"RIGHT_FORCE_DIV_ELEVATION"` | `` |
| `RIGHT_FORCE_DIV_WIDTH` | `String` | Yes | `"RIGHT_FORCE_DIV_WIDTH"` | `` |
| `RIGHT_HAS_EXCLUDED` | `String` | Yes | `"RIGHT_HAS_EXCLUDED"` | `` |
| `RIGHT_HAS_HOLE` | `String` | Yes | `"RIGHT_HAS_HOLE"` | `` |
| `RIGHT_HAS_MANUAL_OFFSET` | `String` | Yes | `"RIGHT_HAS_MANUAL_OFFSET"` | `` |
| `RIGHT_HAS_SECTION_HOLE` | `String` | Yes | `"RIGHT_HAS_SECTION_HOLE"` | `` |
| `RIGHT_IN_EDGE` | `Int32` | Yes | `261` | `` |
| `RIGHT_IN_EDGE_WITHOUT_BORDER` | `Int32` | Yes | `321` | `` |
| `RIGHT_MANUAL_OFFSET` | `String` | Yes | `"RIGHT_MANUAL_OFFSET"` | `` |
| `RIGHT_OUT_EDGE` | `Int32` | Yes | `259` | `` |
| `RIGHT_PSP_ELEVATION` | `String` | Yes | `"RIGHT_PSP_ELEVATION"` | `` |
| `RIGHT_PSP_OFFSET` | `String` | Yes | `"RIGHT_PSP_OFFSET"` | `` |
| `RIGHT_PSP_WIDTH` | `String` | Yes | `"RIGHT_PSP_WIDTH"` | `` |
| `RIGHT_SAND` | `Int32` | Yes | `269` | `` |
| `RIGHT_SIDE1_ELEVATION` | `String` | Yes | `"RIGHT_SIDE1_ELEVATION"` | `` |
| `RIGHT_SIDE1_WIDTH` | `String` | Yes | `"RIGHT_SIDE1_WIDTH"` | `` |
| `RIGHT_SIDE2_ELEVATION` | `String` | Yes | `"RIGHT_SIDE2_ELEVATION"` | `` |
| `RIGHT_SIDE2_WIDTH` | `String` | Yes | `"RIGHT_SIDE2_WIDTH"` | `` |
| `RIGHT_SLOPE_DITCH_CUT_CONTOUR` | `String` | Yes | `"RightSlopeDitchCutSlopeContour"` | `` |
| `RIGHT_SLOPE_END` | `Int32` | Yes | `397` | `` |
| `RIGHT_SLOPE_FILL_CONTOUR` | `String` | Yes | `"RightSlopeFillContour"` | `` |
| `RIGHT_SLOPE_LOOSENING_CODE1` | `String` | Yes | `"RIGTH_SLOPE_LOOSENING_CODE1"` | `` |
| `RIGHT_SLOPE_LOOSENING_CODE2` | `String` | Yes | `"RIGTH_SLOPE_LOOSENING_CODE2"` | `` |
| `RIGHT_SLOPE_LOOSENING_CODE3` | `String` | Yes | `"RIGTH_SLOPE_LOOSENING_CODE3"` | `` |
| `RIGHT_SLOPE_START` | `Int32` | Yes | `395` | `` |
| `RIGHT_STRONG_SAND` | `Int32` | Yes | `273` | `` |
| `RIGHT_STRONG_SIDE` | `Int32` | Yes | `323` | `` |
| `RIGHT_STRONG_SIDE_WITHOUT_BORDER` | `Int32` | Yes | `327` | `` |
| `RIGHT_TOP_AXIS_SAND` | `Int32` | Yes | `251` | `` |
| `RIGHT_TOP_SAND` | `Int32` | Yes | `267` | `` |
| `RIGHT_TOP_STRONG_SAND` | `Int32` | Yes | `275` | `` |
| `RIGHT_WORK_SAND` | `Int32` | Yes | `271` | `` |
| `sDefault_1_Category` | `String` | Yes | `"Шаблон для 1 категории"` | `` |
| `sDefault_1_Category_2` | `String` | Yes | `"Шаблон для 1 категории (2 слоя основания)"` | `` |
| `sDefault_1_Category_Archive` | `String` | Yes | `"Шаблон для 1 категории (архив)"` | `` |
| `sDefault_111` | `String` | Yes | `"111"` | `` |
| `sDefault_2_5_Category` | `String` | Yes | `"Шаблон для 2-5 категории"` | `` |
| `sDefault_2_5_Category_2` | `String` | Yes | `"Шаблон для 2-5 категории (2 слоя основания)"` | `` |
| `sDefault_2_5_Category_3` | `String` | Yes | `"Шаблон для 2-5 категории (корытного типа)"` | `` |
| `sDefault_2_5_Category_4` | `String` | Yes | `"Шаблон для 2-5 категории (толщина ППС от существующих кромок при уширении)"` | `` |
| `sDefault_2_5_Category_Archive` | `String` | Yes | `"Шаблон для 2-5 категории (архив)"` | `` |
| `sDefault_222` | `String` | Yes | `"222"` | `` |
| `sDefault_left_crossing` | `String` | Yes | `"Шаблон для пересечения слева от главной"` | `` |
| `sDefault_mp` | `String` | Yes | `"Выравнивание покрытия"` | `` |
| `sDefault_right_crossing` | `String` | Yes | `"Шаблон для пересечения справа от главной"` | `` |
| `sDefault_sickle_shaped` | `String` | Yes | `"Шаблон серповидного профиля"` | `` |
| `SECTION_AUTO_FIT_CORRECTION_DEFAULT` | `Int32` | Yes | `65280` | `` |
| `SECTION_AUTO_FIT_CORRECTION_EXISTINGROADBED` | `Int32` | Yes | `16384` | `` |
| `SECTION_AUTO_FIT_CORRECTION_GRASS` | `Int32` | Yes | `256` | `` |
| `SECTION_AUTO_FIT_CORRECTION_LEFTDITCHBANK` | `Int32` | Yes | `1024` | `` |
| `SECTION_AUTO_FIT_CORRECTION_LEFTSLOPELOOSENING` | `Int32` | Yes | `24576` | `` |
| `SECTION_AUTO_FIT_CORRECTION_RECONSTRUCTION` | `Int32` | Yes | `8192` | `` |
| `SECTION_AUTO_FIT_CORRECTION_RIGHTDITCHBANK` | `Int32` | Yes | `2048` | `` |
| `SECTION_AUTO_FIT_CORRECTION_RIGHTSLOPELOOSENING` | `Int32` | Yes | `32768` | `` |
| `SECTION_AUTO_FIT_CORRECTION_ROADSIDE` | `Int32` | Yes | `4096` | `` |
| `SECTION_AUTO_FIT_CORRECTION_SLOPEBANK` | `Int32` | Yes | `512` | `` |
| `SECTION_AUTO_FIT_EMPTY` | `Int32` | Yes | `0` | `` |
| `SECTION_AUTO_FIT_PROFILE` | `Int32` | Yes | `65536` | `` |
| `SECTION_AUTO_FIT_TRAYS` | `Int32` | Yes | `131072` | `` |
| `SECTION_AUTO_FIT_URB_BORDERS` | `Int32` | Yes | `262144` | `` |
| `SECTION_AUTO_FIT_URB_BUSSTOPS` | `Int32` | Yes | `8` | `` |
| `SECTION_AUTO_FIT_URB_CONSTRUCTION` | `Int32` | Yes | `64` | `` |
| `SECTION_AUTO_FIT_URB_DEFAULT` | `Int32` | Yes | `786687` | `` |
| `SECTION_AUTO_FIT_URB_INTERSECTION` | `Int32` | Yes | `4` | `` |
| `SECTION_AUTO_FIT_URB_MAIN` | `Int32` | Yes | `1` | `` |
| `SECTION_AUTO_FIT_URB_SIDE` | `Int32` | Yes | `2` | `` |
| `SECTION_AUTO_FIT_URB_TEMPLATE_VARIABLES` | `Int32` | Yes | `524288` | `` |
| `SECTION_AUTO_FIT_URB_TEMPLATES` | `Int32` | Yes | `128` | `` |
| `SECTION_AUTO_FIT_URB_USERSTRIPS` | `Int32` | Yes | `16` | `` |
| `SECTION_AUTO_FIT_URB_VIRAGE` | `Int32` | Yes | `32` | `` |
| `SECTION_AUTOFIT` | `String` | Yes | `"SECTION_AUTOFIT"` | `` |
| `SLOPE_DYNAMIC_LEFT_HK` | `String` | Yes | `"DYNAMIC_LEFT_HK"` | `` |
| `SLOPE_DYNAMIC_RIGHT_HK` | `String` | Yes | `"DYNAMIC_RIGHT_HK"` | `` |
| `SLOPE_FLAG_DEFAULT` | `Int32` | Yes | `0` | `` |
| `SLOPE_FLAG_USE_DITCH_PROFILE` | `Int32` | Yes | `2` | `` |
| `SLOPE_FLAG_USE_INTERPOLATE` | `Int32` | Yes | `1` | `` |
| `SLOPE_FLAG_USE_LAST_POINT_STANDING` | `Int32` | Yes | `4` | `` |
| `SLOPE_FOOT` | `Int32` | Yes | `1` | `` |
| `SLOPE_LEFT_A1` | `String` | Yes | `"LEFT_A1"` | `` |
| `SLOPE_LEFT_A2` | `String` | Yes | `"LEFT_A2"` | `` |
| `SLOPE_LEFT_A3` | `String` | Yes | `"LEFT_A3"` | `` |
| `SLOPE_LEFT_B` | `String` | Yes | `"LEFT_B"` | `` |
| `SLOPE_LEFT_CATCH_POINT` | `String` | Yes | `"LeftSlopeCatchPoint"` | `` |
| `SLOPE_LEFT_FLAGS` | `String` | Yes | `"LEFT_FLAGS"` | `` |
| `SLOPE_LEFT_GA` | `String` | Yes | `"LEFT_GA"` | `` |
| `SLOPE_LEFT_GK` | `String` | Yes | `"LEFT_GK"` | `` |
| `SLOPE_LEFT_GW` | `String` | Yes | `"LEFT_GW"` | `` |
| `SLOPE_LEFT_H1` | `String` | Yes | `"LEFT_H1"` | `` |
| `SLOPE_LEFT_H2` | `String` | Yes | `"LEFT_H2"` | `` |
| `SLOPE_LEFT_H3` | `String` | Yes | `"LEFT_H3"` | `` |
| `SLOPE_LEFT_HK` | `String` | Yes | `"LEFT_HK"` | `` |
| `SLOPE_LEFT_INTERSECTION_COUNT` | `String` | Yes | `"LEFT_INTERSECTION_COUNT"` | `` |
| `SLOPE_LEFT_M1` | `String` | Yes | `"LEFT_M1"` | `` |
| `SLOPE_LEFT_M2` | `String` | Yes | `"LEFT_M2"` | `` |
| `SLOPE_LEFT_M3` | `String` | Yes | `"LEFT_M3"` | `` |
| `SLOPE_LEFT_M4` | `String` | Yes | `"LEFT_M4"` | `` |
| `SLOPE_LEFT_N1` | `String` | Yes | `"LEFT_N1"` | `` |
| `SLOPE_LEFT_N2` | `String` | Yes | `"LEFT_N2"` | `` |
| `SLOPE_LEFT_NUMBER` | `String` | Yes | `"LEFT_NUMBER"` | `` |
| `SLOPE_LEFT_START_POINT` | `String` | Yes | `"LeftSlopeStartPoint"` | `` |
| `SLOPE_LEFT_TYPE` | `String` | Yes | `"LEFT_TYPE"` | `` |
| `SLOPE_LEFT_W` | `String` | Yes | `"LEFT_W"` | `` |
| `SLOPE_NUMBER_DEFAULT` | `Int32` | Yes | `0` | `` |
| `SLOPE_RIGHT_A1` | `String` | Yes | `"RIGHT_A1"` | `` |
| `SLOPE_RIGHT_A2` | `String` | Yes | `"RIGHT_A2"` | `` |
| `SLOPE_RIGHT_A3` | `String` | Yes | `"RIGHT_A3"` | `` |
| `SLOPE_RIGHT_B` | `String` | Yes | `"RIGHT_B"` | `` |
| `SLOPE_RIGHT_CATCH_POINT` | `String` | Yes | `"RightSlopeCatchPoint"` | `` |
| `SLOPE_RIGHT_FLAGS` | `String` | Yes | `"RIGHT_FLAGS"` | `` |
| `SLOPE_RIGHT_GA` | `String` | Yes | `"RIGHT_GA"` | `` |
| `SLOPE_RIGHT_GK` | `String` | Yes | `"RIGHT_GK"` | `` |
| `SLOPE_RIGHT_GW` | `String` | Yes | `"RIGHT_GW"` | `` |
| `SLOPE_RIGHT_H1` | `String` | Yes | `"RIGHT_H1"` | `` |
| `SLOPE_RIGHT_H2` | `String` | Yes | `"RIGHT_H2"` | `` |
| `SLOPE_RIGHT_H3` | `String` | Yes | `"RIGHT_H3"` | `` |
| `SLOPE_RIGHT_HK` | `String` | Yes | `"RIGHT_HK"` | `` |
| `SLOPE_RIGHT_INTERSECTION_COUNT` | `String` | Yes | `"RIGHT_INTERSECTION_COUNT"` | `` |
| `SLOPE_RIGHT_M1` | `String` | Yes | `"RIGHT_M1"` | `` |
| `SLOPE_RIGHT_M2` | `String` | Yes | `"RIGHT_M2"` | `` |
| `SLOPE_RIGHT_M3` | `String` | Yes | `"RIGHT_M3"` | `` |
| `SLOPE_RIGHT_M4` | `String` | Yes | `"RIGHT_M4"` | `` |
| `SLOPE_RIGHT_N1` | `String` | Yes | `"RIGHT_N1"` | `` |
| `SLOPE_RIGHT_N2` | `String` | Yes | `"RIGHT_N2"` | `` |
| `SLOPE_RIGHT_NUMBER` | `String` | Yes | `"RIGHT_NUMBER"` | `` |
| `SLOPE_RIGHT_START_POINT` | `String` | Yes | `"RightSlopeStartPoint"` | `` |
| `SLOPE_RIGHT_TYPE` | `String` | Yes | `"RIGHT_TYPE"` | `` |
| `SLOPE_RIGHT_W` | `String` | Yes | `"RIGHT_W"` | `` |
| `SLOPE_TYPE_AUTO` | `Int32` | Yes | `0` | `` |
| `SLOPE_TYPE_CUT` | `Int32` | Yes | `2` | `` |
| `SLOPE_TYPE_DITCH` | `Int32` | Yes | `3` | `` |
| `SLOPE_TYPE_FILL` | `Int32` | Yes | `1` | `` |
| `SLOPE_TYPE_NONE` | `Int32` | Yes | `4` | `` |
| `START_POINT_FOR_513_CONTOUR` | `Int32` | Yes | `200` | `` |

### `RoadDynamicSurfaceFactor` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadDynamicSurfaceFactor` |
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
      - `Topomatic.Alg.Road.RoadDynamicSurfaceFactor`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Hard` | `RoadDynamicSurfaceFactor` | Yes | `Hard` | `` |
| `Light` | `RoadDynamicSurfaceFactor` | Yes | `Light` | `` |
| `Medium` | `RoadDynamicSurfaceFactor` | Yes | `Medium` | `` |
| `User` | `RoadDynamicSurfaceFactor` | Yes | `User` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Light` | `0` |
| `Medium` | `1` |
| `Hard` | `2` |
| `User` | `3` |

**Underlying Type**: `System.Int32`

### `RoadDynamicSurfaceType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadDynamicSurfaceType` |
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
      - `Topomatic.Alg.Road.RoadDynamicSurfaceType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Crs` | `RoadDynamicSurfaceType` | Yes | `Crs` | `` |
| `Urb` | `RoadDynamicSurfaceType` | Yes | `Urb` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Crs` | `0` |
| `Urb` | `1` |

**Underlying Type**: `System.Int32`

### `RoadTransitions` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.RoadTransitions` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, Topomatic.Alg.Prf.ITransitions, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.RoadTransitions`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Transition` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Restrictions` | `RoadTransitionsRestrictions` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `GetNext` | `Int32` | `Int32 index` | `` |
| `GetPrevious` | `Int32` | `Int32 index` | `` |
| `IndexOf` | `Int32` | `Transition item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RefreshViolations` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (20)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TrasitionsCount` | `Int32` | Yes | `19` | `` |
| `trCL` | `Int32` | Yes | `0` | `` |
| `trL1` | `Int32` | Yes | `1` | `` |
| `trL2` | `Int32` | Yes | `3` | `` |
| `trL3` | `Int32` | Yes | `5` | `` |
| `trL4` | `Int32` | Yes | `7` | `` |
| `trL5` | `Int32` | Yes | `9` | `` |
| `trL6` | `Int32` | Yes | `11` | `` |
| `trL7` | `Int32` | Yes | `13` | `` |
| `trL8` | `Int32` | Yes | `15` | `` |
| `trLD` | `Int32` | Yes | `17` | `` |
| `trR1` | `Int32` | Yes | `2` | `` |
| `trR2` | `Int32` | Yes | `4` | `` |
| `trR3` | `Int32` | Yes | `6` | `` |
| `trR4` | `Int32` | Yes | `8` | `` |
| `trR5` | `Int32` | Yes | `10` | `` |
| `trR6` | `Int32` | Yes | `12` | `` |
| `trR7` | `Int32` | Yes | `14` | `` |
| `trR8` | `Int32` | Yes | `16` | `` |
| `trRD` | `Int32` | Yes | `18` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ITransitions` | `get_Item` |
| `ITransitions` | `Clear` |
| `ITransitions` | `IndexOf` |
| `ITransitions` | `GetPrevious` |
| `ITransitions` | `GetNext` |
| `ITransitions` | `get_Count` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Changed` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.add_Undo` |
| `ITransitions` | `Topomatic.Alg.Prf.ITransitions.remove_Undo` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IAlignmentContainer` | `get_Alignment` |

---
## Namespace: `Topomatic.Alg.Road.Corrections`

### `CorrectionExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.CorrectionExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Join` | `Void` | `SlopeBankCorrection correction, AlignmentJoinType joinType, SlopeBankCorrection first, SlopeBankCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `RoadSideCorrection correction, AlignmentJoinType joinType, RoadSideCorrection first, RoadSideCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `DitchBankCorrection correction, AlignmentJoinType joinType, DitchBankCorrection first, DitchBankCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `RenewCorrection correction, AlignmentJoinType joinType, RenewCorrection first, RenewCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `GrassCorrection correction, AlignmentJoinType joinType, GrassCorrection first, GrassCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `ExistingRoadBedCorrection correction, AlignmentJoinType joinType, ExistingRoadBedCorrection first, ExistingRoadBedCorrection second, Double first_length, Double second_length` | `Extension` |
| `Join` | `Void` | `ReconstructionCorrection correction, AlignmentJoinType joinType, ReconstructionCorrection first, ReconstructionCorrection second, Double first_length, Double second_length` | `Extension` |
| `Split` | `Void` | `ExistingRoadBedCorrection correction, Double station, ExistingRoadBedCorrection before, ExistingRoadBedCorrection after` | `Extension` |
| `Split` | `Void` | `RenewCorrection correction, Double station, RenewCorrection before, RenewCorrection after` | `Extension` |
| `Split` | `Void` | `GrassCorrection correction, Double station, GrassCorrection before, GrassCorrection after` | `Extension` |
| `Split` | `Void` | `SlopeBankCorrection correction, Double station, SlopeBankCorrection before, SlopeBankCorrection after` | `Extension` |
| `Split` | `Void` | `ReconstructionCorrection correction, Double station, ReconstructionCorrection before, ReconstructionCorrection after` | `Extension` |
| `Split` | `Void` | `RoadSideCorrection correction, Double station, RoadSideCorrection before, RoadSideCorrection after` | `Extension` |
| `Split` | `Void` | `DitchBankCorrection correction, Double station, DitchBankCorrection before, DitchBankCorrection after` | `Extension` |

### `CorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.GrassCorrection+CorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.GrassCorrection+CorrectionItem`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CorrectionType` | `GrassCorrectionType` | No | `` | `` |
| `FootCode` | `Int32` | No | `` | `` |
| `SlopeCode` | `Int32` | No | `` | `` |
| `SlopeThickness` | `Double` | No | `` | `` |
| `SoilThickness` | `Double` | No | `` | `` |

### `CorrectionItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrection+CorrectionItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConstructionHeight` | `Double` | No | `` | `` |
| `CutHeight` | `Double` | No | `` | `` |

### `CorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RoadSideCorrection+CorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.RoadSideCorrection+CorrectionItem`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftBankThickness` | `Double` | No | `` | `` |
| `LeftStrongBankThickness` | `Double` | No | `` | `` |
| `RightBankThickness` | `Double` | No | `` | `` |
| `RightStrongBankThickness` | `Double` | No | `` | `` |

### `CorrectionSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.CorrectionSide` |
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
      - `Topomatic.Alg.Road.Corrections.CorrectionSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `CorrectionSide` | Yes | `Left` | `` |
| `Right` | `CorrectionSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

### `DitchBankCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.DitchBankCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.DitchBankCorrection`

#### Constructors (1)

- `.ctor(Object owner, CorrectionSide side)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `DitchBankCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `CorrectionSide` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `DitchBankCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `DitchBankCorrectionItem item` | `` |
| `Contains` | `Boolean` | `Double station` | `` |
| `CopyTo` | `Void` | `DitchBankCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<DitchBankCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `DitchBankCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, DitchBankCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `DitchBankCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref DitchBankCorrectionItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `DitchBankCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.DitchBankCorrectionItem`

#### Constructors (1)

- `.ctor(DitchBankCorrectionItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `DitchBankCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DitchBankCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CorrectionType` | `DitchBankCorrectionType` | No | `` | `` |
| `Depth` | `Double` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `HeightBottom` | `Double` | No | `` | `` |
| `HeightSlope` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `DitchBankCorrectionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.DitchBankCorrectionType` |
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
      - `Topomatic.Alg.Road.Corrections.DitchBankCorrectionType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Concreting` | `DitchBankCorrectionType` | Yes | `Concreting` | `` |
| `Grassing` | `DitchBankCorrectionType` | Yes | `Grassing` | `` |
| `Paving` | `DitchBankCorrectionType` | Yes | `Paving` | `` |
| `RapidFlow` | `DitchBankCorrectionType` | Yes | `RapidFlow` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Grassing` | `0` |
| `Paving` | `1` |
| `Concreting` | `2` |
| `RapidFlow` | `3` |

**Underlying Type**: `System.Int32`

### `ExistingRoadBedCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ExistingRoadBedCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ExistingRoadBedCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ExistingRoadBedCorrectionItem item` | `` |
| `CopyTo` | `Void` | `ExistingRoadBedCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ExistingRoadBedCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `ExistingRoadBedCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, ExistingRoadBedCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ExistingRoadBedCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref CorrectionItem item` | `` |

#### Nested Types (1)

- `CorrectionItem` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ExistingRoadBedCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.ExistingRoadBedCorrectionItem`

#### Constructors (1)

- `.ctor(ExistingRoadBedCorrectionItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ExistingRoadBedCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ExistingRoadBedCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConstructionHeight` | `Double` | No | `` | `` |
| `CutHeight` | `Double` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `GrassCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.GrassCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.GrassCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.GrassCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.GrassCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.GrassCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `GrassCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `GrassCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `GrassCorrectionItem item` | `` |
| `CopyTo` | `Void` | `GrassCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<GrassCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `GrassCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, GrassCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `GrassCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref CorrectionItem item` | `` |

#### Nested Types (1)

- `CorrectionItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `GrassCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.GrassCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.GrassCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.GrassCorrectionItem`

#### Constructors (1)

- `.ctor(GrassCorrectionItem item)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GrassCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `GrassCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CorrectionType` | `GrassCorrectionType` | No | `` | `` |
| `DEFAULT_FOOT` | `Int32` | Yes | `1` | `` |
| `DEFAULT_SLOPE` | `Int32` | Yes | `3` | `` |
| `EndSlopeThickness` | `Double` | No | `` | `` |
| `EndSoilThickness` | `Double` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `FootCode` | `Int32` | No | `` | `` |
| `SlopeCode` | `Int32` | No | `` | `` |
| `StartSlopeThickness` | `Double` | No | `` | `` |
| `StartSoilThickness` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `GrassCorrectionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.GrassCorrectionType` |
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
      - `Topomatic.Alg.Road.Corrections.GrassCorrectionType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dern` | `GrassCorrectionType` | Yes | `Dern` | `` |
| `Torf` | `GrassCorrectionType` | Yes | `Torf` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Dern` | `0` |
| `Torf` | `1` |

**Underlying Type**: `System.Int32`

### `Item` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrection+Item` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IList<IRenewLayer>` | `get` | No | `` |
| `MaxFrez` | `Double` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

### `ReconstructionBorder` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ReconstructionBorder` |
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
      - `Topomatic.Alg.Road.Corrections.ReconstructionBorder`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Existing` | `ReconstructionBorder` | Yes | `Existing` | `` |
| `Project` | `ReconstructionBorder` | Yes | `Project` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Existing` | `0` |
| `Project` | `1` |

**Underlying Type**: `System.Int32`

### `ReconstructionCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ReconstructionCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.ReconstructionCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.ReconstructionCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.ReconstructionCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.ReconstructionCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `ReconstructionCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ReconstructionCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `ReconstructionCorrectionItem item` | `` |
| `CopyTo` | `Void` | `ReconstructionCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<ReconstructionCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `ReconstructionCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, ReconstructionCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `ReconstructionCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref ReconstructionCorrectionItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ReconstructionCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ReconstructionCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.ReconstructionCorrectionItem`

#### Constructors (1)

- `.ctor(ReconstructionCorrectionItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ReconstructionCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ReconstructionCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftBorder` | `ReconstructionBorder` | No | `` | `` |
| `LeftEdgeOffset` | `Double` | No | `` | `` |
| `LeftMinTrench` | `Double` | No | `` | `` |
| `LeftReconstruction` | `ReconstructionCorrectionType` | No | `` | `` |
| `LeftUndercut` | `String` | No | `` | `` |
| `RightBorder` | `ReconstructionBorder` | No | `` | `` |
| `RightEdgeOffset` | `Double` | No | `` | `` |
| `RightMinTrench` | `Double` | No | `` | `` |
| `RightReconstruction` | `ReconstructionCorrectionType` | No | `` | `` |
| `RightUndercut` | `String` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `ReconstructionCorrectionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.ReconstructionCorrectionType` |
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
      - `Topomatic.Alg.Road.Corrections.ReconstructionCorrectionType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Broadening` | `ReconstructionCorrectionType` | Yes | `Broadening` | `` |
| `None` | `ReconstructionCorrectionType` | Yes | `None` | `` |
| `Topup` | `ReconstructionCorrectionType` | Yes | `Topup` | `` |
| `TopupByFill` | `ReconstructionCorrectionType` | Yes | `TopupByFill` | `` |
| `TrenchInside` | `ReconstructionCorrectionType` | Yes | `TrenchInside` | `` |
| `TrenchOutside` | `ReconstructionCorrectionType` | Yes | `TrenchOutside` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Broadening` | `1` |
| `Topup` | `2` |
| `TopupByFill` | `3` |
| `TrenchInside` | `4` |
| `TrenchOutside` | `5` |

**Underlying Type**: `System.Int32`

### `RenewCorrection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RenewCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Layers` | `RenewCorrectionLayers` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Segments` | `RenewCorrectionSegments` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Item item` | `` |

#### Nested Types (1)

- `Item` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `get_Alignment` |

### `RenewCorrectionLayerItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrectionLayerItem` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionLayerItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Crs.Road.IRenewLayer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RenewCorrectionLayerItem`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `LayerType` | `RenewLayerType` | `get/set` | No | `` |
| `MinThick` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Thick` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `RenewCorrectionLayerItem other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEquatable`1` | `Equals` |
| `IRenewLayer` | `get_Name` |
| `IRenewLayer` | `get_Thick` |
| `IRenewLayer` | `get_MinThick` |
| `IRenewLayer` | `get_LayerType` |

### `RenewCorrectionLayers` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrectionLayers` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RenewCorrectionLayers`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `StationItem` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `StationItem` | `Double station` | `` |
| `AddLayer` | `RenewCorrectionLayerItem` | `Double station, RenewCorrectionLayerItem layerItem` | `` |
| `AddLayer` | `RenewCorrectionLayerItem` | `Double station` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref IList<RenewCorrectionLayerItem> layers` | `` |

#### Nested Types (1)

- `StationItem` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IAlignmentContainer` | `get_Alignment` |

### `RenewCorrectionSegmentItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem`

#### Constructors (1)

- `.ctor(RenewCorrectionSegmentItem item)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `RenewCorrectionSegmentItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `RenewCorrectionSegmentItem` | `StgNode stgNode` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `MaxFrez` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `RenewCorrectionSegments` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrectionSegments` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionSegmentItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RenewCorrectionSegments`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `RenewCorrectionSegmentItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `RenewCorrectionSegmentItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `RenewCorrectionSegmentItem item` | `` |
| `CopyTo` | `Void` | `RenewCorrectionSegmentItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<RenewCorrectionSegmentItem>` | `` | `` |
| `IndexOf` | `Int32` | `RenewCorrectionSegmentItem item` | `` |
| `Insert` | `Void` | `Int32 index, RenewCorrectionSegmentItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `RenewCorrectionSegmentItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref RenewCorrectionSegmentItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RoadSideCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RoadSideCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RoadSideCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `RoadSideCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `RoadSideCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `RoadSideCorrectionItem item` | `` |
| `CopyTo` | `Void` | `RoadSideCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<RoadSideCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `RoadSideCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, RoadSideCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `RoadSideCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref CorrectionItem item` | `` |

#### Nested Types (1)

- `CorrectionItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `RoadSideCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.RoadSideCorrectionItem`

#### Constructors (1)

- `.ctor(RoadSideCorrectionItem item)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `RoadSideCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `RoadSideCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `LeftBankThicknessEnd` | `Double` | No | `` | `` |
| `LeftBankThicknessStart` | `Double` | No | `` | `` |
| `LeftStrongBankThicknessEnd` | `Double` | No | `` | `` |
| `LeftStrongBankThicknessStart` | `Double` | No | `` | `` |
| `RightBankThicknessEnd` | `Double` | No | `` | `` |
| `RightBankThicknessStart` | `Double` | No | `` | `` |
| `RightStrongBankThicknessEnd` | `Double` | No | `` | `` |
| `RightStrongBankThicknessStart` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `RoadSideCorrectionLengthType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RoadSideCorrectionLengthType` |
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
      - `Topomatic.Alg.Road.Corrections.RoadSideCorrectionLengthType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bank` | `RoadSideCorrectionLengthType` | Yes | `Bank` | `` |
| `StrongBank` | `RoadSideCorrectionLengthType` | Yes | `StrongBank` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `StrongBank` | `0` |
| `Bank` | `1` |

**Underlying Type**: `System.Int32`

### `SlopeBankCorrection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.SlopeBankCorrection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.SlopeBankCorrection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `SlopeBankCorrectionItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SlopeBankCorrectionItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `SlopeBankCorrectionItem item` | `` |
| `CopyTo` | `Void` | `SlopeBankCorrectionItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<SlopeBankCorrectionItem>` | `` | `` |
| `IndexOf` | `Int32` | `SlopeBankCorrectionItem item` | `` |
| `Insert` | `Void` | `Int32 index, SlopeBankCorrectionItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `SlopeBankCorrectionItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref SlopeBankCorrectionItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `SlopeBankCorrectionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.SlopeBankCorrectionItem`

#### Constructors (1)

- `.ctor(SlopeBankCorrectionItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SlopeBankCorrectionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SlopeBankCorrectionItem` | `StgNode stgNode` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `LeftDepth` | `Double` | No | `` | `` |
| `LeftElevation` | `Double` | No | `` | `` |
| `LeftHeightBottom` | `Double` | No | `` | `` |
| `LeftHeightTop` | `Double` | No | `` | `` |
| `LeftStartType` | `SlopeBankStartType` | No | `` | `` |
| `RightDepth` | `Double` | No | `` | `` |
| `RightElevation` | `Double` | No | `` | `` |
| `RightHeightBottom` | `Double` | No | `` | `` |
| `RightHeightTop` | `Double` | No | `` | `` |
| `RightStartType` | `SlopeBankStartType` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `SlopeBankStartType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.SlopeBankStartType` |
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
      - `Topomatic.Alg.Road.Corrections.SlopeBankStartType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CatchPoint` | `SlopeBankStartType` | Yes | `CatchPoint` | `` |
| `EdgePoint` | `SlopeBankStartType` | Yes | `EdgePoint` | `` |
| `Elevation` | `SlopeBankStartType` | Yes | `Elevation` | `` |
| `SingleSlope` | `SlopeBankStartType` | Yes | `SingleSlope` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `EdgePoint` | `0` |
| `CatchPoint` | `1` |
| `SingleSlope` | `2` |
| `Elevation` | `3` |

**Underlying Type**: `System.Int32`

### `SlopeLoosening` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.SlopeLoosening` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Corrections.SlopeLooseningItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Corrections.SlopeLooseningItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Corrections.SlopeLooseningItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.SlopeLoosening`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `SlopeLooseningItem` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SlopeLooseningItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `SlopeLooseningItem item` | `` |
| `CopyTo` | `Void` | `SlopeLooseningItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<SlopeLooseningItem>` | `` | `` |
| `IndexOf` | `Int32` | `SlopeLooseningItem item` | `` |
| `Insert` | `Void` | `Int32 index, SlopeLooseningItem item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `SlopeLooseningItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref SlopeLooseningItem item` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `IAlignmentContainer` | `get_Alignment` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `SlopeLooseningItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.SlopeLooseningItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Corrections.SlopeLooseningItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Corrections.SlopeLooseningItem`

#### Constructors (1)

- `.ctor(SlopeLooseningItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SlopeLooseningItem other` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SlopeLooseningItem` | `StgNode node` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code1` | `Int32` | No | `` | `` |
| `Code2` | `Int32` | No | `` | `` |
| `Code3` | `Int32` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `StationItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Corrections.RenewCorrectionLayers+StationItem` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Corrections.RenewCorrectionLayers+StationItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Corrections.RenewCorrectionLayers+StationItem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IList<RenewCorrectionLayerItem>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `StationItem other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Alg.Road.Design`

### `BorderMarkStandardValuesEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Design.BorderMarkStandardValuesEditor` |
| **Base Type** | `Topomatic.ComponentModel.Design.StandardValueEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.ComponentModel.Design.StandardValueEditor`
      - `Topomatic.Alg.Road.Design.BorderMarkStandardValuesEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertFromOldValue` | `String` | `Int32 oldValue` | `` |

---
## Namespace: `Topomatic.Alg.Road.Intensities`

### `IntensitiesCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Intensities.IntensitiesCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Intensities.IntensitiesCollection`

#### Constructors (1)

- `.ctor(RoadAlignment alignment)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `RoadAlignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Intensity` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Intensity` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Intensity` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Intensities.Intensity` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Intensities.Intensity, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Intensities.Intensity`

#### Constructors (2)

- `.ctor(IntensitiesCollection owner)`
- `.ctor(IntensitiesCollection owner, Intensity intensity)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CarsPerDay` | `Int32` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `Intensity other` | `` |
| `Equals` | `Boolean` | `Intensity other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Alg.Road.Offsets`

### `BaseRoadOffset` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Offsets.BaseRoadOffset` |
| **Base Type** | `Topomatic.Alg.Offsets.Offset` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Offsets.IOffset, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Offsets.Offset`
        - `Topomatic.Alg.Road.Offsets.BaseRoadOffset`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, OffsetDefinition offsetDefinition, StripPosition stripPosition)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Definition` | `OffsetDefinition` | `get/set` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Stations` | `Double[]` | `get` | No | `` |
| `StripPosition` | `StripPosition` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `MakeEditable` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double firstValue, ref Double lastValue` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_IsReadOnly` |
| `IOffset` | `TryGetValue` |
| `IOffset` | `get_Stations` |
| `IOffset` | `get_IsEmpty` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `OffsetDefinition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Offsets.OffsetDefinition` |
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
      - `Topomatic.Alg.Road.Offsets.OffsetDefinition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Manual` | `OffsetDefinition` | Yes | `Manual` | `` |
| `UrbDefined` | `OffsetDefinition` | Yes | `UrbDefined` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Manual` | `0` |
| `UrbDefined` | `1` |

**Underlying Type**: `System.Int32`

### `RoadOffset` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Offsets.RoadOffset` |
| **Base Type** | `Topomatic.Alg.Road.Offsets.BaseRoadOffset` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Offsets.Offset+OffsetItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Alg.IAlignmentContainer, Topomatic.Alg.Offsets.IOffset, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Offsets.Offset`
        - `Topomatic.Alg.Road.Offsets.BaseRoadOffset`
          - `Topomatic.Alg.Road.Offsets.RoadOffset`

#### Constructors (2)

- `.ctor(Object parent)`
- `.ctor(Object parent, OffsetDefinition offsetDefinition, StripPosition stripPosition)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Road.Restrictions`

### `RoadTransitionsRestrictions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Restrictions.RoadTransitionsRestrictions` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Restrictions.RoadTransitionsRestrictions`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, RoadTransitionsRestrictions restrictions)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CheckDeltaGrade` | `Boolean` | `get/set` | No | `` |
| `CheckGeometry` | `Boolean` | `get/set` | No | `` |
| `CheckMaxGrade` | `Boolean` | `get/set` | No | `` |
| `CheckMaxLineLength` | `Boolean` | `get/set` | No | `` |
| `CheckMinGrade` | `Boolean` | `get/set` | No | `` |
| `CheckMinLength` | `Boolean` | `get/set` | No | `` |
| `CheckRadius` | `Boolean` | `get/set` | No | `` |
| `DeltaGrade` | `Double` | `get/set` | No | `` |
| `InRadius` | `Double` | `get/set` | No | `` |
| `MaxGrade` | `Double` | `get/set` | No | `` |
| `MaxLineLength` | `Double` | `get/set` | No | `` |
| `MinGrade` | `Double` | `get/set` | No | `` |
| `MinInLength` | `Double` | `get/set` | No | `` |
| `MinLineLength` | `Double` | `get/set` | No | `` |
| `MinOutLength` | `Double` | `get/set` | No | `` |
| `OutRadius` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Alg.Road.ServiceClasses`

### `MaskedStation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.ServiceClasses.MaskedStation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.ServiceClasses.MaskedStation`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Mask` | `Int32` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `MaskedStationComparer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.ServiceClasses.MaskedStationComparer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IComparer`1[[Topomatic.Alg.Road.ServiceClasses.MaskedStation, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Comparer` | `MaskedStationComparer` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Compare` | `Int32` | `MaskedStation x, MaskedStation y` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparer`1` | `Compare` |

### `MaskedStationsListWithDuplicated` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.ServiceClasses.MaskedStationsListWithDuplicated` |
| **Base Type** | `Topomatic.Alg.ServiceClasses.SortedDoubleListWithDuplicated` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.ServiceClasses.SortedDoubleListWithDuplicated`
    - `Topomatic.Alg.Road.ServiceClasses.MaskedStationsListWithDuplicated`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `Double station, Int32 flag` | `` |
| `Clear` | `Void` | `` | `` |
| `Convert` | `Void` | `List<MaskedStation> markedStations, Double beforeEps, Double afterEps, Predicate<Double> canSplit` | `` |
| `UnsetDuplicated` | `Void` | `Int32 flags` | `` |

---
## Namespace: `Topomatic.Alg.Road.Style`

### `BordersUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.BordersUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.BordersUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomLeaderString` | `String` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |
| `TopLeaderString` | `String` | `get/set` | No | `` |

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

### `BusStopUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.BusStopUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.BusStopUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ShowNameOnProfileCommunication` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

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

### `DefaultUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.DefaultUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.DefaultUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FortifiedRoadSideUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.FortifiedRoadSideUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.FortifiedRoadSideUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenewStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.RenewStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Road.Style.RenewStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `MaxElevationColor` | `CadColor` | `get/set` | No | `` |
| `MinElevationColor` | `CadColor` | `get/set` | No | `` |
| `TextHeight` | `Single` | `get/set` | No | `` |
| `TypesColor` | `CadColor` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `RenewStyle style` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RoadAlignmentStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.RoadAlignmentStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyle` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Alg.Alignment, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyle`
    - `Topomatic.Alg.Road.Style.RoadAlignmentStyle`

#### Constructors (1)

- `.ctor(RoadAlignment owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BordersStyle` | `BordersUrbStyle` | `get` | No | `` |
| `BusStopStyle` | `BusStopUrbStyle` | `get` | No | `` |
| `DefaultUrbStyle` | `DefaultUrbStyle` | `get` | No | `` |
| `EdgeTraysStyle` | `EdgeTraysStyle` | `get` | No | `` |
| `FortifiedRoadSideUrbStyle` | `FortifiedRoadSideUrbStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `RenewStyle` | `RenewStyle` | `get` | No | `` |
| `RoadwayStyle` | `RoadwayUrbStyle` | `get` | No | `` |
| `TelescopicTraysStyle` | `TelescopicTraysStyle` | `get` | No | `` |
| `UnfortifiedRoadSideUrbStyle` | `UnfortifiedRoadSideUrbStyle` | `get` | No | `` |

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

### `RoadwayUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.RoadwayUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.RoadwayUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UnfortifiedRoadSideUrbStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Style.UnfortifiedRoadSideUrbStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Style.UnfortifiedRoadSideUrbStyle`

#### Constructors (1)

- `.ctor(AlignmentStyle owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `StandardName` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Alg.Road.Trays`

### `EdgeTray` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.EdgeTray` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Trays.EdgeTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Trays.EdgeTray`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, EdgeTray tray)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Direction` | `TrayDirection` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Position` | `TrayPosition` | `get/set` | No | `` |
| `Side` | `TraySide` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `TrayType` | `EdgeTrayType` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `EdgeTray other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `EdgeTrays` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.EdgeTrays` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Trays.EdgeTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Trays.EdgeTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Trays.EdgeTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Trays.EdgeTrays`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `EdgeTray` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `EdgeTray item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `EdgeTray item` | `` |
| `CopyTo` | `Void` | `EdgeTray[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<EdgeTray>` | `` | `` |
| `IndexOf` | `Int32` | `EdgeTray item` | `` |
| `Insert` | `Void` | `Int32 index, EdgeTray item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `EdgeTray item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `EdgeTraysStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.EdgeTraysStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Trays.EdgeTraysStyle`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrowBlockName` | `String` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareDefaultBlocks` | `Void` | `Drawing drawing` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `EdgeTrayType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.EdgeTrayType` |
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
      - `Topomatic.Alg.Road.Trays.EdgeTrayType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `B1` | `EdgeTrayType` | Yes | `B1` | `` |
| `B2` | `EdgeTrayType` | Yes | `B2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `B1` | `0` |
| `B2` | `1` |

**Underlying Type**: `System.Int32`

### `TelescopicTray` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TelescopicTray` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Trays.TelescopicTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Alg.IAlignmentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Trays.TelescopicTray`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, TelescopicTray tray)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `AxisPosition` | `Vector2D` | `get` | No | `` |
| `BottomType` | `TrayBottomType` | `get/set` | No | `` |
| `EndPosition` | `Vector2D` | `get` | No | `` |
| `HeadPosition` | `Vector2D` | `get` | No | `` |
| `HeadType` | `TrayHeadType` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Side` | `TraySide` | `get/set` | No | `` |
| `StartPosition` | `Vector2D` | `get` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `TextOffset` | `Vector2D` | `get/set` | No | `` |
| `TrayType` | `TelescopicTrayType` | `get/set` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |
| `WaterType` | `TelescopicTrayWaterType` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `TelescopicTray other` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePositions` | `Boolean` | `RoadAlignment alignment, TraySide side, Double station, Double offset, Double length, Double rotation, ref Vector2D axis, ref Vector2D head, ref Vector2D start, ref Vector2D end` | `` |
| `GetPrefferableHead` | `TrayHeadType` | `TraySide side, TrayDirection direction` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEquatable`1` | `Equals` |
| `IAlignmentContainer` | `get_Alignment` |

### `TelescopicTrays` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TelescopicTrays` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IList`1[[Topomatic.Alg.Road.Trays.TelescopicTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Trays.TelescopicTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Trays.TelescopicTray, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Trays.TelescopicTrays`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `TelescopicTray` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `TelescopicTray item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `TelescopicTray item` | `` |
| `CopyTo` | `Void` | `TelescopicTray[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<TelescopicTray>` | `` | `` |
| `IndexOf` | `Int32` | `TelescopicTray item` | `` |
| `Insert` | `Void` | `Int32 index, TelescopicTray item` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `TelescopicTray item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `get_IsReadOnly` |
| `ICollection`1` | `Add` |
| `ICollection`1` | `Clear` |
| `ICollection`1` | `Contains` |
| `ICollection`1` | `CopyTo` |
| `ICollection`1` | `Remove` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TelescopicTraysStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TelescopicTraysStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Road.Trays.TelescopicTraysStyle`

#### Constructors (1)

- `.ctor(Object parent)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BodyBlockName` | `String` | `get/set` | No | `` |
| `BottomDissectorBlockName` | `String` | `get/set` | No | `` |
| `BottomQuencherBlockName` | `String` | `get/set` | No | `` |
| `HeadBackwardType1BlockName` | `String` | `get/set` | No | `` |
| `HeadBackwardType2BlockName` | `String` | `get/set` | No | `` |
| `HeadBothType1BlockName` | `String` | `get/set` | No | `` |
| `HeadBothType2BlockName` | `String` | `get/set` | No | `` |
| `HeadForwardType1BlockName` | `String` | `get/set` | No | `` |
| `HeadForwardType2BlockName` | `String` | `get/set` | No | `` |
| `ShowPkText` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |
| `TextStandardName` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PrepareDefaultBlocks` | `Void` | `Drawing drawing` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TelescopicTrayType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TelescopicTrayType` |
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
      - `Topomatic.Alg.Road.Trays.TelescopicTrayType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `B6` | `TelescopicTrayType` | Yes | `B6` | `` |
| `B7` | `TelescopicTrayType` | Yes | `B7` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `B6` | `0` |
| `B7` | `1` |

**Underlying Type**: `System.Int32`

### `TelescopicTrayWaterType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TelescopicTrayWaterType` |
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
      - `Topomatic.Alg.Road.Trays.TelescopicTrayWaterType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Type1` | `TelescopicTrayWaterType` | Yes | `Type1` | `` |
| `Type2` | `TelescopicTrayWaterType` | Yes | `Type2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Type1` | `0` |
| `Type2` | `1` |

**Underlying Type**: `System.Int32`

### `TrayBottomType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TrayBottomType` |
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
      - `Topomatic.Alg.Road.Trays.TrayBottomType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dissector` | `TrayBottomType` | Yes | `Dissector` | `` |
| `None` | `TrayBottomType` | Yes | `None` | `` |
| `Quencher` | `TrayBottomType` | Yes | `Quencher` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Quencher` | `1` |
| `Dissector` | `2` |

**Underlying Type**: `System.Int32`

### `TrayDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TrayDirection` |
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
      - `Topomatic.Alg.Road.Trays.TrayDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `TrayDirection` | Yes | `Backward` | `` |
| `Forward` | `TrayDirection` | Yes | `Forward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `Backward` | `1` |

**Underlying Type**: `System.Int32`

### `TrayHeadType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TrayHeadType` |
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
      - `Topomatic.Alg.Road.Trays.TrayHeadType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `TrayHeadType` | Yes | `Backward` | `` |
| `Both` | `TrayHeadType` | Yes | `Both` | `` |
| `Forward` | `TrayHeadType` | Yes | `Forward` | `` |
| `None` | `TrayHeadType` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Forward` | `1` |
| `Backward` | `2` |
| `Both` | `3` |

**Underlying Type**: `System.Int32`

### `TrayPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TrayPosition` |
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
      - `Topomatic.Alg.Road.Trays.TrayPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InEdge` | `TrayPosition` | Yes | `InEdge` | `` |
| `OutEdge` | `TrayPosition` | Yes | `OutEdge` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InEdge` | `0` |
| `OutEdge` | `1` |

**Underlying Type**: `System.Int32`

### `TraysExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TraysExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Join` | `Void` | `EdgeTrays trays, AlignmentJoinType joinType, EdgeTrays first, EdgeTrays second, Double firstLength, Double secondLength` | `Extension` |
| `Join` | `Void` | `TelescopicTrays trays, AlignmentJoinType joinType, TelescopicTrays first, TelescopicTrays second, Double firstLength, Double secondLength` | `Extension` |
| `Split` | `Void` | `EdgeTrays trays, Double station, EdgeTrays before, EdgeTrays after` | `Extension` |
| `Split` | `Void` | `TelescopicTrays trays, Double station, TelescopicTrays before, TelescopicTrays after` | `Extension` |

### `TraySide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Trays.TraySide` |
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
      - `Topomatic.Alg.Road.Trays.TraySide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `TraySide` | Yes | `Left` | `` |
| `Right` | `TraySide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Road.Urb`

### `ExcludedPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.ExcludedPosition` |
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
      - `Topomatic.Alg.Road.Urb.ExcludedPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `ExcludedPosition` | Yes | `Left` | `` |
| `Right` | `ExcludedPosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

### `ExcludedSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.ExcludedSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.ExcludedSegment`

#### Constructors (1)

- `.ctor(Double startStation, Double endStation)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `StationInside` | `InsideSegmentPosition` | `Double station` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

### `ExcludedSegments` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.ExcludedSegments` |
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
| `Item` | `ExcludedSegment` | `get` | No | `` |
| `SegmentCount` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `HasExcluded` | `InsideSegmentPosition` | `Double station` | `` |
| `RemoveSegment` | `Void` | `Int32 index` | `` |
| `TryAddSegment` | `Boolean` | `Double startStation, Double endStation, ref ExcludedSegment excluded` | `` |

### `GradeOptions` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GradeOptions` |
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
      - `Topomatic.Alg.Road.Urb.GradeOptions`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalcOnlyIfHasWidth` | `GradeOptions` | Yes | `CalcOnlyIfHasWidth` | `` |
| `SimpleCalc` | `GradeOptions` | Yes | `SimpleCalc` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SimpleCalc` | `0` |
| `CalcOnlyIfHasWidth` | `1` |

**Underlying Type**: `System.Int32`

### `GradePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GradePosition` |
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
      - `Topomatic.Alg.Road.Urb.GradePosition`

#### Fields (27)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left1` | `GradePosition` | Yes | `Left1` | `` |
| `Left2` | `GradePosition` | Yes | `Left2` | `` |
| `Left3` | `GradePosition` | Yes | `Left3` | `` |
| `Left4` | `GradePosition` | Yes | `Left4` | `` |
| `Left5` | `GradePosition` | Yes | `Left5` | `` |
| `LeftCenter` | `GradePosition` | Yes | `LeftCenter` | `` |
| `LeftDivider` | `GradePosition` | Yes | `LeftDivider` | `` |
| `LeftDividerBorder` | `GradePosition` | Yes | `LeftDividerBorder` | `` |
| `LeftPsp` | `GradePosition` | Yes | `LeftPsp` | `` |
| `Right1` | `GradePosition` | Yes | `Right1` | `` |
| `Right2` | `GradePosition` | Yes | `Right2` | `` |
| `Right3` | `GradePosition` | Yes | `Right3` | `` |
| `Right4` | `GradePosition` | Yes | `Right4` | `` |
| `Right5` | `GradePosition` | Yes | `Right5` | `` |
| `RightCenter` | `GradePosition` | Yes | `RightCenter` | `` |
| `RightDivider` | `GradePosition` | Yes | `RightDivider` | `` |
| `RightDividerBorder` | `GradePosition` | Yes | `RightDividerBorder` | `` |
| `RightPsp` | `GradePosition` | Yes | `RightPsp` | `` |
| `SandLeft` | `GradePosition` | Yes | `SandLeft` | `` |
| `SandRight` | `GradePosition` | Yes | `SandRight` | `` |
| `SideLeft1` | `GradePosition` | Yes | `SideLeft1` | `` |
| `SideLeft2` | `GradePosition` | Yes | `SideLeft2` | `` |
| `SideLeft3` | `GradePosition` | Yes | `SideLeft3` | `` |
| `SideRight1` | `GradePosition` | Yes | `SideRight1` | `` |
| `SideRight2` | `GradePosition` | Yes | `SideRight2` | `` |
| `SideRight3` | `GradePosition` | Yes | `SideRight3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftCenter` | `0` |
| `LeftDivider` | `1` |
| `LeftDividerBorder` | `2` |
| `Left1` | `3` |
| `Left2` | `4` |
| `Left3` | `5` |
| `Left4` | `6` |
| `Left5` | `7` |
| `LeftPsp` | `8` |
| `SideLeft1` | `9` |
| `SideLeft2` | `10` |
| `SideLeft3` | `11` |
| `SandLeft` | `12` |
| `RightCenter` | `13` |
| `RightDivider` | `14` |
| `RightDividerBorder` | `15` |
| `Right1` | `16` |
| `Right2` | `17` |
| `Right3` | `18` |
| `Right4` | `19` |
| `Right5` | `20` |
| `RightPsp` | `21` |
| `SideRight1` | `22` |
| `SideRight2` | `23` |
| `SideRight3` | `24` |
| `SandRight` | `25` |

**Underlying Type**: `System.Int32`

### `GradePriority` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GradePriority` |
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
      - `Topomatic.Alg.Road.Urb.GradePriority`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BusStop` | `GradePriority` | Yes | `BusStop` | `` |
| `Maximum` | `GradePriority` | Yes | `Maximum` | `` |
| `System` | `GradePriority` | Yes | `System` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Virage` | `GradePriority` | Yes | `Virage` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `System` | `0` |
| `Virage` | `1` |
| `BusStop` | `2` |
| `Maximum` | `3` |

**Underlying Type**: `System.Int32`

### `HolePosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.HolePosition` |
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
      - `Topomatic.Alg.Road.Urb.HolePosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftCenter` | `HolePosition` | Yes | `LeftCenter` | `` |
| `RightCenter` | `HolePosition` | Yes | `RightCenter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftCenter` | `0` |
| `RightCenter` | `1` |

**Underlying Type**: `System.Int32`

### `HoleSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.HoleSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.HoleSegment`

#### Constructors (1)

- `.ctor(Double startStation, Double startOffset, Double endStation, Double endOffset)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `StationInside` | `InsideSegmentPosition` | `Double station` | `` |
| `TryGetOffset` | `InsideSegmentPosition` | `Double station, ref Double offset` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndOffset` | `Double` | No | `` | `` |
| `EndStation` | `Double` | No | `` | `` |
| `StartOffset` | `Double` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

### `HoleSegments` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.HoleSegments` |
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
| `Item` | `HoleSegment` | `get` | No | `` |
| `SegmentCount` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `HasHole` | `InsideSegmentPosition` | `Double station, ref Double first, ref Double last` | `` |
| `RemoveSegment` | `Void` | `Int32 index` | `` |
| `TryAddSegment` | `Boolean` | `Double startStation, Double startOffset, Double endStation, Double endOffset, ref HoleSegment hole` | `` |

### `InsideSegmentPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.InsideSegmentPosition` |
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
      - `Topomatic.Alg.Road.Urb.InsideSegmentPosition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `InsideSegmentPosition` | Yes | `End` | `` |
| `Indside` | `InsideSegmentPosition` | Yes | `Indside` | `` |
| `Outside` | `InsideSegmentPosition` | Yes | `Outside` | `` |
| `Start` | `InsideSegmentPosition` | Yes | `Start` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Outside` | `0` |
| `Indside` | `1` |
| `Start` | `2` |
| `End` | `3` |

**Underlying Type**: `System.Int32`

### `ParamOptions` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.ParamOptions` |
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
      - `Topomatic.Alg.Road.Urb.ParamOptions`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `ParamOptions` | Yes | `None` | `` |
| `Replace` | `ParamOptions` | Yes | `Replace` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Replace` | `1` |

**Underlying Type**: `System.Int32`

### `ParamPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.ParamPosition` |
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
      - `Topomatic.Alg.Road.Urb.ParamPosition`

#### Fields (13)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AsphaltLayerHeight` | `ParamPosition` | Yes | `AsphaltLayerHeight` | `` |
| `CenterLineElevation` | `ParamPosition` | Yes | `CenterLineElevation` | `` |
| `FondationBroadening` | `ParamPosition` | Yes | `FondationBroadening` | `` |
| `LeftBorderSide1Height` | `ParamPosition` | Yes | `LeftBorderSide1Height` | `` |
| `LeftBorderSide2Height` | `ParamPosition` | Yes | `LeftBorderSide2Height` | `` |
| `LeftDividerBorderHeight` | `ParamPosition` | Yes | `LeftDividerBorderHeight` | `` |
| `RightBorderSide1Height` | `ParamPosition` | Yes | `RightBorderSide1Height` | `` |
| `RightBorderSide2Height` | `ParamPosition` | Yes | `RightBorderSide2Height` | `` |
| `RightDividerBorderHeight` | `ParamPosition` | Yes | `RightDividerBorderHeight` | `` |
| `SandLayerHeight` | `ParamPosition` | Yes | `SandLayerHeight` | `` |
| `StoneLayerHeight` | `ParamPosition` | Yes | `StoneLayerHeight` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WorkingLayerHeight` | `ParamPosition` | Yes | `WorkingLayerHeight` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `CenterLineElevation` | `0` |
| `AsphaltLayerHeight` | `1` |
| `StoneLayerHeight` | `2` |
| `SandLayerHeight` | `3` |
| `WorkingLayerHeight` | `4` |
| `LeftBorderSide1Height` | `5` |
| `LeftBorderSide2Height` | `6` |
| `RightBorderSide1Height` | `7` |
| `RightBorderSide2Height` | `8` |
| `LeftDividerBorderHeight` | `9` |
| `RightDividerBorderHeight` | `10` |
| `FondationBroadening` | `11` |

**Underlying Type**: `System.Int32`

### `StripHatch` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.StripHatch` |
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
      - `Topomatic.Alg.Road.Urb.StripHatch`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fill` | `StripHatch` | Yes | `Fill` | `` |
| `None` | `StripHatch` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Fill` | `1` |

**Underlying Type**: `System.Int32`

### `StripPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.StripPosition` |
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
      - `Topomatic.Alg.Road.Urb.StripPosition`

#### Fields (27)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left1` | `StripPosition` | Yes | `Left1` | `` |
| `Left2` | `StripPosition` | Yes | `Left2` | `` |
| `Left3` | `StripPosition` | Yes | `Left3` | `` |
| `Left4` | `StripPosition` | Yes | `Left4` | `` |
| `Left5` | `StripPosition` | Yes | `Left5` | `` |
| `LeftCenter` | `StripPosition` | Yes | `LeftCenter` | `` |
| `LeftDivider` | `StripPosition` | Yes | `LeftDivider` | `` |
| `LeftDividerBorder` | `StripPosition` | Yes | `LeftDividerBorder` | `` |
| `LeftPsp` | `StripPosition` | Yes | `LeftPsp` | `` |
| `LeftPspDivider` | `StripPosition` | Yes | `LeftPspDivider` | `` |
| `Right1` | `StripPosition` | Yes | `Right1` | `` |
| `Right2` | `StripPosition` | Yes | `Right2` | `` |
| `Right3` | `StripPosition` | Yes | `Right3` | `` |
| `Right4` | `StripPosition` | Yes | `Right4` | `` |
| `Right5` | `StripPosition` | Yes | `Right5` | `` |
| `RightCenter` | `StripPosition` | Yes | `RightCenter` | `` |
| `RightDivider` | `StripPosition` | Yes | `RightDivider` | `` |
| `RightDividerBorder` | `StripPosition` | Yes | `RightDividerBorder` | `` |
| `RightPsp` | `StripPosition` | Yes | `RightPsp` | `` |
| `RightPspDivider` | `StripPosition` | Yes | `RightPspDivider` | `` |
| `SideLeft1` | `StripPosition` | Yes | `SideLeft1` | `` |
| `SideLeft2` | `StripPosition` | Yes | `SideLeft2` | `` |
| `SideLeft3` | `StripPosition` | Yes | `SideLeft3` | `` |
| `SideRight1` | `StripPosition` | Yes | `SideRight1` | `` |
| `SideRight2` | `StripPosition` | Yes | `SideRight2` | `` |
| `SideRight3` | `StripPosition` | Yes | `SideRight3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftCenter` | `0` |
| `LeftDivider` | `1` |
| `LeftDividerBorder` | `2` |
| `Left1` | `3` |
| `Left2` | `4` |
| `Left3` | `5` |
| `Left4` | `6` |
| `Left5` | `7` |
| `LeftPspDivider` | `8` |
| `LeftPsp` | `9` |
| `SideLeft1` | `10` |
| `SideLeft2` | `11` |
| `SideLeft3` | `12` |
| `RightCenter` | `13` |
| `RightDivider` | `14` |
| `RightDividerBorder` | `15` |
| `Right1` | `16` |
| `Right2` | `17` |
| `Right3` | `18` |
| `Right4` | `19` |
| `Right5` | `20` |
| `RightPspDivider` | `21` |
| `RightPsp` | `22` |
| `SideRight1` | `23` |
| `SideRight2` | `24` |
| `SideRight3` | `25` |

**Underlying Type**: `System.Int32`

### `StripTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.StripTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BorderPositionToCategory` | `Int32` | `BorderPosition position` | `` |
| `ConvertToPolyLine` | `Void` | `IEnumerable<IPathItem> paths, CompoundLine mainLine, Polyline3D polyline` | `` |
| `EqualVectorPosition` | `Boolean` | `Vector3D pos1, Vector3D pos2` | `` |
| `EqualVectorPosition` | `Boolean` | `Vector2D pos1, Vector2D pos2` | `` |
| `GradePositionToCategory` | `Int32` | `GradePosition position` | `` |
| `GradePriorityToPriority` | `Int32` | `GradePriority priority` | `` |
| `HolePositionToCategory` | `Int32` | `HolePosition position` | `` |
| `ParamPositionToCategory` | `Int32` | `ParamPosition position` | `` |
| `ReversalAreaCalculateCirclePositions` | `Boolean` | `Double distance, Double mainOffset, Double dividerOffset, Double mainRadius, Double dividerRadius, Boolean forward, ref Vector2D mainCenter, ref Vector2D dividerCenter` | `` |
| `SectArcAndPolyline` | `Void` | `Vector3D center, Double radius, Double startAngle, Double endAngle, IPolyline3D poly, IList<Vector3D> result` | `` |
| `SectPolyLine3D` | `Vector3D[]` | `IPolyline3D poly1, IPolyline3D poly2` | `` |
| `SplitArc` | `ArcStruc[]` | `ArcStruc arc, Double minimumLength` | `` |
| `StripPositionToCategory` | `Int32` | `StripPosition position` | `` |
| `ValueBetween` | `Boolean` | `Double val1, Double val2, Double value` | `` |

### `UrbConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (122)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AsphaltLayerHeight` | `Int32` | Yes | `100` | `` |
| `CenterLine` | `Int32` | Yes | `0` | `` |
| `CenterLineCompensationLeft` | `Int32` | Yes | `-5` | `` |
| `CenterLineCompensationRight` | `Int32` | Yes | `5` | `` |
| `CenterLineElevation` | `Int32` | Yes | `0` | `` |
| `DirectIslandLeft` | `Int32` | Yes | `-30` | `` |
| `DirectIslandRight` | `Int32` | Yes | `30` | `` |
| `DividerCompensationLeft` | `Int32` | Yes | `-8` | `` |
| `DividerCompensationRight` | `Int32` | Yes | `8` | `` |
| `FondationBroadening` | `Int32` | Yes | `300` | `` |
| `GradePriorityBusStop` | `Int32` | Yes | `2` | `` |
| `GradePrioritySystem` | `Int32` | Yes | `0` | `` |
| `GradePriorityVirage` | `Int32` | Yes | `1` | `` |
| `LeftBorderSide1Height` | `Int32` | Yes | `200` | `` |
| `LeftBorderSide2Height` | `Int32` | Yes | `204` | `` |
| `LeftCenterLine` | `Int32` | Yes | `-1` | `` |
| `LeftDivider` | `Int32` | Yes | `-10` | `` |
| `LeftDividerBorderHeight` | `Int32` | Yes | `220` | `` |
| `LeftForceDivider` | `Int32` | Yes | `-20` | `` |
| `LeftMainStrip1` | `Int32` | Yes | `-60` | `` |
| `LeftMainStrip2` | `Int32` | Yes | `-70` | `` |
| `LeftMainStrip3` | `Int32` | Yes | `-80` | `` |
| `LeftMainStrip4` | `Int32` | Yes | `-90` | `` |
| `LeftMainStrip5` | `Int32` | Yes | `-100` | `` |
| `LeftMainStripOffset1` | `Int32` | Yes | `-55` | `` |
| `LeftMainStripOffset2` | `Int32` | Yes | `-65` | `` |
| `LeftMainStripOffset3` | `Int32` | Yes | `-75` | `` |
| `LeftMainStripOffset4` | `Int32` | Yes | `-85` | `` |
| `LeftMainStripOffset5` | `Int32` | Yes | `-95` | `` |
| `LeftPocket` | `Int32` | Yes | `-130` | `` |
| `LeftPsp` | `Int32` | Yes | `-120` | `` |
| `LeftPspDivider` | `Int32` | Yes | `-110` | `` |
| `LeftSand` | `Int32` | Yes | `-500` | `` |
| `LeftSide1` | `Int32` | Yes | `-160` | `` |
| `LeftSide2` | `Int32` | Yes | `-215` | `` |
| `LeftSide3` | `Int32` | Yes | `-230` | `` |
| `LeftSideCompensation` | `Int32` | Yes | `-213` | `` |
| `LeftSidePspCompensation` | `Int32` | Yes | `-214` | `` |
| `LeftUserStrip0_1` | `Int32` | Yes | `-51` | `` |
| `LeftUserStrip0_2` | `Int32` | Yes | `-52` | `` |
| `LeftUserStrip0_3` | `Int32` | Yes | `-53` | `` |
| `LeftUserStrip0_4` | `Int32` | Yes | `-54` | `` |
| `LeftUserStrip1_1` | `Int32` | Yes | `-61` | `` |
| `LeftUserStrip1_2` | `Int32` | Yes | `-62` | `` |
| `LeftUserStrip1_3` | `Int32` | Yes | `-63` | `` |
| `LeftUserStrip1_4` | `Int32` | Yes | `-64` | `` |
| `LeftUserStrip2_1` | `Int32` | Yes | `-71` | `` |
| `LeftUserStrip2_2` | `Int32` | Yes | `-72` | `` |
| `LeftUserStrip2_3` | `Int32` | Yes | `-73` | `` |
| `LeftUserStrip2_4` | `Int32` | Yes | `-74` | `` |
| `LeftUserStrip3_1` | `Int32` | Yes | `-81` | `` |
| `LeftUserStrip3_2` | `Int32` | Yes | `-82` | `` |
| `LeftUserStrip3_3` | `Int32` | Yes | `-83` | `` |
| `LeftUserStrip3_4` | `Int32` | Yes | `-84` | `` |
| `LeftUserStrip4_1` | `Int32` | Yes | `-91` | `` |
| `LeftUserStrip4_2` | `Int32` | Yes | `-92` | `` |
| `LeftUserStrip4_3` | `Int32` | Yes | `-93` | `` |
| `LeftUserStrip4_4` | `Int32` | Yes | `-94` | `` |
| `LeftUserStrip5_1` | `Int32` | Yes | `-101` | `` |
| `LeftUserStrip5_2` | `Int32` | Yes | `-102` | `` |
| `LeftUserStrip5_3` | `Int32` | Yes | `-103` | `` |
| `LeftUserStrip5_4` | `Int32` | Yes | `-104` | `` |
| `LeftWaitArea` | `Int32` | Yes | `-200` | `` |
| `ReversalAreaLeftDivider` | `Int32` | Yes | `-9` | `` |
| `ReversalAreaLeftPsp` | `Int32` | Yes | `-15` | `` |
| `ReversalAreaRightDivider` | `Int32` | Yes | `9` | `` |
| `ReversalAreaRightPsp` | `Int32` | Yes | `15` | `` |
| `RightBorderSide1Height` | `Int32` | Yes | `210` | `` |
| `RightBorderSide2Height` | `Int32` | Yes | `214` | `` |
| `RightCenterLine` | `Int32` | Yes | `1` | `` |
| `RightDivider` | `Int32` | Yes | `10` | `` |
| `RightDividerBorderHeight` | `Int32` | Yes | `230` | `` |
| `RightForceDivider` | `Int32` | Yes | `20` | `` |
| `RightMainStrip1` | `Int32` | Yes | `60` | `` |
| `RightMainStrip2` | `Int32` | Yes | `70` | `` |
| `RightMainStrip3` | `Int32` | Yes | `80` | `` |
| `RightMainStrip4` | `Int32` | Yes | `90` | `` |
| `RightMainStrip5` | `Int32` | Yes | `100` | `` |
| `RightMainStripOffset1` | `Int32` | Yes | `55` | `` |
| `RightMainStripOffset2` | `Int32` | Yes | `65` | `` |
| `RightMainStripOffset3` | `Int32` | Yes | `75` | `` |
| `RightMainStripOffset4` | `Int32` | Yes | `85` | `` |
| `RightMainStripOffset5` | `Int32` | Yes | `95` | `` |
| `RightPocket` | `Int32` | Yes | `130` | `` |
| `RightPsp` | `Int32` | Yes | `120` | `` |
| `RightPspDivider` | `Int32` | Yes | `110` | `` |
| `RightSand` | `Int32` | Yes | `500` | `` |
| `RightSide1` | `Int32` | Yes | `160` | `` |
| `RightSide2` | `Int32` | Yes | `215` | `` |
| `RightSide3` | `Int32` | Yes | `230` | `` |
| `RightSideCompensation` | `Int32` | Yes | `213` | `` |
| `RightSidePspCompensation` | `Int32` | Yes | `214` | `` |
| `RightUserStrip0_1` | `Int32` | Yes | `51` | `` |
| `RightUserStrip0_2` | `Int32` | Yes | `52` | `` |
| `RightUserStrip0_3` | `Int32` | Yes | `53` | `` |
| `RightUserStrip0_4` | `Int32` | Yes | `54` | `` |
| `RightUserStrip1_1` | `Int32` | Yes | `61` | `` |
| `RightUserStrip1_2` | `Int32` | Yes | `62` | `` |
| `RightUserStrip1_3` | `Int32` | Yes | `63` | `` |
| `RightUserStrip1_4` | `Int32` | Yes | `64` | `` |
| `RightUserStrip2_1` | `Int32` | Yes | `71` | `` |
| `RightUserStrip2_2` | `Int32` | Yes | `72` | `` |
| `RightUserStrip2_3` | `Int32` | Yes | `73` | `` |
| `RightUserStrip2_4` | `Int32` | Yes | `74` | `` |
| `RightUserStrip3_1` | `Int32` | Yes | `81` | `` |
| `RightUserStrip3_2` | `Int32` | Yes | `82` | `` |
| `RightUserStrip3_3` | `Int32` | Yes | `83` | `` |
| `RightUserStrip3_4` | `Int32` | Yes | `84` | `` |
| `RightUserStrip4_1` | `Int32` | Yes | `91` | `` |
| `RightUserStrip4_2` | `Int32` | Yes | `92` | `` |
| `RightUserStrip4_3` | `Int32` | Yes | `93` | `` |
| `RightUserStrip4_4` | `Int32` | Yes | `94` | `` |
| `RightUserStrip5_1` | `Int32` | Yes | `101` | `` |
| `RightUserStrip5_2` | `Int32` | Yes | `102` | `` |
| `RightUserStrip5_3` | `Int32` | Yes | `103` | `` |
| `RightUserStrip5_4` | `Int32` | Yes | `104` | `` |
| `RightWaitArea` | `Int32` | Yes | `200` | `` |
| `SandLayerHeight` | `Int32` | Yes | `120` | `` |
| `StoneLayerHeight` | `Int32` | Yes | `110` | `` |
| `WidthPriorityReplace` | `Int32` | Yes | `1` | `` |
| `WidthPrioritySystem` | `Int32` | Yes | `0` | `` |
| `WorkingLayerHeight` | `Int32` | Yes | `130` | `` |

### `UrbMoveState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbMoveState` |
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
      - `Topomatic.Alg.Road.Urb.UrbMoveState`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Complete` | `UrbMoveState` | Yes | `Complete` | `` |
| `NeedRemove` | `UrbMoveState` | Yes | `NeedRemove` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Complete` | `0` |
| `NeedRemove` | `1` |

**Underlying Type**: `System.Int32`

### `UrbObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`

#### Constructors (2)

- `.ctor(UrbParams owner, UrbObject value)`
- `.ctor(UrbParams owner, UrbObjectOptions options)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IsHidden` | `Boolean` | `get` | No | `` |
| `IsUserDefined` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Urb` | `UrbParams` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `ObjectInLimits` | `Boolean` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEquatable`1` | `Equals` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `UrbObjectEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbObjectEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Alg.Road.Urb.UrbObjectEventArgs`

#### Constructors (1)

- `.ctor(UrbObject obj)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Object` | `UrbObject` | `get` | No | `` |

### `UrbObjectMarking` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbObjectMarking` |
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
      - `Topomatic.Alg.Road.Urb.UrbObjectMarking`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Island` | `UrbObjectMarking` | Yes | `Island` | `` |
| `Linear` | `UrbObjectMarking` | Yes | `Linear` | `` |
| `None` | `UrbObjectMarking` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Linear` | `1` |
| `Island` | `2` |

**Underlying Type**: `System.Int32`

### `UrbObjectOptions` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbObjectOptions` |
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
      - `Topomatic.Alg.Road.Urb.UrbObjectOptions`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Hidden` | `UrbObjectOptions` | Yes | `Hidden` | `` |
| `None` | `UrbObjectOptions` | Yes | `None` | `` |
| `System` | `UrbObjectOptions` | Yes | `System` | `` |
| `UserDefined` | `UrbObjectOptions` | Yes | `UserDefined` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `System` | `1` |
| `Hidden` | `2` |
| `UserDefined` | `4` |

**Underlying Type**: `System.Int32`

### `UrbObjectRecorder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbObjectRecorder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RegisterAsExcludedObject` | `Void` | `ExcludedPosition side, UrbObject obj` | `` |
| `RegisterAsGradeObject` | `Void` | `Int32 category, UrbObject obj` | `` |
| `RegisterAsHoleObject` | `Void` | `HolePosition side, UrbObject obj` | `` |
| `RegisterAsParamObject` | `Void` | `Int32 category, UrbObject obj` | `` |
| `RegisterAsSectionExcludedObject` | `Void` | `ExcludedPosition side, UrbObject obj` | `` |
| `RegisterAsWidthObject` | `Void` | `Int32 category, UrbObject obj` | `` |

### `UrbParams` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbParams` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbParams`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Alignment` | `Alignment` | `get` | No | `` |
| `Construction` | `ConstructionStrip` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DividerStrips` | `DividerStrips` | `get` | No | `` |
| `Item` | `UrbObject` | `get` | No | `` |
| `Item` | `UrbObject` | `get` | No | `` |
| `MainStrips` | `MainStrips` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SideStrips` | `SideStrips` | `get` | No | `` |

#### Instance Methods (31)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `UrbObject item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Guid id` | `` |
| `Contains` | `Boolean` | `UrbObject item` | `` |
| `FillChangingStations` | `Void` | `List<Double> stations` | `` |
| `FillSections` | `Void` | `Double from, Double to, Boolean interpolate, Boolean mark, Nullable<Int32> template, Nullable<Int32> variables, Func<UrbObject Nullable<Int32>> findMatchAndMask` | `` |
| `GetElevation` | `Boolean` | `Double station, Double offset, ref Double firstElevation, ref Double lastElevation` | `` |
| `GetElevation` | `Boolean` | `Double station, Double offset, Nullable<Double> lastGrade, Int32 stopCategory, ref Double firstElevation, ref Double lastElevation` | `` |
| `GetEnumerator` | `IEnumerator<UrbObject>` | `` | `` |
| `GetGrade` | `Boolean` | `Double station, GradePosition position, GradePriority priority, Boolean ignoreOptions, ref Double firstGrade, ref Double lastGrade` | `` |
| `GetParamValue` | `Boolean` | `Double station, ParamPosition position, ref Double firstValue, ref Double lastValue` | `` |
| `GetWidthAndElevation` | `Boolean` | `Double station, Int32 category1, Int32 category2, ref Double firstWidth, ref Double lastWidth, ref Double firstElevation, ref Double lastElevation` | `` |
| `GetWidthAndElevation` | `Boolean` | `Double station, StripPosition position, ref Double firstWidth, ref Double lastWidth, ref Double firstElevation, ref Double lastElevation` | `` |
| `GetWidths` | `Strip` | `Int32 category1, Int32 category2` | `` |
| `GetWidths` | `Strip` | `Double startStation, Double endStation, Int32 category1, Int32 category2, Nullable<Double> strongLength` | `` |
| `GetWidthsAndElevations` | `IList<UrbStationItem>` | `Double station` | `` |
| `HasExcluded` | `InsideSegmentPosition` | `Double station, StripPosition position` | `` |
| `HasHole` | `InsideSegmentPosition` | `Double station, StripPosition position, ref Double firstHole, ref Double lastHole` | `` |
| `HasSectionExcluded` | `InsideSegmentPosition` | `Double station, StripPosition position` | `` |
| `IndexOf` | `Int32` | `UrbObject item` | `` |
| `Insert` | `Void` | `Int32 index, UrbObject item` | `` |
| `Invalidate` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Move` | `Void` | `Double station, Double offset` | `` |
| `PlanOffset` | `IPolyline3D` | `Double startStation, Double endStation, StripPosition position, Double offset` | `` |
| `PlanOffset` | `IPolyline3D` | `StripPosition position, Double offset` | `` |
| `Remove` | `Boolean` | `Guid id` | `` |
| `Remove` | `Boolean` | `UrbObject item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetObject` | `Boolean` | `Guid id, ref UrbObject value` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `BeforeRemove` | `EventHandler<UrbObjectEventArgs>` | No | `` |

#### Nested Types (1)

- `UrbStationItem` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IAlignmentContainer` | `get_Alignment` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `UrbStationItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UrbParams+UrbStationItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.UrbParams+UrbStationItem`

#### Constructors (1)

- `.ctor(Double firstWidth, Double lastWidth, Double firstElevation, Double lastElevation, Int32 code)`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Code` | `Int32` | No | `` | `` |
| `FirstElevation` | `Double` | No | `` | `` |
| `FirstWidth` | `Double` | No | `` | `` |
| `LastElevation` | `Double` | No | `` | `` |
| `LastWidth` | `Double` | No | `` | `` |

### `WidthOptions` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.WidthOptions` |
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
      - `Topomatic.Alg.Road.Urb.WidthOptions`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `WidthOptions` | Yes | `None` | `` |
| `Replace` | `WidthOptions` | Yes | `Replace` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Replace` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Road.Urb.Border`

### `BorderPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Border.BorderPosition` |
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
      - `Topomatic.Alg.Road.Urb.Border.BorderPosition`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftDivider` | `BorderPosition` | Yes | `LeftDivider` | `` |
| `LeftSide1` | `BorderPosition` | Yes | `LeftSide1` | `` |
| `LeftSide2` | `BorderPosition` | Yes | `LeftSide2` | `` |
| `RightDivider` | `BorderPosition` | Yes | `RightDivider` | `` |
| `RightSide1` | `BorderPosition` | Yes | `RightSide1` | `` |
| `RightSide2` | `BorderPosition` | Yes | `RightSide2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftDivider` | `0` |
| `LeftSide1` | `1` |
| `LeftSide2` | `2` |
| `RightDivider` | `3` |
| `RightSide1` | `4` |
| `RightSide2` | `5` |

**Underlying Type**: `System.Int32`

### `BorderStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Border.BorderStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Border.BorderStrip`

#### Constructors (3)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, BorderStrip clone)`
- `.ctor(UrbParams urb, CadColor color, Double startStation, Double endStation, String description, Double startHeight, Double endHeight, BorderPosition position, String mark, Boolean leaderDraw, Boolean leaderMirror, Double leaderOffset, Double leaderRotation, Vector2D leaderPositon, Guid modelId)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `EndHeight` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `LeaderCenter` | `Vector2D` | `get` | No | `` |
| `LeaderDraw` | `Boolean` | `get/set` | No | `` |
| `LeaderMirror` | `Boolean` | `get/set` | No | `` |
| `LeaderNormal` | `Vector2D` | `get` | No | `` |
| `LeaderOffset` | `Double` | `get/set` | No | `` |
| `LeaderPosition` | `Vector2D` | `get/set` | No | `` |
| `LeaderRotation` | `Double` | `get/set` | No | `` |
| `Mark` | `String` | `get/set` | No | `` |
| `ModelId` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Normal` | `Vector2D` | `get` | No | `` |
| `Position` | `BorderPosition` | `get/set` | No | `` |
| `StartHeight` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `UrbCategory` | `Int32` | `get` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `Boolean` | `Double start, Double end, ref IPolyline3D border` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `ICompoundLinearObject` | `GetPathList` |
| `ILinearObject` | `GetPolyline` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

---
## Namespace: `Topomatic.Alg.Road.Urb.Descent`

### `DescentDirectionPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentDirectionPosition` |
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
      - `Topomatic.Alg.Road.Urb.Descent.DescentDirectionPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `After` | `DescentDirectionPosition` | Yes | `After` | `` |
| `Before` | `DescentDirectionPosition` | Yes | `Before` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Before` | `0` |
| `After` | `1` |

**Underlying Type**: `System.Int32`

### `DescentExcludedPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentExcludedPosition` |
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
      - `Topomatic.Alg.Road.Urb.Descent.DescentExcludedPosition`

#### Fields (13)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `DescentExcludedPosition` | Yes | `Center` | `` |
| `Divider` | `DescentExcludedPosition` | Yes | `Divider` | `` |
| `DividerBorder` | `DescentExcludedPosition` | Yes | `DividerBorder` | `` |
| `First` | `DescentExcludedPosition` | Yes | `First` | `` |
| `Five` | `DescentExcludedPosition` | Yes | `Five` | `` |
| `Four` | `DescentExcludedPosition` | Yes | `Four` | `` |
| `Psp` | `DescentExcludedPosition` | Yes | `Psp` | `` |
| `Second` | `DescentExcludedPosition` | Yes | `Second` | `` |
| `Side1` | `DescentExcludedPosition` | Yes | `Side1` | `` |
| `Side2` | `DescentExcludedPosition` | Yes | `Side2` | `` |
| `Side3` | `DescentExcludedPosition` | Yes | `Side3` | `` |
| `Third` | `DescentExcludedPosition` | Yes | `Third` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Center` | `0` |
| `Divider` | `1` |
| `DividerBorder` | `2` |
| `First` | `3` |
| `Second` | `4` |
| `Third` | `5` |
| `Four` | `6` |
| `Five` | `7` |
| `Psp` | `8` |
| `Side1` | `9` |
| `Side2` | `10` |
| `Side3` | `11` |

**Underlying Type**: `System.Int32`

### `DescentPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentPosition` |
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
      - `Topomatic.Alg.Road.Urb.Descent.DescentPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftCenter` | `DescentPosition` | Yes | `LeftCenter` | `` |
| `RightCenter` | `DescentPosition` | Yes | `RightCenter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftCenter` | `0` |
| `RightCenter` | `1` |

**Underlying Type**: `System.Int32`

### `DescentStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Descent.DescentStrip`

#### Constructors (3)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, DescentStrip clone)`
- `.ctor(UrbParams urb, String name, CadColor stripColor, StripHatch stripHatch, CadColor dividerColor, StripHatch dividerHatch, DescentPosition descentPosition, Double startHole, Double startHoleOffset, Double endHole, Double endHoleOffset, Boolean useUrbSides, Boolean useExcludedHole, DescentExcludedPosition excludedPosition, DescentDirectionPosition directionPosition, Boolean hasPsp, Double pspLength, Double pspOtgon, Double pspJump, Double pspWidth, Double extendedPspLength, Double extendedPspOtgon, Double extendedPspWidth, Double dividerLength, Double dividerOtgon, Double dividerWidth, Double pspGrade, Boolean usePspGrade, Double sideWidthStart, Double side1WidthStart, Double side3WidthStart, Double sideWidthMiddle, Double side1WidthMiddle, Double side3WidthMiddle, Double sideWidthEnd, Double side1WidthEnd, Double side3WidthEnd, Boolean fromCrossing)`

#### Properties (49)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AdditionalGrades` | `Grades` | `get` | No | `` |
| `AdditionalLengths` | `Lengths` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `DescentPosition` | `DescentPosition` | `get/set` | No | `` |
| `DirectionPosition` | `DescentDirectionPosition` | `get/set` | No | `` |
| `DividerBorder` | `IPolyline3D` | `get` | No | `` |
| `DividerBounds` | `BoundingBox2D` | `get` | No | `` |
| `DividerColor` | `CadColor` | `get/set` | No | `` |
| `DividerHatch` | `StripHatch` | `get/set` | No | `` |
| `DividerLength` | `Double` | `get/set` | No | `` |
| `DividerOtgon` | `Double` | `get/set` | No | `` |
| `DividerWidth` | `Double` | `get/set` | No | `` |
| `EndHole` | `Double` | `get/set` | No | `` |
| `EndHoleOffset` | `Double` | `get/set` | No | `` |
| `ExcludedPosition` | `DescentExcludedPosition` | `get/set` | No | `` |
| `ExtendedPspLength` | `Double` | `get/set` | No | `` |
| `ExtendedPspOtgon` | `Double` | `get/set` | No | `` |
| `ExtendedPspWidth` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `HasPsp` | `Boolean` | `get/set` | No | `` |
| `HoleBounds` | `BoundingBox2D` | `get` | No | `` |
| `HoleLine` | `IPolyline3D` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Lines` | `IPolyline3D[]` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PspBorder` | `IPolyline3D` | `get` | No | `` |
| `PspBounds` | `BoundingBox2D` | `get` | No | `` |
| `PspGrade` | `Double` | `get/set` | No | `` |
| `PspJump` | `Double` | `get/set` | No | `` |
| `PspLength` | `Double` | `get/set` | No | `` |
| `PspOtgon` | `Double` | `get/set` | No | `` |
| `PspWidth` | `Double` | `get/set` | No | `` |
| `Side1WidthEnd` | `Double` | `get/set` | No | `` |
| `Side1WidthMiddle` | `Double` | `get/set` | No | `` |
| `Side1WidthStart` | `Double` | `get/set` | No | `` |
| `Side3WidthEnd` | `Double` | `get/set` | No | `` |
| `Side3WidthMiddle` | `Double` | `get/set` | No | `` |
| `Side3WidthStart` | `Double` | `get/set` | No | `` |
| `SideWidthEnd` | `Double` | `get/set` | No | `` |
| `SideWidthMiddle` | `Double` | `get/set` | No | `` |
| `SideWidthStart` | `Double` | `get/set` | No | `` |
| `StartHole` | `Double` | `get/set` | No | `` |
| `StartHoleOffset` | `Double` | `get/set` | No | `` |
| `StripColor` | `CadColor` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `UseExcludedHole` | `Boolean` | `get/set` | No | `` |
| `UsePspGrade` | `Boolean` | `get/set` | No | `` |
| `UseUrbSides` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Nested Types (2)

- `Grades` (class)
- `Lengths` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `GradeItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades+GradeItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades+GradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades+GradeItem`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GradeItem other` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Length` | `Double` | No | `` | `` |
| `PspGrade` | `Double` | No | `` | `` |
| `Side1Grade` | `Double` | No | `` | `` |
| `SideGrade` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Grades` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades+GradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades+GradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Grades`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Grades grades)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `GradeItem` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `GradeItem item` | `` |
| `Assign` | `Void` | `Grades lengths` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `GradeItem item` | `` |
| `CopyTo` | `Void` | `GradeItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<GradeItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `GradeItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `GradeItem` (struct)

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `LengthItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths+LengthItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths+LengthItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths+LengthItem`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `LengthItem other` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Length` | `Double` | No | `` | `` |
| `PspWidth` | `Double` | No | `` | `` |
| `Side1Width` | `Double` | No | `` | `` |
| `Side2Width` | `Double` | No | `` | `` |
| `Side3Width` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Lengths` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.ICollection`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths+LengthItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths+LengthItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Urb.Descent.DescentStrip+Lengths`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Lengths lengths)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `LengthItem` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `LengthItem item` | `` |
| `Assign` | `Void` | `Lengths lengths` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `LengthItem item` | `` |
| `CopyTo` | `Void` | `LengthItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<LengthItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `LengthItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `LengthItem` (struct)

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
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

---
## Namespace: `Topomatic.Alg.Road.Urb.GeneralStrips`

### `CenterStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.CenterStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.GeneralStrips.CenterStrip`

#### Constructors (2)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, CenterStrip clone)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CenterStripId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `ConstructionItem` (struct)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.ConstructionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.ConstructionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.ConstructionItem`

#### Constructors (2)

- `.ctor(ConstructionItem item)`
- `.ctor(Double station, String description, Double asphaltLayerHeight, Double stoneLayerHeight, Double sandLayerHeight, Double workingLayerHeight, Double leftSandGrade, Double rightSandGrade, Double fondationBroadering)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ConstructionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, ConstructionItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ConstructionItem` | `StgNode stgNode, ConstructionItem defaultValue` | `` |
| `LoadFromStg` | `ConstructionItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `ConstructionItem node, StgNode stgNode, ConstructionItem defaultValue` | `` |
| `SaveToStg` | `Void` | `ConstructionItem node, StgNode stgNode` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AsphaltLayerHeight` | `Double` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FondationBroadening` | `Double` | No | `` | `` |
| `LeftSandGrade` | `Double` | No | `` | `` |
| `RightSandGrade` | `Double` | No | `` | `` |
| `SandLayerHeight` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |
| `StoneLayerHeight` | `Double` | No | `` | `` |
| `WorkingLayerHeight` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ConstructionStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.ConstructionStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.GeneralStrips.ConstructionStrip`

#### Constructors (2)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, ConstructionStrip clone)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConstructionItems` | `IList<ConstructionItem>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `SandGrades` | `IList<GradeItem>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetConstruction` | `ConstructionItem` | `Double station` | `` |
| `GetGrades` | `GradeItem` | `Double station` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConstructionStripId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `DividerItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.DividerItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.DividerItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.DividerItem`

#### Constructors (2)

- `.ctor(DividerItem item)`
- `.ctor(Double station, String description, Double leftFull, Double leftBorder, Double rightFull, Double rightBorder)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `DividerItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, DividerItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DividerItem` | `StgNode stgNode, DividerItem defaultValue` | `` |
| `LoadFromStg` | `DividerItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `DividerItem node, StgNode stgNode, DividerItem defaultValue` | `` |
| `SaveToStg` | `Void` | `DividerItem node, StgNode stgNode` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `LeftBorder` | `Double` | No | `` | `` |
| `LeftFull` | `Double` | No | `` | `` |
| `RightBorder` | `Double` | No | `` | `` |
| `RightFull` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `DividerStrips` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.DividerStrips` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.GeneralStrips.DividerStrips`

#### Constructors (2)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, DividerStrips clone)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Grades` | `IList<GradeItem>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Widths` | `IList<DividerItem>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetGrade` | `GradeItem` | `Double station` | `` |
| `GetWidth` | `DividerItem` | `Double station` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DividerStripsId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `GradeItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.GradeItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.GradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.GradeItem`

#### Constructors (2)

- `.ctor(GradeItem item)`
- `.ctor(Double station, String description, Double left, Double right)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `GradeItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, GradeItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `GradeItem` | `StgNode stgNode, GradeItem defaultValue` | `` |
| `LoadFromStg` | `GradeItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `GradeItem node, StgNode stgNode, GradeItem defaultValue` | `` |
| `SaveToStg` | `Void` | `GradeItem node, StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Left` | `Double` | No | `` | `` |
| `Right` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `MainItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.MainItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.MainItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.MainItem`

#### Constructors (2)

- `.ctor(MainItem item)`
- `.ctor(Double station, String description, Double left1, Double left2, Double left3, Double left4, Double left5, Double right1, Double right2, Double right3, Double right4, Double right5)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftFull` | `Double` | `get` | No | `` |
| `LeftStripsCount` | `Int32` | `get` | No | `` |
| `RightFull` | `Double` | `get` | No | `` |
| `RightStripsCount` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `MainItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, MainItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `MainItem` | `StgNode stgNode, MainItem defaultValue` | `` |
| `LoadFromStg` | `MainItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `MainItem node, StgNode stgNode, MainItem defaultValue` | `` |
| `SaveToStg` | `Void` | `MainItem node, StgNode stgNode` | `` |

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Left1` | `Double` | No | `` | `` |
| `Left2` | `Double` | No | `` | `` |
| `Left3` | `Double` | No | `` | `` |
| `Left4` | `Double` | No | `` | `` |
| `Left5` | `Double` | No | `` | `` |
| `Right1` | `Double` | No | `` | `` |
| `Right2` | `Double` | No | `` | `` |
| `Right3` | `Double` | No | `` | `` |
| `Right4` | `Double` | No | `` | `` |
| `Right5` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `MainStrips` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.MainStrips` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.GeneralStrips.MainStrips`

#### Constructors (2)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, MainStrips clone)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Grades` | `IList<MainItem>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Widths` | `IList<MainItem>` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetGrade` | `MainItem` | `Double station` | `` |
| `GetStripsCounts` | `Void` | `Double station, ref Int32 leftCount, ref Int32 rightCount` | `` |
| `GetWidth` | `MainItem` | `Double station` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MainStripsId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `SideGradeItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.SideGradeItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.SideGradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.SideGradeItem`

#### Constructors (2)

- `.ctor(SideGradeItem item)`
- `.ctor(Double station, String description, Double left, Double right, Double leftSide1Grade, Double rightSide1Grade, Double leftSide3Grade, Double rightSide3Grade)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SideGradeItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, SideGradeItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SideGradeItem` | `StgNode stgNode, SideGradeItem defaultValue` | `` |
| `LoadFromStg` | `SideGradeItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `SideGradeItem node, StgNode stgNode, SideGradeItem defaultValue` | `` |
| `SaveToStg` | `Void` | `SideGradeItem node, StgNode stgNode` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Left` | `Double` | No | `` | `` |
| `LeftSide1Grade` | `Double` | No | `` | `` |
| `LeftSide3Grade` | `Double` | No | `` | `` |
| `Right` | `Double` | No | `` | `` |
| `RightSide1Grade` | `Double` | No | `` | `` |
| `RightSide3Grade` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `SideItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.SideItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.GeneralStrips.SideItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.GeneralStrips.SideItem`

#### Constructors (2)

- `.ctor(SideItem item)`
- `.ctor(Double station, String description, Double leftFull, Double leftGrass, Double leftConcrete, Double rightFull, Double rightGrass, Double rightConcrete)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SideItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, SideItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SideItem` | `StgNode stgNode, SideItem defaultValue` | `` |
| `LoadFromStg` | `SideItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `SideItem node, StgNode stgNode, SideItem defaultValue` | `` |
| `SaveToStg` | `Void` | `SideItem node, StgNode stgNode` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `LeftConcrete` | `Double` | No | `` | `` |
| `LeftFull` | `Double` | No | `` | `` |
| `LeftGrass` | `Double` | No | `` | `` |
| `RightConcrete` | `Double` | No | `` | `` |
| `RightFull` | `Double` | No | `` | `` |
| `RightGrass` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `SideStrips` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.GeneralStrips.SideStrips` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.GeneralStrips.SideStrips`

#### Constructors (2)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, SideStrips clone)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Grades` | `IList<SideGradeItem>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `UseFixedSide2Width` | `Boolean` | `get/set` | No | `` |
| `UseSide1Grade` | `Boolean` | `get/set` | No | `` |
| `UseSide3Grade` | `Boolean` | `get/set` | No | `` |
| `Widths` | `IList<SideItem>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetGrade` | `SideGradeItem` | `Double station` | `` |
| `GetWidth` | `SideItem` | `Double station` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SideStripsId` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

---
## Namespace: `Topomatic.Alg.Road.Urb.HoleStrips`

### `HoleStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.HoleStrips.HoleStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.HoleStrips.HoleStrip`

#### Constructors (4)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, HoleStrip clone)`
- `.ctor(UrbParams urb, Double startStation, Double endStation)`
- `.ctor(UrbParams urb, String name, Double startStation, Double startOffset, Double endStation, Double endOffset, HolePosition position, Boolean fromCrossing)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `EndOffset` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Position` | `HolePosition` | `get/set` | No | `` |
| `StartOffset` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `ICompoundLinearObject` | `GetPathList` |
| `ILinearObject` | `GetPolyline` |

---
## Namespace: `Topomatic.Alg.Road.Urb.Islands`

### `DirectionIsland` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.DirectionIsland` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Islands.DirectionIsland`

#### Constructors (4)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, DirectionIsland clone)`
- `.ctor(UrbParams urb, Double station)`
- `.ctor(UrbParams urb, String name, Double station, CadColor color, StripHatch hatch, IslandDirection direction, Double lengthForward, Double stopLength, Double stopWidth, Double middleWidth, Double lengthBeforeMiddle, Double lengthAfterMiddle, Double dividerWidth, Double dividerOtgon, Double dividerLength, Boolean fromCrossing)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Direction` | `IslandDirection` | `get/set` | No | `` |
| `DividerLength` | `Double` | `get/set` | No | `` |
| `DividerOtgon` | `Double` | `get/set` | No | `` |
| `DividerWidth` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IslandBorder` | `IPolyline3D` | `get` | No | `` |
| `IslandBounds` | `BoundingBox2D` | `get` | No | `` |
| `IslandDividerBorder` | `IPolyline3D` | `get` | No | `` |
| `IslandDividerBounds` | `BoundingBox2D` | `get` | No | `` |
| `LengthAfterMiddle` | `Double` | `get/set` | No | `` |
| `LengthBeforeMiddle` | `Double` | `get/set` | No | `` |
| `LengthForward` | `Double` | `get/set` | No | `` |
| `Lines` | `IPolyline3D[]` | `get` | No | `` |
| `LinesBounds` | `BoundingBox2D[]` | `get` | No | `` |
| `MiddleWidth` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `StopLength` | `Double` | `get/set` | No | `` |
| `StopWidth` | `Double` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `DropShapedIslandRadiusPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.DropShapedIslandRadiusPosition` |
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
      - `Topomatic.Alg.Road.Urb.Islands.DropShapedIslandRadiusPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MainRadius` | `DropShapedIslandRadiusPosition` | Yes | `MainRadius` | `` |
| `SecondRadius` | `DropShapedIslandRadiusPosition` | Yes | `SecondRadius` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `MainRadius` | `0` |
| `SecondRadius` | `1` |

**Underlying Type**: `System.Int32`

### `IslandDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.IslandDirection` |
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
      - `Topomatic.Alg.Road.Urb.Islands.IslandDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `IslandDirection` | Yes | `Backward` | `` |
| `Forward` | `IslandDirection` | Yes | `Forward` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Forward` | `0` |
| `Backward` | `1` |

**Underlying Type**: `System.Int32`

### `MajorDropShapedIsland` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.MajorDropShapedIsland` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Islands.MajorDropShapedIsland`

#### Constructors (5)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, MajorDropShapedIsland clone)`
- `.ctor(UrbParams urb, Double station)`
- `.ctor(UrbParams urb, String name, Double station, IslandDirection direction, Double width, Double backwardLength, Double forwardLength, Double radius, Boolean fromCrossing)`
- `.ctor(UrbParams urb, String name, Double station, CadColor color, StripHatch hatch, IslandDirection direction, Double width, Double backwardLength, Double forwardLength, Double radius, Boolean fromCrossing)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardLength` | `Double` | `get/set` | No | `` |
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `CenterPosition` | `Vector2D` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Direction` | `IslandDirection` | `get/set` | No | `` |
| `ForwardLength` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `MinorDropShapedIsland` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.MinorDropShapedIsland` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Islands.MinorDropShapedIsland`

#### Constructors (5)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, MinorDropShapedIsland clone)`
- `.ctor(UrbParams urb, Double station)`
- `.ctor(UrbParams urb, String name, Double station, IslandDirection direction, Double width, Double backwardLength, Double forwardLength, Double lineLength, Double mainRadius, Double secondRadius, DropShapedIslandRadiusPosition radiusPosition, Double broadeningLength, Double broadeningWidthLeft, Double broadeningWidthRight, Boolean fromCrossing)`
- `.ctor(UrbParams urb, String name, Double station, CadColor color, StripHatch hatch, IslandDirection direction, Double width, Double backwardLength, Double forwardLength, Double lineLength, Double mainRadius, Double secondRadius, DropShapedIslandRadiusPosition radiusPosition, Double broadeningLength, Double broadeningWidthLeft, Double broadeningWidthRight, Boolean fromCrossing)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardLength` | `Double` | `get/set` | No | `` |
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `BroadeningLength` | `Double` | `get/set` | No | `` |
| `BroadeningWidthLeft` | `Double` | `get/set` | No | `` |
| `BroadeningWidthRight` | `Double` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Direction` | `IslandDirection` | `get/set` | No | `` |
| `ForwardLength` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `LineLength` | `Double` | `get/set` | No | `` |
| `MainRadius` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `RadiusPosition` | `DropShapedIslandRadiusPosition` | `get/set` | No | `` |
| `SecondRadius` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `ReversalArea` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.ReversalArea` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Islands.ReversalArea`

#### Constructors (3)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, ReversalArea clone)`
- `.ctor(UrbParams urb, String name, String description, Double station, CadColor color, StripHatch hatch, ReversalAreaType reversalAreaType, Double leftBeforeRadius, Double leftCenterRadius, Double leftAfterRadius, Double rightBeforeRadius, Double rightCenterRadius, Double rightAfterRadius, Double axisOffset, Double radius, Double pspWidth, Double middleWidth, Double pspDividerWidth, Double radiusWidth, Double leftBeforePspLength, Double leftBeforePspOtgon, Double leftAfterPspLength, Double leftAfterPspOtgon, Double rightBeforePspLength, Double rightBeforePspOtgon, Double rightAfterPspLength, Double rightAfterPspOtgon, Double leftPspDividerLength, Double leftPspDividerOtgon, Double rightPspDividerLength, Double rightPspDividerOtgon)`

#### Properties (39)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AfterIslandBorder` | `IPolyline3D` | `get` | No | `` |
| `AfterIslandBounds` | `BoundingBox2D` | `get` | No | `` |
| `AxisOffset` | `Double` | `get/set` | No | `` |
| `BeforeIslandBorder` | `IPolyline3D` | `get` | No | `` |
| `BeforeIslandBounds` | `BoundingBox2D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `LeftAfterPspLength` | `Double` | `get/set` | No | `` |
| `LeftAfterPspOtgon` | `Double` | `get/set` | No | `` |
| `LeftAfterRadius` | `Double` | `get/set` | No | `` |
| `LeftBeforePspLength` | `Double` | `get/set` | No | `` |
| `LeftBeforePspOtgon` | `Double` | `get/set` | No | `` |
| `LeftBeforeRadius` | `Double` | `get/set` | No | `` |
| `LeftCenterRadius` | `Double` | `get/set` | No | `` |
| `LeftPspDividerLength` | `Double` | `get/set` | No | `` |
| `LeftPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `Lines` | `IPolyline3D[]` | `get` | No | `` |
| `LinesBounds` | `BoundingBox2D[]` | `get` | No | `` |
| `MiddleWidth` | `Double` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PspDividerWidth` | `Double` | `get/set` | No | `` |
| `PspWidth` | `Double` | `get/set` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `RadiusWidth` | `Double` | `get/set` | No | `` |
| `ReversalAreaType` | `ReversalAreaType` | `get/set` | No | `` |
| `RightAfterPspLength` | `Double` | `get/set` | No | `` |
| `RightAfterPspOtgon` | `Double` | `get/set` | No | `` |
| `RightAfterRadius` | `Double` | `get/set` | No | `` |
| `RightBeforePspLength` | `Double` | `get/set` | No | `` |
| `RightBeforePspOtgon` | `Double` | `get/set` | No | `` |
| `RightBeforeRadius` | `Double` | `get/set` | No | `` |
| `RightCenterRadius` | `Double` | `get/set` | No | `` |
| `RightPspDividerLength` | `Double` | `get/set` | No | `` |
| `RightPspDividerOtgon` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `ReversalAreaType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.ReversalAreaType` |
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
      - `Topomatic.Alg.Road.Urb.Islands.ReversalAreaType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DropShapedAfter` | `ReversalAreaType` | Yes | `DropShapedAfter` | `` |
| `DropShapedBefore` | `ReversalAreaType` | Yes | `DropShapedBefore` | `` |
| `DropShapedBoth` | `ReversalAreaType` | Yes | `DropShapedBoth` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DropShapedBefore` | `0` |
| `DropShapedAfter` | `1` |
| `DropShapedBoth` | `2` |

**Underlying Type**: `System.Int32`

### `TriangleIsland` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.TriangleIsland` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Islands.TriangleIsland`

#### Constructors (4)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, TriangleIsland clone)`
- `.ctor(UrbParams urb, String name, CadColor color, StripHatch hatch, TriangleIslandPosition position, Boolean fromCrossing)`
- `.ctor(UrbParams urb, String name, CadColor color, StripHatch hatch, TriangleIslandPosition position, IEnumerable<Vector2D> points, Boolean fromCrossing)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Points` | `IList<Vector2D>` | `get` | No | `` |
| `Position` | `TriangleIslandPosition` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `TriangleIslandPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Islands.TriangleIslandPosition` |
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
      - `Topomatic.Alg.Road.Urb.Islands.TriangleIslandPosition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftFirst` | `TriangleIslandPosition` | Yes | `LeftFirst` | `` |
| `LeftSecond` | `TriangleIslandPosition` | Yes | `LeftSecond` | `` |
| `RightFirst` | `TriangleIslandPosition` | Yes | `RightFirst` | `` |
| `RightSecond` | `TriangleIslandPosition` | Yes | `RightSecond` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftFirst` | `0` |
| `RightFirst` | `1` |
| `LeftSecond` | `2` |
| `RightSecond` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Road.Urb.RoadStops`

### `BusStop` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.RoadStops.BusStop` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.RoadStops.BusStop`

#### Constructors (4)

- `.ctor(UrbParams parent)`
- `.ctor(UrbParams parent, BusStop clone)`
- `.ctor(UrbParams parent, Double station)`
- `.ctor(UrbParams parent, String name, StopPosition position, Double station, Double waitingAreaWidth, Double waitingAreaForwardLength, Double waitingAreaBackwardLength, CadColor waitingAreaColor, StripHatch waitingAreaHatch, Double landingPlaceWidth, Double landingPlaceForwardLength, Double landingPlaceBackwardLength, CadColor landingAreaColor, StripHatch landingAreaHatch, Double pocketWidth, Double pocketForwardLength, Double pocketBackwardLength, CadColor pocketColor, StripHatch pocketHatch, Double pspWidth, Double pspForwardLength, Double pspForwardOtgon, Double pspBackwardLength, Double pspBackwardOtgon, CadColor pspColor, StripHatch pspHatch, Double dividerWidth, Double dividerForwardLength, Double dividerForwardOtgon, Double dividerBackwardLength, Double dividerBackwardOtgon, CadColor dividerColor, StripHatch dividerHatch, Double sidewalkForwardWidth, Double sidewalkForwardLength, Double sideForwardWidth, Double grassForwardWidth, Double sidewalkBackwardWidth, Double sidewalkBackwardLength, Double sideBackwardWidth, Double grassBackwardWidth, Double pspJumpBefore, Double pspJumpAfter, Double borderHeight, Boolean useUrbGrades, Boolean replaceSide1, Double pocketGrade, Double stopGrade, Double pspGrade, CadColor grassAreaColor, StripHatch grassAreaHatch, CadColor sidewalkAreaColor, StripHatch sidewalkAreaHatch, CadColor sideAreaColor, StripHatch sideAreaHatch)`

#### Properties (81)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardGrassBorder` | `IPolyline3D` | `get` | No | `` |
| `BackwardGrassBounds` | `BoundingBox2D` | `get` | No | `` |
| `BackwardSideBorder` | `IPolyline3D` | `get` | No | `` |
| `BackwardSideBounds` | `BoundingBox2D` | `get` | No | `` |
| `BackwardSideWalkBorder` | `IPolyline3D` | `get` | No | `` |
| `BackwardSideWalkBounds` | `BoundingBox2D` | `get` | No | `` |
| `BorderHeight` | `Double` | `get/set` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `DividerBackwardLength` | `Double` | `get/set` | No | `` |
| `DividerBackwardOtgon` | `Double` | `get/set` | No | `` |
| `DividerBorder` | `IPolyline3D` | `get` | No | `` |
| `DividerBounds` | `BoundingBox2D` | `get` | No | `` |
| `DividerColor` | `CadColor` | `get/set` | No | `` |
| `DividerForwardLength` | `Double` | `get/set` | No | `` |
| `DividerForwardOtgon` | `Double` | `get/set` | No | `` |
| `DividerHatch` | `StripHatch` | `get/set` | No | `` |
| `DividerWidth` | `Double` | `get/set` | No | `` |
| `ForwardGrassBorder` | `IPolyline3D` | `get` | No | `` |
| `ForwardGrassBounds` | `BoundingBox2D` | `get` | No | `` |
| `ForwardSideBorder` | `IPolyline3D` | `get` | No | `` |
| `ForwardSideBounds` | `BoundingBox2D` | `get` | No | `` |
| `ForwardSideWalkBorder` | `IPolyline3D` | `get` | No | `` |
| `ForwardSideWalkBounds` | `BoundingBox2D` | `get` | No | `` |
| `GrassAreaColor` | `CadColor` | `get/set` | No | `` |
| `GrassAreaHatch` | `StripHatch` | `get/set` | No | `` |
| `GrassBackwardWidth` | `Double` | `get/set` | No | `` |
| `GrassForwardWidth` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `LandingAreaBorder` | `IPolyline3D` | `get` | No | `` |
| `LandingAreaBounds` | `BoundingBox2D` | `get` | No | `` |
| `LandingAreaColor` | `CadColor` | `get/set` | No | `` |
| `LandingAreaHatch` | `StripHatch` | `get/set` | No | `` |
| `LandingPlaceBackwardLength` | `Double` | `get/set` | No | `` |
| `LandingPlaceForwardLength` | `Double` | `get/set` | No | `` |
| `LandingPlaceWidth` | `Double` | `get/set` | No | `` |
| `Lines` | `IPolyline3D[]` | `get` | No | `` |
| `LinesBounds` | `BoundingBox2D[]` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PocketBackwardLength` | `Double` | `get/set` | No | `` |
| `PocketBorder` | `IPolyline3D` | `get` | No | `` |
| `PocketBounds` | `BoundingBox2D` | `get` | No | `` |
| `PocketColor` | `CadColor` | `get/set` | No | `` |
| `PocketForwardLength` | `Double` | `get/set` | No | `` |
| `PocketGrade` | `Double` | `get/set` | No | `` |
| `PocketHatch` | `StripHatch` | `get/set` | No | `` |
| `PocketWidth` | `Double` | `get/set` | No | `` |
| `Position` | `StopPosition` | `get/set` | No | `` |
| `PspBackwardLength` | `Double` | `get/set` | No | `` |
| `PspBackwardOtgon` | `Double` | `get/set` | No | `` |
| `PspBorder` | `IPolyline3D` | `get` | No | `` |
| `PspBounds` | `BoundingBox2D` | `get` | No | `` |
| `PspColor` | `CadColor` | `get/set` | No | `` |
| `PspForwardLength` | `Double` | `get/set` | No | `` |
| `PspForwardOtgon` | `Double` | `get/set` | No | `` |
| `PspGrade` | `Double` | `get/set` | No | `` |
| `PspHatch` | `StripHatch` | `get/set` | No | `` |
| `PspJumpBackward` | `Double` | `get/set` | No | `` |
| `PspJumpForward` | `Double` | `get/set` | No | `` |
| `PspWidth` | `Double` | `get/set` | No | `` |
| `ReplaceSide1` | `Boolean` | `get/set` | No | `` |
| `SideAreaColor` | `CadColor` | `get/set` | No | `` |
| `SideAreaHatch` | `StripHatch` | `get/set` | No | `` |
| `SideBackwardWidth` | `Double` | `get/set` | No | `` |
| `SideForwardWidth` | `Double` | `get/set` | No | `` |
| `SideWalkAreaColor` | `CadColor` | `get/set` | No | `` |
| `SideWalkAreaHatch` | `StripHatch` | `get/set` | No | `` |
| `SideWalkBackwardLength` | `Double` | `get/set` | No | `` |
| `SideWalkBackwardWidth` | `Double` | `get/set` | No | `` |
| `SideWalkForwardLength` | `Double` | `get/set` | No | `` |
| `SideWalkForwardWidth` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |
| `StopGrade` | `Double` | `get/set` | No | `` |
| `UseUrbGrades` | `Boolean` | `get/set` | No | `` |
| `WaitAreaBorder` | `IPolyline3D` | `get` | No | `` |
| `WaitAreaBounds` | `BoundingBox2D` | `get` | No | `` |
| `WaitingAreaBackwardLength` | `Double` | `get/set` | No | `` |
| `WaitingAreaColor` | `CadColor` | `get/set` | No | `` |
| `WaitingAreaForwardLength` | `Double` | `get/set` | No | `` |
| `WaitingAreaHatch` | `StripHatch` | `get/set` | No | `` |
| `WaitingAreaWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `StopPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.RoadStops.StopPosition` |
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
      - `Topomatic.Alg.Road.Urb.RoadStops.StopPosition`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `StopPosition` | Yes | `Left` | `` |
| `Right` | `StopPosition` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Road.Urb.SectionExclude`

### `SectionExclude` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.SectionExclude.SectionExclude` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.SectionExclude.SectionExclude`

#### Constructors (4)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, SectionExclude clone)`
- `.ctor(UrbParams urb, Double startStation, Double endStation)`
- `.ctor(UrbParams urb, String name, Double startStation, Double endStation, ExcludedPosition position, Boolean fromCrossing)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `Double` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Position` | `ExcludedPosition` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

---
## Namespace: `Topomatic.Alg.Road.Urb.UserStrips`

### `AxisStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.AxisStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.UserStrips.AxisStrip`

#### Constructors (6)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, AxisStrip clone)`
- `.ctor(UrbParams urb, String name, StripPosition position)`
- `.ctor(UrbParams urb, Double startStation, Double endStation)`
- `.ctor(UrbParams urb, String name, StripPosition position, Double startStation, Double endStation, Double offset)`
- `.ctor(UrbParams urb, String name, StripPosition position, StripExtension extension, Double startStation, Double endStation, Double offset)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Extension` | `StripExtension` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Position` | `StripPosition` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `UrbCategory` | `Int32` | `get` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `Boolean` | `Double deltaStation, ref IPolyline3D border` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `ICompoundLinearObject` | `GetPathList` |
| `ILinearObject` | `GetPolyline` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `UserSimpleStrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.UserSimpleStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UserStrips.UserStrip` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.UserStrips.UserStrip`
          - `Topomatic.Alg.Road.Urb.UserStrips.UserSimpleStrip`

#### Constructors (4)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, UserSimpleStrip clone)`
- `.ctor(UrbParams urb, Double startStation, Double endStation)`
- `.ctor(UrbParams urb, String name, String description, UserStripPosition position, UserStripPriority priority, StripHatch hatch, UserStripAppointment appointment, Boolean draw, Double startOtgon, Double startStation, Double endOtgon, Double endStation, Double width, Boolean fromCrossing)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `EndOtgon` | `Double` | `get/set` | No | `` |
| `EndStation` | `Double` | `get/set` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `StartOtgon` | `Double` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `Move` | `Boolean` | `Double deltaStation, ref IPolyline3D border` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `UserStrip` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.UserStrip` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.UserStrips.UserStrip`

#### Constructors (3)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, UserStrip clone)`
- `.ctor(UrbParams urb, String name, String description, UserStripPosition position, UserStripPriority priority, StripHatch stripHatch, UserStripAppointment appointment, Boolean draw, Boolean fromCrossing)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Appointment` | `UserStripAppointment` | `get/set` | No | `` |
| `Border` | `IPolyline3D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Draw` | `Boolean` | `get/set` | No | `` |
| `FromCrossing` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Position` | `UserStripPosition` | `get/set` | No | `` |
| `Priority` | `UserStripPriority` | `get/set` | No | `` |
| `StripHatch` | `StripHatch` | `get/set` | No | `` |
| `UrbCategory` | `Int32` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Move` | `Boolean` | `Double deltaStation, ref IPolyline3D border` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `ILinearObject` | `GetPolyline` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `UserStripAppointment` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.UserStripAppointment` |
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
      - `Topomatic.Alg.Road.Urb.UserStrips.UserStripAppointment`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DividingStrip` | `UserStripAppointment` | Yes | `DividingStrip` | `` |
| `TrafficStrip` | `UserStripAppointment` | Yes | `TrafficStrip` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DividingStrip` | `0` |
| `TrafficStrip` | `1` |

**Underlying Type**: `System.Int32`

### `UserStripPosition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.UserStripPosition` |
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
      - `Topomatic.Alg.Road.Urb.UserStrips.UserStripPosition`

#### Fields (13)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left1` | `UserStripPosition` | Yes | `Left1` | `` |
| `Left2` | `UserStripPosition` | Yes | `Left2` | `` |
| `Left3` | `UserStripPosition` | Yes | `Left3` | `` |
| `Left4` | `UserStripPosition` | Yes | `Left4` | `` |
| `Left5` | `UserStripPosition` | Yes | `Left5` | `` |
| `LeftCenter` | `UserStripPosition` | Yes | `LeftCenter` | `` |
| `Right1` | `UserStripPosition` | Yes | `Right1` | `` |
| `Right2` | `UserStripPosition` | Yes | `Right2` | `` |
| `Right3` | `UserStripPosition` | Yes | `Right3` | `` |
| `Right4` | `UserStripPosition` | Yes | `Right4` | `` |
| `Right5` | `UserStripPosition` | Yes | `Right5` | `` |
| `RightCenter` | `UserStripPosition` | Yes | `RightCenter` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LeftCenter` | `0` |
| `Left1` | `1` |
| `Left2` | `2` |
| `Left3` | `3` |
| `Left4` | `4` |
| `Left5` | `5` |
| `RightCenter` | `6` |
| `Right1` | `7` |
| `Right2` | `8` |
| `Right3` | `9` |
| `Right4` | `10` |
| `Right5` | `11` |

**Underlying Type**: `System.Int32`

### `UserStripPriority` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.UserStrips.UserStripPriority` |
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
      - `Topomatic.Alg.Road.Urb.UserStrips.UserStripPriority`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fisrt` | `UserStripPriority` | Yes | `Fisrt` | `` |
| `Fourth` | `UserStripPriority` | Yes | `Fourth` | `` |
| `Second` | `UserStripPriority` | Yes | `Second` | `` |
| `Third` | `UserStripPriority` | Yes | `Third` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Fisrt` | `0` |
| `Second` | `1` |
| `Third` | `2` |
| `Fourth` | `3` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Alg.Road.Urb.Virage`

### `GradeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.GradeType` |
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
      - `Topomatic.Alg.Road.Urb.Virage.GradeType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Div` | `GradeType` | Yes | `Div` | `` |
| `Heights` | `GradeType` | Yes | `Heights` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Div` | `0` |
| `Heights` | `1` |

**Underlying Type**: `System.Int32`

### `Otgon` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.Virage+Otgon` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Virage.Virage+Otgon, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Virage.Virage+Otgon`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Otgon other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, Otgon defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Otgon` | `StgNode stgNode, Otgon defaultValue` | `` |
| `LoadFromStg` | `Otgon` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `Otgon otgonItem, StgNode stgNode, Otgon defaultValue` | `` |
| `SaveToStg` | `Void` | `Otgon otgonItem, StgNode stgNode` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndGrade` | `Double` | No | `` | `` |
| `KeepGrade` | `GradeType` | No | `` | `` |
| `LeftOffset` | `Double` | No | `` | `` |
| `OtgonFlags` | `OtgonFlags` | No | `` | `` |
| `OtgonMethod` | `OtgonMethod` | No | `` | `` |
| `OtgonType` | `OtgonType` | No | `` | `` |
| `RightOffset` | `Double` | No | `` | `` |
| `StartGrade` | `Double` | No | `` | `` |
| `WidthStation` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `OtgonFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.OtgonFlags` |
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
      - `Topomatic.Alg.Road.Urb.Virage.OtgonFlags`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ConsequentiallyStaX` | `OtgonFlags` | Yes | `ConsequentiallyStaX` | `` |
| `DivRotateGroundParallel` | `OtgonFlags` | Yes | `DivRotateGroundParallel` | `` |
| `None` | `OtgonFlags` | Yes | `None` | `` |
| `RotateGround` | `OtgonFlags` | Yes | `RotateGround` | `` |
| `RotateGroundParallel` | `OtgonFlags` | Yes | `RotateGroundParallel` | `` |
| `StandardStaX` | `OtgonFlags` | Yes | `StandardStaX` | `` |
| `UseDeltaDiv` | `OtgonFlags` | Yes | `UseDeltaDiv` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WithoutStaX` | `OtgonFlags` | Yes | `WithoutStaX` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `RotateGround` | `1` |
| `UseDeltaDiv` | `2` |
| `RotateGroundParallel` | `4` |
| `DivRotateGroundParallel` | `8` |
| `StandardStaX` | `16` |
| `WithoutStaX` | `32` |
| `ConsequentiallyStaX` | `64` |

**Underlying Type**: `System.Int32`

### `OtgonMethod` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.OtgonMethod` |
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
      - `Topomatic.Alg.Road.Urb.Virage.OtgonMethod`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RotateInEdge` | `OtgonMethod` | Yes | `RotateInEdge` | `` |
| `RotateManual` | `OtgonMethod` | Yes | `RotateManual` | `` |
| `RotateMiddle` | `OtgonMethod` | Yes | `RotateMiddle` | `` |
| `RotateOutEdge` | `OtgonMethod` | Yes | `RotateOutEdge` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RotateInEdge` | `0` |
| `RotateMiddle` | `1` |
| `RotateOutEdge` | `2` |
| `RotateManual` | `3` |

**Underlying Type**: `System.Int32`

### `OtgonType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.OtgonType` |
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
      - `Topomatic.Alg.Road.Urb.Virage.OtgonType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AnotherSideTwoRadius` | `OtgonType` | Yes | `AnotherSideTwoRadius` | `` |
| `AnotherSideTwoRadiusLength` | `OtgonType` | Yes | `AnotherSideTwoRadiusLength` | `` |
| `OneSideTwoRadiusLength` | `OtgonType` | Yes | `OneSideTwoRadiusLength` | `` |
| `RadiusLength` | `OtgonType` | Yes | `RadiusLength` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RadiusLength` | `0` |
| `OneSideTwoRadiusLength` | `1` |
| `AnotherSideTwoRadius` | `2` |
| `AnotherSideTwoRadiusLength` | `3` |

**Underlying Type**: `System.Int32`

### `Virage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.Virage` |
| **Base Type** | `Topomatic.Alg.Road.Urb.UrbObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Alg.IAlignmentContainer, Topomatic.FoundationClasses.IHandledObject, Topomatic.FoundationClasses.IOwned, System.IEquatable`1[[Topomatic.Alg.Road.Urb.UrbObject, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Road.Urb.UrbObject`
        - `Topomatic.Alg.Road.Urb.Virage.Virage`

#### Constructors (3)

- `.ctor(UrbParams urb)`
- `.ctor(UrbParams urb, Virage clone)`
- `.ctor(UrbParams urb, Double station)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cmin` | `Double` | `get/set` | No | `` |
| `ConstructionTable` | `IList<VirageConstructionItem>` | `get` | No | `` |
| `Custom` | `Boolean` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Direction` | `VirageDirection` | `get/set` | No | `` |
| `EndOtgon` | `Otgon` | `get/set` | No | `` |
| `Grade` | `Double` | `get/set` | No | `` |
| `GradeTable` | `IList<VirageGradeItem>` | `get` | No | `` |
| `Id` | `Guid` | `get/set` | No | `` |
| `IgnorePsp` | `Boolean` | `get/set` | No | `` |
| `KeepOnAuto` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `OnlyWidth` | `Boolean` | `get/set` | No | `` |
| `StartOtgon` | `Otgon` | `get/set` | No | `` |
| `Umin` | `Double` | `get/set` | No | `` |
| `UseCmin` | `Boolean` | `get/set` | No | `` |
| `WidthTable` | `IList<VirageWidthItem>` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanSplit` | `String` | `Double station` | `` |
| `Clone` | `UrbObject` | `UrbParams parent` | `` |
| `Equals` | `Boolean` | `UrbObject other` | `` |
| `JoinAsFirst` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length` | `` |
| `JoinAsSecond` | `Void` | `UrbParams urb, AlignmentJoinType joinType, Double length, Double second_length` | `` |
| `Move` | `UrbMoveState` | `Double station, Double delta` | `` |
| `ObjectInLimits` | `Boolean` | `Double minStation, Double maxStation, Boolean includeStart, Boolean includeEnd` | `` |
| `Split` | `Void` | `Double station, UrbParams before, UrbParams after` | `` |

#### Nested Types (1)

- `Otgon` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IHandledObject` | `get_Id` |
| `IHandledObject` | `set_Id` |
| `IEquatable`1` | `Equals` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `VirageCalcer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.VirageCalcer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Calculate` | `Void` | `IList<Virage> virages` | `` |
| `Calculate` | `Void` | `RoadAlignment alignment` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SIDE_OFFSET` | `Double` | Yes | `10` | `` |

### `VirageConstructionItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.VirageConstructionItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Virage.VirageConstructionItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Virage.VirageConstructionItem`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `VirageConstructionItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, VirageConstructionItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `VirageConstructionItem` | `StgNode stgNode, VirageConstructionItem defaultValue` | `` |
| `LoadFromStg` | `VirageConstructionItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `VirageConstructionItem node, StgNode stgNode, VirageConstructionItem defaultValue` | `` |
| `SaveToStg` | `Void` | `VirageConstructionItem node, StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ClElevation` | `Double` | No | `` | `` |
| `LeftSandGrade` | `Double` | No | `` | `` |
| `RightSandGrade` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `VirageDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.VirageDirection` |
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
      - `Topomatic.Alg.Road.Urb.Virage.VirageDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `VirageDirection` | Yes | `Left` | `` |
| `Right` | `VirageDirection` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |

**Underlying Type**: `System.Int32`

### `VirageGradeItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.VirageGradeItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Virage.VirageGradeItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Virage.VirageGradeItem`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `VirageGradeItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, VirageGradeItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `VirageGradeItem` | `StgNode stgNode, VirageGradeItem defaultValue` | `` |
| `LoadFromStg` | `VirageGradeItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `VirageGradeItem node, StgNode stgNode, VirageGradeItem defaultValue` | `` |
| `SaveToStg` | `Void` | `VirageGradeItem node, StgNode stgNode` | `` |

#### Fields (21)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftDivider` | `Double` | No | `` | `` |
| `LeftMain1` | `Double` | No | `` | `` |
| `LeftMain2` | `Double` | No | `` | `` |
| `LeftMain3` | `Double` | No | `` | `` |
| `LeftMain4` | `Double` | No | `` | `` |
| `LeftMain5` | `Double` | No | `` | `` |
| `LeftPsp` | `Double` | No | `` | `` |
| `LeftSide` | `Double` | No | `` | `` |
| `LeftSide1` | `Double` | No | `` | `` |
| `LeftSide3` | `Double` | No | `` | `` |
| `RightDivider` | `Double` | No | `` | `` |
| `RightMain1` | `Double` | No | `` | `` |
| `RightMain2` | `Double` | No | `` | `` |
| `RightMain3` | `Double` | No | `` | `` |
| `RightMain4` | `Double` | No | `` | `` |
| `RightMain5` | `Double` | No | `` | `` |
| `RightPsp` | `Double` | No | `` | `` |
| `RightSide` | `Double` | No | `` | `` |
| `RightSide1` | `Double` | No | `` | `` |
| `RightSide3` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `VirageWidthItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Urb.Virage.VirageWidthItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Alg.Road.Urb.Virage.VirageWidthItem, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Road.Urb.Virage.VirageWidthItem`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `VirageWidthItem other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode, VirageWidthItem defaultValue` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `VirageWidthItem` | `StgNode stgNode, VirageWidthItem defaultValue` | `` |
| `LoadFromStg` | `VirageWidthItem` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `VirageWidthItem node, StgNode stgNode, VirageWidthItem defaultValue` | `` |
| `SaveToStg` | `Void` | `VirageWidthItem node, StgNode stgNode` | `` |

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftCl` | `Double` | No | `` | `` |
| `LeftDivider` | `Double` | No | `` | `` |
| `LeftMain1` | `Double` | No | `` | `` |
| `LeftMain2` | `Double` | No | `` | `` |
| `LeftMain3` | `Double` | No | `` | `` |
| `LeftMain4` | `Double` | No | `` | `` |
| `LeftMain5` | `Double` | No | `` | `` |
| `LeftSide` | `Double` | No | `` | `` |
| `RightCl` | `Double` | No | `` | `` |
| `RightDivider` | `Double` | No | `` | `` |
| `RightMain1` | `Double` | No | `` | `` |
| `RightMain2` | `Double` | No | `` | `` |
| `RightMain3` | `Double` | No | `` | `` |
| `RightMain4` | `Double` | No | `` | `` |
| `RightMain5` | `Double` | No | `` | `` |
| `RightSide` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Alg.Road.Vcs`

### `RoadConflictResolver` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Vcs.RoadConflictResolver` |
| **Base Type** | `Topomatic.Alg.Vcs.AlgConflictResolver` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Vcs.AlgConflictResolver`
    - `Topomatic.Alg.Road.Vcs.RoadConflictResolver`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResolveConflict` | `Boolean` | `Alignment origin, Alignment local, Alignment remote, Alignment result, VcsContext context` | `` |

---
## Namespace: `Topomatic.Alg.Road.Volumes`

### `RoadSurfaceVolume` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Road.Volumes.RoadSurfaceVolume` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Alg.Road.Volumes.RoadSurfaceVolume, Topomatic.Alg.Road, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Road.Volumes.RoadSurfaceVolume`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, RoadSurfaceVolume volume)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomSurfaceRelativeUri` | `URI` | `get/set` | No | `` |
| `CutCode` | `Int32` | `get/set` | No | `` |
| `FillCode` | `Int32` | `get/set` | No | `` |
| `LayerName` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `TopSurfaceRelativeUri` | `URI` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `RoadSurfaceVolume other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 151 |
| **Classes** | 64 |
| **Interfaces** | 0 |
| **Enums** | 50 |
| **Structs** | 26 |
| **Abstract Classes** | 5 |
| **Static Classes** | 6 |
| **Total Methods** | 657 |
| **Total Properties** | 595 |
| **Total Fields** | 866 |
| **Total Events** | 3 |
| **Total Constructors** | 144 |
| **Nested Types** | 11 |
| **Extension Methods** | 0 |


