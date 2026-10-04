# Topomatic.Dwg.Layer

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Dwg.Layer` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Dwg.Layer, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Dwg.Layer.dll` |

---
## Namespace: `Topomatic.Dwg.Layer`

### `DrawingLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DrawingLayer` |
| **Base Type** | `Topomatic.Cad.View.CadViewLayer` |
| **Implements** | `System.IDisposable, Topomatic.FoundationClasses.ILayer, Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.ILayerActivityController, Topomatic.Dwg.IDrawingContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.CadViewLayer`
    - `Topomatic.Dwg.Layer.DrawingLayer`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String name)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ActiveLayer` | `ILayer` | `get/set` | No | `` |
| `ActiveLayout` | `DwgLayout` | `get/set` | No | `` |
| `Drawing` | `Drawing` | `get/set` | No | `` |
| `LayerGuid` | `Guid` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `PasteAsBlock` | `Boolean` | `get/set` | No | `` |
| `SelectedEntityIndexes` | `IEnumerable<Int32>` | `get` | No | `` |
| `SelectedEntitys` | `IEnumerable<DwgEntity>` | `get` | No | `` |
| `SelectionSet` | `SelectionSet` | `get` | No | `` |
| `SortedSelectedEntitys` | `IEnumerable<DwgEntity>` | `get` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AboveObject` | `Void` | `` | `` |
| `BringTextToFront` | `Void` | `Boolean text, Boolean dimension` | `` |
| `BringToFront` | `Void` | `` | `` |
| `ClearDisabledEntitys` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `ExtractAllArcSegments` | `Void` | `DwgEntity entity, List<ArcSegment> list` | `` |
| `ExtractArcSegment` | `Boolean` | `DwgEntity entity, Vector3D point, ref ArcSegment arc` | `` |
| `ExtractLineSegment` | `Boolean` | `DwgEntity entity, Vector3D point, ref LineSegment line` | `` |
| `GetSubLayers` | `IEnumerable<ILayer>` | `` | `` |
| `PickArc` | `Boolean` | `Predicate<DwgEntity> match, ref ArcSegment arc, String message` | `` |
| `PickLine` | `Boolean` | `Predicate<DwgEntity> match, ref LineSegment line, String message` | `` |
| `PickOneEntity` | `GetPointResult` | `Predicate<DwgEntity> match, ref DwgEntity entity, String message, String[] args` | `` |
| `PickOneEntity` | `DwgEntity` | `Predicate<DwgEntity> match, String message` | `` |
| `RemoveLayer` | `Boolean` | `ILayer layer` | `` |
| `SelectEntities` | `GetPointResult` | `Predicate<DwgEntity> match, String message, String[] args` | `` |
| `SelectEntities` | `Boolean` | `Predicate<DwgEntity> match, String message` | `` |
| `SelectOneEntity` | `GetPointResult` | `Predicate<DwgEntity> match, ref DwgEntity entity, String message, String[] args` | `` |
| `SelectOneEntity` | `DwgEntity` | `Predicate<DwgEntity> match, String message` | `` |
| `SendToBack` | `Void` | `` | `` |
| `UnderObject` | `Void` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDrawingLayer` | `DrawingLayer` | `CadView cadview, Boolean readOnly` | `` |
| `GetDrawingLayer` | `DrawingLayer` | `CadView cadview` | `` |
| `GetDrawingLayers` | `IEnumerable<DrawingLayer>` | `CadView cadview` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Guid` | `Guid` | Yes | `` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `LayerOverride` | `EventHandler` | No | `` |

#### Nested Types (1)

- `DrawingSelectionSet` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `ILayer` | `get_Name` |
| `ILayer` | `GetSubLayers` |
| `ILayerActivityController` | `get_ActiveLayer` |
| `ILayerActivityController` | `set_ActiveLayer` |
| `ILayerActivityController` | `RemoveLayer` |
| `IDrawingContainer` | `get_Drawing` |

