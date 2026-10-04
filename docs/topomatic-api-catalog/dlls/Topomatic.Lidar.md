# Topomatic.Lidar

## Assembly Information

| Property | Value |
|----------|-------|
| **Name** | `Topomatic.Lidar` |
| **Version** | `16.0.42.24` |
| **Runtime** | `v2.0.50727` |
| **Full Name** | `Topomatic.Lidar, Version=16.0.42.24, Culture=neutral, PublicKeyToken=e252492115b01327` |
| **Location** | `C:\Program Files\Topomatic Robur Rail 16.0\Topomatic.Lidar.dll` |

---
## Namespace: `Topomatic.Lidar`

### `ChunkedArray`1<T where class>` (class)

**Attributes**: [DefaultMember]

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.ChunkedArray`1` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `True` |

#### Constructors (1)

- `.ctor(Int32 size)`

#### Properties (3)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Buffer` | `T[][]` | `get` | No | `` |
| `Count` | `Int32` | `get/set` | No | `` |
| `Item` | `T` | `get/set` | No | `` |

#### Fields (1)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `CHUNK_SIZE` | `Int32` | Yes | `32000000` | `` |

### `ILidarBufferContainer` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.ILidarBufferContainer` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `GetBuffer` | `LidarBuffer` | `` | `` |

### `IProgressArgs` (interface)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.IProgressArgs` |
| **Base Type** | `none` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `True` |
| **Is Generic** | `False` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Step` | `Void` | `Int64 value` | `` |

### `LiDAR` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.LiDAR` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Properties (4)

| Name | Type | Accessors | Static | Attributes |
|------|------|------------|--------|------------|
| `Bounds` | `BoundingBox3D` | `get/set` | No | `` |
| `Position` | `Vector3D` | `get/set` | No | `` |
| `Records` | `ChunkedArray<PointDataRecord>` | `get/set` | No | `` |
| `Scale` | `Vector3D` | `get/set` | No | `` |

#### Instance Methods (1)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `LidarBuffer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.LidarBuffer` |
| **Base Type** | `System.Object` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (2)

- `.ctor()` - **Default constructor**
- `.ctor(LiDAR model, IProgressArgs args, Int32 classification)`

#### Instance Methods (5)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `FindPoints` | `Void` | `BoundingBox2D bounds, Action<Vector4D> action` | `` |
| `LoadFromFile` | `Void` | `String filename` | `` |
| `SaveToFile` | `Void` | `String filename` | `` |
| `Transform` | `Void` | `Matrix matrix` | `` |

#### Fields (4)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `fullpath` | `String` | No | `` | `` |
| `indexers` | `QuadTreeIndexer[]` | No | `` | `` |
| `maxz` | `Single` | No | `` | `` |
| `minz` | `Single` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `PointDataRecord` (struct)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.PointDataRecord` |
| **Base Type** | `System.ValueType` |
| **Visibility** | `public` |
| **Is Sealed** | `True` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `System.ValueType`
    - `Topomatic.Lidar.PointDataRecord`

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `classification` | `Byte` | No | `` | `` |
| `wight` | `UInt32` | No | `` | `` |
| `x` | `Int32` | No | `` | `` |
| `y` | `Int32` | No | `` | `` |
| `z` | `Int32` | No | `` | `` |

### `QuadTreeIndexer` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.QuadTreeIndexer` |
| **Base Type** | `Topomatic.Lidar.QuadTreeLeaf` |
| **Implements** | `System.IDisposable` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Inheritance Chain

- `System.Object` **(root)**
  - `Topomatic.Lidar.QuadTreeLeaf`
    - `Topomatic.Lidar.QuadTreeIndexer`

#### Instance Methods (2)

| Name | Return Type | Parameters | Attributes |
|------|-------------|------------|------------|
| `Dispose` | `Void` | `` | `` |
| `Transform` | `Void` | `Matrix matrix` | `` |

#### Fields (5)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `clrs` | `ManagedBuffer<Byte>` | No | `` | `` |
| `points` | `ManagedBuffer<Vector3F>` | No | `` | `` |
| `position` | `Vector3D` | No | `` | `` |
| `scale` | `Vector3D` | No | `` | `` |
| `weights` | `ManagedBuffer<Byte>` | No | `` | `` |

#### Interface Implementation

| Interface | Implementation Method |
|-----------|----------------------|
| `IDisposable` | `Dispose` |

### `QuadTreeLeaf` (class)

| Property | Value |
|----------|-------|
| **Full Name** | `Topomatic.Lidar.QuadTreeLeaf` |
| **Base Type** | `System.Object` |
| **Visibility** | `public` |
| **Is Sealed** | `False` |
| **Is Abstract** | `False` |
| **Is Generic** | `False` |

#### Constructors (1)

- `.ctor()` - **Default constructor**

#### Fields (9)

| Name | Type | Static | Value | Attributes |
|------|------|--------|-------|------------|
| `count` | `Int32` | No | `` | `` |
| `leafs` | `QuadTreeLeaf[]` | No | `` | `` |
| `maxx` | `Single` | No | `` | `` |
| `maxy` | `Single` | No | `` | `` |
| `maxz` | `Single` | No | `` | `` |
| `minx` | `Single` | No | `` | `` |
| `miny` | `Single` | No | `` | `` |
| `minz` | `Single` | No | `` | `` |
| `start` | `Int32` | No | `` | `` |

---
## Summary Statistics

| Metric | Count |
|--------|-------|
| **Total Types** | 8 |
| **Classes** | 5 |
| **Interfaces** | 2 |
| **Enums** | 0 |
| **Structs** | 1 |
| **Abstract Classes** | 0 |
| **Static Classes** | 0 |
| **Total Methods** | 10 |
| **Total Properties** | 7 |
| **Total Fields** | 24 |
| **Total Events** | 0 |
| **Total Constructors** | 5 |
| **Nested Types** | 0 |
| **Extension Methods** | 0 |


