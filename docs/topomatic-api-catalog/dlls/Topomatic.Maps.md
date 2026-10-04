# Topomatic.Maps

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Maps` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Maps, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Maps.dll` |

---
## Namespace: `Topomatic.Maps.ConstructionGeodesicGrid`

### `CGGAxis` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.ConstructionGeodesicGrid.Utils+CGGAxis` |
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
| `Angle` | `Double` | `get` | No | `` |
| `TextPos` | `Vector3D` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Segments` | `List<LineSegment>` | No | `` | `` |
| `Text` | `String` | No | `` | `` |

### `CGGSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.ConstructionGeodesicGrid.CGGSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.ApplicationPlatform.UserSettings.IUserSettingsProvider, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ABForm` | `Boolean` | `get/set` | No | `` |
| `Active` | `Boolean` | `get/set` | No | `` |
| `AxisNoteOffset` | `Double` | `get/set` | No | `` |
| `AxisTextHeight` | `Double` | `get/set` | No | `` |
| `AxisTextOffset` | `Double` | `get/set` | No | `` |
| `Contour` | `Vector2D[]` | `get/set` | No | `` |
| `ContourMode` | `Boolean` | `get/set` | No | `` |
| `GridStep` | `Double` | `get/set` | No | `` |
| `HorAxisesEndIndex` | `Int32` | `get/set` | No | `` |
| `HorAxisesStartIndex` | `Int32` | `get/set` | No | `` |
| `Instance` | `CGGSettings` | `get` | Yes | `` |
| `RelativeXY` | `Boolean` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `SquareSideLength` | `Double` | `get/set` | No | `` |
| `VertAxisesEndIndex` | `Int32` | `get/set` | No | `` |
| `VertAxisesStartIndex` | `Int32` | `get/set` | No | `` |
| `X` | `Double` | `get/set` | No | `` |
| `Y` | `Double` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePanel` | `UserSettingsPanel` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable` | `` | `` |
| `GetPath` | `String` | `Object moniker` | `` |
| `GetSortOrder` | `Int32` | `Object moniker` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUserSettingsProvider` | `GetMonikers` |
| `IUserSettingsProvider` | `GetPath` |
| `IUserSettingsProvider` | `GetSortOrder` |
| `IUserSettingsProvider` | `CreatePanel` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Utils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.ConstructionGeodesicGrid.Utils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateAxises` | `CGGAxis[]` | `Boolean hor, Vector2D[] screenBorder` | `` |
| `CalculateAxisesRange` | `Void` | `IEnumerable<Vector2D> border, Double distance, ref Int32 horAxisesStartIndex, ref Int32 horAxisesEndIndex, ref Int32 vertAxisesStartIndex, ref Int32 vertAxisesEndIndex` | `` |
| `NormalizeAngle` | `Double` | `Double value` | `` |
| `SectLinePolygon` | `Vector2D[]` | `Line2D line, Vector2D[] polygon` | `` |
| `SectSegmentPolygon` | `Vector2D[]` | `LineSegment lineSegment, Vector2D[] polygon` | `` |
| `TransformFromCGG` | `Vector2D` | `Vector2D point` | `` |
| `TransformToCGG` | `Vector2D` | `Vector2D point` | `` |
| `TransformToGeographic` | `Void` | `ref Vector2D point` | `` |
| `ValueToABText` | `String` | `Double value, Boolean isA` | `` |

#### Nested Types (1)

- `CGGAxis` (class)

---
## Namespace: `Topomatic.Maps.Entities`

### `ArrowInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.DwgEntityLeader+ArrowInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D position, Polyline2DCurve curve, TypedObject tobj)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Curve` | `Polyline2DCurve` | `get` | No | `` |
| `Vector` | `Vector2D` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ParseTags` | `String` | `String value` | `` |

