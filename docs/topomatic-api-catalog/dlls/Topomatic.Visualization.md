# Topomatic.Visualization

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Visualization` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Visualization.dll` |

---
## Namespace: `Topomatic.Robur.UserSettings`

### `SmdxCustomSettings` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Robur.UserSettings.SmdxCustomSettings` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

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

---
## Namespace: `Topomatic.Visualization`

### `Animation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+Animation` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Direction` | `VectorTrack<DirectionInterpolatedValue>` | `get` | No | `` |
| `Normal` | `VectorTrack<DirectionInterpolatedValue>` | `get` | No | `` |
| `Position` | `VectorTrack<PositionInterpolatedValue>` | `get` | No | `` |
| `Scale` | `VectorTrack<PositionInterpolatedValue>` | `get` | No | `` |

### `Assembly3d` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (4)

- `.ctor(Stream stream)`
- `.ctor(String fullpath)`
- `.ctor(ImTypeDescriptor type)`
- `.ctor(ImTypeDescriptor type, Matrix transform)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Items` | `IList<ConstructionReference>` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `` |
| `Models` | `IDictionary<String IConstructionModel>` | `get` | No | `` |
| `Ox` | `Nullable<Vector3D>` | `get/set` | No | `` |
| `Oy` | `Nullable<Vector3D>` | `get/set` | No | `` |
| `Position` | `AssemblyPosition` | `get/set` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateElement` | `ImElement` | `` | `` |
| `GenerateName` | `String` | `String name` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateMatrix` | `Matrix` | `Vector3D position, Vector3D ox, Vector3D oy` | `` |

#### Nested Types (5)

- `AssemblyPosition` (struct)
- `ConstructionReference` (class)
- `GeneratedConstructionModel` (class)
- `IConstructionModel` (interface)
- `LibraryConstructionModel` (class)

### `AssemblyPosition` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d+AssemblyPosition` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.Assembly3d+AssemblyPosition`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Vector` | `Vector3D` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `X` | `Nullable<Double>` | No | `` | `` |
| `Y` | `Nullable<Double>` | No | `` | `` |
| `Z` | `Nullable<Double>` | No | `` | `` |

### `BlobGeometryModelsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.BlobGeometryModelsCache` |
| **Base Type** | `Topomatic.Visualization.GeometryModelsCache` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Visualization.BlobGeometryModelsCache, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Cad.Foundation.Matrix, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryModelsCache`
    - `Topomatic.Visualization.BlobGeometryModelsCache`

#### Constructors (2)

- `.ctor(GeometryModel3D[] models, Matrix[] matrices, Vector3D pivot)`
- `.ctor(GeometryModel3D model, Matrix matrix, Vector3D pivot)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CastRay` | `Nullable<Vector3D>` | `Ray3D ray, ref Triangle3D triangle` | `` |
| `ConvertToModel` | `Void` | `GeometryModel3D model` | `` |
| `Dispose` | `Void` | `` | `` |
| `EnsureTree` | `Void` | `` | `` |
| `IntersectEdges` | `Void` | `Plane plane, Action<Vector3D Vector3D> callback` | `` |
| `IntersectTrianglesPlane` | `Void` | `Plane plane, Action<Vector3D Vector3D Vector3D PhongMaterial> callback` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `CacheType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry3dCache+CacheType` |
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
      - `Topomatic.Visualization.Geometry3dCache+CacheType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Fill` | `CacheType` | Yes | `Fill` | `` |
| `value__` | `Int32` | No | `` | `` |
| `Wire` | `CacheType` | Yes | `Wire` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Wire` | `0` |
| `Fill` | `1` |

**Underlying Type**: `System.Int32`

### `ComponentCountType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ComponentCountType` |
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
      - `Topomatic.Visualization.ComponentCountType`

#### Fields (10)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `ExactKit` | `ComponentCountType` | Yes | `ExactKit` | `` |
| `ExactPsc` | `ComponentCountType` | Yes | `ExactPsc` | `` |
| `ExactPscPerMeter` | `ComponentCountType` | Yes | `ExactPscPerMeter` | `` |
| `LengthM` | `ComponentCountType` | Yes | `LengthM` | `` |
| `SqareM2` | `ComponentCountType` | Yes | `SqareM2` | `` |
| `value__` | `Int32` | No | `` | `` |
| `VolumeLiter` | `ComponentCountType` | Yes | `VolumeLiter` | `` |
| `VolumeM3` | `ComponentCountType` | Yes | `VolumeM3` | `` |
| `WeightKg` | `ComponentCountType` | Yes | `WeightKg` | `` |
| `WeightTon` | `ComponentCountType` | Yes | `WeightTon` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `ExactPsc` | `0` |
| `ExactPscPerMeter` | `1` |
| `WeightKg` | `2` |
| `ExactKit` | `3` |
| `VolumeM3` | `4` |
| `VolumeLiter` | `5` |
| `WeightTon` | `6` |
| `SqareM2` | `7` |
| `LengthM` | `8` |

**Underlying Type**: `System.Int32`

### `ComponentCountTypeEnumConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ComponentCountTypeEnumConverter` |
| **Base Type** | `Topomatic.ComponentModel.BaseEnumConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.ComponentModel.BaseEnumConverter`
      - `Topomatic.Visualization.ComponentCountTypeEnumConverter`

#### Constructors (1)

- `.ctor()` - **Default constructor**

### `Compound3DElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Compound3DElement` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.Compound3DElement`

#### Constructors (2)

- `.ctor(String name, ImTypeDescriptor type, ImProperties properties, ImDocuments documents)`
- `.ctor(String name, String typeId, ImProperties properties, ImDocuments documents)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Count` | `Int32` | `get` | No | `` |
| `Flags` | `Model3DElementFlags` | `get` | No | `` |
| `MergeGroups` | `Boolean` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (13)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `String name, ImElement element, Vector3D position, Vector3D ox, Vector3D oy, Vector3D scale, ImProperties properties, ImDocuments documents` | `` |
| `Add` | `Void` | `String name, ImElement element, Vector3D position` | `` |
| `Add` | `Void` | `String name, ImElement element, Vector3D position, Vector3D ox, Vector3D oy` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetReferences` | `IEnumerable<IImElementReference>` | `` | `` |
| `SetModel` | `Void` | `GeometryModel3D model` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `CompoundModelsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.CompoundModelsCache` |
| **Base Type** | `Topomatic.Visualization.GeometryModelsCache` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Visualization.BlobGeometryModelsCache, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Cad.Foundation.Matrix, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryModelsCache`
    - `Topomatic.Visualization.CompoundModelsCache`

#### Constructors (1)

- `.ctor(GeometryModelsCache[] caches)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |
| `Caches` | `GeometryModelsCache[]` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CastRay` | `Nullable<Vector3D>` | `Ray3D ray, ref Triangle3D triangle` | `` |
| `Dispose` | `Void` | `` | `` |
| `IntersectEdges` | `Void` | `Plane plane, Action<Vector3D Vector3D> callback` | `` |
| `IntersectTrianglesPlane` | `Void` | `Plane plane, Action<Vector3D Vector3D Vector3D PhongMaterial> callback` | `` |
| `Paint` | `Void` | `DeviceContext dc` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `ConstructionReference` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d+ConstructionReference` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Matrix transform)`

#### Properties (9)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Description` | `String` | `get/set` | No | `` |
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Items` | `IList<ConstructionReference>` | `get` | No | `` |
| `Matrix` | `Matrix` | `get` | No | `` |
| `Model` | `String` | `get/set` | No | `` |
| `Ox` | `Vector3D` | `get/set` | No | `` |
| `Oy` | `Vector3D` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

### `DefaultTransactableTypedObjectWrapper`1<T where ITransactable, IUpdatable, class, ITransactable>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.DefaultTransactableTypedObjectWrapper`1` |
| **Base Type** | `Topomatic.Visualization.TransactableTypedObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`
      - `Topomatic.Visualization.DefaultTransactableTypedObjectWrapper`1`

#### Constructors (1)

