# Topomatic.Sfc.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sfc.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sfc.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sfc.Layer.dll` |

---
## Namespace: `Topomatic.Sfc.Layer`

### `SurfaceExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.SurfaceExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLayer` | `UInt32` | `Surface surface, xLibraryNode node` | `Extension` |
| `RefreshLineLayer` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshLineSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshPatchLayer` | `Void` | `Surface surface, Int32 handle` | `Extension` |
| `RefreshPatchSign` | `Void` | `Surface surface, Int32 handle` | `Extension` |
| `RefreshPointLayer` | `Void` | `Surface surface, SurfacePointExtensiveInformation information` | `Extension` |
| `RefreshPointLayer` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshPointSign` | `Void` | `Surface surface, SurfacePointExtensiveInformation information` | `Extension` |
| `RefreshPointSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshPolygonLayer` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshPolygonSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshStructureLineLayer` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `RefreshStructureLineSign` | `Void` | `Surface surface, Int32 index` | `Extension` |
| `TranslateExplorationCode` | `Void` | `Surface surface, SurfacePointExtensiveInformation information, ref SurfacePoint pt, String value` | `Extension` |
| `TranslateExplorationCode` | `Void` | `Surface surface, Int32 index, String value` | `Extension` |

### `SurfaceLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.SurfaceLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Sfc.Layer.SurfaceLayer`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `Frozen` | `Boolean` | `get/set` | No | `` |
| `HighlightedCodes` | `Code[]` | `get/set` | No | `` |
| `HorizonalsLayer` | `ILayer` | `get` | No | `` |
| `InclinationsLayer` | `ILayer` | `get` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `LinesLayer` | `ILayer` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PointsLayer` | `ILayer` | `get` | No | `` |
| `ProjectScale` | `Single` | `get` | No | `` |
| `RibsLayer` | `ILayer` | `get` | No | `` |
| `SelectedLinesCount` | `Int32` | `get` | No | `` |
| `SelectedPatchesCount` | `Int32` | `get` | No | `` |
| `SelectedPointsCount` | `Int32` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `Surface` | `Surface` | `get/set` | No | `` |
| `TrianglesLayer` | `ILayer` | `get` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `GetHighlightedPoints` | `IEnumerable<Int32>` | `` | `` |
| `GetSelectedContours` | `IEnumerable<Int32>` | `` | `` |
| `GetSelectedPatches` | `IEnumerable<Int32>` | `` | `` |
| `GetSelectedPoints` | `IEnumerable<Int32>` | `` | `` |
| `GetSelectedStructureLines` | `IEnumerable<Int32>` | `` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `GetTriangleColor` | `Color` | `Int32 index, Color defaultValue, Boolean enable` | `` |
| `IsLineSelected` | `Boolean` | `Int32 index` | `` |
| `IsPatchSelected` | `Boolean` | `Int32 index` | `` |
| `IsPointSelected` | `Boolean` | `Int32 index` | `` |
| `PeakOneStructureLine` | `StructureLine` | `Predicate<Int32> match, String message` | `` |
| `PickOnePoint` | `GetPointResult` | `Predicate<Int32> match, ref Int32 index, String message, String[] args` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |
| `SelectContours` | `GetPointResult` | `Predicate<Int32> match, String message, String[] args` | `` |
| `SelectOnePatch` | `Int32` | `Predicate<Int32> match, String message` | `` |
| `SelectOneStructureLine` | `GetPointResult` | `Predicate<Int32> match, ref StructureLine line, String message, String[] args` | `` |
| `SelectOneStructureLine` | `StructureLine` | `Predicate<Int32> match, String message` | `` |
| `SelectPatches` | `GetPointResult` | `Predicate<Int32> match, String message, String[] args` | `` |
| `SelectPoints` | `GetPointResult` | `Predicate<Int32> match, String message, String[] args` | `` |
| `SelectStructureLines` | `GetPointResult` | `Predicate<Int32> match, String message, String[] args` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSurfaceLayer` | `SurfaceLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetSurfaceLayer` | `SurfaceLayer` | `CadView cadview` | `` |
| `GetSurfaceLayers` | `IEnumerable<SurfaceLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Nested Types (1)

