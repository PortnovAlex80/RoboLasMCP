# Topomatic.Landscaping

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Landscaping` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Landscaping.dll` |

---
## Namespace: `Topomatic.Landscaping`

### `DwgSmdxGroupLandscaping` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.DwgSmdxGroupLandscaping` |
| **Base Type** | `Topomatic.Landscaping.DwgSmdxLandscaping` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Landscaping.DwgSmdxLandscaping`
        - `Topomatic.Landscaping.DwgSmdxGroupLandscaping`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `LeaderIndex` | `Int32` | `get/set` | No | `Browsable` |
| `LeaderStart` | `Vector2D` | `get` | No | `Browsable` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `PlantsPosition` | `IEnumerable<Vector2D>` | `get` | No | `Browsable` |
| `Positions` | `IList<Vector2D>` | `get` | No | `Browsable` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `SortByXY` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `DwgSmdxHedgerowLandscaping` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.DwgSmdxHedgerowLandscaping` |
| **Base Type** | `Topomatic.Landscaping.DwgSmdxLandscaping` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Landscaping.DwgSmdxLandscaping`
        - `Topomatic.Landscaping.DwgSmdxHedgerowLandscaping`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BranchCount` | `Int32` | `get/set` | No | `` |
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `DitchLines` | `IEnumerable<Polyline2DCurve>` | `get` | No | `Browsable` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `LeaderIndex` | `Int32` | `get/set` | No | `Browsable` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `PlantsPosition` | `IEnumerable<Vector2D>` | `get` | No | `` |
| `Polyline` | `Polyline2DCurve` | `get` | No | `Browsable` |
| `RowType` | `HedgrowType` | `get/set` | No | `PropertyTypeConverter` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPolyline` | `Void` | `Polyline2DCurve polyline` | `` |
| `GetAnnotativeDitchLines` | `IEnumerable<Polyline2DCurve>` | `Double scale` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToPolyline` | `DwgPolyline` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RADIUS` | `Single` | Yes | `0.5` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `DwgSmdxLandscaping` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.DwgSmdxLandscaping` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Landscaping.DwgSmdxLandscaping`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (26)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Block` | `DwgBlock` | `get` | No | `Browsable` |
| `BlockPit` | `DwgBlock` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `Browsable` |
| `EntityStyle` | `LandscapeStyle` | `get/set` | No | `` |
| `Gost` | `String` | `get/set` | No | `PropertyProvider, PropertyUpdateSequence` |
| `HasCache3d` | `Boolean` | `get` | No | `Browsable` |
| `HasLandscapeElements` | `Boolean` | `get` | No | `Browsable` |
| `LeadBlock` | `DwgBlock` | `get` | No | `Browsable` |
| `LeaderOffset` | `Vector3D` | `get/set` | No | `Browsable` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Number` | `Int32` | `get/set` | No | `` |
| `PitObject` | `UndergroundParams` | `get/set` | No | `PropertyProvider` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `PlantElement` | `ImElement` | `get/set` | No | `PropertyUpdateSequence, PropertyProvider` |
| `PlantElementProperties` | `UpdatableTypedObjectWrapper` | `get` | No | `TypedObjectPropertiesExclude, WrappedTypedObjectProvider, PropertyUpdateSequence` |
| `PlantGroup` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyProvider` |
| `PlantsPosition` | `IEnumerable<Vector2D>` | `get` | No | `Browsable` |
| `PlantType` | `TreeType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, PropertyProvider` |
| `RelativeRotation` | `Double` | `get` | No | `Browsable` |
| `Scale` | `Single` | `get` | No | `Browsable` |
| `ShowLeader` | `Boolean` | `get/set` | No | `` |
| `Sort` | `String` | `get/set` | No | `PropertyUpdateSequence, PropertyProvider` |
| `SubGroup` | `String` | `get/set` | No | `ConditionalBrowsable, PropertyUpdateSequence, PropertyProvider` |
| `TextBlock` | `DwgBlock` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `EqualsLandscapeElements` | `Boolean` | `DwgSmdxLandscaping entity` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `Reset` | `Void` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEntitys` | `IEnumerable<DwgEntity>` | `DwgBlock block, Dictionary<String String> attribs, TypedObject tobj` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxLandscapePlanting"` | `` |
| `PIT_SMDX` | `String` | Yes | `"SmdxLandscapeUnderground"` | `` |
| `PLANT_SMDX` | `String` | Yes | `"SmdxLandscapePlant"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |

### `DwgSmdxLinearLandscaping` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.DwgSmdxLinearLandscaping` |
| **Base Type** | `Topomatic.Landscaping.DwgSmdxLandscaping` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Landscaping.DwgSmdxLandscaping`
        - `Topomatic.Landscaping.DwgSmdxLinearLandscaping`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `Hiddens` | `Hidden` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `LeaderIndex` | `Int32` | `get/set` | No | `Browsable` |
| `LeaderStart` | `Vector2D` | `get` | No | `Browsable` |
| `LeftRow` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Method` | `LinearPlanting` | `get/set` | No | `PropertyTypeConverter, ConditionalBrowsable` |
| `OnVertexOnly` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `OptionalLines` | `IList<Polyline2DCurve>` | `get` | No | `Browsable` |
| `Padding` | `Single` | `get/set` | No | `ConditionalBrowsable` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `PlantsPosition` | `IEnumerable<Vector2D>` | `get` | No | `Browsable` |
| `Polyline` | `Polyline2DCurve` | `get` | No | `Browsable` |
| `RightRow` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `Step` | `Double` | `get/set` | No | `ConditionalBrowsable` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignPolyline` | `Void` | `Polyline2DCurve polyline` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLastElementPosOnLine` | `Vector2D` | `` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToPolyline` | `DwgPolyline` | `` | `` |
| `ToPolyline` | `DwgPolyline` | `Polyline2DCurve polyline2d` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `DwgSmdxPointLandscaping` (class)

**Attributes**: [EntityController, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.DwgSmdxPointLandscaping` |
| **Base Type** | `Topomatic.Landscaping.DwgSmdxLandscaping` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder, Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Landscaping.DwgSmdxLandscaping`
        - `Topomatic.Landscaping.DwgSmdxPointLandscaping`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Pivot3d` | `Vector3D` | `get` | No | `Browsable` |
