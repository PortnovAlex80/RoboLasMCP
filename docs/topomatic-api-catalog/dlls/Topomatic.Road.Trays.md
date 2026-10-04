# Topomatic.Road.Trays

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Road.Trays` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Road.Trays, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Road.Trays.dll` |

---
## Namespace: `Topomatic.Road.Trays`

### `TraySide` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.TraySide` |
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
      - `Topomatic.Road.Trays.TraySide`

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

### `TraySnap` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.TraySnap` |
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
      - `Topomatic.Road.Trays.TraySnap`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alignment` | `TraySnap` | Yes | `Alignment` | `` |
| `None` | `TraySnap` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Alignment` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Road.Trays.DwgEdgeTrayEntity`

### `DwgEdgeTray` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTray` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTray`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double sta1, Double sta2, TraySide side)`
- `.ctor(Double sta1, Double sta2, TraySide side, ImElement element)`

#### Properties (18)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Arrangements` | `List<EdgeTrayArrangement>` | `get` | No | `Browsable` |
| `BaseAxis` | `EdgeTrayBaseAxis` | `get/set` | No | `DisplayName, ConditionalReadOnly, Category` |
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `Bounds3d` | `BoundingBox3D` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `Curve` | `Polyline2DCurve` | `get/set` | No | `Browsable` |
| `Element` | `ImElement` | `get` | No | `Browsable` |
| `EndStation` | `Double` | `get/set` | No | `Category, ConditionalReadOnly, PropertyProvider` |
| `EntityName` | `String` | `get` | No | `Browsable` |
| `HorizontalOffset` | `Double` | `get/set` | No | `Category, DisplayName, Length, ConditionalReadOnly` |
| `IsBreakable` | `Boolean` | `get` | No | `Browsable` |
| `IsProxyGraphics` | `Boolean` | `get` | No | `Browsable` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `StartStation` | `Double` | `get/set` | No | `Category, PropertyProvider, ConditionalReadOnly` |
| `Stationing` | `IStationing` | `get` | No | `Browsable` |
| `TraySide` | `TraySide` | `get/set` | No | `ConditionalReadOnly, Category, DisplayName` |
| `TraySnap` | `TraySnap` | `get/set` | No | `DisplayName, Category` |
| `VerticalOffset` | `Double` | `get/set` | No | `ConditionalReadOnly, Category, DisplayName, Length` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Fire` | `Nullable<Double>` | `Ray3D ray` | `` |
| `GetAlignment` | `RoadAlignment` | `` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPlan` | `DwgBlock` | `` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"Topomatic.Dwg.Entities.DwgEdgeTray"` | `` |
| `LENGTH_PROPERTY_TAG` | `String` | Yes | `"prop_length"` | `` |
| `MIRRORED_PROPERTY_TAG` | `String` | Yes | `"prop_mirrored"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |
| `IStationingRepository` | `get_Stationing` |
| `IPointObject` | `get_BasePoint` |

### `DwgEdgeTrayController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTrayController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTrayController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SupportPaint3d` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Fire` | `Nullable<Double>` | `DwgEntity entity, Ray3D ray` | `` |
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `EdgeTrayArrangement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgEdgeTrayEntity.EdgeTrayArrangement` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned`1[[Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTray, Topomatic.Road.Trays, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IOwned, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(DwgEdgeTray owner)`
- `.ctor(DwgEdgeTray owner, Double station, ImElement element)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get/set` | No | `DisplayName, ImObjectPropertyProvider` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Station` | `Double` | `get/set` | No | `Length, DisplayName` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned`1` | `Topomatic.FoundationClasses.IOwned<Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTray>.get_Owner` |
| `IOwned`1` | `Topomatic.FoundationClasses.IOwned<Topomatic.Road.Trays.DwgEdgeTrayEntity.DwgEdgeTray>.set_Owner` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `EdgeTrayBaseAxis` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgEdgeTrayEntity.EdgeTrayBaseAxis` |
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
      - `Topomatic.Road.Trays.DwgEdgeTrayEntity.EdgeTrayBaseAxis`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RoadEdge` | `EdgeTrayBaseAxis` | Yes | `RoadEdge` | `` |
