# Topomatic.Sites

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Sites` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Sites, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Sites.dll` |

---
## Namespace: `Topomatic.Sites`

### `ISiteContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.ISiteContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Site` | `Site` | `get` | No | `` |

### `IVertexNumerator3D` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.IVertexNumerator3D` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CurrentVertex` | `Nullable<Vector3D>` | `get` | No | `` |

### `Node` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Profile+Node` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sites.Profile+Node`

#### Constructors (2)

- `.ctor(Double sta, Double elev)`
- `.ctor(Double sta, Double elev, Double elev2)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Node` | `StgNode node` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Elevation` | `Double` | No | `` | `` |
| `Elevation2` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `Profile` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Profile` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.Profile`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `Node` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Node node` | `` |
| `Clear` | `Void` | `` | `` |
| `GetMinY` | `Boolean` | `Double sta, ref Double elev` | `` |
| `GetY` | `Boolean` | `Double sta, ref Double elev1, ref Double elev2` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `Node` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `Side` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Side` |
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
      - `Topomatic.Sites.Side`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Left` | `Side` | Yes | `Left` | `` |
| `Right` | `Side` | Yes | `Right` | `` |
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

### `Site` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Site` |
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
      - `Topomatic.Sites.Site`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Collection` | `SiteObjectCollection` | `get` | No | `` |
| `Description` | `String` | `get/set` | No | `` |
| `DynamicSurface` | `Boolean` | `get/set` | No | `` |
| `EgSurfaceRelativePathes` | `IList<String>` | `get` | No | `` |
| `LineMap` | `SiteObjectMap` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |
| `PatchMap` | `SiteObjectMap` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Events (4)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `AfterInsert` | `IndexerEventHandler` | No | `` |
| `AfterRemove` | `IndexerEventHandler` | No | `` |
| `NameChanged` | `EventHandler` | No | `` |
| `ValueChanged` | `EventHandler` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SiteObjectMap` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjectMap` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String name, Int32 id` | `` |
| `Clear` | `Void` | `` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<String Int32>>` | `` | `` |
| `LoadFromStg` | `Void` | `IStgArray array` | `` |
| `Remove` | `Void` | `String name` | `` |
| `SaveToStg` | `Void` | `IStgArray array` | `` |
| `TryGetValue` | `Boolean` | `String name, ref Int32 id` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SiteTools` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteTools` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (35)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CheckIntersections` | `Void` | `Surface sfc, StructureLine line1, StructureLine line2, UInt32 layer, List<Int32> indices1, List<Int32> indices2` | `` |
| `ContainsName` | `Boolean` | `Site site, String name` | `` |
| `CreatePavement` | `GeometryModel3D` | `Surface sfc, Int32 patch, Double delta, Double depth, Double width, Double grade, Double slope, CadColor color` | `` |
| `CreateSolidFromModel` | `Shell` | `GeometryModel3D model, Vector3D position` | `` |
| `CreateSolidFromTriangles` | `Void` | `Shell solid, Surface sfc, List<Int32> list, Boolean byDepth, Double value` | `` |
| `CreateSolidPavement` | `Shell` | `Surface sfc, List<Int32> list, Double delta, Double depth, Double width, Double grade, Double slope` | `` |
| `FindPoint` | `Int32` | `Surface sfc, Vector2D pos` | `` |
| `GetPatch` | `SurfacePatch` | `Site site, Surface sfc, String name` | `` |
| `GetPatchHandle` | `Int32` | `Site site, String name` | `` |
| `GetPatchId` | `String` | `Site site, SurfacePatch patch` | `` |
| `GetStructureLine` | `StructureLine` | `Surface sfc, Int32 lineId` | `` |
| `GetStructureLine` | `StructureLine` | `Site site, Surface sfc, String name` | `` |
| `GetStructureLineId` | `String` | `Site site, StructureLine sl` | `` |
| `GetStructureLineIndex` | `Int32` | `Site site, Surface sfc, String name` | `` |
| `GetStructureLineIndex` | `Int32` | `Surface sfc, Int32 lineId` | `` |
| `InsertStructureLine` | `Void` | `Surface sfc, StructureLine sl` | `` |
| `IsCCW` | `Double` | `StructureLine sl` | `` |
| `MakeContoursFromTriangles` | `Void` | `Surface sfc, List<Int32> indices, List<List<Int32>> contours` | `` |
| `MakeOffset` | `Void` | `List<Vector3D> poly, List<Vector3D> result, Double offset, Double inclination` | `` |
| `MakeOffset` | `Void` | `List<Vector3D> poly, List<Vector3D> result, Double offset1, Double offset2, Double inclination1, Double inclination2, Boolean removeloops` | `` |
| `MakeTrianglesInsideContours` | `Void` | `Surface sfc, List<Int32> indices, List<Triangle> triangles` | `` |
| `PolylineOffset` | `Void` | `IList<Vector2D> polyline, IList<Double> offsets, IList<Vector2D> result` | `` |
| `PolylineOffsetEx` | `Void` | `IList<Vector2D> polyline, List<Double> offsets, List<Double> stations, IList<Vector2D> result, Boolean removeloops` | `` |
| `PolylineOffsetEx` | `Void` | `IList<Vector2D> polyline, Double offset1, Double offset2, IList<Vector2D> result, Boolean removeloops` | `` |
| `PosInSegment` | `Boolean` | `Vector3D a, Vector3D b, Vector3D pos` | `` |
| `PosOnBorder` | `Boolean` | `Vector2D pos, IList<Vector2D> poly` | `` |
| `RebuildInside` | `Void` | `Surface sfc, StructureLine sl` | `` |
| `RemoveDuplicated` | `Void` | `List<Vector3D> list` | `` |
| `RemoveDuplicated` | `Void` | `List<Vector2D> list` | `` |
| `RemoveDuplicates` | `Void` | `List<Int32> list` | `` |
| `SelectAdjacentTriangles` | `Void` | `Surface sfc, StructureLine sl, List<Int32> indices` | `` |
| `SelectInside` | `Void` | `Surface sfc, StructureLine sl, List<Int32> indices` | `` |
| `SelectSectTriangles` | `Void` | `Surface sfc, StructureLine sl, List<Int32> indices` | `` |
| `TrianglesToPatch` | `Void` | `Surface sfc, List<Int32> indices, Int32 patchId` | `` |
| `Trim` | `Void` | `List<Vector3D> poly, Double sta1, Double sta2, List<Vector3D> result` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EPS` | `Double` | Yes | `1E-06` | `` |
| `EPSSQR` | `Double` | Yes | `1E-12` | `` |

---
## Namespace: `Topomatic.Sites.Design`

### `SiteLineCurrentVertexIndexEditor` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Design.SiteLineCurrentVertexIndexEditor` |
| **Base Type** | `Topomatic.ComponentModel.PropertyEditor` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyEditor`
    - `Topomatic.Sites.Design.SiteLineCurrentVertexIndexEditor`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `EditValue` | `Object` | `IPropertyTypeDescriptorContext context, IPropertyWindowsFormsEditorService editorService, Int32 button` | `` |
| `GetCustomButtons` | `Image[]` | `IPropertyTypeDescriptorContext context, Int32 size` | `` |
| `GetEditStyle` | `PropertyTypeEditorEditStyle` | `IPropertyTypeDescriptorContext context` | `` |

### `SiteStationConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.Design.SiteStationConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Sites.Design.SiteStationConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanConvertFromString` | `Boolean` | `Type sourceType` | `` |
| `CanConvertToString` | `Boolean` | `Type sourceType` | `` |
| `ConvertFromString` | `Object` | `String value` | `` |
| `ConvertToString` | `String` | `Object value` | `` |

---
## Namespace: `Topomatic.Sites.SiteObjects`

### `ElevationPoint` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteEntityPatch+ElevationPoint` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sites.SiteObjects.SiteEntityPatch+ElevationPoint`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `ElevationPoint` | `StgNode node` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Elevation` | `Double` | No | `` | `` |
| `Station` | `Double` | No | `` | `` |