### `DrawingSelectionSet` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DrawingLayer+DrawingSelectionSet` |
| **Base Type** | `Topomatic.Cad.View.SelectionSet` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.SelectionSet`
    - `Topomatic.Dwg.Layer.DrawingLayer+DrawingSelectionSet`

#### Constructors (1)

- `.ctor(DrawingLayer layer)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `SupportClipboard` | `Boolean` | `get` | No | `` |
| `SupportTransform` | `Boolean` | `get` | No | `` |

#### Instance Methods (28)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Align` | `Void` | `Object data, Vector2D sourceA, Vector2D sourceB, Vector2D destA, Vector2D destB, Boolean scale, Boolean copy` | `` |
| `Clear` | `Void` | `` | `` |
| `CopyProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Erase` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `GetIndexesAtPoint` | `IEnumerable<KeyValuePair<Double Int32>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetIndexesByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Int32> action` | `` |
| `GetObjectGrips` | `IEnumerable<IGrip>` | `Object obj` | `` |
| `GetObjectsAtPoint` | `IEnumerable<KeyValuePair<Double Object>>` | `Vector3D point, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsAtRay` | `IEnumerable<KeyValuePair<Double Object>>` | `Ray3D ray, Predicate<Object> match, Int32 waitTimeOut` | `` |
| `GetObjectsByFrame` | `Void` | `FrameSelectType mode, RectangleD rect, Predicate<Object> match, Action<Object> action` | `` |
| `GetObjectsByPolygon` | `Void` | `FrameSelectType mode, List<Vector2D> pointsList, Predicate<Object> match, Action<Object> action` | `` |
| `GetSelectable` | `IEnumerable` | `` | `` |
| `GetTransformData` | `Object` | `` | `` |
| `IsEnable` | `Boolean` | `Object obj` | `` |
| `IsOwned` | `Boolean` | `Object obj` | `` |
| `IsSelected` | `Boolean` | `Object obj` | `` |
| `Mirror` | `Void` | `Object data, Vector2D a, Vector2D b, Boolean copy` | `` |
| `Move` | `Void` | `Object data, Double x, Double y, Double z, Boolean copy` | `` |
| `PaintTransformData` | `Void` | `Object data, CadPen pen` | `` |
| `PasteProperties` | `Void` | `Object obj, StgNode data` | `` |
| `Rotate` | `Void` | `Object data, Vector2D basePoint, Double rotationAngle, Boolean copy` | `` |
| `Scale` | `Void` | `Object data, Vector2D basePoint, Double scaleFactorX, Double scaleFactorY, Boolean copy` | `` |
| `Select` | `Void` | `IEnumerable pSelSet, Boolean bFlag` | `` |
| `Select` | `Void` | `Object item, Boolean bFlag` | `` |
| `SupportCopyProperties` | `Boolean` | `Object obj` | `` |
| `SupportPasteProperties` | `Boolean` | `Object obj, StgNode data` | `` |
| `Transform` | `Void` | `Object data, Matrix transform, Boolean copy` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `DwgAlignmentPolylineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgAlignmentPolylineController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgDynamicPolylineController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgDynamicPolylineController`
      - `Topomatic.Dwg.Layer.DwgAlignmentPolylineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgArcController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgArcController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgArcController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgCircleController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgCircleController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgCircleController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgClothoidController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgClothoidController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgClothoidController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgComplexEntityController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DwgConnectedPolylineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgConnectedPolylineController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgDynamicPolylineController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgDynamicPolylineController`
      - `Topomatic.Dwg.Layer.DwgConnectedPolylineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDimensionAngularController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDimensionAngularController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgDimensionAngularController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDimensionOrdinateController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDimensionOrdinateController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgDimensionOrdinateController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDimensionRadialLargeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDimensionRadialLargeController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgDimensionRadialLargeController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDimensionRadiusController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDimensionRadiusController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgDimensionRadiusController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDimensionRotatedController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDimensionRotatedController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgDimensionRotatedController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgDynamicPolylineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgDynamicPolylineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgDynamicPolylineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `DwgEllipseController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgEllipseController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgEllipseController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgFaceController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgFaceController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgFaceController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgHatchController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgHatchController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgHatchController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgImageController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgImageController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgImageController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgInsertController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgInsertController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgInsertController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetAttribs` | `IEnumerable<DwgEntity>` | `DwgInsert e` | `` |
| `GetEntitiesWithoutAttributes` | `IEnumerable<DwgEntity>` | `DwgEntities entities` | `` |
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgLeaderController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgLeaderController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgComplexEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgComplexEntityController`
      - `Topomatic.Dwg.Layer.DwgLeaderController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgLineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgLineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgLineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgMLineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgMLineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgMLineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgMTextController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgMTextController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgMTextController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgOffsetedPolylineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgOffsetedPolylineController` |
