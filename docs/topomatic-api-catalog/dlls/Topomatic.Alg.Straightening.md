# Topomatic.Alg.Straightening

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Alg.Straightening` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Alg.Straightening, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Alg.Straightening.dll` |

---
## Namespace: `Topomatic.Alg.Straightening`

### `IStraighteningContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.IStraighteningContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Straightening` | `Straightening` | `get` | No | `` |

### `OffsetValue` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.OffsetValue` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Straightening.OffsetValue`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `OffsetValue` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Offset` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `OffsetValues` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.OffsetValues` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Alg.Straightening.OffsetValues`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ClearPlan` | `Boolean` | `get/set` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `OffsetValue` | `get` | No | `` |
| `MakeRectifiableAlignment` | `Boolean` | `get/set` | No | `` |
| `MatchedAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `Side` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Int32` | `OffsetValue value` | `` |
| `AddInterval` | `Void` | `Double sta1, Double sta2, Double value` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `TryGetValue` | `Boolean` | `Double station, ref Double offset` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RectifiableAlignment` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.RectifiableAlignment` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, Topomatic.Cad.Foundation.IObjectDisjoiner, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Straightening.RectifiableAlignment`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `Item` | `Vector2D` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (20)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Vector2D item` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Vector2D item` | `` |
| `CopyTo` | `Void` | `Vector2D[] array, Int32 arrayIndex` | `` |
| `GetAbsCurvature` | `Double` | `Int32 index` | `` |
| `GetCenterPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEndPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetEnumerator` | `IEnumerator<Vector2D>` | `` | `` |
| `GetInsertionPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetMiddlePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetNodePoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetQuadrantPoint` | `Void` | `ObjectsDisjointerArgs e, IList<Vector3D> list` | `` |
| `GetRadius` | `Double` | `Int32 index` | `` |
| `GetSegments` | `Void` | `ObjectsDisjointerArgs e, IList<ArcSegment> arcList, IList<LineSegment> lineList` | `` |
| `IndexOf` | `Int32` | `Vector2D item` | `` |
| `Insert` | `Void` | `Int32 index, Vector2D item` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Remove` | `Boolean` | `Vector2D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
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
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IObjectDisjoiner` | `GetEndPoint` |
| `IObjectDisjoiner` | `GetCenterPoint` |
| `IObjectDisjoiner` | `GetMiddlePoint` |
| `IObjectDisjoiner` | `GetNodePoint` |
| `IObjectDisjoiner` | `GetQuadrantPoint` |
| `IObjectDisjoiner` | `GetInsertionPoint` |
| `IObjectDisjoiner` | `GetSegments` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `Straightening` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Straightening` |
| **Base Type** | `Topomatic.FoundationClasses.UndoObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.FoundationClasses.UndoObject`
      - `Topomatic.Alg.Straightening.Straightening`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CheckCurveLength` | `Boolean` | `get/set` | No | `` |
| `CheckLineAngle` | `Boolean` | `get/set` | No | `` |
| `ControlAlignmentRelativePath` | `String` | `get/set` | No | `` |
| `GabaritesDistance` | `Double` | `get/set` | No | `` |
| `HasControlAlignment` | `Boolean` | `get/set` | No | `` |
| `MaximumLineAngle` | `Double` | `get/set` | No | `` |
| `MinimalCurveLength` | `Double` | `get/set` | No | `` |
| `OffsetValues` | `OffsetValues` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `RectifiableAlignment` | `RectifiableAlignment` | `get` | No | `` |
| `ShowGabarites` | `Boolean` | `get/set` | No | `` |
| `Style` | `StraighteningStyle` | `get` | No | `` |

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