### `EntitySegment` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteEntityPatch+EntitySegment` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Sites.SiteObjects.SiteEntityPatch+EntitySegment`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `EntitySegment` | `StgNode node` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `EntityUid` | `UInt32` | No | `` | `` |
| `FromFirst` | `Boolean` | No | `` | `` |
| `FromUid` | `UInt32` | No | `` | `` |
| `ToFirst` | `Boolean` | No | `` | `` |
| `ToUid` | `UInt32` | No | `` | `` |

### `PavementLayer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.PavementLayer` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Code` | `Int32` | `get/set` | No | `` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Depth` | `Double` | `get/set` | No | `` |
| `Grade` | `Double` | `get/set` | No | `` |
| `Holder` | `SemanticDataHolder` | `get` | No | `` |
| `Offset` | `Double` | `get/set` | No | `` |
| `Semantic` | `SemanticDataSet` | `get` | No | `` |
| `Slope` | `Double` | `get/set` | No | `` |

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

### `PavementLayers` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.PavementLayers` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.PavementLayers`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `PavementLayer` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `PavementLayer layer` | `` |
| `Clear` | `Void` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `SiteBerm` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteBerm` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Sites.SiteObjects.SiteObject, Topomatic.Sites, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteBerm`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (15)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Angle` | `Double` | `get/set` | No | `Angle` |
| `BaseLine` | `String` | `get/set` | No | `Browsable` |
| `Elevation` | `Double` | `get/set` | No | `Elevation` |
| `Grade` | `Double` | `get/set` | No | `Browsable` |
| `Length` | `Double` | `get/set` | No | `Browsable` |
| `Length2` | `Double` | `get/set` | No | `Browsable` |
| `Line` | `String` | `get` | No | `Browsable` |
| `Polygon` | `String` | `get` | No | `Browsable` |
| `Position` | `Vector2D` | `get/set` | No | `Vector` |
| `Slope` | `SiteSlope` | `get` | No | `Browsable` |
| `SlopeStrengthening` | `SitePavement` | `get` | No | `Browsable` |
| `Strengthening` | `SitePavement` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `Browsable` |
| `Width` | `Double` | `get/set` | No | `Browsable` |
| `Wrapper` | `UpdatableTypedObjectWrapper` | `get` | No | `WrappedTypedObjectProvider, TypedObjectPropertiesExclude` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `ClearTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `CreateBrep` | `Shell[]` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetEnumerator` | `IEnumerator<SiteObject>` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SiteBorder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteBorder` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteBorder`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (12)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomOffset` | `SiteOffset` | `get` | No | `Browsable` |
| `CanSplit` | `Boolean` | `get` | No | `` |
| `End` | `Double` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, ConditionalReadOnly` |
| `Outter` | `SiteOffset` | `get` | No | `Browsable` |
| `OutterRise` | `Double` | `get/set` | No | `Length` |
| `Rise` | `Double` | `get/set` | No | `Length` |
| `Side` | `Side` | `get/set` | No | `` |
| `Start` | `Double` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyEditor` |
| `TopOffset` | `SiteOffset` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `` |
| `WholeLine` | `Boolean` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `Length` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `Split` | `SiteObject` | `Double sta` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteBuilding` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteBuilding` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Sites.SiteObjects.SiteObject, Topomatic.Sites, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteBuilding`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BlindOffset` | `SiteOffset` | `get` | No | `Browsable` |
| `DeltaElevation` | `Double` | `get/set` | No | `Elevation` |
| `Elevation` | `Double` | `get/set` | No | `Elevation` |
| `Line` | `String` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetEnumerator` | `IEnumerator<SiteObject>` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SiteDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteDitch` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Sites.SiteObjects.SiteObject, Topomatic.Sites, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteDitch`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLine` | `String` | `get/set` | No | `PropertyEditor, PropertyTypeConverter` |
| `CanSplit` | `Boolean` | `get` | No | `` |
| `End` | `Double` | `get/set` | No | `ConditionalReadOnly, PropertyEditor, PropertyTypeConverter` |
| `LeftBottom` | `SiteOffset` | `get` | No | `Browsable` |
| `LeftSlope` | `SiteSlope` | `get` | No | `Browsable` |
| `Line` | `String` | `get` | No | `Browsable` |
| `RightBottom` | `SiteOffset` | `get` | No | `Browsable` |
| `RightSlope` | `SiteSlope` | `get` | No | `Browsable` |
| `Start` | `Double` | `get/set` | No | `PropertyEditor, ConditionalReadOnly, PropertyTypeConverter` |
| `TypeName` | `String` | `get` | No | `` |
| `WholeLine` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetEnumerator` | `IEnumerator<SiteObject>` | `` | `` |
| `Split` | `SiteObject` | `Double sta` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SiteEntityPatch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteEntityPatch` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, Topomatic.Cad.Foundation.IPolyline2DCurveContainer` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteEntityPatch`