- `.ctor(T owner, Func<T TypedObject> getObject)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `DirectionInterpolatedValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+DirectionInterpolatedValue` |
| **Base Type** | `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue`
    - `Topomatic.Visualization.GeometryInsertionAnimation+DirectionInterpolatedValue`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vector3F p)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `InterpolatedValue other, InterpolatedValue eps` | `` |
| `Interpolate` | `InterpolatedValue` | `InterpolatedValue other, Single amount` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value` | `Vector3F` | No | `` | `` |

### `Frame` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera+Frame` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Int32 time, Double value)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Time` | `Int32` | No | `` | `` |
| `Value` | `Double` | No | `` | `` |

### `GeneratedConstructionModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d+GeneratedConstructionModel` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.Assembly3d+IConstructionModel` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(GeometryModel3D model, String typeId, ImProperties properties, IEnumerable<ImDocument> documents)`
- `.ctor(GeometryModel3D model, ImTypeDescriptor type, ImProperties properties, IEnumerable<ImDocument> documents)`

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Model` | `GeometryModel3D` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IConstructionModel` | `get_Model` |
| `IConstructionModel` | `get_Type` |
| `IConstructionModel` | `get_Properties` |
| `IConstructionModel` | `get_Documents` |

### `Geometry3dCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry3dCache` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(GeometryModel3D model, Matrix matrix, CacheType cacheType)`
- `.ctor(GeometryModel3D model, Matrix matrix, CacheType cacheType, Vector3F look)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `DeviceContext dc` | `` |

#### Nested Types (1)

- `CacheType` (enum)

### `GeometryCamera` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Informations` | `List<TrackInformation>` | `get` | No | `` |
| `Positions` | `List<RelativePosition>` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (5)

- `Frame` (class)
- `InterpolationType` (enum)
- `RelativePosition` (class)
- `Track` (class)
- `TrackInformation` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeometryInsertion` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertion` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Group` | `VisualizationGroup` | `get/set` | No | `` |
| `Handle` | `UInt32` | `get` | No | `` |
| `Mesh` | `String` | `get/set` | No | `` |
| `Ox` | `Vector3F` | `get` | No | `` |
| `Oy` | `Vector3F` | `get` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Rotation` | `Vector3F` | `get/set` | No | `Obsolete` |
| `Scale` | `Vector3F` | `get/set` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetRotationMatrix` | `Matrix` | `` | `` |
| `GetWorldMatrix` | `Matrix` | `` | `` |
| `LoadRotation` | `Void` | `StgNode node` | `` |
| `Rotate` | `Void` | `Matrix matrix` | `` |
| `Rotate` | `Void` | `Vector3D ox, Vector3D oy` | `` |
| `SaveRotation` | `Void` | `StgNode node` | `` |

### `GeometryInsertionAnimation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.GeometryInsertionAnimation+Animation, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.GeometryInsertionAnimation`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode stgnode` | `` |
| `SaveToStg` | `Void` | `StgNode stgnode, Vector3F insOx, Vector3F insOy` | `` |
| `SaveToStg` | `Void` | `StgNode stgnode` | `` |

#### Nested Types (9)

- `Animation` (class)
- `DirectionInterpolatedValue` (class)
- `InterpolatedValue` (abstract class)
- `Interpolation` (enum)
- `PositionInterpolatedValue` (class)
- `SingleInterpolatedValue` (class)
- `SplineBoundaryCondition` (enum)
- `VectorFrame`1` (struct)
- `VectorTrack`1` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `GeometryModel3DFormatProvider` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryModel3DFormatProvider` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanSave` | `Boolean` | `get` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStream` | `ImElement` | `Stream stream, ref Vector3D origin` | `` |
| `SaveToStream` | `Void` | `ImElement model, Stream stream` | `` |

### `GeometryModel3DUtils` (static class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryModel3DUtils` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateModel3DView` | `Void` | `DwgBlock block, GeometryModel3D model, Model3DView view, Model3DCutting cutting, Model3DViewOptions options` | `` |
| `CreateModel3DViewMaterial` | `Void` | `DwgBlock block, GeometryModel3D model, Model3DView view, Model3DCutting cutting, Model3DViewOptions options, String material` | `` |

### `GeometryModelsCache` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryModelsCache` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Visualization.BlobGeometryModelsCache, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Cad.Foundation.Matrix, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CastRay` | `Nullable<Vector3D>` | `Ray3D ray, ref Triangle3D triangle` | `` |
| `Dispose` | `Void` | `` | `` |
| `Fire` | `Nullable<Double>` | `Ray3D ray` | `` |
| `GetEnumerator` | `IEnumerator<KeyValuePair<BlobGeometryModelsCache Matrix>>` | `` | `` |
| `IntersectEdges` | `Void` | `Plane plane, Action<Vector3D Vector3D> callback` | `` |
| `IntersectTriangles` | `Void` | `Plane plane, Action<Vector3D Vector3D Vector3D> callback` | `` |
| `IntersectTrianglesPlane` | `Void` | `Plane plane, Action<Vector3D Vector3D Vector3D PhongMaterial> callback` | `` |
| `Paint` | `Void` | `DeviceContext dc` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Paint` | `Void` | `DeviceContext dc, IEnumerable<GeometryModelsCache> caches` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `GeometryModelsCacheBuilder` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryModelsCacheBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Vector3D pivot)`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Create` | `GeometryModelsCache` | `ImElement element, Matrix matrix` | `` |
| `Create` | `GeometryModelsCache` | `ImElement[] elements, Matrix[] matrices` | `` |

### `Guid3DElement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Guid3DElement` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.Guid3DElement`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Guid` | `Guid` | `get/set` | No | `` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `IConstructionModel` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d+IConstructionModel` |
| **Base Type** | `none` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Model` | `GeometryModel3D` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get` | No | `` |

### `ImElementHolder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementHolder` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Cache` | `GeometryModelsCache` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |

### `ImElementWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImElementWrapper` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |
| `Flags` | `Model3DElementFlags` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetReferences` | `IEnumerable<IImElementReference>` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImObjectPropertyProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImObjectPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.ImObjectPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (6)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowEmpty` | `Boolean` | `get/set` | No | `` |
| `Category` | `String` | `get/set` | No | `` |
| `DisplayProperties` | `Boolean` | `get/set` | No | `` |
| `Identifier` | `String` | `get/set` | No | `` |
| `InstanceDependence` | `Boolean` | `get` | No | `` |
| `SmdxType` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

#### Static Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `SelectObject` | `TypedObject` | `String parentType, Predicate<TypedObject> selected, Predicate<TypedObject> filter` | `` |
| `SelectObject` | `TypedObject` | `String parentType, Predicate<TypedObject> selected, Predicate<TypedObject> filter, ref String uid` | `` |
| `SelectObject` | `TypedObject` | `String parentType` | `` |
| `SelectObject` | `TypedObject` | `String parentType, TypedObject selected` | `` |

### `ImObjectPropertyProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImObjectPropertyProviderAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Visualization.ImObjectPropertyProviderAttribute`

#### Constructors (7)

- `.ctor()` - **Default constructor**
- `.ctor(String smdxcls)`
- `.ctor(String smdxcls, String identifier)`
- `.ctor(String smdxcls, Boolean displayProperties)`
- `.ctor(String smdxcls, String identifier, Boolean allowEmpty)`
- `.ctor(String smdxcls, Boolean displayProperties, Boolean allowEmpty)`
- `.ctor(String smdxcls, String category, String identifier, Boolean allowEmpty)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImViewElement` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImViewElement` |
| **Base Type** | `Topomatic.Visualization.ImElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetLimits` | `Boolean` | `Model3DView view, Matrix transform, ref BoundingBox2D limits, Double mapscale` | `` |
| `GetStaticViewDocumentName` | `String` | `Model3DView view, Model3DCutting cutting` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `ImViewElementExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ImViewElementExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (7)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CopyModel3D` | `Void` | `Object source, Object dest, Guid id` | `` |
| `Find3DModel` | `ImElement` | `Object obj, Guid id` | `` |
| `FindCollection` | `ImElementCollection` | `Object obj` | `` |
| `GetCachedValue` | `T` | `ImDocument doc, Func<Byte[] T> load` | `` |
| `GetDrawing` | `Drawing` | `ImDocument doc, Boolean grayscale` | `Extension` |
| `GetDrawing` | `Drawing` | `ImDocument doc` | `Extension` |
| `Synchronize` | `Void` | `Object obj, Guid id` | `` |

### `InstancingModelsCache` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.InstancingModelsCache` |
| **Base Type** | `Topomatic.Visualization.GeometryModelsCache` |
| **Implements** | `System.IDisposable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[Topomatic.Visualization.BlobGeometryModelsCache, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327],[Topomatic.Cad.Foundation.Matrix, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryModelsCache`
    - `Topomatic.Visualization.InstancingModelsCache`