| `SlopeEdge` | `EdgeTrayBaseAxis` | Yes | `SlopeEdge` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RoadEdge` | `0` |
| `SlopeEdge` | `1` |

**Underlying Type**: `System.Int32`

### `EdgeTrayBaseAxisEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgEdgeTrayEntity.EdgeTrayBaseAxisEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Road.Trays.DwgEdgeTrayEntity.EdgeTrayBaseAxisEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Road.Trays.DwgTelescopicTrayEntity`

### `DwgTelescopicTray` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgTelescopicTrayEntity.DwgTelescopicTray` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.IPointObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Road.Trays.DwgTelescopicTrayEntity.DwgTelescopicTray`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (43)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `DisplayName, Angle, ConditionalReadOnly` |
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `Bounds3d` | `BoundingBox3D` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `CatcherDescription` | `String` | `get/set` | No | `Category, DisplayName` |
| `CatcherElement` | `ImElement` | `get/set` | No | `Category, DisplayName, ImObjectPropertyProvider` |
| `CatcherIncline` | `Int32` | `get/set` | No | `DisplayName, Category` |
| `CatcherLengthFar` | `Double` | `get/set` | No | `DisplayName, Category` |
| `CatcherLengthNear` | `Double` | `get/set` | No | `DisplayName, Category` |
| `CatcherType` | `String` | `get/set` | No | `DisplayName, Category` |
| `CatcherWidthFarLeft` | `Double` | `get/set` | No | `Category, DisplayName` |
| `CatcherWidthFarRight` | `Double` | `get/set` | No | `DisplayName, Category` |
| `CatcherWidthMidLeft` | `Double` | `get/set` | No | `Category, DisplayName` |
| `CatcherWidthMidRight` | `Double` | `get/set` | No | `Category, DisplayName` |
| `CatcherWidthNearLeft` | `Double` | `get/set` | No | `Category, DisplayName` |
| `CatcherWidthNearRight` | `Double` | `get/set` | No | `Category, DisplayName` |
| `DamperDeepening` | `Double` | `get/set` | No | `DisplayName, Category` |
| `DamperElement` | `ImElement` | `get/set` | No | `DisplayName, Category, ImObjectPropertyProvider` |
| `DitchSlopeIncline` | `Double` | `get/set` | No | `Category, DisplayName` |
| `Element` | `ImElement` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `Browsable` |
| `Height` | `Double` | `get/set` | No | `DisplayName, Length, Category` |
| `IsBreakable` | `Boolean` | `get` | No | `Browsable` |
| `IsProxyGraphics` | `Boolean` | `get` | No | `Browsable` |
| `Length` | `Double` | `get` | No | `Length, Category, DisplayName, ReadOnly` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `PiketNoteOffset` | `Vector2D` | `get/set` | No | `Category, DisplayName` |
| `PlanLength` | `Double` | `get/set` | No | `Length, DisplayName, Category` |
| `Position` | `Vector3D` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly, DisplayName` |
| `Rotation` | `Double` | `get/set` | No | `Category, DisplayName, Length` |
| `StartOffset` | `Double` | `get/set` | No | `Length, Category, DisplayName` |
| `StartOffsetWithIncline` | `Double` | `get` | No | `Browsable` |
| `Station` | `Double` | `get/set` | No | `Category, PropertyProvider, ConditionalReadOnly` |
| `Stationing` | `IStationing` | `get` | No | `Browsable` |
| `TrayCount` | `Int32` | `get` | No | `ReadOnly, DisplayName, Category` |
| `TrayElement` | `ImElement` | `get/set` | No | `DisplayName, Category, ImObjectPropertyProvider` |
| `TrayEnd` | `Vector3D` | `get/set` | No | `DisplayName, Category, Browsable` |
| `TrayEndElevationIncrement` | `Double` | `get/set` | No | `Length, Category, DisplayName` |
| `TrayEndLengthIncrement` | `Double` | `get/set` | No | `DisplayName, Length, Category` |
| `TrayEndStopElement` | `ImElement` | `get/set` | No | `DisplayName, ImObjectPropertyProvider, Category` |
| `TrayEndWithIncrement` | `Vector3D` | `get` | No | `Browsable` |
| `TraySide` | `TraySide` | `get/set` | No | `PropertyTypeConverter, DisplayName, Category, ConditionalReadOnly` |
| `TraySnap` | `TraySnap` | `get/set` | No | `PropertyUpdateSequence, DisplayName, PropertyTypeConverter, Category` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Fire` | `Nullable<Double>` | `Ray3D ray` | `` |
| `GetAlignment` | `RoadAlignment` | `` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPlan` | `DwgBlock` | `` | `Browsable` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_NOTE_OFFSET` | `Vector2D` | No | `` | `` |
| `ENTITY_CAPTION` | `String` | Yes | `"Лоток телескопический"` | `` |
| `ENTITY_NAME` | `String` | Yes | `"Topomatic.Dwg.Entities.DwgTelescopicTray"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IStationingRepository` | `get_Stationing` |
| `IPointObject` | `get_BasePoint` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |

### `DwgTelescopicTrayController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgTelescopicTrayEntity.DwgTelescopicTrayController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Road.Trays.DwgTelescopicTrayEntity.DwgTelescopicTrayController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SupportPaint3d` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Fire` | `Nullable<Double>` | `DwgEntity entity, Ray3D ray` | `` |
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `FlowCatcherSides` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgTelescopicTrayEntity.FlowCatcherSides` |
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
      - `Topomatic.Road.Trays.DwgTelescopicTrayEntity.FlowCatcherSides`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `FlowCatcherSides` | Yes | `Both` | `` |
| `Left` | `FlowCatcherSides` | Yes | `Left` | `` |
| `Right` | `FlowCatcherSides` | Yes | `Right` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Left` | `0` |
| `Right` | `1` |
| `Both` | `2` |

**Underlying Type**: `System.Int32`

### `FlowDamperTypes` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgTelescopicTrayEntity.FlowDamperTypes` |
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
      - `Topomatic.Road.Trays.DwgTelescopicTrayEntity.FlowDamperTypes`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ditch` | `FlowDamperTypes` | Yes | `Ditch` | `` |
| `None` | `FlowDamperTypes` | Yes | `None` | `` |
| `Slope` | `FlowDamperTypes` | Yes | `Slope` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Slope` | `1` |
| `Ditch` | `2` |

**Underlying Type**: `System.Int32`

### `TrayTypes` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Road.Trays.DwgTelescopicTrayEntity.TrayTypes` |
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
      - `Topomatic.Road.Trays.DwgTelescopicTrayEntity.TrayTypes`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `B6` | `TrayTypes` | Yes | `B6` | `` |
| `B7` | `TrayTypes` | Yes | `B7` | `` |
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

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 12 |
| **Classes** | 6 |
| **Interfaces** | 0 |
| **Enums** | 6 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 21 |
| **Total Properties** | 66 |
| **Total Fields** | 26 |
| **Total Events** | 0 |
| **Total Constructors** | 9 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