#### Constructors (2)

- `.ctor(Object owner)`
- `.ctor(Object owner, IEnumerable<EntitySegment> segments, Boolean closed)`

#### Properties (11)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get/set` | No | `` |
| `Code` | `Int32` | `get/set` | No | `PropertyTypeConverter, PropertyEditor, PropertyUpdateSequence` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Elevations` | `IList<ElevationPoint>` | `get` | No | `Browsable` |
| `Holder` | `SemanticDataHolder` | `get` | No | `Browsable` |
| `Patch` | `String` | `get` | No | `Browsable` |
| `Polygon` | `String` | `get` | No | `Browsable` |
| `Semantic` | `SemanticDataSet` | `get` | No | `PropertyUpdateSequence` |
| `TypeName` | `String` | `get` | No | `` |
| `Valid` | `Boolean` | `get` | No | `` |
| `Values` | `IList<EntitySegment>` | `get` | No | `Browsable` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetPolyline` | `Polyline2DCurve` | `` | `Browsable` |
| `GetProfile` | `Profile` | `` | `Browsable` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Nested Types (2)

- `ElevationPoint` (struct)
- `EntitySegment` (struct)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IPolyline2DCurveContainer` | `GetPolyline` |

### `SiteFill` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteFill` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteFill`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `TypeName` | `String` | `get` | No | `Browsable` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteGround` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteGround` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteGround`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePoint` | `Vector3D` | `get/set` | No | `Browsable` |
| `Direction` | `Vector2D` | `get/set` | No | `Browsable` |
| `Elevation1` | `Double` | `get/set` | No | `Elevation, PropertyUpdateSequence` |
| `Elevation2` | `Double` | `get/set` | No | `Elevation` |
| `Grade` | `Double` | `get/set` | No | `Grade` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetElevation` | `Double` | `Vector2D pos` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteLine` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteLine` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.BugleVector3D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Sites.IVertexNumerator3D, System.Collections.ICollection` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteLine`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (14)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Closed` | `Boolean` | `get/set` | No | `Browsable` |
| `Count` | `Int32` | `get` | No | `Browsable` |
| `CurrentBulge` | `Double` | `get/set` | No | `Browsable` |
| `CurrentStation` | `Double` | `get` | No | `Browsable, PropertyTypeConverter` |
| `CurrentVertex` | `Vector3D` | `get/set` | No | `Browsable` |
| `CurrentVertexIndex` | `Int32` | `get/set` | No | `Browsable, PropertyUpdateSequence, PropertyEditor` |
| `IsReadOnly` | `Boolean` | `get` | No | `Browsable` |
| `Item` | `BugleVector3D` | `get/set` | No | `Browsable` |
| `Length2D` | `Double` | `get` | No | `Browsable, Length` |
| `MaxElevation` | `Double` | `get` | No | `Elevation, Browsable` |
| `MinElevation` | `Double` | `get` | No | `Browsable, Elevation` |
| `StationLength` | `Double` | `get` | No | `Browsable` |
| `Stations` | `IEnumerable<Double>` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `Browsable` |

#### Instance Methods (19)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `BugleVector3D vertex` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `BugleVector3D item` | `` |
| `CopyTo` | `Void` | `BugleVector3D[] array, Int32 arrayIndex` | `` |
| `GetEnumerator` | `IEnumerator<BugleVector3D>` | `` | `` |
| `GetPos` | `Boolean` | `Double sta, ref Vector3D pos` | `` |
| `GetProfile` | `IList<Vector2D>` | `` | `` |
| `GetStation` | `Double` | `Int32 index` | `` |
| `GetTangent` | `Boolean` | `Double sta, ref Vector3D tangent` | `` |
| `IndexOf` | `Int32` | `BugleVector3D item` | `` |
| `Insert` | `Void` | `Int32 index, BugleVector3D item` | `` |
| `IsPosInside` | `Boolean` | `Vector2D pos` | `` |
| `Remove` | `Boolean` | `BugleVector3D item` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |
| `StationToString` | `String` | `Double station` | `` |
| `StringToStation` | `Double` | `String value` | `` |
| `ToPolyline2D` | `IList<Vector2D>` | `` | `` |
| `ToPolyline3D` | `IPolyline3D` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

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
| `IVertexNumerator3D` | `Topomatic.Sites.IVertexNumerator3D.get_CurrentVertex` |
| `ICollection` | `System.Collections.ICollection.CopyTo` |
| `ICollection` | `System.Collections.ICollection.get_Count` |
| `ICollection` | `System.Collections.ICollection.get_SyncRoot` |
| `ICollection` | `System.Collections.ICollection.get_IsSynchronized` |

### `SiteObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanSplit` | `Boolean` | `get` | No | `Browsable` |
| `EgSurfaces` | `IEnumerable<Surface>` | `get` | No | `Browsable` |
| `Layer` | `ILayer` | `get/set` | No | `Browsable` |
| `Name` | `String` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `Browsable` |
| `Site` | `Site` | `get` | No | `Browsable` |
| `Surface` | `Surface` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `Browsable` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `ClearTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary arg` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Split` | `SiteObject` | `Double sta` | `` |