| `PlantsPosition` | `IEnumerable<Vector2D>` | `get` | No | `Browsable` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuickDimensionPoints` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToString` | `String` | `` | `` |

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

### `Hidden` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Hidden` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Landscaping.HiddenArea, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Polyline2DCurve line)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `Browsable` |
| `Item` | `HiddenArea` | `get/set` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `HiddenArea area` | `` |
| `AddByPoints` | `Boolean` | `Vector2D startPoint, Vector2D endPoint` | `` |
| `AddByStation` | `Boolean` | `Double start, Double end` | `` |
| `AddOnVertex` | `Boolean` | `Int32 startIdx, Int32 endIdx` | `` |
| `BetweenHiddenArea` | `Boolean` | `Double station` | `` |
| `Check` | `Boolean` | `Int32 idx` | `` |
| `Check` | `Void` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `GetAreaAt` | `Boolean` | `Int32 index, ref HiddenArea area` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetHiddenWithPadding` | `Hidden` | `Polyline2DCurve polyline, Double offset` | `` |
| `IndexOf` | `Int32` | `HiddenArea area` | `` |
| `Remove` | `Boolean` | `HiddenArea area` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `System.Collections.Generic.IEnumerable<Topomatic.Landscaping.HiddenArea>.GetEnumerator` |
| `IEnumerable` | `GetEnumerator` |

### `HiddenArea` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.HiddenArea` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Landscaping.HiddenArea`

#### Constructors (1)

- `.ctor(Double start, Double end)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `Double` | No | `` | `` |
| `Start` | `Double` | No | `` | `` |

