# Topomatic.Culverts

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Culverts` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Culverts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Culverts.dll` |

---
## Namespace: `Topomatic.Culverts`

### `BlockTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.BlockTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (33)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddHatch` | `Void` | `String pattern, Double scalePattern, DwgPolyline l, DwgBlock result` | `` |
| `AddHatchAndContour` | `Void` | `String pattern, Double scalePattern, DwgPolyline l, DwgBlock result` | `` |
| `BuildLineOfSquare` | `List<Vector2D[]>` | `Vector2D[] frame, Vector2D[] axis, Int32 count, Double distanceBetweenWidth, Double horizontalScale` | `` |
| `BuildLineOfSquare` | `List<Vector2D[]>` | `Vector2D[] axis, Double[] horizontal, Double[] vertical, Double distanceBetween` | `` |
| `BuildLineOfSquare` | `List<Vector2D[]>` | `Vector2D[] axis, Double[] horizontal, Double[] vertical, Double distanceBetweenHorizontal, Double distanceBetweenVertical` | `` |
| `ClearDictionary` | `Void` | `Drawing drawing, Predicate<String> match` | `` |
| `ClearDrawing` | `Void` | `Drawing drawing` | `` |
| `Clip` | `List<DwgEntity>` | `DwgBlock block, Vector2D pos, Vector2D normal` | `` |
| `ConvertToSizeMM` | `String` | `Double value` | `` |
| `CreateCompoundBlock` | `DwgBlock` | `Drawing drawing` | `` |
| `CreateLeader` | `DwgLeader` | `DynamicComponent data, Double height` | `` |
| `CreateLeader` | `DwgLeader` | `DynamicComponent data` | `` |
| `CreateSystemBlock` | `DwgBlock` | `Drawing drawing, String prefix` | `` |
| `CreateTableBlock` | `DwgTable` | `Drawing drawing, String id` | `` |
| `CreateText` | `DwgText` | `DynamicComponent data` | `` |
| `CreateText` | `DwgText` | `DynamicComponent data, Double height, TextAlignment justify, Double ratio` | `` |
| `GetOrCreatePropertiesDictionary` | `DwgDictionary` | `Drawing source, String propertyKey, ImProperties properties` | `` |
| `GetPrepareGrade` | `String` | `Double grade, Boolean inceptionRequired, Int32 digit` | `` |
| `GetTables` | `KeyValuePair<DwgTable String>[]` | `Drawing drawing, String[] ids` | `` |
| `GetValidPropertyKey` | `String` | `String key` | `` |
| `InitalizeProps` | `Void` | `DwgEntity entity, String propsKey` | `` |
| `Mirror` | `Void` | `DwgEntities source, Int32 indexFrom, DwgBlock result` | `` |
| `Mirror` | `DwgBlock` | `DwgBlock source` | `` |
| `MirrorOXOY` | `Void` | `DwgEntities source, Int32 indexFrom, DwgBlock result` | `` |
| `MirrorVertical` | `DwgBlock` | `DwgBlock source` | `` |
| `MirrorVertical` | `Void` | `DwgEntities source, Int32 indexFrom, DwgBlock result` | `` |
| `PackProperties` | `String` | `Drawing source, String name, String prefix, ImProperties properties` | `` |
| `ParseGrade` | `String` | `Vector2D from, Vector2D to, Boolean inceptionRequired, Int32 digit` | `` |
| `ParseIncline` | `Double` | `Vector2D from, Vector2D to` | `` |
| `PreparePrism` | `Vector2D[]` | `Vector2D v1, Vector2D v2, Vector2D v3, Vector2D v4` | `` |
| `SetSignedEntity` | `Void` | `DwgEntity entity, String id` | `` |
| `TryGetCulvertPlaceData` | `Boolean` | `Alignment alg, Double station, ref Vector2D centerPoint, ref Vector2D directionPoint, ref Double angle` | `` |
| `UnpackProperties` | `List<ModelPropertyItem>` | `Drawing source, String propKey, ref String name` | `` |

### `ClvArrangement` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ClvArrangement` |
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
      - `Topomatic.Culverts.ClvArrangement`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BySlope` | `ClvArrangement` | Yes | `BySlope` | `` |
| `BySteps` | `ClvArrangement` | Yes | `BySteps` | `` |
| `None` | `ClvArrangement` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `BySlope` | `1` |
| `BySteps` | `2` |

**Underlying Type**: `System.Int32`

### `ClvBindingMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ClvBindingMode` |
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
      - `Topomatic.Culverts.ClvBindingMode`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlgCrossSection` | `ClvBindingMode` | Yes | `AlgCrossSection` | `` |
| `AlgStationAndAngle` | `ClvBindingMode` | Yes | `AlgStationAndAngle` | `` |
| `Empty` | `ClvBindingMode` | Yes | `Empty` | `` |
| `SfcSection` | `ClvBindingMode` | Yes | `SfcSection` | `` |
| `StaticSurfaces` | `ClvBindingMode` | Yes | `StaticSurfaces` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `AlgCrossSection` | `1` |
| `AlgStationAndAngle` | `2` |
| `SfcSection` | `3` |
| `StaticSurfaces` | `4` |

**Underlying Type**: `System.Int32`

### `ClvElementTags` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ClvElementTags` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (28)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BANDAGE` | `String` | Yes | `"bandage"` | `` |
| `BORDERING_ANGLE` | `String` | Yes | `"BORDERING_ANGLE"` | `` |
| `HEADER_SHEET` | `String` | Yes | `"header_sheet"` | `` |
| `INPUT_HEADER` | `String` | Yes | `"input_header"` | `` |
| `INPUT_HEADER_BASE` | `String` | Yes | `"input_header_base"` | `` |
| `INPUT_HEADER_SHELL` | `String` | Yes | `"input_header_shell"` | `` |
| `INPUT_SLOPE_P1_PLATE_TAG` | `String` | Yes | `"input_slope_p1_plate"` | `` |
| `INPUT_SLOPE_STREN_SHELL` | `String` | Yes | `"input_slope_stren_shell"` | `` |
| `INPUT_STREN` | `String` | Yes | `"input_stren"` | `` |
| `INPUT_STREN_CUTTING_SOLID` | `String` | Yes | `"input_stren_cutting_solid"` | `` |
| `INPUT_STREN_INITIAL_CONCRETE_LAYER` | `String` | Yes | `"input_stren_initial_concrete_layer"` | `` |
| `INPUT_STREN_INITIAL_RUBBLE_LAYER` | `String` | Yes | `"input_stren_initial_rubble_layer"` | `` |
| `MIDDLE_PART` | `String` | Yes | `"middle_part"` | `` |
| `MIDDLE_PART_BASE` | `String` | Yes | `"middle_part_base"` | `` |
| `MIDDLE_PART_SHELL` | `String` | Yes | `"middle_part_shell"` | `` |
| `OUTPUT_HEADER` | `String` | Yes | `"output_header"` | `` |
| `OUTPUT_HEADER_BASE` | `String` | Yes | `"output_header_base"` | `` |
| `OUTPUT_HEADER_SHELL` | `String` | Yes | `"output_header_shell"` | `` |
| `OUTPUT_SLOPE_P1_PLATE_TAG` | `String` | Yes | `"output_slope_p1_plate"` | `` |
| `OUTPUT_SLOPE_STREN_SHELL` | `String` | Yes | `"output_slope_stren_shell"` | `` |
| `OUTPUT_STREN` | `String` | Yes | `"output_stren"` | `` |
| `OUTPUT_STREN_CUTTING_SOLID` | `String` | Yes | `"output_stren_cutting_solid"` | `` |
| `OUTPUT_STREN_INITIAL_CONCRETE_LAYER` | `String` | Yes | `"output_stren_initial_concrete_layer"` | `` |
| `OUTPUT_STREN_INITIAL_RUBBLE_LAYER` | `String` | Yes | `"output_stren_initial_rubble_layer"` | `` |
| `RECONSTRUCTION_EXISTING_BASE` | `String` | Yes | `"reconstruction_existing_base"` | `` |
| `SECTION` | `String` | Yes | `"section"` | `` |
| `SHEET` | `String` | Yes | `"sheet"` | `` |
| `STREN_END_ELEMENT` | `String` | Yes | `"stren_end_element"` | `` |

### `Construction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Construction` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Culverts.ConstructionComponent, Topomatic.Culverts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Construction`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Arrangement` | `ClvArrangement` | `get/set` | No | `` |
| `Culvert` | `Culvert` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `DwgComponents` | `DwgComponents` | `get` | No | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Messages` | `List<Message>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `State` | `ConstructionState` | `get` | No | `` |
| `TreeOperations` | `IList<ClvTreeOperation>` | `get` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddComponent` | `T` | `` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `CreateCompoundModel` | `ImElement` | `` | `` |
| `CreateSpecificationDataset` | `List<RowData>` | `String tableId, SpecificationType specType` | `` |
| `EvaluateDynamicData` | `String` | `DieselEngine engine, String expression` | `` |
| `FindComponent` | `T` | `Predicate<T> match` | `` |
| `FindComponents` | `List<T>` | `` | `` |
| `GetDwgComponents` | `List<DwgComponent>` | `DwgKeys key` | `` |
| `GetDwgEntities` | `EntityCollection<DwgEntity>` | `DwgKeys key` | `` |
| `GetDynamicComponents` | `List<DynamicComponent>` | `DwgKeys key` | `` |
| `GetDynamicData` | `IDictionary<String String>` | `DieselEngine engine` | `` |
| `GetDynamicDataValue` | `String` | `DieselEngine engine, String key, String defaultValue` | `` |
| `GetEnumerator` | `IEnumerator<ConstructionComponent>` | `` | `` |
| `GetRootElement` | `ClvElement` | `` | `` |
| `GetSelectableElements` | `List<ClvElement>` | `ClvView view` | `` |
| `GetSpecifications` | `IEnumerable<ComponentSpecification>` | `SpecificationType type` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetRootElement` | `Void` | `ClvElement element` | `` |
| `TryGetDataValue` | `Boolean` | `String key, ref T value` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `MessagesUpdated` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IDrawingContainer` | `get_Drawing` |
| `ICulvertContainer` | `get_Culvert` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `ConstructionComponent` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionComponent` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Construction` | `Construction` | `get` | No | `` |
| `Culvert` | `Culvert` | `get` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `Construction owner, StgNode node, ISerializationContext context, ref ConstructionComponent component` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IDrawingContainer` | `get_Drawing` |
| `ICulvertContainer` | `get_Culvert` |

### `ConstructionState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionState` |
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
      - `Topomatic.Culverts.ConstructionState`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Invalidate` | `ConstructionState` | Yes | `Invalidate` | `` |
| `ReadOnly` | `ConstructionState` | Yes | `ReadOnly` | `` |
| `Ready` | `ConstructionState` | Yes | `Ready` | `` |
| `Refreshing` | `ConstructionState` | Yes | `Refreshing` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Invalidate` | `0` |
| `Refreshing` | `1` |
| `Ready` | `2` |
| `ReadOnly` | `3` |

**Underlying Type**: `System.Int32`

### `Culvert` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Culvert` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Culverts.ICulvertContainer, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IStateController, Topomatic.Culverts.IDynamicSection, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Culvert`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (32)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlbumGuid` | `Guid` | `get/set` | No | `` |
| `AlbumName` | `String` | `get/set` | No | `` |
| `Aliace` | `String` | `get/set` | No | `` |
| `BuildDetails` | `String` | `get/set` | No | `` |
| `Construction` | `Construction` | `get` | No | `` |
| `Diameter` | `Double` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `ExtendedGrips` | `Boolean` | `get/set` | No | `` |
| `Hole` | `ValuePerValue` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `HoleType` | `HoleType` | `get/set` | No | `` |
| `IsRotatedPlanCaption` | `Boolean` | `get/set` | No | `` |
| `LeaderText` | `String` | `get/set` | No | `` |
| `Modified` | `Boolean` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Place` | `Place` | `get` | No | `` |
| `PlanCaptionSide` | `PlanCaptionSide` | `get/set` | No | `` |
| `PlanCaptionSta` | `Double` | `get/set` | No | `` |
| `PlanSectionEndLeader` | `LeaderInfo` | `get/set` | No | `` |
| `PlanSectionStartLeader` | `LeaderInfo` | `get/set` | No | `` |
| `PrecisionStyle` | `PrecisionStyle` | `get` | No | `` |
| `Prism` | `Prism` | `get` | No | `` |
| `ProfileElementSelectionStatus` | `Boolean` | `get/set` | No | `` |
| `PropertiesKey` | `String` | `get/set` | No | `` |
| `ReadOnly` | `Boolean` | `get/set` | No | `` |
| `Reconstruction` | `Reconstruction` | `get` | No | `` |
| `ReportTemplate` | `String[]` | `get/set` | No | `` |
| `Restrictions` | `Restrictions` | `get` | No | `` |
| `SectionInfo` | `SectionInfo` | `get` | No | `` |
| `SectSurfaces` | `IList<String>` | `get` | No | `` |
| `SheetContext` | `SheetContext` | `get` | No | `` |
| `Simplified3DRepresentation` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateShell` | `Shell` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `ProfileElementSelectionStatusChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICulvertContainer` | `Topomatic.Culverts.ICulvertContainer.get_Culvert` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStateController` | `get_Modified` |
| `IStateController` | `set_Modified` |
| `IStateController` | `get_ReadOnly` |
| `IStateController` | `set_ReadOnly` |
| `IDynamicSection` | `get_SectionInfo` |
| `IDrawingContainer` | `get_Drawing` |

### `CulvertConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.CulvertConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (60)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ARRANGEMENT_DELTA_Z` | `String` | Yes | `"arrangement_delta_z"` | `` |
| `ARRANGEMENT_EDITABLE` | `String` | Yes | `"arrangement_editable"` | `` |
| `ASPHALT_PLANK_HEIGTH` | `Double` | Yes | `0.03` | `` |
| `BED_INSIDE_LEFT` | `String` | Yes | `"BED_INSIDE_LEFT"` | `` |
| `BED_INSIDE_RIGHT` | `String` | Yes | `"BED_INSIDE_RIGHT"` | `` |
| `BED_OUTSIDE_LEFT` | `String` | Yes | `"BED_OUTSIDE_LEFT"` | `` |
| `BED_OUTSIDE_RIGHT` | `String` | Yes | `"BED_OUTSIDE_RIGHT"` | `` |
| `DYNAMIC_MODELS_DATA` | `String` | Yes | `"dynamic_models_data"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_LINK_LEFT` | `String` | Yes | `"excavation_pit_header_width_link_left"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_LINK_RIGHT` | `String` | Yes | `"excavation_pit_header_width_link_right"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_PORTAL_LEFT` | `String` | Yes | `"excavation_pit_header_width_portal_left"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_PORTAL_RIGHT` | `String` | Yes | `"excavation_pit_header_width_portal_right"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_SLOPE_LEFT` | `String` | Yes | `"excavation_pit_header_width_slope_left"` | `` |
| `EXCAVATION_PIT_HEADER_WIDTH_SLOPE_RIGHT` | `String` | Yes | `"excavation_pit_header_width_slope_right"` | `` |
| `FACADE_SCHEME_INPUT` | `String` | Yes | `"*SECTION_SCHEME"` | `` |
| `FACADE_SCHEME_OUTPUT` | `String` | Yes | `"FACADE_SCHEME_OUTPUT"` | `` |
| `FILL_HEIGHT` | `String` | Yes | `"fill_height"` | `` |
| `FOUNDATION_BOTTOM` | `String` | Yes | `"foundation_bottom"` | `` |
| `H3_POSITION` | `String` | Yes | `"h3_position"` | `` |
| `HEAD_INSIDE_LEFT` | `String` | Yes | `"HEAD_INSIDE_LEFT"` | `` |
| `HEAD_INSIDE_RIGHT` | `String` | Yes | `"HEAD_INSIDE_RIGHT"` | `` |
| `HEAD_OUTSIDE_LEFT` | `String` | Yes | `"HEAD_OUTSIDE_LEFT"` | `` |
| `HEAD_OUTSIDE_RIGHT` | `String` | Yes | `"HEAD_OUTSIDE_RIGHT"` | `` |
| `HEADER_BOTTOM` | `String` | Yes | `"header_bottom"` | `` |
| `HEADER_OFFSETS` | `String` | Yes | `"header_offsets"` | `` |
| `HEADER_TOP_FORTIFICATION` | `String` | Yes | `"header_top_fortification"` | `` |
| `HOLE_COUNT` | `String` | Yes | `"hole_count"` | `` |
| `INPUT_STRENGTHENING_BERM_END` | `String` | Yes | `"input_strengthening_berm_end"` | `` |
| `INPUT_STRENGTHENING_BERM_START` | `String` | Yes | `"input_strengthening_berm_start"` | `` |
| `INPUT_STRENGTHENING_SLOPE_TOP` | `String` | Yes | `"input_strengthening_slope_top"` | `` |
| `LENGTH` | `String` | Yes | `"length"` | `` |
| `MIDDLE_PART_AXIS` | `String` | Yes | `"middle_axis"` | `` |
| `MIDDLE_PART_DISTANCE_BETWEEN_SECTION` | `Double` | Yes | `0.03` | `` |
| `MIDDLE_PART_FOUNDATION_OFFSET` | `String` | Yes | `"middle_part_foundation_offset"` | `` |
| `MIDDLE_PART_HEADER_OFFSETS` | `String` | Yes | `"middle_offsets"` | `` |
| `MIDDLE_PART_LINK_STRUCTURE` | `String` | Yes | `"middle_links_structure"` | `` |
| `MIDDLE_PART_LINKS_COUNT` | `String` | Yes | `"middle_links_count"` | `` |
| `MIDDLE_PART_SECTION_WIDTH` | `String` | Yes | `"middle_part_section_width"` | `` |
| `MIDDLE_PART_STEPS` | `String` | Yes | `"middle_part_steps"` | `` |
| `MODEL_TYPE` | `String` | Yes | `"culvert"` | `` |
| `OUTPUT_STRENGTHENING_BERM_END` | `String` | Yes | `"output_strengthening_berm_end"` | `` |
| `OUTPUT_STRENGTHENING_BERM_START` | `String` | Yes | `"output_strengthening_berm_start"` | `` |
| `OUTPUT_STRENGTHENING_SLOPE_TOP` | `String` | Yes | `"output_strengthening_slope_top"` | `` |
| `P1_FORTIFICATION_CARD_HEIGHT` | `Double` | Yes | `0.55` | `` |
| `P1_HEIGHT` | `Double` | Yes | `0.49` | `` |
| `P1_WIDTH` | `Double` | Yes | `0.49` | `` |
| `PATTERN_HATCH_MONOLIT` | `String` | Yes | `"ANSI31"` | `` |
| `PLAN_AXIS_DESIGN_STANDARD` | `String` | Yes | `"culvert_plan_axis"` | `` |
| `PLAN_BED_WIDTH` | `String` | Yes | `"PLAN_BED_WIDTH"` | `` |
| `PLAN_CAPTION_STANDARD` | `String` | Yes | `"culvert_plan_caption"` | `` |
| `PLAN_DESIGN_STANDARD` | `String` | Yes | `"culvert_plan"` | `` |
| `PLAN_ELEVATIONS_STANDARD` | `String` | Yes | `"culvert_plan_elevations"` | `` |
| `PLAN_MIDDLE_FOUNDATION_WIDTH` | `String` | Yes | `"PLAN_MIDDLE_FOUNDATION_WIDTH"` | `` |
| `PLAN_SIMPLIFIED_REPRESENTATION_STANDARD` | `String` | Yes | `"culvert_plan_simplified_representation"` | `` |
| `PROPERTIES_KEY` | `String` | Yes | `"props"` | `` |
| `SCALED_HEADER_OFFSETS` | `String` | Yes | `"SCALED_HEADER_OFFSETS"` | `` |
| `TASK_ALBUMS` | `String` | Yes | `"culvert_albums"` | `` |
| `TEXT_HEIGHT` | `Double` | Yes | `0.25` | `` |
| `TRAY_LEFT_POS` | `String` | Yes | `"tray_left_pos"` | `` |
| `TRAY_RIGHT_POS` | `String` | Yes | `"tray_right_pos"` | `` |

### `DismantileLink` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ReconstructionPart+DismantileLink` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.ReconstructionPart+DismantileLink`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DismantileLink` | `StgNode node, ISerializationContext context` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DistanceBetween` | `Double` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `Length` | `Double` | No | `` | `` |
| `Model` | `ImElement` | No | `` | `` |
| `PropertyKey` | `String` | No | `` | `` |
| `Width` | `Double` | No | `` | `` |

### `DwgEntityType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DwgEntityType` |
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
      - `Topomatic.Culverts.DwgEntityType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dimension` | `DwgEntityType` | Yes | `Dimension` | `` |
| `Leader` | `DwgEntityType` | Yes | `Leader` | `` |
| `Text` | `DwgEntityType` | Yes | `Text` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Dimension` | `0` |
| `Leader` | `1` |
| `Text` | `2` |

