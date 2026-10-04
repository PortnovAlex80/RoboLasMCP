# Topomatic.RoadMarking

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.RoadMarking` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.RoadMarking, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.RoadMarking.dll` |

---
## Namespace: `Topomatic.RoadMarking`

### `AlignmentTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.AlignmentTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CaclculatePositionAndRotation` | `Boolean` | `RoadAlignment alg, Double station, Double length, MarkingPosition location, Boolean forward, ref Vector2D position, ref Double rotation` | `` |
| `MakePolyByLocation` | `Polyline3D` | `RoadAlignment alg, Double sta1, Double sta2, MarkingPosition location, Double offs` | `` |

### `AltBackground` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.AltBackground` |
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
      - `Topomatic.RoadMarking.AltBackground`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Type1` | `AltBackground` | Yes | `Type1` | `` |
| `Type2` | `AltBackground` | Yes | `Type2` | `` |
| `Type3` | `AltBackground` | Yes | `Type3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Type1` | `0` |
| `Type2` | `1` |
| `Type3` | `2` |

**Underlying Type**: `System.Int32`

### `AltBackgroundEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.AltBackgroundEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.AltBackgroundEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `MarkingConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.MarkingConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindAlignment` | `RoadAlignment` | `IOwned obj` | `` |
| `MarkingPositionToCategory` | `Int32` | `MarkingPosition position` | `` |
| `MarkingPositionToOppositeCategory` | `Int32` | `MarkingPosition position` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PluginUID` | `String` | Yes | `"RoadMarking"` | `` |
| `RoadMarkingLayerName` | `String` | Yes | `` | `` |

### `MarkingPosition` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.MarkingPosition` |
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
      - `Topomatic.RoadMarking.MarkingPosition`

#### Fields (26)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left1` | `MarkingPosition` | Yes | `Left1` | `` |
| `Left2` | `MarkingPosition` | Yes | `Left2` | `` |
| `Left3` | `MarkingPosition` | Yes | `Left3` | `` |
| `Left4` | `MarkingPosition` | Yes | `Left4` | `` |
| `Left5` | `MarkingPosition` | Yes | `Left5` | `` |
| `LeftCenter` | `MarkingPosition` | Yes | `LeftCenter` | `` |
| `LeftDivider` | `MarkingPosition` | Yes | `LeftDivider` | `` |
| `LeftDividerBorder` | `MarkingPosition` | Yes | `LeftDividerBorder` | `` |
| `LeftPsp` | `MarkingPosition` | Yes | `LeftPsp` | `` |
| `Manual` | `MarkingPosition` | Yes | `Manual` | `` |
| `Right1` | `MarkingPosition` | Yes | `Right1` | `` |
| `Right2` | `MarkingPosition` | Yes | `Right2` | `` |
| `Right3` | `MarkingPosition` | Yes | `Right3` | `` |
| `Right4` | `MarkingPosition` | Yes | `Right4` | `` |
| `Right5` | `MarkingPosition` | Yes | `Right5` | `` |
| `RightCenter` | `MarkingPosition` | Yes | `RightCenter` | `` |
| `RightDivider` | `MarkingPosition` | Yes | `RightDivider` | `` |
| `RightDividerBorder` | `MarkingPosition` | Yes | `RightDividerBorder` | `` |
| `RightPsp` | `MarkingPosition` | Yes | `RightPsp` | `` |
| `SideLeft1` | `MarkingPosition` | Yes | `SideLeft1` | `` |
| `SideLeft2` | `MarkingPosition` | Yes | `SideLeft2` | `` |
| `SideLeft3` | `MarkingPosition` | Yes | `SideLeft3` | `` |
| `SideRight1` | `MarkingPosition` | Yes | `SideRight1` | `` |
| `SideRight2` | `MarkingPosition` | Yes | `SideRight2` | `` |
| `SideRight3` | `MarkingPosition` | Yes | `SideRight3` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Manual` | `0` |
| `LeftCenter` | `1` |
| `LeftDivider` | `2` |
| `LeftDividerBorder` | `3` |
| `Left1` | `4` |
| `Left2` | `5` |
| `Left3` | `6` |
| `Left4` | `7` |
| `Left5` | `8` |
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
| `RightPsp` | `21` |
| `SideRight1` | `22` |
| `SideRight2` | `23` |
| `SideRight3` | `24` |

**Underlying Type**: `System.Int32`

### `MarkingPositionEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.MarkingPositionEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.MarkingPositionEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.RoadMarking.Entities`

### `AreaPattern` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+AreaPattern` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+AreaPattern`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Borders` | `Boolean` | No | `` | `` |
| `HorizontalDashLength` | `Double` | No | `` | `` |
| `LeftAngle` | `Double` | No | `` | `` |
| `Length` | `Double` | No | `` | `` |
| `RightAngle` | `Double` | No | `` | `` |
| `VerticalDashLength` | `Double` | No | `` | `` |