#### Constructors (2)

- `.ctor(BlobGeometryModelsCache blob, Matrix[] matrices, Vector3D pivot)`
- `.ctor(GeometryModel3D model, Matrix[] matrices, Vector3D pivot)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get` | No | `` |

#### Instance Methods (4)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CastRay` | `Nullable<Vector3D>` | `Ray3D ray, ref Triangle3D triangle` | `` |
| `Dispose` | `Void` | `` | `` |
| `IntersectEdges` | `Void` | `Plane plane, Action<Vector3D Vector3D> callback` | `` |
| `IntersectTrianglesPlane` | `Void` | `Plane plane, Action<Vector3D Vector3D Vector3D PhongMaterial> callback` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `InterpolatedValue` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `InterpolatedValue other, InterpolatedValue eps` | `` |
| `Interpolate` | `InterpolatedValue` | `InterpolatedValue other, Single amount` | `` |

### `Interpolation` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+Interpolation` |
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
      - `Topomatic.Visualization.GeometryInsertionAnimation+Interpolation`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Discret` | `Interpolation` | Yes | `Discret` | `` |
| `Linear` | `Interpolation` | Yes | `Linear` | `` |
| `Spline` | `Interpolation` | Yes | `Spline` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Spline` | `0` |
| `Linear` | `1` |
| `Discret` | `2` |

**Underlying Type**: `System.Int32`

### `InterpolationType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera+InterpolationType` |
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
      - `Topomatic.Visualization.GeometryCamera+InterpolationType`

#### Fields (3)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Discret` | `InterpolationType` | Yes | `Discret` | `` |
| `Linear` | `InterpolationType` | Yes | `Linear` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Linear` | `0` |
| `Discret` | `1` |

**Underlying Type**: `System.Int32`

### `LibraryConstructionModel` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Assembly3d+LibraryConstructionModel` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.Assembly3d+IConstructionModel` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(ImElement element)`

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Documents` | `ImDocuments` | `get` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `Model` | `GeometryModel3D` | `get` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IConstructionModel` | `get_Model` |
| `IConstructionModel` | `get_Type` |
| `IConstructionModel` | `get_Properties` |
| `IConstructionModel` | `get_Documents` |

### `LinearSolidBuilder` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.LinearSolidBuilder` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateSolid` | `GeometryModel3D` | `Double from, Double to, ref Vector3D pivot, ref Vector3D ox, ref ImProperties properties` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `BACK_SIDE` | `String` | Yes | `"bside"` | `` |
| `FRONT_SIDE` | `String` | Yes | `"fside"` | `` |

#### Nested Types (1)

- `VectorsList` (class)

### `MapxIncludeHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationMap+MapxIncludeHandler` |
| **Base Type** | `Topomatic.Visualization.Geometry.IncludeHandler` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Geometry.IncludeHandler`
    - `Topomatic.Visualization.VisualizationMap+MapxIncludeHandler`

#### Constructors (1)

- `.ctor(VisualizationMap map)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |

### `Model3DElementCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DElementCollection` |
| **Base Type** | `Topomatic.FoundationClasses.UpdatableObject` |
| **Implements** | `Topomatic.FoundationClasses.Undo.INamedTransactable, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IOwned, Topomatic.Stg.IStgSerializable, Topomatic.Visualization.ImElementCollection` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.FoundationClasses.UpdatableObject`
    - `Topomatic.Visualization.Model3DElementCollection`

#### Constructors (1)

- `.ctor(Object owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `ImElement` | `get/set` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `Synchronize` | `Void` | `Guid id` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ImElementCollection` | `get_Item` |
| `ImElementCollection` | `set_Item` |
| `ImElementCollection` | `Synchronize` |

### `Model3DElementNameValidator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DElementNameValidator` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String formatStr)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GenerateValidName` | `String` | `String name` | `` |

### `Model3DElementPropertyProviderAttibute` (class)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DElementPropertyProviderAttibute` |
| **Base Type** | `Topomatic.Visualization.ImObjectPropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Visualization.ImObjectPropertyProviderAttribute`
        - `Topomatic.Visualization.Model3DElementPropertyProviderAttibute`

#### Constructors (7)

- `.ctor()` - **Default constructor**
- `.ctor(String smdxcls)`
- `.ctor(String smdxcls, Boolean displayProperties)`
- `.ctor(String smdxcls, String identifier)`
- `.ctor(String smdxcls, Boolean displayProperties, Boolean allowEmpty)`
- `.ctor(String smdxcls, String identifier, Boolean allowEmpty)`
- `.ctor(String smdxcls, String category, String identifier, Boolean allowEmpty)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DLibraryItemGuidAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DLibraryItemGuidAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Visualization.Model3DLibraryItemGuidAttribute`

#### Constructors (4)

- `.ctor(String value)`
- `.ctor(String value, Boolean displayProperties)`
- `.ctor(String value, Boolean displayProperties, Boolean allowEmpty)`
- `.ctor(String tag, String value, Boolean displayProperties, Boolean allowEmpty)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Model3DLibraryItemGuidPropertyProvider` (class)

**Attributes**: [Obsolete]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Model3DLibraryItemGuidPropertyProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.Model3DLibraryItemGuidPropertyProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (5)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `AllowEmpty` | `Boolean` | `get/set` | No | `` |
| `DisplayProperties` | `Boolean` | `get/set` | No | `` |
| `InstanceDependence` | `Boolean` | `get` | No | `` |
| `Tag` | `String` | `get/set` | No | `` |
| `Value` | `String` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Find3DModel` | `ImElement` | `Guid guid` | `` |
| `Select3DModel` | `ImElement` | `ref Guid guid, Func<ImElement Boolean> filter` | `` |

### `ModelPropertyItem` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.ModelPropertyItem` |
| **Base Type** | `System.ValueType` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.ModelPropertyItem`

#### Constructors (1)

- `.ctor(ModelPropertyItem item)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |
| `ToString` | `String` | `` | `` |

#### Static Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Convert` | `ImProperties` | `IEnumerable<ModelPropertyItem> properties` | `` |
| `Convert` | `ModelPropertyItem` | `ImProperty property` | `Obsolete` |
| `ParseTag` | `List<String>` | `String tag` | `` |

#### Fields (7)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `COMPONENTS_TAG_TYPE` | `String` | Yes | `"components"` | `` |
| `INFO_TAG_TYPE` | `String` | Yes | `"info"` | `` |
| `LIBRARY_TAG_TYPE` | `String` | Yes | `"library"` | `` |
| `Name` | `String` | No | `` | `` |
| `Tag` | `String` | No | `` | `` |
| `Value` | `String` | No | `` | `` |
| `VALUES_TAG_TYPE` | `String` | Yes | `"combo"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `PlaneExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.PlaneExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clip` | `GeometryModel3D` | `IEnumerable<Plane> planes, GeometryModel3D source` | `` |
| `TrySectSegment` | `Boolean` | `Plane plane, Vector3D a, Vector3D b, ref Vector3D sect` | `Extension` |

### `PositionInterpolatedValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+PositionInterpolatedValue` |
| **Base Type** | `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue`
    - `Topomatic.Visualization.GeometryInsertionAnimation+PositionInterpolatedValue`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Vector3F p)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `InterpolatedValue other, InterpolatedValue eps` | `` |
| `Interpolate` | `InterpolatedValue` | `InterpolatedValue other, Single amount` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value` | `Vector3F` | No | `` | `` |

### `RelativePosition` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera+RelativePosition` |
| **Base Type** | `System.Object` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(UInt32 insertion, Vector3F position)`

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Insertion` | `UInt32` | No | `` | `` |
| `Position` | `Vector3F` | No | `` | `` |

### `SingleInterpolatedValue` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+SingleInterpolatedValue` |
| **Base Type** | `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.GeometryInsertionAnimation+InterpolatedValue`
    - `Topomatic.Visualization.GeometryInsertionAnimation+SingleInterpolatedValue`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(Single s)`

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `InterpolatedValue other, InterpolatedValue eps` | `` |
| `Interpolate` | `InterpolatedValue` | `InterpolatedValue other, Single amount` | `` |
| `ToString` | `String` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `value` | `Single` | No | `` | `` |

### `SplineBoundaryCondition` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+SplineBoundaryCondition` |
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
      - `Topomatic.Visualization.GeometryInsertionAnimation+SplineBoundaryCondition`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FirstDerivative` | `SplineBoundaryCondition` | Yes | `FirstDerivative` | `` |
| `Natural` | `SplineBoundaryCondition` | Yes | `Natural` | `` |
| `ParabolicallyTerminated` | `SplineBoundaryCondition` | Yes | `ParabolicallyTerminated` | `` |
| `SecondDerivative` | `SplineBoundaryCondition` | Yes | `SecondDerivative` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Natural` | `0` |
| `ParabolicallyTerminated` | `1` |
| `FirstDerivative` | `2` |
| `SecondDerivative` | `3` |

**Underlying Type**: `System.Int32`

### `Static3DElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Static3DElement` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.Static3DElement`

#### Constructors (4)

- `.ctor(GeometryModel3D model)`
- `.ctor(ImElement element)`
- `.ctor(String name, String typeId, ImProperties properties, GeometryModel3D model, ImDocuments documents)`
- `.ctor(String name, ImTypeDescriptor type, ImProperties properties, GeometryModel3D model, ImDocuments documents)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Name` | `String` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `SetMode` | `Void` | `GeometryModel3D model` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StaticSolidElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.StaticSolidElement` |
| **Base Type** | `Topomatic.Visualization.ImViewElement` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.StaticSolidElement`

#### Constructors (2)

- `.ctor(String name, ImTypeDescriptor type, ImProperties properties, Shell shell, ImDocuments documents)`
- `.ctor(String name, String typeId, ImProperties properties, Shell shell, ImDocuments documents)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Color` | `Color` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Origin` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetBrep` | `Shell` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetModel` | `GeometryModel3D` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `SetBrep` | `Void` | `Shell shell` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `StubTypedObjectWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.StubTypedObjectWrapper` |
| **Base Type** | `Topomatic.Visualization.UpdatableTypedObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.StubTypedObjectWrapper`

#### Constructors (1)

- `.ctor(TypedObject tobj)`

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `Track` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera+Track` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Visualization.GeometryCamera+Frame, Topomatic.Visualization, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.GeometryCamera+Track`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Digits` | `Int32` | `get/set` | No | `` |
| `Interpolation` | `InterpolationType` | `get/set` | No | `` |
| `RoundDistance` | `Double` | `get/set` | No | `` |
| `ShowEndZeroFeet` | `Boolean` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `IndexOfClosestPointLeftOf` | `Int32` | `Int32 t` | `` |
| `IndexOfClosestPointLeftOf` | `Int32` | `Double t` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `Optimize` | `Void` | `Int32 index, Double eps` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |

### `TrackInformation` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryCamera+TrackInformation` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Length` | `Int32` | `get/set` | No | `` |
| `Message` | `String` | `get/set` | No | `` |
| `Tracks` | `List<Track>` | `get` | No | `` |

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

### `TransactableTypedObjectWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TransactableTypedObjectWrapper` |
| **Base Type** | `Topomatic.Visualization.UpdatableTypedObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`

#### Constructors (1)

- `.ctor(ITransactable owner)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Owner` | `Object` | `get/set` | No | `` |
| `TransactionManager` | `ITransactionManager` | `get` | No | `` |

#### Events (3)

| Name | Handler Type | Static | Attributes |
|------|--------------|--------|------------|
| `Added` | `EventHandler<TypedObjectWrapperPropertyEventArgs>` | No | `` |
| `Changed` | `EventHandler<TypedObjectWrapperPropertyChangedEventArgs>` | No | `` |
| `Removed` | `EventHandler<TypedObjectWrapperPropertyEventArgs>` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITransactable` | `get_TransactionManager` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `TypedObjectCollections` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObjectCollections` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Visualization.ITypedObjectCollection, System.Collections.Generic.IEnumerable`1[[Topomatic.Visualization.ITypedObjectCollection, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `TypedObjectCollections` | `get` | Yes | `` |
| `LibraryUid` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindCollection` | `ITypedObjectCollection` | `String uid, ref String localUid` | `` |
| `FindObject` | `TypedObject` | `String uid` | `` |
| `FindPath` | `String` | `String uid` | `` |
| `FindUids` | `IEnumerable<String>` | `String parentType, Predicate<TypedObject> match` | `` |
| `GetEnumerator` | `IEnumerator<ITypedObjectCollection>` | `` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `REGISTER_COLLECTION_BROADCAST` | `String` | Yes | `"register_tobject_collection"` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITypedObjectCollection` | `FindUids` |
| `ITypedObjectCollection` | `FindObject` |
| `ITypedObjectCollection` | `FindPath` |
| `ITypedObjectCollection` | `get_LibraryUid` |
| `IEnumerable`1` | `GetEnumerator` |
| `IEnumerable` | `System.Collections.IEnumerable.GetEnumerator` |

### `TypedObjectExtentions` (static class)

**Attributes**: [Extension]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObjectExtentions` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Static Methods (37)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ChangeValue` | `Void` | `UpdatableTypedObjectWrapper obj, String tag, Object value` | `Extension` |
| `FillElevation` | `Void` | `IElevationProvider provider, Boolean designed, IList<StateElevationValue> values, Vector2D p` | `Extension` |
| `FillElevation` | `Void` | `IEnumerable<DwgEntity> entitys, IList<StateElevationValue> values, Vector2D p` | `Extension` |
| `Filter` | `IEnumerable<TypedObject>` | `String parentId, Predicate<TypedObject> match` | `` |
| `Filter` | `IEnumerable<TypedObject>` | `ITypedObjectCollection collection, String parentId, Predicate<TypedObject> match` | `Extension` |
| `FromAngularSI` | `Double` | `TypedObject obj, String tag, Double defaultValue` | `Extension` |
| `FromAngularSI` | `Double` | `UpdatableTypedObjectWrapper obj, String tag, Double defaultValue` | `Extension` |
| `FromAngularSI` | `Double` | `TypedObject obj, String tag` | `Extension` |
| `FromAngularSI` | `Double` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `FromLinearSI` | `Double` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `FromLinearSI` | `Double` | `UpdatableTypedObjectWrapper obj, String tag, Double defaultValue` | `Extension` |
| `FromLinearSI` | `Double` | `TypedObject obj, String tag, Double defaultValue` | `Extension` |
| `FromLinearSI` | `Double` | `TypedObject obj, String tag` | `Extension` |
| `GetAllDocument` | `ImDocument` | `TypedObject tobj, String name` | `Extension` |
| `GetAllDocuments` | `IEnumerable<String>` | `TypedObject tobj` | `Extension` |
| `GetAllProperties` | `ImProperties` | `UpdatableTypedObjectWrapper obj` | `Extension` |
| `GetAttribsProps` | `ImProperties` | `TypedObject obj, DwgBlock block` | `` |
| `GetBoolean` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `GetBoolean` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, Boolean def` | `Extension` |
| `GetDocument` | `ImDocument` | `UpdatableTypedObjectWrapper obj, String name` | `Extension` |
| `GetDocuments` | `IEnumerable<String>` | `UpdatableTypedObjectWrapper obj` | `Extension` |
| `GetDouble` | `Double` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `GetDouble` | `Double` | `UpdatableTypedObjectWrapper obj, String tag, Double def` | `Extension` |
| `GetInt` | `Int32` | `UpdatableTypedObjectWrapper obj, String tag, Int32 def` | `Extension` |
| `GetInt` | `Int32` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `GetStationStr` | `String` | `TypedObject obj, String tag` | `Extension` |
| `GetString` | `String` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `GetString` | `String` | `UpdatableTypedObjectWrapper obj, String tag, String def` | `Extension` |
| `GetValue` | `Object` | `UpdatableTypedObjectWrapper obj, String tag` | `Extension` |
| `IsGray` | `Boolean` | `TypedObject obj` | `Extension` |
| `ToAngularSI` | `Void` | `UpdatableTypedObjectWrapper obj, String tag, Double value` | `Extension` |
| `ToLinearSI` | `Void` | `UpdatableTypedObjectWrapper obj, String tag, Double value` | `Extension` |
| `TryGetBoolean` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, ref Boolean value` | `Extension` |
| `TryGetDouble` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, ref Double value` | `Extension` |
| `TryGetInt` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, ref Int32 value` | `Extension` |
| `TryGetString` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, ref String value` | `Extension` |
| `TryGetValue` | `Boolean` | `UpdatableTypedObjectWrapper obj, String tag, ref Object value` | `Extension` |

### `TypedObjectField` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObjectField` |
| **Base Type** | `Topomatic.Visualization.TransactableTypedObjectWrapper` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped, Topomatic.FoundationClasses.Undo.ITransactable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.UpdatableTypedObjectWrapper`
    - `Topomatic.Visualization.TransactableTypedObjectWrapper`
      - `Topomatic.Visualization.TypedObjectField`

#### Constructors (2)

- `.ctor(ITransactable owner, TypedObjectField field)`
- `.ctor(ITransactable owner, TypedObject value)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `InnerValue` | `TypedObject` | `get/set` | No | `` |
| `Value` | `TypedObject` | `get/set` | No | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TypedObjectWrapperPropertyChangedEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObjectWrapperPropertyChangedEventArgs` |
| **Base Type** | `Topomatic.Visualization.TypedObjectWrapperPropertyEventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Visualization.TypedObjectWrapperPropertyEventArgs`
      - `Topomatic.Visualization.TypedObjectWrapperPropertyChangedEventArgs`

#### Constructors (1)

- `.ctor(TypedObject[] tobjs, ImProperty property, Object value)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Value` | `Object` | `get` | No | `` |

### `TypedObjectWrapperPropertyEventArgs` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.TypedObjectWrapperPropertyEventArgs` |
| **Base Type** | `System.EventArgs` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.EventArgs`
    - `Topomatic.Visualization.TypedObjectWrapperPropertyEventArgs`

#### Constructors (1)

- `.ctor(TypedObject[] tobjs, ImProperty property)`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Property` | `ImProperty` | `get` | No | `` |
| `TypedObjects` | `TypedObject[]` | `get` | No | `` |

### `UpdatableTypedObjectWrapper` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.UpdatableTypedObjectWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.FoundationClasses.IUpdatable, Topomatic.FoundationClasses.IWrapped`1[[Topomatic.Visualization.TypedObject, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], Topomatic.FoundationClasses.IWrapped` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `WrappedObject` | `TypedObject` | `get` | No | `` |

#### Instance Methods (6)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `ChangeType` | `Void` | `ImTypeDescriptor dsc` | `` |
| `ChangeValue` | `Void` | `ImPropertyKey[] keys, Object value` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `UpdatableTypedObjectWrapper other` | `` |
| `RemoveProperty` | `Boolean` | `ImPropertyKey[] keys` | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `TypedObject` | `TypedObject value` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |
| `IWrapped`1` | `get_WrappedObject` |
| `IWrapped` | `Topomatic.FoundationClasses.IWrapped.get_WrappedObject` |

### `VectorFrame`1<InterpolatedValue where class>` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+VectorFrame`1` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `nested public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Visualization.GeometryInsertionAnimation+VectorFrame`1`

#### Constructors (1)

- `.ctor(Int32 time, InterpolatedValue value)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ToString` | `String` | `` | `` |

#### Fields (2)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Time` | `Int32` | No | `` | `` |
| `Value` | `InterpolatedValue` | No | `` | `` |

### `VectorsList` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.LinearSolidBuilder+VectorsList` |
| **Base Type** | `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Implements** | `System.Collections.Generic.IList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.ICollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IEnumerable`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]], System.Collections.Generic.IReadOnlyCollection`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.Generic.List`1[[Topomatic.Cad.Foundation.Vector2D, Topomatic.Cad.Foundation, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327]]`
    - `Topomatic.Visualization.LinearSolidBuilder+VectorsList`

#### Constructors (3)

- `.ctor(String uid)`
- `.ctor(IEnumerable<Vector2D> collection, String uid)`
- `.ctor(Int32 capacity, String uid)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Uid` | `String` | `get` | No | `` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CorrectValues` | `Void` | `VectorsList list1, VectorsList list2, ref List<Vector2D> out1, ref List<Vector2D> out2` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VectorTrack`1<T where InterpolatedValue, class, InterpolatedValue>` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.GeometryInsertionAnimation+VectorTrack`1` |
| **Base Type** | `` |
| **Implements** | `, , , System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, , ` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Inheritance Chain

- `System.Object` **(root)**
  - ``
    - `Topomatic.Visualization.GeometryInsertionAnimation+VectorTrack`1`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Interpolation` | `Interpolation` | `get/set` | No | `` |
| `LeftBoundary` | `SplineBoundaryCondition` | `get/set` | No | `` |
| `RightBoundary` | `SplineBoundaryCondition` | `get/set` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `T` | `Int32 time` | `` |
| `Inerpolate` | `T` | `Int32 time` | `` |
| `Optimize` | `Void` | `Int32 index, T eps` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationGroup` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationGroup` |
| **Base Type** | `Topomatic.Visualization.TypedObject` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.VisualizationGroup`

#### Constructors (1)

- `.ctor(VisualizationGroup parent, String name)`

#### Properties (7)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Childs` | `IList<VisualizationGroup>` | `get` | No | `` |
| `Documents` | `ImDocuments` | `get` | No | `` |
| `FullPath` | `String` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Parent` | `VisualizationGroup` | `get/set` | No | `` |
| `Properties` | `ImProperties` | `get` | No | `` |
| `Type` | `ImTypeDescriptor` | `get/set` | No | `` |

#### Instance Methods (8)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FillProperties` | `Void` | `` | `` |
| `GetAllProperties` | `ImProperties` | `` | `` |
| `GetDocument` | `ImDocument` | `String name` | `` |
| `GetDocuments` | `IEnumerable<String>` | `` | `` |
| `GetObjectType` | `ImTypeDescriptor` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `ResetProperties` | `Void` | `` | `` |
| `SetObjectType` | `Void` | `ImTypeDescriptor type` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationMap` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationMap` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor(String content)`
- `.ctor(String source, String content, Predicate<GeometryInsertion> match, IEnumerable<String> rootPath)`

#### Properties (10)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Animation` | `Dictionary<UInt32 GeometryInsertionAnimation>` | `get` | No | `` |
| `AutoGeneratedTextures` | `Dictionary<String AutoGeneratedTexture>` | `get` | No | `` |
| `Cameras` | `List<GeometryCamera>` | `get` | No | `` |
| `Compress` | `Boolean` | `get/set` | No | `` |
| `Group` | `VisualizationGroup` | `get` | No | `` |
| `HandleSeed` | `UInt32` | `get` | No | `` |
| `Leveling` | `Dictionary<String LodCollection>` | `get` | No | `` |
| `RootGroups` | `IEnumerable<VisualizationGroup>` | `get` | No | `` |
| `RootTypes` | `IEnumerable<ImTypeDescriptor>` | `get` | No | `` |
| `WorldPivot` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (54)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddAssembly` | `Void` | `Assembly3d assembly` | `` |
| `AddContent` | `Void` | `String content, String name, Byte[] buffer, Boolean compress` | `` |
| `AddContent` | `Void` | `String content, String name, Stream stream, Boolean compress` | `` |
| `AddEffect` | `Void` | `String name, Byte[] buffer` | `` |
| `AddEffect` | `Void` | `String name, Stream stream` | `` |
| `AddInsertion` | `GeometryInsertion` | `String mesh, Vector3D insertion` | `` |
| `AddMesh` | `Void` | `String name, GeometryModel3D cmesh` | `` |
| `AddModel3DElement` | `Void` | `ImElement element, String name, Matrix matrix` | `` |
| `AddModel3DElement` | `Void` | `ImElement element, String name, Vector3D position, Vector3D scale, Vector3D ox, Vector3D oy` | `` |
| `AddModel3DElement` | `Void` | `ImElement element, String name, Matrix matrix, Dictionary<ImElement String> map, Boolean merge, ImProperties properties, ImDocuments documents` | `` |
| `AddSurface` | `UInt32` | `GeometryModel3D surface, Vector3D insertion` | `` |
| `AddTexture` | `Void` | `String name, Byte[] buffer` | `` |
| `AddTexture` | `Void` | `String name, Stream stream` | `` |
| `BeginGroup` | `Void` | `String name, Boolean merge` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `CommitUpdate` | `Void` | `` | `` |
| `ContainsEffect` | `Boolean` | `String name` | `` |
| `ContainsMesh` | `Boolean` | `String name` | `` |
| `ContainsTexture` | `Boolean` | `String name` | `` |
| `CreateType` | `ImTypeDescriptor` | `ImTypeDescriptor descriptor` | `` |
| `CreateType` | `ImTypeDescriptor` | `String id` | `` |
| `Dispose` | `Void` | `Boolean save` | `` |
| `Dispose` | `Void` | `` | `` |
| `EndGroup` | `Void` | `Boolean removeEmpty` | `` |
| `EndGroup` | `Void` | `` | `` |
| `FindGroup` | `VisualizationGroup` | `String name` | `` |
| `FindType` | `ImTypeDescriptor` | `String id` | `` |
| `GenContentName` | `String` | `String directory, String prefix, String suffix` | `` |
| `GenGroupName` | `String` | `String name` | `` |
| `GenMeshName` | `String` | `String prefix` | `` |
| `GenTextureName` | `String` | `String prefix, String suffix` | `` |
| `GetContent` | `MemoryStream` | `String content, String name` | `` |
| `GetContents` | `IEnumerable<String>` | `String content` | `` |
| `GetEffect` | `MemoryStream` | `String name` | `` |
| `GetEffects` | `IEnumerable<String>` | `` | `` |
| `GetInsertion` | `GeometryInsertion` | `UInt32 handle` | `` |
| `GetInsertions` | `IEnumerable<GeometryInsertion>` | `` | `` |
| `GetInsertionsCount` | `Int32` | `` | `` |
| `GetMesh` | `GeometryModel3D` | `String name` | `` |
| `GetMeshBounds` | `BoundingBox3D` | `String name` | `` |
| `GetMeshes` | `IEnumerable<String>` | `` | `` |
| `GetMeshesCount` | `Int32` | `` | `` |
| `GetSurfaces` | `IEnumerable<UInt32>` | `` | `` |
| `GetTexture` | `MemoryStream` | `String name` | `` |
| `GetTextures` | `IEnumerable<String>` | `` | `` |
| `GroupExists` | `Boolean` | `String name` | `` |
| `Groups` | `IEnumerable<VisualizationGroup>` | `` | `` |
| `IsSurface` | `Boolean` | `String mesh` | `` |
| `RemoveContent` | `Boolean` | `String content, String name` | `` |
| `RemoveEffect` | `Boolean` | `String name` | `` |
| `RemoveInsertion` | `Boolean` | `UInt32 handle` | `` |
| `RemoveMesh` | `Boolean` | `String name` | `` |
| `RemoveTexture` | `Boolean` | `String name` | `` |
| `Types` | `IEnumerable<ImTypeDescriptor>` | `` | `` |

#### Nested Types (1)

- `MapxIncludeHandler` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `VisualizationPropertiesProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationPropertiesProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.VisualizationPropertiesProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Expand` | `Boolean` | `get/set` | No | `` |
| `InstanceDependence` | `Boolean` | `get` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `Void` | `String category, Boolean isreadonly, List<CustomProperty> list, ImProperties properties, Boolean expand, Func<ImPropertyKey[] Object> getter, Action<ImPropertyKey[] Object> setter` | `` |
| `GetStringValue` | `String` | `ImProperty p` | `` |

### `VisualizationPropertiesProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationPropertiesProviderAttribute` |
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
      - `Topomatic.Visualization.VisualizationPropertiesProviderAttribute`

#### Constructors (1)

- `.ctor(Boolean expand)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `VisualizationTypeObjectTypeConverter` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.VisualizationTypeObjectTypeConverter` |
| **Base Type** | `Topomatic.ComponentModel.PropertyTypeConverter` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyTypeConverter`
    - `Topomatic.Visualization.VisualizationTypeObjectTypeConverter`

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
## Namespace: `Topomatic.Visualization.Components`

### `IComponentContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Components.IComponentContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `FixedComponents` | `IEnumerable<ModelComponent>` | `get` | No | `` |
| `Length` | `Double` | `get` | No | `` |
| `LibraryOwner` | `Object` | `get` | No | `` |
| `UserComponents` | `String` | `get/set` | No | `` |

### `ModelComponent` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Components.ModelComponent` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.FoundationClasses.IOwned` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Object owner, ImElement element)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get/set` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Owner` | `Object` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateCopy` | `ModelComponent` | `Object owner` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetComponentsFromString` | `List<ModelComponent>` | `Object owner, String s` | `` |
| `SetComponentsToString` | `String` | `Object owner, List<ModelComponent> components` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Count` | `Double` | No | `` | `` |
| `CountMeasure` | `ComponentCountType` | No | `` | `` |
| `Description` | `String` | No | `` | `` |
| `FilterPropertyTag` | `String` | No | `` | `` |
| `FilterPropertyValue` | `String` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `IOwned` | `get_Owner` |
| `IOwned` | `set_Owner` |

### `ModelComponentEditableWrapper` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Components.ModelComponentEditableWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, Topomatic.ComponentModel.IActivator` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IList list)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `CanCreateInstance` | `Boolean` | `get` | No | `` |
| `Count` | `Int32` | `get` | No | `` |
| `IsChanged` | `Boolean` | `get` | No | `` |
| `IsFixedSize` | `Boolean` | `get` | No | `` |
| `IsReadOnly` | `Boolean` | `get` | No | `` |
| `IsSynchronized` | `Boolean` | `get` | No | `` |
| `Item` | `Object` | `get/set` | No | `` |
| `SyncRoot` | `Object` | `get` | No | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AcceptChanges` | `Void` | `` | `` |
| `Add` | `Int32` | `Object value` | `` |
| `Clear` | `Void` | `` | `` |
| `Contains` | `Boolean` | `Object value` | `` |
| `CopyTo` | `Void` | `Array array, Int32 index` | `` |
| `CreateInstance` | `Object` | `` | `` |
| `GetEnumerator` | `IEnumerator` | `` | `` |
| `IndexOf` | `Int32` | `Object value` | `` |
| `Insert` | `Void` | `Int32 index, Object value` | `` |
| `Remove` | `Void` | `Object value` | `` |
| `RemoveAt` | `Void` | `Int32 index` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ICollection` | `CopyTo` |
| `ICollection` | `get_Count` |
| `ICollection` | `get_SyncRoot` |
| `ICollection` | `get_IsSynchronized` |
| `IEnumerable` | `GetEnumerator` |
| `IList` | `get_Item` |
| `IList` | `set_Item` |
| `IList` | `Add` |
| `IList` | `Contains` |
| `IList` | `Clear` |
| `IList` | `get_IsReadOnly` |
| `IList` | `get_IsFixedSize` |
| `IList` | `IndexOf` |
| `IList` | `Insert` |
| `IList` | `Remove` |
| `IList` | `RemoveAt` |
| `IChangeTracking` | `get_IsChanged` |
| `IChangeTracking` | `AcceptChanges` |
| `IActivator` | `get_CanCreateInstance` |
| `IActivator` | `CreateInstance` |

