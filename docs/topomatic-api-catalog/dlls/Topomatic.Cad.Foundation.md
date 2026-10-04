# Topomatic.Cad.Foundation

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Cad.Foundation` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Cad.Foundation.dll` |

---
## Namespace: `Topomatic.Cad.Foundation`

### `AngleConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ValueConverter+AngleConverter` |
| **Base Type** | `Topomatic.Cad.Foundation.ValueConverter+BaseFloatConverter` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ValueConverter+BaseFloatConverter`
    - `Topomatic.Cad.Foundation.ValueConverter+AngleConverter`

#### Constructors (1)

- `.ctor(Int32 digits)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleUnit` | `AngleUnits` | `get/set` | No | `` |
| `Digits` | `Int32` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToStr` | `String` | `Double value, Int32 digits, AngleUnits units, Boolean showZeroFeet, String format` | `` |
| `AngleToStr` | `String` | `Double value, Int32 digits` | `` |
| `AngleToStr` | `String` | `Double value` | `` |
| `StrToAngle` | `Double` | `String value` | `` |
| `TryStrToAngle` | `Boolean` | `String value, ref Double result` | `` |

### `AngleUnits` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.AngleUnits` |
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
      - `Topomatic.Cad.Foundation.AngleUnits`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Degrees` | `AngleUnits` | Yes | `Degrees` | `` |
| `DegreMinuteSeconds` | `AngleUnits` | Yes | `DegreMinuteSeconds` | `` |
| `Grads` | `AngleUnits` | Yes | `Grads` | `` |
| `Radians` | `AngleUnits` | Yes | `Radians` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Degrees` | `0` |
| `DegreMinuteSeconds` | `1` |
| `Grads` | `2` |
| `Radians` | `3` |

**Underlying Type**: `System.Int32`

### `ArcItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+ArcItem` |
| **Base Type** | `Topomatic.Cad.Foundation.CompoundLine+Item` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.CompoundLine+Item`
      - `Topomatic.Cad.Foundation.CompoundLine+ArcItem`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Center` | `Vector2D` | `get` | No | `` |
| `CounterClockwise` | `Boolean` | `get` | No | `` |
| `EndAngle` | `Double` | `get` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `ItemType` | `get` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `StartAngle` | `Double` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double sta, Double offset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `ArcSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ArcSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.ArcSegment`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `Vector3D` | No | `` | `` |
| `EndAngle` | `Double` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |
| `StartAngle` | `Double` | No | `` | `` |

### `ArrayMode` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ArrayMode` |
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
      - `Topomatic.Cad.Foundation.ArrayMode`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Point` | `ArrayMode` | Yes | `Point` | `` |
| `Polygon` | `ArrayMode` | Yes | `Polygon` | `` |
| `Polyline` | `ArrayMode` | Yes | `Polyline` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Polyline` | `0` |
| `Polygon` | `1` |
| `Point` | `2` |

**Underlying Type**: `System.Int32`

### `BaseFloatConverter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ValueConverter+BaseFloatConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DecimalSeparator` | `Char` | `get/set` | Yes | `` |
| `FormatProvider` | `IFormatProvider` | `get` | No | `` |

### `BaseOverlayOperation` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BaseOverlayOperation` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.BaseOverlayOperation`

### `BentleyOttmanSegment` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BentleyOttmanSegment` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector2D start, Vector2D end)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `End` | `Vector2D` | No | `` | `` |
| `Start` | `Vector2D` | No | `` | `` |

### `BoundingBox2D` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BoundingBox2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BoundingBox2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BoundingBox2D`

#### Constructors (1)

- `.ctor(Vector2D min, Vector2D max)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Double` | `get/set` | No | `` |
| `BottomLeft` | `Vector2D` | `get` | No | `` |
| `BottomRight` | `Vector2D` | `get` | No | `` |
| `Center` | `Vector2D` | `get/set` | No | `` |
| `Empty` | `BoundingBox2D` | `get` | Yes | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `Infinity` | `BoundingBox2D` | `get` | Yes | `` |
| `IsInfinity` | `Boolean` | `get` | No | `` |
| `IsNan` | `Boolean` | `get` | No | `` |
| `Left` | `Double` | `get/set` | No | `` |
| `Right` | `Double` | `get/set` | No | `` |
| `Top` | `Double` | `get/set` | No | `` |
| `TopLeft` | `Vector2D` | `get` | No | `` |
| `TopRight` | `Vector2D` | `get` | No | `` |
| `Width` | `Double` | `get/set` | No | `` |

#### Instance Methods (32)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `Vector2D point` | `` |
| `ClipBox` | `Boolean` | `ref BoundingBox2D box` | `` |
| `ClipLine` | `Boolean` | `Line2D line` | `` |
| `ClipLine` | `Boolean` | `Line2D line, ref Vector2D a, ref Vector2D b` | `` |
| `ClipRay` | `Boolean` | `Ray2D ray, ref Vector2D a, ref Vector2D b` | `` |
| `ClipRay` | `Boolean` | `Ray2D ray` | `` |
| `ClipSegment` | `Boolean` | `Vector2D a, Vector2D b` | `` |
| `ClipSegment` | `Boolean` | `ref Vector2D a, ref Vector2D b` | `` |
| `Contains` | `Void` | `ref BoundingSphere2D sphere, ref ContainmentType result` | `` |
| `Contains` | `Void` | `ref BoundingBox2D box, ref ContainmentType result` | `` |
| `Contains` | `Void` | `ref Vector2D point, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingBox2D box` | `` |
| `Contains` | `ContainmentType` | `BoundingSphere2D sphere` | `` |
| `Contains` | `ContainmentType` | `Vector2D point` | `` |
| `EqualEps` | `Boolean` | `BoundingBox2D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `BoundingBox2D other` | `` |
| `GetCorners` | `Void` | `Vector2D[] corners` | `` |
| `GetCorners` | `Vector2D[]` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Inflate` | `Void` | `Double dX, Double dY` | `` |
| `Intersects` | `Void` | `ref BoundingSphere2D sphere, ref Boolean result` | `` |
| `Intersects` | `Void` | `ref BoundingBox2D box, ref Boolean result` | `` |
| `Intersects` | `Boolean` | `BoundingBox2D box` | `` |
| `Intersects` | `Boolean` | `BoundingSphere2D sphere` | `` |
| `Move` | `Void` | `Double dX, Double dY` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToRectangle` | `Rectangle` | `` | `` |
| `ToRectangleD` | `RectangleD` | `` | `` |
| `ToRectangleF` | `RectangleF` | `` | `` |
| `ToString` | `String` | `` | `` |
| `Transform` | `Void` | `ref Matrix matrix, ref BoundingBox2D result` | `` |

#### Static Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `BoundingBox2D` | `BoundingBox2D box, Vector2D point` | `` |
| `AddPoint` | `Void` | `ref BoundingBox2D box, ref Vector2D point, ref BoundingBox2D result` | `` |
| `CreateFromPoints` | `BoundingBox2D` | `Vector2D[] points` | `` |
| `CreateFromPoints` | `BoundingBox2D` | `IEnumerable<Vector2D> points` | `` |
| `CreateFromRectangle` | `BoundingBox2D` | `Rectangle rect` | `` |
| `CreateFromRectangleF` | `BoundingBox2D` | `RectangleF rect` | `` |
| `CreateFromSphere` | `Void` | `ref BoundingSphere2D sphere, ref BoundingBox2D result` | `` |
| `CreateFromSphere` | `BoundingBox2D` | `BoundingSphere2D sphere` | `` |
| `CreateMerged` | `Void` | `ref BoundingBox2D original, ref BoundingBox2D additional, ref BoundingBox2D result` | `` |
| `CreateMerged` | `BoundingBox2D` | `BoundingBox2D original, BoundingBox2D additional` | `` |
| `LoadFromStg` | `BoundingBox2D` | `StgNode stgNode` | `` |
| `LoadFromStg` | `BoundingBox2D` | `StgNode stgNode, BoundingBox2D def` | `` |
| `Transform` | `BoundingBox2D` | `BoundingBox2D box, Matrix matrix` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CornerCount` | `Int32` | Yes | `4` | `` |
| `Max` | `Vector2D` | No | `` | `` |
| `Min` | `Vector2D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BoundingBox3D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BoundingBox3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BoundingBox3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BoundingBox3D`

#### Constructors (1)

- `.ctor(Vector3D min, Vector3D max)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Double` | `get/set` | No | `` |
| `Center` | `Vector3D` | `get` | No | `` |
| `Depth` | `Double` | `get` | No | `` |
| `Empty` | `BoundingBox3D` | `get` | Yes | `` |
| `Far` | `Double` | `get/set` | No | `` |
| `Height` | `Double` | `get` | No | `` |
| `Left` | `Double` | `get/set` | No | `` |
| `Near` | `Double` | `get/set` | No | `` |
| `Right` | `Double` | `get/set` | No | `` |
| `Top` | `Double` | `get/set` | No | `` |
| `Width` | `Double` | `get` | No | `` |

#### Instance Methods (36)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `Vector3D point` | `` |
| `ClipLine` | `Boolean` | `Line3D line, ref Vector3D a, ref Vector3D b` | `` |
| `ClipLine` | `Boolean` | `Line3D line` | `` |
| `ClipRay` | `Boolean` | `Ray3D ray` | `` |
| `ClipRay` | `Boolean` | `Ray3D ray, ref Vector3D a, ref Vector3D b` | `` |
| `ClipSegment` | `Boolean` | `ref Vector3D a, ref Vector3D b` | `` |
| `ClipSegment` | `Boolean` | `Vector3D a, Vector3D b` | `` |
| `Contains` | `ContainmentType` | `Vector3D point` | `` |
| `Contains` | `Void` | `ref BoundingBox3D box, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingBox3D box` | `` |
| `Contains` | `Void` | `ref Vector3D point, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingSphere3D sphere` | `` |
| `Contains` | `Void` | `ref BoundingSphere3D sphere, ref ContainmentType result` | `` |
| `Contains2d` | `ContainmentType` | `Vector3D point` | `` |
| `Contains2d` | `ContainmentType` | `BoundingBox3D box` | `` |
| `Contains2d` | `ContainmentType` | `BoundingSphere3D sphere` | `` |
| `Equals` | `Boolean` | `BoundingBox3D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `EqualsWithEps` | `Boolean` | `BoundingBox3D other, Double squaredEps` | `` |
| `EqualsWithEps` | `Boolean` | `BoundingBox3D other` | `` |
| `GetCorners` | `Void` | `Vector3D[] corners` | `` |
| `GetCorners` | `Vector3D[]` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersects` | `Boolean` | `Vector3D a, Vector3D b, Vector3D c` | `` |
| `Intersects` | `Nullable<Double>` | `Ray3D ray` | `` |
| `Intersects` | `PlaneIntersectionType` | `Plane plane` | `` |
| `Intersects` | `Void` | `ref BoundingSphere3D sphere, ref Boolean result` | `` |
| `Intersects` | `Boolean` | `BoundingSphere3D sphere` | `` |
| `Intersects` | `Void` | `ref BoundingBox3D box, ref Boolean result` | `` |
| `Intersects` | `Void` | `ref Ray3D ray, ref Nullable<Double> result` | `` |
| `Intersects` | `Boolean` | `BoundingBox3D box` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `To2d` | `BoundingBox2D` | `` | `` |
| `ToString` | `String` | `` | `` |
| `Transform` | `BoundingBox3D` | `Matrix matrix` | `` |
| `Transform` | `Void` | `ref Matrix matrix, ref BoundingBox3D result` | `` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPoint` | `Void` | `ref BoundingBox3D box, ref Vector3D point, ref BoundingBox3D result` | `` |
| `AddPoint` | `BoundingBox3D` | `BoundingBox3D box, Vector3D point` | `` |
| `CreateFromPoints` | `BoundingBox3D` | `IEnumerable<Vector3D> points` | `` |
| `CreateFromSphere` | `Void` | `ref BoundingSphere3D sphere, ref BoundingBox3D result` | `` |
| `CreateFromSphere` | `BoundingBox3D` | `BoundingSphere3D sphere` | `` |
| `CreateMerged` | `Void` | `ref BoundingBox3D original, ref BoundingBox3D additional, ref BoundingBox3D result` | `` |
| `CreateMerged` | `BoundingBox3D` | `BoundingBox3D original, BoundingBox3D additional` | `` |
| `LoadFromStg` | `BoundingBox3D` | `StgNode stgNode` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CornerCount` | `Int32` | Yes | `8` | `` |
| `Max` | `Vector3D` | No | `` | `` |
| `Min` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BoundingFrustum` (class)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BoundingFrustum` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BoundingFrustum, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(Vector3D[] corners)`
- `.ctor(Matrix value)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Plane` | `get` | No | `` |
| `Far` | `Plane` | `get` | No | `` |
| `FarCenter` | `Vector3D` | `get` | No | `` |
| `IsOrtho` | `Boolean` | `get` | No | `` |
| `IsPerspective` | `Boolean` | `get` | No | `` |
| `Left` | `Plane` | `get` | No | `` |
| `Matrix` | `Matrix` | `get/set` | No | `` |
| `Near` | `Plane` | `get` | No | `` |
| `NearCenter` | `Vector3D` | `get` | No | `` |
| `Right` | `Plane` | `get` | No | `` |
| `Top` | `Plane` | `get` | No | `` |

#### Instance Methods (23)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clip` | `Boolean` | `ref Vector3D a, ref Vector3D b` | `` |
| `Contains` | `Void` | `ref Vector3D point, ref ContainmentType result` | `` |
| `Contains` | `Void` | `ref BoundingBox3D box, ref ContainmentType result` | `` |
| `Contains` | `Void` | `ref BoundingSphere3D sphere, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingFrustum frustum` | `` |
| `Contains` | `ContainmentType` | `BoundingBox3D box` | `` |
| `Contains` | `ContainmentType` | `Vector3D point` | `` |
| `Contains` | `ContainmentType` | `BoundingSphere3D sphere` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `BoundingFrustum other` | `` |
| `GetCorners` | `Void` | `Vector3D[] corners` | `` |
| `GetCorners` | `Vector3D[]` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersects` | `Void` | `ref BoundingSphere3D sphere, ref Boolean result` | `` |
| `Intersects` | `Void` | `ref BoundingBox3D box, ref Boolean result` | `` |
| `Intersects` | `Void` | `ref Ray3D ray, ref Nullable<Double> result` | `` |
| `Intersects` | `Void` | `ref Plane plane, ref PlaneIntersectionType result` | `` |
| `Intersects` | `Nullable<Double>` | `Ray3D ray` | `` |
| `Intersects` | `Boolean` | `BoundingFrustum frustum` | `` |
| `Intersects` | `Boolean` | `BoundingBox3D box` | `` |
| `Intersects` | `PlaneIntersectionType` | `Plane plane` | `` |
| `Intersects` | `Boolean` | `BoundingSphere3D sphere` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CornerCount` | `Int32` | Yes | `8` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BoundingSphere2D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BoundingSphere2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BoundingSphere2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BoundingSphere2D`

#### Constructors (1)

- `.ctor(Vector2D center, Double radius)`

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Void` | `ref Vector2D point, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingBox2D box` | `` |
| `Contains` | `Void` | `ref BoundingBox2D box, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `Vector2D point` | `` |
| `Contains` | `ContainmentType` | `BoundingSphere2D sphere` | `` |
| `Contains` | `Void` | `ref BoundingSphere2D sphere, ref ContainmentType result` | `` |
| `Equals` | `Boolean` | `BoundingSphere2D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersects` | `Void` | `ref BoundingBox2D box, ref Boolean result` | `` |
| `Intersects` | `Boolean` | `BoundingBox2D box` | `` |
| `Intersects` | `Void` | `ref BoundingSphere2D sphere, ref Boolean result` | `` |
| `Intersects` | `Boolean` | `BoundingSphere2D sphere` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromBoundingBox` | `Void` | `ref BoundingBox2D box, ref BoundingSphere2D result` | `` |
| `CreateFromBoundingBox` | `BoundingSphere2D` | `BoundingBox2D box` | `` |
| `CreateFromPoints` | `BoundingSphere2D` | `IEnumerable<Vector2D> points` | `` |
| `CreateMerged` | `Void` | `ref BoundingSphere2D original, ref BoundingSphere2D additional, ref BoundingSphere2D result` | `` |
| `CreateMerged` | `BoundingSphere2D` | `BoundingSphere2D original, BoundingSphere2D additional` | `` |
| `LoadFromStg` | `BoundingSphere2D` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `Vector2D` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BoundingSphere3D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BoundingSphere3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BoundingSphere3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BoundingSphere3D`

#### Constructors (1)

- `.ctor(Vector3D center, Double radius)`

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Void` | `ref Vector3D point, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `Vector3D point` | `` |
| `Contains` | `Void` | `ref BoundingBox3D box, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingBox3D box` | `` |
| `Contains` | `Void` | `ref BoundingSphere3D sphere, ref ContainmentType result` | `` |
| `Contains` | `ContainmentType` | `BoundingSphere3D sphere` | `` |
| `Equals` | `Boolean` | `BoundingSphere3D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersects` | `Void` | `ref BoundingSphere3D sphere, ref Boolean result` | `` |
| `Intersects` | `Boolean` | `BoundingBox3D box` | `` |
| `Intersects` | `Boolean` | `BoundingSphere3D sphere` | `` |
| `Intersects` | `Void` | `ref BoundingBox3D box, ref Boolean result` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |
| `Transform` | `Void` | `ref Matrix matrix, ref BoundingSphere3D result` | `` |
| `Transform` | `BoundingSphere3D` | `Matrix matrix` | `` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateFromBoundingBox` | `Void` | `ref BoundingBox3D box, ref BoundingSphere3D result` | `` |
| `CreateFromBoundingBox` | `BoundingSphere3D` | `BoundingBox3D box` | `` |
| `CreateFromPoints` | `BoundingSphere3D` | `IEnumerable<Vector3D> points` | `` |
| `CreateMerged` | `Void` | `ref BoundingSphere3D original, ref BoundingSphere3D additional, ref BoundingSphere3D result` | `` |
| `CreateMerged` | `BoundingSphere3D` | `BoundingSphere3D original, BoundingSphere3D additional` | `` |
| `LoadFromStg` | `BoundingSphere3D` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Center` | `Vector3D` | No | `` | `` |
| `Radius` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BrushStyle` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BrushStyle` |
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
      - `Topomatic.Cad.Foundation.BrushStyle`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BlackDashed` | `BrushStyle` | Yes | `BlackDashed` | `` |
| `Dashed` | `BrushStyle` | Yes | `Dashed` | `` |
| `Solid` | `BrushStyle` | Yes | `Solid` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Xor` | `BrushStyle` | Yes | `Xor` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Solid` | `0` |
| `Dashed` | `1` |
| `BlackDashed` | `2` |
| `Xor` | `4` |

**Underlying Type**: `System.Int32`

### `BugleVector2D` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BugleVector2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BugleVector2D`

#### Constructors (2)

- `.ctor(Vector2D vertex)`
- `.ctor(Vector2D vertex, Single bugle)`

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualEps` | `Boolean` | `BugleVector2D other` | `` |
| `EqualEps` | `Boolean` | `BugleVector2D other, Double squaredEps` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `BugleVector2D other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `BugleVector2D` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bugle` | `Single` | No | `` | `` |
| `Vertex` | `Vector2D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `BugleVector3D` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.BugleVector3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.BugleVector3D`

#### Constructors (2)

- `.ctor(Vector3D vertex)`
- `.ctor(Vector3D vertex, Single bugle)`

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EqualEps` | `Boolean` | `BugleVector3D other` | `` |
| `EqualEps` | `Boolean` | `BugleVector3D other, Double squaredEps` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `BugleVector3D other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `BugleVector3D` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bugle` | `Single` | No | `` | `` |
| `Vertex` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `CadColor` (struct)