| **Base Type** | `Topomatic.Dwg.Layer.DwgDynamicPolylineController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgDynamicPolylineController`
      - `Topomatic.Dwg.Layer.DwgOffsetedPolylineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgPointController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgPointController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgPointController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgPolyline3DController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgPolyline3DController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgPolyline3DController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgPolylineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgPolylineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgPolylineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgRayController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgRayController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgRayController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgShapeController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgShapeController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgShapeController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgSolidController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgSolidController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgSolidController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgSplineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgSplineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgSplineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgTextController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgTextController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgTextController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgViewportController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgViewportController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgViewportController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PaintSubstrait` | `Void` | `DwgViewport vport, PaintEntityEventArgs args` | `` |

### `DwgWipeoutController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgWipeoutController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgWipeoutController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `DwgXLineController` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.DwgXLineController` |
| **Base Type** | `Topomatic.Dwg.DwgEntityController` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Dwg.DwgEntityController`
    - `Topomatic.Dwg.Layer.DwgXLineController`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetGrips` | `IEnumerable` | `DwgEntity entity, Object cadview` | `` |

### `EntityGrip` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.EntityGrip` |
| **Base Type** | `Topomatic.Cad.View.Grip` |
| **Implements** | `Topomatic.Cad.View.IGrip` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.View.Grip`
    - `Topomatic.Dwg.Layer.EntityGrip`

#### Constructors (1)

- `.ctor(CadView cadview, DwgEntity entity)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `OnDynamicRender` | `Void` | `DeviceContext dc, Vector3D vertex` | `` |
| `OnMove` | `Void` | `Vector3D vertex` | `` |
| `OnPaint` | `Void` | `PaintGripEventArgs e` | `` |
| `PerformMove` | `Void` | `Vector3D vertex` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Auxiliary` | `DrawCursorEvent` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IGrip` | `OnPaint` |

### `GripPaintAuxiliaryEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.GripPaintAuxiliaryEventArgs` |
| **Base Type** | `Topomatic.Dwg.Layer.PaintAuxiliaryEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Dwg.Layer.PaintAuxiliaryEventArgs`
      - `Topomatic.Dwg.Layer.GripPaintAuxiliaryEventArgs`

#### Constructors (1)

- `.ctor(CadPen pen, Int32 index)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get` | No | `` |

### `PaintAuxiliaryEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Dwg.Layer.PaintAuxiliaryEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Dwg.Layer.PaintAuxiliaryEventArgs`

#### Constructors (1)

- `.ctor(CadPen pen)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Pen` | `CadPen` | `get` | No | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 38 |
| **Classes** | 38 |
| **Interfaces** | 0 |
| **Enums** | 0 |
| **Structs** | 0 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 89 |
| **Total Properties** | 15 |
| **Total Fields** | 1 |
| **Total Events** | 2 |
| **Total Constructors** | 39 |
| **Nested Types** | 1 |
| **Extension Methods** | 0 |


