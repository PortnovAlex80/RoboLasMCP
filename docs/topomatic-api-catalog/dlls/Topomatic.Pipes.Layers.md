# Topomatic.Pipes.Layers

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Pipes.Layers` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Pipes.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Pipes.Layers.dll` |

---
## Namespace: `Topomatic.Pipes.Layers`

### `BasisPointInfo` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.BasisPointInfo` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.BasisPointInfo`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Elevation` | `Double` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `PlanBasisName` | `String` | No | `` | `` |
| `ProfileBasisName` | `String` | No | `` | `` |
| `Station` | `String` | No | `` | `` |
| `StationBasisName` | `String` | No | `` | `` |
| `StationOffsetString` | `String` | No | `` | `` |

### `GeometryModelsCreator` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.GeometryModelsCreator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Cube` | `Void` | `Vector3dCollection positions, TrianglesCollection triangles, Double length, Double width, Double height` | `` |
| `Cylinder` | `Void` | `Vector3dCollection positions, TrianglesCollection triangles, Double baseRadius, Double topRadius, Double height, Int32 slices, Int32 stacks` | `` |
| `Icosahedron` | `Void` | `Vector3dCollection positions, TrianglesCollection triangles, Double radius` | `` |
| `PolylineBased` | `Void` | `Vector3dCollection positions, TrianglesCollection triangles, List<Vector2D> baseLine, Double baseElevation, Double height` | `` |
| `SetMeshMaterial` | `Void` | `GeometryModel3D model, MeshGeometry3D mesh, String name, Vector3F diffuse` | `` |
| `Sphere` | `Void` | `Vector3dCollection positions, TrianglesCollection triangles, Double radius` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `SphereSlices` | `Int32` | Yes | `8` | `` |
| `SphereStacks` | `Int32` | Yes | `8` | `` |

### `PipeNetworkCustomFrameLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `GetTextStandard` | `TextStandard` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PipeNetworkCustomFrameWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer, Object wrappedObject)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `Browsable` |
| `IsSelectable` | `Boolean` | `get/set` | No | `Browsable` |
| `Layer` | `PipeNetworkCustomFrameLayer` | `get` | No | `Browsable` |
| `LayerName` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `Browsable` |
| `ReadOnly` | `Boolean` | `get/set` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `Browsable` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `Browsable` |
| `WrappedObject` | `Object` | `get` | No | `Browsable` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Erase` | `Void` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `InvalidateCadView` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PipeNetworkExtendWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(PipeNetworkExtendWrapper parentWrapper)`
- `.ctor(Object wrappedObject, CadView cadView, Boolean readOnly)`

---
## Namespace: `Topomatic.Pipes.Layers.Caches`

### `CacheDictionary`2<K where class, V where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.CacheDictionary`2` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(Func<K V> createValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `V` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `K key` | `` |
| `Invalidate` | `Void` | `` | `` |

### `CacheTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.CacheTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetContourFromCompoundLines` | `List<Vector2D>` | `CompoundLine[] compoundLines` | `` |
| `GetInterpolatedPlanCompoundLine` | `CompoundLine` | `PnSegment pipe, Double startOffset, Double endOffset` | `` |
| `GetInterpolatedProfileCompoundLine` | `CompoundLine` | `PnSegment pipe, Double startOffset, Double endOffset` | `` |
| `GetItemByNameId` | `T` | `TechDuctSegmentData techDuct, T item, Boolean atStart` | `` |
| `PairCompoundLine` | `Boolean` | `ref CompoundLine source, CompoundLine other, Double maxLength, Boolean atStart, Boolean isProfile` | `` |
| `PairPlanCompoundLine` | `Boolean` | `ref CompoundLine source, CompoundLine other, Boolean atStart` | `` |
| `PairProfileCompoundLine` | `Boolean` | `ref CompoundLine source, CompoundLine other, Double maxLength, Boolean atStart` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AbsoluteMaxLength` | `Double` | Yes | `1` | `` |
| `CompoundLineConvertToPosArrayEps` | `Double` | Yes | `0.0001` | `` |
| `PipePartMaxLength` | `Double` | Yes | `0.25` | `` |

### `DrawingDataParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.DrawingDataParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(CadView cadView, TextStandard textStandard, Func<IOwned String> getNetworkName)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnnotationScale` | `Double` | `get/set` | No | `` |
| `HorizontalScale` | `Double` | `get/set` | No | `` |
| `ScreenRatio` | `Double` | `get/set` | No | `` |
| `VerticalScale` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AssignToLeaderParams` | `Void` | `ref LeaderParams lp` | `` |
| `AssignToLeaderParamsWithAnnotative` | `Void` | `PipeNetwork network, ref LeaderParams lp` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CadView` | `CadView` | No | `` | `` |
| `Font` | `CadFont` | No | `` | `` |
| `GetModelName` | `Func<IOwned String>` | No | `` | `` |
| `TextStandard` | `TextStandard` | No | `` | `` |

### `LineSurfaceCacheProfileData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.LineSurfaceCacheProfileData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LineSurfacesCache parent, IList<LineSurfacePoint> userSurface)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DynamicSurface` | `List<LineSurfacePoint>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPointsByStation` | `Void` | `Double station, ref LineSurfacePoint first, ref LineSurfacePoint second` | `` |
| `GetProfile` | `IList<LineSurfacePoint>` | `` | `` |
| `GetProfile` | `IList<LineSurfacePoint>` | `Double startStation, Double endStation` | `` |
| `TryGetElevation` | `Boolean` | `Double station, ref Double startElevation, ref Double endElevation` | `` |
| `TryGetSource` | `Boolean` | `Double station, ref String source1, ref String source2` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetElevation` | `Boolean` | `IList<LineSurfacePoint> profile, Double station, ref Double startElevation, ref Double endElevation` | `` |
| `TryGetSource` | `Boolean` | `IList<LineSurfacePoint> profile, Double station, ref String source1, ref String source2` | `` |

### `LineSurfacesCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.LineSurfacesCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine line, PnLineCrossCache crossesCache, Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrProfiles` | `List<List<LineSurfacePoint>>` | `get` | No | `` |
| `EgProfile` | `LineSurfaceCacheProfileData` | `get` | No | `` |
| `GridStations` | `List<Double>` | `get` | No | `` |
| `Line` | `PnLine` | `get` | No | `` |
| `PgProfile` | `LineSurfaceCacheProfileData` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProfile` | `IList<LineSurfacePoint>` | `IList<LineSurfacePoint> surface, Double startStation, Double endStation` | `` |
| `GetSurfacesStations` | `List<KeyValuePair<Double Boolean>>` | `` | `` |
| `InvalidateAll` | `Void` | `` | `` |
| `InvalidateCr` | `Void` | `` | `` |
| `TryGetPgThenEgProfileElevation` | `Boolean` | `Double station, ref Double firstElevation, ref Double secondElevation` | `` |

### `LineSurfacesCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.LineSurfacesCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, PipeNetwork pipeNetwork, PnLineCrossCacheDict crossesCache)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GetSurfaces` | `Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>>` | `get` | No | `` |
| `Item` | `LineSurfacesCache` | `get` | No | `` |
| `Item` | `LineSurfacesCache` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `UInt32 id` | `` |
| `ClearAll` | `Void` | `` | `` |

### `MassiveElevationsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.MassiveElevationsCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, MassiveObject massive)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BotDepth` | `Double` | `get/set` | No | `` |
| `EgElevation` | `Nullable<Double>` | `get` | No | `` |
| `Massive` | `MassiveObject` | `get` | No | `` |
| `PgElevation` | `Nullable<Double>` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `TopDepth` | `Double` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PnLineCrossCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.PnLineCrossCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine line, Func<Boolean List<PipeNetworkInfo>> getAllPipeNetworks, Func<ReferenceNodeData Object> getNodeReference)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossAtNodes` | `List<PnEiProfileCrossAtNodeKey>` | `get` | No | `` |
| `CrossAtPipes` | `List<PnEiProfileCrossAtSegmentKey>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `Obsolete` |

### `PnLineCrossCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.PnLineCrossCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<Boolean List<PipeNetworkInfo>> getPipeNetworks, Func<ReferenceNodeData Object> getNodeReference, PipeNetwork pipeNetwork)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `PnLineCrossCache` | `get` | No | `` |
| `Item` | `PnLineCrossCache` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAll` | `Void` | `` | `` |

### `ShellCacheKey` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.ShellCacheKey` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.Collections.Generic.IEqualityComparer`1[[Topomatic.Pipes.Layers.Caches.ShellCacheKey, Topomatic.Pipes.Layers, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.ShellCacheKey`

#### Constructors (1)

- `.ctor(Shell shell)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LineId` | `UInt32` | `get` | No | `` |
| `PipeIndex` | `Int32` | `get` | No | `` |
| `ShellEndSta` | `Int32` | `get` | No | `` |
| `ShellStartSta` | `Int32` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ShellCacheKey x, ShellCacheKey y` | `` |
| `GetHashCode` | `Int32` | `ShellCacheKey obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEqualityComparer`1` | `Equals` |
| `IEqualityComparer`1` | `GetHashCode` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Common`

### `SegmentAxisPlanProfileCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Common.SegmentAxisPlanProfileCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ConstructionChunk chunk)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Plan` | `LightweightPlan` | No | `` | `` |
| `Profile` | `LightweightProfile` | No | `` | `` |

### `SegmentAxisPlanProfileCacheKey` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Common.SegmentAxisPlanProfileCacheKey` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Common.SegmentAxisPlanProfileCacheKey`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndSta` | `Double` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `StartSta` | `Double` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Ditches`

### `DitchLayersCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Ditches.DitchLayersCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork, GeometryModelsCacheBuilder cacheBuilder)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `DitchLayersPlanCache` | `get` | No | `` |
| `Layer3DModelsCaches` | `IEnumerable<GeometryModelsCache>` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateAll` | `Void` | `GeometryModelsCacheBuilder models3DCacheBuilder` | `` |

### `DitchLayersPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Ditches.DitchLayersPlanCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GeometryModelsCacheBuilder cacheBuilder, ICreatableDitchLayer ditchLayer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Model3DCacheHolder` | `DitchLayersCacheHolder` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Line3d`

### `Line3dCacheTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Line3d.Line3dCacheTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateReal3dLine` | `List<Vector3D>` | `CompoundLine plan, CompoundLine profile, Double startStation, Double endStation, ref List<Int32> arcPoints` | `` |
| `GetFullLength` | `Double` | `ConstructionChunk chunk` | `` |
| `GetPlanAndProfile` | `Void` | `ConstructionChunk chunk, Double addStartSta, Double addEndSta, ref LightweightPlan plan, ref LightweightProfile profile` | `` |
| `GetPlanAndProfile` | `Void` | `PnSegment segment, Vector2D offset, ref LightweightPlan plan, ref LightweightProfile profile` | `` |
| `GetPlanAndProfile` | `Void` | `ConstructionAxis axis, Double startStation, Double endStation, ref LightweightPlan plan, ref LightweightProfile profile` | `` |
| `GetPlanAndProfile` | `Void` | `ConstructionChunk chunk, ref LightweightPlan plan, ref LightweightProfile profile` | `` |
| `GetPlanAndProfile` | `Void` | `ConstructionAxis axis, ref LightweightPlan plan, ref LightweightProfile profile` | `` |
| `GetPlanLength` | `Double` | `ConstructionChunk chunk` | `` |
| `GetSegmentReal3dLine` | `Real3dLineCacheValue` | `PnSegment segment, Real3dLineCacheKey key` | `` |

### `Real3dLineCacheKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Line3d.Real3dLineCacheKey` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D offset, Double startStation, Double endStation)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `Offset` | `Vector2D` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |

### `Real3dLineCacheValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Line3d.Real3dLineCacheValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(List<Vector3D> line, List<Int32> arkPoints)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length2D` | `Double` | `get` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ArkPoints` | `List<Int32>` | No | `` | `` |
| `Line` | `List<Vector3D>` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Models3d`

### `DitchLayersCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.DitchLayersCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.DitchLayersCacheHolder`

#### Constructors (1)

- `.ctor(GeometryModelsCacheBuilder cacheBuilder, ICreatableDitchLayer ditchLayer)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MassiveModelsCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.MassiveModelsCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.MassiveModelsCacheHolder`

#### Constructors (1)

- `.ctor(MassiveObject massive, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetModel` | `Void` | `MassiveObject massive, ref ImElement element, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ModelCacheHolder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |
| `Invalidate` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |
| `Invalidate` | `Void` | `` | `` |
| `TryGetGeometryModelsCache` | `Boolean` | `ref GeometryModelsCache cache` | `` |
| `TryGetModelAndMatrix` | `Boolean` | `ref GeometryModel3D model, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `NodeModelCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.NodeModelCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.NodeModelCacheHolder`

#### Constructors (1)

- `.ctor(PnNode node, NodeElevationsCache elevationsCache, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSphereNodeModel` | `GeometryModel3D` | `Double r` | `` |
| `GetEmptySphere` | `GeometryModel3D` | `PnNode node, ref Vector3D center` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointChunkModelPosRotation` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.Segment3DModelsBuilder+PointChunkModelPosRotation` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Models3d.Segment3DModelsBuilder+PointChunkModelPosRotation`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RotationOY` | `Double` | No | `` | `` |
| `RotationOZ` | `Double` | No | `` | `` |
| `Vertex` | `Vector3D` | No | `` | `` |

### `Segment3DModelsBuilder` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.Segment3DModelsBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCircleMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, Double size` | `` |
| `CreateDiamondMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, Double size` | `` |
| `CreateMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, ISegmentProfileContainer profileCont` | `` |
| `CreateMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, SegmentElementContainer obj` | `` |
| `CreatePipeMaterial` | `Void` | `GeometryModel3D model, MeshGeometry3D mesh` | `` |
| `CreateRectangleMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, Double size` | `` |
| `CreateShellMaterial` | `Void` | `GeometryModel3D model, MeshGeometry3D mesh` | `` |
| `GetChunkProfile` | `KeyValuePair<List<Vector3D> List<Int32>>` | `SegmentPlanCache cache, ConstructionChunk chunk` | `` |
| `GetLongModel3d` | `GeometryModel3D` | `List<Vector3D> baseProfile, List<Int32> arcPoints, ConstructionChunkLong chunk, Vector3D pivot` | `` |
| `GetPointModel3d` | `GeometryModel3D` | `List<Vector3D> baseProfile, Vector3D pivot, Double stationStep, ImElement element, Vector3D rotation, Boolean useProfileGrade` | `` |
| `GetPointModel3d` | `GeometryModel3D` | `List<Vector3D> baseProfile, List<Int32> arcPoints, ConstructionChunkPoint chunk, Vector3D pivot` | `` |
| `GetSegmentPivot` | `Vector3D` | `PnSegment segment` | `` |
| `GetShellModel3d` | `GeometryModel3D` | `List<Vector3D> baseProfile, List<Int32> arcPoints, ConstructionChunkShell chunk, Vector3D pivot` | `` |
| `СreateMesh` | `MeshGeometry3D` | `List<Vector3D> positions, List<Int32> arcPoints, Int32 slices, Vector2D[] stack` | `` |

#### Nested Types (1)

- `PointChunkModelPosRotation` (struct)

### `SegmentLongChunkCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.SegmentLongChunkCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.SegmentLongChunkCacheHolder`

#### Constructors (1)

- `.ctor(SegmentPlanCache cache, ConstructionChunkLong chunk, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentPointChunkCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.SegmentPointChunkCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.SegmentPointChunkCacheHolder`

#### Constructors (1)

- `.ctor(SegmentPlanCache cache, ConstructionChunkPoint chunk, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentShellChunkCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.SegmentShellChunkCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.SegmentShellChunkCacheHolder`

#### Constructors (1)

- `.ctor(SegmentPlanCache cache, ConstructionChunkShell chunk, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TechDuctModelsCacheHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Models3d.TechDuctModelsCacheHolder` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Models3d.ModelCacheHolder`
    - `Topomatic.Pipes.Layers.Caches.Models3d.TechDuctModelsCacheHolder`

#### Constructors (1)

- `.ctor(SegmentPlanCache cache, GeometryModelsCacheBuilder cacheBuilder)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElementAndMatrix` | `Boolean` | `ref ImElement element, ref Matrix matrix` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateTechDuctModels` | `IEnumerable<KeyValuePair<PnCrsSectionItem GeometryModel3D>>` | `PnCrsMainSection section, SegmentPlanCache cache, Vector3D pivot` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Layers.Caches.NodeElevations`

### `NodeElevationsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.NodeElevations.NodeElevationsCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, LineSurfacesCacheDict lineSurfacesCaches, Func<Object Vector2D BasisPointInfo> getBasisInfo)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisOffset` | `Double` | `get` | No | `` |
| `BasisStation` | `String` | `get` | No | `` |
| `BasisVerticalOffset` | `Double` | `get` | No | `` |
| `BotElevation` | `Double` | `get` | No | `` |
| `EgElevation` | `Nullable<Double>` | `get` | No | `` |
| `Node` | `PnNode` | `get` | No | `` |
| `PgElevation` | `Nullable<Double>` | `get` | No | `` |
| `PgThenEgElevation` | `Double` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `SegmentElevation` | `Double` | `get` | No | `` |
| `SegmentMinBotInnerElevation` | `Double` | `get` | No | `` |
| `ShaftCache` | `NodeElevationsShaftSubCache` | `get` | No | `` |
| `TopElevation` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `NodeElevationsData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.NodeElevations.NodeElevationsData` |
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
| `PgThenEgElevation` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Initialize` | `Void` | `PnNode node, LineSurfacesCacheDict surfacesCache` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BasisVerticalOffset` | `Double` | No | `` | `` |
| `BotElevation` | `Double` | No | `` | `` |
| `BotSegmentElevation` | `Dictionary<PipeCharacterPoint Double>` | No | `` | `` |
| `EgElevation` | `Nullable<Double>` | No | `` | `` |
| `PgElevation` | `Nullable<Double>` | No | `` | `` |
| `SegmentElevation` | `Double` | No | `` | `` |
| `TopElevation` | `Double` | No | `` | `` |
| `TopSegmentElevation` | `Dictionary<PipeCharacterPoint Double>` | No | `` | `` |

### `NodeElevationsShaftSubCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.NodeElevations.NodeElevationsShaftSubCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(NodeElevationsCache elevationsCache)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `KeepSurfaceSurplus` | `Boolean` | `get` | No | `` |
| `PipeSurplus` | `Double` | `get` | No | `` |
| `SectionsEps` | `Double` | `get` | No | `` |
| `ShaftDepth` | `Double` | `get` | No | `` |
| `ShaftHeight` | `Double` | `get` | No | `` |
| `SurfaceSurplus` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `RefreshCache` | `Void` | `ref NodeElevationsData data` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Plan`

### `CacheDict` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.CacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PlanLayerCacheContainer container)`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Caches` | `PlanLayerCacheContainer` | No | `` | `` |

### `NodeBlockParser` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.NodeBlockParser` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, NodeElevationsCache elevationsCache)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ParseTextString` | `String` | `String s` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcPlanAngle` | `Double` | `PnNode node, PnLine line, Int32 index` | `` |
| `GetStationStrings` | `Boolean` | `PnNode node, ref String staStr, ref String staPkStr, ref String baseLineName` | `` |
| `ParseTextString` | `String` | `PnNode node, NodeElevationsCache elevationsCache, String s` | `` |