### `CrossingType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.CrossingType` |
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
      - `Topomatic.RoadMarking.Entities.CrossingType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BicycleCrossing` | `CrossingType` | Yes | `BicycleCrossing` | `` |
| `PedestrianCrossing` | `CrossingType` | Yes | `PedestrianCrossing` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PedestrianCrossing` | `0` |
| `BicycleCrossing` | `1` |

**Underlying Type**: `System.Int32`

### `CrossingTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.CrossingTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.Entities.CrossingTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DwgAreaSmdxRoadMarking` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgAreaSmdxRoadMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgAreaSmdxRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Areas` | `KeyValuePair<CadColor Double>[]` | `get` | No | `Browsable` |
| `Border` | `IPolyline3D` | `get` | No | `Browsable` |
| `Buffer` | `Vector2F[]` | `get` | No | `Browsable` |
| `BufferColor` | `CadColor` | `get` | No | `Browsable` |
| `Element` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider` |
| `EndStation` | `Double` | `get` | No | `PropertyProvider` |
| `EntityName` | `String` | `get` | No | `` |
| `GrayScale` | `Boolean` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Pivot` | `Vector2D` | `get` | No | `Browsable` |
| `Polyline` | `IPolyline3D` | `get` | No | `Browsable` |
| `StartStation` | `Double` | `get` | No | `PropertyProvider` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateModel` | `GeometryModel3D` | `ref Matrix matrix` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `Refresh` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxAreaRoadMarking"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `ImElementHolder` | `get_Element` |

### `DwgLinearRoadMarking` (class)

**Attributes**: [Obsolete(Message: `Use DwgLinearSmdxRoadMarking instead`), DefaultMember, EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgLinearRoadMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Cad.Foundation.ICompoundLinearObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.IPolyline3D, Topomatic.Dwg.Entities.ILinearJoinable, Topomatic.Dwg.Entities.ILinearBreakable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgLinearRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AltVariant` | `Boolean` | `get/set` | No | `` |
| `Closed` | `Boolean` | `get/set` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `BugleVector3D` | `get/set` | No | `Browsable` |
| `MarkingLocation` | `MarkingPosition` | `get/set` | No | `Browsable` |
| `MarkingOffset` | `Double` | `get/set` | No | `Browsable` |
| `MarkingType` | `LinearMarkingType` | `get/set` | No | `` |
| `MLocation` | `MarkingPosition` | `get` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `MOffset` | `Double` | `get` | No | `PropertyUpdateSequence, Length` |
| `PkE` | `Double` | `get` | No | `PropertyProvider` |
| `PkS` | `Double` | `get` | No | `PropertyProvider` |
| `PolyLength` | `Double` | `get` | No | `Length` |
| `Scale` | `Double` | `get/set` | No | `Browsable` |
| `Self` | `DwgLinearRoadMarking` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `Speed` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `Length` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (29)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BugleVector3D item` | `` |
| `AssignPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `BreakEntity` | `List<DwgEntity>` | `Vector3D a, Vector3D b` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BugleVector3D item` | `` |
| `CopyTo` | `Void` | `BugleVector3D[] array, Int32 arrayIndex` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<BugleVector3D>` | `` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyLeft` | `Polyline3D` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetPolyRight` | `Polyline3D` | `` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetTriangleBuff` | `Vector2F[]` | `` | `` |
| `IndexOf` | `Int32` | `BugleVector3D item` | `` |
| `Insert` | `Void` | `Int32 index, BugleVector3D item` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double scale` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `LoadFrom` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `BugleVector3D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveTo` | `Void` | `StgNode node` | `` |
| `SegmentBound` | `BoundingBox2D` | `Int32 index` | `Browsable` |
| `ToString` | `String` | `` | `` |
| `TryGetPkEndByLastPolyPoint` | `Boolean` | `IStationingCurve curve, ref Double pkE` | `` |
| `TryGetPkStartByFirstPolyPoint` | `Boolean` | `IStationingCurve curve, ref Double pkS` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
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
| `ICompoundLinearObject` | `GetPathList` |
| `ILinearObject` | `GetPolyline` |
| `IPolyline3D` | `get_Closed` |
| `IPolyline3D` | `set_Closed` |
| `ILinearJoinable` | `AssignPolyline` |
| `ILinearBreakable` | `BreakEntity` |