#### Fields (6)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `AdditionalStructureLineLayerName` | `String` | Yes | `` | `` |
| `ModifiersLayerName` | `String` | Yes | `` | `` |
| `PatchLayerName` | `String` | Yes | `` | `` |
| `SlopeLayerName` | `String` | Yes | `` | `` |
| `StructureLineLayerName` | `String` | Yes | `` | `` |
| `VolumesLayerName` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ILayeredObject` | `get_Layer` |
| `ILayeredObject` | `set_Layer` |

### `SiteObjectCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteObjectCollection` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteObjectCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Item` | `SiteObject` | `get` | No | `` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `SiteObject obj` | `` |
| `Clear` | `Void` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `IndexOf` | `Int32` | `SiteObject obj` | `` |
| `Insert` | `Void` | `Int32 index, SiteObject obj` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteOffset` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteOffset` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteOffset`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanSplit` | `Boolean` | `get` | No | `` |
| `End` | `Double` | `get/set` | No | `PropertyTypeConverter, PropertyEditor, ConditionalReadOnly` |
| `Grade` | `Double` | `get/set` | No | `Grade` |
| `OffsetLine` | `String` | `get` | No | `Browsable` |
| `Polygon` | `String` | `get` | No | `Browsable` |
| `Side` | `Side` | `get/set` | No | `` |
| `Start` | `Double` | `get/set` | No | `PropertyEditor, ConditionalReadOnly, PropertyTypeConverter` |
| `TypeName` | `String` | `get` | No | `` |
| `WholeLine` | `Boolean` | `get/set` | No | `` |
| `Width` | `Double` | `get/set` | No | `Length` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `Split` | `SiteObject` | `Double sta` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SitePavement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SitePavement` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SitePavement`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BasePatch` | `String` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Layers` | `PavementLayers` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary arg` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteSimpleObject` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BaseLine` | `String` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Code` | `Int32` | `get/set` | No | `PropertyEditor, PropertyTypeConverter, PropertyUpdateSequence` |
| `Color` | `CadColor` | `get/set` | No | `` |
| `Holder` | `SemanticDataHolder` | `get` | No | `Browsable` |
| `IsNoHorizontals` | `Boolean` | `get/set` | No | `` |
| `IsNoInclinations` | `Boolean` | `get/set` | No | `` |
| `IsNoRibs` | `Boolean` | `get/set` | No | `` |
| `Patch` | `String` | `get` | No | `Browsable` |
| `Semantic` | `SemanticDataSet` | `get` | No | `PropertyUpdateSequence` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `SiteObject` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteSlope` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteSlope` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteSlope`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (13)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `BottomLine` | `String` | `get` | No | `Browsable` |
| `ByProfile` | `Boolean` | `get/set` | No | `` |
| `CanSplit` | `Boolean` | `get` | No | `` |
| `ClipByEg` | `Boolean` | `get/set` | No | `` |
| `End` | `Double` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyEditor` |
| `Height` | `Double` | `get/set` | No | `Length` |
| `Profile` | `Profile` | `get/set` | No | `PropertyTypeConverter, PropertyEditor` |
| `Side` | `Side` | `get/set` | No | `` |
| `Start` | `Double` | `get/set` | No | `PropertyTypeConverter, ConditionalReadOnly, PropertyEditor` |
| `Type` | `SlopeType` | `get/set` | No | `` |
| `TypeName` | `String` | `get` | No | `Browsable` |
| `Value` | `Double` | `get/set` | No | `Length` |
| `WholeLine` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `Clone` | `SiteObject` | `` | `` |
| `CreateBrep` | `Shell` | `` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `Split` | `SiteObject` | `Double sta` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ADJACENT` | `Int32` | Yes | `3` | `` |
| `BOTTOM` | `Int32` | Yes | `2` | `` |
| `TOP` | `Int32` | Yes | `0` | `` |
| `TYPE_NAME` | `String` | Yes | `` | `` |
| `VERTICAL` | `Int32` | Yes | `1` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SiteSlopeDitch` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteSlopeDitch` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject, System.Collections.Generic.IEnumerable`1[[Topomatic.Sites.SiteObjects.SiteObject, Topomatic.Sites, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSlopeDitch`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bottom` | `SiteOffset` | `get` | No | `Browsable` |
| `CutSlope` | `SiteSlope` | `get` | No | `Browsable` |
| `FillSlope` | `SiteSlope` | `get` | No | `Browsable` |
| `TypeName` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary args` | `` |
| `GetEnumerator` | `IEnumerator<SiteObject>` | `` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `SiteTray` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SiteTray` |
| **Base Type** | `Topomatic.Sites.SiteObjects.SiteSimpleObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.ILayeredObject` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Sites.SiteObjects.SiteObject`
      - `Topomatic.Sites.SiteObjects.SiteSimpleObject`
        - `Topomatic.Sites.SiteObjects.SiteTray`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Height` | `Double` | `get/set` | No | `Length` |
| `Thickness` | `Double` | `get/set` | No | `Length` |
| `TypeName` | `String` | `get` | No | `` |
| `Width` | `Double` | `get/set` | No | `Length` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ClearPointAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreatePointsAndLines` | `Void` | `DynamicDictionary args` | `` |
| `CreateTrianglesAndPatches` | `Void` | `DynamicDictionary arg` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `TYPE_NAME` | `String` | Yes | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `SlopeType` (enum)

**Attributes**: [PropertyTypeConverter]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Sites.SiteObjects.SlopeType` |
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
      - `Topomatic.Sites.SiteObjects.SlopeType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Auto` | `SlopeType` | Yes | `Auto` | `` |
| `Cut` | `SlopeType` | Yes | `Cut` | `` |
| `Fill` | `SlopeType` | Yes | `Fill` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Auto` | `0` |
| `Fill` | `1` |
| `Cut` | `2` |

**Underlying Type**: `System.Int32`

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 31 |
| **Classes** | 21 |
| **Interfaces** | 2 |
| **Enums** | 2 |
| **Structs** | 3 |
| **Abstract Classes** | 2 |
| **Static Classes** | 1 |
| **Total Methods** | 168 |
| **Total Properties** | 152 |
| **Total Fields** | 43 |
| **Total Events** | 4 |
| **Total Constructors** | 26 |
| **Nested Types** | 3 |
| **Extension Methods** | 0 |