### `PlanCrossCacheData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanCrossCacheData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String baseNetworkName, PnSegment basePipe, String crossNetworkName, PnSegment crossPipe, String distInLightPipe, String distInLightShell)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLineName` | `String` | `get/set` | No | `` |
| `BaseNetworkName` | `String` | `get/set` | No | `` |
| `CrossLineName` | `String` | `get/set` | No | `` |
| `CrossName` | `String` | `get` | No | `` |
| `CrossNetworkName` | `String` | `get/set` | No | `` |
| `CrossNetworkType` | `String` | `get/set` | No | `` |
| `CrossNetworkTypeDesignation` | `String` | `get/set` | No | `` |
| `CrossPipeNetworkDescription` | `String` | `get/set` | No | `` |
| `CrossStatus` | `String` | `get/set` | No | `` |
| `DistInLightPipe` | `String` | `get/set` | No | `` |
| `DistInLightShell` | `String` | `get/set` | No | `` |
| `Number` | `Int32` | `get/set` | No | `` |

### `PlanCrossCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanCrossCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ICrossingsContainer crossContainer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `PlanCrossCacheData` | `get` | No | `` |
| `Keys` | `IEnumerable<PnEiPlanCrossAtPipeKey>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `RefreshCache` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetDistanceInLight` | `Boolean` | `PipesCrossing cross, Boolean getWithShell, ref Double distance` | `` |
| `TryGetDistInLight` | `Boolean` | `PipesCrossing cross, ref Double distance` | `` |

### `PlanLayerCacheContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanLayerCacheContainer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network, Func<Boolean List<PipeNetworkInfo>> getPipeNetworks, Func<ReferenceNodeData Object> getNodeReference, Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, Func<Object Vector2D BasisPointInfo> getBasisInfo)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LongsWholeSceneCache` | `BlobGeometryModelsCache` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAllCaches` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DitchCaches` | `DitchLayersCacheDict` | No | `` | `` |
| `GetBasisInfo` | `Func<Object Vector2D BasisPointInfo>` | No | `` | `` |
| `GetNodeReference` | `Func<ReferenceNodeData Object>` | No | `` | `` |
| `GetPipeNetworks` | `Func<Boolean List<PipeNetworkInfo>>` | No | `` | `` |
| `GetSurfaces` | `Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>>` | No | `` | `` |
| `LineCrossCacheDict` | `PnLineCrossCacheDict` | No | `` | `` |
| `m_PipeNetwork` | `PipeNetwork` | No | `` | `` |
| `MassiveCaches` | `PlanMassiveCacheDict` | No | `` | `` |
| `NodeCaches` | `PlanNodeCacheDict` | No | `` | `` |
| `SegmentCaches` | `SegmentPlanCacheDict` | No | `` | `` |
| `SurfacesCaches` | `LineSurfacesCacheDict` | No | `` | `` |

### `PlanMassiveBlockCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanMassiveBlockCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(MassiveObject massive)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

### `PlanMassiveCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanMassiveCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PlanMassiveCacheDict cacheDict, Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, MassiveObject massive, GeometryModelsCacheBuilder cacheBuilder)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlockCache` | `PlanMassiveBlockCache` | `get` | No | `` |
| `ElevationsCache` | `MassiveElevationsCache` | `get` | No | `` |
| `MassiveObject` | `MassiveObject` | `get` | No | `` |
| `Model3DCacheHolder` | `MassiveModelsCacheHolder` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |

### `PlanMassiveCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanMassiveCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, PipeNetwork pipeNetwork, GeometryModelsCacheBuilder modelsCacheBuilder)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `PlanMassiveCache` | `get` | No | `` |
| `Item` | `PlanMassiveCache` | `get` | No | `` |
| `Layer3DModelsCaches` | `IEnumerable<GeometryModelsCache>` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

### `PlanNodeBlockCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanNodeBlockCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, NodeElevationsCache nodeElevationsCache, SegmentPlanCacheDict pipeCacheDict)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDismantle` | `List<DwgEntity>` | `Double annotationScale` | `` |
| `GetLabels` | `List<DwgEntity>` | `Double currentScale, Double annotationScale, TextStandard pipeTextStandard` | `` |
| `GetLabelsForScheme` | `List<DwgEntity>` | `Double currentScale, Double annotationScale, TextStandard pipeTextStandard` | `` |
| `GetRegulars` | `List<DwgEntity>` | `Double annotationScale, TextStandard pipeTextStandard` | `` |
| `GetSchemeEntities` | `List<DwgEntity>` | `Double currentScale, Double annotationScale, TextStandard pipeTextStandard` | `` |
| `Invalidate` | `Void` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DrawPlanAngle` | `Boolean` | No | `` | `` |
| `SchemeElevation` | `LabelParams` | Yes | `` | `` |

### `PlanNodeCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanNodeCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, LineSurfacesCacheDict surfacesDictCache, Func<Object Vector2D BasisPointInfo> getBasisInfo, SegmentPlanCacheDict planPipeCacheDict, GeometryModelsCacheBuilder cacheBuilder)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlockCache` | `PlanNodeBlockCache` | `get` | No | `` |
| `ElevationsCache` | `NodeElevationsCache` | `get` | No | `` |
| `Models3DCacheHolder` | `NodeModelCacheHolder` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |

### `PlanNodeCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanNodeCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork pipeNetwork, LineSurfacesCacheDict lineSurfacesDict, SegmentPlanCacheDict pipeCacheDict, Func<Object Vector2D BasisPointInfo> getBasisInfo, GeometryModelsCacheBuilder cacheBuilder)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `PlanNodeCache` | `get` | No | `` |
| `Item` | `PlanNodeCache` | `get` | No | `` |
| `Layer3DModelsCaches` | `IEnumerable<GeometryModelsCache>` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateAll` | `Void` | `GeometryModelsCacheBuilder models3DCacheBuilder` | `` |
| `InvalidateBlocksByLine` | `Void` | `PnLine line` | `` |

### `PlanPipeLeaderParamsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanPipeLeaderParamsCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnSegment pipe, Int32 indexVertex)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

### `PlanPipeLeaderParamsCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanPipeLeaderParamsCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnSegment pipe)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `PlanPipeLeaderParamsCache` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAll` | `Void` | `` | `` |

### `PlanRailContactNetworkCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.PlanRailContactNetworkCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SegmentPlanCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.SegmentPlanCacheDict` |
| **Base Type** | `Topomatic.Pipes.Layers.Caches.Plan.CacheDict` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Caches.Plan.CacheDict`
    - `Topomatic.Pipes.Layers.Caches.Plan.SegmentPlanCacheDict`

#### Constructors (1)

- `.ctor(PlanLayerCacheContainer container, GeometryModelsCacheBuilder modelsCacheBuilder)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `SegmentPlanCache` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearLine` | `Void` | `PnLine line` | `` |
| `ClearSegment` | `Void` | `PnSegment segment` | `` |
| `GetLongCache` | `LongChunkPlanCache` | `ConstructionChunkLong chunk` | `` |
| `GetPlanProfile` | `SegmentAxisPlanProfileCache` | `ConstructionChunk chunk` | `` |
| `GetShellCache` | `ShellChunkPlanCache` | `ConstructionChunkShell chunk` | `` |
| `InvalidateAll` | `Void` | `GeometryModelsCacheBuilder models3DCacheBuilder` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Plan.Segments`

### `ArrowData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.SegmentPlanCache+DrawingData+ArrowData` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D midPos, Vector2D direction, Boolean isLine, Double annotationScale)`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bounds` | `BoundingBox2D` | No | `` | `` |
| `End` | `Vector2D` | No | `` | `` |
| `LeftBot` | `Vector2D` | No | `` | `` |
| `RightBot` | `Vector2D` | No | `` | `` |
| `Top` | `Vector2D` | No | `` | `` |

### `AxisPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.AxisPlanCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SegmentPlanCache segmentCache, ConstructionAxis axis)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LongCaches` | `CacheDictionary<UInt32 LongChunkPlanCache>` | No | `` | `` |
| `PlanProfileCaches` | `CacheDictionary<ConstructionChunk SegmentAxisPlanProfileCache>` | No | `` | `` |
| `PointCaches` | `CacheDictionary<UInt32 PointChunkPlanCache>` | No | `` | `` |
| `ShellCaches` | `CacheDictionary<UInt32 ShellChunkPlanCache>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `BorderData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.SegmentPlanCache+DrawingData+BorderData` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Alpha` | `Int32` | No | `` | `` |
| `Color` | `CadColor` | No | `` | `` |
| `Strip` | `Vector2F[]` | No | `` | `` |

### `DrawingData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.SegmentPlanCache+DrawingData` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndEntities` | `List<DwgEntity>` | `get` | No | `` |
| `EndEntitiesMaxHeight` | `Double` | `get` | No | `` |
| `StartEntities` | `List<DwgEntity>` | `get` | No | `` |
| `StartEntitiesMaxHeight` | `Double` | `get` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arrow` | `ArrowData` | No | `` | `` |
| `PipeSchemePipeLeaderParams` | `LeaderParams` | No | `` | `` |

#### Nested Types (2)

- `ArrowData` (class)
- `BorderData` (class)

### `LongChunkPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.LongChunkPlanCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AxisPlanCache axisCache, ConstructionChunkLong chunk)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LongChunk` | `ConstructionChunkLong` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CachedPlanLength` | `Double` | No | `` | `` |
| `Model3DCacheHolder` | `SegmentLongChunkCacheHolder` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `PointChunkPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.PointChunkPlanCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AxisPlanCache axisCache, ConstructionChunkPoint chunk)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Model3DCacheHolder` | `SegmentPointChunkCacheHolder` | No | `` | `` |
| `PointChunk` | `ConstructionChunkPoint` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `SegmentPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.SegmentPlanCache` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SegmentPlanCacheDict dict, PnSegment segment, GeometryModelsCacheBuilder cacheBuilder)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeometryModelsCacheBuilder` | `GeometryModelsCacheBuilder` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |
| `TechDuctCacheHolder` | `TechDuctModelsCacheHolder` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetReal3DLine` | `Real3dLineCacheValue` | `Real3dLineCacheKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AxisCaches` | `CacheDictionary<UInt32 AxisPlanCache>` | No | `` | `` |

#### Nested Types (1)

- `DrawingData` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `
` | `get_GeometryModelsCacheBuilder` |

### `ShellChunkPlanCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Plan.Segments.ShellChunkPlanCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AxisPlanCache axisCache, ConstructionChunkShell chunk)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `ShellChunk` | `ConstructionChunkShell` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDrawingData` | `ShellChunkPlanDrawingData` | `DrawingDataParams drawingDataParams, Boolean calcShellLp, Boolean calcStationingLp` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CachedPlanLength` | `Double` | No | `` | `` |
| `Model3DCacheHolder` | `SegmentShellChunkCacheHolder` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Profile`

### `ControlPipeData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileShellCache+DrawingData+ControlPipeData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Profile.ProfileShellCache+DrawingData+ControlPipeData`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ShellBotPos` | `Vector2D` | No | `` | `` |
| `ShellTopPos` | `Vector2D` | No | `` | `` |
| `TopPos` | `Vector2D` | No | `` | `` |

### `DrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileShellCache+DrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Profile.ProfileShellCache+DrawingData`

#### Constructors (1)

- `.ctor(CadView cadView, LineSurfacesCache sfcCache, Shell shell, TextStandard textStandard, Vector2D leaderOffset, Double lineProfileStation)`

#### Fields (15)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInnerLine` | `Polyline3D` | No | `` | `` |
| `BotOuterLine` | `Polyline3D` | No | `` | `` |
| `ControlPipes` | `List<ControlPipeData>` | No | `` | `` |
| `Hatch` | `DwgHatch` | No | `` | `` |
| `LeftOuterBot` | `Vector2D` | No | `` | `` |
| `LeftOuterTop` | `Vector2D` | No | `` | `` |
| `LeftPipeBot` | `Vector2D` | No | `` | `` |
| `LeftPipeTop` | `Vector2D` | No | `` | `` |
| `PatternAngle` | `Double` | No | `` | `` |
| `RightOuterBot` | `Vector2D` | No | `` | `` |
| `RightOuterTop` | `Vector2D` | No | `` | `` |
| `RightPipeBot` | `Vector2D` | No | `` | `` |
| `RightPipeTop` | `Vector2D` | No | `` | `` |
| `TopInnerLine` | `Polyline3D` | No | `` | `` |
| `TopOuterLine` | `Polyline3D` | No | `` | `` |

#### Nested Types (1)

- `ControlPipeData` (struct)

### `ProfileElementNodeCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileElementNodeCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileNodeCacheKey key)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LeftSegments` | `List<Vector2D>` | `get` | No | `` |
| `RightSegments` | `List<Vector2D>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `Refresh` | `Void` | `` | `` |

### `ProfileNetworkCaches` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNetworkCaches` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary dictionary, PipeNetwork pipeNetwork)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GetBasisInfo` | `Func<Object Vector2D BasisPointInfo>` | `get` | No | `` |
| `GetSurfaces` | `Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>>` | `get` | No | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Dictionary` | `ProfileNetworkCachesDictionary` | No | `` | `` |
| `GetPipeNetworks` | `Func<List<KeyValuePair<String PipeNetwork>>>` | No | `` | `` |
| `LineCrossCacheDict` | `PnLineCrossCacheDict` | No | `` | `` |
| `NodeCacheDict` | `ProfileNodeCacheDict` | No | `` | `` |
| `SurfacesCacheDict` | `LineSurfacesCacheDict` | No | `` | `` |

### `ProfileNetworkCachesDictionary` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNetworkCachesDictionary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<Boolean List<PipeNetworkInfo>> getPipeNetworks, Func<ReferenceNodeData Object> getNodeReference, Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, Func<Object Vector2D BasisPointInfo> getBasisInfo)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `ProfileNetworkCaches` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `GetBasisInfo` | `Func<Object Vector2D BasisPointInfo>` | No | `` | `` |
| `GetNodeReference` | `Func<ReferenceNodeData Object>` | No | `` | `` |
| `GetPipeNetworks` | `Func<Boolean List<PipeNetworkInfo>>` | No | `` | `` |
| `GetSurfaces` | `Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>>` | No | `` | `` |

### `ProfileNodeBlockCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNodeBlockCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, NodeElevationsCache elevationsCache)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawDepthHeader` | `Boolean` | `CadView cadView` | `` |
| `DrawDepthHeaderExtended` | `Boolean` | `CadView cadView` | `` |
| `DrawTemplateMarkHeader` | `Boolean` | `CadView cadView` | `` |
| `Invalidate` | `Void` | `` | `` |
| `OrdinateBlock` | `List<DwgEntity>` | `CadView cadView` | `` |

### `ProfileNodeCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNodeCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Func<PipeNetwork IList<String> List<KeyValuePair<String Surface>>> getSurfaces, PnLine line, Int32 nodeIndex, LineSurfacesCacheDict surfacesDictCache, PnNode referenceNode, NodeElevationsCache refNodeElevationsCache)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FullStation` | `Double` | `get` | No | `` |
| `Line` | `PnLine` | `get` | No | `` |
| `Node` | `PnNode` | `get` | No | `` |
| `NodeIndex` | `Int32` | `get` | No | `` |
| `NodeStation` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BlockCache` | `ProfileNodeBlockCache` | No | `` | `` |
| `ElementCache` | `ProfileElementNodeCache` | No | `` | `` |
| `ElevationsCache` | `NodeElevationsCache` | No | `` | `` |
| `SurfacesCaches` | `LineSurfacesCacheDict` | No | `` | `` |

### `ProfileNodeCacheDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNodeCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileNetworkCaches caches, PipeNetwork pipeNetwork)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `ProfileNodeCache` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `UInt32 nodeId` | `` |
| `ClearAll` | `Void` | `` | `` |
| `ClearLine` | `Void` | `PnLine line` | `` |

### `ProfileNodeCacheKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileNodeCacheKey` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine line, Int32 nodeIndex)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Line` | `PnLine` | `get` | No | `` |
| `NodeIndex` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