- `SurfaceSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |
| `ISurfaceContainer` | `get_Surface` |

### `SurfaceSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.SurfaceLayer+SurfaceSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Sfc.Layer.SurfaceLayer+SurfaceSelectionSet`

#### Constructors (1)

- `.ctor(SurfaceLayer layer)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsHorizontalSelectable` | `Boolean` | `get/set` | Yes | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (35)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clear` | `Void` | `` | `` |
| `ClearSelectedContours` | `Void` | `` | `` |
| `ClearSelectedHorizontals` | `Void` | `` | `` |
| `ClearSelectedPoints` | `Void` | `` | `` |
| `ClearSelectedStructureLines` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetNearestContourIndexes` | `IEnumerable<KeyValuePair<Double Int32>>` | `Vector3D position, Predicate<Object> match` | `` |
| `GetNearestPointIndexes` | `IEnumerable<KeyValuePair<Double Int32>>` | `Vector3D position, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetNearestStructureLineIndexes` | `IEnumerable<KeyValuePair<Double Int32>>` | `Vector3D position, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtFrustum` | `IEnumerable<KeyValuePair<Vector3D Object>>` | `BoundingFrustum frustum, Predicate<Object> match, Int32 waitTimeOut` | `` |
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
| `IsStructureLineSelected` | `Boolean` | `Int32 index` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `SelectByFrame` | `Boolean` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Boolean select` | `` |
| `SelectPoint` | `Void` | `Int32 index, Boolean select` | `` |
| `SelectStructureLine` | `Void` | `Int32 index, Boolean select` | `` |
| `SelectTriangle` | `Void` | `Int32 index, Boolean select` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Sfc.Layer.Design`

### `SurfaceSituationLineProperties` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Design.SurfaceSituationLineProperties` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SurfaceStructureLineWrapper wrapper)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ElevationBehaviour` | `ElevationBehaviour` | `get/set` | No | `PropertyUpdateSequence, PropertyTypeConverter, SRCategory, SRDisplayName` |
| `PointElevation` | `Double` | `get/set` | No | `Elevation, PropertyUpdateSequence, SRCategory, SRDisplayName` |
| `RelationElevation` | `Double` | `get/set` | No | `Elevation, SRCategory, SRDisplayName, PropertyUpdateSequence` |
| `Wrapper` | `SurfaceStructureLineWrapper` | `get` | No | `Browsable` |

---
## Namespace: `Topomatic.Sfc.Layer.Wrappers`

### `SurfaceObjectWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(SurfaceLayer layer)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layer` | `DwgLayer` | `get/set` | No | `SRDisplayName, PropertyTypeConverter, SRCategory, PropertyEditor` |
| `LayerID` | `UInt32` | `get/set` | No | `Browsable` |
| `Surface` | `Surface` | `get` | No | `Browsable` |
| `SurfaceLayer` | `SurfaceLayer` | `get` | No | `Browsable` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ILayeredObject` | `Topomatic.FoundationClasses.ILayeredObject.get_Layer` |
| `ILayeredObject` | `Topomatic.FoundationClasses.ILayeredObject.set_Layer` |
| `ISurfaceContainer` | `get_Surface` |

### `SurfacePatchWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfacePatchWrapper` |
| **Base Type** | `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.ISimpleDocumentContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper`
    - `Topomatic.Sfc.Layer.Wrappers.SurfacePatchWrapper`

#### Constructors (1)

- `.ctor(SurfaceLayer layer, Int32 handle, List<Int32> list)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Aread2d` | `Double` | `get` | No | `Area, SRDisplayName` |
| `Aread3d` | `Double` | `get` | No | `SRDisplayName, Area` |
| `Color` | `CadColor` | `get/set` | No | `SRDisplayName, PropertyUpdateSequence` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `Handle` | `Int32` | `get` | No | `Browsable` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `LayerID` | `UInt32` | `get/set` | No | `` |
| `List` | `List<Int32>` | `get` | No | `Browsable` |
| `NoHorizontals` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, SRDisplayName, SRCategory` |
| `NoInclinations` | `Boolean` | `get/set` | No | `SRDisplayName, PropertyUpdateSequence, SRCategory` |
| `NoRibs` | `Boolean` | `get/set` | No | `SRCategory, SRDisplayName, PropertyUpdateSequence` |
| `ObjectCode` | `KeyValuePair<Int32 Surface>` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, PropertyEditor, SRCategory, SRDisplayName` |
| `Semantic` | `SemanticDataSet` | `get` | No | `PropertyUpdateSequence, SRCategory` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |

### `SurfacePointWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfacePointWrapper` |
| **Base Type** | `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.IPointObject, Topomatic.FoundationClasses.ISimpleDocumentContainer, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper`
    - `Topomatic.Sfc.Layer.Wrappers.SurfacePointWrapper`

#### Constructors (1)

- `.ctor(SurfaceLayer layer, Int32 index)`

#### Properties (21)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get` | No | `Browsable` |
| `BlockName` | `String` | `get` | No | `ConditionalBrowsable, SRDisplayName, SRCategory` |
| `Bounds` | `BoundingBox2D` | `get` | No | `Browsable` |
| `BoundsInitialized` | `Boolean` | `get` | No | `Browsable` |
| `Description` | `String` | `get/set` | No | `SRCategory, PropertyUpdateSequence, SRDisplayName` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `ExplorationCode` | `String` | `get/set` | No | `SRCategory, PropertyUpdateSequence, SRDisplayName, PropertyEditor` |
| `Extended` | `Boolean` | `get/set` | No | `SRDisplayName, PropertyUpdateSequence, SRCategory` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `HasSign` | `Boolean` | `get` | No | `Browsable` |
| `Index` | `Int32` | `get` | No | `Browsable` |
| `LayerID` | `UInt32` | `get/set` | No | `` |
| `Locked` | `Boolean` | `get/set` | No | `SRDisplayName, SRCategory, PropertyUpdateSequence` |
| `Number` | `String` | `get/set` | No | `SRCategory, PropertyUpdateSequence, SRDisplayName` |
| `ObjectCode` | `KeyValuePair<Int32 Surface>` | `get/set` | No | `PropertyEditor, PropertyUpdateSequence, SRDisplayName, PropertyTypeConverter, SRCategory` |
| `Rotation` | `Double` | `get/set` | No | `SRCategory, SRDisplayName, Angle, PropertyTypeConverter, PropertyUpdateSequence` |
| `Scale` | `Double` | `get/set` | No | `DefaultDouble, SRDisplayName, PropertyUpdateSequence, SRCategory` |
| `Semantic` | `SemanticDataSet` | `get` | No | `PropertyUpdateSequence, SRCategory` |
| `ShowLeader` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, SRCategory, SRDisplayName` |
| `Situation` | `Boolean` | `get/set` | No | `PropertyUpdateSequence, SRDisplayName, SRCategory` |
| `Vertex` | `Vector3D` | `get/set` | No | `PropertyUpdateSequence, SRCategory, SRDisplayName` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
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
| `IPointObject` | `get_BasePoint` |
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `SurfacePolygonWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfacePolygonWrapper` |
| **Base Type** | `Topomatic.Sfc.Layer.Wrappers.SurfaceStructureLineWrapper` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Sfc.StructureLine, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.ILinearObject, Topomatic.FoundationClasses.ISimpleDocumentContainer, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IColoredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper`
    - `Topomatic.Sfc.Layer.Wrappers.SurfaceStructureLineWrapper`
      - `Topomatic.Sfc.Layer.Wrappers.SurfacePolygonWrapper`

#### Constructors (1)

- `.ctor(SurfaceLayer layer, Int32 index)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AreaObjectCode` | `KeyValuePair<Int32 Surface>` | `get/set` | No | `PropertyTypeConverter, PropertyUpdateSequence, PropertyEditor, SRDisplayName, SRCategory` |
| `AreaSemantic` | `SemanticDataSet` | `get` | No | `PropertyUpdateSequence, SRCategory` |
| `Density` | `Int32` | `get/set` | No | `PropertyUpdateSequence, SRCategory, SRDisplayName` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |

### `SurfaceStructureLineWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfaceStructureLineWrapper` |
| **Base Type** | `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Sfc.StructureLine, Topomatic.Sfc, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.ILinearObject, Topomatic.FoundationClasses.ISimpleDocumentContainer, Topomatic.FoundationClasses.INamedObject, Topomatic.Cad.Foundation.IColoredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper`
    - `Topomatic.Sfc.Layer.Wrappers.SurfaceStructureLineWrapper`