**Underlying Type**: `System.Int32`

### `DwgKeys` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DwgKeys` |
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
      - `Topomatic.Culverts.DwgKeys`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CamberScheme` | `DwgKeys` | Yes | `CamberScheme` | `` |
| `CulvertConstruction` | `DwgKeys` | Yes | `CulvertConstruction` | `` |
| `CulvertFacade` | `DwgKeys` | Yes | `CulvertFacade` | `` |
| `CulvertPlan` | `DwgKeys` | Yes | `CulvertPlan` | `` |
| `CulvertProfile` | `DwgKeys` | Yes | `CulvertProfile` | `` |
| `CulvertSection` | `DwgKeys` | Yes | `CulvertSection` | `` |
| `None` | `DwgKeys` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `CulvertPlan` | `1` |
| `CulvertProfile` | `2` |
| `CulvertConstruction` | `3` |
| `CulvertSection` | `4` |
| `CamberScheme` | `5` |
| `CulvertFacade` | `6` |

**Underlying Type**: `System.Int32`

### `DynamicComponent` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DynamicComponent` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.DynamicComponent`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `DynamicComponent result` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DynamicComponent` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `DynamicComponent value, StgNode node` | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BasePoints` | `List<Vector2D>` | No | `` | `` |
| `EntityType` | `DwgEntityType` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `Id` | `String` | No | `` | `` |
| `Justify` | `TextAlignment` | No | `` | `` |
| `Mirror` | `Boolean` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `SourceType` | `DynamicComponentType` | No | `` | `` |
| `Text` | `String` | No | `` | `` |
| `TextRotation` | `Double` | No | `` | `` |
| `UpperPoints` | `List<Vector2D>` | No | `` | `` |

### `DynamicComponents` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DynamicComponents` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Culverts.DynamicComponent, Topomatic.Culverts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Culverts.DynamicComponents`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `DynamicComponent` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDimension` | `Void` | `DynamicComponent dimension` | `` |
| `Filter` | `Void` | `IList<DynamicComponent> dimensions, DynamicComponentType type` | `` |
| `GetEnumerator` | `IEnumerator<DynamicComponent>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `DynamicComponentType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DynamicComponentType` |
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
      - `Topomatic.Culverts.DynamicComponentType`

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DimensionInputFacade` | `DynamicComponentType` | Yes | `DimensionInputFacade` | `` |
| `DimensionOutputFacade` | `DynamicComponentType` | Yes | `DimensionOutputFacade` | `` |
| `DimensionPlan` | `DynamicComponentType` | Yes | `DimensionPlan` | `` |
| `DimensionProfile` | `DynamicComponentType` | Yes | `DimensionProfile` | `` |
| `DimensionSection` | `DynamicComponentType` | Yes | `DimensionSection` | `` |
| `LeaderInputFacade` | `DynamicComponentType` | Yes | `LeaderInputFacade` | `` |
| `LeaderOutputFacade` | `DynamicComponentType` | Yes | `LeaderOutputFacade` | `` |
| `LeaderPlan` | `DynamicComponentType` | Yes | `LeaderPlan` | `` |
| `LeaderProfile` | `DynamicComponentType` | Yes | `LeaderProfile` | `` |
| `LeaderSection` | `DynamicComponentType` | Yes | `LeaderSection` | `` |
| `TextInputFacade` | `DynamicComponentType` | Yes | `TextInputFacade` | `` |
| `TextOutputFacade` | `DynamicComponentType` | Yes | `TextOutputFacade` | `` |
| `TextPlan` | `DynamicComponentType` | Yes | `TextPlan` | `` |
| `TextProfile` | `DynamicComponentType` | Yes | `TextProfile` | `` |
| `TextScheme` | `DynamicComponentType` | Yes | `TextScheme` | `` |
| `TextSection` | `DynamicComponentType` | Yes | `TextSection` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DimensionPlan` | `0` |
| `DimensionProfile` | `1` |
| `DimensionSection` | `2` |
| `DimensionInputFacade` | `3` |
| `LeaderPlan` | `4` |
| `LeaderProfile` | `5` |
| `LeaderSection` | `6` |
| `LeaderInputFacade` | `7` |
| `TextPlan` | `8` |
| `TextProfile` | `9` |
| `TextSection` | `10` |
| `TextScheme` | `11` |
| `LeaderOutputFacade` | `12` |
| `DimensionOutputFacade` | `13` |
| `TextInputFacade` | `14` |
| `TextOutputFacade` | `15` |

**Underlying Type**: `System.Int32`

### `DynamicDataScope` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.DynamicDataScope` |
| **Base Type** | `Topomatic.FoundationClasses.Diesel.DieselScope` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.Diesel.DieselScope`
    - `Topomatic.Culverts.DynamicDataScope`

#### Constructors (1)

- `.ctor(Construction construction)`

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `String key` | `` |
| `Evaluate` | `String` | `DieselEngine engine, String expression` | `` |
| `GetDoubleValue` | `Nullable<Double>` | `DieselEngine engine, String key` | `` |
| `GetFunction` | `DieselFunction` | `String name` | `` |
| `GetValue` | `String` | `DieselEngine engine, String key, String defaultValue` | `` |
| `GetValues` | `IDictionary<String String>` | `DieselEngine engine` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RegisterConst` | `Void` | `String key, Int32 volume` | `` |
| `RegisterConst` | `Void` | `String key, String volume` | `` |
| `RegisterConst` | `Void` | `String key, Double volume` | `` |
| `RegisterElementsCount` | `Void` | `String key, String[] elementTags` | `` |
| `RegisterElevation` | `Void` | `String keyValue, String keyRound, Double value` | `` |
| `RegisterExpression` | `Void` | `String key, String expression` | `` |
| `RegisterGrade` | `Void` | `String keyValue, String keyRound, Double value` | `` |
| `RegisterLength` | `Void` | `String keyValue, String keyRound, Double value` | `` |
| `RegisterSumOfImProps` | `Void` | `String key, String propertyTag, String[] elementTags` | `` |
| `Remove` | `Boolean` | `String key` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `ExcavationCalculateType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ExcavationCalculateType` |
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
      - `Topomatic.Culverts.ExcavationCalculateType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ground` | `ExcavationCalculateType` | Yes | `Ground` | `` |
| `Project` | `ExcavationCalculateType` | Yes | `Project` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Project` | `0` |
| `Ground` | `1` |

**Underlying Type**: `System.Int32`

### `HoleType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.HoleType` |
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
      - `Topomatic.Culverts.HoleType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `HoleType` | Yes | `Empty` | `` |
| `Rect` | `HoleType` | Yes | `Rect` | `` |
| `Round` | `HoleType` | Yes | `Round` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Round` | `1` |
| `Rect` | `2` |

**Underlying Type**: `System.Int32`

### `ICulvertContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ICulvertContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |

### `IDynamicSection` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.IDynamicSection` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SectionInfo` | `SectionInfo` | `get` | No | `` |

### `LeaderInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.LeaderInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.LeaderInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `LeaderInfo` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Mirror` | `Boolean` | No | `` | `` |
| `Offset` | `Vector2D` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |

### `Message` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Message` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Message`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Message` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Level` | `TaskLevel` | No | `` | `` |
| `Text` | `String` | No | `` | `` |

### `PartState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ReconstructionPart+PartState` |
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
      - `Topomatic.Culverts.ReconstructionPart+PartState`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dismantile` | `PartState` | Yes | `Dismantile` | `` |
| `Exists` | `PartState` | Yes | `Exists` | `` |
| `NotExists` | `PartState` | Yes | `NotExists` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NotExists` | `0` |
| `Exists` | `1` |
| `Dismantile` | `2` |

**Underlying Type**: `System.Int32`

### `Place` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Place` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Culverts.Place`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |
| `EgSurfaces` | `IList<String>` | `get` | No | `` |
| `FgSurfaces` | `IList<String>` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PipeAlignmentAngle` | `Double` | `get/set` | No | `` |
| `StaticCenter` | `Vector2D` | `get/set` | No | `` |
| `StaticDirection` | `Vector2D` | `get/set` | No | `` |
| `StaticEg` | `CrsLine` | `get` | No | `` |
| `StaticFg` | `CrsLine` | `get` | No | `` |
| `StationStr` | `String` | `get/set` | No | `` |

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
| `ICulvertContainer` | `get_Culvert` |

### `PlanCaptionSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.PlanCaptionSide` |
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
      - `Topomatic.Culverts.PlanCaptionSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SectionEnd` | `PlanCaptionSide` | Yes | `SectionEnd` | `` |
| `SectionStart` | `PlanCaptionSide` | Yes | `SectionStart` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SectionStart` | `0` |
| `SectionEnd` | `1` |

**Underlying Type**: `System.Int32`

### `Prism` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Prism` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Prism`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CenterUrbPosition` | `Vector2D` | `get/set` | No | `` |
| `Culvert` | `Culvert` | `get` | No | `` |
| `CulvertArrangementAngle` | `Double` | `get` | No | `` |
| `CulvertArrangementOffs` | `Vector2D` | `get` | No | `` |
| `CulvertCenterPosition` | `Vector2D` | `get/set` | No | `` |
| `CulvertDirection` | `Vector2D` | `get/set` | No | `` |
| `LeftCulvertOffset` | `Double` | `get/set` | No | `` |
| `LeftCulvertPosition` | `Vector2D` | `get` | No | `` |
| `LeftLength` | `Double` | `get` | No | `` |
| `LeftSlopeDirection` | `Vector2D` | `get/set` | No | `` |
| `LeftSlopePosition` | `Vector2D` | `get/set` | No | `` |
| `LeftUrbPosition` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RightCulvertOffset` | `Double` | `get/set` | No | `` |
| `RightCulvertPosition` | `Vector2D` | `get` | No | `` |
| `RightLength` | `Double` | `get` | No | `` |
| `RightSlopeDirection` | `Vector2D` | `get/set` | No | `` |
| `RightSlopePosition` | `Vector2D` | `get/set` | No | `` |
| `RightUrbPosition` | `Vector2D` | `get/set` | No | `` |
| `ScaleFactor` | `Double` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyCulvertPointArrangementTransform` | `Vector2D` | `Vector2D culvertPoint` | `` |
| `CalcCulvertArrangementTransform` | `Matrix` | `` | `` |
| `IsLeftHeaderOutput` | `Boolean` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICulvertContainer` | `get_Culvert` |

### `Reconstruction` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Reconstruction` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Reconstruction`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |
| `Enabled` | `Boolean` | `get/set` | No | `` |
| `LeftDismantle` | `ReconstructionPart` | `get` | No | `` |
| `LeftManualOffset` | `Double` | `get/set` | No | `` |
| `LeftOffset` | `Double` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RightDismantle` | `ReconstructionPart` | `get` | No | `` |
| `RightManualOffset` | `Double` | `get/set` | No | `` |
| `RightOffset` | `Double` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ICulvertContainer` | `get_Culvert` |

### `ReconstructionPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ReconstructionPart` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Culverts.ReconstructionPart`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AddSlopeWall` | `DismantileLink` | `get/set` | No | `` |
| `Culvert` | `Culvert` | `get` | No | `` |
| `Links` | `IList<DismantileLink>` | `get` | No | `` |
| `MainSlopeWall` | `DismantileLink` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Portal` | `DismantileLink` | `get/set` | No | `` |
| `PortalState` | `PartState` | `get/set` | No | `` |
| `SlopeState` | `PartState` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Nested Types (2)

- `DismantileLink` (struct)
- `PartState` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |
| `ICulvertContainer` | `get_Culvert` |

### `Restrictions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Restrictions` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Culverts.Restrictions`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Culvert` | `Culvert` | `get` | No | `` |
| `HorizontalDistance` | `Double` | `get/set` | No | `` |
| `MaximumGrade` | `Double` | `get/set` | No | `` |
| `MinimumGrade` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `StandardBermLength` | `Double` | `get/set` | No | `` |
| `StandardSlopeGrade` | `Double` | `get/set` | No | `` |
| `VerticalDistance` | `Double` | `get/set` | No | `` |

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
| `ICulvertContainer` | `get_Culvert` |

### `SectionInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.SectionInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.SectionInfo`

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AXIS` | `Int32` | Yes | `0` | `` |
| `AxisPoints` | `Vector2D[]` | No | `` | `` |
| `Center` | `Vector2D` | No | `` | `` |
| `Direction` | `Vector2D` | No | `` | `` |
| `Eg` | `CrsLineNode[]` | No | `` | `` |
| `EgElevation` | `Double` | No | `` | `` |
| `Fg` | `CrsLineNode[]` | No | `` | `` |
| `FgElevation` | `Double` | No | `` | `` |
| `Handle` | `UInt32` | No | `` | `` |
| `LEDGE` | `Int32` | Yes | `1` | `` |
| `LFOOT` | `Int32` | Yes | `3` | `` |
| `PipeAlignmentAngle` | `Double` | No | `` | `` |
| `REDGE` | `Int32` | Yes | `2` | `` |
| `RFOOT` | `Int32` | Yes | `4` | `` |

### `SmdxProps` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.SmdxProps` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HEAD_KIND_INLET` | `String` | Yes | `"INLET"` | `` |
| `HEAD_KIND_OUTLET` | `String` | Yes | `"OUTLET"` | `` |
| `PROP_NAME_HEAD_KIND` | `String` | Yes | `"Вид оголовка"` | `` |
| `PROP_TAG_HEAD_KIND` | `String` | Yes | `"headkind"` | `` |

### `SmdxTypes` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.SmdxTypes` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SmdxCulvertConstructionElement` | `String` | Yes | `"SmdxCulvertConstructionElement"` | `` |
| `SmdxCulvertHead` | `String` | Yes | `"SmdxCulvertHead"` | `` |
| `SmdxCulvertMiddle` | `String` | Yes | `"SmdxCulvertMiddle"` | `` |
| `SmdxCulvertModel` | `String` | Yes | `"SmdxCulvertModel"` | `` |
| `SmdxCulvertSection` | `String` | Yes | `"SmdxCulvertSection"` | `` |
| `SmdxCulvertStrengthening` | `String` | Yes | `"SmdxCulvertStrengthening"` | `` |
| `SmdxEntity` | `String` | Yes | `"SmdxEntity"` | `` |

### `StgTools` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.StgTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ImElement` | `StgNode node, String guidKey, String modelKey, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `ImElement model, StgNode node, String modelKey, ISerializationContext context` | `Extension` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CONTEXT_NAME` | `String` | Yes | `"Context"` | `` |

### `UnitsPerValue` (struct)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.UnitsPerValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.UnitsPerValue`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `UnitsPerValue` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `UnitsPerValue value, StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Units` | `Int32` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

### `UnitsPerValueConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.UnitsPerValueConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Culverts.UnitsPerValueConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `ValuePerValue` (struct)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ValuePerValue` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IComparable`1[[Topomatic.Culverts.ValuePerValue, Topomatic.Culverts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.ValuePerValue`

#### Constructors (1)

- `.ctor(Double value1, Double value2)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Empty` | `ValuePerValue` | `get` | Yes | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompareTo` | `Int32` | `ValuePerValue other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ValuePerValue` | `StgNode node, ValuePerValue defaultValue` | `` |
| `LoadFromStg` | `ValuePerValue` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `ValuePerValue value, StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Value1` | `Double` | No | `` | `` |
| `Value2` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IComparable`1` | `CompareTo` |

### `ValuePerValueConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ValuePerValueConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Culverts.ValuePerValueConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