### `ProfileShellCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ProfileShellCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Shell shell)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `Shell` | `Shell` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `DrawingData` | `TextStandard textStandart, CadView cadView, LineSurfacesCache sfcCache` | `` |
| `Invalidate` | `Void` | `` | `` |
| `OrdinateBlock` | `List<DwgEntity>` | `TextStandard textStandart, CadView cadView, LineSurfacesCache sfcCache` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLeaderParams` | `LeaderParams` | `Shell shell, Vector2D leaderOffset, Boolean useProfileStation` | `` |
| `GetLeaderParams` | `LeaderParams` | `CadView cadView, TextStandard textStandard, Shell shell` | `` |

#### Nested Types (1)

- `DrawingData` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `ShellChunkProfileCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.ShellChunkProfileCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AxisProfileCache axisCache, ConstructionChunkShell chunk)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawingDataParams` | `DrawingDataParams` | `get` | No | `` |
| `OrdinateBlock` | `List<DwgEntity>` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `SfcCache` | `LineSurfacesCache` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `ShellChunkDrawingData` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

---
## Namespace: `Topomatic.Pipes.Layers.Caches.Profile.Segments`

### `AxisProfileCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.AxisProfileCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SegmentProfileCache segmentCache, ConstructionAxis axis)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LongCaches` | `CacheDictionary<UInt32 LongChunkProfileCache>` | No | `` | `` |
| `PlanProfileCaches` | `CacheDictionary<ConstructionChunk SegmentAxisPlanProfileCache>` | No | `` | `` |
| `ShellCaches` | `CacheDictionary<UInt32 ShellChunkProfileCache>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `DrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCache+DrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCache+DrawingData`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeterminationType` | `DeterminationType` | No | `` | `` |
| `DismantleCrosses` | `List<Vector2D[]>` | No | `` | `` |
| `DrawTechDuctAxis` | `Boolean` | No | `` | `` |
| `HydraulicsData` | `OutputData` | No | `` | `` |
| `PipeProfiles` | `List<PipeProfile>` | No | `` | `` |
| `TechDuct` | `TechDuctSegmentData` | No | `` | `` |
| `TechDuctFarms` | `List<List<Vector2D>>` | No | `` | `` |

#### Nested Types (1)

- `PipeProfile` (struct)

### `LongChunkProfileCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.LongChunkProfileCache` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(AxisProfileCache axisCache, ConstructionChunkLong chunk)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawingDataParams` | `DrawingDataParams` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `LongChunkDrawingData` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `PipeProfile` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCache+DrawingData+PipeProfile` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCache+DrawingData+PipeProfile`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInnerLine` | `Polyline3D` | No | `` | `` |
| `BotOuterLine` | `Polyline3D` | No | `` | `` |
| `Hatch` | `DwgHatch` | No | `` | `` |
| `LeftInnerBot` | `Vector2D` | No | `` | `` |
| `MiddleLine` | `Polyline3D` | No | `` | `` |
| `RightInnerBot` | `Vector2D` | No | `` | `` |
| `TopInnerLine` | `Polyline3D` | No | `` | `` |
| `TopOuterLine` | `Polyline3D` | No | `` | `` |
| `WaterLine` | `Polyline3D` | No | `` | `` |

### `SegmentProfileCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnSegment segment, DrawingDataParams drawingDataParams, LineSurfacesCache sfcCache, ProfileNodeCacheDict nodeCaches)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DrawingDataParams` | `DrawingDataParams` | `get/set` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `DrawingData` | `DrawingDataParams drawingDataParams` | `` |
| `GetElevation` | `Nullable<KeyValuePair<Double Double>>` | `Double station, PipeCharacterPoint cp` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `Int32 nodeIndex` | `` |
| `GetPlanProfile` | `SegmentAxisPlanProfileCache` | `ConstructionChunk chunk` | `` |
| `GetSegment` | `PnSegment` | `` | `` |
| `Invalidate` | `Void` | `DrawingDataParams drawingDataParams` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AxisCaches` | `CacheDictionary<UInt32 AxisProfileCache>` | No | `` | `` |

#### Nested Types (1)

- `DrawingData` (struct)

### `SegmentProfileCacheDict` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Caches.Profile.Segments.SegmentProfileCacheDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary caches)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearLine` | `Void` | `UInt32 lineId` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `String networkId, CadView cadView, PnSegment segment, Int32 index` | `` |
| `GetSegmentCache` | `SegmentProfileCache` | `String networkId, PnSegment segment, DrawingDataParams drawingDataParams` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Common`

### `CadViewParams` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.CommonDrawer+CadViewParams` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Common.CommonDrawer+CadViewParams`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AnnotationScale` | `Double` | No | `` | `` |
| `ScreenRatio` | `Double` | No | `` | `` |

### `ColorLinetypeExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.ColorLinetypeExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.ColorLinetypeExtendWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, Object obj)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `Layer` | `ILayer` | `get` | No | `Browsable` |
| `LayerName` | `String` | `get` | No | `` |
| `Linetype` | `DwgLinetype` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `LinetypeScale` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `Lineweight` | `Lineweight` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |

### `CommonDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.CommonDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawRuler` | `Void` | `DwgStyle tagStyle, Double horizontalScale, Double verticalScale, PipeNetwork pipeNetwork, Double min, Double max, Double vertOffs, ref List<DwgEntity> list` | `` |
| `DrawText` | `Void` | `CadPen pen, TextStandard standard, Double height, Double ratio, Double oblique, Double annotationScale, Double screenRatio, String text, Vector2D pos, Double angle, TextJustify tj, Boolean mask` | `` |
| `DrawText` | `Void` | `CadPen pen, TextStandard textStandard, CadViewParams cadViewParams, TextParams textParams` | `` |
| `DrawText` | `Void` | `CadPen pen, TextStandard standard, Double annotationScale, Double screenRatio, String text, Vector2D pos, Double angle, TextJustify tj, Boolean mask` | `` |
| `GenerateDwgText` | `DwgText` | `DwgStyle style, String content, Vector2D pos, Double rotation, TextJustify tj` | `` |
| `GenerateDwgText` | `DwgMText` | `DwgStyle style, String content, Vector2D pos, Double rotation, TextJustify tj, Boolean mask` | `` |
| `GenerateDwgText` | `DwgMText` | `DwgStyle style, String content, Vector2D pos, TextJustify tj, Boolean mask` | `` |
| `GenerateDwgText` | `DwgText` | `Drawing drawing, TextStandard textStd, Double scale, String content, Vector2D pos, Double rotation, TextJustify tj, CadColor color` | `` |
| `GenerateDwgText` | `DwgMText` | `Drawing drawing, TextStandard textStd, Double scale, String s, Vector2D pos, Double rotation, TextJustify tj, Boolean mask, CadColor color` | `` |
| `GenerateDwgText` | `DwgMText` | `Drawing drawing, TextStandard textStandard, Double scale, TextParams textParams, CadColor color` | `` |
| `GenerateDwgText` | `DwgText` | `DwgStyle style, String content, Vector2D pos, TextJustify tj` | `` |
| `GetLayer` | `PipeNetworkCustomFrameLayer` | `CadView cadview, Guid guid, Boolean readOnly` | `` |
| `GetLayer` | `PipeNetworkCustomFrameLayer` | `CadView cadview, Guid guid` | `` |
| `LeaderTextIsEmpty` | `Boolean` | `LeaderParams leader` | `` |
| `LeaderTextNotEmpty` | `Boolean` | `LeaderParams leader` | `` |
| `SkipText` | `Boolean` | `Double scale, Double height` | `` |
| `TextAlignment` | `TextAlignment` | `TextJustify tj` | `` |
| `TextAttachment` | `AttachmentPoint` | `TextJustify tj` | `` |

#### Nested Types (2)

- `CadViewParams` (struct)
- `TextParams` (struct)

### `DisplaySettingsExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.DisplaySettingsExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.DisplaySettingsExtendWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FlipText` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `HideLeader` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `LeaderAngle` | `Double` | `get/set` | No | `Angle, ConditionalReadOnly` |
| `nShowOnProfileCrossing` | `Boolean` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |
| `ShowOnPlan` | `Boolean` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `ShowOnProfile` | `Boolean` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |

### `IMassiveObjectWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.IMassiveObjectWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Massive` | `MassiveObject` | `get` | No | `` |

### `INodeWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.INodeWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |
| `Node` | `PnNode` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateCadView` | `Void` | `` | `` |

### `ISegmentConstructionAxisContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.ISegmentConstructionAxisContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `ConstructionAxis` | `get` | No | `` |

### `ISegmentWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.ISegmentWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `` |

### `IShellWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.IShellWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Shell` | `Shell` | `get` | No | `` |

### `PnEiPipeWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.ISegmentWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsWrapper`
    - `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, ConstructionChunk chunk, EditableItemsController controller, EditableItemsKey key)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `Browsable` |
| `ChunkExtendWrapper` | `ConstructionChunkExtendWrapper` | `get` | No | `PropertyProvider` |
| `DisplaySettingsWrapper` | `DisplaySettingsExtendWrapper` | `get` | No | `PropertyProvider` |
| `LayerName` | `String` | `get` | No | `` |
| `ParametersByCatalogue` | `ParametersByCatalogueWrapper` | `get` | No | `PropertyProvider` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `Browsable` |
| `PipeNetworkName` | `String` | `get` | No | `` |
| `ProfileColor` | `CadColor` | `get/set` | No | `ConditionalReadOnly` |
| `ProfileUserValuesWrapper` | `ProfileUserValuesExtendWrapper` | `get` | No | `PropertyProvider` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `StationsExtendWrapper` | `StationsExtendWrapper` | `get` | No | `PropertyProvider` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `InvalidateCadView` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |
| `ISegmentWrapper` | `get_Segment` |
| `ISegmentWrapper` | `get_CadView` |

### `TextParams` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.CommonDrawer+TextParams` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Common.CommonDrawer+TextParams`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Mask` | `Boolean` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `Rotation` | `Double` | No | `` | `` |
| `Text` | `String` | No | `` | `` |
| `TextJustify` | `TextJustify` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Common.LayerProps`

### `PenStateHolder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.LayerProps.PenStateHolder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadPen pen)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PopPenState` | `Void` | `` | `` |
| `PushPenState` | `Void` | `PipeNetworkItem item, DwgLayer layer, Boolean enabled` | `` |
| `PushPenState` | `Void` | `PlanWrapper wrapper, DwgLayer layer` | `` |
| `ResetDcParams` | `Void` | `` | `` |
| `SetDсParams` | `Void` | `PlanWrapper wrapper, DwgLayer layer` | `` |
| `StoreDcParams` | `Void` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Pen` | `CadPen` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Common.Nodes`

### `AlignmentCrossExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.AlignmentCrossExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.AlignmentCrossExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossId` | `String` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, ConditionalReadOnly` |

### `MassiveConnectionExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.MassiveConnectionExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.MassiveConnectionExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ConnectionName` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor, PropertyTypeConverter` |
| `LinkElevation` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |

### `NodeDataIncutExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.NodeDataIncutExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.NodeDataIncutExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BotElevation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Diameter` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `MidElevation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `TopElevation` | `String` | `get/set` | No | `ConditionalReadOnly` |

### `NodeElevationExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.NodeElevationExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.NodeElevationExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisVerticalOffset` | `String` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly, PropertyUpdateSequence` |
| `BottomElevation` | `String` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly, PropertyUpdateSequence` |
| `BySegmentCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, ConditionalBrowsable, ConditionalReadOnly` |
| `FixType` | `SimpleBaseElevationType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, ConditionalReadOnly` |
| `NodeBySegmentSelector` | `NodeBySegmentSelector` | `get/set` | No | `ConditionalBrowsable, PropertyUpdateSequence, PropertyTypeConverter, ConditionalReadOnly` |
| `SurfaceDepth` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly, ConditionalBrowsable` |
| `SurfaceSurplus` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalBrowsable, ConditionalReadOnly` |

### `NodeExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.NodeExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.NodeExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, Boolean readOnly, NodeElevationsCache elevationsCache)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AlignmentCrossExtendWrapper` | `AlignmentCrossExtendWrapper` | `get` | No | `PropertyProvider, ConditionalBrowsable` |
| `BasisStation` | `String` | `get` | No | `` |
| `ConnectedLines` | `String` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `IncutExtendWrapper` | `NodeDataIncutExtendWrapper` | `get` | No | `ConditionalBrowsable, PropertyProvider` |
| `LineStations` | `String` | `get` | No | `` |
| `MassiveConnectionExtendWrapper` | `MassiveConnectionExtendWrapper` | `get` | No | `ConditionalBrowsable, PropertyProvider` |
| `Name` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `NodeElevationExtendWrapper` | `NodeElevationExtendWrapper` | `get` | No | `PropertyProvider, ConditionalBrowsable` |
| `NodePlanSign` | `String` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `NodePlanSignLabel` | `String` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `NodeProfileBotSign` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor` |
| `NodeSimplifiedPlanSign` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor` |
| `NodeType` | `String` | `get` | No | `` |
| `NodeTypeName` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider, PropertyUpdateSequence, ConditionalReadOnly` |
| `ParamsThroughNode` | `NodeParamsThroughTypeEnum` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter` |
| `PlanThroughNode` | `NodePlanThroughTypeEnum` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter` |
| `ProfileThroughNode` | `NodeProfileThroughTypeEnum` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `RcwSupportExtendWrapper` | `RailContactWireSupportExtendWrapper` | `get` | No | `ConditionalBrowsable, PropertyProvider` |
| `ReferenceExtendWrapper` | `ReferenceExtendWrapper` | `get` | No | `ConditionalBrowsable, PropertyProvider` |
| `ShaftExtendWrapper` | `ShaftExtendWrapper` | `get` | No | `PropertyProvider, ConditionalBrowsable` |
| `TemplateMark` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLinesAndStations` | `List<KeyValuePair<String String>>` | `PnNode node` | `` |
| `GetLinesNames` | `String` | `List<KeyValuePair<String String>> list` | `` |
| `GetLinesStations` | `String` | `List<KeyValuePair<String String>> list` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ShowAlignmentCrossDataName` | `String` | Yes | `"ShowAlignmentCrossData"` | `` |
| `ShowReferenceDataName` | `String` | Yes | `"ShowReferenceData"` | `` |

### `RailContactWireSupportExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.RailContactWireSupportExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.RailContactWireSupportExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisRelativeElevation` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `FoundationSize` | `String` | `get` | No | `ConditionalReadOnly` |
| `IsFixed` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `Material` | `String` | `get` | No | `ConditionalReadOnly` |
| `Offset` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `SupportType` | `String` | `get` | No | `ConditionalReadOnly` |
| `Zigzag` | `RailContactWireSupportZigzagType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `ZigzagOffset` | `String` | `get/set` | No | `ConditionalReadOnly` |

### `ReferenceExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.ReferenceExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.ReferenceExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Reference` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter, PropertyEditor` |
| `UseReferenceElevation` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |

### `ShaftExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Nodes.ShaftExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Nodes.ShaftExtendWrapper`

#### Constructors (1)

- `.ctor(NodeExtendWrapper nodeExtendWrapper)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `CurrentSectionIndex` | `Int32` | `get/set` | No | `PropertyUpdateSequence, PropertyEditor` |
| `CurrentSectionName` | `String` | `get` | No | `` |
| `CurrentSectionPosition` | `Vector2D` | `get/set` | No | `` |
| `CurrentSectionRotation` | `Double` | `get/set` | No | `Angle` |
| `Diameter` | `Double` | `get` | No | `ConditionalBrowsable` |
| `Length` | `Double` | `get` | No | `ConditionalBrowsable` |
| `Profile` | `SectionProfileType` | `get` | No | `PropertyTypeConverter` |
| `ShaftBottomElevation` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `ShaftBottomElevationFixType` | `ShaftBotElevationType` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter, PropertyUpdateSequence` |
| `ShaftDepth` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `ShaftKeepSurfaceSurplus` | `TopElevationType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `ShaftPipeSurplus` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `ShaftSectionsEps` | `Double` | `get` | No | `ConditionalReadOnly` |
| `ShaftSurfaceSurplus` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `ShaftTopElevation` | `String` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `Width` | `Double` | `get` | No | `ConditionalBrowsable` |

---
## Namespace: `Topomatic.Pipes.Layers.Common.Segments`

### `DataSegmentExtendWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, Boolean readOnly, Object wrappedObject)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

### `PipeSegmentExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.PipeSegmentExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper`
      - `Topomatic.Pipes.Layers.Common.Segments.PipeSegmentExtendWrapper`

#### Constructors (1)

- `.ctor(PipeSegmentData pipe, CadView cadView, Boolean readOnly)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter` |
| `Foundation` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyProvider` |
| `FoundationDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `GnbPipeDirection` | `GnbPipeDirection` | `get/set` | No | `PropertyTypeConverter, ConditionalBrowsable, ConditionalReadOnly` |
| `Isolation` | `String` | `get/set` | No | `PropertyProvider, ConditionalReadOnly` |
| `SelectedPipeCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyUpdateSequence` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

### `RailCnExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.RailCnExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper`
      - `Topomatic.Pipes.Layers.Common.Segments.RailCnExtendWrapper`

#### Constructors (1)

- `.ctor(Alignment basisAlg, PnSegment segment, CadView cadView, Boolean readOnly)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RcnLength` | `String` | `get/set` | No | `ConditionalReadOnly` |

### `SegmentCaches` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentExtendWrapper+SegmentCaches` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentExtendWrapper+SegmentCaches`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndNodeCache` | `NodeElevationsCache` | No | `` | `` |
| `StartNodeCache` | `NodeElevationsCache` | No | `` | `` |
| `SurfacesCache` | `LineSurfacesCache` | No | `` | `` |

### `SegmentExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, SegmentCaches caches, PnSegment segment, Boolean readOnly)`

#### Properties (28)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackwardGrade` | `String` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `DataExtendWrapper` | `DataSegmentExtendWrapper` | `get` | No | `PropertyProvider` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `EndEgDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `EndElevation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `EndNodeConnection` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor` |
| `EndPgDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Grade` | `String` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |
| `LineName` | `String` | `get` | No | `` |
| `PipeDataElement` | `ImElement` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly, ConditionalBrowsable, ImObjectPropertyProvider` |
| `PipeEndNodeName` | `String` | `get` | No | `ConditionalReadOnly` |
| `PipeStartNodeName` | `String` | `get` | No | `ConditionalReadOnly` |
| `PlanBentCount` | `Int32` | `get` | No | `ConditionalBrowsable` |
| `PlanName` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `ProfileBentCount` | `Int32` | `get` | No | `ConditionalBrowsable` |
| `RailCnExtendWrapper` | `RailCnExtendWrapper` | `get` | No | `PropertyProvider, ConditionalBrowsable` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `SegmentLayout` | `SegmentLayoutType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `StartEgDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `StartElevation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `StartNodeConnection` | `String` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `StartPgDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `SteelMark` | `String` | `get/set` | No | `PropertyProvider, ConditionalReadOnly, PropertyUpdateSequence, ConditionalBrowsable` |
| `TechDuctDataElement` | `ImElement` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence, ConditionalBrowsable, ImObjectPropertyProvider` |
| `TemplateMark` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `TypePipeBent` | `String` | `get` | No | `` |
| `WireDataElement` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider, ConditionalReadOnly, PropertyUpdateSequence, ConditionalBrowsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |

#### Nested Types (1)

- `SegmentCaches` (struct)

### `TechDuctSegmentExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.TechDuctSegmentExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper`
      - `Topomatic.Pipes.Layers.Common.Segments.TechDuctSegmentExtendWrapper`

#### Constructors (1)

- `.ctor(TechDuctSegmentData techDuct, CadView cadView, Boolean readOnly)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndCrossSectionName` | `String` | `get/set` | No | `PropertyEditor, ConditionalReadOnly, PropertyTypeConverter` |
| `StartCrossSectionName` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor, PropertyTypeConverter` |

### `WireSegmentExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.WireSegmentExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.DataSegmentExtendWrapper`
      - `Topomatic.Pipes.Layers.Common.Segments.WireSegmentExtendWrapper`

#### Constructors (1)

- `.ctor(WireSegmentData wire, CadView cadView, Boolean readOnly)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EarthWorkType` | `PipeEarthWorkType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `SelectedPipeCharacterPoint` | `PipeCharacterPoint` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter, ConditionalReadOnly` |
| `WireSagType` | `WireSagType` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, ConditionalReadOnly` |
| `WireSagValue` | `String` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |

---
## Namespace: `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction`

### `ConstructionChunkExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ConstructionChunkExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ConstructionChunkExtendWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `ConstructionAxis` | `get` | No | `Browsable` |
| `DeterminationType` | `DeterminationType` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter` |
| `Line` | `PnLine` | `get` | No | `Browsable` |
| `LineName` | `String` | `get` | No | `` |
| `PlanName` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `SegmentName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `EqualsChunk` | `Boolean` | `ConstructionChunk other` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `ParametersByCatalogueWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ParametersByCatalogueWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ParametersByCatalogueWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly, Boolean pipeOnly)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get/set` | No | `Browsable` |
| `PipeElement` | `ImElement` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly, ImObjectPropertyProvider, ConditionalBrowsable` |
| `TechDuctElement` | `ImElement` | `get/set` | No | `ImObjectPropertyProvider, ConditionalReadOnly, ConditionalBrowsable, PropertyUpdateSequence` |
| `WireElement` | `ImElement` | `get/set` | No | `PropertyUpdateSequence, ConditionalBrowsable, ImObjectPropertyProvider, ConditionalReadOnly` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider` |

### `ProfileUserValuesExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ProfileUserValuesExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ProfileUserValuesExtendWrapper`

#### Constructors (1)

- `.ctor(ProfileUserDefinedValuesContainer profileValues, CadView cadView, Boolean readOnly)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `UserHeight` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `UserInnerDiameter` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `UserOuterDiameter` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `UserThickness` | `Double` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |
| `UserWidth` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `UserWireDiameter` | `Double` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |

### `StationsExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.StationsExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.StationsExtendWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndStation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `EndStationType` | `SegmentStationType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `StartStation` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `StartStationType` | `SegmentStationType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |

---
## Namespace: `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk`

### `ControlPipesSignsWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ControlPipesSignsWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ControlPipesSignsWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ControlPipePlanSignName` | `String` | `get/set` | No | `ConditionalBrowsable, PropertyEditor, ConditionalReadOnly` |
| `ControlPipeProfileBotSignName` | `String` | `get/set` | No | `PropertyEditor, ConditionalBrowsable, ConditionalReadOnly` |
| `ControlPipeSimplifiedPlanSignName` | `String` | `get/set` | No | `ConditionalBrowsable, PropertyEditor, ConditionalReadOnly` |

### `ControlPipesWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ControlPipesWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ControlPipesWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ControlPipeCount` | `ShellControlPipeCount` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyUpdateSequence` |
| `EndControlPipeOffset` | `String` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |
| `StartControlPipeOffset` | `String` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |
| `TopControlPipeOffset` | `String` | `get/set` | No | `ConditionalReadOnly, ConditionalBrowsable` |

### `ParametersWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ParametersWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ParametersWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FoundationDepth` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `PipeToShellBottomDiff` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `ShellProfileOffset` | `String` | `get/set` | No | `ConditionalReadOnly` |

### `ShellChunkParameterByCatalogueWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ShellChunkParameterByCatalogueWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Common.Segments.SegmentConstruction.ShellChunk.ShellChunkParameterByCatalogueWrapper`

#### Constructors (1)

- `.ctor(ConstructionChunk chunk, CadView cadView, Boolean readOnly)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Document` | `String` | `get` | No | `` |
| `FullName` | `String` | `get` | No | `` |
| `Height` | `Double` | `get` | No | `ConditionalBrowsable` |
| `InnerDiameter` | `Double` | `get` | No | `ConditionalBrowsable` |
| `LengthWithBell` | `Double` | `get` | No | `` |
| `LengthWithoutBell` | `Double` | `get` | No | `` |
| `Material` | `MaterialType` | `get` | No | `PropertyTypeConverter` |
| `NominalDiameter` | `Double` | `get` | No | `` |
| `NS` | `Double` | `get` | No | `` |
| `OuterDiameter` | `Double` | `get` | No | `ConditionalBrowsable` |
| `PN` | `Double` | `get` | No | `` |
| `SDR` | `Double` | `get` | No | `` |
| `SN` | `Double` | `get` | No | `` |
| `Thickness` | `Double` | `get` | No | `` |
| `Weight` | `Double` | `get` | No | `` |
| `Width` | `Double` | `get` | No | `ConditionalBrowsable` |

---
## Namespace: `Topomatic.Pipes.Layers.Design`

### `AlignmentRelativePathAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.AlignmentRelativePathAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderAttribute` |
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
        - `Topomatic.Pipes.Layers.Design.AlignmentRelativePathAttribute`

#### Constructors (1)

- `.ctor(String[] modelTypes)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchGroundInfoCollectionProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.DitchGroundInfoCollectionProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Pipes.Layers.Design.DitchGroundInfoCollectionProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `GeologyRelativePathAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.GeologyRelativePathAttribute` |
| **Base Type** | `Topomatic.Cad.View.Design.ModelFinderAttribute` |
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
        - `Topomatic.Pipes.Layers.Design.GeologyRelativePathAttribute`

#### Constructors (1)

- `.ctor(String[] modelTypes)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PointSignPropertyEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.PointSignPropertyEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Pipes.Layers.Design.PointSignPropertyEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SimpleComboBoxPropertyProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.SimpleComboBoxPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Pipes.Layers.Design.SimpleComboBoxPropertyProvider`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Design.EnumConverters`

### `DitchLayingMethodEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.DitchLayingMethodEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.DitchLayingMethodEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DitchTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.DitchTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.DitchTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `LeaderTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.LeaderTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.LeaderTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ShaftBotElevationEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftBotElevationEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftBotElevationEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `ShaftTopElevationEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftTopElevationEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftTopElevationEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Nested Types (1)

- `TopElevationType` (enum)

### `ShellControlPipeCountConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.ShellControlPipeCountConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.ShellControlPipeCountConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `SimpleBotElevationEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.SimpleBotElevationEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Pipes.Layers.Design.EnumConverters.SimpleBotElevationEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `TopElevationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftTopElevationEnumConverter+TopElevationType` |
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
      - `Topomatic.Pipes.Layers.Design.EnumConverters.ShaftTopElevationEnumConverter+TopElevationType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BySurplus` | `TopElevationType` | Yes | `BySurplus` | `` |
| `ByTopElevation` | `TopElevationType` | Yes | `ByTopElevation` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `BySurplus` | `0` |
| `ByTopElevation` | `1` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Pipes.Layers.Plan`

### `DitchMidSectionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchMidSectionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchMidSectionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, CadColor color, Ditch ditch, Int32 index)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DitchPlanSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AfterWrapperErase` | `Void` | `` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |

#### Nested Types (3)

- `DitchMidSectionGrip` (class)
- `DitchPositionGrip` (class)
- `DitchShaftAngleGrip` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `AfterWrapperErase` |

### `DitchPlanWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DitchPlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Pipes.Layers.Plan.ICreatableDitchWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.DitchPlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, Ditch ditch, LineSurfacesCacheDict surfacesCache)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CreatableDitch` | `ICreatableDitch` | `get` | No | `Browsable` |
| `Ditch` | `Ditch` | `get` | No | `Browsable` |
| `DitchGeometryExtendWrapper` | `DitchGeometryExtendWrapper` | `get` | No | `PropertyProvider` |
| `DitchLayersExtendWrapper` | `DitchLayersExtendWrapper` | `get` | No | `PropertyProvider` |
| `DitchParamsExtendWrapper` | `DitchParamsExtendWrapper` | `get` | No | `PropertyProvider` |
| `GeologyModelRelativePath` | `String` | `get/set` | No | `AlignmentRelativePath` |
| `GroundInfos` | `IList<GroundInfoContainer>` | `get` | No | `PropertyProvider` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `OnErase` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILinearObject` | `GetPolyline` |
| `ICreatableDitchWrapper` | `get_CreatableDitch` |

### `DitchPositionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchPositionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchPositionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, CadColor color, Ditch ditch, Int32 index)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnCreateMenu` | `Void` | `CreateMenuEventArgs e` | `` |
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnCreateMenu` |

### `DitchShaftAngleGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchShaftAngleGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Pipes.Layers.Plan.DitchPlanSubLayer+DitchShaftAngleGrip`

#### Constructors (1)

- `.ctor(CadView cadView, CadColor color, ConnectedDitchPit ditch)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DrawingCrossCaches` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossAtPipeController+DrawingCrossCaches` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnEiPlanCrossAtPipeController controller)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `DrawingData` | `TextStandard textStandard, Double annotationScale, EditableItemsKey key, EditableItem item` | `` |
| `Invalidate` | `Void` | `EditableItemsKey key` | `` |
| `InvalidateAllCaches` | `Void` | `` | `` |

### `DrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossDrawer+DrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossDrawer+DrawingData`

#### Constructors (1)

- `.ctor(TextStandard textStandard, Double annotationScale, PnEiPlanCrossAtPipeKey key, PnEiPlanCrossAtPipeItem item, Int32 number)`

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrossLeader` | `LeaderParams` | No | `` | `` |

### `ICreatableDitchWrapper` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.ICreatableDitchWrapper` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CreatableDitch` | `ICreatableDitch` | `get` | No | `` |

### `NetworkSchemePlanSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.NetworkSchemePlanSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.NetworkSchemePlanSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer, Func<Object Vector2D BasisPointInfo> getBasisInfo)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodeGrips` | `IEnumerable<IGrip>` | `CadView cadView, NetworkSchemePlanNodeWrapper wrapper` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegmentGrips` | `IEnumerable<IGrip>` | `CadView cadView, NetworkSchemePlanPipeWrapper wrapper` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetShellGrips` | `IEnumerable<IGrip>` | `CadView cadView, NetworkSchemePlanShellWrapper wrapper` | `` |
| `InvalidateLine` | `Void` | `PnLine line, FieldChangedType changeType` | `` |
| `InvalidateNode` | `Void` | `PnNode node, FieldChangedType changeType` | `` |
| `InvalidateSegment` | `Void` | `PnSegment segment, FieldChangedType changeType` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBlockEntities` | `IEnumerable<KeyValuePair<DwgEntity Int32>>` | `PipeNetwork network, String blockName` | `` |
| `GetDefaultSchemePlanSignPosition` | `Vector2D` | `PnSegment segment, Boolean atStart` | `` |
| `GetPipeSchemeAngleEnd` | `Double` | `PnSegment segment` | `` |
| `GetPipeSchemeAngleStart` | `Double` | `PnSegment segment` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PlanCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Dwg.IDrawingContainer, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayerActivityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Pipes.Layers.Plan.PlanCompoundLayer`

#### Constructors (1)

- `.ctor(String name, PipeNetwork pipeNetwork)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPipeNetworkPlanLayers` | `IEnumerable<PlanCompoundLayer>` | `CadView cadView` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |
| `ModelsGuid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `GetSubLayers` |
| `IDrawingContainer` | `get_Drawing` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |

### `PlanLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.Plan.PlanLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `LinePlanSubLayer` | `LinePlanSubLayer` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `NodePlanSubLayer` | `NodePlanSubLayer` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `PipePlanSubLayer` | `SegmentPlanSubLayer` | `get` | No | `` |
| `PlanSubLayers` | `IEnumerable<PlanSubLayer>` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAllCaches` | `Void` | `GeometryModelsCacheBuilder cacheBuilder` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `ResetModel3dPivot` | `Void` | `` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Caches` | `PlanLayerCacheContainer` | No | `` | `` |
| `FastCache` | `Boolean` | Yes | `` | `` |
| `Guid` | `Guid` | Yes | `` | `` |
| `HigherThanMountEverestElevation` | `Int32` | Yes | `10000` | `` |
| `LayerName` | `String` | Yes | `` | `` |
| `LineStationingTextStandard` | `TextStandard` | No | `` | `` |
| `LineTextStandard` | `TextStandard` | No | `` | `` |
| `NodeTextStandard` | `TextStandard` | No | `` | `` |
| `SegmentTextStandard` | `TextStandard` | No | `` | `` |

#### Nested Types (1)

- `PnPlanSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PlanLayerClipboardData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanLayerClipboardData` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(List<Object> selections)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddFromStg` | `Void` | `PipeNetwork pipeNetwork, Matrix transform` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `PaintData` | `Void` | `CadView cadView, CadPen pen` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `m_Selections` | `List<Object>` | No | `` | `` |
| `Node` | `StgNode` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlanSubLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Caches` | `PlanLayerCacheContainer` | `get` | No | `` |
| `CadView` | `CadView` | `get` | No | `` |
| `DwgLayer` | `DwgLayer` | `get` | No | `` |
| `DwgSubLayers` | `IEnumerable<DwgLayer>` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `PlanLayer` | `PlanLayer` | `get` | No | `` |
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DynamicDraw` | `Void` | `CadPen pen, Vector3D location` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLimits` | `Boolean` | `ref BoundingBox2D limits` | `` |
| `GetLimits3D` | `Boolean` | `ref BoundingBox3D limits` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetSnapObjects` | `Void` | `ObjectSnapEventArgs e` | `` |
| `HilightObject` | `Void` | `CadPen pen, Object obj` | `` |
| `InvalidateLine` | `Void` | `PnLine line, FieldChangedType changeType` | `` |
| `InvalidateNode` | `Void` | `PnNode node, FieldChangedType changeType` | `` |
| `InvalidateSegment` | `Void` | `PnSegment segment, FieldChangedType changeType` | `` |
| `Paint` | `Void` | `CadPen pen` | `` |
| `Paint3dModelOnPlan` | `Void` | `CadView cadView, CadPen pen, PlanWrapper pnWrapper, Boolean draw3dModels` | `` |
| `ResolveEnable` | `Boolean` | `` | `` |
| `ResolveVisible` | `Boolean` | `` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `PlanWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PlanSubLayer layer, PipeNetworkItem item, Boolean readOnly)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CadView` | `CadView` | `get` | No | `Browsable` |
| `ColorLinetypeExtendWrapper` | `ColorLinetypeExtendWrapper` | `get` | No | `PropertyProvider` |
| `DwgLayer` | `DwgLayer` | `get` | No | `Browsable` |
| `ItemExist` | `Boolean` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `Browsable` |
| `PlanLayer` | `PlanSubLayer` | `get` | No | `Browsable` |
| `ReadOnly` | `Boolean` | `get/set` | No | `Browsable` |
| `SupportClipboard` | `Boolean` | `get` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `Browsable` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `Browsable` |
| `WrappedObject` | `PipeNetworkItem` | `get` | No | `Browsable` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Erase` | `Void` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `InvalidateCadView` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `OnErase` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IWrapped`1` | `get_WrappedObject` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `PnEiPlanCrossAtPipeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossAtPipeController` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossAtPipeController`

#### Constructors (1)

- `.ctor(PlanCrossCacheDict crossCacheDict, PipeNetwork pipeNetwork)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CreateTextStandard` | `TextStandard` | `get` | No | `` |
| `DrawingCaches` | `DrawingCrossCaches` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLayer` | `ILayer` | `` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |
| `GetPlanCrossData` | `PlanCrossCacheData` | `PnEiPlanCrossAtPipeKey key` | `` |
| `InvalidateAllCaches` | `Void` | `` | `` |
| `RefreshCache` | `Void` | `EditableItemsKey key` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `c_Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `DrawingCrossCaches` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `PnEiPlanCrossAtPipeWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossAtPipeWrapper` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsWrapper`
    - `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossAtPipeWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PlanCrossCacheData planCrossData, PnEiPlanCrossAtPipeController controller, PnEiPlanCrossAtPipeKey key)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `CrossName` | `String` | `get/set` | No | `` |
| `CrossNetworkName` | `String` | `get` | No | `` |
| `CrossNetworkType` | `String` | `get` | No | `` |
| `CrossNetworkTypeDesignation` | `String` | `get` | No | `` |
| `CrossStatus` | `String` | `get` | No | `` |
| `DistInLightPipe` | `String` | `get` | No | `` |
| `DistInLightShell` | `String` | `get` | No | `` |
| `HideOnPlan` | `Boolean` | `get/set` | No | `` |
| `LayerName` | `String` | `get` | No | `` |
| `PipeNetworkName` | `String` | `get` | No | `` |
| `PlanCrossProfileDrawing` | `PlanCrossProfileDrawing` | `get/set` | No | `PropertyTypeConverter` |
| `PlanCrossSectionDrawing` | `PlanCrossSectionDrawing` | `get/set` | No | `PropertyTypeConverter` |
| `ProfileWidth` | `Double` | `get/set` | No | `` |
| `SectionWidth` | `Double` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateCadView` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PnEiPlanCrossDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Pipes.Layers.Plan.PnEiPlanCrossDrawer`

#### Constructors (1)

- `.ctor(PnEiPlanCrossAtPipeController controller, CadView cadView)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TextStandard` | `TextStandard` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

#### Nested Types (1)

- `DrawingData` (struct)

### `PnPlanSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.PlanLayer+PnPlanSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Pipes.Layers.Plan.PlanLayer+PnPlanSelectionSet`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportCopyTransform` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `GetTrianglesAtRay` | `IEnumerable<KeyValuePair<Double Triangle3D>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Ditches`