### `DwgEntityLeader` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.DwgEntityLeader` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgDynamicLeader` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Dwg.Entities.IEntityDependent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Dwg.Entities.DwgDynamicLeader`
          - `Topomatic.Maps.Entities.DwgEntityLeader`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (25)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Annotative` | `Boolean` | `get/set` | No | `` |
| `Arrowhead` | `ArrowheadInfo` | `get/set` | No | `` |
| `ArrowheadName` | `String` | `get/set` | No | `Browsable` |
| `ArrowheadSize` | `Double` | `get/set` | No | `Length` |
| `ArrowheadType` | `AcDimArrowheadType` | `get/set` | No | `Browsable` |
| `AutoMirror` | `Boolean` | `get/set` | No | `` |
| `BackgroundColor` | `CadColor` | `get/set` | No | `` |
| `BackgroundFillType` | `BackgroundFillType` | `get/set` | No | `` |
| `Content` | `String` | `get/set` | No | `` |
| `DependentHandle` | `UInt32` | `get/set` | No | `ParameterType, PropertyUpdateSequence, ParameterType, ParameterType, PropertyProvider` |
| `DependentIds` | `UInt32[]` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `Font` | `CadFont` | `get` | No | `Browsable` |
| `Height` | `Double` | `get/set` | No | `Length` |
| `HorizontalAlignment` | `HorizontalAlignment` | `get/set` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Oblique` | `Double` | `get/set` | No | `PropertyTypeConverter` |
| `Position` | `Vector2D` | `get` | No | `Browsable` |
| `PositionOffset` | `Vector2D` | `get/set` | No | `Vector` |
| `Ratio` | `Double` | `get/set` | No | `DefaultDouble` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Style` | `DwgStyle` | `get/set` | No | `PropertyUpdateSequence` |
| `VertexOffset` | `Vector2D` | `get/set` | No | `Vector` |
| `VerticalAlignment` | `VerticalAlignment` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `SetStyleWithoutPrametersAssignment` | `Void` | `DwgStyle style` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindArrowInfo` | `ArrowInfo` | `Drawing drawing, UInt32 objectId, Vector2D offset` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"ENTITYLEADER"` | `` |

#### Nested Types (1)

- `ArrowInfo` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEntityDependent` | `get_DependentIds` |

### `LeaderOffset` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLinearLeaderEntity+LeaderOffset` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Maps.Entities.MapsLinearLeaderEntity+LeaderOffset`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GradeStation` | `Double` | No | `` | `` |
| `Mirror` | `Boolean` | No | `` | `` |
| `Offset` | `Vector2D` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |

### `LinearLeaderSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.LinearLeaderSide` |
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
      - `Topomatic.Maps.Entities.LinearLeaderSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `LinearLeaderSide` | Yes | `Left` | `` |
| `Right` | `LinearLeaderSide` | Yes | `Right` | `` |
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

### `MapsLeaderCoordinateType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLeaderCoordinateType` |
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
      - `Topomatic.Maps.Entities.MapsLeaderCoordinateType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AB` | `MapsLeaderCoordinateType` | Yes | `AB` | `` |
| `Absolute` | `MapsLeaderCoordinateType` | Yes | `Absolute` | `` |
| `Geographic` | `MapsLeaderCoordinateType` | Yes | `Geographic` | `` |
| `Relative` | `MapsLeaderCoordinateType` | Yes | `Relative` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Absolute` | `0` |
| `Geographic` | `1` |
| `Relative` | `2` |
| `AB` | `3` |

**Underlying Type**: `System.Int32`

### `MapsLeaderEntity` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLeaderEntity` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgCoordinateLeader` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.ICollection, Topomatic.Sfc.Entites.ISurfaceProxyEntity` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Dwg.Entities.DwgDynamicLeader`
          - `Topomatic.Dwg.Entities.DwgCoordinateLeader`
            - `Topomatic.Maps.Entities.MapsLeaderEntity`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Content` | `String` | `get/set` | No | `` |
| `EntityName` | `String` | `get` | No | `Browsable` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Style` | `MapsLeaderStyle` | `get/set` | No | `PropertyUpdateSequence` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `SurfaceModified` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetSurfacePoint` | `Boolean` | `Drawing drawing, Vector2D pos, ref Surface surface, ref SurfacePoint pt` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_POSITION` | `Vector2D` | Yes | `` | `` |
| `ENTITY_NAME` | `String` | Yes | `"MAPSLEADER"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurfaceProxyEntity` | `SurfaceModified` |

