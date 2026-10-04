# Topomatic.Visualization.Runtime

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Visualization.Runtime` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Visualization.Runtime, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Visualization.Runtime.dll` |

---
## Namespace: `Topomatic.Visualization.Runtime`

### `Assembly3dExtension` (static class)

**Attributes**: [Obsolete(Message: `Use ImAggregateExtentions instead`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Assembly3dExtension` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProfilePolyline` | `List<Vector3D>` | `List<Vector3D> polyline, IElevationProvider surface` | `` |
| `CreateSmdxPolyline` | `Object` | `List<Vector3D> polyline, Vector3D pivot` | `` |
| `CreateStationOffsetedPolyline` | `List<Vector3D>` | `ICurve curve, IList<KeyValuePair<Double Double>> so` | `` |
| `LinearObjectDescription` | `String` | `Object obj, String name, Vector2D a, Vector2D b` | `` |
| `PointObjectDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkDescription` | `String` | `Object obj, Vector2D position` | `` |
| `PositionPkDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkLengthDescription` | `String` | `Object obj, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthDescription` | `String` | `Object obj, String name, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthValue` | `ImAggregates` | `Object obj, Vector2D a, Vector2D b` | `` |
| `PositionPkLengthValue` | `ImAggregates` | `Object obj, Double station, Double length` | `` |
| `PositionPkPointDescription` | `String` | `Object obj, String name, Vector2D position` | `` |
| `PositionPkPointValue` | `ImAggregates` | `Object obj, Vector2D position, Nullable<Double> z` | `` |
| `PositionPkValue` | `ImAggregates` | `Object obj, Vector2D position` | `` |
| `PositionPkValue` | `ImAggregates` | `Object obj, Double station` | `` |

### `CreateSurfaceEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.CreateSurfaceEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Visualization.Runtime.CreateSurfaceEventArgs`

#### Constructors (1)

- `.ctor(ISurfaceCreator creator, ILayer layer)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Creator` | `ISurfaceCreator` | `get` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `Layer` | `ILayer` | `get` | No | `` |

### `CreateVisualizationEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.CreateVisualizationEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Visualization.Runtime.CreateVisualizationEventArgs`

#### Constructors (1)

- `.ctor(VisualizationMap map, BoundingBox2D bounds, IDictionary<String Object> parameters, ILayer layer, IDictionary<VisualizationGroup String> documents)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Documents` | `IDictionary<VisualizationGroup String>` | `get` | No | `` |
| `Handled` | `Boolean` | `get/set` | No | `` |
| `Layer` | `ILayer` | `get` | No | `` |
| `Map` | `VisualizationMap` | `get` | No | `` |
| `Parameters` | `IDictionary<String Object>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FetchSurfaces` | `ISurface` | `Object container` | `` |

### `CustomVisualisationNodeProperties` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.CustomVisualisationNodeProperties` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetFactory` | `ICustomVisualisationNodePropertyFactory` | `ImTypeDescriptor type` | `` |
| `RegisterFactory` | `Void` | `ImTypeDescriptor type, ICustomVisualisationNodePropertyFactory factory` | `` |

### `Dwg3dsCurveBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Dwg3dsCurveBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyCurve` | `GeometryModel3D` | `CadColor color, Double from, Double to, ref Vector3D pivot` | `` |
| `ApplyCurve` | `GeometryModel3D` | `CadColor color, Vector2D[] section, Int32[] fillPattern, Double from, Double to, ref Vector3D pivot` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyFace` | `Void` | `GeometryModel3D model, String meshName, String materialName, ref MeshGeometry3D mesh, ref MaterialGroup group, Vector3F a, Vector3F b, Vector3F c, Vector3F d` | `` |
| `Create` | `Dwg3dsCurveBuilder` | `ICurve curve` | `` |
| `FillPattern` | `Int32[]` | `Vector2D[] section` | `` |

### `Dwg3dsModel` (class)

**Attributes**: [EntityController, Obsolete, DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Dwg3dsModel` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Visualization.ImElementHolder, Topomatic.Cad.Foundation.IPointObject, Topomatic.Cad.Foundation.IElevationProvider, Topomatic.Cad.Foundation.ITransformedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Visualization.Runtime.Dwg3dsModel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds3d` | `BoundingBox3D` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get/set` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `EntityName` | `String` | `get` | No | `` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `Mesh` | `GeometryModel3D` | `get/set` | No | `Browsable` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Properties` | `IEnumerable<String>` | `get` | No | `PropertyProvider` |
| `Rotation` | `Double` | `get/set` | No | `Angle` |
| `Scale` | `Vector3D` | `get/set` | No | `GlobalVector` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Depricate` | `DwgEntity` | `` | `` |
| `Fire` | `Nullable<Double>` | `Ray3D ray` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |
| `GetProperty` | `String` | `String key` | `` |
| `RemoveProperty` | `Boolean` | `String key` | `` |
| `SetProperty` | `Void` | `String key, String value` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |
| `IElevationProvider` | `GetElevation` |
| `ITransformedObject` | `get_Position` |
| `ITransformedObject` | `get_Scale` |
| `ITransformedObject` | `get_Rotation` |

### `Dwg3dsTextBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Dwg3dsTextBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplyString` | `Double` | `Compound3DElement element, CadColor color, String value, Double height, Boolean flat` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `Dwg3dsTextBuilder` | `` | `` |
| `Create` | `Dwg3dsTextBuilder` | `String fontName` | `` |

### `DwgEmbedHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.DwgEmbedHandler` |
| **Base Type** | `Topomatic.Visualization.Geometry.DirectoryIncludeHandler` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Geometry.IncludeHandler`
    - `Topomatic.Visualization.Geometry.DirectoryIncludeHandler`
      - `Topomatic.Visualization.Runtime.DwgEmbedHandler`

#### Constructors (1)

- `.ctor(Drawing drawing, String directory, Boolean makeTransparentBg)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |
| `Rename` | `String` | `IncludeHandlerType includeType, String filename, Byte[] data` | `` |

### `DwgModel3DElement` (class)

**Attributes**: [DesignAlias, EntityController]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.DwgModel3DElement` |
| **Base Type** | `Topomatic.Dwg.Entities.DwgEntity` |
| **Implements** | `Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Dwg.IDrawingContainer, System.IDisposable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.IObjectDisjoiner, System.ICloneable, Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IExplodable, Topomatic.Cad.Foundation.IColoredObject, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ITransformedObject, Topomatic.Cad.Foundation.IPointObject, Topomatic.Cad.Foundation.IElevationProvider, Topomatic.Visualization.ImElementHolder, Topomatic.Visualization.Design.IConstructionModelHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgObject`
    - `Topomatic.Dwg.Entities.DwgEntity`
      - `Topomatic.Visualization.Runtime.DwgModel3DElement`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `AreaBottom` | `Double` | `get` | No | `Area, Summarize` |
| `AreaSide` | `Double` | `get` | No | `Area, Summarize` |
| `AreaTop` | `Double` | `get` | No | `Area, Summarize` |
| `Bounds3d` | `BoundingBox3D` | `get` | No | `Browsable` |
| `Cache` | `GeometryModelsCache` | `get` | No | `Browsable` |
| `Element` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider` |
| `EntityName` | `String` | `get` | No | `` |
| `HasCache3D` | `Boolean` | `get` | No | `Browsable` |
| `IsBreakable` | `Boolean` | `get` | No | `` |
| `IsProxyGraphics` | `Boolean` | `get` | No | `` |
| `IsPurged` | `Boolean` | `get` | No | `` |
| `IsSolid` | `Boolean` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `Browsable` |
| `Normal` | `Vector3D` | `get/set` | No | `Browsable` |
| `PlanDisplay` | `DwgModel3DElementPlanDisplay` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `Browsable` |
| `Scale` | `Vector3D` | `get/set` | No | `GlobalVector` |
| `SectionDisplay` | `Boolean` | `get/set` | No | `` |
| `Volume` | `Double` | `get` | No | `Area, Summarize` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginChange` | `Void` | `` | `` |
| `Downgrade` | `Void` | `` | `` |
| `EndChange` | `Void` | `` | `` |
| `Fire` | `Nullable<Double>` | `Ray3D ray` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPlan` | `DwgBlock` | `Double mapscale` | `Browsable` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `Layout` | `Void` | `IList<DwgEntity> list, LayoutEntityEventArgs e` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PARENT_SMDX` | `String` | Yes | `"SmdxElement"` | `` |
| `UPDATE_Z` | `String` | Yes | `"update_z"` | `` |

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
| `ITransformedObject` | `get_Position` |
| `ITransformedObject` | `get_Scale` |
| `ITransformedObject` | `get_Rotation` |
| `IPointObject` | `Topomatic.Cad.Foundation.IPointObject.get_BasePoint` |
| `IElevationProvider` | `GetElevation` |
| `ImElementHolder` | `get_Element` |
| `ImElementHolder` | `get_Cache` |
| `IConstructionModelHolder` | `BeginChange` |
| `IConstructionModelHolder` | `EndChange` |

### `DwgModel3DElementPlanDisplay` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.DwgModel3DElementPlanDisplay` |
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
      - `Topomatic.Visualization.Runtime.DwgModel3DElementPlanDisplay`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `k2D` | `DwgModel3DElementPlanDisplay` | Yes | `k2D` | `` |
| `k3D` | `DwgModel3DElementPlanDisplay` | Yes | `k3D` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `k2D` | `0` |
| `k3D` | `1` |

**Underlying Type**: `System.Int32`

### `DwgModel3DElementPlanDisplayConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.DwgModel3DElementPlanDisplayConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Visualization.Runtime.DwgModel3DElementPlanDisplayConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `GuidEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.GuidEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Visualization.Runtime.GuidEventArgs`

#### Constructors (1)

- `.ctor(Guid id)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Guid` | `Guid` | `get` | No | `` |

### `ICustomVisualisationNodePropertyFactory` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.ICustomVisualisationNodePropertyFactory` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDefault` | `IList<ModelPropertyItem>` | `` | `` |
| `CreateProperty` | `VisualisationNodeProperty` | `String tag, PropertyInfo property, Object instance, Object[] attributes, IList<ModelPropertyItem> items, Int32 index, Boolean readOnly` | `` |

### `ISurface` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.ISurface` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.IElevationProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSection` | `Void` | `IPolyline3D pline, IPolyline3D section` | `` |
| `GetTriangles` | `Void` | `BoundingBox2D box, List<Vector3D> positions, List<Int32> indexes` | `` |

### `ISurfaceCreator` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.ISurfaceCreator` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Object surface` | `` |

### `SingleSurfaceElevationWrapper` (class)

**Attributes**: [Obsolete(Message: `Use StateElevationWrapper instead!`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.SingleSurfaceElevationWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.Runtime.ISurface, Topomatic.Cad.Foundation.IElevationProvider, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IElevationProvider surface, Drawing situation, Nullable<BoundingBox2D> bounds)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSection` | `Void` | `IPolyline3D pline, IPolyline3D section` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |
| `GetTriangles` | `Void` | `BoundingBox2D box, List<Vector3D> positions, List<Int32> indexes` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateStateControllerWrapper` | `SingleSurfaceElevationWrapper` | `Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurface` | `CreateSection` |
| `ISurface` | `GetTriangles` |
| `IElevationProvider` | `GetElevation` |
| `ISurfaceContainer` | `get_Surface` |

### `StateControllerElevationProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.StateControllerElevationProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IElevationProvider, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(StateControllerObject owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IElevationProvider` | `GetElevation` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `StateElevationWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.StateElevationWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.Runtime.ISurface, Topomatic.Cad.Foundation.IElevationProvider, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(StateElevationProvider provider, Nullable<BoundingBox2D> bounds)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSection` | `Void` | `IPolyline3D pline, IPolyline3D section` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |
| `GetTriangles` | `Void` | `BoundingBox2D box, List<Vector3D> positions, List<Int32> indexes` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateWrapper` | `StateElevationWrapper` | `Object obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISurface` | `CreateSection` |
| `ISurface` | `GetTriangles` |
| `IElevationProvider` | `GetElevation` |
| `ISurfaceContainer` | `get_Surface` |

### `UidSurfaceElevationProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.UidSurfaceElevationProvider` |
| **Base Type** | `Topomatic.Visualization.Runtime.StateControllerElevationProvider` |
| **Implements** | `Topomatic.Cad.Foundation.IElevationProvider, Topomatic.FoundationClasses.IOwned, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Runtime.StateControllerElevationProvider`
    - `Topomatic.Visualization.Runtime.UidSurfaceElevationProvider`

#### Constructors (1)

- `.ctor(StateControllerObject owner, String modelUid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Surface` | `Surface` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IElevationProvider` | `GetElevation` |
| `ISurfaceContainer` | `get_Surface` |

### `VisualisationNodeProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.VisualisationNodeProperty` |
| **Base Type** | `Topomatic.ComponentModel.SimpleProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Visualization.Runtime.VisualisationNodeProperty`

#### Constructors (2)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes, IList<ModelPropertyItem> items, Int32 index)`
- `.ctor(PropertyInfo property, Object instance, Object[] attributes, IList<ModelPropertyItem> items, Int32 index, Boolean readOnly)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Category` | `String` | `get/set` | No | `` |
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `DisplayName` | `String` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `IsCompatablePropertysDesctiptor` | `Boolean` | `CustomProperty other` | `` |
| `SetValue` | `Void` | `Object value` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DELIMETER` | `Char` | Yes | `|` | `` |

### `VisualisationNodePropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.VisualisationNodePropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.Runtime.VisualisationNodePropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetName` | `String` | `MultiProperty property` | `` |

### `VisualizationMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.VisualizationMode` |
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
      - `Topomatic.Visualization.Runtime.VisualizationMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `InformationModel` | `VisualizationMode` | Yes | `InformationModel` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VisualizationModel` | `VisualizationMode` | Yes | `VisualizationModel` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `InformationModel` | `0` |
| `VisualizationModel` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Visualization.Runtime.Controls`

### `OpenGlPanel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Controls.OpenGlPanel` |
| **Base Type** | `Topomatic.Cad.View.Panel3d` |
| **Implements** | `System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.UnsafeNativeMethods+IOleControl, System.Windows.Forms.UnsafeNativeMethods+IOleObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods+IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods+IOleWindow, System.Windows.Forms.UnsafeNativeMethods+IViewObject, System.Windows.Forms.UnsafeNativeMethods+IViewObject2, System.Windows.Forms.UnsafeNativeMethods+IPersist, System.Windows.Forms.UnsafeNativeMethods+IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods+IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods+IPersistStorage, System.Windows.Forms.UnsafeNativeMethods+IQuickActivate, System.Windows.Forms.ISupportOleDropSource, System.Windows.Forms.IDropTarget, System.ComponentModel.ISynchronizeInvoke, System.Windows.Forms.IWin32Window, System.Windows.Forms.Layout.IArrangedElement, System.Windows.Forms.IBindableComponent, System.Windows.Forms.IKeyboardToolTip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.MarshalByRefObject`
    - `System.ComponentModel.Component`
      - `System.Windows.Forms.Control`
        - `Topomatic.Cad.View.Panel3d`
          - `Topomatic.Visualization.Runtime.Controls.OpenGlPanel`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Home` | `Matrix` | `get/set` | No | `` |
| `Model` | `GeometryModel3D` | `get/set` | No | `DesignerSerializationVisibility` |
| `World` | `Matrix` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBounds` | `BoundingBox3D` | `` | `` |
| `GoHome` | `Void` | `` | `` |
| `SolveLimmits` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Runtime.Design`

### `VisualisationNodeValuesListProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Design.VisualisationNodeValuesListProperty` |
| **Base Type** | `Topomatic.Visualization.Runtime.VisualisationNodeProperty` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.CustomProperty`
    - `Topomatic.ComponentModel.SimpleProperty`
      - `Topomatic.Visualization.Runtime.VisualisationNodeProperty`
        - `Topomatic.Visualization.Runtime.Design.VisualisationNodeValuesListProperty`

#### Constructors (1)

- `.ctor(PropertyInfo property, Object instance, Object[] attributes, IList<ModelPropertyItem> items, Int32 index, String values, String defaultValue, Boolean isEditable, Boolean readOnly)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Converter` | `PropertyTypeConverter` | `get` | No | `` |
| `Editor` | `PropertyEditor` | `get` | No | `` |
| `IsEditable` | `Boolean` | `get` | No | `` |

---
## Namespace: `Topomatic.Visualization.Runtime.Dialogs`

### `ComponentsDlg` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Dialogs.ComponentsDlg` |
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
                - `Topomatic.Visualization.Runtime.Dialogs.ComponentsDlg`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `IComponentContainer container, Object owner, List<ModelComponent> components` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Runtime.Rail`

### `RailSleeperGratingInc` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Rail.RailwayTools+RailSleeperGratingInc` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.Runtime.Rail.RailwayTools+RailSleeperGratingInc`

#### Constructors (1)

- `.ctor(Int32 sleeperType, Double l1, Double l2, Double turn1, Double turn2)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |
| `Straight` | `Boolean` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `L1` | `Double` | No | `` | `` |
| `L2` | `Double` | No | `` | `` |
| `SleeperType` | `Int32` | No | `` | `` |
| `Turn1` | `Double` | No | `` | `` |
| `Turn2` | `Double` | No | `` | `` |

### `RailwayTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Rail.RailwayTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyGeometry` | `Void` | `GeometryModel3D destination, GeometryModel3D source, Matrix transform` | `` |
| `CreateLiningModel` | `GeometryModel3D` | `` | `` |
| `CreateLiningRailSleeperGrating` | `Void` | `Matrix transform, RailSleeperGratingInc grating, Action<Matrix> createLining` | `` |
| `CreateLodStrap` | `String` | `VisualizationMap map` | `` |
| `CreateRoundRailSleeperGrating` | `String` | `VisualizationMap map, IncludeHandler defaultHandler, String name, RailSleeperGratingInc grating, Int32 curve` | `` |
| `CreateRoundRailSleeperGrating` | `GeometryModel3D` | `RailSleeperGratingInc grating, Int32 curve` | `` |
| `CreateSleeper` | `GeometryModel3D` | `Int32 sleeperType` | `` |
| `CreateStraightProfile` | `Void` | `GeometryModel3D model, RailSleeperGratingInc grating, Boolean fillside` | `` |
| `CreateStraightRailSleeperGrating` | `String` | `VisualizationMap map, IncludeHandler defaultHandler, String name, RailSleeperGratingInc grating, Int32 curve` | `` |
| `CreateStraightRailSleeperGrating` | `GeometryModel3D` | `RailSleeperGratingInc grating, Int32 curve` | `` |
| `CreateStrap` | `GeometryModel3D` | `` | `` |
| `CreatLodLining` | `String` | `VisualizationMap map` | `` |

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DISTANCE_BOTTOM_TRACK` | `Double` | Yes | `1.611` | `` |
| `ROUND_CURVE` | `Int32` | Yes | `2000` | `` |
| `SLEEPER_ELEVATION_OFFSET` | `Double` | Yes | `0.055` | `` |
| `SLEEPER_STEP` | `Int32` | Yes | `100` | `` |
| `SLEEPER_TYPE_RAIL_CONCRETE` | `Int32` | Yes | `0` | `` |
| `SLEEPER_TYPE_TURNOUT_CONCRETE` | `Int32` | Yes | `2` | `` |
| `SLEEPER_TYPE_WOOD` | `Int32` | Yes | `1` | `` |
| `STRAIGHT_CURVE` | `Int32` | Yes | `1840` | `` |
| `TRACK_CURVE_EPS` | `Double` | Yes | `0.01` | `` |
| `TRACK_JOINT_SIZE` | `Double` | Yes | `0.21` | `` |

#### Nested Types (1)

- `RailSleeperGratingInc` (struct)

---
## Namespace: `Topomatic.Visualization.Runtime.Tools`

### `ChordPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.ChordPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.ChordPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanApply` | `Boolean` | `Object obj, TypedObject tobj` | `` |
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `GetObjectDisjoiner` | `IObjectDisjoiner` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

### `SmdxAxesPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxAxesPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.SmdxAxesPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |
| `Order` | `Int32` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanApply` | `Boolean` | `Object obj, TypedObject tobj` | `` |
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `GetObjectDisjoiner` | `IObjectDisjoiner` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

### `SmdxChordPointManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxChordPointManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.SmdxChordPointManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanApply` | `Boolean` | `Object obj, TypedObject tobj` | `` |
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

### `SmdxLinearObjectPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxLinearObjectPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Runtime.Tools.SmdxManualPolylineManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Tools.CombineTypedPropertyManager`
      - `Topomatic.Visualization.Runtime.Tools.SmdxManualPolylineManager`
        - `Topomatic.Visualization.Runtime.Tools.SmdxLinearObjectPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |

### `SmdxManualPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxManualPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Tools.CombineTypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Tools.CombineTypedPropertyManager`
      - `Topomatic.Visualization.Runtime.Tools.SmdxManualPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `GetObjectDisjoiner` | `IObjectDisjoiner` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Join` | `Boolean` | `Object obj, TypedObject tobj, ImAggregates value1, ImAggregates value2, Matrix pivot1, Matrix pivot2, ref Nullable<Matrix> pivot, ref ImAggregates value` | `` |
| `Split` | `Boolean` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot, Vector3D position, ref Nullable<Matrix> pivot1, ref Nullable<Matrix> pivot2, ref ImAggregates value1, ref ImAggregates value2` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateReliefArray` | `List<Vector3D>` | `Object obj, IPolyline3D polyline, Matrix pivot` | `` |

### `SmdxOffsetLinearObjectPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxOffsetLinearObjectPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Runtime.Tools.SmdxLinearObjectPolylineManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Tools.CombineTypedPropertyManager`
      - `Topomatic.Visualization.Runtime.Tools.SmdxManualPolylineManager`
        - `Topomatic.Visualization.Runtime.Tools.SmdxLinearObjectPolylineManager`
          - `Topomatic.Visualization.Runtime.Tools.SmdxOffsetLinearObjectPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanApply` | `Boolean` | `Object obj, TypedObject tobj` | `` |

### `SmdxPointManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxPointManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.SmdxPointManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

### `SmdxPolylineManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxPolylineManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.SmdxPolylineManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

### `SmdxStationPointManager` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Runtime.Tools.SmdxStationPointManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Runtime.Tools.SmdxStationPointManager`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanApply` | `Boolean` | `Object obj, TypedObject tobj` | `` |
| `Downgrade` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |
| `DowngradeType` | `ImTypeDescriptor` | `Object obj, TypedObject tobj` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `Initialize` | `ImAggregates` | `Object obj, TypedObject tobj, TypedPropertyManager[] allowed, String title, ref Nullable<Matrix> pivot` | `` |
| `Update` | `ImAggregates` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot` | `` |

---
## Namespace: `Topomatic.Visualization.Tools`

### `VisualizationUIUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.VisualizationUIUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillComboBox` | `Void` | `ComboBox box, PropertyTypeConverter converter, IEnumerable<T> values, Predicate<T> match` | `` |
| `FillTypeObjectComboBox` | `Void` | `ComboBox box, String parentId, TypedObject selected` | `` |
| `GetComboBoxValue` | `T` | `ComboBox box` | `` |
| `GetObjectValue` | `TypedObject` | `ComboBox box` | `` |
| `GetTitle` | `String` | `TypedObject obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CreateElementsByRuleRootSettingsPath` | `String` | Yes | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 37 |
| **Classes** | 28 |
| **Interfaces** | 3 |
| **Enums** | 2 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 3 |
| **Total Methods** | 141 |
| **Total Properties** | 72 |
| **Total Fields** | 25 |
| **Total Events** | 0 |
| **Total Constructors** | 28 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