#### Constructors (1)

- `.ctor(SurfaceLayer layer, Int32 index)`

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area2D` | `Double` | `get` | No | `Length, SRCategory, SRDisplayName` |
| `Closed` | `Boolean` | `get/set` | No | `SRCategory, PropertyUpdateSequence, SRDisplayName` |
| `Color` | `CadColor` | `get/set` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `SRCategory, SRDisplayName` |
| `CurrentVertexIndex` | `Int32` | `get/set` | No | `PropertyUpdateSequence, SRCategory, PropertyEditor, SRDisplayName` |
| `Description` | `String` | `get/set` | No | `SRCategory, SRDisplayName` |
| `Documents` | `String` | `get/set` | No | `Browsable` |
| `HasDocuments` | `Boolean` | `get` | No | `Browsable` |
| `Index` | `Int32` | `get` | No | `Browsable` |
| `LayerID` | `UInt32` | `get/set` | No | `` |
| `Length2D` | `Double` | `get` | No | `SRCategory, Length, SRDisplayName` |
| `Length3D` | `Double` | `get` | No | `Length, SRDisplayName, SRCategory` |
| `Limitation` | `Boolean` | `get/set` | No | `SRDisplayName, SRCategory, PropertyUpdateSequence` |
| `Line` | `StructureLine` | `get` | No | `Browsable` |
| `LinearObjectCode` | `KeyValuePair<Int32 Surface>` | `get/set` | No | `SRDisplayName, PropertyEditor, PropertyTypeConverter, PropertyUpdateSequence, SRCategory` |
| `LinearSemantic` | `SemanticDataSet` | `get` | No | `SRCategory, PropertyUpdateSequence` |
| `Name` | `String` | `get/set` | No | `Browsable` |
| `SutuationProperties` | `SurfaceSituationLineProperties` | `get` | No | `PropertyProvider` |
| `Vertex` | `Vector3D` | `get/set` | No | `SRCategory, SRDisplayName, PropertyUpdateSequence` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IWrapped`1` | `Topomatic.FoundationClasses.IWrapped<Topomatic.Sfc.StructureLine>.get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `ILinearObject` | `GetPolyline` |
| `ISimpleDocumentContainer` | `get_Documents` |
| `ISimpleDocumentContainer` | `set_Documents` |
| `ISimpleDocumentContainer` | `get_HasDocuments` |
| `INamedObject` | `get_Name` |
| `INamedObject` | `set_Name` |
| `IColoredObject` | `get_Color` |
| `IColoredObject` | `set_Color` |

### `SurfaceTriangleWrapper` (class)

**Attributes**: [DesignAlias]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sfc.Layer.Wrappers.SurfaceTriangleWrapper` |
| **Base Type** | `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.ILayeredObject, Topomatic.Sfc.ISurfaceContainer, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Sfc.Layer.Wrappers.SurfaceObjectWrapper`
    - `Topomatic.Sfc.Layer.Wrappers.SurfaceTriangleWrapper`

#### Constructors (1)

- `.ctor(SurfaceLayer layer, Int32 index)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Contour` | `SurfaceTriangle` | `get` | No | `Browsable` |
| `FirstPoint` | `Vector3D` | `get/set` | No | `SRCategory, SRDisplayName` |
| `Inclination` | `Double` | `get` | No | `SRDisplayName, DefaultDouble` |
| `Index` | `Int32` | `get` | No | `Browsable` |
| `LayerID` | `UInt32` | `get/set` | No | `` |
| `SecondPoint` | `Vector3D` | `get/set` | No | `SRDisplayName, SRCategory` |
| `ThirdPoint` | `Vector3D` | `get/set` | No | `SRCategory, SRDisplayName` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
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
| `IBoundedObject` | `Topomatic.Cad.Foundation.IBoundedObject.get_Bounds` |
| `IBoundedObject` | `Topomatic.Cad.Foundation.IBoundedObject.get_BoundsInitialized` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 10 |
| **Classes** | 8 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 1 |
| **Static Classes** | 1 |
| **Total Methods** | 109 |
| **Total Properties** | 95 |
| **Total Fields** | 1 |
| **Total Events** | 0 |
| **Total Constructors** | 10 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