**Attributes**: [PropertyEditor, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CadColor` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.CadColor`

#### Constructors (2)

- `.ctor(Color Win32Color)`
- `.ctor(Int32 colorIndex)`

#### Properties (17)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Background` | `CadColor` | `get` | Yes | `` |
| `Blue` | `CadColor` | `get` | Yes | `` |
| `ByBlock` | `CadColor` | `get` | Yes | `` |
| `ByLayer` | `CadColor` | `get` | Yes | `` |
| `ColorIndex` | `Int32` | `get` | No | `` |
| `Cyan` | `CadColor` | `get` | Yes | `` |
| `DisableDark` | `Color` | `get` | No | `` |
| `DisableLight` | `Color` | `get` | No | `` |
| `Empty` | `CadColor` | `get` | Yes | `` |
| `Green` | `CadColor` | `get` | Yes | `` |
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Magenta` | `CadColor` | `get` | Yes | `` |
| `Name` | `String` | `get` | No | `` |
| `Red` | `CadColor` | `get` | Yes | `` |
| `White` | `CadColor` | `get` | Yes | `` |
| `Win32Color` | `Color` | `get` | No | `` |
| `Yellow` | `CadColor` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToCompressValue` | `Int32` | `` | `` |
| `ToIndexColor` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromCompressValue` | `CadColor` | `Int32 value` | `` |
| `GetDisableColor` | `Color` | `Color color, Boolean isWhiteBackgroud` | `` |
| `GetDisableColorDark` | `Color` | `Color value` | `` |
| `GetDisableColorLight` | `Color` | `Color value` | `` |
| `GrayScale` | `CadColor` | `CadColor color, Boolean light` | `` |
| `HSLtoRGB` | `Color` | `Double hue, Double saturation, Double luminance` | `` |
| `VisualColor` | `Color` | `CadColor color, CadPen pen` | `` |
| `VisualColor` | `Color` | `CadColor color, CadPen pen, Boolean enable` | `` |
| `VisualColor` | `Color` | `CadColor color, Boolean isWhiteBackgroud, Boolean enable, Boolean print` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BackgroundIndex` | `Int32` | Yes | `67108864` | `` |
| `ByBlockIndex` | `Int32` | Yes | `0` | `` |
| `ByLayerIndex` | `Int32` | Yes | `256` | `` |
| `EmptyIndex` | `Int32` | Yes | `33554432` | `` |
| `FadeControl` | `Single` | Yes | `` | `` |

### `CadFont` (abstract class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CadFont` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |
| `FilePath` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `DrawString` | `Void` | `String s, CadPen pen, Vector3D point, Double sinA, Double cosA, Double height, Double ratio, Double oblique, Double pressure, TextJustify justify, Color wipeOutColor, Double inflate` | `` |
| `DrawString` | `Void` | `String s, CadPen pen, Vector3D point, Double sinA, Double cosA, Double height, Double ratio, Double oblique, Double pressure, TextJustify justify` | `` |
| `DrawString` | `Void` | `String s, CadPen pen, Vector3D point, Double angle, Double height` | `` |
| `GetWipeoutRectanagle` | `Vector2D[]` | `String s, Vector3D point, Double sinA, Double cosA, Double height, Double ratio, Double oblique, Double pressure, TextJustify justify, Double inflate` | `` |
| `JustifyToPosition` | `Vector3D` | `String s, Vector3D point, Double sinA, Double cosA, Double height, Double ratio, Double pressure, TextJustify justify` | `` |
| `TextHeight` | `Double` | `String s, Double height, Double ratio, Double pressure` | `` |
| `TextHeight` | `Double` | `String s, Double height, Double ratio` | `` |
| `TextHeight` | `Double` | `String s, Double height` | `` |
| `TextLength` | `Double` | `String s, Double height, Boolean trimLastSpace` | `` |
| `TextLength` | `Double` | `String s, Double height, Double ratio, Boolean trimLastSpace` | `` |
| `TextLength` | `Double` | `String s, Double height, Double ratio, Double pressure, Boolean trimLastSpace` | `` |
| `TextSize` | `SizeF` | `String s, Double height, Double ratio, Double pressure, Boolean trimLastSpace` | `` |
| `TextSize` | `SizeF` | `String s, Double height, Boolean trimLastSpace` | `` |
| `TextSize` | `SizeF` | `String s, Double height, Double ratio, Boolean trimLastSpace` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Diameter` | `Char` | Yes | `` | `` |
| `Gradus` | `Char` | Yes | `` | `` |
| `PlusMinus` | `Char` | Yes | `` | `` |
| `TabulationMaxScale` | `Double` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CadLibrary` (static class)

**Attributes**: [ComVisible, Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CadLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (95)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Angle2PosOX` | `Double` | `Vector2D a, Vector2D b` | `` |
| `Angle3Pos` | `Double` | `Vector2D a, Vector2D b, Vector2D c` | `` |
| `Angle3PosEx` | `Double` | `Vector2D a, Vector2D b, Vector2D c` | `` |
| `AngleBetweenAngles` | `Boolean` | `Double startAngle, Double endAngle, Double angle` | `` |
| `AngleToArcAngle` | `Double` | `Double angle` | `` |
| `ArcAngleDiff` | `Double` | `Double startAngle, Double endAngle` | `` |
| `ArcBounds` | `BoundingBox2D` | `Vector2D center, Double radius, Double startAngle, Double endAngle` | `` |
| `ArcTangent` | `Int32` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Vector2D pos, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `CalcBugleValue` | `Single` | `Vector2D center, Vector2D Pos1, Vector2D Pos2` | `` |
| `CalcCloth` | `Void` | `Double c, Double s, ref Double x, ref Double y, ref Double beta` | `` |
| `CalcClothCoords` | `Void` | `Double c, Double s, Double x0, Double y0, Double angle, ref Double x, ref Double y, ref Double beta` | `` |
| `CalcClothFullLength` | `Double` | `Double lengthSmall, Double radiusMax, Double radiusMin` | `` |
| `CalcClothOffs` | `Void` | `Double c, Double s, Double offs, ref Double x, ref Double y` | `` |
| `CalcGrade` | `Double` | `Double elev1, Double elev2, Double dist, Boolean roundGrades` | `` |
| `CalcSpline2D` | `Void` | `IEnumerable<Vector2D> fitPoints, ref Vector2D startTangent, ref Vector2D endTangent, Int32 smooth, IList<Vector2D> result` | `` |
| `CalcSpline3D` | `Void` | `IList<Vector3D> controlPoints, IList<Single> knotPoints, Single smoothStep, IList<Vector3D> result` | `` |
| `CalcSpline3D` | `Void` | `IEnumerable<Vector3D> fitPoints, ref Vector3D st, ref Vector3D et, Int32 smooth, IList<Vector3D> result` | `` |
| `CalcSpline3D` | `Void` | `IList<Vector3D> controlPoints, IList<Single> knotPoints, IList<Vector3D> fitPoints, ref Vector3D startTangent, ref Vector3D endTangent` | `` |
| `CircleTangent` | `Boolean` | `Vector2D center, Double radius, Vector2D point, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `ClotoidTangent` | `Boolean` | `Vector2D pt, Double angle, Double radius, Double length, Double startLength, Vector2D pos, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `Cos2Lines` | `Double` | `Vector2D a, Vector2D b, Vector2D c, Vector2D d` | `` |
| `DistanceLineToLine` | `Double` | `Line2D line1, Line2D line2` | `` |
| `DistancePosToLine` | `Double` | `Line2D line, Vector2D point` | `` |
| `DistanceSignToLine` | `Double` | `Line2D line, Vector2D point` | `` |
| `FindPosInsidePolygon` | `Boolean` | `IList<Vector2D> vectors, ref Vector2D pos` | `` |
| `FresnelIntegral` | `Void` | `Double x, ref Double c, ref Double s` | `` |
| `GetArcMiddleAngle` | `Double` | `Double startAngle, Double endAngle` | `` |
| `GetArcMiddlePoint` | `Vector2D` | `Vector2D center, Double radius, Double startAngle, Double endAngle` | `` |
| `GetCircleFrom3Points` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c, ref Vector2D center, ref Double radius` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector3D a, Vector3D b, Vector3D c, Vector2D point` | `` |
| `GrahamMVO` | `List<Int32>` | `IList<Vector2D> vectors` | `` |
| `MakeArcFrom2PointsRadius` | `Boolean` | `Vector2D p1, Vector2D p2, Double radius, Vector2D pos, ref Vector2D center, ref Double startAngle, ref Double endAngle` | `` |
| `MakeArcFrom3Points` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c, ref Vector2D center, ref Double radius, ref Double startAngle, ref Double endAngle` | `` |
| `NormalToArc` | `Int32` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Vector2D pos, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `NormalToCircle` | `Int32` | `Vector2D center, Double radius, Vector2D pos, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `NormalToLine` | `Boolean` | `Vector2D a, Vector2D b, Vector2D pos, ref Vector2D result` | `` |
| `NormalToSegment` | `Boolean` | `Vector2D a, Vector2D b, Vector2D pos, ref Vector2D result` | `` |
| `PointOffset` | `Void` | `Vector2D p, Vector2D p1, Vector2D p2, Double dL, ref Vector2D pOffs1, ref Vector2D pOffs2` | `` |
| `PointOffsetNorm` | `Boolean` | `Vector2D p, Vector2D p1, Vector2D p2, Double dL, ref Vector2D pOf1, ref Vector2D pOf2` | `` |
| `PolygonArea` | `Double` | `IEnumerable<Vector2D> polygon` | `` |
| `Polyline3PointToBugle` | `Single` | `Vector2D a, Vector2D b, Vector2D c` | `` |
| `PolylineOffset` | `Void` | `IList<Vector3D> source, Double offset, IList<Vector3D> result` | `` |
| `PolylineOffset` | `Void` | `IList<Vector2D> polyline, Double offset, IList<Vector2D> result` | `` |
| `PolylineOffsetEx` | `Void` | `IList<Vector2D> polyline, Double offset, IList<Vector2D> result` | `` |
| `PolylineOffsetEx` | `Void` | `IList<Vector2D> polyline, Double offset, IList<List<Vector2D>> result` | `` |
| `PolylineSegmentToArc` | `Boolean` | `Vector2D a, Vector2D b, Single bugle, ref Vector2D center, ref Double radius, ref Double startAngle, ref Double endAngle, ref Boolean reversed` | `` |
| `PosInPolygon` | `Boolean` | `Vector2D point, IList<Vector2D> polygon, Boolean checkBorder` | `` |
| `PosInPolygon` | `Void` | `ref Vector2D point, IList<Vector2D> polygon, Boolean checkBorder, ref Boolean result` | `` |
| `PosInTriangle` | `Void` | `ref Vector2D point, ref Vector2D a, ref Vector2D b, ref Vector2D c, ref Boolean result` | `` |
| `PosInTriangle` | `Boolean` | `Vector2D point, Vector2D a, Vector2D b, Vector2D c` | `` |
| `PosOnCircle` | `Boolean` | `Vector2D center, Double radius, Vector2D point` | `` |
| `PosOnSegment` | `Boolean` | `Vector2D a, Vector2D b, Vector2D pos` | `` |
| `PosSide` | `Int32` | `Vector2D a, Vector2D b, Vector2D point` | `` |
| `PosToNormOffs` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b, Double distance, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `PosToPolylineStaOffset` | `Boolean` | `IList<Vector2D> polyline, Vector2D point, ref Int32 index, ref Double offset, ref Double station` | `` |
| `PosToPolylineStaOffset` | `Boolean` | `IList<Vector2D> polyline, Vector2D point, ref Double offset, ref Double station` | `` |
| `PosToStaOffs` | `Boolean` | `Vector2D pos1, Vector2D pos2, Vector2D pos, ref Double sta, ref Double offs` | `Obsolete(Message: `Функция устаревшия. Лучше использовать PosToStaOffsLine или PosToStaOffsSegment, работают быстрее и правильно.`)` |
| `PosToStaOffsCloth` | `Boolean` | `Double c, Double x0, Double y0, Double angle, Double s0, Double l, Double x, Double y, ref Double s, ref Double offs` | `` |
| `PosToStaOffsLine` | `Boolean` | `Vector2D a, Vector2D b, Vector2D point, ref Double sta, ref Double offs` | `` |
| `PosToStaOffsSegment` | `Boolean` | `Vector2D a, Vector2D b, Vector2D point, ref Double sta, ref Double offs` | `` |
| `RemoveDublicated` | `Void` | `IList<Vector3D> polyline, Double eps` | `` |
| `RemoveDublicated` | `Void` | `IList<Vector2D> polyline` | `` |
| `RemoveDublicated` | `Void` | `IList<Vector2D> polyline, Double eps` | `` |
| `RemoveDublicated` | `Void` | `IList<Vector3D> polyline` | `` |
| `SectArcArc` | `Int32` | `Vector2D center1, Vector2D center2, Double r1, Double r2, Double startAngle1, Double startAngle2, Double endAngle1, Double endAngle2, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectArcCircle` | `Int32` | `Vector2D center1, Double radius1, Double startAngle, Double endAngle, Vector2D center2, Double radius2, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectArcLine` | `Int32` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Line2D line, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectArcSegment` | `Int32` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Vector2D a, Vector2D b, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectCircleCircle` | `Int32` | `Vector2D center1, Vector2D center2, Double r1, Double r2, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectCircleLine` | `Int32` | `Vector2D center, Double radius, Line2D line, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectCircleSegment` | `Int32` | `Vector2D center, Double radius, Vector2D a, Vector2D b, ref Vector2D pos1, ref Vector2D pos2` | `` |
| `SectRayEdge` | `Boolean` | `Ray3D ray, Vector3F a, Vector3F b, ref Vector3F pos1, ref Vector3F pos2` | `` |
| `SectRayEdge` | `Boolean` | `Ray3D ray, Vector3D a, Vector3D b, ref Vector3D pos1, ref Vector3D pos2` | `` |
| `SectRaySphere` | `Boolean` | `Ray3D ray, Vector3D center, Double radius` | `` |
| `SectRayTriangle` | `Boolean` | `Ray3D ray, Vector3F v1, Vector3F v2, Vector3F v3, ref Vector3F sect` | `` |
| `SectRayTriangle` | `Boolean` | `Ray3D ray, Vector3D v1, Vector3D v2, Vector3D v3, ref Vector3D sect` | `` |
| `SectSegmentLine` | `Boolean` | `Vector2D a, Vector2D b, Line2D line, ref Vector2D point` | `` |
| `SectSegments` | `Boolean` | `Vector2D a1, Vector2D a2, Vector2D b1, Vector2D b2, ref Vector2D point` | `` |
| `SectSegmentsEx` | `Boolean` | `Vector2D a1, Vector2D a2, Vector2D b1, Vector2D b2, ref Vector2D point, Int32 flags` | `` |
| `SectSlopeParallelogram` | `Boolean` | `Vector3D a1, Vector3D b1, Vector3D c1, Vector3D a2, Vector3D b2, Vector3D c2` | `` |
| `SectSlopeTriangle` | `Int32` | `Vector3D a1, Vector3D b1, Vector3D c1, Vector3D a2, Vector3D b2, Vector3D c2, Vector3D[] sect` | `` |
| `SectTriangles` | `Int32` | `Vector3D a1, Vector3D b1, Vector3D c1, Vector3D a2, Vector3D b2, Vector3D c2, Vector3D[] sect` | `` |
| `SectTriangleSlopeTriangle` | `Int32` | `Vector3D a1, Vector3D b1, Vector3D c1, Vector3D a2, Vector3D b2, Vector3D c2, Vector3D[] sect` | `` |
| `SegmentOffset` | `Void` | `ref Vector3D a, ref Vector3D b, Double offset` | `` |
| `SegmentOffset` | `Void` | `ref Vector2D a, ref Vector2D b, Double offset` | `` |
| `SmoothPolyline` | `Void` | `IList<Vector3D> polyline, Double smothness, Boolean closed, IPolyline3D result` | `` |
| `SolveBeta` | `Double` | `Vector2D p1, Vector2D p2, Vector2D p3` | `` |
| `SolveQuadratic` | `Boolean` | `Double a, Double b, Double c, ref Double root1, ref Double root2` | `` |
| `StaOffsetToPos` | `Vector2D` | `IList<Vector2D> polyline, Double station, Double offset` | `Extension` |
| `StaOffsetToPosInfinite` | `Vector2D` | `IList<Vector2D> polyline, Double station, Double offset` | `Extension` |
| `StaOffsToPos` | `Vector2D` | `Vector2D pos1, Vector2D pos2, Double sta, Double offs` | `` |
| `StaOffsToPosCloth` | `Vector2D` | `Double c, Double x0, Double y0, Double angle, Double s, Double offs` | `` |
| `Triangle3dArea` | `Double` | `Vector3D a, Vector3D b, Vector3D c` | `` |
| `Triangle3dAreaSqr` | `Double` | `Vector3D a, Vector3D b, Vector3D c` | `` |
| `TriangleArea` | `Double` | `Vector2D a, Vector2D b, Vector2D c` | `` |

### `CadPen` (abstract class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CadPen` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackGroundColor` | `Color` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `ComplexLinetype` | `LinetypePattern` | `get/set` | No | `` |
| `CurrentScale` | `Double` | `get/set` | No | `` |
| `DeviceContext` | `DeviceContext` | `get` | No | `` |
| `DrawingMode` | `DrawingMode` | `get/set` | No | `` |
| `Graphics` | `IGraphics` | `get` | No | `` |
| `HighlightMode` | `HighlightMode` | `get/set` | No | `` |
| `IsWhiteBackColor` | `Boolean` | `get` | No | `` |
| `LineCapJoin` | `LineCapJoin` | `get/set` | No | `` |
| `LinetypeScale` | `Double` | `get/set` | No | `` |
| `OverallMatrix` | `Matrix` | `get` | No | `` |
| `PaintTerminate` | `Boolean` | `get` | No | `` |
| `ProjectionMatrix` | `Matrix` | `get/set` | No | `` |
| `ViewBounds` | `BoundingBox2D` | `get/set` | No | `` |
| `Width` | `Single` | `get/set` | No | `` |

#### Instance Methods (40)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginArray` | `Void` | `` | `` |
| `BeginDraw` | `Void` | `` | `` |
| `DrawArray` | `Void` | `IList<Vector2D> list, ArrayMode mode` | `` |
| `DrawLine` | `Void` | `ref Vector2D a, ref Vector2D b` | `` |
| `DrawLine` | `Void` | `Vector2D a, Vector2D b` | `` |
| `DrawPoint` | `Void` | `ref Vector2D a` | `` |
| `DrawPoint` | `Void` | `Vector2D a` | `` |
| `EndArray` | `Void` | `ArrayMode mode` | `` |
| `EndDraw` | `Void` | `` | `` |
| `EndGraphicsDraw` | `Void` | `` | `` |
| `LoadIdentity` | `Void` | `` | `` |
| `MultMatrix` | `Void` | `ref Matrix matrix` | `` |
| `PopMatrix` | `Void` | `` | `` |
| `ProjectPoint` | `Void` | `ref Vector2D value, ref Vector2D result` | `` |
| `ProjectPoint` | `Vector2D` | `ref Vector2D value` | `` |
| `ProjectPoint` | `Vector2D` | `Vector2D value` | `` |
| `ProjectPoint` | `Void` | `ref Vector3D value, ref Vector3D result` | `` |
| `ProjectPoint` | `Vector3D` | `Vector3D value` | `` |
| `PushMatrix` | `Void` | `` | `` |
| `Reset` | `Void` | `` | `` |
| `ResetLinetype` | `Void` | `` | `` |
| `Rotate` | `Void` | `Double radians` | `` |
| `Rotate` | `Void` | `Double sinA, Double cosA` | `` |
| `Scale` | `Void` | `Double dX, Double dY` | `` |
| `Scale` | `Void` | `Double value` | `` |
| `Translate` | `Void` | `Double dX, Double dY` | `` |
| `UnProjectPoint` | `Vector2D` | `Vector2D value` | `` |
| `UnProjectPoint` | `Vector2D` | `ref Vector2D value` | `` |
| `UnProjectPoint` | `Void` | `ref Vector2D value, ref Vector2D result` | `` |
| `Vertex` | `Void` | `ref Vector2D A` | `` |
| `Vertex` | `Void` | `Double X, Double Y, Double Z` | `` |
| `Vertex` | `Void` | `Vector2D A` | `` |
| `Vertex` | `Void` | `Double X, Double Y` | `` |
| `VertexArc` | `Void` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Boolean drawFirstPoint` | `` |
| `VertexArc` | `Void` | `Vector2D center, Double radius, Double startAngle, Double endAngle, Boolean drawFirstPoint, Boolean inverse` | `` |
| `VertexArc` | `Void` | `Vector2D center, Double radius, Double startAngle, Double endAngle` | `` |
| `VertexCircle` | `Void` | `Vector2D center, Double radius` | `` |
| `VertexEllipse` | `Void` | `Vector2D center, Vector2D endPoint, Double radiusRatio, Double startAngle, Double endAngle, Boolean drawFirstPoint, Boolean inverse` | `` |
| `VertexEllipse` | `Void` | `Vector2D center, Vector2D endPoint, Double radiusRatio, Double startAngle, Double endAngle, Boolean drawFirstPoint` | `` |
| `VertexEllipse` | `Void` | `Vector2D center, Vector2D endPoint, Double radiusRatio, Double startAngle, Double endAngle` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `MaxArcBreak` | `Int32` | Yes | `2000` | `` |
| `MaxCircleBreak` | `Int32` | Yes | `2000` | `` |
| `MinArcBreak` | `Int32` | Yes | `3` | `` |
| `MinCircleBreak` | `Int32` | Yes | `4` | `` |
| `MinimalComplexLinetypePatternSize` | `Double` | Yes | `2` | `` |
| `MinimalSize` | `Double` | Yes | `1` | `` |
| `Smooth` | `Double` | Yes | `5` | `` |

### `ClipTask` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonsClipper+ClipTask` |
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
      - `Topomatic.Cad.Foundation.PolygonsClipper+ClipTask`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Difference` | `ClipTask` | Yes | `Difference` | `` |
| `Intersection` | `ClipTask` | Yes | `Intersection` | `` |
| `Union` | `ClipTask` | Yes | `Union` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Xor` | `ClipTask` | Yes | `Xor` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Intersection` | `0` |
| `Union` | `1` |
| `Difference` | `2` |
| `Xor` | `3` |

**Underlying Type**: `System.Int32`

### `ClothoidDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+ClothoidDirection` |
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
      - `Topomatic.Cad.Foundation.CompoundLine+ClothoidDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `ClothoidDirection` | Yes | `Backward` | `` |
| `Forward` | `ClothoidDirection` | Yes | `Forward` | `` |
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

### `ClothoidItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+ClothoidItem` |
| **Base Type** | `Topomatic.Cad.Foundation.CompoundLine+Item` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.CompoundLine+Item`
      - `Topomatic.Cad.Foundation.CompoundLine+ClothoidItem`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get` | No | `` |
| `BeginPos` | `Vector2D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Direction` | `ClothoidDirection` | `get/set` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `FullLength` | `Double` | `get/set` | No | `` |
| `ItemType` | `ItemType` | `get` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double sta, Double offset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IObjectDisjoiner` | `GetSegments` |

### `ClotSolveLibrary` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ClotSolveLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (31)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcClothAngles` | `Boolean` | `Double clothLength, Double radiusFrom, Double radiusTo, ref Double angle1, ref Double angle2` | `` |
| `CalcClothAnglesAndP` | `Boolean` | `Double clothLength, Double radiusFrom, Double radiusTo, ref Double angle1, ref Double angle2, ref Double p` | `` |
| `CalcClothB` | `Double` | `Double alpha` | `` |
| `CalcClothP` | `Double` | `Double alpha` | `` |
| `CalcClothP_Diff` | `Double` | `Double alpha` | `` |
| `CalcClothT` | `Double` | `Double alpha` | `` |
| `CalcClothTd` | `Double` | `Double alpha` | `` |
| `CalcClothTk` | `Double` | `Double alpha` | `` |
| `CalcClothX0` | `Double` | `Double alpha` | `` |
| `CalcClothX0_Diff` | `Double` | `Double alpha` | `` |
| `CalcClothX0Precisely` | `Double` | `Double alpha` | `` |
| `CalcClothX0Precisely_Diff` | `Double` | `Double alpha` | `` |
| `CalcClothX0Precisely_SecondDiff` | `Double` | `Double alpha` | `` |
| `CalcClothXPrecisely` | `Double` | `Double alpha` | `` |
| `CalcClothXPreciselyDiff` | `Double` | `Double alpha` | `` |
| `CalcClothXPreciselySecondDiff` | `Double` | `Double alpha` | `` |
| `CalcClothXSeries` | `Double` | `Double alpha` | `` |
| `CalcClothXSeriesDiff` | `Double` | `Double alpha` | `` |
| `CalcClothY0` | `Double` | `Double alpha` | `` |
| `CalcClothY0_Diff` | `Double` | `Double alpha` | `` |
| `CalcClothY0Precisely` | `Double` | `Double alpha` | `` |
| `CalcClothY0Precisely_Diff` | `Double` | `Double alpha` | `` |
| `CalcClothY0Precisely_SecondDiff` | `Double` | `Double alpha` | `` |
| `CalcClothYPrecisely` | `Double` | `Double alpha` | `` |
| `CalcClothYPreciselyDiff` | `Double` | `Double alpha` | `` |
| `CalcClothYPreciselySecondDiff` | `Double` | `Double alpha` | `` |
| `CalcClothYSeries` | `Double` | `Double alpha` | `` |
| `CalcClothYSeriesDiff` | `Double` | `Double alpha` | `` |
| `ClothoidToPolyline` | `Void` | `ClothoidStruc clot, IPolyline3D polyline` | `` |
| `FindTruncatedClothoidLength` | `Boolean` | `Double R1, Double Xc1, Double Yc1, Double R2, Double Xc2, Double Yc2, ref Double Len, ref Double Ug, ref Double dx, ref Double dy` | `` |
| `SolveLengthOfClothBetweenLineAndCircle` | `Boolean` | `Double r, Double d, ref Double len` | `` |

### `CompoundLine` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.CompoundLine+Item, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Cad.Foundation.CompoundLine`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |

#### Instance Methods (24)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendItem` | `Item` | `ItemType itemType, Double length, DisplaceType displaceType` | `` |
| `AppendItem` | `Item` | `ItemType itemType, Double length` | `` |
| `AppendItem` | `Item` | `ItemType itemType` | `` |
| `AppendItem` | `Item` | `ItemType itemType, Double station, Double length, DisplaceType displaceType` | `` |
| `Clear` | `Void` | `` | `` |
| `GetAt` | `Item` | `Int32 index` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetCompoundLineItems` | `IEnumerable<Int32>` | `Line2D line` | `` |
| `GetCompoundLineItems` | `IEnumerable<Int32>` | `BoundingBox2D bb` | `` |
| `GetCompoundLineItems` | `IEnumerable<Int32>` | `Vector2D a, Vector2D b` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<Item>` | `` | `` |
| `GetIndexBySta` | `Int32` | `Double sta` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `PosToStaOffset` | `Boolean` | `Vector2D pos, ref Double sta, ref Double offset` | `` |
| `PosToStaOffset` | `Boolean` | `Double startStation, Double endStation, Vector2D pos, ref Double sta, ref Double offset` | `` |
| `RefreshIndex` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `StaOffsetToPos` | `Boolean` | `Double sta, Double offset, ref Vector2D pos` | `` |

#### Nested Types (9)

- `ArcItem` (class)
- `ClothoidDirection` (enum)
- `ClothoidItem` (class)
- `DisplaceType` (enum)
- `Item` (abstract class)
- `ItemType` (enum)
- `OptLib` (abstract class)
- `ParabolaItem` (class)
- `StraightItem` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D0` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.D1` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Project` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.Tesselate` |
| `ICurve` | `Topomatic.Cad.Foundation.ICurve.get_Length` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `CompoundLineExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLineExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (28)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalcKxKy` | `Void` | `Item item, Double length, ref Double kX, ref Double kY` | `Extension` |
| `CalcTangents` | `Boolean` | `Vector2D beginPos, Vector2D endPos, ref Double kX, ref Double kY` | `` |
| `CloneCompoundLineItem` | `Item` | `CompoundLine line, Item item` | `` |
| `Cut` | `CompoundLine` | `CompoundLine current, Double from, Double to` | `Extension` |
| `D02D` | `Boolean` | `ICurve curve, Double u, Double offset, ref Vector2D pos` | `Extension` |
| `D02DInf` | `Boolean` | `ICurve curve, Double u, Double offset, ref Vector2D pos` | `Extension` |
| `GetCurvature` | `Boolean` | `CompoundLine cl, Double station, ref Double curvature` | `Extension` |
| `GetTangentPosition` | `Boolean` | `CompoundLine cl, Double station, Double length, ref Vector2D pos1, ref Vector2D pos2` | `Extension` |
| `GetTangentPosition` | `Boolean` | `CompoundLine cl, Double station, ref Vector2D pos1, ref Vector2D pos2` | `Extension` |
| `GetTangentPosition` | `Void` | `Item item, Double length, Double tangent, ref Vector2D pos1, ref Vector2D pos2` | `Extension` |
| `GetTangentPositionInfinite` | `Boolean` | `CompoundLine cl, Double station, Double length, ref Vector2D pos1, ref Vector2D pos2` | `Extension` |
| `Join` | `Void` | `CompoundLine current, CompoundLine first, CompoundLine second` | `Extension` |
| `PosToStaOffsetInfinite` | `Boolean` | `CompoundLine compoundLine, Vector2D pos, ref Double sta, ref Double offs` | `Extension` |
| `Project2D` | `Boolean` | `ICurve curve, Vector2D pos, ref Double u, ref Double offset` | `Extension` |
| `Project2DInf` | `Boolean` | `ICurve curve, Vector2D pos, ref Double u, ref Double offset` | `Extension` |
| `RotateArcPos` | `Boolean` | `Vector2D arcBegin, Vector2D arcCenter, Double angle, Double kX, Double kY, ref Vector2D endPos, ref Double rkX, ref Double rkY` | `` |
| `SectArc` | `Void` | `CompoundLine trc, Vector2D center, Double radius, Double sangle, Double eangle, IList<Double> stations, Double tg` | `Extension` |
| `SectLine` | `Void` | `CompoundLine trc, ref BoundingBox2D bounds, Line2D line, IList<Double> stations, Double tg` | `Extension` |
| `SectLine` | `Void` | `CompoundLine trc, Line2D line, IList<Double> stations` | `Extension` |
| `SectSegment` | `Void` | `CompoundLine trc, Vector2D a, Vector2D b, IList<Double> stations, Double tg` | `Extension` |
| `SectSegment` | `Void` | `CompoundLine trc, Vector2D a, Vector2D b, IList<Double> stations` | `Extension` |
| `SectWithOtherCompoundLine` | `Void` | `CompoundLine cl, CompoundLine otherCl, ref List<Vector2D> crossPoses` | `Extension` |
| `Split` | `Void` | `CompoundLine current, Double station, CompoundLine before, CompoundLine after` | `Extension` |
| `StaOffsetToPosInfinite` | `Boolean` | `CompoundLine compoundLine, Double sta, Double offs, ref Vector2D pos` | `Extension` |
| `ToPathList` | `Void` | `CompoundLine cl, IList<IPathItem> pathList` | `Extension` |
| `ToPathListWithoutClothoids` | `Void` | `CompoundLine cl, IList<IPathItem> pathList` | `Extension` |
| `ToPolyLine` | `Void` | `CompoundLine cl, IPolyline3D polyline` | `Extension` |
| `ToPosArray` | `Void` | `CompoundLine cl, IList<Vector2D> positions, Double eps` | `Extension` |

### `ContainmentType` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ContainmentType` |
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
      - `Topomatic.Cad.Foundation.ContainmentType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Contains` | `ContainmentType` | Yes | `Contains` | `` |
| `Disjoint` | `ContainmentType` | Yes | `Disjoint` | `` |
| `Intersects` | `ContainmentType` | Yes | `Intersects` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Disjoint` | `0` |
| `Contains` | `1` |
| `Intersects` | `2` |

**Underlying Type**: `System.Int32`

### `CoordsHash`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CoordsHash`1` |
| **Base Type** | `System.Object` |
| **Implements** | `, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor(Int32 coords, Double eps)`
- `.ctor(Int32 capacity, Int32 coords, Double eps)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendValue` | `Int32` | `T vector` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `RestoreValue` | `T` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CoordsJoiner`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CoordsJoiner`1` |
| **Base Type** | `System.Object` |
| **Implements** | `, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor(Int32 coords, Double eps)`
- `.ctor(Int32 capacity, Int32 coords, Double eps)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendValue` | `Int32` | `T vector` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `JoinCoords` | `Void` | `` | `` |
| `RestoreValue` | `T` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `DeviceContext` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (44)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BackgroundColor` | `Color` | `get/set` | No | `` |
| `Box` | `BoundingBox3D` | `get` | No | `` |
| `BrushStyle` | `BrushStyle` | `get/set` | No | `` |
| `Color` | `Color` | `get/set` | No | `` |
| `DepthBias` | `Single` | `get/set` | No | `` |
| `DepthMask` | `Boolean` | `get/set` | No | `` |
| `DepthTest` | `Boolean` | `get/set` | No | `` |
| `Frustum` | `BoundingFrustum` | `get` | No | `` |
| `Graphics` | `IGraphics` | `get` | No | `` |
| `HighlightMode` | `HighlightMode` | `get/set` | No | `` |
| `IsolinesScale` | `Single` | `get/set` | No | `` |
| `IsOrtho` | `Boolean` | `get` | No | `` |
| `IsPerspective` | `Boolean` | `get` | No | `` |
| `IsPloting` | `Boolean` | `get/set` | No | `` |
| `IsWhiteBackgroundColor` | `Boolean` | `get` | No | `` |
| `LinetypeMinimalSize` | `Single` | `get/set` | No | `` |
| `LinetypePattern` | `LinetypePattern` | `get/set` | No | `` |
| `LinetypeScale` | `Single` | `get/set` | No | `` |
| `Multisampling` | `Boolean` | `get/set` | No | `` |
| `OrthoScale` | `Single` | `get/set` | No | `` |
| `Pen` | `CadPen` | `get` | No | `` |
| `Pivot` | `Vector3D` | `get/set` | No | `` |
| `PointSmooth` | `Boolean` | `get/set` | No | `` |
| `PolygonOffset` | `Boolean` | `get/set` | No | `` |
| `Print` | `Boolean` | `get` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `RectangularThickness` | `Single` | `get/set` | No | `` |
| `RegenType` | `RegenType` | `get/set` | No | `` |
| `Shader` | `ShaderType` | `get/set` | No | `` |
| `Simplify` | `Boolean` | `get` | No | `` |
| `Terminated` | `Boolean` | `get` | No | `` |
| `Texture0` | `Texture` | `get/set` | No | `` |
| `Textured` | `Boolean` | `get/set` | No | `` |
| `Thickness` | `Single` | `get/set` | No | `` |
| `UCSInsertion` | `Vector3D` | `get/set` | No | `` |
| `UCSRotation` | `Single` | `get/set` | No | `` |
| `UCSScale` | `Single` | `get/set` | No | `` |
| `VertexBuffer` | `VertexBuffer` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `ViewPortHeight` | `Single` | `get/set` | No | `` |
| `ViewPortWidth` | `Single` | `get/set` | No | `` |
| `WireFrame` | `Boolean` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |
| `WorldViewProjection` | `Matrix` | `get` | No | `` |

#### Instance Methods (69)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `AddTask` | `Void` | `Action task, String caption` | `` |
| `Arc` | `Void` | `Vector3F center, Single radius, Single startDegree, Single endDegree, OrientationType orientation` | `` |
| `BeginArray` | `Void` | `` | `` |
| `BeginClip` | `Void` | `` | `` |
| `BeginRender` | `Void` | `` | `` |
| `Circle` | `Void` | `Vector3F center, Single radius` | `` |
| `ClearDepth` | `Void` | `` | `` |
| `ClipViewPort` | `Void` | `Vector2F left_top, Vector2F right_bottom` | `` |
| `Contains` | `Boolean` | `Vector3F pt` | `` |
| `Contains` | `Boolean` | `Vector3F a, Vector3F b` | `` |
| `Dispose` | `Void` | `` | `` |
| `DrawPrimitives` | `Void` | `PrimitiveType primitiveType, Int32 count` | `` |
| `DrawUserIndexedPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Int32 vertexOffset, Int32 numVertices, Int32[] indexData, Int32 indexOffset, Int32 primitiveCount` | `` |
| `DrawUserIndexedPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Byte[] colorData, Int32 vertexOffset, Int32 numVertices, Int32[] indexData, Int32 indexOffset, Int32 primitiveCount` | `` |
| `DrawUserPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Int32 vertexOffset, Int32 primitiveCount` | `` |
| `DrawUserPrimitives` | `Void` | `PrimitiveType primitiveType, Vector2F[] vertexData, Int32 vertexOffset, Int32 primitiveCount` | `` |
| `DrawUserPrimitives` | `Void` | `PrimitiveType primitiveType, Vector3F[] vertexData, Byte[] colorData, Int32 vertexOffset, Int32 primitiveCount` | `` |
| `Ellipse` | `Void` | `Vector3F center, Single majorAxisLength, Single minorAxisLength, Single startDegree, Single endDegree, Single tiltDegree` | `` |
| `EndArray` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `EndRender` | `Void` | `` | `` |
| `gArc` | `Void` | `Vector3D center, Double radius, Double start, Double end, OrientationType orientation` | `` |
| `gBoundsProjectionInformation` | `Void` | `ref BoundingBox3D box, ref Vector3F size` | `` |
| `gCircle` | `Void` | `Vector3D center, Single radius` | `` |
| `gClipLine` | `Boolean` | `Line3D line, ref Vector3D a, ref Vector3D b` | `` |
| `gClipRay` | `Boolean` | `Ray3D ray, ref Vector3D a, ref Vector3D b` | `` |
| `gClipSegment` | `Boolean` | `ref Vector3D a, ref Vector3D b` | `` |
| `gContains` | `Boolean` | `BoundingBox3D box` | `` |
| `gContains` | `Boolean` | `Vector3D pt` | `` |
| `gContains` | `Boolean` | `Vector3D a, Vector3D b` | `` |
| `gContains` | `Boolean` | `BoundingSphere3D sphere` | `` |
| `gEllipse` | `Void` | `Vector3D center, Single majorAxisLength, Single minorAxisLength, Single startDegree, Single endDegree, Single tiltDegree` | `` |
| `gLine` | `Void` | `Vector3D a, Vector3D b` | `` |
| `gProject` | `Vector3D` | `ref Vector3D position, ref Matrix wvp` | `` |
| `gProject` | `Vector3D` | `Vector3D position` | `` |
| `gProjectFromUCS` | `Vector3D` | `Vector3D position` | `` |
| `gProjectToUCS` | `Vector3D` | `Vector3D position` | `` |
| `gRaster` | `Void` | `String filename` | `` |
| `gRaster` | `Void` | `IRasterReference rst` | `` |
| `gString` | `Void` | `Font font, String text` | `` |
| `gTriangle` | `Void` | `Vector3D a, Vector3D b, Vector3D c` | `` |
| `gUnproject` | `Vector3D` | `Vector3D position` | `` |
| `gUnproject` | `Vector3D` | `Vector2D position` | `` |
| `gVertex` | `Void` | `Vector3D pt` | `` |
| `IsRasterBinded` | `Boolean` | `IRasterReference rst` | `` |
| `IsRasterBinded` | `Boolean` | `String filename` | `` |
| `IsRasterError` | `Boolean` | `IRasterReference rst` | `` |
| `IsRasterError` | `Boolean` | `String filename` | `` |
| `Line` | `Void` | `Vector3F a, Vector3F b` | `` |
| `LoadIdentity` | `Void` | `` | `` |
| `MultMatrix` | `Void` | `ref Matrix matrix` | `` |
| `PopMatrix` | `Void` | `` | `` |
| `Project` | `Vector3F` | `Vector3F position` | `` |
| `PushMatrix` | `Void` | `` | `` |
| `RequestRedraw` | `Void` | `` | `` |
| `Reset` | `Void` | `` | `` |
| `ResetLinetype` | `Void` | `` | `` |
| `RotateOz` | `Void` | `Double radians` | `` |
| `RotateOz` | `Void` | `Double sinA, Double cosA` | `` |
| `Scale` | `Void` | `Double value` | `` |
| `Scale` | `Void` | `Double dX, Double dY` | `` |
| `Scale` | `Void` | `Double dX, Double dY, Double dZ` | `` |
| `ScaleAnotations` | `Void` | `Double scale` | `` |
| `SimplifyBounds3d` | `Void` | `BoundingBox3D bounds, Matrix matrix` | `` |
| `Translate` | `Void` | `Double dX, Double dY` | `` |
| `Translate` | `Void` | `Double dX, Double dY, Double dZ` | `` |
| `Triangle` | `Void` | `Vector3F a, Vector3F b, Vector3F c` | `` |
| `Vertex` | `Void` | `Vector3F pt` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `BackgroundTaskComplete` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `DeviceResource` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.DeviceResource` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(DeviceContext dc)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DeviceContext` | `DeviceContext` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `DisplaceType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+DisplaceType` |
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
      - `Topomatic.Cad.Foundation.CompoundLine+DisplaceType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arc` | `DisplaceType` | Yes | `Arc` | `` |
| `Clothoid` | `DisplaceType` | Yes | `Clothoid` | `` |
| `None` | `DisplaceType` | Yes | `None` | `` |
| `Parabola` | `DisplaceType` | Yes | `Parabola` | `` |
| `Straight` | `DisplaceType` | Yes | `Straight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Straight` | `1` |
| `Clothoid` | `2` |
| `Arc` | `3` |
| `Parabola` | `4` |

**Underlying Type**: `System.Int32`

### `DrawingMode` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.DrawingMode` |
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
      - `Topomatic.Cad.Foundation.DrawingMode`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Check` | `DrawingMode` | Yes | `Check` | `` |
| `Drag` | `DrawingMode` | Yes | `Drag` | `` |
| `Highlight` | `DrawingMode` | Yes | `Highlight` | `` |
| `Print` | `DrawingMode` | Yes | `Print` | `` |
| `Show` | `DrawingMode` | Yes | `Show` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Show` | `1` |
| `Check` | `2` |
| `Drag` | `3` |
| `Print` | `4` |
| `Highlight` | `5` |

**Underlying Type**: `System.Byte`

### `FastIntervalSearcher` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.FastIntervalSearcher` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Double GridStep)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `GridStep` | `Double` | `get` | No | `` |
| `MaxValue` | `Double` | `get` | No | `` |
| `MinValue` | `Double` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Double value, Double length_before, Int32 index` | `` |
| `Clear` | `Void` | `` | `` |
| `FastSearch` | `IEnumerable<Int32>` | `Double value` | `` |

### `FileRasterReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.FileRasterReference` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IRasterReference` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String fullpath)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Sha1` | `Hash` | `get` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Load` | `Bitmap` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IRasterReference` | `get_Id` |
| `IRasterReference` | `get_Sha1` |
| `IRasterReference` | `Load` |
| `IRasterReference` | `get_Valid` |

### `FloatConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ValueConverter+FloatConverter` |
| **Base Type** | `Topomatic.Cad.Foundation.ValueConverter+BaseFloatConverter` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ValueConverter+BaseFloatConverter`
    - `Topomatic.Cad.Foundation.ValueConverter+FloatConverter`

#### Constructors (1)

- `.ctor(Int32 digits)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Digits` | `Int32` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FloatToStr` | `String` | `Double value, Int32 digits, Boolean showZeroFeet` | `` |
| `FloatToStr` | `String` | `Double value, Int32 digits` | `` |
| `FloatToStr` | `String` | `Double value` | `` |
| `StrToFloat` | `Double` | `String value` | `` |
| `TryStrToFloat` | `Boolean` | `String value, ref Double result` | `` |

### `FontManager` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.FontManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `FontManager` | `get` | Yes | `` |
| `DefaultFont` | `CadFont` | `get` | No | `` |
| `Item` | `CadFont` | `get` | No | `` |
| `LoadedSHX` | `IEnumerable<String>` | `get` | No | `` |
| `LoadedTTF` | `IEnumerable<String>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String filename` | `` |
| `SearchSHX` | `ShapeFont` | `String name` | `` |
| `SearchTTF` | `CadFont` | `String name` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CorrectFontPathName` | `String` | `String name` | `` |

### `GraphicResource` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.GraphicResource` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `HighlightMode` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.HighlightMode` |
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
      - `Topomatic.Cad.Foundation.HighlightMode`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Black` | `HighlightMode` | Yes | `Black` | `` |
| `Color` | `HighlightMode` | Yes | `Color` | `` |
| `DoubleBlack` | `HighlightMode` | Yes | `DoubleBlack` | `` |
| `Solid` | `HighlightMode` | Yes | `Solid` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Xor` | `HighlightMode` | Yes | `Xor` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Solid` | `0` |
| `Black` | `1` |
| `Color` | `2` |
| `Xor` | `3` |
| `DoubleBlack` | `4` |

**Underlying Type**: `System.Int32`

### `IBoundedObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |

### `IChord` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IChord` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Chord` | `Int32` | `get` | No | `` |

### `IChordCurve` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IChordCurve` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetChord` | `IStationingCurve` | `Int32 chord` | `` |

### `IColoredObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IColoredObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `CadColor` | `get/set` | No | `` |

### `ICompoundLinearObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ICompoundLinearObject` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPathList` | `Void` | `IList<IPathItem> pathList` | `` |

### `IConsole` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IConsole` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `RequestString` | `String` | `get/set` | No | `` |
| `ResponseString` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Commit` | `Void` | `` | `` |
| `Write` | `Void` | `String s` | `` |
| `WriteLine` | `Void` | `String s` | `` |

### `ICurve` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ICurve` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `D0` | `Boolean` | `Double u, ref Vector3D p` | `` |
| `D1` | `Boolean` | `Double u, ref Vector3D p, ref Vector3D tg` | `` |
| `Project` | `Boolean` | `Vector3D p, ref Double u` | `` |
| `Tesselate` | `IEnumerable<Double>` | `Double u1, Double u2, Double eps` | `` |

### `IElevationProvider` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IElevationProvider` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |

### `IGraphics` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IGraphics` |
| **Base Type** | `none` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Color` | `get/set` | No | `` |
| `Thickness` | `Single` | `get/set` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginGraphics` | `Void` | `` | `` |
| `DrawEllipse` | `Void` | `Single x, Single y, Single width, Single height` | `` |
| `DrawImage` | `Void` | `Image image, RectangleF destRect, RectangleF srcRect` | `` |
| `DrawLine` | `Void` | `Single x1, Single y1, Single x2, Single y2` | `` |
| `DrawRectangle` | `Void` | `Single x, Single y, Single width, Single height` | `` |
| `DrawString` | `Void` | `String s, Font font, Single x, Single y` | `` |
| `EndGraphics` | `Void` | `` | `` |
| `FillEllipse` | `Void` | `Single x, Single y, Single width, Single height` | `` |
| `FillRectangle` | `Void` | `Single x, Single y, Single width, Single height` | `` |
| `FillTriangle` | `Void` | `Single x1, Single y1, Single x2, Single y2, Single x3, Single y3` | `` |
| `ResetClip` | `Void` | `` | `` |
| `SetClip` | `Void` | `RectangleF rect` | `` |

### `IGraphicsExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IGraphicsExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (38)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `DrawClosedCurve` | `Void` | `IGraphics graphics, PointF[] points` | `Extension` |
| `DrawClosedCurve` | `Void` | `IGraphics graphics, Point[] points` | `Extension` |
| `DrawCurve` | `Void` | `IGraphics graphics, PointF[] points` | `Extension` |
| `DrawCurve` | `Void` | `IGraphics graphics, Point[] points` | `Extension` |
| `DrawEllipse` | `Void` | `IGraphics graphics, PointF point, SizeF size` | `Extension` |
| `DrawEllipse` | `Void` | `IGraphics graphics, Point point, Size size` | `Extension` |
| `DrawEllipse` | `Void` | `IGraphics graphics, Int32 x, Int32 y, Int32 width, Int32 height` | `Extension` |
| `DrawEllipse` | `Void` | `IGraphics graphics, RectangleF rect` | `Extension` |
| `DrawEllipse` | `Void` | `IGraphics graphics, Rectangle rect` | `Extension` |
| `DrawImage` | `Void` | `IGraphics graphics, Image image, Single x, Single y, Single width, Single height` | `Extension` |
| `DrawImage` | `Void` | `IGraphics graphics, Image image, Point point` | `Extension` |
| `DrawImage` | `Void` | `IGraphics graphics, Image image, Int32 x, Int32 y` | `Extension` |
| `DrawImage` | `Void` | `IGraphics graphics, Image image, Single x, Single y` | `Extension` |
| `DrawImage` | `Void` | `IGraphics graphics, Image image, PointF point` | `Extension` |
| `DrawLine` | `Void` | `IGraphics graphics, Point a, Point b` | `Extension` |
| `DrawLine` | `Void` | `IGraphics graphics, PointF a, PointF b` | `Extension` |
| `DrawLine` | `Void` | `IGraphics graphics, Int32 x1, Int32 y1, Int32 x2, Int32 y2` | `Extension` |
| `DrawLines` | `Void` | `IGraphics graphics, Point[] points` | `Extension` |
| `DrawLines` | `Void` | `IGraphics graphics, PointF[] points` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, Int32 x, Int32 y, Int32 width, Int32 height` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, Pen pen, Rectangle rect` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, PointF point, SizeF size` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, Point point, Size size` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, Rectangle rect` | `Extension` |
| `DrawRectangle` | `Void` | `IGraphics graphics, RectangleF rect` | `Extension` |
| `DrawString` | `Void` | `IGraphics graphics, String s, Font font, Int32 x, Int32 y` | `Extension` |
| `DrawString` | `Void` | `IGraphics graphics, String s, Font font, Brush brush, Point location` | `Extension` |
| `FillEllipse` | `Void` | `IGraphics graphics, RectangleF rect` | `Extension` |
| `FillEllipse` | `Void` | `IGraphics graphics, Rectangle rect` | `Extension` |
| `FillEllipse` | `Void` | `IGraphics graphics, Point point, Size size` | `Extension` |
| `FillEllipse` | `Void` | `IGraphics graphics, PointF point, SizeF size` | `Extension` |
| `FillEllipse` | `Void` | `IGraphics graphics, Int32 x, Int32 y, Int32 width, Int32 height` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, Rectangle rect` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, PointF point, SizeF size` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, Int32 x, Int32 y, Int32 width, Int32 height` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, Point point, Size size` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, Brush brush, Rectangle rect` | `Extension` |
| `FillRectangle` | `Void` | `IGraphics graphics, RectangleF rect` | `Extension` |

### `ILinearObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ILinearObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |

### `IObjectDisjoiner` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |

### `IPointObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IPointObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get` | No | `` |

### `IPolyline2DCurveContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IPolyline2DCurveContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Polyline2DCurve` | `` | `` |

### `IPolyline3D` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IPolyline3D` |
| **Base Type** | `none` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get/set` | No | `` |

### `IRasterReference` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IRasterReference` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Sha1` | `Hash` | `get` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Load` | `Bitmap` | `` | `` |

### `IRelativeAngle` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IRelativeAngle` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.IPointObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AnglePoint` | `Vector3D` | `get` | No | `` |
| `CounterClockwise` | `Boolean` | `get` | No | `` |

### `IStateElevationProviderFactory` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IStateElevationProviderFactory` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `StateElevationProvider` | `` | `` |

### `IStationingCurve` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.IStationingCurve` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

### `Item` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+Item` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.CompoundLine+Item`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `DisplaceType` | `DisplaceType` | `get` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `EndSta` | `Double` | `get` | No | `` |
| `ItemType` | `ItemType` | `get` | No | `` |
| `KX` | `Double` | `get/set` | No | `` |
| `KY` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `StartPos` | `Vector2D` | `get/set` | No | `` |
| `StartSta` | `Double` | `get` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `PosToStaOffset` | `Boolean` | `Vector2D pos, ref Double sta, ref Double offset` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double sta, Double offset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `ItemType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+ItemType` |
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
      - `Topomatic.Cad.Foundation.CompoundLine+ItemType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arc` | `ItemType` | Yes | `Arc` | `` |
| `Clothoid` | `ItemType` | Yes | `Clothoid` | `` |
| `Parabola` | `ItemType` | Yes | `Parabola` | `` |
| `Straight` | `ItemType` | Yes | `Straight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Straight` | `0` |
| `Arc` | `1` |
| `Clothoid` | `2` |
| `Parabola` | `3` |

**Underlying Type**: `System.Int32`

### `ITransformedObject` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ITransformedObject` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Position` | `Vector3D` | `get` | No | `` |
| `Rotation` | `Double` | `get` | No | `` |
| `Scale` | `Vector3D` | `get` | No | `` |

### `Joiner`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Joiner`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEqualityComparer<T> comparer)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Join` | `Void` | `IEnumerable<JoinSegment<T>> segments, IList<IList<T>> collection` | `` |

#### Nested Types (2)

- `JoinSegment` (struct)
- `JoinSegmentComparer` (class)

### `Joiner2DSegments` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Joiner2DSegments` |
| **Base Type** | `Topomatic.Cad.Foundation.JoinerSegments`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.JoinerSegments`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Joiner2DSegments`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`

### `Joiner3DSegments` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Joiner3DSegments` |
| **Base Type** | `Topomatic.Cad.Foundation.JoinerSegments`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.JoinerSegments`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Joiner3DSegments`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`

### `JoinerSegments`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.JoinerSegments`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(CoordsJoiner<T> coordsJoiner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T a, T b` | `` |
| `Clear` | `Void` | `` | `` |
| `GetItems` | `IEnumerable<T>` | `` | `` |
| `GetSegments` | `IEnumerable<JoinSegment<T>>` | `` | `` |

### `JoinSegment<T where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Joiner`1+JoinSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Joiner`1+JoinSegment`

#### Constructors (1)

- `.ctor(T a, T b)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `T` | No | `` | `` |
| `B` | `T` | No | `` | `` |

### `JoinSegmentComparer<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Joiner`1+JoinSegmentComparer` |
| **Base Type** | `System.Object` |
| **Implements** | `` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(IEqualityComparer<T> comparer)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `JoinSegment<T> x, JoinSegment<T> y` | `` |
| `GetHashCode` | `Int32` | `JoinSegment<T> obj` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEqualityComparer`1` | `Equals` |
| `IEqualityComparer`1` | `GetHashCode` |

### `Line2D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Line2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Line2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Line2D`

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Line2D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Move` | `Void` | `Double deltaX, Double deltaY` | `` |
| `Move` | `Void` | `Vector2D delta` | `` |
| `Normal` | `Line2D` | `Vector2D point` | `` |
| `Normalize` | `Void` | `` | `` |
| `Parallel` | `Line2D` | `Vector2D point` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateLine2D` | `Line2D` | `Vector2D point, Double angle` | `` |
| `CreateLine2D` | `Line2D` | `Vector2D point, Double dX, Double dY` | `` |
| `CreateLine2D` | `Line2D` | `Vector2D pos1, Vector2D pos2` | `` |
| `LoadFromStg` | `Line2D` | `StgNode stgNode` | `` |
| `SectLines` | `Vector2D` | `Line2D l1, Line2D l2` | `` |
| `TryCreateLine2D` | `Boolean` | `Vector2D pos, Double dX, Double dY, ref Line2D line` | `` |
| `TryCreateLine2D` | `Boolean` | `Vector2D pos1, Vector2D pos2, ref Line2D line` | `` |
| `TrySectLines` | `Boolean` | `ref Line2D l1, ref Line2D l2, ref Vector2D point` | `` |
| `TrySectLines` | `Boolean` | `Line2D l1, Line2D l2, ref Vector2D point` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `Double` | No | `` | `` |
| `B` | `Double` | No | `` | `` |
| `C` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Line3D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Line3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Line3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Line3D`

#### Constructors (2)

- `.ctor(Plane p1, Plane p2)`
- `.ctor(Vector3D position, Vector3D direction)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `Line3D other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Direction` | `Vector3D` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `LineCapJoin` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.LineCapJoin` |
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
      - `Topomatic.Cad.Foundation.LineCapJoin`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Round` | `LineCapJoin` | Yes | `Round` | `` |
| `Square` | `LineCapJoin` | Yes | `Square` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Square` | `0` |
| `Round` | `1` |

**Underlying Type**: `System.Int32`

### `LineSegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.LineSegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.LineSegment`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndPoint` | `Vector3D` | No | `` | `` |
| `StartPoint` | `Vector3D` | No | `` | `` |

### `LinetypePattern` (class)

**Attributes**: [ClassInterface, DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.LinetypePattern` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.ICloneable, System.IEquatable`1[[Topomatic.Cad.Foundation.LinetypePattern, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Capacity` | `Int32` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `HaveShapeDash` | `Boolean` | `get` | No | `` |
| `Item` | `LinetypePatternItem` | `get` | No | `` |
| `TotalPatternLength` | `Double` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `LinetypePatternItem` | `` | `` |
| `Assign` | `Void` | `LinetypePattern linetype` | `` |
| `Clear` | `Void` | `` | `` |
| `Clone` | `Object` | `` | `` |
| `Equals` | `Boolean` | `LinetypePattern other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICloneable` | `Clone` |
| `IEquatable`1` | `Equals` |

### `LinetypePatternElementType` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.LinetypePatternElementType` |
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
      - `Topomatic.Cad.Foundation.LinetypePatternElementType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `etAbsoluteRotation` | `LinetypePatternElementType` | Yes | `etAbsoluteRotation` | `` |
| `etShape` | `LinetypePatternElementType` | Yes | `etShape` | `` |
| `etSimple` | `LinetypePatternElementType` | Yes | `etSimple` | `` |
| `etTextString` | `LinetypePatternElementType` | Yes | `etTextString` | `` |
| `value__` | `Byte` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `etSimple` | `0` |
| `etAbsoluteRotation` | `1` |
| `etTextString` | `2` |
| `etShape` | `4` |

**Underlying Type**: `System.Byte`

### `LinetypePatternItem` (class)

**Attributes**: [ClassInterface]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.LinetypePatternItem` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.IEquatable`1[[Topomatic.Cad.Foundation.LinetypePatternItem, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DashDotLength` | `Double` | `get/set` | No | `` |
| `ElementType` | `LinetypePatternElementType` | `get/set` | No | `` |
| `Filename` | `String` | `get/set` | No | `` |
| `Font` | `CadFont` | `get` | No | `` |
| `Height` | `Double` | `get/set` | No | `` |
| `IsAbsoluteRotation` | `Boolean` | `get` | No | `` |
| `IsShape` | `Boolean` | `get` | No | `` |
| `IsSimpleDashDot` | `Boolean` | `get` | No | `` |
| `IsTextString` | `Boolean` | `get` | No | `` |
| `Rotation` | `Double` | `get/set` | No | `` |
| `Scale` | `Double` | `get/set` | No | `` |
| `ShapeNumber` | `UInt16` | `get/set` | No | `` |
| `Style` | `String` | `get/set` | No | `` |
| `TextString` | `String` | `get/set` | No | `` |
| `XOffset` | `Double` | `get/set` | No | `` |
| `YOffset` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `LinetypePatternItem other` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEquatable`1` | `Equals` |

### `ManagedBuffer`1<T where class>` (class)

**Attributes**: [DefaultMember, DebuggerDisplay]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ManagedBuffer`1` |
| **Base Type** | `System.Object` |
| **Implements** | `, , System.Collections.IEnumerable, ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`
- `.ctor(IEnumerable<T> collection)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Capacity` | `Int32` | `get/set` | No | `` |
| `Count` | `Int32` | `get/set` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Instance Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T item` | `` |
| `AddRange` | `Void` | `IEnumerable<T> collection` | `` |
| `AsReadOnly` | `ReadOnlyCollection<T>` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `ClearFast` | `Void` | `` | `` |
| `Contains` | `Boolean` | `T item` | `` |
| `CopyTo` | `Void` | `T[] array, Int32 arrayIndex` | `` |
| `GetBuffer` | `T[]` | `` | `` |
| `GetEnumerator` | `IEnumerator<T>` | `` | `` |
| `IndexOf` | `Int32` | `T item` | `` |
| `Insert` | `Void` | `Int32 index, T item` | `` |
| `Remove` | `Boolean` | `T item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `RemoveRange` | `Void` | `Int32 index, Int32 count` | `` |
| `TrimExcess` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection`1` | `get_Count` |
| `ICollection`1` | `System.Collections.Generic.ICollection<T>.get_IsReadOnly` |
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

### `MathHelper` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.MathHelper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Barycentric` | `Single` | `Single value1, Single value2, Single value3, Single amount1, Single amount2` | `` |
| `CatmullRom` | `Single` | `Single value1, Single value2, Single value3, Single value4, Single amount` | `` |
| `Clamp` | `Single` | `Single value, Single min, Single max` | `` |
| `Distance` | `Single` | `Single value1, Single value2` | `` |
| `Hermite` | `Single` | `Single value1, Single tangent1, Single value2, Single tangent2, Single amount` | `` |
| `Lerp` | `Double` | `Double value1, Double value2, Double amount` | `` |
| `Lerp` | `Single` | `Single value1, Single value2, Single amount` | `` |
| `Max` | `Single` | `Single value1, Single value2` | `` |
| `Min` | `Single` | `Single value1, Single value2` | `` |
| `SmoothStep` | `Single` | `Single value1, Single value2, Single amount` | `` |
| `ToDegrees` | `Single` | `Single radians` | `` |
| `ToRadians` | `Single` | `Single degrees` | `` |
| `WrapAngle` | `Single` | `Single angle` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `E` | `Single` | Yes | `2.718282` | `` |
| `Log10E` | `Single` | Yes | `0.4342945` | `` |
| `Log2E` | `Single` | Yes | `1.442695` | `` |
| `Pi` | `Single` | Yes | `3.141593` | `` |
| `PiOver2` | `Single` | Yes | `1.570796` | `` |
| `PiOver4` | `Single` | Yes | `0.7853982` | `` |
| `TwoPi` | `Single` | Yes | `6.283185` | `` |

### `Matrix` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Matrix` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Matrix, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Matrix`

#### Constructors (3)

- `.ctor(Single* matrix)`
- `.ctor(Double* matrix)`
- `.ctor(Double m11, Double m12, Double m13, Double m14, Double m21, Double m22, Double m23, Double m24, Double m31, Double m32, Double m33, Double m34, Double m41, Double m42, Double m43, Double m44)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Backward` | `Vector3D` | `get/set` | No | `` |
| `Down` | `Vector3D` | `get/set` | No | `` |
| `Forward` | `Vector3D` | `get/set` | No | `` |
| `Identity` | `Matrix` | `get` | Yes | `` |
| `Left` | `Vector3D` | `get/set` | No | `` |
| `Right` | `Vector3D` | `get/set` | No | `` |
| `Translation` | `Vector3D` | `get/set` | No | `` |
| `Up` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Determinant` | `Double` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `Matrix other` | `` |
| `GetExtrudedInsertion` | `Void` | `ref Vector3D position, ref Vector3D scale, ref Vector3D normal, ref Double angle` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetInsertion` | `Void` | `ref Vector3D position, ref Vector3D scale, ref Double angle` | `` |
| `NormalAngle` | `Void` | `ref Vector3D normal, ref Double angle` | `` |
| `OxOy` | `Void` | `ref Vector3D ox, ref Vector3D oy` | `` |
| `Project` | `Vector3D` | `Vector3D position, Double x, Double y, Double width, Double height, Double minz, Double maxz` | `` |
| `Project` | `Vector3D` | `Vector3D position` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToDoubleArray` | `Double[]` | `` | `` |
| `ToEuler` | `Vector3D` | `` | `` |
| `ToFloatArray` | `Single[]` | `` | `` |
| `ToGdippMatrix` | `Matrix` | `` | `` |
| `ToGdippMatrixWithoutTranslation` | `Matrix` | `` | `` |
| `ToSequence` | `Vector3D` | `` | `` |
| `ToString` | `String` | `` | `` |
| `Unproject` | `Vector3D` | `Vector3D position, Double x, Double y, Double width, Double height, Double minz, Double maxz` | `` |

#### Static Methods (64)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateBillboard` | `Void` | `ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D cameraUpVector, Nullable<Vector3D> cameraForwardVector, ref Matrix result` | `` |
| `CreateBillboard` | `Matrix` | `Vector3D objectPosition, Vector3D cameraPosition, Vector3D cameraUpVector, Nullable<Vector3D> cameraForwardVector` | `` |
| `CreateConstrainedBillboard` | `Void` | `ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D rotateAxis, Nullable<Vector3D> cameraForwardVector, Nullable<Vector3D> objectForwardVector, ref Matrix result` | `` |
| `CreateConstrainedBillboard` | `Matrix` | `Vector3D objectPosition, Vector3D cameraPosition, Vector3D rotateAxis, Vector3D cameraForwardVector, Vector3D objectForwardVector` | `` |
| `CreateExtrudedInsertion` | `Matrix` | `Vector3D position, Vector3D scale, Vector3D normal, Double angle` | `` |
| `CreateExtrusion` | `Matrix` | `Vector3D extrusion` | `` |
| `CreateExtrusion` | `Matrix` | `Vector3D normal, Double angle` | `` |
| `CreateFromAxisAngle` | `Void` | `ref Vector3D axis, Double angle, ref Matrix result` | `` |
| `CreateFromAxisAngle` | `Matrix` | `Vector3D axis, Double angle` | `` |
| `CreateInsertion` | `Matrix` | `Vector3D position, Vector3D scale, Vector3D ox, Vector3D oy` | `` |
| `CreateInsertion` | `Matrix` | `Vector3D position, Vector3D scale, Double angle` | `` |
| `CreateLookAt` | `Matrix` | `Vector3D cameraPosition, Vector3D cameraTarget, Vector3D cameraUpVector` | `` |
| `CreateLookAt` | `Void` | `ref Vector3D cameraPosition, ref Vector3D cameraTarget, ref Vector3D cameraUpVector, ref Matrix result` | `` |
| `CreateMirror` | `Matrix` | `Vector2D a, Vector2D b` | `` |
| `CreateOrthographic` | `Matrix` | `Double width, Double height, Double zNearPlane, Double zFarPlane` | `` |
| `CreateOrthographic` | `Void` | `Double width, Double height, Double zNearPlane, Double zFarPlane, ref Matrix result` | `` |
| `CreateOrthographicOffCenter` | `Void` | `Double left, Double right, Double bottom, Double top, Double zNearPlane, Double zFarPlane, ref Matrix result` | `` |
| `CreateOrthographicOffCenter` | `Matrix` | `Double left, Double right, Double bottom, Double top, Double zNearPlane, Double zFarPlane` | `` |
| `CreatePerspective` | `Matrix` | `Double width, Double height, Double nearPlaneDistance, Double farPlaneDistance` | `` |
| `CreatePerspective` | `Void` | `Double width, Double height, Double nearPlaneDistance, Double farPlaneDistance, ref Matrix result` | `` |
| `CreatePerspectiveFieldOfView` | `Void` | `Double fieldOfView, Double aspectRatio, Double nearPlaneDistance, Double farPlaneDistance, ref Matrix result` | `` |
| `CreatePerspectiveFieldOfView` | `Matrix` | `Double fieldOfView, Double aspectRatio, Double nearPlaneDistance, Double farPlaneDistance` | `` |
| `CreatePerspectiveLensLength` | `Matrix` | `Double lensLength, Double width, Double height, Double nearPlaneDistance, Double farPlaneDistance` | `` |
| `CreatePerspectiveOffCenter` | `Matrix` | `Double left, Double right, Double bottom, Double top, Double nearPlaneDistance, Double farPlaneDistance` | `` |
| `CreatePerspectiveOffCenter` | `Void` | `Double left, Double right, Double bottom, Double top, Double nearPlaneDistance, Double farPlaneDistance, ref Matrix result` | `` |
| `CreateRotationAt` | `Matrix` | `Vector2D basePoint, Double angle` | `` |
| `CreateRotationOxOy` | `Matrix` | `Vector3D ox, Vector3D oy` | `` |
| `CreateRotationX` | `Matrix` | `Double sinA, Double cosA` | `` |
| `CreateRotationX` | `Void` | `Double radians, ref Matrix result` | `` |
| `CreateRotationX` | `Matrix` | `Double radians` | `` |
| `CreateRotationY` | `Matrix` | `Double radians` | `` |
| `CreateRotationY` | `Matrix` | `Double sinA, Double cosA` | `` |
| `CreateRotationY` | `Void` | `Double radians, ref Matrix result` | `` |
| `CreateRotationZ` | `Void` | `Double sinA, Double cosA, ref Matrix result` | `` |
| `CreateRotationZ` | `Matrix` | `Double sinA, Double cosA` | `` |
| `CreateRotationZ` | `Matrix` | `Double radians` | `` |
| `CreateRotationZ` | `Void` | `Double radians, ref Matrix result` | `` |
| `CreateScale` | `Matrix` | `Double xScale, Double yScale, Double zScale` | `` |
| `CreateScale` | `Void` | `Double xScale, Double yScale, Double zScale, ref Matrix result` | `` |
| `CreateScale` | `Void` | `ref Vector3D scales, ref Matrix result` | `` |
| `CreateScale` | `Matrix` | `Double scale` | `` |
| `CreateScale` | `Void` | `Double scale, ref Matrix result` | `` |
| `CreateScale` | `Matrix` | `Vector3D scales` | `` |
| `CreateScaleAt` | `Matrix` | `Vector2D basePoint, Double scaleFactor` | `` |
| `CreateScaleAt` | `Matrix` | `Vector3D basePoint, Double scaleFactorX, Double scaleFactorY, Double scaleFactorZ` | `` |
| `CreateScaleAt` | `Matrix` | `Vector2D basePoint, Double scaleFactorX, Double scaleFactorY` | `` |
| `CreateTranslation` | `Matrix` | `Vector3D position` | `` |
| `CreateTranslation` | `Void` | `Double xPosition, Double yPosition, Double zPosition, ref Matrix result` | `` |
| `CreateTranslation` | `Matrix` | `Double xPosition, Double yPosition, Double zPosition` | `` |
| `CreateTranslation` | `Void` | `ref Vector3D position, ref Matrix result` | `` |
| `CreateUCS` | `Matrix` | `Vector3D position, Vector3D ox, Vector3D oy, Vector3D oz` | `` |
| `CreateView` | `Matrix` | `Vector3D target, Vector3D direction, Double twist` | `` |
| `GetAxis` | `Void` | `Vector3D zaxis, Double twist, ref Vector3D xaxis, ref Vector3D yaxis` | `` |
| `GetRotation` | `Vector3F` | `Matrix rotation` | `` |
| `GetView` | `Void` | `Matrix matrix, ref Vector3D eye, ref Vector3D zaxis, ref Double twist` | `` |
| `Invert` | `Matrix` | `Matrix matrix` | `` |
| `Invert` | `Void` | `ref Matrix matrix, ref Matrix result` | `` |
| `Lerp` | `Void` | `ref Matrix matrix1, ref Matrix matrix2, Double amount, ref Matrix result` | `` |
| `Lerp` | `Matrix` | `Matrix matrix1, Matrix matrix2, Double amount` | `` |
| `LoadFromStg` | `Matrix` | `StgNode node` | `` |
| `Mult` | `Matrix` | `ref Matrix matrix1, ref Matrix matrix2` | `` |
| `Mult` | `Void` | `ref Matrix matrix1, ref Matrix matrix2, ref Matrix matrix` | `` |
| `Transpose` | `Matrix` | `Matrix matrix` | `` |
| `Transpose` | `Void` | `ref Matrix matrix, ref Matrix result` | `` |

#### Fields (16)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `M11` | `Double` | No | `` | `` |
| `M12` | `Double` | No | `` | `` |
| `M13` | `Double` | No | `` | `` |
| `M14` | `Double` | No | `` | `` |
| `M21` | `Double` | No | `` | `` |
| `M22` | `Double` | No | `` | `` |
| `M23` | `Double` | No | `` | `` |
| `M24` | `Double` | No | `` | `` |
| `M31` | `Double` | No | `` | `` |
| `M32` | `Double` | No | `` | `` |
| `M33` | `Double` | No | `` | `` |
| `M34` | `Double` | No | `` | `` |
| `M41` | `Double` | No | `` | `` |
| `M42` | `Double` | No | `` | `` |
| `M43` | `Double` | No | `` | `` |
| `M44` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `ObjectsDisjointerArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ObjectsDisjointerArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Cad.Foundation.ObjectsDisjointerArgs`

#### Constructors (1)

- `.ctor(BoundingBox2D box)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Box` | `BoundingBox2D` | `get` | No | `` |

### `OptLib` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+OptLib` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SolveDichotomy` | `Double` | `Func<Double Double> f, Double a, Double b, Double eps` | `` |
| `SolveGradient` | `Void` | `Func<Double Double Double> f, ref Double x1, ref Double x2` | `` |
| `SolveNewton` | `Boolean` | `Func<Double Double> f, ref Double x, Double eps, Int32 maxIter` | `` |
| `SolveNewton` | `Void` | `Func<Double Double Double> f1, Func<Double Double Double> f2, ref Double x1, ref Double x2, Double eps, Int32 maxIter` | `` |
| `SolveNewton` | `Boolean` | `VectorFunction2 f, ref Double x1, ref Double x2, Double eps, Int32 maxIter` | `` |
| `SolveSequanceVariation` | `Void` | `Func<Double Double Double> f, ref Double x1, ref Double x2` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `eps` | `Double` | Yes | `0.0001` | `` |
| `maxIter` | `Int32` | Yes | `20` | `` |

#### Nested Types (1)

- `VectorFunction2` (class)

### `OrientationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.OrientationType` |
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
      - `Topomatic.Cad.Foundation.OrientationType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Clockwise` | `OrientationType` | Yes | `Clockwise` | `` |
| `CounterClockwise` | `OrientationType` | Yes | `CounterClockwise` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Clockwise` | `1` |
| `CounterClockwise` | `-1` |

**Underlying Type**: `System.Int32`

### `OverlayOperation` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.OverlayOperation` |
| **Base Type** | `Topomatic.Cad.Foundation.BaseOverlayOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.BaseOverlayOperation`
      - `Topomatic.Cad.Foundation.OverlayOperation`

### `ParabolaItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+ParabolaItem` |
| **Base Type** | `Topomatic.Cad.Foundation.CompoundLine+Item` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.CompoundLine+Item`
      - `Topomatic.Cad.Foundation.CompoundLine+ParabolaItem`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `A` | `Double` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `ItemType` | `get` | No | `` |
| `P` | `Double` | `get/set` | No | `` |
| `Rotation` | `Double` | `get` | No | `` |
| `StartLength` | `Double` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPositionByStation` | `Vector2D` | `Double station, Boolean translated` | `` |
| `GetYbyX` | `Double` | `Double x` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double sta, Double offset` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetKxKy` | `Void` | `Vector2D pos, Double p, ref Double kx, ref Double ky` | `` |
| `GetP` | `Double` | `Vector2D parabolaPos` | `` |
| `LengthByX` | `Double` | `Double p, Double x` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `PathListExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PathListExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ContainsPos` | `Boolean` | `IPathItem pathItem, Vector2D p` | `Extension` |
| `ContainsPos` | `Boolean` | `ICompoundLinearObject compLinObj, Vector2D p` | `Extension` |
| `ConvertToPathList` | `Void` | `IPolyline3D poly, IList<IPathItem> list` | `Extension` |
| `CutBetweenSta` | `List<IPathItem>` | `IList<IPathItem> pL, Double sta1, Double sta2` | `Extension` |
| `CutBetweenSta` | `IPathItem` | `IPathItem pathItem, Double sta1, Double sta2` | `Extension` |
| `ExtractArc` | `Nullable<ArcStruc>` | `ILinearObject obj, Vector2D pos` | `Extension` |
| `ExtractClothoid` | `Nullable<ClothoidStruc>` | `ICompoundLinearObject compLinObj, Vector2D pos` | `Extension` |
| `ExtractSegment` | `Nullable<SegmentStruc>` | `ILinearObject obj, Vector2D pos` | `Extension` |
| `GetCrossPoses` | `IEnumerable<Vector2D>` | `IPathItem pItem, IPathItem qItem` | `Extension` |
| `GetCrossPoses` | `IEnumerable<Vector2D>` | `IPathItem pItem, Line2D line` | `Extension` |
| `GetLength` | `Double` | `IList<IPathItem> pL` | `Extension` |
| `GetSegmentBySta` | `IPathItem` | `IList<IPathItem> pathList, Double sta, ref Double prevLen, ref Int32 index` | `Extension` |
| `GetStartSta` | `Double` | `IList<IPathItem> pL, Int32 index` | `` |
| `GetTangentAngle` | `Boolean` | `IList<IPathItem> pL, Double sta, ref Double angle` | `Extension` |
| `PolylineRepresentationToPathList` | `Void` | `ILinearObject linear, IList<IPathItem> pathList` | `Extension` |
| `PosToClothoidStruc` | `Boolean` | `ICompoundLinearObject compLinObj, Vector2D point, ref ClothoidStruc cloth` | `Extension` |
| `PosToPathItem` | `Boolean` | `ICompoundLinearObject compLinObj, Vector2D point, ref IPathItem pathItem` | `Extension` |
| `PosToStaOffset` | `Boolean` | `IList<IPathItem> pathList, Vector2D pos, ref Double sta, ref Double offset` | `Extension` |
| `PosToStaOffset` | `Boolean` | `ICompoundLinearObject compLinObj, Vector2D pos, ref Double sta, ref Double offset` | `Extension` |
| `ReversedPathList` | `List<IPathItem>` | `List<IPathItem> pathList` | `Extension` |
| `SectOtherPathListWithoutClothoids` | `Void` | `IList<IPathItem> pL, IList<IPathItem> qL, ref List<Vector2D> crossPoses` | `Extension` |
| `StaOffsetToPos` | `Boolean` | `IList<IPathItem> pathList, Double sta, Double offset, ref Vector2D pos` | `Extension` |

### `Plane` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Plane` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Plane, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Plane`

#### Constructors (5)

- `.ctor(Vector4D value)`
- `.ctor(Vector3D normal, Double d)`
- `.ctor(Vector3D normal, Vector3D position)`
- `.ctor(Vector3D point1, Vector3D point2, Vector3D point3)`
- `.ctor(Double a, Double b, Double c, Double d)`

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dot` | `Void` | `ref Vector4D value, ref Double result` | `` |
| `Dot` | `Double` | `Vector4D value` | `` |
| `DotCoordinate` | `Double` | `Vector3D value` | `` |
| `DotCoordinate` | `Void` | `ref Vector3D value, ref Double result` | `` |
| `DotNormal` | `Void` | `ref Vector3D value, ref Double result` | `` |
| `DotNormal` | `Double` | `Vector3D value` | `` |
| `Equals` | `Boolean` | `Plane other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersect` | `Vector3D` | `Line3D line` | `` |
| `Intersects` | `Void` | `ref BoundingBox3D box, ref PlaneIntersectionType result` | `` |
| `Intersects` | `PlaneIntersectionType` | `BoundingFrustum frustum` | `` |
| `Intersects` | `PlaneIntersectionType` | `BoundingSphere3D sphere` | `` |
| `Intersects` | `PlaneIntersectionType` | `BoundingBox3D box` | `` |
| `Intersects` | `Void` | `ref BoundingSphere3D sphere, ref PlaneIntersectionType result` | `` |
| `Normalize` | `Void` | `` | `` |
| `Project` | `Vector3D` | `Vector3D pt` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Normalize` | `Void` | `ref Plane value, ref Plane result` | `` |
| `Normalize` | `Plane` | `Plane value` | `` |
| `Transform` | `Void` | `ref Plane plane, ref Matrix matrix, ref Plane result` | `` |
| `Transform` | `Plane` | `Plane plane, Matrix matrix` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `D` | `Double` | No | `` | `` |
| `Normal` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `PlaneIntersectionType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PlaneIntersectionType` |
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
      - `Topomatic.Cad.Foundation.PlaneIntersectionType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Back` | `PlaneIntersectionType` | Yes | `Back` | `` |
| `Front` | `PlaneIntersectionType` | Yes | `Front` | `` |
| `Intersecting` | `PlaneIntersectionType` | Yes | `Intersecting` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Front` | `0` |
| `Back` | `1` |
| `Intersecting` | `2` |

**Underlying Type**: `System.Int32`

### `PolygonFillType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonsClipper+PolygonFillType` |
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
      - `Topomatic.Cad.Foundation.PolygonsClipper+PolygonFillType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EvenOdd` | `PolygonFillType` | Yes | `EvenOdd` | `` |
| `NonZero` | `PolygonFillType` | Yes | `NonZero` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `EvenOdd` | `0` |
| `NonZero` | `1` |

**Underlying Type**: `System.Int32`

### `PolygonOperation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonOperation` |
| **Base Type** | `Topomatic.Cad.Foundation.OverlayOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.BaseOverlayOperation`
      - `Topomatic.Cad.Foundation.OverlayOperation`
        - `Topomatic.Cad.Foundation.PolygonOperation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Difference` | `List<List<Vector2D>>` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `Intersection` | `List<List<Vector2D>>` | `IList<Vector2D> A, IList<Vector2D> B` | `` |
| `Union` | `List<List<Vector2D>>` | `IList<Vector2D> A, IList<Vector2D> B` | `` |

### `PolygonOverlay` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonOverlay` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Static Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Difference` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `DifferenceEx` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `GetClockwised` | `IEnumerable<Vector2D>` | `IList<Vector2D> poly` | `` |
| `GetCounterClockwised` | `IEnumerable<Vector2D>` | `IList<Vector2D> poly` | `` |
| `GetCrossVertices` | `Void` | `IList<Vector2D> A, IList<Vector2D> B, List<Vector2D> crossVertices` | `` |
| `Intersection` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `IntersectionEx` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `IsPolyConvex` | `Boolean` | `IList<Vector2D> poly` | `` |
| `IsPosOnSegmentCorrect` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b, Double epsilon` | `` |
| `IsPosStronglyOnSegmentCorrect` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b, Double epsilon` | `` |
| `PolyOrientation` | `Int32` | `IList<Vector2D> poly` | `` |
| `PosInContourEdge` | `Boolean` | `Vector2D p, IList<Vector2D> contour, ref Int32 edgeIndex` | `` |
| `PosInContourEdge` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosInContourOrOnBorder` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosStrictlyInContour` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosStrictlyOutContour` | `Boolean` | `Vector2D p, IList<Vector2D> contour` | `` |
| `PosStronglyInContourEdge` | `Boolean` | `Vector2D p, IList<Vector2D> contour, ref Int32 edgeIndex` | `` |
| `SimplifyContour` | `List<List<Vector2D>>` | `IList<Vector2D> c` | `` |
| `SymmetricDifference` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `SymmetricDifferenceEx` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |
| `Union` | `Boolean` | `IList<Vector2D> a, IList<Vector2D> b, List<List<Vector2D>> solution` | `` |

### `PolygonsClipper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonsClipper` |
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
| `Bounds` | `BoundingBox2D` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygon` | `Void` | `IList<Vector2D> poly, PolygonType polyType` | `` |
| `AddPolygonsList` | `Void` | `IList<IList<Vector2D>> polyList, PolygonType polyType` | `` |
| `Clear` | `Void` | `` | `` |
| `Execute` | `Boolean` | `ClipTask clipTask, List<List<Vector2D>> solution, PolygonFillType subjFillType, PolygonFillType clipFillType` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Area` | `Double` | `IList<Vector2D> poly` | `` |
| `OffsetPolygons` | `List<List<Vector2D>>` | `IList<IList<Vector2D>> polyList, Double offset` | `` |
| `PolygonsIntersection` | `Boolean` | `IList<Vector2D> polyA, IList<Vector2D> polyB, List<List<Vector2D>> solution` | `` |
| `PolygonsUnion` | `Boolean` | `IList<Vector2D> polyA, IList<Vector2D> polyB, List<List<Vector2D>> solution` | `` |

#### Nested Types (3)

- `ClipTask` (enum)
- `PolygonFillType` (enum)
- `PolygonType` (enum)

### `PolygonType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolygonsClipper+PolygonType` |
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
      - `Topomatic.Cad.Foundation.PolygonsClipper+PolygonType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Clip` | `PolygonType` | Yes | `Clip` | `` |
| `Subject` | `PolygonType` | Yes | `Subject` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Subject` | `0` |
| `Clip` | `1` |

**Underlying Type**: `System.Int32`

### `Polyline2DCurve` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline2DCurve` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICurve` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`
- `.ctor(IEnumerable<BugleVector2D> collection)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `HasBungle` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `Item` | `BugleVector2D` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BugleVector2D item` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `CalculateD1` | `Boolean` | `Int32 index, Double length2d, ref Vector3D p, ref Vector3D tg` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BugleVector2D item` | `` |
| `CopyTo` | `Void` | `BugleVector2D[] array, Int32 arrayIndex` | `` |
| `D0` | `Boolean` | `Double u, ref Vector3D p` | `` |
| `D1` | `Boolean` | `Double u, ref Vector3D p, ref Vector3D tg` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `FindNearestLess` | `Int32` | `Double u` | `` |
| `FindStations` | `KeyValuePair<Double Double>` | `Int32 index` | `` |
| `GetEnumerator` | `IEnumerator<BugleVector2D>` | `` | `` |
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |
| `IndexOf` | `Int32` | `BugleVector2D item` | `` |
| `Insert` | `Void` | `Int32 index, BugleVector2D item` | `` |
| `Invalidate` | `Void` | `` | `` |
| `Project` | `Boolean` | `Vector3D p, ref Double u` | `` |
| `Project` | `Boolean` | `Vector3D p, Int32 index, ref Double u, ref Double o2` | `` |
| `Remove` | `Boolean` | `BugleVector2D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `Tesselate` | `IEnumerable<Double>` | `Double u1, Double u2, Double eps` | `` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Changed` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
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
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |
| `ILinearObject` | `GetPolyline` |
| `ICurve` | `D0` |
| `ICurve` | `D1` |
| `ICurve` | `Project` |
| `ICurve` | `Tesselate` |
| `ICurve` | `get_Length` |

### `Polyline2DCurveExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline2DCurveExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (15)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Break` | `Void` | `Polyline2DCurve polyline, Polyline2DCurve[] buffer, Double s1, Double s2` | `Extension` |
| `Break` | `Polyline2DCurve[]` | `Polyline2DCurve polyline, Double s1, Double s2` | `Extension` |
| `Join` | `Polyline2DCurve` | `Polyline2DCurve polyline1, Polyline2DCurve polyline2` | `` |
| `Offset` | `Polyline2DCurve` | `Polyline2DCurve polyline, IEnumerable<Polyline2DCurveOffset> values` | `Extension` |
| `SafetyAdd` | `Void` | `IList<BugleVector2D> vectors, BugleVector2D value` | `` |
| `SectArc` | `Vector2D[]` | `Polyline2DCurve polyline, Vector2D center, Double radius, Double startAngle, Double endAngle` | `Extension` |
| `SectArcStations` | `Double[]` | `Polyline2DCurve polyline, Vector2D center, Double radius, Double startAngle, Double endAngle` | `Extension` |
| `SectLine` | `Vector2D[]` | `Polyline2DCurve polyline, Line2D line` | `Extension` |
| `SectLineStations` | `Double[]` | `Polyline2DCurve polyline, Line2D line` | `Extension` |
| `SectPolyline` | `Vector2D[]` | `Polyline2DCurve polyline, Polyline2DCurve other` | `Extension` |
| `SectPolylineStations` | `Double[]` | `Polyline2DCurve polyline, Polyline2DCurve other` | `Extension` |
| `SectSegment` | `Vector2D[]` | `Polyline2DCurve polyline, Vector2D a, Vector2D b` | `Extension` |
| `SectSegmentStations` | `Double[]` | `Polyline2DCurve polyline, Vector2D a, Vector2D b` | `Extension` |
| `SoprLines` | `Polyline2DCurve` | `Polyline2DCurve polyline, Polyline2DCurve other, Vector2D controlPosition, Double radius, Double l1, Double l2, ref Vector2D middle` | `` |
| `SoprLines` | `Polyline2DCurve` | `Polyline2DCurve polyline, Polyline2DCurve other, Vector2D controlPosition, Double radius, Double l1, Double l2` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BREAK_AFTER` | `Int32` | Yes | `2` | `` |
| `BREAK_BEFORE` | `Int32` | Yes | `0` | `` |
| `BREAK_INSIDE` | `Int32` | Yes | `1` | `` |

### `Polyline2DCurveOffset` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline2DCurveOffset` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Polyline2DCurveOffset`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Polyline2DCurveOffset` | `StgNode node` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `HasRadius` | `Polyline2DCurveOffsetConnect` | No | `` | `` |
| `InRadius` | `Double` | No | `` | `` |
| `Length` | `Double` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `OutRadius` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `Polyline2DCurveOffsetConnect` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline2DCurveOffsetConnect` |
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
      - `Topomatic.Cad.Foundation.Polyline2DCurveOffsetConnect`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Curves` | `Polyline2DCurveOffsetConnect` | Yes | `Curves` | `` |
| `RadiusInsideLength` | `Polyline2DCurveOffsetConnect` | Yes | `RadiusInsideLength` | `` |
| `RadiusOutsideLength` | `Polyline2DCurveOffsetConnect` | Yes | `RadiusOutsideLength` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Curves` | `0` |
| `RadiusInsideLength` | `1` |
| `RadiusOutsideLength` | `2` |

**Underlying Type**: `System.Int32`

### `Polyline3D` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline3D` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Cad.Foundation.IPolyline3D, Topomatic.Cad.Foundation.ILinearObject` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Polyline3D`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`
- `.ctor(IEnumerable<BugleVector3D> collection)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Area2D` | `Double` | `get` | No | `` |
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Length2D` | `Double` | `get` | No | `` |
| `Length3D` | `Double` | `get` | No | `` |
| `Perimetr2D` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPolyline` | `Void` | `IPolyline3D polyline` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPolyline3D` | `get_Closed` |
| `IPolyline3D` | `set_Closed` |
| `ILinearObject` | `GetPolyline` |

### `Polyline3DCurve` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline3DCurve` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.ICurve` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IPolyline3D polyline)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Double` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `D0` | `Boolean` | `Double u, ref Vector3D p` | `` |
| `D1` | `Boolean` | `Double u, ref Vector3D p, ref Vector3D tg` | `` |
| `Project` | `Boolean` | `Vector3D p, ref Double u` | `` |
| `Tesselate` | `IEnumerable<Double>` | `Double u1, Double u2, Double eps` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICurve` | `D0` |
| `ICurve` | `D1` |
| `ICurve` | `Project` |
| `ICurve` | `Tesselate` |
| `ICurve` | `get_Length` |

### `Polyline3DStationingCurve` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Polyline3DStationingCurve` |
| **Base Type** | `Topomatic.Cad.Foundation.Polyline3DCurve` |
| **Implements** | `Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Polyline3DCurve`
    - `Topomatic.Cad.Foundation.Polyline3DStationingCurve`

#### Constructors (1)

- `.ctor(IStationingCurve curve, IPolyline3D polyline)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `Kilometers` | `IKilometers` | `get` | No | `` |
| `Stationing` | `IStationing` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingRepository` | `get_Stationing` |
| `IKilometersRepository` | `get_Kilometers` |
| `IBasisCurveContainer` | `get_BasisCurve` |

### `PolylineExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PolylineExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Assign` | `Void` | `IPolyline3D polyline, IPolyline3D other` | `Extension` |
| `Break` | `List<KeyValuePair<Boolean IPolyline3D>>` | `IPolyline3D polyline, Double s1, Double s2` | `Extension` |
| `Break` | `List<KeyValuePair<Boolean IPolyline3D>>` | `IPolyline3D polyline, Vector3D a, Vector3D b` | `Extension` |
| `Clone` | `Polyline3D` | `IPolyline3D polyline` | `Extension` |
| `ConvertToCurves` | `Void` | `IList<Vector3D> list, IList<BugleVector3D> polyline, Double eps` | `Extension` |
| `ConvertToPolyline` | `Void` | `IList<Vector2D> list, IList<BugleVector2D> polyline, Double eps` | `Extension` |
| `ConvertToPolyline` | `Void` | `IList<Vector2D> list, IList<BugleVector3D> polyline, Double elevation, Double eps` | `Extension` |
| `ConvertToPosArray` | `Void` | `IPolyline3D polyline, IList<Vector2D> list, Double eps` | `Extension` |
| `ConvertToPosArray` | `Void` | `IPolyline3D polyline, IList<Vector3D> list, Double eps` | `Extension` |
| `Flip` | `Void` | `Polyline3D polyline` | `Extension` |
| `GetArea2D` | `Double` | `IPolyline3D polyline` | `Extension` |
| `GetBounds` | `BoundingBox2D` | `Polyline3D polyline` | `Extension` |
| `GetDistantPoints` | `Void` | `IEnumerable<Vector2D> collection, ref Vector2D max, ref Vector2D min` | `Extension` |
| `GetFarthestPoint` | `Vector2D` | `IEnumerable<Vector2D> collection, Vector2D from` | `Extension` |
| `GetFarthestPoint` | `Vector2D` | `IEnumerable<Vector2D> collection, Func<Vector2D Double> function` | `Extension` |
| `GetIntersections` | `IEnumerable<Vector2D>` | `IPolyline3D polyline, Vector2D a, Vector2D b` | `Extension` |
| `GetLength2D` | `Double` | `IPolyline3D polyline` | `Extension` |
| `GetLength3D` | `Double` | `IPolyline3D polyline` | `Extension` |
| `GetNearestPoint` | `Vector2D` | `IEnumerable<Vector2D> collection, Func<Vector2D Double> function` | `Extension` |
| `GetNearestPoint` | `Vector2D` | `IEnumerable<Vector2D> collection, Vector2D to` | `Extension` |
| `GetPerimeter2D` | `Double` | `IPolyline3D polyline` | `Extension` |
| `HasBugles` | `Boolean` | `IPolyline3D polyline` | `Extension` |
| `Join` | `IPolyline3D` | `IPolyline3D polyline1, IPolyline3D polyline2` | `` |
| `Offset` | `Void` | `IList<Vector3D> polyline, Double offset, List<Vector3D> list` | `Extension` |
| `PosToStaOffset` | `Boolean` | `IPolyline3D polyline, Vector2D point, ref Double station, ref Double offset` | `Extension` |
| `RemoveDublicated2D` | `Void` | `IPolyline3D polyline, Double squaredEps` | `Extension` |
| `RemoveDublicated2D` | `Void` | `IPolyline3D polyline` | `Extension` |
| `RemoveDublicated3D` | `Void` | `IPolyline3D polyline, Double squaredEps` | `Extension` |
| `RemoveDublicated3D` | `Void` | `IPolyline3D polyline` | `Extension` |
| `SectLine` | `List<Vector2D>` | `IPolyline3D polyline, Line2D line` | `Extension` |
| `StaOffsetToPos` | `Vector2D` | `IPolyline3D polyline, Double station, Double offset` | `Extension` |
| `StaOffsetToPos3d` | `Boolean` | `IPolyline3D polyline, Double station, Double offset, ref Vector3D pt, ref Vector3D tg` | `Extension` |
| `StaOffsetToPos3d` | `Vector3D` | `IPolyline3D polyline, Double station, Double offset` | `Extension` |
| `Tesselate` | `IEnumerable<Double>` | `IPolyline3D polyline, Double u1, Double u2, Double eps` | `Extension` |
| `Transform` | `Void` | `IPolyline3D polyline, Matrix matrix, Action<BugleVector3D> apply` | `` |
| `Trim` | `Polyline3D` | `IPolyline3D polyline, Double station1, Double station2` | `Extension` |
| `Trim` | `Polyline3D` | `IPolyline3D polyline, Line2D l1, Line2D l2` | `Extension` |

### `PrimitiveType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.PrimitiveType` |
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
      - `Topomatic.Cad.Foundation.PrimitiveType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `LineList` | `PrimitiveType` | Yes | `LineList` | `` |
| `LineStrip` | `PrimitiveType` | Yes | `LineStrip` | `` |
| `PointList` | `PrimitiveType` | Yes | `PointList` | `` |
| `TriangleFan` | `PrimitiveType` | Yes | `TriangleFan` | `` |
| `TriangleList` | `PrimitiveType` | Yes | `TriangleList` | `` |
| `TriangleStrip` | `PrimitiveType` | Yes | `TriangleStrip` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `TriangleList` | `0` |
| `TriangleStrip` | `1` |
| `TriangleFan` | `2` |
| `LineList` | `3` |
| `LineStrip` | `4` |
| `PointList` | `5` |

**Underlying Type**: `System.Int32`

### `RasterBlock` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.RasterBlock` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceResource` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceResource`
    - `Topomatic.Cad.Foundation.RasterBlock`

#### Constructors (1)

- `.ctor(DeviceContext dc, Int32 size, String fullpath, PixelFormat format)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Binded` | `Boolean` | `get` | No | `` |
| `BindTime` | `Int32` | `get` | No | `` |
| `Format` | `PixelFormat` | `get` | No | `` |
| `Fullpath` | `String` | `get` | No | `` |
| `SizeInDeviceMemory` | `Int32` | `get` | No | `` |
| `TileSize` | `Int32` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Bind` | `Void` | `` | `` |
| `Paint` | `Void` | `Vector2F position, Single u, Single v, Single w, Single h` | `` |
| `Unbind` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Ray2D` (struct)

**Attributes**: [ComVisible, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Ray2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Ray2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Ray2D`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Ray2D other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |
| `TrySectWithLine` | `Boolean` | `Line2D line, ref Vector2D point` | `` |
| `TrySectWithRay` | `Boolean` | `Ray2D ray, ref Vector2D point` | `` |
| `TrySectWithSegment` | `Boolean` | `Vector2D startPoint, Vector2D endPoint, ref Vector2D point` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Ray2D` | `StgNode stgNode` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BasePoint` | `Vector2D` | No | `` | `` |
| `Dirrection` | `Vector2D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Ray3D` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Ray3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Ray3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Ray3D`

#### Constructors (1)

- `.ctor(Vector3D position, Vector3D direction)`

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `Ray3D other` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Intersects` | `Void` | `ref Plane plane, ref Nullable<Double> result` | `` |
| `Intersects` | `Nullable<Double>` | `Plane plane` | `` |
| `Intersects` | `Void` | `ref BoundingSphere3D sphere, ref Nullable<Double> result` | `` |
| `Intersects` | `Nullable<Double>` | `BoundingSphere3D sphere` | `` |
| `Intersects` | `Nullable<Double>` | `BoundingBox3D box` | `` |
| `Intersects` | `Void` | `ref BoundingBox3D box, ref Nullable<Double> result` | `` |
| `Intersects` | `Nullable<Double>` | `BoundingFrustum frustum` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Direction` | `Vector3D` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `RectangleD` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.RectangleD` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.RectangleD`

#### Constructors (1)

- `.ctor(Double x, Double y, Double width, Double height)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `Double` | `get` | No | `` |
| `Left` | `Double` | `get` | No | `` |
| `Location` | `Vector2D` | `get/set` | No | `` |
| `Right` | `Double` | `get` | No | `` |
| `Size` | `Vector2D` | `get/set` | No | `` |
| `Top` | `Double` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToBoundingBox` | `BoundingBox2D` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromLTRB` | `RectangleD` | `Double left, Double top, Double right, Double bottom` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Height` | `Double` | No | `` | `` |
| `Width` | `Double` | No | `` | `` |
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |

### `RegenType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.RegenType` |
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
      - `Topomatic.Cad.Foundation.RegenType`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ForExplode` | `RegenType` | Yes | `ForExplode` | `` |
| `HideOrShadeCommand` | `RegenType` | Yes | `HideOrShadeCommand` | `` |
| `RegenTypeInvalid` | `RegenType` | Yes | `RegenTypeInvalid` | `` |
| `SaveWorldDrawForProxy` | `RegenType` | Yes | `SaveWorldDrawForProxy` | `` |
| `ShadedDisplay` | `RegenType` | Yes | `ShadedDisplay` | `` |
| `StandardDisplay` | `RegenType` | Yes | `StandardDisplay` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RegenTypeInvalid` | `0` |
| `StandardDisplay` | `2` |
| `HideOrShadeCommand` | `3` |
| `ShadedDisplay` | `4` |
| `ForExplode` | `5` |
| `SaveWorldDrawForProxy` | `6` |

**Underlying Type**: `System.Int32`

### `ShaderType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShaderType` |
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
      - `Topomatic.Cad.Foundation.ShaderType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Color` | `ShaderType` | Yes | `Color` | `` |
| `Count` | `ShaderType` | Yes | `Count` | `` |
| `None` | `ShaderType` | Yes | `None` | `` |
| `Phong` | `ShaderType` | Yes | `Phong` | `` |
| `PhongTextured` | `ShaderType` | Yes | `PhongTextured` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Color` | `0` |
| `Phong` | `1` |
| `PhongTextured` | `2` |
| `Count` | `3` |
| `None` | `-1` |

**Underlying Type**: `System.Int32`

### `ShapeFont` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShapeFont` |
| **Base Type** | `Topomatic.Cad.Foundation.CadFont` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Cad.Foundation.ShapeForm, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CadFont`
    - `Topomatic.Cad.Foundation.ShapeFont`

#### Constructors (1)

- `.ctor(String filepath)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `FileName` | `String` | `get` | No | `` |
| `FilePath` | `String` | `get` | No | `` |
| `FontCodek` | `Byte` | `get/set` | No | `` |
| `FontMode` | `Byte` | `get/set` | No | `` |
| `FontType` | `Byte` | `get/set` | No | `` |
| `FullBottomHeight` | `Byte` | `get/set` | No | `` |
| `Item` | `ShapeForm` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `ShapeType` | `ShapeType` | `get/set` | No | `` |
| `Size` | `Byte` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CharToIndex` | `Int32` | `Char chr` | `` |
| `CharToName` | `String` | `Char chr` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<Char ShapeForm>>` | `` | `` |
| `IndexToChar` | `Char` | `Int32 index` | `` |
| `IndexToName` | `String` | `Int32 index` | `` |
| `NameToChar` | `Char` | `String name` | `` |
| `NameToIndex` | `Int32` | `String name` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `ShapeForm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShapeForm` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FixedBounds` | `BoundingBox2D` | `get` | No | `` |
| `FixedLength` | `Single` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `OutputScale` | `Single` | `get/set` | No | `` |
| `OutputX` | `Single` | `get/set` | No | `` |
| `OutputY` | `Single` | `get/set` | No | `` |
| `Polylines` | `List<SinglePolyline>` | `get` | No | `` |

#### Nested Types (2)

- `SingleBugledVector` (struct)
- `SinglePolyline` (class)

### `ShapeType` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShapeType` |
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
      - `Topomatic.Cad.Foundation.ShapeType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AnsiFont` | `ShapeType` | Yes | `AnsiFont` | `` |
| `BigFonts` | `ShapeType` | Yes | `BigFonts` | `` |
| `ShapeForm` | `ShapeType` | Yes | `ShapeForm` | `` |
| `Unifonts` | `ShapeType` | Yes | `Unifonts` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ShapeForm` | `0` |
| `AnsiFont` | `1` |
| `BigFonts` | `2` |
| `Unifonts` | `3` |

**Underlying Type**: `System.Int32`

### `SingleBugledVector` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector`

#### Constructors (2)

- `.ctor(Double x, Double y, Double bugle)`
- `.ctor(Single x, Single y, Single bugle)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Vector` | `BugleVector2D` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bugle` | `Single` | No | `` | `` |
| `X` | `Single` | No | `` | `` |
| `Y` | `Single` | No | `` | `` |

### `SinglePolyline` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ShapeForm+SinglePolyline` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.ShapeForm+SingleBugledVector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.ShapeForm+SinglePolyline`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StateElevationProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.StateElevationProvider` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IElevationProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetElevation` | `Nullable<Double>` | `StateElevationType state, Vector2D p` | `` |
| `GetElevation` | `Nullable<Double>` | `Vector2D p` | `` |
| `GetElevations` | `IEnumerable<StateElevationValue>` | `Vector2D p` | `` |
| `GetReferences` | `IEnumerable<IElevationProvider>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IElevationProvider` | `GetElevation` |

### `StateElevationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.StateElevationType` |
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
      - `Topomatic.Cad.Foundation.StateElevationType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DESIGNED` | `StateElevationType` | Yes | `DESIGNED` | `` |
| `DISMANTLED` | `StateElevationType` | Yes | `DISMANTLED` | `` |
| `DISMANTLING` | `StateElevationType` | Yes | `DISMANTLING` | `` |
| `EXISTING` | `StateElevationType` | Yes | `EXISTING` | `` |
| `UNDEFINED` | `StateElevationType` | Yes | `UNDEFINED` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `DESIGNED` | `0` |
| `DISMANTLING` | `1` |
| `EXISTING` | `2` |
| `DISMANTLED` | `3` |
| `UNDEFINED` | `4` |

**Underlying Type**: `System.Int32`

### `StateElevationValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.StateElevationValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.StateElevationValue`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `State` | `StateElevationType` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

### `StationedBasisPolyline2DCurve` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.StationedBasisPolyline2DCurve` |
| **Base Type** | `Topomatic.Cad.Foundation.StationedPolyline2DCurve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository, Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Polyline2DCurve`
    - `Topomatic.Cad.Foundation.StationedPolyline2DCurve`
      - `Topomatic.Cad.Foundation.StationedBasisPolyline2DCurve`

#### Constructors (3)

- `.ctor(IStationingCurve basis)`
- `.ctor(IStationingCurve basis, Int32 capacity)`
- `.ctor(IStationingCurve basis, IEnumerable<BugleVector2D> collection)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |
| `Kilometers` | `IKilometers` | `get` | No | `` |
| `Stationing` | `IStationing` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingRepository` | `get_Stationing` |
| `IKilometersRepository` | `get_Kilometers` |
| `IBasisCurveContainer` | `get_BasisCurve` |

### `StationedPolyline2DCurve` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.StationedPolyline2DCurve` |
| **Base Type** | `Topomatic.Cad.Foundation.Polyline2DCurve` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IUpdatable, Topomatic.Cad.Foundation.IBoundedObject, Topomatic.Cad.Foundation.ILinearObject, Topomatic.Cad.Foundation.ICurve, Topomatic.Cad.Foundation.IStationingCurve, Topomatic.Cad.Foundation.Stationing.IStationingRepository, Topomatic.Cad.Foundation.Stationing.IKilometersRepository` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Polyline2DCurve`
    - `Topomatic.Cad.Foundation.StationedPolyline2DCurve`

#### Constructors (9)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`
- `.ctor(IEnumerable<BugleVector2D> collection)`
- `.ctor(IStationing stationing, Int32 capacity)`
- `.ctor(IKilometers kilometers, IEnumerable<BugleVector2D> collection)`
- `.ctor(IStationing stationing, IEnumerable<BugleVector2D> collection)`
- `.ctor(IKilometers kilometers, Int32 capacity)`
- `.ctor(IStationing stationing, IKilometers kilometers, IEnumerable<BugleVector2D> collection)`
- `.ctor(IStationing stationing, IKilometers kilometers, Int32 capacity)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Kilometers` | `IKilometers` | `get` | No | `` |
| `Stationing` | `IStationing` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationingRepository` | `get_Stationing` |
| `IKilometersRepository` | `get_Kilometers` |

### `StraightItem` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+StraightItem` |
| **Base Type** | `Topomatic.Cad.Foundation.CompoundLine+Item` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.CompoundLine+Item`
      - `Topomatic.Cad.Foundation.CompoundLine+StraightItem`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `ItemType` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `StaOffsetToPos` | `Vector2D` | `Double sta, Double offset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetSegments` |

### `TextJustify` (enum)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.TextJustify` |
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
      - `Topomatic.Cad.Foundation.TextJustify`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BottomCenter` | `TextJustify` | Yes | `BottomCenter` | `` |
| `BottomLeft` | `TextJustify` | Yes | `BottomLeft` | `` |
| `BottomRight` | `TextJustify` | Yes | `BottomRight` | `` |
| `MiddleCenter` | `TextJustify` | Yes | `MiddleCenter` | `` |
| `MiddleLeft` | `TextJustify` | Yes | `MiddleLeft` | `` |
| `MiddleRight` | `TextJustify` | Yes | `MiddleRight` | `` |
| `TopCenter` | `TextJustify` | Yes | `TopCenter` | `` |
| `TopLeft` | `TextJustify` | Yes | `TopLeft` | `` |
| `TopRight` | `TextJustify` | Yes | `TopRight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `BottomLeft` | `0` |
| `BottomCenter` | `1` |
| `BottomRight` | `2` |
| `MiddleLeft` | `3` |
| `MiddleCenter` | `4` |
| `MiddleRight` | `5` |
| `TopLeft` | `6` |
| `TopCenter` | `7` |
| `TopRight` | `8` |

**Underlying Type**: `System.Int32`

### `Texture` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Texture` |
| **Base Type** | `Topomatic.Cad.Foundation.GraphicResource` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.GraphicResource`
    - `Topomatic.Cad.Foundation.Texture`

#### Constructors (1)

- `.ctor(Int32 width, Int32 height, TextureFormat format, Byte[] data)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Data` | `Byte[]` | `get` | No | `` |
| `Format` | `TextureFormat` | `get` | No | `` |
| `Hash` | `String` | `get` | No | `` |
| `Height` | `Int32` | `get` | No | `` |
| `Width` | `Int32` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TextureFormat` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.TextureFormat` |
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
      - `Topomatic.Cad.Foundation.TextureFormat`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `RGB` | `TextureFormat` | Yes | `RGB` | `` |
| `RGBA` | `TextureFormat` | Yes | `RGBA` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `RGB` | `0` |
| `RGBA` | `1` |

**Underlying Type**: `System.Int32`

### `Triangle3D` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangle3D` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Triangle3D`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `Triangle3D` | Yes | `` | `` |
| `Vertex1` | `Vector3D` | No | `` | `` |
| `Vertex2` | `Vector3D` | No | `` | `` |
| `Vertex3` | `Vector3D` | No | `` | `` |

### `UnmanagedBuffer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.UnmanagedBuffer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Capacity` | `Int32` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `HandleRef` | `HandleRef` | `get` | No | `` |
| `Pointer` | `IntPtr` | `get` | No | `` |
| `Tag` | `Object` | `get/set` | No | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddByte` | `Void` | `Byte value` | `` |
| `AddDouble` | `Void` | `Double value` | `` |
| `AddFloat` | `Void` | `Single value` | `` |
| `AddInteger` | `Void` | `Int32 value` | `` |
| `AddPointF` | `Void` | `PointF value` | `` |
| `AddShort` | `Void` | `Int16 value` | `` |
| `Assign` | `Void` | `UnmanagedBuffer other` | `` |
| `Clear` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `EnsureCapacity` | `Void` | `Int32 capacity` | `` |
| `GetByte` | `Byte` | `Int32 index` | `` |
| `GetFloat` | `Single` | `Int32 index` | `` |
| `GetInteger` | `Int32` | `Int32 index` | `` |
| `RemoveInteger` | `Void` | `Int32 index` | `` |
| `SetByte` | `Void` | `Int32 index, Byte value` | `` |
| `SetFloat` | `Void` | `Int32 index, Single value` | `` |
| `SetInteger` | `Void` | `Int32 index, Int32 value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `ValueConverter` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.ValueConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AngleUnit` | `AngleUnits` | `get/set` | Yes | `` |
| `AreaDigits` | `Int32` | `get/set` | Yes | `` |
| `CoordinateDigits` | `Int32` | `get/set` | Yes | `` |
| `DecimalSeparator` | `Char` | `get/set` | Yes | `` |
| `DefaultAngleDigits` | `Int32` | `get/set` | Yes | `` |
| `DefaultDigits` | `Int32` | `get/set` | Yes | `` |
| `ElevationDigits` | `Int32` | `get/set` | Yes | `` |
| `GradeDigits` | `Int32` | `get/set` | Yes | `` |
| `LengthDigits` | `Int32` | `get/set` | Yes | `` |
| `RadiusDigits` | `Int32` | `get/set` | Yes | `` |
| `ShowAngleEndZeroFeet` | `Boolean` | `get/set` | Yes | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | Yes | `` |

#### Static Methods (22)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleToStr` | `String` | `Double value` | `` |
| `AngleToStr` | `String` | `Double value, Int32 digits` | `` |
| `AngleToStr` | `String` | `Double value, Int32 digits, AngleUnits units, Boolean showZeroFeet, String format` | `` |
| `AreaToStr` | `String` | `Double value` | `` |
| `CompAngles` | `Boolean` | `Double angle1, Double angle2` | `` |
| `CompAngles` | `Boolean` | `Double angle1, Double angle2, Double epsilon` | `` |
| `CompSquaredValues` | `Int32` | `Double Value1, Double Value2, Double Epsilon` | `` |
| `CompSquaredValues` | `Int32` | `Double value1, Double value2` | `` |
| `CompValues` | `Int32` | `Double Value1, Double Value2, Double Epsilon` | `` |
| `CompValues` | `Int32` | `Double value1, Double value2` | `` |
| `CoordinateToStr` | `String` | `Double value` | `` |
| `ElevationToStr` | `String` | `Double value` | `` |
| `FloatToStr` | `String` | `Double value, Int32 digits, Boolean showZeroFeet` | `` |
| `FloatToStr` | `String` | `Double value` | `` |
| `FloatToStr` | `String` | `Double value, Int32 digits` | `` |
| `GradeToStr` | `String` | `Double value` | `` |
| `LengthToStr` | `String` | `Double value` | `` |
| `RadiusToStr` | `String` | `Double value` | `` |
| `StrToAngle` | `Double` | `String value` | `` |
| `StrToFloat` | `Double` | `String value` | `` |
| `TryStrToAngle` | `Boolean` | `String value, ref Double result` | `` |
| `TryStrToFloat` | `Boolean` | `String value, ref Double result` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Eps` | `Double` | Yes | `0.001` | `` |
| `MaxDouble` | `Double` | Yes | `1000000000000` | `` |
| `SquaredEps` | `Double` | Yes | `1E-06` | `` |

#### Nested Types (3)

- `AngleConverter` (class)
- `BaseFloatConverter` (abstract class)
- `FloatConverter` (class)

### `VariationBentleyOttmanAlgorithm`1<T where BentleyOttmanSegment, class, BentleyOttmanSegment>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.VariationBentleyOttmanAlgorithm`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(Int32 segmentsCount)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddSegment` | `Int32` | `Vector2D start, Vector2D end` | `` |
| `Invalidate` | `Void` | `` | `` |

### `Vector2D` (struct)

**Attributes**: [DefaultMember, Vector, TypeConverter, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector2D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Vector2D`

#### Constructors (4)

- `.ctor(Point point)`
- `.ctor(PointF point)`
- `.ctor(Double value)`
- `.ctor(Double x, Double y)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Empty` | `Vector2D` | `get` | Yes | `` |
| `IsInfinity` | `Boolean` | `get` | No | `` |
| `IsNaN` | `Boolean` | `get` | No | `` |
| `Item` | `Double` | `get/set` | No | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `LengthSquared` | `Double` | `get` | No | `` |
| `MaxInfinity` | `Vector2D` | `get` | Yes | `` |
| `MinInfinity` | `Vector2D` | `get` | Yes | `` |
| `One` | `Vector2D` | `get` | Yes | `` |
| `Point` | `Point` | `get` | No | `` |
| `PointF` | `PointF` | `get` | No | `` |
| `UnitX` | `Vector2D` | `get` | Yes | `` |
| `UnitY` | `Vector2D` | `get` | Yes | `` |

#### Instance Methods (17)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `Vector2D other` | `` |
| `EqualsEps` | `Boolean` | `Vector2D other` | `` |
| `EqualsEps` | `Boolean` | `Vector2D other, Double squaredEps` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetHashCode` | `Int32` | `Double eps` | `` |
| `Normalize` | `Void` | `` | `` |
| `Rotate` | `Void` | `Double sinA, Double cosA` | `` |
| `Rotate` | `Void` | `Double radians` | `` |
| `RotateAt` | `Void` | `Double sinA, Double cosA, Vector2D point` | `` |
| `RotateAt` | `Void` | `Double radians, Vector2D point` | `` |
| `Round` | `Void` | `Int32 digits` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, Vector2D defaultValue` | `` |
| `SaveToStream` | `Void` | `BinaryWriter writer` | `` |
| `ToString` | `String` | `` | `` |
| `Transform` | `Void` | `ref Matrix matrix` | `` |

#### Static Methods (40)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Barycentric` | `Vector2D` | `Vector2D value1, Vector2D value2, Vector2D value3, Double amount1, Double amount2` | `` |
| `Barycentric` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, Double amount1, Double amount2, ref Vector2D result` | `` |
| `CatmullRom` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, Double amount, ref Vector2D result` | `` |
| `CatmullRom` | `Vector2D` | `Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, Double amount` | `` |
| `Clamp` | `Vector2D` | `Vector2D value1, Vector2D min, Vector2D max` | `` |
| `Clamp` | `Void` | `ref Vector2D value1, ref Vector2D min, ref Vector2D max, ref Vector2D result` | `` |
| `Cross` | `Double` | `Vector2D vector1, Vector2D vector2` | `` |
| `Distance` | `Double` | `Vector2D value1, Vector2D value2` | `` |
| `Distance` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Double result` | `` |
| `DistanceSquared` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Double result` | `` |
| `DistanceSquared` | `Double` | `Vector2D value1, Vector2D value2` | `` |
| `Dot` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Double result` | `` |
| `Dot` | `Double` | `Vector2D value1, Vector2D value2` | `` |
| `Hermite` | `Vector2D` | `Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, Double amount` | `` |
| `Hermite` | `Void` | `ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, Double amount, ref Vector2D result` | `` |
| `Lerp` | `Vector2D` | `Vector2D value1, Vector2D value2, Double amount` | `` |
| `Lerp` | `Void` | `ref Vector2D value1, ref Vector2D value2, Double amount, ref Vector2D result` | `` |
| `LoadFromStg` | `Vector2D` | `StgNode node` | `` |
| `LoadFromStg` | `Vector2D` | `StgNode node, Vector2D defaultValue` | `` |
| `LoadFromStream` | `Vector2D` | `BinaryReader reader` | `` |
| `Max` | `Vector2D` | `Vector2D value1, Vector2D value2` | `` |
| `Max` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Vector2D result` | `` |
| `Min` | `Void` | `ref Vector2D value1, ref Vector2D value2, ref Vector2D result` | `` |
| `Min` | `Vector2D` | `Vector2D value1, Vector2D value2` | `` |
| `Normalize` | `Void` | `ref Vector2D value, ref Vector2D result` | `` |
| `Normalize` | `Vector2D` | `Vector2D value` | `` |
| `Rotate` | `Vector2D` | `Vector2D v, Double sinA, Double cosA` | `` |
| `SaveToStg` | `Void` | `Vector2D vector, StgNode node, Vector2D defaultValue` | `` |
| `SaveToStg` | `Void` | `Vector2D vector, StgNode node` | `` |
| `SaveToStream` | `Void` | `Vector2D vector, BinaryWriter writer` | `` |
| `SmoothStep` | `Void` | `ref Vector2D value1, ref Vector2D value2, Double amount, ref Vector2D result` | `` |
| `SmoothStep` | `Vector2D` | `Vector2D value1, Vector2D value2, Double amount` | `` |
| `Transform` | `Vector2D` | `Vector2D position, Matrix matrix` | `` |
| `Transform` | `Void` | `Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray` | `` |
| `Transform` | `Void` | `ref Vector2D position, ref Matrix matrix, ref Vector2D result` | `` |
| `Transform` | `Void` | `Vector2D[] sourceArray, Int32 sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, Int32 destinationIndex, Int32 length` | `` |
| `TransformNormal` | `Void` | `Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray` | `` |
| `TransformNormal` | `Vector2D` | `Vector2D normal, Matrix matrix` | `` |
| `TransformNormal` | `Void` | `Vector2D[] sourceArray, Int32 sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, Int32 destinationIndex, Int32 length` | `` |
| `TransformNormal` | `Void` | `ref Vector2D normal, ref Matrix matrix, ref Vector2D result` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Vector2DCoordsHash` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector2DCoordsHash` |
| **Base Type** | `Topomatic.Cad.Foundation.CoordsHash`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CoordsHash`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Vector2DCoordsHash`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`
- `.ctor(Int32 capacity, Double eps)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector2DCoordsJoiner` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector2DCoordsJoiner` |
| **Base Type** | `Topomatic.Cad.Foundation.CoordsJoiner`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CoordsJoiner`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Vector2DCoordsJoiner`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`
- `.ctor(Int32 capacity, Double eps)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector2DJoiner` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector2DJoiner` |
| **Base Type** | `Topomatic.Cad.Foundation.Joiner`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Joiner`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Vector2DJoiner`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`

### `Vector2F` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector2F` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Vector2F`

#### Constructors (3)

- `.ctor(Vector2D v)`
- `.ctor(Single x, Single y)`
- `.ctor(Double x, Double y)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Single` | `get/set` | No | `` |
| `LengthSquared` | `Single` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Normalize` | `Void` | `` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Max` | `Void` | `ref Vector2F value1, ref Vector2F value2, ref Vector2F result` | `` |
| `Min` | `Void` | `ref Vector2F value1, ref Vector2F value2, ref Vector2F result` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Single` | No | `` | `` |
| `Y` | `Single` | No | `` | `` |

### `Vector3D` (struct)

**Attributes**: [DefaultMember, Vector, TypeConverter, Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector3D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Vector3D`

#### Constructors (3)

- `.ctor(Double value)`
- `.ctor(Vector2D value, Double z)`
- `.ctor(Double x, Double y, Double z)`

#### Properties (16)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Backward` | `Vector3D` | `get` | Yes | `` |
| `Down` | `Vector3D` | `get` | Yes | `` |
| `Elevation` | `Double` | `get/set` | No | `` |
| `Empty` | `Vector3D` | `get` | Yes | `` |
| `Forward` | `Vector3D` | `get` | Yes | `` |
| `Item` | `Double` | `get/set` | No | `` |
| `Left` | `Vector3D` | `get` | Yes | `` |
| `Length` | `Double` | `get/set` | No | `` |
| `LengthSquared` | `Double` | `get` | No | `` |
| `One` | `Vector3D` | `get` | Yes | `` |
| `Pos` | `Vector2D` | `get/set` | No | `` |
| `Right` | `Vector3D` | `get` | Yes | `` |
| `UnitX` | `Vector3D` | `get` | Yes | `` |
| `UnitY` | `Vector3D` | `get` | Yes | `` |
| `UnitZ` | `Vector3D` | `get` | Yes | `` |
| `Up` | `Vector3D` | `get` | Yes | `` |

#### Instance Methods (16)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AngleWithRef` | `Double` | `Vector3D other, Vector3D vref` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `Equals` | `Boolean` | `Vector3D other` | `` |
| `EqualsEps` | `Boolean` | `Vector3D other` | `` |
| `EqualsEps` | `Boolean` | `Vector3D other, Double squaredEps` | `` |
| `GetHashCode` | `Int32` | `Double eps` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Normalize` | `Void` | `` | `` |
| `RotateOZ` | `Void` | `Double radians` | `` |
| `RotateOZ` | `Void` | `Double sinA, Double cosA` | `` |
| `RotateOZAt` | `Void` | `Double radians, Vector2D point` | `` |
| `RotateOZAt` | `Void` | `Double sinA, Double cosA, Vector2D point` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, Vector3D defaultValue` | `` |
| `SaveToStream` | `Void` | `BinaryWriter writer` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (43)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Barycentric` | `Vector3D` | `Vector3D value1, Vector3D value2, Vector3D value3, Double amount1, Double amount2` | `` |
| `Barycentric` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, Double amount1, Double amount2, ref Vector3D result` | `` |
| `CatmullRom` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, ref Vector3D value4, Double amount, ref Vector3D result` | `` |
| `CatmullRom` | `Vector3D` | `Vector3D value1, Vector3D value2, Vector3D value3, Vector3D value4, Double amount` | `` |
| `Clamp` | `Vector3D` | `Vector3D value1, Vector3D min, Vector3D max` | `` |
| `Clamp` | `Void` | `ref Vector3D value1, ref Vector3D min, ref Vector3D max, ref Vector3D result` | `` |
| `Cross` | `Void` | `ref Vector3D vector1, ref Vector3D vector2, ref Vector3D result` | `` |
| `Cross` | `Vector3D` | `Vector3D vector1, Vector3D vector2` | `` |
| `Distance` | `Double` | `Vector3D value1, Vector3D value2` | `` |
| `Distance` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Double result` | `` |
| `DistanceSquared` | `Double` | `Vector3D value1, Vector3D value2` | `` |
| `DistanceSquared` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Double result` | `` |
| `Dot` | `Void` | `ref Vector3D vector1, ref Vector3D vector2, ref Double result` | `` |
| `Dot` | `Double` | `Vector3D vector1, Vector3D vector2` | `` |
| `Hermite` | `Vector3D` | `Vector3D value1, Vector3D tangent1, Vector3D value2, Vector3D tangent2, Double amount` | `` |
| `Hermite` | `Void` | `ref Vector3D value1, ref Vector3D tangent1, ref Vector3D value2, ref Vector3D tangent2, Double amount, ref Vector3D result` | `` |
| `Lerp` | `Vector3D` | `Vector3D value1, Vector3D value2, Double amount` | `` |
| `Lerp` | `Void` | `ref Vector3D value1, ref Vector3D value2, Double amount, ref Vector3D result` | `` |
| `LoadFromStg` | `Vector3D` | `StgNode node, Vector3D defaultValue` | `` |
| `LoadFromStg` | `Vector3D` | `StgNode node` | `` |
| `LoadFromStream` | `Vector3D` | `BinaryReader reader` | `` |
| `Max` | `Vector3D` | `Vector3D value1, Vector3D value2` | `` |
| `Max` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Vector3D result` | `` |
| `Min` | `Vector3D` | `Vector3D value1, Vector3D value2` | `` |
| `Min` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Vector3D result` | `` |
| `Normalize` | `Void` | `ref Vector3D value, ref Vector3D result` | `` |
| `Normalize` | `Vector3D` | `Vector3D value` | `` |
| `Reflect` | `Void` | `ref Vector3D vector, ref Vector3D normal, ref Vector3D result` | `` |
| `Reflect` | `Vector3D` | `Vector3D vector, Vector3D normal` | `` |
| `SaveToStg` | `Void` | `Vector3D vector, StgNode node, Vector3D defaultValue` | `` |
| `SaveToStg` | `Void` | `Vector3D vector, StgNode node` | `` |
| `SaveToStream` | `Void` | `Vector3D vector, BinaryWriter writer` | `` |
| `SmoothStep` | `Void` | `ref Vector3D value1, ref Vector3D value2, Double amount, ref Vector3D result` | `` |
| `SmoothStep` | `Vector3D` | `Vector3D value1, Vector3D value2, Double amount` | `` |
| `Subtract` | `Void` | `ref Vector3D value1, ref Vector3D value2, ref Vector3D result` | `` |
| `Transform` | `Void` | `ref Vector3D position, ref Matrix matrix, ref Vector3D result` | `` |
| `Transform` | `Vector3D` | `Vector3D position, Matrix matrix` | `` |
| `Transform` | `Void` | `Vector3D[] sourceArray, ref Matrix matrix, Vector3D[] destinationArray` | `` |
| `Transform` | `Void` | `Vector3D[] sourceArray, Int32 sourceIndex, ref Matrix matrix, Vector3D[] destinationArray, Int32 destinationIndex, Int32 length` | `` |
| `TransformNormal` | `Void` | `Vector3D[] sourceArray, ref Matrix matrix, Vector3D[] destinationArray` | `` |
| `TransformNormal` | `Void` | `Vector3D[] sourceArray, Int32 sourceIndex, ref Matrix matrix, Vector3D[] destinationArray, Int32 destinationIndex, Int32 length` | `` |
| `TransformNormal` | `Void` | `ref Vector3D normal, ref Matrix matrix, ref Vector3D result` | `` |
| `TransformNormal` | `Vector3D` | `Vector3D normal, Matrix matrix` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |
| `Z` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Vector3DCoordsHash` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector3DCoordsHash` |
| **Base Type** | `Topomatic.Cad.Foundation.CoordsHash`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CoordsHash`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Vector3DCoordsHash`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`
- `.ctor(Int32 capacity, Double eps)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector3DCoordsJoiner` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector3DCoordsJoiner` |
| **Base Type** | `Topomatic.Cad.Foundation.CoordsJoiner`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CoordsJoiner`1[[Topomatic.Cad.Foundation.Vector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Cad.Foundation.Vector3DCoordsJoiner`

#### Constructors (3)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`
- `.ctor(Int32 capacity, Double eps)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector3F` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector3F` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Vector3F`

#### Constructors (4)

- `.ctor(Vector3D v)`
- `.ctor(Vector2F value, Single z)`
- `.ctor(Single x, Single y, Single z)`
- `.ctor(Double x, Double y, Double z)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Single` | `get/set` | No | `` |
| `LengthSquared` | `Single` | `get` | No | `` |
| `Pos` | `Vector2F` | `get/set` | No | `` |
| `Vector` | `Vector3D` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Vector3F other, Single eps` | `` |
| `Equals` | `Boolean` | `Vector3F other` | `` |
| `EqualsEps` | `Boolean` | `Vector3F other` | `` |
| `Normalize` | `Void` | `` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node, Vector3F defaultValue` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Cross` | `Vector3F` | `Vector3F vector1, Vector3F vector2` | `` |
| `Cross` | `Void` | `ref Vector3F vector1, ref Vector3F vector2, ref Vector3F result` | `` |
| `Dot` | `Void` | `ref Vector3F vector1, ref Vector3F vector2, ref Double result` | `` |
| `Dot` | `Double` | `Vector3F vector1, Vector3F vector2` | `` |
| `DotF` | `Single` | `Vector3F vector1, Vector3F vector2` | `` |
| `LoadFromStg` | `Vector3F` | `StgNode node, Vector3F defaultValue` | `` |
| `LoadFromStg` | `Vector3F` | `StgNode node` | `` |
| `Max` | `Void` | `ref Vector3F value1, ref Vector3F value2, ref Vector3F result` | `` |
| `Min` | `Void` | `ref Vector3F value1, ref Vector3F value2, ref Vector3F result` | `` |
| `SaveToStg` | `Void` | `Vector3F vector, StgNode node, Vector3F defaultValue` | `` |
| `SaveToStg` | `Void` | `Vector3F vector, StgNode node` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Empty` | `Vector3F` | Yes | `` | `` |
| `X` | `Single` | No | `` | `` |
| `Y` | `Single` | No | `` | `` |
| `Z` | `Single` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `Vector4D` (struct)

**Attributes**: [Serializable]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Vector4D` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Vector4D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Vector4D`

#### Constructors (4)

- `.ctor(Double value)`
- `.ctor(Vector3D value, Double w)`
- `.ctor(Vector2D value, Double z, Double w)`
- `.ctor(Double x, Double y, Double z, Double w)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `One` | `Vector4D` | `get` | Yes | `` |
| `UnitW` | `Vector4D` | `get` | Yes | `` |
| `UnitX` | `Vector4D` | `get` | Yes | `` |
| `UnitY` | `Vector4D` | `get` | Yes | `` |
| `UnitZ` | `Vector4D` | `get` | Yes | `` |
| `Zero` | `Vector4D` | `get` | Yes | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Vector4D other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `Length` | `Double` | `` | `` |
| `LengthSquared` | `Double` | `` | `` |
| `Normalize` | `Void` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (46)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Add` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Barycentric` | `Vector4D` | `Vector4D value1, Vector4D value2, Vector4D value3, Double amount1, Double amount2` | `` |
| `Barycentric` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, Double amount1, Double amount2, ref Vector4D result` | `` |
| `CatmullRom` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, ref Vector4D value4, Double amount, ref Vector4D result` | `` |
| `CatmullRom` | `Vector4D` | `Vector4D value1, Vector4D value2, Vector4D value3, Vector4D value4, Double amount` | `` |
| `Clamp` | `Void` | `ref Vector4D value1, ref Vector4D min, ref Vector4D max, ref Vector4D result` | `` |
| `Clamp` | `Vector4D` | `Vector4D value1, Vector4D min, Vector4D max` | `` |
| `Distance` | `Double` | `Vector4D value1, Vector4D value2` | `` |
| `Distance` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Double result` | `` |
| `DistanceSquared` | `Double` | `Vector4D value1, Vector4D value2` | `` |
| `DistanceSquared` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Double result` | `` |
| `Divide` | `Vector4D` | `Vector4D value1, Double divider` | `` |
| `Divide` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Divide` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Divide` | `Void` | `ref Vector4D value1, Double divider, ref Vector4D result` | `` |
| `Dot` | `Double` | `Vector4D vector1, Vector4D vector2` | `` |
| `Dot` | `Void` | `ref Vector4D vector1, ref Vector4D vector2, ref Double result` | `` |
| `Hermite` | `Void` | `ref Vector4D value1, ref Vector4D tangent1, ref Vector4D value2, ref Vector4D tangent2, Double amount, ref Vector4D result` | `` |
| `Hermite` | `Vector4D` | `Vector4D value1, Vector4D tangent1, Vector4D value2, Vector4D tangent2, Double amount` | `` |
| `Lerp` | `Void` | `ref Vector4D value1, ref Vector4D value2, Double amount, ref Vector4D result` | `` |
| `Lerp` | `Vector4D` | `Vector4D value1, Vector4D value2, Double amount` | `` |
| `Max` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Max` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Min` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Min` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Multiply` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Multiply` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Multiply` | `Void` | `ref Vector4D value1, Double scaleFactor, ref Vector4D result` | `` |
| `Multiply` | `Vector4D` | `Vector4D value1, Double scaleFactor` | `` |
| `Negate` | `Vector4D` | `Vector4D value` | `` |
| `Negate` | `Void` | `ref Vector4D value, ref Vector4D result` | `` |
| `Normalize` | `Vector4D` | `Vector4D vector` | `` |
| `Normalize` | `Void` | `ref Vector4D vector, ref Vector4D result` | `` |
| `SmoothStep` | `Vector4D` | `Vector4D value1, Vector4D value2, Double amount` | `` |
| `SmoothStep` | `Void` | `ref Vector4D value1, ref Vector4D value2, Double amount, ref Vector4D result` | `` |
| `Subtract` | `Void` | `ref Vector4D value1, ref Vector4D value2, ref Vector4D result` | `` |
| `Subtract` | `Vector4D` | `Vector4D value1, Vector4D value2` | `` |
| `Transform` | `Void` | `ref Vector2D position, ref Matrix matrix, ref Vector4D result` | `` |
| `Transform` | `Vector4D` | `Vector2D position, Matrix matrix` | `` |
| `Transform` | `Void` | `Vector4D[] sourceArray, ref Matrix matrix, Vector4D[] destinationArray` | `` |
| `Transform` | `Void` | `ref Vector4D vector, ref Matrix matrix, ref Vector4D result` | `` |
| `Transform` | `Void` | `Vector4D[] sourceArray, Int32 sourceIndex, ref Matrix matrix, Vector4D[] destinationArray, Int32 destinationIndex, Int32 length` | `` |
| `Transform` | `Vector4D` | `Vector4D vector, Matrix matrix` | `` |
| `Transform` | `Vector4D` | `Vector3D position, Matrix matrix` | `` |
| `Transform` | `Void` | `ref Vector3D position, ref Matrix matrix, ref Vector4D result` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `W` | `Double` | No | `` | `` |
| `X` | `Double` | No | `` | `` |
| `Y` | `Double` | No | `` | `` |
| `Z` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `VectorFunction2` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.CompoundLine+OptLib+VectorFunction2` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Cad.Foundation.CompoundLine+OptLib+VectorFunction2`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `ref Double y1, ref Double y2, Double x1, Double x2, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Boolean` | `ref Double y1, ref Double y2, IAsyncResult result` | `` |
| `Invoke` | `Boolean` | `ref Double y1, ref Double y2, Double x1, Double x2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VertexBuffer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.VertexBuffer` |
| **Base Type** | `Topomatic.Cad.Foundation.GraphicResource` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.GraphicResource`
    - `Topomatic.Cad.Foundation.VertexBuffer`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Colors` | `Vector3F[]` | `get/set` | No | `` |
| `ColorsSize` | `Int32` | `get` | No | `` |
| `IndexCount` | `Int32` | `get/set` | No | `` |
| `Indices` | `Int32[]` | `get/set` | No | `` |
| `IndicesSize` | `Int32` | `get` | No | `` |
| `Normals` | `Vector3F[]` | `get/set` | No | `` |
| `NormalsSize` | `Int32` | `get` | No | `` |
| `Positions` | `Vector3F[]` | `get/set` | No | `` |
| `PositionsSize` | `Int32` | `get` | No | `` |
| `TexCoords1` | `Vector2F[]` | `get/set` | No | `` |
| `TexCoords1Size` | `Int32` | `get` | No | `` |
| `VertexCount` | `Int32` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VolumeOperation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.VolumeOperation` |
| **Base Type** | `Topomatic.Cad.Foundation.OverlayOperation` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.BaseOverlayOperation`
      - `Topomatic.Cad.Foundation.OverlayOperation`
        - `Topomatic.Cad.Foundation.VolumeOperation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CutFillArea` | `Void` | `IList<Vector2D> earthLine, IList<Vector2D> redLine, List<List<Vector2D>> fillContours, List<List<Vector2D>> cutContours, ref Double fill, ref Double cut` | `` |
| `CutFillArea` | `Void` | `IList<Vector2D> earthLine, IList<Vector2D> redLine, ref Double fill, ref Double cut` | `` |
| `IntersecionArea` | `Double` | `IList<Vector2D> A, IList<Vector2D> B` | `` |

---
## Namespace: `Topomatic.Cad.Foundation.Brep`

### `Bvh`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Bvh`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `T obj, BoundingBox3D bounds` | `` |
| `Clear` | `Void` | `` | `` |
| `Find` | `Void` | `Ray3D ray, List<T> list` | `` |
| `Find` | `Void` | `BoundingBox3D bounds, List<T> list` | `` |
| `GetWeight` | `Double` | `` | `` |
| `Remove` | `Void` | `T obj, BoundingBox3D bounds` | `` |

### `ClassifyPointResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.ClassifyPointResult` |
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
      - `Topomatic.Cad.Foundation.Brep.ClassifyPointResult`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PointInside` | `ClassifyPointResult` | Yes | `PointInside` | `` |
| `PointNotOnPlane` | `ClassifyPointResult` | Yes | `PointNotOnPlane` | `` |
| `PointOnEdge` | `ClassifyPointResult` | Yes | `PointOnEdge` | `` |
| `PointOnFace` | `ClassifyPointResult` | Yes | `PointOnFace` | `` |
| `PointOnVertex` | `ClassifyPointResult` | Yes | `PointOnVertex` | `` |
| `PointOutSide` | `ClassifyPointResult` | Yes | `PointOutSide` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PointInside` | `0` |
| `PointOnVertex` | `1` |
| `PointOnEdge` | `2` |
| `PointOnFace` | `3` |
| `PointOutSide` | `4` |
| `PointNotOnPlane` | `5` |

**Underlying Type**: `System.Int32`

### `Edge` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Edge` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |
| `End` | `Vertex` | `get/set` | No | `` |
| `Faces` | `IEnumerable<Face>` | `get` | No | `` |
| `FacesCount` | `Int32` | `get` | No | `` |
| `Flags` | `Int32` | `get/set` | No | `` |
| `Start` | `Vertex` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClassifyPoint` | `ClassifyPointResult` | `Vector3D pos` | `` |
| `GetPosition` | `Vector3D` | `Double t` | `` |

### `EdgeFlags` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.EdgeFlags` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FIRST` | `Int32` | Yes | `1` | `` |
| `HIDDEN` | `Int32` | Yes | `8` | `` |
| `REVERSED` | `Int32` | Yes | `4` | `` |
| `SECOND` | `Int32` | Yes | `2` | `` |
| `SMOOTH` | `Int32` | Yes | `16` | `` |

### `Edges` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Edges` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Brep.Edge, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Edge` | `Vertex v1, Vertex v2` | `` |
| `Clear` | `Void` | `` | `` |
| `Find` | `Void` | `BoundingBox3D bounds, List<Edge> list` | `` |
| `GetEnumerator` | `IEnumerator<Edge>` | `` | `` |
| `Remove` | `Void` | `Edge edge` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `Face` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Face` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |
| `Flags` | `Int32` | `get/set` | No | `` |
| `Loops` | `Loops` | `get` | No | `` |
| `Plane` | `Plane` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClassifyPoint` | `ClassifyPointResult` | `Vector3D pos` | `` |
| `Flip` | `Void` | `` | `` |

### `FaceFlags` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.FaceFlags` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FIRST` | `Int32` | Yes | `1` | `` |
| `REVERSED` | `Int32` | Yes | `4` | `` |
| `SECOND` | `Int32` | Yes | `2` | `` |

### `Faces` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Faces` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Brep.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Face face` | `` |
| `Clear` | `Void` | `` | `` |
| `Find` | `Void` | `Ray3D ray, List<Face> list` | `` |
| `Find` | `Void` | `BoundingBox3D bounds, List<Face> list` | `` |
| `GetEnumerator` | `IEnumerator<Face>` | `` | `` |
| `Remove` | `Void` | `Face face` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `Loop` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Loop` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Brep.LoopEdge, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Parent` | `Face` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `LoopEdge` | `Edge e, Boolean reverse` | `` |
| `AddAfter` | `LoopEdge` | `LoopEdge iterator, Edge e, Boolean reverse` | `` |
| `AddBefore` | `LoopEdge` | `LoopEdge iterator, Edge e, Boolean reverse` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEdges` | `Void` | `List<Edge> edges` | `` |
| `GetEnumerator` | `IEnumerator<LoopEdge>` | `` | `` |
| `GetFlags` | `List<Int32>` | `` | `` |
| `GetPolygon2d` | `List<Vector2D>` | `` | `` |
| `GetPolygon3d` | `List<Vector3D>` | `` | `` |
| `GetVertices` | `Void` | `List<Vertex> vertices` | `` |
| `IsValid` | `Boolean` | `` | `` |
| `Remove` | `Void` | `LoopEdge ledge` | `` |
| `Reverse` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `LoopEdge` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.LoopEdge` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Loop parent, Edge edge, Boolean reverse)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Edge` | `Edge` | `get` | No | `` |
| `End` | `Vertex` | `get` | No | `` |
| `Parent` | `Loop` | `get` | No | `` |
| `Reverse` | `Boolean` | `get/set` | No | `` |
| `Start` | `Vertex` | `get` | No | `` |

### `Loops` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Loops` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Brep.Loop, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Parent` | `Face` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Loop` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<Loop>` | `` | `` |
| `Remove` | `Boolean` | `Loop loop` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `Plane` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Plane` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector3D pos, Vector3D ox, Vector3D oy)`

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetDistance` | `Double` | `Vector3D pos` | `` |
| `GetNormal` | `Vector3D` | `Vector2D pos` | `` |
| `GetPosition` | `Vector3D` | `Vector2D pos` | `` |
| `Project` | `Vector2D` | `Vector3D pos` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Ox` | `Vector3D` | No | `` | `` |
| `Oy` | `Vector3D` | No | `` | `` |
| `Oz` | `Vector3D` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |

### `Shell` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Shell` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Edges` | `Edges` | `get` | No | `` |
| `Faces` | `Faces` | `get` | No | `` |
| `Vertices` | `Vertices` | `get` | No | `` |

### `Tools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Tools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (46)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddEdge` | `Void` | `Shell shell, Vector3D startPos, Vector3D endPos, Int32 flags` | `` |
| `AddEdge` | `Void` | `Shell shell, Vector3D startPos, Vector3D endPos` | `` |
| `AddFace` | `Void` | `Shell shell, List<Vector3D> positions, Int32 edgeFlags, Int32 flags` | `` |
| `AddFace` | `Void` | `Shell shell, List<Vector3D> positions, List<Int32> edgeFlags, Int32 flags` | `` |
| `AddFace` | `Void` | `Shell shell, List<Vector3D> positions, Int32 flags` | `` |
| `AddFace` | `Void` | `Shell shell, List<Vector3D> positions` | `` |
| `Circle` | `Shell` | `Double radius, Int32 slices` | `` |
| `Clip` | `Shell` | `Shell shell, Shell solid, Boolean inside` | `` |
| `Copy` | `Void` | `Shell src, Shell dst` | `` |
| `CreateModel3D` | `GeometryModel3D` | `Shell shell, Vector3D origin, Color color` | `` |
| `Cube` | `Shell` | `Double width, Double height, Double depth` | `` |
| `Cylinder` | `Shell` | `Double radius1, Double radius2, Double height, Int32 slices` | `` |
| `Difference` | `Shell` | `Shell solid1, Shell solid2` | `` |
| `Extrude` | `Shell` | `Double height, Shell shell1` | `` |
| `Extrude` | `Shell` | `Double height, Face face` | `` |
| `FaceTriangulation` | `Void` | `IEnumerable<Face> faces, Vector3D origin, List<Vector3F> positions, List<Vector3F> normals, List<Int32> indices` | `` |
| `FaceTriangulation` | `Void` | `Face face, Vector3D origin, List<Vector3F> positions, List<Int32> indices` | `` |
| `Flip` | `Void` | `Shell shell` | `` |
| `GetPosOnFace` | `Boolean` | `Face face, ref Vector3D pos` | `` |
| `Intersection` | `Shell` | `Shell solid1, Shell solid2` | `` |
| `IsCCW` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c` | `` |
| `IsCCW` | `Boolean` | `List<Vector2D> polygon` | `` |
| `IsSolid` | `Boolean` | `Shell shell` | `` |
| `IsValidTriangle` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c` | `` |
| `LoadFromStg` | `Void` | `Shell shell, StgNode node` | `` |
| `MassProperties` | `Void` | `Shell shell, Vector3D origin, ref Double volume, ref Vector3D center, ref Vector3D moments, ref Vector3D products` | `` |
| `MassProperties` | `Void` | `Shell shell, ref Double volume, ref Vector3D center, ref Vector3D moments, ref Vector3D products` | `` |
| `Multmatrix` | `Shell` | `Matrix matrix, Shell shell` | `` |
| `Polygon` | `Shell` | `Vector3D[] positions` | `` |
| `PosInsideSolid` | `Boolean` | `Shell solid, Vector3D pos, Int32 mask` | `` |
| `PosInsideSolid` | `Boolean` | `Shell solid, Vector3D pos` | `` |
| `RemoveEdge` | `Void` | `Shell shell, Edge edge` | `` |
| `RemoveFace` | `Void` | `Shell shell, Face face` | `` |
| `RemoveFaces` | `Void` | `Shell shell, IEnumerable<Face> faces` | `` |
| `RemoveStrayEdges` | `Void` | `Shell shell` | `` |
| `Rotate` | `Shell` | `Double ox, Double oy, Double oz, Shell shell` | `` |
| `SaveToStg` | `Void` | `Shell shell, StgNode node` | `` |
| `Scale` | `Shell` | `Double scale, Shell shell` | `` |
| `Separate` | `Shell[]` | `Shell shell` | `` |
| `SimplifyEdges` | `Void` | `Shell shell` | `` |
| `SimplifyFaces` | `Void` | `Shell shell` | `` |
| `Slice` | `Shell[]` | `Shell shell, Plane plane` | `` |
| `SolidInfo` | `Int32[]` | `Shell shell` | `` |
| `Sphere` | `Shell` | `Double radius, Int32 slices, Int32 stacks` | `` |
| `Translate` | `Shell` | `Double x, Double y, Double z, Shell shell` | `` |
| `Union` | `Shell` | `Shell solid1, Shell solid2` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EPS` | `Double` | Yes | `1E-06` | `` |
| `SQREPS` | `Double` | Yes | `1E-12` | `` |

### `Vertex` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Vertex` |
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
| `Flags` | `Int32` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Bounds` | `BoundingBox3D` | `Vector3D pos` | `` |

### `Vertices` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Brep.Vertices` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Brep.Vertex, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Vertex` | `Vector3D pos` | `` |
| `Clear` | `Void` | `` | `` |
| `Find` | `Void` | `BoundingBox3D bounds, List<Vertex> list` | `` |
| `GetEnumerator` | `IEnumerator<Vertex>` | `` | `` |
| `Remove` | `Void` | `Vertex vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

---
## Namespace: `Topomatic.Cad.Foundation.Bulk`

### `BulkLayers<T where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Bulk.BulkTriangulationBuilder`1+BulkLayers` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Bulk.BulkTriangulationBuilder`1+BulkLayers`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Depths` | `Double[]` | No | `` | `` |
| `Uid` | `T` | No | `` | `` |

### `BulkLevel`1<T where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Bulk.BulkLevel`1` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Bulk.BulkLevel`1`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Depth` | `Double` | No | `` | `` |
| `Uid` | `T` | No | `` | `` |

### `BulkSectionTriangulation`1<T where class>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Bulk.BulkSectionTriangulation`1` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Cad.Foundation.IBoundedObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(IEqualityComparer<T> comparer)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePos` | `Vector2D` | `get` | No | `` |
| `Bounds` | `BoundingBox2D` | `get` | No | `` |
| `BoundsInitialized` | `Boolean` | `get` | No | `` |
| `MarkedLayers` | `IList<MarkedList<T>>` | `get` | No | `` |
| `Nodes` | `IList<Vector2D>` | `get` | No | `` |
| `Triangles` | `IList<Triangle>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IsInterpolated` | `Boolean` | `Int32 triangle` | `` |

#### Nested Types (1)

- `MarkedList` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IBoundedObject` | `get_Bounds` |
| `IBoundedObject` | `get_BoundsInitialized` |

### `BulkTriangulationBuilder`1<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Bulk.BulkTriangulationBuilder`1` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.Bulk.BulkTriangulationBuilder`1`

#### Constructors (1)

- `.ctor(IEqualityComparer<T> comparer)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePos` | `Vector2D` | `get` | No | `` |
| `Elevations` | `IList<Double>` | `get` | No | `` |
| `Levels` | `IList<BulkLevel<T>[]>` | `get` | No | `` |
| `Nodes` | `IList<Vector2D>` | `get` | No | `` |
| `Triangles` | `IList<Triangle>` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Execute` | `Boolean` | `IList<KeyValuePair<Vector3D BulkLevel<T>[]>> columns, IEnumerable<Edge> columnEdges` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateLayers` | `IList<BulkLayers<T>>` | `BulkLevel<T>[][] columns, IEqualityComparer<T> comparer` | `` |
| `GetLayersFromSource` | `IList<BulkLayers<T>>` | `BulkLevel<T>[][] values, BulkLevel<T>[] source, IEqualityComparer<T> comparer` | `` |

#### Nested Types (1)

- `BulkLayers` (struct)

### `MarkedList<T where class>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Bulk.BulkSectionTriangulation`1+MarkedList` |
| **Base Type** | `System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.IList`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.ICollection`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IReadOnlyCollection`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Cad.Foundation.Bulk.BulkSectionTriangulation`1+MarkedList`

#### Constructors (1)

- `.ctor(T mark)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Mark` | `T` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Cad.Foundation.Cogo`

### `ArcStruc` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.ArcStruc` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Cad.Foundation.Cogo.IPathItem, System.IEquatable`1[[Topomatic.Cad.Foundation.Cogo.ArcStruc, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.ArcStruc`

#### Constructors (3)

- `.ctor(ArcStruc source)`
- `.ctor(Vector2D center, Vector2D startpos, Vector2D endpos, Boolean clockwiseflag)`
- `.ctor(Vector2D center, Double radius, Double startAngle, Double endAngle, Boolean clockwiseflag)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Center` | `Vector2D` | `get/set` | No | `` |
| `CounterClockwise` | `Boolean` | `get/set` | No | `` |
| `DeltaAngle` | `Double` | `get` | No | `` |
| `EndAngle` | `Double` | `get/set` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `PathItemType` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `MiddlePos` | `Vector2D` | `get` | No | `` |
| `MiddleTangentAngle` | `Double` | `get` | No | `` |
| `Radius` | `Double` | `get/set` | No | `` |
| `Reverse` | `IPathItem` | `get` | No | `` |
| `StartAngle` | `Double` | `get/set` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |
| `SupplementArc` | `ArcStruc` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ArcStruc other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPathItem` | `get_ItemType` |
| `IPathItem` | `get_StartPos` |
| `IPathItem` | `get_EndPos` |
| `IPathItem` | `get_Length` |
| `IPathItem` | `get_Reverse` |
| `IEquatable`1` | `Equals` |

### `ClotDirection` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.ClotDirection` |
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
      - `Topomatic.Cad.Foundation.Cogo.ClotDirection`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Backward` | `ClotDirection` | Yes | `Backward` | `` |
| `Forward` | `ClotDirection` | Yes | `Forward` | `` |
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

### `ClothoidStruc` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.ClothoidStruc` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Cad.Foundation.Cogo.IPathItem, System.IEquatable`1[[Topomatic.Cad.Foundation.Cogo.ClothoidStruc, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.ClothoidStruc`

#### Constructors (3)

- `.ctor(ClothoidStruc source)`
- `.ctor(Vector2D pt, Double angle, Double radius, Double lengthfull, Double lengthstart, ClotDirection direction)`
- `.ctor(Double radius, Double angle, Double length, Double lengthfull, Vector2D beginpos, Vector2D endpos, ClotDirection direction)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `` |
| `Direction` | `ClotDirection` | `get/set` | No | `` |
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `PathItemType` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `LengthFull` | `Double` | `get/set` | No | `` |
| `LengthStart` | `Double` | `get/set` | No | `` |
| `MiddlePos` | `Vector2D` | `get` | No | `` |
| `MiddleTangentAngle` | `Double` | `get` | No | `` |
| `ParameterC` | `Double` | `get` | No | `` |
| `Pt` | `Vector2D` | `get/set` | No | `` |
| `RadiusEnd` | `Double` | `get/set` | No | `` |
| `RadiusStart` | `Double` | `get` | No | `` |
| `Reverse` | `IPathItem` | `get` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `ClothoidStruc other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPathItem` | `get_ItemType` |
| `IPathItem` | `get_StartPos` |
| `IPathItem` | `get_EndPos` |
| `IPathItem` | `get_Length` |
| `IPathItem` | `get_Reverse` |
| `IEquatable`1` | `Equals` |

### `ClotLocalParameters` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.CogoLibrary+ClotLocalParameters` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Beta` | `Double` | `Double L, Double R` | `` |
| `D` | `Double` | `Double L, Double R` | `` |
| `P` | `Double` | `Double L, Double R` | `` |
| `t` | `Double` | `Double L, Double R` | `` |
| `Td` | `Double` | `Double L, Double R` | `` |
| `X` | `Double` | `Double L, Double R` | `` |
| `Y` | `Double` | `Double L, Double R` | `` |

### `CogoLibrary` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.CogoLibrary` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (44)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanMakeArc` | `Boolean` | `Vector2D a, Vector2D b, Vector2D c, Double epsilon` | `` |
| `GetCircleFrom2PointsKasat` | `Boolean` | `Vector2D T1, Vector2D T2, Vector2D P1, Vector2D P2, ref Double XO, ref Double YO, ref Double Radius` | `` |
| `GetClothBFrom2PointsRLKasat` | `Boolean` | `Vector2D SP, Vector2D EP, Vector2D T1, Vector2D T2, Double R, Double L, ref ClothoidStruc Cl` | `` |
| `GetClothBTruncFrom2PointsRLKasat` | `Boolean` | `Vector2D SP, Vector2D EP, Vector2D T1, Vector2D T2, Double Rmin, Double Rmax, Double Lyc, ref ClothoidStruc Cl` | `` |
| `GetClothFrom2PointsKasat` | `Boolean` | `Vector2D SP, Vector2D EP, Vector2D T1, Vector2D T2, Double Radius, Double Length, ref ClothoidStruc Cl` | `` |
| `GetClothTruncFrom2PointsRLKasat` | `Boolean` | `Vector2D SP, Vector2D EP, Vector2D T1, Vector2D T2, Double Rmin, Double Rmax, Double Lyc, ref ClothoidStruc Cl` | `` |
| `MakeArcFrom2PointsKasat` | `Boolean` | `Vector2D T1, Vector2D T2, Vector2D P1, Vector2D P2, Boolean Invert, ref ArcStruc Arc` | `` |
| `MakeArcFrom2PointsLengthKasat` | `Boolean` | `Vector2D T1, Vector2D T2, Vector2D P1, Vector2D P2, Double L, Boolean Invert, ref ArcStruc Arc` | `` |
| `MakeArcFrom2PointsRadiusKasat` | `Boolean` | `Vector2D T1, Vector2D T2, Vector2D P1, Vector2D P2, Double R, Boolean Invert, ref ArcStruc Arc` | `` |
| `MakeArcFrom2PointsRLKasat` | `Boolean` | `Vector2D T1, Vector2D T2, Vector2D P1, Vector2D P2, Double R, Double L, Boolean Invert, ref ArcStruc Arc` | `` |
| `MakeArcFromStartPosRLTangent` | `Boolean` | `Vector2D sp, Double tangentAngle, Boolean counterClockWise, Double R, Double L, ref ArcStruc arc` | `` |
| `MakeClothBackwardFromStartPosRLTangent` | `Boolean` | `Vector2D sp, Double tangentAngle, Double R, Double L, ref ClothoidStruc clot` | `` |
| `MakeClothForwardFromStartPosRLTangent` | `Boolean` | `Vector2D sp, Double tangentAngle, Double R, Double L, ref ClothoidStruc clot` | `` |
| `MakeTruncClothBackwardFromStartPosRLTangent` | `Boolean` | `Vector2D sp, Double tangentAngle, Double R_start, Double R_end, Double L, ref ClothoidStruc clot` | `` |
| `MakeTruncClothForwardFromStartPosRLTangent` | `Boolean` | `Vector2D sp, Double tangentAngle, Double R_start, Double R_end, Double L, ref ClothoidStruc clot` | `` |
| `Mate_2AimedSegments_by_ClotArcClot_PureGeom_Ex` | `MatingResult` | `SegmentStruc seg1, SegmentStruc seg2, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, IList<IPathItem> pathListCut` | `` |
| `Mate_2Arcs_by_ClotArcClot` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref Nullable<ClothoidStruc> Clot1Ex, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_2Arcs_by_ClotArcClot` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref Nullable<ClothoidStruc> Clot1Ex, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_2Arcs_by_ClotArcClot_Alt` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref Nullable<ClothoidStruc> Clot1Ex, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_2Arcs_by_ClotArcClotEx` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, Boolean solveByTruncLen, Double biClotPartLen1, Double biClotPartLen2, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref Nullable<ClothoidStruc> Clot1Ex, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_2JoinedSegments_by_ClotArcClot` | `MatingResult` | `SegmentStruc seg1, SegmentStruc seg2, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Tan1, ref Double Tan2` | `` |
| `Mate_2JoinedSegments_by_ClotArcClot_PureGeom` | `MatingResult` | `ref SegmentStruc seg1, ref SegmentStruc seg2, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2` | `` |
| `Mate_2JoinedSegments_by_ClotArcClot_PureGeom_Ex` | `MatingResult` | `SegmentStruc seg1, SegmentStruc seg2, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, IList<IPathItem> pathListCut` | `` |
| `Mate_2PathLists_by_ClotArcClot` | `Boolean` | `IList<IPathItem> cl1, IList<IPathItem> cl2, Double controlSta1, Double controlSta2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean useTruncatedCloths, Boolean quick, Boolean solveByTruncLen, Double biClotPartLen1, Double biClotPartLen2, List<IPathItem> matingPathList, ref Vector2D MateP1, ref Vector2D MateP2, ref Double sta1, ref Double sta2` | `` |
| `Mate_2Segments_by_ClotArcClot` | `Boolean` | `SegmentStruc seg1, SegmentStruc seg2, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_CircleCircleByBiCloth` | `Boolean` | `Vector2D center1, Double radius1, Vector2D center2, Double radius2, MatingParamTypesBiCloth scheme, Double param, MateMode mateMode, MateSide mateSide, ref Nullable<ClothoidStruc> Clot1, ref Nullable<ClothoidStruc> Clot2` | `` |
| `Mate_CircleCircleByClotSegClot` | `Boolean` | `Vector2D center1, Double radius1, Vector2D center2, Double radius2, Double l1, Double l2, MateMode mateMode, MateSide mateSide, ref Nullable<ClothoidStruc> Clot1, ref SegmentStruc Seg, ref Nullable<ClothoidStruc> Clot2` | `` |
| `Mate_CircleCircleBySegment` | `Boolean` | `Vector2D center1, Double radius1, Vector2D center2, Double radius2, MateMode mateMode, MateSide mateSide, ref Vector2D tangentPos1, ref Vector2D tangentPos2` | `` |
| `Mate_CircleSegmentByCloth` | `Boolean` | `Vector2D center, Double radius, Vector2D sp, Vector2D ep, Boolean alternative, ref ClothoidStruc clot` | `` |
| `Mate_SegmentArc_by_ClotArcClot` | `Boolean` | `SegmentStruc seg, ArcStruc arc, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_SegmentArc_by_ClotArcClot` | `Boolean` | `SegmentStruc seg, ArcStruc arc, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_SegmentArc_by_ClotArcClot_Alt` | `Boolean` | `SegmentStruc seg, ArcStruc arc, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_SegmentArc_by_ClotArcClotEx` | `Boolean` | `SegmentStruc seg, ArcStruc arc, Boolean inverseMating, Double Rad, Double Param1, Double Param2, MatingParamTypes paramTypes, Boolean leftLocationFlag, Boolean solveByTruncLen, Double biClotPartLen, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Nullable<ClothoidStruc> Clot2Ex, ref Vector2D MatePos1, ref Vector2D MatePos2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate_SeparatedCircleLineByArc_PointOnCircle` | `Boolean` | `Vector2D center, Double circleradius, Line2D line, Vector2D pointOnCircle, ref Double Rad` | `` |
| `Mate_SeparatedCircleLineByArc_PointOnLine` | `Boolean` | `Vector2D center, Double circleradius, Line2D line, Vector2D pointOnLine, ref Double Rad` | `` |
| `Mate_SeparatedCircleLineByArc_Rad` | `Boolean` | `Vector2D center, Double circleradius, Vector2D sp, Vector2D ep, Double rad, Vector2D controlPos, Boolean alternative, ref ArcStruc arc` | `` |
| `Mate2ArcByLen` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Double Rad, Double l1, Double l2, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2, ref Double Sta1, ref Double Sta2` | `` |
| `Mate2ArcBySta` | `Boolean` | `ArcStruc arc1, ArcStruc arc2, Double Rad, Double sta1, Double sta2, ref ArcStruc Arc, ref ClothoidStruc Clot1, ref ClothoidStruc Clot2` | `` |
| `Mate2SegByLen` | `Boolean` | `SegmentStruc seg1, SegmentStruc seg2, Double Rad, Double l1, Double l2` | `` |
| `Mate2SegByTan` | `Boolean` | `SegmentStruc seg1, SegmentStruc seg2, Double Rad, Double tan1, Double tan2` | `` |
| `MateCircleCircleCloth` | `Boolean` | `Vector2D C1, Vector2D C2, Double R1, Double R2, Boolean alternative, ref ClothoidStruc Clot` | `` |
| `MateSimmBiclothoid` | `Boolean` | `Vector2D p1, Vector2D p2, Vector2D p3, Double Param, MatingParamTypesEx ParamType, ref ClothoidStruc Cl1, ref ClothoidStruc Cl2` | `` |
| `MateUnSimmBiclothoid` | `Boolean` | `Vector2D P1, Vector2D P2, Vector2D P3, Double Param1, Double Param2, MatingParamTypes ParamType, ref ClothoidStruc clot1, ref ClothoidStruc clot2, ref Double T1, ref Double T2` | `` |
| `TransformByAngleToPoint` | `Boolean` | `IList<IPathItem> pL, Vector2D pos, Double ta, Double startRadius, Boolean useStartRadius, List<IPathItem> tpL` | `` |

#### Nested Types (1)

- `ClotLocalParameters` (abstract class)

### `CompoundLineConverter` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.CompoundLineConverter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ConvertCompoundlineToDisplaceTypedPathList` | `Void` | `IEnumerable<Item> line, IList<PathItemWithDisplaceType> dtPathList` | `` |
| `ConvertCompoundlineToPathList` | `Void` | `IEnumerable<Item> line, IList<IPathItem> pathList` | `` |

### `CompoundLineMaker` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.CompoundLineMaker` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `MakeCompoundLineFromDisplaceTypedPathItems` | `Boolean` | `IList<PathItemWithDisplaceType> pathList, CompoundLine line, CompoundLine mainLine` | `` |
| `MakeCompoundLineFromDisplaceTypedPathItems` | `Boolean` | `IList<PathItemWithDisplaceType> pathList, CompoundLine line` | `` |
| `MakeCompoundLineFromPathItems` | `Boolean` | `IList<IPathItem> pathList, CompoundLine line, CompoundLine mainLine` | `` |
| `MakeCompoundLineFromPathItems` | `Boolean` | `IList<IPathItem> pathList, CompoundLine line` | `` |

### `IndexedPathItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.IndexedPathItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.IndexedPathItem`

#### Constructors (1)

- `.ctor(IPathItem pathItem, Int32 index)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Index` | `Int32` | `get/set` | No | `` |
| `PathItem` | `IPathItem` | `get/set` | No | `` |

### `IPathItem` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.IPathItem` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `PathItemType` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Reverse` | `IPathItem` | `get` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |

### `MateMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MateMode` |
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
      - `Topomatic.Cad.Foundation.Cogo.MateMode`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `modeInSide` | `MateMode` | Yes | `modeInSide` | `` |
| `modeOutSide` | `MateMode` | Yes | `modeOutSide` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `modeOutSide` | `0` |
| `modeInSide` | `1` |

**Underlying Type**: `System.Int32`

### `MateSide` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MateSide` |
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
      - `Topomatic.Cad.Foundation.Cogo.MateSide`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sideLeft` | `MateSide` | Yes | `sideLeft` | `` |
| `sideRight` | `MateSide` | Yes | `sideRight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `sideLeft` | `0` |
| `sideRight` | `1` |

**Underlying Type**: `System.Int32`

### `MatingParamTypes` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MatingParamTypes` |
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
      - `Topomatic.Cad.Foundation.Cogo.MatingParamTypes`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sptL1L2` | `MatingParamTypes` | Yes | `sptL1L2` | `` |
| `sptL1T2` | `MatingParamTypes` | Yes | `sptL1T2` | `` |
| `sptL2T1` | `MatingParamTypes` | Yes | `sptL2T1` | `` |
| `sptT1T2` | `MatingParamTypes` | Yes | `sptT1T2` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `sptL1L2` | `0` |
| `sptT1T2` | `1` |
| `sptL1T2` | `2` |
| `sptL2T1` | `3` |

**Underlying Type**: `System.Int32`

### `MatingParamTypesBiCloth` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MatingParamTypesBiCloth` |
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
      - `Topomatic.Cad.Foundation.Cogo.MatingParamTypesBiCloth`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sbtByFirstLen` | `MatingParamTypesBiCloth` | Yes | `sbtByFirstLen` | `` |
| `sbtByLenRelation` | `MatingParamTypesBiCloth` | Yes | `sbtByLenRelation` | `` |
| `sbtBySecondLen` | `MatingParamTypesBiCloth` | Yes | `sbtBySecondLen` | `` |
| `sbtSameParameters` | `MatingParamTypesBiCloth` | Yes | `sbtSameParameters` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `sbtSameParameters` | `0` |
| `sbtByLenRelation` | `1` |
| `sbtByFirstLen` | `2` |
| `sbtBySecondLen` | `3` |

**Underlying Type**: `System.Int32`

### `MatingParamTypesEx` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MatingParamTypesEx` |
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
      - `Topomatic.Cad.Foundation.Cogo.MatingParamTypesEx`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sbtBiss` | `MatingParamTypesEx` | Yes | `sbtBiss` | `` |
| `sbtLength` | `MatingParamTypesEx` | Yes | `sbtLength` | `` |
| `sbtRadius` | `MatingParamTypesEx` | Yes | `sbtRadius` | `` |
| `sbtTangens` | `MatingParamTypesEx` | Yes | `sbtTangens` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `sbtRadius` | `0` |
| `sbtBiss` | `1` |
| `sbtTangens` | `2` |
| `sbtLength` | `3` |

**Underlying Type**: `System.Int32`

### `MatingResult` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.MatingResult` |
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
      - `Topomatic.Cad.Foundation.Cogo.MatingResult`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fail` | `MatingResult` | Yes | `Fail` | `` |
| `Missing` | `MatingResult` | Yes | `Missing` | `` |
| `Success` | `MatingResult` | Yes | `Success` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Success` | `0` |
| `Missing` | `1` |
| `Fail` | `2` |

**Underlying Type**: `System.Int32`

### `PathItemDisplaceType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemDisplaceType` |
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
      - `Topomatic.Cad.Foundation.Cogo.PathItemDisplaceType`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arc` | `PathItemDisplaceType` | Yes | `Arc` | `` |
| `Clothoid` | `PathItemDisplaceType` | Yes | `Clothoid` | `` |
| `None` | `PathItemDisplaceType` | Yes | `None` | `` |
| `Straight` | `PathItemDisplaceType` | Yes | `Straight` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Straight` | `1` |
| `Clothoid` | `2` |
| `Arc` | `3` |

**Underlying Type**: `System.Int32`

### `PathItemType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemType` |
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
      - `Topomatic.Cad.Foundation.Cogo.PathItemType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Arc` | `PathItemType` | Yes | `Arc` | `` |
| `Clothoid` | `PathItemType` | Yes | `Clothoid` | `` |
| `Segment` | `PathItemType` | Yes | `Segment` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Segment` | `0` |
| `Arc` | `1` |
| `Clothoid` | `2` |

**Underlying Type**: `System.Int32`

### `PathItemWithDisplaceType` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemWithDisplaceType` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.PathItemWithDisplaceType`

#### Constructors (1)

- `.ctor(IPathItem pathItem, PathItemDisplaceType displaceType)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DisplaceType` | `PathItemDisplaceType` | `get/set` | No | `` |
| `PathItem` | `IPathItem` | `get/set` | No | `` |

### `PathItemWithDisplaceTypeAndOffs` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemWithDisplaceTypeAndOffs` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.PathItemWithDisplaceTypeAndOffs`

#### Constructors (1)

- `.ctor(IPathItem pathItem, PathItemDisplaceType displaceType, Double offs1, Double offs2)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `DisplaceType` | `PathItemDisplaceType` | `get/set` | No | `` |
| `Offs1` | `Double` | `get/set` | No | `` |
| `Offs2` | `Double` | `get/set` | No | `` |
| `PathItem` | `IPathItem` | `get/set` | No | `` |

### `PathItemWithOffs` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemWithOffs` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.PathItemWithOffs`

#### Constructors (1)

- `.ctor(IPathItem pathItem, Double offs1, Double offs2)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Offs1` | `Double` | `get/set` | No | `` |
| `Offs2` | `Double` | `get/set` | No | `` |
| `PathItem` | `IPathItem` | `get/set` | No | `` |

### `PathItemWithSta` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.PathItemWithSta` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.PathItemWithSta`

#### Constructors (1)

- `.ctor(IPathItem pathItem, Double sta)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `PathItem` | `IPathItem` | `get/set` | No | `` |
| `Sta` | `Double` | `get/set` | No | `` |

### `SegmentStruc` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.SegmentStruc` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Cad.Foundation.Cogo.IPathItem, System.IEquatable`1[[Topomatic.Cad.Foundation.Cogo.SegmentStruc, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.SegmentStruc`

#### Constructors (2)

- `.ctor(SegmentStruc source)`
- `.ctor(Vector2D startpos, Vector2D endpos)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `EndPos` | `Vector2D` | `get` | No | `` |
| `ItemType` | `PathItemType` | `get` | No | `` |
| `Left` | `Vector2D` | `get/set` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `Reverse` | `IPathItem` | `get` | No | `` |
| `Right` | `Vector2D` | `get/set` | No | `` |
| `StartPos` | `Vector2D` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `SegmentStruc other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPathItem` | `get_ItemType` |
| `IPathItem` | `get_StartPos` |
| `IPathItem` | `get_EndPos` |
| `IPathItem` | `get_Length` |
| `IPathItem` | `get_Reverse` |
| `IEquatable`1` | `Equals` |

### `SolveLib` (static class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.SolveLib` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (71)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AbsAngle2Segments` | `Double` | `Vector2D a, Vector2D b, Vector2D c, Vector2D d` | `` |
| `AngleSegment` | `Double` | `Vector2D a, Vector2D b` | `` |
| `ArcPartBetweenSta` | `ArcStruc` | `ArcStruc arc, Double sta1, Double sta2` | `` |
| `Circle_Circle_Intersection` | `Int32` | `Double x0, Double y0, Double r0, Double x1, Double y1, Double r1, ref Double xi, ref Double yi, ref Double xi_prime, ref Double yi_prime` | `` |
| `CircleCenterForClothoid` | `Vector2D` | `ClothoidStruc clot, Double radius_p` | `` |
| `CircleCenterForClothoid` | `Boolean` | `ClothoidStruc clot, Vector2D p, ref Vector2D center, ref Double radius_p` | `` |
| `CircleCenterForClothoid` | `Vector2D` | `ClothoidStruc clot, Double s, ref Double radius_p` | `` |
| `CircleCenterForClothoidAlt` | `Boolean` | `ClothoidStruc clot, Vector2D p, Double R, ref Vector2D center` | `` |
| `CircleCircleExternalTangent` | `Boolean` | `Vector2D c1, Vector2D c2, Double r1, Double r2, Vector2D cPos, ref Vector2D p1, ref Vector2D p2` | `` |
| `CircleCircleInternalTangent` | `Boolean` | `Vector2D c1, Vector2D c2, Double r1, Double r2, Vector2D cPos, ref Vector2D p1, ref Vector2D p2` | `` |
| `CircleTangentsFromPos` | `Int32` | `Vector2D pos, Vector2D center, Double radius, ref Vector2D p1, ref Vector2D p2` | `` |
| `ClothoidPartBetweenSta` | `ClothoidStruc` | `ClothoidStruc clot, Double sta1, Double sta2` | `` |
| `DedupCollection` | `IEnumerable<T>` | `IEnumerable<T> input, IEqualityComparer<T> comparer` | `` |
| `DedupCollection` | `IEnumerable<T>` | `IEnumerable<T> input` | `` |
| `DiffAngle` | `Double` | `Double StartAngle, Double EndAngle` | `` |
| `EqualsAngles` | `Boolean` | `Double alpha, Double beta` | `` |
| `FindArcCenter` | `Vector2D` | `Vector2D StartPos, Vector2D EndPos, Double Radius, Boolean Side` | `` |
| `GetArcTangentAngle` | `Boolean` | `ArcStruc arc, Double sta, ref Double angle` | `` |
| `GetClothoidTangentAngle` | `Boolean` | `ClothoidStruc clot, Double sta, ref Double angle` | `` |
| `GetParallelLineDistSide` | `Line2D` | `Line2D L, Double Dist, Vector2D SidePos` | `` |
| `GetParallelLineDistSideOld` | `Line2D` | `Line2D L, Double Dist, Vector2D SidePos` | `` |
| `GetPathItemTangentAngle` | `Boolean` | `IPathItem item, Double sta, ref Double angle` | `` |
| `GetPathListLength` | `Double` | `IList<IPathItem> pathList` | `` |
| `GetPathListTangentAngle` | `Boolean` | `IList<IPathItem> pL, Double sta, ref Double angle` | `` |
| `GetPosStaVectorialSegment` | `Double` | `Vector2D p, Vector2D sp, Vector2D ep` | `` |
| `GetSegmentBySta` | `IPathItem` | `IList<IPathItem> pathList, Double sta, ref Double prevLen, ref Int32 index` | `` |
| `GetSegmentMiddlePos` | `Vector2D` | `SegmentStruc seg` | `` |
| `GetSegmentTangentAngle` | `Boolean` | `SegmentStruc seg, Double sta, ref Double angle` | `` |
| `IsAimedSegments` | `Boolean` | `SegmentStruc A, SegmentStruc B, ref Vector2D Pos` | `` |
| `IsIdenticalPathLists` | `Boolean` | `List<IPathItem> pathList1, List<IPathItem> pathList2` | `` |
| `IsLeft` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b` | `` |
| `IsPointsOnSameSide` | `Boolean` | `Vector2D p, Vector2D q, Vector2D a, Vector2D b` | `` |
| `IsPointsOnSameSide` | `Boolean` | `Vector2D p, Vector2D q, Line2D L` | `` |
| `IsPosOnArc` | `Boolean` | `Vector2D p, ArcStruc arc` | `` |
| `IsPosOnClothoid` | `Boolean` | `Vector2D p, ClothoidStruc clot` | `` |
| `IsPosOnPathItem` | `Boolean` | `Vector2D p, IPathItem pathItem` | `` |
| `IsPosOnRay` | `Boolean` | `Vector2D p, Ray2D ray` | `` |
| `IsPosOnSegment` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b` | `` |
| `IsPosOnSegmentEx` | `Boolean` | `Vector2D p, SegmentStruc seg, Double epsilon` | `` |
| `IsPosOnSegmentVar` | `Boolean` | `Vector2D p, Vector2D a, Vector2D b, Double delta` | `` |
| `IsSamePathLists` | `Boolean` | `List<IPathItem> pathList1, List<IPathItem> pathList2` | `` |
| `MakeCircleFrom3Points` | `Boolean` | `Vector2D pt1, Vector2D pt2, Vector2D pt3, ref Vector2D center, ref Double radius` | `` |
| `MakeClothoidFromPointOnArcByLen` | `ClothoidStruc` | `ArcStruc arc, Vector2D p, Double len, Boolean counterclockwiseFlag, Boolean alternative` | `` |
| `MakeNormal` | `Line2D` | `Line2D L, Vector2D P` | `` |
| `MakeTruncatedClothoid_From_PointOnArc_To_OtherRadius` | `ClothoidStruc` | `ArcStruc arc, Vector2D p, Double l_trunc, Double otherRadius, Boolean counterclockwiseFlag` | `` |
| `MakeTruncatedClothoid_From_PointOnArc_To_OtherRadius_ByLenFull` | `ClothoidStruc` | `ArcStruc arc, Vector2D p, Double l_full, Double otherRadius, Boolean counterclockwiseFlag` | `` |
| `MakeTruncatedClothoid_Rmax_Rmin` | `ClothoidStruc` | `Double l_trunc, Double Rmax, Double Rmin, Vector2D p, Double tangentAngle, Boolean counterclockwiseFlag` | `` |
| `MakeTruncatedClothoid_Rmin_Rmax` | `ClothoidStruc` | `Double l_trunc, Double Rmin, Double Rmax, Vector2D p, Double tangentAngle, Boolean counterclockwiseFlag` | `` |
| `MakeTruncatedClothoidByLenFull_Rmax_Rmin` | `ClothoidStruc` | `Double l_full, Double Rmax, Double Rmin, Vector2D p, Double tangentAngle, Boolean counterclockwiseFlag` | `` |
| `MakeTruncatedClothoidByLenFull_Rmin_Rmax` | `ClothoidStruc` | `Double l_full, Double Rmin, Double Rmax, Vector2D p, Double tangentAngle, Boolean counterclockwiseFlag` | `` |
| `MinDistFromPosToArc` | `Double` | `Vector2D pos, ArcStruc arc` | `` |
| `MinDistFromPosToSegment` | `Double` | `Vector2D p, SegmentStruc segment` | `` |
| `MinDistSquareFromPosToSegment` | `Double` | `Vector2D p, SegmentStruc seg` | `` |
| `ParallelLineDist` | `Line2D` | `Line2D l, Double d` | `` |
| `PathItemPartBetweenSta` | `IPathItem` | `IPathItem pathItem, Double sta1, Double sta2` | `` |
| `PosToLineProjection` | `Vector2D` | `Vector2D Pos, Line2D Line` | `` |
| `PosToStaOffsArc` | `Boolean` | `ArcStruc arc, Vector2D pos, ref Double sta, ref Double offs` | `` |
| `PosToStaOffsPathItem` | `Boolean` | `IPathItem item, Vector2D pos, ref Double sta, ref Double offs` | `` |
| `Reflection` | `Vector2D` | `Vector2D Pos, Line2D L` | `` |
| `RemoveDublicated` | `Void` | `IList<Vector2D> contour, Double eps` | `` |
| `ReversedPathList` | `List<IPathItem>` | `List<IPathItem> pathList` | `` |
| `SectSegmentsOnSameLine` | `Boolean` | `Vector2D fl, Vector2D fr, Vector2D sl, Vector2D sr, Double epsilon, ref Vector2D p, ref Vector2D q` | `` |
| `SegmentPartBetweenSta` | `SegmentStruc` | `SegmentStruc segment, Double sta1, Double sta2` | `` |
| `SolveAngleForClothoid` | `Double` | `Double c, Double s, Double tangentAngle` | `` |
| `SolvePtAndAngleForClothoid` | `Void` | `Double c, Double s, Vector2D p, Double tangentAngle, ref Vector2D Pt, ref Double Angle` | `` |
| `SolvePtForClothoid` | `Vector2D` | `Double c, Double s, Double fi, Vector2D p` | `` |
| `StaOffsToPosArc` | `Vector2D` | `ArcStruc arc, Double sta, Double offs` | `` |
| `StaOffsToPosClothoid` | `Vector2D` | `ClothoidStruc clot, Double sta, Double offs` | `` |
| `StaOffsToPosPathItem` | `Vector2D` | `IPathItem item, Double sta, Double offs` | `` |
| `StaOffsToPosSegment` | `Vector2D` | `Vector2D pos1, Vector2D pos2, Double sta, Double offs` | `` |
| `StaToAbsRadiusClothoid` | `Double` | `ClothoidStruc clot, Double sta` | `` |

### `StationedPathItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItem` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItem`

#### Constructors (1)

- `.ctor(Double station, IPathItem pathItem)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PathItem` | `IPathItem` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `StationedPathItems` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItems` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItem, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItem, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver+StationedPathItem, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 capacity)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `StationedPathItem` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `StationedPathItem item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `StationedPathItem item` | `` |
| `CopyTo` | `Void` | `StationedPathItem[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<StationedPathItem>` | `` | `` |
| `GetSegment` | `StationedPathItem[]` | `Double startStation, Double endStation` | `` |
| `IndexOf` | `Int32` | `StationedPathItem item` | `` |
| `Insert` | `Void` | `Int32 index, StationedPathItem item` | `` |
| `Remove` | `Boolean` | `StationedPathItem item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

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
| `IList`1` | `get_Item` |
| `IList`1` | `set_Item` |
| `IList`1` | `IndexOf` |
| `IList`1` | `Insert` |
| `IList`1` | `RemoveAt` |

### `StationingTransitionSolver` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.StationingTransitionSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CompoundLineDisplace` | `IList<IPathItem>` | `CompoundLine compoundLine, IList<Vector2D> offsets` | `` |
| `CompoundLineDisplace` | `StationedPathItems` | `CompoundLine compoundLine` | `` |
| `StationedPathItemsDisplace` | `IList<IPathItem>` | `StationedPathItems stationedPath, IList<Vector2D> offsets` | `` |

#### Nested Types (2)

- `StationedPathItem` (struct)
- `StationedPathItems` (class)

### `TransitionSolver` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Cogo.TransitionSolver` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (14)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddDisplaceRangeForPathItemWithOffs` | `Void` | `PathItemWithOffs pathItemWithOffs, List<IPathItem> list` | `` |
| `AddDisplaceRangeForPathItemWithOffsEx` | `Void` | `PathItemWithDisplaceTypeAndOffs pathItemWithOffsDT, List<PathItemWithDisplaceType> list` | `` |
| `ArcDisplace` | `IEnumerable<IPathItem>` | `ArcStruc arc, Double offs1, Double offs2` | `` |
| `ArcDisplaceByClot` | `IPathItem` | `ArcStruc arc, Double offs1, Double offs2` | `` |
| `ArcDisplaceByFixSplitStep` | `IEnumerable<IPathItem>` | `ArcStruc arc, Double offs1, Double offs2` | `` |
| `ClothoidDisplace` | `IEnumerable<IPathItem>` | `ClothoidStruc clot, Double offs1, Double offs2` | `` |
| `CompoundLineDisplace` | `CompoundLine` | `CompoundLine cLine, IList<Vector2D> StaOffsList` | `` |
| `CompoundLineDisplace` | `Void` | `CompoundLine cLine, IList<Vector2D> StaOffsList, CompoundLine result` | `` |
| `CompoundLineDisplaceByPathItems` | `IEnumerable<IPathItem>` | `CompoundLine cLine, IList<Vector2D> StaOffsList` | `` |
| `CompoundLineDisplaceEx` | `CompoundLine` | `CompoundLine cLine, IList<Vector2D> StaOffsList` | `` |
| `CompoundLineDisplaceEx` | `Void` | `CompoundLine cLine, IList<Vector2D> StaOffsList, CompoundLine result` | `` |
| `SegmentDisplace` | `SegmentStruc` | `SegmentStruc segment, Double offs1, Double offs2` | `` |
| `Sta1ToSta2` | `Boolean` | `CompoundLine cl1, CompoundLine cl2, Double sta1, ref Double sta2` | `` |
| `Sta2ToSta1` | `Boolean` | `CompoundLine cl1, CompoundLine cl2, Double sta2, ref Double sta1` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PermissibleRecursiveDepth` | `Double` | Yes | `1000` | `` |
| `PermissibleVariance` | `Double` | Yes | `0.001` | `` |
| `SplitStep` | `Double` | Yes | `1` | `` |

---
## Namespace: `Topomatic.Cad.Foundation.Design`

### `AngleAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.AngleAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.AngleAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `AngleConverter` (class)

**Attributes**: [ComVisible]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.AngleConverter` |
| **Base Type** | `Topomatic.ComponentModel.DoubleConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseNumberConverter`
      - `Topomatic.ComponentModel.DoubleConverter`
        - `Topomatic.Cad.Foundation.Design.AngleConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultConverter` | `AngleConverter` | Yes | `` | `` |

### `AreaAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.AreaAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.AreaAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `BackgoundColorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.BackgoundColorAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Cad.Foundation.Design.BackgoundColorAttribute`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean supportBackgoundColorValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SupportBackgoundColorValue` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ByBlockAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.ByBlockAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Cad.Foundation.Design.ByBlockAttribute`

#### Constructors (1)

- `.ctor(Boolean byBlockValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ByBlockValue` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ByLayerAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.ByLayerAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Cad.Foundation.Design.ByLayerAttribute`

#### Constructors (1)

- `.ctor(Boolean byLayerValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ByLayerValue` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DefaultDoubleAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.DefaultDoubleAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverterAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyTypeConverterAttribute`
      - `Topomatic.Cad.Foundation.Design.DefaultDoubleAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DeltaVectorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.DeltaVectorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.DeltaVectorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ElevationAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.ElevationAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.ElevationAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GlobalVectorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.GlobalVectorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.GlobalVectorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `GradeAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.GradeAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverterAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyTypeConverterAttribute`
      - `Topomatic.Cad.Foundation.Design.GradeAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LengthAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.LengthAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.LengthAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `NoneColorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.NoneColorAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Cad.Foundation.Design.NoneColorAttribute`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Boolean supportNoneColorValue)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SupportNoneColorValue` | `Boolean` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RadiusAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.RadiusAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.RadiusAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector2DCodeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.Vector2DCodeConverter` |
| **Base Type** | `System.ComponentModel.TypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ComponentModel.TypeConverter`
    - `Topomatic.Cad.Foundation.Design.Vector2DCodeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFrom` | `Boolean` | `ITypeDescriptorContext context, Type sourceType` | `` |
| `CanConvertTo` | `Boolean` | `ITypeDescriptorContext context, Type destinationType` | `` |
| `ConvertFrom` | `Object` | `ITypeDescriptorContext context, CultureInfo culture, Object value` | `` |
| `ConvertTo` | `Object` | `ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType` | `` |
| `CreateInstance` | `Object` | `ITypeDescriptorContext context, IDictionary propertyValues` | `` |
| `GetCreateInstanceSupported` | `Boolean` | `ITypeDescriptorContext context` | `` |
| `GetProperties` | `PropertyDescriptorCollection` | `ITypeDescriptorContext context, Object value, Attribute[] attributes` | `` |
| `GetPropertiesSupported` | `Boolean` | `ITypeDescriptorContext context` | `` |

### `Vector3DCodeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.Vector3DCodeConverter` |
| **Base Type** | `System.ComponentModel.TypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ComponentModel.TypeConverter`
    - `Topomatic.Cad.Foundation.Design.Vector3DCodeConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFrom` | `Boolean` | `ITypeDescriptorContext context, Type sourceType` | `` |
| `CanConvertTo` | `Boolean` | `ITypeDescriptorContext context, Type destinationType` | `` |
| `ConvertFrom` | `Object` | `ITypeDescriptorContext context, CultureInfo culture, Object value` | `` |
| `ConvertTo` | `Object` | `ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType` | `` |
| `CreateInstance` | `Object` | `ITypeDescriptorContext context, IDictionary propertyValues` | `` |
| `GetCreateInstanceSupported` | `Boolean` | `ITypeDescriptorContext context` | `` |
| `GetProperties` | `PropertyDescriptorCollection` | `ITypeDescriptorContext context, Object value, Attribute[] attributes` | `` |
| `GetPropertiesSupported` | `Boolean` | `ITypeDescriptorContext context` | `` |

### `VectorAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Design.VectorAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Cad.Foundation.Design.VectorAttribute`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Cad.Foundation.Freetype`

### `ConicToFunc` (class)

**Attributes**: [UnmanagedFunctionPointer]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+ConicToFunc` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+ConicToFunc`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `ref FT_Vector control, ref FT_Vector to, IntPtr user, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Int32` | `ref FT_Vector control, ref FT_Vector to, IAsyncResult result` | `` |
| `Invoke` | `Int32` | `ref FT_Vector control, ref FT_Vector to, IntPtr user` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CubicToFunc` (class)

**Attributes**: [UnmanagedFunctionPointer]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+CubicToFunc` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+CubicToFunc`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `ref FT_Vector control1, ref FT_Vector control2, ref FT_Vector to, IntPtr user, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Int32` | `ref FT_Vector control1, ref FT_Vector control2, ref FT_Vector to, IAsyncResult result` | `` |
| `Invoke` | `Int32` | `ref FT_Vector control1, ref FT_Vector control2, ref FT_Vector to, IntPtr user` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FreeTypeFont` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeFont` |
| **Base Type** | `Topomatic.Cad.Foundation.CadFont` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.CadFont`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeFont`

#### Constructors (1)

- `.ctor(String filename)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get` | No | `` |
| `FilePath` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `FreeTypeFontLetter` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeLetters+FreeTypeFontLetter` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeLetters+FreeTypeFontLetter`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Advance` | `Single` | No | `` | `` |
| `BearingX` | `Single` | No | `` | `` |
| `BearingY` | `Single` | No | `` | `` |
| `GHeight` | `Single` | No | `` | `` |
| `GWidth` | `Single` | No | `` | `` |
| `Outline` | `List<List<Vector2F>>` | No | `` | `` |
| `Verteces` | `ManagedBuffer<Vector2F>` | No | `` | `` |

### `FreeTypeLetters` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeLetters` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String fileName)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TryGetLetter` | `Boolean` | `Char character, ref FreeTypeFontLetter letter` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DEFAULT_CHAR` | `Char` | Yes | `?` | `` |
| `SIZE` | `Double` | Yes | `100` | `` |

#### Nested Types (1)

- `FreeTypeFontLetter` (struct)

### `FreeTypeNative` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateOffsetOf` | `IntPtr` | `IntPtr start, String fieldName` | `` |
| `Error` | `String` | `Int32 error` | `` |
| `FT_Done_Face` | `Int32` | `IntPtr face` | `DllImport, PreserveSig` |
| `FT_Done_FreeType` | `Int32` | `IntPtr library` | `DllImport, PreserveSig` |
| `FT_Get_Char_Index` | `UInt32` | `IntPtr face, UInt32 charcode` | `DllImport, PreserveSig` |
| `FT_Init_FreeType` | `Int32` | `ref IntPtr alibrary` | `DllImport, PreserveSig` |
| `FT_Load_Glyph` | `Int32` | `IntPtr face, UInt32 glyph_index, Int32 load_flags` | `DllImport, PreserveSig` |
| `FT_New_Face` | `Int32` | `IntPtr library, String filepathname, Int32 face_index, ref IntPtr aface` | `DllImport, PreserveSig` |
| `FT_Outline_Check` | `Int32` | `IntPtr outline` | `DllImport, PreserveSig` |
| `FT_Outline_Decompose` | `Int32` | `IntPtr outline, ref FT_Outline_Funcs funcs, IntPtr user` | `DllImport, PreserveSig` |
| `FT_Set_Char_Size` | `Int32` | `IntPtr face, Int32 char_width, Int32 char_height, UInt32 horz_resolution, UInt32 vert_resolution` | `DllImport, PreserveSig` |
| `PtrToStructure` | `T` | `IntPtr ptr` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FT_LOAD_DEFAULT` | `Int32` | Yes | `0` | `` |

#### Nested Types (21)

- `ConicToFunc` (class)
- `CubicToFunc` (class)
- `FT_BBox` (struct)
- `FT_BitmapRec` (struct)
- `FT_FaceFlags` (enum)
- `FT_FaceRec` (struct)
- `FT_GenericRec` (struct)
- `FT_GlyphFormat` (enum)
- `FT_GlyphMetricsRec` (struct)
- `FT_GlyphSlotRec` (struct)
- `FT_Outline_Flags` (enum)
- `FT_Outline_Funcs` (struct)
- `FT_OutlineRec` (struct)
- `FT_PixelMode` (enum)
- `FT_Size_Request_Rec` (struct)
- `FT_SizeRec` (struct)
- `FT_SizeRequestType` (enum)
- `FT_StyleFlags` (enum)
- `FT_Vector` (struct)
- `LineToFunc` (class)
- `MoveToFunc` (class)

### `FT_BBox` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_BBox` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_BBox`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `xMax` | `IntPtr` | No | `` | `` |
| `xMin` | `IntPtr` | No | `` | `` |
| `yMax` | `IntPtr` | No | `` | `` |
| `yMin` | `IntPtr` | No | `` | `` |

### `FT_BitmapRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_BitmapRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_BitmapRec`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `buffer` | `IntPtr` | No | `` | `` |
| `num_grays` | `Int16` | No | `` | `` |
| `palette` | `IntPtr` | No | `` | `` |
| `palette_mode` | `Byte` | No | `` | `` |
| `pitch` | `Int32` | No | `` | `` |
| `pixel_mode` | `FT_PixelMode` | No | `` | `` |
| `rows` | `Int32` | No | `` | `` |
| `width` | `Int32` | No | `` | `` |

### `FT_FaceFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_FaceFlags` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_FaceFlags`

#### Fields (17)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CidKeyed` | `FT_FaceFlags` | Yes | `CidKeyed` | `` |
| `Color` | `FT_FaceFlags` | Yes | `Color` | `` |
| `ExternalStream` | `FT_FaceFlags` | Yes | `ExternalStream` | `` |
| `FastGlyphs` | `FT_FaceFlags` | Yes | `FastGlyphs` | `` |
| `FixedSizes` | `FT_FaceFlags` | Yes | `FixedSizes` | `` |
| `FixedWidth` | `FT_FaceFlags` | Yes | `FixedWidth` | `` |
| `GlyphNames` | `FT_FaceFlags` | Yes | `GlyphNames` | `` |
| `Hinter` | `FT_FaceFlags` | Yes | `Hinter` | `` |
| `Horizontal` | `FT_FaceFlags` | Yes | `Horizontal` | `` |
| `Kerning` | `FT_FaceFlags` | Yes | `Kerning` | `` |
| `MultipleMasters` | `FT_FaceFlags` | Yes | `MultipleMasters` | `` |
| `None` | `FT_FaceFlags` | Yes | `None` | `` |
| `Scalable` | `FT_FaceFlags` | Yes | `Scalable` | `` |
| `Sfnt` | `FT_FaceFlags` | Yes | `Sfnt` | `` |
| `Tricky` | `FT_FaceFlags` | Yes | `Tricky` | `` |
| `value__` | `Int64` | No | `` | `` |
| `Vertical` | `FT_FaceFlags` | Yes | `Vertical` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Scalable` | `1` |
| `FixedSizes` | `2` |
| `FixedWidth` | `4` |
| `Sfnt` | `8` |
| `Horizontal` | `16` |
| `Vertical` | `32` |
| `Kerning` | `64` |
| `FastGlyphs` | `128` |
| `MultipleMasters` | `256` |
| `GlyphNames` | `512` |
| `ExternalStream` | `1024` |
| `Hinter` | `2048` |
| `CidKeyed` | `4096` |
| `Tricky` | `8192` |
| `Color` | `16384` |

**Underlying Type**: `System.Int64`

### `FT_FaceRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_FaceRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_FaceRec`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `SizeInBytes` | `Int32` | `get` | Yes | `` |

#### Fields (31)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ascender` | `Int16` | No | `` | `` |
| `autohint` | `FT_GenericRec` | No | `` | `` |
| `available_sizes` | `IntPtr` | No | `` | `` |
| `bbox` | `FT_BBox` | No | `` | `` |
| `charmap` | `IntPtr` | No | `` | `` |
| `charmaps` | `IntPtr` | No | `` | `` |
| `descender` | `Int16` | No | `` | `` |
| `driver` | `IntPtr` | No | `` | `` |
| `extensions` | `IntPtr` | No | `` | `` |
| `face_flags` | `IntPtr` | No | `` | `` |
| `face_index` | `IntPtr` | No | `` | `` |
| `family_name` | `IntPtr` | No | `` | `` |
| `generic` | `FT_GenericRec` | No | `` | `` |
| `glyph` | `IntPtr` | No | `` | `` |
| `height` | `Int16` | No | `` | `` |
| `internal` | `IntPtr` | No | `` | `` |
| `max_advance_height` | `Int16` | No | `` | `` |
| `max_advance_width` | `Int16` | No | `` | `` |
| `memory` | `IntPtr` | No | `` | `` |
| `num_charmaps` | `Int32` | No | `` | `` |
| `num_faces` | `IntPtr` | No | `` | `` |
| `num_fixed_sizes` | `Int32` | No | `` | `` |
| `num_glyphs` | `IntPtr` | No | `` | `` |
| `size` | `IntPtr` | No | `` | `` |
| `sizes_list` | `IntPtr` | No | `` | `` |
| `stream` | `IntPtr` | No | `` | `` |
| `style_flags` | `IntPtr` | No | `` | `` |
| `style_name` | `IntPtr` | No | `` | `` |
| `underline_position` | `Int16` | No | `` | `` |
| `underline_thickness` | `Int16` | No | `` | `` |
| `units_per_EM` | `UInt16` | No | `` | `` |

### `FT_GenericRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GenericRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GenericRec`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `data` | `IntPtr` | No | `` | `` |
| `finalizer` | `IntPtr` | No | `` | `` |

### `FT_GlyphFormat` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphFormat` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphFormat`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bitmap` | `FT_GlyphFormat` | Yes | `Bitmap` | `` |
| `Composite` | `FT_GlyphFormat` | Yes | `Composite` | `` |
| `None` | `FT_GlyphFormat` | Yes | `None` | `` |
| `Outline` | `FT_GlyphFormat` | Yes | `Outline` | `` |
| `Plotter` | `FT_GlyphFormat` | Yes | `Plotter` | `` |
| `value__` | `UInt32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Bitmap` | `1651078259` |
| `Composite` | `1668246896` |
| `Outline` | `1869968492` |
| `Plotter` | `1886154612` |

**Underlying Type**: `System.UInt32`

### `FT_GlyphMetricsRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphMetricsRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphMetricsRec`

#### Fields (8)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `height` | `IntPtr` | No | `` | `` |
| `horiAdvance` | `IntPtr` | No | `` | `` |
| `horiBearingX` | `IntPtr` | No | `` | `` |
| `horiBearingY` | `IntPtr` | No | `` | `` |
| `vertAdvance` | `IntPtr` | No | `` | `` |
| `vertBearingX` | `IntPtr` | No | `` | `` |
| `vertBearingY` | `IntPtr` | No | `` | `` |
| `width` | `IntPtr` | No | `` | `` |

### `FT_GlyphSlotRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphSlotRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_GlyphSlotRec`

#### Fields (22)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `advance` | `FT_Vector` | No | `` | `` |
| `bitmap` | `FT_BitmapRec` | No | `` | `` |
| `bitmap_left` | `Int32` | No | `` | `` |
| `bitmap_top` | `Int32` | No | `` | `` |
| `control_data` | `IntPtr` | No | `` | `` |
| `control_len` | `IntPtr` | No | `` | `` |
| `face` | `IntPtr` | No | `` | `` |
| `format` | `FT_GlyphFormat` | No | `` | `` |
| `generic` | `FT_GenericRec` | No | `` | `` |
| `internal` | `IntPtr` | No | `` | `` |
| `library` | `IntPtr` | No | `` | `` |
| `linearHoriAdvance` | `IntPtr` | No | `` | `` |
| `linearVertAdvance` | `IntPtr` | No | `` | `` |
| `lsb_delta` | `IntPtr` | No | `` | `` |
| `metrics` | `FT_GlyphMetricsRec` | No | `` | `` |
| `next` | `IntPtr` | No | `` | `` |
| `num_subglyphs` | `UInt32` | No | `` | `` |
| `other` | `IntPtr` | No | `` | `` |
| `outline` | `FT_OutlineRec` | No | `` | `` |
| `reserved` | `UInt32` | No | `` | `` |
| `rsb_delta` | `IntPtr` | No | `` | `` |
| `subglyphs` | `IntPtr` | No | `` | `` |

### `FT_Outline_Flags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Outline_Flags` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Outline_Flags`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EvenOddFill` | `FT_Outline_Flags` | Yes | `EvenOddFill` | `` |
| `HighPrecision` | `FT_Outline_Flags` | Yes | `HighPrecision` | `` |
| `IgnoreDropouts` | `FT_Outline_Flags` | Yes | `IgnoreDropouts` | `` |
| `IncludeStubs` | `FT_Outline_Flags` | Yes | `IncludeStubs` | `` |
| `None` | `FT_Outline_Flags` | Yes | `None` | `` |
| `Owner` | `FT_Outline_Flags` | Yes | `Owner` | `` |
| `ReverseFill` | `FT_Outline_Flags` | Yes | `ReverseFill` | `` |
| `SinglePass` | `FT_Outline_Flags` | Yes | `SinglePass` | `` |
| `SmartDropouts` | `FT_Outline_Flags` | Yes | `SmartDropouts` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Owner` | `1` |
| `EvenOddFill` | `2` |
| `ReverseFill` | `4` |
| `IgnoreDropouts` | `8` |
| `SmartDropouts` | `16` |
| `IncludeStubs` | `32` |
| `HighPrecision` | `256` |
| `SinglePass` | `512` |

**Underlying Type**: `System.Int32`

### `FT_Outline_Funcs` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Outline_Funcs` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Outline_Funcs`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `conicTo` | `IntPtr` | No | `` | `` |
| `cubicTo` | `IntPtr` | No | `` | `` |
| `delta` | `IntPtr` | No | `` | `` |
| `lineTo` | `IntPtr` | No | `` | `` |
| `moveTo` | `IntPtr` | No | `` | `` |
| `shift` | `Int32` | No | `` | `` |

### `FT_OutlineRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_OutlineRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_OutlineRec`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `contours` | `IntPtr` | No | `` | `` |
| `flags` | `FT_Outline_Flags` | No | `` | `` |
| `n_contours` | `Int16` | No | `` | `` |
| `n_points` | `Int16` | No | `` | `` |
| `points` | `IntPtr` | No | `` | `` |
| `tags` | `IntPtr` | No | `` | `` |

### `FT_PixelMode` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_PixelMode` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_PixelMode`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bgra` | `FT_PixelMode` | Yes | `Bgra` | `` |
| `Gray` | `FT_PixelMode` | Yes | `Gray` | `` |
| `Gray2` | `FT_PixelMode` | Yes | `Gray2` | `` |
| `Gray4` | `FT_PixelMode` | Yes | `Gray4` | `` |
| `Lcd` | `FT_PixelMode` | Yes | `Lcd` | `` |
| `Mono` | `FT_PixelMode` | Yes | `Mono` | `` |
| `None` | `FT_PixelMode` | Yes | `None` | `` |
| `value__` | `Byte` | No | `` | `` |
| `VerticalLcd` | `FT_PixelMode` | Yes | `VerticalLcd` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Mono` | `1` |
| `Gray` | `2` |
| `Gray2` | `3` |
| `Gray4` | `4` |
| `Lcd` | `5` |
| `VerticalLcd` | `6` |
| `Bgra` | `7` |

**Underlying Type**: `System.Byte`

### `FT_Size_Request_Rec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Size_Request_Rec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Size_Request_Rec`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `height` | `IntPtr` | No | `` | `` |
| `horiResolution` | `UInt32` | No | `` | `` |
| `type` | `FT_SizeRequestType` | No | `` | `` |
| `vertResolution` | `UInt32` | No | `` | `` |
| `width` | `IntPtr` | No | `` | `` |

### `FT_SizeRec` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_SizeRec` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_SizeRec`

### `FT_SizeRequestType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_SizeRequestType` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_SizeRequestType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BoundingBox` | `FT_SizeRequestType` | Yes | `BoundingBox` | `` |
| `Cell` | `FT_SizeRequestType` | Yes | `Cell` | `` |
| `Normal` | `FT_SizeRequestType` | Yes | `Normal` | `` |
| `RealDimensions` | `FT_SizeRequestType` | Yes | `RealDimensions` | `` |
| `Scales` | `FT_SizeRequestType` | Yes | `Scales` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Normal` | `0` |
| `RealDimensions` | `1` |
| `BoundingBox` | `2` |
| `Cell` | `3` |
| `Scales` | `4` |

**Underlying Type**: `System.Int32`

### `FT_StyleFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_StyleFlags` |
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
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_StyleFlags`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Bold` | `FT_StyleFlags` | Yes | `Bold` | `` |
| `Italic` | `FT_StyleFlags` | Yes | `Italic` | `` |
| `None` | `FT_StyleFlags` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Italic` | `1` |
| `Bold` | `2` |

**Underlying Type**: `System.Int32`

### `FT_Vector` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Vector` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+FT_Vector`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `x` | `IntPtr` | No | `` | `` |
| `y` | `IntPtr` | No | `` | `` |

### `LetterOutlineBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.LetterOutlineBuilder` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Double eps)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InstalledSystemRegularFonts` | `IDictionary<String String>` | `get` | Yes | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `LoadLetterOutline` | `Boolean` | `List<Polyline3D> lines, String fontPath, UInt32 letter, Double height, ref Double gwidth, ref Double gheight, ref Double bearingx, ref Double bearingy, ref Double advance` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `LineToFunc` (class)

**Attributes**: [UnmanagedFunctionPointer]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+LineToFunc` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+LineToFunc`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `ref FT_Vector to, IntPtr user, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Int32` | `ref FT_Vector to, IAsyncResult result` | `` |
| `Invoke` | `Int32` | `ref FT_Vector to, IntPtr user` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MoveToFunc` (class)

**Attributes**: [UnmanagedFunctionPointer]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+MoveToFunc` |
| **Base Type** | `System.MulticastDelegate` |
| **Implements** | `System.ICloneable, System.Runtime.Serialization.ISerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Delegate`
    - `System.MulticastDelegate`
      - `Topomatic.Cad.Foundation.Freetype.FreeTypeNative+MoveToFunc`

#### Constructors (1)

- `.ctor(Object object, IntPtr method)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginInvoke` | `IAsyncResult` | `ref FT_Vector to, IntPtr user, AsyncCallback callback, Object object` | `` |
| `EndInvoke` | `Int32` | `ref FT_Vector to, IAsyncResult result` | `` |
| `Invoke` | `Int32` | `ref FT_Vector to, IntPtr user` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Cad.Foundation.Rasters`

### `Hash` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Rasters.Hash` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Rasters.Hash`

#### Constructors (1)

- `.ctor(Byte[] buffer)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToBuffer` | `Void` | `Byte[] buffer` | `` |
| `ToBuffer` | `Byte[]` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `a` | `UInt16` | No | `` | `` |
| `b` | `UInt16` | No | `` | `` |
| `c` | `UInt32` | No | `` | `` |
| `d` | `UInt32` | No | `` | `` |
| `e` | `UInt32` | No | `` | `` |
| `f` | `UInt32` | No | `` | `` |

---
## Namespace: `Topomatic.Cad.Foundation.Stationing`

### `IBasisCurveContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.IBasisCurveContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasisCurve` | `IStationingCurve` | `get` | No | `` |

### `IKilometers` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.IKilometers` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromKm` | `Boolean` | `Int32 number, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToKm` | `Boolean` | `Double u, ref Int32 kilometre, ref Double plus, ref Boolean forward` | `` |

### `IKilometersRepository` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.IKilometersRepository` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Kilometers` | `IKilometers` | `get` | No | `` |

### `IStationing` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.IStationing` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `WholeLength` | `Double` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillWholes` | `Boolean` | `IList<Double> values` | `` |
| `FromPk` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToPk` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |
| `ToPkDecimal` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |

### `IStationingRepository` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.IStationingRepository` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Stationing` | `IStationing` | `get` | No | `` |

### `Kilometers` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.Kilometers` |
| **Base Type** | `Topomatic.Cad.Foundation.Stationing.LinkedKilometers` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IKilometers, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Kilometers, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedKilometers`
      - `Topomatic.Cad.Foundation.Stationing.Kilometers`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Kilometers Kilometers)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `KilometersSector` | `get/set` | No | `` |
| `SimpleKilometres` | `Boolean` | `get/set` | No | `` |
| `StartStation` | `Double` | `get/set` | No | `` |

#### Instance Methods (18)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `KilometersSector item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `KilometersSector item` | `` |
| `CopyTo` | `Void` | `KilometersSector[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `Kilometers other` | `` |
| `FillWholes` | `IEnumerable<Double>` | `Double start, Double end` | `` |
| `FromKm` | `Boolean` | `Int32 number, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `GetEnumerator` | `IEnumerator<KilometersSector>` | `` | `` |
| `IndexOf` | `Int32` | `KilometersSector item` | `` |
| `Insert` | `Void` | `Int32 index, KilometersSector item` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `KilometersSector item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToKm` | `Boolean` | `Double u, ref Int32 number, ref Double plus, ref Boolean forward` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `KILOMETRE_LENGTH` | `Double` | Yes | `1000` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IKilometers` | `ToKm` |
| `IKilometers` | `FromKm` |
| `IKilometers` | `FromString` |
| `IKilometers` | `IsWhole` |
| `IKilometers` | `IsChop` |
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
| `IEquatable`1` | `Equals` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `KilometersExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.KilometersExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromString` | `Boolean` | `IKilometers kilometers, String value, ref Double u1, ref Double u2` | `Extension` |
| `FromString` | `Boolean` | `IKilometers kilometers, String pk, String plus, ref Double u` | `Extension` |
| `FromString` | `Double` | `IKilometers kilometers, String value` | `Extension` |
| `ToKm` | `Boolean` | `IKilometers kilometers, Double u, ref Int32 number, ref Double plus` | `Extension` |
| `ToString` | `Void` | `IKilometers kilometers, Double u, ref String pk, ref String plus` | `Extension` |
| `ToString` | `String` | `IKilometers kilometers, Double u1, Double u2, Int32 digits, Boolean showZeroFeet` | `Extension` |
| `ToString` | `String` | `IKilometers kilometers, Double u` | `Extension` |
| `ToString` | `Void` | `IKilometers kilometers, Double u, Int32 digits, Boolean showZeroFeet, ref String pk, ref String plus` | `Extension` |
| `ToString` | `String` | `IKilometers kilometers, Double u1, Double u2` | `Extension` |
| `ToString` | `String` | `IKilometers kilometers, Double u, Int32 digits, Boolean showZeroFeet` | `Extension` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `sWrong` | `String` | Yes | `"??"` | `` |

### `KilometersSector` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.KilometersSector` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.KilometersSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Stationing.KilometersSector`

#### Constructors (1)

- `.ctor(KilometersSector sector)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `KilometersSector other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `KilometersSector` | `StgNode stgNode, KilometersSector defaultValue` | `` |
| `LoadFromStg` | `KilometersSector` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `KilometersSector sector, StgNode stgNode` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndKm` | `Int32` | No | `` | `` |
| `EndPlus` | `Double` | No | `` | `` |
| `StartKm` | `Int32` | No | `` | `` |
| `StartPlus` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

### `LinkedKilometers` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.LinkedKilometers` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IKilometers` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedKilometers`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromKm` | `Boolean` | `Int32 number, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToKm` | `Boolean` | `Double u, ref Int32 number, ref Double plus, ref Boolean forward` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IKilometers` | `ToKm` |
| `IKilometers` | `FromKm` |
| `IKilometers` | `FromString` |
| `IKilometers` | `IsWhole` |
| `IKilometers` | `IsChop` |

### `LinkedStationing` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.LinkedStationing` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IStationing` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedStationing`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `WholeLength` | `Double` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillWholes` | `Boolean` | `IList<Double> values` | `` |
| `FromPk` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `ToPk` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |
| `ToPkDecimal` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStationing` | `ToPk` |
| `IStationing` | `ToPkDecimal` |
| `IStationing` | `FromPk` |
| `IStationing` | `FromString` |
| `IStationing` | `get_WholeLength` |
| `IStationing` | `FillWholes` |
| `IStationing` | `IsWhole` |
| `IStationing` | `IsChop` |

### `Stationing` (abstract class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.Stationing` |
| **Base Type** | `Topomatic.Cad.Foundation.Stationing.LinkedStationing` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Cad.Foundation.Stationing.IStationing, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.Stationing, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Cad.Foundation.Stationing.LinkedStationing`
      - `Topomatic.Cad.Foundation.Stationing.Stationing`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, Stationing stationing)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `StationingSector` | `get/set` | No | `` |
| `WholeLength` | `Double` | `get` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `StationingSector item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `StationingSector item` | `` |
| `CopyTo` | `Void` | `StationingSector[] array, Int32 arrayIndex` | `` |
| `Equals` | `Boolean` | `Stationing other` | `` |
| `FillWholes` | `Boolean` | `IList<Double> values` | `` |
| `FromPk` | `Boolean` | `Int32 number, Nullable<Char> index, Double plus, ref Double u` | `` |
| `FromString` | `Boolean` | `String value, ref Double u` | `` |
| `GetEnumerator` | `IEnumerator<StationingSector>` | `` | `` |
| `IndexOf` | `Int32` | `StationingSector item` | `` |
| `Insert` | `Void` | `Int32 index, StationingSector item` | `` |
| `IsChop` | `Boolean` | `Double u` | `` |
| `IsWhole` | `Boolean` | `Double u` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `StationingSector item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `SetWholeLength` | `Void` | `Double value` | `` |
| `ToPk` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |
| `ToPkDecimal` | `Boolean` | `Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus, ref Boolean forward` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `INDEXES` | `String[]` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStationing` | `ToPk` |
| `IStationing` | `ToPkDecimal` |
| `IStationing` | `FromPk` |
| `IStationing` | `FromString` |
| `IStationing` | `get_WholeLength` |
| `IStationing` | `FillWholes` |
| `IStationing` | `IsWhole` |
| `IStationing` | `IsChop` |
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
| `IEquatable`1` | `Equals` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StationingExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.StationingExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FromString` | `Boolean` | `IStationing stationing, String value, ref Double u1, ref Double u2` | `Extension` |
| `FromString` | `Boolean` | `IStationing stationing, String pk, String plus, ref Double u` | `Extension` |
| `FromString` | `Double` | `IStationing stationing, String value` | `Extension` |
| `ToPk` | `Boolean` | `IStationing stationing, Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `Extension` |
| `ToPkDecimal` | `Boolean` | `IStationing stationing, Double u, ref Int32 number, ref Nullable<Char> index, ref Double plus` | `Extension` |
| `ToString` | `Void` | `IStationing stationing, Double u, ref String pk, ref String plus` | `Extension` |
| `ToString` | `String` | `IStationing stationing, Double u` | `Extension` |
| `ToString` | `Void` | `IStationing stationing, Double u, Int32 digits, Boolean showZeroFeet, ref String pk, ref String plus` | `Extension` |
| `ToString` | `String` | `IStationing stationing, Double u, Int32 digits, Boolean showZeroFeet` | `Extension` |
| `ToString` | `String` | `IStationing stationing, Double u1, Double u2, Int32 digits, Boolean showZeroFeet` | `Extension` |
| `ToString` | `String` | `IStationing stationing, Double u1, Double u2` | `Extension` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndTraceString` | `String` | Yes | `"КТ"` | `` |
| `StartTraceString` | `String` | Yes | `"НТ"` | `` |
| `sWrong` | `String` | Yes | `"??"` | `` |

### `StationingSector` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Stationing.StationingSector` |
| **Base Type** | `System.ValueType` |
| **Implements** | `System.IEquatable`1[[Topomatic.Cad.Foundation.Stationing.StationingSector, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Stationing.StationingSector`

#### Constructors (1)

- `.ctor(StationingSector sector)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `StationingSector other` | `` |
| `SaveToStg` | `Void` | `StgNode stgNode` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `StationingSector` | `StgNode stgNode, StationingSector defaultValue` | `` |
| `LoadFromStg` | `StationingSector` | `StgNode stgNode` | `` |
| `SaveToStg` | `Void` | `StationingSector sector, StgNode stgNode` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndPk` | `Int32` | No | `` | `` |
| `EndPlus` | `Double` | No | `` | `` |
| `Index` | `Nullable<Char>` | No | `` | `` |
| `sEmptyIndex` | `String` | Yes | `"None"` | `` |
| `StartPk` | `Int32` | No | `` | `` |
| `StartPlus` | `Double` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEquatable`1` | `Equals` |

---
## Namespace: `Topomatic.Cad.Foundation.Triangulation`

### `ActiveRibsBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.ActiveRibsBuilder` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder`
    - `Topomatic.Cad.Foundation.Triangulation.ActiveRibsBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `IList<Node> nodes, IList<Edge> limitation, IList<Triangle> triangles` | `` |

### `BrepDelauney` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `BrepPolygonFiller` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.BrepPolygonFiller` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.BrepDelauney` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.BrepDelauney`
    - `Topomatic.Cad.Foundation.Triangulation.BrepPolygonFiller`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `List<Vector2D> contour, List<Triangle> triangles` | `` |

### `DynamicCachedBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.DynamicCachedBuilder` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder`
    - `Topomatic.Cad.Foundation.Triangulation.DynamicCachedBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `IList<Node> nodes, IList<Triangle> triangles` | `` |
| `FindTriangle` | `Int32` | `Node vertex, IList<Node> nodes, IList<Triangle> triangles` | `` |

### `DynamicCachedLimitationBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.DynamicCachedLimitationBuilder` |
| **Base Type** | `Topomatic.Cad.Foundation.Triangulation.DynamicCachedBuilder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder`
    - `Topomatic.Cad.Foundation.Triangulation.DynamicCachedBuilder`
      - `Topomatic.Cad.Foundation.Triangulation.DynamicCachedLimitationBuilder`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Build` | `Void` | `IList<Node> nodes, IList<Edge> limitation, IList<Triangle> triangles` | `` |

### `Edge` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.Edge` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Triangulation.Edge`

#### Constructors (1)

- `.ctor(Int32 a, Int32 b)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `Int32` | No | `` | `` |
| `B` | `Int32` | No | `` | `` |
| `Tag` | `Int32` | No | `` | `` |

### `Node` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.Node` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Triangulation.Node`

#### Constructors (1)

- `.ctor(Double x, Double y)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |
| `ToVector` | `Vector2D` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Invalid` | `Boolean` | No | `` | `` |
| `X` | `Single` | No | `` | `` |
| `Y` | `Single` | No | `` | `` |

### `SurfaceBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.SurfaceBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Events (1)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Progress` | `ProgressChangedEventHandler` | No | `` |

### `Triangle` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Cad.Foundation.Triangulation.Triangle` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Cad.Foundation.Triangulation.Triangle`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetTriangle` | `Int32` | `Int32 index` | `` |
| `SetTriangle` | `Void` | `Int32 index, Int32 value` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Triangle1` | `Int32` | No | `` | `` |
| `Triangle2` | `Int32` | No | `` | `` |
| `Triangle3` | `Int32` | No | `` | `` |
| `Vertex1` | `Int32` | No | `` | `` |
| `Vertex2` | `Int32` | No | `` | `` |
| `Vertex3` | `Int32` | No | `` | `` |

---
## Namespace: `Topomatic.Visualization`

### `BinaryStorage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.BinaryStorage` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String filename)`

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `String` | `Stream stream` | `` |
| `Append` | `String` | `Byte[] data` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Find` | `Byte[]` | `String id` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `BinaryStorage` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `BooleanPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.BooleanPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.BooleanPropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultList` | `BooleanPropertyInfo` | Yes | `` | `` |
| `DefaultSingle` | `BooleanPropertyInfo` | Yes | `` | `` |
| `DefaultTable` | `BooleanPropertyInfo` | Yes | `` | `` |

### `CustomDescriptorProperties` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImTypeDescriptors+CustomDescriptorProperties` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Visualization.ImProperties, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendPropertys` | `Void` | `ImTypeDescriptor value, IEnumerable<ImProperty> propertys` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String ImProperties>>` | `` | `` |
| `GetResetState` | `ResetState` | `ImTypeDescriptor value, ImProperty property` | `` |
| `ResetProperty` | `Boolean` | `ImTypeDescriptor value, ImProperty property` | `` |
| `ResetPropertys` | `Boolean` | `ImTypeDescriptor value` | `` |

#### Nested Types (1)

- `ResetState` (enum)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `CustomDescriptors` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImTypeDescriptors+CustomDescriptors` |
| **Base Type** | `Topomatic.Visualization.ImTypeDescriptors` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.ImTypeDescriptor, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImTypeDescriptors`
    - `Topomatic.Visualization.ImTypeDescriptors+CustomDescriptors`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CustomProperties` | `CustomDescriptorProperties` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AppendDescriptor` | `ImTypeDescriptor` | `ImTypeDescriptor parent, String title` | `` |
| `AppendDescriptor` | `Void` | `ImTypeDescriptor value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `EnumerationPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.EnumerationPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.EnumerationPropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Values` | `Dictionary<String String>` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `FloatPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.FloatPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.FloatPropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `High` | `Nullable<Double>` | `get/set` | No | `` |
| `Low` | `Nullable<Double>` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `IImElementReference` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.IImElementReference` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Ox` | `Vector3D` | `get` | No | `` |
| `Oy` | `Vector3D` | `get` | No | `` |
| `Position` | `Vector3D` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Scale` | `Vector3D` | `get` | No | `` |

### `ImAggregates` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImAggregates` |
| **Base Type** | `Topomatic.Visualization.TypedObject` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImAggregates`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get/set` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImAggregates` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `FillProperties` | `Void` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `ResetProperties` | `Void` | `` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `ImAggregates` | `ImTypeDescriptor type, ImProperties properties` | `` |
| `Create` | `ImAggregates` | `String parentId, ImProperties properties, ImDocuments documents` | `` |
| `Create` | `ImAggregates` | `ImTypeDescriptor type, ImProperties properties, ImDocuments documents` | `` |
| `Create` | `ImAggregates` | `String parentId` | `` |
| `Create` | `ImAggregates` | `ImTypeDescriptor type` | `` |
| `Create` | `ImAggregates` | `String parentId, ImProperties properties` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImDocument` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImDocument` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `Byte[]` | `` | `` |

### `ImDocumentFile` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImDocumentFile` |
| **Base Type** | `Topomatic.Visualization.ImDocument` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImDocument`
    - `Topomatic.Visualization.ImDocumentFile`

#### Constructors (1)

- `.ctor(String name, String path)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `Byte[]` | `` | `` |

### `ImDocumentGenerated` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImDocumentGenerated` |
| **Base Type** | `Topomatic.Visualization.ImDocument` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImDocument`
    - `Topomatic.Visualization.ImDocumentGenerated`

#### Constructors (1)

- `.ctor(String name, Byte[] data)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetData` | `Byte[]` | `` | `` |

### `ImDocuments` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImDocuments` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.ImDocument, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.ImDocuments`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(TypedObject tobj)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImDocuments` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `LoadFromStg` | `Void` | `IStgArray array, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `IStgArray array, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImElement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElement` |
| **Base Type** | `Topomatic.Visualization.TypedObject` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flags` | `Model3DElementFlags` | `get` | No | `` |
| `IsAssembly` | `Boolean` | `get` | No | `` |
| `IsMergeGroups` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImElement` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetBrep` | `Shell` | `` | `` |
| `GetCompleteModel` | `GeometryModel3D` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetReferences` | `IEnumerable<IImElementReference>` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CategoryTag` | `String` | Yes | `"Category"` | `` |
| `FamilyTag` | `String` | Yes | `"Family"` | `` |
| `IdentifierTag` | `String` | Yes | `"Identifier"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImElementCollection` (interface)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementCollection` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `ImElement` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Synchronize` | `Void` | `Guid id` | `` |

### `ImElementCollectionContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementCollectionContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ImCollection` | `ImElementCollection` | `get` | No | `` |

### `ImElementExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckView` | `Void` | `Model3DView view` | `Extension` |
| `GetElementView` | `Model3DView` | `Matrix matrix, ref Vector3D position, ref Vector3D scale, ref Double angle` | `Extension` |
| `GetMatrix` | `Matrix` | `Vector3D position, Vector3D scale, Vector3D ox, Vector3D oy` | `` |
| `GetMatrix` | `Matrix` | `IImElementReference item` | `Extension` |
| `GetPlacement` | `Void` | `Matrix matrix, ref ImElementPlacement placement` | `Extension` |
| `LoadResources` | `Void` | `ImElement element, IncludeHandler handler` | `Extension` |

### `ImElementPlacement` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementPlacement` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.ImElementPlacement`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Default` | `ImElementPlacement` | Yes | `` | `` |
| `Ox` | `Vector3D` | No | `` | `` |
| `Oy` | `Vector3D` | No | `` | `` |
| `Position` | `Vector3D` | No | `` | `` |
| `Scale` | `Vector3D` | No | `` | `` |

### `ImElementReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementReference` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.IImElementReference` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String name, ImElement element, Vector3D position, Vector3D ox, Vector3D oy, Vector3D scale, ImProperties properties, ImDocuments documents)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Ox` | `Vector3D` | `get` | No | `` |
| `Oy` | `Vector3D` | `get` | No | `` |
| `Position` | `Vector3D` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Scale` | `Vector3D` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IImElementReference` | `get_Name` |
| `IImElementReference` | `get_Element` |
| `IImElementReference` | `get_Position` |
| `IImElementReference` | `get_Ox` |
| `IImElementReference` | `get_Oy` |
| `IImElementReference` | `get_Scale` |
| `IImElementReference` | `get_Properties` |
| `IImElementReference` | `get_Documents` |

### `ImGuidElement` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImGuidElement` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Guid` | `Guid` | `get` | No | `` |

### `ImProperties` (class)

**Attributes**: [PropertyProvider]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImProperties` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.ImProperty, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.ImProperties`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImProperties` | `` | `` |
| `Equality` | `Boolean` | `ImProperties other` | `` |
| `FindEquality` | `ImProperty` | `ImProperty p` | `` |
| `FindEquality` | `ImProperty` | `String tag, String name` | `` |
| `LoadDefaultSystemPropertyTypes` | `Void` | `` | `` |
| `LoadFromStgArray` | `Void` | `IStgArray array, ISerializationContext context` | `` |
| `LoadPropertyTypes` | `Void` | `Func<ImTypeDescriptor ImTypeDescriptor> func` | `` |
| `ReadPropertiesJson` | `Void` | `JsonReader json` | `` |
| `RemoveEquality` | `Boolean` | `ImProperty p` | `` |
| `RemoveEquality` | `Boolean` | `String tag, String name` | `` |
| `SaveToStgArray` | `Void` | `IStgArray array, ISerializationContext context` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImProperty` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImProperty` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (3)

- `.ctor(String tag, String name, Object value)`
- `.ctor(String tag, String name, Object value, ImPropertyInfo info)`
- `.ctor(String tag, String name, Object value, MeasureUnit units)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Fixed` | `Boolean` | `get/set` | No | `` |
| `Info` | `ImPropertyInfo` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `StringTag` | `String` | `get` | No | `` |
| `StringValue` | `String` | `get` | No | `` |
| `Tag` | `String` | `get/set` | No | `` |
| `Value` | `Object` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImProperty` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equality` | `Boolean` | `ImProperty a, ImProperty b` | `` |

### `ImPropertyInfo` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImPropertyInfo` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Layout` | `ImPropertyLayout` | `get/set` | No | `` |
| `Units` | `MeasureUnit` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equality` | `Boolean` | `ImPropertyInfo a, ImPropertyInfo b` | `` |

### `ImPropertyKey` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImPropertyKey` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.ImPropertyKey`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Column` | `Int32` | No | `` | `` |
| `Row` | `Int32` | No | `` | `` |
| `Tag` | `String` | No | `` | `` |

### `ImPropertyLayout` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImPropertyLayout` |
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
      - `Topomatic.Visualization.ImPropertyLayout`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `List` | `ImPropertyLayout` | Yes | `List` | `` |
| `Single` | `ImPropertyLayout` | Yes | `Single` | `` |
| `Table` | `ImPropertyLayout` | Yes | `Table` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Single` | `0` |
| `List` | `1` |
| `Table` | `2` |

**Underlying Type**: `System.Int32`

### `ImTypeDescriptor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImTypeDescriptor` |
| **Base Type** | `Topomatic.Visualization.ImAggregates` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImAggregates`
      - `Topomatic.Visualization.ImTypeDescriptor`

#### Constructors (2)

- `.ctor(String id, String title, ImTypeDescriptor parent)`
- `.ctor(String id, String title, ImTypeDescriptor parent, ImProperties properties, ImDocuments documents)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `IsAssignableTo` | `Boolean` | `String id` | `` |
| `ToString` | `String` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImTypeDescriptors` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImTypeDescriptors` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.ImTypeDescriptor, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(IEnumerable<ImTypeDescriptors> merged)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Custom` | `ImTypeDescriptors` | `get` | Yes | `` |
| `Item` | `ImTypeDescriptor` | `get` | No | `` |
| `System` | `ImTypeDescriptors` | `get` | Yes | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Contains` | `Boolean` | `String id` | `` |
| `Filter` | `IEnumerable<ImTypeDescriptor>` | `Predicate<ImTypeDescriptor> match` | `` |
| `Filter` | `IEnumerable<ImTypeDescriptor>` | `String parent` | `` |
| `GetEnumerator` | `IEnumerator<ImTypeDescriptor>` | `` | `` |
| `LoadJson` | `Void` | `String filename` | `` |
| `Merge` | `Void` | `ImTypeDescriptors other` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FilterImDescriptors` | `IEnumerable<ImTypeDescriptor>` | `String parent` | `` |
| `FilterImDescriptors` | `IEnumerable<ImTypeDescriptor>` | `Predicate<ImTypeDescriptor> match` | `` |
| `FindDescriptor` | `ImTypeDescriptor` | `String id` | `` |

#### Nested Types (2)

- `CustomDescriptorProperties` (class)
- `CustomDescriptors` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `IntegerPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.IntegerPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.IntegerPropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `High` | `Nullable<Int32>` | `get/set` | No | `` |
| `Low` | `Nullable<Int32>` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `ISerializationContext` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ISerializationContext` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBlob` | `Int32` | `Byte[] data` | `` |
| `AddClass` | `Int32` | `String cls` | `` |
| `AddGeometryModel3D` | `Int32` | `GeometryModel3D model` | `` |
| `AddSerializable` | `Int32` | `IStgSerializable obj` | `` |
| `AddType` | `Int32` | `ImTypeDescriptor descriptor` | `` |
| `GetBlob` | `Byte[]` | `Int32 id` | `` |
| `GetClass` | `String` | `Int32 id` | `` |
| `GetGeometryModel3D` | `GeometryModel3D` | `Int32 id` | `` |
| `GetSerializable` | `T` | `Int32 id` | `` |
| `GetType` | `ImTypeDescriptor` | `Int32 id` | `` |

### `IStgContextSerializable` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.IStgContextSerializable` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |

### `ITypedObjectCollection` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ITypedObjectCollection` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `LibraryUid` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindObject` | `TypedObject` | `String uid` | `` |
| `FindPath` | `String` | `String uid` | `` |
| `FindUids` | `IEnumerable<String>` | `String parentType, Predicate<TypedObject> match` | `` |

### `MeasureUnit` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.MeasureUnit` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(String id, String title)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Id` | `String` | `get` | No | `` |
| `Title` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Model3DCutting` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DCutting` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IEnumerable<Vector2D> section, Vector3D normal)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Global` | `IEnumerable<Vector3D>` | `get` | No | `` |
| `Normal` | `Vector3D` | `get/set` | No | `` |
| `Section` | `IEnumerable<Vector2D>` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Back` | `Model3DCutting` | Yes | `` | `` |
| `Bottom` | `Model3DCutting` | Yes | `` | `` |
| `Front` | `Model3DCutting` | Yes | `` | `` |
| `Left` | `Model3DCutting` | Yes | `` | `` |
| `Right` | `Model3DCutting` | Yes | `` | `` |
| `Top` | `Model3DCutting` | Yes | `` | `` |

### `Model3DElementFlags` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DElementFlags` |
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
      - `Topomatic.Visualization.Model3DElementFlags`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `kAssembly` | `Model3DElementFlags` | Yes | `kAssembly` | `` |
| `kMergeGroups` | `Model3DElementFlags` | Yes | `kMergeGroups` | `` |
| `kNone` | `Model3DElementFlags` | Yes | `kNone` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `kNone` | `0` |
| `kAssembly` | `1` |
| `kMergeGroups` | `2` |

**Underlying Type**: `System.Int32`

### `Model3DView` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DView` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector3D direction, Vector3D head)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Direction` | `Vector3D` | `get/set` | No | `` |
| `Head` | `Vector3D` | `get/set` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Back` | `Model3DView` | Yes | `` | `` |
| `Bottom` | `Model3DView` | Yes | `` | `` |
| `Front` | `Model3DView` | Yes | `` | `` |
| `Left` | `Model3DView` | Yes | `` | `` |
| `Right` | `Model3DView` | Yes | `` | `` |
| `Top` | `Model3DView` | Yes | `` | `` |

### `Model3DViewOptions` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DViewOptions` |
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
      - `Topomatic.Visualization.Model3DViewOptions`

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AnalizeHidden` | `Model3DViewOptions` | Yes | `BestSpeed, AnalizeHidden` | `` |
| `BestQuality` | `Model3DViewOptions` | Yes | `BestSpeed, BestQuality` | `` |
| `BestSpeed` | `Model3DViewOptions` | Yes | `None` | `` |
| `Good` | `Model3DViewOptions` | Yes | `BestSpeed, Good` | `` |
| `HideHidden` | `Model3DViewOptions` | Yes | `BestSpeed, HideHidden` | `` |
| `Merge` | `Model3DViewOptions` | Yes | `BestSpeed, Merge` | `` |
| `None` | `Model3DViewOptions` | Yes | `None` | `` |
| `Optimize` | `Model3DViewOptions` | Yes | `BestSpeed, Optimize` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `BestSpeed` | `0` |
| `AnalizeHidden` | `1` |
| `HideHidden` | `2` |
| `Optimize` | `4` |
| `Merge` | `8` |
| `Good` | `12` |
| `BestQuality` | `13` |

**Underlying Type**: `System.Int32`

### `ReferencePropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ReferencePropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.ReferencePropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Target` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultPointsignList` | `ReferencePropertyInfo` | Yes | `` | `` |
| `DefaultPointsignSingle` | `ReferencePropertyInfo` | Yes | `` | `` |
| `DefaultPointsignTable` | `ReferencePropertyInfo` | Yes | `` | `` |

### `ResetState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImTypeDescriptors+CustomDescriptorProperties+ResetState` |
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
      - `Topomatic.Visualization.ImTypeDescriptors+CustomDescriptorProperties+ResetState`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `None` | `ResetState` | Yes | `None` | `` |
| `Reload` | `ResetState` | Yes | `Reload` | `` |
| `Remove` | `ResetState` | Yes | `Remove` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Remove` | `1` |
| `Reload` | `2` |

**Underlying Type**: `System.Int32`

### `SerializationContext` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.SerializationContext` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.ISerializationContext, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get` | No | `` |

#### Instance Methods (12)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBlob` | `Int32` | `Byte[] data` | `` |
| `AddClass` | `Int32` | `String cls` | `` |
| `AddGeometryModel3D` | `Int32` | `GeometryModel3D model` | `` |
| `AddSerializable` | `Int32` | `IStgSerializable obj` | `` |
| `AddType` | `Int32` | `ImTypeDescriptor descriptor` | `` |
| `GetBlob` | `Byte[]` | `Int32 id` | `` |
| `GetClass` | `String` | `Int32 id` | `` |
| `GetGeometryModel3D` | `GeometryModel3D` | `Int32 id` | `` |
| `GetSerializable` | `T` | `Int32 id` | `` |
| `GetType` | `ImTypeDescriptor` | `Int32 id` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ISerializationContext` | `get_Owner` |
| `ISerializationContext` | `AddClass` |
| `ISerializationContext` | `GetClass` |
| `ISerializationContext` | `AddType` |
| `ISerializationContext` | `GetType` |
| `ISerializationContext` | `AddGeometryModel3D` |
| `ISerializationContext` | `GetGeometryModel3D` |
| `ISerializationContext` | `AddBlob` |
| `ISerializationContext` | `GetBlob` |
| `ISerializationContext` | `AddSerializable` |
| `ISerializationContext` | `GetSerializable` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StringPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.StringPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.StringPropertyInfo`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `DefaultList` | `StringPropertyInfo` | Yes | `` | `` |
| `DefaultSingle` | `StringPropertyInfo` | Yes | `` | `` |
| `DefaultTable` | `StringPropertyInfo` | Yes | `` | `` |

### `TypedObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObject` |
| **Base Type** | `System.Object` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (29)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ApplayOverridedProperties` | `Void` | `IEnumerable<ImProperty> properties` | `` |
| `GetAllProperties` | `ImProperties` | `` | `` |
| `GetBoolean` | `Boolean` | `String tag, Boolean def` | `` |
| `GetBoolean` | `Boolean` | `String tag` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetDouble` | `Double` | `String tag` | `` |
| `GetDouble` | `Double` | `String tag, Double def` | `` |
| `GetIndexedValue` | `Boolean` | `ImProperty property, Int32 row, Int32 column, ref Object value` | `` |
| `GetInt` | `Int32` | `String tag` | `` |
| `GetInt` | `Int32` | `String tag, Int32 def` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetPropertyObjects` | `TypedObject[]` | `ImPropertyKey[] keys` | `` |
| `GetString` | `String` | `String tag, String def` | `` |
| `GetString` | `String` | `String tag` | `` |
| `GetValue` | `Object` | `String tag` | `` |
| `SaveToStg` | `Void` | `StgNode node, ISerializationContext context` | `` |
| `SetIndexedValue` | `Boolean` | `ImProperty property, Int32 row, Int32 column, Object value` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |
| `TryGetBoolean` | `Boolean` | `String tag, ref Boolean value` | `` |
| `TryGetDouble` | `Boolean` | `String tag, ref Double value` | `` |
| `TryGetInt` | `Boolean` | `String tag, ref Int32 value` | `` |
| `TryGetProperty` | `Boolean` | `String stringTag, String name, ref ImProperty value` | `` |
| `TryGetProperty` | `Boolean` | `ImProperty s, ref ImProperty value` | `` |
| `TryGetProperty` | `Boolean` | `ImPropertyKey[] keys, ref ImProperty value` | `` |
| `TryGetString` | `Boolean` | `String tag, ref String value` | `` |
| `TryGetValue` | `Boolean` | `ImPropertyKey[] keys, ref Object value` | `` |
| `TryGetValue` | `Boolean` | `String tag, ref Object value` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `TypedObject` | `StgNode node, ISerializationContext context` | `` |
| `TryGetDouble` | `Boolean` | `Object obj, ref Double value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICloneable` | `System.ICloneable.Clone` |

### `TypedPropertyInfo` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedPropertyInfo` |
| **Base Type** | `Topomatic.Visualization.ImPropertyInfo` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.ImPropertyInfo`
    - `Topomatic.Visualization.TypedPropertyInfo`

#### Constructors (1)

- `.ctor(ImTypeDescriptor type)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Type` | `ImTypeDescriptor` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ImPropertyInfo` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

### `Units` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Units` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Fields (24)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `All` | `Dictionary<String MeasureUnit>` | Yes | `` | `` |
| `Celsius` | `MeasureUnit` | Yes | `` | `` |
| `Centimeters` | `MeasureUnit` | Yes | `` | `` |
| `Count` | `MeasureUnit` | Yes | `` | `` |
| `CubicMetters` | `MeasureUnit` | Yes | `` | `` |
| `Degres` | `MeasureUnit` | Yes | `` | `` |
| `Density` | `MeasureUnit` | Yes | `` | `` |
| `FlowSpeed` | `MeasureUnit` | Yes | `` | `` |
| `KgM3` | `MeasureUnit` | Yes | `` | `` |
| `Kilogram` | `MeasureUnit` | Yes | `` | `` |
| `Kilometers` | `MeasureUnit` | Yes | `` | `` |
| `Kmh` | `MeasureUnit` | Yes | `` | `` |
| `kN` | `MeasureUnit` | Yes | `` | `` |
| `kPa` | `MeasureUnit` | Yes | `` | `` |
| `Metters` | `MeasureUnit` | Yes | `` | `` |
| `Millemitters` | `MeasureUnit` | Yes | `` | `` |
| `MPa` | `MeasureUnit` | Yes | `` | `` |
| `Pa` | `MeasureUnit` | Yes | `` | `` |
| `Percent` | `MeasureUnit` | Yes | `` | `` |
| `Promiles` | `MeasureUnit` | Yes | `` | `` |
| `Radians` | `MeasureUnit` | Yes | `` | `` |
| `SpecificGravity` | `MeasureUnit` | Yes | `` | `` |
| `SquereMetters` | `MeasureUnit` | Yes | `` | `` |
| `Undefined` | `MeasureUnit` | Yes | `` | `` |

---
## Namespace: `Topomatic.Visualization.Animation`

### `AnimationKey` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.AnimationKey` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bias` | `Nullable<Single>` | `get/set` | No | `` |
| `Continuity` | `Nullable<Single>` | `get/set` | No | `` |
| `EaseFrom` | `Nullable<Single>` | `get/set` | No | `` |
| `EaseTo` | `Nullable<Single>` | `get/set` | No | `` |
| `Tension` | `Nullable<Single>` | `get/set` | No | `` |
| `Time` | `Int32` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetKeyValue` | `Single` | `Int32 index` | `` |

### `Animations` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.Animations` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FileName` | `String` | `get/set` | No | `` |
| `Length` | `Int32` | `get/set` | No | `` |
| `MeshAnimation` | `List<MeshAnimation>` | `get` | No | `` |
| `Revision` | `UInt16` | `get/set` | No | `` |

### `AnimationTrack`1<T where AnimationKey, class, AnimationKey>` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.AnimationTrack`1` |
| **Base Type** | `` |
| **Implements** | `, , , System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, , ` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Visualization.Animation.AnimationTrack`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Flags` | `UInt16` | `get/set` | No | `` |
| `Nu1` | `Int32` | `get/set` | No | `` |
| `Nu2` | `Int32` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MeshAnimation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshAnimation` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.Animation.MeshAnimation, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Animation.MeshAnimation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsEmpty` | `Boolean` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Pivot` | `Vector3F` | `get/set` | No | `` |
| `Position` | `MeshPositionTrack` | `get` | No | `` |
| `Rotation` | `MeshRotationTrack` | `get` | No | `` |
| `Scale` | `MeshScaleTrack` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MeshPositionKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshPositionKey` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationKey` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Animation.AnimationKey`
    - `Topomatic.Visualization.Animation.MeshPositionKey`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Location` | `Vector3F` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetKeyValue` | `Single` | `Int32 index` | `` |

### `MeshPositionTrack` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshPositionTrack` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshPositionKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Visualization.Animation.MeshPositionTrack`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetPosition` | `Boolean` | `Int32 time, ref Vector3F position` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MeshRotationKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshRotationKey` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationKey` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Animation.AnimationKey`
    - `Topomatic.Visualization.Animation.MeshRotationKey`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Single` | `get/set` | No | `` |
| `Axis` | `Vector3F` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetKeyValue` | `Single` | `Int32 index` | `` |

### `MeshRotationTrack` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshRotationTrack` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshRotationKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Visualization.Animation.MeshRotationTrack`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetRotation` | `Boolean` | `Int32 time, ref Single angle, ref Vector3F axis` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MeshScaleKey` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshScaleKey` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationKey` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Animation.AnimationKey`
    - `Topomatic.Visualization.Animation.MeshScaleKey`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Scale` | `Vector3F` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetKeyValue` | `Single` | `Int32 index` | `` |

### `MeshScaleTrack` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Animation.MeshScaleTrack` |
| **Base Type** | `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Animation.AnimationTrack`1[[Topomatic.Visualization.Animation.MeshScaleKey, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
      - `Topomatic.Visualization.Animation.MeshScaleTrack`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetScale` | `Boolean` | `Int32 time, ref Vector3F scale` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Geometry`

### `AutoGeneratedTexture` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.AutoGeneratedTexture` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Filter` | `TargetFilter` | `get/set` | No | `` |
| `Format` | `TargetFormat` | `get/set` | No | `` |
| `GenerateMipmaps` | `Boolean` | `get/set` | No | `` |
| `Height` | `Int32` | `get/set` | No | `` |
| `Sources` | `List<TextureSource>` | `get` | No | `` |
| `Width` | `Int32` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `AutoGeneratedTexture` | `String technique` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (4)

- `RenderTarget` (class)
- `TargetFilter` (enum)
- `TargetFormat` (enum)
- `TextureSource` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `BitmapTexture` (class)

**Attributes**: [DebuggerDisplay]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.BitmapTexture` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bitmap` | `Byte[]` | `get/set` | No | `` |
| `Blur` | `Single` | `get/set` | No | `` |
| `Filter` | `FilterType` | `get/set` | No | `` |
| `IgnoreAlpha` | `Boolean` | `get/set` | No | `` |
| `Mirror` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Negative` | `Boolean` | `get/set` | No | `` |
| `Percent` | `Single` | `get/set` | No | `` |
| `Rotation` | `Single` | `get/set` | No | `` |
| `Tiling` | `TileType` | `get/set` | No | `` |
| `UOffset` | `Single` | `get/set` | No | `` |
| `UScale` | `Single` | `get/set` | No | `` |
| `VOffset` | `Single` | `get/set` | No | `` |
| `VScale` | `Single` | `get/set` | No | `` |

### `DirectoryIncludeHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.DirectoryIncludeHandler` |
| **Base Type** | `Topomatic.Visualization.Geometry.IncludeHandler` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Geometry.IncludeHandler`
    - `Topomatic.Visualization.Geometry.DirectoryIncludeHandler`

#### Constructors (1)

- `.ctor(String directory)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |

### `Face` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.Face` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.Geometry.Face`

#### Constructors (2)

- `.ctor(Int32 a, Int32 b, Int32 c)`
- `.ctor(UInt16 a, UInt16 b, UInt16 c, UInt16 flags)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Flip` | `Face` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `A` | `UInt16` | No | `` | `` |
| `B` | `UInt16` | No | `` | `` |
| `C` | `UInt16` | No | `` | `` |
| `Flags` | `UInt16` | No | `` | `` |

### `FilterType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.FilterType` |
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
      - `Topomatic.Visualization.Geometry.FilterType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Pyramidal` | `FilterType` | Yes | `Pyramidal` | `` |
| `SummedArea` | `FilterType` | Yes | `SummedArea` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Pyramidal` | `0` |
| `SummedArea` | `1` |

**Underlying Type**: `System.UInt16`

### `GeometryModel3D` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.GeometryModel3D` |
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
| `Animation` | `Animations` | `get` | No | `` |
| `Materials` | `IDictionary<String IPhongMaterial>` | `get` | No | `` |
| `Meshes` | `IDictionary<String MeshGeometry3D>` | `get` | No | `` |
| `Shaders` | `IDictionary<String Byte[]>` | `get` | No | `` |
| `Textures` | `IDictionary<String Byte[]>` | `get` | No | `` |
| `Version` | `Int32` | `get/set` | No | `` |

#### Instance Methods (21)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Append` | `Void` | `GeometryModel3D model, String name, Matrix matrix, Dictionary<String String> materials` | `` |
| `Append` | `Void` | `GeometryModel3D model, Matrix matrix` | `` |
| `ApplayAnimation` | `Void` | `Int32 time` | `` |
| `Clone` | `GeometryModel3D` | `` | `` |
| `FixNames` | `Void` | `` | `` |
| `GenerateMaterialName` | `String` | `String name` | `` |
| `GenerateMeshName` | `String` | `String name` | `` |
| `GetBoundingSphere` | `BoundingSphere3D` | `` | `` |
| `GetBounds` | `BoundingBox3D` | `` | `` |
| `IsEmpty` | `Boolean` | `` | `` |
| `LoadFrom3dsFile` | `Void` | `String filename` | `` |
| `LoadFrom3dsStream` | `Void` | `Stream stream` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadJ3d` | `Void` | `Stream stream` | `` |
| `LoadResources` | `Void` | `IncludeHandler handler` | `` |
| `MergeEqualsVerteces` | `Void` | `Single eps` | `` |
| `Optimize` | `Void` | `` | `` |
| `SaveJ3d` | `Void` | `Stream stream` | `` |
| `SaveTo3dsFile` | `Void` | `String filename` | `` |
| `SaveTo3dsStream` | `Void` | `Stream stream` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadMaterialJmtl` | `IPhongMaterial` | `Stream stream` | `` |
| `SaveMaterialJmtl` | `Void` | `IPhongMaterial material, Stream stream` | `` |

### `IncludeHandler` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.IncludeHandler` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |
| `Rename` | `String` | `IncludeHandlerType includeType, String filename, Byte[] data` | `` |

### `IncludeHandlerType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.IncludeHandlerType` |
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
      - `Topomatic.Visualization.Geometry.IncludeHandlerType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Shader` | `IncludeHandlerType` | Yes | `Shader` | `` |
| `Texture` | `IncludeHandlerType` | Yes | `Texture` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Texture` | `0` |
| `Shader` | `1` |

**Underlying Type**: `System.Int32`

### `IPhongMaterial` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.IPhongMaterial` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Stg.IStgSerializable, System.ICloneable, System.IEquatable`1[[Topomatic.Visualization.Geometry.IPhongMaterial, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToPhong` | `PhongMaterial` | `` | `` |

### `MaterialFlags` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MaterialFlags` |
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
      - `Topomatic.Visualization.Geometry.MaterialFlags`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Additive` | `MaterialFlags` | Yes | `Additive` | `` |
| `FaceMap` | `MaterialFlags` | Yes | `FaceMap` | `` |
| `None` | `MaterialFlags` | Yes | `None` | `` |
| `Soften` | `MaterialFlags` | Yes | `Soften` | `` |
| `TwoSide` | `MaterialFlags` | Yes | `TwoSide` | `` |
| `UseBlur` | `MaterialFlags` | Yes | `UseBlur` | `` |
| `UseFall` | `MaterialFlags` | Yes | `UseFall` | `` |
| `UseIllumination` | `MaterialFlags` | Yes | `UseIllumination` | `` |
| `UseWireAbs` | `MaterialFlags` | Yes | `UseWireAbs` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `TwoSide` | `1` |
| `UseWireAbs` | `2` |
| `UseFall` | `4` |
| `UseBlur` | `8` |
| `UseIllumination` | `16` |
| `Additive` | `32` |
| `FaceMap` | `64` |
| `Soften` | `128` |

**Underlying Type**: `System.UInt16`

### `MaterialGroup` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MaterialGroup` |
| **Base Type** | `Topomatic.FoundationClasses.IndexesCollection`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.IndexesCollection`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Visualization.Geometry.MaterialGroup`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Material` | `String` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MaterialGroupsCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MaterialGroupsCollection` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.Geometry.MaterialGroup, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Geometry.MaterialGroupsCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MeshGeometry3D` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MeshGeometry3D` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Colors` | `Vector3dCollection` | `get` | No | `` |
| `Groups` | `MaterialGroupsCollection` | `get` | No | `` |
| `LocalMatrix` | `Matrix` | `get/set` | No | `` |
| `Matrix` | `Matrix` | `get/set` | No | `` |
| `Normals` | `Vector3dCollection` | `get` | No | `` |
| `PositionFlags` | `PositionFlagsCollection` | `get` | No | `` |
| `Positions` | `Vector3dCollection` | `get` | No | `` |
| `PositionWeights` | `WeightsCollection` | `get` | No | `` |
| `Smoothing` | `SmoothingGroups` | `get` | No | `` |
| `TextureCoordinates` | `Vector2dCollection` | `get` | No | `` |
| `TextureCoordinates2` | `Vector2dCollection` | `get` | No | `` |
| `TriangleIndices` | `TrianglesCollection` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CalculateDefaultNormals` | `Void` | `` | `` |
| `CalculateSmoothness` | `MeshGeometry3D` | `ManagedBuffer<Vector3F> normals` | `` |
| `CalculateSmoothness` | `MeshGeometry3D` | `ManagedBuffer<Vector3F> normals, Int32 version` | `` |
| `GetBoundingSphere` | `BoundingSphere3D` | `` | `` |
| `GetBounds` | `BoundingBox3D` | `` | `` |

### `MeshGeometry3DExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MeshGeometry3DExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddCube` | `Void` | `MeshGeometry3D mesh, Matrix matrix, String material` | `Extension` |
| `AddCube` | `Void` | `MeshGeometry3D mesh, Single size, String material` | `Extension` |
| `AddIndex` | `UInt16` | `MeshGeometry3D mesh, Int32 a, Int32 b, Int32 c` | `Extension` |
| `AddSphere` | `Void` | `MeshGeometry3D mesh, Single diameter, Int32 tessellation, String material` | `Extension` |
| `AddTexture` | `UInt16` | `MeshGeometry3D mesh, Double x, Double y` | `Extension` |
| `AddVertex` | `UInt16` | `MeshGeometry3D mesh, Vector3D position` | `Extension` |
| `CreatePatchIndices` | `Void` | `MeshGeometry3D mesh, Int32 tessellation, Boolean isMirrored` | `Extension` |
| `CreatePatchVertices` | `Void` | `MeshGeometry3D mesh, Vector3D[] patch, Int32 tessellation, Boolean isMirrored` | `Extension` |

### `MeshHelper` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MeshHelper` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddFaceToJoiner` | `Void` | `Vector3D pos1, Vector3D pos2, Vector3D pos3, Vector2D a, Vector2D b, Line2D line, BoundingBox2D box, Action<Vector3D Vector3D> append` | `` |
| `AddFaceToJoiner3DSegments` | `Void` | `Vector3D pos1, Vector3D pos2, Vector3D pos3, Vector2D a, Vector2D b, Line2D line, BoundingBox2D box, Joiner3DSegments contour` | `` |
| `OptimizeForCache` | `Void` | `MeshGeometry3D mesh` | `Extension` |

### `PhongMaterial` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.PhongMaterial` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Visualization.Geometry.IPhongMaterial, System.ICloneable, System.IEquatable`1[[Topomatic.Visualization.Geometry.IPhongMaterial, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (19)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ambient` | `Vector3F` | `get/set` | No | `` |
| `Blur` | `Single` | `get/set` | No | `` |
| `BumpMap` | `BitmapTexture` | `get/set` | No | `` |
| `Diffuse` | `Vector3F` | `get/set` | No | `` |
| `EnvironmentMap` | `BitmapTexture` | `get/set` | No | `` |
| `Flags` | `MaterialFlags` | `get/set` | No | `` |
| `IlluminationPercentage` | `Single` | `get/set` | No | `` |
| `OpacMap` | `BitmapTexture` | `get/set` | No | `` |
| `SecondTextureMap` | `BitmapTexture` | `get/set` | No | `` |
| `SelfIlluminationMap` | `BitmapTexture` | `get/set` | No | `` |
| `Shading` | `ShadeType` | `get/set` | No | `` |
| `ShineMap` | `BitmapTexture` | `get/set` | No | `` |
| `Shininess` | `Single` | `get/set` | No | `` |
| `Specular` | `Vector3F` | `get/set` | No | `` |
| `SpecularLevel` | `Single` | `get/set` | No | `` |
| `SpecularMap` | `BitmapTexture` | `get/set` | No | `` |
| `TextureMap` | `BitmapTexture` | `get/set` | No | `` |
| `Transparency` | `Single` | `get/set` | No | `` |
| `WireSize` | `Single` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Object` | `` | `` |
| `Equals` | `Boolean` | `IPhongMaterial other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IPhongMaterial` | `Topomatic.Visualization.Geometry.IPhongMaterial.ToPhong` |
| `ICloneable` | `Clone` |
| `IEquatable`1` | `Equals` |

### `PositionFlagsCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.PositionFlagsCollection` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Visualization.Geometry.PositionFlagsCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `RenderTarget` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.AutoGeneratedTexture+RenderTarget` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Mesh` | `String` | `get/set` | No | `` |
| `Projection` | `Matrix` | `get/set` | No | `` |
| `Technique` | `String` | `get/set` | No | `` |
| `View` | `Matrix` | `get/set` | No | `` |
| `World` | `Matrix` | `get/set` | No | `` |

### `ShadeType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.ShadeType` |
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
      - `Topomatic.Visualization.Geometry.ShadeType`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Flat` | `ShadeType` | Yes | `Flat` | `` |
| `Gouraud` | `ShadeType` | Yes | `Gouraud` | `` |
| `Metal` | `ShadeType` | Yes | `Metal` | `` |
| `Phong` | `ShadeType` | Yes | `Phong` | `` |
| `value__` | `UInt16` | No | `` | `` |
| `Wire` | `ShadeType` | Yes | `Wire` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Wire` | `0` |
| `Flat` | `1` |
| `Gouraud` | `2` |
| `Phong` | `3` |
| `Metal` | `4` |

**Underlying Type**: `System.UInt16`

### `SmoothingGroups` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.SmoothingGroups` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Visualization.Geometry.SmoothingGroups`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TargetFilter` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.AutoGeneratedTexture+TargetFilter` |
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
      - `Topomatic.Visualization.Geometry.AutoGeneratedTexture+TargetFilter`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Normals` | `TargetFilter` | Yes | `Normals` | `` |
| `SemiTransparent` | `TargetFilter` | Yes | `SemiTransparent` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `SemiTransparent` | `0` |
| `Normals` | `1` |

**Underlying Type**: `System.Int32`

### `TargetFormat` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.AutoGeneratedTexture+TargetFormat` |
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
      - `Topomatic.Visualization.Geometry.AutoGeneratedTexture+TargetFormat`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Color` | `TargetFormat` | Yes | `Color` | `` |
| `FractionAlpha` | `TargetFormat` | Yes | `FractionAlpha` | `` |
| `Grayscale` | `TargetFormat` | Yes | `Grayscale` | `` |
| `Solid` | `TargetFormat` | Yes | `Solid` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `FractionAlpha` | `0` |
| `Solid` | `1` |
| `Grayscale` | `2` |
| `Color` | `3` |

**Underlying Type**: `System.Int32`

### `TextureSource` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.AutoGeneratedTexture+TextureSource` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Int32` | `get/set` | No | `` |
| `Targets` | `List<RenderTarget>` | `get` | No | `` |
| `Width` | `Int32` | `get/set` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `TextureSource` | `String technique` | `` |

### `TileType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.TileType` |
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
      - `Topomatic.Visualization.Geometry.TileType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Both` | `TileType` | Yes | `Both` | `` |
| `Decal` | `TileType` | Yes | `Decal` | `` |
| `Tile` | `TileType` | Yes | `Tile` | `` |
| `value__` | `UInt16` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Tile` | `0` |
| `Decal` | `1` |
| `Both` | `2` |

**Underlying Type**: `System.UInt16`

### `TrianglesCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.TrianglesCollection` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Visualization.Geometry.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Visualization.Geometry.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.Geometry.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Visualization.Geometry.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Visualization.Geometry.Face, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Geometry.TrianglesCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector2dCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.Vector2dCollection` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Cad.Foundation.Vector2F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Cad.Foundation.Vector2F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Geometry.Vector2dCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Vector3dCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.Vector3dCollection` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[Topomatic.Cad.Foundation.Vector3F, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.Geometry.Vector3dCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WeightsCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.WeightsCollection` |
| **Base Type** | `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Implements** | `System.Collections.Generic.ICollection`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.Generic.IEnumerable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.ManagedBuffer`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]`
    - `Topomatic.Visualization.Geometry.WeightsCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Shaders`

### `BooleanShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.BooleanShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.BooleanShaderParameter`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `Value` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Integer2ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Integer2ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Integer2ShaderParameter`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Integer3ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Integer3ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Integer3ShaderParameter`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |
| `Z` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Integer4ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Integer4ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Integer4ShaderParameter`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `W` | `Int32` | `get/set` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |
| `Y` | `Int32` | `get/set` | No | `` |
| `Z` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `IntegerShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.IntegerShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.IntegerShaderParameter`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `UIMax` | `Int32` | `get/set` | No | `` |
| `UIMin` | `Int32` | `get/set` | No | `` |
| `UIStep` | `Int32` | `get/set` | No | `` |
| `X` | `Int32` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `MatrixShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.MatrixShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.MatrixShaderParameter`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Matrix` | `Matrix` | `get/set` | No | `` |
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `PixelShaderVersion` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.PixelShaderVersion` |
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
      - `Topomatic.Visualization.Shaders.PixelShaderVersion`

#### Fields (11)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `PS_1_1` | `PixelShaderVersion` | Yes | `PS_1_1` | `` |
| `PS_1_2` | `PixelShaderVersion` | Yes | `PS_1_2` | `` |
| `PS_1_3` | `PixelShaderVersion` | Yes | `PS_1_3` | `` |
| `PS_1_4` | `PixelShaderVersion` | Yes | `PS_1_4` | `` |
| `PS_2_0` | `PixelShaderVersion` | Yes | `PS_2_0` | `` |
| `PS_2_A` | `PixelShaderVersion` | Yes | `PS_2_A` | `` |
| `PS_2_B` | `PixelShaderVersion` | Yes | `PS_2_B` | `` |
| `PS_2_SW` | `PixelShaderVersion` | Yes | `PS_2_SW` | `` |
| `PS_3_0` | `PixelShaderVersion` | Yes | `PS_3_0` | `` |
| `value__` | `UInt16` | No | `` | `` |
| `XPS_3_0` | `PixelShaderVersion` | Yes | `XPS_3_0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `PS_1_1` | `1` |
| `PS_1_2` | `2` |
| `PS_1_3` | `3` |
| `PS_1_4` | `4` |
| `PS_2_0` | `5` |
| `PS_2_A` | `6` |
| `PS_2_B` | `7` |
| `PS_2_SW` | `8` |
| `PS_3_0` | `9` |
| `XPS_3_0` | `10` |

**Underlying Type**: `System.UInt16`

### `ReferenceShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.ReferenceShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.ReferenceShaderParameter`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `Reference` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Shader` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Shader` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.Geometry.IPhongMaterial, Topomatic.Stg.IStgSerializable, System.ICloneable, System.IEquatable`1[[Topomatic.Visualization.Geometry.IPhongMaterial, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Topomatic.Visualization.Shaders.ShaderParameter, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Conditions` | `String` | `get/set` | No | `` |
| `Item` | `ShaderParameter` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `PS` | `PixelShaderVersion` | `get/set` | No | `` |
| `Sortable` | `Int32` | `get/set` | No | `` |
| `Technique` | `String` | `get/set` | No | `` |
| `UIDescription` | `String` | `get/set` | No | `` |
| `UIName` | `String` | `get/set` | No | `` |
| `VertexFormat` | `ShaderVertexFormat` | `get/set` | No | `` |
| `VS` | `VertexShaderVersion` | `get/set` | No | `` |

#### Instance Methods (28)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddBoolean` | `BooleanShaderParameter` | `String name, Boolean value` | `` |
| `AddColor3f` | `Single3ShaderParameter` | `String name, Color color` | `` |
| `AddColor3i` | `Integer3ShaderParameter` | `String name, Color color` | `` |
| `AddColor4f` | `Single4ShaderParameter` | `String name, Color color` | `` |
| `AddColor4i` | `Integer4ShaderParameter` | `String name, Color color` | `` |
| `AddInteger` | `IntegerShaderParameter` | `String name, Int32 x` | `` |
| `AddInteger2` | `Integer2ShaderParameter` | `String name, Int32 x, Int32 y` | `` |
| `AddInteger3` | `Integer3ShaderParameter` | `String name, Int32 x, Int32 y, Int32 z` | `` |
| `AddInteger4` | `Integer4ShaderParameter` | `String name, Int32 x, Int32 y, Int32 z, Int32 w` | `` |
| `AddMatrix` | `MatrixShaderParameter` | `String name, Matrix matrix` | `` |
| `AddReference` | `ReferenceShaderParameter` | `String name, String reference` | `` |
| `AddSingle` | `SingleShaderParameter` | `String name, Single x` | `` |
| `AddSingle2` | `Single2ShaderParameter` | `String name, Single x, Single y` | `` |
| `AddSingle3` | `Single3ShaderParameter` | `String name, Single x, Single y, Single z` | `` |
| `AddSingle4` | `Single4ShaderParameter` | `String name, Single x, Single y, Single z, Single w` | `` |
| `AddTexture1D` | `TextureShaderParameter` | `String name, String filename` | `` |
| `AddTexture2D` | `TextureShaderParameter` | `String name, String filename` | `` |
| `AddTexture3D` | `TextureShaderParameter` | `String name, String filename` | `` |
| `AddTextureCube` | `TextureShaderParameter` | `String name, String filename` | `` |
| `Clone` | `Shader` | `` | `` |
| `Equals` | `Boolean` | `IPhongMaterial other` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String ShaderParameter>>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `LoadFromString` | `Void` | `String s` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToPhong` | `PhongMaterial` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPhongMaterial` | `ToPhong` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ICloneable` | `System.ICloneable.Clone` |
| `IEquatable`1` | `Equals` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

### `ShaderParameter` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `UIDescription` | `String` | `get/set` | No | `` |
| `UIHidden` | `Boolean` | `get/set` | No | `` |
| `UIName` | `String` | `get/set` | No | `` |
| `UIWidget` | `String` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `TryParseValue` | `Boolean` | `String s` | `` |

### `ShaderParameterType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.ShaderParameterType` |
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
      - `Topomatic.Visualization.Shaders.ShaderParameterType`

#### Fields (18)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Boolean` | `ShaderParameterType` | Yes | `Boolean` | `` |
| `Custom` | `ShaderParameterType` | Yes | `Custom` | `` |
| `Integer` | `ShaderParameterType` | Yes | `Integer` | `` |
| `Integer2` | `ShaderParameterType` | Yes | `Integer2` | `` |
| `Integer3` | `ShaderParameterType` | Yes | `Integer3` | `` |
| `Integer4` | `ShaderParameterType` | Yes | `Integer4` | `` |
| `Matrix` | `ShaderParameterType` | Yes | `Matrix` | `` |
| `Reference` | `ShaderParameterType` | Yes | `Reference` | `` |
| `Single` | `ShaderParameterType` | Yes | `Single` | `` |
| `Single2` | `ShaderParameterType` | Yes | `Single2` | `` |
| `Single3` | `ShaderParameterType` | Yes | `Single3` | `` |
| `Single4` | `ShaderParameterType` | Yes | `Single4` | `` |
| `Texture1D` | `ShaderParameterType` | Yes | `Texture1D` | `` |
| `Texture2D` | `ShaderParameterType` | Yes | `Texture2D` | `` |
| `Texture3D` | `ShaderParameterType` | Yes | `Texture3D` | `` |
| `TextureCube` | `ShaderParameterType` | Yes | `TextureCube` | `` |
| `Unknown` | `ShaderParameterType` | Yes | `Unknown` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Unknown` | `0` |
| `Integer` | `1` |
| `Integer2` | `2` |
| `Integer3` | `3` |
| `Integer4` | `4` |
| `Single` | `11` |
| `Single2` | `12` |
| `Single3` | `13` |
| `Single4` | `14` |
| `Texture1D` | `40` |
| `Texture2D` | `41` |
| `Texture3D` | `42` |
| `TextureCube` | `43` |
| `Boolean` | `50` |
| `Matrix` | `60` |
| `Custom` | `254` |
| `Reference` | `255` |

**Underlying Type**: `System.Int32`

### `ShaderVertexFormat` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.ShaderVertexFormat` |
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
      - `Topomatic.Visualization.Shaders.ShaderVertexFormat`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Binormal` | `ShaderVertexFormat` | Yes | `Binormal` | `` |
| `Color` | `ShaderVertexFormat` | Yes | `Color` | `` |
| `Normal` | `ShaderVertexFormat` | Yes | `Normal` | `` |
| `Position` | `ShaderVertexFormat` | Yes | `Position` | `` |
| `Random` | `ShaderVertexFormat` | Yes | `Random` | `` |
| `Tangent` | `ShaderVertexFormat` | Yes | `Tangent` | `` |
| `Texture` | `ShaderVertexFormat` | Yes | `Texture` | `` |
| `Texture2` | `ShaderVertexFormat` | Yes | `Texture2` | `` |
| `value__` | `UInt16` | No | `` | `` |
| `Weights` | `ShaderVertexFormat` | Yes | `Weights` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Position` | `0` |
| `Normal` | `1` |
| `Texture` | `2` |
| `Tangent` | `4` |
| `Binormal` | `8` |
| `Random` | `16` |
| `Texture2` | `32` |
| `Color` | `64` |
| `Weights` | `512` |

**Underlying Type**: `System.UInt16`

### `Single2ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Single2ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Single2ShaderParameter`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `X` | `Single` | `get/set` | No | `` |
| `Y` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Single3ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Single3ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Single3ShaderParameter`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `X` | `Single` | `get/set` | No | `` |
| `Y` | `Single` | `get/set` | No | `` |
| `Z` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `Single4ShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Single4ShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.Single4ShaderParameter`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `W` | `Single` | `get/set` | No | `` |
| `X` | `Single` | `get/set` | No | `` |
| `Y` | `Single` | `get/set` | No | `` |
| `Z` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `SingleShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.SingleShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.SingleShaderParameter`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `UIMax` | `Single` | `get/set` | No | `` |
| `UIMin` | `Single` | `get/set` | No | `` |
| `UIStep` | `Single` | `get/set` | No | `` |
| `X` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `ToString` | `String` | `` | `` |

### `TextureShaderParameter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.TextureShaderParameter` |
| **Base Type** | `Topomatic.Visualization.Shaders.ShaderParameter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Shaders.ShaderParameter`
    - `Topomatic.Visualization.Shaders.TextureShaderParameter`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Compress` | `Boolean` | `get/set` | No | `` |
| `GenMipMaps` | `Boolean` | `get/set` | No | `` |
| `HeightMap` | `Boolean` | `get/set` | No | `` |
| `NormalMap` | `Boolean` | `get/set` | No | `` |
| `ParameterType` | `ShaderParameterType` | `get` | No | `` |
| `Resource` | `String` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetValue` | `Object` | `` | `` |
| `SetParameterType` | `Void` | `ShaderParameterType type` | `` |
| `ToString` | `String` | `` | `` |

### `Vector3FExtensions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.Vector3FExtensions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToColor` | `Color` | `Vector3F vector` | `Extension` |

### `VertexShaderVersion` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Shaders.VertexShaderVersion` |
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
      - `Topomatic.Visualization.Shaders.VertexShaderVersion`

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value__` | `UInt16` | No | `` | `` |
| `VS_1_1` | `VertexShaderVersion` | Yes | `VS_1_1` | `` |
| `VS_2_0` | `VertexShaderVersion` | Yes | `VS_2_0` | `` |
| `VS_2_A` | `VertexShaderVersion` | Yes | `VS_2_A` | `` |
| `VS_2_SW` | `VertexShaderVersion` | Yes | `VS_2_SW` | `` |
| `VS_3_0` | `VertexShaderVersion` | Yes | `VS_3_0` | `` |
| `XVS_3_0` | `VertexShaderVersion` | Yes | `XVS_3_0` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `VS_1_1` | `1` |
| `VS_2_0` | `2` |
| `VS_2_A` | `3` |
| `VS_2_SW` | `4` |
| `VS_3_0` | `5` |
| `XVS_3_0` | `6` |

**Underlying Type**: `System.UInt16`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 349 |
| **Classes** | 148 |
| **Interfaces** | 33 |
| **Enums** | 55 |
| **Structs** | 58 |
| **Abstract Classes** | 28 |
| **Static Classes** | 27 |
| **Total Methods** | 1899 |
| **Total Properties** | 697 |
| **Total Fields** | 655 |
| **Total Events** | 3 |
| **Total Constructors** | 243 |
| **Nested Types** | 54 |
| **Extension Methods** | 0 |