### `LandscapeSettings` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeSettings` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Region` | `String` | `get/set` | Yes | `` |

### `LandscapingTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapingTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddToGroup` | `Boolean` | `DwgSmdxGroupLandscaping group, DwgSmdxLandscaping item` | `` |
| `Autonum` | `Void` | `DwgEntities entities` | `` |
| `AutonumByPosAndType` | `Void` | `DwgEntities entities, TreeType treeType` | `` |
| `AutonumByPosition` | `Void` | `DwgEntities entities` | `` |
| `BreakGroup` | `List<DwgSmdxPointLandscaping>` | `DwgSmdxGroupLandscaping group` | `` |
| `CutPolylineToPos` | `Void` | `Vector2D lastElement, Polyline2DCurve polyline` | `` |
| `GetNearestPos` | `Boolean` | `IEnumerable<Vector2D> positions, Vector2D vertex, ref Int32 idx` | `` |
| `GetPolyWithPadding` | `Polyline2DCurve` | `Polyline2DCurve polyline, Double padding` | `` |
| `GetVertexes` | `IEnumerable<Vector2D>` | `Polyline2DCurve polyline` | `` |
| `GroupByLandscapeElements` | `List<List<DwgSmdxLandscaping>>` | `IEnumerable<DwgEntity> entities, Action<List<DwgSmdxLandscaping> DwgSmdxLandscaping> add` | `` |
| `GroupElementAt` | `DwgSmdxPointLandscaping` | `Int32 idx, DwgSmdxGroupLandscaping group` | `` |
| `IsPointOnLine` | `Boolean` | `BugleVector2D a, BugleVector2D b, Vector2D point` | `` |
| `PosForStructLine` | `IEnumerable<Vector3D>` | `Polyline2DCurve polyline, Double scale` | `` |
| `SortByPos` | `Int32` | `Vector2D vertex1, Vector2D vertex2` | `` |
| `SortEntitiesByPosAndType` | `List<List<DwgSmdxLandscaping>>` | `DwgEntities entities, TreeType treeType` | `` |
| `TextOffset` | `Vector3D` | `DwgSmdxLandscaping entity` | `` |
| `TextOffset` | `Vector3D` | `DwgSmdxLandscaping entity, Double annotationScale` | `` |
| `ToPolyline2DCurve` | `Polyline2DCurve` | `IPolyline3D polyline` | `` |

### `UndergroundParams` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.UndergroundParams` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.INamedObject, System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Landscaping.UndergroundParams`

#### Constructors (3)