### `VolumeConstsGlobal` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.VolumeConstsGlobal` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (396)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `_ROUND` | `String` | Yes | `"_round"` | `` |
| `_VALUE` | `String` | Yes | `"_value"` | `` |
| `ALBUM_INPUT_HEADER_RUBBLE_HEIGHT_ROUND` | `String` | Yes | `"album_input_header_rubble_height_round"` | `` |
| `ALBUM_INPUT_HEADER_RUBBLE_HEIGHT_VALUE` | `String` | Yes | `"album_input_header_rubble_height_value"` | `` |
| `ALBUM_OUTPUT_HEADER_RUBBLE_HEIGHT_ROUND` | `String` | Yes | `"album_output_header_rubble_height_round"` | `` |
| `ALBUM_OUTPUT_HEADER_RUBBLE_HEIGHT_VALUE` | `String` | Yes | `"album_output_header_rubble_height_value"` | `` |
| `BEAM_THICKNESS_ROUND` | `String` | Yes | `"beam_thickness_round"` | `` |
| `BEAM_THICKNESS_VALUE` | `String` | Yes | `"beam_thickness_value"` | `` |
| `CEMENT_EARTH_HEADER_ROUND` | `String` | Yes | `"cement_earth_header_round"` | `` |
| `CEMENT_EARTH_HEADER_VALUE` | `String` | Yes | `"cement_earth_header_value"` | `` |
| `CEMENT_M200_HEADER_ROUND` | `String` | Yes | `"cement_m200_header_round"` | `` |
| `CEMENT_M200_HEADER_VALUE` | `String` | Yes | `"cement_m200_header_value"` | `` |
| `CEMENT_M200_MIDDLE_ROUND` | `String` | Yes | `"cement_m200_middle_round"` | `` |
| `CEMENT_M200_MIDDLE_VALUE` | `String` | Yes | `"cement_m200_middle_value"` | `` |
| `CHANNEL_ELEVATION_ROUND` | `String` | Yes | `"channel_elevation_round"` | `` |
| `CHANNEL_ELEVATION_VALUE` | `String` | Yes | `"channel_elevation_value"` | `` |
| `CONCRETE_SUMMARY_ROUND` | `String` | Yes | `"concrete_summary_round"` | `` |
| `CONCRETE_SUMMARY_VALUE` | `String` | Yes | `"concrete_summary_value"` | `` |
| `CONSTRUCTION_LIFT_ROUND` | `String` | Yes | `"construction_lift_round"` | `` |
| `CONSTRUCTION_LIFT_VALUE` | `String` | Yes | `"construction_lift_value"` | `` |
| `CONSTRUCTION_TYPE_STR` | `String` | Yes | `"construction_type_str"` | `` |
| `COORDINATE_CONVERTER_DIGITS` | `String` | Yes | `"coordinate_converter_digits"` | `` |
| `CRITICAL_DEPTH_ROUND` | `String` | Yes | `"critical_depth_round"` | `` |
| `CRITICAL_DEPTH_VALUE` | `String` | Yes | `"critical_depth_value"` | `` |
| `DELTA_BETWEEN_MIDDLE_FULL` | `String` | Yes | `"delta_between_middle_full"` | `` |
| `DELTA_BETWEEN_MIDDLE_SMALL` | `String` | Yes | `"delta_between_middle_small"` | `` |
| `DIAMETER_ROUND` | `String` | Yes | `"diameter_round"` | `` |
| `DIAMETER_VALUE` | `String` | Yes | `"diameter_value"` | `` |
| `ELEVATION_CONVERTER_DIGITS` | `String` | Yes | `"elevation_converter_digits"` | `` |
| `EMBANKMENT_PIT_HEADER_ADD_VALUE` | `String` | Yes | `"embankment_pit_header_add_value"` | `` |
| `EMBANKMENT_PIT_HEADER_ALBUM_VALUE` | `String` | Yes | `"embankment_pit_header_album_value"` | `` |
| `EMBANKMENT_PIT_LEFT_HEADER_AREA_VALUE` | `String` | Yes | `"embankment_pit_left_header_area_value"` | `` |
| `EMBANKMENT_PIT_MIDDLE_ADD_VALUE` | `String` | Yes | `"embankment_pit_middle_add_value"` | `` |
| `EMBANKMENT_PIT_MIDDLE_ALBUM_VALUE` | `String` | Yes | `"embankment_pit_middle_album_value"` | `` |
| `EMBANKMENT_PIT_MIDDLE_AREA_VALUE` | `String` | Yes | `"embankment_pit_middle_area_value"` | `` |
| `EMBANKMENT_PIT_RIGHT_HEADER_AREA_VALUE` | `String` | Yes | `"embankment_pit_right_header_area_value"` | `` |
| `END_A1_ROUND` | `String` | Yes | `"end_a1_round"` | `` |
| `END_A1_VALUE` | `String` | Yes | `"end_a1_value"` | `` |
| `END_AREA_ROUND` | `String` | Yes | `"end_area_round"` | `` |
| `END_AREA_VALUE` | `String` | Yes | `"end_area_value"` | `` |
| `END_ARMATURE_TOTAL_ROUND` | `String` | Yes | `"end_armature_total_round"` | `` |
| `END_ARMATURE_TOTAL_VALUE` | `String` | Yes | `"end_armature_total_value"` | `` |
| `END_ASPHALT_ROUND` | `String` | Yes | `"end_asphalt_round"` | `` |
| `END_ASPHALT_VALUE` | `String` | Yes | `"end_asphalt_value"` | `` |
| `END_B_ROUND` | `String` | Yes | `"end_b_round"` | `` |
| `END_B_VALUE` | `String` | Yes | `"end_b_value"` | `` |
| `END_B20_ROUND` | `String` | Yes | `"end_b20_round"` | `` |
| `END_B20_VALUE` | `String` | Yes | `"end_b20_value"` | `` |
| `END_EARTH_ROUND` | `String` | Yes | `"end_earth_round"` | `` |
| `END_EARTH_VALUE` | `String` | Yes | `"end_earth_value"` | `` |
| `END_ROCK_ROUND` | `String` | Yes | `"end_rock_round"` | `` |
| `END_ROCK_VALUE` | `String` | Yes | `"end_rock_value"` | `` |
| `END_STONE_ROUND` | `String` | Yes | `"end_stone_round"` | `` |
| `END_STONE_VALUE` | `String` | Yes | `"end_stone_value"` | `` |
| `END_T_ROUND` | `String` | Yes | `"end_t_round"` | `` |
| `END_T_VALUE` | `String` | Yes | `"end_t_value"` | `` |
| `END_TK_ROUND` | `String` | Yes | `"end_tk_round"` | `` |
| `END_TK_VALUE` | `String` | Yes | `"end_tk_value"` | `` |
| `EXCAVATION_PIT_HEADER_ADD_VALUE` | `String` | Yes | `"excavation_pit_header_add_value"` | `` |
| `EXCAVATION_PIT_HEADER_ALBUM_VALUE` | `String` | Yes | `"excavation_pit_header_album_value"` | `` |
| `EXCAVATION_PIT_HEADER_BASE` | `String` | Yes | `"excavation_pit_header_base"` | `` |
| `EXCAVATION_PIT_HEADER_CALC` | `String` | Yes | `"excavation_pit_header_calc"` | `` |
| `EXCAVATION_PIT_HEADER_ROUND` | `String` | Yes | `"excavation_pit_header_round"` | `` |
| `EXCAVATION_PIT_HEADER_VALUE` | `String` | Yes | `"excavation_pit_header_value"` | `` |
| `EXCAVATION_PIT_LEFT_HEADER_AREA_VALUE` | `String` | Yes | `"excavation_pit_left_header_area_value"` | `` |
| `EXCAVATION_PIT_MIDDLE_ADD_VALUE` | `String` | Yes | `"excavation_pit_middle_add_value"` | `` |
| `EXCAVATION_PIT_MIDDLE_ALBUM_VALUE` | `String` | Yes | `"excavation_pit_middle_album_value"` | `` |
| `EXCAVATION_PIT_MIDDLE_AREA_VALUE` | `String` | Yes | `"excavation_middle_area_value"` | `` |
| `EXCAVATION_PIT_MIDDLE_PER_METER` | `String` | Yes | `"excavation_pit_middle_per_meter"` | `` |
| `EXCAVATION_PIT_MIDDLE_ROUND` | `String` | Yes | `"excavation_pit_middle_round"` | `` |
| `EXCAVATION_PIT_MIDDLE_VALUE` | `String` | Yes | `"excavation_pit_middle_value"` | `` |
| `EXCAVATION_PIT_RIGHT_HEADER_AREA_VALUE` | `String` | Yes | `"excavation_pit_right_header_area_value"` | `` |
| `FILL_HEIGHT_ROUND` | `String` | Yes | `"fill_height_round"` | `` |
| `FILL_HEIGHT_VALUE` | `String` | Yes | `"fill_height_value"` | `` |
| `FILLING_PIT_HEADER_ROUND` | `String` | Yes | `"filling_pit_header_round"` | `` |
| `FILLING_PIT_HEADER_VALUE` | `String` | Yes | `"filling_pit_header_value"` | `` |
| `FILLING_PIT_MIDDLE_PER_METER` | `String` | Yes | `"filling_pit_middle_per_meter"` | `` |
| `FILLING_PIT_MIDDLE_ROUND` | `String` | Yes | `"filling_pit_middle_round"` | `` |
| `FILLING_PIT_MIDDLE_VALUE` | `String` | Yes | `"filling_pit_middle_value"` | `` |
| `FLOW_TYPE_STR` | `String` | Yes | `"flow_type_str"` | `` |
| `FORTIFICATION_TYPE_STR` | `String` | Yes | `"fortification_type_str"` | `` |
| `FOUNDATION_CONCRETE_HEADER_ROUND` | `String` | Yes | `"foundation_concrete_header_round"` | `` |
| `FOUNDATION_CONCRETE_HEADER_VALUE` | `String` | Yes | `"foundation_concrete_header_value"` | `` |
| `FOUNDATION_CONCRETE_MIDDLE_ROUND` | `String` | Yes | `"foundation_concrete_middle_round"` | `` |
| `FOUNDATION_CONCRETE_MIDDLE_VALUE` | `String` | Yes | `"foundation_concrete_middle_value"` | `` |
| `FOUNDATION_TYPE_STR` | `String` | Yes | `"foundation_type_str"` | `` |
| `FREEZING_DEPTH_ALBUM_1484` | `String` | Yes | `"freezing_depth_album_1484"` | `` |
| `FREEZING_DEPTH_PLUS_025_VALUE` | `String` | Yes | `"freezing_depth_plus_025_value"` | `` |
| `FREEZING_DEPTH_ROUND` | `String` | Yes | `"freezing_depth_round"` | `` |
| `FREEZING_DEPTH_VALUE` | `String` | Yes | `"freezing_depth_value"` | `` |
| `FREEZING_INPUT_KEY` | `String` | Yes | `"freezing_input_key_"` | `` |
| `FREEZING_OUTPUT_KEY` | `String` | Yes | `"freezing_output_key_"` | `` |
| `FRONT_SUPPORT_ROUND` | `String` | Yes | `"front_support_round"` | `` |
| `FRONT_SUPPORT_VALUE` | `String` | Yes | `"front_support_value"` | `` |
| `GENERAL_CONVERTER_DIGITS` | `String` | Yes | `"general_converter_digits"` | `` |
| `GRADE_CONVERTER_DIGITS` | `String` | Yes | `"grade_converter_digits"` | `` |
| `GRADE_CRITICAL_ROUND` | `String` | Yes | `"grade_critical_round"` | `` |
| `GRADE_CRITICAL_VALUE` | `String` | Yes | `"grade_critical_value"` | `` |
| `GRADE_PIPE_ROUND` | `String` | Yes | `"grade_pipe_round"` | `` |
| `GRADE_PIPE_VALUE` | `String` | Yes | `"grade_pipe_value"` | `` |
| `GRAVEL_HEADER_ROUND` | `String` | Yes | `"gravel_header_round"` | `` |
| `GRAVEL_HEADER_VALUE` | `String` | Yes | `"gravel_header_value"` | `` |
| `GRAVEL_MIDDLE_ROUND` | `String` | Yes | `"gravel_middle_round"` | `` |
| `GRAVEL_MIDDLE_VALUE` | `String` | Yes | `"gravel_middle_value"` | `` |
| `GRAVEL_SAND_MIX_HEADER` | `String` | Yes | `"gravel_sand_mix_header"` | `` |
| `GRAVEL_SAND_MIX_HEADER_ROUND` | `String` | Yes | `"gravel_sand_mix_header_round"` | `` |
| `GRAVEL_SAND_MIX_HEADER_VALUE` | `String` | Yes | `"gravel_sand_mix_header_value"` | `` |
| `GRAVEL_SAND_MIX_INFILLSINUSES` | `String` | Yes | `"gravel_sand_mix_infillsinuses"` | `` |
| `GRAVEL_SAND_MIX_INFILLSINUSES_PER_METR` | `String` | Yes | `"gravel_sand_mix_infillsinuses_per_metr"` | `` |
| `GRAVEL_SAND_MIX_MIDDLE_PER_METR` | `String` | Yes | `"gravel_sand_mix_middle_per_metr"` | `` |
| `GRAVEL_SAND_MIX_MIDDLE_ROUND` | `String` | Yes | `"gravel_sand_mix_middle_round"` | `` |
| `GRAVEL_SAND_MIX_MIDDLE_VALUE` | `String` | Yes | `"gravel_sand_mix_middle_value"` | `` |
| `GRAVEL_SAND_MIX_TOTAL_ROUND` | `String` | Yes | `"gravel_sand_mix_total_round"` | `` |
| `GRAVEL_SAND_MIX_TOTAL_VALUE` | `String` | Yes | `"gravel_sand_mix_total_value"` | `` |
| `GROUND_ELEVATION_ON_H9_POINT_VALUE` | `String` | Yes | `"ground_elevation_on_h9_point_value"` | `` |
| `GROUND_FREEZING_ELEVATION_ON_H7_POINT_ROUND` | `String` | Yes | `"ground_freezing_elevation_on_h7_point_round"` | `` |
| `GROUND_FREEZING_ELEVATION_ON_H9_POINT_ROUND` | `String` | Yes | `"ground_freezing_elevation_on_h9_point_round"` | `` |
| `GROUND_TYPE_STR` | `String` | Yes | `"ground_type_str"` | `` |
| `H1_ROUND` | `String` | Yes | `"h1_round"` | `` |
| `H1_VALUE` | `String` | Yes | `"h1_value"` | `` |
| `H2_ROUND` | `String` | Yes | `"h2_round"` | `` |
| `H2_VALUE` | `String` | Yes | `"h2_value"` | `` |
| `H3_ROUND` | `String` | Yes | `"h3_round"` | `` |
| `H3_VALUE` | `String` | Yes | `"h3_value"` | `` |
| `H4_ROUND` | `String` | Yes | `"h4_round"` | `` |
| `H4_VALUE` | `String` | Yes | `"h4_value"` | `` |
| `H5_ROUND` | `String` | Yes | `"h5_round"` | `` |
| `H5_VALUE` | `String` | Yes | `"h5_value"` | `` |
| `H6_ROUND` | `String` | Yes | `"h6_round"` | `` |
| `H6_VALUE` | `String` | Yes | `"h6_value"` | `` |
| `H7_ROUND` | `String` | Yes | `"h7_round"` | `` |
| `H7_VALUE` | `String` | Yes | `"h7_value"` | `` |
| `H8_ROUND` | `String` | Yes | `"h8_round"` | `` |
| `H8_VALUE` | `String` | Yes | `"h8_value"` | `` |
| `H9_ROUND` | `String` | Yes | `"h9_round"` | `` |
| `H9_VALUE` | `String` | Yes | `"h9_value"` | `` |
| `HEADER_A1_TOTAL_ROUND` | `String` | Yes | `"header_a1_total_round"` | `` |
| `HEADER_AREA_TOTAL_ROUND` | `String` | Yes | `"header_area_total_round"` | `` |
| `HEADER_ASPHALT_TOTAL_ROUND` | `String` | Yes | `"header_asphalt_total_round"` | `` |
| `HEADER_B20_TOTAL_ROUND` | `String` | Yes | `"header_b20_total_round"` | `` |
| `HEADER_CONCRETE_B20_P1_TOTAL_ROUND` | `String` | Yes | `"header_concrete_b20_p1_total_round"` | `` |
| `HEADER_CONCRETE_B20_U1_AND_U2_TOTAL_ROUND` | `String` | Yes | `"header_concrete_b20_u1_and_u2_total_round"` | `` |
| `HEADER_CONCRETE_B20_U1_TOTAL_ROUND` | `String` | Yes | `"header_concrete_b20_u1_total_round"` | `` |
| `HEADER_EXCAVATION_EARTH_TOTAL_ROUND` | `String` | Yes | `"header_excavation_earth_total_round"` | `` |
| `HEADER_M200_TOTAL_ROUND` | `String` | Yes | `"header_m200_total_round"` | `` |
| `HEADER_ROCK_TOTAL_ROUND` | `String` | Yes | `"header_rock_total_round"` | `` |
| `HEADER_STONE_TOTAL_ROUND` | `String` | Yes | `"header_stone_total_round"` | `` |
| `HEADER_STOP_B20_TOTAL_ROUND` | `String` | Yes | `"header_stop_b20_total_round"` | `` |
| `HOLE_COUNT` | `String` | Yes | `"holes_count"` | `` |
| `HOLE_HEIGHT_ROUND` | `String` | Yes | `"hole_height_round"` | `` |
| `HOLE_HEIGHT_VALUE` | `String` | Yes | `"hole_height_value"` | `` |
| `HOLE_WIDTH_ROUND` | `String` | Yes | `"hole_width_round"` | `` |
| `HOLE_WIDTH_VALUE` | `String` | Yes | `"hole_width_value"` | `` |
| `INFILLSINUSES_HEADER_B20_ROUND` | `String` | Yes | `"infillsinuses_header_b20_round"` | `` |
| `INFILLSINUSES_HEADER_B20_VALUE` | `String` | Yes | `"infillsinuses_header_b20_value"` | `` |
| `INFILLSINUSES_HEADER_GRAVEL_SAND_ROUND` | `String` | Yes | `"infillsinuses_header_gravel_sand_round"` | `` |
| `INFILLSINUSES_HEADER_GRAVEL_SAND_VALUE` | `String` | Yes | `"infillsinuses_header_gravel_sand_value"` | `` |
| `INFILLSINUSES_MIDDLE_B20_ROUND` | `String` | Yes | `"infillsinuses_middle_b20_round"` | `` |
| `INFILLSINUSES_MIDDLE_B20_VALUE` | `String` | Yes | `"infillsinuses_middle_b20_value"` | `` |
| `INFILLSINUSES_MIDDLE_GRAVEL_SAND_ROUND` | `String` | Yes | `"infillsinuses_middle_gravel_sand_round"` | `` |
| `INFILLSINUSES_MIDDLE_GRAVEL_SAND_VALUE` | `String` | Yes | `"infillsinuses_middle_gravel_sand_value"` | `` |
| `INPUT_A_ROUND` | `String` | Yes | `"input_a_round"` | `` |
| `INPUT_A_VALUE` | `String` | Yes | `"input_a_value"` | `` |
| `INPUT_BERM_LENGTH_ROUND` | `String` | Yes | `"input_berm_length_round"` | `` |
| `INPUT_BERM_LENGTH_VALUE` | `String` | Yes | `"input_berm_length_value"` | `` |
| `INPUT_CHANNEL_A1_PLATE_U1_ROUND` | `String` | Yes | `"input_channel_a1_plate_u1_round"` | `` |
| `INPUT_CHANNEL_A1_PLATE_U1_VALUE` | `String` | Yes | `"input_channel_a1_plate_u1_value"` | `` |
| `INPUT_CHANNEL_A1_PLATE_U2_ROUND` | `String` | Yes | `"input_channel_a1_plate_u2_round"` | `` |
| `INPUT_CHANNEL_A1_PLATE_U2_VALUE` | `String` | Yes | `"input_channel_a1_plate_u2_value"` | `` |
| `INPUT_CHANNEL_A1_ROUND` | `String` | Yes | `"input_channel_a1_round"` | `` |
| `INPUT_CHANNEL_A1_VALUE` | `String` | Yes | `"input_channel_a1_value"` | `` |
| `INPUT_CHANNEL_AREA_ROUND` | `String` | Yes | `"input_channel_area_round"` | `` |
| `INPUT_CHANNEL_AREA_VALUE` | `String` | Yes | `"input_channel_area_value"` | `` |
| `INPUT_CHANNEL_ARMATURE_A1_PLATE_P1_ROUND` | `String` | Yes | `"input_channel_armature_a1_plate_p1_round"` | `` |
| `INPUT_CHANNEL_ARMATURE_A1_PLATE_P1_VALUE` | `String` | Yes | `"input_channel_armature_a1_plate_p1_value"` | `` |
| `INPUT_CHANNEL_ASPHALT_ROUND` | `String` | Yes | `"input_channel_asphalt_round"` | `` |
| `INPUT_CHANNEL_ASPHALT_VALUE` | `String` | Yes | `"input_channel_asphalt_value"` | `` |
| `INPUT_CHANNEL_CEMENT_M200_ROUND` | `String` | Yes | `"input_channel_cement_m200_round"` | `` |
| `INPUT_CHANNEL_CEMENT_M200_VALUE` | `String` | Yes | `"input_channel_cement_m200_value"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_P1_ROUND` | `String` | Yes | `"input_channel_concrete_b20_plate_p1_round"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_P1_VALUE` | `String` | Yes | `"input_channel_concrete_b20_plate_p1_value"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_U1_ROUND` | `String` | Yes | `"input_channel_concrete_b20_plate_u1_round"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_U1_VALUE` | `String` | Yes | `"input_channel_concrete_b20_plate_u1_value"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_U2_ROUND` | `String` | Yes | `"input_channel_concrete_b20_plate_u2_round"` | `` |
| `INPUT_CHANNEL_CONCRETE_B20_PLATE_U2_VALUE` | `String` | Yes | `"input_channel_concrete_b20_plate_u2_value"` | `` |
| `INPUT_CHANNEL_FORTIFICATION_B20_ROUND` | `String` | Yes | `"input_channel_fortification_b20_round"` | `` |
| `INPUT_CHANNEL_FORTIFICATION_B20_VALUE` | `String` | Yes | `"input_channel_fortification_b20_value"` | `` |
| `INPUT_CHANNEL_P1_COUNT` | `String` | Yes | `"input_channel_p1_count"` | `` |
| `INPUT_CHANNEL_ROCK_ROUND` | `String` | Yes | `"input_channel_rock_round"` | `` |
| `INPUT_CHANNEL_ROCK_VALUE` | `String` | Yes | `"input_channel_rock_value"` | `` |
| `INPUT_CHANNEL_STONE_ROUND` | `String` | Yes | `"input_channel_stone_round"` | `` |
| `INPUT_CHANNEL_STONE_VALUE` | `String` | Yes | `"input_channel_stone_value"` | `` |
| `INPUT_CHANNEL_STOP_B20_ROUND` | `String` | Yes | `"input_channel_stop_b20_round"` | `` |
| `INPUT_CHANNEL_STOP_B20_VALUE` | `String` | Yes | `"input_channel_stop_b20_value"` | `` |
| `INPUT_CHANNEL_U1_COUNT` | `String` | Yes | `"input_channel_u1_count"` | `` |
| `INPUT_CHANNEL_U2_COUNT` | `String` | Yes | `"input_channel_u2_count"` | `` |
| `INPUT_H025_ROUND` | `String` | Yes | `"input_h025_round"` | `` |
| `INPUT_H025_VALUE` | `String` | Yes | `"input_h025_value"` | `` |
| `INPUT_HEADER_CREATED` | `String` | Yes | `"input_header_created"` | `` |
| `INPUT_HEADER_STONE_HEIGHT_ROUND` | `String` | Yes | `"input_header_stone_height_round"` | `` |
| `INPUT_HEADER_STONE_HEIGHT_VALUE` | `String` | Yes | `"input_header_stone_height_value"` | `` |
| `INPUT_HEADER_TYPE_STR` | `String` | Yes | `"input_header_type_str"` | `` |
| `INPUT_INCLINE_ROUND` | `String` | Yes | `"input_incline_round"` | `` |
| `INPUT_INCLINE_TO_STR` | `String` | Yes | `"input_incline_to_str"` | `` |
| `INPUT_INCLINE_VALUE` | `String` | Yes | `"input_incline_value"` | `` |
| `INPUT_M1_ROUND` | `String` | Yes | `"input_m1_round"` | `` |
| `INPUT_M1_VALUE` | `String` | Yes | `"input_m1_value"` | `` |
| `INPUT_N1_ROUND` | `String` | Yes | `"input_n1_round"` | `` |
| `INPUT_N1_VALUE` | `String` | Yes | `"input_n1_value"` | `` |
| `INPUT_P1_ROUND` | `String` | Yes | `"input_p1_round"` | `` |
| `INPUT_P1_VALUE` | `String` | Yes | `"input_p1_value"` | `` |
| `INPUT_Q1_ROUND` | `String` | Yes | `"input_q1_round"` | `` |
| `INPUT_Q1_VALUE` | `String` | Yes | `"input_q1_value"` | `` |
| `INPUT_SLOPE_AREA_CHOOSE_VALUE` | `String` | Yes | `"input_slope_area_choose_value"` | `` |
| `INPUT_SLOPE_AREA_ROUND` | `String` | Yes | `"input_slope_area_round"` | `` |
| `INPUT_SLOPE_AREA_VALUE` | `String` | Yes | `"input_slope_area_value"` | `` |
| `INPUT_SLOPE_ARMATURE_A1_PLATE_P1_ROUND` | `String` | Yes | `"input_slope_armature_a1_plate_p1_round"` | `` |
| `INPUT_SLOPE_ARMATURE_A1_PLATE_P1_VALUE` | `String` | Yes | `"input_slope_armature_a1_plate_p1_value"` | `` |
| `INPUT_SLOPE_ARMATURE_ROUND` | `String` | Yes | `"input_slope_armature_round"` | `` |
| `INPUT_SLOPE_ARMATURE_VALUE` | `String` | Yes | `"input_slope_armature_value"` | `` |
| `INPUT_SLOPE_ASPHALT_ROUND` | `String` | Yes | `"input_slope_asphalt_round"` | `` |
| `INPUT_SLOPE_ASPHALT_VALUE` | `String` | Yes | `"input_slope_asphalt_value"` | `` |
| `INPUT_SLOPE_CEMENT_M200_ROUND` | `String` | Yes | `"input_slope_cement_m200_round"` | `` |
| `INPUT_SLOPE_CEMENT_M200_VALUE` | `String` | Yes | `"input_slope_cement_m200_value"` | `` |
| `INPUT_SLOPE_CONCRETE_B20_PLATE_P1_ROUND` | `String` | Yes | `"input_slope_concrete_b20_plate_p1_round"` | `` |
| `INPUT_SLOPE_CONCRETE_B20_PLATE_P1_VALUE` | `String` | Yes | `"input_slope_concrete_b20_plate_p1_value"` | `` |
| `INPUT_SLOPE_CONCRETE_ROUND` | `String` | Yes | `"input_slope_concrete_round"` | `` |
| `INPUT_SLOPE_CONCRETE_VALUE` | `String` | Yes | `"input_slope_concrete_value"` | `` |
| `INPUT_SLOPE_GRAVEL_ROUND` | `String` | Yes | `"input_slope_gravel_round"` | `` |
| `INPUT_SLOPE_GRAVEL_VALUE` | `String` | Yes | `"input_slope_gravel_value"` | `` |
| `INPUT_SLOPE_P1_COUNT` | `String` | Yes | `"input_slope_p1_count"` | `` |
| `INPUT_STRENGTHENING_VALID` | `String` | Yes | `"input_strengthening_valid"` | `` |
| `INSERT_KEY_FREEZING_INPUT` | `String` | Yes | `"insert_key_freezing_input"` | `` |
| `INSERT_KEY_FREEZING_OUTPUT` | `String` | Yes | `"insert_key_freezing_output"` | `` |
| `INSERT_KEY_LINK_COUNT` | `String` | Yes | `"insert_key_link_count"` | `` |
| `INSERT_KEY_SECTION` | `String` | Yes | `"insert_key_section"` | `` |
| `INSIDE_H_VALUE` | `String` | Yes | `"inside_h_value"` | `` |
| `INSIDE_HEADER_M1` | `String` | Yes | `"inside_header_m1"` | `` |
| `INSIDE_HEADER_N1` | `String` | Yes | `"inside_header_n1"` | `` |
| `LENGTH_CONVERTER_DIGITS` | `String` | Yes | `"length_converter_digits"` | `` |
| `LENGTH_DELTA_ROUND` | `String` | Yes | `"length_delta_round"` | `` |
| `LENGTH_DELTA_VALUE` | `String` | Yes | `"length_delta_value"` | `` |
| `LENGTH_LEFT_ROUND` | `String` | Yes | `"length_left_round"` | `` |
| `LENGTH_LEFT_VALUE` | `String` | Yes | `"length_left_value"` | `` |
| `LENGTH_RIGHT_ROUND` | `String` | Yes | `"length_right_round"` | `` |
| `LENGTH_RIGHT_VALUE` | `String` | Yes | `"length_right_value"` | `` |
| `LENGTH_TEORY_ROUND` | `String` | Yes | `"length_teory_round"` | `` |
| `LENGTH_TEORY_VALUE` | `String` | Yes | `"length_teory_value"` | `` |
| `LENGTH_TOTAL_ROUND` | `String` | Yes | `"length_total_round"` | `` |
| `LENGTH_TOTAL_VALUE` | `String` | Yes | `"length_total_value"` | `` |
| `LENGTH_WITHOUT_HEADER_ROUND` | `String` | Yes | `"length_without_header_round"` | `` |
| `LENGTH_WITHOUT_HEADER_VALUE` | `String` | Yes | `"length_without_header_value"` | `` |
| `LINK_COUNT_VALUE` | `String` | Yes | `"link_count_value"` | `` |
| `LINK_IN_MIDDLE_COUNT_KEY_FOR_CALC` | `String` | Yes | `"link_in_middle_count_key_for_calc_"` | `` |
| `LINK_IN_MIDDLE_VOLUME_KEY_FOR_CALC` | `String` | Yes | `"link_in_middle_volume_key_for_calc"` | `` |
| `LINK_IN_SECTION_COUNT_KEY_FOR_REPORT` | `String` | Yes | `"link_in_section_count_key_for_report_"` | `` |
| `MAXIMUM_GRADE_VALUE` | `String` | Yes | `"maximum_grade_value"` | `` |
| `MIDDLE_DEPTH_ROUND` | `String` | Yes | `"middle_depth_round"` | `` |
| `MIDDLE_DEPTH_VALUE` | `String` | Yes | `"middle_depth_value"` | `` |
| `MIDDLE_ELEVATION_ROUND` | `String` | Yes | `"middle_elevation_round"` | `` |
| `MIDDLE_ELEVATION_VALUE` | `String` | Yes | `"middle_elevation_value"` | `` |
| `MIDDLE_LINK_CONCRETE_VOLUME` | `String` | Yes | `"middle_link_concrete_volume"` | `` |
| `MIDDLE_PART_LINKS_COUNT` | `String` | Yes | `"middle_part_links_count"` | `` |
| `MIDDLE_PART_SECTIONS_COUNT` | `String` | Yes | `"middle_part_sections_count"` | `` |
| `MINIMUM_GRADE_VALUE` | `String` | Yes | `"minimum_grade_value"` | `` |
| `OUT_SPEED_NORMATIVE_ROUND` | `String` | Yes | `"out_speed_normative_round"` | `` |
| `OUT_SPEED_NORMATIVE_VALUE` | `String` | Yes | `"out_speed_normative_value"` | `` |
| `OUT_SPEED_ROUND` | `String` | Yes | `"out_speed_round"` | `` |
| `OUT_SPEED_VALUE` | `String` | Yes | `"out_speed_value"` | `` |
| `OUTPUT_BERM_LENGTH_ROUND` | `String` | Yes | `"output_berm_length_round"` | `` |
| `OUTPUT_BERM_LENGTH_VALUE` | `String` | Yes | `"output_berm_length_value"` | `` |
| `OUTPUT_CHANNEL_A1_PLATE_U1_ROUND` | `String` | Yes | `"output_channel_a1_plate_u1_round"` | `` |
| `OUTPUT_CHANNEL_A1_PLATE_U1_VALUE` | `String` | Yes | `"output_channel_a1_plate_u1_value"` | `` |
| `OUTPUT_CHANNEL_A1_ROUND` | `String` | Yes | `"output_channel_a1_round"` | `` |
| `OUTPUT_CHANNEL_A1_VALUE` | `String` | Yes | `"output_channel_a1_value"` | `` |
| `OUTPUT_CHANNEL_AREA_ROUND` | `String` | Yes | `"output_channel_area_round"` | `` |
| `OUTPUT_CHANNEL_AREA_VALUE` | `String` | Yes | `"output_channel_area_value"` | `` |
| `OUTPUT_CHANNEL_ASPHALT_ROUND` | `String` | Yes | `"output_channel_asphalt_round"` | `` |
| `OUTPUT_CHANNEL_ASPHALT_VALUE` | `String` | Yes | `"output_channel_asphalt_value"` | `` |
| `OUTPUT_CHANNEL_B20_FORTIFICATION_ROUND` | `String` | Yes | `"output_channel_b20_fortification_round"` | `` |
| `OUTPUT_CHANNEL_B20_FORTIFICATION_VALUE` | `String` | Yes | `"output_channel_b20_fortification_value"` | `` |
| `OUTPUT_CHANNEL_B20_STOP_ROUND` | `String` | Yes | `"output_channel_b20_stop_round"` | `` |
| `OUTPUT_CHANNEL_B20_STOP_VALUE` | `String` | Yes | `"output_channel_b20_stop_value"` | `` |
| `OUTPUT_CHANNEL_CONCRETE_B20_PLATE_U1_ROUND` | `String` | Yes | `"output_channel_concrete_b20_plate_u1_round"` | `` |
| `OUTPUT_CHANNEL_CONCRETE_B20_PLATE_U1_VALUE` | `String` | Yes | `"output_channel_concrete_b20_plate_u1_value"` | `` |
| `OUTPUT_CHANNEL_CONCRETE_B20_ROUND` | `String` | Yes | `"output_channel_concrete_b20_round"` | `` |
| `OUTPUT_CHANNEL_CONCRETE_B20_VALUE` | `String` | Yes | `"output_channel_concrete_b20_value"` | `` |
| `OUTPUT_CHANNEL_FORTIFICATION_B20_ROUND` | `String` | Yes | `"output_channel_fortification_b20_round"` | `` |
| `OUTPUT_CHANNEL_FORTIFICATION_B20_VALUE` | `String` | Yes | `"output_channel_fortification_b20_value"` | `` |
| `OUTPUT_CHANNEL_ROCK_ROUND` | `String` | Yes | `"output_channel_rock_round"` | `` |
| `OUTPUT_CHANNEL_ROCK_VALUE` | `String` | Yes | `"output_channel_rock_value"` | `` |
| `OUTPUT_CHANNEL_STONE_ROUND` | `String` | Yes | `"output_channel_stone_round"` | `` |
| `OUTPUT_CHANNEL_STONE_VALUE` | `String` | Yes | `"output_channel_stone_value"` | `` |
| `OUTPUT_CHANNEL_STOP_B20_ROUND` | `String` | Yes | `"output_channel_stop_b20_round"` | `` |
| `OUTPUT_CHANNEL_STOP_B20_VALUE` | `String` | Yes | `"output_channel_stop_b20_value"` | `` |
| `OUTPUT_CHANNEL_U1_COUNT` | `String` | Yes | `"output_channel_u1_count"` | `` |
| `OUTPUT_D_ROUND` | `String` | Yes | `"output_d_round"` | `` |
| `OUTPUT_D_VALUE` | `String` | Yes | `"output_d_value"` | `` |
| `OUTPUT_H025_ROUND` | `String` | Yes | `"output_h025_round"` | `` |
| `OUTPUT_H025_VALUE` | `String` | Yes | `"output_h025_value"` | `` |
| `OUTPUT_HEADER_CREATED` | `String` | Yes | `"output_header_created"` | `` |
| `OUTPUT_HEADER_STONE_HEIGHT_ROUND` | `String` | Yes | `"output_header_stone_height_round"` | `` |
| `OUTPUT_HEADER_STONE_HEIGHT_VALUE` | `String` | Yes | `"output_header_stone_height_value"` | `` |
| `OUTPUT_HEADER_TYPE_STR` | `String` | Yes | `"output_header_type_str"` | `` |
| `OUTPUT_INCLINE_ROUND` | `String` | Yes | `"output_incline_round"` | `` |
| `OUTPUT_INCLINE_TO_STR` | `String` | Yes | `"output_incline_to_str"` | `` |
| `OUTPUT_INCLINE_VALUE` | `String` | Yes | `"output_incline_value"` | `` |
| `OUTPUT_L_ROUND` | `String` | Yes | `"output_l_round"` | `` |
| `OUTPUT_L_VALUE` | `String` | Yes | `"output_l_value"` | `` |
| `OUTPUT_M2_ROUND` | `String` | Yes | `"output_m2_round"` | `` |
| `OUTPUT_M2_VALUE` | `String` | Yes | `"output_m2_value"` | `` |
| `OUTPUT_N2_ROUND` | `String` | Yes | `"output_n2_round"` | `` |
| `OUTPUT_N2_VALUE` | `String` | Yes | `"output_n2_value"` | `` |
| `OUTPUT_NK1` | `String` | Yes | `"output_nk1"` | `` |
| `OUTPUT_NK2` | `String` | Yes | `"output_nk2"` | `` |
| `OUTPUT_NK3` | `String` | Yes | `"output_nk3"` | `` |
| `OUTPUT_NK4` | `String` | Yes | `"output_nk4"` | `` |
| `OUTPUT_P2_ROUND` | `String` | Yes | `"output_p2_round"` | `` |
| `OUTPUT_P2_VALUE` | `String` | Yes | `"output_p2_value"` | `` |
| `OUTPUT_Q2_ROUND` | `String` | Yes | `"output_q2_round"` | `` |
| `OUTPUT_Q2_VALUE` | `String` | Yes | `"output_q2_value"` | `` |
| `OUTPUT_SLOPE_AREA_ROUND` | `String` | Yes | `"output_slope_area_round"` | `` |
| `OUTPUT_SLOPE_AREA_VALUE` | `String` | Yes | `"output_slope_area_value"` | `` |
| `OUTPUT_SLOPE_ARMATURE_A1_PLATE_P1_ROUND` | `String` | Yes | `"output_slope_armature_a1_plate_p1_round"` | `` |
| `OUTPUT_SLOPE_ARMATURE_A1_PLATE_P1_VALUE` | `String` | Yes | `"output_slope_armature_a1_plate_p1_value"` | `` |
| `OUTPUT_SLOPE_ARMATURE_ROUND` | `String` | Yes | `"output_slope_armature_round"` | `` |
| `OUTPUT_SLOPE_ARMATURE_VALUE` | `String` | Yes | `"output_slope_armature_value"` | `` |
| `OUTPUT_SLOPE_ASPHALT_ROUND` | `String` | Yes | `"output_slope_asphalt_round"` | `` |
| `OUTPUT_SLOPE_ASPHALT_VALUE` | `String` | Yes | `"output_slope_asphalt_value"` | `` |
| `OUTPUT_SLOPE_CEMENT_M200_ROUND` | `String` | Yes | `"output_slope_cement_m200_round"` | `` |
| `OUTPUT_SLOPE_CEMENT_M200_VALUE` | `String` | Yes | `"output_slope_cement_m200_value"` | `` |
| `OUTPUT_SLOPE_CONCRETE_B20_PLATE_P1_ROUND` | `String` | Yes | `"output_slope_concrete_b20_plate_p1_round"` | `` |
| `OUTPUT_SLOPE_CONCRETE_B20_PLATE_P1_VALUE` | `String` | Yes | `"output_slope_concrete_b20_plate_p1_value"` | `` |
| `OUTPUT_SLOPE_CONCRETE_ROUND` | `String` | Yes | `"output_slope_concrete_round"` | `` |
| `OUTPUT_SLOPE_CONCRETE_VALUE` | `String` | Yes | `"output_slope_concrete_value"` | `` |
| `OUTPUT_SLOPE_GRAVEL_ROUND` | `String` | Yes | `"output_slope_gravel_round"` | `` |
| `OUTPUT_SLOPE_GRAVEL_VALUE` | `String` | Yes | `"output_slope_gravel_value"` | `` |
| `OUTPUT_SLOPE_P1_COUNT` | `String` | Yes | `"output_slope_p1_count"` | `` |
| `OUTPUT_SPEED_CRITICAL_GRADE_ROUND` | `String` | Yes | `"output_speed_critical_grade_round"` | `` |
| `OUTPUT_SPEED_CRITICAL_GRADE_VALUE` | `String` | Yes | `"output_speed_critical_grade_value"` | `` |
| `OUTPUT_STRENGTHENING_VALID` | `String` | Yes | `"output_strengthening_valid"` | `` |
| `OUTSIDE_H025` | `String` | Yes | `"outside_h025"` | `` |
| `PACKLES_ROUND` | `String` | Yes | `"packles_round"` | `` |
| `PACKLES_VALUE` | `String` | Yes | `"packles_value"` | `` |
| `PIPE_ALIGNMENT_ANGLE_ROUND` | `String` | Yes | `"pipe_alignment_angle_round"` | `` |
| `PIPE_ALIGNMENT_ANGLE_VALUE` | `String` | Yes | `"pipe_alignment_angle_value"` | `` |
| `PIPE_PLAN_ALIGNMENT_ANGLE_ROUND` | `String` | Yes | `"pipe_plan_alignment_angle_round"` | `` |
| `PIPE_PLAN_ALIGNMENT_ANGLE_VALUE` | `String` | Yes | `"pipe_plan_alignment_angle_value"` | `` |
| `PIT_WIDTH_ROUND` | `String` | Yes | `"pit_width_round"` | `` |
| `PIT_WIDTH_VALUE` | `String` | Yes | `"pit_width_value"` | `` |
| `PRECAST_CONCRETE_HEADER_ROUND` | `String` | Yes | `"precast_concrete_header_round"` | `` |
| `PRECAST_CONCRETE_HEADER_VALUE` | `String` | Yes | `"precast_concrete_header_value"` | `` |
| `PRECAST_CONCRETE_MIDDLE_ROUND` | `String` | Yes | `"precast_concrete_middle_round"` | `` |
| `PRECAST_CONCRETE_MIDDLE_VALUE` | `String` | Yes | `"precast_concrete_middle_value"` | `` |
| `REQUIRED_FILL_HEIGHT_ROUND` | `String` | Yes | `"required_fill_height_round"` | `` |
| `REQUIRED_FILL_HEIGHT_VALUE` | `String` | Yes | `"required_fill_height_value"` | `` |
| `SAFETY_BLOCK_ASPHALT_CONCRETE_HEADER_ROUND` | `String` | Yes | `"safety_block_asphalt_concrete_header_round"` | `` |
| `SAFETY_BLOCK_ASPHALT_CONCRETE_HEADER_VALUE` | `String` | Yes | `"safety_block_asphalt_concrete_header_value"` | `` |
| `SAFETY_BLOCK_ASPHALT_CONCRETE_MIDDLE_ROUND` | `String` | Yes | `"safety_block_asphalt_concrete_middle_round"` | `` |
| `SAFETY_BLOCK_ASPHALT_CONCRETE_MIDDLE_VALUE` | `String` | Yes | `"safety_block_asphalt_concrete_middle_value"` | `` |
| `SECTION_COUNT_KEY` | `String` | Yes | `"section_count_key_"` | `` |
| `SECTION_GRADE_ROUND` | `String` | Yes | `"section_grade_round"` | `` |
| `SECTION_GRADE_STR` | `String` | Yes | `"section_grade_str"` | `` |
| `SECTION_GRADE_VALUE` | `String` | Yes | `"section_grade_value"` | `` |
| `SELECTED_FILL_HEIGHT_ROUND` | `String` | Yes | `"selected_fill_height_round"` | `` |
| `SELECTED_FILL_HEIGHT_VALUE` | `String` | Yes | `"selected_fill_height_value"` | `` |
| `SHEET_THICKNESS_ROUND` | `String` | Yes | `"sheet_thickness_round"` | `` |
| `SHEET_THICKNESS_VALUE` | `String` | Yes | `"sheet_thickness_value"` | `` |
| `SHOW_END_ZERO_FEET` | `String` | Yes | `"show_end_zero_feet"` | `` |
| `STANDARD_SLOPE_GRADE_ROUND` | `String` | Yes | `"standard_slope_grade_round"` | `` |
| `STANDARD_SLOPE_GRADE_VALUE` | `String` | Yes | `"standard_slope_grade_value"` | `` |
| `STATION_STR` | `String` | Yes | `"station_str"` | `` |
| `TIGHT_SECTION_ROUND` | `String` | Yes | `"tight_section_round"` | `` |
| `TIGHT_SECTION_VALUE` | `String` | Yes | `"tight_section_value"` | `` |
| `TRAY_BLOCKS_COUNT` | `String` | Yes | `"tray_blocks_count"` | `` |
| `TRAY_CONCRETE_ROUND` | `String` | Yes | `"tray_concrete_round"` | `` |
| `TRAY_CONCRETE_VALUE` | `String` | Yes | `"tray_concrete_value"` | `` |
| `UVV_ROUND` | `String` | Yes | `"uvv_round"` | `` |
| `UVV_VALUE` | `String` | Yes | `"uvv_value"` | `` |
| `VALUE_DIGITS` | `Int32` | Yes | `8` | `` |
| `VERTICAL_DISTANCE_VALUE` | `String` | Yes | `"vertical_distance_value"` | `` |
| `WALL_WIDTH_ROUND` | `String` | Yes | `"wall_width_round"` | `` |
| `WALL_WIDTH_VALUE` | `String` | Yes | `"wall_width_value"` | `` |
| `WATER_CONSUMPTION_ROUND` | `String` | Yes | `"water_consumption_round"` | `` |
| `WATER_CONSUMPTION_VALUE` | `String` | Yes | `"water_consumption_value"` | `` |
| `WATER_DIRECTION` | `String` | Yes | `"water_direction"` | `` |
| `WATERPROOFING_COATING_HEADER_ROUND` | `String` | Yes | `"waterproofing_coating_header_round"` | `` |
| `WATERPROOFING_COATING_HEADER_VALUE` | `String` | Yes | `"waterproofing_coating_header_value"` | `` |
| `WATERPROOFING_COATING_MIDDLE_ROUND` | `String` | Yes | `"waterproofing_coating_middle_round"` | `` |
| `WATERPROOFING_COATING_MIDDLE_VALUE` | `String` | Yes | `"waterproofing_coating_middle_value"` | `` |
| `WATERPROOFING_TAPING_HEADER_ROUND` | `String` | Yes | `"waterproofing_taping_header_round"` | `` |
| `WATERPROOFING_TAPING_HEADER_VALUE` | `String` | Yes | `"waterproofing_taping_header_value"` | `` |
| `WATERPROOFING_TAPING_MIDDLE_ROUND` | `String` | Yes | `"waterproofing_taping_middle_round"` | `` |
| `WATERPROOFING_TAPING_MIDDLE_VALUE` | `String` | Yes | `"waterproofing_taping_middle_value"` | `` |
| `WIDTH_ROAD_ROUND` | `String` | Yes | `"width_road_round"` | `` |
| `WIDTH_ROAD_VALUE` | `String` | Yes | `"width_road_value"` | `` |