### `DitchLayerExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.DitchLayerExtendWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network, DitchLayer layer, Action recreateLayers)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `FillVolume` | `String` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `PropertyUpdateSequence, Elevation` |
| `Name` | `String` | `get/set` | No | `` |

### `DitchLayerPlanWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.DitchLayerPlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.Ditches.DitchLayerPlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, ICreatableDitchLayer ditchLayer, DitchLayersCacheDict cache)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `` |
| `DitchLayer` | `ICreatableDitchLayer` | `get` | No | `Browsable` |
| `FillVolume` | `String` | `get` | No | `` |
| `GeometryModelsCache` | `IEnumerable<GeometryModelsCache>` | `get` | No | `Browsable` |
| `Height` | `Double` | `get` | No | `Elevation, PropertyUpdateSequence` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `Browsable` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `get_GeometryModelsCache` |

### `DitchLayersExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.DitchLayersExtendWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network, IList<DitchLayer> layers, Action recreateLayers)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layers` | `IList<DitchLayerExtendWrapper>` | `get` | No | `PropertyProvider` |

### `DitchPlanLayersSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.DitchPlanLayersSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Ditches.DitchPlanLayersSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers`

### `DitchExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetwork network, Ditch ditch)`

### `DitchGeneralExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchGeneralExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper`
    - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchGeneralExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetwork network, Ditch ditch)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DitchType` | `eDitchType` | `get` | No | `PropertyTypeConverter, PropertyUpdateSequence` |
| `Length3D` | `String` | `get` | No | `ConditionalBrowsable` |
| `Name` | `String` | `get/set` | No | `` |

### `DitchGeometryExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchGeometryExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper`
    - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchGeometryExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetwork network, Ditch ditch)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle, ConditionalBrowsable` |
| `ConnectedDepth` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `ConnectedLineName` | `String` | `get` | No | `ConditionalBrowsable` |
| `ConnectedPipeName` | `String` | `get` | No | `ConditionalBrowsable` |
| `Count` | `Int32` | `get` | No | `ConditionalBrowsable` |
| `CurrentVertex` | `Vector3D` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly` |
| `CurrentVertexIndex` | `Int32` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence, ConditionalBrowsable` |

### `DitchParamsExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchParamsExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchExtendWrapper`
    - `Topomatic.Pipes.Layers.Plan.Ditches.ExtendWrappers.DitchParamsExtendWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PipeNetwork network, Ditch ditch, LineSurfacesCacheDict surfacesCache)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CutPriority` | `Int32` | `get/set` | No | `` |
| `CutVolume` | `String` | `get` | No | `` |
| `Depth` | `String` | `get/set` | No | `ConditionalBrowsable` |
| `DitchPitSlope` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `DitchType` | `eDitchType` | `get` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `Elevation` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `LayingMethod` | `eDitchLayingMethod` | `get/set` | No | `PropertyTypeConverter` |
| `LeftSlope` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `Length` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `Length3D` | `String` | `get` | No | `ConditionalBrowsable` |
| `Name` | `String` | `get/set` | No | `` |
| `RightSlope` | `Double` | `get/set` | No | `ConditionalBrowsable` |
| `TemplateName` | `String` | `get` | No | `` |
| `Width` | `Double` | `get/set` | No | `ConditionalBrowsable` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.DwgEntityGrips`

### `TextEntityGripData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.DwgEntityGrips.TextEntityGripData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEditedLabel` | `EditedLabel` | `` | `` |
| `GetEntityPosition` | `Vector2D` | `` | `` |
| `GetEntityTextLength` | `Double` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FlipDwgMText` | `Void` | `ref DwgMText mtext` | `` |
| `FlipDwgText` | `Void` | `ref DwgText text` | `` |
| `TextAttachment` | `AttachmentPoint` | `TextAlignment tj` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Angle` | `Double` | No | `` | `` |
| `CadView` | `CadView` | No | `` | `` |
| `Dictionary` | `IDictionary<Int32 EditedLabel>` | No | `` | `` |
| `Entity` | `DwgEntity` | No | `` | `` |
| `EntityIndex` | `Int32` | No | `` | `` |
| `ParseString` | `Func<String String>` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `TextStyle` | `DwgStyle` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Line`

### `LinePlanchetData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanchetData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Line.LinePlanchetData`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LabelsLayer` | `DwgLayer` | No | `` | `` |
| `LineLayer` | `DwgLayer` | No | `` | `` |
| `LinetypeContainer` | `LinetypeContainer` | No | `` | `` |
| `StationingLayer` | `DwgLayer` | No | `` | `` |

### `LinePlanDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnLine line)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnnotationScale` | `Double` | `set` | No | `` |
| `Line` | `PnLine` | `get` | No | `` |
| `TextStandard` | `TextStandard` | `set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePlanchetDwgEntities` | `List<DwgEntity>` | `Drawing drawing, LinePlanchetData planchetData` | `` |
| `DrawLine` | `Void` | `CadPen pen` | `` |
| `DrawLineStationing` | `Void` | `CadPen pen, TextStandard textStandard` | `` |
| `DrawLineText` | `Void` | `CadPen pen` | `` |
| `DrawSegmentText` | `Void` | `CadPen pen, SegmentData segData` | `` |
| `GetSegmentText` | `String` | `PnSegment segment` | `` |
| `TryGetLimits` | `Boolean` | `ref BoundingBox2D bounds` | `` |

#### Nested Types (1)

- `SegmentData` (struct)

### `LinePlanDrawersDict` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanDrawersDict` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(LinePlanSubLayer lineLayer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `LinePlanDrawer` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateAll` | `Void` | `` | `` |
| `InvalidateLine` | `Void` | `PnLine line` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLineDrawer` | `LinePlanDrawer` | `Func<PipeNetwork String Alignment> getAlignmentById, PnLine line` | `` |

### `LinePlanSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Line.LinePlanSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `InvalidateAll` | `Void` | `` | `` |
| `InvalidateLine` | `Void` | `PnLine line, FieldChangedType changeType` | `` |
| `InvalidateSegment` | `Void` | `PnSegment segment, FieldChangedType changeType` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LinePlanWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.Line.LinePlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, PnLine line)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GeologySurvey` | `String` | `get/set` | No | `ConditionalReadOnly, GeologyRelativePath` |
| `ItemExist` | `Boolean` | `get` | No | `` |
| `Length2D` | `String` | `get` | No | `` |
| `Length3D` | `String` | `get` | No | `` |
| `Line` | `PnLine` | `get` | No | `Browsable` |
| `LineSmdxType` | `ImElement` | `get/set` | No | `ConditionalReadOnly, ImObjectPropertyProvider, PropertyUpdateSequence` |
| `Name` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `NodesCount` | `Int32` | `get` | No | `` |
| `PipeNetworkType` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `PipesCount` | `Int32` | `get` | No | `` |
| `PlanName` | `String` | `get` | No | `Browsable, ConditionalReadOnly` |
| `RailCwLine` | `RailContactWireLineExtendWrapper` | `get` | No | `ConditionalBrowsable, PropertyProvider` |
| `StartStation` | `String` | `get/set` | No | `` |
| `StationPrefix` | `String` | `get/set` | No | `` |
| `TypeName` | `String` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, Browsable, PropertyEditor` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `OnErase` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LineExist` | `Boolean` | `PnLine line` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILinearObject` | `GetPolyline` |

### `RailContactWireLineExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.RailContactWireLineExtendWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkExtendWrapper`
    - `Topomatic.Pipes.Layers.Plan.Line.RailContactWireLineExtendWrapper`

#### Constructors (1)

- `.ctor(RailContactNetworkLineData rcnLineData, CadView cadView, Boolean readOnly)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AutoUpdateOnNodeChanged` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `PlanAlignmentId` | `String` | `get/set` | No | `AlignmentRelativePath, ConditionalReadOnly` |
| `ProfileAlignmentId` | `String` | `get/set` | No | `AlignmentRelativePath, ConditionalReadOnly` |
| `StationingAlignmentId` | `String` | `get/set` | No | `ConditionalReadOnly, AlignmentRelativePath` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `SegmentData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Line.LinePlanDrawer+SegmentData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Line.LinePlanDrawer+SegmentData`

#### Constructors (1)

- `.ctor(CompoundLine cl, String text, Double textRelativePos, Boolean flipText)`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CompoundLine` | `CompoundLine` | No | `` | `` |
| `Text` | `String` | No | `` | `` |
| `TextAngle` | `Double` | No | `` | `` |
| `TextPosition` | `Vector2D` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.NetworkScheme`

### `NetworkSchemePlanNodeWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanNodeWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Pipes.Layers.Common.INodeWrapper, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanNodeWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, PnNode node)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `Node` | `PnNode` | `get` | No | `Browsable` |
| `NodeSchemePlanSign` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor` |
| `SchemeHideOnPlan` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `SchemePlanRotation` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `OnErase` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INodeWrapper` | `get_Node` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `NetworkSchemePlanPipeWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanPipeWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Pipes.Layers.Common.ISegmentWrapper, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanPipeWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, PnSegment segment)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `LeaderAngle` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |
| `LeaderAngleEnd` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |
| `LeaderAngleStart` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |
| `LeaderHide` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `LeaderHideOnPlanEnd` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `LeaderHideOnPlanStart` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `NetworkSchemePipeGradeDirection` | `NetworkSchemePipeDirectionEnum` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly` |
| `NetworkSchemeTemplate` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `SchemePlanSignNameEnd` | `String` | `get/set` | No | `ConditionalReadOnly, PropertyEditor` |
| `SchemePlanSignNameStart` | `String` | `get/set` | No | `PropertyEditor, ConditionalReadOnly` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentWrapper` | `get_Segment` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `NetworkSchemePlanShellWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanShellWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.NetworkScheme.NetworkSchemePlanShellWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, ConstructionChunkShell shellChunk)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `HideLeader` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `LeaderAngle` | `Double` | `get/set` | No | `Angle, ConditionalReadOnly` |
| `ShellChunk` | `ConstructionChunkShell` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Nodes`

### `NodePlanSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Nodes.NodePlanSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Nodes.NodePlanSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DwgSubLayers` | `IEnumerable<DwgLayer>` | `get` | No | `` |
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEntityBounds` | `BoundingBox2D` | `DwgEntity entity, Vector2D insertionPoint` | `` |
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `InvalidateNode` | `Void` | `PnNode node, FieldChangedType changeType` | `` |
| `PaintNode` | `Void` | `CadView cadView, CadPen pen, PnNode node, Vector2D position` | `` |
| `PaintNode` | `Void` | `CadView cadView, CadPen pen, PnNode node, Boolean enable, Nullable<CadColor> overrideColor` | `` |
| `PaintNode` | `Void` | `CadView cadView, CadPen pen, PnNode node, Double rotation` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBlockEntities` | `IEnumerable<KeyValuePair<DwgEntity Int32>>` | `PnNode node, String blockName` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

### `NodePlanWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Nodes.NodePlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.FoundationClasses.ISimpleDocumentContainer, Topomatic.Pipes.Layers.Common.INodeWrapper, 
.
, 
.
, Topomatic.Visualization.Components.IComponentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.Nodes.NodePlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, PlanNodeCacheDict cacheDict, PnNode node)`

#### Properties (20)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `CurrentVertex` | `Vector2D` | `get/set` | No | `ConditionalReadOnly` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `FixedComponents` | `IEnumerable<ModelComponent>` | `get` | No | `Browsable` |
| `FlipText` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `GeometryModelsCache` | `IEnumerable<GeometryModelsCache>` | `get` | No | `Browsable` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `HideLeader` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `ItemExist` | `Boolean` | `get` | No | `` |
| `LeaderAngle` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |
| `Length` | `Double` | `get` | No | `Browsable` |
| `LibraryOwner` | `Object` | `get` | No | `Browsable` |
| `Node` | `PnNode` | `get` | No | `Browsable` |
| `NodeExtendWrapper` | `NodeExtendWrapper` | `get` | No | `PropertyProvider` |
| `NodePlanAngle` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `SectionsCount` | `Int32` | `get` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `` |
| `UserComponents` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `OnErase` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |
| `INodeWrapper` | `get_Node` |
| `
` | `get_SectionsCount` |
| `
` | `get_GeometryModelsCache` |
| `IComponentContainer` | `get_FixedComponents` |
| `IComponentContainer` | `get_UserComponents` |
| `IComponentContainer` | `set_UserComponents` |
| `IComponentContainer` | `get_LibraryOwner` |
| `IComponentContainer` | `get_Length` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Nodes.Grips`

### `NodePositionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Nodes.Grips.NodePositionGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Pipes.Layers.Plan.Nodes.Grips.NodePositionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, NodePlanSubLayer nodeLayer, PnNode node)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D position` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Segments`

### `GroundInfoContainerWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentDitchChunkPlanWrapper+GroundInfoContainerWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(GroundInfoContainer container)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ciper` | `String` | `get` | No | `` |
| `Description` | `String` | `get` | No | `` |
| `ExcavationCategory` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Volume` | `Double` | `get` | No | `` |

### `SegmentConstructionDitchLayerExtendWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentConstructionDitchLayerExtendWrapper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PipeNetwork network, ConstructionChunkDitchLayer layer, Action recreateLayers)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |
| `FillVolume` | `String` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `PropertyUpdateSequence, Elevation` |
| `Name` | `String` | `get/set` | No | `` |

### `SegmentDitchChunkPlanWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentDitchChunkPlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Pipes.Layers.Plan.ICreatableDitchWrapper, Topomatic.Pipes.Layers.Common.ISegmentConstructionAxisContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentDitchChunkPlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, SegmentPlanCacheDict cacheDict, ConstructionChunkDitch ditchChunk)`

#### Properties (24)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `ConstructionAxis` | `get` | No | `Browsable` |
| `CreatableDitch` | `ICreatableDitch` | `get` | No | `Browsable` |
| `CutPriority` | `Int32` | `get/set` | No | `` |
| `CutVolume` | `String` | `get` | No | `` |
| `DitchChunk` | `ConstructionChunkDitch` | `get` | No | `Browsable` |
| `DitchType` | `eDitchType` | `get` | No | `PropertyUpdateSequence, PropertyTypeConverter` |
| `FifthLayerExtendWrapper` | `SegmentConstructionDitchLayerExtendWrapper` | `get` | No | `PropertyProvider` |
| `FirstLayerExtendWrapper` | `SegmentConstructionDitchLayerExtendWrapper` | `get` | No | `PropertyProvider` |
| `FourthLayerExtendWrapper` | `SegmentConstructionDitchLayerExtendWrapper` | `get` | No | `PropertyProvider` |
| `GeologyModelRelativePath` | `String` | `get/set` | No | `AlignmentRelativePath` |
| `GroundInfos` | `IList<GroundInfoContainer>` | `get` | No | `PropertyProvider` |
| `ItemExist` | `Boolean` | `get` | No | `` |
| `LayingMethod` | `eDitchLayingMethod` | `get/set` | No | `PropertyTypeConverter` |
| `LeftSlope` | `Double` | `get/set` | No | `` |
| `Length` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `Name` | `String` | `get/set` | No | `` |
| `RightSlope` | `Double` | `get/set` | No | `` |
| `SecondLayerExtendWrapper` | `SegmentConstructionDitchLayerExtendWrapper` | `get` | No | `PropertyProvider` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `StationsExtendWrapper` | `StationsExtendWrapper` | `get` | No | `PropertyProvider` |
| `TemplateName` | `String` | `get` | No | `` |
| `ThirdLayerExtendWrapper` | `SegmentConstructionDitchLayerExtendWrapper` | `get` | No | `PropertyProvider` |
| `VerticalOffset` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetHashCode` | `Int32` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `OnErase` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Nested Types (1)

- `GroundInfoContainerWrapper` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILinearObject` | `GetPolyline` |
| `ICreatableDitchWrapper` | `get_CreatableDitch` |
| `ISegmentConstructionAxisContainer` | `get_Axis` |

### `SegmentLongChunkSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentLongChunkSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentLongChunkSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetLongChunkGrips` | `IEnumerable<IGrip>` | `CadView cadView, LongChunkPlanCache cache, LeaderParams leaderParams` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `InvalidateLine` | `Void` | `PnLine line, FieldChangedType changeType` | `` |
| `InvalidateSegment` | `Void` | `PnSegment segment, FieldChangedType changeType` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

### `SegmentPlanchetData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanchetData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanchetData`

#### Fields (12)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeterminationLayer` | `DwgLayer` | No | `` | `` |
| `LabelsLayer` | `DwgLayer` | No | `` | `` |
| `LineTextStandard` | `TextStandard` | No | `` | `` |
| `LongChunkLayer` | `DwgLayer` | No | `` | `` |
| `PointChunkLayer` | `DwgLayer` | No | `` | `` |
| `RealSizeLayer` | `DwgLayer` | No | `` | `` |
| `SegmentLayer` | `DwgLayer` | No | `` | `` |
| `SegmentTextStandard` | `TextStandard` | No | `` | `` |
| `ShellChunkLayer` | `DwgLayer` | No | `` | `` |
| `ShellLabelsLayer` | `DwgLayer` | No | `` | `` |
| `ShellStationingLayer` | `DwgLayer` | No | `` | `` |
| `VertexLayer` | `DwgLayer` | No | `` | `` |

### `SegmentPlanSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `InvalidateLine` | `Void` | `PnLine line, FieldChangedType changeType` | `` |
| `InvalidateSegment` | `Void` | `PnSegment segment, FieldChangedType changeType` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDrawingData` | `DrawingData` | `PnSegment pipe, DrawingDataParams drawingDataParams, SegmentPlanCacheDict planPipeCacheDict, CadView cadView` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

### `SegmentPlanWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Pipes.PipeNetworkItem, Topomatic.Pipes, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Pipes.IPipeNetworkContainer, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.FoundationClasses.ISimpleDocumentContainer, Topomatic.Pipes.Layers.Common.ISegmentWrapper, Topomatic.Pipes.Layers.Common.ISegmentConstructionAxisContainer, 
.
, Topomatic.Visualization.Components.IComponentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanWrapper`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentPlanWrapper`