### `ModelComponentFixedWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Components.ModelComponentFixedWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IList list)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

### `ModelComponentSummaryWrapper` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Components.ModelComponentSummaryWrapper` |
| **Base Type** | `System.Object` |
| **Implements** | `System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(IList list)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetEnumerator` | `IEnumerator` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IEnumerable` | `GetEnumerator` |

---
## Namespace: `Topomatic.Visualization.Constructions`

### `ConstructedModel3dElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.ConstructedModel3dElement` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Visualization.Constructions.ConstructedModel3dElement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ConstructionDocument doc, ImProperties properties)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Document` | `ConstructionDocument` | `get/set` | No | `` |
| `Element` | `ImElement` | `get` | No | `` |
| `IsUpdating` | `Boolean` | `get` | No | `` |

#### Instance Methods (9)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginUpdate` | `Void` | `` | `` |
| `Clone` | `ImElement` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `IsInitializedProperty` | `Boolean` | `String tag` | `Obsolete` |
| `NeedInitializeProperty` | `Void` | `String tag` | `Obsolete` |

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `TypedListValueProperty` | `ImProperty` | `ImAggregates aggregate` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `ConstructedModelStorage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.ConstructedModelStorage` |
| **Base Type** | `System.Object` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Visualization.ITypedObjectCollection` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Custom` | `CustomConstructedModelStorage` | `get` | Yes | `` |
| `LibraryUid` | `String` | `get` | No | `` |
| `Prefix` | `String` | `get` | No | `` |
| `System` | `ConstructedModelStorage` | `get` | Yes | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `FindObject` | `TypedObject` | `String uid` | `` |
| `FindPath` | `String` | `String uid` | `` |
| `FindUids` | `IEnumerable<String>` | `String parentType, Predicate<TypedObject> match` | `` |
| `LoadFromStg` | `Void` | `StgNode node` | `` |
| `SaveToStg` | `Void` | `StgNode node` | `` |