---
## Namespace: `Topomatic.Culverts.Components`

### `AllowedSection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.AllowedSection` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DistanceBetweenLinks` | `Double` | `get/set` | No | `` |
| `Element` | `ClvElement` | `get/set` | No | `` |
| `FoundationBottomOffset` | `Double` | `get/set` | No | `` |
| `FoundationPlates` | `Dictionary<String KeyValuePair<Int32 String>>` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `IsFullSectionModel` | `Boolean` | `get/set` | No | `` |
| `LecalBlocks` | `Dictionary<String KeyValuePair<Int32 String>>` | `get` | No | `` |
| `LeftInputElements` | `List<ClvElement>` | `get` | No | `` |
| `LeftInputLengthOffset` | `Double` | `get/set` | No | `` |
| `LeftOutputElements` | `List<ClvElement>` | `get` | No | `` |
| `LeftOutputLengthOffset` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `LinkOffsets` | `List<Double>` | `get` | No | `` |
| `Links` | `Dictionary<String KeyValuePair<Int32 String>>` | `get` | No | `` |
| `LinksBottomOffset` | `Double` | `get/set` | No | `` |
| `NegativeSlopeMiddleElements` | `List<ClvElement>` | `get` | No | `` |
| `NegativeSlopeSingleSectionElements` | `List<ClvElement>` | `get` | No | `` |
| `PositiveSlopeMiddleElements` | `List<ClvElement>` | `get` | No | `` |
| `PositiveSlopeSingleSectionElements` | `List<ClvElement>` | `get` | No | `` |
| `RightInputElements` | `List<ClvElement>` | `get` | No | `` |
| `RightInputLengthOffset` | `Double` | `get/set` | No | `` |
| `RightOutputElements` | `List<ClvElement>` | `get` | No | `` |
| `RightOutputLengthOffset` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