### `StraighteningConsts` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.StraighteningConsts` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCurvatureFromRadius` | `Double` | `Double radius` | `` |
| `GetCurvatureFromThreePoints` | `Double` | `Vector2D pos1, Vector2D pos2, Vector2D pos3` | `` |
| `GetRadiusFromCurvature` | `Double` | `Double curvature` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CURVE_SCALE` | `Int32` | Yes | `100000` | `` |
| `MINIMAL_CURVATURE` | `Double` | Yes | `500` | `` |
| `MINIMAL_RADIUS` | `Double` | Yes | `200` | `` |
| `PluginID` | `String` | Yes | `"Straightening"` | `` |
| `StraighteningWindow` | `String` | Yes | `"id_straightening"` | `` |

---
## Namespace: `Topomatic.Alg.Straightening.Style`

### `CurvatureGraphStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Style.CurvatureGraphStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Straightening.Style.CurvatureGraphStyle`

#### Constructors (1)

- `.ctor(StraighteningStyle owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `ParametersShowText` | `Boolean` | `get/set` | No | `` |
| `ParametersTextSize` | `Single` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `RectifiableAlignmentPlanStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Style.RectifiableAlignmentPlanStyle` |
| **Base Type** | `Topomatic.Alg.Style.AlignmentLayerStyleItem` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Alg.Style.AlignmentStyleItem`
    - `Topomatic.Alg.Style.AlignmentLayerStyleItem`
      - `Topomatic.Alg.Straightening.Style.RectifiableAlignmentPlanStyle`

#### Constructors (1)

- `.ctor(StraighteningStyle owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BorderHeight` | `Single` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `EnableRectifiableAlignmentEdit` | `Boolean` | `get/set` | No | `` |
| `PointsSize` | `Single` | `get/set` | No | `` |
| `PointsTextSize` | `Single` | `get/set` | No | `` |
| `ShowPointsDirectionPrefix` | `Boolean` | `get/set` | No | `` |
| `StandardName` | `String` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `StraighteningStyle` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Style.StraighteningStyle` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IOwned, Topomatic.FoundationClasses.IOwned`1[[Topomatic.Alg.Straightening.Straightening, Topomatic.Alg.Straightening, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[Topomatic.Alg.Style.AlignmentStyleItem, Topomatic.Alg, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Straightening owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurvatureGraphStyle` | `CurvatureGraphStyle` | `get` | No | `` |
| `LayerStyles` | `IEnumerable<AlignmentLayerStyleItem>` | `get` | No | `` |
| `Owner` | `Straightening` | `get/set` | No | `` |
| `PlanStyle` | `RectifiableAlignmentPlanStyle` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator<AlignmentStyleItem>` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `Topomatic.FoundationClasses.IOwned.get_Owner` |
| `IOwned` | `Topomatic.FoundationClasses.IOwned.set_Owner` |
| `IOwned`1` | `get_Owner` |
| `IOwned`1` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |
| `IEnumerable`1` | `GetEnumerator` |

---
## Namespace: `Topomatic.Alg.Straightening.Tools`

### `Point` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Tools.PrfTools+Point` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Straightening.Tools.PrfTools+Point`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `IsInterpolated` | `Boolean` | No | `` | `` |
| `Offset` | `Double` | No | `` | `` |
| `OffsetPosition` | `Vector2D` | No | `` | `` |
| `Position` | `Vector2D` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |
| `Status` | `PointStatus` | No | `` | `` |

### `PointStatus` (enum)

**Attributes**: [Flags]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Tools.PrfTools+PointStatus` |
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
      - `Topomatic.Alg.Straightening.Tools.PrfTools+PointStatus`

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BeginCurve` | `PointStatus` | Yes | `BeginCurve` | `` |
| `EndCurve` | `PointStatus` | Yes | `EndCurve` | `` |
| `ExistingPoint` | `PointStatus` | Yes | `ExistingPoint` | `` |
| `StationPoint` | `PointStatus` | Yes | `StationPoint` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Vertex` | `PointStatus` | Yes | `Vertex` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `StationPoint` | `1` |
| `ExistingPoint` | `2` |
| `BeginCurve` | `4` |
| `EndCurve` | `8` |
| `Vertex` | `16` |

**Underlying Type**: `System.Int32`

### `PrfTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Tools.PrfTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `PreparePoints` | `Boolean` | `Alignment alignment, RectifiableAlignment rectifiableAlignment, Boolean rectifiableAlignmentPoints, Boolean interpolate, Boolean stepStations, Boolean wholeStations, Double startStation, Double endStation, Double lineStep, Double curveStep, List<Segment> segments, List<Point> points, Func<Boolean> cancel, ref Double min, ref Double max` | `` |
| `PrepareSegments` | `Boolean` | `Alignment alignment, Double startStation, Double endStation, List<Segment> segments, Func<Boolean> cancel` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FLAG_INTERPOLATE` | `Int32` | Yes | `8` | `` |
| `FLAG_RECTIFIABLE` | `Int32` | Yes | `2` | `` |
| `FLAG_STEP` | `Int32` | Yes | `1` | `` |
| `FLAG_WHOLE` | `Int32` | Yes | `4` | `` |

#### Nested Types (3)

- `Point` (struct)
- `PointStatus` (enum)
- `Segment` (struct)

### `Segment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Alg.Straightening.Tools.PrfTools+Segment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Alg.Straightening.Tools.PrfTools+Segment`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EndStation` | `Double` | No | `` | `` |
| `IsLine` | `Boolean` | No | `` | `` |
| `StartStation` | `Double` | No | `` | `` |
| `VertexIndex` | `Int32` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 13 |
| **Classes** | 6 |
| **Interfaces** | 1 |
| **Enums** | 1 |
| **Structs** | 3 |
| **Abstract Classes** | 0 |
| **Static Classes** | 2 |
| **Total Methods** | 43 |
| **Total Properties** | 37 |
| **Total Fields** | 27 |
| **Total Events** | 0 |
| **Total Constructors** | 6 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