#### Nested Types (1)

- `CustomConstructedModelStorage` (class)

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IStgSerializable` | `SaveToStg` |
| `IStgSerializable` | `LoadFromStg` |
| `ITypedObjectCollection` | `FindUids` |
| `ITypedObjectCollection` | `FindObject` |
| `ITypedObjectCollection` | `FindPath` |
| `ITypedObjectCollection` | `get_LibraryUid` |

### `ConstructionDocument` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.ConstructionDocument` |
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
| `Modules` | `IDictionary<String String>` | `get` | No | `` |
| `Name` | `String` | `get/set` | No | `` |
| `Script` | `String` | `get/set` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `ConstructionDocument` | `` | `` |
| `CreateModel` | `ImElement` | `` | `` |
| `LoadFromFile` | `Void` | `String filename` | `` |
| `LoadFromStream` | `Void` | `Stream stream, String filename` | `` |
| `LoadFromString` | `Void` | `String s, String filename` | `` |

### `CustomConstructedModelStorage` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.ConstructedModelStorage+CustomConstructedModelStorage` |
| **Base Type** | `Topomatic.Visualization.Constructions.ConstructedModelStorage` |
| **Implements** | `Topomatic.Stg.IStgSerializable, Topomatic.Visualization.ITypedObjectCollection, Topomatic.FoundationClasses.IUpdatable` |
| **Visibility** | `nested public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Constructions.ConstructedModelStorage`
    - `Topomatic.Visualization.Constructions.ConstructedModelStorage+CustomConstructedModelStorage`