#### Constructors (1)

- `.ctor(PlanSubLayer layer, Boolean readOnly, SegmentPlanCacheDict cacheDict, PnSegment segment, SegmentCaches caches)`

#### Properties (22)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Axis` | `ConstructionAxis` | `get` | No | `Browsable` |
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `FixedComponents` | `IEnumerable<ModelComponent>` | `get` | No | `Browsable` |
| `FlipText` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `GeometryModelsCache` | `IEnumerable<GeometryModelsCache>` | `get` | No | `Browsable` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `HideLeader` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `HideNetworkDesignation` | `Boolean` | `get/set` | No | `ConditionalReadOnly` |
| `ItemExist` | `Boolean` | `get` | No | `` |
| `LeaderAngle` | `Double` | `get/set` | No | `ConditionalReadOnly, Angle` |
| `Length` | `Double` | `get` | No | `Browsable` |
| `Length3D` | `String` | `get` | No | `` |
| `LengthBck` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `LengthFwd` | `String` | `get/set` | No | `ConditionalReadOnly` |
| `LibraryOwner` | `Object` | `get` | No | `Browsable` |
| `PipeExtendWrapper` | `SegmentExtendWrapper` | `get` | No | `PropertyProvider` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `` |
| `UserComponents` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `OnErase` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SegmentExist` | `Boolean` | `PnSegment segment` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |
| `ISegmentWrapper` | `get_Segment` |
| `ISegmentConstructionAxisContainer` | `get_Axis` |
| `
` | `get_GeometryModelsCache` |
| `IComponentContainer` | `get_FixedComponents` |
| `IComponentContainer` | `get_UserComponents` |
| `IComponentContainer` | `set_UserComponents` |
| `IComponentContainer` | `get_LibraryOwner` |
| `IComponentContainer` | `get_Length` |

### `SegmentPointChunkSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentPointChunkSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentPointChunkSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

### `SegmentShellChunkSubLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.SegmentShellChunkSubLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Plan.PlanSubLayer` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.Plan.PlanSubLayer`
    - `Topomatic.Pipes.Layers.Plan.Segments.SegmentShellChunkSubLayer`

#### Constructors (1)

- `.ctor(PlanLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Wrappers` | `IEnumerable<PlanWrapper>` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetGeometryModelsCache` | `GeometryModelsCache` | `PlanWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWholeSceneCache` | `IEnumerable<GeometryModelsCache>` | `` | `` |
| `TryGetWrapperBounds` | `Boolean` | `CadView cadView, PlanWrapper pnWrapper, ref BoundingBox2D bounds` | `` |
| `TryGetWrapperBounds3D` | `Boolean` | `PlanWrapper pnWrapper, ref BoundingBox3D bounds` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetWholeSceneCache` |
| `
` | `GetGeometryModelsCache` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Segments.Drawers`

### `LongChunkPlanDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.LongChunkPlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `LongChunkPlanDrawingDataParams` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.LongChunkPlanDrawingDataParams` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Segments.Drawers.LongChunkPlanDrawingDataParams`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalcChunkLeaderParams` | `Boolean` | No | `` | `` |
| `LongChunk` | `ConstructionChunkLong` | No | `` | `` |
| `PlanLine` | `LightweightPlan` | No | `` | `` |
| `ProfileLine` | `LightweightProfile` | No | `` | `` |

### `PointChunkPlanDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.PointChunkPlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `SegmentDeterminationDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.SegmentDeterminationDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDeterminationDwgText` | `Void` | `PnSegment segment, TextStandard textStandard, Double sheetScale, DwgLayer layer, ref List<DwgEntity> list` | `` |
| `AddEntities` | `Void` | `PnSegment segment, TextStandard textStandard, Double sheetScale, DwgLayer determinationLayer, ref List<DwgEntity> list` | `` |
| `Draw` | `Void` | `CadPen pen, SegmentDeterminationDrawerData data` | `` |

### `SegmentDeterminationDrawerData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.SegmentDeterminationDrawerData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `FillData` | `Void` | `PnSegment segment, DrawingDataParams ddp` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DeterminationTypeLeader` | `LeaderParams` | No | `` | `` |
| `Dismantle` | `List<Vector2D>` | No | `` | `` |
| `DISMANTLE_OFFSET` | `Double` | Yes | `0.75` | `` |
| `DISMANTLE_STEP` | `Double` | Yes | `5` | `` |

### `SegmentPlanDrawer` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.SegmentPlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePlanchetDwgEntities` | `List<DwgEntity>` | `CadView cadView, IDwgSheet sheet, Drawing drawing, PnSegment segment, SegmentPlanchetData data` | `` |
| `GetLeaderParams` | `LeaderParams` | `Double annotationScale, TextStandard textStandard, PnSegment segment` | `` |
| `GetVertexesParams` | `List<LeaderParams>` | `TextStandard textStandard, Double annotationScale, PnSegment segment` | `` |

### `ShellChunkPlanDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.ShellChunkPlanDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `ShellChunkPlanDrawingData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.ShellChunkPlanDrawingData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDefaultEndStationParams` | `StoredLeaderData` | `LightweightPlan plan` | `` |
| `GetDefaultLeaderParams` | `StoredLeaderData` | `LightweightPlan plan, Double basePos` | `` |
| `GetDefaultStartStationParams` | `StoredLeaderData` | `LightweightPlan plan` | `` |

#### Fields (14)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ControlPipePlanBlock` | `DwgBlock` | No | `` | `` |
| `ControlPipes` | `List<Vector2D>` | No | `` | `` |
| `EndStationingLeaderParams` | `LeaderParams` | No | `` | `` |
| `EndStationingTextOffset` | `Vector2D` | Yes | `` | `` |
| `LeaderParams` | `LeaderParams` | No | `` | `` |
| `LeaderParamsTextOffset` | `Vector2D` | Yes | `` | `` |
| `LeftLine` | `LightweightPlan` | No | `` | `` |
| `RealSizeLeftLine` | `LightweightPlan` | No | `` | `` |
| `RealSizeRightLine` | `LightweightPlan` | No | `` | `` |
| `RightLine` | `LightweightPlan` | No | `` | `` |
| `SchemeLeaderParams` | `LeaderParams` | No | `` | `` |
| `ShellChunk` | `ConstructionChunkShell` | No | `` | `` |
| `StartStationingLeaderParams` | `LeaderParams` | No | `` | `` |
| `StartStationingTextOffset` | `Vector2D` | Yes | `` | `` |

### `ShellChunkPlanDrawingDataParams` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Drawers.ShellChunkPlanDrawingDataParams` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Segments.Drawers.ShellChunkPlanDrawingDataParams`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CalcChunkLeaderParams` | `Boolean` | No | `` | `` |
| `CalcStationingLeaderParams` | `Boolean` | No | `` | `` |
| `PlanLine` | `LightweightPlan` | No | `` | `` |
| `ProfileLine` | `LightweightProfile` | No | `` | `` |
| `ShellChunk` | `ConstructionChunkShell` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Plan.Segments.Grips.StoredLeaderParamsGrips`

### `StoredLeaderData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Plan.Segments.Grips.StoredLeaderParamsGrips.StoredLeaderData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Plan.Segments.Grips.StoredLeaderParamsGrips.StoredLeaderData`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillStoredParams` | `Void` | `StoredLeaderParams slp` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Angle` | `Double` | No | `` | `` |
| `Flip` | `Boolean` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `Valid` | `Boolean` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Profile`

### `CrossCaches` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController+CrossCaches` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnEiProfileBaseController controller)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `DrawingData` | `TextStandard textStandard, CadView cadView, EditableItemsKey key, EditableItem item` | `` |
| `Invalidate` | `Void` | `EditableItemsKey key` | `` |
| `InvalidateAllCaches` | `Void` | `` | `` |

### `DimensionProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.DimensionProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.DimensionProfileLayer`

#### Constructors (1)

- `.ctor(PnEiProfileCrossAtPipeController crossPipeController)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DimensionTextPositions` | `Void` | `PipeNetwork pipeNetwork, CadView cadView, TextStandard textStandard, ref Boolean annotativeText, ref Double annotativeHeight, ref Double scaleVertical, ref Double dimHeight` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElementProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.ElementProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.ElementProfileLayer`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

### `GeologyLayerSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.GeologyProfileLayer+GeologyLayerSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Pipes.Layers.Profile.GeologyProfileLayer+GeologyLayerSelectionSet`

#### Constructors (1)

- `.ctor(CadViewLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Move` | `Void` | `Object data, Double x, Double y, Double z, Boolean copy` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `GeologyProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.GeologyProfileLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.Profile.GeologyProfileLayer`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Invalidate` | `Void` | `` | `` |
| `InvalidateAllCaches` | `Void` | `` | `` |
| `InvalidateData` | `Void` | `UInt32 id` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `GeologyLayerSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |

### `LineNameProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.LineNameProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.LineNameProfileLayer`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |
| `TopOffset` | `Double` | Yes | `20` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `NodeProfileDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.NodeProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `Drawing drawing, DwgStyle tagStyle, CadColor tagColor, Double horizontalScale, Double verticalScale, Double min, Double verticalOffset, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |
| `AddEntities` | `Void` | `Drawing drawing, DwgStyle tagStyle, CadColor tagColor, Double horizontalScale, Double verticalScale, Double min, Double verticalOffset, ProfileNodeCache cache, List<Vector2D> drawDepthHeaderPositions, Positions depthExtendedHeaderPositions, Nullable<Vector2D> templateMarkPosition, ref List<DwgEntity> list` | `` |
| `DrawNode` | `Void` | `TextStandard textStandard, CadPen pen, CadView cadView, ProfileNodeCache cache` | `` |
| `GetEndPoints` | `List<Vector2D>` | `ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `TextStandard textStandard, CadView cadView, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `GetMiddlePoints` | `List<Vector2D>` | `ProfileNodeCache cache` | `` |
| `GetPipeCutWidth` | `Double` | `PnNode node` | `` |
| `GetSegments` | `List<LineSegment>` | `ProfileNodeCache cache` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LayoutWidth` | `Lineweight` | Yes | `` | `` |

### `NodeProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.NodeProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.NodeProfileLayer`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `NodeCacheDict` | `ProfileNodeCacheDict` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

### `NodeProfileWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.NodeProfileWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.INodeWrapper, 
.
, Topomatic.Visualization.Components.IComponentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`
      - `Topomatic.Pipes.Layers.Profile.NodeProfileWrapper`

#### Constructors (1)

- `.ctor(PnLine line, Int32 nodeIndex, NodeElevationsCache elevationsCache, PipeNetworkCustomFrameLayer layer)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FixedComponents` | `IEnumerable<ModelComponent>` | `get` | No | `Browsable` |
| `Length` | `Double` | `get` | No | `Browsable` |
| `LibraryOwner` | `Object` | `get` | No | `Browsable` |
| `Line` | `PnLine` | `get` | No | `Browsable` |
| `Node` | `PnNode` | `get` | No | `Browsable` |
| `NodeExtendWrapper` | `NodeExtendWrapper` | `get` | No | `PropertyProvider` |
| `NodeIndex` | `Int32` | `get` | No | `Browsable` |
| `SectionsCount` | `Int32` | `get` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `Browsable` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `Browsable` |
| `UserComponents` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `INodeWrapper` | `get_Node` |
| `
` | `get_SectionsCount` |
| `IComponentContainer` | `get_FixedComponents` |
| `IComponentContainer` | `get_UserComponents` |
| `IComponentContainer` | `set_UserComponents` |
| `IComponentContainer` | `get_LibraryOwner` |
| `IComponentContainer` | `get_Length` |

### `PipeNetworkProfileLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeNetworkProfileWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer, Object wrappedObject)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ProfileColor` | `CadColor` | `get/set` | No | `ConditionalReadOnly` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IColoredProfile` | `get_ProfileColor` |
| `IColoredProfile` | `set_ProfileColor` |

### `PnEiProfileBaseController` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CreateTextStandard` | `TextStandard` | `get` | No | `` |
| `DrawingDataCache` | `CrossCaches` | `get` | No | `` |
| `LineCrossCaches` | `PnLineCrossCacheDict` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |
| `SurfacesCaches` | `LineSurfacesCacheDict` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDrawer` | `EditableItemsDrawer` | `CadView cadView` | `` |
| `GetLayer` | `ILayer` | `` | `` |
| `GetNodesCaches` | `ProfileNodeCacheDict` | `PipeNetwork network` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEiLayer` | `EditableItemsLayer` | `CadView cadview, Guid guid, Boolean readOnly` | `` |
| `GetEiLayer` | `EditableItemsLayer` | `CadView cadview, Guid guid` | `` |

#### Nested Types (1)

- `CrossCaches` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `ProfileCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.ProfileCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Pipes.Layers.Profile.ProfileCompoundLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LineCrossCacheDict` | `PnLineCrossCacheDict` | `get` | No | `` |
| `LineSurfacesCacheDict` | `LineSurfacesCacheDict` | `get` | No | `` |
| `NodeCacheDict` | `ProfileNodeCacheDict` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |
| `PipeProfileLayer` | `AxisProfileLayer` | `get` | No | `` |
| `SegmentCacheDict` | `SegmentProfileCacheDict` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `InvalidateCrossDrawingCaches` | `Void` | `` | `` |
| `RefreshAllCaches` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPipeNetworkProfileCompoundLayer` | `ProfileCompoundLayer` | `CadView cadView, Boolean readOnly` | `` |
| `GetPipeNetworkProfileCompoundLayer` | `ProfileCompoundLayer` | `CadView cadView` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `ProfileCustomFrameSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.ProfileCustomFrameSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Pipes.Layers.Profile.ProfileCustomFrameSelectionSet`

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `ShaftSectionsProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.ShaftSectionsProfileLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.Profile.ShaftSectionsProfileLayer`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawExtenstions` | `Void` | `CadPen pen, Double screenRatio, NodeElevationsCache cache, List<ShaftSection> manholeSections, List<ShaftSection> baseSections` | `` |
| `DrawShaftSections` | `Void` | `CadPen pen, Color color, Vector2D botPos, IEnumerable<ConstructionChunk> chunks, Int32 selectedIndex, Color selectedColor` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `SurfaceProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.SurfaceProfileLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.Profile.SurfaceProfileLayer`

#### Constructors (1)

- `.ctor(Guid guid, ProfileNetworkCachesDictionary networkCachesDict)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Enable` | `Boolean` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Style` | `ProfileSurfaceStyle` | `get` | No | `` |
| `Visible` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetProfiles` | `List<List<Vector2D>>` | `BoundingBox2D bounds` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEgThanPgDepthProfile` | `List<List<Vector2D>>` | `LineSurfacesCache lineSurfacesCache, Double depth, Nullable<Double> startStation, Nullable<Double> endStation` | `` |
| `GetEgThenPgDepthProfile` | `List<List<Vector2D>>` | `LineSurfacesCache lineSurfacesCache, Double depth` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CrGuid` | `Guid` | Yes | `` | `` |
| `EgGuid` | `Guid` | Yes | `` | `` |
| `FdGuid` | `Guid` | Yes | `` | `` |
| `PgGuid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayer` | `get_Visible` |
| `ILayer` | `set_Visible` |
| `ILayer` | `get_Enable` |
| `ILayer` | `set_Enable` |
| `ILayer` | `get_Name` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `UserEntityProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.UserEntityProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.UserEntityProfileLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `WaterLevelProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.WaterLevelProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.WaterLevelProfileLayer`

#### Constructors (1)

- `.ctor(SegmentProfileCacheDict profilePipeCacheDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WaterLevelProfileWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.WaterLevelProfileWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.ISegmentWrapper, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`
      - `Topomatic.Pipes.Layers.Profile.WaterLevelProfileWrapper`

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer, PnSegment segment)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get` | No | `Browsable` |
| `LineName` | `String` | `get` | No | `` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentWrapper` | `get_Segment` |
| `
` | `get_Color` |

---
## Namespace: `Topomatic.Pipes.Layers.Profile.Crosses`

### `DistanceData` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.DistanceData` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ChunkPos` | `Vector2D` | No | `` | `` |
| `CrossChunkPos` | `Vector2D` | No | `` | `` |
| `Distance` | `Double` | No | `` | `` |
| `TextPos` | `Vector2D` | No | `` | `` |
| `TypeText` | `String` | No | `` | `` |
| `TypeTopPos` | `Nullable<Vector2D>` | No | `` | `` |

### `DrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.DrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Profile.Crosses.DrawingData`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CenterPos` | `Vector2D` | `get` | No | `` |
| `ChunkProfileParams` | `ProfileParams` | `get` | No | `` |
| `DistancePoses` | `IEnumerable<DistanceData>` | `get` | No | `` |
| `Hide` | `Boolean` | `get` | No | `` |
| `PipeNetwork` | `PipeNetwork` | `get` | No | `` |
| `ShowDistanceInLight` | `ShowDistanceInLight` | `get` | No | `` |
| `Station` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetClosestDistance` | `DistanceData` | `` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `DrawingData` | `Double horizontalScale, Double verticalScale, PnEiProfileCrossAtSegmentKey key, PnEiProfileCrossAtSegmentItem item, Double station` | `` |
| `GetData` | `DrawingData` | `Double horizontalScale, Double verticalScale, PnEiProfileCrossAtNodeKey key, PnEiProfileCrossAtNodeItem item, Double station` | `` |
| `GetData` | `DrawingData` | `TextStandard textStandard, CadView cadView, PnEiProfileCrossAtSegmentKey key, PnEiProfileCrossAtSegmentItem item` | `` |
| `GetData` | `DrawingData` | `TextStandard textStandard, CadView cadView, PnEiProfileCrossAtNodeKey key, PnEiProfileCrossAtNodeItem item` | `` |

### `PnEiProfileCrossAtNodeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtNodeController` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController`
      - `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtNodeController`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `StaticGuid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |

### `PnEiProfileCrossAtNodeWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtNodeWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.ISegmentWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsWrapper`
    - `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper`
      - `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtNodeWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PnEiProfileBaseController controller, PnEiProfileCrossAtNodeKey key)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossAtNodeCharacterPoint` | `CrossAtNodeCharacterPoint` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, ConditionalBrowsable` |