- `.ctor(String name)`
- `.ctor(String placeName, TreeType plantType, RootSystem rootType, RootForm form)`
- `.ctor(String placeName, TreeType plantType, RootSystem rootType, RootForm form, Double clodSize, Double clodHeight)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ClodHeight` | `Double` | `get/set` | No | `PropertyUpdateSequence` |
| `ClodSize` | `Double` | `get/set` | No | `PropertyUpdateSequence` |
| `ClodVolume` | `Double` | `get/set` | No | `ReadOnly` |
| `DitchType` | `Int32` | `get/set` | No | `Browsable` |
| `Form` | `RootForm` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `GroundVolume100` | `Double` | `get/set` | No | `ReadOnly` |
| `GroundVolume50` | `Double` | `get/set` | No | `ReadOnly` |
| `IsEmpty` | `Boolean` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `Browsable` |
| `PitDepth` | `Double` | `get/set` | No | `PropertyUpdateSequence` |
| `PitSize` | `Double` | `get/set` | No | `PropertyUpdateSequence` |
| `PitVolume` | `Double` | `get/set` | No | `ReadOnly` |
| `PlantType` | `TreeType` | `get/set` | No | `PropertyTypeConverter, Browsable` |
| `RootDiameter` | `Double` | `get/set` | No | `` |
| `RootLength` | `Double` | `get/set` | No | `` |
| `RootType` | `RootSystem` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateVolumes` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `ConvertToPlantProps` | `ImProperties` | `` | `` |
| `ConvertToProps` | `ImProperties` | `` | `` |
| `EqualsObj` | `Boolean` | `UndergroundParams under` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `ICloneable` | `Clone` |

---
## Namespace: `Topomatic.Landscaping.LandscapeLibrary`

### `HedgrowType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.HedgrowType` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.HedgrowType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DOUBLE` | `HedgrowType` | Yes | `DOUBLE` | `` |
| `SINGLE` | `HedgrowType` | Yes | `SINGLE` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SINGLE` | `0` |
| `DOUBLE` | `1` |

**Underlying Type**: `System.Int32`

### `HedgrowTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.HedgrowTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.HedgrowTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LandscapeParser` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.LandscapeParser` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBlockName` | `String` | `String name, String type` | `` |
| `GetBlocks` | `String[]` | `String type` | `` |

### `LinearPlanting` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.LinearPlanting` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.LinearPlanting`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Chess` | `LinearPlanting` | Yes | `Chess` | `` |
| `Parallel` | `LinearPlanting` | Yes | `Parallel` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Parallel` | `0` |
| `Chess` | `1` |

**Underlying Type**: `System.Int32`

### `LinearPlantingConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.LinearPlantingConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.LinearPlantingConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `PlantingEnum` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.PlantingEnum` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.PlantingEnum`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Hedgerow` | `PlantingEnum` | Yes | `Hedgerow` | `` |
| `Linear` | `PlantingEnum` | Yes | `Linear` | `` |
| `Point` | `PlantingEnum` | Yes | `Point` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Point` | `0` |
| `Linear` | `1` |
| `Hedgerow` | `2` |

**Underlying Type**: `System.Int32`

### `PlantingEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.PlantingEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.PlantingEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RootForm` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.RootForm` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.RootForm`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ROUND` | `RootForm` | Yes | `ROUND` | `` |
| `SQUARE` | `RootForm` | Yes | `SQUARE` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ROUND` | `0` |
| `SQUARE` | `1` |

**Underlying Type**: `System.Int32`

### `RootFormConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.RootFormConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.RootFormConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `RootSystem` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.RootSystem` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.RootSystem`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CLOSED` | `RootSystem` | Yes | `CLOSED` | `` |
| `OPEN` | `RootSystem` | Yes | `OPEN` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `OPEN` | `0` |
| `CLOSED` | `1` |

**Underlying Type**: `System.Int32`

### `RootSystemConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.RootSystemConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.RootSystemConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TreeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.TreeType` |
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
      - `Topomatic.Landscaping.LandscapeLibrary.TreeType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CONIFER_TREE` | `TreeType` | Yes | `CONIFER_TREE` | `` |
| `CONIFEROUS_SHRUBS` | `TreeType` | Yes | `CONIFEROUS_SHRUBS` | `` |
| `DECIDUOUS_SHRUBS` | `TreeType` | Yes | `DECIDUOUS_SHRUBS` | `` |
| `DECIDUOUS_TREE` | `TreeType` | Yes | `DECIDUOUS_TREE` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DECIDUOUS_TREE` | `0` |
| `CONIFER_TREE` | `1` |
| `DECIDUOUS_SHRUBS` | `2` |
| `CONIFEROUS_SHRUBS` | `3` |

**Underlying Type**: `System.Int32`

### `TreeTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.LandscapeLibrary.TreeTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Landscaping.LandscapeLibrary.TreeTypeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

---
## Namespace: `Topomatic.Landscaping.Sheets`