### `CamberCalcMode` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CamberCalcMode` |
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
      - `Topomatic.Culverts.Components.CamberCalcMode`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ByCount` | `CamberCalcMode` | Yes | `ByCount` | `` |
| `ByLinks` | `CamberCalcMode` | Yes | `ByLinks` | `` |
| `BySections` | `CamberCalcMode` | Yes | `BySections` | `` |
| `ByStep` | `CamberCalcMode` | Yes | `ByStep` | `` |
| `ByTransformedX` | `CamberCalcMode` | Yes | `ByTransformedX` | `` |
| `ByTrayOffset` | `CamberCalcMode` | Yes | `ByTrayOffset` | `` |
| `Determining` | `CamberCalcMode` | Yes | `Determining` | `` |
| `Empty` | `CamberCalcMode` | Yes | `Empty` | `` |
| `FromInputHeader` | `CamberCalcMode` | Yes | `FromInputHeader` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `BySections` | `1` |
| `ByLinks` | `2` |
| `ByStep` | `4` |
| `ByCount` | `8` |
| `Determining` | `16` |
| `ByTrayOffset` | `32` |
| `ByTransformedX` | `64` |
| `FromInputHeader` | `128` |

**Underlying Type**: `System.Int32`

### `CamberCalculator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CamberCalculator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D start, Vector2D end, Double embankmentHeight, Double camberCoeff, Double culvertAngle)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CamberValue` | `Double` | `get` | No | `` |
| `EndX` | `Double` | `get` | No | `` |
| `StartX` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcCamberPoint` | `Vector2D` | `Double x` | `` |

### `CamberPoint` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CamberPoint` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.CamberPoint`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CalcMode` | `CamberCalcMode` | `get/set` | No | `` |
| `Caption` | `String` | `get/set` | No | `` |
| `TransformedX` | `Double` | `get` | No | `` |
| `TrayOffset` | `Double` | `get` | No | `` |
| `TrayX` | `Double` | `get` | No | `` |
| `Value` | `Vector2D` | `get` | No | `` |
| `Visibility` | `CamberPointVisibility` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `RefreshValues` | `Void` | `CamberCalculator calculator, Matrix culvertTransform` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetTransformedX` | `Void` | `Double x, CamberCalculator calculator, Matrix culvertTransform` | `` |
| `SetTrayOffset` | `Void` | `Double offset, CamberCalculator calculator, Matrix culvertTransform` | `` |
| `SetTrayX` | `Void` | `Double x, CamberCalculator calculator, Matrix culvertTransform` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `CamberPoint` | `StgNode node` | `` |

### `CamberPointVisibility` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CamberPointVisibility` |
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
      - `Topomatic.Culverts.Components.CamberPointVisibility`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Construction` | `CamberPointVisibility` | Yes | `Construction` | `` |
| `Default` | `CamberPointVisibility` | Yes | `Default` | `` |
| `None` | `CamberPointVisibility` | Yes | `None` | `` |
| `Profile` | `CamberPointVisibility` | Yes | `Profile` | `` |
| `Scheme` | `CamberPointVisibility` | Yes | `Scheme` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Construction` | `1` |
| `Profile` | `2` |
| `Scheme` | `4` |
| `Default` | `7` |

**Underlying Type**: `System.Int32`

### `CorrugatedArrangement` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CorrugatedArrangement` |
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
      - `Topomatic.Culverts.Components.CorrugatedArrangement`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CombineLastSections` | `CorrugatedArrangement` | Yes | `CombineLastSections` | `` |
| `CutLastSection` | `CorrugatedArrangement` | Yes | `CutLastSection` | `` |
| `Empty` | `CorrugatedArrangement` | Yes | `Empty` | `` |
| `Optimal` | `CorrugatedArrangement` | Yes | `Optimal` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Optimal` | `1` |
| `CutLastSection` | `2` |
| `CombineLastSections` | `3` |

**Underlying Type**: `System.Int32`

### `CorrugatedSectionEntry` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.CorrugatedSectionEntry` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owned)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FoundamentBottom` | `Double` | `get/set` | No | `` |
| `GroundWorksVerticalOffset` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `InnerRadius` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `LinkPropsKey` | `String` | `get/set` | No | `` |
| `Model` | `ImElement` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `OuterRadius` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `CorrugatedSectionEntry source` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `DynamicElementInsert` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.DynamicElementInsert` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BindingTagOX` | `String` | `get/set` | No | `` |
| `BindingTagOY` | `String` | `get/set` | No | `` |
| `Element` | `ClvElement` | `get/set` | No | `` |
| `OX` | `Vector3D` | `get/set` | No | `` |
| `OY` | `Vector3D` | `get/set` | No | `` |
| `Position` | `DynamicPositionInfo` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

### `DynamicPositionInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.DynamicPositionInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.DynamicPositionInfo`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `DynamicPositionInfo` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `DynamicPositionInfo value, StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BindingTagX` | `String` | No | `` | `` |
| `BindingTagY` | `String` | No | `` | `` |
| `BindingTagZ` | `String` | No | `` | `` |
| `DeltaX` | `Double` | No | `` | `` |
| `DeltaY` | `Double` | No | `` | `` |
| `DeltaZ` | `Double` | No | `` | `` |

### `Elevation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Elevation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.Elevation`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Empty` | `Elevation` | `get` | Yes | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CaptionYOffsFactor` | `Double` | No | `` | `` |
| `FormatPattern` | `String` | No | `` | `` |
| `IsLowerCaption` | `Boolean` | No | `` | `` |
| `IsRightSideCaption` | `Boolean` | No | `` | `` |
| `Value` | `Vector2D` | No | `` | `` |
| `ValueTransformed` | `Vector2D` | No | `` | `` |
| `Visibility` | `ElevationVisibility` | No | `` | `` |

### `ElevationVisibility` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.ElevationVisibility` |
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
      - `Topomatic.Culverts.Components.ElevationVisibility`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AlwaysVisible` | `ElevationVisibility` | Yes | `AlwaysVisible` | `` |
| `Empty` | `ElevationVisibility` | Yes | `Empty` | `` |
| `Invisible` | `ElevationVisibility` | Yes | `Invisible` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Visible` | `ElevationVisibility` | Yes | `Visible` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Visible` | `1` |
| `Invisible` | `2` |
| `AlwaysVisible` | `4` |

**Underlying Type**: `System.Int32`

### `FortificationSlopeCard` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.FortificationSlopeCard` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlockCount` | `Int32` | `get/set` | No | `` |
| `BlockName` | `String` | `get/set` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `FortificationSlopeCard` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `FortificationSlopeCard value, StgNode node` | `` |

### `FortificationValues` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.FortificationValues` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefaultIndexes` | `IList<Int32>` | `get` | No | `` |
| `FortificationMonolitCaption` | `String` | `get/set` | No | `` |
| `FortificationSlopeCards` | `IList<FortificationSlopeCard>` | `get` | No | `` |
| `FortificationSlopeCardsTag` | `String` | `get/set` | No | `` |
| `H025` | `Double` | `get/set` | No | `` |
| `Height1` | `Double` | `get/set` | No | `` |
| `Height2` | `Double` | `get/set` | No | `` |
| `M` | `Double` | `get/set` | No | `` |
| `N` | `Double` | `get/set` | No | `` |
| `P1BlockHeight` | `Double` | `get/set` | No | `` |
| `Pattern1` | `String` | `get/set` | No | `` |
| `Pattern2` | `String` | `get/set` | No | `` |
| `Props` | `String` | `get/set` | No | `` |
| `QToTop` | `Boolean` | `get/set` | No | `` |
| `Strengthening` | `StrengtheningBase` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

### `HeaderBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.HeaderBlock` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owned)`

#### Properties (53)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BigFoundationCount` | `Int32` | `get/set` | No | `` |
| `BigFoundationPropsKey` | `String` | `get/set` | No | `` |
| `BlockPropsKey` | `String` | `get/set` | No | `` |
| `BottomGravelEnd` | `Double` | `get/set` | No | `` |
| `Dimensions` | `DynamicComponents` | `get` | No | `` |
| `DynamicBlock` | `ImElement` | `get/set` | No | `` |
| `DynamicElements` | `List<DynamicElementInsert>` | `get` | No | `` |
| `ElementKeyAndCount` | `Dictionary<String Int32>` | `get/set` | No | `` |
| `Elements` | `List<ClvElement>` | `get` | No | `` |
| `Id` | `String` | `get/set` | No | `` |
| `LecalBlockWidth` | `Double` | `get/set` | No | `` |
| `LinkBottom` | `Double` | `get/set` | No | `` |
| `LinkOffsets` | `List<List<Double>>` | `get` | No | `` |
| `LinkPropsKey` | `String` | `get/set` | No | `` |
| `LinkToPortalDistance` | `Double` | `get/set` | No | `` |
| `MiddleToLinkDistance` | `Double` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PitWidthLink` | `Double` | `get/set` | No | `` |
| `PitWidthPortal` | `Double` | `get/set` | No | `` |
| `PitWidthSlope` | `Double` | `get/set` | No | `` |
| `PlanBlock` | `String` | `get/set` | No | `` |
| `PortalBottom` | `Vector2D` | `get/set` | No | `` |
| `PortalCount` | `Int32` | `get/set` | No | `` |
| `PortalEnd` | `Vector2D` | `get/set` | No | `` |
| `PortalOuterCount` | `Int32` | `get/set` | No | `` |
| `PortalOuterPropsKey` | `String` | `get/set` | No | `` |
| `PortalPlateCount` | `Int32` | `get/set` | No | `` |
| `PortalPlatePropsKey` | `String` | `get/set` | No | `` |
| `PortalPropsKey` | `String` | `get/set` | No | `` |
| `PortalSlice` | `Double` | `get/set` | No | `` |
| `PortalTop` | `Vector2D` | `get/set` | No | `` |
| `PortalWallWidth` | `Double` | `get/set` | No | `` |
| `ProfileBlock` | `String` | `get/set` | No | `` |
| `ProtectiveShieldCount` | `Int32` | `get/set` | No | `` |
| `ProtectiveShieldPropsKey` | `String` | `get/set` | No | `` |
| `SectionOffsets` | `List<Double>` | `get` | No | `` |
| `SlopeEnd` | `Double` | `get/set` | No | `` |
| `SlopeExtandedPropsKey` | `String` | `get/set` | No | `` |
| `SlopeLeftEnd` | `Vector2D` | `get/set` | No | `` |
| `SlopeLeftStart` | `Vector2D` | `get/set` | No | `` |
| `SlopeOuterTop` | `Vector2D` | `get/set` | No | `` |
| `SlopePlateExtandedPropsKey` | `String` | `get/set` | No | `` |
| `SlopePlatePropsKey` | `String` | `get/set` | No | `` |
| `SlopePropsKey` | `String` | `get/set` | No | `` |
| `SlopeRightEnd` | `Vector2D` | `get/set` | No | `` |
| `SlopeRightStart` | `Vector2D` | `get/set` | No | `` |
| `SmallFoundationCount` | `Int32` | `get/set` | No | `` |
| `SmallFoundationPropsKey` | `String` | `get/set` | No | `` |
| `TrayPortal` | `Double` | `get/set` | No | `` |
| `U1AddFull` | `Boolean` | `get/set` | No | `` |
| `U1AddOuter` | `Boolean` | `get/set` | No | `` |
| `U1Height` | `Double` | `get/set` | No | `` |
| `U1StartY` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ISectionsContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.ISectionsContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SectionsExist` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinksOffsets` | `List<Double>` | `String sectionKey` | `` |
| `GetSectionOffset` | `Double` | `String sectionKey` | `` |
| `GetSectionsKeys` | `List<String>` | `` | `` |

### `MiddlePartBuildDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.MiddlePartBuildDirection` |
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
      - `Topomatic.Culverts.Components.MiddlePartBuildDirection`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `MiddlePartBuildDirection` | Yes | `Left` | `` |
| `Middle` | `MiddlePartBuildDirection` | Yes | `Middle` | `` |
| `Right` | `MiddlePartBuildDirection` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Middle` | `1` |
| `Right` | `2` |

**Underlying Type**: `System.Int32`

### `SectionIndex` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.SectionIndex` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.SectionIndex`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SectionIndex` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Index` | `Int32` | No | `` | `` |
| `Side` | `Int32` | No | `` | `` |