| `DrawTypeAtNode` | `CrossDrawType` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, ConditionalBrowsable` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `ShowDiameters` | `CrossDrawContour` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, ConditionalBrowsable` |
| `UseDefaultCrossAtNodeCharacterPoint` | `Boolean` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `UseDefaultDrawTypeAtNode` | `Boolean` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `UseDefaultShowDiameter` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `WrappedItem` | `PnEiProfileCrossAtNodeItem` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentWrapper` | `get_Segment` |

### `PnEiProfileCrossAtPipeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtPipeController` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController` |
| **Implements** | `System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.FoundationClasses.EditableItems.EditableItemsKey, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IObjectDisjoiner, System.IDisposable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsController`
    - `Topomatic.Pipes.Layers.Profile.PnEiProfileBaseController`
      - `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtPipeController`

#### Constructors (1)

- `.ctor(ProfileNetworkCachesDictionary networkCachesDict)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `CadView cadView, Object obj` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `StaticGuid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |

### `PnEiProfileCrossAtPipeWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtPipeWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.FoundationClasses.EditableItems.EditableItem, Topomatic.FoundationClasses, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.ILayeredObject, Topomatic.FoundationClasses.IOwned, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.ISegmentWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsWrapper`
    - `Topomatic.Pipes.Layers.Common.PnEiPipeWrapper`
      - `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossAtPipeWrapper`

#### Constructors (1)

- `.ctor(CadView cadView, PnEiProfileBaseController controller, PnEiProfileCrossAtSegmentKey key)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CrossAtPipeCharacterPoint` | `CrossAtPipeCharacterPoint` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter, ConditionalBrowsable` |
| `DrawTypeAtPipe` | `CrossDrawType` | `get/set` | No | `PropertyTypeConverter, ConditionalBrowsable, ConditionalReadOnly` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `ShowDiameters` | `CrossDrawContour` | `get/set` | No | `ConditionalBrowsable, ConditionalReadOnly, PropertyTypeConverter` |
| `ShowDistanceInLight` | `ShowDistanceInLight` | `get/set` | No | `ConditionalReadOnly, PropertyTypeConverter` |
| `UseDefaultCrossAtPipeCharacterPoint` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `UseDefaultDrawTypeAtPipe` | `Boolean` | `get/set` | No | `ConditionalReadOnly, PropertyUpdateSequence` |
| `UseDefaultShowDiameter` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, ConditionalReadOnly` |
| `WrappedItem` | `PnEiProfileCrossAtSegmentItem` | `get` | No | `Browsable` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentWrapper` | `get_Segment` |

### `PnEiProfileCrossDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossDrawer` |
| **Base Type** | `Topomatic.Cad.View.EditableItems.EditableItemsDrawer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.EditableItems.EditableItemsDrawer`
    - `Topomatic.Pipes.Layers.Profile.Crosses.PnEiProfileCrossDrawer`

#### Constructors (1)

- `.ctor(PnEiProfileBaseController controller, CadView cadView)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TextStandard` | `TextStandard` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawItem` | `Void` | `Boolean enabled, CadPen pen, EditableItemsKey editableItemsKey, Object editableItem` | `` |
| `GetLimits` | `Boolean` | `EditableItemsKey editableItemsKey, Object editableItem, ref BoundingBox2D bounds` | `` |