### `LandscapeSheet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Sheets.LandscapeSheet` |
| **Base Type** | `Topomatic.Tables.Export.TemplateSheet` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Tables.Export.UserSheet`
    - `Topomatic.Tables.Export.TemplateSheet`
      - `Topomatic.Landscaping.Sheets.LandscapeSheet`

#### Constructors (1)

- `.ctor(String name, Drawing drawing, TreeType type)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFrame` | `UserSheetWizardFrame` | `Object moniker` | `` |
| `GetMonikers` | `IEnumerable<Object>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Landscaping.Styles`

### `LandscapeStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Styles.LandscapeStyle` |
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
      - `Topomatic.Landscaping.Styles.LandscapeStyle`

#### Constructors (1)

- `.ctor(IDwgNamedCollection owner, String name)`

#### Properties (32)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoRotate` | `Boolean` | `get/set` | No | `` |
| `BlockScale` | `Double` | `get/set` | No | `` |
| `BushClod` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `BushPit` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `BushSize` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ConiferClod` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ConiferPit` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ConiferSize` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `CrownEnabled` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `DitchWidth` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `Font` | `CadFont` | `get` | No | `Browsable` |
| `HatchColor` | `CadColor` | `get/set` | No | `ConditionalBrowsable` |
| `HedgeLineScale` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `IsReadCrown` | `Boolean` | `get` | No | `Browsable` |
| `IsReadPit` | `Boolean` | `get` | No | `Browsable` |
| `IsReadText` | `Boolean` | `get` | No | `Browsable` |
| `LeadColor` | `CadColor` | `get/set` | No | `` |
| `LeaderBackground` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `LeaderFont` | `CadFont` | `get` | No | `Browsable` |
| `LeaderHeight` | `Double` | `get/set` | No | `` |
| `LeaderStyle` | `DwgStyle` | `get/set` | No | `` |
| `LeafyClod` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `LeafyPit` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `LeafySize` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `LineVisible` | `Boolean` | `get/set` | No | `` |
| `PitColor` | `CadColor` | `get/set` | No | `` |
| `PitEnabled` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `SizeEnabled` | `Boolean` | `get/set` | No | `PropertyUpdateSequence` |
| `StructColor` | `CadColor` | `get/set` | No | `` |
| `Style` | `DwgStyle` | `get/set` | No | `` |
| `TextVisible` | `Boolean` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `OnCopy` | `Void` | `DwgObject obj, ReferencesContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

### `LandscapeStyles` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Landscaping.Styles.LandscapeStyles` |
| **Base Type** | `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Landscaping.Styles.LandscapeStyle, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Dwg.IDwgCollection, Topomatic.Dwg.IDwgDatabase, System.Collections.Generic.IEnumerable`1[[Topomatic.Landscaping.Styles.LandscapeStyle, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.ICollection, Topomatic.Dwg.IDwgNamedCollection, Topomatic.Visualization.IStgContextSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.DwgCollection`1[[Topomatic.Landscaping.Styles.LandscapeStyle, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Dwg.DwgNamedCollection`1[[Topomatic.Landscaping.Styles.LandscapeStyle, Topomatic.Landscaping, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
        - `Topomatic.Landscaping.Styles.LandscapeStyles`

#### Constructors (1)

- `.ctor(IDwgDatabase owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Default` | `LandscapeStyle` | `get/set` | No | `` |
| `Group` | `LandscapeStyle` | `get` | No | `` |
| `Hedgerow` | `LandscapeStyle` | `get` | No | `` |
| `Linear` | `LandscapeStyle` | `get` | No | `` |
| `ObjectName` | `String` | `get` | No | `` |
| `Point` | `LandscapeStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ENTITY_NAME` | `String` | Yes | `"LANDSCAPESTYLES"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgContextSerializable` | `LoadFromStg` |
| `IStgContextSerializable` | `SaveToStg` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 26 |
| **Classes** | 14 |
| **Interfaces** | 0 |
| **Enums** | 6 |
| **Structs** | 2 |
| **Abstract Classes** | 1 |
| **Static Classes** | 3 |
| **Total Methods** | 95 |
| **Total Properties** | 134 |
| **Total Fields** | 28 |
| **Total Events** | 0 |
| **Total Constructors** | 19 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