### `SectionInsert` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.SectionInsert` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PlacedElements` | `List<ClvElement>` | `get` | No | `` |
| `Section` | `AllowedSection` | `get/set` | No | `` |
| `Side` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPosition` | `Vector3D` | `` | `` |
| `SetPosition` | `Void` | `Vector3D position` | `` |

---
## Namespace: `Topomatic.Culverts.Components.BaseBuilders`

### `BaseBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(BasePart owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Grade` | `Double` | `get/set` | No | `` |
| `HeightUnderMiddle` | `Double` | `get/set` | No | `` |
| `TopOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `BasePart owner, StgNode node, ISerializationContext context, ref BaseBuilder builder` | `` |

### `BaseBuilderWithCementEarthLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithCementEarthLayer` |
| **Base Type** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder`
    - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithCementEarthLayer`

#### Constructors (1)

- `.ctor(BasePart owner)`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"BaseBuilderWithCementEarthLayer"` | `` |

### `BaseBuilderWithPortalPlateBottomConst` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithPortalPlateBottomConst` |
| **Base Type** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder`
    - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithPortalPlateBottomConst`

#### Constructors (1)

- `.ctor(BasePart owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InputBottomOffset` | `Double` | `get/set` | No | `` |
| `InputHeaderPositions` | `IList<Vector2D>` | `get/set` | No | `` |
| `OutputBottomOffset` | `Double` | `get/set` | No | `` |
| `OutputHeaderPositions` | `IList<Vector2D>` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBaseLayer` | `Void` | `Double layerTopDY, Double layerBotDY, String hatchPatternName, Double hatchPatternScale` | `` |
| `AddBaseLayer` | `Void` | `Double layerTopDY, Double layerBotDY, String hatchPatternName, Double hatchPatternScale, String text, Double textDX` | `` |
| `AddInvisibleBaseLayer` | `Void` | `Double layerTopDY, Double layerBotDY, String text, Double textDX` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"BaseBuilderWithPortalPlateBottomConst"` | `` |

### `BaseBuilderWithPortalPlateTopConst` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithPortalPlateTopConst` |
| **Base Type** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder`
    - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilderWithPortalPlateTopConst`

#### Constructors (1)

- `.ctor(BasePart owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HeaderLength` | `Double` | `get/set` | No | `` |
| `HeaderPositions` | `IList<Vector2D>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"BaseBuilderWithPortalPlateTopConst"` | `` |

### `BaseElementInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseElementInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.BaseBuilders.BaseElementInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `BaseElementInfo` | `StgNode node, ISerializationContext context` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Color` | `Color` | No | `` | `` |
| `Documents` | `ImDocuments` | No | `` | `` |
| `IsHidden` | `Boolean` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Properties` | `ImProperties` | No | `` | `` |
| `SectionContour` | `IList<Vector2D>` | No | `` | `` |
| `Tags` | `IList<String>` | No | `` | `` |

### `BaseLayerInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.BaseLayerInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.BaseBuilders.BaseLayerInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `BaseLayerInfo` | `StgNode node, ISerializationContext context` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Color` | `Color` | No | `` | `` |
| `Documents` | `ImDocuments` | No | `` | `` |
| `HatchName` | `String` | No | `` | `` |
| `HatchScale` | `Double` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Properties` | `ImProperties` | No | `` | `` |
| `Tags` | `IList<String>` | No | `` | `` |
| `Text` | `String` | No | `` | `` |
| `UseTextMirror` | `Boolean` | No | `` | `` |

### `ComponentFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.ComponentFlags` |
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
      - `Topomatic.Culverts.Components.BaseBuilders.ComponentFlags`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `ComponentFlags` | Yes | `Empty` | `` |
| `LeftSide` | `ComponentFlags` | Yes | `LeftSide` | `` |
| `RightSide` | `ComponentFlags` | Yes | `RightSide` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `LeftSide` | `1` |
| `RightSide` | `2` |

**Underlying Type**: `System.Int32`

### `StepInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.StepInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.BaseBuilders.StepInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StepInfo` | `StgNode node, ISerializationContext context` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BaseLayers` | `IList<BaseLayerInfo>` | No | `` | `` |
| `BaseSectionContours` | `IList<IList<Vector2D>>` | No | `` | `` |
| `Height` | `Double` | No | `` | `` |
| `IsVerticalSlope` | `Boolean` | No | `` | `` |
| `Length` | `Double` | No | `` | `` |
| `Slope` | `Double` | No | `` | `` |

### `SteppedBaseBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.BaseBuilders.SteppedBaseBuilder` |
| **Base Type** | `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Components.BaseBuilders.BaseBuilder`
    - `Topomatic.Culverts.Components.BaseBuilders.SteppedBaseBuilder`

#### Constructors (1)

- `.ctor(BasePart owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InputHeaderPositions` | `List<Vector2D>` | `get` | No | `` |
| `InputSteps` | `List<StepInfo>` | `get` | No | `` |
| `MiddleBaseElements` | `List<BaseElementInfo>` | `get` | No | `` |
| `MiddleBaseHatchName` | `String` | `get/set` | No | `` |
| `MiddleBaseHatchScale` | `Double` | `get/set` | No | `` |
| `OutputHeaderPositions` | `List<Vector2D>` | `get` | No | `` |
| `OutputSteps` | `List<StepInfo>` | `get` | No | `` |
| `ProfileComponentFlags` | `List<ComponentFlags>` | `get` | No | `` |
| `ProfileComponents` | `List<DynamicComponent>` | `get` | No | `` |
| `TrimMiddlePartBase` | `Boolean` | `get/set` | No | `` |
| `UniteMiddleBase` | `Boolean` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"SteppedBaseBuilder"` | `` |

---
## Namespace: `Topomatic.Culverts.Components.Parts`

### `BasePart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.BasePart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.BasePart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseBuilder` | `BaseBuilder` | `get/set` | No | `` |
| `HeightUnderInputPortal` | `Double` | `get/set` | No | `` |
| `HeightUnderOutputPortal` | `Double` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"BasePart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BedBlock` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.BedPart+BedBlock` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.Parts.BedPart+BedBlock`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `BedBlock` | `BedPart bedPart, StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `BedBlock block, StgNode node, ISerializationContext context` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Components` | `DwgComponents` | No | `` | `` |
| `Elements` | `List<ClvElement>` | No | `` | `` |
| `Id` | `String` | No | `` | `` |
| `PlanBlock` | `String` | No | `` | `` |
| `PropsKey` | `String` | No | `` | `` |
| `SectionBlock` | `String` | No | `` | `` |

### `BedPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.BedPart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.BedPart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Dimensions` | `DynamicComponents` | `get` | No | `` |
| `InsideBlockLeft` | `BedBlock` | `get/set` | No | `` |
| `InsideBlockRight` | `BedBlock` | `get/set` | No | `` |
| `OutsideBlockLeft` | `BedBlock` | `get/set` | No | `` |
| `OutsideBlockRight` | `BedBlock` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"BedPart"` | `` |

#### Nested Types (1)

- `BedBlock` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElevationsPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.ElevationsPart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.ElevationsPart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CamberCalcMode` | `CamberCalcMode` | `get/set` | No | `` |
| `CamberCoeff` | `Double` | `get/set` | No | `` |
| `CamberCount` | `Int32` | `get/set` | No | `` |
| `CamberPoints` | `List<CamberPoint>` | `get` | No | `` |
| `CamberStep` | `Double` | `get/set` | No | `` |
| `IsCamberDirectionFromInput` | `Boolean` | `get/set` | No | `` |
| `UserCamberPoints` | `IList<CamberPoint>` | `get` | No | `` |
| `UseUserCamberPoints` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCalculator` | `CamberCalculator` | `` | `` |
| `SupportsCalcMode` | `Boolean` | `CamberCalcMode mode` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"ElevationsPart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `HeaderPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.HeaderPart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer, Topomatic.Culverts.Components.ISectionsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.HeaderPart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (23)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AliformSandLabelPos` | `Vector2D` | `get/set` | No | `` |
| `AliformSandLabelText` | `String` | `get/set` | No | `` |
| `DimensionOffset` | `Double` | `get/set` | No | `` |
| `DistanceBetweenAxis` | `Double` | `get/set` | No | `` |
| `DrawObliqueFortificationConcrete` | `Boolean` | `get/set` | No | `` |
| `DrawVerticalFortificationDimension` | `Boolean` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `InsideBlockLeft` | `HeaderBlock` | `get` | No | `` |
| `InsideBlockRight` | `HeaderBlock` | `get` | No | `` |
| `InsideFortificationLeft` | `FortificationValues` | `get` | No | `` |
| `InsideFortificationRight` | `FortificationValues` | `get` | No | `` |
| `LinkHeight` | `Double` | `get/set` | No | `` |
| `OutsideBlockLeft` | `HeaderBlock` | `get` | No | `` |
| `OutsideBlockRight` | `HeaderBlock` | `get` | No | `` |
| `OutsideFortificationLeft` | `FortificationValues` | `get` | No | `` |
| `OutsideFortificationRight` | `FortificationValues` | `get` | No | `` |
| `SandHatchPattern` | `String` | `get/set` | No | `` |
| `SandHatchScale` | `Double` | `get/set` | No | `` |
| `SandOverPipe` | `Double` | `get/set` | No | `` |
| `SectionsExist` | `Boolean` | `get` | No | `` |
| `ShieldLabelPos` | `Vector2D` | `get/set` | No | `` |
| `ShieldLabelText` | `String` | `get/set` | No | `` |
| `StoneHeightUnderPortal` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinksOffsets` | `List<Double>` | `String sectionKey` | `` |
| `GetSectionOffset` | `Double` | `String sectionKey` | `` |
| `GetSectionsKeys` | `List<String>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"HeaderPart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISectionsContainer` | `get_SectionsExist` |
| `ISectionsContainer` | `GetSectionsKeys` |
| `ISectionsContainer` | `GetSectionOffset` |
| `ISectionsContainer` | `GetLinksOffsets` |

### `HydraulicPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.HydraulicPart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.HydraulicPart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CalculationType` | `HydraulicCalculationType` | `get/set` | No | `` |
| `FlowType` | `HydraulicFlowType` | `get/set` | No | `` |
| `HeightOrDiameter` | `Double` | `get/set` | No | `` |
| `IsConicalOrHeightenedHead` | `Boolean` | `get/set` | No | `` |
| `WaterConsumption` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCalculator` | `HydraulicCalculator` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"HydraulicPart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MiddlePart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.MiddlePart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer, Topomatic.Culverts.Components.ISectionsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.MiddlePart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowedSections` | `IList<AllowedSection>` | `get` | No | `` |
| `BoundingShell` | `Shell` | `get/set` | No | `` |
| `BuildDirection` | `MiddlePartBuildDirection` | `get/set` | No | `` |
| `CustomBuild` | `Boolean` | `get/set` | No | `` |
| `CustomLinks` | `IList<SectionIndex>` | `get` | No | `` |
| `DistanceBetweenAxis` | `Double` | `get/set` | No | `` |
| `DistanceBetweenSection` | `Double` | `get/set` | No | `` |
| `DynamicElements` | `List<DynamicElementInsert>` | `get` | No | `` |
| `ExcludedLinks` | `IList<Int32>` | `get` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `InletShellExtension` | `Double` | `get/set` | No | `` |
| `LeftHeaderInside` | `Double` | `get/set` | No | `` |
| `LeftHeaderOffset` | `Double` | `get` | No | `` |
| `LeftHeaderOutside` | `Double` | `get/set` | No | `` |
| `LeftInputAliformLength` | `Double` | `get/set` | No | `` |
| `LeftOutputAliformLength` | `Double` | `get/set` | No | `` |
| `OutletShellExtension` | `Double` | `get/set` | No | `` |
| `PlacedLinks` | `IEnumerable<SectionIndex>` | `get` | No | `` |
| `RightHeaderInside` | `Double` | `get/set` | No | `` |
| `RightHeaderOffset` | `Double` | `get` | No | `` |
| `RightHeaderOutside` | `Double` | `get/set` | No | `` |
| `RightInputAliformLength` | `Double` | `get/set` | No | `` |
| `RightOutputAliformLength` | `Double` | `get/set` | No | `` |
| `SectionsExist` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinksOffsets` | `List<Double>` | `String sectionKey` | `` |
| `GetSectionOffset` | `Double` | `String sectionKey` | `` |
| `GetSectionsKeys` | `List<String>` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LEFT_SIDE` | `Int32` | Yes | `-1` | `` |
| `MONIKER` | `String` | Yes | `"MiddlePart"` | `` |
| `RIGHT_SIDE` | `Int32` | Yes | `1` | `` |
| `UNKNOW_SIDE` | `Int32` | Yes | `0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISectionsContainer` | `get_SectionsExist` |
| `ISectionsContainer` | `GetSectionsKeys` |
| `ISectionsContainer` | `GetSectionOffset` |
| `ISectionsContainer` | `GetLinksOffsets` |

### `MiddlePartGofr` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.MiddlePartGofr` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer, Topomatic.Culverts.Components.ISectionsContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.MiddlePartGofr`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Arrangement` | `CorrugatedArrangement` | `get/set` | No | `` |
| `BuildDirection` | `MiddlePartBuildDirection` | `get/set` | No | `` |
| `ConnectingBand` | `CorrugatedSectionEntry` | `get` | No | `` |
| `CutOblique` | `Boolean` | `get/set` | No | `` |
| `CuttingHeight` | `Double` | `get/set` | No | `` |
| `DistanceBetweenAxis` | `Double` | `get/set` | No | `` |
| `EndLinkPropsKey` | `String` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `L1CountInSection` | `Int32` | `get/set` | No | `` |
| `L1PropsKey` | `String` | `get/set` | No | `` |
| `LeftHeaderOffset` | `Double` | `get/set` | No | `` |
| `Link` | `CorrugatedSectionEntry` | `get` | No | `` |
| `MaxSectionLength` | `Double` | `get/set` | No | `` |
| `MinOutlet` | `Double` | `get/set` | No | `` |
| `RightHeaderOffset` | `Double` | `get/set` | No | `` |
| `SectionsExist` | `Boolean` | `get` | No | `` |
| `SectionZOffset` | `Double` | `get/set` | No | `` |
| `ShellRadius` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinksOffsets` | `List<Double>` | `String sectionKey` | `` |
| `GetSectionOffset` | `Double` | `String sectionKey` | `` |
| `GetSectionsKeys` | `List<String>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MiddlePartGofr"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISectionsContainer` | `get_SectionsExist` |
| `ISectionsContainer` | `GetSectionsKeys` |
| `ISectionsContainer` | `GetSectionOffset` |
| `ISectionsContainer` | `GetLinksOffsets` |

### `MiddlePartScaled` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.MiddlePartScaled` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.MiddlePartScaled`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderingAngle` | `ImElement` | `get/set` | No | `` |
| `BuildDirection` | `MiddlePartBuildDirection` | `get/set` | No | `` |
| `CurvatureRadius` | `Double` | `get/set` | No | `` |
| `DistanceBetweenAxes` | `Double` | `get/set` | No | `` |
| `EffectiveWidth` | `Double` | `get/set` | No | `` |
| `ExcessiveArc` | `Double` | `get/set` | No | `` |
| `HeaderSheet` | `ImElement` | `get/set` | No | `` |
| `HeaderSheetCount` | `Int32` | `get/set` | No | `` |
| `InputHeaderOffset` | `Double` | `get/set` | No | `` |
| `MetalThickness` | `Double` | `get/set` | No | `` |
| `MinOutlet` | `Double` | `get/set` | No | `` |
| `OutputHeaderOffset` | `Double` | `get/set` | No | `` |
| `SectionBottom` | `Double` | `get/set` | No | `` |
| `SectionCount` | `Int32` | `get/set` | No | `` |
| `Sheet` | `ImElement` | `get/set` | No | `` |
| `SheetCount` | `Int32` | `get/set` | No | `` |
| `SheetWidth` | `Double` | `get/set` | No | `` |
| `TrayHeight` | `Double` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MiddlePartScaled"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SectionPart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.SectionPart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.SectionPart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlockSectionName` | `String` | `get/set` | No | `` |
| `Dimensions` | `DynamicComponents` | `get` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"SectionPart"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Volume` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.VolumePart+Volume` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Components.Parts.VolumePart+Volume`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsCalculated` | `Boolean` | No | `` | `` |
| `Value` | `String` | No | `` | `` |

### `VolumePart` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Components.Parts.VolumePart` |
| **Base Type** | `Topomatic.Culverts.ConstructionComponent` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Visualization.IStgContextSerializable, Topomatic.FoundationClasses.IOwned, Topomatic.Dwg.IDrawingContainer, Topomatic.Culverts.ICulvertContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.ConstructionComponent`
        - `Topomatic.Culverts.Components.Parts.VolumePart`

#### Constructors (1)

- `.ctor(Construction owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ExcavationCalculateType` | `ExcavationCalculateType` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddCalculatedVolume` | `Void` | `String key, String value` | `` |
| `AddElementsCountVolume` | `Void` | `String key, String[] elementTags` | `` |
| `AddStaticVolume` | `Void` | `String key, Double value` | `` |
| `AddStaticVolume` | `Void` | `String key, String value` | `` |
| `AddSumOfImPropsVolume` | `Void` | `String key, String propertyTag, String[] elementTags` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"VolumePart"` | `` |

#### Nested Types (1)

- `Volume` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Culverts.ConstructionData`

### `DataContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.DataContext` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String key, DataContextItem<T> value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `String key, ref T value` | `` |

### `DataContextItem` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.DataContextItem` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `StgNode node, ref DataContextItem item` | `` |

### `DataContextItem`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.DataContextItem`1` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `T` | `get/set` | No | `` |

### `DoubleListWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.DoubleListWrapper` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.DoubleListWrapper`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IList<Double> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IList<Double>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"DoubleListWrapper"` | `` |

### `DynamicModelData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.DynamicModelData` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IDictionary`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IDictionary`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.DynamicModelData`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IDictionary<String Double> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IDictionary<String Double>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"DynamicModelData"` | `` |

### `IntegerListWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.IntegerListWrapper` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.IntegerListWrapper`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IList<Int32> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IList<Int32>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"IntegerListWrapper"` | `` |

### `MiddlePartSteps` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.MiddlePartSteps` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D[], Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D[], Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.MiddlePartSteps`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IList<Vector2D[]> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IList<Vector2D[]>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MiddlePartSteps"` | `` |

### `Vector2DListWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.Vector2DListWrapper` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.Vector2DListWrapper`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IList<Vector2D> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IList<Vector2D>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"Vector2DListWrapper"` | `` |

### `Vector3DListWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionData.Vector3DListWrapper` |
| **Base Type** | `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionData.DataContextItem`
    - `Topomatic.Culverts.ConstructionData.DataContextItem`1[[System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
      - `Topomatic.Culverts.ConstructionData.Vector3DListWrapper`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IList<Vector3D> value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `IList<Vector3D>` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"Vector3DListWrapper"` | `` |

---
## Namespace: `Topomatic.Culverts.ConstructionTree`

### `BoolOperationKinds` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.BoolOperationKinds` |
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
      - `Topomatic.Culverts.ConstructionTree.BoolOperationKinds`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Difference` | `BoolOperationKinds` | Yes | `Difference` | `` |
| `Empty` | `BoolOperationKinds` | Yes | `Empty` | `` |
| `Intersection` | `BoolOperationKinds` | Yes | `Intersection` | `` |
| `Union` | `BoolOperationKinds` | Yes | `Union` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Union` | `1` |
| `Difference` | `2` |
| `Intersection` | `3` |

**Underlying Type**: `System.Int32`

### `ClvElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.ClvElement` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HoleBinding` | `Int32` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Parent` | `ClvElement` | `get` | No | `` |
| `SelectionFlags` | `ClvView` | `get/set` | No | `` |
| `Tags` | `HashSet<String>` | `get` | No | `` |
| `VisibilityFlags` | `ClvView` | `get/set` | No | `` |

#### Instance Methods (25)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddChild` | `Void` | `ClvElement child` | `` |
| `BuildCompoundModel` | `Void` | `Compound3DElement container` | `` |
| `Clone` | `ClvElement` | `` | `` |
| `ConfigureCompoundModel` | `Void` | `String name, String typeId, ImProperties props` | `` |
| `ConfigureModel` | `Void` | `ImElement model` | `` |
| `DoTraversal` | `Void` | `List<ClvElement> result` | `` |
| `DoTraversal` | `Void` | `Predicate<ClvElement> filter, List<ClvElement> result` | `` |
| `DoTraversal` | `Void` | `Action<ClvElement> action` | `` |
| `GetChildren` | `List<ClvElement>` | `` | `` |
| `GetGlobalOXOY` | `Void` | `ref Vector3D ox, ref Vector3D oy` | `` |
| `GetGlobalPosition` | `Vector3D` | `` | `` |
| `GetLevel` | `Int32` | `` | `` |
| `GetLocalOXOY` | `Void` | `ref Vector3D ox, ref Vector3D oy` | `` |
| `GetLocalPosition` | `Vector3D` | `` | `` |
| `GetModel` | `ImElement` | `` | `` |
| `GetParents` | `List<ClvElement>` | `` | `` |
| `GetSelectableElements` | `Void` | `ClvView view, List<ClvElement> result` | `` |
| `GetViewEntities` | `Void` | `ClvView view, DwgBlock container` | `` |
| `IsVisible` | `Boolean` | `ClvView view` | `` |
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `RemoveChild` | `Void` | `ClvElement child` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetLocalOXOY` | `Void` | `Vector3D ox, Vector3D oy` | `` |
| `SetLocalPosition` | `Void` | `Vector3D localPosition` | `` |
| `SetOrigin` | `Void` | `Vector3D origin` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HOLE_BINDING_EMPTY` | `Int32` | Yes | `0` | `` |
| `HOLE_BINDING_NOT_BINDED` | `Int32` | Yes | `-1` | `` |

### `ClvTreeOperation` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.ClvTreeOperation` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `ClvElement rootElement` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `StgNode node, ref ClvTreeOperation operation` | `` |

### `ClvView` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.ClvView` |
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
      - `Topomatic.Culverts.ConstructionTree.ClvView`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `ClvView` | Yes | `All` | `` |
| `None` | `ClvView` | Yes | `None` | `` |
| `Plan` | `ClvView` | Yes | `Plan` | `` |
| `Profile` | `ClvView` | Yes | `Profile` | `` |
| `value__` | `Int32` | No | `` | `` |
| `View3D` | `ClvView` | Yes | `View3D` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Profile` | `1` |
| `Plan` | `2` |
| `View3D` | `4` |
| `All` | `7` |

**Underlying Type**: `System.Int32`

### `CopyViewOperation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.CopyViewOperation` |
| **Base Type** | `Topomatic.Culverts.ConstructionTree.ClvTreeOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionTree.ClvTreeOperation`
    - `Topomatic.Culverts.ConstructionTree.CopyViewOperation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RemoveSourceElement` | `Boolean` | `get/set` | No | `` |
| `SourceElementTag` | `String` | `get/set` | No | `` |
| `SourceElementViews` | `IList<Model3DView>` | `get/set` | No | `` |
| `TargetElementTag` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `ClvElement rootElement` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"CopyViewOperation"` | `` |

### `SeparateShellOperation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.SeparateShellOperation` |
| **Base Type** | `Topomatic.Culverts.ConstructionTree.ClvTreeOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionTree.ClvTreeOperation`
    - `Topomatic.Culverts.ConstructionTree.SeparateShellOperation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SourceElementsTag` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `ClvElement rootElement` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"SeparateShellOperation"` | `` |

### `SolidBoolOperation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.ConstructionTree.SolidBoolOperation` |
| **Base Type** | `Topomatic.Culverts.ConstructionTree.ClvTreeOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.ConstructionTree.ClvTreeOperation`
    - `Topomatic.Culverts.ConstructionTree.SolidBoolOperation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DiscardElementTags` | `IList<String>` | `get/set` | No | `` |
| `OperationKind` | `BoolOperationKinds` | `get/set` | No | `` |
| `RemoveSourceElement` | `Boolean` | `get/set` | No | `` |
| `RemoveTargetElements` | `Boolean` | `get/set` | No | `` |
| `ResultColor` | `Color` | `get/set` | No | `` |
| `ResultContainerTag` | `String` | `get/set` | No | `` |
| `ResultHoleBinding` | `Int32` | `get/set` | No | `` |
| `ResultName` | `String` | `get/set` | No | `` |
| `ResultSelectionFlags` | `ClvView` | `get/set` | No | `` |
| `ResultTags` | `IList<String>` | `get/set` | No | `` |
| `ResultTypeId` | `String` | `get/set` | No | `` |
| `ResultVisibilityFlags` | `ClvView` | `get/set` | No | `` |
| `SeparateResultShell` | `Boolean` | `get/set` | No | `` |
| `SimplifyResultEdges` | `Boolean` | `get/set` | No | `` |
| `SimplifyResultFaces` | `Boolean` | `get/set` | No | `` |
| `SourceElementTag` | `String` | `get/set` | No | `` |
| `TargetElementsTag` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Void` | `ClvElement rootElement` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"SolidBoolOperation"` | `` |

---
## Namespace: `Topomatic.Culverts.Dwg`

### `DwgTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.DwgTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDiameterDimension` | `Void` | `Vector2D center, Double diameter, Boolean showRadius, Double wallThickness, Boolean showThickness, Boolean isLeftSide, Double angle, DynamicComponentType type, DynamicComponents components` | `` |
| `AddDiameterDimension` | `Void` | `Vector2D center, Double diameter, DynamicComponentType type, DynamicComponents components` | `` |
| `AddHorizontalDimension` | `Void` | `Double x1, Double x2, Double y1, Double y2, DynamicComponentType type, DynamicComponents components` | `` |
| `AddLeader` | `Void` | `DynamicComponents components, DynamicComponentType type, String text, Boolean mirror, Vector2D position, Vector2D[] basePoints` | `` |
| `AddSlopeCaption` | `Void` | `Vector2D start, Vector2D end, Boolean isUpperSide, DynamicComponentType type, DynamicComponents components` | `` |
| `AddVerticalDimension` | `Void` | `Double y1, Double y2, Double x1, Double x2, DynamicComponentType type, DynamicComponents components` | `` |
| `CreateDwgPolyline` | `DwgPolyline` | `IPolyline3D polyline3D, Drawing drawing` | `` |
| `CreateGroundHatch` | `Void` | `DwgBlock container, Boolean absoluteAngle, Vector2D[] ground` | `` |
| `CreateHatch` | `Void` | `IList<BugleVector2D> points, IList<IList<BugleVector2D>> excludedContours, String hatchPatternName, Double hatchScale, Double hatchPatternAngle, DwgBlock container` | `` |
| `CreateHatch` | `Void` | `IList<BugleVector2D> points, IList<BugleVector2D> excludedPoints, String hatchPatternName, Double hatchScale, Double hatchPatternAngle, DwgBlock container` | `` |
| `CreateHatch` | `Void` | `DwgBlock container, String hatchPatternName, Double hatchScale, Double hatchPatternAngle, BugleVector2D[] points` | `` |
| `CreateHatch` | `Void` | `IList<BugleVector2D> points, String hatchPatternName, Double hatchScale, Double hatchPatternAngle, DwgBlock container` | `` |
| `CreateHatch` | `DwgHatch` | `IList<BugleVector2D> points, IList<IList<BugleVector2D>> excludedContours, String hatchPatternName, Double hatchScale, Double hatchPatternAngle, Drawing drawing` | `` |
| `CreateHatch` | `Void` | `DwgBlock container, AreaSign areaSign, BugleVector2D[] points` | `` |
| `CreateOutline` | `DwgPolyline` | `Drawing drawing, Boolean closed, DwgLinetype linetype, BugleVector2D[] points` | `` |
| `CreateOutline` | `DwgPolyline` | `Drawing drawing, Boolean closed, DwgLinetype linetype, Vector2D[] points` | `` |
| `CreateOutline` | `Void` | `DwgBlock container, Boolean closed, DwgLinetype linetype, Vector2D[] points` | `` |
| `CreateOutline` | `Void` | `DwgBlock container, Boolean closed, DwgLinetype linetype, BugleVector2D[] points` | `` |
| `CreatePolyline3D` | `Polyline3D` | `DwgPolyline dwgPolyline` | `` |
| `CreateSettings` | `Dictionary<String Object>` | `DwgText tagEntity, Double textHeightScale` | `` |
| `GetDashDotLineType` | `DwgLinetype` | `Drawing drawing` | `` |
| `GetDashedLineType` | `DwgLinetype` | `Drawing drawing` | `` |
| `TryClipPolylineByLine` | `Boolean` | `IPolyline3D polyline, Vector2D a, Vector2D b, ref List<IPolyline3D> fragments` | `` |

### `PlanUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.PlanUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCaptionEntities` | `EntityCollection<DwgEntity>` | `Culvert culvert, CadColor color, Double annotationScale, Double stationDelta` | `` |
| `CreateElevationEntities` | `EntityCollection<DwgEntity>` | `Culvert culvert, CadColor color, Boolean isStartElevation, Vector2D offset, Double rotation` | `` |
| `CreatePlanAxisEntities` | `EntityCollection<DwgEntity>` | `Culvert culvert, CadColor color` | `` |
| `CreateSimplifiedRepresentationEntities` | `EntityCollection<DwgEntity>` | `Culvert culvert, CadColor color` | `` |
| `TryGetAxisPoints` | `Boolean` | `Culvert culvert, ref Vector2D start, ref Vector2D center, ref Vector2D end` | `` |
| `TryGetCaptionAxis` | `Boolean` | `Culvert culvert, ref Vector2D axisStart, ref Vector2D axisEnd` | `` |
| `TryGetCulvertPositions` | `Boolean` | `Culvert culvert, ref Vector2D axisStart, ref Vector2D axisEnd, ref Vector2D leftStart, ref Vector2D leftEnd, ref Vector2D rightStart, ref Vector2D rightEnd` | `` |
| `TryGetElevationLeaderPos` | `Boolean` | `Culvert culvert, Boolean isStartElevation, ref Vector2D pos, ref Vector3D elevation` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SIMPLIFIED_REPRESENTATION_EDGE_EXTRA_WIDTH` | `Double` | Yes | `0.5` | `` |

---
## Namespace: `Topomatic.Culverts.Dwg.Components`

### `CachedComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.CachedComponent` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.DwgComponent`
    - `Topomatic.Culverts.Dwg.Components.CachedComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SourceEntities` | `List<DwgEntity>` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"CachedComponent"` | `` |

### `DwgComponent` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Behaviors` | `List<DwgComponentBehavior>` | `get` | No | `` |
| `Id` | `String` | `get/set` | No | `` |
| `IsVisible` | `Boolean` | `get/set` | No | `` |
| `Tags` | `HashSet<String>` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `DwgComponent` | `Culvert culvert` | `` |
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetEntities` | `EntityCollection<DwgEntity>` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `Refresh` | `Void` | `Drawing drawing, DwgLayer layer, Matrix matrix, IDictionary<String Object> settings` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `Culvert culvert, StgNode node, ref DwgComponent component` | `` |

### `DwgComponents` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.DwgComponents` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Culverts.Dwg.Components.DwgComponents`

#### Constructors (1)

- `.ctor(Culvert culvert, Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddComponents` | `Void` | `DwgKeys key, DwgComponent[] components` | `` |
| `Clear` | `Void` | `` | `` |
| `GetComponents` | `IList<DwgComponent>` | `DwgKeys key` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `DwgComponentSettings` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.DwgComponentSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TEXT_HEIGHT` | `String` | Yes | `"text_height"` | `` |
| `TEXT_OBLIQUE` | `String` | Yes | `"text_oblique"` | `` |
| `TEXT_RATIO` | `String` | Yes | `"text_ratio"` | `` |
| `TEXT_STYLE` | `String` | Yes | `"text_style"` | `` |

### `DwgComponentTags` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.DwgComponentTags` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DIMENSION` | `String` | Yes | `"dimension"` | `` |
| `ELEVATION` | `String` | Yes | `"elevation"` | `` |
| `LEADER` | `String` | Yes | `"leader"` | `` |
| `SECTION` | `String` | Yes | `"section"` | `` |
| `TEXT` | `String` | Yes | `"text"` | `` |

### `ElevationComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.ElevationComponent` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.DwgComponent`
    - `Topomatic.Culverts.Dwg.Components.ElevationComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsInvertedMarker` | `Boolean` | `get/set` | No | `` |
| `IsLeftSideLeader` | `Boolean` | `get/set` | No | `` |
| `MarkOffset` | `Vector2D` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"ElevationComponent"` | `` |

### `LeaderComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.LeaderComponent` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.DwgComponent`
    - `Topomatic.Culverts.Dwg.Components.LeaderComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoints` | `List<Vector2D>` | `get` | No | `` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Text` | `String` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"LeaderComponent"` | `` |

### `MockupItemInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.MockupItemInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Dwg.Components.MockupItemInfo`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector2D` | `get` | No | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Flipped` | `Boolean` | No | `` | `` |
| `Hidden` | `Boolean` | No | `` | `` |
| `Id` | `String` | No | `` | `` |
| `InitialPosition` | `Vector2D` | No | `` | `` |
| `Offset` | `Vector2D` | No | `` | `` |
| `Ratio` | `Double` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |

### `MultilineLeaderComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.MultilineLeaderComponent` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.DwgComponent`
    - `Topomatic.Culverts.Dwg.Components.MultilineLeaderComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoints` | `List<Vector2D>` | `get` | No | `` |
| `CreateArrow` | `Boolean` | `get/set` | No | `` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Position` | `Vector2D` | `get/set` | No | `` |
| `Text` | `List<MultilineLeaderTextEntry>` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MultilineLeaderComponent"` | `` |

### `MultilineLeaderTextEntry` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.MultilineLeaderTextEntry` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Dwg.Components.MultilineLeaderTextEntry`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `MultilineLeaderTextEntry` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FirstText` | `String` | No | `` | `` |
| `LastText` | `String` | No | `` | `` |
| `LastTextSpacing` | `Double` | No | `` | `` |

### `SectionComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.SectionComponent` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.DwgComponent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.DwgComponent`
    - `Topomatic.Culverts.Dwg.Components.SectionComponent`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndCaption` | `String` | `get/set` | No | `` |
| `Inverted` | `Boolean` | `get/set` | No | `` |
| `Positions` | `List<Vector2D>` | `get` | No | `` |
| `StartCaption` | `String` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox2D` | `` | `` |
| `GetMockupItem` | `MockupItemInfo` | `String tag` | `` |
| `GetMockupPositionTags` | `List<String>` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY, Double deltaZ` | `` |
| `PrepareMockup` | `Void` | `MockupItemInfo mockupItem` | `` |
| `SetLayer` | `Void` | `DwgLayer layer` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"SectionComponent"` | `` |

---
## Namespace: `Topomatic.Culverts.Dwg.Components.Behaviors`

### `AliformLeaderBehavior` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.AliformLeaderBehavior` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior`
    - `Topomatic.Culverts.Dwg.Components.Behaviors.AliformLeaderBehavior`

#### Constructors (1)

- `.ctor(Culvert culvert, DwgComponent associatedComponent)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsInputHeader` | `Boolean` | `get/set` | No | `` |
| `LeaderOffset` | `Vector2D` | `get/set` | No | `` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnRefresh` | `Void` | `Drawing drawing, DwgLayer layer, Matrix matrix, IDictionary<String Object> settings` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"AliformLeaderBehavior"` | `` |

### `DwgComponentBehavior` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Culvert culvert, DwgComponent associatedComponent)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnRefresh` | `Void` | `Drawing drawing, DwgLayer layer, Matrix matrix, IDictionary<String Object> settings` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `Culvert culvert, DwgComponent owner, StgNode node, ref DwgComponentBehavior behavior` | `` |

### `LocationBinding` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.LocationBinding` |
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
      - `Topomatic.Culverts.Dwg.Components.Behaviors.LocationBinding`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `LocationBinding` | Yes | `Empty` | `` |
| `LeftAliform` | `LocationBinding` | Yes | `LeftAliform` | `` |
| `LeftBed` | `LocationBinding` | Yes | `LeftBed` | `` |
| `LeftHeader` | `LocationBinding` | Yes | `LeftHeader` | `` |
| `RightAliform` | `LocationBinding` | Yes | `RightAliform` | `` |
| `RightBed` | `LocationBinding` | Yes | `RightBed` | `` |
| `RightHeader` | `LocationBinding` | Yes | `RightHeader` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `LeftHeader` | `1` |
| `RightHeader` | `2` |
| `LeftAliform` | `3` |
| `RightAliform` | `4` |
| `LeftBed` | `5` |
| `RightBed` | `6` |

**Underlying Type**: `System.Int32`

### `MultilineLeaderBehavior` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.MultilineLeaderBehavior` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior`
    - `Topomatic.Culverts.Dwg.Components.Behaviors.MultilineLeaderBehavior`

#### Constructors (1)

- `.ctor(Culvert culvert, DwgComponent associatedComponent)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoints` | `List<StaOffs>` | `get` | No | `` |
| `IsProfile` | `Boolean` | `get/set` | No | `` |
| `Position` | `StaOffs` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnRefresh` | `Void` | `Drawing drawing, DwgLayer layer, Matrix matrix, IDictionary<String Object> settings` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MultilineLeaderBehavior"` | `` |

### `PlanSectionBehavior` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.PlanSectionBehavior` |
| **Base Type** | `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Dwg.Components.Behaviors.DwgComponentBehavior`
    - `Topomatic.Culverts.Dwg.Components.Behaviors.PlanSectionBehavior`

#### Constructors (1)

- `.ctor(Culvert culvert, DwgComponent associatedComponent)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Binding` | `LocationBinding` | `get/set` | No | `` |
| `Positions` | `List<Vector2D>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnRefresh` | `Void` | `Drawing drawing, DwgLayer layer, Matrix matrix, IDictionary<String Object> settings` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"PlanSectionBehavior"` | `` |

### `StaOffs` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Dwg.Components.Behaviors.StaOffs` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Dwg.Components.Behaviors.StaOffs`

#### Constructors (1)

- `.ctor(Double station, Double offset, LocationBinding binding)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StaOffs` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Binding` | `LocationBinding` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Culverts.Hydraulic`

### `HydraulicCalculationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Hydraulic.HydraulicCalculationType` |
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
      - `Topomatic.Culverts.Hydraulic.HydraulicCalculationType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Box` | `HydraulicCalculationType` | Yes | `Box` | `` |
| `Gofr` | `HydraulicCalculationType` | Yes | `Gofr` | `` |
| `Round` | `HydraulicCalculationType` | Yes | `Round` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Box` | `0` |
| `Round` | `1` |
| `Gofr` | `2` |

**Underlying Type**: `System.Int32`

### `HydraulicCalculator` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Hydraulic.HydraulicCalculator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(HydraulicFlowType flowType)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FlowType` | `HydraulicFlowType` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Backwater` | `Double` | `Double waterConsumption` | `` |
| `CompactSectionDepth` | `Double` | `Double waterConsumption` | `` |
| `CriticalDepth` | `Double` | `Double waterConsumption` | `` |
| `CriticalGrade` | `Double` | `Double waterConsumption` | `` |
| `CriticalGradeSpeed` | `Double` | `Double waterConsumption` | `` |
| `OutSpeed` | `Double` | `Double waterConsumption, Double grade` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `G` | `Double` | Yes | `9.8` | `` |

### `HydraulicFlowType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Hydraulic.HydraulicFlowType` |
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
      - `Topomatic.Culverts.Hydraulic.HydraulicFlowType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Pressure` | `HydraulicFlowType` | Yes | `Pressure` | `` |
| `SemiPressure` | `HydraulicFlowType` | Yes | `SemiPressure` | `` |
| `value__` | `Int32` | No | `` | `` |
| `WithoutPressure` | `HydraulicFlowType` | Yes | `WithoutPressure` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `WithoutPressure` | `0` |
| `SemiPressure` | `1` |
| `Pressure` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Culverts.Sheets`

### `ColumnInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.ColumnInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Sheets.ColumnInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ColumnInfo` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `Values` | `List<String>` | No | `` | `` |

### `SheetContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.SheetContext` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Sheets.SheetContext`

#### Constructors (1)

- `.ctor(Culvert culvert)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `UseCustomSpecs` | `Boolean` | `get/set` | No | `` |
| `VariablesCount` | `Int32` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddTable` | `Void` | `TableInfo tableInfo` | `` |
| `AddVariable` | `Void` | `VariableInfo variableInfo` | `` |
| `Clear` | `Void` | `` | `` |
| `CreateDataset` | `List<RowData>` | `String tableId` | `` |
| `CreateTableContext` | `TableContext` | `String tableId` | `` |
| `GetVariable` | `VariableInfo` | `Int32 index` | `` |
| `GetVariableValue` | `String` | `String variableKey` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `SheetTableNames` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.SheetTableNames` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GENERAL` | `String` | Yes | `"General"` | `` |
| `LEFT_DISMANTLING_SPEC` | `String` | Yes | `"LeftDismantlingSpec"` | `` |
| `RIGHT_DISMANTLING_SPEC` | `String` | Yes | `"RightDismantlingSpec"` | `` |
| `SPECIFICATION` | `String` | Yes | `"Specification"` | `` |
| `SPECIFICATION_1` | `String` | Yes | `"Specification_1"` | `` |
| `SPECIFICATION_2` | `String` | Yes | `"Specification_2"` | `` |
| `STREN_VOLUMES` | `String` | Yes | `"StrenVolumes"` | `` |
| `VOLUMES` | `String` | Yes | `"Volumes"` | `` |

### `SpecificationData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.SpecificationData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Sheets.SpecificationData`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `String` | `get/set` | No | `DesignAlias, Description` |
| `Height` | `String` | `get/set` | No | `DesignAlias, Description` |
| `Hole` | `String` | `get/set` | No | `Description, DesignAlias` |
| `Length` | `String` | `get/set` | No | `Description, DesignAlias` |
| `Material` | `String` | `get/set` | No | `Description, DesignAlias` |
| `Nomenclature` | `String` | `get/set` | No | `DesignAlias, Description` |
| `Volume` | `String` | `get/set` | No | `Description, DesignAlias` |
| `Weight` | `String` | `get/set` | No | `Description, DesignAlias` |
| `Width` | `String` | `get/set` | No | `DesignAlias, Description` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `SpecificationData` | `ComponentSpecification spec` | `` |

### `TableInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.TableInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Sheets.TableInfo`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `TableInfo` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Columns` | `List<ColumnInfo>` | No | `` | `` |
| `TableId` | `String` | No | `` | `` |

### `VariableInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Sheets.VariableInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Sheets.VariableInfo`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `VariableInfo` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Description` | `String` | No | `` | `` |
| `Name` | `String` | No | `` | `` |
| `TableId` | `String` | No | `` | `` |
| `Value` | `String` | No | `` | `` |

---
## Namespace: `Topomatic.Culverts.Specifications`

### `ComponentSpecification` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Specifications.ComponentSpecification` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Specifications.ComponentSpecification`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ComponentSpecification` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `ComponentSpecification value, StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Count` | `Int32` | No | `` | `` |
| `PropertyKey` | `String` | No | `` | `` |
| `Type` | `SpecificationType` | No | `` | `` |
| `Values` | `Dictionary<String String>` | No | `` | `` |

### `SpecificationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Specifications.SpecificationType` |
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
      - `Topomatic.Culverts.Specifications.SpecificationType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LeftDismantle` | `SpecificationType` | Yes | `LeftDismantle` | `` |
| `NewConstruction` | `SpecificationType` | Yes | `NewConstruction` | `` |
| `RightDismantle` | `SpecificationType` | Yes | `RightDismantle` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NewConstruction` | `0` |
| `LeftDismantle` | `1` |
| `RightDismantle` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Culverts.Strengthening`

### `MonolithicStrengthening` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Strengthening.MonolithicStrengthening` |
| **Base Type** | `Topomatic.Culverts.Strengthening.StrengtheningBase` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Strengthening.StrengtheningBase`
    - `Topomatic.Culverts.Strengthening.MonolithicStrengthening`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean isInputHeader, Boolean isLeftHeader)`

#### Properties (29)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsphaltPlankThickness` | `Double` | `get/set` | No | `` |
| `AttachedPlanLeaderBasePositions` | `IList<StaOffs>` | `get/set` | No | `` |
| `AttachedProfileLeaderBasePositions` | `IList<StaOffs>` | `get/set` | No | `` |
| `BaseLayers` | `List<StrenLayerInfo>` | `get` | No | `` |
| `CardLength` | `Double` | `get/set` | No | `` |
| `CreateCards` | `Boolean` | `get/set` | No | `` |
| `CreateContinuousAliformLayer` | `Boolean` | `get/set` | No | `` |
| `CuttingShellWidth` | `Double` | `get/set` | No | `` |
| `Diameter` | `Double` | `get/set` | No | `` |
| `DistBtwAxes` | `Double` | `get/set` | No | `` |
| `Elements` | `List<ClvElement>` | `get` | No | `` |
| `FirstLayer` | `StrenLayerInfo` | `get/set` | No | `` |
| `HasPortal` | `Boolean` | `get/set` | No | `` |
| `HoleBotZOffset` | `Double` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `LeftLowerStripInnerEnd` | `Vector2D` | `get/set` | No | `` |
| `LeftLowerStripInnerStart` | `Vector2D` | `get/set` | No | `` |
| `LeftLowerStripOuterStart` | `Vector2D` | `get/set` | No | `` |
| `LinkThickness` | `Double` | `get/set` | No | `` |
| `PlanComponents` | `List<DynamicComponent>` | `get` | No | `` |
| `PlanDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `PlanEntities` | `List<DwgEntity>` | `get` | No | `` |
| `ProfileDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `ProfileEntities` | `List<DwgEntity>` | `get` | No | `` |
| `RightLowerStripInnerEnd` | `Vector2D` | `get/set` | No | `` |
| `RightLowerStripInnerStart` | `Vector2D` | `get/set` | No | `` |
| `RightLowerStripOuterStart` | `Vector2D` | `get/set` | No | `` |
| `TopInnerWidth` | `Double` | `get/set` | No | `` |
| `TopWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Refresh` | `Void` | `Culvert culvert, DataContext context` | `` |
| `RefreshDynamicData` | `Void` | `DynamicDataScope dynamicData` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLayersLeaderText` | `List<MultilineLeaderTextEntry>` | `IList<String> layerNames, IList<Double> layerThicknesses` | `` |
| `LayerThickness` | `Double` | `Double layerThickness` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"MonolithicStrengthening"` | `` |

### `P1Strengthening` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Strengthening.P1Strengthening` |
| **Base Type** | `Topomatic.Culverts.Strengthening.StrengtheningBase` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Culverts.Strengthening.StrengtheningBase`
    - `Topomatic.Culverts.Strengthening.P1Strengthening`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean isInputHeader, Boolean isLeftHeader)`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AsphaltPlankThickness` | `Double` | `get/set` | No | `` |
| `CardLength` | `Int32` | `get/set` | No | `` |
| `CardWidth` | `Int32` | `get/set` | No | `` |
| `CreateContinuousAliformLayer` | `Boolean` | `get/set` | No | `` |
| `CreateIntermediateCard` | `Boolean` | `get/set` | No | `` |
| `CuttingShellWidth` | `Double` | `get/set` | No | `` |
| `Diameter` | `Double` | `get/set` | No | `` |
| `DistBtwAxes` | `Double` | `get/set` | No | `` |
| `Elements` | `List<ClvElement>` | `get` | No | `` |
| `HasPortal` | `Boolean` | `get/set` | No | `` |
| `HoleBotZOffset` | `Double` | `get/set` | No | `` |
| `HoleCount` | `Int32` | `get/set` | No | `` |
| `LeftLowerStripInnerEnd` | `Vector2D` | `get/set` | No | `` |
| `LeftLowerStripInnerStart` | `Vector2D` | `get/set` | No | `` |
| `LinkThickness` | `Double` | `get/set` | No | `` |
| `LowerStripPlateCount` | `Int32` | `get/set` | No | `` |
| `P1PlateModel` | `ImElement` | `get` | Yes | `` |
| `PlanComponents` | `List<DynamicComponent>` | `get` | No | `` |
| `PlanDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `PlanEntities` | `List<DwgEntity>` | `get` | No | `` |
| `ProfileDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `ProfileEntities` | `List<DwgEntity>` | `get` | No | `` |
| `RightLowerStripInnerEnd` | `Vector2D` | `get/set` | No | `` |
| `RightLowerStripInnerStart` | `Vector2D` | `get/set` | No | `` |
| `RubbleThickness` | `Double` | `get/set` | No | `` |
| `TopInnerWidth` | `Double` | `get/set` | No | `` |
| `TopWidth` | `Double` | `get/set` | No | `` |
| `UpperStripPlateCount` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Refresh` | `Void` | `Culvert culvert, DataContext context` | `` |
| `RefreshDynamicData` | `Void` | `DynamicDataScope dynamicData` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MONIKER` | `String` | Yes | `"P1Strengthening"` | `` |

### `StrengtheningBase` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Strengthening.StrengtheningBase` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Elements` | `List<ClvElement>` | `get` | No | `` |
| `PlanComponents` | `List<DynamicComponent>` | `get` | No | `` |
| `PlanDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `PlanEntities` | `List<DwgEntity>` | `get` | No | `` |
| `ProfileDwgComponents` | `List<DwgComponent>` | `get` | No | `` |
| `ProfileEntities` | `List<DwgEntity>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Refresh` | `Void` | `Culvert culvert, DataContext context` | `` |
| `RefreshDynamicData` | `Void` | `DynamicDataScope dynamicData` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryLoadFromStg` | `Boolean` | `StgNode node, ref StrengtheningBase strengthening` | `` |

### `StrenLayerInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Strengthening.StrenLayerInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Strengthening.StrenLayerInfo`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaSign` | `AreaSign` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Tags` | `IList<String>` | `get/set` | No | `` |
| `Thickness` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StrenLayerInfo` | `StgNode node` | `` |

---
## Namespace: `Topomatic.Culverts.Style`

### `PrecisionStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Style.PrecisionStyle` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Culverts.Culvert, Topomatic.Culverts, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Culverts.Style.PrecisionStyle`

#### Constructors (1)

- `.ctor(Culvert owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CoordinateDigits` | `Int32` | `get/set` | No | `` |
| `ElevationDigits` | `Int32` | `get/set` | No | `` |
| `GeneralDigits` | `Int32` | `get/set` | No | `` |
| `GradeDigits` | `Int32` | `get/set` | No | `` |
| `LengthDigits` | `Int32` | `get/set` | No | `` |
| `Owner` | `Culvert` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CoordinateToStr` | `String` | `Double value` | `` |
| `CopyProperties` | `Void` | `PrecisionStyle style` | `` |
| `ElevationToStr` | `String` | `Double value` | `` |
| `FloatToStr` | `String` | `Double value` | `` |
| `GradeToStr` | `String` | `Double value` | `` |
| `LengthToStr` | `String` | `Double value` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |

---
## Namespace: `Topomatic.Culverts.Utils`

### `ClvConverter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Utils.ClvConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DoubleStrToDisplayStr` | `String` | `String value` | `` |
| `DoubleToString` | `String` | `Double value` | `` |
| `DoubleToString` | `String` | `Double value, Int32 digits, Boolean showZeroFeet` | `` |
| `DoubleToString` | `String` | `Double value, Int32 digits` | `` |

### `ColorUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Utils.ColorUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Color` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `Color color, StgNode node` | `` |

### `ShellExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Utils.ShellExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddFace` | `Void` | `Shell shell, IList<Vector3D> positions` | `Extension` |
| `CalcBounds` | `BoundingBox3D` | `Shell shell` | `Extension` |
| `Clone` | `Shell` | `Shell shell` | `Extension` |
| `CreateFromSections` | `Shell` | `List<List<Vector3D>> startSection, List<List<Vector3D>> endSection` | `` |
| `CreateFrustrum` | `Shell` | `Double leftRadius, Double rightRadius, Double length, Int32 resolution` | `` |
| `Extrude` | `Shell` | `Shell section, Double length, Double width, Double height` | `` |
| `Extrude` | `Shell` | `List<List<Vector3D>> section, Double length, Double width, Double height` | `` |

### `SmdxExtensions` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Utils.SmdxExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateAreaSign` | `AreaSign` | `String hatchPatternName, Single hatchScale, Single hatchRotation` | `` |

---
## Namespace: `Topomatic.Culverts.Visualization`

### `CompoundDynamic3DElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.CompoundDynamic3DElement` |
| **Base Type** | `Topomatic.Culverts.Visualization.Dynamic3DElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Dynamic3DElement`
          - `Topomatic.Culverts.Visualization.CompoundDynamic3DElement`

#### Constructors (2)

- `.ctor(String name, ImTypeDescriptor type, ImProperties properties, ImDocuments documents)`
- `.ctor(String name, String typeId, ImProperties properties, ImDocuments documents)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String name, Dynamic3DElement element, Vector3D position, Vector3D ox, Vector3D oy` | `` |
| `Add` | `Void` | `String name, Dynamic3DElement element, Vector3D position, Vector3D ox, Vector3D oy, Vector3D scale, ImProperties properties, ImDocuments documents` | `` |
| `Add` | `Void` | `String name, Dynamic3DElement element, Vector3D position` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetAllProperties` | `ImProperties` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `Prepare` | `Void` | `Construction construction` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Custom3DModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Custom3DModel` |
| **Base Type** | `Topomatic.Culverts.Visualization.Dynamic3DElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Dynamic3DElement`
          - `Topomatic.Culverts.Visualization.Custom3DModel`

#### Constructors (1)

- `.ctor(String typeId, String name)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddStaticModel` | `Void` | `GeometryModel3D model, Matrix matrix` | `` |
| `AddViewBlock` | `Void` | `Model3DView view, Action<DwgBlock> action` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `Prepare` | `Void` | `Construction construction` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Dynamic3DElement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Dynamic3DElement` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Dynamic3DElement`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Prepare` | `Void` | `Construction construction` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Element3DWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Element3DWrapper` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Culverts.Visualization.Element3DWrapper`

#### Constructors (1)

- `.ctor(ImElement element)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Double` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ProfileLeft` | `Double` | `get` | No | `` |
| `ProfileLength` | `Double` | `get` | No | `` |
| `ProfileRight` | `Double` | `get` | No | `` |
| `SectionLeft` | `Double` | `get` | No | `` |
| `SectionRight` | `Double` | `get` | No | `` |
| `SectionWidth` | `Double` | `get` | No | `` |
| `Top` | `Double` | `get` | No | `` |

#### Instance Methods (30)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddViewBlock` | `Void` | `Model3DView view, Action<DwgBlock> action` | `` |
| `CalcBaseProfileLength` | `Double` | `` | `` |
| `ClearViewBlocks` | `Void` | `` | `` |
| `Clone` | `ImElement` | `` | `` |
| `DisableGeometryView` | `Void` | `` | `` |
| `DisablePlanView` | `Void` | `` | `` |
| `DisableProfileView` | `Void` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetBrep` | `Shell` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetSectionContour` | `List<Vector2D>` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `LoadFacadeBlock` | `Void` | `DwgBlock block, Matrix transform` | `` |
| `LoadSectionBlock` | `Void` | `DwgBlock block, Matrix transform` | `` |
| `LoadSectionLeftBlock` | `Void` | `DwgBlock block, Matrix transform` | `` |
| `LoadSectionRightBlock` | `Void` | `DwgBlock block, Matrix transform` | `` |
| `LoadSystemBlock` | `Boolean` | `String blockName, Matrix transform, DwgBlock result` | `` |
| `RotateProfileToSection` | `Void` | `` | `` |
| `RotateSectionClockwise` | `Void` | `` | `` |
| `UseBoundsPlanView` | `Void` | `` | `` |
| `UseBoundsProfileView` | `Void` | `String hatchPatternName, Double hatchPatternScale` | `` |
| `UseElementProfileView` | `Void` | `` | `` |
| `UseMirror` | `Void` | `` | `` |
| `UseName` | `Void` | `String name` | `` |
| `UsePlanGeometryOverlay` | `Void` | `` | `` |
| `UseProfileGeometryOverlay` | `Void` | `` | `` |
| `UseSystemPlanBlock` | `Void` | `` | `` |
| `UseSystemProfileBlock` | `Void` | `` | `` |
| `UseSystemProfileBlock` | `Void` | `Double planAngle` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementClip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementClip` |
| **Base Type** | `Topomatic.Culverts.Visualization.Model3DElementView` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Culverts.Visualization.Model3DElementView`
            - `Topomatic.Culverts.Visualization.Model3DElementClip`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ImElement item, Plane plane)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementFlip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementFlip` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Culverts.Visualization.Model3DElementFlip`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(ImElement item)`
- `.ctor(ImElement item, Matrix flipMatrix)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FlipOZ` | `Matrix` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementHeaderStopBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementHeaderStopBlock` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Model3DElementHeaderStopBlock`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, Double length, Double height)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementLecalBlockConcreteHeader` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementLecalBlockConcreteHeader` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Model3DElementLecalBlockConcreteHeader`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, Double linkLength, Double headerBot, Double midY, Double midX, Double portalProfileBoundsWidth, Double portalTopThickness, Double offsetFromLinkToPortal, String patternName, Double patternScale)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementLecalBlockConcreteMiddle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementLecalBlockConcreteMiddle` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Model3DElementLecalBlockConcreteMiddle`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, Double length, Double depth, String patternName, Double patternScale)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementMiddleMonolitFoundation144_01` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementMiddleMonolitFoundation144_01` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Model3DElementMiddleMonolitFoundation144_01`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, Double length, Double topHeight, Double bottomHeight, String patternName, Double patternScale)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementProtectedShieldHeadMonolith` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementProtectedShieldHeadMonolith` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Model3DElementProtectedShieldHeadMonolith`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name, Double length, Double depth, Double width, String patternName, Double patternScale)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementView` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementView` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Culverts.Visualization.Model3DElementView`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ImElement item)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `RotateProfileToSection` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DElementVisibleCustom` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Model3DElementVisibleCustom` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Culverts.Visualization.Model3DElementVisibleCustom`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ImElement item, Boolean visiblePlan, Boolean visibleProfile)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Solid3DModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.Solid3DModel` |
| **Base Type** | `Topomatic.Culverts.Visualization.Dynamic3DElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Culverts.Visualization.Dynamic3DElement`
          - `Topomatic.Culverts.Visualization.Solid3DModel`

#### Constructors (1)

- `.ctor(String typeId, String name)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Color` | `get/set` | No | `` |
| `Faces` | `List<Face>` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Positions` | `List<SolidPositionInfo>` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddViewContour` | `Void` | `Model3DView view, SolidContourInfo contour` | `` |
| `AddViewContour` | `Void` | `SolidContourInfo contour` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetBrep` | `Shell` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `Prepare` | `Void` | `Construction construction` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateConcreteOXModel` | `Solid3DModel` | `String typeId, String name, Double length, IList<Vector2D> sectionContour, IList<Face> faces` | `` |
| `CreateConcreteOYModel` | `Solid3DModel` | `String typeId, String name, Double width, IList<Vector2D> profileContour, IList<Face> faces` | `` |
| `CreateOXModel` | `Solid3DModel` | `String typeId, String name, Double length, IList<Vector3D> positions, IList<Face> faces, Int32[] profileIndices` | `` |
| `CreateOYModel` | `Solid3DModel` | `String typeId, String name, Double width, IList<Vector3D> positions, IList<Face> faces, Int32[] profileIndices` | `` |
| `CreateOZModel` | `Solid3DModel` | `String typeId, String name, Double height, IList<Vector3D> positions, IList<Face> faces, Int32[] profileIndices` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_HATCH_NAME` | `String` | Yes | `"ANSI31"` | `` |
| `DEFAULT_HATCH_SCALE` | `Single` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SolidContourInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.SolidContourInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Visualization.SolidContourInfo`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SolidContourInfo` | `StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AreaSign` | `AreaSign` | No | `` | `` |
| `Closed` | `Boolean` | No | `` | `` |
| `Indices` | `Int32[]` | No | `` | `` |
| `UseOppositeFaces` | `Boolean` | No | `` | `` |