### `DwgLinearSmdxRoadMarking` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgLinearSmdxRoadMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Visualization.ImElementHolder, Topomatic.Dwg.Entities.ILinearJoinable, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Dwg.Entities.ILinearBreakable, Topomatic.Dwg.Entities.IPolylineConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgLinearSmdxRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Areas` | `KeyValuePair<CadColor Double>[]` | `get` | No | `Browsable` |
| `Buffer` | `Vector2F[][]` | `get` | No | `Browsable` |
| `BufferColors` | `CadColor[]` | `get` | No | `Browsable` |
| `Element` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider` |
| `EndStation` | `Double` | `get/set` | No | `PropertyProvider, ConditionalReadOnly` |
| `EntityName` | `String` | `get` | No | `` |
| `GrayScale` | `Boolean` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Pivot` | `Vector2D` | `get` | No | `Browsable` |
| `Polyline` | `IPolyline3D` | `get` | No | `Browsable` |
| `PrefferedLocation` | `MarkingPosition` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `PrefferedOffset` | `Double` | `get/set` | No | `Length, PropertyUpdateSequence` |
| `StartStation` | `Double` | `get/set` | No | `PropertyProvider, ConditionalReadOnly` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `BreakEntity` | `List<DwgEntity>` | `Vector3D a, Vector3D b` | `` |
| `CreateModel` | `GeometryModel3D` | `ref Matrix matrix` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `Refresh` | `Void` | `` | `` |
| `ToPolyline` | `DwgPolyline` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxLineRoadMarking"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `ImElementHolder` | `get_Element` |
| `ILinearJoinable` | `AssignPolyline` |
| `ILinearObject` | `GetPolyline` |
| `ILinearBreakable` | `BreakEntity` |
| `IPolylineConverter` | `ToPolyline` |

### `DwgPedestrianCrossingMarking` (class)