### `ProfileParams` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Crosses.ProfileParams` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Chunk` | `ConstructionChunk` | No | `` | `` |
| `Color` | `CadColor` | No | `` | `` |
| `Dismantle` | `Nullable<BoundingBox2D>` | No | `` | `` |
| `DrawType` | `CrossDrawType` | No | `` | `` |
| `LeaderParams` | `LeaderParams` | No | `` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.Profile.Segments`

### `AxisProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.AxisProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.Segments.AxisProfileLayer`

#### Constructors (1)

- `.ctor(SegmentProfileCacheDict profilePipeCacheDict)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |
| `SurfacesCacheDict` | `LineSurfacesCacheDict` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearLineCache` | `Void` | `UInt32 lineId` | `` |
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

### `LongChunkProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.LongChunkProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.Segments.LongChunkProfileLayer`

#### Constructors (1)

- `.ctor(SegmentProfileCacheDict profilePipeCacheDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearLineCache` | `Void` | `UInt32 lineId` | `` |
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

### `SegmentProfileDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.SegmentProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `Double horizontalScale, Double verticalScale, PnSegment pipe, Func<Int32 ProfileNodeCache> getNodeCache, ref List<DwgEntity> list` | `` |
| `DrawPipeEnd` | `Void` | `CadPen pen, Double screenRatio, Double station, PnSegment pipe, Double additionalElevation, Boolean left` | `` |
| `DrawPipeEnd` | `Void` | `CadPen pen, Double screenRatio, Double station, PnSegment pipe, Boolean left` | `` |
| `DynamicDrawPipe` | `Void` | `CadPen pen, Double screenRatio, LightweightProfile profileLine, Double pipeProfileStation, Double outerRadius, Double innerRadius, Double offset` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, PnSegment pipe, ref BoundingBox2D bounds` | `` |

### `SegmentProfileWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.SegmentProfileWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.Layers.Common.ISegmentWrapper, Topomatic.Visualization.Components.IComponentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`
      - `Topomatic.Pipes.Layers.Profile.Segments.SegmentProfileWrapper`

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer, PnSegment segment, SegmentCaches caches)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FixedComponents` | `IEnumerable<ModelComponent>` | `get` | No | `Browsable` |
| `Length` | `Double` | `get` | No | `Browsable` |
| `Length2D` | `String` | `get` | No | `` |
| `Length3D` | `String` | `get` | No | `` |
| `LibraryOwner` | `Object` | `get` | No | `Browsable` |
| `PipeExtendWrapper` | `SegmentExtendWrapper` | `get` | No | `PropertyProvider` |
| `Segment` | `PnSegment` | `get` | No | `Browsable` |
| `SupportCopyProperties` | `Boolean` | `get` | No | `Browsable` |
| `SupportPasteProperties` | `Boolean` | `get` | No | `Browsable` |
| `UserComponents` | `String` | `get/set` | No | `Browsable` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyProperties` | `Void` | `StgNode data` | `` |
| `PasteProperties` | `Void` | `StgNode data` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISegmentWrapper` | `get_Segment` |
| `IComponentContainer` | `get_FixedComponents` |
| `IComponentContainer` | `get_UserComponents` |
| `IComponentContainer` | `set_UserComponents` |
| `IComponentContainer` | `get_LibraryOwner` |
| `IComponentContainer` | `get_Length` |

### `SegmentVerticesProfileDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.SegmentVerticesProfileDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `SegmentVerticesProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.SegmentVerticesProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.Segments.SegmentVerticesProfileLayer`

#### Constructors (1)

- `.ctor(SegmentProfileCacheDict profilePipeCacheDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

### `ShellChunkProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ShellChunkProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, 
.
` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileLayer`
        - `Topomatic.Pipes.Layers.Profile.Segments.ShellChunkProfileLayer`

#### Constructors (1)

- `.ctor(SegmentProfileCacheDict profilePipeCacheDict)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearLineCache` | `Void` | `UInt32 lineId` | `` |
| `GetEndNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetLine` | `PnLine` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodeCache` | `ProfileNodeCache` | `PnLine line, Int32 nodeIndex` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetStartNodeIndex` | `Int32` | `PipeNetworkCustomFrameWrapper pnWrapper` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `
` | `GetNodeCache` |
| `
` | `GetLine` |
| `
` | `GetStartNodeIndex` |
| `
` | `GetEndNodeIndex` |

---
## Namespace: `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers`

### `CompoundLines` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.PipeProfilesContainer+CompoundLines` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileLines profiles)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillFromOrigins` | `Void` | `ProfileLines profiles` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInnerLine` | `CompoundLine` | No | `` | `` |
| `BotOuterLine` | `CompoundLine` | No | `` | `` |
| `MiddleLine` | `CompoundLine` | No | `` | `` |
| `TopInnerLine` | `CompoundLine` | No | `` | `` |
| `TopOuterLine` | `CompoundLine` | No | `` | `` |

### `ControlPipeData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData+ControlPipeData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData+ControlPipeData`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ShellBotPos` | `Vector2D` | No | `` | `` |
| `ShellTopPos` | `Vector2D` | No | `` | `` |
| `TopPos` | `Vector2D` | No | `` | `` |

### `LongChunkDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.LongChunkDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `LongChunkDrawingData drawingData, ref List<DwgEntity> list` | `` |
| `DrawPipe` | `Void` | `CadPen pen, LongChunkDrawingData data` | `` |
| `GetLimits` | `Boolean` | `LongChunkDrawingData data, ref BoundingBox2D bounds` | `` |

### `LongChunkDrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.LongChunkDrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.LongChunkDrawingData`

#### Constructors (1)

- `.ctor(LongChunkProfileCache cache)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Chunk` | `ConstructionChunkLong` | `get` | No | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateDismatleCrosses` | `List<Vector2D[]>` | `ConstructionChunkLong chunk, SegmentAxisPlanProfileCache planProfile, DrawingDataParams drawingDataParams` | `` |
| `PairCompoundLines` | `Void` | `PipeProfilesContainer current, PipeProfilesContainer other, Boolean atStart` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cache` | `LongChunkProfileCache` | No | `` | `` |
| `DismantleCrosses` | `List<Vector2D[]>` | No | `` | `` |
| `DrawingDataParams` | `DrawingDataParams` | No | `` | `` |
| `PipeProfiles` | `PipeProfilesContainer` | No | `` | `` |

### `MainChunkVertices` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData+MainChunkVertices` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData+MainChunkVertices`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotEnd` | `Vector2D` | No | `` | `` |
| `BotStart` | `Vector2D` | No | `` | `` |
| `Exist` | `Boolean` | No | `` | `` |
| `TopEnd` | `Vector2D` | No | `` | `` |
| `TopStart` | `Vector2D` | No | `` | `` |

### `PipeProfilesContainer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.PipeProfilesContainer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ProfileLines origins)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CutProfiles` | `Void` | `Double startWall, Double endWall` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInnerLine` | `Polyline3D` | No | `` | `` |
| `BotOuterLine` | `Polyline3D` | No | `` | `` |
| `Hatch` | `DwgHatch` | No | `` | `` |
| `MiddleLine` | `Polyline3D` | No | `` | `` |
| `TopInnerLine` | `Polyline3D` | No | `` | `` |
| `TopOuterLine` | `Polyline3D` | No | `` | `` |

#### Nested Types (2)

- `CompoundLines` (class)
- `ProfileLines` (class)

### `ProfileLines` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.PipeProfilesContainer+ProfileLines` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BotInnerLine` | `LightweightProfile` | No | `` | `` |
| `BotOuterLine` | `LightweightProfile` | No | `` | `` |
| `MiddleLine` | `LightweightProfile` | No | `` | `` |
| `TopInnerLine` | `LightweightProfile` | No | `` | `` |
| `TopOuterLine` | `LightweightProfile` | No | `` | `` |

### `SegmentProfileLineDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.SegmentProfileLineDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `Double horizontalScale, Double verticalScale, PnSegment pipe, Func<Int32 ProfileNodeCache> getNodeCache, ref List<DwgEntity> list` | `` |
| `DynamicDrawPipe` | `Void` | `CadPen pen, Double screenRatio, LightweightProfile profileLine, Double pipeProfileStation, Double outerRadius, Double innerRadius` | `` |
| `GetLimits` | `Boolean` | `PnSegment segment, ref BoundingBox2D bounds` | `` |

### `ShellChunkDrawer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntities` | `Void` | `DwgStyle tagStyle, ShellChunkDrawingData drawingData, Double minY, ref List<DwgEntity> list, Boolean hideLeader` | `` |
| `DrawPipe` | `Void` | `CadPen pen, ShellChunkDrawingData data` | `` |
| `GetLimits` | `Boolean` | `ShellChunkDrawingData data, ref BoundingBox2D bounds` | `` |

### `ShellChunkDrawingData` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Pipes.Layers.Profile.Segments.ConstructionDrawers.ShellChunkDrawingData`

#### Constructors (1)

- `.ctor(ShellChunkProfileCache cache)`

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLeaderParams` | `LeaderParams` | `ConstructionChunkShell chunk, LightweightPlan plan, LightweightProfile profile` | `` |

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Chunk` | `ConstructionChunkShell` | No | `` | `` |
| `ControlPipes` | `List<ControlPipeData>` | No | `` | `` |
| `DismantleCrosses` | `List<Vector2D[]>` | No | `` | `` |
| `DrawingDataParams` | `DrawingDataParams` | No | `` | `` |
| `LeaderParams` | `LeaderParams` | No | `` | `` |
| `MainVertices` | `MainChunkVertices` | No | `` | `` |
| `OrdinateBlock` | `List<DwgEntity>` | No | `` | `` |
| `PipeProfiles` | `PipeProfilesContainer` | No | `` | `` |

#### Nested Types (2)

- `ControlPipeData` (struct)
- `MainChunkVertices` (struct)

---
## Namespace: `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers`

### `AirOutDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.AirOutDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, ProfileNodeCache cache, ShaftType shaftType` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ShaftType shaftType, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ShaftType shaftType, ref List<DwgEntity> list` | `` |

### `BuildingDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.BuildingDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `ControlDeviceUnderCoverDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.ControlDeviceUnderCoverDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, ProfileNodeCache cache, Boolean drawPole` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, Boolean drawPole, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, Boolean drawPole, ref List<DwgEntity> list` | `` |

### `ControlPipeUnderCoverDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.ControlPipeUnderCoverDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `CoverDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.CoverDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, Double station, Double elevation` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, Double station, Double elevation, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, Double station, Double elevation, ref List<DwgEntity> list` | `` |

### `DamperDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.DamperDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, ProfileNodeCache cache, ShaftType shaftType` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ShaftType shaftType, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ShaftType shaftType, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1` | `` |

### `DiameterChangerDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.DiameterChangerDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1.1` | `` |

### `DismantleNodeDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.DismantleNodeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `EndCapDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.EndCapDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `GroundExitDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.GroundExitDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `Double screenRatio, CadPen pen, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `HalfShaftDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.HalfShaftDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Nullable<Double> topElevation` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultHalfShaftHeight` | `Double` | Yes | `1` | `` |
| `HalfShaftHeightTag` | `String` | Yes | `"HalfShaftHeight"` | `` |

### `HydrantDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.HydrantDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, ShaftType shaftType, Double sr` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits, ShaftType shaftType, Double sr` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ShaftType shaftType, ref List<DwgEntity> list` | `` |

### `IncutDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.IncutDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, CadView cadView, TextStandard textStandard, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `CadView cadView, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Drawing drawing, DwgStyle style, Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `MaterialChangerDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.MaterialChangerDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1` | `` |

### `NodeDepthHeaderDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.NodeDepthHeaderDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, CadPen pen, Double screenRatio, ProfileNodeCache cache, Nullable<Vector2D> offset` | `` |
| `GetTextGripPos` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, Double screenRatio, ProfileNodeCache cache, Vector2D offset, ref Vector2D baseGripPos, ref Vector2D realGripPos` | `` |
| `Layout` | `Void` | `DwgStyle tagStyle, Double horizontalScale, Double verticalScale, ProfileNodeCache cache, List<Vector2D> positions, ref List<DwgEntity> list` | `` |

### `NodeExtendedHeaderDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.NodeExtendedHeaderDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, CadPen pen, Double screenRatio, ProfileNodeCache cache, Nullable<Vector2D> offset` | `` |
| `GetLimits` | `Boolean` | `TextStandard textStandard, Nullable<Double> annotativeHeight, CadView cadView, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `GetTextGripPos` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, Double screenRatio, ProfileNodeCache cache, Vector2D offset, ref Vector2D baseGripPos, ref Vector2D realGripPos` | `` |
| `Layout` | `Void` | `DwgStyle tagStyle, Double horizontalScale, Double verticalScale, ProfileNodeCache cache, Positions depthExtendedHeaderPositions, ref List<DwgEntity> list` | `` |

#### Nested Types (1)

- `Positions` (class)

### `NodeTemplateMarkHeaderDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.NodeTemplateMarkHeaderDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, CadPen pen, Double screenRatio, ProfileNodeCache cache, Nullable<Vector2D> offset` | `` |
| `GetTextGripPos` | `Void` | `TextStandard textStandard, Nullable<Double> annotativeHeight, Double screenRatio, ProfileNodeCache cache, Vector2D offset, ref Vector2D baseGripPos, ref Vector2D realGripPos` | `` |
| `Layout` | `Void` | `DwgStyle tagStyle, Double horizontalScale, Double verticalScale, ProfileNodeCache cache, Nullable<Vector2D> position, ref List<DwgEntity> list` | `` |

### `PlanAngleDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.PlanAngleDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1.1` | `` |

### `PlanAngleWithPipeDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.PlanAngleWithPipeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1.1` | `` |

### `PoleFixedDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.PoleFixedDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `PoleMovableDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.PoleMovableDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Double screenRatio` | `` |
| `GetLimits` | `Boolean` | `Double screenRatio, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `Positions` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.NodeExtendedHeaderDrawer+Positions` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BaseGripPos` | `Vector2D` | No | `` | `` |
| `LeaderLeftPos` | `Vector2D` | No | `` | `` |
| `LeaderRightPos` | `Vector2D` | No | `` | `` |
| `LeftDepthPos` | `Nullable<Vector2D>` | No | `` | `` |
| `NameTextPos` | `Vector2D` | No | `` | `` |
| `NodeDiameterTextPos` | `Vector2D` | No | `` | `` |
| `RealGripPos` | `Vector2D` | No | `` | `` |
| `RightDepthPos` | `Nullable<Vector2D>` | No | `` | `` |

### `ShaftDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.ShaftDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, ProfileNodeCache cache, Nullable<Double> botElevation, Nullable<Double> topElevation` | `` |
| `GetLimits` | `Boolean` | `Double station, ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `ShaftType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.ShaftType` |
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
      - `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.ShaftType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HalfShaft` | `ShaftType` | Yes | `HalfShaft` | `` |
| `NoShaft` | `ShaftType` | Yes | `NoShaft` | `` |
| `Shaft` | `ShaftType` | Yes | `Shaft` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `NoShaft` | `0` |
| `HalfShaft` | `1` |
| `Shaft` | `2` |

**Underlying Type**: `System.Int32`

### `SimpleElementNodeDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.SimpleElementNodeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `TextStandard textStandard, CadPen pen, CadView cadView, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `DwgStyle tagStyle, Double horizontalScale, Double verticalScale, Double min, Double verticalOffset, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `SimpleNodeDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.SimpleNodeDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Double screenRatio, ProfileNodeCache cache` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, ref List<DwgEntity> list` | `` |

### `StreetlightPoleDrawer` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.Profile.StaticNodeDrawers.StreetlightPoleDrawer` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Draw` | `Void` | `CadPen pen, Double screenRatio, ProfileNodeCache cache, Boolean drawAnchor` | `` |
| `GetLimits` | `Boolean` | `ProfileNodeCache cache, ref BoundingBox2D limits` | `` |
| `Layout` | `Void` | `Double horizontalScale, Double verticalScale, ProfileNodeCache cache, Boolean drawAnchor, ref List<DwgEntity> list` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Width` | `Double` | Yes | `1` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.SegmentCrs`

### `PipeNetworkSegmentCrsLayer` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PipeNetworkSegmentCrsWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsWrapper`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsBorderLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsBorderLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsBorderLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawBorder` | `Void` | `CadPen pen, PnCrsBorder border` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsCenterLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsCenterLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsCenterLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CenterRadius` | `Double` | Yes | `0.02` | `` |
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |

### `SegmentCrsCompoundLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsCompoundLayer` |
| **Base Type** | `Topomatic.Cad.View.CompoundLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.View.CadViewLayer, Topomatic.Cad.View, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, Topomatic.Pipes.IPipeNetworkContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Cad.View.CompoundLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsCompoundLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PipeNetwork` | `PipeNetwork` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPipeNetworkContainer` | `get_PipeNetwork` |

### `SegmentCrsContourLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsContourLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsContourLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawContour` | `Void` | `CadPen pen, PnCrsContour contour` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SegmentCrsElevationProfileLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsElevationProfileLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsElevationProfileLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawElevation` | `Void` | `CadPen pen, PnCrsElevationProfile elevation` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SegmentCrsEntityLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsEntityLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsEntityLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SegmentCrsFarmLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsFarmLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsFarmLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawFarm` | `Void` | `CadPen pen, PnCrsFarm farm` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SegmentCrsLayouter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsLayouter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntitiesToDrawing` | `Void` | `PnCrsMainSection section, TextStandard crsUserEntityTs, Drawing drawing` | `` |

### `SegmentCrsSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsSelectionSet`

#### Constructors (1)

- `.ctor(PipeNetworkCustomFrameLayer layer)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `SupportCopyTransform` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `SegmentCrsSlotLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsSlotLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsSlotLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawSlot` | `Void` | `CadPen pen, PnCrsSlot slot` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `SegmentCrsUnderlayLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsUnderlayLayer` |
| **Base Type** | `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameLayer`
      - `Topomatic.Pipes.Layers.SegmentCrs.PipeNetworkSegmentCrsLayer`
        - `Topomatic.Pipes.Layers.SegmentCrs.SegmentCrsUnderlayLayer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LayerGuid` | `Guid` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `GetWrappers` | `IList<PipeNetworkCustomFrameWrapper>` | `` | `` |
| `PaintWrapper` | `Void` | `CadView cadView, CadPen pen, TextStandard textStandard, PipeNetworkCustomFrameWrapper pnWrapper` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawUnderlay` | `Void` | `CadPen pen, PnCrsSectionUnderlay underlay, Vector2D position, Double rotation, Double scale` | `` |
| `DrawUnderlay` | `Void` | `CadPen pen, PnCrsSectionUnderlay underlay` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

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

---
## Namespace: `Topomatic.Pipes.Layers.SegmentCrs.Grips`

### `CrossLeaderPositionGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.SegmentCrs.Grips.CrossLeaderPositionGrip` |
| **Base Type** | `Topomatic.Planchet.Leader.LeaderPositionGrip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Planchet.Leader.LeaderGrip`
      - `Topomatic.Planchet.Leader.LeaderPositionGrip`
        - `Topomatic.Pipes.Layers.SegmentCrs.Grips.CrossLeaderPositionGrip`

#### Constructors (1)

- `.ctor(CadView cadView, LeaderParams leaderParams, CadColor color, PnEiPlanCrossAtPipeController controller, PnEiPlanCrossAtPipeKey key, PnEiPlanCrossAtPipeItem item)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ResetPosition` | `Void` | `` | `` |
| `SetPosition` | `Void` | `Vector3D vertex` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetDefaultPos` | `Void` | `LabelParams labelParams, Double cadViewScreenRotation` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Pipes.Layers.ServiceClasses`

### `BasisTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.BasisTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetBasisElevation` | `Boolean` | `Alignment alg, Vector2D pos, ref Double elevation` | `` |

### `LayerTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.LayerTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearAllSelectionSets` | `Void` | `CadView cadView` | `` |
| `ClearPlanSelectionSet` | `Void` | `CadView cadView` | `` |
| `ClearProfileSelectionSet` | `Void` | `CadView cadView` | `` |
| `DrawTriangleStrip` | `Void` | `Vector2F[] strip, Vector2D pivot, Int32 alpha, CadColor color, PaintEntityEventArgs args` | `` |
| `EqualsTextStandard` | `Boolean` | `TextStandard a, TextStandard b` | `` |
| `GetAlignmentById` | `Alignment` | `CadView cadView, PipeNetwork network, String id` | `` |
| `GetBasisAlignment` | `Alignment` | `CadView cadView, PipeNetwork network` | `` |
| `GetBasisInfo` | `BasisPointInfo` | `CadView cadView, Object obj, Vector2D pos` | `` |
| `GetModelName` | `String` | `CadView cadView, IOwned obj` | `` |
| `InvalidateCadView` | `Void` | `CadView cadView` | `` |
| `Select3dModel` | `ImElement` | `ImElement selected, Func<ImElement Boolean> filter` | `` |
| `TextStandardsEqualsForDrawer` | `Boolean` | `TextStandard a, TextStandard b` | `` |
| `TryGetSegmentChunkBounds3D` | `Boolean` | `SegmentPlanCache cache, ConstructionChunk chunk, ref BoundingBox3D bounds` | `` |

### `LeaderParamsExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.LeaderParamsExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SetTextStandard` | `Void` | `LeaderParams leaderParams, String fileName, Double height, Double ratio, Double oblique` | `Extension` |
| `SetTextStandard` | `Void` | `LeaderParams leaderParams, TextStandard textStandard, Double annotationScale` | `Extension` |

### `ParabolaTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.ParabolaTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateParabolaBy3Points` | `Void` | `` | `` |

### `SimpleContourFill` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.SimpleContourFill` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Pipes.Layers.ServiceClasses.SimpleContourFill`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcSimpleContoursStrips` | `Void` | `List<List<Vector2D>> contours, Vector2D pivot, ref List<Vector2F> strip` | `` |

### `SmdxTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.SmdxTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDeterminationType` | `Void` | `DeterminationType detType, ref ImProperties props` | `` |
| `SmdxTypeContainsId` | `Boolean` | `ImTypeDescriptor smdxType, String id` | `` |

#### Fields (66)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DitchCutVolumeTag` | `String` | Yes | `"ditch_cut_volume"` | `` |
| `DitchLayerDiameterTag` | `String` | Yes | `"ditch_layer_diameter"` | `` |
| `DitchLayerHeightTag` | `String` | Yes | `"ditch_layer_height"` | `` |
| `DitchLayerVolumeTag` | `String` | Yes | `"ditch_layer_volume"` | `` |
| `DitchLeftSlopeTag` | `String` | Yes | `"ditch_left_slope"` | `` |
| `DitchLengthTag` | `String` | Yes | `"ditch_length"` | `` |
| `DitchRightSlopeTag` | `String` | Yes | `"ditch_right_slope"` | `` |
| `DitchWidthTag` | `String` | Yes | `"ditch_width"` | `` |
| `ElementStatusTag` | `String` | Yes | `"status_type"` | `` |
| `LineDescriptor` | `String` | Yes | `"SmdxNetworksLine"` | `` |
| `LineLength2dTag` | `String` | Yes | `"line_length_2d"` | `` |
| `LineLength3dTag` | `String` | Yes | `"line_length_3d"` | `` |
| `LineNameTag` | `String` | Yes | `"line_name"` | `` |
| `LineNetworkTypeTag` | `String` | Yes | `"line_network_type"` | `` |
| `LineNodesCountTag` | `String` | Yes | `"line_nodes_count"` | `` |
| `LineSegmentsCountTag` | `String` | Yes | `"line_segments_count"` | `` |
| `LineTagsToHide` | `String[]` | Yes | `` | `` |
| `NodeBasisStationTag` | `String` | Yes | `"node_basis_station"` | `` |
| `NodeDescriptor` | `String` | Yes | `"SmdxNetworksNode"` | `` |
| `NodeLinesNamesTag` | `String` | Yes | `"node_lines_names"` | `` |
| `NodeLinesStationsTag` | `String` | Yes | `"node_lines_stations"` | `` |
| `NodeMarkTag` | `String` | Yes | `"node_mark"` | `` |
| `NodeNameTag` | `String` | Yes | `"node_name"` | `` |
| `NodeNetworkTypeTag` | `String` | Yes | `"node_network_type"` | `` |
| `NodePositionXTag` | `String` | Yes | `"node_position_x"` | `` |
| `NodePositionYTag` | `String` | Yes | `"node_position_y"` | `` |
| `NodePositionZTag` | `String` | Yes | `"node_position_z"` | `` |
| `NodeShaftBottomElevationTag` | `String` | Yes | `"shaft_bottom_elevation"` | `` |
| `NodeShaftDepthTag` | `String` | Yes | `"shaft_depth"` | `` |
| `NodeShaftDescriptor` | `String` | Yes | `"SmdxNetworksNodeShaft"` | `` |
| `NodeShaftDiameterTag` | `String` | Yes | `"shaft_diameter"` | `` |
| `NodeShaftLengthTag` | `String` | Yes | `"shaft_length"` | `` |
| `NodeShaftPipeSurplusTag` | `String` | Yes | `"shaft_pipe_surplus"` | `` |
| `NodeShaftProfileTag` | `String` | Yes | `"shaft_profile"` | `` |
| `NodeShaftRectangularDescriptor` | `String` | Yes | `"SmdxNetworksNodeShaftRectangular"` | `` |
| `NodeShaftRoundDescriptor` | `String` | Yes | `"SmdxNetworksNodeShaftRound"` | `` |
| `NodeShaftSurplusTag` | `String` | Yes | `"shaft_surplus"` | `` |
| `NodeShaftTopElevationTag` | `String` | Yes | `"shaft_top_elevation"` | `` |
| `NodeShaftWidthTag` | `String` | Yes | `"shaft_width"` | `` |
| `NodeTagsToHide` | `String[]` | Yes | `` | `` |
| `NodeTypeTag` | `String` | Yes | `"node_type"` | `` |
| `SegmentCharacterPointParams` | `String` | Yes | `"SmdxNetworksCharacterPointParams"` | `` |
| `SegmentCpElevationTag` | `String` | Yes | `"character_point_elevation"` | `` |
| `SegmentCpTypeTag` | `String` | Yes | `"segment_cp_type"` | `` |
| `SegmentDescriptor` | `String` | Yes | `"SmdxNetworksSegment"` | `` |
| `SegmentEgDistanceTag` | `String` | Yes | `"character_point_eg_dist"` | `` |
| `SegmentEndCpTag` | `String` | Yes | `"segment_end_cp_params"` | `` |
| `SegmentGradeTag` | `String` | Yes | `"segment_grade"` | `` |
| `SegmentLayoutTypeTag` | `String` | Yes | `"segment_layout_type"` | `` |
| `SegmentLength2dTag` | `String` | Yes | `"segment_length_2d"` | `` |
| `SegmentLength3dTag` | `String` | Yes | `"segment_length_3d"` | `` |
| `SegmentOvergroundDistanceTag` | `String` | Yes | `"character_point_overground_distance"` | `` |
| `SegmentPgDistanceTag` | `String` | Yes | `"character_point_pg_dist"` | `` |
| `SegmentPipeHeightTag` | `String` | Yes | `"pipe_height"` | `` |
| `SegmentPipeInnerDiameterTag` | `String` | Yes | `"pipe_inner_diameter"` | `` |
| `SegmentPipeOuterDiameterTag` | `String` | Yes | `"pipe_outer_diameter"` | `` |
| `SegmentPipeThicknessTag` | `String` | Yes | `"pipe_thickness"` | `` |
| `SegmentPipeWidthTag` | `String` | Yes | `"pipe_width"` | `` |
| `SegmentStartCpTag` | `String` | Yes | `"segment_start_cp_params"` | `` |
| `SegmentTagsToHide` | `String[]` | Yes | `` | `` |
| `SegmentUndergroundDistanceTag` | `String` | Yes | `"character_point_underground_distance"` | `` |
| `ShellDescriptor` | `String` | Yes | `"SmdxNetworksShell"` | `` |
| `ShellEndCpTag` | `String` | Yes | `"shell_end_cp_params"` | `` |
| `ShellLength2dTag` | `String` | Yes | `"shell_length_2d"` | `` |
| `ShellLength3dTag` | `String` | Yes | `"shell_length_3d"` | `` |
| `ShellStartCpTag` | `String` | Yes | `"shell_start_cp_params"` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.ServiceClasses.TagParsers`

### `NodeSchemeTagParser` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.TagParsers.NodeSchemeTagParser` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnNode node, NodeElevationsCache elevationsCache)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevationText` | `String` | `` | `` |
| `ParseTextString` | `String` | `String s` | `` |

### `PipeSchemeTagParser` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.ServiceClasses.TagParsers.PipeSchemeTagParser` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(PnSegment segment, PlanNodeCacheDict nodeCaches)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ParseTextStringAtEnd` | `String` | `String content` | `` |
| `ParseTextStringAtStart` | `String` | `String content` | `` |

---
## Namespace: `Topomatic.Pipes.Layers.UserEntities`

### `UserDimensionWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.UserEntities.UserDimensionWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.UserEntities.UserEntityWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ICloneableWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`
      - `Topomatic.Pipes.Layers.UserEntities.UserEntityWrapper`
        - `Topomatic.Pipes.Layers.UserEntities.UserDimensionWrapper`

#### Constructors (1)

- `.ctor(IList<UserProfileEntity> collection, DimensionProfileEntity dimension, PipeNetworkCustomFrameLayer layer)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DefinitionPos` | `Vector2D` | `get/set` | No | `Browsable` |
| `EndPosition` | `Vector2D` | `get/set` | No | `` |
| `StartPosition` | `Vector2D` | `get/set` | No | `` |
| `WrappedDimension` | `DimensionProfileEntity` | `get` | No | `Browsable` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetWrapperGrips` | `IEnumerable<IGrip>` | `CadView cadView, TextStandard textStandard, Vector2D offset` | `` |
| `PaintWrapper` | `Void` | `CadPen pen, Double screenRatio, TextStandard textStandard` | `` |
| `ToString` | `String` | `` | `` |
| `TryGetWrapperBounds` | `Boolean` | `Double screenRatio, TextStandard textStandard, ref BoundingBox2D bounds` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDimension` | `Void` | `Double screenRatio, Double annotationHeight, Vector2D p0, Vector2D p1, Vector2D def, Double notchSize, ref List<Vector2D> line, ref Vector2D textPos, ref String text, ref Double angle` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `UserEntityLayouter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.UserEntities.UserEntityLayouter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEntitiesToDrawing` | `Void` | `UserProfileEntity entity, Vector2D scale, Func<Vector2D Vector2D> transform, DwgStyle tagStyle, PipeNetwork network, Drawing drawing` | `` |

### `UserEntityWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Pipes.Layers.UserEntities.UserEntityWrapper` |
| **Base Type** | `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper` |
| **Implements** | `Topomatic.Pipes.IPipeNetworkContainer, Topomatic.Pipes.PnInterfaces.IColoredProfile, Topomatic.Pipes.CadViewTransform.ICloneableWrapper` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Pipes.Layers.PipeNetworkCustomFrameWrapper`
    - `Topomatic.Pipes.Layers.Profile.PipeNetworkProfileWrapper`
      - `Topomatic.Pipes.Layers.UserEntities.UserEntityWrapper`

#### Constructors (1)

- `.ctor(IList<UserProfileEntity> collection, UserProfileEntity entity, PipeNetworkCustomFrameLayer layer)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WrappedEntity` | `UserProfileEntity` | `get` | No | `Browsable` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddInstanceToCollection` | `Void` | `ITransformable item` | `` |
| `CloneWrappedObject` | `ITransformable` | `` | `` |
| `Erase` | `Void` | `` | `` |
| `GetWrapperGrips` | `IEnumerable<IGrip>` | `CadView cadView, TextStandard textStandard, Vector2D offset` | `` |
| `PaintWrapper` | `Void` | `CadPen pen, Double screenRatio, TextStandard textStandard` | `` |
| `TryGetWrapperBounds` | `Boolean` | `Double screenRatio, TextStandard textStandard, ref BoundingBox2D bounds` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Tag` | `Object` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneableWrapper` | `AddInstanceToCollection` |
| `ICloneableWrapper` | `CloneWrappedObject` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 278 |
| **Classes** | 184 |
| **Interfaces** | 6 |
| **Enums** | 2 |
| **Structs** | 23 |
| **Abstract Classes** | 16 |
| **Static Classes** | 47 |
| **Total Methods** | 801 |
| **Total Properties** | 668 |
| **Total Fields** | 378 |
| **Total Events** | 0 |
| **Total Constructors** | 205 |
| **Nested Types** | 27 |
| **Extension Methods** | 0 |