#### Properties (2)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `IsUpdating` | `Boolean` | `get` | No | `` |
| `LibraryUid` | `String` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `ConstructedModel3dElement obj, String path, String uid` | `` |
| `Add` | `String` | `ConstructedModel3dElement obj, String path` | `` |
| `BeginUpdate` | `Void` | `` | `` |
| `EndUpdate` | `Void` | `` | `` |
| `Remove` | `Void` | `String uid` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `ITypedObjectCollection` | `get_LibraryUid` |
| `IUpdatable` | `BeginUpdate` |
| `IUpdatable` | `EndUpdate` |
| `IUpdatable` | `get_IsUpdating` |

### `GeometryObject3D` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.GeometryObject3D` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetComponents` | `IImElementReference[]` | `Style style, Double tolerance` | `` |
| `GetMesh` | `GeometryModel3D` | `Style style, Double tolerance` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix matrix, Double mapscale` | `` |

### `NestedConstructedElement` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.NestedConstructedElement` |
| **Base Type** | `Topomatic.Visualization.ImElementWrapper` |
| **Implements** | `System.ICloneable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.TypedObject`
    - `Topomatic.Visualization.ImElement`
      - `Topomatic.Visualization.ImViewElement`
        - `Topomatic.Visualization.ImElementWrapper`
          - `Topomatic.Visualization.Constructions.NestedConstructedElement`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(ImElement element)`

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Element` | `ImElement` | `get` | No | `` |

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Equals` | `Boolean` | `Object obj` | `` |
| `GetHashCode` | `Int32` | `` | `` |
| `GetProperties` | `ImProperties` | `` | `` |
| `GetView` | `Boolean` | `Model3DView view, DwgBlock block, Matrix transform, Double mapscale` | `` |
| `SetElement` | `Void` | `ImElement element` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Constructions.Geometry`

### `Style` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Constructions.Geometry.Style` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor(Style owner)`

#### Properties (8)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Ambient` | `Vector3D` | `get` | No | `` |
| `Diffuse` | `Vector3D` | `get` | No | `` |
| `Name` | `String` | `get` | No | `` |
| `Shininess` | `Double` | `get` | No | `` |
| `Specular` | `Vector3D` | `get` | No | `` |
| `SpecularLevel` | `Double` | `get` | No | `` |
| `Transparency` | `Double` | `get` | No | `` |
| `Type` | `String` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Clone` | `Style` | `Style owner` | `` |
| `CreateMaterial` | `String` | `GeometryModel3D model` | `` |
| `GetValue` | `T` | `String key, T def` | `` |

#### Static Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetColored` | `Style` | `Color color, Style owner` | `` |
| `GetPhong` | `Style` | `Cell cell` | `` |

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `kAmbient` | `String` | Yes | `` | `` |
| `kDiffuse` | `String` | Yes | `` | `` |
| `kName` | `String` | Yes | `` | `` |
| `kPhong` | `String` | Yes | `` | `` |
| `kShininess` | `String` | Yes | `` | `` |
| `kSpecular` | `String` | Yes | `` | `` |
| `kSpecularLevel` | `String` | Yes | `` | `` |
| `kTransparency` | `String` | Yes | `` | `` |
| `kType` | `String` | Yes | `` | `` |

---
## Namespace: `Topomatic.Visualization.Design`

### `IConstructionModelHolder` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.IConstructionModelHolder` |
| **Base Type** | `none` |
| **Implements** | `Topomatic.Visualization.ImElementHolder` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `BeginChange` | `Void` | `` | `` |
| `EndChange` | `Void` | `` | `` |

### `ImTypeDescriptorProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.ImTypeDescriptorProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.Design.ImTypeDescriptorProvider`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetProperties` | `CustomProperty[]` | `Object value, PropertyInfo property, Object[] attributes` | `` |

### `ImTypeDescriptorProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.ImTypeDescriptorProviderAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Visualization.Design.ImTypeDescriptorProviderAttribute`

#### Constructors (1)

- `.ctor(String parentId)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `TypedObjectPropertiesExcludeAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.TypedObjectPropertiesExcludeAttribute` |
| **Base Type** | `System.Attribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.Visualization.Design.TypedObjectPropertiesExcludeAttribute`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String[] exclude)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `ExcludePropety` | `Boolean` | `Object wrapper, ImProperty property` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `WrappedTypedObjectProvider` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.WrappedTypedObjectProvider` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProvider` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.ComponentModel.PropertyProvider`
    - `Topomatic.Visualization.Design.WrappedTypedObjectProvider`

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