### `MapsLeaderStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLeaderStyle` |
| **Base Type** | `Topomatic.Dwg.DwgNamedObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.FoundationClasses.INamedObject, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgNamedObject`
      - `Topomatic.Maps.Entities.MapsLeaderStyle`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Annotative` | `Boolean` | `get/set` | No | `` |
| `Arrowhead` | `ArrowheadInfo` | `get/set` | No | `` |
| `ArrowheadName` | `String` | `get/set` | No | `Browsable` |
| `ArrowheadSize` | `Double` | `get/set` | No | `Length` |
| `ArrowheadType` | `AcDimArrowheadType` | `get/set` | No | `Browsable` |
| `AutoMirror` | `Boolean` | `get/set` | No | `` |
| `AutoRotate` | `Boolean` | `get/set` | No | `` |
| `BackgroundColor` | `CadColor` | `get/set` | No | `` |
| `BackgroundFillType` | `BackgroundFillType` | `get/set` | No | `` |
| `CooridnateType` | `MapsLeaderCoordinateType` | `get/set` | No | `PropertyUpdateSequence` |
| `DecimalFormat` | `Boolean` | `get/set` | No | `` |
| `DefaultLayer` | `String` | `get/set` | No | `` |
| `Font` | `CadFont` | `get` | No | `Browsable` |
| `Height` | `Double` | `get/set` | No | `Length` |
| `HorizontalAlignment` | `HorizontalAlignment` | `get/set` | No | `` |
| `HorizontalDatumId` | `Guid` | `get/set` | No | `PropertyProvider, ConditionalBrowsable` |
| `LeaderContent` | `String` | `get/set` | No | `` |
| `NorthY` | `Boolean` | `get/set` | No | `` |
| `Precision` | `Int32` | `get/set` | No | `` |
| `Style` | `DwgStyle` | `get/set` | No | `PropertyUpdateSequence` |
| `VerticalAlignment` | `VerticalAlignment` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `OnCopy` | `Void` | `DwgObject obj, ReferencesContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `MapsLeaderStyles` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLeaderStyles` |
| **Base Type** | `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Maps.Entities.MapsLeaderStyle, Topomatic.Maps, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, System.Collections.Generic.IEnumerable`1[[Topomatic.Maps.Entities.MapsLeaderStyle, Topomatic.Maps, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgCollection`1[[Topomatic.Maps.Entities.MapsLeaderStyle, Topomatic.Maps, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Maps.Entities.MapsLeaderStyle, Topomatic.Maps, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Maps.Entities.MapsLeaderStyles`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AandB` | `MapsLeaderStyle` | `get` | No | `` |
| `Absoultes` | `MapsLeaderStyle` | `get` | No | `` |
| `Geographics` | `MapsLeaderStyle` | `get` | No | `` |
| `ObjectName` | `String` | `get` | No | `` |
| `Relatives` | `MapsLeaderStyle` | `get` | No | `` |
| `Standard` | `MapsLeaderStyle` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"MAPSLEADERSTYLES"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MapsLinearLeaderEntity` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsLinearLeaderEntity` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgComplexEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Sfc.Entites.ISurfaceProxyEntity` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Maps.Entities.MapsLinearLeaderEntity`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnnotationScale` | `Double` | `get/set` | No | `Browsable` |
| `GradeArrowheadName` | `String` | `get/set` | No | `Browsable` |
| `GradeArrowheadType` | `AcDimArrowheadType` | `get/set` | No | `Browsable` |
| `GradeContent` | `String` | `get/set` | No | `ConditionalBrowsable` |
| `GradeLineweight` | `Lineweight` | `get/set` | No | `ConditionalBrowsable` |
| `GradesArrowhead` | `ArrowheadInfo` | `get/set` | No | `ConditionalBrowsable` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `IsValid` | `Boolean` | `get` | No | `` |
| `Item` | `LeaderOffset` | `get/set` | No | `Browsable` |
| `LeaderContent` | `String` | `get/set` | No | `` |
| `ShowGrade` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `ShowLeader` | `Boolean` | `get/set` | No | `` |
| `Side` | `LinearLeaderSide` | `get/set` | No | `PropertyTypeConverter` |
| `Style` | `MapsLeaderStyle` | `get/set` | No | `PropertyUpdateSequence` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAnnotativeBounds` | `BoundingBox2D` | `Double scale` | `` |
| `GetPolyline` | `Polyline2DCurve` | `` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `SurfaceModified` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Nested Types (1)

- `LeaderOffset` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurfaceProxyEntity` | `SurfaceModified` |

### `MapsPolylineLeaderEntity` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsPolylineLeaderEntity` |
| **Base Type** | `Topomatic.Maps.Entities.MapsLinearLeaderEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Sfc.Entites.ISurfaceProxyEntity, Topomatic.Dwg.Entities.IEntityDependent` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Maps.Entities.MapsLinearLeaderEntity`
          - `Topomatic.Maps.Entities.MapsPolylineLeaderEntity`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DependentHandle` | `UInt32` | `get/set` | No | `PropertyProvider, PropertyUpdateSequence` |
| `DependentIds` | `UInt32[]` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Polyline2DCurve` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"MAPSPOLYLINELEADER"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEntityDependent` | `get_DependentIds` |

### `MapsStructureLineLeaderEntity` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.MapsStructureLineLeaderEntity` |
| **Base Type** | `Topomatic.Maps.Entities.MapsLinearLeaderEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Dwg.Entities.DwgEntity, Topomatic.Dwg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Sfc.Entites.ISurfaceProxyEntity` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Dwg.Entities.DwgComplexEntity`
        - `Topomatic.Maps.Entities.MapsLinearLeaderEntity`
          - `Topomatic.Maps.Entities.MapsStructureLineLeaderEntity`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DependentHandle` | `Int32` | `get/set` | No | `PropertyProvider, PropertyUpdateSequence` |
| `EntityName` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Polyline2DCurve` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"MAPSSTRUCTURELINELEADER"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StructureLineArcUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.StructureLineArcUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `StructureLineToPolyline2DCurve` | `Polyline2DCurve` | `StructureLine structureLine` | `` |

#### Nested Types (1)

- `StructureLineSegmentArc` (class)

### `StructureLineSegmentArc` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Maps.Entities.StructureLineArcUtils+StructureLineSegmentArc` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Center` | `Vector2D` | `get` | No | `` |
| `EndIndex` | `Int32` | `get/set` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `Indexes` | `Int32[]` | `get` | No | `` |
| `Line` | `StructureLine` | `get/set` | No | `` |
| `MidPos` | `Vector2D` | `get` | No | `` |
| `NodesCount` | `Int32` | `get` | No | `` |
| `Radius` | `Double` | `get` | No | `` |
| `SegmentLength` | `Double` | `get` | No | `` |
| `StartIndex` | `Int32` | `get/set` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsIndex` | `Boolean` | `Int32 index` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromIndex` | `StructureLineSegmentArc` | `StructureLine line, Int32 index` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 16 |
| **Classes** | 10 |
| **Interfaces** | 0 |
| **Enums** | 2 |
| **Structs** | 1 |
| **Abstract Classes** | 1 |
| **Static Classes** | 2 |
| **Total Methods** | 42 |
| **Total Properties** | 110 |
| **Total Fields** | 20 |
| **Total Events** | 0 |
| **Total Constructors** | 8 |
| **Nested Types** | 4 |
| **Extension Methods** | 0 |