**Attributes**: [EntityController, DesignAlias, Obsolete(Message: `Use DwgAreaSmdxRoadMarking instead`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgPedestrianCrossingMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Dwg.Entities.IPolylineConverter, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICompoundLinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgPedestrianCrossingMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ArrowDrawing` | `Drawing` | `get` | No | `Browsable` |
| `BackgroundColor` | `CadColor` | `get/set` | No | `ConditionalBrowsable` |
| `BackgroundType` | `AltBackground` | `get/set` | No | `ConditionalBrowsable` |
| `Cache` | `List<DwgEntity>` | `get` | No | `Browsable` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `CrossingType` | `CrossingType` | `get/set` | No | `PropertyUpdateSequence` |
| `Delta` | `Vector2D` | `get` | No | `DeltaVector` |
| `EndPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `EntityName` | `String` | `get` | No | `` |
| `IsAdjustable` | `Boolean` | `get/set` | No | `ConditionalBrowsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsColorBackground` | `Boolean` | `get/set` | No | `ConditionalBrowsable, PropertyUpdateSequence` |
| `IsOffsetable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `Length` |
| `Rotation` | `Double` | `get` | No | `Angle` |
| `StartPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `Width` | `Double` | `get/set` | No | `Length` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToPolyline` | `DwgPolyline` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IPolylineConverter` | `ToPolyline` |
| `ILinearObject` | `GetPolyline` |
| `ICompoundLinearObject` | `GetPathList` |

### `DwgPointSignInsRoadMarking` (class)

**Attributes**: [DesignAlias, Obsolete(Message: `Use DwgPointSignSmdxRoadMarking instead`), EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgPointSignInsRoadMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgPointSignInsRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Annotative` | `Boolean` | `get/set` | No | `Browsable` |
| `Attribs` | `IEnumerable<IAttrib>` | `get` | No | `PropertyProvider` |
| `Block` | `DwgBlock` | `get/set` | No | `PropertyEditor, ConditionalBrowsable, ReadOnly` |
| `Description` | `String` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `HasAttribs` | `Boolean` | `get` | No | `Browsable` |
| `InvertMatrix` | `Matrix` | `get` | No | `Browsable` |
| `IsBackgroud` | `Boolean` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Scale` | `Vector3D` | `get/set` | No | `GlobalVector` |
| `Speed` | `Double` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter, PropertyEditor` |
| `Square` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |
| `XScaleFactor` | `Double` | `get/set` | No | `Browsable` |
| `YScaleFactor` | `Double` | `get/set` | No | `Browsable` |
| `ZScaleFactor` | `Double` | `get/set` | No | `Browsable` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAttrib` | `IAttrib` | `String tag, Boolean muliString` | `` |
| `ClearAttribs` | `Void` | `` | `` |
| `GetAnnotativeBounds` | `BoundingBox2D` | `Double scale` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IntersectWith` | `Boolean` | `BoundingBox2D box, Double scale` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `NotifyChange` | `Void` | `DwgObject sender, EventArgs e` | `` |
| `RemoveAttrib` | `Void` | `IAttrib attrib` | `` |
| `RemoveAttribAt` | `Void` | `Int32 index` | `` |
| `ToString` | `String` | `` | `` |
| `UseReference` | `Boolean` | `DwgObject obj` | `` |

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
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |

### `DwgPointSignSmdxRoadMarking` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgPointSignSmdxRoadMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Visualization.ImElementHolder, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgPointSignSmdxRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Areas` | `KeyValuePair<CadColor Double>[]` | `get` | No | `Browsable` |
| `BlockColor` | `CadColor` | `get` | No | `Browsable` |
| `Element` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider` |
| `EntityName` | `String` | `get` | No | `` |
| `GrayScale` | `Boolean` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `PrefferedDirectionForward` | `Boolean` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `PrefferedLocation` | `MarkingPosition` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence, PropertyTypeConverter` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Scale` | `Vector3D` | `get` | No | `Browsable` |
| `Station` | `Double` | `get/set` | No | `PropertyProvider, ConditionalReadOnly` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateModel` | `GeometryModel3D` | `ref Matrix matrix` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `Refresh` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetReplacedEntitys` | `IEnumerable<DwgEntity>` | `DwgPointSignSmdxRoadMarking e` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxPointRoadMarking"` | `` |

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
| `ImElementHolder` | `get_Element` |
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |

### `DwgRoadMarking` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cache3d` | `BlobGeometryModelsCache` | `get/set` | No | `Browsable` |
| `Kilometers` | `IKilometers` | `get` | No | `Browsable` |
| `Stationing` | `IStationing` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetTypedObject` | `ImAggregates` | `` | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IStationingRepository` | `get_Stationing` |

### `DwgSmdxRoadMarking` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Areas` | `KeyValuePair<CadColor Double>[]` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `Element` | `ImElement` | `get/set` | No | `` |
| `HasCache3d` | `Boolean` | `get` | No | `Browsable` |
| `Kilometers` | `IKilometers` | `get` | No | `Browsable` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `Stationing` | `IStationing` | `get` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateModel` | `GeometryModel3D` | `ref Matrix m` | `` |
| `Dispose` | `Void` | `` | `` |
| `IsAdditionalColor` | `Boolean` | `CadColor color` | `` |
| `Refresh` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Model3d` | `GeometryModel3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IStationingRepository` | `get_Stationing` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |

### `DwgSmdxRoadMarkingBuilder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BuildArea` | `Vector2F[]` | `AreaPattern pattern, IList<Vector2D> vectors, IList<Vector2D> bounds, ref Vector2D pivot` | `` |
| `BuildLinear` | `Vector2F[][]` | `LinearPattern[] patterns, IList<Vector2D> vectors, Double frotation, Boolean cutting, Boolean vinvert, ref Double length, ref Vector2D pivot` | `` |

#### Nested Types (3)

- `AreaPattern` (struct)
- `LinearPattern` (struct)
- `LinearPatternStyle` (enum)

### `DwgStoppingPlaceMarking` (class)

**Attributes**: [EntityController, Obsolete(Message: `Use DwgAreaSmdxRoadMarking instead`), DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgStoppingPlaceMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Dwg.Entities.IPolylineConverter, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICompoundLinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgStoppingPlaceMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CachePoly` | `DwgPolyline` | `get` | No | `Browsable` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Delta` | `Vector2D` | `get` | No | `DeltaVector` |
| `EndPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsOffsetable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `Length` |
| `LineLength` | `Double` | `get` | No | `Length` |
| `Rotation` | `Double` | `get` | No | `Angle` |
| `Side` | `PlaceSide` | `get/set` | No | `PropertyUpdateSequence` |
| `StartPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToPolyline` | `DwgPolyline` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Size` | `Single` | Yes | `` | `` |
| `Width` | `Single` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |
| `IPolylineConverter` | `ToPolyline` |
| `ILinearObject` | `GetPolyline` |
| `ICompoundLinearObject` | `GetPathList` |

### `DwgTrafficIslandMarking` (class)

**Attributes**: [DefaultMember, DesignAlias, Obsolete(Message: `Use DwgAreaSmdxRoadMarking instead`), EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgTrafficIslandMarking` |
| **Base Type** | `Topomatic.RoadMarking.Entities.DwgRoadMarking` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.IPolyline3D, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICompoundLinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.RoadMarking.Entities.DwgRoadMarking`
        - `Topomatic.RoadMarking.Entities.DwgTrafficIslandMarking`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cache` | `List<DwgEntity>` | `get` | No | `Browsable` |
| `Closed` | `Boolean` | `get/set` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `EndDestPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IslandType` | `TrafficIslandType` | `get/set` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `BugleVector3D` | `get/set` | No | `Browsable` |
| `LeftStroke` | `Boolean` | `get/set` | No | `` |
| `RightStroke` | `Boolean` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `Browsable` |
| `StartDestPos` | `Vector2D` | `get/set` | No | `PropertyUpdateSequence` |
| `StrokeCount` | `Int32` | `get/set` | No | `` |
| `Width` | `Double` | `get` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BugleVector3D item` | `` |
| `AssignPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BugleVector3D item` | `` |
| `CopyTo` | `Void` | `BugleVector3D[] array, Int32 arrayIndex` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<BugleVector3D>` | `` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetSolidArea` | `Double` | `` | `` |
| `IndexOf` | `Int32` | `BugleVector3D item` | `` |
| `Insert` | `Void` | `Int32 index, BugleVector3D item` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `Remove` | `Boolean` | `BugleVector3D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SegmentBound` | `BoundingBox2D` | `Int32 index` | `Browsable` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IPolyline3D` | `get_Closed` |
| `IPolyline3D` | `set_Closed` |
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
| `ILinearObject` | `GetPolyline` |
| `ICompoundLinearObject` | `GetPathList` |

### `LinearMarkingType` (enum)

**Attributes**: [Obsolete, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.LinearMarkingType` |
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
      - `Topomatic.RoadMarking.Entities.LinearMarkingType`

#### Fields (16)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LINEAR_ROAD_MARKING_1_1` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_1` | `` |
| `LINEAR_ROAD_MARKING_1_10` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_10` | `` |
| `LINEAR_ROAD_MARKING_1_11` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_11` | `` |
| `LINEAR_ROAD_MARKING_1_12` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_12` | `` |
| `LINEAR_ROAD_MARKING_1_13` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_13` | `` |
| `LINEAR_ROAD_MARKING_1_17` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_17` | `` |
| `LINEAR_ROAD_MARKING_1_2` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_2` | `` |
| `LINEAR_ROAD_MARKING_1_25` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_25` | `` |
| `LINEAR_ROAD_MARKING_1_3` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_3` | `` |
| `LINEAR_ROAD_MARKING_1_4` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_4` | `` |
| `LINEAR_ROAD_MARKING_1_5` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_5` | `` |
| `LINEAR_ROAD_MARKING_1_6` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_6` | `` |
| `LINEAR_ROAD_MARKING_1_7` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_7` | `` |
| `LINEAR_ROAD_MARKING_1_8` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_8` | `` |
| `LINEAR_ROAD_MARKING_1_9` | `LinearMarkingType` | Yes | `LINEAR_ROAD_MARKING_1_9` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `LINEAR_ROAD_MARKING_1_1` | `0` |
| `LINEAR_ROAD_MARKING_1_2` | `1` |
| `LINEAR_ROAD_MARKING_1_3` | `3` |
| `LINEAR_ROAD_MARKING_1_4` | `4` |
| `LINEAR_ROAD_MARKING_1_5` | `5` |
| `LINEAR_ROAD_MARKING_1_6` | `6` |
| `LINEAR_ROAD_MARKING_1_7` | `7` |
| `LINEAR_ROAD_MARKING_1_8` | `8` |
| `LINEAR_ROAD_MARKING_1_9` | `9` |
| `LINEAR_ROAD_MARKING_1_10` | `10` |
| `LINEAR_ROAD_MARKING_1_11` | `11` |
| `LINEAR_ROAD_MARKING_1_12` | `12` |
| `LINEAR_ROAD_MARKING_1_13` | `13` |
| `LINEAR_ROAD_MARKING_1_17` | `14` |
| `LINEAR_ROAD_MARKING_1_25` | `15` |

**Underlying Type**: `System.Byte`

### `LinearMarkingTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.LinearMarkingTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.Entities.LinearMarkingTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LinearPattern` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+LinearPattern` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+LinearPattern`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DashLength` | `Single` | No | `` | `` |
| `Invert` | `Boolean` | No | `` | `` |
| `Length` | `Single` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `SpaceBetween` | `Single` | No | `` | `` |
| `Style` | `LinearPatternStyle` | No | `` | `` |
| `Width` | `Single` | No | `` | `` |

### `LinearPatternStyle` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+LinearPatternStyle` |
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
      - `Topomatic.RoadMarking.Entities.DwgSmdxRoadMarkingBuilder+LinearPatternStyle`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arrows` | `LinearPatternStyle` | Yes | `Arrows` | `` |
| `Dash` | `LinearPatternStyle` | Yes | `Dash` | `` |
| `Empty` | `LinearPatternStyle` | Yes | `Empty` | `` |
| `Line` | `LinearPatternStyle` | Yes | `Line` | `` |
| `Rectangle` | `LinearPatternStyle` | Yes | `Rectangle` | `` |
| `Triangle` | `LinearPatternStyle` | Yes | `Triangle` | `` |
| `value__` | `Int32` | No | `` | `` |
| `ZigZag` | `LinearPatternStyle` | Yes | `ZigZag` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Empty` | `0` |
| `Line` | `1` |
| `Dash` | `2` |
| `Rectangle` | `3` |
| `Triangle` | `4` |
| `Arrows` | `5` |
| `ZigZag` | `6` |

**Underlying Type**: `System.Int32`

### `PlaceSide` (enum)

**Attributes**: [Obsolete, PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.PlaceSide` |
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
      - `Topomatic.RoadMarking.Entities.PlaceSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `PlaceSide` | Yes | `Left` | `` |
| `Right` | `PlaceSide` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Right` | `1` |
| `Left` | `-1` |

**Underlying Type**: `System.Int32`

### `PlaceSideConverter` (class)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.PlaceSideConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.Entities.PlaceSideConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TrafficIslandType` (enum)

**Attributes**: [PropertyTypeConverter, Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.TrafficIslandType` |
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
      - `Topomatic.RoadMarking.Entities.TrafficIslandType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DividerCodirectional` | `TrafficIslandType` | Yes | `DividerCodirectional` | `` |
| `DividerOpposite` | `TrafficIslandType` | Yes | `DividerOpposite` | `` |
| `MergeFlow` | `TrafficIslandType` | Yes | `MergeFlow` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DividerOpposite` | `0` |
| `DividerCodirectional` | `1` |
| `MergeFlow` | `2` |

**Underlying Type**: `System.Byte`

### `TrafficIslandTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.RoadMarking.Entities.TrafficIslandTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.RoadMarking.Entities.TrafficIslandTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 28 |
| **Classes** | 14 |
| **Interfaces** | 0 |
| **Enums** | 7 |
| **Structs** | 2 |
| **Abstract Classes** | 2 |
| **Static Classes** | 3 |
| **Total Methods** | 134 |
| **Total Properties** | 145 |
| **Total Fields** | 85 |
| **Total Events** | 0 |
| **Total Constructors** | 16 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