### `SolidPositionInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Culverts.Visualization.SolidPositionInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Culverts.Visualization.SolidPositionInfo`

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `SolidPositionInfo` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `SolidPositionInfo value, StgNode node` | `` |

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BindingTagX1` | `String` | No | `` | `` |
| `BindingTagX2` | `String` | No | `` | `` |
| `BindingTagY1` | `String` | No | `` | `` |
| `BindingTagY2` | `String` | No | `` | `` |
| `BindingTagZ1` | `String` | No | `` | `` |
| `BindingTagZ2` | `String` | No | `` | `` |
| `ContourBreak` | `Boolean` | No | `` | `` |
| `DeltaX1` | `Double` | No | `` | `` |
| `DeltaX2` | `Double` | No | `` | `` |
| `DeltaY1` | `Double` | No | `` | `` |
| `DeltaY2` | `Double` | No | `` | `` |
| `DeltaZ1` | `Double` | No | `` | `` |
| `DeltaZ2` | `Double` | No | `` | `` |
| `SkipSideFace` | `Boolean` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 148 |
| **Classes** | 70 |
| **Interfaces** | 3 |
| **Enums** | 22 |
| **Structs** | 27 |
| **Abstract Classes** | 10 |
| **Static Classes** | 16 |
| **Total Methods** | 515 |
| **Total Properties** | 548 |
| **Total Fields** | 809 |
| **Total Events** | 2 |
| **Total Constructors** | 98 |
| **Nested Types** | 4 |
| **Extension Methods** | 0 |