### `WrappedTypedObjectProviderAttribute` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Design.WrappedTypedObjectProviderAttribute` |
| **Base Type** | `Topomatic.ComponentModel.PropertyProviderAttribute` |
| **Implements** | `System.Runtime.InteropServices._Attribute` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Attribute`
    - `Topomatic.ComponentModel.PropertyProviderAttribute`
      - `Topomatic.Visualization.Design.WrappedTypedObjectProviderAttribute`

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(String parentId)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CreateProvider` | `PropertyProvider` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

---
## Namespace: `Topomatic.Visualization.Geometry`

### `Drawing3DGenerator` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.Drawing3DGenerator` |
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
| `GenerateDrawing` | `Drawing` | `Drawing source, Matrix transform, TypedObject obj` | `` |
| `GenerateModel` | `GeometryModel3D` | `Drawing source, Matrix transform, TypedObject obj` | `` |
| `GenerateTextSolid` | `IEnumerable<DwgSolid>` | `Drawing sourceDrawing, IEnumerable<DwgEntity> sourceEntitys, Matrix transform, TypedObject obj` | `` |

### `GeometricDeviceContext` (class)

**Attributes**: [Obsolete(Message: `Dont'use is old and ugly`)]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.GeometricDeviceContext` |
| **Base Type** | `Topomatic.Cad.Foundation.DeviceContext` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Cad.Foundation.DeviceContext`
    - `Topomatic.Visualization.Geometry.GeometricDeviceContext`

#### Constructors (2)

- `.ctor(Matrix transform)`
- `.ctor(CadFont font, Matrix transform)`

#### Instance Methods (10)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `AddPolygonClip` | `Void` | `Vector2F[] pline, Int32 count` | `` |
| `BeginClip` | `Void` | `` | `` |
| `CalculateArea` | `KeyValuePair<CadColor Double>[]` | `` | `` |
| `Clear` | `Void` | `` | `` |
| `EndClip` | `Void` | `` | `` |
| `Finallized` | `Void` | `GeometryModel3D model, Boolean solidBack` | `` |
| `Finallized` | `Void` | `GeometryModel3D model` | `` |
| `FindFont` | `CadFont` | `Font font` | `` |
| `gString` | `Void` | `Font font, String text` | `` |
| `PrepareDwgSolids` | `IEnumerable<DwgSolid>` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `MapIncludeHandler` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Geometry.MapIncludeHandler` |
| **Base Type** | `Topomatic.Visualization.Geometry.IncludeHandler` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Geometry.IncludeHandler`
    - `Topomatic.Visualization.Geometry.MapIncludeHandler`

#### Constructors (1)

- `.ctor(VisualizationMap map)`

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Open` | `Stream` | `IncludeHandlerType includeType, String filename` | `` |

---
## Namespace: `Topomatic.Visualization.Leveling`

### `Lod` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Leveling.Lod` |
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
| `BoundsInflater` | `BoundingBox3D` | `get/set` | No | `` |
| `Distance` | `Double` | `get/set` | No | `` |
| `Geometry` | `String` | `get/set` | No | `` |
| `LodType` | `LodType` | `get/set` | No | `` |

### `LodCollection` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Leveling.LodCollection` |
| **Base Type** | `System.Collections.CollectionBase` |
| **Implements** | `System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.Collections.CollectionBase`
    - `Topomatic.Visualization.Leveling.LodCollection`

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Item` | `Lod` | `get` | No | `` |

#### Instance Methods (3)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Add` | `Void` | `Lod lod` | `` |
| `LoadFromStg` | `Void` | `StgNode node, String geometry` | `` |
| `SaveToStg` | `Void` | `StgNode node, String geometry` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

### `LodType` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Leveling.LodType` |
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
      - `Topomatic.Visualization.Leveling.LodType`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `FreeImpostor` | `LodType` | Yes | `FreeImpostor` | `` |
| `Geometry` | `LodType` | Yes | `Geometry` | `` |
| `Simplified` | `LodType` | Yes | `Simplified` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `Geometry` | `0` |
| `FreeImpostor` | `1` |
| `Simplified` | `2` |

**Underlying Type**: `System.Int32`

---
## Namespace: `Topomatic.Visualization.Tools`

### `CombineTypedPropertyManager` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.CombineTypedPropertyManager` |
| **Base Type** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Visualization.Tools.TypedPropertyManager`
    - `Topomatic.Visualization.Tools.CombineTypedPropertyManager`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Join` | `Boolean` | `Object obj, TypedObject tobj, ImAggregates value1, ImAggregates value2, Matrix pivot1, Matrix pivot2, ref Nullable<Matrix> pivot, ref ImAggregates value` | `` |
| `Split` | `Boolean` | `Object obj, TypedObject tobj, ImAggregates value, Matrix pivot, Vector3D position, ref Nullable<Matrix> pivot1, ref Nullable<Matrix> pivot2, ref ImAggregates value1, ref ImAggregates value2` | `` |

### `PropertyChangeState` (enum)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.TypedPropertyManagerCollection+PropertyChangeState` |
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
      - `Topomatic.Visualization.Tools.TypedPropertyManagerCollection+PropertyChangeState`

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `Cancel` | `PropertyChangeState` | Yes | `Cancel` | `` |
| `Done` | `PropertyChangeState` | Yes | `Done` | `` |
| `None` | `PropertyChangeState` | Yes | `None` | `` |
| `value__` | `Int32` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|

#### Enum Values

| Name | Value |
|------|-------|
| `None` | `0` |
| `Done` | `1` |
| `Cancel` | `2` |

**Underlying Type**: `System.Int32`

### `TypedPropertyManager` (abstract class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.TypedPropertyManager` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

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

#### Static Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetCurveMatrix` | `Matrix` | `Object obj, Vector3D position` | `` |

### `TypedPropertyManagerCollection` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Visualization.Tools.TypedPropertyManagerCollection` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (1)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Current` | `TypedPropertyManagerCollection` | `get` | Yes | `` |

#### Instance Methods (11)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `CanCombine` | `Boolean` | `Object obj, TypedObject tobj, ImProperty p` | `` |
| `CanDowngrade` | `Boolean` | `Object obj, TypedObject tobj, ImProperty p` | `` |
| `DowngradeProperty` | `Boolean` | `Object obj, TypedObject tobj, ImProperty p, Matrix pivot` | `` |
| `GetGrips` | `IEnumerable<Grip>` | `CadView cadView, Object obj, UpdatableTypedObjectWrapper wrapper, ImProperty property, Matrix pivot` | `` |
| `GetObjectDisjoiner` | `IObjectDisjoiner` | `Object obj, TypedObject tobj, ImProperty p, Matrix pivot` | `` |
| `InitializeProperty` | `PropertyChangeState` | `Object obj, TypedObject tobj, ImProperty p, ref Nullable<Matrix> pivot` | `` |
| `JoinProperty` | `PropertyChangeState` | `Object obj, TypedObject tobj, ImProperty p, ImProperty join, Matrix pivot1, Matrix pivot2, ref Nullable<Matrix> pivot, ref ImAggregates value` | `` |
| `Register` | `Void` | `String type, TypedPropertyManager manager` | `` |
| `Register` | `Void` | `ImTypeDescriptor type, TypedPropertyManager manager` | `` |
| `SplitProperty` | `PropertyChangeState` | `Object obj, TypedObject tobj, ImProperty p, Matrix pivot, Vector3D position, ref Nullable<Matrix> pivot1, ref Nullable<Matrix> pivot2, ref ImAggregates value1, ref ImAggregates value2` | `` |
| `UpdateProperty` | `Boolean` | `Object obj, TypedObject tobj, ImProperty p, Matrix pivot` | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `REGISTER_COLLECTION_BROADCAST` | `String` | Yes | `"register_tprops_collection"` | `` |

#### Nested Types (1)

- `PropertyChangeState` (enum)

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 97 |
| **Classes** | 67 |
| **Interfaces** | 4 |
| **Enums** | 7 |
| **Structs** | 3 |
| **Abstract Classes** | 12 |
| **Static Classes** | 4 |
| **Total Methods** | 374 |
| **Total Properties** | 166 |
| **Total Fields** | 70 |
| **Total Events** | 3 |
| **Total Constructors** | 114 |
| **Nested Types** | 24 |
| **Extension Methods** | 0 |


